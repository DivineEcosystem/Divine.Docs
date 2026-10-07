# <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single"></a> Class CDotaMsgStructuredTooltipProperties.Types.AttributeValue\_Single

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDotaMsgStructuredTooltipProperties.Types.AttributeValue_Single : IMessage<CDotaMsgStructuredTooltipProperties.Types.AttributeValue_Single>, IEquatable<CDotaMsgStructuredTooltipProperties.Types.AttributeValue_Single>, IDeepCloneable<CDotaMsgStructuredTooltipProperties.Types.AttributeValue_Single>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDotaMsgStructuredTooltipProperties.Types.AttributeValue\_Single](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeValue\_Single.md)

#### Implements

IMessage<CDotaMsgStructuredTooltipProperties.Types.AttributeValue\_Single\>, 
[IEquatable<CDotaMsgStructuredTooltipProperties.Types.AttributeValue\_Single\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDotaMsgStructuredTooltipProperties.Types.AttributeValue\_Single\>, 
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
[EnumerableExtensions.In<CDotaMsgStructuredTooltipProperties.Types.AttributeValue\_Single\>\(CDotaMsgStructuredTooltipProperties.Types.AttributeValue\_Single, params CDotaMsgStructuredTooltipProperties.Types.AttributeValue\_Single\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single__ctor"></a> AttributeValue\_Single\(\)

```csharp
public AttributeValue_Single()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single__ctor_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single_"></a> AttributeValue\_Single\(AttributeValue\_Single\)

```csharp
public AttributeValue_Single(CDotaMsgStructuredTooltipProperties.Types.AttributeValue_Single other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeValue\_Single](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeValue\_Single.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single_SingleValueFieldNumber"></a> SingleValueFieldNumber

```csharp
public const int SingleValueFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single_Parser"></a> Parser

```csharp
public static MessageParser<CDotaMsgStructuredTooltipProperties.Types.AttributeValue_Single> Parser { get; }
```

#### Property Value

 MessageParser<[CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeValue\_Single](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeValue\_Single.md)\>

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single_SingleValue"></a> SingleValue

```csharp
public CDotaMsgStructuredTooltipProperties.Types.AttributeValueValue SingleValue { get; set; }
```

#### Property Value

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeValueValue](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeValueValue.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single_Clone"></a> Clone\(\)

```csharp
public CDotaMsgStructuredTooltipProperties.Types.AttributeValue_Single Clone()
```

#### Returns

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeValue\_Single](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeValue\_Single.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single_Equals_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single_"></a> Equals\(AttributeValue\_Single\)

```csharp
public bool Equals(CDotaMsgStructuredTooltipProperties.Types.AttributeValue_Single other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeValue\_Single](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeValue\_Single.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single_MergeFrom_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single_"></a> MergeFrom\(AttributeValue\_Single\)

```csharp
public void MergeFrom(CDotaMsgStructuredTooltipProperties.Types.AttributeValue_Single other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeValue\_Single](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeValue\_Single.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeValue_Single_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

