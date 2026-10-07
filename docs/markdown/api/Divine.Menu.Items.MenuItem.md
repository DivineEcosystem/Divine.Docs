# <a id="Divine_Menu_Items_MenuItem"></a> Class MenuItem

Namespace: [Divine.Menu.Items](Divine.Menu.Items.md)  
Assembly: Divine.dll  

```csharp
public abstract class MenuItem : IMenuItemExtensions, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuItem](Divine.Menu.Items.MenuItem.md)

#### Derived

[MenuLinker](Divine.Menu.Items.MenuLinker.md), 
[MenuText](Divine.Menu.Items.MenuText.md)

#### Implements

[IMenuItemExtensions](Divine.Menu.Items.IMenuItemExtensions.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[MenuExtensions.Disable<MenuItem\>\(MenuItem\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Disable\_\_1\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[MenuExtensions.Enable<MenuItem\>\(MenuItem\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Enable\_\_1\_\_\_0\_), 
[MenuExtensions.Hide<MenuItem\>\(MenuItem\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Hide\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<MenuItem\>\(MenuItem, params MenuItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[MenuExtensions.Load<MenuItem\>\(MenuItem\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Load\_\_1\_\_\_0\_), 
[MenuExtensions.Move<MenuItem\>\(MenuItem, int\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Move\_\_1\_\_\_0\_System\_Int32\_), 
[MenuExtensions.Refresh<MenuItem\>\(MenuItem, bool, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Refresh\_\_1\_\_\_0\_System\_Boolean\_System\_Boolean\_), 
[MenuExtensions.Reset<MenuItem\>\(MenuItem\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Reset\_\_1\_\_\_0\_), 
[MenuExtensions.Save<MenuItem\>\(MenuItem, MenuSaveMode\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Save\_\_1\_\_\_0\_Divine\_Menu\_Components\_MenuSaveMode\_), 
[MenuExtensions.SetImage<MenuItem\>\(MenuItem, HeroId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Units\_Heroes\_Components\_HeroId\_System\_Boolean\_), 
[MenuExtensions.SetImage<MenuItem\>\(MenuItem, ItemId, bool\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Items\_Components\_ItemId\_System\_Boolean\_), 
[MenuExtensions.SetImage<MenuItem\>\(MenuItem, AbilityId\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_Divine\_Entity\_Entities\_Abilities\_Components\_AbilityId\_), 
[MenuExtensions.SetImage<MenuItem\>\(MenuItem, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<MenuItem\>\(MenuItem, string, string, ImageType\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_String\_System\_String\_Divine\_Renderer\_ImageType\_), 
[MenuExtensions.SetImage<MenuItem\>\(MenuItem, MenuImageKey?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImage\_\_1\_\_\_0\_System\_Nullable\_Divine\_Menu\_Components\_MenuImageKey\_\_), 
[MenuExtensions.SetImageFromResources<MenuItem\>\(MenuItem, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.SetImageFromResources<MenuItem\>\(MenuItem, string, string\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetImageFromResources\_\_1\_\_\_0\_System\_String\_System\_String\_), 
[MenuExtensions.SetTooltip<MenuItem\>\(MenuItem, string?\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_SetTooltip\_\_1\_\_\_0\_System\_String\_), 
[MenuExtensions.Show<MenuItem\>\(MenuItem\)](Divine.Menu.MenuExtensions.md\#Divine\_Menu\_MenuExtensions\_Show\_\_1\_\_\_0\_)

## Properties

### <a id="Divine_Menu_Items_MenuItem_CanSave"></a> CanSave

```csharp
public bool CanSave { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuItem_CanVisible"></a> CanVisible

```csharp
public bool CanVisible { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuItem_Context"></a> Context

```csharp
public MenuContext Context { get; }
```

#### Property Value

 [MenuContext](Divine.Menu.Items.MenuContext.md)

### <a id="Divine_Menu_Items_MenuItem_ContextStyle"></a> ContextStyle

```csharp
public IContextStyle ContextStyle { get; }
```

#### Property Value

 [IContextStyle](Divine.Menu.Styles.IContextStyle.md)

### <a id="Divine_Menu_Items_MenuItem_Flags"></a> Flags

```csharp
public virtual MenuFlags Flags { get; }
```

#### Property Value

 [MenuFlags](Divine.Menu.Components.MenuFlags.md)

### <a id="Divine_Menu_Items_MenuItem_FullName"></a> FullName

```csharp
public virtual string FullName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Menu_Items_MenuItem_ImageKey"></a> ImageKey

```csharp
public MenuImageKey? ImageKey { get; }
```

#### Property Value

 [MenuImageKey](Divine.Menu.Components.MenuImageKey.md)?

### <a id="Divine_Menu_Items_MenuItem_IsContext"></a> IsContext

```csharp
public bool IsContext { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuItem_IsDisabled"></a> IsDisabled

```csharp
public bool IsDisabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuItem_IsDisposed"></a> IsDisposed

```csharp
public bool IsDisposed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuItem_IsHidden"></a> IsHidden

```csharp
public bool IsHidden { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuItem_IsRequiresSave"></a> IsRequiresSave

```csharp
public bool IsRequiresSave { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuItem_IsRoot"></a> IsRoot

```csharp
public bool IsRoot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuItem_IsSearcherMark"></a> IsSearcherMark

```csharp
public bool IsSearcherMark { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuItem_IsSelected"></a> IsSelected

```csharp
public bool IsSelected { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuItem_IsVisible"></a> IsVisible

```csharp
public bool IsVisible { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuItem_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Menu_Items_MenuItem_Parent"></a> Parent

```csharp
public Menu? Parent { get; }
```

#### Property Value

 [Menu](Divine.Menu.Items.Menu.md)?

### <a id="Divine_Menu_Items_MenuItem_Priority"></a> Priority

```csharp
public virtual int Priority { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Menu_Items_MenuItem_Root"></a> Root

```csharp
public RootObject Root { get; }
```

#### Property Value

 [RootObject](Divine.Menu.Objects.RootObject.md)

### <a id="Divine_Menu_Items_MenuItem_Item_System_String_"></a> this\[string\]

```csharp
public virtual MenuObject this[string name] { get; }
```

#### Property Value

 [MenuObject](Divine.Menu.Objects.MenuObject.md)

### <a id="Divine_Menu_Items_MenuItem_Tooltip"></a> Tooltip

```csharp
public string? Tooltip { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Divine_Menu_Items_MenuItem_View"></a> View

```csharp
public IView View { get; }
```

#### Property Value

 [IView](Divine.Menu.Views.IView.md)

### <a id="Divine_Menu_Items_MenuItem_Views"></a> Views

```csharp
public List<IView> Views { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IView](Divine.Menu.Views.IView.md)\>

## Methods

### <a id="Divine_Menu_Items_MenuItem_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
public void Dispose(bool forceSave = true)
```

#### Parameters

`forceSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Items_MenuItem_OnRefresh"></a> OnRefresh\(\)

```csharp
protected virtual void OnRefresh()
```

### <a id="Divine_Menu_Items_MenuItem_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override sealed string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

## Operators

### <a id="Divine_Menu_Items_MenuItem_op_Implicit_Divine_Menu_Objects_MenuObject__Divine_Menu_Items_MenuItem"></a> implicit operator MenuItem\(MenuObject\)

```csharp
public static implicit operator MenuItem(MenuObject menuObject)
```

#### Parameters

`menuObject` [MenuObject](Divine.Menu.Objects.MenuObject.md)

#### Returns

 [MenuItem](Divine.Menu.Items.MenuItem.md)

