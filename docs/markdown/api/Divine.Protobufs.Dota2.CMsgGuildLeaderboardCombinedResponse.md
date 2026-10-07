# <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse"></a> Class CMsgGuildLeaderboardCombinedResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGuildLeaderboardCombinedResponse : IMessage<CMsgGuildLeaderboardCombinedResponse>, IEquatable<CMsgGuildLeaderboardCombinedResponse>, IDeepCloneable<CMsgGuildLeaderboardCombinedResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGuildLeaderboardCombinedResponse](Divine.Protobufs.Dota2.CMsgGuildLeaderboardCombinedResponse.md)

#### Implements

IMessage<CMsgGuildLeaderboardCombinedResponse\>, 
[IEquatable<CMsgGuildLeaderboardCombinedResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGuildLeaderboardCombinedResponse\>, 
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
[EnumerableExtensions.In<CMsgGuildLeaderboardCombinedResponse\>\(CMsgGuildLeaderboardCombinedResponse, params CMsgGuildLeaderboardCombinedResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse__ctor"></a> CMsgGuildLeaderboardCombinedResponse\(\)

```csharp
public CMsgGuildLeaderboardCombinedResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse__ctor_Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_"></a> CMsgGuildLeaderboardCombinedResponse\(CMsgGuildLeaderboardCombinedResponse\)

```csharp
public CMsgGuildLeaderboardCombinedResponse(CMsgGuildLeaderboardCombinedResponse other)
```

#### Parameters

`other` [CMsgGuildLeaderboardCombinedResponse](Divine.Protobufs.Dota2.CMsgGuildLeaderboardCombinedResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_CurrentPercentileFieldNumber"></a> CurrentPercentileFieldNumber

```csharp
public const int CurrentPercentileFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_LastUpdatedFieldNumber"></a> LastUpdatedFieldNumber

```csharp
public const int LastUpdatedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_PointsFieldNumber"></a> PointsFieldNumber

```csharp
public const int PointsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_RankFieldNumber"></a> RankFieldNumber

```csharp
public const int RankFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_RegionFieldNumber"></a> RegionFieldNumber

```csharp
public const int RegionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_WeeklyPercentileFieldNumber"></a> WeeklyPercentileFieldNumber

```csharp
public const int WeeklyPercentileFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_CurrentPercentile"></a> CurrentPercentile

```csharp
public RepeatedField<uint> CurrentPercentile { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_GuildId"></a> GuildId

```csharp
public RepeatedField<uint> GuildId { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_HasLastUpdated"></a> HasLastUpdated

```csharp
public bool HasLastUpdated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_HasRegion"></a> HasRegion

```csharp
public bool HasRegion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_LastUpdated"></a> LastUpdated

```csharp
public uint LastUpdated { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGuildLeaderboardCombinedResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGuildLeaderboardCombinedResponse](Divine.Protobufs.Dota2.CMsgGuildLeaderboardCombinedResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_Points"></a> Points

```csharp
public RepeatedField<uint> Points { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_Rank"></a> Rank

```csharp
public RepeatedField<uint> Rank { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_Region"></a> Region

```csharp
public uint Region { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_WeeklyPercentile"></a> WeeklyPercentile

```csharp
public RepeatedField<uint> WeeklyPercentile { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_ClearLastUpdated"></a> ClearLastUpdated\(\)

```csharp
public void ClearLastUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_ClearRegion"></a> ClearRegion\(\)

```csharp
public void ClearRegion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGuildLeaderboardCombinedResponse Clone()
```

#### Returns

 [CMsgGuildLeaderboardCombinedResponse](Divine.Protobufs.Dota2.CMsgGuildLeaderboardCombinedResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_Equals_Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_"></a> Equals\(CMsgGuildLeaderboardCombinedResponse\)

```csharp
public bool Equals(CMsgGuildLeaderboardCombinedResponse other)
```

#### Parameters

`other` [CMsgGuildLeaderboardCombinedResponse](Divine.Protobufs.Dota2.CMsgGuildLeaderboardCombinedResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_"></a> MergeFrom\(CMsgGuildLeaderboardCombinedResponse\)

```csharp
public void MergeFrom(CMsgGuildLeaderboardCombinedResponse other)
```

#### Parameters

`other` [CMsgGuildLeaderboardCombinedResponse](Divine.Protobufs.Dota2.CMsgGuildLeaderboardCombinedResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildLeaderboardCombinedResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

