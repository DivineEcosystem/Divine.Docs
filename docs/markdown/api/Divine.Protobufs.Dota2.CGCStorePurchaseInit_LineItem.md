# <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem"></a> Class CGCStorePurchaseInit\_LineItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCStorePurchaseInit_LineItem : IMessage<CGCStorePurchaseInit_LineItem>, IEquatable<CGCStorePurchaseInit_LineItem>, IDeepCloneable<CGCStorePurchaseInit_LineItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCStorePurchaseInit\_LineItem](Divine.Protobufs.Dota2.CGCStorePurchaseInit\_LineItem.md)

#### Implements

IMessage<CGCStorePurchaseInit\_LineItem\>, 
[IEquatable<CGCStorePurchaseInit\_LineItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCStorePurchaseInit\_LineItem\>, 
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
[EnumerableExtensions.In<CGCStorePurchaseInit\_LineItem\>\(CGCStorePurchaseInit\_LineItem, params CGCStorePurchaseInit\_LineItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem__ctor"></a> CGCStorePurchaseInit\_LineItem\(\)

```csharp
public CGCStorePurchaseInit_LineItem()
```

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem__ctor_Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_"></a> CGCStorePurchaseInit\_LineItem\(CGCStorePurchaseInit\_LineItem\)

```csharp
public CGCStorePurchaseInit_LineItem(CGCStorePurchaseInit_LineItem other)
```

#### Parameters

`other` [CGCStorePurchaseInit\_LineItem](Divine.Protobufs.Dota2.CGCStorePurchaseInit\_LineItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_CostInLocalCurrencyFieldNumber"></a> CostInLocalCurrencyFieldNumber

```csharp
public const int CostInLocalCurrencyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_ItemDefIdFieldNumber"></a> ItemDefIdFieldNumber

```csharp
public const int ItemDefIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_PriceIndexFieldNumber"></a> PriceIndexFieldNumber

```csharp
public const int PriceIndexFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_PurchaseTypeFieldNumber"></a> PurchaseTypeFieldNumber

```csharp
public const int PurchaseTypeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_QuantityFieldNumber"></a> QuantityFieldNumber

```csharp
public const int QuantityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_SourceReferenceIdFieldNumber"></a> SourceReferenceIdFieldNumber

```csharp
public const int SourceReferenceIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_CostInLocalCurrency"></a> CostInLocalCurrency

```csharp
public uint CostInLocalCurrency { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_HasCostInLocalCurrency"></a> HasCostInLocalCurrency

```csharp
public bool HasCostInLocalCurrency { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_HasItemDefId"></a> HasItemDefId

```csharp
public bool HasItemDefId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_HasPriceIndex"></a> HasPriceIndex

```csharp
public bool HasPriceIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_HasPurchaseType"></a> HasPurchaseType

```csharp
public bool HasPurchaseType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_HasQuantity"></a> HasQuantity

```csharp
public bool HasQuantity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_HasSourceReferenceId"></a> HasSourceReferenceId

```csharp
public bool HasSourceReferenceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_ItemDefId"></a> ItemDefId

```csharp
public uint ItemDefId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_Parser"></a> Parser

```csharp
public static MessageParser<CGCStorePurchaseInit_LineItem> Parser { get; }
```

#### Property Value

 MessageParser<[CGCStorePurchaseInit\_LineItem](Divine.Protobufs.Dota2.CGCStorePurchaseInit\_LineItem.md)\>

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_PriceIndex"></a> PriceIndex

```csharp
public int PriceIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_PurchaseType"></a> PurchaseType

```csharp
public uint PurchaseType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_Quantity"></a> Quantity

```csharp
public uint Quantity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_SourceReferenceId"></a> SourceReferenceId

```csharp
public ulong SourceReferenceId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_ClearCostInLocalCurrency"></a> ClearCostInLocalCurrency\(\)

```csharp
public void ClearCostInLocalCurrency()
```

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_ClearItemDefId"></a> ClearItemDefId\(\)

```csharp
public void ClearItemDefId()
```

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_ClearPriceIndex"></a> ClearPriceIndex\(\)

```csharp
public void ClearPriceIndex()
```

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_ClearPurchaseType"></a> ClearPurchaseType\(\)

```csharp
public void ClearPurchaseType()
```

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_ClearQuantity"></a> ClearQuantity\(\)

```csharp
public void ClearQuantity()
```

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_ClearSourceReferenceId"></a> ClearSourceReferenceId\(\)

```csharp
public void ClearSourceReferenceId()
```

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_Clone"></a> Clone\(\)

```csharp
public CGCStorePurchaseInit_LineItem Clone()
```

#### Returns

 [CGCStorePurchaseInit\_LineItem](Divine.Protobufs.Dota2.CGCStorePurchaseInit\_LineItem.md)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_Equals_Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_"></a> Equals\(CGCStorePurchaseInit\_LineItem\)

```csharp
public bool Equals(CGCStorePurchaseInit_LineItem other)
```

#### Parameters

`other` [CGCStorePurchaseInit\_LineItem](Divine.Protobufs.Dota2.CGCStorePurchaseInit\_LineItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_MergeFrom_Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_"></a> MergeFrom\(CGCStorePurchaseInit\_LineItem\)

```csharp
public void MergeFrom(CGCStorePurchaseInit_LineItem other)
```

#### Parameters

`other` [CGCStorePurchaseInit\_LineItem](Divine.Protobufs.Dota2.CGCStorePurchaseInit\_LineItem.md)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CGCStorePurchaseInit_LineItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

