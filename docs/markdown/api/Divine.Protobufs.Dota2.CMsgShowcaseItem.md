# <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem"></a> Class CMsgShowcaseItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseItem : IMessage<CMsgShowcaseItem>, IEquatable<CMsgShowcaseItem>, IDeepCloneable<CMsgShowcaseItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseItem](Divine.Protobufs.Dota2.CMsgShowcaseItem.md)

#### Implements

IMessage<CMsgShowcaseItem\>, 
[IEquatable<CMsgShowcaseItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseItem\>, 
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
[EnumerableExtensions.In<CMsgShowcaseItem\>\(CMsgShowcaseItem, params CMsgShowcaseItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem__ctor"></a> CMsgShowcaseItem\(\)

```csharp
public CMsgShowcaseItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem__ctor_Divine_Protobufs_Dota2_CMsgShowcaseItem_"></a> CMsgShowcaseItem\(CMsgShowcaseItem\)

```csharp
public CMsgShowcaseItem(CMsgShowcaseItem other)
```

#### Parameters

`other` [CMsgShowcaseItem](Divine.Protobufs.Dota2.CMsgShowcaseItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ItemDataFieldNumber"></a> ItemDataFieldNumber

```csharp
public const int ItemDataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ItemPositionFieldNumber"></a> ItemPositionFieldNumber

```csharp
public const int ItemPositionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ShowcaseItemIdFieldNumber"></a> ShowcaseItemIdFieldNumber

```csharp
public const int ShowcaseItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_StateFieldNumber"></a> StateFieldNumber

```csharp
public const int StateFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HasShowcaseItemId"></a> HasShowcaseItemId

```csharp
public bool HasShowcaseItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HasState"></a> HasState

```csharp
public bool HasState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ItemData"></a> ItemData

```csharp
public CMsgShowcaseItemData ItemData { get; set; }
```

#### Property Value

 [CMsgShowcaseItemData](Divine.Protobufs.Dota2.CMsgShowcaseItemData.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ItemPosition"></a> ItemPosition

```csharp
public CMsgShowcaseItemPosition ItemPosition { get; set; }
```

#### Property Value

 [CMsgShowcaseItemPosition](Divine.Protobufs.Dota2.CMsgShowcaseItemPosition.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseItem](Divine.Protobufs.Dota2.CMsgShowcaseItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ShowcaseItemId"></a> ShowcaseItemId

```csharp
public uint ShowcaseItemId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_State"></a> State

```csharp
public EShowcaseItemState State { get; set; }
```

#### Property Value

 [EShowcaseItemState](Divine.Protobufs.Dota2.EShowcaseItemState.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ClearShowcaseItemId"></a> ClearShowcaseItemId\(\)

```csharp
public void ClearShowcaseItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ClearState"></a> ClearState\(\)

```csharp
public void ClearState()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseItem Clone()
```

#### Returns

 [CMsgShowcaseItem](Divine.Protobufs.Dota2.CMsgShowcaseItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Equals_Divine_Protobufs_Dota2_CMsgShowcaseItem_"></a> Equals\(CMsgShowcaseItem\)

```csharp
public bool Equals(CMsgShowcaseItem other)
```

#### Parameters

`other` [CMsgShowcaseItem](Divine.Protobufs.Dota2.CMsgShowcaseItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseItem_"></a> MergeFrom\(CMsgShowcaseItem\)

```csharp
public void MergeFrom(CMsgShowcaseItem other)
```

#### Parameters

`other` [CMsgShowcaseItem](Divine.Protobufs.Dota2.CMsgShowcaseItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

