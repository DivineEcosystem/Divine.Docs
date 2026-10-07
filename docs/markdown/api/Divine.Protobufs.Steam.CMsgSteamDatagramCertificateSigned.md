# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned"></a> Class CMsgSteamDatagramCertificateSigned

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramCertificateSigned : IMessage<CMsgSteamDatagramCertificateSigned>, IEquatable<CMsgSteamDatagramCertificateSigned>, IDeepCloneable<CMsgSteamDatagramCertificateSigned>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramCertificateSigned](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateSigned.md)

#### Implements

IMessage<CMsgSteamDatagramCertificateSigned\>, 
[IEquatable<CMsgSteamDatagramCertificateSigned\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramCertificateSigned\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramCertificateSigned\>\(CMsgSteamDatagramCertificateSigned, params CMsgSteamDatagramCertificateSigned\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned__ctor"></a> CMsgSteamDatagramCertificateSigned\(\)

```csharp
public CMsgSteamDatagramCertificateSigned()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_"></a> CMsgSteamDatagramCertificateSigned\(CMsgSteamDatagramCertificateSigned\)

```csharp
public CMsgSteamDatagramCertificateSigned(CMsgSteamDatagramCertificateSigned other)
```

#### Parameters

`other` [CMsgSteamDatagramCertificateSigned](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateSigned.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_CaKeyIdFieldNumber"></a> CaKeyIdFieldNumber

```csharp
public const int CaKeyIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_CaSignatureFieldNumber"></a> CaSignatureFieldNumber

```csharp
public const int CaSignatureFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_CertFieldNumber"></a> CertFieldNumber

```csharp
public const int CertFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_PrivateKeyDataFieldNumber"></a> PrivateKeyDataFieldNumber

```csharp
public const int PrivateKeyDataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_CaKeyId"></a> CaKeyId

```csharp
public ulong CaKeyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_CaSignature"></a> CaSignature

```csharp
public ByteString CaSignature { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_Cert"></a> Cert

```csharp
public ByteString Cert { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_HasCaKeyId"></a> HasCaKeyId

```csharp
public bool HasCaKeyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_HasCaSignature"></a> HasCaSignature

```csharp
public bool HasCaSignature { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_HasCert"></a> HasCert

```csharp
public bool HasCert { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_HasPrivateKeyData"></a> HasPrivateKeyData

```csharp
public bool HasPrivateKeyData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramCertificateSigned> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramCertificateSigned](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateSigned.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_PrivateKeyData"></a> PrivateKeyData

```csharp
public ByteString PrivateKeyData { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_ClearCaKeyId"></a> ClearCaKeyId\(\)

```csharp
public void ClearCaKeyId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_ClearCaSignature"></a> ClearCaSignature\(\)

```csharp
public void ClearCaSignature()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_ClearCert"></a> ClearCert\(\)

```csharp
public void ClearCert()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_ClearPrivateKeyData"></a> ClearPrivateKeyData\(\)

```csharp
public void ClearPrivateKeyData()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramCertificateSigned Clone()
```

#### Returns

 [CMsgSteamDatagramCertificateSigned](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateSigned.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_"></a> Equals\(CMsgSteamDatagramCertificateSigned\)

```csharp
public bool Equals(CMsgSteamDatagramCertificateSigned other)
```

#### Parameters

`other` [CMsgSteamDatagramCertificateSigned](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateSigned.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_"></a> MergeFrom\(CMsgSteamDatagramCertificateSigned\)

```csharp
public void MergeFrom(CMsgSteamDatagramCertificateSigned other)
```

#### Parameters

`other` [CMsgSteamDatagramCertificateSigned](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateSigned.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateSigned_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

