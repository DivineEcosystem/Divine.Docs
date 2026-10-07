# <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem"></a> Class CMsgGameDataAbilityOrItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameDataAbilityOrItem : IMessage<CMsgGameDataAbilityOrItem>, IEquatable<CMsgGameDataAbilityOrItem>, IDeepCloneable<CMsgGameDataAbilityOrItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameDataAbilityOrItem](Divine.Protobufs.Dota2.CMsgGameDataAbilityOrItem.md)

#### Implements

IMessage<CMsgGameDataAbilityOrItem\>, 
[IEquatable<CMsgGameDataAbilityOrItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameDataAbilityOrItem\>, 
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
[EnumerableExtensions.In<CMsgGameDataAbilityOrItem\>\(CMsgGameDataAbilityOrItem, params CMsgGameDataAbilityOrItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem__ctor"></a> CMsgGameDataAbilityOrItem\(\)

```csharp
public CMsgGameDataAbilityOrItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem__ctor_Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_"></a> CMsgGameDataAbilityOrItem\(CMsgGameDataAbilityOrItem\)

```csharp
public CMsgGameDataAbilityOrItem(CMsgGameDataAbilityOrItem other)
```

#### Parameters

`other` [CMsgGameDataAbilityOrItem](Divine.Protobufs.Dota2.CMsgGameDataAbilityOrItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_AbilityHasScepterFieldNumber"></a> AbilityHasScepterFieldNumber

```csharp
public const int AbilityHasScepterFieldNumber = 60
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_AbilityHasShardFieldNumber"></a> AbilityHasShardFieldNumber

```csharp
public const int AbilityHasShardFieldNumber = 61
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_AbilityIsGrantedByScepterFieldNumber"></a> AbilityIsGrantedByScepterFieldNumber

```csharp
public const int AbilityIsGrantedByScepterFieldNumber = 62
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_AbilityIsGrantedByShardFieldNumber"></a> AbilityIsGrantedByShardFieldNumber

```csharp
public const int AbilityIsGrantedByShardFieldNumber = 63
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_AbilityIsInnateFieldNumber"></a> AbilityIsInnateFieldNumber

```csharp
public const int AbilityIsInnateFieldNumber = 64
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_BehaviorFieldNumber"></a> BehaviorFieldNumber

```csharp
public const int BehaviorFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_CastPointsFieldNumber"></a> CastPointsFieldNumber

```csharp
public const int CastPointsFieldNumber = 31
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_CastRangesFieldNumber"></a> CastRangesFieldNumber

```csharp
public const int CastRangesFieldNumber = 30
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ChannelTimesFieldNumber"></a> ChannelTimesFieldNumber

```csharp
public const int ChannelTimesFieldNumber = 32
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_CooldownsFieldNumber"></a> CooldownsFieldNumber

```csharp
public const int CooldownsFieldNumber = 33
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_DamageFieldNumber"></a> DamageFieldNumber

```csharp
public const int DamageFieldNumber = 25
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_DamagesFieldNumber"></a> DamagesFieldNumber

```csharp
public const int DamagesFieldNumber = 35
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_DescLocFieldNumber"></a> DescLocFieldNumber

```csharp
public const int DescLocFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_DispellableFieldNumber"></a> DispellableFieldNumber

```csharp
public const int DispellableFieldNumber = 27
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_DurationsFieldNumber"></a> DurationsFieldNumber

```csharp
public const int DurationsFieldNumber = 34
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_FacetsLocFieldNumber"></a> FacetsLocFieldNumber

```csharp
public const int FacetsLocFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_GoldCostsFieldNumber"></a> GoldCostsFieldNumber

```csharp
public const int GoldCostsFieldNumber = 37
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HealthCostsFieldNumber"></a> HealthCostsFieldNumber

```csharp
public const int HealthCostsFieldNumber = 38
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ImmunityFieldNumber"></a> ImmunityFieldNumber

```csharp
public const int ImmunityFieldNumber = 26
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_IsItemFieldNumber"></a> IsItemFieldNumber

```csharp
public const int IsItemFieldNumber = 50
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ItemCostFieldNumber"></a> ItemCostFieldNumber

```csharp
public const int ItemCostFieldNumber = 70
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ItemInitialChargesFieldNumber"></a> ItemInitialChargesFieldNumber

```csharp
public const int ItemInitialChargesFieldNumber = 71
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ItemNeutralTierFieldNumber"></a> ItemNeutralTierFieldNumber

```csharp
public const int ItemNeutralTierFieldNumber = 72
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ItemQualityFieldNumber"></a> ItemQualityFieldNumber

```csharp
public const int ItemQualityFieldNumber = 85
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ItemStockMaxFieldNumber"></a> ItemStockMaxFieldNumber

```csharp
public const int ItemStockMaxFieldNumber = 73
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ItemStockTimeFieldNumber"></a> ItemStockTimeFieldNumber

```csharp
public const int ItemStockTimeFieldNumber = 74
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_LoreLocFieldNumber"></a> LoreLocFieldNumber

```csharp
public const int LoreLocFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ManaCostsFieldNumber"></a> ManaCostsFieldNumber

```csharp
public const int ManaCostsFieldNumber = 36
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_MaxLevelFieldNumber"></a> MaxLevelFieldNumber

```csharp
public const int MaxLevelFieldNumber = 28
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_NameLocFieldNumber"></a> NameLocFieldNumber

```csharp
public const int NameLocFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_NotesLocFieldNumber"></a> NotesLocFieldNumber

```csharp
public const int NotesLocFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ScepterLocFieldNumber"></a> ScepterLocFieldNumber

```csharp
public const int ScepterLocFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ShardLocFieldNumber"></a> ShardLocFieldNumber

```csharp
public const int ShardLocFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_SpecialValuesFieldNumber"></a> SpecialValuesFieldNumber

```csharp
public const int SpecialValuesFieldNumber = 40
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_TargetTeamFieldNumber"></a> TargetTeamFieldNumber

```csharp
public const int TargetTeamFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_TargetTypeFieldNumber"></a> TargetTypeFieldNumber

```csharp
public const int TargetTypeFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_AbilityHasScepter"></a> AbilityHasScepter

```csharp
public bool AbilityHasScepter { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_AbilityHasShard"></a> AbilityHasShard

```csharp
public bool AbilityHasShard { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_AbilityIsGrantedByScepter"></a> AbilityIsGrantedByScepter

```csharp
public bool AbilityIsGrantedByScepter { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_AbilityIsGrantedByShard"></a> AbilityIsGrantedByShard

```csharp
public bool AbilityIsGrantedByShard { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_AbilityIsInnate"></a> AbilityIsInnate

```csharp
public bool AbilityIsInnate { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_Behavior"></a> Behavior

```csharp
public ulong Behavior { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_CastPoints"></a> CastPoints

```csharp
public RepeatedField<float> CastPoints { get; }
```

#### Property Value

 RepeatedField<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_CastRanges"></a> CastRanges

```csharp
public RepeatedField<uint> CastRanges { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ChannelTimes"></a> ChannelTimes

```csharp
public RepeatedField<float> ChannelTimes { get; }
```

#### Property Value

 RepeatedField<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_Cooldowns"></a> Cooldowns

```csharp
public RepeatedField<float> Cooldowns { get; }
```

#### Property Value

 RepeatedField<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_Damage"></a> Damage

```csharp
public uint Damage { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_Damages"></a> Damages

```csharp
public RepeatedField<uint> Damages { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_DescLoc"></a> DescLoc

```csharp
public string DescLoc { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_Dispellable"></a> Dispellable

```csharp
public uint Dispellable { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_Durations"></a> Durations

```csharp
public RepeatedField<float> Durations { get; }
```

#### Property Value

 RepeatedField<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_FacetsLoc"></a> FacetsLoc

```csharp
public RepeatedField<string> FacetsLoc { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_GoldCosts"></a> GoldCosts

```csharp
public RepeatedField<uint> GoldCosts { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasAbilityHasScepter"></a> HasAbilityHasScepter

```csharp
public bool HasAbilityHasScepter { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasAbilityHasShard"></a> HasAbilityHasShard

```csharp
public bool HasAbilityHasShard { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasAbilityIsGrantedByScepter"></a> HasAbilityIsGrantedByScepter

```csharp
public bool HasAbilityIsGrantedByScepter { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasAbilityIsGrantedByShard"></a> HasAbilityIsGrantedByShard

```csharp
public bool HasAbilityIsGrantedByShard { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasAbilityIsInnate"></a> HasAbilityIsInnate

```csharp
public bool HasAbilityIsInnate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasBehavior"></a> HasBehavior

```csharp
public bool HasBehavior { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasDamage"></a> HasDamage

```csharp
public bool HasDamage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasDescLoc"></a> HasDescLoc

```csharp
public bool HasDescLoc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasDispellable"></a> HasDispellable

```csharp
public bool HasDispellable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasImmunity"></a> HasImmunity

```csharp
public bool HasImmunity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasIsItem"></a> HasIsItem

```csharp
public bool HasIsItem { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasItemCost"></a> HasItemCost

```csharp
public bool HasItemCost { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasItemInitialCharges"></a> HasItemInitialCharges

```csharp
public bool HasItemInitialCharges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasItemNeutralTier"></a> HasItemNeutralTier

```csharp
public bool HasItemNeutralTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasItemQuality"></a> HasItemQuality

```csharp
public bool HasItemQuality { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasItemStockMax"></a> HasItemStockMax

```csharp
public bool HasItemStockMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasItemStockTime"></a> HasItemStockTime

```csharp
public bool HasItemStockTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasLoreLoc"></a> HasLoreLoc

```csharp
public bool HasLoreLoc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasMaxLevel"></a> HasMaxLevel

```csharp
public bool HasMaxLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasNameLoc"></a> HasNameLoc

```csharp
public bool HasNameLoc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasScepterLoc"></a> HasScepterLoc

```csharp
public bool HasScepterLoc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasShardLoc"></a> HasShardLoc

```csharp
public bool HasShardLoc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasTargetTeam"></a> HasTargetTeam

```csharp
public bool HasTargetTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasTargetType"></a> HasTargetType

```csharp
public bool HasTargetType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_HealthCosts"></a> HealthCosts

```csharp
public RepeatedField<uint> HealthCosts { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_Id"></a> Id

```csharp
public int Id { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_Immunity"></a> Immunity

```csharp
public uint Immunity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_IsItem"></a> IsItem

```csharp
public bool IsItem { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ItemCost"></a> ItemCost

```csharp
public uint ItemCost { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ItemInitialCharges"></a> ItemInitialCharges

```csharp
public uint ItemInitialCharges { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ItemNeutralTier"></a> ItemNeutralTier

```csharp
public uint ItemNeutralTier { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ItemQuality"></a> ItemQuality

```csharp
public uint ItemQuality { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ItemStockMax"></a> ItemStockMax

```csharp
public uint ItemStockMax { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ItemStockTime"></a> ItemStockTime

```csharp
public float ItemStockTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_LoreLoc"></a> LoreLoc

```csharp
public string LoreLoc { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ManaCosts"></a> ManaCosts

```csharp
public RepeatedField<uint> ManaCosts { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_MaxLevel"></a> MaxLevel

```csharp
public uint MaxLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_NameLoc"></a> NameLoc

```csharp
public string NameLoc { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_NotesLoc"></a> NotesLoc

```csharp
public RepeatedField<string> NotesLoc { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameDataAbilityOrItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameDataAbilityOrItem](Divine.Protobufs.Dota2.CMsgGameDataAbilityOrItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ScepterLoc"></a> ScepterLoc

```csharp
public string ScepterLoc { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ShardLoc"></a> ShardLoc

```csharp
public string ShardLoc { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_SpecialValues"></a> SpecialValues

```csharp
public RepeatedField<CMsgGameDataSpecialValues> SpecialValues { get; }
```

#### Property Value

 RepeatedField<[CMsgGameDataSpecialValues](Divine.Protobufs.Dota2.CMsgGameDataSpecialValues.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_TargetTeam"></a> TargetTeam

```csharp
public uint TargetTeam { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_TargetType"></a> TargetType

```csharp
public uint TargetType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_Type"></a> Type

```csharp
public uint Type { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearAbilityHasScepter"></a> ClearAbilityHasScepter\(\)

```csharp
public void ClearAbilityHasScepter()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearAbilityHasShard"></a> ClearAbilityHasShard\(\)

```csharp
public void ClearAbilityHasShard()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearAbilityIsGrantedByScepter"></a> ClearAbilityIsGrantedByScepter\(\)

```csharp
public void ClearAbilityIsGrantedByScepter()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearAbilityIsGrantedByShard"></a> ClearAbilityIsGrantedByShard\(\)

```csharp
public void ClearAbilityIsGrantedByShard()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearAbilityIsInnate"></a> ClearAbilityIsInnate\(\)

```csharp
public void ClearAbilityIsInnate()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearBehavior"></a> ClearBehavior\(\)

```csharp
public void ClearBehavior()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearDamage"></a> ClearDamage\(\)

```csharp
public void ClearDamage()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearDescLoc"></a> ClearDescLoc\(\)

```csharp
public void ClearDescLoc()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearDispellable"></a> ClearDispellable\(\)

```csharp
public void ClearDispellable()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearImmunity"></a> ClearImmunity\(\)

```csharp
public void ClearImmunity()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearIsItem"></a> ClearIsItem\(\)

```csharp
public void ClearIsItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearItemCost"></a> ClearItemCost\(\)

```csharp
public void ClearItemCost()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearItemInitialCharges"></a> ClearItemInitialCharges\(\)

```csharp
public void ClearItemInitialCharges()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearItemNeutralTier"></a> ClearItemNeutralTier\(\)

```csharp
public void ClearItemNeutralTier()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearItemQuality"></a> ClearItemQuality\(\)

```csharp
public void ClearItemQuality()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearItemStockMax"></a> ClearItemStockMax\(\)

```csharp
public void ClearItemStockMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearItemStockTime"></a> ClearItemStockTime\(\)

```csharp
public void ClearItemStockTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearLoreLoc"></a> ClearLoreLoc\(\)

```csharp
public void ClearLoreLoc()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearMaxLevel"></a> ClearMaxLevel\(\)

```csharp
public void ClearMaxLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearNameLoc"></a> ClearNameLoc\(\)

```csharp
public void ClearNameLoc()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearScepterLoc"></a> ClearScepterLoc\(\)

```csharp
public void ClearScepterLoc()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearShardLoc"></a> ClearShardLoc\(\)

```csharp
public void ClearShardLoc()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearTargetTeam"></a> ClearTargetTeam\(\)

```csharp
public void ClearTargetTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearTargetType"></a> ClearTargetType\(\)

```csharp
public void ClearTargetType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_Clone"></a> Clone\(\)

```csharp
public CMsgGameDataAbilityOrItem Clone()
```

#### Returns

 [CMsgGameDataAbilityOrItem](Divine.Protobufs.Dota2.CMsgGameDataAbilityOrItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_Equals_Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_"></a> Equals\(CMsgGameDataAbilityOrItem\)

```csharp
public bool Equals(CMsgGameDataAbilityOrItem other)
```

#### Parameters

`other` [CMsgGameDataAbilityOrItem](Divine.Protobufs.Dota2.CMsgGameDataAbilityOrItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_MergeFrom_Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_"></a> MergeFrom\(CMsgGameDataAbilityOrItem\)

```csharp
public void MergeFrom(CMsgGameDataAbilityOrItem other)
```

#### Parameters

`other` [CMsgGameDataAbilityOrItem](Divine.Protobufs.Dota2.CMsgGameDataAbilityOrItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataAbilityOrItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

