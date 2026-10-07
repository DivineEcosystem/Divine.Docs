# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned"></a> Class CMsgSteamDatagramSessionCryptInfoSigned

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramSessionCryptInfoSigned : IMessage<CMsgSteamDatagramSessionCryptInfoSigned>, IEquatable<CMsgSteamDatagramSessionCryptInfoSigned>, IDeepCloneable<CMsgSteamDatagramSessionCryptInfoSigned>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramSessionCryptInfoSigned](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfoSigned.md)

#### Implements

IMessage<CMsgSteamDatagramSessionCryptInfoSigned\>, 
[IEquatable<CMsgSteamDatagramSessionCryptInfoSigned\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramSessionCryptInfoSigned\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramSessionCryptInfoSigned\>\(CMsgSteamDatagramSessionCryptInfoSigned, params CMsgSteamDatagramSessionCryptInfoSigned\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned__ctor"></a> CMsgSteamDatagramSessionCryptInfoSigned\(\)

```csharp
public CMsgSteamDatagramSessionCryptInfoSigned()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_"></a> CMsgSteamDatagramSessionCryptInfoSigned\(CMsgSteamDatagramSessionCryptInfoSigned\)

```csharp
public CMsgSteamDatagramSessionCryptInfoSigned(CMsgSteamDatagramSessionCryptInfoSigned other)
```

#### Parameters

`other` [CMsgSteamDatagramSessionCryptInfoSigned](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfoSigned.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_InfoFieldNumber"></a> InfoFieldNumber

```csharp
public const int InfoFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_SignatureFieldNumber"></a> SignatureFieldNumber

```csharp
public const int SignatureFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_HasInfo"></a> HasInfo

```csharp
public bool HasInfo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_HasSignature"></a> HasSignature

```csharp
public bool HasSignature { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_Info"></a> Info

```csharp
public ByteString Info { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramSessionCryptInfoSigned> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramSessionCryptInfoSigned](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfoSigned.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_Signature"></a> Signature

```csharp
public ByteString Signature { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_ClearInfo"></a> ClearInfo\(\)

```csharp
public void ClearInfo()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_ClearSignature"></a> ClearSignature\(\)

```csharp
public void ClearSignature()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramSessionCryptInfoSigned Clone()
```

#### Returns

 [CMsgSteamDatagramSessionCryptInfoSigned](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfoSigned.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_"></a> Equals\(CMsgSteamDatagramSessionCryptInfoSigned\)

```csharp
public bool Equals(CMsgSteamDatagramSessionCryptInfoSigned other)
```

#### Parameters

`other` [CMsgSteamDatagramSessionCryptInfoSigned](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfoSigned.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_"></a> MergeFrom\(CMsgSteamDatagramSessionCryptInfoSigned\)

```csharp
public void MergeFrom(CMsgSteamDatagramSessionCryptInfoSigned other)
```

#### Parameters

`other` [CMsgSteamDatagramSessionCryptInfoSigned](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfoSigned.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfoSigned_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

