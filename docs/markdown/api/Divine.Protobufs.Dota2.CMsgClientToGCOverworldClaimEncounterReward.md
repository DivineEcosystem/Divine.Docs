# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward"></a> Class CMsgClientToGCOverworldClaimEncounterReward

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldClaimEncounterReward : IMessage<CMsgClientToGCOverworldClaimEncounterReward>, IEquatable<CMsgClientToGCOverworldClaimEncounterReward>, IDeepCloneable<CMsgClientToGCOverworldClaimEncounterReward>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldClaimEncounterReward](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimEncounterReward.md)

#### Implements

IMessage<CMsgClientToGCOverworldClaimEncounterReward\>, 
[IEquatable<CMsgClientToGCOverworldClaimEncounterReward\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldClaimEncounterReward\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldClaimEncounterReward\>\(CMsgClientToGCOverworldClaimEncounterReward, params CMsgClientToGCOverworldClaimEncounterReward\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward__ctor"></a> CMsgClientToGCOverworldClaimEncounterReward\(\)

```csharp
public CMsgClientToGCOverworldClaimEncounterReward()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_"></a> CMsgClientToGCOverworldClaimEncounterReward\(CMsgClientToGCOverworldClaimEncounterReward\)

```csharp
public CMsgClientToGCOverworldClaimEncounterReward(CMsgClientToGCOverworldClaimEncounterReward other)
```

#### Parameters

`other` [CMsgClientToGCOverworldClaimEncounterReward](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimEncounterReward.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_ExtraRewardDataFieldNumber"></a> ExtraRewardDataFieldNumber

```csharp
public const int ExtraRewardDataFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_LeaderboardDataFieldNumber"></a> LeaderboardDataFieldNumber

```csharp
public const int LeaderboardDataFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_LeaderboardIndexFieldNumber"></a> LeaderboardIndexFieldNumber

```csharp
public const int LeaderboardIndexFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_NodeIdFieldNumber"></a> NodeIdFieldNumber

```csharp
public const int NodeIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_PeriodicResourceIdFieldNumber"></a> PeriodicResourceIdFieldNumber

```csharp
public const int PeriodicResourceIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_RewardDataFieldNumber"></a> RewardDataFieldNumber

```csharp
public const int RewardDataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_ShouldClaimRewardFieldNumber"></a> ShouldClaimRewardFieldNumber

```csharp
public const int ShouldClaimRewardFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_ExtraRewardData"></a> ExtraRewardData

```csharp
public CMsgOverworldEncounterData ExtraRewardData { get; set; }
```

#### Property Value

 [CMsgOverworldEncounterData](Divine.Protobufs.Dota2.CMsgOverworldEncounterData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_HasLeaderboardData"></a> HasLeaderboardData

```csharp
public bool HasLeaderboardData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_HasLeaderboardIndex"></a> HasLeaderboardIndex

```csharp
public bool HasLeaderboardIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_HasNodeId"></a> HasNodeId

```csharp
public bool HasNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_HasPeriodicResourceId"></a> HasPeriodicResourceId

```csharp
public bool HasPeriodicResourceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_HasRewardData"></a> HasRewardData

```csharp
public bool HasRewardData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_HasShouldClaimReward"></a> HasShouldClaimReward

```csharp
public bool HasShouldClaimReward { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_LeaderboardData"></a> LeaderboardData

```csharp
public uint LeaderboardData { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_LeaderboardIndex"></a> LeaderboardIndex

```csharp
public uint LeaderboardIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_NodeId"></a> NodeId

```csharp
public uint NodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldClaimEncounterReward> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldClaimEncounterReward](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimEncounterReward.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_PeriodicResourceId"></a> PeriodicResourceId

```csharp
public uint PeriodicResourceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_RewardData"></a> RewardData

```csharp
public uint RewardData { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_ShouldClaimReward"></a> ShouldClaimReward

```csharp
public bool ShouldClaimReward { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_ClearLeaderboardData"></a> ClearLeaderboardData\(\)

```csharp
public void ClearLeaderboardData()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_ClearLeaderboardIndex"></a> ClearLeaderboardIndex\(\)

```csharp
public void ClearLeaderboardIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_ClearNodeId"></a> ClearNodeId\(\)

```csharp
public void ClearNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_ClearPeriodicResourceId"></a> ClearPeriodicResourceId\(\)

```csharp
public void ClearPeriodicResourceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_ClearRewardData"></a> ClearRewardData\(\)

```csharp
public void ClearRewardData()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_ClearShouldClaimReward"></a> ClearShouldClaimReward\(\)

```csharp
public void ClearShouldClaimReward()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldClaimEncounterReward Clone()
```

#### Returns

 [CMsgClientToGCOverworldClaimEncounterReward](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimEncounterReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_"></a> Equals\(CMsgClientToGCOverworldClaimEncounterReward\)

```csharp
public bool Equals(CMsgClientToGCOverworldClaimEncounterReward other)
```

#### Parameters

`other` [CMsgClientToGCOverworldClaimEncounterReward](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimEncounterReward.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_"></a> MergeFrom\(CMsgClientToGCOverworldClaimEncounterReward\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldClaimEncounterReward other)
```

#### Parameters

`other` [CMsgClientToGCOverworldClaimEncounterReward](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimEncounterReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterReward_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

