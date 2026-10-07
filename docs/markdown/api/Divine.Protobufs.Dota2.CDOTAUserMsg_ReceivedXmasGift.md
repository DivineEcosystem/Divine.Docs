# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift"></a> Class CDOTAUserMsg\_ReceivedXmasGift

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_ReceivedXmasGift : IMessage<CDOTAUserMsg_ReceivedXmasGift>, IEquatable<CDOTAUserMsg_ReceivedXmasGift>, IDeepCloneable<CDOTAUserMsg_ReceivedXmasGift>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_ReceivedXmasGift](Divine.Protobufs.Dota2.CDOTAUserMsg\_ReceivedXmasGift.md)

#### Implements

IMessage<CDOTAUserMsg\_ReceivedXmasGift\>, 
[IEquatable<CDOTAUserMsg\_ReceivedXmasGift\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_ReceivedXmasGift\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_ReceivedXmasGift\>\(CDOTAUserMsg\_ReceivedXmasGift, params CDOTAUserMsg\_ReceivedXmasGift\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift__ctor"></a> CDOTAUserMsg\_ReceivedXmasGift\(\)

```csharp
public CDOTAUserMsg_ReceivedXmasGift()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_"></a> CDOTAUserMsg\_ReceivedXmasGift\(CDOTAUserMsg\_ReceivedXmasGift\)

```csharp
public CDOTAUserMsg_ReceivedXmasGift(CDOTAUserMsg_ReceivedXmasGift other)
```

#### Parameters

`other` [CDOTAUserMsg\_ReceivedXmasGift](Divine.Protobufs.Dota2.CDOTAUserMsg\_ReceivedXmasGift.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_InventorySlotFieldNumber"></a> InventorySlotFieldNumber

```csharp
public const int InventorySlotFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_ItemNameFieldNumber"></a> ItemNameFieldNumber

```csharp
public const int ItemNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_HasInventorySlot"></a> HasInventorySlot

```csharp
public bool HasInventorySlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_HasItemName"></a> HasItemName

```csharp
public bool HasItemName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_InventorySlot"></a> InventorySlot

```csharp
public int InventorySlot { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_ItemName"></a> ItemName

```csharp
public string ItemName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_ReceivedXmasGift> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_ReceivedXmasGift](Divine.Protobufs.Dota2.CDOTAUserMsg\_ReceivedXmasGift.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_ClearInventorySlot"></a> ClearInventorySlot\(\)

```csharp
public void ClearInventorySlot()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_ClearItemName"></a> ClearItemName\(\)

```csharp
public void ClearItemName()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_ReceivedXmasGift Clone()
```

#### Returns

 [CDOTAUserMsg\_ReceivedXmasGift](Divine.Protobufs.Dota2.CDOTAUserMsg\_ReceivedXmasGift.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_"></a> Equals\(CDOTAUserMsg\_ReceivedXmasGift\)

```csharp
public bool Equals(CDOTAUserMsg_ReceivedXmasGift other)
```

#### Parameters

`other` [CDOTAUserMsg\_ReceivedXmasGift](Divine.Protobufs.Dota2.CDOTAUserMsg\_ReceivedXmasGift.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_"></a> MergeFrom\(CDOTAUserMsg\_ReceivedXmasGift\)

```csharp
public void MergeFrom(CDOTAUserMsg_ReceivedXmasGift other)
```

#### Parameters

`other` [CDOTAUserMsg\_ReceivedXmasGift](Divine.Protobufs.Dota2.CDOTAUserMsg\_ReceivedXmasGift.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReceivedXmasGift_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

