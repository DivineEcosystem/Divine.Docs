# <a id="Divine_Protobufs_Dota2_CSODOTAParty"></a> Class CSODOTAParty

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSODOTAParty : IMessage<CSODOTAParty>, IEquatable<CSODOTAParty>, IDeepCloneable<CSODOTAParty>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSODOTAParty](Divine.Protobufs.Dota2.CSODOTAParty.md)

#### Implements

IMessage<CSODOTAParty\>, 
[IEquatable<CSODOTAParty\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSODOTAParty\>, 
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
[EnumerableExtensions.In<CSODOTAParty\>\(CSODOTAParty, params CSODOTAParty\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSODOTAParty__ctor"></a> CSODOTAParty\(\)

```csharp
public CSODOTAParty()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty__ctor_Divine_Protobufs_Dota2_CSODOTAParty_"></a> CSODOTAParty\(CSODOTAParty\)

```csharp
public CSODOTAParty(CSODOTAParty other)
```

#### Parameters

`other` [CSODOTAParty](Divine.Protobufs.Dota2.CSODOTAParty.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_AccountFlagsFieldNumber"></a> AccountFlagsFieldNumber

```csharp
public const int AccountFlagsFieldNumber = 43
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_AttemptNumFieldNumber"></a> AttemptNumFieldNumber

```csharp
public const int AttemptNumFieldNumber = 34
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_AttemptStartTimeFieldNumber"></a> AttemptStartTimeFieldNumber

```csharp
public const int AttemptStartTimeFieldNumber = 33
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_BehaviorScoreLikertScaleFieldNumber"></a> BehaviorScoreLikertScaleFieldNumber

```csharp
public const int BehaviorScoreLikertScaleFieldNumber = 77
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_BotDifficultyMaskFieldNumber"></a> BotDifficultyMaskFieldNumber

```csharp
public const int BotDifficultyMaskFieldNumber = 72
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_BotScriptIndexMaskFieldNumber"></a> BotScriptIndexMaskFieldNumber

```csharp
public const int BotScriptIndexMaskFieldNumber = 73
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ContainsRequiredPlaytesterFieldNumber"></a> ContainsRequiredPlaytesterFieldNumber

```csharp
public const int ContainsRequiredPlaytesterFieldNumber = 78
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_CustomGameDifficultyMaskFieldNumber"></a> CustomGameDifficultyMaskFieldNumber

```csharp
public const int CustomGameDifficultyMaskFieldNumber = 70
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_CustomGameDisabledAccountIdFieldNumber"></a> CustomGameDisabledAccountIdFieldNumber

```csharp
public const int CustomGameDisabledAccountIdFieldNumber = 64
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_CustomGameDisabledUntilDateFieldNumber"></a> CustomGameDisabledUntilDateFieldNumber

```csharp
public const int CustomGameDisabledUntilDateFieldNumber = 63
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_EffectiveStartedMatchmakingTimeFieldNumber"></a> EffectiveStartedMatchmakingTimeFieldNumber

```csharp
public const int EffectiveStartedMatchmakingTimeFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ExclusiveTournamentIdFieldNumber"></a> ExclusiveTournamentIdFieldNumber

```csharp
public const int ExclusiveTournamentIdFieldNumber = 45
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_GameModesFieldNumber"></a> GameModesFieldNumber

```csharp
public const int GameModesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HighPriorityStateFieldNumber"></a> HighPriorityStateFieldNumber

```csharp
public const int HighPriorityStateFieldNumber = 68
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_IsChallengeMatchFieldNumber"></a> IsChallengeMatchFieldNumber

```csharp
public const int IsChallengeMatchFieldNumber = 65
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_IsSteamChinaFieldNumber"></a> IsSteamChinaFieldNumber

```csharp
public const int IsSteamChinaFieldNumber = 71
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_LaneSelectionsEnabledFieldNumber"></a> LaneSelectionsEnabledFieldNumber

```csharp
public const int LaneSelectionsEnabledFieldNumber = 69
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_LeaderIdFieldNumber"></a> LeaderIdFieldNumber

```csharp
public const int LeaderIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_LowPriorityAccountIdFieldNumber"></a> LowPriorityAccountIdFieldNumber

```csharp
public const int LowPriorityAccountIdFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_LowPriorityGamesRemainingFieldNumber"></a> LowPriorityGamesRemainingFieldNumber

```csharp
public const int LowPriorityGamesRemainingFieldNumber = 35
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_MatchDisabledAccountIdFieldNumber"></a> MatchDisabledAccountIdFieldNumber

```csharp
public const int MatchDisabledAccountIdFieldNumber = 25
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_MatchDisabledUntilDateFieldNumber"></a> MatchDisabledUntilDateFieldNumber

```csharp
public const int MatchDisabledUntilDateFieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_MatchgroupsFieldNumber"></a> MatchgroupsFieldNumber

```csharp
public const int MatchgroupsFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_MatchlanguagesFieldNumber"></a> MatchlanguagesFieldNumber

```csharp
public const int MatchlanguagesFieldNumber = 27
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_MatchmakingFlagsFieldNumber"></a> MatchmakingFlagsFieldNumber

```csharp
public const int MatchmakingFlagsFieldNumber = 67
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_MatchmakingMaxRangeMinutesFieldNumber"></a> MatchmakingMaxRangeMinutesFieldNumber

```csharp
public const int MatchmakingMaxRangeMinutesFieldNumber = 26
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_MatchTypeFieldNumber"></a> MatchTypeFieldNumber

```csharp
public const int MatchTypeFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_MemberIdsFieldNumber"></a> MemberIdsFieldNumber

```csharp
public const int MemberIdsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_MembersFieldNumber"></a> MembersFieldNumber

```csharp
public const int MembersFieldNumber = 29
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_OpenForJoinRequestsFieldNumber"></a> OpenForJoinRequestsFieldNumber

```csharp
public const int OpenForJoinRequestsFieldNumber = 40
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_PartyBuilderMatchGroupsFieldNumber"></a> PartyBuilderMatchGroupsFieldNumber

```csharp
public const int PartyBuilderMatchGroupsFieldNumber = 57
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_PartyBuilderSlotsToFillFieldNumber"></a> PartyBuilderSlotsToFillFieldNumber

```csharp
public const int PartyBuilderSlotsToFillFieldNumber = 56
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_PartyBuilderStartTimeFieldNumber"></a> PartyBuilderStartTimeFieldNumber

```csharp
public const int PartyBuilderStartTimeFieldNumber = 58
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_PartyIdFieldNumber"></a> PartyIdFieldNumber

```csharp
public const int PartyIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_PartySearchBeaconActiveFieldNumber"></a> PartySearchBeaconActiveFieldNumber

```csharp
public const int PartySearchBeaconActiveFieldNumber = 66
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_RankSpreadLikertScaleFieldNumber"></a> RankSpreadLikertScaleFieldNumber

```csharp
public const int RankSpreadLikertScaleFieldNumber = 76
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_RawStartedMatchmakingTimeFieldNumber"></a> RawStartedMatchmakingTimeFieldNumber

```csharp
public const int RawStartedMatchmakingTimeFieldNumber = 32
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ReadyCheckFieldNumber"></a> ReadyCheckFieldNumber

```csharp
public const int ReadyCheckFieldNumber = 62
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_RecvInvitesFieldNumber"></a> RecvInvitesFieldNumber

```csharp
public const int RecvInvitesFieldNumber = 42
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_RegionSelectFlagsFieldNumber"></a> RegionSelectFlagsFieldNumber

```csharp
public const int RegionSelectFlagsFieldNumber = 44
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_RestrictedFromRankedAccountIdFieldNumber"></a> RestrictedFromRankedAccountIdFieldNumber

```csharp
public const int RestrictedFromRankedAccountIdFieldNumber = 75
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_RestrictedFromRankedFieldNumber"></a> RestrictedFromRankedFieldNumber

```csharp
public const int RestrictedFromRankedFieldNumber = 74
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_SentInvitesFieldNumber"></a> SentInvitesFieldNumber

```csharp
public const int SentInvitesFieldNumber = 41
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_SoloQueueFieldNumber"></a> SoloQueueFieldNumber

```csharp
public const int SoloQueueFieldNumber = 59
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_StateFieldNumber"></a> StateFieldNumber

```csharp
public const int StateFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_SteamClanAccountIdFieldNumber"></a> SteamClanAccountIdFieldNumber

```csharp
public const int SteamClanAccountIdFieldNumber = 61
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TeamBaseLogoFieldNumber"></a> TeamBaseLogoFieldNumber

```csharp
public const int TeamBaseLogoFieldNumber = 53
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TeamNameFieldNumber"></a> TeamNameFieldNumber

```csharp
public const int TeamNameFieldNumber = 51
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TeamUiLogoFieldNumber"></a> TeamUiLogoFieldNumber

```csharp
public const int TeamUiLogoFieldNumber = 52
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TourneyBracketRoundFieldNumber"></a> TourneyBracketRoundFieldNumber

```csharp
public const int TourneyBracketRoundFieldNumber = 50
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TourneyDivisionIdFieldNumber"></a> TourneyDivisionIdFieldNumber

```csharp
public const int TourneyDivisionIdFieldNumber = 47
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TourneyQueueDeadlineStateFieldNumber"></a> TourneyQueueDeadlineStateFieldNumber

```csharp
public const int TourneyQueueDeadlineStateFieldNumber = 55
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TourneyQueueDeadlineTimeFieldNumber"></a> TourneyQueueDeadlineTimeFieldNumber

```csharp
public const int TourneyQueueDeadlineTimeFieldNumber = 54
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TourneyScheduleTimeFieldNumber"></a> TourneyScheduleTimeFieldNumber

```csharp
public const int TourneyScheduleTimeFieldNumber = 48
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TourneySkillLevelFieldNumber"></a> TourneySkillLevelFieldNumber

```csharp
public const int TourneySkillLevelFieldNumber = 49
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_AccountFlags"></a> AccountFlags

```csharp
public uint AccountFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_AttemptNum"></a> AttemptNum

```csharp
public uint AttemptNum { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_AttemptStartTime"></a> AttemptStartTime

```csharp
public uint AttemptStartTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_BehaviorScoreLikertScale"></a> BehaviorScoreLikertScale

```csharp
public uint BehaviorScoreLikertScale { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_BotDifficultyMask"></a> BotDifficultyMask

```csharp
public uint BotDifficultyMask { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_BotScriptIndexMask"></a> BotScriptIndexMask

```csharp
public uint BotScriptIndexMask { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ContainsRequiredPlaytester"></a> ContainsRequiredPlaytester

```csharp
public bool ContainsRequiredPlaytester { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_CustomGameDifficultyMask"></a> CustomGameDifficultyMask

```csharp
public uint CustomGameDifficultyMask { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_CustomGameDisabledAccountId"></a> CustomGameDisabledAccountId

```csharp
public uint CustomGameDisabledAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_CustomGameDisabledUntilDate"></a> CustomGameDisabledUntilDate

```csharp
public uint CustomGameDisabledUntilDate { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_EffectiveStartedMatchmakingTime"></a> EffectiveStartedMatchmakingTime

```csharp
public uint EffectiveStartedMatchmakingTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ExclusiveTournamentId"></a> ExclusiveTournamentId

```csharp
public uint ExclusiveTournamentId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_GameModes"></a> GameModes

```csharp
public uint GameModes { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasAccountFlags"></a> HasAccountFlags

```csharp
public bool HasAccountFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasAttemptNum"></a> HasAttemptNum

```csharp
public bool HasAttemptNum { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasAttemptStartTime"></a> HasAttemptStartTime

```csharp
public bool HasAttemptStartTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasBehaviorScoreLikertScale"></a> HasBehaviorScoreLikertScale

```csharp
public bool HasBehaviorScoreLikertScale { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasBotDifficultyMask"></a> HasBotDifficultyMask

```csharp
public bool HasBotDifficultyMask { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasBotScriptIndexMask"></a> HasBotScriptIndexMask

```csharp
public bool HasBotScriptIndexMask { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasContainsRequiredPlaytester"></a> HasContainsRequiredPlaytester

```csharp
public bool HasContainsRequiredPlaytester { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasCustomGameDifficultyMask"></a> HasCustomGameDifficultyMask

```csharp
public bool HasCustomGameDifficultyMask { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasCustomGameDisabledAccountId"></a> HasCustomGameDisabledAccountId

```csharp
public bool HasCustomGameDisabledAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasCustomGameDisabledUntilDate"></a> HasCustomGameDisabledUntilDate

```csharp
public bool HasCustomGameDisabledUntilDate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasEffectiveStartedMatchmakingTime"></a> HasEffectiveStartedMatchmakingTime

```csharp
public bool HasEffectiveStartedMatchmakingTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasExclusiveTournamentId"></a> HasExclusiveTournamentId

```csharp
public bool HasExclusiveTournamentId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasGameModes"></a> HasGameModes

```csharp
public bool HasGameModes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasHighPriorityState"></a> HasHighPriorityState

```csharp
public bool HasHighPriorityState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasIsChallengeMatch"></a> HasIsChallengeMatch

```csharp
public bool HasIsChallengeMatch { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasIsSteamChina"></a> HasIsSteamChina

```csharp
public bool HasIsSteamChina { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasLaneSelectionsEnabled"></a> HasLaneSelectionsEnabled

```csharp
public bool HasLaneSelectionsEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasLeaderId"></a> HasLeaderId

```csharp
public bool HasLeaderId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasLowPriorityAccountId"></a> HasLowPriorityAccountId

```csharp
public bool HasLowPriorityAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasLowPriorityGamesRemaining"></a> HasLowPriorityGamesRemaining

```csharp
public bool HasLowPriorityGamesRemaining { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasMatchDisabledAccountId"></a> HasMatchDisabledAccountId

```csharp
public bool HasMatchDisabledAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasMatchDisabledUntilDate"></a> HasMatchDisabledUntilDate

```csharp
public bool HasMatchDisabledUntilDate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasMatchgroups"></a> HasMatchgroups

```csharp
public bool HasMatchgroups { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasMatchlanguages"></a> HasMatchlanguages

```csharp
public bool HasMatchlanguages { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasMatchmakingFlags"></a> HasMatchmakingFlags

```csharp
public bool HasMatchmakingFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasMatchmakingMaxRangeMinutes"></a> HasMatchmakingMaxRangeMinutes

```csharp
public bool HasMatchmakingMaxRangeMinutes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasMatchType"></a> HasMatchType

```csharp
public bool HasMatchType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasOpenForJoinRequests"></a> HasOpenForJoinRequests

```csharp
public bool HasOpenForJoinRequests { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasPartyBuilderMatchGroups"></a> HasPartyBuilderMatchGroups

```csharp
public bool HasPartyBuilderMatchGroups { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasPartyBuilderSlotsToFill"></a> HasPartyBuilderSlotsToFill

```csharp
public bool HasPartyBuilderSlotsToFill { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasPartyBuilderStartTime"></a> HasPartyBuilderStartTime

```csharp
public bool HasPartyBuilderStartTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasPartyId"></a> HasPartyId

```csharp
public bool HasPartyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasPartySearchBeaconActive"></a> HasPartySearchBeaconActive

```csharp
public bool HasPartySearchBeaconActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasRankSpreadLikertScale"></a> HasRankSpreadLikertScale

```csharp
public bool HasRankSpreadLikertScale { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasRawStartedMatchmakingTime"></a> HasRawStartedMatchmakingTime

```csharp
public bool HasRawStartedMatchmakingTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasRegionSelectFlags"></a> HasRegionSelectFlags

```csharp
public bool HasRegionSelectFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasRestrictedFromRanked"></a> HasRestrictedFromRanked

```csharp
public bool HasRestrictedFromRanked { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasRestrictedFromRankedAccountId"></a> HasRestrictedFromRankedAccountId

```csharp
public bool HasRestrictedFromRankedAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasSoloQueue"></a> HasSoloQueue

```csharp
public bool HasSoloQueue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasState"></a> HasState

```csharp
public bool HasState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasSteamClanAccountId"></a> HasSteamClanAccountId

```csharp
public bool HasSteamClanAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasTeamBaseLogo"></a> HasTeamBaseLogo

```csharp
public bool HasTeamBaseLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasTeamName"></a> HasTeamName

```csharp
public bool HasTeamName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasTeamUiLogo"></a> HasTeamUiLogo

```csharp
public bool HasTeamUiLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasTourneyBracketRound"></a> HasTourneyBracketRound

```csharp
public bool HasTourneyBracketRound { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasTourneyDivisionId"></a> HasTourneyDivisionId

```csharp
public bool HasTourneyDivisionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasTourneyQueueDeadlineState"></a> HasTourneyQueueDeadlineState

```csharp
public bool HasTourneyQueueDeadlineState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasTourneyQueueDeadlineTime"></a> HasTourneyQueueDeadlineTime

```csharp
public bool HasTourneyQueueDeadlineTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasTourneyScheduleTime"></a> HasTourneyScheduleTime

```csharp
public bool HasTourneyScheduleTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HasTourneySkillLevel"></a> HasTourneySkillLevel

```csharp
public bool HasTourneySkillLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_HighPriorityState"></a> HighPriorityState

```csharp
public EHighPriorityMMState HighPriorityState { get; set; }
```

#### Property Value

 [EHighPriorityMMState](Divine.Protobufs.Dota2.EHighPriorityMMState.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_IsChallengeMatch"></a> IsChallengeMatch

```csharp
public bool IsChallengeMatch { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_IsSteamChina"></a> IsSteamChina

```csharp
public bool IsSteamChina { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_LaneSelectionsEnabled"></a> LaneSelectionsEnabled

```csharp
public bool LaneSelectionsEnabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_LeaderId"></a> LeaderId

```csharp
public ulong LeaderId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_LowPriorityAccountId"></a> LowPriorityAccountId

```csharp
public uint LowPriorityAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_LowPriorityGamesRemaining"></a> LowPriorityGamesRemaining

```csharp
public uint LowPriorityGamesRemaining { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_MatchDisabledAccountId"></a> MatchDisabledAccountId

```csharp
public uint MatchDisabledAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_MatchDisabledUntilDate"></a> MatchDisabledUntilDate

```csharp
public uint MatchDisabledUntilDate { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_Matchgroups"></a> Matchgroups

```csharp
public uint Matchgroups { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_Matchlanguages"></a> Matchlanguages

```csharp
public uint Matchlanguages { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_MatchmakingFlags"></a> MatchmakingFlags

```csharp
public uint MatchmakingFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_MatchmakingMaxRangeMinutes"></a> MatchmakingMaxRangeMinutes

```csharp
public uint MatchmakingMaxRangeMinutes { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_MatchType"></a> MatchType

```csharp
public MatchType MatchType { get; set; }
```

#### Property Value

 [MatchType](Divine.Protobufs.Dota2.MatchType.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_MemberIds"></a> MemberIds

```csharp
public RepeatedField<ulong> MemberIds { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_Members"></a> Members

```csharp
public RepeatedField<CSODOTAPartyMember> Members { get; }
```

#### Property Value

 RepeatedField<[CSODOTAPartyMember](Divine.Protobufs.Dota2.CSODOTAPartyMember.md)\>

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_OpenForJoinRequests"></a> OpenForJoinRequests

```csharp
public bool OpenForJoinRequests { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_Parser"></a> Parser

```csharp
public static MessageParser<CSODOTAParty> Parser { get; }
```

#### Property Value

 MessageParser<[CSODOTAParty](Divine.Protobufs.Dota2.CSODOTAParty.md)\>

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_PartyBuilderMatchGroups"></a> PartyBuilderMatchGroups

```csharp
public uint PartyBuilderMatchGroups { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_PartyBuilderSlotsToFill"></a> PartyBuilderSlotsToFill

```csharp
public uint PartyBuilderSlotsToFill { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_PartyBuilderStartTime"></a> PartyBuilderStartTime

```csharp
public uint PartyBuilderStartTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_PartyId"></a> PartyId

```csharp
public ulong PartyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_PartySearchBeaconActive"></a> PartySearchBeaconActive

```csharp
public bool PartySearchBeaconActive { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_RankSpreadLikertScale"></a> RankSpreadLikertScale

```csharp
public uint RankSpreadLikertScale { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_RawStartedMatchmakingTime"></a> RawStartedMatchmakingTime

```csharp
public uint RawStartedMatchmakingTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ReadyCheck"></a> ReadyCheck

```csharp
public CMsgReadyCheckStatus ReadyCheck { get; set; }
```

#### Property Value

 [CMsgReadyCheckStatus](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_RecvInvites"></a> RecvInvites

```csharp
public RepeatedField<CSODOTAPartyInvite> RecvInvites { get; }
```

#### Property Value

 RepeatedField<[CSODOTAPartyInvite](Divine.Protobufs.Dota2.CSODOTAPartyInvite.md)\>

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_RegionSelectFlags"></a> RegionSelectFlags

```csharp
public uint RegionSelectFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_RestrictedFromRanked"></a> RestrictedFromRanked

```csharp
public bool RestrictedFromRanked { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_RestrictedFromRankedAccountId"></a> RestrictedFromRankedAccountId

```csharp
public uint RestrictedFromRankedAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_SentInvites"></a> SentInvites

```csharp
public RepeatedField<CSODOTAPartyInvite> SentInvites { get; }
```

#### Property Value

 RepeatedField<[CSODOTAPartyInvite](Divine.Protobufs.Dota2.CSODOTAPartyInvite.md)\>

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_SoloQueue"></a> SoloQueue

```csharp
public bool SoloQueue { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_State"></a> State

```csharp
public CSODOTAParty.Types.State State { get; set; }
```

#### Property Value

 [CSODOTAParty](Divine.Protobufs.Dota2.CSODOTAParty.md).[Types](Divine.Protobufs.Dota2.CSODOTAParty.Types.md).[State](Divine.Protobufs.Dota2.CSODOTAParty.Types.State.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_SteamClanAccountId"></a> SteamClanAccountId

```csharp
public uint SteamClanAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TeamBaseLogo"></a> TeamBaseLogo

```csharp
public ulong TeamBaseLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TeamName"></a> TeamName

```csharp
public string TeamName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TeamUiLogo"></a> TeamUiLogo

```csharp
public ulong TeamUiLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TourneyBracketRound"></a> TourneyBracketRound

```csharp
public uint TourneyBracketRound { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TourneyDivisionId"></a> TourneyDivisionId

```csharp
public uint TourneyDivisionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TourneyQueueDeadlineState"></a> TourneyQueueDeadlineState

```csharp
public ETourneyQueueDeadlineState TourneyQueueDeadlineState { get; set; }
```

#### Property Value

 [ETourneyQueueDeadlineState](Divine.Protobufs.Dota2.ETourneyQueueDeadlineState.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TourneyQueueDeadlineTime"></a> TourneyQueueDeadlineTime

```csharp
public uint TourneyQueueDeadlineTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TourneyScheduleTime"></a> TourneyScheduleTime

```csharp
public uint TourneyScheduleTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_TourneySkillLevel"></a> TourneySkillLevel

```csharp
public uint TourneySkillLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearAccountFlags"></a> ClearAccountFlags\(\)

```csharp
public void ClearAccountFlags()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearAttemptNum"></a> ClearAttemptNum\(\)

```csharp
public void ClearAttemptNum()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearAttemptStartTime"></a> ClearAttemptStartTime\(\)

```csharp
public void ClearAttemptStartTime()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearBehaviorScoreLikertScale"></a> ClearBehaviorScoreLikertScale\(\)

```csharp
public void ClearBehaviorScoreLikertScale()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearBotDifficultyMask"></a> ClearBotDifficultyMask\(\)

```csharp
public void ClearBotDifficultyMask()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearBotScriptIndexMask"></a> ClearBotScriptIndexMask\(\)

```csharp
public void ClearBotScriptIndexMask()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearContainsRequiredPlaytester"></a> ClearContainsRequiredPlaytester\(\)

```csharp
public void ClearContainsRequiredPlaytester()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearCustomGameDifficultyMask"></a> ClearCustomGameDifficultyMask\(\)

```csharp
public void ClearCustomGameDifficultyMask()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearCustomGameDisabledAccountId"></a> ClearCustomGameDisabledAccountId\(\)

```csharp
public void ClearCustomGameDisabledAccountId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearCustomGameDisabledUntilDate"></a> ClearCustomGameDisabledUntilDate\(\)

```csharp
public void ClearCustomGameDisabledUntilDate()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearEffectiveStartedMatchmakingTime"></a> ClearEffectiveStartedMatchmakingTime\(\)

```csharp
public void ClearEffectiveStartedMatchmakingTime()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearExclusiveTournamentId"></a> ClearExclusiveTournamentId\(\)

```csharp
public void ClearExclusiveTournamentId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearGameModes"></a> ClearGameModes\(\)

```csharp
public void ClearGameModes()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearHighPriorityState"></a> ClearHighPriorityState\(\)

```csharp
public void ClearHighPriorityState()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearIsChallengeMatch"></a> ClearIsChallengeMatch\(\)

```csharp
public void ClearIsChallengeMatch()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearIsSteamChina"></a> ClearIsSteamChina\(\)

```csharp
public void ClearIsSteamChina()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearLaneSelectionsEnabled"></a> ClearLaneSelectionsEnabled\(\)

```csharp
public void ClearLaneSelectionsEnabled()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearLeaderId"></a> ClearLeaderId\(\)

```csharp
public void ClearLeaderId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearLowPriorityAccountId"></a> ClearLowPriorityAccountId\(\)

```csharp
public void ClearLowPriorityAccountId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearLowPriorityGamesRemaining"></a> ClearLowPriorityGamesRemaining\(\)

```csharp
public void ClearLowPriorityGamesRemaining()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearMatchDisabledAccountId"></a> ClearMatchDisabledAccountId\(\)

```csharp
public void ClearMatchDisabledAccountId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearMatchDisabledUntilDate"></a> ClearMatchDisabledUntilDate\(\)

```csharp
public void ClearMatchDisabledUntilDate()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearMatchgroups"></a> ClearMatchgroups\(\)

```csharp
public void ClearMatchgroups()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearMatchlanguages"></a> ClearMatchlanguages\(\)

```csharp
public void ClearMatchlanguages()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearMatchmakingFlags"></a> ClearMatchmakingFlags\(\)

```csharp
public void ClearMatchmakingFlags()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearMatchmakingMaxRangeMinutes"></a> ClearMatchmakingMaxRangeMinutes\(\)

```csharp
public void ClearMatchmakingMaxRangeMinutes()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearMatchType"></a> ClearMatchType\(\)

```csharp
public void ClearMatchType()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearOpenForJoinRequests"></a> ClearOpenForJoinRequests\(\)

```csharp
public void ClearOpenForJoinRequests()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearPartyBuilderMatchGroups"></a> ClearPartyBuilderMatchGroups\(\)

```csharp
public void ClearPartyBuilderMatchGroups()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearPartyBuilderSlotsToFill"></a> ClearPartyBuilderSlotsToFill\(\)

```csharp
public void ClearPartyBuilderSlotsToFill()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearPartyBuilderStartTime"></a> ClearPartyBuilderStartTime\(\)

```csharp
public void ClearPartyBuilderStartTime()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearPartyId"></a> ClearPartyId\(\)

```csharp
public void ClearPartyId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearPartySearchBeaconActive"></a> ClearPartySearchBeaconActive\(\)

```csharp
public void ClearPartySearchBeaconActive()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearRankSpreadLikertScale"></a> ClearRankSpreadLikertScale\(\)

```csharp
public void ClearRankSpreadLikertScale()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearRawStartedMatchmakingTime"></a> ClearRawStartedMatchmakingTime\(\)

```csharp
public void ClearRawStartedMatchmakingTime()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearRegionSelectFlags"></a> ClearRegionSelectFlags\(\)

```csharp
public void ClearRegionSelectFlags()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearRestrictedFromRanked"></a> ClearRestrictedFromRanked\(\)

```csharp
public void ClearRestrictedFromRanked()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearRestrictedFromRankedAccountId"></a> ClearRestrictedFromRankedAccountId\(\)

```csharp
public void ClearRestrictedFromRankedAccountId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearSoloQueue"></a> ClearSoloQueue\(\)

```csharp
public void ClearSoloQueue()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearState"></a> ClearState\(\)

```csharp
public void ClearState()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearSteamClanAccountId"></a> ClearSteamClanAccountId\(\)

```csharp
public void ClearSteamClanAccountId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearTeamBaseLogo"></a> ClearTeamBaseLogo\(\)

```csharp
public void ClearTeamBaseLogo()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearTeamName"></a> ClearTeamName\(\)

```csharp
public void ClearTeamName()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearTeamUiLogo"></a> ClearTeamUiLogo\(\)

```csharp
public void ClearTeamUiLogo()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearTourneyBracketRound"></a> ClearTourneyBracketRound\(\)

```csharp
public void ClearTourneyBracketRound()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearTourneyDivisionId"></a> ClearTourneyDivisionId\(\)

```csharp
public void ClearTourneyDivisionId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearTourneyQueueDeadlineState"></a> ClearTourneyQueueDeadlineState\(\)

```csharp
public void ClearTourneyQueueDeadlineState()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearTourneyQueueDeadlineTime"></a> ClearTourneyQueueDeadlineTime\(\)

```csharp
public void ClearTourneyQueueDeadlineTime()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearTourneyScheduleTime"></a> ClearTourneyScheduleTime\(\)

```csharp
public void ClearTourneyScheduleTime()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ClearTourneySkillLevel"></a> ClearTourneySkillLevel\(\)

```csharp
public void ClearTourneySkillLevel()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_Clone"></a> Clone\(\)

```csharp
public CSODOTAParty Clone()
```

#### Returns

 [CSODOTAParty](Divine.Protobufs.Dota2.CSODOTAParty.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_Equals_Divine_Protobufs_Dota2_CSODOTAParty_"></a> Equals\(CSODOTAParty\)

```csharp
public bool Equals(CSODOTAParty other)
```

#### Parameters

`other` [CSODOTAParty](Divine.Protobufs.Dota2.CSODOTAParty.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_MergeFrom_Divine_Protobufs_Dota2_CSODOTAParty_"></a> MergeFrom\(CSODOTAParty\)

```csharp
public void MergeFrom(CSODOTAParty other)
```

#### Parameters

`other` [CSODOTAParty](Divine.Protobufs.Dota2.CSODOTAParty.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTAParty_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

