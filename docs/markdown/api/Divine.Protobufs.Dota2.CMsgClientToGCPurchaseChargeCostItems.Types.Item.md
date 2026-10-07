# <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item"></a> Class CMsgClientToGCPurchaseChargeCostItems.Types.Item

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCPurchaseChargeCostItems.Types.Item : IMessage<CMsgClientToGCPurchaseChargeCostItems.Types.Item>, IEquatable<CMsgClientToGCPurchaseChargeCostItems.Types.Item>, IDeepCloneable<CMsgClientToGCPurchaseChargeCostItems.Types.Item>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCPurchaseChargeCostItems.Types.Item](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.Types.Item.md)

#### Implements

IMessage<CMsgClientToGCPurchaseChargeCostItems.Types.Item\>, 
[IEquatable<CMsgClientToGCPurchaseChargeCostItems.Types.Item\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCPurchaseChargeCostItems.Types.Item\>, 
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
[EnumerableExtensions.In<CMsgClientToGCPurchaseChargeCostItems.Types.Item\>\(CMsgClientToGCPurchaseChargeCostItems.Types.Item, params CMsgClientToGCPurchaseChargeCostItems.Types.Item\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item__ctor"></a> Item\(\)

```csharp
public Item()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item__ctor_Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_"></a> Item\(Item\)

```csharp
public Item(CMsgClientToGCPurchaseChargeCostItems.Types.Item other)
```

#### Parameters

`other` [CMsgClientToGCPurchaseChargeCostItems](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.Types.md).[Item](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.Types.Item.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_ItemDefIndexFieldNumber"></a> ItemDefIndexFieldNumber

```csharp
public const int ItemDefIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_PriceIndexFieldNumber"></a> PriceIndexFieldNumber

```csharp
public const int PriceIndexFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_QuantityFieldNumber"></a> QuantityFieldNumber

```csharp
public const int QuantityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_SourceReferenceIdFieldNumber"></a> SourceReferenceIdFieldNumber

```csharp
public const int SourceReferenceIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_HasItemDefIndex"></a> HasItemDefIndex

```csharp
public bool HasItemDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_HasPriceIndex"></a> HasPriceIndex

```csharp
public bool HasPriceIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_HasQuantity"></a> HasQuantity

```csharp
public bool HasQuantity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_HasSourceReferenceId"></a> HasSourceReferenceId

```csharp
public bool HasSourceReferenceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_ItemDefIndex"></a> ItemDefIndex

```csharp
public uint ItemDefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCPurchaseChargeCostItems.Types.Item> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCPurchaseChargeCostItems](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.Types.md).[Item](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.Types.Item.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_PriceIndex"></a> PriceIndex

```csharp
public int PriceIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_Quantity"></a> Quantity

```csharp
public uint Quantity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_SourceReferenceId"></a> SourceReferenceId

```csharp
public ulong SourceReferenceId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_ClearItemDefIndex"></a> ClearItemDefIndex\(\)

```csharp
public void ClearItemDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_ClearPriceIndex"></a> ClearPriceIndex\(\)

```csharp
public void ClearPriceIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_ClearQuantity"></a> ClearQuantity\(\)

```csharp
public void ClearQuantity()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_ClearSourceReferenceId"></a> ClearSourceReferenceId\(\)

```csharp
public void ClearSourceReferenceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCPurchaseChargeCostItems.Types.Item Clone()
```

#### Returns

 [CMsgClientToGCPurchaseChargeCostItems](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.Types.md).[Item](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.Types.Item.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_Equals_Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_"></a> Equals\(Item\)

```csharp
public bool Equals(CMsgClientToGCPurchaseChargeCostItems.Types.Item other)
```

#### Parameters

`other` [CMsgClientToGCPurchaseChargeCostItems](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.Types.md).[Item](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.Types.Item.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_"></a> MergeFrom\(Item\)

```csharp
public void MergeFrom(CMsgClientToGCPurchaseChargeCostItems.Types.Item other)
```

#### Parameters

`other` [CMsgClientToGCPurchaseChargeCostItems](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.Types.md).[Item](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.Types.Item.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Types_Item_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

