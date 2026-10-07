# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody"></a> Class CMsgSteamDatagramGameserverPingRequestBody

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramGameserverPingRequestBody : IMessage<CMsgSteamDatagramGameserverPingRequestBody>, IEquatable<CMsgSteamDatagramGameserverPingRequestBody>, IDeepCloneable<CMsgSteamDatagramGameserverPingRequestBody>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramGameserverPingRequestBody](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverPingRequestBody.md)

#### Implements

IMessage<CMsgSteamDatagramGameserverPingRequestBody\>, 
[IEquatable<CMsgSteamDatagramGameserverPingRequestBody\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramGameserverPingRequestBody\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramGameserverPingRequestBody\>\(CMsgSteamDatagramGameserverPingRequestBody, params CMsgSteamDatagramGameserverPingRequestBody\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody__ctor"></a> CMsgSteamDatagramGameserverPingRequestBody\(\)

```csharp
public CMsgSteamDatagramGameserverPingRequestBody()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_"></a> CMsgSteamDatagramGameserverPingRequestBody\(CMsgSteamDatagramGameserverPingRequestBody\)

```csharp
public CMsgSteamDatagramGameserverPingRequestBody(CMsgSteamDatagramGameserverPingRequestBody other)
```

#### Parameters

`other` [CMsgSteamDatagramGameserverPingRequestBody](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverPingRequestBody.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_EchoFieldNumber"></a> EchoFieldNumber

```csharp
public const int EchoFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_MyIpsFieldNumber"></a> MyIpsFieldNumber

```csharp
public const int MyIpsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_RelayPopidFieldNumber"></a> RelayPopidFieldNumber

```csharp
public const int RelayPopidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_RelayUnixTimeFieldNumber"></a> RelayUnixTimeFieldNumber

```csharp
public const int RelayUnixTimeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_RoutingSecretFieldNumber"></a> RoutingSecretFieldNumber

```csharp
public const int RoutingSecretFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_YourPublicIpFieldNumber"></a> YourPublicIpFieldNumber

```csharp
public const int YourPublicIpFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_YourPublicPortFieldNumber"></a> YourPublicPortFieldNumber

```csharp
public const int YourPublicPortFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_Echo"></a> Echo

```csharp
public ByteString Echo { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_HasEcho"></a> HasEcho

```csharp
public bool HasEcho { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_HasRelayPopid"></a> HasRelayPopid

```csharp
public bool HasRelayPopid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_HasRelayUnixTime"></a> HasRelayUnixTime

```csharp
public bool HasRelayUnixTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_HasRoutingSecret"></a> HasRoutingSecret

```csharp
public bool HasRoutingSecret { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_HasYourPublicPort"></a> HasYourPublicPort

```csharp
public bool HasYourPublicPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_MyIps"></a> MyIps

```csharp
public RepeatedField<CMsgSteamNetworkingIPAddress> MyIps { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamNetworkingIPAddress](Divine.Protobufs.Steam.CMsgSteamNetworkingIPAddress.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramGameserverPingRequestBody> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramGameserverPingRequestBody](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverPingRequestBody.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_RelayPopid"></a> RelayPopid

```csharp
public uint RelayPopid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_RelayUnixTime"></a> RelayUnixTime

```csharp
public ulong RelayUnixTime { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_RoutingSecret"></a> RoutingSecret

```csharp
public ulong RoutingSecret { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_YourPublicIp"></a> YourPublicIp

```csharp
public CMsgSteamNetworkingIPAddress YourPublicIp { get; set; }
```

#### Property Value

 [CMsgSteamNetworkingIPAddress](Divine.Protobufs.Steam.CMsgSteamNetworkingIPAddress.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_YourPublicPort"></a> YourPublicPort

```csharp
public uint YourPublicPort { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_ClearEcho"></a> ClearEcho\(\)

```csharp
public void ClearEcho()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_ClearRelayPopid"></a> ClearRelayPopid\(\)

```csharp
public void ClearRelayPopid()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_ClearRelayUnixTime"></a> ClearRelayUnixTime\(\)

```csharp
public void ClearRelayUnixTime()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_ClearRoutingSecret"></a> ClearRoutingSecret\(\)

```csharp
public void ClearRoutingSecret()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_ClearYourPublicPort"></a> ClearYourPublicPort\(\)

```csharp
public void ClearYourPublicPort()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramGameserverPingRequestBody Clone()
```

#### Returns

 [CMsgSteamDatagramGameserverPingRequestBody](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverPingRequestBody.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_"></a> Equals\(CMsgSteamDatagramGameserverPingRequestBody\)

```csharp
public bool Equals(CMsgSteamDatagramGameserverPingRequestBody other)
```

#### Parameters

`other` [CMsgSteamDatagramGameserverPingRequestBody](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverPingRequestBody.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_"></a> MergeFrom\(CMsgSteamDatagramGameserverPingRequestBody\)

```csharp
public void MergeFrom(CMsgSteamDatagramGameserverPingRequestBody other)
```

#### Parameters

`other` [CMsgSteamDatagramGameserverPingRequestBody](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverPingRequestBody.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestBody_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

