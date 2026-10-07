# <a id="Divine_Entity_Entities_Players_Player"></a> Class Player

Namespace: [Divine.Entity.Entities.Players](Divine.Entity.Entities.Players.md)  
Assembly: Divine.dll  

```csharp
public class Player : Entity, IEquatable<Entity>, INative
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Divine.Entity.Entities.Entity.md) ← 
[Player](Divine.Entity.Entities.Players.Player.md)

#### Derived

[DirePlayer](Divine.Entity.Entities.Players.DirePlayer.md), 
[RadiantPlayer](Divine.Entity.Entities.Players.RadiantPlayer.md)

#### Implements

[IEquatable<Entity\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[INative](Divine.Memory.INative.md)

#### Inherited Members

[Entity.NetworkClassInfos](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_NetworkClassInfos), 
[Entity.NetworkPropertyChanged](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_NetworkPropertyChanged), 
[Entity.AnimationChanged](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_AnimationChanged), 
[Entity.Native](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Native), 
[Entity.GetClassIdByNetworkName\(string\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetClassIdByNetworkName\_System\_String\_), 
[Entity.GetNetworkNameByClassId\(ClassId\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetNetworkNameByClassId\_Divine\_Entity\_Entities\_Components\_ClassId\_), 
[Entity.GetStandartNetworkNameByClassId\(int\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetStandartNetworkNameByClassId\_System\_Int32\_), 
[Entity.IsValid](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_IsValid), 
[Entity.Type](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Type), 
[Entity.Handle](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Handle), 
[Entity.NetworkHandle](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_NetworkHandle), 
[Entity.Serial](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Serial), 
[Entity.Index](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Index), 
[Entity.GetHandleByIndex\(int, int\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetHandleByIndex\_System\_Int32\_System\_Int32\_), 
[Entity.GetSerialByHandle\(uint\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetSerialByHandle\_System\_UInt32\_), 
[Entity.GetSerialByNetworkHandle\(uint\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetSerialByNetworkHandle\_System\_UInt32\_), 
[Entity.GetIndexByHandle\(uint\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetIndexByHandle\_System\_UInt32\_), 
[Entity.GetIndexByNetworkHandle\(uint\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetIndexByNetworkHandle\_System\_UInt32\_), 
[Entity.GetHandleByNetworkHandle\(uint\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetHandleByNetworkHandle\_System\_UInt32\_), 
[Entity.GetNetworkHandleByHandle\(uint\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetNetworkHandleByHandle\_System\_UInt32\_), 
[Entity.GetNetworkHandleByIndex\(int, int\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetNetworkHandleByIndex\_System\_Int32\_System\_Int32\_), 
[Entity.InternalName](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_InternalName), 
[Entity.DesignerName](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_DesignerName), 
[Entity.MaximumHealth](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_MaximumHealth), 
[Entity.Health](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Health), 
[Entity.CreateTime](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_CreateTime), 
[Entity.Speed](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Speed), 
[Entity.Team](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Team), 
[Entity.Owner](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Owner), 
[Entity.Name](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Name), 
[Entity.NetworkName](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_NetworkName), 
[Entity.LifeState](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_LifeState), 
[Entity.IdentityFlags](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_IdentityFlags), 
[Entity.WorldGroupId](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_WorldGroupId), 
[Entity.IsMainWorld](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_IsMainWorld), 
[Entity.IsClientWorld](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_IsClientWorld), 
[Entity.Flags](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Flags), 
[Entity.ClassId](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_ClassId), 
[Entity.ClassNetworkId](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_ClassNetworkId), 
[Entity.Position](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Position), 
[Entity.Angles](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Angles), 
[Entity.NetworkAngles](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_NetworkAngles), 
[Entity.IsAlive](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_IsAlive), 
[Entity.IsVisible](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_IsVisible), 
[Entity.IsDormant](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_IsDormant), 
[Entity.Rotation](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Rotation), 
[Entity.RotationRad](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_RotationRad), 
[Entity.NetworkRotation](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_NetworkRotation), 
[Entity.NetworkRotationRad](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_NetworkRotationRad), 
[Entity.AnimationName](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_AnimationName), 
[Entity.AnimationSequence](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_AnimationSequence), 
[Entity.Model](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Model), 
[Entity.Scale](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Scale), 
[Entity.ColorTint](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_ColorTint), 
[Entity.Glow](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Glow), 
[Entity.Particles](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Particles), 
[Entity.GetSequenceName\(int\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetSequenceName\_System\_Int32\_), 
[Entity.Select\(\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Select), 
[Entity.Select\(bool\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Select\_System\_Boolean\_), 
[Entity.PlaySound\(string\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_PlaySound\_System\_String\_), 
[Entity.ToString\(\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_ToString), 
[Entity.Equals\(object?\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Equals\_System\_Object\_), 
[Entity.Equals\(Entity?\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_Equals\_Divine\_Entity\_Entities\_Entity\_), 
[Entity.GetHashCode\(\)](Divine.Entity.Entities.Entity.md\#Divine\_Entity\_Entities\_Entity\_GetHashCode), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[EntityExtensions.Distance\(Entity, Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_Distance\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.Distance\(Entity, Vector3\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_Distance\_Divine\_Entity\_Entities\_Entity\_System\_Numerics\_Vector3\_), 
[EntityExtensions.Distance2D\(Entity, Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_Distance2D\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.Distance2D\(Entity, Vector3\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_Distance2D\_Divine\_Entity\_Entities\_Entity\_System\_Numerics\_Vector3\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<Player\>\(Player, params Player\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[EntityExtensions.IsAlly\(Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsAlly\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.IsAlly\(Entity, Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsAlly\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.IsAlly\(Entity, Team\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsAlly\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Components\_Team\_), 
[EntityExtensions.IsEnemy\(Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsEnemy\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.IsEnemy\(Entity, Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsEnemy\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.IsEnemy\(Entity, Team\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsEnemy\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Components\_Team\_), 
[EntityExtensions.IsInRange\(Entity, Entity, float\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsInRange\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Entity\_System\_Single\_), 
[EntityExtensions.IsInRange\(Entity, Vector2, float\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsInRange\_Divine\_Entity\_Entities\_Entity\_System\_Numerics\_Vector2\_System\_Single\_), 
[EntityExtensions.IsInRange\(Entity, Vector3, float\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsInRange\_Divine\_Entity\_Entities\_Entity\_System\_Numerics\_Vector3\_System\_Single\_)

## Properties

### <a id="Divine_Entity_Entities_Players_Player_AllPlayerData"></a> AllPlayerData

```csharp
public static IEnumerable<PlayerData> AllPlayerData { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[PlayerData](Divine.Entity.Entities.Players.Components.PlayerData.md)\>

### <a id="Divine_Entity_Entities_Players_Player_Assists"></a> Assists

```csharp
public int Assists { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_BattleBonusRate"></a> BattleBonusRate

```csharp
public uint BattleBonusRate { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Players_Player_BuybackCooldownTime"></a> BuybackCooldownTime

```csharp
public float BuybackCooldownTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Players_Player_BuybackCostTime"></a> BuybackCostTime

```csharp
public float BuybackCostTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Players_Player_BuybackGoldLimitTime"></a> BuybackGoldLimitTime

```csharp
public float BuybackGoldLimitTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Players_Player_CampsStacked"></a> CampsStacked

```csharp
public int CampsStacked { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_CanBuyback"></a> CanBuyback

```csharp
public bool CanBuyback { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_CanRepick"></a> CanRepick

```csharp
public bool CanRepick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_ClaimedDenyCount"></a> ClaimedDenyCount

```csharp
public int ClaimedDenyCount { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_ClaimedMissCount"></a> ClaimedMissCount

```csharp
public int ClaimedMissCount { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_Color"></a> Color

```csharp
public Color Color { get; }
```

#### Property Value

 [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Entity_Entities_Players_Player_CompendiumLevel"></a> CompendiumLevel

```csharp
public ushort CompendiumLevel { get; }
```

#### Property Value

 [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

### <a id="Divine_Entity_Entities_Players_Player_ConnectionState"></a> ConnectionState

```csharp
public ConnectionState ConnectionState { get; }
```

#### Property Value

 [ConnectionState](Divine.Entity.Entities.Players.Components.ConnectionState.md)

### <a id="Divine_Entity_Entities_Players_Player_CreepKillGold"></a> CreepKillGold

```csharp
public int CreepKillGold { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_CreepsStacked"></a> CreepsStacked

```csharp
public int CreepsStacked { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_CustomBuybackCooldown"></a> CustomBuybackCooldown

```csharp
public float CustomBuybackCooldown { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Players_Player_Deaths"></a> Deaths

```csharp
public int Deaths { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_DenyCount"></a> DenyCount

```csharp
public int DenyCount { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_Gold"></a> Gold

```csharp
public int Gold { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_GoldSpentOnSupport"></a> GoldSpentOnSupport

```csharp
public int GoldSpentOnSupport { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_HasRandomed"></a> HasRandomed

```csharp
public bool HasRandomed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Healing"></a> Healing

```csharp
public float Healing { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Players_Player_Hero"></a> Hero

```csharp
public Hero? Hero { get; }
```

#### Property Value

 [Hero](Divine.Entity.Entities.Units.Heroes.Hero.md)?

### <a id="Divine_Entity_Entities_Players_Player_HeroDamage"></a> HeroDamage

```csharp
[Obsolete("This removed by Valve (11.11.2025)")]
public int HeroDamage { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_HeroKillGold"></a> HeroKillGold

```csharp
public int HeroKillGold { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_Id"></a> Id

```csharp
public int Id { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_IncomeGold"></a> IncomeGold

```csharp
public int IncomeGold { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_IsAFK"></a> IsAFK

```csharp
public bool IsAFK { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_IsBattleBonusActive"></a> IsBattleBonusActive

```csharp
public bool IsBattleBonusActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_IsBroadcaster"></a> IsBroadcaster

```csharp
public bool IsBroadcaster { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_IsFakeClient"></a> IsFakeClient

```csharp
public bool IsFakeClient { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_IsFullyJoinedServer"></a> IsFullyJoinedServer

```csharp
public bool IsFullyJoinedServer { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_IsPredictingVictory"></a> IsPredictingVictory

```csharp
public bool IsPredictingVictory { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_IsSpectator"></a> IsSpectator

```csharp
public bool IsSpectator { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_IsVoiceChatBanned"></a> IsVoiceChatBanned

```csharp
[Obsolete("Removed by Valve")]
public bool IsVoiceChatBanned { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Kills"></a> Kills

```csharp
public int Kills { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_KillStreak"></a> KillStreak

```csharp
public int KillStreak { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_LastBuybackTime"></a> LastBuybackTime

```csharp
public float LastBuybackTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Players_Player_LastHitCount"></a> LastHitCount

```csharp
public int LastHitCount { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_LastHitMultikill"></a> LastHitMultikill

```csharp
public int LastHitMultikill { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_LastHitStreak"></a> LastHitStreak

```csharp
public int LastHitStreak { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_Level"></a> Level

```csharp
public int Level { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_MissCount"></a> MissCount

```csharp
public int MissCount { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_Name"></a> Name

```csharp
public override string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Players_Player_NearbyCreepDeathCount"></a> NearbyCreepDeathCount

```csharp
public int NearbyCreepDeathCount { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_ObserverWardsPlaced"></a> ObserverWardsPlaced

```csharp
public int ObserverWardsPlaced { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_PlayerData"></a> PlayerData

```csharp
public PlayerData? PlayerData { get; }
```

#### Property Value

 [PlayerData](Divine.Entity.Entities.Players.Components.PlayerData.md)?

### <a id="Divine_Entity_Entities_Players_Player_PlayerSteamId"></a> PlayerSteamId

```csharp
[Obsolete("Use SteamId")]
public uint PlayerSteamId { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Players_Player_QueryUnit"></a> QueryUnit

```csharp
public Entity? QueryUnit { get; }
```

#### Property Value

 [Entity](Divine.Entity.Entities.Entity.md)?

### <a id="Divine_Entity_Entities_Players_Player_QuickBuySlots"></a> QuickBuySlots

```csharp
public IEnumerable<QuickBuySlot> QuickBuySlots { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[QuickBuySlot](Divine.Entity.Entities.Players.Components.QuickBuySlot.md)\>

### <a id="Divine_Entity_Entities_Players_Player_ReliableGold"></a> ReliableGold

```csharp
public int ReliableGold { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_RespawnSeconds"></a> RespawnSeconds

```csharp
public int RespawnSeconds { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_RoshanKills"></a> RoshanKills

```csharp
public int RoshanKills { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_RunePickups"></a> RunePickups

```csharp
public int RunePickups { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_SelectedHeroId"></a> SelectedHeroId

```csharp
public HeroId SelectedHeroId { get; }
```

#### Property Value

 [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)

### <a id="Divine_Entity_Entities_Players_Player_SelectedUnits"></a> SelectedUnits

```csharp
public IEnumerable<Unit> SelectedUnits { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Unit](Divine.Entity.Entities.Units.Unit.md)\>

### <a id="Divine_Entity_Entities_Players_Player_SentryWardsPlaced"></a> SentryWardsPlaced

```csharp
public int SentryWardsPlaced { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_SharedGold"></a> SharedGold

```csharp
public int SharedGold { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_SteamId"></a> SteamId

```csharp
public uint SteamId { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Players_Player_StickyItemSlot"></a> StickyItemSlot

```csharp
public QuickBuySlot? StickyItemSlot { get; }
```

#### Property Value

 [QuickBuySlot](Divine.Entity.Entities.Players.Components.QuickBuySlot.md)?

### <a id="Divine_Entity_Entities_Players_Player_Stuns"></a> Stuns

```csharp
public float Stuns { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Players_Player_TeamSlot"></a> TeamSlot

```csharp
public int TeamSlot { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_TotalEarnedGold"></a> TotalEarnedGold

```csharp
public int TotalEarnedGold { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_TotalEarnedXP"></a> TotalEarnedXP

```csharp
public int TotalEarnedXP { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_TowerKills"></a> TowerKills

```csharp
public int TowerKills { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_UnreliableGold"></a> UnreliableGold

```csharp
public int UnreliableGold { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_WardsDestroyed"></a> WardsDestroyed

```csharp
public int WardsDestroyed { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Player_WardsPurchased"></a> WardsPurchased

```csharp
public int WardsPurchased { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Entity_Entities_Players_Player_Announce_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_"></a> Announce\(Unit, Ability\)

```csharp
public static bool Announce(Unit unit, Ability ability)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Attack_System_Collections_Generic_IEnumerable_Divine_Entity_Entities_Units_Unit__System_Numerics_Vector3_"></a> Attack\(IEnumerable<Unit\>, Vector3\)

```csharp
public static bool Attack(IEnumerable<Unit> units, Vector3 position)
```

#### Parameters

`units` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Unit](Divine.Entity.Entities.Units.Unit.md)\>

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Attack_System_Collections_Generic_IEnumerable_Divine_Entity_Entities_Units_Unit__System_Numerics_Vector3_System_Boolean_"></a> Attack\(IEnumerable<Unit\>, Vector3, bool\)

```csharp
public static bool Attack(IEnumerable<Unit> units, Vector3 position, bool queued)
```

#### Parameters

`units` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Unit](Divine.Entity.Entities.Units.Unit.md)\>

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Attack_System_Collections_Generic_IEnumerable_Divine_Entity_Entities_Units_Unit__Divine_Entity_Entities_Units_Unit_"></a> Attack\(IEnumerable<Unit\>, Unit\)

```csharp
public static bool Attack(IEnumerable<Unit> units, Unit target)
```

#### Parameters

`units` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Unit](Divine.Entity.Entities.Units.Unit.md)\>

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Attack_System_Collections_Generic_IEnumerable_Divine_Entity_Entities_Units_Unit__Divine_Entity_Entities_Units_Unit_System_Boolean_"></a> Attack\(IEnumerable<Unit\>, Unit, bool\)

```csharp
public static bool Attack(IEnumerable<Unit> units, Unit target, bool queued)
```

#### Parameters

`units` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Unit](Divine.Entity.Entities.Units.Unit.md)\>

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Attack_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_PhysicalItems_PhysicalItem_"></a> Attack\(Unit, PhysicalItem\)

```csharp
public static bool Attack(Unit unit, PhysicalItem target)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`target` [PhysicalItem](Divine.Entity.Entities.PhysicalItems.PhysicalItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Attack_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_PhysicalItems_PhysicalItem_System_Boolean_"></a> Attack\(Unit, PhysicalItem, bool\)

```csharp
public static bool Attack(Unit unit, PhysicalItem target, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`target` [PhysicalItem](Divine.Entity.Entities.PhysicalItems.PhysicalItem.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Attack_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Units_Unit_"></a> Attack\(Unit, Unit\)

```csharp
public static bool Attack(Unit unit, Unit target)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Attack_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Units_Unit_System_Boolean_"></a> Attack\(Unit, Unit, bool\)

```csharp
public static bool Attack(Unit unit, Unit target, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Attack_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_"></a> Attack\(Unit, Vector3\)

```csharp
public static bool Attack(Unit unit, Vector3 position)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Attack_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_System_Boolean_"></a> Attack\(Unit, Vector3, bool\)

```csharp
public static bool Attack(Unit unit, Vector3 position, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Buy_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Components_AbilityId_"></a> Buy\(Unit, AbilityId\)

```csharp
public static bool Buy(Unit unit, AbilityId abilityId)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Buyback"></a> Buyback\(\)

```csharp
public static bool Buyback()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_"></a> Cast\(Unit, Ability\)

```csharp
public static bool Cast(Unit unit, Ability ability)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_System_Boolean_"></a> Cast\(Unit, Ability, bool\)

```csharp
public static bool Cast(Unit unit, Ability ability, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_System_Boolean_System_Boolean_"></a> Cast\(Unit, Ability, bool, bool\)

```csharp
public static bool Cast(Unit unit, Ability ability, bool queued, bool bypassOrderAdding)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_System_Numerics_Vector3_"></a> Cast\(Unit, Ability, Vector3\)

```csharp
public static bool Cast(Unit unit, Ability ability, Vector3 position)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_System_Numerics_Vector3_System_Boolean_"></a> Cast\(Unit, Ability, Vector3, bool\)

```csharp
public static bool Cast(Unit unit, Ability ability, Vector3 position, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_System_Numerics_Vector3_System_Boolean_System_Boolean_"></a> Cast\(Unit, Ability, Vector3, bool, bool\)

```csharp
public static bool Cast(Unit unit, Ability ability, Vector3 position, bool queued, bool bypassOrderAdding)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_System_Numerics_Vector3_System_Numerics_Vector3_"></a> Cast\(Unit, Ability, Vector3, Vector3\)

```csharp
public static bool Cast(Unit unit, Ability ability, Vector3 startPosition, Vector3 endPosition)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`startPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_System_Numerics_Vector3_System_Numerics_Vector3_System_Boolean_"></a> Cast\(Unit, Ability, Vector3, Vector3, bool\)

```csharp
public static bool Cast(Unit unit, Ability ability, Vector3 startPosition, Vector3 endPosition, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`startPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_System_Numerics_Vector3_System_Numerics_Vector3_System_Boolean_System_Boolean_"></a> Cast\(Unit, Ability, Vector3, Vector3, bool, bool\)

```csharp
public static bool Cast(Unit unit, Ability ability, Vector3 startPosition, Vector3 endPosition, bool queued, bool bypassOrderAdding)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`startPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_Divine_Entity_Entities_Units_Unit_"></a> Cast\(Unit, Ability, Unit\)

```csharp
public static bool Cast(Unit unit, Ability ability, Unit target)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_Divine_Entity_Entities_Units_Unit_System_Boolean_"></a> Cast\(Unit, Ability, Unit, bool\)

```csharp
public static bool Cast(Unit unit, Ability ability, Unit target, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_Divine_Entity_Entities_Units_Unit_System_Boolean_System_Boolean_"></a> Cast\(Unit, Ability, Unit, bool, bool\)

```csharp
public static bool Cast(Unit unit, Ability ability, Unit target, bool queued, bool bypassOrderAdding)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_"></a> Cast\(Unit, Ability, Unit, Vector3\)

```csharp
public static bool Cast(Unit unit, Ability ability, Unit startTarget, Vector3 endPosition)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`startTarget` [Unit](Divine.Entity.Entities.Units.Unit.md)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_System_Boolean_"></a> Cast\(Unit, Ability, Unit, Vector3, bool\)

```csharp
public static bool Cast(Unit unit, Ability ability, Unit startTarget, Vector3 endPosition, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`startTarget` [Unit](Divine.Entity.Entities.Units.Unit.md)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_System_Boolean_System_Boolean_"></a> Cast\(Unit, Ability, Unit, Vector3, bool, bool\)

```csharp
public static bool Cast(Unit unit, Ability ability, Unit startTarget, Vector3 endPosition, bool queued, bool bypassOrderAdding)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`startTarget` [Unit](Divine.Entity.Entities.Units.Unit.md)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_Divine_Entity_Entities_Runes_Rune_"></a> Cast\(Unit, Ability, Rune\)

```csharp
public static bool Cast(Unit unit, Ability ability, Rune target)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`target` [Rune](Divine.Entity.Entities.Runes.Rune.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_Divine_Entity_Entities_Runes_Rune_System_Boolean_"></a> Cast\(Unit, Ability, Rune, bool\)

```csharp
public static bool Cast(Unit unit, Ability ability, Rune target, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`target` [Rune](Divine.Entity.Entities.Runes.Rune.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_Divine_Entity_Entities_Runes_Rune_System_Boolean_System_Boolean_"></a> Cast\(Unit, Ability, Rune, bool, bool\)

```csharp
public static bool Cast(Unit unit, Ability ability, Rune target, bool queued, bool bypassOrderAdding)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`target` [Rune](Divine.Entity.Entities.Runes.Rune.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_Divine_Entity_Entities_Trees_Tree_"></a> Cast\(Unit, Ability, Tree\)

```csharp
public static bool Cast(Unit unit, Ability ability, Tree target)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`target` [Tree](Divine.Entity.Entities.Trees.Tree.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_Divine_Entity_Entities_Trees_Tree_System_Boolean_"></a> Cast\(Unit, Ability, Tree, bool\)

```csharp
public static bool Cast(Unit unit, Ability ability, Tree target, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`target` [Tree](Divine.Entity.Entities.Trees.Tree.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Cast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_Divine_Entity_Entities_Trees_Tree_System_Boolean_System_Boolean_"></a> Cast\(Unit, Ability, Tree, bool, bool\)

```csharp
public static bool Cast(Unit unit, Ability ability, Tree target, bool queued, bool bypassOrderAdding)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`target` [Tree](Divine.Entity.Entities.Trees.Tree.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_CastToggle_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_"></a> CastToggle\(Unit, Ability\)

```csharp
public static bool CastToggle(Unit unit, Ability ability)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_CastToggle_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_System_Boolean_"></a> CastToggle\(Unit, Ability, bool\)

```csharp
public static bool CastToggle(Unit unit, Ability ability, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_CastToggle_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_System_Boolean_System_Boolean_"></a> CastToggle\(Unit, Ability, bool, bool\)

```csharp
public static bool CastToggle(Unit unit, Ability ability, bool queued, bool bypassOrderAdding)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_CastToggleAutocast_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_"></a> CastToggleAutocast\(Unit, Ability\)

```csharp
public static bool CastToggleAutocast(Unit unit, Ability ability)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_CombineLock_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Items_Item_"></a> CombineLock\(Unit, Item\)

```csharp
public static bool CombineLock(Unit unit, Item item)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`item` [Item](Divine.Entity.Entities.Abilities.Items.Item.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_CombineUnlock_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Items_Item_"></a> CombineUnlock\(Unit, Item\)

```csharp
public static bool CombineUnlock(Unit unit, Item item)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`item` [Item](Divine.Entity.Entities.Abilities.Items.Item.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Disassemble_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Items_Item_"></a> Disassemble\(Unit, Item\)

```csharp
public static bool Disassemble(Unit unit, Item item)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`item` [Item](Divine.Entity.Entities.Abilities.Items.Item.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Drop_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Items_Item_System_Numerics_Vector3_"></a> Drop\(Unit, Item, Vector3\)

```csharp
public static bool Drop(Unit unit, Item item, Vector3 position)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`item` [Item](Divine.Entity.Entities.Abilities.Items.Item.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Drop_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Items_Item_System_Numerics_Vector3_System_Boolean_"></a> Drop\(Unit, Item, Vector3, bool\)

```csharp
public static bool Drop(Unit unit, Item item, Vector3 position, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`item` [Item](Divine.Entity.Entities.Abilities.Items.Item.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_DropFromStash_Divine_Entity_Entities_Abilities_Items_Item_"></a> DropFromStash\(Item\)

```csharp
public static bool DropFromStash(Item item)
```

#### Parameters

`item` [Item](Divine.Entity.Entities.Abilities.Items.Item.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Follow_System_Collections_Generic_IEnumerable_Divine_Entity_Entities_Units_Unit__Divine_Entity_Entities_Units_Unit_"></a> Follow\(IEnumerable<Unit\>, Unit\)

```csharp
public static bool Follow(IEnumerable<Unit> units, Unit target)
```

#### Parameters

`units` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Unit](Divine.Entity.Entities.Units.Unit.md)\>

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Follow_System_Collections_Generic_IEnumerable_Divine_Entity_Entities_Units_Unit__Divine_Entity_Entities_Units_Unit_System_Boolean_"></a> Follow\(IEnumerable<Unit\>, Unit, bool\)

```csharp
public static bool Follow(IEnumerable<Unit> units, Unit target, bool queued)
```

#### Parameters

`units` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Unit](Divine.Entity.Entities.Units.Unit.md)\>

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Follow_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Units_Unit_"></a> Follow\(Unit, Unit\)

```csharp
public static bool Follow(Unit unit, Unit target)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Follow_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Units_Unit_System_Boolean_"></a> Follow\(Unit, Unit, bool\)

```csharp
public static bool Follow(Unit unit, Unit target, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_GetPlayerDataById_System_Int32_"></a> GetPlayerDataById\(int\)

```csharp
public static PlayerData? GetPlayerDataById(int playerId)
```

#### Parameters

`playerId` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [PlayerData](Divine.Entity.Entities.Players.Components.PlayerData.md)?

### <a id="Divine_Entity_Entities_Players_Player_Give_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Items_Item_Divine_Entity_Entities_Units_Unit_"></a> Give\(Unit, Item, Unit\)

```csharp
public static bool Give(Unit unit, Item item, Unit target)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`item` [Item](Divine.Entity.Entities.Abilities.Items.Item.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Give_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Items_Item_Divine_Entity_Entities_Units_Unit_System_Boolean_"></a> Give\(Unit, Item, Unit, bool\)

```csharp
public static bool Give(Unit unit, Item item, Unit target, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`item` [Item](Divine.Entity.Entities.Abilities.Items.Item.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Glyph"></a> Glyph\(\)

```csharp
public static bool Glyph()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_HiddenDrop_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Items_Item_"></a> HiddenDrop\(Unit, Item\)

```csharp
public static bool HiddenDrop(Unit unit, Item item)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`item` [Item](Divine.Entity.Entities.Abilities.Items.Item.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_HiddenDrop_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Items_Item_System_Boolean_"></a> HiddenDrop\(Unit, Item, bool\)

```csharp
public static bool HiddenDrop(Unit unit, Item item, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`item` [Item](Divine.Entity.Entities.Abilities.Items.Item.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Hold_System_Collections_Generic_IEnumerable_Divine_Entity_Entities_Units_Unit__"></a> Hold\(IEnumerable<Unit\>\)

```csharp
public static bool Hold(IEnumerable<Unit> units)
```

#### Parameters

`units` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Unit](Divine.Entity.Entities.Units.Unit.md)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Hold_System_Collections_Generic_IEnumerable_Divine_Entity_Entities_Units_Unit__System_Boolean_"></a> Hold\(IEnumerable<Unit\>, bool\)

```csharp
public static bool Hold(IEnumerable<Unit> units, bool queued)
```

#### Parameters

`units` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Unit](Divine.Entity.Entities.Units.Unit.md)\>

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Hold_Divine_Entity_Entities_Units_Unit_"></a> Hold\(Unit\)

```csharp
public static bool Hold(Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Hold_Divine_Entity_Entities_Units_Unit_System_Boolean_"></a> Hold\(Unit, bool\)

```csharp
public static bool Hold(Unit unit, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Move_System_Collections_Generic_IEnumerable_Divine_Entity_Entities_Units_Unit__System_Numerics_Vector3_"></a> Move\(IEnumerable<Unit\>, Vector3\)

```csharp
public static bool Move(IEnumerable<Unit> units, Vector3 position)
```

#### Parameters

`units` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Unit](Divine.Entity.Entities.Units.Unit.md)\>

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Move_System_Collections_Generic_IEnumerable_Divine_Entity_Entities_Units_Unit__System_Numerics_Vector3_System_Boolean_"></a> Move\(IEnumerable<Unit\>, Vector3, bool\)

```csharp
public static bool Move(IEnumerable<Unit> units, Vector3 position, bool queued)
```

#### Parameters

`units` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Unit](Divine.Entity.Entities.Units.Unit.md)\>

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Move_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Items_Item_Divine_Entity_Entities_Abilities_Items_Components_ItemSlot_"></a> Move\(Unit, Item, ItemSlot\)

```csharp
public static bool Move(Unit unit, Item item, ItemSlot itemSlot)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`item` [Item](Divine.Entity.Entities.Abilities.Items.Item.md)

`itemSlot` [ItemSlot](Divine.Entity.Entities.Abilities.Items.Components.ItemSlot.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Move_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_"></a> Move\(Unit, Vector3\)

```csharp
public static bool Move(Unit unit, Vector3 position)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Move_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_System_Boolean_"></a> Move\(Unit, Vector3, bool\)

```csharp
public static bool Move(Unit unit, Vector3 position, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Move_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_System_Boolean_System_Boolean_"></a> Move\(Unit, Vector3, bool, bool\)

```csharp
public static bool Move(Unit unit, Vector3 position, bool queued, bool bypassOrderAdding)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_MoveToDirection_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_"></a> MoveToDirection\(Unit, Vector3\)

```csharp
public static bool MoveToDirection(Unit unit, Vector3 position)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_MoveToDirection_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_System_Boolean_"></a> MoveToDirection\(Unit, Vector3, bool\)

```csharp
public static bool MoveToDirection(Unit unit, Vector3 position, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Patrol_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_"></a> Patrol\(Unit, Vector3\)

```csharp
public static bool Patrol(Unit unit, Vector3 position)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Patrol_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_System_Boolean_"></a> Patrol\(Unit, Vector3, bool\)

```csharp
public static bool Patrol(Unit unit, Vector3 position, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_PickUp_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_PhysicalItems_PhysicalItem_"></a> PickUp\(Unit, PhysicalItem\)

```csharp
public static bool PickUp(Unit unit, PhysicalItem physicalItem)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`physicalItem` [PhysicalItem](Divine.Entity.Entities.PhysicalItems.PhysicalItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_PickUp_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_PhysicalItems_PhysicalItem_System_Boolean_"></a> PickUp\(Unit, PhysicalItem, bool\)

```csharp
public static bool PickUp(Unit unit, PhysicalItem physicalItem, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`physicalItem` [PhysicalItem](Divine.Entity.Entities.PhysicalItems.PhysicalItem.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_PickUp_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Runes_Rune_"></a> PickUp\(Unit, Rune\)

```csharp
public static bool PickUp(Unit unit, Rune rune)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`rune` [Rune](Divine.Entity.Entities.Runes.Rune.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_PickUp_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Runes_Rune_System_Boolean_"></a> PickUp\(Unit, Rune, bool\)

```csharp
public static bool PickUp(Unit unit, Rune rune, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`rune` [Rune](Divine.Entity.Entities.Runes.Rune.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Scan_System_Numerics_Vector3_"></a> Scan\(Vector3\)

```csharp
public static bool Scan(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Select_Divine_Entity_Entities_Entity_"></a> Select\(Entity\)

```csharp
public static bool Select(Entity entity)
```

#### Parameters

`entity` [Entity](Divine.Entity.Entities.Entity.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Select_Divine_Entity_Entities_Entity_System_Boolean_"></a> Select\(Entity, bool\)

```csharp
public static bool Select(Entity entity, bool addToCurrentSelection)
```

#### Parameters

`entity` [Entity](Divine.Entity.Entities.Entity.md)

`addToCurrentSelection` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Sell_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Items_Item_"></a> Sell\(Unit, Item\)

```csharp
public static bool Sell(Unit unit, Item item)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`item` [Item](Divine.Entity.Entities.Abilities.Items.Item.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Stop_System_Collections_Generic_IEnumerable_Divine_Entity_Entities_Units_Unit__"></a> Stop\(IEnumerable<Unit\>\)

```csharp
public static bool Stop(IEnumerable<Unit> units)
```

#### Parameters

`units` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Unit](Divine.Entity.Entities.Units.Unit.md)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Stop_System_Collections_Generic_IEnumerable_Divine_Entity_Entities_Units_Unit__System_Boolean_"></a> Stop\(IEnumerable<Unit\>, bool\)

```csharp
public static bool Stop(IEnumerable<Unit> units, bool queued)
```

#### Parameters

`units` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Unit](Divine.Entity.Entities.Units.Unit.md)\>

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Stop_Divine_Entity_Entities_Units_Unit_"></a> Stop\(Unit\)

```csharp
public static bool Stop(Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Stop_Divine_Entity_Entities_Units_Unit_System_Boolean_"></a> Stop\(Unit, bool\)

```csharp
public static bool Stop(Unit unit, bool queued)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Stop_Divine_Entity_Entities_Units_Unit_System_Boolean_System_Boolean_"></a> Stop\(Unit, bool, bool\)

```csharp
public static bool Stop(Unit unit, bool queued, bool bypassOrderAdding)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Player_Upgrade_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Ability_"></a> Upgrade\(Unit, Ability\)

```csharp
public static bool Upgrade(Unit unit, Ability ability)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

