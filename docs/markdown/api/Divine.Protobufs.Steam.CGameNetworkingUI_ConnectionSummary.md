# <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary"></a> Class CGameNetworkingUI\_ConnectionSummary

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGameNetworkingUI_ConnectionSummary : IMessage<CGameNetworkingUI_ConnectionSummary>, IEquatable<CGameNetworkingUI_ConnectionSummary>, IDeepCloneable<CGameNetworkingUI_ConnectionSummary>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGameNetworkingUI\_ConnectionSummary](Divine.Protobufs.Steam.CGameNetworkingUI\_ConnectionSummary.md)

#### Implements

IMessage<CGameNetworkingUI\_ConnectionSummary\>, 
[IEquatable<CGameNetworkingUI\_ConnectionSummary\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGameNetworkingUI\_ConnectionSummary\>, 
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
[EnumerableExtensions.In<CGameNetworkingUI\_ConnectionSummary\>\(CGameNetworkingUI\_ConnectionSummary, params CGameNetworkingUI\_ConnectionSummary\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary__ctor"></a> CGameNetworkingUI\_ConnectionSummary\(\)

```csharp
public CGameNetworkingUI_ConnectionSummary()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary__ctor_Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_"></a> CGameNetworkingUI\_ConnectionSummary\(CGameNetworkingUI\_ConnectionSummary\)

```csharp
public CGameNetworkingUI_ConnectionSummary(CGameNetworkingUI_ConnectionSummary other)
```

#### Parameters

`other` [CGameNetworkingUI\_ConnectionSummary](Divine.Protobufs.Steam.CGameNetworkingUI\_ConnectionSummary.md)

## Fields

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_ConnectionStateFieldNumber"></a> ConnectionStateFieldNumber

```csharp
public const int ConnectionStateFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_IpWasSharedFieldNumber"></a> IpWasSharedFieldNumber

```csharp
public const int IpWasSharedFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_PacketLossFieldNumber"></a> PacketLossFieldNumber

```csharp
public const int PacketLossFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_PingDefaultInternetRouteFieldNumber"></a> PingDefaultInternetRouteFieldNumber

```csharp
public const int PingDefaultInternetRouteFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_PingMsFieldNumber"></a> PingMsFieldNumber

```csharp
public const int PingMsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_SdrpopLocalFieldNumber"></a> SdrpopLocalFieldNumber

```csharp
public const int SdrpopLocalFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_SdrpopRemoteFieldNumber"></a> SdrpopRemoteFieldNumber

```csharp
public const int SdrpopRemoteFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_TransportKindFieldNumber"></a> TransportKindFieldNumber

```csharp
public const int TransportKindFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_ConnectionState"></a> ConnectionState

```csharp
public uint ConnectionState { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_HasConnectionState"></a> HasConnectionState

```csharp
public bool HasConnectionState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_HasIpWasShared"></a> HasIpWasShared

```csharp
public bool HasIpWasShared { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_HasPacketLoss"></a> HasPacketLoss

```csharp
public bool HasPacketLoss { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_HasPingDefaultInternetRoute"></a> HasPingDefaultInternetRoute

```csharp
public bool HasPingDefaultInternetRoute { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_HasPingMs"></a> HasPingMs

```csharp
public bool HasPingMs { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_HasSdrpopLocal"></a> HasSdrpopLocal

```csharp
public bool HasSdrpopLocal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_HasSdrpopRemote"></a> HasSdrpopRemote

```csharp
public bool HasSdrpopRemote { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_HasTransportKind"></a> HasTransportKind

```csharp
public bool HasTransportKind { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_IpWasShared"></a> IpWasShared

```csharp
public bool IpWasShared { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_PacketLoss"></a> PacketLoss

```csharp
public float PacketLoss { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_Parser"></a> Parser

```csharp
public static MessageParser<CGameNetworkingUI_ConnectionSummary> Parser { get; }
```

#### Property Value

 MessageParser<[CGameNetworkingUI\_ConnectionSummary](Divine.Protobufs.Steam.CGameNetworkingUI\_ConnectionSummary.md)\>

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_PingDefaultInternetRoute"></a> PingDefaultInternetRoute

```csharp
public uint PingDefaultInternetRoute { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_PingMs"></a> PingMs

```csharp
public uint PingMs { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_SdrpopLocal"></a> SdrpopLocal

```csharp
public string SdrpopLocal { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_SdrpopRemote"></a> SdrpopRemote

```csharp
public string SdrpopRemote { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_TransportKind"></a> TransportKind

```csharp
public uint TransportKind { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_ClearConnectionState"></a> ClearConnectionState\(\)

```csharp
public void ClearConnectionState()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_ClearIpWasShared"></a> ClearIpWasShared\(\)

```csharp
public void ClearIpWasShared()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_ClearPacketLoss"></a> ClearPacketLoss\(\)

```csharp
public void ClearPacketLoss()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_ClearPingDefaultInternetRoute"></a> ClearPingDefaultInternetRoute\(\)

```csharp
public void ClearPingDefaultInternetRoute()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_ClearPingMs"></a> ClearPingMs\(\)

```csharp
public void ClearPingMs()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_ClearSdrpopLocal"></a> ClearSdrpopLocal\(\)

```csharp
public void ClearSdrpopLocal()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_ClearSdrpopRemote"></a> ClearSdrpopRemote\(\)

```csharp
public void ClearSdrpopRemote()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_ClearTransportKind"></a> ClearTransportKind\(\)

```csharp
public void ClearTransportKind()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_Clone"></a> Clone\(\)

```csharp
public CGameNetworkingUI_ConnectionSummary Clone()
```

#### Returns

 [CGameNetworkingUI\_ConnectionSummary](Divine.Protobufs.Steam.CGameNetworkingUI\_ConnectionSummary.md)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_Equals_Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_"></a> Equals\(CGameNetworkingUI\_ConnectionSummary\)

```csharp
public bool Equals(CGameNetworkingUI_ConnectionSummary other)
```

#### Parameters

`other` [CGameNetworkingUI\_ConnectionSummary](Divine.Protobufs.Steam.CGameNetworkingUI\_ConnectionSummary.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_MergeFrom_Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_"></a> MergeFrom\(CGameNetworkingUI\_ConnectionSummary\)

```csharp
public void MergeFrom(CGameNetworkingUI_ConnectionSummary other)
```

#### Parameters

`other` [CGameNetworkingUI\_ConnectionSummary](Divine.Protobufs.Steam.CGameNetworkingUI\_ConnectionSummary.md)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionSummary_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

