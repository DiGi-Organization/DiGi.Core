#### [DiGi\.Core](DiGi.Core.Overview.md 'DiGi\.Core\.Overview')

## DiGi\.Core\.Classes Namespace
### Classes

<a name='DiGi.Core.Classes.Address'></a>

## Address Class

Represents a physical mailing address including street, city, postal code, and country code\.

```csharp
public class Address : DiGi.Core.Classes.SerializableObject, DiGi.Core.Interfaces.IAddress, DiGi.Core.Interfaces.ILocation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → Address

Implements [DiGi\.Core\.Interfaces\.IAddress](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iaddress 'DiGi\.Core\.Interfaces\.IAddress'), [ILocation](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ILocation 'DiGi\.Core\.Interfaces\.ILocation'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Classes.Address.Address(DiGi.Core.Classes.Address)'></a>

## Address\(Address\) Constructor

Initializes a new instance of the Address class using another Address object\.

```csharp
public Address(DiGi.Core.Classes.Address? address);
```
#### Parameters

<a name='DiGi.Core.Classes.Address.Address(DiGi.Core.Classes.Address).address'></a>

`address` [Address](DiGi.Core.Classes.md#DiGi.Core.Classes.Address 'DiGi\.Core\.Classes\.Address')

The source address to copy from\.

<a name='DiGi.Core.Classes.Address.Address(string,string,string,DiGi.Core.Enums.CountryCode)'></a>

## Address\(string, string, string, CountryCode\) Constructor

Initializes a new instance of the Address class with specified address details\.

```csharp
public Address(string? street, string? city, string? postalCode, DiGi.Core.Enums.CountryCode countryCode);
```
#### Parameters

<a name='DiGi.Core.Classes.Address.Address(string,string,string,DiGi.Core.Enums.CountryCode).street'></a>

`street` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The street name and number\.

<a name='DiGi.Core.Classes.Address.Address(string,string,string,DiGi.Core.Enums.CountryCode).city'></a>

`city` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The city name\.

<a name='DiGi.Core.Classes.Address.Address(string,string,string,DiGi.Core.Enums.CountryCode).postalCode'></a>

`postalCode` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The postal or zip code\.

<a name='DiGi.Core.Classes.Address.Address(string,string,string,DiGi.Core.Enums.CountryCode).countryCode'></a>

`countryCode` [CountryCode](DiGi.Core.Enums.md#DiGi.Core.Enums.CountryCode 'DiGi\.Core\.Enums\.CountryCode')

The ISO country code\.

<a name='DiGi.Core.Classes.Address.Address(System.Text.Json.Nodes.JsonObject)'></a>

## Address\(JsonObject\) Constructor

Initializes a new instance of the Address class from a JsonObject\.

```csharp
public Address(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.Address.Address(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing address data\.
### Properties

<a name='DiGi.Core.Classes.Address.City'></a>

## Address\.City Property

Gets the city name of the address\.

```csharp
public string? City { get; }
```

Implements [City](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iaddress.city 'DiGi\.Core\.Interfaces\.IAddress\.City')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.Address.CountryCode'></a>

## Address\.CountryCode Property

Gets the ISO country code of the address\.

```csharp
public DiGi.Core.Enums.CountryCode CountryCode { get; }
```

Implements [CountryCode](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iaddress.countrycode 'DiGi\.Core\.Interfaces\.IAddress\.CountryCode')

#### Property Value
[CountryCode](DiGi.Core.Enums.md#DiGi.Core.Enums.CountryCode 'DiGi\.Core\.Enums\.CountryCode')

<a name='DiGi.Core.Classes.Address.PostalCode'></a>

## Address\.PostalCode Property

Gets the postal or zip code of the address\.

```csharp
public string? PostalCode { get; }
```

Implements [PostalCode](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iaddress.postalcode 'DiGi\.Core\.Interfaces\.IAddress\.PostalCode')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.Address.Street'></a>

## Address\.Street Property

Gets the street name and number of the address\.

```csharp
public string? Street { get; }
```

Implements [Street](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iaddress.street 'DiGi\.Core\.Interfaces\.IAddress\.Street')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.AnyOf'></a>

## AnyOf Class

A type\-safe container that allows a variable to hold one of several specified types\.

```csharp
public class AnyOf
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → AnyOf

Derived  
↳ [AnyOf&lt;T,K&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_ 'DiGi\.Core\.Classes\.AnyOf\<T,K\>')  
↳ [AnyOf&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T_ 'DiGi\.Core\.Classes\.AnyOf\<T\>')
### Constructors

<a name='DiGi.Core.Classes.AnyOf.AnyOf(object,System.Type)'></a>

## AnyOf\(object, Type\) Constructor

Initializes a new instance of the AnyOf class with a value and an optional type\.

```csharp
public AnyOf(object? value, System.Type? type=null);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf.AnyOf(object,System.Type).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to store\.

<a name='DiGi.Core.Classes.AnyOf.AnyOf(object,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The expected type of the value\.
### Properties

<a name='DiGi.Core.Classes.AnyOf.Types'></a>

## AnyOf\.Types Property

Gets the list of allowed types for this container\.

```csharp
public virtual System.Type[] Types { get; }
```

#### Property Value
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Core.Classes.AnyOf.Value'></a>

## AnyOf\.Value Property

Gets or sets the underlying value stored in the container\.

```csharp
public object? Value { get; set; }
```

#### Property Value
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')
### Methods

<a name='DiGi.Core.Classes.AnyOf.Equals(object)'></a>

## AnyOf\.Equals\(object\) Method

Determines whether the specified object is equal to the current AnyOf instance\.

```csharp
public override bool Equals(object? @object);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf.Equals(object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the objects are equal; otherwise, false\.

<a name='DiGi.Core.Classes.AnyOf.GetHashCode()'></a>

## AnyOf\.GetHashCode\(\) Method

Returns the hash code for the contained value\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The hash code of the stored value\.

<a name='DiGi.Core.Classes.AnyOf.GetType()'></a>

## AnyOf\.GetType\(\) Method

Retrieves the actual type of the stored value, or the first allowed type if null\.

```csharp
public System.Type? GetType();
```

#### Returns
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')  
The Type of the stored value\.

<a name='DiGi.Core.Classes.AnyOf.GetValue_T_()'></a>

## AnyOf\.GetValue\<T\>\(\) Method

Attempts to retrieve the stored value cast to the specified type T\.

```csharp
public T? GetValue<T>();
```
#### Type parameters

<a name='DiGi.Core.Classes.AnyOf.GetValue_T_().T'></a>

`T`

The target type\.

#### Returns
[T](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf.GetValue_T_().T 'DiGi\.Core\.Classes\.AnyOf\.GetValue\<T\>\(\)\.T')  
The value cast to T, or default if not possible\.

<a name='DiGi.Core.Classes.AnyOf.IsValid(object)'></a>

## AnyOf\.IsValid\(object\) Method

Checks if a given value is compatible with the allowed types of this container\.

```csharp
public bool IsValid(object? value);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf.IsValid(object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to validate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if valid; otherwise, false\.

<a name='DiGi.Core.Classes.AnyOf.ToString()'></a>

## AnyOf\.ToString\(\) Method

Returns a string representation of the contained value\.

```csharp
public override string? ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The string representation\.
### Operators

<a name='DiGi.Core.Classes.AnyOf.op_Equality(DiGi.Core.Classes.AnyOf,object)'></a>

## AnyOf\.operator ==\(AnyOf, object\) Operator

Compares an [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance with a specified object for equality\.

```csharp
public static bool operator ==(DiGi.Core.Classes.AnyOf? anyOf, object? @object);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf.op_Equality(DiGi.Core.Classes.AnyOf,object).anyOf'></a>

`anyOf` [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf')

The [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance to compare\.

<a name='DiGi.Core.Classes.AnyOf.op_Equality(DiGi.Core.Classes.AnyOf,object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare against the [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the objects are equal; otherwise, false\.

<a name='DiGi.Core.Classes.AnyOf.op_ImplicitDiGi.Core.Classes.AnyOf(bool)'></a>

## AnyOf\.implicit operator AnyOf\(bool\) Operator

Implicitly converts a boolean value to an [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance\.

```csharp
public static DiGi.Core.Classes.AnyOf implicit operator DiGi.Core.Classes.AnyOf(bool value);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf.op_ImplicitDiGi.Core.Classes.AnyOf(bool).value'></a>

`value` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

The boolean value to convert\.

#### Returns
[AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf')  
An [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance representing the provided boolean value\.

<a name='DiGi.Core.Classes.AnyOf.op_ImplicitDiGi.Core.Classes.AnyOf(double)'></a>

## AnyOf\.implicit operator AnyOf\(double\) Operator

Implicitly converts a double value to an [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance\.

```csharp
public static DiGi.Core.Classes.AnyOf implicit operator DiGi.Core.Classes.AnyOf(double value);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf.op_ImplicitDiGi.Core.Classes.AnyOf(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value to convert\.

#### Returns
[AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf')  
An [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance representing the provided double value\.

<a name='DiGi.Core.Classes.AnyOf.op_ImplicitDiGi.Core.Classes.AnyOf(int)'></a>

## AnyOf\.implicit operator AnyOf\(int\) Operator

Implicitly converts an integer value to an [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance\.

```csharp
public static DiGi.Core.Classes.AnyOf implicit operator DiGi.Core.Classes.AnyOf(int value);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf.op_ImplicitDiGi.Core.Classes.AnyOf(int).value'></a>

`value` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer value to convert\.

#### Returns
[AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf')  
An [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance representing the provided integer value\.

<a name='DiGi.Core.Classes.AnyOf.op_ImplicitDiGi.Core.Classes.AnyOf(long)'></a>

## AnyOf\.implicit operator AnyOf\(long\) Operator

Implicitly converts a long value to an [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance\.

```csharp
public static DiGi.Core.Classes.AnyOf implicit operator DiGi.Core.Classes.AnyOf(long value);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf.op_ImplicitDiGi.Core.Classes.AnyOf(long).value'></a>

`value` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The long value to convert\.

#### Returns
[AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf')  
An [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance representing the provided long value\.

<a name='DiGi.Core.Classes.AnyOf.op_ImplicitDiGi.Core.Classes.AnyOf(string)'></a>

## AnyOf\.implicit operator AnyOf\(string\) Operator

Implicitly converts a string value to an [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance\.

```csharp
public static DiGi.Core.Classes.AnyOf implicit operator DiGi.Core.Classes.AnyOf(string value);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf.op_ImplicitDiGi.Core.Classes.AnyOf(string).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string value to convert\.

#### Returns
[AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf')  
An [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance representing the provided string value\.

<a name='DiGi.Core.Classes.AnyOf.op_ImplicitDiGi.Core.Classes.AnyOf(System.DateTime)'></a>

## AnyOf\.implicit operator AnyOf\(DateTime\) Operator

Implicitly converts a [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') value to an [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance\.

```csharp
public static DiGi.Core.Classes.AnyOf implicit operator DiGi.Core.Classes.AnyOf(System.DateTime value);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf.op_ImplicitDiGi.Core.Classes.AnyOf(System.DateTime).value'></a>

`value` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') value to convert\.

#### Returns
[AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf')  
An [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance representing the provided [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') value\.

<a name='DiGi.Core.Classes.AnyOf.op_ImplicitDiGi.Core.Classes.AnyOf(System.DateTimeOffset)'></a>

## AnyOf\.implicit operator AnyOf\(DateTimeOffset\) Operator

Implicitly converts a [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') value to an [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance\.

```csharp
public static DiGi.Core.Classes.AnyOf implicit operator DiGi.Core.Classes.AnyOf(System.DateTimeOffset value);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf.op_ImplicitDiGi.Core.Classes.AnyOf(System.DateTimeOffset).value'></a>

`value` [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')

The [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') value to convert\.

#### Returns
[AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf')  
An [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance representing the provided [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') value\.

<a name='DiGi.Core.Classes.AnyOf.op_ImplicitDiGi.Core.Classes.AnyOf(System.Guid)'></a>

## AnyOf\.implicit operator AnyOf\(Guid\) Operator

Implicitly converts a [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid') value to an [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance\.

```csharp
public static DiGi.Core.Classes.AnyOf implicit operator DiGi.Core.Classes.AnyOf(System.Guid value);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf.op_ImplicitDiGi.Core.Classes.AnyOf(System.Guid).value'></a>

`value` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid') value to convert\.

#### Returns
[AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf')  
An [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance representing the provided [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid') value\.

<a name='DiGi.Core.Classes.AnyOf.op_Implicitstring(DiGi.Core.Classes.AnyOf)'></a>

## AnyOf\.implicit operator string\(AnyOf\) Operator

Implicitly converts an [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance to a nullable string representation\.

```csharp
public static string? implicit operator string?(DiGi.Core.Classes.AnyOf value);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf.op_Implicitstring(DiGi.Core.Classes.AnyOf).value'></a>

`value` [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf')

The [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance to convert\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The string representation of the value, or null if the instance is null\.

<a name='DiGi.Core.Classes.AnyOf.op_Inequality(DiGi.Core.Classes.AnyOf,object)'></a>

## AnyOf\.operator \!=\(AnyOf, object\) Operator

Determines whether the specified [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance is not equal to the specified object\.

```csharp
public static bool operator !=(DiGi.Core.Classes.AnyOf? anyOf, object? @object);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf.op_Inequality(DiGi.Core.Classes.AnyOf,object).anyOf'></a>

`anyOf` [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf')

The [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance to compare\.

<a name='DiGi.Core.Classes.AnyOf.op_Inequality(DiGi.Core.Classes.AnyOf,object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare against the [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the objects are not equal; otherwise, false\.

<a name='DiGi.Core.Classes.AnyOf_T,K_'></a>

## AnyOf\<T,K\> Class

A type\-safe container for one of two specified types T or K\.

```csharp
public class AnyOf<T,K> : DiGi.Core.Classes.AnyOf
```
#### Type parameters

<a name='DiGi.Core.Classes.AnyOf_T,K_.T'></a>

`T`

The first type\.

<a name='DiGi.Core.Classes.AnyOf_T,K_.K'></a>

`K`

The second type\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') → AnyOf\<T,K\>
### Constructors

<a name='DiGi.Core.Classes.AnyOf_T,K_.AnyOf(K)'></a>

## AnyOf\(K\) Constructor

Initializes a new instance of AnyOf with a value of type K\.

```csharp
public AnyOf(K value);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf_T,K_.AnyOf(K).value'></a>

`value` [K](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_.K 'DiGi\.Core\.Classes\.AnyOf\<T,K\>\.K')

The value to store\.

<a name='DiGi.Core.Classes.AnyOf_T,K_.AnyOf(T)'></a>

## AnyOf\(T\) Constructor

Initializes a new instance of AnyOf with a value of type T\.

```csharp
public AnyOf(T value);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf_T,K_.AnyOf(T).value'></a>

`value` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_.T 'DiGi\.Core\.Classes\.AnyOf\<T,K\>\.T')

The value to store\.
### Properties

<a name='DiGi.Core.Classes.AnyOf_T,K_.Types'></a>

## AnyOf\<T,K\>\.Types Property

Gets the two allowed types T and K for this container\.

```csharp
public override System.Type[] Types { get; }
```

#### Property Value
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Operators

<a name='DiGi.Core.Classes.AnyOf_T,K_.op_ImplicitDiGi.Core.Classes.AnyOf_T,K_(K)'></a>

## AnyOf\<T,K\>\.implicit operator AnyOf\<T,K\>\(K\) Operator

Implicitly converts a value of type K to an AnyOf container holding either T or K\.

```csharp
public static DiGi.Core.Classes.AnyOf<T,K> implicit operator DiGi.Core.Classes.AnyOf<T,K>(K value);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf_T,K_.op_ImplicitDiGi.Core.Classes.AnyOf_T,K_(K).value'></a>

`value` [K](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_.K 'DiGi\.Core\.Classes\.AnyOf\<T,K\>\.K')

The value of type K to convert\.

#### Returns
[DiGi\.Core\.Classes\.AnyOf&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_ 'DiGi\.Core\.Classes\.AnyOf\<T,K\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_.T 'DiGi\.Core\.Classes\.AnyOf\<T,K\>\.T')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_ 'DiGi\.Core\.Classes\.AnyOf\<T,K\>')[K](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_.K 'DiGi\.Core\.Classes\.AnyOf\<T,K\>\.K')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_ 'DiGi\.Core\.Classes\.AnyOf\<T,K\>')  
An AnyOf container holding the provided value of type K\.

<a name='DiGi.Core.Classes.AnyOf_T,K_.op_ImplicitDiGi.Core.Classes.AnyOf_T,K_(T)'></a>

## AnyOf\<T,K\>\.implicit operator AnyOf\<T,K\>\(T\) Operator

Implicitly converts a value of type T to an AnyOf container holding either T or K\.

```csharp
public static DiGi.Core.Classes.AnyOf<T,K> implicit operator DiGi.Core.Classes.AnyOf<T,K>(T value);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf_T,K_.op_ImplicitDiGi.Core.Classes.AnyOf_T,K_(T).value'></a>

`value` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_.T 'DiGi\.Core\.Classes\.AnyOf\<T,K\>\.T')

The value of type T to be wrapped in an AnyOf container\.

#### Returns
[DiGi\.Core\.Classes\.AnyOf&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_ 'DiGi\.Core\.Classes\.AnyOf\<T,K\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_.T 'DiGi\.Core\.Classes\.AnyOf\<T,K\>\.T')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_ 'DiGi\.Core\.Classes\.AnyOf\<T,K\>')[K](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_.K 'DiGi\.Core\.Classes\.AnyOf\<T,K\>\.K')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_ 'DiGi\.Core\.Classes\.AnyOf\<T,K\>')  
An AnyOf container holding the provided value of type T\.

<a name='DiGi.Core.Classes.AnyOf_T,K_.op_ImplicitK(DiGi.Core.Classes.AnyOf_T,K_)'></a>

## AnyOf\<T,K\>\.implicit operator K\(AnyOf\<T,K\>\) Operator

Implicitly converts the AnyOf container to its contained value of type K\.

```csharp
public static K? implicit operator K?(DiGi.Core.Classes.AnyOf<T,K> anyOf);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf_T,K_.op_ImplicitK(DiGi.Core.Classes.AnyOf_T,K_).anyOf'></a>

`anyOf` [DiGi\.Core\.Classes\.AnyOf&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_ 'DiGi\.Core\.Classes\.AnyOf\<T,K\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_.T 'DiGi\.Core\.Classes\.AnyOf\<T,K\>\.T')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_ 'DiGi\.Core\.Classes\.AnyOf\<T,K\>')[K](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_.K 'DiGi\.Core\.Classes\.AnyOf\<T,K\>\.K')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_ 'DiGi\.Core\.Classes\.AnyOf\<T,K\>')

The AnyOf instance to convert\.

#### Returns
[K](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_.K 'DiGi\.Core\.Classes\.AnyOf\<T,K\>\.K')  
The contained value of type K, or the default value if the container is null\.

<a name='DiGi.Core.Classes.AnyOf_T,K_.op_ImplicitT(DiGi.Core.Classes.AnyOf_T,K_)'></a>

## AnyOf\<T,K\>\.implicit operator T\(AnyOf\<T,K\>\) Operator

Implicitly converts the AnyOf container to its contained value of type T\.

```csharp
public static T? implicit operator T?(DiGi.Core.Classes.AnyOf<T,K> anyOf);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf_T,K_.op_ImplicitT(DiGi.Core.Classes.AnyOf_T,K_).anyOf'></a>

`anyOf` [DiGi\.Core\.Classes\.AnyOf&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_ 'DiGi\.Core\.Classes\.AnyOf\<T,K\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_.T 'DiGi\.Core\.Classes\.AnyOf\<T,K\>\.T')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_ 'DiGi\.Core\.Classes\.AnyOf\<T,K\>')[K](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_.K 'DiGi\.Core\.Classes\.AnyOf\<T,K\>\.K')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_ 'DiGi\.Core\.Classes\.AnyOf\<T,K\>')

The AnyOf instance to convert\.

#### Returns
[T](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T,K_.T 'DiGi\.Core\.Classes\.AnyOf\<T,K\>\.T')  
The contained value of type T, or the default value if the container is null\.

<a name='DiGi.Core.Classes.AnyOf_T_'></a>

## AnyOf\<T\> Class

A type\-safe container for a single specified type T\.

```csharp
public class AnyOf<T> : DiGi.Core.Classes.AnyOf
```
#### Type parameters

<a name='DiGi.Core.Classes.AnyOf_T_.T'></a>

`T`

The specified type\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [AnyOf](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf 'DiGi\.Core\.Classes\.AnyOf') → AnyOf\<T\>
### Constructors

<a name='DiGi.Core.Classes.AnyOf_T_.AnyOf(T)'></a>

## AnyOf\(T\) Constructor

A type\-safe container for a single specified type T\.

```csharp
public AnyOf(T value);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf_T_.AnyOf(T).value'></a>

`value` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T_.T 'DiGi\.Core\.Classes\.AnyOf\<T\>\.T')
### Properties

<a name='DiGi.Core.Classes.AnyOf_T_.Types'></a>

## AnyOf\<T\>\.Types Property

Gets the single allowed type T for this container\.

```csharp
public override System.Type[] Types { get; }
```

#### Property Value
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Operators

<a name='DiGi.Core.Classes.AnyOf_T_.op_ImplicitT(DiGi.Core.Classes.AnyOf_T_)'></a>

## AnyOf\<T\>\.implicit operator T\(AnyOf\<T\>\) Operator

Implicitly converts an [AnyOf&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T_ 'DiGi\.Core\.Classes\.AnyOf\<T\>') container to its contained value of type [T](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T_.T 'DiGi\.Core\.Classes\.AnyOf\<T\>\.T')\.

```csharp
public static T? implicit operator T?(DiGi.Core.Classes.AnyOf<T> anyOf);
```
#### Parameters

<a name='DiGi.Core.Classes.AnyOf_T_.op_ImplicitT(DiGi.Core.Classes.AnyOf_T_).anyOf'></a>

`anyOf` [DiGi\.Core\.Classes\.AnyOf&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T_ 'DiGi\.Core\.Classes\.AnyOf\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T_.T 'DiGi\.Core\.Classes\.AnyOf\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T_ 'DiGi\.Core\.Classes\.AnyOf\<T\>')

The [AnyOf&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T_ 'DiGi\.Core\.Classes\.AnyOf\<T\>') instance to convert\.

#### Returns
[T](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T_.T 'DiGi\.Core\.Classes\.AnyOf\<T\>\.T')  
The contained value of type [T](DiGi.Core.Classes.md#DiGi.Core.Classes.AnyOf_T_.T 'DiGi\.Core\.Classes\.AnyOf\<T\>\.T'), or the default value if the instance is null\.

<a name='DiGi.Core.Classes.BackgroundTask'></a>

## BackgroundTask Class

Provides a base class for background tasks with status tracking and event notifications\.

```csharp
public abstract class BackgroundTask : DiGi.Core.Interfaces.IBackgroundTask, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → BackgroundTask

Derived  
↳ [CancelableBackgroundTask](DiGi.Core.Classes.md#DiGi.Core.Classes.CancelableBackgroundTask 'DiGi\.Core\.Classes\.CancelableBackgroundTask')

Implements [IBackgroundTask](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IBackgroundTask 'DiGi\.Core\.Interfaces\.IBackgroundTask'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Fields

<a name='DiGi.Core.Classes.BackgroundTask.exception'></a>

## BackgroundTask\.exception Field

Stores any exception that occurred during task execution\.

```csharp
protected Exception? exception;
```

#### Field Value
[System\.Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception 'System\.Exception')

<a name='DiGi.Core.Classes.BackgroundTask.isRunning'></a>

## BackgroundTask\.isRunning Field

Indicates whether the task is currently running\.

```csharp
private bool isRunning;
```

#### Field Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Classes.BackgroundTask.isSucceeded'></a>

## BackgroundTask\.isSucceeded Field

Indicates whether the last task execution succeeded\.

```csharp
private bool isSucceeded;
```

#### Field Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Classes.BackgroundTask.lockObject'></a>

## BackgroundTask\.lockObject Field

Object used for thread synchronization\.

```csharp
protected readonly object lockObject;
```

#### Field Value
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

<a name='DiGi.Core.Classes.BackgroundTask.stopwatch'></a>

## BackgroundTask\.stopwatch Field

Measures the execution time of the task\.

```csharp
private readonly Stopwatch stopwatch;
```

#### Field Value
[System\.Diagnostics\.Stopwatch](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch 'System\.Diagnostics\.Stopwatch')
### Properties

<a name='DiGi.Core.Classes.BackgroundTask.BackgroundTaskStatus'></a>

## BackgroundTask\.BackgroundTaskStatus Property

Gets the current status of the background task\.

```csharp
public DiGi.Core.Enums.BackgroundTaskStatus BackgroundTaskStatus { get; }
```

Implements [BackgroundTaskStatus](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IBackgroundTask.BackgroundTaskStatus 'DiGi\.Core\.Interfaces\.IBackgroundTask\.BackgroundTaskStatus')

#### Property Value
[BackgroundTaskStatus](DiGi.Core.Enums.md#DiGi.Core.Enums.BackgroundTaskStatus 'DiGi\.Core\.Enums\.BackgroundTaskStatus')

<a name='DiGi.Core.Classes.BackgroundTask.Exception'></a>

## BackgroundTask\.Exception Property

Gets the exception that caused the task to fail, or null if the task succeeded\.

```csharp
public System.Exception? Exception { get; }
```

Implements [Exception](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IBackgroundTask.Exception 'DiGi\.Core\.Interfaces\.IBackgroundTask\.Exception')

#### Property Value
[System\.Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception 'System\.Exception')

<a name='DiGi.Core.Classes.BackgroundTask.ExecutionTimeSpan'></a>

## BackgroundTask\.ExecutionTimeSpan Property

Gets the total execution time of the last run\.

```csharp
public System.TimeSpan ExecutionTimeSpan { get; }
```

Implements [ExecutionTimeSpan](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IBackgroundTask.ExecutionTimeSpan 'DiGi\.Core\.Interfaces\.IBackgroundTask\.ExecutionTimeSpan')

#### Property Value
[System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan')

<a name='DiGi.Core.Classes.BackgroundTask.IsCompleted'></a>

## BackgroundTask\.IsCompleted Property

Gets a value indicating whether the task has completed\.

```csharp
public bool IsCompleted { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Classes.BackgroundTask.IsRunning'></a>

## BackgroundTask\.IsRunning Property

Gets a value indicating whether the task is currently running\.

```csharp
public bool IsRunning { get; }
```

Implements [IsRunning](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IBackgroundTask.IsRunning 'DiGi\.Core\.Interfaces\.IBackgroundTask\.IsRunning')

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Classes.BackgroundTask.IsSucceeded'></a>

## BackgroundTask\.IsSucceeded Property

Gets a value indicating whether the last task execution succeeded\.

```csharp
public bool IsSucceeded { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Classes.BackgroundTask.Task'></a>

## BackgroundTask\.Task Property

Gets or sets the underlying task associated with this background task\.

```csharp
protected System.Threading.Tasks.Task? Task { protected get; protected set; }
```

#### Property Value
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')

<a name='DiGi.Core.Classes.BackgroundTask.WasCanceled'></a>

## BackgroundTask\.WasCanceled Property

Gets a value indicating whether the task was cancelled before it reported failure\.

The base implementation is always false. A cancelable task overrides it, so that a run stopped
            by its operator - which reports failure only because its cancellation was requested - is not wrapped
            as a [BackgroundTaskFailureException](DiGi.Core.Classes.md#DiGi.Core.Classes.BackgroundTaskFailureException 'DiGi\.Core\.Classes\.BackgroundTaskFailureException').

```csharp
protected virtual bool WasCanceled { protected get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')
### Methods

<a name='DiGi.Core.Classes.BackgroundTask.ExecuteAsync()'></a>

## BackgroundTask\.ExecuteAsync\(\) Method

When overridden in a derived class, defines the work to be executed by the background task\.

```csharp
protected abstract System.Threading.Tasks.Task<bool> ExecuteAsync();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
True if the task succeeded; otherwise, false\.

<a name='DiGi.Core.Classes.BackgroundTask.OnStarted()'></a>

## BackgroundTask\.OnStarted\(\) Method

Raises the Started event\.

```csharp
protected virtual void OnStarted();
```

<a name='DiGi.Core.Classes.BackgroundTask.OnStarting()'></a>

## BackgroundTask\.OnStarting\(\) Method

Raises the Starting event\.

```csharp
protected virtual void OnStarting();
```

<a name='DiGi.Core.Classes.BackgroundTask.OnStopped()'></a>

## BackgroundTask\.OnStopped\(\) Method

Raises the Stopped event\.

```csharp
protected virtual void OnStopped();
```

<a name='DiGi.Core.Classes.BackgroundTask.OnStopping()'></a>

## BackgroundTask\.OnStopping\(\) Method

Raises the Stopping event\.

```csharp
protected virtual void OnStopping();
```

<a name='DiGi.Core.Classes.BackgroundTask.Start()'></a>

## BackgroundTask\.Start\(\) Method

Starts the background task execution\.

```csharp
public virtual void Start();
```

Implements [Start\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IBackgroundTask.Start() 'DiGi\.Core\.Interfaces\.IBackgroundTask\.Start\(\)')
### Events

<a name='DiGi.Core.Classes.BackgroundTask.Started'></a>

## BackgroundTask\.Started Event

Occurs when the task has started execution\.

```csharp
public event EventHandler? Started;
```

Implements [Started](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IBackgroundTask.Started 'DiGi\.Core\.Interfaces\.IBackgroundTask\.Started')

#### Event Type
[System\.EventHandler](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler 'System\.EventHandler')

<a name='DiGi.Core.Classes.BackgroundTask.Starting'></a>

## BackgroundTask\.Starting Event

Occurs when the task is about to start execution\.

```csharp
public event EventHandler? Starting;
```

Implements [Starting](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IBackgroundTask.Starting 'DiGi\.Core\.Interfaces\.IBackgroundTask\.Starting')

#### Event Type
[System\.EventHandler](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler 'System\.EventHandler')

<a name='DiGi.Core.Classes.BackgroundTask.Stopped'></a>

## BackgroundTask\.Stopped Event

Occurs when the task has stopped execution\.

```csharp
public event EventHandler? Stopped;
```

Implements [Stopped](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IBackgroundTask.Stopped 'DiGi\.Core\.Interfaces\.IBackgroundTask\.Stopped')

#### Event Type
[System\.EventHandler](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler 'System\.EventHandler')

<a name='DiGi.Core.Classes.BackgroundTask.Stopping'></a>

## BackgroundTask\.Stopping Event

Occurs when the task is about to stop execution\.

```csharp
public event EventHandler? Stopping;
```

Implements [Stopping](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IBackgroundTask.Stopping 'DiGi\.Core\.Interfaces\.IBackgroundTask\.Stopping')

#### Event Type
[System\.EventHandler](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler 'System\.EventHandler')

<a name='DiGi.Core.Classes.BackgroundTaskFailureException'></a>

## BackgroundTaskFailureException Class

Represents the deliberate failure of a background task: a refusal the task decided on itself, such as a
duplicate email or a cancelled dialog, rather than an unexpected exception thrown while it was running\.

It exists so a consumer of [Exception](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IBackgroundTask.Exception 'DiGi\.Core\.Interfaces\.IBackgroundTask\.Exception') can tell a designed
            refusal from a crash by type: the message alone would leave a reader guessing whether the run broke or
            declined. A task throwing it is refusing; anything else in `Exception` is a fault.

[BackgroundTask](DiGi.Core.Classes.md#DiGi.Core.Classes.BackgroundTask 'DiGi\.Core\.Classes\.BackgroundTask') also assigns it as a fallback when a task reports failure by returning
            false without an exception and without being cancelled, so such a run still carries a message the task
            row can show on hover and the clipboard can copy.

```csharp
public class BackgroundTaskFailureException : System.Exception
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception 'System\.Exception') → BackgroundTaskFailureException
### Constructors

<a name='DiGi.Core.Classes.BackgroundTaskFailureException.BackgroundTaskFailureException(string)'></a>

## BackgroundTaskFailureException\(string\) Constructor

Initializes a new instance of the [BackgroundTaskFailureException](DiGi.Core.Classes.md#DiGi.Core.Classes.BackgroundTaskFailureException 'DiGi\.Core\.Classes\.BackgroundTaskFailureException') class with a specified error message\.

```csharp
public BackgroundTaskFailureException(string? message);
```
#### Parameters

<a name='DiGi.Core.Classes.BackgroundTaskFailureException.BackgroundTaskFailureException(string).message'></a>

`message` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The message that describes why the task refused to do what it was asked for\.

<a name='DiGi.Core.Classes.CancelableBackgroundTask'></a>

## CancelableBackgroundTask Class

Provides a base class for background tasks that can be canceled during execution\.

```csharp
public abstract class CancelableBackgroundTask : DiGi.Core.Classes.BackgroundTask, DiGi.Core.Interfaces.ICancelableBackgroundTask, DiGi.Core.Interfaces.IBackgroundTask, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [BackgroundTask](DiGi.Core.Classes.md#DiGi.Core.Classes.BackgroundTask 'DiGi\.Core\.Classes\.BackgroundTask') → CancelableBackgroundTask

Derived  
↳ [ReportableBackgroundTask&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ReportableBackgroundTask_T_ 'DiGi\.Core\.Classes\.ReportableBackgroundTask\<T\>')

Implements [ICancelableBackgroundTask](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICancelableBackgroundTask 'DiGi\.Core\.Interfaces\.ICancelableBackgroundTask'), [IBackgroundTask](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IBackgroundTask 'DiGi\.Core\.Interfaces\.IBackgroundTask'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Fields

<a name='DiGi.Core.Classes.CancelableBackgroundTask.cancellationTokenSource'></a>

## CancelableBackgroundTask\.cancellationTokenSource Field

Source for controlling cancellation of the background task\.

```csharp
private CancellationTokenSource? cancellationTokenSource;
```

#### Field Value
[System\.Threading\.CancellationTokenSource](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtokensource 'System\.Threading\.CancellationTokenSource')

<a name='DiGi.Core.Classes.CancelableBackgroundTask.isCanceled'></a>

## CancelableBackgroundTask\.isCanceled Field

Indicates whether the last run was cancelled through this task's own source\.

```csharp
private bool isCanceled;
```

#### Field Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')
### Properties

<a name='DiGi.Core.Classes.CancelableBackgroundTask.CancelableBackgroundTaskStatus'></a>

## CancelableBackgroundTask\.CancelableBackgroundTaskStatus Property

Gets the current status of the cancelable background task\.

A run stopped by [Stop\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.CancelableBackgroundTask.Stop() 'DiGi\.Core\.Classes\.CancelableBackgroundTask\.Stop\(\)') or [StopAsync\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.CancelableBackgroundTask.StopAsync() 'DiGi\.Core\.Classes\.CancelableBackgroundTask\.StopAsync\(\)') reports
            [Canceled](DiGi.Core.Enums.md#DiGi.Core.Enums.CancelableBackgroundTaskStatus.Canceled 'DiGi\.Core\.Enums\.CancelableBackgroundTaskStatus\.Canceled') until the next [Start\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.CancelableBackgroundTask.Start() 'DiGi\.Core\.Classes\.CancelableBackgroundTask\.Start\(\)').

```csharp
public DiGi.Core.Enums.CancelableBackgroundTaskStatus CancelableBackgroundTaskStatus { get; }
```

Implements [CancelableBackgroundTaskStatus](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICancelableBackgroundTask.CancelableBackgroundTaskStatus 'DiGi\.Core\.Interfaces\.ICancelableBackgroundTask\.CancelableBackgroundTaskStatus')

#### Property Value
[CancelableBackgroundTaskStatus](DiGi.Core.Enums.md#DiGi.Core.Enums.CancelableBackgroundTaskStatus 'DiGi\.Core\.Enums\.CancelableBackgroundTaskStatus')

<a name='DiGi.Core.Classes.CancelableBackgroundTask.IsCanceled'></a>

## CancelableBackgroundTask\.IsCanceled Property

Gets a value indicating whether the last run ended because [Stop\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.CancelableBackgroundTask.Stop() 'DiGi\.Core\.Classes\.CancelableBackgroundTask\.Stop\(\)') or [StopAsync\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.CancelableBackgroundTask.StopAsync() 'DiGi\.Core\.Classes\.CancelableBackgroundTask\.StopAsync\(\)')
requested its cancellation\.

A fault is not a cancellation: an [System\.OperationCanceledException](https://learn.microsoft.com/en-us/dotnet/api/system.operationcanceledexception 'System\.OperationCanceledException') this task's source did not
            request, such as a request timeout, leaves it false. Reset by [Start\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.CancelableBackgroundTask.Start() 'DiGi\.Core\.Classes\.CancelableBackgroundTask\.Start\(\)').

```csharp
public bool IsCanceled { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Classes.CancelableBackgroundTask.WasCanceled'></a>

## CancelableBackgroundTask\.WasCanceled Property

Gets a value indicating whether the task was cancelled before it reported failure\.

Read while the run is still finishing - [Stop\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.CancelableBackgroundTask.Stop() 'DiGi\.Core\.Classes\.CancelableBackgroundTask\.Stop\(\)') and [StopAsync\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.CancelableBackgroundTask.StopAsync() 'DiGi\.Core\.Classes\.CancelableBackgroundTask\.StopAsync\(\)') await the
            run before they clean the source up - so a run stopped by its operator is recognized as cancelled and
            is not wrapped as a [BackgroundTaskFailureException](DiGi.Core.Classes.md#DiGi.Core.Classes.BackgroundTaskFailureException 'DiGi\.Core\.Classes\.BackgroundTaskFailureException') for having returned false.

Only a cancellation requested through this task's own source counts: an
            [System\.OperationCanceledException](https://learn.microsoft.com/en-us/dotnet/api/system.operationcanceledexception 'System\.OperationCanceledException') raised inside the run for another reason, such as a request
            timeout, is a failure and is kept in [Exception](DiGi.Core.Classes.md#DiGi.Core.Classes.BackgroundTask.Exception 'DiGi\.Core\.Classes\.BackgroundTask\.Exception').

```csharp
protected override bool WasCanceled { protected get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')
### Methods

<a name='DiGi.Core.Classes.CancelableBackgroundTask.Cleanup()'></a>

## CancelableBackgroundTask\.Cleanup\(\) Method

Disposes the cancellation token source\.

The completed task is kept, so the status reports the outcome of the last run until the next
            [Start\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.CancelableBackgroundTask.Start() 'DiGi\.Core\.Classes\.CancelableBackgroundTask\.Start\(\)').

```csharp
private void Cleanup();
```

<a name='DiGi.Core.Classes.CancelableBackgroundTask.ExecuteAsync()'></a>

## CancelableBackgroundTask\.ExecuteAsync\(\) Method

Executes the background task with cancellation support\.

An [System\.OperationCanceledException](https://learn.microsoft.com/en-us/dotnet/api/system.operationcanceledexception 'System\.OperationCanceledException') is treated as a cancellation only when this task's
            source requested it ([Stop\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.CancelableBackgroundTask.Stop() 'DiGi\.Core\.Classes\.CancelableBackgroundTask\.Stop\(\)') or [StopAsync\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.CancelableBackgroundTask.StopAsync() 'DiGi\.Core\.Classes\.CancelableBackgroundTask\.StopAsync\(\)')). Any other one - a request timeout,
            a callee's own linked source - is stored in [Exception](DiGi.Core.Classes.md#DiGi.Core.Classes.BackgroundTask.Exception 'DiGi\.Core\.Classes\.BackgroundTask\.Exception') like any fault, so
            the real cause reaches the task row instead of the generic [BackgroundTaskFailureException](DiGi.Core.Classes.md#DiGi.Core.Classes.BackgroundTaskFailureException 'DiGi\.Core\.Classes\.BackgroundTaskFailureException').

```csharp
protected override System.Threading.Tasks.Task<bool> ExecuteAsync();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
True if the task succeeded; otherwise, false\.

<a name='DiGi.Core.Classes.CancelableBackgroundTask.ExecuteAsync(System.Threading.CancellationToken)'></a>

## CancelableBackgroundTask\.ExecuteAsync\(CancellationToken\) Method

When overridden in a derived class, defines the work to be executed with a cancellation token\.

```csharp
protected abstract System.Threading.Tasks.Task<bool> ExecuteAsync(System.Threading.CancellationToken token);
```
#### Parameters

<a name='DiGi.Core.Classes.CancelableBackgroundTask.ExecuteAsync(System.Threading.CancellationToken).token'></a>

`token` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
True if the task succeeded; otherwise, false\.

<a name='DiGi.Core.Classes.CancelableBackgroundTask.MarkCanceled()'></a>

## CancelableBackgroundTask\.MarkCanceled\(\) Method

Records that the current run was cancelled through this task's own source\.

```csharp
private void MarkCanceled();
```

<a name='DiGi.Core.Classes.CancelableBackgroundTask.OnCanceled()'></a>

## CancelableBackgroundTask\.OnCanceled\(\) Method

Raises the Canceled event\.

```csharp
protected virtual void OnCanceled();
```

<a name='DiGi.Core.Classes.CancelableBackgroundTask.OnCancelling()'></a>

## CancelableBackgroundTask\.OnCancelling\(\) Method

Raises the Cancelling event\.

```csharp
protected virtual void OnCancelling();
```

<a name='DiGi.Core.Classes.CancelableBackgroundTask.Start()'></a>

## CancelableBackgroundTask\.Start\(\) Method

Starts the background task execution synchronously\.

```csharp
public override void Start();
```

Implements [Start\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IBackgroundTask.Start() 'DiGi\.Core\.Interfaces\.IBackgroundTask\.Start\(\)')

<a name='DiGi.Core.Classes.CancelableBackgroundTask.Stop()'></a>

## CancelableBackgroundTask\.Stop\(\) Method

Stops the background task synchronously by canceling and waiting for completion\.

```csharp
public void Stop();
```

<a name='DiGi.Core.Classes.CancelableBackgroundTask.StopAsync()'></a>

## CancelableBackgroundTask\.StopAsync\(\) Method

Stops the background task asynchronously by canceling and waiting for completion\.

```csharp
public System.Threading.Tasks.Task StopAsync();
```

Implements [StopAsync\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICancelableBackgroundTask.StopAsync() 'DiGi\.Core\.Interfaces\.ICancelableBackgroundTask\.StopAsync\(\)')

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')  
A task that represents the asynchronous stop operation\.
### Events

<a name='DiGi.Core.Classes.CancelableBackgroundTask.Canceled'></a>

## CancelableBackgroundTask\.Canceled Event

Occurs when the task has been canceled\.

```csharp
public event EventHandler? Canceled;
```

#### Event Type
[System\.EventHandler](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler 'System\.EventHandler')

<a name='DiGi.Core.Classes.CancelableBackgroundTask.Cancelling'></a>

## CancelableBackgroundTask\.Cancelling Event

Occurs when the task is being canceled\.

```csharp
public event EventHandler? Cancelling;
```

#### Event Type
[System\.EventHandler](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler 'System\.EventHandler')

<a name='DiGi.Core.Classes.Category'></a>

## Category Class

Represents a named category that can contain hierarchical subcategories\.

```csharp
public class Category : DiGi.Core.Classes.SerializableObject, System.IEquatable<DiGi.Core.Classes.Category>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → Category

Implements [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')
### Constructors

<a name='DiGi.Core.Classes.Category.Category(DiGi.Core.Classes.Category)'></a>

## Category\(Category\) Constructor

Initializes a new instance of the Category class by cloning an existing category\.

```csharp
public Category(DiGi.Core.Classes.Category? category);
```
#### Parameters

<a name='DiGi.Core.Classes.Category.Category(DiGi.Core.Classes.Category).category'></a>

`category` [Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category')

The category to clone\.

<a name='DiGi.Core.Classes.Category.Category(string)'></a>

## Category\(string\) Constructor

Initializes a new instance of the Category class with a specified name\.

```csharp
public Category(string? name);
```
#### Parameters

<a name='DiGi.Core.Classes.Category.Category(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the category\.

<a name='DiGi.Core.Classes.Category.Category(string,System.Collections.Generic.IEnumerable_DiGi.Core.Classes.Category_)'></a>

## Category\(string, IEnumerable\<Category\>\) Constructor

Initializes a new instance of the Category class with a specified name and a collection of subcategories\.

```csharp
public Category(string? name, System.Collections.Generic.IEnumerable<DiGi.Core.Classes.Category>? subCategories);
```
#### Parameters

<a name='DiGi.Core.Classes.Category.Category(string,System.Collections.Generic.IEnumerable_DiGi.Core.Classes.Category_).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the category\.

<a name='DiGi.Core.Classes.Category.Category(string,System.Collections.Generic.IEnumerable_DiGi.Core.Classes.Category_).subCategories'></a>

`subCategories` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The initial set of subcategories\.

<a name='DiGi.Core.Classes.Category.Category(System.Text.Json.Nodes.JsonObject)'></a>

## Category\(JsonObject\) Constructor

Initializes a new instance of the Category class from a JsonObject\.

```csharp
public Category(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.Category.Category(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to deserialize\.
### Properties

<a name='DiGi.Core.Classes.Category.Name'></a>

## Category\.Name Property

Gets the name of the category\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.Category.SubCategories'></a>

## Category\.SubCategories Property

Gets or sets the list of subcategories\.

```csharp
public System.Collections.Generic.List<DiGi.Core.Classes.Category>? SubCategories { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.Core.Classes.Category.Add(DiGi.Core.Classes.Category)'></a>

## Category\.Add\(Category\) Method

Adds a subcategory to the current category\.

```csharp
public bool Add(DiGi.Core.Classes.Category? category);
```
#### Parameters

<a name='DiGi.Core.Classes.Category.Add(DiGi.Core.Classes.Category).category'></a>

`category` [Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category')

The category to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the category was successfully added; otherwise, false\.

<a name='DiGi.Core.Classes.Category.Add(string)'></a>

## Category\.Add\(string\) Method

Creates and adds a subcategory with the specified name\.

```csharp
public DiGi.Core.Classes.Category? Add(string? name);
```
#### Parameters

<a name='DiGi.Core.Classes.Category.Add(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the subcategory to add\.

#### Returns
[Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category')  
The newly created Category, or null if it could not be added\.

<a name='DiGi.Core.Classes.Category.AddRange(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.Category_)'></a>

## Category\.AddRange\(IEnumerable\<Category\>\) Method

Adds a collection of subcategories to the current category\.

```csharp
public void AddRange(System.Collections.Generic.IEnumerable<DiGi.Core.Classes.Category>? subCategories);
```
#### Parameters

<a name='DiGi.Core.Classes.Category.AddRange(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.Category_).subCategories'></a>

`subCategories` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of categories to add\.

<a name='DiGi.Core.Classes.Category.Clone()'></a>

## Category\.Clone\(\) Method

Creates a deep copy of the current category\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.Clone() 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>\.Clone\(\)')

#### Returns
[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned version of the category as an ISerializableObject\.

<a name='DiGi.Core.Classes.Category.Equals(DiGi.Core.Classes.Category)'></a>

## Category\.Equals\(Category\) Method

Determines whether the current Category is equal to another Category\.

```csharp
public bool Equals(DiGi.Core.Classes.Category? category);
```
#### Parameters

<a name='DiGi.Core.Classes.Category.Equals(DiGi.Core.Classes.Category).category'></a>

`category` [Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category')

The other category to compare with\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if they are equal; otherwise, false\.

<a name='DiGi.Core.Classes.Category.Equals(object)'></a>

## Category\.Equals\(object\) Method

Determines whether the current Category is equal to a specified object\.

```csharp
public override bool Equals(object? @object);
```
#### Parameters

<a name='DiGi.Core.Classes.Category.Equals(object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if they are equal; otherwise, false\.

<a name='DiGi.Core.Classes.Category.GetHashCode()'></a>

## Category\.GetHashCode\(\) Method

Returns a hash code for the current category based on its name and subcategories\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A numeric hash code\.

<a name='DiGi.Core.Classes.Category.ToString()'></a>

## Category\.ToString\(\) Method

Returns a string that represents the current category's name\.

```csharp
public override string? ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The category name\.
### Operators

<a name='DiGi.Core.Classes.Category.op_Equality(DiGi.Core.Classes.Category,DiGi.Core.Classes.Category)'></a>

## Category\.operator ==\(Category, Category\) Operator

Determines whether two Category instances are equal\.

```csharp
public static bool operator ==(DiGi.Core.Classes.Category? category_1, DiGi.Core.Classes.Category? category_2);
```
#### Parameters

<a name='DiGi.Core.Classes.Category.op_Equality(DiGi.Core.Classes.Category,DiGi.Core.Classes.Category).category_1'></a>

`category_1` [Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category')

The first Category instance to compare\.

<a name='DiGi.Core.Classes.Category.op_Equality(DiGi.Core.Classes.Category,DiGi.Core.Classes.Category).category_2'></a>

`category_2` [Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category')

The second Category instance to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the two Category instances are considered equal; otherwise, false\.

<a name='DiGi.Core.Classes.Category.op_ImplicitDiGi.Core.Classes.Category(string)'></a>

## Category\.implicit operator Category\(string\) Operator

Implicitly converts a string to a [Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category') instance\.

```csharp
public static DiGi.Core.Classes.Category? implicit operator DiGi.Core.Classes.Category?(string? name);
```
#### Parameters

<a name='DiGi.Core.Classes.Category.op_ImplicitDiGi.Core.Classes.Category(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the category as a [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')\.

#### Returns
[Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category')  
A new [Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category') instance created from the provided name, or null if the name is null\.

<a name='DiGi.Core.Classes.Category.op_Implicitstring(DiGi.Core.Classes.Category)'></a>

## Category\.implicit operator string\(Category\) Operator

Implicitly converts a [Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category') instance to its name as a string\.

```csharp
public static string? implicit operator string?(DiGi.Core.Classes.Category? category);
```
#### Parameters

<a name='DiGi.Core.Classes.Category.op_Implicitstring(DiGi.Core.Classes.Category).category'></a>

`category` [Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category')

The [Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category') instance to convert\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The name of the category as a [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String'), or null if the category is null\.

<a name='DiGi.Core.Classes.Category.op_Inequality(DiGi.Core.Classes.Category,DiGi.Core.Classes.Category)'></a>

## Category\.operator \!=\(Category, Category\) Operator

Determines whether two Category instances are not equal\.

```csharp
public static bool operator !=(DiGi.Core.Classes.Category? category_1, DiGi.Core.Classes.Category? category_2);
```
#### Parameters

<a name='DiGi.Core.Classes.Category.op_Inequality(DiGi.Core.Classes.Category,DiGi.Core.Classes.Category).category_1'></a>

`category_1` [Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category')

The first Category instance to compare\.

<a name='DiGi.Core.Classes.Category.op_Inequality(DiGi.Core.Classes.Category,DiGi.Core.Classes.Category).category_2'></a>

`category_2` [Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category')

The second Category instance to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the two Category instances are not considered equal; otherwise, false\.

<a name='DiGi.Core.Classes.CategoryPath'></a>

## CategoryPath Class

Represents a hierarchical path to a category\.

```csharp
public class CategoryPath : DiGi.Core.Classes.ObjectPath<DiGi.Core.Classes.CategoryPath>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.ObjectPath&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath_TObjectPath_ 'DiGi\.Core\.Classes\.ObjectPath\<TObjectPath\>')[CategoryPath](DiGi.Core.Classes.md#DiGi.Core.Classes.CategoryPath 'DiGi\.Core\.Classes\.CategoryPath')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath_TObjectPath_ 'DiGi\.Core\.Classes\.ObjectPath\<TObjectPath\>') → CategoryPath
### Constructors

<a name='DiGi.Core.Classes.CategoryPath.CategoryPath(string)'></a>

## CategoryPath\(string\) Constructor

Initializes a new instance of the [CategoryPath](DiGi.Core.Classes.md#DiGi.Core.Classes.CategoryPath 'DiGi\.Core\.Classes\.CategoryPath') class with a single segment name\.

```csharp
public CategoryPath(string name);
```
#### Parameters

<a name='DiGi.Core.Classes.CategoryPath.CategoryPath(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the category segment\.

<a name='DiGi.Core.Classes.CategoryPath.CategoryPath(string,DiGi.Core.Classes.CategoryPath)'></a>

## CategoryPath\(string, CategoryPath\) Constructor

Initializes a new instance of the [CategoryPath](DiGi.Core.Classes.md#DiGi.Core.Classes.CategoryPath 'DiGi\.Core\.Classes\.CategoryPath') class by appending a name to an existing path\.

```csharp
public CategoryPath(string name, DiGi.Core.Classes.CategoryPath path);
```
#### Parameters

<a name='DiGi.Core.Classes.CategoryPath.CategoryPath(string,DiGi.Core.Classes.CategoryPath).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the segment to append\.

<a name='DiGi.Core.Classes.CategoryPath.CategoryPath(string,DiGi.Core.Classes.CategoryPath).path'></a>

`path` [CategoryPath](DiGi.Core.Classes.md#DiGi.Core.Classes.CategoryPath 'DiGi\.Core\.Classes\.CategoryPath')

The existing category path to which the name will be appended\.

<a name='DiGi.Core.Classes.CategoryPath.CategoryPath(System.Collections.Generic.IEnumerable_string_)'></a>

## CategoryPath\(IEnumerable\<string\>\) Constructor

Initializes a new instance of the [CategoryPath](DiGi.Core.Classes.md#DiGi.Core.Classes.CategoryPath 'DiGi\.Core\.Classes\.CategoryPath') class using a collection of segment names\.

```csharp
public CategoryPath(System.Collections.Generic.IEnumerable<string> names);
```
#### Parameters

<a name='DiGi.Core.Classes.CategoryPath.CategoryPath(System.Collections.Generic.IEnumerable_string_).names'></a>

`names` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segment names to initialize the path\.

<a name='DiGi.Core.Classes.CategoryPath.CategoryPath(System.Text.Json.Nodes.JsonObject)'></a>

## CategoryPath\(JsonObject\) Constructor

Initializes a new instance of the [CategoryPath](DiGi.Core.Classes.md#DiGi.Core.Classes.CategoryPath 'DiGi\.Core\.Classes\.CategoryPath') class from a JSON object\.

```csharp
public CategoryPath(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.CategoryPath.CategoryPath(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the category path\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\> Class

An abstract base class for a two\-key\-indexed collection of values\.

```csharp
public abstract class Cluster<TKey_1,TKey_2,TValue> : DiGi.Core.Interfaces.IObject, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable
```
#### Type parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TKey_1'></a>

`TKey_1`

The type of the first key\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TKey_2'></a>

`TKey_2`

The type of the second key\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TValue'></a>

`TValue`

The type of the value\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Cluster\<TKey\_1,TKey\_2,TValue\>

Derived  
↳ [List&lt;TKey\_1,TKey\_2,TValue&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>')  
↳ [ValueCluster&lt;TKey\_1,TKey\_2,TValue&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>')

Implements [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')
### Constructors

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Cluster()'></a>

## Cluster\(\) Constructor

Initializes a new instance of the Cluster class\.

```csharp
public Cluster();
```

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Cluster(DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_)'></a>

## Cluster\(Cluster\<TKey\_1,TKey\_2,TValue\>\) Constructor

Initializes a new instance of the Cluster class by cloning another cluster\.

```csharp
public Cluster(DiGi.Core.Classes.Cluster<TKey_1,TKey_2,TValue>? cluster);
```
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Cluster(DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_).cluster'></a>

`cluster` [DiGi\.Core\.Classes\.Cluster&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')[TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')[TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')

The cluster to clone\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Cluster(System.Collections.Generic.IEnumerable_TValue_)'></a>

## Cluster\(IEnumerable\<TValue\>\) Constructor

Initializes a new instance of the Cluster class with the specified values\.

```csharp
public Cluster(System.Collections.Generic.IEnumerable<TValue>? values);
```
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Cluster(System.Collections.Generic.IEnumerable_TValue_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The values to populate the cluster with\.
### Properties

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Values'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.Values Property

Gets or sets the list of values in the cluster\.

```csharp
public System.Collections.Generic.List<TValue>? Values { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Add(TValue)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.Add\(TValue\) Method

Adds a value to the cluster\.

```csharp
public abstract bool Add(TValue? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Add(TValue).value'></a>

`value` [TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TValue')

The value to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was added; otherwise, false\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.AddRange_UValue_(System.Collections.Generic.IEnumerable_UValue_)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.AddRange\<UValue\>\(IEnumerable\<UValue\>\) Method

Adds multiple values to the cluster and returns those that were successfully added\.

```csharp
public System.Collections.Generic.List<UValue>? AddRange<UValue>(System.Collections.Generic.IEnumerable<UValue?>? values)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.AddRange_UValue_(System.Collections.Generic.IEnumerable_UValue_).UValue'></a>

`UValue`

The type of the values\.
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.AddRange_UValue_(System.Collections.Generic.IEnumerable_UValue_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.AddRange_UValue_(System.Collections.Generic.IEnumerable_UValue_).UValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.AddRange\<UValue\>\(System\.Collections\.Generic\.IEnumerable\<UValue\>\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The values to add\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.AddRange_UValue_(System.Collections.Generic.IEnumerable_UValue_).UValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.AddRange\<UValue\>\(System\.Collections\.Generic\.IEnumerable\<UValue\>\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of values that were successfully added\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Clear()'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.Clear\(\) Method

Clears all values from the cluster\.

```csharp
public abstract void Clear();
```

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Contains(TKey_1)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.Contains\(TKey\_1\) Method

Determines whether the cluster contains a value with the specified first key\.

```csharp
public abstract bool Contains(TKey_1? key_1);
```
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Contains(TKey_1).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The first key to locate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the cluster contains a value with the specified key; otherwise, false\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Contains(TKey_1,TKey_2)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.Contains\(TKey\_1, TKey\_2\) Method

Determines whether the cluster contains a value with the specified first and second keys\.

```csharp
public abstract bool Contains(TKey_1? key_1, TKey_2? key_2);
```
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Contains(TKey_1,TKey_2).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The first key to locate\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Contains(TKey_1,TKey_2).key_2'></a>

`key_2` [TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')

The second key to locate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the cluster contains a value with the specified keys; otherwise, false\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Contains(TValue)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.Contains\(TValue\) Method

Determines whether the cluster contains a specific value\.

```csharp
public abstract bool Contains(TValue? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Contains(TValue).value'></a>

`value` [TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TValue')

The value to locate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the cluster contains the value; otherwise, false\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetEnumerator()'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the cluster values\.

Derivatives should override this method with a streaming implementation over their internal storage; the base implementation materializes a list via [GetValues&lt;UValue&gt;\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetValues_UValue_() 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.GetValues\<UValue\>\(\)').

```csharp
public virtual System.Collections.Generic.IEnumerator<TValue> GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator 'System\.Collections\.Generic\.IEnumerable\`1\.GetEnumerator'), [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

#### Returns
[System\.Collections\.Generic\.IEnumerator&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')  
An enumerator for the cluster values\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetKeys_1()'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.GetKeys\_1\(\) Method

Gets a list of all unique first keys in the cluster\.

Values are drawn from the cluster's enumeration ([GetEnumerator\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetEnumerator() 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.GetEnumerator\(\)')), so derivatives with a streaming enumerator avoid the intermediate list allocation.

```csharp
public virtual System.Collections.Generic.List<TKey_1>? GetKeys_1();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of first keys; empty if the cluster contains none\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetKeys_2(TKey_1)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.GetKeys\_2\(TKey\_1\) Method

Gets a list of all unique second keys for values with the specified first key\.

Values are drawn from the cluster's enumeration ([GetEnumerator\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetEnumerator() 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.GetEnumerator\(\)')), so derivatives with a streaming enumerator avoid the intermediate list allocation.

```csharp
public virtual System.Collections.Generic.List<TKey_2>? GetKeys_2(TKey_1? key_1);
```
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetKeys_2(TKey_1).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The first key to filter by\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of second keys; empty if the cluster has no matching values, or null if key\_1 is null\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetKey_1(TValue)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.GetKey\_1\(TValue\) Method

Gets the first key for a given value\.

```csharp
protected abstract TKey_1? GetKey_1(TValue? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetKey_1(TValue).value'></a>

`value` [TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TValue')

The value to get the key from\.

#### Returns
[TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')  
The first key, or null\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetKey_2(TValue)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.GetKey\_2\(TValue\) Method

Gets the second key for a given value\.

```csharp
protected abstract TKey_2? GetKey_2(TValue? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetKey_2(TValue).value'></a>

`value` [TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TValue')

The value to get the key from\.

#### Returns
[TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')  
The second key, or null\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetValue_UValue_(System.Func_UValue,bool_)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.GetValue\<UValue\>\(Func\<UValue,bool\>\) Method

Gets the first value matching the specified predicate\.

```csharp
public virtual UValue? GetValue<UValue>(System.Func<UValue?,bool>? func)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetValue_UValue_(System.Func_UValue,bool_).UValue'></a>

`UValue`

The type of the value\.
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetValue_UValue_(System.Func_UValue,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetValue_UValue_(System.Func_UValue,bool_).UValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.GetValue\<UValue\>\(System\.Func\<UValue,bool\>\)\.UValue')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

A predicate function to filter values\.

#### Returns
[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetValue_UValue_(System.Func_UValue,bool_).UValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.GetValue\<UValue\>\(System\.Func\<UValue,bool\>\)\.UValue')  
The first matching value, or default if none found\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetValues_UValue_()'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.GetValues\<UValue\>\(\) Method

Gets a list of all values of the specified type\.

```csharp
public abstract System.Collections.Generic.List<UValue>? GetValues<UValue>()
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetValues_UValue_().UValue'></a>

`UValue`

The type of the value\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetValues_UValue_().UValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.GetValues\<UValue\>\(\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of values, or null if none found\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetValues_UValue_(System.Func_UValue,bool_)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.GetValues\<UValue\>\(Func\<UValue,bool\>\) Method

Gets a list of values filtered by the specified predicate\.

Values are drawn from the cluster's enumeration ([GetEnumerator\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetEnumerator() 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.GetEnumerator\(\)')), so derivatives with a streaming enumerator avoid the intermediate list allocation.

```csharp
public System.Collections.Generic.List<UValue>? GetValues<UValue>(System.Func<UValue?,bool>? func)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetValues_UValue_(System.Func_UValue,bool_).UValue'></a>

`UValue`

The type of the value\.
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetValues_UValue_(System.Func_UValue,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetValues_UValue_(System.Func_UValue,bool_).UValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.GetValues\<UValue\>\(System\.Func\<UValue,bool\>\)\.UValue')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

A predicate function to filter values; all values are returned when null\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetValues_UValue_(System.Func_UValue,bool_).UValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.GetValues\<UValue\>\(System\.Func\<UValue,bool\>\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of matching values; empty if none match\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.GetValues\<UValue\>\(TKey\_1\) Method

Gets a list of values filtered by the specified first key\.

Values are drawn from the cluster's enumeration ([GetEnumerator\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetEnumerator() 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.GetEnumerator\(\)')), so derivatives with a streaming enumerator avoid the intermediate list allocation.

```csharp
public virtual System.Collections.Generic.List<UValue>? GetValues<UValue>(TKey_1? key_1)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1).UValue'></a>

`UValue`

The type of the value\.
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The first key to filter by\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1).UValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.GetValues\<UValue\>\(TKey\_1\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of matching values; empty if none match, or null if key\_1 is null\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.IsValid(TValue)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.IsValid\(TValue\) Method

Determines whether the specified value is valid for this cluster\.

```csharp
public virtual bool IsValid(TValue? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.IsValid(TValue).value'></a>

`value` [TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TValue')

The value to validate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value is valid; otherwise, false\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Remove(TKey_1)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.Remove\(TKey\_1\) Method

Removes all values with the specified first key\.

```csharp
public abstract bool Remove(TKey_1? key_1);
```
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Remove(TKey_1).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The first key to filter by\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if any values were removed; otherwise, false\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Remove(TKey_1,TKey_2)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.Remove\(TKey\_1, TKey\_2\) Method

Removes all values with the specified first and second keys\.

```csharp
public abstract bool Remove(TKey_1? key_1, TKey_2? key_2);
```
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Remove(TKey_1,TKey_2).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The first key to filter by\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Remove(TKey_1,TKey_2).key_2'></a>

`key_2` [TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')

The second key to filter by\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if any values were removed; otherwise, false\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Remove(TValue)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.Remove\(TValue\) Method

Removes a specific value from the cluster\.

```csharp
public abstract bool Remove(TValue? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.Remove(TValue).value'></a>

`value` [TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TValue')

The value to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was removed; otherwise, false\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.SetValues(System.Collections.Generic.IEnumerable_TValue_)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.SetValues\(IEnumerable\<TValue\>\) Method

Sets the cluster values by clearing existing values and adding the specified ones\.

```csharp
protected bool SetValues(System.Collections.Generic.IEnumerable<TValue>? values);
```
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.SetValues(System.Collections.Generic.IEnumerable_TValue_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The values to set\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if values were set successfully; otherwise, false\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValue_UValue_(System.Func_UValue,bool_,UValue)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.TryGetValue\<UValue\>\(Func\<UValue,bool\>, UValue\) Method

Attempts to get the first value matching the specified predicate\.

```csharp
public bool TryGetValue<UValue>(System.Func<UValue?,bool>? func, out UValue? value)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValue_UValue_(System.Func_UValue,bool_,UValue).UValue'></a>

`UValue`

The type of the value\.
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValue_UValue_(System.Func_UValue,bool_,UValue).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValue_UValue_(System.Func_UValue,bool_,UValue).UValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TryGetValue\<UValue\>\(System\.Func\<UValue,bool\>, UValue\)\.UValue')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

A predicate function to filter values\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValue_UValue_(System.Func_UValue,bool_,UValue).value'></a>

`value` [UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValue_UValue_(System.Func_UValue,bool_,UValue).UValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TryGetValue\<UValue\>\(System\.Func\<UValue,bool\>, UValue\)\.UValue')

When this method returns, contains the first matching value, or default if no match was found\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a matching value was found; otherwise, false\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValue_UValue_(UValue,System.Func_UValue,bool_)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.TryGetValue\<UValue\>\(UValue, Func\<UValue,bool\>\) Method

Attempts to get the first value matching the specified predicate\.

```csharp
public bool TryGetValue<UValue>(out UValue? value, System.Func<UValue?,bool>? func)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValue_UValue_(UValue,System.Func_UValue,bool_).UValue'></a>

`UValue`

The type of the value\.
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValue_UValue_(UValue,System.Func_UValue,bool_).value'></a>

`value` [UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValue_UValue_(UValue,System.Func_UValue,bool_).UValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TryGetValue\<UValue\>\(UValue, System\.Func\<UValue,bool\>\)\.UValue')

When this method returns, contains the first matching value, or default if no match was found\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValue_UValue_(UValue,System.Func_UValue,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValue_UValue_(UValue,System.Func_UValue,bool_).UValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TryGetValue\<UValue\>\(UValue, System\.Func\<UValue,bool\>\)\.UValue')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

A predicate function to filter values\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a matching value was found; otherwise, false\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValues_UValue_(System.Collections.Generic.List_UValue_,System.Func_UValue,bool_)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.TryGetValues\<UValue\>\(List\<UValue\>, Func\<UValue,bool\>\) Method

Attempts to get values filtered by the specified predicate\.

```csharp
public bool TryGetValues<UValue>(out System.Collections.Generic.List<UValue>? values, System.Func<UValue?,bool>? func)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValues_UValue_(System.Collections.Generic.List_UValue_,System.Func_UValue,bool_).UValue'></a>

`UValue`

The type of the value\.
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValues_UValue_(System.Collections.Generic.List_UValue_,System.Func_UValue,bool_).values'></a>

`values` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValues_UValue_(System.Collections.Generic.List_UValue_,System.Func_UValue,bool_).UValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TryGetValues\<UValue\>\(System\.Collections\.Generic\.List\<UValue\>, System\.Func\<UValue,bool\>\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains the matching values, or null if none found\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValues_UValue_(System.Collections.Generic.List_UValue_,System.Func_UValue,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValues_UValue_(System.Collections.Generic.List_UValue_,System.Func_UValue,bool_).UValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TryGetValues\<UValue\>\(System\.Collections\.Generic\.List\<UValue\>, System\.Func\<UValue,bool\>\)\.UValue')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

A predicate function to filter values\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if any matching values were found; otherwise, false\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValues_UValue_(System.Func_UValue,bool_,System.Collections.Generic.List_UValue_)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.TryGetValues\<UValue\>\(Func\<UValue,bool\>, List\<UValue\>\) Method

Attempts to get values filtered by the specified predicate\.

```csharp
public bool TryGetValues<UValue>(System.Func<UValue?,bool>? func, out System.Collections.Generic.List<UValue>? values)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValues_UValue_(System.Func_UValue,bool_,System.Collections.Generic.List_UValue_).UValue'></a>

`UValue`

The type of the value\.
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValues_UValue_(System.Func_UValue,bool_,System.Collections.Generic.List_UValue_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValues_UValue_(System.Func_UValue,bool_,System.Collections.Generic.List_UValue_).UValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TryGetValues\<UValue\>\(System\.Func\<UValue,bool\>, System\.Collections\.Generic\.List\<UValue\>\)\.UValue')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

A predicate function to filter values\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValues_UValue_(System.Func_UValue,bool_,System.Collections.Generic.List_UValue_).values'></a>

`values` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValues_UValue_(System.Func_UValue,bool_,System.Collections.Generic.List_UValue_).UValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TryGetValues\<UValue\>\(System\.Func\<UValue,bool\>, System\.Collections\.Generic\.List\<UValue\>\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains the matching values, or null if none found\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if any matching values were found; otherwise, false\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValues_UValue_(TKey_1,System.Collections.Generic.List_UValue_)'></a>

## Cluster\<TKey\_1,TKey\_2,TValue\>\.TryGetValues\<UValue\>\(TKey\_1, List\<UValue\>\) Method

Attempts to get values filtered by the specified first key\.

```csharp
public bool TryGetValues<UValue>(TKey_1? key_1, out System.Collections.Generic.List<UValue>? values)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValues_UValue_(TKey_1,System.Collections.Generic.List_UValue_).UValue'></a>

`UValue`

The type of the value\.
#### Parameters

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValues_UValue_(TKey_1,System.Collections.Generic.List_UValue_).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The first key to filter by\.

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValues_UValue_(TKey_1,System.Collections.Generic.List_UValue_).values'></a>

`values` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.TryGetValues_UValue_(TKey_1,System.Collections.Generic.List_UValue_).UValue 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>\.TryGetValues\<UValue\>\(TKey\_1, System\.Collections\.Generic\.List\<UValue\>\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains the matching values, or null if none found\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if any matching values were found; otherwise, false\.
### Explicit Interface Implementations

<a name='DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_.System.Collections.IEnumerable.GetEnumerator()'></a>

## System\.Collections\.IEnumerable\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the cluster values\.

```csharp
System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

<a name='DiGi.Core.Classes.Color'></a>

## Color Class

Represents an ARGB color, providing conversions between integer values and System\.Drawing\.Color\.

```csharp
public class Color : DiGi.Core.Classes.SerializableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → Color
### Constructors

<a name='DiGi.Core.Classes.Color.Color(byte,byte,byte,byte)'></a>

## Color\(byte, byte, byte, byte\) Constructor

Initializes a new instance of the Color class with specified ARGB components\.

```csharp
public Color(byte alpha, byte red, byte green, byte blue);
```
#### Parameters

<a name='DiGi.Core.Classes.Color.Color(byte,byte,byte,byte).alpha'></a>

`alpha` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')

The alpha component\.

<a name='DiGi.Core.Classes.Color.Color(byte,byte,byte,byte).red'></a>

`red` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')

The red component\.

<a name='DiGi.Core.Classes.Color.Color(byte,byte,byte,byte).green'></a>

`green` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')

The green component\.

<a name='DiGi.Core.Classes.Color.Color(byte,byte,byte,byte).blue'></a>

`blue` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')

The blue component\.

<a name='DiGi.Core.Classes.Color.Color(DiGi.Core.Classes.Color)'></a>

## Color\(Color\) Constructor

Initializes a new instance of the Color class by copying another Color instance\.

```csharp
public Color(DiGi.Core.Classes.Color? color);
```
#### Parameters

<a name='DiGi.Core.Classes.Color.Color(DiGi.Core.Classes.Color).color'></a>

`color` [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color')

The source color to copy from\.

<a name='DiGi.Core.Classes.Color.Color(int)'></a>

## Color\(int\) Constructor

Initializes a new instance of the Color class from an integer value\.

```csharp
public Color(int value);
```
#### Parameters

<a name='DiGi.Core.Classes.Color.Color(int).value'></a>

`value` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The ARGB integer value\.

<a name='DiGi.Core.Classes.Color.Color(System.Drawing.Color)'></a>

## Color\(Color\) Constructor

Initializes a new instance of the Color class from a System\.Drawing\.Color object\.

```csharp
public Color(System.Drawing.Color color);
```
#### Parameters

<a name='DiGi.Core.Classes.Color.Color(System.Drawing.Color).color'></a>

`color` [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')

The source color\.

<a name='DiGi.Core.Classes.Color.Color(System.Text.Json.Nodes.JsonObject)'></a>

## Color\(JsonObject\) Constructor

Initializes a new instance of the Color class from a JsonObject\.

```csharp
public Color(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.Color.Color(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing color data\.
### Properties

<a name='DiGi.Core.Classes.Color.Alpha'></a>

## Color\.Alpha Property

Gets the alpha component of the color\.

```csharp
public byte Alpha { get; }
```

#### Property Value
[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')

<a name='DiGi.Core.Classes.Color.Blue'></a>

## Color\.Blue Property

Gets the blue component of the color\.

```csharp
public byte Blue { get; }
```

#### Property Value
[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')

<a name='DiGi.Core.Classes.Color.Green'></a>

## Color\.Green Property

Gets the green component of the color\.

```csharp
public byte Green { get; }
```

#### Property Value
[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')

<a name='DiGi.Core.Classes.Color.Red'></a>

## Color\.Red Property

Gets the red component of the color\.

```csharp
public byte Red { get; }
```

#### Property Value
[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')

<a name='DiGi.Core.Classes.Color.Value'></a>

## Color\.Value Property

Gets the integer representation \(ARGB\) of the color\.

```csharp
public int Value { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')
### Methods

<a name='DiGi.Core.Classes.Color.Equals(object)'></a>

## Color\.Equals\(object\) Method

Determines whether the specified object is equal to the current Color instance\.

```csharp
public override bool Equals(object? @object);
```
#### Parameters

<a name='DiGi.Core.Classes.Color.Equals(object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the objects are equal; otherwise, false\.

<a name='DiGi.Core.Classes.Color.GetHashCode()'></a>

## Color\.GetHashCode\(\) Method

Returns a hash code for the current Color instance\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The hash code of the color\.
### Operators

<a name='DiGi.Core.Classes.Color.op_Equality(DiGi.Core.Classes.Color,DiGi.Core.Classes.Color)'></a>

## Color\.operator ==\(Color, Color\) Operator

Determines whether two [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color') instances are equal\.

```csharp
public static bool operator ==(DiGi.Core.Classes.Color? color_1, DiGi.Core.Classes.Color? color_2);
```
#### Parameters

<a name='DiGi.Core.Classes.Color.op_Equality(DiGi.Core.Classes.Color,DiGi.Core.Classes.Color).color_1'></a>

`color_1` [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color')

The first [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color') instance to compare\.

<a name='DiGi.Core.Classes.Color.op_Equality(DiGi.Core.Classes.Color,DiGi.Core.Classes.Color).color_2'></a>

`color_2` [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color')

The second [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color') instance to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the two [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color') instances are equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Core.Classes.Color.op_ImplicitDiGi.Core.Classes.Color(int)'></a>

## Color\.implicit operator Color\(int\) Operator

Implicitly converts an integer representation of a color \(typically in ARGB format\) to a [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color') instance\.

```csharp
public static DiGi.Core.Classes.Color implicit operator DiGi.Core.Classes.Color(int value);
```
#### Parameters

<a name='DiGi.Core.Classes.Color.op_ImplicitDiGi.Core.Classes.Color(int).value'></a>

`value` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer value representing the color\.

#### Returns
[Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color')  
A new [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color') instance created from the specified integer value\.

<a name='DiGi.Core.Classes.Color.op_ImplicitDiGi.Core.Classes.Color(System.Drawing.Color)'></a>

## Color\.implicit operator Color\(Color\) Operator

Implicitly converts a [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color') instance to a [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color') instance\.

```csharp
public static DiGi.Core.Classes.Color implicit operator DiGi.Core.Classes.Color(System.Drawing.Color color);
```
#### Parameters

<a name='DiGi.Core.Classes.Color.op_ImplicitDiGi.Core.Classes.Color(System.Drawing.Color).color'></a>

`color` [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')

The [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color') instance to convert\.

#### Returns
[Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color')  
A new [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color') instance created from the specified [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')\.

<a name='DiGi.Core.Classes.Color.op_ImplicitSystem.Drawing.Color(DiGi.Core.Classes.Color)'></a>

## Color\.implicit operator Color\(Color\) Operator

Implicitly converts a nullable [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color') instance to a [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color') instance\.

```csharp
public static System.Drawing.Color implicit operator System.Drawing.Color(DiGi.Core.Classes.Color? color);
```
#### Parameters

<a name='DiGi.Core.Classes.Color.op_ImplicitSystem.Drawing.Color(DiGi.Core.Classes.Color).color'></a>

`color` [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color')

The nullable [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color') instance to convert\.

#### Returns
[System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')  
A [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color') instance representing the specified color, or [System\.Drawing\.Color\.Empty](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color.empty 'System\.Drawing\.Color\.Empty') if the provided color is null\.

<a name='DiGi.Core.Classes.Color.op_Inequality(DiGi.Core.Classes.Color,DiGi.Core.Classes.Color)'></a>

## Color\.operator \!=\(Color, Color\) Operator

Determines whether two [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color') instances are not equal\.

```csharp
public static bool operator !=(DiGi.Core.Classes.Color? color_1, DiGi.Core.Classes.Color? color_2);
```
#### Parameters

<a name='DiGi.Core.Classes.Color.op_Inequality(DiGi.Core.Classes.Color,DiGi.Core.Classes.Color).color_1'></a>

`color_1` [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color')

The first [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color') instance to compare\.

<a name='DiGi.Core.Classes.Color.op_Inequality(DiGi.Core.Classes.Color,DiGi.Core.Classes.Color).color_2'></a>

`color_2` [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color')

The second [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color') instance to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the two [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color') instances are not equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Core.Classes.ComplexReference'></a>

## ComplexReference Class

Represents a reference reached by walking an ordered chain of references, so that an object nested inside a
containment hierarchy can be addressed from its root \- for example a wall inside a building inside an area
inside a country\.

Each step is an ordinary reference and is nested inside the rendered string, which is what allows a
            chain of any depth to be parsed back in a single pass without knowing any step's shape in advance.

This is an [IComplexReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IComplexReference 'DiGi\.Core\.Interfaces\.IComplexReference') and deliberately not an
            [IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference'): a path has no unique identifier of its own, and keeping it out of the
            unique-reference APIs keeps long paths out of storage keys.

The chain is structural only. DiGi.Core has no containment model, so nothing here validates that the
            steps actually contain one another; that belongs to whichever repository knows the hierarchy.

```csharp
public class ComplexReference : DiGi.Core.Classes.SerializableReference, DiGi.Core.Interfaces.IComplexReference, DiGi.Core.Interfaces.IReference, DiGi.Core.Interfaces.IObject, System.IEquatable<DiGi.Core.Interfaces.IReference>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') → ComplexReference

Implements [IComplexReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IComplexReference 'DiGi\.Core\.Interfaces\.IComplexReference'), [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

### Example
A country, area, building and wall chain renders and parses \(via
[TryParse\(this string, IReference\)](DiGi.Core.md#DiGi.Core.Query.TryParse(thisstring,DiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.TryParse\(this string, DiGi\.Core\.Interfaces\.IReference\)')\) as the discriminator followed by one nested step
per level \(shown wrapped for readability; the actual string has no whitespace\):

```csharp
Complex::(TypeExternal::POLAND::(Type::DiGi.GIS.Classes.Country,DiGi.GIS))
        ::(UniqueId::(Type::DiGi.GIS.Classes.Area,DiGi.GIS)::Mazowieckie)
        ::(UniqueId::(Type::DiGi.GIS.Classes.Building,DiGi.GIS)::BLD-001)
        ::(Guid::(Type::DiGi.Analytical.Building.Classes.Wall,DiGi.Analytical.Building)::0f8fad5bd9cb469fa16570867728950e)
```
### Constructors

<a name='DiGi.Core.Classes.ComplexReference.ComplexReference(DiGi.Core.Classes.ComplexReference)'></a>

## ComplexReference\(ComplexReference\) Constructor

Initializes a new instance of the [ComplexReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ComplexReference 'DiGi\.Core\.Classes\.ComplexReference') class by copying an existing reference\.

```csharp
public ComplexReference(DiGi.Core.Classes.ComplexReference? complexReference);
```
#### Parameters

<a name='DiGi.Core.Classes.ComplexReference.ComplexReference(DiGi.Core.Classes.ComplexReference).complexReference'></a>

`complexReference` [ComplexReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ComplexReference 'DiGi\.Core\.Classes\.ComplexReference')

The existing reference to copy\.

<a name='DiGi.Core.Classes.ComplexReference.ComplexReference(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.ISerializableReference_)'></a>

## ComplexReference\(IEnumerable\<ISerializableReference\>\) Constructor

Initializes a new instance of the [ComplexReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ComplexReference 'DiGi\.Core\.Classes\.ComplexReference') class from an ordered chain of references\.

```csharp
public ComplexReference(System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.ISerializableReference?>? references);
```
#### Parameters

<a name='DiGi.Core.Classes.ComplexReference.ComplexReference(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.ISerializableReference_).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The steps of the chain, from the root inwards\. Null steps are skipped\.

<a name='DiGi.Core.Classes.ComplexReference.ComplexReference(System.Text.Json.Nodes.JsonObject)'></a>

## ComplexReference\(JsonObject\) Constructor

Initializes a new instance of the [ComplexReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ComplexReference 'DiGi\.Core\.Classes\.ComplexReference') class from a JSON object\.

```csharp
public ComplexReference(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.ComplexReference.ComplexReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.
### Properties

<a name='DiGi.Core.Classes.ComplexReference.Count'></a>

## ComplexReference\.Count Property

Gets the number of steps in the chain\.

```csharp
public int Count { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.Classes.ComplexReference.References'></a>

## ComplexReference\.References Property

Gets the steps of the chain, from the root inwards\.

```csharp
public System.Collections.Generic.List<DiGi.Core.Interfaces.ISerializableReference> References { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Core.Classes.ComplexReference.Segments'></a>

## ComplexReference\.Segments Property

Gets the segments of this reference's string form: one nested segment per step, in order\.

The only reference with a variable number of segments; every other type declares a fixed count.

```csharp
protected override System.Collections.Generic.IEnumerable<string?> Segments { protected get; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.Core.Classes.ComplexReference.this[int]'></a>

## ComplexReference\.this\[int\] Property

Gets the step at the specified position in the chain\.

```csharp
public DiGi.Core.Interfaces.ISerializableReference? this[int index] { get; }
```
#### Parameters

<a name='DiGi.Core.Classes.ComplexReference.this[int].index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based position, counted from the root\.

#### Property Value
[ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference')
### Methods

<a name='DiGi.Core.Classes.ComplexReference.Clone()'></a>

## ComplexReference\.Clone\(\) Method

Creates a deep copy of the current object\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.Clone() 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>\.Clone\(\)')

#### Returns
[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A deep copy of the current object\.

<a name='DiGi.Core.Classes.ConfigurationFile'></a>

## ConfigurationFile Class

Manages the reading, writing, and retrieval of key\-value pair configuration settings from a file\.

```csharp
public class ConfigurationFile : DiGi.Core.Classes.SerializableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → ConfigurationFile
### Constructors

<a name='DiGi.Core.Classes.ConfigurationFile.ConfigurationFile()'></a>

## ConfigurationFile\(\) Constructor

Initializes a new empty instance of the ConfigurationFile class\.

```csharp
public ConfigurationFile();
```

<a name='DiGi.Core.Classes.ConfigurationFile.ConfigurationFile(DiGi.Core.Classes.ConfigurationFile)'></a>

## ConfigurationFile\(ConfigurationFile\) Constructor

Initializes a new instance of the ConfigurationFile class by copying settings from another instance\.

```csharp
public ConfigurationFile(DiGi.Core.Classes.ConfigurationFile? configurationFile);
```
#### Parameters

<a name='DiGi.Core.Classes.ConfigurationFile.ConfigurationFile(DiGi.Core.Classes.ConfigurationFile).configurationFile'></a>

`configurationFile` [ConfigurationFile](DiGi.Core.Classes.md#DiGi.Core.Classes.ConfigurationFile 'DiGi\.Core\.Classes\.ConfigurationFile')

The source configuration file to copy from\.

<a name='DiGi.Core.Classes.ConfigurationFile.ConfigurationFile(System.Text.Json.Nodes.JsonObject)'></a>

## ConfigurationFile\(JsonObject\) Constructor

Initializes a new instance of the ConfigurationFile class from a JsonObject\.

```csharp
public ConfigurationFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.ConfigurationFile.ConfigurationFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing configuration data\.
### Properties

<a name='DiGi.Core.Classes.ConfigurationFile.Dictionary'></a>

## ConfigurationFile\.Dictionary Property

Gets the dictionary containing key\-value configuration settings\.

```csharp
public System.Collections.Generic.Dictionary<string,string> Dictionary { get; }
```

#### Property Value
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

<a name='DiGi.Core.Classes.ConfigurationFile.Names'></a>

## ConfigurationFile\.Names Property

Gets the list of all configuration key names\.

```csharp
public System.Collections.Generic.List<string> Names { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.Core.Classes.ConfigurationFile.Add(string,string)'></a>

## ConfigurationFile\.Add\(string, string\) Method

Adds or removes a string configuration setting\.

```csharp
public bool Add(string name, string? value);
```
#### Parameters

<a name='DiGi.Core.Classes.ConfigurationFile.Add(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The key of the setting\.

<a name='DiGi.Core.Classes.ConfigurationFile.Add(string,string).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value to set, or null to remove the setting\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the operation was successful; otherwise, false\.

<a name='DiGi.Core.Classes.ConfigurationFile.Add(string,System.Nullable_bool_)'></a>

## ConfigurationFile\.Add\(string, Nullable\<bool\>\) Method

Adds or removes a boolean configuration setting\.

```csharp
public bool Add(string name, System.Nullable<bool> value);
```
#### Parameters

<a name='DiGi.Core.Classes.ConfigurationFile.Add(string,System.Nullable_bool_).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The key of the setting\.

<a name='DiGi.Core.Classes.ConfigurationFile.Add(string,System.Nullable_bool_).value'></a>

`value` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The value to set, or null to remove the setting\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the operation was successful; otherwise, false\.

<a name='DiGi.Core.Classes.ConfigurationFile.Add(string,System.Nullable_double_)'></a>

## ConfigurationFile\.Add\(string, Nullable\<double\>\) Method

Adds or removes a double configuration setting\.

```csharp
public bool Add(string name, System.Nullable<double> value);
```
#### Parameters

<a name='DiGi.Core.Classes.ConfigurationFile.Add(string,System.Nullable_double_).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The key of the setting\.

<a name='DiGi.Core.Classes.ConfigurationFile.Add(string,System.Nullable_double_).value'></a>

`value` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The value to set, or null to remove the setting\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the operation was successful; otherwise, false\.

<a name='DiGi.Core.Classes.ConfigurationFile.Add(string,System.Nullable_int_)'></a>

## ConfigurationFile\.Add\(string, Nullable\<int\>\) Method

Adds or removes an integer configuration setting\.

```csharp
public bool Add(string name, System.Nullable<int> value);
```
#### Parameters

<a name='DiGi.Core.Classes.ConfigurationFile.Add(string,System.Nullable_int_).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The key of the setting\.

<a name='DiGi.Core.Classes.ConfigurationFile.Add(string,System.Nullable_int_).value'></a>

`value` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The value to set, or null to remove the setting\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the operation was successful; otherwise, false\.

<a name='DiGi.Core.Classes.ConfigurationFile.Append(DiGi.Core.Classes.ConfigurationFile)'></a>

## ConfigurationFile\.Append\(ConfigurationFile\) Method

Appends settings from another configuration file instance to this one\.

```csharp
public bool Append(DiGi.Core.Classes.ConfigurationFile? configurationFile);
```
#### Parameters

<a name='DiGi.Core.Classes.ConfigurationFile.Append(DiGi.Core.Classes.ConfigurationFile).configurationFile'></a>

`configurationFile` [ConfigurationFile](DiGi.Core.Classes.md#DiGi.Core.Classes.ConfigurationFile 'DiGi\.Core\.Classes\.ConfigurationFile')

The source configuration file\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if any settings were appended; otherwise, false\.

<a name='DiGi.Core.Classes.ConfigurationFile.Contains(string,bool)'></a>

## ConfigurationFile\.Contains\(string, bool\) Method

Checks if a configuration setting exists by its name\.

```csharp
public bool Contains(string? name, bool caseSensitive=false);
```
#### Parameters

<a name='DiGi.Core.Classes.ConfigurationFile.Contains(string,bool).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The key to look for\.

<a name='DiGi.Core.Classes.ConfigurationFile.Contains(string,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether the search should be case\-sensitive\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the key exists; otherwise, false\.

<a name='DiGi.Core.Classes.ConfigurationFile.GetValue(string,bool)'></a>

## ConfigurationFile\.GetValue\(string, bool\) Method

Retrieves a configuration value as an object\.

```csharp
public object? GetValue(string name, bool caseSensitive=false);
```
#### Parameters

<a name='DiGi.Core.Classes.ConfigurationFile.GetValue(string,bool).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The key of the setting\.

<a name='DiGi.Core.Classes.ConfigurationFile.GetValue(string,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether the search should be case\-sensitive\.

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')  
The retrieved value, or null if not found\.

<a name='DiGi.Core.Classes.ConfigurationFile.GetValue_T_(string,bool)'></a>

## ConfigurationFile\.GetValue\<T\>\(string, bool\) Method

Retrieves a configuration value and attempts to cast it to type T\.

```csharp
public T? GetValue<T>(string name, bool caseSensitive=false);
```
#### Type parameters

<a name='DiGi.Core.Classes.ConfigurationFile.GetValue_T_(string,bool).T'></a>

`T`

The target type\.
#### Parameters

<a name='DiGi.Core.Classes.ConfigurationFile.GetValue_T_(string,bool).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The key of the setting\.

<a name='DiGi.Core.Classes.ConfigurationFile.GetValue_T_(string,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether the search should be case\-sensitive\.

#### Returns
[T](DiGi.Core.Classes.md#DiGi.Core.Classes.ConfigurationFile.GetValue_T_(string,bool).T 'DiGi\.Core\.Classes\.ConfigurationFile\.GetValue\<T\>\(string, bool\)\.T')  
The value cast to T, or default if not found or conversion fails\.

<a name='DiGi.Core.Classes.ConfigurationFile.GetValue_T_(string,T,bool)'></a>

## ConfigurationFile\.GetValue\<T\>\(string, T, bool\) Method

Retrieves a configuration value and attempts to cast it to type T, or returns a default value\.

```csharp
public T? GetValue<T>(string name, T? defaultValue, bool caseSensitive=false);
```
#### Type parameters

<a name='DiGi.Core.Classes.ConfigurationFile.GetValue_T_(string,T,bool).T'></a>

`T`

The target type\.
#### Parameters

<a name='DiGi.Core.Classes.ConfigurationFile.GetValue_T_(string,T,bool).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The key of the setting\.

<a name='DiGi.Core.Classes.ConfigurationFile.GetValue_T_(string,T,bool).defaultValue'></a>

`defaultValue` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.ConfigurationFile.GetValue_T_(string,T,bool).T 'DiGi\.Core\.Classes\.ConfigurationFile\.GetValue\<T\>\(string, T, bool\)\.T')

The value to return if not found or conversion fails\.

<a name='DiGi.Core.Classes.ConfigurationFile.GetValue_T_(string,T,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether the search should be case\-sensitive\.

#### Returns
[T](DiGi.Core.Classes.md#DiGi.Core.Classes.ConfigurationFile.GetValue_T_(string,T,bool).T 'DiGi\.Core\.Classes\.ConfigurationFile\.GetValue\<T\>\(string, T, bool\)\.T')  
The retrieved value cast to T, or the defaultValue\.

<a name='DiGi.Core.Classes.ConfigurationFile.Read(string)'></a>

## ConfigurationFile\.Read\(string\) Method

Reads configuration settings from a file at the specified path\.

```csharp
public bool Read(string path);
```
#### Parameters

<a name='DiGi.Core.Classes.ConfigurationFile.Read(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The absolute or relative path to the configuration file\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the file was read successfully; otherwise, false\.

<a name='DiGi.Core.Classes.ConfigurationFile.Read(string[])'></a>

## ConfigurationFile\.Read\(string\[\]\) Method

Reads configuration settings from an array of strings \(lines\)\.

```csharp
public bool Read(string[]? lines);
```
#### Parameters

<a name='DiGi.Core.Classes.ConfigurationFile.Read(string[]).lines'></a>

`lines` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The lines to parse as key\-value pairs\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if at least one setting was read successfully; otherwise, false\.

<a name='DiGi.Core.Classes.ConfigurationFile.Remove(string)'></a>

## ConfigurationFile\.Remove\(string\) Method

Removes a configuration setting by its name\.

```csharp
public bool Remove(string name);
```
#### Parameters

<a name='DiGi.Core.Classes.ConfigurationFile.Remove(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The key of the setting to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the setting was removed; otherwise, false\.

<a name='DiGi.Core.Classes.ConfigurationFile.TryGetValue_T_(string,T,bool)'></a>

## ConfigurationFile\.TryGetValue\<T\>\(string, T, bool\) Method

Attempts to retrieve a configuration value and convert it to type T\.

```csharp
public bool TryGetValue<T>(string name, out T? value, bool caseSensitive=false);
```
#### Type parameters

<a name='DiGi.Core.Classes.ConfigurationFile.TryGetValue_T_(string,T,bool).T'></a>

`T`

The target type\.
#### Parameters

<a name='DiGi.Core.Classes.ConfigurationFile.TryGetValue_T_(string,T,bool).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The key of the setting\.

<a name='DiGi.Core.Classes.ConfigurationFile.TryGetValue_T_(string,T,bool).value'></a>

`value` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.ConfigurationFile.TryGetValue_T_(string,T,bool).T 'DiGi\.Core\.Classes\.ConfigurationFile\.TryGetValue\<T\>\(string, T, bool\)\.T')

The converted value, if successful\.

<a name='DiGi.Core.Classes.ConfigurationFile.TryGetValue_T_(string,T,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether the search should be case\-sensitive\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was found and successfully converted; otherwise, false\.

<a name='DiGi.Core.Classes.ConfigurationFile.Write(string)'></a>

## ConfigurationFile\.Write\(string\) Method

Writes the current configuration settings to a file at the specified path\.

```csharp
public bool Write(string path);
```
#### Parameters

<a name='DiGi.Core.Classes.ConfigurationFile.Write(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path where the configuration file should be written\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the file was written successfully; otherwise, false\.

<a name='DiGi.Core.Classes.ConversionManager'></a>

## ConversionManager Class

Caches and retrieves reflection data \(MethodInfo\) for type conversion methods\.

```csharp
public class ConversionManager
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → ConversionManager
### Constructors

<a name='DiGi.Core.Classes.ConversionManager.ConversionManager()'></a>

## ConversionManager\(\) Constructor

Initializes a new instance of the [ConversionManager](DiGi.Core.Classes.md#DiGi.Core.Classes.ConversionManager 'DiGi\.Core\.Classes\.ConversionManager') class\.

```csharp
public ConversionManager();
```
### Methods

<a name='DiGi.Core.Classes.ConversionManager.GetMethodInfo(string,bool)'></a>

## ConversionManager\.GetMethodInfo\(string, bool\) Method

Retrieves the [System\.Reflection\.MethodInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.methodinfo 'System\.Reflection\.MethodInfo') for the specified full type name\.

```csharp
public System.Reflection.MethodInfo? GetMethodInfo(string? fullTypeName, bool update=true);
```
#### Parameters

<a name='DiGi.Core.Classes.ConversionManager.GetMethodInfo(string,bool).fullTypeName'></a>

`fullTypeName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The full name of the type to get the method info for\.

<a name='DiGi.Core.Classes.ConversionManager.GetMethodInfo(string,bool).update'></a>

`update` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, updates the internal cache if the method info is not found\.

#### Returns
[System\.Reflection\.MethodInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.methodinfo 'System\.Reflection\.MethodInfo')  
The [System\.Reflection\.MethodInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.methodinfo 'System\.Reflection\.MethodInfo') if found; otherwise, `null`\.

<a name='DiGi.Core.Classes.ConversionManager.GetMethodInfo(System.Type,bool)'></a>

## ConversionManager\.GetMethodInfo\(Type, bool\) Method

Retrieves the [System\.Reflection\.MethodInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.methodinfo 'System\.Reflection\.MethodInfo') for the specified type\.

```csharp
public System.Reflection.MethodInfo? GetMethodInfo(System.Type? type, bool update=true);
```
#### Parameters

<a name='DiGi.Core.Classes.ConversionManager.GetMethodInfo(System.Type,bool).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to get the method info for\.

<a name='DiGi.Core.Classes.ConversionManager.GetMethodInfo(System.Type,bool).update'></a>

`update` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, updates the internal cache if the method info is not found\.

#### Returns
[System\.Reflection\.MethodInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.methodinfo 'System\.Reflection\.MethodInfo')  
The [System\.Reflection\.MethodInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.methodinfo 'System\.Reflection\.MethodInfo') if found; otherwise, `null`\.

<a name='DiGi.Core.Classes.ConvertOptions'></a>

## ConvertOptions Class

An abstract base class for defining options used during data conversion processes\.

```csharp
public abstract class ConvertOptions : DiGi.Core.Classes.SerializableOptions, DiGi.Core.Interfaces.IConvertOptions, DiGi.Core.Interfaces.IOptions, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableOptions](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableOptions 'DiGi\.Core\.Classes\.SerializableOptions') → ConvertOptions

Implements [DiGi\.Core\.Interfaces\.IConvertOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iconvertoptions 'DiGi\.Core\.Interfaces\.IConvertOptions'), [IOptions](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IOptions 'DiGi\.Core\.Interfaces\.IOptions'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Classes.ConvertOptions.ConvertOptions()'></a>

## ConvertOptions\(\) Constructor

Initializes a new instance of the ConvertOptions class\.

```csharp
public ConvertOptions();
```

<a name='DiGi.Core.Classes.ConvertOptions.ConvertOptions(DiGi.Core.Classes.ConvertOptions)'></a>

## ConvertOptions\(ConvertOptions\) Constructor

Initializes a new instance of the ConvertOptions class by copying another ConvertOptions object\.

```csharp
public ConvertOptions(DiGi.Core.Classes.ConvertOptions? convertOptions);
```
#### Parameters

<a name='DiGi.Core.Classes.ConvertOptions.ConvertOptions(DiGi.Core.Classes.ConvertOptions).convertOptions'></a>

`convertOptions` [ConvertOptions](DiGi.Core.Classes.md#DiGi.Core.Classes.ConvertOptions 'DiGi\.Core\.Classes\.ConvertOptions')

The source options to copy from\.

<a name='DiGi.Core.Classes.ConvertOptions.ConvertOptions(System.Text.Json.Nodes.JsonObject)'></a>

## ConvertOptions\(JsonObject\) Constructor

Initializes a new instance of the ConvertOptions class from a JsonObject\.

```csharp
public ConvertOptions(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.ConvertOptions.ConvertOptions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing conversion options\.

<a name='DiGi.Core.Classes.Coordinates'></a>

## Coordinates Class

Represents a geographic location using Latitude and Longitude\.

```csharp
public class Coordinates : DiGi.Core.Classes.SerializableObject, DiGi.Core.Interfaces.ICoordinates, DiGi.Core.Interfaces.ILocation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → Coordinates

Implements [ICoordinates](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICoordinates 'DiGi\.Core\.Interfaces\.ICoordinates'), [ILocation](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ILocation 'DiGi\.Core\.Interfaces\.ILocation'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Classes.Coordinates.Coordinates(DiGi.Core.Classes.Coordinates)'></a>

## Coordinates\(Coordinates\) Constructor

Initializes a new instance of the Coordinates class by copying another Coordinates object\.

```csharp
public Coordinates(DiGi.Core.Classes.Coordinates? coordinates);
```
#### Parameters

<a name='DiGi.Core.Classes.Coordinates.Coordinates(DiGi.Core.Classes.Coordinates).coordinates'></a>

`coordinates` [Coordinates](DiGi.Core.Classes.md#DiGi.Core.Classes.Coordinates 'DiGi\.Core\.Classes\.Coordinates')

The source coordinates to copy from\.

<a name='DiGi.Core.Classes.Coordinates.Coordinates(double,double)'></a>

## Coordinates\(double, double\) Constructor

Initializes a new instance of the Coordinates class with specified latitude and longitude\.

```csharp
public Coordinates(double latitude, double longitude);
```
#### Parameters

<a name='DiGi.Core.Classes.Coordinates.Coordinates(double,double).latitude'></a>

`latitude` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The geographic latitude\.

<a name='DiGi.Core.Classes.Coordinates.Coordinates(double,double).longitude'></a>

`longitude` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The geographic longitude\.

<a name='DiGi.Core.Classes.Coordinates.Coordinates(System.Text.Json.Nodes.JsonObject)'></a>

## Coordinates\(JsonObject\) Constructor

Initializes a new instance of the Coordinates class from a JsonObject\.

```csharp
public Coordinates(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.Coordinates.Coordinates(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing coordinate data\.
### Properties

<a name='DiGi.Core.Classes.Coordinates.Latitude'></a>

## Coordinates\.Latitude Property

Gets the geographic latitude of the location\.

```csharp
public double Latitude { get; }
```

Implements [Latitude](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICoordinates.Latitude 'DiGi\.Core\.Interfaces\.ICoordinates\.Latitude')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Classes.Coordinates.Longitude'></a>

## Coordinates\.Longitude Property

Gets the geographic longitude of the location\.

```csharp
public double Longitude { get; }
```

Implements [Longitude](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICoordinates.Longitude 'DiGi\.Core\.Interfaces\.ICoordinates\.Longitude')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Classes.DateTimeCollection'></a>

## DateTimeCollection Class

Represents a collection of [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') objects\.

```csharp
public class DateTimeCollection : DiGi.Core.Classes.SerializableObject, DiGi.Core.Interfaces.ITimeSeries, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, System.Collections.Generic.ICollection<System.DateTime>, System.Collections.Generic.IEnumerable<System.DateTime>, System.Collections.IEnumerable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → DateTimeCollection

Implements [ITimeSeries](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITimeSeries 'DiGi\.Core\.Interfaces\.ITimeSeries'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.Collections\.Generic\.ICollection&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1'), [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')
### Constructors

<a name='DiGi.Core.Classes.DateTimeCollection.DateTimeCollection()'></a>

## DateTimeCollection\(\) Constructor

Initializes a new instance of the [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection') class\.

```csharp
public DateTimeCollection();
```

<a name='DiGi.Core.Classes.DateTimeCollection.DateTimeCollection(DiGi.Core.Classes.DateTimeCollection)'></a>

## DateTimeCollection\(DateTimeCollection\) Constructor

Initializes a new instance of the [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection') class by copying another collection\.

```csharp
public DateTimeCollection(DiGi.Core.Classes.DateTimeCollection? dateTimeCollection);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeCollection.DateTimeCollection(DiGi.Core.Classes.DateTimeCollection).dateTimeCollection'></a>

`dateTimeCollection` [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection')

The DateTimeCollection to copy from\.

<a name='DiGi.Core.Classes.DateTimeCollection.DateTimeCollection(System.Collections.Generic.IEnumerable_System.DateTime_)'></a>

## DateTimeCollection\(IEnumerable\<DateTime\>\) Constructor

Initializes a new instance of the [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection') class with the specified collection of DateTimes\.

```csharp
public DateTimeCollection(System.Collections.Generic.IEnumerable<System.DateTime>? dateTimes);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeCollection.DateTimeCollection(System.Collections.Generic.IEnumerable_System.DateTime_).dateTimes'></a>

`dateTimes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of date times to initialize the collection with\.

<a name='DiGi.Core.Classes.DateTimeCollection.DateTimeCollection(System.Text.Json.Nodes.JsonObject)'></a>

## DateTimeCollection\(JsonObject\) Constructor

Initializes a new instance of the [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection') class from a JSON object\.

```csharp
public DateTimeCollection(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeCollection.DateTimeCollection(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the collection from\.
### Properties

<a name='DiGi.Core.Classes.DateTimeCollection.Count'></a>

## DateTimeCollection\.Count Property

Gets the number of elements contained in the collection\.

```csharp
public int Count { get; }
```

Implements [Count](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1.count 'System\.Collections\.Generic\.ICollection\`1\.Count')

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.Classes.DateTimeCollection.DateTimes'></a>

## DateTimeCollection\.DateTimes Property

Gets the list of DateTimes in the collection\.

```csharp
public System.Collections.Generic.IList<System.DateTime> DateTimes { get; }
```

#### Property Value
[System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

<a name='DiGi.Core.Classes.DateTimeCollection.IsReadOnly'></a>

## DateTimeCollection\.IsReadOnly Property

Gets a value indicating whether the collection is read\-only\.

```csharp
public bool IsReadOnly { get; }
```

Implements [IsReadOnly](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1.isreadonly 'System\.Collections\.Generic\.ICollection\`1\.IsReadOnly')

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')
### Methods

<a name='DiGi.Core.Classes.DateTimeCollection.Add(System.DateTime)'></a>

## DateTimeCollection\.Add\(DateTime\) Method

Adds the specified DateTime to the collection\.

```csharp
public void Add(System.DateTime dateTime);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeCollection.Add(System.DateTime).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The DateTime to add to the collection\.

<a name='DiGi.Core.Classes.DateTimeCollection.Add(System.Nullable_System.DateTime_)'></a>

## DateTimeCollection\.Add\(Nullable\<DateTime\>\) Method

Adds the specified nullable DateTime to the collection\.

```csharp
public void Add(System.Nullable<System.DateTime> dateTime);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeCollection.Add(System.Nullable_System.DateTime_).dateTime'></a>

`dateTime` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The nullable DateTime to add to the collection\.

<a name='DiGi.Core.Classes.DateTimeCollection.Clear()'></a>

## DateTimeCollection\.Clear\(\) Method

Removes all elements from the collection\.

```csharp
public void Clear();
```

Implements [Clear\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1.clear 'System\.Collections\.Generic\.ICollection\`1\.Clear')

<a name='DiGi.Core.Classes.DateTimeCollection.Contains(System.DateTime)'></a>

## DateTimeCollection\.Contains\(DateTime\) Method

Determines whether the collection contains a specific DateTime\.

```csharp
public bool Contains(System.DateTime dateTime);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeCollection.Contains(System.DateTime).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The DateTime to locate in the collection\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
true if the collection contains the specified DateTime; otherwise, false\.

<a name='DiGi.Core.Classes.DateTimeCollection.Contains(System.Nullable_System.DateTime_)'></a>

## DateTimeCollection\.Contains\(Nullable\<DateTime\>\) Method

Determines whether the collection contains a specific nullable DateTime\.

```csharp
public bool Contains(System.Nullable<System.DateTime> dateTime);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeCollection.Contains(System.Nullable_System.DateTime_).dateTime'></a>

`dateTime` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The nullable DateTime to locate in the collection\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
true if the collection contains the specified nullable DateTime; otherwise, false\.

<a name='DiGi.Core.Classes.DateTimeCollection.CopyTo(System.DateTime[],int)'></a>

## DateTimeCollection\.CopyTo\(DateTime\[\], int\) Method

Copies the elements of the collection to a specified array, starting at the specified index\.

```csharp
public void CopyTo(System.DateTime[]? array, int arrayIndex);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeCollection.CopyTo(System.DateTime[],int).array'></a>

`array` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The destination array to which the elements are copied\.

<a name='DiGi.Core.Classes.DateTimeCollection.CopyTo(System.DateTime[],int).arrayIndex'></a>

`arrayIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index in the destination array at which the elements should be copied to\.

<a name='DiGi.Core.Classes.DateTimeCollection.GetDateTimes()'></a>

## DateTimeCollection\.GetDateTimes\(\) Method

Generates and returns an array of DateTimes within the series\.

```csharp
public System.DateTime[]? GetDateTimes();
```

Implements [GetDateTimes\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITimeSeries.GetDateTimes() 'DiGi\.Core\.Interfaces\.ITimeSeries\.GetDateTimes\(\)')

#### Returns
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of DateTime objects containing the series, or null if no date times are available\.

<a name='DiGi.Core.Classes.DateTimeCollection.GetEnumerator()'></a>

## DateTimeCollection\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the collection\.

```csharp
public System.Collections.Generic.IEnumerator<System.DateTime> GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator 'System\.Collections\.Generic\.IEnumerable\`1\.GetEnumerator'), [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

#### Returns
[System\.Collections\.Generic\.IEnumerator&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')  
An IEnumerator\<DateTime\> that iterates through the collection\.

<a name='DiGi.Core.Classes.DateTimeCollection.Remove(System.DateTime)'></a>

## DateTimeCollection\.Remove\(DateTime\) Method

Removes the first occurrence of a specific DateTime from the collection\.

```csharp
public bool Remove(System.DateTime dateTime);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeCollection.Remove(System.DateTime).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The DateTime to remove from the collection\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the item was successfully removed; otherwise, false\.

<a name='DiGi.Core.Classes.DateTimeCollection.Remove(System.Nullable_System.DateTime_)'></a>

## DateTimeCollection\.Remove\(Nullable\<DateTime\>\) Method

Removes the first occurrence of a specific nullable DateTime from the collection\.

```csharp
public bool Remove(System.Nullable<System.DateTime> dateTime);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeCollection.Remove(System.Nullable_System.DateTime_).dateTime'></a>

`dateTime` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The nullable DateTime to remove from the collection\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the item was successfully removed; otherwise, false\.
### Operators

<a name='DiGi.Core.Classes.DateTimeCollection.op_ImplicitDiGi.Core.Classes.DateTimeCollection(System.Collections.Generic.List_System.DateTime_)'></a>

## DateTimeCollection\.implicit operator DateTimeCollection\(List\<DateTime\>\) Operator

Implicitly converts a nullable list of [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') objects to a nullable [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection')\.

```csharp
public static DiGi.Core.Classes.DateTimeCollection? implicit operator DiGi.Core.Classes.DateTimeCollection?(System.Collections.Generic.List<System.DateTime>? dateTimes);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeCollection.op_ImplicitDiGi.Core.Classes.DateTimeCollection(System.Collections.Generic.List_System.DateTime_).dateTimes'></a>

`dateTimes` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The nullable list of [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') values to convert\.

#### Returns
[DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection')  
A new [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection') containing the elements from the list, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is null\.

<a name='DiGi.Core.Classes.DateTimeCollection.op_ImplicitDiGi.Core.Classes.DateTimeCollection(System.DateTime[])'></a>

## DateTimeCollection\.implicit operator DateTimeCollection\(DateTime\[\]\) Operator

Implicitly converts a nullable array of [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') objects to a nullable [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection')\.

```csharp
public static DiGi.Core.Classes.DateTimeCollection? implicit operator DiGi.Core.Classes.DateTimeCollection?(System.DateTime[]? dateTimes);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeCollection.op_ImplicitDiGi.Core.Classes.DateTimeCollection(System.DateTime[]).dateTimes'></a>

`dateTimes` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The nullable array of [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') values to convert\.

#### Returns
[DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection')  
A new [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection') containing the elements from the array, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is null\.

<a name='DiGi.Core.Classes.DateTimeCollection.op_ImplicitDiGi.Core.Classes.DateTimeCollection(System.Nullable_System.DateTime_)'></a>

## DateTimeCollection\.implicit operator DateTimeCollection\(Nullable\<DateTime\>\) Operator

Implicitly converts a nullable [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') to a nullable [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection')\.

```csharp
public static DiGi.Core.Classes.DateTimeCollection? implicit operator DiGi.Core.Classes.DateTimeCollection?(System.Nullable<System.DateTime> dateTime);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeCollection.op_ImplicitDiGi.Core.Classes.DateTimeCollection(System.Nullable_System.DateTime_).dateTime'></a>

`dateTime` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The nullable [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') value to convert\.

#### Returns
[DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection')  
A new [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection') containing the specified date time, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is null\.

<a name='DiGi.Core.Classes.DateTimeCollection.op_ImplicitSystem.Collections.Generic.List_System.DateTime_(DiGi.Core.Classes.DateTimeCollection)'></a>

## DateTimeCollection\.implicit operator List\<DateTime\>\(DateTimeCollection\) Operator

Implicitly converts a [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection') to a nullable list of [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')\.

```csharp
public static System.Collections.Generic.List<System.DateTime>? implicit operator System.Collections.Generic.List<System.DateTime>?(DiGi.Core.Classes.DateTimeCollection? dateTimeCollection);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeCollection.op_ImplicitSystem.Collections.Generic.List_System.DateTime_(DiGi.Core.Classes.DateTimeCollection).dateTimeCollection'></a>

`dateTimeCollection` [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection')

The [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection') instance to convert\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the date times from the collection, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the source is null\.

<a name='DiGi.Core.Classes.DateTimeCollection.op_ImplicitSystem.DateTime[](DiGi.Core.Classes.DateTimeCollection)'></a>

## DateTimeCollection\.implicit operator DateTime\[\]\(DateTimeCollection\) Operator

Implicitly converts a nullable [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection') to a nullable array of [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') objects\.

```csharp
public static System.DateTime[]? implicit operator System.DateTime[]?(DiGi.Core.Classes.DateTimeCollection? dateTimeCollection);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeCollection.op_ImplicitSystem.DateTime[](DiGi.Core.Classes.DateTimeCollection).dateTimeCollection'></a>

`dateTimeCollection` [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection')

The nullable [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection') to convert\.

#### Returns
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
A nullable array of [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') values containing the elements from the collection, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is null\.

<a name='DiGi.Core.Classes.DateTimeRange'></a>

## DateTimeRange Class

Represents a range of date and time values\.

```csharp
public class DateTimeRange : DiGi.Core.Classes.Range<System.DateTime>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>') → DateTimeRange
### Constructors

<a name='DiGi.Core.Classes.DateTimeRange.DateTimeRange(DiGi.Core.Classes.DateTimeRange)'></a>

## DateTimeRange\(DateTimeRange\) Constructor

Initializes a new instance of the [DateTimeRange](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeRange 'DiGi\.Core\.Classes\.DateTimeRange') class by copying an existing range\.

```csharp
public DateTimeRange(DiGi.Core.Classes.DateTimeRange dateTimeRange);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeRange.DateTimeRange(DiGi.Core.Classes.DateTimeRange).dateTimeRange'></a>

`dateTimeRange` [DateTimeRange](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeRange 'DiGi\.Core\.Classes\.DateTimeRange')

The date time range to copy from\.

<a name='DiGi.Core.Classes.DateTimeRange.DateTimeRange(System.DateTime,System.DateTime)'></a>

## DateTimeRange\(DateTime, DateTime\) Constructor

Initializes a new instance of the [DateTimeRange](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeRange 'DiGi\.Core\.Classes\.DateTimeRange') class with specified start and end dates\.

```csharp
public DateTimeRange(System.DateTime value_1, System.DateTime value_2);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeRange.DateTimeRange(System.DateTime,System.DateTime).value_1'></a>

`value_1` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The first date time value\.

<a name='DiGi.Core.Classes.DateTimeRange.DateTimeRange(System.DateTime,System.DateTime).value_2'></a>

`value_2` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The second date time value\.

<a name='DiGi.Core.Classes.DateTimeRange.DateTimeRange(System.Text.Json.Nodes.JsonObject)'></a>

## DateTimeRange\(JsonObject\) Constructor

Initializes a new instance of the [DateTimeRange](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeRange 'DiGi\.Core\.Classes\.DateTimeRange') class from a JSON object\.

```csharp
public DateTimeRange(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeRange.DateTimeRange(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the range from\.
### Properties

<a name='DiGi.Core.Classes.DateTimeRange.Length'></a>

## DateTimeRange\.Length Property

Gets the duration or length of the date time range\.

```csharp
public override System.DateTime Length { get; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.Core.Classes.DateTimeSeries'></a>

## DateTimeSeries Class

Represents a series of DateTimes generated based on a range and step interval\.

```csharp
public class DateTimeSeries : DiGi.Core.Classes.SerializableObject, DiGi.Core.Interfaces.ITimeSeries, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → DateTimeSeries

Implements [ITimeSeries](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITimeSeries 'DiGi\.Core\.Interfaces\.ITimeSeries'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Classes.DateTimeSeries.DateTimeSeries(DiGi.Core.Classes.DateTimeRange,long)'></a>

## DateTimeSeries\(DateTimeRange, long\) Constructor

Initializes a new instance of the [DateTimeSeries](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeSeries 'DiGi\.Core\.Classes\.DateTimeSeries') class with a specified range and step\.

```csharp
public DateTimeSeries(DiGi.Core.Classes.DateTimeRange? range, long step);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeSeries.DateTimeSeries(DiGi.Core.Classes.DateTimeRange,long).range'></a>

`range` [DateTimeRange](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeRange 'DiGi\.Core\.Classes\.DateTimeRange')

The date time range for the series\.

<a name='DiGi.Core.Classes.DateTimeSeries.DateTimeSeries(DiGi.Core.Classes.DateTimeRange,long).step'></a>

`step` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The step interval between dates in the series\.

<a name='DiGi.Core.Classes.DateTimeSeries.DateTimeSeries(DiGi.Core.Classes.DateTimeSeries)'></a>

## DateTimeSeries\(DateTimeSeries\) Constructor

Initializes a new instance of the [DateTimeSeries](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeSeries 'DiGi\.Core\.Classes\.DateTimeSeries') class by copying another series\.

```csharp
public DateTimeSeries(DiGi.Core.Classes.DateTimeSeries? dateTimeSeries);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeSeries.DateTimeSeries(DiGi.Core.Classes.DateTimeSeries).dateTimeSeries'></a>

`dateTimeSeries` [DateTimeSeries](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeSeries 'DiGi\.Core\.Classes\.DateTimeSeries')

The source [DateTimeSeries](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeSeries 'DiGi\.Core\.Classes\.DateTimeSeries') to copy from\.

<a name='DiGi.Core.Classes.DateTimeSeries.DateTimeSeries(System.DateTime)'></a>

## DateTimeSeries\(DateTime\) Constructor

Initializes a new instance of the [DateTimeSeries](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeSeries 'DiGi\.Core\.Classes\.DateTimeSeries') class starting at the specified date\.

```csharp
public DateTimeSeries(System.DateTime dateTime);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeSeries.DateTimeSeries(System.DateTime).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The start date and time for the series\.

<a name='DiGi.Core.Classes.DateTimeSeries.DateTimeSeries(System.DateTime,System.DateTime,long)'></a>

## DateTimeSeries\(DateTime, DateTime, long\) Constructor

Initializes a new instance of the [DateTimeSeries](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeSeries 'DiGi\.Core\.Classes\.DateTimeSeries') class with start date, end date, and step\.

```csharp
public DateTimeSeries(System.DateTime dateTime_1, System.DateTime dateTime_2, long step);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeSeries.DateTimeSeries(System.DateTime,System.DateTime,long).dateTime_1'></a>

`dateTime_1` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The starting date and time of the series\.

<a name='DiGi.Core.Classes.DateTimeSeries.DateTimeSeries(System.DateTime,System.DateTime,long).dateTime_2'></a>

`dateTime_2` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The ending date and time of the series\.

<a name='DiGi.Core.Classes.DateTimeSeries.DateTimeSeries(System.DateTime,System.DateTime,long).step'></a>

`step` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The step interval for the series\.

<a name='DiGi.Core.Classes.DateTimeSeries.DateTimeSeries(System.Text.Json.Nodes.JsonObject)'></a>

## DateTimeSeries\(JsonObject\) Constructor

Initializes a new instance of the [DateTimeSeries](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeSeries 'DiGi\.Core\.Classes\.DateTimeSeries') class from a JSON object\.

```csharp
public DateTimeSeries(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.DateTimeSeries.DateTimeSeries(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the series\.
### Properties

<a name='DiGi.Core.Classes.DateTimeSeries.Range'></a>

## DateTimeSeries\.Range Property

Gets or sets the date range for the series\.

```csharp
public DiGi.Core.Classes.DateTimeRange? Range { get; }
```

#### Property Value
[DateTimeRange](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeRange 'DiGi\.Core\.Classes\.DateTimeRange')

<a name='DiGi.Core.Classes.DateTimeSeries.Step'></a>

## DateTimeSeries\.Step Property

Gets or sets the step interval for the series\.

```csharp
public long Step { get; }
```

#### Property Value
[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')
### Methods

<a name='DiGi.Core.Classes.DateTimeSeries.GetDateTimes()'></a>

## DateTimeSeries\.GetDateTimes\(\) Method

Generates and returns an array of DateTimes within the series\.

```csharp
public System.DateTime[]? GetDateTimes();
```

Implements [GetDateTimes\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITimeSeries.GetDateTimes() 'DiGi\.Core\.Interfaces\.ITimeSeries\.GetDateTimes\(\)')

#### Returns
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') objects representing the series, or null\.

<a name='DiGi.Core.Classes.DescriptionEnumConverter'></a>

## DescriptionEnumConverter Class

Type converter for enum types that resolves a string by member name, numeric value, or the text of the member's [System\.ComponentModel\.DescriptionAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.descriptionattribute 'System\.ComponentModel\.DescriptionAttribute')\.

Attach it with `[TypeConverter(typeof(DescriptionEnumConverter))]` on the enum. ASP.NET Core binds query, route and form values through [System\.ComponentModel\.TypeDescriptor](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.typedescriptor 'System\.ComponentModel\.TypeDescriptor'), so the attribute makes the description an accepted input token wherever the enum is bound - without renaming the member, and without changing how the value is written (enums still travel as their underlying integer). Anything the description matching does not resolve is handed to [System\.ComponentModel\.EnumConverter](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.enumconverter 'System\.ComponentModel\.EnumConverter') and behaves exactly as before.

Matching is delegated to [TryGetEnum\(this string, Type, Enum\)](DiGi.Core.md#DiGi.Core.Query.TryGetEnum(thisstring,System.Type,System.Enum) 'DiGi\.Core\.Query\.TryGetEnum\(this string, System\.Type, System\.Enum\)'), the same matcher DiGi JSON deserialization uses.

```csharp
public class DescriptionEnumConverter : System.ComponentModel.EnumConverter
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.ComponentModel\.TypeConverter](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.typeconverter 'System\.ComponentModel\.TypeConverter') → [System\.ComponentModel\.EnumConverter](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.enumconverter 'System\.ComponentModel\.EnumConverter') → DescriptionEnumConverter
### Constructors

<a name='DiGi.Core.Classes.DescriptionEnumConverter.DescriptionEnumConverter(System.Type)'></a>

## DescriptionEnumConverter\(Type\) Constructor

Initializes a new instance of the DescriptionEnumConverter class for the specified enum type\.

```csharp
public DescriptionEnumConverter(System.Type type);
```
#### Parameters

<a name='DiGi.Core.Classes.DescriptionEnumConverter.DescriptionEnumConverter(System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The enum type this converter is attached to\. [System\.ComponentModel\.TypeDescriptor](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.typedescriptor 'System\.ComponentModel\.TypeDescriptor') supplies it when the converter is created from a [System\.ComponentModel\.TypeConverterAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.typeconverterattribute 'System\.ComponentModel\.TypeConverterAttribute')\.
### Methods

<a name='DiGi.Core.Classes.DescriptionEnumConverter.ConvertFrom(System.ComponentModel.ITypeDescriptorContext,System.Globalization.CultureInfo,object)'></a>

## DescriptionEnumConverter\.ConvertFrom\(ITypeDescriptorContext, CultureInfo, object\) Method

Converts the given value to an enum member of the converter's type\.

```csharp
public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
```
#### Parameters

<a name='DiGi.Core.Classes.DescriptionEnumConverter.ConvertFrom(System.ComponentModel.ITypeDescriptorContext,System.Globalization.CultureInfo,object).context'></a>

`context` [System\.ComponentModel\.ITypeDescriptorContext](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.itypedescriptorcontext 'System\.ComponentModel\.ITypeDescriptorContext')

The format context\.

<a name='DiGi.Core.Classes.DescriptionEnumConverter.ConvertFrom(System.ComponentModel.ITypeDescriptorContext,System.Globalization.CultureInfo,object).culture'></a>

`culture` [System\.Globalization\.CultureInfo](https://learn.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo 'System\.Globalization\.CultureInfo')

The culture used for the conversion\.

<a name='DiGi.Core.Classes.DescriptionEnumConverter.ConvertFrom(System.ComponentModel.ITypeDescriptorContext,System.Globalization.CultureInfo,object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to convert\.

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')  
The enum member the value resolves to\.

<a name='DiGi.Core.Classes.ExternalReference'></a>

## ExternalReference Class

Base class for references to external resources\.

```csharp
public abstract class ExternalReference : DiGi.Core.Classes.SerializableReference, DiGi.Core.Interfaces.IExternalReference, DiGi.Core.Interfaces.IReference, DiGi.Core.Interfaces.IObject, System.IEquatable<DiGi.Core.Interfaces.IReference>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') → ExternalReference

Derived  
↳ [ExternalReference&lt;USerializableReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference_USerializableReference_ 'DiGi\.Core\.Classes\.ExternalReference\<USerializableReference\>')

Implements [IExternalReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IExternalReference 'DiGi\.Core\.Interfaces\.IExternalReference'), [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')
### Constructors

<a name='DiGi.Core.Classes.ExternalReference.ExternalReference(DiGi.Core.Classes.ExternalReference)'></a>

## ExternalReference\(ExternalReference\) Constructor

Initializes a new instance of the [ExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference 'DiGi\.Core\.Classes\.ExternalReference') class by copying an existing reference\.

```csharp
public ExternalReference(DiGi.Core.Classes.ExternalReference? externalReference);
```
#### Parameters

<a name='DiGi.Core.Classes.ExternalReference.ExternalReference(DiGi.Core.Classes.ExternalReference).externalReference'></a>

`externalReference` [ExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference 'DiGi\.Core\.Classes\.ExternalReference')

The external reference to copy\.

<a name='DiGi.Core.Classes.ExternalReference.ExternalReference(string)'></a>

## ExternalReference\(string\) Constructor

Initializes a new instance of the [ExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference 'DiGi\.Core\.Classes\.ExternalReference') class with a specified source\.

```csharp
public ExternalReference(string? source);
```
#### Parameters

<a name='DiGi.Core.Classes.ExternalReference.ExternalReference(string).source'></a>

`source` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The source string for the external reference\.

<a name='DiGi.Core.Classes.ExternalReference.ExternalReference(System.Text.Json.Nodes.JsonObject)'></a>

## ExternalReference\(JsonObject\) Constructor

Initializes a new instance of the [ExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference 'DiGi\.Core\.Classes\.ExternalReference') class from a JSON object\.

```csharp
public ExternalReference(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.ExternalReference.ExternalReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the reference\.
### Properties

<a name='DiGi.Core.Classes.ExternalReference.Source'></a>

## ExternalReference\.Source Property

Gets or sets the source identifier for the external reference\.

```csharp
public string Source { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.ExternalReference_USerializableReference_'></a>

## ExternalReference\<USerializableReference\> Class

Base class for references to external resources\.

```csharp
public abstract class ExternalReference<USerializableReference> : DiGi.Core.Classes.ExternalReference
    where USerializableReference : DiGi.Core.Interfaces.ISerializableReference
```
#### Type parameters

<a name='DiGi.Core.Classes.ExternalReference_USerializableReference_.USerializableReference'></a>

`USerializableReference`

The type of the serializable reference\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') → [ExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference 'DiGi\.Core\.Classes\.ExternalReference') → ExternalReference\<USerializableReference\>

Derived  
↳ [InstanceRelatedExternalReference&lt;TInstanceRelatedSerializableReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_ 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference\<TInstanceRelatedSerializableReference\>')  
↳ [TypeRelatedExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeRelatedExternalReference 'DiGi\.Core\.Classes\.TypeRelatedExternalReference')
### Constructors

<a name='DiGi.Core.Classes.ExternalReference_USerializableReference_.ExternalReference(DiGi.Core.Classes.ExternalReference_USerializableReference_)'></a>

## ExternalReference\(ExternalReference\<USerializableReference\>\) Constructor

Initializes a new instance of the [ExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference 'DiGi\.Core\.Classes\.ExternalReference') class by copying an existing generic reference\.

```csharp
public ExternalReference(DiGi.Core.Classes.ExternalReference<USerializableReference>? externalReference);
```
#### Parameters

<a name='DiGi.Core.Classes.ExternalReference_USerializableReference_.ExternalReference(DiGi.Core.Classes.ExternalReference_USerializableReference_).externalReference'></a>

`externalReference` [DiGi\.Core\.Classes\.ExternalReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference_USerializableReference_ 'DiGi\.Core\.Classes\.ExternalReference\<USerializableReference\>')[USerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference_USerializableReference_.USerializableReference 'DiGi\.Core\.Classes\.ExternalReference\<USerializableReference\>\.USerializableReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference_USerializableReference_ 'DiGi\.Core\.Classes\.ExternalReference\<USerializableReference\>')

The external reference to copy from\.

<a name='DiGi.Core.Classes.ExternalReference_USerializableReference_.ExternalReference(string,USerializableReference)'></a>

## ExternalReference\(string, USerializableReference\) Constructor

Initializes a new instance of the [ExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference 'DiGi\.Core\.Classes\.ExternalReference') class with a specified source and serializable reference\.

```csharp
public ExternalReference(string? source, USerializableReference? reference);
```
#### Parameters

<a name='DiGi.Core.Classes.ExternalReference_USerializableReference_.ExternalReference(string,USerializableReference).source'></a>

`source` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The source of the external reference\.

<a name='DiGi.Core.Classes.ExternalReference_USerializableReference_.ExternalReference(string,USerializableReference).reference'></a>

`reference` [USerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference_USerializableReference_.USerializableReference 'DiGi\.Core\.Classes\.ExternalReference\<USerializableReference\>\.USerializableReference')

The serializable reference to use\.

<a name='DiGi.Core.Classes.ExternalReference_USerializableReference_.ExternalReference(System.Text.Json.Nodes.JsonObject)'></a>

## ExternalReference\(JsonObject\) Constructor

Initializes a new instance of the [ExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference 'DiGi\.Core\.Classes\.ExternalReference') class from a JSON object\.

```csharp
public ExternalReference(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.ExternalReference_USerializableReference_.ExternalReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.
### Properties

<a name='DiGi.Core.Classes.ExternalReference_USerializableReference_.Reference'></a>

## ExternalReference\<USerializableReference\>\.Reference Property

Gets or sets the serializable reference object\.

```csharp
public USerializableReference? Reference { get; }
```

#### Property Value
[USerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference_USerializableReference_.USerializableReference 'DiGi\.Core\.Classes\.ExternalReference\<USerializableReference\>\.USerializableReference')

<a name='DiGi.Core.Classes.ExternalReference_USerializableReference_.Segments'></a>

## ExternalReference\<USerializableReference\>\.Segments Property

Gets the segments of this reference's string form: the source, then the nested reference\.

```csharp
protected override System.Collections.Generic.IEnumerable<string?> Segments { protected get; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_'></a>

## ExternalReferenceGuidResult\<TUniqueObject,UExternalReference\> Class

Represents a result containing an external reference GUID\.

```csharp
public abstract class ExternalReferenceGuidResult<TUniqueObject,UExternalReference> : DiGi.Core.Classes.GuidResult<TUniqueObject>
    where TUniqueObject : DiGi.Core.Interfaces.IUniqueObject
    where UExternalReference : DiGi.Core.Interfaces.IExternalReference
```
#### Type parameters

<a name='DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_.TUniqueObject'></a>

`TUniqueObject`

The type of the unique object\.

<a name='DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_.UExternalReference'></a>

`UExternalReference`

The type of the external reference\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [UniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObject 'DiGi\.Core\.Classes\.UniqueObject') → [GuidObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidObject 'DiGi\.Core\.Classes\.GuidObject') → [GuidResult](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult 'DiGi\.Core\.Classes\.GuidResult') → [DiGi\.Core\.Classes\.GuidResult&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult_TUniqueObject_ 'DiGi\.Core\.Classes\.GuidResult\<TUniqueObject\>')[TUniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_.TUniqueObject 'DiGi\.Core\.Classes\.ExternalReferenceGuidResult\<TUniqueObject,UExternalReference\>\.TUniqueObject')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult_TUniqueObject_ 'DiGi\.Core\.Classes\.GuidResult\<TUniqueObject\>') → ExternalReferenceGuidResult\<TUniqueObject,UExternalReference\>
### Constructors

<a name='DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_.ExternalReferenceGuidResult()'></a>

## ExternalReferenceGuidResult\(\) Constructor

Initializes a new instance of the [ExternalReferenceGuidResult&lt;TUniqueObject,UExternalReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_ 'DiGi\.Core\.Classes\.ExternalReferenceGuidResult\<TUniqueObject,UExternalReference\>') class\.

```csharp
public ExternalReferenceGuidResult();
```

<a name='DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_.ExternalReferenceGuidResult(DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_)'></a>

## ExternalReferenceGuidResult\(ExternalReferenceGuidResult\<TUniqueObject,UExternalReference\>\) Constructor

Initializes a new instance of the [ExternalReferenceGuidResult&lt;TUniqueObject,UExternalReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_ 'DiGi\.Core\.Classes\.ExternalReferenceGuidResult\<TUniqueObject,UExternalReference\>') class from another external reference GUID result\.

```csharp
public ExternalReferenceGuidResult(DiGi.Core.Classes.ExternalReferenceGuidResult<TUniqueObject,UExternalReference>? externalReferenceGuidResult);
```
#### Parameters

<a name='DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_.ExternalReferenceGuidResult(DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_).externalReferenceGuidResult'></a>

`externalReferenceGuidResult` [DiGi\.Core\.Classes\.ExternalReferenceGuidResult&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_ 'DiGi\.Core\.Classes\.ExternalReferenceGuidResult\<TUniqueObject,UExternalReference\>')[TUniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_.TUniqueObject 'DiGi\.Core\.Classes\.ExternalReferenceGuidResult\<TUniqueObject,UExternalReference\>\.TUniqueObject')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_ 'DiGi\.Core\.Classes\.ExternalReferenceGuidResult\<TUniqueObject,UExternalReference\>')[UExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_.UExternalReference 'DiGi\.Core\.Classes\.ExternalReferenceGuidResult\<TUniqueObject,UExternalReference\>\.UExternalReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_ 'DiGi\.Core\.Classes\.ExternalReferenceGuidResult\<TUniqueObject,UExternalReference\>')

The external reference GUID result to copy from\.

<a name='DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_.ExternalReferenceGuidResult(System.Text.Json.Nodes.JsonObject)'></a>

## ExternalReferenceGuidResult\(JsonObject\) Constructor

Initializes a new instance of the [ExternalReferenceGuidResult&lt;TUniqueObject,UExternalReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_ 'DiGi\.Core\.Classes\.ExternalReferenceGuidResult\<TUniqueObject,UExternalReference\>') class from the specified JSON object\.

```csharp
public ExternalReferenceGuidResult(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_.ExternalReferenceGuidResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.

<a name='DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_.ExternalReferenceGuidResult(UExternalReference)'></a>

## ExternalReferenceGuidResult\(UExternalReference\) Constructor

Initializes a new instance of the [ExternalReferenceGuidResult&lt;TUniqueObject,UExternalReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_ 'DiGi\.Core\.Classes\.ExternalReferenceGuidResult\<TUniqueObject,UExternalReference\>') class with the specified external reference\.

```csharp
public ExternalReferenceGuidResult(UExternalReference? reference);
```
#### Parameters

<a name='DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_.ExternalReferenceGuidResult(UExternalReference).reference'></a>

`reference` [UExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_.UExternalReference 'DiGi\.Core\.Classes\.ExternalReferenceGuidResult\<TUniqueObject,UExternalReference\>\.UExternalReference')

The external reference to use\.
### Properties

<a name='DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_.Reference'></a>

## ExternalReferenceGuidResult\<TUniqueObject,UExternalReference\>\.Reference Property

Gets or sets the associated external reference\.

```csharp
public UExternalReference? Reference { get; }
```

#### Property Value
[UExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_.UExternalReference 'DiGi\.Core\.Classes\.ExternalReferenceGuidResult\<TUniqueObject,UExternalReference\>\.UExternalReference')

<a name='DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_'></a>

## ExternalReferenceUniqueResult\<TUniqueObject,UExternalReference\> Class

Represents a result containing an external reference unique identifier\.

```csharp
public abstract class ExternalReferenceUniqueResult<TUniqueObject,UExternalReference> : DiGi.Core.Classes.UniqueResult<TUniqueObject>
    where TUniqueObject : DiGi.Core.Interfaces.IUniqueObject
    where UExternalReference : DiGi.Core.Interfaces.IExternalReference
```
#### Type parameters

<a name='DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_.TUniqueObject'></a>

`TUniqueObject`

The type of the unique object\.

<a name='DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_.UExternalReference'></a>

`UExternalReference`

The type of the external reference\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [UniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObject 'DiGi\.Core\.Classes\.UniqueObject') → [UniqueResult](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult 'DiGi\.Core\.Classes\.UniqueResult') → [DiGi\.Core\.Classes\.UniqueResult&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult_T_ 'DiGi\.Core\.Classes\.UniqueResult\<T\>')[TUniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_.TUniqueObject 'DiGi\.Core\.Classes\.ExternalReferenceUniqueResult\<TUniqueObject,UExternalReference\>\.TUniqueObject')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult_T_ 'DiGi\.Core\.Classes\.UniqueResult\<T\>') → ExternalReferenceUniqueResult\<TUniqueObject,UExternalReference\>
### Constructors

<a name='DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_.ExternalReferenceUniqueResult()'></a>

## ExternalReferenceUniqueResult\(\) Constructor

Initializes a new instance of the [ExternalReferenceUniqueResult&lt;TUniqueObject,UExternalReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_ 'DiGi\.Core\.Classes\.ExternalReferenceUniqueResult\<TUniqueObject,UExternalReference\>') class\.

```csharp
public ExternalReferenceUniqueResult();
```

<a name='DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_.ExternalReferenceUniqueResult(DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_)'></a>

## ExternalReferenceUniqueResult\(ExternalReferenceUniqueResult\<TUniqueObject,UExternalReference\>\) Constructor

Initializes a new instance of the [ExternalReferenceUniqueResult&lt;TUniqueObject,UExternalReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_ 'DiGi\.Core\.Classes\.ExternalReferenceUniqueResult\<TUniqueObject,UExternalReference\>') class from another external reference unique result\.

```csharp
public ExternalReferenceUniqueResult(DiGi.Core.Classes.ExternalReferenceUniqueResult<TUniqueObject,UExternalReference>? externalReferenceUniqueResult);
```
#### Parameters

<a name='DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_.ExternalReferenceUniqueResult(DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_).externalReferenceUniqueResult'></a>

`externalReferenceUniqueResult` [DiGi\.Core\.Classes\.ExternalReferenceUniqueResult&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_ 'DiGi\.Core\.Classes\.ExternalReferenceUniqueResult\<TUniqueObject,UExternalReference\>')[TUniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_.TUniqueObject 'DiGi\.Core\.Classes\.ExternalReferenceUniqueResult\<TUniqueObject,UExternalReference\>\.TUniqueObject')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_ 'DiGi\.Core\.Classes\.ExternalReferenceUniqueResult\<TUniqueObject,UExternalReference\>')[UExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_.UExternalReference 'DiGi\.Core\.Classes\.ExternalReferenceUniqueResult\<TUniqueObject,UExternalReference\>\.UExternalReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_ 'DiGi\.Core\.Classes\.ExternalReferenceUniqueResult\<TUniqueObject,UExternalReference\>')

The external reference unique result to initialize from\.

<a name='DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_.ExternalReferenceUniqueResult(System.Text.Json.Nodes.JsonObject)'></a>

## ExternalReferenceUniqueResult\(JsonObject\) Constructor

Initializes a new instance of the [ExternalReferenceUniqueResult&lt;TUniqueObject,UExternalReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_ 'DiGi\.Core\.Classes\.ExternalReferenceUniqueResult\<TUniqueObject,UExternalReference\>') class from the specified JSON object\.

```csharp
public ExternalReferenceUniqueResult(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_.ExternalReferenceUniqueResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.

<a name='DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_.ExternalReferenceUniqueResult(UExternalReference)'></a>

## ExternalReferenceUniqueResult\(UExternalReference\) Constructor

Initializes a new instance of the [ExternalReferenceUniqueResult&lt;TUniqueObject,UExternalReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_ 'DiGi\.Core\.Classes\.ExternalReferenceUniqueResult\<TUniqueObject,UExternalReference\>') class with the specified external reference\.

```csharp
public ExternalReferenceUniqueResult(UExternalReference? reference);
```
#### Parameters

<a name='DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_.ExternalReferenceUniqueResult(UExternalReference).reference'></a>

`reference` [UExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_.UExternalReference 'DiGi\.Core\.Classes\.ExternalReferenceUniqueResult\<TUniqueObject,UExternalReference\>\.UExternalReference')

The external reference to initialize with\.
### Properties

<a name='DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_.Reference'></a>

## ExternalReferenceUniqueResult\<TUniqueObject,UExternalReference\>\.Reference Property

Gets or sets the associated external reference\.

```csharp
public UExternalReference? Reference { get; }
```

#### Property Value
[UExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_.UExternalReference 'DiGi\.Core\.Classes\.ExternalReferenceUniqueResult\<TUniqueObject,UExternalReference\>\.UExternalReference')

<a name='DiGi.Core.Classes.GuidExternalReference'></a>

## GuidExternalReference Class

Represents an external reference identified by a GUID\.

```csharp
public sealed class GuidExternalReference : DiGi.Core.Classes.UniqueExternalReference<DiGi.Core.Classes.GuidReference>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') → [ExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference 'DiGi\.Core\.Classes\.ExternalReference') → [DiGi\.Core\.Classes\.ExternalReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference_USerializableReference_ 'DiGi\.Core\.Classes\.ExternalReference\<USerializableReference\>')[GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference_USerializableReference_ 'DiGi\.Core\.Classes\.ExternalReference\<USerializableReference\>') → [DiGi\.Core\.Classes\.InstanceRelatedExternalReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_ 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference\<TInstanceRelatedSerializableReference\>')[GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_ 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference\<TInstanceRelatedSerializableReference\>') → [DiGi\.Core\.Classes\.UniqueExternalReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_ 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>')[GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_ 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>') → GuidExternalReference

### Example
Renders and parses \(via [TryParse\(this string, IReference\)](DiGi.Core.md#DiGi.Core.Query.TryParse(thisstring,DiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.TryParse\(this string, DiGi\.Core\.Interfaces\.IReference\)')\) as the discriminator, the
source, then the nested GUID reference:

```csharp
GuidExternal::Revit::(Guid::(Type::DiGi.GIS.Classes.Building2D,DiGi.GIS)::0f8fad5bd9cb469fa16570867728950e)
```
### Constructors

<a name='DiGi.Core.Classes.GuidExternalReference.GuidExternalReference(DiGi.Core.Classes.GuidExternalReference)'></a>

## GuidExternalReference\(GuidExternalReference\) Constructor

Initializes a new instance of the [GuidExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidExternalReference 'DiGi\.Core\.Classes\.GuidExternalReference') class by copying an existing instance\.

```csharp
public GuidExternalReference(DiGi.Core.Classes.GuidExternalReference? guidExternalReference);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidExternalReference.GuidExternalReference(DiGi.Core.Classes.GuidExternalReference).guidExternalReference'></a>

`guidExternalReference` [GuidExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidExternalReference 'DiGi\.Core\.Classes\.GuidExternalReference')

The existing instance to copy\.

<a name='DiGi.Core.Classes.GuidExternalReference.GuidExternalReference(string,DiGi.Core.Classes.GuidReference)'></a>

## GuidExternalReference\(string, GuidReference\) Constructor

Initializes a new instance of the [GuidExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidExternalReference 'DiGi\.Core\.Classes\.GuidExternalReference') class with a source and a GUID reference\.

```csharp
public GuidExternalReference(string? source, DiGi.Core.Classes.GuidReference? reference);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidExternalReference.GuidExternalReference(string,DiGi.Core.Classes.GuidReference).source'></a>

`source` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The source string\.

<a name='DiGi.Core.Classes.GuidExternalReference.GuidExternalReference(string,DiGi.Core.Classes.GuidReference).reference'></a>

`reference` [GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference')

The GUID reference\.

<a name='DiGi.Core.Classes.GuidExternalReference.GuidExternalReference(string,DiGi.Core.Interfaces.IGuidObject)'></a>

## GuidExternalReference\(string, IGuidObject\) Constructor

Initializes a new instance of the [GuidExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidExternalReference 'DiGi\.Core\.Classes\.GuidExternalReference') class with a source and a GUID object\.

```csharp
public GuidExternalReference(string? source, DiGi.Core.Interfaces.IGuidObject? guidObject);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidExternalReference.GuidExternalReference(string,DiGi.Core.Interfaces.IGuidObject).source'></a>

`source` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The source string\.

<a name='DiGi.Core.Classes.GuidExternalReference.GuidExternalReference(string,DiGi.Core.Interfaces.IGuidObject).guidObject'></a>

`guidObject` [IGuidObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidObject 'DiGi\.Core\.Interfaces\.IGuidObject')

The GUID object\.

<a name='DiGi.Core.Classes.GuidExternalReference.GuidExternalReference(System.Text.Json.Nodes.JsonObject)'></a>

## GuidExternalReference\(JsonObject\) Constructor

Initializes a new instance of the [GuidExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidExternalReference 'DiGi\.Core\.Classes\.GuidExternalReference') class from a JSON object\.

```csharp
public GuidExternalReference(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidExternalReference.GuidExternalReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.

<a name='DiGi.Core.Classes.GuidModel'></a>

## GuidModel Class

Provides a base implementation for models identified by a unique GUID\.

```csharp
public abstract class GuidModel : DiGi.Core.Classes.GuidObject, DiGi.Core.Interfaces.IGuidModel, DiGi.Core.Interfaces.ISerializableModel, DiGi.Core.Interfaces.IModel, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [UniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObject 'DiGi\.Core\.Classes\.UniqueObject') → [GuidObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidObject 'DiGi\.Core\.Classes\.GuidObject') → GuidModel

Implements [IGuidModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidModel 'DiGi\.Core\.Interfaces\.IGuidModel'), [ISerializableModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableModel 'DiGi\.Core\.Interfaces\.ISerializableModel'), [IModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IModel 'DiGi\.Core\.Interfaces\.IModel'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IGuidObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidObject 'DiGi\.Core\.Interfaces\.IGuidObject'), [IUniqueObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Constructors

<a name='DiGi.Core.Classes.GuidModel.GuidModel()'></a>

## GuidModel\(\) Constructor

Initializes a new instance of the [GuidModel](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidModel 'DiGi\.Core\.Classes\.GuidModel') class\.

```csharp
public GuidModel();
```

<a name='DiGi.Core.Classes.GuidModel.GuidModel(DiGi.Core.Classes.GuidModel)'></a>

## GuidModel\(GuidModel\) Constructor

Initializes a new instance of the [GuidModel](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidModel 'DiGi\.Core\.Classes\.GuidModel') class by copying another instance\.

```csharp
public GuidModel(DiGi.Core.Classes.GuidModel? guidModel);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidModel.GuidModel(DiGi.Core.Classes.GuidModel).guidModel'></a>

`guidModel` [GuidModel](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidModel 'DiGi\.Core\.Classes\.GuidModel')

The GuidModel instance to copy from\.

<a name='DiGi.Core.Classes.GuidModel.GuidModel(System.Guid)'></a>

## GuidModel\(Guid\) Constructor

Initializes a new instance of the [GuidModel](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidModel 'DiGi\.Core\.Classes\.GuidModel') class with a specified GUID\.

```csharp
public GuidModel(System.Guid guid);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidModel.GuidModel(System.Guid).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The GUID value to initialize the model with\.

<a name='DiGi.Core.Classes.GuidModel.GuidModel(System.Text.Json.Nodes.JsonObject)'></a>

## GuidModel\(JsonObject\) Constructor

Initializes a new instance of the [GuidModel](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidModel 'DiGi\.Core\.Classes\.GuidModel') class from a JSON object\.

```csharp
public GuidModel(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidModel.GuidModel(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the model from\.

<a name='DiGi.Core.Classes.GuidObject'></a>

## GuidObject Class

Base class for objects identified by a unique GUID\.

```csharp
public abstract class GuidObject : DiGi.Core.Classes.UniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [UniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObject 'DiGi\.Core\.Classes\.UniqueObject') → GuidObject

Derived  
↳ [GuidModel](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidModel 'DiGi\.Core\.Classes\.GuidModel')  
↳ [GuidResult](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult 'DiGi\.Core\.Classes\.GuidResult')

Implements [IGuidObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidObject 'DiGi\.Core\.Interfaces\.IGuidObject'), [IUniqueObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Classes.GuidObject.GuidObject()'></a>

## GuidObject\(\) Constructor

Initializes a new instance of the [GuidObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidObject 'DiGi\.Core\.Classes\.GuidObject') class\.

```csharp
public GuidObject();
```

<a name='DiGi.Core.Classes.GuidObject.GuidObject(DiGi.Core.Classes.GuidObject)'></a>

## GuidObject\(GuidObject\) Constructor

Initializes a new instance of the [GuidObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidObject 'DiGi\.Core\.Classes\.GuidObject') class by copying another GuidObject\.

```csharp
public GuidObject(DiGi.Core.Classes.GuidObject? guidObject);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidObject.GuidObject(DiGi.Core.Classes.GuidObject).guidObject'></a>

`guidObject` [GuidObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidObject 'DiGi\.Core\.Classes\.GuidObject')

The GuidObject to copy from\.

<a name='DiGi.Core.Classes.GuidObject.GuidObject(System.Guid)'></a>

## GuidObject\(Guid\) Constructor

Initializes a new instance of the [GuidObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidObject 'DiGi\.Core\.Classes\.GuidObject') class with the specified GUID\.

```csharp
public GuidObject(System.Guid guid);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidObject.GuidObject(System.Guid).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The GUID to assign to the new instance\.

<a name='DiGi.Core.Classes.GuidObject.GuidObject(System.Guid,DiGi.Core.Classes.GuidObject)'></a>

## GuidObject\(Guid, GuidObject\) Constructor

Initializes a new instance of the [GuidObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidObject 'DiGi\.Core\.Classes\.GuidObject') class with a specified GUID and an existing object\.

```csharp
public GuidObject(System.Guid guid, DiGi.Core.Classes.GuidObject? guidObject);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidObject.GuidObject(System.Guid,DiGi.Core.Classes.GuidObject).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The GUID to assign to the new instance\.

<a name='DiGi.Core.Classes.GuidObject.GuidObject(System.Guid,DiGi.Core.Classes.GuidObject).guidObject'></a>

`guidObject` [GuidObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidObject 'DiGi\.Core\.Classes\.GuidObject')

The existing GuidObject used for initialization\.

<a name='DiGi.Core.Classes.GuidObject.GuidObject(System.Text.Json.Nodes.JsonObject)'></a>

## GuidObject\(JsonObject\) Constructor

Initializes a new instance of the [GuidObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidObject 'DiGi\.Core\.Classes\.GuidObject') class from a JSON object\.

```csharp
public GuidObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidObject.GuidObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the instance from\.
### Properties

<a name='DiGi.Core.Classes.GuidObject.Guid'></a>

## GuidObject\.Guid Property

Gets or sets the unique identifier for the object\.

```csharp
public System.Guid Guid { get; }
```

Implements [Guid](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidObject.Guid 'DiGi\.Core\.Interfaces\.IGuidObject\.Guid')

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Core.Classes.GuidObject.UniqueId'></a>

## GuidObject\.UniqueId Property

Gets or sets the unique identification string for this object\.

```csharp
public override string? UniqueId { get; }
```

Implements [UniqueId](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject.UniqueId 'DiGi\.Core\.Interfaces\.IUniqueObject\.UniqueId')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Core.Classes.GuidObject.Duplicate(System.Nullable_System.Guid_)'></a>

## GuidObject\.Duplicate\(Nullable\<Guid\>\) Method

Creates a duplicate of the current object, optionally using a new GUID\.

```csharp
public virtual DiGi.Core.Interfaces.IGuidObject? Duplicate(System.Nullable<System.Guid> guid=null);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidObject.Duplicate(System.Nullable_System.Guid_).guid'></a>

`guid` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional GUID to assign to the duplicated object\.

Implements [Duplicate\(Nullable&lt;Guid&gt;\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidObject.Duplicate(System.Nullable_System.Guid_) 'DiGi\.Core\.Interfaces\.IGuidObject\.Duplicate\(System\.Nullable\<System\.Guid\>\)')

#### Returns
[IGuidObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidObject 'DiGi\.Core\.Interfaces\.IGuidObject')  
A duplicate of the current object as an [IGuidObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidObject 'DiGi\.Core\.Interfaces\.IGuidObject')\.

<a name='DiGi.Core.Classes.GuidPropertyReference'></a>

## GuidPropertyReference Class

Represents a reference to a specific property of an object identified by a GUID\.

```csharp
public class GuidPropertyReference : DiGi.Core.Classes.UniquePropertyReference<DiGi.Core.Classes.GuidReference>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') → [PropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference 'DiGi\.Core\.Classes\.PropertyReference') → [DiGi\.Core\.Classes\.PropertyReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference_USerializableReference_ 'DiGi\.Core\.Classes\.PropertyReference\<USerializableReference\>')[GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference_USerializableReference_ 'DiGi\.Core\.Classes\.PropertyReference\<USerializableReference\>') → [DiGi\.Core\.Classes\.UniquePropertyReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_ 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>')[GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_ 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>') → GuidPropertyReference

### Example
Renders and parses \(via [TryParse\(this string, IReference\)](DiGi.Core.md#DiGi.Core.Query.TryParse(thisstring,DiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.TryParse\(this string, DiGi\.Core\.Interfaces\.IReference\)')\) as the discriminator, the
nested GUID reference, then the property name:

```csharp
GuidProperty::(Guid::(Type::DiGi.GIS.Classes.Building2D,DiGi.GIS)::0f8fad5bd9cb469fa16570867728950e)::Name
```
### Constructors

<a name='DiGi.Core.Classes.GuidPropertyReference.GuidPropertyReference(DiGi.Core.Classes.GuidPropertyReference)'></a>

## GuidPropertyReference\(GuidPropertyReference\) Constructor

Initializes a new instance of the [GuidPropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidPropertyReference 'DiGi\.Core\.Classes\.GuidPropertyReference') class by copying an existing reference\.

```csharp
public GuidPropertyReference(DiGi.Core.Classes.GuidPropertyReference? guidPropertyReference);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidPropertyReference.GuidPropertyReference(DiGi.Core.Classes.GuidPropertyReference).guidPropertyReference'></a>

`guidPropertyReference` [GuidPropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidPropertyReference 'DiGi\.Core\.Classes\.GuidPropertyReference')

The existing reference to copy\.

<a name='DiGi.Core.Classes.GuidPropertyReference.GuidPropertyReference(DiGi.Core.Classes.GuidReference,string)'></a>

## GuidPropertyReference\(GuidReference, string\) Constructor

Initializes a new instance of the [GuidPropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidPropertyReference 'DiGi\.Core\.Classes\.GuidPropertyReference') class with the specified reference and property name\.

```csharp
public GuidPropertyReference(DiGi.Core.Classes.GuidReference? reference, string? propertyName);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidPropertyReference.GuidPropertyReference(DiGi.Core.Classes.GuidReference,string).reference'></a>

`reference` [GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference')

The reference to use\.

<a name='DiGi.Core.Classes.GuidPropertyReference.GuidPropertyReference(DiGi.Core.Classes.GuidReference,string).propertyName'></a>

`propertyName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the property\.

<a name='DiGi.Core.Classes.GuidPropertyReference.GuidPropertyReference(System.Text.Json.Nodes.JsonObject)'></a>

## GuidPropertyReference\(JsonObject\) Constructor

Initializes a new instance of the [GuidPropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidPropertyReference 'DiGi\.Core\.Classes\.GuidPropertyReference') class from the specified JSON object\.

```csharp
public GuidPropertyReference(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidPropertyReference.GuidPropertyReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.
### Methods

<a name='DiGi.Core.Classes.GuidPropertyReference.Clone()'></a>

## GuidPropertyReference\.Clone\(\) Method

Creates a shallow copy of the current object\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject Clone();
```

Implements [Clone\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.Clone() 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>\.Clone\(\)')

#### Returns
[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A shallow copy of the current object\.

<a name='DiGi.Core.Classes.GuidReference'></a>

## GuidReference Class

Represents a reference to an object identified by a GUID\.

```csharp
public class GuidReference : DiGi.Core.Classes.UniqueReference
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') → [UniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference 'DiGi\.Core\.Classes\.UniqueReference') → GuidReference

### Example
Renders and parses \(via [TryParse\(this string, IReference\)](DiGi.Core.md#DiGi.Core.Query.TryParse(thisstring,DiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.TryParse\(this string, DiGi\.Core\.Interfaces\.IReference\)')\) as the discriminator, the
nested type reference, then the GUID in N format:

```csharp
Guid::(Type::DiGi.GIS.Classes.Building2D,DiGi.GIS)::0f8fad5bd9cb469fa16570867728950e
```
### Constructors

<a name='DiGi.Core.Classes.GuidReference.GuidReference(DiGi.Core.Classes.GuidReference)'></a>

## GuidReference\(GuidReference\) Constructor

Initializes a new instance of the [GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference') class by copying an existing reference\.

```csharp
public GuidReference(DiGi.Core.Classes.GuidReference? guidReference);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidReference.GuidReference(DiGi.Core.Classes.GuidReference).guidReference'></a>

`guidReference` [GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference')

The existing reference to copy\.

<a name='DiGi.Core.Classes.GuidReference.GuidReference(DiGi.Core.Classes.TypeReference,System.Guid)'></a>

## GuidReference\(TypeReference, Guid\) Constructor

Initializes a new instance of the [GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference') class using a type reference and a GUID\.

```csharp
public GuidReference(DiGi.Core.Classes.TypeReference? typeReference, System.Guid guid);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidReference.GuidReference(DiGi.Core.Classes.TypeReference,System.Guid).typeReference'></a>

`typeReference` [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')

The type reference to use\.

<a name='DiGi.Core.Classes.GuidReference.GuidReference(DiGi.Core.Classes.TypeReference,System.Guid).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The GUID value to assign\.

<a name='DiGi.Core.Classes.GuidReference.GuidReference(DiGi.Core.Interfaces.IGuidObject)'></a>

## GuidReference\(IGuidObject\) Constructor

Initializes a new instance of the [GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference') class from a GUID object\.

```csharp
public GuidReference(DiGi.Core.Interfaces.IGuidObject? guidObject);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidReference.GuidReference(DiGi.Core.Interfaces.IGuidObject).guidObject'></a>

`guidObject` [IGuidObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidObject 'DiGi\.Core\.Interfaces\.IGuidObject')

The GUID object to initialize from\.

<a name='DiGi.Core.Classes.GuidReference.GuidReference(System.Text.Json.Nodes.JsonObject)'></a>

## GuidReference\(JsonObject\) Constructor

Initializes a new instance of the [GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference') class from a JSON object\.

```csharp
public GuidReference(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidReference.GuidReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.
### Properties

<a name='DiGi.Core.Classes.GuidReference.Guid'></a>

## GuidReference\.Guid Property

Gets the GUID value of the reference\.

```csharp
public System.Guid Guid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Core.Classes.GuidReference.UniqueId'></a>

## GuidReference\.UniqueId Property

Gets the unique identifier for the reference\.

```csharp
public override string? UniqueId { get; }
```

Implements [UniqueId](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference.UniqueId 'DiGi\.Core\.Interfaces\.IUniqueReference\.UniqueId')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Core.Classes.GuidReference.Clone()'></a>

## GuidReference\.Clone\(\) Method

Creates a deep copy of the current object\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.Clone() 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>\.Clone\(\)')

#### Returns
[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a copy of the current object\.

<a name='DiGi.Core.Classes.GuidResult'></a>

## GuidResult Class

Represents a result containing a GUID\.

```csharp
public abstract class GuidResult : DiGi.Core.Classes.GuidObject, DiGi.Core.Interfaces.IGuidResult, DiGi.Core.Interfaces.IUniqueResult, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [UniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObject 'DiGi\.Core\.Classes\.UniqueObject') → [GuidObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidObject 'DiGi\.Core\.Classes\.GuidObject') → GuidResult

Derived  
↳ [GuidResult&lt;TUniqueObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult_TUniqueObject_ 'DiGi\.Core\.Classes\.GuidResult\<TUniqueObject\>')

Implements [IGuidResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidResult 'DiGi\.Core\.Interfaces\.IGuidResult'), [IUniqueResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult 'DiGi\.Core\.Interfaces\.IUniqueResult'), [ISerializableResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [IResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IResult 'DiGi\.Core\.Interfaces\.IResult'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IUniqueObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Constructors

<a name='DiGi.Core.Classes.GuidResult.GuidResult()'></a>

## GuidResult\(\) Constructor

Initializes a new instance of the [GuidResult](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult 'DiGi\.Core\.Classes\.GuidResult') class\.

```csharp
public GuidResult();
```

<a name='DiGi.Core.Classes.GuidResult.GuidResult(DiGi.Core.Classes.GuidResult)'></a>

## GuidResult\(GuidResult\) Constructor

Initializes a new instance of the [GuidResult](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult 'DiGi\.Core\.Classes\.GuidResult') class from another GUID result\.

```csharp
public GuidResult(DiGi.Core.Classes.GuidResult? guidResult);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidResult.GuidResult(DiGi.Core.Classes.GuidResult).guidResult'></a>

`guidResult` [GuidResult](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult 'DiGi\.Core\.Classes\.GuidResult')

The GUID result to initialize from\.

<a name='DiGi.Core.Classes.GuidResult.GuidResult(System.Text.Json.Nodes.JsonObject)'></a>

## GuidResult\(JsonObject\) Constructor

Initializes a new instance of the [GuidResult](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult 'DiGi\.Core\.Classes\.GuidResult') class from the specified JSON object\.

```csharp
public GuidResult(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidResult.GuidResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.

<a name='DiGi.Core.Classes.GuidResult_TUniqueObject_'></a>

## GuidResult\<TUniqueObject\> Class

Represents a result containing a GUID\.

```csharp
public abstract class GuidResult<TUniqueObject> : DiGi.Core.Classes.GuidResult, DiGi.Core.Interfaces.IUniqueResult<TUniqueObject>, DiGi.Core.Interfaces.IUniqueResult, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject
    where TUniqueObject : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Classes.GuidResult_TUniqueObject_.TUniqueObject'></a>

`TUniqueObject`

The type of the unique object associated with the GUID result\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [UniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObject 'DiGi\.Core\.Classes\.UniqueObject') → [GuidObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidObject 'DiGi\.Core\.Classes\.GuidObject') → [GuidResult](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult 'DiGi\.Core\.Classes\.GuidResult') → GuidResult\<TUniqueObject\>

Derived  
↳ [ExternalReferenceGuidResult&lt;TUniqueObject,UExternalReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceGuidResult_TUniqueObject,UExternalReference_ 'DiGi\.Core\.Classes\.ExternalReferenceGuidResult\<TUniqueObject,UExternalReference\>')

Implements [DiGi\.Core\.Interfaces\.IUniqueResult&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult_T_ 'DiGi\.Core\.Interfaces\.IUniqueResult\<T\>')[TUniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult_TUniqueObject_.TUniqueObject 'DiGi\.Core\.Classes\.GuidResult\<TUniqueObject\>\.TUniqueObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult_T_ 'DiGi\.Core\.Interfaces\.IUniqueResult\<T\>'), [IUniqueResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult 'DiGi\.Core\.Interfaces\.IUniqueResult'), [ISerializableResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [IResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IResult 'DiGi\.Core\.Interfaces\.IResult'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IUniqueObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Constructors

<a name='DiGi.Core.Classes.GuidResult_TUniqueObject_.GuidResult()'></a>

## GuidResult\(\) Constructor

Initializes a new instance of the [GuidResult](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult 'DiGi\.Core\.Classes\.GuidResult') class\.

```csharp
public GuidResult();
```

<a name='DiGi.Core.Classes.GuidResult_TUniqueObject_.GuidResult(DiGi.Core.Classes.GuidResult_TUniqueObject_)'></a>

## GuidResult\(GuidResult\<TUniqueObject\>\) Constructor

Initializes a new instance of the [GuidResult](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult 'DiGi\.Core\.Classes\.GuidResult') class from a generic GUID result\.

```csharp
public GuidResult(DiGi.Core.Classes.GuidResult<TUniqueObject>? guidResult);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidResult_TUniqueObject_.GuidResult(DiGi.Core.Classes.GuidResult_TUniqueObject_).guidResult'></a>

`guidResult` [DiGi\.Core\.Classes\.GuidResult&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult_TUniqueObject_ 'DiGi\.Core\.Classes\.GuidResult\<TUniqueObject\>')[TUniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult_TUniqueObject_.TUniqueObject 'DiGi\.Core\.Classes\.GuidResult\<TUniqueObject\>\.TUniqueObject')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult_TUniqueObject_ 'DiGi\.Core\.Classes\.GuidResult\<TUniqueObject\>')

The generic GUID result to initialize from\.

<a name='DiGi.Core.Classes.GuidResult_TUniqueObject_.GuidResult(System.Text.Json.Nodes.JsonObject)'></a>

## GuidResult\(JsonObject\) Constructor

Initializes a new instance of the [GuidResult](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult 'DiGi\.Core\.Classes\.GuidResult') class from the specified JSON object\.

```csharp
public GuidResult(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.GuidResult_TUniqueObject_.GuidResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.

<a name='DiGi.Core.Classes.IndexedBools'></a>

## IndexedBools Class

Represents a collection of boolean values mapped to integer indices\.

```csharp
public class IndexedBools : DiGi.Core.Classes.IndexedObjects<bool>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.IndexedObjects&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_ 'DiGi\.Core\.Classes\.IndexedObjects\<T\>')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_ 'DiGi\.Core\.Classes\.IndexedObjects\<T\>') → IndexedBools
### Constructors

<a name='DiGi.Core.Classes.IndexedBools.IndexedBools()'></a>

## IndexedBools\(\) Constructor

Initializes a new instance of the [IndexedBools](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedBools 'DiGi\.Core\.Classes\.IndexedBools') class\.

```csharp
public IndexedBools();
```

<a name='DiGi.Core.Classes.IndexedBools.IndexedBools(DiGi.Core.Classes.IndexedBools)'></a>

## IndexedBools\(IndexedBools\) Constructor

Initializes a new instance of the [IndexedBools](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedBools 'DiGi\.Core\.Classes\.IndexedBools') class by copying another instance\.

```csharp
public IndexedBools(DiGi.Core.Classes.IndexedBools indexedDoubles);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedBools.IndexedBools(DiGi.Core.Classes.IndexedBools).indexedDoubles'></a>

`indexedDoubles` [IndexedBools](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedBools 'DiGi\.Core\.Classes\.IndexedBools')

The source [IndexedBools](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedBools 'DiGi\.Core\.Classes\.IndexedBools') instance to copy from\.

<a name='DiGi.Core.Classes.IndexedBools.IndexedBools(int,int,bool)'></a>

## IndexedBools\(int, int, bool\) Constructor

Initializes a new instance of the [IndexedBools](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedBools 'DiGi\.Core\.Classes\.IndexedBools') class with a range of indices set to the same value\.

```csharp
public IndexedBools(int startIndex, int count, bool value);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedBools.IndexedBools(int,int,bool).startIndex'></a>

`startIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The starting index of the range\.

<a name='DiGi.Core.Classes.IndexedBools.IndexedBools(int,int,bool).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of elements in the range\.

<a name='DiGi.Core.Classes.IndexedBools.IndexedBools(int,int,bool).value'></a>

`value` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

The boolean value to assign to each element in the range\.

<a name='DiGi.Core.Classes.IndexedBools.IndexedBools(System.Collections.Generic.IEnumerable_bool_)'></a>

## IndexedBools\(IEnumerable\<bool\>\) Constructor

Initializes a new instance of the [IndexedBools](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedBools 'DiGi\.Core\.Classes\.IndexedBools') class from a collection of boolean values\.

```csharp
public IndexedBools(System.Collections.Generic.IEnumerable<bool> values);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedBools.IndexedBools(System.Collections.Generic.IEnumerable_bool_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of boolean values to use for initialization\.

<a name='DiGi.Core.Classes.IndexedBools.IndexedBools(System.Collections.Generic.IEnumerable_bool_,int)'></a>

## IndexedBools\(IEnumerable\<bool\>, int\) Constructor

Initializes a new instance of the [IndexedBools](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedBools 'DiGi\.Core\.Classes\.IndexedBools') class from a collection of boolean values starting at a specified index\.

```csharp
public IndexedBools(System.Collections.Generic.IEnumerable<bool> values, int startIndex);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedBools.IndexedBools(System.Collections.Generic.IEnumerable_bool_,int).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of boolean values to use for initialization\.

<a name='DiGi.Core.Classes.IndexedBools.IndexedBools(System.Collections.Generic.IEnumerable_bool_,int).startIndex'></a>

`startIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The starting index for the provided values\.

<a name='DiGi.Core.Classes.IndexedBools.IndexedBools(System.Text.Json.Nodes.JsonObject)'></a>

## IndexedBools\(JsonObject\) Constructor

Initializes a new instance of the [IndexedBools](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedBools 'DiGi\.Core\.Classes\.IndexedBools') class from a JSON object\.

```csharp
public IndexedBools(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedBools.IndexedBools(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the instance from\.

<a name='DiGi.Core.Classes.IndexedDoubles'></a>

## IndexedDoubles Class

Represents a collection of double\-precision floating\-point values mapped to integer indices\.

```csharp
public class IndexedDoubles : DiGi.Core.Classes.IndexedObjects<double>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.IndexedObjects&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_ 'DiGi\.Core\.Classes\.IndexedObjects\<T\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_ 'DiGi\.Core\.Classes\.IndexedObjects\<T\>') → IndexedDoubles
### Constructors

<a name='DiGi.Core.Classes.IndexedDoubles.IndexedDoubles()'></a>

## IndexedDoubles\(\) Constructor

Initializes a new instance of the [IndexedDoubles](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedDoubles 'DiGi\.Core\.Classes\.IndexedDoubles') class\.

```csharp
public IndexedDoubles();
```

<a name='DiGi.Core.Classes.IndexedDoubles.IndexedDoubles(DiGi.Core.Classes.IndexedDoubles)'></a>

## IndexedDoubles\(IndexedDoubles\) Constructor

Initializes a new instance of the [IndexedDoubles](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedDoubles 'DiGi\.Core\.Classes\.IndexedDoubles') class by copying another instance\.

```csharp
public IndexedDoubles(DiGi.Core.Classes.IndexedDoubles indexedDoubles);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedDoubles.IndexedDoubles(DiGi.Core.Classes.IndexedDoubles).indexedDoubles'></a>

`indexedDoubles` [IndexedDoubles](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedDoubles 'DiGi\.Core\.Classes\.IndexedDoubles')

The source IndexedDoubles instance to copy\.

<a name='DiGi.Core.Classes.IndexedDoubles.IndexedDoubles(int,int,double)'></a>

## IndexedDoubles\(int, int, double\) Constructor

Initializes a new instance of the [IndexedDoubles](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedDoubles 'DiGi\.Core\.Classes\.IndexedDoubles') class with a range of indices set to the same value\.

```csharp
public IndexedDoubles(int startIndex, int count, double value);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedDoubles.IndexedDoubles(int,int,double).startIndex'></a>

`startIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The starting index for the range\.

<a name='DiGi.Core.Classes.IndexedDoubles.IndexedDoubles(int,int,double).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of elements in the range\.

<a name='DiGi.Core.Classes.IndexedDoubles.IndexedDoubles(int,int,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value to assign to each element in the range\.

<a name='DiGi.Core.Classes.IndexedDoubles.IndexedDoubles(System.Collections.Generic.IEnumerable_double_)'></a>

## IndexedDoubles\(IEnumerable\<double\>\) Constructor

Initializes a new instance of the [IndexedDoubles](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedDoubles 'DiGi\.Core\.Classes\.IndexedDoubles') class from a collection of double values\.

```csharp
public IndexedDoubles(System.Collections.Generic.IEnumerable<double> values);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedDoubles.IndexedDoubles(System.Collections.Generic.IEnumerable_double_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of double values to initialize with\.

<a name='DiGi.Core.Classes.IndexedDoubles.IndexedDoubles(System.Collections.Generic.IEnumerable_double_,int)'></a>

## IndexedDoubles\(IEnumerable\<double\>, int\) Constructor

Initializes a new instance of the [IndexedDoubles](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedDoubles 'DiGi\.Core\.Classes\.IndexedDoubles') class from a collection of double values starting at a specified index\.

```csharp
public IndexedDoubles(System.Collections.Generic.IEnumerable<double> values, int startIndex);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedDoubles.IndexedDoubles(System.Collections.Generic.IEnumerable_double_,int).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of double values to initialize with\.

<a name='DiGi.Core.Classes.IndexedDoubles.IndexedDoubles(System.Collections.Generic.IEnumerable_double_,int).startIndex'></a>

`startIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The starting index for the provided values\.

<a name='DiGi.Core.Classes.IndexedDoubles.IndexedDoubles(System.Text.Json.Nodes.JsonObject)'></a>

## IndexedDoubles\(JsonObject\) Constructor

Initializes a new instance of the [IndexedDoubles](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedDoubles 'DiGi\.Core\.Classes\.IndexedDoubles') class from a JSON object\.

```csharp
public IndexedDoubles(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedDoubles.IndexedDoubles(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.
### Methods

<a name='DiGi.Core.Classes.IndexedDoubles.GetAverage()'></a>

## IndexedDoubles\.GetAverage\(\) Method

Calculates and returns the average of all stored values\.

```csharp
public double GetAverage();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The calculated average of the stored values\.

<a name='DiGi.Core.Classes.IndexedDoubles.GetMaxValue()'></a>

## IndexedDoubles\.GetMaxValue\(\) Method

Returns the maximum value present in the collection\.

```csharp
public double GetMaxValue();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The maximum double value found in the collection\.

<a name='DiGi.Core.Classes.IndexedDoubles.GetMaxValueIndex()'></a>

## IndexedDoubles\.GetMaxValueIndex\(\) Method

Returns the index of the maximum value in the collection\.

```csharp
public int GetMaxValueIndex();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The zero\-based index of the maximum value\.

<a name='DiGi.Core.Classes.IndexedDoubles.GetMinValue()'></a>

## IndexedDoubles\.GetMinValue\(\) Method

Returns the minimum value present in the collection\.

```csharp
public double GetMinValue();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The minimum value found in the collection\.

<a name='DiGi.Core.Classes.IndexedDoubles.GetMinValueIndex()'></a>

## IndexedDoubles\.GetMinValueIndex\(\) Method

Returns the index of the minimum value in the collection\.

```csharp
public int GetMinValueIndex();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The zero\-based index of the minimum value\.

<a name='DiGi.Core.Classes.IndexedDoubles.GetSum()'></a>

## IndexedDoubles\.GetSum\(\) Method

Calculates and returns the sum of all stored values\.

```csharp
public double GetSum();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The total sum of all stored values\.

<a name='DiGi.Core.Classes.IndexedDoubles.Sum(DiGi.Core.Classes.IndexedDoubles)'></a>

## IndexedDoubles\.Sum\(IndexedDoubles\) Method

Adds the values from another [IndexedDoubles](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedDoubles 'DiGi\.Core\.Classes\.IndexedDoubles') instance to the current collection\.

```csharp
public void Sum(DiGi.Core.Classes.IndexedDoubles indexedDoubles);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedDoubles.Sum(DiGi.Core.Classes.IndexedDoubles).indexedDoubles'></a>

`indexedDoubles` [IndexedDoubles](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedDoubles 'DiGi\.Core\.Classes\.IndexedDoubles')

The [IndexedDoubles](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedDoubles 'DiGi\.Core\.Classes\.IndexedDoubles') instance containing the values to be added\.

<a name='DiGi.Core.Classes.IndexedObjects_T_'></a>

## IndexedObjects\<T\> Class

Represents a generic collection of objects mapped to integer indices\.

```csharp
public class IndexedObjects<T> : DiGi.Core.Classes.SerializableObject, DiGi.Core.Interfaces.IIndexedObjects<T>, DiGi.Core.Interfaces.IIndexedObjects, DiGi.Core.Interfaces.IObject, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable<T>
```
#### Type parameters

<a name='DiGi.Core.Classes.IndexedObjects_T_.T'></a>

`T`

The type of elements in the collection\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → IndexedObjects\<T\>

Derived  
↳ [IndexedBools](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedBools 'DiGi\.Core\.Classes\.IndexedBools')  
↳ [IndexedDoubles](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedDoubles 'DiGi\.Core\.Classes\.IndexedDoubles')

Implements [DiGi\.Core\.Interfaces\.IIndexedObjects&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IIndexedObjects_T_ 'DiGi\.Core\.Interfaces\.IIndexedObjects\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_.T 'DiGi\.Core\.Classes\.IndexedObjects\<T\>\.T')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IIndexedObjects_T_ 'DiGi\.Core\.Interfaces\.IIndexedObjects\<T\>'), [IIndexedObjects](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IIndexedObjects 'DiGi\.Core\.Interfaces\.IIndexedObjects'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable'), [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_.T 'DiGi\.Core\.Classes\.IndexedObjects\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')
### Constructors

<a name='DiGi.Core.Classes.IndexedObjects_T_.IndexedObjects()'></a>

## IndexedObjects\(\) Constructor

Initializes a new instance of the [IndexedObjects&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_ 'DiGi\.Core\.Classes\.IndexedObjects\<T\>') class\.

```csharp
public IndexedObjects();
```

<a name='DiGi.Core.Classes.IndexedObjects_T_.IndexedObjects(DiGi.Core.Classes.IndexedObjects_T_)'></a>

## IndexedObjects\(IndexedObjects\<T\>\) Constructor

Initializes a new instance of the [IndexedObjects&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_ 'DiGi\.Core\.Classes\.IndexedObjects\<T\>') class by copying another instance\.

```csharp
public IndexedObjects(DiGi.Core.Classes.IndexedObjects<T>? indexedObjects);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedObjects_T_.IndexedObjects(DiGi.Core.Classes.IndexedObjects_T_).indexedObjects'></a>

`indexedObjects` [DiGi\.Core\.Classes\.IndexedObjects&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_ 'DiGi\.Core\.Classes\.IndexedObjects\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_.T 'DiGi\.Core\.Classes\.IndexedObjects\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_ 'DiGi\.Core\.Classes\.IndexedObjects\<T\>')

The existing instance to copy from\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.IndexedObjects(int,int,T)'></a>

## IndexedObjects\(int, int, T\) Constructor

Initializes a new instance of the [IndexedObjects&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_ 'DiGi\.Core\.Classes\.IndexedObjects\<T\>') class with a range of indices set to the same value\.

```csharp
public IndexedObjects(int startIndex, int count, T? value);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedObjects_T_.IndexedObjects(int,int,T).startIndex'></a>

`startIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The starting index of the range\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.IndexedObjects(int,int,T).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of elements in the range\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.IndexedObjects(int,int,T).value'></a>

`value` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_.T 'DiGi\.Core\.Classes\.IndexedObjects\<T\>\.T')

The value to assign to each element in the range\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.IndexedObjects(System.Collections.Generic.IEnumerable_T_)'></a>

## IndexedObjects\(IEnumerable\<T\>\) Constructor

Initializes a new instance of the [IndexedObjects&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_ 'DiGi\.Core\.Classes\.IndexedObjects\<T\>') class from a collection of values\.

```csharp
public IndexedObjects(System.Collections.Generic.IEnumerable<T>? values);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedObjects_T_.IndexedObjects(System.Collections.Generic.IEnumerable_T_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_.T 'DiGi\.Core\.Classes\.IndexedObjects\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of values to initialize the collection\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.IndexedObjects(System.Collections.Generic.IEnumerable_T_,int)'></a>

## IndexedObjects\(IEnumerable\<T\>, int\) Constructor

Initializes a new instance of the [IndexedObjects&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_ 'DiGi\.Core\.Classes\.IndexedObjects\<T\>') class from a collection of values starting at a specified index\.

```csharp
public IndexedObjects(System.Collections.Generic.IEnumerable<T>? values, int startIndex);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedObjects_T_.IndexedObjects(System.Collections.Generic.IEnumerable_T_,int).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_.T 'DiGi\.Core\.Classes\.IndexedObjects\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of values to initialize the collection\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.IndexedObjects(System.Collections.Generic.IEnumerable_T_,int).startIndex'></a>

`startIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The starting index for the collection of values\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.IndexedObjects(System.Collections.Generic.SortedDictionary_int,T_)'></a>

## IndexedObjects\(SortedDictionary\<int,T\>\) Constructor

Initializes a new instance of the [IndexedObjects&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_ 'DiGi\.Core\.Classes\.IndexedObjects\<T\>') class from a sorted dictionary of indices and values\.

```csharp
public IndexedObjects(System.Collections.Generic.SortedDictionary<int,T?>? sortedDictionary);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedObjects_T_.IndexedObjects(System.Collections.Generic.SortedDictionary_int,T_).sortedDictionary'></a>

`sortedDictionary` [System\.Collections\.Generic\.SortedDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.sorteddictionary-2 'System\.Collections\.Generic\.SortedDictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.sorteddictionary-2 'System\.Collections\.Generic\.SortedDictionary\`2')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_.T 'DiGi\.Core\.Classes\.IndexedObjects\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.sorteddictionary-2 'System\.Collections\.Generic\.SortedDictionary\`2')

The sorted dictionary containing indices and values to initialize the collection\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.IndexedObjects(System.Text.Json.Nodes.JsonObject)'></a>

## IndexedObjects\(JsonObject\) Constructor

Initializes a new instance of the [IndexedObjects&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_ 'DiGi\.Core\.Classes\.IndexedObjects\<T\>') class from a JSON object\.

```csharp
public IndexedObjects(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedObjects_T_.IndexedObjects(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the collection\.
### Properties

<a name='DiGi.Core.Classes.IndexedObjects_T_.Count'></a>

## IndexedObjects\<T\>\.Count Property

Gets the number of elements contained in the collection\.

```csharp
public int Count { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.Classes.IndexedObjects_T_.Keys'></a>

## IndexedObjects\<T\>\.Keys Property

Gets the collection of all indices currently stored\.

```csharp
public System.Collections.Generic.IEnumerable<int>? Keys { get; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.Core.Classes.IndexedObjects_T_.this[int]'></a>

## IndexedObjects\<T\>\.this\[int\] Property

Gets or sets the value associated with the specified index\.

```csharp
public T? this[int index] { get; set; }
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedObjects_T_.this[int].index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the element to get or set\.

#### Property Value
[T](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_.T 'DiGi\.Core\.Classes\.IndexedObjects\<T\>\.T')

<a name='DiGi.Core.Classes.IndexedObjects_T_.Values'></a>

## IndexedObjects\<T\>\.Values Property

Gets the collection of all values currently stored\.

```csharp
public System.Collections.Generic.IEnumerable<T?>? Values { get; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_.T 'DiGi\.Core\.Classes\.IndexedObjects\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')
### Methods

<a name='DiGi.Core.Classes.IndexedObjects_T_.Add(DiGi.Core.Classes.Range_int_,T)'></a>

## IndexedObjects\<T\>\.Add\(Range\<int\>, T\) Method

Adds or updates values across a specified range of indices\. Returns true if the operation succeeded\.

```csharp
public bool Add(DiGi.Core.Classes.Range<int> range, T? value);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedObjects_T_.Add(DiGi.Core.Classes.Range_int_,T).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range of indices to update\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.Add(DiGi.Core.Classes.Range_int_,T).value'></a>

`value` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_.T 'DiGi\.Core\.Classes\.IndexedObjects\<T\>\.T')

The value to add or update\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the operation succeeded; otherwise, false\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.Add(int,T)'></a>

## IndexedObjects\<T\>\.Add\(int, T\) Method

Adds or updates a value at the specified index\. Returns true if the operation succeeded\.

```csharp
public bool Add(int index, T? value);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedObjects_T_.Add(int,T).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index at which to add or update the value\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.Add(int,T).value'></a>

`value` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_.T 'DiGi\.Core\.Classes\.IndexedObjects\<T\>\.T')

The value to add or update\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the operation succeeded; otherwise, false\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.ContainsIndex(int)'></a>

## IndexedObjects\<T\>\.ContainsIndex\(int\) Method

Determines whether the collection contains an element at the specified index\.

```csharp
public bool ContainsIndex(int index);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedObjects_T_.ContainsIndex(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index to check for existence\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the collection contains an element at the specified index; otherwise, false\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.FromJsonObject(System.Text.Json.Nodes.JsonObject)'></a>

## IndexedObjects\<T\>\.FromJsonObject\(JsonObject\) Method

Populates the current instance from a JSON object\. Returns true if successful\.

```csharp
public override bool FromJsonObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedObjects_T_.FromJsonObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to populate the instance from\.

Implements [FromJsonObject\(JsonObject\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject.FromJsonObject(System.Text.Json.Nodes.JsonObject) 'DiGi\.Core\.Interfaces\.ISerializableObject\.FromJsonObject\(System\.Text\.Json\.Nodes\.JsonObject\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the population was successful; otherwise, false\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.GetEnumerator()'></a>

## IndexedObjects\<T\>\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the collection of values\.

```csharp
public System.Collections.Generic.IEnumerator<T> GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator 'System\.Collections\.Generic\.IEnumerable\`1\.GetEnumerator'), [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

#### Returns
[System\.Collections\.Generic\.IEnumerator&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_.T 'DiGi\.Core\.Classes\.IndexedObjects\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')  
An enumerator that iterates through the collection\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.GetMaxIndex()'></a>

## IndexedObjects\<T\>\.GetMaxIndex\(\) Method

Gets the highest index present in the collection, or null if empty\.

```csharp
public System.Nullable<int> GetMaxIndex();
```

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The maximum index present in the collection, or null if the collection is empty\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.GetMinIndex()'></a>

## IndexedObjects\<T\>\.GetMinIndex\(\) Method

Gets the lowest index present in the collection, or null if empty\.

```csharp
public System.Nullable<int> GetMinIndex();
```

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The minimum index present in the collection, or null if the collection is empty\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.GetValue(int)'></a>

## IndexedObjects\<T\>\.GetValue\(int\) Method

Retrieves the value at the specified index\.

```csharp
public T? GetValue(int index);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedObjects_T_.GetValue(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the element to get\.

#### Returns
[T](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_.T 'DiGi\.Core\.Classes\.IndexedObjects\<T\>\.T')  
The value at the specified index, or null if not found\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.GetValues(DiGi.Core.Classes.Range_int_)'></a>

## IndexedObjects\<T\>\.GetValues\(Range\<int\>\) Method

Retrieves a list of values within the specified range\.

```csharp
public System.Collections.Generic.List<T?>? GetValues(DiGi.Core.Classes.Range<int>? range);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedObjects_T_.GetValues(DiGi.Core.Classes.Range_int_).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range of indices from which to retrieve values\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_.T 'DiGi\.Core\.Classes\.IndexedObjects\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of values within the specified range, or null if no values are found\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.GetValues(DiGi.Core.Classes.Range_int_,bool)'></a>

## IndexedObjects\<T\>\.GetValues\(Range\<int\>, bool\) Method

Retrieves a list of values within the specified range, with an option to bound the results\.

```csharp
public System.Collections.Generic.List<T?>? GetValues(DiGi.Core.Classes.Range<int>? range, bool bounded);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedObjects_T_.GetValues(DiGi.Core.Classes.Range_int_,bool).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range of indices from which to retrieve values\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.GetValues(DiGi.Core.Classes.Range_int_,bool).bounded'></a>

`bounded` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the results should be bounded\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_.T 'DiGi\.Core\.Classes\.IndexedObjects\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of values within the specified range, or null if no values are found\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.Remove(int)'></a>

## IndexedObjects\<T\>\.Remove\(int\) Method

Removes the element at the specified index\. Returns true if the element was found and removed\.

```csharp
public bool Remove(int index);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedObjects_T_.Remove(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the element to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the element was successfully found and removed; otherwise, false\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.ToJsonObject()'></a>

## IndexedObjects\<T\>\.ToJsonObject\(\) Method

Serializes the current instance into a JSON object\.

```csharp
public override System.Text.Json.Nodes.JsonObject? ToJsonObject();
```

Implements [ToJsonObject\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject.ToJsonObject() 'DiGi\.Core\.Interfaces\.ISerializableObject\.ToJsonObject\(\)')

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') representation of the current instance, or null\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.TryGetValue(int,T)'></a>

## IndexedObjects\<T\>\.TryGetValue\(int, T\) Method

Attempts to get the value associated with the specified index\. Returns true if found\.

```csharp
public bool TryGetValue(int index, out T? result);
```
#### Parameters

<a name='DiGi.Core.Classes.IndexedObjects_T_.TryGetValue(int,T).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the element to get\.

<a name='DiGi.Core.Classes.IndexedObjects_T_.TryGetValue(int,T).result'></a>

`result` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_.T 'DiGi\.Core\.Classes\.IndexedObjects\<T\>\.T')

When this method returns, contains the value associated with the specified index, if found; otherwise, the default value of the element type\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the element was found; otherwise, false\.

<a name='DiGi.Core.Classes.InstanceRelatedExternalReference'></a>

## InstanceRelatedExternalReference Class

Represents a sealed implementation of an external reference related to a specific instance\.

```csharp
public sealed class InstanceRelatedExternalReference : DiGi.Core.Classes.InstanceRelatedExternalReference<DiGi.Core.Interfaces.IInstanceRelatedSerializableReference>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') → [ExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference 'DiGi\.Core\.Classes\.ExternalReference') → [DiGi\.Core\.Classes\.ExternalReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference_USerializableReference_ 'DiGi\.Core\.Classes\.ExternalReference\<USerializableReference\>')[IInstanceRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedSerializableReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedSerializableReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference_USerializableReference_ 'DiGi\.Core\.Classes\.ExternalReference\<USerializableReference\>') → [DiGi\.Core\.Classes\.InstanceRelatedExternalReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_ 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference\<TInstanceRelatedSerializableReference\>')[IInstanceRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedSerializableReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedSerializableReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_ 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference\<TInstanceRelatedSerializableReference\>') → InstanceRelatedExternalReference

### Example
Renders and parses \(via [TryParse\(this string, IReference\)](DiGi.Core.md#DiGi.Core.Query.TryParse(thisstring,DiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.TryParse\(this string, DiGi\.Core\.Interfaces\.IReference\)')\) as the discriminator, the
source, then the nested instance\-related reference:

```csharp
InstanceExternal::Revit::(Guid::(Type::DiGi.GIS.Classes.Building2D,DiGi.GIS)::0f8fad5bd9cb469fa16570867728950e)
```
### Constructors

<a name='DiGi.Core.Classes.InstanceRelatedExternalReference.InstanceRelatedExternalReference(DiGi.Core.Classes.InstanceRelatedExternalReference)'></a>

## InstanceRelatedExternalReference\(InstanceRelatedExternalReference\) Constructor

Initializes a new instance of the [InstanceRelatedExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference') class by copying an existing reference\.

```csharp
public InstanceRelatedExternalReference(DiGi.Core.Classes.InstanceRelatedExternalReference? externalReference);
```
#### Parameters

<a name='DiGi.Core.Classes.InstanceRelatedExternalReference.InstanceRelatedExternalReference(DiGi.Core.Classes.InstanceRelatedExternalReference).externalReference'></a>

`externalReference` [InstanceRelatedExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference')

The existing reference to copy\.

<a name='DiGi.Core.Classes.InstanceRelatedExternalReference.InstanceRelatedExternalReference(string,DiGi.Core.Interfaces.IInstanceRelatedSerializableReference)'></a>

## InstanceRelatedExternalReference\(string, IInstanceRelatedSerializableReference\) Constructor

Initializes a new instance of the [InstanceRelatedExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference') class with the specified source and interface\-based reference\.

```csharp
public InstanceRelatedExternalReference(string? source, DiGi.Core.Interfaces.IInstanceRelatedSerializableReference? reference);
```
#### Parameters

<a name='DiGi.Core.Classes.InstanceRelatedExternalReference.InstanceRelatedExternalReference(string,DiGi.Core.Interfaces.IInstanceRelatedSerializableReference).source'></a>

`source` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The source string\.

<a name='DiGi.Core.Classes.InstanceRelatedExternalReference.InstanceRelatedExternalReference(string,DiGi.Core.Interfaces.IInstanceRelatedSerializableReference).reference'></a>

`reference` [IInstanceRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedSerializableReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedSerializableReference')

The interface\-based reference\.

<a name='DiGi.Core.Classes.InstanceRelatedExternalReference.InstanceRelatedExternalReference(System.Text.Json.Nodes.JsonObject)'></a>

## InstanceRelatedExternalReference\(JsonObject\) Constructor

Initializes a new instance of the [InstanceRelatedExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference') class from the specified JSON object\.

```csharp
public InstanceRelatedExternalReference(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.InstanceRelatedExternalReference.InstanceRelatedExternalReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.

<a name='DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_'></a>

## InstanceRelatedExternalReference\<TInstanceRelatedSerializableReference\> Class

Represents an abstract base class for external references related to a specific instance\.

```csharp
public abstract class InstanceRelatedExternalReference<TInstanceRelatedSerializableReference> : DiGi.Core.Classes.ExternalReference<TInstanceRelatedSerializableReference>
    where TInstanceRelatedSerializableReference : DiGi.Core.Interfaces.IInstanceRelatedSerializableReference
```
#### Type parameters

<a name='DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_.TInstanceRelatedSerializableReference'></a>

`TInstanceRelatedSerializableReference`

The type of the serializable reference related to the instance\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') → [ExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference 'DiGi\.Core\.Classes\.ExternalReference') → [DiGi\.Core\.Classes\.ExternalReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference_USerializableReference_ 'DiGi\.Core\.Classes\.ExternalReference\<USerializableReference\>')[TInstanceRelatedSerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_.TInstanceRelatedSerializableReference 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference\<TInstanceRelatedSerializableReference\>\.TInstanceRelatedSerializableReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference_USerializableReference_ 'DiGi\.Core\.Classes\.ExternalReference\<USerializableReference\>') → InstanceRelatedExternalReference\<TInstanceRelatedSerializableReference\>

Derived  
↳ [InstanceRelatedExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference')  
↳ [UniqueExternalReference&lt;TUniqueReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_ 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>')
### Constructors

<a name='DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_.InstanceRelatedExternalReference(DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_)'></a>

## InstanceRelatedExternalReference\(InstanceRelatedExternalReference\<TInstanceRelatedSerializableReference\>\) Constructor

Initializes a new instance of the [InstanceRelatedExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference') class by copying an existing generic reference\.

```csharp
public InstanceRelatedExternalReference(DiGi.Core.Classes.InstanceRelatedExternalReference<TInstanceRelatedSerializableReference>? externalReference);
```
#### Parameters

<a name='DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_.InstanceRelatedExternalReference(DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_).externalReference'></a>

`externalReference` [DiGi\.Core\.Classes\.InstanceRelatedExternalReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_ 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference\<TInstanceRelatedSerializableReference\>')[TInstanceRelatedSerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_.TInstanceRelatedSerializableReference 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference\<TInstanceRelatedSerializableReference\>\.TInstanceRelatedSerializableReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_ 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference\<TInstanceRelatedSerializableReference\>')

The existing generic reference to copy\.

<a name='DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_.InstanceRelatedExternalReference(string,TInstanceRelatedSerializableReference)'></a>

## InstanceRelatedExternalReference\(string, TInstanceRelatedSerializableReference\) Constructor

Initializes a new instance of the [InstanceRelatedExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference') class with the specified source and reference\.

```csharp
public InstanceRelatedExternalReference(string? source, TInstanceRelatedSerializableReference? reference);
```
#### Parameters

<a name='DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_.InstanceRelatedExternalReference(string,TInstanceRelatedSerializableReference).source'></a>

`source` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The source string\.

<a name='DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_.InstanceRelatedExternalReference(string,TInstanceRelatedSerializableReference).reference'></a>

`reference` [TInstanceRelatedSerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_.TInstanceRelatedSerializableReference 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference\<TInstanceRelatedSerializableReference\>\.TInstanceRelatedSerializableReference')

The related serializable reference\.

<a name='DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_.InstanceRelatedExternalReference(System.Text.Json.Nodes.JsonObject)'></a>

## InstanceRelatedExternalReference\(JsonObject\) Constructor

Initializes a new instance of the [InstanceRelatedExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference') class from the specified JSON object\.

```csharp
public InstanceRelatedExternalReference(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_.InstanceRelatedExternalReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_'></a>

## List\<TKey\_1,TKey\_2,TValue\> Class

Represents a base abstract list implementation\.

```csharp
public abstract class List<TKey_1,TKey_2,TValue> : DiGi.Core.Classes.Cluster<TKey_1, TKey_2, TValue>
```
#### Type parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_1'></a>

`TKey_1`

The type of the first primary key\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_2'></a>

`TKey_2`

The type of the second primary key\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TValue'></a>

`TValue`

The type of values contained in the list\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Cluster&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')[TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')[TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>') → List\<TKey\_1,TKey\_2,TValue\>

Derived  
↳ [SerializableObjectListCluster&lt;TKey\_1,TKey\_2,TValue&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>')
### Constructors

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.List()'></a>

## List\(\) Constructor

Initializes a new instance of the List class\.

```csharp
public List();
```

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.List(DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_)'></a>

## List\(List\<TKey\_1,TKey\_2,TValue\>\) Constructor

Initializes a new instance of the List class from an existing value cluster\.

```csharp
public List(DiGi.Core.Classes.List<TKey_1,TKey_2,TValue>? valueCluster);
```
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.List(DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_).valueCluster'></a>

`valueCluster` [DiGi\.Core\.Classes\.List&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>')[TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>')[TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>')

The existing value cluster to initialize the list from\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.List(System.Collections.Generic.IEnumerable_TValue_)'></a>

## List\(IEnumerable\<TValue\>\) Constructor

Initializes a new instance of the List class using the specified collection of values\.

```csharp
public List(System.Collections.Generic.IEnumerable<TValue>? values);
```
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.List(System.Collections.Generic.IEnumerable_TValue_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of values used to initialize the list\.
### Methods

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Add(TValue)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.Add\(TValue\) Method

Adds the specified value to the value cluster\.

```csharp
public override bool Add(TValue? value);
```
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Add(TValue).value'></a>

`value` [TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TValue')

The value to add to the cluster\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the element is successfully added; otherwise, false\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Clear()'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.Clear\(\) Method

Removes all elements from the value cluster\.

```csharp
public override void Clear();
```

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Contains(TKey_1)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.Contains\(TKey\_1\) Method

Determines whether the cluster contains an element with the specified primary key\.

```csharp
public override bool Contains(TKey_1? key_1);
```
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Contains(TKey_1).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The primary key to locate in the cluster\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the cluster contains an element with the specified primary key; otherwise, false\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Contains(TKey_1,TKey_2)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.Contains\(TKey\_1, TKey\_2\) Method

Determines whether the cluster contains an element with the specified combination of keys\.

```csharp
public override bool Contains(TKey_1? key_1, TKey_2? key_2);
```
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Contains(TKey_1,TKey_2).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The first key to search for\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Contains(TKey_1,TKey_2).key_2'></a>

`key_2` [TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')

The second key to search for\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the cluster contains an element with the specified keys; otherwise, false\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Contains(TValue)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.Contains\(TValue\) Method

Determines whether the cluster contains a specific value\.

```csharp
public override bool Contains(TValue? value);
```
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Contains(TValue).value'></a>

`value` [TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TValue')

The value to locate in the cluster\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the cluster contains the specified value; otherwise, false\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Equals(TValue,TValue)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.Equals\(TValue, TValue\) Method

Determines whether two specified values are equal\.

```csharp
public virtual bool Equals(TValue? value_1, TValue? value_2);
```
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Equals(TValue,TValue).value_1'></a>

`value_1` [TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TValue')

The first value to compare\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Equals(TValue,TValue).value_2'></a>

`value_2` [TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TValue')

The second value to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified values are equal; otherwise, false\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetEnumerator()'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the cluster values\.

```csharp
public override System.Collections.Generic.IEnumerator<TValue> GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator 'System\.Collections\.Generic\.IEnumerable\`1\.GetEnumerator'), [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

#### Returns
[System\.Collections\.Generic\.IEnumerator&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')  
An enumerator for the cluster values\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetIndexes_UValue_(TKey_1,TKey_2,System.Func_UValue,bool_)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.GetIndexes\<UValue\>\(TKey\_1, TKey\_2, Func\<UValue,bool\>\) Method

Retrieves the indexes of elements that match the specified keys and predicate\.

```csharp
public virtual System.Collections.Generic.List<int>? GetIndexes<UValue>(TKey_1? key_1, TKey_2? key_2, System.Func<UValue?,bool>? func)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetIndexes_UValue_(TKey_1,TKey_2,System.Func_UValue,bool_).UValue'></a>

`UValue`

The type of the value being evaluated by the predicate\.
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetIndexes_UValue_(TKey_1,TKey_2,System.Func_UValue,bool_).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The first key to search for\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetIndexes_UValue_(TKey_1,TKey_2,System.Func_UValue,bool_).key_2'></a>

`key_2` [TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')

The second key to search for\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetIndexes_UValue_(TKey_1,TKey_2,System.Func_UValue,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetIndexes_UValue_(TKey_1,TKey_2,System.Func_UValue,bool_).UValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.GetIndexes\<UValue\>\(TKey\_1, TKey\_2, System\.Func\<UValue,bool\>\)\.UValue')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

A predicate function used to filter elements based on their value\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of indexes that match the criteria, or null if no matches are found\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetKeys_1()'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.GetKeys\_1\(\) Method

Returns a list of all primary keys in the cluster\.

```csharp
public override System.Collections.Generic.List<TKey_1>? GetKeys_1();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing all primary keys, or null if none exist\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetKeys_2(TKey_1)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.GetKeys\_2\(TKey\_1\) Method

Returns a list of secondary keys associated with the specified primary key\.

```csharp
public override System.Collections.Generic.List<TKey_2>? GetKeys_2(TKey_1? key_1);
```
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetKeys_2(TKey_1).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The primary key used to retrieve the secondary keys\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of secondary keys associated with the specified primary key, or null if none are found\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValue_UValue_(DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.GetValue\<UValue\>\(ListClusterReference\<TKey\_1,TKey\_2\>\) Method

Retrieves a value using the provided cluster reference\.

```csharp
public UValue? GetValue<UValue>(DiGi.Core.Classes.ListClusterReference<TKey_1,TKey_2>? listClusterReference)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValue_UValue_(DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_).UValue'></a>

`UValue`

The type of value to retrieve\.
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValue_UValue_(DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_).listClusterReference'></a>

`listClusterReference` [DiGi\.Core\.Classes\.ListClusterReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_ 'DiGi\.Core\.Classes\.ListClusterReference\<TKey\_1,TKey\_2\>')[TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_ 'DiGi\.Core\.Classes\.ListClusterReference\<TKey\_1,TKey\_2\>')[TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_ 'DiGi\.Core\.Classes\.ListClusterReference\<TKey\_1,TKey\_2\>')

The cluster reference used to locate the value\.

#### Returns
[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValue_UValue_(DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_).UValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.GetValue\<UValue\>\(DiGi\.Core\.Classes\.ListClusterReference\<TKey\_1,TKey\_2\>\)\.UValue')  
The retrieved value, or null if not found\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValue_UValue_(System.Func_UValue,bool_)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.GetValue\<UValue\>\(Func\<UValue,bool\>\) Method

Retrieves the first value that satisfies the specified predicate\.

```csharp
public override UValue? GetValue<UValue>(System.Func<UValue?,bool>? func)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValue_UValue_(System.Func_UValue,bool_).UValue'></a>

`UValue`

The type of value to retrieve\.
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValue_UValue_(System.Func_UValue,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValue_UValue_(System.Func_UValue,bool_).UValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.GetValue\<UValue\>\(System\.Func\<UValue,bool\>\)\.UValue')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

A predicate function used to find a matching value\.

#### Returns
[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValue_UValue_(System.Func_UValue,bool_).UValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.GetValue\<UValue\>\(System\.Func\<UValue,bool\>\)\.UValue')  
The first value that satisfies the predicate, or null if no match is found\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_()'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.GetValues\<UValue\>\(\) Method

Returns all values contained in the list\.

```csharp
public override System.Collections.Generic.List<UValue> GetValues<UValue>()
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_().UValue'></a>

`UValue`

The type of values stored in the list\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_().UValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.GetValues\<UValue\>\(\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing all values currently held in the cluster\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2__)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.GetValues\<UValue\>\(IEnumerable\<ListClusterReference\<TKey\_1,TKey\_2\>\>\) Method

Retrieves values associated with a collection of cluster references\.

```csharp
public System.Collections.Generic.List<UValue>? GetValues<UValue>(System.Collections.Generic.IEnumerable<DiGi.Core.Classes.ListClusterReference<TKey_1,TKey_2>>? listClusterReferences)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2__).UValue'></a>

`UValue`

The type of values being retrieved\.
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2__).listClusterReferences'></a>

`listClusterReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.ListClusterReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_ 'DiGi\.Core\.Classes\.ListClusterReference\<TKey\_1,TKey\_2\>')[TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_ 'DiGi\.Core\.Classes\.ListClusterReference\<TKey\_1,TKey\_2\>')[TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_ 'DiGi\.Core\.Classes\.ListClusterReference\<TKey\_1,TKey\_2\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of cluster references to retrieve values for\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2__).UValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.GetValues\<UValue\>\(System\.Collections\.Generic\.IEnumerable\<DiGi\.Core\.Classes\.ListClusterReference\<TKey\_1,TKey\_2\>\>\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of retrieved values, or null if no values were found\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.GetValues\<UValue\>\(TKey\_1\) Method

Retrieves all values associated with the specified primary key\.

```csharp
public override System.Collections.Generic.List<UValue>? GetValues<UValue>(TKey_1? key_1)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1).UValue'></a>

`UValue`

The type of value to retrieve\.
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The primary key used for lookup\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1).UValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.GetValues\<UValue\>\(TKey\_1\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of values associated with the specified primary key, or null if none are found\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1,TKey_2,System.Collections.Generic.IEnumerable_int_)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.GetValues\<UValue\>\(TKey\_1, TKey\_2, IEnumerable\<int\>\) Method

Retrieves values at the specified indexes for the given keys\.

```csharp
public System.Collections.Generic.List<UValue>? GetValues<UValue>(TKey_1? key_1, TKey_2? key_2, System.Collections.Generic.IEnumerable<int> indexes)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1,TKey_2,System.Collections.Generic.IEnumerable_int_).UValue'></a>

`UValue`

The type of values being retrieved\.
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1,TKey_2,System.Collections.Generic.IEnumerable_int_).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The primary key used to locate the cluster\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1,TKey_2,System.Collections.Generic.IEnumerable_int_).key_2'></a>

`key_2` [TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')

The secondary key used to locate the element within the cluster\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1,TKey_2,System.Collections.Generic.IEnumerable_int_).indexes'></a>

`indexes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of indexes from which to retrieve values\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1,TKey_2,System.Collections.Generic.IEnumerable_int_).UValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.GetValues\<UValue\>\(TKey\_1, TKey\_2, System\.Collections\.Generic\.IEnumerable\<int\>\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of values found at the specified indexes, or null if no values were found\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1,TKey_2,System.Func_UValue,bool_)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.GetValues\<UValue\>\(TKey\_1, TKey\_2, Func\<UValue,bool\>\) Method

Retrieves values that match the specified keys and predicate\.

```csharp
public System.Collections.Generic.List<UValue>? GetValues<UValue>(TKey_1? key_1, TKey_2? key_2, System.Func<UValue?,bool> func)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1,TKey_2,System.Func_UValue,bool_).UValue'></a>

`UValue`

The type of value to retrieve\.
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1,TKey_2,System.Func_UValue,bool_).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The first key used for lookup\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1,TKey_2,System.Func_UValue,bool_).key_2'></a>

`key_2` [TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')

The second key used for lookup\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1,TKey_2,System.Func_UValue,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1,TKey_2,System.Func_UValue,bool_).UValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.GetValues\<UValue\>\(TKey\_1, TKey\_2, System\.Func\<UValue,bool\>\)\.UValue')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

A predicate function to filter the values\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.GetValues_UValue_(TKey_1,TKey_2,System.Func_UValue,bool_).UValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.GetValues\<UValue\>\(TKey\_1, TKey\_2, System\.Func\<UValue,bool\>\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of values that match the specified keys and predicate, or null if none are found\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Remove(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2__)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.Remove\(IEnumerable\<ListClusterReference\<TKey\_1,TKey\_2\>\>\) Method

Removes and returns values associated with the specified cluster references\.

```csharp
public System.Collections.Generic.List<TValue>? Remove(System.Collections.Generic.IEnumerable<DiGi.Core.Classes.ListClusterReference<TKey_1,TKey_2>>? listClusterReferences);
```
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Remove(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2__).listClusterReferences'></a>

`listClusterReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.ListClusterReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_ 'DiGi\.Core\.Classes\.ListClusterReference\<TKey\_1,TKey\_2\>')[TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_ 'DiGi\.Core\.Classes\.ListClusterReference\<TKey\_1,TKey\_2\>')[TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_ 'DiGi\.Core\.Classes\.ListClusterReference\<TKey\_1,TKey\_2\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of cluster references to remove\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of removed values, or null if no values were found for the provided references\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Remove(TKey_1)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.Remove\(TKey\_1\) Method

Removes all elements associated with the specified primary key from the cluster\.

```csharp
public override bool Remove(TKey_1? key_1);
```
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Remove(TKey_1).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The primary key of the elements to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more elements were removed; otherwise, false\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Remove(TKey_1,TKey_2)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.Remove\(TKey\_1, TKey\_2\) Method

Removes the element associated with the specified combination of keys from the cluster\.

```csharp
public override bool Remove(TKey_1? key_1, TKey_2? key_2);
```
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Remove(TKey_1,TKey_2).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The primary key of the element to remove\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Remove(TKey_1,TKey_2).key_2'></a>

`key_2` [TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')

The secondary key of the element to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the element was successfully removed; otherwise, false\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Remove(TKey_1,TKey_2,int)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.Remove\(TKey\_1, TKey\_2, int\) Method

Removes and returns the value at the specified index for the given keys\.

```csharp
public TValue? Remove(TKey_1? key_1, TKey_2? key_2, int index);
```
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Remove(TKey_1,TKey_2,int).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The primary key associated with the value to remove\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Remove(TKey_1,TKey_2,int).key_2'></a>

`key_2` [TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')

The secondary key associated with the value to remove\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Remove(TKey_1,TKey_2,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the value to remove\.

#### Returns
[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TValue')  
The removed value, or the default value of TValue if the element was not found\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Remove(TKey_1,TKey_2,System.Collections.Generic.IEnumerable_int_)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.Remove\(TKey\_1, TKey\_2, IEnumerable\<int\>\) Method

Removes and returns values at the specified indexes for the given keys\.

```csharp
public System.Collections.Generic.List<TValue>? Remove(TKey_1? key_1, TKey_2? key_2, System.Collections.Generic.IEnumerable<int> indexes);
```
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Remove(TKey_1,TKey_2,System.Collections.Generic.IEnumerable_int_).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The primary key associated with the values to remove\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Remove(TKey_1,TKey_2,System.Collections.Generic.IEnumerable_int_).key_2'></a>

`key_2` [TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')

The secondary key associated with the values to remove\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Remove(TKey_1,TKey_2,System.Collections.Generic.IEnumerable_int_).indexes'></a>

`indexes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of indexes specifying which values to remove\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the removed values, or null if no values were removed\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Remove(TValue)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.Remove\(TValue\) Method

Removes the first occurrence of a specific value from the cluster\.

```csharp
public override bool Remove(TValue? value);
```
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.Remove(TValue).value'></a>

`value` [TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TValue')

The value to remove from the cluster\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully removed; otherwise, false\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TryGetIndex(TValue,TKey_1,TKey_2,int)'></a>

## List\<TKey\_1,TKey\_2,TValue\>\.TryGetIndex\(TValue, TKey\_1, TKey\_2, int\) Method

Attempts to find the primary key, secondary key, and index of a specific value\.

```csharp
public bool TryGetIndex(TValue? value, out TKey_1? key_1, out TKey_2? key_2, out int index);
```
#### Parameters

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TryGetIndex(TValue,TKey_1,TKey_2,int).value'></a>

`value` [TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TValue')

The value to locate in the cluster\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TryGetIndex(TValue,TKey_1,TKey_2,int).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

When this method returns, contains the primary key associated with the specified value, if found; otherwise, the default value of TKey\_1\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TryGetIndex(TValue,TKey_1,TKey_2,int).key_2'></a>

`key_2` [TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')

When this method returns, contains the secondary key associated with the specified value, if found; otherwise, the default value of TKey\_2\.

<a name='DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_.TryGetIndex(TValue,TKey_1,TKey_2,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

When this method returns, contains the index of the specified value, if found; otherwise, 0\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the primary key, secondary key, and index were found; otherwise, false\.

<a name='DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_'></a>

## ListClusterReference\<TKey\_1,TKey\_2\> Class

Provides an abstract base class for references to elements within a list cluster\.

```csharp
public abstract class ListClusterReference<TKey_1,TKey_2> : DiGi.Core.Interfaces.IReference, DiGi.Core.Interfaces.IObject, System.IEquatable<DiGi.Core.Interfaces.IReference>
```
#### Type parameters

<a name='DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_.TKey_1'></a>

`TKey_1`

The type of the first key\.

<a name='DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_.TKey_2'></a>

`TKey_2`

The type of the second key\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → ListClusterReference\<TKey\_1,TKey\_2\>

Implements [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')
### Constructors

<a name='DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_.ListClusterReference(TKey_1,TKey_2,int)'></a>

## ListClusterReference\(TKey\_1, TKey\_2, int\) Constructor

Provides an abstract base class for references to elements within a list cluster\.

```csharp
protected ListClusterReference(TKey_1? key_1, TKey_2? key_2, int index);
```
#### Parameters

<a name='DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_.ListClusterReference(TKey_1,TKey_2,int).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_.TKey_1 'DiGi\.Core\.Classes\.ListClusterReference\<TKey\_1,TKey\_2\>\.TKey\_1')

<a name='DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_.ListClusterReference(TKey_1,TKey_2,int).key_2'></a>

`key_2` [TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_.TKey_2 'DiGi\.Core\.Classes\.ListClusterReference\<TKey\_1,TKey\_2\>\.TKey\_2')

<a name='DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_.ListClusterReference(TKey_1,TKey_2,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')
### Properties

<a name='DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_.Index'></a>

## ListClusterReference\<TKey\_1,TKey\_2\>\.Index Property

Gets or sets the index of the reference within the list cluster\.

```csharp
public int Index { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_.Key_1'></a>

## ListClusterReference\<TKey\_1,TKey\_2\>\.Key\_1 Property

Gets or sets the primary key associated with the reference\.

```csharp
public TKey_1? Key_1 { get; }
```

#### Property Value
[TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_.TKey_1 'DiGi\.Core\.Classes\.ListClusterReference\<TKey\_1,TKey\_2\>\.TKey\_1')

<a name='DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_.Key_2'></a>

## ListClusterReference\<TKey\_1,TKey\_2\>\.Key\_2 Property

Gets or sets the secondary key associated with the reference\.

```csharp
public TKey_2? Key_2 { get; }
```

#### Property Value
[TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_.TKey_2 'DiGi\.Core\.Classes\.ListClusterReference\<TKey\_1,TKey\_2\>\.TKey\_2')
### Methods

<a name='DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_.Equals(DiGi.Core.Interfaces.IReference)'></a>

## ListClusterReference\<TKey\_1,TKey\_2\>\.Equals\(IReference\) Method

Determines whether the specified reference is equal to the current reference\.

```csharp
public abstract bool Equals(DiGi.Core.Interfaces.IReference reference);
```
#### Parameters

<a name='DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_.Equals(DiGi.Core.Interfaces.IReference).reference'></a>

`reference` [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')

The reference to compare with the current reference\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
true if the specified reference is equal to the current reference; otherwise, false\.

<a name='DiGi.Core.Classes.LongProgressWrapper'></a>

## LongProgressWrapper Class

Wraps progress reporting for long values\.

```csharp
public class LongProgressWrapper : DiGi.Core.Classes.ProgressWrapper<long>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.ProgressWrapper&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ProgressWrapper_T_ 'DiGi\.Core\.Classes\.ProgressWrapper\<T\>')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ProgressWrapper_T_ 'DiGi\.Core\.Classes\.ProgressWrapper\<T\>') → LongProgressWrapper
### Constructors

<a name='DiGi.Core.Classes.LongProgressWrapper.LongProgressWrapper(long,System.IProgress_long_)'></a>

## LongProgressWrapper\(long, IProgress\<long\>\) Constructor

Initializes a new instance of the [LongProgressWrapper](DiGi.Core.Classes.md#DiGi.Core.Classes.LongProgressWrapper 'DiGi\.Core\.Classes\.LongProgressWrapper') class with an initial value\.

```csharp
public LongProgressWrapper(long initialValue, System.IProgress<long>? progress=null);
```
#### Parameters

<a name='DiGi.Core.Classes.LongProgressWrapper.LongProgressWrapper(long,System.IProgress_long_).initialValue'></a>

`initialValue` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The initial progress value\.

<a name='DiGi.Core.Classes.LongProgressWrapper.LongProgressWrapper(long,System.IProgress_long_).progress'></a>

`progress` [System\.IProgress&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1 'System\.IProgress\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1 'System\.IProgress\`1')

An optional progress reporter\.

<a name='DiGi.Core.Classes.LongProgressWrapper.LongProgressWrapper(System.IProgress_long_)'></a>

## LongProgressWrapper\(IProgress\<long\>\) Constructor

Initializes a new instance of the [LongProgressWrapper](DiGi.Core.Classes.md#DiGi.Core.Classes.LongProgressWrapper 'DiGi\.Core\.Classes\.LongProgressWrapper') class\.

```csharp
public LongProgressWrapper(System.IProgress<long>? progress=null);
```
#### Parameters

<a name='DiGi.Core.Classes.LongProgressWrapper.LongProgressWrapper(System.IProgress_long_).progress'></a>

`progress` [System\.IProgress&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1 'System\.IProgress\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1 'System\.IProgress\`1')

An optional progress reporter\.
### Methods

<a name='DiGi.Core.Classes.LongProgressWrapper.Increment(long)'></a>

## LongProgressWrapper\.Increment\(long\) Method

Increments the current progress value and reports the update\.

```csharp
public long Increment(long value);
```
#### Parameters

<a name='DiGi.Core.Classes.LongProgressWrapper.Increment(long).value'></a>

`value` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The amount to increment by\.

#### Returns
[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')  
The updated progress value\.

<a name='DiGi.Core.Classes.MemorySizeSplitter_TSerializableObject_'></a>

## MemorySizeSplitter\<TSerializableObject\> Class

Splits serializable objects by their serialized byte array size\.

```csharp
public class MemorySizeSplitter<TSerializableObject> : DiGi.Core.Classes.Splitter<TSerializableObject, long>
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Core.Classes.MemorySizeSplitter_TSerializableObject_.TSerializableObject'></a>

`TSerializableObject`

The type of the serializable object\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Splitter&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Splitter_T,X_ 'DiGi\.Core\.Classes\.Splitter\<T,X\>')[TSerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.MemorySizeSplitter_TSerializableObject_.TSerializableObject 'DiGi\.Core\.Classes\.MemorySizeSplitter\<TSerializableObject\>\.TSerializableObject')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.Splitter_T,X_ 'DiGi\.Core\.Classes\.Splitter\<T,X\>')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Splitter_T,X_ 'DiGi\.Core\.Classes\.Splitter\<T,X\>') → MemorySizeSplitter\<TSerializableObject\>
### Constructors

<a name='DiGi.Core.Classes.MemorySizeSplitter_TSerializableObject_.MemorySizeSplitter(System.Collections.Generic.IEnumerable_TSerializableObject_)'></a>

## MemorySizeSplitter\(IEnumerable\<TSerializableObject\>\) Constructor

Initializes a new instance of the [MemorySizeSplitter&lt;TSerializableObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.MemorySizeSplitter_TSerializableObject_ 'DiGi\.Core\.Classes\.MemorySizeSplitter\<TSerializableObject\>') class\.

```csharp
public MemorySizeSplitter(System.Collections.Generic.IEnumerable<TSerializableObject> serializableObjects);
```
#### Parameters

<a name='DiGi.Core.Classes.MemorySizeSplitter_TSerializableObject_.MemorySizeSplitter(System.Collections.Generic.IEnumerable_TSerializableObject_).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TSerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.MemorySizeSplitter_TSerializableObject_.TSerializableObject 'DiGi\.Core\.Classes\.MemorySizeSplitter\<TSerializableObject\>\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of serializable objects to be split\.
### Methods

<a name='DiGi.Core.Classes.MemorySizeSplitter_TSerializableObject_.GetValue(TSerializableObject)'></a>

## MemorySizeSplitter\<TSerializableObject\>\.GetValue\(TSerializableObject\) Method

Gets the memory size value for the specified serializable object\.

```csharp
public override long GetValue(TSerializableObject? serializableObject);
```
#### Parameters

<a name='DiGi.Core.Classes.MemorySizeSplitter_TSerializableObject_.GetValue(TSerializableObject).serializableObject'></a>

`serializableObject` [TSerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.MemorySizeSplitter_TSerializableObject_.TSerializableObject 'DiGi\.Core\.Classes\.MemorySizeSplitter\<TSerializableObject\>\.TSerializableObject')

The serializable object to get the memory size value for\.

#### Returns
[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')  
The memory size value of the specified serializable object\.

<a name='DiGi.Core.Classes.MultiUpdater_TValue_'></a>

## MultiUpdater\<TValue\> Class

Class MultiUpdater\.

```csharp
public class MultiUpdater<TValue> : DiGi.Core.Interfaces.IUpdater<TValue>, DiGi.Core.Interfaces.IUpdater, DiGi.Core.Interfaces.IEvaluator
```
#### Type parameters

<a name='DiGi.Core.Classes.MultiUpdater_TValue_.TValue'></a>

`TValue`

The type of value handled by the MultiUpdater\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → MultiUpdater\<TValue\>

Implements [DiGi\.Core\.Interfaces\.IUpdater&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUpdater_TValue_ 'DiGi\.Core\.Interfaces\.IUpdater\<TValue\>')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.MultiUpdater_TValue_.TValue 'DiGi\.Core\.Classes\.MultiUpdater\<TValue\>\.TValue')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUpdater_TValue_ 'DiGi\.Core\.Interfaces\.IUpdater\<TValue\>'), [IUpdater](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUpdater 'DiGi\.Core\.Interfaces\.IUpdater'), [IEvaluator](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IEvaluator 'DiGi\.Core\.Interfaces\.IEvaluator')
### Constructors

<a name='DiGi.Core.Classes.MultiUpdater_TValue_.MultiUpdater(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUpdater_)'></a>

## MultiUpdater\(IEnumerable\<IUpdater\>\) Constructor

Initializes a new instance of the [MultiUpdater&lt;TValue&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.MultiUpdater_TValue_ 'DiGi\.Core\.Classes\.MultiUpdater\<TValue\>') class using a collection of updaters\.

```csharp
public MultiUpdater(System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUpdater> updaters);
```
#### Parameters

<a name='DiGi.Core.Classes.MultiUpdater_TValue_.MultiUpdater(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUpdater_).updaters'></a>

`updaters` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[IUpdater](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUpdater 'DiGi\.Core\.Interfaces\.IUpdater')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of updaters to initialize the MultiUpdater with\.
### Properties

<a name='DiGi.Core.Classes.MultiUpdater_TValue_.Value'></a>

## MultiUpdater\<TValue\>\.Value Property

Gets the current value associated with the updater\.

```csharp
public TValue? Value { get; set; }
```

Implements [Value](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUpdater_TValue_.Value 'DiGi\.Core\.Interfaces\.IUpdater\<TValue\>\.Value')

#### Property Value
[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.MultiUpdater_TValue_.TValue 'DiGi\.Core\.Classes\.MultiUpdater\<TValue\>\.TValue')
### Methods

<a name='DiGi.Core.Classes.MultiUpdater_TValue_.Update()'></a>

## MultiUpdater\<TValue\>\.Update\(\) Method

Performs an update operation and returns whether any changes were made\.

```csharp
public bool Update();
```

Implements [Update\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUpdater.Update() 'DiGi\.Core\.Interfaces\.IUpdater\.Update\(\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if any changes were made; otherwise, false\.

<a name='DiGi.Core.Classes.MultiUpdater_TValue_.Update(bool[])'></a>

## MultiUpdater\<TValue\>\.Update\(bool\[\]\) Method

Performs an update operation and returns a boolean array indicating which specific updaters were modified\.

```csharp
public bool Update(out bool[]? updated);
```
#### Parameters

<a name='DiGi.Core.Classes.MultiUpdater_TValue_.Update(bool[]).updated'></a>

`updated` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

When this method returns, contains a boolean array indicating which specific updaters were modified\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the update operation was successful; otherwise, false\.

<a name='DiGi.Core.Classes.Object'></a>

## Object Class

Base abstract class for all domain objects within DiGi\.Core\.

```csharp
public abstract class Object : DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Object

Derived  
↳ [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject')

Implements [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Classes.Object.Object()'></a>

## Object\(\) Constructor

Initializes a new instance of the Object class\.

```csharp
public Object();
```

<a name='DiGi.Core.Classes.ObjectPath'></a>

## ObjectPath Class

Represents a hierarchical path to an object\.

```csharp
public class ObjectPath : DiGi.Core.Classes.ObjectPath<DiGi.Core.Classes.ObjectPath>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.ObjectPath&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath_TObjectPath_ 'DiGi\.Core\.Classes\.ObjectPath\<TObjectPath\>')[ObjectPath](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath 'DiGi\.Core\.Classes\.ObjectPath')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath_TObjectPath_ 'DiGi\.Core\.Classes\.ObjectPath\<TObjectPath\>') → ObjectPath
### Constructors

<a name='DiGi.Core.Classes.ObjectPath.ObjectPath(string)'></a>

## ObjectPath\(string\) Constructor

Initializes a new instance of the [ObjectPath](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath 'DiGi\.Core\.Classes\.ObjectPath') class with a single segment name\.

```csharp
public ObjectPath(string name);
```
#### Parameters

<a name='DiGi.Core.Classes.ObjectPath.ObjectPath(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the path segment\.

<a name='DiGi.Core.Classes.ObjectPath.ObjectPath(string,DiGi.Core.Classes.ObjectPath)'></a>

## ObjectPath\(string, ObjectPath\) Constructor

Initializes a new instance of the [ObjectPath](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath 'DiGi\.Core\.Classes\.ObjectPath') class by appending a name to an existing path\.

```csharp
public ObjectPath(string name, DiGi.Core.Classes.ObjectPath path);
```
#### Parameters

<a name='DiGi.Core.Classes.ObjectPath.ObjectPath(string,DiGi.Core.Classes.ObjectPath).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the segment to append\.

<a name='DiGi.Core.Classes.ObjectPath.ObjectPath(string,DiGi.Core.Classes.ObjectPath).path'></a>

`path` [ObjectPath](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath 'DiGi\.Core\.Classes\.ObjectPath')

The existing path to which the name is appended\.

<a name='DiGi.Core.Classes.ObjectPath.ObjectPath(System.Collections.Generic.IEnumerable_string_)'></a>

## ObjectPath\(IEnumerable\<string\>\) Constructor

Initializes a new instance of the [ObjectPath](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath 'DiGi\.Core\.Classes\.ObjectPath') class using a collection of segment names\.

```csharp
public ObjectPath(System.Collections.Generic.IEnumerable<string> names);
```
#### Parameters

<a name='DiGi.Core.Classes.ObjectPath.ObjectPath(System.Collections.Generic.IEnumerable_string_).names'></a>

`names` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segment names to include in the path\.

<a name='DiGi.Core.Classes.ObjectPath.ObjectPath(System.Text.Json.Nodes.JsonObject)'></a>

## ObjectPath\(JsonObject\) Constructor

Initializes a new instance of the [ObjectPath](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath 'DiGi\.Core\.Classes\.ObjectPath') class from a JSON object\.

```csharp
public ObjectPath(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.ObjectPath.ObjectPath(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the path\.

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_'></a>

## ObjectPath\<TObjectPath\> Class

Base class for representing a hierarchical path to an object\.

```csharp
public abstract class ObjectPath<TObjectPath> : DiGi.Core.Classes.SerializableObject, DiGi.Core.Interfaces.IObjectPath<TObjectPath>, DiGi.Core.Interfaces.IObjectPath, DiGi.Core.Interfaces.IObject
    where TObjectPath : DiGi.Core.Classes.ObjectPath<TObjectPath>
```
#### Type parameters

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.TObjectPath'></a>

`TObjectPath`

The type of the object path\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → ObjectPath\<TObjectPath\>

Derived  
↳ [CategoryPath](DiGi.Core.Classes.md#DiGi.Core.Classes.CategoryPath 'DiGi\.Core\.Classes\.CategoryPath')  
↳ [ObjectPath](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath 'DiGi\.Core\.Classes\.ObjectPath')

Implements [DiGi\.Core\.Interfaces\.IObjectPath&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObjectPath_T_ 'DiGi\.Core\.Interfaces\.IObjectPath\<T\>')[TObjectPath](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath_TObjectPath_.TObjectPath 'DiGi\.Core\.Classes\.ObjectPath\<TObjectPath\>\.TObjectPath')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObjectPath_T_ 'DiGi\.Core\.Interfaces\.IObjectPath\<T\>'), [IObjectPath](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObjectPath 'DiGi\.Core\.Interfaces\.IObjectPath'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.ObjectPath(DiGi.Core.Classes.ObjectPath_TObjectPath_)'></a>

## ObjectPath\(ObjectPath\<TObjectPath\>\) Constructor

Initializes a new instance of the [ObjectPath](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath 'DiGi\.Core\.Classes\.ObjectPath') class by copying an existing path\.

```csharp
public ObjectPath(DiGi.Core.Classes.ObjectPath<TObjectPath>? path);
```
#### Parameters

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.ObjectPath(DiGi.Core.Classes.ObjectPath_TObjectPath_).path'></a>

`path` [DiGi\.Core\.Classes\.ObjectPath&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath_TObjectPath_ 'DiGi\.Core\.Classes\.ObjectPath\<TObjectPath\>')[TObjectPath](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath_TObjectPath_.TObjectPath 'DiGi\.Core\.Classes\.ObjectPath\<TObjectPath\>\.TObjectPath')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath_TObjectPath_ 'DiGi\.Core\.Classes\.ObjectPath\<TObjectPath\>')

The existing path to copy\.

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.ObjectPath(string)'></a>

## ObjectPath\(string\) Constructor

Initializes a new instance of the [ObjectPath](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath 'DiGi\.Core\.Classes\.ObjectPath') class with a single segment name\.

```csharp
public ObjectPath(string? name);
```
#### Parameters

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.ObjectPath(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the single segment\.

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.ObjectPath(string,TObjectPath)'></a>

## ObjectPath\(string, TObjectPath\) Constructor

Initializes a new instance of the [ObjectPath](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath 'DiGi\.Core\.Classes\.ObjectPath') class by appending a name to an existing path\.

```csharp
public ObjectPath(string? name, TObjectPath? path);
```
#### Parameters

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.ObjectPath(string,TObjectPath).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the segment to append\.

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.ObjectPath(string,TObjectPath).path'></a>

`path` [TObjectPath](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath_TObjectPath_.TObjectPath 'DiGi\.Core\.Classes\.ObjectPath\<TObjectPath\>\.TObjectPath')

The existing path to which the name is appended\.

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.ObjectPath(System.Collections.Generic.IEnumerable_string_)'></a>

## ObjectPath\(IEnumerable\<string\>\) Constructor

Initializes a new instance of the [ObjectPath](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath 'DiGi\.Core\.Classes\.ObjectPath') class using a collection of segment names\.

```csharp
public ObjectPath(System.Collections.Generic.IEnumerable<string>? names);
```
#### Parameters

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.ObjectPath(System.Collections.Generic.IEnumerable_string_).names'></a>

`names` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segment names\.

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.ObjectPath(System.Text.Json.Nodes.JsonObject)'></a>

## ObjectPath\(JsonObject\) Constructor

Initializes a new instance of the [ObjectPath](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath 'DiGi\.Core\.Classes\.ObjectPath') class from a JSON object\.

```csharp
public ObjectPath(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.ObjectPath(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to create the path from\.
### Properties

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.Name'></a>

## ObjectPath\<TObjectPath\>\.Name Property

Gets the name of the current path segment\.

```csharp
public string Name { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.Path'></a>

## ObjectPath\<TObjectPath\>\.Path Property

Gets the parent path segment\.

```csharp
public TObjectPath? Path { get; set; }
```

#### Property Value
[TObjectPath](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath_TObjectPath_.TObjectPath 'DiGi\.Core\.Classes\.ObjectPath\<TObjectPath\>\.TObjectPath')

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.Separator'></a>

## ObjectPath\<TObjectPath\>\.Separator Property

Gets the character used to separate segments in the path\.

```csharp
public static string Separator { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.Add(string)'></a>

## ObjectPath\<TObjectPath\>\.Add\(string\) Method

Appends a new segment to the path and returns the resulting path\.

```csharp
public TObjectPath? Add(string? name);
```
#### Parameters

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.Add(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the segment to append\.

#### Returns
[TObjectPath](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath_TObjectPath_.TObjectPath 'DiGi\.Core\.Classes\.ObjectPath\<TObjectPath\>\.TObjectPath')  
The resulting path after appending the segment\.

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.Add(System.Collections.Generic.IEnumerable_string_)'></a>

## ObjectPath\<TObjectPath\>\.Add\(IEnumerable\<string\>\) Method

Appends multiple segments to the path and returns the resulting path\.

```csharp
public TObjectPath? Add(System.Collections.Generic.IEnumerable<string>? names);
```
#### Parameters

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.Add(System.Collections.Generic.IEnumerable_string_).names'></a>

`names` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segment names to append\.

#### Returns
[TObjectPath](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath_TObjectPath_.TObjectPath 'DiGi\.Core\.Classes\.ObjectPath\<TObjectPath\>\.TObjectPath')  
The resulting path after appending the segments\.

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.Equals(object)'></a>

## ObjectPath\<TObjectPath\>\.Equals\(object\) Method

Determines whether the specified object is equal to the current path\.

```csharp
public override bool Equals(object obj);
```
#### Parameters

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the current path\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the objects are equal; otherwise, false\.

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.GetHashCode()'></a>

## ObjectPath\<TObjectPath\>\.GetHashCode\(\) Method

Returns the hash code for this path\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The hash code for this path\.

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.GetNames(bool)'></a>

## ObjectPath\<TObjectPath\>\.GetNames\(bool\) Method

Retrieves a list of all segment names in the path\.

```csharp
public System.Collections.Generic.List<string> GetNames(bool includeName=true);
```
#### Parameters

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.GetNames(bool).includeName'></a>

`includeName` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include the name\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of strings containing the segment names\.

<a name='DiGi.Core.Classes.ObjectPath_TObjectPath_.ToString()'></a>

## ObjectPath\<TObjectPath\>\.ToString\(\) Method

Returns a string representation of the hierarchical path\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the hierarchical path\.

<a name='DiGi.Core.Classes.ProgressWrapper_T_'></a>

## ProgressWrapper\<T\> Class

Provides thread\-safe progress reporting for values of type T\.

```csharp
public class ProgressWrapper<T> : DiGi.Core.Interfaces.IObject
```
#### Type parameters

<a name='DiGi.Core.Classes.ProgressWrapper_T_.T'></a>

`T`

The type of the progress value\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → ProgressWrapper\<T\>

Derived  
↳ [LongProgressWrapper](DiGi.Core.Classes.md#DiGi.Core.Classes.LongProgressWrapper 'DiGi\.Core\.Classes\.LongProgressWrapper')

Implements [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Classes.ProgressWrapper_T_.ProgressWrapper(T,System.IProgress_T_)'></a>

## ProgressWrapper\(T, IProgress\<T\>\) Constructor

Initializes a new instance of the [ProgressWrapper&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ProgressWrapper_T_ 'DiGi\.Core\.Classes\.ProgressWrapper\<T\>') class with an initial value\.

```csharp
public ProgressWrapper(T initialValue, System.IProgress<T>? progress=null);
```
#### Parameters

<a name='DiGi.Core.Classes.ProgressWrapper_T_.ProgressWrapper(T,System.IProgress_T_).initialValue'></a>

`initialValue` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.ProgressWrapper_T_.T 'DiGi\.Core\.Classes\.ProgressWrapper\<T\>\.T')

The initial progress value\.

<a name='DiGi.Core.Classes.ProgressWrapper_T_.ProgressWrapper(T,System.IProgress_T_).progress'></a>

`progress` [System\.IProgress&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1 'System\.IProgress\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.ProgressWrapper_T_.T 'DiGi\.Core\.Classes\.ProgressWrapper\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1 'System\.IProgress\`1')

An optional IProgress implementation to report updates to\.
### Properties

<a name='DiGi.Core.Classes.ProgressWrapper_T_.Current'></a>

## ProgressWrapper\<T\>\.Current Property

Gets the current progress value\.

```csharp
public T Current { get; private set; }
```

#### Property Value
[T](DiGi.Core.Classes.md#DiGi.Core.Classes.ProgressWrapper_T_.T 'DiGi\.Core\.Classes\.ProgressWrapper\<T\>\.T')
### Methods

<a name='DiGi.Core.Classes.ProgressWrapper_T_.Report(T)'></a>

## ProgressWrapper\<T\>\.Report\(T\) Method

Reports a new progress value\.

```csharp
public void Report(T value);
```
#### Parameters

<a name='DiGi.Core.Classes.ProgressWrapper_T_.Report(T).value'></a>

`value` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.ProgressWrapper_T_.T 'DiGi\.Core\.Classes\.ProgressWrapper\<T\>\.T')

The progress value to report\.

<a name='DiGi.Core.Classes.PropertyReference'></a>

## PropertyReference Class

Represents a reference to a property within a serializable object\.

```csharp
public abstract class PropertyReference : DiGi.Core.Classes.SerializableReference
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') → PropertyReference

Derived  
↳ [PropertyReference&lt;USerializableReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference_USerializableReference_ 'DiGi\.Core\.Classes\.PropertyReference\<USerializableReference\>')
### Constructors

<a name='DiGi.Core.Classes.PropertyReference.PropertyReference(DiGi.Core.Classes.PropertyReference)'></a>

## PropertyReference\(PropertyReference\) Constructor

Initializes a new instance of the [PropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference 'DiGi\.Core\.Classes\.PropertyReference') class by copying an existing reference\.

```csharp
public PropertyReference(DiGi.Core.Classes.PropertyReference? propertyReference);
```
#### Parameters

<a name='DiGi.Core.Classes.PropertyReference.PropertyReference(DiGi.Core.Classes.PropertyReference).propertyReference'></a>

`propertyReference` [PropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference 'DiGi\.Core\.Classes\.PropertyReference')

The property reference to copy\.

<a name='DiGi.Core.Classes.PropertyReference.PropertyReference(string)'></a>

## PropertyReference\(string\) Constructor

Initializes a new instance of the [PropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference 'DiGi\.Core\.Classes\.PropertyReference') class with the specified property name\.

```csharp
public PropertyReference(string? propertyName);
```
#### Parameters

<a name='DiGi.Core.Classes.PropertyReference.PropertyReference(string).propertyName'></a>

`propertyName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the property\.

<a name='DiGi.Core.Classes.PropertyReference.PropertyReference(System.Text.Json.Nodes.JsonObject)'></a>

## PropertyReference\(JsonObject\) Constructor

Initializes a new instance of the [PropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference 'DiGi\.Core\.Classes\.PropertyReference') class from the specified nullable JSON object\.

```csharp
public PropertyReference(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.PropertyReference.PropertyReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to create the reference from\.
### Properties

<a name='DiGi.Core.Classes.PropertyReference.PropertyName'></a>

## PropertyReference\.PropertyName Property

Gets or sets the name of the referenced property\.

```csharp
public string? PropertyName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.PropertyReference_USerializableReference_'></a>

## PropertyReference\<USerializableReference\> Class

Represents a typed reference to a property within a serializable object\.

```csharp
public abstract class PropertyReference<USerializableReference> : DiGi.Core.Classes.PropertyReference
    where USerializableReference : DiGi.Core.Classes.SerializableReference
```
#### Type parameters

<a name='DiGi.Core.Classes.PropertyReference_USerializableReference_.USerializableReference'></a>

`USerializableReference`

The type of the serializable reference\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') → [PropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference 'DiGi\.Core\.Classes\.PropertyReference') → PropertyReference\<USerializableReference\>

Derived  
↳ [TypePropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypePropertyReference 'DiGi\.Core\.Classes\.TypePropertyReference')  
↳ [UniquePropertyReference&lt;UUniquePropertyReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_ 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>')
### Constructors

<a name='DiGi.Core.Classes.PropertyReference_USerializableReference_.PropertyReference(DiGi.Core.Classes.PropertyReference_USerializableReference_)'></a>

## PropertyReference\(PropertyReference\<USerializableReference\>\) Constructor

Initializes a new instance of the [PropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference 'DiGi\.Core\.Classes\.PropertyReference') class by copying an existing generic reference\.

```csharp
public PropertyReference(DiGi.Core.Classes.PropertyReference<USerializableReference>? propertyReference);
```
#### Parameters

<a name='DiGi.Core.Classes.PropertyReference_USerializableReference_.PropertyReference(DiGi.Core.Classes.PropertyReference_USerializableReference_).propertyReference'></a>

`propertyReference` [DiGi\.Core\.Classes\.PropertyReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference_USerializableReference_ 'DiGi\.Core\.Classes\.PropertyReference\<USerializableReference\>')[USerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference_USerializableReference_.USerializableReference 'DiGi\.Core\.Classes\.PropertyReference\<USerializableReference\>\.USerializableReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference_USerializableReference_ 'DiGi\.Core\.Classes\.PropertyReference\<USerializableReference\>')

The generic property reference to copy\.

<a name='DiGi.Core.Classes.PropertyReference_USerializableReference_.PropertyReference(System.Text.Json.Nodes.JsonObject)'></a>

## PropertyReference\(JsonObject\) Constructor

Initializes a new instance of the [PropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference 'DiGi\.Core\.Classes\.PropertyReference') class from the specified JSON object\.

```csharp
public PropertyReference(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.PropertyReference_USerializableReference_.PropertyReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.

<a name='DiGi.Core.Classes.PropertyReference_USerializableReference_.PropertyReference(USerializableReference,string)'></a>

## PropertyReference\(USerializableReference, string\) Constructor

Initializes a new instance of the [PropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference 'DiGi\.Core\.Classes\.PropertyReference') class with the specified serializable reference and property name\.

```csharp
public PropertyReference(USerializableReference? reference, string? propertyName);
```
#### Parameters

<a name='DiGi.Core.Classes.PropertyReference_USerializableReference_.PropertyReference(USerializableReference,string).reference'></a>

`reference` [USerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference_USerializableReference_.USerializableReference 'DiGi\.Core\.Classes\.PropertyReference\<USerializableReference\>\.USerializableReference')

The serializable reference\.

<a name='DiGi.Core.Classes.PropertyReference_USerializableReference_.PropertyReference(USerializableReference,string).propertyName'></a>

`propertyName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the property\.
### Properties

<a name='DiGi.Core.Classes.PropertyReference_USerializableReference_.Reference'></a>

## PropertyReference\<USerializableReference\>\.Reference Property

Gets or sets the serializable reference associated with this property reference\.

```csharp
public USerializableReference? Reference { get; }
```

#### Property Value
[USerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference_USerializableReference_.USerializableReference 'DiGi\.Core\.Classes\.PropertyReference\<USerializableReference\>\.USerializableReference')

<a name='DiGi.Core.Classes.PropertyReference_USerializableReference_.Segments'></a>

## PropertyReference\<USerializableReference\>\.Segments Property

Gets the segments of this reference's string form: the nested reference, then the property name\.

```csharp
protected override System.Collections.Generic.IEnumerable<string?> Segments { protected get; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.Core.Classes.Range_T_'></a>

## Range\<T\> Class

Represents a closed interval between a minimum and maximum value of type T\.

```csharp
public class Range<T> : DiGi.Core.Classes.SerializableObject
```
#### Type parameters

<a name='DiGi.Core.Classes.Range_T_.T'></a>

`T`

The type of the values in the range\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → Range\<T\>

Derived  
↳ [DateTimeRange](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeRange 'DiGi\.Core\.Classes\.DateTimeRange')
### Constructors

<a name='DiGi.Core.Classes.Range_T_.Range(DiGi.Core.Classes.Range_T_)'></a>

## Range\(Range\<T\>\) Constructor

Initializes a new instance of the [Range&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>') class by copying an existing range\.

```csharp
public Range(DiGi.Core.Classes.Range<T>? range);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.Range(DiGi.Core.Classes.Range_T_).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The existing range to copy\.

<a name='DiGi.Core.Classes.Range_T_.Range(System.Collections.Generic.IEnumerable_T_)'></a>

## Range\(IEnumerable\<T\>\) Constructor

Initializes a new instance of the [Range&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>') class based on a collection of values\.

```csharp
public Range(System.Collections.Generic.IEnumerable<T>? values);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.Range(System.Collections.Generic.IEnumerable_T_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of values to use for initializing the range\.

<a name='DiGi.Core.Classes.Range_T_.Range(System.Text.Json.Nodes.JsonObject)'></a>

## Range\(JsonObject\) Constructor

Initializes a new instance of the [Range&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>') class from a JSON object\.

```csharp
public Range(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.Range(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the range from\.

<a name='DiGi.Core.Classes.Range_T_.Range(T,T)'></a>

## Range\(T, T\) Constructor

Initializes a new instance of the [Range&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>') class with specified boundary values\.

```csharp
public Range(T? value_1, T? value_2);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.Range(T,T).value_1'></a>

`value_1` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')

The first boundary value\.

<a name='DiGi.Core.Classes.Range_T_.Range(T,T).value_2'></a>

`value_2` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')

The second boundary value\.
### Properties

<a name='DiGi.Core.Classes.Range_T_.Length'></a>

## Range\<T\>\.Length Property

Gets the length of the range\.

```csharp
public virtual T Length { get; }
```

#### Property Value
[T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')

<a name='DiGi.Core.Classes.Range_T_.Max'></a>

## Range\<T\>\.Max Property

Gets the maximum value of the range\.

```csharp
public T Max { get; }
```

#### Property Value
[T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')

<a name='DiGi.Core.Classes.Range_T_.Min'></a>

## Range\<T\>\.Min Property

Gets the minimum value of the range\.

```csharp
public T Min { get; }
```

#### Property Value
[T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')
### Methods

<a name='DiGi.Core.Classes.Range_T_.Add(DiGi.Core.Classes.Range_T_)'></a>

## Range\<T\>\.Add\(Range\<T\>\) Method

Expands the current range to include another range and returns true if the range was modified\.

```csharp
public bool Add(DiGi.Core.Classes.Range<T>? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.Add(DiGi.Core.Classes.Range_T_).value'></a>

`value` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the range was modified; otherwise, false\.

<a name='DiGi.Core.Classes.Range_T_.Add(T)'></a>

## Range\<T\>\.Add\(T\) Method

Adds a value to the range and returns true if the range was expanded\.

```csharp
public bool Add(T value);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.Add(T).value'></a>

`value` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')

The value to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the range was expanded; otherwise, false\.

<a name='DiGi.Core.Classes.Range_T_.Equals(object)'></a>

## Range\<T\>\.Equals\(object\) Method

Determines whether the specified object is equal to the current range\.

```csharp
public override bool Equals(object? @object);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.Equals(object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the current range\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified object is equal to the current range; otherwise, false\.

<a name='DiGi.Core.Classes.Range_T_.GetHashCode()'></a>

## Range\<T\>\.GetHashCode\(\) Method

Gets the hash code for the current type reference\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A hash code for the current object\.

<a name='DiGi.Core.Classes.Range_T_.In(DiGi.Core.Classes.Range_T_)'></a>

## Range\<T\>\.In\(Range\<T\>\) Method

Determines whether another range is entirely contained within this range\.

```csharp
public bool In(DiGi.Core.Classes.Range<T>? range);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.In(DiGi.Core.Classes.Range_T_).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range to check for containment\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified range is contained within this range; otherwise, false\.

<a name='DiGi.Core.Classes.Range_T_.In(DiGi.Core.Classes.Range_T_,T)'></a>

## Range\<T\>\.In\(Range\<T\>, T\) Method

Determines whether another range is contained within this range, considering a given tolerance\.

```csharp
public bool In(DiGi.Core.Classes.Range<T>? range, T tolerance);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.In(DiGi.Core.Classes.Range_T_,T).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range to check for containment\.

<a name='DiGi.Core.Classes.Range_T_.In(DiGi.Core.Classes.Range_T_,T).tolerance'></a>

`tolerance` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')

The tolerance value to use during the containment check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified range is contained within this range; otherwise, false\.

<a name='DiGi.Core.Classes.Range_T_.In(T)'></a>

## Range\<T\>\.In\(T\) Method

Determines whether a specified value is contained within the range\.

```csharp
public bool In(T value);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.In(T).value'></a>

`value` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')

The value to check for containment\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value is contained within the range; otherwise, false\.

<a name='DiGi.Core.Classes.Range_T_.In(T,T)'></a>

## Range\<T\>\.In\(T, T\) Method

Determines whether a specified value is contained within the range, considering a given tolerance\.

```csharp
public bool In(T value, T tolerance);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.In(T,T).value'></a>

`value` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')

The value to check for containment\.

<a name='DiGi.Core.Classes.Range_T_.In(T,T).tolerance'></a>

`tolerance` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')

The tolerance value to use during the containment check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified value is contained within the range; otherwise, false\.

<a name='DiGi.Core.Classes.Range_T_.InRange(DiGi.Core.Classes.Range_T_,T)'></a>

## Range\<T\>\.InRange\(Range\<T\>, T\) Method

Determines whether the specified range is in range \(intersects or is within tolerance\) of the current range\.

```csharp
public bool InRange(DiGi.Core.Classes.Range<T>? range, T tolerance);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.InRange(DiGi.Core.Classes.Range_T_,T).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range to check\.

<a name='DiGi.Core.Classes.Range_T_.InRange(DiGi.Core.Classes.Range_T_,T).tolerance'></a>

`tolerance` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')

The tolerance value to consider\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the ranges intersect or are within the specified tolerance; otherwise, false\.

<a name='DiGi.Core.Classes.Range_T_.Intersect(DiGi.Core.Classes.Range_T_)'></a>

## Range\<T\>\.Intersect\(Range\<T\>\) Method

Determines whether the current range intersects with another specified range\.

```csharp
public bool Intersect(DiGi.Core.Classes.Range<T>? range);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.Intersect(DiGi.Core.Classes.Range_T_).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range to check for intersection\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the ranges intersect; otherwise, false\.

<a name='DiGi.Core.Classes.Range_T_.Intersect(DiGi.Core.Classes.Range_T_,T)'></a>

## Range\<T\>\.Intersect\(Range\<T\>, T\) Method

Determines whether the current range intersects with another specified range, considering a given tolerance\.

```csharp
public bool Intersect(DiGi.Core.Classes.Range<T>? range, T tolerance);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.Intersect(DiGi.Core.Classes.Range_T_,T).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range to check for intersection\.

<a name='DiGi.Core.Classes.Range_T_.Intersect(DiGi.Core.Classes.Range_T_,T).tolerance'></a>

`tolerance` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')

The tolerance value to use during the intersection check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the ranges intersect; otherwise, false\.

<a name='DiGi.Core.Classes.Range_T_.Out(DiGi.Core.Classes.Range_T_)'></a>

## Range\<T\>\.Out\(Range\<T\>\) Method

Determines whether another range is completely outside this range\.

```csharp
public bool Out(DiGi.Core.Classes.Range<T>? range);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.Out(DiGi.Core.Classes.Range_T_).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range to check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified range is completely outside this range; otherwise, false\.

<a name='DiGi.Core.Classes.Range_T_.Out(DiGi.Core.Classes.Range_T_,T)'></a>

## Range\<T\>\.Out\(Range\<T\>, T\) Method

Determines whether another range is completely outside this range, considering a given tolerance\.

```csharp
public bool Out(DiGi.Core.Classes.Range<T>? range, T tolerance);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.Out(DiGi.Core.Classes.Range_T_,T).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range to check\.

<a name='DiGi.Core.Classes.Range_T_.Out(DiGi.Core.Classes.Range_T_,T).tolerance'></a>

`tolerance` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')

The tolerance value to consider\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified range is completely outside this range; otherwise, false\.

<a name='DiGi.Core.Classes.Range_T_.Out(T)'></a>

## Range\<T\>\.Out\(T\) Method

Determines whether a specified value is outside the boundaries of the range\.

```csharp
public bool Out(T value);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.Out(T).value'></a>

`value` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')

The value to check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified value is outside the boundaries of the range; otherwise, false\.

<a name='DiGi.Core.Classes.Range_T_.Out(T,T)'></a>

## Range\<T\>\.Out\(T, T\) Method

Determines whether a specified value is outside the boundaries of the range, considering a given tolerance\.

```csharp
public bool Out(T value, T tolerance);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.Out(T,T).value'></a>

`value` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')

The value to check\.

<a name='DiGi.Core.Classes.Range_T_.Out(T,T).tolerance'></a>

`tolerance` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')

The tolerance value to consider\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified value is outside the boundaries of the range; otherwise, false\.

<a name='DiGi.Core.Classes.Range_T_.ToString()'></a>

## Range\<T\>\.ToString\(\) Method

Returns a string representation of the current range\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string that represents the current range\.
### Operators

<a name='DiGi.Core.Classes.Range_T_.op_Equality(DiGi.Core.Classes.Range_T_,object)'></a>

## Range\<T\>\.operator ==\(Range\<T\>, object\) Operator

Compares the specified [Range&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>') with another object for equality\.

```csharp
public static bool operator ==(DiGi.Core.Classes.Range<T>? range, object? @object);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.op_Equality(DiGi.Core.Classes.Range_T_,object).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The [Range&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>') instance to compare\.

<a name='DiGi.Core.Classes.Range_T_.op_Equality(DiGi.Core.Classes.Range_T_,object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the range\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the objects are equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Core.Classes.Range_T_.op_Inequality(DiGi.Core.Classes.Range_T_,object)'></a>

## Range\<T\>\.operator \!=\(Range\<T\>, object\) Operator

Compares the specified [Range&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>') with another object for inequality\.

```csharp
public static bool operator !=(DiGi.Core.Classes.Range<T>? range, object? @object);
```
#### Parameters

<a name='DiGi.Core.Classes.Range_T_.op_Inequality(DiGi.Core.Classes.Range_T_,object).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_.T 'DiGi\.Core\.Classes\.Range\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The [Range&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>') instance to compare\.

<a name='DiGi.Core.Classes.Range_T_.op_Inequality(DiGi.Core.Classes.Range_T_,object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the range\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the objects are not equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Core.Classes.ReferenceConstructor'></a>

## ReferenceConstructor Class

Encapsulates the logic to rebuild an [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference') from the segments of its string form, using a
method marked with [ReferenceFactoryAttribute](DiGi.Core.Classes.md#DiGi.Core.Classes.ReferenceFactoryAttribute 'DiGi\.Core\.Classes\.ReferenceFactoryAttribute')\.

```csharp
public class ReferenceConstructor
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → ReferenceConstructor
### Properties

<a name='DiGi.Core.Classes.ReferenceConstructor.Discriminator'></a>

## ReferenceConstructor\.Discriminator Property

Gets the discriminator this reference type is written with: its [Kind](DiGi.Core.Classes.md#DiGi.Core.Classes.ReferenceConstructor.Kind 'DiGi\.Core\.Classes\.ReferenceConstructor\.Kind') when declared,
otherwise its [FullTypeName](DiGi.Core.Classes.md#DiGi.Core.Classes.ReferenceConstructor.FullTypeName 'DiGi\.Core\.Classes\.ReferenceConstructor\.FullTypeName')\.

```csharp
public string? Discriminator { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.ReferenceConstructor.FullTypeName'></a>

## ReferenceConstructor\.FullTypeName Property

Gets the assembly\-qualified full type name of the reference type this constructor creates\.

```csharp
public string? FullTypeName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.ReferenceConstructor.Kind'></a>

## ReferenceConstructor\.Kind Property

Gets the short discriminator token this reference type is written with, or null when it falls back to
[FullTypeName](DiGi.Core.Classes.md#DiGi.Core.Classes.ReferenceConstructor.FullTypeName 'DiGi\.Core\.Classes\.ReferenceConstructor\.FullTypeName')\.

```csharp
public string? Kind { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.ReferenceConstructor.ReferenceType'></a>

## ReferenceConstructor\.ReferenceType Property

Gets the reference type this constructor creates\.

```csharp
public System.Type? ReferenceType { get; }
```

#### Property Value
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

<a name='DiGi.Core.Classes.ReferenceConstructor.Valid'></a>

## ReferenceConstructor\.Valid Property

Gets a value indicating whether the factory method matches the required signature\.

```csharp
public bool Valid { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')
### Methods

<a name='DiGi.Core.Classes.ReferenceConstructor.Create(System.Collections.Generic.IReadOnlyList_string_)'></a>

## ReferenceConstructor\.Create\(IReadOnlyList\<string\>\) Method

Rebuilds the reference from its segments\.

```csharp
public DiGi.Core.Interfaces.IReference? Create(System.Collections.Generic.IReadOnlyList<string?>? segments);
```
#### Parameters

<a name='DiGi.Core.Classes.ReferenceConstructor.Create(System.Collections.Generic.IReadOnlyList_string_).segments'></a>

`segments` [System\.Collections\.Generic\.IReadOnlyList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')

The segments, in the order declared by the type's Segments property\.

#### Returns
[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')  
The reference, or null when the segments do not describe a valid instance\.

<a name='DiGi.Core.Classes.ReferenceFactoryAttribute'></a>

## ReferenceFactoryAttribute Class

Marks a public static method as the factory that rebuilds a reference type from the segments of its string
form, and declares the discriminator that type is written with\.

The method must have the signature
            `public static IReference? Name(IReadOnlyList<string?>? segments)` and must consume exactly the
            segments that the type's `Segments` property declares, in the same order. Those two together are the
            round-trip contract.

Factories are discovered reflectively, which is what lets DiGi.Core parse reference types defined in
            repositories it cannot reference. Place the factory in the repository that owns the reference type.

```csharp
public sealed class ReferenceFactoryAttribute : System.Attribute
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → ReferenceFactoryAttribute

### Remarks
Initializes a new instance of the [ReferenceFactoryAttribute](DiGi.Core.Classes.md#DiGi.Core.Classes.ReferenceFactoryAttribute 'DiGi\.Core\.Classes\.ReferenceFactoryAttribute') class\.
### Constructors

<a name='DiGi.Core.Classes.ReferenceFactoryAttribute.ReferenceFactoryAttribute(System.Type)'></a>

## ReferenceFactoryAttribute\(Type\) Constructor

Marks a public static method as the factory that rebuilds a reference type from the segments of its string
form, and declares the discriminator that type is written with\.

The method must have the signature
            `public static IReference? Name(IReadOnlyList<string?>? segments)` and must consume exactly the
            segments that the type's `Segments` property declares, in the same order. Those two together are the
            round-trip contract.

Factories are discovered reflectively, which is what lets DiGi.Core parse reference types defined in
            repositories it cannot reference. Place the factory in the repository that owns the reference type.

```csharp
public ReferenceFactoryAttribute(System.Type referenceType);
```
#### Parameters

<a name='DiGi.Core.Classes.ReferenceFactoryAttribute.ReferenceFactoryAttribute(System.Type).referenceType'></a>

`referenceType` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The concrete reference type this factory creates\.

### Remarks
Initializes a new instance of the [ReferenceFactoryAttribute](DiGi.Core.Classes.md#DiGi.Core.Classes.ReferenceFactoryAttribute 'DiGi\.Core\.Classes\.ReferenceFactoryAttribute') class\.
### Properties

<a name='DiGi.Core.Classes.ReferenceFactoryAttribute.Kind'></a>

## ReferenceFactoryAttribute\.Kind Property

Gets or sets the short discriminator token this reference type is written with\.

Kind tokens share one flat namespace across every repository and are a persisted contract: they are
            append-only, must be unique, and must contain neither a comma nor a colon. When left null the type falls
            back to being written with its assembly-qualified full type name.

```csharp
public string? Kind { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.ReferenceFactoryAttribute.ReferenceType'></a>

## ReferenceFactoryAttribute\.ReferenceType Property

Gets the concrete reference type this factory creates\.

```csharp
public System.Type ReferenceType { get; }
```

#### Property Value
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

<a name='DiGi.Core.Classes.ReferenceManager'></a>

## ReferenceManager Class

Caches the [ReferenceConstructor](DiGi.Core.Classes.md#DiGi.Core.Classes.ReferenceConstructor 'DiGi\.Core\.Classes\.ReferenceConstructor') discovered for each reference type, so a reference string can be
resolved back to the type that produced it\.

Factories are found reflectively rather than through a hard-coded table, because DiGi.Core must be able
            to construct reference types defined in repositories that depend on it and that it therefore cannot
            reference.

```csharp
public class ReferenceManager
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → ReferenceManager
### Constructors

<a name='DiGi.Core.Classes.ReferenceManager.ReferenceManager()'></a>

## ReferenceManager\(\) Constructor

Initializes a new instance of the [ReferenceManager](DiGi.Core.Classes.md#DiGi.Core.Classes.ReferenceManager 'DiGi\.Core\.Classes\.ReferenceManager') class\.

```csharp
public ReferenceManager();
```
### Methods

<a name='DiGi.Core.Classes.ReferenceManager.GetReferenceConstructor(string,bool)'></a>

## ReferenceManager\.GetReferenceConstructor\(string, bool\) Method

Retrieves the reference constructor for a discriminator\.

An assembly-qualified full type name is self-locating, so only its own assembly is scanned. A short
            kind token carries no assembly, so a miss falls back to scanning every loaded assembly that references
            DiGi.Core - which means a kind resolves only if its declaring assembly is already loaded.

```csharp
public DiGi.Core.Classes.ReferenceConstructor? GetReferenceConstructor(string? discriminator, bool update=true);
```
#### Parameters

<a name='DiGi.Core.Classes.ReferenceManager.GetReferenceConstructor(string,bool).discriminator'></a>

`discriminator` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

A kind token or an assembly\-qualified full type name\.

<a name='DiGi.Core.Classes.ReferenceManager.GetReferenceConstructor(string,bool).update'></a>

`update` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to scan for the factory when it is not already cached\.

#### Returns
[ReferenceConstructor](DiGi.Core.Classes.md#DiGi.Core.Classes.ReferenceConstructor 'DiGi\.Core\.Classes\.ReferenceConstructor')  
The reference constructor, or null when the discriminator names no known reference type\.

<a name='DiGi.Core.Classes.ReferenceManager.GetReferenceConstructor(System.Type,bool)'></a>

## ReferenceManager\.GetReferenceConstructor\(Type, bool\) Method

Retrieves the reference constructor for a reference type, scanning its assembly on first use\.

```csharp
public DiGi.Core.Classes.ReferenceConstructor? GetReferenceConstructor(System.Type? type, bool update=true);
```
#### Parameters

<a name='DiGi.Core.Classes.ReferenceManager.GetReferenceConstructor(System.Type,bool).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The reference type\.

<a name='DiGi.Core.Classes.ReferenceManager.GetReferenceConstructor(System.Type,bool).update'></a>

`update` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to scan for the factory when it is not already cached\.

#### Returns
[ReferenceConstructor](DiGi.Core.Classes.md#DiGi.Core.Classes.ReferenceConstructor 'DiGi\.Core\.Classes\.ReferenceConstructor')  
The reference constructor, or null when the type has no factory\.

<a name='DiGi.Core.Classes.ReferenceManager.GetReferenceConstructors()'></a>

## ReferenceManager\.GetReferenceConstructors\(\) Method

Retrieves every reference constructor discoverable in the currently loaded assemblies\.

```csharp
public System.Collections.Generic.List<DiGi.Core.Classes.ReferenceConstructor> GetReferenceConstructors();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ReferenceConstructor](DiGi.Core.Classes.md#DiGi.Core.Classes.ReferenceConstructor 'DiGi\.Core\.Classes\.ReferenceConstructor')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
The reference constructors\.

<a name='DiGi.Core.Classes.ReportableBackgroundTask_T_'></a>

## ReportableBackgroundTask\<T\> Class

Provides a base class for background tasks that report progress during execution\.

```csharp
public abstract class ReportableBackgroundTask<T> : DiGi.Core.Classes.CancelableBackgroundTask, DiGi.Core.Interfaces.IReportableBackgroundTask<T>, DiGi.Core.Interfaces.IReportableBackgroundTask, DiGi.Core.Interfaces.ICancelableBackgroundTask, DiGi.Core.Interfaces.IBackgroundTask, DiGi.Core.Interfaces.IObject
```
#### Type parameters

<a name='DiGi.Core.Classes.ReportableBackgroundTask_T_.T'></a>

`T`

The type of progress data reported\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [BackgroundTask](DiGi.Core.Classes.md#DiGi.Core.Classes.BackgroundTask 'DiGi\.Core\.Classes\.BackgroundTask') → [CancelableBackgroundTask](DiGi.Core.Classes.md#DiGi.Core.Classes.CancelableBackgroundTask 'DiGi\.Core\.Classes\.CancelableBackgroundTask') → ReportableBackgroundTask\<T\>

Implements [DiGi\.Core\.Interfaces\.IReportableBackgroundTask&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReportableBackgroundTask_T_ 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.ReportableBackgroundTask_T_.T 'DiGi\.Core\.Classes\.ReportableBackgroundTask\<T\>\.T')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReportableBackgroundTask_T_ 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask\<T\>'), [IReportableBackgroundTask](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReportableBackgroundTask 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask'), [ICancelableBackgroundTask](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICancelableBackgroundTask 'DiGi\.Core\.Interfaces\.ICancelableBackgroundTask'), [IBackgroundTask](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IBackgroundTask 'DiGi\.Core\.Interfaces\.IBackgroundTask'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Methods

<a name='DiGi.Core.Classes.ReportableBackgroundTask_T_.ExecuteAsync(System.IProgress_T_,System.Threading.CancellationToken)'></a>

## ReportableBackgroundTask\<T\>\.ExecuteAsync\(IProgress\<T\>, CancellationToken\) Method

When overridden in a derived class, defines the work to be executed with progress reporting\.

```csharp
protected abstract System.Threading.Tasks.Task<bool> ExecuteAsync(System.IProgress<T> progress, System.Threading.CancellationToken cancellationToken);
```
#### Parameters

<a name='DiGi.Core.Classes.ReportableBackgroundTask_T_.ExecuteAsync(System.IProgress_T_,System.Threading.CancellationToken).progress'></a>

`progress` [System\.IProgress&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1 'System\.IProgress\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.ReportableBackgroundTask_T_.T 'DiGi\.Core\.Classes\.ReportableBackgroundTask\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1 'System\.IProgress\`1')

The progress reporter for reporting progress updates\.

<a name='DiGi.Core.Classes.ReportableBackgroundTask_T_.ExecuteAsync(System.IProgress_T_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
True if the task succeeded; otherwise, false\.

<a name='DiGi.Core.Classes.ReportableBackgroundTask_T_.ExecuteAsync(System.Threading.CancellationToken)'></a>

## ReportableBackgroundTask\<T\>\.ExecuteAsync\(CancellationToken\) Method

Executes the background task with progress reporting support\.

```csharp
protected override System.Threading.Tasks.Task<bool> ExecuteAsync(System.Threading.CancellationToken cancellationToken);
```
#### Parameters

<a name='DiGi.Core.Classes.ReportableBackgroundTask_T_.ExecuteAsync(System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
True if the task succeeded; otherwise, false\.

<a name='DiGi.Core.Classes.ReportableBackgroundTask_T_.OnProgressChanged(T)'></a>

## ReportableBackgroundTask\<T\>\.OnProgressChanged\(T\) Method

Raises the ProgressChanged event with the given progress value\.

```csharp
protected virtual void OnProgressChanged(T value);
```
#### Parameters

<a name='DiGi.Core.Classes.ReportableBackgroundTask_T_.OnProgressChanged(T).value'></a>

`value` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.ReportableBackgroundTask_T_.T 'DiGi\.Core\.Classes\.ReportableBackgroundTask\<T\>\.T')

The progress value to report\.
### Events

<a name='DiGi.Core.Classes.ReportableBackgroundTask_T_.ProgressChanged'></a>

## ReportableBackgroundTask\<T\>\.ProgressChanged Event

Occurs when the task reports progress\.

```csharp
public event EventHandler<T>? ProgressChanged;
```

Implements [ProgressChanged](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReportableBackgroundTask_T_.ProgressChanged 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask\<T\>\.ProgressChanged')

#### Event Type
[System\.EventHandler&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1 'System\.EventHandler\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.ReportableBackgroundTask_T_.T 'DiGi\.Core\.Classes\.ReportableBackgroundTask\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1 'System\.EventHandler\`1')

<a name='DiGi.Core.Classes.SerializableModel'></a>

## SerializableModel Class

Base class for models that support serialization\.

```csharp
public abstract class SerializableModel : DiGi.Core.Classes.SerializableObject, DiGi.Core.Interfaces.ISerializableModel, DiGi.Core.Interfaces.IModel, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → SerializableModel

Implements [ISerializableModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableModel 'DiGi\.Core\.Interfaces\.ISerializableModel'), [IModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IModel 'DiGi\.Core\.Interfaces\.IModel'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Core.Classes.SerializableModel.SerializableModel()'></a>

## SerializableModel\(\) Constructor

Initializes a new instance of the [SerializableModel](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableModel 'DiGi\.Core\.Classes\.SerializableModel') class\.

```csharp
public SerializableModel();
```

<a name='DiGi.Core.Classes.SerializableModel.SerializableModel(DiGi.Core.Classes.SerializableModel)'></a>

## SerializableModel\(SerializableModel\) Constructor

Initializes a new instance of the [SerializableModel](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableModel 'DiGi\.Core\.Classes\.SerializableModel') class by copying an existing model\.

```csharp
public SerializableModel(DiGi.Core.Classes.SerializableModel serializableModel);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableModel.SerializableModel(DiGi.Core.Classes.SerializableModel).serializableModel'></a>

`serializableModel` [SerializableModel](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableModel 'DiGi\.Core\.Classes\.SerializableModel')

The source model to copy from\.

<a name='DiGi.Core.Classes.SerializableModel.SerializableModel(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableModel\(JsonObject\) Constructor

Initializes a new instance of the [SerializableModel](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableModel 'DiGi\.Core\.Classes\.SerializableModel') class from a JSON object\.

```csharp
public SerializableModel(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableModel.SerializableModel(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the model\.

<a name='DiGi.Core.Classes.SerializableObject'></a>

## SerializableObject Class

Abstract base class that provides core JSON serialization and deserialization capabilities to an Object\.

```csharp
public abstract class SerializableObject : DiGi.Core.Classes.Object, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → SerializableObject

Derived  
↳ [Address](DiGi.Core.Classes.md#DiGi.Core.Classes.Address 'DiGi\.Core\.Classes\.Address')  
↳ [Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category')  
↳ [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color')  
↳ [ConfigurationFile](DiGi.Core.Classes.md#DiGi.Core.Classes.ConfigurationFile 'DiGi\.Core\.Classes\.ConfigurationFile')  
↳ [Coordinates](DiGi.Core.Classes.md#DiGi.Core.Classes.Coordinates 'DiGi\.Core\.Classes\.Coordinates')  
↳ [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection')  
↳ [DateTimeSeries](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeSeries 'DiGi\.Core\.Classes\.DateTimeSeries')  
↳ [IndexedObjects&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_ 'DiGi\.Core\.Classes\.IndexedObjects\<T\>')  
↳ [ObjectPath&lt;TObjectPath&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath_TObjectPath_ 'DiGi\.Core\.Classes\.ObjectPath\<TObjectPath\>')  
↳ [Range&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')  
↳ [SerializableModel](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableModel 'DiGi\.Core\.Classes\.SerializableModel')  
↳ [SerializableObjectCollection&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>')  
↳ [SerializableObjectWrapper](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectWrapper 'DiGi\.Core\.Classes\.SerializableObjectWrapper')  
↳ [SerializableOptions](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableOptions 'DiGi\.Core\.Classes\.SerializableOptions')  
↳ [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference')  
↳ [SerializableResult](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult 'DiGi\.Core\.Classes\.SerializableResult')  
↳ [Size](DiGi.Core.Classes.md#DiGi.Core.Classes.Size 'DiGi\.Core\.Classes\.Size')  
↳ [SphericalDistributionSerializableObjectCollection&lt;TSerializableObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_ 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection\<TSerializableObject\>')  
↳ [UniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObject 'DiGi\.Core\.Classes\.UniqueObject')  
↳ [Value&lt;TObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Value_TObject_ 'DiGi\.Core\.Classes\.Value\<TObject\>')

Implements [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Classes.SerializableObject.SerializableObject()'></a>

## SerializableObject\(\) Constructor

Initializes a new instance of the SerializableObject class\.

```csharp
public SerializableObject();
```

<a name='DiGi.Core.Classes.SerializableObject.SerializableObject(DiGi.Core.Classes.SerializableObject)'></a>

## SerializableObject\(SerializableObject\) Constructor

Initializes a new instance of the SerializableObject class by copying another serializable object\.

```csharp
public SerializableObject(DiGi.Core.Classes.SerializableObject? serializableObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObject.SerializableObject(DiGi.Core.Classes.SerializableObject).serializableObject'></a>

`serializableObject` [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject')

The source object to copy from\.

<a name='DiGi.Core.Classes.SerializableObject.SerializableObject(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableObject\(JsonObject\) Constructor

Initializes a new instance of the SerializableObject class from a JsonObject\.

```csharp
public SerializableObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObject.SerializableObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing serializable data\.
### Properties

<a name='DiGi.Core.Classes.SerializableObject.FullTypeName'></a>

## SerializableObject\.FullTypeName Property

Gets the full type name of the object for serialization purposes\.

```csharp
private string? FullTypeName { private get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Core.Classes.SerializableObject.Clone()'></a>

## SerializableObject\.Clone\(\) Method

Creates a deep copy of the serializable object by serializing and deserializing it\.

```csharp
public virtual DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.Clone() 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>\.Clone\(\)')

#### Returns
[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject') instance that is a deep copy of the current object, or null if cloning fails\.

<a name='DiGi.Core.Classes.SerializableObject.FromJsonObject(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableObject\.FromJsonObject\(JsonObject\) Method

Populates the object's properties from a JsonObject\.

```csharp
public virtual bool FromJsonObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObject.FromJsonObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to populate the object\.

Implements [FromJsonObject\(JsonObject\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject.FromJsonObject(System.Text.Json.Nodes.JsonObject) 'DiGi\.Core\.Interfaces\.ISerializableObject\.FromJsonObject\(System\.Text\.Json\.Nodes\.JsonObject\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object was successfully populated; otherwise, false\.

<a name='DiGi.Core.Classes.SerializableObject.ToJsonObject()'></a>

## SerializableObject\.ToJsonObject\(\) Method

Converts the object into a JsonObject for serialization\.

```csharp
public virtual System.Text.Json.Nodes.JsonObject? ToJsonObject();
```

Implements [ToJsonObject\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject.ToJsonObject() 'DiGi\.Core\.Interfaces\.ISerializableObject\.ToJsonObject\(\)')

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') representation of the object, or null if conversion fails\.
### Operators

<a name='DiGi.Core.Classes.SerializableObject.op_ExplicitDiGi.Core.Classes.SerializableObject(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableObject\.explicit operator SerializableObject\(JsonObject\) Operator

Explicitly converts a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') to a [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') instance\.

```csharp
public static DiGi.Core.Classes.SerializableObject? explicit operator DiGi.Core.Classes.SerializableObject?(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObject.op_ExplicitDiGi.Core.Classes.SerializableObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') to convert from\.

#### Returns
[SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject')  
A [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') instance created from the provided [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject'), or null if the conversion fails or the input is null\.

<a name='DiGi.Core.Classes.SerializableObject.op_ExplicitSystem.Text.Json.Nodes.JsonObject(DiGi.Core.Classes.SerializableObject)'></a>

## SerializableObject\.explicit operator JsonObject\(SerializableObject\) Operator

Explicitly converts a [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') instance to a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public static System.Text.Json.Nodes.JsonObject? explicit operator System.Text.Json.Nodes.JsonObject?(DiGi.Core.Classes.SerializableObject? serializableObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObject.op_ExplicitSystem.Text.Json.Nodes.JsonObject(DiGi.Core.Classes.SerializableObject).serializableObject'></a>

`serializableObject` [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject')

The [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') instance to convert from\.

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') representation of the provided [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject'), or null if the input is null\.

<a name='DiGi.Core.Classes.SerializableObjectCollection'></a>

## SerializableObjectCollection Class

Non\-generic version of SerializableObjectCollection for handling a collection of ISerializableObjects\.

```csharp
public class SerializableObjectCollection : DiGi.Core.Classes.SerializableObjectCollection<DiGi.Core.Interfaces.ISerializableObject>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableObjectCollection&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>') → SerializableObjectCollection
### Constructors

<a name='DiGi.Core.Classes.SerializableObjectCollection.SerializableObjectCollection()'></a>

## SerializableObjectCollection\(\) Constructor

Initializes a new instance of the [SerializableObjectCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection 'DiGi\.Core\.Classes\.SerializableObjectCollection') class\.

```csharp
public SerializableObjectCollection();
```

<a name='DiGi.Core.Classes.SerializableObjectCollection.SerializableObjectCollection(DiGi.Core.Classes.SerializableObjectCollection)'></a>

## SerializableObjectCollection\(SerializableObjectCollection\) Constructor

Initializes a new instance of the [SerializableObjectCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection 'DiGi\.Core\.Classes\.SerializableObjectCollection') class by copying another collection\.

```csharp
public SerializableObjectCollection(DiGi.Core.Classes.SerializableObjectCollection? serializableObjectCollection);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectCollection.SerializableObjectCollection(DiGi.Core.Classes.SerializableObjectCollection).serializableObjectCollection'></a>

`serializableObjectCollection` [SerializableObjectCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection 'DiGi\.Core\.Classes\.SerializableObjectCollection')

The source collection to copy from\.

<a name='DiGi.Core.Classes.SerializableObjectCollection.SerializableObjectCollection(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.ISerializableObject_)'></a>

## SerializableObjectCollection\(IEnumerable\<ISerializableObject\>\) Constructor

Initializes a new instance of the [SerializableObjectCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection 'DiGi\.Core\.Classes\.SerializableObjectCollection') class from an enumerable of ISerializableObject instances\.

```csharp
public SerializableObjectCollection(System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.ISerializableObject>? serializableObjects);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectCollection.SerializableObjectCollection(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.ISerializableObject_).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The enumerable of serializable objects to initialize the collection with\.

<a name='DiGi.Core.Classes.SerializableObjectCollection.SerializableObjectCollection(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableObjectCollection\(JsonObject\) Constructor

Initializes a new instance of the [SerializableObjectCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection 'DiGi\.Core\.Classes\.SerializableObjectCollection') class from a JSON object\.

```csharp
public SerializableObjectCollection(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectCollection.SerializableObjectCollection(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the collection from\.
### Methods

<a name='DiGi.Core.Classes.SerializableObjectCollection.Clone()'></a>

## SerializableObjectCollection\.Clone\(\) Method

Creates a new object that is a copy of the current instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.Clone() 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>\.Clone\(\)')

#### Returns
[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new object that is a copy of this instance\.

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_'></a>

## SerializableObjectCollection\<T\> Class

A serializable collection of objects implementing ISerializableObject\.

```csharp
public class SerializableObjectCollection<T> : DiGi.Core.Classes.SerializableObject, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    where T : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.T'></a>

`T`

The type of elements in the collection\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → SerializableObjectCollection\<T\>

Derived  
↳ [SerializableObjectCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection 'DiGi\.Core\.Classes\.SerializableObjectCollection')

Implements [System\.Collections\.Generic\.ICollection&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1'), [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')
### Constructors

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.SerializableObjectCollection()'></a>

## SerializableObjectCollection\(\) Constructor

Initializes a new instance of the [SerializableObjectCollection&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>') class\.

```csharp
public SerializableObjectCollection();
```

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.SerializableObjectCollection(DiGi.Core.Classes.SerializableObjectCollection_T_)'></a>

## SerializableObjectCollection\(SerializableObjectCollection\<T\>\) Constructor

Initializes a new instance of the [SerializableObjectCollection&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>') class by copying another collection\.

```csharp
public SerializableObjectCollection(DiGi.Core.Classes.SerializableObjectCollection<T>? serializableObjectCollection);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.SerializableObjectCollection(DiGi.Core.Classes.SerializableObjectCollection_T_).serializableObjectCollection'></a>

`serializableObjectCollection` [DiGi\.Core\.Classes\.SerializableObjectCollection&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>')

The source collection to copy from\.

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.SerializableObjectCollection(System.Collections.Generic.IEnumerable_T_)'></a>

## SerializableObjectCollection\(IEnumerable\<T\>\) Constructor

Initializes a new instance of the [SerializableObjectCollection&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>') class from an enumerable of serializable objects\.

```csharp
public SerializableObjectCollection(System.Collections.Generic.IEnumerable<T>? serializableObjects);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.SerializableObjectCollection(System.Collections.Generic.IEnumerable_T_).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The enumerable of serializable objects to initialize the collection with\.

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.SerializableObjectCollection(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableObjectCollection\(JsonObject\) Constructor

Initializes a new instance of the [SerializableObjectCollection&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>') class from a JSON object\.

```csharp
public SerializableObjectCollection(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.SerializableObjectCollection(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the collection from\.
### Properties

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.Count'></a>

## SerializableObjectCollection\<T\>\.Count Property

Gets the number of elements contained in the collection\.

```csharp
public int Count { get; }
```

Implements [Count](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1.count 'System\.Collections\.Generic\.ICollection\`1\.Count')

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.IsReadOnly'></a>

## SerializableObjectCollection\<T\>\.IsReadOnly Property

Gets a value indicating whether the collection is read\-only\.

```csharp
public bool IsReadOnly { get; }
```

Implements [IsReadOnly](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1.isreadonly 'System\.Collections\.Generic\.ICollection\`1\.IsReadOnly')

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.this[int]'></a>

## SerializableObjectCollection\<T\>\.this\[int\] Property

Gets or sets the element at the specified index of the collection\.

```csharp
public T this[int index] { get; set; }
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.this[int].index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the element to get or set\.

#### Property Value
[T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.Values'></a>

## SerializableObjectCollection\<T\>\.Values Property

Gets the list of elements contained in the collection\.

```csharp
public System.Collections.Generic.IList<T> Values { get; }
```

#### Property Value
[System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')
### Methods

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.Add(T)'></a>

## SerializableObjectCollection\<T\>\.Add\(T\) Method

Adds an item to the collection\.

```csharp
public void Add(T serializableObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.Add(T).serializableObject'></a>

`serializableObject` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')

The object to add to the collection\.

Implements [Add\(T\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1.add#system-collections-generic-icollection-1-add(-0) 'System\.Collections\.Generic\.ICollection\`1\.Add\(\`0\)')

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.Clear()'></a>

## SerializableObjectCollection\<T\>\.Clear\(\) Method

Removes all items from the collection\.

```csharp
public void Clear();
```

Implements [Clear\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1.clear 'System\.Collections\.Generic\.ICollection\`1\.Clear')

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.Contains(T)'></a>

## SerializableObjectCollection\<T\>\.Contains\(T\) Method

Determines whether the collection contains a specific value\.

```csharp
public bool Contains(T? item);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.Contains(T).item'></a>

`item` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')

The object to locate in the collection\.

Implements [Contains\(T\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1.contains#system-collections-generic-icollection-1-contains(-0) 'System\.Collections\.Generic\.ICollection\`1\.Contains\(\`0\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the item is found; otherwise, false\.

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.CopyTo(T[],int)'></a>

## SerializableObjectCollection\<T\>\.CopyTo\(T\[\], int\) Method

Copies the elements of the collection to an Array, starting at a particular Array index\.

```csharp
public void CopyTo(T[] array, int arrayIndex);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.CopyTo(T[],int).array'></a>

`array` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The one\-dimensional Array that is the destination of the elements\.

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.CopyTo(T[],int).arrayIndex'></a>

`arrayIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index in array at which copying begins\.

Implements [CopyTo\(T\[\], int\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1.copyto#system-collections-generic-icollection-1-copyto(-0[]-system-int32) 'System\.Collections\.Generic\.ICollection\`1\.CopyTo\(\`0\[\],System\.Int32\)')

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.GetEnumerator()'></a>

## SerializableObjectCollection\<T\>\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the collection\.

```csharp
public System.Collections.Generic.IEnumerator<T> GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator 'System\.Collections\.Generic\.IEnumerable\`1\.GetEnumerator'), [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

#### Returns
[System\.Collections\.Generic\.IEnumerator&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')  
An enumerator that can be used to iterate through the collection\.

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.Remove(T)'></a>

## SerializableObjectCollection\<T\>\.Remove\(T\) Method

Removes the first occurrence of a specific object from the collection\.

```csharp
public bool Remove(T? item);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.Remove(T).item'></a>

`item` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')

The object to remove from the collection\.

Implements [Remove\(T\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1.remove#system-collections-generic-icollection-1-remove(-0) 'System\.Collections\.Generic\.ICollection\`1\.Remove\(\`0\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if item was successfully removed from the collection; otherwise, false\.

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.RemoveAt(int)'></a>

## SerializableObjectCollection\<T\>\.RemoveAt\(int\) Method

Removes the element at the specified index of the collection\.

```csharp
public void RemoveAt(int index);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.RemoveAt(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the element to remove\.
### Operators

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.op_ExplicitDiGi.Core.Classes.SerializableObjectCollection_T_(System.Collections.Generic.List_T_)'></a>

## SerializableObjectCollection\<T\>\.explicit operator SerializableObjectCollection\<T\>\(List\<T\>\) Operator

Explicitly converts a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') to a [SerializableObjectCollection&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>')\.

```csharp
public static DiGi.Core.Classes.SerializableObjectCollection<T>? explicit operator DiGi.Core.Classes.SerializableObjectCollection<T>?(System.Collections.Generic.List<T>? serializableObjects);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.op_ExplicitDiGi.Core.Classes.SerializableObjectCollection_T_(System.Collections.Generic.List_T_).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list of objects to convert into a collection\.

#### Returns
[DiGi\.Core\.Classes\.SerializableObjectCollection&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>')  
A new instance of [SerializableObjectCollection&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>') containing the provided elements, or null if the input list is null\.

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.op_ExplicitDiGi.Core.Classes.SerializableObjectCollection_T_(T[])'></a>

## SerializableObjectCollection\<T\>\.explicit operator SerializableObjectCollection\<T\>\(T\[\]\) Operator

Explicitly converts an array of type [T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T') to a [SerializableObjectCollection&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>')\.

```csharp
public static DiGi.Core.Classes.SerializableObjectCollection<T>? explicit operator DiGi.Core.Classes.SerializableObjectCollection<T>?(T[]? serializableObjects);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.op_ExplicitDiGi.Core.Classes.SerializableObjectCollection_T_(T[]).serializableObjects'></a>

`serializableObjects` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The array of objects to convert into a collection\.

#### Returns
[DiGi\.Core\.Classes\.SerializableObjectCollection&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>')  
A new instance of [SerializableObjectCollection&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>') containing the provided elements, or null if the input array is null\.

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.op_ExplicitSystem.Collections.Generic.List_T_(DiGi.Core.Classes.SerializableObjectCollection_T_)'></a>

## SerializableObjectCollection\<T\>\.explicit operator List\<T\>\(SerializableObjectCollection\<T\>\) Operator

Explicitly converts a [SerializableObjectCollection&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>') to a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')\.

```csharp
public static System.Collections.Generic.List<T>? explicit operator System.Collections.Generic.List<T>?(DiGi.Core.Classes.SerializableObjectCollection<T>? serializableObjectCollection);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.op_ExplicitSystem.Collections.Generic.List_T_(DiGi.Core.Classes.SerializableObjectCollection_T_).serializableObjectCollection'></a>

`serializableObjectCollection` [DiGi\.Core\.Classes\.SerializableObjectCollection&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>')

The serializable object collection to convert into a list\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A new instance of [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the elements from the source collection, or null if the input collection is null\.

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.op_ExplicitT[](DiGi.Core.Classes.SerializableObjectCollection_T_)'></a>

## SerializableObjectCollection\<T\>\.explicit operator T\[\]\(SerializableObjectCollection\<T\>\) Operator

Explicitly converts the [SerializableObjectCollection&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>') to an array of type [T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')\.

```csharp
public static T[]? explicit operator T[]?(DiGi.Core.Classes.SerializableObjectCollection<T>? serializableObjectCollection);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.op_ExplicitT[](DiGi.Core.Classes.SerializableObjectCollection_T_).serializableObjectCollection'></a>

`serializableObjectCollection` [DiGi\.Core\.Classes\.SerializableObjectCollection&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_ 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>')

The collection instance to convert\.

#### Returns
[T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectCollection_T_.T 'DiGi\.Core\.Classes\.SerializableObjectCollection\<T\>\.T')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array containing the elements of the collection, or null if the provided collection is null\.
### Explicit Interface Implementations

<a name='DiGi.Core.Classes.SerializableObjectCollection_T_.System.Collections.IEnumerable.GetEnumerator()'></a>

## System\.Collections\.IEnumerable\.GetEnumerator\(\) Method

Returns an enumerator that iterates through a collection\.

```csharp
System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

<a name='DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_'></a>

## SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\> Class

Base class for clusters of serializable objects keyed by two keys\.

```csharp
public abstract class SerializableObjectListCluster<TKey_1,TKey_2,TValue> : DiGi.Core.Classes.List<TKey_1, TKey_2, TValue>, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
    where TValue : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.TKey_1'></a>

`TKey_1`

The type of the first key\.

<a name='DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.TKey_2'></a>

`TKey_2`

The type of the second key\.

<a name='DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.TValue'></a>

`TValue`

The type of the values in the cluster\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Cluster&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')[TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')[TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>') → [DiGi\.Core\.Classes\.List&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>')[TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>')[TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.List_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.List\<TKey\_1,TKey\_2,TValue\>') → SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>

Implements [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.SerializableObjectListCluster()'></a>

## SerializableObjectListCluster\(\) Constructor

Initializes a new instance of the SerializableObjectListCluster class\.

```csharp
public SerializableObjectListCluster();
```

<a name='DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.SerializableObjectListCluster(DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_)'></a>

## SerializableObjectListCluster\(SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>\) Constructor

Initializes a new instance of the SerializableObjectListCluster class from another serializable list cluster\.

```csharp
public SerializableObjectListCluster(DiGi.Core.Classes.SerializableObjectListCluster<TKey_1,TKey_2,TValue>? serializableObjectListCluster);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.SerializableObjectListCluster(DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_).serializableObjectListCluster'></a>

`serializableObjectListCluster` [DiGi\.Core\.Classes\.SerializableObjectListCluster&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>')[TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>')[TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>')

The source serializable list cluster to copy from\.

<a name='DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.SerializableObjectListCluster(System.Collections.Generic.IEnumerable_TValue_)'></a>

## SerializableObjectListCluster\(IEnumerable\<TValue\>\) Constructor

Initializes a new instance of the SerializableObjectListCluster class using the specified collection of values\.

```csharp
public SerializableObjectListCluster(System.Collections.Generic.IEnumerable<TValue>? values);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.SerializableObjectListCluster(System.Collections.Generic.IEnumerable_TValue_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of values to initialize the cluster with\.

<a name='DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.SerializableObjectListCluster(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableObjectListCluster\(JsonObject\) Constructor

Initializes a new instance of the SerializableObjectListCluster class from a JSON object\.

```csharp
public SerializableObjectListCluster(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.SerializableObjectListCluster(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the cluster from\.
### Methods

<a name='DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.Clone()'></a>

## SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>\.Clone\(\) Method

Creates a deep copy of the current serializable value cluster\.

```csharp
public virtual DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.Clone() 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>\.Clone\(\)')

#### Returns
[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a clone of the current instance, or null\.

<a name='DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.FromJsonObject(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>\.FromJsonObject\(JsonObject\) Method

Populates the current instance from the specified JSON object\.

```csharp
public bool FromJsonObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.FromJsonObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to populate the instance from\.

Implements [FromJsonObject\(JsonObject\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject.FromJsonObject(System.Text.Json.Nodes.JsonObject) 'DiGi\.Core\.Interfaces\.ISerializableObject\.FromJsonObject\(System\.Text\.Json\.Nodes\.JsonObject\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the population was successful; otherwise, false\.

<a name='DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_.ToJsonObject()'></a>

## SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>\.ToJsonObject\(\) Method

Converts the current instance into a JSON object\.

```csharp
public System.Text.Json.Nodes.JsonObject? ToJsonObject();
```

Implements [ToJsonObject\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject.ToJsonObject() 'DiGi\.Core\.Interfaces\.ISerializableObject\.ToJsonObject\(\)')

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') representation of the current instance, or null\.

<a name='DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_'></a>

## SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\> Class

Represents a base abstract serializable value cluster\.

```csharp
public abstract class SerializableObjectValueCluster<TKey_1,TKey_2,TValue> : DiGi.Core.Classes.ValueCluster<TKey_1, TKey_2, TValue>, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
    where TValue : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.TKey_1'></a>

`TKey_1`

The type of the first key\.

<a name='DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.TKey_2'></a>

`TKey_2`

The type of the second key\.

<a name='DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.TValue'></a>

`TValue`

The type of the value\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Cluster&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')[TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')[TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>') → [DiGi\.Core\.Classes\.ValueCluster&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>')[TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>')[TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>') → SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>

Derived  
↳ [UniqueObjectValueCluster&lt;TValue&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_ 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>')

Implements [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.SerializableObjectValueCluster()'></a>

## SerializableObjectValueCluster\(\) Constructor

Initializes a new instance of the SerializableObjectValueCluster class\.

```csharp
public SerializableObjectValueCluster();
```

<a name='DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.SerializableObjectValueCluster(DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_)'></a>

## SerializableObjectValueCluster\(SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>\) Constructor

Initializes a new instance of the SerializableObjectValueCluster class from another serializable value cluster\.

```csharp
public SerializableObjectValueCluster(DiGi.Core.Classes.SerializableObjectValueCluster<TKey_1,TKey_2,TValue>? serializableObjectValueCluster);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.SerializableObjectValueCluster(DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_).serializableObjectValueCluster'></a>

`serializableObjectValueCluster` [DiGi\.Core\.Classes\.SerializableObjectValueCluster&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>')[TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>')[TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>')

The serializable value cluster to copy from\.

<a name='DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.SerializableObjectValueCluster(System.Collections.Generic.IEnumerable_TValue_)'></a>

## SerializableObjectValueCluster\(IEnumerable\<TValue\>\) Constructor

Initializes a new instance of the SerializableObjectValueCluster class using the specified collection of values\.

```csharp
public SerializableObjectValueCluster(System.Collections.Generic.IEnumerable<TValue>? values);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.SerializableObjectValueCluster(System.Collections.Generic.IEnumerable_TValue_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of values to initialize the cluster with\.

<a name='DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.SerializableObjectValueCluster(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableObjectValueCluster\(JsonObject\) Constructor

Initializes a new instance of the SerializableObjectValueCluster class from a JSON object\.

```csharp
public SerializableObjectValueCluster(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.SerializableObjectValueCluster(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the current instance\.
### Methods

<a name='DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.Clone()'></a>

## SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>\.Clone\(\) Method

Creates a deep copy of the current serializable value cluster\.

```csharp
public virtual DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.Clone() 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>\.Clone\(\)')

#### Returns
[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a deep copy of the current instance, or null\.

<a name='DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.FromJsonObject(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>\.FromJsonObject\(JsonObject\) Method

Populates the current instance from the specified JSON object\.

```csharp
public bool FromJsonObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.FromJsonObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to populate the instance from\.

Implements [FromJsonObject\(JsonObject\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject.FromJsonObject(System.Text.Json.Nodes.JsonObject) 'DiGi\.Core\.Interfaces\.ISerializableObject\.FromJsonObject\(System\.Text\.Json\.Nodes\.JsonObject\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the population was successful; otherwise, false\.

<a name='DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_.ToJsonObject()'></a>

## SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>\.ToJsonObject\(\) Method

Converts the current instance into a JSON object\.

```csharp
public System.Text.Json.Nodes.JsonObject? ToJsonObject();
```

Implements [ToJsonObject\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject.ToJsonObject() 'DiGi\.Core\.Interfaces\.ISerializableObject\.ToJsonObject\(\)')

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') representation of the current instance, or null\.

<a name='DiGi.Core.Classes.SerializableObjectWrapper'></a>

## SerializableObjectWrapper Class

A wrapper that encapsulates a JsonObject, allowing it to be treated as a SerializableObject without full deserialization\.

```csharp
public class SerializableObjectWrapper : DiGi.Core.Classes.SerializableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → SerializableObjectWrapper
### Constructors

<a name='DiGi.Core.Classes.SerializableObjectWrapper.SerializableObjectWrapper()'></a>

## SerializableObjectWrapper\(\) Constructor

Initializes a new instance of the [SerializableObjectWrapper](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectWrapper 'DiGi\.Core\.Classes\.SerializableObjectWrapper') class\.

```csharp
public SerializableObjectWrapper();
```

<a name='DiGi.Core.Classes.SerializableObjectWrapper.SerializableObjectWrapper(DiGi.Core.Classes.SerializableObjectWrapper)'></a>

## SerializableObjectWrapper\(SerializableObjectWrapper\) Constructor

Initializes a new instance of the [SerializableObjectWrapper](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectWrapper 'DiGi\.Core\.Classes\.SerializableObjectWrapper') class by copying another instance\.

```csharp
public SerializableObjectWrapper(DiGi.Core.Classes.SerializableObjectWrapper? serializableObjectWrapper);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectWrapper.SerializableObjectWrapper(DiGi.Core.Classes.SerializableObjectWrapper).serializableObjectWrapper'></a>

`serializableObjectWrapper` [SerializableObjectWrapper](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectWrapper 'DiGi\.Core\.Classes\.SerializableObjectWrapper')

The source wrapper to copy from\.

<a name='DiGi.Core.Classes.SerializableObjectWrapper.SerializableObjectWrapper(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableObjectWrapper\(JsonObject\) Constructor

Initializes a new instance of the [SerializableObjectWrapper](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectWrapper 'DiGi\.Core\.Classes\.SerializableObjectWrapper') class from a JSON object\.

```csharp
public SerializableObjectWrapper(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectWrapper.SerializableObjectWrapper(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to wrap\.
### Methods

<a name='DiGi.Core.Classes.SerializableObjectWrapper.Clone()'></a>

## SerializableObjectWrapper\.Clone\(\) Method

Creates a new object that is a copy of the current instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.Clone() 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>\.Clone\(\)')

#### Returns
[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new object that is a copy of this instance\.

<a name='DiGi.Core.Classes.SerializableObjectWrapper.FromJsonObject(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableObjectWrapper\.FromJsonObject\(JsonObject\) Method

Populates the object's properties from the specified JsonObject\.

```csharp
public override bool FromJsonObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectWrapper.FromJsonObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JsonObject to populate from\.

Implements [FromJsonObject\(JsonObject\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject.FromJsonObject(System.Text.Json.Nodes.JsonObject) 'DiGi\.Core\.Interfaces\.ISerializableObject\.FromJsonObject\(System\.Text\.Json\.Nodes\.JsonObject\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the operation was successful; otherwise, false\.

<a name='DiGi.Core.Classes.SerializableObjectWrapper.ToJsonObject()'></a>

## SerializableObjectWrapper\.ToJsonObject\(\) Method

Converts the current instance into a JsonObject\.

```csharp
public override System.Text.Json.Nodes.JsonObject? ToJsonObject();
```

Implements [ToJsonObject\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject.ToJsonObject() 'DiGi\.Core\.Interfaces\.ISerializableObject\.ToJsonObject\(\)')

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A JsonObject representation of the instance\.

<a name='DiGi.Core.Classes.SerializableObjectWrapper.TryGetFullTypeName(string)'></a>

## SerializableObjectWrapper\.TryGetFullTypeName\(string\) Method

Attempts to retrieve the full type name from the wrapped JsonObject\.

```csharp
public bool TryGetFullTypeName(out string? fullTypeName);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectWrapper.TryGetFullTypeName(string).fullTypeName'></a>

`fullTypeName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

When this method returns, contains the full type name if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the full type name was successfully retrieved; otherwise, false\.
### Operators

<a name='DiGi.Core.Classes.SerializableObjectWrapper.op_ExplicitDiGi.Core.Classes.SerializableObjectWrapper(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableObjectWrapper\.explicit operator SerializableObjectWrapper\(JsonObject\) Operator

Explicitly converts a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') to a [SerializableObjectWrapper](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectWrapper 'DiGi\.Core\.Classes\.SerializableObjectWrapper')\.

```csharp
public static DiGi.Core.Classes.SerializableObjectWrapper? explicit operator DiGi.Core.Classes.SerializableObjectWrapper?(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectWrapper.op_ExplicitDiGi.Core.Classes.SerializableObjectWrapper(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') to convert\.

#### Returns
[SerializableObjectWrapper](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectWrapper 'DiGi\.Core\.Classes\.SerializableObjectWrapper')  
A new [SerializableObjectWrapper](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectWrapper 'DiGi\.Core\.Classes\.SerializableObjectWrapper') instance wrapping the provided [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

<a name='DiGi.Core.Classes.SerializableObjectWrapper.op_ExplicitSystem.Text.Json.Nodes.JsonObject(DiGi.Core.Classes.SerializableObjectWrapper)'></a>

## SerializableObjectWrapper\.explicit operator JsonObject\(SerializableObjectWrapper\) Operator

Explicitly converts a [SerializableObjectWrapper](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectWrapper 'DiGi\.Core\.Classes\.SerializableObjectWrapper') to a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public static System.Text.Json.Nodes.JsonObject? explicit operator System.Text.Json.Nodes.JsonObject?(DiGi.Core.Classes.SerializableObjectWrapper? serializableObjectWrapper);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableObjectWrapper.op_ExplicitSystem.Text.Json.Nodes.JsonObject(DiGi.Core.Classes.SerializableObjectWrapper).serializableObjectWrapper'></a>

`serializableObjectWrapper` [SerializableObjectWrapper](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectWrapper 'DiGi\.Core\.Classes\.SerializableObjectWrapper')

The [SerializableObjectWrapper](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectWrapper 'DiGi\.Core\.Classes\.SerializableObjectWrapper') instance to convert\.

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') representation of the wrapper, or null if the wrapper is null\.

<a name='DiGi.Core.Classes.SerializableOptions'></a>

## SerializableOptions Class

Abstract base class for serializable configuration or option objects\.

```csharp
public abstract class SerializableOptions : DiGi.Core.Classes.SerializableObject, DiGi.Core.Interfaces.ISerializableOptions, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IOptions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → SerializableOptions

Derived  
↳ [ConvertOptions](DiGi.Core.Classes.md#DiGi.Core.Classes.ConvertOptions 'DiGi\.Core\.Classes\.ConvertOptions')

Implements [ISerializableOptions](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableOptions 'DiGi\.Core\.Interfaces\.ISerializableOptions'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [IOptions](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IOptions 'DiGi\.Core\.Interfaces\.IOptions')
### Constructors

<a name='DiGi.Core.Classes.SerializableOptions.SerializableOptions()'></a>

## SerializableOptions\(\) Constructor

Initializes a new instance of the [SerializableOptions](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableOptions 'DiGi\.Core\.Classes\.SerializableOptions') class\.

```csharp
public SerializableOptions();
```

<a name='DiGi.Core.Classes.SerializableOptions.SerializableOptions(DiGi.Core.Classes.SerializableOptions)'></a>

## SerializableOptions\(SerializableOptions\) Constructor

Initializes a new instance of the [SerializableOptions](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableOptions 'DiGi\.Core\.Classes\.SerializableOptions') class by copying another options instance\.

```csharp
public SerializableOptions(DiGi.Core.Classes.SerializableOptions? serializableOptions);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableOptions.SerializableOptions(DiGi.Core.Classes.SerializableOptions).serializableOptions'></a>

`serializableOptions` [SerializableOptions](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableOptions 'DiGi\.Core\.Classes\.SerializableOptions')

The source options instance to copy from\.

<a name='DiGi.Core.Classes.SerializableOptions.SerializableOptions(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableOptions\(JsonObject\) Constructor

Initializes a new instance of the [SerializableOptions](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableOptions 'DiGi\.Core\.Classes\.SerializableOptions') class from a JSON object\.

```csharp
public SerializableOptions(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableOptions.SerializableOptions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize options from\.

<a name='DiGi.Core.Classes.SerializableReference'></a>

## SerializableReference Class

Base class for serializable references, owning the rendering of the reference string and equality based on it\.

Derived types do not override [ToString\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference.ToString() 'DiGi\.Core\.Classes\.SerializableReference\.ToString\(\)'); they declare [Segments](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference.Segments 'DiGi\.Core\.Classes\.SerializableReference\.Segments') and this class
            adds the discriminator, the separators and the caching. That keeps every reference on one grammar - a type
            cannot forget its discriminator or its escaping - and lets one rendered string serve
            [ToString\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference.ToString() 'DiGi\.Core\.Classes\.SerializableReference\.ToString\(\)'), [Equals\(IReference\)](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference.Equals(DiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Classes\.SerializableReference\.Equals\(DiGi\.Core\.Interfaces\.IReference\)') and [GetHashCode\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference.GetHashCode() 'DiGi\.Core\.Classes\.SerializableReference\.GetHashCode\(\)') alike.

```csharp
public abstract class SerializableReference : DiGi.Core.Classes.SerializableObject, DiGi.Core.Interfaces.ISerializableReference, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IReference, System.IEquatable<DiGi.Core.Interfaces.IReference>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → SerializableReference

Derived  
↳ [ComplexReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ComplexReference 'DiGi\.Core\.Classes\.ComplexReference')  
↳ [ExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference 'DiGi\.Core\.Classes\.ExternalReference')  
↳ [PropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference 'DiGi\.Core\.Classes\.PropertyReference')  
↳ [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')  
↳ [UniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference 'DiGi\.Core\.Classes\.UniqueReference')

Implements [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

### Remarks
The equality operators declared here apply only when AT LEAST ONE operand is statically typed as
[SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') or a type derived from it\. When both operands are typed as an interface \-
[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference'), [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference'), [IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference') \- C\# finds no
user defined operator candidate and falls back to reference equality, which is false for two equal references
held in separate instances\. Nothing declared here can change that; compare such operands with
[Equals\(this IReference, IReference\)](DiGi.Core.md#DiGi.Core.Query.Equals(thisDiGi.Core.Interfaces.IReference,DiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.Equals\(this DiGi\.Core\.Interfaces\.IReference, DiGi\.Core\.Interfaces\.IReference\)') instead\.
### Constructors

<a name='DiGi.Core.Classes.SerializableReference.SerializableReference()'></a>

## SerializableReference\(\) Constructor

Initializes a new instance of the [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') class\.

```csharp
public SerializableReference();
```

<a name='DiGi.Core.Classes.SerializableReference.SerializableReference(DiGi.Core.Classes.SerializableReference)'></a>

## SerializableReference\(SerializableReference\) Constructor

Initializes a new instance of the [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') class by copying an existing reference\.

```csharp
public SerializableReference(DiGi.Core.Classes.SerializableReference? serializableReference);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableReference.SerializableReference(DiGi.Core.Classes.SerializableReference).serializableReference'></a>

`serializableReference` [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference')

The existing reference to copy\.

<a name='DiGi.Core.Classes.SerializableReference.SerializableReference(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableReference\(JsonObject\) Constructor

Initializes a new instance of the [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') class from a JSON object\.

```csharp
public SerializableReference(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableReference.SerializableReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the reference from\.
### Properties

<a name='DiGi.Core.Classes.SerializableReference.Segments'></a>

## SerializableReference\.Segments Property

Gets the segments of this reference's string form, in order and already escaped\.

Render a scalar with [Segment\(this string\)](DiGi.Core.md#DiGi.Core.Query.Segment(thisstring) 'DiGi\.Core\.Query\.Segment\(this string\)') and a nested reference with
            [Segment\(this IReference\)](DiGi.Core.md#DiGi.Core.Query.Segment(thisDiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.Segment\(this DiGi\.Core\.Interfaces\.IReference\)'). Do NOT include the discriminator, the separators or any
            surrounding decoration - [ToString\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference.ToString() 'DiGi\.Core\.Classes\.SerializableReference\.ToString\(\)') adds those and caches the result.

The order and count declared here IS the parse contract. The method marked with
            [ReferenceFactoryAttribute](DiGi.Core.Classes.md#DiGi.Core.Classes.ReferenceFactoryAttribute 'DiGi\.Core\.Classes\.ReferenceFactoryAttribute') for this type must consume exactly these segments, in this order;
            changing one without the other silently breaks the round trip.

```csharp
protected abstract System.Collections.Generic.IEnumerable<string?> Segments { protected get; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')
### Methods

<a name='DiGi.Core.Classes.SerializableReference.Equals(DiGi.Core.Interfaces.IReference)'></a>

## SerializableReference\.Equals\(IReference\) Method

Determines whether the specified reference is equal to the current serializable reference\. References of
different runtime types are never equal, which keeps the comparison symmetric for derived types that
narrow equality further\.

```csharp
public bool Equals(DiGi.Core.Interfaces.IReference? reference);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableReference.Equals(DiGi.Core.Interfaces.IReference).reference'></a>

`reference` [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')

The reference to compare with the current serializable reference\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified reference is equal to the current serializable reference; otherwise, false\.

<a name='DiGi.Core.Classes.SerializableReference.Equals(object)'></a>

## SerializableReference\.Equals\(object\) Method

Determines whether the specified object is equal to the current serializable reference\.

```csharp
public override bool Equals(object? @object);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableReference.Equals(object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the current serializable reference\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified object is equal to the current serializable reference; otherwise, false\.

<a name='DiGi.Core.Classes.SerializableReference.GetHashCode()'></a>

## SerializableReference\.GetHashCode\(\) Method

Gets the hash code for the current reference, derived from its cached string form\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The hash code for the current reference\.

<a name='DiGi.Core.Classes.SerializableReference.ToString()'></a>

## SerializableReference\.ToString\(\) Method

Returns the reference string: this type's discriminator followed by its [Segments](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference.Segments 'DiGi\.Core\.Classes\.SerializableReference\.Segments')\.

Sealed on purpose. The base owns rendering so that no reference type can drift off the grammar by
            omitting its discriminator or its escaping, and so the result can be cached once and reused by
            [Equals\(IReference\)](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference.Equals(DiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Classes\.SerializableReference\.Equals\(DiGi\.Core\.Interfaces\.IReference\)') and [GetHashCode\(\)](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference.GetHashCode() 'DiGi\.Core\.Classes\.SerializableReference\.GetHashCode\(\)'). Derived types contribute
            [Segments](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference.Segments 'DiGi\.Core\.Classes\.SerializableReference\.Segments') instead.

Never returns null for a type with a registered factory, because the discriminator is always
            emitted.

```csharp
public sealed override string? ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The reference string\.
### Operators

<a name='DiGi.Core.Classes.SerializableReference.op_Equality(DiGi.Core.Classes.SerializableReference,DiGi.Core.Classes.SerializableReference)'></a>

## SerializableReference\.operator ==\(SerializableReference, SerializableReference\) Operator

Compares two [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') instances for equality\.

```csharp
public static bool operator ==(DiGi.Core.Classes.SerializableReference? serializableReference_1, DiGi.Core.Classes.SerializableReference? serializableReference_2);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableReference.op_Equality(DiGi.Core.Classes.SerializableReference,DiGi.Core.Classes.SerializableReference).serializableReference_1'></a>

`serializableReference_1` [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference')

The first serializable reference to compare\.

<a name='DiGi.Core.Classes.SerializableReference.op_Equality(DiGi.Core.Classes.SerializableReference,DiGi.Core.Classes.SerializableReference).serializableReference_2'></a>

`serializableReference_2` [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference')

The second serializable reference to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the two serializable references are equal; otherwise, false\.

<a name='DiGi.Core.Classes.SerializableReference.op_Equality(DiGi.Core.Classes.SerializableReference,DiGi.Core.Interfaces.ISerializableReference)'></a>

## SerializableReference\.operator ==\(SerializableReference, ISerializableReference\) Operator

Compares a [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') instance and an [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference') object for equality\.

```csharp
public static bool operator ==(DiGi.Core.Classes.SerializableReference? serializableReference_1, DiGi.Core.Interfaces.ISerializableReference? @object);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableReference.op_Equality(DiGi.Core.Classes.SerializableReference,DiGi.Core.Interfaces.ISerializableReference).serializableReference_1'></a>

`serializableReference_1` [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference')

The serializable reference to compare\.

<a name='DiGi.Core.Classes.SerializableReference.op_Equality(DiGi.Core.Classes.SerializableReference,DiGi.Core.Interfaces.ISerializableReference).object'></a>

`object` [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference')

The serializable reference object to compare with the first instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the serializable reference and the object are equal; otherwise, false\.

<a name='DiGi.Core.Classes.SerializableReference.op_Equality(DiGi.Core.Classes.SerializableReference,object)'></a>

## SerializableReference\.operator ==\(SerializableReference, object\) Operator

Compares a [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') instance and an object for equality\.

```csharp
public static bool operator ==(DiGi.Core.Classes.SerializableReference? serializableReference_1, object? @object);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableReference.op_Equality(DiGi.Core.Classes.SerializableReference,object).serializableReference_1'></a>

`serializableReference_1` [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference')

The serializable reference to compare\.

<a name='DiGi.Core.Classes.SerializableReference.op_Equality(DiGi.Core.Classes.SerializableReference,object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the serializable reference\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the serializable reference and the object are equal; otherwise, false\.

<a name='DiGi.Core.Classes.SerializableReference.op_Equality(object,DiGi.Core.Classes.SerializableReference)'></a>

## SerializableReference\.operator ==\(object, SerializableReference\) Operator

Compares an object and a [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') instance for equality\.

```csharp
public static bool operator ==(object? serializableReference_1, DiGi.Core.Classes.SerializableReference? serializableReference_2);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableReference.op_Equality(object,DiGi.Core.Classes.SerializableReference).serializableReference_1'></a>

`serializableReference_1` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the serializable reference\.

<a name='DiGi.Core.Classes.SerializableReference.op_Equality(object,DiGi.Core.Classes.SerializableReference).serializableReference_2'></a>

`serializableReference_2` [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference')

The serializable reference to compare with the object\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object and the serializable reference are equal; otherwise, false\.

<a name='DiGi.Core.Classes.SerializableReference.op_Inequality(DiGi.Core.Classes.SerializableReference,DiGi.Core.Classes.SerializableReference)'></a>

## SerializableReference\.operator \!=\(SerializableReference, SerializableReference\) Operator

Compares two [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') instances for inequality\.

```csharp
public static bool operator !=(DiGi.Core.Classes.SerializableReference? serializableReference_1, DiGi.Core.Classes.SerializableReference? serializableReference_2);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableReference.op_Inequality(DiGi.Core.Classes.SerializableReference,DiGi.Core.Classes.SerializableReference).serializableReference_1'></a>

`serializableReference_1` [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference')

The first serializable reference to compare\.

<a name='DiGi.Core.Classes.SerializableReference.op_Inequality(DiGi.Core.Classes.SerializableReference,DiGi.Core.Classes.SerializableReference).serializableReference_2'></a>

`serializableReference_2` [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference')

The second serializable reference to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the two serializable references are not equal; otherwise, false\.

<a name='DiGi.Core.Classes.SerializableReference.op_Inequality(DiGi.Core.Classes.SerializableReference,DiGi.Core.Interfaces.ISerializableReference)'></a>

## SerializableReference\.operator \!=\(SerializableReference, ISerializableReference\) Operator

Compares a [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') instance and an [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference') for inequality\.

```csharp
public static bool operator !=(DiGi.Core.Classes.SerializableReference? serializableReference_1, DiGi.Core.Interfaces.ISerializableReference? @object);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableReference.op_Inequality(DiGi.Core.Classes.SerializableReference,DiGi.Core.Interfaces.ISerializableReference).serializableReference_1'></a>

`serializableReference_1` [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference')

The serializable reference to compare\.

<a name='DiGi.Core.Classes.SerializableReference.op_Inequality(DiGi.Core.Classes.SerializableReference,DiGi.Core.Interfaces.ISerializableReference).object'></a>

`object` [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference')

The object implementing [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference') to compare with the serializable reference\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the serializable reference and the object are not equal; otherwise, false\.

<a name='DiGi.Core.Classes.SerializableReference.op_Inequality(DiGi.Core.Classes.SerializableReference,object)'></a>

## SerializableReference\.operator \!=\(SerializableReference, object\) Operator

Compares a [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') instance and an object for inequality\.

```csharp
public static bool operator !=(DiGi.Core.Classes.SerializableReference? serializableReference_1, object? @object);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableReference.op_Inequality(DiGi.Core.Classes.SerializableReference,object).serializableReference_1'></a>

`serializableReference_1` [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference')

The serializable reference to compare\.

<a name='DiGi.Core.Classes.SerializableReference.op_Inequality(DiGi.Core.Classes.SerializableReference,object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the serializable reference\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the serializable reference and the object are not equal; otherwise, false\.

<a name='DiGi.Core.Classes.SerializableReference.op_Inequality(object,DiGi.Core.Classes.SerializableReference)'></a>

## SerializableReference\.operator \!=\(object, SerializableReference\) Operator

Compares an object and a [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') instance for inequality\.

```csharp
public static bool operator !=(object? serializableReference_1, DiGi.Core.Classes.SerializableReference? serializableReference_2);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableReference.op_Inequality(object,DiGi.Core.Classes.SerializableReference).serializableReference_1'></a>

`serializableReference_1` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare\.

<a name='DiGi.Core.Classes.SerializableReference.op_Inequality(object,DiGi.Core.Classes.SerializableReference).serializableReference_2'></a>

`serializableReference_2` [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference')

The serializable reference to compare with the object\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object and the serializable reference are not equal; otherwise, false\.

<a name='DiGi.Core.Classes.SerializableResult'></a>

## SerializableResult Class

Represents a result that can be serialized\.

```csharp
public abstract class SerializableResult : DiGi.Core.Classes.SerializableObject, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → SerializableResult

Derived  
↳ [SerializableResult&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult_T_ 'DiGi\.Core\.Classes\.SerializableResult\<T\>')

Implements [ISerializableResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [IResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IResult 'DiGi\.Core\.Interfaces\.IResult'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Core.Classes.SerializableResult.SerializableResult()'></a>

## SerializableResult\(\) Constructor

Initializes a new instance of the [SerializableResult](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult 'DiGi\.Core\.Classes\.SerializableResult') class\.

```csharp
public SerializableResult();
```

<a name='DiGi.Core.Classes.SerializableResult.SerializableResult(DiGi.Core.Classes.SerializableResult)'></a>

## SerializableResult\(SerializableResult\) Constructor

Initializes a new instance of the [SerializableResult](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult 'DiGi\.Core\.Classes\.SerializableResult') class from another serializable result\.

```csharp
public SerializableResult(DiGi.Core.Classes.SerializableResult? serializableResult);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableResult.SerializableResult(DiGi.Core.Classes.SerializableResult).serializableResult'></a>

`serializableResult` [SerializableResult](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult 'DiGi\.Core\.Classes\.SerializableResult')

The serializable result to initialize from\.

<a name='DiGi.Core.Classes.SerializableResult.SerializableResult(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableResult\(JsonObject\) Constructor

Initializes a new instance of the [SerializableResult](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult 'DiGi\.Core\.Classes\.SerializableResult') class from the specified JSON object\.

```csharp
public SerializableResult(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableResult.SerializableResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.

<a name='DiGi.Core.Classes.SerializableResult_T_'></a>

## SerializableResult\<T\> Class

Represents a result that can be serialized\.

```csharp
public abstract class SerializableResult<T> : DiGi.Core.Classes.SerializableResult, DiGi.Core.Interfaces.ISerializableResult<T>, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
    where T : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Core.Classes.SerializableResult_T_.T'></a>

`T`

The type of the result\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableResult](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult 'DiGi\.Core\.Classes\.SerializableResult') → SerializableResult\<T\>

Implements [DiGi\.Core\.Interfaces\.ISerializableResult&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult_T_ 'DiGi\.Core\.Interfaces\.ISerializableResult\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult_T_.T 'DiGi\.Core\.Classes\.SerializableResult\<T\>\.T')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult_T_ 'DiGi\.Core\.Interfaces\.ISerializableResult\<T\>'), [ISerializableResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [IResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IResult 'DiGi\.Core\.Interfaces\.IResult'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Core.Classes.SerializableResult_T_.SerializableResult()'></a>

## SerializableResult\(\) Constructor

Initializes a new instance of the [SerializableResult](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult 'DiGi\.Core\.Classes\.SerializableResult') class\.

```csharp
public SerializableResult();
```

<a name='DiGi.Core.Classes.SerializableResult_T_.SerializableResult(DiGi.Core.Classes.SerializableResult_T_)'></a>

## SerializableResult\(SerializableResult\<T\>\) Constructor

Initializes a new instance of the [SerializableResult](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult 'DiGi\.Core\.Classes\.SerializableResult') class from a generic serializable result\.

```csharp
public SerializableResult(DiGi.Core.Classes.SerializableResult<T>? serializableResult);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableResult_T_.SerializableResult(DiGi.Core.Classes.SerializableResult_T_).serializableResult'></a>

`serializableResult` [DiGi\.Core\.Classes\.SerializableResult&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult_T_ 'DiGi\.Core\.Classes\.SerializableResult\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult_T_.T 'DiGi\.Core\.Classes\.SerializableResult\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult_T_ 'DiGi\.Core\.Classes\.SerializableResult\<T\>')

The generic serializable result to initialize from\.

<a name='DiGi.Core.Classes.SerializableResult_T_.SerializableResult(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableResult\(JsonObject\) Constructor

Initializes a new instance of the [SerializableResult](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult 'DiGi\.Core\.Classes\.SerializableResult') class from the specified JSON object\.

```csharp
public SerializableResult(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializableResult_T_.SerializableResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.

<a name='DiGi.Core.Classes.SerializationConstructor'></a>

## SerializationConstructor Class

Encapsulates logic to instantiate an ISerializableObject from a JsonObject, supporting both parameterless and JSON\-aware constructors\.

```csharp
public class SerializationConstructor
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → SerializationConstructor
### Properties

<a name='DiGi.Core.Classes.SerializationConstructor.FullTypeName'></a>

## SerializationConstructor\.FullTypeName Property

Gets the full type name of the type instantiated by this constructor\.

```csharp
public string? FullTypeName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Core.Classes.SerializationConstructor.Create_T_(System.Text.Json.Nodes.JsonObject)'></a>

## SerializationConstructor\.Create\<T\>\(JsonObject\) Method

Creates an instance of the serializable object from a JsonObject\.

```csharp
public T? Create<T>(System.Text.Json.Nodes.JsonObject? jsonObject)
    where T : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.Classes.SerializationConstructor.Create_T_(System.Text.Json.Nodes.JsonObject).T'></a>

`T`

The type of the object to create\.
#### Parameters

<a name='DiGi.Core.Classes.SerializationConstructor.Create_T_(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to populate the created instance\.

#### Returns
[T](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializationConstructor.Create_T_(System.Text.Json.Nodes.JsonObject).T 'DiGi\.Core\.Classes\.SerializationConstructor\.Create\<T\>\(System\.Text\.Json\.Nodes\.JsonObject\)\.T')  
The created instance of type \<typeparam ref="T" /\>, or null if creation fails\.

<a name='DiGi.Core.Classes.SerializationManager'></a>

## SerializationManager Class

Manages caching and retrieval of serialization constructors and method collections to optimize the serialization process\.

```csharp
public class SerializationManager
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → SerializationManager
### Constructors

<a name='DiGi.Core.Classes.SerializationManager.SerializationManager()'></a>

## SerializationManager\(\) Constructor

Initializes a new instance of the [SerializationManager](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializationManager 'DiGi\.Core\.Classes\.SerializationManager') class\.

```csharp
public SerializationManager();
```
### Properties

<a name='DiGi.Core.Classes.SerializationManager.JsonSerializerOptions'></a>

## SerializationManager\.JsonSerializerOptions Property

Gets or sets the options used for JSON serialization and deserialization\.

```csharp
public System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }
```

#### Property Value
[System\.Text\.Json\.JsonSerializerOptions](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializeroptions 'System\.Text\.Json\.JsonSerializerOptions')
### Methods

<a name='DiGi.Core.Classes.SerializationManager.GetSerializationConstructor(string,bool)'></a>

## SerializationManager\.GetSerializationConstructor\(string, bool\) Method

Retrieves the serialization constructor for the specified type name, optionally updating it\.

```csharp
public DiGi.Core.Classes.SerializationConstructor? GetSerializationConstructor(string? fullTypeName, bool update=true);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializationManager.GetSerializationConstructor(string,bool).fullTypeName'></a>

`fullTypeName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The full name of the type whose serialization constructor is to be retrieved\.

<a name='DiGi.Core.Classes.SerializationManager.GetSerializationConstructor(string,bool).update'></a>

`update` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

True to update the constructor if necessary; otherwise, false\.

#### Returns
[SerializationConstructor](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializationConstructor 'DiGi\.Core\.Classes\.SerializationConstructor')  
The serialization constructor, or null if not found\.

<a name='DiGi.Core.Classes.SerializationManager.GetSerializationConstructor(System.Type,bool)'></a>

## SerializationManager\.GetSerializationConstructor\(Type, bool\) Method

Retrieves the serialization constructor for a given type, optionally updating the cache\.

```csharp
public DiGi.Core.Classes.SerializationConstructor? GetSerializationConstructor(System.Type? type, bool update=true);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializationManager.GetSerializationConstructor(System.Type,bool).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type for which to retrieve the serialization constructor\.

<a name='DiGi.Core.Classes.SerializationManager.GetSerializationConstructor(System.Type,bool).update'></a>

`update` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to update the cache if the constructor is not found\.

#### Returns
[SerializationConstructor](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializationConstructor 'DiGi\.Core\.Classes\.SerializationConstructor')  
The serialization constructor for the specified type, or null if none was found\.

<a name='DiGi.Core.Classes.SerializationManager.GetSerializationConstructor_TSerializableObject_(bool)'></a>

## SerializationManager\.GetSerializationConstructor\<TSerializableObject\>\(bool\) Method

Retrieves the serialization constructor, optionally updating it if necessary\.

```csharp
public DiGi.Core.Classes.SerializationConstructor? GetSerializationConstructor<TSerializableObject>(bool update=true)
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.Classes.SerializationManager.GetSerializationConstructor_TSerializableObject_(bool).TSerializableObject'></a>

`TSerializableObject`

The type of the serializable object\.
#### Parameters

<a name='DiGi.Core.Classes.SerializationManager.GetSerializationConstructor_TSerializableObject_(bool).update'></a>

`update` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

True to update the constructor if necessary; otherwise, false\.

#### Returns
[SerializationConstructor](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializationConstructor 'DiGi\.Core\.Classes\.SerializationConstructor')  
The serialization constructor, or null if not found\.

<a name='DiGi.Core.Classes.SerializationManager.GetSerializationMethodCollection(DiGi.Core.Interfaces.ISerializableObject,bool)'></a>

## SerializationManager\.GetSerializationMethodCollection\(ISerializableObject, bool\) Method

Retrieves the collection of serialization methods for the specified object, optionally updating it\.

```csharp
public DiGi.Core.Classes.SerializationMethodCollection? GetSerializationMethodCollection(DiGi.Core.Interfaces.ISerializableObject? serializableObject, bool update=true);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializationManager.GetSerializationMethodCollection(DiGi.Core.Interfaces.ISerializableObject,bool).serializableObject'></a>

`serializableObject` [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The serializable object to retrieve methods for\.

<a name='DiGi.Core.Classes.SerializationManager.GetSerializationMethodCollection(DiGi.Core.Interfaces.ISerializableObject,bool).update'></a>

`update` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

True to update the collection if necessary; otherwise, false\.

#### Returns
[SerializationMethodCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializationMethodCollection 'DiGi\.Core\.Classes\.SerializationMethodCollection')  
The collection of serialization methods, or null if not found\.

<a name='DiGi.Core.Classes.SerializationManager.GetSerializationMethodCollection(System.Type,bool)'></a>

## SerializationManager\.GetSerializationMethodCollection\(Type, bool\) Method

Retrieves the serialization method collection for a given type, optionally updating the cache\.

```csharp
public DiGi.Core.Classes.SerializationMethodCollection? GetSerializationMethodCollection(System.Type? type, bool update=true);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializationManager.GetSerializationMethodCollection(System.Type,bool).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to retrieve the serialization methods for\.

<a name='DiGi.Core.Classes.SerializationManager.GetSerializationMethodCollection(System.Type,bool).update'></a>

`update` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

True to update the cache if necessary; otherwise, false\.

#### Returns
[SerializationMethodCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializationMethodCollection 'DiGi\.Core\.Classes\.SerializationMethodCollection')  
The collection of serialization methods, or null if not found\.

<a name='DiGi.Core.Classes.SerializationManager.GetSerializationMethodCollection_TSerializableObject_(bool)'></a>

## SerializationManager\.GetSerializationMethodCollection\<TSerializableObject\>\(bool\) Method

Retrieves the collection of serialization methods, optionally updating it\.

```csharp
public DiGi.Core.Classes.SerializationMethodCollection? GetSerializationMethodCollection<TSerializableObject>(bool update=true)
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.Classes.SerializationManager.GetSerializationMethodCollection_TSerializableObject_(bool).TSerializableObject'></a>

`TSerializableObject`

The type of the serializable object\.
#### Parameters

<a name='DiGi.Core.Classes.SerializationManager.GetSerializationMethodCollection_TSerializableObject_(bool).update'></a>

`update` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

True to update the collection if necessary; otherwise, false\.

#### Returns
[SerializationMethodCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializationMethodCollection 'DiGi\.Core\.Classes\.SerializationMethodCollection')  
The collection of serialization methods, or null if not found\.

<a name='DiGi.Core.Classes.SerializationMethod'></a>

## SerializationMethod Class

Represents a specific member \(property or field\) targeted for serialization, containing its reflection metadata and name\.

```csharp
public class SerializationMethod
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → SerializationMethod
### Properties

<a name='DiGi.Core.Classes.SerializationMethod.FieldInfo'></a>

## SerializationMethod\.FieldInfo Property

Gets the field information when the member is a field; otherwise, null\.

```csharp
public System.Reflection.FieldInfo? FieldInfo { get; }
```

#### Property Value
[System\.Reflection\.FieldInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.fieldinfo 'System\.Reflection\.FieldInfo')

<a name='DiGi.Core.Classes.SerializationMethod.IsReadable'></a>

## SerializationMethod\.IsReadable Property

Gets a value indicating whether the member value can be read \(a field, or a property with a parameterless getter\)\.

```csharp
public bool IsReadable { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Classes.SerializationMethod.MemberInfo'></a>

## SerializationMethod\.MemberInfo Property

Gets the member information associated with this instance\.

```csharp
public System.Reflection.MemberInfo MemberInfo { get; }
```

#### Property Value
[System\.Reflection\.MemberInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.memberinfo 'System\.Reflection\.MemberInfo')

<a name='DiGi.Core.Classes.SerializationMethod.Name'></a>

## SerializationMethod\.Name Property

Gets the name of the serialization component\.

```csharp
public string Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.SerializationMethod.PropertyInfo'></a>

## SerializationMethod\.PropertyInfo Property

Gets the property information when the member is a property; otherwise, null\.

```csharp
public System.Reflection.PropertyInfo? PropertyInfo { get; }
```

#### Property Value
[System\.Reflection\.PropertyInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo 'System\.Reflection\.PropertyInfo')

<a name='DiGi.Core.Classes.SerializationMethodCollection'></a>

## SerializationMethodCollection Class

A collection of SerializationMethod objects for a specific type; handles the actual conversion between objects and JSON\.

```csharp
public class SerializationMethodCollection
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → SerializationMethodCollection
### Properties

<a name='DiGi.Core.Classes.SerializationMethodCollection.this[string]'></a>

## SerializationMethodCollection\.this\[string\] Property

Gets the [SerializationMethod](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializationMethod 'DiGi\.Core\.Classes\.SerializationMethod') associated with the specified name\.

```csharp
public DiGi.Core.Classes.SerializationMethod? this[string? name] { get; }
```
#### Parameters

<a name='DiGi.Core.Classes.SerializationMethodCollection.this[string].name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the serialization method to retrieve\.

#### Property Value
[SerializationMethod](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializationMethod 'DiGi\.Core\.Classes\.SerializationMethod')
### Methods

<a name='DiGi.Core.Classes.SerializationMethodCollection.Create(DiGi.Core.Interfaces.ISerializableObject)'></a>

## SerializationMethodCollection\.Create\(ISerializableObject\) Method

Creates a JsonObject representing the state of the provided serializable object\.

```csharp
public System.Text.Json.Nodes.JsonObject? Create(DiGi.Core.Interfaces.ISerializableObject? serializableObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializationMethodCollection.Create(DiGi.Core.Interfaces.ISerializableObject).serializableObject'></a>

`serializableObject` [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The serializable object to be converted into a JSON object\.

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') representing the state of the serializable object, or null if it could not be created\.

<a name='DiGi.Core.Classes.SerializationMethodCollection.Update(DiGi.Core.Interfaces.ISerializableObject,System.Text.Json.Nodes.JsonObject)'></a>

## SerializationMethodCollection\.Update\(ISerializableObject, JsonObject\) Method

Updates the provided serializable object using values from a JsonObject\.

```csharp
public bool Update(DiGi.Core.Interfaces.ISerializableObject? serializableObject, System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializationMethodCollection.Update(DiGi.Core.Interfaces.ISerializableObject,System.Text.Json.Nodes.JsonObject).serializableObject'></a>

`serializableObject` [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The serializable object to be updated\.

<a name='DiGi.Core.Classes.SerializationMethodCollection.Update(DiGi.Core.Interfaces.ISerializableObject,System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the source data for the update\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the update was successful; otherwise, false\.

<a name='DiGi.Core.Classes.SerializationMethodCollection.Update(DiGi.Core.Interfaces.ISerializableObject,System.Text.Json.Nodes.JsonObject,System.Collections.Generic.HashSet_string_)'></a>

## SerializationMethodCollection\.Update\(ISerializableObject, JsonObject, HashSet\<string\>\) Method

Updates the specified serializable object using data from a JSON object\.

```csharp
public bool Update(DiGi.Core.Interfaces.ISerializableObject? serializableObject, System.Text.Json.Nodes.JsonObject? jsonObject, out System.Collections.Generic.HashSet<string>? propertyNames);
```
#### Parameters

<a name='DiGi.Core.Classes.SerializationMethodCollection.Update(DiGi.Core.Interfaces.ISerializableObject,System.Text.Json.Nodes.JsonObject,System.Collections.Generic.HashSet_string_).serializableObject'></a>

`serializableObject` [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The serializable object to be updated\.

<a name='DiGi.Core.Classes.SerializationMethodCollection.Update(DiGi.Core.Interfaces.ISerializableObject,System.Text.Json.Nodes.JsonObject,System.Collections.Generic.HashSet_string_).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the source data for the update\.

<a name='DiGi.Core.Classes.SerializationMethodCollection.Update(DiGi.Core.Interfaces.ISerializableObject,System.Text.Json.Nodes.JsonObject,System.Collections.Generic.HashSet_string_).propertyNames'></a>

`propertyNames` [System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')

When this method returns, contains a set of property names that were updated\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the update was successful; otherwise, false\.

<a name='DiGi.Core.Classes.Size'></a>

## Size Class

Defines two\-dimensional dimensions \(Width and Height\) with scaling utilities\.

```csharp
public class Size : DiGi.Core.Classes.SerializableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → Size
### Constructors

<a name='DiGi.Core.Classes.Size.Size()'></a>

## Size\(\) Constructor

Initializes a new empty instance of the Size class\.

```csharp
public Size();
```

<a name='DiGi.Core.Classes.Size.Size(DiGi.Core.Classes.Size)'></a>

## Size\(Size\) Constructor

Initializes a new instance of the Size class by copying another Size object\.

```csharp
public Size(DiGi.Core.Classes.Size? size);
```
#### Parameters

<a name='DiGi.Core.Classes.Size.Size(DiGi.Core.Classes.Size).size'></a>

`size` [Size](DiGi.Core.Classes.md#DiGi.Core.Classes.Size 'DiGi\.Core\.Classes\.Size')

The source size to copy from\.

<a name='DiGi.Core.Classes.Size.Size(double,double)'></a>

## Size\(double, double\) Constructor

Initializes a new instance of the Size class with specified width and height\.

```csharp
public Size(double width, double height);
```
#### Parameters

<a name='DiGi.Core.Classes.Size.Size(double,double).width'></a>

`width` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The width dimension\.

<a name='DiGi.Core.Classes.Size.Size(double,double).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The height dimension\.

<a name='DiGi.Core.Classes.Size.Size(System.Text.Json.Nodes.JsonObject)'></a>

## Size\(JsonObject\) Constructor

Initializes a new instance of the Size class from a JsonObject\.

```csharp
public Size(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.Size.Size(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing size data\.
### Properties

<a name='DiGi.Core.Classes.Size.Height'></a>

## Size\.Height Property

Gets or sets the height dimension of the size\.

```csharp
public double Height { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Classes.Size.Width'></a>

## Size\.Width Property

Gets or sets the width dimension of the size\.

```csharp
public double Width { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.Core.Classes.Size.GetArea()'></a>

## Size\.GetArea\(\) Method

Calculates the total area of the size \(Width \* Height\)\.

```csharp
public double GetArea();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The calculated area\.

<a name='DiGi.Core.Classes.Size.GetScaled(double)'></a>

## Size\.GetScaled\(double\) Method

Returns a new Size object scaled by the given factor\.

```csharp
public DiGi.Core.Classes.Size GetScaled(double value);
```
#### Parameters

<a name='DiGi.Core.Classes.Size.GetScaled(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scaling factor\.

#### Returns
[Size](DiGi.Core.Classes.md#DiGi.Core.Classes.Size 'DiGi\.Core\.Classes\.Size')  
A new scaled Size instance\.

<a name='DiGi.Core.Classes.Size.Scale(double)'></a>

## Size\.Scale\(double\) Method

Scales the current size dimensions by the given factor\.

```csharp
public void Scale(double value);
```
#### Parameters

<a name='DiGi.Core.Classes.Size.Scale(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scaling factor\.
### Operators

<a name='DiGi.Core.Classes.Size.op_ImplicitDiGi.Core.Classes.Size(System.Drawing.Size)'></a>

## Size\.implicit operator Size\(Size\) Operator

Implicitly converts a [System\.Drawing\.Size](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.size 'System\.Drawing\.Size') object to a [Size](DiGi.Core.Classes.md#DiGi.Core.Classes.Size 'DiGi\.Core\.Classes\.Size') instance\.

```csharp
public static DiGi.Core.Classes.Size implicit operator DiGi.Core.Classes.Size(System.Drawing.Size size);
```
#### Parameters

<a name='DiGi.Core.Classes.Size.op_ImplicitDiGi.Core.Classes.Size(System.Drawing.Size).size'></a>

`size` [System\.Drawing\.Size](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.size 'System\.Drawing\.Size')

The [System\.Drawing\.Size](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.size 'System\.Drawing\.Size') object to convert\.

#### Returns
[Size](DiGi.Core.Classes.md#DiGi.Core.Classes.Size 'DiGi\.Core\.Classes\.Size')  
A new [Size](DiGi.Core.Classes.md#DiGi.Core.Classes.Size 'DiGi\.Core\.Classes\.Size') instance created from the provided dimensions\.

<a name='DiGi.Core.Classes.Size.op_ImplicitDiGi.Core.Classes.Size(System.Drawing.SizeF)'></a>

## Size\.implicit operator Size\(SizeF\) Operator

Implicitly converts a [System\.Drawing\.SizeF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.sizef 'System\.Drawing\.SizeF') object to a [Size](DiGi.Core.Classes.md#DiGi.Core.Classes.Size 'DiGi\.Core\.Classes\.Size') instance\.

```csharp
public static DiGi.Core.Classes.Size implicit operator DiGi.Core.Classes.Size(System.Drawing.SizeF size);
```
#### Parameters

<a name='DiGi.Core.Classes.Size.op_ImplicitDiGi.Core.Classes.Size(System.Drawing.SizeF).size'></a>

`size` [System\.Drawing\.SizeF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.sizef 'System\.Drawing\.SizeF')

The [System\.Drawing\.SizeF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.sizef 'System\.Drawing\.SizeF') object to convert\.

#### Returns
[Size](DiGi.Core.Classes.md#DiGi.Core.Classes.Size 'DiGi\.Core\.Classes\.Size')  
A new [Size](DiGi.Core.Classes.md#DiGi.Core.Classes.Size 'DiGi\.Core\.Classes\.Size') instance created from the provided dimensions\.

<a name='DiGi.Core.Classes.SizeSplitter_T_'></a>

## SizeSplitter\<T\> Class

Splits items by counting them as individual units\.

```csharp
public class SizeSplitter<T> : DiGi.Core.Classes.Splitter<T, int>
```
#### Type parameters

<a name='DiGi.Core.Classes.SizeSplitter_T_.T'></a>

`T`

The type of the items to be split\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Splitter&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Splitter_T,X_ 'DiGi\.Core\.Classes\.Splitter\<T,X\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.SizeSplitter_T_.T 'DiGi\.Core\.Classes\.SizeSplitter\<T\>\.T')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.Splitter_T,X_ 'DiGi\.Core\.Classes\.Splitter\<T,X\>')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Splitter_T,X_ 'DiGi\.Core\.Classes\.Splitter\<T,X\>') → SizeSplitter\<T\>
### Constructors

<a name='DiGi.Core.Classes.SizeSplitter_T_.SizeSplitter(System.Collections.Generic.IEnumerable_T_)'></a>

## SizeSplitter\(IEnumerable\<T\>\) Constructor

Initializes a new instance of the [SizeSplitter&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SizeSplitter_T_ 'DiGi\.Core\.Classes\.SizeSplitter\<T\>') class\.

```csharp
public SizeSplitter(System.Collections.Generic.IEnumerable<T> items);
```
#### Parameters

<a name='DiGi.Core.Classes.SizeSplitter_T_.SizeSplitter(System.Collections.Generic.IEnumerable_T_).items'></a>

`items` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.SizeSplitter_T_.T 'DiGi\.Core\.Classes\.SizeSplitter\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of items to be split\.
### Methods

<a name='DiGi.Core.Classes.SizeSplitter_T_.GetValue(T)'></a>

## SizeSplitter\<T\>\.GetValue\(T\) Method

Gets the size value for the specified item\.

```csharp
public override int GetValue(T? item);
```
#### Parameters

<a name='DiGi.Core.Classes.SizeSplitter_T_.GetValue(T).item'></a>

`item` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.SizeSplitter_T_.T 'DiGi\.Core\.Classes\.SizeSplitter\<T\>\.T')

The item to get the size value for\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The size value of the specified item\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection'></a>

## SphericalDistributionSerializableObjectCollection Class

Non\-generic version of SphericalDistributionSerializableObjectCollection for handling a collection of ISerializableObjects\.

```csharp
public class SphericalDistributionSerializableObjectCollection : DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection<DiGi.Core.Interfaces.ISerializableObject>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_ 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection\<TSerializableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_ 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection\<TSerializableObject\>') → SphericalDistributionSerializableObjectCollection
### Constructors

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection.SphericalDistributionSerializableObjectCollection()'></a>

## SphericalDistributionSerializableObjectCollection\(\) Constructor

Initializes a new instance of the [SphericalDistributionSerializableObjectCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection') class\.

```csharp
public SphericalDistributionSerializableObjectCollection();
```

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection.SphericalDistributionSerializableObjectCollection(DiGi.Core.Classes.Range_double_,double,DiGi.Core.Classes.Range_double_,double)'></a>

## SphericalDistributionSerializableObjectCollection\(Range\<double\>, double, Range\<double\>, double\) Constructor

Initializes a new instance of the [SphericalDistributionSerializableObjectCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection') class with specified ranges and intervals\.

```csharp
public SphericalDistributionSerializableObjectCollection(DiGi.Core.Classes.Range<double>? azimuthRange, double azimuthInterval, DiGi.Core.Classes.Range<double>? elevationRange, double elevationInterval);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection.SphericalDistributionSerializableObjectCollection(DiGi.Core.Classes.Range_double_,double,DiGi.Core.Classes.Range_double_,double).azimuthRange'></a>

`azimuthRange` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The azimuth range\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection.SphericalDistributionSerializableObjectCollection(DiGi.Core.Classes.Range_double_,double,DiGi.Core.Classes.Range_double_,double).azimuthInterval'></a>

`azimuthInterval` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The azimuth bin interval size\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection.SphericalDistributionSerializableObjectCollection(DiGi.Core.Classes.Range_double_,double,DiGi.Core.Classes.Range_double_,double).elevationRange'></a>

`elevationRange` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The elevation range\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection.SphericalDistributionSerializableObjectCollection(DiGi.Core.Classes.Range_double_,double,DiGi.Core.Classes.Range_double_,double).elevationInterval'></a>

`elevationInterval` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The elevation bin interval size\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection.SphericalDistributionSerializableObjectCollection(DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection)'></a>

## SphericalDistributionSerializableObjectCollection\(SphericalDistributionSerializableObjectCollection\) Constructor

Initializes a new instance of the [SphericalDistributionSerializableObjectCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection') class by copying another collection\.

```csharp
public SphericalDistributionSerializableObjectCollection(DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection? sphericalDistributionCollection);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection.SphericalDistributionSerializableObjectCollection(DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection).sphericalDistributionCollection'></a>

`sphericalDistributionCollection` [SphericalDistributionSerializableObjectCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection')

The collection to copy from\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection.SphericalDistributionSerializableObjectCollection(double,double,double,double,double,double)'></a>

## SphericalDistributionSerializableObjectCollection\(double, double, double, double, double, double\) Constructor

Initializes a new instance of the [SphericalDistributionSerializableObjectCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection') class with specified range boundaries and intervals\.

```csharp
public SphericalDistributionSerializableObjectCollection(double minAzimuth, double maxAzimuth, double azimuthInterval, double minElevation, double maxElevation, double elevationInterval);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection.SphericalDistributionSerializableObjectCollection(double,double,double,double,double,double).minAzimuth'></a>

`minAzimuth` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimum azimuth value\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection.SphericalDistributionSerializableObjectCollection(double,double,double,double,double,double).maxAzimuth'></a>

`maxAzimuth` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum azimuth value\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection.SphericalDistributionSerializableObjectCollection(double,double,double,double,double,double).azimuthInterval'></a>

`azimuthInterval` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The azimuth bin interval size\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection.SphericalDistributionSerializableObjectCollection(double,double,double,double,double,double).minElevation'></a>

`minElevation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimum elevation value\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection.SphericalDistributionSerializableObjectCollection(double,double,double,double,double,double).maxElevation'></a>

`maxElevation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum elevation value\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection.SphericalDistributionSerializableObjectCollection(double,double,double,double,double,double).elevationInterval'></a>

`elevationInterval` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The elevation bin interval size\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection.SphericalDistributionSerializableObjectCollection(System.Text.Json.Nodes.JsonObject)'></a>

## SphericalDistributionSerializableObjectCollection\(JsonObject\) Constructor

Initializes a new instance of the [SphericalDistributionSerializableObjectCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection') class from a JSON object\.

```csharp
public SphericalDistributionSerializableObjectCollection(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection.SphericalDistributionSerializableObjectCollection(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.
### Methods

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection.Clone()'></a>

## SphericalDistributionSerializableObjectCollection\.Clone\(\) Method

Creates a new object that is a copy of the current instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.Clone() 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>\.Clone\(\)')

#### Returns
[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new object that is a copy of this instance\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\> Class

Represents a spherical distribution collection of serializable objects partitioned into azimuth and elevation bins\.

```csharp
public class SphericalDistributionSerializableObjectCollection<TSerializableObject> : DiGi.Core.Classes.SerializableObject
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.TSerializableObject'></a>

`TSerializableObject`

The type of elements stored in the collection\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → SphericalDistributionSerializableObjectCollection\<TSerializableObject\>

Derived  
↳ [SphericalDistributionSerializableObjectCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection')
### Constructors

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.SphericalDistributionSerializableObjectCollection()'></a>

## SphericalDistributionSerializableObjectCollection\(\) Constructor

Initializes a new instance of the [SphericalDistributionSerializableObjectCollection&lt;TSerializableObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_ 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection\<TSerializableObject\>') class\.

```csharp
public SphericalDistributionSerializableObjectCollection();
```

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.SphericalDistributionSerializableObjectCollection(DiGi.Core.Classes.Range_double_,double,DiGi.Core.Classes.Range_double_,double)'></a>

## SphericalDistributionSerializableObjectCollection\(Range\<double\>, double, Range\<double\>, double\) Constructor

Initializes a new instance of the [SphericalDistributionSerializableObjectCollection&lt;TSerializableObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_ 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection\<TSerializableObject\>') class with specified ranges and intervals\.

```csharp
public SphericalDistributionSerializableObjectCollection(DiGi.Core.Classes.Range<double>? azimuthRange, double azimuthInterval, DiGi.Core.Classes.Range<double>? elevationRange, double elevationInterval);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.SphericalDistributionSerializableObjectCollection(DiGi.Core.Classes.Range_double_,double,DiGi.Core.Classes.Range_double_,double).azimuthRange'></a>

`azimuthRange` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The azimuth range\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.SphericalDistributionSerializableObjectCollection(DiGi.Core.Classes.Range_double_,double,DiGi.Core.Classes.Range_double_,double).azimuthInterval'></a>

`azimuthInterval` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The azimuth bin interval size\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.SphericalDistributionSerializableObjectCollection(DiGi.Core.Classes.Range_double_,double,DiGi.Core.Classes.Range_double_,double).elevationRange'></a>

`elevationRange` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The elevation range\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.SphericalDistributionSerializableObjectCollection(DiGi.Core.Classes.Range_double_,double,DiGi.Core.Classes.Range_double_,double).elevationInterval'></a>

`elevationInterval` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The elevation bin interval size\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.SphericalDistributionSerializableObjectCollection(DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_)'></a>

## SphericalDistributionSerializableObjectCollection\(SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\) Constructor

Initializes a new instance of the [SphericalDistributionSerializableObjectCollection&lt;TSerializableObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_ 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection\<TSerializableObject\>') class by copying another instance\.

```csharp
public SphericalDistributionSerializableObjectCollection(DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection<TSerializableObject>? sphericalDistributionCollection);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.SphericalDistributionSerializableObjectCollection(DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_).sphericalDistributionCollection'></a>

`sphericalDistributionCollection` [DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_ 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection\<TSerializableObject\>')[TSerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.TSerializableObject 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.TSerializableObject')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_ 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection\<TSerializableObject\>')

The collection to copy from\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.SphericalDistributionSerializableObjectCollection(double,double,double,double,double,double)'></a>

## SphericalDistributionSerializableObjectCollection\(double, double, double, double, double, double\) Constructor

Initializes a new instance of the [SphericalDistributionSerializableObjectCollection&lt;TSerializableObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_ 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection\<TSerializableObject\>') class with specified range boundaries and intervals\.

```csharp
public SphericalDistributionSerializableObjectCollection(double minAzimuth, double maxAzimuth, double azimuthInterval, double minElevation, double maxElevation, double elevationInterval);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.SphericalDistributionSerializableObjectCollection(double,double,double,double,double,double).minAzimuth'></a>

`minAzimuth` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimum azimuth value\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.SphericalDistributionSerializableObjectCollection(double,double,double,double,double,double).maxAzimuth'></a>

`maxAzimuth` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum azimuth value\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.SphericalDistributionSerializableObjectCollection(double,double,double,double,double,double).azimuthInterval'></a>

`azimuthInterval` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The azimuth bin interval size\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.SphericalDistributionSerializableObjectCollection(double,double,double,double,double,double).minElevation'></a>

`minElevation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimum elevation value\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.SphericalDistributionSerializableObjectCollection(double,double,double,double,double,double).maxElevation'></a>

`maxElevation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum elevation value\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.SphericalDistributionSerializableObjectCollection(double,double,double,double,double,double).elevationInterval'></a>

`elevationInterval` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The elevation bin interval size\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.SphericalDistributionSerializableObjectCollection(System.Text.Json.Nodes.JsonObject)'></a>

## SphericalDistributionSerializableObjectCollection\(JsonObject\) Constructor

Initializes a new instance of the [SphericalDistributionSerializableObjectCollection&lt;TSerializableObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_ 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection\<TSerializableObject\>') class from a JSON object\.

```csharp
public SphericalDistributionSerializableObjectCollection(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.SphericalDistributionSerializableObjectCollection(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.
### Properties

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.AzimuthCount'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.AzimuthCount Property

Gets the azimuth count of bins\.

```csharp
public int AzimuthCount { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.AzimuthInterval'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.AzimuthInterval Property

Gets the azimuth interval\.

```csharp
public double AzimuthInterval { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.AzimuthRange'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.AzimuthRange Property

Gets the azimuth range\.

```csharp
public DiGi.Core.Classes.Range<double>? AzimuthRange { get; }
```

#### Property Value
[DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.Count'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.Count Property

Gets the total number of items stored across all bins\.

```csharp
public int Count { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.ElevationCount'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.ElevationCount Property

Gets the elevation count of bins\.

```csharp
public int ElevationCount { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.ElevationInterval'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.ElevationInterval Property

Gets the elevation interval\.

```csharp
public double ElevationInterval { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.ElevationRange'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.ElevationRange Property

Gets the elevation range\.

```csharp
public DiGi.Core.Classes.Range<double>? ElevationRange { get; }
```

#### Property Value
[DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.Values'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.Values Property

Gets all stored elements across all bins as a flat read\-only list\.

```csharp
public System.Collections.Generic.IReadOnlyList<TSerializableObject> Values { get; }
```

#### Property Value
[System\.Collections\.Generic\.IReadOnlyList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')[TSerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.TSerializableObject 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')
### Methods

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.AddValue(double,double,TSerializableObject)'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.AddValue\(double, double, TSerializableObject\) Method

Adds an item to the bin corresponding to the given coordinates\.

```csharp
public void AddValue(double azimuth, double elevation, TSerializableObject? value);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.AddValue(double,double,TSerializableObject).azimuth'></a>

`azimuth` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The azimuth coordinate\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.AddValue(double,double,TSerializableObject).elevation'></a>

`elevation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The elevation coordinate\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.AddValue(double,double,TSerializableObject).value'></a>

`value` [TSerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.TSerializableObject 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.TSerializableObject')

The item to add\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.AddValues(double,double,System.Collections.Generic.IEnumerable_TSerializableObject_)'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.AddValues\(double, double, IEnumerable\<TSerializableObject\>\) Method

Adds multiple items to the bin corresponding to the given coordinates\.

```csharp
public void AddValues(double azimuth, double elevation, System.Collections.Generic.IEnumerable<TSerializableObject>? values);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.AddValues(double,double,System.Collections.Generic.IEnumerable_TSerializableObject_).azimuth'></a>

`azimuth` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The azimuth coordinate\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.AddValues(double,double,System.Collections.Generic.IEnumerable_TSerializableObject_).elevation'></a>

`elevation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The elevation coordinate\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.AddValues(double,double,System.Collections.Generic.IEnumerable_TSerializableObject_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TSerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.TSerializableObject 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of items to add\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.Clear()'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.Clear\(\) Method

Clears all items stored in all bins\.

```csharp
public void Clear();
```

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.FromJsonObject(System.Text.Json.Nodes.JsonObject)'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.FromJsonObject\(JsonObject\) Method

Populates the instance properties and grid bins from a JSON object\.

```csharp
public override bool FromJsonObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.FromJsonObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing serialized data\.

Implements [FromJsonObject\(JsonObject\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject.FromJsonObject(System.Text.Json.Nodes.JsonObject) 'DiGi\.Core\.Interfaces\.ISerializableObject\.FromJsonObject\(System\.Text\.Json\.Nodes\.JsonObject\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if population succeeded; otherwise, false\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetAzimuthIndex(double)'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.GetAzimuthIndex\(double\) Method

Maps an azimuth value to the corresponding 0\-based array index using the defined domain starting from minimum azimuth\.

```csharp
private int GetAzimuthIndex(double azimuth);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetAzimuthIndex(double).azimuth'></a>

`azimuth` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetAzimuthRange(int)'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.GetAzimuthRange\(int\) Method

Gets the azimuth range corresponding to the specified azimuth index, starting from minimum azimuth\.

```csharp
public DiGi.Core.Classes.Range<double>? GetAzimuthRange(int azimuthIndex);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetAzimuthRange(int).azimuthIndex'></a>

`azimuthIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based azimuth index\.

#### Returns
[DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')  
The azimuth range for the specified index, or null if the index is out of bounds\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetAzimuthRanges(bool)'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.GetAzimuthRanges\(bool\) Method

Gets a list of azimuth ranges for all partitions, optionally filtering to populated partitions only\.

```csharp
public System.Collections.Generic.List<DiGi.Core.Classes.Range<double>>? GetAzimuthRanges(bool populatedOnly=false);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetAzimuthRanges(bool).populatedOnly'></a>

`populatedOnly` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If true, returns azimuth ranges only for partitions containing at least one item\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of azimuth ranges, or null if grid is uninitialized\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetElevationIndex(double)'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.GetElevationIndex\(double\) Method

Maps an elevation value to the corresponding 0\-based array index using the defined domain starting from minimum elevation\.

```csharp
private int GetElevationIndex(double elevation);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetElevationIndex(double).elevation'></a>

`elevation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetElevationRange(int)'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.GetElevationRange\(int\) Method

Gets the elevation range corresponding to the specified elevation index, starting from minimum elevation\.

```csharp
public DiGi.Core.Classes.Range<double>? GetElevationRange(int elevationIndex);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetElevationRange(int).elevationIndex'></a>

`elevationIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based elevation index\.

#### Returns
[DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')  
The elevation range for the specified index, or null if the index is out of bounds\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetElevationRanges(bool)'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.GetElevationRanges\(bool\) Method

Gets a list of elevation ranges for all partitions, optionally filtering to populated partitions only\.

```csharp
public System.Collections.Generic.List<DiGi.Core.Classes.Range<double>>? GetElevationRanges(bool populatedOnly=false);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetElevationRanges(bool).populatedOnly'></a>

`populatedOnly` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If true, returns elevation ranges only for partitions containing at least one item\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of elevation ranges, or null if grid is uninitialized\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetValues(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_)'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.GetValues\(Range\<double\>, Range\<double\>\) Method

Retrieves items stored within specified range bounds\.

```csharp
public System.Collections.Generic.IReadOnlyList<TSerializableObject>? GetValues(DiGi.Core.Classes.Range<double>? azimuthRange, DiGi.Core.Classes.Range<double>? elevationRange);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetValues(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_).azimuthRange'></a>

`azimuthRange` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range of azimuth coordinates\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetValues(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_).elevationRange'></a>

`elevationRange` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range of elevation coordinates\.

#### Returns
[System\.Collections\.Generic\.IReadOnlyList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')[TSerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.TSerializableObject 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')  
A read\-only list of items matching the criteria, or null if ranges are null\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetValues(double,double)'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.GetValues\(double, double\) Method

Retrieves items stored in the exact bin corresponding to the given coordinates\.

```csharp
public System.Collections.Generic.IReadOnlyList<TSerializableObject>? GetValues(double azimuth, double elevation);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetValues(double,double).azimuth'></a>

`azimuth` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The azimuth coordinate\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetValues(double,double).elevation'></a>

`elevation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The elevation coordinate\.

#### Returns
[System\.Collections\.Generic\.IReadOnlyList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')[TSerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.TSerializableObject 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')  
A read\-only list of items stored at the given coordinates\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetValues(double,double,double,double)'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.GetValues\(double, double, double, double\) Method

Retrieves all items within the specified bounds, handling internal wrap\-around for azimuth\.

```csharp
public System.Collections.Generic.IReadOnlyList<TSerializableObject>? GetValues(double startAzimuth, double endAzimuth, double startElevation, double endElevation);
```
#### Parameters

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetValues(double,double,double,double).startAzimuth'></a>

`startAzimuth` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The starting azimuth coordinate\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetValues(double,double,double,double).endAzimuth'></a>

`endAzimuth` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The ending azimuth coordinate\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetValues(double,double,double,double).startElevation'></a>

`startElevation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The starting elevation coordinate\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.GetValues(double,double,double,double).endElevation'></a>

`endElevation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The ending elevation coordinate\.

#### Returns
[System\.Collections\.Generic\.IReadOnlyList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')[TSerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.TSerializableObject 'DiGi\.Core\.Classes\.SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')  
A read\-only list of items within the bounds\.

<a name='DiGi.Core.Classes.SphericalDistributionSerializableObjectCollection_TSerializableObject_.ToJsonObject()'></a>

## SphericalDistributionSerializableObjectCollection\<TSerializableObject\>\.ToJsonObject\(\) Method

Converts the current instance into a JsonObject representation\.

```csharp
public override System.Text.Json.Nodes.JsonObject? ToJsonObject();
```

Implements [ToJsonObject\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject.ToJsonObject() 'DiGi\.Core\.Interfaces\.ISerializableObject\.ToJsonObject\(\)')

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A JsonObject representation, or null\.

<a name='DiGi.Core.Classes.Splitter_T,X_'></a>

## Splitter\<T,X\> Class

Provides a base implementation for splitting a collection of items into groups\.

```csharp
public abstract class Splitter<T,X>
    where X : struct, System.IComparable, System.IConvertible
```
#### Type parameters

<a name='DiGi.Core.Classes.Splitter_T,X_.T'></a>

`T`

The type of elements in the collection to be split\.

<a name='DiGi.Core.Classes.Splitter_T,X_.X'></a>

`X`

The type used to determine the value of each element for splitting purposes\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Splitter\<T,X\>

Derived  
↳ [MemorySizeSplitter&lt;TSerializableObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.MemorySizeSplitter_TSerializableObject_ 'DiGi\.Core\.Classes\.MemorySizeSplitter\<TSerializableObject\>')  
↳ [SizeSplitter&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SizeSplitter_T_ 'DiGi\.Core\.Classes\.SizeSplitter\<T\>')
### Constructors

<a name='DiGi.Core.Classes.Splitter_T,X_.Splitter(System.Collections.Generic.IEnumerable_T_)'></a>

## Splitter\(IEnumerable\<T\>\) Constructor

Initializes a new instance of the [Splitter&lt;T,X&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Splitter_T,X_ 'DiGi\.Core\.Classes\.Splitter\<T,X\>') class with the specified items\.

```csharp
public Splitter(System.Collections.Generic.IEnumerable<T> items);
```
#### Parameters

<a name='DiGi.Core.Classes.Splitter_T,X_.Splitter(System.Collections.Generic.IEnumerable_T_).items'></a>

`items` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.Splitter_T,X_.T 'DiGi\.Core\.Classes\.Splitter\<T,X\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of items to be processed by the splitter\.
### Properties

<a name='DiGi.Core.Classes.Splitter_T,X_.Items'></a>

## Splitter\<T,X\>\.Items Property

Gets or sets the list of items to be processed by the splitter\.

```csharp
public System.Collections.Generic.List<T>? Items { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.Splitter_T,X_.T 'DiGi\.Core\.Classes\.Splitter\<T,X\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.Core.Classes.Splitter_T,X_.GetValue(T)'></a>

## Splitter\<T,X\>\.GetValue\(T\) Method

Retrieves a value associated with the specified item\.

```csharp
public abstract X GetValue(T? item);
```
#### Parameters

<a name='DiGi.Core.Classes.Splitter_T,X_.GetValue(T).item'></a>

`item` [T](DiGi.Core.Classes.md#DiGi.Core.Classes.Splitter_T,X_.T 'DiGi\.Core\.Classes\.Splitter\<T,X\>\.T')

The item for which to retrieve the value\.

#### Returns
[X](DiGi.Core.Classes.md#DiGi.Core.Classes.Splitter_T,X_.X 'DiGi\.Core\.Classes\.Splitter\<T,X\>\.X')  
The value associated with the provided item\.

<a name='DiGi.Core.Classes.Splitter_T,X_.Next(X)'></a>

## Splitter\<T,X\>\.Next\(X\) Method

Returns the next chunk of items that don't exceed the maxValue\.
Returns null when no more items are available\.

```csharp
public System.Collections.Generic.List<T>? Next(X maxValue);
```
#### Parameters

<a name='DiGi.Core.Classes.Splitter_T,X_.Next(X).maxValue'></a>

`maxValue` [X](DiGi.Core.Classes.md#DiGi.Core.Classes.Splitter_T,X_.X 'DiGi\.Core\.Classes\.Splitter\<T,X\>\.X')

The maximum value allowed for the next chunk\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.Splitter_T,X_.T 'DiGi\.Core\.Classes\.Splitter\<T,X\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
The next list of items that fit within the specified maximum value, or null if no more items remain\.

<a name='DiGi.Core.Classes.Splitter_T,X_.Reset()'></a>

## Splitter\<T,X\>\.Reset\(\) Method

Resets the internal iterator index to the beginning\.

```csharp
public void Reset();
```

<a name='DiGi.Core.Classes.Splitter_T,X_.Split(X)'></a>

## Splitter\<T,X\>\.Split\(X\) Method

Splits the items into multiple lists based on the provided maximum value\.

```csharp
public System.Collections.Generic.List<System.Collections.Generic.List<T>>? Split(X maxValue);
```
#### Parameters

<a name='DiGi.Core.Classes.Splitter_T,X_.Split(X).maxValue'></a>

`maxValue` [X](DiGi.Core.Classes.md#DiGi.Core.Classes.Splitter_T,X_.X 'DiGi\.Core\.Classes\.Splitter\<T,X\>\.X')

The maximum value allowed for each split list\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.Splitter_T,X_.T 'DiGi\.Core\.Classes\.Splitter\<T,X\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of lists containing the split items, or null if the operation cannot be completed\.

<a name='DiGi.Core.Classes.Tag'></a>

## Tag Class

A specialized Value class used to associate metadata tags with objects\.

```csharp
public class Tag : DiGi.Core.Classes.Value
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.Value&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Value_TObject_ 'DiGi\.Core\.Classes\.Value\<TObject\>')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Value_TObject_ 'DiGi\.Core\.Classes\.Value\<TObject\>') → [Value](DiGi.Core.Classes.md#DiGi.Core.Classes.Value 'DiGi\.Core\.Classes\.Value') → Tag
### Constructors

<a name='DiGi.Core.Classes.Tag.Tag(bool)'></a>

## Tag\(bool\) Constructor

Initializes a new instance of the Tag class with a boolean value\.

```csharp
public Tag(bool value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(bool).value'></a>

`value` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

The boolean value for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(bool[])'></a>

## Tag\(bool\[\]\) Constructor

Initializes a new instance of the Tag class with a boolean array value\.

```csharp
public Tag(bool[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(bool[]).value'></a>

`value` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The boolean array for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(byte)'></a>

## Tag\(byte\) Constructor

Initializes a new instance of the Tag class with a byte value\.

```csharp
public Tag(byte value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(byte).value'></a>

`value` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')

The byte value for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(byte[])'></a>

## Tag\(byte\[\]\) Constructor

Initializes a new instance of the Tag class with a byte array value\.

```csharp
public Tag(byte[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(byte[]).value'></a>

`value` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The byte array for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(char)'></a>

## Tag\(char\) Constructor

Initializes a new instance of the Tag class with a character value\.

```csharp
public Tag(char value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(char).value'></a>

`value` [System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')

The character value for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(char[])'></a>

## Tag\(char\[\]\) Constructor

Initializes a new instance of the Tag class with a character array value\.

```csharp
public Tag(char[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(char[]).value'></a>

`value` [System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The character array for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(decimal)'></a>

## Tag\(decimal\) Constructor

Initializes a new instance of the Tag class with a decimal value\.

```csharp
public Tag(decimal value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(decimal).value'></a>

`value` [System\.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal 'System\.Decimal')

The decimal value for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(decimal[])'></a>

## Tag\(decimal\[\]\) Constructor

Initializes a new instance of the Tag class with a decimal array value\.

```csharp
public Tag(decimal[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(decimal[]).value'></a>

`value` [System\.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal 'System\.Decimal')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The decimal array for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(DiGi.Core.Classes.Tag)'></a>

## Tag\(Tag\) Constructor

Initializes a new instance of the Tag class by copying another Tag object\.

```csharp
private Tag(DiGi.Core.Classes.Tag? tag);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(DiGi.Core.Classes.Tag).tag'></a>

`tag` [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')

The source tag to copy from\.

<a name='DiGi.Core.Classes.Tag.Tag(DiGi.Core.Interfaces.ISerializableObject)'></a>

## Tag\(ISerializableObject\) Constructor

Initializes a new instance of the Tag class with a serializable object value\.

```csharp
public Tag(DiGi.Core.Interfaces.ISerializableObject? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(DiGi.Core.Interfaces.ISerializableObject).value'></a>

`value` [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The serializable object for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(double)'></a>

## Tag\(double\) Constructor

Initializes a new instance of the Tag class with a double value\.

```csharp
public Tag(double value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(double[])'></a>

## Tag\(double\[\]\) Constructor

Initializes a new instance of the Tag class with a double array value\.

```csharp
public Tag(double[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(double[]).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The double array for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(float)'></a>

## Tag\(float\) Constructor

Initializes a new instance of the Tag class with a float value\.

```csharp
public Tag(float value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(float).value'></a>

`value` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The float value for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(float[])'></a>

## Tag\(float\[\]\) Constructor

Initializes a new instance of the Tag class with a float array value\.

```csharp
public Tag(float[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(float[]).value'></a>

`value` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The float array for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(int)'></a>

## Tag\(int\) Constructor

Initializes a new instance of the Tag class with an integer value\.

```csharp
public Tag(int value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(int).value'></a>

`value` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer value for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(int[])'></a>

## Tag\(int\[\]\) Constructor

Initializes a new instance of the Tag class with an integer array value\.

```csharp
public Tag(int[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(int[]).value'></a>

`value` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The integer array for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(long)'></a>

## Tag\(long\) Constructor

Initializes a new instance of the Tag class with a long integer value\.

```csharp
public Tag(long value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(long).value'></a>

`value` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The long integer value for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(long[])'></a>

## Tag\(long\[\]\) Constructor

Initializes a new instance of the Tag class with a long array value\.

```csharp
public Tag(long[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(long[]).value'></a>

`value` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The long array for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(object)'></a>

## Tag\(object\) Constructor

Initializes a new instance of the Tag class from a generic object value\.

```csharp
private Tag(object? tag);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(object).tag'></a>

`tag` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to associate with the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(sbyte)'></a>

## Tag\(sbyte\) Constructor

Initializes a new instance of the Tag class with a signed byte value\.

```csharp
public Tag(sbyte value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(sbyte).value'></a>

`value` [System\.SByte](https://learn.microsoft.com/en-us/dotnet/api/system.sbyte 'System\.SByte')

The signed byte value for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(sbyte[])'></a>

## Tag\(sbyte\[\]\) Constructor

Initializes a new instance of the Tag class with a signed byte array value\.

```csharp
public Tag(sbyte[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(sbyte[]).value'></a>

`value` [System\.SByte](https://learn.microsoft.com/en-us/dotnet/api/system.sbyte 'System\.SByte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The signed byte array for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(short)'></a>

## Tag\(short\) Constructor

Initializes a new instance of the Tag class with a short integer value\.

```csharp
public Tag(short value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(short).value'></a>

`value` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The short integer value for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(short[])'></a>

## Tag\(short\[\]\) Constructor

Initializes a new instance of the Tag class with a short integer array value\.

```csharp
public Tag(short[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(short[]).value'></a>

`value` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The short integer array for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(string)'></a>

## Tag\(string\) Constructor

Initializes a new instance of the Tag class with a string value\.

```csharp
public Tag(string? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(string).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string value for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(string[])'></a>

## Tag\(string\[\]\) Constructor

Initializes a new instance of the Tag class with a string array value\.

```csharp
public Tag(string[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(string[]).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The string array for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(System.DateTime)'></a>

## Tag\(DateTime\) Constructor

Initializes a new instance of the Tag class with a DateTime value\.

```csharp
public Tag(System.DateTime value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(System.DateTime).value'></a>

`value` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The date and time value for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(System.DateTimeOffset)'></a>

## Tag\(DateTimeOffset\) Constructor

Initializes a new instance of the Tag class with a DateTimeOffset value\.

```csharp
public Tag(System.DateTimeOffset value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(System.DateTimeOffset).value'></a>

`value` [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')

The date, time, and offset value for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(System.DateTimeOffset[])'></a>

## Tag\(DateTimeOffset\[\]\) Constructor

Initializes a new instance of the Tag class with a DateTimeOffset array value\.

```csharp
public Tag(System.DateTimeOffset[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(System.DateTimeOffset[]).value'></a>

`value` [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The DateTimeOffset array for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(System.DateTime[])'></a>

## Tag\(DateTime\[\]\) Constructor

Initializes a new instance of the Tag class with a DateTime array value\.

```csharp
public Tag(System.DateTime[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(System.DateTime[]).value'></a>

`value` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The DateTime array for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(System.Guid)'></a>

## Tag\(Guid\) Constructor

Initializes a new instance of the Tag class with a Guid value\.

```csharp
public Tag(System.Guid value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(System.Guid).value'></a>

`value` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The Guid value for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(System.Guid[])'></a>

## Tag\(Guid\[\]\) Constructor

Initializes a new instance of the Tag class with a Guid array value\.

```csharp
public Tag(System.Guid[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(System.Guid[]).value'></a>

`value` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The Guid array for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(System.Text.Json.Nodes.JsonObject)'></a>

## Tag\(JsonObject\) Constructor

Initializes a new instance of the Tag class from a JsonObject\.

```csharp
private Tag(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing tag data\.

<a name='DiGi.Core.Classes.Tag.Tag(System.TimeSpan)'></a>

## Tag\(TimeSpan\) Constructor

Initializes a new instance of the Tag class with a TimeSpan value\.

```csharp
public Tag(System.TimeSpan value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(System.TimeSpan).value'></a>

`value` [System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan')

The time span value for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(System.TimeSpan[])'></a>

## Tag\(TimeSpan\[\]\) Constructor

Initializes a new instance of the Tag class with a TimeSpan array value\.

```csharp
public Tag(System.TimeSpan[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(System.TimeSpan[]).value'></a>

`value` [System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The TimeSpan array for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(System.Type)'></a>

## Tag\(Type\) Constructor

Initializes a new instance of the Tag class with a Type value\.

```csharp
public Tag(System.Type? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(System.Type).value'></a>

`value` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to wrap for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(uint)'></a>

## Tag\(uint\) Constructor

Initializes a new instance of the Tag class with an unsigned integer value\.

```csharp
public Tag(uint value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(uint).value'></a>

`value` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

The unsigned integer value for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(uint[])'></a>

## Tag\(uint\[\]\) Constructor

Initializes a new instance of the Tag class with an unsigned integer array value\.

```csharp
public Tag(uint[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(uint[]).value'></a>

`value` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The unsigned integer array for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(ulong)'></a>

## Tag\(ulong\) Constructor

Initializes a new instance of the Tag class with an unsigned long integer value\.

```csharp
public Tag(ulong value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(ulong).value'></a>

`value` [System\.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64 'System\.UInt64')

The unsigned long integer value for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(ulong[])'></a>

## Tag\(ulong\[\]\) Constructor

Initializes a new instance of the Tag class with an unsigned long integer array value\.

```csharp
public Tag(ulong[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(ulong[]).value'></a>

`value` [System\.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64 'System\.UInt64')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The unsigned long integer array for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(ushort)'></a>

## Tag\(ushort\) Constructor

Initializes a new instance of the Tag class with an unsigned short integer value\.

```csharp
public Tag(ushort value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(ushort).value'></a>

`value` [System\.UInt16](https://learn.microsoft.com/en-us/dotnet/api/system.uint16 'System\.UInt16')

The unsigned short integer value for the tag\.

<a name='DiGi.Core.Classes.Tag.Tag(ushort[])'></a>

## Tag\(ushort\[\]\) Constructor

Initializes a new instance of the Tag class with an unsigned short integer array value\.

```csharp
public Tag(ushort[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.Tag(ushort[]).value'></a>

`value` [System\.UInt16](https://learn.microsoft.com/en-us/dotnet/api/system.uint16 'System\.UInt16')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The unsigned short integer array for the tag\.
### Properties

<a name='DiGi.Core.Classes.Tag.Value'></a>

## Tag\.Value Property

Gets or sets the underlying value of the tag\.

```csharp
public object? Value { get; set; }
```

Implements [Value](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IValue_TValue_.Value 'DiGi\.Core\.Interfaces\.IValue\<TValue\>\.Value')

#### Property Value
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')
### Methods

<a name='DiGi.Core.Classes.Tag.Clone()'></a>

## Tag\.Clone\(\) Method

Creates a deep copy of the tag by creating a new Tag instance with the current value\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.Clone() 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>\.Clone\(\)')

#### Returns
[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned Tag object\.
### Operators

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(bool)'></a>

## Tag\.implicit operator Tag\(bool\) Operator

Implicitly converts a boolean value to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(bool value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(bool).value'></a>

`value` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

The boolean value to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified boolean value\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(bool[])'></a>

## Tag\.implicit operator Tag\(bool\[\]\) Operator

Implicitly converts a boolean array to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(bool[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(bool[]).value'></a>

`value` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The boolean array to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified boolean array\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(byte)'></a>

## Tag\.implicit operator Tag\(byte\) Operator

Implicitly converts a byte value to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(byte value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(byte).value'></a>

`value` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')

The byte value to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified byte value\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(byte[])'></a>

## Tag\.implicit operator Tag\(byte\[\]\) Operator

Implicitly converts a byte array to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(byte[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(byte[]).value'></a>

`value` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The byte array to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified byte array\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(char)'></a>

## Tag\.implicit operator Tag\(char\) Operator

Implicitly converts a character value to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(char value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(char).value'></a>

`value` [System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')

The character value to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified character value\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(char[])'></a>

## Tag\.implicit operator Tag\(char\[\]\) Operator

Implicitly converts a character array to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(char[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(char[]).value'></a>

`value` [System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The character array to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified character array\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(decimal)'></a>

## Tag\.implicit operator Tag\(decimal\) Operator

Implicitly converts a decimal value to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(decimal value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(decimal).value'></a>

`value` [System\.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal 'System\.Decimal')

The decimal value to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified decimal value\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(decimal[])'></a>

## Tag\.implicit operator Tag\(decimal\[\]\) Operator

Implicitly converts a decimal array to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(decimal[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(decimal[]).value'></a>

`value` [System\.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal 'System\.Decimal')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The decimal array to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified decimal array\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(double)'></a>

## Tag\.implicit operator Tag\(double\) Operator

Implicitly converts a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(double value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(double[])'></a>

## Tag\.implicit operator Tag\(double\[\]\) Operator

Implicitly converts a double precision floating\-point array to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(double[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(double[]).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The double precision floating\-point array to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified double precision floating\-point array\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(float)'></a>

## Tag\.implicit operator Tag\(float\) Operator

Implicitly converts a single\-precision floating\-point value to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(float value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(float).value'></a>

`value` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The float value to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified float value\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(float[])'></a>

## Tag\.implicit operator Tag\(float\[\]\) Operator

Implicitly converts a float array to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(float[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(float[]).value'></a>

`value` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The float array to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified float array\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(int)'></a>

## Tag\.implicit operator Tag\(int\) Operator

Implicitly converts a signed integer value to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(int value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(int).value'></a>

`value` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The signed integer value to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified signed integer value\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(int[])'></a>

## Tag\.implicit operator Tag\(int\[\]\) Operator

Implicitly converts an integer array to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(int[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(int[]).value'></a>

`value` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The integer array to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified integer array\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(long)'></a>

## Tag\.implicit operator Tag\(long\) Operator

Implicitly converts a long integer value to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(long value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(long).value'></a>

`value` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The long integer value to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified long integer value\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(long[])'></a>

## Tag\.implicit operator Tag\(long\[\]\) Operator

Implicitly converts a long integer array to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(long[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(long[]).value'></a>

`value` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The long integer array to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified long integer array\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(sbyte)'></a>

## Tag\.implicit operator Tag\(sbyte\) Operator

Implicitly converts a signed byte value to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(sbyte value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(sbyte).value'></a>

`value` [System\.SByte](https://learn.microsoft.com/en-us/dotnet/api/system.sbyte 'System\.SByte')

The signed byte value to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified signed byte value\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(sbyte[])'></a>

## Tag\.implicit operator Tag\(sbyte\[\]\) Operator

Implicitly converts a signed byte array to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(sbyte[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(sbyte[]).value'></a>

`value` [System\.SByte](https://learn.microsoft.com/en-us/dotnet/api/system.sbyte 'System\.SByte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The signed byte array to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified signed byte array\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(short)'></a>

## Tag\.implicit operator Tag\(short\) Operator

Implicitly converts a short integer value to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(short value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(short).value'></a>

`value` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The short integer value to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified short integer value\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(short[])'></a>

## Tag\.implicit operator Tag\(short\[\]\) Operator

Implicitly converts a short integer array to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(short[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(short[]).value'></a>

`value` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The short integer array to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified short integer array\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(string)'></a>

## Tag\.implicit operator Tag\(string\) Operator

Implicitly converts a [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String') value to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(string? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(string).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String') value to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String') value\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(string[])'></a>

## Tag\.implicit operator Tag\(string\[\]\) Operator

Implicitly converts a string array to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(string[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(string[]).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The string array to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified string array\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(System.DateTime)'></a>

## Tag\.implicit operator Tag\(DateTime\) Operator

Implicitly converts a [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') value to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(System.DateTime value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(System.DateTime).value'></a>

`value` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') value to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') value\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(System.DateTimeOffset)'></a>

## Tag\.implicit operator Tag\(DateTimeOffset\) Operator

Implicitly converts a [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') value to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(System.DateTimeOffset value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(System.DateTimeOffset).value'></a>

`value` [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')

The [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') value to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') value\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(System.DateTimeOffset[])'></a>

## Tag\.implicit operator Tag\(DateTimeOffset\[\]\) Operator

Implicitly converts a [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') array to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(System.DateTimeOffset[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(System.DateTimeOffset[]).value'></a>

`value` [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') array to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') array\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(System.DateTime[])'></a>

## Tag\.implicit operator Tag\(DateTime\[\]\) Operator

Implicitly converts a [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') array to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(System.DateTime[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(System.DateTime[]).value'></a>

`value` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') array to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') array\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(System.Guid)'></a>

## Tag\.implicit operator Tag\(Guid\) Operator

Implicitly converts a [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid') to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(System.Guid value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(System.Guid).value'></a>

`value` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The GUID value to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified GUID\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(System.Guid[])'></a>

## Tag\.implicit operator Tag\(Guid\[\]\) Operator

Implicitly converts a GUID array to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(System.Guid[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(System.Guid[]).value'></a>

`value` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The GUID array to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified GUID array\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(System.TimeSpan)'></a>

## Tag\.implicit operator Tag\(TimeSpan\) Operator

Implicitly converts a [System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan') value to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(System.TimeSpan value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(System.TimeSpan).value'></a>

`value` [System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan')

The [System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan') value to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified [System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan') value\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(System.TimeSpan[])'></a>

## Tag\.implicit operator Tag\(TimeSpan\[\]\) Operator

Implicitly converts a [System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan') array to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(System.TimeSpan[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(System.TimeSpan[]).value'></a>

`value` [System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The [System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan') array to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified [System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan') array\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(System.Type)'></a>

## Tag\.implicit operator Tag\(Type\) Operator

Implicitly converts a [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type') to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(System.Type? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(System.Type).value'></a>

`value` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified type\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(uint)'></a>

## Tag\.implicit operator Tag\(uint\) Operator

Implicitly converts an unsigned integer value to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(uint value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(uint).value'></a>

`value` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

The unsigned integer value to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified unsigned integer value\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(uint[])'></a>

## Tag\.implicit operator Tag\(uint\[\]\) Operator

Implicitly converts an unsigned integer array to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(uint[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(uint[]).value'></a>

`value` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The unsigned integer array to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified unsigned integer array\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(ulong)'></a>

## Tag\.implicit operator Tag\(ulong\) Operator

Implicitly converts an unsigned long integer value to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(ulong value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(ulong).value'></a>

`value` [System\.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64 'System\.UInt64')

The unsigned long integer value to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified unsigned long integer value\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(ulong[])'></a>

## Tag\.implicit operator Tag\(ulong\[\]\) Operator

Implicitly converts an unsigned long integer array to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(ulong[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(ulong[]).value'></a>

`value` [System\.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64 'System\.UInt64')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The unsigned long integer array to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified unsigned long integer array\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(ushort)'></a>

## Tag\.implicit operator Tag\(ushort\) Operator

Implicitly converts an unsigned short integer value to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(ushort value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(ushort).value'></a>

`value` [System\.UInt16](https://learn.microsoft.com/en-us/dotnet/api/system.uint16 'System\.UInt16')

The unsigned short integer value to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified unsigned short integer value\.

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(ushort[])'></a>

## Tag\.implicit operator Tag\(ushort\[\]\) Operator

Implicitly converts an unsigned short integer array to a [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')\.

```csharp
public static DiGi.Core.Classes.Tag implicit operator DiGi.Core.Classes.Tag(ushort[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Tag.op_ImplicitDiGi.Core.Classes.Tag(ushort[]).value'></a>

`value` [System\.UInt16](https://learn.microsoft.com/en-us/dotnet/api/system.uint16 'System\.UInt16')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The unsigned short integer array to be converted\.

#### Returns
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')  
A new [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag') instance initialized with the specified unsigned short integer array\.

<a name='DiGi.Core.Classes.TypePropertyReference'></a>

## TypePropertyReference Class

Represents a reference to a property by its type\.

```csharp
public class TypePropertyReference : DiGi.Core.Classes.PropertyReference<DiGi.Core.Classes.TypeReference>, DiGi.Core.Interfaces.ITypeRelatedSerializableReference, DiGi.Core.Interfaces.ITypeRelatedReference, DiGi.Core.Interfaces.IReference, DiGi.Core.Interfaces.IObject, System.IEquatable<DiGi.Core.Interfaces.IReference>, DiGi.Core.Interfaces.ISerializableReference, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') → [PropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference 'DiGi\.Core\.Classes\.PropertyReference') → [DiGi\.Core\.Classes\.PropertyReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference_USerializableReference_ 'DiGi\.Core\.Classes\.PropertyReference\<USerializableReference\>')[TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference_USerializableReference_ 'DiGi\.Core\.Classes\.PropertyReference\<USerializableReference\>') → TypePropertyReference

Implements [ITypeRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITypeRelatedSerializableReference 'DiGi\.Core\.Interfaces\.ITypeRelatedSerializableReference'), [ITypeRelatedReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITypeRelatedReference 'DiGi\.Core\.Interfaces\.ITypeRelatedReference'), [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1'), [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject')

### Example
Renders and parses \(via [TryParse\(this string, IReference\)](DiGi.Core.md#DiGi.Core.Query.TryParse(thisstring,DiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.TryParse\(this string, DiGi\.Core\.Interfaces\.IReference\)')\) as the discriminator, the
nested type reference, then the property name:

```csharp
TypeProperty::(Type::DiGi.GIS.Classes.Building2D,DiGi.GIS)::Name
```
### Constructors

<a name='DiGi.Core.Classes.TypePropertyReference.TypePropertyReference(DiGi.Core.Classes.TypePropertyReference)'></a>

## TypePropertyReference\(TypePropertyReference\) Constructor

Initializes a new instance of the [TypePropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypePropertyReference 'DiGi\.Core\.Classes\.TypePropertyReference') class by copying an existing reference\.

```csharp
public TypePropertyReference(DiGi.Core.Classes.TypePropertyReference? typePropertyReference);
```
#### Parameters

<a name='DiGi.Core.Classes.TypePropertyReference.TypePropertyReference(DiGi.Core.Classes.TypePropertyReference).typePropertyReference'></a>

`typePropertyReference` [TypePropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypePropertyReference 'DiGi\.Core\.Classes\.TypePropertyReference')

The existing reference to copy\.

<a name='DiGi.Core.Classes.TypePropertyReference.TypePropertyReference(DiGi.Core.Classes.TypeReference,string)'></a>

## TypePropertyReference\(TypeReference, string\) Constructor

Initializes a new instance of the [TypePropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypePropertyReference 'DiGi\.Core\.Classes\.TypePropertyReference') class using a type reference and a property name\.

```csharp
public TypePropertyReference(DiGi.Core.Classes.TypeReference? reference, string? propertyName);
```
#### Parameters

<a name='DiGi.Core.Classes.TypePropertyReference.TypePropertyReference(DiGi.Core.Classes.TypeReference,string).reference'></a>

`reference` [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')

The type reference\.

<a name='DiGi.Core.Classes.TypePropertyReference.TypePropertyReference(DiGi.Core.Classes.TypeReference,string).propertyName'></a>

`propertyName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the property\.

<a name='DiGi.Core.Classes.TypePropertyReference.TypePropertyReference(System.Text.Json.Nodes.JsonObject)'></a>

## TypePropertyReference\(JsonObject\) Constructor

Initializes a new instance of the [TypePropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypePropertyReference 'DiGi\.Core\.Classes\.TypePropertyReference') class from a JSON object\.

```csharp
public TypePropertyReference(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.TypePropertyReference.TypePropertyReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.
### Properties

<a name='DiGi.Core.Classes.TypePropertyReference.FullTypeName'></a>

## TypePropertyReference\.FullTypeName Property

Gets the full name of the referenced type\.

```csharp
public string? FullTypeName { get; }
```

Implements [FullTypeName](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITypeRelatedReference.FullTypeName 'DiGi\.Core\.Interfaces\.ITypeRelatedReference\.FullTypeName')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Core.Classes.TypePropertyReference.Clone()'></a>

## TypePropertyReference\.Clone\(\) Method

Creates a deep copy of the current object\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject Clone();
```

Implements [Clone\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.Clone() 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>\.Clone\(\)')

#### Returns
[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A deep copy of the current object\.

<a name='DiGi.Core.Classes.TypeReference'></a>

## TypeReference Class

Represents a reference to a \.NET type by its full name\.

```csharp
public class TypeReference : DiGi.Core.Classes.SerializableReference, DiGi.Core.Interfaces.ITypeRelatedSerializableReference, DiGi.Core.Interfaces.ITypeRelatedReference, DiGi.Core.Interfaces.IReference, DiGi.Core.Interfaces.IObject, System.IEquatable<DiGi.Core.Interfaces.IReference>, DiGi.Core.Interfaces.ISerializableReference, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') → TypeReference

Implements [ITypeRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITypeRelatedSerializableReference 'DiGi\.Core\.Interfaces\.ITypeRelatedSerializableReference'), [ITypeRelatedReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITypeRelatedReference 'DiGi\.Core\.Interfaces\.ITypeRelatedReference'), [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1'), [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject')

### Example
Renders and parses \(via [TryParse\(this string, IReference\)](DiGi.Core.md#DiGi.Core.Query.TryParse(thisstring,DiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.TryParse\(this string, DiGi\.Core\.Interfaces\.IReference\)')\) as:

```csharp
Type::DiGi.GIS.Classes.Building2D,DiGi.GIS
```
### Constructors

<a name='DiGi.Core.Classes.TypeReference.TypeReference(DiGi.Core.Classes.TypeReference)'></a>

## TypeReference\(TypeReference\) Constructor

Initializes a new instance of the [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference') class by copying an existing type reference\.

```csharp
public TypeReference(DiGi.Core.Classes.TypeReference? typeReference);
```
#### Parameters

<a name='DiGi.Core.Classes.TypeReference.TypeReference(DiGi.Core.Classes.TypeReference).typeReference'></a>

`typeReference` [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')

The existing type reference to copy\.

<a name='DiGi.Core.Classes.TypeReference.TypeReference(DiGi.Core.Interfaces.IObject)'></a>

## TypeReference\(IObject\) Constructor

Initializes a new instance of the [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference') class based on the provided object\.

```csharp
public TypeReference(DiGi.Core.Interfaces.IObject? @object);
```
#### Parameters

<a name='DiGi.Core.Classes.TypeReference.TypeReference(DiGi.Core.Interfaces.IObject).object'></a>

`object` [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')

The object to use for initializing the current type reference\.

<a name='DiGi.Core.Classes.TypeReference.TypeReference(string)'></a>

## TypeReference\(string\) Constructor

Initializes a new instance of the [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference') class using the specified full type name\.

```csharp
public TypeReference(string? fullTypeName);
```
#### Parameters

<a name='DiGi.Core.Classes.TypeReference.TypeReference(string).fullTypeName'></a>

`fullTypeName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The full name of the type\.

<a name='DiGi.Core.Classes.TypeReference.TypeReference(System.Text.Json.Nodes.JsonObject)'></a>

## TypeReference\(JsonObject\) Constructor

Initializes a new instance of the [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference') class from a JSON object\.

```csharp
public TypeReference(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.TypeReference.TypeReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the type reference\.

<a name='DiGi.Core.Classes.TypeReference.TypeReference(System.Type)'></a>

## TypeReference\(Type\) Constructor

Initializes a new instance of the [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference') class for the specified type\.

```csharp
public TypeReference(System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Classes.TypeReference.TypeReference(System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to reference\.
### Properties

<a name='DiGi.Core.Classes.TypeReference.FullTypeName'></a>

## TypeReference\.FullTypeName Property

Gets or sets the full name of the referenced type\.

```csharp
public string? FullTypeName { get; }
```

Implements [FullTypeName](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITypeRelatedReference.FullTypeName 'DiGi\.Core\.Interfaces\.ITypeRelatedReference\.FullTypeName')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.TypeReference.Segments'></a>

## TypeReference\.Segments Property

Gets the segments of this reference's string form: the full type name\.

```csharp
protected override System.Collections.Generic.IEnumerable<string?> Segments { protected get; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')
### Methods

<a name='DiGi.Core.Classes.TypeReference.Clone()'></a>

## TypeReference\.Clone\(\) Method

Creates a shallow copy of the current type reference\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.Clone() 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>\.Clone\(\)')

#### Returns
[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A shallow copy of the current type reference\.

<a name='DiGi.Core.Classes.TypeReference.Equals(object)'></a>

## TypeReference\.Equals\(object\) Method

Determines whether the specified object is equal to the current type reference\.

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='DiGi.Core.Classes.TypeReference.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the current type reference\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified object is equal to the current type reference; otherwise, false\.

<a name='DiGi.Core.Classes.TypeReference.GetHashCode()'></a>

## TypeReference\.GetHashCode\(\) Method

Gets the hash code for the current type reference\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The hash code for the current type reference\.
### Operators

<a name='DiGi.Core.Classes.TypeReference.op_Equality(DiGi.Core.Classes.TypeReference,DiGi.Core.Classes.TypeReference)'></a>

## TypeReference\.operator ==\(TypeReference, TypeReference\) Operator

Compares two [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference') instances for equality based on their full type names\.

```csharp
public static bool operator ==(DiGi.Core.Classes.TypeReference? typeReference_1, DiGi.Core.Classes.TypeReference? typeReference_2);
```
#### Parameters

<a name='DiGi.Core.Classes.TypeReference.op_Equality(DiGi.Core.Classes.TypeReference,DiGi.Core.Classes.TypeReference).typeReference_1'></a>

`typeReference_1` [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')

The first [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference') to compare\.

<a name='DiGi.Core.Classes.TypeReference.op_Equality(DiGi.Core.Classes.TypeReference,DiGi.Core.Classes.TypeReference).typeReference_2'></a>

`typeReference_2` [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')

The second [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference') to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the two type references are equal; otherwise, false\.

<a name='DiGi.Core.Classes.TypeReference.op_ImplicitDiGi.Core.Classes.TypeReference(System.Type)'></a>

## TypeReference\.implicit operator TypeReference\(Type\) Operator

Implicitly converts a [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type') to a [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')\.

```csharp
public static DiGi.Core.Classes.TypeReference? implicit operator DiGi.Core.Classes.TypeReference?(System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Classes.TypeReference.op_ImplicitDiGi.Core.Classes.TypeReference(System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type') instance to convert\.

#### Returns
[TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')  
A [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference') representing the specified type, or null if the provided type is null\.

<a name='DiGi.Core.Classes.TypeReference.op_ImplicitSystem.Type(DiGi.Core.Classes.TypeReference)'></a>

## TypeReference\.implicit operator Type\(TypeReference\) Operator

Implicitly converts a [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference') to a [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')\.

```csharp
public static System.Type? implicit operator System.Type?(DiGi.Core.Classes.TypeReference? typeReference);
```
#### Parameters

<a name='DiGi.Core.Classes.TypeReference.op_ImplicitSystem.Type(DiGi.Core.Classes.TypeReference).typeReference'></a>

`typeReference` [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')

The [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference') instance to convert\.

#### Returns
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')  
The [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type') corresponding to the specified type reference, or null if the provided type reference is null\.

<a name='DiGi.Core.Classes.TypeReference.op_Inequality(DiGi.Core.Classes.TypeReference,DiGi.Core.Classes.TypeReference)'></a>

## TypeReference\.operator \!=\(TypeReference, TypeReference\) Operator

Compares two [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference') instances for inequality based on their full type names\.

```csharp
public static bool operator !=(DiGi.Core.Classes.TypeReference? typeReference_1, DiGi.Core.Classes.TypeReference? typeReference_2);
```
#### Parameters

<a name='DiGi.Core.Classes.TypeReference.op_Inequality(DiGi.Core.Classes.TypeReference,DiGi.Core.Classes.TypeReference).typeReference_1'></a>

`typeReference_1` [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')

The first [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference') to compare\.

<a name='DiGi.Core.Classes.TypeReference.op_Inequality(DiGi.Core.Classes.TypeReference,DiGi.Core.Classes.TypeReference).typeReference_2'></a>

`typeReference_2` [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')

The second [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference') to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the two type references are not equal; otherwise, false\.

<a name='DiGi.Core.Classes.TypeRelatedExternalReference'></a>

## TypeRelatedExternalReference Class

Represents an external reference related to a type rather than a specific instance\.

```csharp
public sealed class TypeRelatedExternalReference : DiGi.Core.Classes.ExternalReference<DiGi.Core.Interfaces.ITypeRelatedSerializableReference>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') → [ExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference 'DiGi\.Core\.Classes\.ExternalReference') → [DiGi\.Core\.Classes\.ExternalReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference_USerializableReference_ 'DiGi\.Core\.Classes\.ExternalReference\<USerializableReference\>')[ITypeRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITypeRelatedSerializableReference 'DiGi\.Core\.Interfaces\.ITypeRelatedSerializableReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference_USerializableReference_ 'DiGi\.Core\.Classes\.ExternalReference\<USerializableReference\>') → TypeRelatedExternalReference

### Example
Renders and parses \(via [TryParse\(this string, IReference\)](DiGi.Core.md#DiGi.Core.Query.TryParse(thisstring,DiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.TryParse\(this string, DiGi\.Core\.Interfaces\.IReference\)')\) as the discriminator, the
source, then the nested type\-related reference:

```csharp
TypeExternal::Revit::(Type::DiGi.GIS.Classes.Building2D,DiGi.GIS)
```
### Constructors

<a name='DiGi.Core.Classes.TypeRelatedExternalReference.TypeRelatedExternalReference(DiGi.Core.Classes.TypeRelatedExternalReference)'></a>

## TypeRelatedExternalReference\(TypeRelatedExternalReference\) Constructor

Initializes a new instance of the [TypeRelatedExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeRelatedExternalReference 'DiGi\.Core\.Classes\.TypeRelatedExternalReference') class by copying an existing reference\.

```csharp
public TypeRelatedExternalReference(DiGi.Core.Classes.TypeRelatedExternalReference? externalReference);
```
#### Parameters

<a name='DiGi.Core.Classes.TypeRelatedExternalReference.TypeRelatedExternalReference(DiGi.Core.Classes.TypeRelatedExternalReference).externalReference'></a>

`externalReference` [TypeRelatedExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeRelatedExternalReference 'DiGi\.Core\.Classes\.TypeRelatedExternalReference')

The external reference to copy\.

<a name='DiGi.Core.Classes.TypeRelatedExternalReference.TypeRelatedExternalReference(string,DiGi.Core.Interfaces.ITypeRelatedSerializableReference)'></a>

## TypeRelatedExternalReference\(string, ITypeRelatedSerializableReference\) Constructor

Initializes a new instance of the [TypeRelatedExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeRelatedExternalReference 'DiGi\.Core\.Classes\.TypeRelatedExternalReference') class with the specified source and reference\.

```csharp
public TypeRelatedExternalReference(string? source, DiGi.Core.Interfaces.ITypeRelatedSerializableReference? reference);
```
#### Parameters

<a name='DiGi.Core.Classes.TypeRelatedExternalReference.TypeRelatedExternalReference(string,DiGi.Core.Interfaces.ITypeRelatedSerializableReference).source'></a>

`source` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The source string\.

<a name='DiGi.Core.Classes.TypeRelatedExternalReference.TypeRelatedExternalReference(string,DiGi.Core.Interfaces.ITypeRelatedSerializableReference).reference'></a>

`reference` [ITypeRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITypeRelatedSerializableReference 'DiGi\.Core\.Interfaces\.ITypeRelatedSerializableReference')

The serializable reference to use\.

<a name='DiGi.Core.Classes.TypeRelatedExternalReference.TypeRelatedExternalReference(System.Text.Json.Nodes.JsonObject)'></a>

## TypeRelatedExternalReference\(JsonObject\) Constructor

Initializes a new instance of the [TypeRelatedExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeRelatedExternalReference 'DiGi\.Core\.Classes\.TypeRelatedExternalReference') class from the specified JSON object\.

```csharp
public TypeRelatedExternalReference(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.TypeRelatedExternalReference.TypeRelatedExternalReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the instance from\.

<a name='DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_'></a>

## UniqueExternalReference\<TUniqueReference\> Class

Base class for external references that identify objects by a unique ID\.

```csharp
public abstract class UniqueExternalReference<TUniqueReference> : DiGi.Core.Classes.InstanceRelatedExternalReference<TUniqueReference>, DiGi.Core.Interfaces.IUniqueReference, DiGi.Core.Interfaces.IInstanceRelatedSerializableReference, DiGi.Core.Interfaces.IInstanceRelatedReference, DiGi.Core.Interfaces.IReference, DiGi.Core.Interfaces.IObject, System.IEquatable<DiGi.Core.Interfaces.IReference>, DiGi.Core.Interfaces.ISerializableReference, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
    where TUniqueReference : DiGi.Core.Classes.UniqueReference
```
#### Type parameters

<a name='DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_.TUniqueReference'></a>

`TUniqueReference`

The type of the unique reference identifier\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') → [ExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference 'DiGi\.Core\.Classes\.ExternalReference') → [DiGi\.Core\.Classes\.ExternalReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference_USerializableReference_ 'DiGi\.Core\.Classes\.ExternalReference\<USerializableReference\>')[TUniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_.TUniqueReference 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>\.TUniqueReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference_USerializableReference_ 'DiGi\.Core\.Classes\.ExternalReference\<USerializableReference\>') → [DiGi\.Core\.Classes\.InstanceRelatedExternalReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_ 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference\<TInstanceRelatedSerializableReference\>')[TUniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_.TUniqueReference 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>\.TUniqueReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference_TInstanceRelatedSerializableReference_ 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference\<TInstanceRelatedSerializableReference\>') → UniqueExternalReference\<TUniqueReference\>

Derived  
↳ [GuidExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidExternalReference 'DiGi\.Core\.Classes\.GuidExternalReference')

Implements [IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference'), [IInstanceRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedSerializableReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedSerializableReference'), [IInstanceRelatedReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedReference'), [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1'), [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_.UniqueExternalReference(DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_)'></a>

## UniqueExternalReference\(UniqueExternalReference\<TUniqueReference\>\) Constructor

Initializes a new instance of the [UniqueExternalReference&lt;TUniqueReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_ 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>') class by copying an existing generic reference\.

```csharp
public UniqueExternalReference(DiGi.Core.Classes.UniqueExternalReference<TUniqueReference>? externalReference);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_.UniqueExternalReference(DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_).externalReference'></a>

`externalReference` [DiGi\.Core\.Classes\.UniqueExternalReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_ 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>')[TUniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_.TUniqueReference 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>\.TUniqueReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_ 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>')

The external reference to copy\.

<a name='DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_.UniqueExternalReference(string,TUniqueReference)'></a>

## UniqueExternalReference\(string, TUniqueReference\) Constructor

Initializes a new instance of the [UniqueExternalReference&lt;TUniqueReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_ 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>') class with the specified source and unique reference\.

```csharp
public UniqueExternalReference(string? source, TUniqueReference? reference);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_.UniqueExternalReference(string,TUniqueReference).source'></a>

`source` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The source identifier\.

<a name='DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_.UniqueExternalReference(string,TUniqueReference).reference'></a>

`reference` [TUniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_.TUniqueReference 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>\.TUniqueReference')

The unique reference value\.

<a name='DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_.UniqueExternalReference(System.Text.Json.Nodes.JsonObject)'></a>

## UniqueExternalReference\(JsonObject\) Constructor

Initializes a new instance of the [UniqueExternalReference&lt;TUniqueReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_ 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>') class from the specified JSON object\.

```csharp
public UniqueExternalReference(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_.UniqueExternalReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.
### Properties

<a name='DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_.TypeReference'></a>

## UniqueExternalReference\<TUniqueReference\>\.TypeReference Property

Gets or sets the type reference associated with this object\.

```csharp
public DiGi.Core.Classes.TypeReference? TypeReference { get; }
```

Implements [TypeReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference.TypeReference 'DiGi\.Core\.Interfaces\.IUniqueReference\.TypeReference')

#### Property Value
[TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')

<a name='DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_.UniqueId'></a>

## UniqueExternalReference\<TUniqueReference\>\.UniqueId Property

Gets or sets the unique identifier for this reference\.

```csharp
public string? UniqueId { get; }
```

Implements [UniqueId](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference.UniqueId 'DiGi\.Core\.Interfaces\.IUniqueReference\.UniqueId')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.UniqueIdObject'></a>

## UniqueIdObject Class

Base class for serializable objects identified by a unique string ID\.

```csharp
public abstract class UniqueIdObject : DiGi.Core.Classes.UniqueObject, DiGi.Core.Interfaces.IUniqueIdObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [UniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObject 'DiGi\.Core\.Classes\.UniqueObject') → UniqueIdObject

Implements [IUniqueIdObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueIdObject 'DiGi\.Core\.Interfaces\.IUniqueIdObject'), [IUniqueObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Classes.UniqueIdObject.UniqueIdObject()'></a>

## UniqueIdObject\(\) Constructor

Initializes a new instance of the [UniqueIdObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdObject 'DiGi\.Core\.Classes\.UniqueIdObject') class\.

```csharp
public UniqueIdObject();
```

<a name='DiGi.Core.Classes.UniqueIdObject.UniqueIdObject(DiGi.Core.Classes.UniqueIdObject)'></a>

## UniqueIdObject\(UniqueIdObject\) Constructor

Initializes a new instance of the [UniqueIdObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdObject 'DiGi\.Core\.Classes\.UniqueIdObject') class by copying another UniqueIdObject\.

```csharp
public UniqueIdObject(DiGi.Core.Classes.UniqueIdObject? uniqueIdObject);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueIdObject.UniqueIdObject(DiGi.Core.Classes.UniqueIdObject).uniqueIdObject'></a>

`uniqueIdObject` [UniqueIdObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdObject 'DiGi\.Core\.Classes\.UniqueIdObject')

The source UniqueIdObject to copy from\.

<a name='DiGi.Core.Classes.UniqueIdObject.UniqueIdObject(string)'></a>

## UniqueIdObject\(string\) Constructor

Initializes a new instance of the [UniqueIdObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdObject 'DiGi\.Core\.Classes\.UniqueIdObject') class with the specified unique ID\.

```csharp
public UniqueIdObject(string? uniqueId);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueIdObject.UniqueIdObject(string).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier string\.

<a name='DiGi.Core.Classes.UniqueIdObject.UniqueIdObject(string,DiGi.Core.Classes.GuidObject)'></a>

## UniqueIdObject\(string, GuidObject\) Constructor

Initializes a new instance of the [UniqueIdObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdObject 'DiGi\.Core\.Classes\.UniqueIdObject') class with a specified unique ID and GuidObject\.

```csharp
public UniqueIdObject(string uniqueId, DiGi.Core.Classes.GuidObject? guidObject);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueIdObject.UniqueIdObject(string,DiGi.Core.Classes.GuidObject).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier string\.

<a name='DiGi.Core.Classes.UniqueIdObject.UniqueIdObject(string,DiGi.Core.Classes.GuidObject).guidObject'></a>

`guidObject` [GuidObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidObject 'DiGi\.Core\.Classes\.GuidObject')

The associated GUID object, or null\.

<a name='DiGi.Core.Classes.UniqueIdObject.UniqueIdObject(System.Text.Json.Nodes.JsonObject)'></a>

## UniqueIdObject\(JsonObject\) Constructor

Initializes a new instance of the [UniqueIdObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdObject 'DiGi\.Core\.Classes\.UniqueIdObject') class from a JSON object\.

```csharp
public UniqueIdObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueIdObject.UniqueIdObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.
### Properties

<a name='DiGi.Core.Classes.UniqueIdObject.UniqueId'></a>

## UniqueIdObject\.UniqueId Property

Gets or sets the unique identification string for this object\.

```csharp
public override string? UniqueId { get; }
```

Implements [UniqueId](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject.UniqueId 'DiGi\.Core\.Interfaces\.IUniqueObject\.UniqueId')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.UniqueIdPropertyReference'></a>

## UniqueIdPropertyReference Class

Represents a reference to a property by its unique ID\.

```csharp
public class UniqueIdPropertyReference : DiGi.Core.Classes.UniquePropertyReference<DiGi.Core.Classes.UniqueIdReference>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') → [PropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference 'DiGi\.Core\.Classes\.PropertyReference') → [DiGi\.Core\.Classes\.PropertyReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference_USerializableReference_ 'DiGi\.Core\.Classes\.PropertyReference\<USerializableReference\>')[UniqueIdReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdReference 'DiGi\.Core\.Classes\.UniqueIdReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference_USerializableReference_ 'DiGi\.Core\.Classes\.PropertyReference\<USerializableReference\>') → [DiGi\.Core\.Classes\.UniquePropertyReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_ 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>')[UniqueIdReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdReference 'DiGi\.Core\.Classes\.UniqueIdReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_ 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>') → UniqueIdPropertyReference

### Example
Renders and parses \(via [TryParse\(this string, IReference\)](DiGi.Core.md#DiGi.Core.Query.TryParse(thisstring,DiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.TryParse\(this string, DiGi\.Core\.Interfaces\.IReference\)')\) as the discriminator, the
nested unique identifier reference, then the property name:

```csharp
UniqueIdProperty::(UniqueId::(Type::DiGi.GIS.Classes.Building2D,DiGi.GIS)::BLD-001)::Name
```
### Constructors

<a name='DiGi.Core.Classes.UniqueIdPropertyReference.UniqueIdPropertyReference(DiGi.Core.Classes.UniqueIdPropertyReference)'></a>

## UniqueIdPropertyReference\(UniqueIdPropertyReference\) Constructor

Initializes a new instance of the [UniqueIdPropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdPropertyReference 'DiGi\.Core\.Classes\.UniqueIdPropertyReference') class by copying an existing reference\.

```csharp
public UniqueIdPropertyReference(DiGi.Core.Classes.UniqueIdPropertyReference? uniqueIdPropertyReference);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueIdPropertyReference.UniqueIdPropertyReference(DiGi.Core.Classes.UniqueIdPropertyReference).uniqueIdPropertyReference'></a>

`uniqueIdPropertyReference` [UniqueIdPropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdPropertyReference 'DiGi\.Core\.Classes\.UniqueIdPropertyReference')

The existing reference to copy\.

<a name='DiGi.Core.Classes.UniqueIdPropertyReference.UniqueIdPropertyReference(DiGi.Core.Classes.UniqueIdReference,string)'></a>

## UniqueIdPropertyReference\(UniqueIdReference, string\) Constructor

Initializes a new instance of the [UniqueIdPropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdPropertyReference 'DiGi\.Core\.Classes\.UniqueIdPropertyReference') class using a unique ID reference and a property name\.

```csharp
public UniqueIdPropertyReference(DiGi.Core.Classes.UniqueIdReference? reference, string? propertyName);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueIdPropertyReference.UniqueIdPropertyReference(DiGi.Core.Classes.UniqueIdReference,string).reference'></a>

`reference` [UniqueIdReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdReference 'DiGi\.Core\.Classes\.UniqueIdReference')

The unique ID reference\.

<a name='DiGi.Core.Classes.UniqueIdPropertyReference.UniqueIdPropertyReference(DiGi.Core.Classes.UniqueIdReference,string).propertyName'></a>

`propertyName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the property\.

<a name='DiGi.Core.Classes.UniqueIdPropertyReference.UniqueIdPropertyReference(System.Text.Json.Nodes.JsonObject)'></a>

## UniqueIdPropertyReference\(JsonObject\) Constructor

Initializes a new instance of the [UniqueIdPropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdPropertyReference 'DiGi\.Core\.Classes\.UniqueIdPropertyReference') class from a JSON object\.

```csharp
public UniqueIdPropertyReference(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueIdPropertyReference.UniqueIdPropertyReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.
### Methods

<a name='DiGi.Core.Classes.UniqueIdPropertyReference.Clone()'></a>

## UniqueIdPropertyReference\.Clone\(\) Method

Creates a deep copy of the current object\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject Clone();
```

Implements [Clone\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.Clone() 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>\.Clone\(\)')

#### Returns
[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A deep copy of the current object\.

<a name='DiGi.Core.Classes.UniqueIdReference'></a>

## UniqueIdReference Class

Represents a reference to an object identified by a unique string ID\.

```csharp
public class UniqueIdReference : DiGi.Core.Classes.UniqueReference
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') → [UniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference 'DiGi\.Core\.Classes\.UniqueReference') → UniqueIdReference

### Example
Renders and parses \(via [TryParse\(this string, IReference\)](DiGi.Core.md#DiGi.Core.Query.TryParse(thisstring,DiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.TryParse\(this string, DiGi\.Core\.Interfaces\.IReference\)')\) as the discriminator, the
nested type reference, then the unique identifier:

```csharp
UniqueId::(Type::DiGi.GIS.Classes.Building2D,DiGi.GIS)::BLD-001
```
### Constructors

<a name='DiGi.Core.Classes.UniqueIdReference.UniqueIdReference(DiGi.Core.Classes.TypeReference,string)'></a>

## UniqueIdReference\(TypeReference, string\) Constructor

Initializes a new instance of the [UniqueIdReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdReference 'DiGi\.Core\.Classes\.UniqueIdReference') class using a type reference and a unique identifier\.

```csharp
public UniqueIdReference(DiGi.Core.Classes.TypeReference? typeReference, string? uniqueId);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueIdReference.UniqueIdReference(DiGi.Core.Classes.TypeReference,string).typeReference'></a>

`typeReference` [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')

The type reference\.

<a name='DiGi.Core.Classes.UniqueIdReference.UniqueIdReference(DiGi.Core.Classes.TypeReference,string).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier\.

<a name='DiGi.Core.Classes.UniqueIdReference.UniqueIdReference(DiGi.Core.Classes.UniqueIdReference)'></a>

## UniqueIdReference\(UniqueIdReference\) Constructor

Initializes a new instance of the [UniqueIdReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdReference 'DiGi\.Core\.Classes\.UniqueIdReference') class by copying an existing reference\.

```csharp
public UniqueIdReference(DiGi.Core.Classes.UniqueIdReference? uniqueIdReference);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueIdReference.UniqueIdReference(DiGi.Core.Classes.UniqueIdReference).uniqueIdReference'></a>

`uniqueIdReference` [UniqueIdReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdReference 'DiGi\.Core\.Classes\.UniqueIdReference')

The existing reference to copy\.

<a name='DiGi.Core.Classes.UniqueIdReference.UniqueIdReference(DiGi.Core.Interfaces.IUniqueIdObject)'></a>

## UniqueIdReference\(IUniqueIdObject\) Constructor

Initializes a new instance of the [UniqueIdReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdReference 'DiGi\.Core\.Classes\.UniqueIdReference') class from a unique ID object\.

```csharp
public UniqueIdReference(DiGi.Core.Interfaces.IUniqueIdObject? uniqueIdObject);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueIdReference.UniqueIdReference(DiGi.Core.Interfaces.IUniqueIdObject).uniqueIdObject'></a>

`uniqueIdObject` [IUniqueIdObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueIdObject 'DiGi\.Core\.Interfaces\.IUniqueIdObject')

The unique ID object to initialize from\.

<a name='DiGi.Core.Classes.UniqueIdReference.UniqueIdReference(System.Text.Json.Nodes.JsonObject)'></a>

## UniqueIdReference\(JsonObject\) Constructor

Initializes a new instance of the [UniqueIdReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdReference 'DiGi\.Core\.Classes\.UniqueIdReference') class from a JSON object\.

```csharp
public UniqueIdReference(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueIdReference.UniqueIdReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.
### Properties

<a name='DiGi.Core.Classes.UniqueIdReference.UniqueId'></a>

## UniqueIdReference\.UniqueId Property

Gets the unique identifier for the reference\.

```csharp
public override string? UniqueId { get; }
```

Implements [UniqueId](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference.UniqueId 'DiGi\.Core\.Interfaces\.IUniqueReference\.UniqueId')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Core.Classes.UniqueIdReference.Clone()'></a>

## UniqueIdReference\.Clone\(\) Method

Creates a deep copy of the current object\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.Clone() 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>\.Clone\(\)')

#### Returns
[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A deep copy of the current object\.

<a name='DiGi.Core.Classes.UniqueObject'></a>

## UniqueObject Class

Base class for serializable objects with a unique identifier\.

```csharp
public abstract class UniqueObject : DiGi.Core.Classes.SerializableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → UniqueObject

Derived  
↳ [GuidObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidObject 'DiGi\.Core\.Classes\.GuidObject')  
↳ [UniqueIdObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdObject 'DiGi\.Core\.Classes\.UniqueIdObject')  
↳ [UniqueResult](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult 'DiGi\.Core\.Classes\.UniqueResult')

Implements [IUniqueObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Classes.UniqueObject.UniqueObject()'></a>

## UniqueObject\(\) Constructor

Initializes a new instance of the [UniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObject 'DiGi\.Core\.Classes\.UniqueObject') class\.

```csharp
public UniqueObject();
```

<a name='DiGi.Core.Classes.UniqueObject.UniqueObject(DiGi.Core.Classes.UniqueObject)'></a>

## UniqueObject\(UniqueObject\) Constructor

Initializes a new instance of the [UniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObject 'DiGi\.Core\.Classes\.UniqueObject') class by copying an existing instance\.

```csharp
public UniqueObject(DiGi.Core.Classes.UniqueObject? uniqueObject);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueObject.UniqueObject(DiGi.Core.Classes.UniqueObject).uniqueObject'></a>

`uniqueObject` [UniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObject 'DiGi\.Core\.Classes\.UniqueObject')

The existing instance to copy\.

<a name='DiGi.Core.Classes.UniqueObject.UniqueObject(System.Text.Json.Nodes.JsonObject)'></a>

## UniqueObject\(JsonObject\) Constructor

Initializes a new instance of the [UniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObject 'DiGi\.Core\.Classes\.UniqueObject') class using the specified JSON object\.

```csharp
public UniqueObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueObject.UniqueObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to use for initialization\.
### Properties

<a name='DiGi.Core.Classes.UniqueObject.UniqueId'></a>

## UniqueObject\.UniqueId Property

Gets or sets the unique identifier for the object\.

```csharp
public abstract string? UniqueId { get; }
```

Implements [UniqueId](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject.UniqueId 'DiGi\.Core\.Interfaces\.IUniqueObject\.UniqueId')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_'></a>

## UniqueObjectValueCluster\<TValue\> Class

Represents a value cluster that ensures uniqueness of its contained objects\.

```csharp
public class UniqueObjectValueCluster<TValue> : DiGi.Core.Classes.SerializableObjectValueCluster<DiGi.Core.Classes.TypeReference, DiGi.Core.Interfaces.IUniqueReference, TValue>
    where TValue : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TValue'></a>

`TValue`

The type of values contained in the cluster\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Cluster&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')[TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')[IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TValue 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>\.TValue')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>') → [DiGi\.Core\.Classes\.ValueCluster&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>')[TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>')[IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TValue 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>\.TValue')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>') → [DiGi\.Core\.Classes\.SerializableObjectValueCluster&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>')[TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>')[IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TValue 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>\.TValue')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>') → UniqueObjectValueCluster\<TValue\>
### Constructors

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.UniqueObjectValueCluster()'></a>

## UniqueObjectValueCluster\(\) Constructor

Initializes a new instance of the UniqueObjectValueCluster class\.

```csharp
public UniqueObjectValueCluster();
```

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.UniqueObjectValueCluster(DiGi.Core.Classes.UniqueObjectValueCluster_TValue_)'></a>

## UniqueObjectValueCluster\(UniqueObjectValueCluster\<TValue\>\) Constructor

Initializes a new instance of the UniqueObjectValueCluster class from another unique object value cluster\.

```csharp
public UniqueObjectValueCluster(DiGi.Core.Classes.UniqueObjectValueCluster<TValue>? uniqueObjectValueCluster);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.UniqueObjectValueCluster(DiGi.Core.Classes.UniqueObjectValueCluster_TValue_).uniqueObjectValueCluster'></a>

`uniqueObjectValueCluster` [DiGi\.Core\.Classes\.UniqueObjectValueCluster&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_ 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TValue 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>\.TValue')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_ 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>')

The unique object value cluster to copy from\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.UniqueObjectValueCluster(System.Collections.Generic.IEnumerable_TValue_)'></a>

## UniqueObjectValueCluster\(IEnumerable\<TValue\>\) Constructor

Initializes a new instance of the UniqueObjectValueCluster class using the specified collection of values\.

```csharp
public UniqueObjectValueCluster(System.Collections.Generic.IEnumerable<TValue>? values);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.UniqueObjectValueCluster(System.Collections.Generic.IEnumerable_TValue_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TValue 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>\.TValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of values to initialize the cluster with\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.UniqueObjectValueCluster(System.Text.Json.Nodes.JsonObject)'></a>

## UniqueObjectValueCluster\(JsonObject\) Constructor

Initializes a new instance of the UniqueObjectValueCluster class from a JSON object\.

```csharp
public UniqueObjectValueCluster(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.UniqueObjectValueCluster(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the cluster\.
### Methods

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.Contains(DiGi.Core.Interfaces.IUniqueReference)'></a>

## UniqueObjectValueCluster\<TValue\>\.Contains\(IUniqueReference\) Method

Determines whether the cluster contains an element with the specified unique reference\.

```csharp
public bool Contains(DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.Contains(DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to locate in the cluster\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the cluster contains an element with the specified unique reference; otherwise, false\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetTypeReferences()'></a>

## UniqueObjectValueCluster\<TValue\>\.GetTypeReferences\(\) Method

Retrieves all type references present in the unique object value cluster\.

```csharp
public System.Collections.Generic.List<DiGi.Core.Classes.TypeReference>? GetTypeReferences();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of type references present in the cluster, or null if none exist\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValue_UValue_(DiGi.Core.Interfaces.IUniqueReference)'></a>

## UniqueObjectValueCluster\<TValue\>\.GetValue\<UValue\>\(IUniqueReference\) Method

Retrieves the value associated with the specified unique reference\.

```csharp
public UValue? GetValue<UValue>(DiGi.Core.Interfaces.IUniqueReference? uniqueReference)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValue_UValue_(DiGi.Core.Interfaces.IUniqueReference).UValue'></a>

`UValue`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValue_UValue_(DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference for which to retrieve the value\.

#### Returns
[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValue_UValue_(DiGi.Core.Interfaces.IUniqueReference).UValue 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>\.GetValue\<UValue\>\(DiGi\.Core\.Interfaces\.IUniqueReference\)\.UValue')  
The value associated with the specified unique reference, or null if not found\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValue_UValue_(System.Func_UValue,bool_)'></a>

## UniqueObjectValueCluster\<TValue\>\.GetValue\<UValue\>\(Func\<UValue,bool\>\) Method

Retrieves the first value that satisfies the specified predicate\.

```csharp
public override UValue? GetValue<UValue>(System.Func<UValue?,bool>? func)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValue_UValue_(System.Func_UValue,bool_).UValue'></a>

`UValue`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValue_UValue_(System.Func_UValue,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValue_UValue_(System.Func_UValue,bool_).UValue 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>\.GetValue\<UValue\>\(System\.Func\<UValue,bool\>\)\.UValue')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The predicate used to determine if a value satisfies the condition\.

#### Returns
[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValue_UValue_(System.Func_UValue,bool_).UValue 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>\.GetValue\<UValue\>\(System\.Func\<UValue,bool\>\)\.UValue')  
The first value that satisfies the predicate, or null if no such value is found\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValues_U_(System.Type)'></a>

## UniqueObjectValueCluster\<TValue\>\.GetValues\<U\>\(Type\) Method

Retrieves all values of the specified type from the cluster\.

```csharp
public System.Collections.Generic.List<U>? GetValues<U>(System.Type? type);
```
#### Type parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValues_U_(System.Type).U'></a>

`U`

The type of the values to retrieve\.
#### Parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValues_U_(System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type used to filter the values in the cluster\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[U](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValues_U_(System.Type).U 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>\.GetValues\<U\>\(System\.Type\)\.U')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of values of the specified type, or null if no such values exist\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValues_UValue_(DiGi.Core.Classes.TypeReference)'></a>

## UniqueObjectValueCluster\<TValue\>\.GetValues\<UValue\>\(TypeReference\) Method

Retrieves all values associated with the specified type reference\.

```csharp
public override System.Collections.Generic.List<UValue>? GetValues<UValue>(DiGi.Core.Classes.TypeReference? key_1)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValues_UValue_(DiGi.Core.Classes.TypeReference).UValue'></a>

`UValue`

The type of the values to retrieve\.
#### Parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValues_UValue_(DiGi.Core.Classes.TypeReference).key_1'></a>

`key_1` [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')

The type reference used to identify the values\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValues_UValue_(DiGi.Core.Classes.TypeReference).UValue 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>\.GetValues\<UValue\>\(DiGi\.Core\.Classes\.TypeReference\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of values associated with the specified type reference, or null if none are found\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValues_UValue_(DiGi.Core.Classes.TypeReference,bool)'></a>

## UniqueObjectValueCluster\<TValue\>\.GetValues\<UValue\>\(TypeReference, bool\) Method

Retrieves values for a specific type reference, optionally requiring an exact match\.

```csharp
public System.Collections.Generic.List<UValue>? GetValues<UValue>(DiGi.Core.Classes.TypeReference? key_1, bool exactMath)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValues_UValue_(DiGi.Core.Classes.TypeReference,bool).UValue'></a>

`UValue`

The type of the values to retrieve\.
#### Parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValues_UValue_(DiGi.Core.Classes.TypeReference,bool).key_1'></a>

`key_1` [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')

The type reference used to identify the values\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValues_UValue_(DiGi.Core.Classes.TypeReference,bool).exactMath'></a>

`exactMath` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether an exact match is required for the retrieval\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValues_UValue_(DiGi.Core.Classes.TypeReference,bool).UValue 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>\.GetValues\<UValue\>\(DiGi\.Core\.Classes\.TypeReference, bool\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of values associated with the specified type reference, or null if none are found\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValues_UValue_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_)'></a>

## UniqueObjectValueCluster\<TValue\>\.GetValues\<UValue\>\(IEnumerable\<IUniqueReference\>\) Method

Retrieves values associated with a collection of unique references\.

```csharp
public System.Collections.Generic.List<UValue>? GetValues<UValue>(System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueReference>? uniqueReferences)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValues_UValue_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_).UValue'></a>

`UValue`

The type of the values to retrieve\.
#### Parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValues_UValue_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_).uniqueReferences'></a>

`uniqueReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of unique references to look up\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.GetValues_UValue_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_).UValue 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>\.GetValues\<UValue\>\(System\.Collections\.Generic\.IEnumerable\<DiGi\.Core\.Interfaces\.IUniqueReference\>\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of values associated with the provided unique references, or null if no values are found\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.Remove(DiGi.Core.Interfaces.IUniqueReference)'></a>

## UniqueObjectValueCluster\<TValue\>\.Remove\(IUniqueReference\) Method

Removes the value associated with the specified unique reference\.

```csharp
public bool Remove(DiGi.Core.Interfaces.IUniqueReference? key_2);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.Remove(DiGi.Core.Interfaces.IUniqueReference).key_2'></a>

`key_2` [IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference of the value to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully removed; otherwise, false\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.Remove(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_)'></a>

## UniqueObjectValueCluster\<TValue\>\.Remove\(IEnumerable\<IUniqueReference\>\) Method

Removes and returns references for a collection of unique references\.

```csharp
public virtual System.Collections.Generic.List<DiGi.Core.Interfaces.IUniqueReference>? Remove(System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueReference>? keys_2);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.Remove(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_).keys_2'></a>

`keys_2` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references to be removed\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the references that were actually removed, or null if no references were removed\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.Remove_UValue_(System.Collections.Generic.IEnumerable_UValue_)'></a>

## UniqueObjectValueCluster\<TValue\>\.Remove\<UValue\>\(IEnumerable\<UValue\>\) Method

Removes and returns the specified collection of values from the cluster\.

```csharp
public virtual System.Collections.Generic.List<UValue>? Remove<UValue>(System.Collections.Generic.IEnumerable<UValue>? values)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.Remove_UValue_(System.Collections.Generic.IEnumerable_UValue_).UValue'></a>

`UValue`

The type of the values to remove\.
#### Parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.Remove_UValue_(System.Collections.Generic.IEnumerable_UValue_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.Remove_UValue_(System.Collections.Generic.IEnumerable_UValue_).UValue 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>\.Remove\<UValue\>\(System\.Collections\.Generic\.IEnumerable\<UValue\>\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of values to be removed from the cluster\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.Remove_UValue_(System.Collections.Generic.IEnumerable_UValue_).UValue 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>\.Remove\<UValue\>\(System\.Collections\.Generic\.IEnumerable\<UValue\>\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the values that were actually removed, or null if no values were removed\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TryGetValue_UValue_(DiGi.Core.Interfaces.IUniqueReference,UValue)'></a>

## UniqueObjectValueCluster\<TValue\>\.TryGetValue\<UValue\>\(IUniqueReference, UValue\) Method

Attempts to retrieve a value associated with the specified unique reference\.

```csharp
public bool TryGetValue<UValue>(DiGi.Core.Interfaces.IUniqueReference? uniqueReference, out UValue? value)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TryGetValue_UValue_(DiGi.Core.Interfaces.IUniqueReference,UValue).UValue'></a>

`UValue`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TryGetValue_UValue_(DiGi.Core.Interfaces.IUniqueReference,UValue).uniqueReference'></a>

`uniqueReference` [IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference used to look up the value\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TryGetValue_UValue_(DiGi.Core.Interfaces.IUniqueReference,UValue).value'></a>

`value` [UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TryGetValue_UValue_(DiGi.Core.Interfaces.IUniqueReference,UValue).UValue 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>\.TryGetValue\<UValue\>\(DiGi\.Core\.Interfaces\.IUniqueReference, UValue\)\.UValue')

When this method returns, contains the retrieved value if successful; otherwise, the default value for [UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TryGetValue_UValue_(DiGi.Core.Interfaces.IUniqueReference,UValue).UValue 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>\.TryGetValue\<UValue\>\(DiGi\.Core\.Interfaces\.IUniqueReference, UValue\)\.UValue')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully retrieved; otherwise, false\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TryGetValues_UValue_(DiGi.Core.Classes.TypeReference,bool,System.Collections.Generic.List_UValue_)'></a>

## UniqueObjectValueCluster\<TValue\>\.TryGetValues\<UValue\>\(TypeReference, bool, List\<UValue\>\) Method

Attempts to retrieve values for a specific type reference, optionally requiring an exact match\.

```csharp
public bool TryGetValues<UValue>(DiGi.Core.Classes.TypeReference? key_1, bool exactMatch, out System.Collections.Generic.List<UValue>? values)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TryGetValues_UValue_(DiGi.Core.Classes.TypeReference,bool,System.Collections.Generic.List_UValue_).UValue'></a>

`UValue`

The type of the values to retrieve\.
#### Parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TryGetValues_UValue_(DiGi.Core.Classes.TypeReference,bool,System.Collections.Generic.List_UValue_).key_1'></a>

`key_1` [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')

The type reference used as the key for retrieval\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TryGetValues_UValue_(DiGi.Core.Classes.TypeReference,bool,System.Collections.Generic.List_UValue_).exactMatch'></a>

`exactMatch` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A boolean indicating whether an exact match is required\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TryGetValues_UValue_(DiGi.Core.Classes.TypeReference,bool,System.Collections.Generic.List_UValue_).values'></a>

`values` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TryGetValues_UValue_(DiGi.Core.Classes.TypeReference,bool,System.Collections.Generic.List_UValue_).UValue 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>\.TryGetValues\<UValue\>\(DiGi\.Core\.Classes\.TypeReference, bool, System\.Collections\.Generic\.List\<UValue\>\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains the retrieved values if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more values were successfully retrieved; otherwise, false\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TryGetValues_UValue_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Collections.Generic.List_UValue_)'></a>

## UniqueObjectValueCluster\<TValue\>\.TryGetValues\<UValue\>\(IEnumerable\<IUniqueReference\>, List\<UValue\>\) Method

Attempts to retrieve values associated with a collection of unique references\.

```csharp
public bool TryGetValues<UValue>(System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueReference>? uniqueReferences, out System.Collections.Generic.List<UValue>? values)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TryGetValues_UValue_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Collections.Generic.List_UValue_).UValue'></a>

`UValue`

The type of the values to retrieve\.
#### Parameters

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TryGetValues_UValue_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Collections.Generic.List_UValue_).uniqueReferences'></a>

`uniqueReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of unique references to look up\.

<a name='DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TryGetValues_UValue_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Collections.Generic.List_UValue_).values'></a>

`values` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_.TryGetValues_UValue_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Collections.Generic.List_UValue_).UValue 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>\.TryGetValues\<UValue\>\(System\.Collections\.Generic\.IEnumerable\<DiGi\.Core\.Interfaces\.IUniqueReference\>, System\.Collections\.Generic\.List\<UValue\>\)\.UValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains the retrieved values if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more values were successfully retrieved; otherwise, false\.

<a name='DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_'></a>

## UniquePropertyReference\<UUniquePropertyReference\> Class

Represents a reference to a property by its unique reference\.

```csharp
public abstract class UniquePropertyReference<UUniquePropertyReference> : DiGi.Core.Classes.PropertyReference<UUniquePropertyReference>, DiGi.Core.Interfaces.IInstanceRelatedSerializableReference, DiGi.Core.Interfaces.IInstanceRelatedReference, DiGi.Core.Interfaces.IReference, DiGi.Core.Interfaces.IObject, System.IEquatable<DiGi.Core.Interfaces.IReference>, DiGi.Core.Interfaces.ISerializableReference, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
    where UUniquePropertyReference : DiGi.Core.Classes.UniqueReference
```
#### Type parameters

<a name='DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_.UUniquePropertyReference'></a>

`UUniquePropertyReference`

The type of the unique property reference\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') → [PropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference 'DiGi\.Core\.Classes\.PropertyReference') → [DiGi\.Core\.Classes\.PropertyReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference_USerializableReference_ 'DiGi\.Core\.Classes\.PropertyReference\<USerializableReference\>')[UUniquePropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_.UUniquePropertyReference 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>\.UUniquePropertyReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.PropertyReference_USerializableReference_ 'DiGi\.Core\.Classes\.PropertyReference\<USerializableReference\>') → UniquePropertyReference\<UUniquePropertyReference\>

Derived  
↳ [GuidPropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidPropertyReference 'DiGi\.Core\.Classes\.GuidPropertyReference')  
↳ [UniqueIdPropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdPropertyReference 'DiGi\.Core\.Classes\.UniqueIdPropertyReference')

Implements [IInstanceRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedSerializableReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedSerializableReference'), [IInstanceRelatedReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedReference'), [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1'), [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject')

### Remarks
This type is abstract: a closed instance would render identically to the matching concrete subclass \-
[GuidPropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidPropertyReference 'DiGi\.Core\.Classes\.GuidPropertyReference') or [UniqueIdPropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdPropertyReference 'DiGi\.Core\.Classes\.UniqueIdPropertyReference') \- because the discriminator is
the only thing separating them, and a generic type has no stable short discriminator\. Instantiate a subclass\.
### Constructors

<a name='DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_.UniquePropertyReference(DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_)'></a>

## UniquePropertyReference\(UniquePropertyReference\<UUniquePropertyReference\>\) Constructor

Initializes a new instance of the [UniquePropertyReference&lt;UUniquePropertyReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_ 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>') class by copying an existing reference\.

```csharp
public UniquePropertyReference(DiGi.Core.Classes.UniquePropertyReference<UUniquePropertyReference>? uniquePropertyReference);
```
#### Parameters

<a name='DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_.UniquePropertyReference(DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_).uniquePropertyReference'></a>

`uniquePropertyReference` [DiGi\.Core\.Classes\.UniquePropertyReference&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_ 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>')[UUniquePropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_.UUniquePropertyReference 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>\.UUniquePropertyReference')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_ 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>')

The unique property reference to copy\.

<a name='DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_.UniquePropertyReference(System.Text.Json.Nodes.JsonObject)'></a>

## UniquePropertyReference\(JsonObject\) Constructor

Initializes a new instance of the [UniquePropertyReference&lt;UUniquePropertyReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_ 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>') class from a JSON object\.

```csharp
public UniquePropertyReference(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_.UniquePropertyReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the reference from\.

<a name='DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_.UniquePropertyReference(UUniquePropertyReference,string)'></a>

## UniquePropertyReference\(UUniquePropertyReference, string\) Constructor

Initializes a new instance of the [UniquePropertyReference&lt;UUniquePropertyReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_ 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>') class using a unique property reference and a property name\.

```csharp
public UniquePropertyReference(UUniquePropertyReference? reference, string? propertyName);
```
#### Parameters

<a name='DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_.UniquePropertyReference(UUniquePropertyReference,string).reference'></a>

`reference` [UUniquePropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_.UUniquePropertyReference 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>\.UUniquePropertyReference')

The unique property reference\.

<a name='DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_.UniquePropertyReference(UUniquePropertyReference,string).propertyName'></a>

`propertyName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the property\.

<a name='DiGi.Core.Classes.UniqueReference'></a>

## UniqueReference Class

Base class for references to objects with a unique identifier\.

```csharp
public abstract class UniqueReference : DiGi.Core.Classes.SerializableReference, DiGi.Core.Interfaces.IUniqueReference, DiGi.Core.Interfaces.IInstanceRelatedSerializableReference, DiGi.Core.Interfaces.IInstanceRelatedReference, DiGi.Core.Interfaces.IReference, DiGi.Core.Interfaces.IObject, System.IEquatable<DiGi.Core.Interfaces.IReference>, DiGi.Core.Interfaces.ISerializableReference, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') → UniqueReference

Derived  
↳ [GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference')  
↳ [UniqueIdReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdReference 'DiGi\.Core\.Classes\.UniqueIdReference')

Implements [IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference'), [IInstanceRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedSerializableReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedSerializableReference'), [IInstanceRelatedReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedReference'), [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1'), [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Core.Classes.UniqueReference.UniqueReference(DiGi.Core.Classes.TypeReference)'></a>

## UniqueReference\(TypeReference\) Constructor

Initializes a new instance of the [UniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference 'DiGi\.Core\.Classes\.UniqueReference') class using a [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference.TypeReference 'DiGi\.Core\.Classes\.UniqueReference\.TypeReference')\.

```csharp
public UniqueReference(DiGi.Core.Classes.TypeReference? typeReference);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueReference.UniqueReference(DiGi.Core.Classes.TypeReference).typeReference'></a>

`typeReference` [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')

The type reference to use\.

<a name='DiGi.Core.Classes.UniqueReference.UniqueReference(DiGi.Core.Classes.UniqueReference)'></a>

## UniqueReference\(UniqueReference\) Constructor

Initializes a new instance of the [UniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference 'DiGi\.Core\.Classes\.UniqueReference') class using another [UniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference 'DiGi\.Core\.Classes\.UniqueReference')\.

```csharp
public UniqueReference(DiGi.Core.Classes.UniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueReference.UniqueReference(DiGi.Core.Classes.UniqueReference).uniqueReference'></a>

`uniqueReference` [UniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference 'DiGi\.Core\.Classes\.UniqueReference')

The unique reference to use\.

<a name='DiGi.Core.Classes.UniqueReference.UniqueReference(DiGi.Core.Interfaces.IObject)'></a>

## UniqueReference\(IObject\) Constructor

Initializes a new instance of the [UniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference 'DiGi\.Core\.Classes\.UniqueReference') class for the specified object\.

```csharp
public UniqueReference(DiGi.Core.Interfaces.IObject? @object);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueReference.UniqueReference(DiGi.Core.Interfaces.IObject).object'></a>

`object` [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')

The object to create a reference for\.

<a name='DiGi.Core.Classes.UniqueReference.UniqueReference(System.Text.Json.Nodes.JsonObject)'></a>

## UniqueReference\(JsonObject\) Constructor

Initializes a new instance of the [UniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference 'DiGi\.Core\.Classes\.UniqueReference') class from a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public UniqueReference(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueReference.UniqueReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to create a reference from\.
### Properties

<a name='DiGi.Core.Classes.UniqueReference.Segments'></a>

## UniqueReference\.Segments Property

Gets the segments of this reference's string form: the nested type reference, then the unique identifier\.

Shared by every unique reference, so [GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference') and [UniqueIdReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdReference 'DiGi\.Core\.Classes\.UniqueIdReference')
            differ only by their discriminator - which is what tells them apart on the way back.

```csharp
protected override System.Collections.Generic.IEnumerable<string?> Segments { protected get; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.Core.Classes.UniqueReference.TypeReference'></a>

## UniqueReference\.TypeReference Property

Gets or sets the associated type reference\.

```csharp
public DiGi.Core.Classes.TypeReference? TypeReference { get; }
```

Implements [TypeReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference.TypeReference 'DiGi\.Core\.Interfaces\.IUniqueReference\.TypeReference')

#### Property Value
[TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')

<a name='DiGi.Core.Classes.UniqueReference.UniqueId'></a>

## UniqueReference\.UniqueId Property

Gets the unique identifier of the reference\.

```csharp
public abstract string? UniqueId { get; }
```

Implements [UniqueId](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference.UniqueId 'DiGi\.Core\.Interfaces\.IUniqueReference\.UniqueId')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.UniqueResult'></a>

## UniqueResult Class

Represents a result containing a unique identifier\.

```csharp
public abstract class UniqueResult : DiGi.Core.Classes.UniqueObject, DiGi.Core.Interfaces.IUniqueResult, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [UniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObject 'DiGi\.Core\.Classes\.UniqueObject') → UniqueResult

Derived  
↳ [UniqueResult&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult_T_ 'DiGi\.Core\.Classes\.UniqueResult\<T\>')

Implements [IUniqueResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult 'DiGi\.Core\.Interfaces\.IUniqueResult'), [ISerializableResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [IResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IResult 'DiGi\.Core\.Interfaces\.IResult'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IUniqueObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Constructors

<a name='DiGi.Core.Classes.UniqueResult.UniqueResult()'></a>

## UniqueResult\(\) Constructor

Initializes a new instance of the [UniqueResult](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult 'DiGi\.Core\.Classes\.UniqueResult') class\.

```csharp
public UniqueResult();
```

<a name='DiGi.Core.Classes.UniqueResult.UniqueResult(DiGi.Core.Classes.UniqueResult)'></a>

## UniqueResult\(UniqueResult\) Constructor

Initializes a new instance of the [UniqueResult](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult 'DiGi\.Core\.Classes\.UniqueResult') class from another unique result\.

```csharp
public UniqueResult(DiGi.Core.Classes.UniqueResult? uniqueResult);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueResult.UniqueResult(DiGi.Core.Classes.UniqueResult).uniqueResult'></a>

`uniqueResult` [UniqueResult](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult 'DiGi\.Core\.Classes\.UniqueResult')

The unique result to initialize from\.

<a name='DiGi.Core.Classes.UniqueResult.UniqueResult(System.Text.Json.Nodes.JsonObject)'></a>

## UniqueResult\(JsonObject\) Constructor

Initializes a new instance of the [UniqueResult](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult 'DiGi\.Core\.Classes\.UniqueResult') class from the specified JSON object\.

```csharp
public UniqueResult(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueResult.UniqueResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.

<a name='DiGi.Core.Classes.UniqueResult_T_'></a>

## UniqueResult\<T\> Class

Represents a result containing a unique identifier\.

```csharp
public abstract class UniqueResult<T> : DiGi.Core.Classes.UniqueResult, DiGi.Core.Interfaces.IResult<T>, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject
    where T : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Classes.UniqueResult_T_.T'></a>

`T`

The type of the value contained in the result\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [UniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObject 'DiGi\.Core\.Classes\.UniqueObject') → [UniqueResult](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult 'DiGi\.Core\.Classes\.UniqueResult') → UniqueResult\<T\>

Derived  
↳ [ExternalReferenceUniqueResult&lt;TUniqueObject,UExternalReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReferenceUniqueResult_TUniqueObject,UExternalReference_ 'DiGi\.Core\.Classes\.ExternalReferenceUniqueResult\<TUniqueObject,UExternalReference\>')

Implements [DiGi\.Core\.Interfaces\.IResult&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IResult_T_ 'DiGi\.Core\.Interfaces\.IResult\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult_T_.T 'DiGi\.Core\.Classes\.UniqueResult\<T\>\.T')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IResult_T_ 'DiGi\.Core\.Interfaces\.IResult\<T\>'), [IResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IResult 'DiGi\.Core\.Interfaces\.IResult'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Classes.UniqueResult_T_.UniqueResult()'></a>

## UniqueResult\(\) Constructor

Initializes a new instance of the [UniqueResult](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult 'DiGi\.Core\.Classes\.UniqueResult') class\.

```csharp
public UniqueResult();
```

<a name='DiGi.Core.Classes.UniqueResult_T_.UniqueResult(DiGi.Core.Classes.UniqueResult_T_)'></a>

## UniqueResult\(UniqueResult\<T\>\) Constructor

Initializes a new instance of the [UniqueResult](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult 'DiGi\.Core\.Classes\.UniqueResult') class from a generic unique result\.

```csharp
public UniqueResult(DiGi.Core.Classes.UniqueResult<T>? uniqueResult);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueResult_T_.UniqueResult(DiGi.Core.Classes.UniqueResult_T_).uniqueResult'></a>

`uniqueResult` [DiGi\.Core\.Classes\.UniqueResult&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult_T_ 'DiGi\.Core\.Classes\.UniqueResult\<T\>')[T](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult_T_.T 'DiGi\.Core\.Classes\.UniqueResult\<T\>\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult_T_ 'DiGi\.Core\.Classes\.UniqueResult\<T\>')

The generic unique result to initialize from\.

<a name='DiGi.Core.Classes.UniqueResult_T_.UniqueResult(System.Text.Json.Nodes.JsonObject)'></a>

## UniqueResult\(JsonObject\) Constructor

Initializes a new instance of the [UniqueResult](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult 'DiGi\.Core\.Classes\.UniqueResult') class from the specified JSON object\.

```csharp
public UniqueResult(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.UniqueResult_T_.UniqueResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.

<a name='DiGi.Core.Classes.Utf8JsonBatch_TSerializableObject_'></a>

## Utf8JsonBatch\<TSerializableObject\> Class

A batch of serializable objects together with the UTF\-8 JSON array that represents them\.

```csharp
public class Utf8JsonBatch<TSerializableObject>
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Core.Classes.Utf8JsonBatch_TSerializableObject_.TSerializableObject'></a>

`TSerializableObject`

The type of the serializable object\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Utf8JsonBatch\<TSerializableObject\>
### Constructors

<a name='DiGi.Core.Classes.Utf8JsonBatch_TSerializableObject_.Utf8JsonBatch(System.Collections.Generic.List_TSerializableObject_,byte[])'></a>

## Utf8JsonBatch\(List\<TSerializableObject\>, byte\[\]\) Constructor

Initializes a new instance of the [Utf8JsonBatch&lt;TSerializableObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Utf8JsonBatch_TSerializableObject_ 'DiGi\.Core\.Classes\.Utf8JsonBatch\<TSerializableObject\>') class\.

```csharp
public Utf8JsonBatch(System.Collections.Generic.List<TSerializableObject> serializableObjects, byte[] utf8Json);
```
#### Parameters

<a name='DiGi.Core.Classes.Utf8JsonBatch_TSerializableObject_.Utf8JsonBatch(System.Collections.Generic.List_TSerializableObject_,byte[]).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TSerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.Utf8JsonBatch_TSerializableObject_.TSerializableObject 'DiGi\.Core\.Classes\.Utf8JsonBatch\<TSerializableObject\>\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The objects making up the batch, in payload order\.

<a name='DiGi.Core.Classes.Utf8JsonBatch_TSerializableObject_.Utf8JsonBatch(System.Collections.Generic.List_TSerializableObject_,byte[]).utf8Json'></a>

`utf8Json` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The complete UTF\-8 JSON array representing [serializableObjects](DiGi.Core.Classes.md#DiGi.Core.Classes.Utf8JsonBatch_TSerializableObject_.Utf8JsonBatch(System.Collections.Generic.List_TSerializableObject_,byte[]).serializableObjects 'DiGi\.Core\.Classes\.Utf8JsonBatch\<TSerializableObject\>\.Utf8JsonBatch\(System\.Collections\.Generic\.List\<TSerializableObject\>, byte\[\]\)\.serializableObjects')\.
### Properties

<a name='DiGi.Core.Classes.Utf8JsonBatch_TSerializableObject_.SerializableObjects'></a>

## Utf8JsonBatch\<TSerializableObject\>\.SerializableObjects Property

Gets the objects making up the batch, in the same order as they appear in [Utf8Json](DiGi.Core.Classes.md#DiGi.Core.Classes.Utf8JsonBatch_TSerializableObject_.Utf8Json 'DiGi\.Core\.Classes\.Utf8JsonBatch\<TSerializableObject\>\.Utf8Json')\.

```csharp
public System.Collections.Generic.List<TSerializableObject> SerializableObjects { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TSerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.Utf8JsonBatch_TSerializableObject_.TSerializableObject 'DiGi\.Core\.Classes\.Utf8JsonBatch\<TSerializableObject\>\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Core.Classes.Utf8JsonBatch_TSerializableObject_.Utf8Json'></a>

## Utf8JsonBatch\<TSerializableObject\>\.Utf8Json Property

Gets the complete UTF\-8 JSON array representing [SerializableObjects](DiGi.Core.Classes.md#DiGi.Core.Classes.Utf8JsonBatch_TSerializableObject_.SerializableObjects 'DiGi\.Core\.Classes\.Utf8JsonBatch\<TSerializableObject\>\.SerializableObjects'), ready to be sent as a request body\.

```csharp
public byte[] Utf8Json { get; }
```

#### Property Value
[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Core.Classes.Utf8JsonSplitter_TSerializableObject_'></a>

## Utf8JsonSplitter\<TSerializableObject\> Class

Splits serializable objects into batches by serialized byte array size, emitting each batch's UTF\-8 JSON array alongside its objects\.

Unlike [MemorySizeSplitter&lt;TSerializableObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.MemorySizeSplitter_TSerializableObject_ 'DiGi\.Core\.Classes\.MemorySizeSplitter\<TSerializableObject\>'), which serializes every object once merely to measure it and then leaves the caller to serialize the whole batch a second time, this splitter serializes each object exactly once and keeps the bytes. An object that does not fit the current batch is carried into the next one already serialized, so it is never converted twice either.

```csharp
public class Utf8JsonSplitter<TSerializableObject>
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Core.Classes.Utf8JsonSplitter_TSerializableObject_.TSerializableObject'></a>

`TSerializableObject`

The type of the serializable object\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Utf8JsonSplitter\<TSerializableObject\>
### Constructors

<a name='DiGi.Core.Classes.Utf8JsonSplitter_TSerializableObject_.Utf8JsonSplitter(System.Collections.Generic.IEnumerable_TSerializableObject_)'></a>

## Utf8JsonSplitter\(IEnumerable\<TSerializableObject\>\) Constructor

Initializes a new instance of the [Utf8JsonSplitter&lt;TSerializableObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Utf8JsonSplitter_TSerializableObject_ 'DiGi\.Core\.Classes\.Utf8JsonSplitter\<TSerializableObject\>') class with the specified objects\.

```csharp
public Utf8JsonSplitter(System.Collections.Generic.IEnumerable<TSerializableObject>? serializableObjects);
```
#### Parameters

<a name='DiGi.Core.Classes.Utf8JsonSplitter_TSerializableObject_.Utf8JsonSplitter(System.Collections.Generic.IEnumerable_TSerializableObject_).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TSerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.Utf8JsonSplitter_TSerializableObject_.TSerializableObject 'DiGi\.Core\.Classes\.Utf8JsonSplitter\<TSerializableObject\>\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of objects to be split\.
### Methods

<a name='DiGi.Core.Classes.Utf8JsonSplitter_TSerializableObject_.Consume()'></a>

## Utf8JsonSplitter\<TSerializableObject\>\.Consume\(\) Method

Discards the pending object so the next peek advances to the following one\.

```csharp
private void Consume();
```

<a name='DiGi.Core.Classes.Utf8JsonSplitter_TSerializableObject_.Next(long)'></a>

## Utf8JsonSplitter\<TSerializableObject\>\.Next\(long\) Method

Returns the next batch of objects whose serialized size does not exceed [maxSize](DiGi.Core.Classes.md#DiGi.Core.Classes.Utf8JsonSplitter_TSerializableObject_.Next(long).maxSize 'DiGi\.Core\.Classes\.Utf8JsonSplitter\<TSerializableObject\>\.Next\(long\)\.maxSize'), together with the UTF\-8 JSON array representing them\.

A batch always contains at least one object, so a single object larger than [maxSize](DiGi.Core.Classes.md#DiGi.Core.Classes.Utf8JsonSplitter_TSerializableObject_.Next(long).maxSize 'DiGi\.Core\.Classes\.Utf8JsonSplitter\<TSerializableObject\>\.Next\(long\)\.maxSize') is emitted on its own rather than dropped. Returns null when no objects remain.

```csharp
public DiGi.Core.Classes.Utf8JsonBatch<TSerializableObject>? Next(long maxSize);
```
#### Parameters

<a name='DiGi.Core.Classes.Utf8JsonSplitter_TSerializableObject_.Next(long).maxSize'></a>

`maxSize` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The maximum serialized size, in bytes, allowed for the next batch\.

#### Returns
[DiGi\.Core\.Classes\.Utf8JsonBatch&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Utf8JsonBatch_TSerializableObject_ 'DiGi\.Core\.Classes\.Utf8JsonBatch\<TSerializableObject\>')[TSerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.Utf8JsonSplitter_TSerializableObject_.TSerializableObject 'DiGi\.Core\.Classes\.Utf8JsonSplitter\<TSerializableObject\>\.TSerializableObject')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Utf8JsonBatch_TSerializableObject_ 'DiGi\.Core\.Classes\.Utf8JsonBatch\<TSerializableObject\>')  
The next batch, or null if no more objects are available\.

<a name='DiGi.Core.Classes.Utf8JsonSplitter_TSerializableObject_.Reset()'></a>

## Utf8JsonSplitter\<TSerializableObject\>\.Reset\(\) Method

Resets the internal iterator to the beginning\.

```csharp
public void Reset();
```

<a name='DiGi.Core.Classes.Utf8JsonSplitter_TSerializableObject_.TryPeek(TSerializableObject,byte[])'></a>

## Utf8JsonSplitter\<TSerializableObject\>\.TryPeek\(TSerializableObject, byte\[\]\) Method

Gets the next object and its serialized bytes without consuming it, serializing it at most once\.

```csharp
private bool TryPeek(out TSerializableObject? serializableObject, out byte[]? utf8Json);
```
#### Parameters

<a name='DiGi.Core.Classes.Utf8JsonSplitter_TSerializableObject_.TryPeek(TSerializableObject,byte[]).serializableObject'></a>

`serializableObject` [TSerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.Utf8JsonSplitter_TSerializableObject_.TSerializableObject 'DiGi\.Core\.Classes\.Utf8JsonSplitter\<TSerializableObject\>\.TSerializableObject')

When this method returns, contains the next object\.

<a name='DiGi.Core.Classes.Utf8JsonSplitter_TSerializableObject_.TryPeek(TSerializableObject,byte[]).utf8Json'></a>

`utf8Json` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

When this method returns, contains the UTF\-8 JSON of the next object\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if an object is available; otherwise, false\.

<a name='DiGi.Core.Classes.Value'></a>

## Value Class

A non\-generic version of the Value class that wraps an object\.

```csharp
public class Value : DiGi.Core.Classes.Value<object>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.Value&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Value_TObject_ 'DiGi\.Core\.Classes\.Value\<TObject\>')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Value_TObject_ 'DiGi\.Core\.Classes\.Value\<TObject\>') → Value

Derived  
↳ [Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')
### Constructors

<a name='DiGi.Core.Classes.Value.Value(bool)'></a>

## Value\(bool\) Constructor

Initializes a new instance of the Value class with a boolean value\.

```csharp
public Value(bool value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(bool).value'></a>

`value` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

The boolean value\.

<a name='DiGi.Core.Classes.Value.Value(bool[])'></a>

## Value\(bool\[\]\) Constructor

Initializes a new instance of the Value class with a boolean array value\.

```csharp
public Value(bool[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(bool[]).value'></a>

`value` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The boolean array\.

<a name='DiGi.Core.Classes.Value.Value(byte)'></a>

## Value\(byte\) Constructor

Initializes a new instance of the Value class with a byte value\.

```csharp
public Value(byte value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(byte).value'></a>

`value` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')

The byte value\.

<a name='DiGi.Core.Classes.Value.Value(byte[])'></a>

## Value\(byte\[\]\) Constructor

Initializes a new instance of the Value class with a byte array value\.

```csharp
public Value(byte[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(byte[]).value'></a>

`value` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The byte array\.

<a name='DiGi.Core.Classes.Value.Value(char)'></a>

## Value\(char\) Constructor

Initializes a new instance of the Value class with a character value\.

```csharp
public Value(char value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(char).value'></a>

`value` [System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')

The character value\.

<a name='DiGi.Core.Classes.Value.Value(char[])'></a>

## Value\(char\[\]\) Constructor

Initializes a new instance of the Value class with a character array value\.

```csharp
public Value(char[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(char[]).value'></a>

`value` [System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The character array\.

<a name='DiGi.Core.Classes.Value.Value(decimal)'></a>

## Value\(decimal\) Constructor

Initializes a new instance of the Value class with a decimal value\.

```csharp
public Value(decimal value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(decimal).value'></a>

`value` [System\.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal 'System\.Decimal')

The decimal value\.

<a name='DiGi.Core.Classes.Value.Value(decimal[])'></a>

## Value\(decimal\[\]\) Constructor

Initializes a new instance of the Value class with a decimal array value\.

```csharp
public Value(decimal[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(decimal[]).value'></a>

`value` [System\.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal 'System\.Decimal')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The decimal array\.

<a name='DiGi.Core.Classes.Value.Value(DiGi.Core.Classes.Value)'></a>

## Value\(Value\) Constructor

Initializes a new instance of the Value class by copying another Value object\.

```csharp
public Value(DiGi.Core.Classes.Value? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(DiGi.Core.Classes.Value).value'></a>

`value` [Value](DiGi.Core.Classes.md#DiGi.Core.Classes.Value 'DiGi\.Core\.Classes\.Value')

The source value to copy from\.

<a name='DiGi.Core.Classes.Value.Value(DiGi.Core.Interfaces.ISerializableObject)'></a>

## Value\(ISerializableObject\) Constructor

Initializes a new instance of the Value class with a serializable object value\.

```csharp
public Value(DiGi.Core.Interfaces.ISerializableObject? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(DiGi.Core.Interfaces.ISerializableObject).value'></a>

`value` [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The serializable object\.

<a name='DiGi.Core.Classes.Value.Value(double)'></a>

## Value\(double\) Constructor

Initializes a new instance of the Value class with a double value\.

```csharp
public Value(double value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value\.

<a name='DiGi.Core.Classes.Value.Value(double[])'></a>

## Value\(double\[\]\) Constructor

Initializes a new instance of the Value class with a double array value\.

```csharp
public Value(double[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(double[]).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The double array\.

<a name='DiGi.Core.Classes.Value.Value(float)'></a>

## Value\(float\) Constructor

Initializes a new instance of the Value class with a float value\.

```csharp
public Value(float value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(float).value'></a>

`value` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The float value\.

<a name='DiGi.Core.Classes.Value.Value(float[])'></a>

## Value\(float\[\]\) Constructor

Initializes a new instance of the Value class with a float array value\.

```csharp
public Value(float[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(float[]).value'></a>

`value` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The float array\.

<a name='DiGi.Core.Classes.Value.Value(int)'></a>

## Value\(int\) Constructor

Initializes a new instance of the Value class with an integer value\.

```csharp
public Value(int value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(int).value'></a>

`value` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer value\.

<a name='DiGi.Core.Classes.Value.Value(int[])'></a>

## Value\(int\[\]\) Constructor

Initializes a new instance of the Value class with an integer array value\.

```csharp
public Value(int[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(int[]).value'></a>

`value` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The integer array\.

<a name='DiGi.Core.Classes.Value.Value(long)'></a>

## Value\(long\) Constructor

Initializes a new instance of the Value class with a long value\.

```csharp
public Value(long value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(long).value'></a>

`value` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The long value\.

<a name='DiGi.Core.Classes.Value.Value(long[])'></a>

## Value\(long\[\]\) Constructor

Initializes a new instance of the Value class with a long array value\.

```csharp
public Value(long[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(long[]).value'></a>

`value` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The long array\.

<a name='DiGi.Core.Classes.Value.Value(object)'></a>

## Value\(object\) Constructor

Initializes a new instance of the Value class from a generic object value\.

```csharp
protected Value(object? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to wrap\.

<a name='DiGi.Core.Classes.Value.Value(sbyte)'></a>

## Value\(sbyte\) Constructor

Initializes a new instance of the Value class with a signed byte value\.

```csharp
public Value(sbyte value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(sbyte).value'></a>

`value` [System\.SByte](https://learn.microsoft.com/en-us/dotnet/api/system.sbyte 'System\.SByte')

The signed byte value\.

<a name='DiGi.Core.Classes.Value.Value(sbyte[])'></a>

## Value\(sbyte\[\]\) Constructor

Initializes a new instance of the Value class with a signed byte array value\.

```csharp
public Value(sbyte[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(sbyte[]).value'></a>

`value` [System\.SByte](https://learn.microsoft.com/en-us/dotnet/api/system.sbyte 'System\.SByte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The signed byte array\.

<a name='DiGi.Core.Classes.Value.Value(short)'></a>

## Value\(short\) Constructor

Initializes a new instance of the Value class with a short integer value\.

```csharp
public Value(short value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(short).value'></a>

`value` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The short integer value\.

<a name='DiGi.Core.Classes.Value.Value(short[])'></a>

## Value\(short\[\]\) Constructor

Initializes a new instance of the Value class with a short integer array value\.

```csharp
public Value(short[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(short[]).value'></a>

`value` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The short integer array\.

<a name='DiGi.Core.Classes.Value.Value(string)'></a>

## Value\(string\) Constructor

Initializes a new instance of the Value class with a string value\.

```csharp
public Value(string? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(string).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string value\.

<a name='DiGi.Core.Classes.Value.Value(string[])'></a>

## Value\(string\[\]\) Constructor

Initializes a new instance of the Value class with a string array value\.

```csharp
public Value(string[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(string[]).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The string array\.

<a name='DiGi.Core.Classes.Value.Value(System.DateTime)'></a>

## Value\(DateTime\) Constructor

Initializes a new instance of the Value class with a DateTime value\.

```csharp
public Value(System.DateTime value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(System.DateTime).value'></a>

`value` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The date and time value\.

<a name='DiGi.Core.Classes.Value.Value(System.DateTimeOffset)'></a>

## Value\(DateTimeOffset\) Constructor

Initializes a new instance of the Value class with a DateTimeOffset value\.

```csharp
public Value(System.DateTimeOffset value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(System.DateTimeOffset).value'></a>

`value` [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')

The date, time, and offset value\.

<a name='DiGi.Core.Classes.Value.Value(System.DateTimeOffset[])'></a>

## Value\(DateTimeOffset\[\]\) Constructor

Initializes a new instance of the Value class with a DateTimeOffset array value\.

```csharp
public Value(System.DateTimeOffset[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(System.DateTimeOffset[]).value'></a>

`value` [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The DateTimeOffset array\.

<a name='DiGi.Core.Classes.Value.Value(System.DateTime[])'></a>

## Value\(DateTime\[\]\) Constructor

Initializes a new instance of the Value class with a DateTime array value\.

```csharp
public Value(System.DateTime[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(System.DateTime[]).value'></a>

`value` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The DateTime array\.

<a name='DiGi.Core.Classes.Value.Value(System.Guid)'></a>

## Value\(Guid\) Constructor

Initializes a new instance of the Value class with a Guid value\.

```csharp
public Value(System.Guid value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(System.Guid).value'></a>

`value` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The Guid value\.

<a name='DiGi.Core.Classes.Value.Value(System.Guid[])'></a>

## Value\(Guid\[\]\) Constructor

Initializes a new instance of the Value class with a Guid array value\.

```csharp
public Value(System.Guid[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(System.Guid[]).value'></a>

`value` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The Guid array\.

<a name='DiGi.Core.Classes.Value.Value(System.Text.Json.Nodes.JsonObject)'></a>

## Value\(JsonObject\) Constructor

Initializes a new instance of the Value class from a JSON object\.

```csharp
public Value(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object\.

<a name='DiGi.Core.Classes.Value.Value(System.TimeSpan)'></a>

## Value\(TimeSpan\) Constructor

Initializes a new instance of the Value class with a TimeSpan value\.

```csharp
public Value(System.TimeSpan value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(System.TimeSpan).value'></a>

`value` [System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan')

The time span value\.

<a name='DiGi.Core.Classes.Value.Value(System.TimeSpan[])'></a>

## Value\(TimeSpan\[\]\) Constructor

Initializes a new instance of the Value class with a TimeSpan array value\.

```csharp
public Value(System.TimeSpan[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(System.TimeSpan[]).value'></a>

`value` [System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The TimeSpan array\.

<a name='DiGi.Core.Classes.Value.Value(System.Type)'></a>

## Value\(Type\) Constructor

Initializes a new instance of the Value class with a Type value\.

```csharp
public Value(System.Type? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(System.Type).value'></a>

`value` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to wrap\.

<a name='DiGi.Core.Classes.Value.Value(uint)'></a>

## Value\(uint\) Constructor

Initializes a new instance of the Value class with an unsigned integer value\.

```csharp
public Value(uint value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(uint).value'></a>

`value` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

The unsigned integer value\.

<a name='DiGi.Core.Classes.Value.Value(uint[])'></a>

## Value\(uint\[\]\) Constructor

Initializes a new instance of the Value class with an unsigned integer array value\.

```csharp
public Value(uint[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(uint[]).value'></a>

`value` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The unsigned integer array\.

<a name='DiGi.Core.Classes.Value.Value(ulong)'></a>

## Value\(ulong\) Constructor

Initializes a new instance of the Value class with an unsigned long integer value\.

```csharp
public Value(ulong value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(ulong).value'></a>

`value` [System\.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64 'System\.UInt64')

The unsigned long integer value\.

<a name='DiGi.Core.Classes.Value.Value(ulong[])'></a>

## Value\(ulong\[\]\) Constructor

Initializes a new instance of the Value class with an unsigned long integer array value\.

```csharp
public Value(ulong[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(ulong[]).value'></a>

`value` [System\.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64 'System\.UInt64')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The unsigned long integer array\.

<a name='DiGi.Core.Classes.Value.Value(ushort)'></a>

## Value\(ushort\) Constructor

Initializes a new instance of the Value class with an unsigned short integer value\.

```csharp
public Value(ushort value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(ushort).value'></a>

`value` [System\.UInt16](https://learn.microsoft.com/en-us/dotnet/api/system.uint16 'System\.UInt16')

The unsigned short integer value\.

<a name='DiGi.Core.Classes.Value.Value(ushort[])'></a>

## Value\(ushort\[\]\) Constructor

Initializes a new instance of the Value class with an unsigned short integer array value\.

```csharp
public Value(ushort[]? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value.Value(ushort[]).value'></a>

`value` [System\.UInt16](https://learn.microsoft.com/en-us/dotnet/api/system.uint16 'System\.UInt16')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The unsigned short integer array\.
### Methods

<a name='DiGi.Core.Classes.Value.Clone()'></a>

## Value\.Clone\(\) Method

Creates a deep copy of the Value object by creating a new instance with the current value\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.Clone() 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>\.Clone\(\)')

#### Returns
[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned Value object\.

<a name='DiGi.Core.Classes.Value_TObject_'></a>

## Value\<TObject\> Class

A serializable wrapper for values of various types, providing consistent serialization and type tracking\.

```csharp
public class Value<TObject> : DiGi.Core.Classes.SerializableObject, DiGi.Core.Interfaces.IValue<TObject>, DiGi.Core.Interfaces.IValue, DiGi.Core.Interfaces.IObject
```
#### Type parameters

<a name='DiGi.Core.Classes.Value_TObject_.TObject'></a>

`TObject`

The type of the object being wrapped\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object') → [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject') → Value\<TObject\>

Derived  
↳ [Value](DiGi.Core.Classes.md#DiGi.Core.Classes.Value 'DiGi\.Core\.Classes\.Value')

Implements [DiGi\.Core\.Interfaces\.IValue&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IValue_TValue_ 'DiGi\.Core\.Interfaces\.IValue\<TValue\>')[TObject](DiGi.Core.Classes.md#DiGi.Core.Classes.Value_TObject_.TObject 'DiGi\.Core\.Classes\.Value\<TObject\>\.TObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IValue_TValue_ 'DiGi\.Core\.Interfaces\.IValue\<TValue\>'), [IValue](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IValue 'DiGi\.Core\.Interfaces\.IValue'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Classes.Value_TObject_.Value(DiGi.Core.Classes.Value_TObject_)'></a>

## Value\(Value\<TObject\>\) Constructor

Initializes a new instance of the Value class by copying another Value object\.

```csharp
protected Value(DiGi.Core.Classes.Value<TObject>? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value_TObject_.Value(DiGi.Core.Classes.Value_TObject_).value'></a>

`value` [DiGi\.Core\.Classes\.Value&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Value_TObject_ 'DiGi\.Core\.Classes\.Value\<TObject\>')[TObject](DiGi.Core.Classes.md#DiGi.Core.Classes.Value_TObject_.TObject 'DiGi\.Core\.Classes\.Value\<TObject\>\.TObject')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Value_TObject_ 'DiGi\.Core\.Classes\.Value\<TObject\>')

The source value to copy from\.

<a name='DiGi.Core.Classes.Value_TObject_.Value(System.Text.Json.Nodes.JsonObject)'></a>

## Value\(JsonObject\) Constructor

Initializes a new instance of the Value class from a JSON object\.

```csharp
public Value(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.Value_TObject_.Value(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object\.

<a name='DiGi.Core.Classes.Value_TObject_.Value(TObject)'></a>

## Value\(TObject\) Constructor

Initializes a new instance of the Value class with a value of type TObject\.

```csharp
protected Value(TObject? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Value_TObject_.Value(TObject).value'></a>

`value` [TObject](DiGi.Core.Classes.md#DiGi.Core.Classes.Value_TObject_.TObject 'DiGi\.Core\.Classes\.Value\<TObject\>\.TObject')

The value to wrap\.
### Properties

<a name='DiGi.Core.Classes.Value_TObject_.ValueType'></a>

## Value\<TObject\>\.ValueType Property

Gets the runtime type of the wrapped value\.

```csharp
public System.Type? ValueType { get; }
```

#### Property Value
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')
### Methods

<a name='DiGi.Core.Classes.Value_TObject_.GetValue_XObject_()'></a>

## Value\<TObject\>\.GetValue\<XObject\>\(\) Method

Attempts to retrieve the wrapped value cast to a specific type XObject\.

```csharp
public XObject? GetValue<XObject>()
    where XObject : TObject;
```
#### Type parameters

<a name='DiGi.Core.Classes.Value_TObject_.GetValue_XObject_().XObject'></a>

`XObject`

The target type\.

Implements [GetValue&lt;XValue&gt;\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IValue_TValue_.GetValue_XValue_() 'DiGi\.Core\.Interfaces\.IValue\<TValue\>\.GetValue\<XValue\>\(\)')

#### Returns
[XObject](DiGi.Core.Classes.md#DiGi.Core.Classes.Value_TObject_.GetValue_XObject_().XObject 'DiGi\.Core\.Classes\.Value\<TObject\>\.GetValue\<XObject\>\(\)\.XObject')  
The value cast to XObject if successful; otherwise, default\.
### Explicit Interface Implementations

<a name='DiGi.Core.Classes.Value_TObject_.DiGi.Core.Interfaces.IValue_TObject_.Value'></a>

## DiGi\.Core\.Interfaces\.IValue\<TObject\>\.Value Property

Gets the wrapped value\.

```csharp
TObject? DiGi.Core.Interfaces.IValue<TObject>.Value { get; }
```

Implements [Value](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IValue_TValue_.Value 'DiGi\.Core\.Interfaces\.IValue\<TValue\>\.Value')

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_'></a>

## ValueCluster\<TKey\_1,TKey\_2,TValue\> Class

Represents a base abstract value cluster for organizing data by keys\.

```csharp
public abstract class ValueCluster<TKey_1,TKey_2,TValue> : DiGi.Core.Classes.Cluster<TKey_1, TKey_2, TValue>
```
#### Type parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_1'></a>

`TKey_1`

The type of the first key used for organization\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_2'></a>

`TKey_2`

The type of the second key used for organization\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TValue'></a>

`TValue`

The type of values stored in the cluster\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Cluster&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')[TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')[TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>') → ValueCluster\<TKey\_1,TKey\_2,TValue\>

Derived  
↳ [SerializableObjectValueCluster&lt;TKey\_1,TKey\_2,TValue&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>')
### Constructors

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.ValueCluster()'></a>

## ValueCluster\(\) Constructor

Initializes a new instance of the ValueCluster class\.

```csharp
public ValueCluster();
```

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.ValueCluster(DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_)'></a>

## ValueCluster\(ValueCluster\<TKey\_1,TKey\_2,TValue\>\) Constructor

Initializes a new instance of the ValueCluster class from another value cluster\.

```csharp
public ValueCluster(DiGi.Core.Classes.ValueCluster<TKey_1,TKey_2,TValue>? valueCluster);
```
#### Parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.ValueCluster(DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_).valueCluster'></a>

`valueCluster` [DiGi\.Core\.Classes\.ValueCluster&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>')[TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>')[TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')[,](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>')

The value cluster to copy from\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.ValueCluster(System.Collections.Generic.IEnumerable_TValue_)'></a>

## ValueCluster\(IEnumerable\<TValue\>\) Constructor

Initializes a new instance of the ValueCluster class using the specified collection of values\.

```csharp
public ValueCluster(System.Collections.Generic.IEnumerable<TValue>? values);
```
#### Parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.ValueCluster(System.Collections.Generic.IEnumerable_TValue_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of values to initialize the cluster with\.
### Methods

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.Add(TValue)'></a>

## ValueCluster\<TKey\_1,TKey\_2,TValue\>\.Add\(TValue\) Method

Adds the specified value to the value cluster\.

```csharp
public override bool Add(TValue? value);
```
#### Parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.Add(TValue).value'></a>

`value` [TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TValue')

The value to add to the cluster\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
true if the element is successfully added to the cluster; otherwise, false\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.Clear()'></a>

## ValueCluster\<TKey\_1,TKey\_2,TValue\>\.Clear\(\) Method

Removes all elements from the value cluster\.

```csharp
public override void Clear();
```

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.Contains(TKey_1)'></a>

## ValueCluster\<TKey\_1,TKey\_2,TValue\>\.Contains\(TKey\_1\) Method

Determines whether the cluster contains an element with the specified primary key\.

```csharp
public override bool Contains(TKey_1? key_1);
```
#### Parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.Contains(TKey_1).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The primary key to locate in the cluster\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
true if the cluster contains an element with the specified primary key; otherwise, false\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.Contains(TKey_1,TKey_2)'></a>

## ValueCluster\<TKey\_1,TKey\_2,TValue\>\.Contains\(TKey\_1, TKey\_2\) Method

Determines whether the cluster contains an element with the specified combination of keys\.

```csharp
public override bool Contains(TKey_1? key_1, TKey_2? key_2);
```
#### Parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.Contains(TKey_1,TKey_2).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The first part of the key\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.Contains(TKey_1,TKey_2).key_2'></a>

`key_2` [TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')

The second part of the key\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
true if the cluster contains an element with the specified combination of keys; otherwise, false\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.Contains(TValue)'></a>

## ValueCluster\<TKey\_1,TKey\_2,TValue\>\.Contains\(TValue\) Method

Determines whether the cluster contains a specific value\.

```csharp
public override bool Contains(TValue? value);
```
#### Parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.Contains(TValue).value'></a>

`value` [TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TValue')

The value to locate in the cluster\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
true if the cluster contains a specific value; otherwise, false\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetEnumerator()'></a>

## ValueCluster\<TKey\_1,TKey\_2,TValue\>\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the cluster values\.

```csharp
public override System.Collections.Generic.IEnumerator<TValue> GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator 'System\.Collections\.Generic\.IEnumerable\`1\.GetEnumerator'), [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

#### Returns
[System\.Collections\.Generic\.IEnumerator&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')[TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')  
An enumerator for the cluster values\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetKeys_1()'></a>

## ValueCluster\<TKey\_1,TKey\_2,TValue\>\.GetKeys\_1\(\) Method

Returns a list of all primary keys in the cluster\.

```csharp
public override System.Collections.Generic.List<TKey_1>? GetKeys_1();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing all primary keys present in the cluster, or null if the cluster is empty\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetKeys_2(TKey_1)'></a>

## ValueCluster\<TKey\_1,TKey\_2,TValue\>\.GetKeys\_2\(TKey\_1\) Method

Returns a list of secondary keys associated with the specified primary key\.

```csharp
public override System.Collections.Generic.List<TKey_2>? GetKeys_2(TKey_1? key_1);
```
#### Parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetKeys_2(TKey_1).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The primary key used to look up the secondary keys\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of secondary keys associated with the specified primary key, or null if none are found\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetValue_UValue_(System.Func_UValue,bool_)'></a>

## ValueCluster\<TKey\_1,TKey\_2,TValue\>\.GetValue\<UValue\>\(Func\<UValue,bool\>\) Method

Retrieves the first value that satisfies the specified predicate\.

```csharp
public override UValue? GetValue<UValue>(System.Func<UValue?,bool>? func)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetValue_UValue_(System.Func_UValue,bool_).UValue'></a>

`UValue`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetValue_UValue_(System.Func_UValue,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetValue_UValue_(System.Func_UValue,bool_).UValue 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.GetValue\<UValue\>\(System\.Func\<UValue,bool\>\)\.UValue')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

A function to test each element for a condition\.

#### Returns
[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetValue_UValue_(System.Func_UValue,bool_).UValue 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.GetValue\<UValue\>\(System\.Func\<UValue,bool\>\)\.UValue')  
The first value that satisfies the specified predicate, or null if no such value is found\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetValue_UValue_(TKey_1,TKey_2)'></a>

## ValueCluster\<TKey\_1,TKey\_2,TValue\>\.GetValue\<UValue\>\(TKey\_1, TKey\_2\) Method

Retrieves the value associated with the specified combination of keys\.

```csharp
public UValue? GetValue<UValue>(TKey_1? key_1, TKey_2? key_2)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetValue_UValue_(TKey_1,TKey_2).UValue'></a>

`UValue`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetValue_UValue_(TKey_1,TKey_2).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The first key in the combination\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetValue_UValue_(TKey_1,TKey_2).key_2'></a>

`key_2` [TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')

The second key in the combination\.

#### Returns
[UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetValue_UValue_(TKey_1,TKey_2).UValue 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.GetValue\<UValue\>\(TKey\_1, TKey\_2\)\.UValue')  
The value associated with the specified keys, or null if no such value exists\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetValues_U_()'></a>

## ValueCluster\<TKey\_1,TKey\_2,TValue\>\.GetValues\<U\>\(\) Method

Returns all values contained in the cluster\.

```csharp
public override System.Collections.Generic.List<U> GetValues<U>()
    where U : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetValues_U_().U'></a>

`U`

The type of the values returned\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[U](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetValues_U_().U 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.GetValues\<U\>\(\)\.U')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing all values in the cluster\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetValues_U_(TKey_1)'></a>

## ValueCluster\<TKey\_1,TKey\_2,TValue\>\.GetValues\<U\>\(TKey\_1\) Method

Retrieves all values associated with the specified primary key\.

```csharp
public override System.Collections.Generic.List<U>? GetValues<U>(TKey_1? key_1)
    where U : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetValues_U_(TKey_1).U'></a>

`U`

The type of values to retrieve\.
#### Parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetValues_U_(TKey_1).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The primary key used to look up the values\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[U](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.GetValues_U_(TKey_1).U 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.GetValues\<U\>\(TKey\_1\)\.U')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of values associated with the specified key, or null if no values are found\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.Remove(TKey_1)'></a>

## ValueCluster\<TKey\_1,TKey\_2,TValue\>\.Remove\(TKey\_1\) Method

Removes all elements associated with the specified primary key from the cluster\.

```csharp
public override bool Remove(TKey_1? key_1);
```
#### Parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.Remove(TKey_1).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The primary key used to identify the elements to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
true if one or more elements were removed; otherwise, false\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.Remove(TKey_1,TKey_2)'></a>

## ValueCluster\<TKey\_1,TKey\_2,TValue\>\.Remove\(TKey\_1, TKey\_2\) Method

Removes the element associated with the specified combination of keys from the cluster\.

```csharp
public override bool Remove(TKey_1? key_1, TKey_2? key_2);
```
#### Parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.Remove(TKey_1,TKey_2).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The first key used to identify the element\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.Remove(TKey_1,TKey_2).key_2'></a>

`key_2` [TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')

The second key used to identify the element\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
true if the element was successfully removed; otherwise, false\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.Remove(TValue)'></a>

## ValueCluster\<TKey\_1,TKey\_2,TValue\>\.Remove\(TValue\) Method

Removes the first occurrence of a specific value from the cluster\.

```csharp
public override bool Remove(TValue? value);
```
#### Parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.Remove(TValue).value'></a>

`value` [TValue](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TValue 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TValue')

The value to remove from the cluster\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
true if the value was successfully removed; otherwise, false\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TryGetValue_UValue_(TKey_1,TKey_2,UValue)'></a>

## ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TryGetValue\<UValue\>\(TKey\_1, TKey\_2, UValue\) Method

Attempts to retrieve the value associated with the specified combination of keys\.

```csharp
public bool TryGetValue<UValue>(TKey_1? key_1, TKey_2? key_2, out UValue? value)
    where UValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TryGetValue_UValue_(TKey_1,TKey_2,UValue).UValue'></a>

`UValue`

The type of the value to be retrieved\.
#### Parameters

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TryGetValue_UValue_(TKey_1,TKey_2,UValue).key_1'></a>

`key_1` [TKey\_1](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_1 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_1')

The first key used to identify the value\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TryGetValue_UValue_(TKey_1,TKey_2,UValue).key_2'></a>

`key_2` [TKey\_2](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TKey_2 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TKey\_2')

The second key used to identify the value\.

<a name='DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TryGetValue_UValue_(TKey_1,TKey_2,UValue).value'></a>

`value` [UValue](DiGi.Core.Classes.md#DiGi.Core.Classes.ValueCluster_TKey_1,TKey_2,TValue_.TryGetValue_UValue_(TKey_1,TKey_2,UValue).UValue 'DiGi\.Core\.Classes\.ValueCluster\<TKey\_1,TKey\_2,TValue\>\.TryGetValue\<UValue\>\(TKey\_1, TKey\_2, UValue\)\.UValue')

When this method returns, contains the value associated with the specified keys, if found; otherwise, the default value for the type of the value parameter\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
true if the value was found; otherwise, false\.
### Structs

<a name='DiGi.Core.Classes.Factor'></a>

## Factor Struct

Represents a normalization factor as a value between 0 and 1\.

```csharp
public readonly struct Factor : DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Implements [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Core.Classes.Factor.Factor()'></a>

## Factor\(\) Constructor

Initializes a new instance of the Factor struct with default values\.

```csharp
public Factor();
```

<a name='DiGi.Core.Classes.Factor.Factor(DiGi.Core.Classes.Factor)'></a>

## Factor\(Factor\) Constructor

Initializes a new instance of the Factor struct by copying another Factor\.

```csharp
public Factor(DiGi.Core.Classes.Factor factor);
```
#### Parameters

<a name='DiGi.Core.Classes.Factor.Factor(DiGi.Core.Classes.Factor).factor'></a>

`factor` [Factor](DiGi.Core.Classes.md#DiGi.Core.Classes.Factor 'DiGi\.Core\.Classes\.Factor')

The source factor\.

<a name='DiGi.Core.Classes.Factor.Factor(double)'></a>

## Factor\(double\) Constructor

Initializes a new instance of the Factor struct with a specified value clamped between 0 and 1\.

```csharp
public Factor(double value);
```
#### Parameters

<a name='DiGi.Core.Classes.Factor.Factor(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The factor value\.

<a name='DiGi.Core.Classes.Factor.Factor(System.Text.Json.Nodes.JsonObject)'></a>

## Factor\(JsonObject\) Constructor

Initializes a new instance of the Factor struct from a JsonObject, reading its `Value` node and clamping it between 0 and 1\.

The node is read here rather than through [FromJsonObject\(this ISerializableObject, JsonObject\)](DiGi.Core.md#DiGi.Core.Modify.FromJsonObject(thisDiGi.Core.Interfaces.ISerializableObject,System.Text.Json.Nodes.JsonObject) 'DiGi\.Core\.Modify\.FromJsonObject\(this DiGi\.Core\.Interfaces\.ISerializableObject, System\.Text\.Json\.Nodes\.JsonObject\)'), which would populate a boxed copy of this readonly struct and leave the value [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN').

```csharp
public Factor(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.Factor.Factor(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the factor value; a missing or unreadable `Value` yields [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.
### Methods

<a name='DiGi.Core.Classes.Factor.Clone()'></a>

## Factor\.Clone\(\) Method

Creates a deep copy of the factor\.

```csharp
public DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.Clone() 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>\.Clone\(\)')

#### Returns
[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new Factor instance with the same value\.

<a name='DiGi.Core.Classes.Factor.FromJsonObject(System.Text.Json.Nodes.JsonObject)'></a>

## Factor\.FromJsonObject\(JsonObject\) Method

Does nothing: a readonly struct cannot be populated in place\. Construct a new factor with [Factor\(JsonObject\)](DiGi.Core.Classes.md#DiGi.Core.Classes.Factor.Factor(System.Text.Json.Nodes.JsonObject) 'DiGi\.Core\.Classes\.Factor\.Factor\(System\.Text\.Json\.Nodes\.JsonObject\)') instead\.

```csharp
public bool FromJsonObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Classes.Factor.FromJsonObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data; ignored\.

Implements [FromJsonObject\(JsonObject\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject.FromJsonObject(System.Text.Json.Nodes.JsonObject) 'DiGi\.Core\.Interfaces\.ISerializableObject\.FromJsonObject\(System\.Text\.Json\.Nodes\.JsonObject\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
Always false\.

<a name='DiGi.Core.Classes.Factor.ToJsonObject()'></a>

## Factor\.ToJsonObject\(\) Method

Converts the factor to a JsonObject for serialization\.

```csharp
public System.Text.Json.Nodes.JsonObject? ToJsonObject();
```

Implements [ToJsonObject\(\)](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject.ToJsonObject() 'DiGi\.Core\.Interfaces\.ISerializableObject\.ToJsonObject\(\)')

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A JsonObject representation of the factor\.

<a name='DiGi.Core.Classes.Factor.ToString()'></a>

## Factor\.ToString\(\) Method

Returns a string representation of the factor's value\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The numeric value as a string\.
### Operators

<a name='DiGi.Core.Classes.Factor.op_ImplicitDiGi.Core.Classes.Factor(double)'></a>

## Factor\.implicit operator Factor\(double\) Operator

Implicitly converts a double to a Factor\.

```csharp
public static DiGi.Core.Classes.Factor implicit operator DiGi.Core.Classes.Factor(double value);
```
#### Parameters

<a name='DiGi.Core.Classes.Factor.op_ImplicitDiGi.Core.Classes.Factor(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

#### Returns
[Factor](DiGi.Core.Classes.md#DiGi.Core.Classes.Factor 'DiGi\.Core\.Classes\.Factor')

<a name='DiGi.Core.Classes.Factor.op_ImplicitDiGi.Core.Classes.Factor(float)'></a>

## Factor\.implicit operator Factor\(float\) Operator

Implicitly converts a float to a Factor\.

```csharp
public static DiGi.Core.Classes.Factor implicit operator DiGi.Core.Classes.Factor(float value);
```
#### Parameters

<a name='DiGi.Core.Classes.Factor.op_ImplicitDiGi.Core.Classes.Factor(float).value'></a>

`value` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

#### Returns
[Factor](DiGi.Core.Classes.md#DiGi.Core.Classes.Factor 'DiGi\.Core\.Classes\.Factor')

<a name='DiGi.Core.Classes.Factor.op_Implicitdouble(DiGi.Core.Classes.Factor)'></a>

## Factor\.implicit operator double\(Factor\) Operator

Implicitly converts a Factor to its double value\.

```csharp
public static double implicit operator double(DiGi.Core.Classes.Factor factor);
```
#### Parameters

<a name='DiGi.Core.Classes.Factor.op_Implicitdouble(DiGi.Core.Classes.Factor).factor'></a>

`factor` [Factor](DiGi.Core.Classes.md#DiGi.Core.Classes.Factor 'DiGi\.Core\.Classes\.Factor')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Classes.Factor.op_Implicitfloat(DiGi.Core.Classes.Factor)'></a>

## Factor\.implicit operator float\(Factor\) Operator

Implicitly converts a Factor to its float value\.

```csharp
public static float implicit operator float(DiGi.Core.Classes.Factor factor);
```
#### Parameters

<a name='DiGi.Core.Classes.Factor.op_Implicitfloat(DiGi.Core.Classes.Factor).factor'></a>

`factor` [Factor](DiGi.Core.Classes.md#DiGi.Core.Classes.Factor 'DiGi\.Core\.Classes\.Factor')

#### Returns
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Core.Classes.OKLab'></a>

## OKLab Struct

Represents a color in the OKLab perceptual color space, with lightness L and chromatic axes A and B\.

OKLab (Ottosson, 2021) is a perceptually uniform color space: equal Euclidean distances read as equal visual differences, which is why the color ramps interpolate on it and the categorical distance check asserts on it instead of RGB.

```csharp
public readonly struct OKLab
```
### Constructors

<a name='DiGi.Core.Classes.OKLab.OKLab(double,double,double)'></a>

## OKLab\(double, double, double\) Constructor

Initializes a new instance of the OKLab struct with specified lightness and chromatic axes\.

```csharp
public OKLab(double l, double a, double b);
```
#### Parameters

<a name='DiGi.Core.Classes.OKLab.OKLab(double,double,double).l'></a>

`l` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The OKLab lightness L\.

<a name='DiGi.Core.Classes.OKLab.OKLab(double,double,double).a'></a>

`a` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The OKLab A chromatic axis\.

<a name='DiGi.Core.Classes.OKLab.OKLab(double,double,double).b'></a>

`b` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The OKLab B chromatic axis\.
### Properties

<a name='DiGi.Core.Classes.OKLab.A'></a>

## OKLab\.A Property

Gets the OKLab A chromatic axis\.

```csharp
public double A { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Classes.OKLab.B'></a>

## OKLab\.B Property

Gets the OKLab B chromatic axis\.

```csharp
public double B { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Classes.OKLab.L'></a>

## OKLab\.L Property

Gets the OKLab lightness L\.

```csharp
public double L { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Classes.Path'></a>

## Path Struct

Represents a file system path or directory and provides utilities for manipulating and validating it\.

```csharp
public readonly struct Path
```
### Constructors

<a name='DiGi.Core.Classes.Path.Path(string)'></a>

## Path\(string\) Constructor

Initializes a new instance of the Path struct with a specified path string\.

```csharp
public Path(string? value);
```
#### Parameters

<a name='DiGi.Core.Classes.Path.Path(string).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path string\.

<a name='DiGi.Core.Classes.Path.Path(string[])'></a>

## Path\(string\[\]\) Constructor

Initializes a new instance of the Path struct by combining multiple path segments\.

```csharp
public Path(params string[]? values);
```
#### Parameters

<a name='DiGi.Core.Classes.Path.Path(string[]).values'></a>

`values` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The path segments to combine\.

<a name='DiGi.Core.Classes.Path.Path(System.Nullable_DiGi.Core.Classes.Path_)'></a>

## Path\(Nullable\<Path\>\) Constructor

Initializes a new instance of the Path struct by copying another Path\.

```csharp
public Path(System.Nullable<DiGi.Core.Classes.Path> path);
```
#### Parameters

<a name='DiGi.Core.Classes.Path.Path(System.Nullable_DiGi.Core.Classes.Path_).path'></a>

`path` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Path](DiGi.Core.Classes.md#DiGi.Core.Classes.Path 'DiGi\.Core\.Classes\.Path')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The source path\.
### Properties

<a name='DiGi.Core.Classes.Path.DirectoryExists'></a>

## Path\.DirectoryExists Property

Gets a value indicating whether the current path refers to an existing directory\.

```csharp
public bool DirectoryExists { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Classes.Path.DirectoryPath'></a>

## Path\.DirectoryPath Property

Gets a new Path representing the directory component of the current path\.

```csharp
public System.Nullable<DiGi.Core.Classes.Path> DirectoryPath { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Path](DiGi.Core.Classes.md#DiGi.Core.Classes.Path 'DiGi\.Core\.Classes\.Path')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.Core.Classes.Path.Extension'></a>

## Path\.Extension Property

Gets the extension of the path, including the period \('\.'\)\.

```csharp
public string? Extension { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.Path.FileExists'></a>

## Path\.FileExists Property

Gets a value indicating whether the current path refers to an existing file\.

```csharp
public bool FileExists { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Classes.Path.FileName'></a>

## Path\.FileName Property

Gets the file name and extension of the path\.

```csharp
public string? FileName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.Path.FileNameWithoutExtension'></a>

## Path\.FileNameWithoutExtension Property

Gets the file name of the path without the extension\.

```csharp
public string? FileNameWithoutExtension { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.Path.IsEmpty'></a>

## Path\.IsEmpty Property

Gets a value indicating whether the path is null or empty\.

```csharp
public bool IsEmpty { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')
### Methods

<a name='DiGi.Core.Classes.Path.Equals(object)'></a>

## Path\.Equals\(object\) Method

Determines whether the specified object is equal to the current Path\.

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='DiGi.Core.Classes.Path.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Classes.Path.GetDirectoryInfo()'></a>

## Path\.GetDirectoryInfo\(\) Method

Retrieves a DirectoryInfo object for the current path, if valid\.

```csharp
public System.IO.DirectoryInfo? GetDirectoryInfo();
```

#### Returns
[System\.IO\.DirectoryInfo](https://learn.microsoft.com/en-us/dotnet/api/system.io.directoryinfo 'System\.IO\.DirectoryInfo')  
A DirectoryInfo object or null if the path is invalid\.

<a name='DiGi.Core.Classes.Path.GetFileInfo()'></a>

## Path\.GetFileInfo\(\) Method

Retrieves a FileInfo object for the current path, if valid\.

```csharp
public System.IO.FileInfo? GetFileInfo();
```

#### Returns
[System\.IO\.FileInfo](https://learn.microsoft.com/en-us/dotnet/api/system.io.fileinfo 'System\.IO\.FileInfo')  
A FileInfo object or null if the path is invalid\.

<a name='DiGi.Core.Classes.Path.GetHashCode()'></a>

## Path\.GetHashCode\(\) Method

Returns the hash code for this Path\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.Classes.Path.IsValid()'></a>

## Path\.IsValid\(\) Method

Validates whether the path is a valid URI \(relative or absolute\)\.

```csharp
public bool IsValid();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if valid; otherwise, false\.

<a name='DiGi.Core.Classes.Path.IsValid(System.UriKind)'></a>

## Path\.IsValid\(UriKind\) Method

Validates whether the path is a valid URI of the specified kind\.

```csharp
public bool IsValid(System.UriKind uriKind);
```
#### Parameters

<a name='DiGi.Core.Classes.Path.IsValid(System.UriKind).uriKind'></a>

`uriKind` [System\.UriKind](https://learn.microsoft.com/en-us/dotnet/api/system.urikind 'System\.UriKind')

The type of URI to validate against\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if valid; otherwise, false\.
### Operators

<a name='DiGi.Core.Classes.Path.op_Addition(System.Nullable_DiGi.Core.Classes.Path_,string)'></a>

## Path\.operator \+\(Nullable\<Path\>, string\) Operator

Combines the current Path with another string segment to create a new Path\.

```csharp
public static System.Nullable<DiGi.Core.Classes.Path> operator +(System.Nullable<DiGi.Core.Classes.Path> path, string value);
```
#### Parameters

<a name='DiGi.Core.Classes.Path.op_Addition(System.Nullable_DiGi.Core.Classes.Path_,string).path'></a>

`path` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Path](DiGi.Core.Classes.md#DiGi.Core.Classes.Path 'DiGi\.Core\.Classes\.Path')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.Core.Classes.Path.op_Addition(System.Nullable_DiGi.Core.Classes.Path_,string).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Path](DiGi.Core.Classes.md#DiGi.Core.Classes.Path 'DiGi\.Core\.Classes\.Path')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.Core.Classes.Path.op_Equality(System.Nullable_DiGi.Core.Classes.Path_,System.Nullable_DiGi.Core.Classes.Path_)'></a>

## Path\.operator ==\(Nullable\<Path\>, Nullable\<Path\>\) Operator

Determines whether two Path instances are equal\.

```csharp
public static bool operator ==(System.Nullable<DiGi.Core.Classes.Path> path_1, System.Nullable<DiGi.Core.Classes.Path> path_2);
```
#### Parameters

<a name='DiGi.Core.Classes.Path.op_Equality(System.Nullable_DiGi.Core.Classes.Path_,System.Nullable_DiGi.Core.Classes.Path_).path_1'></a>

`path_1` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Path](DiGi.Core.Classes.md#DiGi.Core.Classes.Path 'DiGi\.Core\.Classes\.Path')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.Core.Classes.Path.op_Equality(System.Nullable_DiGi.Core.Classes.Path_,System.Nullable_DiGi.Core.Classes.Path_).path_2'></a>

`path_2` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Path](DiGi.Core.Classes.md#DiGi.Core.Classes.Path 'DiGi\.Core\.Classes\.Path')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Classes.Path.op_ImplicitDiGi.Core.Classes.Path(string)'></a>

## Path\.implicit operator Path\(string\) Operator

Implicitly converts a string to a Path\.

```csharp
public static DiGi.Core.Classes.Path implicit operator DiGi.Core.Classes.Path(string value);
```
#### Parameters

<a name='DiGi.Core.Classes.Path.op_ImplicitDiGi.Core.Classes.Path(string).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

#### Returns
[Path](DiGi.Core.Classes.md#DiGi.Core.Classes.Path 'DiGi\.Core\.Classes\.Path')

<a name='DiGi.Core.Classes.Path.op_Implicitstring(System.Nullable_DiGi.Core.Classes.Path_)'></a>

## Path\.implicit operator string\(Nullable\<Path\>\) Operator

Implicitly converts a Path to its underlying string value\.

```csharp
public static string? implicit operator string?(System.Nullable<DiGi.Core.Classes.Path> path);
```
#### Parameters

<a name='DiGi.Core.Classes.Path.op_Implicitstring(System.Nullable_DiGi.Core.Classes.Path_).path'></a>

`path` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Path](DiGi.Core.Classes.md#DiGi.Core.Classes.Path 'DiGi\.Core\.Classes\.Path')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Classes.Path.op_Inequality(System.Nullable_DiGi.Core.Classes.Path_,System.Nullable_DiGi.Core.Classes.Path_)'></a>

## Path\.operator \!=\(Nullable\<Path\>, Nullable\<Path\>\) Operator

Determines whether two Path instances are unequal\.

```csharp
public static bool operator !=(System.Nullable<DiGi.Core.Classes.Path> path_1, System.Nullable<DiGi.Core.Classes.Path> path_2);
```
#### Parameters

<a name='DiGi.Core.Classes.Path.op_Inequality(System.Nullable_DiGi.Core.Classes.Path_,System.Nullable_DiGi.Core.Classes.Path_).path_1'></a>

`path_1` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Path](DiGi.Core.Classes.md#DiGi.Core.Classes.Path 'DiGi\.Core\.Classes\.Path')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.Core.Classes.Path.op_Inequality(System.Nullable_DiGi.Core.Classes.Path_,System.Nullable_DiGi.Core.Classes.Path_).path_2'></a>

`path_2` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Path](DiGi.Core.Classes.md#DiGi.Core.Classes.Path 'DiGi\.Core\.Classes\.Path')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')