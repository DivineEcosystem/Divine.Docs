# <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply"></a> Class CMsgSteamSockets\_UDP\_ChallengeReply

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamSockets_UDP_ChallengeReply : IMessage<CMsgSteamSockets_UDP_ChallengeReply>, IEquatable<CMsgSteamSockets_UDP_ChallengeReply>, IDeepCloneable<CMsgSteamSockets_UDP_ChallengeReply>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamSockets\_UDP\_ChallengeReply](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ChallengeReply.md)

#### Implements

IMessage<CMsgSteamSockets\_UDP\_ChallengeReply\>, 
[IEquatable<CMsgSteamSockets\_UDP\_ChallengeReply\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamSockets\_UDP\_ChallengeReply\>, 
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
[EnumerableExtensions.In<CMsgSteamSockets\_UDP\_ChallengeReply\>\(CMsgSteamSockets\_UDP\_ChallengeReply, params CMsgSteamSockets\_UDP\_ChallengeReply\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply__ctor"></a> CMsgSteamSockets\_UDP\_ChallengeReply\(\)

```csharp
public CMsgSteamSockets_UDP_ChallengeReply()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply__ctor_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_"></a> CMsgSteamSockets\_UDP\_ChallengeReply\(CMsgSteamSockets\_UDP\_ChallengeReply\)

```csharp
public CMsgSteamSockets_UDP_ChallengeReply(CMsgSteamSockets_UDP_ChallengeReply other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_ChallengeReply](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ChallengeReply.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_ChallengeFieldNumber"></a> ChallengeFieldNumber

```csharp
public const int ChallengeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_ConnectionIdFieldNumber"></a> ConnectionIdFieldNumber

```csharp
public const int ConnectionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_ProtocolVersionFieldNumber"></a> ProtocolVersionFieldNumber

```csharp
public const int ProtocolVersionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_YourTimestampFieldNumber"></a> YourTimestampFieldNumber

```csharp
public const int YourTimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_Challenge"></a> Challenge

```csharp
public ulong Challenge { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_ConnectionId"></a> ConnectionId

```csharp
public uint ConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_HasChallenge"></a> HasChallenge

```csharp
public bool HasChallenge { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_HasConnectionId"></a> HasConnectionId

```csharp
public bool HasConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_HasProtocolVersion"></a> HasProtocolVersion

```csharp
public bool HasProtocolVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_HasYourTimestamp"></a> HasYourTimestamp

```csharp
public bool HasYourTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamSockets_UDP_ChallengeReply> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamSockets\_UDP\_ChallengeReply](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ChallengeReply.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_ProtocolVersion"></a> ProtocolVersion

```csharp
public uint ProtocolVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_YourTimestamp"></a> YourTimestamp

```csharp
public ulong YourTimestamp { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_ClearChallenge"></a> ClearChallenge\(\)

```csharp
public void ClearChallenge()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_ClearConnectionId"></a> ClearConnectionId\(\)

```csharp
public void ClearConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_ClearProtocolVersion"></a> ClearProtocolVersion\(\)

```csharp
public void ClearProtocolVersion()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_ClearYourTimestamp"></a> ClearYourTimestamp\(\)

```csharp
public void ClearYourTimestamp()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_Clone"></a> Clone\(\)

```csharp
public CMsgSteamSockets_UDP_ChallengeReply Clone()
```

#### Returns

 [CMsgSteamSockets\_UDP\_ChallengeReply](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ChallengeReply.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_Equals_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_"></a> Equals\(CMsgSteamSockets\_UDP\_ChallengeReply\)

```csharp
public bool Equals(CMsgSteamSockets_UDP_ChallengeReply other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_ChallengeReply](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ChallengeReply.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_MergeFrom_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_"></a> MergeFrom\(CMsgSteamSockets\_UDP\_ChallengeReply\)

```csharp
public void MergeFrom(CMsgSteamSockets_UDP_ChallengeReply other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_ChallengeReply](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ChallengeReply.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ChallengeReply_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

