# <a id="Divine_Menu_Items_MenuSlider"></a> Class MenuSlider

Namespace: [Divine.Menu.Items](Divine.Menu.Items.md)  
Assembly: Divine.dll  

```csharp
public sealed class MenuSlider : MenuText, IDisposable, IMenuTextExtensions, IMenuItemExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuItem](Divine.Menu.Items.MenuItem.md) ← 
[MenuText](Divine.Menu.Items.MenuText.md) ← 
[MenuSlider](Divine.Menu.Items.MenuSlider.md)

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
[MenuItem.Dispose\(bool\)](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_Dispose\_System\_Boolean\_), 
[MenuItem.ToString\(\)](Divine.Menu.Items.MenuItem.md\#Divine\_Menu\_Items\_MenuItem\_ToString), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[MenuExtensions.Disable<MenuSlider\>\(MenuSlider\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Disable\_\_1\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[MenuExtensions.Enable<MenuSlider\>\(MenuSlider\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Enable\_\_1\_\_\_0\_), 
[MenuExtensions.Hide<MenuSlider\>\(MenuSlider\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Hide\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<MenuSlider\>\(MenuSlider, params MenuSlider\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[MenuExtensions.Load<MenuSlider\>\(MenuSlider\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Load\_\_1\_\_\_0\_), 
[MenuExtensions.Move<MenuSlider\>\(MenuSlider, int\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Move\_\_1\_\_\_0\_System\_Int32\_), 
[MenuExtensions.Refresh<MenuSlider\>\(MenuSlider, bool, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Refresh\_\_1\_\_\_0\_System\_Boolean\_System\_Boolean\_), 
[MenuExtensions.Reset<MenuSlider\>\(MenuSlider\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Reset\_\_1\_\_\_0\_), 
[MenuExtensions.Save<MenuSlider\>\(MenuSlider, MenuSaveMode\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Save\_\_1\_\_\_0\_Divine\_Menu\_Components\_MenuSaveMode\_), 
[MenuExtensions.SetDisplayTextFontColor<MenuSlider\>\(MenuSlider, Color?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetDisplayTextFontColor\_\_1\_\_\_0\_System\_Nullable\_Vortice\_Mathematics\_Color\_\_), 
[MenuExtensions.SetImage<MenuSlider\>\(MenuSlider, HeroId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Units\_Heroes\_Components\_HeroId\_System\_Boolean\_), 
[MenuExtensions.SetImage<MenuSlider\>\(MenuSlider, ItemId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Items\_Components\_ItemId\_System\_Boolean\_), 
[MenuExtensions.SetImage<MenuSlider\>\(MenuSlider, AbilityId\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_), 
[MenuExtensions.SetImage<MenuSlider\>\(MenuSlider, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<MenuSlider\>\(MenuSlider, string, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<MenuSlider\>\(MenuSlider, MenuImageKey?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_Nullable\_Divine\_Menu\_Components\_MenuImageKey\_\_), 
[MenuExtensions.SetImageFromResources<MenuSlider\>\(MenuSlider, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.SetImageFromResources<MenuSlider\>\(MenuSlider, string, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_System\_String\_), 
[MenuExtensions.SetSearchMark<MenuSlider\>\(MenuSlider, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetSearchMark\_\_1\_\_\_0\_System\_Boolean\_), 
[MenuExtensions.SetTooltip<MenuSlider\>\(MenuSlider, string?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetTooltip\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.Show<MenuSlider\>\(MenuSlider\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Show\_\_1\_\_\_0\_)

## Properties

### <a id="Divine_Menu_Items_MenuSlider_DefaultValue"></a> DefaultValue

```csharp
public float DefaultValue { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Items_MenuSlider_IsFloatingPoint"></a> IsFloatingPoint

```csharp
public bool IsFloatingPoint { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuSlider_MaxValue"></a> MaxValue

```csharp
public float MaxValue { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Items_MenuSlider_MinValue"></a> MinValue

```csharp
public float MinValue { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Items_MenuSlider_Percent"></a> Percent

```csharp
public float Percent { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Items_MenuSlider_Value"></a> Value

```csharp
public float Value { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Items_MenuSlider_View"></a> View

```csharp
public ISliderView View { get; }
```

#### Property Value

 [ISliderView](Divine.Menu.Views.ISliderView.md)

### <a id="Divine_Menu_Items_MenuSlider_WheelStep"></a> WheelStep

```csharp
public float WheelStep { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Menu_Items_MenuSlider_AddValueChangedHandler_System_Boolean_System_EventHandler_Divine_Menu_Items_MenuSlider_Divine_Menu_EventArgs_SliderChangedEventArgs__"></a> AddValueChangedHandler\(bool, EventHandler<MenuSlider, SliderChangedEventArgs\>\)

```csharp
public void AddValueChangedHandler(bool addEvent, EventHandler<MenuSlider, SliderChangedEventArgs> handler)
```

#### Parameters

`addEvent` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`handler` [EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler\-2)<[MenuSlider](Divine.Menu.Items.MenuSlider.md), [SliderChangedEventArgs](Divine.Menu.EventArgs.SliderChangedEventArgs.md)\>

### <a id="Divine_Menu_Items_MenuSlider_RemoveValueChangedHandler_System_Boolean_System_EventHandler_Divine_Menu_Items_MenuSlider_Divine_Menu_EventArgs_SliderChangedEventArgs__"></a> RemoveValueChangedHandler\(bool, EventHandler<MenuSlider, SliderChangedEventArgs\>\)

```csharp
public void RemoveValueChangedHandler(bool removeEvent, EventHandler<MenuSlider, SliderChangedEventArgs> handler)
```

#### Parameters

`removeEvent` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`handler` [EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler\-2)<[MenuSlider](Divine.Menu.Items.MenuSlider.md), [SliderChangedEventArgs](Divine.Menu.EventArgs.SliderChangedEventArgs.md)\>

### <a id="Divine_Menu_Items_MenuSlider_ValueChanged"></a> ValueChanged

```csharp
public event EventHandler<MenuSlider, SliderChangedEventArgs> ValueChanged
```

#### Event Type

 [EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler\-2)<[MenuSlider](Divine.Menu.Items.MenuSlider.md), [SliderChangedEventArgs](Divine.Menu.EventArgs.SliderChangedEventArgs.md)\>

## Operators

### <a id="Divine_Menu_Items_MenuSlider_op_Explicit_Divine_Menu_Items_MenuSlider__System_Int32"></a> explicit operator int\(MenuSlider\)

```csharp
public static explicit operator int(MenuSlider slider)
```

#### Parameters

`slider` [MenuSlider](Divine.Menu.Items.MenuSlider.md)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Menu_Items_MenuSlider_op_Explicit_Divine_Menu_Items_MenuSlider__System_Byte"></a> explicit operator byte\(MenuSlider\)

```csharp
public static explicit operator byte(MenuSlider slider)
```

#### Parameters

`slider` [MenuSlider](Divine.Menu.Items.MenuSlider.md)

#### Returns

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="Divine_Menu_Items_MenuSlider_op_Implicit_Divine_Menu_Objects_MenuObject__Divine_Menu_Items_MenuSlider"></a> implicit operator MenuSlider\(MenuObject\)

```csharp
public static implicit operator MenuSlider(MenuObject menuObject)
```

#### Parameters

`menuObject` [MenuObject](Divine.Menu.Objects.MenuObject.md)

#### Returns

 [MenuSlider](Divine.Menu.Items.MenuSlider.md)

### <a id="Divine_Menu_Items_MenuSlider_op_Implicit_Divine_Menu_Items_MenuSlider__System_Single"></a> implicit operator float\(MenuSlider\)

```csharp
public static implicit operator float(MenuSlider slider)
```

#### Parameters

`slider` [MenuSlider](Divine.Menu.Items.MenuSlider.md)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

