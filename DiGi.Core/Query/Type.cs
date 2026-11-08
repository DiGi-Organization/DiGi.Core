using DiGi.Core.Classes;
using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the Type associated with the specified TypeReference.
        /// </summary>
        /// <param name="typeReference">The type reference to get the type for.</param>
        /// <returns>The Type associated with the specified TypeReference, or null if not found.</returns>
        public static Type? Type(this TypeReference? typeReference)
        {
            string? fullTypeName = typeReference?.FullTypeName;
            if (string.IsNullOrWhiteSpace(fullTypeName))
            {
                return null;
            }

            return Type(fullTypeName, false);
        }

        /// <summary>
        /// Gets the Type associated with the specified type name.
        /// </summary>
        /// <param name="typeName">The name of the type to search for.</param>
        /// <param name="ignoreCase">Whether to ignore case during comparison.</param>
        /// <returns>The Type associated with the specified type name, or null if not found.</returns>
        public static Type? Type(this string? typeName, bool ignoreCase = false)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }

            Type? result = System.Type.GetType(typeName, false, ignoreCase);
            if (result != null)
            {
                return result;
            }

            if (!typeName!.Contains(","))
            {
                string[] names = typeName.Split('.');
                if (names.Length > 1)
                {
                    List<string> values_Temp = [.. names];
                    values_Temp.RemoveAt(values_Temp.Count - 1);

                    string typeName_Temp = string.Format(CultureInfo.CurrentCulture, "{0},{1}", typeName, string.Join(".", values_Temp));
                    result = System.Type.GetType(typeName_Temp, false, ignoreCase);
                }

                return result;
            }

            string[] values = typeName.Split(',');
            if (values.Length > 1)
            {
                string? typeName_Temp = values[0]?.Trim();
                string? assemblyName = values[1]?.Trim();
                if (!string.IsNullOrWhiteSpace(typeName_Temp) && !string.IsNullOrWhiteSpace(assemblyName))
                {
                    if (ignoreCase)
                    {
                        typeName_Temp = typeName_Temp!.ToUpper(CultureInfo.CurrentCulture);
                        assemblyName = assemblyName!.ToUpper(CultureInfo.CurrentCulture);
                    }

                    Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
                    if (assemblies != null)
                    {
                        foreach (Assembly assembly in assemblies)
                        {
                            string? assemblyName_Temp = assembly?.GetName()?.Name?.Trim();
                            if (assemblyName_Temp == null)
                            {
                                continue;
                            }

                            if (ignoreCase)
                            {
                                assemblyName_Temp = assemblyName_Temp.ToUpper(CultureInfo.CurrentCulture);
                            }

                            if (!assemblyName!.Equals(assemblyName_Temp, StringComparison.Ordinal))
                            {
                                continue;
                            }

                            Type[] types = assembly!.GetTypes();
                            if (types != null)
                            {
                                foreach (Type type in types)
                                {
                                    string? typeName_Temp_Temp = type?.Name?.Trim();
                                    if (string.IsNullOrWhiteSpace(typeName_Temp_Temp))
                                    {
                                        continue;
                                    }

                                    if (ignoreCase)
                                    {
                                        typeName_Temp_Temp = typeName_Temp_Temp!.ToUpper(CultureInfo.CurrentCulture);
                                    }

                                    if (typeName_Temp!.Equals(typeName_Temp_Temp, StringComparison.Ordinal))
                                    {
                                        result = type;
                                        break;
                                    }

                                    if (typeName_Temp.Equals(string.Format(CultureInfo.CurrentCulture, "{0}.{1}", assemblyName, typeName_Temp_Temp), StringComparison.Ordinal))
                                    {
                                        result = type;
                                        break;
                                    }
                                }
                            }

                            return result;
                        }
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the Type associated with the specified type name using custom comparison and assembly filtering.
        /// </summary>
        /// <param name="typeName">The name of the type to search for.</param>
        /// <param name="textComparisonType">The type of text comparison to use.</param>
        /// <param name="ignoreCase">Whether to ignore case during comparison.</param>
        /// <param name="func">A function used to filter assemblies.</param>
        /// <returns>The Type associated with the specified type name, or null if not found.</returns>
        public static Type? Type(this string? typeName, TextComparisonType textComparisonType, bool ignoreCase = false, Func<Assembly, bool>? func = null)
        {
            if (string.IsNullOrWhiteSpace(typeName))
            {
                return null;
            }

            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            if (assemblies == null || assemblies.Length == 0)
            {
                return null;
            }

            string typeName_Temp = ignoreCase ? typeName!.ToLower(CultureInfo.CurrentCulture) : typeName!;

            foreach (Assembly assembly in assemblies)
            {
                if (func != null && !func.Invoke(assembly))
                {
                    continue;
                }

                Type[]? types = null;
                try
                {
                    types = assembly?.GetTypes();
                }
                catch
                {
                    continue;
                }

                if (types == null || types.Length == 0)
                {
                    continue;
                }

                foreach (Type type in types)
                {
                    string name;

                    name = ignoreCase ? type.FullName.ToLower(CultureInfo.CurrentCulture) : type.FullName;
                    if (Compare(name, typeName_Temp, textComparisonType))
                    {
                        return type;
                    }

                    name = ignoreCase ? type.Name.ToLower(CultureInfo.CurrentCulture) : type.Name;
                    if (Compare(name, typeName_Temp, textComparisonType))
                    {
                        return type;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the Type associated with the specified DataType.
        /// </summary>
        /// <param name="dataType">The data type to get the type for.</param>
        /// <returns>The Type associated with the specified DataType, or null if not found.</returns>
        public static Type? Type(this DataType dataType)
        {
            switch (dataType)
            {
                case Enums.DataType.Undefined:
                    return null;

                case Enums.DataType.SByte:
                    return typeof(sbyte);

                case Enums.DataType.Byte:
                    return typeof(byte);

                case Enums.DataType.Short:
                    return typeof(short);

                case Enums.DataType.UShort:
                    return typeof(ushort);

                case Enums.DataType.Int:
                    return typeof(int);

                case Enums.DataType.UInt:
                    return typeof(uint);

                case Enums.DataType.Long:
                    return typeof(long);

                case Enums.DataType.ULong:
                    return typeof(ulong);

                case Enums.DataType.Float:
                    return typeof(float);

                case Enums.DataType.Double:
                    return typeof(double);

                case Enums.DataType.Decimal:
                    return typeof(decimal);

                case Enums.DataType.DateTime:
                    return typeof(DateTime);

                case Enums.DataType.Bool:
                    return typeof(bool);

                case Enums.DataType.String:
                    return typeof(string);

                case Enums.DataType.Guid:
                    return typeof(Guid);

                case Enums.DataType.Enum:
                    return typeof(Enum);

                case Enums.DataType.ValueType:
                    return typeof(ValueType);

                case Enums.DataType.JsonNode:
                    return typeof(JsonNode);

                case Enums.DataType.SerializableObject:
                    return typeof(ISerializableObject);

                case Enums.DataType.Object:
                    return typeof(IObject);

                case Enums.DataType.Other:
                    return typeof(object);

                default:
                    break;
            }

            throw new NotImplementedException();
        }
    }
}