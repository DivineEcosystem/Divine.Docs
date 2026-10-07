# <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry"></a> Class CMsgGCReportMetrics.Types.MetricEntry

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCReportMetrics.Types.MetricEntry : IMessage<CMsgGCReportMetrics.Types.MetricEntry>, IEquatable<CMsgGCReportMetrics.Types.MetricEntry>, IDeepCloneable<CMsgGCReportMetrics.Types.MetricEntry>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCReportMetrics.Types.MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md)

#### Implements

IMessage<CMsgGCReportMetrics.Types.MetricEntry\>, 
[IEquatable<CMsgGCReportMetrics.Types.MetricEntry\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCReportMetrics.Types.MetricEntry\>, 
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
[EnumerableExtensions.In<CMsgGCReportMetrics.Types.MetricEntry\>\(CMsgGCReportMetrics.Types.MetricEntry, params CMsgGCReportMetrics.Types.MetricEntry\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry__ctor"></a> MetricEntry\(\)

```csharp
public MetricEntry()
```

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry__ctor_Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_"></a> MetricEntry\(MetricEntry\)

```csharp
public MetricEntry(CMsgGCReportMetrics.Types.MetricEntry other)
```

#### Parameters

`other` [CMsgGCReportMetrics](Divine.Protobufs.Steam.CMsgGCReportMetrics.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.md).[MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_CatalogFieldNumber"></a> CatalogFieldNumber

```csharp
public const int CatalogFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_DimensionsFieldNumber"></a> DimensionsFieldNumber

```csharp
public const int DimensionsFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_MeasurementsFieldNumber"></a> MeasurementsFieldNumber

```csharp
public const int MeasurementsFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_OperationFieldNumber"></a> OperationFieldNumber

```csharp
public const int OperationFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Catalog"></a> Catalog

```csharp
public string Catalog { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Dimensions"></a> Dimensions

```csharp
public RepeatedField<CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension> Dimensions { get; }
```

#### Property Value

 RepeatedField<[CMsgGCReportMetrics](Divine.Protobufs.Steam.CMsgGCReportMetrics.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.md).[MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.md).[Dimension](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_HasCatalog"></a> HasCatalog

```csharp
public bool HasCatalog { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_HasOperation"></a> HasOperation

```csharp
public bool HasOperation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Measurements"></a> Measurements

```csharp
public RepeatedField<CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement> Measurements { get; }
```

#### Property Value

 RepeatedField<[CMsgGCReportMetrics](Divine.Protobufs.Steam.CMsgGCReportMetrics.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.md).[MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.md).[Measurement](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Operation"></a> Operation

```csharp
public string Operation { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCReportMetrics.Types.MetricEntry> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCReportMetrics](Divine.Protobufs.Steam.CMsgGCReportMetrics.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.md).[MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Timestamp"></a> Timestamp

```csharp
public double Timestamp { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_ClearCatalog"></a> ClearCatalog\(\)

```csharp
public void ClearCatalog()
```

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_ClearOperation"></a> ClearOperation\(\)

```csharp
public void ClearOperation()
```

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Clone"></a> Clone\(\)

```csharp
public CMsgGCReportMetrics.Types.MetricEntry Clone()
```

#### Returns

 [CMsgGCReportMetrics](Divine.Protobufs.Steam.CMsgGCReportMetrics.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.md).[MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Equals_Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_"></a> Equals\(MetricEntry\)

```csharp
public bool Equals(CMsgGCReportMetrics.Types.MetricEntry other)
```

#### Parameters

`other` [CMsgGCReportMetrics](Divine.Protobufs.Steam.CMsgGCReportMetrics.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.md).[MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_MergeFrom_Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_"></a> MergeFrom\(MetricEntry\)

```csharp
public void MergeFrom(CMsgGCReportMetrics.Types.MetricEntry other)
```

#### Parameters

`other` [CMsgGCReportMetrics](Divine.Protobufs.Steam.CMsgGCReportMetrics.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.md).[MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

