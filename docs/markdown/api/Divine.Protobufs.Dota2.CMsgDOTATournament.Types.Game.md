# <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game"></a> Class CMsgDOTATournament.Types.Game

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATournament.Types.Game : IMessage<CMsgDOTATournament.Types.Game>, IEquatable<CMsgDOTATournament.Types.Game>, IDeepCloneable<CMsgDOTATournament.Types.Game>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATournament.Types.Game](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.Game.md)

#### Implements

IMessage<CMsgDOTATournament.Types.Game\>, 
[IEquatable<CMsgDOTATournament.Types.Game\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATournament.Types.Game\>, 
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
[EnumerableExtensions.In<CMsgDOTATournament.Types.Game\>\(CMsgDOTATournament.Types.Game, params CMsgDOTATournament.Types.Game\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game__ctor"></a> Game\(\)

```csharp
public Game()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game__ctor_Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_"></a> Game\(Game\)

```csharp
public Game(CMsgDOTATournament.Types.Game other)
```

#### Parameters

`other` [CMsgDOTATournament](Divine.Protobufs.Dota2.CMsgDOTATournament.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.md).[Game](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.Game.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_LobbyIdFieldNumber"></a> LobbyIdFieldNumber

```csharp
public const int LobbyIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_NodeIdxFieldNumber"></a> NodeIdxFieldNumber

```csharp
public const int NodeIdxFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_StartTimeFieldNumber"></a> StartTimeFieldNumber

```csharp
public const int StartTimeFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_StateFieldNumber"></a> StateFieldNumber

```csharp
public const int StateFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_TeamAGoodFieldNumber"></a> TeamAGoodFieldNumber

```csharp
public const int TeamAGoodFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_HasLobbyId"></a> HasLobbyId

```csharp
public bool HasLobbyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_HasNodeIdx"></a> HasNodeIdx

```csharp
public bool HasNodeIdx { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_HasStartTime"></a> HasStartTime

```csharp
public bool HasStartTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_HasState"></a> HasState

```csharp
public bool HasState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_HasTeamAGood"></a> HasTeamAGood

```csharp
public bool HasTeamAGood { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_LobbyId"></a> LobbyId

```csharp
public ulong LobbyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_NodeIdx"></a> NodeIdx

```csharp
public uint NodeIdx { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATournament.Types.Game> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATournament](Divine.Protobufs.Dota2.CMsgDOTATournament.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.md).[Game](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.Game.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_StartTime"></a> StartTime

```csharp
public uint StartTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_State"></a> State

```csharp
public ETournamentGameState State { get; set; }
```

#### Property Value

 [ETournamentGameState](Divine.Protobufs.Dota2.ETournamentGameState.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_TeamAGood"></a> TeamAGood

```csharp
public bool TeamAGood { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_ClearLobbyId"></a> ClearLobbyId\(\)

```csharp
public void ClearLobbyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_ClearNodeIdx"></a> ClearNodeIdx\(\)

```csharp
public void ClearNodeIdx()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_ClearStartTime"></a> ClearStartTime\(\)

```csharp
public void ClearStartTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_ClearState"></a> ClearState\(\)

```csharp
public void ClearState()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_ClearTeamAGood"></a> ClearTeamAGood\(\)

```csharp
public void ClearTeamAGood()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATournament.Types.Game Clone()
```

#### Returns

 [CMsgDOTATournament](Divine.Protobufs.Dota2.CMsgDOTATournament.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.md).[Game](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.Game.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_Equals_Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_"></a> Equals\(Game\)

```csharp
public bool Equals(CMsgDOTATournament.Types.Game other)
```

#### Parameters

`other` [CMsgDOTATournament](Divine.Protobufs.Dota2.CMsgDOTATournament.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.md).[Game](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.Game.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_"></a> MergeFrom\(Game\)

```csharp
public void MergeFrom(CMsgDOTATournament.Types.Game other)
```

#### Parameters

`other` [CMsgDOTATournament](Divine.Protobufs.Dota2.CMsgDOTATournament.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.md).[Game](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.Game.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Types_Game_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

