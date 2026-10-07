# <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData"></a> Class AbilitySpecialData

Namespace: [Divine.Entity.Entities.Abilities.Components](Divine.Entity.Entities.Abilities.Components.md)  
Assembly: Divine.dll  

```csharp
public sealed class AbilitySpecialData
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AbilitySpecialData](Divine.Entity.Entities.Abilities.Components.AbilitySpecialData.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<AbilitySpecialData\>\(AbilitySpecialData, params AbilitySpecialData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Fields

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_Native"></a> Native

```csharp
public readonly nint Native
```

#### Field Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

## Properties

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_Bonus"></a> Bonus

```csharp
public AbilitySpecialBonus Bonus { get; }
```

#### Property Value

 [AbilitySpecialBonus](Divine.Entity.Entities.Abilities.Components.AbilitySpecialBonus.md)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_Count"></a> Count

```csharp
public uint Count { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_DamageType"></a> DamageType

```csharp
public DamageType DamageType { get; }
```

#### Property Value

 [DamageType](Divine.Entity.Entities.Abilities.Components.DamageType.md)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_FacetBonus"></a> FacetBonus

```csharp
public AbilityFacetBonus FacetBonus { get; }
```

#### Property Value

 [AbilityFacetBonus](Divine.Entity.Entities.Abilities.Components.AbilityFacetBonus.md)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_IsAffectedByAoEIncrease"></a> IsAffectedByAoEIncrease

```csharp
public bool IsAffectedByAoEIncrease { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_IsAffectedByCurio"></a> IsAffectedByCurio

```csharp
public bool IsAffectedByCurio { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_IsDynamicValue"></a> IsDynamicValue

```csharp
public bool IsDynamicValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_IsRequiresScepter"></a> IsRequiresScepter

```csharp
public bool IsRequiresScepter { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_IsRequiresShard"></a> IsRequiresShard

```csharp
public bool IsRequiresShard { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_IsSpellDamage"></a> IsSpellDamage

```csharp
public bool IsSpellDamage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_RequiredFacet"></a> RequiredFacet

```csharp
public StringToken RequiredFacet { get; }
```

#### Property Value

 [StringToken](Divine.StringToken.StringToken.md)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_ScepterBonus"></a> ScepterBonus

```csharp
public AbilityLevelingBonus ScepterBonus { get; }
```

#### Property Value

 [AbilityLevelingBonus](Divine.Entity.Entities.Abilities.Components.AbilityLevelingBonus.md)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_ShardBonus"></a> ShardBonus

```csharp
public AbilityLevelingBonus ShardBonus { get; }
```

#### Property Value

 [AbilityLevelingBonus](Divine.Entity.Entities.Abilities.Components.AbilityLevelingBonus.md)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_Value"></a> Value

```csharp
public float Value { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_Values"></a> Values

```csharp
public IEnumerable<float> Values { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_ValuesText"></a> ValuesText

```csharp
public string ValuesText { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_GetValue_System_UInt32_"></a> GetValue\(uint\)

```csharp
public float GetValue(uint index)
```

#### Parameters

`index` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilitySpecialData_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

