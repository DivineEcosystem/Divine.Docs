# <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement"></a> Class CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement : IMessage<CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement>, IEquatable<CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement>, IDeepCloneable<CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement.md)

#### Implements

IMessage<CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement\>, 
[IEquatable<CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement\>, 
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
[EnumerableExtensions.In<CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement\>\(CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement, params CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement__ctor"></a> Measurement\(\)

```csharp
public Measurement()
```

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement__ctor_Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_"></a> Measurement\(Measurement\)

```csharp
public Measurement(CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement other)
```

#### Parameters

`other` [CMsgGCReportMetrics](Divine.Protobufs.Steam.CMsgGCReportMetrics.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.md).[MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.md).[Measurement](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_ValueFloatFieldNumber"></a> ValueFloatFieldNumber

```csharp
public const int ValueFloatFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_ValueIntegerFieldNumber"></a> ValueIntegerFieldNumber

```csharp
public const int ValueIntegerFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_HasValueFloat"></a> HasValueFloat

```csharp
public bool HasValueFloat { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_HasValueInteger"></a> HasValueInteger

```csharp
public bool HasValueInteger { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCReportMetrics](Divine.Protobufs.Steam.CMsgGCReportMetrics.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.md).[MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.md).[Measurement](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_ValueCase"></a> ValueCase

```csharp
public CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement.ValueOneofCase ValueCase { get; }
```

#### Property Value

 [CMsgGCReportMetrics](Divine.Protobufs.Steam.CMsgGCReportMetrics.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.md).[MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.md).[Measurement](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement.md).[ValueOneofCase](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement.ValueOneofCase.md)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_ValueFloat"></a> ValueFloat

```csharp
public double ValueFloat { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_ValueInteger"></a> ValueInteger

```csharp
public long ValueInteger { get; set; }
```

#### Property Value

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_ClearValueFloat"></a> ClearValueFloat\(\)

```csharp
public void ClearValueFloat()
```

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_ClearValueInteger"></a> ClearValueInteger\(\)

```csharp
public void ClearValueInteger()
```

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_Clone"></a> Clone\(\)

```csharp
public CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement Clone()
```

#### Returns

 [CMsgGCReportMetrics](Divine.Protobufs.Steam.CMsgGCReportMetrics.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.md).[MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.md).[Measurement](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement.md)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_Equals_Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_"></a> Equals\(Measurement\)

```csharp
public bool Equals(CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement other)
```

#### Parameters

`other` [CMsgGCReportMetrics](Divine.Protobufs.Steam.CMsgGCReportMetrics.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.md).[MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.md).[Measurement](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_MergeFrom_Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_"></a> MergeFrom\(Measurement\)

```csharp
public void MergeFrom(CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement other)
```

#### Parameters

`other` [CMsgGCReportMetrics](Divine.Protobufs.Steam.CMsgGCReportMetrics.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.md).[MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.md).[Measurement](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.Measurement.md)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Measurement_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

