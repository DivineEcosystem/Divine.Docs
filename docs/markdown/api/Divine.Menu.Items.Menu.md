# <a id="Divine_Menu_Items_Menu"></a> Class Menu

Namespace: [Divine.Menu.Items](Divine.Menu.Items.md)  
Assembly: Divine.dll  

```csharp
public class Menu : MenuExpander, IDisposable, IMenuExtensions, IMenuExpanderExtensions, IMenuTextExtensions, IMenuItemExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuItem](Divine.Menu.Items.MenuItem.md) ← 
[MenuText](Divine.Menu.Items.MenuText.md) ← 
[MenuExpander](Divine.Menu.Items.MenuExpander.md) ← 
[Menu](Divine.Menu.Items.Menu.md)

#### Derived

[MenuContext](Divine.Menu.Items.MenuContext.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IMenuExtensions](Divine.Menu.Items.IMenuExtensions.md), 
[IMenuExpanderExtensions](Divine.Menu.Items.IMenuExpanderExtensions.md), 
[IMenuTextExtensions](Divine.Menu.Items.IMenuTextExtensions.md), 
[IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

#### Inherited Members

[MenuExpander.View](Divine.Menu.Items.MenuExpander.md\#Divine\_Menu\_Items\_MenuExpander\_View), 
[MenuExpander.IsExpanded](Divine.Menu.Items.MenuExpander.md\#Divine\_Menu\_Items\_MenuExpander\_IsExpanded), 
[MenuExpander.Expanded](Divine.Menu.Items.MenuExpander.md\#Divine\_Menu\_Items\_MenuExpander\_Expanded), 
[MenuExpander.Collapsed](Divine.Menu.Items.MenuExpander.md\#Divine\_Menu\_Items\_MenuExpander\_Collapsed), 
[MenuText.DefaultDisplayText](Divine.Menu.Items.MenuText.md\#Divine\_Menu\_Items\_MenuText\_DefaultDisplayText), 
[MenuText.DisplayText](Divine.Menu.Items.MenuText.md\#Divine\_Menu\_Items\_MenuText\_DisplayText), 
[MenuText.DisplayTextFontColor](Divine.Menu.Items.MenuText.md\#Divine\_Menu\_Items\_MenuText\_DisplayTextFontColor), 
[MenuItem.this\[string\]](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_Item\_System\_String\_), 
[MenuItem.Context](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_Context), 
[MenuItem.Root](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_Root), 
[MenuItem.Parent](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_Parent), 
[MenuItem.ContextStyle](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_ContextStyle), 
[MenuItem.View](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_View), 
[MenuItem.Views](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_Views), 
[MenuItem.Name](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_Name), 
[MenuItem.FullName](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_FullName), 
[MenuItem.IsContext](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_IsContext), 
[MenuItem.IsRoot](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_IsRoot), 
[MenuItem.IsDisposed](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_IsDisposed), 
[MenuItem.CanSave](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_CanSave), 
[MenuItem.IsHidden](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_IsHidden), 
[MenuItem.CanVisible](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_CanVisible), 
[MenuItem.IsVisible](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_IsVisible), 
[MenuItem.IsDisabled](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_IsDisabled), 
[MenuItem.IsSearcherMark](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_IsSearcherMark), 
[MenuItem.Flags](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_Flags), 
[MenuItem.Priority](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_Priority), 
[MenuItem.IsSelected](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_IsSelected), 
[MenuItem.ImageKey](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_ImageKey), 
[MenuItem.Tooltip](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_Tooltip), 
[MenuItem.IsRequiresSave](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_IsRequiresSave), 
[MenuItem.OnRefresh\(\)](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_OnRefresh), 
[MenuItem.Dispose\(bool\)](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_Dispose\_System\_Boolean\_), 
[MenuItem.ToString\(\)](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_ToString), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[MenuExtensions.Collapse<Menu\>\(Menu\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Collapse\_\_1\_\_\_0\_), 
[MenuExtensions.Disable<Menu\>\(Menu\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Disable\_\_1\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[MenuExtensions.Enable<Menu\>\(Menu\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Enable\_\_1\_\_\_0\_), 
[MenuExtensions.Expand<Menu\>\(Menu\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Expand\_\_1\_\_\_0\_), 
[MenuExtensions.Hide<Menu\>\(Menu\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Hide\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<Menu\>\(Menu, params Menu\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[MenuExtensions.Load<Menu\>\(Menu\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Load\_\_1\_\_\_0\_), 
[MenuExtensions.Move<Menu\>\(Menu, int\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Move\_\_1\_\_\_0\_System\_Int32\_), 
[MenuExtensions.Refresh<Menu\>\(Menu, bool, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Refresh\_\_1\_\_\_0\_System\_Boolean\_System\_Boolean\_), 
[MenuExtensions.Reset<Menu\>\(Menu\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Reset\_\_1\_\_\_0\_), 
[MenuExtensions.ResetSwitcher<Menu\>\(Menu\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_ResetSwitcher\_\_1\_\_\_0\_), 
[MenuExtensions.Save<Menu\>\(Menu, MenuSaveMode\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Save\_\_1\_\_\_0\_Divine\_Menu\_Components\_MenuSaveMode\_), 
[MenuExtensions.SetDisplayTextFontColor<Menu\>\(Menu, Color?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetDisplayTextFontColor\_\_1\_\_\_0\_System\_Nullable\_Vortice\_Mathematics\_Color\_\_), 
[MenuExtensions.SetImage<Menu\>\(Menu, HeroId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Units\_Heroes\_Components\_HeroId\_System\_Boolean\_), 
[MenuExtensions.SetImage<Menu\>\(Menu, ItemId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Items\_Components\_ItemId\_System\_Boolean\_), 
[MenuExtensions.SetImage<Menu\>\(Menu, AbilityId\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_), 
[MenuExtensions.SetImage<Menu\>\(Menu, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<Menu\>\(Menu, string, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<Menu\>\(Menu, MenuImageKey?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_Nullable\_Divine\_Menu\_Components\_MenuImageKey\_\_), 
[MenuExtensions.SetImageFromResources<Menu\>\(Menu, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.SetImageFromResources<Menu\>\(Menu, string, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_System\_String\_), 
[MenuExtensions.SetSearchMark<Menu\>\(Menu, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetSearchMark\_\_1\_\_\_0\_System\_Boolean\_), 
[MenuExtensions.SetTooltip<Menu\>\(Menu, string?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetTooltip\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.Show<Menu\>\(Menu\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Show\_\_1\_\_\_0\_)

## Properties

### <a id="Divine_Menu_Items_Menu_DefaultValue"></a> DefaultValue

```csharp
public virtual bool DefaultValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_Menu_Items"></a> Items

