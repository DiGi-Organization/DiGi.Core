using DiGi.Core.IO.Table.Interfaces;
using System.Globalization;

namespace DiGi.Core.IO
{
    public static partial class Query
    {
        /// <summary>
        /// Generates a unique identifier for the specified column by normalizing its name.
        /// </summary>
        /// <param name="column">The column instance to process.</param>
        /// <returns>A normalized string representing the unique identifier, or null if the column or its name is null.</returns>
        public static string? UniqueId(this IColumn? column)
        {
            if (column?.Name is not string name)
            {
                return null;
            }

            return name.ToLower(CultureInfo.CurrentCulture).Trim().Replace(" ", "_").Replace("[", "").Replace("]", "").Replace(".", "_").Replace(",", "_");
        }
    }
}
