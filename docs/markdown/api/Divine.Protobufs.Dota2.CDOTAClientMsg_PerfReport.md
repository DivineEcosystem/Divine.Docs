# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport"></a> Class CDOTAClientMsg\_PerfReport

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_PerfReport : IMessage<CDOTAClientMsg_PerfReport>, IEquatable<CDOTAClientMsg_PerfReport>, IDeepCloneable<CDOTAClientMsg_PerfReport>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_PerfReport](Divine.Protobufs.Dota2.CDOTAClientMsg\_PerfReport.md)

#### Implements

IMessage<CDOTAClientMsg\_PerfReport\>, 
[IEquatable<CDOTAClientMsg\_PerfReport\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_PerfReport\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_PerfReport\>\(CDOTAClientMsg\_PerfReport, params CDOTAClientMsg\_PerfReport\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport__ctor"></a> CDOTAClientMsg\_PerfReport\(\)

```csharp
public CDOTAClientMsg_PerfReport()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_"></a> CDOTAClientMsg\_PerfReport\(CDOTAClientMsg\_PerfReport\)

```csharp
public CDOTAClientMsg_PerfReport(CDOTAClientMsg_PerfReport other)
```

#### Parameters

`other` [CDOTAClientMsg\_PerfReport](Divine.Protobufs.Dota2.CDOTAClientMsg\_PerfReport.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageClientSimulateTimeFieldNumber"></a> AverageClientSimulateTimeFieldNumber

```csharp
public const int AverageClientSimulateTimeFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageClientTickTimeFieldNumber"></a> AverageClientTickTimeFieldNumber

```csharp
public const int AverageClientTickTimeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageComputeTimeFieldNumber"></a> AverageComputeTimeFieldNumber

```csharp
public const int AverageComputeTimeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageFrameTimeFieldNumber"></a> AverageFrameTimeFieldNumber

```csharp
public const int AverageFrameTimeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageFrameUpdateTimeFieldNumber"></a> AverageFrameUpdateTimeFieldNumber

```csharp
public const int AverageFrameUpdateTimeFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageIdleTimeFieldNumber"></a> AverageIdleTimeFieldNumber

```csharp
public const int AverageIdleTimeFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageInputProcessingTimeFieldNumber"></a> AverageInputProcessingTimeFieldNumber

```csharp
public const int AverageInputProcessingTimeFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageMissedSnapshotRateFieldNumber"></a> AverageMissedSnapshotRateFieldNumber

```csharp
public const int AverageMissedSnapshotRateFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageOutputTimeFieldNumber"></a> AverageOutputTimeFieldNumber

```csharp
public const int AverageOutputTimeFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageSwapTimeFieldNumber"></a> AverageSwapTimeFieldNumber

```csharp
public const int AverageSwapTimeFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageWaitForRenderingToCompleteTimeFieldNumber"></a> AverageWaitForRenderingToCompleteTimeFieldNumber

```csharp
public const int AverageWaitForRenderingToCompleteTimeFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxClientSimulateTimeFieldNumber"></a> MaxClientSimulateTimeFieldNumber

```csharp
public const int MaxClientSimulateTimeFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxClientTickTimeFieldNumber"></a> MaxClientTickTimeFieldNumber

```csharp
public const int MaxClientTickTimeFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxComputeTimeFieldNumber"></a> MaxComputeTimeFieldNumber

```csharp
public const int MaxComputeTimeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxFrameTimeFieldNumber"></a> MaxFrameTimeFieldNumber

```csharp
public const int MaxFrameTimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxFrameUpdateTimeFieldNumber"></a> MaxFrameUpdateTimeFieldNumber

```csharp
public const int MaxFrameUpdateTimeFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxIdleTimeFieldNumber"></a> MaxIdleTimeFieldNumber

```csharp
public const int MaxIdleTimeFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxInputProcessingTimeFieldNumber"></a> MaxInputProcessingTimeFieldNumber

```csharp
public const int MaxInputProcessingTimeFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxMissedSnapshotRateFieldNumber"></a> MaxMissedSnapshotRateFieldNumber

```csharp
public const int MaxMissedSnapshotRateFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxOutputTimeFieldNumber"></a> MaxOutputTimeFieldNumber

```csharp
public const int MaxOutputTimeFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxSwapTimeFieldNumber"></a> MaxSwapTimeFieldNumber

```csharp
public const int MaxSwapTimeFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxWaitForRenderingToCompleteTimeFieldNumber"></a> MaxWaitForRenderingToCompleteTimeFieldNumber

```csharp
public const int MaxWaitForRenderingToCompleteTimeFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageClientSimulateTime"></a> AverageClientSimulateTime

```csharp
public float AverageClientSimulateTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageClientTickTime"></a> AverageClientTickTime

```csharp
public float AverageClientTickTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageComputeTime"></a> AverageComputeTime

```csharp
public float AverageComputeTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageFrameTime"></a> AverageFrameTime

```csharp
public float AverageFrameTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageFrameUpdateTime"></a> AverageFrameUpdateTime

```csharp
public float AverageFrameUpdateTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageIdleTime"></a> AverageIdleTime

```csharp
public float AverageIdleTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageInputProcessingTime"></a> AverageInputProcessingTime

```csharp
public float AverageInputProcessingTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageMissedSnapshotRate"></a> AverageMissedSnapshotRate

```csharp
public float AverageMissedSnapshotRate { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageOutputTime"></a> AverageOutputTime

```csharp
public float AverageOutputTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageSwapTime"></a> AverageSwapTime

```csharp
public float AverageSwapTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_AverageWaitForRenderingToCompleteTime"></a> AverageWaitForRenderingToCompleteTime

```csharp
public float AverageWaitForRenderingToCompleteTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasAverageClientSimulateTime"></a> HasAverageClientSimulateTime

```csharp
public bool HasAverageClientSimulateTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasAverageClientTickTime"></a> HasAverageClientTickTime

```csharp
public bool HasAverageClientTickTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasAverageComputeTime"></a> HasAverageComputeTime

```csharp
public bool HasAverageComputeTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasAverageFrameTime"></a> HasAverageFrameTime

```csharp
public bool HasAverageFrameTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasAverageFrameUpdateTime"></a> HasAverageFrameUpdateTime

```csharp
public bool HasAverageFrameUpdateTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasAverageIdleTime"></a> HasAverageIdleTime

```csharp
public bool HasAverageIdleTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasAverageInputProcessingTime"></a> HasAverageInputProcessingTime

```csharp
public bool HasAverageInputProcessingTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasAverageMissedSnapshotRate"></a> HasAverageMissedSnapshotRate

```csharp
public bool HasAverageMissedSnapshotRate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasAverageOutputTime"></a> HasAverageOutputTime

```csharp
public bool HasAverageOutputTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasAverageSwapTime"></a> HasAverageSwapTime

```csharp
public bool HasAverageSwapTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasAverageWaitForRenderingToCompleteTime"></a> HasAverageWaitForRenderingToCompleteTime

```csharp
public bool HasAverageWaitForRenderingToCompleteTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasMaxClientSimulateTime"></a> HasMaxClientSimulateTime

```csharp
public bool HasMaxClientSimulateTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasMaxClientTickTime"></a> HasMaxClientTickTime

```csharp
public bool HasMaxClientTickTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasMaxComputeTime"></a> HasMaxComputeTime

```csharp
public bool HasMaxComputeTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasMaxFrameTime"></a> HasMaxFrameTime

```csharp
public bool HasMaxFrameTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasMaxFrameUpdateTime"></a> HasMaxFrameUpdateTime

```csharp
public bool HasMaxFrameUpdateTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasMaxIdleTime"></a> HasMaxIdleTime

```csharp
public bool HasMaxIdleTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasMaxInputProcessingTime"></a> HasMaxInputProcessingTime

```csharp
public bool HasMaxInputProcessingTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasMaxMissedSnapshotRate"></a> HasMaxMissedSnapshotRate

```csharp
public bool HasMaxMissedSnapshotRate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasMaxOutputTime"></a> HasMaxOutputTime

```csharp
public bool HasMaxOutputTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasMaxSwapTime"></a> HasMaxSwapTime

```csharp
public bool HasMaxSwapTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_HasMaxWaitForRenderingToCompleteTime"></a> HasMaxWaitForRenderingToCompleteTime

```csharp
public bool HasMaxWaitForRenderingToCompleteTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxClientSimulateTime"></a> MaxClientSimulateTime

```csharp
public float MaxClientSimulateTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxClientTickTime"></a> MaxClientTickTime

```csharp
public float MaxClientTickTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxComputeTime"></a> MaxComputeTime

```csharp
public float MaxComputeTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxFrameTime"></a> MaxFrameTime

```csharp
public float MaxFrameTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxFrameUpdateTime"></a> MaxFrameUpdateTime

```csharp
public float MaxFrameUpdateTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxIdleTime"></a> MaxIdleTime

```csharp
public float MaxIdleTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxInputProcessingTime"></a> MaxInputProcessingTime

```csharp
public float MaxInputProcessingTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxMissedSnapshotRate"></a> MaxMissedSnapshotRate

```csharp
public float MaxMissedSnapshotRate { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxOutputTime"></a> MaxOutputTime

```csharp
public float MaxOutputTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxSwapTime"></a> MaxSwapTime

```csharp
public float MaxSwapTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MaxWaitForRenderingToCompleteTime"></a> MaxWaitForRenderingToCompleteTime

```csharp
public float MaxWaitForRenderingToCompleteTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_PerfReport> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_PerfReport](Divine.Protobufs.Dota2.CDOTAClientMsg\_PerfReport.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearAverageClientSimulateTime"></a> ClearAverageClientSimulateTime\(\)

```csharp
public void ClearAverageClientSimulateTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearAverageClientTickTime"></a> ClearAverageClientTickTime\(\)

```csharp
public void ClearAverageClientTickTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearAverageComputeTime"></a> ClearAverageComputeTime\(\)

```csharp
public void ClearAverageComputeTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearAverageFrameTime"></a> ClearAverageFrameTime\(\)

```csharp
public void ClearAverageFrameTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearAverageFrameUpdateTime"></a> ClearAverageFrameUpdateTime\(\)

```csharp
public void ClearAverageFrameUpdateTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearAverageIdleTime"></a> ClearAverageIdleTime\(\)

```csharp
public void ClearAverageIdleTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearAverageInputProcessingTime"></a> ClearAverageInputProcessingTime\(\)

```csharp
public void ClearAverageInputProcessingTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearAverageMissedSnapshotRate"></a> ClearAverageMissedSnapshotRate\(\)

```csharp
public void ClearAverageMissedSnapshotRate()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearAverageOutputTime"></a> ClearAverageOutputTime\(\)

```csharp
public void ClearAverageOutputTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearAverageSwapTime"></a> ClearAverageSwapTime\(\)

```csharp
public void ClearAverageSwapTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearAverageWaitForRenderingToCompleteTime"></a> ClearAverageWaitForRenderingToCompleteTime\(\)

```csharp
public void ClearAverageWaitForRenderingToCompleteTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearMaxClientSimulateTime"></a> ClearMaxClientSimulateTime\(\)

```csharp
public void ClearMaxClientSimulateTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearMaxClientTickTime"></a> ClearMaxClientTickTime\(\)

```csharp
public void ClearMaxClientTickTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearMaxComputeTime"></a> ClearMaxComputeTime\(\)

```csharp
public void ClearMaxComputeTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearMaxFrameTime"></a> ClearMaxFrameTime\(\)

```csharp
public void ClearMaxFrameTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearMaxFrameUpdateTime"></a> ClearMaxFrameUpdateTime\(\)

```csharp
public void ClearMaxFrameUpdateTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearMaxIdleTime"></a> ClearMaxIdleTime\(\)

```csharp
public void ClearMaxIdleTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearMaxInputProcessingTime"></a> ClearMaxInputProcessingTime\(\)

```csharp
public void ClearMaxInputProcessingTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearMaxMissedSnapshotRate"></a> ClearMaxMissedSnapshotRate\(\)

```csharp
public void ClearMaxMissedSnapshotRate()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearMaxOutputTime"></a> ClearMaxOutputTime\(\)

```csharp
public void ClearMaxOutputTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearMaxSwapTime"></a> ClearMaxSwapTime\(\)

```csharp
public void ClearMaxSwapTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ClearMaxWaitForRenderingToCompleteTime"></a> ClearMaxWaitForRenderingToCompleteTime\(\)

```csharp
public void ClearMaxWaitForRenderingToCompleteTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_PerfReport Clone()
```

#### Returns

 [CDOTAClientMsg\_PerfReport](Divine.Protobufs.Dota2.CDOTAClientMsg\_PerfReport.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_"></a> Equals\(CDOTAClientMsg\_PerfReport\)

```csharp
public bool Equals(CDOTAClientMsg_PerfReport other)
```

#### Parameters

`other` [CDOTAClientMsg\_PerfReport](Divine.Protobufs.Dota2.CDOTAClientMsg\_PerfReport.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_"></a> MergeFrom\(CDOTAClientMsg\_PerfReport\)

```csharp
public void MergeFrom(CDOTAClientMsg_PerfReport other)
```

#### Parameters

`other` [CDOTAClientMsg\_PerfReport](Divine.Protobufs.Dota2.CDOTAClientMsg\_PerfReport.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PerfReport_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

