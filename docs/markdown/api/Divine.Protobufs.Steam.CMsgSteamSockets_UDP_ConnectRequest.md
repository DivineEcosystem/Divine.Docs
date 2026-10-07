# <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest"></a> Class CMsgSteamSockets\_UDP\_ConnectRequest

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamSockets_UDP_ConnectRequest : IMessage<CMsgSteamSockets_UDP_ConnectRequest>, IEquatable<CMsgSteamSockets_UDP_ConnectRequest>, IDeepCloneable<CMsgSteamSockets_UDP_ConnectRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamSockets\_UDP\_ConnectRequest](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ConnectRequest.md)

#### Implements

IMessage<CMsgSteamSockets\_UDP\_ConnectRequest\>, 
[IEquatable<CMsgSteamSockets\_UDP\_ConnectRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamSockets\_UDP\_ConnectRequest\>, 
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
[EnumerableExtensions.In<CMsgSteamSockets\_UDP\_ConnectRequest\>\(CMsgSteamSockets\_UDP\_ConnectRequest, params CMsgSteamSockets\_UDP\_ConnectRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest__ctor"></a> CMsgSteamSockets\_UDP\_ConnectRequest\(\)

```csharp
public CMsgSteamSockets_UDP_ConnectRequest()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest__ctor_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_"></a> CMsgSteamSockets\_UDP\_ConnectRequest\(CMsgSteamSockets\_UDP\_ConnectRequest\)

```csharp
public CMsgSteamSockets_UDP_ConnectRequest(CMsgSteamSockets_UDP_ConnectRequest other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_ConnectRequest](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ConnectRequest.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_CertFieldNumber"></a> CertFieldNumber

```csharp
public const int CertFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_ChallengeFieldNumber"></a> ChallengeFieldNumber

```csharp
public const int ChallengeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_ClientConnectionIdFieldNumber"></a> ClientConnectionIdFieldNumber

```csharp
public const int ClientConnectionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_CryptFieldNumber"></a> CryptFieldNumber

```csharp
public const int CryptFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_IdentityStringFieldNumber"></a> IdentityStringFieldNumber

```csharp
public const int IdentityStringFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_LegacyClientSteamIdFieldNumber"></a> LegacyClientSteamIdFieldNumber

```csharp
public const int LegacyClientSteamIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_LegacyIdentityBinaryFieldNumber"></a> LegacyIdentityBinaryFieldNumber

```csharp
public const int LegacyIdentityBinaryFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_LegacyProtocolVersionFieldNumber"></a> LegacyProtocolVersionFieldNumber

```csharp
public const int LegacyProtocolVersionFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_MyTimestampFieldNumber"></a> MyTimestampFieldNumber

```csharp
public const int MyTimestampFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_PingEstMsFieldNumber"></a> PingEstMsFieldNumber

```csharp
public const int PingEstMsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_Cert"></a> Cert

```csharp
public CMsgSteamDatagramCertificateSigned Cert { get; set; }
```

#### Property Value

 [CMsgSteamDatagramCertificateSigned](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateSigned.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_Challenge"></a> Challenge

```csharp
public ulong Challenge { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_ClientConnectionId"></a> ClientConnectionId

```csharp
public uint ClientConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_Crypt"></a> Crypt

```csharp
public CMsgSteamDatagramSessionCryptInfoSigned Crypt { get; set; }
```

#### Property Value

 [CMsgSteamDatagramSessionCryptInfoSigned](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfoSigned.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_HasChallenge"></a> HasChallenge

```csharp
public bool HasChallenge { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_HasClientConnectionId"></a> HasClientConnectionId

```csharp
public bool HasClientConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_HasIdentityString"></a> HasIdentityString

```csharp
public bool HasIdentityString { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_HasLegacyClientSteamId"></a> HasLegacyClientSteamId

```csharp
public bool HasLegacyClientSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_HasLegacyProtocolVersion"></a> HasLegacyProtocolVersion

```csharp
public bool HasLegacyProtocolVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_HasMyTimestamp"></a> HasMyTimestamp

```csharp
public bool HasMyTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_HasPingEstMs"></a> HasPingEstMs

```csharp
public bool HasPingEstMs { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_IdentityString"></a> IdentityString

```csharp
public string IdentityString { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_LegacyClientSteamId"></a> LegacyClientSteamId

```csharp
public ulong LegacyClientSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_LegacyIdentityBinary"></a> LegacyIdentityBinary

```csharp
public CMsgSteamNetworkingIdentityLegacyBinary LegacyIdentityBinary { get; set; }
```

#### Property Value

 [CMsgSteamNetworkingIdentityLegacyBinary](Divine.Protobufs.Steam.CMsgSteamNetworkingIdentityLegacyBinary.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_LegacyProtocolVersion"></a> LegacyProtocolVersion

```csharp
public uint LegacyProtocolVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_MyTimestamp"></a> MyTimestamp

```csharp
public ulong MyTimestamp { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamSockets_UDP_ConnectRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamSockets\_UDP\_ConnectRequest](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ConnectRequest.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_PingEstMs"></a> PingEstMs

```csharp
public uint PingEstMs { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_ClearChallenge"></a> ClearChallenge\(\)

```csharp
public void ClearChallenge()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_ClearClientConnectionId"></a> ClearClientConnectionId\(\)

```csharp
public void ClearClientConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_ClearIdentityString"></a> ClearIdentityString\(\)

```csharp
public void ClearIdentityString()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_ClearLegacyClientSteamId"></a> ClearLegacyClientSteamId\(\)

```csharp
public void ClearLegacyClientSteamId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_ClearLegacyProtocolVersion"></a> ClearLegacyProtocolVersion\(\)

```csharp
public void ClearLegacyProtocolVersion()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_ClearMyTimestamp"></a> ClearMyTimestamp\(\)

```csharp
public void ClearMyTimestamp()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_ClearPingEstMs"></a> ClearPingEstMs\(\)

```csharp
public void ClearPingEstMs()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_Clone"></a> Clone\(\)

```csharp
public CMsgSteamSockets_UDP_ConnectRequest Clone()
```

#### Returns

 [CMsgSteamSockets\_UDP\_ConnectRequest](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ConnectRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_Equals_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_"></a> Equals\(CMsgSteamSockets\_UDP\_ConnectRequest\)

```csharp
public bool Equals(CMsgSteamSockets_UDP_ConnectRequest other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_ConnectRequest](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ConnectRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_MergeFrom_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_"></a> MergeFrom\(CMsgSteamSockets\_UDP\_ConnectRequest\)

```csharp
public void MergeFrom(CMsgSteamSockets_UDP_ConnectRequest other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_ConnectRequest](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ConnectRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

