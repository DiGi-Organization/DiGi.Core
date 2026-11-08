using DiGi.Core.Interfaces;
using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>Defines a set of types associated with an enum value.</summary>
    [AttributeUsage(AttributeTargets.All)]
    [SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "Serialized type: its name is the _type discriminator of stored JSON.")]
    [SuppressMessage("Design", "CA1010:Generic interface should also be implemented", Justification = "Serialized type: an added IEnumerable<T> would change how the DiGi serializer writes it.")]
    public class AssociatedTypes : Attribute, IEnumerable, ISerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Types))]
        private readonly Type[]? types;

        /// <summary>Initializes a new instance of the AssociatedTypes class with specified values.</summary>
        /// <param name="values">The associated types.</param>
        public AssociatedTypes(params Type[]? values)
        {
            types = values;
        }

        /// <summary>Initializes a new instance of the AssociatedTypes class by copying another AssociatedTypes instance.</summary>
        /// <param name="associatedTypes">The AssociatedTypes instance to copy.</param>
        public AssociatedTypes(AssociatedTypes? associatedTypes)
        {
            if (associatedTypes != null)
            {
                types = associatedTypes.Types?.ToArray();
            }
        }

        /// <summary>Initializes a new instance of the AssociatedTypes class from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object containing associated types data.</param>
        public AssociatedTypes(JsonObject? jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        /// <summary>Gets the collection of associated types.</summary>
        [JsonIgnore]
        public Type[]? Types
        {
            get
            {
                return types?.ToArray();
            }
        }

        /// <summary>Creates a shallow copy of the current AssociatedTypes instance.</summary>
        /// <returns>A cloned ISerializableObject.</returns>
        public virtual ISerializableObject? Clone()
        {
            return new AssociatedTypes(types);
        }

        /// <summary>Populates the current AssociatedTypes instance from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object to read data from.</param>
        /// <returns>True if successful, false otherwise.</returns>
        public virtual bool FromJsonObject(JsonObject? jsonObject)
        {
            return Modify.FromJsonObject(this, jsonObject);
        }

        /// <summary>Returns an enumerator that iterates through the associated types.</summary>
        /// <returns>An IEnumerator for the Types collection.</returns>
        public IEnumerator GetEnumerator()
        {
            if (types == null)
            {
                return Enumerable.Empty<Type>().GetEnumerator();
            }

            return types.GetEnumerator();
        }

        /// <summary>Determines whether a specified type is associated with this instance.</summary>
        /// <param name="type">The type to validate.</param>
        /// <returns>True if the type is valid, false otherwise.</returns>
        public virtual bool IsValid(Type? type)
        {
            if (types == null || types.Length == 0 || type == null)
            {
                return false;
            }

            foreach (Type? type_Temp in types)
            {
                if (type_Temp == null)
                {
                    continue;
                }

                if (type.Equals(type_Temp))
                {
                    return true;
                }

                if (type.IsAssignableFrom(type_Temp))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>Converts the current AssociatedTypes instance to a JSON object.</summary>
        /// <returns>The resulting JsonObject.</returns>
        public virtual JsonObject? ToJsonObject()
        {
            return Convert.ToJson(this);
        }
    }
}