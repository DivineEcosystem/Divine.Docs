# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6"></a> Class CMsgSteamLearnMatchHeroV6

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnMatchHeroV6 : IMessage<CMsgSteamLearnMatchHeroV6>, IEquatable<CMsgSteamLearnMatchHeroV6>, IDeepCloneable<CMsgSteamLearnMatchHeroV6>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnMatchHeroV6](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroV6.md)

#### Implements

IMessage<CMsgSteamLearnMatchHeroV6\>, 
[IEquatable<CMsgSteamLearnMatchHeroV6\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnMatchHeroV6\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnMatchHeroV6\>\(CMsgSteamLearnMatchHeroV6, params CMsgSteamLearnMatchHeroV6\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6__ctor"></a> CMsgSteamLearnMatchHeroV6\(\)

```csharp
public CMsgSteamLearnMatchHeroV6()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_"></a> CMsgSteamLearnMatchHeroV6\(CMsgSteamLearnMatchHeroV6\)

```csharp
public CMsgSteamLearnMatchHeroV6(CMsgSteamLearnMatchHeroV6 other)
```

#### Parameters

`other` [CMsgSteamLearnMatchHeroV6](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroV6.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_AlliedHeroAndFacetFieldNumber"></a> AlliedHeroAndFacetFieldNumber

```csharp
public const int AlliedHeroAndFacetFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_EnemyHeroAndFacetFieldNumber"></a> EnemyHeroAndFacetFieldNumber

```csharp
public const int EnemyHeroAndFacetFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_FacetFieldNumber"></a> FacetFieldNumber

```csharp
public const int FacetFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_HeroAndFacetFieldNumber"></a> HeroAndFacetFieldNumber

```csharp
public const int HeroAndFacetFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_LaneFieldNumber"></a> LaneFieldNumber

```csharp
public const int LaneFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_PositionFieldNumber"></a> PositionFieldNumber

```csharp
public const int PositionFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_AlliedHeroAndFacet"></a> AlliedHeroAndFacet

```csharp
public RepeatedField<uint> AlliedHeroAndFacet { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_EnemyHeroAndFacet"></a> EnemyHeroAndFacet

```csharp
public RepeatedField<uint> EnemyHeroAndFacet { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_Facet"></a> Facet

```csharp
public uint Facet { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_HasFacet"></a> HasFacet

```csharp
public bool HasFacet { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_HasHeroAndFacet"></a> HasHeroAndFacet

```csharp
public bool HasHeroAndFacet { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_HasLane"></a> HasLane

```csharp
public bool HasLane { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_HasPosition"></a> HasPosition

```csharp
public bool HasPosition { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_HeroAndFacet"></a> HeroAndFacet

```csharp
public uint HeroAndFacet { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_Lane"></a> Lane

```csharp
public uint Lane { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnMatchHeroV6> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnMatchHeroV6](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroV6.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_Position"></a> Position

```csharp
public uint Position { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_ClearFacet"></a> ClearFacet\(\)

```csharp
public void ClearFacet()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_ClearHeroAndFacet"></a> ClearHeroAndFacet\(\)

```csharp
public void ClearHeroAndFacet()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_ClearLane"></a> ClearLane\(\)

```csharp
public void ClearLane()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_ClearPosition"></a> ClearPosition\(\)

```csharp
public void ClearPosition()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnMatchHeroV6 Clone()
```

#### Returns

 [CMsgSteamLearnMatchHeroV6](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroV6.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_"></a> Equals\(CMsgSteamLearnMatchHeroV6\)

```csharp
public bool Equals(CMsgSteamLearnMatchHeroV6 other)
```

#### Parameters

`other` [CMsgSteamLearnMatchHeroV6](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroV6.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_"></a> MergeFrom\(CMsgSteamLearnMatchHeroV6\)

```csharp
public void MergeFrom(CMsgSteamLearnMatchHeroV6 other)
```

#### Parameters

`other` [CMsgSteamLearnMatchHeroV6](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroV6.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroV6_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

