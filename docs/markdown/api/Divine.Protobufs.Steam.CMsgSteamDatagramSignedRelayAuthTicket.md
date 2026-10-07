# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket"></a> Class CMsgSteamDatagramSignedRelayAuthTicket

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramSignedRelayAuthTicket : IMessage<CMsgSteamDatagramSignedRelayAuthTicket>, IEquatable<CMsgSteamDatagramSignedRelayAuthTicket>, IDeepCloneable<CMsgSteamDatagramSignedRelayAuthTicket>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramSignedRelayAuthTicket](Divine.Protobufs.Steam.CMsgSteamDatagramSignedRelayAuthTicket.md)

#### Implements

IMessage<CMsgSteamDatagramSignedRelayAuthTicket\>, 
[IEquatable<CMsgSteamDatagramSignedRelayAuthTicket\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramSignedRelayAuthTicket\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramSignedRelayAuthTicket\>\(CMsgSteamDatagramSignedRelayAuthTicket, params CMsgSteamDatagramSignedRelayAuthTicket\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket__ctor"></a> CMsgSteamDatagramSignedRelayAuthTicket\(\)

```csharp
public CMsgSteamDatagramSignedRelayAuthTicket()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_"></a> CMsgSteamDatagramSignedRelayAuthTicket\(CMsgSteamDatagramSignedRelayAuthTicket\)

```csharp
public CMsgSteamDatagramSignedRelayAuthTicket(CMsgSteamDatagramSignedRelayAuthTicket other)
```

#### Parameters

`other` [CMsgSteamDatagramSignedRelayAuthTicket](Divine.Protobufs.Steam.CMsgSteamDatagramSignedRelayAuthTicket.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_CertsFieldNumber"></a> CertsFieldNumber

```csharp
public const int CertsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_KeyIdFieldNumber"></a> KeyIdFieldNumber

```csharp
public const int KeyIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_ReservedDoNotUseFieldNumber"></a> ReservedDoNotUseFieldNumber

```csharp
public const int ReservedDoNotUseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_SignatureFieldNumber"></a> SignatureFieldNumber

```csharp
public const int SignatureFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_TicketFieldNumber"></a> TicketFieldNumber

```csharp
public const int TicketFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_Certs"></a> Certs

```csharp
public RepeatedField<CMsgSteamDatagramCertificateSigned> Certs { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamDatagramCertificateSigned](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateSigned.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_HasKeyId"></a> HasKeyId

```csharp
public bool HasKeyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_HasReservedDoNotUse"></a> HasReservedDoNotUse

```csharp
public bool HasReservedDoNotUse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_HasSignature"></a> HasSignature

```csharp
public bool HasSignature { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_HasTicket"></a> HasTicket

```csharp
public bool HasTicket { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_KeyId"></a> KeyId

```csharp
public ulong KeyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramSignedRelayAuthTicket> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramSignedRelayAuthTicket](Divine.Protobufs.Steam.CMsgSteamDatagramSignedRelayAuthTicket.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_ReservedDoNotUse"></a> ReservedDoNotUse

```csharp
public ulong ReservedDoNotUse { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_Signature"></a> Signature

```csharp
public ByteString Signature { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_Ticket"></a> Ticket

```csharp
public ByteString Ticket { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_ClearKeyId"></a> ClearKeyId\(\)

```csharp
public void ClearKeyId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_ClearReservedDoNotUse"></a> ClearReservedDoNotUse\(\)

```csharp
public void ClearReservedDoNotUse()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_ClearSignature"></a> ClearSignature\(\)

```csharp
public void ClearSignature()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_ClearTicket"></a> ClearTicket\(\)

```csharp
public void ClearTicket()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramSignedRelayAuthTicket Clone()
```

#### Returns

 [CMsgSteamDatagramSignedRelayAuthTicket](Divine.Protobufs.Steam.CMsgSteamDatagramSignedRelayAuthTicket.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_"></a> Equals\(CMsgSteamDatagramSignedRelayAuthTicket\)

```csharp
public bool Equals(CMsgSteamDatagramSignedRelayAuthTicket other)
```

#### Parameters

`other` [CMsgSteamDatagramSignedRelayAuthTicket](Divine.Protobufs.Steam.CMsgSteamDatagramSignedRelayAuthTicket.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_"></a> MergeFrom\(CMsgSteamDatagramSignedRelayAuthTicket\)

```csharp
public void MergeFrom(CMsgSteamDatagramSignedRelayAuthTicket other)
```

#### Parameters

`other` [CMsgSteamDatagramSignedRelayAuthTicket](Divine.Protobufs.Steam.CMsgSteamDatagramSignedRelayAuthTicket.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedRelayAuthTicket_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

