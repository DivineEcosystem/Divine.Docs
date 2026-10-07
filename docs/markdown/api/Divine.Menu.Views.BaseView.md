# <a id="Divine_Menu_Views_BaseView"></a> Class BaseView

Namespace: [Divine.Menu.Views](Divine.Menu.Views.md)  
Assembly: Divine.dll  

```csharp
public abstract class BaseView : IView
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BaseView](Divine.Menu.Views.BaseView.md)

#### Derived

[View](Divine.Menu.Views.Default.View.md)

#### Implements

[IView](Divine.Menu.Views.IView.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<BaseView\>\(BaseView, params BaseView\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Menu_Views_BaseView__ctor_Divine_Menu_Items_MenuItem_Divine_Menu_Styles_IStyle_Divine_Menu_Styles_IGeneralStyle_Divine_Menu_Renderers_IMenuRenderer_"></a> BaseView\(MenuItem, IStyle, IGeneralStyle, IMenuRenderer\)

```csharp
public BaseView(MenuItem owner, IStyle style, IGeneralStyle generalStyle, IMenuRenderer menuRenderer)
```

#### Parameters

`owner` [MenuItem](Divine.Menu.Items.MenuItem.md)

`style` [IStyle](Divine.Menu.Styles.IStyle.md)

`generalStyle` [IGeneralStyle](Divine.Menu.Styles.IGeneralStyle.md)

`menuRenderer` [IMenuRenderer](Divine.Menu.Renderers.IMenuRenderer.md)

## Properties

### <a id="Divine_Menu_Views_BaseView_Bottom"></a> Bottom

```csharp
public float Bottom { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Views_BaseView_BottomLeft"></a> BottomLeft

```csharp
public Vector2 BottomLeft { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Menu_Views_BaseView_BottomRight"></a> BottomRight

```csharp
public Vector2 BottomRight { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Menu_Views_BaseView_CanVisible"></a> CanVisible

```csharp
public bool CanVisible { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_BaseView_Context"></a> Context

```csharp
public IContextView Context { get; }
```

#### Property Value

 [IContextView](Divine.Menu.Views.IContextView.md)

### <a id="Divine_Menu_Views_BaseView_ContextPosition"></a> ContextPosition

```csharp
public Vector2 ContextPosition { get; set; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Menu_Views_BaseView_ContextStyle"></a> ContextStyle

```csharp
public IContextStyle ContextStyle { get; }
```

#### Property Value

 [IContextStyle](Divine.Menu.Styles.IContextStyle.md)

### <a id="Divine_Menu_Views_BaseView_ExtraHeight"></a> ExtraHeight

```csharp
public virtual float ExtraHeight { get; protected set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Views_BaseView_Flags"></a> Flags

```csharp
public MenuFlags Flags { get; }
```

#### Property Value

 [MenuFlags](Divine.Menu.Components.MenuFlags.md)

### <a id="Divine_Menu_Views_BaseView_GeneralStyle"></a> GeneralStyle

```csharp
public IStyle GeneralStyle { get; }
```

#### Property Value

 [IStyle](Divine.Menu.Styles.IStyle.md)

### <a id="Divine_Menu_Views_BaseView_Height"></a> Height

```csharp
public float Height { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Views_BaseView_ImageKey"></a> ImageKey

```csharp
public MenuImageKey? ImageKey { get; }
```

#### Property Value

 [MenuImageKey](Divine.Menu.Components.MenuImageKey.md)?

### <a id="Divine_Menu_Views_BaseView_ImageRectangle"></a> ImageRectangle

```csharp
public virtual RoundedRect ImageRectangle { get; protected set; }
```

#### Property Value

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Menu_Views_BaseView_ImageSize"></a> ImageSize

```csharp
public virtual Size ImageSize { get; protected set; }
```

#### Property Value

 [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

### <a id="Divine_Menu_Views_BaseView_IsDisabled"></a> IsDisabled

```csharp
public bool IsDisabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_BaseView_IsHovered"></a> IsHovered

```csharp
public bool IsHovered { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_BaseView_IsRoot"></a> IsRoot

```csharp
public bool IsRoot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_BaseView_IsSearcherMark"></a> IsSearcherMark

```csharp
public bool IsSearcherMark { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_BaseView_IsSelected"></a> IsSelected

```csharp
public bool IsSelected { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_BaseView_IsVisible"></a> IsVisible

```csharp
public bool IsVisible { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_BaseView_Left"></a> Left

```csharp
public float Left { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Views_BaseView_Linked"></a> Linked

```csharp
public MenuItem Linked { get; }
```

#### Property Value

 [MenuItem](Divine.Menu.Items.MenuItem.md)

### <a id="Divine_Menu_Views_BaseView_Next"></a> Next

```csharp
public BaseView? Next { get; }
```

#### Property Value

 [BaseView](Divine.Menu.Views.BaseView.md)?

### <a id="Divine_Menu_Views_BaseView_Owner"></a> Owner

```csharp
public MenuItem Owner { get; }
```

#### Property Value

 [MenuItem](Divine.Menu.Items.MenuItem.md)

### <a id="Divine_Menu_Views_BaseView_Parent"></a> Parent

```csharp
public IMenuView? Parent { get; }
```

#### Property Value

 [IMenuView](Divine.Menu.Views.IMenuView.md)?

### <a id="Divine_Menu_Views_BaseView_Position"></a> Position

```csharp
public Vector2 Position { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Menu_Views_BaseView_Prev"></a> Prev

```csharp
public BaseView? Prev { get; }
```

#### Property Value

 [BaseView](Divine.Menu.Views.BaseView.md)?

### <a id="Divine_Menu_Views_BaseView_Rectangle"></a> Rectangle

```csharp
public virtual RoundedRect Rectangle { get; protected set; }
```

#### Property Value

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Menu_Views_BaseView_Renderer"></a> Renderer

```csharp
public IMenuRenderer Renderer { get; }
```

#### Property Value

 [IMenuRenderer](Divine.Menu.Renderers.IMenuRenderer.md)

### <a id="Divine_Menu_Views_BaseView_Right"></a> Right

```csharp
public float Right { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Views_BaseView_SelectedView"></a> SelectedView

```csharp
public static BaseView? SelectedView { get; }
```

#### Property Value

 [BaseView](Divine.Menu.Views.BaseView.md)?

### <a id="Divine_Menu_Views_BaseView_Size"></a> Size

```csharp
public Size Size { get; }
```

#### Property Value

 [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

### <a id="Divine_Menu_Views_BaseView_Style"></a> Style

```csharp
public IStyle Style { get; }
```

#### Property Value

 [IStyle](Divine.Menu.Styles.IStyle.md)

### <a id="Divine_Menu_Views_BaseView_Tooltip"></a> Tooltip

```csharp
public string? Tooltip { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Divine_Menu_Views_BaseView_Top"></a> Top

```csharp
public float Top { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Views_BaseView_TopLeft"></a> TopLeft

```csharp
public Vector2 TopLeft { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Menu_Views_BaseView_TopRight"></a> TopRight

```csharp
public Vector2 TopRight { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Menu_Views_BaseView_Width"></a> Width

```csharp
public float Width { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Menu_Views_BaseView_CreateMiniMenu_System_String_System_Numerics_Vector2_"></a> CreateMiniMenu\(string, Vector2\)

```csharp
protected virtual void CreateMiniMenu(string name, Vector2 position)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Menu_Views_BaseView_Dispose"></a> Dispose\(\)

```csharp
protected virtual void Dispose()
```

### <a id="Divine_Menu_Views_BaseView_GetHoverValue"></a> GetHoverValue\(\)

```csharp
protected virtual float GetHoverValue()
```

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Views_BaseView_OnContextHide"></a> OnContextHide\(\)

```csharp
protected virtual void OnContextHide()
```

### <a id="Divine_Menu_Views_BaseView_OnContextShow"></a> OnContextShow\(\)

```csharp
protected virtual void OnContextShow()
```

### <a id="Divine_Menu_Views_BaseView_OnDisable"></a> OnDisable\(\)

```csharp
protected virtual void OnDisable()
```

### <a id="Divine_Menu_Views_BaseView_OnDraw"></a> OnDraw\(\)

```csharp
protected virtual void OnDraw()
```

### <a id="Divine_Menu_Views_BaseView_OnDrawBackground"></a> OnDrawBackground\(\)

```csharp
protected virtual void OnDrawBackground()
```

### <a id="Divine_Menu_Views_BaseView_OnDrawHover"></a> OnDrawHover\(\)

```csharp
protected virtual void OnDrawHover()
```

### <a id="Divine_Menu_Views_BaseView_OnDrawImage"></a> OnDrawImage\(\)

```csharp
protected virtual void OnDrawImage()
```

### <a id="Divine_Menu_Views_BaseView_OnDrawSpecial"></a> OnDrawSpecial\(\)

```csharp
protected virtual void OnDrawSpecial()
```

### <a id="Divine_Menu_Views_BaseView_OnDrawSpecialImage"></a> OnDrawSpecialImage\(\)

```csharp
protected virtual void OnDrawSpecialImage()
```

### <a id="Divine_Menu_Views_BaseView_OnDrawSpecialText"></a> OnDrawSpecialText\(\)

```csharp
protected virtual void OnDrawSpecialText()
```

### <a id="Divine_Menu_Views_BaseView_OnDrawStart"></a> OnDrawStart\(\)

```csharp
protected virtual void OnDrawStart()
```

### <a id="Divine_Menu_Views_BaseView_OnEnable"></a> OnEnable\(\)

```csharp
protected virtual void OnEnable()
```

### <a id="Divine_Menu_Views_BaseView_OnHide"></a> OnHide\(\)

```csharp
protected virtual void OnHide()
```

### <a id="Divine_Menu_Views_BaseView_OnHideMiniMenu_Divine_Menu_Items_MiniMenu_"></a> OnHideMiniMenu\(MiniMenu\)

```csharp
protected virtual void OnHideMiniMenu(MiniMenu miniMenu)
```

#### Parameters

`miniMenu` [MiniMenu](Divine.Menu.Items.MiniMenu.md)

### <a id="Divine_Menu_Views_BaseView_OnHoverEnd"></a> OnHoverEnd\(\)

```csharp
protected virtual void OnHoverEnd()
```

### <a id="Divine_Menu_Views_BaseView_OnHoverStart"></a> OnHoverStart\(\)

```csharp
protected virtual void OnHoverStart()
```

### <a id="Divine_Menu_Views_BaseView_OnMouseKeyDown_System_Boolean_System_Numerics_Vector2_"></a> OnMouseKeyDown\(bool, Vector2\)

```csharp
protected virtual bool OnMouseKeyDown(bool right, Vector2 position)
```

#### Parameters

`right` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_BaseView_OnMouseKeyUp_System_Boolean_System_Numerics_Vector2_"></a> OnMouseKeyUp\(bool, Vector2\)

```csharp
protected virtual bool OnMouseKeyUp(bool right, Vector2 position)
```

#### Parameters

`right` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_BaseView_OnMouseMove_System_Numerics_Vector2_"></a> OnMouseMove\(Vector2\)

```csharp
protected virtual bool OnMouseMove(Vector2 position)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_BaseView_OnMouseWheel_System_Boolean_System_Numerics_Vector2_"></a> OnMouseWheel\(bool, Vector2\)

```csharp
protected virtual bool OnMouseWheel(bool up, Vector2 position)
```

#### Parameters

`up` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_BaseView_OnRefresh_Divine_Menu_Views_BaseView_Divine_Menu_Views_BaseView_"></a> OnRefresh\(BaseView?, BaseView?\)

```csharp
protected virtual void OnRefresh(BaseView? prev, BaseView? next)
```

#### Parameters

`prev` [BaseView](Divine.Menu.Views.BaseView.md)?

`next` [BaseView](Divine.Menu.Views.BaseView.md)?

### <a id="Divine_Menu_Views_BaseView_OnRefresh"></a> OnRefresh\(\)

```csharp
protected virtual void OnRefresh()
```

### <a id="Divine_Menu_Views_BaseView_OnRefreshSize"></a> OnRefreshSize\(\)

```csharp
protected virtual void OnRefreshSize()
```

### <a id="Divine_Menu_Views_BaseView_OnReset"></a> OnReset\(\)

```csharp
protected virtual void OnReset()
```

### <a id="Divine_Menu_Views_BaseView_OnShow"></a> OnShow\(\)

```csharp
protected virtual void OnShow()
```

### <a id="Divine_Menu_Views_BaseView_OnShowMiniMenu_Divine_Menu_Items_MiniMenu_"></a> OnShowMiniMenu\(MiniMenu\)

```csharp
protected virtual void OnShowMiniMenu(MiniMenu miniMenu)
```

#### Parameters

`miniMenu` [MiniMenu](Divine.Menu.Items.MiniMenu.md)

### <a id="Divine_Menu_Views_BaseView_RemoveMiniMenu"></a> RemoveMiniMenu\(\)

```csharp
protected virtual void RemoveMiniMenu()
```

### <a id="Divine_Menu_Views_BaseView_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override sealed string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

