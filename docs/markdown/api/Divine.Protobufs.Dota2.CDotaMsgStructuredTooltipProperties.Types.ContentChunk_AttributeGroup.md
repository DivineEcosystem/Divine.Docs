# <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_ContentChunk_AttributeGroup"></a> Class CDotaMsgStructuredTooltipProperties.Types.ContentChunk\_AttributeGroup

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDotaMsgStructuredTooltipProperties.Types.ContentChunk_AttributeGroup : IMessage<CDotaMsgStructuredTooltipProperties.Types.ContentChunk_AttributeGroup>, IEquatable<CDotaMsgStructuredTooltipProperties.Types.ContentChunk_AttributeGroup>, IDeepCloneable<CDotaMsgStructuredTooltipProperties.Types.ContentChunk_AttributeGroup>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDotaMsgStructuredTooltipProperties.Types.ContentChunk\_AttributeGroup](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.ContentChunk\_AttributeGroup.md)

#### Implements

IMessage<CDotaMsgStructuredTooltipProperties.Types.ContentChunk\_AttributeGroup\>, 
[IEquatable<CDotaMsgStructuredTooltipProperties.Types.ContentChunk\_AttributeGroup\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDotaMsgStructuredTooltipProperties.Types.ContentChunk\_AttributeGroup\>, 
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
[EnumerableExtensions.In<CDotaMsgStructuredTooltipProperties.Types.ContentChunk\_AttributeGroup\>\(CDotaMsgStructuredTooltipProperties.Types.ContentChunk\_AttributeGroup, params CDotaMsgStructuredTooltipProperties.Types.ContentChunk\_AttributeGroup\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_ContentChunk_AttributeGroup__ctor"></a> ContentChunk\_AttributeGroup\(\)

```csharp
public ContentChunk_AttributeGroup()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_ContentChunk_AttributeGroup__ctor_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_ContentChunk_AttributeGroup_"></a> ContentChunk\_AttributeGroup\(ContentChunk\_AttributeGroup\)

```csharp
public ContentChunk_AttributeGroup(CDotaMsgStructuredTooltipProperties.Types.ContentChunk_AttributeGroup other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[ContentChunk\_AttributeGroup](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.ContentChunk\_AttributeGroup.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_ContentChunk_AttributeGroup_GroupsFieldNumber"></a> GroupsFieldNumber

```csharp
public const int GroupsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_ContentChunk_AttributeGroup_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_ContentChunk_AttributeGroup_Groups"></a> Groups

```csharp
public RepeatedField<CDotaMsgStructuredTooltipProperties.Types.AttributeGroup> Groups { get; }
```

#### Property Value

 RepeatedField<[CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroup](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroup.md)\>

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_ContentChunk_AttributeGroup_Parser"></a> Parser

```csharp
public static MessageParser<CDotaMsgStructuredTooltipProperties.Types.ContentChunk_AttributeGroup> Parser { get; }
```

#### Property Value

 MessageParser<[CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[ContentChunk\_AttributeGroup](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.ContentChunk\_AttributeGroup.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_ContentChunk_AttributeGroup_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_ContentChunk_AttributeGroup_Clone"></a> Clone\(\)

```csharp
public CDotaMsgStructuredTooltipProperties.Types.ContentChunk_AttributeGroup Clone()
```

#### Returns

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[ContentChunk\_AttributeGroup](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.ContentChunk\_AttributeGroup.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_ContentChunk_AttributeGroup_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_ContentChunk_AttributeGroup_Equals_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_ContentChunk_AttributeGroup_"></a> Equals\(ContentChunk\_AttributeGroup\)

```csharp
public bool Equals(CDotaMsgStructuredTooltipProperties.Types.ContentChunk_AttributeGroup other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[ContentChunk\_AttributeGroup](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.ContentChunk\_AttributeGroup.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_ContentChunk_AttributeGroup_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_ContentChunk_AttributeGroup_MergeFrom_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_ContentChunk_AttributeGroup_"></a> MergeFrom\(ContentChunk\_AttributeGroup\)

```csharp
public void MergeFrom(CDotaMsgStructuredTooltipProperties.Types.ContentChunk_AttributeGroup other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[ContentChunk\_AttributeGroup](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.ContentChunk\_AttributeGroup.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_ContentChunk_AttributeGroup_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_ContentChunk_AttributeGroup_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_ContentChunk_AttributeGroup_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

