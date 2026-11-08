using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Security.Cryptography;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Computes the MD5 checksum of a string.
        /// </summary>
        /// <param name="value">The string to compute the checksum for.</param>
        /// <returns>A string representing the MD5 checksum, or null if the input is null.</returns>
        [SuppressMessage("Security", "CA5351:Do Not Use Broken Cryptographic Algorithms", Justification = "Not security: a content checksum compared with stored values; another algorithm would invalidate them.")]
        public static string? Checksum(this string? value)
        {
            if (value == null)
            {
                return null;
            }

            byte[]? bytes = null;

            using (MD5 mD5 = MD5.Create())
            {
                using MemoryStream memoryStream = new();

                StreamWriter streamWriter = new(memoryStream);

                streamWriter.Write(value);
                streamWriter.Flush();
                memoryStream.Position = 0;

                bytes = mD5.ComputeHash(memoryStream);
            }

            return BitConverter.ToString(bytes);
        }
    }
}