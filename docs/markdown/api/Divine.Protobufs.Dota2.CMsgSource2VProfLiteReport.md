# <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport"></a> Class CMsgSource2VProfLiteReport

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSource2VProfLiteReport : IMessage<CMsgSource2VProfLiteReport>, IEquatable<CMsgSource2VProfLiteReport>, IDeepCloneable<CMsgSource2VProfLiteReport>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSource2VProfLiteReport](Divine.Protobufs.Dota2.CMsgSource2VProfLiteReport.md)

#### Implements

IMessage<CMsgSource2VProfLiteReport\>, 
[IEquatable<CMsgSource2VProfLiteReport\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSource2VProfLiteReport\>, 
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
[EnumerableExtensions.In<CMsgSource2VProfLiteReport\>\(CMsgSource2VProfLiteReport, params CMsgSource2VProfLiteReport\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport__ctor"></a> CMsgSource2VProfLiteReport\(\)

```csharp
public CMsgSource2VProfLiteReport()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport__ctor_Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_"></a> CMsgSource2VProfLiteReport\(CMsgSource2VProfLiteReport\)

```csharp
public CMsgSource2VProfLiteReport(CMsgSource2VProfLiteReport other)
```

#### Parameters

`other` [CMsgSource2VProfLiteReport](Divine.Protobufs.Dota2.CMsgSource2VProfLiteReport.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_DiscardedFramesFieldNumber"></a> DiscardedFramesFieldNumber

```csharp
public const int DiscardedFramesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_ItemsFieldNumber"></a> ItemsFieldNumber

```csharp
public const int ItemsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_TotalFieldNumber"></a> TotalFieldNumber

```csharp
public const int TotalFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_DiscardedFrames"></a> DiscardedFrames

```csharp
public uint DiscardedFrames { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_HasDiscardedFrames"></a> HasDiscardedFrames

```csharp
public bool HasDiscardedFrames { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_Items"></a> Items

```csharp
public RepeatedField<CMsgSource2VProfLiteReportItem> Items { get; }
```

#### Property Value

 RepeatedField<[CMsgSource2VProfLiteReportItem](Divine.Protobufs.Dota2.CMsgSource2VProfLiteReportItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSource2VProfLiteReport> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSource2VProfLiteReport](Divine.Protobufs.Dota2.CMsgSource2VProfLiteReport.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_Total"></a> Total

```csharp
public CMsgSource2VProfLiteReportItem Total { get; set; }
```

#### Property Value

 [CMsgSource2VProfLiteReportItem](Divine.Protobufs.Dota2.CMsgSource2VProfLiteReportItem.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_ClearDiscardedFrames"></a> ClearDiscardedFrames\(\)

```csharp
public void ClearDiscardedFrames()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_Clone"></a> Clone\(\)

```csharp
public CMsgSource2VProfLiteReport Clone()
```

#### Returns

 [CMsgSource2VProfLiteReport](Divine.Protobufs.Dota2.CMsgSource2VProfLiteReport.md)

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_Equals_Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_"></a> Equals\(CMsgSource2VProfLiteReport\)

```csharp
public bool Equals(CMsgSource2VProfLiteReport other)
```

#### Parameters

`other` [CMsgSource2VProfLiteReport](Divine.Protobufs.Dota2.CMsgSource2VProfLiteReport.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_MergeFrom_Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_"></a> MergeFrom\(CMsgSource2VProfLiteReport\)

```csharp
public void MergeFrom(CMsgSource2VProfLiteReport other)
```

#### Parameters

`other` [CMsgSource2VProfLiteReport](Divine.Protobufs.Dota2.CMsgSource2VProfLiteReport.md)

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSource2VProfLiteReport_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

