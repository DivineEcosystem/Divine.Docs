# <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem"></a> Class CMsgClientToGCPlaceStickersRequest.Types.StickerItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCPlaceStickersRequest.Types.StickerItem : IMessage<CMsgClientToGCPlaceStickersRequest.Types.StickerItem>, IEquatable<CMsgClientToGCPlaceStickersRequest.Types.StickerItem>, IDeepCloneable<CMsgClientToGCPlaceStickersRequest.Types.StickerItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCPlaceStickersRequest.Types.StickerItem](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersRequest.Types.StickerItem.md)

#### Implements

IMessage<CMsgClientToGCPlaceStickersRequest.Types.StickerItem\>, 
[IEquatable<CMsgClientToGCPlaceStickersRequest.Types.StickerItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCPlaceStickersRequest.Types.StickerItem\>, 
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
[EnumerableExtensions.In<CMsgClientToGCPlaceStickersRequest.Types.StickerItem\>\(CMsgClientToGCPlaceStickersRequest.Types.StickerItem, params CMsgClientToGCPlaceStickersRequest.Types.StickerItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem__ctor"></a> StickerItem\(\)

```csharp
public StickerItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem__ctor_Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_"></a> StickerItem\(StickerItem\)

```csharp
public StickerItem(CMsgClientToGCPlaceStickersRequest.Types.StickerItem other)
```

#### Parameters

`other` [CMsgClientToGCPlaceStickersRequest](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersRequest.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersRequest.Types.md).[StickerItem](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersRequest.Types.StickerItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_PageNumFieldNumber"></a> PageNumFieldNumber

```csharp
public const int PageNumFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_StickerFieldNumber"></a> StickerFieldNumber

```csharp
public const int StickerFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_HasPageNum"></a> HasPageNum

```csharp
public bool HasPageNum { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_PageNum"></a> PageNum

```csharp
public uint PageNum { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCPlaceStickersRequest.Types.StickerItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCPlaceStickersRequest](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersRequest.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersRequest.Types.md).[StickerItem](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersRequest.Types.StickerItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_Sticker"></a> Sticker

```csharp
public CMsgStickerbookSticker Sticker { get; set; }
```

#### Property Value

 [CMsgStickerbookSticker](Divine.Protobufs.Dota2.CMsgStickerbookSticker.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_ClearPageNum"></a> ClearPageNum\(\)

```csharp
public void ClearPageNum()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCPlaceStickersRequest.Types.StickerItem Clone()
```

#### Returns

 [CMsgClientToGCPlaceStickersRequest](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersRequest.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersRequest.Types.md).[StickerItem](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersRequest.Types.StickerItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_Equals_Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_"></a> Equals\(StickerItem\)

```csharp
public bool Equals(CMsgClientToGCPlaceStickersRequest.Types.StickerItem other)
```

#### Parameters

`other` [CMsgClientToGCPlaceStickersRequest](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersRequest.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersRequest.Types.md).[StickerItem](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersRequest.Types.StickerItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_"></a> MergeFrom\(StickerItem\)

```csharp
public void MergeFrom(CMsgClientToGCPlaceStickersRequest.Types.StickerItem other)
```

#### Parameters

`other` [CMsgClientToGCPlaceStickersRequest](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersRequest.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersRequest.Types.md).[StickerItem](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersRequest.Types.StickerItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersRequest_Types_StickerItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

