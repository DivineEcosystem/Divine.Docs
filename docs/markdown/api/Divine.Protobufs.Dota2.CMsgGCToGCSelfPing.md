# <a id="Divine_Protobufs_Dota2_CMsgGCToGCSelfPing"></a> Class CMsgGCToGCSelfPing

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCSelfPing : IMessage<CMsgGCToGCSelfPing>, IEquatable<CMsgGCToGCSelfPing>, IDeepCloneable<CMsgGCToGCSelfPing>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCSelfPing](Divine.Protobufs.Dota2.CMsgGCToGCSelfPing.md)

#### Implements

IMessage<CMsgGCToGCSelfPing\>, 
[IEquatable<CMsgGCToGCSelfPing\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCSelfPing\>, 
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
[EnumerableExtensions.In<CMsgGCToGCSelfPing\>\(CMsgGCToGCSelfPing, params CMsgGCToGCSelfPing\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSelfPing__ctor"></a> CMsgGCToGCSelfPing\(\)

```csharp
public CMsgGCToGCSelfPing()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSelfPing__ctor_Divine_Protobufs_Dota2_CMsgGCToGCSelfPing_"></a> CMsgGCToGCSelfPing\(CMsgGCToGCSelfPing\)

```csharp
public CMsgGCToGCSelfPing(CMsgGCToGCSelfPing other)
```

#### Parameters

`other` [CMsgGCToGCSelfPing](Divine.Protobufs.Dota2.CMsgGCToGCSelfPing.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSelfPing_SampleIdFieldNumber"></a> SampleIdFieldNumber

```csharp
public const int SampleIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSelfPing_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSelfPing_HasSampleId"></a> HasSampleId

```csharp
public bool HasSampleId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSelfPing_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCSelfPing> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCSelfPing](Divine.Protobufs.Dota2.CMsgGCToGCSelfPing.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSelfPing_SampleId"></a> SampleId

```csharp
public uint SampleId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSelfPing_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSelfPing_ClearSampleId"></a> ClearSampleId\(\)

```csharp
public void ClearSampleId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSelfPing_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCSelfPing Clone()
```

#### Returns

 [CMsgGCToGCSelfPing](Divine.Protobufs.Dota2.CMsgGCToGCSelfPing.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSelfPing_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSelfPing_Equals_Divine_Protobufs_Dota2_CMsgGCToGCSelfPing_"></a> Equals\(CMsgGCToGCSelfPing\)

```csharp
public bool Equals(CMsgGCToGCSelfPing other)
```

#### Parameters

`other` [CMsgGCToGCSelfPing](Divine.Protobufs.Dota2.CMsgGCToGCSelfPing.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSelfPing_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSelfPing_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCSelfPing_"></a> MergeFrom\(CMsgGCToGCSelfPing\)

```csharp
public void MergeFrom(CMsgGCToGCSelfPing other)
```

#### Parameters

`other` [CMsgGCToGCSelfPing](Divine.Protobufs.Dota2.CMsgGCToGCSelfPing.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSelfPing_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSelfPing_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSelfPing_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

