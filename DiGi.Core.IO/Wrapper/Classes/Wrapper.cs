using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Classes;
using DiGi.Core.IO.Interfaces;
using DiGi.Core.IO.Wrapper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    /// <summary>
    /// Base class for wrapping serializable objects into a structure that can be persisted and retrieved using unique references.
    /// </summary>
    public abstract class Wrapper : IDisposable
    {
        private readonly WrapperNodeCluster wrapperNodeCluster = [];
        private bool disposed;

        /// <summary>
        /// Initializes a new instance of the <see cref="Wrapper"/> class.
        /// </summary>
        public Wrapper()
        {
        }

        /// <summary>
        /// Adds a serializable object to the wrapper and returns its unique reference.
        /// </summary>
        /// <param name="value">The serializable object to add.</param>
        /// <returns>A <see cref="UniqueReference"/> for the added object, or null.</returns>
        public UniqueReference? Add(ISerializableObject? value)
        {
            if (value == null)
            {
                return null;
            }

            List<IWrapperUniqueReference>? wrapperUniqueReferences = AddRange(new object[] { value });
            if (wrapperUniqueReferences == null || wrapperUniqueReferences.Count == 0)
            {
                return null;
            }

            return wrapperUniqueReferences[0]?.UniqueReference();
        }

        /// <summary>
        /// Adds a string value to the wrapper and returns its unique identifier reference.
        /// </summary>
        /// <param name="value">The string value to add.</param>
        /// <returns>A <see cref="UniqueIdReference"/> for the added value, or null.</returns>
        public UniqueIdReference? Add(string? value)
        {
            if (value == null)
            {
                return null;
            }

            List<IWrapperUniqueReference>? wrapperUniqueReferences = AddRange([value]);
            if (wrapperUniqueReferences == null || wrapperUniqueReferences.Count == 0)
            {
                return null;
            }

            return wrapperUniqueReferences[0]?.UniqueReference() as UniqueIdReference;
        }

        /// <summary>
        /// Adds a double value to the wrapper and returns its unique identifier reference.
        /// </summary>
        /// <param name="value">The double value to add.</param>
        /// <returns>A <see cref="UniqueIdReference"/> for the added value, or null.</returns>
        public UniqueIdReference? Add(double value)
        {
            List<IWrapperUniqueReference>? wrapperUniqueReferences = AddRange([value]);
            if (wrapperUniqueReferences == null || wrapperUniqueReferences.Count == 0)
            {
                return null;
            }

            return wrapperUniqueReferences[0]?.UniqueReference() as UniqueIdReference;
        }

        /// <summary>
        /// Adds a collection of serializable objects to the wrapper and returns their unique references.
        /// </summary>
        /// <typeparam name="TSerializableObject">The type of serializable objects being added.</typeparam>
        /// <param name="serializableObjects">The collection of serializable objects to add.</param>
        /// <returns>A list of <see cref="UniqueReference"/> for the added objects, or null.</returns>
        public List<UniqueReference>? AddRange<TSerializableObject>(IEnumerable<TSerializableObject>? serializableObjects) where TSerializableObject : ISerializableObject
        {
            if (serializableObjects == null)
            {
                return null;
            }

            List<object> objects = [];
            foreach (TSerializableObject serializableObject in serializableObjects)
            {
                objects.Add(serializableObject);
            }

            List<IWrapperUniqueReference>? wrapperUniqueReferences = AddRange(objects);
            if (wrapperUniqueReferences == null)
            {
                return null;
            }

            List<UniqueReference> result = [];
            foreach (IWrapperUniqueReference wrapperUniqueReference in wrapperUniqueReferences)
            {
                UniqueReference? uniqueReference = wrapperUniqueReference.UniqueReference();
                if (uniqueReference is null)
                {
                    continue;
                }

                result.Add(uniqueReference);
            }

            return result;
        }

        /// <summary>
        /// Clears the cached content of the file.
        /// </summary>
        public void Clear()
        {
            wrapperNodeCluster.Clear();
        }

        /// <summary>
        /// Releases all resources used by the watcher.
        /// </summary>
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Parses and returns the file content as a list of JSON nodes.
        /// </summary>
        /// <returns>A list of <see cref="JsonNode"/> objects, or null if the operation fails.</returns>
        public List<JsonNode?>? GetJsonNodes()
        {
            WrapperMetadata wrapperMetadata = GetWrapperMetadata();

            List<string>? references = wrapperMetadata?.References;
            if (references == null)
            {
                return null;
            }

            HashSet<IWrapperUniqueReference> wrapperUniqueReferences = [];
            foreach (string reference in references)
            {
                if (!Query.TryParse(reference, out IWrapperUniqueReference? wrapperUniqueReference) || wrapperUniqueReference == null)
                {
                    continue;
                }

                wrapperUniqueReferences.Add(wrapperUniqueReference);
            }

            HashSet<WrapperNode>? wrapperNodes = Read(wrapperUniqueReferences);
            if (wrapperNodes == null)
            {
                return null;
            }

            Dictionary<string, WrapperNode> wrapperNodesByReference = [];
            foreach (WrapperNode wrapperNode_Temp in wrapperNodes)
            {
                if (wrapperNode_Temp == null)
                {
                    continue;
                }

                string? key = wrapperNode_Temp.WrapperUniqueReference?.ToString();
                if (key == null)
                {
                    continue;
                }

                wrapperNodesByReference[key] = wrapperNode_Temp;
            }

            List<JsonNode?> result = [];
            foreach (string reference in references)
            {
                wrapperNodesByReference.TryGetValue(reference, out WrapperNode? wrapperNode);

                result.Add(wrapperNode?.JsonNode);
            }

            return result;
        }

        /// <summary>
        /// Retrieves metadata associated with the file.
        /// </summary>
        /// <typeparam name="TMetadata">The type of metadata to retrieve.</typeparam>
        /// <returns>The metadata object of type <typeparamref name="TMetadata"/>, or null if not found.</returns>
        public TMetadata? GetMetadata<TMetadata>() where TMetadata : IMetadata
        {
            MetadataStorage metadataStorage = GetMetadataStorage();

            return metadataStorage.GetMetadata<TMetadata>();
        }

        /// <summary>
        /// Retrieves all serializable objects from the file content.
        /// </summary>
        /// <returns>A list of objects implementing <see cref="ISerializableObject"/>, or null.</returns>
        public List<ISerializableObject>? GetSerializableObjects()
        {
            return GetSerializableObjects<ISerializableObject>();
        }

        /// <summary>
        /// Retrieves all serializable objects of a specific type from the file content.
        /// </summary>
        /// <typeparam name="TSerializableObject">The type of serializable objects to retrieve.</typeparam>
        /// <returns>A list of serializable objects of type <typeparamref name="TSerializableObject"/>, or null.</returns>
        public List<TSerializableObject>? GetSerializableObjects<TSerializableObject>() where TSerializableObject : ISerializableObject
        {
            List<JsonNode?>? jsonNodes = GetJsonNodes();
            if (jsonNodes == null)
            {
                return null;
            }

            List<TSerializableObject> result = [];
            foreach (JsonNode? jsonNode in jsonNodes)
            {
                TSerializableObject? serializableObject = Core.Create.SerializableObject<TSerializableObject>(jsonNode as JsonObject);
                if (serializableObject == null)
                {
                    continue;
                }

                result.Add(serializableObject);
            }

            return result;
        }

        /// <summary>
        /// Reads the file and returns its content as a list of JSON nodes.
        /// </summary>
        /// <returns>A list of <see cref="JsonNode"/> objects representing the file content, or null.</returns>
        public List<JsonNode>? Read()
        {
            HashSet<WrapperNode>? wrapperNodes = Read(null as IEnumerable<TypeReference>);
            if (wrapperNodes == null)
            {
                return null;
            }

            List<JsonNode> result = [];
            foreach (WrapperNode wrapperNode in wrapperNodes)
            {
                JsonNode? jsonNode = wrapperNode?.JsonNode;
                if (jsonNode == null)
                {
                    continue;
                }

                result.Add(jsonNode);
            }

            return result;
        }

        /// <summary>
        /// Reads specific serializable objects from the file based on the provided references.
        /// </summary>
        /// <typeparam name="TSerializableObject">The type of serializable objects to read.</typeparam>
        /// <param name="uniqueReferences">A collection of unique references used to identify the objects to be read.</param>
        /// <returns>A list of serializable objects of type <typeparamref name="TSerializableObject"/>, or null if no objects were found.</returns>
        public List<TSerializableObject>? Read<TSerializableObject>(IEnumerable<UniqueReference> uniqueReferences) where TSerializableObject : ISerializableObject
        {
            List<JsonNode>? jsonNodes = Read(uniqueReferences);
            if (jsonNodes == null)
            {
                return null;
            }

            List<TSerializableObject> result = [];
            foreach (JsonNode jsonNode in jsonNodes)
            {
                if (jsonNode is not JsonObject jsonObject)
                {
                    continue;
                }

                TSerializableObject? serializableObject = Core.Create.SerializableObject<TSerializableObject>(jsonObject);
                if (serializableObject == null)
                {
                    continue;
                }

                result.Add(serializableObject);
            }

            return result;
        }

        /// <summary>
        /// Reads a single serializable object from the file using its unique reference.
        /// </summary>
        /// <typeparam name="TSerializableObject">The type of the serializable object to read.</typeparam>
        /// <param name="uniqueReference">The unique reference of the object to read.</param>
        /// <returns>The deserialized object of type <typeparamref name="TSerializableObject"/>, or null.</returns>
        public TSerializableObject? Read<TSerializableObject>(UniqueReference? uniqueReference) where TSerializableObject : ISerializableObject
        {
            if (uniqueReference is null)
            {
                return default;
            }

            List<TSerializableObject>? serializableObjects = Read<TSerializableObject>([uniqueReference]);
            if (serializableObjects == null || serializableObjects.Count == 0)
            {
                return default;
            }

            return serializableObjects[0];
        }

        /// <summary>
        /// Reads JSON nodes associated with the provided unique references.
        /// </summary>
        /// <param name="uniqueReferences">The collection of unique references to read.</param>
        /// <returns>A list of JSON nodes corresponding to the provided references, or null.</returns>
        public List<JsonNode>? Read(IEnumerable<UniqueReference>? uniqueReferences)
        {
            if (uniqueReferences == null)
            {
                return null;
            }

            HashSet<IWrapperUniqueReference> wrapperUniqueReferences = [];
            foreach (UniqueReference uniqueReference in uniqueReferences)
            {
                if (uniqueReference is null)
                {
                    continue;
                }

                IWrapperUniqueReference? wrapperUniqueReference = Create.WrapperUniqueReference(uniqueReference);
                if (wrapperUniqueReference == null)
                {
                    continue;
                }

                wrapperUniqueReferences.Add(wrapperUniqueReference);
            }

            HashSet<WrapperNode>? wrapperNodes = Read(wrapperUniqueReferences);
            if (wrapperNodes == null)
            {
                return null;
            }

            List<JsonNode> result = [];
            foreach (UniqueReference uniqueReference in uniqueReferences)
            {
                WrapperNode? wrapperNode = wrapperNodeCluster.GetValue(uniqueReference);
                JsonNode? jsonNode = wrapperNode?.JsonNode;
                if (jsonNode == null)
                {
                    continue;
                }

                result.Add(jsonNode);
            }

            return result;
        }

        /// <summary>
        /// Sets the metadata for the file content.
        /// </summary>
        /// <param name="metadata">The metadata to set.</param>
        public void SetMetadata(IMetadata metadata)
        {
            MetadataStorage? metadataStorage = Read<MetadataStorage>(Constants.MetadataStorage.WrapperGuidReference);
            metadataStorage ??= new MetadataStorage();

            metadataStorage.SetMetadata(metadata);

            SetMetadataStorage(metadataStorage);
        }

        /// <summary>
        /// Writes specific objects to the file based on the provided references.
        /// </summary>
        /// <param name="uniqueReferences">The collection of unique references to write.</param>
        /// <returns>A collection of unique references for the written objects, or null.</returns>
        public IEnumerable<UniqueReference>? Write(IEnumerable<UniqueReference>? uniqueReferences)
        {
            if (uniqueReferences == null)
            {
                return null;
            }

            HashSet<IWrapperUniqueReference?> wrapperUniqueReferences = [];
            foreach (UniqueReference uniqueReference in uniqueReferences)
            {
                if (uniqueReference is null)
                {
                    continue;
                }

                wrapperUniqueReferences.Add(Create.WrapperUniqueReference(uniqueReference));
            }

            IEnumerable<IWrapperUniqueReference?>? wrapperUniqueReferences_Temp = Write(wrapperUniqueReferences);
            if (wrapperUniqueReferences_Temp == null || !wrapperUniqueReferences_Temp.Any())
            {
                return null;
            }

            HashSet<UniqueReference> result = [];
            foreach (IWrapperUniqueReference? wrapperUniqueReference_Temp in wrapperUniqueReferences_Temp)
            {
                UniqueReference? uniqueReference = wrapperUniqueReference_Temp?.UniqueReference();
                if (uniqueReference is null)
                {
                    continue;
                }

                result.Add(uniqueReference);
            }

            return result;
        }

        /// <summary>
        /// Writes all current objects to the file.
        /// </summary>
        /// <returns>A collection of unique references for the written objects, or null.</returns>
        public IEnumerable<UniqueReference>? Write()
        {
            IEnumerable<IWrapperUniqueReference?>? wrapperUniqueReferences = Write(null as IEnumerable<WrapperTypeReference>);
            if (wrapperUniqueReferences == null)
            {
                return null;
            }

            HashSet<UniqueReference> result = [];
            foreach (IWrapperUniqueReference? wrapperUniqueReference in wrapperUniqueReferences)
            {
                UniqueReference? uniqueReference = wrapperUniqueReference?.UniqueReference();
                if (uniqueReference is null)
                {
                    continue;
                }

                result.Add(uniqueReference);
            }
            return result;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposed = true;
            }
        }

        protected abstract bool Pull(IEnumerable<WrapperItem>? wrapperItems);

        protected abstract bool Pull(out IEnumerable<TypeReference>? typeReferences);

        protected abstract bool Pull(TypeReference? typeReference, out IEnumerable<UniqueReference>? uniqueReferences);

        protected abstract bool Push(IEnumerable<WrapperItem>? wrapperItems);

        private List<IWrapperUniqueReference>? AddRange(IEnumerable<object>? objects)
        {
            if (objects == null)
            {
                return null;
            }

            WrapperMetadata wrapperMetadata = GetWrapperMetadata();

            List<IWrapperUniqueReference> result = [];
            foreach (object @object in objects)
            {
                IWrapperUniqueReference wrapperUniqueReference = wrapperNodeCluster.Add(@object as dynamic);
                if (wrapperUniqueReference is null)
                {
                    continue;
                }

                result.Add(wrapperUniqueReference);

                wrapperMetadata.References.Add(wrapperUniqueReference.ToString());
            }

            SetWrapperMetadata(wrapperMetadata);

            return result;
        }

        private MetadataStorage GetMetadataStorage()
        {
            MetadataStorage? result = Read<MetadataStorage>(Constants.MetadataStorage.WrapperGuidReference);
            result ??= new MetadataStorage();

            return result;
        }

        private WrapperMetadata GetWrapperMetadata()
        {
            MetadataStorage metadataStorage = GetMetadataStorage();

            WrapperMetadata? wrapperMetadata = metadataStorage.GetMetadata<WrapperMetadata>();
            if (wrapperMetadata == null)
            {
                wrapperMetadata = new WrapperMetadata();
                metadataStorage.SetMetadata(wrapperMetadata);
            }

            return wrapperMetadata;
        }

        private HashSet<WrapperNode>? Read(HashSet<IWrapperUniqueReference> wrapperUniqueReferences)
        {
            if (wrapperUniqueReferences == null)
            {
                return null;
            }

            HashSet<WrapperNode> result = [];
            HashSet<IWrapperUniqueReference> wrapperUniqueReferences_Pull = [];

            foreach (IWrapperUniqueReference wrapperUniqueReference in wrapperUniqueReferences)
            {
                if (wrapperUniqueReference == null)
                {
                    return null;
                }

                WrapperNode? wrapperNode = wrapperNodeCluster.GetValue(wrapperUniqueReference);
                if (wrapperNode == null)
                {
                    wrapperUniqueReferences_Pull.Add(wrapperUniqueReference);
                    continue;
                }

                wrapperNode.Unwrap(wrapperNodeCluster, out HashSet<IWrapperUniqueReference>? wrapperUniqueReferences_Pull_Temp);

                if (wrapperUniqueReferences_Pull_Temp != null && wrapperUniqueReferences_Pull_Temp.Count != 0)
                {
                    foreach (IWrapperUniqueReference wrapperUniqueReference_Pull_Temp in wrapperUniqueReferences_Pull_Temp)
                    {
                        wrapperUniqueReferences_Pull.Add(wrapperUniqueReference_Pull_Temp);
                    }
                }
                else
                {
                    result.Add(wrapperNode);
                }
            }

            if (wrapperUniqueReferences_Pull == null || wrapperUniqueReferences_Pull.Count == 0)
            {
                return result;
            }

            Dictionary<IWrapperUniqueReference, WrapperItem> dictionary = [];
            foreach (IWrapperUniqueReference wrapperUniqueReference in wrapperUniqueReferences_Pull)
            {
                dictionary[wrapperUniqueReference] = new WrapperItem(wrapperUniqueReference.UniqueReference());
            }

            if (dictionary == null || dictionary.Count == 0)
            {
                return null;
            }

            if (!Pull(dictionary.Values))
            {
                return null;
            }

            foreach (KeyValuePair<IWrapperUniqueReference, WrapperItem> keyValuePair in dictionary)
            {
                WrapperNode wrapperNode = new(keyValuePair.Key, keyValuePair.Value.JsonNode as dynamic);
                wrapperNodeCluster.Add(wrapperNode);
            }

            Read(wrapperUniqueReferences_Pull);

            foreach (IWrapperUniqueReference wrapperUniqueReference_Pull in wrapperUniqueReferences_Pull)
            {
                WrapperNode? wrapperNode = wrapperNodeCluster.GetValue(wrapperUniqueReference_Pull) ?? throw new NotImplementedException();
                wrapperNode.Unwrap(wrapperNodeCluster, out HashSet<IWrapperUniqueReference>? wrapperUniqueReferences_Pull_Temp);

                if (wrapperUniqueReferences_Pull_Temp != null && wrapperUniqueReferences_Pull_Temp.Count != 0)
                {
                    throw new NotImplementedException();
                }

                if (wrapperUniqueReferences.Contains(wrapperUniqueReference_Pull))
                {
                    result.Add(wrapperNode);
                }
            }

            return result;
        }

        private WrapperNode? Read(IWrapperUniqueReference wrapperUniqueReference)
        {
            if (wrapperUniqueReference == null)
            {
                return null;
            }

            HashSet<WrapperNode>? wrapperNodes = Read([wrapperUniqueReference]);
            if (wrapperNodes == null || wrapperNodes.Count == 0)
            {
                return null;
            }

            return wrapperNodes.First();
        }

        private TSerializableObject? Read<TSerializableObject>(IWrapperUniqueReference wrapperUniqueReference) where TSerializableObject : ISerializableObject
        {
            if (Read(wrapperUniqueReference)?.JsonNode is not JsonObject jsonObject)
            {
                return default;
            }

            return Core.Create.SerializableObject<TSerializableObject>(jsonObject);
        }

        private HashSet<WrapperNode>? Read(IEnumerable<TypeReference>? typeReferences)
        {
            if (typeReferences == null)
            {
                if (!Pull(out typeReferences) || typeReferences == null)
                {
                    return null;
                }
            }

            HashSet<WrapperNode> result = [];
            foreach (TypeReference typeReference in typeReferences)
            {
                if (!Pull(typeReference, out IEnumerable<UniqueReference>? uniqueReferences) || uniqueReferences == null)
                {
                    continue;
                }

                HashSet<IWrapperUniqueReference> wrapperUniqueReferences = [];
                foreach (UniqueReference uniqueReference in uniqueReferences)
                {
                    IWrapperUniqueReference? wrapperUniqueReference = uniqueReference.WrapperUniqueReference();
                    if (wrapperUniqueReference == null)
                    {
                        continue;
                    }

                    wrapperUniqueReferences.Add(wrapperUniqueReference);
                }

                HashSet<WrapperNode>? wrapperNodes_TypeReference = Read(wrapperUniqueReferences);
                if (wrapperNodes_TypeReference == null)
                {
                    continue;
                }

                foreach (WrapperNode wrapperNode_TypeReference in wrapperNodes_TypeReference)
                {
                    if (wrapperNodes_TypeReference == null)
                    {
                        continue;
                    }

                    result.Add(wrapperNode_TypeReference);
                }
            }

            return result;
        }

        private void SetMetadataStorage(MetadataStorage metadataStorage)
        {
            if (metadataStorage == null)
            {
                return;
            }

            wrapperNodeCluster.Add(metadataStorage);
        }

        private void SetWrapperMetadata(WrapperMetadata wrapperMetadata)
        {
            SetMetadata(wrapperMetadata);
        }

        private List<IWrapperUniqueReference?>? Write(IEnumerable<IWrapperUniqueReference?>? wrapperUniqueReferences)
        {
            if (wrapperUniqueReferences == null)
            {
                return null;
            }

            List<WrapperItem> wrapperItems = [];
            foreach (IWrapperUniqueReference? wrapperUniqueReference in wrapperUniqueReferences)
            {
                if (wrapperUniqueReference == null)
                {
                    continue;
                }

                WrapperNode? wrapperNode = wrapperNodeCluster.GetValue(wrapperUniqueReference);
                if (wrapperNode == null)
                {
                    continue;
                }

                List<WrapperNode> wrapperNodes_Temp = [wrapperNode];

                wrapperNodeCluster.Wrap(true, wrapperNode.WrapperUniqueReference, out HashSet<WrapperNode>? wrapperNodes_Wrap);
                if (wrapperNodes_Wrap != null && wrapperNodes_Wrap.Count != 0)
                {
                    foreach (WrapperNode wrapperNode_Wrap in wrapperNodes_Wrap)
                    {
                        wrapperNodes_Temp.Add(wrapperNode_Wrap);
                    }
                }

                foreach (WrapperNode wrapperNode_Temp in wrapperNodes_Temp)
                {
                    WrapperItem? wrapperItem = new(wrapperNode_Temp.GetUniqueReference(), wrapperNode_Temp.JsonNode, null);
                    if (wrapperItem == null)
                    {
                        continue;
                    }

                    wrapperItems.Add(wrapperItem);
                }
            }

            if (!Push(wrapperItems))
            {
                return null;
            }

            return wrapperItems.ConvertAll(x => Create.WrapperUniqueReference(x.UniqueReference));
        }

        private HashSet<IWrapperUniqueReference>? Write(IEnumerable<WrapperTypeReference>? wrapperTypeReferences)
        {
            if (wrapperTypeReferences == null)
            {
                wrapperTypeReferences = wrapperNodeCluster?.GetKeys_1();
                if (wrapperTypeReferences == null)
                {
                    return null;
                }
            }

            HashSet<IWrapperUniqueReference> result = [];
            foreach (WrapperTypeReference wrapperTypeReference in wrapperTypeReferences)
            {
                IEnumerable<IWrapperUniqueReference?>? wrapperUniqueReferences = wrapperNodeCluster?.GetKeys_2(wrapperTypeReference);
                if (wrapperTypeReferences == null)
                {
                    continue;
                }

                wrapperUniqueReferences = Write(wrapperUniqueReferences);
                if (wrapperTypeReferences == null)
                {
                    continue;
                }

                if (wrapperUniqueReferences != null)
                {
                    foreach (IWrapperUniqueReference? wrapperUniqueReference in wrapperUniqueReferences)
                    {
                        if (wrapperUniqueReference == null)
                        {
                            continue;
                        }

                        result.Add(wrapperUniqueReference);
                    }
                }
            }

            return result;
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Wrapper()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }
    }
}