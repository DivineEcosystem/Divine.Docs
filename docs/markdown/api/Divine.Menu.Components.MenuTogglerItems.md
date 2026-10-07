# <a id="Divine_Menu_Components_MenuTogglerItems"></a> Struct MenuTogglerItems

Namespace: [Divine.Menu.Components](Divine.Menu.Components.md)  
Assembly: Divine.dll  

```csharp
public readonly ref struct MenuTogglerItems
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Divine_Menu_Components_MenuTogglerItems__ctor_System_ReadOnlySpan_Divine_Menu_Components_MenuTogglerItem__"></a> MenuTogglerItems\(ReadOnlySpan<MenuTogglerItem\>\)

```csharp
public MenuTogglerItems(ReadOnlySpan<MenuTogglerItem> span)
```

#### Parameters

`span` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerItem](Divine.Menu.Components.MenuTogglerItem.md)\>

## Fields

### <a id="Divine_Menu_Components_MenuTogglerItems_Span"></a> Span

```csharp
public readonly ReadOnlySpan<MenuTogglerItem> Span
```

#### Field Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerItem](Divine.Menu.Components.MenuTogglerItem.md)\>

## Methods

### <a id="Divine_Menu_Components_MenuTogglerItems_Create_System_Span_Divine_Entity_Entities_Abilities_Items_Components_ItemId__"></a> Create\(Span<ItemId\>\)

```csharp
public static MenuTogglerItems Create(Span<ItemId> values)
```

#### Parameters

`values` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<[ItemId](Divine.Entity.Entities.Abilities.Items.Components.ItemId.md)\>

#### Returns

 [MenuTogglerItems](Divine.Menu.Components.MenuTogglerItems.md)

### <a id="Divine_Menu_Components_MenuTogglerItems_Create_System_ReadOnlySpan_Divine_Menu_Components_MenuTogglerItem__"></a> Create\(ReadOnlySpan<MenuTogglerItem\>\)

```csharp
public static MenuTogglerItems Create(ReadOnlySpan<MenuTogglerItem> values)
```

#### Parameters

`values` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerItem](Divine.Menu.Components.MenuTogglerItem.md)\>

#### Returns

 [MenuTogglerItems](Divine.Menu.Components.MenuTogglerItems.md)

### <a id="Divine_Menu_Components_MenuTogglerItems_GetEnumerator"></a> GetEnumerator\(\)

```csharp
public ReadOnlySpan<MenuTogglerItem>.Enumerator GetEnumerator()
```

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerItem](Divine.Menu.Components.MenuTogglerItem.md)\>.[Enumerator](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1.enumerator)

## Operators

### <a id="Divine_Menu_Components_MenuTogglerItems_op_Implicit_System_Collections_Generic_Dictionary_Divine_Entity_Entities_Abilities_Items_Components_ItemId_System_Boolean___Divine_Menu_Components_MenuTogglerItems"></a> implicit operator MenuTogglerItems\(Dictionary<ItemId, bool\>\)

```csharp
public static implicit operator MenuTogglerItems(Dictionary<ItemId, bool> values)
```

#### Parameters

`values` [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<[ItemId](Divine.Entity.Entities.Abilities.Items.Components.ItemId.md), [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

#### Returns

 [MenuTogglerItems](Divine.Menu.Components.MenuTogglerItems.md)

### <a id="Divine_Menu_Components_MenuTogglerItems_op_Implicit_System_Collections_Generic_HashSet_Divine_Entity_Entities_Abilities_Items_Components_ItemId___Divine_Menu_Components_MenuTogglerItems"></a> implicit operator MenuTogglerItems\(HashSet<ItemId\>\)

```csharp
public static implicit operator MenuTogglerItems(HashSet<ItemId> values)
```

#### Parameters

`values` [HashSet](https://learn.microsoft.com/dotnet/api/system.collections.generic.hashset\-1)<[ItemId](Divine.Entity.Entities.Abilities.Items.Components.ItemId.md)\>

#### Returns

 [MenuTogglerItems](Divine.Menu.Components.MenuTogglerItems.md)

### <a id="Divine_Menu_Components_MenuTogglerItems_op_Implicit_System_Collections_Generic_List_Divine_Entity_Entities_Abilities_Items_Components_ItemId___Divine_Menu_Components_MenuTogglerItems"></a> implicit operator MenuTogglerItems\(List<ItemId\>\)

```csharp
public static implicit operator MenuTogglerItems(List<ItemId> values)
```

#### Parameters

`values` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[ItemId](Divine.Entity.Entities.Abilities.Items.Components.ItemId.md)\>

#### Returns

 [MenuTogglerItems](Divine.Menu.Components.MenuTogglerItems.md)

### <a id="Divine_Menu_Components_MenuTogglerItems_op_Implicit_Divine_Entity_Entities_Abilities_Items_Components_ItemId____Divine_Menu_Components_MenuTogglerItems"></a> implicit operator MenuTogglerItems\(ItemId\[\]\)

```csharp
public static implicit operator MenuTogglerItems(ItemId[] values)
```

#### Parameters

`values` [ItemId](Divine.Entity.Entities.Abilities.Items.Components.ItemId.md)\[\]

#### Returns

 [MenuTogglerItems](Divine.Menu.Components.MenuTogglerItems.md)

### <a id="Divine_Menu_Components_MenuTogglerItems_op_Implicit_System_Span_Divine_Entity_Entities_Abilities_Items_Components_ItemId___Divine_Menu_Components_MenuTogglerItems"></a> implicit operator MenuTogglerItems\(Span<ItemId\>\)

```csharp
public static implicit operator MenuTogglerItems(Span<ItemId> values)
```

#### Parameters

`values` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<[ItemId](Divine.Entity.Entities.Abilities.Items.Components.ItemId.md)\>

#### Returns

 [MenuTogglerItems](Divine.Menu.Components.MenuTogglerItems.md)

### <a id="Divine_Menu_Components_MenuTogglerItems_op_Implicit_Divine_Menu_Components_MenuTogglerItem____Divine_Menu_Components_MenuTogglerItems"></a> implicit operator MenuTogglerItems\(MenuTogglerItem\[\]\)

```csharp
public static implicit operator MenuTogglerItems(MenuTogglerItem[] values)
```

#### Parameters

`values` [MenuTogglerItem](Divine.Menu.Components.MenuTogglerItem.md)\[\]

#### Returns

 [MenuTogglerItems](Divine.Menu.Components.MenuTogglerItems.md)