```csharp
public IEnumerable<MenuItem> Items { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[MenuItem](Divine.Menu.Items.MenuItem.md)\>

### <a id="Divine_Menu_Items_Menu_Item_System_String_"></a> this\[string\]

```csharp
public override MenuObject this[string name] { get; }
```

#### Property Value

 [MenuObject](Divine.Menu.Objects.MenuObject.md)

### <a id="Divine_Menu_Items_Menu_Value"></a> Value

```csharp
public virtual bool Value { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_Menu_View"></a> View

```csharp
public IMenuView View { get; }
```

#### Property Value

 [IMenuView](Divine.Menu.Views.IMenuView.md)

## Methods

### <a id="Divine_Menu_Items_Menu_AddAbilityToggler_Divine_Menu_Components_MenuName_Divine_Menu_Components_MenuTogglerAbilities_System_Boolean_"></a> AddAbilityToggler\(MenuName, MenuTogglerAbilities, bool\)

```csharp
public MenuAbilityToggler AddAbilityToggler(MenuName name, MenuTogglerAbilities values = default, bool dontSave = false)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`values` [MenuTogglerAbilities](Divine.Menu.Components.MenuTogglerAbilities.md)

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuAbilityToggler](Divine.Menu.Items.MenuAbilityToggler.md)

### <a id="Divine_Menu_Items_Menu_AddAbilityToggler_Divine_Menu_Components_MenuName_Divine_Menu_Components_MenuTogglerOptions_Divine_Menu_Components_MenuTogglerAbilities_System_Boolean_"></a> AddAbilityToggler\(MenuName, MenuTogglerOptions, MenuTogglerAbilities, bool\)

```csharp
public MenuAbilityToggler AddAbilityToggler(MenuName name, MenuTogglerOptions options, MenuTogglerAbilities values = default, bool dontSave = false)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`options` [MenuTogglerOptions](Divine.Menu.Components.MenuTogglerOptions.md)

`values` [MenuTogglerAbilities](Divine.Menu.Components.MenuTogglerAbilities.md)

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuAbilityToggler](Divine.Menu.Items.MenuAbilityToggler.md)

