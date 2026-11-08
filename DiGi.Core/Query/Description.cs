using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the description attribute of an enum value.
        /// </summary>
        /// <param name="enum">The enum value.</param>
        /// <returns>The description string, or the enum name if no attribute is found.</returns>
        public static string? Description(this Enum? @enum)
        {
            Type? type = @enum?.GetType();
            if (type == null)
            {
                return null;
            }

            Type type_Temp = Nullable.GetUnderlyingType(type);
            if (type_Temp != null)
            {
                type = type_Temp;
            }

            FieldInfo fieldInfo = type.GetField(@enum!.ToString());

            if (fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) is DescriptionAttribute[] descriptionAttributes && descriptionAttributes.Length != 0)
            {
                return descriptionAttributes[0].Description;
            }

            return @enum.ToString();
        }

        /// <summary>
        /// Gets the description attribute of a Type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The description string, or the type name if no attribute is found.</returns>
        public static string? Description(this Type? type)
        {
            Type type_Temp = Nullable.GetUnderlyingType(type);
            if (type_Temp != null)
            {
                type = type_Temp;
            }

            if (type == null)
            {
                return null;
            }

            if (type.GetCustomAttributes(typeof(DescriptionAttribute), false) is DescriptionAttribute[] descriptionAttributes && descriptionAttributes.Length != 0)
            {
                return descriptionAttributes[0].Description;
            }

            return type.Name;
        }
    }
}