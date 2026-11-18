using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Extracts the value from a <see cref="JsonNode"/> cast to the specified type.
        /// </summary>
        /// <param name="jsonNode">The JSON node to extract the value from.</param>
        /// <param name="type">The target type to cast the value to.</param>
        /// <returns>The extracted value cast to the specified type, or null if the operation fails or the input is null.</returns>
        public static object? Value(this JsonNode? jsonNode, Type? type)
        {
            if (jsonNode == null || type == null)
            {
                return null;
            }

            if (jsonNode.GetType() == type)
            {
                return jsonNode;
            }

            Type? type_Underlying = Nullable.GetUnderlyingType(type);
            bool nullable = type_Underlying != null;
            Type type_Temp = type_Underlying ?? type;

            if (nullable && jsonNode.GetValueKind() == System.Text.Json.JsonValueKind.Null)
            {
                return null;
            }

            JsonValue? jsonValue_Scalar = jsonNode as JsonValue;

            if (type_Temp.IsEnum)
            {
                if (jsonValue_Scalar == null)
                {
                    return null;
                }

                JsonValue jsonValue = jsonValue_Scalar;

                object? value_Temp = null;
                switch (jsonValue.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.String:
                        if (jsonValue.TryGetValue(out string? @string))
                        {
                            value_Temp = @string;
                        }
                        break;

                    case System.Text.Json.JsonValueKind.Number:
                        if (jsonValue.TryGetValue(out int @int))
                        {
                            value_Temp = @int;
                        }
                        break;
                }

                if (value_Temp == null)
                {
                    if (jsonValue.TryGetValue(out int @int))
                    {
                        value_Temp = @int;
                    }
                    else if (jsonValue.TryGetValue(out string? @string))
                    {
                        value_Temp = @string;
                    }
                    else if (!jsonValue.TryGetValue(out value_Temp))
                    {
                        value_Temp = null;
                    }
                }

                if (nullable && value_Temp == null)
                {
                    return null;
                }

                if (TryConvert(value_Temp, out value_Temp, type_Temp))
                {
                    return value_Temp;
                }

                if (nullable)
                {
                    return null;
                }

                Array array_Enum = System.Enum.GetValues(type_Temp);
                if (array_Enum != null && array_Enum.Length != 0)
                {
                    return array_Enum.GetValue(0);
                }

                return null;
            }

            // Handled before the switch below, because a DateTimeOffset reports TypeCode.Object and would
            // otherwise fall through to the general object path and be asked to convert a JSON string into a
            // struct, which throws. TryConvert_DateTimeOffset already reads the ISO 8601 form.
            // Worth keeping over a plain DateTime wherever a moment is serialized: a DateTime written as UTC is
            // read back in the local zone, so serializing the same object twice produces two different documents.
            if (type_Temp == typeof(DateTimeOffset))
            {
                if (TryConvert_DateTimeOffset(jsonNode, out DateTimeOffset? dateTimeOffset) && dateTimeOffset is not null)
                {
                    return dateTimeOffset.Value;
                }

                if (nullable)
                {
                    return null;
                }

                return default(DateTimeOffset);
            }

            TypeCode typeCode = System.Type.GetTypeCode(type_Temp);

            switch (typeCode)
            {
                case TypeCode.String:
                    if (jsonValue_Scalar != null && jsonValue_Scalar.TryGetValue(out string? string_Fast))
                    {
                        return string_Fast;
                    }

                    if (TryConvert_String(jsonNode, out string? @string))
                    {
                        return @string;
                    }
                    return default(string);

                case TypeCode.Boolean:
                    if (jsonValue_Scalar != null && jsonValue_Scalar.TryGetValue(out bool bool_Fast))
                    {
                        return bool_Fast;
                    }

                    if (TryConvert_Boolean(jsonNode, out bool? @bool) && @bool is not null)
                    {
                        return @bool.Value;
                    }
                    return default(bool);

                case TypeCode.DateTime:
                    if (TryConvert_DateTime(jsonNode, out DateTime? dateTime) && dateTime is not null)
                    {
                        return dateTime.Value;
                    }
                    return default(DateTime);

                case TypeCode.Int32:
                    if (jsonValue_Scalar != null && jsonValue_Scalar.TryGetValue(out int int_Fast))
                    {
                        return int_Fast;
                    }

                    if (TryConvert_Int(jsonNode, out int? @int) && @int is not null)
                    {
                        return @int.Value;
                    }
                    return default(int);

                case TypeCode.UInt32:
                    if (jsonValue_Scalar != null && jsonValue_Scalar.TryGetValue(out uint uint_Fast))
                    {
                        return uint_Fast;
                    }

                    if (TryConvert_Uint(jsonNode, out uint? @uint) && @uint is not null)
                    {
                        return @uint.Value;
                    }
                    return default(uint);

                case TypeCode.Int64:
                    if (jsonValue_Scalar != null && jsonValue_Scalar.TryGetValue(out long long_Fast))
                    {
                        return long_Fast;
                    }

                    if (TryConvert_Long(jsonNode, out long? @long) && @long is not null)
                    {
                        return @long.Value;
                    }
                    return default(long);

                case TypeCode.UInt64:
                    if (jsonValue_Scalar != null && jsonValue_Scalar.TryGetValue(out ulong ulong_Fast))
                    {
                        return ulong_Fast;
                    }

                    if (TryConvert_Ulong(jsonNode, out ulong? @ulong) && @ulong is not null)
                    {
                        return @ulong.Value;
                    }
                    return default(ulong);

                case TypeCode.Int16:
                    if (jsonValue_Scalar != null && jsonValue_Scalar.TryGetValue(out short short_Fast))
                    {
                        return short_Fast;
                    }

                    if (TryConvert_Short(jsonNode, out short? @short) && @short is not null)
                    {
                        return @short.Value;
                    }
                    return default(short);

                case TypeCode.UInt16:
                    if (jsonValue_Scalar != null && jsonValue_Scalar.TryGetValue(out ushort ushort_Fast))
                    {
                        return ushort_Fast;
                    }

                    if (TryConvert_Ushort(jsonNode, out ushort? @ushort) && @ushort is not null)
                    {
                        return @ushort.Value;
                    }
                    return default(ushort);

                case TypeCode.Double:
                    if (jsonValue_Scalar != null && jsonValue_Scalar.TryGetValue(out double double_Fast))
                    {
                        return double_Fast;
                    }

                    if (TryConvert_Double(jsonNode, out double? @double) && @double is not null)
                    {
                        return @double.Value;
                    }
                    return default(double);

                case TypeCode.Single:
                    if (jsonValue_Scalar != null && jsonValue_Scalar.TryGetValue(out float float_Fast))
                    {
                        return float_Fast;
                    }

                    if (TryConvert_Float(jsonNode, out float? @float) && @float is not null)
                    {
                        return @float.Value;
                    }
                    return default(float);

                case TypeCode.Byte:
                    if (jsonValue_Scalar != null && jsonValue_Scalar.TryGetValue(out byte byte_Fast))
                    {
                        return byte_Fast;
                    }

                    if (TryConvert_Byte(jsonNode, out byte? @byte) && @byte is not null)
                    {
                        return @byte.Value;
                    }
                    return default(byte);
            }

            if (type_Temp == typeof(Guid))
            {
                return jsonNode.GetValue<Guid>();
            }

            if (type_Temp == typeof(System.Drawing.Color))
            {
                Color? color = Create.SerializableObject<Color>(jsonNode.AsObject());
                if (color is null)
                {
                    return System.Drawing.Color.Empty;
                }

                return (System.Drawing.Color)color;
            }

            if (type_Temp == typeof(TimeSpan))
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        long ticks = jsonNode.GetValue<long>();

                        return TimeSpan.FromTicks(ticks);

                    case System.Text.Json.JsonValueKind.String:
                        object? @object = jsonNode.GetValue<object>();
                        if (@object is TimeSpan timeSpan)
                        {
                            return timeSpan;
                        }

                        if (@object is System.Text.Json.JsonElement)
                        {
                            @object = jsonNode.GetValue<string>();
                            if (TryConvert(@object, out timeSpan))
                            {
                                return timeSpan;
                            }
                        }

                        return null;
                }

                return null;
            }

            if (type_Temp.IsSubclassOf(typeof(Type)) || type_Temp == typeof(Type))
            {
                if (Value(jsonNode, typeof(string)) is not string fullName)
                {
                    return null;
                }

                return Type(fullName);
            }

            if (IsNumeric(type_Temp))
            {
                return jsonNode.GetValue<double>();
            }

            if (typeof(ISerializableObject).IsAssignableFrom(type_Temp))
            {
                return Create.SerializableObject<ISerializableObject>(jsonNode.AsObject());
            }

            if (typeof(Array).IsAssignableFrom(type_Temp))
            {
                Type? type_Array = type_Temp.GetElementType();

                JsonArray? jsonArray = type_Array == null ? null : jsonNode.AsArray();
                if (jsonArray != null)
                {
                    int count = jsonArray.Count;

                    Array array = Array.CreateInstance(type_Array!, count);
                    for (int i = 0; i < count; i++)
                    {
                        object? @object = Value(jsonArray[i], type_Array);
                        if (@object != null && !type_Array!.IsAssignableFrom(@object.GetType()))
                        {
                            @object = type_Array.GetConstructor([@object.GetType()])?.Invoke([@object]);
                        }

                        array.SetValue(@object, i);
                    }

                    return array;
                }
            }

            if (typeof(IList).IsAssignableFrom(type_Temp))
            {
                Type[] genericTypes = type_Temp.GenericTypeArguments;
                Type? genericType = genericTypes != null && genericTypes.Length > 0 ? genericTypes[0] : null;
                if (genericType != null)
                {
                    IList? list = Create.List(genericType);
                    if (list == null)
                    {
                        return null;
                    }

                    JsonArray? jsonArray = jsonNode.AsArray();
                    if (jsonArray != null)
                    {
                        foreach (JsonNode? jsonNode_Temp in jsonArray)
                        {
                            object? @object = Value(jsonNode_Temp, genericType);
                            if (@object != null && !genericType.IsAssignableFrom(@object.GetType()))
                            {
                                @object = genericType.GetConstructor([@object.GetType()])?.Invoke([@object]);
                            }

                            list.Add(@object);
                        }

                        return Activator.CreateInstance(type, list);
                    }
                }
            }

            if (typeof(IDictionary).IsAssignableFrom(type_Temp))
            {
                Type[] genericTypes = type.GenericTypeArguments;
                Type? genericType_Key = genericTypes != null && genericTypes.Length > 0 ? genericTypes[0] : null;
                Type? genericType_Value = genericTypes != null && genericTypes.Length > 1 ? genericTypes[1] : null;

                if (genericType_Key != null && genericType_Value != null)
                {
                    IDictionary? dictionary = Create.Dictionary(genericType_Key, genericType_Value);
                    if (dictionary is null)
                    {
                        return null;
                    }

                    switch (jsonNode.GetValueKind())
                    {
                        case System.Text.Json.JsonValueKind.Array:
                            JsonArray? jsonArray = jsonNode.AsArray();
                            if (jsonArray != null)
                            {
                                foreach (JsonNode? jsonNode_Temp in jsonArray)
                                {
                                    if (jsonNode_Temp is null)
                                    {
                                        continue;
                                    }

                                    object? key = Value(jsonNode_Temp["Key"], genericType_Key);
                                    if (key != null)
                                    {
                                        dictionary[key] = Value(jsonNode_Temp["Value"], genericType_Value);
                                    }
                                }

                                return Activator.CreateInstance(type, dictionary);
                            }
                            break;

                        case System.Text.Json.JsonValueKind.Object:
                            JsonObject? jsonObject = jsonNode.AsObject();
                            if (jsonObject != null)
                            {
                                foreach (KeyValuePair<string, JsonNode?> keyValuePair in jsonObject)
                                {
                                    object? key = Value(keyValuePair.Key, genericType_Key);
                                    if (key != null)
                                    {
                                        dictionary[key] = Value(keyValuePair.Value, genericType_Value);
                                    }
                                }

                                return Activator.CreateInstance(type, dictionary);
                            }
                            break;
                    }
                }
            }

            System.Text.Json.JsonValueKind jsonValueKind = jsonNode.GetValueKind();
            if (jsonValueKind is System.Text.Json.JsonValueKind.Object && jsonNode is not JsonObject)
            {
                jsonNode = JsonNode.Parse(jsonNode.ToJsonString())!.AsObject();
            }

            object? value = null;

            object? ReadNumber(JsonNode node)
            {
                object? object_Value = node.GetValue<object>();

                if (object_Value is System.Text.Json.JsonElement element_Value)
                {
                    // Parsed (text) leg: the node is element-backed - canonicalize to the narrowest CLR type that
                    // round-trips, so a whole number reads back as an int rather than a double.
                    if (element_Value.TryGetInt32(out int int_Value))
                    {
                        return int_Value;
                    }

                    if (element_Value.TryGetInt64(out long long_Value))
                    {
                        return long_Value;
                    }

                    return element_Value.GetDouble();
                }

                if (IsNumeric(object_Value))
                {
                    // CLR-backed (clone) leg: the node holds a boxed CLR numeric - keep its exact type (an int stays an
                    // int, a decimal stays a decimal) instead of asking the node for a double it does not hold.
                    return object_Value;
                }

                // Unreachable for a JsonValueKind.Number node: it is either element-backed (handled above) or holds a boxed
                // CLR numeric (handled above). Throwing surfaces a future kind mismatch instead of silently widening it.
                throw new InvalidOperationException("A JsonValueKind.Number node holds neither a JsonElement nor a boxed CLR numeric, so it cannot be read as a number.");
            }

            switch (jsonValueKind)
            {
                case System.Text.Json.JsonValueKind.String:
                    // CLR-backed (clone) leg: a node built from a boxed Guid, DateTime, ... has kind String but holds no
                    // string, so GetValue<string>() throws - read its JSON text instead, exactly as the text leg would.
                    value = jsonNode.AsValue().TryGetValue(out string? string_Value) ? string_Value : JsonNode.Parse(jsonNode.ToJsonString())!.GetValue<string>();
                    break;

                case System.Text.Json.JsonValueKind.True:
                    value = true;
                    break;

                case System.Text.Json.JsonValueKind.Number:
                    value = ReadNumber(jsonNode);
                    break;

                case System.Text.Json.JsonValueKind.False:
                    value = false;
                    break;

                case System.Text.Json.JsonValueKind.Null:
                    value = null;
                    break;

                case System.Text.Json.JsonValueKind.Object:
                    JsonObject jsonObject = (JsonObject)jsonNode;

                    if (jsonObject.ContainsKey(Constants.Serialization.PropertyName.Type))
                    {
                        ISerializableObject? serializableObject = Create.SerializableObject<ISerializableObject>(jsonObject);
                        if (serializableObject is SerializableObjectWrapper)
                        {
                            value = serializableObject.ToJsonObject();
                        }
                        else
                        {
                            value = serializableObject;
                        }
                    }
                    break;

                case System.Text.Json.JsonValueKind.Array:
                    value = jsonNode;
                    break;
            }

            if (value is not null && TryConvert(value, out object? result, type))
            {
                return result;
            }

            if (typeof(IEnumerable).IsAssignableFrom(type_Temp))
            {
                Type[] genericTypes = type_Temp.GenericTypeArguments;
                Type? genericType = genericTypes != null && genericTypes.Length > 0 ? genericTypes[0] : null;
                if (genericType != null)
                {
                    IList? list = Create.List(genericType);
                    if (list == null)
                    {
                        return null;
                    }

                    JsonArray? jsonArray = jsonNode.AsArray();
                    if (jsonArray != null)
                    {
                        foreach (JsonNode? jsonNode_Temp in jsonArray)
                        {
                            object? @object = Value(jsonNode_Temp, genericType);
                            if (@object != null && !genericType.IsAssignableFrom(@object.GetType()))
                            {
                                @object = genericType.GetConstructor([@object.GetType()])?.Invoke([@object]);
                            }

                            list.Add(@object);
                        }

                        if (type.IsAbstract)
                        {
                            if (type.IsAssignableFrom(list.GetType()))
                            {
                                return list;
                            }

                            throw new NotImplementedException();
                        }

                        return Activator.CreateInstance(type, list);
                    }
                }
            }

            if (type_Temp.IsGenericType && type_Temp.GetGenericTypeDefinition() == typeof(KeyValuePair<,>))
            {
                Type[] types_GenericArguments = type_Temp.GetGenericArguments();
                if (types_GenericArguments != null && types_GenericArguments.Length >= 2)
                {
                    Type type_Key = types_GenericArguments[0];
                    Type type_Value = types_GenericArguments[1];
                    switch (jsonNode.GetValueKind())
                    {
                        case System.Text.Json.JsonValueKind.Object:
                            JsonObject? jsonObject = jsonNode.AsObject();
                            if (jsonObject != null && jsonObject.ContainsKey("Key") && jsonObject.ContainsKey("Value"))
                            {
                                object? key = Value(jsonObject["Key"], type_Key);
                                object? value_Temp = Value(jsonObject["Value"], type_Value);
                                return Activator.CreateInstance(type_Temp, key, value_Temp);
                            }
                            break;
                    }
                }
            }

            if (typeof(System.Numerics.Complex).IsAssignableFrom(type_Temp))
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Object:
                        JsonObject? jsonObject = jsonNode.AsObject();
                        if (jsonObject != null && jsonObject.ContainsKey("Real") && jsonObject.ContainsKey("Imaginary"))
                        {
                            if (Value(jsonObject["Real"], typeof(double)) is double real && Value(jsonObject["Imaginary"], typeof(double)) is double imaginary)
                            {
                                return new System.Numerics.Complex(real, imaginary);
                            }
                        }
                        break;
                }
            }

            return null;
        }
    }
}