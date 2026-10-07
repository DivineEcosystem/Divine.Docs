# <a id="Divine_Menu_Items_MenuToggler_1"></a> Class MenuToggler<T\>

Namespace: [Divine.Menu.Items](Divine.Menu.Items.md)  
Assembly: Divine.dll  

```csharp
public sealed class MenuToggler<T> : MenuTogglerBase<T>, IDisposable, IMenuExpanderExtensions, IMenuTogglerExtensions, IMenuTextExtensions, IMenuItemExtensions where T : notnull
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuItem](Divine.Menu.Items.MenuItem.md) ← 
[MenuText](Divine.Menu.Items.MenuText.md) ← 
[MenuExpander](Divine.Menu.Items.MenuExpander.md) ← 
[MenuTogglerBase<T\>](Divine.Menu.Items.MenuTogglerBase\-1.md) ← 
[MenuToggler<T\>](Divine.Menu.Items.MenuToggler\-1.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IMenuExpanderExtensions](Divine.Menu.Items.IMenuExpanderExtensions.md), 
[IMenuTogglerExtensions](Divine.Menu.Items.IMenuTogglerExtensions.md), 
[IMenuTextExtensions](Divine.Menu.Items.IMenuTextExtensions.md), 
[IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

#### Inherited Members

[MenuTogglerBase<T\>.this\[T\]](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_Item\_\_0\_), 
[MenuTogglerBase<T\>.View](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_View), 
[MenuTogglerBase<T\>.Options](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_Options), 
[MenuTogglerBase<T\>.CanToggle](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_CanToggle), 
[MenuTogglerBase<T\>.CanChangePriority](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_CanChangePriority), 
[MenuTogglerBase<T\>.IsExpandable](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_IsExpandable), 
[MenuTogglerBase<T\>.DefaultValues](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_DefaultValues), 
[MenuTogglerBase<T\>.ImageKeys](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_ImageKeys), 
[MenuTogglerBase<T\>.Values](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_Values), 
[MenuTogglerBase<T\>.GetValue\(T\)](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_GetValue\_\_0\_), 
[MenuTogglerBase<T\>.TryGetValue\(T, out bool\)](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_TryGetValue\_\_0\_System\_Boolean\_\_), 
[MenuTogglerBase<T\>.SetValue\(T, bool\)](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_SetValue\_\_0\_System\_Boolean\_), 
[MenuTogglerBase<T\>.AddValue\(MenuTogglerValue<T\>\)](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_AddValue\_Divine\_Menu\_Components\_MenuTogglerValue\_\_0\_\_), 
[MenuTogglerBase<T\>.RemoveValue\(T\)](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_RemoveValue\_\_0\_), 
[MenuTogglerBase<T\>.GetPriority\(T\)](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_GetPriority\_\_0\_), 
[MenuTogglerBase<T\>.SetPriority\(T, int\)](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_SetPriority\_\_0\_System\_Int32\_), 
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
[MenuItem.Dispose\(bool\)](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_Dispose\_System\_Boolean\_), 
[MenuItem.ToString\(\)](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_ToString), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[MenuExtensions.Collapse<MenuToggler<T\>\>\(MenuToggler<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Collapse\_\_1\_\_\_0\_), 
[MenuExtensions.Disable<MenuToggler<T\>\>\(MenuToggler<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Disable\_\_1\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[MenuExtensions.Enable<MenuToggler<T\>\>\(MenuToggler<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Enable\_\_1\_\_\_0\_), 
[MenuExtensions.Expand<MenuToggler<T\>\>\(MenuToggler<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Expand\_\_1\_\_\_0\_), 
[MenuExtensions.Hide<MenuToggler<T\>\>\(MenuToggler<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Hide\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<MenuToggler<T\>\>\(MenuToggler<T\>, params MenuToggler<T\>\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[MenuExtensions.Load<MenuToggler<T\>\>\(MenuToggler<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Load\_\_1\_\_\_0\_), 
[MenuExtensions.Move<MenuToggler<T\>\>\(MenuToggler<T\>, int\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Move\_\_1\_\_\_0\_System\_Int32\_), 
[MenuExtensions.Refresh<MenuToggler<T\>\>\(MenuToggler<T\>, bool, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Refresh\_\_1\_\_\_0\_System\_Boolean\_System\_Boolean\_), 
[MenuExtensions.Reset<MenuToggler<T\>\>\(MenuToggler<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Reset\_\_1\_\_\_0\_), 
[MenuExtensions.ResetPriorities<MenuToggler<T\>\>\(MenuToggler<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_ResetPriorities\_\_1\_\_\_0\_), 
[MenuExtensions.ResetValues<MenuToggler<T\>\>\(MenuToggler<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_ResetValues\_\_1\_\_\_0\_), 
[MenuExtensions.Save<MenuToggler<T\>\>\(MenuToggler<T\>, MenuSaveMode\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Save\_\_1\_\_\_0\_Divine\_Menu\_Components\_MenuSaveMode\_), 
[MenuExtensions.SetDisplayTextFontColor<MenuToggler<T\>\>\(MenuToggler<T\>, Color?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetDisplayTextFontColor\_\_1\_\_\_0\_System\_Nullable\_Vortice\_Mathematics\_Color\_\_), 
[MenuExtensions.SetImage<MenuToggler<T\>\>\(MenuToggler<T\>, HeroId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Units\_Heroes\_Components\_HeroId\_System\_Boolean\_), 
[MenuExtensions.SetImage<MenuToggler<T\>\>\(MenuToggler<T\>, ItemId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Items\_Components\_ItemId\_System\_Boolean\_), 
[MenuExtensions.SetImage<MenuToggler<T\>\>\(MenuToggler<T\>, AbilityId\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_), 
[MenuExtensions.SetImage<MenuToggler<T\>\>\(MenuToggler<T\>, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<MenuToggler<T\>\>\(MenuToggler<T\>, string, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<MenuToggler<T\>\>\(MenuToggler<T\>, MenuImageKey?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_Nullable\_Divine\_Menu\_Components\_MenuImageKey\_\_), 
[MenuExtensions.SetImageFromResources<MenuToggler<T\>\>\(MenuToggler<T\>, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.SetImageFromResources<MenuToggler<T\>\>\(MenuToggler<T\>, string, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_System\_String\_), 
[MenuExtensions.SetSearchMark<MenuToggler<T\>\>\(MenuToggler<T\>, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetSearchMark\_\_1\_\_\_0\_System\_Boolean\_), 
[MenuExtensions.SetTooltip<MenuToggler<T\>\>\(MenuToggler<T\>, string?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetTooltip\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.Show<MenuToggler<T\>\>\(MenuToggler<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Show\_\_1\_\_\_0\_)

### <a id="Divine_Menu_Items_MenuToggler_1_FullValueChanged"></a> FullValueChanged

```csharp
public event EventHandler<MenuToggler<T>, TogglerChangedEventArgs<T>> FullValueChanged
```

#### Event Type

 [EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler\-2)<[MenuToggler](Divine.Menu.Items.MenuToggler\-1.md)<T\>, [TogglerChangedEventArgs](Divine.Menu.EventArgs.TogglerChangedEventArgs\-1.md)<T\>\>

### <a id="Divine_Menu_Items_MenuToggler_1_PriorityChanged"></a> PriorityChanged

```csharp
public event EventHandler<MenuToggler<T>, TogglerPriorityChangedEventArgs<T>> PriorityChanged
```

#### Event Type

 [EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler\-2)<[MenuToggler](Divine.Menu.Items.MenuToggler\-1.md)<T\>, [TogglerPriorityChangedEventArgs](Divine.Menu.EventArgs.TogglerPriorityChangedEventArgs\-1.md)<T\>\>

### <a id="Divine_Menu_Items_MenuToggler_1_ValueChanged"></a> ValueChanged

```csharp
public event EventHandler<MenuToggler<T>, TogglerChangedEventArgs<T>> ValueChanged
```

#### Event Type

 [EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler\-2)<[MenuToggler](Divine.Menu.Items.MenuToggler\-1.md)<T\>, [TogglerChangedEventArgs](Divine.Menu.EventArgs.TogglerChangedEventArgs\-1.md)<T\>\>

## Operators

### <a id="Divine_Menu_Items_MenuToggler_1_op_Implicit_Divine_Menu_Objects_MenuObject__Divine_Menu_Items_MenuToggler__0_"></a> implicit operator MenuToggler<T\>\(MenuObject\)

```csharp
public static implicit operator MenuToggler<T>(MenuObject menuObject)
```

#### Parameters

`menuObject` [MenuObject](Divine.Menu.Objects.MenuObject.md)

#### Returns

 [MenuToggler](Divine.Menu.Items.MenuToggler\-1.md)<T\>

