# <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember"></a> Class CSODOTAPartyMember

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSODOTAPartyMember : IMessage<CSODOTAPartyMember>, IEquatable<CSODOTAPartyMember>, IDeepCloneable<CSODOTAPartyMember>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSODOTAPartyMember](Divine.Protobufs.Dota2.CSODOTAPartyMember.md)

#### Implements

IMessage<CSODOTAPartyMember\>, 
[IEquatable<CSODOTAPartyMember\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSODOTAPartyMember\>, 
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
[EnumerableExtensions.In<CSODOTAPartyMember\>\(CSODOTAPartyMember, params CSODOTAPartyMember\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember__ctor"></a> CSODOTAPartyMember\(\)

```csharp
public CSODOTAPartyMember()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember__ctor_Divine_Protobufs_Dota2_CSODOTAPartyMember_"></a> CSODOTAPartyMember\(CSODOTAPartyMember\)

```csharp
public CSODOTAPartyMember(CSODOTAPartyMember other)
```

#### Parameters

`other` [CSODOTAPartyMember](Divine.Protobufs.Dota2.CSODOTAPartyMember.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_BannedHeroIdsFieldNumber"></a> BannedHeroIdsFieldNumber

```csharp
public const int BannedHeroIdsFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_HasHpResourceFieldNumber"></a> HasHpResourceFieldNumber

```csharp
public const int HasHpResourceFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_HighPriorityDisabledFieldNumber"></a> HighPriorityDisabledFieldNumber

```csharp
public const int HighPriorityDisabledFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_IsCoachFieldNumber"></a> IsCoachFieldNumber

```csharp
public const int IsCoachFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_IsPlusSubscriberFieldNumber"></a> IsPlusSubscriberFieldNumber

```csharp
public const int IsPlusSubscriberFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_IsSteamChinaFieldNumber"></a> IsSteamChinaFieldNumber

```csharp
public const int IsSteamChinaFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_JoinedFromPartyfinderFieldNumber"></a> JoinedFromPartyfinderFieldNumber

```csharp
public const int JoinedFromPartyfinderFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_LaneSelectionFlagsFieldNumber"></a> LaneSelectionFlagsFieldNumber

```csharp
public const int LaneSelectionFlagsFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_MmDataValidFieldNumber"></a> MmDataValidFieldNumber

```csharp
public const int MmDataValidFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_RegionPingCodesFieldNumber"></a> RegionPingCodesFieldNumber

```csharp
public const int RegionPingCodesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_RegionPingFailedBitmaskFieldNumber"></a> RegionPingFailedBitmaskFieldNumber

```csharp
public const int RegionPingFailedBitmaskFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_RegionPingTimesFieldNumber"></a> RegionPingTimesFieldNumber

```csharp
public const int RegionPingTimesFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_TourneyBuyinFieldNumber"></a> TourneyBuyinFieldNumber

```csharp
public const int TourneyBuyinFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_TourneyPreventUntilFieldNumber"></a> TourneyPreventUntilFieldNumber

```csharp
public const int TourneyPreventUntilFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_TourneySkillLevelFieldNumber"></a> TourneySkillLevelFieldNumber

```csharp
public const int TourneySkillLevelFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_BannedHeroIds"></a> BannedHeroIds

```csharp
public RepeatedField<int> BannedHeroIds { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_HasHasHpResource"></a> HasHasHpResource

```csharp
public bool HasHasHpResource { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_HasHighPriorityDisabled"></a> HasHighPriorityDisabled

```csharp
public bool HasHighPriorityDisabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_HasHpResource"></a> HasHpResource

```csharp
public bool HasHpResource { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_HasIsCoach"></a> HasIsCoach

```csharp
public bool HasIsCoach { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_HasIsPlusSubscriber"></a> HasIsPlusSubscriber

```csharp
public bool HasIsPlusSubscriber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_HasIsSteamChina"></a> HasIsSteamChina

```csharp
public bool HasIsSteamChina { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_HasJoinedFromPartyfinder"></a> HasJoinedFromPartyfinder

```csharp
public bool HasJoinedFromPartyfinder { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_HasLaneSelectionFlags"></a> HasLaneSelectionFlags

```csharp
public bool HasLaneSelectionFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_HasMmDataValid"></a> HasMmDataValid

```csharp
public bool HasMmDataValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_HasRegionPingFailedBitmask"></a> HasRegionPingFailedBitmask

```csharp
public bool HasRegionPingFailedBitmask { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_HasTourneyBuyin"></a> HasTourneyBuyin

```csharp
public bool HasTourneyBuyin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_HasTourneyPreventUntil"></a> HasTourneyPreventUntil

```csharp
public bool HasTourneyPreventUntil { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_HasTourneySkillLevel"></a> HasTourneySkillLevel

```csharp
public bool HasTourneySkillLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_HighPriorityDisabled"></a> HighPriorityDisabled

```csharp
public bool HighPriorityDisabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_IsCoach"></a> IsCoach

```csharp
public bool IsCoach { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_IsPlusSubscriber"></a> IsPlusSubscriber

```csharp
public bool IsPlusSubscriber { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_IsSteamChina"></a> IsSteamChina

```csharp
public bool IsSteamChina { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_JoinedFromPartyfinder"></a> JoinedFromPartyfinder

```csharp
public bool JoinedFromPartyfinder { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_LaneSelectionFlags"></a> LaneSelectionFlags

```csharp
public uint LaneSelectionFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_MmDataValid"></a> MmDataValid

```csharp
public bool MmDataValid { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Parser"></a> Parser

```csharp
public static MessageParser<CSODOTAPartyMember> Parser { get; }
```

#### Property Value

 MessageParser<[CSODOTAPartyMember](Divine.Protobufs.Dota2.CSODOTAPartyMember.md)\>

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_RegionPingCodes"></a> RegionPingCodes

```csharp
public RepeatedField<uint> RegionPingCodes { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_RegionPingFailedBitmask"></a> RegionPingFailedBitmask

```csharp
public ulong RegionPingFailedBitmask { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_RegionPingTimes"></a> RegionPingTimes

```csharp
public RepeatedField<uint> RegionPingTimes { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_TourneyBuyin"></a> TourneyBuyin

```csharp
public uint TourneyBuyin { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_TourneyPreventUntil"></a> TourneyPreventUntil

```csharp
public uint TourneyPreventUntil { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_TourneySkillLevel"></a> TourneySkillLevel

```csharp
public uint TourneySkillLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_ClearHasHpResource"></a> ClearHasHpResource\(\)

```csharp
public void ClearHasHpResource()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_ClearHighPriorityDisabled"></a> ClearHighPriorityDisabled\(\)

```csharp
public void ClearHighPriorityDisabled()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_ClearIsCoach"></a> ClearIsCoach\(\)

```csharp
public void ClearIsCoach()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_ClearIsPlusSubscriber"></a> ClearIsPlusSubscriber\(\)

```csharp
public void ClearIsPlusSubscriber()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_ClearIsSteamChina"></a> ClearIsSteamChina\(\)

```csharp
public void ClearIsSteamChina()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_ClearJoinedFromPartyfinder"></a> ClearJoinedFromPartyfinder\(\)

```csharp
public void ClearJoinedFromPartyfinder()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_ClearLaneSelectionFlags"></a> ClearLaneSelectionFlags\(\)

```csharp
public void ClearLaneSelectionFlags()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_ClearMmDataValid"></a> ClearMmDataValid\(\)

```csharp
public void ClearMmDataValid()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_ClearRegionPingFailedBitmask"></a> ClearRegionPingFailedBitmask\(\)

```csharp
public void ClearRegionPingFailedBitmask()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_ClearTourneyBuyin"></a> ClearTourneyBuyin\(\)

```csharp
public void ClearTourneyBuyin()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_ClearTourneyPreventUntil"></a> ClearTourneyPreventUntil\(\)

```csharp
public void ClearTourneyPreventUntil()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_ClearTourneySkillLevel"></a> ClearTourneySkillLevel\(\)

```csharp
public void ClearTourneySkillLevel()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Clone"></a> Clone\(\)

```csharp
public CSODOTAPartyMember Clone()
```

#### Returns

 [CSODOTAPartyMember](Divine.Protobufs.Dota2.CSODOTAPartyMember.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_Equals_Divine_Protobufs_Dota2_CSODOTAPartyMember_"></a> Equals\(CSODOTAPartyMember\)

```csharp
public bool Equals(CSODOTAPartyMember other)
```

#### Parameters

`other` [CSODOTAPartyMember](Divine.Protobufs.Dota2.CSODOTAPartyMember.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_MergeFrom_Divine_Protobufs_Dota2_CSODOTAPartyMember_"></a> MergeFrom\(CSODOTAPartyMember\)

```csharp
public void MergeFrom(CSODOTAPartyMember other)
```

#### Parameters

`other` [CSODOTAPartyMember](Divine.Protobufs.Dota2.CSODOTAPartyMember.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTAPartyMember_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

