# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem"></a> Class CDOTAClientMsg\_RerollNeutralItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_RerollNeutralItem : IMessage<CDOTAClientMsg_RerollNeutralItem>, IEquatable<CDOTAClientMsg_RerollNeutralItem>, IDeepCloneable<CDOTAClientMsg_RerollNeutralItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_RerollNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_RerollNeutralItem.md)

#### Implements

IMessage<CDOTAClientMsg\_RerollNeutralItem\>, 
[IEquatable<CDOTAClientMsg\_RerollNeutralItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_RerollNeutralItem\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_RerollNeutralItem\>\(CDOTAClientMsg\_RerollNeutralItem, params CDOTAClientMsg\_RerollNeutralItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem__ctor"></a> CDOTAClientMsg\_RerollNeutralItem\(\)

```csharp
public CDOTAClientMsg_RerollNeutralItem()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_"></a> CDOTAClientMsg\_RerollNeutralItem\(CDOTAClientMsg\_RerollNeutralItem\)

```csharp
public CDOTAClientMsg_RerollNeutralItem(CDOTAClientMsg_RerollNeutralItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_RerollNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_RerollNeutralItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_SlotIndexFieldNumber"></a> SlotIndexFieldNumber

```csharp
public const int SlotIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_TargetEntindexFieldNumber"></a> TargetEntindexFieldNumber

```csharp
public const int TargetEntindexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_HasSlotIndex"></a> HasSlotIndex

```csharp
public bool HasSlotIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_HasTargetEntindex"></a> HasTargetEntindex

```csharp
public bool HasTargetEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_RerollNeutralItem> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_RerollNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_RerollNeutralItem.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_SlotIndex"></a> SlotIndex

```csharp
public int SlotIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_TargetEntindex"></a> TargetEntindex

```csharp
public int TargetEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_ClearSlotIndex"></a> ClearSlotIndex\(\)

```csharp
public void ClearSlotIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_ClearTargetEntindex"></a> ClearTargetEntindex\(\)

```csharp
public void ClearTargetEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_RerollNeutralItem Clone()
```

#### Returns

 [CDOTAClientMsg\_RerollNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_RerollNeutralItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_"></a> Equals\(CDOTAClientMsg\_RerollNeutralItem\)

```csharp
public bool Equals(CDOTAClientMsg_RerollNeutralItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_RerollNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_RerollNeutralItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_"></a> MergeFrom\(CDOTAClientMsg\_RerollNeutralItem\)

```csharp
public void MergeFrom(CDOTAClientMsg_RerollNeutralItem other)
```

#### Parameters

`other` [CDOTAClientMsg\_RerollNeutralItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_RerollNeutralItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RerollNeutralItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

