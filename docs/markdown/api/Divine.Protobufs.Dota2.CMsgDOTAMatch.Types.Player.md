# <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player"></a> Class CMsgDOTAMatch.Types.Player

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAMatch.Types.Player : IMessage<CMsgDOTAMatch.Types.Player>, IEquatable<CMsgDOTAMatch.Types.Player>, IDeepCloneable<CMsgDOTAMatch.Types.Player>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAMatch.Types.Player](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.md)

#### Implements

IMessage<CMsgDOTAMatch.Types.Player\>, 
[IEquatable<CMsgDOTAMatch.Types.Player\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAMatch.Types.Player\>, 
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
[EnumerableExtensions.In<CMsgDOTAMatch.Types.Player\>\(CMsgDOTAMatch.Types.Player, params CMsgDOTAMatch.Types.Player\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player__ctor"></a> Player\(\)

```csharp
public Player()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player__ctor_Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_"></a> Player\(Player\)

```csharp
public Player(CMsgDOTAMatch.Types.Player other)
```

#### Parameters

`other` [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[Player](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_AbilityUpgradesFieldNumber"></a> AbilityUpgradesFieldNumber

```csharp
public const int AbilityUpgradesFieldNumber = 47
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ActivePlusSubscriptionFieldNumber"></a> ActivePlusSubscriptionFieldNumber

```csharp
public const int ActivePlusSubscriptionFieldNumber = 51
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_AdditionalUnitsInventoryFieldNumber"></a> AdditionalUnitsInventoryFieldNumber

```csharp
public const int AdditionalUnitsInventoryFieldNumber = 48
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_AssistsFieldNumber"></a> AssistsFieldNumber

```csharp
public const int AssistsFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_BotDifficultyFieldNumber"></a> BotDifficultyFieldNumber

```csharp
public const int BotDifficultyFieldNumber = 58
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_BountyRunesFieldNumber"></a> BountyRunesFieldNumber

```csharp
public const int BountyRunesFieldNumber = 77
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClaimedDeniesFieldNumber"></a> ClaimedDeniesFieldNumber

```csharp
public const int ClaimedDeniesFieldNumber = 44
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClaimedFarmGoldFieldNumber"></a> ClaimedFarmGoldFieldNumber

```csharp
public const int ClaimedFarmGoldFieldNumber = 42
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClaimedMissesFieldNumber"></a> ClaimedMissesFieldNumber

```csharp
public const int ClaimedMissesFieldNumber = 45
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_CustomGameDataFieldNumber"></a> CustomGameDataFieldNumber

```csharp
public const int CustomGameDataFieldNumber = 50
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_DeathsFieldNumber"></a> DeathsFieldNumber

```csharp
public const int DeathsFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_DeniesFieldNumber"></a> DeniesFieldNumber

```csharp
public const int DeniesFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_DisableDurationFieldNumber"></a> DisableDurationFieldNumber

```csharp
public const int DisableDurationFieldNumber = 85
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ExpectedTeamContributionFieldNumber"></a> ExpectedTeamContributionFieldNumber

```csharp
public const int ExpectedTeamContributionFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_FeedingDetectedFieldNumber"></a> FeedingDetectedFieldNumber

```csharp
public const int FeedingDetectedFieldNumber = 32
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_GoldFieldNumber"></a> GoldFieldNumber

```csharp
public const int GoldFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_GoldLostToDeathFieldNumber"></a> GoldLostToDeathFieldNumber

```csharp
public const int GoldLostToDeathFieldNumber = 71
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_GoldPerMinFieldNumber"></a> GoldPerMinFieldNumber

```csharp
public const int GoldPerMinFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_GoldSpentFieldNumber"></a> GoldSpentFieldNumber

```csharp
public const int GoldSpentFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HeroDamageDealtFieldNumber"></a> HeroDamageDealtFieldNumber

```csharp
public const int HeroDamageDealtFieldNumber = 79
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HeroDamageFieldNumber"></a> HeroDamageFieldNumber

```csharp
public const int HeroDamageFieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HeroDamageReceivedFieldNumber"></a> HeroDamageReceivedFieldNumber

```csharp
public const int HeroDamageReceivedFieldNumber = 67
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HeroHealingFieldNumber"></a> HeroHealingFieldNumber

```csharp
public const int HeroHealingFieldNumber = 26
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HeroPickOrderFieldNumber"></a> HeroPickOrderFieldNumber

```csharp
public const int HeroPickOrderFieldNumber = 63
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HeroPlayCountFieldNumber"></a> HeroPlayCountFieldNumber

```csharp
public const int HeroPlayCountFieldNumber = 37
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HeroWasDotaPlusSuggestionFieldNumber"></a> HeroWasDotaPlusSuggestionFieldNumber

```csharp
public const int HeroWasDotaPlusSuggestionFieldNumber = 69
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HeroWasRandomedFieldNumber"></a> HeroWasRandomedFieldNumber

```csharp
public const int HeroWasRandomedFieldNumber = 64
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item0FieldNumber"></a> Item0FieldNumber

```csharp
public const int Item0FieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item10FieldNumber"></a> Item10FieldNumber

```csharp
public const int Item10FieldNumber = 83
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item10LvlFieldNumber"></a> Item10LvlFieldNumber

```csharp
public const int Item10LvlFieldNumber = 84
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item1FieldNumber"></a> Item1FieldNumber

```csharp
public const int Item1FieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item2FieldNumber"></a> Item2FieldNumber

```csharp
public const int Item2FieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item3FieldNumber"></a> Item3FieldNumber

```csharp
public const int Item3FieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item4FieldNumber"></a> Item4FieldNumber

```csharp
public const int Item4FieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item5FieldNumber"></a> Item5FieldNumber

```csharp
public const int Item5FieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item6FieldNumber"></a> Item6FieldNumber

```csharp
public const int Item6FieldNumber = 59
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item7FieldNumber"></a> Item7FieldNumber

```csharp
public const int Item7FieldNumber = 60
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item8FieldNumber"></a> Item8FieldNumber

```csharp
public const int Item8FieldNumber = 61
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item9FieldNumber"></a> Item9FieldNumber

```csharp
public const int Item9FieldNumber = 76
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_KillsFieldNumber"></a> KillsFieldNumber

```csharp
public const int KillsFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_LaneSelectionFlagsFieldNumber"></a> LaneSelectionFlagsFieldNumber

```csharp
public const int LaneSelectionFlagsFieldNumber = 75
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_LastHitsFieldNumber"></a> LastHitsFieldNumber

```csharp
public const int LastHitsFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_LeaverStatusFieldNumber"></a> LeaverStatusFieldNumber

```csharp
public const int LeaverStatusFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_LevelFieldNumber"></a> LevelFieldNumber

```csharp
public const int LevelFieldNumber = 27
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_MissesFieldNumber"></a> MissesFieldNumber

```csharp
public const int MissesFieldNumber = 46
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_MmrTypeFieldNumber"></a> MmrTypeFieldNumber

```csharp
public const int MmrTypeFieldNumber = 74
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_NetWorthFieldNumber"></a> NetWorthFieldNumber

```csharp
public const int NetWorthFieldNumber = 52
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_OutpostsCapturedFieldNumber"></a> OutpostsCapturedFieldNumber

```csharp
public const int OutpostsCapturedFieldNumber = 78
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_PartyIdFieldNumber"></a> PartyIdFieldNumber

```csharp
public const int PartyIdFieldNumber = 38
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_PermanentBuffsFieldNumber"></a> PermanentBuffsFieldNumber

```csharp
public const int PermanentBuffsFieldNumber = 57
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_PlayerNameFieldNumber"></a> PlayerNameFieldNumber

```csharp
public const int PlayerNameFieldNumber = 29
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_PlayerSlotFieldNumber"></a> PlayerSlotFieldNumber

```csharp
public const int PlayerSlotFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_PreviousRankFieldNumber"></a> PreviousRankFieldNumber

```csharp
public const int PreviousRankFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ProNameFieldNumber"></a> ProNameFieldNumber

```csharp
public const int ProNameFieldNumber = 72
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_RankChangeFieldNumber"></a> RankChangeFieldNumber

```csharp
public const int RankChangeFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_RankUncertaintyChangeFieldNumber"></a> RankUncertaintyChangeFieldNumber

```csharp
public const int RankUncertaintyChangeFieldNumber = 36
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_RealNameFieldNumber"></a> RealNameFieldNumber

```csharp
public const int RealNameFieldNumber = 73
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ScaledAssistsFieldNumber"></a> ScaledAssistsFieldNumber

```csharp
public const int ScaledAssistsFieldNumber = 41
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ScaledDeathsFieldNumber"></a> ScaledDeathsFieldNumber

```csharp
public const int ScaledDeathsFieldNumber = 40
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ScaledHeroDamageFieldNumber"></a> ScaledHeroDamageFieldNumber

```csharp
public const int ScaledHeroDamageFieldNumber = 54
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ScaledHeroHealingFieldNumber"></a> ScaledHeroHealingFieldNumber

```csharp
public const int ScaledHeroHealingFieldNumber = 56
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ScaledKillsFieldNumber"></a> ScaledKillsFieldNumber

```csharp
public const int ScaledKillsFieldNumber = 39
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ScaledMetricFieldNumber"></a> ScaledMetricFieldNumber

```csharp
public const int ScaledMetricFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ScaledTowerDamageFieldNumber"></a> ScaledTowerDamageFieldNumber

```csharp
public const int ScaledTowerDamageFieldNumber = 55
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_SearchRankFieldNumber"></a> SearchRankFieldNumber

```csharp
public const int SearchRankFieldNumber = 34
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_SearchRankUncertaintyFieldNumber"></a> SearchRankUncertaintyFieldNumber

```csharp
public const int SearchRankUncertaintyFieldNumber = 35
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_SecondsDeadFieldNumber"></a> SecondsDeadFieldNumber

```csharp
public const int SecondsDeadFieldNumber = 70
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_SelectedFacetFieldNumber"></a> SelectedFacetFieldNumber

```csharp
public const int SelectedFacetFieldNumber = 82
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_SupportAbilityValueFieldNumber"></a> SupportAbilityValueFieldNumber

```csharp
public const int SupportAbilityValueFieldNumber = 30
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_SupportGoldFieldNumber"></a> SupportGoldFieldNumber

```csharp
public const int SupportGoldFieldNumber = 43
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_TeamNumberFieldNumber"></a> TeamNumberFieldNumber

```csharp
public const int TeamNumberFieldNumber = 80
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_TeamSlotFieldNumber"></a> TeamSlotFieldNumber

```csharp
public const int TeamSlotFieldNumber = 81
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_TimeLastSeenFieldNumber"></a> TimeLastSeenFieldNumber

```csharp
public const int TimeLastSeenFieldNumber = 28
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_TowerDamageFieldNumber"></a> TowerDamageFieldNumber

```csharp
public const int TowerDamageFieldNumber = 25
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_XpPerMinFieldNumber"></a> XpPerMinFieldNumber

```csharp
public const int XpPerMinFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_AbilityUpgrades"></a> AbilityUpgrades

```csharp
public RepeatedField<CMatchPlayerAbilityUpgrade> AbilityUpgrades { get; }
```

#### Property Value

 RepeatedField<[CMatchPlayerAbilityUpgrade](Divine.Protobufs.Dota2.CMatchPlayerAbilityUpgrade.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ActivePlusSubscription"></a> ActivePlusSubscription

```csharp
public bool ActivePlusSubscription { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_AdditionalUnitsInventory"></a> AdditionalUnitsInventory

```csharp
public RepeatedField<CMatchAdditionalUnitInventory> AdditionalUnitsInventory { get; }
```

#### Property Value

 RepeatedField<[CMatchAdditionalUnitInventory](Divine.Protobufs.Dota2.CMatchAdditionalUnitInventory.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Assists"></a> Assists

```csharp
public uint Assists { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_BotDifficulty"></a> BotDifficulty

```csharp
public uint BotDifficulty { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_BountyRunes"></a> BountyRunes

```csharp
public uint BountyRunes { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClaimedDenies"></a> ClaimedDenies

```csharp
public uint ClaimedDenies { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClaimedFarmGold"></a> ClaimedFarmGold

```csharp
public uint ClaimedFarmGold { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClaimedMisses"></a> ClaimedMisses

```csharp
public uint ClaimedMisses { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_CustomGameData"></a> CustomGameData

```csharp
public CMsgDOTAMatch.Types.Player.Types.CustomGameData CustomGameData { get; set; }
```

#### Property Value

 [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[Player](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.Types.md).[CustomGameData](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.Types.CustomGameData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Deaths"></a> Deaths

```csharp
public uint Deaths { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Denies"></a> Denies

```csharp
public uint Denies { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_DisableDuration"></a> DisableDuration

```csharp
public uint DisableDuration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ExpectedTeamContribution"></a> ExpectedTeamContribution

```csharp
public float ExpectedTeamContribution { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_FeedingDetected"></a> FeedingDetected

```csharp
public bool FeedingDetected { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Gold"></a> Gold

```csharp
public uint Gold { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_GoldLostToDeath"></a> GoldLostToDeath

```csharp
public uint GoldLostToDeath { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_GoldPerMin"></a> GoldPerMin

```csharp
public uint GoldPerMin { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_GoldSpent"></a> GoldSpent

```csharp
public uint GoldSpent { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasActivePlusSubscription"></a> HasActivePlusSubscription

```csharp
public bool HasActivePlusSubscription { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasAssists"></a> HasAssists

```csharp
public bool HasAssists { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasBotDifficulty"></a> HasBotDifficulty

```csharp
public bool HasBotDifficulty { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasBountyRunes"></a> HasBountyRunes

```csharp
public bool HasBountyRunes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasClaimedDenies"></a> HasClaimedDenies

```csharp
public bool HasClaimedDenies { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasClaimedFarmGold"></a> HasClaimedFarmGold

```csharp
public bool HasClaimedFarmGold { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasClaimedMisses"></a> HasClaimedMisses

```csharp
public bool HasClaimedMisses { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasDeaths"></a> HasDeaths

```csharp
public bool HasDeaths { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasDenies"></a> HasDenies

```csharp
public bool HasDenies { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasDisableDuration"></a> HasDisableDuration

```csharp
public bool HasDisableDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasExpectedTeamContribution"></a> HasExpectedTeamContribution

```csharp
public bool HasExpectedTeamContribution { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasFeedingDetected"></a> HasFeedingDetected

```csharp
public bool HasFeedingDetected { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasGold"></a> HasGold

```csharp
public bool HasGold { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasGoldLostToDeath"></a> HasGoldLostToDeath

```csharp
public bool HasGoldLostToDeath { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasGoldPerMin"></a> HasGoldPerMin

```csharp
public bool HasGoldPerMin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasGoldSpent"></a> HasGoldSpent

```csharp
public bool HasGoldSpent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasHeroDamage"></a> HasHeroDamage

```csharp
public bool HasHeroDamage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasHeroHealing"></a> HasHeroHealing

```csharp
public bool HasHeroHealing { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasHeroPickOrder"></a> HasHeroPickOrder

```csharp
public bool HasHeroPickOrder { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasHeroPlayCount"></a> HasHeroPlayCount

```csharp
public bool HasHeroPlayCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasHeroWasDotaPlusSuggestion"></a> HasHeroWasDotaPlusSuggestion

```csharp
public bool HasHeroWasDotaPlusSuggestion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasHeroWasRandomed"></a> HasHeroWasRandomed

```csharp
public bool HasHeroWasRandomed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasItem0"></a> HasItem0

```csharp
public bool HasItem0 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasItem1"></a> HasItem1

```csharp
public bool HasItem1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasItem10"></a> HasItem10

```csharp
public bool HasItem10 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasItem10Lvl"></a> HasItem10Lvl

```csharp
public bool HasItem10Lvl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasItem2"></a> HasItem2

```csharp
public bool HasItem2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasItem3"></a> HasItem3

```csharp
public bool HasItem3 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasItem4"></a> HasItem4

```csharp
public bool HasItem4 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasItem5"></a> HasItem5

```csharp
public bool HasItem5 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasItem6"></a> HasItem6

```csharp
public bool HasItem6 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasItem7"></a> HasItem7

```csharp
public bool HasItem7 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasItem8"></a> HasItem8

```csharp
public bool HasItem8 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasItem9"></a> HasItem9

```csharp
public bool HasItem9 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasKills"></a> HasKills

```csharp
public bool HasKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasLaneSelectionFlags"></a> HasLaneSelectionFlags

```csharp
public bool HasLaneSelectionFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasLastHits"></a> HasLastHits

```csharp
public bool HasLastHits { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasLeaverStatus"></a> HasLeaverStatus

```csharp
public bool HasLeaverStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasLevel"></a> HasLevel

```csharp
public bool HasLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasMisses"></a> HasMisses

```csharp
public bool HasMisses { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasMmrType"></a> HasMmrType

```csharp
public bool HasMmrType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasNetWorth"></a> HasNetWorth

```csharp
public bool HasNetWorth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasOutpostsCaptured"></a> HasOutpostsCaptured

```csharp
public bool HasOutpostsCaptured { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasPartyId"></a> HasPartyId

```csharp
public bool HasPartyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasPlayerName"></a> HasPlayerName

```csharp
public bool HasPlayerName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasPlayerSlot"></a> HasPlayerSlot

```csharp
public bool HasPlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasPreviousRank"></a> HasPreviousRank

```csharp
public bool HasPreviousRank { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasProName"></a> HasProName

```csharp
public bool HasProName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasRankChange"></a> HasRankChange

```csharp
public bool HasRankChange { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasRankUncertaintyChange"></a> HasRankUncertaintyChange

```csharp
public bool HasRankUncertaintyChange { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasRealName"></a> HasRealName

```csharp
public bool HasRealName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasScaledAssists"></a> HasScaledAssists

```csharp
public bool HasScaledAssists { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasScaledDeaths"></a> HasScaledDeaths

```csharp
public bool HasScaledDeaths { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasScaledHeroDamage"></a> HasScaledHeroDamage

```csharp
public bool HasScaledHeroDamage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasScaledHeroHealing"></a> HasScaledHeroHealing

```csharp
public bool HasScaledHeroHealing { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasScaledKills"></a> HasScaledKills

```csharp
public bool HasScaledKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasScaledMetric"></a> HasScaledMetric

```csharp
public bool HasScaledMetric { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasScaledTowerDamage"></a> HasScaledTowerDamage

```csharp
public bool HasScaledTowerDamage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasSearchRank"></a> HasSearchRank

```csharp
public bool HasSearchRank { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasSearchRankUncertainty"></a> HasSearchRankUncertainty

```csharp
public bool HasSearchRankUncertainty { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasSecondsDead"></a> HasSecondsDead

```csharp
public bool HasSecondsDead { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasSelectedFacet"></a> HasSelectedFacet

```csharp
public bool HasSelectedFacet { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasSupportAbilityValue"></a> HasSupportAbilityValue

```csharp
public bool HasSupportAbilityValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasSupportGold"></a> HasSupportGold

```csharp
public bool HasSupportGold { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasTeamNumber"></a> HasTeamNumber

```csharp
public bool HasTeamNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasTeamSlot"></a> HasTeamSlot

```csharp
public bool HasTeamSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasTimeLastSeen"></a> HasTimeLastSeen

```csharp
public bool HasTimeLastSeen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasTowerDamage"></a> HasTowerDamage

```csharp
public bool HasTowerDamage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HasXpPerMin"></a> HasXpPerMin

```csharp
public bool HasXpPerMin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HeroDamage"></a> HeroDamage

```csharp
public uint HeroDamage { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HeroDamageDealt"></a> HeroDamageDealt

```csharp
public RepeatedField<CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived> HeroDamageDealt { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[Player](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.Types.md).[HeroDamageReceived](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HeroDamageReceived"></a> HeroDamageReceived

```csharp
public RepeatedField<CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived> HeroDamageReceived { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[Player](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.Types.md).[HeroDamageReceived](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HeroHealing"></a> HeroHealing

```csharp
public uint HeroHealing { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HeroPickOrder"></a> HeroPickOrder

```csharp
public uint HeroPickOrder { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HeroPlayCount"></a> HeroPlayCount

```csharp
public uint HeroPlayCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HeroWasDotaPlusSuggestion"></a> HeroWasDotaPlusSuggestion

```csharp
public bool HeroWasDotaPlusSuggestion { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_HeroWasRandomed"></a> HeroWasRandomed

```csharp
public bool HeroWasRandomed { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item0"></a> Item0

```csharp
public int Item0 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item1"></a> Item1

```csharp
public int Item1 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item10"></a> Item10

```csharp
public int Item10 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item10Lvl"></a> Item10Lvl

```csharp
public int Item10Lvl { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item2"></a> Item2

```csharp
public int Item2 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item3"></a> Item3

```csharp
public int Item3 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item4"></a> Item4

```csharp
public int Item4 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item5"></a> Item5

```csharp
public int Item5 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item6"></a> Item6

```csharp
public int Item6 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item7"></a> Item7

```csharp
public int Item7 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item8"></a> Item8

```csharp
public int Item8 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Item9"></a> Item9

```csharp
public int Item9 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Kills"></a> Kills

```csharp
public uint Kills { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_LaneSelectionFlags"></a> LaneSelectionFlags

```csharp
public uint LaneSelectionFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_LastHits"></a> LastHits

```csharp
public uint LastHits { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_LeaverStatus"></a> LeaverStatus

```csharp
public uint LeaverStatus { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Level"></a> Level

```csharp
public uint Level { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Misses"></a> Misses

```csharp
public uint Misses { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_MmrType"></a> MmrType

```csharp
public uint MmrType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_NetWorth"></a> NetWorth

```csharp
public uint NetWorth { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_OutpostsCaptured"></a> OutpostsCaptured

```csharp
public uint OutpostsCaptured { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAMatch.Types.Player> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[Player](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_PartyId"></a> PartyId

```csharp
public ulong PartyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_PermanentBuffs"></a> PermanentBuffs

```csharp
public RepeatedField<CMatchPlayerPermanentBuff> PermanentBuffs { get; }
```

#### Property Value

 RepeatedField<[CMatchPlayerPermanentBuff](Divine.Protobufs.Dota2.CMatchPlayerPermanentBuff.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_PlayerName"></a> PlayerName

```csharp
public string PlayerName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_PlayerSlot"></a> PlayerSlot

```csharp
public uint PlayerSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_PreviousRank"></a> PreviousRank

```csharp
public uint PreviousRank { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ProName"></a> ProName

```csharp
public string ProName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_RankChange"></a> RankChange

```csharp
public int RankChange { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_RankUncertaintyChange"></a> RankUncertaintyChange

```csharp
public int RankUncertaintyChange { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_RealName"></a> RealName

```csharp
public string RealName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ScaledAssists"></a> ScaledAssists

```csharp
public float ScaledAssists { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ScaledDeaths"></a> ScaledDeaths

```csharp
public float ScaledDeaths { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ScaledHeroDamage"></a> ScaledHeroDamage

```csharp
public uint ScaledHeroDamage { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ScaledHeroHealing"></a> ScaledHeroHealing

```csharp
public uint ScaledHeroHealing { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ScaledKills"></a> ScaledKills

```csharp
public float ScaledKills { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ScaledMetric"></a> ScaledMetric

```csharp
public float ScaledMetric { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ScaledTowerDamage"></a> ScaledTowerDamage

```csharp
public uint ScaledTowerDamage { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_SearchRank"></a> SearchRank

```csharp
public uint SearchRank { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_SearchRankUncertainty"></a> SearchRankUncertainty

```csharp
public uint SearchRankUncertainty { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_SecondsDead"></a> SecondsDead

```csharp
public uint SecondsDead { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_SelectedFacet"></a> SelectedFacet

```csharp
public uint SelectedFacet { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_SupportAbilityValue"></a> SupportAbilityValue

```csharp
public uint SupportAbilityValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_SupportGold"></a> SupportGold

```csharp
public uint SupportGold { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_TeamNumber"></a> TeamNumber

```csharp
public DOTA_GC_TEAM TeamNumber { get; set; }
```

#### Property Value

 [DOTA\_GC\_TEAM](Divine.Protobufs.Dota2.DOTA\_GC\_TEAM.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_TeamSlot"></a> TeamSlot

```csharp
public uint TeamSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_TimeLastSeen"></a> TimeLastSeen

```csharp
public uint TimeLastSeen { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_TowerDamage"></a> TowerDamage

```csharp
public uint TowerDamage { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_XpPerMin"></a> XpPerMin

```csharp
public uint XpPerMin { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearActivePlusSubscription"></a> ClearActivePlusSubscription\(\)

```csharp
public void ClearActivePlusSubscription()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearAssists"></a> ClearAssists\(\)

```csharp
public void ClearAssists()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearBotDifficulty"></a> ClearBotDifficulty\(\)

```csharp
public void ClearBotDifficulty()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearBountyRunes"></a> ClearBountyRunes\(\)

```csharp
public void ClearBountyRunes()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearClaimedDenies"></a> ClearClaimedDenies\(\)

```csharp
public void ClearClaimedDenies()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearClaimedFarmGold"></a> ClearClaimedFarmGold\(\)

```csharp
public void ClearClaimedFarmGold()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearClaimedMisses"></a> ClearClaimedMisses\(\)

```csharp
public void ClearClaimedMisses()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearDeaths"></a> ClearDeaths\(\)

```csharp
public void ClearDeaths()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearDenies"></a> ClearDenies\(\)

```csharp
public void ClearDenies()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearDisableDuration"></a> ClearDisableDuration\(\)

```csharp
public void ClearDisableDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearExpectedTeamContribution"></a> ClearExpectedTeamContribution\(\)

```csharp
public void ClearExpectedTeamContribution()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearFeedingDetected"></a> ClearFeedingDetected\(\)

```csharp
public void ClearFeedingDetected()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearGold"></a> ClearGold\(\)

```csharp
public void ClearGold()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearGoldLostToDeath"></a> ClearGoldLostToDeath\(\)

```csharp
public void ClearGoldLostToDeath()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearGoldPerMin"></a> ClearGoldPerMin\(\)

```csharp
public void ClearGoldPerMin()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearGoldSpent"></a> ClearGoldSpent\(\)

```csharp
public void ClearGoldSpent()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearHeroDamage"></a> ClearHeroDamage\(\)

```csharp
public void ClearHeroDamage()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearHeroHealing"></a> ClearHeroHealing\(\)

```csharp
public void ClearHeroHealing()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearHeroPickOrder"></a> ClearHeroPickOrder\(\)

```csharp
public void ClearHeroPickOrder()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearHeroPlayCount"></a> ClearHeroPlayCount\(\)

```csharp
public void ClearHeroPlayCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearHeroWasDotaPlusSuggestion"></a> ClearHeroWasDotaPlusSuggestion\(\)

```csharp
public void ClearHeroWasDotaPlusSuggestion()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearHeroWasRandomed"></a> ClearHeroWasRandomed\(\)

```csharp
public void ClearHeroWasRandomed()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearItem0"></a> ClearItem0\(\)

```csharp
public void ClearItem0()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearItem1"></a> ClearItem1\(\)

```csharp
public void ClearItem1()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearItem10"></a> ClearItem10\(\)

```csharp
public void ClearItem10()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearItem10Lvl"></a> ClearItem10Lvl\(\)

```csharp
public void ClearItem10Lvl()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearItem2"></a> ClearItem2\(\)

```csharp
public void ClearItem2()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearItem3"></a> ClearItem3\(\)

```csharp
public void ClearItem3()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearItem4"></a> ClearItem4\(\)

```csharp
public void ClearItem4()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearItem5"></a> ClearItem5\(\)

```csharp
public void ClearItem5()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearItem6"></a> ClearItem6\(\)

```csharp
public void ClearItem6()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearItem7"></a> ClearItem7\(\)

```csharp
public void ClearItem7()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearItem8"></a> ClearItem8\(\)

```csharp
public void ClearItem8()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearItem9"></a> ClearItem9\(\)

```csharp
public void ClearItem9()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearKills"></a> ClearKills\(\)

```csharp
public void ClearKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearLaneSelectionFlags"></a> ClearLaneSelectionFlags\(\)

```csharp
public void ClearLaneSelectionFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearLastHits"></a> ClearLastHits\(\)

```csharp
public void ClearLastHits()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearLeaverStatus"></a> ClearLeaverStatus\(\)

```csharp
public void ClearLeaverStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearLevel"></a> ClearLevel\(\)

```csharp
public void ClearLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearMisses"></a> ClearMisses\(\)

```csharp
public void ClearMisses()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearMmrType"></a> ClearMmrType\(\)

```csharp
public void ClearMmrType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearNetWorth"></a> ClearNetWorth\(\)

```csharp
public void ClearNetWorth()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearOutpostsCaptured"></a> ClearOutpostsCaptured\(\)

```csharp
public void ClearOutpostsCaptured()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearPartyId"></a> ClearPartyId\(\)

```csharp
public void ClearPartyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearPlayerName"></a> ClearPlayerName\(\)

```csharp
public void ClearPlayerName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearPlayerSlot"></a> ClearPlayerSlot\(\)

```csharp
public void ClearPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearPreviousRank"></a> ClearPreviousRank\(\)

```csharp
public void ClearPreviousRank()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearProName"></a> ClearProName\(\)

```csharp
public void ClearProName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearRankChange"></a> ClearRankChange\(\)

```csharp
public void ClearRankChange()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearRankUncertaintyChange"></a> ClearRankUncertaintyChange\(\)

```csharp
public void ClearRankUncertaintyChange()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearRealName"></a> ClearRealName\(\)

```csharp
public void ClearRealName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearScaledAssists"></a> ClearScaledAssists\(\)

```csharp
public void ClearScaledAssists()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearScaledDeaths"></a> ClearScaledDeaths\(\)

```csharp
public void ClearScaledDeaths()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearScaledHeroDamage"></a> ClearScaledHeroDamage\(\)

```csharp
public void ClearScaledHeroDamage()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearScaledHeroHealing"></a> ClearScaledHeroHealing\(\)

```csharp
public void ClearScaledHeroHealing()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearScaledKills"></a> ClearScaledKills\(\)

```csharp
public void ClearScaledKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearScaledMetric"></a> ClearScaledMetric\(\)

```csharp
public void ClearScaledMetric()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearScaledTowerDamage"></a> ClearScaledTowerDamage\(\)

```csharp
public void ClearScaledTowerDamage()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearSearchRank"></a> ClearSearchRank\(\)

```csharp
public void ClearSearchRank()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearSearchRankUncertainty"></a> ClearSearchRankUncertainty\(\)

```csharp
public void ClearSearchRankUncertainty()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearSecondsDead"></a> ClearSecondsDead\(\)

```csharp
public void ClearSecondsDead()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearSelectedFacet"></a> ClearSelectedFacet\(\)

```csharp
public void ClearSelectedFacet()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearSupportAbilityValue"></a> ClearSupportAbilityValue\(\)

```csharp
public void ClearSupportAbilityValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearSupportGold"></a> ClearSupportGold\(\)

```csharp
public void ClearSupportGold()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearTeamNumber"></a> ClearTeamNumber\(\)

```csharp
public void ClearTeamNumber()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearTeamSlot"></a> ClearTeamSlot\(\)

```csharp
public void ClearTeamSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearTimeLastSeen"></a> ClearTimeLastSeen\(\)

```csharp
public void ClearTimeLastSeen()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearTowerDamage"></a> ClearTowerDamage\(\)

```csharp
public void ClearTowerDamage()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ClearXpPerMin"></a> ClearXpPerMin\(\)

```csharp
public void ClearXpPerMin()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAMatch.Types.Player Clone()
```

#### Returns

 [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[Player](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Equals_Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_"></a> Equals\(Player\)

```csharp
public bool Equals(CMsgDOTAMatch.Types.Player other)
```

#### Parameters

`other` [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[Player](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_"></a> MergeFrom\(Player\)

```csharp
public void MergeFrom(CMsgDOTAMatch.Types.Player other)
```

#### Parameters

`other` [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[Player](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

