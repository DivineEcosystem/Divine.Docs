# <a id="Divine_Menu_Components_MenuTogglerHero"></a> Class MenuTogglerHero

Namespace: [Divine.Menu.Components](Divine.Menu.Components.md)  
Assembly: Divine.dll  

```csharp
public sealed class MenuTogglerHero : MenuTogglerValue<HeroId>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuValue<HeroId, bool\>](Divine.Menu.Components.MenuValue\-2.md) ← 
[MenuTogglerValue<HeroId\>](Divine.Menu.Components.MenuTogglerValue\-1.md) ← 
[MenuTogglerHero](Divine.Menu.Components.MenuTogglerHero.md)

#### Inherited Members

[MenuTogglerValue<HeroId\>.ImageKey](Divine.Menu.Components.MenuTogglerValue\-1.md\#Divine\_Menu\_Components\_MenuTogglerValue\_1\_ImageKey), 
[MenuValue<HeroId, bool\>.Key](Divine.Menu.Components.MenuValue\-2.md\#Divine\_Menu\_Components\_MenuValue\_2\_Key), 
[MenuValue<HeroId, bool\>.Value](Divine.Menu.Components.MenuValue\-2.md\#Divine\_Menu\_Components\_MenuValue\_2\_Value), 
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
[EnumerableExtensions.In<MenuTogglerHero\>\(MenuTogglerHero, params MenuTogglerHero\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Menu_Components_MenuTogglerHero__ctor_Divine_Entity_Entities_Units_Heroes_Components_HeroId_System_Boolean_"></a> MenuTogglerHero\(HeroId, bool\)

```csharp
[SetsRequiredMembers]
public MenuTogglerHero(HeroId key, bool value)
```

#### Parameters

`key` [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Components_MenuTogglerHero__ctor_Divine_Entity_Entities_Units_Heroes_Components_HeroId_"></a> MenuTogglerHero\(HeroId\)

```csharp
[SetsRequiredMembers]
public MenuTogglerHero(HeroId key)
```

#### Parameters

`key` [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)

## Operators

### <a id="Divine_Menu_Components_MenuTogglerHero_op_Implicit_System_ValueTuple_Divine_Entity_Entities_Units_Heroes_Components_HeroId_System_Boolean___Divine_Menu_Components_MenuTogglerHero"></a> implicit operator MenuTogglerHero\(\(HeroId Key, bool Value\)\)

```csharp
public static implicit operator MenuTogglerHero((HeroId Key, bool Value) togglerImage)
```

#### Parameters

`togglerImage` \([HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md) [Key](https://learn.microsoft.com/dotnet/api/system.valuetuple\-divine.entity.entities.units.heroes.components.heroid,system.boolean\-.key), [bool](https://learn.microsoft.com/dotnet/api/system.boolean) [Value](https://learn.microsoft.com/dotnet/api/system.valuetuple\-divine.entity.entities.units.heroes.components.heroid,system.boolean\-.value)\)

#### Returns

 [MenuTogglerHero](Divine.Menu.Components.MenuTogglerHero.md)

### <a id="Divine_Menu_Components_MenuTogglerHero_op_Implicit_System_Collections_Generic_KeyValuePair_Divine_Entity_Entities_Units_Heroes_Components_HeroId_System_Boolean___Divine_Menu_Components_MenuTogglerHero"></a> implicit operator MenuTogglerHero\(KeyValuePair<HeroId, bool\>\)

```csharp
public static implicit operator MenuTogglerHero(KeyValuePair<HeroId, bool> pair)
```

#### Parameters

`pair` [KeyValuePair](https://learn.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair\-2)<[HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md), [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

#### Returns

 [MenuTogglerHero](Divine.Menu.Components.MenuTogglerHero.md)

### <a id="Divine_Menu_Components_MenuTogglerHero_op_Implicit_Divine_Entity_Entities_Units_Heroes_Components_HeroId__Divine_Menu_Components_MenuTogglerHero"></a> implicit operator MenuTogglerHero\(HeroId\)

```csharp
public static implicit operator MenuTogglerHero(HeroId key)
```

#### Parameters

`key` [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)

#### Returns

 [MenuTogglerHero](Divine.Menu.Components.MenuTogglerHero.md)

