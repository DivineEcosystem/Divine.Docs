# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3"></a> Class CMsgSteamLearnMatchHeroesV3

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnMatchHeroesV3 : IMessage<CMsgSteamLearnMatchHeroesV3>, IEquatable<CMsgSteamLearnMatchHeroesV3>, IDeepCloneable<CMsgSteamLearnMatchHeroesV3>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnMatchHeroesV3](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroesV3.md)

#### Implements

IMessage<CMsgSteamLearnMatchHeroesV3\>, 
[IEquatable<CMsgSteamLearnMatchHeroesV3\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnMatchHeroesV3\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnMatchHeroesV3\>\(CMsgSteamLearnMatchHeroesV3, params CMsgSteamLearnMatchHeroesV3\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3__ctor"></a> CMsgSteamLearnMatchHeroesV3\(\)

```csharp
public CMsgSteamLearnMatchHeroesV3()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_"></a> CMsgSteamLearnMatchHeroesV3\(CMsgSteamLearnMatchHeroesV3\)

```csharp
public CMsgSteamLearnMatchHeroesV3(CMsgSteamLearnMatchHeroesV3 other)
```

#### Parameters

`other` [CMsgSteamLearnMatchHeroesV3](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroesV3.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_DireHeroFacetsFieldNumber"></a> DireHeroFacetsFieldNumber

```csharp
public const int DireHeroFacetsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_DireHeroIdsFieldNumber"></a> DireHeroIdsFieldNumber

```csharp
public const int DireHeroIdsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_DireLanesFieldNumber"></a> DireLanesFieldNumber

```csharp
public const int DireLanesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_DirePositionsFieldNumber"></a> DirePositionsFieldNumber

```csharp
public const int DirePositionsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_RadiantHeroFacetsFieldNumber"></a> RadiantHeroFacetsFieldNumber

```csharp
public const int RadiantHeroFacetsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_RadiantHeroIdsFieldNumber"></a> RadiantHeroIdsFieldNumber

```csharp
public const int RadiantHeroIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_RadiantLanesFieldNumber"></a> RadiantLanesFieldNumber

```csharp
public const int RadiantLanesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_RadiantPositionsFieldNumber"></a> RadiantPositionsFieldNumber

```csharp
public const int RadiantPositionsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_DireHeroFacets"></a> DireHeroFacets

```csharp
public RepeatedField<uint> DireHeroFacets { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_DireHeroIds"></a> DireHeroIds

```csharp
public RepeatedField<int> DireHeroIds { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_DireLanes"></a> DireLanes

```csharp
public RepeatedField<uint> DireLanes { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_DirePositions"></a> DirePositions

```csharp
public RepeatedField<uint> DirePositions { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnMatchHeroesV3> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnMatchHeroesV3](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroesV3.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_RadiantHeroFacets"></a> RadiantHeroFacets

```csharp
public RepeatedField<uint> RadiantHeroFacets { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_RadiantHeroIds"></a> RadiantHeroIds

```csharp
public RepeatedField<int> RadiantHeroIds { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_RadiantLanes"></a> RadiantLanes

```csharp
public RepeatedField<uint> RadiantLanes { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_RadiantPositions"></a> RadiantPositions

```csharp
public RepeatedField<uint> RadiantPositions { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnMatchHeroesV3 Clone()
```

#### Returns

 [CMsgSteamLearnMatchHeroesV3](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroesV3.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_"></a> Equals\(CMsgSteamLearnMatchHeroesV3\)

```csharp
public bool Equals(CMsgSteamLearnMatchHeroesV3 other)
```

#### Parameters

`other` [CMsgSteamLearnMatchHeroesV3](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroesV3.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_"></a> MergeFrom\(CMsgSteamLearnMatchHeroesV3\)

```csharp
public void MergeFrom(CMsgSteamLearnMatchHeroesV3 other)
```

#### Parameters

`other` [CMsgSteamLearnMatchHeroesV3](Divine.Protobufs.Dota2.CMsgSteamLearnMatchHeroesV3.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchHeroesV3_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

