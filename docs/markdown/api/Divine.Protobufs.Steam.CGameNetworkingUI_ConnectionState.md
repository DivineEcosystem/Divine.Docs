# <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState"></a> Class CGameNetworkingUI\_ConnectionState

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGameNetworkingUI_ConnectionState : IMessage<CGameNetworkingUI_ConnectionState>, IEquatable<CGameNetworkingUI_ConnectionState>, IDeepCloneable<CGameNetworkingUI_ConnectionState>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGameNetworkingUI\_ConnectionState](Divine.Protobufs.Steam.CGameNetworkingUI\_ConnectionState.md)

#### Implements

IMessage<CGameNetworkingUI\_ConnectionState\>, 
[IEquatable<CGameNetworkingUI\_ConnectionState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGameNetworkingUI\_ConnectionState\>, 
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
[EnumerableExtensions.In<CGameNetworkingUI\_ConnectionState\>\(CGameNetworkingUI\_ConnectionState, params CGameNetworkingUI\_ConnectionState\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState__ctor"></a> CGameNetworkingUI\_ConnectionState\(\)

```csharp
public CGameNetworkingUI_ConnectionState()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState__ctor_Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_"></a> CGameNetworkingUI\_ConnectionState\(CGameNetworkingUI\_ConnectionState\)

```csharp
public CGameNetworkingUI_ConnectionState(CGameNetworkingUI_ConnectionState other)
```

#### Parameters

`other` [CGameNetworkingUI\_ConnectionState](Divine.Protobufs.Steam.CGameNetworkingUI\_ConnectionState.md)

## Fields

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_AddressRemoteFieldNumber"></a> AddressRemoteFieldNumber

```csharp
public const int AddressRemoteFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_CloseMessageFieldNumber"></a> CloseMessageFieldNumber

```csharp
public const int CloseMessageFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_CloseReasonFieldNumber"></a> CloseReasonFieldNumber

```csharp
public const int CloseReasonFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_CloseTimeFieldNumber"></a> CloseTimeFieldNumber

```csharp
public const int CloseTimeFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ConnectionIdLocalFieldNumber"></a> ConnectionIdLocalFieldNumber

```csharp
public const int ConnectionIdLocalFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ConnectionKeyFieldNumber"></a> ConnectionKeyFieldNumber

```csharp
public const int ConnectionKeyFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ConnectionStateFieldNumber"></a> ConnectionStateFieldNumber

```csharp
public const int ConnectionStateFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_E2EQualityLocalFieldNumber"></a> E2EQualityLocalFieldNumber

```csharp
public const int E2EQualityLocalFieldNumber = 30
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_E2EQualityRemoteFieldNumber"></a> E2EQualityRemoteFieldNumber

```csharp
public const int E2EQualityRemoteFieldNumber = 31
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_E2EQualityRemoteInstantaneousTimeFieldNumber"></a> E2EQualityRemoteInstantaneousTimeFieldNumber

```csharp
public const int E2EQualityRemoteInstantaneousTimeFieldNumber = 32
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_E2EQualityRemoteLifetimeTimeFieldNumber"></a> E2EQualityRemoteLifetimeTimeFieldNumber

```csharp
public const int E2EQualityRemoteLifetimeTimeFieldNumber = 33
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_FrontQualityLocalFieldNumber"></a> FrontQualityLocalFieldNumber

```csharp
public const int FrontQualityLocalFieldNumber = 40
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_FrontQualityRemoteFieldNumber"></a> FrontQualityRemoteFieldNumber

```csharp
public const int FrontQualityRemoteFieldNumber = 41
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_FrontQualityRemoteInstantaneousTimeFieldNumber"></a> FrontQualityRemoteInstantaneousTimeFieldNumber

```csharp
public const int FrontQualityRemoteInstantaneousTimeFieldNumber = 42
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_FrontQualityRemoteLifetimeTimeFieldNumber"></a> FrontQualityRemoteLifetimeTimeFieldNumber

```csharp
public const int FrontQualityRemoteLifetimeTimeFieldNumber = 43
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_IdentityLocalFieldNumber"></a> IdentityLocalFieldNumber

```csharp
public const int IdentityLocalFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_IdentityRemoteFieldNumber"></a> IdentityRemoteFieldNumber

```csharp
public const int IdentityRemoteFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_P2PRoutingFieldNumber"></a> P2PRoutingFieldNumber

```csharp
public const int P2PRoutingFieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_PingDefaultInternetRouteFieldNumber"></a> PingDefaultInternetRouteFieldNumber

```csharp
public const int PingDefaultInternetRouteFieldNumber = 27
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_PingInteriorFieldNumber"></a> PingInteriorFieldNumber

```csharp
public const int PingInteriorFieldNumber = 25
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_PingRemoteFrontFieldNumber"></a> PingRemoteFrontFieldNumber

```csharp
public const int PingRemoteFrontFieldNumber = 26
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_SdrpopidLocalFieldNumber"></a> SdrpopidLocalFieldNumber

```csharp
public const int SdrpopidLocalFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_SdrpopidRemoteFieldNumber"></a> SdrpopidRemoteFieldNumber

```csharp
public const int SdrpopidRemoteFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_StartTimeFieldNumber"></a> StartTimeFieldNumber

```csharp
public const int StartTimeFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_StatusLocTokenFieldNumber"></a> StatusLocTokenFieldNumber

```csharp
public const int StatusLocTokenFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_TransportKindFieldNumber"></a> TransportKindFieldNumber

```csharp
public const int TransportKindFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_AddressRemote"></a> AddressRemote

```csharp
public string AddressRemote { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_CloseMessage"></a> CloseMessage

```csharp
public string CloseMessage { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_CloseReason"></a> CloseReason

```csharp
public uint CloseReason { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_CloseTime"></a> CloseTime

```csharp
public uint CloseTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ConnectionIdLocal"></a> ConnectionIdLocal

```csharp
public uint ConnectionIdLocal { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ConnectionKey"></a> ConnectionKey

```csharp
public string ConnectionKey { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ConnectionState"></a> ConnectionState

```csharp
public uint ConnectionState { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_E2EQualityLocal"></a> E2EQualityLocal

```csharp
public CMsgSteamDatagramConnectionQuality E2EQualityLocal { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_E2EQualityRemote"></a> E2EQualityRemote

```csharp
public CMsgSteamDatagramConnectionQuality E2EQualityRemote { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_E2EQualityRemoteInstantaneousTime"></a> E2EQualityRemoteInstantaneousTime

```csharp
public ulong E2EQualityRemoteInstantaneousTime { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_E2EQualityRemoteLifetimeTime"></a> E2EQualityRemoteLifetimeTime

```csharp
public ulong E2EQualityRemoteLifetimeTime { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_FrontQualityLocal"></a> FrontQualityLocal

```csharp
public CMsgSteamDatagramConnectionQuality FrontQualityLocal { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_FrontQualityRemote"></a> FrontQualityRemote

```csharp
public CMsgSteamDatagramConnectionQuality FrontQualityRemote { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_FrontQualityRemoteInstantaneousTime"></a> FrontQualityRemoteInstantaneousTime

```csharp
public ulong FrontQualityRemoteInstantaneousTime { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_FrontQualityRemoteLifetimeTime"></a> FrontQualityRemoteLifetimeTime

```csharp
public ulong FrontQualityRemoteLifetimeTime { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasAddressRemote"></a> HasAddressRemote

```csharp
public bool HasAddressRemote { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasCloseMessage"></a> HasCloseMessage

```csharp
public bool HasCloseMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasCloseReason"></a> HasCloseReason

```csharp
public bool HasCloseReason { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasCloseTime"></a> HasCloseTime

```csharp
public bool HasCloseTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasConnectionIdLocal"></a> HasConnectionIdLocal

```csharp
public bool HasConnectionIdLocal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasConnectionKey"></a> HasConnectionKey

```csharp
public bool HasConnectionKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasConnectionState"></a> HasConnectionState

```csharp
public bool HasConnectionState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasE2EQualityRemoteInstantaneousTime"></a> HasE2EQualityRemoteInstantaneousTime

```csharp
public bool HasE2EQualityRemoteInstantaneousTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasE2EQualityRemoteLifetimeTime"></a> HasE2EQualityRemoteLifetimeTime

```csharp
public bool HasE2EQualityRemoteLifetimeTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasFrontQualityRemoteInstantaneousTime"></a> HasFrontQualityRemoteInstantaneousTime

```csharp
public bool HasFrontQualityRemoteInstantaneousTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasFrontQualityRemoteLifetimeTime"></a> HasFrontQualityRemoteLifetimeTime

```csharp
public bool HasFrontQualityRemoteLifetimeTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasIdentityLocal"></a> HasIdentityLocal

```csharp
public bool HasIdentityLocal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasIdentityRemote"></a> HasIdentityRemote

```csharp
public bool HasIdentityRemote { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasPingDefaultInternetRoute"></a> HasPingDefaultInternetRoute

```csharp
public bool HasPingDefaultInternetRoute { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasPingInterior"></a> HasPingInterior

```csharp
public bool HasPingInterior { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasPingRemoteFront"></a> HasPingRemoteFront

```csharp
public bool HasPingRemoteFront { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasSdrpopidLocal"></a> HasSdrpopidLocal

```csharp
public bool HasSdrpopidLocal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasSdrpopidRemote"></a> HasSdrpopidRemote

```csharp
public bool HasSdrpopidRemote { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasStartTime"></a> HasStartTime

```csharp
public bool HasStartTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasStatusLocToken"></a> HasStatusLocToken

```csharp
public bool HasStatusLocToken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_HasTransportKind"></a> HasTransportKind

```csharp
public bool HasTransportKind { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_IdentityLocal"></a> IdentityLocal

```csharp
public string IdentityLocal { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_IdentityRemote"></a> IdentityRemote

```csharp
public string IdentityRemote { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_P2PRouting"></a> P2PRouting

```csharp
public CMsgSteamDatagramP2PRoutingSummary P2PRouting { get; set; }
```

#### Property Value

 [CMsgSteamDatagramP2PRoutingSummary](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutingSummary.md)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_Parser"></a> Parser

```csharp
public static MessageParser<CGameNetworkingUI_ConnectionState> Parser { get; }
```

#### Property Value

 MessageParser<[CGameNetworkingUI\_ConnectionState](Divine.Protobufs.Steam.CGameNetworkingUI\_ConnectionState.md)\>

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_PingDefaultInternetRoute"></a> PingDefaultInternetRoute

```csharp
public uint PingDefaultInternetRoute { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_PingInterior"></a> PingInterior

```csharp
public uint PingInterior { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_PingRemoteFront"></a> PingRemoteFront

```csharp
public uint PingRemoteFront { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_SdrpopidLocal"></a> SdrpopidLocal

```csharp
public string SdrpopidLocal { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_SdrpopidRemote"></a> SdrpopidRemote

```csharp
public string SdrpopidRemote { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_StartTime"></a> StartTime

```csharp
public uint StartTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_StatusLocToken"></a> StatusLocToken

```csharp
public string StatusLocToken { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_TransportKind"></a> TransportKind

```csharp
public uint TransportKind { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearAddressRemote"></a> ClearAddressRemote\(\)

```csharp
public void ClearAddressRemote()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearCloseMessage"></a> ClearCloseMessage\(\)

```csharp
public void ClearCloseMessage()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearCloseReason"></a> ClearCloseReason\(\)

```csharp
public void ClearCloseReason()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearCloseTime"></a> ClearCloseTime\(\)

```csharp
public void ClearCloseTime()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearConnectionIdLocal"></a> ClearConnectionIdLocal\(\)

```csharp
public void ClearConnectionIdLocal()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearConnectionKey"></a> ClearConnectionKey\(\)

```csharp
public void ClearConnectionKey()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearConnectionState"></a> ClearConnectionState\(\)

```csharp
public void ClearConnectionState()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearE2EQualityRemoteInstantaneousTime"></a> ClearE2EQualityRemoteInstantaneousTime\(\)

```csharp
public void ClearE2EQualityRemoteInstantaneousTime()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearE2EQualityRemoteLifetimeTime"></a> ClearE2EQualityRemoteLifetimeTime\(\)

```csharp
public void ClearE2EQualityRemoteLifetimeTime()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearFrontQualityRemoteInstantaneousTime"></a> ClearFrontQualityRemoteInstantaneousTime\(\)

```csharp
public void ClearFrontQualityRemoteInstantaneousTime()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearFrontQualityRemoteLifetimeTime"></a> ClearFrontQualityRemoteLifetimeTime\(\)

```csharp
public void ClearFrontQualityRemoteLifetimeTime()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearIdentityLocal"></a> ClearIdentityLocal\(\)

```csharp
public void ClearIdentityLocal()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearIdentityRemote"></a> ClearIdentityRemote\(\)

```csharp
public void ClearIdentityRemote()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearPingDefaultInternetRoute"></a> ClearPingDefaultInternetRoute\(\)

```csharp
public void ClearPingDefaultInternetRoute()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearPingInterior"></a> ClearPingInterior\(\)

```csharp
public void ClearPingInterior()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearPingRemoteFront"></a> ClearPingRemoteFront\(\)

```csharp
public void ClearPingRemoteFront()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearSdrpopidLocal"></a> ClearSdrpopidLocal\(\)

```csharp
public void ClearSdrpopidLocal()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearSdrpopidRemote"></a> ClearSdrpopidRemote\(\)

```csharp
public void ClearSdrpopidRemote()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearStartTime"></a> ClearStartTime\(\)

```csharp
public void ClearStartTime()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearStatusLocToken"></a> ClearStatusLocToken\(\)

```csharp
public void ClearStatusLocToken()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ClearTransportKind"></a> ClearTransportKind\(\)

```csharp
public void ClearTransportKind()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_Clone"></a> Clone\(\)

```csharp
public CGameNetworkingUI_ConnectionState Clone()
```

#### Returns

 [CGameNetworkingUI\_ConnectionState](Divine.Protobufs.Steam.CGameNetworkingUI\_ConnectionState.md)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_Equals_Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_"></a> Equals\(CGameNetworkingUI\_ConnectionState\)

```csharp
public bool Equals(CGameNetworkingUI_ConnectionState other)
```

#### Parameters

`other` [CGameNetworkingUI\_ConnectionState](Divine.Protobufs.Steam.CGameNetworkingUI\_ConnectionState.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_MergeFrom_Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_"></a> MergeFrom\(CGameNetworkingUI\_ConnectionState\)

```csharp
public void MergeFrom(CGameNetworkingUI_ConnectionState other)
```

#### Parameters

`other` [CGameNetworkingUI\_ConnectionState](Divine.Protobufs.Steam.CGameNetworkingUI\_ConnectionState.md)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_ConnectionState_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

