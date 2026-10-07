# <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK"></a> Class CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK : IMessage<CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK>, IEquatable<CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK>, IDeepCloneable<CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK.md)

#### Implements

IMessage<CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK\>, 
[IEquatable<CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK\>, 
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
[EnumerableExtensions.In<CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK\>\(CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK, params CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK__ctor"></a> ConnectOK\(\)

```csharp
public ConnectOK()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK__ctor_Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK_"></a> ConnectOK\(ConnectOK\)

```csharp
public ConnectOK(CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK other)
```

#### Parameters

`other` [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ConnectOK](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK_CertFieldNumber"></a> CertFieldNumber

```csharp
public const int CertFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK_CryptFieldNumber"></a> CryptFieldNumber

```csharp
public const int CryptFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK_Cert"></a> Cert

```csharp
public CMsgSteamDatagramCertificateSigned Cert { get; set; }
```

#### Property Value

 [CMsgSteamDatagramCertificateSigned](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateSigned.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK_Crypt"></a> Crypt

```csharp
public CMsgSteamDatagramSessionCryptInfoSigned Crypt { get; set; }
```

#### Property Value

 [CMsgSteamDatagramSessionCryptInfoSigned](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfoSigned.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ConnectOK](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK_Clone"></a> Clone\(\)

```csharp
public CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK Clone()
```

#### Returns

 [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ConnectOK](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK_Equals_Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK_"></a> Equals\(ConnectOK\)

```csharp
public bool Equals(CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK other)
```

#### Parameters

`other` [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ConnectOK](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK_MergeFrom_Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK_"></a> MergeFrom\(ConnectOK\)

```csharp
public void MergeFrom(CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK other)
```

#### Parameters

`other` [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ConnectOK](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Types_ConnectOK_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

