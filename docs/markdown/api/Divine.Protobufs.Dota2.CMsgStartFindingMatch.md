# <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch"></a> Class CMsgStartFindingMatch

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgStartFindingMatch : IMessage<CMsgStartFindingMatch>, IEquatable<CMsgStartFindingMatch>, IDeepCloneable<CMsgStartFindingMatch>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgStartFindingMatch](Divine.Protobufs.Dota2.CMsgStartFindingMatch.md)

#### Implements

IMessage<CMsgStartFindingMatch\>, 
[IEquatable<CMsgStartFindingMatch\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgStartFindingMatch\>, 
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
[EnumerableExtensions.In<CMsgStartFindingMatch\>\(CMsgStartFindingMatch, params CMsgStartFindingMatch\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch__ctor"></a> CMsgStartFindingMatch\(\)

```csharp
public CMsgStartFindingMatch()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch__ctor_Divine_Protobufs_Dota2_CMsgStartFindingMatch_"></a> CMsgStartFindingMatch\(CMsgStartFindingMatch\)

```csharp
public CMsgStartFindingMatch(CMsgStartFindingMatch other)
```

#### Parameters

`other` [CMsgStartFindingMatch](Divine.Protobufs.Dota2.CMsgStartFindingMatch.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_BotDifficultyMaskFieldNumber"></a> BotDifficultyMaskFieldNumber

```csharp
public const int BotDifficultyMaskFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_BotScriptIndexMaskFieldNumber"></a> BotScriptIndexMaskFieldNumber

```csharp
public const int BotScriptIndexMaskFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClientVersionFieldNumber"></a> ClientVersionFieldNumber

```csharp
public const int ClientVersionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_CustomGameDifficultyMaskFieldNumber"></a> CustomGameDifficultyMaskFieldNumber

```csharp
public const int CustomGameDifficultyMaskFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_DisableExperimentalGameplayFieldNumber"></a> DisableExperimentalGameplayFieldNumber

```csharp
public const int DisableExperimentalGameplayFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_GameLanguageEnumFieldNumber"></a> GameLanguageEnumFieldNumber

```csharp
public const int GameLanguageEnumFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_GameLanguageNameFieldNumber"></a> GameLanguageNameFieldNumber

```csharp
public const int GameLanguageNameFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_GameModesFieldNumber"></a> GameModesFieldNumber

```csharp
public const int GameModesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HighPriorityDisabledFieldNumber"></a> HighPriorityDisabledFieldNumber

```csharp
public const int HighPriorityDisabledFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_IsChallengeMatchFieldNumber"></a> IsChallengeMatchFieldNumber

```csharp
public const int IsChallengeMatchFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_KeyFieldNumber"></a> KeyFieldNumber

```csharp
public const int KeyFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_LaneSelectionFlagsFieldNumber"></a> LaneSelectionFlagsFieldNumber

```csharp
public const int LaneSelectionFlagsFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_MatchgroupsFieldNumber"></a> MatchgroupsFieldNumber

```csharp
public const int MatchgroupsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_MatchlanguagesFieldNumber"></a> MatchlanguagesFieldNumber

```csharp
public const int MatchlanguagesFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_MatchTypeFieldNumber"></a> MatchTypeFieldNumber

```csharp
public const int MatchTypeFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_PingDataFieldNumber"></a> PingDataFieldNumber

```csharp
public const int PingDataFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_RegionSelectFlagsFieldNumber"></a> RegionSelectFlagsFieldNumber

```csharp
public const int RegionSelectFlagsFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_SoloQueueFieldNumber"></a> SoloQueueFieldNumber

```csharp
public const int SoloQueueFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_SteamClanAccountIdFieldNumber"></a> SteamClanAccountIdFieldNumber

```csharp
public const int SteamClanAccountIdFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_BotDifficultyMask"></a> BotDifficultyMask

```csharp
public uint BotDifficultyMask { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_BotScriptIndexMask"></a> BotScriptIndexMask

```csharp
public uint BotScriptIndexMask { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClientVersion"></a> ClientVersion

```csharp
public uint ClientVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_CustomGameDifficultyMask"></a> CustomGameDifficultyMask

```csharp
public uint CustomGameDifficultyMask { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_DisableExperimentalGameplay"></a> DisableExperimentalGameplay

```csharp
public bool DisableExperimentalGameplay { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_GameLanguageEnum"></a> GameLanguageEnum

```csharp
public MatchLanguages GameLanguageEnum { get; set; }
```

#### Property Value

 [MatchLanguages](Divine.Protobufs.Dota2.MatchLanguages.md)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_GameLanguageName"></a> GameLanguageName

```csharp
public string GameLanguageName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_GameModes"></a> GameModes

```csharp
public uint GameModes { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HasBotDifficultyMask"></a> HasBotDifficultyMask

```csharp
public bool HasBotDifficultyMask { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HasBotScriptIndexMask"></a> HasBotScriptIndexMask

```csharp
public bool HasBotScriptIndexMask { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HasClientVersion"></a> HasClientVersion

```csharp
public bool HasClientVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HasCustomGameDifficultyMask"></a> HasCustomGameDifficultyMask

```csharp
public bool HasCustomGameDifficultyMask { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HasDisableExperimentalGameplay"></a> HasDisableExperimentalGameplay

```csharp
public bool HasDisableExperimentalGameplay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HasGameLanguageEnum"></a> HasGameLanguageEnum

```csharp
public bool HasGameLanguageEnum { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HasGameLanguageName"></a> HasGameLanguageName

```csharp
public bool HasGameLanguageName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HasGameModes"></a> HasGameModes

```csharp
public bool HasGameModes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HasHighPriorityDisabled"></a> HasHighPriorityDisabled

```csharp
public bool HasHighPriorityDisabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HasIsChallengeMatch"></a> HasIsChallengeMatch

```csharp
public bool HasIsChallengeMatch { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HasKey"></a> HasKey

```csharp
public bool HasKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HasLaneSelectionFlags"></a> HasLaneSelectionFlags

```csharp
public bool HasLaneSelectionFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HasMatchgroups"></a> HasMatchgroups

```csharp
public bool HasMatchgroups { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HasMatchlanguages"></a> HasMatchlanguages

```csharp
public bool HasMatchlanguages { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HasMatchType"></a> HasMatchType

```csharp
public bool HasMatchType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HasRegionSelectFlags"></a> HasRegionSelectFlags

```csharp
public bool HasRegionSelectFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HasSoloQueue"></a> HasSoloQueue

```csharp
public bool HasSoloQueue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HasSteamClanAccountId"></a> HasSteamClanAccountId

```csharp
public bool HasSteamClanAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_HighPriorityDisabled"></a> HighPriorityDisabled

```csharp
public bool HighPriorityDisabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_IsChallengeMatch"></a> IsChallengeMatch

```csharp
public bool IsChallengeMatch { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_Key"></a> Key

```csharp
public string Key { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_LaneSelectionFlags"></a> LaneSelectionFlags

```csharp
public uint LaneSelectionFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_Matchgroups"></a> Matchgroups

```csharp
public uint Matchgroups { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_Matchlanguages"></a> Matchlanguages

```csharp
public uint Matchlanguages { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_MatchType"></a> MatchType

```csharp
public MatchType MatchType { get; set; }
```

#### Property Value

 [MatchType](Divine.Protobufs.Dota2.MatchType.md)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_Parser"></a> Parser

```csharp
public static MessageParser<CMsgStartFindingMatch> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgStartFindingMatch](Divine.Protobufs.Dota2.CMsgStartFindingMatch.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_PingData"></a> PingData

```csharp
public CMsgClientPingData PingData { get; set; }
```

#### Property Value

 [CMsgClientPingData](Divine.Protobufs.Dota2.CMsgClientPingData.md)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_RegionSelectFlags"></a> RegionSelectFlags

```csharp
public uint RegionSelectFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_SoloQueue"></a> SoloQueue

```csharp
public bool SoloQueue { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_SteamClanAccountId"></a> SteamClanAccountId

```csharp
public uint SteamClanAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClearBotDifficultyMask"></a> ClearBotDifficultyMask\(\)

```csharp
public void ClearBotDifficultyMask()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClearBotScriptIndexMask"></a> ClearBotScriptIndexMask\(\)

```csharp
public void ClearBotScriptIndexMask()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClearClientVersion"></a> ClearClientVersion\(\)

```csharp
public void ClearClientVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClearCustomGameDifficultyMask"></a> ClearCustomGameDifficultyMask\(\)

```csharp
public void ClearCustomGameDifficultyMask()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClearDisableExperimentalGameplay"></a> ClearDisableExperimentalGameplay\(\)

```csharp
public void ClearDisableExperimentalGameplay()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClearGameLanguageEnum"></a> ClearGameLanguageEnum\(\)

```csharp
public void ClearGameLanguageEnum()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClearGameLanguageName"></a> ClearGameLanguageName\(\)

```csharp
public void ClearGameLanguageName()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClearGameModes"></a> ClearGameModes\(\)

```csharp
public void ClearGameModes()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClearHighPriorityDisabled"></a> ClearHighPriorityDisabled\(\)

```csharp
public void ClearHighPriorityDisabled()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClearIsChallengeMatch"></a> ClearIsChallengeMatch\(\)

```csharp
public void ClearIsChallengeMatch()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClearKey"></a> ClearKey\(\)

```csharp
public void ClearKey()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClearLaneSelectionFlags"></a> ClearLaneSelectionFlags\(\)

```csharp
public void ClearLaneSelectionFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClearMatchgroups"></a> ClearMatchgroups\(\)

```csharp
public void ClearMatchgroups()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClearMatchlanguages"></a> ClearMatchlanguages\(\)

```csharp
public void ClearMatchlanguages()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClearMatchType"></a> ClearMatchType\(\)

```csharp
public void ClearMatchType()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClearRegionSelectFlags"></a> ClearRegionSelectFlags\(\)

```csharp
public void ClearRegionSelectFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClearSoloQueue"></a> ClearSoloQueue\(\)

```csharp
public void ClearSoloQueue()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClearSteamClanAccountId"></a> ClearSteamClanAccountId\(\)

```csharp
public void ClearSteamClanAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_Clone"></a> Clone\(\)

```csharp
public CMsgStartFindingMatch Clone()
```

#### Returns

 [CMsgStartFindingMatch](Divine.Protobufs.Dota2.CMsgStartFindingMatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_Equals_Divine_Protobufs_Dota2_CMsgStartFindingMatch_"></a> Equals\(CMsgStartFindingMatch\)

```csharp
public bool Equals(CMsgStartFindingMatch other)
```

#### Parameters

`other` [CMsgStartFindingMatch](Divine.Protobufs.Dota2.CMsgStartFindingMatch.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_MergeFrom_Divine_Protobufs_Dota2_CMsgStartFindingMatch_"></a> MergeFrom\(CMsgStartFindingMatch\)

```csharp
public void MergeFrom(CMsgStartFindingMatch other)
```

#### Parameters

`other` [CMsgStartFindingMatch](Divine.Protobufs.Dota2.CMsgStartFindingMatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatch_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

