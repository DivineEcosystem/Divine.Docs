# <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch"></a> Class CMsgDOTAMatch

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAMatch : IMessage<CMsgDOTAMatch>, IEquatable<CMsgDOTAMatch>, IDeepCloneable<CMsgDOTAMatch>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md)

#### Implements

IMessage<CMsgDOTAMatch\>, 
[IEquatable<CMsgDOTAMatch\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAMatch\>, 
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
[EnumerableExtensions.In<CMsgDOTAMatch\>\(CMsgDOTAMatch, params CMsgDOTAMatch\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch__ctor"></a> CMsgDOTAMatch\(\)

```csharp
public CMsgDOTAMatch()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch__ctor_Divine_Protobufs_Dota2_CMsgDOTAMatch_"></a> CMsgDOTAMatch\(CMsgDOTAMatch\)

```csharp
public CMsgDOTAMatch(CMsgDOTAMatch other)
```

#### Parameters

`other` [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_AverageSkillFieldNumber"></a> AverageSkillFieldNumber

```csharp
public const int AverageSkillFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_BarracksStatusFieldNumber"></a> BarracksStatusFieldNumber

```csharp
public const int BarracksStatusFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_BroadcasterChannelsFieldNumber"></a> BroadcasterChannelsFieldNumber

```csharp
public const int BroadcasterChannelsFieldNumber = 43
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClusterFieldNumber"></a> ClusterFieldNumber

```csharp
public const int ClusterFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_CoachesFieldNumber"></a> CoachesFieldNumber

```csharp
public const int CoachesFieldNumber = 57
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_CustomGameDataFieldNumber"></a> CustomGameDataFieldNumber

```csharp
public const int CustomGameDataFieldNumber = 45
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_DireGuildIdFieldNumber"></a> DireGuildIdFieldNumber

```csharp
public const int DireGuildIdFieldNumber = 36
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_DireTeamCompleteFieldNumber"></a> DireTeamCompleteFieldNumber

```csharp
public const int DireTeamCompleteFieldNumber = 28
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_DireTeamIdFieldNumber"></a> DireTeamIdFieldNumber

```csharp
public const int DireTeamIdFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_DireTeamLogoFieldNumber"></a> DireTeamLogoFieldNumber

```csharp
public const int DireTeamLogoFieldNumber = 26
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_DireTeamLogoUrlFieldNumber"></a> DireTeamLogoUrlFieldNumber

```csharp
public const int DireTeamLogoUrlFieldNumber = 55
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_DireTeamNameFieldNumber"></a> DireTeamNameFieldNumber

```csharp
public const int DireTeamNameFieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_DireTeamScoreFieldNumber"></a> DireTeamScoreFieldNumber

```csharp
public const int DireTeamScoreFieldNumber = 49
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_DireTeamTagFieldNumber"></a> DireTeamTagFieldNumber

```csharp
public const int DireTeamTagFieldNumber = 38
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_EngineFieldNumber"></a> EngineFieldNumber

```csharp
public const int EngineFieldNumber = 44
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_FirstBloodTimeFieldNumber"></a> FirstBloodTimeFieldNumber

```csharp
public const int FirstBloodTimeFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_GameBalanceFieldNumber"></a> GameBalanceFieldNumber

```csharp
public const int GameBalanceFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_GameModeFieldNumber"></a> GameModeFieldNumber

```csharp
public const int GameModeFieldNumber = 31
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HumanPlayersFieldNumber"></a> HumanPlayersFieldNumber

```csharp
public const int HumanPlayersFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_LeagueidFieldNumber"></a> LeagueidFieldNumber

```csharp
public const int LeagueidFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_LobbyTypeFieldNumber"></a> LobbyTypeFieldNumber

```csharp
public const int LobbyTypeFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_MatchFlagsFieldNumber"></a> MatchFlagsFieldNumber

```csharp
public const int MatchFlagsFieldNumber = 46
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_MatchOutcomeFieldNumber"></a> MatchOutcomeFieldNumber

```csharp
public const int MatchOutcomeFieldNumber = 50
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_MatchSeqNumFieldNumber"></a> MatchSeqNumFieldNumber

```csharp
public const int MatchSeqNumFieldNumber = 33
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_PicksBansFieldNumber"></a> PicksBansFieldNumber

```csharp
public const int PicksBansFieldNumber = 32
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_PreGameDurationFieldNumber"></a> PreGameDurationFieldNumber

```csharp
public const int PreGameDurationFieldNumber = 53
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_PrivateMetadataKeyFieldNumber"></a> PrivateMetadataKeyFieldNumber

```csharp
public const int PrivateMetadataKeyFieldNumber = 47
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_RadiantGuildIdFieldNumber"></a> RadiantGuildIdFieldNumber

```csharp
public const int RadiantGuildIdFieldNumber = 35
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_RadiantTeamCompleteFieldNumber"></a> RadiantTeamCompleteFieldNumber

```csharp
public const int RadiantTeamCompleteFieldNumber = 27
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_RadiantTeamIdFieldNumber"></a> RadiantTeamIdFieldNumber

```csharp
public const int RadiantTeamIdFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_RadiantTeamLogoFieldNumber"></a> RadiantTeamLogoFieldNumber

```csharp
public const int RadiantTeamLogoFieldNumber = 25
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_RadiantTeamLogoUrlFieldNumber"></a> RadiantTeamLogoUrlFieldNumber

```csharp
public const int RadiantTeamLogoUrlFieldNumber = 54
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_RadiantTeamNameFieldNumber"></a> RadiantTeamNameFieldNumber

```csharp
public const int RadiantTeamNameFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_RadiantTeamScoreFieldNumber"></a> RadiantTeamScoreFieldNumber

```csharp
public const int RadiantTeamScoreFieldNumber = 48
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_RadiantTeamTagFieldNumber"></a> RadiantTeamTagFieldNumber

```csharp
public const int RadiantTeamTagFieldNumber = 37
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ReplaySaltFieldNumber"></a> ReplaySaltFieldNumber

```csharp
public const int ReplaySaltFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ReplayStateFieldNumber"></a> ReplayStateFieldNumber

```csharp
public const int ReplayStateFieldNumber = 34
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_SeriesIdFieldNumber"></a> SeriesIdFieldNumber

```csharp
public const int SeriesIdFieldNumber = 39
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_SeriesTypeFieldNumber"></a> SeriesTypeFieldNumber

```csharp
public const int SeriesTypeFieldNumber = 40
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ServerIpFieldNumber"></a> ServerIpFieldNumber

```csharp
public const int ServerIpFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ServerPortFieldNumber"></a> ServerPortFieldNumber

```csharp
public const int ServerPortFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_StarttimeFieldNumber"></a> StarttimeFieldNumber

```csharp
public const int StarttimeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_TournamentIdFieldNumber"></a> TournamentIdFieldNumber

```csharp
public const int TournamentIdFieldNumber = 51
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_TournamentRoundFieldNumber"></a> TournamentRoundFieldNumber

```csharp
public const int TournamentRoundFieldNumber = 52
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_TowerStatusFieldNumber"></a> TowerStatusFieldNumber

```csharp
public const int TowerStatusFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_AverageSkill"></a> AverageSkill

```csharp
public uint AverageSkill { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_BarracksStatus"></a> BarracksStatus

```csharp
public RepeatedField<uint> BarracksStatus { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_BroadcasterChannels"></a> BroadcasterChannels

```csharp
public RepeatedField<CMsgDOTAMatch.Types.BroadcasterChannel> BroadcasterChannels { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[BroadcasterChannel](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.BroadcasterChannel.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Cluster"></a> Cluster

```csharp
public uint Cluster { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Coaches"></a> Coaches

```csharp
public RepeatedField<CMsgDOTAMatch.Types.Coach> Coaches { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[Coach](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Coach.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_CustomGameData"></a> CustomGameData

```csharp
public CMsgDOTAMatch.Types.CustomGameData CustomGameData { get; set; }
```

#### Property Value

 [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[CustomGameData](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.CustomGameData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_DireGuildId"></a> DireGuildId

```csharp
public uint DireGuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_DireTeamComplete"></a> DireTeamComplete

```csharp
public uint DireTeamComplete { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_DireTeamId"></a> DireTeamId

```csharp
public uint DireTeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_DireTeamLogo"></a> DireTeamLogo

```csharp
public ulong DireTeamLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_DireTeamLogoUrl"></a> DireTeamLogoUrl

```csharp
public string DireTeamLogoUrl { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_DireTeamName"></a> DireTeamName

```csharp
public string DireTeamName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_DireTeamScore"></a> DireTeamScore

```csharp
public uint DireTeamScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_DireTeamTag"></a> DireTeamTag

```csharp
public string DireTeamTag { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Duration"></a> Duration

```csharp
public uint Duration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Engine"></a> Engine

```csharp
public uint Engine { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_FirstBloodTime"></a> FirstBloodTime

```csharp
public uint FirstBloodTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_GameBalance"></a> GameBalance

```csharp
public float GameBalance { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_GameMode"></a> GameMode

```csharp
public DOTA_GameMode GameMode { get; set; }
```

#### Property Value

 [DOTA\_GameMode](Divine.Protobufs.Dota2.DOTA\_GameMode.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasAverageSkill"></a> HasAverageSkill

```csharp
public bool HasAverageSkill { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasCluster"></a> HasCluster

```csharp
public bool HasCluster { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasDireGuildId"></a> HasDireGuildId

```csharp
public bool HasDireGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasDireTeamComplete"></a> HasDireTeamComplete

```csharp
public bool HasDireTeamComplete { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasDireTeamId"></a> HasDireTeamId

```csharp
public bool HasDireTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasDireTeamLogo"></a> HasDireTeamLogo

```csharp
public bool HasDireTeamLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasDireTeamLogoUrl"></a> HasDireTeamLogoUrl

```csharp
public bool HasDireTeamLogoUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasDireTeamName"></a> HasDireTeamName

```csharp
public bool HasDireTeamName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasDireTeamScore"></a> HasDireTeamScore

```csharp
public bool HasDireTeamScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasDireTeamTag"></a> HasDireTeamTag

```csharp
public bool HasDireTeamTag { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasEngine"></a> HasEngine

```csharp
public bool HasEngine { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasFirstBloodTime"></a> HasFirstBloodTime

```csharp
public bool HasFirstBloodTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasGameBalance"></a> HasGameBalance

```csharp
public bool HasGameBalance { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasGameMode"></a> HasGameMode

```csharp
public bool HasGameMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasHumanPlayers"></a> HasHumanPlayers

```csharp
public bool HasHumanPlayers { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasLeagueid"></a> HasLeagueid

```csharp
public bool HasLeagueid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasLobbyType"></a> HasLobbyType

```csharp
public bool HasLobbyType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasMatchFlags"></a> HasMatchFlags

```csharp
public bool HasMatchFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasMatchOutcome"></a> HasMatchOutcome

```csharp
public bool HasMatchOutcome { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasMatchSeqNum"></a> HasMatchSeqNum

```csharp
public bool HasMatchSeqNum { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasPreGameDuration"></a> HasPreGameDuration

```csharp
public bool HasPreGameDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasPrivateMetadataKey"></a> HasPrivateMetadataKey

```csharp
public bool HasPrivateMetadataKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasRadiantGuildId"></a> HasRadiantGuildId

```csharp
public bool HasRadiantGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasRadiantTeamComplete"></a> HasRadiantTeamComplete

```csharp
public bool HasRadiantTeamComplete { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasRadiantTeamId"></a> HasRadiantTeamId

```csharp
public bool HasRadiantTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasRadiantTeamLogo"></a> HasRadiantTeamLogo

```csharp
public bool HasRadiantTeamLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasRadiantTeamLogoUrl"></a> HasRadiantTeamLogoUrl

```csharp
public bool HasRadiantTeamLogoUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasRadiantTeamName"></a> HasRadiantTeamName

```csharp
public bool HasRadiantTeamName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasRadiantTeamScore"></a> HasRadiantTeamScore

```csharp
public bool HasRadiantTeamScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasRadiantTeamTag"></a> HasRadiantTeamTag

```csharp
public bool HasRadiantTeamTag { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasReplaySalt"></a> HasReplaySalt

```csharp
public bool HasReplaySalt { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasReplayState"></a> HasReplayState

```csharp
public bool HasReplayState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasSeriesId"></a> HasSeriesId

```csharp
public bool HasSeriesId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasSeriesType"></a> HasSeriesType

```csharp
public bool HasSeriesType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasServerIp"></a> HasServerIp

```csharp
public bool HasServerIp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasServerPort"></a> HasServerPort

```csharp
public bool HasServerPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasStarttime"></a> HasStarttime

```csharp
public bool HasStarttime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasTournamentId"></a> HasTournamentId

```csharp
public bool HasTournamentId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HasTournamentRound"></a> HasTournamentRound

```csharp
public bool HasTournamentRound { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_HumanPlayers"></a> HumanPlayers

```csharp
public uint HumanPlayers { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Leagueid"></a> Leagueid

```csharp
public uint Leagueid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_LobbyType"></a> LobbyType

```csharp
public uint LobbyType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_MatchFlags"></a> MatchFlags

```csharp
public uint MatchFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_MatchOutcome"></a> MatchOutcome

```csharp
public EMatchOutcome MatchOutcome { get; set; }
```

#### Property Value

 [EMatchOutcome](Divine.Protobufs.Dota2.EMatchOutcome.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_MatchSeqNum"></a> MatchSeqNum

```csharp
public ulong MatchSeqNum { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAMatch> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_PicksBans"></a> PicksBans

```csharp
public RepeatedField<CMatchHeroSelectEvent> PicksBans { get; }
```

#### Property Value

 RepeatedField<[CMatchHeroSelectEvent](Divine.Protobufs.Dota2.CMatchHeroSelectEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Players"></a> Players

```csharp
public RepeatedField<CMsgDOTAMatch.Types.Player> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[Player](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_PreGameDuration"></a> PreGameDuration

```csharp
public uint PreGameDuration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_PrivateMetadataKey"></a> PrivateMetadataKey

```csharp
public uint PrivateMetadataKey { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_RadiantGuildId"></a> RadiantGuildId

```csharp
public uint RadiantGuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_RadiantTeamComplete"></a> RadiantTeamComplete

```csharp
public uint RadiantTeamComplete { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_RadiantTeamId"></a> RadiantTeamId

```csharp
public uint RadiantTeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_RadiantTeamLogo"></a> RadiantTeamLogo

```csharp
public ulong RadiantTeamLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_RadiantTeamLogoUrl"></a> RadiantTeamLogoUrl

```csharp
public string RadiantTeamLogoUrl { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_RadiantTeamName"></a> RadiantTeamName

```csharp
public string RadiantTeamName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_RadiantTeamScore"></a> RadiantTeamScore

```csharp
public uint RadiantTeamScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_RadiantTeamTag"></a> RadiantTeamTag

```csharp
public string RadiantTeamTag { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ReplaySalt"></a> ReplaySalt

```csharp
public uint ReplaySalt { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ReplayState"></a> ReplayState

```csharp
public CMsgDOTAMatch.Types.ReplayState ReplayState { get; set; }
```

#### Property Value

 [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[ReplayState](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.ReplayState.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_SeriesId"></a> SeriesId

```csharp
public uint SeriesId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_SeriesType"></a> SeriesType

```csharp
public uint SeriesType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ServerIp"></a> ServerIp

```csharp
public uint ServerIp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ServerPort"></a> ServerPort

```csharp
public uint ServerPort { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Starttime"></a> Starttime

```csharp
public uint Starttime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_TournamentId"></a> TournamentId

```csharp
public uint TournamentId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_TournamentRound"></a> TournamentRound

```csharp
public uint TournamentRound { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_TowerStatus"></a> TowerStatus

```csharp
public RepeatedField<uint> TowerStatus { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearAverageSkill"></a> ClearAverageSkill\(\)

```csharp
public void ClearAverageSkill()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearCluster"></a> ClearCluster\(\)

```csharp
public void ClearCluster()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearDireGuildId"></a> ClearDireGuildId\(\)

```csharp
public void ClearDireGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearDireTeamComplete"></a> ClearDireTeamComplete\(\)

```csharp
public void ClearDireTeamComplete()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearDireTeamId"></a> ClearDireTeamId\(\)

```csharp
public void ClearDireTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearDireTeamLogo"></a> ClearDireTeamLogo\(\)

```csharp
public void ClearDireTeamLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearDireTeamLogoUrl"></a> ClearDireTeamLogoUrl\(\)

```csharp
public void ClearDireTeamLogoUrl()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearDireTeamName"></a> ClearDireTeamName\(\)

```csharp
public void ClearDireTeamName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearDireTeamScore"></a> ClearDireTeamScore\(\)

```csharp
public void ClearDireTeamScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearDireTeamTag"></a> ClearDireTeamTag\(\)

```csharp
public void ClearDireTeamTag()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearEngine"></a> ClearEngine\(\)

```csharp
public void ClearEngine()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearFirstBloodTime"></a> ClearFirstBloodTime\(\)

```csharp
public void ClearFirstBloodTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearGameBalance"></a> ClearGameBalance\(\)

```csharp
public void ClearGameBalance()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearGameMode"></a> ClearGameMode\(\)

```csharp
public void ClearGameMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearHumanPlayers"></a> ClearHumanPlayers\(\)

```csharp
public void ClearHumanPlayers()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearLeagueid"></a> ClearLeagueid\(\)

```csharp
public void ClearLeagueid()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearLobbyType"></a> ClearLobbyType\(\)

```csharp
public void ClearLobbyType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearMatchFlags"></a> ClearMatchFlags\(\)

```csharp
public void ClearMatchFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearMatchOutcome"></a> ClearMatchOutcome\(\)

```csharp
public void ClearMatchOutcome()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearMatchSeqNum"></a> ClearMatchSeqNum\(\)

```csharp
public void ClearMatchSeqNum()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearPreGameDuration"></a> ClearPreGameDuration\(\)

```csharp
public void ClearPreGameDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearPrivateMetadataKey"></a> ClearPrivateMetadataKey\(\)

```csharp
public void ClearPrivateMetadataKey()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearRadiantGuildId"></a> ClearRadiantGuildId\(\)

```csharp
public void ClearRadiantGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearRadiantTeamComplete"></a> ClearRadiantTeamComplete\(\)

```csharp
public void ClearRadiantTeamComplete()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearRadiantTeamId"></a> ClearRadiantTeamId\(\)

```csharp
public void ClearRadiantTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearRadiantTeamLogo"></a> ClearRadiantTeamLogo\(\)

```csharp
public void ClearRadiantTeamLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearRadiantTeamLogoUrl"></a> ClearRadiantTeamLogoUrl\(\)

```csharp
public void ClearRadiantTeamLogoUrl()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearRadiantTeamName"></a> ClearRadiantTeamName\(\)

```csharp
public void ClearRadiantTeamName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearRadiantTeamScore"></a> ClearRadiantTeamScore\(\)

```csharp
public void ClearRadiantTeamScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearRadiantTeamTag"></a> ClearRadiantTeamTag\(\)

```csharp
public void ClearRadiantTeamTag()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearReplaySalt"></a> ClearReplaySalt\(\)

```csharp
public void ClearReplaySalt()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearReplayState"></a> ClearReplayState\(\)

```csharp
public void ClearReplayState()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearSeriesId"></a> ClearSeriesId\(\)

```csharp
public void ClearSeriesId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearSeriesType"></a> ClearSeriesType\(\)

```csharp
public void ClearSeriesType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearServerIp"></a> ClearServerIp\(\)

```csharp
public void ClearServerIp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearServerPort"></a> ClearServerPort\(\)

```csharp
public void ClearServerPort()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearStarttime"></a> ClearStarttime\(\)

```csharp
public void ClearStarttime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearTournamentId"></a> ClearTournamentId\(\)

```csharp
public void ClearTournamentId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ClearTournamentRound"></a> ClearTournamentRound\(\)

```csharp
public void ClearTournamentRound()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAMatch Clone()
```

#### Returns

 [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Equals_Divine_Protobufs_Dota2_CMsgDOTAMatch_"></a> Equals\(CMsgDOTAMatch\)

```csharp
public bool Equals(CMsgDOTAMatch other)
```

#### Parameters

`other` [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAMatch_"></a> MergeFrom\(CMsgDOTAMatch\)

```csharp
public void MergeFrom(CMsgDOTAMatch other)
```

#### Parameters

`other` [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

