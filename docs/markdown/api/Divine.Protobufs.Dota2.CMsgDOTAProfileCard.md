# <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard"></a> Class CMsgDOTAProfileCard

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAProfileCard : IMessage<CMsgDOTAProfileCard>, IEquatable<CMsgDOTAProfileCard>, IDeepCloneable<CMsgDOTAProfileCard>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md)

#### Implements

IMessage<CMsgDOTAProfileCard\>, 
[IEquatable<CMsgDOTAProfileCard\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAProfileCard\>, 
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
[EnumerableExtensions.In<CMsgDOTAProfileCard\>\(CMsgDOTAProfileCard, params CMsgDOTAProfileCard\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard__ctor"></a> CMsgDOTAProfileCard\(\)

```csharp
public CMsgDOTAProfileCard()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard__ctor_Divine_Protobufs_Dota2_CMsgDOTAProfileCard_"></a> CMsgDOTAProfileCard\(CMsgDOTAProfileCard\)

```csharp
public CMsgDOTAProfileCard(CMsgDOTAProfileCard other)
```

#### Parameters

`other` [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_BadgePointsFieldNumber"></a> BadgePointsFieldNumber

```csharp
public const int BadgePointsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_EventLevelFieldNumber"></a> EventLevelFieldNumber

```csharp
public const int EventLevelFieldNumber = 26
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_FavoriteTeamPackedFieldNumber"></a> FavoriteTeamPackedFieldNumber

```csharp
public const int FavoriteTeamPackedFieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_IsPlusSubscriberFieldNumber"></a> IsPlusSubscriberFieldNumber

```csharp
public const int IsPlusSubscriberFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_LeaderboardRankCoreFieldNumber"></a> LeaderboardRankCoreFieldNumber

```csharp
public const int LeaderboardRankCoreFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_LeaderboardRankFieldNumber"></a> LeaderboardRankFieldNumber

```csharp
public const int LeaderboardRankFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_LifetimeGamesFieldNumber"></a> LifetimeGamesFieldNumber

```csharp
public const int LifetimeGamesFieldNumber = 25
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_PlusOriginalStartDateFieldNumber"></a> PlusOriginalStartDateFieldNumber

```csharp
public const int PlusOriginalStartDateFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_RankTierFieldNumber"></a> RankTierFieldNumber

```csharp
public const int RankTierFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_RankTierScoreFieldNumber"></a> RankTierScoreFieldNumber

```csharp
public const int RankTierScoreFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_RecentBattleCupVictoryFieldNumber"></a> RecentBattleCupVictoryFieldNumber

```csharp
public const int RecentBattleCupVictoryFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_SlotsFieldNumber"></a> SlotsFieldNumber

```csharp
public const int SlotsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_TitleFieldNumber"></a> TitleFieldNumber

```csharp
public const int TitleFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_BadgePoints"></a> BadgePoints

```csharp
public uint BadgePoints { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_EventLevel"></a> EventLevel

```csharp
public uint EventLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_FavoriteTeamPacked"></a> FavoriteTeamPacked

```csharp
public ulong FavoriteTeamPacked { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_HasBadgePoints"></a> HasBadgePoints

```csharp
public bool HasBadgePoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_HasEventLevel"></a> HasEventLevel

```csharp
public bool HasEventLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_HasFavoriteTeamPacked"></a> HasFavoriteTeamPacked

```csharp
public bool HasFavoriteTeamPacked { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_HasIsPlusSubscriber"></a> HasIsPlusSubscriber

```csharp
public bool HasIsPlusSubscriber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_HasLeaderboardRank"></a> HasLeaderboardRank

```csharp
public bool HasLeaderboardRank { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_HasLeaderboardRankCore"></a> HasLeaderboardRankCore

```csharp
public bool HasLeaderboardRankCore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_HasLifetimeGames"></a> HasLifetimeGames

```csharp
public bool HasLifetimeGames { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_HasPlusOriginalStartDate"></a> HasPlusOriginalStartDate

```csharp
public bool HasPlusOriginalStartDate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_HasRankTier"></a> HasRankTier

```csharp
public bool HasRankTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_HasRankTierScore"></a> HasRankTierScore

```csharp
public bool HasRankTierScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_HasTitle"></a> HasTitle

```csharp
public bool HasTitle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_IsPlusSubscriber"></a> IsPlusSubscriber

```csharp
public bool IsPlusSubscriber { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_LeaderboardRank"></a> LeaderboardRank

```csharp
public uint LeaderboardRank { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_LeaderboardRankCore"></a> LeaderboardRankCore

```csharp
public uint LeaderboardRankCore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_LifetimeGames"></a> LifetimeGames

```csharp
public uint LifetimeGames { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAProfileCard> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_PlusOriginalStartDate"></a> PlusOriginalStartDate

```csharp
public uint PlusOriginalStartDate { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_RankTier"></a> RankTier

```csharp
public uint RankTier { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_RankTierScore"></a> RankTierScore

```csharp
public uint RankTierScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_RecentBattleCupVictory"></a> RecentBattleCupVictory

```csharp
public CMsgBattleCupVictory RecentBattleCupVictory { get; set; }
```

#### Property Value

 [CMsgBattleCupVictory](Divine.Protobufs.Dota2.CMsgBattleCupVictory.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Slots"></a> Slots

```csharp
public RepeatedField<CMsgDOTAProfileCard.Types.Slot> Slots { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Title"></a> Title

```csharp
public uint Title { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_ClearBadgePoints"></a> ClearBadgePoints\(\)

```csharp
public void ClearBadgePoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_ClearEventLevel"></a> ClearEventLevel\(\)

```csharp
public void ClearEventLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_ClearFavoriteTeamPacked"></a> ClearFavoriteTeamPacked\(\)

```csharp
public void ClearFavoriteTeamPacked()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_ClearIsPlusSubscriber"></a> ClearIsPlusSubscriber\(\)

```csharp
public void ClearIsPlusSubscriber()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_ClearLeaderboardRank"></a> ClearLeaderboardRank\(\)

```csharp
public void ClearLeaderboardRank()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_ClearLeaderboardRankCore"></a> ClearLeaderboardRankCore\(\)

```csharp
public void ClearLeaderboardRankCore()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_ClearLifetimeGames"></a> ClearLifetimeGames\(\)

```csharp
public void ClearLifetimeGames()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_ClearPlusOriginalStartDate"></a> ClearPlusOriginalStartDate\(\)

```csharp
public void ClearPlusOriginalStartDate()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_ClearRankTier"></a> ClearRankTier\(\)

```csharp
public void ClearRankTier()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_ClearRankTierScore"></a> ClearRankTierScore\(\)

```csharp
public void ClearRankTierScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_ClearTitle"></a> ClearTitle\(\)

```csharp
public void ClearTitle()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAProfileCard Clone()
```

#### Returns

 [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Equals_Divine_Protobufs_Dota2_CMsgDOTAProfileCard_"></a> Equals\(CMsgDOTAProfileCard\)

```csharp
public bool Equals(CMsgDOTAProfileCard other)
```

#### Parameters

`other` [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAProfileCard_"></a> MergeFrom\(CMsgDOTAProfileCard\)

```csharp
public void MergeFrom(CMsgDOTAProfileCard other)
```

#### Parameters

`other` [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

