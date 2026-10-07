# <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport"></a> Class CMsgShowcaseReport

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseReport : IMessage<CMsgShowcaseReport>, IEquatable<CMsgShowcaseReport>, IDeepCloneable<CMsgShowcaseReport>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseReport](Divine.Protobufs.Dota2.CMsgShowcaseReport.md)

#### Implements

IMessage<CMsgShowcaseReport\>, 
[IEquatable<CMsgShowcaseReport\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseReport\>, 
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
[EnumerableExtensions.In<CMsgShowcaseReport\>\(CMsgShowcaseReport, params CMsgShowcaseReport\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport__ctor"></a> CMsgShowcaseReport\(\)

```csharp
public CMsgShowcaseReport()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport__ctor_Divine_Protobufs_Dota2_CMsgShowcaseReport_"></a> CMsgShowcaseReport\(CMsgShowcaseReport\)

```csharp
public CMsgShowcaseReport(CMsgShowcaseReport other)
```

#### Parameters

`other` [CMsgShowcaseReport](Divine.Protobufs.Dota2.CMsgShowcaseReport.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_ReportCommentFieldNumber"></a> ReportCommentFieldNumber

```csharp
public const int ReportCommentFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_ReporterAccountIdFieldNumber"></a> ReporterAccountIdFieldNumber

```csharp
public const int ReporterAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_ReportTimestampFieldNumber"></a> ReportTimestampFieldNumber

```csharp
public const int ReportTimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_ShowcaseTypeFieldNumber"></a> ShowcaseTypeFieldNumber

```csharp
public const int ShowcaseTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_HasReportComment"></a> HasReportComment

```csharp
public bool HasReportComment { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_HasReporterAccountId"></a> HasReporterAccountId

```csharp
public bool HasReporterAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_HasReportTimestamp"></a> HasReportTimestamp

```csharp
public bool HasReportTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_HasShowcaseType"></a> HasShowcaseType

```csharp
public bool HasShowcaseType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseReport> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseReport](Divine.Protobufs.Dota2.CMsgShowcaseReport.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_ReportComment"></a> ReportComment

```csharp
public string ReportComment { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_ReporterAccountId"></a> ReporterAccountId

```csharp
public uint ReporterAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_ReportTimestamp"></a> ReportTimestamp

```csharp
public uint ReportTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_ShowcaseType"></a> ShowcaseType

```csharp
public EShowcaseType ShowcaseType { get; set; }
```

#### Property Value

 [EShowcaseType](Divine.Protobufs.Dota2.EShowcaseType.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_ClearReportComment"></a> ClearReportComment\(\)

```csharp
public void ClearReportComment()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_ClearReporterAccountId"></a> ClearReporterAccountId\(\)

```csharp
public void ClearReporterAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_ClearReportTimestamp"></a> ClearReportTimestamp\(\)

```csharp
public void ClearReportTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_ClearShowcaseType"></a> ClearShowcaseType\(\)

```csharp
public void ClearShowcaseType()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseReport Clone()
```

#### Returns

 [CMsgShowcaseReport](Divine.Protobufs.Dota2.CMsgShowcaseReport.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_Equals_Divine_Protobufs_Dota2_CMsgShowcaseReport_"></a> Equals\(CMsgShowcaseReport\)

```csharp
public bool Equals(CMsgShowcaseReport other)
```

#### Parameters

`other` [CMsgShowcaseReport](Divine.Protobufs.Dota2.CMsgShowcaseReport.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseReport_"></a> MergeFrom\(CMsgShowcaseReport\)

```csharp
public void MergeFrom(CMsgShowcaseReport other)
```

#### Parameters

`other` [CMsgShowcaseReport](Divine.Protobufs.Dota2.CMsgShowcaseReport.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReport_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