### <a id="Divine_Menu_Items_Menu_AddButton_Divine_Menu_Components_MenuName_System_Boolean_"></a> AddButton\(MenuName, bool\)

```csharp
public MenuButton AddButton(MenuName name, bool withoutInnerButton = false)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`withoutInnerButton` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuButton](Divine.Menu.Items.MenuButton.md)

### <a id="Divine_Menu_Items_Menu_AddHeroToggler_Divine_Menu_Components_MenuName_Divine_Menu_Components_MenuTogglerHeroes_System_Boolean_"></a> AddHeroToggler\(MenuName, MenuTogglerHeroes, bool\)

```csharp
public MenuHeroToggler AddHeroToggler(MenuName name, MenuTogglerHeroes values = default, bool dontSave = false)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`values` [MenuTogglerHeroes](Divine.Menu.Components.MenuTogglerHeroes.md)

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuHeroToggler](Divine.Menu.Items.MenuHeroToggler.md)

### <a id="Divine_Menu_Items_Menu_AddHeroToggler_Divine_Menu_Components_MenuName_Divine_Menu_Components_MenuTogglerOptions_Divine_Menu_Components_MenuTogglerHeroes_System_Boolean_"></a> AddHeroToggler\(MenuName, MenuTogglerOptions, MenuTogglerHeroes, bool\)

```csharp
public MenuHeroToggler AddHeroToggler(MenuName name, MenuTogglerOptions options, MenuTogglerHeroes values = default, bool dontSave = false)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`options` [MenuTogglerOptions](Divine.Menu.Components.MenuTogglerOptions.md)

`values` [MenuTogglerHeroes](Divine.Menu.Components.MenuTogglerHeroes.md)

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuHeroToggler](Divine.Menu.Items.MenuHeroToggler.md)

### <a id="Divine_Menu_Items_Menu_AddHoldKey_Divine_Menu_Components_MenuName_Divine_Input_Key_System_Boolean_"></a> AddHoldKey\(MenuName, Key, bool\)

```csharp
public MenuHoldKey AddHoldKey(MenuName name, Key defaultKey = Key.None, bool dontSave = false)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`defaultKey` [Key](Divine.Input.Key.md)

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuHoldKey](Divine.Menu.Items.MenuHoldKey.md)

### <a id="Divine_Menu_Items_Menu_AddInputKey_Divine_Menu_Components_MenuName_Divine_Input_Key_System_Boolean_"></a> AddInputKey\(MenuName, Key, bool\)

```csharp
public MenuInputKey AddInputKey(MenuName name, Key defaultKey = Key.None, bool dontSave = false)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`defaultKey` [Key](Divine.Input.Key.md)

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuInputKey](Divine.Menu.Items.MenuInputKey.md)

### <a id="Divine_Menu_Items_Menu_AddInputText_Divine_Menu_Components_MenuName_System_String_System_Boolean_"></a> AddInputText\(MenuName, string?, bool\)

```csharp
public MenuInputText AddInputText(MenuName name, string? defaultText = null, bool dontSave = false)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`defaultText` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuInputText](Divine.Menu.Items.MenuInputText.md)

### <a id="Divine_Menu_Items_Menu_AddItemToggler_Divine_Menu_Components_MenuName_Divine_Menu_Components_MenuTogglerItems_System_Boolean_"></a> AddItemToggler\(MenuName, MenuTogglerItems, bool\)

```csharp
public MenuItemToggler AddItemToggler(MenuName name, MenuTogglerItems values = default, bool dontSave = false)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`values` [MenuTogglerItems](Divine.Menu.Components.MenuTogglerItems.md)

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuItemToggler](Divine.Menu.Items.MenuItemToggler.md)

### <a id="Divine_Menu_Items_Menu_AddItemToggler_Divine_Menu_Components_MenuName_Divine_Menu_Components_MenuTogglerOptions_Divine_Menu_Components_MenuTogglerItems_System_Boolean_"></a> AddItemToggler\(MenuName, MenuTogglerOptions, MenuTogglerItems, bool\)

```csharp
public MenuItemToggler AddItemToggler(MenuName name, MenuTogglerOptions options, MenuTogglerItems values = default, bool dontSave = false)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`options` [MenuTogglerOptions](Divine.Menu.Components.MenuTogglerOptions.md)

