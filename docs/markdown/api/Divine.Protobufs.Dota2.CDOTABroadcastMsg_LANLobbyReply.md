# <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply"></a> Class CDOTABroadcastMsg\_LANLobbyReply

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTABroadcastMsg_LANLobbyReply : IMessage<CDOTABroadcastMsg_LANLobbyReply>, IEquatable<CDOTABroadcastMsg_LANLobbyReply>, IDeepCloneable<CDOTABroadcastMsg_LANLobbyReply>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTABroadcastMsg\_LANLobbyReply](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.md)

#### Implements

IMessage<CDOTABroadcastMsg\_LANLobbyReply\>, 
[IEquatable<CDOTABroadcastMsg\_LANLobbyReply\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTABroadcastMsg\_LANLobbyReply\>, 
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
[EnumerableExtensions.In<CDOTABroadcastMsg\_LANLobbyReply\>\(CDOTABroadcastMsg\_LANLobbyReply, params CDOTABroadcastMsg\_LANLobbyReply\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply__ctor"></a> CDOTABroadcastMsg\_LANLobbyReply\(\)

```csharp
public CDOTABroadcastMsg_LANLobbyReply()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply__ctor_Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_"></a> CDOTABroadcastMsg\_LANLobbyReply\(CDOTABroadcastMsg\_LANLobbyReply\)

```csharp
public CDOTABroadcastMsg_LANLobbyReply(CDOTABroadcastMsg_LANLobbyReply other)
```

#### Parameters

`other` [CDOTABroadcastMsg\_LANLobbyReply](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_GameModeFieldNumber"></a> GameModeFieldNumber

```csharp
public const int GameModeFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_LeaderAccountIdFieldNumber"></a> LeaderAccountIdFieldNumber

```csharp
public const int LeaderAccountIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_MembersFieldNumber"></a> MembersFieldNumber

```csharp
public const int MembersFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_RequiresPassKeyFieldNumber"></a> RequiresPassKeyFieldNumber

```csharp
public const int RequiresPassKeyFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_TournamentGameIdFieldNumber"></a> TournamentGameIdFieldNumber

```csharp
public const int TournamentGameIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_TournamentIdFieldNumber"></a> TournamentIdFieldNumber

```csharp
public const int TournamentIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_GameMode"></a> GameMode

```csharp
public uint GameMode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_HasGameMode"></a> HasGameMode

```csharp
public bool HasGameMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_HasLeaderAccountId"></a> HasLeaderAccountId

```csharp
public bool HasLeaderAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_HasPlayers"></a> HasPlayers

```csharp
public bool HasPlayers { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_HasRequiresPassKey"></a> HasRequiresPassKey

```csharp
public bool HasRequiresPassKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_HasTournamentGameId"></a> HasTournamentGameId

```csharp
public bool HasTournamentGameId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_HasTournamentId"></a> HasTournamentId

```csharp
public bool HasTournamentId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Id"></a> Id

```csharp
public ulong Id { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_LeaderAccountId"></a> LeaderAccountId

```csharp
public uint LeaderAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Members"></a> Members

```csharp
public RepeatedField<CDOTABroadcastMsg_LANLobbyReply.Types.CLobbyMember> Members { get; }
```

#### Property Value

 RepeatedField<[CDOTABroadcastMsg\_LANLobbyReply](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.md).[Types](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.Types.md).[CLobbyMember](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.Types.CLobbyMember.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Parser"></a> Parser

```csharp
public static MessageParser<CDOTABroadcastMsg_LANLobbyReply> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTABroadcastMsg\_LANLobbyReply](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Players"></a> Players

```csharp
public uint Players { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_RequiresPassKey"></a> RequiresPassKey

```csharp
public bool RequiresPassKey { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_TournamentGameId"></a> TournamentGameId

```csharp
public uint TournamentGameId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_TournamentId"></a> TournamentId

```csharp
public uint TournamentId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_ClearGameMode"></a> ClearGameMode\(\)

```csharp
public void ClearGameMode()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_ClearLeaderAccountId"></a> ClearLeaderAccountId\(\)

```csharp
public void ClearLeaderAccountId()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_ClearPlayers"></a> ClearPlayers\(\)

```csharp
public void ClearPlayers()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_ClearRequiresPassKey"></a> ClearRequiresPassKey\(\)

```csharp
public void ClearRequiresPassKey()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_ClearTournamentGameId"></a> ClearTournamentGameId\(\)

```csharp
public void ClearTournamentGameId()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_ClearTournamentId"></a> ClearTournamentId\(\)

```csharp
public void ClearTournamentId()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Clone"></a> Clone\(\)

```csharp
public CDOTABroadcastMsg_LANLobbyReply Clone()
```

#### Returns

 [CDOTABroadcastMsg\_LANLobbyReply](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.md)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Equals_Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_"></a> Equals\(CDOTABroadcastMsg\_LANLobbyReply\)

```csharp
public bool Equals(CDOTABroadcastMsg_LANLobbyReply other)
```

#### Parameters

`other` [CDOTABroadcastMsg\_LANLobbyReply](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_MergeFrom_Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_"></a> MergeFrom\(CDOTABroadcastMsg\_LANLobbyReply\)

```csharp
public void MergeFrom(CDOTABroadcastMsg_LANLobbyReply other)
```

#### Parameters

`other` [CDOTABroadcastMsg\_LANLobbyReply](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.md)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

