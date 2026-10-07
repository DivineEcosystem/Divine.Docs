# <a id="Divine_Menu_Items_MenuToggler"></a> Class MenuToggler

Namespace: [Divine.Menu.Items](Divine.Menu.Items.md)  
Assembly: Divine.dll  

```csharp
public sealed class MenuToggler : MenuTogglerBase<string>, IDisposable, IMenuExpanderExtensions, IMenuTogglerExtensions, IMenuTextExtensions, IMenuItemExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuItem](Divine.Menu.Items.MenuItem.md) ← 
[MenuText](Divine.Menu.Items.MenuText.md) ← 
[MenuExpander](Divine.Menu.Items.MenuExpander.md) ← 
[MenuTogglerBase<string\>](Divine.Menu.Items.MenuTogglerBase\-1.md) ← 
[MenuToggler](Divine.Menu.Items.MenuToggler.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IMenuExpanderExtensions](Divine.Menu.Items.IMenuExpanderExtensions.md), 
[IMenuTogglerExtensions](Divine.Menu.Items.IMenuTogglerExtensions.md), 
[IMenuTextExtensions](Divine.Menu.Items.IMenuTextExtensions.md), 
[IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

#### Inherited Members

[MenuTogglerBase<string\>.this\[string\]](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_Item\_\_0\_), 
[MenuTogglerBase<string\>.View](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_View), 
[MenuTogglerBase<string\>.Options](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_Options), 
[MenuTogglerBase<string\>.CanToggle](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_CanToggle), 
[MenuTogglerBase<string\>.CanChangePriority](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_CanChangePriority), 
[MenuTogglerBase<string\>.IsExpandable](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_IsExpandable), 
[MenuTogglerBase<string\>.DefaultValues](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_DefaultValues), 
[MenuTogglerBase<string\>.ImageKeys](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_ImageKeys), 
[MenuTogglerBase<string\>.Values](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_Values), 
[MenuTogglerBase<string\>.GetValue\(string\)](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_GetValue\_\_0\_), 
[MenuTogglerBase<string\>.TryGetValue\(string, out bool\)](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_TryGetValue\_\_0\_System\_Boolean\_\_), 
[MenuTogglerBase<string\>.SetValue\(string, bool\)](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_SetValue\_\_0\_System\_Boolean\_), 
[MenuTogglerBase<string\>.AddValue\(MenuTogglerValue<string\>\)](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_AddValue\_Divine\_Menu\_Components\_MenuTogglerValue\_\_0\_\_), 
[MenuTogglerBase<string\>.RemoveValue\(string\)](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_RemoveValue\_\_0\_), 
[MenuTogglerBase<string\>.GetPriority\(string\)](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_GetPriority\_\_0\_), 
[MenuTogglerBase<string\>.SetPriority\(string, int\)](Divine.Menu.Items.MenuTogglerBase\-1.md\#Divine\_Menu\_Items\_MenuTogglerBase\_1\_SetPriority\_\_0\_System\_Int32\_), 
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

[MenuExtensions.Collapse<MenuToggler\>\(MenuToggler\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Collapse\_\_1\_\_\_0\_), 
[MenuExtensions.Disable<MenuToggler\>\(MenuToggler\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Disable\_\_1\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[MenuExtensions.Enable<MenuToggler\>\(MenuToggler\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Enable\_\_1\_\_\_0\_), 
[MenuExtensions.Expand<MenuToggler\>\(MenuToggler\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Expand\_\_1\_\_\_0\_), 
[MenuExtensions.Hide<MenuToggler\>\(MenuToggler\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Hide\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<MenuToggler\>\(MenuToggler, params MenuToggler\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[MenuExtensions.Load<MenuToggler\>\(MenuToggler\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Load\_\_1\_\_\_0\_), 
[MenuExtensions.Move<MenuToggler\>\(MenuToggler, int\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Move\_\_1\_\_\_0\_System\_Int32\_), 
[MenuExtensions.Refresh<MenuToggler\>\(MenuToggler, bool, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Refresh\_\_1\_\_\_0\_System\_Boolean\_System\_Boolean\_), 
[MenuExtensions.Reset<MenuToggler\>\(MenuToggler\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Reset\_\_1\_\_\_0\_), 
[MenuExtensions.ResetPriorities<MenuToggler\>\(MenuToggler\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_ResetPriorities\_\_1\_\_\_0\_), 
[MenuExtensions.ResetValues<MenuToggler\>\(MenuToggler\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_ResetValues\_\_1\_\_\_0\_), 
[MenuExtensions.Save<MenuToggler\>\(MenuToggler, MenuSaveMode\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Save\_\_1\_\_\_0\_Divine\_Menu\_Components\_MenuSaveMode\_), 
[MenuExtensions.SetDisplayTextFontColor<MenuToggler\>\(MenuToggler, Color?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetDisplayTextFontColor\_\_1\_\_\_0\_System\_Nullable\_Vortice\_Mathematics\_Color\_\_), 
[MenuExtensions.SetImage<MenuToggler\>\(MenuToggler, HeroId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Units\_Heroes\_Components\_HeroId\_System\_Boolean\_), 
[MenuExtensions.SetImage<MenuToggler\>\(MenuToggler, ItemId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Items\_Components\_ItemId\_System\_Boolean\_), 
[MenuExtensions.SetImage<MenuToggler\>\(MenuToggler, AbilityId\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_), 
[MenuExtensions.SetImage<MenuToggler\>\(MenuToggler, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<MenuToggler\>\(MenuToggler, string, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<MenuToggler\>\(MenuToggler, MenuImageKey?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_Nullable\_Divine\_Menu\_Components\_MenuImageKey\_\_), 
[MenuExtensions.SetImageFromResources<MenuToggler\>\(MenuToggler, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.SetImageFromResources<MenuToggler\>\(MenuToggler, string, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_System\_String\_), 
[MenuExtensions.SetSearchMark<MenuToggler\>\(MenuToggler, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetSearchMark\_\_1\_\_\_0\_System\_Boolean\_), 
[MenuExtensions.SetTooltip<MenuToggler\>\(MenuToggler, string?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetTooltip\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.Show<MenuToggler\>\(MenuToggler\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Show\_\_1\_\_\_0\_)

## Methods

### <a id="Divine_Menu_Items_MenuToggler_AddValue_Divine_Entity_Entities_Abilities_Ability_System_Boolean_"></a> AddValue\(Ability, bool\)

```csharp
public bool AddValue(Ability ability, bool value = false)
```

#### Parameters

`ability` [Ability](Divine.Entity.Entities.Abilities.Ability.md)

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuToggler_AddValue_Divine_Entity_Entities_Abilities_Components_AbilityId_System_Boolean_"></a> AddValue\(AbilityId, bool\)

```csharp
public bool AddValue(AbilityId id, bool value = false)
```

#### Parameters

`id` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuToggler_AddValue_Divine_Menu_Components_MenuTogglerAbility_"></a> AddValue\(MenuTogglerAbility\)

```csharp
public bool AddValue(MenuTogglerAbility togglerValue)
```

#### Parameters

`togglerValue` [MenuTogglerAbility](Divine.Menu.Components.MenuTogglerAbility.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuToggler_AddValue_Divine_Menu_Components_MenuTogglerValue_"></a> AddValue\(MenuTogglerValue\)

```csharp
public bool AddValue(MenuTogglerValue togglerValue)
```

#### Parameters

`togglerValue` [MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuToggler_FullValueChanged"></a> FullValueChanged

```csharp
public event EventHandler<MenuToggler, TogglerChangedEventArgs> FullValueChanged
```

#### Event Type

 [EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler\-2)<[MenuToggler](Divine.Menu.Items.MenuToggler.md), [TogglerChangedEventArgs](Divine.Menu.EventArgs.TogglerChangedEventArgs.md)\>

### <a id="Divine_Menu_Items_MenuToggler_PriorityChanged"></a> PriorityChanged

```csharp
public event EventHandler<MenuToggler, TogglerPriorityChangedEventArgs> PriorityChanged
```

#### Event Type

 [EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler\-2)<[MenuToggler](Divine.Menu.Items.MenuToggler.md), [TogglerPriorityChangedEventArgs](Divine.Menu.EventArgs.TogglerPriorityChangedEventArgs.md)\>

### <a id="Divine_Menu_Items_MenuToggler_ValueChanged"></a> ValueChanged

```csharp
public event EventHandler<MenuToggler, TogglerChangedEventArgs> ValueChanged
```

#### Event Type

 [EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler\-2)<[MenuToggler](Divine.Menu.Items.MenuToggler.md), [TogglerChangedEventArgs](Divine.Menu.EventArgs.TogglerChangedEventArgs.md)\>

