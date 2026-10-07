# <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific"></a> Class CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Specific

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Specific : IMessage<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Specific>, IEquatable<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Specific>, IDeepCloneable<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Specific>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Specific](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Specific.md)

#### Implements

IMessage<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Specific\>, 
[IEquatable<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Specific\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Specific\>, 
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
[EnumerableExtensions.In<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Specific\>\(CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Specific, params CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Specific\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific__ctor"></a> AttributeGroupDesc\_Specific\(\)

```csharp
public AttributeGroupDesc_Specific()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific__ctor_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_"></a> AttributeGroupDesc\_Specific\(AttributeGroupDesc\_Specific\)

```csharp
public AttributeGroupDesc_Specific(CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Specific other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDesc\_Specific](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Specific.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_DescLocTokenFieldNumber"></a> DescLocTokenFieldNumber

```csharp
public const int DescLocTokenFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_TitleLocTokenFieldNumber"></a> TitleLocTokenFieldNumber

```csharp
public const int TitleLocTokenFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_DescLocToken"></a> DescLocToken

```csharp
public string DescLocToken { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_HasDescLocToken"></a> HasDescLocToken

```csharp
public bool HasDescLocToken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_HasTitleLocToken"></a> HasTitleLocToken

```csharp
public bool HasTitleLocToken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_Parser"></a> Parser

```csharp
public static MessageParser<CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Specific> Parser { get; }
```

#### Property Value

 MessageParser<[CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDesc\_Specific](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Specific.md)\>

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_TitleLocToken"></a> TitleLocToken

```csharp
public string TitleLocToken { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_ClearDescLocToken"></a> ClearDescLocToken\(\)

```csharp
public void ClearDescLocToken()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_ClearTitleLocToken"></a> ClearTitleLocToken\(\)

```csharp
public void ClearTitleLocToken()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_Clone"></a> Clone\(\)

```csharp
public CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Specific Clone()
```

#### Returns

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDesc\_Specific](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Specific.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_Equals_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_"></a> Equals\(AttributeGroupDesc\_Specific\)

```csharp
public bool Equals(CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Specific other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDesc\_Specific](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Specific.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_MergeFrom_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_"></a> MergeFrom\(AttributeGroupDesc\_Specific\)

```csharp
public void MergeFrom(CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc_Specific other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[AttributeGroupDesc\_Specific](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.AttributeGroupDesc\_Specific.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Types_AttributeGroupDesc_Specific_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

