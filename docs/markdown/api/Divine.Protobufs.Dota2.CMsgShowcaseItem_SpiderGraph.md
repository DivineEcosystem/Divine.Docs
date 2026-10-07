# <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_SpiderGraph"></a> Class CMsgShowcaseItem\_SpiderGraph

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseItem_SpiderGraph : IMessage<CMsgShowcaseItem_SpiderGraph>, IEquatable<CMsgShowcaseItem_SpiderGraph>, IDeepCloneable<CMsgShowcaseItem_SpiderGraph>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseItem\_SpiderGraph](Divine.Protobufs.Dota2.CMsgShowcaseItem\_SpiderGraph.md)

#### Implements

IMessage<CMsgShowcaseItem\_SpiderGraph\>, 
[IEquatable<CMsgShowcaseItem\_SpiderGraph\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseItem\_SpiderGraph\>, 
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
[EnumerableExtensions.In<CMsgShowcaseItem\_SpiderGraph\>\(CMsgShowcaseItem\_SpiderGraph, params CMsgShowcaseItem\_SpiderGraph\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_SpiderGraph__ctor"></a> CMsgShowcaseItem\_SpiderGraph\(\)

```csharp
public CMsgShowcaseItem_SpiderGraph()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_SpiderGraph__ctor_Divine_Protobufs_Dota2_CMsgShowcaseItem_SpiderGraph_"></a> CMsgShowcaseItem\_SpiderGraph\(CMsgShowcaseItem\_SpiderGraph\)

```csharp
public CMsgShowcaseItem_SpiderGraph(CMsgShowcaseItem_SpiderGraph other)
```

#### Parameters

`other` [CMsgShowcaseItem\_SpiderGraph](Divine.Protobufs.Dota2.CMsgShowcaseItem\_SpiderGraph.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_SpiderGraph_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_SpiderGraph_Data"></a> Data

```csharp
public CMsgShowcaseItem_SpiderGraph.Types.Data Data { get; set; }
```

#### Property Value

 [CMsgShowcaseItem\_SpiderGraph](Divine.Protobufs.Dota2.CMsgShowcaseItem\_SpiderGraph.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_SpiderGraph.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_SpiderGraph.Types.Data.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_SpiderGraph_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_SpiderGraph_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseItem_SpiderGraph> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseItem\_SpiderGraph](Divine.Protobufs.Dota2.CMsgShowcaseItem\_SpiderGraph.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_SpiderGraph_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_SpiderGraph_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseItem_SpiderGraph Clone()
```

#### Returns

 [CMsgShowcaseItem\_SpiderGraph](Divine.Protobufs.Dota2.CMsgShowcaseItem\_SpiderGraph.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_SpiderGraph_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_SpiderGraph_Equals_Divine_Protobufs_Dota2_CMsgShowcaseItem_SpiderGraph_"></a> Equals\(CMsgShowcaseItem\_SpiderGraph\)

```csharp
public bool Equals(CMsgShowcaseItem_SpiderGraph other)
```

#### Parameters

`other` [CMsgShowcaseItem\_SpiderGraph](Divine.Protobufs.Dota2.CMsgShowcaseItem\_SpiderGraph.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_SpiderGraph_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_SpiderGraph_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseItem_SpiderGraph_"></a> MergeFrom\(CMsgShowcaseItem\_SpiderGraph\)

```csharp
public void MergeFrom(CMsgShowcaseItem_SpiderGraph other)
```

#### Parameters

`other` [CMsgShowcaseItem\_SpiderGraph](Divine.Protobufs.Dota2.CMsgShowcaseItem\_SpiderGraph.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_SpiderGraph_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_SpiderGraph_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_SpiderGraph_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

