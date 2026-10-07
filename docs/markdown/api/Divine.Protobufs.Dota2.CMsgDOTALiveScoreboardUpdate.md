# <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate"></a> Class CMsgDOTALiveScoreboardUpdate

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALiveScoreboardUpdate : IMessage<CMsgDOTALiveScoreboardUpdate>, IEquatable<CMsgDOTALiveScoreboardUpdate>, IDeepCloneable<CMsgDOTALiveScoreboardUpdate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALiveScoreboardUpdate](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.md)

#### Implements

IMessage<CMsgDOTALiveScoreboardUpdate\>, 
[IEquatable<CMsgDOTALiveScoreboardUpdate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALiveScoreboardUpdate\>, 
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
[EnumerableExtensions.In<CMsgDOTALiveScoreboardUpdate\>\(CMsgDOTALiveScoreboardUpdate, params CMsgDOTALiveScoreboardUpdate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate__ctor"></a> CMsgDOTALiveScoreboardUpdate\(\)

```csharp
public CMsgDOTALiveScoreboardUpdate()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate__ctor_Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_"></a> CMsgDOTALiveScoreboardUpdate\(CMsgDOTALiveScoreboardUpdate\)

```csharp
public CMsgDOTALiveScoreboardUpdate(CMsgDOTALiveScoreboardUpdate other)
```

#### Parameters

`other` [CMsgDOTALiveScoreboardUpdate](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_HltvDelayFieldNumber"></a> HltvDelayFieldNumber

```csharp
public const int HltvDelayFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_RoshanRespawnTimerFieldNumber"></a> RoshanRespawnTimerFieldNumber

```csharp
public const int RoshanRespawnTimerFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_TeamBadFieldNumber"></a> TeamBadFieldNumber

```csharp
public const int TeamBadFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_TeamGoodFieldNumber"></a> TeamGoodFieldNumber

```csharp
public const int TeamGoodFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_TournamentGameIdFieldNumber"></a> TournamentGameIdFieldNumber

```csharp
public const int TournamentGameIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_TournamentIdFieldNumber"></a> TournamentIdFieldNumber

```csharp
public const int TournamentIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Duration"></a> Duration

```csharp
public float Duration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_HasHltvDelay"></a> HasHltvDelay

```csharp
public bool HasHltvDelay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_HasRoshanRespawnTimer"></a> HasRoshanRespawnTimer

```csharp
public bool HasRoshanRespawnTimer { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_HasTournamentGameId"></a> HasTournamentGameId

```csharp
public bool HasTournamentGameId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_HasTournamentId"></a> HasTournamentId

```csharp
public bool HasTournamentId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_HltvDelay"></a> HltvDelay

```csharp
public int HltvDelay { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALiveScoreboardUpdate> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALiveScoreboardUpdate](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_RoshanRespawnTimer"></a> RoshanRespawnTimer

```csharp
public uint RoshanRespawnTimer { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_TeamBad"></a> TeamBad

```csharp
public CMsgDOTALiveScoreboardUpdate.Types.Team TeamBad { get; set; }
```

#### Property Value

 [CMsgDOTALiveScoreboardUpdate](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.Types.Team.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_TeamGood"></a> TeamGood

```csharp
public CMsgDOTALiveScoreboardUpdate.Types.Team TeamGood { get; set; }
```

#### Property Value

 [CMsgDOTALiveScoreboardUpdate](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.Types.Team.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_TournamentGameId"></a> TournamentGameId

```csharp
public uint TournamentGameId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_TournamentId"></a> TournamentId

```csharp
public uint TournamentId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_ClearHltvDelay"></a> ClearHltvDelay\(\)

```csharp
public void ClearHltvDelay()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_ClearRoshanRespawnTimer"></a> ClearRoshanRespawnTimer\(\)

```csharp
public void ClearRoshanRespawnTimer()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_ClearTournamentGameId"></a> ClearTournamentGameId\(\)

```csharp
public void ClearTournamentGameId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_ClearTournamentId"></a> ClearTournamentId\(\)

```csharp
public void ClearTournamentId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALiveScoreboardUpdate Clone()
```

#### Returns

 [CMsgDOTALiveScoreboardUpdate](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Equals_Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_"></a> Equals\(CMsgDOTALiveScoreboardUpdate\)

```csharp
public bool Equals(CMsgDOTALiveScoreboardUpdate other)
```

#### Parameters

`other` [CMsgDOTALiveScoreboardUpdate](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_"></a> MergeFrom\(CMsgDOTALiveScoreboardUpdate\)

```csharp
public void MergeFrom(CMsgDOTALiveScoreboardUpdate other)
```

#### Parameters

`other` [CMsgDOTALiveScoreboardUpdate](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

