#### [DiGi\.Unit\.Parameter](DiGi.Unit.Parameter.Overview.md 'DiGi\.Unit\.Parameter\.Overview')

## DiGi\.Unit\.Parameter\.Classes Namespace
### Classes

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition'></a>

## UnitExternalParameterDefinition Class

Represents an external parameter definition that includes a unit of measurement\.

```csharp
public class UnitExternalParameterDefinition : DiGi.Core.Parameter.Classes.ExternalParameterDefinition
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParameterDefinition](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parameterdefinition 'DiGi\.Core\.Parameter\.Classes\.ParameterDefinition') → [DiGi\.Core\.Parameter\.Classes\.ComplexParameterDefinition](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.complexparameterdefinition 'DiGi\.Core\.Parameter\.Classes\.ComplexParameterDefinition') → [DiGi\.Core\.Parameter\.Classes\.ExternalParameterDefinition](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.externalparameterdefinition 'DiGi\.Core\.Parameter\.Classes\.ExternalParameterDefinition') → UnitExternalParameterDefinition
### Constructors

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition()'></a>

## UnitExternalParameterDefinition\(\) Constructor

Initializes a new instance of the [UnitExternalParameterDefinition](DiGi.Unit.Parameter.Classes.md#DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition 'DiGi\.Unit\.Parameter\.Classes\.UnitExternalParameterDefinition') class\.

```csharp
public UnitExternalParameterDefinition();
```

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition)'></a>

## UnitExternalParameterDefinition\(UnitExternalParameterDefinition\) Constructor

Initializes a new instance of the [UnitExternalParameterDefinition](DiGi.Unit.Parameter.Classes.md#DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition 'DiGi\.Unit\.Parameter\.Classes\.UnitExternalParameterDefinition') class by copying another instance\.

```csharp
public UnitExternalParameterDefinition(DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition? unitExternalParameterDefinition);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition).unitExternalParameterDefinition'></a>

`unitExternalParameterDefinition` [UnitExternalParameterDefinition](DiGi.Unit.Parameter.Classes.md#DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition 'DiGi\.Unit\.Parameter\.Classes\.UnitExternalParameterDefinition')

The instance to copy from\.

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string,DiGi.Unit.Classes.Unit)'></a>

## UnitExternalParameterDefinition\(Guid, string, string, AccessType, ParameterValue, AssociatedTypes, string, Unit\) Constructor

Initializes a new instance of the [UnitExternalParameterDefinition](DiGi.Unit.Parameter.Classes.md#DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition 'DiGi\.Unit\.Parameter\.Classes\.UnitExternalParameterDefinition') class with full parameters and unit\.

```csharp
public UnitExternalParameterDefinition(System.Guid guid, string? name, string? description, DiGi.Core.Parameter.Enums.AccessType accessType, DiGi.Core.Parameter.Classes.ParameterValue? parameterValue, DiGi.Core.Parameter.Classes.AssociatedTypes associatedTypes, string? groupName, DiGi.Unit.Classes.Unit? unit=null);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string,DiGi.Unit.Classes.Unit).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier\.

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string,DiGi.Unit.Classes.Unit).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name\.

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string,DiGi.Unit.Classes.Unit).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description\.

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string,DiGi.Unit.Classes.Unit).accessType'></a>

`accessType` [DiGi\.Core\.Parameter\.Enums\.AccessType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.enums.accesstype 'DiGi\.Core\.Parameter\.Enums\.AccessType')

The access type\.

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string,DiGi.Unit.Classes.Unit).parameterValue'></a>

`parameterValue` [DiGi\.Core\.Parameter\.Classes\.ParameterValue](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametervalue 'DiGi\.Core\.Parameter\.Classes\.ParameterValue')

The parameter value\.

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string,DiGi.Unit.Classes.Unit).associatedTypes'></a>

`associatedTypes` [DiGi\.Core\.Parameter\.Classes\.AssociatedTypes](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.associatedtypes 'DiGi\.Core\.Parameter\.Classes\.AssociatedTypes')

The associated types\.

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string,DiGi.Unit.Classes.Unit).groupName'></a>

`groupName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The group name\.

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string,DiGi.Unit.Classes.Unit).unit'></a>

`unit` [DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit')

The unit of measurement\.

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string,System.Enum)'></a>

## UnitExternalParameterDefinition\(Guid, string, string, AccessType, ParameterValue, AssociatedTypes, string, Enum\) Constructor

