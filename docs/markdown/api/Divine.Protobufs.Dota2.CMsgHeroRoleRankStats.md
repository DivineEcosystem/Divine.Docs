# <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats"></a> Class CMsgHeroRoleRankStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgHeroRoleRankStats : IMessage<CMsgHeroRoleRankStats>, IEquatable<CMsgHeroRoleRankStats>, IDeepCloneable<CMsgHeroRoleRankStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgHeroRoleRankStats](Divine.Protobufs.Dota2.CMsgHeroRoleRankStats.md)

#### Implements

IMessage<CMsgHeroRoleRankStats\>, 
[IEquatable<CMsgHeroRoleRankStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgHeroRoleRankStats\>, 
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
[EnumerableExtensions.In<CMsgHeroRoleRankStats\>\(CMsgHeroRoleRankStats, params CMsgHeroRoleRankStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats__ctor"></a> CMsgHeroRoleRankStats\(\)

```csharp
public CMsgHeroRoleRankStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats__ctor_Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_"></a> CMsgHeroRoleRankStats\(CMsgHeroRoleRankStats\)

```csharp
public CMsgHeroRoleRankStats(CMsgHeroRoleRankStats other)
```

#### Parameters

`other` [CMsgHeroRoleRankStats](Divine.Protobufs.Dota2.CMsgHeroRoleRankStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_HeroStatsFieldNumber"></a> HeroStatsFieldNumber

```csharp
public const int HeroStatsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_RankTierFieldNumber"></a> RankTierFieldNumber

```csharp
public const int RankTierFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_HasRankTier"></a> HasRankTier

```csharp
public bool HasRankTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_HeroStats"></a> HeroStats

```csharp
public RepeatedField<CMsgHeroRoleHeroStats> HeroStats { get; }
```

#### Property Value

 RepeatedField<[CMsgHeroRoleHeroStats](Divine.Protobufs.Dota2.CMsgHeroRoleHeroStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgHeroRoleRankStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgHeroRoleRankStats](Divine.Protobufs.Dota2.CMsgHeroRoleRankStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_RankTier"></a> RankTier

```csharp
public uint RankTier { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_ClearRankTier"></a> ClearRankTier\(\)

```csharp
public void ClearRankTier()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_Clone"></a> Clone\(\)

```csharp
public CMsgHeroRoleRankStats Clone()
```

#### Returns

 [CMsgHeroRoleRankStats](Divine.Protobufs.Dota2.CMsgHeroRoleRankStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_Equals_Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_"></a> Equals\(CMsgHeroRoleRankStats\)

```csharp
public bool Equals(CMsgHeroRoleRankStats other)
```

#### Parameters

`other` [CMsgHeroRoleRankStats](Divine.Protobufs.Dota2.CMsgHeroRoleRankStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_MergeFrom_Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_"></a> MergeFrom\(CMsgHeroRoleRankStats\)

```csharp
public void MergeFrom(CMsgHeroRoleRankStats other)
```

#### Parameters

`other` [CMsgHeroRoleRankStats](Divine.Protobufs.Dota2.CMsgHeroRoleRankStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleRankStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

