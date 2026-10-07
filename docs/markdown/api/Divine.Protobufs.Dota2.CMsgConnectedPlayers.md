# <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers"></a> Class CMsgConnectedPlayers

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgConnectedPlayers : IMessage<CMsgConnectedPlayers>, IEquatable<CMsgConnectedPlayers>, IDeepCloneable<CMsgConnectedPlayers>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md)

#### Implements

IMessage<CMsgConnectedPlayers\>, 
[IEquatable<CMsgConnectedPlayers\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgConnectedPlayers\>, 
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
[EnumerableExtensions.In<CMsgConnectedPlayers\>\(CMsgConnectedPlayers, params CMsgConnectedPlayers\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers__ctor"></a> CMsgConnectedPlayers\(\)

```csharp
public CMsgConnectedPlayers()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers__ctor_Divine_Protobufs_Dota2_CMsgConnectedPlayers_"></a> CMsgConnectedPlayers\(CMsgConnectedPlayers\)

```csharp
public CMsgConnectedPlayers(CMsgConnectedPlayers other)
```

#### Parameters

`other` [CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_BuildingStateFieldNumber"></a> BuildingStateFieldNumber

```csharp
public const int BuildingStateFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_ConnectedPlayersFieldNumber"></a> ConnectedPlayersFieldNumber

```csharp
public const int ConnectedPlayersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_DireKillsFieldNumber"></a> DireKillsFieldNumber

```csharp
public const int DireKillsFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_DisconnectedPlayersFieldNumber"></a> DisconnectedPlayersFieldNumber

```csharp
public const int DisconnectedPlayersFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_FirstBloodHappenedFieldNumber"></a> FirstBloodHappenedFieldNumber

```csharp
public const int FirstBloodHappenedFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_GameStateFieldNumber"></a> GameStateFieldNumber

```csharp
public const int GameStateFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_PlayerDraftFieldNumber"></a> PlayerDraftFieldNumber

```csharp
public const int PlayerDraftFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_PoorNetworkConditionsFieldNumber"></a> PoorNetworkConditionsFieldNumber

```csharp
public const int PoorNetworkConditionsFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_RadiantKillsFieldNumber"></a> RadiantKillsFieldNumber

```csharp
public const int RadiantKillsFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_RadiantLeadFieldNumber"></a> RadiantLeadFieldNumber

```csharp
public const int RadiantLeadFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_SendReasonFieldNumber"></a> SendReasonFieldNumber

```csharp
public const int SendReasonFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_BuildingState"></a> BuildingState

```csharp
public uint BuildingState { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_ConnectedPlayers"></a> ConnectedPlayers

```csharp
public RepeatedField<CMsgConnectedPlayers.Types.Player> ConnectedPlayers { get; }
```

#### Property Value

 RepeatedField<[CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md).[Types](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.md).[Player](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_DireKills"></a> DireKills

```csharp
public uint DireKills { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_DisconnectedPlayers"></a> DisconnectedPlayers

```csharp
public RepeatedField<CMsgConnectedPlayers.Types.Player> DisconnectedPlayers { get; }
```

#### Property Value

 RepeatedField<[CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md).[Types](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.md).[Player](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_FirstBloodHappened"></a> FirstBloodHappened

```csharp
public bool FirstBloodHappened { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_GameState"></a> GameState

```csharp
public DOTA_GameState GameState { get; set; }
```

#### Property Value

 [DOTA\_GameState](Divine.Protobufs.Dota2.DOTA\_GameState.md)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_HasBuildingState"></a> HasBuildingState

```csharp
public bool HasBuildingState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_HasDireKills"></a> HasDireKills

```csharp
public bool HasDireKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_HasFirstBloodHappened"></a> HasFirstBloodHappened

```csharp
public bool HasFirstBloodHappened { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_HasGameState"></a> HasGameState

```csharp
public bool HasGameState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_HasRadiantKills"></a> HasRadiantKills

```csharp
public bool HasRadiantKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_HasRadiantLead"></a> HasRadiantLead

```csharp
public bool HasRadiantLead { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_HasSendReason"></a> HasSendReason

```csharp
public bool HasSendReason { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Parser"></a> Parser

```csharp
public static MessageParser<CMsgConnectedPlayers> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_PlayerDraft"></a> PlayerDraft

```csharp
public RepeatedField<CMsgConnectedPlayers.Types.PlayerDraft> PlayerDraft { get; }
```

#### Property Value

 RepeatedField<[CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md).[Types](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.md).[PlayerDraft](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.PlayerDraft.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_PoorNetworkConditions"></a> PoorNetworkConditions

```csharp
public CMsgPoorNetworkConditions PoorNetworkConditions { get; set; }
```

#### Property Value

 [CMsgPoorNetworkConditions](Divine.Protobufs.Dota2.CMsgPoorNetworkConditions.md)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_RadiantKills"></a> RadiantKills

```csharp
public uint RadiantKills { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_RadiantLead"></a> RadiantLead

```csharp
public int RadiantLead { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_SendReason"></a> SendReason

```csharp
public CMsgConnectedPlayers.Types.SendReason SendReason { get; set; }
```

#### Property Value

 [CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md).[Types](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.md).[SendReason](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.SendReason.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_ClearBuildingState"></a> ClearBuildingState\(\)

```csharp
public void ClearBuildingState()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_ClearDireKills"></a> ClearDireKills\(\)

```csharp
public void ClearDireKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_ClearFirstBloodHappened"></a> ClearFirstBloodHappened\(\)

```csharp
public void ClearFirstBloodHappened()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_ClearGameState"></a> ClearGameState\(\)

```csharp
public void ClearGameState()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_ClearRadiantKills"></a> ClearRadiantKills\(\)

```csharp
public void ClearRadiantKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_ClearRadiantLead"></a> ClearRadiantLead\(\)

```csharp
public void ClearRadiantLead()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_ClearSendReason"></a> ClearSendReason\(\)

```csharp
public void ClearSendReason()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Clone"></a> Clone\(\)

```csharp
public CMsgConnectedPlayers Clone()
```

#### Returns

 [CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Equals_Divine_Protobufs_Dota2_CMsgConnectedPlayers_"></a> Equals\(CMsgConnectedPlayers\)

```csharp
public bool Equals(CMsgConnectedPlayers other)
```

#### Parameters

`other` [CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_MergeFrom_Divine_Protobufs_Dota2_CMsgConnectedPlayers_"></a> MergeFrom\(CMsgConnectedPlayers\)

```csharp
public void MergeFrom(CMsgConnectedPlayers other)
```

#### Parameters

`other` [CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

