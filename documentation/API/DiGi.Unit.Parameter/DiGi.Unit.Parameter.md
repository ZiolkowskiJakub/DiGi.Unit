#### [DiGi\.Unit\.Parameter](DiGi.Unit.Parameter.Overview.md 'DiGi\.Unit\.Parameter\.Overview')

## DiGi\.Unit\.Parameter Namespace
### Classes

<a name='DiGi.Unit.Parameter.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Unit.Parameter.Query.Unit(thisDiGi.Core.Parameter.Classes.EnumParameterDefinition)'></a>

## Query\.Unit\(this EnumParameterDefinition\) Method

Retrieves the measurement unit associated with the specified enum parameter definition\.

```csharp
public static DiGi.Unit.Classes.Unit? Unit(this DiGi.Core.Parameter.Classes.EnumParameterDefinition? enumParameterDefinition);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Query.Unit(thisDiGi.Core.Parameter.Classes.EnumParameterDefinition).enumParameterDefinition'></a>

`enumParameterDefinition` [DiGi\.Core\.Parameter\.Classes\.EnumParameterDefinition](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.enumparameterdefinition 'DiGi\.Core\.Parameter\.Classes\.EnumParameterDefinition')

The enum parameter definition to retrieve the unit for\.

#### Returns
[DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit')  
The [DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit') associated with the enum parameter definition, or `null` if not found\.

<a name='DiGi.Unit.Parameter.Query.Unit(thisDiGi.Core.Parameter.Classes.Parameter)'></a>

## Query\.Unit\(this Parameter\) Method

Retrieves the measurement unit associated with the specified parameter\.

```csharp
public static DiGi.Unit.Classes.Unit? Unit(this DiGi.Core.Parameter.Classes.Parameter? parameter);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Query.Unit(thisDiGi.Core.Parameter.Classes.Parameter).parameter'></a>

`parameter` [DiGi\.Core\.Parameter\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')

The parameter to retrieve the unit for\.

#### Returns
[DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit')  
The [DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit') associated with the parameter, or `null` if not found\.

<a name='DiGi.Unit.Parameter.Query.Unit(thisDiGi.Core.Parameter.Classes.ParameterDefinition)'></a>

## Query\.Unit\(this ParameterDefinition\) Method

Retrieves the measurement unit associated with the specified parameter definition\.

```csharp
public static DiGi.Unit.Classes.Unit? Unit(this DiGi.Core.Parameter.Classes.ParameterDefinition? parameterDefinition);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Query.Unit(thisDiGi.Core.Parameter.Classes.ParameterDefinition).parameterDefinition'></a>

`parameterDefinition` [DiGi\.Core\.Parameter\.Classes\.ParameterDefinition](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parameterdefinition 'DiGi\.Core\.Parameter\.Classes\.ParameterDefinition')

The parameter definition to retrieve the unit for\.

#### Returns
[DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit')  
The [DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit') associated with the parameter definition, or `null` if not found\.

<a name='DiGi.Unit.Parameter.Query.Unit(thisDiGi.Core.Parameter.Interfaces.IParameterDefinition)'></a>

## Query\.Unit\(this IParameterDefinition\) Method

Retrieves the measurement unit associated with the specified parameter definition interface\.

```csharp
public static DiGi.Unit.Classes.Unit? Unit(this DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Query.Unit(thisDiGi.Core.Parameter.Interfaces.IParameterDefinition).parameterDefinition'></a>

`parameterDefinition` [DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparameterdefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition to retrieve the unit for\.

#### Returns
[DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit')  
The [DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit') associated with the parameter definition, or `null` if not found\.

<a name='DiGi.Unit.Parameter.Query.Unit(thisDiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition)'></a>

## Query\.Unit\(this UnitExternalParameterDefinition\) Method

Retrieves the measurement unit associated with the specified unit external parameter definition\.

```csharp
public static DiGi.Unit.Classes.Unit? Unit(this DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition? unitExternalParameterDefinition);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Query.Unit(thisDiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition).unitExternalParameterDefinition'></a>

`unitExternalParameterDefinition` [UnitExternalParameterDefinition](DiGi.Unit.Parameter.Classes.md#DiGi.Unit.Parameter.Classes.UnitExternalParameterDefinition 'DiGi\.Unit\.Parameter\.Classes\.UnitExternalParameterDefinition')

The unit external parameter definition to retrieve the unit for\.

#### Returns
[DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit')  
The [DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit') associated with the unit external parameter definition, or `null` if not found\.

<a name='DiGi.Unit.Parameter.Query.Unit(thisSystem.Enum)'></a>

## Query\.Unit\(this Enum\) Method

Retrieves the measurement unit associated with the specified enumeration value\.

```csharp
public static DiGi.Unit.Classes.Unit? Unit(this System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Unit.Parameter.Query.Unit(thisSystem.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value to retrieve the unit for\.

#### Returns
[DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit')  
The [DiGi\.Unit\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.unit.classes.unit 'DiGi\.Unit\.Classes\.Unit') associated with the enumeration value, or `null` if not found\.