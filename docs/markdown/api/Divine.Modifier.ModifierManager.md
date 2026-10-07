# <a id="Divine_Modifier_ModifierManager"></a> Class ModifierManager

Namespace: [Divine.Modifier](Divine.Modifier.md)  
Assembly: Divine.dll  

```csharp
public static class ModifierManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ModifierManager](Divine.Modifier.ModifierManager.md)

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

## Properties

### <a id="Divine_Modifier_ModifierManager_ModifierNames"></a> ModifierNames

```csharp
public static IReadOnlyList<string> ModifierNames { get; }
```

#### Property Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Modifier_ModifierManager_Modifiers"></a> Modifiers

```csharp
public static IEnumerable<Modifier> Modifiers { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Modifier](Divine.Modifier.Modifiers.Modifier.md)\>

## Methods

### <a id="Divine_Modifier_ModifierManager_AddModifier_Divine_Entity_Entities_Units_Unit_System_String_Divine_Entity_Entities_Entity_Divine_Entity_Entities_Abilities_Ability_Divine_Source2_KeyValues_"></a> AddModifier\(Unit, string, Entity?, Ability?, KeyValues?\)

```csharp
public static Modifier? AddModifier(Unit unit, string name, Entity? caster = null, Ability? ability = null, KeyValues? keyValues = null)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`caster` [Entity](Divine.Entity.Entities.Entity.md)?

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)?

`keyValues` [KeyValues](Divine.Source2.KeyValues.md)?

#### Returns

 [Modifier](Divine.Modifier.Modifiers.Modifier.md)?

### <a id="Divine_Modifier_ModifierManager_ModifierAdded"></a> ModifierAdded

```csharp
public static event ModifierManager.ModifierAddedEventHandler? ModifierAdded
```

#### Event Type

 [ModifierManager](Divine.Modifier.ModifierManager.md).[ModifierAddedEventHandler](Divine.Modifier.ModifierManager.ModifierAddedEventHandler.md)?

### <a id="Divine_Modifier_ModifierManager_ModifierRemoved"></a> ModifierRemoved

```csharp
public static event ModifierManager.ModifierRemovedEventHandler? ModifierRemoved
```

#### Event Type

 [ModifierManager](Divine.Modifier.ModifierManager.md).[ModifierRemovedEventHandler](Divine.Modifier.ModifierManager.ModifierRemovedEventHandler.md)?

