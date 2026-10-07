# <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats"></a> Class CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats : IMessage<CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats>, IEquatable<CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats>, IDeepCloneable<CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats.md)

#### Implements

IMessage<CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats\>, 
[IEquatable<CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats\>, 
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
[EnumerableExtensions.In<CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats\>\(CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats, params CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats__ctor"></a> RankChunkedStats\(\)

```csharp
public RankChunkedStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats__ctor_Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_"></a> RankChunkedStats\(RankChunkedStats\)

```csharp
public RankChunkedStats(CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats other)
```

#### Parameters

`other` [CMsgGCGetHeroTimedStatsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.md).[RankChunkedStats](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_RankChunkFieldNumber"></a> RankChunkFieldNumber

```csharp
public const int RankChunkFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_TimedStatsFieldNumber"></a> TimedStatsFieldNumber

```csharp
public const int TimedStatsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_HasRankChunk"></a> HasRankChunk

```csharp
public bool HasRankChunk { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCGetHeroTimedStatsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.md).[RankChunkedStats](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_RankChunk"></a> RankChunk

```csharp
public uint RankChunk { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_TimedStats"></a> TimedStats

```csharp
public RepeatedField<CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer> TimedStats { get; }
```

#### Property Value

 RepeatedField<[CMsgGCGetHeroTimedStatsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.md).[TimedStatsContainer](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_ClearRankChunk"></a> ClearRankChunk\(\)

```csharp
public void ClearRankChunk()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_Clone"></a> Clone\(\)

```csharp
public CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats Clone()
```

#### Returns

 [CMsgGCGetHeroTimedStatsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.md).[RankChunkedStats](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_Equals_Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_"></a> Equals\(RankChunkedStats\)

```csharp
public bool Equals(CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats other)
```

#### Parameters

`other` [CMsgGCGetHeroTimedStatsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.md).[RankChunkedStats](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_MergeFrom_Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_"></a> MergeFrom\(RankChunkedStats\)

```csharp
public void MergeFrom(CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats other)
```

#### Parameters

`other` [CMsgGCGetHeroTimedStatsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.md).[RankChunkedStats](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.RankChunkedStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_RankChunkedStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

