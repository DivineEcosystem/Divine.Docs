# <a id="Divine_Menu_Items_IMenuItemExtensions"></a> Interface IMenuItemExtensions

Namespace: [Divine.Menu.Items](Divine.Menu.Items.md)  
Assembly: Divine.dll  

```csharp
public interface IMenuItemExtensions
```

#### Extension Methods

[MenuExtensions.Disable<IMenuItemExtensions\>\(IMenuItemExtensions\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Disable\_\_1\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[MenuExtensions.Enable<IMenuItemExtensions\>\(IMenuItemExtensions\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Enable\_\_1\_\_\_0\_), 
[MenuExtensions.Hide<IMenuItemExtensions\>\(IMenuItemExtensions\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Hide\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<IMenuItemExtensions\>\(IMenuItemExtensions, params IMenuItemExtensions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[MenuExtensions.Load<IMenuItemExtensions\>\(IMenuItemExtensions\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Load\_\_1\_\_\_0\_), 
[MenuExtensions.Move<IMenuItemExtensions\>\(IMenuItemExtensions, int\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Move\_\_1\_\_\_0\_System\_Int32\_), 
[MenuExtensions.Refresh<IMenuItemExtensions\>\(IMenuItemExtensions, bool, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Refresh\_\_1\_\_\_0\_System\_Boolean\_System\_Boolean\_), 
[MenuExtensions.Reset<IMenuItemExtensions\>\(IMenuItemExtensions\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Reset\_\_1\_\_\_0\_), 
[MenuExtensions.Save<IMenuItemExtensions\>\(IMenuItemExtensions, MenuSaveMode\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Save\_\_1\_\_\_0\_Divine\_Menu\_Components\_MenuSaveMode\_), 
[MenuExtensions.SetImage<IMenuItemExtensions\>\(IMenuItemExtensions, HeroId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Units\_Heroes\_Components\_HeroId\_System\_Boolean\_), 
[MenuExtensions.SetImage<IMenuItemExtensions\>\(IMenuItemExtensions, ItemId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Items\_Components\_ItemId\_System\_Boolean\_), 
[MenuExtensions.SetImage<IMenuItemExtensions\>\(IMenuItemExtensions, AbilityId\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_), 
[MenuExtensions.SetImage<IMenuItemExtensions\>\(IMenuItemExtensions, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<IMenuItemExtensions\>\(IMenuItemExtensions, string, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<IMenuItemExtensions\>\(IMenuItemExtensions, MenuImageKey?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_Nullable\_Divine\_Menu\_Components\_MenuImageKey\_\_), 
[MenuExtensions.SetImageFromResources<IMenuItemExtensions\>\(IMenuItemExtensions, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.SetImageFromResources<IMenuItemExtensions\>\(IMenuItemExtensions, string, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_System\_String\_), 
[MenuExtensions.SetTooltip<IMenuItemExtensions\>\(IMenuItemExtensions, string?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetTooltip\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.Show<IMenuItemExtensions\>\(IMenuItemExtensions\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Show\_\_1\_\_\_0\_)

## Methods

### <a id="Divine_Menu_Items_IMenuItemExtensions_Disable"></a> Disable\(\)

```csharp
IMenuItemExtensions Disable()
```

#### Returns

 [IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

### <a id="Divine_Menu_Items_IMenuItemExtensions_Enable"></a> Enable\(\)

```csharp
IMenuItemExtensions Enable()
```

#### Returns

 [IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

### <a id="Divine_Menu_Items_IMenuItemExtensions_Hide"></a> Hide\(\)

```csharp
IMenuItemExtensions Hide()
```

#### Returns

 [IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

### <a id="Divine_Menu_Items_IMenuItemExtensions_Load"></a> Load\(\)

```csharp
IMenuItemExtensions Load()
```

#### Returns

 [IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

### <a id="Divine_Menu_Items_IMenuItemExtensions_Move_System_Int32_"></a> Move\(int\)

```csharp
IMenuItemExtensions Move(int priority)
```

#### Parameters

`priority` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

### <a id="Divine_Menu_Items_IMenuItemExtensions_Refresh_System_Boolean_System_Boolean_"></a> Refresh\(bool, bool\)

```csharp
IMenuItemExtensions Refresh(bool parentRefresh = true, bool checkContextVisible = true)
```

#### Parameters

`parentRefresh` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`checkContextVisible` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

### <a id="Divine_Menu_Items_IMenuItemExtensions_Reset"></a> Reset\(\)

```csharp
IMenuItemExtensions Reset()
```

#### Returns

 [IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

### <a id="Divine_Menu_Items_IMenuItemExtensions_Save_Divine_Menu_Components_MenuSaveMode_"></a> Save\(MenuSaveMode\)

```csharp
IMenuItemExtensions Save(MenuSaveMode saveMode = MenuSaveMode.Force)
```

#### Parameters

`saveMode` [MenuSaveMode](Divine.Menu.Components.MenuSaveMode.md)

#### Returns

 [IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

### <a id="Divine_Menu_Items_IMenuItemExtensions_SetImage_Divine_Entity_Entities_Units_Heroes_Components_HeroId_System_Boolean_"></a> SetImage\(HeroId, bool\)

```csharp
IMenuItemExtensions SetImage(HeroId heroId, bool square = false)
```

#### Parameters

`heroId` [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)

`square` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

### <a id="Divine_Menu_Items_IMenuItemExtensions_SetImage_Divine_Entity_Entities_Abilities_Items_Components_ItemId_System_Boolean_"></a> SetImage\(ItemId, bool\)

```csharp
IMenuItemExtensions SetImage(ItemId itemId, bool square = false)
```

#### Parameters

`itemId` [ItemId](Divine.Entity.Entities.Abilities.Items.Components.ItemId.md)

`square` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

### <a id="Divine_Menu_Items_IMenuItemExtensions_SetImage_Divine_Entity_Entities_Abilities_Components_AbilityId_"></a> SetImage\(AbilityId\)

```csharp
IMenuItemExtensions SetImage(AbilityId abilityId)
```

#### Parameters

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

#### Returns

 [IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

### <a id="Divine_Menu_Items_IMenuItemExtensions_SetImage_System_String_Divine_Renderer_ImageType_"></a> SetImage\(string, ImageType\)

```csharp
IMenuItemExtensions SetImage(string key, ImageType type = ImageType.Default)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`type` [ImageType](Divine.Renderer.ImageType.md)

#### Returns

 [IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

### <a id="Divine_Menu_Items_IMenuItemExtensions_SetImage_System_String_System_String_Divine_Renderer_ImageType_"></a> SetImage\(string, string, ImageType\)

```csharp
IMenuItemExtensions SetImage(string key, string path, ImageType type = ImageType.Default)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

`type` [ImageType](Divine.Renderer.ImageType.md)

#### Returns

 [IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

### <a id="Divine_Menu_Items_IMenuItemExtensions_SetImage_System_Nullable_Divine_Menu_Components_MenuImageKey__"></a> SetImage\(MenuImageKey?\)

```csharp
IMenuItemExtensions SetImage(MenuImageKey? imageKey)
```

#### Parameters

`imageKey` [MenuImageKey](Divine.Menu.Components.MenuImageKey.md)?

#### Returns

 [IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

### <a id="Divine_Menu_Items_IMenuItemExtensions_SetImageFromResources_System_String_"></a> SetImageFromResources\(string\)

```csharp
IMenuItemExtensions SetImageFromResources(string key)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

### <a id="Divine_Menu_Items_IMenuItemExtensions_SetImageFromResources_System_String_System_String_"></a> SetImageFromResources\(string, string\)

```csharp
IMenuItemExtensions SetImageFromResources(string key, string path)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

### <a id="Divine_Menu_Items_IMenuItemExtensions_SetTooltip_System_String_"></a> SetTooltip\(string?\)

```csharp
IMenuItemExtensions SetTooltip(string? tooltip)
```

#### Parameters

`tooltip` [string](https://learn.microsoft.com/dotnet/api/system.string)?

#### Returns

 [IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

### <a id="Divine_Menu_Items_IMenuItemExtensions_Show"></a> Show\(\)

```csharp
IMenuItemExtensions Show()
```

#### Returns

 [IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

