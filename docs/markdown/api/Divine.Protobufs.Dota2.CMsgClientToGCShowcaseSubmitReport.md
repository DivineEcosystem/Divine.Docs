# <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport"></a> Class CMsgClientToGCShowcaseSubmitReport

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCShowcaseSubmitReport : IMessage<CMsgClientToGCShowcaseSubmitReport>, IEquatable<CMsgClientToGCShowcaseSubmitReport>, IDeepCloneable<CMsgClientToGCShowcaseSubmitReport>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCShowcaseSubmitReport](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSubmitReport.md)

#### Implements

IMessage<CMsgClientToGCShowcaseSubmitReport\>, 
[IEquatable<CMsgClientToGCShowcaseSubmitReport\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCShowcaseSubmitReport\>, 
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
[EnumerableExtensions.In<CMsgClientToGCShowcaseSubmitReport\>\(CMsgClientToGCShowcaseSubmitReport, params CMsgClientToGCShowcaseSubmitReport\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport__ctor"></a> CMsgClientToGCShowcaseSubmitReport\(\)

```csharp
public CMsgClientToGCShowcaseSubmitReport()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport__ctor_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_"></a> CMsgClientToGCShowcaseSubmitReport\(CMsgClientToGCShowcaseSubmitReport\)

```csharp
public CMsgClientToGCShowcaseSubmitReport(CMsgClientToGCShowcaseSubmitReport other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseSubmitReport](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSubmitReport.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_ReportCommentFieldNumber"></a> ReportCommentFieldNumber

```csharp
public const int ReportCommentFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_ShowcaseTypeFieldNumber"></a> ShowcaseTypeFieldNumber

```csharp
public const int ShowcaseTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_HasReportComment"></a> HasReportComment

```csharp
public bool HasReportComment { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_HasShowcaseType"></a> HasShowcaseType

```csharp
public bool HasShowcaseType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCShowcaseSubmitReport> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCShowcaseSubmitReport](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSubmitReport.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_ReportComment"></a> ReportComment

```csharp
public string ReportComment { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_ShowcaseType"></a> ShowcaseType

```csharp
public EShowcaseType ShowcaseType { get; set; }
```

#### Property Value

 [EShowcaseType](Divine.Protobufs.Dota2.EShowcaseType.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_ClearReportComment"></a> ClearReportComment\(\)

```csharp
public void ClearReportComment()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_ClearShowcaseType"></a> ClearShowcaseType\(\)

```csharp
public void ClearShowcaseType()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCShowcaseSubmitReport Clone()
```

#### Returns

 [CMsgClientToGCShowcaseSubmitReport](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSubmitReport.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_Equals_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_"></a> Equals\(CMsgClientToGCShowcaseSubmitReport\)

```csharp
public bool Equals(CMsgClientToGCShowcaseSubmitReport other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseSubmitReport](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSubmitReport.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_"></a> MergeFrom\(CMsgClientToGCShowcaseSubmitReport\)

```csharp
public void MergeFrom(CMsgClientToGCShowcaseSubmitReport other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseSubmitReport](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSubmitReport.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReport_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

