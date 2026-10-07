# <a id="Divine_Entity_Entities_Units_Components_Inventory"></a> Class Inventory

Namespace: [Divine.Entity.Entities.Units.Components](Divine.Entity.Entities.Units.Components.md)  
Assembly: Divine.dll  

```csharp
public sealed class Inventory
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Inventory](Divine.Entity.Entities.Units.Components.Inventory.md)

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
[EnumerableExtensions.In<Inventory\>\(Inventory, params Inventory\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Entity_Entities_Units_Components_Inventory__ctor_Divine_Entity_Entities_Units_Unit_"></a> Inventory\(Unit\)

```csharp
public Inventory(Unit owner)
```

#### Parameters

`owner` [Unit](Divine.Entity.Entities.Units.Unit.md)

## Properties

### <a id="Divine_Entity_Entities_Units_Components_Inventory_BackpackItems"></a> BackpackItems

```csharp
public IEnumerable<Item> BackpackItems { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Item](Divine.Entity.Entities.Abilities.Items.Item.md)\>

### <a id="Divine_Entity_Entities_Units_Components_Inventory_FreeBackpackSlots"></a> FreeBackpackSlots

```csharp
public IEnumerable<ItemSlot> FreeBackpackSlots { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[ItemSlot](Divine.Entity.Entities.Abilities.Items.Components.ItemSlot.md)\>

### <a id="Divine_Entity_Entities_Units_Components_Inventory_FreeMainSlots"></a> FreeMainSlots

```csharp
public IEnumerable<ItemSlot> FreeMainSlots { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[ItemSlot](Divine.Entity.Entities.Abilities.Items.Components.ItemSlot.md)\>

### <a id="Divine_Entity_Entities_Units_Components_Inventory_FreeSlots"></a> FreeSlots

```csharp
public IEnumerable<ItemSlot> FreeSlots { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[ItemSlot](Divine.Entity.Entities.Abilities.Items.Components.ItemSlot.md)\>

### <a id="Divine_Entity_Entities_Units_Components_Inventory_FreeStashSlots"></a> FreeStashSlots

```csharp
public IEnumerable<ItemSlot> FreeStashSlots { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[ItemSlot](Divine.Entity.Entities.Abilities.Items.Components.ItemSlot.md)\>

### <a id="Divine_Entity_Entities_Units_Components_Inventory_IsStashEnabled"></a> IsStashEnabled

```csharp
public bool IsStashEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Components_Inventory_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Components_Inventory_Item1"></a> Item1

```csharp
public Item? Item1 { get; }
```

#### Property Value

 [Item](Divine.Entity.Entities.Abilities.Items.Item.md)?

### <a id="Divine_Entity_Entities_Units_Components_Inventory_Item2"></a> Item2

```csharp
public Item? Item2 { get; }
```

#### Property Value

 [Item](Divine.Entity.Entities.Abilities.Items.Item.md)?

### <a id="Divine_Entity_Entities_Units_Components_Inventory_Item3"></a> Item3

```csharp
public Item? Item3 { get; }
```

#### Property Value

 [Item](Divine.Entity.Entities.Abilities.Items.Item.md)?

### <a id="Divine_Entity_Entities_Units_Components_Inventory_Item4"></a> Item4

```csharp
public Item? Item4 { get; }
```

#### Property Value

 [Item](Divine.Entity.Entities.Abilities.Items.Item.md)?

### <a id="Divine_Entity_Entities_Units_Components_Inventory_Item5"></a> Item5

```csharp
public Item? Item5 { get; }
```

#### Property Value

 [Item](Divine.Entity.Entities.Abilities.Items.Item.md)?

### <a id="Divine_Entity_Entities_Units_Components_Inventory_Item6"></a> Item6

```csharp
public Item? Item6 { get; }
```

#### Property Value

 [Item](Divine.Entity.Entities.Abilities.Items.Item.md)?

### <a id="Divine_Entity_Entities_Units_Components_Inventory_Items"></a> Items

```csharp
public IEnumerable<Item> Items { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Item](Divine.Entity.Entities.Abilities.Items.Item.md)\>

### <a id="Divine_Entity_Entities_Units_Components_Inventory_MainItems"></a> MainItems

```csharp
public IEnumerable<Item> MainItems { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Item](Divine.Entity.Entities.Abilities.Items.Item.md)\>

### <a id="Divine_Entity_Entities_Units_Components_Inventory_NeutralItem"></a> NeutralItem

```csharp
public Item? NeutralItem { get; }
```

#### Property Value

 [Item](Divine.Entity.Entities.Abilities.Items.Item.md)?

### <a id="Divine_Entity_Entities_Units_Components_Inventory_Owner"></a> Owner

```csharp
public Unit Owner { get; }
```

#### Property Value

 [Unit](Divine.Entity.Entities.Units.Unit.md)

### <a id="Divine_Entity_Entities_Units_Components_Inventory_StashItems"></a> StashItems

```csharp
public IEnumerable<Item> StashItems { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Item](Divine.Entity.Entities.Abilities.Items.Item.md)\>

### <a id="Divine_Entity_Entities_Units_Components_Inventory_TownPortalScroll"></a> TownPortalScroll

```csharp
public Item? TownPortalScroll { get; }
```

#### Property Value

 [Item](Divine.Entity.Entities.Abilities.Items.Item.md)?

## Methods

### <a id="Divine_Entity_Entities_Units_Components_Inventory_GetFreeSlots_Divine_Entity_Entities_Abilities_Items_Components_ItemSlot_Divine_Entity_Entities_Abilities_Items_Components_ItemSlot_"></a> GetFreeSlots\(ItemSlot, ItemSlot\)

```csharp
public IEnumerable<ItemSlot> GetFreeSlots(ItemSlot startSlot, ItemSlot endSlot)
```

#### Parameters

`startSlot` [ItemSlot](Divine.Entity.Entities.Abilities.Items.Components.ItemSlot.md)

`endSlot` [ItemSlot](Divine.Entity.Entities.Abilities.Items.Components.ItemSlot.md)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[ItemSlot](Divine.Entity.Entities.Abilities.Items.Components.ItemSlot.md)\>

### <a id="Divine_Entity_Entities_Units_Components_Inventory_GetItem_Divine_Entity_Entities_Abilities_Items_Components_ItemSlot_"></a> GetItem\(ItemSlot\)

```csharp
public Item? GetItem(ItemSlot itemSlot)
```

#### Parameters

`itemSlot` [ItemSlot](Divine.Entity.Entities.Abilities.Items.Components.ItemSlot.md)

#### Returns

 [Item](Divine.Entity.Entities.Abilities.Items.Item.md)?

### <a id="Divine_Entity_Entities_Units_Components_Inventory_GetItems_Divine_Entity_Entities_Abilities_Items_Components_ItemSlot_Divine_Entity_Entities_Abilities_Items_Components_ItemSlot_"></a> GetItems\(ItemSlot, ItemSlot\)

```csharp
public IEnumerable<Item> GetItems(ItemSlot startSlot, ItemSlot endSlot)
```

#### Parameters

`startSlot` [ItemSlot](Divine.Entity.Entities.Abilities.Items.Components.ItemSlot.md)

`endSlot` [ItemSlot](Divine.Entity.Entities.Abilities.Items.Components.ItemSlot.md)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Item](Divine.Entity.Entities.Abilities.Items.Item.md)\>

### <a id="Divine_Entity_Entities_Units_Components_Inventory_GetItemsById_Divine_Entity_Entities_Abilities_Components_AbilityId_"></a> GetItemsById\(AbilityId\)

```csharp
public IEnumerable<Item> GetItemsById(AbilityId abilityId)
```

#### Parameters

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Item](Divine.Entity.Entities.Abilities.Items.Item.md)\>

