# <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode"></a> Class CMsgDOTALeagueNode

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeagueNode : IMessage<CMsgDOTALeagueNode>, IEquatable<CMsgDOTALeagueNode>, IDeepCloneable<CMsgDOTALeagueNode>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeagueNode](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.md)

#### Implements

IMessage<CMsgDOTALeagueNode\>, 
[IEquatable<CMsgDOTALeagueNode\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeagueNode\>, 
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
[EnumerableExtensions.In<CMsgDOTALeagueNode\>\(CMsgDOTALeagueNode, params CMsgDOTALeagueNode\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode__ctor"></a> CMsgDOTALeagueNode\(\)

```csharp
public CMsgDOTALeagueNode()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode__ctor_Divine_Protobufs_Dota2_CMsgDOTALeagueNode_"></a> CMsgDOTALeagueNode\(CMsgDOTALeagueNode\)

```csharp
public CMsgDOTALeagueNode(CMsgDOTALeagueNode other)
```

#### Parameters

`other` [CMsgDOTALeagueNode](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ActualTimeFieldNumber"></a> ActualTimeFieldNumber

```csharp
public const int ActualTimeFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_HasStartedFieldNumber"></a> HasStartedFieldNumber

```csharp
public const int HasStartedFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_IncomingNodeId1FieldNumber"></a> IncomingNodeId1FieldNumber

```csharp
public const int IncomingNodeId1FieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_IncomingNodeId2FieldNumber"></a> IncomingNodeId2FieldNumber

```csharp
public const int IncomingNodeId2FieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_IsCompletedFieldNumber"></a> IsCompletedFieldNumber

```csharp
public const int IsCompletedFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_LosingNodeIdFieldNumber"></a> LosingNodeIdFieldNumber

```csharp
public const int LosingNodeIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_MatchesFieldNumber"></a> MatchesFieldNumber

```csharp
public const int MatchesFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_NodeGroupIdFieldNumber"></a> NodeGroupIdFieldNumber

```csharp
public const int NodeGroupIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_NodeIdFieldNumber"></a> NodeIdFieldNumber

```csharp
public const int NodeIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_NodeTypeFieldNumber"></a> NodeTypeFieldNumber

```csharp
public const int NodeTypeFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ScheduledTimeFieldNumber"></a> ScheduledTimeFieldNumber

```csharp
public const int ScheduledTimeFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_SeriesIdFieldNumber"></a> SeriesIdFieldNumber

```csharp
public const int SeriesIdFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_StreamIdsFieldNumber"></a> StreamIdsFieldNumber

```csharp
public const int StreamIdsFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Team1WinsFieldNumber"></a> Team1WinsFieldNumber

```csharp
public const int Team1WinsFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Team2WinsFieldNumber"></a> Team2WinsFieldNumber

```csharp
public const int Team2WinsFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_TeamId1FieldNumber"></a> TeamId1FieldNumber

```csharp
public const int TeamId1FieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_TeamId2FieldNumber"></a> TeamId2FieldNumber

```csharp
public const int TeamId2FieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_VodsFieldNumber"></a> VodsFieldNumber

```csharp
public const int VodsFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_WinningNodeIdFieldNumber"></a> WinningNodeIdFieldNumber

```csharp
public const int WinningNodeIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ActualTime"></a> ActualTime

```csharp
public uint ActualTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_HasActualTime"></a> HasActualTime

```csharp
public bool HasActualTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_HasHasStarted"></a> HasHasStarted

```csharp
public bool HasHasStarted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_HasIncomingNodeId1"></a> HasIncomingNodeId1

```csharp
public bool HasIncomingNodeId1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_HasIncomingNodeId2"></a> HasIncomingNodeId2

```csharp
public bool HasIncomingNodeId2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_HasIsCompleted"></a> HasIsCompleted

```csharp
public bool HasIsCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_HasLosingNodeId"></a> HasLosingNodeId

```csharp
public bool HasLosingNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_HasNodeGroupId"></a> HasNodeGroupId

```csharp
public bool HasNodeGroupId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_HasNodeId"></a> HasNodeId

```csharp
public bool HasNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_HasNodeType"></a> HasNodeType

```csharp
public bool HasNodeType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_HasScheduledTime"></a> HasScheduledTime

```csharp
public bool HasScheduledTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_HasSeriesId"></a> HasSeriesId

```csharp
public bool HasSeriesId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_HasStarted"></a> HasStarted

```csharp
public bool HasStarted { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_HasTeam1Wins"></a> HasTeam1Wins

```csharp
public bool HasTeam1Wins { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_HasTeam2Wins"></a> HasTeam2Wins

```csharp
public bool HasTeam2Wins { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_HasTeamId1"></a> HasTeamId1

```csharp
public bool HasTeamId1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_HasTeamId2"></a> HasTeamId2

```csharp
public bool HasTeamId2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_HasWinningNodeId"></a> HasWinningNodeId

```csharp
public bool HasWinningNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_IncomingNodeId1"></a> IncomingNodeId1

```csharp
public uint IncomingNodeId1 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_IncomingNodeId2"></a> IncomingNodeId2

```csharp
public uint IncomingNodeId2 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_IsCompleted"></a> IsCompleted

```csharp
public bool IsCompleted { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_LosingNodeId"></a> LosingNodeId

```csharp
public uint LosingNodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Matches"></a> Matches

```csharp
public RepeatedField<CMsgDOTALeagueNode.Types.MatchDetails> Matches { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTALeagueNode](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.md).[MatchDetails](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.MatchDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_NodeGroupId"></a> NodeGroupId

```csharp
public uint NodeGroupId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_NodeId"></a> NodeId

```csharp
public uint NodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_NodeType"></a> NodeType

```csharp
public ELeagueNodeType NodeType { get; set; }
```

#### Property Value

 [ELeagueNodeType](Divine.Protobufs.Dota2.ELeagueNodeType.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeagueNode> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeagueNode](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ScheduledTime"></a> ScheduledTime

```csharp
public uint ScheduledTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_SeriesId"></a> SeriesId

```csharp
public uint SeriesId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_StreamIds"></a> StreamIds

```csharp
public RepeatedField<uint> StreamIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Team1Wins"></a> Team1Wins

```csharp
public uint Team1Wins { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Team2Wins"></a> Team2Wins

```csharp
public uint Team2Wins { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_TeamId1"></a> TeamId1

```csharp
public uint TeamId1 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_TeamId2"></a> TeamId2

```csharp
public uint TeamId2 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Vods"></a> Vods

```csharp
public RepeatedField<CMsgDOTALeagueNode.Types.VOD> Vods { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTALeagueNode](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.md).[VOD](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.VOD.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_WinningNodeId"></a> WinningNodeId

```csharp
public uint WinningNodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ClearActualTime"></a> ClearActualTime\(\)

```csharp
public void ClearActualTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ClearHasStarted"></a> ClearHasStarted\(\)

```csharp
public void ClearHasStarted()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ClearIncomingNodeId1"></a> ClearIncomingNodeId1\(\)

```csharp
public void ClearIncomingNodeId1()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ClearIncomingNodeId2"></a> ClearIncomingNodeId2\(\)

```csharp
public void ClearIncomingNodeId2()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ClearIsCompleted"></a> ClearIsCompleted\(\)

```csharp
public void ClearIsCompleted()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ClearLosingNodeId"></a> ClearLosingNodeId\(\)

```csharp
public void ClearLosingNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ClearNodeGroupId"></a> ClearNodeGroupId\(\)

```csharp
public void ClearNodeGroupId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ClearNodeId"></a> ClearNodeId\(\)

```csharp
public void ClearNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ClearNodeType"></a> ClearNodeType\(\)

```csharp
public void ClearNodeType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ClearScheduledTime"></a> ClearScheduledTime\(\)

```csharp
public void ClearScheduledTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ClearSeriesId"></a> ClearSeriesId\(\)

```csharp
public void ClearSeriesId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ClearTeam1Wins"></a> ClearTeam1Wins\(\)

```csharp
public void ClearTeam1Wins()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ClearTeam2Wins"></a> ClearTeam2Wins\(\)

```csharp
public void ClearTeam2Wins()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ClearTeamId1"></a> ClearTeamId1\(\)

```csharp
public void ClearTeamId1()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ClearTeamId2"></a> ClearTeamId2\(\)

```csharp
public void ClearTeamId2()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ClearWinningNodeId"></a> ClearWinningNodeId\(\)

```csharp
public void ClearWinningNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeagueNode Clone()
```

#### Returns

 [CMsgDOTALeagueNode](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Equals_Divine_Protobufs_Dota2_CMsgDOTALeagueNode_"></a> Equals\(CMsgDOTALeagueNode\)

```csharp
public bool Equals(CMsgDOTALeagueNode other)
```

#### Parameters

`other` [CMsgDOTALeagueNode](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeagueNode_"></a> MergeFrom\(CMsgDOTALeagueNode\)

```csharp
public void MergeFrom(CMsgDOTALeagueNode other)
```

#### Parameters

`other` [CMsgDOTALeagueNode](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

