# <a id="Divine_Menu_MenuExtensions"></a> Class MenuExtensions

Namespace: [Divine.Menu](Divine.Menu.md)  
Assembly: Divine.dll  

```csharp
public static class MenuExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuExtensions](Divine.Menu.MenuExtensions.md)

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

### <a id="Divine_Menu_MenuExtensions_Collapse__1___0_"></a> Collapse<T\>\(T\)

```csharp
public static T Collapse<T>(this T item) where T : IMenuExpanderExtensions
```

#### Parameters

`item` T

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_Disable__1___0_"></a> Disable<T\>\(T\)

```csharp
public static T Disable<T>(this T item) where T : IMenuItemExtensions
```

#### Parameters

`item` T

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_Enable__1___0_"></a> Enable<T\>\(T\)

```csharp
public static T Enable<T>(this T item) where T : IMenuItemExtensions
```

#### Parameters

`item` T

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_Expand__1___0_"></a> Expand<T\>\(T\)

```csharp
public static T Expand<T>(this T item) where T : IMenuExpanderExtensions
```

#### Parameters

`item` T

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_Hide__1___0_"></a> Hide<T\>\(T\)

```csharp
public static T Hide<T>(this T item) where T : IMenuItemExtensions
```

#### Parameters

`item` T

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_Load__1___0_"></a> Load<T\>\(T\)

```csharp
public static T Load<T>(this T item) where T : IMenuItemExtensions
```

#### Parameters

`item` T

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_Move__1___0_System_Int32_"></a> Move<T\>\(T, int\)

```csharp
public static T Move<T>(this T item, int priority) where T : IMenuItemExtensions
```

#### Parameters

`item` T

`priority` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_Refresh__1___0_System_Boolean_System_Boolean_"></a> Refresh<T\>\(T, bool, bool\)

```csharp
public static T Refresh<T>(this T item, bool parentRefresh = true, bool checkContextVisible = true) where T : IMenuItemExtensions
```

#### Parameters

`item` T

`parentRefresh` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`checkContextVisible` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_Reset__1___0_"></a> Reset<T\>\(T\)

```csharp
public static T Reset<T>(this T item) where T : IMenuItemExtensions
```

#### Parameters

`item` T

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_ResetPriorities__1___0_"></a> ResetPriorities<T\>\(T\)

```csharp
public static T ResetPriorities<T>(this T item) where T : IMenuTogglerExtensions
```

#### Parameters

`item` T

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_ResetSwitcher__1___0_"></a> ResetSwitcher<T\>\(T\)

```csharp
public static T ResetSwitcher<T>(this T item) where T : IMenuExtensions
```

#### Parameters

`item` T

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_ResetValues__1___0_"></a> ResetValues<T\>\(T\)

```csharp
public static T ResetValues<T>(this T item) where T : IMenuTogglerExtensions
```

#### Parameters

`item` T

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_Save__1___0_Divine_Menu_Components_MenuSaveMode_"></a> Save<T\>\(T, MenuSaveMode\)

```csharp
public static T Save<T>(this T item, MenuSaveMode saveMode = MenuSaveMode.Force) where T : IMenuItemExtensions
```

#### Parameters

`item` T

`saveMode` [MenuSaveMode](Divine.Menu.Components.MenuSaveMode.md)

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_SetDisplayTextFontColor__1___0_System_Nullable_Vortice_Mathematics_Color__"></a> SetDisplayTextFontColor<T\>\(T, Color?\)

```csharp
public static T SetDisplayTextFontColor<T>(this T item, Color? color) where T : IMenuTextExtensions
```

#### Parameters

`item` T

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)?

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_SetImage__1___0_Divine_Entity_Entities_Units_Heroes_Components_HeroId_System_Boolean_"></a> SetImage<T\>\(T, HeroId, bool\)

```csharp
public static T SetImage<T>(this T item, HeroId heroId, bool square = false) where T : IMenuItemExtensions
```

#### Parameters

`item` T

`heroId` [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)

`square` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_SetImage__1___0_Divine_Entity_Entities_Abilities_Items_Components_ItemId_System_Boolean_"></a> SetImage<T\>\(T, ItemId, bool\)

```csharp
public static T SetImage<T>(this T item, ItemId itemId, bool square = false) where T : IMenuItemExtensions
```

#### Parameters

`item` T

`itemId` [ItemId](Divine.Entity.Entities.Abilities.Items.Components.ItemId.md)

`square` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_SetImage__1___0_Divine_Entity_Entities_Abilities_Components_AbilityId_"></a> SetImage<T\>\(T, AbilityId\)

```csharp
public static T SetImage<T>(this T item, AbilityId abilityId) where T : IMenuItemExtensions
```

#### Parameters

`item` T

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_SetImage__1___0_System_String_Divine_Renderer_ImageType_"></a> SetImage<T\>\(T, string, ImageType\)

```csharp
public static T SetImage<T>(this T item, string key, ImageType type = ImageType.Default) where T : IMenuItemExtensions
```

#### Parameters

`item` T

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`type` [ImageType](Divine.Renderer.ImageType.md)

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_SetImage__1___0_System_String_System_String_Divine_Renderer_ImageType_"></a> SetImage<T\>\(T, string, string, ImageType\)

```csharp
public static T SetImage<T>(this T item, string key, string path, ImageType type = ImageType.Default) where T : IMenuItemExtensions
```

#### Parameters

`item` T

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

`type` [ImageType](Divine.Renderer.ImageType.md)

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_SetImage__1___0_System_Nullable_Divine_Menu_Components_MenuImageKey__"></a> SetImage<T\>\(T, MenuImageKey?\)

```csharp
public static T SetImage<T>(this T item, MenuImageKey? imageKey) where T : IMenuItemExtensions
```

#### Parameters

`item` T

`imageKey` [MenuImageKey](Divine.Menu.Components.MenuImageKey.md)?

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_SetImageFromResources__1___0_System_String_"></a> SetImageFromResources<T\>\(T, string\)

```csharp
public static T SetImageFromResources<T>(this T item, string key) where T : IMenuItemExtensions
```

#### Parameters

`item` T

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_SetImageFromResources__1___0_System_String_System_String_"></a> SetImageFromResources<T\>\(T, string, string\)

```csharp
public static T SetImageFromResources<T>(this T item, string key, string path) where T : IMenuItemExtensions
```

#### Parameters

`item` T

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_SetPosition__1___0_System_Numerics_Vector2_"></a> SetPosition<T\>\(T, Vector2\)

```csharp
public static T SetPosition<T>(this T item, Vector2 position) where T : IMenuContextExtensions
```

#### Parameters

`item` T

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_SetSearchMark__1___0_System_Boolean_"></a> SetSearchMark<T\>\(T, bool\)

```csharp
public static T SetSearchMark<T>(this T item, bool value) where T : IMenuTextExtensions
```

#### Parameters

`item` T

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_SetTooltip__1___0_System_String_"></a> SetTooltip<T\>\(T, string?\)

```csharp
public static T SetTooltip<T>(this T item, string? tooltip) where T : IMenuItemExtensions
```

#### Parameters

`item` T

`tooltip` [string](https://learn.microsoft.com/dotnet/api/system.string)?

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Menu_MenuExtensions_Show__1___0_"></a> Show<T\>\(T\)

```csharp
public static T Show<T>(this T item) where T : IMenuItemExtensions
```

#### Parameters

`item` T

#### Returns

 T

#### Type Parameters

`T` 

