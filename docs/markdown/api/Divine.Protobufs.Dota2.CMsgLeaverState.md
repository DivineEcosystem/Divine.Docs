# <a id="Divine_Protobufs_Dota2_CMsgLeaverState"></a> Class CMsgLeaverState

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLeaverState : IMessage<CMsgLeaverState>, IEquatable<CMsgLeaverState>, IDeepCloneable<CMsgLeaverState>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLeaverState](Divine.Protobufs.Dota2.CMsgLeaverState.md)

#### Implements

IMessage<CMsgLeaverState\>, 
[IEquatable<CMsgLeaverState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLeaverState\>, 
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
[EnumerableExtensions.In<CMsgLeaverState\>\(CMsgLeaverState, params CMsgLeaverState\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState__ctor"></a> CMsgLeaverState\(\)

```csharp
public CMsgLeaverState()
```

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState__ctor_Divine_Protobufs_Dota2_CMsgLeaverState_"></a> CMsgLeaverState\(CMsgLeaverState\)

```csharp
public CMsgLeaverState(CMsgLeaverState other)
```

#### Parameters

`other` [CMsgLeaverState](Divine.Protobufs.Dota2.CMsgLeaverState.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_DiscardMatchResultsFieldNumber"></a> DiscardMatchResultsFieldNumber

```csharp
public const int DiscardMatchResultsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_FirstBloodHappenedFieldNumber"></a> FirstBloodHappenedFieldNumber

```csharp
public const int FirstBloodHappenedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_GameStateFieldNumber"></a> GameStateFieldNumber

```csharp
public const int GameStateFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_LeaverDetectedFieldNumber"></a> LeaverDetectedFieldNumber

```csharp
public const int LeaverDetectedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_LobbyStateFieldNumber"></a> LobbyStateFieldNumber

```csharp
public const int LobbyStateFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_MassDisconnectFieldNumber"></a> MassDisconnectFieldNumber

```csharp
public const int MassDisconnectFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_DiscardMatchResults"></a> DiscardMatchResults

```csharp
public bool DiscardMatchResults { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_FirstBloodHappened"></a> FirstBloodHappened

```csharp
public bool FirstBloodHappened { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_GameState"></a> GameState

```csharp
public DOTA_GameState GameState { get; set; }
```

#### Property Value

 [DOTA\_GameState](Divine.Protobufs.Dota2.DOTA\_GameState.md)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_HasDiscardMatchResults"></a> HasDiscardMatchResults

```csharp
public bool HasDiscardMatchResults { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_HasFirstBloodHappened"></a> HasFirstBloodHappened

```csharp
public bool HasFirstBloodHappened { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_HasGameState"></a> HasGameState

```csharp
public bool HasGameState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_HasLeaverDetected"></a> HasLeaverDetected

```csharp
public bool HasLeaverDetected { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_HasLobbyState"></a> HasLobbyState

```csharp
public bool HasLobbyState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_HasMassDisconnect"></a> HasMassDisconnect

```csharp
public bool HasMassDisconnect { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_LeaverDetected"></a> LeaverDetected

```csharp
public bool LeaverDetected { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_LobbyState"></a> LobbyState

```csharp
public uint LobbyState { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_MassDisconnect"></a> MassDisconnect

```csharp
public bool MassDisconnect { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLeaverState> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLeaverState](Divine.Protobufs.Dota2.CMsgLeaverState.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_ClearDiscardMatchResults"></a> ClearDiscardMatchResults\(\)

```csharp
public void ClearDiscardMatchResults()
```

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_ClearFirstBloodHappened"></a> ClearFirstBloodHappened\(\)

```csharp
public void ClearFirstBloodHappened()
```

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_ClearGameState"></a> ClearGameState\(\)

```csharp
public void ClearGameState()
```

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_ClearLeaverDetected"></a> ClearLeaverDetected\(\)

```csharp
public void ClearLeaverDetected()
```

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_ClearLobbyState"></a> ClearLobbyState\(\)

```csharp
public void ClearLobbyState()
```

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_ClearMassDisconnect"></a> ClearMassDisconnect\(\)

```csharp
public void ClearMassDisconnect()
```

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_Clone"></a> Clone\(\)

```csharp
public CMsgLeaverState Clone()
```

#### Returns

 [CMsgLeaverState](Divine.Protobufs.Dota2.CMsgLeaverState.md)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_Equals_Divine_Protobufs_Dota2_CMsgLeaverState_"></a> Equals\(CMsgLeaverState\)

```csharp
public bool Equals(CMsgLeaverState other)
```

#### Parameters

`other` [CMsgLeaverState](Divine.Protobufs.Dota2.CMsgLeaverState.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_MergeFrom_Divine_Protobufs_Dota2_CMsgLeaverState_"></a> MergeFrom\(CMsgLeaverState\)

```csharp
public void MergeFrom(CMsgLeaverState other)
```

#### Parameters

`other` [CMsgLeaverState](Divine.Protobufs.Dota2.CMsgLeaverState.md)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverState_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

