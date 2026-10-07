# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails"></a> Class CDOTAUserMsg\_StatsHeroMinuteDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_StatsHeroMinuteDetails : IMessage<CDOTAUserMsg_StatsHeroMinuteDetails>, IEquatable<CDOTAUserMsg_StatsHeroMinuteDetails>, IDeepCloneable<CDOTAUserMsg_StatsHeroMinuteDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_StatsHeroMinuteDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroMinuteDetails.md)

#### Implements

IMessage<CDOTAUserMsg\_StatsHeroMinuteDetails\>, 
[IEquatable<CDOTAUserMsg\_StatsHeroMinuteDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_StatsHeroMinuteDetails\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_StatsHeroMinuteDetails\>\(CDOTAUserMsg\_StatsHeroMinuteDetails, params CDOTAUserMsg\_StatsHeroMinuteDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails__ctor"></a> CDOTAUserMsg\_StatsHeroMinuteDetails\(\)

```csharp
public CDOTAUserMsg_StatsHeroMinuteDetails()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_"></a> CDOTAUserMsg\_StatsHeroMinuteDetails\(CDOTAUserMsg\_StatsHeroMinuteDetails\)

```csharp
public CDOTAUserMsg_StatsHeroMinuteDetails(CDOTAUserMsg_StatsHeroMinuteDetails other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsHeroMinuteDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroMinuteDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_ClaimedFarmFieldNumber"></a> ClaimedFarmFieldNumber

```csharp
public const int ClaimedFarmFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_DamageAbsorbedFieldNumber"></a> DamageAbsorbedFieldNumber

```csharp
public const int DamageAbsorbedFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_DamageDoneFieldNumber"></a> DamageDoneFieldNumber

```csharp
public const int DamageDoneFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_HarvestedCreepGoldFieldNumber"></a> HarvestedCreepGoldFieldNumber

```csharp
public const int HarvestedCreepGoldFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_HeroDamageFieldNumber"></a> HeroDamageFieldNumber

```csharp
public const int HeroDamageFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_HeroKillsFieldNumber"></a> HeroKillsFieldNumber

```csharp
public const int HeroKillsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_LastHitsFieldNumber"></a> LastHitsFieldNumber

```csharp
public const int LastHitsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_ManaSpentFieldNumber"></a> ManaSpentFieldNumber

```csharp
public const int ManaSpentFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_NetWorthFieldNumber"></a> NetWorthFieldNumber

```csharp
public const int NetWorthFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_PositionInfoFieldNumber"></a> PositionInfoFieldNumber

```csharp
public const int PositionInfoFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_RunesCollectedFieldNumber"></a> RunesCollectedFieldNumber

```csharp
public const int RunesCollectedFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_TotalXpFieldNumber"></a> TotalXpFieldNumber

```csharp
public const int TotalXpFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_TowerDamageFieldNumber"></a> TowerDamageFieldNumber

```csharp
public const int TowerDamageFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_TpsUsedFieldNumber"></a> TpsUsedFieldNumber

```csharp
public const int TpsUsedFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_WardsPlacedFieldNumber"></a> WardsPlacedFieldNumber

```csharp
public const int WardsPlacedFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_ClaimedFarm"></a> ClaimedFarm

```csharp
public uint ClaimedFarm { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_DamageAbsorbed"></a> DamageAbsorbed

```csharp
public RepeatedField<uint> DamageAbsorbed { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_DamageDone"></a> DamageDone

```csharp
public RepeatedField<uint> DamageDone { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_HarvestedCreepGold"></a> HarvestedCreepGold

```csharp
public uint HarvestedCreepGold { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_HasClaimedFarm"></a> HasClaimedFarm

```csharp
public bool HasClaimedFarm { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_HasHarvestedCreepGold"></a> HasHarvestedCreepGold

```csharp
public bool HasHarvestedCreepGold { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_HasHeroDamage"></a> HasHeroDamage

```csharp
public bool HasHeroDamage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_HasHeroKills"></a> HasHeroKills

```csharp
public bool HasHeroKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_HasLastHits"></a> HasLastHits

```csharp
public bool HasLastHits { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_HasNetWorth"></a> HasNetWorth

```csharp
public bool HasNetWorth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_HasRunesCollected"></a> HasRunesCollected

```csharp
public bool HasRunesCollected { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_HasTotalXp"></a> HasTotalXp

```csharp
public bool HasTotalXp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_HasTowerDamage"></a> HasTowerDamage

```csharp
public bool HasTowerDamage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_HasTpsUsed"></a> HasTpsUsed

```csharp
public bool HasTpsUsed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_HasWardsPlaced"></a> HasWardsPlaced

```csharp
public bool HasWardsPlaced { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_HeroDamage"></a> HeroDamage

```csharp
public uint HeroDamage { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_HeroKills"></a> HeroKills

```csharp
public uint HeroKills { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_LastHits"></a> LastHits

```csharp
public uint LastHits { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_ManaSpent"></a> ManaSpent

```csharp
public RepeatedField<uint> ManaSpent { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_NetWorth"></a> NetWorth

```csharp
public uint NetWorth { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_StatsHeroMinuteDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_StatsHeroMinuteDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroMinuteDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_PositionInfo"></a> PositionInfo

```csharp
public CDOTAUserMsg_StatsHeroPositionInfo PositionInfo { get; set; }
```

#### Property Value

 [CDOTAUserMsg\_StatsHeroPositionInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroPositionInfo.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_RunesCollected"></a> RunesCollected

```csharp
public uint RunesCollected { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_TotalXp"></a> TotalXp

```csharp
public uint TotalXp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_TowerDamage"></a> TowerDamage

```csharp
public uint TowerDamage { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_TpsUsed"></a> TpsUsed

```csharp
public uint TpsUsed { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_WardsPlaced"></a> WardsPlaced

```csharp
public uint WardsPlaced { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_ClearClaimedFarm"></a> ClearClaimedFarm\(\)

```csharp
public void ClearClaimedFarm()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_ClearHarvestedCreepGold"></a> ClearHarvestedCreepGold\(\)

```csharp
public void ClearHarvestedCreepGold()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_ClearHeroDamage"></a> ClearHeroDamage\(\)

```csharp
public void ClearHeroDamage()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_ClearHeroKills"></a> ClearHeroKills\(\)

```csharp
public void ClearHeroKills()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_ClearLastHits"></a> ClearLastHits\(\)

```csharp
public void ClearLastHits()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_ClearNetWorth"></a> ClearNetWorth\(\)

```csharp
public void ClearNetWorth()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_ClearRunesCollected"></a> ClearRunesCollected\(\)

```csharp
public void ClearRunesCollected()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_ClearTotalXp"></a> ClearTotalXp\(\)

```csharp
public void ClearTotalXp()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_ClearTowerDamage"></a> ClearTowerDamage\(\)

```csharp
public void ClearTowerDamage()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_ClearTpsUsed"></a> ClearTpsUsed\(\)

```csharp
public void ClearTpsUsed()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_ClearWardsPlaced"></a> ClearWardsPlaced\(\)

```csharp
public void ClearWardsPlaced()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_StatsHeroMinuteDetails Clone()
```

#### Returns

 [CDOTAUserMsg\_StatsHeroMinuteDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroMinuteDetails.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_"></a> Equals\(CDOTAUserMsg\_StatsHeroMinuteDetails\)

```csharp
public bool Equals(CDOTAUserMsg_StatsHeroMinuteDetails other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsHeroMinuteDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroMinuteDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_"></a> MergeFrom\(CDOTAUserMsg\_StatsHeroMinuteDetails\)

```csharp
public void MergeFrom(CDOTAUserMsg_StatsHeroMinuteDetails other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsHeroMinuteDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroMinuteDetails.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroMinuteDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

