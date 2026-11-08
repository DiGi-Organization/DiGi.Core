using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>
    /// Base class for all parameter value types.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    [SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "Serialized base type used across the workspace by this name; renaming is a breaking change.")]
    public abstract class ParameterValue : Attribute, ISerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Nullable))]
        private readonly bool nullable = true;

        /// <summary>
        /// Gets a value indicating whether the parameter is nullable.
        /// </summary>
        [JsonIgnore]
        public bool Nullable
        {
            get
            {
                return nullable;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterValue"/> class.
        /// </summary>
        public ParameterValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterValue"/> class with specified nullability.
        /// </summary>
        /// <param name="nullable">A value indicating whether the parameter is nullable.</param>
        public ParameterValue(bool nullable)
        {
            this.nullable = nullable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterValue"/> class by copying an existing instance.
        /// </summary>
        /// <param name="parameterValue">The existing <see cref="ParameterValue"/> instance to copy.</param>
        public ParameterValue(ParameterValue? parameterValue)
        {
            if (parameterValue != null)
            {
                nullable = parameterValue.nullable;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterValue"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the parameter value.</param>
        public ParameterValue(JsonObject? jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        /// <summary>
        /// Gets the parameter type associated with this value.
        /// </summary>
        [JsonIgnore]
        public abstract ParameterType ParameterType { get; }

        /// <summary>
        /// Creates a clone of the current parameter value.
        /// </summary>
        /// <returns>A new instance of <see cref="ISerializableObject"/> that is a copy of the current object, or null.</returns>
        public abstract ISerializableObject? Clone();

        /// <summary>
        /// Populates the parameter value from the provided JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to extract the value from.</param>
        /// <returns>True if the population was successful; otherwise, false.</returns>
        public bool FromJsonObject(JsonObject? jsonObject)
        {
            return Modify.FromJsonObject(this, jsonObject);
        }

        /// <summary>
        /// Validates whether the given value is compatible with this parameter.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>True if the value is valid; otherwise, false.</returns>
        public virtual bool IsValid(object? value)
        {
            if (value == null)
            {
                return nullable;
            }

            return Query.IsValid(ParameterType, value);
        }

        /// <summary>
        /// Converts the current parameter value to a JSON object.
        /// </summary>
        /// <returns>A <see cref="JsonObject"/> representation of the parameter value, or null if conversion fails.</returns>
        public JsonObject? ToJsonObject()
        {
            return Convert.ToJson(this);
        }

        /// <summary>
        /// Attempts to convert an input value to the expected output type.
        /// </summary>
        /// <param name="value_In">The value to be converted.</param>
        /// <param name="value_Out">When this method returns, contains the converted value if successful; otherwise, null.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public virtual bool TryConvert(object? value_In, out object? value_Out)
        {
            value_Out = default;

            if (value_In == null)
            {
                if (nullable)
                {
                    value_Out = null;
                    return true;
                }

                return false;
            }

            switch (ParameterType)
            {
                case ParameterType.Double:
                    if (value_In == null)
                    {
                        return false;
                    }

                    double @double;
                    if (!Core.Query.TryConvert(value_In, out @double))
                    {
                        return false;
                    }

                    value_Out = @double;
                    return true;

                case ParameterType.String:
                    string? @string;
                    if (!Core.Query.TryConvert(value_In, out @string))
                    {
                        return false;
                    }

                    value_Out = @string;
                    return true;

                case ParameterType.Boolean:
                    if (value_In == null)
                    {
                        return false;
                    }

                    bool @bool;
                    if (!Core.Query.TryConvert(value_In, out @bool))
                    {
                        return false;
                    }

                    value_Out = @bool;
                    return true;

                case ParameterType.Integer:
                    if (value_In == null)
                    {
                        return false;
                    }

                    int @int;
                    if (!Core.Query.TryConvert(value_In, out @int))
                    {
                        return false;
                    }

                    value_Out = @int;
                    return true;

                case ParameterType.Object:
                    if (value_In is not ISerializableObject && value_In is not Enum)
                    {
                        return false;
                    }

                    value_Out = value_In;
                    return true;

                case ParameterType.Guid:
                    if (value_In == null)
                    {
                        return false;
                    }

                    Guid @guid;
                    if (!Core.Query.TryConvert(value_In, out @guid))
                    {
                        return false;
                    }

                    value_Out = @guid;
                    return true;

                case ParameterType.DateTime:
                    if (value_In == null)
                    {
                        return false;
                    }

                    DateTime @dateTime;
                    if (!Core.Query.TryConvert(value_In, out @dateTime))
                    {
                        return false;
                    }

                    value_Out = @dateTime;
                    return true;

                case ParameterType.Color:
                    Core.Classes.Color? color;
                    if (!Core.Query.TryConvert(value_In, out color))
                    {
                        return false;
                    }

                    value_Out = color;
                    return true;

                case ParameterType.Undefined:
                    value_Out = value_In;
                    return true;
            }

            return false;
        }
    }
}