# <a id="Divine_Menu_Items_MenuContext"></a> Class MenuContext

Namespace: [Divine.Menu.Items](Divine.Menu.Items.md)  
Assembly: Divine.dll  

```csharp
public abstract class MenuContext : Menu, IDisposable, IMenuContextExtensions, IMenuExtensions, IMenuExpanderExtensions, IMenuTextExtensions, IMenuItemExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuItem](Divine.Menu.Items.MenuItem.md) ← 
[MenuText](Divine.Menu.Items.MenuText.md) ← 
[MenuExpander](Divine.Menu.Items.MenuExpander.md) ← 
[Menu](Divine.Menu.Items.Menu.md) ← 
[MenuContext](Divine.Menu.Items.MenuContext.md)

#### Derived

[MainMenu](Divine.Menu.Items.MainMenu.md), 
[MenuTooltip](Divine.Menu.Items.MenuTooltip.md), 
[MiniMenu](Divine.Menu.Items.MiniMenu.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IMenuContextExtensions](Divine.Menu.Items.IMenuContextExtensions.md), 
[IMenuExtensions](Divine.Menu.Items.IMenuExtensions.md), 
[IMenuExpanderExtensions](Divine.Menu.Items.IMenuExpanderExtensions.md), 
[IMenuTextExtensions](Divine.Menu.Items.IMenuTextExtensions.md), 
[IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

#### Inherited Members

[Menu.this\[string\]](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_Item\_System\_String\_), 
[Menu.DefaultValue](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_DefaultValue), 
[Menu.Value](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_Value), 
[Menu.View](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_View), 
[Menu.Items](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_Items), 
[Menu.ValueChanged](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_ValueChanged), 
[Menu.AddValueChangedHandler\(bool, EventHandler<Menu, SwitcherChangedEventArgs\>\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddValueChangedHandler\_System\_Boolean\_System\_EventHandler\_Divine\_Menu\_Items\_Menu\_Divine\_Menu\_EventArgs\_SwitcherChangedEventArgs\_\_), 
[Menu.RemoveValueChangedHandler\(bool, EventHandler<Menu, SwitcherChangedEventArgs\>\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_RemoveValueChangedHandler\_System\_Boolean\_System\_EventHandler\_Divine\_Menu\_Items\_Menu\_Divine\_Menu\_EventArgs\_SwitcherChangedEventArgs\_\_), 
[Menu.AddMenu\(MenuName, bool, bool, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddMenu\_Divine\_Menu\_Components\_MenuName\_System\_Boolean\_System\_Boolean\_System\_Boolean\_), 
[Menu.AddSearcher\(MenuName\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddSearcher\_Divine\_Menu\_Components\_MenuName\_), 
[Menu.AddInputText\(MenuName, string?, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddInputText\_Divine\_Menu\_Components\_MenuName\_System\_String\_System\_Boolean\_), 
[Menu.AddHoldKey\(MenuName, Key, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddHoldKey\_Divine\_Menu\_Components\_MenuName\_Divine\_Input\_Key\_System\_Boolean\_), 
[Menu.AddToggleKey\(MenuName, Key, bool, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddToggleKey\_Divine\_Menu\_Components\_MenuName\_Divine\_Input\_Key\_System\_Boolean\_System\_Boolean\_), 
[Menu.AddInputKey\(MenuName, Key, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddInputKey\_Divine\_Menu\_Components\_MenuName\_Divine\_Input\_Key\_System\_Boolean\_), 
[Menu.AddButton\(MenuName, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddButton\_Divine\_Menu\_Components\_MenuName\_System\_Boolean\_), 
[Menu.AddSwitcher\(MenuName, bool, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddSwitcher\_Divine\_Menu\_Components\_MenuName\_System\_Boolean\_System\_Boolean\_), 
[Menu.AddSlider\(MenuName, float, float, float, bool, float, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddSlider\_Divine\_Menu\_Components\_MenuName\_System\_Single\_System\_Single\_System\_Single\_System\_Boolean\_System\_Single\_System\_Boolean\_), 
[Menu.AddSelector\(MenuName, MenuSelectorValues, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddSelector\_Divine\_Menu\_Components\_MenuName\_Divine\_Menu\_Components\_MenuSelectorValues\_System\_Boolean\_), 
[Menu.AddSelector\(MenuName, int, MenuSelectorValues, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddSelector\_Divine\_Menu\_Components\_MenuName\_System\_Int32\_Divine\_Menu\_Components\_MenuSelectorValues\_System\_Boolean\_), 
[Menu.AddSelector<T\>\(MenuName, MenuSelectorValues<T\>, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddSelector\_\_1\_Divine\_Menu\_Components\_MenuName\_Divine\_Menu\_Components\_MenuSelectorValues\_\_\_0\_\_System\_Boolean\_), 
[Menu.AddSelector<T\>\(MenuName, int, MenuSelectorValues<T\>, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddSelector\_\_1\_Divine\_Menu\_Components\_MenuName\_System\_Int32\_Divine\_Menu\_Components\_MenuSelectorValues\_\_\_0\_\_System\_Boolean\_), 
[Menu.AddHeroToggler\(MenuName, MenuTogglerHeroes, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddHeroToggler\_Divine\_Menu\_Components\_MenuName\_Divine\_Menu\_Components\_MenuTogglerHeroes\_System\_Boolean\_), 
[Menu.AddHeroToggler\(MenuName, MenuTogglerOptions, MenuTogglerHeroes, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddHeroToggler\_Divine\_Menu\_Components\_MenuName\_Divine\_Menu\_Components\_MenuTogglerOptions\_Divine\_Menu\_Components\_MenuTogglerHeroes\_System\_Boolean\_), 
[Menu.AddAbilityToggler\(MenuName, MenuTogglerAbilities, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddAbilityToggler\_Divine\_Menu\_Components\_MenuName\_Divine\_Menu\_Components\_MenuTogglerAbilities\_System\_Boolean\_), 
[Menu.AddAbilityToggler\(MenuName, MenuTogglerOptions, MenuTogglerAbilities, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddAbilityToggler\_Divine\_Menu\_Components\_MenuName\_Divine\_Menu\_Components\_MenuTogglerOptions\_Divine\_Menu\_Components\_MenuTogglerAbilities\_System\_Boolean\_), 
[Menu.AddItemToggler\(MenuName, MenuTogglerItems, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddItemToggler\_Divine\_Menu\_Components\_MenuName\_Divine\_Menu\_Components\_MenuTogglerItems\_System\_Boolean\_), 
[Menu.AddItemToggler\(MenuName, MenuTogglerOptions, MenuTogglerItems, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddItemToggler\_Divine\_Menu\_Components\_MenuName\_Divine\_Menu\_Components\_MenuTogglerOptions\_Divine\_Menu\_Components\_MenuTogglerItems\_System\_Boolean\_), 
[Menu.AddToggler\(MenuName, MenuTogglerValues, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddToggler\_Divine\_Menu\_Components\_MenuName\_Divine\_Menu\_Components\_MenuTogglerValues\_System\_Boolean\_), 
[Menu.AddToggler\(MenuName, MenuTogglerOptions, MenuTogglerValues, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddToggler\_Divine\_Menu\_Components\_MenuName\_Divine\_Menu\_Components\_MenuTogglerOptions\_Divine\_Menu\_Components\_MenuTogglerValues\_System\_Boolean\_), 
[Menu.AddToggler<T\>\(MenuName, MenuTogglerValues<T\>, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddToggler\_\_1\_Divine\_Menu\_Components\_MenuName\_Divine\_Menu\_Components\_MenuTogglerValues\_\_\_0\_\_System\_Boolean\_), 
[Menu.AddToggler<T\>\(MenuName, MenuTogglerOptions, MenuTogglerValues<T\>, bool\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddToggler\_\_1\_Divine\_Menu\_Components\_MenuName\_Divine\_Menu\_Components\_MenuTogglerOptions\_Divine\_Menu\_Components\_MenuTogglerValues\_\_\_0\_\_System\_Boolean\_), 
[Menu.AddLinker\(MenuText\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddLinker\_Divine\_Menu\_Items\_MenuText\_), 
[Menu.AddLinker\(MenuName, MenuText\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddLinker\_Divine\_Menu\_Components\_MenuName\_Divine\_Menu\_Items\_MenuText\_), 
[Menu.AddText\(MenuName\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_AddText\_Divine\_Menu\_Components\_MenuName\_), 
[Menu.Remove\(MenuItem\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_Remove\_Divine\_Menu\_Items\_MenuItem\_), 
[Menu.Remove\(string\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_Remove\_System\_String\_), 
[Menu.Clear\(\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_Clear), 
[Menu.GetItem<T\>\(string\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_GetItem\_\_1\_System\_String\_), 
[Menu.TryGetItem<T\>\(string, out T?\)](Divine.Menu.Items.Menu.md\#Divine\_Menu\_Items\_Menu\_TryGetItem\_\_1\_System\_String\_\_\_0\_\_), 
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

[MenuExtensions.Collapse<MenuContext\>\(MenuContext\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Collapse\_\_1\_\_\_0\_), 
[MenuExtensions.Disable<MenuContext\>\(MenuContext\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Disable\_\_1\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[MenuExtensions.Enable<MenuContext\>\(MenuContext\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Enable\_\_1\_\_\_0\_), 
[MenuExtensions.Expand<MenuContext\>\(MenuContext\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Expand\_\_1\_\_\_0\_), 
[MenuExtensions.Hide<MenuContext\>\(MenuContext\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Hide\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<MenuContext\>\(MenuContext, params MenuContext\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[MenuExtensions.Load<MenuContext\>\(MenuContext\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Load\_\_1\_\_\_0\_), 
[MenuExtensions.Move<MenuContext\>\(MenuContext, int\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Move\_\_1\_\_\_0\_System\_Int32\_), 
[MenuExtensions.Refresh<MenuContext\>\(MenuContext, bool, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Refresh\_\_1\_\_\_0\_System\_Boolean\_System\_Boolean\_), 
[MenuExtensions.Reset<MenuContext\>\(MenuContext\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Reset\_\_1\_\_\_0\_), 
[MenuExtensions.ResetSwitcher<MenuContext\>\(MenuContext\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_ResetSwitcher\_\_1\_\_\_0\_), 
[MenuExtensions.Save<MenuContext\>\(MenuContext, MenuSaveMode\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Save\_\_1\_\_\_0\_Divine\_Menu\_Components\_MenuSaveMode\_), 
[MenuExtensions.SetDisplayTextFontColor<MenuContext\>\(MenuContext, Color?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetDisplayTextFontColor\_\_1\_\_\_0\_System\_Nullable\_Vortice\_Mathematics\_Color\_\_), 
[MenuExtensions.SetImage<MenuContext\>\(MenuContext, HeroId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Units\_Heroes\_Components\_HeroId\_System\_Boolean\_), 
[MenuExtensions.SetImage<MenuContext\>\(MenuContext, ItemId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Items\_Components\_ItemId\_System\_Boolean\_), 
[MenuExtensions.SetImage<MenuContext\>\(MenuContext, AbilityId\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_), 
[MenuExtensions.SetImage<MenuContext\>\(MenuContext, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<MenuContext\>\(MenuContext, string, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<MenuContext\>\(MenuContext, MenuImageKey?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_Nullable\_Divine\_Menu\_Components\_MenuImageKey\_\_), 
[MenuExtensions.SetImageFromResources<MenuContext\>\(MenuContext, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.SetImageFromResources<MenuContext\>\(MenuContext, string, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_System\_String\_), 
[MenuExtensions.SetPosition<MenuContext\>\(MenuContext, Vector2\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetPosition\_\_1\_\_\_0\_System\_Numerics\_Vector2\_), 
[MenuExtensions.SetSearchMark<MenuContext\>\(MenuContext, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetSearchMark\_\_1\_\_\_0\_System\_Boolean\_), 
[MenuExtensions.SetTooltip<MenuContext\>\(MenuContext, string?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetTooltip\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.Show<MenuContext\>\(MenuContext\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Show\_\_1\_\_\_0\_)

## Properties

### <a id="Divine_Menu_Items_MenuContext_ContextStyle"></a> ContextStyle

```csharp
public IContextStyle ContextStyle { get; }
```

#### Property Value

 [IContextStyle](Divine.Menu.Styles.IContextStyle.md)

### <a id="Divine_Menu_Items_MenuContext_Flags"></a> Flags

```csharp
public override MenuFlags Flags { get; }
```

#### Property Value

 [MenuFlags](Divine.Menu.Components.MenuFlags.md)

### <a id="Divine_Menu_Items_MenuContext_FullName"></a> FullName

```csharp
public override string FullName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Menu_Items_MenuContext_IsExpanded"></a> IsExpanded

```csharp
public override bool IsExpanded { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuContext_Position"></a> Position

```csharp
public virtual Vector2 Position { get; set; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Menu_Items_MenuContext_Priority"></a> Priority

```csharp
public override int Priority { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Menu_Items_MenuContext_View"></a> View

```csharp
public IContextView View { get; }
```

#### Property Value

 [IContextView](Divine.Menu.Views.IContextView.md)

## Methods

### <a id="Divine_Menu_Items_MenuContext_SetStyle_Divine_Menu_Styles_IContextStyle_"></a> SetStyle\(IContextStyle\)

```csharp
protected virtual void SetStyle(IContextStyle contextStyle)
```

#### Parameters

`contextStyle` [IContextStyle](Divine.Menu.Styles.IContextStyle.md)

