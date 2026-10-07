# <a id="Divine_Menu_Components_MenuTogglerItem"></a> Class MenuTogglerItem

Namespace: [Divine.Menu.Components](Divine.Menu.Components.md)  
Assembly: Divine.dll  

```csharp
public sealed class MenuTogglerItem : MenuTogglerValue<ItemId>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuValue<ItemId, bool\>](Divine.Menu.Components.MenuValue\-2.md) ← 
[MenuTogglerValue<ItemId\>](Divine.Menu.Components.MenuTogglerValue\-1.md) ← 
[MenuTogglerItem](Divine.Menu.Components.MenuTogglerItem.md)

#### Inherited Members

[MenuTogglerValue<ItemId\>.ImageKey](Divine.Menu.Components.MenuTogglerValue\-1.md\#Divine\_Menu\_Components\_MenuTogglerValue\_1\_ImageKey), 
[MenuValue<ItemId, bool\>.Key](Divine.Menu.Components.MenuValue\-2.md\#Divine\_Menu\_Components\_MenuValue\_2\_Key), 
[MenuValue<ItemId, bool\>.Value](Divine.Menu.Components.MenuValue\-2.md\#Divine\_Menu\_Components\_MenuValue\_2\_Value), 
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
[EnumerableExtensions.In<MenuTogglerItem\>\(MenuTogglerItem, params MenuTogglerItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Menu_Components_MenuTogglerItem__ctor_Divine_Entity_Entities_Abilities_Items_Components_ItemId_System_Boolean_"></a> MenuTogglerItem\(ItemId, bool\)

```csharp
[SetsRequiredMembers]
public MenuTogglerItem(ItemId key, bool value)
```

#### Parameters

`key` [ItemId](Divine.Entity.Entities.Abilities.Items.Components.ItemId.md)

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Components_MenuTogglerItem__ctor_Divine_Entity_Entities_Abilities_Items_Components_ItemId_"></a> MenuTogglerItem\(ItemId\)

```csharp
[SetsRequiredMembers]
public MenuTogglerItem(ItemId key)
```

#### Parameters

`key` [ItemId](Divine.Entity.Entities.Abilities.Items.Components.ItemId.md)

## Operators

### <a id="Divine_Menu_Components_MenuTogglerItem_op_Implicit_System_ValueTuple_Divine_Entity_Entities_Abilities_Items_Components_ItemId_System_Boolean___Divine_Menu_Components_MenuTogglerItem"></a> implicit operator MenuTogglerItem\(\(ItemId Key, bool Value\)\)

```csharp
public static implicit operator MenuTogglerItem((ItemId Key, bool Value) togglerImage)
```

#### Parameters

`togglerImage` \([ItemId](Divine.Entity.Entities.Abilities.Items.Components.ItemId.md) [Key](https://learn.microsoft.com/dotnet/api/system.valuetuple\-divine.entity.entities.abilities.items.components.itemid,system.boolean\-.key), [bool](https://learn.microsoft.com/dotnet/api/system.boolean) [Value](https://learn.microsoft.com/dotnet/api/system.valuetuple\-divine.entity.entities.abilities.items.components.itemid,system.boolean\-.value)\)

#### Returns

 [MenuTogglerItem](Divine.Menu.Components.MenuTogglerItem.md)

### <a id="Divine_Menu_Components_MenuTogglerItem_op_Implicit_System_Collections_Generic_KeyValuePair_Divine_Entity_Entities_Abilities_Items_Components_ItemId_System_Boolean___Divine_Menu_Components_MenuTogglerItem"></a> implicit operator MenuTogglerItem\(KeyValuePair<ItemId, bool\>\)

```csharp
public static implicit operator MenuTogglerItem(KeyValuePair<ItemId, bool> pair)
```

#### Parameters

`pair` [KeyValuePair](https://learn.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair\-2)<[ItemId](Divine.Entity.Entities.Abilities.Items.Components.ItemId.md), [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

#### Returns

 [MenuTogglerItem](Divine.Menu.Components.MenuTogglerItem.md)

### <a id="Divine_Menu_Components_MenuTogglerItem_op_Implicit_Divine_Entity_Entities_Abilities_Items_Components_ItemId__Divine_Menu_Components_MenuTogglerItem"></a> implicit operator MenuTogglerItem\(ItemId\)

```csharp
public static implicit operator MenuTogglerItem(ItemId key)
```

#### Parameters

`key` [ItemId](Divine.Entity.Entities.Abilities.Items.Components.ItemId.md)

#### Returns

 [MenuTogglerItem](Divine.Menu.Components.MenuTogglerItem.md)

