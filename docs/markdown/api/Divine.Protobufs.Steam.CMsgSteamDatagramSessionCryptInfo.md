# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo"></a> Class CMsgSteamDatagramSessionCryptInfo

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramSessionCryptInfo : IMessage<CMsgSteamDatagramSessionCryptInfo>, IEquatable<CMsgSteamDatagramSessionCryptInfo>, IDeepCloneable<CMsgSteamDatagramSessionCryptInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramSessionCryptInfo](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfo.md)

#### Implements

IMessage<CMsgSteamDatagramSessionCryptInfo\>, 
[IEquatable<CMsgSteamDatagramSessionCryptInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramSessionCryptInfo\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramSessionCryptInfo\>\(CMsgSteamDatagramSessionCryptInfo, params CMsgSteamDatagramSessionCryptInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo__ctor"></a> CMsgSteamDatagramSessionCryptInfo\(\)

```csharp
public CMsgSteamDatagramSessionCryptInfo()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_"></a> CMsgSteamDatagramSessionCryptInfo\(CMsgSteamDatagramSessionCryptInfo\)

```csharp
public CMsgSteamDatagramSessionCryptInfo(CMsgSteamDatagramSessionCryptInfo other)
```

#### Parameters

`other` [CMsgSteamDatagramSessionCryptInfo](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfo.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_CiphersFieldNumber"></a> CiphersFieldNumber

```csharp
public const int CiphersFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_KeyDataFieldNumber"></a> KeyDataFieldNumber

```csharp
public const int KeyDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_KeyTypeFieldNumber"></a> KeyTypeFieldNumber

```csharp
public const int KeyTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_NonceFieldNumber"></a> NonceFieldNumber

```csharp
public const int NonceFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_ProtocolVersionFieldNumber"></a> ProtocolVersionFieldNumber

```csharp
public const int ProtocolVersionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_Ciphers"></a> Ciphers

```csharp
public RepeatedField<ESteamNetworkingSocketsCipher> Ciphers { get; }
```

#### Property Value

 RepeatedField<[ESteamNetworkingSocketsCipher](Divine.Protobufs.Steam.ESteamNetworkingSocketsCipher.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_HasKeyData"></a> HasKeyData

```csharp
public bool HasKeyData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_HasKeyType"></a> HasKeyType

```csharp
public bool HasKeyType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_HasNonce"></a> HasNonce

```csharp
public bool HasNonce { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_HasProtocolVersion"></a> HasProtocolVersion

```csharp
public bool HasProtocolVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_KeyData"></a> KeyData

```csharp
public ByteString KeyData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_KeyType"></a> KeyType

```csharp
public CMsgSteamDatagramSessionCryptInfo.Types.EKeyType KeyType { get; set; }
```

#### Property Value

 [CMsgSteamDatagramSessionCryptInfo](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfo.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfo.Types.md).[EKeyType](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfo.Types.EKeyType.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_Nonce"></a> Nonce

```csharp
public ulong Nonce { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramSessionCryptInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramSessionCryptInfo](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfo.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_ProtocolVersion"></a> ProtocolVersion

```csharp
public uint ProtocolVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_ClearKeyData"></a> ClearKeyData\(\)

```csharp
public void ClearKeyData()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_ClearKeyType"></a> ClearKeyType\(\)

```csharp
public void ClearKeyType()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_ClearNonce"></a> ClearNonce\(\)

```csharp
public void ClearNonce()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_ClearProtocolVersion"></a> ClearProtocolVersion\(\)

```csharp
public void ClearProtocolVersion()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramSessionCryptInfo Clone()
```

#### Returns

 [CMsgSteamDatagramSessionCryptInfo](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfo.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_"></a> Equals\(CMsgSteamDatagramSessionCryptInfo\)

```csharp
public bool Equals(CMsgSteamDatagramSessionCryptInfo other)
```

#### Parameters

`other` [CMsgSteamDatagramSessionCryptInfo](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_"></a> MergeFrom\(CMsgSteamDatagramSessionCryptInfo\)

```csharp
public void MergeFrom(CMsgSteamDatagramSessionCryptInfo other)
```

#### Parameters

`other` [CMsgSteamDatagramSessionCryptInfo](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfo.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSessionCryptInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

