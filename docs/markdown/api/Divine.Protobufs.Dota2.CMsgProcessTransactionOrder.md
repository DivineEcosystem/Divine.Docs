# <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder"></a> Class CMsgProcessTransactionOrder

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgProcessTransactionOrder : IMessage<CMsgProcessTransactionOrder>, IEquatable<CMsgProcessTransactionOrder>, IDeepCloneable<CMsgProcessTransactionOrder>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgProcessTransactionOrder](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.md)

#### Implements

IMessage<CMsgProcessTransactionOrder\>, 
[IEquatable<CMsgProcessTransactionOrder\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgProcessTransactionOrder\>, 
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
[EnumerableExtensions.In<CMsgProcessTransactionOrder\>\(CMsgProcessTransactionOrder, params CMsgProcessTransactionOrder\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder__ctor"></a> CMsgProcessTransactionOrder\(\)

```csharp
public CMsgProcessTransactionOrder()
```

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder__ctor_Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_"></a> CMsgProcessTransactionOrder\(CMsgProcessTransactionOrder\)

```csharp
public CMsgProcessTransactionOrder(CMsgProcessTransactionOrder other)
```

#### Parameters

`other` [CMsgProcessTransactionOrder](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_CurrencyFieldNumber"></a> CurrencyFieldNumber

```csharp
public const int CurrencyFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_ItemsFieldNumber"></a> ItemsFieldNumber

```csharp
public const int ItemsFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_PurchaseReportStatusFieldNumber"></a> PurchaseReportStatusFieldNumber

```csharp
public const int PurchaseReportStatusFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_SteamTxnIdFieldNumber"></a> SteamTxnIdFieldNumber

```csharp
public const int SteamTxnIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_TimeStampFieldNumber"></a> TimeStampFieldNumber

```csharp
public const int TimeStampFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_TxnIdFieldNumber"></a> TxnIdFieldNumber

```csharp
public const int TxnIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_WatermarkFieldNumber"></a> WatermarkFieldNumber

```csharp
public const int WatermarkFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Currency"></a> Currency

```csharp
public uint Currency { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_HasCurrency"></a> HasCurrency

```csharp
public bool HasCurrency { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_HasPurchaseReportStatus"></a> HasPurchaseReportStatus

```csharp
public bool HasPurchaseReportStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_HasSteamId"></a> HasSteamId

```csharp
public bool HasSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_HasSteamTxnId"></a> HasSteamTxnId

```csharp
public bool HasSteamTxnId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_HasTimeStamp"></a> HasTimeStamp

```csharp
public bool HasTimeStamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_HasTxnId"></a> HasTxnId

```csharp
public bool HasTxnId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_HasWatermark"></a> HasWatermark

```csharp
public bool HasWatermark { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Items"></a> Items

```csharp
public RepeatedField<CMsgProcessTransactionOrder.Types.Item> Items { get; }
```

#### Property Value

 RepeatedField<[CMsgProcessTransactionOrder](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.md).[Types](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.Types.md).[Item](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.Types.Item.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Parser"></a> Parser

```csharp
public static MessageParser<CMsgProcessTransactionOrder> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgProcessTransactionOrder](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_PurchaseReportStatus"></a> PurchaseReportStatus

```csharp
public int PurchaseReportStatus { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_SteamId"></a> SteamId

```csharp
public ulong SteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_SteamTxnId"></a> SteamTxnId

```csharp
public ulong SteamTxnId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_TimeStamp"></a> TimeStamp

```csharp
public uint TimeStamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_TxnId"></a> TxnId

```csharp
public ulong TxnId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Watermark"></a> Watermark

```csharp
public ulong Watermark { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_ClearCurrency"></a> ClearCurrency\(\)

```csharp
public void ClearCurrency()
```

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_ClearPurchaseReportStatus"></a> ClearPurchaseReportStatus\(\)

```csharp
public void ClearPurchaseReportStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_ClearSteamId"></a> ClearSteamId\(\)

```csharp
public void ClearSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_ClearSteamTxnId"></a> ClearSteamTxnId\(\)

```csharp
public void ClearSteamTxnId()
```

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_ClearTimeStamp"></a> ClearTimeStamp\(\)

```csharp
public void ClearTimeStamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_ClearTxnId"></a> ClearTxnId\(\)

```csharp
public void ClearTxnId()
```

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_ClearWatermark"></a> ClearWatermark\(\)

```csharp
public void ClearWatermark()
```

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Clone"></a> Clone\(\)

```csharp
public CMsgProcessTransactionOrder Clone()
```

#### Returns

 [CMsgProcessTransactionOrder](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.md)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_Equals_Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_"></a> Equals\(CMsgProcessTransactionOrder\)

```csharp
public bool Equals(CMsgProcessTransactionOrder other)
```

#### Parameters

`other` [CMsgProcessTransactionOrder](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_MergeFrom_Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_"></a> MergeFrom\(CMsgProcessTransactionOrder\)

```csharp
public void MergeFrom(CMsgProcessTransactionOrder other)
```

#### Parameters

`other` [CMsgProcessTransactionOrder](Divine.Protobufs.Dota2.CMsgProcessTransactionOrder.md)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgProcessTransactionOrder_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

