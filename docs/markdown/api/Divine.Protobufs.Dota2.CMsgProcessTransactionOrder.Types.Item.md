# <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item"></a> Class CMsgProcessTransactionOrder.Types.Item

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgProcessTransactionOrder.Types.Item : IMessage<CMsgProcessTransactionOrder.Types.Item>, IEquatable<CMsgProcessTransactionOrder.Types.Item>, IDeepCloneable<CMsgProcessTransactionOrder.Types.Item>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgProcessTransactionOrder.Types.Item](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.Types.Item.md)

#### Implements

IMessage<CMsgProcessTransactionOrder.Types.Item\>, 
[IEquatable<CMsgProcessTransactionOrder.Types.Item\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgProcessTransactionOrder.Types.Item\>, 
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
[EnumerableExtensions.In<CMsgProcessTransactionOrder.Types.Item\>\(CMsgProcessTransactionOrder.Types.Item, params CMsgProcessTransactionOrder.Types.Item\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item__ctor"></a> Item\(\)

```csharp
public Item()
```

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item__ctor_Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_"></a> Item\(Item\)

```csharp
public Item(CMsgProcessTransactionOrder.Types.Item other)
```

#### Parameters

`other` [CMsgProcessTransactionOrder](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.md).[Types](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.Types.md).[Item](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.Types.Item.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_CategoryDescFieldNumber"></a> CategoryDescFieldNumber

```csharp
public const int CategoryDescFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_DefaultPriceFieldNumber"></a> DefaultPriceFieldNumber

```csharp
public const int DefaultPriceFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_ItemDefIndexFieldNumber"></a> ItemDefIndexFieldNumber

```csharp
public const int ItemDefIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_ItemPriceFieldNumber"></a> ItemPriceFieldNumber

```csharp
public const int ItemPriceFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_ParentStackIndexFieldNumber"></a> ParentStackIndexFieldNumber

```csharp
public const int ParentStackIndexFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_PriceIndexFieldNumber"></a> PriceIndexFieldNumber

```csharp
public const int PriceIndexFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_QuantityFieldNumber"></a> QuantityFieldNumber

```csharp
public const int QuantityFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_SourceReferenceIdFieldNumber"></a> SourceReferenceIdFieldNumber

```csharp
public const int SourceReferenceIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_StorePurchaseTypeFieldNumber"></a> StorePurchaseTypeFieldNumber

```csharp
public const int StorePurchaseTypeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_CategoryDesc"></a> CategoryDesc

```csharp
public string CategoryDesc { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_DefaultPrice"></a> DefaultPrice

```csharp
public bool DefaultPrice { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_HasCategoryDesc"></a> HasCategoryDesc

```csharp
public bool HasCategoryDesc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_HasDefaultPrice"></a> HasDefaultPrice

```csharp
public bool HasDefaultPrice { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_HasItemDefIndex"></a> HasItemDefIndex

```csharp
public bool HasItemDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_HasItemPrice"></a> HasItemPrice

```csharp
public bool HasItemPrice { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_HasParentStackIndex"></a> HasParentStackIndex

```csharp
public bool HasParentStackIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_HasPriceIndex"></a> HasPriceIndex

```csharp
public bool HasPriceIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_HasQuantity"></a> HasQuantity

```csharp
public bool HasQuantity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_HasSourceReferenceId"></a> HasSourceReferenceId

```csharp
public bool HasSourceReferenceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_HasStorePurchaseType"></a> HasStorePurchaseType

```csharp
public bool HasStorePurchaseType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_ItemDefIndex"></a> ItemDefIndex

```csharp
public uint ItemDefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_ItemPrice"></a> ItemPrice

```csharp
public uint ItemPrice { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_ParentStackIndex"></a> ParentStackIndex

```csharp
public int ParentStackIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_Parser"></a> Parser

```csharp
public static MessageParser<CMsgProcessTransactionOrder.Types.Item> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgProcessTransactionOrder](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.md).[Types](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.Types.md).[Item](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.Types.Item.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_PriceIndex"></a> PriceIndex

```csharp
public int PriceIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_Quantity"></a> Quantity

```csharp
public uint Quantity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_SourceReferenceId"></a> SourceReferenceId

```csharp
public ulong SourceReferenceId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_StorePurchaseType"></a> StorePurchaseType

```csharp
public uint StorePurchaseType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_ClearCategoryDesc"></a> ClearCategoryDesc\(\)

```csharp
public void ClearCategoryDesc()
```

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_ClearDefaultPrice"></a> ClearDefaultPrice\(\)

```csharp
public void ClearDefaultPrice()
```

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_ClearItemDefIndex"></a> ClearItemDefIndex\(\)

```csharp
public void ClearItemDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_ClearItemPrice"></a> ClearItemPrice\(\)

```csharp
public void ClearItemPrice()
```

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_ClearParentStackIndex"></a> ClearParentStackIndex\(\)

```csharp
public void ClearParentStackIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_ClearPriceIndex"></a> ClearPriceIndex\(\)

```csharp
public void ClearPriceIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_ClearQuantity"></a> ClearQuantity\(\)

```csharp
public void ClearQuantity()
```

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_ClearSourceReferenceId"></a> ClearSourceReferenceId\(\)

```csharp
public void ClearSourceReferenceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_ClearStorePurchaseType"></a> ClearStorePurchaseType\(\)

```csharp
public void ClearStorePurchaseType()
```

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_Clone"></a> Clone\(\)

```csharp
public CMsgProcessTransactionOrder.Types.Item Clone()
```

#### Returns

 [CMsgProcessTransactionOrder](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.md).[Types](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.Types.md).[Item](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.Types.Item.md)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_Equals_Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_"></a> Equals\(Item\)

```csharp
public bool Equals(CMsgProcessTransactionOrder.Types.Item other)
```

#### Parameters

`other` [CMsgProcessTransactionOrder](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.md).[Types](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.Types.md).[Item](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.Types.Item.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_MergeFrom_Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_"></a> MergeFrom\(Item\)

```csharp
public void MergeFrom(CMsgProcessTransactionOrder.Types.Item other)
```

#### Parameters

`other` [CMsgProcessTransactionOrder](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.md).[Types](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.Types.md).[Item](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.Types.Item.md)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Types_Item_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

