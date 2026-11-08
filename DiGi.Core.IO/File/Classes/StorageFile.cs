using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.File.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.File.Classes
{
    /// <summary>
    /// Represents a file used for storing and managing serializable objects.
    /// </summary>
    /// <typeparam name="TSerializableObject">The type of serializable object that this storage file manages.</typeparam>
    public class StorageFile<TSerializableObject> : File, IValuesFile<TSerializableObject> where TSerializableObject : ISerializableObject
    {
        [JsonIgnore]
        private Dictionary<UniqueReference, TSerializableObject?>? dictionary = null;

        [JsonIgnore]
        private bool disposed = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageFile"/> class using the specified file path.
        /// </summary>
        /// <param name="path">The system path to the storage file.</param>
        public StorageFile(string? path)
            : base(path)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageFile"/> class from an existing typed storage file.
        /// </summary>
        /// <param name="storageFile">The existing typed storage file to initialize from.</param>
        public StorageFile(StorageFile<TSerializableObject>? storageFile)
            : base(storageFile)
        {
            if (storageFile != null)
            {
                Values = storageFile.Values;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageFile"/> class from the provided JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the storage file.</param>
        public StorageFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the total number of elements contained in the storage file.
        /// </summary>
        [JsonIgnore]
        public int Count
        {
            get
            {
                HashSet<UniqueReference>? uniqueReferences = GetUniqueReferences();
                if (uniqueReferences == null)
                {
                    return -1;
                }

                return uniqueReferences.Count;
            }
        }

        /// <summary>
        /// Gets all stored values as a collection of serializable objects.
        /// </summary>
        [JsonInclude]
        public IEnumerable<TSerializableObject?>? Values
        {
            get
            {
                return GetValues();
            }

            set
            {
                SetValues(value);
            }
        }

        /// <summary>
        /// Adds a serializable object to the storage and returns its unique reference.
        /// </summary>
        /// <param name="serializableObject">The serializable object to be added to the storage.</param>
        /// <returns>The unique reference of the added object, or null if the operation failed.</returns>
        public UniqueReference? AddValue(TSerializableObject? serializableObject)
        {
            UniqueReference? uniqueReference = GetUniqueReference(serializableObject); //Create.UniqueReference(serializableObject);
            if (uniqueReference is null)
            {
                return null;
            }

            if (dictionary == null)
            {
                Open();
            }

            dictionary ??= [];

            dictionary[uniqueReference] = serializableObject;
            return uniqueReference;
        }

        /// <summary>
        /// Determines whether the storage contains an object associated with the specified unique reference.
        /// </summary>
        /// <param name="uniqueReference">The unique reference to check for.</param>
        /// <returns>True if the storage contains an object associated with the specified unique reference; otherwise, false.</returns>
        public bool Contains(UniqueReference? uniqueReference)
        {
            if (uniqueReference is null)
            {
                return false;
            }

            if (dictionary != null && dictionary.ContainsKey(uniqueReference))
            {
                return true;
            }

            return GetValue(uniqueReference) != null;
        }

        /// <summary>
        /// Retrieves the unique reference for the specified serializable object.
        /// </summary>
        /// <param name="serializableObject">The serializable object to retrieve the reference for.</param>
        /// <returns>The unique reference associated with the specified serializable object, or null.</returns>
        public virtual UniqueReference? GetUniqueReference(TSerializableObject? serializableObject)
        {
            return Core.Create.UniqueReference(serializableObject);
        }

        /// <summary>
        /// Gets a set of all unique references stored in the file.
        /// </summary>
        /// <returns>A hash set containing all unique references stored in the file, or null.</returns>
        public HashSet<UniqueReference>? GetUniqueReferences()
        {
            if (dictionary == null)
            {
                Open();
            }

            string? path = Path;
            if (string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path))
            {
                return null;
            }

            dictionary ??= [];

            HashSet<UniqueReference> result = [];

            using (ZipArchive zipArchive = ZipFile.OpenRead(path))
            {
                IEnumerable<ZipArchiveEntry> zipArchiveEntries = zipArchive.Entries;

                foreach (ZipArchiveEntry zipArchiveEntry in zipArchiveEntries)
                {
                    if (zipArchiveEntry == null || !zipArchiveEntry.FullName.StartsWith(IO.Constants.EntryName.Values, StringComparison.CurrentCulture))
                    {
                        continue;
                    }

                    // The entry name is Query.Encode(uniqueReference) = url-encoded reference string (written at
                    // the Encode call sites below).
                    UniqueReference? uniqueReference = Query.Decode(zipArchiveEntry.Name);
                    if (uniqueReference is null)
                    {
                        continue;
                    }

                    result.Add(uniqueReference);
                }
            }

            if (dictionary != null)
            {
                foreach (UniqueReference uniqueReference in dictionary.Keys)
                {
                    result.Add(uniqueReference);
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves the typed value associated with the specified unique reference.
        /// </summary>
        /// <param name="uniqueReference">The unique reference to retrieve the value for.</param>
        /// <returns>The typed value associated with the specified unique reference, or null if not found.</returns>
        public TSerializableObject? GetValue(UniqueReference? uniqueReference)
        {
            if (!TryGetValue(uniqueReference, out TSerializableObject? result))
            {
                return default;
            }

            return result;
        }

        /// <summary>
        /// Retrieves the base serializable object associated with the specified unique reference.
        /// </summary>
        /// <typeparam name="USerializableObject">The type of the serializable object.</typeparam>
        /// <param name="uniqueReference">The unique reference to retrieve the value for.</param>
        /// <returns>The base serializable object associated with the specified unique reference, or null if not found.</returns>
        public USerializableObject? GetValue<USerializableObject>(UniqueReference? uniqueReference) where USerializableObject : TSerializableObject
        {
            if (!TryGetValue(uniqueReference, out USerializableObject? result))
            {
                return default;
            }

            return result;
        }

        /// <summary>
        /// Retrieves the object at the specified index.
        /// </summary>
        /// <typeparam name="USerializableObject">The type of serializable object to retrieve.</typeparam>
        /// <param name="index">The index of the object to retrieve.</param>
        /// <returns>The object at the specified index, or null if not found.</returns>
        public USerializableObject? GetValue<USerializableObject>(int index) where USerializableObject : TSerializableObject
        {
            TSerializableObject? serializableObject = GetValue(index);
            if (serializableObject is USerializableObject result)
            {
                return result;
            }

            return default;
        }

        /// <summary>
        /// Retrieves the typed object at the specified index.
        /// </summary>
        /// <param name="index">The index of the object to retrieve.</param>
        /// <returns>The typed object at the specified index, or null if not found.</returns>
        public TSerializableObject? GetValue(int? index)
        {
            if (!TryGetValue(index, out TSerializableObject? result))
            {
                return default;
            }

            return result;
        }

        /// <summary>
        /// Retrieves a collection of objects associated with the provided set of unique references.
        /// </summary>
        /// <typeparam name="USerializableObject">The type of serializable object to retrieve.</typeparam>
        /// <param name="uniqueReferences">The collection of unique references to retrieve values for.</param>
        /// <returns>A collection of objects associated with the provided unique references, or null if not available.</returns>
        public IEnumerable<USerializableObject?>? GetValues<USerializableObject>(IEnumerable<UniqueReference>? uniqueReferences) where USerializableObject : TSerializableObject
        {
            IEnumerable<TSerializableObject?>? serializableObjects = GetValues(uniqueReferences);
            if (serializableObjects == null)
            {
                return null;
            }

            List<USerializableObject?> result = [];
            foreach (TSerializableObject? serializableObject in serializableObjects)
            {
                if (serializableObject == null || serializableObject is not USerializableObject)
                {
                    result.Add(default);
                }
                else
                {
                    result.Add((USerializableObject)serializableObject);
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves a typed collection of objects associated with the provided set of unique references.
        /// </summary>
        /// <param name="uniqueReferences">The collection of unique references to retrieve values for.</param>
        /// <returns>A collection of typed objects associated with the provided unique references, or null if not available.</returns>
        public IEnumerable<TSerializableObject?>? GetValues(IEnumerable<UniqueReference>? uniqueReferences)
        {
            if (uniqueReferences == null)
            {
                return null;
            }

            if (dictionary == null)
            {
                Open();
            }

            dictionary ??= [];

            HashSet<UniqueReference> uniqueReferences_Pull = [];

            Dictionary<UniqueReference, TSerializableObject?> dictionary_Temp = [];
            foreach (UniqueReference uniqueReference in uniqueReferences)
            {
                if (uniqueReference is null)
                {
                    continue;
                }

                if (dictionary.TryGetValue(uniqueReference, out TSerializableObject? serializableObject))
                {
                    dictionary_Temp[uniqueReference] = serializableObject;
                }
                else
                {
                    uniqueReferences_Pull.Add(uniqueReference);
                }
            }

            List<TSerializableObject?>? serializableObjects = Pull(uniqueReferences_Pull);
            if (serializableObjects != null)
            {
                foreach (TSerializableObject? serializableObject in serializableObjects)
                {
                    UniqueReference? uniqueReference = GetUniqueReference(serializableObject); //Create.UniqueReference(serializableObject);
                    if (uniqueReference is null)
                    {
                        continue;
                    }

                    dictionary_Temp[uniqueReference] = serializableObject;
                    dictionary[uniqueReference] = serializableObject;
                }
            }

            List<TSerializableObject?> result = [];
            foreach (UniqueReference uniqueReference in uniqueReferences)
            {
                if (uniqueReference is not null && dictionary_Temp.TryGetValue(uniqueReference, out TSerializableObject? serializableObject))
                {
                    result.Add(serializableObject);
                }
                else
                {
                    result.Add(default);
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves a typed collection of objects at the specified indices.
        /// </summary>
        /// <param name="indexes">The collection of indices for which to retrieve values.</param>
        /// <returns>A collection of typed objects corresponding to the provided indices, or null if not available.</returns>
        public IEnumerable<TSerializableObject?>? GetValues(IEnumerable<int>? indexes)
        {
            if (indexes == null)
            {
                return null;
            }

            HashSet<UniqueReference>? uniqueReferences = GetUniqueReferences();
            if (uniqueReferences == null)
            {
                return null;
            }

            List<UniqueReference> uniqueReferences_List = [.. uniqueReferences];

            int count = uniqueReferences_List.Count;

            Dictionary<int, UniqueReference> dictionary_UniqueReference = [];
            foreach (int index in indexes)
            {
                if (index < 0 || index >= count)
                {
                    continue;
                }

                dictionary_UniqueReference[index] = uniqueReferences_List[index];
            }

            IEnumerable<TSerializableObject?>? serializableObjects = GetValues(dictionary_UniqueReference.Values);

            Dictionary<UniqueReference, TSerializableObject> dictionary_SerializableObject = [];
            if (serializableObjects != null)
            {
                foreach (TSerializableObject? serializableObject in serializableObjects)
                {
                    if (serializableObject == null)
                    {
                        continue;
                    }

                    //dictionary_SerializableObject[Create.UniqueReference(serializableObject)] = serializableObject;

                    UniqueReference? uniqueReference = GetUniqueReference(serializableObject);
                    if (uniqueReference is null)
                    {
                        continue;
                    }

                    dictionary_SerializableObject[uniqueReference] = serializableObject;
                }
            }

            List<TSerializableObject?> result = [];
            foreach (int index in indexes)
            {
                if (!dictionary_UniqueReference.TryGetValue(index, out UniqueReference uniqueReference) || uniqueReference is null)
                {
                    result.Add(default);
                    continue;
                }

                if (!dictionary_SerializableObject.TryGetValue(uniqueReference, out TSerializableObject? serializableObject))
                {
                    serializableObject = default;
                }

                result.Add(serializableObject);
            }

            return result;
        }

        /// <summary>
        /// Retrieves a collection of objects at the specified indices.
        /// </summary>
        /// <param name="indexes">The collection of indices to retrieve objects from.</param>
        /// <typeparam name="USerializableObject">The type of serializable objects being retrieved.</typeparam>
        /// <returns>A collection of objects found at the specified indices, or null if no objects were found.</returns>
        public IEnumerable<USerializableObject?>? GetValues<USerializableObject>(IEnumerable<int>? indexes) where USerializableObject : TSerializableObject
        {
            IEnumerable<TSerializableObject?>? serializableObjects = GetValues(indexes);
            if (serializableObjects == null)
            {
                return null;
            }

            List<USerializableObject?> result = [];
            foreach (TSerializableObject? serializableObject in serializableObjects)
            {
                if (serializableObject is USerializableObject uSerializableObject)
                {
                    result.Add(uSerializableObject);
                }
                else
                {
                    result.Add(default);
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves all stored objects as a collection.
        /// </summary>
        /// <typeparam name="USerializableObject">The type of serializable objects being retrieved.</typeparam>
        /// <returns>A collection of all stored objects, or null if the collection is empty.</returns>
        public IEnumerable<USerializableObject?>? GetValues<USerializableObject>() where USerializableObject : TSerializableObject
        {
            IEnumerable<TSerializableObject?>? values = GetValues();
            if (values == null)
            {
                return null;
            }

            List<USerializableObject> result = [];
            foreach (TSerializableObject? value in values)
            {
                if (value is USerializableObject uSerializableObject)
                {
                    result.Add(uSerializableObject);
                }
            }

            return result;
        }

        /// <summary>
        /// Opens the storage file for reading and writing.
        /// </summary>
        /// <returns>True if the storage file was opened successfully; otherwise, false.</returns>
        public override bool Open()
        {
            bool result = base.Open();
            if (!result)
            {
                return result;
            }

            dictionary ??= [];

            return result;
        }

        /// <summary>
        /// Removes all objects associated with the provided set of unique references.
        /// </summary>
        /// <param name="uniqueReferences">The collection of unique references to be removed.</param>
        /// <returns>A HashSet containing the unique references that were successfully removed, or null if no objects were removed.</returns>
        public HashSet<UniqueReference>? Remove(IEnumerable<UniqueReference>? uniqueReferences)
        {
            if (uniqueReferences == null)
            {
                return null;
            }

            if (dictionary == null)
            {
                Open();
            }

            HashSet<UniqueReference> uniqueReferences_Temp = [.. uniqueReferences];

            HashSet<UniqueReference> result = [];

            if (dictionary != null)
            {
                foreach (UniqueReference uniqueReference in uniqueReferences_Temp.ToList())
                {
                    if (dictionary.ContainsKey(uniqueReference))
                    {
                        uniqueReferences_Temp.Remove(uniqueReference);
                        dictionary[uniqueReference] = default;
                        result.Add(uniqueReference);
                    }
                }
            }

            if (uniqueReferences_Temp.Count == 0)
            {
                return result;
            }

            using (ZipArchive zipArchive = ZipFile.Open(Path, ZipArchiveMode.Update))
            {
                foreach (UniqueReference uniqueReference in uniqueReferences_Temp.ToList())
                {
                    string entryName = System.IO.Path.Combine(IO.Constants.EntryName.Values, Query.Encode(uniqueReference));

                    ZipArchiveEntry zipArchiveEntry = zipArchive.GetEntry(entryName);
                    if (zipArchiveEntry == null)
                    {
                        continue;
                    }

                    zipArchiveEntry.Delete();
                    uniqueReferences_Temp.Remove(uniqueReference);
                    result.Add(uniqueReference);
                }
            }

            return result;
        }

        /// <summary>
        /// Removes the object associated with the specified unique reference.
        /// </summary>
        /// <param name="uniqueReference">The unique reference of the object to remove.</param>
        /// <returns>True if the object was successfully removed; otherwise, false.</returns>
        public bool Remove(UniqueReference? uniqueReference)
        {
            if (uniqueReference is null)
            {
                return false;
            }

            if (dictionary == null)
            {
                Open();
            }

            if (dictionary != null && dictionary.ContainsKey(uniqueReference))
            {
                dictionary[uniqueReference] = default;
                return true;
            }

            using ZipArchive zipArchive = ZipFile.Open(Path, ZipArchiveMode.Update);
            string entryName = System.IO.Path.Combine(IO.Constants.EntryName.Values, Query.Encode(uniqueReference));

            ZipArchiveEntry zipArchiveEntry = zipArchive.GetEntry(entryName);
            if (zipArchiveEntry == null)
            {
                return false;
            }

            zipArchiveEntry.Delete();
            return true;
        }

        /// <summary>
        /// Removes all objects that satisfy the specified condition and returns their references.
        /// </summary>
        /// <typeparam name="USerializableObject">The type of the serializable objects being evaluated.</typeparam>
        /// <param name="func">A predicate function to determine which objects to remove.</param>
        /// <returns>A set containing the unique references of all removed objects, or null if no objects were removed.</returns>
        public HashSet<UniqueReference>? RemoveAll<USerializableObject>(Func<USerializableObject?, bool>? func) where USerializableObject : TSerializableObject
        {
            return Remove(func);
        }

        /// <summary>
        /// Removes the first object that satisfies the specified condition and returns its reference.
        /// </summary>
        /// <typeparam name="USerializableObject">The type of the serializable objects being evaluated.</typeparam>
        /// <param name="func">A predicate function to determine which object to remove.</param>
        /// <returns>The unique reference of the removed object, or null if no object satisfied the condition.</returns>
        public UniqueReference? RemoveFirst<USerializableObject>(Func<USerializableObject?, bool>? func) where USerializableObject : TSerializableObject
        {
            return Remove(func, 1)?.FirstOrDefault();
        }

        /// <summary>
        /// Saves the current state of the storage file to disk.
        /// </summary>
        /// <returns>True if the save operation was successful; otherwise, false.</returns>
        public override bool Save()
        {
            bool result = base.Save();
            if (!result)
            {
                return false;
            }

            HashSet<UniqueReference>? uniqueReferences = Push();

            return uniqueReferences != null && uniqueReferences.Count > 0;
        }

        /// <summary>
        /// Attempts to retrieve a typed value for the specified unique reference.
        /// </summary>
        /// <param name="uniqueReference">The unique reference of the object to retrieve.</param>
        /// <param name="serializableObject">When this method returns, contains the retrieved object if successful; otherwise, null.</param>
        /// <returns>True if the object was successfully retrieved; otherwise, false.</returns>
        public bool TryGetValue(UniqueReference? uniqueReference, out TSerializableObject? serializableObject)
        {
            serializableObject = default;

            if (uniqueReference is null)
            {
                return false;
            }

            if (uniqueReference is null)
            {
                return default;
            }

            IEnumerable<TSerializableObject?>? serializableObjects = GetValues([uniqueReference]);
            if (serializableObjects == null)
            {
                return default;
            }

            serializableObject = serializableObjects.FirstOrDefault();

            return serializableObject != null;
        }

        /// <summary>
        /// Attempts to retrieve a base serializable object for the specified unique reference.
        /// </summary>
        /// <typeparam name="USerializableObject">The type of the serializable object.</typeparam>
        /// <param name="uniqueReference">The unique reference of the object to retrieve.</param>
        /// <param name="serializableObject">When this method returns, contains the retrieved object if successful; otherwise, null.</param>
        /// <returns>True if the object was successfully retrieved; otherwise, false.</returns>
        public bool TryGetValue<USerializableObject>(UniqueReference? uniqueReference, out USerializableObject? serializableObject) where USerializableObject : TSerializableObject
        {
            serializableObject = default;

            if (!TryGetValue(uniqueReference, out TSerializableObject? serializableObject_Temp))
            {
                return false;
            }

            if (serializableObject_Temp is USerializableObject uSerializableObject)
            {
                serializableObject = uSerializableObject;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Attempts to retrieve a typed value at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the element to get.</param>
        /// <param name="serializableObject">When this method returns, contains the object corresponding to the specified index, if found; otherwise, null.</param>
        /// <returns>True if the element exists at the specified index; otherwise, false.</returns>
        public bool TryGetValue(int index, out TSerializableObject? serializableObject)
        {
            serializableObject = default;

            if (index < 0)
            {
                return false;
            }

            IEnumerable<TSerializableObject?>? serializableObjects = GetValues([index]);
            if (serializableObjects == null)
            {
                return default;
            }

            serializableObject = serializableObjects.FirstOrDefault();

            return serializableObject != null;
        }

        /// <summary>
        /// Attempts to retrieve a base serializable object at the specified index.
        /// </summary>
        /// <typeparam name="USerializableObject">The type of the serializable object.</typeparam>
        /// <param name="index">The zero-based index of the element to get.</param>
        /// <param name="serializableObject">When this method returns, contains the object corresponding to the specified index, if found; otherwise, null.</param>
        /// <returns>True if the element exists at the specified index; otherwise, false.</returns>
        public bool TryGetValue<USerializableObject>(int? index, out USerializableObject? serializableObject) where USerializableObject : TSerializableObject
        {
            serializableObject = default;

            if (!TryGetValue(index, out TSerializableObject? serializableObject_Temp))
            {
                return false;
            }

            if (serializableObject_Temp is USerializableObject uSerializableObject)
            {
                serializableObject = uSerializableObject;
                return true;
            }

            return false;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (!disposed)
            {
                if (disposing)
                {
                    // dispose managed state (managed objects).
                }

                // free unmanaged resources (unmanaged objects) and override a finalizer below.
                // set large fields to null.

                dictionary = null;
                disposed = true;
            }
        }

        private List<TSerializableObject?>? GetValues()
        {
            List<TSerializableObject?>? result = Pull();
            dictionary ??= [];

            result ??= [];

            List<UniqueReference?> uniqueReferences = result.ConvertAll(x => GetUniqueReference(x)); //result.ConvertAll(x => Create.UniqueReference(x));

            foreach (KeyValuePair<UniqueReference, TSerializableObject?> keyValuePair in dictionary)
            {
                int index = uniqueReferences.FindIndex(x => x is not null && keyValuePair.Key.Equals(x));
                if (index == -1)
                {
                    result.Add(keyValuePair.Value);
                    continue;
                }

                result[index] = keyValuePair.Value;
            }

            foreach (TSerializableObject? serializableObject in result)
            {
                UniqueReference? uniqueReference = GetUniqueReference(serializableObject); //Create.UniqueReference(serializableObject);
                if (uniqueReference is null)
                {
                    continue;
                }

                if (!dictionary.ContainsKey(uniqueReference))
                {
                    dictionary[uniqueReference] = serializableObject;
                }
            }

            return result;
        }

        private List<TSerializableObject?>? Pull(IEnumerable<UniqueReference>? uniqueReferences = null)
        {
            if (dictionary == null)
            {
                Open();
            }

            string? path = Path;
            if (string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path))
            {
                return null;
            }

            dictionary ??= [];

            List<string> jsons = [];
            using (ZipArchive zipArchive = ZipFile.OpenRead(path))
            {
                IEnumerable<ZipArchiveEntry>? zipArchiveEntries = null;
                if (uniqueReferences != null)
                {
                    List<ZipArchiveEntry> zipArchiveEntries_Temp = [];

                    foreach (UniqueReference uniqueReference in uniqueReferences)
                    {
                        if (uniqueReference is null)
                        {
                            continue;
                        }

                        string entryName = System.IO.Path.Combine(IO.Constants.EntryName.Values, Query.Encode(uniqueReference));

                        ZipArchiveEntry zipArchiveEntry = zipArchive.GetEntry(entryName);
                        if (zipArchiveEntry != null)
                        {
                            zipArchiveEntries_Temp.Add(zipArchiveEntry);
                        }
                    }

                    zipArchiveEntries = zipArchiveEntries_Temp;
                }
                else
                {
                    List<ZipArchiveEntry>? zipArchiveEntries_Temp = zipArchive.Entries?.ToList();
                    if (zipArchiveEntries_Temp != null)
                    {
                        for (int i = zipArchiveEntries_Temp.Count - 1; i >= 0; i--)
                        {
                            ZipArchiveEntry ZipArchiveEntry = zipArchiveEntries_Temp[i];

                            if (ZipArchiveEntry == null || !ZipArchiveEntry.FullName.StartsWith(IO.Constants.EntryName.Values, StringComparison.CurrentCulture))
                            {
                                zipArchiveEntries_Temp.RemoveAt(i);
                            }
                        }
                    }

                    zipArchiveEntries = zipArchiveEntries_Temp;
                }

                if (zipArchiveEntries != null)
                {
                    foreach (ZipArchiveEntry zipArchiveEntry in zipArchiveEntries)
                    {
                        using StreamReader streamReader = new(zipArchiveEntry.Open());
                        jsons.Add(streamReader.ReadToEnd());
                    }
                }
            }

            List<TSerializableObject?> result = [];
            foreach (string json in jsons)
            {
                List<TSerializableObject>? serializableObjects = Convert.ToDiGi<TSerializableObject>(json);
                if (serializableObjects != null && serializableObjects.Count != 0)
                {
                    TSerializableObject serializableObject = serializableObjects[0];
                    if (serializableObject != null)
                    {
                        result.Add(serializableObject);
                    }
                }
            }

            return result;
        }

        private HashSet<UniqueReference>? Push(IEnumerable<UniqueReference>? uniqueReferences = null)
        {
            if (this.dictionary == null)
            {
                Open();
            }

            string? path = Path;
            if (string.IsNullOrWhiteSpace(path) || !Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return null;
            }

            Dictionary<UniqueReference, string?> dictionary = [];
            if (this.dictionary != null)
            {
                if (uniqueReferences == null)
                {
                    foreach (KeyValuePair<UniqueReference, TSerializableObject?> keyValuePair in this.dictionary)
                    {
                        dictionary[keyValuePair.Key] = Convert.ToSystem_String(keyValuePair.Value);
                    }
                }
                else
                {
                    foreach (UniqueReference uniqueReference in uniqueReferences)
                    {
                        if (!this.dictionary.TryGetValue(uniqueReference, out TSerializableObject? serializableObject))
                        {
                            continue;
                        }

                        dictionary[uniqueReference] = Convert.ToSystem_String(serializableObject);
                    }
                }
            }

            HashSet<UniqueReference> result = [];
            using (ZipArchive zipArchive = ZipFile.Open(path, ZipArchiveMode.Update))
            {
                foreach (KeyValuePair<UniqueReference, string?> keyValuePair in dictionary)
                {
                    string entryName = System.IO.Path.Combine(IO.Constants.EntryName.Values, Query.Encode(keyValuePair.Key));

                    ZipArchiveEntry zipArchiveEntry = zipArchive.GetEntry(entryName);
                    zipArchiveEntry?.Delete();

                    if (string.IsNullOrWhiteSpace(keyValuePair.Value))
                    {
                        continue;
                    }

                    zipArchiveEntry = zipArchive.CreateEntry(entryName);

                    using (Stream stream = zipArchiveEntry.Open())
                    {
                        using StreamWriter streamWriter = new(stream);
                        streamWriter.Write(keyValuePair.Value);
                    }

                    result.Add(keyValuePair.Key);
                }
            }

            return result;
        }

        private HashSet<UniqueReference>? Remove<USerializableObject>(Func<USerializableObject?, bool>? func, uint? maxCount = uint.MaxValue) where USerializableObject : TSerializableObject
        {
            if (func == null || maxCount < 1)
            {
                return null;
            }

            if (dictionary == null)
            {
                Open();
            }

            if (dictionary == null)
            {
                return null;
            }

            HashSet<UniqueReference> result = [];

            foreach (KeyValuePair<UniqueReference, TSerializableObject?> keyValuePair in dictionary)
            {
                USerializableObject? uSerializableObject = keyValuePair.Value is USerializableObject uSerializableObject_Temp ? uSerializableObject_Temp : default;
                if (uSerializableObject == null || !func.Invoke(uSerializableObject))
                {
                    continue;
                }

                dictionary[keyValuePair.Key] = default;

                result.Add(keyValuePair.Key);
                if (result.Count >= maxCount)
                {
                    return result;
                }
            }

            using (ZipArchive zipArchive = ZipFile.Open(Path, ZipArchiveMode.Update))
            {
                List<ZipArchiveEntry>? zipArchiveEntries = zipArchive.Entries?.ToList();
                if (zipArchiveEntries == null || zipArchiveEntries.Count == 0)
                {
                    return result;
                }

                for (int i = zipArchiveEntries.Count - 1; i >= 0; i--)
                {
                    ZipArchiveEntry zipArchiveEntry = zipArchiveEntries[i];

                    if (zipArchiveEntry == null || !zipArchiveEntry.FullName.StartsWith(IO.Constants.EntryName.Values, StringComparison.CurrentCulture))
                    {
                        continue;
                    }

                    USerializableObject? serializableObject = default;

                    using (StreamReader streamReader = new(zipArchiveEntry.Open()))
                    {
                        string json = streamReader.ReadToEnd();

                        List<USerializableObject>? serializableObjects = Convert.ToDiGi<USerializableObject>(json);
                        if (serializableObjects == null || serializableObjects.Count == 0)
                        {
                            continue;
                        }

                        serializableObject = serializableObjects[0];
                    }

                    if (serializableObject == null)
                    {
                        continue;
                    }

                    UniqueReference? uniqueReference = GetUniqueReference(serializableObject); //Create.UniqueReference(serializableObject);
                    if (uniqueReference is null)
                    {
                        continue;
                    }

                    if (result.Contains(uniqueReference))
                    {
                        zipArchiveEntry.Delete();
                        continue;
                    }

                    if (!func.Invoke(serializableObject))
                    {
                        if (!dictionary.ContainsKey(uniqueReference))
                        {
                            dictionary[uniqueReference] = serializableObject;
                        }

                        continue;
                    }

                    zipArchiveEntry.Delete();

                    result.Add(uniqueReference);

                    if (result.Count >= maxCount)
                    {
                        return result;
                    }
                }
            }

            return result;
        }

        private void SetValues(IEnumerable<TSerializableObject?>? values)
        {
            if (values == null)
            {
                return;
            }

            if (dictionary == null)
            {
                Open();
            }

            dictionary ??= [];

            foreach (TSerializableObject? serializableObject in values)
            {
                UniqueReference? uniqueReference = GetUniqueReference(serializableObject); //Create.UniqueReference(serializableObject);
                if (uniqueReference is null)
                {
                    continue;
                }

                dictionary[uniqueReference] = serializableObject;
            }
        }
    }

    /// <summary>
    /// Represents a file used for storing and managing serializable objects.
    /// </summary>
    public class StorageFile : StorageFile<ISerializableObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageFile"/> class using the specified file path.
        /// </summary>
        /// <param name="path">The path to the storage file.</param>
        public StorageFile(string? path)
            : base(path)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageFile"/> class from another storage file instance.
        /// </summary>
        /// <param name="storageFile">The source storage file instance.</param>
        public StorageFile(StorageFile? storageFile)
            : base(storageFile)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageFile"/> class from the provided JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize the storage file from.</param>
        public StorageFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}