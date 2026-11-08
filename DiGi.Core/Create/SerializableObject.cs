using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates a serializable object from the given JSON object.</summary>
        /// <typeparam name="T">The type of the object to create.</typeparam>
        /// <param name="jsonObject">The JSON object to convert into a serializable object.</param>
        /// <returns>A serializable object of type <typeparamref name="T"/>, or null if the conversion fails.</returns>
        public static T? SerializableObject<T>(this JsonObject? jsonObject) where T : ISerializableObject
        {
            if (jsonObject == null)
            {
                return default;
            }

            string? fullTypeName = Query.FullTypeName(jsonObject);

            SerializationConstructor? serializationConstructor;
            if (!string.IsNullOrWhiteSpace(fullTypeName))
            {
                serializationConstructor = Settings.SerializationManager.GetSerializationConstructor(fullTypeName);
            }
            else
            {
                serializationConstructor = Settings.SerializationManager.GetSerializationConstructor<T>();
            }

            serializationConstructor ??= Settings.SerializationManager.GetSerializationConstructor<SerializableObjectWrapper>();

            if (serializationConstructor == null)
            {
                return default;
            }

            return serializationConstructor.Create<T>(jsonObject);
        }
    }
}