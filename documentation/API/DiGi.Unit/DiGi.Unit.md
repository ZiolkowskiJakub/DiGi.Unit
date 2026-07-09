#### [DiGi\.Unit](DiGi.Unit.Overview.md 'DiGi\.Unit\.Overview')

## DiGi\.Unit Namespace
### Classes

<a name='DiGi.Unit.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Unit.Create.UnitManager()'></a>

## Create\.UnitManager\(\) Method

Creates and initializes a new instance of the UnitManager by loading types from its assembly\.

```csharp
public static DiGi.Unit.Classes.UnitManager UnitManager();
```

#### Returns
[UnitManager](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitManager 'DiGi\.Unit\.Classes\.UnitManager')  
A fully initialized [UnitManager](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitManager 'DiGi\.Unit\.Classes\.UnitManager') instance\.

<a name='DiGi.Unit.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Unit.Query.CategoryAttribute(thisSystem.Enum)'></a>

## Query\.CategoryAttribute\(this Enum\) Method

Retrieves the CategoryAttribute associated with the specified enumeration type\.

```csharp
public static DiGi.Unit.Classes.CategoryAttribute? CategoryAttribute(this System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Unit.Query.CategoryAttribute(thisSystem.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value to evaluate\.

#### Returns
[CategoryAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.CategoryAttribute 'DiGi\.Unit\.Classes\.CategoryAttribute')  
The [CategoryAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.CategoryAttribute 'DiGi\.Unit\.Classes\.CategoryAttribute') attribute if found; otherwise, null\.

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,double)'></a>

## Query\.Convert\(double, Unit, Unit, double\) Method

Converts a value from one unit to another\. Returns the default value if conversion fails\.

```csharp
public static double Convert(double value, DiGi.Unit.Classes.Unit? from, DiGi.Unit.Classes.Unit? to, double defaultValue);
```
#### Parameters

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value to convert\.

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,double).from'></a>

`from` [Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit')

The source unit of measurement\.

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,double).to'></a>

`to` [Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit')

The target unit of measurement\.

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,double).defaultValue'></a>

`defaultValue` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value to return if the conversion cannot be performed\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The converted value, or [defaultValue](DiGi.Unit.md#DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,double).defaultValue 'DiGi\.Unit\.Query\.Convert\(double, DiGi\.Unit\.Classes\.Unit, DiGi\.Unit\.Classes\.Unit, double\)\.defaultValue') if conversion fails\.

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,double,double)'></a>

## Query\.Convert\(double, Unit, Unit, double, double\) Method

Converts a value from one unit to another using the specified tolerance\. Returns the default value if conversion fails\.

```csharp
public static double Convert(double value, DiGi.Unit.Classes.Unit? from, DiGi.Unit.Classes.Unit? to, double defaultValue, double tolerance);
```
#### Parameters

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,double,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value to convert\.

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,double,double).from'></a>

`from` [Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit')

The source unit of measurement\.

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,double,double).to'></a>

`to` [Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit')

The target unit of measurement\.

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,double,double).defaultValue'></a>

`defaultValue` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value to return if the conversion cannot be performed\.

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The allowed margin of error for the conversion\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The converted value, or [defaultValue](DiGi.Unit.md#DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,double,double).defaultValue 'DiGi\.Unit\.Query\.Convert\(double, DiGi\.Unit\.Classes\.Unit, DiGi\.Unit\.Classes\.Unit, double, double\)\.defaultValue') if conversion fails\.

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,double)'></a>

## Query\.Convert\(double, UnitAttribute, UnitAttribute, double\) Method

Converts a value between units defined by UnitAttributes\. Returns the default value if conversion fails\.

```csharp
public static double Convert(double value, DiGi.Unit.Classes.UnitAttribute? from, DiGi.Unit.Classes.UnitAttribute? to, double defaultValue);
```
#### Parameters

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value to convert\.

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,double).from'></a>

`from` [UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute')

The source unit attribute\.

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,double).to'></a>

`to` [UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute')

The target unit attribute\.

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,double).defaultValue'></a>

`defaultValue` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value to return if the conversion cannot be performed\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The converted value, or [defaultValue](DiGi.Unit.md#DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,double).defaultValue 'DiGi\.Unit\.Query\.Convert\(double, DiGi\.Unit\.Classes\.UnitAttribute, DiGi\.Unit\.Classes\.UnitAttribute, double\)\.defaultValue') if conversion fails\.

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,double,double)'></a>

## Query\.Convert\(double, UnitAttribute, UnitAttribute, double, double\) Method

Converts a value between units defined by UnitAttributes using the specified tolerance\. Returns the default value if conversion fails\.

```csharp
public static double Convert(double value, DiGi.Unit.Classes.UnitAttribute? from, DiGi.Unit.Classes.UnitAttribute? to, double defaultValue, double tolerance);
```
#### Parameters

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,double,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value to convert\.

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,double,double).from'></a>

`from` [UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute')

The source unit attribute\.

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,double,double).to'></a>

`to` [UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute')

The target unit attribute\.

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,double,double).defaultValue'></a>

`defaultValue` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value to return if the conversion cannot be performed\.

<a name='DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The allowed margin of error for the conversion\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The converted value, or [defaultValue](DiGi.Unit.md#DiGi.Unit.Query.Convert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,double,double).defaultValue 'DiGi\.Unit\.Query\.Convert\(double, DiGi\.Unit\.Classes\.UnitAttribute, DiGi\.Unit\.Classes\.UnitAttribute, double, double\)\.defaultValue') if conversion fails\.

<a name='DiGi.Unit.Query.Convert(double,System.Enum,System.Enum,double)'></a>

## Query\.Convert\(double, Enum, Enum, double\) Method

Converts a value between units defined by Enums\. Returns the default value if conversion fails or inputs are null\.

```csharp
public static double Convert(double value, System.Enum? from, System.Enum? to, double defaultValue);
```
#### Parameters

<a name='DiGi.Unit.Query.Convert(double,System.Enum,System.Enum,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value to convert\.

<a name='DiGi.Unit.Query.Convert(double,System.Enum,System.Enum,double).from'></a>

`from` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The source unit Enum\.

<a name='DiGi.Unit.Query.Convert(double,System.Enum,System.Enum,double).to'></a>

`to` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The target unit Enum\.

<a name='DiGi.Unit.Query.Convert(double,System.Enum,System.Enum,double).defaultValue'></a>

`defaultValue` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value to return if the conversion cannot be performed\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The converted value, or [defaultValue](DiGi.Unit.md#DiGi.Unit.Query.Convert(double,System.Enum,System.Enum,double).defaultValue 'DiGi\.Unit\.Query\.Convert\(double, System\.Enum, System\.Enum, double\)\.defaultValue') if conversion fails\.

<a name='DiGi.Unit.Query.Convert(double,System.Enum,System.Enum,double,double)'></a>

## Query\.Convert\(double, Enum, Enum, double, double\) Method

Converts a value between units defined by Enums using the specified tolerance\. Returns the default value if conversion fails or inputs are null\.

```csharp
public static double Convert(double value, System.Enum? from, System.Enum? to, double defaultValue, double tolerance);
```
#### Parameters

<a name='DiGi.Unit.Query.Convert(double,System.Enum,System.Enum,double,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value to convert\.

<a name='DiGi.Unit.Query.Convert(double,System.Enum,System.Enum,double,double).from'></a>

`from` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The source unit Enum\.

<a name='DiGi.Unit.Query.Convert(double,System.Enum,System.Enum,double,double).to'></a>

`to` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The target unit Enum\.

<a name='DiGi.Unit.Query.Convert(double,System.Enum,System.Enum,double,double).defaultValue'></a>

`defaultValue` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value to return if the conversion cannot be performed\.

<a name='DiGi.Unit.Query.Convert(double,System.Enum,System.Enum,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The allowed margin of error for the conversion\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The converted value, or [defaultValue](DiGi.Unit.md#DiGi.Unit.Query.Convert(double,System.Enum,System.Enum,double,double).defaultValue 'DiGi\.Unit\.Query\.Convert\(double, System\.Enum, System\.Enum, double, double\)\.defaultValue') if conversion fails\.

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,System.Nullable_double_)'></a>

## Query\.TryConvert\(double, Unit, Unit, Nullable\<double\>\) Method

Attempts to convert a numeric value from one unit to another\.

```csharp
public static bool TryConvert(double value, DiGi.Unit.Classes.Unit? from, DiGi.Unit.Classes.Unit? to, out System.Nullable<double> result);
```
#### Parameters

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,System.Nullable_double_).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value to be converted\.

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,System.Nullable_double_).from'></a>

`from` [Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit')

The source unit\.

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,System.Nullable_double_).to'></a>

`to` [Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit')

The target unit\.

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,System.Nullable_double_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted value if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,System.Nullable_double_,double)'></a>

## Query\.TryConvert\(double, Unit, Unit, Nullable\<double\>, double\) Method

Attempts to convert a numeric value from one unit to another and rounds the result based on the specified tolerance\.

```csharp
public static bool TryConvert(double value, DiGi.Unit.Classes.Unit? from, DiGi.Unit.Classes.Unit? to, out System.Nullable<double> result, double tolerance);
```
#### Parameters

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,System.Nullable_double_,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value to be converted\.

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,System.Nullable_double_,double).from'></a>

`from` [Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit')

The source unit\.

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,System.Nullable_double_,double).to'></a>

`to` [Unit](DiGi.Unit.Classes.md#DiGi.Unit.Classes.Unit 'DiGi\.Unit\.Classes\.Unit')

The target unit\.

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,System.Nullable_double_,double).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted and rounded value if successful; otherwise, null\.

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.Unit,DiGi.Unit.Classes.Unit,System.Nullable_double_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The precision used to round the resulting value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,System.Nullable_double_)'></a>

## Query\.TryConvert\(double, UnitAttribute, UnitAttribute, Nullable\<double\>\) Method

Attempts to convert a numeric value using the provided unit attributes\.

```csharp
public static bool TryConvert(double value, DiGi.Unit.Classes.UnitAttribute? from, DiGi.Unit.Classes.UnitAttribute? to, out System.Nullable<double> result);
```
#### Parameters

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,System.Nullable_double_).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value to be converted\.

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,System.Nullable_double_).from'></a>

`from` [UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute')

The source unit attribute\.

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,System.Nullable_double_).to'></a>

`to` [UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute')

The target unit attribute\.

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,System.Nullable_double_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted value if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,System.Nullable_double_,double)'></a>

## Query\.TryConvert\(double, UnitAttribute, UnitAttribute, Nullable\<double\>, double\) Method

Attempts to convert a numeric value using the provided unit attributes and rounds the result based on the specified tolerance\.

```csharp
public static bool TryConvert(double value, DiGi.Unit.Classes.UnitAttribute? from, DiGi.Unit.Classes.UnitAttribute? to, out System.Nullable<double> result, double tolerance);
```
#### Parameters

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,System.Nullable_double_,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value to be converted\.

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,System.Nullable_double_,double).from'></a>

`from` [UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute')

The source unit attribute\.

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,System.Nullable_double_,double).to'></a>

`to` [UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute')

The target unit attribute\.

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,System.Nullable_double_,double).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted and rounded value if successful; otherwise, null\.

<a name='DiGi.Unit.Query.TryConvert(double,DiGi.Unit.Classes.UnitAttribute,DiGi.Unit.Classes.UnitAttribute,System.Nullable_double_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The precision used to round the resulting value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Unit.Query.TryConvert(double,System.Enum,System.Enum,System.Nullable_double_)'></a>

## Query\.TryConvert\(double, Enum, Enum, Nullable\<double\>\) Method

Attempts to convert a numeric value between two units specified as enum values\.

```csharp
public static bool TryConvert(double value, System.Enum from, System.Enum to, out System.Nullable<double> result);
```
#### Parameters

<a name='DiGi.Unit.Query.TryConvert(double,System.Enum,System.Enum,System.Nullable_double_).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value to be converted\.

<a name='DiGi.Unit.Query.TryConvert(double,System.Enum,System.Enum,System.Nullable_double_).from'></a>

`from` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The source unit represented as an Enum\.

<a name='DiGi.Unit.Query.TryConvert(double,System.Enum,System.Enum,System.Nullable_double_).to'></a>

`to` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The target unit represented as an Enum\.

<a name='DiGi.Unit.Query.TryConvert(double,System.Enum,System.Enum,System.Nullable_double_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted value if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Unit.Query.TryConvert(double,System.Enum,System.Enum,System.Nullable_double_,double)'></a>

## Query\.TryConvert\(double, Enum, Enum, Nullable\<double\>, double\) Method

Attempts to convert a numeric value between two units specified as enum values and rounds the result based on the specified tolerance\.

```csharp
public static bool TryConvert(double value, System.Enum from, System.Enum to, out System.Nullable<double> result, double tolerance);
```
#### Parameters

<a name='DiGi.Unit.Query.TryConvert(double,System.Enum,System.Enum,System.Nullable_double_,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value to be converted\.

<a name='DiGi.Unit.Query.TryConvert(double,System.Enum,System.Enum,System.Nullable_double_,double).from'></a>

`from` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The source unit represented as an Enum\.

<a name='DiGi.Unit.Query.TryConvert(double,System.Enum,System.Enum,System.Nullable_double_,double).to'></a>

`to` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The target unit represented as an Enum\.

<a name='DiGi.Unit.Query.TryConvert(double,System.Enum,System.Enum,System.Nullable_double_,double).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted and rounded value if successful; otherwise, null\.

<a name='DiGi.Unit.Query.TryConvert(double,System.Enum,System.Enum,System.Nullable_double_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The precision used to round the resulting value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Unit.Query.Type(thisDiGi.Unit.Enums.UnitDataType)'></a>

## Query\.Type\(this UnitDataType\) Method

Returns the \.NET Type associated with the specified unit data type\.

```csharp
public static System.Type? Type(this DiGi.Unit.Enums.UnitDataType unitDataType);
```
#### Parameters

<a name='DiGi.Unit.Query.Type(thisDiGi.Unit.Enums.UnitDataType).unitDataType'></a>

`unitDataType` [UnitDataType](DiGi.Unit.Enums.md#DiGi.Unit.Enums.UnitDataType 'DiGi\.Unit\.Enums\.UnitDataType')

The unit data type to resolve\.

#### Returns
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')  
The corresponding [Type\(this UnitDataType\)](DiGi.Unit.md#DiGi.Unit.Query.Type(thisDiGi.Unit.Enums.UnitDataType) 'DiGi\.Unit\.Query\.Type\(this DiGi\.Unit\.Enums\.UnitDataType\)'), or null if no mapping is defined for the provided value\.

<a name='DiGi.Unit.Query.UnitAttribute(thisSystem.Enum)'></a>

## Query\.UnitAttribute\(this Enum\) Method

Retrieves the UnitAttribute associated with the provided enum value\.

```csharp
public static DiGi.Unit.Classes.UnitAttribute? UnitAttribute(this System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Unit.Query.UnitAttribute(thisSystem.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enum value to check for the attribute\.

#### Returns
[UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute')  
The [UnitAttribute](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitAttribute 'DiGi\.Unit\.Classes\.UnitAttribute') if found; otherwise, null\.

<a name='DiGi.Unit.Query.UnitDataType(thisSystem.Type)'></a>

## Query\.UnitDataType\(this Type\) Method

Determines the corresponding [UnitDataType\(this Type\)](DiGi.Unit.md#DiGi.Unit.Query.UnitDataType(thisSystem.Type) 'DiGi\.Unit\.Query\.UnitDataType\(this System\.Type\)') for a given [Type\(this UnitDataType\)](DiGi.Unit.md#DiGi.Unit.Query.Type(thisDiGi.Unit.Enums.UnitDataType) 'DiGi\.Unit\.Query\.Type\(this DiGi\.Unit\.Enums\.UnitDataType\)')\.

```csharp
public static DiGi.Unit.Enums.UnitDataType UnitDataType(this System.Type? type);
```
#### Parameters

<a name='DiGi.Unit.Query.UnitDataType(thisSystem.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to evaluate\.

#### Returns
[UnitDataType](DiGi.Unit.Enums.md#DiGi.Unit.Enums.UnitDataType 'DiGi\.Unit\.Enums\.UnitDataType')  
The matching [UnitDataType\(this Type\)](DiGi.Unit.md#DiGi.Unit.Query.UnitDataType(thisSystem.Type) 'DiGi\.Unit\.Query\.UnitDataType\(this System\.Type\)') value, or [Undefined](DiGi.Unit.Enums.md#DiGi.Unit.Enums.UnitDataType.Undefined 'DiGi\.Unit\.Enums\.UnitDataType\.Undefined') if the type is null or not a recognized numeric type\.

<a name='DiGi.Unit.Settings'></a>

## Settings Class

```csharp
public static class Settings
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Settings
### Properties

<a name='DiGi.Unit.Settings.UnitManager'></a>

## Settings\.UnitManager Property

Gets the global unit manager instance\.

```csharp
public static DiGi.Unit.Classes.UnitManager UnitManager { get; }
```

#### Property Value
[UnitManager](DiGi.Unit.Classes.md#DiGi.Unit.Classes.UnitManager 'DiGi\.Unit\.Classes\.UnitManager')