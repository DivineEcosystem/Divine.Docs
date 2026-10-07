# <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats"></a> Class CMsgServerToGCMatchConnectionStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCMatchConnectionStats : IMessage<CMsgServerToGCMatchConnectionStats>, IEquatable<CMsgServerToGCMatchConnectionStats>, IDeepCloneable<CMsgServerToGCMatchConnectionStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCMatchConnectionStats](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.md)

#### Implements

IMessage<CMsgServerToGCMatchConnectionStats\>, 
[IEquatable<CMsgServerToGCMatchConnectionStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCMatchConnectionStats\>, 
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
[EnumerableExtensions.In<CMsgServerToGCMatchConnectionStats\>\(CMsgServerToGCMatchConnectionStats, params CMsgServerToGCMatchConnectionStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats__ctor"></a> CMsgServerToGCMatchConnectionStats\(\)

```csharp
public CMsgServerToGCMatchConnectionStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats__ctor_Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_"></a> CMsgServerToGCMatchConnectionStats\(CMsgServerToGCMatchConnectionStats\)

```csharp
public CMsgServerToGCMatchConnectionStats(CMsgServerToGCMatchConnectionStats other)
```

#### Parameters

`other` [CMsgServerToGCMatchConnectionStats](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_ClusterIdFieldNumber"></a> ClusterIdFieldNumber

```csharp
public const int ClusterIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_RegionIdFieldNumber"></a> RegionIdFieldNumber

```csharp
public const int RegionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_ClusterId"></a> ClusterId

```csharp
public uint ClusterId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_HasClusterId"></a> HasClusterId

```csharp
public bool HasClusterId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_HasRegionId"></a> HasRegionId

```csharp
public bool HasRegionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCMatchConnectionStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCMatchConnectionStats](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Players"></a> Players

```csharp
public RepeatedField<CMsgServerToGCMatchConnectionStats.Types.Player> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgServerToGCMatchConnectionStats](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_RegionId"></a> RegionId

```csharp
public uint RegionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_ClearClusterId"></a> ClearClusterId\(\)

```csharp
public void ClearClusterId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_ClearRegionId"></a> ClearRegionId\(\)

```csharp
public void ClearRegionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCMatchConnectionStats Clone()
```

#### Returns

 [CMsgServerToGCMatchConnectionStats](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Equals_Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_"></a> Equals\(CMsgServerToGCMatchConnectionStats\)

```csharp
public bool Equals(CMsgServerToGCMatchConnectionStats other)
```

#### Parameters

`other` [CMsgServerToGCMatchConnectionStats](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_"></a> MergeFrom\(CMsgServerToGCMatchConnectionStats\)

```csharp
public void MergeFrom(CMsgServerToGCMatchConnectionStats other)
```

#### Parameters

`other` [CMsgServerToGCMatchConnectionStats](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

