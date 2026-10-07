# <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest"></a> Class CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest : IMessage<CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest>, IEquatable<CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest>, IDeepCloneable<CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest.md)

#### Implements

IMessage<CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest\>, 
[IEquatable<CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest\>, 
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
[EnumerableExtensions.In<CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest\>\(CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest, params CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest__ctor"></a> ConnectRequest\(\)

```csharp
public ConnectRequest()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest__ctor_Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_"></a> ConnectRequest\(ConnectRequest\)

```csharp
public ConnectRequest(CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest other)
```

#### Parameters

`other` [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ConnectRequest](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_CertFieldNumber"></a> CertFieldNumber

```csharp
public const int CertFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_CryptFieldNumber"></a> CryptFieldNumber

```csharp
public const int CryptFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_FromFakeipFieldNumber"></a> FromFakeipFieldNumber

```csharp
public const int FromFakeipFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_FromVirtualPortFieldNumber"></a> FromVirtualPortFieldNumber

```csharp
public const int FromVirtualPortFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_ToVirtualPortFieldNumber"></a> ToVirtualPortFieldNumber

```csharp
public const int ToVirtualPortFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_Cert"></a> Cert

```csharp
public CMsgSteamDatagramCertificateSigned Cert { get; set; }
```

#### Property Value

 [CMsgSteamDatagramCertificateSigned](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateSigned.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_Crypt"></a> Crypt

```csharp
public CMsgSteamDatagramSessionCryptInfoSigned Crypt { get; set; }
```

#### Property Value

 [CMsgSteamDatagramSessionCryptInfoSigned](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfoSigned.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_FromFakeip"></a> FromFakeip

```csharp
public string FromFakeip { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_FromVirtualPort"></a> FromVirtualPort

```csharp
public uint FromVirtualPort { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_HasFromFakeip"></a> HasFromFakeip

```csharp
public bool HasFromFakeip { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_HasFromVirtualPort"></a> HasFromVirtualPort

```csharp
public bool HasFromVirtualPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_HasToVirtualPort"></a> HasToVirtualPort

```csharp
public bool HasToVirtualPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ConnectRequest](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_ToVirtualPort"></a> ToVirtualPort

```csharp
public uint ToVirtualPort { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_ClearFromFakeip"></a> ClearFromFakeip\(\)

```csharp
public void ClearFromFakeip()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_ClearFromVirtualPort"></a> ClearFromVirtualPort\(\)

```csharp
public void ClearFromVirtualPort()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_ClearToVirtualPort"></a> ClearToVirtualPort\(\)

```csharp
public void ClearToVirtualPort()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_Clone"></a> Clone\(\)

```csharp
public CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest Clone()
```

#### Returns

 [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ConnectRequest](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_Equals_Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_"></a> Equals\(ConnectRequest\)

```csharp
public bool Equals(CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest other)
```

#### Parameters

`other` [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ConnectRequest](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_MergeFrom_Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_"></a> MergeFrom\(ConnectRequest\)

```csharp
public void MergeFrom(CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest other)
```

#### Parameters

`other` [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ConnectRequest](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

