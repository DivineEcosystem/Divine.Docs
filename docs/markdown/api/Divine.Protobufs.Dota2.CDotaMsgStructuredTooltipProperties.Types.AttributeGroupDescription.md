# <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription"></a> Class CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription : IMessage<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription>, IEquatable<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription>, IDeepCloneable<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription.md)

#### Implements

IMessage<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription\>, 
[IEquatable<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription\>, 
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
[EnumerableExtensions.In<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription\>\(CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription, params CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription__ctor"></a> AttributeGroupDescription\(\)

```csharp
public AttributeGroupDescription()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription__ctor_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_"></a> AttributeGroupDescription\(AttributeGroupDescription\)

```csharp
public AttributeGroupDescription(CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDescription](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_BasicFieldNumber"></a> BasicFieldNumber

```csharp
public const int BasicFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_CharacteristicsFieldNumber"></a> CharacteristicsFieldNumber

```csharp
public const int CharacteristicsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_SpecificFieldNumber"></a> SpecificFieldNumber

```csharp
public const int SpecificFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_AttrGroupDescCase"></a> AttrGroupDescCase

```csharp
public CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription.AttrGroupDescOneofCase AttrGroupDescCase { get; }
```

#### Property Value

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDescription](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription.md).[AttrGroupDescOneofCase](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription.AttrGroupDescOneofCase.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_Basic"></a> Basic

```csharp
public CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Basic Basic { get; set; }
```

#### Property Value

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDesc\_Basic](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Basic.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_Characteristics"></a> Characteristics

```csharp
public CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Basic Characteristics { get; set; }
```

#### Property Value

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDesc\_Basic](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Basic.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_Parser"></a> Parser

```csharp
public static MessageParser<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription> Parser { get; }
```

#### Property Value

 MessageParser<[CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDescription](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription.md)\>

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_Specific"></a> Specific

```csharp
public CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Specific Specific { get; set; }
```

#### Property Value

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDesc\_Specific](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Specific.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_ClearAttrGroupDesc"></a> ClearAttrGroupDesc\(\)

```csharp
public void ClearAttrGroupDesc()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_Clone"></a> Clone\(\)

```csharp
public CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription Clone()
```

#### Returns

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDescription](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_Equals_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_"></a> Equals\(AttributeGroupDescription\)

```csharp
public bool Equals(CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDescription](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_MergeFrom_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_"></a> MergeFrom\(AttributeGroupDescription\)

```csharp
public void MergeFrom(CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDescription](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDescription.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDescription_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

