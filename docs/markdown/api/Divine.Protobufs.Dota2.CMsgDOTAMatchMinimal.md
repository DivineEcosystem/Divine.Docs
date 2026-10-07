# <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal"></a> Class CMsgDOTAMatchMinimal

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAMatchMinimal : IMessage<CMsgDOTAMatchMinimal>, IEquatable<CMsgDOTAMatchMinimal>, IDeepCloneable<CMsgDOTAMatchMinimal>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAMatchMinimal](Divine.Protobufs.Dota2.CMsgDOTAMatchMinimal.md)

#### Implements

IMessage<CMsgDOTAMatchMinimal\>, 
[IEquatable<CMsgDOTAMatchMinimal\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAMatchMinimal\>, 
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
[EnumerableExtensions.In<CMsgDOTAMatchMinimal\>\(CMsgDOTAMatchMinimal, params CMsgDOTAMatchMinimal\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal__ctor"></a> CMsgDOTAMatchMinimal\(\)

```csharp
public CMsgDOTAMatchMinimal()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal__ctor_Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_"></a> CMsgDOTAMatchMinimal\(CMsgDOTAMatchMinimal\)

```csharp
public CMsgDOTAMatchMinimal(CMsgDOTAMatchMinimal other)
```

#### Parameters

`other` [CMsgDOTAMatchMinimal](Divine.Protobufs.Dota2.CMsgDOTAMatchMinimal.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_DireScoreFieldNumber"></a> DireScoreFieldNumber

```csharp
public const int DireScoreFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_GameModeFieldNumber"></a> GameModeFieldNumber

```csharp
public const int GameModeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_IsPlayerDraftFieldNumber"></a> IsPlayerDraftFieldNumber

```csharp
public const int IsPlayerDraftFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_LobbyTypeFieldNumber"></a> LobbyTypeFieldNumber

```csharp
public const int LobbyTypeFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_MatchOutcomeFieldNumber"></a> MatchOutcomeFieldNumber

```csharp
public const int MatchOutcomeFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_RadiantScoreFieldNumber"></a> RadiantScoreFieldNumber

```csharp
public const int RadiantScoreFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_StartTimeFieldNumber"></a> StartTimeFieldNumber

```csharp
public const int StartTimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_TourneyFieldNumber"></a> TourneyFieldNumber

```csharp
public const int TourneyFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_DireScore"></a> DireScore

```csharp
public uint DireScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_Duration"></a> Duration

```csharp
public uint Duration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_GameMode"></a> GameMode

```csharp
public DOTA_GameMode GameMode { get; set; }
```

#### Property Value

 [DOTA\_GameMode](Divine.Protobufs.Dota2.DOTA\_GameMode.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_HasDireScore"></a> HasDireScore

```csharp
public bool HasDireScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_HasGameMode"></a> HasGameMode

```csharp
public bool HasGameMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_HasIsPlayerDraft"></a> HasIsPlayerDraft

```csharp
public bool HasIsPlayerDraft { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_HasLobbyType"></a> HasLobbyType

```csharp
public bool HasLobbyType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_HasMatchOutcome"></a> HasMatchOutcome

```csharp
public bool HasMatchOutcome { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_HasRadiantScore"></a> HasRadiantScore

```csharp
public bool HasRadiantScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_HasStartTime"></a> HasStartTime

```csharp
public bool HasStartTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_IsPlayerDraft"></a> IsPlayerDraft

```csharp
public bool IsPlayerDraft { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_LobbyType"></a> LobbyType

```csharp
public uint LobbyType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_MatchOutcome"></a> MatchOutcome

```csharp
public EMatchOutcome MatchOutcome { get; set; }
```

#### Property Value

 [EMatchOutcome](Divine.Protobufs.Dota2.EMatchOutcome.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAMatchMinimal> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAMatchMinimal](Divine.Protobufs.Dota2.CMsgDOTAMatchMinimal.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_Players"></a> Players

```csharp
public RepeatedField<CMsgDOTAMatchMinimal.Types.Player> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAMatchMinimal](Divine.Protobufs.Dota2.CMsgDOTAMatchMinimal.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatchMinimal.Types.md).[Player](Divine.Protobufs.Dota2.CMsgDOTAMatchMinimal.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_RadiantScore"></a> RadiantScore

```csharp
public uint RadiantScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_StartTime"></a> StartTime

```csharp
public uint StartTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_Tourney"></a> Tourney

```csharp
public CMsgDOTAMatchMinimal.Types.Tourney Tourney { get; set; }
```

#### Property Value

 [CMsgDOTAMatchMinimal](Divine.Protobufs.Dota2.CMsgDOTAMatchMinimal.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatchMinimal.Types.md).[Tourney](Divine.Protobufs.Dota2.CMsgDOTAMatchMinimal.Types.Tourney.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_ClearDireScore"></a> ClearDireScore\(\)

```csharp
public void ClearDireScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_ClearGameMode"></a> ClearGameMode\(\)

```csharp
public void ClearGameMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_ClearIsPlayerDraft"></a> ClearIsPlayerDraft\(\)

```csharp
public void ClearIsPlayerDraft()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_ClearLobbyType"></a> ClearLobbyType\(\)

```csharp
public void ClearLobbyType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_ClearMatchOutcome"></a> ClearMatchOutcome\(\)

```csharp
public void ClearMatchOutcome()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_ClearRadiantScore"></a> ClearRadiantScore\(\)

```csharp
public void ClearRadiantScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_ClearStartTime"></a> ClearStartTime\(\)

```csharp
public void ClearStartTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAMatchMinimal Clone()
```

#### Returns

 [CMsgDOTAMatchMinimal](Divine.Protobufs.Dota2.CMsgDOTAMatchMinimal.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_Equals_Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_"></a> Equals\(CMsgDOTAMatchMinimal\)

```csharp
public bool Equals(CMsgDOTAMatchMinimal other)
```

#### Parameters

`other` [CMsgDOTAMatchMinimal](Divine.Protobufs.Dota2.CMsgDOTAMatchMinimal.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_"></a> MergeFrom\(CMsgDOTAMatchMinimal\)

```csharp
public void MergeFrom(CMsgDOTAMatchMinimal other)
```

#### Parameters

`other` [CMsgDOTAMatchMinimal](Divine.Protobufs.Dota2.CMsgDOTAMatchMinimal.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchMinimal_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

