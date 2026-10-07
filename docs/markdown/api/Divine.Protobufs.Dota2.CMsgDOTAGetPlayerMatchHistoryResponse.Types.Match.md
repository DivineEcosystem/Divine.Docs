# <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match"></a> Class CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match : IMessage<CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match>, IEquatable<CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match>, IDeepCloneable<CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match.md)

#### Implements

IMessage<CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match\>, 
[IEquatable<CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match\>, 
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
[EnumerableExtensions.In<CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match\>\(CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match, params CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match__ctor"></a> Match\(\)

```csharp
public Match()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match__ctor_Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_"></a> Match\(Match\)

```csharp
public Match(CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match other)
```

#### Parameters

`other` [CMsgDOTAGetPlayerMatchHistoryResponse](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.Types.md).[Match](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_AbandonFieldNumber"></a> AbandonFieldNumber

```csharp
public const int AbandonFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ActivePlusSubscriptionFieldNumber"></a> ActivePlusSubscriptionFieldNumber

```csharp
public const int ActivePlusSubscriptionFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_EngineFieldNumber"></a> EngineFieldNumber

```csharp
public const int EngineFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_GameModeFieldNumber"></a> GameModeFieldNumber

```csharp
public const int GameModeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_LobbyTypeFieldNumber"></a> LobbyTypeFieldNumber

```csharp
public const int LobbyTypeFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_PreviousRankFieldNumber"></a> PreviousRankFieldNumber

```csharp
public const int PreviousRankFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_RankChangeFieldNumber"></a> RankChangeFieldNumber

```csharp
public const int RankChangeFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_SeasonalRankFieldNumber"></a> SeasonalRankFieldNumber

```csharp
public const int SeasonalRankFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_SelectedFacetFieldNumber"></a> SelectedFacetFieldNumber

```csharp
public const int SelectedFacetFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_SoloRankFieldNumber"></a> SoloRankFieldNumber

```csharp
public const int SoloRankFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_StartTimeFieldNumber"></a> StartTimeFieldNumber

```csharp
public const int StartTimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_TeamNameFieldNumber"></a> TeamNameFieldNumber

```csharp
public const int TeamNameFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_TourneyDivisionFieldNumber"></a> TourneyDivisionFieldNumber

```csharp
public const int TourneyDivisionFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_TourneyIdFieldNumber"></a> TourneyIdFieldNumber

```csharp
public const int TourneyIdFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_TourneyRoundFieldNumber"></a> TourneyRoundFieldNumber

```csharp
public const int TourneyRoundFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_TourneyTierFieldNumber"></a> TourneyTierFieldNumber

```csharp
public const int TourneyTierFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_UgcTeamUiLogoFieldNumber"></a> UgcTeamUiLogoFieldNumber

```csharp
public const int UgcTeamUiLogoFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_WinnerFieldNumber"></a> WinnerFieldNumber

```csharp
public const int WinnerFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_Abandon"></a> Abandon

```csharp
public bool Abandon { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ActivePlusSubscription"></a> ActivePlusSubscription

```csharp
public bool ActivePlusSubscription { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_Duration"></a> Duration

```csharp
public uint Duration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_Engine"></a> Engine

```csharp
public uint Engine { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_GameMode"></a> GameMode

```csharp
public uint GameMode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasAbandon"></a> HasAbandon

```csharp
public bool HasAbandon { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasActivePlusSubscription"></a> HasActivePlusSubscription

```csharp
public bool HasActivePlusSubscription { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasEngine"></a> HasEngine

```csharp
public bool HasEngine { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasGameMode"></a> HasGameMode

```csharp
public bool HasGameMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasLobbyType"></a> HasLobbyType

```csharp
public bool HasLobbyType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasPreviousRank"></a> HasPreviousRank

```csharp
public bool HasPreviousRank { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasRankChange"></a> HasRankChange

```csharp
public bool HasRankChange { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasSeasonalRank"></a> HasSeasonalRank

```csharp
public bool HasSeasonalRank { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasSelectedFacet"></a> HasSelectedFacet

```csharp
public bool HasSelectedFacet { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasSoloRank"></a> HasSoloRank

```csharp
public bool HasSoloRank { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasStartTime"></a> HasStartTime

```csharp
public bool HasStartTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasTeamName"></a> HasTeamName

```csharp
public bool HasTeamName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasTourneyDivision"></a> HasTourneyDivision

```csharp
public bool HasTourneyDivision { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasTourneyId"></a> HasTourneyId

```csharp
public bool HasTourneyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasTourneyRound"></a> HasTourneyRound

```csharp
public bool HasTourneyRound { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasTourneyTier"></a> HasTourneyTier

```csharp
public bool HasTourneyTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasUgcTeamUiLogo"></a> HasUgcTeamUiLogo

```csharp
public bool HasUgcTeamUiLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HasWinner"></a> HasWinner

```csharp
public bool HasWinner { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_LobbyType"></a> LobbyType

```csharp
public uint LobbyType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAGetPlayerMatchHistoryResponse](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.Types.md).[Match](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_PreviousRank"></a> PreviousRank

```csharp
public uint PreviousRank { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_RankChange"></a> RankChange

```csharp
public int RankChange { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_SeasonalRank"></a> SeasonalRank

```csharp
public bool SeasonalRank { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_SelectedFacet"></a> SelectedFacet

```csharp
public uint SelectedFacet { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_SoloRank"></a> SoloRank

```csharp
public bool SoloRank { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_StartTime"></a> StartTime

```csharp
public uint StartTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_TeamName"></a> TeamName

```csharp
public string TeamName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_TourneyDivision"></a> TourneyDivision

```csharp
public uint TourneyDivision { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_TourneyId"></a> TourneyId

```csharp
public uint TourneyId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_TourneyRound"></a> TourneyRound

```csharp
public uint TourneyRound { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_TourneyTier"></a> TourneyTier

```csharp
public uint TourneyTier { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_UgcTeamUiLogo"></a> UgcTeamUiLogo

```csharp
public ulong UgcTeamUiLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_Winner"></a> Winner

```csharp
public bool Winner { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearAbandon"></a> ClearAbandon\(\)

```csharp
public void ClearAbandon()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearActivePlusSubscription"></a> ClearActivePlusSubscription\(\)

```csharp
public void ClearActivePlusSubscription()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearEngine"></a> ClearEngine\(\)

```csharp
public void ClearEngine()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearGameMode"></a> ClearGameMode\(\)

```csharp
public void ClearGameMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearLobbyType"></a> ClearLobbyType\(\)

```csharp
public void ClearLobbyType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearPreviousRank"></a> ClearPreviousRank\(\)

```csharp
public void ClearPreviousRank()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearRankChange"></a> ClearRankChange\(\)

```csharp
public void ClearRankChange()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearSeasonalRank"></a> ClearSeasonalRank\(\)

```csharp
public void ClearSeasonalRank()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearSelectedFacet"></a> ClearSelectedFacet\(\)

```csharp
public void ClearSelectedFacet()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearSoloRank"></a> ClearSoloRank\(\)

```csharp
public void ClearSoloRank()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearStartTime"></a> ClearStartTime\(\)

```csharp
public void ClearStartTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearTeamName"></a> ClearTeamName\(\)

```csharp
public void ClearTeamName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearTourneyDivision"></a> ClearTourneyDivision\(\)

```csharp
public void ClearTourneyDivision()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearTourneyId"></a> ClearTourneyId\(\)

```csharp
public void ClearTourneyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearTourneyRound"></a> ClearTourneyRound\(\)

```csharp
public void ClearTourneyRound()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearTourneyTier"></a> ClearTourneyTier\(\)

```csharp
public void ClearTourneyTier()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearUgcTeamUiLogo"></a> ClearUgcTeamUiLogo\(\)

```csharp
public void ClearUgcTeamUiLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ClearWinner"></a> ClearWinner\(\)

```csharp
public void ClearWinner()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match Clone()
```

#### Returns

 [CMsgDOTAGetPlayerMatchHistoryResponse](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.Types.md).[Match](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_Equals_Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_"></a> Equals\(Match\)

```csharp
public bool Equals(CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match other)
```

#### Parameters

`other` [CMsgDOTAGetPlayerMatchHistoryResponse](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.Types.md).[Match](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_"></a> MergeFrom\(Match\)

```csharp
public void MergeFrom(CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match other)
```

#### Parameters

`other` [CMsgDOTAGetPlayerMatchHistoryResponse](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.Types.md).[Match](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Types_Match_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

