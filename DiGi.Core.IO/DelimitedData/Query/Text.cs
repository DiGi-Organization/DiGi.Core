using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DiGi.Core.IO.DelimitedData
{
    public static partial class Query
    {
        /// <summary>
        /// Joins a collection of values into a delimited string.
        /// </summary>
        /// <param name="values">The collection of strings to join.</param>
        /// <param name="separator">The character used as the delimiter between strings.</param>
        /// <returns>A string containing the joined values, or null if the input is null.</returns>
        public static string? Text(this IEnumerable<string?>? values, char separator)
        {
            if (values == null)
            {
                return null;
            }

            StringBuilder stringBuilder = new();
            bool firstColumn = true;
            foreach (string? value in values)
            {
                // Add separator if this isn't the first value
                if (!firstColumn)
                {
                    stringBuilder.Append(separator);
                }

                // Implement special handling for values that contain comma or quote Enclose in
                // quotes and double up any double quotes
                if (value == null)
                {
                    stringBuilder.Append(string.Empty);
                }
                else if (value.IndexOfAny(['"', separator, '\n']) != -1)
                {
                    stringBuilder.AppendFormat(CultureInfo.CurrentCulture, "\"{0}\"", value.Replace("\"", "\"\""));
                }
                else
                {
                    stringBuilder.Append(value);
                }

                firstColumn = false;
            }

            return stringBuilder.ToString();
        }
    }
}