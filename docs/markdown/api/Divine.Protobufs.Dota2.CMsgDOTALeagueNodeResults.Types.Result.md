# <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result"></a> Class CMsgDOTALeagueNodeResults.Types.Result

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeagueNodeResults.Types.Result : IMessage<CMsgDOTALeagueNodeResults.Types.Result>, IEquatable<CMsgDOTALeagueNodeResults.Types.Result>, IDeepCloneable<CMsgDOTALeagueNodeResults.Types.Result>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeagueNodeResults.Types.Result](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.Types.Result.md)

#### Implements

IMessage<CMsgDOTALeagueNodeResults.Types.Result\>, 
[IEquatable<CMsgDOTALeagueNodeResults.Types.Result\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeagueNodeResults.Types.Result\>, 
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
[EnumerableExtensions.In<CMsgDOTALeagueNodeResults.Types.Result\>\(CMsgDOTALeagueNodeResults.Types.Result, params CMsgDOTALeagueNodeResults.Types.Result\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result__ctor"></a> Result\(\)

```csharp
public Result()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result__ctor_Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_"></a> Result\(Result\)

```csharp
public Result(CMsgDOTALeagueNodeResults.Types.Result other)
```

#### Parameters

`other` [CMsgDOTALeagueNodeResults](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.Types.Result.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_HasStartedFieldNumber"></a> HasStartedFieldNumber

```csharp
public const int HasStartedFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_IncomingNodeId1FieldNumber"></a> IncomingNodeId1FieldNumber

```csharp
public const int IncomingNodeId1FieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_IncomingNodeId2FieldNumber"></a> IncomingNodeId2FieldNumber

```csharp
public const int IncomingNodeId2FieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_IsCompletedFieldNumber"></a> IsCompletedFieldNumber

```csharp
public const int IsCompletedFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_LosingNodeIdFieldNumber"></a> LosingNodeIdFieldNumber

```csharp
public const int LosingNodeIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_LosingTeamIdFieldNumber"></a> LosingTeamIdFieldNumber

```csharp
public const int LosingTeamIdFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_MatchIdsFieldNumber"></a> MatchIdsFieldNumber

```csharp
public const int MatchIdsFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_NodeIdFieldNumber"></a> NodeIdFieldNumber

```csharp
public const int NodeIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_ScheduledTimeFieldNumber"></a> ScheduledTimeFieldNumber

```csharp
public const int ScheduledTimeFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_Team1NameFieldNumber"></a> Team1NameFieldNumber

```csharp
public const int Team1NameFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_Team1WinsFieldNumber"></a> Team1WinsFieldNumber

```csharp
public const int Team1WinsFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_Team2NameFieldNumber"></a> Team2NameFieldNumber

```csharp
public const int Team2NameFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_Team2WinsFieldNumber"></a> Team2WinsFieldNumber

```csharp
public const int Team2WinsFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_TeamId1FieldNumber"></a> TeamId1FieldNumber

```csharp
public const int TeamId1FieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_TeamId2FieldNumber"></a> TeamId2FieldNumber

```csharp
public const int TeamId2FieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_WinningNodeIdFieldNumber"></a> WinningNodeIdFieldNumber

```csharp
public const int WinningNodeIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_WinningTeamIdFieldNumber"></a> WinningTeamIdFieldNumber

```csharp
public const int WinningTeamIdFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_HasHasStarted"></a> HasHasStarted

```csharp
public bool HasHasStarted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_HasIncomingNodeId1"></a> HasIncomingNodeId1

```csharp
public bool HasIncomingNodeId1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_HasIncomingNodeId2"></a> HasIncomingNodeId2

```csharp
public bool HasIncomingNodeId2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_HasIsCompleted"></a> HasIsCompleted

```csharp
public bool HasIsCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_HasLosingNodeId"></a> HasLosingNodeId

```csharp
public bool HasLosingNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_HasLosingTeamId"></a> HasLosingTeamId

```csharp
public bool HasLosingTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_HasNodeId"></a> HasNodeId

```csharp
public bool HasNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_HasScheduledTime"></a> HasScheduledTime

```csharp
public bool HasScheduledTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_HasStarted"></a> HasStarted

```csharp
public bool HasStarted { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_HasTeam1Name"></a> HasTeam1Name

```csharp
public bool HasTeam1Name { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_HasTeam1Wins"></a> HasTeam1Wins

```csharp
public bool HasTeam1Wins { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_HasTeam2Name"></a> HasTeam2Name

```csharp
public bool HasTeam2Name { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_HasTeam2Wins"></a> HasTeam2Wins

```csharp
public bool HasTeam2Wins { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_HasTeamId1"></a> HasTeamId1

```csharp
public bool HasTeamId1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_HasTeamId2"></a> HasTeamId2

```csharp
public bool HasTeamId2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_HasWinningNodeId"></a> HasWinningNodeId

```csharp
public bool HasWinningNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_HasWinningTeamId"></a> HasWinningTeamId

```csharp
public bool HasWinningTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_IncomingNodeId1"></a> IncomingNodeId1

```csharp
public uint IncomingNodeId1 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_IncomingNodeId2"></a> IncomingNodeId2

```csharp
public uint IncomingNodeId2 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_IsCompleted"></a> IsCompleted

```csharp
public bool IsCompleted { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_LosingNodeId"></a> LosingNodeId

```csharp
public uint LosingNodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_LosingTeamId"></a> LosingTeamId

```csharp
public uint LosingTeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_MatchIds"></a> MatchIds

```csharp
public RepeatedField<ulong> MatchIds { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_NodeId"></a> NodeId

```csharp
public uint NodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeagueNodeResults.Types.Result> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeagueNodeResults](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.Types.Result.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_ScheduledTime"></a> ScheduledTime

```csharp
public uint ScheduledTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_Team1Name"></a> Team1Name

```csharp
public string Team1Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_Team1Wins"></a> Team1Wins

```csharp
public uint Team1Wins { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_Team2Name"></a> Team2Name

```csharp
public string Team2Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_Team2Wins"></a> Team2Wins

```csharp
public uint Team2Wins { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_TeamId1"></a> TeamId1

```csharp
public uint TeamId1 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_TeamId2"></a> TeamId2

```csharp
public uint TeamId2 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_WinningNodeId"></a> WinningNodeId

```csharp
public uint WinningNodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_WinningTeamId"></a> WinningTeamId

```csharp
public uint WinningTeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_ClearHasStarted"></a> ClearHasStarted\(\)

```csharp
public void ClearHasStarted()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_ClearIncomingNodeId1"></a> ClearIncomingNodeId1\(\)

```csharp
public void ClearIncomingNodeId1()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_ClearIncomingNodeId2"></a> ClearIncomingNodeId2\(\)

```csharp
public void ClearIncomingNodeId2()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_ClearIsCompleted"></a> ClearIsCompleted\(\)

```csharp
public void ClearIsCompleted()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_ClearLosingNodeId"></a> ClearLosingNodeId\(\)

```csharp
public void ClearLosingNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_ClearLosingTeamId"></a> ClearLosingTeamId\(\)

```csharp
public void ClearLosingTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_ClearNodeId"></a> ClearNodeId\(\)

```csharp
public void ClearNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_ClearScheduledTime"></a> ClearScheduledTime\(\)

```csharp
public void ClearScheduledTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_ClearTeam1Name"></a> ClearTeam1Name\(\)

```csharp
public void ClearTeam1Name()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_ClearTeam1Wins"></a> ClearTeam1Wins\(\)

```csharp
public void ClearTeam1Wins()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_ClearTeam2Name"></a> ClearTeam2Name\(\)

```csharp
public void ClearTeam2Name()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_ClearTeam2Wins"></a> ClearTeam2Wins\(\)

```csharp
public void ClearTeam2Wins()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_ClearTeamId1"></a> ClearTeamId1\(\)

```csharp
public void ClearTeamId1()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_ClearTeamId2"></a> ClearTeamId2\(\)

```csharp
public void ClearTeamId2()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_ClearWinningNodeId"></a> ClearWinningNodeId\(\)

```csharp
public void ClearWinningNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_ClearWinningTeamId"></a> ClearWinningTeamId\(\)

```csharp
public void ClearWinningTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeagueNodeResults.Types.Result Clone()
```

#### Returns

 [CMsgDOTALeagueNodeResults](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.Types.Result.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_Equals_Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_"></a> Equals\(Result\)

```csharp
public bool Equals(CMsgDOTALeagueNodeResults.Types.Result other)
```

#### Parameters

`other` [CMsgDOTALeagueNodeResults](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.Types.Result.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_"></a> MergeFrom\(Result\)

```csharp
public void MergeFrom(CMsgDOTALeagueNodeResults.Types.Result other)
```

#### Parameters

`other` [CMsgDOTALeagueNodeResults](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeResults.Types.Result.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeResults_Types_Result_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

