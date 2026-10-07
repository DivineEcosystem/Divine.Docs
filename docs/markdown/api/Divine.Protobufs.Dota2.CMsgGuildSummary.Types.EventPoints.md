# <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints"></a> Class CMsgGuildSummary.Types.EventPoints

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGuildSummary.Types.EventPoints : IMessage<CMsgGuildSummary.Types.EventPoints>, IEquatable<CMsgGuildSummary.Types.EventPoints>, IDeepCloneable<CMsgGuildSummary.Types.EventPoints>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGuildSummary.Types.EventPoints](Divine.Protobufs.Dota2.CMsgGuildSummary.Types.EventPoints.md)

#### Implements

IMessage<CMsgGuildSummary.Types.EventPoints\>, 
[IEquatable<CMsgGuildSummary.Types.EventPoints\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGuildSummary.Types.EventPoints\>, 
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
[EnumerableExtensions.In<CMsgGuildSummary.Types.EventPoints\>\(CMsgGuildSummary.Types.EventPoints, params CMsgGuildSummary.Types.EventPoints\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints__ctor"></a> EventPoints\(\)

```csharp
public EventPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints__ctor_Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_"></a> EventPoints\(EventPoints\)

```csharp
public EventPoints(CMsgGuildSummary.Types.EventPoints other)
```

#### Parameters

`other` [CMsgGuildSummary](Divine.Protobufs.Dota2.CMsgGuildSummary.md).[Types](Divine.Protobufs.Dota2.CMsgGuildSummary.Types.md).[EventPoints](Divine.Protobufs.Dota2.CMsgGuildSummary.Types.EventPoints.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_GuildCurrentPercentileFieldNumber"></a> GuildCurrentPercentileFieldNumber

```csharp
public const int GuildCurrentPercentileFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_GuildPointsFieldNumber"></a> GuildPointsFieldNumber

```csharp
public const int GuildPointsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_GuildRankFieldNumber"></a> GuildRankFieldNumber

```csharp
public const int GuildRankFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_GuildWeeklyPercentileFieldNumber"></a> GuildWeeklyPercentileFieldNumber

```csharp
public const int GuildWeeklyPercentileFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_GuildWeeklyRankFieldNumber"></a> GuildWeeklyRankFieldNumber

```csharp
public const int GuildWeeklyRankFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_GuildCurrentPercentile"></a> GuildCurrentPercentile

```csharp
public uint GuildCurrentPercentile { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_GuildPoints"></a> GuildPoints

```csharp
public uint GuildPoints { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_GuildRank"></a> GuildRank

```csharp
public uint GuildRank { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_GuildWeeklyPercentile"></a> GuildWeeklyPercentile

```csharp
public uint GuildWeeklyPercentile { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_GuildWeeklyRank"></a> GuildWeeklyRank

```csharp
public uint GuildWeeklyRank { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_HasGuildCurrentPercentile"></a> HasGuildCurrentPercentile

```csharp
public bool HasGuildCurrentPercentile { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_HasGuildPoints"></a> HasGuildPoints

```csharp
public bool HasGuildPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_HasGuildRank"></a> HasGuildRank

```csharp
public bool HasGuildRank { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_HasGuildWeeklyPercentile"></a> HasGuildWeeklyPercentile

```csharp
public bool HasGuildWeeklyPercentile { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_HasGuildWeeklyRank"></a> HasGuildWeeklyRank

```csharp
public bool HasGuildWeeklyRank { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGuildSummary.Types.EventPoints> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGuildSummary](Divine.Protobufs.Dota2.CMsgGuildSummary.md).[Types](Divine.Protobufs.Dota2.CMsgGuildSummary.Types.md).[EventPoints](Divine.Protobufs.Dota2.CMsgGuildSummary.Types.EventPoints.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_ClearGuildCurrentPercentile"></a> ClearGuildCurrentPercentile\(\)

```csharp
public void ClearGuildCurrentPercentile()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_ClearGuildPoints"></a> ClearGuildPoints\(\)

```csharp
public void ClearGuildPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_ClearGuildRank"></a> ClearGuildRank\(\)

```csharp
public void ClearGuildRank()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_ClearGuildWeeklyPercentile"></a> ClearGuildWeeklyPercentile\(\)

```csharp
public void ClearGuildWeeklyPercentile()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_ClearGuildWeeklyRank"></a> ClearGuildWeeklyRank\(\)

```csharp
public void ClearGuildWeeklyRank()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_Clone"></a> Clone\(\)

```csharp
public CMsgGuildSummary.Types.EventPoints Clone()
```

#### Returns

 [CMsgGuildSummary](Divine.Protobufs.Dota2.CMsgGuildSummary.md).[Types](Divine.Protobufs.Dota2.CMsgGuildSummary.Types.md).[EventPoints](Divine.Protobufs.Dota2.CMsgGuildSummary.Types.EventPoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_Equals_Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_"></a> Equals\(EventPoints\)

```csharp
public bool Equals(CMsgGuildSummary.Types.EventPoints other)
```

#### Parameters

`other` [CMsgGuildSummary](Divine.Protobufs.Dota2.CMsgGuildSummary.md).[Types](Divine.Protobufs.Dota2.CMsgGuildSummary.Types.md).[EventPoints](Divine.Protobufs.Dota2.CMsgGuildSummary.Types.EventPoints.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_MergeFrom_Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_"></a> MergeFrom\(EventPoints\)

```csharp
public void MergeFrom(CMsgGuildSummary.Types.EventPoints other)
```

#### Parameters

`other` [CMsgGuildSummary](Divine.Protobufs.Dota2.CMsgGuildSummary.md).[Types](Divine.Protobufs.Dota2.CMsgGuildSummary.Types.md).[EventPoints](Divine.Protobufs.Dota2.CMsgGuildSummary.Types.EventPoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Types_EventPoints_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

