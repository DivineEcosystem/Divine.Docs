# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply"></a> Class CMsgSteamDatagramRouterPingReply

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramRouterPingReply : IMessage<CMsgSteamDatagramRouterPingReply>, IEquatable<CMsgSteamDatagramRouterPingReply>, IDeepCloneable<CMsgSteamDatagramRouterPingReply>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramRouterPingReply](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.md)

#### Implements

IMessage<CMsgSteamDatagramRouterPingReply\>, 
[IEquatable<CMsgSteamDatagramRouterPingReply\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramRouterPingReply\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramRouterPingReply\>\(CMsgSteamDatagramRouterPingReply, params CMsgSteamDatagramRouterPingReply\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply__ctor"></a> CMsgSteamDatagramRouterPingReply\(\)

```csharp
public CMsgSteamDatagramRouterPingReply()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_"></a> CMsgSteamDatagramRouterPingReply\(CMsgSteamDatagramRouterPingReply\)

```csharp
public CMsgSteamDatagramRouterPingReply(CMsgSteamDatagramRouterPingReply other)
```

#### Parameters

`other` [CMsgSteamDatagramRouterPingReply](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_AltAddressesFieldNumber"></a> AltAddressesFieldNumber

```csharp
public const int AltAddressesFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ChallengeFieldNumber"></a> ChallengeFieldNumber

```csharp
public const int ChallengeFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ClientCookieFieldNumber"></a> ClientCookieFieldNumber

```csharp
public const int ClientCookieFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ClientTimestampFieldNumber"></a> ClientTimestampFieldNumber

```csharp
public const int ClientTimestampFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_DummyPadFieldNumber"></a> DummyPadFieldNumber

```csharp
public const int DummyPadFieldNumber = 99
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_DummyVarintFieldNumber"></a> DummyVarintFieldNumber

```csharp
public const int DummyVarintFieldNumber = 100
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_EchoRequestReplyTosFieldNumber"></a> EchoRequestReplyTosFieldNumber

```csharp
public const int EchoRequestReplyTosFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_EchoSentTosFieldNumber"></a> EchoSentTosFieldNumber

```csharp
public const int EchoSentTosFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_LatencyDatacenterIdsFieldNumber"></a> LatencyDatacenterIdsFieldNumber

```csharp
public const int LatencyDatacenterIdsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_LatencyDatacenterIdsP2PFieldNumber"></a> LatencyDatacenterIdsP2PFieldNumber

```csharp
public const int LatencyDatacenterIdsP2PFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_LatencyPingMsFieldNumber"></a> LatencyPingMsFieldNumber

```csharp
public const int LatencyPingMsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_LatencyPingMsP2PFieldNumber"></a> LatencyPingMsP2PFieldNumber

```csharp
public const int LatencyPingMsP2PFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_RecvTosFieldNumber"></a> RecvTosFieldNumber

```csharp
public const int RecvTosFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_RouteExceptionsFieldNumber"></a> RouteExceptionsFieldNumber

```csharp
public const int RouteExceptionsFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ScoringPenaltyRelayClusterFieldNumber"></a> ScoringPenaltyRelayClusterFieldNumber

```csharp
public const int ScoringPenaltyRelayClusterFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_SecondsUntilShutdownFieldNumber"></a> SecondsUntilShutdownFieldNumber

```csharp
public const int SecondsUntilShutdownFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_SentTosFieldNumber"></a> SentTosFieldNumber

```csharp
public const int SentTosFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ServerTimeFieldNumber"></a> ServerTimeFieldNumber

```csharp
public const int ServerTimeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_YourPublicIpFieldNumber"></a> YourPublicIpFieldNumber

```csharp
public const int YourPublicIpFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_YourPublicPortFieldNumber"></a> YourPublicPortFieldNumber

```csharp
public const int YourPublicPortFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_AltAddresses"></a> AltAddresses

```csharp
public RepeatedField<CMsgSteamDatagramRouterPingReply.Types.AltAddress> AltAddresses { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamDatagramRouterPingReply](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.md).[AltAddress](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.AltAddress.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Challenge"></a> Challenge

```csharp
public ulong Challenge { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ClientCookie"></a> ClientCookie

```csharp
public uint ClientCookie { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ClientTimestamp"></a> ClientTimestamp

```csharp
public uint ClientTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_DummyPad"></a> DummyPad

```csharp
public ByteString DummyPad { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_DummyVarint"></a> DummyVarint

```csharp
public ulong DummyVarint { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_EchoRequestReplyTos"></a> EchoRequestReplyTos

```csharp
public uint EchoRequestReplyTos { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_EchoSentTos"></a> EchoSentTos

```csharp
public uint EchoSentTos { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_HasChallenge"></a> HasChallenge

```csharp
public bool HasChallenge { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_HasClientCookie"></a> HasClientCookie

```csharp
public bool HasClientCookie { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_HasClientTimestamp"></a> HasClientTimestamp

```csharp
public bool HasClientTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_HasDummyPad"></a> HasDummyPad

```csharp
public bool HasDummyPad { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_HasDummyVarint"></a> HasDummyVarint

```csharp
public bool HasDummyVarint { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_HasEchoRequestReplyTos"></a> HasEchoRequestReplyTos

```csharp
public bool HasEchoRequestReplyTos { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_HasEchoSentTos"></a> HasEchoSentTos

```csharp
public bool HasEchoSentTos { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_HasRecvTos"></a> HasRecvTos

```csharp
public bool HasRecvTos { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_HasScoringPenaltyRelayCluster"></a> HasScoringPenaltyRelayCluster

```csharp
public bool HasScoringPenaltyRelayCluster { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_HasSecondsUntilShutdown"></a> HasSecondsUntilShutdown

```csharp
public bool HasSecondsUntilShutdown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_HasSentTos"></a> HasSentTos

```csharp
public bool HasSentTos { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_HasServerTime"></a> HasServerTime

```csharp
public bool HasServerTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_HasYourPublicIp"></a> HasYourPublicIp

```csharp
public bool HasYourPublicIp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_HasYourPublicPort"></a> HasYourPublicPort

```csharp
public bool HasYourPublicPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_LatencyDatacenterIds"></a> LatencyDatacenterIds

```csharp
public RepeatedField<uint> LatencyDatacenterIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_LatencyDatacenterIdsP2P"></a> LatencyDatacenterIdsP2P

```csharp
public RepeatedField<uint> LatencyDatacenterIdsP2P { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_LatencyPingMs"></a> LatencyPingMs

```csharp
public RepeatedField<uint> LatencyPingMs { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_LatencyPingMsP2P"></a> LatencyPingMsP2P

```csharp
public RepeatedField<uint> LatencyPingMsP2P { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramRouterPingReply> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramRouterPingReply](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_RecvTos"></a> RecvTos

```csharp
public uint RecvTos { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_RouteExceptions"></a> RouteExceptions

```csharp
public RepeatedField<CMsgSteamDatagramRouterPingReply.Types.RouteException> RouteExceptions { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamDatagramRouterPingReply](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.md).[RouteException](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.Types.RouteException.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ScoringPenaltyRelayCluster"></a> ScoringPenaltyRelayCluster

```csharp
public uint ScoringPenaltyRelayCluster { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_SecondsUntilShutdown"></a> SecondsUntilShutdown

```csharp
public uint SecondsUntilShutdown { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_SentTos"></a> SentTos

```csharp
public uint SentTos { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ServerTime"></a> ServerTime

```csharp
public uint ServerTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_YourPublicIp"></a> YourPublicIp

```csharp
public uint YourPublicIp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_YourPublicPort"></a> YourPublicPort

```csharp
public uint YourPublicPort { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ClearChallenge"></a> ClearChallenge\(\)

```csharp
public void ClearChallenge()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ClearClientCookie"></a> ClearClientCookie\(\)

```csharp
public void ClearClientCookie()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ClearClientTimestamp"></a> ClearClientTimestamp\(\)

```csharp
public void ClearClientTimestamp()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ClearDummyPad"></a> ClearDummyPad\(\)

```csharp
public void ClearDummyPad()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ClearDummyVarint"></a> ClearDummyVarint\(\)

```csharp
public void ClearDummyVarint()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ClearEchoRequestReplyTos"></a> ClearEchoRequestReplyTos\(\)

```csharp
public void ClearEchoRequestReplyTos()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ClearEchoSentTos"></a> ClearEchoSentTos\(\)

```csharp
public void ClearEchoSentTos()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ClearRecvTos"></a> ClearRecvTos\(\)

```csharp
public void ClearRecvTos()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ClearScoringPenaltyRelayCluster"></a> ClearScoringPenaltyRelayCluster\(\)

```csharp
public void ClearScoringPenaltyRelayCluster()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ClearSecondsUntilShutdown"></a> ClearSecondsUntilShutdown\(\)

```csharp
public void ClearSecondsUntilShutdown()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ClearSentTos"></a> ClearSentTos\(\)

```csharp
public void ClearSentTos()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ClearServerTime"></a> ClearServerTime\(\)

```csharp
public void ClearServerTime()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ClearYourPublicIp"></a> ClearYourPublicIp\(\)

```csharp
public void ClearYourPublicIp()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ClearYourPublicPort"></a> ClearYourPublicPort\(\)

```csharp
public void ClearYourPublicPort()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramRouterPingReply Clone()
```

#### Returns

 [CMsgSteamDatagramRouterPingReply](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_"></a> Equals\(CMsgSteamDatagramRouterPingReply\)

```csharp
public bool Equals(CMsgSteamDatagramRouterPingReply other)
```

#### Parameters

`other` [CMsgSteamDatagramRouterPingReply](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_"></a> MergeFrom\(CMsgSteamDatagramRouterPingReply\)

```csharp
public void MergeFrom(CMsgSteamDatagramRouterPingReply other)
```

#### Parameters

`other` [CMsgSteamDatagramRouterPingReply](Divine.Protobufs.Steam.CMsgSteamDatagramRouterPingReply.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRouterPingReply_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

