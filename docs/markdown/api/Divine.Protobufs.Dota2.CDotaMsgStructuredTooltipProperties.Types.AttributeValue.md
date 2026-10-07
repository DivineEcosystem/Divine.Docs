# <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue"></a> Class CDotaMsgStructuredTooltipProperties.Types.AttributeValue

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDotaMsgStructuredTooltipProperties.Types.AttributeValue : IMessage<CDotaMsgStructuredTooltipProperties.Types.AttributeValue>, IEquatable<CDotaMsgStructuredTooltipProperties.Types.AttributeValue>, IDeepCloneable<CDotaMsgStructuredTooltipProperties.Types.AttributeValue>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDotaMsgStructuredTooltipProperties.Types.AttributeValue](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeValue.md)

#### Implements

IMessage<CDotaMsgStructuredTooltipProperties.Types.AttributeValue\>, 
[IEquatable<CDotaMsgStructuredTooltipProperties.Types.AttributeValue\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDotaMsgStructuredTooltipProperties.Types.AttributeValue\>, 
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
[EnumerableExtensions.In<CDotaMsgStructuredTooltipProperties.Types.AttributeValue\>\(CDotaMsgStructuredTooltipProperties.Types.AttributeValue, params CDotaMsgStructuredTooltipProperties.Types.AttributeValue\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue__ctor"></a> AttributeValue\(\)

```csharp
public AttributeValue()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue__ctor_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_"></a> AttributeValue\(AttributeValue\)

```csharp
public AttributeValue(CDotaMsgStructuredTooltipProperties.Types.AttributeValue other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeValue](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeValue.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_DeltaFieldNumber"></a> DeltaFieldNumber

```csharp
public const int DeltaFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_SingleFieldNumber"></a> SingleFieldNumber

```csharp
public const int SingleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_VariableFieldNumber"></a> VariableFieldNumber

```csharp
public const int VariableFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_AttrValueCase"></a> AttrValueCase

```csharp
public CDotaMsgStructuredTooltipProperties.Types.AttributeValue.AttrValueOneofCase AttrValueCase { get; }
```

#### Property Value

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeValue](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeValue.md).[AttrValueOneofCase](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeValue.AttrValueOneofCase.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Delta"></a> Delta

```csharp
public CDotaMsgStructuredTooltipProperties.Types.AttributeValue_Delta Delta { get; set; }
```

#### Property Value

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeValue\_Delta](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeValue\_Delta.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Parser"></a> Parser

```csharp
public static MessageParser<CDotaMsgStructuredTooltipProperties.Types.AttributeValue> Parser { get; }
```

#### Property Value

 MessageParser<[CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeValue](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeValue.md)\>

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single"></a> Single

```csharp
public CDotaMsgStructuredTooltipProperties.Types.AttributeValue_Single Single { get; set; }
```

#### Property Value

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeValue\_Single](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeValue\_Single.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Variable"></a> Variable

```csharp
public CDotaMsgStructuredTooltipProperties.Types.AttributeValue_Variable Variable { get; set; }
```

#### Property Value

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeValue\_Variable](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeValue\_Variable.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_ClearAttrValue"></a> ClearAttrValue\(\)

```csharp
public void ClearAttrValue()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Clone"></a> Clone\(\)

```csharp
public CDotaMsgStructuredTooltipProperties.Types.AttributeValue Clone()
```

#### Returns

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeValue](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeValue.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Equals_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_"></a> Equals\(AttributeValue\)

```csharp
public bool Equals(CDotaMsgStructuredTooltipProperties.Types.AttributeValue other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeValue](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeValue.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_MergeFrom_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_"></a> MergeFrom\(AttributeValue\)

```csharp
public void MergeFrom(CDotaMsgStructuredTooltipProperties.Types.AttributeValue other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeValue](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeValue.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