Initializes a new instance of the [UnitExternalParameterDefinition](DiGi.Unit.Parameter.Classes.md#DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition 'DiGi\.Unit\.Parameter\.Classes\.UnitExternalParameterDefinition') class with full parameters and unit enumeration value\.

```csharp
public UnitExternalParameterDefinition(System.Guid guid, string? name, string? description, DiGi.Core.Parameter.Enums.AccessType accessType, DiGi.Core.Parameter.Classes.ParameterValue? parameterValue, DiGi.Core.Parameter.Classes.AssociatedTypes associatedTypes, string? groupName, System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string,System.Enum).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier\.

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string,System.Enum).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name\.

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string,System.Enum).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description\.

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string,System.Enum).accessType'></a>

`accessType` [DiGi\.Core\.Parameter\.Enums\.AccessType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.enums.accesstype 'DiGi\.Core\.Parameter\.Enums\.AccessType')

The access type\.

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string,System.Enum).parameterValue'></a>

`parameterValue` [DiGi\.Core\.Parameter\.Classes\.ParameterValue](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametervalue 'DiGi\.Core\.Parameter\.Classes\.ParameterValue')

The parameter value\.

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string,System.Enum).associatedTypes'></a>

`associatedTypes` [DiGi\.Core\.Parameter\.Classes\.AssociatedTypes](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.associatedtypes 'DiGi\.Core\.Parameter\.Classes\.AssociatedTypes')

The associated types\.

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string,System.Enum).groupName'></a>

`groupName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The group name\.

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Core.Parameter.Classes.ParameterValue,DiGi.Core.Parameter.Classes.AssociatedTypes,string,System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The unit enumeration value\.

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Text.Json.Nodes.JsonObject)'></a>

## UnitExternalParameterDefinition\(JsonObject\) Constructor

Initializes a new instance of the [UnitExternalParameterDefinition](DiGi.Unit.Parameter.Classes.md#DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition 'DiGi\.Unit\.Parameter\.Classes\.UnitExternalParameterDefinition') class from a JSON object\.

```csharp
public UnitExternalParameterDefinition(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.UnitExternalParameterDefinition(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing parameter definition data\.
### Properties

<a name='DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition.Unit'></a>

## UnitExternalParameterDefinition\.Unit Property

Gets the unit of measurement associated with the parameter definition\.

```csharp
public DiGi.Unit.Classes.Unit? Unit { get; }
```

#### Property Value
[DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit')

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties'></a>

## UnitParameterProperties Class

Contains metadata and properties for a parameter definition, including unit of measurement\.

```csharp
public class UnitParameterProperties : DiGi.Core.Parameter.Classes.ParameterProperties
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → [DiGi\.Core\.Parameter\.Classes\.ParameterProperties](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parameterproperties 'DiGi\.Core\.Parameter\.Classes\.ParameterProperties') → UnitParameterProperties
### Constructors

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,DiGi.Unit.Classes.Unit)'></a>

## UnitParameterProperties\(string, Unit\) Constructor

Initializes a new instance of the [UnitParameterProperties](DiGi.Unit.Parameter.Classes.md#DiGi.Unit.Parameter.Classes.UnitParameterProperties 'DiGi\.Unit\.Parameter\.Classes\.UnitParameterProperties') class with a name and unit\.

```csharp
public UnitParameterProperties(string? name, DiGi.Unit.Classes.Unit? unit=null);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,DiGi.Unit.Classes.Unit).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,DiGi.Unit.Classes.Unit).unit'></a>

`unit` [DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit')

The unit of measurement associated with the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Unit.Classes.Unit)'></a>

## UnitParameterProperties\(string, string, AccessType, Unit\) Constructor

Initializes a new instance of the [UnitParameterProperties](DiGi.Unit.Parameter.Classes.md#DiGi.Unit.Parameter.Classes.UnitParameterProperties 'DiGi\.Unit\.Parameter\.Classes\.UnitParameterProperties') class with a name, description, access type, and unit\.

```csharp
public UnitParameterProperties(string? name, string? description, DiGi.Core.Parameter.Enums.AccessType accessType, DiGi.Unit.Classes.Unit? unit=null);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Unit.Classes.Unit).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Unit.Classes.Unit).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Unit.Classes.Unit).accessType'></a>

`accessType` [DiGi\.Core\.Parameter\.Enums\.AccessType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.enums.accesstype 'DiGi\.Core\.Parameter\.Enums\.AccessType')

The access type of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Unit.Classes.Unit).unit'></a>

`unit` [DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit')

The unit of measurement associated with the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,DiGi.Core.Parameter.Enums.AccessType,System.Enum)'></a>

