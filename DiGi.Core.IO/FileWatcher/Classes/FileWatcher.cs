using DiGi.Core.IO.File.Interfaces;
using DiGi.Core.IO.Interfaces;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Timers;
using Timer = System.Timers.Timer;

namespace DiGi.Core.IO.FileWatcher.Classes
{
    /// <summary>
    /// Monitors any file and reloads its binary content only if the hash has changed.
    /// </summary>
    public class FileWatcher : IDisposable, IIOObject
    {
        private readonly string path;
        private readonly Timer timer;
        private byte[]? bytes;
        private byte[]? hash;
        private DateTime lastWriteTime;

        /// <summary>
        /// Initializes a new instance of the FileWatcher class to monitor changes to the specified file at a given
        /// interval.
        /// </summary>
        /// <param name="path">The full path to the file to be monitored. The file must exist at the time of initialization.</param>
        /// <param name="interval">The interval, in milliseconds, at which the file is checked for changes. The default is 5000 milliseconds.</param>
        /// <exception cref="FileNotFoundException">Thrown if the file specified by path does not exist.</exception>
        public FileWatcher(string path, double interval = 5000)
        {
            if (!System.IO.File.Exists(path))
            {
                throw new FileNotFoundException("Target file not found.", path);
            }

            this.path = path;
            bytes = SafeReadBytes();
            hash = ComputeHash(bytes);

            timer = new Timer(interval);
            timer.Elapsed += OnTimerElapsed;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        public event EventHandler<byte[]>? ContentChanged;

        /// <summary>
        /// Gets the raw bytes of the file content.
        /// </summary>
        public byte[]? Bytes => bytes;

        /// <summary>
        /// Gets or sets the interval in milliseconds between checks for file changes.
        /// </summary>
        public double Interval
        {
            get
            {
                return timer.Interval;
            }

            set
            {
                timer.Interval = value;
            }
        }

        /// <summary>
        /// Gets the path to the file being watched.
        /// </summary>
        public string Path => path;

        /// <summary>
        /// Releases all resources used by the watcher.
        /// </summary>
        public void Dispose()
        {
            timer?.Stop();
            timer?.Dispose();
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Reads the content of the file as an array of strings.
        /// </summary>
        /// <param name="encoding">The encoding to use when reading the file.</param>
        /// <returns>An array of strings containing the lines of the file.</returns>
        public string[]? GetLines(System.Text.Encoding? encoding = null)
        {
            return GetString(encoding)?.Split(["\r\n", "\r", "\n"], StringSplitOptions.None);
        }

        /// <summary>
        /// Reads the content of the file as a single string.
        /// </summary>
        /// <param name="encoding">The encoding to use when reading the file.</param>
        /// <returns>The content of the file as a string.</returns>
        public string GetString(System.Text.Encoding? encoding = null)
        {
            if (bytes == null || bytes.Length == 0)
            {
                return string.Empty;
            }

            // Fallback to UTF8 if no encoding is specified
            System.Text.Encoding targetEncoding = encoding ?? System.Text.Encoding.UTF8;

            return targetEncoding.GetString(bytes);
        }

        private static byte[]? ComputeHash(byte[]? data)
        {
            if (data == null)
            {
                return null;
            }

            using SHA256 sha256 = SHA256.Create();

            return sha256.ComputeHash(data);
        }

        private static bool HashesMatch(byte[]? hash_1, byte[]? hash_2)
        {
            if (hash_1 == null || hash_2 == null)
            {
                return false;
            }

            return hash_1.SequenceEqual(hash_2);
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                // 1. Fast metadata check
                DateTime currentLastWriteTime = System.IO.File.GetLastWriteTime(path);

                // If metadata hasn't changed, exit immediately without touching the file content
                if (currentLastWriteTime <= lastWriteTime)
                {
                    return;
                }

                // 2. Heavy content check (only if timestamp changed)
                byte[]? currentBytes = SafeReadBytes();
                if (currentBytes == null)
                {
                    return;
                }

                byte[]? currentHash = ComputeHash(currentBytes);

                if (!HashesMatch(hash, currentHash))
                {
                    lastWriteTime = currentLastWriteTime;
                    hash = currentHash;
                    bytes = currentBytes;

                    ContentChanged?.Invoke(this, bytes);
                }
                else
                {
                    // Update timestamp anyway to avoid re-hashing if file was saved without changes
                    lastWriteTime = currentLastWriteTime;
                }
            }
            catch (Exception exception)
            {
                // Log error in your CAD/BIM console (e.g., RhinoApp.WriteLine or Rhino.Runtime.HostUtils.ExceptionReport)
                System.Diagnostics.Debug.WriteLine($"Error checking file: {exception.Message}");
            }
        }

        private byte[]? SafeReadBytes()
        {
            try
            {
                // FileShare.ReadWrite is crucial for plugins co-existing with CAD/BIM software
                using FileStream fileStream = new(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                byte[] buffer = new byte[fileStream.Length];

                // A single Read may return fewer bytes than asked for (CA2022) - read until the buffer is full or the file ends.
                int count = 0;
                while (count < buffer.Length)
                {
                    int count_Read = fileStream.Read(buffer, count, buffer.Length - count);
                    if (count_Read == 0)
                    {
                        break;
                    }

                    count += count_Read;
                }

                return buffer;
            }
            catch (IOException)
            {
                // File locked by Revit/Rhino/Excel or another process
                return null;
            }
        }
    }

    /// <summary>
    /// Provides a base implementation for watching a file for changes.
    /// </summary>
    /// <typeparam name="TFile">The type of the file being watched.</typeparam>
    public abstract class FileWatcher<TFile> : FileWatcher where TFile : IFile
    {
        private TFile? file;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileWatcher"/> class.
        /// </summary>
        /// <param name="path">The path to the file to watch.</param>
        /// <param name="interval">The interval in milliseconds between checks for changes.</param>
        public FileWatcher(string path, double interval = 60000)
            : base(path, interval)
        {
            ContentChanged += FileWatcher_ContentChanged;
        }

        /// <summary>
        /// Gets the file object being watched.
        /// </summary>
        public TFile? File
        {
            get
            {
                file ??= CreateFile();

                return file;
            }
        }

        protected abstract TFile CreateFile();

        private void FileWatcher_ContentChanged(object sender, byte[] e)
        {
            file = default;
        }
    }
}