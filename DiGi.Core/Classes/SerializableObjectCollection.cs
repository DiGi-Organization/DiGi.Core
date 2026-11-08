using DiGi.Core.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// A serializable collection of objects implementing ISerializableObject.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    public class SerializableObjectCollection<T> : SerializableObject, ICollection<T> where T : ISerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Values))]
        private readonly List<T> values = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableObjectCollection{T}"/> class.
        /// </summary>
        public SerializableObjectCollection()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableObjectCollection{T}"/> class from an enumerable of serializable objects.
        /// </summary>
        /// <param name="serializableObjects">The enumerable of serializable objects to initialize the collection with.</param>
        public SerializableObjectCollection(IEnumerable<T>? serializableObjects)
        {
            if (serializableObjects != null)
            {
                values.AddRange(serializableObjects);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableObjectCollection{T}"/> class by copying another collection.
        /// </summary>
        /// <param name="serializableObjectCollection">The source collection to copy from.</param>
        public SerializableObjectCollection(SerializableObjectCollection<T>? serializableObjectCollection)
            : base(serializableObjectCollection)
        {
            if (serializableObjectCollection?.values != null)
            {
                values = [.. serializableObjectCollection.values];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableObjectCollection{T}"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize the collection from.</param>
        public SerializableObjectCollection(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the list of elements contained in the collection.
        /// </summary>
        [JsonIgnore]
        public IList<T> Values
        {
            get
            {
                return values;
            }
        }

        /// <summary>
        /// Gets the number of elements contained in the collection.
        /// </summary>
        [JsonIgnore]
        public int Count
        {
            get
            {
                return values == null ? 0 : values.Count;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the collection is read-only.
        /// </summary>
        [JsonIgnore]
        public bool IsReadOnly => false;

        /// <summary>
        /// Gets or sets the element at the specified index of the collection.
        /// </summary>
        /// <param name="index">The zero-based index of the element to get or set.</param>
        /// <returns>The element at the specified index.</returns>
        [JsonIgnore]
        public T this[int index]
        {
            get
            {
                return values[index];
            }

            set
            {
                values[index] = value;
            }
        }

        /// <summary>
        /// Explicitly converts a <see cref="SerializableObjectCollection{T}"/> to a <see cref="List{T}"/>.
        /// </summary>
        /// <param name="serializableObjectCollection">The serializable object collection to convert into a list.</param>
        /// <returns>A new instance of <see cref="List{T}"/> containing the elements from the source collection, or null if the input collection is null.</returns>
        public static explicit operator List<T>?(SerializableObjectCollection<T>? serializableObjectCollection)
        {
            if (serializableObjectCollection == null)
            {
                return null;
            }

            return serializableObjectCollection.values == null ? [] : [.. serializableObjectCollection.values];
        }

        /// <summary>
        /// Explicitly converts a <see cref="List{T}"/> to a <see cref="SerializableObjectCollection{T}"/>.
        /// </summary>
        /// <param name="serializableObjects">The list of objects to convert into a collection.</param>
        /// <returns>A new instance of <see cref="SerializableObjectCollection{T}"/> containing the provided elements, or null if the input list is null.</returns>
        public static explicit operator SerializableObjectCollection<T>?(List<T>? serializableObjects)
        {
            if (serializableObjects == null)
            {
                return null;
            }

            return [.. serializableObjects];
        }

        /// <summary>
        /// Explicitly converts an array of type <typeparamref name="T"/> to a <see cref="SerializableObjectCollection{T}"/>.
        /// </summary>
        /// <param name="serializableObjects">The array of objects to convert into a collection.</param>
        /// <returns>A new instance of <see cref="SerializableObjectCollection{T}"/> containing the provided elements, or null if the input array is null.</returns>
        public static explicit operator SerializableObjectCollection<T>?(T[]? serializableObjects)
        {
            if (serializableObjects == null)
            {
                return null;
            }

            return [.. serializableObjects];
        }

        /// <summary>
        /// Explicitly converts the <see cref="SerializableObjectCollection{T}"/> to an array of type <typeparamref name="T"/>.
        /// </summary>
        /// <param name="serializableObjectCollection">The collection instance to convert.</param>
        /// <returns>An array containing the elements of the collection, or null if the provided collection is null.</returns>
        public static explicit operator T[]?(SerializableObjectCollection<T>? serializableObjectCollection)
        {
            if (serializableObjectCollection == null)
            {
                return null;
            }

            return serializableObjectCollection.values == null ? [] : [.. serializableObjectCollection.values];
        }

        /// <summary>
        /// Adds an item to the collection.
        /// </summary>
        /// <param name="serializableObject">The object to add to the collection.</param>
        public void Add(T serializableObject)
        {
            values.Add(serializableObject);
        }

        /// <summary>
        /// Removes all items from the collection.
        /// </summary>
        public void Clear()
        {
            values?.Clear();
        }

        /// <summary>
        /// Determines whether the collection contains a specific value.
        /// </summary>
        /// <param name="item">The object to locate in the collection.</param>
        /// <returns>True if the item is found; otherwise, false.</returns>
        public bool Contains(T? item)
        {
            if (values == null || item == null)
            {
                return false;
            }

            return values.Contains(item);
        }

        /// <summary>
        /// Copies the elements of the collection to an Array, starting at a particular Array index.
        /// </summary>
        /// <param name="array">The one-dimensional Array that is the destination of the elements.</param>
        /// <param name="arrayIndex">The zero-based index in array at which copying begins.</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            if (values == null)
            {
                return;
            }

            if (array == null)
            {
                throw new System.ArgumentNullException(nameof(array));
            }

            if (arrayIndex < 0)
            {
                throw new System.ArgumentOutOfRangeException(nameof(arrayIndex));
            }

            if (array.Length - arrayIndex < values.Count)
            {
                throw new System.ArgumentException("The number of elements in collection is greater than the available space from arrayIndex to the end of the destination array");
            }

            for (int i = 0; i < values.Count; i++)
            {
                array[i + arrayIndex] = values[i];
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return values?.GetEnumerator() ?? Enumerable.Empty<T>().GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An IEnumerator object that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Removes the first occurrence of a specific object from the collection.
        /// </summary>
        /// <param name="item">The object to remove from the collection.</param>
        /// <returns>True if item was successfully removed from the collection; otherwise, false.</returns>
        public bool Remove(T? item)
        {
            if (values == null || item == null)
            {
                return false;
            }

            return values.Remove(item);
        }

        /// <summary>
        /// Removes the element at the specified index of the collection.
        /// </summary>
        /// <param name="index">The zero-based index of the element to remove.</param>
        public void RemoveAt(int index)
        {
            values.RemoveAt(index);
        }
    }

    /// <summary>
    /// Non-generic version of SerializableObjectCollection for handling a collection of ISerializableObjects.
    /// </summary>
    public class SerializableObjectCollection : SerializableObjectCollection<ISerializableObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableObjectCollection"/> class.
        /// </summary>
        public SerializableObjectCollection()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableObjectCollection"/> class from an enumerable of ISerializableObject instances.
        /// </summary>
        /// <param name="serializableObjects">The enumerable of serializable objects to initialize the collection with.</param>
        public SerializableObjectCollection(IEnumerable<ISerializableObject>? serializableObjects)
            : base(serializableObjects)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableObjectCollection"/> class by copying another collection.
        /// </summary>
        /// <param name="serializableObjectCollection">The source collection to copy from.</param>
        public SerializableObjectCollection(SerializableObjectCollection? serializableObjectCollection)
            : base(serializableObjectCollection)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableObjectCollection"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize the collection from.</param>
        public SerializableObjectCollection(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public override ISerializableObject? Clone()
        {
            return new SerializableObjectCollection(this);
        }
    }
}