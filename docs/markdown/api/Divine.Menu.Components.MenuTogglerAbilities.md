# <a id="Divine_Menu_Components_MenuTogglerAbilities"></a> Struct MenuTogglerAbilities

Namespace: [Divine.Menu.Components](Divine.Menu.Components.md)  
Assembly: Divine.dll  

```csharp
public readonly ref struct MenuTogglerAbilities
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Divine_Menu_Components_MenuTogglerAbilities__ctor_System_ReadOnlySpan_Divine_Menu_Components_MenuTogglerAbility__"></a> MenuTogglerAbilities\(ReadOnlySpan<MenuTogglerAbility\>\)

```csharp
public MenuTogglerAbilities(ReadOnlySpan<MenuTogglerAbility> span)
```

#### Parameters

`span` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerAbility](Divine.Menu.Components.MenuTogglerAbility.md)\>

## Fields

### <a id="Divine_Menu_Components_MenuTogglerAbilities_Span"></a> Span

```csharp
public readonly ReadOnlySpan<MenuTogglerAbility> Span
```

#### Field Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerAbility](Divine.Menu.Components.MenuTogglerAbility.md)\>

## Methods

### <a id="Divine_Menu_Components_MenuTogglerAbilities_Create_System_Span_Divine_Entity_Entities_Abilities_Components_AbilityId__"></a> Create\(Span<AbilityId\>\)

```csharp
public static MenuTogglerAbilities Create(Span<AbilityId> values)
```

#### Parameters

`values` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<[AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)\>

#### Returns

 [MenuTogglerAbilities](Divine.Menu.Components.MenuTogglerAbilities.md)

### <a id="Divine_Menu_Components_MenuTogglerAbilities_Create_System_ReadOnlySpan_Divine_Menu_Components_MenuTogglerAbility__"></a> Create\(ReadOnlySpan<MenuTogglerAbility\>\)

```csharp
public static MenuTogglerAbilities Create(ReadOnlySpan<MenuTogglerAbility> values)
```

#### Parameters

`values` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerAbility](Divine.Menu.Components.MenuTogglerAbility.md)\>

#### Returns

 [MenuTogglerAbilities](Divine.Menu.Components.MenuTogglerAbilities.md)

### <a id="Divine_Menu_Components_MenuTogglerAbilities_GetEnumerator"></a> GetEnumerator\(\)

```csharp
public ReadOnlySpan<MenuTogglerAbility>.Enumerator GetEnumerator()
```

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerAbility](Divine.Menu.Components.MenuTogglerAbility.md)\>.[Enumerator](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1.enumerator)

## Operators

### <a id="Divine_Menu_Components_MenuTogglerAbilities_op_Implicit_System_Collections_Generic_Dictionary_Divine_Entity_Entities_Abilities_Components_AbilityId_System_Boolean___Divine_Menu_Components_MenuTogglerAbilities"></a> implicit operator MenuTogglerAbilities\(Dictionary<AbilityId, bool\>\)

```csharp
public static implicit operator MenuTogglerAbilities(Dictionary<AbilityId, bool> values)
```

#### Parameters

`values` [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<[AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md), [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

#### Returns

 [MenuTogglerAbilities](Divine.Menu.Components.MenuTogglerAbilities.md)

### <a id="Divine_Menu_Components_MenuTogglerAbilities_op_Implicit_System_Collections_Generic_HashSet_Divine_Entity_Entities_Abilities_Components_AbilityId___Divine_Menu_Components_MenuTogglerAbilities"></a> implicit operator MenuTogglerAbilities\(HashSet<AbilityId\>\)

```csharp
public static implicit operator MenuTogglerAbilities(HashSet<AbilityId> values)
```

#### Parameters

`values` [HashSet](https://learn.microsoft.com/dotnet/api/system.collections.generic.hashset\-1)<[AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)\>

#### Returns

 [MenuTogglerAbilities](Divine.Menu.Components.MenuTogglerAbilities.md)

### <a id="Divine_Menu_Components_MenuTogglerAbilities_op_Implicit_System_Collections_Generic_List_Divine_Entity_Entities_Abilities_Components_AbilityId___Divine_Menu_Components_MenuTogglerAbilities"></a> implicit operator MenuTogglerAbilities\(List<AbilityId\>\)

```csharp
public static implicit operator MenuTogglerAbilities(List<AbilityId> values)
```

#### Parameters

`values` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)\>

#### Returns

 [MenuTogglerAbilities](Divine.Menu.Components.MenuTogglerAbilities.md)

### <a id="Divine_Menu_Components_MenuTogglerAbilities_op_Implicit_Divine_Entity_Entities_Abilities_Components_AbilityId____Divine_Menu_Components_MenuTogglerAbilities"></a> implicit operator MenuTogglerAbilities\(AbilityId\[\]\)

```csharp
public static implicit operator MenuTogglerAbilities(AbilityId[] values)
```

#### Parameters

`values` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)\[\]

#### Returns

 [MenuTogglerAbilities](Divine.Menu.Components.MenuTogglerAbilities.md)

### <a id="Divine_Menu_Components_MenuTogglerAbilities_op_Implicit_System_Span_Divine_Entity_Entities_Abilities_Components_AbilityId___Divine_Menu_Components_MenuTogglerAbilities"></a> implicit operator MenuTogglerAbilities\(Span<AbilityId\>\)

```csharp
public static implicit operator MenuTogglerAbilities(Span<AbilityId> values)
```

#### Parameters

`values` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<[AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)\>

#### Returns

 [MenuTogglerAbilities](Divine.Menu.Components.MenuTogglerAbilities.md)

### <a id="Divine_Menu_Components_MenuTogglerAbilities_op_Implicit_Divine_Menu_Components_MenuTogglerAbility____Divine_Menu_Components_MenuTogglerAbilities"></a> implicit operator MenuTogglerAbilities\(MenuTogglerAbility\[\]\)

```csharp
public static implicit operator MenuTogglerAbilities(MenuTogglerAbility[] values)
```

#### Parameters

`values` [MenuTogglerAbility](Divine.Menu.Components.MenuTogglerAbility.md)\[\]

#### Returns

 [MenuTogglerAbilities](Divine.Menu.Components.MenuTogglerAbilities.md)

