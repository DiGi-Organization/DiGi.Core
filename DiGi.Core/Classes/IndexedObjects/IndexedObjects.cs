using DiGi.Core.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a generic collection of objects mapped to integer indices.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    public class IndexedObjects<T> : SerializableObject, IIndexedObjects<T>
    {
        private readonly SortedDictionary<int, T?> sortedDictionary = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedObjects{T}"/> class.
        /// </summary>
        public IndexedObjects()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedObjects{T}"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize the collection.</param>
        public IndexedObjects(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedObjects{T}"/> class from a collection of values.
        /// </summary>
        /// <param name="values">The collection of values to initialize the collection.</param>
        public IndexedObjects(IEnumerable<T>? values)
        {
            if (values != null)
            {
                int index = 0;
                foreach (T value in values)
                {
                    sortedDictionary[index] = value;
                    index++;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedObjects{T}"/> class from a collection of values starting at a specified index.
        /// </summary>
        /// <param name="values">The collection of values to initialize the collection.</param>
        /// <param name="startIndex">The starting index for the collection of values.</param>
        public IndexedObjects(IEnumerable<T>? values, int startIndex)
        {
            if (values != null)
            {
                int index = startIndex;
                foreach (T value in values)
                {
                    sortedDictionary[index] = value;
                    index++;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedObjects{T}"/> class from a sorted dictionary of indices and values.
        /// </summary>
        /// <param name="sortedDictionary">The sorted dictionary containing indices and values to initialize the collection.</param>
        public IndexedObjects(SortedDictionary<int, T?>? sortedDictionary)
        {
            if (sortedDictionary != null)
            {
                foreach (KeyValuePair<int, T?> keyValuePair in sortedDictionary)
                {
                    this.sortedDictionary[keyValuePair.Key] = keyValuePair.Value;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedObjects{T}"/> class by copying another instance.
        /// </summary>
        /// <param name="indexedObjects">The existing instance to copy from.</param>
        public IndexedObjects(IndexedObjects<T>? indexedObjects)
            : this(indexedObjects?.sortedDictionary)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedObjects{T}"/> class with a range of indices set to the same value.
        /// </summary>
        /// <param name="startIndex">The starting index of the range.</param>
        /// <param name="count">The number of elements in the range.</param>
        /// <param name="value">The value to assign to each element in the range.</param>
        public IndexedObjects(int startIndex, int count, T? value)
        {
            int end = startIndex + count;
            for (int i = startIndex; i < end; i++)
            {
                sortedDictionary[i] = value;
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
                return sortedDictionary.Count;
            }
        }

        /// <summary>
        /// Gets the collection of all indices currently stored.
        /// </summary>
        [JsonIgnore]
        public IEnumerable<int>? Keys
        {
            get
            {
                return sortedDictionary?.Keys;
            }
        }

        /// <summary>
        /// Gets the collection of all values currently stored.
        /// </summary>
        [JsonIgnore]
        public IEnumerable<T?>? Values
        {
            get
            {
                return sortedDictionary?.Values;
            }
        }

        /// <summary>
        /// Gets or sets the value associated with the specified index.
        /// </summary>
        /// <param name="index">The index of the element to get or set.</param>
        /// <returns>The value at the specified index, or the default value if the index is not found.</returns>
        [JsonIgnore]
        public T? this[int index]
        {
            get
            {
                if (!sortedDictionary.TryGetValue(index, out T? value))
                {
                    return default;
                }

                return value;
            }

            set
            {
                sortedDictionary[index] = value;
            }
        }

        /// <summary>
        /// Adds or updates a value at the specified index. Returns true if the operation succeeded.
        /// </summary>
        /// <param name="index">The index at which to add or update the value.</param>
        /// <param name="value">The value to add or update.</param>
        /// <returns>True if the operation succeeded; otherwise, false.</returns>
        public bool Add(int index, T? value)
        {
            sortedDictionary[index] = value;
            return true;
        }

        /// <summary>
        /// Adds or updates values across a specified range of indices. Returns true if the operation succeeded.
        /// </summary>
        /// <param name="range">The range of indices to update.</param>
        /// <param name="value">The value to add or update.</param>
        /// <returns>True if the operation succeeded; otherwise, false.</returns>
        public bool Add(Range<int> range, T? value)
        {
            for (int i = range.Min; i <= range.Max; i++)
            {
                sortedDictionary[i] = value;
            }

            return true;
        }

        /// <summary>
        /// Determines whether the collection contains an element at the specified index.
        /// </summary>
        /// <param name="index">The index to check for existence.</param>
        /// <returns>True if the collection contains an element at the specified index; otherwise, false.</returns>
        public bool ContainsIndex(int index)
        {
            if (index == -1)
            {
                return false;
            }

            foreach (int index_Temp in sortedDictionary.Keys)
            {
                if (index == index_Temp)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Populates the current instance from a JSON object. Returns true if successful.
        /// </summary>
        /// <param name="jsonObject">The JSON object to populate the instance from.</param>
        /// <returns>True if the population was successful; otherwise, false.</returns>
        public override bool FromJsonObject(JsonObject? jsonObject)
        {
            if (jsonObject is null)
            {
                return false;
            }

            bool result = base.FromJsonObject(jsonObject);
            if (!result)
            {
                return result;
            }

            if (jsonObject.TryGetPropertyValue(nameof(Values), out JsonNode? jsonNode) && jsonNode != null)
            {
                JsonArray jsonArray = jsonNode.AsArray();
                foreach (JsonNode? jsonNode_Temp in jsonArray)
                {
                    if (jsonNode_Temp is not JsonObject jsonObject_Temp)
                    {
                        continue;
                    }

                    if (!jsonObject_Temp.TryGetPropertyValue("Index", out JsonNode? jsonNode_Index) || !jsonObject_Temp.TryGetPropertyValue("Value", out JsonNode? jsonNode_Value))
                    {
                        continue;
                    }

                    if (jsonNode_Index is null)
                    {
                        continue;
                    }

                    object? value = Query.Value(jsonNode_Value, typeof(T));
                    if (value is T t)
                    {
                        sortedDictionary[(int)jsonNode_Index] = t;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection of values.
        /// </summary>
        /// <returns>An enumerator that iterates through the collection.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            if (sortedDictionary?.Values is null)
            {
                return Enumerable.Empty<T>().GetEnumerator();
            }

            return sortedDictionary.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Gets the highest index present in the collection, or null if empty.
        /// </summary>
        /// <returns>The maximum index present in the collection, or null if the collection is empty.</returns>
        public int? GetMaxIndex()
        {
            IEnumerable<int>? keys = Keys;
            if (keys == null || !keys.Any())
            {
                return null;
            }

            return keys.Max(x => x);
        }

        /// <summary>
        /// Gets the lowest index present in the collection, or null if empty.
        /// </summary>
        /// <returns>The minimum index present in the collection, or null if the collection is empty.</returns>
        public int? GetMinIndex()
        {
            IEnumerable<int>? keys = Keys;
            if (keys == null || !keys.Any())
            {
                return null;
            }

            return keys.Min(x => x);
        }

        /// <summary>
        /// Retrieves the value at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the element to get.</param>
        /// <returns>The value at the specified index, or null if not found.</returns>
        public T? GetValue(int index)
        {
            return this[index];
        }

        /// <summary>
        /// Retrieves a list of values within the specified range.
        /// </summary>
        /// <param name="range">The range of indices from which to retrieve values.</param>
        /// <returns>A list of values within the specified range, or null if no values are found.</returns>
        public List<T?>? GetValues(Range<int>? range)
        {
            if (range is null)
            {
                return null;
            }

            List<T?> result = [];
            for (int i = range.Min; i <= range.Max; i++)
            {
                if (!sortedDictionary.TryGetValue(i, out T? value))
                {
                    value = default;
                }

                result.Add(value);
            }

            return result;
        }

        /// <summary>
        /// Retrieves a list of values within the specified range, with an option to bound the results.
        /// </summary>
        /// <param name="range">The range of indices from which to retrieve values.</param>
        /// <param name="bounded">A value indicating whether the results should be bounded.</param>
        /// <returns>A list of values within the specified range, or null if no values are found.</returns>
        public List<T?>? GetValues(Range<int>? range, bool bounded)
        {
            if (range is null)
            {
                return null;
            }

            if (!bounded)
            {
                return GetValues(range);
            }

            int? minIndex = GetMinIndex();
            if (minIndex is null)
            {
                return null;
            }

            int? maxIndex = GetMaxIndex();
            if (maxIndex is null)
            {
                return null;
            }

            Range<int> range_Temp = new(minIndex.Value, maxIndex.Value);

            List<T?> result = [];
            for (int i = range.Min; i <= range.Max; i++)
            {
                int index = Query.BoundedIndex(range_Temp, i);

                if (!sortedDictionary.TryGetValue(index, out T? value))
                {
                    value = default;
                }

                result.Add(value);
            }

            return result;
        }

        /// <summary>
        /// Removes the element at the specified index. Returns true if the element was found and removed.
        /// </summary>
        /// <param name="index">The zero-based index of the element to remove.</param>
        /// <returns>True if the element was successfully found and removed; otherwise, false.</returns>
        public bool Remove(int index)
        {
            return sortedDictionary.Remove(index);
        }

        /// <summary>
        /// Serializes the current instance into a JSON object.
        /// </summary>
        /// <returns>A <see cref="JsonObject"/> representation of the current instance, or null.</returns>
        public override JsonObject? ToJsonObject()
        {
            JsonObject? result = base.ToJsonObject();
            if (result == null)
            {
                return null;
            }

            if (sortedDictionary != null)
            {
                JsonArray jsonArray = [];
                foreach (KeyValuePair<int, T?> keyValuePair in sortedDictionary)
                {
                    JsonObject jsonObject_Temp = new()
                    {
                        { "Index", keyValuePair.Key },
                        { "Value", Create.JsonNode(keyValuePair.Value) }
                    };

                    jsonArray.Add(jsonObject_Temp);
                }

                result[nameof(Values)] = jsonArray;
            }

            return result;
        }

        /// <summary>
        /// Attempts to get the value associated with the specified index. Returns true if found.
        /// </summary>
        /// <param name="index">The zero-based index of the element to get.</param>
        /// <param name="result">When this method returns, contains the value associated with the specified index, if found; otherwise, the default value of the element type.</param>
        /// <returns>True if the element was found; otherwise, false.</returns>
        public bool TryGetValue(int index, out T? result)
        {
            if (!sortedDictionary.TryGetValue(index, out T? value))
            {
                result = default;
                return false;
            }

            result = value;
            return true;
        }
    }
}