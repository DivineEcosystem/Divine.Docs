# <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension"></a> Class CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension : IMessage<CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension>, IEquatable<CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension>, IDeepCloneable<CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension.md)

#### Implements

IMessage<CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension\>, 
[IEquatable<CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension\>, 
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
[EnumerableExtensions.In<CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension\>\(CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension, params CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension__ctor"></a> Dimension\(\)

```csharp
public Dimension()
```

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension__ctor_Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_"></a> Dimension\(Dimension\)

```csharp
public Dimension(CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension other)
```

#### Parameters

`other` [CMsgGCReportMetrics](Divine.Protobufs.Steam.CMsgGCReportMetrics.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.md).[MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.md).[Dimension](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_ValueBooleanFieldNumber"></a> ValueBooleanFieldNumber

```csharp
public const int ValueBooleanFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_ValueIntegerFieldNumber"></a> ValueIntegerFieldNumber

```csharp
public const int ValueIntegerFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_ValueStringFieldNumber"></a> ValueStringFieldNumber

```csharp
public const int ValueStringFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_HasValueBoolean"></a> HasValueBoolean

```csharp
public bool HasValueBoolean { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_HasValueInteger"></a> HasValueInteger

```csharp
public bool HasValueInteger { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_HasValueString"></a> HasValueString

```csharp
public bool HasValueString { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCReportMetrics](Divine.Protobufs.Steam.CMsgGCReportMetrics.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.md).[MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.md).[Dimension](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_ValueBoolean"></a> ValueBoolean

```csharp
public bool ValueBoolean { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_ValueCase"></a> ValueCase

```csharp
public CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension.ValueOneofCase ValueCase { get; }
```

#### Property Value

 [CMsgGCReportMetrics](Divine.Protobufs.Steam.CMsgGCReportMetrics.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.md).[MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.md).[Dimension](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension.md).[ValueOneofCase](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension.ValueOneofCase.md)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_ValueInteger"></a> ValueInteger

```csharp
public long ValueInteger { get; set; }
```

#### Property Value

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_ValueString"></a> ValueString

```csharp
public string ValueString { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_ClearValueBoolean"></a> ClearValueBoolean\(\)

```csharp
public void ClearValueBoolean()
```

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_ClearValueInteger"></a> ClearValueInteger\(\)

```csharp
public void ClearValueInteger()
```

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_ClearValueString"></a> ClearValueString\(\)

```csharp
public void ClearValueString()
```

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_Clone"></a> Clone\(\)

```csharp
public CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension Clone()
```

#### Returns

 [CMsgGCReportMetrics](Divine.Protobufs.Steam.CMsgGCReportMetrics.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.md).[MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.md).[Dimension](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension.md)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_Equals_Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_"></a> Equals\(Dimension\)

```csharp
public bool Equals(CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension other)
```

#### Parameters

`other` [CMsgGCReportMetrics](Divine.Protobufs.Steam.CMsgGCReportMetrics.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.md).[MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.md).[Dimension](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_MergeFrom_Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_"></a> MergeFrom\(Dimension\)

```csharp
public void MergeFrom(CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension other)
```

#### Parameters

`other` [CMsgGCReportMetrics](Divine.Protobufs.Steam.CMsgGCReportMetrics.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.md).[MetricEntry](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.md).[Types](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.md).[Dimension](Divine.Protobufs.Steam.CMsgGCReportMetrics.Types.MetricEntry.Types.Dimension.md)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Types_MetricEntry_Types_Dimension_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

