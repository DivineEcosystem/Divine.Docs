# <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent"></a> Class CMsgTournamentItemEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTournamentItemEvent : IMessage<CMsgTournamentItemEvent>, IEquatable<CMsgTournamentItemEvent>, IDeepCloneable<CMsgTournamentItemEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTournamentItemEvent](Divine.Protobufs.Dota2.CMsgTournamentItemEvent.md)

#### Implements

IMessage<CMsgTournamentItemEvent\>, 
[IEquatable<CMsgTournamentItemEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTournamentItemEvent\>, 
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
[EnumerableExtensions.In<CMsgTournamentItemEvent\>\(CMsgTournamentItemEvent, params CMsgTournamentItemEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent__ctor"></a> CMsgTournamentItemEvent\(\)

```csharp
public CMsgTournamentItemEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent__ctor_Divine_Protobufs_Dota2_CMsgTournamentItemEvent_"></a> CMsgTournamentItemEvent\(CMsgTournamentItemEvent\)

```csharp
public CMsgTournamentItemEvent(CMsgTournamentItemEvent other)
```

#### Parameters

`other` [CMsgTournamentItemEvent](Divine.Protobufs.Dota2.CMsgTournamentItemEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_DotaTimeFieldNumber"></a> DotaTimeFieldNumber

```csharp
public const int DotaTimeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_EventTeamFieldNumber"></a> EventTeamFieldNumber

```csharp
public const int EventTeamFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_EventTypeFieldNumber"></a> EventTypeFieldNumber

```csharp
public const int EventTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_HeroStatuesFieldNumber"></a> HeroStatuesFieldNumber

```csharp
public const int HeroStatuesFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_KillerAccountIdFieldNumber"></a> KillerAccountIdFieldNumber

```csharp
public const int KillerAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_LootListFieldNumber"></a> LootListFieldNumber

```csharp
public const int LootListFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_LoserScoreFieldNumber"></a> LoserScoreFieldNumber

```csharp
public const int LoserScoreFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_MultiKillCountFieldNumber"></a> MultiKillCountFieldNumber

```csharp
public const int MultiKillCountFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_TvDelayFieldNumber"></a> TvDelayFieldNumber

```csharp
public const int TvDelayFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_VictimAccountIdFieldNumber"></a> VictimAccountIdFieldNumber

```csharp
public const int VictimAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_WinnerScoreFieldNumber"></a> WinnerScoreFieldNumber

```csharp
public const int WinnerScoreFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_DotaTime"></a> DotaTime

```csharp
public int DotaTime { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_EventTeam"></a> EventTeam

```csharp
public uint EventTeam { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_EventType"></a> EventType

```csharp
public DOTA_TournamentEvents EventType { get; set; }
```

#### Property Value

 [DOTA\_TournamentEvents](Divine.Protobufs.Dota2.DOTA\_TournamentEvents.md)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_HasDotaTime"></a> HasDotaTime

```csharp
public bool HasDotaTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_HasEventTeam"></a> HasEventTeam

```csharp
public bool HasEventTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_HasEventType"></a> HasEventType

```csharp
public bool HasEventType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_HasKillerAccountId"></a> HasKillerAccountId

```csharp
public bool HasKillerAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_HasLootList"></a> HasLootList

```csharp
public bool HasLootList { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_HasLoserScore"></a> HasLoserScore

```csharp
public bool HasLoserScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_HasMultiKillCount"></a> HasMultiKillCount

```csharp
public bool HasMultiKillCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_HasTvDelay"></a> HasTvDelay

```csharp
public bool HasTvDelay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_HasVictimAccountId"></a> HasVictimAccountId

```csharp
public bool HasVictimAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_HasWinnerScore"></a> HasWinnerScore

```csharp
public bool HasWinnerScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_HeroStatues"></a> HeroStatues

```csharp
public RepeatedField<CProtoItemHeroStatue> HeroStatues { get; }
```

#### Property Value

 RepeatedField<[CProtoItemHeroStatue](Divine.Protobufs.Dota2.CProtoItemHeroStatue.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_KillerAccountId"></a> KillerAccountId

```csharp
public uint KillerAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_LootList"></a> LootList

```csharp
public string LootList { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_LoserScore"></a> LoserScore

```csharp
public uint LoserScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_MultiKillCount"></a> MultiKillCount

```csharp
public uint MultiKillCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTournamentItemEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTournamentItemEvent](Divine.Protobufs.Dota2.CMsgTournamentItemEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_TvDelay"></a> TvDelay

```csharp
public int TvDelay { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_VictimAccountId"></a> VictimAccountId

```csharp
public uint VictimAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_WinnerScore"></a> WinnerScore

```csharp
public uint WinnerScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_ClearDotaTime"></a> ClearDotaTime\(\)

```csharp
public void ClearDotaTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_ClearEventTeam"></a> ClearEventTeam\(\)

```csharp
public void ClearEventTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_ClearEventType"></a> ClearEventType\(\)

```csharp
public void ClearEventType()
```

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_ClearKillerAccountId"></a> ClearKillerAccountId\(\)

```csharp
public void ClearKillerAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_ClearLootList"></a> ClearLootList\(\)

```csharp
public void ClearLootList()
```

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_ClearLoserScore"></a> ClearLoserScore\(\)

```csharp
public void ClearLoserScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_ClearMultiKillCount"></a> ClearMultiKillCount\(\)

```csharp
public void ClearMultiKillCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_ClearTvDelay"></a> ClearTvDelay\(\)

```csharp
public void ClearTvDelay()
```

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_ClearVictimAccountId"></a> ClearVictimAccountId\(\)

```csharp
public void ClearVictimAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_ClearWinnerScore"></a> ClearWinnerScore\(\)

```csharp
public void ClearWinnerScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_Clone"></a> Clone\(\)

```csharp
public CMsgTournamentItemEvent Clone()
```

#### Returns

 [CMsgTournamentItemEvent](Divine.Protobufs.Dota2.CMsgTournamentItemEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_Equals_Divine_Protobufs_Dota2_CMsgTournamentItemEvent_"></a> Equals\(CMsgTournamentItemEvent\)

```csharp
public bool Equals(CMsgTournamentItemEvent other)
```

#### Parameters

`other` [CMsgTournamentItemEvent](Divine.Protobufs.Dota2.CMsgTournamentItemEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_MergeFrom_Divine_Protobufs_Dota2_CMsgTournamentItemEvent_"></a> MergeFrom\(CMsgTournamentItemEvent\)

```csharp
public void MergeFrom(CMsgTournamentItemEvent other)
```

#### Parameters

`other` [CMsgTournamentItemEvent](Divine.Protobufs.Dota2.CMsgTournamentItemEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

