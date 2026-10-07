# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter"></a> Class CMsgSteamDatagramConnectionStatsClientToRouter

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramConnectionStatsClientToRouter : IMessage<CMsgSteamDatagramConnectionStatsClientToRouter>, IEquatable<CMsgSteamDatagramConnectionStatsClientToRouter>, IDeepCloneable<CMsgSteamDatagramConnectionStatsClientToRouter>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramConnectionStatsClientToRouter](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsClientToRouter.md)

#### Implements

IMessage<CMsgSteamDatagramConnectionStatsClientToRouter\>, 
[IEquatable<CMsgSteamDatagramConnectionStatsClientToRouter\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramConnectionStatsClientToRouter\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramConnectionStatsClientToRouter\>\(CMsgSteamDatagramConnectionStatsClientToRouter, params CMsgSteamDatagramConnectionStatsClientToRouter\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter__ctor"></a> CMsgSteamDatagramConnectionStatsClientToRouter\(\)

```csharp
public CMsgSteamDatagramConnectionStatsClientToRouter()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_"></a> CMsgSteamDatagramConnectionStatsClientToRouter\(CMsgSteamDatagramConnectionStatsClientToRouter\)

```csharp
public CMsgSteamDatagramConnectionStatsClientToRouter(CMsgSteamDatagramConnectionStatsClientToRouter other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionStatsClientToRouter](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsClientToRouter.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_AckRelayFieldNumber"></a> AckRelayFieldNumber

```csharp
public const int AckRelayFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_ClientConnectionIdFieldNumber"></a> ClientConnectionIdFieldNumber

```csharp
public const int ClientConnectionIdFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_LegacyAckE2EFieldNumber"></a> LegacyAckE2EFieldNumber

```csharp
public const int LegacyAckE2EFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_QualityE2EFieldNumber"></a> QualityE2EFieldNumber

```csharp
public const int QualityE2EFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_QualityRelayFieldNumber"></a> QualityRelayFieldNumber

```csharp
public const int QualityRelayFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_SeqNumC2RFieldNumber"></a> SeqNumC2RFieldNumber

```csharp
public const int SeqNumC2RFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_SeqNumE2EFieldNumber"></a> SeqNumE2EFieldNumber

```csharp
public const int SeqNumE2EFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_AckRelay"></a> AckRelay

```csharp
public RepeatedField<uint> AckRelay { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_ClientConnectionId"></a> ClientConnectionId

```csharp
public uint ClientConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_HasClientConnectionId"></a> HasClientConnectionId

```csharp
public bool HasClientConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_HasSeqNumC2R"></a> HasSeqNumC2R

```csharp
public bool HasSeqNumC2R { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_HasSeqNumE2E"></a> HasSeqNumE2E

```csharp
public bool HasSeqNumE2E { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_LegacyAckE2E"></a> LegacyAckE2E

```csharp
public RepeatedField<uint> LegacyAckE2E { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramConnectionStatsClientToRouter> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramConnectionStatsClientToRouter](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsClientToRouter.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_QualityE2E"></a> QualityE2E

```csharp
public CMsgSteamDatagramConnectionQuality QualityE2E { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_QualityRelay"></a> QualityRelay

```csharp
public CMsgSteamDatagramConnectionQuality QualityRelay { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_SeqNumC2R"></a> SeqNumC2R

```csharp
public uint SeqNumC2R { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_SeqNumE2E"></a> SeqNumE2E

```csharp
public uint SeqNumE2E { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_ClearClientConnectionId"></a> ClearClientConnectionId\(\)

```csharp
public void ClearClientConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_ClearSeqNumC2R"></a> ClearSeqNumC2R\(\)

```csharp
public void ClearSeqNumC2R()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_ClearSeqNumE2E"></a> ClearSeqNumE2E\(\)

```csharp
public void ClearSeqNumE2E()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramConnectionStatsClientToRouter Clone()
```

#### Returns

 [CMsgSteamDatagramConnectionStatsClientToRouter](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsClientToRouter.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_"></a> Equals\(CMsgSteamDatagramConnectionStatsClientToRouter\)

```csharp
public bool Equals(CMsgSteamDatagramConnectionStatsClientToRouter other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionStatsClientToRouter](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsClientToRouter.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_"></a> MergeFrom\(CMsgSteamDatagramConnectionStatsClientToRouter\)

```csharp
public void MergeFrom(CMsgSteamDatagramConnectionStatsClientToRouter other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionStatsClientToRouter](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionStatsClientToRouter.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionStatsClientToRouter_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

