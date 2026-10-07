# <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails"></a> Class CMsgSpectatorLobbyGameDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSpectatorLobbyGameDetails : IMessage<CMsgSpectatorLobbyGameDetails>, IEquatable<CMsgSpectatorLobbyGameDetails>, IDeepCloneable<CMsgSpectatorLobbyGameDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSpectatorLobbyGameDetails](Divine.Protobufs.Dota2.CMsgSpectatorLobbyGameDetails.md)

#### Implements

IMessage<CMsgSpectatorLobbyGameDetails\>, 
[IEquatable<CMsgSpectatorLobbyGameDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSpectatorLobbyGameDetails\>, 
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
[EnumerableExtensions.In<CMsgSpectatorLobbyGameDetails\>\(CMsgSpectatorLobbyGameDetails, params CMsgSpectatorLobbyGameDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails__ctor"></a> CMsgSpectatorLobbyGameDetails\(\)

```csharp
public CMsgSpectatorLobbyGameDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails__ctor_Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_"></a> CMsgSpectatorLobbyGameDetails\(CMsgSpectatorLobbyGameDetails\)

```csharp
public CMsgSpectatorLobbyGameDetails(CMsgSpectatorLobbyGameDetails other)
```

#### Parameters

`other` [CMsgSpectatorLobbyGameDetails](Divine.Protobufs.Dota2.CMsgSpectatorLobbyGameDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_DireTeamFieldNumber"></a> DireTeamFieldNumber

```csharp
public const int DireTeamFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_LanguageFieldNumber"></a> LanguageFieldNumber

```csharp
public const int LanguageFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_RadiantTeamFieldNumber"></a> RadiantTeamFieldNumber

```csharp
public const int RadiantTeamFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_SeriesGameFieldNumber"></a> SeriesGameFieldNumber

```csharp
public const int SeriesGameFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_SeriesTypeFieldNumber"></a> SeriesTypeFieldNumber

```csharp
public const int SeriesTypeFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_ServerSteamIdFieldNumber"></a> ServerSteamIdFieldNumber

```csharp
public const int ServerSteamIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_StreamNameFieldNumber"></a> StreamNameFieldNumber

```csharp
public const int StreamNameFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_StreamUrlFieldNumber"></a> StreamUrlFieldNumber

```csharp
public const int StreamUrlFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_DireTeam"></a> DireTeam

```csharp
public CMsgSpectatorLobbyGameDetails.Types.Team DireTeam { get; set; }
```

#### Property Value

 [CMsgSpectatorLobbyGameDetails](Divine.Protobufs.Dota2.CMsgSpectatorLobbyGameDetails.md).[Types](Divine.Protobufs.Dota2.CMsgSpectatorLobbyGameDetails.Types.md).[Team](Divine.Protobufs.Dota2.CMsgSpectatorLobbyGameDetails.Types.Team.md)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_HasLanguage"></a> HasLanguage

```csharp
public bool HasLanguage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_HasSeriesGame"></a> HasSeriesGame

```csharp
public bool HasSeriesGame { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_HasSeriesType"></a> HasSeriesType

```csharp
public bool HasSeriesType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_HasServerSteamId"></a> HasServerSteamId

```csharp
public bool HasServerSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_HasStreamName"></a> HasStreamName

```csharp
public bool HasStreamName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_HasStreamUrl"></a> HasStreamUrl

```csharp
public bool HasStreamUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_Language"></a> Language

```csharp
public uint Language { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSpectatorLobbyGameDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSpectatorLobbyGameDetails](Divine.Protobufs.Dota2.CMsgSpectatorLobbyGameDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_RadiantTeam"></a> RadiantTeam

```csharp
public CMsgSpectatorLobbyGameDetails.Types.Team RadiantTeam { get; set; }
```

#### Property Value

 [CMsgSpectatorLobbyGameDetails](Divine.Protobufs.Dota2.CMsgSpectatorLobbyGameDetails.md).[Types](Divine.Protobufs.Dota2.CMsgSpectatorLobbyGameDetails.Types.md).[Team](Divine.Protobufs.Dota2.CMsgSpectatorLobbyGameDetails.Types.Team.md)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_SeriesGame"></a> SeriesGame

```csharp
public uint SeriesGame { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_SeriesType"></a> SeriesType

```csharp
public uint SeriesType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_ServerSteamId"></a> ServerSteamId

```csharp
public ulong ServerSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_StreamName"></a> StreamName

```csharp
public string StreamName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_StreamUrl"></a> StreamUrl

```csharp
public string StreamUrl { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_ClearLanguage"></a> ClearLanguage\(\)

```csharp
public void ClearLanguage()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_ClearSeriesGame"></a> ClearSeriesGame\(\)

```csharp
public void ClearSeriesGame()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_ClearSeriesType"></a> ClearSeriesType\(\)

```csharp
public void ClearSeriesType()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_ClearServerSteamId"></a> ClearServerSteamId\(\)

```csharp
public void ClearServerSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_ClearStreamName"></a> ClearStreamName\(\)

```csharp
public void ClearStreamName()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_ClearStreamUrl"></a> ClearStreamUrl\(\)

```csharp
public void ClearStreamUrl()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_Clone"></a> Clone\(\)

```csharp
public CMsgSpectatorLobbyGameDetails Clone()
```

#### Returns

 [CMsgSpectatorLobbyGameDetails](Divine.Protobufs.Dota2.CMsgSpectatorLobbyGameDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_Equals_Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_"></a> Equals\(CMsgSpectatorLobbyGameDetails\)

```csharp
public bool Equals(CMsgSpectatorLobbyGameDetails other)
```

#### Parameters

`other` [CMsgSpectatorLobbyGameDetails](Divine.Protobufs.Dota2.CMsgSpectatorLobbyGameDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_"></a> MergeFrom\(CMsgSpectatorLobbyGameDetails\)

```csharp
public void MergeFrom(CMsgSpectatorLobbyGameDetails other)
```

#### Parameters

`other` [CMsgSpectatorLobbyGameDetails](Divine.Protobufs.Dota2.CMsgSpectatorLobbyGameDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyGameDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

