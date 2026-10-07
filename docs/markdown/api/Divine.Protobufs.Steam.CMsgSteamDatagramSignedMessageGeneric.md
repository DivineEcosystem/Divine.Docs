# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric"></a> Class CMsgSteamDatagramSignedMessageGeneric

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramSignedMessageGeneric : IMessage<CMsgSteamDatagramSignedMessageGeneric>, IEquatable<CMsgSteamDatagramSignedMessageGeneric>, IDeepCloneable<CMsgSteamDatagramSignedMessageGeneric>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramSignedMessageGeneric](Divine.Protobufs.Steam.CMsgSteamDatagramSignedMessageGeneric.md)

#### Implements

IMessage<CMsgSteamDatagramSignedMessageGeneric\>, 
[IEquatable<CMsgSteamDatagramSignedMessageGeneric\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramSignedMessageGeneric\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramSignedMessageGeneric\>\(CMsgSteamDatagramSignedMessageGeneric, params CMsgSteamDatagramSignedMessageGeneric\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric__ctor"></a> CMsgSteamDatagramSignedMessageGeneric\(\)

```csharp
public CMsgSteamDatagramSignedMessageGeneric()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_"></a> CMsgSteamDatagramSignedMessageGeneric\(CMsgSteamDatagramSignedMessageGeneric\)

```csharp
public CMsgSteamDatagramSignedMessageGeneric(CMsgSteamDatagramSignedMessageGeneric other)
```

#### Parameters

`other` [CMsgSteamDatagramSignedMessageGeneric](Divine.Protobufs.Steam.CMsgSteamDatagramSignedMessageGeneric.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_CertFieldNumber"></a> CertFieldNumber

```csharp
public const int CertFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_DummyPadFieldNumber"></a> DummyPadFieldNumber

```csharp
public const int DummyPadFieldNumber = 1023
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_SignatureFieldNumber"></a> SignatureFieldNumber

```csharp
public const int SignatureFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_SignedDataFieldNumber"></a> SignedDataFieldNumber

```csharp
public const int SignedDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_Cert"></a> Cert

```csharp
public CMsgSteamDatagramCertificateSigned Cert { get; set; }
```

#### Property Value

 [CMsgSteamDatagramCertificateSigned](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateSigned.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_DummyPad"></a> DummyPad

```csharp
public ByteString DummyPad { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_HasDummyPad"></a> HasDummyPad

```csharp
public bool HasDummyPad { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_HasSignature"></a> HasSignature

```csharp
public bool HasSignature { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_HasSignedData"></a> HasSignedData

```csharp
public bool HasSignedData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramSignedMessageGeneric> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramSignedMessageGeneric](Divine.Protobufs.Steam.CMsgSteamDatagramSignedMessageGeneric.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_Signature"></a> Signature

```csharp
public ByteString Signature { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_SignedData"></a> SignedData

```csharp
public ByteString SignedData { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_ClearDummyPad"></a> ClearDummyPad\(\)

```csharp
public void ClearDummyPad()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_ClearSignature"></a> ClearSignature\(\)

```csharp
public void ClearSignature()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_ClearSignedData"></a> ClearSignedData\(\)

```csharp
public void ClearSignedData()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramSignedMessageGeneric Clone()
```

#### Returns

 [CMsgSteamDatagramSignedMessageGeneric](Divine.Protobufs.Steam.CMsgSteamDatagramSignedMessageGeneric.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_"></a> Equals\(CMsgSteamDatagramSignedMessageGeneric\)

```csharp
public bool Equals(CMsgSteamDatagramSignedMessageGeneric other)
```

#### Parameters

`other` [CMsgSteamDatagramSignedMessageGeneric](Divine.Protobufs.Steam.CMsgSteamDatagramSignedMessageGeneric.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_"></a> MergeFrom\(CMsgSteamDatagramSignedMessageGeneric\)

```csharp
public void MergeFrom(CMsgSteamDatagramSignedMessageGeneric other)
```

#### Parameters

`other` [CMsgSteamDatagramSignedMessageGeneric](Divine.Protobufs.Steam.CMsgSteamDatagramSignedMessageGeneric.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedMessageGeneric_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

