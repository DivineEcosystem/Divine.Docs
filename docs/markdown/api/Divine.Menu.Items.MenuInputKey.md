# <a id="Divine_Menu_Items_MenuInputKey"></a> Class MenuInputKey

Namespace: [Divine.Menu.Items](Divine.Menu.Items.md)  
Assembly: Divine.dll  

```csharp
public class MenuInputKey : MenuText, IDisposable, IMenuTextExtensions, IMenuItemExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuItem](Divine.Menu.Items.MenuItem.md) ← 
[MenuText](Divine.Menu.Items.MenuText.md) ← 
[MenuInputKey](Divine.Menu.Items.MenuInputKey.md)

#### Derived

[MenuHoldKey](Divine.Menu.Items.MenuHoldKey.md), 
[MenuToggleKey](Divine.Menu.Items.MenuToggleKey.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IMenuTextExtensions](Divine.Menu.Items.IMenuTextExtensions.md), 
[IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

#### Inherited Members

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

[MenuExtensions.Disable<MenuInputKey\>\(MenuInputKey\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Disable\_\_1\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[MenuExtensions.Enable<MenuInputKey\>\(MenuInputKey\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Enable\_\_1\_\_\_0\_), 
[MenuExtensions.Hide<MenuInputKey\>\(MenuInputKey\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Hide\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<MenuInputKey\>\(MenuInputKey, params MenuInputKey\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[MenuExtensions.Load<MenuInputKey\>\(MenuInputKey\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Load\_\_1\_\_\_0\_), 
[MenuExtensions.Move<MenuInputKey\>\(MenuInputKey, int\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Move\_\_1\_\_\_0\_System\_Int32\_), 
[MenuExtensions.Refresh<MenuInputKey\>\(MenuInputKey, bool, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Refresh\_\_1\_\_\_0\_System\_Boolean\_System\_Boolean\_), 
[MenuExtensions.Reset<MenuInputKey\>\(MenuInputKey\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Reset\_\_1\_\_\_0\_), 
[MenuExtensions.Save<MenuInputKey\>\(MenuInputKey, MenuSaveMode\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Save\_\_1\_\_\_0\_Divine\_Menu\_Components\_MenuSaveMode\_), 
[MenuExtensions.SetDisplayTextFontColor<MenuInputKey\>\(MenuInputKey, Color?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetDisplayTextFontColor\_\_1\_\_\_0\_System\_Nullable\_Vortice\_Mathematics\_Color\_\_), 
[MenuExtensions.SetImage<MenuInputKey\>\(MenuInputKey, HeroId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Units\_Heroes\_Components\_HeroId\_System\_Boolean\_), 
[MenuExtensions.SetImage<MenuInputKey\>\(MenuInputKey, ItemId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Items\_Components\_ItemId\_System\_Boolean\_), 
[MenuExtensions.SetImage<MenuInputKey\>\(MenuInputKey, AbilityId\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_), 
[MenuExtensions.SetImage<MenuInputKey\>\(MenuInputKey, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<MenuInputKey\>\(MenuInputKey, string, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<MenuInputKey\>\(MenuInputKey, MenuImageKey?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_Nullable\_Divine\_Menu\_Components\_MenuImageKey\_\_), 
[MenuExtensions.SetImageFromResources<MenuInputKey\>\(MenuInputKey, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.SetImageFromResources<MenuInputKey\>\(MenuInputKey, string, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_System\_String\_), 
[MenuExtensions.SetSearchMark<MenuInputKey\>\(MenuInputKey, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetSearchMark\_\_1\_\_\_0\_System\_Boolean\_), 
[MenuExtensions.SetTooltip<MenuInputKey\>\(MenuInputKey, string?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetTooltip\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.Show<MenuInputKey\>\(MenuInputKey\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Show\_\_1\_\_\_0\_)

## Properties

### <a id="Divine_Menu_Items_MenuInputKey_DefaultKey"></a> DefaultKey

```csharp
public Key DefaultKey { get; }
```

#### Property Value

 [Key](Divine.Input.Key.md)

### <a id="Divine_Menu_Items_MenuInputKey_IsAssigningNewKey"></a> IsAssigningNewKey

```csharp
public bool IsAssigningNewKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuInputKey_Key"></a> Key

```csharp
public Key Key { get; set; }
```

#### Property Value

 [Key](Divine.Input.Key.md)

### <a id="Divine_Menu_Items_MenuInputKey_View"></a> View

```csharp
public IInputKeyView View { get; }
```

#### Property Value

 [IInputKeyView](Divine.Menu.Views.IInputKeyView.md)

### <a id="Divine_Menu_Items_MenuInputKey_Down"></a> Down

```csharp
public event SenderEventHandler<MenuInputKey>? Down
```

#### Event Type

 [SenderEventHandler](Divine.EventHandlers.SenderEventHandler\-1.md)<[MenuInputKey](Divine.Menu.Items.MenuInputKey.md)\>?

### <a id="Divine_Menu_Items_MenuInputKey_KeyChanged"></a> KeyChanged

```csharp
public event EventHandler<MenuInputKey, InputKeyChangedEventArgs>? KeyChanged
```

#### Event Type

 [EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler\-2)<[MenuInputKey](Divine.Menu.Items.MenuInputKey.md), [InputKeyChangedEventArgs](Divine.Menu.EventArgs.InputKeyChangedEventArgs.md)\>?

### <a id="Divine_Menu_Items_MenuInputKey_Up"></a> Up

```csharp
public event SenderEventHandler<MenuInputKey>? Up
```

#### Event Type

 [SenderEventHandler](Divine.EventHandlers.SenderEventHandler\-1.md)<[MenuInputKey](Divine.Menu.Items.MenuInputKey.md)\>?

## Operators

### <a id="Divine_Menu_Items_MenuInputKey_op_Implicit_Divine_Menu_Objects_MenuObject__Divine_Menu_Items_MenuInputKey"></a> implicit operator MenuInputKey\(MenuObject\)

```csharp
public static implicit operator MenuInputKey(MenuObject menuObject)
```

#### Parameters

`menuObject` [MenuObject](Divine.Menu.Objects.MenuObject.md)

#### Returns

 [MenuInputKey](Divine.Menu.Items.MenuInputKey.md)