## UnitParameterProperties\(string, string, AccessType, Enum\) Constructor

Initializes a new instance of the [UnitParameterProperties](DiGi.Unit.Parameter.Classes.md#DiGi.Unit.Parameter.Classes.UnitParameterProperties 'DiGi\.Unit\.Parameter\.Classes\.UnitParameterProperties') class with a name, description, access type, and unit enumeration value\.

```csharp
public UnitParameterProperties(string? name, string? description, DiGi.Core.Parameter.Enums.AccessType accessType, System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,DiGi.Core.Parameter.Enums.AccessType,System.Enum).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,DiGi.Core.Parameter.Enums.AccessType,System.Enum).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,DiGi.Core.Parameter.Enums.AccessType,System.Enum).accessType'></a>

`accessType` [DiGi\.Core\.Parameter\.Enums\.AccessType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.enums.accesstype 'DiGi\.Core\.Parameter\.Enums\.AccessType')

The access type of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,DiGi.Core.Parameter.Enums.AccessType,System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The unit enumeration value associated with the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,DiGi.Unit.Classes.Unit)'></a>

## UnitParameterProperties\(string, string, Unit\) Constructor

Initializes a new instance of the [UnitParameterProperties](DiGi.Unit.Parameter.Classes.md#DiGi.Unit.Parameter.Classes.UnitParameterProperties 'DiGi\.Unit\.Parameter\.Classes\.UnitParameterProperties') class with a unique identifier, name, and unit\.

```csharp
public UnitParameterProperties(string? uniqueId, string? name, DiGi.Unit.Classes.Unit? unit=null);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,DiGi.Unit.Classes.Unit).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,DiGi.Unit.Classes.Unit).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,DiGi.Unit.Classes.Unit).unit'></a>

`unit` [DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit')

The unit of measurement associated with the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Unit.Classes.Unit)'></a>

## UnitParameterProperties\(string, string, string, AccessType, Unit\) Constructor

Initializes a new instance of the [UnitParameterProperties](DiGi.Unit.Parameter.Classes.md#DiGi.Unit.Parameter.Classes.UnitParameterProperties 'DiGi\.Unit\.Parameter\.Classes\.UnitParameterProperties') class with a unique identifier, name, description, access type, and unit\.

```csharp
public UnitParameterProperties(string? uniqueId, string? name, string? description, DiGi.Core.Parameter.Enums.AccessType accessType, DiGi.Unit.Classes.Unit? unit=null);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Unit.Classes.Unit).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Unit.Classes.Unit).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Unit.Classes.Unit).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Unit.Classes.Unit).accessType'></a>

`accessType` [DiGi\.Core\.Parameter\.Enums\.AccessType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.enums.accesstype 'DiGi\.Core\.Parameter\.Enums\.AccessType')

The access type of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,DiGi.Unit.Classes.Unit).unit'></a>

`unit` [DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit')

The unit of measurement associated with the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string,DiGi.Unit.Classes.Unit)'></a>

## UnitParameterProperties\(string, string, string, AccessType, string, Unit\) Constructor

Initializes a new instance of the [UnitParameterProperties](DiGi.Unit.Parameter.Classes.md#DiGi.Unit.Parameter.Classes.UnitParameterProperties 'DiGi\.Unit\.Parameter\.Classes\.UnitParameterProperties') class with full metadata including group name and unit\.

```csharp
public UnitParameterProperties(string? uniqueId, string? name, string? description, DiGi.Core.Parameter.Enums.AccessType accessType, string? groupName, DiGi.Unit.Classes.Unit? unit=null);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string,DiGi.Unit.Classes.Unit).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string,DiGi.Unit.Classes.Unit).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string,DiGi.Unit.Classes.Unit).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string,DiGi.Unit.Classes.Unit).accessType'></a>

`accessType` [DiGi\.Core\.Parameter\.Enums\.AccessType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.enums.accesstype 'DiGi\.Core\.Parameter\.Enums\.AccessType')

The access type of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string,DiGi.Unit.Classes.Unit).groupName'></a>

