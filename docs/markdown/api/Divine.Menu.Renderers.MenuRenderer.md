# <a id="Divine_Menu_Renderers_MenuRenderer"></a> Class MenuRenderer

Namespace: [Divine.Menu.Renderers](Divine.Menu.Renderers.md)  
Assembly: Divine.dll  

```csharp
public sealed class MenuRenderer : IMenuRenderer, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuRenderer](Divine.Menu.Renderers.MenuRenderer.md)

#### Implements

[IMenuRenderer](Divine.Menu.Renderers.IMenuRenderer.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<MenuRenderer\>\(MenuRenderer, params MenuRenderer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Menu_Renderers_MenuRenderer_MenuPosition"></a> MenuPosition

```csharp
public Vector2 MenuPosition { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Menu_Renderers_MenuRenderer_MenuStaticPosition"></a> MenuStaticPosition

```csharp
public Vector2 MenuStaticPosition { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Menu_Renderers_MenuRenderer_Window"></a> Window

```csharp
public Rect Window { get; }
```

#### Property Value

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Menu_Renderers_MenuRenderer_WindowPosition"></a> WindowPosition

```csharp
public Vector2 WindowPosition { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Menu_Renderers_MenuRenderer_WindowSize"></a> WindowSize

```csharp
public Size WindowSize { get; }
```

#### Property Value

 [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

## Methods

### <a id="Divine_Menu_Renderers_MenuRenderer_Clear"></a> Clear\(\)

```csharp
public void Clear()
```

### <a id="Divine_Menu_Renderers_MenuRenderer_CreateRoundedRectangleGeometry_Divine_Renderer_Numerics_RoundedRect_"></a> CreateRoundedRectangleGeometry\(RoundedRect\)

```csharp
public ID2D1Geometry* CreateRoundedRectangleGeometry(RoundedRect rect)
```

#### Parameters

`rect` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

#### Returns

 ID2D1Geometry\*

### <a id="Divine_Menu_Renderers_MenuRenderer_CreateTextLayout_System_String_Vortice_Mathematics_Size_System_Single_Divine_Renderer_FontFlags_Divine_Renderer_FontWeight_"></a> CreateTextLayout\(string, Size, float, FontFlags, FontWeight\)

```csharp
public IDWriteTextLayout* CreateTextLayout(string text, Size size, float fontSize, FontFlags fontFlags = FontFlags.Left, FontWeight fontWeight = FontWeight.Bold)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`size` [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

`fontFlags` [FontFlags](Divine.Renderer.FontFlags.md)

`fontWeight` [FontWeight](Divine.Renderer.FontWeight.md)

#### Returns

 IDWriteTextLayout\*

### <a id="Divine_Menu_Renderers_MenuRenderer_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="Divine_Menu_Renderers_MenuRenderer_DrawBackground_Divine_Renderer_Numerics_RoundedRect_Vortice_Mathematics_Color_"></a> DrawBackground\(RoundedRect, Color\)

```csharp
public void DrawBackground(RoundedRect rect, Color color)
```

#### Parameters

`rect` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Menu_Renderers_MenuRenderer_DrawDebugRectangle_System_Boolean_Vortice_Mathematics_Rect_System_Nullable_Vortice_Mathematics_Color__"></a> DrawDebugRectangle\(bool, Rect, Color?\)

```csharp
public void DrawDebugRectangle(bool isEnabled, Rect rect, Color? color = null)
```

#### Parameters

`isEnabled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)?

### <a id="Divine_Menu_Renderers_MenuRenderer_DrawFilledRectangle_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_"></a> DrawFilledRectangle\(Rect, Color\)

```csharp
public void DrawFilledRectangle(Rect rect, Color color)
```

#### Parameters

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Menu_Renderers_MenuRenderer_DrawFilledRoundedRectangle_Divine_Renderer_Numerics_RoundedRect_Vortice_Mathematics_Color_"></a> DrawFilledRoundedRectangle\(RoundedRect, Color\)

```csharp
public void DrawFilledRoundedRectangle(RoundedRect rect, Color color)
```

#### Parameters

`rect` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Menu_Renderers_MenuRenderer_DrawImage_Divine_Menu_Components_MenuImageKey_Vortice_Mathematics_Rect_System_Single_"></a> DrawImage\(MenuImageKey, Rect, float\)

```csharp
public void DrawImage(MenuImageKey imageKey, Rect rect, float opacity = 1)
```

#### Parameters

`imageKey` [MenuImageKey](Divine.Menu.Components.MenuImageKey.md)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`opacity` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Renderers_MenuRenderer_DrawLine_System_Numerics_Vector2_System_Numerics_Vector2_Vortice_Mathematics_Color_System_Single_"></a> DrawLine\(Vector2, Vector2, Color, float\)

```csharp
public void DrawLine(Vector2 start, Vector2 end, Color color, float width)
```

#### Parameters

`start` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`end` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Renderers_MenuRenderer_DrawRoundedImage_Divine_Menu_Components_MenuImageKey_Divine_Renderer_Numerics_RoundedRect_System_Single_"></a> DrawRoundedImage\(MenuImageKey, RoundedRect, float\)

```csharp
public void DrawRoundedImage(MenuImageKey imageKey, RoundedRect rect, float opacity = 1)
```

#### Parameters

`imageKey` [MenuImageKey](Divine.Menu.Components.MenuImageKey.md)

`rect` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`opacity` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Renderers_MenuRenderer_DrawRoundedRectangle_Divine_Renderer_Numerics_RoundedRect_Vortice_Mathematics_Color_System_Single_"></a> DrawRoundedRectangle\(RoundedRect, Color, float\)

```csharp
public void DrawRoundedRectangle(RoundedRect rect, Color color, float width)
```

#### Parameters

`rect` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Renderers_MenuRenderer_DrawText_System_String_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_System_Single_Divine_Renderer_FontFlags_Divine_Renderer_FontWeight_"></a> DrawText\(string, Rect, Color, float, FontFlags, FontWeight\)

```csharp
public void DrawText(string text, Rect rect, Color color, float fontSize, FontFlags fontFlags = FontFlags.Left, FontWeight fontWeight = FontWeight.Bold)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

`fontFlags` [FontFlags](Divine.Renderer.FontFlags.md)

`fontWeight` [FontWeight](Divine.Renderer.FontWeight.md)

### <a id="Divine_Menu_Renderers_MenuRenderer_GetTextMetrics_System_String_Vortice_Mathematics_Size_System_Single_Divine_Renderer_FontWeight_"></a> GetTextMetrics\(string, Size, float, FontWeight\)

```csharp
public TextMetrics GetTextMetrics(string text, Size size, float fontSize, FontWeight fontWeight = FontWeight.Bold)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`size` [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

`fontWeight` [FontWeight](Divine.Renderer.FontWeight.md)

#### Returns

 TextMetrics

### <a id="Divine_Menu_Renderers_MenuRenderer_Invoke_System_Action_"></a> Invoke\(Action\)

```csharp
public void Invoke(Action callback)
```

#### Parameters

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

