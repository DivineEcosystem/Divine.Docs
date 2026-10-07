# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient"></a> Class CMsgSteamDatagramP2PBadRouteRouterToClient

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramP2PBadRouteRouterToClient : IMessage<CMsgSteamDatagramP2PBadRouteRouterToClient>, IEquatable<CMsgSteamDatagramP2PBadRouteRouterToClient>, IDeepCloneable<CMsgSteamDatagramP2PBadRouteRouterToClient>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramP2PBadRouteRouterToClient](Divine.Protobufs.Steam.CMsgSteamDatagramP2PBadRouteRouterToClient.md)

#### Implements

IMessage<CMsgSteamDatagramP2PBadRouteRouterToClient\>, 
[IEquatable<CMsgSteamDatagramP2PBadRouteRouterToClient\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramP2PBadRouteRouterToClient\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramP2PBadRouteRouterToClient\>\(CMsgSteamDatagramP2PBadRouteRouterToClient, params CMsgSteamDatagramP2PBadRouteRouterToClient\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient__ctor"></a> CMsgSteamDatagramP2PBadRouteRouterToClient\(\)

```csharp
public CMsgSteamDatagramP2PBadRouteRouterToClient()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_"></a> CMsgSteamDatagramP2PBadRouteRouterToClient\(CMsgSteamDatagramP2PBadRouteRouterToClient\)

```csharp
public CMsgSteamDatagramP2PBadRouteRouterToClient(CMsgSteamDatagramP2PBadRouteRouterToClient other)
```

#### Parameters

`other` [CMsgSteamDatagramP2PBadRouteRouterToClient](Divine.Protobufs.Steam.CMsgSteamDatagramP2PBadRouteRouterToClient.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_AckForwardTargetRevisionFieldNumber"></a> AckForwardTargetRevisionFieldNumber

```csharp
public const int AckForwardTargetRevisionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_ConnectionIdFieldNumber"></a> ConnectionIdFieldNumber

```csharp
public const int ConnectionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_FailedRelayRoutingTokenFieldNumber"></a> FailedRelayRoutingTokenFieldNumber

```csharp
public const int FailedRelayRoutingTokenFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_KludgePadFieldNumber"></a> KludgePadFieldNumber

```csharp
public const int KludgePadFieldNumber = 99
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_AckForwardTargetRevision"></a> AckForwardTargetRevision

```csharp
public uint AckForwardTargetRevision { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_ConnectionId"></a> ConnectionId

```csharp
public uint ConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_FailedRelayRoutingToken"></a> FailedRelayRoutingToken

```csharp
public ByteString FailedRelayRoutingToken { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_HasAckForwardTargetRevision"></a> HasAckForwardTargetRevision

```csharp
public bool HasAckForwardTargetRevision { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_HasConnectionId"></a> HasConnectionId

```csharp
public bool HasConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_HasFailedRelayRoutingToken"></a> HasFailedRelayRoutingToken

```csharp
public bool HasFailedRelayRoutingToken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_HasKludgePad"></a> HasKludgePad

```csharp
public bool HasKludgePad { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_KludgePad"></a> KludgePad

```csharp
public ulong KludgePad { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramP2PBadRouteRouterToClient> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramP2PBadRouteRouterToClient](Divine.Protobufs.Steam.CMsgSteamDatagramP2PBadRouteRouterToClient.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_ClearAckForwardTargetRevision"></a> ClearAckForwardTargetRevision\(\)

```csharp
public void ClearAckForwardTargetRevision()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_ClearConnectionId"></a> ClearConnectionId\(\)

```csharp
public void ClearConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_ClearFailedRelayRoutingToken"></a> ClearFailedRelayRoutingToken\(\)

```csharp
public void ClearFailedRelayRoutingToken()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_ClearKludgePad"></a> ClearKludgePad\(\)

```csharp
public void ClearKludgePad()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramP2PBadRouteRouterToClient Clone()
```

#### Returns

 [CMsgSteamDatagramP2PBadRouteRouterToClient](Divine.Protobufs.Steam.CMsgSteamDatagramP2PBadRouteRouterToClient.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_"></a> Equals\(CMsgSteamDatagramP2PBadRouteRouterToClient\)

```csharp
public bool Equals(CMsgSteamDatagramP2PBadRouteRouterToClient other)
```

#### Parameters

`other` [CMsgSteamDatagramP2PBadRouteRouterToClient](Divine.Protobufs.Steam.CMsgSteamDatagramP2PBadRouteRouterToClient.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_"></a> MergeFrom\(CMsgSteamDatagramP2PBadRouteRouterToClient\)

```csharp
public void MergeFrom(CMsgSteamDatagramP2PBadRouteRouterToClient other)
```

#### Parameters

`other` [CMsgSteamDatagramP2PBadRouteRouterToClient](Divine.Protobufs.Steam.CMsgSteamDatagramP2PBadRouteRouterToClient.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PBadRouteRouterToClient_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

