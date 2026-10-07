# <a id="Divine_Entity_Entities_Abilities_Components_AbilityLevelingBonus"></a> Class AbilityLevelingBonus

Namespace: [Divine.Entity.Entities.Abilities.Components](Divine.Entity.Entities.Abilities.Components.md)  
Assembly: Divine.dll  

```csharp
public sealed class AbilityLevelingBonus
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AbilityLevelingBonus](Divine.Entity.Entities.Abilities.Components.AbilityLevelingBonus.md)

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
[EnumerableExtensions.In<AbilityLevelingBonus\>\(AbilityLevelingBonus, params AbilityLevelingBonus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityLevelingBonus_AghanimId"></a> AghanimId

```csharp
public uint AghanimId { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityLevelingBonus_HasValues"></a> HasValues

```csharp
public bool HasValues { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityLevelingBonus_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityLevelingBonus_Operation"></a> Operation

```csharp
public SpecialBonusOperation Operation { get; }
```

#### Property Value

 [SpecialBonusOperation](Divine.Entity.Entities.Abilities.Components.SpecialBonusOperation.md)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityLevelingBonus_Value"></a> Value

```csharp
public float Value { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityLevelingBonus_Values"></a> Values

```csharp
public IEnumerable<float> Values { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

## Methods

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityLevelingBonus_GetValue_System_UInt32_"></a> GetValue\(uint\)

```csharp
public float GetValue(uint index)
```

#### Parameters

`index` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityLevelingBonus_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

