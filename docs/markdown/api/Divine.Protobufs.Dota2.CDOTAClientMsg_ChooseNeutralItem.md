# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem"></a> Class CDOTAClientMsg\_ChooseNeutralItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_ChooseNeutralItem : IMessage<CDOTAClientMsg_ChooseNeutralItem>, IEquatable<CDOTAClientMsg_ChooseNeutralItem>, IDeepCloneable<CDOTAClientMsg_ChooseNeutralItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_ChooseNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseNeutralItem.md)

#### Implements

IMessage<CDOTAClientMsg\_ChooseNeutralItem\>, 
[IEquatable<CDOTAClientMsg\_ChooseNeutralItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_ChooseNeutralItem\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_ChooseNeutralItem\>\(CDOTAClientMsg\_ChooseNeutralItem, params CDOTAClientMsg\_ChooseNeutralItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem__ctor"></a> CDOTAClientMsg\_ChooseNeutralItem\(\)

```csharp
public CDOTAClientMsg_ChooseNeutralItem()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_"></a> CDOTAClientMsg\_ChooseNeutralItem\(CDOTAClientMsg\_ChooseNeutralItem\)

```csharp
public CDOTAClientMsg_ChooseNeutralItem(CDOTAClientMsg_ChooseNeutralItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChooseNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseNeutralItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_NeutralItemIndexFieldNumber"></a> NeutralItemIndexFieldNumber

```csharp
public const int NeutralItemIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_SlotIndexFieldNumber"></a> SlotIndexFieldNumber

```csharp
public const int SlotIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_TargetEntindexFieldNumber"></a> TargetEntindexFieldNumber

```csharp
public const int TargetEntindexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_HasNeutralItemIndex"></a> HasNeutralItemIndex

```csharp
public bool HasNeutralItemIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_HasSlotIndex"></a> HasSlotIndex

```csharp
public bool HasSlotIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_HasTargetEntindex"></a> HasTargetEntindex

```csharp
public bool HasTargetEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_NeutralItemIndex"></a> NeutralItemIndex

```csharp
public int NeutralItemIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_ChooseNeutralItem> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_ChooseNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseNeutralItem.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_SlotIndex"></a> SlotIndex

```csharp
public int SlotIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_TargetEntindex"></a> TargetEntindex

```csharp
public int TargetEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_ClearNeutralItemIndex"></a> ClearNeutralItemIndex\(\)

```csharp
public void ClearNeutralItemIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_ClearSlotIndex"></a> ClearSlotIndex\(\)

```csharp
public void ClearSlotIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_ClearTargetEntindex"></a> ClearTargetEntindex\(\)

```csharp
public void ClearTargetEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_ChooseNeutralItem Clone()
```

#### Returns

 [CDOTAClientMsg\_ChooseNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseNeutralItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_"></a> Equals\(CDOTAClientMsg\_ChooseNeutralItem\)

```csharp
public bool Equals(CDOTAClientMsg_ChooseNeutralItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChooseNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseNeutralItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_"></a> MergeFrom\(CDOTAClientMsg\_ChooseNeutralItem\)

```csharp
public void MergeFrom(CDOTAClientMsg_ChooseNeutralItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChooseNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseNeutralItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseNeutralItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

