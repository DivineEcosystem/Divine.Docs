# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem"></a> Class CDOTAClientMsg\_ChooseCraftedNeutralItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_ChooseCraftedNeutralItem : IMessage<CDOTAClientMsg_ChooseCraftedNeutralItem>, IEquatable<CDOTAClientMsg_ChooseCraftedNeutralItem>, IDeepCloneable<CDOTAClientMsg_ChooseCraftedNeutralItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_ChooseCraftedNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseCraftedNeutralItem.md)

#### Implements

IMessage<CDOTAClientMsg\_ChooseCraftedNeutralItem\>, 
[IEquatable<CDOTAClientMsg\_ChooseCraftedNeutralItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_ChooseCraftedNeutralItem\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_ChooseCraftedNeutralItem\>\(CDOTAClientMsg\_ChooseCraftedNeutralItem, params CDOTAClientMsg\_ChooseCraftedNeutralItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem__ctor"></a> CDOTAClientMsg\_ChooseCraftedNeutralItem\(\)

```csharp
public CDOTAClientMsg_ChooseCraftedNeutralItem()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_"></a> CDOTAClientMsg\_ChooseCraftedNeutralItem\(CDOTAClientMsg\_ChooseCraftedNeutralItem\)

```csharp
public CDOTAClientMsg_ChooseCraftedNeutralItem(CDOTAClientMsg_ChooseCraftedNeutralItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChooseCraftedNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseCraftedNeutralItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_EnhancementIndexFieldNumber"></a> EnhancementIndexFieldNumber

```csharp
public const int EnhancementIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_ItemTierFieldNumber"></a> ItemTierFieldNumber

```csharp
public const int ItemTierFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_NeutralItemIndexFieldNumber"></a> NeutralItemIndexFieldNumber

```csharp
public const int NeutralItemIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_EnhancementIndex"></a> EnhancementIndex

```csharp
public int EnhancementIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_HasEnhancementIndex"></a> HasEnhancementIndex

```csharp
public bool HasEnhancementIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_HasItemTier"></a> HasItemTier

```csharp
public bool HasItemTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_HasNeutralItemIndex"></a> HasNeutralItemIndex

```csharp
public bool HasNeutralItemIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_ItemTier"></a> ItemTier

```csharp
public int ItemTier { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_NeutralItemIndex"></a> NeutralItemIndex

```csharp
public int NeutralItemIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_ChooseCraftedNeutralItem> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_ChooseCraftedNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseCraftedNeutralItem.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_ClearEnhancementIndex"></a> ClearEnhancementIndex\(\)

```csharp
public void ClearEnhancementIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_ClearItemTier"></a> ClearItemTier\(\)

```csharp
public void ClearItemTier()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_ClearNeutralItemIndex"></a> ClearNeutralItemIndex\(\)

```csharp
public void ClearNeutralItemIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_ChooseCraftedNeutralItem Clone()
```

#### Returns

 [CDOTAClientMsg\_ChooseCraftedNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseCraftedNeutralItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_"></a> Equals\(CDOTAClientMsg\_ChooseCraftedNeutralItem\)

```csharp
public bool Equals(CDOTAClientMsg_ChooseCraftedNeutralItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChooseCraftedNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseCraftedNeutralItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_"></a> MergeFrom\(CDOTAClientMsg\_ChooseCraftedNeutralItem\)

```csharp
public void MergeFrom(CDOTAClientMsg_ChooseCraftedNeutralItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChooseCraftedNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseCraftedNeutralItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseCraftedNeutralItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

