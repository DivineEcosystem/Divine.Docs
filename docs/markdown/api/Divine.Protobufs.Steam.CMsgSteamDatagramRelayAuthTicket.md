# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket"></a> Class CMsgSteamDatagramRelayAuthTicket

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramRelayAuthTicket : IMessage<CMsgSteamDatagramRelayAuthTicket>, IEquatable<CMsgSteamDatagramRelayAuthTicket>, IDeepCloneable<CMsgSteamDatagramRelayAuthTicket>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramRelayAuthTicket](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.md)

#### Implements

IMessage<CMsgSteamDatagramRelayAuthTicket\>, 
[IEquatable<CMsgSteamDatagramRelayAuthTicket\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramRelayAuthTicket\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramRelayAuthTicket\>\(CMsgSteamDatagramRelayAuthTicket, params CMsgSteamDatagramRelayAuthTicket\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket__ctor"></a> CMsgSteamDatagramRelayAuthTicket\(\)

```csharp
public CMsgSteamDatagramRelayAuthTicket()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_"></a> CMsgSteamDatagramRelayAuthTicket\(CMsgSteamDatagramRelayAuthTicket\)

```csharp
public CMsgSteamDatagramRelayAuthTicket(CMsgSteamDatagramRelayAuthTicket other)
```

#### Parameters

`other` [CMsgSteamDatagramRelayAuthTicket](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_AppIdFieldNumber"></a> AppIdFieldNumber

```csharp
public const int AppIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_AuthorizedClientIdentityStringFieldNumber"></a> AuthorizedClientIdentityStringFieldNumber

```csharp
public const int AuthorizedClientIdentityStringFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_AuthorizedPublicIpFieldNumber"></a> AuthorizedPublicIpFieldNumber

```csharp
public const int AuthorizedPublicIpFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_ExtraFieldsFieldNumber"></a> ExtraFieldsFieldNumber

```csharp
public const int ExtraFieldsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_GameserverAddressFieldNumber"></a> GameserverAddressFieldNumber

```csharp
public const int GameserverAddressFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_GameserverIdentityStringFieldNumber"></a> GameserverIdentityStringFieldNumber

```csharp
public const int GameserverIdentityStringFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_LegacyAuthorizedClientIdentityBinaryFieldNumber"></a> LegacyAuthorizedClientIdentityBinaryFieldNumber

```csharp
public const int LegacyAuthorizedClientIdentityBinaryFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_LegacyAuthorizedSteamIdFieldNumber"></a> LegacyAuthorizedSteamIdFieldNumber

```csharp
public const int LegacyAuthorizedSteamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_LegacyGameserverIdentityBinaryFieldNumber"></a> LegacyGameserverIdentityBinaryFieldNumber

```csharp
public const int LegacyGameserverIdentityBinaryFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_LegacyGameserverPopIdFieldNumber"></a> LegacyGameserverPopIdFieldNumber

```csharp
public const int LegacyGameserverPopIdFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_LegacyGameserverSteamIdFieldNumber"></a> LegacyGameserverSteamIdFieldNumber

```csharp
public const int LegacyGameserverSteamIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_TimeExpiryFieldNumber"></a> TimeExpiryFieldNumber

```csharp
public const int TimeExpiryFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_VirtualPortFieldNumber"></a> VirtualPortFieldNumber

```csharp
public const int VirtualPortFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_AppId"></a> AppId

```csharp
public uint AppId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_AuthorizedClientIdentityString"></a> AuthorizedClientIdentityString

```csharp
public string AuthorizedClientIdentityString { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_AuthorizedPublicIp"></a> AuthorizedPublicIp

```csharp
public uint AuthorizedPublicIp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_ExtraFields"></a> ExtraFields

```csharp
public RepeatedField<CMsgSteamDatagramRelayAuthTicket.Types.ExtraField> ExtraFields { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamDatagramRelayAuthTicket](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.Types.md).[ExtraField](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.Types.ExtraField.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_GameserverAddress"></a> GameserverAddress

```csharp
public ByteString GameserverAddress { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_GameserverIdentityString"></a> GameserverIdentityString

```csharp
public string GameserverIdentityString { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_HasAppId"></a> HasAppId

```csharp
public bool HasAppId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_HasAuthorizedClientIdentityString"></a> HasAuthorizedClientIdentityString

```csharp
public bool HasAuthorizedClientIdentityString { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_HasAuthorizedPublicIp"></a> HasAuthorizedPublicIp

```csharp
public bool HasAuthorizedPublicIp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_HasGameserverAddress"></a> HasGameserverAddress

```csharp
public bool HasGameserverAddress { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_HasGameserverIdentityString"></a> HasGameserverIdentityString

```csharp
public bool HasGameserverIdentityString { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_HasLegacyAuthorizedClientIdentityBinary"></a> HasLegacyAuthorizedClientIdentityBinary

```csharp
public bool HasLegacyAuthorizedClientIdentityBinary { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_HasLegacyAuthorizedSteamId"></a> HasLegacyAuthorizedSteamId

```csharp
public bool HasLegacyAuthorizedSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_HasLegacyGameserverIdentityBinary"></a> HasLegacyGameserverIdentityBinary

```csharp
public bool HasLegacyGameserverIdentityBinary { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_HasLegacyGameserverPopId"></a> HasLegacyGameserverPopId

```csharp
public bool HasLegacyGameserverPopId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_HasLegacyGameserverSteamId"></a> HasLegacyGameserverSteamId

```csharp
public bool HasLegacyGameserverSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_HasTimeExpiry"></a> HasTimeExpiry

```csharp
public bool HasTimeExpiry { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_HasVirtualPort"></a> HasVirtualPort

```csharp
public bool HasVirtualPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_LegacyAuthorizedClientIdentityBinary"></a> LegacyAuthorizedClientIdentityBinary

```csharp
public ByteString LegacyAuthorizedClientIdentityBinary { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_LegacyAuthorizedSteamId"></a> LegacyAuthorizedSteamId

```csharp
public ulong LegacyAuthorizedSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_LegacyGameserverIdentityBinary"></a> LegacyGameserverIdentityBinary

```csharp
public ByteString LegacyGameserverIdentityBinary { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_LegacyGameserverPopId"></a> LegacyGameserverPopId

```csharp
public uint LegacyGameserverPopId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_LegacyGameserverSteamId"></a> LegacyGameserverSteamId

```csharp
public ulong LegacyGameserverSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramRelayAuthTicket> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramRelayAuthTicket](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_TimeExpiry"></a> TimeExpiry

```csharp
public uint TimeExpiry { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_VirtualPort"></a> VirtualPort

```csharp
public uint VirtualPort { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_ClearAppId"></a> ClearAppId\(\)

```csharp
public void ClearAppId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_ClearAuthorizedClientIdentityString"></a> ClearAuthorizedClientIdentityString\(\)

```csharp
public void ClearAuthorizedClientIdentityString()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_ClearAuthorizedPublicIp"></a> ClearAuthorizedPublicIp\(\)

```csharp
public void ClearAuthorizedPublicIp()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_ClearGameserverAddress"></a> ClearGameserverAddress\(\)

```csharp
public void ClearGameserverAddress()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_ClearGameserverIdentityString"></a> ClearGameserverIdentityString\(\)

```csharp
public void ClearGameserverIdentityString()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_ClearLegacyAuthorizedClientIdentityBinary"></a> ClearLegacyAuthorizedClientIdentityBinary\(\)

```csharp
public void ClearLegacyAuthorizedClientIdentityBinary()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_ClearLegacyAuthorizedSteamId"></a> ClearLegacyAuthorizedSteamId\(\)

```csharp
public void ClearLegacyAuthorizedSteamId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_ClearLegacyGameserverIdentityBinary"></a> ClearLegacyGameserverIdentityBinary\(\)

```csharp
public void ClearLegacyGameserverIdentityBinary()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_ClearLegacyGameserverPopId"></a> ClearLegacyGameserverPopId\(\)

```csharp
public void ClearLegacyGameserverPopId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_ClearLegacyGameserverSteamId"></a> ClearLegacyGameserverSteamId\(\)

```csharp
public void ClearLegacyGameserverSteamId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_ClearTimeExpiry"></a> ClearTimeExpiry\(\)

```csharp
public void ClearTimeExpiry()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_ClearVirtualPort"></a> ClearVirtualPort\(\)

```csharp
public void ClearVirtualPort()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramRelayAuthTicket Clone()
```

#### Returns

 [CMsgSteamDatagramRelayAuthTicket](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_"></a> Equals\(CMsgSteamDatagramRelayAuthTicket\)

```csharp
public bool Equals(CMsgSteamDatagramRelayAuthTicket other)
```

#### Parameters

`other` [CMsgSteamDatagramRelayAuthTicket](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_"></a> MergeFrom\(CMsgSteamDatagramRelayAuthTicket\)

```csharp
public void MergeFrom(CMsgSteamDatagramRelayAuthTicket other)
```

#### Parameters

`other` [CMsgSteamDatagramRelayAuthTicket](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

