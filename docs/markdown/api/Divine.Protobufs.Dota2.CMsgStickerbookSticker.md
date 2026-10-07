# <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker"></a> Class CMsgStickerbookSticker

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgStickerbookSticker : IMessage<CMsgStickerbookSticker>, IEquatable<CMsgStickerbookSticker>, IDeepCloneable<CMsgStickerbookSticker>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgStickerbookSticker](Divine.Protobufs.Dota2.CMsgStickerbookSticker.md)

#### Implements

IMessage<CMsgStickerbookSticker\>, 
[IEquatable<CMsgStickerbookSticker\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgStickerbookSticker\>, 
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
[EnumerableExtensions.In<CMsgStickerbookSticker\>\(CMsgStickerbookSticker, params CMsgStickerbookSticker\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker__ctor"></a> CMsgStickerbookSticker\(\)

```csharp
public CMsgStickerbookSticker()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker__ctor_Divine_Protobufs_Dota2_CMsgStickerbookSticker_"></a> CMsgStickerbookSticker\(CMsgStickerbookSticker\)

```csharp
public CMsgStickerbookSticker(CMsgStickerbookSticker other)
```

#### Parameters

`other` [CMsgStickerbookSticker](Divine.Protobufs.Dota2.CMsgStickerbookSticker.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_DepthBiasFieldNumber"></a> DepthBiasFieldNumber

```csharp
public const int DepthBiasFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_ItemDefIdFieldNumber"></a> ItemDefIdFieldNumber

```csharp
public const int ItemDefIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_PositionXFieldNumber"></a> PositionXFieldNumber

```csharp
public const int PositionXFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_PositionYFieldNumber"></a> PositionYFieldNumber

```csharp
public const int PositionYFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_PositionZFieldNumber"></a> PositionZFieldNumber

```csharp
public const int PositionZFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_QualityFieldNumber"></a> QualityFieldNumber

```csharp
public const int QualityFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_RotationFieldNumber"></a> RotationFieldNumber

```csharp
public const int RotationFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_ScaleFieldNumber"></a> ScaleFieldNumber

```csharp
public const int ScaleFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_SourceItemIdFieldNumber"></a> SourceItemIdFieldNumber

```csharp
public const int SourceItemIdFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_StickerNumFieldNumber"></a> StickerNumFieldNumber

```csharp
public const int StickerNumFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_DepthBias"></a> DepthBias

```csharp
public uint DepthBias { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_HasDepthBias"></a> HasDepthBias

```csharp
public bool HasDepthBias { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_HasItemDefId"></a> HasItemDefId

```csharp
public bool HasItemDefId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_HasPositionX"></a> HasPositionX

```csharp
public bool HasPositionX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_HasPositionY"></a> HasPositionY

```csharp
public bool HasPositionY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_HasPositionZ"></a> HasPositionZ

```csharp
public bool HasPositionZ { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_HasQuality"></a> HasQuality

```csharp
public bool HasQuality { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_HasRotation"></a> HasRotation

```csharp
public bool HasRotation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_HasScale"></a> HasScale

```csharp
public bool HasScale { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_HasSourceItemId"></a> HasSourceItemId

```csharp
public bool HasSourceItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_HasStickerNum"></a> HasStickerNum

```csharp
public bool HasStickerNum { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_ItemDefId"></a> ItemDefId

```csharp
public uint ItemDefId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_Parser"></a> Parser

```csharp
public static MessageParser<CMsgStickerbookSticker> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgStickerbookSticker](Divine.Protobufs.Dota2.CMsgStickerbookSticker.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_PositionX"></a> PositionX

```csharp
public float PositionX { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_PositionY"></a> PositionY

```csharp
public float PositionY { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_PositionZ"></a> PositionZ

```csharp
public float PositionZ { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_Quality"></a> Quality

```csharp
public uint Quality { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_Rotation"></a> Rotation

```csharp
public float Rotation { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_Scale"></a> Scale

```csharp
public float Scale { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_SourceItemId"></a> SourceItemId

```csharp
public ulong SourceItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_StickerNum"></a> StickerNum

```csharp
public uint StickerNum { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_ClearDepthBias"></a> ClearDepthBias\(\)

```csharp
public void ClearDepthBias()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_ClearItemDefId"></a> ClearItemDefId\(\)

```csharp
public void ClearItemDefId()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_ClearPositionX"></a> ClearPositionX\(\)

```csharp
public void ClearPositionX()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_ClearPositionY"></a> ClearPositionY\(\)

```csharp
public void ClearPositionY()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_ClearPositionZ"></a> ClearPositionZ\(\)

```csharp
public void ClearPositionZ()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_ClearQuality"></a> ClearQuality\(\)

```csharp
public void ClearQuality()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_ClearRotation"></a> ClearRotation\(\)

```csharp
public void ClearRotation()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_ClearScale"></a> ClearScale\(\)

```csharp
public void ClearScale()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_ClearSourceItemId"></a> ClearSourceItemId\(\)

```csharp
public void ClearSourceItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_ClearStickerNum"></a> ClearStickerNum\(\)

```csharp
public void ClearStickerNum()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_Clone"></a> Clone\(\)

```csharp
public CMsgStickerbookSticker Clone()
```

#### Returns

 [CMsgStickerbookSticker](Divine.Protobufs.Dota2.CMsgStickerbookSticker.md)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_Equals_Divine_Protobufs_Dota2_CMsgStickerbookSticker_"></a> Equals\(CMsgStickerbookSticker\)

```csharp
public bool Equals(CMsgStickerbookSticker other)
```

#### Parameters

`other` [CMsgStickerbookSticker](Divine.Protobufs.Dota2.CMsgStickerbookSticker.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_MergeFrom_Divine_Protobufs_Dota2_CMsgStickerbookSticker_"></a> MergeFrom\(CMsgStickerbookSticker\)

```csharp
public void MergeFrom(CMsgStickerbookSticker other)
```

#### Parameters

`other` [CMsgStickerbookSticker](Divine.Protobufs.Dota2.CMsgStickerbookSticker.md)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookSticker_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

