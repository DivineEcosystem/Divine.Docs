# <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails"></a> Class CMsgDOTARealtimeGameStats.Types.MatchDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARealtimeGameStats.Types.MatchDetails : IMessage<CMsgDOTARealtimeGameStats.Types.MatchDetails>, IEquatable<CMsgDOTARealtimeGameStats.Types.MatchDetails>, IDeepCloneable<CMsgDOTARealtimeGameStats.Types.MatchDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARealtimeGameStats.Types.MatchDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.MatchDetails.md)

#### Implements

IMessage<CMsgDOTARealtimeGameStats.Types.MatchDetails\>, 
[IEquatable<CMsgDOTARealtimeGameStats.Types.MatchDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARealtimeGameStats.Types.MatchDetails\>, 
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
[EnumerableExtensions.In<CMsgDOTARealtimeGameStats.Types.MatchDetails\>\(CMsgDOTARealtimeGameStats.Types.MatchDetails, params CMsgDOTARealtimeGameStats.Types.MatchDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails__ctor"></a> MatchDetails\(\)

```csharp
public MatchDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails__ctor_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_"></a> MatchDetails\(MatchDetails\)

```csharp
public MatchDetails(CMsgDOTARealtimeGameStats.Types.MatchDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[MatchDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.MatchDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_BansFieldNumber"></a> BansFieldNumber

```csharp
public const int BansFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_BroadcastersFieldNumber"></a> BroadcastersFieldNumber

```csharp
public const int BroadcastersFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_CheersPeakFieldNumber"></a> CheersPeakFieldNumber

```csharp
public const int CheersPeakFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_GameModeFieldNumber"></a> GameModeFieldNumber

```csharp
public const int GameModeFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_GameStateFieldNumber"></a> GameStateFieldNumber

```csharp
public const int GameStateFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_GameTimeFieldNumber"></a> GameTimeFieldNumber

```csharp
public const int GameTimeFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_IsNightstalkerNightFieldNumber"></a> IsNightstalkerNightFieldNumber

```csharp
public const int IsNightstalkerNightFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_IsPlayerDraftFieldNumber"></a> IsPlayerDraftFieldNumber

```csharp
public const int IsPlayerDraftFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_KillsFieldNumber"></a> KillsFieldNumber

```csharp
public const int KillsFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_LeagueNodeIdFieldNumber"></a> LeagueNodeIdFieldNumber

```csharp
public const int LeagueNodeIdFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_LobbyTypeFieldNumber"></a> LobbyTypeFieldNumber

```csharp
public const int LobbyTypeFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_PicksFieldNumber"></a> PicksFieldNumber

```csharp
public const int PicksFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ServerSteamIdFieldNumber"></a> ServerSteamIdFieldNumber

```csharp
public const int ServerSteamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_SingleTeamFieldNumber"></a> SingleTeamFieldNumber

```csharp
public const int SingleTeamFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_StartTimestampFieldNumber"></a> StartTimestampFieldNumber

```csharp
public const int StartTimestampFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_TeamidDireFieldNumber"></a> TeamidDireFieldNumber

```csharp
public const int TeamidDireFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_TeamidRadiantFieldNumber"></a> TeamidRadiantFieldNumber

```csharp
public const int TeamidRadiantFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_TimeOfDayFieldNumber"></a> TimeOfDayFieldNumber

```csharp
public const int TimeOfDayFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_Bans"></a> Bans

```csharp
public RepeatedField<CMsgDOTARealtimeGameStats.Types.PickBanDetails> Bans { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[PickBanDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.PickBanDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_Broadcasters"></a> Broadcasters

```csharp
public RepeatedField<CMsgDOTARealtimeGameStats.Types.BroadcasterDetails> Broadcasters { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[BroadcasterDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.BroadcasterDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_CheersPeak"></a> CheersPeak

```csharp
public uint CheersPeak { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_GameMode"></a> GameMode

```csharp
public uint GameMode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_GameState"></a> GameState

```csharp
public uint GameState { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_GameTime"></a> GameTime

```csharp
public int GameTime { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_HasCheersPeak"></a> HasCheersPeak

```csharp
public bool HasCheersPeak { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_HasGameMode"></a> HasGameMode

```csharp
public bool HasGameMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_HasGameState"></a> HasGameState

```csharp
public bool HasGameState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_HasGameTime"></a> HasGameTime

```csharp
public bool HasGameTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_HasIsNightstalkerNight"></a> HasIsNightstalkerNight

```csharp
public bool HasIsNightstalkerNight { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_HasIsPlayerDraft"></a> HasIsPlayerDraft

```csharp
public bool HasIsPlayerDraft { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_HasLeagueNodeId"></a> HasLeagueNodeId

```csharp
public bool HasLeagueNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_HasLobbyType"></a> HasLobbyType

```csharp
public bool HasLobbyType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_HasServerSteamId"></a> HasServerSteamId

```csharp
public bool HasServerSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_HasSingleTeam"></a> HasSingleTeam

```csharp
public bool HasSingleTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_HasStartTimestamp"></a> HasStartTimestamp

```csharp
public bool HasStartTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_HasTeamidDire"></a> HasTeamidDire

```csharp
public bool HasTeamidDire { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_HasTeamidRadiant"></a> HasTeamidRadiant

```csharp
public bool HasTeamidRadiant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_HasTimeOfDay"></a> HasTimeOfDay

```csharp
public bool HasTimeOfDay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_IsNightstalkerNight"></a> IsNightstalkerNight

```csharp
public bool IsNightstalkerNight { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_IsPlayerDraft"></a> IsPlayerDraft

```csharp
public bool IsPlayerDraft { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_Kills"></a> Kills

```csharp
public RepeatedField<CMsgDOTARealtimeGameStats.Types.KillDetails> Kills { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[KillDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.KillDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_LeagueNodeId"></a> LeagueNodeId

```csharp
public uint LeagueNodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_LobbyType"></a> LobbyType

```csharp
public uint LobbyType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARealtimeGameStats.Types.MatchDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[MatchDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.MatchDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_Picks"></a> Picks

```csharp
public RepeatedField<CMsgDOTARealtimeGameStats.Types.PickBanDetails> Picks { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[PickBanDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.PickBanDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ServerSteamId"></a> ServerSteamId

```csharp
public ulong ServerSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_SingleTeam"></a> SingleTeam

```csharp
public bool SingleTeam { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_StartTimestamp"></a> StartTimestamp

```csharp
public uint StartTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_TeamidDire"></a> TeamidDire

```csharp
public uint TeamidDire { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_TeamidRadiant"></a> TeamidRadiant

```csharp
public uint TeamidRadiant { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_TimeOfDay"></a> TimeOfDay

```csharp
public float TimeOfDay { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ClearCheersPeak"></a> ClearCheersPeak\(\)

```csharp
public void ClearCheersPeak()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ClearGameMode"></a> ClearGameMode\(\)

```csharp
public void ClearGameMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ClearGameState"></a> ClearGameState\(\)

```csharp
public void ClearGameState()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ClearGameTime"></a> ClearGameTime\(\)

```csharp
public void ClearGameTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ClearIsNightstalkerNight"></a> ClearIsNightstalkerNight\(\)

```csharp
public void ClearIsNightstalkerNight()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ClearIsPlayerDraft"></a> ClearIsPlayerDraft\(\)

```csharp
public void ClearIsPlayerDraft()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ClearLeagueNodeId"></a> ClearLeagueNodeId\(\)

```csharp
public void ClearLeagueNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ClearLobbyType"></a> ClearLobbyType\(\)

```csharp
public void ClearLobbyType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ClearServerSteamId"></a> ClearServerSteamId\(\)

```csharp
public void ClearServerSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ClearSingleTeam"></a> ClearSingleTeam\(\)

```csharp
public void ClearSingleTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ClearStartTimestamp"></a> ClearStartTimestamp\(\)

```csharp
public void ClearStartTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ClearTeamidDire"></a> ClearTeamidDire\(\)

```csharp
public void ClearTeamidDire()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ClearTeamidRadiant"></a> ClearTeamidRadiant\(\)

```csharp
public void ClearTeamidRadiant()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ClearTimeOfDay"></a> ClearTimeOfDay\(\)

```csharp
public void ClearTimeOfDay()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARealtimeGameStats.Types.MatchDetails Clone()
```

#### Returns

 [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[MatchDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.MatchDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_Equals_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_"></a> Equals\(MatchDetails\)

```csharp
public bool Equals(CMsgDOTARealtimeGameStats.Types.MatchDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[MatchDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.MatchDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_"></a> MergeFrom\(MatchDetails\)

```csharp
public void MergeFrom(CMsgDOTARealtimeGameStats.Types.MatchDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[MatchDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.MatchDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_MatchDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

