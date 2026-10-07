# <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem"></a> Class CGCStoreRechargeRedirect\_LineItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCStoreRechargeRedirect_LineItem : IMessage<CGCStoreRechargeRedirect_LineItem>, IEquatable<CGCStoreRechargeRedirect_LineItem>, IDeepCloneable<CGCStoreRechargeRedirect_LineItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCStoreRechargeRedirect\_LineItem](Divine.Protobufs.Dota2.CGCStoreRechargeRedirect\_LineItem.md)

#### Implements

IMessage<CGCStoreRechargeRedirect\_LineItem\>, 
[IEquatable<CGCStoreRechargeRedirect\_LineItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCStoreRechargeRedirect\_LineItem\>, 
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
[EnumerableExtensions.In<CGCStoreRechargeRedirect\_LineItem\>\(CGCStoreRechargeRedirect\_LineItem, params CGCStoreRechargeRedirect\_LineItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem__ctor"></a> CGCStoreRechargeRedirect\_LineItem\(\)

```csharp
public CGCStoreRechargeRedirect_LineItem()
```

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem__ctor_Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_"></a> CGCStoreRechargeRedirect\_LineItem\(CGCStoreRechargeRedirect\_LineItem\)

```csharp
public CGCStoreRechargeRedirect_LineItem(CGCStoreRechargeRedirect_LineItem other)
```

#### Parameters

`other` [CGCStoreRechargeRedirect\_LineItem](Divine.Protobufs.Dota2.CGCStoreRechargeRedirect\_LineItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_ItemDefIdFieldNumber"></a> ItemDefIdFieldNumber

```csharp
public const int ItemDefIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_QuantityFieldNumber"></a> QuantityFieldNumber

```csharp
public const int QuantityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_HasItemDefId"></a> HasItemDefId

```csharp
public bool HasItemDefId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_HasQuantity"></a> HasQuantity

```csharp
public bool HasQuantity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_ItemDefId"></a> ItemDefId

```csharp
public uint ItemDefId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_Parser"></a> Parser

```csharp
public static MessageParser<CGCStoreRechargeRedirect_LineItem> Parser { get; }
```

#### Property Value

 MessageParser<[CGCStoreRechargeRedirect\_LineItem](Divine.Protobufs.Dota2.CGCStoreRechargeRedirect\_LineItem.md)\>

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_Quantity"></a> Quantity

```csharp
public uint Quantity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_ClearItemDefId"></a> ClearItemDefId\(\)

```csharp
public void ClearItemDefId()
```

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_ClearQuantity"></a> ClearQuantity\(\)

```csharp
public void ClearQuantity()
```

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_Clone"></a> Clone\(\)

```csharp
public CGCStoreRechargeRedirect_LineItem Clone()
```

#### Returns

 [CGCStoreRechargeRedirect\_LineItem](Divine.Protobufs.Dota2.CGCStoreRechargeRedirect\_LineItem.md)

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_Equals_Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_"></a> Equals\(CGCStoreRechargeRedirect\_LineItem\)

```csharp
public bool Equals(CGCStoreRechargeRedirect_LineItem other)
```

#### Parameters

`other` [CGCStoreRechargeRedirect\_LineItem](Divine.Protobufs.Dota2.CGCStoreRechargeRedirect\_LineItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_MergeFrom_Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_"></a> MergeFrom\(CGCStoreRechargeRedirect\_LineItem\)

```csharp
public void MergeFrom(CGCStoreRechargeRedirect_LineItem other)
```

#### Parameters

`other` [CGCStoreRechargeRedirect\_LineItem](Divine.Protobufs.Dota2.CGCStoreRechargeRedirect\_LineItem.md)

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CGCStoreRechargeRedirect_LineItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

