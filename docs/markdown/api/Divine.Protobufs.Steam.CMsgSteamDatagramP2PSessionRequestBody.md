# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody"></a> Class CMsgSteamDatagramP2PSessionRequestBody

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramP2PSessionRequestBody : IMessage<CMsgSteamDatagramP2PSessionRequestBody>, IEquatable<CMsgSteamDatagramP2PSessionRequestBody>, IDeepCloneable<CMsgSteamDatagramP2PSessionRequestBody>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramP2PSessionRequestBody](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.md)

#### Implements

IMessage<CMsgSteamDatagramP2PSessionRequestBody\>, 
[IEquatable<CMsgSteamDatagramP2PSessionRequestBody\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramP2PSessionRequestBody\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramP2PSessionRequestBody\>\(CMsgSteamDatagramP2PSessionRequestBody, params CMsgSteamDatagramP2PSessionRequestBody\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody__ctor"></a> CMsgSteamDatagramP2PSessionRequestBody\(\)

```csharp
public CMsgSteamDatagramP2PSessionRequestBody()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_"></a> CMsgSteamDatagramP2PSessionRequestBody\(CMsgSteamDatagramP2PSessionRequestBody\)

```csharp
public CMsgSteamDatagramP2PSessionRequestBody(CMsgSteamDatagramP2PSessionRequestBody other)
```

#### Parameters

`other` [CMsgSteamDatagramP2PSessionRequestBody](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_BuildFieldNumber"></a> BuildFieldNumber

```csharp
public const int BuildFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ChallengeFieldNumber"></a> ChallengeFieldNumber

```csharp
public const int ChallengeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ChallengeTimeFieldNumber"></a> ChallengeTimeFieldNumber

```csharp
public const int ChallengeTimeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ClientConnectionIdFieldNumber"></a> ClientConnectionIdFieldNumber

```csharp
public const int ClientConnectionIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_EncryptedDataFieldNumber"></a> EncryptedDataFieldNumber

```csharp
public const int EncryptedDataFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_EncryptionMyEphemeralPublicKeyFieldNumber"></a> EncryptionMyEphemeralPublicKeyFieldNumber

```csharp
public const int EncryptionMyEphemeralPublicKeyFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_EncryptionYourPublicKeyLeadByteFieldNumber"></a> EncryptionYourPublicKeyLeadByteFieldNumber

```csharp
public const int EncryptionYourPublicKeyLeadByteFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_LegacyPeerSteamIdFieldNumber"></a> LegacyPeerSteamIdFieldNumber

```csharp
public const int LegacyPeerSteamIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_NetworkConfigVersionFieldNumber"></a> NetworkConfigVersionFieldNumber

```csharp
public const int NetworkConfigVersionFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_PeerConnectionIdFieldNumber"></a> PeerConnectionIdFieldNumber

```csharp
public const int PeerConnectionIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_PeerIdentityStringFieldNumber"></a> PeerIdentityStringFieldNumber

```csharp
public const int PeerIdentityStringFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_PlatformFieldNumber"></a> PlatformFieldNumber

```csharp
public const int PlatformFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ProtocolVersionFieldNumber"></a> ProtocolVersionFieldNumber

```csharp
public const int ProtocolVersionFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Build"></a> Build

```csharp
public string Build { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Challenge"></a> Challenge

```csharp
public ulong Challenge { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ChallengeTime"></a> ChallengeTime

```csharp
public uint ChallengeTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ClientConnectionId"></a> ClientConnectionId

```csharp
public uint ClientConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_EncryptedData"></a> EncryptedData

```csharp
public ByteString EncryptedData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_EncryptionMyEphemeralPublicKey"></a> EncryptionMyEphemeralPublicKey

```csharp
public ByteString EncryptionMyEphemeralPublicKey { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_EncryptionYourPublicKeyLeadByte"></a> EncryptionYourPublicKeyLeadByte

```csharp
public uint EncryptionYourPublicKeyLeadByte { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_HasBuild"></a> HasBuild

```csharp
public bool HasBuild { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_HasChallenge"></a> HasChallenge

```csharp
public bool HasChallenge { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_HasChallengeTime"></a> HasChallengeTime

```csharp
public bool HasChallengeTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_HasClientConnectionId"></a> HasClientConnectionId

```csharp
public bool HasClientConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_HasEncryptedData"></a> HasEncryptedData

```csharp
public bool HasEncryptedData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_HasEncryptionMyEphemeralPublicKey"></a> HasEncryptionMyEphemeralPublicKey

```csharp
public bool HasEncryptionMyEphemeralPublicKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_HasEncryptionYourPublicKeyLeadByte"></a> HasEncryptionYourPublicKeyLeadByte

```csharp
public bool HasEncryptionYourPublicKeyLeadByte { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_HasLegacyPeerSteamId"></a> HasLegacyPeerSteamId

```csharp
public bool HasLegacyPeerSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_HasNetworkConfigVersion"></a> HasNetworkConfigVersion

```csharp
public bool HasNetworkConfigVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_HasPeerConnectionId"></a> HasPeerConnectionId

```csharp
public bool HasPeerConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_HasPeerIdentityString"></a> HasPeerIdentityString

```csharp
public bool HasPeerIdentityString { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_HasPlatform"></a> HasPlatform

```csharp
public bool HasPlatform { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_HasProtocolVersion"></a> HasProtocolVersion

```csharp
public bool HasProtocolVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_LegacyPeerSteamId"></a> LegacyPeerSteamId

```csharp
public ulong LegacyPeerSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_NetworkConfigVersion"></a> NetworkConfigVersion

```csharp
public ulong NetworkConfigVersion { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramP2PSessionRequestBody> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramP2PSessionRequestBody](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_PeerConnectionId"></a> PeerConnectionId

```csharp
public uint PeerConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_PeerIdentityString"></a> PeerIdentityString

```csharp
public string PeerIdentityString { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Platform"></a> Platform

```csharp
public string Platform { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ProtocolVersion"></a> ProtocolVersion

```csharp
public uint ProtocolVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ClearBuild"></a> ClearBuild\(\)

```csharp
public void ClearBuild()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ClearChallenge"></a> ClearChallenge\(\)

```csharp
public void ClearChallenge()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ClearChallengeTime"></a> ClearChallengeTime\(\)

```csharp
public void ClearChallengeTime()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ClearClientConnectionId"></a> ClearClientConnectionId\(\)

```csharp
public void ClearClientConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ClearEncryptedData"></a> ClearEncryptedData\(\)

```csharp
public void ClearEncryptedData()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ClearEncryptionMyEphemeralPublicKey"></a> ClearEncryptionMyEphemeralPublicKey\(\)

```csharp
public void ClearEncryptionMyEphemeralPublicKey()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ClearEncryptionYourPublicKeyLeadByte"></a> ClearEncryptionYourPublicKeyLeadByte\(\)

```csharp
public void ClearEncryptionYourPublicKeyLeadByte()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ClearLegacyPeerSteamId"></a> ClearLegacyPeerSteamId\(\)

```csharp
public void ClearLegacyPeerSteamId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ClearNetworkConfigVersion"></a> ClearNetworkConfigVersion\(\)

```csharp
public void ClearNetworkConfigVersion()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ClearPeerConnectionId"></a> ClearPeerConnectionId\(\)

```csharp
public void ClearPeerConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ClearPeerIdentityString"></a> ClearPeerIdentityString\(\)

```csharp
public void ClearPeerIdentityString()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ClearPlatform"></a> ClearPlatform\(\)

```csharp
public void ClearPlatform()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ClearProtocolVersion"></a> ClearProtocolVersion\(\)

```csharp
public void ClearProtocolVersion()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramP2PSessionRequestBody Clone()
```

#### Returns

 [CMsgSteamDatagramP2PSessionRequestBody](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_"></a> Equals\(CMsgSteamDatagramP2PSessionRequestBody\)

```csharp
public bool Equals(CMsgSteamDatagramP2PSessionRequestBody other)
```

#### Parameters

`other` [CMsgSteamDatagramP2PSessionRequestBody](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_"></a> MergeFrom\(CMsgSteamDatagramP2PSessionRequestBody\)

```csharp
public void MergeFrom(CMsgSteamDatagramP2PSessionRequestBody other)
```

#### Parameters

`other` [CMsgSteamDatagramP2PSessionRequestBody](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

