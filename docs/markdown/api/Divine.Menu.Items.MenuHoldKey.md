# <a id="Divine_Menu_Items_MenuHoldKey"></a> Class MenuHoldKey

Namespace: [Divine.Menu.Items](Divine.Menu.Items.md)  
Assembly: Divine.dll  

```csharp
public sealed class MenuHoldKey : MenuInputKey, IDisposable, IMenuTextExtensions, IMenuItemExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuItem](Divine.Menu.Items.MenuItem.md) ← 
[MenuText](Divine.Menu.Items.MenuText.md) ← 
[MenuInputKey](Divine.Menu.Items.MenuInputKey.md) ← 
[MenuHoldKey](Divine.Menu.Items.MenuHoldKey.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IMenuTextExtensions](Divine.Menu.Items.IMenuTextExtensions.md), 
[IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md)

#### Inherited Members

[MenuInputKey.View](Divine.Menu.Items.MenuInputKey.md\#Divine\_Menu\_Items\_MenuInputKey\_View), 
[MenuInputKey.DefaultKey](Divine.Menu.Items.MenuInputKey.md\#Divine\_Menu\_Items\_MenuInputKey\_DefaultKey), 
[MenuInputKey.Key](Divine.Menu.Items.MenuInputKey.md\#Divine\_Menu\_Items\_MenuInputKey\_Key), 
[MenuInputKey.IsAssigningNewKey](Divine.Menu.Items.MenuInputKey.md\#Divine\_Menu\_Items\_MenuInputKey\_IsAssigningNewKey), 
[MenuInputKey.KeyChanged](Divine.Menu.Items.MenuInputKey.md\#Divine\_Menu\_Items\_MenuInputKey\_KeyChanged), 
[MenuInputKey.Down](Divine.Menu.Items.MenuInputKey.md\#Divine\_Menu\_Items\_MenuInputKey\_Down), 
[MenuInputKey.Up](Divine.Menu.Items.MenuInputKey.md\#Divine\_Menu\_Items\_MenuInputKey\_Up), 
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

[MenuExtensions.Disable<MenuHoldKey\>\(MenuHoldKey\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Disable\_\_1\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[MenuExtensions.Enable<MenuHoldKey\>\(MenuHoldKey\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Enable\_\_1\_\_\_0\_), 
[MenuExtensions.Hide<MenuHoldKey\>\(MenuHoldKey\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Hide\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<MenuHoldKey\>\(MenuHoldKey, params MenuHoldKey\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[MenuExtensions.Load<MenuHoldKey\>\(MenuHoldKey\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Load\_\_1\_\_\_0\_), 
[MenuExtensions.Move<MenuHoldKey\>\(MenuHoldKey, int\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Move\_\_1\_\_\_0\_System\_Int32\_), 
[MenuExtensions.Refresh<MenuHoldKey\>\(MenuHoldKey, bool, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Refresh\_\_1\_\_\_0\_System\_Boolean\_System\_Boolean\_), 
[MenuExtensions.Reset<MenuHoldKey\>\(MenuHoldKey\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Reset\_\_1\_\_\_0\_), 
[MenuExtensions.Save<MenuHoldKey\>\(MenuHoldKey, MenuSaveMode\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Save\_\_1\_\_\_0\_Divine\_Menu\_Components\_MenuSaveMode\_), 
[MenuExtensions.SetDisplayTextFontColor<MenuHoldKey\>\(MenuHoldKey, Color?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetDisplayTextFontColor\_\_1\_\_\_0\_System\_Nullable\_Vortice\_Mathematics\_Color\_\_), 
[MenuExtensions.SetImage<MenuHoldKey\>\(MenuHoldKey, HeroId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Units\_Heroes\_Components\_HeroId\_System\_Boolean\_), 
[MenuExtensions.SetImage<MenuHoldKey\>\(MenuHoldKey, ItemId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Items\_Components\_ItemId\_System\_Boolean\_), 
[MenuExtensions.SetImage<MenuHoldKey\>\(MenuHoldKey, AbilityId\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_), 
[MenuExtensions.SetImage<MenuHoldKey\>\(MenuHoldKey, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<MenuHoldKey\>\(MenuHoldKey, string, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<MenuHoldKey\>\(MenuHoldKey, MenuImageKey?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_Nullable\_Divine\_Menu\_Components\_MenuImageKey\_\_), 
[MenuExtensions.SetImageFromResources<MenuHoldKey\>\(MenuHoldKey, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.SetImageFromResources<MenuHoldKey\>\(MenuHoldKey, string, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_System\_String\_), 
[MenuExtensions.SetSearchMark<MenuHoldKey\>\(MenuHoldKey, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetSearchMark\_\_1\_\_\_0\_System\_Boolean\_), 
[MenuExtensions.SetTooltip<MenuHoldKey\>\(MenuHoldKey, string?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetTooltip\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.Show<MenuHoldKey\>\(MenuHoldKey\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Show\_\_1\_\_\_0\_)

## Properties

### <a id="Divine_Menu_Items_MenuHoldKey_Value"></a> Value

```csharp
public bool Value { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuHoldKey_View"></a> View

```csharp
public IHoldKeyView View { get; }
```

#### Property Value

 [IHoldKeyView](Divine.Menu.Views.IHoldKeyView.md)

## Methods

### <a id="Divine_Menu_Items_MenuHoldKey_AddValueChangedHandler_System_Boolean_System_EventHandler_Divine_Menu_Items_MenuHoldKey_Divine_Menu_EventArgs_HoldKeyChangedEventArgs__"></a> AddValueChangedHandler\(bool, EventHandler<MenuHoldKey, HoldKeyChangedEventArgs\>\)

```csharp
public void AddValueChangedHandler(bool addEventIfValueTrue, EventHandler<MenuHoldKey, HoldKeyChangedEventArgs> handler)
```

#### Parameters

`addEventIfValueTrue` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`handler` [EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler\-2)<[MenuHoldKey](Divine.Menu.Items.MenuHoldKey.md), [HoldKeyChangedEventArgs](Divine.Menu.EventArgs.HoldKeyChangedEventArgs.md)\>

### <a id="Divine_Menu_Items_MenuHoldKey_RemoveValueChangedHandler_System_Boolean_System_EventHandler_Divine_Menu_Items_MenuHoldKey_Divine_Menu_EventArgs_HoldKeyChangedEventArgs__"></a> RemoveValueChangedHandler\(bool, EventHandler<MenuHoldKey, HoldKeyChangedEventArgs\>\)

```csharp
public void RemoveValueChangedHandler(bool removeEventIfValueTrue, EventHandler<MenuHoldKey, HoldKeyChangedEventArgs> handler)
```

#### Parameters

`removeEventIfValueTrue` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`handler` [EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler\-2)<[MenuHoldKey](Divine.Menu.Items.MenuHoldKey.md), [HoldKeyChangedEventArgs](Divine.Menu.EventArgs.HoldKeyChangedEventArgs.md)\>

### <a id="Divine_Menu_Items_MenuHoldKey_ValueChanged"></a> ValueChanged

```csharp
public event EventHandler<MenuHoldKey, HoldKeyChangedEventArgs> ValueChanged
```

#### Event Type

 [EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler\-2)<[MenuHoldKey](Divine.Menu.Items.MenuHoldKey.md), [HoldKeyChangedEventArgs](Divine.Menu.EventArgs.HoldKeyChangedEventArgs.md)\>

## Operators

### <a id="Divine_Menu_Items_MenuHoldKey_op_Implicit_Divine_Menu_Objects_MenuObject__Divine_Menu_Items_MenuHoldKey"></a> implicit operator MenuHoldKey\(MenuObject\)

```csharp
public static implicit operator MenuHoldKey(MenuObject menuObject)
```

#### Parameters

`menuObject` [MenuObject](Divine.Menu.Objects.MenuObject.md)

#### Returns

 [MenuHoldKey](Divine.Menu.Items.MenuHoldKey.md)

### <a id="Divine_Menu_Items_MenuHoldKey_op_Implicit_Divine_Menu_Items_MenuHoldKey__System_Boolean"></a> implicit operator bool\(MenuHoldKey\)

```csharp
public static implicit operator bool(MenuHoldKey holdKey)
```

#### Parameters

`holdKey` [MenuHoldKey](Divine.Menu.Items.MenuHoldKey.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

