using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Classes;
using DiGi.Core.IO.File.Interfaces;
using DiGi.Core.IO.Interfaces;
using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.File.Classes
{
    /// <summary>
    /// Base class for files that support metadata and persistence via Zip archives.
    /// </summary>
    public abstract class File : SerializableObject, IFile
    {
        private bool disposed;

        [JsonInclude, JsonPropertyName(nameof(MetadataStorage)), Description("MetadataStorage")]
        private MetadataStorage metadataStorage = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="File"/> class with the specified path.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public File(string? path)
            : base()
        {
            metadataStorage.SetMetadata(new FileMetadata(GetType(), path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="File"/> class by cloning another file's metadata.
        /// </summary>
        /// <param name="file">The source file to clone metadata from.</param>
        public File(File? file)
            : base(file)
        {
            if (file != null)
            {
                metadataStorage = file.metadataStorage.Clone<MetadataStorage>() ?? new();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="File"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing file data.</param>
        public File(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the metadata storage of the file.
        /// </summary>
        [JsonIgnore]
        internal MetadataStorage MetadataStorage
        {
            get
            {
                return metadataStorage;
            }
        }

        /// <summary>
        /// Gets or sets the path of the file.
        /// </summary>
        public string? Path
        {
            get
            {
                return GetMetadata<FileMetadata>()?.Path;
            }

            set
            {
                FileMetadata? fileMetadata = GetMetadata<FileMetadata>();
                fileMetadata ??= new FileMetadata(GetType());

                fileMetadata.Path = value;
                metadataStorage.SetMetadata(fileMetadata);
            }
        }

        /// <summary>
        /// Releases all resources used by the file.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Retrieves metadata of the specified type from the file's metadata storage.
        /// </summary>
        /// <typeparam name="TMetadata">The type of metadata to retrieve.</typeparam>
        /// <returns>The metadata of type <typeparamref name="TMetadata"/> if found; otherwise, null.</returns>
        public TMetadata? GetMetadata<TMetadata>() where TMetadata : IMetadata
        {
            if (metadataStorage == null)
            {
                return default;
            }

            return metadataStorage.GetMetadata<TMetadata>();
        }

        /// <summary>
        /// Opens the file using its current path.
        /// </summary>
        /// <returns>True if the file was opened successfully; otherwise, false.</returns>
        public virtual bool Open()
        {
            string? path = Path;
            if (string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            if (!System.IO.File.Exists(path))
            {
                return false;
            }

            using ZipArchive zipArchive = ZipFile.OpenRead(path);

            ZipArchiveEntry zipArchiveEntry;

            zipArchiveEntry = zipArchive.GetEntry(IO.Constants.EntryName.MetadataStorage);
            if (zipArchiveEntry != null)
            {
                using StreamReader streamReader = new(zipArchiveEntry.Open());
                MetadataStorage? metadataStorage = Convert.ToDiGi<MetadataStorage>(streamReader.ReadToEnd())?.FirstOrDefault();

                this.metadataStorage = metadataStorage ?? new();
                Path = path;
            }

            return true;
        }

        /// <summary>
        /// Opens the file from the specified path.
        /// </summary>
        /// <param name="path">The path of the file to open.</param>
        /// <returns>True if the file was opened successfully; otherwise, false.</returns>
        public bool Open(string? path)
        {
            Path = path;

            return Open();
        }

        /// <summary>
        /// Saves the file's metadata and updates its modification date.
        /// </summary>
        /// <returns>True if the save operation was successful; otherwise, false.</returns>
        public virtual bool Save()
        {
            FileMetadata? fileMetadata = GetMetadata<FileMetadata>();
            fileMetadata ??= new FileMetadata(GetType());

            string? path = fileMetadata.Path;
            if (string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            fileMetadata.Modified = DateTime.Now;

            metadataStorage.SetMetadata(fileMetadata);

            string? json = Convert.ToSystem_String((ISerializableObject)metadataStorage);
            if (string.IsNullOrWhiteSpace(json))
            {
                return false;
            }

            using ZipArchive zipArchive = ZipFile.Open(path, ZipArchiveMode.Update);

            ZipArchiveEntry zipArchiveEntry = zipArchive.GetEntry(IO.Constants.EntryName.MetadataStorage);
            zipArchiveEntry?.Delete();

            zipArchiveEntry = zipArchive.CreateEntry(IO.Constants.EntryName.MetadataStorage);

            using Stream stream = zipArchiveEntry.Open();
            using StreamWriter streamWriter = new(stream);
            streamWriter.Write(json);

            return true;
        }

        /// <summary>
        /// Saves the file to the specified path.
        /// </summary>
        /// <param name="path">The path where the file should be saved.</param>
        /// <returns>True if the file was saved successfully; otherwise, false.</returns>
        public bool SaveAs(string? path)
        {
            Path = path;
            return Save();
        }

        /// <summary>
        /// Sets a custom metadata object for the file.
        /// </summary>
        /// <param name="metadata">The metadata object to set.</param>
        public void SetMetadata(IMetadata? metadata)
        {
            if (metadata == null || metadata is FileMetadata)
            {
                return;
            }

            metadataStorage.SetMetadata(metadata);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // dispose managed state (managed objects).
                }

                // free unmanaged resources (unmanaged objects) and override a finalizer below.
                // set large fields to null.

                //metadataStorage = null;

                disposed = true;
            }
        }
    }
}