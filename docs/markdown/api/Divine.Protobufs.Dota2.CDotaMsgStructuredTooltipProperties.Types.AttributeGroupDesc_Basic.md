# <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Basic"></a> Class CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Basic

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Basic : IMessage<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Basic>, IEquatable<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Basic>, IDeepCloneable<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Basic>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Basic](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Basic.md)

#### Implements

IMessage<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Basic\>, 
[IEquatable<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Basic\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Basic\>, 
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
[EnumerableExtensions.In<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Basic\>\(CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Basic, params CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Basic\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Basic__ctor"></a> AttributeGroupDesc\_Basic\(\)

```csharp
public AttributeGroupDesc_Basic()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Basic__ctor_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Basic_"></a> AttributeGroupDesc\_Basic\(AttributeGroupDesc\_Basic\)

```csharp
public AttributeGroupDesc_Basic(CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Basic other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDesc\_Basic](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Basic.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Basic_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Basic_Parser"></a> Parser

```csharp
public static MessageParser<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Basic> Parser { get; }
```

#### Property Value

 MessageParser<[CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDesc\_Basic](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Basic.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Basic_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Basic_Clone"></a> Clone\(\)

```csharp
public CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Basic Clone()
```

#### Returns

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDesc\_Basic](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Basic.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Basic_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Basic_Equals_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Basic_"></a> Equals\(AttributeGroupDesc\_Basic\)

```csharp
public bool Equals(CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Basic other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDesc\_Basic](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Basic.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Basic_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Basic_MergeFrom_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Basic_"></a> MergeFrom\(AttributeGroupDesc\_Basic\)

```csharp
public void MergeFrom(CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Basic other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDesc\_Basic](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Basic.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Basic_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Basic_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Basic_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

