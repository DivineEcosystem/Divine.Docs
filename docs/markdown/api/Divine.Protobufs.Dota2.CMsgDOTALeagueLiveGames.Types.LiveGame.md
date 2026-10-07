# <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame"></a> Class CMsgDOTALeagueLiveGames.Types.LiveGame

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeagueLiveGames.Types.LiveGame : IMessage<CMsgDOTALeagueLiveGames.Types.LiveGame>, IEquatable<CMsgDOTALeagueLiveGames.Types.LiveGame>, IDeepCloneable<CMsgDOTALeagueLiveGames.Types.LiveGame>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeagueLiveGames.Types.LiveGame](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.Types.LiveGame.md)

#### Implements

IMessage<CMsgDOTALeagueLiveGames.Types.LiveGame\>, 
[IEquatable<CMsgDOTALeagueLiveGames.Types.LiveGame\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeagueLiveGames.Types.LiveGame\>, 
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
[EnumerableExtensions.In<CMsgDOTALeagueLiveGames.Types.LiveGame\>\(CMsgDOTALeagueLiveGames.Types.LiveGame, params CMsgDOTALeagueLiveGames.Types.LiveGame\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame__ctor"></a> LiveGame\(\)

```csharp
public LiveGame()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame__ctor_Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_"></a> LiveGame\(LiveGame\)

```csharp
public LiveGame(CMsgDOTALeagueLiveGames.Types.LiveGame other)
```

#### Parameters

`other` [CMsgDOTALeagueLiveGames](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.Types.md).[LiveGame](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.Types.LiveGame.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_DireLogoFieldNumber"></a> DireLogoFieldNumber

```csharp
public const int DireLogoFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_DireNameFieldNumber"></a> DireNameFieldNumber

```csharp
public const int DireNameFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_DireTeamIdFieldNumber"></a> DireTeamIdFieldNumber

```csharp
public const int DireTeamIdFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_LeagueNodeIdFieldNumber"></a> LeagueNodeIdFieldNumber

```csharp
public const int LeagueNodeIdFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_RadiantLogoFieldNumber"></a> RadiantLogoFieldNumber

```csharp
public const int RadiantLogoFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_RadiantNameFieldNumber"></a> RadiantNameFieldNumber

```csharp
public const int RadiantNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_RadiantTeamIdFieldNumber"></a> RadiantTeamIdFieldNumber

```csharp
public const int RadiantTeamIdFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_SeriesIdFieldNumber"></a> SeriesIdFieldNumber

```csharp
public const int SeriesIdFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_ServerSteamIdFieldNumber"></a> ServerSteamIdFieldNumber

```csharp
public const int ServerSteamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_SpectatorsFieldNumber"></a> SpectatorsFieldNumber

```csharp
public const int SpectatorsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_TimeFieldNumber"></a> TimeFieldNumber

```csharp
public const int TimeFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_DireLogo"></a> DireLogo

```csharp
public ulong DireLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_DireName"></a> DireName

```csharp
public string DireName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_DireTeamId"></a> DireTeamId

```csharp
public uint DireTeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_HasDireLogo"></a> HasDireLogo

```csharp
public bool HasDireLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_HasDireName"></a> HasDireName

```csharp
public bool HasDireName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_HasDireTeamId"></a> HasDireTeamId

```csharp
public bool HasDireTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_HasLeagueNodeId"></a> HasLeagueNodeId

```csharp
public bool HasLeagueNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_HasRadiantLogo"></a> HasRadiantLogo

```csharp
public bool HasRadiantLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_HasRadiantName"></a> HasRadiantName

```csharp
public bool HasRadiantName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_HasRadiantTeamId"></a> HasRadiantTeamId

```csharp
public bool HasRadiantTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_HasSeriesId"></a> HasSeriesId

```csharp
public bool HasSeriesId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_HasServerSteamId"></a> HasServerSteamId

```csharp
public bool HasServerSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_HasSpectators"></a> HasSpectators

```csharp
public bool HasSpectators { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_HasTime"></a> HasTime

```csharp
public bool HasTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_LeagueNodeId"></a> LeagueNodeId

```csharp
public uint LeagueNodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeagueLiveGames.Types.LiveGame> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeagueLiveGames](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.Types.md).[LiveGame](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.Types.LiveGame.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_RadiantLogo"></a> RadiantLogo

```csharp
public ulong RadiantLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_RadiantName"></a> RadiantName

```csharp
public string RadiantName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_RadiantTeamId"></a> RadiantTeamId

```csharp
public uint RadiantTeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_SeriesId"></a> SeriesId

```csharp
public uint SeriesId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_ServerSteamId"></a> ServerSteamId

```csharp
public ulong ServerSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_Spectators"></a> Spectators

```csharp
public uint Spectators { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_Time"></a> Time

```csharp
public uint Time { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_ClearDireLogo"></a> ClearDireLogo\(\)

```csharp
public void ClearDireLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_ClearDireName"></a> ClearDireName\(\)

```csharp
public void ClearDireName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_ClearDireTeamId"></a> ClearDireTeamId\(\)

```csharp
public void ClearDireTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_ClearLeagueNodeId"></a> ClearLeagueNodeId\(\)

```csharp
public void ClearLeagueNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_ClearRadiantLogo"></a> ClearRadiantLogo\(\)

```csharp
public void ClearRadiantLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_ClearRadiantName"></a> ClearRadiantName\(\)

```csharp
public void ClearRadiantName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_ClearRadiantTeamId"></a> ClearRadiantTeamId\(\)

```csharp
public void ClearRadiantTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_ClearSeriesId"></a> ClearSeriesId\(\)

```csharp
public void ClearSeriesId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_ClearServerSteamId"></a> ClearServerSteamId\(\)

```csharp
public void ClearServerSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_ClearSpectators"></a> ClearSpectators\(\)

```csharp
public void ClearSpectators()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_ClearTime"></a> ClearTime\(\)

```csharp
public void ClearTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeagueLiveGames.Types.LiveGame Clone()
```

#### Returns

 [CMsgDOTALeagueLiveGames](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.Types.md).[LiveGame](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.Types.LiveGame.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_Equals_Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_"></a> Equals\(LiveGame\)

```csharp
public bool Equals(CMsgDOTALeagueLiveGames.Types.LiveGame other)
```

#### Parameters

`other` [CMsgDOTALeagueLiveGames](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.Types.md).[LiveGame](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.Types.LiveGame.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_"></a> MergeFrom\(LiveGame\)

```csharp
public void MergeFrom(CMsgDOTALeagueLiveGames.Types.LiveGame other)
```

#### Parameters

`other` [CMsgDOTALeagueLiveGames](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.Types.md).[LiveGame](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.Types.LiveGame.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Types_LiveGame_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

