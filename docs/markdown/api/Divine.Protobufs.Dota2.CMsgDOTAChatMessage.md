# <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage"></a> Class CMsgDOTAChatMessage

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAChatMessage : IMessage<CMsgDOTAChatMessage>, IEquatable<CMsgDOTAChatMessage>, IDeepCloneable<CMsgDOTAChatMessage>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md)

#### Implements

IMessage<CMsgDOTAChatMessage\>, 
[IEquatable<CMsgDOTAChatMessage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAChatMessage\>, 
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
[EnumerableExtensions.In<CMsgDOTAChatMessage\>\(CMsgDOTAChatMessage, params CMsgDOTAChatMessage\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage__ctor"></a> CMsgDOTAChatMessage\(\)

```csharp
public CMsgDOTAChatMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage__ctor_Divine_Protobufs_Dota2_CMsgDOTAChatMessage_"></a> CMsgDOTAChatMessage\(CMsgDOTAChatMessage\)

```csharp
public CMsgDOTAChatMessage(CMsgDOTAChatMessage other)
```

#### Parameters

`other` [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_BadgeLevelFieldNumber"></a> BadgeLevelFieldNumber

```csharp
public const int BadgeLevelFieldNumber = 25
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_BattleCupStreakFieldNumber"></a> BattleCupStreakFieldNumber

```csharp
public const int BattleCupStreakFieldNumber = 29
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ChannelIdFieldNumber"></a> ChannelIdFieldNumber

```csharp
public const int ChannelIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ChannelUserIdFieldNumber"></a> ChannelUserIdFieldNumber

```csharp
public const int ChannelUserIdFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ChatFlagsFieldNumber"></a> ChatFlagsFieldNumber

```csharp
public const int ChatFlagsFieldNumber = 34
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ChatWheelMessageFieldNumber"></a> ChatWheelMessageFieldNumber

```csharp
public const int ChatWheelMessageFieldNumber = 41
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_CoinFlipFieldNumber"></a> CoinFlipFieldNumber

```csharp
public const int CoinFlipFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_CtrlIsDownFieldNumber"></a> CtrlIsDownFieldNumber

```csharp
public const int CtrlIsDownFieldNumber = 36
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_DiceRollFieldNumber"></a> DiceRollFieldNumber

```csharp
public const int DiceRollFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_EventLevelFieldNumber"></a> EventLevelFieldNumber

```csharp
public const int EventLevelFieldNumber = 42
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_FantasyDraftOwnerAccountIdFieldNumber"></a> FantasyDraftOwnerAccountIdFieldNumber

```csharp
public const int FantasyDraftOwnerAccountIdFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_FantasyDraftPlayerAccountIdFieldNumber"></a> FantasyDraftPlayerAccountIdFieldNumber

```csharp
public const int FantasyDraftPlayerAccountIdFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_FavoriteTeamIdFieldNumber"></a> FavoriteTeamIdFieldNumber

```csharp
public const int FavoriteTeamIdFieldNumber = 37
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_FavoriteTeamQualityFieldNumber"></a> FavoriteTeamQualityFieldNumber

```csharp
public const int FavoriteTeamQualityFieldNumber = 38
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_LegacyBattleCupVictoryFieldNumber"></a> LegacyBattleCupVictoryFieldNumber

```csharp
public const int LegacyBattleCupVictoryFieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_PersonaNameFieldNumber"></a> PersonaNameFieldNumber

```csharp
public const int PersonaNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_PlayerDraftPickFieldNumber"></a> PlayerDraftPickFieldNumber

```csharp
public const int PlayerDraftPickFieldNumber = 40
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_PrivateChatChannelIdFieldNumber"></a> PrivateChatChannelIdFieldNumber

```csharp
public const int PrivateChatChannelIdFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_RequestedAbilityIdFieldNumber"></a> RequestedAbilityIdFieldNumber

```csharp
public const int RequestedAbilityIdFieldNumber = 33
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_RequestedHeroFacetKeyFieldNumber"></a> RequestedHeroFacetKeyFieldNumber

```csharp
public const int RequestedHeroFacetKeyFieldNumber = 45
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_RequestedHeroIdFieldNumber"></a> RequestedHeroIdFieldNumber

```csharp
public const int RequestedHeroIdFieldNumber = 44
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ShareLobbyCustomGameIdFieldNumber"></a> ShareLobbyCustomGameIdFieldNumber

```csharp
public const int ShareLobbyCustomGameIdFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ShareLobbyIdFieldNumber"></a> ShareLobbyIdFieldNumber

```csharp
public const int ShareLobbyIdFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ShareLobbyPasskeyFieldNumber"></a> ShareLobbyPasskeyFieldNumber

```csharp
public const int ShareLobbyPasskeyFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_SharePartyIdFieldNumber"></a> SharePartyIdFieldNumber

```csharp
public const int SharePartyIdFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ShareProfileAccountIdFieldNumber"></a> ShareProfileAccountIdFieldNumber

```csharp
public const int ShareProfileAccountIdFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_StartedFindingMatchFieldNumber"></a> StartedFindingMatchFieldNumber

```csharp
public const int StartedFindingMatchFieldNumber = 35
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_StatusFieldNumber"></a> StatusFieldNumber

```csharp
public const int StatusFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_SuggestBanHeroIdFieldNumber"></a> SuggestBanHeroIdFieldNumber

```csharp
public const int SuggestBanHeroIdFieldNumber = 30
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_SuggestInviteAccountIdFieldNumber"></a> SuggestInviteAccountIdFieldNumber

```csharp
public const int SuggestInviteAccountIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_SuggestInviteNameFieldNumber"></a> SuggestInviteNameFieldNumber

```csharp
public const int SuggestInviteNameFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_SuggestInviteToLobbyFieldNumber"></a> SuggestInviteToLobbyFieldNumber

```csharp
public const int SuggestInviteToLobbyFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_SuggestPickHeroFacetFieldNumber"></a> SuggestPickHeroFacetFieldNumber

```csharp
public const int SuggestPickHeroFacetFieldNumber = 43
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_SuggestPickHeroIdFieldNumber"></a> SuggestPickHeroIdFieldNumber

```csharp
public const int SuggestPickHeroIdFieldNumber = 26
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_SuggestPickHeroRoleFieldNumber"></a> SuggestPickHeroRoleFieldNumber

```csharp
public const int SuggestPickHeroRoleFieldNumber = 27
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_SuggestPlayerDraftPickFieldNumber"></a> SuggestPlayerDraftPickFieldNumber

```csharp
public const int SuggestPlayerDraftPickFieldNumber = 39
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_TextFieldNumber"></a> TextFieldNumber

```csharp
public const int TextFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_TriviaAnswerFieldNumber"></a> TriviaAnswerFieldNumber

```csharp
public const int TriviaAnswerFieldNumber = 32
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_BadgeLevel"></a> BadgeLevel

```csharp
public uint BadgeLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_BattleCupStreak"></a> BattleCupStreak

```csharp
public uint BattleCupStreak { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ChannelId"></a> ChannelId

```csharp
public ulong ChannelId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ChannelUserId"></a> ChannelUserId

```csharp
public uint ChannelUserId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ChatFlags"></a> ChatFlags

```csharp
public uint ChatFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ChatWheelMessage"></a> ChatWheelMessage

```csharp
public CMsgDOTAChatMessage.Types.ChatWheelMessage ChatWheelMessage { get; set; }
```

#### Property Value

 [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[ChatWheelMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.ChatWheelMessage.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_CoinFlip"></a> CoinFlip

```csharp
public bool CoinFlip { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_CtrlIsDown"></a> CtrlIsDown

```csharp
public bool CtrlIsDown { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_DiceRoll"></a> DiceRoll

```csharp
public CMsgDOTAChatMessage.Types.DiceRoll DiceRoll { get; set; }
```

#### Property Value

 [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[DiceRoll](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.DiceRoll.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_EventLevel"></a> EventLevel

```csharp
public uint EventLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_FantasyDraftOwnerAccountId"></a> FantasyDraftOwnerAccountId

```csharp
public uint FantasyDraftOwnerAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_FantasyDraftPlayerAccountId"></a> FantasyDraftPlayerAccountId

```csharp
public uint FantasyDraftPlayerAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_FavoriteTeamId"></a> FavoriteTeamId

```csharp
public uint FavoriteTeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_FavoriteTeamQuality"></a> FavoriteTeamQuality

```csharp
public uint FavoriteTeamQuality { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasBadgeLevel"></a> HasBadgeLevel

```csharp
public bool HasBadgeLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasBattleCupStreak"></a> HasBattleCupStreak

```csharp
public bool HasBattleCupStreak { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasChannelId"></a> HasChannelId

```csharp
public bool HasChannelId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasChannelUserId"></a> HasChannelUserId

```csharp
public bool HasChannelUserId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasChatFlags"></a> HasChatFlags

```csharp
public bool HasChatFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasCoinFlip"></a> HasCoinFlip

```csharp
public bool HasCoinFlip { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasCtrlIsDown"></a> HasCtrlIsDown

```csharp
public bool HasCtrlIsDown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasEventLevel"></a> HasEventLevel

```csharp
public bool HasEventLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasFantasyDraftOwnerAccountId"></a> HasFantasyDraftOwnerAccountId

```csharp
public bool HasFantasyDraftOwnerAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasFantasyDraftPlayerAccountId"></a> HasFantasyDraftPlayerAccountId

```csharp
public bool HasFantasyDraftPlayerAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasFavoriteTeamId"></a> HasFavoriteTeamId

```csharp
public bool HasFavoriteTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasFavoriteTeamQuality"></a> HasFavoriteTeamQuality

```csharp
public bool HasFavoriteTeamQuality { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasLegacyBattleCupVictory"></a> HasLegacyBattleCupVictory

```csharp
public bool HasLegacyBattleCupVictory { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasPersonaName"></a> HasPersonaName

```csharp
public bool HasPersonaName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasPrivateChatChannelId"></a> HasPrivateChatChannelId

```csharp
public bool HasPrivateChatChannelId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasRequestedAbilityId"></a> HasRequestedAbilityId

```csharp
public bool HasRequestedAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasRequestedHeroFacetKey"></a> HasRequestedHeroFacetKey

```csharp
public bool HasRequestedHeroFacetKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasRequestedHeroId"></a> HasRequestedHeroId

```csharp
public bool HasRequestedHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasShareLobbyCustomGameId"></a> HasShareLobbyCustomGameId

```csharp
public bool HasShareLobbyCustomGameId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasShareLobbyId"></a> HasShareLobbyId

```csharp
public bool HasShareLobbyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasShareLobbyPasskey"></a> HasShareLobbyPasskey

```csharp
public bool HasShareLobbyPasskey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasSharePartyId"></a> HasSharePartyId

```csharp
public bool HasSharePartyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasShareProfileAccountId"></a> HasShareProfileAccountId

```csharp
public bool HasShareProfileAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasStartedFindingMatch"></a> HasStartedFindingMatch

```csharp
public bool HasStartedFindingMatch { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasStatus"></a> HasStatus

```csharp
public bool HasStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasSuggestBanHeroId"></a> HasSuggestBanHeroId

```csharp
public bool HasSuggestBanHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasSuggestInviteAccountId"></a> HasSuggestInviteAccountId

```csharp
public bool HasSuggestInviteAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasSuggestInviteName"></a> HasSuggestInviteName

```csharp
public bool HasSuggestInviteName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasSuggestInviteToLobby"></a> HasSuggestInviteToLobby

```csharp
public bool HasSuggestInviteToLobby { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasSuggestPickHeroFacet"></a> HasSuggestPickHeroFacet

```csharp
public bool HasSuggestPickHeroFacet { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasSuggestPickHeroId"></a> HasSuggestPickHeroId

```csharp
public bool HasSuggestPickHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasSuggestPickHeroRole"></a> HasSuggestPickHeroRole

```csharp
public bool HasSuggestPickHeroRole { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasSuggestPlayerDraftPick"></a> HasSuggestPlayerDraftPick

```csharp
public bool HasSuggestPlayerDraftPick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasText"></a> HasText

```csharp
public bool HasText { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_LegacyBattleCupVictory"></a> LegacyBattleCupVictory

```csharp
public bool LegacyBattleCupVictory { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAChatMessage> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_PersonaName"></a> PersonaName

```csharp
public string PersonaName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_PlayerDraftPick"></a> PlayerDraftPick

```csharp
public CMsgDOTAChatMessage.Types.PlayerDraftPick PlayerDraftPick { get; set; }
```

#### Property Value

 [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[PlayerDraftPick](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.PlayerDraftPick.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_PrivateChatChannelId"></a> PrivateChatChannelId

```csharp
public uint PrivateChatChannelId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_RequestedAbilityId"></a> RequestedAbilityId

```csharp
public int RequestedAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_RequestedHeroFacetKey"></a> RequestedHeroFacetKey

```csharp
public ulong RequestedHeroFacetKey { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_RequestedHeroId"></a> RequestedHeroId

```csharp
public int RequestedHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ShareLobbyCustomGameId"></a> ShareLobbyCustomGameId

```csharp
public ulong ShareLobbyCustomGameId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ShareLobbyId"></a> ShareLobbyId

```csharp
public ulong ShareLobbyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ShareLobbyPasskey"></a> ShareLobbyPasskey

```csharp
public string ShareLobbyPasskey { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_SharePartyId"></a> SharePartyId

```csharp
public ulong SharePartyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ShareProfileAccountId"></a> ShareProfileAccountId

```csharp
public uint ShareProfileAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_StartedFindingMatch"></a> StartedFindingMatch

```csharp
public bool StartedFindingMatch { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Status"></a> Status

```csharp
public uint Status { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_SuggestBanHeroId"></a> SuggestBanHeroId

```csharp
public int SuggestBanHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_SuggestInviteAccountId"></a> SuggestInviteAccountId

```csharp
public uint SuggestInviteAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_SuggestInviteName"></a> SuggestInviteName

```csharp
public string SuggestInviteName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_SuggestInviteToLobby"></a> SuggestInviteToLobby

```csharp
public bool SuggestInviteToLobby { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_SuggestPickHeroFacet"></a> SuggestPickHeroFacet

```csharp
public uint SuggestPickHeroFacet { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_SuggestPickHeroId"></a> SuggestPickHeroId

```csharp
public int SuggestPickHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_SuggestPickHeroRole"></a> SuggestPickHeroRole

```csharp
public string SuggestPickHeroRole { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_SuggestPlayerDraftPick"></a> SuggestPlayerDraftPick

```csharp
public int SuggestPlayerDraftPick { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Text"></a> Text

```csharp
public string Text { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_TriviaAnswer"></a> TriviaAnswer

```csharp
public CMsgDOTAChatMessage.Types.TriviaAnswered TriviaAnswer { get; set; }
```

#### Property Value

 [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[TriviaAnswered](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.TriviaAnswered.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearBadgeLevel"></a> ClearBadgeLevel\(\)

```csharp
public void ClearBadgeLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearBattleCupStreak"></a> ClearBattleCupStreak\(\)

```csharp
public void ClearBattleCupStreak()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearChannelId"></a> ClearChannelId\(\)

```csharp
public void ClearChannelId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearChannelUserId"></a> ClearChannelUserId\(\)

```csharp
public void ClearChannelUserId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearChatFlags"></a> ClearChatFlags\(\)

```csharp
public void ClearChatFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearCoinFlip"></a> ClearCoinFlip\(\)

```csharp
public void ClearCoinFlip()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearCtrlIsDown"></a> ClearCtrlIsDown\(\)

```csharp
public void ClearCtrlIsDown()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearEventLevel"></a> ClearEventLevel\(\)

```csharp
public void ClearEventLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearFantasyDraftOwnerAccountId"></a> ClearFantasyDraftOwnerAccountId\(\)

```csharp
public void ClearFantasyDraftOwnerAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearFantasyDraftPlayerAccountId"></a> ClearFantasyDraftPlayerAccountId\(\)

```csharp
public void ClearFantasyDraftPlayerAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearFavoriteTeamId"></a> ClearFavoriteTeamId\(\)

```csharp
public void ClearFavoriteTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearFavoriteTeamQuality"></a> ClearFavoriteTeamQuality\(\)

```csharp
public void ClearFavoriteTeamQuality()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearLegacyBattleCupVictory"></a> ClearLegacyBattleCupVictory\(\)

```csharp
public void ClearLegacyBattleCupVictory()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearPersonaName"></a> ClearPersonaName\(\)

```csharp
public void ClearPersonaName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearPrivateChatChannelId"></a> ClearPrivateChatChannelId\(\)

```csharp
public void ClearPrivateChatChannelId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearRequestedAbilityId"></a> ClearRequestedAbilityId\(\)

```csharp
public void ClearRequestedAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearRequestedHeroFacetKey"></a> ClearRequestedHeroFacetKey\(\)

```csharp
public void ClearRequestedHeroFacetKey()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearRequestedHeroId"></a> ClearRequestedHeroId\(\)

```csharp
public void ClearRequestedHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearShareLobbyCustomGameId"></a> ClearShareLobbyCustomGameId\(\)

```csharp
public void ClearShareLobbyCustomGameId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearShareLobbyId"></a> ClearShareLobbyId\(\)

```csharp
public void ClearShareLobbyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearShareLobbyPasskey"></a> ClearShareLobbyPasskey\(\)

```csharp
public void ClearShareLobbyPasskey()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearSharePartyId"></a> ClearSharePartyId\(\)

```csharp
public void ClearSharePartyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearShareProfileAccountId"></a> ClearShareProfileAccountId\(\)

```csharp
public void ClearShareProfileAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearStartedFindingMatch"></a> ClearStartedFindingMatch\(\)

```csharp
public void ClearStartedFindingMatch()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearStatus"></a> ClearStatus\(\)

```csharp
public void ClearStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearSuggestBanHeroId"></a> ClearSuggestBanHeroId\(\)

```csharp
public void ClearSuggestBanHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearSuggestInviteAccountId"></a> ClearSuggestInviteAccountId\(\)

```csharp
public void ClearSuggestInviteAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearSuggestInviteName"></a> ClearSuggestInviteName\(\)

```csharp
public void ClearSuggestInviteName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearSuggestInviteToLobby"></a> ClearSuggestInviteToLobby\(\)

```csharp
public void ClearSuggestInviteToLobby()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearSuggestPickHeroFacet"></a> ClearSuggestPickHeroFacet\(\)

```csharp
public void ClearSuggestPickHeroFacet()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearSuggestPickHeroId"></a> ClearSuggestPickHeroId\(\)

```csharp
public void ClearSuggestPickHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearSuggestPickHeroRole"></a> ClearSuggestPickHeroRole\(\)

```csharp
public void ClearSuggestPickHeroRole()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearSuggestPlayerDraftPick"></a> ClearSuggestPlayerDraftPick\(\)

```csharp
public void ClearSuggestPlayerDraftPick()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearText"></a> ClearText\(\)

```csharp
public void ClearText()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAChatMessage Clone()
```

#### Returns

 [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Equals_Divine_Protobufs_Dota2_CMsgDOTAChatMessage_"></a> Equals\(CMsgDOTAChatMessage\)

```csharp
public bool Equals(CMsgDOTAChatMessage other)
```

#### Parameters

`other` [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAChatMessage_"></a> MergeFrom\(CMsgDOTAChatMessage\)

```csharp
public void MergeFrom(CMsgDOTAChatMessage other)
```

#### Parameters

`other` [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

