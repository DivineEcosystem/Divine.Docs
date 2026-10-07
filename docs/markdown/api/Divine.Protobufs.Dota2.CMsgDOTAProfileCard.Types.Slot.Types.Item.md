# <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item"></a> Class CMsgDOTAProfileCard.Types.Slot.Types.Item

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAProfileCard.Types.Slot.Types.Item : IMessage<CMsgDOTAProfileCard.Types.Slot.Types.Item>, IEquatable<CMsgDOTAProfileCard.Types.Slot.Types.Item>, IDeepCloneable<CMsgDOTAProfileCard.Types.Slot.Types.Item>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAProfileCard.Types.Slot.Types.Item](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Item.md)

#### Implements

IMessage<CMsgDOTAProfileCard.Types.Slot.Types.Item\>, 
[IEquatable<CMsgDOTAProfileCard.Types.Slot.Types.Item\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAProfileCard.Types.Slot.Types.Item\>, 
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
[EnumerableExtensions.In<CMsgDOTAProfileCard.Types.Slot.Types.Item\>\(CMsgDOTAProfileCard.Types.Slot.Types.Item, params CMsgDOTAProfileCard.Types.Slot.Types.Item\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item__ctor"></a> Item\(\)

```csharp
public Item()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item__ctor_Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_"></a> Item\(Item\)

```csharp
public Item(CMsgDOTAProfileCard.Types.Slot.Types.Item other)
```

#### Parameters

`other` [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Item](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Item.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_SerializedItemFieldNumber"></a> SerializedItemFieldNumber

```csharp
public const int SerializedItemFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_HasSerializedItem"></a> HasSerializedItem

```csharp
public bool HasSerializedItem { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAProfileCard.Types.Slot.Types.Item> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Item](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Item.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_SerializedItem"></a> SerializedItem

```csharp
public ByteString SerializedItem { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_ClearSerializedItem"></a> ClearSerializedItem\(\)

```csharp
public void ClearSerializedItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAProfileCard.Types.Slot.Types.Item Clone()
```

#### Returns

 [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Item](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Item.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_Equals_Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_"></a> Equals\(Item\)

```csharp
public bool Equals(CMsgDOTAProfileCard.Types.Slot.Types.Item other)
```

#### Parameters

`other` [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Item](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Item.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_"></a> MergeFrom\(Item\)

```csharp
public void MergeFrom(CMsgDOTAProfileCard.Types.Slot.Types.Item other)
```

#### Parameters

`other` [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Item](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Item.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Item_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

