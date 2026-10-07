# <a id="Divine_Entity_Entities_Units_Components_Spellbook"></a> Class Spellbook

Namespace: [Divine.Entity.Entities.Units.Components](Divine.Entity.Entities.Units.Components.md)  
Assembly: Divine.dll  

```csharp
public sealed class Spellbook
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Spellbook](Divine.Entity.Entities.Units.Components.Spellbook.md)

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
[EnumerableExtensions.In<Spellbook\>\(Spellbook, params Spellbook\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Entity_Entities_Units_Components_Spellbook_ConsumableItems"></a> ConsumableItems

```csharp
public IEnumerable<Spell> ConsumableItems { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Spell](Divine.Entity.Entities.Abilities.Spells.Spell.md)\>

### <a id="Divine_Entity_Entities_Units_Components_Spellbook_HighFive"></a> HighFive

```csharp
public Spell? HighFive { get; }
```

#### Property Value

 [Spell](Divine.Entity.Entities.Abilities.Spells.Spell.md)?

### <a id="Divine_Entity_Entities_Units_Components_Spellbook_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Components_Spellbook_MainSpells"></a> MainSpells

```csharp
public IEnumerable<Spell> MainSpells { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Spell](Divine.Entity.Entities.Abilities.Spells.Spell.md)\>

### <a id="Divine_Entity_Entities_Units_Components_Spellbook_Owner"></a> Owner

```csharp
public Unit Owner { get; }
```

#### Property Value

 [Unit](Divine.Entity.Entities.Units.Unit.md)

### <a id="Divine_Entity_Entities_Units_Components_Spellbook_Spell1"></a> Spell1

```csharp
public Spell? Spell1 { get; }
```

#### Property Value

 [Spell](Divine.Entity.Entities.Abilities.Spells.Spell.md)?

### <a id="Divine_Entity_Entities_Units_Components_Spellbook_Spell2"></a> Spell2

```csharp
public Spell? Spell2 { get; }
```

#### Property Value

 [Spell](Divine.Entity.Entities.Abilities.Spells.Spell.md)?

### <a id="Divine_Entity_Entities_Units_Components_Spellbook_Spell3"></a> Spell3

```csharp
public Spell? Spell3 { get; }
```

#### Property Value

 [Spell](Divine.Entity.Entities.Abilities.Spells.Spell.md)?

### <a id="Divine_Entity_Entities_Units_Components_Spellbook_Spell4"></a> Spell4

```csharp
public Spell? Spell4 { get; }
```

#### Property Value

 [Spell](Divine.Entity.Entities.Abilities.Spells.Spell.md)?

### <a id="Divine_Entity_Entities_Units_Components_Spellbook_Spell5"></a> Spell5

```csharp
public Spell? Spell5 { get; }
```

#### Property Value

 [Spell](Divine.Entity.Entities.Abilities.Spells.Spell.md)?

### <a id="Divine_Entity_Entities_Units_Components_Spellbook_Spell6"></a> Spell6

```csharp
public Spell? Spell6 { get; }
```

#### Property Value

 [Spell](Divine.Entity.Entities.Abilities.Spells.Spell.md)?

### <a id="Divine_Entity_Entities_Units_Components_Spellbook_Spells"></a> Spells

```csharp
public IEnumerable<Spell> Spells { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Spell](Divine.Entity.Entities.Abilities.Spells.Spell.md)\>

### <a id="Divine_Entity_Entities_Units_Components_Spellbook_Talents"></a> Talents

```csharp
public IEnumerable<Spell> Talents { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Spell](Divine.Entity.Entities.Abilities.Spells.Spell.md)\>

## Methods

### <a id="Divine_Entity_Entities_Units_Components_Spellbook_GetSlot_Divine_Entity_Entities_Abilities_Spells_Spell_"></a> GetSlot\(Spell\)

```csharp
public SpellSlot GetSlot(Spell spell)
```

#### Parameters

`spell` [Spell](Divine.Entity.Entities.Abilities.Spells.Spell.md)

#### Returns

 [SpellSlot](Divine.Entity.Entities.Abilities.Spells.Components.SpellSlot.md)

### <a id="Divine_Entity_Entities_Units_Components_Spellbook_GetSpell_Divine_Entity_Entities_Abilities_Spells_Components_SpellSlot_"></a> GetSpell\(SpellSlot\)

```csharp
public Spell? GetSpell(SpellSlot spellSlot)
```

#### Parameters

`spellSlot` [SpellSlot](Divine.Entity.Entities.Abilities.Spells.Components.SpellSlot.md)

#### Returns

 [Spell](Divine.Entity.Entities.Abilities.Spells.Spell.md)?

### <a id="Divine_Entity_Entities_Units_Components_Spellbook_GetSpellById_Divine_Entity_Entities_Abilities_Components_AbilityId_"></a> GetSpellById\(AbilityId\)

```csharp
public Spell? GetSpellById(AbilityId abilityId)
```

#### Parameters

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

#### Returns

 [Spell](Divine.Entity.Entities.Abilities.Spells.Spell.md)?

### <a id="Divine_Entity_Entities_Units_Components_Spellbook_GetSpellByName_System_String_"></a> GetSpellByName\(string\)

```csharp
public Spell? GetSpellByName(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Spell](Divine.Entity.Entities.Abilities.Spells.Spell.md)?

### <a id="Divine_Entity_Entities_Units_Components_Spellbook_GetSpells_Divine_Entity_Entities_Abilities_Spells_Components_SpellSlot_Divine_Entity_Entities_Abilities_Spells_Components_SpellSlot_"></a> GetSpells\(SpellSlot, SpellSlot\)

```csharp
public IEnumerable<Spell> GetSpells(SpellSlot startSlot, SpellSlot endSlot)
```

#### Parameters

`startSlot` [SpellSlot](Divine.Entity.Entities.Abilities.Spells.Components.SpellSlot.md)

`endSlot` [SpellSlot](Divine.Entity.Entities.Abilities.Spells.Components.SpellSlot.md)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Spell](Divine.Entity.Entities.Abilities.Spells.Spell.md)\>

