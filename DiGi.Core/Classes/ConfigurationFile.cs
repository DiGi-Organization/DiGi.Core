using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Manages the reading, writing, and retrieval of key-value pair configuration settings from a file.
    /// </summary>
    public class ConfigurationFile : SerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Dictionary))]
        private readonly Dictionary<string, string> dictionary = [];

        /// <summary>
        /// Initializes a new empty instance of the ConfigurationFile class.
        /// </summary>
        public ConfigurationFile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConfigurationFile class by copying settings from another instance.
        /// </summary>
        /// <param name="configurationFile">The source configuration file to copy from.</param>
        public ConfigurationFile(ConfigurationFile? configurationFile)
            : base(configurationFile)
        {
            if (configurationFile != null)
            {
                if (configurationFile.dictionary != null)
                {
                    foreach (KeyValuePair<string, string> keyValuePair in configurationFile.dictionary)
                    {
                        dictionary[keyValuePair.Key] = keyValuePair.Value;
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the ConfigurationFile class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing configuration data.</param>
        public ConfigurationFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the dictionary containing key-value configuration settings.
        /// </summary>
        [JsonIgnore]
        public Dictionary<string, string> Dictionary
        {
            get
            {
                return dictionary;
            }
        }

        /// <summary>
        /// Gets the list of all configuration key names.
        /// </summary>
        [JsonIgnore]
        public List<string> Names
        {
            get
            {
                return [.. dictionary.Keys];
            }
        }

        /// <summary>
        /// Adds or removes a boolean configuration setting.
        /// </summary>
        /// <param name="name">The key of the setting.</param>
        /// <param name="value">The value to set, or null to remove the setting.</param>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
        public bool Add(string name, bool? value)
        {
            if (name == null)
            {
                return false;
            }

            if (value is null)
            {
                return Remove(name);
            }

            dictionary[name.Trim()] = value.ToString();
            return true;
        }

        /// <summary>
        /// Adds or removes a string configuration setting.
        /// </summary>
        /// <param name="name">The key of the setting.</param>
        /// <param name="value">The value to set, or null to remove the setting.</param>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
        public bool Add(string name, string? value)
        {
            if (name == null)
            {
                return false;
            }

            if (value is null)
            {
                return Remove(name);
            }

            dictionary[name.Trim()] = string.Format(CultureInfo.CurrentCulture, "\"{0}\"", value);
            return true;
        }

        /// <summary>
        /// Adds or removes a double configuration setting.
        /// </summary>
        /// <param name="name">The key of the setting.</param>
        /// <param name="value">The value to set, or null to remove the setting.</param>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
        public bool Add(string name, double? value)
        {
            if (name == null)
            {
                return false;
            }

            if (value is null)
            {
                return Remove(name);
            }

            string text = value.Value.ToString(CultureInfo.InvariantCulture);
            if (!text.Contains("."))
            {
                text += ".0";
            }

            dictionary[name.Trim()] = text;
            return true;
        }

        /// <summary>
        /// Adds or removes an integer configuration setting.
        /// </summary>
        /// <param name="name">The key of the setting.</param>
        /// <param name="value">The value to set, or null to remove the setting.</param>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
        public bool Add(string name, int? value)
        {
            if (name == null)
            {
                return false;
            }

            if (value is null)
            {
                return Remove(name);
            }

            dictionary[name.Trim()] = (value?.ToString(CultureInfo.CurrentCulture) ?? string.Empty);
            return true;
        }

        /// <summary>
        /// Appends settings from another configuration file instance to this one.
        /// </summary>
        /// <param name="configurationFile">The source configuration file.</param>
        /// <returns>True if any settings were appended; otherwise, false.</returns>
        public bool Append(ConfigurationFile? configurationFile)
        {
            if (configurationFile?.dictionary is not Dictionary<string, string> dictionary)
            {
                return false;
            }

            bool result = false;

            foreach (KeyValuePair<string, string> keyValuePair in dictionary)
            {
                this.dictionary[keyValuePair.Key] = keyValuePair.Value;
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Checks if a configuration setting exists by its name.
        /// </summary>
        /// <param name="name">The key to look for.</param>
        /// <param name="caseSensitive">Whether the search should be case-sensitive.</param>
        /// <returns>True if the key exists; otherwise, false.</returns>
        public bool Contains(string? name, bool caseSensitive = false)
        {
            if (name is null)
            {
                return false;
            }

            string name_Temp = name.Trim();

            bool result = dictionary.ContainsKey(name_Temp);
            if (!caseSensitive)
            {
                return dictionary.TryGetFirstKey(name_Temp, out _, x => x?.ToUpper(CultureInfo.CurrentCulture));
            }

            return result;
        }

        /// <summary>
        /// Retrieves a configuration value and attempts to cast it to type T.
        /// </summary>
        /// <typeparam name="T">The target type.</typeparam>
        /// <param name="name">The key of the setting.</param>
        /// <param name="caseSensitive">Whether the search should be case-sensitive.</param>
        /// <returns>The value cast to T, or default if not found or conversion fails.</returns>
        public T? GetValue<T>(string name, bool caseSensitive = false)
        {
            if (!TryGetValue(name, out T? result, caseSensitive))
            {
                return default;
            }

            return result;
        }

        /// <summary>
        /// Retrieves a configuration value and attempts to cast it to type T, or returns a default value.
        /// </summary>
        /// <typeparam name="T">The target type.</typeparam>
        /// <param name="name">The key of the setting.</param>
        /// <param name="defaultValue">The value to return if not found or conversion fails.</param>
        /// <param name="caseSensitive">Whether the search should be case-sensitive.</param>
        /// <returns>The retrieved value cast to T, or the defaultValue.</returns>
        public T? GetValue<T>(string name, T? defaultValue, bool caseSensitive = false)
        {
            if (!TryGetValue(name, out T? result, caseSensitive))
            {
                return defaultValue;
            }

            return result;
        }

        /// <summary>
        /// Retrieves a configuration value as an object.
        /// </summary>
        /// <param name="name">The key of the setting.</param>
        /// <param name="caseSensitive">Whether the search should be case-sensitive.</param>
        /// <returns>The retrieved value, or null if not found.</returns>
        public object? GetValue(string name, bool caseSensitive = false)
        {
            if (!TryGetValue(name, out object? result, caseSensitive))
            {
                return null;
            }

            return result;
        }

        /// <summary>
        /// Reads configuration settings from a file at the specified path.
        /// </summary>
        /// <param name="path">The absolute or relative path to the configuration file.</param>
        /// <returns>True if the file was read successfully; otherwise, false.</returns>
        public bool Read(string path)
        {
            if (path == null || !System.IO.File.Exists(path))
            {
                return false;
            }

            string[] lines = System.IO.File.ReadAllLines(path);
            if (lines == null || lines.Length == 0)
            {
                return false;
            }

            return Read(lines);
        }

        /// <summary>
        /// Reads configuration settings from an array of strings (lines).
        /// </summary>
        /// <param name="lines">The lines to parse as key-value pairs.</param>
        /// <returns>True if at least one setting was read successfully; otherwise, false.</returns>
        public bool Read(string[]? lines)
        {
            if (lines == null || lines.Length == 0)
            {
                return false;
            }

            bool result = false;

            foreach (string line in lines)
            {
                int index = line.IndexOf("=", StringComparison.CurrentCulture);
                if (index == -1)
                {
                    continue;
                }

                string name = line.Substring(0, index);
                string text = line.Substring(index + 1);

                if (text.StartsWith("\"", StringComparison.CurrentCulture) && text.EndsWith("\"", StringComparison.CurrentCulture))
                {
                    text = text.Substring(1, text.Length - 2);
                }

                Add(name, text);
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Removes a configuration setting by its name.
        /// </summary>
        /// <param name="name">The key of the setting to remove.</param>
        /// <returns>True if the setting was removed; otherwise, false.</returns>
        public bool Remove(string name)
        {
            if (name == null)
            {
                return false;
            }

            string name_Temp = name.Trim();

            return dictionary.Remove(name_Temp);
        }

        /// <summary>
        /// Attempts to retrieve a configuration value and convert it to type T.
        /// </summary>
        /// <typeparam name="T">The target type.</typeparam>
        /// <param name="name">The key of the setting.</param>
        /// <param name="value">The converted value, if successful.</param>
        /// <param name="caseSensitive">Whether the search should be case-sensitive.</param>
        /// <returns>True if the value was found and successfully converted; otherwise, false.</returns>
        public bool TryGetValue<T>(string name, out T? value, bool caseSensitive = false)
        {
            value = default;

            if (name is null)
            {
                return false;
            }

            string name_Temp = name.Trim();

            if (!dictionary.TryGetValue(name_Temp, out string text))
            {
                if (caseSensitive)
                {
                    return false;
                }

                if (!dictionary.TryGetFirstKey(name_Temp, out string? key, x => x?.ToUpper(CultureInfo.CurrentCulture)) || string.IsNullOrWhiteSpace(key))
                {
                    return false;
                }

                if (!dictionary.TryGetValue(key!, out text))
                {
                    return false;
                }
            }

            if (text.StartsWith("\"", StringComparison.CurrentCulture) && text.EndsWith("\"", StringComparison.CurrentCulture))
            {
                text = text.Substring(1, text.Length - 2);
            }

            return Query.TryConvert(text, out value);
        }

        /// <summary>
        /// Writes the current configuration settings to a file at the specified path.
        /// </summary>
        /// <param name="path">The path where the configuration file should be written.</param>
        /// <returns>True if the file was written successfully; otherwise, false.</returns>
        public bool Write(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            string directory = System.IO.Path.GetDirectoryName(path);
            if (string.IsNullOrEmpty(directory) || !System.IO.Directory.Exists(directory))
            {
                return false;
            }

            List<string> lines = [];
            foreach (KeyValuePair<string, string> keyValuePair in dictionary)
            {
                lines.Add(string.Format(CultureInfo.CurrentCulture, "{0}={1}", keyValuePair.Key, keyValuePair.Value));
            }

            System.IO.File.WriteAllLines(path, lines);
            return true;
        }
    }
}