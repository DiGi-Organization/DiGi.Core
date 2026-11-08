using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace DiGi.Core.Parameter
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the description of the specified enumeration value.
        /// </summary>
        /// <param name="enum">The enumeration value for which to get the description.</param>
        /// <returns>The description of the specified enumeration value, or null if no description is found.</returns>
        public static string? Description(this Enum? @enum)
        {
            FieldInfo? fieldInfo = @enum?.GetType()?.GetField(@enum?.ToString());
            if (fieldInfo is null)
            {
                return null;
            }

            if (fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) is DescriptionAttribute[] descriptionAttributes && descriptionAttributes.Length != 0)
            {
                return descriptionAttributes[0].Description;
            }

            return @enum!.ToString();
        }

        /// <summary>
        /// Gets the description of the specified type.
        /// </summary>
        /// <param name="type">The type for which to get the description.</param>
        /// <returns>The description of the specified type, or null if no description is found.</returns>
        public static string? Description(this Type? type)
        {
            if (type == null)
            {
                return null;
            }

            object[] objects = type.GetCustomAttributes(typeof(DescriptionAttribute), true);
            if (objects == null || objects.Length == 0)
            {
                return null;
            }

            foreach (object @object in objects)
            {
                if (@object is DescriptionAttribute descriptionAttribute)
                {
                    return descriptionAttribute.Description;
                }
            }

            return null;
        }
    }
}