using System.Globalization;
using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the full name of an enum value, including its full type name.
        /// </summary>
        /// <param name="enum">The enum value.</param>
        /// <returns>The formatted full name string, or null if the input is null.</returns>
        public static string? FullName(this Enum? @enum)
        {
            if (@enum == null)
            {
                return null;
            }

            return string.Format(CultureInfo.CurrentCulture, "{0}:{1}", FullTypeName(@enum.GetType()), @enum.ToString());
        }
    }
}