# <a id="Divine_Menu_Items_MenuSelector"></a> Class MenuSelector

Namespace: [Divine.Menu.Items](Divine.Menu.Items.md)  
Assembly: Divine.dll  

```csharp
public sealed class MenuSelector : MenuSelectorBase<string>, IDisposable, IMenuTextExtensions, IMenuItemExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuItem](Divine.Menu.Items.MenuItem.md) ← 
[MenuText](Divine.Menu.Items.MenuText.md) ← 
[MenuSelectorBase<string\>](Divine.Menu.Items.MenuSelectorBase\-1.md) ← 
[MenuSelector](Divine.Menu.Items.MenuSelector.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IMenuTextExtensions](Divine.Menu.Items.IMenuTextExtensions.md), 
[IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

#### Inherited Members

[MenuSelectorBase<string\>.View](Divine.Menu.Items.MenuSelectorBase\-1.md\#Divine\_Menu\_Items\_MenuSelectorBase\_1\_View), 
[MenuSelectorBase<string\>.DefaultIndex](Divine.Menu.Items.MenuSelectorBase\-1.md\#Divine\_Menu\_Items\_MenuSelectorBase\_1\_DefaultIndex), 
[MenuSelectorBase<string\>.Values](Divine.Menu.Items.MenuSelectorBase\-1.md\#Divine\_Menu\_Items\_MenuSelectorBase\_1\_Values), 
[MenuSelectorBase<string\>.Index](Divine.Menu.Items.MenuSelectorBase\-1.md\#Divine\_Menu\_Items\_MenuSelectorBase\_1\_Index), 
[MenuSelectorBase<string\>.Key](Divine.Menu.Items.MenuSelectorBase\-1.md\#Divine\_Menu\_Items\_MenuSelectorBase\_1\_Key), 
[MenuSelectorBase<string\>.Value](Divine.Menu.Items.MenuSelectorBase\-1.md\#Divine\_Menu\_Items\_MenuSelectorBase\_1\_Value), 
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
[MenuItem.Dispose\(bool\)](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_Dispose\_System\_Boolean\_), 
[MenuItem.ToString\(\)](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_ToString), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[MenuExtensions.Disable<MenuSelector\>\(MenuSelector\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Disable\_\_1\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[MenuExtensions.Enable<MenuSelector\>\(MenuSelector\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Enable\_\_1\_\_\_0\_), 
[MenuExtensions.Hide<MenuSelector\>\(MenuSelector\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Hide\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<MenuSelector\>\(MenuSelector, params MenuSelector\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[MenuExtensions.Load<MenuSelector\>\(MenuSelector\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Load\_\_1\_\_\_0\_), 
[MenuExtensions.Move<MenuSelector\>\(MenuSelector, int\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Move\_\_1\_\_\_0\_System\_Int32\_), 
[MenuExtensions.Refresh<MenuSelector\>\(MenuSelector, bool, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Refresh\_\_1\_\_\_0\_System\_Boolean\_System\_Boolean\_), 
[MenuExtensions.Reset<MenuSelector\>\(MenuSelector\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Reset\_\_1\_\_\_0\_), 
[MenuExtensions.Save<MenuSelector\>\(MenuSelector, MenuSaveMode\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Save\_\_1\_\_\_0\_Divine\_Menu\_Components\_MenuSaveMode\_), 
[MenuExtensions.SetDisplayTextFontColor<MenuSelector\>\(MenuSelector, Color?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetDisplayTextFontColor\_\_1\_\_\_0\_System\_Nullable\_Vortice\_Mathematics\_Color\_\_), 
[MenuExtensions.SetImage<MenuSelector\>\(MenuSelector, HeroId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Units\_Heroes\_Components\_HeroId\_System\_Boolean\_), 
[MenuExtensions.SetImage<MenuSelector\>\(MenuSelector, ItemId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Items\_Components\_ItemId\_System\_Boolean\_), 
[MenuExtensions.SetImage<MenuSelector\>\(MenuSelector, AbilityId\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_), 
[MenuExtensions.SetImage<MenuSelector\>\(MenuSelector, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<MenuSelector\>\(MenuSelector, string, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<MenuSelector\>\(MenuSelector, MenuImageKey?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_Nullable\_Divine\_Menu\_Components\_MenuImageKey\_\_), 
[MenuExtensions.SetImageFromResources<MenuSelector\>\(MenuSelector, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.SetImageFromResources<MenuSelector\>\(MenuSelector, string, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_System\_String\_), 
[MenuExtensions.SetSearchMark<MenuSelector\>\(MenuSelector, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetSearchMark\_\_1\_\_\_0\_System\_Boolean\_), 
[MenuExtensions.SetTooltip<MenuSelector\>\(MenuSelector, string?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetTooltip\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.Show<MenuSelector\>\(MenuSelector\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Show\_\_1\_\_\_0\_)

### <a id="Divine_Menu_Items_MenuSelector_ValueChanged"></a> ValueChanged

```csharp
public event EventHandler<MenuSelector, SelectorChangedEventArgs> ValueChanged
```

#### Event Type

 [EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler\-2)<[MenuSelector](Divine.Menu.Items.MenuSelector.md), [SelectorChangedEventArgs](Divine.Menu.EventArgs.SelectorChangedEventArgs.md)\>

## Operators

### <a id="Divine_Menu_Items_MenuSelector_op_Implicit_Divine_Menu_Objects_MenuObject__Divine_Menu_Items_MenuSelector"></a> implicit operator MenuSelector\(MenuObject\)

```csharp
public static implicit operator MenuSelector(MenuObject menuObject)
```

#### Parameters

`menuObject` [MenuObject](Divine.Menu.Objects.MenuObject.md)

#### Returns

 [MenuSelector](Divine.Menu.Items.MenuSelector.md)

