# <a id="Divine_Protobufs_Dota2_CMsgGameDataHero"></a> Class CMsgGameDataHero

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameDataHero : IMessage<CMsgGameDataHero>, IEquatable<CMsgGameDataHero>, IDeepCloneable<CMsgGameDataHero>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameDataHero](Divine.Protobufs.Dota2.CMsgGameDataHero.md)

#### Implements

IMessage<CMsgGameDataHero\>, 
[IEquatable<CMsgGameDataHero\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameDataHero\>, 
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
[EnumerableExtensions.In<CMsgGameDataHero\>\(CMsgGameDataHero, params CMsgGameDataHero\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero__ctor"></a> CMsgGameDataHero\(\)

```csharp
public CMsgGameDataHero()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero__ctor_Divine_Protobufs_Dota2_CMsgGameDataHero_"></a> CMsgGameDataHero\(CMsgGameDataHero\)

```csharp
public CMsgGameDataHero(CMsgGameDataHero other)
```

#### Parameters

`other` [CMsgGameDataHero](Divine.Protobufs.Dota2.CMsgGameDataHero.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_AbilitiesFieldNumber"></a> AbilitiesFieldNumber

```csharp
public const int AbilitiesFieldNumber = 40
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_AgiBaseFieldNumber"></a> AgiBaseFieldNumber

```csharp
public const int AgiBaseFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_AgiGainFieldNumber"></a> AgiGainFieldNumber

```csharp
public const int AgiGainFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ArmorFieldNumber"></a> ArmorFieldNumber

```csharp
public const int ArmorFieldNumber = 29
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_AttackCapabilityFieldNumber"></a> AttackCapabilityFieldNumber

```csharp
public const int AttackCapabilityFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_AttackRangeFieldNumber"></a> AttackRangeFieldNumber

```csharp
public const int AttackRangeFieldNumber = 27
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_AttackRateFieldNumber"></a> AttackRateFieldNumber

```csharp
public const int AttackRateFieldNumber = 26
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_BioLocFieldNumber"></a> BioLocFieldNumber

```csharp
public const int BioLocFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ComplexityFieldNumber"></a> ComplexityFieldNumber

```csharp
public const int ComplexityFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_DamageMaxFieldNumber"></a> DamageMaxFieldNumber

```csharp
public const int DamageMaxFieldNumber = 25
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_DamageMinFieldNumber"></a> DamageMinFieldNumber

```csharp
public const int DamageMinFieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_FacetAbilitiesFieldNumber"></a> FacetAbilitiesFieldNumber

```csharp
public const int FacetAbilitiesFieldNumber = 42
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_FacetsFieldNumber"></a> FacetsFieldNumber

```csharp
public const int FacetsFieldNumber = 43
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HealthRegenFieldNumber"></a> HealthRegenFieldNumber

```csharp
public const int HealthRegenFieldNumber = 36
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HypeLocFieldNumber"></a> HypeLocFieldNumber

```csharp
public const int HypeLocFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_IntBaseFieldNumber"></a> IntBaseFieldNumber

```csharp
public const int IntBaseFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_IntGainFieldNumber"></a> IntGainFieldNumber

```csharp
public const int IntGainFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_MagicResistanceFieldNumber"></a> MagicResistanceFieldNumber

```csharp
public const int MagicResistanceFieldNumber = 30
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ManaRegenFieldNumber"></a> ManaRegenFieldNumber

```csharp
public const int ManaRegenFieldNumber = 38
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_MaxHealthFieldNumber"></a> MaxHealthFieldNumber

```csharp
public const int MaxHealthFieldNumber = 35
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_MaxManaFieldNumber"></a> MaxManaFieldNumber

```csharp
public const int MaxManaFieldNumber = 37
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_MovementSpeedFieldNumber"></a> MovementSpeedFieldNumber

```csharp
public const int MovementSpeedFieldNumber = 31
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_NameLocFieldNumber"></a> NameLocFieldNumber

```csharp
public const int NameLocFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_NpeDescLocFieldNumber"></a> NpeDescLocFieldNumber

```csharp
public const int NpeDescLocFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_OrderIdFieldNumber"></a> OrderIdFieldNumber

```csharp
public const int OrderIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_PrimaryAttrFieldNumber"></a> PrimaryAttrFieldNumber

```csharp
public const int PrimaryAttrFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ProjectileSpeedFieldNumber"></a> ProjectileSpeedFieldNumber

```csharp
public const int ProjectileSpeedFieldNumber = 28
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_RoleLevelsFieldNumber"></a> RoleLevelsFieldNumber

```csharp
public const int RoleLevelsFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_SightRangeDayFieldNumber"></a> SightRangeDayFieldNumber

```csharp
public const int SightRangeDayFieldNumber = 33
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_SightRangeNightFieldNumber"></a> SightRangeNightFieldNumber

```csharp
public const int SightRangeNightFieldNumber = 34
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_StrBaseFieldNumber"></a> StrBaseFieldNumber

```csharp
public const int StrBaseFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_StrGainFieldNumber"></a> StrGainFieldNumber

```csharp
public const int StrGainFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_TalentsFieldNumber"></a> TalentsFieldNumber

```csharp
public const int TalentsFieldNumber = 41
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_TurnRateFieldNumber"></a> TurnRateFieldNumber

```csharp
public const int TurnRateFieldNumber = 32
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Abilities"></a> Abilities

```csharp
public RepeatedField<CMsgGameDataAbilityOrItem> Abilities { get; }
```

#### Property Value

 RepeatedField<[CMsgGameDataAbilityOrItem](Divine.Protobufs.Dota2.CMsgGameDataAbilityOrItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_AgiBase"></a> AgiBase

```csharp
public uint AgiBase { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_AgiGain"></a> AgiGain

```csharp
public float AgiGain { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Armor"></a> Armor

```csharp
public float Armor { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_AttackCapability"></a> AttackCapability

```csharp
public uint AttackCapability { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_AttackRange"></a> AttackRange

```csharp
public uint AttackRange { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_AttackRate"></a> AttackRate

```csharp
public float AttackRate { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_BioLoc"></a> BioLoc

```csharp
public string BioLoc { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Complexity"></a> Complexity

```csharp
public uint Complexity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_DamageMax"></a> DamageMax

```csharp
public int DamageMax { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_DamageMin"></a> DamageMin

```csharp
public int DamageMin { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_FacetAbilities"></a> FacetAbilities

```csharp
public RepeatedField<CMsgGameDataAbilityOrItemList> FacetAbilities { get; }
```

#### Property Value

 RepeatedField<[CMsgGameDataAbilityOrItemList](Divine.Protobufs.Dota2.CMsgGameDataAbilityOrItemList.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Facets"></a> Facets

```csharp
public RepeatedField<CMsgGameDataHero.Types.Facet> Facets { get; }
```

#### Property Value

 RepeatedField<[CMsgGameDataHero](Divine.Protobufs.Dota2.CMsgGameDataHero.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataHero.Types.md).[Facet](Divine.Protobufs.Dota2.CMsgGameDataHero.Types.Facet.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasAgiBase"></a> HasAgiBase

```csharp
public bool HasAgiBase { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasAgiGain"></a> HasAgiGain

```csharp
public bool HasAgiGain { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasArmor"></a> HasArmor

```csharp
public bool HasArmor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasAttackCapability"></a> HasAttackCapability

```csharp
public bool HasAttackCapability { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasAttackRange"></a> HasAttackRange

```csharp
public bool HasAttackRange { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasAttackRate"></a> HasAttackRate

```csharp
public bool HasAttackRate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasBioLoc"></a> HasBioLoc

```csharp
public bool HasBioLoc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasComplexity"></a> HasComplexity

```csharp
public bool HasComplexity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasDamageMax"></a> HasDamageMax

```csharp
public bool HasDamageMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasDamageMin"></a> HasDamageMin

```csharp
public bool HasDamageMin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasHealthRegen"></a> HasHealthRegen

```csharp
public bool HasHealthRegen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasHypeLoc"></a> HasHypeLoc

```csharp
public bool HasHypeLoc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasIntBase"></a> HasIntBase

```csharp
public bool HasIntBase { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasIntGain"></a> HasIntGain

```csharp
public bool HasIntGain { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasMagicResistance"></a> HasMagicResistance

```csharp
public bool HasMagicResistance { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasManaRegen"></a> HasManaRegen

```csharp
public bool HasManaRegen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasMaxHealth"></a> HasMaxHealth

```csharp
public bool HasMaxHealth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasMaxMana"></a> HasMaxMana

```csharp
public bool HasMaxMana { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasMovementSpeed"></a> HasMovementSpeed

```csharp
public bool HasMovementSpeed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasNameLoc"></a> HasNameLoc

```csharp
public bool HasNameLoc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasNpeDescLoc"></a> HasNpeDescLoc

```csharp
public bool HasNpeDescLoc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasOrderId"></a> HasOrderId

```csharp
public bool HasOrderId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasPrimaryAttr"></a> HasPrimaryAttr

```csharp
public bool HasPrimaryAttr { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasProjectileSpeed"></a> HasProjectileSpeed

```csharp
public bool HasProjectileSpeed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasSightRangeDay"></a> HasSightRangeDay

```csharp
public bool HasSightRangeDay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasSightRangeNight"></a> HasSightRangeNight

```csharp
public bool HasSightRangeNight { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasStrBase"></a> HasStrBase

```csharp
public bool HasStrBase { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasStrGain"></a> HasStrGain

```csharp
public bool HasStrGain { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HasTurnRate"></a> HasTurnRate

```csharp
public bool HasTurnRate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HealthRegen"></a> HealthRegen

```csharp
public float HealthRegen { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_HypeLoc"></a> HypeLoc

```csharp
public string HypeLoc { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Id"></a> Id

```csharp
public int Id { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_IntBase"></a> IntBase

```csharp
public uint IntBase { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_IntGain"></a> IntGain

```csharp
public float IntGain { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_MagicResistance"></a> MagicResistance

```csharp
public uint MagicResistance { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ManaRegen"></a> ManaRegen

```csharp
public float ManaRegen { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_MaxHealth"></a> MaxHealth

```csharp
public uint MaxHealth { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_MaxMana"></a> MaxMana

```csharp
public uint MaxMana { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_MovementSpeed"></a> MovementSpeed

```csharp
public uint MovementSpeed { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_NameLoc"></a> NameLoc

```csharp
public string NameLoc { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_NpeDescLoc"></a> NpeDescLoc

```csharp
public string NpeDescLoc { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_OrderId"></a> OrderId

```csharp
public uint OrderId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameDataHero> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameDataHero](Divine.Protobufs.Dota2.CMsgGameDataHero.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_PrimaryAttr"></a> PrimaryAttr

```csharp
public uint PrimaryAttr { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ProjectileSpeed"></a> ProjectileSpeed

```csharp
public uint ProjectileSpeed { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_RoleLevels"></a> RoleLevels

```csharp
public RepeatedField<uint> RoleLevels { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_SightRangeDay"></a> SightRangeDay

```csharp
public uint SightRangeDay { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_SightRangeNight"></a> SightRangeNight

```csharp
public uint SightRangeNight { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_StrBase"></a> StrBase

```csharp
public uint StrBase { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_StrGain"></a> StrGain

```csharp
public float StrGain { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Talents"></a> Talents

```csharp
public RepeatedField<CMsgGameDataAbilityOrItem> Talents { get; }
```

#### Property Value

 RepeatedField<[CMsgGameDataAbilityOrItem](Divine.Protobufs.Dota2.CMsgGameDataAbilityOrItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_TurnRate"></a> TurnRate

```csharp
public float TurnRate { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearAgiBase"></a> ClearAgiBase\(\)

```csharp
public void ClearAgiBase()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearAgiGain"></a> ClearAgiGain\(\)

```csharp
public void ClearAgiGain()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearArmor"></a> ClearArmor\(\)

```csharp
public void ClearArmor()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearAttackCapability"></a> ClearAttackCapability\(\)

```csharp
public void ClearAttackCapability()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearAttackRange"></a> ClearAttackRange\(\)

```csharp
public void ClearAttackRange()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearAttackRate"></a> ClearAttackRate\(\)

```csharp
public void ClearAttackRate()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearBioLoc"></a> ClearBioLoc\(\)

```csharp
public void ClearBioLoc()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearComplexity"></a> ClearComplexity\(\)

```csharp
public void ClearComplexity()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearDamageMax"></a> ClearDamageMax\(\)

```csharp
public void ClearDamageMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearDamageMin"></a> ClearDamageMin\(\)

```csharp
public void ClearDamageMin()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearHealthRegen"></a> ClearHealthRegen\(\)

```csharp
public void ClearHealthRegen()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearHypeLoc"></a> ClearHypeLoc\(\)

```csharp
public void ClearHypeLoc()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearIntBase"></a> ClearIntBase\(\)

```csharp
public void ClearIntBase()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearIntGain"></a> ClearIntGain\(\)

```csharp
public void ClearIntGain()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearMagicResistance"></a> ClearMagicResistance\(\)

```csharp
public void ClearMagicResistance()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearManaRegen"></a> ClearManaRegen\(\)

```csharp
public void ClearManaRegen()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearMaxHealth"></a> ClearMaxHealth\(\)

```csharp
public void ClearMaxHealth()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearMaxMana"></a> ClearMaxMana\(\)

```csharp
public void ClearMaxMana()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearMovementSpeed"></a> ClearMovementSpeed\(\)

```csharp
public void ClearMovementSpeed()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearNameLoc"></a> ClearNameLoc\(\)

```csharp
public void ClearNameLoc()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearNpeDescLoc"></a> ClearNpeDescLoc\(\)

```csharp
public void ClearNpeDescLoc()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearOrderId"></a> ClearOrderId\(\)

```csharp
public void ClearOrderId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearPrimaryAttr"></a> ClearPrimaryAttr\(\)

```csharp
public void ClearPrimaryAttr()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearProjectileSpeed"></a> ClearProjectileSpeed\(\)

```csharp
public void ClearProjectileSpeed()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearSightRangeDay"></a> ClearSightRangeDay\(\)

```csharp
public void ClearSightRangeDay()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearSightRangeNight"></a> ClearSightRangeNight\(\)

```csharp
public void ClearSightRangeNight()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearStrBase"></a> ClearStrBase\(\)

```csharp
public void ClearStrBase()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearStrGain"></a> ClearStrGain\(\)

```csharp
public void ClearStrGain()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ClearTurnRate"></a> ClearTurnRate\(\)

```csharp
public void ClearTurnRate()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Clone"></a> Clone\(\)

```csharp
public CMsgGameDataHero Clone()
```

#### Returns

 [CMsgGameDataHero](Divine.Protobufs.Dota2.CMsgGameDataHero.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Equals_Divine_Protobufs_Dota2_CMsgGameDataHero_"></a> Equals\(CMsgGameDataHero\)

```csharp
public bool Equals(CMsgGameDataHero other)
```

#### Parameters

`other` [CMsgGameDataHero](Divine.Protobufs.Dota2.CMsgGameDataHero.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_MergeFrom_Divine_Protobufs_Dota2_CMsgGameDataHero_"></a> MergeFrom\(CMsgGameDataHero\)

```csharp
public void MergeFrom(CMsgGameDataHero other)
```

#### Parameters

`other` [CMsgGameDataHero](Divine.Protobufs.Dota2.CMsgGameDataHero.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

