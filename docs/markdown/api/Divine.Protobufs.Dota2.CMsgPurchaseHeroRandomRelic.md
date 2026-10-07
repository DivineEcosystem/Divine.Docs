# <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic"></a> Class CMsgPurchaseHeroRandomRelic

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPurchaseHeroRandomRelic : IMessage<CMsgPurchaseHeroRandomRelic>, IEquatable<CMsgPurchaseHeroRandomRelic>, IDeepCloneable<CMsgPurchaseHeroRandomRelic>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPurchaseHeroRandomRelic](Divine.Protobufs.Dota2.CMsgPurchaseHeroRandomRelic.md)

#### Implements

IMessage<CMsgPurchaseHeroRandomRelic\>, 
[IEquatable<CMsgPurchaseHeroRandomRelic\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPurchaseHeroRandomRelic\>, 
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
[EnumerableExtensions.In<CMsgPurchaseHeroRandomRelic\>\(CMsgPurchaseHeroRandomRelic, params CMsgPurchaseHeroRandomRelic\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic__ctor"></a> CMsgPurchaseHeroRandomRelic\(\)

```csharp
public CMsgPurchaseHeroRandomRelic()
```

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic__ctor_Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_"></a> CMsgPurchaseHeroRandomRelic\(CMsgPurchaseHeroRandomRelic\)

```csharp
public CMsgPurchaseHeroRandomRelic(CMsgPurchaseHeroRandomRelic other)
```

#### Parameters

`other` [CMsgPurchaseHeroRandomRelic](Divine.Protobufs.Dota2.CMsgPurchaseHeroRandomRelic.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_RelicRarityFieldNumber"></a> RelicRarityFieldNumber

```csharp
public const int RelicRarityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_HasRelicRarity"></a> HasRelicRarity

```csharp
public bool HasRelicRarity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPurchaseHeroRandomRelic> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPurchaseHeroRandomRelic](Divine.Protobufs.Dota2.CMsgPurchaseHeroRandomRelic.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_RelicRarity"></a> RelicRarity

```csharp
public EHeroRelicRarity RelicRarity { get; set; }
```

#### Property Value

 [EHeroRelicRarity](Divine.Protobufs.Dota2.EHeroRelicRarity.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_ClearRelicRarity"></a> ClearRelicRarity\(\)

```csharp
public void ClearRelicRarity()
```

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_Clone"></a> Clone\(\)

```csharp
public CMsgPurchaseHeroRandomRelic Clone()
```

#### Returns

 [CMsgPurchaseHeroRandomRelic](Divine.Protobufs.Dota2.CMsgPurchaseHeroRandomRelic.md)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_Equals_Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_"></a> Equals\(CMsgPurchaseHeroRandomRelic\)

```csharp
public bool Equals(CMsgPurchaseHeroRandomRelic other)
```

#### Parameters

`other` [CMsgPurchaseHeroRandomRelic](Divine.Protobufs.Dota2.CMsgPurchaseHeroRandomRelic.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_MergeFrom_Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_"></a> MergeFrom\(CMsgPurchaseHeroRandomRelic\)

```csharp
public void MergeFrom(CMsgPurchaseHeroRandomRelic other)
```

#### Parameters

`other` [CMsgPurchaseHeroRandomRelic](Divine.Protobufs.Dota2.CMsgPurchaseHeroRandomRelic.md)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelic_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

