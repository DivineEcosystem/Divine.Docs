# <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample"></a> Class CMsgSource2FramePerfSample

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSource2FramePerfSample : IMessage<CMsgSource2FramePerfSample>, IEquatable<CMsgSource2FramePerfSample>, IDeepCloneable<CMsgSource2FramePerfSample>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSource2FramePerfSample](Divine.Protobufs.Dota2.CMsgSource2FramePerfSample.md)

#### Implements

IMessage<CMsgSource2FramePerfSample\>, 
[IEquatable<CMsgSource2FramePerfSample\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSource2FramePerfSample\>, 
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
[EnumerableExtensions.In<CMsgSource2FramePerfSample\>\(CMsgSource2FramePerfSample, params CMsgSource2FramePerfSample\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample__ctor"></a> CMsgSource2FramePerfSample\(\)

```csharp
public CMsgSource2FramePerfSample()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample__ctor_Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_"></a> CMsgSource2FramePerfSample\(CMsgSource2FramePerfSample\)

```csharp
public CMsgSource2FramePerfSample(CMsgSource2FramePerfSample other)
```

#### Parameters

`other` [CMsgSource2FramePerfSample](Divine.Protobufs.Dota2.CMsgSource2FramePerfSample.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_FrameTimeMsFieldNumber"></a> FrameTimeMsFieldNumber

```csharp
public const int FrameTimeMsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_GpuTimeMsFieldNumber"></a> GpuTimeMsFieldNumber

```csharp
public const int GpuTimeMsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_TagsFieldNumber"></a> TagsFieldNumber

```csharp
public const int TagsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_FrameTimeMs"></a> FrameTimeMs

```csharp
public float FrameTimeMs { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_GpuTimeMs"></a> GpuTimeMs

```csharp
public float GpuTimeMs { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_HasFrameTimeMs"></a> HasFrameTimeMs

```csharp
public bool HasFrameTimeMs { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_HasGpuTimeMs"></a> HasGpuTimeMs

```csharp
public bool HasGpuTimeMs { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSource2FramePerfSample> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSource2FramePerfSample](Divine.Protobufs.Dota2.CMsgSource2FramePerfSample.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_Tags"></a> Tags

```csharp
public RepeatedField<CMsgSource2FramePerfSample.Types.Tag> Tags { get; }
```

#### Property Value

 RepeatedField<[CMsgSource2FramePerfSample](Divine.Protobufs.Dota2.CMsgSource2FramePerfSample.md).[Types](Divine.Protobufs.Dota2.CMsgSource2FramePerfSample.Types.md).[Tag](Divine.Protobufs.Dota2.CMsgSource2FramePerfSample.Types.Tag.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_ClearFrameTimeMs"></a> ClearFrameTimeMs\(\)

```csharp
public void ClearFrameTimeMs()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_ClearGpuTimeMs"></a> ClearGpuTimeMs\(\)

```csharp
public void ClearGpuTimeMs()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_Clone"></a> Clone\(\)

```csharp
public CMsgSource2FramePerfSample Clone()
```

#### Returns

 [CMsgSource2FramePerfSample](Divine.Protobufs.Dota2.CMsgSource2FramePerfSample.md)

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_Equals_Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_"></a> Equals\(CMsgSource2FramePerfSample\)

```csharp
public bool Equals(CMsgSource2FramePerfSample other)
```

#### Parameters

`other` [CMsgSource2FramePerfSample](Divine.Protobufs.Dota2.CMsgSource2FramePerfSample.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_MergeFrom_Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_"></a> MergeFrom\(CMsgSource2FramePerfSample\)

```csharp
public void MergeFrom(CMsgSource2FramePerfSample other)
```

#### Parameters

`other` [CMsgSource2FramePerfSample](Divine.Protobufs.Dota2.CMsgSource2FramePerfSample.md)

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSource2FramePerfSample_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

