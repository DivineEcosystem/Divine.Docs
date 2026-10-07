# <a id="Divine_Protobufs_Dota2_CMsgBotWorldState"></a> Class CMsgBotWorldState

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBotWorldState : IMessage<CMsgBotWorldState>, IEquatable<CMsgBotWorldState>, IDeepCloneable<CMsgBotWorldState>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md)

#### Implements

IMessage<CMsgBotWorldState\>, 
[IEquatable<CMsgBotWorldState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBotWorldState\>, 
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
[EnumerableExtensions.In<CMsgBotWorldState\>\(CMsgBotWorldState, params CMsgBotWorldState\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState__ctor"></a> CMsgBotWorldState\(\)

```csharp
public CMsgBotWorldState()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState__ctor_Divine_Protobufs_Dota2_CMsgBotWorldState_"></a> CMsgBotWorldState\(CMsgBotWorldState\)

```csharp
public CMsgBotWorldState(CMsgBotWorldState other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_AbilityEventsFieldNumber"></a> AbilityEventsFieldNumber

```csharp
public const int AbilityEventsFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_AvoidanceZonesFieldNumber"></a> AvoidanceZonesFieldNumber

```csharp
public const int AvoidanceZonesFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_CourierKilledEventsFieldNumber"></a> CourierKilledEventsFieldNumber

```csharp
public const int CourierKilledEventsFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_CouriersFieldNumber"></a> CouriersFieldNumber

```csharp
public const int CouriersFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_DamageEventsFieldNumber"></a> DamageEventsFieldNumber

```csharp
public const int DamageEventsFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_DotaTimeFieldNumber"></a> DotaTimeFieldNumber

```csharp
public const int DotaTimeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_DroppedItemsDeltasFieldNumber"></a> DroppedItemsDeltasFieldNumber

```csharp
public const int DroppedItemsDeltasFieldNumber = 112
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_DroppedItemsFieldNumber"></a> DroppedItemsFieldNumber

```csharp
public const int DroppedItemsFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_GameStateFieldNumber"></a> GameStateFieldNumber

```csharp
public const int GameStateFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_GameTimeFieldNumber"></a> GameTimeFieldNumber

```csharp
public const int GameTimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_GlyphCooldownEnemyFieldNumber"></a> GlyphCooldownEnemyFieldNumber

```csharp
public const int GlyphCooldownEnemyFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_GlyphCooldownFieldNumber"></a> GlyphCooldownFieldNumber

```csharp
public const int GlyphCooldownFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_HeroPickStateFieldNumber"></a> HeroPickStateFieldNumber

```csharp
public const int HeroPickStateFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_IncomingTeleportsFieldNumber"></a> IncomingTeleportsFieldNumber

```csharp
public const int IncomingTeleportsFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_LinearProjectilesFieldNumber"></a> LinearProjectilesFieldNumber

```csharp
public const int LinearProjectilesFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_RoshanKilledEventsFieldNumber"></a> RoshanKilledEventsFieldNumber

```csharp
public const int RoshanKilledEventsFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_RuneInfosDeltasFieldNumber"></a> RuneInfosDeltasFieldNumber

```csharp
public const int RuneInfosDeltasFieldNumber = 113
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_RuneInfosFieldNumber"></a> RuneInfosFieldNumber

```csharp
public const int RuneInfosFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_TimeOfDayFieldNumber"></a> TimeOfDayFieldNumber

```csharp
public const int TimeOfDayFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_TreeEventsFieldNumber"></a> TreeEventsFieldNumber

```csharp
public const int TreeEventsFieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_UnitsFieldNumber"></a> UnitsFieldNumber

```csharp
public const int UnitsFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_AbilityEvents"></a> AbilityEvents

```csharp
public RepeatedField<CMsgBotWorldState.Types.EventAbility> AbilityEvents { get; }
```

#### Property Value

 RepeatedField<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventAbility](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventAbility.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_AvoidanceZones"></a> AvoidanceZones

```csharp
public RepeatedField<CMsgBotWorldState.Types.AvoidanceZone> AvoidanceZones { get; }
```

#### Property Value

 RepeatedField<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[AvoidanceZone](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.AvoidanceZone.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_CourierKilledEvents"></a> CourierKilledEvents

```csharp
public RepeatedField<CMsgBotWorldState.Types.EventCourierKilled> CourierKilledEvents { get; }
```

#### Property Value

 RepeatedField<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventCourierKilled](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventCourierKilled.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Couriers"></a> Couriers

```csharp
public RepeatedField<CMsgBotWorldState.Types.Courier> Couriers { get; }
```

#### Property Value

 RepeatedField<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Courier](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Courier.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_DamageEvents"></a> DamageEvents

```csharp
public RepeatedField<CMsgBotWorldState.Types.EventDamage> DamageEvents { get; }
```

#### Property Value

 RepeatedField<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventDamage](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventDamage.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_DotaTime"></a> DotaTime

```csharp
public float DotaTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_DroppedItems"></a> DroppedItems

```csharp
public RepeatedField<CMsgBotWorldState.Types.DroppedItem> DroppedItems { get; }
```

#### Property Value

 RepeatedField<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[DroppedItem](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.DroppedItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_DroppedItemsDeltas"></a> DroppedItemsDeltas

```csharp
public RepeatedField<int> DroppedItemsDeltas { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_GameState"></a> GameState

```csharp
public uint GameState { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_GameTime"></a> GameTime

```csharp
public float GameTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_GlyphCooldown"></a> GlyphCooldown

```csharp
public float GlyphCooldown { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_GlyphCooldownEnemy"></a> GlyphCooldownEnemy

```csharp
public float GlyphCooldownEnemy { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_HasDotaTime"></a> HasDotaTime

```csharp
public bool HasDotaTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_HasGameState"></a> HasGameState

```csharp
public bool HasGameState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_HasGameTime"></a> HasGameTime

```csharp
public bool HasGameTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_HasGlyphCooldown"></a> HasGlyphCooldown

```csharp
public bool HasGlyphCooldown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_HasGlyphCooldownEnemy"></a> HasGlyphCooldownEnemy

```csharp
public bool HasGlyphCooldownEnemy { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_HasHeroPickState"></a> HasHeroPickState

```csharp
public bool HasHeroPickState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_HasTimeOfDay"></a> HasTimeOfDay

```csharp
public bool HasTimeOfDay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_HeroPickState"></a> HeroPickState

```csharp
public uint HeroPickState { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_IncomingTeleports"></a> IncomingTeleports

```csharp
public RepeatedField<CMsgBotWorldState.Types.TeleportInfo> IncomingTeleports { get; }
```

#### Property Value

 RepeatedField<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[TeleportInfo](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.TeleportInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_LinearProjectiles"></a> LinearProjectiles

```csharp
public RepeatedField<CMsgBotWorldState.Types.LinearProjectile> LinearProjectiles { get; }
```

#### Property Value

 RepeatedField<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[LinearProjectile](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.LinearProjectile.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBotWorldState> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Players"></a> Players

```csharp
public RepeatedField<CMsgBotWorldState.Types.Player> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Player](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_RoshanKilledEvents"></a> RoshanKilledEvents

```csharp
public RepeatedField<CMsgBotWorldState.Types.EventRoshanKilled> RoshanKilledEvents { get; }
```

#### Property Value

 RepeatedField<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventRoshanKilled](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventRoshanKilled.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_RuneInfos"></a> RuneInfos

```csharp
public RepeatedField<CMsgBotWorldState.Types.RuneInfo> RuneInfos { get; }
```

#### Property Value

 RepeatedField<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[RuneInfo](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.RuneInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_RuneInfosDeltas"></a> RuneInfosDeltas

```csharp
public RepeatedField<int> RuneInfosDeltas { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_TimeOfDay"></a> TimeOfDay

```csharp
public float TimeOfDay { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_TreeEvents"></a> TreeEvents

```csharp
public RepeatedField<CMsgBotWorldState.Types.EventTree> TreeEvents { get; }
```

#### Property Value

 RepeatedField<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventTree](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventTree.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Units"></a> Units

```csharp
public RepeatedField<CMsgBotWorldState.Types.Unit> Units { get; }
```

#### Property Value

 RepeatedField<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Unit](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Unit.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_ClearDotaTime"></a> ClearDotaTime\(\)

```csharp
public void ClearDotaTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_ClearGameState"></a> ClearGameState\(\)

```csharp
public void ClearGameState()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_ClearGameTime"></a> ClearGameTime\(\)

```csharp
public void ClearGameTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_ClearGlyphCooldown"></a> ClearGlyphCooldown\(\)

```csharp
public void ClearGlyphCooldown()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_ClearGlyphCooldownEnemy"></a> ClearGlyphCooldownEnemy\(\)

```csharp
public void ClearGlyphCooldownEnemy()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_ClearHeroPickState"></a> ClearHeroPickState\(\)

```csharp
public void ClearHeroPickState()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_ClearTimeOfDay"></a> ClearTimeOfDay\(\)

```csharp
public void ClearTimeOfDay()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Clone"></a> Clone\(\)

```csharp
public CMsgBotWorldState Clone()
```

#### Returns

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Equals_Divine_Protobufs_Dota2_CMsgBotWorldState_"></a> Equals\(CMsgBotWorldState\)

```csharp
public bool Equals(CMsgBotWorldState other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_MergeFrom_Divine_Protobufs_Dota2_CMsgBotWorldState_"></a> MergeFrom\(CMsgBotWorldState\)

```csharp
public void MergeFrom(CMsgBotWorldState other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

