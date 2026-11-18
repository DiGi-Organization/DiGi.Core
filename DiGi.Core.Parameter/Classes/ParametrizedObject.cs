using DiGi.Core.Classes;
using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>
    /// Class ParametrizedObject.
    /// </summary>
    public class ParametrizedObject : SerializableObject, IParametrizedObject
    {
        [JsonInclude, JsonPropertyName(nameof(ParameterGroupCollection))]
        private ParameterGroupCollection parameterGroupCollection = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedObject"/> class.
        /// </summary>
        public ParametrizedObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedObject"/> class using a collection of parameters.
        /// </summary>
        /// <param name="parameters">The collection of parameters to initialize the object with.</param>
        public ParametrizedObject(IEnumerable<Parameter>? parameters)
            : base()
        {
            if (parameters != null)
            {
                foreach (Parameter parameter in parameters)
                {
                    parameterGroupCollection.SetValue(parameter);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedObject"/> class using a parameter group collection.
        /// </summary>
        /// <param name="parameterGroupCollection">The parameter group collection to use for initialization.</param>
        public ParametrizedObject(ParameterGroupCollection? parameterGroupCollection)
        {
            this.parameterGroupCollection = parameterGroupCollection == null ? new ParameterGroupCollection() : new ParameterGroupCollection(parameterGroupCollection);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedObject"/> class by copying another parametrized object.
        /// </summary>
        /// <param name="parametrizedObject">The parametrized object to copy from.</param>
        public ParametrizedObject(ParametrizedObject? parametrizedObject)
            : base(parametrizedObject)
        {
            if (parametrizedObject != null)
            {
                parameterGroupCollection = parametrizedObject.parameterGroupCollection == null ? new ParameterGroupCollection() : new ParameterGroupCollection(parametrizedObject.parameterGroupCollection);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedObject"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public ParametrizedObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Creates a deep copy of the parametrized object.
        /// </summary>
        /// <remarks>
        /// A <see cref="ParametrizedObject"/> itself is copied member by member with its parameters cloned, which is a deep copy only because it holds nothing else. Any derived type is copied by the JSON round trip of <see cref="SerializableObject.Clone"/>: a member-by-member copy would share every field it adds - a <c>BuildingModel</c> clone shared its relation cluster with its source (DiGi-Organization/DiGi.Core#14).
        /// </remarks>
        /// <returns>A new cloned instance of the parametrized object.</returns>
        public override ISerializableObject? Clone()
        {
            if (GetType() != typeof(ParametrizedObject))
            {
                return base.Clone();
            }

            ParametrizedObject parametrizedObject = (ParametrizedObject)MemberwiseClone();
            parametrizedObject.parameterGroupCollection = (ParameterGroupCollection)parameterGroupCollection.Clone()!;
            return parametrizedObject;
        }

        /// <summary>
        /// Gets the parameter group collection.
        /// </summary>
        [JsonIgnore]
        public ParameterGroupCollection ParameterGroupCollection
        {
            get
            {
                return parameterGroupCollection;
            }
        }

        /// <summary>
        /// Determines whether the object contains a parameter with the specified unique identifier.
        /// </summary>
        /// <param name="uniqueId">The unique identifier of the parameter to search for.</param>
        /// <returns>True if the object contains a parameter with the specified unique identifier; otherwise, false.</returns>
        public bool Contains(string? uniqueId)
        {
            return parameterGroupCollection.Contains(uniqueId);
        }

        /// <summary>
        /// Determines whether the object contains a parameter associated with the specified definition.
        /// </summary>
        /// <param name="parameterDefinition">The parameter definition to search for.</param>
        /// <returns>True if the object contains a parameter associated with the specified definition; otherwise, false.</returns>
        public bool Contains(IParameterDefinition? parameterDefinition)
        {
            return parameterGroupCollection.Contains(parameterDefinition);
        }

        /// <summary>
        /// Determines whether the object contains a parameter associated with the specified enumeration member.
        /// </summary>
        /// <param name="enum">The enumeration member to search for.</param>
        /// <returns>True if the object contains a parameter associated with the specified enumeration member; otherwise, false.</returns>
        public bool Contains(Enum? @enum)
        {
            return parameterGroupCollection.Contains(@enum);
        }

        /// <summary>
        /// Retrieves a list of parameter definitions that match the specified name and comparison criteria.
        /// </summary>
        /// <param name="parameterName">The name of the parameters to search for.</param>
        /// <param name="textComparisonType">The type of text comparison to use.</param>
        /// <param name="caseSensitive">A value indicating whether the comparison should be case-sensitive.</param>
        /// <returns>A list of parameter definitions that match the specified criteria, or null if none are found.</returns>
        public List<IParameterDefinition>? GetParameterDefinitions(string? parameterName, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true)
        {
            return parameterGroupCollection?.GetParameterDefinitions(parameterName, textComparisonType, caseSensitive);
        }

        /// <summary>
        /// Retrieves a list of parameter definitions of type <typeparamref name="TParameterDefinition"/> that match the specified name and comparison criteria.
        /// </summary>
        /// <typeparam name="TParameterDefinition">The type of the parameter definitions to retrieve.</typeparam>
        /// <param name="parameterName">The name of the parameters to search for.</param>
        /// <param name="textComparisonType">The type of text comparison to use.</param>
        /// <param name="caseSensitive">A value indicating whether the comparison should be case-sensitive.</param>
        /// <returns>A list of parameter definitions that match the specified criteria, or null if none are found.</returns>
        public List<TParameterDefinition>? GetParameterDefinitions<TParameterDefinition>(string? parameterName, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true) where TParameterDefinition : IParameterDefinition
        {
            return parameterGroupCollection?.GetParameterDefinitions<TParameterDefinition>(parameterName, textComparisonType, caseSensitive);
        }

        /// <summary>
        /// Retrieves all parameter definitions of type <typeparamref name="TParameterDefinition"/>.
        /// </summary>
        /// <typeparam name="TParameterDefinition">The type of the parameter definitions to retrieve.</typeparam>
        /// <returns>A list of all parameter definitions of the specified type, or null if none are found.</returns>
        public List<TParameterDefinition>? GetParameterDefinitions<TParameterDefinition>() where TParameterDefinition : IParameterDefinition
        {
            return parameterGroupCollection?.GetParameterDefinitions<TParameterDefinition>();
        }

        /// <summary>
        /// Gets the value associated with the specified parameter definition.
        /// </summary>
        /// <param name="parameterDefinition">The parameter definition for which to retrieve the value.</param>
        /// <param name="getValueSettings">Optional settings for retrieving the value.</param>
        /// <returns>The value associated with the specified parameter definition, or null if not found.</returns>
        public object? GetValue(IParameterDefinition? parameterDefinition, GetValueSettings? getValueSettings = null)
        {
            return parameterGroupCollection?.GetValue(parameterDefinition, getValueSettings);
        }

        /// <summary>
        /// Gets the value associated with the specified unique identifier.
        /// </summary>
        /// <param name="uniqueId">The unique identifier of the value to retrieve.</param>
        /// <param name="getValueSettings">Optional settings for retrieving the value.</param>
        /// <returns>The value associated with the specified unique identifier, or null if not found.</returns>
        public object? GetValue(string? uniqueId, GetValueSettings? getValueSettings = null)
        {
            return parameterGroupCollection?.GetValue(uniqueId, getValueSettings);
        }

        /// <summary>
        /// Gets the value associated with the specified enumeration member.
        /// </summary>
        /// <param name="enum">The enumeration member associated with the value.</param>
        /// <param name="getValueSettings">Optional settings for retrieving the value.</param>
        /// <returns>The value associated with the specified enumeration member, or null if not found.</returns>
        public object? GetValue(Enum? @enum, GetValueSettings? getValueSettings = null)
        {
            if (@enum == null)
            {
                return null;
            }

            return parameterGroupCollection.GetValue((EnumParameterDefinition)@enum!, getValueSettings);
        }

        /// <summary>
        /// Gets the value of type <typeparamref name="T"/> associated with the specified enumeration member.
        /// </summary>
        /// <typeparam name="T">The type of the value to retrieve.</typeparam>
        /// <param name="enum">The enumeration member associated with the value.</param>
        /// <param name="getValueSettings">Optional settings for retrieving the value.</param>
        /// <returns>The value associated with the specified enumeration member, or null if not found.</returns>
        public T? GetValue<T>(Enum? @enum, GetValueSettings? getValueSettings = null)
        {
            if (@enum == null)
            {
                return default;
            }

            return parameterGroupCollection.GetValue<T>((EnumParameterDefinition)@enum!, getValueSettings);
        }

        /// <summary>
        /// Gets the value of type <typeparamref name="T"/> associated with the specified parameter definition.
        /// </summary>
        /// <typeparam name="T">The type of the value to retrieve.</typeparam>
        /// <param name="parameterDefinition">The definition of the parameter whose value is to be retrieved.</param>
        /// <param name="getValueSettings">Optional settings for retrieving the value.</param>
        /// <returns>The value associated with the specified parameter definition, or null if not found.</returns>
        public T? GetValue<T>(IParameterDefinition? parameterDefinition, GetValueSettings? getValueSettings = null)
        {
            if (parameterDefinition == null)
            {
                return default;
            }

            return parameterGroupCollection.GetValue<T>(parameterDefinition, getValueSettings);
        }

        /// <summary>
        /// Gets the value of type <typeparamref name="T"/> associated with the specified unique identifier.
        /// </summary>
        /// <typeparam name="T">The type of the value to retrieve.</typeparam>
        /// <param name="uniqueId">The unique identifier of the value to retrieve.</param>
        /// <param name="getValueSettings">Optional settings for retrieving the value.</param>
        /// <returns>The value associated with the specified unique identifier, or null if not found.</returns>
        public T? GetValue<T>(string? uniqueId, GetValueSettings? getValueSettings = null)
        {
            if (uniqueId == null)
            {
                return default;
            }

            return parameterGroupCollection == null ? default : parameterGroupCollection.GetValue<T>(uniqueId, getValueSettings);
        }

        /// <summary>
        /// Gets the first parameter value converted to type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of the value to retrieve.</typeparam>
        /// <param name="getValueSettings">Optional settings for retrieving the value.</param>
        /// <returns>The value of type <typeparamref name="T"/>, or default if not found.</returns>
        public T? GetValue<T>(GetValueSettings? getValueSettings = null)
        {
            return parameterGroupCollection == null ? default : parameterGroupCollection.GetValue<T>(getValueSettings);
        }

        /// <summary>
        /// Removes the parameter associated with the specified definition.
        /// </summary>
        /// <param name="parameterDefinition">The definition of the parameter to remove.</param>
        /// <returns>True if the parameter was successfully removed; otherwise, false.</returns>
        public bool Remove(IParameterDefinition? parameterDefinition)
        {
            return parameterGroupCollection.Remove(parameterDefinition);
        }

        /// <summary>
        /// Removes the parameter associated with the specified unique identifier.
        /// </summary>
        /// <param name="uniqueId">The unique identifier of the parameter to remove.</param>
        /// <returns>True if the parameter was successfully removed; otherwise, false.</returns>
        public bool Remove(string? uniqueId)
        {
            return parameterGroupCollection.Remove(uniqueId);
        }

        /// <summary>
        /// Sets the value for the specified parameter definition.
        /// </summary>
        /// <param name="parameterDefinition">The parameter definition.</param>
        /// <param name="value">The value to set.</param>
        /// <param name="setValueSettings">Optional settings for setting the value.</param>
        /// <returns>True if the value was successfully set; otherwise, false.</returns>
        public bool SetValue(IParameterDefinition? parameterDefinition, object? value, SetValueSettings? setValueSettings = null)
        {
            return parameterGroupCollection.SetValue(parameterDefinition, value, setValueSettings);
        }

        /// <summary>
        /// Sets the value for the specified enumeration member.
        /// </summary>
        /// <param name="enum">The enumeration member.</param>
        /// <param name="value">The value to set.</param>
        /// <param name="setValueSettings">Optional settings for setting the value.</param>
        /// <returns>True if the value was successfully set; otherwise, false.</returns>
        public bool SetValue(Enum? @enum, object? value, SetValueSettings? setValueSettings = null)
        {
            if (@enum == null)
            {
                return false;
            }

            return parameterGroupCollection.SetValue((EnumParameterDefinition)@enum!, value, setValueSettings);
        }

        /// <summary>
        /// Sets the value for the parameter with the specified name.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="value">The value to set.</param>
        /// <param name="setValueSettings">Optional settings for setting the value.</param>
        /// <returns>True if the value was successfully set; otherwise, false.</returns>
        public bool SetValue(string? name, object? value, SetValueSettings? setValueSettings = null)
        {
            return parameterGroupCollection.SetValue(name, value, setValueSettings);
        }

        /// <summary>
        /// Sets the value using the provided parameter object.
        /// </summary>
        /// <param name="parameter">The parameter object containing the value to set.</param>
        /// <returns>True if the value was successfully set; otherwise, false.</returns>
        public bool SetValue(Parameter? parameter)
        {
            return parameterGroupCollection.SetValue(parameter);
        }

        /// <summary>
        /// Attempts to retrieve the value associated with the specified unique identifier.
        /// </summary>
        /// <param name="uniqueId">The unique identifier of the value to retrieve.</param>
        /// <param name="value">When this method returns, contains the retrieved value if successful; otherwise, null.</param>
        /// <param name="getValueSettings">Optional settings for retrieving the value.</param>
        /// <returns>True if the value was successfully retrieved; otherwise, false.</returns>
        public bool TryGetValue(string? uniqueId, out object? value, GetValueSettings? getValueSettings = null)
        {
            return parameterGroupCollection.TryGetValue(uniqueId, out value, getValueSettings);
        }

        /// <summary>
        /// Attempts to retrieve the value associated with the specified parameter definition.
        /// </summary>
        /// <param name="parameterDefinition">The parameter definition associated with the value.</param>
        /// <param name="value">When this method returns, contains the retrieved value if successful; otherwise, null.</param>
        /// <param name="getValueSettings">Optional settings to use when retrieving the value.</param>
        /// <returns>True if the value was successfully retrieved; otherwise, false.</returns>
        public bool TryGetValue(IParameterDefinition? parameterDefinition, out object? value, GetValueSettings? getValueSettings = null)
        {
            return parameterGroupCollection.TryGetValue(parameterDefinition, out value, getValueSettings);
        }

        /// <summary>
        /// Attempts to retrieve the value associated with the specified enumeration member.
        /// </summary>
        /// <param name="enum">The enumeration member associated with the value.</param>
        /// <param name="value">When this method returns, contains the retrieved value if successful; otherwise, null.</param>
        /// <param name="getValueSettings">Optional settings to use when retrieving the value.</param>
        /// <returns>True if the value was successfully retrieved; otherwise, false.</returns>
        public bool TryGetValue(Enum? @enum, out object? value, GetValueSettings? getValueSettings = null)
        {
            value = null;
            if (@enum == null)
            {
                return false;
            }

            return TryGetValue((EnumParameterDefinition)@enum!, out value, getValueSettings);
        }

        /// <summary>
        /// Attempts to retrieve the value of type <typeparamref name="T"/> associated with the specified parameter definition.
        /// </summary>
        /// <typeparam name="T">The type of the value to retrieve.</typeparam>
        /// <param name="parameterDefinition">The parameter definition associated with the value.</param>
        /// <param name="value">When this method returns, contains the retrieved value of type <typeparamref name="T"/> if successful; otherwise, the default value of <typeparamref name="T"/>.</param>
        /// <param name="getValueSettings">Optional settings to use when retrieving the value.</param>
        /// <returns>True if the value was successfully retrieved; otherwise, false.</returns>
        public bool TryGetValue<T>(IParameterDefinition? parameterDefinition, out T? value, GetValueSettings? getValueSettings = null)
        {
            return parameterGroupCollection.TryGetValue(parameterDefinition, out value, getValueSettings);
        }

        /// <summary>
        /// Attempts to retrieve the value of type <typeparamref name="T"/> associated with the specified enumeration member.
        /// </summary>
        /// <typeparam name="T">The type of the value to retrieve.</typeparam>
        /// <param name="enum">The enumeration member associated with the value.</param>
        /// <param name="value">When this method returns, contains the retrieved value of type <typeparamref name="T"/> if successful; otherwise, the default value of <typeparamref name="T"/>.</param>
        /// <param name="getValueSettings">Optional settings to use when retrieving the value.</param>
        /// <returns>True if the value was successfully retrieved; otherwise, false.</returns>
        public bool TryGetValue<T>(Enum? @enum, out T? value, GetValueSettings? getValueSettings = null)
        {
            if (@enum is null)
            {
                value = default;
                return false;
            }

            return parameterGroupCollection.TryGetValue((EnumParameterDefinition)@enum!, out value, getValueSettings);
        }

        /// <summary>
        /// Attempts to retrieve the value of type <typeparamref name="T"/> associated with the specified unique identifier.
        /// </summary>
        /// <typeparam name="T">The type of the value to retrieve.</typeparam>
        /// <param name="uniqueId">The unique identifier for the value.</param>
        /// <param name="value">When this method returns, contains the retrieved value of type <typeparamref name="T"/> if successful; otherwise, the default value of <typeparamref name="T"/>.</param>
        /// <param name="getValueSettings">Optional settings to use when retrieving the value.</param>
        /// <returns>True if the value was successfully retrieved; otherwise, false.</returns>
        public bool TryGetValue<T>(string? uniqueId, out T? value, GetValueSettings? getValueSettings = null)
        {
            return parameterGroupCollection.TryGetValue(uniqueId, out value, getValueSettings);
        }
    }
}