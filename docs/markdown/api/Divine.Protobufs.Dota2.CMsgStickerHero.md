# <a id="Divine_Protobufs_Dota2_CMsgStickerHero"></a> Class CMsgStickerHero

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgStickerHero : IMessage<CMsgStickerHero>, IEquatable<CMsgStickerHero>, IDeepCloneable<CMsgStickerHero>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgStickerHero](Divine.Protobufs.Dota2.CMsgStickerHero.md)

#### Implements

IMessage<CMsgStickerHero\>, 
[IEquatable<CMsgStickerHero\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgStickerHero\>, 
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
[EnumerableExtensions.In<CMsgStickerHero\>\(CMsgStickerHero, params CMsgStickerHero\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero__ctor"></a> CMsgStickerHero\(\)

```csharp
public CMsgStickerHero()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero__ctor_Divine_Protobufs_Dota2_CMsgStickerHero_"></a> CMsgStickerHero\(CMsgStickerHero\)

```csharp
public CMsgStickerHero(CMsgStickerHero other)
```

#### Parameters

`other` [CMsgStickerHero](Divine.Protobufs.Dota2.CMsgStickerHero.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_ItemDefIdFieldNumber"></a> ItemDefIdFieldNumber

```csharp
public const int ItemDefIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_QualityFieldNumber"></a> QualityFieldNumber

```csharp
public const int QualityFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_SourceItemIdFieldNumber"></a> SourceItemIdFieldNumber

```csharp
public const int SourceItemIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_HasItemDefId"></a> HasItemDefId

```csharp
public bool HasItemDefId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_HasQuality"></a> HasQuality

```csharp
public bool HasQuality { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_HasSourceItemId"></a> HasSourceItemId

```csharp
public bool HasSourceItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_ItemDefId"></a> ItemDefId

```csharp
public uint ItemDefId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_Parser"></a> Parser

```csharp
public static MessageParser<CMsgStickerHero> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgStickerHero](Divine.Protobufs.Dota2.CMsgStickerHero.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_Quality"></a> Quality

```csharp
public uint Quality { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_SourceItemId"></a> SourceItemId

```csharp
public ulong SourceItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_ClearItemDefId"></a> ClearItemDefId\(\)

```csharp
public void ClearItemDefId()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_ClearQuality"></a> ClearQuality\(\)

```csharp
public void ClearQuality()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_ClearSourceItemId"></a> ClearSourceItemId\(\)

```csharp
public void ClearSourceItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_Clone"></a> Clone\(\)

```csharp
public CMsgStickerHero Clone()
```

#### Returns

 [CMsgStickerHero](Divine.Protobufs.Dota2.CMsgStickerHero.md)

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_Equals_Divine_Protobufs_Dota2_CMsgStickerHero_"></a> Equals\(CMsgStickerHero\)

```csharp
public bool Equals(CMsgStickerHero other)
```

#### Parameters

`other` [CMsgStickerHero](Divine.Protobufs.Dota2.CMsgStickerHero.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_MergeFrom_Divine_Protobufs_Dota2_CMsgStickerHero_"></a> MergeFrom\(CMsgStickerHero\)

```csharp
public void MergeFrom(CMsgStickerHero other)
```

#### Parameters

`other` [CMsgStickerHero](Divine.Protobufs.Dota2.CMsgStickerHero.md)

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgStickerHero_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

