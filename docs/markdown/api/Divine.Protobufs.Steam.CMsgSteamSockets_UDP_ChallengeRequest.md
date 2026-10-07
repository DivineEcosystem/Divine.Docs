# <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest"></a> Class CMsgSteamSockets\_UDP\_ChallengeRequest

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamSockets_UDP_ChallengeRequest : IMessage<CMsgSteamSockets_UDP_ChallengeRequest>, IEquatable<CMsgSteamSockets_UDP_ChallengeRequest>, IDeepCloneable<CMsgSteamSockets_UDP_ChallengeRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamSockets\_UDP\_ChallengeRequest](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ChallengeRequest.md)

#### Implements

IMessage<CMsgSteamSockets\_UDP\_ChallengeRequest\>, 
[IEquatable<CMsgSteamSockets\_UDP\_ChallengeRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamSockets\_UDP\_ChallengeRequest\>, 
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
[EnumerableExtensions.In<CMsgSteamSockets\_UDP\_ChallengeRequest\>\(CMsgSteamSockets\_UDP\_ChallengeRequest, params CMsgSteamSockets\_UDP\_ChallengeRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest__ctor"></a> CMsgSteamSockets\_UDP\_ChallengeRequest\(\)

```csharp
public CMsgSteamSockets_UDP_ChallengeRequest()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest__ctor_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_"></a> CMsgSteamSockets\_UDP\_ChallengeRequest\(CMsgSteamSockets\_UDP\_ChallengeRequest\)

```csharp
public CMsgSteamSockets_UDP_ChallengeRequest(CMsgSteamSockets_UDP_ChallengeRequest other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_ChallengeRequest](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ChallengeRequest.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_ConnectionIdFieldNumber"></a> ConnectionIdFieldNumber

```csharp
public const int ConnectionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_MyTimestampFieldNumber"></a> MyTimestampFieldNumber

```csharp
public const int MyTimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_ProtocolVersionFieldNumber"></a> ProtocolVersionFieldNumber

```csharp
public const int ProtocolVersionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_ConnectionId"></a> ConnectionId

```csharp
public uint ConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_HasConnectionId"></a> HasConnectionId

```csharp
public bool HasConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_HasMyTimestamp"></a> HasMyTimestamp

```csharp
public bool HasMyTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_HasProtocolVersion"></a> HasProtocolVersion

```csharp
public bool HasProtocolVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_MyTimestamp"></a> MyTimestamp

```csharp
public ulong MyTimestamp { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamSockets_UDP_ChallengeRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamSockets\_UDP\_ChallengeRequest](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ChallengeRequest.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_ProtocolVersion"></a> ProtocolVersion

```csharp
public uint ProtocolVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_ClearConnectionId"></a> ClearConnectionId\(\)

```csharp
public void ClearConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_ClearMyTimestamp"></a> ClearMyTimestamp\(\)

```csharp
public void ClearMyTimestamp()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_ClearProtocolVersion"></a> ClearProtocolVersion\(\)

```csharp
public void ClearProtocolVersion()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_Clone"></a> Clone\(\)

```csharp
public CMsgSteamSockets_UDP_ChallengeRequest Clone()
```

#### Returns

 [CMsgSteamSockets\_UDP\_ChallengeRequest](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ChallengeRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_Equals_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_"></a> Equals\(CMsgSteamSockets\_UDP\_ChallengeRequest\)

```csharp
public bool Equals(CMsgSteamSockets_UDP_ChallengeRequest other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_ChallengeRequest](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ChallengeRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_MergeFrom_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_"></a> MergeFrom\(CMsgSteamSockets\_UDP\_ChallengeRequest\)

```csharp
public void MergeFrom(CMsgSteamSockets_UDP_ChallengeRequest other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_ChallengeRequest](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ChallengeRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

