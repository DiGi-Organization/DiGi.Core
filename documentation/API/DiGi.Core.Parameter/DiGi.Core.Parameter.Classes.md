#### [DiGi\.Core\.Parameter](DiGi.Core.Parameter.Overview.md 'DiGi\.Core\.Parameter\.Overview')

## DiGi\.Core\.Parameter\.Classes Namespace
### Classes

<a name='DiGi.Core.Parameter.Classes.AssociatedTypes'></a>

## AssociatedTypes Class

Defines a set of types associated with an enum value\.

```csharp
public class AssociatedTypes : System.Attribute, System.Collections.IEnumerable, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → AssociatedTypes

Implements [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Parameter.Classes.AssociatedTypes.AssociatedTypes(DiGi.Core.Parameter.Classes.AssociatedTypes)'></a>

## AssociatedTypes\(AssociatedTypes\) Constructor

Initializes a new instance of the AssociatedTypes class by copying another AssociatedTypes instance\.

```csharp
public AssociatedTypes(DiGi.Core.Parameter.Classes.AssociatedTypes? associatedTypes);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.AssociatedTypes.AssociatedTypes(DiGi.Core.Parameter.Classes.AssociatedTypes).associatedTypes'></a>

`associatedTypes` [AssociatedTypes](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.AssociatedTypes 'DiGi\.Core\.Parameter\.Classes\.AssociatedTypes')

The AssociatedTypes instance to copy\.

<a name='DiGi.Core.Parameter.Classes.AssociatedTypes.AssociatedTypes(System.Text.Json.Nodes.JsonObject)'></a>

## AssociatedTypes\(JsonObject\) Constructor

Initializes a new instance of the AssociatedTypes class from a JSON object\.

```csharp
public AssociatedTypes(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.AssociatedTypes.AssociatedTypes(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing associated types data\.

<a name='DiGi.Core.Parameter.Classes.AssociatedTypes.AssociatedTypes(System.Type[])'></a>

## AssociatedTypes\(Type\[\]\) Constructor

Initializes a new instance of the AssociatedTypes class with specified values\.

```csharp
public AssociatedTypes(params System.Type[]? values);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.AssociatedTypes.AssociatedTypes(System.Type[]).values'></a>

`values` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The associated types\.
### Properties

<a name='DiGi.Core.Parameter.Classes.AssociatedTypes.Types'></a>

## AssociatedTypes\.Types Property

Gets the collection of associated types\.

```csharp
public System.Type[]? Types { get; }
```

#### Property Value
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Core.Parameter.Classes.AssociatedTypes.Clone()'></a>

## AssociatedTypes\.Clone\(\) Method

Creates a shallow copy of the current AssociatedTypes instance\.

```csharp
public virtual DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned ISerializableObject\.

<a name='DiGi.Core.Parameter.Classes.AssociatedTypes.FromJsonObject(System.Text.Json.Nodes.JsonObject)'></a>

## AssociatedTypes\.FromJsonObject\(JsonObject\) Method

Populates the current AssociatedTypes instance from a JSON object\.

```csharp
public virtual bool FromJsonObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.AssociatedTypes.FromJsonObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to read data from\.

