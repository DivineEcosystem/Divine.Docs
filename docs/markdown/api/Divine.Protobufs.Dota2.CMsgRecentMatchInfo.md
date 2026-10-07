# <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo"></a> Class CMsgRecentMatchInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgRecentMatchInfo : IMessage<CMsgRecentMatchInfo>, IEquatable<CMsgRecentMatchInfo>, IDeepCloneable<CMsgRecentMatchInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgRecentMatchInfo](Divine.Protobufs.Dota2.CMsgRecentMatchInfo.md)

#### Implements

IMessage<CMsgRecentMatchInfo\>, 
[IEquatable<CMsgRecentMatchInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgRecentMatchInfo\>, 
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
[EnumerableExtensions.In<CMsgRecentMatchInfo\>\(CMsgRecentMatchInfo, params CMsgRecentMatchInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo__ctor"></a> CMsgRecentMatchInfo\(\)

```csharp
public CMsgRecentMatchInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo__ctor_Divine_Protobufs_Dota2_CMsgRecentMatchInfo_"></a> CMsgRecentMatchInfo\(CMsgRecentMatchInfo\)

```csharp
public CMsgRecentMatchInfo(CMsgRecentMatchInfo other)
```

#### Parameters

`other` [CMsgRecentMatchInfo](Divine.Protobufs.Dota2.CMsgRecentMatchInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_AssistsFieldNumber"></a> AssistsFieldNumber

```csharp
public const int AssistsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_DeathsFieldNumber"></a> DeathsFieldNumber

```csharp
public const int DeathsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_GameModeFieldNumber"></a> GameModeFieldNumber

```csharp
public const int GameModeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_KillsFieldNumber"></a> KillsFieldNumber

```csharp
public const int KillsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_LobbyTypeFieldNumber"></a> LobbyTypeFieldNumber

```csharp
public const int LobbyTypeFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_MatchOutcomeFieldNumber"></a> MatchOutcomeFieldNumber

```csharp
public const int MatchOutcomeFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_PlayerSlotFieldNumber"></a> PlayerSlotFieldNumber

```csharp
public const int PlayerSlotFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_TeamNumberFieldNumber"></a> TeamNumberFieldNumber

```csharp
public const int TeamNumberFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_Assists"></a> Assists

```csharp
public uint Assists { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_Deaths"></a> Deaths

```csharp
public uint Deaths { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_Duration"></a> Duration

```csharp
public uint Duration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_GameMode"></a> GameMode

```csharp
public DOTA_GameMode GameMode { get; set; }
```

#### Property Value

 [DOTA\_GameMode](Divine.Protobufs.Dota2.DOTA\_GameMode.md)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_HasAssists"></a> HasAssists

```csharp
public bool HasAssists { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_HasDeaths"></a> HasDeaths

```csharp
public bool HasDeaths { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_HasGameMode"></a> HasGameMode

```csharp
public bool HasGameMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_HasKills"></a> HasKills

```csharp
public bool HasKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_HasLobbyType"></a> HasLobbyType

```csharp
public bool HasLobbyType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_HasMatchOutcome"></a> HasMatchOutcome

```csharp
public bool HasMatchOutcome { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_HasPlayerSlot"></a> HasPlayerSlot

```csharp
public bool HasPlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_HasTeamNumber"></a> HasTeamNumber

```csharp
public bool HasTeamNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_Kills"></a> Kills

```csharp
public uint Kills { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_LobbyType"></a> LobbyType

```csharp
public uint LobbyType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_MatchOutcome"></a> MatchOutcome

```csharp
public EMatchOutcome MatchOutcome { get; set; }
```

#### Property Value

 [EMatchOutcome](Divine.Protobufs.Dota2.EMatchOutcome.md)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgRecentMatchInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgRecentMatchInfo](Divine.Protobufs.Dota2.CMsgRecentMatchInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_PlayerSlot"></a> PlayerSlot

```csharp
public uint PlayerSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_TeamNumber"></a> TeamNumber

```csharp
public uint TeamNumber { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_ClearAssists"></a> ClearAssists\(\)

```csharp
public void ClearAssists()
```

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_ClearDeaths"></a> ClearDeaths\(\)

```csharp
public void ClearDeaths()
```

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_ClearGameMode"></a> ClearGameMode\(\)

```csharp
public void ClearGameMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_ClearKills"></a> ClearKills\(\)

```csharp
public void ClearKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_ClearLobbyType"></a> ClearLobbyType\(\)

```csharp
public void ClearLobbyType()
```

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_ClearMatchOutcome"></a> ClearMatchOutcome\(\)

```csharp
public void ClearMatchOutcome()
```

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_ClearPlayerSlot"></a> ClearPlayerSlot\(\)

```csharp
public void ClearPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_ClearTeamNumber"></a> ClearTeamNumber\(\)

```csharp
public void ClearTeamNumber()
```

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_Clone"></a> Clone\(\)

```csharp
public CMsgRecentMatchInfo Clone()
```

#### Returns

 [CMsgRecentMatchInfo](Divine.Protobufs.Dota2.CMsgRecentMatchInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_Equals_Divine_Protobufs_Dota2_CMsgRecentMatchInfo_"></a> Equals\(CMsgRecentMatchInfo\)

```csharp
public bool Equals(CMsgRecentMatchInfo other)
```

#### Parameters

`other` [CMsgRecentMatchInfo](Divine.Protobufs.Dota2.CMsgRecentMatchInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgRecentMatchInfo_"></a> MergeFrom\(CMsgRecentMatchInfo\)

```csharp
public void MergeFrom(CMsgRecentMatchInfo other)
```

#### Parameters

`other` [CMsgRecentMatchInfo](Divine.Protobufs.Dota2.CMsgRecentMatchInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgRecentMatchInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

