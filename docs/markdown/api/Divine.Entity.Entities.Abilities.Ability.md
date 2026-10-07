# <a id="Divine_Entity_Entities_Abilities_Ability"></a> Class Ability

Namespace: [Divine.Entity.Entities.Abilities](Divine.Entity.Entities.Abilities.md)  
Assembly: Divine.dll  

```csharp
public class Ability : Entity, IEquatable<Entity>, INative
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Divine.Entity.Entities.Entity.md) ← 
[Ability](Divine.Entity.Entities.Abilities.Ability.md)

#### Derived

[Item](Divine.Entity.Entities.Abilities.Items.Item.md), 
[Spell](Divine.Entity.Entities.Abilities.Spells.Spell.md)

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
[AbilityExtensions.GetAbilitySlotInfo\(Ability\)](Divine.Extensions.AbilityExtensions.md\#Divine\_Extensions\_AbilityExtensions\_GetAbilitySlotInfo\_Divine\_Entity\_Entities\_Abilities\_Ability\_), 
[AbilityExtensions.GetAbilitySpecialData\(Ability, string\)](Divine.Extensions.AbilityExtensions.md\#Divine\_Extensions\_AbilityExtensions\_GetAbilitySpecialData\_Divine\_Entity\_Entities\_Abilities\_Ability\_System\_String\_), 
[AbilityExtensions.GetAbilitySpecialData\(Ability, string, uint\)](Divine.Extensions.AbilityExtensions.md\#Divine\_Extensions\_AbilityExtensions\_GetAbilitySpecialData\_Divine\_Entity\_Entities\_Abilities\_Ability\_System\_String\_System\_UInt32\_), 
[AbilityExtensions.GetAbilitySpecialDataValue\(Ability, string, uint\)](Divine.Extensions.AbilityExtensions.md\#Divine\_Extensions\_AbilityExtensions\_GetAbilitySpecialDataValue\_Divine\_Entity\_Entities\_Abilities\_Ability\_System\_String\_System\_UInt32\_), 
[AbilityExtensions.GetAbilitySpecialDataWithTalent\(Ability, Unit, string, uint\)](Divine.Extensions.AbilityExtensions.md\#Divine\_Extensions\_AbilityExtensions\_GetAbilitySpecialDataWithTalent\_Divine\_Entity\_Entities\_Abilities\_Ability\_Divine\_Entity\_Entities\_Units\_Unit\_System\_String\_System\_UInt32\_), 
[AbilityExtensions.GetAbilitySpecialDataWithTalent\(Ability, Unit, string, AbilityId, uint\)](Divine.Extensions.AbilityExtensions.md\#Divine\_Extensions\_AbilityExtensions\_GetAbilitySpecialDataWithTalent\_Divine\_Entity\_Entities\_Abilities\_Ability\_Divine\_Entity\_Entities\_Units\_Unit\_System\_String\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_System\_UInt32\_), 
[AbilityExtensions.GetCastPoint\(Ability\)](Divine.Extensions.AbilityExtensions.md\#Divine\_Extensions\_AbilityExtensions\_GetCastPoint\_Divine\_Entity\_Entities\_Abilities\_Ability\_), 
[EnumerableExtensions.In<Ability\>\(Ability, params Ability\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
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

### <a id="Divine_Entity_Entities_Abilities_Ability_AbilityBehavior"></a> AbilityBehavior

```csharp
public AbilityBehavior AbilityBehavior { get; }
```

#### Property Value

 [AbilityBehavior](Divine.Entity.Entities.Abilities.Components.AbilityBehavior.md)

### <a id="Divine_Entity_Entities_Abilities_Ability_AbilityData"></a> AbilityData

```csharp
public AbilityData? AbilityData { get; }
```

#### Property Value

 [AbilityData](Divine.Entity.Entities.Abilities.Components.AbilityData.md)?

### <a id="Divine_Entity_Entities_Abilities_Ability_AbilityIndex"></a> AbilityIndex

```csharp
public ushort AbilityIndex { get; }
```

#### Property Value

 [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

### <a id="Divine_Entity_Entities_Abilities_Ability_AbilitySlot"></a> AbilitySlot

```csharp
public AbilitySlot AbilitySlot { get; }
```

#### Property Value

 [AbilitySlot](Divine.Entity.Entities.Abilities.Components.AbilitySlot.md)

### <a id="Divine_Entity_Entities_Abilities_Ability_AbilitySpecialData"></a> AbilitySpecialData

```csharp
public IEnumerable<AbilitySpecialData> AbilitySpecialData { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[AbilitySpecialData](Divine.Entity.Entities.Abilities.Components.AbilitySpecialData.md)\>

### <a id="Divine_Entity_Entities_Abilities_Ability_AbilityState"></a> AbilityState

```csharp
public AbilityState AbilityState { get; }
```

#### Property Value

 [AbilityState](Divine.Entity.Entities.Abilities.Components.AbilityState.md)

### <a id="Divine_Entity_Entities_Abilities_Ability_AbilityType"></a> AbilityType

```csharp
public AbilityType AbilityType { get; }
```

#### Property Value

 [AbilityType](Divine.Entity.Entities.Abilities.Components.AbilityType.md)

### <a id="Divine_Entity_Entities_Abilities_Ability_AllKeyValues"></a> AllKeyValues

```csharp
public static KeyValues AllKeyValues { get; }
```

#### Property Value

 [KeyValues](Divine.Source2.KeyValues.md)

### <a id="Divine_Entity_Entities_Abilities_Ability_BaseCastRange"></a> BaseCastRange

```csharp
public float BaseCastRange { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Ability_CastPoint"></a> CastPoint

```csharp
public float CastPoint { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Ability_CastRange"></a> CastRange

```csharp
public float CastRange { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Ability_CastStartTime"></a> CastStartTime

```csharp
public float CastStartTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Ability_ChannelMaximumTime"></a> ChannelMaximumTime

```csharp
public float ChannelMaximumTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Ability_ChannelStartTime"></a> ChannelStartTime

```csharp
public float ChannelStartTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Ability_ChannelTime"></a> ChannelTime

```csharp
public float ChannelTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Ability_ChargeRestoreTime"></a> ChargeRestoreTime

```csharp
public float ChargeRestoreTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Ability_ChargeRestoreTimeRemaining"></a> ChargeRestoreTimeRemaining

```csharp
public float ChargeRestoreTimeRemaining { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Ability_Charges"></a> Charges

```csharp
public int Charges { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cooldown"></a> Cooldown

```csharp
public float Cooldown { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Ability_CooldownInFog"></a> CooldownInFog

```csharp
public float CooldownInFog { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Ability_CooldownLength"></a> CooldownLength

```csharp
public float CooldownLength { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Ability_CurrentCharges"></a> CurrentCharges

```csharp
public virtual uint CurrentCharges { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Abilities_Ability_Damage"></a> Damage

```csharp
public int Damage { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Abilities_Ability_DamageType"></a> DamageType

```csharp
public DamageType DamageType { get; }
```

#### Property Value

 [DamageType](Divine.Entity.Entities.Abilities.Components.DamageType.md)

### <a id="Divine_Entity_Entities_Abilities_Ability_DispellableType"></a> DispellableType

```csharp
public DispellableType DispellableType { get; }
```

#### Property Value

 [DispellableType](Divine.Entity.Entities.Abilities.Components.DispellableType.md)

### <a id="Divine_Entity_Entities_Abilities_Ability_Duration"></a> Duration

```csharp
public float Duration { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Ability_EnemyLevel"></a> EnemyLevel

```csharp
public int EnemyLevel { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Abilities_Ability_HasAltCastState"></a> HasAltCastState

```csharp
public bool HasAltCastState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Id"></a> Id

```csharp
public AbilityId Id { get; }
```

#### Property Value

 [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

### <a id="Divine_Entity_Entities_Abilities_Ability_IsActivated"></a> IsActivated

```csharp
public bool IsActivated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_IsAutoCastEnabled"></a> IsAutoCastEnabled

```csharp
public bool IsAutoCastEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_IsChanneling"></a> IsChanneling

```csharp
public bool IsChanneling { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_IsCooldownFrozen"></a> IsCooldownFrozen

```csharp
public bool IsCooldownFrozen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_IsGrantedByScepter"></a> IsGrantedByScepter

```csharp
public bool IsGrantedByScepter { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_IsHidden"></a> IsHidden

```csharp
public bool IsHidden { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_IsInAbilityPhase"></a> IsInAbilityPhase

```csharp
public bool IsInAbilityPhase { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_IsInIndefiniteCooldown"></a> IsInIndefiniteCooldown

```csharp
public bool IsInIndefiniteCooldown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_IsInnate"></a> IsInnate

```csharp
public bool IsInnate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_IsReplicated"></a> IsReplicated

```csharp
public bool IsReplicated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_IsStolen"></a> IsStolen

```csharp
public bool IsStolen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_IsToggled"></a> IsToggled

```csharp
public bool IsToggled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_KeyValue"></a> KeyValue

```csharp
public KeyValues? KeyValue { get; }
```

#### Property Value

 [KeyValues](Divine.Source2.KeyValues.md)?

### <a id="Divine_Entity_Entities_Abilities_Ability_LastCastClickTime"></a> LastCastClickTime

```csharp
public float LastCastClickTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Ability_Level"></a> Level

```csharp
public uint Level { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Abilities_Ability_LevelsBeetweenUpgrades"></a> LevelsBeetweenUpgrades

```csharp
public int LevelsBeetweenUpgrades { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Abilities_Ability_ManaCost"></a> ManaCost

```csharp
public int ManaCost { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Abilities_Ability_MaximumLevel"></a> MaximumLevel

```csharp
public int MaximumLevel { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Abilities_Ability_Name"></a> Name

```csharp
public override string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Abilities_Ability_NetworkActivity"></a> NetworkActivity

```csharp
public NetworkActivity NetworkActivity { get; }
```

#### Property Value

 [NetworkActivity](Divine.Entity.Entities.Components.NetworkActivity.md)

### <a id="Divine_Entity_Entities_Abilities_Ability_NeutralTierIndex"></a> NeutralTierIndex

```csharp
public int NeutralTierIndex { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Abilities_Ability_OverrideCastPoint"></a> OverrideCastPoint

```csharp
public float OverrideCastPoint { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Ability_RequiredLevel"></a> RequiredLevel

```csharp
public int RequiredLevel { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Abilities_Ability_SharedCooldownName"></a> SharedCooldownName

```csharp
public string SharedCooldownName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Abilities_Ability_SpellPierceImmunityType"></a> SpellPierceImmunityType

```csharp
public SpellPierceImmunityType SpellPierceImmunityType { get; }
```

#### Property Value

 [SpellPierceImmunityType](Divine.Entity.Entities.Abilities.Components.SpellPierceImmunityType.md)

### <a id="Divine_Entity_Entities_Abilities_Ability_TargetFlags"></a> TargetFlags

```csharp
public TargetFlags TargetFlags { get; }
```

#### Property Value

 [TargetFlags](Divine.Entity.Entities.Abilities.Components.TargetFlags.md)

### <a id="Divine_Entity_Entities_Abilities_Ability_TargetTeamType"></a> TargetTeamType

```csharp
public TargetTeamType TargetTeamType { get; }
```

#### Property Value

 [TargetTeamType](Divine.Entity.Entities.Abilities.Components.TargetTeamType.md)

### <a id="Divine_Entity_Entities_Abilities_Ability_TargetType"></a> TargetType

```csharp
public TargetType TargetType { get; }
```

#### Property Value

 [TargetType](Divine.Entity.Entities.Abilities.Components.TargetType.md)

### <a id="Divine_Entity_Entities_Abilities_Ability_TextureName"></a> TextureName

```csharp
public string TextureName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Entity_Entities_Abilities_Ability_Announce"></a> Announce\(\)

```csharp
public bool Announce()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast"></a> Cast\(\)

```csharp
public bool Cast()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_System_Boolean_"></a> Cast\(bool\)

```csharp
public bool Cast(bool queued)
```

#### Parameters

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_System_Boolean_System_Boolean_"></a> Cast\(bool, bool\)

```csharp
public bool Cast(bool queued, bool bypassOrderAdding)
```

#### Parameters

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_System_Numerics_Vector3_"></a> Cast\(Vector3\)

```csharp
public bool Cast(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_System_Numerics_Vector3_System_Boolean_"></a> Cast\(Vector3, bool\)

```csharp
public bool Cast(Vector3 position, bool queued)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_System_Numerics_Vector3_System_Boolean_System_Boolean_"></a> Cast\(Vector3, bool, bool\)

```csharp
public bool Cast(Vector3 position, bool queued, bool bypassOrderAdding)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_System_Numerics_Vector3_System_Numerics_Vector3_"></a> Cast\(Vector3, Vector3\)

```csharp
public bool Cast(Vector3 startPosition, Vector3 endPosition)
```

#### Parameters

`startPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_System_Numerics_Vector3_System_Numerics_Vector3_System_Boolean_"></a> Cast\(Vector3, Vector3, bool\)

```csharp
public bool Cast(Vector3 startPosition, Vector3 endPosition, bool queued)
```

#### Parameters

`startPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_System_Numerics_Vector3_System_Numerics_Vector3_System_Boolean_System_Boolean_"></a> Cast\(Vector3, Vector3, bool, bool\)

```csharp
public bool Cast(Vector3 startPosition, Vector3 endPosition, bool queued, bool bypassOrderAdding)
```

#### Parameters

`startPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_Divine_Entity_Entities_Units_Unit_"></a> Cast\(Unit\)

```csharp
public bool Cast(Unit target)
```

#### Parameters

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_Divine_Entity_Entities_Units_Unit_System_Boolean_"></a> Cast\(Unit, bool\)

```csharp
public bool Cast(Unit target, bool queued)
```

#### Parameters

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_Divine_Entity_Entities_Units_Unit_System_Boolean_System_Boolean_"></a> Cast\(Unit, bool, bool\)

```csharp
public bool Cast(Unit target, bool queued, bool bypassOrderAdding)
```

#### Parameters

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_"></a> Cast\(Unit, Vector3\)

```csharp
public bool Cast(Unit startTarget, Vector3 endPosition)
```

#### Parameters

`startTarget` [Unit](Divine.Entity.Entities.Units.Unit.md)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_System_Boolean_"></a> Cast\(Unit, Vector3, bool\)

```csharp
public bool Cast(Unit startTarget, Vector3 endPosition, bool queued)
```

#### Parameters

`startTarget` [Unit](Divine.Entity.Entities.Units.Unit.md)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_System_Boolean_System_Boolean_"></a> Cast\(Unit, Vector3, bool, bool\)

```csharp
public bool Cast(Unit startTarget, Vector3 endPosition, bool queued, bool bypassOrderAdding)
```

#### Parameters

`startTarget` [Unit](Divine.Entity.Entities.Units.Unit.md)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_Divine_Entity_Entities_Runes_Rune_"></a> Cast\(Rune\)

```csharp
public bool Cast(Rune target)
```

#### Parameters

`target` [Rune](Divine.Entity.Entities.Runes.Rune.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_Divine_Entity_Entities_Runes_Rune_System_Boolean_"></a> Cast\(Rune, bool\)

```csharp
public bool Cast(Rune target, bool queued)
```

#### Parameters

`target` [Rune](Divine.Entity.Entities.Runes.Rune.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_Divine_Entity_Entities_Runes_Rune_System_Boolean_System_Boolean_"></a> Cast\(Rune, bool, bool\)

```csharp
public bool Cast(Rune target, bool queued, bool bypassOrderAdding)
```

#### Parameters

`target` [Rune](Divine.Entity.Entities.Runes.Rune.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_Divine_Entity_Entities_Trees_Tree_"></a> Cast\(Tree\)

```csharp
public bool Cast(Tree target)
```

#### Parameters

`target` [Tree](Divine.Entity.Entities.Trees.Tree.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_Divine_Entity_Entities_Trees_Tree_System_Boolean_"></a> Cast\(Tree, bool\)

```csharp
public bool Cast(Tree target, bool queued)
```

#### Parameters

`target` [Tree](Divine.Entity.Entities.Trees.Tree.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_Cast_Divine_Entity_Entities_Trees_Tree_System_Boolean_System_Boolean_"></a> Cast\(Tree, bool, bool\)

```csharp
public bool Cast(Tree target, bool queued, bool bypassOrderAdding)
```

#### Parameters

`target` [Tree](Divine.Entity.Entities.Trees.Tree.md)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_CastToggle"></a> CastToggle\(\)

```csharp
public bool CastToggle()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_CastToggle_System_Boolean_"></a> CastToggle\(bool\)

```csharp
public bool CastToggle(bool queued)
```

#### Parameters

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_CastToggle_System_Boolean_System_Boolean_"></a> CastToggle\(bool, bool\)

```csharp
public bool CastToggle(bool queued, bool bypassOrderAdding)
```

#### Parameters

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_CastToggleAutocast"></a> CastToggleAutocast\(\)

```csharp
public bool CastToggleAutocast()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Ability_GetAbilityDataById_Divine_Entity_Entities_Abilities_Components_AbilityId_"></a> GetAbilityDataById\(AbilityId\)

```csharp
public static AbilityData? GetAbilityDataById(AbilityId abilityId)
```

#### Parameters

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

#### Returns

 [AbilityData](Divine.Entity.Entities.Abilities.Components.AbilityData.md)?

### <a id="Divine_Entity_Entities_Abilities_Ability_GetAbilityDataByIndex_System_UInt16_"></a> GetAbilityDataByIndex\(ushort\)

```csharp
public static AbilityData? GetAbilityDataByIndex(ushort abilityIndex)
```

#### Parameters

`abilityIndex` [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

#### Returns

 [AbilityData](Divine.Entity.Entities.Abilities.Components.AbilityData.md)?

### <a id="Divine_Entity_Entities_Abilities_Ability_GetAbilityDataByName_System_String_"></a> GetAbilityDataByName\(string\)

```csharp
public static AbilityData? GetAbilityDataByName(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [AbilityData](Divine.Entity.Entities.Abilities.Components.AbilityData.md)?

### <a id="Divine_Entity_Entities_Abilities_Ability_GetAbilityIdByName_System_String_"></a> GetAbilityIdByName\(string\)

```csharp
public static AbilityId GetAbilityIdByName(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

### <a id="Divine_Entity_Entities_Abilities_Ability_GetAbilityIndexById_Divine_Entity_Entities_Abilities_Components_AbilityId_"></a> GetAbilityIndexById\(AbilityId\)

```csharp
public static ushort GetAbilityIndexById(AbilityId abilityId)
```

#### Parameters

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

#### Returns

 [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

### <a id="Divine_Entity_Entities_Abilities_Ability_GetAbilityIndexByName_System_String_"></a> GetAbilityIndexByName\(string\)

```csharp
public static ushort GetAbilityIndexByName(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

### <a id="Divine_Entity_Entities_Abilities_Ability_GetAbilityNameById_Divine_Entity_Entities_Abilities_Components_AbilityId_"></a> GetAbilityNameById\(AbilityId\)

```csharp
public static string GetAbilityNameById(AbilityId abilityId)
```

#### Parameters

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Abilities_Ability_GetKeyValueById_Divine_Entity_Entities_Abilities_Components_AbilityId_"></a> GetKeyValueById\(AbilityId\)

```csharp
public static KeyValues? GetKeyValueById(AbilityId abilityId)
```

#### Parameters

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

#### Returns

 [KeyValues](Divine.Source2.KeyValues.md)?

### <a id="Divine_Entity_Entities_Abilities_Ability_GetKeyValueByName_System_String_"></a> GetKeyValueByName\(string\)

```csharp
public static KeyValues? GetKeyValueByName(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [KeyValues](Divine.Source2.KeyValues.md)?

### <a id="Divine_Entity_Entities_Abilities_Ability_GetKeyValueByName_System_ReadOnlySpan_System_Byte__"></a> GetKeyValueByName\(ReadOnlySpan<byte\>\)

```csharp
public static KeyValues? GetKeyValueByName(ReadOnlySpan<byte> name)
```

#### Parameters

`name` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

#### Returns

 [KeyValues](Divine.Source2.KeyValues.md)?

### <a id="Divine_Entity_Entities_Abilities_Ability_Upgrade"></a> Upgrade\(\)

```csharp
public bool Upgrade()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

