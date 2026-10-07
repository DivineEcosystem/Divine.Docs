# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero"></a> Class CDOTAClientMsg\_DemoHero

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_DemoHero : IMessage<CDOTAClientMsg_DemoHero>, IEquatable<CDOTAClientMsg_DemoHero>, IDeepCloneable<CDOTAClientMsg_DemoHero>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_DemoHero](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.md)

#### Implements

IMessage<CDOTAClientMsg\_DemoHero\>, 
[IEquatable<CDOTAClientMsg\_DemoHero\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_DemoHero\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_DemoHero\>\(CDOTAClientMsg\_DemoHero, params CDOTAClientMsg\_DemoHero\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero__ctor"></a> CDOTAClientMsg\_DemoHero\(\)

```csharp
public CDOTAClientMsg_DemoHero()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_"></a> CDOTAClientMsg\_DemoHero\(CDOTAClientMsg\_DemoHero\)

```csharp
public CDOTAClientMsg_DemoHero(CDOTAClientMsg_DemoHero other)
```

#### Parameters

`other` [CDOTAClientMsg\_DemoHero](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_HeroIdToSpawnFieldNumber"></a> HeroIdToSpawnFieldNumber

```csharp
public const int HeroIdToSpawnFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_HeroVariantFieldNumber"></a> HeroVariantFieldNumber

```csharp
public const int HeroVariantFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_ItemDataFieldNumber"></a> ItemDataFieldNumber

```csharp
public const int ItemDataFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_ItemIdsFieldNumber"></a> ItemIdsFieldNumber

```csharp
public const int ItemIdsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_KeepExistingDemoheroFieldNumber"></a> KeepExistingDemoheroFieldNumber

```csharp
public const int KeepExistingDemoheroFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_PreviewItemsFieldNumber"></a> PreviewItemsFieldNumber

```csharp
public const int PreviewItemsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_StyleIndexOverrideFieldNumber"></a> StyleIndexOverrideFieldNumber

```csharp
public const int StyleIndexOverrideFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_HasHeroIdToSpawn"></a> HasHeroIdToSpawn

```csharp
public bool HasHeroIdToSpawn { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_HasHeroVariant"></a> HasHeroVariant

```csharp
public bool HasHeroVariant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_HasKeepExistingDemohero"></a> HasKeepExistingDemohero

```csharp
public bool HasKeepExistingDemohero { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_HasStyleIndexOverride"></a> HasStyleIndexOverride

```csharp
public bool HasStyleIndexOverride { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_HeroIdToSpawn"></a> HeroIdToSpawn

```csharp
public int HeroIdToSpawn { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_HeroVariant"></a> HeroVariant

```csharp
public int HeroVariant { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_ItemData"></a> ItemData

```csharp
public RepeatedField<CSOEconItem> ItemData { get; }
```

#### Property Value

 RepeatedField<[CSOEconItem](Divine.Protobufs.Dota2.CSOEconItem.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_ItemIds"></a> ItemIds

```csharp
public RepeatedField<ulong> ItemIds { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_KeepExistingDemohero"></a> KeepExistingDemohero

```csharp
public bool KeepExistingDemohero { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_DemoHero> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_DemoHero](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_PreviewItems"></a> PreviewItems

```csharp
public RepeatedField<CDOTAClientMsg_DemoHero.Types.PreviewItem> PreviewItems { get; }
```

#### Property Value

 RepeatedField<[CDOTAClientMsg\_DemoHero](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.md).[Types](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.Types.md).[PreviewItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.Types.PreviewItem.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_StyleIndexOverride"></a> StyleIndexOverride

```csharp
public uint StyleIndexOverride { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_ClearHeroIdToSpawn"></a> ClearHeroIdToSpawn\(\)

```csharp
public void ClearHeroIdToSpawn()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_ClearHeroVariant"></a> ClearHeroVariant\(\)

```csharp
public void ClearHeroVariant()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_ClearKeepExistingDemohero"></a> ClearKeepExistingDemohero\(\)

```csharp
public void ClearKeepExistingDemohero()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_ClearStyleIndexOverride"></a> ClearStyleIndexOverride\(\)

```csharp
public void ClearStyleIndexOverride()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_DemoHero Clone()
```

#### Returns

 [CDOTAClientMsg\_DemoHero](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_"></a> Equals\(CDOTAClientMsg\_DemoHero\)

```csharp
public bool Equals(CDOTAClientMsg_DemoHero other)
```

#### Parameters

`other` [CDOTAClientMsg\_DemoHero](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_"></a> MergeFrom\(CDOTAClientMsg\_DemoHero\)

```csharp
public void MergeFrom(CDOTAClientMsg_DemoHero other)
```

#### Parameters

`other` [CDOTAClientMsg\_DemoHero](Divine.Protobufs.Dota2.CDOTAClientMsg\_DemoHero.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DemoHero_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

