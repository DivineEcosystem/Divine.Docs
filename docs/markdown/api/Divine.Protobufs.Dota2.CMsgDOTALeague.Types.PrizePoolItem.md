# <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem"></a> Class CMsgDOTALeague.Types.PrizePoolItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeague.Types.PrizePoolItem : IMessage<CMsgDOTALeague.Types.PrizePoolItem>, IEquatable<CMsgDOTALeague.Types.PrizePoolItem>, IDeepCloneable<CMsgDOTALeague.Types.PrizePoolItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeague.Types.PrizePoolItem](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.PrizePoolItem.md)

#### Implements

IMessage<CMsgDOTALeague.Types.PrizePoolItem\>, 
[IEquatable<CMsgDOTALeague.Types.PrizePoolItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeague.Types.PrizePoolItem\>, 
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
[EnumerableExtensions.In<CMsgDOTALeague.Types.PrizePoolItem\>\(CMsgDOTALeague.Types.PrizePoolItem, params CMsgDOTALeague.Types.PrizePoolItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem__ctor"></a> PrizePoolItem\(\)

```csharp
public PrizePoolItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem__ctor_Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_"></a> PrizePoolItem\(PrizePoolItem\)

```csharp
public PrizePoolItem(CMsgDOTALeague.Types.PrizePoolItem other)
```

#### Parameters

`other` [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[PrizePoolItem](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.PrizePoolItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_ItemDefFieldNumber"></a> ItemDefFieldNumber

```csharp
public const int ItemDefFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_RevenueCentsPerSaleFieldNumber"></a> RevenueCentsPerSaleFieldNumber

```csharp
public const int RevenueCentsPerSaleFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_RevenuePctFieldNumber"></a> RevenuePctFieldNumber

```csharp
public const int RevenuePctFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_SalesStopTimestampFieldNumber"></a> SalesStopTimestampFieldNumber

```csharp
public const int SalesStopTimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_HasItemDef"></a> HasItemDef

```csharp
public bool HasItemDef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_HasRevenueCentsPerSale"></a> HasRevenueCentsPerSale

```csharp
public bool HasRevenueCentsPerSale { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_HasRevenuePct"></a> HasRevenuePct

```csharp
public bool HasRevenuePct { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_HasSalesStopTimestamp"></a> HasSalesStopTimestamp

```csharp
public bool HasSalesStopTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_ItemDef"></a> ItemDef

```csharp
public uint ItemDef { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeague.Types.PrizePoolItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[PrizePoolItem](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.PrizePoolItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_RevenueCentsPerSale"></a> RevenueCentsPerSale

```csharp
public uint RevenueCentsPerSale { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_RevenuePct"></a> RevenuePct

```csharp
public uint RevenuePct { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_SalesStopTimestamp"></a> SalesStopTimestamp

```csharp
public uint SalesStopTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_ClearItemDef"></a> ClearItemDef\(\)

```csharp
public void ClearItemDef()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_ClearRevenueCentsPerSale"></a> ClearRevenueCentsPerSale\(\)

```csharp
public void ClearRevenueCentsPerSale()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_ClearRevenuePct"></a> ClearRevenuePct\(\)

```csharp
public void ClearRevenuePct()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_ClearSalesStopTimestamp"></a> ClearSalesStopTimestamp\(\)

```csharp
public void ClearSalesStopTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeague.Types.PrizePoolItem Clone()
```

#### Returns

 [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[PrizePoolItem](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.PrizePoolItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_Equals_Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_"></a> Equals\(PrizePoolItem\)

```csharp
public bool Equals(CMsgDOTALeague.Types.PrizePoolItem other)
```

#### Parameters

`other` [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[PrizePoolItem](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.PrizePoolItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_"></a> MergeFrom\(PrizePoolItem\)

```csharp
public void MergeFrom(CMsgDOTALeague.Types.PrizePoolItem other)
```

#### Parameters

`other` [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[PrizePoolItem](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.PrizePoolItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePoolItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

