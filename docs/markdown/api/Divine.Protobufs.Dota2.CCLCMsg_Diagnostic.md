# <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic"></a> Class CCLCMsg\_Diagnostic

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CCLCMsg_Diagnostic : IMessage<CCLCMsg_Diagnostic>, IEquatable<CCLCMsg_Diagnostic>, IDeepCloneable<CCLCMsg_Diagnostic>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CCLCMsg\_Diagnostic](Divine.Protobufs.Dota2.CCLCMsg\_Diagnostic.md)

#### Implements

IMessage<CCLCMsg\_Diagnostic\>, 
[IEquatable<CCLCMsg\_Diagnostic\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CCLCMsg\_Diagnostic\>, 
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
[EnumerableExtensions.In<CCLCMsg\_Diagnostic\>\(CCLCMsg\_Diagnostic, params CCLCMsg\_Diagnostic\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic__ctor"></a> CCLCMsg\_Diagnostic\(\)

```csharp
public CCLCMsg_Diagnostic()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic__ctor_Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_"></a> CCLCMsg\_Diagnostic\(CCLCMsg\_Diagnostic\)

```csharp
public CCLCMsg_Diagnostic(CCLCMsg_Diagnostic other)
```

#### Parameters

`other` [CCLCMsg\_Diagnostic](Divine.Protobufs.Dota2.CCLCMsg\_Diagnostic.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_DownstreamFlowFieldNumber"></a> DownstreamFlowFieldNumber

```csharp
public const int DownstreamFlowFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_PerfSamplesFieldNumber"></a> PerfSamplesFieldNumber

```csharp
public const int PerfSamplesFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_SystemSpecsFieldNumber"></a> SystemSpecsFieldNumber

```csharp
public const int SystemSpecsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_UpstreamFlowFieldNumber"></a> UpstreamFlowFieldNumber

```csharp
public const int UpstreamFlowFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_VprofReportFieldNumber"></a> VprofReportFieldNumber

```csharp
public const int VprofReportFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_DownstreamFlow"></a> DownstreamFlow

```csharp
public CMsgSource2NetworkFlowQuality DownstreamFlow { get; set; }
```

#### Property Value

 [CMsgSource2NetworkFlowQuality](Divine.Protobufs.Dota2.CMsgSource2NetworkFlowQuality.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_Parser"></a> Parser

```csharp
public static MessageParser<CCLCMsg_Diagnostic> Parser { get; }
```

#### Property Value

 MessageParser<[CCLCMsg\_Diagnostic](Divine.Protobufs.Dota2.CCLCMsg\_Diagnostic.md)\>

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_PerfSamples"></a> PerfSamples

```csharp
public RepeatedField<CMsgSource2FramePerfSample> PerfSamples { get; }
```

#### Property Value

 RepeatedField<[CMsgSource2FramePerfSample](Divine.Protobufs.Dota2.CMsgSource2FramePerfSample.md)\>

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_SystemSpecs"></a> SystemSpecs

```csharp
public CMsgSource2SystemSpecs SystemSpecs { get; set; }
```

#### Property Value

 [CMsgSource2SystemSpecs](Divine.Protobufs.Dota2.CMsgSource2SystemSpecs.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_UpstreamFlow"></a> UpstreamFlow

```csharp
public CMsgSource2NetworkFlowQuality UpstreamFlow { get; set; }
```

#### Property Value

 [CMsgSource2NetworkFlowQuality](Divine.Protobufs.Dota2.CMsgSource2NetworkFlowQuality.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_VprofReport"></a> VprofReport

```csharp
public CMsgSource2VProfLiteReport VprofReport { get; set; }
```

#### Property Value

 [CMsgSource2VProfLiteReport](Divine.Protobufs.Dota2.CMsgSource2VProfLiteReport.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_Clone"></a> Clone\(\)

```csharp
public CCLCMsg_Diagnostic Clone()
```

#### Returns

 [CCLCMsg\_Diagnostic](Divine.Protobufs.Dota2.CCLCMsg\_Diagnostic.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_Equals_Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_"></a> Equals\(CCLCMsg\_Diagnostic\)

```csharp
public bool Equals(CCLCMsg_Diagnostic other)
```

#### Parameters

`other` [CCLCMsg\_Diagnostic](Divine.Protobufs.Dota2.CCLCMsg\_Diagnostic.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_MergeFrom_Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_"></a> MergeFrom\(CCLCMsg\_Diagnostic\)

```csharp
public void MergeFrom(CCLCMsg_Diagnostic other)
```

#### Parameters

`other` [CCLCMsg\_Diagnostic](Divine.Protobufs.Dota2.CCLCMsg\_Diagnostic.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_Diagnostic_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

