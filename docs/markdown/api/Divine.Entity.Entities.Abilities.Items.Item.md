# <a id="Divine_Entity_Entities_Abilities_Items_Item"></a> Class Item

Namespace: [Divine.Entity.Entities.Abilities.Items](Divine.Entity.Entities.Abilities.Items.md)  
Assembly: Divine.dll  

```csharp
public class Item : Ability, IEquatable<Entity>, INative
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Divine.Entity.Entities.Entity.md) ← 
[Ability](Divine.Entity.Entities.Abilities.Ability.md) ← 
[Item](Divine.Entity.Entities.Abilities.Items.Item.md)

#### Derived

[Bottle](Divine.Entity.Entities.Abilities.Items.Bottle.md), 
[KeenOptic](Divine.Entity.Entities.Abilities.Items.Neutrals.KeenOptic.md), 
[PowerTreads](Divine.Entity.Entities.Abilities.Items.PowerTreads.md), 
[Vambrace](Divine.Entity.Entities.Abilities.Items.Vambrace.md)

#### Implements

[IEquatable<Entity\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[INative](Divine.Memory.INative.md)

#### Inherited Members

[Ability.AllKeyValues](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_AllKeyValues), 
[Ability.GetKeyValueById\(AbilityId\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_GetKeyValueById\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_), 
[Ability.GetKeyValueByName\(string\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_GetKeyValueByName\_System\_String\_), 
[Ability.GetKeyValueByName\(ReadOnlySpan<byte\>\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_GetKeyValueByName\_System\_ReadOnlySpan\_System\_Byte\_\_), 
[Ability.GetAbilityDataByIndex\(ushort\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_GetAbilityDataByIndex\_System\_UInt16\_), 
[Ability.GetAbilityDataById\(AbilityId\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_GetAbilityDataById\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_), 
[Ability.GetAbilityDataByName\(string\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_GetAbilityDataByName\_System\_String\_), 
[Ability.GetAbilityIndexById\(AbilityId\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_GetAbilityIndexById\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_), 
[Ability.GetAbilityIndexByName\(string\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_GetAbilityIndexByName\_System\_String\_), 
[Ability.GetAbilityIdByName\(string\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_GetAbilityIdByName\_System\_String\_), 
[Ability.GetAbilityNameById\(AbilityId\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_GetAbilityNameById\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_), 
[Ability.Name](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Name), 
[Ability.HasAltCastState](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_HasAltCastState), 
[Ability.EnemyLevel](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_EnemyLevel), 
[Ability.IsReplicated](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_IsReplicated), 
[Ability.IsHidden](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_IsHidden), 
[Ability.IsActivated](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_IsActivated), 
[Ability.IsStolen](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_IsStolen), 
[Ability.Level](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Level), 
[Ability.IsToggled](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_IsToggled), 
[Ability.IsCooldownFrozen](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_IsCooldownFrozen), 
[Ability.IsInAbilityPhase](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_IsInAbilityPhase), 
[Ability.Cooldown](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cooldown), 
[Ability.CooldownInFog](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_CooldownInFog), 
[Ability.CooldownLength](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_CooldownLength), 
[Ability.ManaCost](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_ManaCost), 
[Ability.IsAutoCastEnabled](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_IsAutoCastEnabled), 
[Ability.ChannelTime](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_ChannelTime), 
[Ability.IsInIndefiniteCooldown](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_IsInIndefiniteCooldown), 
[Ability.OverrideCastPoint](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_OverrideCastPoint), 
[Ability.LastCastClickTime](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_LastCastClickTime), 
[Ability.ChannelStartTime](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_ChannelStartTime), 
[Ability.ChargeRestoreTimeRemaining](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_ChargeRestoreTimeRemaining), 
[Ability.CurrentCharges](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_CurrentCharges), 
[Ability.CastStartTime](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_CastStartTime), 
[Ability.MaximumLevel](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_MaximumLevel), 
[Ability.TextureName](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_TextureName), 
[Ability.SharedCooldownName](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_SharedCooldownName), 
[Ability.NetworkActivity](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_NetworkActivity), 
[Ability.Id](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Id), 
[Ability.AbilityType](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_AbilityType), 
[Ability.AbilityBehavior](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_AbilityBehavior), 
[Ability.TargetTeamType](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_TargetTeamType), 
[Ability.TargetFlags](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_TargetFlags), 
[Ability.TargetType](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_TargetType), 
[Ability.DamageType](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_DamageType), 
[Ability.SpellPierceImmunityType](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_SpellPierceImmunityType), 
[Ability.DispellableType](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_DispellableType), 
[Ability.IsGrantedByScepter](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_IsGrantedByScepter), 
[Ability.RequiredLevel](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_RequiredLevel), 
[Ability.AbilityIndex](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_AbilityIndex), 
[Ability.LevelsBeetweenUpgrades](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_LevelsBeetweenUpgrades), 
[Ability.NeutralTierIndex](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_NeutralTierIndex), 
[Ability.KeyValue](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_KeyValue), 
[Ability.AbilityState](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_AbilityState), 
[Ability.AbilityData](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_AbilityData), 
[Ability.AbilitySpecialData](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_AbilitySpecialData), 
[Ability.IsChanneling](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_IsChanneling), 
[Ability.AbilitySlot](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_AbilitySlot), 
[Ability.CastPoint](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_CastPoint), 
[Ability.ChannelMaximumTime](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_ChannelMaximumTime), 
[Ability.Damage](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Damage), 
[Ability.CastRange](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_CastRange), 
[Ability.BaseCastRange](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_BaseCastRange), 
[Ability.Duration](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Duration), 
[Ability.Charges](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Charges), 
[Ability.ChargeRestoreTime](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_ChargeRestoreTime), 
[Ability.IsInnate](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_IsInnate), 
[Ability.Cast\(\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast), 
[Ability.Cast\(bool\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_System\_Boolean\_), 
[Ability.Cast\(bool, bool\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_System\_Boolean\_System\_Boolean\_), 
[Ability.Cast\(Vector3\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_System\_Numerics\_Vector3\_), 
[Ability.Cast\(Vector3, bool\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_System\_Numerics\_Vector3\_System\_Boolean\_), 
[Ability.Cast\(Vector3, bool, bool\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_System\_Numerics\_Vector3\_System\_Boolean\_System\_Boolean\_), 
[Ability.Cast\(Vector3, Vector3\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_System\_Numerics\_Vector3\_System\_Numerics\_Vector3\_), 
[Ability.Cast\(Vector3, Vector3, bool\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_System\_Numerics\_Vector3\_System\_Numerics\_Vector3\_System\_Boolean\_), 
[Ability.Cast\(Vector3, Vector3, bool, bool\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_System\_Numerics\_Vector3\_System\_Numerics\_Vector3\_System\_Boolean\_System\_Boolean\_), 
[Ability.Cast\(Unit\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[Ability.Cast\(Unit, bool\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Boolean\_), 
[Ability.Cast\(Unit, bool, bool\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Boolean\_System\_Boolean\_), 
[Ability.Cast\(Unit, Vector3\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Numerics\_Vector3\_), 
[Ability.Cast\(Unit, Vector3, bool\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Numerics\_Vector3\_System\_Boolean\_), 
[Ability.Cast\(Unit, Vector3, bool, bool\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Numerics\_Vector3\_System\_Boolean\_System\_Boolean\_), 
[Ability.Cast\(Rune\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_Divine\_Entity\_Entities\_Runes\_Rune\_), 
[Ability.Cast\(Rune, bool\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_Divine\_Entity\_Entities\_Runes\_Rune\_System\_Boolean\_), 
[Ability.Cast\(Rune, bool, bool\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_Divine\_Entity\_Entities\_Runes\_Rune\_System\_Boolean\_System\_Boolean\_), 
[Ability.Cast\(Tree\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_Divine\_Entity\_Entities\_Trees\_Tree\_), 
[Ability.Cast\(Tree, bool\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_Divine\_Entity\_Entities\_Trees\_Tree\_System\_Boolean\_), 
[Ability.Cast\(Tree, bool, bool\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Cast\_Divine\_Entity\_Entities\_Trees\_Tree\_System\_Boolean\_System\_Boolean\_), 
[Ability.CastToggle\(\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_CastToggle), 
[Ability.CastToggle\(bool\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_CastToggle\_System\_Boolean\_), 
[Ability.CastToggle\(bool, bool\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_CastToggle\_System\_Boolean\_System\_Boolean\_), 
[Ability.CastToggleAutocast\(\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_CastToggleAutocast), 
[Ability.Upgrade\(\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Upgrade), 
[Ability.Announce\(\)](Divine.Entity.Entities.Abilities.Ability.md\#Divine\_Entity\_Entities\_Abilities\_Ability\_Announce), 
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
[AbilityExtensions.GetAbilitySlotInfo\(Ability\)](Divine.Extensions.AbilityExtensions.md\#Divine\_Extensions\_AbilityExtensions\_GetAbilitySlotInfo\_Divine\_Entity\_Entities\_Abilities\_Ability\_), 
[AbilityExtensions.GetAbilitySpecialData\(Ability, string\)](Divine.Extensions.AbilityExtensions.md\#Divine\_Extensions\_AbilityExtensions\_GetAbilitySpecialData\_Divine\_Entity\_Entities\_Abilities\_Ability\_System\_String\_), 
[AbilityExtensions.GetAbilitySpecialData\(Ability, string, uint\)](Divine.Extensions.AbilityExtensions.md\#Divine\_Extensions\_AbilityExtensions\_GetAbilitySpecialData\_Divine\_Entity\_Entities\_Abilities\_Ability\_System\_String\_System\_UInt32\_), 
[AbilityExtensions.GetAbilitySpecialDataValue\(Ability, string, uint\)](Divine.Extensions.AbilityExtensions.md\#Divine\_Extensions\_AbilityExtensions\_GetAbilitySpecialDataValue\_Divine\_Entity\_Entities\_Abilities\_Ability\_System\_String\_System\_UInt32\_), 
[AbilityExtensions.GetAbilitySpecialDataWithTalent\(Ability, Unit, string, uint\)](Divine.Extensions.AbilityExtensions.md\#Divine\_Extensions\_AbilityExtensions\_GetAbilitySpecialDataWithTalent\_Divine\_Entity\_Entities\_Abilities\_Ability\_Divine\_Entity\_Entities\_Units\_Unit\_System\_String\_System\_UInt32\_), 
[AbilityExtensions.GetAbilitySpecialDataWithTalent\(Ability, Unit, string, AbilityId, uint\)](Divine.Extensions.AbilityExtensions.md\#Divine\_Extensions\_AbilityExtensions\_GetAbilitySpecialDataWithTalent\_Divine\_Entity\_Entities\_Abilities\_Ability\_Divine\_Entity\_Entities\_Units\_Unit\_System\_String\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_System\_UInt32\_), 
[AbilityExtensions.GetCastPoint\(Ability\)](Divine.Extensions.AbilityExtensions.md\#Divine\_Extensions\_AbilityExtensions\_GetCastPoint\_Divine\_Entity\_Entities\_Abilities\_Ability\_), 
[EnumerableExtensions.In<Item\>\(Item, params Item\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
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

### <a id="Divine_Entity_Entities_Abilities_Items_Item_AssembledTime"></a> AssembledTime

```csharp
public float AssembledTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_CanBeUsedOutOfInventory"></a> CanBeUsedOutOfInventory

