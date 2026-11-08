using System.Globalization;
using System;
using System.ComponentModel;
using System.Reflection;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Attempts to parse a "TypeFullName:EnumValueName" formatted string into an Enum value.
        /// </summary>
        /// <param name="text">The text in "TypeFullName:EnumValueName" format.</param>
        /// <param name="enum">When this method returns, contains the parsed Enum value, or null if parsing failed.</param>
        /// <returns>True if the parsing was successful; otherwise, false.</returns>
        public static bool TryGetEnum(string? text, out Enum? @enum)
        {
            @enum = default;
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }

            string[] strings = text!.Split(':');
            if (strings.Length < 2)
            {
                return false;
            }

            Type? type = Type(strings[0]);
            if (type == null)
            {
                return false;
            }

            return TryGetEnum(strings[1], type, out @enum);
        }

        /// <summary>
        /// Attempts to parse a string into an enum value by checking exact names, numeric values, descriptions, and fuzzy matching.
        /// </summary>
        /// <param name="text">The string text to be parsed.</param>
        /// <param name="type">The type of the enum to parse into.</param>
        /// <param name="enum">When this method returns, contains the parsed enum value if successful; otherwise, null.</param>
        /// <returns>True if the string was successfully parsed into an enum value; otherwise, false.</returns>
        public static bool TryGetEnum(this string? text, Type? type, out Enum? @enum)
        {
            @enum = null;

            if (string.IsNullOrEmpty(text) || type == null || !type.IsEnum)
            {
                return false;
            }

            // 1. Fast path: Direct exact name lookup via reflection hashtable
            FieldInfo? fieldInfo_Exact = type.GetField(text!, BindingFlags.Public | BindingFlags.Static);
            if (fieldInfo_Exact != null && fieldInfo_Exact.IsLiteral)
            {
                @enum = (Enum)fieldInfo_Exact.GetValue(null)!;
                return true;
            }

            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Public | BindingFlags.Static);
            if (fieldInfos.Length == 0)
            {
                return false;
            }

            // 2. Numeric string matching (e.g. "2", "-1")
            if (long.TryParse(text, out long numericValue))
            {
                for (int i = 0; i < fieldInfos.Length; i++)
                {
                    FieldInfo fieldInfo = fieldInfos[i];
                    long fieldValue = System.Convert.ToInt64(fieldInfo.GetRawConstantValue(), CultureInfo.CurrentCulture);
                    if (fieldValue == numericValue)
                    {
                        @enum = (Enum)fieldInfo.GetValue(null)!;
                        return true;
                    }
                }
            }

            // 3. Exact Description matching (case-sensitive)
            for (int i = 0; i < fieldInfos.Length; i++)
            {
                FieldInfo fieldInfo = fieldInfos[i];
                if (fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) is DescriptionAttribute[] descriptionAttributes && descriptionAttributes.Length > 0)
                {
                    if (string.Equals(descriptionAttributes[0].Description, text, StringComparison.Ordinal))
                    {
                        @enum = (Enum)fieldInfo.GetValue(null)!;
                        return true;
                    }
                }
            }

            // 4. Fuzzy Name matching (case-insensitive, ignoring spaces)
            for (int i = 0; i < fieldInfos.Length; i++)
            {
                FieldInfo fieldInfo = fieldInfos[i];
                if (EqualsIgnoreSpaces(fieldInfo.Name, text!, true))
                {
                    @enum = (Enum)fieldInfo.GetValue(null)!;
                    return true;
                }
            }

            // 5. Fuzzy Description matching (case-insensitive, ignoring spaces)
            for (int i = 0; i < fieldInfos.Length; i++)
            {
                FieldInfo fieldInfo = fieldInfos[i];
                if (fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) is DescriptionAttribute[] descriptionAttributes && descriptionAttributes.Length > 0)
                {
                    string? description = descriptionAttributes[0].Description;
                    if (description != null && EqualsIgnoreSpaces(description, text!, true))
                    {
                        @enum = (Enum)fieldInfo.GetValue(null)!;
                        return true;
                    }
                }
            }

            @enum = null;
            return false;

            bool EqualsIgnoreSpaces(string string_1, string string_2, bool ignoreCase)
            {
                int index_1 = 0;
                int index_2 = 0;
                while (index_1 < string_1.Length || index_2 < string_2.Length)
                {
                    while (index_1 < string_1.Length && string_1[index_1] == ' ')
                    {
                        index_1++;
                    }
                    while (index_2 < string_2.Length && string_2[index_2] == ' ')
                    {
                        index_2++;
                    }

                    if (index_1 == string_1.Length && index_2 == string_2.Length)
                    {
                        return true;
                    }
                    if (index_1 == string_1.Length || index_2 == string_2.Length)
                    {
                        return false;
                    }

                    char char_1 = string_1[index_1];
                    char char_2 = string_2[index_2];

                    if (ignoreCase)
                    {
                        if (char.ToUpperInvariant(char_1) != char.ToUpperInvariant(char_2))
                        {
                            return false;
                        }
                    }
                    else if (char_1 != char_2)
                    {
                        return false;
                    }

                    index_1++;
                    index_2++;
                }

                return true;
            }
        }

        /// <summary>
        /// Attempts to parse a string into a strongly-typed enum value of type <typeparamref name="TEnum"/>.
        /// </summary>
        /// <typeparam name="TEnum">The target enum type.</typeparam>
        /// <param name="text">The text to parse.</param>
        /// <param name="enum">When this method returns, contains the parsed TEnum value, or default if parsing failed.</param>
        /// <returns>True if the parsing was successful; otherwise, false.</returns>
        public static bool TryGetEnum<TEnum>(this string? text, out TEnum? @enum) where TEnum : Enum
        {
            @enum = default;
            if (!TryGetEnum(text, typeof(TEnum), out Enum? @enum_Temp))
            {
                return false;
            }

            if (enum_Temp is not TEnum)
            {
                return false;
            }

            @enum = (TEnum)enum_Temp;
            return true;
        }
    }
}