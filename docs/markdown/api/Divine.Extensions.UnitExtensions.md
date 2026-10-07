# <a id="Divine_Extensions_UnitExtensions"></a> Class UnitExtensions

Namespace: [Divine.Extensions](Divine.Extensions.md)  
Assembly: Divine.dll  

```csharp
public static class UnitExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UnitExtensions](Divine.Extensions.UnitExtensions.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_)

## Methods

### <a id="Divine_Extensions_UnitExtensions_AttackPoint_Divine_Entity_Entities_Units_Unit_"></a> AttackPoint\(Unit\)

```csharp
public static float AttackPoint(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_UnitExtensions_AttackRange_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Units_Unit_"></a> AttackRange\(Unit, Unit?\)

```csharp
public static float AttackRange(this Unit unit, Unit? target = null)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)?

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_UnitExtensions_AttackSpeedValue_Divine_Entity_Entities_Units_Unit_"></a> AttackSpeedValue\(Unit\)

```csharp
public static float AttackSpeedValue(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_UnitExtensions_CalculateSpellDamage_Divine_Entity_Entities_Units_Heroes_Hero_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Components_DamageType_System_Single_"></a> CalculateSpellDamage\(Hero, Unit, DamageType, float\)

```csharp
public static float CalculateSpellDamage(this Hero source, Unit target, DamageType damageType, float amount)
```

#### Parameters

`source` [Hero](Divine.Entity.Entities.Units.Heroes.Hero.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`damageType` [DamageType](Divine.Entity.Entities.Abilities.Components.DamageType.md)

`amount` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_UnitExtensions_CanAttack_Divine_Entity_Entities_Units_Unit_"></a> CanAttack\(Unit\)

```csharp
public static bool CanAttack(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_CanAttack_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Units_Unit_"></a> CanAttack\(Unit, Unit\)

```csharp
public static bool CanAttack(this Unit attacker, Unit target)
```

#### Parameters

`attacker` [Unit](Divine.Entity.Entities.Units.Unit.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_Direction_Divine_Entity_Entities_Units_Unit_System_Single_"></a> Direction\(Unit, float\)

```csharp
public static Vector3 Direction(this Unit unit, float length = 1)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`length` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Extensions_UnitExtensions_Direction2D_Divine_Entity_Entities_Units_Unit_System_Single_"></a> Direction2D\(Unit, float\)

```csharp
public static Vector2 Direction2D(this Unit unit, float length = 1)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`length` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Extensions_UnitExtensions_FindRotationAngle_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_"></a> FindRotationAngle\(Unit, Vector3\)

```csharp
[Obsolete("Use GetAngle")]
public static float FindRotationAngle(this Unit unit, Vector3 pos)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`pos` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_UnitExtensions_GetAbilityById_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Components_AbilityId_"></a> GetAbilityById\(Unit, AbilityId\)

```csharp
public static Ability? GetAbilityById(this Unit unit, AbilityId abilityId)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

#### Returns

 [Ability](Divine.Entity.Entities.Abilities.Ability.md)?

### <a id="Divine_Extensions_UnitExtensions_GetAngle_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_"></a> GetAngle\(Unit, Vector3\)

```csharp
public static float GetAngle(this Unit unit, Vector3 position)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_UnitExtensions_GetAttackDamage_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Units_Unit_System_Boolean_System_Single_"></a> GetAttackDamage\(Unit, Unit, bool, float\)

```csharp
public static float GetAttackDamage(this Unit source, Unit target, bool useMinimumDamage = false, float damageAmplifier = 0)
```

#### Parameters

`source` [Unit](Divine.Entity.Entities.Units.Unit.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`useMinimumDamage` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`damageAmplifier` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_UnitExtensions_GetAutoAttackArrivalTime_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Units_Unit_System_Boolean_"></a> GetAutoAttackArrivalTime\(Unit, Unit, bool\)

```csharp
public static float GetAutoAttackArrivalTime(this Unit source, Unit target, bool takeRotationTimeIntoAccount = true)
```

#### Parameters

`source` [Unit](Divine.Entity.Entities.Units.Unit.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`takeRotationTimeIntoAccount` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_UnitExtensions_GetDisplayName_Divine_Entity_Entities_Units_Unit_"></a> GetDisplayName\(Unit\)

```csharp
public static string GetDisplayName(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Extensions_UnitExtensions_GetEnemiesInRange__1_Divine_Entity_Entities_Units_Unit_System_Single_"></a> GetEnemiesInRange<TEntity\>\(Unit, float\)

```csharp
public static IEnumerable<TEntity> GetEnemiesInRange<TEntity>(this Unit unit, float range) where TEntity : Unit
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`range` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<TEntity\>

#### Type Parameters

`TEntity` 

### <a id="Divine_Extensions_UnitExtensions_GetItemById_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Abilities_Components_AbilityId_"></a> GetItemById\(Unit, AbilityId\)

```csharp
public static Item? GetItemById(this Unit unit, AbilityId abilityId)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

#### Returns

 [Item](Divine.Entity.Entities.Abilities.Items.Item.md)?

### <a id="Divine_Extensions_UnitExtensions_GetModifierByName_Divine_Entity_Entities_Units_Unit_System_String_"></a> GetModifierByName\(Unit, string\)

```csharp
public static Modifier? GetModifierByName(this Unit unit, string name)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Modifier](Divine.Modifier.Modifiers.Modifier.md)?

### <a id="Divine_Extensions_UnitExtensions_GetModifierByTextureName_Divine_Entity_Entities_Units_Unit_System_String_"></a> GetModifierByTextureName\(Unit, string\)

```csharp
public static Modifier? GetModifierByTextureName(this Unit unit, string name)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Modifier](Divine.Modifier.Modifiers.Modifier.md)?

### <a id="Divine_Extensions_UnitExtensions_GetProjectileArrivalTime_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Units_Unit_System_Single_System_Single_System_Boolean_"></a> GetProjectileArrivalTime\(Unit, Unit, float, float, bool\)

```csharp
public static float GetProjectileArrivalTime(this Unit source, Unit target, float delay, float missileSpeed, bool takeRotationTimeIntoAccount = true)
```

#### Parameters

`source` [Unit](Divine.Entity.Entities.Units.Unit.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`delay` [float](https://learn.microsoft.com/dotnet/api/system.single)

`missileSpeed` [float](https://learn.microsoft.com/dotnet/api/system.single)

`takeRotationTimeIntoAccount` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_UnitExtensions_GetSpellAmplification_Divine_Entity_Entities_Units_Unit_"></a> GetSpellAmplification\(Unit\)

```csharp
public static float GetSpellAmplification(this Unit source)
```

#### Parameters

`source` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_UnitExtensions_GetUnitsInRange__1_Divine_Entity_Entities_Units_Unit_System_Single_"></a> GetUnitsInRange<TEntity\>\(Unit, float\)

```csharp
public static IEnumerable<TEntity> GetUnitsInRange<TEntity>(this Unit unit, float range) where TEntity : Unit
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`range` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<TEntity\>

#### Type Parameters

`TEntity` 

### <a id="Divine_Extensions_UnitExtensions_HasAghanimShard_Divine_Entity_Entities_Units_Unit_"></a> HasAghanimShard\(Unit\)

```csharp
public static bool HasAghanimShard(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_HasAghanimsScepter_Divine_Entity_Entities_Units_Unit_"></a> HasAghanimsScepter\(Unit\)

```csharp
public static bool HasAghanimsScepter(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_HasAnyModifiers_Divine_Entity_Entities_Units_Unit_System_String___"></a> HasAnyModifiers\(Unit, params string\[\]\)

```csharp
public static bool HasAnyModifiers(this Unit unit, params string[] modifierNames)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`modifierNames` [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_HasModifier_Divine_Entity_Entities_Units_Unit_System_String_"></a> HasModifier\(Unit, string\)

```csharp
public static bool HasModifier(this Unit unit, string modifierName)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`modifierName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_HasModifiers_Divine_Entity_Entities_Units_Unit_System_Collections_Generic_IEnumerable_System_String__System_Boolean_"></a> HasModifiers\(Unit, IEnumerable<string\>, bool\)

```csharp
public static bool HasModifiers(this Unit unit, IEnumerable<string> modifierNames, bool hasAll = true)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`modifierNames` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

`hasAll` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_HealthPercent_Divine_Entity_Entities_Units_Unit_"></a> HealthPercent\(Unit\)

```csharp
public static float HealthPercent(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_UnitExtensions_InFront_Divine_Entity_Entities_Units_Unit_System_Single_"></a> InFront\(Unit, float\)

```csharp
public static Vector3 InFront(this Unit unit, float distance)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`distance` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Extensions_UnitExtensions_IsAttackImmune_Divine_Entity_Entities_Units_Unit_"></a> IsAttackImmune\(Unit\)

```csharp
public static bool IsAttackImmune(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsAttacking_Divine_Entity_Entities_Units_Unit_"></a> IsAttacking\(Unit\)

```csharp
public static bool IsAttacking(this Unit source)
```

#### Parameters

`source` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsBlockingAbilities_Divine_Entity_Entities_Units_Unit_System_Boolean_"></a> IsBlockingAbilities\(Unit, bool\)

```csharp
public static bool IsBlockingAbilities(this Unit unit, bool checkReflecting = false)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`checkReflecting` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsBlockingDamage_Divine_Entity_Entities_Units_Unit_"></a> IsBlockingDamage\(Unit\)

```csharp
public static bool IsBlockingDamage(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsChanneling_Divine_Entity_Entities_Units_Unit_"></a> IsChanneling\(Unit\)

```csharp
public static bool IsChanneling(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsDirectlyFacing_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_"></a> IsDirectlyFacing\(Unit, Vector3\)

```csharp
public static bool IsDirectlyFacing(this Unit source, Vector3 pos)
```

#### Parameters

`source` [Unit](Divine.Entity.Entities.Units.Unit.md)

`pos` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsDirectlyFacing_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Units_Unit_"></a> IsDirectlyFacing\(Unit, Unit\)

returns true if source is directly facing to target

```csharp
public static bool IsDirectlyFacing(this Unit source, Unit target)
```

#### Parameters

`source` [Unit](Divine.Entity.Entities.Units.Unit.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsDisarmed_Divine_Entity_Entities_Units_Unit_"></a> IsDisarmed\(Unit\)

```csharp
public static bool IsDisarmed(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsHexed_Divine_Entity_Entities_Units_Unit_"></a> IsHexed\(Unit\)

```csharp
public static bool IsHexed(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsInAttackRange_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Units_Unit_System_Single_"></a> IsInAttackRange\(Unit, Unit, float\)

```csharp
public static bool IsInAttackRange(this Unit source, Unit target, float bonusAttackRange = 0)
```

#### Parameters

`source` [Unit](Divine.Entity.Entities.Units.Unit.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`bonusAttackRange` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsInRange_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Units_Unit_System_Single_System_Boolean_"></a> IsInRange\(Unit, Unit, float, bool\)

```csharp
public static bool IsInRange(this Unit source, Unit target, float range, bool centerToCenter = false)
```

#### Parameters

`source` [Unit](Divine.Entity.Entities.Units.Unit.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`range` [float](https://learn.microsoft.com/dotnet/api/system.single)

`centerToCenter` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsInvisible_Divine_Entity_Entities_Units_Unit_"></a> IsInvisible\(Unit\)

```csharp
public static bool IsInvisible(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsInvulnerable_Divine_Entity_Entities_Units_Unit_"></a> IsInvulnerable\(Unit\)

```csharp
public static bool IsInvulnerable(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsLinkensProtected_Divine_Entity_Entities_Units_Unit_"></a> IsLinkensProtected\(Unit\)

```csharp
public static bool IsLinkensProtected(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsMagicImmune_Divine_Entity_Entities_Units_Unit_"></a> IsMagicImmune\(Unit\)

```csharp
public static bool IsMagicImmune(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsMuted_Divine_Entity_Entities_Units_Unit_"></a> IsMuted\(Unit\)

```csharp
public static bool IsMuted(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsRealUnit_Divine_Entity_Entities_Units_Unit_"></a> IsRealUnit\(Unit\)

```csharp
public static bool IsRealUnit(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsReflectingAbilities_Divine_Entity_Entities_Units_Unit_"></a> IsReflectingAbilities\(Unit\)

```csharp
public static bool IsReflectingAbilities(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsReflectingDamage_Divine_Entity_Entities_Units_Unit_"></a> IsReflectingDamage\(Unit\)

```csharp
public static bool IsReflectingDamage(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsRooted_Divine_Entity_Entities_Units_Unit_"></a> IsRooted\(Unit\)

```csharp
public static bool IsRooted(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsRotating_Divine_Entity_Entities_Units_Unit_"></a> IsRotating\(Unit\)

```csharp
public static bool IsRotating(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsSilenced_Divine_Entity_Entities_Units_Unit_"></a> IsSilenced\(Unit\)

```csharp
public static bool IsSilenced(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsSpellShieldProtected_Divine_Entity_Entities_Units_Unit_"></a> IsSpellShieldProtected\(Unit\)

```csharp
public static bool IsSpellShieldProtected(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsStunned_Divine_Entity_Entities_Units_Unit_"></a> IsStunned\(Unit\)

```csharp
public static bool IsStunned(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsTargetAttacking_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Units_Unit_"></a> IsTargetAttacking\(Unit, Unit\)

```csharp
public static bool IsTargetAttacking(this Unit source, Unit target)
```

#### Parameters

`source` [Unit](Divine.Entity.Entities.Units.Unit.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsValidOrbwalkingTarget_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Units_Unit_System_Single_"></a> IsValidOrbwalkingTarget\(Unit, Unit, float\)

```csharp
public static bool IsValidOrbwalkingTarget(this Unit attacker, Unit target, float bonusAttackRange = 0)
```

#### Parameters

`attacker` [Unit](Divine.Entity.Entities.Units.Unit.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`bonusAttackRange` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_IsValidTarget_Divine_Entity_Entities_Units_Unit_System_Single_System_Boolean_System_Nullable_System_Numerics_Vector3__System_Boolean_"></a> IsValidTarget\(Unit, float, bool, Vector3?, bool\)

```csharp
public static bool IsValidTarget(this Unit unit, float range = 3.4028235E+38, bool checkTeam = true, Vector3? from = null, bool visibleCheck = true)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`range` [float](https://learn.microsoft.com/dotnet/api/system.single)

`checkTeam` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`from` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)?

`visibleCheck` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_UnitExtensions_ProjectileSpeed_Divine_Entity_Entities_Units_Unit_"></a> ProjectileSpeed\(Unit\)

```csharp
public static float ProjectileSpeed(this Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_UnitExtensions_TurnRate_Divine_Entity_Entities_Units_Unit_System_Boolean_"></a> TurnRate\(Unit, bool\)

```csharp
public static float TurnRate(this Unit unit, bool currentTurnRate = true)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`currentTurnRate` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_UnitExtensions_TurnTime_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_"></a> TurnTime\(Unit, Vector3\)

```csharp
public static float TurnTime(this Unit unit, Vector3 position)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_UnitExtensions_TurnTime_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector2_"></a> TurnTime\(Unit, Vector2\)

```csharp
public static float TurnTime(this Unit unit, Vector2 position)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_UnitExtensions_TurnTime_Divine_Entity_Entities_Units_Unit_System_Single_"></a> TurnTime\(Unit, float\)

```csharp
public static float TurnTime(this Unit unit, float angle)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`angle` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_UnitExtensions_Vector2FromPolarAngle_Divine_Entity_Entities_Units_Unit_System_Single_System_Single_"></a> Vector2FromPolarAngle\(Unit, float, float\)

```csharp
public static Vector2 Vector2FromPolarAngle(this Unit unit, float delta = 0, float radial = 1)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`delta` [float](https://learn.microsoft.com/dotnet/api/system.single)

`radial` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Extensions_UnitExtensions_Vector3FromPolarAngle_Divine_Entity_Entities_Units_Unit_System_Single_System_Single_"></a> Vector3FromPolarAngle\(Unit, float, float\)

```csharp
public static Vector3 Vector3FromPolarAngle(this Unit unit, float delta = 0, float radial = 1)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`delta` [float](https://learn.microsoft.com/dotnet/api/system.single)

`radial` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