`values` [MenuTogglerItems](Divine.Menu.Components.MenuTogglerItems.md)

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuItemToggler](Divine.Menu.Items.MenuItemToggler.md)

### <a id="Divine_Menu_Items_Menu_AddLinker_Divine_Menu_Items_MenuText_"></a> AddLinker\(MenuText\)

```csharp
public MenuLinker AddLinker(MenuText text)
```

#### Parameters

`text` [MenuText](Divine.Menu.Items.MenuText.md)

#### Returns

 [MenuLinker](Divine.Menu.Items.MenuLinker.md)

### <a id="Divine_Menu_Items_Menu_AddLinker_Divine_Menu_Components_MenuName_Divine_Menu_Items_MenuText_"></a> AddLinker\(MenuName, MenuText\)

```csharp
public MenuLinker AddLinker(MenuName name, MenuText text)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`text` [MenuText](Divine.Menu.Items.MenuText.md)

#### Returns

 [MenuLinker](Divine.Menu.Items.MenuLinker.md)

### <a id="Divine_Menu_Items_Menu_AddMenu_Divine_Menu_Components_MenuName_System_Boolean_System_Boolean_System_Boolean_"></a> AddMenu\(MenuName, bool, bool, bool\)

```csharp
public Menu AddMenu(MenuName name, bool withSwitcher = false, bool defaultValue = true, bool dontSave = false)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`withSwitcher` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`defaultValue` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [Menu](Divine.Menu.Items.Menu.md)

### <a id="Divine_Menu_Items_Menu_AddSearcher_Divine_Menu_Components_MenuName_"></a> AddSearcher\(MenuName\)

```csharp
public MenuSearcher AddSearcher(MenuName name)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

#### Returns

 [MenuSearcher](Divine.Menu.Items.MenuSearcher.md)

### <a id="Divine_Menu_Items_Menu_AddSelector_Divine_Menu_Components_MenuName_Divine_Menu_Components_MenuSelectorValues_System_Boolean_"></a> AddSelector\(MenuName, MenuSelectorValues, bool\)

```csharp
public MenuSelector AddSelector(MenuName name, MenuSelectorValues values = default, bool dontSave = false)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`values` [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues.md)

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuSelector](Divine.Menu.Items.MenuSelector.md)

### <a id="Divine_Menu_Items_Menu_AddSelector_Divine_Menu_Components_MenuName_System_Int32_Divine_Menu_Components_MenuSelectorValues_System_Boolean_"></a> AddSelector\(MenuName, int, MenuSelectorValues, bool\)

```csharp
public MenuSelector AddSelector(MenuName name, int defaultIndex, MenuSelectorValues values = default, bool dontSave = false)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`defaultIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`values` [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues.md)

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuSelector](Divine.Menu.Items.MenuSelector.md)

### <a id="Divine_Menu_Items_Menu_AddSelector__1_Divine_Menu_Components_MenuName_Divine_Menu_Components_MenuSelectorValues___0__System_Boolean_"></a> AddSelector<T\>\(MenuName, MenuSelectorValues<T\>, bool\)

```csharp
public MenuSelector<T> AddSelector<T>(MenuName name, MenuSelectorValues<T> values = default, bool dontSave = false) where T : notnull
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`values` [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues\-1.md)<T\>

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuSelector](Divine.Menu.Items.MenuSelector\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="Divine_Menu_Items_Menu_AddSelector__1_Divine_Menu_Components_MenuName_System_Int32_Divine_Menu_Components_MenuSelectorValues___0__System_Boolean_"></a> AddSelector<T\>\(MenuName, int, MenuSelectorValues<T\>, bool\)

```csharp
public MenuSelector<T> AddSelector<T>(MenuName name, int defaultIndex, MenuSelectorValues<T> values = default, bool dontSave = false) where T : notnull
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`defaultIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`values` [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues\-1.md)<T\>

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuSelector](Divine.Menu.Items.MenuSelector\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="Divine_Menu_Items_Menu_AddSlider_Divine_Menu_Components_MenuName_System_Single_System_Single_System_Single_System_Boolean_System_Single_System_Boolean_"></a> AddSlider\(MenuName, float, float, float, bool, float, bool\)

```csharp
public MenuSlider AddSlider(MenuName name, float value, float minValue, float maxValue, bool isFloatingPoint = false, float wheelStep = 1, bool dontSave = false)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

