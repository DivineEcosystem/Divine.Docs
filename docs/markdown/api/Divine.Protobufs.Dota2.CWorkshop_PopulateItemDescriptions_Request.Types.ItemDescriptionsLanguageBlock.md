# <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock"></a> Class CWorkshop\_PopulateItemDescriptions\_Request.Types.ItemDescriptionsLanguageBlock

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CWorkshop_PopulateItemDescriptions_Request.Types.ItemDescriptionsLanguageBlock : IMessage<CWorkshop_PopulateItemDescriptions_Request.Types.ItemDescriptionsLanguageBlock>, IEquatable<CWorkshop_PopulateItemDescriptions_Request.Types.ItemDescriptionsLanguageBlock>, IDeepCloneable<CWorkshop_PopulateItemDescriptions_Request.Types.ItemDescriptionsLanguageBlock>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CWorkshop\_PopulateItemDescriptions\_Request.Types.ItemDescriptionsLanguageBlock](Divine.Protobufs.Dota2.CWorkshop\_PopulateItemDescriptions\_Request.Types.ItemDescriptionsLanguageBlock.md)

#### Implements

IMessage<CWorkshop\_PopulateItemDescriptions\_Request.Types.ItemDescriptionsLanguageBlock\>, 
[IEquatable<CWorkshop\_PopulateItemDescriptions\_Request.Types.ItemDescriptionsLanguageBlock\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CWorkshop\_PopulateItemDescriptions\_Request.Types.ItemDescriptionsLanguageBlock\>, 
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
[EnumerableExtensions.In<CWorkshop\_PopulateItemDescriptions\_Request.Types.ItemDescriptionsLanguageBlock\>\(CWorkshop\_PopulateItemDescriptions\_Request.Types.ItemDescriptionsLanguageBlock, params CWorkshop\_PopulateItemDescriptions\_Request.Types.ItemDescriptionsLanguageBlock\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock__ctor"></a> ItemDescriptionsLanguageBlock\(\)

```csharp
public ItemDescriptionsLanguageBlock()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock__ctor_Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_"></a> ItemDescriptionsLanguageBlock\(ItemDescriptionsLanguageBlock\)

```csharp
public ItemDescriptionsLanguageBlock(CWorkshop_PopulateItemDescriptions_Request.Types.ItemDescriptionsLanguageBlock other)
```

#### Parameters

`other` [CWorkshop\_PopulateItemDescriptions\_Request](Divine.Protobufs.Dota2.CWorkshop\_PopulateItemDescriptions\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_PopulateItemDescriptions\_Request.Types.md).[ItemDescriptionsLanguageBlock](Divine.Protobufs.Dota2.CWorkshop\_PopulateItemDescriptions\_Request.Types.ItemDescriptionsLanguageBlock.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_DescriptionsFieldNumber"></a> DescriptionsFieldNumber

```csharp
public const int DescriptionsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_LanguageFieldNumber"></a> LanguageFieldNumber

```csharp
public const int LanguageFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_Descriptions"></a> Descriptions

```csharp
public RepeatedField<CWorkshop_PopulateItemDescriptions_Request.Types.SingleItemDescription> Descriptions { get; }
```

#### Property Value

 RepeatedField<[CWorkshop\_PopulateItemDescriptions\_Request](Divine.Protobufs.Dota2.CWorkshop\_PopulateItemDescriptions\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_PopulateItemDescriptions\_Request.Types.md).[SingleItemDescription](Divine.Protobufs.Dota2.CWorkshop\_PopulateItemDescriptions\_Request.Types.SingleItemDescription.md)\>

### <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_HasLanguage"></a> HasLanguage

```csharp
public bool HasLanguage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_Language"></a> Language

```csharp
public string Language { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_Parser"></a> Parser

```csharp
public static MessageParser<CWorkshop_PopulateItemDescriptions_Request.Types.ItemDescriptionsLanguageBlock> Parser { get; }
```

#### Property Value

 MessageParser<[CWorkshop\_PopulateItemDescriptions\_Request](Divine.Protobufs.Dota2.CWorkshop\_PopulateItemDescriptions\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_PopulateItemDescriptions\_Request.Types.md).[ItemDescriptionsLanguageBlock](Divine.Protobufs.Dota2.CWorkshop\_PopulateItemDescriptions\_Request.Types.ItemDescriptionsLanguageBlock.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_ClearLanguage"></a> ClearLanguage\(\)

```csharp
public void ClearLanguage()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_Clone"></a> Clone\(\)

```csharp
public CWorkshop_PopulateItemDescriptions_Request.Types.ItemDescriptionsLanguageBlock Clone()
```

#### Returns

 [CWorkshop\_PopulateItemDescriptions\_Request](Divine.Protobufs.Dota2.CWorkshop\_PopulateItemDescriptions\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_PopulateItemDescriptions\_Request.Types.md).[ItemDescriptionsLanguageBlock](Divine.Protobufs.Dota2.CWorkshop\_PopulateItemDescriptions\_Request.Types.ItemDescriptionsLanguageBlock.md)

### <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_Equals_Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_"></a> Equals\(ItemDescriptionsLanguageBlock\)

```csharp
public bool Equals(CWorkshop_PopulateItemDescriptions_Request.Types.ItemDescriptionsLanguageBlock other)
```

#### Parameters

`other` [CWorkshop\_PopulateItemDescriptions\_Request](Divine.Protobufs.Dota2.CWorkshop\_PopulateItemDescriptions\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_PopulateItemDescriptions\_Request.Types.md).[ItemDescriptionsLanguageBlock](Divine.Protobufs.Dota2.CWorkshop\_PopulateItemDescriptions\_Request.Types.ItemDescriptionsLanguageBlock.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_MergeFrom_Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_"></a> MergeFrom\(ItemDescriptionsLanguageBlock\)

```csharp
public void MergeFrom(CWorkshop_PopulateItemDescriptions_Request.Types.ItemDescriptionsLanguageBlock other)
```

#### Parameters

`other` [CWorkshop\_PopulateItemDescriptions\_Request](Divine.Protobufs.Dota2.CWorkshop\_PopulateItemDescriptions\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_PopulateItemDescriptions\_Request.Types.md).[ItemDescriptionsLanguageBlock](Divine.Protobufs.Dota2.CWorkshop\_PopulateItemDescriptions\_Request.Types.ItemDescriptionsLanguageBlock.md)

### <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CWorkshop_PopulateItemDescriptions_Request_Types_ItemDescriptionsLanguageBlock_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

