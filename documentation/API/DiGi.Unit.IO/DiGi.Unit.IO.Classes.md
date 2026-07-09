#### [DiGi\.Unit\.IO](DiGi.Unit.IO.Overview.md 'DiGi\.Unit\.IO\.Overview')

## DiGi\.Unit\.IO\.Classes Namespace
### Classes

<a name='DiGi.Unit.IO.Classes.UnitColumn'></a>

## UnitColumn Class

Represents a column in a table that is associated with a specific unit of measurement, extending the basic extended column functionality\.

```csharp
public class UnitColumn : DiGi.Core.IO.Table.Classes.ExtendedColumn
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.IO\.Table\.Classes\.Column](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.column 'DiGi\.Core\.IO\.Table\.Classes\.Column') → [DiGi\.Core\.IO\.Table\.Classes\.ExtendedColumn](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.extendedcolumn 'DiGi\.Core\.IO\.Table\.Classes\.ExtendedColumn') → UnitColumn
### Constructors

<a name='DiGi.Unit.IO.Classes.UnitColumn.UnitColumn(DiGi.Unit.IO.Classes.UnitColumn)'></a>

## UnitColumn\(UnitColumn\) Constructor

Initializes a new instance of the [UnitColumn](DiGi.Unit.IO.Classes.md#DiGi.Unit.IO.Classes.UnitColumn 'DiGi\.Unit\.IO\.Classes\.UnitColumn') class by cloning an existing [UnitColumn](DiGi.Unit.IO.Classes.md#DiGi.Unit.IO.Classes.UnitColumn 'DiGi\.Unit\.IO\.Classes\.UnitColumn') instance\.

```csharp
public UnitColumn(DiGi.Unit.IO.Classes.UnitColumn unitColumn);
```
#### Parameters

<a name='DiGi.Unit.IO.Classes.UnitColumn.UnitColumn(DiGi.Unit.IO.Classes.UnitColumn).unitColumn'></a>

`unitColumn` [UnitColumn](DiGi.Unit.IO.Classes.md#DiGi.Unit.IO.Classes.UnitColumn 'DiGi\.Unit\.IO\.Classes\.UnitColumn')

The source column to clone\.

<a name='DiGi.Unit.IO.Classes.UnitColumn.UnitColumn(string,DiGi.Unit.Classes.Unit,string,string)'></a>

## UnitColumn\(string, Unit, string, string\) Constructor

Initializes a new instance of the [UnitColumn](DiGi.Unit.IO.Classes.md#DiGi.Unit.IO.Classes.UnitColumn 'DiGi\.Unit\.IO\.Classes\.UnitColumn') class with specified name, unit, category, and description, defaulting the type to double\.

```csharp
public UnitColumn(string? name, DiGi.Unit.Classes.Unit? unit, string? category, string? description);
```
#### Parameters

<a name='DiGi.Unit.IO.Classes.UnitColumn.UnitColumn(string,DiGi.Unit.Classes.Unit,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the column\.

<a name='DiGi.Unit.IO.Classes.UnitColumn.UnitColumn(string,DiGi.Unit.Classes.Unit,string,string).unit'></a>

`unit` [DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit')

The unit associated with the column\.

<a name='DiGi.Unit.IO.Classes.UnitColumn.UnitColumn(string,DiGi.Unit.Classes.Unit,string,string).category'></a>

`category` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The category metadata for the column\.

<a name='DiGi.Unit.IO.Classes.UnitColumn.UnitColumn(string,DiGi.Unit.Classes.Unit,string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description metadata for the column\.

<a name='DiGi.Unit.IO.Classes.UnitColumn.UnitColumn(string,DiGi.Unit.Classes.Unit,string,string,DiGi.Unit.Enums.UnitDataType)'></a>

## UnitColumn\(string, Unit, string, string, UnitDataType\) Constructor

Initializes a new instance of the [UnitColumn](DiGi.Unit.IO.Classes.md#DiGi.Unit.IO.Classes.UnitColumn 'DiGi\.Unit\.IO\.Classes\.UnitColumn') class with specified name, unit, category, description, and specific unit data type\.

```csharp
public UnitColumn(string? name, DiGi.Unit.Classes.Unit? unit, string? category, string? description, DiGi.Unit.Enums.UnitDataType unitDataType);
```
#### Parameters

<a name='DiGi.Unit.IO.Classes.UnitColumn.UnitColumn(string,DiGi.Unit.Classes.Unit,string,string,DiGi.Unit.Enums.UnitDataType).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the column\.

<a name='DiGi.Unit.IO.Classes.UnitColumn.UnitColumn(string,DiGi.Unit.Classes.Unit,string,string,DiGi.Unit.Enums.UnitDataType).unit'></a>

`unit` [DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit')

The unit associated with the column\.

<a name='DiGi.Unit.IO.Classes.UnitColumn.UnitColumn(string,DiGi.Unit.Classes.Unit,string,string,DiGi.Unit.Enums.UnitDataType).category'></a>

`category` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The category metadata for the column\.

<a name='DiGi.Unit.IO.Classes.UnitColumn.UnitColumn(string,DiGi.Unit.Classes.Unit,string,string,DiGi.Unit.Enums.UnitDataType).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description metadata for the column\.

<a name='DiGi.Unit.IO.Classes.UnitColumn.UnitColumn(string,DiGi.Unit.Classes.Unit,string,string,DiGi.Unit.Enums.UnitDataType).unitDataType'></a>

`unitDataType` [DiGi\.Unit\.Enums\.UnitDataType](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.enums.unitdatatype 'DiGi\.Unit\.Enums\.UnitDataType')

The data type of the unit column\.

<a name='DiGi.Unit.IO.Classes.UnitColumn.UnitColumn(System.Text.Json.Nodes.JsonObject)'></a>

## UnitColumn\(JsonObject\) Constructor

Initializes a new instance of the [UnitColumn](DiGi.Unit.IO.Classes.md#DiGi.Unit.IO.Classes.UnitColumn 'DiGi\.Unit\.IO\.Classes\.UnitColumn') class from a JSON object\.

```csharp
public UnitColumn(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Unit.IO.Classes.UnitColumn.UnitColumn(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the column data\.
### Properties

<a name='DiGi.Unit.IO.Classes.UnitColumn.Unit'></a>

## UnitColumn\.Unit Property

Gets or sets the unit associated with this column\.

```csharp
public DiGi.Unit.Classes.Unit? Unit { get; set; }
```

#### Property Value
[DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit')

<a name='DiGi.Unit.IO.Classes.UnitColumn.UnitDataType'></a>

## UnitColumn\.UnitDataType Property

Gets the unit data type based on the underlying type of the column\.

```csharp
public DiGi.Unit.Enums.UnitDataType UnitDataType { get; }
```

#### Property Value
[DiGi\.Unit\.Enums\.UnitDataType](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.enums.unitdatatype 'DiGi\.Unit\.Enums\.UnitDataType')