# <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket"></a> Class CMsgGCToClientSteamDatagramTicket

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientSteamDatagramTicket : IMessage<CMsgGCToClientSteamDatagramTicket>, IEquatable<CMsgGCToClientSteamDatagramTicket>, IDeepCloneable<CMsgGCToClientSteamDatagramTicket>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientSteamDatagramTicket](Divine.Protobufs.Dota2.CMsgGCToClientSteamDatagramTicket.md)

#### Implements

IMessage<CMsgGCToClientSteamDatagramTicket\>, 
[IEquatable<CMsgGCToClientSteamDatagramTicket\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientSteamDatagramTicket\>, 
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
[EnumerableExtensions.In<CMsgGCToClientSteamDatagramTicket\>\(CMsgGCToClientSteamDatagramTicket, params CMsgGCToClientSteamDatagramTicket\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket__ctor"></a> CMsgGCToClientSteamDatagramTicket\(\)

```csharp
public CMsgGCToClientSteamDatagramTicket()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket__ctor_Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_"></a> CMsgGCToClientSteamDatagramTicket\(CMsgGCToClientSteamDatagramTicket\)

```csharp
public CMsgGCToClientSteamDatagramTicket(CMsgGCToClientSteamDatagramTicket other)
```

#### Parameters

`other` [CMsgGCToClientSteamDatagramTicket](Divine.Protobufs.Dota2.CMsgGCToClientSteamDatagramTicket.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_LegacyAppIdFieldNumber"></a> LegacyAppIdFieldNumber

```csharp
public const int LegacyAppIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_LegacyAuthorizedPublicIpFieldNumber"></a> LegacyAuthorizedPublicIpFieldNumber

```csharp
public const int LegacyAuthorizedPublicIpFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_LegacyAuthorizedSteamIdFieldNumber"></a> LegacyAuthorizedSteamIdFieldNumber

```csharp
public const int LegacyAuthorizedSteamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_LegacyExtraFieldsFieldNumber"></a> LegacyExtraFieldsFieldNumber

```csharp
public const int LegacyExtraFieldsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_LegacyGameserverNetIdFieldNumber"></a> LegacyGameserverNetIdFieldNumber

```csharp
public const int LegacyGameserverNetIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_LegacyGameserverSteamIdFieldNumber"></a> LegacyGameserverSteamIdFieldNumber

```csharp
public const int LegacyGameserverSteamIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_LegacySignatureFieldNumber"></a> LegacySignatureFieldNumber

```csharp
public const int LegacySignatureFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_LegacyTimeExpiryFieldNumber"></a> LegacyTimeExpiryFieldNumber

```csharp
public const int LegacyTimeExpiryFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_SerializedTicketFieldNumber"></a> SerializedTicketFieldNumber

```csharp
public const int SerializedTicketFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_HasLegacyAppId"></a> HasLegacyAppId

```csharp
public bool HasLegacyAppId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_HasLegacyAuthorizedPublicIp"></a> HasLegacyAuthorizedPublicIp

```csharp
public bool HasLegacyAuthorizedPublicIp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_HasLegacyAuthorizedSteamId"></a> HasLegacyAuthorizedSteamId

```csharp
public bool HasLegacyAuthorizedSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_HasLegacyGameserverNetId"></a> HasLegacyGameserverNetId

```csharp
public bool HasLegacyGameserverNetId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_HasLegacyGameserverSteamId"></a> HasLegacyGameserverSteamId

```csharp
public bool HasLegacyGameserverSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_HasLegacySignature"></a> HasLegacySignature

```csharp
public bool HasLegacySignature { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_HasLegacyTimeExpiry"></a> HasLegacyTimeExpiry

```csharp
public bool HasLegacyTimeExpiry { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_HasSerializedTicket"></a> HasSerializedTicket

```csharp
public bool HasSerializedTicket { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_LegacyAppId"></a> LegacyAppId

```csharp
public uint LegacyAppId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_LegacyAuthorizedPublicIp"></a> LegacyAuthorizedPublicIp

```csharp
public uint LegacyAuthorizedPublicIp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_LegacyAuthorizedSteamId"></a> LegacyAuthorizedSteamId

```csharp
public ulong LegacyAuthorizedSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_LegacyExtraFields"></a> LegacyExtraFields

```csharp
public RepeatedField<ByteString> LegacyExtraFields { get; }
```

#### Property Value

 RepeatedField<ByteString\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_LegacyGameserverNetId"></a> LegacyGameserverNetId

```csharp
public ulong LegacyGameserverNetId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_LegacyGameserverSteamId"></a> LegacyGameserverSteamId

```csharp
public ulong LegacyGameserverSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_LegacySignature"></a> LegacySignature

```csharp
public ByteString LegacySignature { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_LegacyTimeExpiry"></a> LegacyTimeExpiry

```csharp
public uint LegacyTimeExpiry { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientSteamDatagramTicket> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientSteamDatagramTicket](Divine.Protobufs.Dota2.CMsgGCToClientSteamDatagramTicket.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_SerializedTicket"></a> SerializedTicket

```csharp
public ByteString SerializedTicket { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_ClearLegacyAppId"></a> ClearLegacyAppId\(\)

```csharp
public void ClearLegacyAppId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_ClearLegacyAuthorizedPublicIp"></a> ClearLegacyAuthorizedPublicIp\(\)

```csharp
public void ClearLegacyAuthorizedPublicIp()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_ClearLegacyAuthorizedSteamId"></a> ClearLegacyAuthorizedSteamId\(\)

```csharp
public void ClearLegacyAuthorizedSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_ClearLegacyGameserverNetId"></a> ClearLegacyGameserverNetId\(\)

```csharp
public void ClearLegacyGameserverNetId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_ClearLegacyGameserverSteamId"></a> ClearLegacyGameserverSteamId\(\)

```csharp
public void ClearLegacyGameserverSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_ClearLegacySignature"></a> ClearLegacySignature\(\)

```csharp
public void ClearLegacySignature()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_ClearLegacyTimeExpiry"></a> ClearLegacyTimeExpiry\(\)

```csharp
public void ClearLegacyTimeExpiry()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_ClearSerializedTicket"></a> ClearSerializedTicket\(\)

```csharp
public void ClearSerializedTicket()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientSteamDatagramTicket Clone()
```

#### Returns

 [CMsgGCToClientSteamDatagramTicket](Divine.Protobufs.Dota2.CMsgGCToClientSteamDatagramTicket.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_Equals_Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_"></a> Equals\(CMsgGCToClientSteamDatagramTicket\)

```csharp
public bool Equals(CMsgGCToClientSteamDatagramTicket other)
```

#### Parameters

`other` [CMsgGCToClientSteamDatagramTicket](Divine.Protobufs.Dota2.CMsgGCToClientSteamDatagramTicket.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_"></a> MergeFrom\(CMsgGCToClientSteamDatagramTicket\)

```csharp
public void MergeFrom(CMsgGCToClientSteamDatagramTicket other)
```

#### Parameters

`other` [CMsgGCToClientSteamDatagramTicket](Divine.Protobufs.Dota2.CMsgGCToClientSteamDatagramTicket.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientSteamDatagramTicket_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

