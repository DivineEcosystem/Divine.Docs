# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateRequest"></a> Class CMsgSteamDatagramCertificateRequest

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramCertificateRequest : IMessage<CMsgSteamDatagramCertificateRequest>, IEquatable<CMsgSteamDatagramCertificateRequest>, IDeepCloneable<CMsgSteamDatagramCertificateRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramCertificateRequest](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateRequest.md)

#### Implements

IMessage<CMsgSteamDatagramCertificateRequest\>, 
[IEquatable<CMsgSteamDatagramCertificateRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramCertificateRequest\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramCertificateRequest\>\(CMsgSteamDatagramCertificateRequest, params CMsgSteamDatagramCertificateRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateRequest__ctor"></a> CMsgSteamDatagramCertificateRequest\(\)

```csharp
public CMsgSteamDatagramCertificateRequest()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateRequest__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramCertificateRequest_"></a> CMsgSteamDatagramCertificateRequest\(CMsgSteamDatagramCertificateRequest\)

```csharp
public CMsgSteamDatagramCertificateRequest(CMsgSteamDatagramCertificateRequest other)
```

#### Parameters

`other` [CMsgSteamDatagramCertificateRequest](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateRequest.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateRequest_CertFieldNumber"></a> CertFieldNumber

```csharp
public const int CertFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateRequest_Cert"></a> Cert

```csharp
public CMsgSteamDatagramCertificate Cert { get; set; }
```

#### Property Value

 [CMsgSteamDatagramCertificate](Divine.Protobufs.Steam.CMsgSteamDatagramCertificate.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramCertificateRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramCertificateRequest](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateRequest_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramCertificateRequest Clone()
```

#### Returns

 [CMsgSteamDatagramCertificateRequest](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateRequest_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramCertificateRequest_"></a> Equals\(CMsgSteamDatagramCertificateRequest\)

```csharp
public bool Equals(CMsgSteamDatagramCertificateRequest other)
```

#### Parameters

`other` [CMsgSteamDatagramCertificateRequest](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateRequest_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramCertificateRequest_"></a> MergeFrom\(CMsgSteamDatagramCertificateRequest\)

```csharp
public void MergeFrom(CMsgSteamDatagramCertificateRequest other)
```

#### Parameters

`other` [CMsgSteamDatagramCertificateRequest](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificateRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

