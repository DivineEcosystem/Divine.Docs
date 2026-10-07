# <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero"></a> Class CMsgProfileResponse.Types.FeaturedHero

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgProfileResponse.Types.FeaturedHero : IMessage<CMsgProfileResponse.Types.FeaturedHero>, IEquatable<CMsgProfileResponse.Types.FeaturedHero>, IDeepCloneable<CMsgProfileResponse.Types.FeaturedHero>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgProfileResponse.Types.FeaturedHero](Divine.Protobufs.Dota2.CMsgProfileResponse.Types.FeaturedHero.md)

#### Implements

IMessage<CMsgProfileResponse.Types.FeaturedHero\>, 
[IEquatable<CMsgProfileResponse.Types.FeaturedHero\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgProfileResponse.Types.FeaturedHero\>, 
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
[EnumerableExtensions.In<CMsgProfileResponse.Types.FeaturedHero\>\(CMsgProfileResponse.Types.FeaturedHero, params CMsgProfileResponse.Types.FeaturedHero\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero__ctor"></a> FeaturedHero\(\)

```csharp
public FeaturedHero()
```

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero__ctor_Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_"></a> FeaturedHero\(FeaturedHero\)

```csharp
public FeaturedHero(CMsgProfileResponse.Types.FeaturedHero other)
```

#### Parameters

`other` [CMsgProfileResponse](Divine.Protobufs.Dota2.CMsgProfileResponse.md).[Types](Divine.Protobufs.Dota2.CMsgProfileResponse.Types.md).[FeaturedHero](Divine.Protobufs.Dota2.CMsgProfileResponse.Types.FeaturedHero.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_EquippedEconItemsFieldNumber"></a> EquippedEconItemsFieldNumber

```csharp
public const int EquippedEconItemsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_ManuallySetFieldNumber"></a> ManuallySetFieldNumber

```csharp
public const int ManuallySetFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_PlusHeroRelicsItemFieldNumber"></a> PlusHeroRelicsItemFieldNumber

```csharp
public const int PlusHeroRelicsItemFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_PlusHeroXpFieldNumber"></a> PlusHeroXpFieldNumber

```csharp
public const int PlusHeroXpFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_EquippedEconItems"></a> EquippedEconItems

```csharp
public RepeatedField<CSOEconItem> EquippedEconItems { get; }
```

#### Property Value

 RepeatedField<[CSOEconItem](Divine.Protobufs.Dota2.CSOEconItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_HasManuallySet"></a> HasManuallySet

```csharp
public bool HasManuallySet { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_HasPlusHeroXp"></a> HasPlusHeroXp

```csharp
public bool HasPlusHeroXp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_ManuallySet"></a> ManuallySet

```csharp
public bool ManuallySet { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_Parser"></a> Parser

```csharp
public static MessageParser<CMsgProfileResponse.Types.FeaturedHero> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgProfileResponse](Divine.Protobufs.Dota2.CMsgProfileResponse.md).[Types](Divine.Protobufs.Dota2.CMsgProfileResponse.Types.md).[FeaturedHero](Divine.Protobufs.Dota2.CMsgProfileResponse.Types.FeaturedHero.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_PlusHeroRelicsItem"></a> PlusHeroRelicsItem

```csharp
public CSOEconItem PlusHeroRelicsItem { get; set; }
```

#### Property Value

 [CSOEconItem](Divine.Protobufs.Dota2.CSOEconItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_PlusHeroXp"></a> PlusHeroXp

```csharp
public uint PlusHeroXp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_ClearManuallySet"></a> ClearManuallySet\(\)

```csharp
public void ClearManuallySet()
```

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_ClearPlusHeroXp"></a> ClearPlusHeroXp\(\)

```csharp
public void ClearPlusHeroXp()
```

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_Clone"></a> Clone\(\)

```csharp
public CMsgProfileResponse.Types.FeaturedHero Clone()
```

#### Returns

 [CMsgProfileResponse](Divine.Protobufs.Dota2.CMsgProfileResponse.md).[Types](Divine.Protobufs.Dota2.CMsgProfileResponse.Types.md).[FeaturedHero](Divine.Protobufs.Dota2.CMsgProfileResponse.Types.FeaturedHero.md)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_Equals_Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_"></a> Equals\(FeaturedHero\)

```csharp
public bool Equals(CMsgProfileResponse.Types.FeaturedHero other)
```

#### Parameters

`other` [CMsgProfileResponse](Divine.Protobufs.Dota2.CMsgProfileResponse.md).[Types](Divine.Protobufs.Dota2.CMsgProfileResponse.Types.md).[FeaturedHero](Divine.Protobufs.Dota2.CMsgProfileResponse.Types.FeaturedHero.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_MergeFrom_Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_"></a> MergeFrom\(FeaturedHero\)

```csharp
public void MergeFrom(CMsgProfileResponse.Types.FeaturedHero other)
```

#### Parameters

`other` [CMsgProfileResponse](Divine.Protobufs.Dota2.CMsgProfileResponse.md).[Types](Divine.Protobufs.Dota2.CMsgProfileResponse.Types.md).[FeaturedHero](Divine.Protobufs.Dota2.CMsgProfileResponse.Types.FeaturedHero.md)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgProfileResponse_Types_FeaturedHero_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

