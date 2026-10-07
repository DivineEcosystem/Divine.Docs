# <a id="Divine_Protobufs_Dota2_CMsgDOTATournament"></a> Class CMsgDOTATournament

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATournament : IMessage<CMsgDOTATournament>, IEquatable<CMsgDOTATournament>, IDeepCloneable<CMsgDOTATournament>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATournament](Divine.Protobufs.Dota2.CMsgDOTATournament.md)

#### Implements

IMessage<CMsgDOTATournament\>, 
[IEquatable<CMsgDOTATournament\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATournament\>, 
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
[EnumerableExtensions.In<CMsgDOTATournament\>\(CMsgDOTATournament, params CMsgDOTATournament\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament__ctor"></a> CMsgDOTATournament\(\)

```csharp
public CMsgDOTATournament()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament__ctor_Divine_Protobufs_Dota2_CMsgDOTATournament_"></a> CMsgDOTATournament\(CMsgDOTATournament\)

```csharp
public CMsgDOTATournament(CMsgDOTATournament other)
```

#### Parameters

`other` [CMsgDOTATournament](Divine.Protobufs.Dota2.CMsgDOTATournament.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_DivisionIdFieldNumber"></a> DivisionIdFieldNumber

```csharp
public const int DivisionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_GamesFieldNumber"></a> GamesFieldNumber

```csharp
public const int GamesFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_NodesFieldNumber"></a> NodesFieldNumber

```csharp
public const int NodesFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_ScheduleTimeFieldNumber"></a> ScheduleTimeFieldNumber

```csharp
public const int ScheduleTimeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_SeasonTrophyIdFieldNumber"></a> SeasonTrophyIdFieldNumber

```csharp
public const int SeasonTrophyIdFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_SkillLevelFieldNumber"></a> SkillLevelFieldNumber

```csharp
public const int SkillLevelFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_StateFieldNumber"></a> StateFieldNumber

```csharp
public const int StateFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_StateSeqNumFieldNumber"></a> StateSeqNumFieldNumber

```csharp
public const int StateSeqNumFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_TeamsFieldNumber"></a> TeamsFieldNumber

```csharp
public const int TeamsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_TournamentIdFieldNumber"></a> TournamentIdFieldNumber

```csharp
public const int TournamentIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_TournamentTemplateFieldNumber"></a> TournamentTemplateFieldNumber

```csharp
public const int TournamentTemplateFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_DivisionId"></a> DivisionId

```csharp
public uint DivisionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Games"></a> Games

```csharp
public RepeatedField<CMsgDOTATournament.Types.Game> Games { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTATournament](Divine.Protobufs.Dota2.CMsgDOTATournament.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.md).[Game](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.Game.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_HasDivisionId"></a> HasDivisionId

```csharp
public bool HasDivisionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_HasScheduleTime"></a> HasScheduleTime

```csharp
public bool HasScheduleTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_HasSeasonTrophyId"></a> HasSeasonTrophyId

```csharp
public bool HasSeasonTrophyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_HasSkillLevel"></a> HasSkillLevel

```csharp
public bool HasSkillLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_HasState"></a> HasState

```csharp
public bool HasState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_HasStateSeqNum"></a> HasStateSeqNum

```csharp
public bool HasStateSeqNum { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_HasTournamentId"></a> HasTournamentId

```csharp
public bool HasTournamentId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_HasTournamentTemplate"></a> HasTournamentTemplate

```csharp
public bool HasTournamentTemplate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Nodes"></a> Nodes

```csharp
public RepeatedField<CMsgDOTATournament.Types.Node> Nodes { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTATournament](Divine.Protobufs.Dota2.CMsgDOTATournament.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.md).[Node](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.Node.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATournament> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATournament](Divine.Protobufs.Dota2.CMsgDOTATournament.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_ScheduleTime"></a> ScheduleTime

```csharp
public uint ScheduleTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_SeasonTrophyId"></a> SeasonTrophyId

```csharp
public uint SeasonTrophyId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_SkillLevel"></a> SkillLevel

```csharp
public uint SkillLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_State"></a> State

```csharp
public ETournamentState State { get; set; }
```

#### Property Value

 [ETournamentState](Divine.Protobufs.Dota2.ETournamentState.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_StateSeqNum"></a> StateSeqNum

```csharp
public uint StateSeqNum { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Teams"></a> Teams

```csharp
public RepeatedField<CMsgDOTATournament.Types.Team> Teams { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTATournament](Divine.Protobufs.Dota2.CMsgDOTATournament.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTATournament.Types.Team.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_TournamentId"></a> TournamentId

```csharp
public uint TournamentId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_TournamentTemplate"></a> TournamentTemplate

```csharp
public ETournamentTemplate TournamentTemplate { get; set; }
```

#### Property Value

 [ETournamentTemplate](Divine.Protobufs.Dota2.ETournamentTemplate.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_ClearDivisionId"></a> ClearDivisionId\(\)

```csharp
public void ClearDivisionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_ClearScheduleTime"></a> ClearScheduleTime\(\)

```csharp
public void ClearScheduleTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_ClearSeasonTrophyId"></a> ClearSeasonTrophyId\(\)

```csharp
public void ClearSeasonTrophyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_ClearSkillLevel"></a> ClearSkillLevel\(\)

```csharp
public void ClearSkillLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_ClearState"></a> ClearState\(\)

```csharp
public void ClearState()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_ClearStateSeqNum"></a> ClearStateSeqNum\(\)

```csharp
public void ClearStateSeqNum()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_ClearTournamentId"></a> ClearTournamentId\(\)

```csharp
public void ClearTournamentId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_ClearTournamentTemplate"></a> ClearTournamentTemplate\(\)

```csharp
public void ClearTournamentTemplate()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATournament Clone()
```

#### Returns

 [CMsgDOTATournament](Divine.Protobufs.Dota2.CMsgDOTATournament.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_Equals_Divine_Protobufs_Dota2_CMsgDOTATournament_"></a> Equals\(CMsgDOTATournament\)

```csharp
public bool Equals(CMsgDOTATournament other)
```

#### Parameters

`other` [CMsgDOTATournament](Divine.Protobufs.Dota2.CMsgDOTATournament.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATournament_"></a> MergeFrom\(CMsgDOTATournament\)

```csharp
public void MergeFrom(CMsgDOTATournament other)
```

#### Parameters

`other` [CMsgDOTATournament](Divine.Protobufs.Dota2.CMsgDOTATournament.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournament_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

