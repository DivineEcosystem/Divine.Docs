# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate"></a> Class CMsgSteamDatagramCertificate

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramCertificate : IMessage<CMsgSteamDatagramCertificate>, IEquatable<CMsgSteamDatagramCertificate>, IDeepCloneable<CMsgSteamDatagramCertificate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramCertificate](Divine.Protobufs.Steam.CMsgSteamDatagramCertificate.md)

#### Implements

IMessage<CMsgSteamDatagramCertificate\>, 
[IEquatable<CMsgSteamDatagramCertificate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramCertificate\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramCertificate\>\(CMsgSteamDatagramCertificate, params CMsgSteamDatagramCertificate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate__ctor"></a> CMsgSteamDatagramCertificate\(\)

```csharp
public CMsgSteamDatagramCertificate()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_"></a> CMsgSteamDatagramCertificate\(CMsgSteamDatagramCertificate\)

```csharp
public CMsgSteamDatagramCertificate(CMsgSteamDatagramCertificate other)
```

#### Parameters

`other` [CMsgSteamDatagramCertificate](Divine.Protobufs.Steam.CMsgSteamDatagramCertificate.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_AppIdsFieldNumber"></a> AppIdsFieldNumber

```csharp
public const int AppIdsFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_GameserverDatacenterIdsFieldNumber"></a> GameserverDatacenterIdsFieldNumber

```csharp
public const int GameserverDatacenterIdsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_IdentityStringFieldNumber"></a> IdentityStringFieldNumber

```csharp
public const int IdentityStringFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_IpAddressesFieldNumber"></a> IpAddressesFieldNumber

```csharp
public const int IpAddressesFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_KeyDataFieldNumber"></a> KeyDataFieldNumber

```csharp
public const int KeyDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_KeyTypeFieldNumber"></a> KeyTypeFieldNumber

```csharp
public const int KeyTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_LegacyIdentityBinaryFieldNumber"></a> LegacyIdentityBinaryFieldNumber

```csharp
public const int LegacyIdentityBinaryFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_LegacySteamIdFieldNumber"></a> LegacySteamIdFieldNumber

```csharp
public const int LegacySteamIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_TimeCreatedFieldNumber"></a> TimeCreatedFieldNumber

```csharp
public const int TimeCreatedFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_TimeExpiryFieldNumber"></a> TimeExpiryFieldNumber

```csharp
public const int TimeExpiryFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_AppIds"></a> AppIds

```csharp
public RepeatedField<uint> AppIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_GameserverDatacenterIds"></a> GameserverDatacenterIds

```csharp
public RepeatedField<uint> GameserverDatacenterIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_HasIdentityString"></a> HasIdentityString

```csharp
public bool HasIdentityString { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_HasKeyData"></a> HasKeyData

```csharp
public bool HasKeyData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_HasKeyType"></a> HasKeyType

```csharp
public bool HasKeyType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_HasLegacySteamId"></a> HasLegacySteamId

```csharp
public bool HasLegacySteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_HasTimeCreated"></a> HasTimeCreated

```csharp
public bool HasTimeCreated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_HasTimeExpiry"></a> HasTimeExpiry

```csharp
public bool HasTimeExpiry { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_IdentityString"></a> IdentityString

```csharp
public string IdentityString { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_IpAddresses"></a> IpAddresses

```csharp
public RepeatedField<string> IpAddresses { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_KeyData"></a> KeyData

```csharp
public ByteString KeyData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_KeyType"></a> KeyType

```csharp
public CMsgSteamDatagramCertificate.Types.EKeyType KeyType { get; set; }
```

#### Property Value

 [CMsgSteamDatagramCertificate](Divine.Protobufs.Steam.CMsgSteamDatagramCertificate.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramCertificate.Types.md).[EKeyType](Divine.Protobufs.Steam.CMsgSteamDatagramCertificate.Types.EKeyType.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_LegacyIdentityBinary"></a> LegacyIdentityBinary

```csharp
public CMsgSteamNetworkingIdentityLegacyBinary LegacyIdentityBinary { get; set; }
```

#### Property Value

 [CMsgSteamNetworkingIdentityLegacyBinary](Divine.Protobufs.Steam.CMsgSteamNetworkingIdentityLegacyBinary.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_LegacySteamId"></a> LegacySteamId

```csharp
public ulong LegacySteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramCertificate> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramCertificate](Divine.Protobufs.Steam.CMsgSteamDatagramCertificate.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_TimeCreated"></a> TimeCreated

```csharp
public uint TimeCreated { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_TimeExpiry"></a> TimeExpiry

```csharp
public uint TimeExpiry { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_ClearIdentityString"></a> ClearIdentityString\(\)

```csharp
public void ClearIdentityString()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_ClearKeyData"></a> ClearKeyData\(\)

```csharp
public void ClearKeyData()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_ClearKeyType"></a> ClearKeyType\(\)

```csharp
public void ClearKeyType()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_ClearLegacySteamId"></a> ClearLegacySteamId\(\)

```csharp
public void ClearLegacySteamId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_ClearTimeCreated"></a> ClearTimeCreated\(\)

```csharp
public void ClearTimeCreated()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_ClearTimeExpiry"></a> ClearTimeExpiry\(\)

```csharp
public void ClearTimeExpiry()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramCertificate Clone()
```

#### Returns

 [CMsgSteamDatagramCertificate](Divine.Protobufs.Steam.CMsgSteamDatagramCertificate.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_"></a> Equals\(CMsgSteamDatagramCertificate\)

```csharp
public bool Equals(CMsgSteamDatagramCertificate other)
```

#### Parameters

`other` [CMsgSteamDatagramCertificate](Divine.Protobufs.Steam.CMsgSteamDatagramCertificate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_"></a> MergeFrom\(CMsgSteamDatagramCertificate\)

```csharp
public void MergeFrom(CMsgSteamDatagramCertificate other)
```

#### Parameters

`other` [CMsgSteamDatagramCertificate](Divine.Protobufs.Steam.CMsgSteamDatagramCertificate.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCertificate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

