# <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition"></a> Class CMsgSetItemPositions.Types.ItemPosition

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSetItemPositions.Types.ItemPosition : IMessage<CMsgSetItemPositions.Types.ItemPosition>, IEquatable<CMsgSetItemPositions.Types.ItemPosition>, IDeepCloneable<CMsgSetItemPositions.Types.ItemPosition>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSetItemPositions.Types.ItemPosition](Divine.Protobufs.Dota2.CMsgSetItemPositions.Types.ItemPosition.md)

#### Implements

IMessage<CMsgSetItemPositions.Types.ItemPosition\>, 
[IEquatable<CMsgSetItemPositions.Types.ItemPosition\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSetItemPositions.Types.ItemPosition\>, 
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
[EnumerableExtensions.In<CMsgSetItemPositions.Types.ItemPosition\>\(CMsgSetItemPositions.Types.ItemPosition, params CMsgSetItemPositions.Types.ItemPosition\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition__ctor"></a> ItemPosition\(\)

```csharp
public ItemPosition()
```

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition__ctor_Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_"></a> ItemPosition\(ItemPosition\)

```csharp
public ItemPosition(CMsgSetItemPositions.Types.ItemPosition other)
```

#### Parameters

`other` [CMsgSetItemPositions](Divine.Protobufs.Dota2.CMsgSetItemPositions.md).[Types](Divine.Protobufs.Dota2.CMsgSetItemPositions.Types.md).[ItemPosition](Divine.Protobufs.Dota2.CMsgSetItemPositions.Types.ItemPosition.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_PositionFieldNumber"></a> PositionFieldNumber

```csharp
public const int PositionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_HasPosition"></a> HasPosition

```csharp
public bool HasPosition { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSetItemPositions.Types.ItemPosition> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSetItemPositions](Divine.Protobufs.Dota2.CMsgSetItemPositions.md).[Types](Divine.Protobufs.Dota2.CMsgSetItemPositions.Types.md).[ItemPosition](Divine.Protobufs.Dota2.CMsgSetItemPositions.Types.ItemPosition.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_Position"></a> Position

```csharp
public uint Position { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_ClearPosition"></a> ClearPosition\(\)

```csharp
public void ClearPosition()
```

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_Clone"></a> Clone\(\)

```csharp
public CMsgSetItemPositions.Types.ItemPosition Clone()
```

#### Returns

 [CMsgSetItemPositions](Divine.Protobufs.Dota2.CMsgSetItemPositions.md).[Types](Divine.Protobufs.Dota2.CMsgSetItemPositions.Types.md).[ItemPosition](Divine.Protobufs.Dota2.CMsgSetItemPositions.Types.ItemPosition.md)

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_Equals_Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_"></a> Equals\(ItemPosition\)

```csharp
public bool Equals(CMsgSetItemPositions.Types.ItemPosition other)
```

#### Parameters

`other` [CMsgSetItemPositions](Divine.Protobufs.Dota2.CMsgSetItemPositions.md).[Types](Divine.Protobufs.Dota2.CMsgSetItemPositions.Types.md).[ItemPosition](Divine.Protobufs.Dota2.CMsgSetItemPositions.Types.ItemPosition.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_MergeFrom_Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_"></a> MergeFrom\(ItemPosition\)

```csharp
public void MergeFrom(CMsgSetItemPositions.Types.ItemPosition other)
```

#### Parameters

`other` [CMsgSetItemPositions](Divine.Protobufs.Dota2.CMsgSetItemPositions.md).[Types](Divine.Protobufs.Dota2.CMsgSetItemPositions.Types.md).[ItemPosition](Divine.Protobufs.Dota2.CMsgSetItemPositions.Types.ItemPosition.md)

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Types_ItemPosition_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

