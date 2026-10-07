# <a id="Divine_Menu_Renderers_IMenuRenderer"></a> Interface IMenuRenderer

Namespace: [Divine.Menu.Renderers](Divine.Menu.Renderers.md)  
Assembly: Divine.dll  

```csharp
public interface IMenuRenderer : IDisposable
```

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<IMenuRenderer\>\(IMenuRenderer, params IMenuRenderer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Methods

### <a id="Divine_Menu_Renderers_IMenuRenderer_Clear"></a> Clear\(\)

```csharp
void Clear()
```

### <a id="Divine_Menu_Renderers_IMenuRenderer_CreateTextLayout_System_String_Vortice_Mathematics_Size_System_Single_Divine_Renderer_FontFlags_Divine_Renderer_FontWeight_"></a> CreateTextLayout\(string, Size, float, FontFlags, FontWeight\)

```csharp
IDWriteTextLayout* CreateTextLayout(string text, Size size, float fontSize, FontFlags fontFlags = FontFlags.Left, FontWeight fontWeight = FontWeight.Bold)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`size` [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

`fontFlags` [FontFlags](Divine.Renderer.FontFlags.md)

`fontWeight` [FontWeight](Divine.Renderer.FontWeight.md)

#### Returns

 IDWriteTextLayout\*

### <a id="Divine_Menu_Renderers_IMenuRenderer_DrawBackground_Divine_Renderer_Numerics_RoundedRect_Vortice_Mathematics_Color_"></a> DrawBackground\(RoundedRect, Color\)

```csharp
void DrawBackground(RoundedRect rect, Color color)
```

#### Parameters

`rect` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Menu_Renderers_IMenuRenderer_DrawFilledRectangle_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_"></a> DrawFilledRectangle\(Rect, Color\)

```csharp
void DrawFilledRectangle(Rect rect, Color color)
```

#### Parameters

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Menu_Renderers_IMenuRenderer_DrawFilledRoundedRectangle_Divine_Renderer_Numerics_RoundedRect_Vortice_Mathematics_Color_"></a> DrawFilledRoundedRectangle\(RoundedRect, Color\)

```csharp
void DrawFilledRoundedRectangle(RoundedRect rect, Color color)
```

#### Parameters

`rect` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Menu_Renderers_IMenuRenderer_DrawImage_Divine_Menu_Components_MenuImageKey_Vortice_Mathematics_Rect_System_Single_"></a> DrawImage\(MenuImageKey, Rect, float\)

```csharp
void DrawImage(MenuImageKey imageKey, Rect rect, float opacity = 1)
```

#### Parameters

`imageKey` [MenuImageKey](Divine.Menu.Components.MenuImageKey.md)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`opacity` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Renderers_IMenuRenderer_DrawLine_System_Numerics_Vector2_System_Numerics_Vector2_Vortice_Mathematics_Color_System_Single_"></a> DrawLine\(Vector2, Vector2, Color, float\)

```csharp
void DrawLine(Vector2 start, Vector2 end, Color color, float width)
```

#### Parameters

`start` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`end` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Renderers_IMenuRenderer_DrawRoundedImage_Divine_Menu_Components_MenuImageKey_Divine_Renderer_Numerics_RoundedRect_System_Single_"></a> DrawRoundedImage\(MenuImageKey, RoundedRect, float\)

```csharp
void DrawRoundedImage(MenuImageKey imageKey, RoundedRect rect, float opacity = 1)
```

#### Parameters

`imageKey` [MenuImageKey](Divine.Menu.Components.MenuImageKey.md)

`rect` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`opacity` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Renderers_IMenuRenderer_DrawText_System_String_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_System_Single_Divine_Renderer_FontFlags_Divine_Renderer_FontWeight_"></a> DrawText\(string, Rect, Color, float, FontFlags, FontWeight\)

```csharp
void DrawText(string text, Rect rect, Color color, float fontSize, FontFlags fontFlags = FontFlags.Left, FontWeight fontWeight = FontWeight.Bold)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

`fontFlags` [FontFlags](Divine.Renderer.FontFlags.md)

`fontWeight` [FontWeight](Divine.Renderer.FontWeight.md)

### <a id="Divine_Menu_Renderers_IMenuRenderer_GetTextMetrics_System_String_Vortice_Mathematics_Size_System_Single_Divine_Renderer_FontWeight_"></a> GetTextMetrics\(string, Size, float, FontWeight\)

```csharp
TextMetrics GetTextMetrics(string text, Size size, float fontSize, FontWeight fontWeight = FontWeight.Bold)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`size` [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

`fontWeight` [FontWeight](Divine.Renderer.FontWeight.md)

#### Returns

 TextMetrics

### <a id="Divine_Menu_Renderers_IMenuRenderer_Initialize_Divine_Menu_Styles_IGeneralStyle_Divine_Menu_Styles_StyleDebugger_Divine_Menu_Items_MenuContext_"></a> Initialize\(IGeneralStyle, StyleDebugger, MenuContext\)

```csharp
void Initialize(IGeneralStyle generalStyle, StyleDebugger debugger, MenuContext menuContext)
```

#### Parameters

`generalStyle` [IGeneralStyle](Divine.Menu.Styles.IGeneralStyle.md)

`debugger` [StyleDebugger](Divine.Menu.Styles.StyleDebugger.md)

`menuContext` [MenuContext](Divine.Menu.Items.MenuContext.md)

### <a id="Divine_Menu_Renderers_IMenuRenderer_OnDraw"></a> OnDraw\(\)

```csharp
void OnDraw()
```

### <a id="Divine_Menu_Renderers_IMenuRenderer_OnRender"></a> OnRender\(\)

```csharp
void OnRender()
```

