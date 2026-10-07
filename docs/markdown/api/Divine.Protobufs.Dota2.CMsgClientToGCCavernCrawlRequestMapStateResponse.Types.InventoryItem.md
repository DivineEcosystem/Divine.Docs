# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem"></a> Class CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem : IMessage<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem>, IEquatable<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem>, IDeepCloneable<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem.md)

#### Implements

IMessage<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem\>, 
[IEquatable<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem\>\(CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem, params CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem__ctor"></a> InventoryItem\(\)

```csharp
public InventoryItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_"></a> InventoryItem\(InventoryItem\)

```csharp
public InventoryItem(CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.md).[InventoryItem](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_CountFieldNumber"></a> CountFieldNumber

```csharp
public const int CountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_ItemTypeFieldNumber"></a> ItemTypeFieldNumber

```csharp
public const int ItemTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_Count"></a> Count

```csharp
public uint Count { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_HasCount"></a> HasCount

```csharp
public bool HasCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_HasItemType"></a> HasItemType

```csharp
public bool HasItemType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_ItemType"></a> ItemType

```csharp
public uint ItemType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.md).[InventoryItem](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_ClearCount"></a> ClearCount\(\)

```csharp
public void ClearCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_ClearItemType"></a> ClearItemType\(\)

```csharp
public void ClearItemType()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem Clone()
```

#### Returns

 [CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.md).[InventoryItem](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_"></a> Equals\(InventoryItem\)

```csharp
public bool Equals(CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.md).[InventoryItem](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_"></a> MergeFrom\(InventoryItem\)

```csharp
public void MergeFrom(CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.md).[InventoryItem](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_InventoryItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

