# <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality"></a> Class CMsgSource2NetworkFlowQuality

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSource2NetworkFlowQuality : IMessage<CMsgSource2NetworkFlowQuality>, IEquatable<CMsgSource2NetworkFlowQuality>, IDeepCloneable<CMsgSource2NetworkFlowQuality>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSource2NetworkFlowQuality](Divine.Protobufs.Dota2.CMsgSource2NetworkFlowQuality.md)

#### Implements

IMessage<CMsgSource2NetworkFlowQuality\>, 
[IEquatable<CMsgSource2NetworkFlowQuality\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSource2NetworkFlowQuality\>, 
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
[EnumerableExtensions.In<CMsgSource2NetworkFlowQuality\>\(CMsgSource2NetworkFlowQuality, params CMsgSource2NetworkFlowQuality\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality__ctor"></a> CMsgSource2NetworkFlowQuality\(\)

```csharp
public CMsgSource2NetworkFlowQuality()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality__ctor_Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_"></a> CMsgSource2NetworkFlowQuality\(CMsgSource2NetworkFlowQuality\)

```csharp
public CMsgSource2NetworkFlowQuality(CMsgSource2NetworkFlowQuality other)
```

#### Parameters

`other` [CMsgSource2NetworkFlowQuality](Divine.Protobufs.Dota2.CMsgSource2NetworkFlowQuality.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_BytesSecP95FieldNumber"></a> BytesSecP95FieldNumber

```csharp
public const int BytesSecP95FieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_BytesSecP99FieldNumber"></a> BytesSecP99FieldNumber

```csharp
public const int BytesSecP99FieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_BytesTotalFieldNumber"></a> BytesTotalFieldNumber

```csharp
public const int BytesTotalFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_BytesTotalReliableFieldNumber"></a> BytesTotalReliableFieldNumber

```csharp
public const int BytesTotalReliableFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_BytesTotalVoiceFieldNumber"></a> BytesTotalVoiceFieldNumber

```csharp
public const int BytesTotalVoiceFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_EnginemsgsSecP95FieldNumber"></a> EnginemsgsSecP95FieldNumber

```csharp
public const int EnginemsgsSecP95FieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_EnginemsgsSecP99FieldNumber"></a> EnginemsgsSecP99FieldNumber

```csharp
public const int EnginemsgsSecP99FieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_EnginemsgsTotalFieldNumber"></a> EnginemsgsTotalFieldNumber

```csharp
public const int EnginemsgsTotalFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_IntervalPeakjitterP50FieldNumber"></a> IntervalPeakjitterP50FieldNumber

```csharp
public const int IntervalPeakjitterP50FieldNumber = 72
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_IntervalPeakjitterP95FieldNumber"></a> IntervalPeakjitterP95FieldNumber

```csharp
public const int IntervalPeakjitterP95FieldNumber = 73
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_MsgprocUsecAvgMaxFieldNumber"></a> MsgprocUsecAvgMaxFieldNumber

```csharp
public const int MsgprocUsecAvgMaxFieldNumber = 97
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_MsgprocUsecAvgP50FieldNumber"></a> MsgprocUsecAvgP50FieldNumber

```csharp
public const int MsgprocUsecAvgP50FieldNumber = 94
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_MsgprocUsecAvgP95FieldNumber"></a> MsgprocUsecAvgP95FieldNumber

```csharp
public const int MsgprocUsecAvgP95FieldNumber = 95
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_MsgprocUsecAvgP99FieldNumber"></a> MsgprocUsecAvgP99FieldNumber

```csharp
public const int MsgprocUsecAvgP99FieldNumber = 96
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_MsgprocUsecMaxFieldNumber"></a> MsgprocUsecMaxFieldNumber

```csharp
public const int MsgprocUsecMaxFieldNumber = 93
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_MsgprocUsecP50FieldNumber"></a> MsgprocUsecP50FieldNumber

```csharp
public const int MsgprocUsecP50FieldNumber = 90
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_MsgprocUsecP95FieldNumber"></a> MsgprocUsecP95FieldNumber

```csharp
public const int MsgprocUsecP95FieldNumber = 91
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_MsgprocUsecP99FieldNumber"></a> MsgprocUsecP99FieldNumber

```csharp
public const int MsgprocUsecP99FieldNumber = 92
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframeJitterP50FieldNumber"></a> NetframeJitterP50FieldNumber

```csharp
public const int NetframeJitterP50FieldNumber = 70
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframeJitterP99FieldNumber"></a> NetframeJitterP99FieldNumber

```csharp
public const int NetframeJitterP99FieldNumber = 71
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesDroppedFieldNumber"></a> NetframesDroppedFieldNumber

```csharp
public const int NetframesDroppedFieldNumber = 31
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesMsgsMaxFieldNumber"></a> NetframesMsgsMaxFieldNumber

```csharp
public const int NetframesMsgsMaxFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesMsgsP50FieldNumber"></a> NetframesMsgsP50FieldNumber

```csharp
public const int NetframesMsgsP50FieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesMsgsP95FieldNumber"></a> NetframesMsgsP95FieldNumber

```csharp
public const int NetframesMsgsP95FieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesMsgsP99FieldNumber"></a> NetframesMsgsP99FieldNumber

```csharp
public const int NetframesMsgsP99FieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesOutoforderFieldNumber"></a> NetframesOutoforderFieldNumber

```csharp
public const int NetframesOutoforderFieldNumber = 32
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesSizeExceedsMtuFieldNumber"></a> NetframesSizeExceedsMtuFieldNumber

```csharp
public const int NetframesSizeExceedsMtuFieldNumber = 34
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesSizeP95FieldNumber"></a> NetframesSizeP95FieldNumber

```csharp
public const int NetframesSizeP95FieldNumber = 35
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesSizeP99FieldNumber"></a> NetframesSizeP99FieldNumber

```csharp
public const int NetframesSizeP99FieldNumber = 36
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesSizeUncompressedMaxFieldNumber"></a> NetframesSizeUncompressedMaxFieldNumber

```csharp
public const int NetframesSizeUncompressedMaxFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesSizeUncompressedP50FieldNumber"></a> NetframesSizeUncompressedP50FieldNumber

```csharp
public const int NetframesSizeUncompressedP50FieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesSizeUncompressedP95FieldNumber"></a> NetframesSizeUncompressedP95FieldNumber

```csharp
public const int NetframesSizeUncompressedP95FieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesSizeUncompressedP99FieldNumber"></a> NetframesSizeUncompressedP99FieldNumber

```csharp
public const int NetframesSizeUncompressedP99FieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesTotalFieldNumber"></a> NetframesTotalFieldNumber

```csharp
public const int NetframesTotalFieldNumber = 30
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetPingP50FieldNumber"></a> NetPingP50FieldNumber

```csharp
public const int NetPingP50FieldNumber = 81
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetPingP5FieldNumber"></a> NetPingP5FieldNumber

```csharp
public const int NetPingP5FieldNumber = 80
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetPingP95FieldNumber"></a> NetPingP95FieldNumber

```csharp
public const int NetPingP95FieldNumber = 82
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_PacketMisdeliveryRateP50X4FieldNumber"></a> PacketMisdeliveryRateP50X4FieldNumber

```csharp
public const int PacketMisdeliveryRateP50X4FieldNumber = 74
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_PacketMisdeliveryRateP95X4FieldNumber"></a> PacketMisdeliveryRateP95X4FieldNumber

```csharp
public const int PacketMisdeliveryRateP95X4FieldNumber = 75
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_QueuedmsgsMaxFieldNumber"></a> QueuedmsgsMaxFieldNumber

```csharp
public const int QueuedmsgsMaxFieldNumber = 103
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_QueuedmsgsP50FieldNumber"></a> QueuedmsgsP50FieldNumber

```csharp
public const int QueuedmsgsP50FieldNumber = 100
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_QueuedmsgsP95FieldNumber"></a> QueuedmsgsP95FieldNumber

```csharp
public const int QueuedmsgsP95FieldNumber = 101
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_QueuedmsgsP99FieldNumber"></a> QueuedmsgsP99FieldNumber

```csharp
public const int QueuedmsgsP99FieldNumber = 102
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_RecvmarginP1FieldNumber"></a> RecvmarginP1FieldNumber

```csharp
public const int RecvmarginP1FieldNumber = 61
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_RecvmarginP25FieldNumber"></a> RecvmarginP25FieldNumber

```csharp
public const int RecvmarginP25FieldNumber = 63
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_RecvmarginP50FieldNumber"></a> RecvmarginP50FieldNumber

```csharp
public const int RecvmarginP50FieldNumber = 64
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_RecvmarginP5FieldNumber"></a> RecvmarginP5FieldNumber

```csharp
public const int RecvmarginP5FieldNumber = 62
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_RecvmarginP75FieldNumber"></a> RecvmarginP75FieldNumber

```csharp
public const int RecvmarginP75FieldNumber = 65
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_RecvmarginP95FieldNumber"></a> RecvmarginP95FieldNumber

```csharp
public const int RecvmarginP95FieldNumber = 66
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TickMissratenetP75X10FieldNumber"></a> TickMissratenetP75X10FieldNumber

```csharp
public const int TickMissratenetP75X10FieldNumber = 53
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TickMissratenetP95X10FieldNumber"></a> TickMissratenetP95X10FieldNumber

```csharp
public const int TickMissratenetP95X10FieldNumber = 54
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TickMissratenetP99X10FieldNumber"></a> TickMissratenetP99X10FieldNumber

```csharp
public const int TickMissratenetP99X10FieldNumber = 55
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TickMissrateSamplesPerfectFieldNumber"></a> TickMissrateSamplesPerfectFieldNumber

```csharp
public const int TickMissrateSamplesPerfectFieldNumber = 51
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TickMissrateSamplesPerfectnetFieldNumber"></a> TickMissrateSamplesPerfectnetFieldNumber

```csharp
public const int TickMissrateSamplesPerfectnetFieldNumber = 52
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TickMissrateSamplesTotalFieldNumber"></a> TickMissrateSamplesTotalFieldNumber

```csharp
public const int TickMissrateSamplesTotalFieldNumber = 50
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TicksBadDroppedFieldNumber"></a> TicksBadDroppedFieldNumber

```csharp
public const int TicksBadDroppedFieldNumber = 45
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TicksBadLateFieldNumber"></a> TicksBadLateFieldNumber

```csharp
public const int TicksBadLateFieldNumber = 46
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TicksBadOtherFieldNumber"></a> TicksBadOtherFieldNumber

```csharp
public const int TicksBadOtherFieldNumber = 47
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TicksFixedDroppedFieldNumber"></a> TicksFixedDroppedFieldNumber

```csharp
public const int TicksFixedDroppedFieldNumber = 43
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TicksFixedLateFieldNumber"></a> TicksFixedLateFieldNumber

```csharp
public const int TicksFixedLateFieldNumber = 44
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TicksGoodAlmostLateFieldNumber"></a> TicksGoodAlmostLateFieldNumber

```csharp
public const int TicksGoodAlmostLateFieldNumber = 42
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TicksGoodFieldNumber"></a> TicksGoodFieldNumber

```csharp
public const int TicksGoodFieldNumber = 41
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TicksTotalFieldNumber"></a> TicksTotalFieldNumber

```csharp
public const int TicksTotalFieldNumber = 40
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_BytesSecP95"></a> BytesSecP95

```csharp
public uint BytesSecP95 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_BytesSecP99"></a> BytesSecP99

```csharp
public uint BytesSecP99 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_BytesTotal"></a> BytesTotal

```csharp
public ulong BytesTotal { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_BytesTotalReliable"></a> BytesTotalReliable

```csharp
public ulong BytesTotalReliable { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_BytesTotalVoice"></a> BytesTotalVoice

```csharp
public ulong BytesTotalVoice { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_Duration"></a> Duration

```csharp
public uint Duration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_EnginemsgsSecP95"></a> EnginemsgsSecP95

```csharp
public uint EnginemsgsSecP95 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_EnginemsgsSecP99"></a> EnginemsgsSecP99

```csharp
public uint EnginemsgsSecP99 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_EnginemsgsTotal"></a> EnginemsgsTotal

```csharp
public uint EnginemsgsTotal { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasBytesSecP95"></a> HasBytesSecP95

```csharp
public bool HasBytesSecP95 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasBytesSecP99"></a> HasBytesSecP99

```csharp
public bool HasBytesSecP99 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasBytesTotal"></a> HasBytesTotal

```csharp
public bool HasBytesTotal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasBytesTotalReliable"></a> HasBytesTotalReliable

```csharp
public bool HasBytesTotalReliable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasBytesTotalVoice"></a> HasBytesTotalVoice

```csharp
public bool HasBytesTotalVoice { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasEnginemsgsSecP95"></a> HasEnginemsgsSecP95

```csharp
public bool HasEnginemsgsSecP95 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasEnginemsgsSecP99"></a> HasEnginemsgsSecP99

```csharp
public bool HasEnginemsgsSecP99 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasEnginemsgsTotal"></a> HasEnginemsgsTotal

```csharp
public bool HasEnginemsgsTotal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasIntervalPeakjitterP50"></a> HasIntervalPeakjitterP50

```csharp
public bool HasIntervalPeakjitterP50 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasIntervalPeakjitterP95"></a> HasIntervalPeakjitterP95

```csharp
public bool HasIntervalPeakjitterP95 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasMsgprocUsecAvgMax"></a> HasMsgprocUsecAvgMax

```csharp
public bool HasMsgprocUsecAvgMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasMsgprocUsecAvgP50"></a> HasMsgprocUsecAvgP50

```csharp
public bool HasMsgprocUsecAvgP50 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasMsgprocUsecAvgP95"></a> HasMsgprocUsecAvgP95

```csharp
public bool HasMsgprocUsecAvgP95 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasMsgprocUsecAvgP99"></a> HasMsgprocUsecAvgP99

```csharp
public bool HasMsgprocUsecAvgP99 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasMsgprocUsecMax"></a> HasMsgprocUsecMax

```csharp
public bool HasMsgprocUsecMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasMsgprocUsecP50"></a> HasMsgprocUsecP50

```csharp
public bool HasMsgprocUsecP50 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasMsgprocUsecP95"></a> HasMsgprocUsecP95

```csharp
public bool HasMsgprocUsecP95 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasMsgprocUsecP99"></a> HasMsgprocUsecP99

```csharp
public bool HasMsgprocUsecP99 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasNetframeJitterP50"></a> HasNetframeJitterP50

```csharp
public bool HasNetframeJitterP50 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasNetframeJitterP99"></a> HasNetframeJitterP99

```csharp
public bool HasNetframeJitterP99 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasNetframesDropped"></a> HasNetframesDropped

```csharp
public bool HasNetframesDropped { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasNetframesMsgsMax"></a> HasNetframesMsgsMax

```csharp
public bool HasNetframesMsgsMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasNetframesMsgsP50"></a> HasNetframesMsgsP50

```csharp
public bool HasNetframesMsgsP50 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasNetframesMsgsP95"></a> HasNetframesMsgsP95

```csharp
public bool HasNetframesMsgsP95 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasNetframesMsgsP99"></a> HasNetframesMsgsP99

```csharp
public bool HasNetframesMsgsP99 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasNetframesOutoforder"></a> HasNetframesOutoforder

```csharp
public bool HasNetframesOutoforder { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasNetframesSizeExceedsMtu"></a> HasNetframesSizeExceedsMtu

```csharp
public bool HasNetframesSizeExceedsMtu { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasNetframesSizeP95"></a> HasNetframesSizeP95

```csharp
public bool HasNetframesSizeP95 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasNetframesSizeP99"></a> HasNetframesSizeP99

```csharp
public bool HasNetframesSizeP99 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasNetframesSizeUncompressedMax"></a> HasNetframesSizeUncompressedMax

```csharp
public bool HasNetframesSizeUncompressedMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasNetframesSizeUncompressedP50"></a> HasNetframesSizeUncompressedP50

```csharp
public bool HasNetframesSizeUncompressedP50 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasNetframesSizeUncompressedP95"></a> HasNetframesSizeUncompressedP95

```csharp
public bool HasNetframesSizeUncompressedP95 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasNetframesSizeUncompressedP99"></a> HasNetframesSizeUncompressedP99

```csharp
public bool HasNetframesSizeUncompressedP99 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasNetframesTotal"></a> HasNetframesTotal

```csharp
public bool HasNetframesTotal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasNetPingP5"></a> HasNetPingP5

```csharp
public bool HasNetPingP5 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasNetPingP50"></a> HasNetPingP50

```csharp
public bool HasNetPingP50 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasNetPingP95"></a> HasNetPingP95

```csharp
public bool HasNetPingP95 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasPacketMisdeliveryRateP50X4"></a> HasPacketMisdeliveryRateP50X4

```csharp
public bool HasPacketMisdeliveryRateP50X4 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasPacketMisdeliveryRateP95X4"></a> HasPacketMisdeliveryRateP95X4

```csharp
public bool HasPacketMisdeliveryRateP95X4 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasQueuedmsgsMax"></a> HasQueuedmsgsMax

```csharp
public bool HasQueuedmsgsMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasQueuedmsgsP50"></a> HasQueuedmsgsP50

```csharp
public bool HasQueuedmsgsP50 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasQueuedmsgsP95"></a> HasQueuedmsgsP95

```csharp
public bool HasQueuedmsgsP95 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasQueuedmsgsP99"></a> HasQueuedmsgsP99

```csharp
public bool HasQueuedmsgsP99 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasRecvmarginP1"></a> HasRecvmarginP1

```csharp
public bool HasRecvmarginP1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasRecvmarginP25"></a> HasRecvmarginP25

```csharp
public bool HasRecvmarginP25 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasRecvmarginP5"></a> HasRecvmarginP5

```csharp
public bool HasRecvmarginP5 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasRecvmarginP50"></a> HasRecvmarginP50

```csharp
public bool HasRecvmarginP50 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasRecvmarginP75"></a> HasRecvmarginP75

```csharp
public bool HasRecvmarginP75 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasRecvmarginP95"></a> HasRecvmarginP95

```csharp
public bool HasRecvmarginP95 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasTickMissratenetP75X10"></a> HasTickMissratenetP75X10

```csharp
public bool HasTickMissratenetP75X10 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasTickMissratenetP95X10"></a> HasTickMissratenetP95X10

```csharp
public bool HasTickMissratenetP95X10 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasTickMissratenetP99X10"></a> HasTickMissratenetP99X10

```csharp
public bool HasTickMissratenetP99X10 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasTickMissrateSamplesPerfect"></a> HasTickMissrateSamplesPerfect

```csharp
public bool HasTickMissrateSamplesPerfect { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasTickMissrateSamplesPerfectnet"></a> HasTickMissrateSamplesPerfectnet

```csharp
public bool HasTickMissrateSamplesPerfectnet { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasTickMissrateSamplesTotal"></a> HasTickMissrateSamplesTotal

```csharp
public bool HasTickMissrateSamplesTotal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasTicksBadDropped"></a> HasTicksBadDropped

```csharp
public bool HasTicksBadDropped { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasTicksBadLate"></a> HasTicksBadLate

```csharp
public bool HasTicksBadLate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasTicksBadOther"></a> HasTicksBadOther

```csharp
public bool HasTicksBadOther { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasTicksFixedDropped"></a> HasTicksFixedDropped

```csharp
public bool HasTicksFixedDropped { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasTicksFixedLate"></a> HasTicksFixedLate

```csharp
public bool HasTicksFixedLate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasTicksGood"></a> HasTicksGood

```csharp
public bool HasTicksGood { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasTicksGoodAlmostLate"></a> HasTicksGoodAlmostLate

```csharp
public bool HasTicksGoodAlmostLate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_HasTicksTotal"></a> HasTicksTotal

```csharp
public bool HasTicksTotal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_IntervalPeakjitterP50"></a> IntervalPeakjitterP50

```csharp
public uint IntervalPeakjitterP50 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_IntervalPeakjitterP95"></a> IntervalPeakjitterP95

```csharp
public uint IntervalPeakjitterP95 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_MsgprocUsecAvgMax"></a> MsgprocUsecAvgMax

```csharp
public uint MsgprocUsecAvgMax { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_MsgprocUsecAvgP50"></a> MsgprocUsecAvgP50

```csharp
public uint MsgprocUsecAvgP50 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_MsgprocUsecAvgP95"></a> MsgprocUsecAvgP95

```csharp
public uint MsgprocUsecAvgP95 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_MsgprocUsecAvgP99"></a> MsgprocUsecAvgP99

```csharp
public uint MsgprocUsecAvgP99 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_MsgprocUsecMax"></a> MsgprocUsecMax

```csharp
public uint MsgprocUsecMax { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_MsgprocUsecP50"></a> MsgprocUsecP50

```csharp
public uint MsgprocUsecP50 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_MsgprocUsecP95"></a> MsgprocUsecP95

```csharp
public uint MsgprocUsecP95 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_MsgprocUsecP99"></a> MsgprocUsecP99

```csharp
public uint MsgprocUsecP99 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframeJitterP50"></a> NetframeJitterP50

```csharp
public uint NetframeJitterP50 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframeJitterP99"></a> NetframeJitterP99

```csharp
public uint NetframeJitterP99 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesDropped"></a> NetframesDropped

```csharp
public uint NetframesDropped { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesMsgsMax"></a> NetframesMsgsMax

```csharp
public uint NetframesMsgsMax { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesMsgsP50"></a> NetframesMsgsP50

```csharp
public uint NetframesMsgsP50 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesMsgsP95"></a> NetframesMsgsP95

```csharp
public uint NetframesMsgsP95 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesMsgsP99"></a> NetframesMsgsP99

```csharp
public uint NetframesMsgsP99 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesOutoforder"></a> NetframesOutoforder

```csharp
public uint NetframesOutoforder { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesSizeExceedsMtu"></a> NetframesSizeExceedsMtu

```csharp
public uint NetframesSizeExceedsMtu { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesSizeP95"></a> NetframesSizeP95

```csharp
public uint NetframesSizeP95 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesSizeP99"></a> NetframesSizeP99

```csharp
public uint NetframesSizeP99 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesSizeUncompressedMax"></a> NetframesSizeUncompressedMax

```csharp
public uint NetframesSizeUncompressedMax { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesSizeUncompressedP50"></a> NetframesSizeUncompressedP50

```csharp
public uint NetframesSizeUncompressedP50 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesSizeUncompressedP95"></a> NetframesSizeUncompressedP95

```csharp
public uint NetframesSizeUncompressedP95 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesSizeUncompressedP99"></a> NetframesSizeUncompressedP99

```csharp
public uint NetframesSizeUncompressedP99 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetframesTotal"></a> NetframesTotal

```csharp
public uint NetframesTotal { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetPingP5"></a> NetPingP5

```csharp
public uint NetPingP5 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetPingP50"></a> NetPingP50

```csharp
public uint NetPingP50 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_NetPingP95"></a> NetPingP95

```csharp
public uint NetPingP95 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_PacketMisdeliveryRateP50X4"></a> PacketMisdeliveryRateP50X4

```csharp
public uint PacketMisdeliveryRateP50X4 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_PacketMisdeliveryRateP95X4"></a> PacketMisdeliveryRateP95X4

```csharp
public uint PacketMisdeliveryRateP95X4 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSource2NetworkFlowQuality> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSource2NetworkFlowQuality](Divine.Protobufs.Dota2.CMsgSource2NetworkFlowQuality.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_QueuedmsgsMax"></a> QueuedmsgsMax

```csharp
public uint QueuedmsgsMax { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_QueuedmsgsP50"></a> QueuedmsgsP50

```csharp
public uint QueuedmsgsP50 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_QueuedmsgsP95"></a> QueuedmsgsP95

```csharp
public uint QueuedmsgsP95 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_QueuedmsgsP99"></a> QueuedmsgsP99

```csharp
public uint QueuedmsgsP99 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_RecvmarginP1"></a> RecvmarginP1

```csharp
public int RecvmarginP1 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_RecvmarginP25"></a> RecvmarginP25

```csharp
public int RecvmarginP25 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_RecvmarginP5"></a> RecvmarginP5

```csharp
public int RecvmarginP5 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_RecvmarginP50"></a> RecvmarginP50

```csharp
public int RecvmarginP50 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_RecvmarginP75"></a> RecvmarginP75

```csharp
public int RecvmarginP75 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_RecvmarginP95"></a> RecvmarginP95

```csharp
public int RecvmarginP95 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TickMissratenetP75X10"></a> TickMissratenetP75X10

```csharp
public uint TickMissratenetP75X10 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TickMissratenetP95X10"></a> TickMissratenetP95X10

```csharp
public uint TickMissratenetP95X10 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TickMissratenetP99X10"></a> TickMissratenetP99X10

```csharp
public uint TickMissratenetP99X10 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TickMissrateSamplesPerfect"></a> TickMissrateSamplesPerfect

```csharp
public uint TickMissrateSamplesPerfect { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TickMissrateSamplesPerfectnet"></a> TickMissrateSamplesPerfectnet

```csharp
public uint TickMissrateSamplesPerfectnet { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TickMissrateSamplesTotal"></a> TickMissrateSamplesTotal

```csharp
public uint TickMissrateSamplesTotal { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TicksBadDropped"></a> TicksBadDropped

```csharp
public uint TicksBadDropped { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TicksBadLate"></a> TicksBadLate

```csharp
public uint TicksBadLate { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TicksBadOther"></a> TicksBadOther

```csharp
public uint TicksBadOther { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TicksFixedDropped"></a> TicksFixedDropped

```csharp
public uint TicksFixedDropped { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TicksFixedLate"></a> TicksFixedLate

```csharp
public uint TicksFixedLate { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TicksGood"></a> TicksGood

```csharp
public uint TicksGood { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TicksGoodAlmostLate"></a> TicksGoodAlmostLate

```csharp
public uint TicksGoodAlmostLate { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_TicksTotal"></a> TicksTotal

```csharp
public uint TicksTotal { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearBytesSecP95"></a> ClearBytesSecP95\(\)

```csharp
public void ClearBytesSecP95()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearBytesSecP99"></a> ClearBytesSecP99\(\)

```csharp
public void ClearBytesSecP99()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearBytesTotal"></a> ClearBytesTotal\(\)

```csharp
public void ClearBytesTotal()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearBytesTotalReliable"></a> ClearBytesTotalReliable\(\)

```csharp
public void ClearBytesTotalReliable()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearBytesTotalVoice"></a> ClearBytesTotalVoice\(\)

```csharp
public void ClearBytesTotalVoice()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearEnginemsgsSecP95"></a> ClearEnginemsgsSecP95\(\)

```csharp
public void ClearEnginemsgsSecP95()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearEnginemsgsSecP99"></a> ClearEnginemsgsSecP99\(\)

```csharp
public void ClearEnginemsgsSecP99()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearEnginemsgsTotal"></a> ClearEnginemsgsTotal\(\)

```csharp
public void ClearEnginemsgsTotal()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearIntervalPeakjitterP50"></a> ClearIntervalPeakjitterP50\(\)

```csharp
public void ClearIntervalPeakjitterP50()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearIntervalPeakjitterP95"></a> ClearIntervalPeakjitterP95\(\)

```csharp
public void ClearIntervalPeakjitterP95()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearMsgprocUsecAvgMax"></a> ClearMsgprocUsecAvgMax\(\)

```csharp
public void ClearMsgprocUsecAvgMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearMsgprocUsecAvgP50"></a> ClearMsgprocUsecAvgP50\(\)

```csharp
public void ClearMsgprocUsecAvgP50()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearMsgprocUsecAvgP95"></a> ClearMsgprocUsecAvgP95\(\)

```csharp
public void ClearMsgprocUsecAvgP95()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearMsgprocUsecAvgP99"></a> ClearMsgprocUsecAvgP99\(\)

```csharp
public void ClearMsgprocUsecAvgP99()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearMsgprocUsecMax"></a> ClearMsgprocUsecMax\(\)

```csharp
public void ClearMsgprocUsecMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearMsgprocUsecP50"></a> ClearMsgprocUsecP50\(\)

```csharp
public void ClearMsgprocUsecP50()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearMsgprocUsecP95"></a> ClearMsgprocUsecP95\(\)

```csharp
public void ClearMsgprocUsecP95()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearMsgprocUsecP99"></a> ClearMsgprocUsecP99\(\)

```csharp
public void ClearMsgprocUsecP99()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearNetframeJitterP50"></a> ClearNetframeJitterP50\(\)

```csharp
public void ClearNetframeJitterP50()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearNetframeJitterP99"></a> ClearNetframeJitterP99\(\)

```csharp
public void ClearNetframeJitterP99()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearNetframesDropped"></a> ClearNetframesDropped\(\)

```csharp
public void ClearNetframesDropped()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearNetframesMsgsMax"></a> ClearNetframesMsgsMax\(\)

```csharp
public void ClearNetframesMsgsMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearNetframesMsgsP50"></a> ClearNetframesMsgsP50\(\)

```csharp
public void ClearNetframesMsgsP50()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearNetframesMsgsP95"></a> ClearNetframesMsgsP95\(\)

```csharp
public void ClearNetframesMsgsP95()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearNetframesMsgsP99"></a> ClearNetframesMsgsP99\(\)

```csharp
public void ClearNetframesMsgsP99()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearNetframesOutoforder"></a> ClearNetframesOutoforder\(\)

```csharp
public void ClearNetframesOutoforder()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearNetframesSizeExceedsMtu"></a> ClearNetframesSizeExceedsMtu\(\)

```csharp
public void ClearNetframesSizeExceedsMtu()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearNetframesSizeP95"></a> ClearNetframesSizeP95\(\)

```csharp
public void ClearNetframesSizeP95()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearNetframesSizeP99"></a> ClearNetframesSizeP99\(\)

```csharp
public void ClearNetframesSizeP99()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearNetframesSizeUncompressedMax"></a> ClearNetframesSizeUncompressedMax\(\)

```csharp
public void ClearNetframesSizeUncompressedMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearNetframesSizeUncompressedP50"></a> ClearNetframesSizeUncompressedP50\(\)

```csharp
public void ClearNetframesSizeUncompressedP50()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearNetframesSizeUncompressedP95"></a> ClearNetframesSizeUncompressedP95\(\)

```csharp
public void ClearNetframesSizeUncompressedP95()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearNetframesSizeUncompressedP99"></a> ClearNetframesSizeUncompressedP99\(\)

```csharp
public void ClearNetframesSizeUncompressedP99()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearNetframesTotal"></a> ClearNetframesTotal\(\)

```csharp
public void ClearNetframesTotal()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearNetPingP5"></a> ClearNetPingP5\(\)

```csharp
public void ClearNetPingP5()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearNetPingP50"></a> ClearNetPingP50\(\)

```csharp
public void ClearNetPingP50()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearNetPingP95"></a> ClearNetPingP95\(\)

```csharp
public void ClearNetPingP95()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearPacketMisdeliveryRateP50X4"></a> ClearPacketMisdeliveryRateP50X4\(\)

```csharp
public void ClearPacketMisdeliveryRateP50X4()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearPacketMisdeliveryRateP95X4"></a> ClearPacketMisdeliveryRateP95X4\(\)

```csharp
public void ClearPacketMisdeliveryRateP95X4()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearQueuedmsgsMax"></a> ClearQueuedmsgsMax\(\)

```csharp
public void ClearQueuedmsgsMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearQueuedmsgsP50"></a> ClearQueuedmsgsP50\(\)

```csharp
public void ClearQueuedmsgsP50()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearQueuedmsgsP95"></a> ClearQueuedmsgsP95\(\)

```csharp
public void ClearQueuedmsgsP95()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearQueuedmsgsP99"></a> ClearQueuedmsgsP99\(\)

```csharp
public void ClearQueuedmsgsP99()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearRecvmarginP1"></a> ClearRecvmarginP1\(\)

```csharp
public void ClearRecvmarginP1()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearRecvmarginP25"></a> ClearRecvmarginP25\(\)

```csharp
public void ClearRecvmarginP25()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearRecvmarginP5"></a> ClearRecvmarginP5\(\)

```csharp
public void ClearRecvmarginP5()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearRecvmarginP50"></a> ClearRecvmarginP50\(\)

```csharp
public void ClearRecvmarginP50()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearRecvmarginP75"></a> ClearRecvmarginP75\(\)

```csharp
public void ClearRecvmarginP75()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearRecvmarginP95"></a> ClearRecvmarginP95\(\)

```csharp
public void ClearRecvmarginP95()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearTickMissratenetP75X10"></a> ClearTickMissratenetP75X10\(\)

```csharp
public void ClearTickMissratenetP75X10()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearTickMissratenetP95X10"></a> ClearTickMissratenetP95X10\(\)

```csharp
public void ClearTickMissratenetP95X10()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearTickMissratenetP99X10"></a> ClearTickMissratenetP99X10\(\)

```csharp
public void ClearTickMissratenetP99X10()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearTickMissrateSamplesPerfect"></a> ClearTickMissrateSamplesPerfect\(\)

```csharp
public void ClearTickMissrateSamplesPerfect()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearTickMissrateSamplesPerfectnet"></a> ClearTickMissrateSamplesPerfectnet\(\)

```csharp
public void ClearTickMissrateSamplesPerfectnet()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearTickMissrateSamplesTotal"></a> ClearTickMissrateSamplesTotal\(\)

```csharp
public void ClearTickMissrateSamplesTotal()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearTicksBadDropped"></a> ClearTicksBadDropped\(\)

```csharp
public void ClearTicksBadDropped()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearTicksBadLate"></a> ClearTicksBadLate\(\)

```csharp
public void ClearTicksBadLate()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearTicksBadOther"></a> ClearTicksBadOther\(\)

```csharp
public void ClearTicksBadOther()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearTicksFixedDropped"></a> ClearTicksFixedDropped\(\)

```csharp
public void ClearTicksFixedDropped()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearTicksFixedLate"></a> ClearTicksFixedLate\(\)

```csharp
public void ClearTicksFixedLate()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearTicksGood"></a> ClearTicksGood\(\)

```csharp
public void ClearTicksGood()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearTicksGoodAlmostLate"></a> ClearTicksGoodAlmostLate\(\)

```csharp
public void ClearTicksGoodAlmostLate()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ClearTicksTotal"></a> ClearTicksTotal\(\)

```csharp
public void ClearTicksTotal()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_Clone"></a> Clone\(\)

```csharp
public CMsgSource2NetworkFlowQuality Clone()
```

#### Returns

 [CMsgSource2NetworkFlowQuality](Divine.Protobufs.Dota2.CMsgSource2NetworkFlowQuality.md)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_Equals_Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_"></a> Equals\(CMsgSource2NetworkFlowQuality\)

```csharp
public bool Equals(CMsgSource2NetworkFlowQuality other)
```

#### Parameters

`other` [CMsgSource2NetworkFlowQuality](Divine.Protobufs.Dota2.CMsgSource2NetworkFlowQuality.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_MergeFrom_Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_"></a> MergeFrom\(CMsgSource2NetworkFlowQuality\)

```csharp
public void MergeFrom(CMsgSource2NetworkFlowQuality other)
```

#### Parameters

`other` [CMsgSource2NetworkFlowQuality](Divine.Protobufs.Dota2.CMsgSource2NetworkFlowQuality.md)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSource2NetworkFlowQuality_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

