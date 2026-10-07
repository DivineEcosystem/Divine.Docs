# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext"></a> Class CMsgSteamDatagramHostedServerAddressPlaintext

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramHostedServerAddressPlaintext : IMessage<CMsgSteamDatagramHostedServerAddressPlaintext>, IEquatable<CMsgSteamDatagramHostedServerAddressPlaintext>, IDeepCloneable<CMsgSteamDatagramHostedServerAddressPlaintext>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramHostedServerAddressPlaintext](Divine.Protobufs.Steam.CMsgSteamDatagramHostedServerAddressPlaintext.md)

#### Implements

IMessage<CMsgSteamDatagramHostedServerAddressPlaintext\>, 
[IEquatable<CMsgSteamDatagramHostedServerAddressPlaintext\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramHostedServerAddressPlaintext\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramHostedServerAddressPlaintext\>\(CMsgSteamDatagramHostedServerAddressPlaintext, params CMsgSteamDatagramHostedServerAddressPlaintext\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext__ctor"></a> CMsgSteamDatagramHostedServerAddressPlaintext\(\)

```csharp
public CMsgSteamDatagramHostedServerAddressPlaintext()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_"></a> CMsgSteamDatagramHostedServerAddressPlaintext\(CMsgSteamDatagramHostedServerAddressPlaintext\)

```csharp
public CMsgSteamDatagramHostedServerAddressPlaintext(CMsgSteamDatagramHostedServerAddressPlaintext other)
```

#### Parameters

`other` [CMsgSteamDatagramHostedServerAddressPlaintext](Divine.Protobufs.Steam.CMsgSteamDatagramHostedServerAddressPlaintext.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_Ipv4FieldNumber"></a> Ipv4FieldNumber

```csharp
public const int Ipv4FieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_Ipv6FieldNumber"></a> Ipv6FieldNumber

```csharp
public const int Ipv6FieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_PortFieldNumber"></a> PortFieldNumber

```csharp
public const int PortFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_ProtocolVersionFieldNumber"></a> ProtocolVersionFieldNumber

```csharp
public const int ProtocolVersionFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_RoutingSecretFieldNumber"></a> RoutingSecretFieldNumber

```csharp
public const int RoutingSecretFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_HasIpv4"></a> HasIpv4

```csharp
public bool HasIpv4 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_HasIpv6"></a> HasIpv6

```csharp
public bool HasIpv6 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_HasPort"></a> HasPort

```csharp
public bool HasPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_HasProtocolVersion"></a> HasProtocolVersion

```csharp
public bool HasProtocolVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_HasRoutingSecret"></a> HasRoutingSecret

```csharp
public bool HasRoutingSecret { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_Ipv4"></a> Ipv4

```csharp
public uint Ipv4 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_Ipv6"></a> Ipv6

```csharp
public ByteString Ipv6 { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramHostedServerAddressPlaintext> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramHostedServerAddressPlaintext](Divine.Protobufs.Steam.CMsgSteamDatagramHostedServerAddressPlaintext.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_Port"></a> Port

```csharp
public uint Port { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_ProtocolVersion"></a> ProtocolVersion

```csharp
public uint ProtocolVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_RoutingSecret"></a> RoutingSecret

```csharp
public ulong RoutingSecret { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_ClearIpv4"></a> ClearIpv4\(\)

```csharp
public void ClearIpv4()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_ClearIpv6"></a> ClearIpv6\(\)

```csharp
public void ClearIpv6()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_ClearPort"></a> ClearPort\(\)

```csharp
public void ClearPort()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_ClearProtocolVersion"></a> ClearProtocolVersion\(\)

```csharp
public void ClearProtocolVersion()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_ClearRoutingSecret"></a> ClearRoutingSecret\(\)

```csharp
public void ClearRoutingSecret()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramHostedServerAddressPlaintext Clone()
```

#### Returns

 [CMsgSteamDatagramHostedServerAddressPlaintext](Divine.Protobufs.Steam.CMsgSteamDatagramHostedServerAddressPlaintext.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_"></a> Equals\(CMsgSteamDatagramHostedServerAddressPlaintext\)

```csharp
public bool Equals(CMsgSteamDatagramHostedServerAddressPlaintext other)
```

#### Parameters

`other` [CMsgSteamDatagramHostedServerAddressPlaintext](Divine.Protobufs.Steam.CMsgSteamDatagramHostedServerAddressPlaintext.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_"></a> MergeFrom\(CMsgSteamDatagramHostedServerAddressPlaintext\)

```csharp
public void MergeFrom(CMsgSteamDatagramHostedServerAddressPlaintext other)
```

#### Parameters

`other` [CMsgSteamDatagramHostedServerAddressPlaintext](Divine.Protobufs.Steam.CMsgSteamDatagramHostedServerAddressPlaintext.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramHostedServerAddressPlaintext_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

