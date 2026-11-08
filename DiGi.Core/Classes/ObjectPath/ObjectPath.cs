using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Base class for representing a hierarchical path to an object.
    /// </summary>
    /// <typeparam name="TObjectPath">The type of the object path.</typeparam>
    public abstract class ObjectPath<TObjectPath> : SerializableObject, IObjectPath<TObjectPath> where TObjectPath : ObjectPath<TObjectPath>
    {
        [JsonInclude, JsonPropertyName("Name")]
        private string name = string.Empty;

        [JsonInclude, JsonPropertyName("Path")]
        private TObjectPath? path = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPath"/> class using a collection of segment names.
        /// </summary>
        /// <param name="names">The collection of segment names.</param>
        public ObjectPath(IEnumerable<string>? names)
        {
            List<string>? names_Temp = names == null ? null : [.. names];
            if (names_Temp != null && names_Temp.Count != 0)
            {
                Name = names_Temp[0] ?? string.Empty;
                if (names_Temp.Count > 1)
                {
                    names_Temp.RemoveAt(0);
                    Add(names_Temp);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPath"/> class with a single segment name.
        /// </summary>
        /// <param name="name">The name of the single segment.</param>
        public ObjectPath(string? name)
            : this([name ?? string.Empty])
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPath"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to create the path from.</param>
        public ObjectPath(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPath"/> class by appending a name to an existing path.
        /// </summary>
        /// <param name="name">The name of the segment to append.</param>
        /// <param name="path">The existing path to which the name is appended.</param>
        public ObjectPath(string? name, TObjectPath? path)
            : this(name)
        {
            Path = path?.Clone<TObjectPath>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPath"/> class by copying an existing path.
        /// </summary>
        /// <param name="path">The existing path to copy.</param>
        public ObjectPath(ObjectPath<TObjectPath>? path)
            : base(path)
        {
            if (path != null)
            {
                name = path.name;
                this.path = path.path?.Clone<TObjectPath>();
            }
        }

        /// <summary>
        /// Gets the character used to separate segments in the path.
        /// </summary>
        [JsonIgnore]
        [SuppressMessage("Design", "CA1000:Do not declare static members on generic types", Justification = "Public member reached as ObjectPath<T>.Separator across the workspace; moving it is a breaking change.")]
        public static string Separator { get; } = "->";

        /// <summary>
        /// Gets the name of the current path segment.
        /// </summary>
        [JsonIgnore]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Gets the parent path segment.
        /// </summary>
        [JsonIgnore]
        public TObjectPath? Path
        {
            get
            {
                return path?.Clone<TObjectPath>();
            }

            set
            {
                path = value?.Clone<TObjectPath>();
            }
        }

        /// <summary>
        /// Appends a new segment to the path and returns the resulting path.
        /// </summary>
        /// <param name="name">The name of the segment to append.</param>
        /// <returns>The resulting path after appending the segment.</returns>
        public TObjectPath? Add(string? name)
        {
            if (name == null)
            {
                return null;
            }

            return Add([name]);
        }

        /// <summary>
        /// Appends multiple segments to the path and returns the resulting path.
        /// </summary>
        /// <param name="names">The collection of segment names to append.</param>
        /// <returns>The resulting path after appending the segments.</returns>
        public TObjectPath? Add(IEnumerable<string>? names)
        {
            if (names == null || !names.Any())
            {
                return null;
            }

            if (path != null)
            {
                return path.Add(names);
            }

            List<TObjectPath> paths = [];
            foreach (string name in names)
            {
                if (Create(name) is TObjectPath newPath)
                {
                    paths.Add(newPath);
                }
            }

            if (paths.Count == 0)
            {
                return null;
            }

            while (paths.Count > 1)
            {
                int count = paths.Count;

                paths[count - 2].Path = paths[count - 1];

                paths.RemoveAt(count - 1);
            }

            TObjectPath? result = paths[0];

            Path = result;

            return result;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current path.
        /// </summary>
        /// <param name="obj">The object to compare with the current path.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            return ToString() == obj?.ToString();
        }

        /// <summary>
        /// Returns the hash code for this path.
        /// </summary>
        /// <returns>The hash code for this path.</returns>
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        /// <summary>
        /// Retrieves a list of all segment names in the path.
        /// </summary>
        /// <param name="includeName">A value indicating whether to include the name.</param>
        /// <returns>A list of strings containing the segment names.</returns>
        public List<string> GetNames(bool includeName = true)
        {
            List<string> result = [];
            if (includeName)
            {
                result.Add(Name);
            }

            TObjectPath? currentPath = Path;
            while (currentPath != null)
            {
                result.Add(currentPath.Name);
                currentPath = currentPath.Path;
            }

            return result;
        }

        /// <summary>
        /// Returns a string representation of the hierarchical path.
        /// </summary>
        /// <returns>A string representing the hierarchical path.</returns>
        public override string ToString()
        {
            string result = Name ?? string.Empty;
            result = string.Format(CultureInfo.CurrentCulture, "\"{0}\"", result.Replace("\"", "\"\""));
            if (path != null)
            {
                result += Separator + path.ToString();
            }

            return result;
        }

        protected abstract TObjectPath? Create(string name);
    }

    /// <summary>
    /// Represents a hierarchical path to an object.
    /// </summary>
    public class ObjectPath : ObjectPath<ObjectPath>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPath"/> class using a collection of segment names.
        /// </summary>
        /// <param name="names">The collection of segment names to include in the path.</param>
        public ObjectPath(IEnumerable<string> names)
            : base(names)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPath"/> class with a single segment name.
        /// </summary>
        /// <param name="name">The name of the path segment.</param>
        public ObjectPath(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPath"/> class by appending a name to an existing path.
        /// </summary>
        /// <param name="name">The name of the segment to append.</param>
        /// <param name="path">The existing path to which the name is appended.</param>
        public ObjectPath(string name, ObjectPath path)
            : base(name, path)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPath"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the path.</param>
        public ObjectPath(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        protected override ObjectPath Create(string name)
        {
            return new ObjectPath(name);
        }
    }
}