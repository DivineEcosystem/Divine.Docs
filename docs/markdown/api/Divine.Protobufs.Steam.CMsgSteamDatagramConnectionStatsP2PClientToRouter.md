# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter"></a> Class CMsgSteamDatagramConnectionStatsP2PClientToRouter

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramConnectionStatsP2PClientToRouter : IMessage<CMsgSteamDatagramConnectionStatsP2PClientToRouter>, IEquatable<CMsgSteamDatagramConnectionStatsP2PClientToRouter>, IDeepCloneable<CMsgSteamDatagramConnectionStatsP2PClientToRouter>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramConnectionStatsP2PClientToRouter](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsP2PClientToRouter.md)

#### Implements

IMessage<CMsgSteamDatagramConnectionStatsP2PClientToRouter\>, 
[IEquatable<CMsgSteamDatagramConnectionStatsP2PClientToRouter\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramConnectionStatsP2PClientToRouter\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramConnectionStatsP2PClientToRouter\>\(CMsgSteamDatagramConnectionStatsP2PClientToRouter, params CMsgSteamDatagramConnectionStatsP2PClientToRouter\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter__ctor"></a> CMsgSteamDatagramConnectionStatsP2PClientToRouter\(\)

```csharp
public CMsgSteamDatagramConnectionStatsP2PClientToRouter()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_"></a> CMsgSteamDatagramConnectionStatsP2PClientToRouter\(CMsgSteamDatagramConnectionStatsP2PClientToRouter\)

```csharp
public CMsgSteamDatagramConnectionStatsP2PClientToRouter(CMsgSteamDatagramConnectionStatsP2PClientToRouter other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionStatsP2PClientToRouter](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsP2PClientToRouter.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_AckPeerRoutesRevisionFieldNumber"></a> AckPeerRoutesRevisionFieldNumber

```csharp
public const int AckPeerRoutesRevisionFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_AckRelayFieldNumber"></a> AckRelayFieldNumber

```csharp
public const int AckRelayFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_ConnectionIdFieldNumber"></a> ConnectionIdFieldNumber

```csharp
public const int ConnectionIdFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_ForwardTargetRelayRoutingTokenFieldNumber"></a> ForwardTargetRelayRoutingTokenFieldNumber

```csharp
public const int ForwardTargetRelayRoutingTokenFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_ForwardTargetRevisionFieldNumber"></a> ForwardTargetRevisionFieldNumber

```csharp
public const int ForwardTargetRevisionFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_LegacyAckE2EFieldNumber"></a> LegacyAckE2EFieldNumber

```csharp
public const int LegacyAckE2EFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_P2PRoutingSummaryFieldNumber"></a> P2PRoutingSummaryFieldNumber

```csharp
public const int P2PRoutingSummaryFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_QualityE2EFieldNumber"></a> QualityE2EFieldNumber

```csharp
public const int QualityE2EFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_QualityRelayFieldNumber"></a> QualityRelayFieldNumber

```csharp
public const int QualityRelayFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_RoutesFieldNumber"></a> RoutesFieldNumber

```csharp
public const int RoutesFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_SeqNumC2RFieldNumber"></a> SeqNumC2RFieldNumber

```csharp
public const int SeqNumC2RFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_SeqNumE2EFieldNumber"></a> SeqNumE2EFieldNumber

```csharp
public const int SeqNumE2EFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_AckPeerRoutesRevision"></a> AckPeerRoutesRevision

```csharp
public uint AckPeerRoutesRevision { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_AckRelay"></a> AckRelay

```csharp
public RepeatedField<uint> AckRelay { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_ConnectionId"></a> ConnectionId

```csharp
public uint ConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_ForwardTargetRelayRoutingToken"></a> ForwardTargetRelayRoutingToken

```csharp
public ByteString ForwardTargetRelayRoutingToken { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_ForwardTargetRevision"></a> ForwardTargetRevision

```csharp
public uint ForwardTargetRevision { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_HasAckPeerRoutesRevision"></a> HasAckPeerRoutesRevision

```csharp
public bool HasAckPeerRoutesRevision { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_HasConnectionId"></a> HasConnectionId

```csharp
public bool HasConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_HasForwardTargetRelayRoutingToken"></a> HasForwardTargetRelayRoutingToken

```csharp
public bool HasForwardTargetRelayRoutingToken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_HasForwardTargetRevision"></a> HasForwardTargetRevision

```csharp
public bool HasForwardTargetRevision { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_HasRoutes"></a> HasRoutes

```csharp
public bool HasRoutes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_HasSeqNumC2R"></a> HasSeqNumC2R

```csharp
public bool HasSeqNumC2R { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_HasSeqNumE2E"></a> HasSeqNumE2E

```csharp
public bool HasSeqNumE2E { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_LegacyAckE2E"></a> LegacyAckE2E

```csharp
public RepeatedField<uint> LegacyAckE2E { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_P2PRoutingSummary"></a> P2PRoutingSummary

```csharp
public CMsgSteamDatagramP2PRoutingSummary P2PRoutingSummary { get; set; }
```

#### Property Value

 [CMsgSteamDatagramP2PRoutingSummary](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutingSummary.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramConnectionStatsP2PClientToRouter> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramConnectionStatsP2PClientToRouter](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsP2PClientToRouter.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_QualityE2E"></a> QualityE2E

```csharp
public CMsgSteamDatagramConnectionQuality QualityE2E { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_QualityRelay"></a> QualityRelay

```csharp
public CMsgSteamDatagramConnectionQuality QualityRelay { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_Routes"></a> Routes

```csharp
public ByteString Routes { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_SeqNumC2R"></a> SeqNumC2R

```csharp
public uint SeqNumC2R { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_SeqNumE2E"></a> SeqNumE2E

```csharp
public uint SeqNumE2E { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_ClearAckPeerRoutesRevision"></a> ClearAckPeerRoutesRevision\(\)

```csharp
public void ClearAckPeerRoutesRevision()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_ClearConnectionId"></a> ClearConnectionId\(\)

```csharp
public void ClearConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_ClearForwardTargetRelayRoutingToken"></a> ClearForwardTargetRelayRoutingToken\(\)

```csharp
public void ClearForwardTargetRelayRoutingToken()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_ClearForwardTargetRevision"></a> ClearForwardTargetRevision\(\)

```csharp
public void ClearForwardTargetRevision()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_ClearRoutes"></a> ClearRoutes\(\)

```csharp
public void ClearRoutes()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_ClearSeqNumC2R"></a> ClearSeqNumC2R\(\)

```csharp
public void ClearSeqNumC2R()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_ClearSeqNumE2E"></a> ClearSeqNumE2E\(\)

```csharp
public void ClearSeqNumE2E()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramConnectionStatsP2PClientToRouter Clone()
```

#### Returns

 [CMsgSteamDatagramConnectionStatsP2PClientToRouter](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsP2PClientToRouter.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_"></a> Equals\(CMsgSteamDatagramConnectionStatsP2PClientToRouter\)

```csharp
public bool Equals(CMsgSteamDatagramConnectionStatsP2PClientToRouter other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionStatsP2PClientToRouter](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsP2PClientToRouter.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_"></a> MergeFrom\(CMsgSteamDatagramConnectionStatsP2PClientToRouter\)

```csharp
public void MergeFrom(CMsgSteamDatagramConnectionStatsP2PClientToRouter other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionStatsP2PClientToRouter](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsP2PClientToRouter.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PClientToRouter_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

