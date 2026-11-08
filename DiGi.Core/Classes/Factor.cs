using DiGi.Core.Interfaces;
using System.ComponentModel;
using System.Globalization;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a normalization factor as a value between 0 and 1.
    /// </summary>
    public readonly struct Factor : IObject, ISerializableObject
    {
        [JsonInclude, JsonPropertyName("Value"), Description("Value [0-1]")]
        private readonly double value = double.NaN;

        /// <summary>
        /// Initializes a new instance of the Factor struct with default values.
        /// </summary>
        public Factor()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Factor struct with a specified value clamped between 0 and 1.
        /// </summary>
        /// <param name="value">The factor value.</param>
        public Factor(double value)
        {
            this.value = double.IsNaN(value) ? double.NaN : Query.Clamp(value, 0, 1);
        }

        /// <summary>
        /// Initializes a new instance of the Factor struct by copying another Factor.
        /// </summary>
        /// <param name="factor">The source factor.</param>
        public Factor(Factor factor)
        {
            value = factor.value;
        }

        /// <summary>
        /// Initializes a new instance of the Factor struct from a JsonObject, reading its <c>Value</c> node and clamping it between 0 and 1.
        /// <para>The node is read here rather than through <see cref="Modify.FromJsonObject(ISerializableObject?, JsonObject?)"/>, which would populate a boxed copy of this readonly struct and leave the value <see cref="double.NaN"/>.</para>
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the factor value; a missing or unreadable <c>Value</c> yields <see cref="double.NaN"/>.</param>
        public Factor(JsonObject? jsonObject)
        {
            if (jsonObject != null && jsonObject.TryGetPropertyValue("Value", out JsonNode? jsonNode) && jsonNode != null && Query.TryConvert_Double(jsonNode, out double? value_JsonNode) && value_JsonNode != null)
            {
                value = double.IsNaN(value_JsonNode.Value) ? double.NaN : Query.Clamp(value_JsonNode.Value, 0, 1);
            }
        }

        /// <summary>
        /// Implicitly converts a Factor to its double value.
        /// </summary>
        public static implicit operator double(Factor factor)
        {
            return factor.value;
        }

        /// <summary>
        /// Implicitly converts a double to a Factor.
        /// </summary>
        public static implicit operator Factor(double value)
        {
            return new Factor(value);
        }

        /// <summary>
        /// Implicitly converts a float to a Factor.
        /// </summary>
        public static implicit operator Factor(float value)
        {
            return new Factor(System.Convert.ToDouble(value));
        }

        /// <summary>
        /// Implicitly converts a Factor to its float value.
        /// </summary>
        public static implicit operator float(Factor factor)
        {
            return System.Convert.ToSingle(factor.value);
        }

        /// <summary>
        /// Creates a deep copy of the factor.
        /// </summary>
        /// <returns>A new Factor instance with the same value.</returns>
        public ISerializableObject? Clone()
        {
            return new Factor(value);
        }

        /// <summary>
        /// Does nothing: a readonly struct cannot be populated in place. Construct a new factor with <see cref="Factor(JsonObject?)"/> instead.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data; ignored.</param>
        /// <returns>Always false.</returns>
        public bool FromJsonObject(JsonObject? jsonObject)
        {
            return false;
        }

        /// <summary>
        /// Converts the factor to a JsonObject for serialization.
        /// </summary>
        /// <returns>A JsonObject representation of the factor.</returns>
        public JsonObject? ToJsonObject()
        {
            return Convert.ToJson(this);
        }

        /// <summary>
        /// Returns a string representation of the factor's value.
        /// </summary>
        /// <returns>The numeric value as a string.</returns>
        public override string ToString()
        {
            return value.ToString(CultureInfo.CurrentCulture);
        }
    }
}