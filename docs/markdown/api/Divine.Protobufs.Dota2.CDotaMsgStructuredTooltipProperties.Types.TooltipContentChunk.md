# <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk"></a> Class CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk : IMessage<CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk>, IEquatable<CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk>, IDeepCloneable<CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk.md)

#### Implements

IMessage<CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk\>, 
[IEquatable<CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk\>, 
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
[EnumerableExtensions.In<CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk\>\(CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk, params CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk__ctor"></a> TooltipContentChunk\(\)

```csharp
public TooltipContentChunk()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk__ctor_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk_"></a> TooltipContentChunk\(TooltipContentChunk\)

```csharp
public TooltipContentChunk(CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[TooltipContentChunk](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk_AttributeGroupFieldNumber"></a> AttributeGroupFieldNumber

```csharp
public const int AttributeGroupFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk_AttributeGroup"></a> AttributeGroup

```csharp
public CDotaMsgStructuredTooltipProperties.Types.ContentChunk_AttributeGroup AttributeGroup { get; set; }
```

#### Property Value

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[ContentChunk\_AttributeGroup](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.ContentChunk\_AttributeGroup.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk_ContentChunkCase"></a> ContentChunkCase

```csharp
public CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk.ContentChunkOneofCase ContentChunkCase { get; }
```

#### Property Value

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[TooltipContentChunk](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk.md).[ContentChunkOneofCase](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk.ContentChunkOneofCase.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk_Parser"></a> Parser

```csharp
public static MessageParser<CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk> Parser { get; }
```

#### Property Value

 MessageParser<[CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[TooltipContentChunk](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk_ClearContentChunk"></a> ClearContentChunk\(\)

```csharp
public void ClearContentChunk()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk_Clone"></a> Clone\(\)

```csharp
public CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk Clone()
```

#### Returns

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[TooltipContentChunk](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk_Equals_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk_"></a> Equals\(TooltipContentChunk\)

```csharp
public bool Equals(CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[TooltipContentChunk](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk_MergeFrom_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk_"></a> MergeFrom\(TooltipContentChunk\)

```csharp
public void MergeFrom(CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[TooltipContentChunk](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_TooltipContentChunk_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

