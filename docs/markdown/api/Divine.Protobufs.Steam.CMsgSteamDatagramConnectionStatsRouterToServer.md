# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer"></a> Class CMsgSteamDatagramConnectionStatsRouterToServer

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramConnectionStatsRouterToServer : IMessage<CMsgSteamDatagramConnectionStatsRouterToServer>, IEquatable<CMsgSteamDatagramConnectionStatsRouterToServer>, IDeepCloneable<CMsgSteamDatagramConnectionStatsRouterToServer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramConnectionStatsRouterToServer](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsRouterToServer.md)

#### Implements

IMessage<CMsgSteamDatagramConnectionStatsRouterToServer\>, 
[IEquatable<CMsgSteamDatagramConnectionStatsRouterToServer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramConnectionStatsRouterToServer\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramConnectionStatsRouterToServer\>\(CMsgSteamDatagramConnectionStatsRouterToServer, params CMsgSteamDatagramConnectionStatsRouterToServer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer__ctor"></a> CMsgSteamDatagramConnectionStatsRouterToServer\(\)

```csharp
public CMsgSteamDatagramConnectionStatsRouterToServer()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_"></a> CMsgSteamDatagramConnectionStatsRouterToServer\(CMsgSteamDatagramConnectionStatsRouterToServer\)

```csharp
public CMsgSteamDatagramConnectionStatsRouterToServer(CMsgSteamDatagramConnectionStatsRouterToServer other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionStatsRouterToServer](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsRouterToServer.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_AckRelayFieldNumber"></a> AckRelayFieldNumber

```csharp
public const int AckRelayFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_ClientConnectionIdFieldNumber"></a> ClientConnectionIdFieldNumber

```csharp
public const int ClientConnectionIdFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_ClientIdentityStringFieldNumber"></a> ClientIdentityStringFieldNumber

```csharp
public const int ClientIdentityStringFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_LegacyAckE2EFieldNumber"></a> LegacyAckE2EFieldNumber

```csharp
public const int LegacyAckE2EFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_LegacyClientSteamIdFieldNumber"></a> LegacyClientSteamIdFieldNumber

```csharp
public const int LegacyClientSteamIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_QualityE2EFieldNumber"></a> QualityE2EFieldNumber

```csharp
public const int QualityE2EFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_QualityRelayFieldNumber"></a> QualityRelayFieldNumber

```csharp
public const int QualityRelayFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_RelaySessionIdFieldNumber"></a> RelaySessionIdFieldNumber

```csharp
public const int RelaySessionIdFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_RoutingSecretFieldNumber"></a> RoutingSecretFieldNumber

```csharp
public const int RoutingSecretFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_SeqNumE2EFieldNumber"></a> SeqNumE2EFieldNumber

```csharp
public const int SeqNumE2EFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_SeqNumR2SFieldNumber"></a> SeqNumR2SFieldNumber

```csharp
public const int SeqNumR2SFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_ServerConnectionIdFieldNumber"></a> ServerConnectionIdFieldNumber

```csharp
public const int ServerConnectionIdFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_AckRelay"></a> AckRelay

```csharp
public RepeatedField<uint> AckRelay { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_ClientConnectionId"></a> ClientConnectionId

```csharp
public uint ClientConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_ClientIdentityString"></a> ClientIdentityString

```csharp
public string ClientIdentityString { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_HasClientConnectionId"></a> HasClientConnectionId

```csharp
public bool HasClientConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_HasClientIdentityString"></a> HasClientIdentityString

```csharp
public bool HasClientIdentityString { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_HasLegacyClientSteamId"></a> HasLegacyClientSteamId

```csharp
public bool HasLegacyClientSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_HasRelaySessionId"></a> HasRelaySessionId

```csharp
public bool HasRelaySessionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_HasRoutingSecret"></a> HasRoutingSecret

```csharp
public bool HasRoutingSecret { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_HasSeqNumE2E"></a> HasSeqNumE2E

```csharp
public bool HasSeqNumE2E { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_HasSeqNumR2S"></a> HasSeqNumR2S

```csharp
public bool HasSeqNumR2S { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_HasServerConnectionId"></a> HasServerConnectionId

```csharp
public bool HasServerConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_LegacyAckE2E"></a> LegacyAckE2E

```csharp
public RepeatedField<uint> LegacyAckE2E { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_LegacyClientSteamId"></a> LegacyClientSteamId

```csharp
public ulong LegacyClientSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramConnectionStatsRouterToServer> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramConnectionStatsRouterToServer](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsRouterToServer.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_QualityE2E"></a> QualityE2E

```csharp
public CMsgSteamDatagramConnectionQuality QualityE2E { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_QualityRelay"></a> QualityRelay

```csharp
public CMsgSteamDatagramConnectionQuality QualityRelay { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_RelaySessionId"></a> RelaySessionId

```csharp
public uint RelaySessionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_RoutingSecret"></a> RoutingSecret

```csharp
public ulong RoutingSecret { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_SeqNumE2E"></a> SeqNumE2E

```csharp
public uint SeqNumE2E { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_SeqNumR2S"></a> SeqNumR2S

```csharp
public uint SeqNumR2S { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_ServerConnectionId"></a> ServerConnectionId

```csharp
public uint ServerConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_ClearClientConnectionId"></a> ClearClientConnectionId\(\)

```csharp
public void ClearClientConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_ClearClientIdentityString"></a> ClearClientIdentityString\(\)

```csharp
public void ClearClientIdentityString()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_ClearLegacyClientSteamId"></a> ClearLegacyClientSteamId\(\)

```csharp
public void ClearLegacyClientSteamId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_ClearRelaySessionId"></a> ClearRelaySessionId\(\)

```csharp
public void ClearRelaySessionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_ClearRoutingSecret"></a> ClearRoutingSecret\(\)

```csharp
public void ClearRoutingSecret()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_ClearSeqNumE2E"></a> ClearSeqNumE2E\(\)

```csharp
public void ClearSeqNumE2E()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_ClearSeqNumR2S"></a> ClearSeqNumR2S\(\)

```csharp
public void ClearSeqNumR2S()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_ClearServerConnectionId"></a> ClearServerConnectionId\(\)

```csharp
public void ClearServerConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramConnectionStatsRouterToServer Clone()
```

#### Returns

 [CMsgSteamDatagramConnectionStatsRouterToServer](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsRouterToServer.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_"></a> Equals\(CMsgSteamDatagramConnectionStatsRouterToServer\)

```csharp
public bool Equals(CMsgSteamDatagramConnectionStatsRouterToServer other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionStatsRouterToServer](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsRouterToServer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_"></a> MergeFrom\(CMsgSteamDatagramConnectionStatsRouterToServer\)

```csharp
public void MergeFrom(CMsgSteamDatagramConnectionStatsRouterToServer other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionStatsRouterToServer](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsRouterToServer.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsRouterToServer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

