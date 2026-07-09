#### [DiGi\.Unit](DiGi.Unit.Overview.md 'DiGi\.Unit\.Overview')

## DiGi\.Unit\.Classes Namespace
### Classes

<a name='DiGi.Unit.Classes.CategoryAttribute'></a>

## CategoryAttribute Class

An attribute used to categorize enums, implementing serialization and naming contracts\.

```csharp
public sealed class CategoryAttribute : System.Attribute, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.INamedObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → CategoryAttribute

Implements [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject')
### Constructors

<a name='DiGi.Unit.Classes.CategoryAttribute.CategoryAttribute(DiGi.Unit.Classes.CategoryAttribute)'></a>

## CategoryAttribute\(CategoryAttribute\) Constructor

Initializes a new instance of the [CategoryAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.CategoryAttribute 'DiGi\.Unit\.Classes\.CategoryAttribute') class by copying an existing category attribute\.

```csharp
public CategoryAttribute(DiGi.Unit.Classes.CategoryAttribute category);
```
#### Parameters

<a name='DiGi.Unit.Classes.CategoryAttribute.CategoryAttribute(DiGi.Unit.Classes.CategoryAttribute).category'></a>

`category` [CategoryAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.CategoryAttribute 'DiGi\.Unit\.Classes\.CategoryAttribute')

The source category attribute to copy\.

<a name='DiGi.Unit.Classes.CategoryAttribute.CategoryAttribute(DiGi.Unit.Enums.UnitCategory)'></a>

## CategoryAttribute\(UnitCategory\) Constructor

Initializes a new instance of the [CategoryAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.CategoryAttribute 'DiGi\.Unit\.Classes\.CategoryAttribute') class using a specified unit category\.

```csharp
public CategoryAttribute(DiGi.Unit.Enums.UnitCategory unitCategory);
```
#### Parameters

<a name='DiGi.Unit.Classes.CategoryAttribute.CategoryAttribute(DiGi.Unit.Enums.UnitCategory).unitCategory'></a>

`unitCategory` [UnitCategory](DiGi.Unit.Enums.md#DiGi.Unit.Enums.UnitCategory 'DiGi\.Unit\.Enums\.UnitCategory')

The unit category to assign\.

<a name='DiGi.Unit.Classes.CategoryAttribute.CategoryAttribute(System.Text.Json.Nodes.JsonObject)'></a>

## CategoryAttribute\(JsonObject\) Constructor

Initializes a new instance of the [CategoryAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.CategoryAttribute 'DiGi\.Unit\.Classes\.CategoryAttribute') class from a JSON object\.

```csharp
public CategoryAttribute(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Unit.Classes.CategoryAttribute.CategoryAttribute(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing category data\.
### Properties

<a name='DiGi.Unit.Classes.CategoryAttribute.Name'></a>

## CategoryAttribute\.Name Property

Gets the name associated with the category\.

```csharp
public string Name { get; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Unit.Classes.CategoryAttribute.UnitCategory'></a>

## CategoryAttribute\.UnitCategory Property

Gets the [UnitCategory](DiGi.Unit.Classes.md#DiGi.Unit.Classes.CategoryAttribute.UnitCategory 'DiGi\.Unit\.Classes\.CategoryAttribute\.UnitCategory') enum value corresponding to the current name\.

```csharp
public System.Nullable<DiGi.Unit.Enums.UnitCategory> UnitCategory { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[UnitCategory](DiGi.Unit.Enums.md#DiGi.Unit.Enums.UnitCategory 'DiGi\.Unit\.Enums\.UnitCategory')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')
### Methods

<a name='DiGi.Unit.Classes.CategoryAttribute.Clone()'></a>

## CategoryAttribute\.Clone\(\) Method

Creates a clone of the current category attribute\.

```csharp
public DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') instance\.

<a name='DiGi.Unit.Classes.CategoryAttribute.FromJsonObject(System.Text.Json.Nodes.JsonObject)'></a>

## CategoryAttribute\.FromJsonObject\(JsonObject\) Method

Populates the current category attribute from a JSON object\.

```csharp
public bool FromJsonObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Unit.Classes.CategoryAttribute.FromJsonObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to read data from\.

Implements [FromJsonObject\(JsonObject\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject.fromjsonobject#digi-core-interfaces-iserializableobject-fromjsonobject(system-text-json-nodes-jsonobject) 'DiGi\.Core\.Interfaces\.ISerializableObject\.FromJsonObject\(System\.Text\.Json\.Nodes\.JsonObject\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the population was successful; otherwise, false\.

<a name='DiGi.Unit.Classes.CategoryAttribute.ToJsonObject()'></a>

## CategoryAttribute\.ToJsonObject\(\) Method

Converts the current category attribute to a JSON object\.

```csharp
public System.Text.Json.Nodes.JsonObject? ToJsonObject();
```

Implements [ToJsonObject\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject.tojsonobject 'DiGi\.Core\.Interfaces\.ISerializableObject\.ToJsonObject')

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') representation of the attribute\.
### Operators

<a name='DiGi.Unit.Classes.CategoryAttribute.op_ImplicitDiGi.Unit.Classes.CategoryAttribute(DiGi.Unit.Enums.UnitCategory)'></a>

## CategoryAttribute\.implicit operator CategoryAttribute\(UnitCategory\) Operator

Implicitly converts a [UnitCategory](DiGi.Unit.Classes.md#DiGi.Unit.Classes.CategoryAttribute.UnitCategory 'DiGi\.Unit\.Classes\.CategoryAttribute\.UnitCategory') value to a [CategoryAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.CategoryAttribute 'DiGi\.Unit\.Classes\.CategoryAttribute')\.

```csharp
public static DiGi.Unit.Classes.CategoryAttribute implicit operator DiGi.Unit.Classes.CategoryAttribute(DiGi.Unit.Enums.UnitCategory unitCategory);
```
#### Parameters

<a name='DiGi.Unit.Classes.CategoryAttribute.op_ImplicitDiGi.Unit.Classes.CategoryAttribute(DiGi.Unit.Enums.UnitCategory).unitCategory'></a>

`unitCategory` [UnitCategory](DiGi.Unit.Enums.md#DiGi.Unit.Enums.UnitCategory 'DiGi\.Unit\.Enums\.UnitCategory')

The unit category to convert\.

#### Returns
[CategoryAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.CategoryAttribute 'DiGi\.Unit\.Classes\.CategoryAttribute')  
A new [CategoryAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.CategoryAttribute 'DiGi\.Unit\.Classes\.CategoryAttribute') instance\.

<a name='DiGi.Unit.Classes.CategoryAttribute.op_ImplicitDiGi.Unit.Classes.CategoryAttribute(string)'></a>

## CategoryAttribute\.implicit operator CategoryAttribute\(string\) Operator

Implicitly converts a string name to a [CategoryAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.CategoryAttribute 'DiGi\.Unit\.Classes\.CategoryAttribute')\.

```csharp
public static DiGi.Unit.Classes.CategoryAttribute implicit operator DiGi.Unit.Classes.CategoryAttribute(string name);
```
#### Parameters

<a name='DiGi.Unit.Classes.CategoryAttribute.op_ImplicitDiGi.Unit.Classes.CategoryAttribute(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The category name to convert\.

#### Returns
[CategoryAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.CategoryAttribute 'DiGi\.Unit\.Classes\.CategoryAttribute')  
A new [CategoryAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.CategoryAttribute 'DiGi\.Unit\.Classes\.CategoryAttribute') instance\.

<a name='DiGi.Unit.Classes.FactorUnitAttribute'></a>

## FactorUnitAttribute Class

Represents an attribute that defines a unit of measurement based on a conversion factor\.

```csharp
public class FactorUnitAttribute : DiGi.Unit.Classes.UnitAttribute
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → [UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute') → FactorUnitAttribute

Derived  
↳ [LinearUnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.LinearUnitAttribute 'DiGi\.Unit\.Classes\.LinearUnitAttribute')
### Constructors

<a name='DiGi.Unit.Classes.FactorUnitAttribute.FactorUnitAttribute(DiGi.Unit.Classes.FactorUnitAttribute)'></a>

## FactorUnitAttribute\(FactorUnitAttribute\) Constructor

Initializes a new instance of the [FactorUnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.FactorUnitAttribute 'DiGi\.Unit\.Classes\.FactorUnitAttribute') class by copying an existing instance\.

```csharp
public FactorUnitAttribute(DiGi.Unit.Classes.FactorUnitAttribute factorUnit);
```
#### Parameters

<a name='DiGi.Unit.Classes.FactorUnitAttribute.FactorUnitAttribute(DiGi.Unit.Classes.FactorUnitAttribute).factorUnit'></a>

`factorUnit` [FactorUnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.FactorUnitAttribute 'DiGi\.Unit\.Classes\.FactorUnitAttribute')

The source attribute to copy from\.

<a name='DiGi.Unit.Classes.FactorUnitAttribute.FactorUnitAttribute(string,string,double)'></a>

## FactorUnitAttribute\(string, string, double\) Constructor

Initializes a new instance of the [FactorUnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.FactorUnitAttribute 'DiGi\.Unit\.Classes\.FactorUnitAttribute') class\.

```csharp
public FactorUnitAttribute(string? name, string? symbol, double factor);
```
#### Parameters

<a name='DiGi.Unit.Classes.FactorUnitAttribute.FactorUnitAttribute(string,string,double).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the unit\.

<a name='DiGi.Unit.Classes.FactorUnitAttribute.FactorUnitAttribute(string,string,double).symbol'></a>

`symbol` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The symbol representing the unit\.

<a name='DiGi.Unit.Classes.FactorUnitAttribute.FactorUnitAttribute(string,string,double).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The conversion factor for the unit\.

<a name='DiGi.Unit.Classes.FactorUnitAttribute.FactorUnitAttribute(System.Text.Json.Nodes.JsonObject)'></a>

## FactorUnitAttribute\(JsonObject\) Constructor

Initializes a new instance of the [FactorUnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.FactorUnitAttribute 'DiGi\.Unit\.Classes\.FactorUnitAttribute') class from a JSON object\.

```csharp
public FactorUnitAttribute(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Unit.Classes.FactorUnitAttribute.FactorUnitAttribute(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the attribute data\.
### Properties

<a name='DiGi.Unit.Classes.FactorUnitAttribute.Factor'></a>

## FactorUnitAttribute\.Factor Property

Gets the conversion factor used for value transformations\.

```csharp
public double Factor { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.Unit.Classes.FactorUnitAttribute.Clone()'></a>

## FactorUnitAttribute\.Clone\(\) Method

Creates a clone of the current [FactorUnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.FactorUnitAttribute 'DiGi\.Unit\.Classes\.FactorUnitAttribute') instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') representing the cloned attribute\.

<a name='DiGi.Unit.Classes.FactorUnitAttribute.From(double)'></a>

## FactorUnitAttribute\.From\(double\) Method

Converts a value from the base unit to this specific unit by multiplying it by the factor\.

```csharp
public override double From(double value);
```
#### Parameters

<a name='DiGi.Unit.Classes.FactorUnitAttribute.From(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value to convert\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The converted value\.

<a name='DiGi.Unit.Classes.FactorUnitAttribute.To(double)'></a>

## FactorUnitAttribute\.To\(double\) Method

Converts a value from this specific unit back to the base unit by dividing it by the factor\.

```csharp
public override double To(double value);
```
#### Parameters

<a name='DiGi.Unit.Classes.FactorUnitAttribute.To(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value to convert\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The converted value\.

<a name='DiGi.Unit.Classes.LinearUnitAttribute'></a>

## LinearUnitAttribute Class

Represents an attribute for linear unit conversion that incorporates both a multiplication factor and an additive offset\.

```csharp
public class LinearUnitAttribute : DiGi.Unit.Classes.FactorUnitAttribute
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → [UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute') → [FactorUnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.FactorUnitAttribute 'DiGi\.Unit\.Classes\.FactorUnitAttribute') → LinearUnitAttribute
### Constructors

<a name='DiGi.Unit.Classes.LinearUnitAttribute.LinearUnitAttribute(DiGi.Unit.Classes.LinearUnitAttribute)'></a>

## LinearUnitAttribute\(LinearUnitAttribute\) Constructor

Initializes a new instance of the [LinearUnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.LinearUnitAttribute 'DiGi\.Unit\.Classes\.LinearUnitAttribute') class by copying an existing linear unit attribute\.

```csharp
public LinearUnitAttribute(DiGi.Unit.Classes.LinearUnitAttribute linearUnit);
```
#### Parameters

<a name='DiGi.Unit.Classes.LinearUnitAttribute.LinearUnitAttribute(DiGi.Unit.Classes.LinearUnitAttribute).linearUnit'></a>

`linearUnit` [LinearUnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.LinearUnitAttribute 'DiGi\.Unit\.Classes\.LinearUnitAttribute')

The source [LinearUnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.LinearUnitAttribute 'DiGi\.Unit\.Classes\.LinearUnitAttribute') to copy from\.

<a name='DiGi.Unit.Classes.LinearUnitAttribute.LinearUnitAttribute(string,string,double,double)'></a>

## LinearUnitAttribute\(string, string, double, double\) Constructor

Initializes a new instance of the [LinearUnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.LinearUnitAttribute 'DiGi\.Unit\.Classes\.LinearUnitAttribute') class with specified name, symbol, factor, and offset\.

```csharp
public LinearUnitAttribute(string? name, string? symbol, double factor, double offset);
```
#### Parameters

<a name='DiGi.Unit.Classes.LinearUnitAttribute.LinearUnitAttribute(string,string,double,double).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display name of the unit\.

<a name='DiGi.Unit.Classes.LinearUnitAttribute.LinearUnitAttribute(string,string,double,double).symbol'></a>

`symbol` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The symbol representing the unit\.

<a name='DiGi.Unit.Classes.LinearUnitAttribute.LinearUnitAttribute(string,string,double,double).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The multiplication factor used for conversion\.

<a name='DiGi.Unit.Classes.LinearUnitAttribute.LinearUnitAttribute(string,string,double,double).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The additive offset used for conversion\.

<a name='DiGi.Unit.Classes.LinearUnitAttribute.LinearUnitAttribute(System.Text.Json.Nodes.JsonObject)'></a>

## LinearUnitAttribute\(JsonObject\) Constructor

Initializes a new instance of the [LinearUnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.LinearUnitAttribute 'DiGi\.Unit\.Classes\.LinearUnitAttribute') class from a JSON object\.

```csharp
public LinearUnitAttribute(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Unit.Classes.LinearUnitAttribute.LinearUnitAttribute(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the unit configuration\.
### Properties

<a name='DiGi.Unit.Classes.LinearUnitAttribute.Offset'></a>

## LinearUnitAttribute\.Offset Property

Gets the additive offset used in the linear conversion calculation\.

```csharp
public double Offset { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.Unit.Classes.LinearUnitAttribute.Clone()'></a>

## LinearUnitAttribute\.Clone\(\) Method

Creates a clone of the current linear unit attribute\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new instance of [LinearUnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.LinearUnitAttribute 'DiGi\.Unit\.Classes\.LinearUnitAttribute') as an [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

<a name='DiGi.Unit.Classes.LinearUnitAttribute.From(double)'></a>

## LinearUnitAttribute\.From\(double\) Method

Converts a value from the base unit to the target linear unit\.

```csharp
public override double From(double value);
```
#### Parameters

<a name='DiGi.Unit.Classes.LinearUnitAttribute.From(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value in the base unit\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The converted value after applying the factor and offset\.

<a name='DiGi.Unit.Classes.LinearUnitAttribute.To(double)'></a>

## LinearUnitAttribute\.To\(double\) Method

Converts a value from the target linear unit back to the base unit\.

```csharp
public override double To(double value);
```
#### Parameters

<a name='DiGi.Unit.Classes.LinearUnitAttribute.To(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value in the target linear unit\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The converted value after removing the offset and dividing by the factor\.

<a name='DiGi.Unit.Classes.Unit'></a>

## Unit Class

Represents a measurement unit associated with an enumeration value, providing access to its attributes and conversion capabilities\.

```csharp
public class Unit : DiGi.Core.Classes.SerializableObject, DiGi.Core.Interfaces.INamedObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Unit

Implements [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Unit.Classes.Unit.Unit(System.Enum)'></a>

## Unit\(Enum\) Constructor

Initializes a new instance of the [Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit') class with the specified enumeration value\.

```csharp
public Unit(System.Enum @enum);
```
#### Parameters

<a name='DiGi.Unit.Classes.Unit.Unit(System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value representing the unit\.
### Properties

<a name='DiGi.Unit.Classes.Unit.CategoryAttribute'></a>

## Unit\.CategoryAttribute Property

Gets the category attribute associated with this unit\.

```csharp
public DiGi.Unit.Classes.CategoryAttribute? CategoryAttribute { get; }
```

#### Property Value
[CategoryAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.CategoryAttribute 'DiGi\.Unit\.Classes\.CategoryAttribute')

<a name='DiGi.Unit.Classes.Unit.Enum'></a>

## Unit\.Enum Property

Gets the underlying enumeration value of this unit\.

```csharp
public System.Enum Enum { get; }
```

#### Property Value
[System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

<a name='DiGi.Unit.Classes.Unit.Name'></a>

## Unit\.Name Property

Gets the name of the unit as defined in its attributes\.

```csharp
public string? Name { get; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Unit.Classes.Unit.Symbol'></a>

## Unit\.Symbol Property

Gets the symbol of the unit as defined in its attributes\.

```csharp
public string? Symbol { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Unit.Classes.Unit.UnitAttribute'></a>

## Unit\.UnitAttribute Property

Gets the unit attribute containing metadata and conversion logic for this unit\.

```csharp
public DiGi.Unit.Classes.UnitAttribute? UnitAttribute { get; }
```

#### Property Value
[UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute')

<a name='DiGi.Unit.Classes.Unit.UnitCategory'></a>

## Unit\.UnitCategory Property

Gets the category to which this unit belongs, or [Undefined](DiGi.Unit.Enums.md#DiGi.Unit.Enums.UnitCategory.Undefined 'DiGi\.Unit\.Enums\.UnitCategory\.Undefined') if not specified\.

```csharp
public DiGi.Unit.Enums.UnitCategory UnitCategory { get; }
```

#### Property Value
[UnitCategory](DiGi.Unit.Enums.md#DiGi.Unit.Enums.UnitCategory 'DiGi\.Unit\.Enums\.UnitCategory')
### Methods

<a name='DiGi.Unit.Classes.Unit.From(double)'></a>

## Unit\.From\(double\) Method

Converts a value from the unit's scale to its base representation\.

```csharp
public double From(double value);
```
#### Parameters

<a name='DiGi.Unit.Classes.Unit.From(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value to convert\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The converted value, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the unit attribute is missing\.

<a name='DiGi.Unit.Classes.Unit.GetEnum_TEnum_()'></a>

## Unit\.GetEnum\<TEnum\>\(\) Method

Attempts to retrieve the underlying enumeration value cast to a specific enum type\.

```csharp
public TEnum? GetEnum<TEnum>()
    where TEnum : System.Enum;
```
#### Type parameters

<a name='DiGi.Unit.Classes.Unit.GetEnum_TEnum_().TEnum'></a>

`TEnum`

The expected enumeration type\.

#### Returns
[TEnum](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit.GetEnum_TEnum_().TEnum 'DiGi\.Unit\.Classes\.Unit\.GetEnum\<TEnum\>\(\)\.TEnum')  
The enumeration value cast to [TEnum](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit.GetEnum_TEnum_().TEnum 'DiGi\.Unit\.Classes\.Unit\.GetEnum\<TEnum\>\(\)\.TEnum'), or default if the types do not match\.

<a name='DiGi.Unit.Classes.Unit.IsValid()'></a>

## Unit\.IsValid\(\) Method

Determines whether the unit is valid by checking if both its category and unit attributes are present\.

```csharp
public bool IsValid();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the unit is valid; otherwise, false\.

<a name='DiGi.Unit.Classes.Unit.To(double)'></a>

## Unit\.To\(double\) Method

Converts a base value to the unit's scale\.

```csharp
public double To(double value);
```
#### Parameters

<a name='DiGi.Unit.Classes.Unit.To(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value to convert\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The converted value, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the unit attribute is missing\.

<a name='DiGi.Unit.Classes.Unit.TryGetEnum_TEnum_(TEnum)'></a>

## Unit\.TryGetEnum\<TEnum\>\(TEnum\) Method

Attempts to extract the underlying enumeration value as a specific type\.

```csharp
public bool TryGetEnum<TEnum>(out TEnum? @enum)
    where TEnum : System.Enum;
```
#### Type parameters

<a name='DiGi.Unit.Classes.Unit.TryGetEnum_TEnum_(TEnum).TEnum'></a>

`TEnum`

The expected enumeration type\.
#### Parameters

<a name='DiGi.Unit.Classes.Unit.TryGetEnum_TEnum_(TEnum).enum'></a>

`enum` [TEnum](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit.TryGetEnum_TEnum_(TEnum).TEnum 'DiGi\.Unit\.Classes\.Unit\.TryGetEnum\<TEnum\>\(TEnum\)\.TEnum')

When this method returns, contains the enumeration value if successful; otherwise, the default value of [TEnum](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit.TryGetEnum_TEnum_(TEnum).TEnum 'DiGi\.Unit\.Classes\.Unit\.TryGetEnum\<TEnum\>\(TEnum\)\.TEnum')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the underlying enum is of type [TEnum](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit.TryGetEnum_TEnum_(TEnum).TEnum 'DiGi\.Unit\.Classes\.Unit\.TryGetEnum\<TEnum\>\(TEnum\)\.TEnum'); otherwise, false\.
### Operators

<a name='DiGi.Unit.Classes.Unit.op_ExplicitDiGi.Unit.Classes.Unit(System.Enum)'></a>

## Unit\.explicit operator Unit\(Enum\) Operator

Explicitly converts an enumeration value to a [Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit') instance\.

```csharp
public static DiGi.Unit.Classes.Unit? explicit operator DiGi.Unit.Classes.Unit?(System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Unit.Classes.Unit.op_ExplicitDiGi.Unit.Classes.Unit(System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value to convert\.

#### Returns
[Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit')  
A new [Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit') instance, or null if the provided enum is null\.

<a name='DiGi.Unit.Classes.Unit.op_ExplicitSystem.Enum(DiGi.Unit.Classes.Unit)'></a>

## Unit\.explicit operator Enum\(Unit\) Operator

Explicitly converts a [Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit') instance to its underlying enumeration value\.

```csharp
public static System.Enum? explicit operator System.Enum?(DiGi.Unit.Classes.Unit unit);
```
#### Parameters

<a name='DiGi.Unit.Classes.Unit.op_ExplicitSystem.Enum(DiGi.Unit.Classes.Unit).unit'></a>

`unit` [Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit')

The unit instance to convert\.

#### Returns
[System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')  
The underlying [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum') value, or null if the unit is null\.

<a name='DiGi.Unit.Classes.UnitAttribute'></a>

## UnitAttribute Class

Base abstract class for unit attributes, implementing [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') and [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject') to provide
standardization for units of measurement including serialization and conversion logic\.

```csharp
public abstract class UnitAttribute : System.Attribute, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.INamedObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → UnitAttribute

Derived  
↳ [FactorUnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.FactorUnitAttribute 'DiGi\.Unit\.Classes\.FactorUnitAttribute')

Implements [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject')
### Constructors

<a name='DiGi.Unit.Classes.UnitAttribute.UnitAttribute(DiGi.Unit.Classes.UnitAttribute)'></a>

## UnitAttribute\(UnitAttribute\) Constructor

Initializes a new instance of the [UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute') class by copying values from an existing [UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute')\.

```csharp
public UnitAttribute(DiGi.Unit.Classes.UnitAttribute unit);
```
#### Parameters

<a name='DiGi.Unit.Classes.UnitAttribute.UnitAttribute(DiGi.Unit.Classes.UnitAttribute).unit'></a>

`unit` [UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute')

The source unit attribute to copy from\.

<a name='DiGi.Unit.Classes.UnitAttribute.UnitAttribute(string,string)'></a>

## UnitAttribute\(string, string\) Constructor

Initializes a new instance of the [UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute') class with a specified name and symbol\.

```csharp
public UnitAttribute(string? name, string? symbol);
```
#### Parameters

<a name='DiGi.Unit.Classes.UnitAttribute.UnitAttribute(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The descriptive name of the unit\.

<a name='DiGi.Unit.Classes.UnitAttribute.UnitAttribute(string,string).symbol'></a>

`symbol` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The shorthand symbol representing the unit\.

<a name='DiGi.Unit.Classes.UnitAttribute.UnitAttribute(System.Text.Json.Nodes.JsonObject)'></a>

## UnitAttribute\(JsonObject\) Constructor

Initializes a new instance of the [UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute') class using data from a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public UnitAttribute(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Unit.Classes.UnitAttribute.UnitAttribute(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the unit attribute data\.
### Properties

<a name='DiGi.Unit.Classes.UnitAttribute.Name'></a>

## UnitAttribute\.Name Property

Gets the name of the unit\.

```csharp
public string? Name { get; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Unit.Classes.UnitAttribute.Symbol'></a>

## UnitAttribute\.Symbol Property

Gets the symbol of the unit\.

```csharp
public string? Symbol { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Unit.Classes.UnitAttribute.Clone()'></a>

## UnitAttribute\.Clone\(\) Method

Creates a clone of the current object\.

```csharp
public abstract DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned instance as an [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), or null if cloning fails\.

<a name='DiGi.Unit.Classes.UnitAttribute.From(double)'></a>

## UnitAttribute\.From\(double\) Method

Converts a value from this unit's scale to a base reference scale\.

```csharp
public abstract double From(double value);
```
#### Parameters

<a name='DiGi.Unit.Classes.UnitAttribute.From(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value to convert\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The converted value in the base reference scale\.

<a name='DiGi.Unit.Classes.UnitAttribute.FromJsonObject(System.Text.Json.Nodes.JsonObject)'></a>

## UnitAttribute\.FromJsonObject\(JsonObject\) Method

Populates the properties of this object from a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') using [DiGi\.Core\.Modify\.FromJsonObject\(DiGi\.Core\.Interfaces\.ISerializableObject,System\.Text\.Json\.Nodes\.JsonObject\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.modify.fromjsonobject#digi-core-modify-fromjsonobject(digi-core-interfaces-iserializableobject-system-text-json-nodes-jsonobject) 'DiGi\.Core\.Modify\.FromJsonObject\(DiGi\.Core\.Interfaces\.ISerializableObject,System\.Text\.Json\.Nodes\.JsonObject\)')\.

```csharp
public bool FromJsonObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Unit.Classes.UnitAttribute.FromJsonObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to populate from\.

Implements [FromJsonObject\(JsonObject\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject.fromjsonobject#digi-core-interfaces-iserializableobject-fromjsonobject(system-text-json-nodes-jsonobject) 'DiGi\.Core\.Interfaces\.ISerializableObject\.FromJsonObject\(System\.Text\.Json\.Nodes\.JsonObject\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object was successfully populated; otherwise, false\.

<a name='DiGi.Unit.Classes.UnitAttribute.To(double)'></a>

## UnitAttribute\.To\(double\) Method

Converts a value from a base reference scale to this unit's scale\.

```csharp
public abstract double To(double value);
```
#### Parameters

<a name='DiGi.Unit.Classes.UnitAttribute.To(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value in the base reference scale\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The converted value in this unit's scale\.

<a name='DiGi.Unit.Classes.UnitAttribute.ToJsonObject()'></a>

## UnitAttribute\.ToJsonObject\(\) Method

Converts this object into a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') using [DiGi\.Core\.Convert\.ToJson\(DiGi\.Core\.Interfaces\.ISerializableObject\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.convert.tojson#digi-core-convert-tojson(digi-core-interfaces-iserializableobject) 'DiGi\.Core\.Convert\.ToJson\(DiGi\.Core\.Interfaces\.ISerializableObject\)')\.

```csharp
public System.Text.Json.Nodes.JsonObject? ToJsonObject();
```

Implements [ToJsonObject\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject.tojsonobject 'DiGi\.Core\.Interfaces\.ISerializableObject\.ToJsonObject')

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') representation of the current instance\.

<a name='DiGi.Unit.Classes.UnitManager'></a>

## UnitManager Class

Manages a collection of units, providing functionality to add, retrieve, and perform conversions between different unit types\.

```csharp
public class UnitManager
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → UnitManager
### Constructors

<a name='DiGi.Unit.Classes.UnitManager.UnitManager()'></a>

## UnitManager\(\) Constructor

Initializes a new instance of the [UnitManager](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitManager 'DiGi\.Unit\.Classes\.UnitManager') class\.

```csharp
public UnitManager();
```
### Methods

<a name='DiGi.Unit.Classes.UnitManager.Add(System.Enum)'></a>

## UnitManager\.Add\(Enum\) Method

Adds a unit associated with the specified enum value to the manager\.

```csharp
public DiGi.Unit.Classes.Unit? Add(System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Unit.Classes.UnitManager.Add(System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enum value representing the unit\.

#### Returns
[Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit')  
The created or existing [Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit') object, or null if the enum is null or the unit is invalid\.

<a name='DiGi.Unit.Classes.UnitManager.AddRange(System.Reflection.Assembly)'></a>

## UnitManager\.AddRange\(Assembly\) Method

Scans the specified assembly for all Enum types decorated with a [CategoryAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.CategoryAttribute 'DiGi\.Unit\.Classes\.CategoryAttribute') and adds them to the manager\.

```csharp
public System.Collections.Generic.List<DiGi.Unit.Classes.Unit>? AddRange(System.Reflection.Assembly? assembly);
```
#### Parameters

<a name='DiGi.Unit.Classes.UnitManager.AddRange(System.Reflection.Assembly).assembly'></a>

`assembly` [System\.Reflection\.Assembly](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.assembly 'System\.Reflection\.Assembly')

The assembly to scan for unit enums\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of all successfully added [Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit') objects, or null if the assembly is null\.

<a name='DiGi.Unit.Classes.UnitManager.AddRange(System.Type)'></a>

## UnitManager\.AddRange\(Type\) Method

Adds all units defined within the specified Enum type to the manager\.

```csharp
public System.Collections.Generic.List<DiGi.Unit.Classes.Unit>? AddRange(System.Type? type);
```
#### Parameters

<a name='DiGi.Unit.Classes.UnitManager.AddRange(System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The Type of the enum containing the units\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of successfully added [Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit') objects, or null if the type is null\.

<a name='DiGi.Unit.Classes.UnitManager.From(System.Enum,double,bool)'></a>

## UnitManager\.From\(Enum, double, bool\) Method

Converts a value from the specified unit to its base representation\.

```csharp
public double From(System.Enum? @enum, double value, bool update=true);
```
#### Parameters

<a name='DiGi.Unit.Classes.UnitManager.From(System.Enum,double,bool).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enum value representing the source unit\.

<a name='DiGi.Unit.Classes.UnitManager.From(System.Enum,double,bool).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value to convert\.

<a name='DiGi.Unit.Classes.UnitManager.From(System.Enum,double,bool).update'></a>

`update` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to automatically add the unit to the manager if it is not already present\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The converted value, or double\.NaN if the unit could not be retrieved\.

<a name='DiGi.Unit.Classes.UnitManager.GetCategoryAttribute(System.Enum,bool)'></a>

## UnitManager\.GetCategoryAttribute\(Enum, bool\) Method

Retrieves the category attribute associated with the specified unit enum\.

```csharp
public DiGi.Unit.Classes.CategoryAttribute? GetCategoryAttribute(System.Enum? @enum, bool update=true);
```
#### Parameters

<a name='DiGi.Unit.Classes.UnitManager.GetCategoryAttribute(System.Enum,bool).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enum value representing the unit\.

<a name='DiGi.Unit.Classes.UnitManager.GetCategoryAttribute(System.Enum,bool).update'></a>

`update` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to automatically add the unit to the manager if it is not already present\.

#### Returns
[CategoryAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.CategoryAttribute 'DiGi\.Unit\.Classes\.CategoryAttribute')  
The [CategoryAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.CategoryAttribute 'DiGi\.Unit\.Classes\.CategoryAttribute') associated with the unit, or null if the unit could not be retrieved\.

<a name='DiGi.Unit.Classes.UnitManager.GetUnit(System.Enum,bool)'></a>

## UnitManager\.GetUnit\(Enum, bool\) Method

Retrieves the [Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit') object associated with the specified enum value\.

```csharp
public DiGi.Unit.Classes.Unit? GetUnit(System.Enum? @enum, bool update=true);
```
#### Parameters

<a name='DiGi.Unit.Classes.UnitManager.GetUnit(System.Enum,bool).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enum value representing the unit\.

<a name='DiGi.Unit.Classes.UnitManager.GetUnit(System.Enum,bool).update'></a>

`update` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to automatically add the unit to the manager if it is not already present\.

#### Returns
[Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit')  
The [Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit') object, or null if the enum is null or the unit cannot be found/created\.

<a name='DiGi.Unit.Classes.UnitManager.GetUnitAttribute(System.Enum,bool)'></a>

## UnitManager\.GetUnitAttribute\(Enum, bool\) Method

Retrieves the unit attribute associated with the specified unit enum\.

```csharp
public DiGi.Unit.Classes.UnitAttribute? GetUnitAttribute(System.Enum? @enum, bool update=true);
```
#### Parameters

<a name='DiGi.Unit.Classes.UnitManager.GetUnitAttribute(System.Enum,bool).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enum value representing the unit\.

<a name='DiGi.Unit.Classes.UnitManager.GetUnitAttribute(System.Enum,bool).update'></a>

`update` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to automatically add the unit to the manager if it is not already present\.

#### Returns
[UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute')  
The [UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute') associated with the unit, or null if the unit could not be retrieved\.

<a name='DiGi.Unit.Classes.UnitManager.To(System.Enum,double,bool)'></a>

## UnitManager\.To\(Enum, double, bool\) Method

Converts a base representation value to the specified unit\.

```csharp
public double To(System.Enum? @enum, double value, bool update=true);
```
#### Parameters

<a name='DiGi.Unit.Classes.UnitManager.To(System.Enum,double,bool).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enum value representing the target unit\.

<a name='DiGi.Unit.Classes.UnitManager.To(System.Enum,double,bool).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value to convert\.

<a name='DiGi.Unit.Classes.UnitManager.To(System.Enum,double,bool).update'></a>

`update` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to automatically add the unit to the manager if it is not already present\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The converted value, or double\.NaN if the unit could not be retrieved\.