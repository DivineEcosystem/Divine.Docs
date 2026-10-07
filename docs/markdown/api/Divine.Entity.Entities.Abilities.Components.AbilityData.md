# <a id="Divine_Entity_Entities_Abilities_Components_AbilityData"></a> Class AbilityData

Namespace: [Divine.Entity.Entities.Abilities.Components](Divine.Entity.Entities.Abilities.Components.md)  
Assembly: Divine.dll  

```csharp
public sealed class AbilityData
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AbilityData](Divine.Entity.Entities.Abilities.Components.AbilityData.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<AbilityData\>\(AbilityData, params AbilityData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Fields

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_Native"></a> Native

```csharp
public readonly nint Native
```

#### Field Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

## Properties

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_AbilityBehavior"></a> AbilityBehavior

```csharp
public AbilityBehavior AbilityBehavior { get; }
```

#### Property Value

 [AbilityBehavior](Divine.Entity.Entities.Abilities.Components.AbilityBehavior.md)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_AbilityIndex"></a> AbilityIndex

```csharp
public ushort AbilityIndex { get; }
```

#### Property Value

 [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_AbilitySpecialData"></a> AbilitySpecialData

```csharp
public IEnumerable<AbilitySpecialData> AbilitySpecialData { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[AbilitySpecialData](Divine.Entity.Entities.Abilities.Components.AbilitySpecialData.md)\>

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_AbilityType"></a> AbilityType

```csharp
public AbilityType AbilityType { get; }
```

#### Property Value

 [AbilityType](Divine.Entity.Entities.Abilities.Components.AbilityType.md)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_AlternateModelName"></a> AlternateModelName

```csharp
public string AlternateModelName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_AnimationIgnoresModelScale"></a> AnimationIgnoresModelScale

```csharp
public bool AnimationIgnoresModelScale { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_Cost"></a> Cost

```csharp
public uint Cost { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_DamageType"></a> DamageType

```csharp
public DamageType DamageType { get; }
```

#### Property Value

 [DamageType](Divine.Entity.Entities.Abilities.Components.DamageType.md)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_DependentOnAbility"></a> DependentOnAbility

```csharp
public string DependentOnAbility { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_DispellableType"></a> DispellableType

```csharp
public DispellableType DispellableType { get; }
```

#### Property Value

 [DispellableType](Divine.Entity.Entities.Abilities.Components.DispellableType.md)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_DisplayAdditionalHeroes"></a> DisplayAdditionalHeroes

```csharp
public bool DisplayAdditionalHeroes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_DisplayOverheadAlertOnReceived"></a> DisplayOverheadAlertOnReceived

```csharp
public bool DisplayOverheadAlertOnReceived { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_EffectName"></a> EffectName

```csharp
public string EffectName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_HasCastAnimation"></a> HasCastAnimation

```csharp
public bool HasCastAnimation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_Id"></a> Id

```csharp
public AbilityId Id { get; }
```

#### Property Value

 [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_IsAffectedByAoEIncrease"></a> IsAffectedByAoEIncrease

```csharp
public bool IsAffectedByAoEIncrease { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_IsAllowedInBackpack"></a> IsAllowedInBackpack

```csharp
public bool IsAllowedInBackpack { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_IsCastableWhileHidden"></a> IsCastableWhileHidden

```csharp
public bool IsCastableWhileHidden { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_IsGrantedByScepter"></a> IsGrantedByScepter

```csharp
public bool IsGrantedByScepter { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_IsGrantedByShard"></a> IsGrantedByShard

```csharp
public bool IsGrantedByShard { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_IsInnate"></a> IsInnate

```csharp
public bool IsInnate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_IsItem"></a> IsItem

```csharp
public bool IsItem { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_IsObsolete"></a> IsObsolete

```csharp
public bool IsObsolete { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_IsOnCastbar"></a> IsOnCastbar

```csharp
public bool IsOnCastbar { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_IsOnLearnbar"></a> IsOnLearnbar

```csharp
public bool IsOnLearnbar { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_IsPlayerSpecificCooldown"></a> IsPlayerSpecificCooldown

```csharp
public bool IsPlayerSpecificCooldown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_IsSpeciallyAllowedInNeutralSlot"></a> IsSpeciallyAllowedInNeutralSlot

```csharp
public bool IsSpeciallyAllowedInNeutralSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_ItemAvailableAtCustomShop"></a> ItemAvailableAtCustomShop

```csharp
public bool ItemAvailableAtCustomShop { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_ItemAvailableAtGlobalShop"></a> ItemAvailableAtGlobalShop

```csharp
public bool ItemAvailableAtGlobalShop { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_ItemAvailableAtSecretShop"></a> ItemAvailableAtSecretShop

```csharp
public bool ItemAvailableAtSecretShop { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_ItemAvailableAtSideShop"></a> ItemAvailableAtSideShop

```csharp
public bool ItemAvailableAtSideShop { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_ItemContributesToNetWorthWhenDropped"></a> ItemContributesToNetWorthWhenDropped

```csharp
public bool ItemContributesToNetWorthWhenDropped { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_ItemHasPassive"></a> ItemHasPassive

```csharp
public bool ItemHasPassive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_ItemIsPurchasable"></a> ItemIsPurchasable

```csharp
public bool ItemIsPurchasable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_ItemIsPureSupport"></a> ItemIsPureSupport

```csharp
public bool ItemIsPureSupport { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_ItemIsRecipe"></a> ItemIsRecipe

```csharp
public bool ItemIsRecipe { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_ItemIsRecipeGenerated"></a> ItemIsRecipeGenerated

```csharp
public bool ItemIsRecipeGenerated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_ItemIsUpgradeable"></a> ItemIsUpgradeable

```csharp
public bool ItemIsUpgradeable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_ItemRecipeConsumesCharges"></a> ItemRecipeConsumesCharges

```csharp
public bool ItemRecipeConsumesCharges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_ItemRecipeName"></a> ItemRecipeName

```csharp
public string ItemRecipeName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_ItemRequiresCustomShop"></a> ItemRequiresCustomShop

```csharp
public bool ItemRequiresCustomShop { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_ItemStackable"></a> ItemStackable

```csharp
public bool ItemStackable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_KeyValues"></a> KeyValues

```csharp
public KeyValues? KeyValues { get; }
```

#### Property Value

 [KeyValues](Divine.Source2.KeyValues.md)?

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_LevelsBeetweenUpgrades"></a> LevelsBeetweenUpgrades

```csharp
public int LevelsBeetweenUpgrades { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_MaximumLevel"></a> MaximumLevel

```csharp
public int MaximumLevel { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_ModelName"></a> ModelName

```csharp
public string ModelName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_NetworkActivity"></a> NetworkActivity

```csharp
public NetworkActivity NetworkActivity { get; }
```

#### Property Value

 [NetworkActivity](Divine.Entity.Entities.Components.NetworkActivity.md)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_NeutralTierIndex"></a> NeutralTierIndex

```csharp
public int NeutralTierIndex { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_RequiredLevel"></a> RequiredLevel

```csharp
public int RequiredLevel { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_SharedCooldownName"></a> SharedCooldownName

```csharp
public string SharedCooldownName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_SpellPierceImmunityType"></a> SpellPierceImmunityType

```csharp
public SpellPierceImmunityType SpellPierceImmunityType { get; }
```

#### Property Value

 [SpellPierceImmunityType](Divine.Entity.Entities.Abilities.Components.SpellPierceImmunityType.md)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_TargetFlags"></a> TargetFlags

```csharp
public TargetFlags TargetFlags { get; }
```

#### Property Value

 [TargetFlags](Divine.Entity.Entities.Abilities.Components.TargetFlags.md)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_TargetTeamType"></a> TargetTeamType

```csharp
public TargetTeamType TargetTeamType { get; }
```

#### Property Value

 [TargetTeamType](Divine.Entity.Entities.Abilities.Components.TargetTeamType.md)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_TargetType"></a> TargetType

```csharp
public TargetType TargetType { get; }
```

#### Property Value

 [TargetType](Divine.Entity.Entities.Abilities.Components.TargetType.md)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_TextureName"></a> TextureName

```csharp
public string TextureName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_GetCastPoint_System_UInt32_"></a> GetCastPoint\(uint\)

```csharp
public float GetCastPoint(uint index)
```

#### Parameters

`index` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_GetCastRange_System_UInt32_"></a> GetCastRange\(uint\)

```csharp
public int GetCastRange(uint index)
```

#### Parameters

`index` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_GetChannelMaximumTime_System_UInt32_"></a> GetChannelMaximumTime\(uint\)

```csharp
public float GetChannelMaximumTime(uint index)
```

#### Parameters

`index` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_GetChargeRestoreTime_System_UInt32_"></a> GetChargeRestoreTime\(uint\)

```csharp
public float GetChargeRestoreTime(uint index)
```

#### Parameters

`index` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_GetCharges_System_UInt32_"></a> GetCharges\(uint\)

```csharp
public int GetCharges(uint index)
```

#### Parameters

`index` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_GetCooldownLength_System_UInt32_"></a> GetCooldownLength\(uint\)

```csharp
public float GetCooldownLength(uint index)
```

#### Parameters

`index` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_GetDamage_System_UInt32_"></a> GetDamage\(uint\)

```csharp
public int GetDamage(uint index)
```

#### Parameters

`index` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_GetDuration_System_UInt32_"></a> GetDuration\(uint\)

```csharp
public float GetDuration(uint index)
```

#### Parameters

`index` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Abilities_Components_AbilityData_GetManaCost_System_UInt32_"></a> GetManaCost\(uint\)

```csharp
public int GetManaCost(uint index)
```

#### Parameters

`index` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