### <a id="Divine_Entity_Entities_Units_Components_Inventory_GetItemsByName_System_String_"></a> GetItemsByName\(string\)

```csharp
public IEnumerable<Item> GetItemsByName(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Item](Divine.Entity.Entities.Abilities.Items.Item.md)\>

### <a id="Divine_Entity_Entities_Units_Components_Inventory_Move_Divine_Entity_Entities_Abilities_Items_Components_ItemSlot_Divine_Entity_Entities_Abilities_Items_Components_ItemSlot_"></a> Move\(ItemSlot, ItemSlot\)

```csharp
public bool Move(ItemSlot sourceSlot, ItemSlot targetSlot)
```

#### Parameters

`sourceSlot` [ItemSlot](Divine.Entity.Entities.Abilities.Items.Components.ItemSlot.md)

`targetSlot` [ItemSlot](Divine.Entity.Entities.Abilities.Items.Components.ItemSlot.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Components_Inventory_Move_Divine_Entity_Entities_Abilities_Items_Item_Divine_Entity_Entities_Abilities_Items_Components_ItemSlot_"></a> Move\(Item, ItemSlot\)

```csharp
public bool Move(Item item, ItemSlot targetSlot)
```

#### Parameters

`item` [Item](Divine.Entity.Entities.Abilities.Items.Item.md)

`targetSlot` [ItemSlot](Divine.Entity.Entities.Abilities.Items.Components.ItemSlot.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

