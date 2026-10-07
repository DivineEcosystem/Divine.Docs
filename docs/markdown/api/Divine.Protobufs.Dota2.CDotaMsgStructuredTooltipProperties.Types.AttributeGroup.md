# <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup"></a> Class CDotaMsgStructuredTooltipProperties.Types.AttributeGroup

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDotaMsgStructuredTooltipProperties.Types.AttributeGroup : IMessage<CDotaMsgStructuredTooltipProperties.Types.AttributeGroup>, IEquatable<CDotaMsgStructuredTooltipProperties.Types.AttributeGroup>, IDeepCloneable<CDotaMsgStructuredTooltipProperties.Types.AttributeGroup>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDotaMsgStructuredTooltipProperties.Types.AttributeGroup](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroup.md)

#### Implements

IMessage<CDotaMsgStructuredTooltipProperties.Types.AttributeGroup\>, 
[IEquatable<CDotaMsgStructuredTooltipProperties.Types.AttributeGroup\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDotaMsgStructuredTooltipProperties.Types.AttributeGroup\>, 
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
[EnumerableExtensions.In<CDotaMsgStructuredTooltipProperties.Types.AttributeGroup\>\(CDotaMsgStructuredTooltipProperties.Types.AttributeGroup, params CDotaMsgStructuredTooltipProperties.Types.AttributeGroup\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup__ctor"></a> AttributeGroup\(\)

```csharp
public AttributeGroup()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup__ctor_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup_"></a> AttributeGroup\(AttributeGroup\)

```csharp
public AttributeGroup(CDotaMsgStructuredTooltipProperties.Types.AttributeGroup other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroup](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroup.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup_AttributesFieldNumber"></a> AttributesFieldNumber

```csharp
public const int AttributesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup_DescFieldNumber"></a> DescFieldNumber

```csharp
public const int DescFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup_Attributes"></a> Attributes

```csharp
public RepeatedField<CDotaMsgStructuredTooltipProperties.Types.Attribute> Attributes { get; }
```

#### Property Value

 RepeatedField<[CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[Attribute](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.Attribute.md)\>

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup_Desc"></a> Desc

```csharp
public CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription Desc { get; set; }
```

#### Property Value

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDescription](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup_Parser"></a> Parser

```csharp
public static MessageParser<CDotaMsgStructuredTooltipProperties.Types.AttributeGroup> Parser { get; }
```

#### Property Value

 MessageParser<[CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroup](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroup.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup_Clone"></a> Clone\(\)

```csharp
public CDotaMsgStructuredTooltipProperties.Types.AttributeGroup Clone()
```

#### Returns

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroup](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroup.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup_Equals_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup_"></a> Equals\(AttributeGroup\)

```csharp
public bool Equals(CDotaMsgStructuredTooltipProperties.Types.AttributeGroup other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroup](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroup.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup_MergeFrom_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup_"></a> MergeFrom\(AttributeGroup\)

```csharp
public void MergeFrom(CDotaMsgStructuredTooltipProperties.Types.AttributeGroup other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroup](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroup.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroup_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