`minValue` [float](https://learn.microsoft.com/dotnet/api/system.single)

`maxValue` [float](https://learn.microsoft.com/dotnet/api/system.single)

`isFloatingPoint` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`wheelStep` [float](https://learn.microsoft.com/dotnet/api/system.single)

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuSlider](Divine.Menu.Items.MenuSlider.md)

### <a id="Divine_Menu_Items_Menu_AddSwitcher_Divine_Menu_Components_MenuName_System_Boolean_System_Boolean_"></a> AddSwitcher\(MenuName, bool, bool\)

```csharp
public MenuSwitcher AddSwitcher(MenuName name, bool defaultValue = true, bool dontSave = false)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`defaultValue` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuSwitcher](Divine.Menu.Items.MenuSwitcher.md)

### <a id="Divine_Menu_Items_Menu_AddText_Divine_Menu_Components_MenuName_"></a> AddText\(MenuName\)

```csharp
public MenuText AddText(MenuName name)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

#### Returns

 [MenuText](Divine.Menu.Items.MenuText.md)

### <a id="Divine_Menu_Items_Menu_AddToggleKey_Divine_Menu_Components_MenuName_Divine_Input_Key_System_Boolean_System_Boolean_"></a> AddToggleKey\(MenuName, Key, bool, bool\)

```csharp
public MenuToggleKey AddToggleKey(MenuName name, Key defaultKey = Key.None, bool defaultValue = false, bool dontSave = false)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`defaultKey` [Key](Divine.Input.Key.md)

`defaultValue` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuToggleKey](Divine.Menu.Items.MenuToggleKey.md)

### <a id="Divine_Menu_Items_Menu_AddToggler_Divine_Menu_Components_MenuName_Divine_Menu_Components_MenuTogglerValues_System_Boolean_"></a> AddToggler\(MenuName, MenuTogglerValues, bool\)

```csharp
public MenuToggler AddToggler(MenuName name, MenuTogglerValues values = default, bool dontSave = false)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`values` [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues.md)

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuToggler](Divine.Menu.Items.MenuToggler.md)

### <a id="Divine_Menu_Items_Menu_AddToggler_Divine_Menu_Components_MenuName_Divine_Menu_Components_MenuTogglerOptions_Divine_Menu_Components_MenuTogglerValues_System_Boolean_"></a> AddToggler\(MenuName, MenuTogglerOptions, MenuTogglerValues, bool\)

```csharp
public MenuToggler AddToggler(MenuName name, MenuTogglerOptions options, MenuTogglerValues values = default, bool dontSave = false)
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`options` [MenuTogglerOptions](Divine.Menu.Components.MenuTogglerOptions.md)

`values` [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues.md)

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuToggler](Divine.Menu.Items.MenuToggler.md)

### <a id="Divine_Menu_Items_Menu_AddToggler__1_Divine_Menu_Components_MenuName_Divine_Menu_Components_MenuTogglerValues___0__System_Boolean_"></a> AddToggler<T\>\(MenuName, MenuTogglerValues<T\>, bool\)

```csharp
public MenuToggler<T> AddToggler<T>(MenuName name, MenuTogglerValues<T> values = default, bool dontSave = false) where T : notnull
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`values` [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues\-1.md)<T\>

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuToggler](Divine.Menu.Items.MenuToggler\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="Divine_Menu_Items_Menu_AddToggler__1_Divine_Menu_Components_MenuName_Divine_Menu_Components_MenuTogglerOptions_Divine_Menu_Components_MenuTogglerValues___0__System_Boolean_"></a> AddToggler<T\>\(MenuName, MenuTogglerOptions, MenuTogglerValues<T\>, bool\)

```csharp
public MenuToggler<T> AddToggler<T>(MenuName name, MenuTogglerOptions options, MenuTogglerValues<T> values = default, bool dontSave = false) where T : notnull
```

#### Parameters

`name` [MenuName](Divine.Menu.Components.MenuName.md)

`options` [MenuTogglerOptions](Divine.Menu.Components.MenuTogglerOptions.md)

`values` [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues\-1.md)<T\>

`dontSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [MenuToggler](Divine.Menu.Items.MenuToggler\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="Divine_Menu_Items_Menu_AddValueChangedHandler_System_Boolean_System_EventHandler_Divine_Menu_Items_Menu_Divine_Menu_EventArgs_SwitcherChangedEventArgs__"></a> AddValueChangedHandler\(bool, EventHandler<Menu, SwitcherChangedEventArgs\>\)

```csharp
public virtual void AddValueChangedHandler(bool addEventIfValueTrue, EventHandler<Menu, SwitcherChangedEventArgs> handler)
```

#### Parameters

`addEventIfValueTrue` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`handler` [EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler\-2)<[Menu](Divine.Menu.Items.Menu.md), [SwitcherChangedEventArgs](Divine.Menu.EventArgs.SwitcherChangedEventArgs.md)\>

### <a id="Divine_Menu_Items_Menu_Clear"></a> Clear\(\)

```csharp
public void Clear()
```

### <a id="Divine_Menu_Items_Menu_GetItem__1_System_String_"></a> GetItem<T\>\(string\)

```csharp
public T? GetItem<T>(string name) where T : MenuItem
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 T?

#### Type Parameters

`T` 

### <a id="Divine_Menu_Items_Menu_Remove_Divine_Menu_Items_MenuItem_"></a> Remove\(MenuItem\)

```csharp
public bool Remove(MenuItem item)
```

#### Parameters

`item` [MenuItem](Divine.Menu.Items.MenuItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_Menu_Remove_System_String_"></a> Remove\(string\)

```csharp
public bool Remove(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_Menu_RemoveValueChangedHandler_System_Boolean_System_EventHandler_Divine_Menu_Items_Menu_Divine_Menu_EventArgs_SwitcherChangedEventArgs__"></a> RemoveValueChangedHandler\(bool, EventHandler<Menu, SwitcherChangedEventArgs\>\)

```csharp
public virtual void RemoveValueChangedHandler(bool removeEventIfValueTrue, EventHandler<Menu, SwitcherChangedEventArgs> handler)
```

#### Parameters

`removeEventIfValueTrue` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`handler` [EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler\-2)<[Menu](Divine.Menu.Items.Menu.md), [SwitcherChangedEventArgs](Divine.Menu.EventArgs.SwitcherChangedEventArgs.md)\>

### <a id="Divine_Menu_Items_Menu_TryGetItem__1_System_String___0__"></a> TryGetItem<T\>\(string, out T?\)

```csharp
public bool TryGetItem<T>(string name, out T? item) where T : MenuItem
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`item` T?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Type Parameters

`T` 

### <a id="Divine_Menu_Items_Menu_ValueChanged"></a> ValueChanged

```csharp
public virtual event EventHandler<Menu, SwitcherChangedEventArgs> ValueChanged
```

#### Event Type

 [EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler\-2)<[Menu](Divine.Menu.Items.Menu.md), [SwitcherChangedEventArgs](Divine.Menu.EventArgs.SwitcherChangedEventArgs.md)\>

## Operators

### <a id="Divine_Menu_Items_Menu_op_Implicit_Divine_Menu_Objects_MenuObject__Divine_Menu_Items_Menu"></a> implicit operator Menu\(MenuObject\)

```csharp
public static implicit operator Menu(MenuObject menuObject)
```

#### Parameters

`menuObject` [MenuObject](Divine.Menu.Objects.MenuObject.md)

#### Returns

 [Menu](Divine.Menu.Items.Menu.md)

### <a id="Divine_Menu_Items_Menu_op_Implicit_Divine_Menu_Items_Menu__System_Boolean"></a> implicit operator bool\(Menu\)

```csharp
public static implicit operator bool(Menu menu)
```

#### Parameters

`menu` [Menu](Divine.Menu.Items.Menu.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

