# <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability"></a> Class CMsgBotWorldState.Types.Ability

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBotWorldState.Types.Ability : IMessage<CMsgBotWorldState.Types.Ability>, IEquatable<CMsgBotWorldState.Types.Ability>, IDeepCloneable<CMsgBotWorldState.Types.Ability>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBotWorldState.Types.Ability](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Ability.md)

#### Implements

IMessage<CMsgBotWorldState.Types.Ability\>, 
[IEquatable<CMsgBotWorldState.Types.Ability\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBotWorldState.Types.Ability\>, 
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
[EnumerableExtensions.In<CMsgBotWorldState.Types.Ability\>\(CMsgBotWorldState.Types.Ability, params CMsgBotWorldState.Types.Ability\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability__ctor"></a> Ability\(\)

```csharp
public Ability()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability__ctor_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_"></a> Ability\(Ability\)

```csharp
public Ability(CMsgBotWorldState.Types.Ability other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Ability](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Ability.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_AbilityIdFieldNumber"></a> AbilityIdFieldNumber

```csharp
public const int AbilityIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_CasterHandleFieldNumber"></a> CasterHandleFieldNumber

```csharp
public const int CasterHandleFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_CastRangeFieldNumber"></a> CastRangeFieldNumber

```csharp
public const int CastRangeFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ChannelTimeFieldNumber"></a> ChannelTimeFieldNumber

```csharp
public const int ChannelTimeFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ChargesFieldNumber"></a> ChargesFieldNumber

```csharp
public const int ChargesFieldNumber = 30
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_CooldownRemainingFieldNumber"></a> CooldownRemainingFieldNumber

```csharp
public const int CooldownRemainingFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_HandleFieldNumber"></a> HandleFieldNumber

```csharp
public const int HandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_IsActivatedFieldNumber"></a> IsActivatedFieldNumber

```csharp
public const int IsActivatedFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_IsChannelingFieldNumber"></a> IsChannelingFieldNumber

```csharp
public const int IsChannelingFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_IsCombinedLockedFieldNumber"></a> IsCombinedLockedFieldNumber

```csharp
public const int IsCombinedLockedFieldNumber = 40
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_IsFullyCastableFieldNumber"></a> IsFullyCastableFieldNumber

```csharp
public const int IsFullyCastableFieldNumber = 25
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_IsInAbilityPhaseFieldNumber"></a> IsInAbilityPhaseFieldNumber

```csharp
public const int IsInAbilityPhaseFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_IsStolenFieldNumber"></a> IsStolenFieldNumber

```csharp
public const int IsStolenFieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_IsToggledFieldNumber"></a> IsToggledFieldNumber

```csharp
public const int IsToggledFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_LevelFieldNumber"></a> LevelFieldNumber

```csharp
public const int LevelFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_PowerTreadsStatFieldNumber"></a> PowerTreadsStatFieldNumber

```csharp
public const int PowerTreadsStatFieldNumber = 50
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_SecondaryChargesFieldNumber"></a> SecondaryChargesFieldNumber

```csharp
public const int SecondaryChargesFieldNumber = 31
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_SlotFieldNumber"></a> SlotFieldNumber

```csharp
public const int SlotFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_AbilityId"></a> AbilityId

```csharp
public int AbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_CasterHandle"></a> CasterHandle

```csharp
public uint CasterHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_CastRange"></a> CastRange

```csharp
public uint CastRange { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ChannelTime"></a> ChannelTime

```csharp
public float ChannelTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_Charges"></a> Charges

```csharp
public uint Charges { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_CooldownRemaining"></a> CooldownRemaining

```csharp
public float CooldownRemaining { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_Handle"></a> Handle

```csharp
public uint Handle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_HasAbilityId"></a> HasAbilityId

```csharp
public bool HasAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_HasCasterHandle"></a> HasCasterHandle

```csharp
public bool HasCasterHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_HasCastRange"></a> HasCastRange

```csharp
public bool HasCastRange { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_HasChannelTime"></a> HasChannelTime

```csharp
public bool HasChannelTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_HasCharges"></a> HasCharges

```csharp
public bool HasCharges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_HasCooldownRemaining"></a> HasCooldownRemaining

```csharp
public bool HasCooldownRemaining { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_HasHandle"></a> HasHandle

```csharp
public bool HasHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_HasIsActivated"></a> HasIsActivated

```csharp
public bool HasIsActivated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_HasIsChanneling"></a> HasIsChanneling

```csharp
public bool HasIsChanneling { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_HasIsCombinedLocked"></a> HasIsCombinedLocked

```csharp
public bool HasIsCombinedLocked { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_HasIsFullyCastable"></a> HasIsFullyCastable

```csharp
public bool HasIsFullyCastable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_HasIsInAbilityPhase"></a> HasIsInAbilityPhase

```csharp
public bool HasIsInAbilityPhase { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_HasIsStolen"></a> HasIsStolen

```csharp
public bool HasIsStolen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_HasIsToggled"></a> HasIsToggled

```csharp
public bool HasIsToggled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_HasLevel"></a> HasLevel

```csharp
public bool HasLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_HasPowerTreadsStat"></a> HasPowerTreadsStat

```csharp
public bool HasPowerTreadsStat { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_HasSecondaryCharges"></a> HasSecondaryCharges

```csharp
public bool HasSecondaryCharges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_HasSlot"></a> HasSlot

```csharp
public bool HasSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_IsActivated"></a> IsActivated

```csharp
public bool IsActivated { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_IsChanneling"></a> IsChanneling

```csharp
public bool IsChanneling { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_IsCombinedLocked"></a> IsCombinedLocked

```csharp
public bool IsCombinedLocked { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_IsFullyCastable"></a> IsFullyCastable

```csharp
public bool IsFullyCastable { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_IsInAbilityPhase"></a> IsInAbilityPhase

```csharp
public bool IsInAbilityPhase { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_IsStolen"></a> IsStolen

```csharp
public bool IsStolen { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_IsToggled"></a> IsToggled

```csharp
public bool IsToggled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_Level"></a> Level

```csharp
public uint Level { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBotWorldState.Types.Ability> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Ability](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Ability.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_PowerTreadsStat"></a> PowerTreadsStat

```csharp
public int PowerTreadsStat { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_SecondaryCharges"></a> SecondaryCharges

```csharp
public uint SecondaryCharges { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_Slot"></a> Slot

```csharp
public uint Slot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ClearAbilityId"></a> ClearAbilityId\(\)

```csharp
public void ClearAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ClearCasterHandle"></a> ClearCasterHandle\(\)

```csharp
public void ClearCasterHandle()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ClearCastRange"></a> ClearCastRange\(\)

```csharp
public void ClearCastRange()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ClearChannelTime"></a> ClearChannelTime\(\)

```csharp
public void ClearChannelTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ClearCharges"></a> ClearCharges\(\)

```csharp
public void ClearCharges()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ClearCooldownRemaining"></a> ClearCooldownRemaining\(\)

```csharp
public void ClearCooldownRemaining()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ClearHandle"></a> ClearHandle\(\)

```csharp
public void ClearHandle()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ClearIsActivated"></a> ClearIsActivated\(\)

```csharp
public void ClearIsActivated()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ClearIsChanneling"></a> ClearIsChanneling\(\)

```csharp
public void ClearIsChanneling()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ClearIsCombinedLocked"></a> ClearIsCombinedLocked\(\)

```csharp
public void ClearIsCombinedLocked()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ClearIsFullyCastable"></a> ClearIsFullyCastable\(\)

```csharp
public void ClearIsFullyCastable()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ClearIsInAbilityPhase"></a> ClearIsInAbilityPhase\(\)

```csharp
public void ClearIsInAbilityPhase()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ClearIsStolen"></a> ClearIsStolen\(\)

```csharp
public void ClearIsStolen()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ClearIsToggled"></a> ClearIsToggled\(\)

```csharp
public void ClearIsToggled()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ClearLevel"></a> ClearLevel\(\)

```csharp
public void ClearLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ClearPowerTreadsStat"></a> ClearPowerTreadsStat\(\)

```csharp
public void ClearPowerTreadsStat()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ClearSecondaryCharges"></a> ClearSecondaryCharges\(\)

```csharp
public void ClearSecondaryCharges()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ClearSlot"></a> ClearSlot\(\)

```csharp
public void ClearSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_Clone"></a> Clone\(\)

```csharp
public CMsgBotWorldState.Types.Ability Clone()
```

#### Returns

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Ability](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Ability.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_Equals_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_"></a> Equals\(Ability\)

```csharp
public bool Equals(CMsgBotWorldState.Types.Ability other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Ability](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Ability.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_MergeFrom_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_"></a> MergeFrom\(Ability\)

```csharp
public void MergeFrom(CMsgBotWorldState.Types.Ability other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Ability](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Ability.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Ability_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

