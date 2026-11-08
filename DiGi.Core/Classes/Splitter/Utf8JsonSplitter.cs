using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Splits serializable objects into batches by serialized byte array size, emitting each batch's UTF-8 JSON array alongside its objects.
    /// <para>Unlike <see cref="MemorySizeSplitter{TSerializableObject}"/>, which serializes every object once merely to measure it and then leaves the caller to serialize the whole batch a second time, this splitter serializes each object exactly once and keeps the bytes. An object that does not fit the current batch is carried into the next one already serialized, so it is never converted twice either.</para>
    /// </summary>
    /// <typeparam name="TSerializableObject">The type of the serializable object.</typeparam>
    public class Utf8JsonSplitter<TSerializableObject> where TSerializableObject : ISerializableObject
    {
        private const byte ArrayEnd = (byte)']';
        private const byte ArrayStart = (byte)'[';
        private const byte Separator = (byte)',';

        private static readonly byte[] Null = [(byte)'n', (byte)'u', (byte)'l', (byte)'l'];

        private readonly List<TSerializableObject>? serializableObjects;

        private int index;

        private bool hasPending;
        private byte[]? pendingUtf8Json;
        private TSerializableObject? pendingSerializableObject;

        /// <summary>
        /// Initializes a new instance of the <see cref="Utf8JsonSplitter{TSerializableObject}"/> class with the specified objects.
        /// </summary>
        /// <param name="serializableObjects">The collection of objects to be split.</param>
        public Utf8JsonSplitter(IEnumerable<TSerializableObject>? serializableObjects)
        {
            this.serializableObjects = serializableObjects is null ? null : [.. serializableObjects];
        }

        /// <summary>
        /// Returns the next batch of objects whose serialized size does not exceed <paramref name="maxSize"/>, together with the UTF-8 JSON array representing them.
        /// <para>A batch always contains at least one object, so a single object larger than <paramref name="maxSize"/> is emitted on its own rather than dropped. Returns null when no objects remain.</para>
        /// </summary>
        /// <param name="maxSize">The maximum serialized size, in bytes, allowed for the next batch.</param>
        /// <returns>The next batch, or null if no more objects are available.</returns>
        public Utf8JsonBatch<TSerializableObject>? Next(long maxSize)
        {
            if (!TryPeek(out _, out _))
            {
                return null;
            }

            List<TSerializableObject> serializableObjects_Batch = [];

            MemoryStream memoryStream = new();
            memoryStream.WriteByte(ArrayStart);

            long size = 0;

            while (TryPeek(out TSerializableObject? serializableObject, out byte[]? utf8Json))
            {
                if (size + utf8Json!.Length > maxSize && serializableObjects_Batch.Count != 0)
                {
                    // Leave it pending - it starts the next batch without being serialized again.
                    break;
                }

                if (serializableObjects_Batch.Count != 0)
                {
                    memoryStream.WriteByte(Separator);
                    size++;
                }

                memoryStream.Write(utf8Json, 0, utf8Json.Length);
                size += utf8Json.Length;

                serializableObjects_Batch.Add(serializableObject!);

                Consume();
            }

            memoryStream.WriteByte(ArrayEnd);

            return new Utf8JsonBatch<TSerializableObject>(serializableObjects_Batch, memoryStream.ToArray());
        }

        /// <summary>
        /// Resets the internal iterator to the beginning.
        /// </summary>
        public void Reset()
        {
            index = 0;
            Consume();
        }

        /// <summary>
        /// Discards the pending object so the next peek advances to the following one.
        /// </summary>
        private void Consume()
        {
            hasPending = false;
            pendingUtf8Json = null;
            pendingSerializableObject = default;
        }

        /// <summary>
        /// Gets the next object and its serialized bytes without consuming it, serializing it at most once.
        /// </summary>
        /// <param name="serializableObject">When this method returns, contains the next object.</param>
        /// <param name="utf8Json">When this method returns, contains the UTF-8 JSON of the next object.</param>
        /// <returns>True if an object is available; otherwise, false.</returns>
        private bool TryPeek(out TSerializableObject? serializableObject, out byte[]? utf8Json)
        {
            if (hasPending)
            {
                serializableObject = pendingSerializableObject;
                utf8Json = pendingUtf8Json;
                return true;
            }

            if (serializableObjects is null || index >= serializableObjects.Count)
            {
                serializableObject = default;
                utf8Json = null;
                return false;
            }

            serializableObject = serializableObjects[index];

            // A null element serializes to a JSON null, matching Convert.ToSystem_String's payload exactly.
            utf8Json = Convert.ToSystem_Bytes(serializableObject) ?? Null;

            pendingSerializableObject = serializableObject;
            pendingUtf8Json = utf8Json;
            hasPending = true;

            index++;

            return true;
        }
    }
}