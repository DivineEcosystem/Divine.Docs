# <a id="Divine_Menu_Components_MenuTogglerHeroes"></a> Struct MenuTogglerHeroes

Namespace: [Divine.Menu.Components](Divine.Menu.Components.md)  
Assembly: Divine.dll  

```csharp
public readonly ref struct MenuTogglerHeroes
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Divine_Menu_Components_MenuTogglerHeroes__ctor_System_ReadOnlySpan_Divine_Menu_Components_MenuTogglerHero__"></a> MenuTogglerHeroes\(ReadOnlySpan<MenuTogglerHero\>\)

```csharp
public MenuTogglerHeroes(ReadOnlySpan<MenuTogglerHero> span)
```

#### Parameters

`span` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerHero](Divine.Menu.Components.MenuTogglerHero.md)\>

## Fields

### <a id="Divine_Menu_Components_MenuTogglerHeroes_Span"></a> Span

```csharp
public readonly ReadOnlySpan<MenuTogglerHero> Span
```

#### Field Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerHero](Divine.Menu.Components.MenuTogglerHero.md)\>

## Methods

### <a id="Divine_Menu_Components_MenuTogglerHeroes_Create_System_Span_Divine_Entity_Entities_Units_Heroes_Components_HeroId__"></a> Create\(Span<HeroId\>\)

```csharp
public static MenuTogglerHeroes Create(Span<HeroId> values)
```

#### Parameters

`values` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<[HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)\>

#### Returns

 [MenuTogglerHeroes](Divine.Menu.Components.MenuTogglerHeroes.md)

### <a id="Divine_Menu_Components_MenuTogglerHeroes_Create_System_ReadOnlySpan_Divine_Menu_Components_MenuTogglerHero__"></a> Create\(ReadOnlySpan<MenuTogglerHero\>\)

```csharp
public static MenuTogglerHeroes Create(ReadOnlySpan<MenuTogglerHero> values)
```

#### Parameters

`values` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerHero](Divine.Menu.Components.MenuTogglerHero.md)\>

#### Returns

 [MenuTogglerHeroes](Divine.Menu.Components.MenuTogglerHeroes.md)

### <a id="Divine_Menu_Components_MenuTogglerHeroes_GetEnumerator"></a> GetEnumerator\(\)

```csharp
public ReadOnlySpan<MenuTogglerHero>.Enumerator GetEnumerator()
```

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerHero](Divine.Menu.Components.MenuTogglerHero.md)\>.[Enumerator](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1.enumerator)

## Operators

### <a id="Divine_Menu_Components_MenuTogglerHeroes_op_Implicit_System_Collections_Generic_Dictionary_Divine_Entity_Entities_Units_Heroes_Components_HeroId_System_Boolean___Divine_Menu_Components_MenuTogglerHeroes"></a> implicit operator MenuTogglerHeroes\(Dictionary<HeroId, bool\>\)

```csharp
public static implicit operator MenuTogglerHeroes(Dictionary<HeroId, bool> values)
```

#### Parameters

`values` [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<[HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md), [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

#### Returns

 [MenuTogglerHeroes](Divine.Menu.Components.MenuTogglerHeroes.md)

### <a id="Divine_Menu_Components_MenuTogglerHeroes_op_Implicit_System_Collections_Generic_HashSet_Divine_Entity_Entities_Units_Heroes_Components_HeroId___Divine_Menu_Components_MenuTogglerHeroes"></a> implicit operator MenuTogglerHeroes\(HashSet<HeroId\>\)

```csharp
public static implicit operator MenuTogglerHeroes(HashSet<HeroId> values)
```

#### Parameters

`values` [HashSet](https://learn.microsoft.com/dotnet/api/system.collections.generic.hashset\-1)<[HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)\>

#### Returns

 [MenuTogglerHeroes](Divine.Menu.Components.MenuTogglerHeroes.md)

### <a id="Divine_Menu_Components_MenuTogglerHeroes_op_Implicit_System_Collections_Generic_List_Divine_Entity_Entities_Units_Heroes_Components_HeroId___Divine_Menu_Components_MenuTogglerHeroes"></a> implicit operator MenuTogglerHeroes\(List<HeroId\>\)

```csharp
public static implicit operator MenuTogglerHeroes(List<HeroId> values)
```

#### Parameters

`values` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)\>

#### Returns

 [MenuTogglerHeroes](Divine.Menu.Components.MenuTogglerHeroes.md)

### <a id="Divine_Menu_Components_MenuTogglerHeroes_op_Implicit_Divine_Entity_Entities_Units_Heroes_Components_HeroId____Divine_Menu_Components_MenuTogglerHeroes"></a> implicit operator MenuTogglerHeroes\(HeroId\[\]\)

```csharp
public static implicit operator MenuTogglerHeroes(HeroId[] values)
```

#### Parameters

`values` [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)\[\]

#### Returns

 [MenuTogglerHeroes](Divine.Menu.Components.MenuTogglerHeroes.md)

### <a id="Divine_Menu_Components_MenuTogglerHeroes_op_Implicit_System_Span_Divine_Entity_Entities_Units_Heroes_Components_HeroId___Divine_Menu_Components_MenuTogglerHeroes"></a> implicit operator MenuTogglerHeroes\(Span<HeroId\>\)

```csharp
public static implicit operator MenuTogglerHeroes(Span<HeroId> values)
```

#### Parameters

`values` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<[HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)\>

#### Returns

 [MenuTogglerHeroes](Divine.Menu.Components.MenuTogglerHeroes.md)

### <a id="Divine_Menu_Components_MenuTogglerHeroes_op_Implicit_Divine_Menu_Components_MenuTogglerHero____Divine_Menu_Components_MenuTogglerHeroes"></a> implicit operator MenuTogglerHeroes\(MenuTogglerHero\[\]\)

```csharp
public static implicit operator MenuTogglerHeroes(MenuTogglerHero[] values)
```

#### Parameters

`values` [MenuTogglerHero](Divine.Menu.Components.MenuTogglerHero.md)\[\]

#### Returns

 [MenuTogglerHeroes](Divine.Menu.Components.MenuTogglerHeroes.md)

