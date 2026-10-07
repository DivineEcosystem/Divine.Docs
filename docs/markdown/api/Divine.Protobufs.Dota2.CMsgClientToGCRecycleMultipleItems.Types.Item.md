# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item"></a> Class CMsgClientToGCRecycleMultipleItems.Types.Item

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRecycleMultipleItems.Types.Item : IMessage<CMsgClientToGCRecycleMultipleItems.Types.Item>, IEquatable<CMsgClientToGCRecycleMultipleItems.Types.Item>, IDeepCloneable<CMsgClientToGCRecycleMultipleItems.Types.Item>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRecycleMultipleItems.Types.Item](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.Types.Item.md)

#### Implements

IMessage<CMsgClientToGCRecycleMultipleItems.Types.Item\>, 
[IEquatable<CMsgClientToGCRecycleMultipleItems.Types.Item\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRecycleMultipleItems.Types.Item\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRecycleMultipleItems.Types.Item\>\(CMsgClientToGCRecycleMultipleItems.Types.Item, params CMsgClientToGCRecycleMultipleItems.Types.Item\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item__ctor"></a> Item\(\)

```csharp
public Item()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_"></a> Item\(Item\)

```csharp
public Item(CMsgClientToGCRecycleMultipleItems.Types.Item other)
```

#### Parameters

`other` [CMsgClientToGCRecycleMultipleItems](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.Types.md).[Item](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.Types.Item.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_RecipeDefIndexFieldNumber"></a> RecipeDefIndexFieldNumber

```csharp
public const int RecipeDefIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_SlotIdFieldNumber"></a> SlotIdFieldNumber

```csharp
public const int SlotIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_HasRecipeDefIndex"></a> HasRecipeDefIndex

```csharp
public bool HasRecipeDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_HasSlotId"></a> HasSlotId

```csharp
public bool HasSlotId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRecycleMultipleItems.Types.Item> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRecycleMultipleItems](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.Types.md).[Item](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.Types.Item.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_RecipeDefIndex"></a> RecipeDefIndex

```csharp
public uint RecipeDefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_SlotId"></a> SlotId

```csharp
public uint SlotId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_ClearRecipeDefIndex"></a> ClearRecipeDefIndex\(\)

```csharp
public void ClearRecipeDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_ClearSlotId"></a> ClearSlotId\(\)

```csharp
public void ClearSlotId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRecycleMultipleItems.Types.Item Clone()
```

#### Returns

 [CMsgClientToGCRecycleMultipleItems](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.Types.md).[Item](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.Types.Item.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_"></a> Equals\(Item\)

```csharp
public bool Equals(CMsgClientToGCRecycleMultipleItems.Types.Item other)
```

#### Parameters

`other` [CMsgClientToGCRecycleMultipleItems](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.Types.md).[Item](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.Types.Item.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_"></a> MergeFrom\(Item\)

```csharp
public void MergeFrom(CMsgClientToGCRecycleMultipleItems.Types.Item other)
```

#### Parameters

`other` [CMsgClientToGCRecycleMultipleItems](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.Types.md).[Item](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.Types.Item.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Types_Item_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