Implements [FromJsonObject\(JsonObject\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject.fromjsonobject#digi-core-interfaces-iserializableobject-fromjsonobject(system-text-json-nodes-jsonobject) 'DiGi\.Core\.Interfaces\.ISerializableObject\.FromJsonObject\(System\.Text\.Json\.Nodes\.JsonObject\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if successful, false otherwise\.

<a name='DiGi.Core.Parameter.Classes.AssociatedTypes.GetEnumerator()'></a>

## AssociatedTypes\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the associated types\.

```csharp
public System.Collections.IEnumerator GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

#### Returns
[System\.Collections\.IEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerator 'System\.Collections\.IEnumerator')  
An IEnumerator for the Types collection\.

<a name='DiGi.Core.Parameter.Classes.AssociatedTypes.IsValid(System.Type)'></a>

## AssociatedTypes\.IsValid\(Type\) Method

Determines whether a specified type is associated with this instance\.

```csharp
public virtual bool IsValid(System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.AssociatedTypes.IsValid(System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to validate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the type is valid, false otherwise\.

<a name='DiGi.Core.Parameter.Classes.AssociatedTypes.ToJsonObject()'></a>

## AssociatedTypes\.ToJsonObject\(\) Method

Converts the current AssociatedTypes instance to a JSON object\.

```csharp
public virtual System.Text.Json.Nodes.JsonObject? ToJsonObject();
```

Implements [ToJsonObject\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject.tojsonobject 'DiGi\.Core\.Interfaces\.ISerializableObject\.ToJsonObject')

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
The resulting JsonObject\.

<a name='DiGi.Core.Parameter.Classes.BooleanParameterValue'></a>

## BooleanParameterValue Class

Represents a boolean value for a parameter\.

```csharp
public class BooleanParameterValue : DiGi.Core.Parameter.Classes.ParameterValue
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → [ParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterValue 'DiGi\.Core\.Parameter\.Classes\.ParameterValue') → BooleanParameterValue
### Constructors

<a name='DiGi.Core.Parameter.Classes.BooleanParameterValue.BooleanParameterValue()'></a>

## BooleanParameterValue\(\) Constructor

Initializes a new instance of the [BooleanParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.BooleanParameterValue 'DiGi\.Core\.Parameter\.Classes\.BooleanParameterValue') class\.

```csharp
public BooleanParameterValue();
```

<a name='DiGi.Core.Parameter.Classes.BooleanParameterValue.BooleanParameterValue(bool)'></a>

## BooleanParameterValue\(bool\) Constructor

Initializes a new instance of the [BooleanParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.BooleanParameterValue 'DiGi\.Core\.Parameter\.Classes\.BooleanParameterValue') class with specified nullability\.

```csharp
public BooleanParameterValue(bool nullable);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.BooleanParameterValue.BooleanParameterValue(bool).nullable'></a>

`nullable` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the parameter is nullable\.

<a name='DiGi.Core.Parameter.Classes.BooleanParameterValue.BooleanParameterValue(DiGi.Core.Parameter.Classes.BooleanParameterValue)'></a>

## BooleanParameterValue\(BooleanParameterValue\) Constructor

Initializes a new instance of the [BooleanParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.BooleanParameterValue 'DiGi\.Core\.Parameter\.Classes\.BooleanParameterValue') class by copying an existing value\.

```csharp
public BooleanParameterValue(DiGi.Core.Parameter.Classes.BooleanParameterValue? booleanParameterValue);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.BooleanParameterValue.BooleanParameterValue(DiGi.Core.Parameter.Classes.BooleanParameterValue).booleanParameterValue'></a>

`booleanParameterValue` [BooleanParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.BooleanParameterValue 'DiGi\.Core\.Parameter\.Classes\.BooleanParameterValue')

The BooleanParameterValue to copy\.

<a name='DiGi.Core.Parameter.Classes.BooleanParameterValue.BooleanParameterValue(System.Text.Json.Nodes.JsonObject)'></a>

## BooleanParameterValue\(JsonObject\) Constructor

Initializes a new instance of the [BooleanParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.BooleanParameterValue 'DiGi\.Core\.Parameter\.Classes\.BooleanParameterValue') class from a JSON object\.

```csharp
public BooleanParameterValue(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.BooleanParameterValue.BooleanParameterValue(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the current instance from\.
### Properties

<a name='DiGi.Core.Parameter.Classes.BooleanParameterValue.ParameterType'></a>

## BooleanParameterValue\.ParameterType Property

Gets the type of the parameter, which is Integer\.

```csharp
public override DiGi.Core.Parameter.Enums.ParameterType ParameterType { get; }
```

#### Property Value
[ParameterType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.ParameterType 'DiGi\.Core\.Parameter\.Enums\.ParameterType')
### Methods

<a name='DiGi.Core.Parameter.Classes.BooleanParameterValue.Clone()'></a>

## BooleanParameterValue\.Clone\(\) Method

Creates a shallow copy of the current integer parameter value\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A shallow copy of the current integer parameter value\.

<a name='DiGi.Core.Parameter.Classes.BooleanParameterValue.IsValid(object)'></a>

## BooleanParameterValue\.IsValid\(object\) Method

Determines whether the specified value is a valid integer parameter value\.

```csharp
public override bool IsValid(object? value);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.BooleanParameterValue.IsValid(object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to validate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified value is a valid integer parameter value; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.BooleanParameterValue.TryConvert(object,object)'></a>

## BooleanParameterValue\.TryConvert\(object, object\) Method

Attempts to convert the specified input value to an integer parameter value\.

```csharp
public override bool TryConvert(object? value_In, out object? value_Out);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.BooleanParameterValue.TryConvert(object,object).value_In'></a>

`value_In` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The input value to be converted\.

<a name='DiGi.Core.Parameter.Classes.BooleanParameterValue.TryConvert(object,object).value_Out'></a>

`value_Out` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the converted value if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ComplexParameterDefinition'></a>

## ComplexParameterDefinition Class

Represents the abstract base class for complex parameter definitions\.

```csharp
public abstract class ComplexParameterDefinition : DiGi.Core.Parameter.Classes.ParameterDefinition
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [ParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ParameterDefinition') → ComplexParameterDefinition

Derived  
↳ [EnumParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.EnumParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.EnumParameterDefinition')  
↳ [ExternalParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ExternalParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ExternalParameterDefinition')
### Constructors

<a name='DiGi.Core.Parameter.Classes.ComplexParameterDefinition.ComplexParameterDefinition()'></a>

## ComplexParameterDefinition\(\) Constructor

Creates a new instance of the ComplexParameterDefinition class\.

```csharp
public ComplexParameterDefinition();
```

<a name='DiGi.Core.Parameter.Classes.ComplexParameterDefinition.ComplexParameterDefinition(DiGi.Core.Parameter.Classes.ComplexParameterDefinition)'></a>

## ComplexParameterDefinition\(ComplexParameterDefinition\) Constructor

Creates a new instance of the ComplexParameterDefinition class by copying another ComplexParameterDefinition\.

```csharp
public ComplexParameterDefinition(DiGi.Core.Parameter.Classes.ComplexParameterDefinition? complexParameterDefinition);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ComplexParameterDefinition.ComplexParameterDefinition(DiGi.Core.Parameter.Classes.ComplexParameterDefinition).complexParameterDefinition'></a>

`complexParameterDefinition` [ComplexParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ComplexParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ComplexParameterDefinition')

The ComplexParameterDefinition to copy\.

<a name='DiGi.Core.Parameter.Classes.ComplexParameterDefinition.ComplexParameterDefinition(System.Text.Json.Nodes.JsonObject)'></a>

## ComplexParameterDefinition\(JsonObject\) Constructor

Creates a new instance of the ComplexParameterDefinition class from a JSON object\.

```csharp
public ComplexParameterDefinition(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ComplexParameterDefinition.ComplexParameterDefinition(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the complex parameter definition data\.
### Properties

<a name='DiGi.Core.Parameter.Classes.ComplexParameterDefinition.AccessType'></a>

## ComplexParameterDefinition\.AccessType Property

Gets the access type of the complex parameter definition\.

```csharp
public abstract DiGi.Core.Parameter.Enums.AccessType AccessType { get; }
```

#### Property Value
[AccessType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.AccessType 'DiGi\.Core\.Parameter\.Enums\.AccessType')

<a name='DiGi.Core.Parameter.Classes.ComplexParameterDefinition.AssociatedTypes'></a>

## ComplexParameterDefinition\.AssociatedTypes Property

Gets the associated types of the complex parameter definition\.

```csharp
public abstract DiGi.Core.Parameter.Classes.AssociatedTypes? AssociatedTypes { get; }
```

#### Property Value
[AssociatedTypes](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.AssociatedTypes 'DiGi\.Core\.Parameter\.Classes\.AssociatedTypes')

<a name='DiGi.Core.Parameter.Classes.ComplexParameterDefinition.Description'></a>

## ComplexParameterDefinition\.Description Property

Gets the description of the complex parameter definition\.

```csharp
public abstract string? Description { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Parameter.Classes.ComplexParameterDefinition.ParameterType'></a>

## ComplexParameterDefinition\.ParameterType Property

Gets the type of the parameter\.

```csharp
public override DiGi.Core.Parameter.Enums.ParameterType ParameterType { get; }
```

Implements [ParameterType](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition.ParameterType 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\.ParameterType')

#### Property Value
[ParameterType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.ParameterType 'DiGi\.Core\.Parameter\.Enums\.ParameterType')

<a name='DiGi.Core.Parameter.Classes.ComplexParameterDefinition.ParameterValue'></a>

## ComplexParameterDefinition\.ParameterValue Property

Gets the parameter value of the complex parameter definition\.

```csharp
public abstract DiGi.Core.Parameter.Classes.ParameterValue? ParameterValue { get; }
```

#### Property Value
[ParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterValue 'DiGi\.Core\.Parameter\.Classes\.ParameterValue')
### Methods

<a name='DiGi.Core.Parameter.Classes.ComplexParameterDefinition.IsValid(object)'></a>

## ComplexParameterDefinition\.IsValid\(object\) Method

Determines whether the specified value is valid for this complex parameter definition\.

```csharp
public override bool IsValid(object? value);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ComplexParameterDefinition.IsValid(object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to validate\.

Implements [IsValid\(object\)](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition.IsValid(object) 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\.IsValid\(object\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value is valid, false otherwise\.

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue'></a>

## DoubleParameterValue Class

Represents a double\-precision floating\-point value for a parameter\.

```csharp
public class DoubleParameterValue : DiGi.Core.Parameter.Classes.ParameterValue
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → [ParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterValue 'DiGi\.Core\.Parameter\.Classes\.ParameterValue') → DoubleParameterValue
### Constructors

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.DoubleParameterValue()'></a>

## DoubleParameterValue\(\) Constructor

Initializes a new instance of the [DoubleParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.DoubleParameterValue 'DiGi\.Core\.Parameter\.Classes\.DoubleParameterValue') class\.

```csharp
public DoubleParameterValue();
```

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.DoubleParameterValue(bool)'></a>

## DoubleParameterValue\(bool\) Constructor

Initializes a new instance of the [DoubleParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.DoubleParameterValue 'DiGi\.Core\.Parameter\.Classes\.DoubleParameterValue') class with specified nullability\.

```csharp
public DoubleParameterValue(bool nullable);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.DoubleParameterValue(bool).nullable'></a>

`nullable` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the parameter is nullable\.

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.DoubleParameterValue(bool,double,double)'></a>

## DoubleParameterValue\(bool, double, double\) Constructor

Initializes a new instance of the [DoubleParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.DoubleParameterValue 'DiGi\.Core\.Parameter\.Classes\.DoubleParameterValue') class with specified nullability and range\.

```csharp
public DoubleParameterValue(bool nullable, double min, double max);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.DoubleParameterValue(bool,double,double).nullable'></a>

`nullable` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the parameter is nullable\.

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.DoubleParameterValue(bool,double,double).min'></a>

`min` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimum value for the parameter\.

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.DoubleParameterValue(bool,double,double).max'></a>

`max` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum value for the parameter\.

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.DoubleParameterValue(DiGi.Core.Parameter.Classes.DoubleParameterValue)'></a>

## DoubleParameterValue\(DoubleParameterValue\) Constructor

Initializes a new instance of the [DoubleParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.DoubleParameterValue 'DiGi\.Core\.Parameter\.Classes\.DoubleParameterValue') class by copying an existing value\.

```csharp
public DoubleParameterValue(DiGi.Core.Parameter.Classes.DoubleParameterValue? doubleParameterValue);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.DoubleParameterValue(DiGi.Core.Parameter.Classes.DoubleParameterValue).doubleParameterValue'></a>

`doubleParameterValue` [DoubleParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.DoubleParameterValue 'DiGi\.Core\.Parameter\.Classes\.DoubleParameterValue')

The existing value to copy from\.

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.DoubleParameterValue(double)'></a>

## DoubleParameterValue\(double\) Constructor

Initializes a new instance of the [DoubleParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.DoubleParameterValue 'DiGi\.Core\.Parameter\.Classes\.DoubleParameterValue') class with a minimum value\.

```csharp
public DoubleParameterValue(double min);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.DoubleParameterValue(double).min'></a>

`min` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimum value for the parameter\.

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.DoubleParameterValue(double,double)'></a>

## DoubleParameterValue\(double, double\) Constructor

Initializes a new instance of the [DoubleParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.DoubleParameterValue 'DiGi\.Core\.Parameter\.Classes\.DoubleParameterValue') class with a specified range\.

```csharp
public DoubleParameterValue(double min, double max);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.DoubleParameterValue(double,double).min'></a>

`min` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimum value for the parameter\.

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.DoubleParameterValue(double,double).max'></a>

`max` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum value for the parameter\.

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.DoubleParameterValue(System.Text.Json.Nodes.JsonObject)'></a>

## DoubleParameterValue\(JsonObject\) Constructor

Initializes a new instance of the [DoubleParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.DoubleParameterValue 'DiGi\.Core\.Parameter\.Classes\.DoubleParameterValue') class from a JSON object\.

```csharp
public DoubleParameterValue(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.DoubleParameterValue(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the value from\.
### Properties

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.ParameterType'></a>

## DoubleParameterValue\.ParameterType Property

Gets the type of the parameter, which is Integer\.

```csharp
public override DiGi.Core.Parameter.Enums.ParameterType ParameterType { get; }
```

#### Property Value
[ParameterType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.ParameterType 'DiGi\.Core\.Parameter\.Enums\.ParameterType')
### Methods

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.Clone()'></a>

## DoubleParameterValue\.Clone\(\) Method

Creates a shallow copy of the current integer parameter value\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A shallow copy of the current integer parameter value\.

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.IsValid(object)'></a>

## DoubleParameterValue\.IsValid\(object\) Method

Determines whether the specified value is a valid integer parameter value\.

```csharp
public override bool IsValid(object? value);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.IsValid(object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to validate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified value is a valid integer parameter value; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.TryConvert(object,object)'></a>

## DoubleParameterValue\.TryConvert\(object, object\) Method

Attempts to convert the specified input value to an integer parameter value\.

```csharp
public override bool TryConvert(object? value_In, out object? value_Out);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.TryConvert(object,object).value_In'></a>

`value_In` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The input value to be converted\.

<a name='DiGi.Core.Parameter.Classes.DoubleParameterValue.TryConvert(object,object).value_Out'></a>

`value_Out` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the converted value if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition'></a>

## EnumParameterDefinition Class

Defines a parameter based on an enumeration type\.

```csharp
public class EnumParameterDefinition : DiGi.Core.Parameter.Classes.ComplexParameterDefinition
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [ParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ParameterDefinition') → [ComplexParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ComplexParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ComplexParameterDefinition') → EnumParameterDefinition
### Constructors

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.EnumParameterDefinition()'></a>

## EnumParameterDefinition\(\) Constructor

Initializes a new instance of the [EnumParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.EnumParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.EnumParameterDefinition') class\.

```csharp
public EnumParameterDefinition();
```

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.EnumParameterDefinition(DiGi.Core.Parameter.Classes.EnumParameterDefinition)'></a>

## EnumParameterDefinition\(EnumParameterDefinition\) Constructor

Initializes a new instance of the [EnumParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.EnumParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.EnumParameterDefinition') class by copying an existing definition\.

```csharp
public EnumParameterDefinition(DiGi.Core.Parameter.Classes.EnumParameterDefinition? enumParameterDefinition);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.EnumParameterDefinition(DiGi.Core.Parameter.Classes.EnumParameterDefinition).enumParameterDefinition'></a>

`enumParameterDefinition` [EnumParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.EnumParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.EnumParameterDefinition')

The existing enum parameter definition to copy\.

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.EnumParameterDefinition(System.Enum)'></a>

## EnumParameterDefinition\(Enum\) Constructor

Initializes a new instance of the [EnumParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.EnumParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.EnumParameterDefinition') class based on a specific enumeration value\.

```csharp
public EnumParameterDefinition(System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.EnumParameterDefinition(System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value to use for initialization\.

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.EnumParameterDefinition(System.Text.Json.Nodes.JsonObject)'></a>

## EnumParameterDefinition\(JsonObject\) Constructor

Initializes a new instance of the [EnumParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.EnumParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.EnumParameterDefinition') class from a JSON object\.

```csharp
public EnumParameterDefinition(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.EnumParameterDefinition(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the parameter definition\.
### Properties

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.AccessType'></a>

## EnumParameterDefinition\.AccessType Property

Gets the access type for the enum parameter\.

```csharp
public override DiGi.Core.Parameter.Enums.AccessType AccessType { get; }
```

#### Property Value
[AccessType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.AccessType 'DiGi\.Core\.Parameter\.Enums\.AccessType')

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.AssociatedTypes'></a>

## EnumParameterDefinition\.AssociatedTypes Property

Gets the associated types for the enum parameter\.

```csharp
public override DiGi.Core.Parameter.Classes.AssociatedTypes? AssociatedTypes { get; }
```

#### Property Value
[AssociatedTypes](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.AssociatedTypes 'DiGi\.Core\.Parameter\.Classes\.AssociatedTypes')

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.Description'></a>

## EnumParameterDefinition\.Description Property

Gets or sets the description of the enum parameter\.

```csharp
public override string? Description { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.Enum'></a>

## EnumParameterDefinition\.Enum Property

Gets the underlying enumeration value\.

```csharp
public System.Enum? Enum { get; }
```

#### Property Value
[System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.GroupName'></a>

## EnumParameterDefinition\.GroupName Property

Gets the group name to which the enum parameter belongs\.

```csharp
public override string GroupName { get; }
```

Implements [GroupName](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition.GroupName 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\.GroupName')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.Name'></a>

## EnumParameterDefinition\.Name Property

Gets or sets the name of the enum parameter\.

```csharp
public override string? Name { get; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.ParameterValue'></a>

## EnumParameterDefinition\.ParameterValue Property

Gets or sets the current value of the enum parameter\.

```csharp
public override DiGi.Core.Parameter.Classes.ParameterValue? ParameterValue { get; }
```

#### Property Value
[ParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterValue 'DiGi\.Core\.Parameter\.Classes\.ParameterValue')

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.UniqueId'></a>

## EnumParameterDefinition\.UniqueId Property

Gets or sets the unique identifier for the enum parameter\.

```csharp
public override string? UniqueId { get; }
```

Implements [UniqueId](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition.UniqueId 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\.UniqueId')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.Clone()'></a>

## EnumParameterDefinition\.Clone\(\) Method

Creates a copy of the current enum parameter definition\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A clone of the current enum parameter definition as an [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.FromJsonObject(System.Text.Json.Nodes.JsonObject)'></a>

## EnumParameterDefinition\.FromJsonObject\(JsonObject\) Method

Populates the enum parameter definition from a JSON object\.

```csharp
public override bool FromJsonObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.FromJsonObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to populate the definition from\.

Implements [FromJsonObject\(JsonObject\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject.fromjsonobject#digi-core-interfaces-iserializableobject-fromjsonobject(system-text-json-nodes-jsonobject) 'DiGi\.Core\.Interfaces\.ISerializableObject\.FromJsonObject\(System\.Text\.Json\.Nodes\.JsonObject\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the population was successful; otherwise, `false`\.

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.ToJsonObject()'></a>

## EnumParameterDefinition\.ToJsonObject\(\) Method

Converts the enum parameter definition to a JSON object\.

```csharp
public override System.Text.Json.Nodes.JsonObject ToJsonObject();
```

Implements [ToJsonObject\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject.tojsonobject 'DiGi\.Core\.Interfaces\.ISerializableObject\.ToJsonObject')

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') representation of the enum parameter definition\.
### Operators

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.op_ExplicitDiGi.Core.Parameter.Classes.EnumParameterDefinition(System.Enum)'></a>

## EnumParameterDefinition\.explicit operator EnumParameterDefinition\(Enum\) Operator

Explicitly converts an [Enum](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.EnumParameterDefinition.Enum 'DiGi\.Core\.Parameter\.Classes\.EnumParameterDefinition\.Enum') to an [EnumParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.EnumParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.EnumParameterDefinition')\.

```csharp
public static DiGi.Core.Parameter.Classes.EnumParameterDefinition? explicit operator DiGi.Core.Parameter.Classes.EnumParameterDefinition?(System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.op_ExplicitDiGi.Core.Parameter.Classes.EnumParameterDefinition(System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enum value to convert\.

#### Returns
[EnumParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.EnumParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.EnumParameterDefinition')  
An [EnumParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.EnumParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.EnumParameterDefinition') instance created from the provided enum, or `null` if the input is `null`\.

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.op_ExplicitSystem.Enum(DiGi.Core.Parameter.Classes.EnumParameterDefinition)'></a>

## EnumParameterDefinition\.explicit operator Enum\(EnumParameterDefinition\) Operator

Explicitly converts an [EnumParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.EnumParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.EnumParameterDefinition') to its underlying [Enum](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.EnumParameterDefinition.Enum 'DiGi\.Core\.Parameter\.Classes\.EnumParameterDefinition\.Enum') value\.

```csharp
public static System.Enum? explicit operator System.Enum?(DiGi.Core.Parameter.Classes.EnumParameterDefinition? enumParameterDefinition);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.EnumParameterDefinition.op_ExplicitSystem.Enum(DiGi.Core.Parameter.Classes.EnumParameterDefinition).enumParameterDefinition'></a>

`enumParameterDefinition` [EnumParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.EnumParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.EnumParameterDefinition')

The enum parameter definition to convert\.

#### Returns
[System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')  
The [Enum](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.EnumParameterDefinition.Enum 'DiGi\.Core\.Parameter\.Classes\.EnumParameterDefinition\.Enum') value associated with the definition, or `null` if the input is `null`\.

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition'></a>

## ExternalParameterDefinition Class

Represents a parameter definition defined externally with explicit metadata\.

```csharp
public class ExternalParameterDefinition : DiGi.Core.Parameter.Classes.ComplexParameterDefinition, DiGi.Core.Interfaces.INamedObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [ParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ParameterDefinition') → [ComplexParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ComplexParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ComplexParameterDefinition') → ExternalParameterDefinition

Implements [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.ExternalParameterDefinition()'></a>

## ExternalParameterDefinition\(\) Constructor

Creates a new instance of the ExternalParameterDefinition class\.

```csharp
public ExternalParameterDefinition();
```

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.ExternalParameterDefinition(DiGi.Core.Parameter.Classes.ExternalParameterDefinition)'></a>

## ExternalParameterDefinition\(ExternalParameterDefinition\) Constructor

Creates a new instance of the ExternalParameterDefinition class by copying another ExternalParameterDefinition\.

```csharp
public ExternalParameterDefinition(DiGi.Core.Parameter.Classes.ExternalParameterDefinition? externalParameterDefinition);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.ExternalParameterDefinition(DiGi.Core.Parameter.Classes.ExternalParameterDefinition).externalParameterDefinition'></a>

`externalParameterDefinition` [ExternalParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ExternalParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ExternalParameterDefinition')

The ExternalParameterDefinition to copy\.

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.ExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string)'></a>

## ExternalParameterDefinition\(Guid, string, string, AccessType, ParameterValue, AssociatedTypes, string\) Constructor

Creates a new instance of the ExternalParameterDefinition class with the specified parameters\.

```csharp
public ExternalParameterDefinition(System.Guid guid, string? name, string? description, DiGi.Core.Parameter.Enums.AccessType accessType, DiGi.Core.Parameter.Classes.ParameterValue? parameterValue, DiGi.Core.Parameter.Classes.AssociatedTypes associatedTypes, string? groupName);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.ExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier\.

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.ExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name\.

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.ExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description\.

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.ExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string).accessType'></a>

`accessType` [AccessType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.AccessType 'DiGi\.Core\.Parameter\.Enums\.AccessType')

The access type\.

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.ExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string).parameterValue'></a>

`parameterValue` [ParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterValue 'DiGi\.Core\.Parameter\.Classes\.ParameterValue')

The parameter value\.

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.ExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string).associatedTypes'></a>

`associatedTypes` [AssociatedTypes](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.AssociatedTypes 'DiGi\.Core\.Parameter\.Classes\.AssociatedTypes')

The associated types\.

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.ExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string).groupName'></a>

`groupName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The group name\.

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.ExternalParameterDefinition(System.Text.Json.Nodes.JsonObject)'></a>

## ExternalParameterDefinition\(JsonObject\) Constructor

Creates a new instance of the ExternalParameterDefinition class from a JSON object\.

```csharp
public ExternalParameterDefinition(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.ExternalParameterDefinition(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the external parameter definition data\.
### Properties

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.AccessType'></a>

## ExternalParameterDefinition\.AccessType Property

Gets the access type of the external parameter definition\.

```csharp
public override DiGi.Core.Parameter.Enums.AccessType AccessType { get; }
```

#### Property Value
[AccessType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.AccessType 'DiGi\.Core\.Parameter\.Enums\.AccessType')

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.AssociatedTypes'></a>

## ExternalParameterDefinition\.AssociatedTypes Property

Gets the associated types of the external parameter definition\.

```csharp
public override DiGi.Core.Parameter.Classes.AssociatedTypes? AssociatedTypes { get; }
```

#### Property Value
[AssociatedTypes](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.AssociatedTypes 'DiGi\.Core\.Parameter\.Classes\.AssociatedTypes')

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.Description'></a>

## ExternalParameterDefinition\.Description Property

Gets the description of the external parameter definition\.

```csharp
public override string? Description { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.GroupName'></a>

## ExternalParameterDefinition\.GroupName Property

Gets the group name of the external parameter definition\.

```csharp
public override string? GroupName { get; }
```

Implements [GroupName](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition.GroupName 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\.GroupName')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.Name'></a>

## ExternalParameterDefinition\.Name Property

Gets the name of the external parameter definition\.

```csharp
public override string? Name { get; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.ParameterValue'></a>

## ExternalParameterDefinition\.ParameterValue Property

Gets the parameter value of the external parameter definition\.

```csharp
public override DiGi.Core.Parameter.Classes.ParameterValue? ParameterValue { get; }
```

#### Property Value
[ParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterValue 'DiGi\.Core\.Parameter\.Classes\.ParameterValue')

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.UniqueId'></a>

## ExternalParameterDefinition\.UniqueId Property

Gets the unique identifier of the external parameter definition\.

```csharp
public override string UniqueId { get; }
```

Implements [UniqueId](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition.UniqueId 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\.UniqueId')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.IsValid(object)'></a>

## ExternalParameterDefinition\.IsValid\(object\) Method

Determines whether the specified value is valid for this external parameter definition\.

```csharp
public override bool IsValid(object? value);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ExternalParameterDefinition.IsValid(object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to validate\.

Implements [IsValid\(object\)](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition.IsValid(object) 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\.IsValid\(object\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value is valid, false otherwise\.

<a name='DiGi.Core.Parameter.Classes.GetValueSettings'></a>

## GetValueSettings Class

Contains settings for retrieving a parameter value\.

```csharp
public class GetValueSettings
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → GetValueSettings
### Constructors

<a name='DiGi.Core.Parameter.Classes.GetValueSettings.GetValueSettings()'></a>

## GetValueSettings\(\) Constructor

Initializes a new instance of the GetValueSettings class\.

```csharp
public GetValueSettings();
```

<a name='DiGi.Core.Parameter.Classes.GetValueSettings.GetValueSettings(bool,bool)'></a>

## GetValueSettings\(bool, bool\) Constructor

Initializes a new instance of the GetValueSettings class with specified options\.

```csharp
public GetValueSettings(bool tryConvert, bool checkAccessType);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.GetValueSettings.GetValueSettings(bool,bool).tryConvert'></a>

`tryConvert` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to attempt conversion if types do not match\.

<a name='DiGi.Core.Parameter.Classes.GetValueSettings.GetValueSettings(bool,bool).checkAccessType'></a>

`checkAccessType` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to check for read access permissions\.
### Properties

<a name='DiGi.Core.Parameter.Classes.GetValueSettings.CheckAccessType'></a>

## GetValueSettings\.CheckAccessType Property

Gets or sets a value indicating whether the access type should be checked during retrieval\.

```csharp
public bool CheckAccessType { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Parameter.Classes.GetValueSettings.TryConvert'></a>

## GetValueSettings\.TryConvert Property

Gets or sets a value indicating whether to attempt conversion of the value during retrieval\.

```csharp
public bool TryConvert { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Parameter.Classes.GuidParameterValue'></a>

## GuidParameterValue Class

Represents a GUID value for a parameter\.

```csharp
public class GuidParameterValue : DiGi.Core.Parameter.Classes.ParameterValue
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → [ParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterValue 'DiGi\.Core\.Parameter\.Classes\.ParameterValue') → GuidParameterValue
### Constructors

<a name='DiGi.Core.Parameter.Classes.GuidParameterValue.GuidParameterValue()'></a>

## GuidParameterValue\(\) Constructor

Initializes a new instance of the [GuidParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GuidParameterValue 'DiGi\.Core\.Parameter\.Classes\.GuidParameterValue') class\.

```csharp
public GuidParameterValue();
```

<a name='DiGi.Core.Parameter.Classes.GuidParameterValue.GuidParameterValue(bool)'></a>

## GuidParameterValue\(bool\) Constructor

Initializes a new instance of the [GuidParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GuidParameterValue 'DiGi\.Core\.Parameter\.Classes\.GuidParameterValue') class with specified nullability\.

```csharp
public GuidParameterValue(bool nullable);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.GuidParameterValue.GuidParameterValue(bool).nullable'></a>

`nullable` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the parameter is nullable\.

<a name='DiGi.Core.Parameter.Classes.GuidParameterValue.GuidParameterValue(DiGi.Core.Parameter.Classes.GuidParameterValue)'></a>

## GuidParameterValue\(GuidParameterValue\) Constructor

Initializes a new instance of the [GuidParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GuidParameterValue 'DiGi\.Core\.Parameter\.Classes\.GuidParameterValue') class by copying an existing value\.

```csharp
public GuidParameterValue(DiGi.Core.Parameter.Classes.GuidParameterValue? guidParameterValue);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.GuidParameterValue.GuidParameterValue(DiGi.Core.Parameter.Classes.GuidParameterValue).guidParameterValue'></a>

`guidParameterValue` [GuidParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GuidParameterValue 'DiGi\.Core\.Parameter\.Classes\.GuidParameterValue')

The existing value to copy\.

<a name='DiGi.Core.Parameter.Classes.GuidParameterValue.GuidParameterValue(System.Text.Json.Nodes.JsonObject)'></a>

## GuidParameterValue\(JsonObject\) Constructor

Initializes a new instance of the [GuidParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GuidParameterValue 'DiGi\.Core\.Parameter\.Classes\.GuidParameterValue') class from a JSON object\.

```csharp
public GuidParameterValue(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.GuidParameterValue.GuidParameterValue(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.
### Properties

<a name='DiGi.Core.Parameter.Classes.GuidParameterValue.ParameterType'></a>

## GuidParameterValue\.ParameterType Property

Gets the type of the parameter, which is Integer\.

```csharp
public override DiGi.Core.Parameter.Enums.ParameterType ParameterType { get; }
```

#### Property Value
[ParameterType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.ParameterType 'DiGi\.Core\.Parameter\.Enums\.ParameterType')
### Methods

<a name='DiGi.Core.Parameter.Classes.GuidParameterValue.Clone()'></a>

## GuidParameterValue\.Clone\(\) Method

Creates a shallow copy of the current integer parameter value\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A shallow copy of the current object\.

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue'></a>

## IntegerParameterValue Class

Represents an integer value for a parameter\.

```csharp
public class IntegerParameterValue : DiGi.Core.Parameter.Classes.ParameterValue
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → [ParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterValue 'DiGi\.Core\.Parameter\.Classes\.ParameterValue') → IntegerParameterValue
### Constructors

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.IntegerParameterValue()'></a>

## IntegerParameterValue\(\) Constructor

Initializes a new instance of the [IntegerParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.IntegerParameterValue 'DiGi\.Core\.Parameter\.Classes\.IntegerParameterValue') class\.

```csharp
public IntegerParameterValue();
```

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.IntegerParameterValue(bool)'></a>

## IntegerParameterValue\(bool\) Constructor

Initializes a new instance of the [IntegerParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.IntegerParameterValue 'DiGi\.Core\.Parameter\.Classes\.IntegerParameterValue') class with specified nullability\.

```csharp
public IntegerParameterValue(bool nullable);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.IntegerParameterValue(bool).nullable'></a>

`nullable` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether the value can be null\.

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.IntegerParameterValue(bool,int,int)'></a>

## IntegerParameterValue\(bool, int, int\) Constructor

Initializes a new instance of the [IntegerParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.IntegerParameterValue 'DiGi\.Core\.Parameter\.Classes\.IntegerParameterValue') class with specified nullability and range\.

```csharp
public IntegerParameterValue(bool nullable, int min, int max);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.IntegerParameterValue(bool,int,int).nullable'></a>

`nullable` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether the value can be null\.

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.IntegerParameterValue(bool,int,int).min'></a>

`min` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The minimum value for the parameter\.

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.IntegerParameterValue(bool,int,int).max'></a>

`max` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum value for the parameter\.

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.IntegerParameterValue(DiGi.Core.Parameter.Classes.IntegerParameterValue)'></a>

## IntegerParameterValue\(IntegerParameterValue\) Constructor

Initializes a new instance of the [IntegerParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.IntegerParameterValue 'DiGi\.Core\.Parameter\.Classes\.IntegerParameterValue') class by copying an existing value\.

```csharp
public IntegerParameterValue(DiGi.Core.Parameter.Classes.IntegerParameterValue? integerParameterValue);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.IntegerParameterValue(DiGi.Core.Parameter.Classes.IntegerParameterValue).integerParameterValue'></a>

`integerParameterValue` [IntegerParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.IntegerParameterValue 'DiGi\.Core\.Parameter\.Classes\.IntegerParameterValue')

The existing integer parameter value to copy\.

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.IntegerParameterValue(int)'></a>

## IntegerParameterValue\(int\) Constructor

Initializes a new instance of the [IntegerParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.IntegerParameterValue 'DiGi\.Core\.Parameter\.Classes\.IntegerParameterValue') class with a minimum value\.

```csharp
public IntegerParameterValue(int min);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.IntegerParameterValue(int).min'></a>

`min` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The minimum value for the parameter\.

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.IntegerParameterValue(int,int)'></a>

## IntegerParameterValue\(int, int\) Constructor

Initializes a new instance of the [IntegerParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.IntegerParameterValue 'DiGi\.Core\.Parameter\.Classes\.IntegerParameterValue') class with a specified range\.

```csharp
public IntegerParameterValue(int min, int max);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.IntegerParameterValue(int,int).min'></a>

`min` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The minimum value for the parameter\.

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.IntegerParameterValue(int,int).max'></a>

`max` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum value for the parameter\.

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.IntegerParameterValue(System.Text.Json.Nodes.JsonObject)'></a>

## IntegerParameterValue\(JsonObject\) Constructor

Initializes a new instance of the [IntegerParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.IntegerParameterValue 'DiGi\.Core\.Parameter\.Classes\.IntegerParameterValue') class from a JSON object\.

```csharp
public IntegerParameterValue(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.IntegerParameterValue(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the value from\.
### Properties

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.ParameterType'></a>

## IntegerParameterValue\.ParameterType Property

Gets the type of the parameter, which is Integer\.

```csharp
public override DiGi.Core.Parameter.Enums.ParameterType ParameterType { get; }
```

#### Property Value
[ParameterType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.ParameterType 'DiGi\.Core\.Parameter\.Enums\.ParameterType')
### Methods

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.Clone()'></a>

## IntegerParameterValue\.Clone\(\) Method

Creates a shallow copy of the current integer parameter value\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A shallow copy of the current object\.

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.IsValid(object)'></a>

## IntegerParameterValue\.IsValid\(object\) Method

Determines whether the specified value is a valid integer parameter value\.

```csharp
public override bool IsValid(object? value);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.IsValid(object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to validate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value is valid; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.TryConvert(object,object)'></a>

## IntegerParameterValue\.TryConvert\(object, object\) Method

Attempts to convert the specified input value to an integer parameter value\.

```csharp
public override bool TryConvert(object? value_In, out object? value_Out);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.TryConvert(object,object).value_In'></a>

`value_In` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The input value to convert\.

<a name='DiGi.Core.Parameter.Classes.IntegerParameterValue.TryConvert(object,object).value_Out'></a>

`value_Out` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the converted value if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ObjectParameterValue'></a>

## ObjectParameterValue Class

Represents a parameter value that can hold an object of one or more specified types\.

```csharp
public class ObjectParameterValue : DiGi.Core.Parameter.Classes.ParameterValue
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → [ParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterValue 'DiGi\.Core\.Parameter\.Classes\.ParameterValue') → ObjectParameterValue
### Constructors

<a name='DiGi.Core.Parameter.Classes.ObjectParameterValue.ObjectParameterValue()'></a>

## ObjectParameterValue\(\) Constructor

Initializes a new instance of the [ObjectParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ObjectParameterValue 'DiGi\.Core\.Parameter\.Classes\.ObjectParameterValue') class\.

```csharp
public ObjectParameterValue();
```

<a name='DiGi.Core.Parameter.Classes.ObjectParameterValue.ObjectParameterValue(bool,bool,System.Type[])'></a>

## ObjectParameterValue\(bool, bool, Type\[\]\) Constructor

Initializes a new instance of the [ObjectParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ObjectParameterValue 'DiGi\.Core\.Parameter\.Classes\.ObjectParameterValue') class with specified nullability, inheritance rules, and allowed types\.

```csharp
public ObjectParameterValue(bool nullable, bool inheritance, params System.Type[] types);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ObjectParameterValue.ObjectParameterValue(bool,bool,System.Type[]).nullable'></a>

`nullable` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Specifies whether the value can be null\.

<a name='DiGi.Core.Parameter.Classes.ObjectParameterValue.ObjectParameterValue(bool,bool,System.Type[]).inheritance'></a>

`inheritance` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Specifies whether inheritance is considered when validating types\.

<a name='DiGi.Core.Parameter.Classes.ObjectParameterValue.ObjectParameterValue(bool,bool,System.Type[]).types'></a>

`types` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The collection of allowed types for this parameter value\.

<a name='DiGi.Core.Parameter.Classes.ObjectParameterValue.ObjectParameterValue(DiGi.Core.Parameter.Classes.ObjectParameterValue)'></a>

## ObjectParameterValue\(ObjectParameterValue\) Constructor

Initializes a new instance of the [ObjectParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ObjectParameterValue 'DiGi\.Core\.Parameter\.Classes\.ObjectParameterValue') class by copying an existing instance\.

```csharp
public ObjectParameterValue(DiGi.Core.Parameter.Classes.ObjectParameterValue? objectParameterValue);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ObjectParameterValue.ObjectParameterValue(DiGi.Core.Parameter.Classes.ObjectParameterValue).objectParameterValue'></a>

`objectParameterValue` [ObjectParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ObjectParameterValue 'DiGi\.Core\.Parameter\.Classes\.ObjectParameterValue')

The existing instance to copy\.

<a name='DiGi.Core.Parameter.Classes.ObjectParameterValue.ObjectParameterValue(System.Text.Json.Nodes.JsonObject)'></a>

## ObjectParameterValue\(JsonObject\) Constructor

Initializes a new instance of the [ObjectParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ObjectParameterValue 'DiGi\.Core\.Parameter\.Classes\.ObjectParameterValue') class from a JSON object\.

```csharp
public ObjectParameterValue(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ObjectParameterValue.ObjectParameterValue(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the current instance with\.
### Properties

<a name='DiGi.Core.Parameter.Classes.ObjectParameterValue.ParameterType'></a>

## ObjectParameterValue\.ParameterType Property

Gets the parameter type associated with this string parameter value\.

```csharp
public override DiGi.Core.Parameter.Enums.ParameterType ParameterType { get; }
```

#### Property Value
[ParameterType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.ParameterType 'DiGi\.Core\.Parameter\.Enums\.ParameterType')
### Methods

<a name='DiGi.Core.Parameter.Classes.ObjectParameterValue.Clone()'></a>

## ObjectParameterValue\.Clone\(\) Method

Creates a clone of the current string parameter value\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new instance of [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a copy of the current object\.

<a name='DiGi.Core.Parameter.Classes.ObjectParameterValue.IsValid(object)'></a>

## ObjectParameterValue\.IsValid\(object\) Method

Determines whether the specified value is valid for this parameter\.

```csharp
public override bool IsValid(object? value);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ObjectParameterValue.IsValid(object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to validate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value is valid; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ObjectParameterValue.TryConvert(object,object)'></a>

## ObjectParameterValue\.TryConvert\(object, object\) Method

Attempts to convert the specified input value to a compatible output value\.

```csharp
public override bool TryConvert(object? value_In, out object? value_Out);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ObjectParameterValue.TryConvert(object,object).value_In'></a>

`value_In` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The input value to be converted\.

<a name='DiGi.Core.Parameter.Classes.ObjectParameterValue.TryConvert(object,object).value_Out'></a>

`value_Out` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the converted value if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.Parameter'></a>

## Parameter Class

Represents a parameter with a definition and a value\.

```csharp
public class Parameter : DiGi.Core.Classes.SerializableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Parameter
### Constructors

<a name='DiGi.Core.Parameter.Classes.Parameter.Parameter(DiGi.Core.Parameter.Classes.Parameter)'></a>

## Parameter\(Parameter\) Constructor

Creates a new instance of the Parameter class by copying another Parameter\.

```csharp
public Parameter(DiGi.Core.Parameter.Classes.Parameter? parameter);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.Parameter.Parameter(DiGi.Core.Parameter.Classes.Parameter).parameter'></a>

`parameter` [Parameter](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.Parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')

The Parameter to copy\.

<a name='DiGi.Core.Parameter.Classes.Parameter.Parameter(DiGi.Core.Parameter.Interfaces.IParameterDefinition)'></a>

## Parameter\(IParameterDefinition\) Constructor

Creates a new instance of the Parameter class with the specified parameter definition\.

```csharp
internal Parameter(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.Parameter.Parameter(DiGi.Core.Parameter.Interfaces.IParameterDefinition).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition\.

<a name='DiGi.Core.Parameter.Classes.Parameter.Parameter(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object)'></a>

## Parameter\(IParameterDefinition, object\) Constructor

Creates a new instance of the Parameter class with the specified parameter definition and value\.

```csharp
internal Parameter(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition, object? value);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.Parameter.Parameter(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition\.

<a name='DiGi.Core.Parameter.Classes.Parameter.Parameter(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The parameter value\.

<a name='DiGi.Core.Parameter.Classes.Parameter.Parameter(System.Text.Json.Nodes.JsonObject)'></a>

## Parameter\(JsonObject\) Constructor

Creates a new instance of the Parameter class from a JSON object\.

```csharp
public Parameter(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.Parameter.Parameter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the parameter data\.
### Properties

<a name='DiGi.Core.Parameter.Classes.Parameter.Name'></a>

## Parameter\.Name Property

Gets the name of the parameter\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Parameter.Classes.Parameter.ParameterDefinition'></a>

## Parameter\.ParameterDefinition Property

Gets the parameter definition\.

```csharp
public DiGi.Core.Parameter.Interfaces.IParameterDefinition? ParameterDefinition { get; }
```

#### Property Value
[IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

<a name='DiGi.Core.Parameter.Classes.Parameter.ParameterType'></a>

## Parameter\.ParameterType Property

Gets the type of the parameter\.

```csharp
public DiGi.Core.Parameter.Enums.ParameterType ParameterType { get; }
```

#### Property Value
[ParameterType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.ParameterType 'DiGi\.Core\.Parameter\.Enums\.ParameterType')

<a name='DiGi.Core.Parameter.Classes.Parameter.UniqueId'></a>

## Parameter\.UniqueId Property

Gets the unique identifier of the parameter\.

```csharp
public string? UniqueId { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Parameter.Classes.Parameter.Value'></a>

## Parameter\.Value Property

Gets the value of the parameter\.

```csharp
public object? Value { get; }
```

#### Property Value
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')
### Methods

<a name='DiGi.Core.Parameter.Classes.Parameter.Clone()'></a>

## Parameter\.Clone\(\) Method

Creates a deep copy of the Parameter\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new cloned instance of the Parameter\.

<a name='DiGi.Core.Parameter.Classes.Parameter.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## Parameter\.GetValue\<T\>\(GetValueSettings\) Method

Gets the value of the parameter, converted to the specified type\.

```csharp
public T? GetValue<T>(DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.Parameter.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type to convert the value to\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.Parameter.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings for retrieving the value\.

#### Returns
[T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.Parameter.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.Parameter\.GetValue\<T\>\(DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')  
The converted value, or default if conversion fails\.

<a name='DiGi.Core.Parameter.Classes.Parameter.SetValue(object,DiGi.Core.Parameter.Classes.SetValueSettings)'></a>

## Parameter\.SetValue\(object, SetValueSettings\) Method

Sets the value of the parameter\.

```csharp
public bool SetValue(object? value, DiGi.Core.Parameter.Classes.SetValueSettings? setValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.Parameter.SetValue(object,DiGi.Core.Parameter.Classes.SetValueSettings).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to set\.

<a name='DiGi.Core.Parameter.Classes.Parameter.SetValue(object,DiGi.Core.Parameter.Classes.SetValueSettings).setValueSettings'></a>

`setValueSettings` [SetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.SetValueSettings 'DiGi\.Core\.Parameter\.Classes\.SetValueSettings')

Optional settings for setting the value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully set, false otherwise\.

<a name='DiGi.Core.Parameter.Classes.Parameter.TryGetValue_T_(T,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## Parameter\.TryGetValue\<T\>\(T, GetValueSettings\) Method

Tries to get the value of the parameter, converted to the specified type\.

```csharp
public bool TryGetValue<T>(out T? value, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.Parameter.TryGetValue_T_(T,DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type to convert the value to\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.Parameter.TryGetValue_T_(T,DiGi.Core.Parameter.Classes.GetValueSettings).value'></a>

`value` [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.Parameter.TryGetValue_T_(T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.Parameter\.TryGetValue\<T\>\(T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')

The converted value, or default if conversion fails\.

<a name='DiGi.Core.Parameter.Classes.Parameter.TryGetValue_T_(T,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings for retrieving the value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully retrieved, false otherwise\.

<a name='DiGi.Core.Parameter.Classes.ParameterDefinition'></a>

## ParameterDefinition Class

Provides a base class for defining parameters\.

```csharp
public abstract class ParameterDefinition : DiGi.Core.Classes.SerializableObject, DiGi.Core.Parameter.Interfaces.IParameterDefinition, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, System.IEquatable<DiGi.Core.Parameter.Interfaces.IParameterDefinition>, DiGi.Core.Interfaces.INamedObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → ParameterDefinition

Derived  
↳ [ComplexParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ComplexParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ComplexParameterDefinition')  
↳ [SimpleParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.SimpleParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.SimpleParameterDefinition')

Implements [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject')
### Constructors

<a name='DiGi.Core.Parameter.Classes.ParameterDefinition.ParameterDefinition()'></a>

## ParameterDefinition\(\) Constructor

Initializes a new instance of the [ParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ParameterDefinition') class\.

```csharp
public ParameterDefinition();
```

<a name='DiGi.Core.Parameter.Classes.ParameterDefinition.ParameterDefinition(DiGi.Core.Parameter.Classes.ParameterDefinition)'></a>

## ParameterDefinition\(ParameterDefinition\) Constructor

Initializes a new instance of the [ParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ParameterDefinition') class by copying an existing definition\.

```csharp
public ParameterDefinition(DiGi.Core.Parameter.Classes.ParameterDefinition? parameterDefinition);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterDefinition.ParameterDefinition(DiGi.Core.Parameter.Classes.ParameterDefinition).parameterDefinition'></a>

`parameterDefinition` [ParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ParameterDefinition')

The parameter definition to copy from\.

<a name='DiGi.Core.Parameter.Classes.ParameterDefinition.ParameterDefinition(System.Text.Json.Nodes.JsonObject)'></a>

## ParameterDefinition\(JsonObject\) Constructor

Initializes a new instance of the [ParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ParameterDefinition') class from a JSON object\.

```csharp
public ParameterDefinition(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterDefinition.ParameterDefinition(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the definition from\.
### Properties

<a name='DiGi.Core.Parameter.Classes.ParameterDefinition.GroupName'></a>

## ParameterDefinition\.GroupName Property

Gets the group name to which the parameter belongs\.

```csharp
public abstract string? GroupName { get; }
```

Implements [GroupName](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition.GroupName 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\.GroupName')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Parameter.Classes.ParameterDefinition.Name'></a>

## ParameterDefinition\.Name Property

Gets or sets the name of the parameter\.

```csharp
public abstract string? Name { get; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Parameter.Classes.ParameterDefinition.ParameterType'></a>

## ParameterDefinition\.ParameterType Property

Gets the type of the parameter\.

```csharp
public abstract DiGi.Core.Parameter.Enums.ParameterType ParameterType { get; }
```

Implements [ParameterType](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition.ParameterType 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\.ParameterType')

#### Property Value
[ParameterType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.ParameterType 'DiGi\.Core\.Parameter\.Enums\.ParameterType')

<a name='DiGi.Core.Parameter.Classes.ParameterDefinition.UniqueId'></a>

## ParameterDefinition\.UniqueId Property

Gets or sets the unique identifier for the parameter\.

```csharp
public abstract string? UniqueId { get; }
```

Implements [UniqueId](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition.UniqueId 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\.UniqueId')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Core.Parameter.Classes.ParameterDefinition.Equals(DiGi.Core.Parameter.Interfaces.IParameterDefinition)'></a>

## ParameterDefinition\.Equals\(IParameterDefinition\) Method

Determines whether the specified parameter definition is equal to the current instance\.

```csharp
public bool Equals(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterDefinition.Equals(DiGi.Core.Parameter.Interfaces.IParameterDefinition).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition to compare with the current instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified parameter definition is equal to the current instance; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterDefinition.IsValid(object)'></a>

## ParameterDefinition\.IsValid\(object\) Method

Validates whether the provided value is valid for this parameter definition\.

```csharp
public virtual bool IsValid(object? value);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterDefinition.IsValid(object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to validate\.

Implements [IsValid\(object\)](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition.IsValid(object) 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\.IsValid\(object\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value is valid; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup'></a>

## ParameterGroup Class

Represents a group of parameters\.

```csharp
public class ParameterGroup : DiGi.Core.Classes.SerializableObject, System.Collections.Generic.IEnumerable<DiGi.Core.Parameter.Classes.Parameter>, System.Collections.IEnumerable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → ParameterGroup

Implements [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Parameter](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.Parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')
### Constructors

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.ParameterGroup(DiGi.Core.Parameter.Classes.ParameterGroup)'></a>

## ParameterGroup\(ParameterGroup\) Constructor

Initializes a new instance of the [ParameterGroup](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup') class by copying another group\.

```csharp
public ParameterGroup(DiGi.Core.Parameter.Classes.ParameterGroup? parameterGroup);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.ParameterGroup(DiGi.Core.Parameter.Classes.ParameterGroup).parameterGroup'></a>

`parameterGroup` [ParameterGroup](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup')

The parameter group to copy from\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.ParameterGroup(string)'></a>

## ParameterGroup\(string\) Constructor

Initializes a new instance of the [ParameterGroup](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup') class with a specified name\.

```csharp
public ParameterGroup(string? name);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.ParameterGroup(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter group\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.ParameterGroup(string,System.Collections.Generic.IEnumerable_DiGi.Core.Parameter.Classes.Parameter_)'></a>

## ParameterGroup\(string, IEnumerable\<Parameter\>\) Constructor

Initializes a new instance of the [ParameterGroup](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup') class with a specified name and a collection of parameters\.

```csharp
public ParameterGroup(string? name, System.Collections.Generic.IEnumerable<DiGi.Core.Parameter.Classes.Parameter>? parameters);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.ParameterGroup(string,System.Collections.Generic.IEnumerable_DiGi.Core.Parameter.Classes.Parameter_).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter group\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.ParameterGroup(string,System.Collections.Generic.IEnumerable_DiGi.Core.Parameter.Classes.Parameter_).parameters'></a>

`parameters` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Parameter](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.Parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of parameters to include in the group\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.ParameterGroup(System.Text.Json.Nodes.JsonObject)'></a>

## ParameterGroup\(JsonObject\) Constructor

Initializes a new instance of the [ParameterGroup](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup') class from a JSON object\.

```csharp
public ParameterGroup(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.ParameterGroup(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the group from\.
### Properties

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.Name'></a>

## ParameterGroup\.Name Property

Gets or sets the display name of the parameter\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.Clone()'></a>

## ParameterGroup\.Clone\(\) Method

Creates a deep copy of the current parameter group\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A deep copy of the current parameter group\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.Contains(DiGi.Core.Parameter.Interfaces.IParameterDefinition)'></a>

## ParameterGroup\.Contains\(IParameterDefinition\) Method

Determines whether any group in the collection contains a parameter matching the specified definition\.

```csharp
public bool Contains(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.Contains(DiGi.Core.Parameter.Interfaces.IParameterDefinition).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition to search for\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the collection contains a parameter matching the specified definition; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.Contains(string)'></a>

## ParameterGroup\.Contains\(string\) Method

Determines whether any group in the collection contains a parameter with the specified unique identifier\.

```csharp
public bool Contains(string? uniqueId);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.Contains(string).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the parameter to search for\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the collection contains a parameter with the specified unique identifier; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.Contains(System.Enum)'></a>

## ParameterGroup\.Contains\(Enum\) Method

Determines whether the group contains a parameter corresponding to the specified enumeration member\.

```csharp
public bool Contains(System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.Contains(System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration member to search for\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the group contains a parameter corresponding to the specified enumeration member; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetEnumerator()'></a>

## ParameterGroup\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the parameters in the group\.

```csharp
public System.Collections.Generic.IEnumerator<DiGi.Core.Parameter.Classes.Parameter> GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator 'System\.Collections\.Generic\.IEnumerable\`1\.GetEnumerator'), [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

#### Returns
[System\.Collections\.Generic\.IEnumerator&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')[Parameter](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.Parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')  
An enumerator that iterates through the parameters in the group\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetParameterDefinitions(string,DiGi.Core.Enums.TextComparisonType,bool)'></a>

## ParameterGroup\.GetParameterDefinitions\(string, TextComparisonType, bool\) Method

Retrieves a list of parameter definitions that match the specified name and comparison criteria\.

```csharp
public System.Collections.Generic.List<DiGi.Core.Parameter.Interfaces.IParameterDefinition>? GetParameterDefinitions(string? name, DiGi.Core.Enums.TextComparisonType textComparisonType=DiGi.Core.Enums.TextComparisonType.Equals, bool caseSensitive=true);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetParameterDefinitions(string,DiGi.Core.Enums.TextComparisonType,bool).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameters to search for\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetParameterDefinitions(string,DiGi.Core.Enums.TextComparisonType,bool).textComparisonType'></a>

`textComparisonType` [DiGi\.Core\.Enums\.TextComparisonType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.textcomparisontype 'DiGi\.Core\.Enums\.TextComparisonType')

The type of text comparison to use when matching the name\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetParameterDefinitions(string,DiGi.Core.Enums.TextComparisonType,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the name comparison is case\-sensitive\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of parameter definitions that match the specified criteria, or null if no matches are found\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetParameterDefinitions_T_(string,DiGi.Core.Enums.TextComparisonType,bool)'></a>

## ParameterGroup\.GetParameterDefinitions\<T\>\(string, TextComparisonType, bool\) Method

Retrieves a list of parameter definitions of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup.GetParameterDefinitions_T_(string,DiGi.Core.Enums.TextComparisonType,bool).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup\.GetParameterDefinitions\<T\>\(string, DiGi\.Core\.Enums\.TextComparisonType, bool\)\.T') that match the specified name and comparison criteria\.

```csharp
public System.Collections.Generic.List<T>? GetParameterDefinitions<T>(string? name, DiGi.Core.Enums.TextComparisonType textComparisonType=DiGi.Core.Enums.TextComparisonType.Equals, bool caseSensitive=true)
    where T : DiGi.Core.Parameter.Interfaces.IParameterDefinition;
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetParameterDefinitions_T_(string,DiGi.Core.Enums.TextComparisonType,bool).T'></a>

`T`

The type of parameter definitions to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetParameterDefinitions_T_(string,DiGi.Core.Enums.TextComparisonType,bool).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameters to search for\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetParameterDefinitions_T_(string,DiGi.Core.Enums.TextComparisonType,bool).textComparisonType'></a>

`textComparisonType` [DiGi\.Core\.Enums\.TextComparisonType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.textcomparisontype 'DiGi\.Core\.Enums\.TextComparisonType')

The type of text comparison to use when matching the name\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetParameterDefinitions_T_(string,DiGi.Core.Enums.TextComparisonType,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the name comparison is case\-sensitive\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup.GetParameterDefinitions_T_(string,DiGi.Core.Enums.TextComparisonType,bool).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup\.GetParameterDefinitions\<T\>\(string, DiGi\.Core\.Enums\.TextComparisonType, bool\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of parameter definitions of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup.GetParameterDefinitions_T_(string,DiGi.Core.Enums.TextComparisonType,bool).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup\.GetParameterDefinitions\<T\>\(string, DiGi\.Core\.Enums\.TextComparisonType, bool\)\.T') that match the specified criteria, or null if no matches are found\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetParameterDefinitions_TParameterDefinition_()'></a>

## ParameterGroup\.GetParameterDefinitions\<TParameterDefinition\>\(\) Method

Retrieves a list of parameter definitions of the specified type within the group\.

```csharp
public System.Collections.Generic.List<TParameterDefinition>? GetParameterDefinitions<TParameterDefinition>()
    where TParameterDefinition : DiGi.Core.Parameter.Interfaces.IParameterDefinition;
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetParameterDefinitions_TParameterDefinition_().TParameterDefinition'></a>

`TParameterDefinition`

The type of parameter definition to retrieve\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup.GetParameterDefinitions_TParameterDefinition_().TParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup\.GetParameterDefinitions\<TParameterDefinition\>\(\)\.TParameterDefinition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of parameter definitions of the specified type, or null if none are found\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParameterGroup\.GetValue\(IParameterDefinition, GetValueSettings\) Method

Gets the value associated with the specified parameter definition from the collection\.

```csharp
public object? GetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition to retrieve the value for\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings for retrieving the value\.

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')  
The value associated with the specified parameter definition, or null if not found\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetValue(string,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParameterGroup\.GetValue\(string, GetValueSettings\) Method

Gets the value associated with the specified unique identifier from the collection\.

```csharp
public object? GetValue(string? uniqueId, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetValue(string,DiGi.Core.Parameter.Classes.GetValueSettings).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the value to get\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetValue(string,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings for retrieving the value\.

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')  
The value associated with the specified unique identifier, or null if not found\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParameterGroup\.GetValue\<T\>\(IParameterDefinition, GetValueSettings\) Method

Gets the value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup\.GetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') associated with the specified parameter definition from the collection\.

```csharp
public T? GetValue<T>(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The definition of the parameter whose value is to be retrieved\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to control how the value is retrieved\.

#### Returns
[T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup\.GetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')  
The value associated with the specified parameter definition, or the default value for type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup\.GetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') if not found\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetValue_T_(string,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParameterGroup\.GetValue\<T\>\(string, GetValueSettings\) Method

Gets the value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup.GetValue_T_(string,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup\.GetValue\<T\>\(string, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') associated with the specified unique identifier\.

```csharp
public T? GetValue<T>(string? uniqueId, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetValue_T_(string,DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetValue_T_(string,DiGi.Core.Parameter.Classes.GetValueSettings).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the value to get\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.GetValue_T_(string,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings for retrieving the value\.

#### Returns
[T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup.GetValue_T_(string,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup\.GetValue\<T\>\(string, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')  
The value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup.GetValue_T_(string,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup\.GetValue\<T\>\(string, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') associated with the specified unique identifier, or null if not found\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.Remove(DiGi.Core.Parameter.Interfaces.IParameterDefinition)'></a>

## ParameterGroup\.Remove\(IParameterDefinition\) Method

Removes the parameter matching the specified definition from the collection\.

```csharp
public bool Remove(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.Remove(DiGi.Core.Parameter.Interfaces.IParameterDefinition).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The definition of the parameter to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the parameter was successfully removed; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.Remove(string)'></a>

## ParameterGroup\.Remove\(string\) Method

Removes the parameter with the specified unique identifier from the group\.

```csharp
public bool Remove(string uniqueId);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.Remove(string).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the parameter to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the parameter was successfully removed; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.SetValue(DiGi.Core.Parameter.Classes.Parameter)'></a>

## ParameterGroup\.SetValue\(Parameter\) Method

Adds or updates a parameter in the collection\.

```csharp
public bool SetValue(DiGi.Core.Parameter.Classes.Parameter? parameter);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.SetValue(DiGi.Core.Parameter.Classes.Parameter).parameter'></a>

`parameter` [Parameter](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.Parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')

The parameter to add or update\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the operation was successful; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings)'></a>

## ParameterGroup\.SetValue\(IParameterDefinition, object, SetValueSettings\) Method

Sets the value for the parameter matching the specified definition within the collection\.

```csharp
public bool SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition, object? value, DiGi.Core.Parameter.Classes.SetValueSettings? setValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The definition of the parameter to set\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to assign to the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings).setValueSettings'></a>

`setValueSettings` [SetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.SetValueSettings 'DiGi\.Core\.Parameter\.Classes\.SetValueSettings')

Optional settings to control how the value is set\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully set; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.SetValue(string,object,DiGi.Core.Parameter.Classes.SetValueSettings)'></a>

## ParameterGroup\.SetValue\(string, object, SetValueSettings\) Method

Sets the value for the parameter identified by the specified name within the collection\.

```csharp
public bool SetValue(string? name, object? value, DiGi.Core.Parameter.Classes.SetValueSettings? setValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.SetValue(string,object,DiGi.Core.Parameter.Classes.SetValueSettings).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter to set\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.SetValue(string,object,DiGi.Core.Parameter.Classes.SetValueSettings).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to assign to the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.SetValue(string,object,DiGi.Core.Parameter.Classes.SetValueSettings).setValueSettings'></a>

`setValueSettings` [SetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.SetValueSettings 'DiGi\.Core\.Parameter\.Classes\.SetValueSettings')

Optional settings to control how the value is set\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully set; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParameterGroup\.TryGetValue\(IParameterDefinition, object, GetValueSettings\) Method

Attempts to get the value associated with the specified parameter definition from the collection\.

```csharp
public bool TryGetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition, out object? value, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.GetValueSettings).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition for which to retrieve the value\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.GetValueSettings).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the retrieved value if found; otherwise, null\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to use when retrieving the value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully retrieved; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue(string,object,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParameterGroup\.TryGetValue\(string, object, GetValueSettings\) Method

Attempts to get the value associated with the specified unique identifier from the collection\.

```csharp
public bool TryGetValue(string? uniqueId, out object? value, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue(string,object,DiGi.Core.Parameter.Classes.GetValueSettings).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the parameter for which to retrieve the value\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue(string,object,DiGi.Core.Parameter.Classes.GetValueSettings).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the retrieved value if found; otherwise, null\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue(string,object,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to use when retrieving the value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully retrieved; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParameterGroup\.TryGetValue\<T\>\(IParameterDefinition, T, GetValueSettings\) Method

Attempts to get the value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup\.TryGetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') associated with the specified parameter definition from the collection\.

```csharp
public bool TryGetValue<T>(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition, out T? value, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition for which to retrieve the value\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).value'></a>

`value` [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup\.TryGetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')

When this method returns, contains the retrieved value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup\.TryGetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') if found; otherwise, the default value of [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup\.TryGetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to use when retrieving the value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully retrieved; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParameterGroup\.TryGetValue\<T\>\(string, T, GetValueSettings\) Method

Attempts to get the value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup\.TryGetValue\<T\>\(string, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') associated with the specified unique identifier from the collection\.

```csharp
public bool TryGetValue<T>(string? uniqueId, out T? value, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the parameter for which to retrieve the value\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).value'></a>

`value` [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup\.TryGetValue\<T\>\(string, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')

When this method returns, contains the retrieved value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup\.TryGetValue\<T\>\(string, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') if found; otherwise, the default value of [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup\.TryGetValue\<T\>\(string, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroup.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to use when retrieving the value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully retrieved; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection'></a>

## ParameterGroupCollection Class

Represents a collection of parameter groups\.

```csharp
public class ParameterGroupCollection : DiGi.Core.Classes.SerializableObject, System.Collections.Generic.IEnumerable<DiGi.Core.Parameter.Classes.ParameterGroup>, System.Collections.IEnumerable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → ParameterGroupCollection

Implements [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ParameterGroup](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')
### Constructors

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.ParameterGroupCollection()'></a>

## ParameterGroupCollection\(\) Constructor

Initializes a new instance of the [ParameterGroupCollection](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection') class\.

```csharp
public ParameterGroupCollection();
```

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.ParameterGroupCollection(DiGi.Core.Parameter.Classes.ParameterGroupCollection)'></a>

## ParameterGroupCollection\(ParameterGroupCollection\) Constructor

Initializes a new instance of the [ParameterGroupCollection](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection') class by copying another collection\.

```csharp
public ParameterGroupCollection(DiGi.Core.Parameter.Classes.ParameterGroupCollection? parameterGroupCollection);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.ParameterGroupCollection(DiGi.Core.Parameter.Classes.ParameterGroupCollection).parameterGroupCollection'></a>

`parameterGroupCollection` [ParameterGroupCollection](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection')

The parameter group collection to copy from\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.ParameterGroupCollection(System.Collections.Generic.IEnumerable_DiGi.Core.Parameter.Classes.Parameter_)'></a>

## ParameterGroupCollection\(IEnumerable\<Parameter\>\) Constructor

Initializes a new instance of the [ParameterGroupCollection](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection') class from a collection of parameters\.

```csharp
public ParameterGroupCollection(System.Collections.Generic.IEnumerable<DiGi.Core.Parameter.Classes.Parameter>? parameters);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.ParameterGroupCollection(System.Collections.Generic.IEnumerable_DiGi.Core.Parameter.Classes.Parameter_).parameters'></a>

`parameters` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Parameter](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.Parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of parameters to initialize the collection with\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.ParameterGroupCollection(System.Text.Json.Nodes.JsonObject)'></a>

## ParameterGroupCollection\(JsonObject\) Constructor

Initializes a new instance of the [ParameterGroupCollection](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection') class from a JSON object\.

```csharp
public ParameterGroupCollection(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.ParameterGroupCollection(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the collection from\.
### Properties

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.this[string]'></a>

## ParameterGroupCollection\.this\[string\] Property

Gets the parameter group associated with the specified name\.

```csharp
public DiGi.Core.Parameter.Classes.ParameterGroup? this[string? name] { get; }
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.this[string].name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter group to retrieve\.

#### Property Value
[ParameterGroup](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup')
### Methods

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.Clone()'></a>

## ParameterGroupCollection\.Clone\(\) Method

Creates a deep copy of the current parameter group collection\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A deep copy of the current parameter group collection\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.Contains(DiGi.Core.Parameter.Interfaces.IParameterDefinition)'></a>

## ParameterGroupCollection\.Contains\(IParameterDefinition\) Method

Determines whether any group in the collection contains a parameter matching the specified definition\.

```csharp
public bool Contains(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.Contains(DiGi.Core.Parameter.Interfaces.IParameterDefinition).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition to search for\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if any group in the collection contains a parameter matching the specified definition; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.Contains(string)'></a>

## ParameterGroupCollection\.Contains\(string\) Method

Determines whether any group in the collection contains a parameter with the specified unique identifier\.

```csharp
public bool Contains(string? uniqueId);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.Contains(string).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the parameter to search for\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if any group in the collection contains a parameter with the specified unique identifier; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.Contains(System.Enum)'></a>

## ParameterGroupCollection\.Contains\(Enum\) Method

Determines whether any group in the collection contains a parameter corresponding to the specified enumeration member\.

```csharp
public bool Contains(System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.Contains(System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration member to search for\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if any group in the collection contains a parameter corresponding to the specified enumeration member; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetEnumerator()'></a>

## ParameterGroupCollection\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the parameter groups in the collection\.

```csharp
public System.Collections.Generic.IEnumerator<DiGi.Core.Parameter.Classes.ParameterGroup> GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator 'System\.Collections\.Generic\.IEnumerable\`1\.GetEnumerator'), [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

#### Returns
[System\.Collections\.Generic\.IEnumerator&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')[ParameterGroup](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroup 'DiGi\.Core\.Parameter\.Classes\.ParameterGroup')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')  
An enumerator that iterates through the parameter groups in the collection\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetParameterDefinitions(string,DiGi.Core.Enums.TextComparisonType,bool)'></a>

## ParameterGroupCollection\.GetParameterDefinitions\(string, TextComparisonType, bool\) Method

Retrieves a list of parameter definitions that match the specified name and comparison criteria across all groups\.

```csharp
public System.Collections.Generic.List<DiGi.Core.Parameter.Interfaces.IParameterDefinition>? GetParameterDefinitions(string? parameterName, DiGi.Core.Enums.TextComparisonType textComparisonType=DiGi.Core.Enums.TextComparisonType.Equals, bool caseSensitive=true);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetParameterDefinitions(string,DiGi.Core.Enums.TextComparisonType,bool).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameters to search for\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetParameterDefinitions(string,DiGi.Core.Enums.TextComparisonType,bool).textComparisonType'></a>

`textComparisonType` [DiGi\.Core\.Enums\.TextComparisonType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.textcomparisontype 'DiGi\.Core\.Enums\.TextComparisonType')

The type of text comparison to use when matching the name\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetParameterDefinitions(string,DiGi.Core.Enums.TextComparisonType,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the comparison should be case\-sensitive\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of parameter definitions that match the criteria, or null if none are found\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetParameterDefinitions_TParameterDefinition_()'></a>

## ParameterGroupCollection\.GetParameterDefinitions\<TParameterDefinition\>\(\) Method

Retrieves a list of all parameter definitions of the specified type across all groups\.

```csharp
public System.Collections.Generic.List<TParameterDefinition> GetParameterDefinitions<TParameterDefinition>()
    where TParameterDefinition : DiGi.Core.Parameter.Interfaces.IParameterDefinition;
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetParameterDefinitions_TParameterDefinition_().TParameterDefinition'></a>

`TParameterDefinition`

The type of parameter definition to retrieve\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetParameterDefinitions_TParameterDefinition_().TParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection\.GetParameterDefinitions\<TParameterDefinition\>\(\)\.TParameterDefinition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing all parameter definitions of the specified type\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetParameterDefinitions_TParameterDefinition_(string,DiGi.Core.Enums.TextComparisonType,bool)'></a>

## ParameterGroupCollection\.GetParameterDefinitions\<TParameterDefinition\>\(string, TextComparisonType, bool\) Method

Retrieves a list of parameter definitions of type [TParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetParameterDefinitions_TParameterDefinition_(string,DiGi.Core.Enums.TextComparisonType,bool).TParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection\.GetParameterDefinitions\<TParameterDefinition\>\(string, DiGi\.Core\.Enums\.TextComparisonType, bool\)\.TParameterDefinition') that match the specified name and comparison criteria across all groups\.

```csharp
public System.Collections.Generic.List<TParameterDefinition>? GetParameterDefinitions<TParameterDefinition>(string? parameterName, DiGi.Core.Enums.TextComparisonType textComparisonType=DiGi.Core.Enums.TextComparisonType.Equals, bool caseSensitive=true)
    where TParameterDefinition : DiGi.Core.Parameter.Interfaces.IParameterDefinition;
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetParameterDefinitions_TParameterDefinition_(string,DiGi.Core.Enums.TextComparisonType,bool).TParameterDefinition'></a>

`TParameterDefinition`

The type of parameter definition to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetParameterDefinitions_TParameterDefinition_(string,DiGi.Core.Enums.TextComparisonType,bool).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameters to search for\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetParameterDefinitions_TParameterDefinition_(string,DiGi.Core.Enums.TextComparisonType,bool).textComparisonType'></a>

`textComparisonType` [DiGi\.Core\.Enums\.TextComparisonType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.textcomparisontype 'DiGi\.Core\.Enums\.TextComparisonType')

The type of text comparison to use when matching the name\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetParameterDefinitions_TParameterDefinition_(string,DiGi.Core.Enums.TextComparisonType,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the comparison should be case\-sensitive\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetParameterDefinitions_TParameterDefinition_(string,DiGi.Core.Enums.TextComparisonType,bool).TParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection\.GetParameterDefinitions\<TParameterDefinition\>\(string, DiGi\.Core\.Enums\.TextComparisonType, bool\)\.TParameterDefinition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of parameter definitions that match the criteria, or null if none are found\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParameterGroupCollection\.GetValue\(IParameterDefinition, GetValueSettings\) Method

Gets the value associated with the specified parameter definition from the collection\.

```csharp
public object? GetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition used to retrieve the value\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to customize how the value is retrieved\.

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')  
The value associated with the specified parameter definition, or null if not found\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue(string,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParameterGroupCollection\.GetValue\(string, GetValueSettings\) Method

Gets the value associated with the specified unique identifier from the collection\.

```csharp
public object? GetValue(string? uniqueId, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue(string,DiGi.Core.Parameter.Classes.GetValueSettings).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the value to retrieve\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue(string,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to customize how the value is retrieved\.

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')  
The value associated with the specified unique identifier, or null if not found\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParameterGroupCollection\.GetValue\<T\>\(GetValueSettings\) Method

Gets the first parameter value converted to type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection\.GetValue\<T\>\(DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') from the collection\.

```csharp
public T? GetValue<T>(DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to control how the value is retrieved\.

#### Returns
[T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection\.GetValue\<T\>\(DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')  
The value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection\.GetValue\<T\>\(DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T'), or default if not found\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParameterGroupCollection\.GetValue\<T\>\(IParameterDefinition, GetValueSettings\) Method

Gets the value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection\.GetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') associated with the specified parameter definition from the collection\.

```csharp
public T? GetValue<T>(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The definition of the parameter whose value is to be retrieved\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to control how the value is retrieved\.

#### Returns
[T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection\.GetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')  
The value associated with the specified parameter definition, cast to type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection\.GetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T'), or null if not found\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(string,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParameterGroupCollection\.GetValue\<T\>\(string, GetValueSettings\) Method

Gets the value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(string,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection\.GetValue\<T\>\(string, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') associated with the specified unique identifier from the collection\.

```csharp
public T? GetValue<T>(string? uniqueId, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(string,DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(string,DiGi.Core.Parameter.Classes.GetValueSettings).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the value to retrieve\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(string,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to customize how the value is retrieved\.

#### Returns
[T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(string,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection\.GetValue\<T\>\(string, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')  
The value associated with the specified unique identifier, or default if not found\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(System.Enum,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParameterGroupCollection\.GetValue\<T\>\(Enum, GetValueSettings\) Method

Gets the value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(System.Enum,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection\.GetValue\<T\>\(System\.Enum, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') associated with the specified enumeration member from the collection\.

```csharp
public T? GetValue<T>(System.Enum? @enum, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(System.Enum,DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(System.Enum,DiGi.Core.Parameter.Classes.GetValueSettings).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration member associated with the value\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(System.Enum,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to customize how the value is retrieved\.

#### Returns
[T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection.GetValue_T_(System.Enum,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection\.GetValue\<T\>\(System\.Enum, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')  
The value associated with the specified enumeration member, or default if not found\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.Remove(DiGi.Core.Parameter.Interfaces.IParameterDefinition)'></a>

## ParameterGroupCollection\.Remove\(IParameterDefinition\) Method

Removes the parameter matching the specified definition from the collection\.

```csharp
public bool Remove(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.Remove(DiGi.Core.Parameter.Interfaces.IParameterDefinition).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The definition of the parameter to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the parameter was successfully removed; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.Remove(string)'></a>

## ParameterGroupCollection\.Remove\(string\) Method

Removes the parameter with the specified unique identifier from the collection\.

```csharp
public bool Remove(string? uniqueId);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.Remove(string).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the parameter to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the parameter was successfully removed; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.SetValue(DiGi.Core.Parameter.Classes.Parameter)'></a>

## ParameterGroupCollection\.SetValue\(Parameter\) Method

Adds or updates a parameter in the collection\.

```csharp
public bool SetValue(DiGi.Core.Parameter.Classes.Parameter? parameter);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.SetValue(DiGi.Core.Parameter.Classes.Parameter).parameter'></a>

`parameter` [Parameter](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.Parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')

The parameter to add or update\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the operation was successful; otherwise, `false`\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings)'></a>

## ParameterGroupCollection\.SetValue\(IParameterDefinition, object, SetValueSettings\) Method

Sets the value for the parameter matching the specified definition within the collection\.

```csharp
public bool SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition, object? value, DiGi.Core.Parameter.Classes.SetValueSettings? setValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The definition of the parameter to set\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to assign to the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings).setValueSettings'></a>

`setValueSettings` [SetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.SetValueSettings 'DiGi\.Core\.Parameter\.Classes\.SetValueSettings')

Optional settings to control how the value is set\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully set; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.SetValue(string,object,DiGi.Core.Parameter.Classes.SetValueSettings)'></a>

## ParameterGroupCollection\.SetValue\(string, object, SetValueSettings\) Method

Sets the value for the parameter identified by the specified name within the collection\.

```csharp
public bool SetValue(string? name, object? value, DiGi.Core.Parameter.Classes.SetValueSettings? setValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.SetValue(string,object,DiGi.Core.Parameter.Classes.SetValueSettings).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter to set\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.SetValue(string,object,DiGi.Core.Parameter.Classes.SetValueSettings).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to assign to the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.SetValue(string,object,DiGi.Core.Parameter.Classes.SetValueSettings).setValueSettings'></a>

`setValueSettings` [SetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.SetValueSettings 'DiGi\.Core\.Parameter\.Classes\.SetValueSettings')

Optional settings to control how the value is set\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully set; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParameterGroupCollection\.TryGetValue\(IParameterDefinition, object, GetValueSettings\) Method

Attempts to get the value associated with the specified parameter definition from the collection\.

```csharp
public bool TryGetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition, out object? value, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.GetValueSettings).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition associated with the value to get\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.GetValueSettings).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the value associated with the specified parameter definition, if found; otherwise, `null`\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to use when retrieving the value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the value was found; otherwise, `false`\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue(string,object,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParameterGroupCollection\.TryGetValue\(string, object, GetValueSettings\) Method

Attempts to get the value associated with the specified unique identifier from the collection\.

```csharp
public bool TryGetValue(string? uniqueId, out object? value, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue(string,object,DiGi.Core.Parameter.Classes.GetValueSettings).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the value to get\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue(string,object,DiGi.Core.Parameter.Classes.GetValueSettings).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the value associated with the specified unique identifier, if found; otherwise, `null`\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue(string,object,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to use when retrieving the value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the value was found; otherwise, `false`\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParameterGroupCollection\.TryGetValue\<T\>\(IParameterDefinition, T, GetValueSettings\) Method

Attempts to get the value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection\.TryGetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') associated with the specified parameter definition from the collection\.

```csharp
public bool TryGetValue<T>(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition, out T? value, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition associated with the value to get\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).value'></a>

`value` [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection\.TryGetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')

When this method returns, contains the value associated with the specified parameter definition, if found; otherwise, the default value of [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection\.TryGetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to use when retrieving the value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the value was found; otherwise, `false`\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParameterGroupCollection\.TryGetValue\<T\>\(string, T, GetValueSettings\) Method

Attempts to get the value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection\.TryGetValue\<T\>\(string, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') associated with the specified unique identifier from the collection\.

```csharp
public bool TryGetValue<T>(string? uniqueId, out T? value, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the value to get\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).value'></a>

`value` [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection\.TryGetValue\<T\>\(string, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')

When this method returns, contains the value associated with the specified unique identifier, if found; otherwise, the default value of [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection\.TryGetValue\<T\>\(string, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')\.

<a name='DiGi.Core.Parameter.Classes.ParameterGroupCollection.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to use when retrieving the value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the value was found; otherwise, `false`\.

<a name='DiGi.Core.Parameter.Classes.ParameterProperties'></a>

## ParameterProperties Class

Contains metadata and properties for a parameter definition\.

```csharp
public class ParameterProperties : System.Attribute
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → ParameterProperties
### Constructors

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string)'></a>

## ParameterProperties\(string\) Constructor

Initializes a new instance of the [ParameterProperties](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterProperties 'DiGi\.Core\.Parameter\.Classes\.ParameterProperties') class with a specified name\.

```csharp
public ParameterProperties(string? name);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string)'></a>

## ParameterProperties\(string, string\) Constructor

Initializes a new instance of the [ParameterProperties](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterProperties 'DiGi\.Core\.Parameter\.Classes\.ParameterProperties') class with a unique identifier and name\.

```csharp
public ParameterProperties(string? uniqueId, string? name);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string,DiGi.Core.Parameter.Enums.AccessType)'></a>

## ParameterProperties\(string, string, AccessType\) Constructor

Initializes a new instance of the [ParameterProperties](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterProperties 'DiGi\.Core\.Parameter\.Classes\.ParameterProperties') class with a name, description, and access type\.

```csharp
public ParameterProperties(string? name, string? description, DiGi.Core.Parameter.Enums.AccessType accessType);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string,DiGi.Core.Parameter.Enums.AccessType).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string,DiGi.Core.Parameter.Enums.AccessType).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string,DiGi.Core.Parameter.Enums.AccessType).accessType'></a>

`accessType` [AccessType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.AccessType 'DiGi\.Core\.Parameter\.Enums\.AccessType')

The access type of the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string,string)'></a>

## ParameterProperties\(string, string, string\) Constructor

Initializes a new instance of the [ParameterProperties](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterProperties 'DiGi\.Core\.Parameter\.Classes\.ParameterProperties') class with a unique identifier, name, and description\.

```csharp
public ParameterProperties(string? uniqueId, string? name, string? description);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string,string).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType)'></a>

## ParameterProperties\(string, string, string, AccessType\) Constructor

Initializes a new instance of the [ParameterProperties](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterProperties 'DiGi\.Core\.Parameter\.Classes\.ParameterProperties') class with a unique identifier, name, description, and access type\.

```csharp
public ParameterProperties(string? uniqueId, string? name, string? description, DiGi.Core.Parameter.Enums.AccessType accessType);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType).accessType'></a>

`accessType` [AccessType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.AccessType 'DiGi\.Core\.Parameter\.Enums\.AccessType')

The access type of the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string)'></a>

## ParameterProperties\(string, string, string, AccessType, string\) Constructor

Initializes a new instance of the [ParameterProperties](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterProperties 'DiGi\.Core\.Parameter\.Classes\.ParameterProperties') class with full metadata including group name\.

```csharp
public ParameterProperties(string? uniqueId, string? name, string? description, DiGi.Core.Parameter.Enums.AccessType accessType, string? groupName);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string).accessType'></a>

`accessType` [AccessType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.AccessType 'DiGi\.Core\.Parameter\.Enums\.AccessType')

The access type of the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.ParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string).groupName'></a>

`groupName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the group to which the parameter belongs\.
### Properties

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.AccessType'></a>

## ParameterProperties\.AccessType Property

Gets or sets the access level of the parameter\.

```csharp
public DiGi.Core.Parameter.Enums.AccessType AccessType { get; }
```

#### Property Value
[AccessType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.AccessType 'DiGi\.Core\.Parameter\.Enums\.AccessType')

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.Description'></a>

## ParameterProperties\.Description Property

Gets or sets the description of the parameter\.

```csharp
public string? Description { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.GroupName'></a>

## ParameterProperties\.GroupName Property

Gets or sets the name of the group this parameter belongs to\.

```csharp
public string? GroupName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.Name'></a>

## ParameterProperties\.Name Property

Gets or sets the display name of the parameter\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Parameter.Classes.ParameterProperties.UniqueId'></a>

## ParameterProperties\.UniqueId Property

Gets or sets a unique string identifier for the object\.

```csharp
public string? UniqueId { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Parameter.Classes.ParameterValue'></a>

## ParameterValue Class

Base class for all parameter value types\.

```csharp
public abstract class ParameterValue : System.Attribute, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → ParameterValue

Derived  
↳ [BooleanParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.BooleanParameterValue 'DiGi\.Core\.Parameter\.Classes\.BooleanParameterValue')  
↳ [DoubleParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.DoubleParameterValue 'DiGi\.Core\.Parameter\.Classes\.DoubleParameterValue')  
↳ [GuidParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GuidParameterValue 'DiGi\.Core\.Parameter\.Classes\.GuidParameterValue')  
↳ [IntegerParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.IntegerParameterValue 'DiGi\.Core\.Parameter\.Classes\.IntegerParameterValue')  
↳ [ObjectParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ObjectParameterValue 'DiGi\.Core\.Parameter\.Classes\.ObjectParameterValue')  
↳ [StringParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.StringParameterValue 'DiGi\.Core\.Parameter\.Classes\.StringParameterValue')

Implements [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Parameter.Classes.ParameterValue.ParameterValue()'></a>

## ParameterValue\(\) Constructor

Initializes a new instance of the [ParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterValue 'DiGi\.Core\.Parameter\.Classes\.ParameterValue') class\.

```csharp
public ParameterValue();
```

<a name='DiGi.Core.Parameter.Classes.ParameterValue.ParameterValue(bool)'></a>

## ParameterValue\(bool\) Constructor

Initializes a new instance of the [ParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterValue 'DiGi\.Core\.Parameter\.Classes\.ParameterValue') class with specified nullability\.

```csharp
public ParameterValue(bool nullable);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterValue.ParameterValue(bool).nullable'></a>

`nullable` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the parameter is nullable\.

<a name='DiGi.Core.Parameter.Classes.ParameterValue.ParameterValue(DiGi.Core.Parameter.Classes.ParameterValue)'></a>

## ParameterValue\(ParameterValue\) Constructor

Initializes a new instance of the [ParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterValue 'DiGi\.Core\.Parameter\.Classes\.ParameterValue') class by copying an existing instance\.

```csharp
public ParameterValue(DiGi.Core.Parameter.Classes.ParameterValue? parameterValue);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterValue.ParameterValue(DiGi.Core.Parameter.Classes.ParameterValue).parameterValue'></a>

`parameterValue` [ParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterValue 'DiGi\.Core\.Parameter\.Classes\.ParameterValue')

The existing [ParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterValue 'DiGi\.Core\.Parameter\.Classes\.ParameterValue') instance to copy\.

<a name='DiGi.Core.Parameter.Classes.ParameterValue.ParameterValue(System.Text.Json.Nodes.JsonObject)'></a>

## ParameterValue\(JsonObject\) Constructor

Initializes a new instance of the [ParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterValue 'DiGi\.Core\.Parameter\.Classes\.ParameterValue') class from a JSON object\.

```csharp
public ParameterValue(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterValue.ParameterValue(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the parameter value\.
### Properties

<a name='DiGi.Core.Parameter.Classes.ParameterValue.Nullable'></a>

## ParameterValue\.Nullable Property

Gets a value indicating whether the parameter is nullable\.

```csharp
public bool Nullable { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Parameter.Classes.ParameterValue.ParameterType'></a>

## ParameterValue\.ParameterType Property

Gets the parameter type associated with this value\.

```csharp
public abstract DiGi.Core.Parameter.Enums.ParameterType ParameterType { get; }
```

#### Property Value
[ParameterType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.ParameterType 'DiGi\.Core\.Parameter\.Enums\.ParameterType')
### Methods

<a name='DiGi.Core.Parameter.Classes.ParameterValue.Clone()'></a>

## ParameterValue\.Clone\(\) Method

Creates a clone of the current parameter value\.

```csharp
public abstract DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new instance of [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a copy of the current object, or null\.

<a name='DiGi.Core.Parameter.Classes.ParameterValue.FromJsonObject(System.Text.Json.Nodes.JsonObject)'></a>

## ParameterValue\.FromJsonObject\(JsonObject\) Method

Populates the parameter value from the provided JSON object\.

```csharp
public bool FromJsonObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterValue.FromJsonObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to extract the value from\.

Implements [FromJsonObject\(JsonObject\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject.fromjsonobject#digi-core-interfaces-iserializableobject-fromjsonobject(system-text-json-nodes-jsonobject) 'DiGi\.Core\.Interfaces\.ISerializableObject\.FromJsonObject\(System\.Text\.Json\.Nodes\.JsonObject\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the population was successful; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterValue.IsValid(object)'></a>

## ParameterValue\.IsValid\(object\) Method

Validates whether the given value is compatible with this parameter\.

```csharp
public virtual bool IsValid(object? value);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterValue.IsValid(object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to validate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value is valid; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParameterValue.ToJsonObject()'></a>

## ParameterValue\.ToJsonObject\(\) Method

Converts the current parameter value to a JSON object\.

```csharp
public System.Text.Json.Nodes.JsonObject? ToJsonObject();
```

Implements [ToJsonObject\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject.tojsonobject 'DiGi\.Core\.Interfaces\.ISerializableObject\.ToJsonObject')

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') representation of the parameter value, or null if conversion fails\.

<a name='DiGi.Core.Parameter.Classes.ParameterValue.TryConvert(object,object)'></a>

## ParameterValue\.TryConvert\(object, object\) Method

Attempts to convert an input value to the expected output type\.

```csharp
public virtual bool TryConvert(object? value_In, out object? value_Out);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParameterValue.TryConvert(object,object).value_In'></a>

`value_In` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to be converted\.

<a name='DiGi.Core.Parameter.Classes.ParameterValue.TryConvert(object,object).value_Out'></a>

`value_Out` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the converted value if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedGuidObject'></a>

## ParametrizedGuidObject Class

Base class for objects that possess a unique GUID and a set of parameters\.

```csharp
public abstract class ParametrizedGuidObject : DiGi.Core.Parameter.Classes.ParametrizedObject, DiGi.Core.Parameter.Interfaces.IParametrizedGuidObject, DiGi.Core.Parameter.Interfaces.IParametrizedUniqueObject, DiGi.Core.Parameter.Interfaces.IParametrizedObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IUniqueIdObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [ParametrizedObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → ParametrizedGuidObject

Implements [IParametrizedGuidObject](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedGuidObject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedGuidObject'), [IParametrizedUniqueObject](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedUniqueObject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedUniqueObject'), [IParametrizedObject](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedObject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.IUniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueidobject 'DiGi\.Core\.Interfaces\.IUniqueIdObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject')
### Constructors

<a name='DiGi.Core.Parameter.Classes.ParametrizedGuidObject.ParametrizedGuidObject()'></a>

## ParametrizedGuidObject\(\) Constructor

Initializes a new instance of the [ParametrizedGuidObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedGuidObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') class\.

```csharp
public ParametrizedGuidObject();
```

<a name='DiGi.Core.Parameter.Classes.ParametrizedGuidObject.ParametrizedGuidObject(DiGi.Core.Parameter.Classes.ParameterGroupCollection)'></a>

## ParametrizedGuidObject\(ParameterGroupCollection\) Constructor

Initializes a new instance of the [ParametrizedGuidObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedGuidObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') class with a specified group collection\.

```csharp
public ParametrizedGuidObject(DiGi.Core.Parameter.Classes.ParameterGroupCollection? parameterGroupCollection);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedGuidObject.ParametrizedGuidObject(DiGi.Core.Parameter.Classes.ParameterGroupCollection).parameterGroupCollection'></a>

`parameterGroupCollection` [ParameterGroupCollection](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection')

The collection of parameter groups to initialize the object with\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedGuidObject.ParametrizedGuidObject(DiGi.Core.Parameter.Classes.ParametrizedGuidObject)'></a>

## ParametrizedGuidObject\(ParametrizedGuidObject\) Constructor

Initializes a new instance of the [ParametrizedGuidObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedGuidObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') class by copying another object\.

```csharp
public ParametrizedGuidObject(DiGi.Core.Parameter.Classes.ParametrizedGuidObject? parametrizedGuidObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedGuidObject.ParametrizedGuidObject(DiGi.Core.Parameter.Classes.ParametrizedGuidObject).parametrizedGuidObject'></a>

`parametrizedGuidObject` [ParametrizedGuidObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedGuidObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject')

The source object to copy\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedGuidObject.ParametrizedGuidObject(System.Collections.Generic.IEnumerable_DiGi.Core.Parameter.Classes.Parameter_)'></a>

## ParametrizedGuidObject\(IEnumerable\<Parameter\>\) Constructor

Initializes a new instance of the [ParametrizedGuidObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedGuidObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') class with a collection of parameters\.

```csharp
public ParametrizedGuidObject(System.Collections.Generic.IEnumerable<DiGi.Core.Parameter.Classes.Parameter>? parameters);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedGuidObject.ParametrizedGuidObject(System.Collections.Generic.IEnumerable_DiGi.Core.Parameter.Classes.Parameter_).parameters'></a>

`parameters` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Parameter](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.Parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of parameters to initialize the object with\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedGuidObject.ParametrizedGuidObject(System.Guid)'></a>

## ParametrizedGuidObject\(Guid\) Constructor

Initializes a new instance of the [ParametrizedGuidObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedGuidObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') class with a specified GUID\.

```csharp
public ParametrizedGuidObject(System.Guid guid);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedGuidObject.ParametrizedGuidObject(System.Guid).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The GUID to assign to the new instance\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedGuidObject.ParametrizedGuidObject(System.Guid,DiGi.Core.Parameter.Classes.ParametrizedGuidObject)'></a>

## ParametrizedGuidObject\(Guid, ParametrizedGuidObject\) Constructor

Initializes a new instance of the [ParametrizedGuidObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedGuidObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') class with a specific GUID and data from another object\.

```csharp
public ParametrizedGuidObject(System.Guid guid, DiGi.Core.Parameter.Classes.ParametrizedGuidObject? parametrizedGuidObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedGuidObject.ParametrizedGuidObject(System.Guid,DiGi.Core.Parameter.Classes.ParametrizedGuidObject).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The GUID to assign to the new instance\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedGuidObject.ParametrizedGuidObject(System.Guid,DiGi.Core.Parameter.Classes.ParametrizedGuidObject).parametrizedGuidObject'></a>

`parametrizedGuidObject` [ParametrizedGuidObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedGuidObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject')

The source object from which to copy data\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedGuidObject.ParametrizedGuidObject(System.Text.Json.Nodes.JsonObject)'></a>

## ParametrizedGuidObject\(JsonObject\) Constructor

Initializes a new instance of the [ParametrizedGuidObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedGuidObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') class from a JSON object\.

```csharp
public ParametrizedGuidObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedGuidObject.ParametrizedGuidObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to deserialize into a new instance\.
### Properties

<a name='DiGi.Core.Parameter.Classes.ParametrizedGuidObject.Guid'></a>

## ParametrizedGuidObject\.Guid Property

Gets the unique global identifier of the object\.

```csharp
public System.Guid Guid { get; }
```

Implements [Guid](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject.guid 'DiGi\.Core\.Interfaces\.IGuidObject\.Guid')

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Core.Parameter.Classes.ParametrizedGuidObject.UniqueId'></a>

## ParametrizedGuidObject\.UniqueId Property

Gets or sets a unique string identifier for the object\.

```csharp
public string? UniqueId { get; }
```

Implements [UniqueId](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject.uniqueid 'DiGi\.Core\.Interfaces\.IUniqueObject\.UniqueId')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Core.Parameter.Classes.ParametrizedGuidObject.Duplicate(System.Nullable_System.Guid_)'></a>

## ParametrizedGuidObject\.Duplicate\(Nullable\<Guid\>\) Method

Creates a duplicate of the current object, optionally with a new GUID\.

```csharp
public DiGi.Core.Interfaces.IGuidObject? Duplicate(System.Nullable<System.Guid> guid=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedGuidObject.Duplicate(System.Nullable_System.Guid_).guid'></a>

`guid` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional GUID to assign to the duplicated object\.

Implements [Duplicate\(Nullable&lt;Guid&gt;\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject.duplicate#digi-core-interfaces-iguidobject-duplicate(system-nullable{system-guid}) 'DiGi\.Core\.Interfaces\.IGuidObject\.Duplicate\(System\.Nullable\{System\.Guid\}\)')

#### Returns
[DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject')  
A duplicate of the current object as an [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), or null if duplication fails\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject'></a>

## ParametrizedObject Class

Class ParametrizedObject\.

```csharp
public class ParametrizedObject : DiGi.Core.Classes.SerializableObject, DiGi.Core.Parameter.Interfaces.IParametrizedObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → ParametrizedObject

Derived  
↳ [ParametrizedGuidObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedGuidObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject')  
↳ [ParametrizedUniqueIdObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedUniqueIdObject')

Implements [IParametrizedObject](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedObject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.ParametrizedObject()'></a>

## ParametrizedObject\(\) Constructor

Initializes a new instance of the [ParametrizedObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') class\.

```csharp
public ParametrizedObject();
```

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.ParametrizedObject(DiGi.Core.Parameter.Classes.ParameterGroupCollection)'></a>

## ParametrizedObject\(ParameterGroupCollection\) Constructor

Initializes a new instance of the [ParametrizedObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') class using a parameter group collection\.

```csharp
public ParametrizedObject(DiGi.Core.Parameter.Classes.ParameterGroupCollection? parameterGroupCollection);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.ParametrizedObject(DiGi.Core.Parameter.Classes.ParameterGroupCollection).parameterGroupCollection'></a>

`parameterGroupCollection` [ParameterGroupCollection](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection')

The parameter group collection to use for initialization\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.ParametrizedObject(DiGi.Core.Parameter.Classes.ParametrizedObject)'></a>

## ParametrizedObject\(ParametrizedObject\) Constructor

Initializes a new instance of the [ParametrizedObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') class by copying another parametrized object\.

```csharp
public ParametrizedObject(DiGi.Core.Parameter.Classes.ParametrizedObject? parametrizedObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.ParametrizedObject(DiGi.Core.Parameter.Classes.ParametrizedObject).parametrizedObject'></a>

`parametrizedObject` [ParametrizedObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject')

The parametrized object to copy from\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.ParametrizedObject(System.Collections.Generic.IEnumerable_DiGi.Core.Parameter.Classes.Parameter_)'></a>

## ParametrizedObject\(IEnumerable\<Parameter\>\) Constructor

Initializes a new instance of the [ParametrizedObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') class using a collection of parameters\.

```csharp
public ParametrizedObject(System.Collections.Generic.IEnumerable<DiGi.Core.Parameter.Classes.Parameter>? parameters);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.ParametrizedObject(System.Collections.Generic.IEnumerable_DiGi.Core.Parameter.Classes.Parameter_).parameters'></a>

`parameters` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Parameter](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.Parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of parameters to initialize the object with\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.ParametrizedObject(System.Text.Json.Nodes.JsonObject)'></a>

## ParametrizedObject\(JsonObject\) Constructor

Initializes a new instance of the [ParametrizedObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') class from a JSON object\.

```csharp
public ParametrizedObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.ParametrizedObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.
### Properties

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.ParameterGroupCollection'></a>

## ParametrizedObject\.ParameterGroupCollection Property

Gets the parameter group collection\.

```csharp
public DiGi.Core.Parameter.Classes.ParameterGroupCollection ParameterGroupCollection { get; }
```

#### Property Value
[ParameterGroupCollection](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection')
### Methods

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.Clone()'></a>

## ParametrizedObject\.Clone\(\) Method

Creates a deep copy of the parametrized object\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new cloned instance of the parametrized object\.

### Remarks
A [ParametrizedObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') itself is copied member by member with its parameters cloned, which is a deep copy only because it holds nothing else\. Any derived type is copied by the JSON round trip of [DiGi\.Core\.Classes\.SerializableObject\.Clone](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject.clone 'DiGi\.Core\.Classes\.SerializableObject\.Clone'): a member\-by\-member copy would share every field it adds \- a `BuildingModel` clone shared its relation cluster with its source \(DiGi\-Organization/DiGi\.Core\#14\)\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.Contains(DiGi.Core.Parameter.Interfaces.IParameterDefinition)'></a>

## ParametrizedObject\.Contains\(IParameterDefinition\) Method

Determines whether the object contains a parameter associated with the specified definition\.

```csharp
public bool Contains(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.Contains(DiGi.Core.Parameter.Interfaces.IParameterDefinition).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition to search for\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object contains a parameter associated with the specified definition; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.Contains(string)'></a>

## ParametrizedObject\.Contains\(string\) Method

Determines whether the object contains a parameter with the specified unique identifier\.

```csharp
public bool Contains(string? uniqueId);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.Contains(string).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the parameter to search for\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object contains a parameter with the specified unique identifier; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.Contains(System.Enum)'></a>

## ParametrizedObject\.Contains\(Enum\) Method

Determines whether the object contains a parameter associated with the specified enumeration member\.

```csharp
public bool Contains(System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.Contains(System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration member to search for\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object contains a parameter associated with the specified enumeration member; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetParameterDefinitions(string,DiGi.Core.Enums.TextComparisonType,bool)'></a>

## ParametrizedObject\.GetParameterDefinitions\(string, TextComparisonType, bool\) Method

Retrieves a list of parameter definitions that match the specified name and comparison criteria\.

```csharp
public System.Collections.Generic.List<DiGi.Core.Parameter.Interfaces.IParameterDefinition>? GetParameterDefinitions(string? parameterName, DiGi.Core.Enums.TextComparisonType textComparisonType=DiGi.Core.Enums.TextComparisonType.Equals, bool caseSensitive=true);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetParameterDefinitions(string,DiGi.Core.Enums.TextComparisonType,bool).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameters to search for\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetParameterDefinitions(string,DiGi.Core.Enums.TextComparisonType,bool).textComparisonType'></a>

`textComparisonType` [DiGi\.Core\.Enums\.TextComparisonType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.textcomparisontype 'DiGi\.Core\.Enums\.TextComparisonType')

The type of text comparison to use\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetParameterDefinitions(string,DiGi.Core.Enums.TextComparisonType,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the comparison should be case\-sensitive\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of parameter definitions that match the specified criteria, or null if none are found\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetParameterDefinitions_TParameterDefinition_()'></a>

## ParametrizedObject\.GetParameterDefinitions\<TParameterDefinition\>\(\) Method

Retrieves all parameter definitions of type [TParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.GetParameterDefinitions_TParameterDefinition_().TParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.GetParameterDefinitions\<TParameterDefinition\>\(\)\.TParameterDefinition')\.

```csharp
public System.Collections.Generic.List<TParameterDefinition>? GetParameterDefinitions<TParameterDefinition>()
    where TParameterDefinition : DiGi.Core.Parameter.Interfaces.IParameterDefinition;
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetParameterDefinitions_TParameterDefinition_().TParameterDefinition'></a>

`TParameterDefinition`

The type of the parameter definitions to retrieve\.

Implements [GetParameterDefinitions&lt;TParameterDefinition&gt;\(\)](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedObject.GetParameterDefinitions_TParameterDefinition_() 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject\.GetParameterDefinitions\<TParameterDefinition\>\(\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.GetParameterDefinitions_TParameterDefinition_().TParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.GetParameterDefinitions\<TParameterDefinition\>\(\)\.TParameterDefinition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of all parameter definitions of the specified type, or null if none are found\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetParameterDefinitions_TParameterDefinition_(string,DiGi.Core.Enums.TextComparisonType,bool)'></a>

## ParametrizedObject\.GetParameterDefinitions\<TParameterDefinition\>\(string, TextComparisonType, bool\) Method

Retrieves a list of parameter definitions of type [TParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.GetParameterDefinitions_TParameterDefinition_(string,DiGi.Core.Enums.TextComparisonType,bool).TParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.GetParameterDefinitions\<TParameterDefinition\>\(string, DiGi\.Core\.Enums\.TextComparisonType, bool\)\.TParameterDefinition') that match the specified name and comparison criteria\.

```csharp
public System.Collections.Generic.List<TParameterDefinition>? GetParameterDefinitions<TParameterDefinition>(string? parameterName, DiGi.Core.Enums.TextComparisonType textComparisonType=DiGi.Core.Enums.TextComparisonType.Equals, bool caseSensitive=true)
    where TParameterDefinition : DiGi.Core.Parameter.Interfaces.IParameterDefinition;
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetParameterDefinitions_TParameterDefinition_(string,DiGi.Core.Enums.TextComparisonType,bool).TParameterDefinition'></a>

`TParameterDefinition`

The type of the parameter definitions to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetParameterDefinitions_TParameterDefinition_(string,DiGi.Core.Enums.TextComparisonType,bool).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameters to search for\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetParameterDefinitions_TParameterDefinition_(string,DiGi.Core.Enums.TextComparisonType,bool).textComparisonType'></a>

`textComparisonType` [DiGi\.Core\.Enums\.TextComparisonType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.textcomparisontype 'DiGi\.Core\.Enums\.TextComparisonType')

The type of text comparison to use\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetParameterDefinitions_TParameterDefinition_(string,DiGi.Core.Enums.TextComparisonType,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the comparison should be case\-sensitive\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.GetParameterDefinitions_TParameterDefinition_(string,DiGi.Core.Enums.TextComparisonType,bool).TParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.GetParameterDefinitions\<TParameterDefinition\>\(string, DiGi\.Core\.Enums\.TextComparisonType, bool\)\.TParameterDefinition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of parameter definitions that match the specified criteria, or null if none are found\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParametrizedObject\.GetValue\(IParameterDefinition, GetValueSettings\) Method

Gets the value associated with the specified parameter definition\.

```csharp
public object? GetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition for which to retrieve the value\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings for retrieving the value\.

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')  
The value associated with the specified parameter definition, or null if not found\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue(string,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParametrizedObject\.GetValue\(string, GetValueSettings\) Method

Gets the value associated with the specified unique identifier\.

```csharp
public object? GetValue(string? uniqueId, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue(string,DiGi.Core.Parameter.Classes.GetValueSettings).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the value to retrieve\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue(string,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings for retrieving the value\.

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')  
The value associated with the specified unique identifier, or null if not found\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue(System.Enum,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParametrizedObject\.GetValue\(Enum, GetValueSettings\) Method

Gets the value associated with the specified enumeration member\.

```csharp
public object? GetValue(System.Enum? @enum, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue(System.Enum,DiGi.Core.Parameter.Classes.GetValueSettings).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration member associated with the value\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue(System.Enum,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings for retrieving the value\.

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')  
The value associated with the specified enumeration member, or null if not found\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParametrizedObject\.GetValue\<T\>\(GetValueSettings\) Method

Gets the first parameter value converted to type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.GetValue\<T\>\(DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')\.

```csharp
public T? GetValue<T>(DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings for retrieving the value\.

Implements [GetValue&lt;T&gt;\(GetValueSettings\)](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedObject.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings) 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject\.GetValue\<T\>\(DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)')

#### Returns
[T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.GetValue\<T\>\(DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')  
The value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.GetValue\<T\>\(DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T'), or default if not found\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParametrizedObject\.GetValue\<T\>\(IParameterDefinition, GetValueSettings\) Method

Gets the value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.GetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') associated with the specified parameter definition\.

```csharp
public T? GetValue<T>(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The definition of the parameter whose value is to be retrieved\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings for retrieving the value\.

#### Returns
[T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.GetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')  
The value associated with the specified parameter definition, or null if not found\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(string,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParametrizedObject\.GetValue\<T\>\(string, GetValueSettings\) Method

Gets the value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(string,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.GetValue\<T\>\(string, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') associated with the specified unique identifier\.

```csharp
public T? GetValue<T>(string? uniqueId, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(string,DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(string,DiGi.Core.Parameter.Classes.GetValueSettings).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the value to retrieve\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(string,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings for retrieving the value\.

#### Returns
[T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(string,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.GetValue\<T\>\(string, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')  
The value associated with the specified unique identifier, or null if not found\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(System.Enum,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParametrizedObject\.GetValue\<T\>\(Enum, GetValueSettings\) Method

Gets the value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(System.Enum,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.GetValue\<T\>\(System\.Enum, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') associated with the specified enumeration member\.

```csharp
public T? GetValue<T>(System.Enum? @enum, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(System.Enum,DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(System.Enum,DiGi.Core.Parameter.Classes.GetValueSettings).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration member associated with the value\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(System.Enum,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings for retrieving the value\.

#### Returns
[T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.GetValue_T_(System.Enum,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.GetValue\<T\>\(System\.Enum, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')  
The value associated with the specified enumeration member, or null if not found\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.Remove(DiGi.Core.Parameter.Interfaces.IParameterDefinition)'></a>

## ParametrizedObject\.Remove\(IParameterDefinition\) Method

Removes the parameter associated with the specified definition\.

```csharp
public bool Remove(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.Remove(DiGi.Core.Parameter.Interfaces.IParameterDefinition).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The definition of the parameter to remove\.

Implements [Remove\(IParameterDefinition\)](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedObject.Remove(DiGi.Core.Parameter.Interfaces.IParameterDefinition) 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject\.Remove\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the parameter was successfully removed; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.Remove(string)'></a>

## ParametrizedObject\.Remove\(string\) Method

Removes the parameter associated with the specified unique identifier\.

```csharp
public bool Remove(string? uniqueId);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.Remove(string).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the parameter to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the parameter was successfully removed; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.SetValue(DiGi.Core.Parameter.Classes.Parameter)'></a>

## ParametrizedObject\.SetValue\(Parameter\) Method

Sets the value using the provided parameter object\.

```csharp
public bool SetValue(DiGi.Core.Parameter.Classes.Parameter? parameter);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.SetValue(DiGi.Core.Parameter.Classes.Parameter).parameter'></a>

`parameter` [Parameter](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.Parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')

The parameter object containing the value to set\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully set; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings)'></a>

## ParametrizedObject\.SetValue\(IParameterDefinition, object, SetValueSettings\) Method

Sets the value for the specified parameter definition\.

```csharp
public bool SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition, object? value, DiGi.Core.Parameter.Classes.SetValueSettings? setValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to set\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings).setValueSettings'></a>

`setValueSettings` [SetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.SetValueSettings 'DiGi\.Core\.Parameter\.Classes\.SetValueSettings')

Optional settings for setting the value\.

Implements [SetValue\(IParameterDefinition, object, SetValueSettings\)](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedObject.SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings) 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject\.SetValue\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, object, DiGi\.Core\.Parameter\.Classes\.SetValueSettings\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully set; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.SetValue(string,object,DiGi.Core.Parameter.Classes.SetValueSettings)'></a>

## ParametrizedObject\.SetValue\(string, object, SetValueSettings\) Method

Sets the value for the parameter with the specified name\.

```csharp
public bool SetValue(string? name, object? value, DiGi.Core.Parameter.Classes.SetValueSettings? setValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.SetValue(string,object,DiGi.Core.Parameter.Classes.SetValueSettings).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.SetValue(string,object,DiGi.Core.Parameter.Classes.SetValueSettings).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to set\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.SetValue(string,object,DiGi.Core.Parameter.Classes.SetValueSettings).setValueSettings'></a>

`setValueSettings` [SetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.SetValueSettings 'DiGi\.Core\.Parameter\.Classes\.SetValueSettings')

Optional settings for setting the value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully set; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.SetValue(System.Enum,object,DiGi.Core.Parameter.Classes.SetValueSettings)'></a>

## ParametrizedObject\.SetValue\(Enum, object, SetValueSettings\) Method

Sets the value for the specified enumeration member\.

```csharp
public bool SetValue(System.Enum? @enum, object? value, DiGi.Core.Parameter.Classes.SetValueSettings? setValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.SetValue(System.Enum,object,DiGi.Core.Parameter.Classes.SetValueSettings).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration member\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.SetValue(System.Enum,object,DiGi.Core.Parameter.Classes.SetValueSettings).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to set\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.SetValue(System.Enum,object,DiGi.Core.Parameter.Classes.SetValueSettings).setValueSettings'></a>

`setValueSettings` [SetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.SetValueSettings 'DiGi\.Core\.Parameter\.Classes\.SetValueSettings')

Optional settings for setting the value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully set; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParametrizedObject\.TryGetValue\(IParameterDefinition, object, GetValueSettings\) Method

Attempts to retrieve the value associated with the specified parameter definition\.

```csharp
public bool TryGetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition, out object? value, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.GetValueSettings).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition associated with the value\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.GetValueSettings).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the retrieved value if successful; otherwise, null\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to use when retrieving the value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully retrieved; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue(string,object,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParametrizedObject\.TryGetValue\(string, object, GetValueSettings\) Method

Attempts to retrieve the value associated with the specified unique identifier\.

```csharp
public bool TryGetValue(string? uniqueId, out object? value, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue(string,object,DiGi.Core.Parameter.Classes.GetValueSettings).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the value to retrieve\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue(string,object,DiGi.Core.Parameter.Classes.GetValueSettings).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the retrieved value if successful; otherwise, null\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue(string,object,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings for retrieving the value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully retrieved; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue(System.Enum,object,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParametrizedObject\.TryGetValue\(Enum, object, GetValueSettings\) Method

Attempts to retrieve the value associated with the specified enumeration member\.

```csharp
public bool TryGetValue(System.Enum? @enum, out object? value, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue(System.Enum,object,DiGi.Core.Parameter.Classes.GetValueSettings).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration member associated with the value\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue(System.Enum,object,DiGi.Core.Parameter.Classes.GetValueSettings).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the retrieved value if successful; otherwise, null\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue(System.Enum,object,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to use when retrieving the value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully retrieved; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParametrizedObject\.TryGetValue\<T\>\(IParameterDefinition, T, GetValueSettings\) Method

Attempts to retrieve the value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.TryGetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') associated with the specified parameter definition\.

```csharp
public bool TryGetValue<T>(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition, out T? value, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition associated with the value\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).value'></a>

`value` [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.TryGetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')

When this method returns, contains the retrieved value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.TryGetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') if successful; otherwise, the default value of [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.TryGetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to use when retrieving the value\.

Implements [TryGetValue&lt;T&gt;\(IParameterDefinition, T, GetValueSettings\)](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedObject.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings) 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject\.TryGetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully retrieved; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParametrizedObject\.TryGetValue\<T\>\(string, T, GetValueSettings\) Method

Attempts to retrieve the value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.TryGetValue\<T\>\(string, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') associated with the specified unique identifier\.

```csharp
public bool TryGetValue<T>(string? uniqueId, out T? value, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the value\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).value'></a>

`value` [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.TryGetValue\<T\>\(string, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')

When this method returns, contains the retrieved value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.TryGetValue\<T\>\(string, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') if successful; otherwise, the default value of [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.TryGetValue\<T\>\(string, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(string,T,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to use when retrieving the value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully retrieved; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(System.Enum,T,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## ParametrizedObject\.TryGetValue\<T\>\(Enum, T, GetValueSettings\) Method

Attempts to retrieve the value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(System.Enum,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.TryGetValue\<T\>\(System\.Enum, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') associated with the specified enumeration member\.

```csharp
public bool TryGetValue<T>(System.Enum? @enum, out T? value, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(System.Enum,T,DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(System.Enum,T,DiGi.Core.Parameter.Classes.GetValueSettings).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration member associated with the value\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(System.Enum,T,DiGi.Core.Parameter.Classes.GetValueSettings).value'></a>

`value` [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(System.Enum,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.TryGetValue\<T\>\(System\.Enum, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')

When this method returns, contains the retrieved value of type [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(System.Enum,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.TryGetValue\<T\>\(System\.Enum, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T') if successful; otherwise, the default value of [T](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(System.Enum,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject\.TryGetValue\<T\>\(System\.Enum, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedObject.TryGetValue_T_(System.Enum,T,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings to use when retrieving the value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully retrieved; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject'></a>

## ParametrizedUniqueIdObject Class

Represents an abstract base class for objects that possess both a set of parameters and a unique identifier\.

```csharp
public abstract class ParametrizedUniqueIdObject : DiGi.Core.Parameter.Classes.ParametrizedObject, DiGi.Core.Parameter.Interfaces.IParametrizedUniqueIdObject, DiGi.Core.Parameter.Interfaces.IParametrizedUniqueObject, DiGi.Core.Parameter.Interfaces.IParametrizedObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IUniqueIdObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [ParametrizedObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → ParametrizedUniqueIdObject

Implements [IParametrizedUniqueIdObject](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedUniqueIdObject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedUniqueIdObject'), [IParametrizedUniqueObject](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedUniqueObject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedUniqueObject'), [IParametrizedObject](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedObject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.IUniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueidobject 'DiGi\.Core\.Interfaces\.IUniqueIdObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Constructors

<a name='DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject.ParametrizedUniqueIdObject()'></a>

## ParametrizedUniqueIdObject\(\) Constructor

Initializes a new instance of the [ParametrizedUniqueIdObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedUniqueIdObject') class\.

```csharp
public ParametrizedUniqueIdObject();
```

<a name='DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject.ParametrizedUniqueIdObject(DiGi.Core.Parameter.Classes.ParameterGroupCollection)'></a>

## ParametrizedUniqueIdObject\(ParameterGroupCollection\) Constructor

Initializes a new instance of the [ParametrizedUniqueIdObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedUniqueIdObject') class using a parameter group collection\.

```csharp
public ParametrizedUniqueIdObject(DiGi.Core.Parameter.Classes.ParameterGroupCollection? parameterGroupCollection);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject.ParametrizedUniqueIdObject(DiGi.Core.Parameter.Classes.ParameterGroupCollection).parameterGroupCollection'></a>

`parameterGroupCollection` [ParameterGroupCollection](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterGroupCollection 'DiGi\.Core\.Parameter\.Classes\.ParameterGroupCollection')

The parameter group collection to use for initialization\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject.ParametrizedUniqueIdObject(DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject)'></a>

## ParametrizedUniqueIdObject\(ParametrizedUniqueIdObject\) Constructor

Initializes a new instance of the [ParametrizedUniqueIdObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedUniqueIdObject') class by copying another unique ID parametrized object\.

```csharp
public ParametrizedUniqueIdObject(DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject? parametrizedUniqueIdObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject.ParametrizedUniqueIdObject(DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject).parametrizedUniqueIdObject'></a>

`parametrizedUniqueIdObject` [ParametrizedUniqueIdObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedUniqueIdObject')

The parametrized unique ID object to copy\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject.ParametrizedUniqueIdObject(string)'></a>

## ParametrizedUniqueIdObject\(string\) Constructor

Initializes a new instance of the [ParametrizedUniqueIdObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedUniqueIdObject') class with a specified unique identifier\.

```csharp
public ParametrizedUniqueIdObject(string? uniqueId);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject.ParametrizedUniqueIdObject(string).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject.ParametrizedUniqueIdObject(string,DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject)'></a>

## ParametrizedUniqueIdObject\(string, ParametrizedUniqueIdObject\) Constructor

Initializes a new instance of the [ParametrizedUniqueIdObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedUniqueIdObject') class with a specific ID and values from another object\.

```csharp
public ParametrizedUniqueIdObject(string? uniqueId, DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject? parametrizedUniqueIdObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject.ParametrizedUniqueIdObject(string,DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject.ParametrizedUniqueIdObject(string,DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject).parametrizedUniqueIdObject'></a>

`parametrizedUniqueIdObject` [ParametrizedUniqueIdObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedUniqueIdObject')

The parametrized unique ID object to copy values from\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject.ParametrizedUniqueIdObject(System.Collections.Generic.IEnumerable_DiGi.Core.Parameter.Classes.Parameter_)'></a>

## ParametrizedUniqueIdObject\(IEnumerable\<Parameter\>\) Constructor

Initializes a new instance of the [ParametrizedUniqueIdObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedUniqueIdObject') class using a collection of parameters\.

```csharp
public ParametrizedUniqueIdObject(System.Collections.Generic.IEnumerable<DiGi.Core.Parameter.Classes.Parameter>? parameters);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject.ParametrizedUniqueIdObject(System.Collections.Generic.IEnumerable_DiGi.Core.Parameter.Classes.Parameter_).parameters'></a>

`parameters` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Parameter](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.Parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of parameters to use for initialization\.

<a name='DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject.ParametrizedUniqueIdObject(System.Text.Json.Nodes.JsonObject)'></a>

## ParametrizedUniqueIdObject\(JsonObject\) Constructor

Initializes a new instance of the [ParametrizedUniqueIdObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedUniqueIdObject') class from a JSON object\.

```csharp
public ParametrizedUniqueIdObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject.ParametrizedUniqueIdObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.
### Properties

<a name='DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject.UniqueId'></a>

## ParametrizedUniqueIdObject\.UniqueId Property

Gets or sets the unique identifier for this object\.

```csharp
public string? UniqueId { get; }
```

Implements [UniqueId](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject.uniqueid 'DiGi\.Core\.Interfaces\.IUniqueObject\.UniqueId')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Parameter.Classes.SetValueSettings'></a>

## SetValueSettings Class

Contains settings for setting a parameter value\.

```csharp
public class SetValueSettings
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → SetValueSettings
### Constructors

<a name='DiGi.Core.Parameter.Classes.SetValueSettings.SetValueSettings()'></a>

## SetValueSettings\(\) Constructor

Initializes a new instance of the SetValueSettings class\.

```csharp
public SetValueSettings();
```

<a name='DiGi.Core.Parameter.Classes.SetValueSettings.SetValueSettings(bool,bool)'></a>

## SetValueSettings\(bool, bool\) Constructor

Initializes a new instance of the SetValueSettings class with specified options\.

```csharp
public SetValueSettings(bool tryConvert, bool checkAccessType);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.SetValueSettings.SetValueSettings(bool,bool).tryConvert'></a>

`tryConvert` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to attempt conversion if types do not match\.

<a name='DiGi.Core.Parameter.Classes.SetValueSettings.SetValueSettings(bool,bool).checkAccessType'></a>

`checkAccessType` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to check for write access permissions\.
### Properties

<a name='DiGi.Core.Parameter.Classes.SetValueSettings.CheckAccessType'></a>

## SetValueSettings\.CheckAccessType Property

Gets or sets a value indicating whether the access type should be checked during assignment\.

```csharp
public bool CheckAccessType { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Parameter.Classes.SetValueSettings.TryConvert'></a>

## SetValueSettings\.TryConvert Property

Gets or sets a value indicating whether to attempt conversion of the value during assignment\.

```csharp
public bool TryConvert { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Parameter.Classes.SimpleParameterDefinition'></a>

## SimpleParameterDefinition Class

Represents a definition for a simple parameter\.

```csharp
public class SimpleParameterDefinition : DiGi.Core.Parameter.Classes.ParameterDefinition
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [ParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ParameterDefinition') → SimpleParameterDefinition
### Constructors

<a name='DiGi.Core.Parameter.Classes.SimpleParameterDefinition.SimpleParameterDefinition(DiGi.Core.Parameter.Classes.SimpleParameterDefinition)'></a>

## SimpleParameterDefinition\(SimpleParameterDefinition\) Constructor

Initializes a new instance of the [SimpleParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.SimpleParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.SimpleParameterDefinition') class by copying an existing definition\.

```csharp
public SimpleParameterDefinition(DiGi.Core.Parameter.Classes.SimpleParameterDefinition? simpleParameterDefinition);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.SimpleParameterDefinition.SimpleParameterDefinition(DiGi.Core.Parameter.Classes.SimpleParameterDefinition).simpleParameterDefinition'></a>

`simpleParameterDefinition` [SimpleParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.SimpleParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.SimpleParameterDefinition')

The parameter definition to copy from\.

<a name='DiGi.Core.Parameter.Classes.SimpleParameterDefinition.SimpleParameterDefinition(string)'></a>

## SimpleParameterDefinition\(string\) Constructor

Initializes a new instance of the [SimpleParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.SimpleParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.SimpleParameterDefinition') class with the specified name\.

```csharp
public SimpleParameterDefinition(string? name);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.SimpleParameterDefinition.SimpleParameterDefinition(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Core.Parameter.Classes.SimpleParameterDefinition.SimpleParameterDefinition(System.Text.Json.Nodes.JsonObject)'></a>

## SimpleParameterDefinition\(JsonObject\) Constructor

Initializes a new instance of the [SimpleParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.SimpleParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.SimpleParameterDefinition') class from a JSON object\.

```csharp
public SimpleParameterDefinition(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.SimpleParameterDefinition.SimpleParameterDefinition(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the definition from\.
### Properties

<a name='DiGi.Core.Parameter.Classes.SimpleParameterDefinition.GroupName'></a>

## SimpleParameterDefinition\.GroupName Property

Gets the name of the group to which this parameter belongs\.

```csharp
public override string GroupName { get; }
```

Implements [GroupName](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition.GroupName 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\.GroupName')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Parameter.Classes.SimpleParameterDefinition.Name'></a>

## SimpleParameterDefinition\.Name Property

Gets or sets the name of the parameter\.

```csharp
public override string? Name { get; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Parameter.Classes.SimpleParameterDefinition.ParameterType'></a>

## SimpleParameterDefinition\.ParameterType Property

Gets the type of the parameter\.

```csharp
public override DiGi.Core.Parameter.Enums.ParameterType ParameterType { get; }
```

Implements [ParameterType](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition.ParameterType 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\.ParameterType')

#### Property Value
[ParameterType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.ParameterType 'DiGi\.Core\.Parameter\.Enums\.ParameterType')

<a name='DiGi.Core.Parameter.Classes.SimpleParameterDefinition.UniqueId'></a>

## SimpleParameterDefinition\.UniqueId Property

Gets or sets the unique identifier for the parameter\.

```csharp
public override string? UniqueId { get; }
```

Implements [UniqueId](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition.UniqueId 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\.UniqueId')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Core.Parameter.Classes.SimpleParameterDefinition.IsValid(object)'></a>

## SimpleParameterDefinition\.IsValid\(object\) Method

Determines whether the specified value is a valid integer parameter value\.

```csharp
public override bool IsValid(object? value);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.SimpleParameterDefinition.IsValid(object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to validate\.

Implements [IsValid\(object\)](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition.IsValid(object) 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\.IsValid\(object\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value is a valid integer parameter value; otherwise, false\.

<a name='DiGi.Core.Parameter.Classes.StringParameterValue'></a>

## StringParameterValue Class

Represents a parameter value that holds a string\.

```csharp
public class StringParameterValue : DiGi.Core.Parameter.Classes.ParameterValue
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → [ParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterValue 'DiGi\.Core\.Parameter\.Classes\.ParameterValue') → StringParameterValue
### Constructors

<a name='DiGi.Core.Parameter.Classes.StringParameterValue.StringParameterValue()'></a>

## StringParameterValue\(\) Constructor

Initializes a new instance of the [StringParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.StringParameterValue 'DiGi\.Core\.Parameter\.Classes\.StringParameterValue') class\.

```csharp
public StringParameterValue();
```

<a name='DiGi.Core.Parameter.Classes.StringParameterValue.StringParameterValue(bool)'></a>

## StringParameterValue\(bool\) Constructor

Initializes a new instance of the [StringParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.StringParameterValue 'DiGi\.Core\.Parameter\.Classes\.StringParameterValue') class with specified nullability\.

```csharp
public StringParameterValue(bool nullable);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.StringParameterValue.StringParameterValue(bool).nullable'></a>

`nullable` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the parameter is nullable\.

<a name='DiGi.Core.Parameter.Classes.StringParameterValue.StringParameterValue(DiGi.Core.Parameter.Classes.StringParameterValue)'></a>

## StringParameterValue\(StringParameterValue\) Constructor

Initializes a new instance of the [StringParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.StringParameterValue 'DiGi\.Core\.Parameter\.Classes\.StringParameterValue') class by copying an existing instance\.

```csharp
public StringParameterValue(DiGi.Core.Parameter.Classes.StringParameterValue? stringParameterValue);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.StringParameterValue.StringParameterValue(DiGi.Core.Parameter.Classes.StringParameterValue).stringParameterValue'></a>

`stringParameterValue` [StringParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.StringParameterValue 'DiGi\.Core\.Parameter\.Classes\.StringParameterValue')

The existing instance to copy\.

<a name='DiGi.Core.Parameter.Classes.StringParameterValue.StringParameterValue(System.Text.Json.Nodes.JsonObject)'></a>

## StringParameterValue\(JsonObject\) Constructor

Initializes a new instance of the [StringParameterValue](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.StringParameterValue 'DiGi\.Core\.Parameter\.Classes\.StringParameterValue') class from a JSON object\.

```csharp
public StringParameterValue(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Parameter.Classes.StringParameterValue.StringParameterValue(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.
### Properties

<a name='DiGi.Core.Parameter.Classes.StringParameterValue.ParameterType'></a>

## StringParameterValue\.ParameterType Property

Gets the parameter type associated with this string parameter value\.

```csharp
public override DiGi.Core.Parameter.Enums.ParameterType ParameterType { get; }
```

#### Property Value
[ParameterType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.ParameterType 'DiGi\.Core\.Parameter\.Enums\.ParameterType')
### Methods

<a name='DiGi.Core.Parameter.Classes.StringParameterValue.Clone()'></a>

## StringParameterValue\.Clone\(\) Method

Creates a clone of the current string parameter value\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A clone of the current string parameter value\.