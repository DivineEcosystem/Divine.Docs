# <a id="Divine_Menu_Views_IView"></a> Interface IView

Namespace: [Divine.Menu.Views](Divine.Menu.Views.md)  
Assembly: Divine.dll  

```csharp
public interface IView
```

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<IView\>\(IView, params IView\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Menu_Views_IView_Bottom"></a> Bottom

```csharp
float Bottom { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Views_IView_BottomLeft"></a> BottomLeft

```csharp
Vector2 BottomLeft { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Menu_Views_IView_BottomRight"></a> BottomRight

```csharp
Vector2 BottomRight { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Menu_Views_IView_CanVisible"></a> CanVisible

```csharp
bool CanVisible { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_IView_Context"></a> Context

```csharp
IContextView Context { get; }
```

#### Property Value

 [IContextView](Divine.Menu.Views.IContextView.md)

### <a id="Divine_Menu_Views_IView_ContextPosition"></a> ContextPosition

```csharp
Vector2 ContextPosition { get; set; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Menu_Views_IView_ContextStyle"></a> ContextStyle

```csharp
IContextStyle ContextStyle { get; }
```

#### Property Value

 [IContextStyle](Divine.Menu.Styles.IContextStyle.md)

### <a id="Divine_Menu_Views_IView_Flags"></a> Flags

```csharp
MenuFlags Flags { get; }
```

#### Property Value

 [MenuFlags](Divine.Menu.Components.MenuFlags.md)

### <a id="Divine_Menu_Views_IView_GeneralStyle"></a> GeneralStyle

```csharp
IStyle GeneralStyle { get; }
```

#### Property Value

 [IStyle](Divine.Menu.Styles.IStyle.md)

### <a id="Divine_Menu_Views_IView_Height"></a> Height

```csharp
float Height { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Views_IView_ImageKey"></a> ImageKey

```csharp
MenuImageKey? ImageKey { get; }
```

#### Property Value

 [MenuImageKey](Divine.Menu.Components.MenuImageKey.md)?

### <a id="Divine_Menu_Views_IView_ImageRectangle"></a> ImageRectangle

```csharp
RoundedRect ImageRectangle { get; }
```

#### Property Value

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Menu_Views_IView_IsDisabled"></a> IsDisabled

```csharp
bool IsDisabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_IView_IsHovered"></a> IsHovered

```csharp
bool IsHovered { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_IView_IsRoot"></a> IsRoot

```csharp
bool IsRoot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_IView_IsSelected"></a> IsSelected

```csharp
bool IsSelected { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_IView_IsVisible"></a> IsVisible

```csharp
bool IsVisible { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_IView_Left"></a> Left

```csharp
float Left { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Views_IView_Linked"></a> Linked

```csharp
MenuItem Linked { get; }
```

#### Property Value

 [MenuItem](Divine.Menu.Items.MenuItem.md)

### <a id="Divine_Menu_Views_IView_Next"></a> Next

```csharp
IView? Next { get; }
```

#### Property Value

 [IView](Divine.Menu.Views.IView.md)?

### <a id="Divine_Menu_Views_IView_Owner"></a> Owner

```csharp
MenuItem Owner { get; }
```

#### Property Value

 [MenuItem](Divine.Menu.Items.MenuItem.md)

### <a id="Divine_Menu_Views_IView_Parent"></a> Parent

```csharp
IView? Parent { get; }
```

#### Property Value

 [IView](Divine.Menu.Views.IView.md)?

### <a id="Divine_Menu_Views_IView_Position"></a> Position

```csharp
Vector2 Position { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Menu_Views_IView_Prev"></a> Prev

```csharp
IView? Prev { get; }
```

#### Property Value

 [IView](Divine.Menu.Views.IView.md)?

### <a id="Divine_Menu_Views_IView_Rectangle"></a> Rectangle

```csharp
RoundedRect Rectangle { get; }
```

#### Property Value

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Menu_Views_IView_Renderer"></a> Renderer

```csharp
IMenuRenderer Renderer { get; }
```

#### Property Value

 [IMenuRenderer](Divine.Menu.Renderers.IMenuRenderer.md)

### <a id="Divine_Menu_Views_IView_Right"></a> Right

```csharp
float Right { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Views_IView_Size"></a> Size

```csharp
Size Size { get; }
```

#### Property Value

 [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

### <a id="Divine_Menu_Views_IView_Style"></a> Style

```csharp
IStyle Style { get; }
```

#### Property Value

 [IStyle](Divine.Menu.Styles.IStyle.md)

### <a id="Divine_Menu_Views_IView_Tooltip"></a> Tooltip

```csharp
string? Tooltip { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Divine_Menu_Views_IView_Top"></a> Top

```csharp
float Top { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Views_IView_TopLeft"></a> TopLeft

```csharp
Vector2 TopLeft { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Menu_Views_IView_TopRight"></a> TopRight

```csharp
Vector2 TopRight { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Menu_Views_IView_Width"></a> Width

```csharp
float Width { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

