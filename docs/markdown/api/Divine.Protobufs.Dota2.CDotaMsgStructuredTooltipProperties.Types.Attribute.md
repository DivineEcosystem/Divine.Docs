# <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute"></a> Class CDotaMsgStructuredTooltipProperties.Types.Attribute

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDotaMsgStructuredTooltipProperties.Types.Attribute : IMessage<CDotaMsgStructuredTooltipProperties.Types.Attribute>, IEquatable<CDotaMsgStructuredTooltipProperties.Types.Attribute>, IDeepCloneable<CDotaMsgStructuredTooltipProperties.Types.Attribute>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDotaMsgStructuredTooltipProperties.Types.Attribute](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.Attribute.md)

#### Implements

IMessage<CDotaMsgStructuredTooltipProperties.Types.Attribute\>, 
[IEquatable<CDotaMsgStructuredTooltipProperties.Types.Attribute\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDotaMsgStructuredTooltipProperties.Types.Attribute\>, 
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
[EnumerableExtensions.In<CDotaMsgStructuredTooltipProperties.Types.Attribute\>\(CDotaMsgStructuredTooltipProperties.Types.Attribute, params CDotaMsgStructuredTooltipProperties.Types.Attribute\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute__ctor"></a> Attribute\(\)

```csharp
public Attribute()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute__ctor_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_"></a> Attribute\(Attribute\)

```csharp
public Attribute(CDotaMsgStructuredTooltipProperties.Types.Attribute other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[Attribute](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.Attribute.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_InternalNameFieldNumber"></a> InternalNameFieldNumber

```csharp
public const int InternalNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_LocalizedNameTextFieldNumber"></a> LocalizedNameTextFieldNumber

```csharp
public const int LocalizedNameTextFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_ResolvedTypeFieldNumber"></a> ResolvedTypeFieldNumber

```csharp
public const int ResolvedTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_HasInternalName"></a> HasInternalName

```csharp
public bool HasInternalName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_HasLocalizedNameText"></a> HasLocalizedNameText

```csharp
public bool HasLocalizedNameText { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_HasResolvedType"></a> HasResolvedType

```csharp
public bool HasResolvedType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_InternalName"></a> InternalName

```csharp
public string InternalName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_LocalizedNameText"></a> LocalizedNameText

```csharp
public string LocalizedNameText { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_Parser"></a> Parser

```csharp
public static MessageParser<CDotaMsgStructuredTooltipProperties.Types.Attribute> Parser { get; }
```

#### Property Value

 MessageParser<[CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[Attribute](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.Attribute.md)\>

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_ResolvedType"></a> ResolvedType

```csharp
public CDotaMsgStructuredTooltipProperties.Types.EAttributeType ResolvedType { get; set; }
```

#### Property Value

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[EAttributeType](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.EAttributeType.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_Value"></a> Value

```csharp
public CDotaMsgStructuredTooltipProperties.Types.AttributeValue Value { get; set; }
```

#### Property Value

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeValue](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeValue.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_ClearInternalName"></a> ClearInternalName\(\)

```csharp
public void ClearInternalName()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_ClearLocalizedNameText"></a> ClearLocalizedNameText\(\)

```csharp
public void ClearLocalizedNameText()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_ClearResolvedType"></a> ClearResolvedType\(\)

```csharp
public void ClearResolvedType()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_Clone"></a> Clone\(\)

```csharp
public CDotaMsgStructuredTooltipProperties.Types.Attribute Clone()
```

#### Returns

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[Attribute](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.Attribute.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_Equals_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_"></a> Equals\(Attribute\)

```csharp
public bool Equals(CDotaMsgStructuredTooltipProperties.Types.Attribute other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[Attribute](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.Attribute.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_MergeFrom_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_"></a> MergeFrom\(Attribute\)

```csharp
public void MergeFrom(CDotaMsgStructuredTooltipProperties.Types.Attribute other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[Attribute](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.Attribute.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_Attribute_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

