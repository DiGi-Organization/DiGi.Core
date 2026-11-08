using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>
    /// Defines a parameter based on an enumeration type.
    /// </summary>
    public class EnumParameterDefinition : ComplexParameterDefinition
    {
        [JsonInclude, JsonPropertyName("Enum")]
        private Enum? @enum;

        private AccessType accessType_Access = AccessType.ReadWrite;
        private AssociatedTypes? associatedTypes_Associated;
        private bool bool_IsCached;
        private ParameterValue? parameterValue_Parameter;
        private string? string_Description;
        private string? string_GroupName;
        private string? string_Name;
        private string? string_UniqueId;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumParameterDefinition"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the parameter definition.</param>
        public EnumParameterDefinition(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumParameterDefinition"/> class by copying an existing definition.
        /// </summary>
        /// <param name="enumParameterDefinition">The existing enum parameter definition to copy.</param>
        public EnumParameterDefinition(EnumParameterDefinition? enumParameterDefinition)
            : base(enumParameterDefinition)
        {
            if (enumParameterDefinition != null)
            {
                @enum = enumParameterDefinition.@enum;
                bool_IsCached = enumParameterDefinition.bool_IsCached;
                string_Name = enumParameterDefinition.string_Name;
                string_UniqueId = enumParameterDefinition.string_UniqueId;
                string_Description = enumParameterDefinition.string_Description;
                string_GroupName = enumParameterDefinition.string_GroupName;
                accessType_Access = enumParameterDefinition.accessType_Access;
                associatedTypes_Associated = enumParameterDefinition.associatedTypes_Associated;
                parameterValue_Parameter = enumParameterDefinition.parameterValue_Parameter;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumParameterDefinition"/> class based on a specific enumeration value.
        /// </summary>
        /// <param name="enum">The enumeration value to use for initialization.</param>
        public EnumParameterDefinition(Enum? @enum)
        {
            this.@enum = @enum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumParameterDefinition"/> class.
        /// </summary>
        public EnumParameterDefinition()
            : base()
        {
        }

        /// <summary>
        /// Gets the access type for the enum parameter.
        /// </summary>
        public override AccessType AccessType
        {
            get
            {
                EnsureCached();
                return accessType_Access;
            }
        }

        /// <summary>
        /// Gets the associated types for the enum parameter.
        /// </summary>
        public override AssociatedTypes? AssociatedTypes
        {
            get
            {
                EnsureCached();
                return associatedTypes_Associated;
            }
        }

        /// <summary>
        /// Gets or sets the description of the enum parameter.
        /// </summary>
        public override string? Description
        {
            get
            {
                EnsureCached();
                return string_Description;
            }
        }

        /// <summary>
        /// Gets the underlying enumeration value.
        /// </summary>
        public Enum? Enum
        {
            get
            {
                return @enum;
            }
        }

        /// <summary>
        /// Gets the group name to which the enum parameter belongs.
        /// </summary>
        public override string GroupName
        {
            get
            {
                EnsureCached();
                return string_GroupName ?? Constants.Names.DefaultGroupName;
            }
        }

        /// <summary>
        /// Gets or sets the name of the enum parameter.
        /// </summary>
        public override string? Name
        {
            get
            {
                EnsureCached();
                return string_Name;
            }
        }

        /// <summary>
        /// Gets or sets the current value of the enum parameter.
        /// </summary>
        public override ParameterValue? ParameterValue
        {
            get
            {
                EnsureCached();
                return parameterValue_Parameter;
            }
        }

        /// <summary>
        /// Gets or sets the unique identifier for the enum parameter.
        /// </summary>
        public override string? UniqueId
        {
            get
            {
                EnsureCached();
                return string_UniqueId;
            }
        }

        /// <summary>
        /// Explicitly converts an <see cref="EnumParameterDefinition"/> to its underlying <see cref="Enum"/> value.
        /// </summary>
        /// <param name="enumParameterDefinition">The enum parameter definition to convert.</param>
        /// <returns>The <see cref="Enum"/> value associated with the definition, or <c>null</c> if the input is <c>null</c>.</returns>
        public static explicit operator Enum?(EnumParameterDefinition? enumParameterDefinition)
        {
            if (enumParameterDefinition == null)
            {
                return null;
            }

            return enumParameterDefinition.@enum;
        }

        /// <summary>
        /// Explicitly converts an <see cref="Enum"/> to an <see cref="EnumParameterDefinition"/>.
        /// </summary>
        /// <param name="enum">The enum value to convert.</param>
        /// <returns>An <see cref="EnumParameterDefinition"/> instance created from the provided enum, or <c>null</c> if the input is <c>null</c>.</returns>
        public static explicit operator EnumParameterDefinition?(Enum? @enum)
        {
            if (@enum == null)
            {
                return null;
            }

            return new EnumParameterDefinition(@enum);
        }

        /// <summary>
        /// Creates a copy of the current enum parameter definition.
        /// </summary>
        /// <returns>A clone of the current enum parameter definition as an <see cref="ISerializableObject"/>.</returns>
        public override ISerializableObject? Clone()
        {
            return new EnumParameterDefinition(this);
        }

        /// <summary>
        /// Populates the enum parameter definition from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to populate the definition from.</param>
        /// <returns><c>true</c> if the population was successful; otherwise, <c>false</c>.</returns>
        public override bool FromJsonObject(JsonObject? jsonObject)
        {
            if (jsonObject == null)
            {
                return false;
            }

            if (jsonObject.ContainsKey(nameof(Enum)))
            {
                Core.Query.TryGetEnum(jsonObject[nameof(Enum)]?.GetValue<string>(), out @enum);
                bool_IsCached = false;
            }

            return true;
        }

        /// <summary>
        /// Converts the enum parameter definition to a JSON object.
        /// </summary>
        /// <returns>A <see cref="JsonObject"/> representation of the enum parameter definition.</returns>
        public override JsonObject ToJsonObject()
        {
            JsonObject result = new()
            {
                { Core.Constants.Serialization.PropertyName.Type, Core.Query.FullTypeName(GetType()) },
                { nameof(Enum), Core.Query.FullName(@enum) }
            };

            return result;
        }

        private void EnsureCached()
        {
            if (bool_IsCached)
            {
                return;
            }

            if (@enum != null)
            {
                ParameterProperties? parameterProperties_Temp = Query.ParameterProperties(@enum);
                if (parameterProperties_Temp != null)
                {
                    string_Name = parameterProperties_Temp.Name;
                    string_UniqueId = parameterProperties_Temp.UniqueId;
                    string_Description = parameterProperties_Temp.Description;
                    accessType_Access = parameterProperties_Temp.AccessType;
                    string_GroupName = parameterProperties_Temp.GroupName;
                }

                string_GroupName ??= @enum.GetType()?.Namespace;
                string_GroupName ??= Constants.Names.DefaultGroupName;

                string_Name ??= @enum.ToString();
                string_UniqueId ??= Core.Query.FullName(@enum);

                associatedTypes_Associated = Query.AssociatedTypes(@enum.GetType());
                parameterValue_Parameter = Query.ParameterValue<ParameterValue>(@enum);
                parameterValue_Parameter ??= new ObjectParameterValue(true, true, @enum.GetType());
            }

            bool_IsCached = true;
        }
    }
}