`groupName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the group to which the parameter belongs\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string,DiGi.Unit.Classes.Unit).unit'></a>

`unit` [DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit')

The unit of measurement associated with the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string,System.Enum)'></a>

## UnitParameterProperties\(string, string, string, AccessType, string, Enum\) Constructor

Initializes a new instance of the [UnitParameterProperties](DiGi.Unit.Parameter.Classes.md#DiGi.Unit.Parameter.Classes.UnitParameterProperties 'DiGi\.Unit\.Parameter\.Classes\.UnitParameterProperties') class with full metadata including group name and unit enumeration value\.

```csharp
public UnitParameterProperties(string? uniqueId, string? name, string? description, DiGi.Core.Parameter.Enums.AccessType accessType, string? groupName, System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string,System.Enum).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string,System.Enum).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string,System.Enum).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string,System.Enum).accessType'></a>

`accessType` [DiGi\.Core\.Parameter\.Enums\.AccessType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.enums.accesstype 'DiGi\.Core\.Parameter\.Enums\.AccessType')

The access type of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string,System.Enum).groupName'></a>

`groupName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the group to which the parameter belongs\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,string,System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The unit enumeration value associated with the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,System.Enum)'></a>

## UnitParameterProperties\(string, string, string, AccessType, Enum\) Constructor

Initializes a new instance of the [UnitParameterProperties](DiGi.Unit.Parameter.Classes.md#DiGi.Unit.Parameter.Classes.UnitParameterProperties 'DiGi\.Unit\.Parameter\.Classes\.UnitParameterProperties') class with a unique identifier, name, description, access type, and unit enumeration value\.

```csharp
public UnitParameterProperties(string? uniqueId, string? name, string? description, DiGi.Core.Parameter.Enums.AccessType accessType, System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,System.Enum).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,System.Enum).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,System.Enum).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,System.Enum).accessType'></a>

`accessType` [DiGi\.Core\.Parameter\.Enums\.AccessType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.enums.accesstype 'DiGi\.Core\.Parameter\.Enums\.AccessType')

The access type of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Core.Parameter.Enums.AccessType,System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The unit enumeration value associated with the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Unit.Classes.Unit)'></a>

## UnitParameterProperties\(string, string, string, Unit\) Constructor

Initializes a new instance of the [UnitParameterProperties](DiGi.Unit.Parameter.Classes.md#DiGi.Unit.Parameter.Classes.UnitParameterProperties 'DiGi\.Unit\.Parameter\.Classes\.UnitParameterProperties') class with a unique identifier, name, description, and unit\.

```csharp
public UnitParameterProperties(string? uniqueId, string? name, string? description, DiGi.Unit.Classes.Unit? unit=null);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Unit.Classes.Unit).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Unit.Classes.Unit).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Unit.Classes.Unit).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,DiGi.Unit.Classes.Unit).unit'></a>

`unit` [DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit')

The unit of measurement associated with the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,System.Enum)'></a>

## UnitParameterProperties\(string, string, string, Enum\) Constructor

Initializes a new instance of the [UnitParameterProperties](DiGi.Unit.Parameter.Classes.md#DiGi.Unit.Parameter.Classes.UnitParameterProperties 'DiGi\.Unit\.Parameter\.Classes\.UnitParameterProperties') class with a unique identifier, name, description, and unit enumeration value\.

```csharp
public UnitParameterProperties(string? uniqueId, string? name, string? description, System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,System.Enum).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,System.Enum).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,System.Enum).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,string,System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The unit enumeration value associated with the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,System.Enum)'></a>

## UnitParameterProperties\(string, string, Enum\) Constructor

Initializes a new instance of the [UnitParameterProperties](DiGi.Unit.Parameter.Classes.md#DiGi.Unit.Parameter.Classes.UnitParameterProperties 'DiGi\.Unit\.Parameter\.Classes\.UnitParameterProperties') class with a unique identifier, name, and unit enumeration value\.

```csharp
public UnitParameterProperties(string? uniqueId, string? name, System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,System.Enum).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,System.Enum).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,string,System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The unit enumeration value associated with the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,System.Enum)'></a>

## UnitParameterProperties\(string, Enum\) Constructor

Initializes a new instance of the [UnitParameterProperties](DiGi.Unit.Parameter.Classes.md#DiGi.Unit.Parameter.Classes.UnitParameterProperties 'DiGi\.Unit\.Parameter\.Classes\.UnitParameterProperties') class with a name and unit enumeration value\.

```csharp
public UnitParameterProperties(string? name, System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,System.Enum).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.UnitParameterProperties(string,System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The unit enumeration value associated with the parameter\.
### Properties

<a name='DiGi.Unit.Parameter.Classes.UnitParameterProperties.Unit'></a>

## UnitParameterProperties\.Unit Property

Gets the unit of measurement associated with the parameter\.

```csharp
public DiGi.Unit.Classes.Unit? Unit { get; }
```

#### Property Value
[DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit')