# <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier"></a> Class CMsgDotaScenario.Types.Modifier

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDotaScenario.Types.Modifier : IMessage<CMsgDotaScenario.Types.Modifier>, IEquatable<CMsgDotaScenario.Types.Modifier>, IDeepCloneable<CMsgDotaScenario.Types.Modifier>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDotaScenario.Types.Modifier](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Modifier.md)

#### Implements

IMessage<CMsgDotaScenario.Types.Modifier\>, 
[IEquatable<CMsgDotaScenario.Types.Modifier\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDotaScenario.Types.Modifier\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CMsgDotaScenario.Types.Modifier\>\(CMsgDotaScenario.Types.Modifier, params CMsgDotaScenario.Types.Modifier\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier__ctor"></a> Modifier\(\)

```csharp
public Modifier()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier__ctor_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_"></a> Modifier\(Modifier\)

```csharp
public Modifier(CMsgDotaScenario.Types.Modifier other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Modifier](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Modifier.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_AbilityFieldNumber"></a> AbilityFieldNumber

```csharp
public const int AbilityFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_CasterFieldNumber"></a> CasterFieldNumber

```csharp
public const int CasterFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_CreateEvenIfExistingFieldNumber"></a> CreateEvenIfExistingFieldNumber

```csharp
public const int CreateEvenIfExistingFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_CreateWithoutAbilityFieldNumber"></a> CreateWithoutAbilityFieldNumber

```csharp
public const int CreateWithoutAbilityFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_CreateWithoutCasterFieldNumber"></a> CreateWithoutCasterFieldNumber

```csharp
public const int CreateWithoutCasterFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_LifetimeRemainingFieldNumber"></a> LifetimeRemainingFieldNumber

```csharp
public const int LifetimeRemainingFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_MoonshardConsumedBonusFieldNumber"></a> MoonshardConsumedBonusFieldNumber

```csharp
public const int MoonshardConsumedBonusFieldNumber = 100
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_MoonshardConsumedBonusNightVisionFieldNumber"></a> MoonshardConsumedBonusNightVisionFieldNumber

```csharp
public const int MoonshardConsumedBonusNightVisionFieldNumber = 101
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_ParentFieldNumber"></a> ParentFieldNumber

```csharp
public const int ParentFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_StackCountFieldNumber"></a> StackCountFieldNumber

```csharp
public const int StackCountFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_UltimateScepterConsumedAlchemistBonusAllStatsFieldNumber"></a> UltimateScepterConsumedAlchemistBonusAllStatsFieldNumber

```csharp
public const int UltimateScepterConsumedAlchemistBonusAllStatsFieldNumber = 120
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_UltimateScepterConsumedAlchemistBonusHealthFieldNumber"></a> UltimateScepterConsumedAlchemistBonusHealthFieldNumber

```csharp
public const int UltimateScepterConsumedAlchemistBonusHealthFieldNumber = 121
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_UltimateScepterConsumedAlchemistBonusManaFieldNumber"></a> UltimateScepterConsumedAlchemistBonusManaFieldNumber

```csharp
public const int UltimateScepterConsumedAlchemistBonusManaFieldNumber = 122
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_WardtruesightRangeFieldNumber"></a> WardtruesightRangeFieldNumber

```csharp
public const int WardtruesightRangeFieldNumber = 110
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_Ability"></a> Ability

```csharp
public CMsgDotaScenario.Types.EntityRef Ability { get; set; }
```

#### Property Value

 [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[EntityRef](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.EntityRef.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_Caster"></a> Caster

```csharp
public CMsgDotaScenario.Types.EntityRef Caster { get; set; }
```

#### Property Value

 [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[EntityRef](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.EntityRef.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_CreateEvenIfExisting"></a> CreateEvenIfExisting

```csharp
public bool CreateEvenIfExisting { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_CreateWithoutAbility"></a> CreateWithoutAbility

```csharp
public bool CreateWithoutAbility { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_CreateWithoutCaster"></a> CreateWithoutCaster

```csharp
public bool CreateWithoutCaster { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_Duration"></a> Duration

```csharp
public float Duration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_HasCreateEvenIfExisting"></a> HasCreateEvenIfExisting

```csharp
public bool HasCreateEvenIfExisting { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_HasCreateWithoutAbility"></a> HasCreateWithoutAbility

```csharp
public bool HasCreateWithoutAbility { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_HasCreateWithoutCaster"></a> HasCreateWithoutCaster

```csharp
public bool HasCreateWithoutCaster { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_HasLifetimeRemaining"></a> HasLifetimeRemaining

```csharp
public bool HasLifetimeRemaining { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_HasMoonshardConsumedBonus"></a> HasMoonshardConsumedBonus

```csharp
public bool HasMoonshardConsumedBonus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_HasMoonshardConsumedBonusNightVision"></a> HasMoonshardConsumedBonusNightVision

```csharp
public bool HasMoonshardConsumedBonusNightVision { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_HasStackCount"></a> HasStackCount

```csharp
public bool HasStackCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_HasUltimateScepterConsumedAlchemistBonusAllStats"></a> HasUltimateScepterConsumedAlchemistBonusAllStats

```csharp
public bool HasUltimateScepterConsumedAlchemistBonusAllStats { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_HasUltimateScepterConsumedAlchemistBonusHealth"></a> HasUltimateScepterConsumedAlchemistBonusHealth

```csharp
public bool HasUltimateScepterConsumedAlchemistBonusHealth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_HasUltimateScepterConsumedAlchemistBonusMana"></a> HasUltimateScepterConsumedAlchemistBonusMana

```csharp
public bool HasUltimateScepterConsumedAlchemistBonusMana { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_HasWardtruesightRange"></a> HasWardtruesightRange

```csharp
public bool HasWardtruesightRange { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_LifetimeRemaining"></a> LifetimeRemaining

```csharp
public float LifetimeRemaining { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_MoonshardConsumedBonus"></a> MoonshardConsumedBonus

```csharp
public int MoonshardConsumedBonus { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_MoonshardConsumedBonusNightVision"></a> MoonshardConsumedBonusNightVision

```csharp
public int MoonshardConsumedBonusNightVision { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_Parent"></a> Parent

```csharp
public CMsgDotaScenario.Types.EntityRef Parent { get; set; }
```

#### Property Value

 [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[EntityRef](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.EntityRef.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDotaScenario.Types.Modifier> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Modifier](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Modifier.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_StackCount"></a> StackCount

```csharp
public int StackCount { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_UltimateScepterConsumedAlchemistBonusAllStats"></a> UltimateScepterConsumedAlchemistBonusAllStats

```csharp
public int UltimateScepterConsumedAlchemistBonusAllStats { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_UltimateScepterConsumedAlchemistBonusHealth"></a> UltimateScepterConsumedAlchemistBonusHealth

```csharp
public int UltimateScepterConsumedAlchemistBonusHealth { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_UltimateScepterConsumedAlchemistBonusMana"></a> UltimateScepterConsumedAlchemistBonusMana

```csharp
public int UltimateScepterConsumedAlchemistBonusMana { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_WardtruesightRange"></a> WardtruesightRange

```csharp
public int WardtruesightRange { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_ClearCreateEvenIfExisting"></a> ClearCreateEvenIfExisting\(\)

```csharp
public void ClearCreateEvenIfExisting()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_ClearCreateWithoutAbility"></a> ClearCreateWithoutAbility\(\)

```csharp
public void ClearCreateWithoutAbility()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_ClearCreateWithoutCaster"></a> ClearCreateWithoutCaster\(\)

```csharp
public void ClearCreateWithoutCaster()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_ClearLifetimeRemaining"></a> ClearLifetimeRemaining\(\)

```csharp
public void ClearLifetimeRemaining()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_ClearMoonshardConsumedBonus"></a> ClearMoonshardConsumedBonus\(\)

```csharp
public void ClearMoonshardConsumedBonus()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_ClearMoonshardConsumedBonusNightVision"></a> ClearMoonshardConsumedBonusNightVision\(\)

```csharp
public void ClearMoonshardConsumedBonusNightVision()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_ClearStackCount"></a> ClearStackCount\(\)

```csharp
public void ClearStackCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_ClearUltimateScepterConsumedAlchemistBonusAllStats"></a> ClearUltimateScepterConsumedAlchemistBonusAllStats\(\)

```csharp
public void ClearUltimateScepterConsumedAlchemistBonusAllStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_ClearUltimateScepterConsumedAlchemistBonusHealth"></a> ClearUltimateScepterConsumedAlchemistBonusHealth\(\)

```csharp
public void ClearUltimateScepterConsumedAlchemistBonusHealth()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_ClearUltimateScepterConsumedAlchemistBonusMana"></a> ClearUltimateScepterConsumedAlchemistBonusMana\(\)

```csharp
public void ClearUltimateScepterConsumedAlchemistBonusMana()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_ClearWardtruesightRange"></a> ClearWardtruesightRange\(\)

```csharp
public void ClearWardtruesightRange()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_Clone"></a> Clone\(\)

```csharp
public CMsgDotaScenario.Types.Modifier Clone()
```

#### Returns

 [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Modifier](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Modifier.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_Equals_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_"></a> Equals\(Modifier\)

```csharp
public bool Equals(CMsgDotaScenario.Types.Modifier other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Modifier](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Modifier.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_MergeFrom_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_"></a> MergeFrom\(Modifier\)

```csharp
public void MergeFrom(CMsgDotaScenario.Types.Modifier other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Modifier](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Modifier.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Modifier_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

