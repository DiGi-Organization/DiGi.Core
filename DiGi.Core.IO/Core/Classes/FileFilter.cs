using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Interfaces;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Classes
{
    /// <summary>
    /// Provides a filter for selecting files based on a name and a set of extensions.
    /// </summary>
    public sealed class FileFilter : SerializableObject, IIOObject
    {
        [JsonInclude, JsonPropertyName(nameof(Extensions))]
        private readonly List<string>? extensions;

        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileFilter"/> class with a specified name and extensions.
        /// </summary>
        /// <param name="name">The name of the filter.</param>
        /// <param name="extensions">The collection of file extensions associated with the filter.</param>
        public FileFilter(string? name, IEnumerable<string>? extensions)
            : base()
        {
            this.name = name;
            this.extensions = extensions == null ? null : [.. extensions];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileFilter"/> class by copying an existing filter.
        /// </summary>
        /// <param name="fileFilter">The existing filter to copy.</param>
        public FileFilter(FileFilter? fileFilter)
            : base(fileFilter)
        {
            if (fileFilter != null)
            {
                name = fileFilter.name;
                extensions = fileFilter.extensions == null ? null : [.. fileFilter.extensions];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileFilter"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to use for initialization.</param>
        public FileFilter(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the list of file extensions associated with this filter.
        /// </summary>
        [JsonIgnore]
        public List<string>? Extensions
        {
            get
            {
                return extensions == null ? null : [.. extensions];
            }
        }

        /// <summary>
        /// Gets or sets the descriptive name of the file filter.
        /// </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Creates a copy of the current object.
        /// </summary>
        /// <returns>A new instance of the current object containing a copy of its data.</returns>
        public override ISerializableObject? Clone()
        {
            return new FileFilter(this);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            return ToString().Equals((obj as FileFilter)?.ToString(), StringComparison.Ordinal);
        }

        /// <summary>
        /// Returns the hash code for the current object.
        /// </summary>
        /// <returns>The hash code for the current object.</returns>
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string representation of the current object.</returns>
        public override string ToString()
        {
            List<string> values = [];
            if (extensions != null)
            {
                foreach (string extension in extensions)
                {
                    if (string.IsNullOrWhiteSpace(extension))
                    {
                        continue;
                    }

                    values.Add(string.Format(CultureInfo.CurrentCulture, "*.{0}", extension));
                }
            }

            return string.Format(CultureInfo.CurrentCulture, "{0} ({1})|{1}", name ?? string.Empty, string.Join(";", values));
        }
    }
}