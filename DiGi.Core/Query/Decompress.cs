using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Source: https://stackoverflow.com/questions/7343465/compression-decompression-string-with-c-sharp
        /// </summary>
        /// <param name="string">Compressed string to be decompressed</param>
        /// <returns>Decompressed string</returns>
        public static string? Decompress(this string? @string)
        {
            if (@string == null)
            {
                return null;
            }

            byte[] gZipBuffer = System.Convert.FromBase64String(@string);

            using MemoryStream memoryStream = new();

            int dataLength = BitConverter.ToInt32(gZipBuffer, 0);
            memoryStream.Write(gZipBuffer, 4, gZipBuffer.Length - 4);

            byte[] buffer = new byte[dataLength];

            memoryStream.Position = 0;
            using (GZipStream gZipStream = new(memoryStream, CompressionMode.Decompress))
            {
                // A single Read may return fewer bytes than asked for (CA2022) - read until the buffer is full or the stream ends.
                int count = 0;
                while (count < buffer.Length)
                {
                    int count_Read = gZipStream.Read(buffer, count, buffer.Length - count);
                    if (count_Read == 0)
                    {
                        break;
                    }

                    count += count_Read;
                }
            }

            return Encoding.UTF8.GetString(buffer);
        }

        /// <summary>
        /// Decompresses a Base64 encoded string back into a collection of ISerializableObjects.
        /// </summary>
        /// <typeparam name="T">The type of the serializable objects.</typeparam>
        /// <param name="string">The string to decompress.</param>
        /// <returns>A list of deserialized objects, or null if decompression fails.</returns>
        public static List<T>? Decompress<T>(this string? @string) where T : ISerializableObject
        {
            if (string.IsNullOrWhiteSpace(@string))
            {
                return null;
            }

            string? string_Decompress = Decompress(@string);
            if (string.IsNullOrWhiteSpace(@string))
            {
                return null;
            }

            return Convert.ToDiGi<T>(string_Decompress);
        }
    }
}