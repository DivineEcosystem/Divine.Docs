# <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut"></a> Class CMsgGameMatchSignOut

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameMatchSignOut : IMessage<CMsgGameMatchSignOut>, IEquatable<CMsgGameMatchSignOut>, IDeepCloneable<CMsgGameMatchSignOut>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md)

#### Implements

IMessage<CMsgGameMatchSignOut\>, 
[IEquatable<CMsgGameMatchSignOut\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameMatchSignOut\>, 
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
[EnumerableExtensions.In<CMsgGameMatchSignOut\>\(CMsgGameMatchSignOut, params CMsgGameMatchSignOut\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut__ctor"></a> CMsgGameMatchSignOut\(\)

```csharp
public CMsgGameMatchSignOut()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut__ctor_Divine_Protobufs_Dota2_CMsgGameMatchSignOut_"></a> CMsgGameMatchSignOut\(CMsgGameMatchSignOut\)

```csharp
public CMsgGameMatchSignOut(CMsgGameMatchSignOut other)
```

#### Parameters

`other` [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_AdditionalMsgsFieldNumber"></a> AdditionalMsgsFieldNumber

```csharp
public const int AdditionalMsgsFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_AutomaticSurrenderFieldNumber"></a> AutomaticSurrenderFieldNumber

```csharp
public const int AutomaticSurrenderFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_AverageNetworthDeltaFieldNumber"></a> AverageNetworthDeltaFieldNumber

```csharp
public const int AverageNetworthDeltaFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_BarracksStatusFieldNumber"></a> BarracksStatusFieldNumber

```csharp
public const int BarracksStatusFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ClusterFieldNumber"></a> ClusterFieldNumber

```csharp
public const int ClusterFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_CustomGameDataFieldNumber"></a> CustomGameDataFieldNumber

```csharp
public const int CustomGameDataFieldNumber = 37
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_DateFieldNumber"></a> DateFieldNumber

```csharp
public const int DateFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_EventGameLeaderboardEntriesFieldNumber"></a> EventGameLeaderboardEntriesFieldNumber

```csharp
public const int EventGameLeaderboardEntriesFieldNumber = 42
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_EventScoreFieldNumber"></a> EventScoreFieldNumber

```csharp
public const int EventScoreFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ExtraMessagesFieldNumber"></a> ExtraMessagesFieldNumber

```csharp
public const int ExtraMessagesFieldNumber = 54
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_FantasyStatsFieldNumber"></a> FantasyStatsFieldNumber

```csharp
public const int FantasyStatsFieldNumber = 41
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_FirstBloodTimeFieldNumber"></a> FirstBloodTimeFieldNumber

```csharp
public const int FirstBloodTimeFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_GameplayStatsFieldNumber"></a> GameplayStatsFieldNumber

```csharp
public const int GameplayStatsFieldNumber = 44
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_GoodGuysWinFieldNumber"></a> GoodGuysWinFieldNumber

```csharp
public const int GoodGuysWinFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_MatchFlagsFieldNumber"></a> MatchFlagsFieldNumber

```csharp
public const int MatchFlagsFieldNumber = 38
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_MatchTrackedStatsFieldNumber"></a> MatchTrackedStatsFieldNumber

```csharp
public const int MatchTrackedStatsFieldNumber = 58
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_NormalizedWinProbabilityDiffFieldNumber"></a> NormalizedWinProbabilityDiffFieldNumber

```csharp
public const int NormalizedWinProbabilityDiffFieldNumber = 57
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_PlayerStrangeCountAdjustmentsFieldNumber"></a> PlayerStrangeCountAdjustmentsFieldNumber

```csharp
public const int PlayerStrangeCountAdjustmentsFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_PoorNetworkConditionsFieldNumber"></a> PoorNetworkConditionsFieldNumber

```csharp
public const int PoorNetworkConditionsFieldNumber = 35
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_PreGameDurationFieldNumber"></a> PreGameDurationFieldNumber

```csharp
public const int PreGameDurationFieldNumber = 40
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ServerAddrFieldNumber"></a> ServerAddrFieldNumber

```csharp
public const int ServerAddrFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ServerVersionFieldNumber"></a> ServerVersionFieldNumber

```csharp
public const int ServerVersionFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_SocialFeedEventsFieldNumber"></a> SocialFeedEventsFieldNumber

```csharp
public const int SocialFeedEventsFieldNumber = 36
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_TeamScoresFieldNumber"></a> TeamScoresFieldNumber

```csharp
public const int TeamScoresFieldNumber = 39
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_TeamsFieldNumber"></a> TeamsFieldNumber

```csharp
public const int TeamsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_TowerStatusFieldNumber"></a> TowerStatusFieldNumber

```csharp
public const int TowerStatusFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_WinningTeamFieldNumber"></a> WinningTeamFieldNumber

```csharp
public const int WinningTeamFieldNumber = 56
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_AdditionalMsgs"></a> AdditionalMsgs

```csharp
public RepeatedField<CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg> AdditionalMsgs { get; }
```

#### Property Value

 RepeatedField<[CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CAdditionalSignoutMsg](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_AutomaticSurrender"></a> AutomaticSurrender

```csharp
public bool AutomaticSurrender { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_AverageNetworthDelta"></a> AverageNetworthDelta

```csharp
public int AverageNetworthDelta { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_BarracksStatus"></a> BarracksStatus

```csharp
public RepeatedField<uint> BarracksStatus { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Cluster"></a> Cluster

```csharp
public uint Cluster { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_CustomGameData"></a> CustomGameData

```csharp
public CMsgGameMatchSignOut.Types.CCustomGameData CustomGameData { get; set; }
```

#### Property Value

 [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CCustomGameData](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CCustomGameData.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Date"></a> Date

```csharp
public uint Date { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Duration"></a> Duration

```csharp
public uint Duration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_EventGameLeaderboardEntries"></a> EventGameLeaderboardEntries

```csharp
public RepeatedField<CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry> EventGameLeaderboardEntries { get; }
```

#### Property Value

 RepeatedField<[CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[EventGameLeaderboardEntry](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_EventScore"></a> EventScore

```csharp
public uint EventScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ExtraMessages"></a> ExtraMessages

```csharp
public RepeatedField<CExtraMsgBlock> ExtraMessages { get; }
```

#### Property Value

 RepeatedField<[CExtraMsgBlock](Divine.Protobufs.Dota2.CExtraMsgBlock.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_FantasyStats"></a> FantasyStats

```csharp
public RepeatedField<CMsgDOTAFantasyPlayerStats> FantasyStats { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAFantasyPlayerStats](Divine.Protobufs.Dota2.CMsgDOTAFantasyPlayerStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_FirstBloodTime"></a> FirstBloodTime

```csharp
public uint FirstBloodTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_GameplayStats"></a> GameplayStats

```csharp
public CMsgSignOutGameplayStats GameplayStats { get; set; }
```

#### Property Value

 [CMsgSignOutGameplayStats](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_GoodGuysWin"></a> GoodGuysWin

```csharp
public bool GoodGuysWin { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_HasAutomaticSurrender"></a> HasAutomaticSurrender

```csharp
public bool HasAutomaticSurrender { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_HasAverageNetworthDelta"></a> HasAverageNetworthDelta

```csharp
public bool HasAverageNetworthDelta { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_HasCluster"></a> HasCluster

```csharp
public bool HasCluster { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_HasDate"></a> HasDate

```csharp
public bool HasDate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_HasEventScore"></a> HasEventScore

```csharp
public bool HasEventScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_HasFirstBloodTime"></a> HasFirstBloodTime

```csharp
public bool HasFirstBloodTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_HasGoodGuysWin"></a> HasGoodGuysWin

```csharp
public bool HasGoodGuysWin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_HasMatchFlags"></a> HasMatchFlags

```csharp
public bool HasMatchFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_HasNormalizedWinProbabilityDiff"></a> HasNormalizedWinProbabilityDiff

```csharp
public bool HasNormalizedWinProbabilityDiff { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_HasPreGameDuration"></a> HasPreGameDuration

```csharp
public bool HasPreGameDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_HasServerAddr"></a> HasServerAddr

```csharp
public bool HasServerAddr { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_HasServerVersion"></a> HasServerVersion

```csharp
public bool HasServerVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_HasWinningTeam"></a> HasWinningTeam

```csharp
public bool HasWinningTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_MatchFlags"></a> MatchFlags

```csharp
public uint MatchFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_MatchTrackedStats"></a> MatchTrackedStats

```csharp
public RepeatedField<CMsgTrackedStat> MatchTrackedStats { get; }
```

#### Property Value

 RepeatedField<[CMsgTrackedStat](Divine.Protobufs.Dota2.CMsgTrackedStat.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_NormalizedWinProbabilityDiff"></a> NormalizedWinProbabilityDiff

```csharp
public float NormalizedWinProbabilityDiff { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameMatchSignOut> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_PlayerStrangeCountAdjustments"></a> PlayerStrangeCountAdjustments

```csharp
public RepeatedField<CMsgEconPlayerStrangeCountAdjustment> PlayerStrangeCountAdjustments { get; }
```

#### Property Value

 RepeatedField<[CMsgEconPlayerStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_PoorNetworkConditions"></a> PoorNetworkConditions

```csharp
public CMsgPoorNetworkConditions PoorNetworkConditions { get; set; }
```

#### Property Value

 [CMsgPoorNetworkConditions](Divine.Protobufs.Dota2.CMsgPoorNetworkConditions.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_PreGameDuration"></a> PreGameDuration

```csharp
public uint PreGameDuration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ServerAddr"></a> ServerAddr

```csharp
public string ServerAddr { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ServerVersion"></a> ServerVersion

```csharp
public uint ServerVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_SocialFeedEvents"></a> SocialFeedEvents

```csharp
public RepeatedField<CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent> SocialFeedEvents { get; }
```

#### Property Value

 RepeatedField<[CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CSocialFeedMatchEvent](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Teams"></a> Teams

```csharp
public RepeatedField<CMsgGameMatchSignOut.Types.CTeam> Teams { get; }
```

#### Property Value

 RepeatedField<[CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CTeam](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_TeamScores"></a> TeamScores

```csharp
public RepeatedField<uint> TeamScores { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_TowerStatus"></a> TowerStatus

```csharp
public RepeatedField<uint> TowerStatus { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_WinningTeam"></a> WinningTeam

```csharp
public DOTA_GC_TEAM WinningTeam { get; set; }
```

#### Property Value

 [DOTA\_GC\_TEAM](Divine.Protobufs.Dota2.DOTA\_GC\_TEAM.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ClearAutomaticSurrender"></a> ClearAutomaticSurrender\(\)

```csharp
public void ClearAutomaticSurrender()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ClearAverageNetworthDelta"></a> ClearAverageNetworthDelta\(\)

```csharp
public void ClearAverageNetworthDelta()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ClearCluster"></a> ClearCluster\(\)

```csharp
public void ClearCluster()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ClearDate"></a> ClearDate\(\)

```csharp
public void ClearDate()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ClearEventScore"></a> ClearEventScore\(\)

```csharp
public void ClearEventScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ClearFirstBloodTime"></a> ClearFirstBloodTime\(\)

```csharp
public void ClearFirstBloodTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ClearGoodGuysWin"></a> ClearGoodGuysWin\(\)

```csharp
public void ClearGoodGuysWin()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ClearMatchFlags"></a> ClearMatchFlags\(\)

```csharp
public void ClearMatchFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ClearNormalizedWinProbabilityDiff"></a> ClearNormalizedWinProbabilityDiff\(\)

```csharp
public void ClearNormalizedWinProbabilityDiff()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ClearPreGameDuration"></a> ClearPreGameDuration\(\)

```csharp
public void ClearPreGameDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ClearServerAddr"></a> ClearServerAddr\(\)

```csharp
public void ClearServerAddr()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ClearServerVersion"></a> ClearServerVersion\(\)

```csharp
public void ClearServerVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ClearWinningTeam"></a> ClearWinningTeam\(\)

```csharp
public void ClearWinningTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Clone"></a> Clone\(\)

```csharp
public CMsgGameMatchSignOut Clone()
```

#### Returns

 [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Equals_Divine_Protobufs_Dota2_CMsgGameMatchSignOut_"></a> Equals\(CMsgGameMatchSignOut\)

```csharp
public bool Equals(CMsgGameMatchSignOut other)
```

#### Parameters

`other` [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_MergeFrom_Divine_Protobufs_Dota2_CMsgGameMatchSignOut_"></a> MergeFrom\(CMsgGameMatchSignOut\)

```csharp
public void MergeFrom(CMsgGameMatchSignOut other)
```

#### Parameters

`other` [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

