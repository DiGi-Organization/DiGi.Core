using DiGi.Core.IO.Table.Classes;
using DiGi.Core.IO.Table.Interfaces;
using System.Text.Json;

namespace DiGi.Core.IO.Table
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a serializable Table to its JSON string representation using default options (WARINNG! all table values have to be serializable objects otherwise converted data may be missing).
        /// </summary>
        /// <typeparam name="UTable">The type of the table.</typeparam>
        /// <typeparam name="UColumn">The type of the column.</typeparam>
        /// <typeparam name="URow">The type of the row.</typeparam>
        /// <param name="table">The table to be converted to a JSON string.</param>
        /// <returns>A JSON string representation of the table, or null if the provided table is null.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1869:Cache and reuse 'JsonSerializerOptions' instances", Justification = "The options carry a converter generic over this call's type arguments; sharing one needs a static holder per closed type, i.e. a cache (Coding - General.md 1.20).")]
        public static string? ToSystem_String<UTable, UColumn, URow>(this UTable? table) where UTable : ITable<UColumn, URow>, new() where UColumn : IColumn where URow : IRow<URow>
        {
            JsonSerializerOptions jsonSerializerOptions = new();
            jsonSerializerOptions.Converters.Add(new TableConverter<UTable, UColumn, URow>());

            // Zero string allocations - pipes the bytes directly into the destination stream asynchronously
            return JsonSerializer.Serialize(table, jsonSerializerOptions);
        }
    }
}