# <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem"></a> Class CMsgGCAddGiftItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCAddGiftItem : IMessage<CMsgGCAddGiftItem>, IEquatable<CMsgGCAddGiftItem>, IDeepCloneable<CMsgGCAddGiftItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCAddGiftItem](Divine.Protobufs.Dota2.CMsgGCAddGiftItem.md)

#### Implements

IMessage<CMsgGCAddGiftItem\>, 
[IEquatable<CMsgGCAddGiftItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCAddGiftItem\>, 
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
[EnumerableExtensions.In<CMsgGCAddGiftItem\>\(CMsgGCAddGiftItem, params CMsgGCAddGiftItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem__ctor"></a> CMsgGCAddGiftItem\(\)

```csharp
public CMsgGCAddGiftItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem__ctor_Divine_Protobufs_Dota2_CMsgGCAddGiftItem_"></a> CMsgGCAddGiftItem\(CMsgGCAddGiftItem\)

```csharp
public CMsgGCAddGiftItem(CMsgGCAddGiftItem other)
```

#### Parameters

`other` [CMsgGCAddGiftItem](Divine.Protobufs.Dota2.CMsgGCAddGiftItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_GifterAccountIdFieldNumber"></a> GifterAccountIdFieldNumber

```csharp
public const int GifterAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_GiftMessageFieldNumber"></a> GiftMessageFieldNumber

```csharp
public const int GiftMessageFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_IsWalletCashTrustedFieldNumber"></a> IsWalletCashTrustedFieldNumber

```csharp
public const int IsWalletCashTrustedFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_ReceiverAccountIdFieldNumber"></a> ReceiverAccountIdFieldNumber

```csharp
public const int ReceiverAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_WrappedItemFieldNumber"></a> WrappedItemFieldNumber

```csharp
public const int WrappedItemFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_GifterAccountId"></a> GifterAccountId

```csharp
public uint GifterAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_GiftMessage"></a> GiftMessage

```csharp
public string GiftMessage { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_HasGifterAccountId"></a> HasGifterAccountId

```csharp
public bool HasGifterAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_HasGiftMessage"></a> HasGiftMessage

```csharp
public bool HasGiftMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_HasIsWalletCashTrusted"></a> HasIsWalletCashTrusted

```csharp
public bool HasIsWalletCashTrusted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_HasReceiverAccountId"></a> HasReceiverAccountId

```csharp
public bool HasReceiverAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_IsWalletCashTrusted"></a> IsWalletCashTrusted

```csharp
public bool IsWalletCashTrusted { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCAddGiftItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCAddGiftItem](Divine.Protobufs.Dota2.CMsgGCAddGiftItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_ReceiverAccountId"></a> ReceiverAccountId

```csharp
public uint ReceiverAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_WrappedItem"></a> WrappedItem

```csharp
public CSOEconItem WrappedItem { get; set; }
```

#### Property Value

 [CSOEconItem](Divine.Protobufs.Dota2.CSOEconItem.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_ClearGifterAccountId"></a> ClearGifterAccountId\(\)

```csharp
public void ClearGifterAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_ClearGiftMessage"></a> ClearGiftMessage\(\)

```csharp
public void ClearGiftMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_ClearIsWalletCashTrusted"></a> ClearIsWalletCashTrusted\(\)

```csharp
public void ClearIsWalletCashTrusted()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_ClearReceiverAccountId"></a> ClearReceiverAccountId\(\)

```csharp
public void ClearReceiverAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_Clone"></a> Clone\(\)

```csharp
public CMsgGCAddGiftItem Clone()
```

#### Returns

 [CMsgGCAddGiftItem](Divine.Protobufs.Dota2.CMsgGCAddGiftItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_Equals_Divine_Protobufs_Dota2_CMsgGCAddGiftItem_"></a> Equals\(CMsgGCAddGiftItem\)

```csharp
public bool Equals(CMsgGCAddGiftItem other)
```

#### Parameters

`other` [CMsgGCAddGiftItem](Divine.Protobufs.Dota2.CMsgGCAddGiftItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_MergeFrom_Divine_Protobufs_Dota2_CMsgGCAddGiftItem_"></a> MergeFrom\(CMsgGCAddGiftItem\)

```csharp
public void MergeFrom(CMsgGCAddGiftItem other)
```

#### Parameters

`other` [CMsgGCAddGiftItem](Divine.Protobufs.Dota2.CMsgGCAddGiftItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCAddGiftItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

