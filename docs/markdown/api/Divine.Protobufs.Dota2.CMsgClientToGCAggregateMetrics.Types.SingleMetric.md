# <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric"></a> Class CMsgClientToGCAggregateMetrics.Types.SingleMetric

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCAggregateMetrics.Types.SingleMetric : IMessage<CMsgClientToGCAggregateMetrics.Types.SingleMetric>, IEquatable<CMsgClientToGCAggregateMetrics.Types.SingleMetric>, IDeepCloneable<CMsgClientToGCAggregateMetrics.Types.SingleMetric>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCAggregateMetrics.Types.SingleMetric](Divine.Protobufs.Dota2.CMsgClientToGCAggregateMetrics.Types.SingleMetric.md)

#### Implements

IMessage<CMsgClientToGCAggregateMetrics.Types.SingleMetric\>, 
[IEquatable<CMsgClientToGCAggregateMetrics.Types.SingleMetric\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCAggregateMetrics.Types.SingleMetric\>, 
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
[EnumerableExtensions.In<CMsgClientToGCAggregateMetrics.Types.SingleMetric\>\(CMsgClientToGCAggregateMetrics.Types.SingleMetric, params CMsgClientToGCAggregateMetrics.Types.SingleMetric\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric__ctor"></a> SingleMetric\(\)

```csharp
public SingleMetric()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric__ctor_Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_"></a> SingleMetric\(SingleMetric\)

```csharp
public SingleMetric(CMsgClientToGCAggregateMetrics.Types.SingleMetric other)
```

#### Parameters

`other` [CMsgClientToGCAggregateMetrics](Divine.Protobufs.Dota2.CMsgClientToGCAggregateMetrics.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCAggregateMetrics.Types.md).[SingleMetric](Divine.Protobufs.Dota2.CMsgClientToGCAggregateMetrics.Types.SingleMetric.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_MetricCountFieldNumber"></a> MetricCountFieldNumber

```csharp
public const int MetricCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_MetricNameFieldNumber"></a> MetricNameFieldNumber

```csharp
public const int MetricNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_HasMetricCount"></a> HasMetricCount

```csharp
public bool HasMetricCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_HasMetricName"></a> HasMetricName

```csharp
public bool HasMetricName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_MetricCount"></a> MetricCount

```csharp
public uint MetricCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_MetricName"></a> MetricName

```csharp
public string MetricName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCAggregateMetrics.Types.SingleMetric> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCAggregateMetrics](Divine.Protobufs.Dota2.CMsgClientToGCAggregateMetrics.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCAggregateMetrics.Types.md).[SingleMetric](Divine.Protobufs.Dota2.CMsgClientToGCAggregateMetrics.Types.SingleMetric.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_ClearMetricCount"></a> ClearMetricCount\(\)

```csharp
public void ClearMetricCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_ClearMetricName"></a> ClearMetricName\(\)

```csharp
public void ClearMetricName()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCAggregateMetrics.Types.SingleMetric Clone()
```

#### Returns

 [CMsgClientToGCAggregateMetrics](Divine.Protobufs.Dota2.CMsgClientToGCAggregateMetrics.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCAggregateMetrics.Types.md).[SingleMetric](Divine.Protobufs.Dota2.CMsgClientToGCAggregateMetrics.Types.SingleMetric.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_Equals_Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_"></a> Equals\(SingleMetric\)

```csharp
public bool Equals(CMsgClientToGCAggregateMetrics.Types.SingleMetric other)
```

#### Parameters

`other` [CMsgClientToGCAggregateMetrics](Divine.Protobufs.Dota2.CMsgClientToGCAggregateMetrics.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCAggregateMetrics.Types.md).[SingleMetric](Divine.Protobufs.Dota2.CMsgClientToGCAggregateMetrics.Types.SingleMetric.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_"></a> MergeFrom\(SingleMetric\)

```csharp
public void MergeFrom(CMsgClientToGCAggregateMetrics.Types.SingleMetric other)
```

#### Parameters

`other` [CMsgClientToGCAggregateMetrics](Divine.Protobufs.Dota2.CMsgClientToGCAggregateMetrics.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCAggregateMetrics.Types.md).[SingleMetric](Divine.Protobufs.Dota2.CMsgClientToGCAggregateMetrics.Types.SingleMetric.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAggregateMetrics_Types_SingleMetric_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

