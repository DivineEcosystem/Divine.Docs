# <a id="Divine_Entity_Entities_Units_Unit"></a> Class Unit

Namespace: [Divine.Entity.Entities.Units](Divine.Entity.Entities.Units.md)  
Assembly: Divine.dll  

```csharp
public class Unit : Entity, IEquatable<Entity>, INative
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Divine.Entity.Entities.Entity.md) ← 
[Unit](Divine.Entity.Entities.Units.Unit.md)

#### Derived

[Building](Divine.Entity.Entities.Units.Buildings.Building.md), 
[Courier](Divine.Entity.Entities.Units.Courier.md), 
[Creep](Divine.Entity.Entities.Units.Creeps.Creep.md), 
[Hero](Divine.Entity.Entities.Units.Heroes.Hero.md), 
[Roshan](Divine.Entity.Entities.Units.Roshan.md), 
[Ward](Divine.Entity.Entities.Units.Wards.Ward.md)

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

[UnitExtensions.AttackPoint\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_AttackPoint\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.AttackRange\(Unit, Unit?\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_AttackRange\_Divine\_Entity\_Entities\_Units\_Unit\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.AttackSpeedValue\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_AttackSpeedValue\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.CanAttack\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_CanAttack\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.CanAttack\(Unit, Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_CanAttack\_Divine\_Entity\_Entities\_Units\_Unit\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.Direction\(Unit, float\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_Direction\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Single\_), 
[UnitExtensions.Direction2D\(Unit, float\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_Direction2D\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Single\_), 
[EntityExtensions.Distance\(Entity, Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_Distance\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.Distance\(Entity, Vector3\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_Distance\_Divine\_Entity\_Entities\_Entity\_System\_Numerics\_Vector3\_), 
[EntityExtensions.Distance2D\(Unit, Unit, bool\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_Distance2D\_Divine\_Entity\_Entities\_Units\_Unit\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Boolean\_), 
[EntityExtensions.Distance2D\(Entity, Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_Distance2D\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.Distance2D\(Entity, Vector3\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_Distance2D\_Divine\_Entity\_Entities\_Entity\_System\_Numerics\_Vector3\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[UnitExtensions.FindRotationAngle\(Unit, Vector3\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_FindRotationAngle\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Numerics\_Vector3\_), 
[UnitExtensions.GetAbilityById\(Unit, AbilityId\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_GetAbilityById\_Divine\_Entity\_Entities\_Units\_Unit\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_), 
[UnitExtensions.GetAngle\(Unit, Vector3\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_GetAngle\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Numerics\_Vector3\_), 
[UnitExtensions.GetAttackDamage\(Unit, Unit, bool, float\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_GetAttackDamage\_Divine\_Entity\_Entities\_Units\_Unit\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Boolean\_System\_Single\_), 
[UnitExtensions.GetAutoAttackArrivalTime\(Unit, Unit, bool\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_GetAutoAttackArrivalTime\_Divine\_Entity\_Entities\_Units\_Unit\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Boolean\_), 
[UnitExtensions.GetDisplayName\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_GetDisplayName\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.GetEnemiesInRange<TEntity\>\(Unit, float\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_GetEnemiesInRange\_\_1\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Single\_), 
[UnitExtensions.GetItemById\(Unit, AbilityId\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_GetItemById\_Divine\_Entity\_Entities\_Units\_Unit\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_), 
[UnitExtensions.GetModifierByName\(Unit, string\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_GetModifierByName\_Divine\_Entity\_Entities\_Units\_Unit\_System\_String\_), 
[UnitExtensions.GetModifierByTextureName\(Unit, string\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_GetModifierByTextureName\_Divine\_Entity\_Entities\_Units\_Unit\_System\_String\_), 
[UnitExtensions.GetProjectileArrivalTime\(Unit, Unit, float, float, bool\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_GetProjectileArrivalTime\_Divine\_Entity\_Entities\_Units\_Unit\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Single\_System\_Single\_System\_Boolean\_), 
[UnitExtensions.GetSpellAmplification\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_GetSpellAmplification\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.GetUnitsInRange<TEntity\>\(Unit, float\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_GetUnitsInRange\_\_1\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Single\_), 
[UnitExtensions.HasAghanimShard\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_HasAghanimShard\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.HasAghanimsScepter\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_HasAghanimsScepter\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.HasAnyModifiers\(Unit, params string\[\]\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_HasAnyModifiers\_Divine\_Entity\_Entities\_Units\_Unit\_System\_String\_\_\_), 
[UnitExtensions.HasModifier\(Unit, string\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_HasModifier\_Divine\_Entity\_Entities\_Units\_Unit\_System\_String\_), 
[UnitExtensions.HasModifiers\(Unit, IEnumerable<string\>, bool\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_HasModifiers\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Collections\_Generic\_IEnumerable\_System\_String\_\_System\_Boolean\_), 
[UnitExtensions.HealthPercent\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_HealthPercent\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[EnumerableExtensions.In<Unit\>\(Unit, params Unit\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[UnitExtensions.InFront\(Unit, float\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_InFront\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Single\_), 
[EntityExtensions.IsAlly\(Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsAlly\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.IsAlly\(Entity, Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsAlly\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.IsAlly\(Entity, Team\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsAlly\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Components\_Team\_), 
[UnitExtensions.IsAttackImmune\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsAttackImmune\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsAttacking\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsAttacking\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsBlockingAbilities\(Unit, bool\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsBlockingAbilities\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Boolean\_), 
[UnitExtensions.IsBlockingDamage\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsBlockingDamage\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsChanneling\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsChanneling\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsDirectlyFacing\(Unit, Vector3\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsDirectlyFacing\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Numerics\_Vector3\_), 
[UnitExtensions.IsDirectlyFacing\(Unit, Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsDirectlyFacing\_Divine\_Entity\_Entities\_Units\_Unit\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsDisarmed\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsDisarmed\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[EntityExtensions.IsEnemy\(Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsEnemy\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.IsEnemy\(Entity, Entity\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsEnemy\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Entity\_), 
[EntityExtensions.IsEnemy\(Entity, Team\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsEnemy\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Components\_Team\_), 
[UnitExtensions.IsHexed\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsHexed\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsInAttackRange\(Unit, Unit, float\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsInAttackRange\_Divine\_Entity\_Entities\_Units\_Unit\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Single\_), 
[EntityExtensions.IsInRange\(Entity, Entity, float\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsInRange\_Divine\_Entity\_Entities\_Entity\_Divine\_Entity\_Entities\_Entity\_System\_Single\_), 
[EntityExtensions.IsInRange\(Entity, Vector2, float\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsInRange\_Divine\_Entity\_Entities\_Entity\_System\_Numerics\_Vector2\_System\_Single\_), 
[EntityExtensions.IsInRange\(Entity, Vector3, float\)](Divine.Extensions.EntityExtensions.md\#Divine\_Extensions\_EntityExtensions\_IsInRange\_Divine\_Entity\_Entities\_Entity\_System\_Numerics\_Vector3\_System\_Single\_), 
[UnitExtensions.IsInRange\(Unit, Unit, float, bool\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsInRange\_Divine\_Entity\_Entities\_Units\_Unit\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Single\_System\_Boolean\_), 
[UnitExtensions.IsInvisible\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsInvisible\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsInvulnerable\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsInvulnerable\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsLinkensProtected\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsLinkensProtected\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsMagicImmune\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsMagicImmune\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsMuted\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsMuted\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsRealUnit\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsRealUnit\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsReflectingAbilities\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsReflectingAbilities\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsReflectingDamage\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsReflectingDamage\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsRooted\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsRooted\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsRotating\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsRotating\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsSilenced\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsSilenced\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsSpellShieldProtected\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsSpellShieldProtected\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsStunned\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsStunned\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsTargetAttacking\(Unit, Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsTargetAttacking\_Divine\_Entity\_Entities\_Units\_Unit\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.IsValidOrbwalkingTarget\(Unit, Unit, float\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsValidOrbwalkingTarget\_Divine\_Entity\_Entities\_Units\_Unit\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Single\_), 
[UnitExtensions.IsValidTarget\(Unit, float, bool, Vector3?, bool\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_IsValidTarget\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Single\_System\_Boolean\_System\_Nullable\_System\_Numerics\_Vector3\_\_System\_Boolean\_), 
[UnitExtensions.ProjectileSpeed\(Unit\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_ProjectileSpeed\_Divine\_Entity\_Entities\_Units\_Unit\_), 
[UnitExtensions.TurnRate\(Unit, bool\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_TurnRate\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Boolean\_), 
[UnitExtensions.TurnTime\(Unit, Vector3\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_TurnTime\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Numerics\_Vector3\_), 
[UnitExtensions.TurnTime\(Unit, Vector2\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_TurnTime\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Numerics\_Vector2\_), 
[UnitExtensions.TurnTime\(Unit, float\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_TurnTime\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Single\_), 
[UnitExtensions.Vector2FromPolarAngle\(Unit, float, float\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_Vector2FromPolarAngle\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Single\_System\_Single\_), 
[UnitExtensions.Vector3FromPolarAngle\(Unit, float, float\)](Divine.Extensions.UnitExtensions.md\#Divine\_Extensions\_UnitExtensions\_Vector3FromPolarAngle\_Divine\_Entity\_Entities\_Units\_Unit\_System\_Single\_System\_Single\_)

## Properties

### <a id="Divine_Entity_Entities_Units_Unit_ActiveShop"></a> ActiveShop

```csharp
public ShopType ActiveShop { get; }
```

#### Property Value

 [ShopType](Divine.Entity.Entities.Units.Components.ShopType.md)

### <a id="Divine_Entity_Entities_Units_Unit_AllKeyValues"></a> AllKeyValues

```csharp
public static KeyValues AllKeyValues { get; }
```

#### Property Value

 [KeyValues](Divine.Source2.KeyValues.md)

### <a id="Divine_Entity_Entities_Units_Unit_Armor"></a> Armor

```csharp
public virtual float Armor { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_ArmorType"></a> ArmorType

```csharp
[Obsolete("This Removed")]
public ArmorType ArmorType { get; }
```

#### Property Value

 [ArmorType](Divine.Entity.Entities.Units.Components.ArmorType.md)

### <a id="Divine_Entity_Entities_Units_Unit_AttackCapability"></a> AttackCapability

```csharp
public AttackCapability AttackCapability { get; }
```

#### Property Value

 [AttackCapability](Divine.Entity.Entities.Units.Components.AttackCapability.md)

### <a id="Divine_Entity_Entities_Units_Unit_AttackDamageType"></a> AttackDamageType

```csharp
[Obsolete("This Removed")]
public AttackDamageType AttackDamageType { get; }
```

#### Property Value

 [AttackDamageType](Divine.Entity.Entities.Units.Components.AttackDamageType.md)

### <a id="Divine_Entity_Entities_Units_Unit_AttackRange"></a> AttackRange

```csharp
public uint AttackRange { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Units_Unit_AttackSpeed"></a> AttackSpeed

```csharp
public float AttackSpeed { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_AttacksPerSecond"></a> AttacksPerSecond

```csharp
public float AttacksPerSecond { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_AvailableShops"></a> AvailableShops

```csharp
public ShopFlags AvailableShops { get; }
```

#### Property Value

 [ShopFlags](Divine.Entity.Entities.Units.Components.ShopFlags.md)

### <a id="Divine_Entity_Entities_Units_Unit_BaseArmor"></a> BaseArmor

```csharp
public virtual float BaseArmor { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_BaseAttackTime"></a> BaseAttackTime

```csharp
public float BaseAttackTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_BaseHealthRegeneration"></a> BaseHealthRegeneration

```csharp
public float BaseHealthRegeneration { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_BaseManaRegeneration"></a> BaseManaRegeneration

```csharp
public float BaseManaRegeneration { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_BaseMovementSpeed"></a> BaseMovementSpeed

```csharp
public float BaseMovementSpeed { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_BKBChargesUsed"></a> BKBChargesUsed

```csharp
public uint BKBChargesUsed { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Units_Unit_BonusArmor"></a> BonusArmor

```csharp
public virtual float BonusArmor { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_BonusCastRange"></a> BonusCastRange

```csharp
public float BonusCastRange { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_BonusDamage"></a> BonusDamage

```csharp
public int BonusDamage { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Units_Unit_CollisionPadding"></a> CollisionPadding

```csharp
public float CollisionPadding { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_DamageAverage"></a> DamageAverage

```csharp
public int DamageAverage { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Units_Unit_DayVision"></a> DayVision

```csharp
public uint DayVision { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Units_Unit_DeathTime"></a> DeathTime

```csharp
public float DeathTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_DebuffState"></a> DebuffState

```csharp
public UnitState DebuffState { get; }
```

#### Property Value

 [UnitState](Divine.Entity.Entities.Units.Components.UnitState.md)

### <a id="Divine_Entity_Entities_Units_Unit_HasArcana"></a> HasArcana

```csharp
public bool HasArcana { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_HasBaseStatsChanged"></a> HasBaseStatsChanged

```csharp
public bool HasBaseStatsChanged { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_HasInventory"></a> HasInventory

```csharp
public bool HasInventory { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_HasScepter"></a> HasScepter

```csharp
public bool HasScepter { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_HasShard"></a> HasShard

```csharp
public bool HasShard { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_HasSharedAbilities"></a> HasSharedAbilities

```csharp
public bool HasSharedAbilities { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_HasStolenScepter"></a> HasStolenScepter

```csharp
public bool HasStolenScepter { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_HasUpgradeableAbilities"></a> HasUpgradeableAbilities

```csharp
public bool HasUpgradeableAbilities { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_HealthBarOffset"></a> HealthBarOffset

```csharp
public int HealthBarOffset { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Units_Unit_HealthRegeneration"></a> HealthRegeneration

```csharp
public float HealthRegeneration { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_HullRadius"></a> HullRadius

```csharp
public float HullRadius { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_Inventory"></a> Inventory

```csharp
public Inventory? Inventory { get; }
```

#### Property Value

 [Inventory](Divine.Entity.Entities.Units.Components.Inventory.md)?

### <a id="Divine_Entity_Entities_Units_Unit_InvisiblityLevel"></a> InvisiblityLevel

```csharp
public float InvisiblityLevel { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_IsAncient"></a> IsAncient

```csharp
public bool IsAncient { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_IsControllable"></a> IsControllable

```csharp
public bool IsControllable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_IsDeniable"></a> IsDeniable

```csharp
public bool IsDeniable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_IsDominatable"></a> IsDominatable

```csharp
public bool IsDominatable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_IsIllusion"></a> IsIllusion

```csharp
public virtual bool IsIllusion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_IsMelee"></a> IsMelee

```csharp
public bool IsMelee { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_IsMoving"></a> IsMoving

```csharp
public bool IsMoving { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_IsNeutral"></a> IsNeutral

```csharp
public bool IsNeutral { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_IsPhantom"></a> IsPhantom

```csharp
public bool IsPhantom { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_IsRanged"></a> IsRanged

```csharp
public bool IsRanged { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_IsSpawned"></a> IsSpawned

```csharp
public bool IsSpawned { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_IsSummoned"></a> IsSummoned

```csharp
public bool IsSummoned { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_IsVisibleToEnemies"></a> IsVisibleToEnemies

```csharp
public bool IsVisibleToEnemies { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_IsWaitingToSpawn"></a> IsWaitingToSpawn

```csharp
public bool IsWaitingToSpawn { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Label"></a> Label

```csharp
public string Label { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Units_Unit_LastVisibleTime"></a> LastVisibleTime

```csharp
public float LastVisibleTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_LastVisibleToEnemiesTime"></a> LastVisibleToEnemiesTime

```csharp
public float LastVisibleToEnemiesTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_Level"></a> Level

```csharp
public uint Level { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Units_Unit_MagicalDamageResistance"></a> MagicalDamageResistance

```csharp
public float MagicalDamageResistance { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_Mana"></a> Mana

```csharp
public float Mana { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_ManaRegeneration"></a> ManaRegeneration

```csharp
public float ManaRegeneration { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_MaximumDamage"></a> MaximumDamage

```csharp
public int MaximumDamage { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Units_Unit_MaximumMana"></a> MaximumMana

```csharp
public float MaximumMana { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_MinimapIcon"></a> MinimapIcon

```csharp
public string MinimapIcon { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Units_Unit_MinimapIconSize"></a> MinimapIconSize

```csharp
public float MinimapIconSize { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_MinimumDamage"></a> MinimumDamage

```csharp
public int MinimumDamage { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Units_Unit_ModelFilename"></a> ModelFilename

```csharp
[Obsolete("TODO")]
public string ModelFilename { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Units_Unit_Modifiers"></a> Modifiers

```csharp
public IEnumerable<Modifier> Modifiers { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Modifier](Divine.Modifier.Modifiers.Modifier.md)\>

### <a id="Divine_Entity_Entities_Units_Unit_ModifierStatus"></a> ModifierStatus

```csharp
public ModifierStatus ModifierStatus { get; }
```

#### Property Value

 [ModifierStatus](Divine.Entity.Entities.Units.Components.ModifierStatus.md)

### <a id="Divine_Entity_Entities_Units_Unit_MoveCapability"></a> MoveCapability

```csharp
public MoveCapability MoveCapability { get; }
```

#### Property Value

 [MoveCapability](Divine.Entity.Entities.Units.Components.MoveCapability.md)

### <a id="Divine_Entity_Entities_Units_Unit_MovementSpeed"></a> MovementSpeed

```csharp
public float MovementSpeed { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_Name"></a> Name

```csharp
public override sealed string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Units_Unit_NetworkActivity"></a> NetworkActivity

```csharp
public NetworkActivity NetworkActivity { get; }
```

#### Property Value

 [NetworkActivity](Divine.Entity.Entities.Components.NetworkActivity.md)

### <a id="Divine_Entity_Entities_Units_Unit_NightVision"></a> NightVision

```csharp
public uint NightVision { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Units_Unit_PhysicalDamageResistance"></a> PhysicalDamageResistance

```csharp
public virtual float PhysicalDamageResistance { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_ProjectileCollisionSize"></a> ProjectileCollisionSize

```csharp
public float ProjectileCollisionSize { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_RingRadius"></a> RingRadius

```csharp
public float RingRadius { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_RotationDifference"></a> RotationDifference

```csharp
public float RotationDifference { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_ScepterUpgradeId"></a> ScepterUpgradeId

```csharp
public uint ScepterUpgradeId { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Units_Unit_SecondsPerAttack"></a> SecondsPerAttack

```csharp
public float SecondsPerAttack { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_ShardUpgradeId"></a> ShardUpgradeId

```csharp
public uint ShardUpgradeId { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Units_Unit_SoundSet"></a> SoundSet

```csharp
public string SoundSet { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Units_Unit_Spellbook"></a> Spellbook

```csharp
public Spellbook Spellbook { get; }
```

#### Property Value

 [Spellbook](Divine.Entity.Entities.Units.Components.Spellbook.md)

### <a id="Divine_Entity_Entities_Units_Unit_StatusResistance"></a> StatusResistance

```csharp
public float StatusResistance { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_Target"></a> Target

```csharp
public Unit? Target { get; }
```

#### Property Value

 [Unit](Divine.Entity.Entities.Units.Unit.md)?

### <a id="Divine_Entity_Entities_Units_Unit_TauntCooldown"></a> TauntCooldown

```csharp
public float TauntCooldown { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Units_Unit_TotalDamageTaken"></a> TotalDamageTaken

```csharp
public ulong TotalDamageTaken { get; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Entity_Entities_Units_Unit_UnitState"></a> UnitState

```csharp
public UnitState UnitState { get; set; }
```

#### Property Value

 [UnitState](Divine.Entity.Entities.Units.Components.UnitState.md)

### <a id="Divine_Entity_Entities_Units_Unit_UnitType"></a> UnitType

```csharp
public int UnitType { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Units_Unit_Vision"></a> Vision

```csharp
public uint Vision { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Units_Unit_Wearables"></a> Wearables

```csharp
public IEnumerable<WearableItem> Wearables { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[WearableItem](Divine.Entity.Entities.Wearables.WearableItem.md)\>

## Methods

### <a id="Divine_Entity_Entities_Units_Unit_Attack_System_Numerics_Vector3_"></a> Attack\(Vector3\)

```csharp
public bool Attack(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Attack_System_Numerics_Vector3_System_Boolean_"></a> Attack\(Vector3, bool\)

```csharp
public bool Attack(Vector3 position, bool queued)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Attack_Divine_Entity_Entities_Units_Unit_"></a> Attack\(Unit\)

```csharp
public bool Attack(Unit target)
```

#### Parameters

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Attack_Divine_Entity_Entities_Units_Unit_System_Boolean_"></a> Attack\(Unit, bool\)

```csharp
public bool Attack(Unit target, bool queued)
```

#### Parameters

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Attack_Divine_Entity_Entities_PhysicalItems_PhysicalItem_"></a> Attack\(PhysicalItem\)

```csharp
public bool Attack(PhysicalItem target)
```

#### Parameters

`target` [PhysicalItem](Divine.Entity.Entities.PhysicalItems.PhysicalItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Attack_Divine_Entity_Entities_PhysicalItems_PhysicalItem_System_Boolean_"></a> Attack\(PhysicalItem, bool\)

```csharp
public bool Attack(PhysicalItem target, bool queued)
```

#### Parameters

`target` [PhysicalItem](Divine.Entity.Entities.PhysicalItems.PhysicalItem.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Drop_Divine_Entity_Entities_Abilities_Items_Item_System_Numerics_Vector3_"></a> Drop\(Item, Vector3\)

```csharp
public bool Drop(Item item, Vector3 position)
```

#### Parameters

`item` [Item](Divine.Entity.Entities.Abilities.Items.Item.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Drop_Divine_Entity_Entities_Abilities_Items_Item_System_Numerics_Vector3_System_Boolean_"></a> Drop\(Item, Vector3, bool\)

```csharp
public bool Drop(Item item, Vector3 position, bool queued)
```

#### Parameters

`item` [Item](Divine.Entity.Entities.Abilities.Items.Item.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Follow_Divine_Entity_Entities_Units_Unit_"></a> Follow\(Unit\)

```csharp
public bool Follow(Unit target)
```

#### Parameters

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Follow_Divine_Entity_Entities_Units_Unit_System_Boolean_"></a> Follow\(Unit, bool\)

```csharp
public bool Follow(Unit target, bool queued)
```

#### Parameters

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_GetKeyValueByName_System_String_"></a> GetKeyValueByName\(string\)

```csharp
public static KeyValues? GetKeyValueByName(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [KeyValues](Divine.Source2.KeyValues.md)?

### <a id="Divine_Entity_Entities_Units_Unit_GetKeyValueByName_System_ReadOnlySpan_System_Byte__"></a> GetKeyValueByName\(ReadOnlySpan<byte\>\)

```csharp
public static KeyValues? GetKeyValueByName(ReadOnlySpan<byte> name)
```

#### Parameters

`name` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

#### Returns

 [KeyValues](Divine.Source2.KeyValues.md)?

### <a id="Divine_Entity_Entities_Units_Unit_GetSequenceByVariantForActivity_Divine_Entity_Entities_Components_NetworkActivity_System_Int32_"></a> GetSequenceByVariantForActivity\(NetworkActivity, int\)

```csharp
public int GetSequenceByVariantForActivity(NetworkActivity networkActivity, int networkSequenceVariant)
```

#### Parameters

`networkActivity` [NetworkActivity](Divine.Entity.Entities.Components.NetworkActivity.md)

`networkSequenceVariant` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Units_Unit_Give_Divine_Entity_Entities_Abilities_Items_Item_Divine_Entity_Entities_Units_Unit_"></a> Give\(Item, Unit\)

```csharp
public bool Give(Item item, Unit target)
```

#### Parameters

`item` [Item](Divine.Entity.Entities.Abilities.Items.Item.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Give_Divine_Entity_Entities_Abilities_Items_Item_Divine_Entity_Entities_Units_Unit_System_Boolean_"></a> Give\(Item, Unit, bool\)

```csharp
public bool Give(Item item, Unit target, bool queued)
```

#### Parameters

`item` [Item](Divine.Entity.Entities.Abilities.Items.Item.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Hold"></a> Hold\(\)

```csharp
public bool Hold()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Hold_System_Boolean_"></a> Hold\(bool\)

```csharp
public bool Hold(bool queued)
```

#### Parameters

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_IsControllableByPlayer_Divine_Entity_Entities_Players_Player_"></a> IsControllableByPlayer\(Player\)

```csharp
public bool IsControllableByPlayer(Player player)
```

#### Parameters

`player` [Player](Divine.Entity.Entities.Players.Player.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Move_System_Numerics_Vector3_"></a> Move\(Vector3\)

```csharp
public bool Move(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Move_System_Numerics_Vector3_System_Boolean_"></a> Move\(Vector3, bool\)

```csharp
public bool Move(Vector3 position, bool queued)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Move_System_Numerics_Vector3_System_Boolean_System_Boolean_"></a> Move\(Vector3, bool, bool\)

```csharp
public bool Move(Vector3 position, bool queued, bool bypassOrderAdding)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_MoveToDirection_System_Numerics_Vector3_"></a> MoveToDirection\(Vector3\)

```csharp
public bool MoveToDirection(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_MoveToDirection_System_Numerics_Vector3_System_Boolean_"></a> MoveToDirection\(Vector3, bool\)

```csharp
public bool MoveToDirection(Vector3 position, bool queued)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Patrol_System_Numerics_Vector3_"></a> Patrol\(Vector3\)

```csharp
public bool Patrol(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Patrol_System_Numerics_Vector3_System_Boolean_"></a> Patrol\(Vector3, bool\)

```csharp
public bool Patrol(Vector3 position, bool queued)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_PickUp_Divine_Entity_Entities_PhysicalItems_PhysicalItem_"></a> PickUp\(PhysicalItem\)

```csharp
public bool PickUp(PhysicalItem target)
```

#### Parameters

`target` [PhysicalItem](Divine.Entity.Entities.PhysicalItems.PhysicalItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_PickUp_Divine_Entity_Entities_PhysicalItems_PhysicalItem_System_Boolean_"></a> PickUp\(PhysicalItem, bool\)

```csharp
public bool PickUp(PhysicalItem target, bool queued)
```

#### Parameters

`target` [PhysicalItem](Divine.Entity.Entities.PhysicalItems.PhysicalItem.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_PickUp_Divine_Entity_Entities_Runes_Rune_"></a> PickUp\(Rune\)

```csharp
public bool PickUp(Rune target)
```

#### Parameters

`target` [Rune](Divine.Entity.Entities.Runes.Rune.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_PickUp_Divine_Entity_Entities_Runes_Rune_System_Boolean_"></a> PickUp\(Rune, bool\)

```csharp
public bool PickUp(Rune target, bool queued)
```

#### Parameters

`target` [Rune](Divine.Entity.Entities.Runes.Rune.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Stop"></a> Stop\(\)

```csharp
public bool Stop()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Stop_System_Boolean_"></a> Stop\(bool\)

```csharp
public bool Stop(bool queued)
```

#### Parameters

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_Stop_System_Boolean_System_Boolean_"></a> Stop\(bool, bool\)

```csharp
public bool Stop(bool queued, bool bypassOrderAdding)
```

#### Parameters

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Unit_TryGetAttachment_System_String_System_Numerics_Vector3__"></a> TryGetAttachment\(string, out Vector3\)

```csharp
public bool TryGetAttachment(string name, out Vector3 attachment)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`attachment` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

