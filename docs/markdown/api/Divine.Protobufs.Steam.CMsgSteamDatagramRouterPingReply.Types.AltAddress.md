# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress"></a> Class CMsgSteamDatagramRouterPingReply.Types.AltAddress

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramRouterPingReply.Types.AltAddress : IMessage<CMsgSteamDatagramRouterPingReply.Types.AltAddress>, IEquatable<CMsgSteamDatagramRouterPingReply.Types.AltAddress>, IDeepCloneable<CMsgSteamDatagramRouterPingReply.Types.AltAddress>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramRouterPingReply.Types.AltAddress](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.AltAddress.md)

#### Implements

IMessage<CMsgSteamDatagramRouterPingReply.Types.AltAddress\>, 
[IEquatable<CMsgSteamDatagramRouterPingReply.Types.AltAddress\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramRouterPingReply.Types.AltAddress\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramRouterPingReply.Types.AltAddress\>\(CMsgSteamDatagramRouterPingReply.Types.AltAddress, params CMsgSteamDatagramRouterPingReply.Types.AltAddress\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress__ctor"></a> AltAddress\(\)

```csharp
public AltAddress()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_"></a> AltAddress\(AltAddress\)

```csharp
public AltAddress(CMsgSteamDatagramRouterPingReply.Types.AltAddress other)
```

#### Parameters

`other` [CMsgSteamDatagramRouterPingReply](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.md).[AltAddress](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.AltAddress.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_Ipv4FieldNumber"></a> Ipv4FieldNumber

```csharp
public const int Ipv4FieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_PenaltyFieldNumber"></a> PenaltyFieldNumber

```csharp
public const int PenaltyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_PortFieldNumber"></a> PortFieldNumber

```csharp
public const int PortFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_ProtocolFieldNumber"></a> ProtocolFieldNumber

```csharp
public const int ProtocolFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_HasIpv4"></a> HasIpv4

```csharp
public bool HasIpv4 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_HasPenalty"></a> HasPenalty

```csharp
public bool HasPenalty { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_HasPort"></a> HasPort

```csharp
public bool HasPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_HasProtocol"></a> HasProtocol

```csharp
public bool HasProtocol { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_Id"></a> Id

```csharp
public string Id { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_Ipv4"></a> Ipv4

```csharp
public uint Ipv4 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramRouterPingReply.Types.AltAddress> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramRouterPingReply](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.md).[AltAddress](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.AltAddress.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_Penalty"></a> Penalty

```csharp
public uint Penalty { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_Port"></a> Port

```csharp
public uint Port { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_Protocol"></a> Protocol

```csharp
public CMsgSteamDatagramRouterPingReply.Types.AltAddress.Types.Protocol Protocol { get; set; }
```

#### Property Value

 [CMsgSteamDatagramRouterPingReply](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.md).[AltAddress](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.AltAddress.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.AltAddress.Types.md).[Protocol](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.AltAddress.Types.Protocol.md)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_ClearIpv4"></a> ClearIpv4\(\)

```csharp
public void ClearIpv4()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_ClearPenalty"></a> ClearPenalty\(\)

```csharp
public void ClearPenalty()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_ClearPort"></a> ClearPort\(\)

```csharp
public void ClearPort()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_ClearProtocol"></a> ClearProtocol\(\)

```csharp
public void ClearProtocol()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramRouterPingReply.Types.AltAddress Clone()
```

#### Returns

 [CMsgSteamDatagramRouterPingReply](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.md).[AltAddress](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.AltAddress.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_"></a> Equals\(AltAddress\)

```csharp
public bool Equals(CMsgSteamDatagramRouterPingReply.Types.AltAddress other)
```

#### Parameters

`other` [CMsgSteamDatagramRouterPingReply](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.md).[AltAddress](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.AltAddress.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_"></a> MergeFrom\(AltAddress\)

```csharp
public void MergeFrom(CMsgSteamDatagramRouterPingReply.Types.AltAddress other)
```

#### Parameters

`other` [CMsgSteamDatagramRouterPingReply](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.md).[AltAddress](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.AltAddress.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Types_AltAddress_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

