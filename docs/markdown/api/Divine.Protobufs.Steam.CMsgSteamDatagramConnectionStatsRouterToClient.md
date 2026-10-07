# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient"></a> Class CMsgSteamDatagramConnectionStatsRouterToClient

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramConnectionStatsRouterToClient : IMessage<CMsgSteamDatagramConnectionStatsRouterToClient>, IEquatable<CMsgSteamDatagramConnectionStatsRouterToClient>, IDeepCloneable<CMsgSteamDatagramConnectionStatsRouterToClient>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramConnectionStatsRouterToClient](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsRouterToClient.md)

#### Implements

IMessage<CMsgSteamDatagramConnectionStatsRouterToClient\>, 
[IEquatable<CMsgSteamDatagramConnectionStatsRouterToClient\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramConnectionStatsRouterToClient\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramConnectionStatsRouterToClient\>\(CMsgSteamDatagramConnectionStatsRouterToClient, params CMsgSteamDatagramConnectionStatsRouterToClient\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient__ctor"></a> CMsgSteamDatagramConnectionStatsRouterToClient\(\)

```csharp
public CMsgSteamDatagramConnectionStatsRouterToClient()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_"></a> CMsgSteamDatagramConnectionStatsRouterToClient\(CMsgSteamDatagramConnectionStatsRouterToClient\)

```csharp
public CMsgSteamDatagramConnectionStatsRouterToClient(CMsgSteamDatagramConnectionStatsRouterToClient other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionStatsRouterToClient](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsRouterToClient.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_AckRelayFieldNumber"></a> AckRelayFieldNumber

```csharp
public const int AckRelayFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_ClientConnectionIdFieldNumber"></a> ClientConnectionIdFieldNumber

```csharp
public const int ClientConnectionIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_LegacyAckE2EFieldNumber"></a> LegacyAckE2EFieldNumber

```csharp
public const int LegacyAckE2EFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_MigrateRequestIpFieldNumber"></a> MigrateRequestIpFieldNumber

```csharp
public const int MigrateRequestIpFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_MigrateRequestPortFieldNumber"></a> MigrateRequestPortFieldNumber

```csharp
public const int MigrateRequestPortFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_QualityE2EFieldNumber"></a> QualityE2EFieldNumber

```csharp
public const int QualityE2EFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_QualityRelayFieldNumber"></a> QualityRelayFieldNumber

```csharp
public const int QualityRelayFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_ScoringPenaltyRelayClusterFieldNumber"></a> ScoringPenaltyRelayClusterFieldNumber

```csharp
public const int ScoringPenaltyRelayClusterFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_SecondsUntilShutdownFieldNumber"></a> SecondsUntilShutdownFieldNumber

```csharp
public const int SecondsUntilShutdownFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_SeqNumE2EFieldNumber"></a> SeqNumE2EFieldNumber

```csharp
public const int SeqNumE2EFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_SeqNumR2CFieldNumber"></a> SeqNumR2CFieldNumber

```csharp
public const int SeqNumR2CFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_AckRelay"></a> AckRelay

```csharp
public RepeatedField<uint> AckRelay { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_ClientConnectionId"></a> ClientConnectionId

```csharp
public uint ClientConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_HasClientConnectionId"></a> HasClientConnectionId

```csharp
public bool HasClientConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_HasMigrateRequestIp"></a> HasMigrateRequestIp

```csharp
public bool HasMigrateRequestIp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_HasMigrateRequestPort"></a> HasMigrateRequestPort

```csharp
public bool HasMigrateRequestPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_HasScoringPenaltyRelayCluster"></a> HasScoringPenaltyRelayCluster

```csharp
public bool HasScoringPenaltyRelayCluster { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_HasSecondsUntilShutdown"></a> HasSecondsUntilShutdown

```csharp
public bool HasSecondsUntilShutdown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_HasSeqNumE2E"></a> HasSeqNumE2E

```csharp
public bool HasSeqNumE2E { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_HasSeqNumR2C"></a> HasSeqNumR2C

```csharp
public bool HasSeqNumR2C { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_LegacyAckE2E"></a> LegacyAckE2E

```csharp
public RepeatedField<uint> LegacyAckE2E { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_MigrateRequestIp"></a> MigrateRequestIp

```csharp
public uint MigrateRequestIp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_MigrateRequestPort"></a> MigrateRequestPort

```csharp
public uint MigrateRequestPort { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramConnectionStatsRouterToClient> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramConnectionStatsRouterToClient](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsRouterToClient.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_QualityE2E"></a> QualityE2E

```csharp
public CMsgSteamDatagramConnectionQuality QualityE2E { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_QualityRelay"></a> QualityRelay

```csharp
public CMsgSteamDatagramConnectionQuality QualityRelay { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_ScoringPenaltyRelayCluster"></a> ScoringPenaltyRelayCluster

```csharp
public uint ScoringPenaltyRelayCluster { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_SecondsUntilShutdown"></a> SecondsUntilShutdown

```csharp
public uint SecondsUntilShutdown { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_SeqNumE2E"></a> SeqNumE2E

```csharp
public uint SeqNumE2E { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_SeqNumR2C"></a> SeqNumR2C

```csharp
public uint SeqNumR2C { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_ClearClientConnectionId"></a> ClearClientConnectionId\(\)

```csharp
public void ClearClientConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_ClearMigrateRequestIp"></a> ClearMigrateRequestIp\(\)

```csharp
public void ClearMigrateRequestIp()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_ClearMigrateRequestPort"></a> ClearMigrateRequestPort\(\)

```csharp
public void ClearMigrateRequestPort()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_ClearScoringPenaltyRelayCluster"></a> ClearScoringPenaltyRelayCluster\(\)

```csharp
public void ClearScoringPenaltyRelayCluster()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_ClearSecondsUntilShutdown"></a> ClearSecondsUntilShutdown\(\)

```csharp
public void ClearSecondsUntilShutdown()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_ClearSeqNumE2E"></a> ClearSeqNumE2E\(\)

```csharp
public void ClearSeqNumE2E()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_ClearSeqNumR2C"></a> ClearSeqNumR2C\(\)

```csharp
public void ClearSeqNumR2C()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramConnectionStatsRouterToClient Clone()
```

#### Returns

 [CMsgSteamDatagramConnectionStatsRouterToClient](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsRouterToClient.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_"></a> Equals\(CMsgSteamDatagramConnectionStatsRouterToClient\)

```csharp
public bool Equals(CMsgSteamDatagramConnectionStatsRouterToClient other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionStatsRouterToClient](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsRouterToClient.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_"></a> MergeFrom\(CMsgSteamDatagramConnectionStatsRouterToClient\)

```csharp
public void MergeFrom(CMsgSteamDatagramConnectionStatsRouterToClient other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionStatsRouterToClient](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsRouterToClient.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToClient_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

