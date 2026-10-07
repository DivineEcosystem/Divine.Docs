# <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata"></a> Class CDOTAMatchMetadata

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMatchMetadata : IMessage<CDOTAMatchMetadata>, IEquatable<CDOTAMatchMetadata>, IDeepCloneable<CDOTAMatchMetadata>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md)

#### Implements

IMessage<CDOTAMatchMetadata\>, 
[IEquatable<CDOTAMatchMetadata\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMatchMetadata\>, 
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
[EnumerableExtensions.In<CDOTAMatchMetadata\>\(CDOTAMatchMetadata, params CDOTAMatchMetadata\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata__ctor"></a> CDOTAMatchMetadata\(\)

```csharp
public CDOTAMatchMetadata()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata__ctor_Divine_Protobufs_Dota2_CDOTAMatchMetadata_"></a> CDOTAMatchMetadata\(CDOTAMatchMetadata\)

```csharp
public CDOTAMatchMetadata(CDOTAMatchMetadata other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_CustomPostGameTableFieldNumber"></a> CustomPostGameTableFieldNumber

```csharp
public const int CustomPostGameTableFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_EventGameCustomTableFieldNumber"></a> EventGameCustomTableFieldNumber

```csharp
public const int EventGameCustomTableFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_GuildChallengeProgressFieldNumber"></a> GuildChallengeProgressFieldNumber

```csharp
public const int GuildChallengeProgressFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_LobbyIdFieldNumber"></a> LobbyIdFieldNumber

```csharp
public const int LobbyIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_MatchmakingStatsFieldNumber"></a> MatchmakingStatsFieldNumber

```csharp
public const int MatchmakingStatsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_MatchTipsFieldNumber"></a> MatchTipsFieldNumber

```csharp
public const int MatchTipsFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_MatchTrackedStatsFieldNumber"></a> MatchTrackedStatsFieldNumber

```csharp
public const int MatchTrackedStatsFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_MvpDataFieldNumber"></a> MvpDataFieldNumber

```csharp
public const int MvpDataFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_PrimaryEventIdFieldNumber"></a> PrimaryEventIdFieldNumber

```csharp
public const int PrimaryEventIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_PrimaryEventIdForDisplayFieldNumber"></a> PrimaryEventIdForDisplayFieldNumber

```csharp
public const int PrimaryEventIdForDisplayFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_ReportUntilTimeFieldNumber"></a> ReportUntilTimeFieldNumber

```csharp
public const int ReportUntilTimeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_TeamsFieldNumber"></a> TeamsFieldNumber

```csharp
public const int TeamsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_CustomPostGameTable"></a> CustomPostGameTable

```csharp
public ByteString CustomPostGameTable { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_EventGameCustomTable"></a> EventGameCustomTable

```csharp
public ByteString EventGameCustomTable { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_GuildChallengeProgress"></a> GuildChallengeProgress

```csharp
public RepeatedField<CDOTAMatchMetadata.Types.GuildChallengeProgress> GuildChallengeProgress { get; }
```

#### Property Value

 RepeatedField<[CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[GuildChallengeProgress](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.GuildChallengeProgress.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_HasCustomPostGameTable"></a> HasCustomPostGameTable

```csharp
public bool HasCustomPostGameTable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_HasEventGameCustomTable"></a> HasEventGameCustomTable

```csharp
public bool HasEventGameCustomTable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_HasLobbyId"></a> HasLobbyId

```csharp
public bool HasLobbyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_HasPrimaryEventId"></a> HasPrimaryEventId

```csharp
public bool HasPrimaryEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_HasPrimaryEventIdForDisplay"></a> HasPrimaryEventIdForDisplay

```csharp
public bool HasPrimaryEventIdForDisplay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_HasReportUntilTime"></a> HasReportUntilTime

```csharp
public bool HasReportUntilTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_LobbyId"></a> LobbyId

```csharp
public ulong LobbyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_MatchmakingStats"></a> MatchmakingStats

```csharp
public CMsgMatchMatchmakingStats MatchmakingStats { get; set; }
```

#### Property Value

 [CMsgMatchMatchmakingStats](Divine.Protobufs.Dota2.CMsgMatchMatchmakingStats.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_MatchTips"></a> MatchTips

```csharp
public RepeatedField<CDOTAMatchMetadata.Types.Tip> MatchTips { get; }
```

#### Property Value

 RepeatedField<[CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Tip](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Tip.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_MatchTrackedStats"></a> MatchTrackedStats

```csharp
public RepeatedField<CMsgTrackedStat> MatchTrackedStats { get; }
```

#### Property Value

 RepeatedField<[CMsgTrackedStat](Divine.Protobufs.Dota2.CMsgTrackedStat.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_MvpData"></a> MvpData

```csharp
public CMvpData MvpData { get; set; }
```

#### Property Value

 [CMvpData](Divine.Protobufs.Dota2.CMvpData.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMatchMetadata> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_PrimaryEventId"></a> PrimaryEventId

```csharp
public uint PrimaryEventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_PrimaryEventIdForDisplay"></a> PrimaryEventIdForDisplay

```csharp
public uint PrimaryEventIdForDisplay { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_ReportUntilTime"></a> ReportUntilTime

```csharp
public ulong ReportUntilTime { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Teams"></a> Teams

```csharp
public RepeatedField<CDOTAMatchMetadata.Types.Team> Teams { get; }
```

#### Property Value

 RepeatedField<[CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_ClearCustomPostGameTable"></a> ClearCustomPostGameTable\(\)

```csharp
public void ClearCustomPostGameTable()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_ClearEventGameCustomTable"></a> ClearEventGameCustomTable\(\)

```csharp
public void ClearEventGameCustomTable()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_ClearLobbyId"></a> ClearLobbyId\(\)

```csharp
public void ClearLobbyId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_ClearPrimaryEventId"></a> ClearPrimaryEventId\(\)

```csharp
public void ClearPrimaryEventId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_ClearPrimaryEventIdForDisplay"></a> ClearPrimaryEventIdForDisplay\(\)

```csharp
public void ClearPrimaryEventIdForDisplay()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_ClearReportUntilTime"></a> ClearReportUntilTime\(\)

```csharp
public void ClearReportUntilTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Clone"></a> Clone\(\)

```csharp
public CDOTAMatchMetadata Clone()
```

#### Returns

 [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Equals_Divine_Protobufs_Dota2_CDOTAMatchMetadata_"></a> Equals\(CDOTAMatchMetadata\)

```csharp
public bool Equals(CDOTAMatchMetadata other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_MergeFrom_Divine_Protobufs_Dota2_CDOTAMatchMetadata_"></a> MergeFrom\(CDOTAMatchMetadata\)

```csharp
public void MergeFrom(CDOTAMatchMetadata other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

