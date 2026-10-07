# <a id="Divine_Menu_Items_MenuTogglerBase_1"></a> Class MenuTogglerBase<T\>

Namespace: [Divine.Menu.Items](Divine.Menu.Items.md)  
Assembly: Divine.dll  

```csharp
public abstract class MenuTogglerBase<T> : MenuExpander, IDisposable, IMenuExpanderExtensions, IMenuTogglerExtensions, IMenuTextExtensions, IMenuItemExtensions where T : notnull
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuItem](Divine.Menu.Items.MenuItem.md) ← 
[MenuText](Divine.Menu.Items.MenuText.md) ← 
[MenuExpander](Divine.Menu.Items.MenuExpander.md) ← 
[MenuTogglerBase<T\>](Divine.Menu.Items.MenuTogglerBase\-1.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IMenuExpanderExtensions](Divine.Menu.Items.IMenuExpanderExtensions.md), 
[IMenuTogglerExtensions](Divine.Menu.Items.IMenuTogglerExtensions.md), 
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

[MenuExtensions.Collapse<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Collapse\_\_1\_\_\_0\_), 
[MenuExtensions.Disable<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Disable\_\_1\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[MenuExtensions.Enable<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Enable\_\_1\_\_\_0\_), 
[MenuExtensions.Expand<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Expand\_\_1\_\_\_0\_), 
[MenuExtensions.Hide<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Hide\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>, params MenuTogglerBase<T\>\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[MenuExtensions.Load<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Load\_\_1\_\_\_0\_), 
[MenuExtensions.Move<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>, int\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Move\_\_1\_\_\_0\_System\_Int32\_), 
[MenuExtensions.Refresh<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>, bool, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Refresh\_\_1\_\_\_0\_System\_Boolean\_System\_Boolean\_), 
[MenuExtensions.Reset<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Reset\_\_1\_\_\_0\_), 
[MenuExtensions.ResetPriorities<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_ResetPriorities\_\_1\_\_\_0\_), 
[MenuExtensions.ResetValues<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_ResetValues\_\_1\_\_\_0\_), 
[MenuExtensions.Save<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>, MenuSaveMode\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Save\_\_1\_\_\_0\_Divine\_Menu\_Components\_MenuSaveMode\_), 
[MenuExtensions.SetDisplayTextFontColor<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>, Color?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetDisplayTextFontColor\_\_1\_\_\_0\_System\_Nullable\_Vortice\_Mathematics\_Color\_\_), 
[MenuExtensions.SetImage<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>, HeroId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Units\_Heroes\_Components\_HeroId\_System\_Boolean\_), 
[MenuExtensions.SetImage<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>, ItemId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Items\_Components\_ItemId\_System\_Boolean\_), 
[MenuExtensions.SetImage<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>, AbilityId\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_), 
[MenuExtensions.SetImage<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>, string, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>, MenuImageKey?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_Nullable\_Divine\_Menu\_Components\_MenuImageKey\_\_), 
[MenuExtensions.SetImageFromResources<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.SetImageFromResources<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>, string, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_System\_String\_), 
[MenuExtensions.SetSearchMark<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetSearchMark\_\_1\_\_\_0\_System\_Boolean\_), 
[MenuExtensions.SetTooltip<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>, string?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetTooltip\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.Show<MenuTogglerBase<T\>\>\(MenuTogglerBase<T\>\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Show\_\_1\_\_\_0\_)

## Properties

### <a id="Divine_Menu_Items_MenuTogglerBase_1_CanChangePriority"></a> CanChangePriority

```csharp
public bool CanChangePriority { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuTogglerBase_1_CanToggle"></a> CanToggle

```csharp
public bool CanToggle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuTogglerBase_1_DefaultValues"></a> DefaultValues

```csharp
public IReadOnlyDictionary<T, bool> DefaultValues { get; }
```

#### Property Value

 [IReadOnlyDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2)<T, [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="Divine_Menu_Items_MenuTogglerBase_1_ImageKeys"></a> ImageKeys

```csharp
public IReadOnlyDictionary<T, MenuImageKey> ImageKeys { get; }
```

#### Property Value

 [IReadOnlyDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2)<T, [MenuImageKey](Divine.Menu.Components.MenuImageKey.md)\>

### <a id="Divine_Menu_Items_MenuTogglerBase_1_IsExpandable"></a> IsExpandable

```csharp
public bool IsExpandable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuTogglerBase_1_Options"></a> Options

```csharp
public MenuTogglerOptions Options { get; set; }
```

#### Property Value

 [MenuTogglerOptions](Divine.Menu.Components.MenuTogglerOptions.md)

### <a id="Divine_Menu_Items_MenuTogglerBase_1_Item__0_"></a> this\[T\]

```csharp
public bool this[T key] { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuTogglerBase_1_Values"></a> Values

```csharp
public IReadOnlyDictionary<T, bool> Values { get; }
```

#### Property Value

 [IReadOnlyDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2)<T, [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="Divine_Menu_Items_MenuTogglerBase_1_View"></a> View

```csharp
public ITogglerView<T> View { get; }
```

#### Property Value

 [ITogglerView](Divine.Menu.Views.ITogglerView\-1.md)<T\>

## Methods

### <a id="Divine_Menu_Items_MenuTogglerBase_1_AddValue_Divine_Menu_Components_MenuTogglerValue__0__"></a> AddValue\(MenuTogglerValue<T\>\)

```csharp
public bool AddValue(MenuTogglerValue<T> togglerValue)
```

#### Parameters

`togglerValue` [MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue\-1.md)<T\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuTogglerBase_1_GetPriority__0_"></a> GetPriority\(T\)

```csharp
public int GetPriority(T key)
```

#### Parameters

`key` T

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Menu_Items_MenuTogglerBase_1_GetValue__0_"></a> GetValue\(T\)

```csharp
public bool GetValue(T key)
```

#### Parameters

`key` T

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuTogglerBase_1_RemoveValue__0_"></a> RemoveValue\(T\)

```csharp
public bool RemoveValue(T key)
```

#### Parameters

`key` T

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuTogglerBase_1_SetPriority__0_System_Int32_"></a> SetPriority\(T, int\)

```csharp
public bool SetPriority(T key, int priority)
```

#### Parameters

`key` T

`priority` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuTogglerBase_1_SetValue__0_System_Boolean_"></a> SetValue\(T, bool\)

```csharp
public bool SetValue(T key, bool value)
```

#### Parameters

`key` T

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuTogglerBase_1_TryGetValue__0_System_Boolean__"></a> TryGetValue\(T, out bool\)

```csharp
public bool TryGetValue(T key, out bool value)
```

#### Parameters

`key` T

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Operators

### <a id="Divine_Menu_Items_MenuTogglerBase_1_op_Implicit_Divine_Menu_Objects_MenuObject__Divine_Menu_Items_MenuTogglerBase__0_"></a> implicit operator MenuTogglerBase<T\>\(MenuObject\)

```csharp
public static implicit operator MenuTogglerBase<T>(MenuObject menuObject)
```

#### Parameters

`menuObject` [MenuObject](Divine.Menu.Objects.MenuObject.md)

#### Returns

 [MenuTogglerBase](Divine.Menu.Items.MenuTogglerBase\-1.md)<T\>

