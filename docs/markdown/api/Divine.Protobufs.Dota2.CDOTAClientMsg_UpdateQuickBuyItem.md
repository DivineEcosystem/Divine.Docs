# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem"></a> Class CDOTAClientMsg\_UpdateQuickBuyItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_UpdateQuickBuyItem : IMessage<CDOTAClientMsg_UpdateQuickBuyItem>, IEquatable<CDOTAClientMsg_UpdateQuickBuyItem>, IDeepCloneable<CDOTAClientMsg_UpdateQuickBuyItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_UpdateQuickBuyItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_UpdateQuickBuyItem.md)

#### Implements

IMessage<CDOTAClientMsg\_UpdateQuickBuyItem\>, 
[IEquatable<CDOTAClientMsg\_UpdateQuickBuyItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_UpdateQuickBuyItem\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_UpdateQuickBuyItem\>\(CDOTAClientMsg\_UpdateQuickBuyItem, params CDOTAClientMsg\_UpdateQuickBuyItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem__ctor"></a> CDOTAClientMsg\_UpdateQuickBuyItem\(\)

```csharp
public CDOTAClientMsg_UpdateQuickBuyItem()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_"></a> CDOTAClientMsg\_UpdateQuickBuyItem\(CDOTAClientMsg\_UpdateQuickBuyItem\)

```csharp
public CDOTAClientMsg_UpdateQuickBuyItem(CDOTAClientMsg_UpdateQuickBuyItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_UpdateQuickBuyItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_UpdateQuickBuyItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_ItemAbilityIdFieldNumber"></a> ItemAbilityIdFieldNumber

```csharp
public const int ItemAbilityIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_PurchasableFieldNumber"></a> PurchasableFieldNumber

```csharp
public const int PurchasableFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_TopLevelItemAbilityIdFieldNumber"></a> TopLevelItemAbilityIdFieldNumber

```csharp
public const int TopLevelItemAbilityIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_HasItemAbilityId"></a> HasItemAbilityId

```csharp
public bool HasItemAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_HasPurchasable"></a> HasPurchasable

```csharp
public bool HasPurchasable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_HasTopLevelItemAbilityId"></a> HasTopLevelItemAbilityId

```csharp
public bool HasTopLevelItemAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_ItemAbilityId"></a> ItemAbilityId

```csharp
public int ItemAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_UpdateQuickBuyItem> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_UpdateQuickBuyItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_UpdateQuickBuyItem.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_Purchasable"></a> Purchasable

```csharp
public bool Purchasable { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_TopLevelItemAbilityId"></a> TopLevelItemAbilityId

```csharp
public int TopLevelItemAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_ClearItemAbilityId"></a> ClearItemAbilityId\(\)

```csharp
public void ClearItemAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_ClearPurchasable"></a> ClearPurchasable\(\)

```csharp
public void ClearPurchasable()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_ClearTopLevelItemAbilityId"></a> ClearTopLevelItemAbilityId\(\)

```csharp
public void ClearTopLevelItemAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_UpdateQuickBuyItem Clone()
```

#### Returns

 [CDOTAClientMsg\_UpdateQuickBuyItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_UpdateQuickBuyItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_"></a> Equals\(CDOTAClientMsg\_UpdateQuickBuyItem\)

```csharp
public bool Equals(CDOTAClientMsg_UpdateQuickBuyItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_UpdateQuickBuyItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_UpdateQuickBuyItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_"></a> MergeFrom\(CDOTAClientMsg\_UpdateQuickBuyItem\)

```csharp
public void MergeFrom(CDOTAClientMsg_UpdateQuickBuyItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_UpdateQuickBuyItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_UpdateQuickBuyItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuyItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

