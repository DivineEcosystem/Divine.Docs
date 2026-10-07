# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster"></a> Class CMsgSteamDatagramP2PRoutes.Types.RelayCluster

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramP2PRoutes.Types.RelayCluster : IMessage<CMsgSteamDatagramP2PRoutes.Types.RelayCluster>, IEquatable<CMsgSteamDatagramP2PRoutes.Types.RelayCluster>, IDeepCloneable<CMsgSteamDatagramP2PRoutes.Types.RelayCluster>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramP2PRoutes.Types.RelayCluster](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutes.Types.RelayCluster.md)

#### Implements

IMessage<CMsgSteamDatagramP2PRoutes.Types.RelayCluster\>, 
[IEquatable<CMsgSteamDatagramP2PRoutes.Types.RelayCluster\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramP2PRoutes.Types.RelayCluster\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramP2PRoutes.Types.RelayCluster\>\(CMsgSteamDatagramP2PRoutes.Types.RelayCluster, params CMsgSteamDatagramP2PRoutes.Types.RelayCluster\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster__ctor"></a> RelayCluster\(\)

```csharp
public RelayCluster()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_"></a> RelayCluster\(RelayCluster\)

```csharp
public RelayCluster(CMsgSteamDatagramP2PRoutes.Types.RelayCluster other)
```

#### Parameters

`other` [CMsgSteamDatagramP2PRoutes](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutes.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutes.Types.md).[RelayCluster](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutes.Types.RelayCluster.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_PingMsFieldNumber"></a> PingMsFieldNumber

```csharp
public const int PingMsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_PopIdFieldNumber"></a> PopIdFieldNumber

```csharp
public const int PopIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_ScorePenaltyFieldNumber"></a> ScorePenaltyFieldNumber

```csharp
public const int ScorePenaltyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_SessionRelayRoutingTokenFieldNumber"></a> SessionRelayRoutingTokenFieldNumber

```csharp
public const int SessionRelayRoutingTokenFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_HasPingMs"></a> HasPingMs

```csharp
public bool HasPingMs { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_HasPopId"></a> HasPopId

```csharp
public bool HasPopId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_HasScorePenalty"></a> HasScorePenalty

```csharp
public bool HasScorePenalty { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_HasSessionRelayRoutingToken"></a> HasSessionRelayRoutingToken

```csharp
public bool HasSessionRelayRoutingToken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramP2PRoutes.Types.RelayCluster> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramP2PRoutes](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutes.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutes.Types.md).[RelayCluster](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutes.Types.RelayCluster.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_PingMs"></a> PingMs

```csharp
public uint PingMs { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_PopId"></a> PopId

```csharp
public uint PopId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_ScorePenalty"></a> ScorePenalty

```csharp
public uint ScorePenalty { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_SessionRelayRoutingToken"></a> SessionRelayRoutingToken

```csharp
public ByteString SessionRelayRoutingToken { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_ClearPingMs"></a> ClearPingMs\(\)

```csharp
public void ClearPingMs()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_ClearPopId"></a> ClearPopId\(\)

```csharp
public void ClearPopId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_ClearScorePenalty"></a> ClearScorePenalty\(\)

```csharp
public void ClearScorePenalty()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_ClearSessionRelayRoutingToken"></a> ClearSessionRelayRoutingToken\(\)

```csharp
public void ClearSessionRelayRoutingToken()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramP2PRoutes.Types.RelayCluster Clone()
```

#### Returns

 [CMsgSteamDatagramP2PRoutes](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutes.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutes.Types.md).[RelayCluster](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutes.Types.RelayCluster.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_"></a> Equals\(RelayCluster\)

```csharp
public bool Equals(CMsgSteamDatagramP2PRoutes.Types.RelayCluster other)
```

#### Parameters

`other` [CMsgSteamDatagramP2PRoutes](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutes.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutes.Types.md).[RelayCluster](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutes.Types.RelayCluster.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_"></a> MergeFrom\(RelayCluster\)

```csharp
public void MergeFrom(CMsgSteamDatagramP2PRoutes.Types.RelayCluster other)
```

#### Parameters

`other` [CMsgSteamDatagramP2PRoutes](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutes.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutes.Types.md).[RelayCluster](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutes.Types.RelayCluster.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutes_Types_RelayCluster_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