```csharp
public bool CanBeUsedOutOfInventory { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_Cost"></a> Cost

```csharp
public uint Cost { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_CurrentCharges"></a> CurrentCharges

```csharp
public override uint CurrentCharges { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_EffectName"></a> EffectName

```csharp
public string EffectName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_EnableTime"></a> EnableTime

```csharp
public float EnableTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_InitialCharges"></a> InitialCharges

```csharp
public uint InitialCharges { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsAlertable"></a> IsAlertable

```csharp
public bool IsAlertable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsCastedOnPickup"></a> IsCastedOnPickup

```csharp
public bool IsCastedOnPickup { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsCombinable"></a> IsCombinable

```csharp
public bool IsCombinable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsCombineLocked"></a> IsCombineLocked

```csharp
public bool IsCombineLocked { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsDisassemblable"></a> IsDisassemblable

```csharp
public bool IsDisassemblable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsDisplayingCharges"></a> IsDisplayingCharges

```csharp
public bool IsDisplayingCharges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsDroppable"></a> IsDroppable

```csharp
public bool IsDroppable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsEnabled"></a> IsEnabled

```csharp
public bool IsEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsHidingCharges"></a> IsHidingCharges

```csharp
public bool IsHidingCharges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsInBaseShopAvailable"></a> IsInBaseShopAvailable

```csharp
[Obsolete("TODO")]
public bool IsInBaseShopAvailable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsInSecretShopAvailable"></a> IsInSecretShopAvailable

```csharp
[Obsolete("TODO")]
public bool IsInSecretShopAvailable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsInSideShopAvailable"></a> IsInSideShopAvailable

```csharp
[Obsolete("TODO")]
public bool IsInSideShopAvailable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsKillable"></a> IsKillable

```csharp
public bool IsKillable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsNeutralActiveDrop"></a> IsNeutralActiveDrop

```csharp
public bool IsNeutralActiveDrop { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsNeutralDrop"></a> IsNeutralDrop

```csharp
[Obsolete("This removed by valve! try use IsNeutralActiveDrop or IsNeutralPassiveDrop")]
public bool IsNeutralDrop { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsNeutralPassiveDrop"></a> IsNeutralPassiveDrop

```csharp
public bool IsNeutralPassiveDrop { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsPermanent"></a> IsPermanent

```csharp
public bool IsPermanent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsPurchasable"></a> IsPurchasable

```csharp
public bool IsPurchasable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsPurchasedWhileDead"></a> IsPurchasedWhileDead

```csharp
public bool IsPurchasedWhileDead { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsRecipe"></a> IsRecipe

```csharp
public bool IsRecipe { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsRequiringCharges"></a> IsRequiringCharges

```csharp
public bool IsRequiringCharges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsSellable"></a> IsSellable

```csharp
public bool IsSellable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_IsStackable"></a> IsStackable

```csharp
public bool IsStackable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_ItemId"></a> ItemId

```csharp
public ItemId ItemId { get; }
```

#### Property Value

 [ItemId](Divine.Entity.Entities.Abilities.Items.Components.ItemId.md)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_ItemRecipeName"></a> ItemRecipeName

```csharp
public string ItemRecipeName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_ModelName"></a> ModelName

```csharp
public string ModelName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_NeutralDropTeam"></a> NeutralDropTeam

```csharp
public Team NeutralDropTeam { get; }
```

#### Property Value

 [Team](Divine.Entity.Entities.Components.Team.md)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_OldOwner"></a> OldOwner

```csharp
public Entity? OldOwner { get; }
```

#### Property Value

 [Entity](Divine.Entity.Entities.Entity.md)?

### <a id="Divine_Entity_Entities_Abilities_Items_Item_Purchaser"></a> Purchaser

```csharp
public Player? Purchaser { get; }
```

#### Property Value

 [Player](Divine.Entity.Entities.Players.Player.md)?

### <a id="Divine_Entity_Entities_Abilities_Items_Item_PurchaserId"></a> PurchaserId

```csharp
public int PurchaserId { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_PurchaseTime"></a> PurchaseTime

```csharp
public float PurchaseTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_SecondaryCharges"></a> SecondaryCharges

```csharp
public uint SecondaryCharges { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_Shareability"></a> Shareability

```csharp
public Shareability Shareability { get; }
```

#### Property Value

 [Shareability](Divine.Entity.Entities.Abilities.Items.Components.Shareability.md)

## Methods

### <a id="Divine_Entity_Entities_Abilities_Items_Item_CombineLock"></a> CombineLock\(\)

```csharp
public bool CombineLock()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_CombineUnlock"></a> CombineUnlock\(\)

```csharp
public bool CombineUnlock()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_Disassemble"></a> Disassemble\(\)

```csharp
public bool Disassemble()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_DropFromStash"></a> DropFromStash\(\)

```csharp
public bool DropFromStash()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_HiddenDrop"></a> HiddenDrop\(\)

```csharp
public bool HiddenDrop()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_HiddenDrop_System_Boolean_"></a> HiddenDrop\(bool\)

```csharp
public bool HiddenDrop(bool queued)
```

#### Parameters

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_Move_Divine_Entity_Entities_Abilities_Items_Components_ItemSlot_"></a> Move\(ItemSlot\)

```csharp
public bool Move(ItemSlot itemSlot)
```

#### Parameters

`itemSlot` [ItemSlot](Divine.Entity.Entities.Abilities.Items.Components.ItemSlot.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Items_Item_Sell"></a> Sell\(\)

```csharp
public bool Sell()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

