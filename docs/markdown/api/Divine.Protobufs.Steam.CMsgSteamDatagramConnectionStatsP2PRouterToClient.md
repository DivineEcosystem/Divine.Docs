# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient"></a> Class CMsgSteamDatagramConnectionStatsP2PRouterToClient

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramConnectionStatsP2PRouterToClient : IMessage<CMsgSteamDatagramConnectionStatsP2PRouterToClient>, IEquatable<CMsgSteamDatagramConnectionStatsP2PRouterToClient>, IDeepCloneable<CMsgSteamDatagramConnectionStatsP2PRouterToClient>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramConnectionStatsP2PRouterToClient](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsP2PRouterToClient.md)

#### Implements

IMessage<CMsgSteamDatagramConnectionStatsP2PRouterToClient\>, 
[IEquatable<CMsgSteamDatagramConnectionStatsP2PRouterToClient\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramConnectionStatsP2PRouterToClient\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramConnectionStatsP2PRouterToClient\>\(CMsgSteamDatagramConnectionStatsP2PRouterToClient, params CMsgSteamDatagramConnectionStatsP2PRouterToClient\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient__ctor"></a> CMsgSteamDatagramConnectionStatsP2PRouterToClient\(\)

```csharp
public CMsgSteamDatagramConnectionStatsP2PRouterToClient()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_"></a> CMsgSteamDatagramConnectionStatsP2PRouterToClient\(CMsgSteamDatagramConnectionStatsP2PRouterToClient\)

```csharp
public CMsgSteamDatagramConnectionStatsP2PRouterToClient(CMsgSteamDatagramConnectionStatsP2PRouterToClient other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionStatsP2PRouterToClient](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsP2PRouterToClient.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_AckForwardTargetRevisionFieldNumber"></a> AckForwardTargetRevisionFieldNumber

```csharp
public const int AckForwardTargetRevisionFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_AckPeerRoutesRevisionFieldNumber"></a> AckPeerRoutesRevisionFieldNumber

```csharp
public const int AckPeerRoutesRevisionFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_AckRelayFieldNumber"></a> AckRelayFieldNumber

```csharp
public const int AckRelayFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_ConnectionIdFieldNumber"></a> ConnectionIdFieldNumber

```csharp
public const int ConnectionIdFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_LegacyAckE2EFieldNumber"></a> LegacyAckE2EFieldNumber

```csharp
public const int LegacyAckE2EFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_MigrateRequestIpFieldNumber"></a> MigrateRequestIpFieldNumber

```csharp
public const int MigrateRequestIpFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_MigrateRequestPortFieldNumber"></a> MigrateRequestPortFieldNumber

```csharp
public const int MigrateRequestPortFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_QualityE2EFieldNumber"></a> QualityE2EFieldNumber

```csharp
public const int QualityE2EFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_QualityRelayFieldNumber"></a> QualityRelayFieldNumber

```csharp
public const int QualityRelayFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_RoutesFieldNumber"></a> RoutesFieldNumber

```csharp
public const int RoutesFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_ScoringPenaltyRelayClusterFieldNumber"></a> ScoringPenaltyRelayClusterFieldNumber

```csharp
public const int ScoringPenaltyRelayClusterFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_SecondsUntilShutdownFieldNumber"></a> SecondsUntilShutdownFieldNumber

```csharp
public const int SecondsUntilShutdownFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_SeqNumE2EFieldNumber"></a> SeqNumE2EFieldNumber

```csharp
public const int SeqNumE2EFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_SeqNumR2CFieldNumber"></a> SeqNumR2CFieldNumber

```csharp
public const int SeqNumR2CFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_AckForwardTargetRevision"></a> AckForwardTargetRevision

```csharp
public uint AckForwardTargetRevision { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_AckPeerRoutesRevision"></a> AckPeerRoutesRevision

```csharp
public uint AckPeerRoutesRevision { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_AckRelay"></a> AckRelay

```csharp
public RepeatedField<uint> AckRelay { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_ConnectionId"></a> ConnectionId

```csharp
public uint ConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_HasAckForwardTargetRevision"></a> HasAckForwardTargetRevision

```csharp
public bool HasAckForwardTargetRevision { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_HasAckPeerRoutesRevision"></a> HasAckPeerRoutesRevision

```csharp
public bool HasAckPeerRoutesRevision { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_HasConnectionId"></a> HasConnectionId

```csharp
public bool HasConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_HasMigrateRequestIp"></a> HasMigrateRequestIp

```csharp
public bool HasMigrateRequestIp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_HasMigrateRequestPort"></a> HasMigrateRequestPort

```csharp
public bool HasMigrateRequestPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_HasRoutes"></a> HasRoutes

```csharp
public bool HasRoutes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_HasScoringPenaltyRelayCluster"></a> HasScoringPenaltyRelayCluster

```csharp
public bool HasScoringPenaltyRelayCluster { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_HasSecondsUntilShutdown"></a> HasSecondsUntilShutdown

```csharp
public bool HasSecondsUntilShutdown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_HasSeqNumE2E"></a> HasSeqNumE2E

```csharp
public bool HasSeqNumE2E { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_HasSeqNumR2C"></a> HasSeqNumR2C

```csharp
public bool HasSeqNumR2C { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_LegacyAckE2E"></a> LegacyAckE2E

```csharp
public RepeatedField<uint> LegacyAckE2E { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_MigrateRequestIp"></a> MigrateRequestIp

```csharp
public uint MigrateRequestIp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_MigrateRequestPort"></a> MigrateRequestPort

```csharp
public uint MigrateRequestPort { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramConnectionStatsP2PRouterToClient> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramConnectionStatsP2PRouterToClient](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsP2PRouterToClient.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_QualityE2E"></a> QualityE2E

```csharp
public CMsgSteamDatagramConnectionQuality QualityE2E { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_QualityRelay"></a> QualityRelay

```csharp
public CMsgSteamDatagramConnectionQuality QualityRelay { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_Routes"></a> Routes

```csharp
public ByteString Routes { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_ScoringPenaltyRelayCluster"></a> ScoringPenaltyRelayCluster

```csharp
public uint ScoringPenaltyRelayCluster { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_SecondsUntilShutdown"></a> SecondsUntilShutdown

```csharp
public uint SecondsUntilShutdown { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_SeqNumE2E"></a> SeqNumE2E

```csharp
public uint SeqNumE2E { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_SeqNumR2C"></a> SeqNumR2C

```csharp
public uint SeqNumR2C { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_ClearAckForwardTargetRevision"></a> ClearAckForwardTargetRevision\(\)

```csharp
public void ClearAckForwardTargetRevision()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_ClearAckPeerRoutesRevision"></a> ClearAckPeerRoutesRevision\(\)

```csharp
public void ClearAckPeerRoutesRevision()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_ClearConnectionId"></a> ClearConnectionId\(\)

```csharp
public void ClearConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_ClearMigrateRequestIp"></a> ClearMigrateRequestIp\(\)

```csharp
public void ClearMigrateRequestIp()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_ClearMigrateRequestPort"></a> ClearMigrateRequestPort\(\)

```csharp
public void ClearMigrateRequestPort()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_ClearRoutes"></a> ClearRoutes\(\)

```csharp
public void ClearRoutes()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_ClearScoringPenaltyRelayCluster"></a> ClearScoringPenaltyRelayCluster\(\)

```csharp
public void ClearScoringPenaltyRelayCluster()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_ClearSecondsUntilShutdown"></a> ClearSecondsUntilShutdown\(\)

```csharp
public void ClearSecondsUntilShutdown()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_ClearSeqNumE2E"></a> ClearSeqNumE2E\(\)

```csharp
public void ClearSeqNumE2E()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_ClearSeqNumR2C"></a> ClearSeqNumR2C\(\)

```csharp
public void ClearSeqNumR2C()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramConnectionStatsP2PRouterToClient Clone()
```

#### Returns

 [CMsgSteamDatagramConnectionStatsP2PRouterToClient](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsP2PRouterToClient.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_"></a> Equals\(CMsgSteamDatagramConnectionStatsP2PRouterToClient\)

```csharp
public bool Equals(CMsgSteamDatagramConnectionStatsP2PRouterToClient other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionStatsP2PRouterToClient](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsP2PRouterToClient.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_"></a> MergeFrom\(CMsgSteamDatagramConnectionStatsP2PRouterToClient\)

```csharp
public void MergeFrom(CMsgSteamDatagramConnectionStatsP2PRouterToClient other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionStatsP2PRouterToClient](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsP2PRouterToClient.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsP2PRouterToClient_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

