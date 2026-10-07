# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter"></a> Class CMsgSteamDatagramConnectionStatsServerToRouter

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramConnectionStatsServerToRouter : IMessage<CMsgSteamDatagramConnectionStatsServerToRouter>, IEquatable<CMsgSteamDatagramConnectionStatsServerToRouter>, IDeepCloneable<CMsgSteamDatagramConnectionStatsServerToRouter>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramConnectionStatsServerToRouter](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsServerToRouter.md)

#### Implements

IMessage<CMsgSteamDatagramConnectionStatsServerToRouter\>, 
[IEquatable<CMsgSteamDatagramConnectionStatsServerToRouter\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramConnectionStatsServerToRouter\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramConnectionStatsServerToRouter\>\(CMsgSteamDatagramConnectionStatsServerToRouter, params CMsgSteamDatagramConnectionStatsServerToRouter\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter__ctor"></a> CMsgSteamDatagramConnectionStatsServerToRouter\(\)

```csharp
public CMsgSteamDatagramConnectionStatsServerToRouter()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_"></a> CMsgSteamDatagramConnectionStatsServerToRouter\(CMsgSteamDatagramConnectionStatsServerToRouter\)

```csharp
public CMsgSteamDatagramConnectionStatsServerToRouter(CMsgSteamDatagramConnectionStatsServerToRouter other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionStatsServerToRouter](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsServerToRouter.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_AckRelayFieldNumber"></a> AckRelayFieldNumber

```csharp
public const int AckRelayFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_ClientConnectionIdFieldNumber"></a> ClientConnectionIdFieldNumber

```csharp
public const int ClientConnectionIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_LegacyAckE2EFieldNumber"></a> LegacyAckE2EFieldNumber

```csharp
public const int LegacyAckE2EFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_QualityE2EFieldNumber"></a> QualityE2EFieldNumber

```csharp
public const int QualityE2EFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_QualityRelayFieldNumber"></a> QualityRelayFieldNumber

```csharp
public const int QualityRelayFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_RelaySessionIdFieldNumber"></a> RelaySessionIdFieldNumber

```csharp
public const int RelaySessionIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_SeqNumE2EFieldNumber"></a> SeqNumE2EFieldNumber

```csharp
public const int SeqNumE2EFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_SeqNumS2RFieldNumber"></a> SeqNumS2RFieldNumber

```csharp
public const int SeqNumS2RFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_ServerConnectionIdFieldNumber"></a> ServerConnectionIdFieldNumber

```csharp
public const int ServerConnectionIdFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_AckRelay"></a> AckRelay

```csharp
public RepeatedField<uint> AckRelay { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_ClientConnectionId"></a> ClientConnectionId

```csharp
public uint ClientConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_HasClientConnectionId"></a> HasClientConnectionId

```csharp
public bool HasClientConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_HasRelaySessionId"></a> HasRelaySessionId

```csharp
public bool HasRelaySessionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_HasSeqNumE2E"></a> HasSeqNumE2E

```csharp
public bool HasSeqNumE2E { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_HasSeqNumS2R"></a> HasSeqNumS2R

```csharp
public bool HasSeqNumS2R { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_HasServerConnectionId"></a> HasServerConnectionId

```csharp
public bool HasServerConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_LegacyAckE2E"></a> LegacyAckE2E

```csharp
public RepeatedField<uint> LegacyAckE2E { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramConnectionStatsServerToRouter> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramConnectionStatsServerToRouter](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsServerToRouter.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_QualityE2E"></a> QualityE2E

```csharp
public CMsgSteamDatagramConnectionQuality QualityE2E { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_QualityRelay"></a> QualityRelay

```csharp
public CMsgSteamDatagramConnectionQuality QualityRelay { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_RelaySessionId"></a> RelaySessionId

```csharp
public uint RelaySessionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_SeqNumE2E"></a> SeqNumE2E

```csharp
public uint SeqNumE2E { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_SeqNumS2R"></a> SeqNumS2R

```csharp
public uint SeqNumS2R { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_ServerConnectionId"></a> ServerConnectionId

```csharp
public uint ServerConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_ClearClientConnectionId"></a> ClearClientConnectionId\(\)

```csharp
public void ClearClientConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_ClearRelaySessionId"></a> ClearRelaySessionId\(\)

```csharp
public void ClearRelaySessionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_ClearSeqNumE2E"></a> ClearSeqNumE2E\(\)

```csharp
public void ClearSeqNumE2E()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_ClearSeqNumS2R"></a> ClearSeqNumS2R\(\)

```csharp
public void ClearSeqNumS2R()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_ClearServerConnectionId"></a> ClearServerConnectionId\(\)

```csharp
public void ClearServerConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramConnectionStatsServerToRouter Clone()
```

#### Returns

 [CMsgSteamDatagramConnectionStatsServerToRouter](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsServerToRouter.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_"></a> Equals\(CMsgSteamDatagramConnectionStatsServerToRouter\)

```csharp
public bool Equals(CMsgSteamDatagramConnectionStatsServerToRouter other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionStatsServerToRouter](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsServerToRouter.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_"></a> MergeFrom\(CMsgSteamDatagramConnectionStatsServerToRouter\)

```csharp
public void MergeFrom(CMsgSteamDatagramConnectionStatsServerToRouter other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionStatsServerToRouter](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsServerToRouter.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsServerToRouter_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

