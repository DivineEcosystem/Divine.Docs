# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest"></a> Class CMsgSteamDatagramGameserverSessionRequest

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramGameserverSessionRequest : IMessage<CMsgSteamDatagramGameserverSessionRequest>, IEquatable<CMsgSteamDatagramGameserverSessionRequest>, IDeepCloneable<CMsgSteamDatagramGameserverSessionRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramGameserverSessionRequest](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverSessionRequest.md)

#### Implements

IMessage<CMsgSteamDatagramGameserverSessionRequest\>, 
[IEquatable<CMsgSteamDatagramGameserverSessionRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramGameserverSessionRequest\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramGameserverSessionRequest\>\(CMsgSteamDatagramGameserverSessionRequest, params CMsgSteamDatagramGameserverSessionRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest__ctor"></a> CMsgSteamDatagramGameserverSessionRequest\(\)

```csharp
public CMsgSteamDatagramGameserverSessionRequest()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_"></a> CMsgSteamDatagramGameserverSessionRequest\(CMsgSteamDatagramGameserverSessionRequest\)

```csharp
public CMsgSteamDatagramGameserverSessionRequest(CMsgSteamDatagramGameserverSessionRequest other)
```

#### Parameters

`other` [CMsgSteamDatagramGameserverSessionRequest](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverSessionRequest.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_BuildFieldNumber"></a> BuildFieldNumber

```csharp
public const int BuildFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ChallengeFieldNumber"></a> ChallengeFieldNumber

```csharp
public const int ChallengeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ChallengeTimeFieldNumber"></a> ChallengeTimeFieldNumber

```csharp
public const int ChallengeTimeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ClientConnectionIdFieldNumber"></a> ClientConnectionIdFieldNumber

```csharp
public const int ClientConnectionIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_DevClientCertFieldNumber"></a> DevClientCertFieldNumber

```csharp
public const int DevClientCertFieldNumber = 101
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_DevGameserverIdentityFieldNumber"></a> DevGameserverIdentityFieldNumber

```csharp
public const int DevGameserverIdentityFieldNumber = 100
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_NetworkConfigVersionFieldNumber"></a> NetworkConfigVersionFieldNumber

```csharp
public const int NetworkConfigVersionFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_PlatformFieldNumber"></a> PlatformFieldNumber

```csharp
public const int PlatformFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ProtocolVersionFieldNumber"></a> ProtocolVersionFieldNumber

```csharp
public const int ProtocolVersionFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ServerConnectionIdFieldNumber"></a> ServerConnectionIdFieldNumber

```csharp
public const int ServerConnectionIdFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_TicketFieldNumber"></a> TicketFieldNumber

```csharp
public const int TicketFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_Build"></a> Build

```csharp
public string Build { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_Challenge"></a> Challenge

```csharp
public ulong Challenge { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ChallengeTime"></a> ChallengeTime

```csharp
public uint ChallengeTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ClientConnectionId"></a> ClientConnectionId

```csharp
public uint ClientConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_DevClientCert"></a> DevClientCert

```csharp
public CMsgSteamDatagramCertificateSigned DevClientCert { get; set; }
```

#### Property Value

 [CMsgSteamDatagramCertificateSigned](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateSigned.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_DevGameserverIdentity"></a> DevGameserverIdentity

```csharp
public string DevGameserverIdentity { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_HasBuild"></a> HasBuild

```csharp
public bool HasBuild { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_HasChallenge"></a> HasChallenge

```csharp
public bool HasChallenge { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_HasChallengeTime"></a> HasChallengeTime

```csharp
public bool HasChallengeTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_HasClientConnectionId"></a> HasClientConnectionId

```csharp
public bool HasClientConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_HasDevGameserverIdentity"></a> HasDevGameserverIdentity

```csharp
public bool HasDevGameserverIdentity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_HasNetworkConfigVersion"></a> HasNetworkConfigVersion

```csharp
public bool HasNetworkConfigVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_HasPlatform"></a> HasPlatform

```csharp
public bool HasPlatform { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_HasProtocolVersion"></a> HasProtocolVersion

```csharp
public bool HasProtocolVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_HasServerConnectionId"></a> HasServerConnectionId

```csharp
public bool HasServerConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_HasTicket"></a> HasTicket

```csharp
public bool HasTicket { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_NetworkConfigVersion"></a> NetworkConfigVersion

```csharp
public ulong NetworkConfigVersion { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramGameserverSessionRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramGameserverSessionRequest](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverSessionRequest.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_Platform"></a> Platform

```csharp
public string Platform { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ProtocolVersion"></a> ProtocolVersion

```csharp
public uint ProtocolVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ServerConnectionId"></a> ServerConnectionId

```csharp
public uint ServerConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_Ticket"></a> Ticket

```csharp
public ByteString Ticket { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ClearBuild"></a> ClearBuild\(\)

```csharp
public void ClearBuild()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ClearChallenge"></a> ClearChallenge\(\)

```csharp
public void ClearChallenge()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ClearChallengeTime"></a> ClearChallengeTime\(\)

```csharp
public void ClearChallengeTime()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ClearClientConnectionId"></a> ClearClientConnectionId\(\)

```csharp
public void ClearClientConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ClearDevGameserverIdentity"></a> ClearDevGameserverIdentity\(\)

```csharp
public void ClearDevGameserverIdentity()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ClearNetworkConfigVersion"></a> ClearNetworkConfigVersion\(\)

```csharp
public void ClearNetworkConfigVersion()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ClearPlatform"></a> ClearPlatform\(\)

```csharp
public void ClearPlatform()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ClearProtocolVersion"></a> ClearProtocolVersion\(\)

```csharp
public void ClearProtocolVersion()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ClearServerConnectionId"></a> ClearServerConnectionId\(\)

```csharp
public void ClearServerConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ClearTicket"></a> ClearTicket\(\)

```csharp
public void ClearTicket()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramGameserverSessionRequest Clone()
```

#### Returns

 [CMsgSteamDatagramGameserverSessionRequest](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverSessionRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_"></a> Equals\(CMsgSteamDatagramGameserverSessionRequest\)

```csharp
public bool Equals(CMsgSteamDatagramGameserverSessionRequest other)
```

#### Parameters

`other` [CMsgSteamDatagramGameserverSessionRequest](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverSessionRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_"></a> MergeFrom\(CMsgSteamDatagramGameserverSessionRequest\)

```csharp
public void MergeFrom(CMsgSteamDatagramGameserverSessionRequest other)
```

#### Parameters

`other` [CMsgSteamDatagramGameserverSessionRequest](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverSessionRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverSessionRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

