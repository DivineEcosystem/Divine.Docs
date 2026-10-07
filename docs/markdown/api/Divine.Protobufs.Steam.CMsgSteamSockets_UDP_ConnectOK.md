# <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK"></a> Class CMsgSteamSockets\_UDP\_ConnectOK

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamSockets_UDP_ConnectOK : IMessage<CMsgSteamSockets_UDP_ConnectOK>, IEquatable<CMsgSteamSockets_UDP_ConnectOK>, IDeepCloneable<CMsgSteamSockets_UDP_ConnectOK>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamSockets\_UDP\_ConnectOK](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ConnectOK.md)

#### Implements

IMessage<CMsgSteamSockets\_UDP\_ConnectOK\>, 
[IEquatable<CMsgSteamSockets\_UDP\_ConnectOK\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamSockets\_UDP\_ConnectOK\>, 
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
[EnumerableExtensions.In<CMsgSteamSockets\_UDP\_ConnectOK\>\(CMsgSteamSockets\_UDP\_ConnectOK, params CMsgSteamSockets\_UDP\_ConnectOK\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK__ctor"></a> CMsgSteamSockets\_UDP\_ConnectOK\(\)

```csharp
public CMsgSteamSockets_UDP_ConnectOK()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK__ctor_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_"></a> CMsgSteamSockets\_UDP\_ConnectOK\(CMsgSteamSockets\_UDP\_ConnectOK\)

```csharp
public CMsgSteamSockets_UDP_ConnectOK(CMsgSteamSockets_UDP_ConnectOK other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_ConnectOK](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ConnectOK.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_CertFieldNumber"></a> CertFieldNumber

```csharp
public const int CertFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_ClientConnectionIdFieldNumber"></a> ClientConnectionIdFieldNumber

```csharp
public const int ClientConnectionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_CryptFieldNumber"></a> CryptFieldNumber

```csharp
public const int CryptFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_DelayTimeUsecFieldNumber"></a> DelayTimeUsecFieldNumber

```csharp
public const int DelayTimeUsecFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_IdentityStringFieldNumber"></a> IdentityStringFieldNumber

```csharp
public const int IdentityStringFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_LegacyIdentityBinaryFieldNumber"></a> LegacyIdentityBinaryFieldNumber

```csharp
public const int LegacyIdentityBinaryFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_LegacyServerSteamIdFieldNumber"></a> LegacyServerSteamIdFieldNumber

```csharp
public const int LegacyServerSteamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_ServerConnectionIdFieldNumber"></a> ServerConnectionIdFieldNumber

```csharp
public const int ServerConnectionIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_YourTimestampFieldNumber"></a> YourTimestampFieldNumber

```csharp
public const int YourTimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_Cert"></a> Cert

```csharp
public CMsgSteamDatagramCertificateSigned Cert { get; set; }
```

#### Property Value

 [CMsgSteamDatagramCertificateSigned](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateSigned.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_ClientConnectionId"></a> ClientConnectionId

```csharp
public uint ClientConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_Crypt"></a> Crypt

```csharp
public CMsgSteamDatagramSessionCryptInfoSigned Crypt { get; set; }
```

#### Property Value

 [CMsgSteamDatagramSessionCryptInfoSigned](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfoSigned.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_DelayTimeUsec"></a> DelayTimeUsec

```csharp
public uint DelayTimeUsec { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_HasClientConnectionId"></a> HasClientConnectionId

```csharp
public bool HasClientConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_HasDelayTimeUsec"></a> HasDelayTimeUsec

```csharp
public bool HasDelayTimeUsec { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_HasIdentityString"></a> HasIdentityString

```csharp
public bool HasIdentityString { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_HasLegacyServerSteamId"></a> HasLegacyServerSteamId

```csharp
public bool HasLegacyServerSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_HasServerConnectionId"></a> HasServerConnectionId

```csharp
public bool HasServerConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_HasYourTimestamp"></a> HasYourTimestamp

```csharp
public bool HasYourTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_IdentityString"></a> IdentityString

```csharp
public string IdentityString { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_LegacyIdentityBinary"></a> LegacyIdentityBinary

```csharp
public CMsgSteamNetworkingIdentityLegacyBinary LegacyIdentityBinary { get; set; }
```

#### Property Value

 [CMsgSteamNetworkingIdentityLegacyBinary](Divine.Protobufs.Steam.CMsgSteamNetworkingIdentityLegacyBinary.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_LegacyServerSteamId"></a> LegacyServerSteamId

```csharp
public ulong LegacyServerSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamSockets_UDP_ConnectOK> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamSockets\_UDP\_ConnectOK](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ConnectOK.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_ServerConnectionId"></a> ServerConnectionId

```csharp
public uint ServerConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_YourTimestamp"></a> YourTimestamp

```csharp
public ulong YourTimestamp { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_ClearClientConnectionId"></a> ClearClientConnectionId\(\)

```csharp
public void ClearClientConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_ClearDelayTimeUsec"></a> ClearDelayTimeUsec\(\)

```csharp
public void ClearDelayTimeUsec()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_ClearIdentityString"></a> ClearIdentityString\(\)

```csharp
public void ClearIdentityString()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_ClearLegacyServerSteamId"></a> ClearLegacyServerSteamId\(\)

```csharp
public void ClearLegacyServerSteamId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_ClearServerConnectionId"></a> ClearServerConnectionId\(\)

```csharp
public void ClearServerConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_ClearYourTimestamp"></a> ClearYourTimestamp\(\)

```csharp
public void ClearYourTimestamp()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_Clone"></a> Clone\(\)

```csharp
public CMsgSteamSockets_UDP_ConnectOK Clone()
```

#### Returns

 [CMsgSteamSockets\_UDP\_ConnectOK](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ConnectOK.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_Equals_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_"></a> Equals\(CMsgSteamSockets\_UDP\_ConnectOK\)

```csharp
public bool Equals(CMsgSteamSockets_UDP_ConnectOK other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_ConnectOK](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ConnectOK.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_MergeFrom_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_"></a> MergeFrom\(CMsgSteamSockets\_UDP\_ConnectOK\)

```csharp
public void MergeFrom(CMsgSteamSockets_UDP_ConnectOK other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_ConnectOK](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_ConnectOK.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_ConnectOK_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

