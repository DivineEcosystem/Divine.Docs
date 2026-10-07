# <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry"></a> Class CMsgDOTACombatLogEntry

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTACombatLogEntry : IMessage<CMsgDOTACombatLogEntry>, IEquatable<CMsgDOTACombatLogEntry>, IDeepCloneable<CMsgDOTACombatLogEntry>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTACombatLogEntry](Divine.Protobufs.Dota2.CMsgDOTACombatLogEntry.md)

#### Implements

IMessage<CMsgDOTACombatLogEntry\>, 
[IEquatable<CMsgDOTACombatLogEntry\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTACombatLogEntry\>, 
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
[EnumerableExtensions.In<CMsgDOTACombatLogEntry\>\(CMsgDOTACombatLogEntry, params CMsgDOTACombatLogEntry\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry__ctor"></a> CMsgDOTACombatLogEntry\(\)

```csharp
public CMsgDOTACombatLogEntry()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry__ctor_Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_"></a> CMsgDOTACombatLogEntry\(CMsgDOTACombatLogEntry\)

```csharp
public CMsgDOTACombatLogEntry(CMsgDOTACombatLogEntry other)
```

#### Parameters

`other` [CMsgDOTACombatLogEntry](Divine.Protobufs.Dota2.CMsgDOTACombatLogEntry.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AbilityLevelFieldNumber"></a> AbilityLevelFieldNumber

```csharp
public const int AbilityLevelFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ArmorDebuffModifierFieldNumber"></a> ArmorDebuffModifierFieldNumber

```csharp
public const int ArmorDebuffModifierFieldNumber = 66
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AssistPlayer0FieldNumber"></a> AssistPlayer0FieldNumber

```csharp
public const int AssistPlayer0FieldNumber = 31
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AssistPlayer1FieldNumber"></a> AssistPlayer1FieldNumber

```csharp
public const int AssistPlayer1FieldNumber = 32
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AssistPlayer2FieldNumber"></a> AssistPlayer2FieldNumber

```csharp
public const int AssistPlayer2FieldNumber = 33
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AssistPlayer3FieldNumber"></a> AssistPlayer3FieldNumber

```csharp
public const int AssistPlayer3FieldNumber = 34
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AssistPlayersFieldNumber"></a> AssistPlayersFieldNumber

```csharp
public const int AssistPlayersFieldNumber = 40
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AtNightTimeFieldNumber"></a> AtNightTimeFieldNumber

```csharp
public const int AtNightTimeFieldNumber = 74
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AttackerHasScepterFieldNumber"></a> AttackerHasScepterFieldNumber

```csharp
public const int AttackerHasScepterFieldNumber = 75
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AttackerHeroLevelFieldNumber"></a> AttackerHeroLevelFieldNumber

```csharp
public const int AttackerHeroLevelFieldNumber = 43
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AttackerNameFieldNumber"></a> AttackerNameFieldNumber

```csharp
public const int AttackerNameFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AttackerTeamFieldNumber"></a> AttackerTeamFieldNumber

```csharp
public const int AttackerTeamFieldNumber = 28
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AuraModifierFieldNumber"></a> AuraModifierFieldNumber

```csharp
public const int AuraModifierFieldNumber = 65
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_BuildingTypeFieldNumber"></a> BuildingTypeFieldNumber

```csharp
public const int BuildingTypeFieldNumber = 53
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_DamageCategoryFieldNumber"></a> DamageCategoryFieldNumber

```csharp
public const int DamageCategoryFieldNumber = 51
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_DamageSourceNameFieldNumber"></a> DamageSourceNameFieldNumber

```csharp
public const int DamageSourceNameFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_DamageTypeFieldNumber"></a> DamageTypeFieldNumber

```csharp
public const int DamageTypeFieldNumber = 49
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_EventLocationFieldNumber"></a> EventLocationFieldNumber

```csharp
public const int EventLocationFieldNumber = 47
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_GoldReasonFieldNumber"></a> GoldReasonFieldNumber

```csharp
public const int GoldReasonFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_GpmFieldNumber"></a> GpmFieldNumber

```csharp
public const int GpmFieldNumber = 46
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HealFromLifestealFieldNumber"></a> HealFromLifestealFieldNumber

```csharp
public const int HealFromLifestealFieldNumber = 56
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HealFromRegenFieldNumber"></a> HealFromRegenFieldNumber

```csharp
public const int HealFromRegenFieldNumber = 82
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HealthFieldNumber"></a> HealthFieldNumber

```csharp
public const int HealthFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HiddenModifierFieldNumber"></a> HiddenModifierFieldNumber

```csharp
public const int HiddenModifierFieldNumber = 36
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_InflictorIsStolenAbilityFieldNumber"></a> InflictorIsStolenAbilityFieldNumber

```csharp
public const int InflictorIsStolenAbilityFieldNumber = 70
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_InflictorNameFieldNumber"></a> InflictorNameFieldNumber

```csharp
public const int InflictorNameFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_InvisibilityModifierFieldNumber"></a> InvisibilityModifierFieldNumber

```csharp
public const int InvisibilityModifierFieldNumber = 50
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsAbilityToggleOffFieldNumber"></a> IsAbilityToggleOffFieldNumber

```csharp
public const int IsAbilityToggleOffFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsAbilityToggleOnFieldNumber"></a> IsAbilityToggleOnFieldNumber

```csharp
public const int IsAbilityToggleOnFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsAttackerHeroFieldNumber"></a> IsAttackerHeroFieldNumber

```csharp
public const int IsAttackerHeroFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsAttackerIllusionFieldNumber"></a> IsAttackerIllusionFieldNumber

```csharp
public const int IsAttackerIllusionFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsHealSaveFieldNumber"></a> IsHealSaveFieldNumber

```csharp
public const int IsHealSaveFieldNumber = 41
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsTargetBuildingFieldNumber"></a> IsTargetBuildingFieldNumber

```csharp
public const int IsTargetBuildingFieldNumber = 37
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsTargetHeroFieldNumber"></a> IsTargetHeroFieldNumber

```csharp
public const int IsTargetHeroFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsTargetIllusionFieldNumber"></a> IsTargetIllusionFieldNumber

```csharp
public const int IsTargetIllusionFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsUltimateAbilityFieldNumber"></a> IsUltimateAbilityFieldNumber

```csharp
public const int IsUltimateAbilityFieldNumber = 42
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsVisibleDireFieldNumber"></a> IsVisibleDireFieldNumber

```csharp
public const int IsVisibleDireFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsVisibleRadiantFieldNumber"></a> IsVisibleRadiantFieldNumber

```csharp
public const int IsVisibleRadiantFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_KillEaterEventFieldNumber"></a> KillEaterEventFieldNumber

```csharp
public const int KillEaterEventFieldNumber = 71
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_LastHitsFieldNumber"></a> LastHitsFieldNumber

```csharp
public const int LastHitsFieldNumber = 27
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_LocationXFieldNumber"></a> LocationXFieldNumber

```csharp
public const int LocationXFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_LocationYFieldNumber"></a> LocationYFieldNumber

```csharp
public const int LocationYFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_LongRangeKillFieldNumber"></a> LongRangeKillFieldNumber

```csharp
public const int LongRangeKillFieldNumber = 60
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ModifierAbilityFieldNumber"></a> ModifierAbilityFieldNumber

```csharp
public const int ModifierAbilityFieldNumber = 68
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ModifierDurationFieldNumber"></a> ModifierDurationFieldNumber

```csharp
public const int ModifierDurationFieldNumber = 25
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ModifierElapsedDurationFieldNumber"></a> ModifierElapsedDurationFieldNumber

```csharp
public const int ModifierElapsedDurationFieldNumber = 54
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ModifierHiddenFieldNumber"></a> ModifierHiddenFieldNumber

```csharp
public const int ModifierHiddenFieldNumber = 69
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ModifierPurgeAbilityFieldNumber"></a> ModifierPurgeAbilityFieldNumber

```csharp
public const int ModifierPurgeAbilityFieldNumber = 61
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ModifierPurgedDurationFieldNumber"></a> ModifierPurgedDurationFieldNumber

```csharp
public const int ModifierPurgedDurationFieldNumber = 81
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ModifierPurgedFieldNumber"></a> ModifierPurgedFieldNumber

```csharp
public const int ModifierPurgedFieldNumber = 57
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ModifierPurgeNpcFieldNumber"></a> ModifierPurgeNpcFieldNumber

```csharp
public const int ModifierPurgeNpcFieldNumber = 62
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_MotionControllerModifierFieldNumber"></a> MotionControllerModifierFieldNumber

```csharp
public const int MotionControllerModifierFieldNumber = 59
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_NetworthFieldNumber"></a> NetworthFieldNumber

```csharp
public const int NetworthFieldNumber = 52
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_NeutralCampTeamFieldNumber"></a> NeutralCampTeamFieldNumber

```csharp
public const int NeutralCampTeamFieldNumber = 76
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_NeutralCampTypeFieldNumber"></a> NeutralCampTypeFieldNumber

```csharp
public const int NeutralCampTypeFieldNumber = 38
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_NoPhysicalDamageModifierFieldNumber"></a> NoPhysicalDamageModifierFieldNumber

```csharp
public const int NoPhysicalDamageModifierFieldNumber = 67
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ObsWardsPlacedFieldNumber"></a> ObsWardsPlacedFieldNumber

```csharp
public const int ObsWardsPlacedFieldNumber = 30
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_RegeneratedHealthFieldNumber"></a> RegeneratedHealthFieldNumber

```csharp
public const int RegeneratedHealthFieldNumber = 77
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_RootModifierFieldNumber"></a> RootModifierFieldNumber

```csharp
public const int RootModifierFieldNumber = 63
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_RuneTypeFieldNumber"></a> RuneTypeFieldNumber

```csharp
public const int RuneTypeFieldNumber = 39
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_SilenceModifierFieldNumber"></a> SilenceModifierFieldNumber

```csharp
public const int SilenceModifierFieldNumber = 55
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_SlowDurationFieldNumber"></a> SlowDurationFieldNumber

```csharp
public const int SlowDurationFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_SpellEvadedFieldNumber"></a> SpellEvadedFieldNumber

```csharp
public const int SpellEvadedFieldNumber = 58
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_SpellGeneratedAttackFieldNumber"></a> SpellGeneratedAttackFieldNumber

```csharp
public const int SpellGeneratedAttackFieldNumber = 73
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_StackCountFieldNumber"></a> StackCountFieldNumber

```csharp
public const int StackCountFieldNumber = 35
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_StunDurationFieldNumber"></a> StunDurationFieldNumber

```csharp
public const int StunDurationFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_TargetHeroLevelFieldNumber"></a> TargetHeroLevelFieldNumber

```csharp
public const int TargetHeroLevelFieldNumber = 44
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_TargetIsSelfFieldNumber"></a> TargetIsSelfFieldNumber

```csharp
public const int TargetIsSelfFieldNumber = 48
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_TargetNameFieldNumber"></a> TargetNameFieldNumber

```csharp
public const int TargetNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_TargetSourceNameFieldNumber"></a> TargetSourceNameFieldNumber

```csharp
public const int TargetSourceNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_TargetTeamFieldNumber"></a> TargetTeamFieldNumber

```csharp
public const int TargetTeamFieldNumber = 29
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_TimestampRawFieldNumber"></a> TimestampRawFieldNumber

```csharp
public const int TimestampRawFieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_TotalUnitDeathCountFieldNumber"></a> TotalUnitDeathCountFieldNumber

```csharp
public const int TotalUnitDeathCountFieldNumber = 64
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_TrackedStatIdFieldNumber"></a> TrackedStatIdFieldNumber

```csharp
public const int TrackedStatIdFieldNumber = 80
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_UnitStatusLabelFieldNumber"></a> UnitStatusLabelFieldNumber

```csharp
public const int UnitStatusLabelFieldNumber = 72
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_UsesChargesFieldNumber"></a> UsesChargesFieldNumber

```csharp
public const int UsesChargesFieldNumber = 79
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_WillReincarnateFieldNumber"></a> WillReincarnateFieldNumber

```csharp
public const int WillReincarnateFieldNumber = 78
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_XpmFieldNumber"></a> XpmFieldNumber

```csharp
public const int XpmFieldNumber = 45
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_XpReasonFieldNumber"></a> XpReasonFieldNumber

```csharp
public const int XpReasonFieldNumber = 26
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AbilityLevel"></a> AbilityLevel

```csharp
public uint AbilityLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ArmorDebuffModifier"></a> ArmorDebuffModifier

```csharp
public bool ArmorDebuffModifier { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AssistPlayer0"></a> AssistPlayer0

```csharp
public uint AssistPlayer0 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AssistPlayer1"></a> AssistPlayer1

```csharp
public uint AssistPlayer1 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AssistPlayer2"></a> AssistPlayer2

```csharp
public uint AssistPlayer2 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AssistPlayer3"></a> AssistPlayer3

```csharp
public uint AssistPlayer3 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AssistPlayers"></a> AssistPlayers

```csharp
public RepeatedField<int> AssistPlayers { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AtNightTime"></a> AtNightTime

```csharp
public bool AtNightTime { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AttackerHasScepter"></a> AttackerHasScepter

```csharp
public bool AttackerHasScepter { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AttackerHeroLevel"></a> AttackerHeroLevel

```csharp
public uint AttackerHeroLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AttackerName"></a> AttackerName

```csharp
public uint AttackerName { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AttackerTeam"></a> AttackerTeam

```csharp
public uint AttackerTeam { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_AuraModifier"></a> AuraModifier

```csharp
public bool AuraModifier { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_BuildingType"></a> BuildingType

```csharp
public uint BuildingType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_DamageCategory"></a> DamageCategory

```csharp
public uint DamageCategory { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_DamageSourceName"></a> DamageSourceName

```csharp
public uint DamageSourceName { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_DamageType"></a> DamageType

```csharp
public uint DamageType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_EventLocation"></a> EventLocation

```csharp
public uint EventLocation { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_GoldReason"></a> GoldReason

```csharp
public uint GoldReason { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_Gpm"></a> Gpm

```csharp
public uint Gpm { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasAbilityLevel"></a> HasAbilityLevel

```csharp
public bool HasAbilityLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasArmorDebuffModifier"></a> HasArmorDebuffModifier

```csharp
public bool HasArmorDebuffModifier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasAssistPlayer0"></a> HasAssistPlayer0

```csharp
public bool HasAssistPlayer0 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasAssistPlayer1"></a> HasAssistPlayer1

```csharp
public bool HasAssistPlayer1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasAssistPlayer2"></a> HasAssistPlayer2

```csharp
public bool HasAssistPlayer2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasAssistPlayer3"></a> HasAssistPlayer3

```csharp
public bool HasAssistPlayer3 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasAtNightTime"></a> HasAtNightTime

```csharp
public bool HasAtNightTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasAttackerHasScepter"></a> HasAttackerHasScepter

```csharp
public bool HasAttackerHasScepter { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasAttackerHeroLevel"></a> HasAttackerHeroLevel

```csharp
public bool HasAttackerHeroLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasAttackerName"></a> HasAttackerName

```csharp
public bool HasAttackerName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasAttackerTeam"></a> HasAttackerTeam

```csharp
public bool HasAttackerTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasAuraModifier"></a> HasAuraModifier

```csharp
public bool HasAuraModifier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasBuildingType"></a> HasBuildingType

```csharp
public bool HasBuildingType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasDamageCategory"></a> HasDamageCategory

```csharp
public bool HasDamageCategory { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasDamageSourceName"></a> HasDamageSourceName

```csharp
public bool HasDamageSourceName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasDamageType"></a> HasDamageType

```csharp
public bool HasDamageType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasEventLocation"></a> HasEventLocation

```csharp
public bool HasEventLocation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasGoldReason"></a> HasGoldReason

```csharp
public bool HasGoldReason { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasGpm"></a> HasGpm

```csharp
public bool HasGpm { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasHealFromLifesteal"></a> HasHealFromLifesteal

```csharp
public bool HasHealFromLifesteal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasHealFromRegen"></a> HasHealFromRegen

```csharp
public bool HasHealFromRegen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasHealth"></a> HasHealth

```csharp
public bool HasHealth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasHiddenModifier"></a> HasHiddenModifier

```csharp
public bool HasHiddenModifier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasInflictorIsStolenAbility"></a> HasInflictorIsStolenAbility

```csharp
public bool HasInflictorIsStolenAbility { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasInflictorName"></a> HasInflictorName

```csharp
public bool HasInflictorName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasInvisibilityModifier"></a> HasInvisibilityModifier

```csharp
public bool HasInvisibilityModifier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasIsAbilityToggleOff"></a> HasIsAbilityToggleOff

```csharp
public bool HasIsAbilityToggleOff { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasIsAbilityToggleOn"></a> HasIsAbilityToggleOn

```csharp
public bool HasIsAbilityToggleOn { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasIsAttackerHero"></a> HasIsAttackerHero

```csharp
public bool HasIsAttackerHero { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasIsAttackerIllusion"></a> HasIsAttackerIllusion

```csharp
public bool HasIsAttackerIllusion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasIsHealSave"></a> HasIsHealSave

```csharp
public bool HasIsHealSave { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasIsTargetBuilding"></a> HasIsTargetBuilding

```csharp
public bool HasIsTargetBuilding { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasIsTargetHero"></a> HasIsTargetHero

```csharp
public bool HasIsTargetHero { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasIsTargetIllusion"></a> HasIsTargetIllusion

```csharp
public bool HasIsTargetIllusion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasIsUltimateAbility"></a> HasIsUltimateAbility

```csharp
public bool HasIsUltimateAbility { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasIsVisibleDire"></a> HasIsVisibleDire

```csharp
public bool HasIsVisibleDire { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasIsVisibleRadiant"></a> HasIsVisibleRadiant

```csharp
public bool HasIsVisibleRadiant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasKillEaterEvent"></a> HasKillEaterEvent

```csharp
public bool HasKillEaterEvent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasLastHits"></a> HasLastHits

```csharp
public bool HasLastHits { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasLocationX"></a> HasLocationX

```csharp
public bool HasLocationX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasLocationY"></a> HasLocationY

```csharp
public bool HasLocationY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasLongRangeKill"></a> HasLongRangeKill

```csharp
public bool HasLongRangeKill { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasModifierAbility"></a> HasModifierAbility

```csharp
public bool HasModifierAbility { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasModifierDuration"></a> HasModifierDuration

```csharp
public bool HasModifierDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasModifierElapsedDuration"></a> HasModifierElapsedDuration

```csharp
public bool HasModifierElapsedDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasModifierHidden"></a> HasModifierHidden

```csharp
public bool HasModifierHidden { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasModifierPurgeAbility"></a> HasModifierPurgeAbility

```csharp
public bool HasModifierPurgeAbility { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasModifierPurged"></a> HasModifierPurged

```csharp
public bool HasModifierPurged { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasModifierPurgedDuration"></a> HasModifierPurgedDuration

```csharp
public bool HasModifierPurgedDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasModifierPurgeNpc"></a> HasModifierPurgeNpc

```csharp
public bool HasModifierPurgeNpc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasMotionControllerModifier"></a> HasMotionControllerModifier

```csharp
public bool HasMotionControllerModifier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasNetworth"></a> HasNetworth

```csharp
public bool HasNetworth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasNeutralCampTeam"></a> HasNeutralCampTeam

```csharp
public bool HasNeutralCampTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasNeutralCampType"></a> HasNeutralCampType

```csharp
public bool HasNeutralCampType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasNoPhysicalDamageModifier"></a> HasNoPhysicalDamageModifier

```csharp
public bool HasNoPhysicalDamageModifier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasObsWardsPlaced"></a> HasObsWardsPlaced

```csharp
public bool HasObsWardsPlaced { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasRegeneratedHealth"></a> HasRegeneratedHealth

```csharp
public bool HasRegeneratedHealth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasRootModifier"></a> HasRootModifier

```csharp
public bool HasRootModifier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasRuneType"></a> HasRuneType

```csharp
public bool HasRuneType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasSilenceModifier"></a> HasSilenceModifier

```csharp
public bool HasSilenceModifier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasSlowDuration"></a> HasSlowDuration

```csharp
public bool HasSlowDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasSpellEvaded"></a> HasSpellEvaded

```csharp
public bool HasSpellEvaded { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasSpellGeneratedAttack"></a> HasSpellGeneratedAttack

```csharp
public bool HasSpellGeneratedAttack { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasStackCount"></a> HasStackCount

```csharp
public bool HasStackCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasStunDuration"></a> HasStunDuration

```csharp
public bool HasStunDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasTargetHeroLevel"></a> HasTargetHeroLevel

```csharp
public bool HasTargetHeroLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasTargetIsSelf"></a> HasTargetIsSelf

```csharp
public bool HasTargetIsSelf { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasTargetName"></a> HasTargetName

```csharp
public bool HasTargetName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasTargetSourceName"></a> HasTargetSourceName

```csharp
public bool HasTargetSourceName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasTargetTeam"></a> HasTargetTeam

```csharp
public bool HasTargetTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasTimestampRaw"></a> HasTimestampRaw

```csharp
public bool HasTimestampRaw { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasTotalUnitDeathCount"></a> HasTotalUnitDeathCount

```csharp
public bool HasTotalUnitDeathCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasTrackedStatId"></a> HasTrackedStatId

```csharp
public bool HasTrackedStatId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasUnitStatusLabel"></a> HasUnitStatusLabel

```csharp
public bool HasUnitStatusLabel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasUsesCharges"></a> HasUsesCharges

```csharp
public bool HasUsesCharges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasWillReincarnate"></a> HasWillReincarnate

```csharp
public bool HasWillReincarnate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasXpm"></a> HasXpm

```csharp
public bool HasXpm { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HasXpReason"></a> HasXpReason

```csharp
public bool HasXpReason { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HealFromLifesteal"></a> HealFromLifesteal

```csharp
public bool HealFromLifesteal { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HealFromRegen"></a> HealFromRegen

```csharp
public bool HealFromRegen { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_Health"></a> Health

```csharp
public int Health { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_HiddenModifier"></a> HiddenModifier

```csharp
public bool HiddenModifier { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_InflictorIsStolenAbility"></a> InflictorIsStolenAbility

```csharp
public bool InflictorIsStolenAbility { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_InflictorName"></a> InflictorName

```csharp
public uint InflictorName { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_InvisibilityModifier"></a> InvisibilityModifier

```csharp
public bool InvisibilityModifier { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsAbilityToggleOff"></a> IsAbilityToggleOff

```csharp
public bool IsAbilityToggleOff { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsAbilityToggleOn"></a> IsAbilityToggleOn

```csharp
public bool IsAbilityToggleOn { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsAttackerHero"></a> IsAttackerHero

```csharp
public bool IsAttackerHero { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsAttackerIllusion"></a> IsAttackerIllusion

```csharp
public bool IsAttackerIllusion { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsHealSave"></a> IsHealSave

```csharp
public bool IsHealSave { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsTargetBuilding"></a> IsTargetBuilding

```csharp
public bool IsTargetBuilding { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsTargetHero"></a> IsTargetHero

```csharp
public bool IsTargetHero { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsTargetIllusion"></a> IsTargetIllusion

```csharp
public bool IsTargetIllusion { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsUltimateAbility"></a> IsUltimateAbility

```csharp
public bool IsUltimateAbility { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsVisibleDire"></a> IsVisibleDire

```csharp
public bool IsVisibleDire { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_IsVisibleRadiant"></a> IsVisibleRadiant

```csharp
public bool IsVisibleRadiant { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_KillEaterEvent"></a> KillEaterEvent

```csharp
public uint KillEaterEvent { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_LastHits"></a> LastHits

```csharp
public uint LastHits { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_LocationX"></a> LocationX

```csharp
public float LocationX { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_LocationY"></a> LocationY

```csharp
public float LocationY { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_LongRangeKill"></a> LongRangeKill

```csharp
public bool LongRangeKill { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ModifierAbility"></a> ModifierAbility

```csharp
public uint ModifierAbility { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ModifierDuration"></a> ModifierDuration

```csharp
public float ModifierDuration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ModifierElapsedDuration"></a> ModifierElapsedDuration

```csharp
public float ModifierElapsedDuration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ModifierHidden"></a> ModifierHidden

```csharp
public bool ModifierHidden { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ModifierPurgeAbility"></a> ModifierPurgeAbility

```csharp
public uint ModifierPurgeAbility { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ModifierPurged"></a> ModifierPurged

```csharp
public bool ModifierPurged { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ModifierPurgedDuration"></a> ModifierPurgedDuration

```csharp
public float ModifierPurgedDuration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ModifierPurgeNpc"></a> ModifierPurgeNpc

```csharp
public uint ModifierPurgeNpc { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_MotionControllerModifier"></a> MotionControllerModifier

```csharp
public bool MotionControllerModifier { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_Networth"></a> Networth

```csharp
public uint Networth { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_NeutralCampTeam"></a> NeutralCampTeam

```csharp
public uint NeutralCampTeam { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_NeutralCampType"></a> NeutralCampType

```csharp
public uint NeutralCampType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_NoPhysicalDamageModifier"></a> NoPhysicalDamageModifier

```csharp
public bool NoPhysicalDamageModifier { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ObsWardsPlaced"></a> ObsWardsPlaced

```csharp
public uint ObsWardsPlaced { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTACombatLogEntry> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTACombatLogEntry](Divine.Protobufs.Dota2.CMsgDOTACombatLogEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_RegeneratedHealth"></a> RegeneratedHealth

```csharp
public float RegeneratedHealth { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_RootModifier"></a> RootModifier

```csharp
public bool RootModifier { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_RuneType"></a> RuneType

```csharp
public uint RuneType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_SilenceModifier"></a> SilenceModifier

```csharp
public bool SilenceModifier { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_SlowDuration"></a> SlowDuration

```csharp
public float SlowDuration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_SpellEvaded"></a> SpellEvaded

```csharp
public bool SpellEvaded { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_SpellGeneratedAttack"></a> SpellGeneratedAttack

```csharp
public bool SpellGeneratedAttack { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_StackCount"></a> StackCount

```csharp
public uint StackCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_StunDuration"></a> StunDuration

```csharp
public float StunDuration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_TargetHeroLevel"></a> TargetHeroLevel

```csharp
public uint TargetHeroLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_TargetIsSelf"></a> TargetIsSelf

```csharp
public bool TargetIsSelf { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_TargetName"></a> TargetName

```csharp
public uint TargetName { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_TargetSourceName"></a> TargetSourceName

```csharp
public uint TargetSourceName { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_TargetTeam"></a> TargetTeam

```csharp
public uint TargetTeam { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_Timestamp"></a> Timestamp

```csharp
public float Timestamp { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_TimestampRaw"></a> TimestampRaw

```csharp
public float TimestampRaw { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_TotalUnitDeathCount"></a> TotalUnitDeathCount

```csharp
public uint TotalUnitDeathCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_TrackedStatId"></a> TrackedStatId

```csharp
public uint TrackedStatId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_Type"></a> Type

```csharp
public DOTA_COMBATLOG_TYPES Type { get; set; }
```

#### Property Value

 [DOTA\_COMBATLOG\_TYPES](Divine.Protobufs.Dota2.DOTA\_COMBATLOG\_TYPES.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_UnitStatusLabel"></a> UnitStatusLabel

```csharp
public uint UnitStatusLabel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_UsesCharges"></a> UsesCharges

```csharp
public bool UsesCharges { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_Value"></a> Value

```csharp
public uint Value { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_WillReincarnate"></a> WillReincarnate

```csharp
public bool WillReincarnate { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_Xpm"></a> Xpm

```csharp
public uint Xpm { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_XpReason"></a> XpReason

```csharp
public uint XpReason { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearAbilityLevel"></a> ClearAbilityLevel\(\)

```csharp
public void ClearAbilityLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearArmorDebuffModifier"></a> ClearArmorDebuffModifier\(\)

```csharp
public void ClearArmorDebuffModifier()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearAssistPlayer0"></a> ClearAssistPlayer0\(\)

```csharp
public void ClearAssistPlayer0()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearAssistPlayer1"></a> ClearAssistPlayer1\(\)

```csharp
public void ClearAssistPlayer1()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearAssistPlayer2"></a> ClearAssistPlayer2\(\)

```csharp
public void ClearAssistPlayer2()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearAssistPlayer3"></a> ClearAssistPlayer3\(\)

```csharp
public void ClearAssistPlayer3()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearAtNightTime"></a> ClearAtNightTime\(\)

```csharp
public void ClearAtNightTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearAttackerHasScepter"></a> ClearAttackerHasScepter\(\)

```csharp
public void ClearAttackerHasScepter()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearAttackerHeroLevel"></a> ClearAttackerHeroLevel\(\)

```csharp
public void ClearAttackerHeroLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearAttackerName"></a> ClearAttackerName\(\)

```csharp
public void ClearAttackerName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearAttackerTeam"></a> ClearAttackerTeam\(\)

```csharp
public void ClearAttackerTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearAuraModifier"></a> ClearAuraModifier\(\)

```csharp
public void ClearAuraModifier()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearBuildingType"></a> ClearBuildingType\(\)

```csharp
public void ClearBuildingType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearDamageCategory"></a> ClearDamageCategory\(\)

```csharp
public void ClearDamageCategory()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearDamageSourceName"></a> ClearDamageSourceName\(\)

```csharp
public void ClearDamageSourceName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearDamageType"></a> ClearDamageType\(\)

```csharp
public void ClearDamageType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearEventLocation"></a> ClearEventLocation\(\)

```csharp
public void ClearEventLocation()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearGoldReason"></a> ClearGoldReason\(\)

```csharp
public void ClearGoldReason()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearGpm"></a> ClearGpm\(\)

```csharp
public void ClearGpm()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearHealFromLifesteal"></a> ClearHealFromLifesteal\(\)

```csharp
public void ClearHealFromLifesteal()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearHealFromRegen"></a> ClearHealFromRegen\(\)

```csharp
public void ClearHealFromRegen()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearHealth"></a> ClearHealth\(\)

```csharp
public void ClearHealth()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearHiddenModifier"></a> ClearHiddenModifier\(\)

```csharp
public void ClearHiddenModifier()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearInflictorIsStolenAbility"></a> ClearInflictorIsStolenAbility\(\)

```csharp
public void ClearInflictorIsStolenAbility()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearInflictorName"></a> ClearInflictorName\(\)

```csharp
public void ClearInflictorName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearInvisibilityModifier"></a> ClearInvisibilityModifier\(\)

```csharp
public void ClearInvisibilityModifier()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearIsAbilityToggleOff"></a> ClearIsAbilityToggleOff\(\)

```csharp
public void ClearIsAbilityToggleOff()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearIsAbilityToggleOn"></a> ClearIsAbilityToggleOn\(\)

```csharp
public void ClearIsAbilityToggleOn()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearIsAttackerHero"></a> ClearIsAttackerHero\(\)

```csharp
public void ClearIsAttackerHero()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearIsAttackerIllusion"></a> ClearIsAttackerIllusion\(\)

```csharp
public void ClearIsAttackerIllusion()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearIsHealSave"></a> ClearIsHealSave\(\)

```csharp
public void ClearIsHealSave()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearIsTargetBuilding"></a> ClearIsTargetBuilding\(\)

```csharp
public void ClearIsTargetBuilding()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearIsTargetHero"></a> ClearIsTargetHero\(\)

```csharp
public void ClearIsTargetHero()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearIsTargetIllusion"></a> ClearIsTargetIllusion\(\)

```csharp
public void ClearIsTargetIllusion()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearIsUltimateAbility"></a> ClearIsUltimateAbility\(\)

```csharp
public void ClearIsUltimateAbility()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearIsVisibleDire"></a> ClearIsVisibleDire\(\)

```csharp
public void ClearIsVisibleDire()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearIsVisibleRadiant"></a> ClearIsVisibleRadiant\(\)

```csharp
public void ClearIsVisibleRadiant()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearKillEaterEvent"></a> ClearKillEaterEvent\(\)

```csharp
public void ClearKillEaterEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearLastHits"></a> ClearLastHits\(\)

```csharp
public void ClearLastHits()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearLocationX"></a> ClearLocationX\(\)

```csharp
public void ClearLocationX()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearLocationY"></a> ClearLocationY\(\)

```csharp
public void ClearLocationY()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearLongRangeKill"></a> ClearLongRangeKill\(\)

```csharp
public void ClearLongRangeKill()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearModifierAbility"></a> ClearModifierAbility\(\)

```csharp
public void ClearModifierAbility()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearModifierDuration"></a> ClearModifierDuration\(\)

```csharp
public void ClearModifierDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearModifierElapsedDuration"></a> ClearModifierElapsedDuration\(\)

```csharp
public void ClearModifierElapsedDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearModifierHidden"></a> ClearModifierHidden\(\)

```csharp
public void ClearModifierHidden()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearModifierPurgeAbility"></a> ClearModifierPurgeAbility\(\)

```csharp
public void ClearModifierPurgeAbility()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearModifierPurged"></a> ClearModifierPurged\(\)

```csharp
public void ClearModifierPurged()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearModifierPurgedDuration"></a> ClearModifierPurgedDuration\(\)

```csharp
public void ClearModifierPurgedDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearModifierPurgeNpc"></a> ClearModifierPurgeNpc\(\)

```csharp
public void ClearModifierPurgeNpc()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearMotionControllerModifier"></a> ClearMotionControllerModifier\(\)

```csharp
public void ClearMotionControllerModifier()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearNetworth"></a> ClearNetworth\(\)

```csharp
public void ClearNetworth()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearNeutralCampTeam"></a> ClearNeutralCampTeam\(\)

```csharp
public void ClearNeutralCampTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearNeutralCampType"></a> ClearNeutralCampType\(\)

```csharp
public void ClearNeutralCampType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearNoPhysicalDamageModifier"></a> ClearNoPhysicalDamageModifier\(\)

```csharp
public void ClearNoPhysicalDamageModifier()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearObsWardsPlaced"></a> ClearObsWardsPlaced\(\)

```csharp
public void ClearObsWardsPlaced()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearRegeneratedHealth"></a> ClearRegeneratedHealth\(\)

```csharp
public void ClearRegeneratedHealth()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearRootModifier"></a> ClearRootModifier\(\)

```csharp
public void ClearRootModifier()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearRuneType"></a> ClearRuneType\(\)

```csharp
public void ClearRuneType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearSilenceModifier"></a> ClearSilenceModifier\(\)

```csharp
public void ClearSilenceModifier()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearSlowDuration"></a> ClearSlowDuration\(\)

```csharp
public void ClearSlowDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearSpellEvaded"></a> ClearSpellEvaded\(\)

```csharp
public void ClearSpellEvaded()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearSpellGeneratedAttack"></a> ClearSpellGeneratedAttack\(\)

```csharp
public void ClearSpellGeneratedAttack()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearStackCount"></a> ClearStackCount\(\)

```csharp
public void ClearStackCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearStunDuration"></a> ClearStunDuration\(\)

```csharp
public void ClearStunDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearTargetHeroLevel"></a> ClearTargetHeroLevel\(\)

```csharp
public void ClearTargetHeroLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearTargetIsSelf"></a> ClearTargetIsSelf\(\)

```csharp
public void ClearTargetIsSelf()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearTargetName"></a> ClearTargetName\(\)

```csharp
public void ClearTargetName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearTargetSourceName"></a> ClearTargetSourceName\(\)

```csharp
public void ClearTargetSourceName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearTargetTeam"></a> ClearTargetTeam\(\)

```csharp
public void ClearTargetTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearTimestampRaw"></a> ClearTimestampRaw\(\)

```csharp
public void ClearTimestampRaw()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearTotalUnitDeathCount"></a> ClearTotalUnitDeathCount\(\)

```csharp
public void ClearTotalUnitDeathCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearTrackedStatId"></a> ClearTrackedStatId\(\)

```csharp
public void ClearTrackedStatId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearUnitStatusLabel"></a> ClearUnitStatusLabel\(\)

```csharp
public void ClearUnitStatusLabel()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearUsesCharges"></a> ClearUsesCharges\(\)

```csharp
public void ClearUsesCharges()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearWillReincarnate"></a> ClearWillReincarnate\(\)

```csharp
public void ClearWillReincarnate()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearXpm"></a> ClearXpm\(\)

```csharp
public void ClearXpm()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ClearXpReason"></a> ClearXpReason\(\)

```csharp
public void ClearXpReason()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_Clone"></a> Clone\(\)

```csharp
public CMsgDOTACombatLogEntry Clone()
```

#### Returns

 [CMsgDOTACombatLogEntry](Divine.Protobufs.Dota2.CMsgDOTACombatLogEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_Equals_Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_"></a> Equals\(CMsgDOTACombatLogEntry\)

```csharp
public bool Equals(CMsgDOTACombatLogEntry other)
```

#### Parameters

`other` [CMsgDOTACombatLogEntry](Divine.Protobufs.Dota2.CMsgDOTACombatLogEntry.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_"></a> MergeFrom\(CMsgDOTACombatLogEntry\)

```csharp
public void MergeFrom(CMsgDOTACombatLogEntry other)
```

#### Parameters

`other` [CMsgDOTACombatLogEntry](Divine.Protobufs.Dota2.CMsgDOTACombatLogEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACombatLogEntry_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

