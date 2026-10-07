# <a id="Divine_Extensions_AbilityExtensions"></a> Class AbilityExtensions

Namespace: [Divine.Extensions](Divine.Extensions.md)  
Assembly: Divine.dll  

```csharp
public static class AbilityExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AbilityExtensions](Divine.Extensions.AbilityExtensions.md)

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

### <a id="Divine_Extensions_AbilityExtensions_GetAbilitySlotInfo_Divine_Entity_Entities_Abilities_Ability_"></a> GetAbilitySlotInfo\(Ability\)

```csharp
public static (int Slot, int TalentStart) GetAbilitySlotInfo(this Ability ability)
```

#### Parameters

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

#### Returns

 \([int](https://learn.microsoft.com/dotnet/api/system.int32) [Slot](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.int32,system.int32\-.slot), [int](https://learn.microsoft.com/dotnet/api/system.int32) [TalentStart](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.int32,system.int32\-.talentstart)\)

### <a id="Divine_Extensions_AbilityExtensions_GetAbilitySpecialData_Divine_Entity_Entities_Abilities_Ability_System_String_"></a> GetAbilitySpecialData\(Ability, string\)

```csharp
public static float GetAbilitySpecialData(this Ability ability, string name)
```

#### Parameters

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_AbilityExtensions_GetAbilitySpecialData_Divine_Entity_Entities_Abilities_Ability_System_String_System_UInt32_"></a> GetAbilitySpecialData\(Ability, string, uint\)

```csharp
public static float GetAbilitySpecialData(this Ability ability, string name, uint level)
```

#### Parameters

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`level` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_AbilityExtensions_GetAbilitySpecialDataValue_Divine_Entity_Entities_Abilities_Ability_System_String_System_UInt32_"></a> GetAbilitySpecialDataValue\(Ability, string, uint\)

```csharp
public static float GetAbilitySpecialDataValue(this Ability ability, string name, uint level)
```

#### Parameters

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`level` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_AbilityExtensions_GetAbilitySpecialDataWithTalent_Divine_Entity_Entities_Abilities_Ability_Divine_Entity_Entities_Units_Unit_System_String_System_UInt32_"></a> GetAbilitySpecialDataWithTalent\(Ability, Unit, string, uint\)

```csharp
[Obsolete("Use GetAbilitySpecialData or GetAbilitySpecialDataValue")]
public static float GetAbilitySpecialDataWithTalent(this Ability ability, Unit owner, string name, uint level = 0)
```

#### Parameters

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`owner` [Unit](Divine.Entity.Entities.Units.Unit.md)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`level` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_AbilityExtensions_GetAbilitySpecialDataWithTalent_Divine_Entity_Entities_Abilities_Ability_Divine_Entity_Entities_Units_Unit_System_String_Divine_Entity_Entities_Abilities_Components_AbilityId_System_UInt32_"></a> GetAbilitySpecialDataWithTalent\(Ability, Unit, string, AbilityId, uint\)

```csharp
[Obsolete("Use GetAbilitySpecialData or GetAbilitySpecialDataValue")]
public static float GetAbilitySpecialDataWithTalent(this Ability ability, Unit owner, string name, AbilityId talentId, uint level = 0)
```

#### Parameters

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`owner` [Unit](Divine.Entity.Entities.Units.Unit.md)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`talentId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

`level` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_AbilityExtensions_GetCastPoint_Divine_Entity_Entities_Abilities_Ability_"></a> GetCastPoint\(Ability\)

```csharp
public static float GetCastPoint(this Ability ability)
```

#### Parameters

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

