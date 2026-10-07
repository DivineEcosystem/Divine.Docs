# <a id="Divine_Renderer_RendererManager"></a> Class RendererManager

Namespace: [Divine.Renderer](Divine.Renderer.md)  
Assembly: Divine.dll  

```csharp
public static class RendererManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[RendererManager](Divine.Renderer.RendererManager.md)

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
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_)

## Fields

### <a id="Divine_Renderer_RendererManager_DefaultFontFamilyName"></a> DefaultFontFamilyName

```csharp
public const string DefaultFontFamilyName = "Calibri"
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Properties

### <a id="Divine_Renderer_RendererManager_AspectRatio"></a> AspectRatio

```csharp
public static Vector2 AspectRatio { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Renderer_RendererManager_D2D1Factory"></a> D2D1Factory

```csharp
public static ID2D1Factory7* D2D1Factory { get; }
```

#### Property Value

 ID2D1Factory7\*

### <a id="Divine_Renderer_RendererManager_D3D11BackBuffer"></a> D3D11BackBuffer

```csharp
public static ID3D11Texture2D* D3D11BackBuffer { get; }
```

#### Property Value

 ID3D11Texture2D\*

### <a id="Divine_Renderer_RendererManager_D3D11Device"></a> D3D11Device

```csharp
public static ID3D11Device5* D3D11Device { get; }
```

#### Property Value

 ID3D11Device5\*

### <a id="Divine_Renderer_RendererManager_D3D11DeviceContext"></a> D3D11DeviceContext

```csharp
public static ID3D11DeviceContext3* D3D11DeviceContext { get; }
```

#### Property Value

 ID3D11DeviceContext3\*

### <a id="Divine_Renderer_RendererManager_DeviceContext"></a> DeviceContext

```csharp
public static ID2D1DeviceContext6* DeviceContext { get; }
```

#### Property Value

 ID2D1DeviceContext6\*

### <a id="Divine_Renderer_RendererManager_DWriteFactory"></a> DWriteFactory

```csharp
public static IDWriteFactory* DWriteFactory { get; }
```

#### Property Value

 IDWriteFactory\*

### <a id="Divine_Renderer_RendererManager_Ratio"></a> Ratio

```csharp
public static float Ratio { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_RatioScaling"></a> RatioScaling

```csharp
public static Vector2 RatioScaling { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Renderer_RendererManager_Scale"></a> Scale

```csharp
public static float Scale { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_ScreenSize"></a> ScreenSize

```csharp
public static Vector2 ScreenSize { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Renderer_RendererManager_SwapChain"></a> SwapChain

```csharp
public static IDXGISwapChain* SwapChain { get; }
```

#### Property Value

 IDXGISwapChain\*

### <a id="Divine_Renderer_RendererManager_WICImagingFactory"></a> WICImagingFactory

```csharp
public static IWICImagingFactory* WICImagingFactory { get; }
```

#### Property Value

 IWICImagingFactory\*

## Methods

### <a id="Divine_Renderer_RendererManager_AddImageKey_System_String_"></a> AddImageKey\(string\)

```csharp
public static bool AddImageKey(string imageKey)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_AddImageKey_System_String_Divine_Renderer_ImageType_"></a> AddImageKey\(string, ImageType\)

```csharp
public static bool AddImageKey(string imageKey, ImageType imageType)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`imageType` [ImageType](Divine.Renderer.ImageType.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_BeginUnsafeDraw"></a> BeginUnsafeDraw\(\)

```csharp
public static void BeginUnsafeDraw()
```

### <a id="Divine_Renderer_RendererManager_Capture"></a> Capture\(\)

```csharp
public static ID2D1Bitmap* Capture()
```

#### Returns

 ID2D1Bitmap\*

### <a id="Divine_Renderer_RendererManager_CreateOrGetBrush_Vortice_Mathematics_Color_"></a> CreateOrGetBrush\(Color\)

```csharp
public static ID2D1Brush* CreateOrGetBrush(Color color)
```

#### Parameters

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

#### Returns

 ID2D1Brush\*

### <a id="Divine_Renderer_RendererManager_CreateOrGetTextFormat_System_String_Divine_Renderer_FontWeight_System_Single_"></a> CreateOrGetTextFormat\(string, FontWeight, float\)

```csharp
public static IDWriteTextFormat* CreateOrGetTextFormat(string fontFamilyName, FontWeight fontWeight, float fontSize)
```

#### Parameters

`fontFamilyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fontWeight` [FontWeight](Divine.Renderer.FontWeight.md)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 IDWriteTextFormat\*

### <a id="Divine_Renderer_RendererManager_CreateStrokeStyle_Divine_Renderer_CapStyle_Divine_Renderer_CapStyle_Divine_Renderer_CapStyle_Divine_Renderer_LineJoin_System_Single_Divine_Renderer_DashStyle_System_Single_System_Single___"></a> CreateStrokeStyle\(CapStyle, CapStyle, CapStyle, LineJoin, float, DashStyle, float, float\[\]?\)

```csharp
public static StrokeStyle CreateStrokeStyle(CapStyle startCap = CapStyle.Flat, CapStyle endCap = CapStyle.Flat, CapStyle dashCap = CapStyle.Flat, LineJoin lineJoin = LineJoin.Miter, float miterLimit = 10, DashStyle dashStyle = DashStyle.Solid, float dashOffset = 0, float[]? dashes = null)
```

#### Parameters

`startCap` [CapStyle](Divine.Renderer.CapStyle.md)

`endCap` [CapStyle](Divine.Renderer.CapStyle.md)

`dashCap` [CapStyle](Divine.Renderer.CapStyle.md)

`lineJoin` [LineJoin](Divine.Renderer.LineJoin.md)

`miterLimit` [float](https://learn.microsoft.com/dotnet/api/system.single)

`dashStyle` [DashStyle](Divine.Renderer.DashStyle.md)

`dashOffset` [float](https://learn.microsoft.com/dotnet/api/system.single)

`dashes` [float](https://learn.microsoft.com/dotnet/api/system.single)\[\]?

#### Returns

 [StrokeStyle](Divine.Renderer.StrokeStyle.md)

### <a id="Divine_Renderer_RendererManager_DrawCircle_System_Numerics_Vector2_System_Single_Vortice_Mathematics_Color_"></a> DrawCircle\(Vector2, float, Color\)

```csharp
public static void DrawCircle(Vector2 center, float radius, Color color)
```

#### Parameters

`center` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Renderer_RendererManager_DrawCircle_System_Numerics_Vector2_System_Single_Vortice_Mathematics_Color_System_Single_"></a> DrawCircle\(Vector2, float, Color, float\)

```csharp
public static void DrawCircle(Vector2 center, float radius, Color color, float width)
```

#### Parameters

`center` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawCircle_System_Numerics_Vector2_System_Single_Vortice_Mathematics_Color_System_Single_Divine_Renderer_StrokeStyle_"></a> DrawCircle\(Vector2, float, Color, float, StrokeStyle\)

```csharp
public static void DrawCircle(Vector2 center, float radius, Color color, float width, StrokeStyle strokeStyle)
```

#### Parameters

`center` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`strokeStyle` [StrokeStyle](Divine.Renderer.StrokeStyle.md)

### <a id="Divine_Renderer_RendererManager_DrawFilledRectangle_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_"></a> DrawFilledRectangle\(Rect, Color\)

```csharp
public static void DrawFilledRectangle(Rect rect, Color color)
```

#### Parameters

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Renderer_RendererManager_DrawFilledRectangle_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_Vortice_Mathematics_Color_System_Single_"></a> DrawFilledRectangle\(Rect, Color, Color, float\)

```csharp
public static void DrawFilledRectangle(Rect rect, Color color, Color backgroundColor, float borderWidth)
```

#### Parameters

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`backgroundColor` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`borderWidth` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawFilledRectangle_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_Vortice_Mathematics_Color_System_Single_Divine_Renderer_StrokeStyle_"></a> DrawFilledRectangle\(Rect, Color, Color, float, StrokeStyle\)

```csharp
public static void DrawFilledRectangle(Rect rect, Color color, Color backgroundColor, float borderWidth, StrokeStyle strokeStyle)
```

#### Parameters

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`backgroundColor` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`borderWidth` [float](https://learn.microsoft.com/dotnet/api/system.single)

`strokeStyle` [StrokeStyle](Divine.Renderer.StrokeStyle.md)

### <a id="Divine_Renderer_RendererManager_DrawFilledRoundedRectangle_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_System_Single_"></a> DrawFilledRoundedRectangle\(Rect, Color, float\)

```csharp
public static void DrawFilledRoundedRectangle(Rect rect, Color color, float radius)
```

#### Parameters

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawFilledRoundedRectangle_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_System_Numerics_Vector2_"></a> DrawFilledRoundedRectangle\(Rect, Color, Vector2\)

```csharp
public static void DrawFilledRoundedRectangle(Rect rect, Color color, Vector2 radius)
```

#### Parameters

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`radius` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Renderer_RendererManager_DrawFilledRoundedRectangle_Divine_Renderer_Numerics_RoundedRect_Vortice_Mathematics_Color_"></a> DrawFilledRoundedRectangle\(RoundedRect, Color\)

```csharp
public static void DrawFilledRoundedRectangle(RoundedRect rect, Color color)
```

#### Parameters

`rect` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Renderer_RendererManager_DrawImage_Divine_Entity_Entities_Abilities_Components_AbilityId_Vortice_Mathematics_Rect_"></a> DrawImage\(AbilityId, Rect\)

```csharp
public static void DrawImage(AbilityId abilityId, Rect rect)
```

#### Parameters

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Renderer_RendererManager_DrawImage_Divine_Entity_Entities_Abilities_Components_AbilityId_Vortice_Mathematics_Rect_System_Boolean_"></a> DrawImage\(AbilityId, Rect, bool\)

```csharp
public static void DrawImage(AbilityId abilityId, Rect rect, bool loadImage)
```

#### Parameters

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`loadImage` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_DrawImage_Divine_Entity_Entities_Abilities_Components_AbilityId_Vortice_Mathematics_Rect_System_Single_"></a> DrawImage\(AbilityId, Rect, float\)

```csharp
public static void DrawImage(AbilityId abilityId, Rect rect, float opacity)
```

#### Parameters

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`opacity` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawImage_Divine_Entity_Entities_Abilities_Components_AbilityId_Vortice_Mathematics_Rect_System_Boolean_System_Single_"></a> DrawImage\(AbilityId, Rect, bool, float\)

```csharp
public static void DrawImage(AbilityId abilityId, Rect rect, bool loadImage, float opacity)
```

#### Parameters

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`loadImage` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`opacity` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawImage_Divine_Entity_Entities_Abilities_Components_AbilityId_Vortice_Mathematics_Rect_Divine_Renderer_AbilityImageType_"></a> DrawImage\(AbilityId, Rect, AbilityImageType\)

```csharp
public static void DrawImage(AbilityId abilityId, Rect rect, AbilityImageType abilityImageType)
```

#### Parameters

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`abilityImageType` [AbilityImageType](Divine.Renderer.AbilityImageType.md)

### <a id="Divine_Renderer_RendererManager_DrawImage_Divine_Entity_Entities_Abilities_Components_AbilityId_Vortice_Mathematics_Rect_Divine_Renderer_AbilityImageType_System_Boolean_"></a> DrawImage\(AbilityId, Rect, AbilityImageType, bool\)

```csharp
public static void DrawImage(AbilityId abilityId, Rect rect, AbilityImageType abilityImageType, bool loadImage)
```

#### Parameters

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`abilityImageType` [AbilityImageType](Divine.Renderer.AbilityImageType.md)

`loadImage` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_DrawImage_Divine_Entity_Entities_Abilities_Components_AbilityId_Vortice_Mathematics_Rect_Divine_Renderer_AbilityImageType_System_Single_"></a> DrawImage\(AbilityId, Rect, AbilityImageType, float\)

```csharp
public static void DrawImage(AbilityId abilityId, Rect rect, AbilityImageType abilityImageType, float opacity)
```

#### Parameters

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`abilityImageType` [AbilityImageType](Divine.Renderer.AbilityImageType.md)

`opacity` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawImage_Divine_Entity_Entities_Abilities_Components_AbilityId_Vortice_Mathematics_Rect_Divine_Renderer_AbilityImageType_System_Boolean_System_Single_"></a> DrawImage\(AbilityId, Rect, AbilityImageType, bool, float\)

```csharp
public static void DrawImage(AbilityId abilityId, Rect rect, AbilityImageType abilityImageType, bool loadImage, float opacity)
```

#### Parameters

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`abilityImageType` [AbilityImageType](Divine.Renderer.AbilityImageType.md)

`loadImage` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`opacity` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawImage_Divine_Entity_Entities_Units_Heroes_Components_HeroId_Vortice_Mathematics_Rect_"></a> DrawImage\(HeroId, Rect\)

```csharp
public static void DrawImage(HeroId heroId, Rect rect)
```

#### Parameters

`heroId` [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Renderer_RendererManager_DrawImage_Divine_Entity_Entities_Units_Heroes_Components_HeroId_Vortice_Mathematics_Rect_System_Boolean_"></a> DrawImage\(HeroId, Rect, bool\)

```csharp
public static void DrawImage(HeroId heroId, Rect rect, bool loadImage)
```

#### Parameters

`heroId` [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`loadImage` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_DrawImage_Divine_Entity_Entities_Units_Heroes_Components_HeroId_Vortice_Mathematics_Rect_System_Single_"></a> DrawImage\(HeroId, Rect, float\)

```csharp
public static void DrawImage(HeroId heroId, Rect rect, float opacity)
```

#### Parameters

`heroId` [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`opacity` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawImage_Divine_Entity_Entities_Units_Heroes_Components_HeroId_Vortice_Mathematics_Rect_System_Boolean_System_Single_"></a> DrawImage\(HeroId, Rect, bool, float\)

```csharp
public static void DrawImage(HeroId heroId, Rect rect, bool loadImage, float opacity)
```

#### Parameters

`heroId` [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`loadImage` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`opacity` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawImage_Divine_Entity_Entities_Units_Heroes_Components_HeroId_Vortice_Mathematics_Rect_Divine_Renderer_UnitImageType_"></a> DrawImage\(HeroId, Rect, UnitImageType\)

```csharp
public static void DrawImage(HeroId heroId, Rect rect, UnitImageType unitImageType)
```

#### Parameters

`heroId` [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`unitImageType` [UnitImageType](Divine.Renderer.UnitImageType.md)

### <a id="Divine_Renderer_RendererManager_DrawImage_Divine_Entity_Entities_Units_Heroes_Components_HeroId_Vortice_Mathematics_Rect_Divine_Renderer_UnitImageType_System_Boolean_"></a> DrawImage\(HeroId, Rect, UnitImageType, bool\)

```csharp
public static void DrawImage(HeroId heroId, Rect rect, UnitImageType unitImageType, bool loadImage)
```

#### Parameters

`heroId` [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`unitImageType` [UnitImageType](Divine.Renderer.UnitImageType.md)

`loadImage` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_DrawImage_Divine_Entity_Entities_Units_Heroes_Components_HeroId_Vortice_Mathematics_Rect_Divine_Renderer_UnitImageType_System_Single_"></a> DrawImage\(HeroId, Rect, UnitImageType, float\)

```csharp
public static void DrawImage(HeroId heroId, Rect rect, UnitImageType unitImageType, float opacity)
```

#### Parameters

`heroId` [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`unitImageType` [UnitImageType](Divine.Renderer.UnitImageType.md)

`opacity` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawImage_Divine_Entity_Entities_Units_Heroes_Components_HeroId_Vortice_Mathematics_Rect_Divine_Renderer_UnitImageType_System_Boolean_System_Single_"></a> DrawImage\(HeroId, Rect, UnitImageType, bool, float\)

```csharp
public static void DrawImage(HeroId heroId, Rect rect, UnitImageType unitImageType, bool loadImage, float opacity)
```

#### Parameters

`heroId` [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`unitImageType` [UnitImageType](Divine.Renderer.UnitImageType.md)

`loadImage` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`opacity` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawImage_System_String_Vortice_Mathematics_Rect_Divine_Renderer_UnitImageType_"></a> DrawImage\(string, Rect, UnitImageType\)

```csharp
public static void DrawImage(string unitName, Rect rect, UnitImageType unitImageType)
```

#### Parameters

`unitName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`unitImageType` [UnitImageType](Divine.Renderer.UnitImageType.md)

### <a id="Divine_Renderer_RendererManager_DrawImage_System_String_Vortice_Mathematics_Rect_Divine_Renderer_UnitImageType_System_Boolean_"></a> DrawImage\(string, Rect, UnitImageType, bool\)

```csharp
public static void DrawImage(string unitName, Rect rect, UnitImageType unitImageType, bool loadImage)
```

#### Parameters

`unitName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`unitImageType` [UnitImageType](Divine.Renderer.UnitImageType.md)

`loadImage` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_DrawImage_System_String_Vortice_Mathematics_Rect_Divine_Renderer_UnitImageType_System_Single_"></a> DrawImage\(string, Rect, UnitImageType, float\)

```csharp
public static void DrawImage(string unitName, Rect rect, UnitImageType unitImageType, float opacity)
```

#### Parameters

`unitName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`unitImageType` [UnitImageType](Divine.Renderer.UnitImageType.md)

`opacity` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawImage_System_String_Vortice_Mathematics_Rect_Divine_Renderer_UnitImageType_System_Boolean_System_Single_"></a> DrawImage\(string, Rect, UnitImageType, bool, float\)

```csharp
public static void DrawImage(string unitName, Rect rect, UnitImageType unitImageType, bool loadImage, float opacity)
```

#### Parameters

`unitName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`unitImageType` [UnitImageType](Divine.Renderer.UnitImageType.md)

`loadImage` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`opacity` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawImage_System_String_Vortice_Mathematics_Rect_"></a> DrawImage\(string, Rect\)

```csharp
public static void DrawImage(string imageKey, Rect rect)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Renderer_RendererManager_DrawImage_System_String_Vortice_Mathematics_Rect_Divine_Renderer_ImageType_"></a> DrawImage\(string, Rect, ImageType\)

```csharp
public static void DrawImage(string imageKey, Rect rect, ImageType imageType)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`imageType` [ImageType](Divine.Renderer.ImageType.md)

### <a id="Divine_Renderer_RendererManager_DrawImage_System_String_Vortice_Mathematics_Rect_System_Single_"></a> DrawImage\(string, Rect, float\)

```csharp
public static void DrawImage(string imageKey, Rect rect, float opacity)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`opacity` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawImage_System_String_Vortice_Mathematics_Rect_Divine_Renderer_ImageType_System_Single_"></a> DrawImage\(string, Rect, ImageType, float\)

```csharp
public static void DrawImage(string imageKey, Rect rect, ImageType imageType, float opacity)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`imageType` [ImageType](Divine.Renderer.ImageType.md)

`opacity` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawImage_System_String_Vortice_Mathematics_Rect_Divine_Renderer_ImageType_System_Boolean_"></a> DrawImage\(string, Rect, ImageType, bool\)

```csharp
public static void DrawImage(string imageKey, Rect rect, ImageType imageType, bool loadImage)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`imageType` [ImageType](Divine.Renderer.ImageType.md)

`loadImage` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_DrawImage_System_String_Vortice_Mathematics_Rect_Divine_Renderer_ImageType_System_Boolean_System_Single_"></a> DrawImage\(string, Rect, ImageType, bool, float\)

```csharp
public static void DrawImage(string imageKey, Rect rect, ImageType imageType, bool loadImage, float opacity)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`imageType` [ImageType](Divine.Renderer.ImageType.md)

`loadImage` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`opacity` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawImage_System_String_Vortice_Mathematics_Rect_Divine_Renderer_ImageType_System_Boolean_System_Single_System_Numerics_Matrix3x2_"></a> DrawImage\(string, Rect, ImageType, bool, float, Matrix3x2\)

```csharp
public static void DrawImage(string imageKey, Rect rect, ImageType imageType, bool loadImage, float opacity, Matrix3x2 matrix)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`imageType` [ImageType](Divine.Renderer.ImageType.md)

`loadImage` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`opacity` [float](https://learn.microsoft.com/dotnet/api/system.single)

`matrix` [Matrix3x2](https://learn.microsoft.com/dotnet/api/system.numerics.matrix3x2)

### <a id="Divine_Renderer_RendererManager_DrawImage_System_String_Vortice_Mathematics_Rect_Vortice_Mathematics_Rect_"></a> DrawImage\(string, Rect, Rect\)

```csharp
public static void DrawImage(string imageKey, Rect window, Rect rect)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`window` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Renderer_RendererManager_DrawLine_System_Numerics_Vector2_System_Numerics_Vector2_Vortice_Mathematics_Color_"></a> DrawLine\(Vector2, Vector2, Color\)

```csharp
public static void DrawLine(Vector2 start, Vector2 end, Color color)
```

#### Parameters

`start` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`end` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Renderer_RendererManager_DrawLine_System_Numerics_Vector2_System_Numerics_Vector2_Vortice_Mathematics_Color_System_Single_"></a> DrawLine\(Vector2, Vector2, Color, float\)

```csharp
public static void DrawLine(Vector2 start, Vector2 end, Color color, float width)
```

#### Parameters

`start` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`end` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawLine_System_Numerics_Vector2_System_Numerics_Vector2_Vortice_Mathematics_Color_System_Single_Divine_Renderer_StrokeStyle_"></a> DrawLine\(Vector2, Vector2, Color, float, StrokeStyle\)

```csharp
public static void DrawLine(Vector2 start, Vector2 end, Color color, float width, StrokeStyle strokeStyle)
```

#### Parameters

`start` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`end` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`strokeStyle` [StrokeStyle](Divine.Renderer.StrokeStyle.md)

### <a id="Divine_Renderer_RendererManager_DrawRectangle_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_"></a> DrawRectangle\(Rect, Color\)

```csharp
public static void DrawRectangle(Rect rect, Color color)
```

#### Parameters

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Renderer_RendererManager_DrawRectangle_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_System_Single_"></a> DrawRectangle\(Rect, Color, float\)

```csharp
public static void DrawRectangle(Rect rect, Color color, float width)
```

#### Parameters

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawRectangle_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_System_Single_Divine_Renderer_StrokeStyle_"></a> DrawRectangle\(Rect, Color, float, StrokeStyle\)

```csharp
public static void DrawRectangle(Rect rect, Color color, float width, StrokeStyle strokeStyle)
```

#### Parameters

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`strokeStyle` [StrokeStyle](Divine.Renderer.StrokeStyle.md)

### <a id="Divine_Renderer_RendererManager_DrawRoundedRectangle_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_System_Numerics_Vector2_"></a> DrawRoundedRectangle\(Rect, Color, Vector2\)

```csharp
public static void DrawRoundedRectangle(Rect rect, Color color, Vector2 radius)
```

#### Parameters

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`radius` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Renderer_RendererManager_DrawRoundedRectangle_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_System_Single_System_Single_"></a> DrawRoundedRectangle\(Rect, Color, float, float\)

```csharp
public static void DrawRoundedRectangle(Rect rect, Color color, float width, float radius)
```

#### Parameters

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawRoundedRectangle_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_System_Single_System_Numerics_Vector2_"></a> DrawRoundedRectangle\(Rect, Color, float, Vector2\)

```csharp
public static void DrawRoundedRectangle(Rect rect, Color color, float width, Vector2 radius)
```

#### Parameters

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`radius` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Renderer_RendererManager_DrawRoundedRectangle_Divine_Renderer_Numerics_RoundedRect_Vortice_Mathematics_Color_System_Single_"></a> DrawRoundedRectangle\(RoundedRect, Color, float\)

```csharp
public static void DrawRoundedRectangle(RoundedRect rect, Color color, float width)
```

#### Parameters

`rect` [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawText_System_String_System_Numerics_Vector2_Vortice_Mathematics_Color_System_Single_"></a> DrawText\(string, Vector2, Color, float\)

```csharp
public static void DrawText(string text, Vector2 position, Color color, float fontSize)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawText_System_String_System_Numerics_Vector2_Vortice_Mathematics_Color_System_String_System_Single_"></a> DrawText\(string, Vector2, Color, string, float\)

```csharp
public static void DrawText(string text, Vector2 position, Color color, string fontFamilyName, float fontSize)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`fontFamilyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawText_System_String_System_Numerics_Vector2_Vortice_Mathematics_Color_System_String_Divine_Renderer_FontWeight_System_Single_"></a> DrawText\(string, Vector2, Color, string, FontWeight, float\)

```csharp
public static void DrawText(string text, Vector2 position, Color color, string fontFamilyName, FontWeight fontWeight, float fontSize)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`fontFamilyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fontWeight` [FontWeight](Divine.Renderer.FontWeight.md)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawText_System_String_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_System_Single_"></a> DrawText\(string, Rect, Color, float\)

```csharp
public static void DrawText(string text, Rect rect, Color color, float fontSize)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawText_System_String_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_Divine_Renderer_FontFlags_System_Single_"></a> DrawText\(string, Rect, Color, FontFlags, float\)

```csharp
public static void DrawText(string text, Rect rect, Color color, FontFlags fontFlags, float fontSize)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`fontFlags` [FontFlags](Divine.Renderer.FontFlags.md)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawText_System_String_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_System_String_System_Single_"></a> DrawText\(string, Rect, Color, string, float\)

```csharp
public static void DrawText(string text, Rect rect, Color color, string fontFamilyName, float fontSize)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`fontFamilyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawText_System_String_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_System_String_Divine_Renderer_FontFlags_System_Single_"></a> DrawText\(string, Rect, Color, string, FontFlags, float\)

```csharp
public static void DrawText(string text, Rect rect, Color color, string fontFamilyName, FontFlags fontFlags, float fontSize)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`fontFamilyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fontFlags` [FontFlags](Divine.Renderer.FontFlags.md)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawText_System_String_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_System_String_Divine_Renderer_FontWeight_Divine_Renderer_FontFlags_System_Single_"></a> DrawText\(string, Rect, Color, string, FontWeight, FontFlags, float\)

```csharp
public static void DrawText(string text, Rect rect, Color color, string fontFamilyName, FontWeight fontWeight, FontFlags fontFlags, float fontSize)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`fontFamilyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fontWeight` [FontWeight](Divine.Renderer.FontWeight.md)

`fontFlags` [FontFlags](Divine.Renderer.FontFlags.md)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Renderer_RendererManager_DrawText_System_String_Vortice_Mathematics_Rect_Vortice_Mathematics_Color_System_String_Divine_Renderer_FontWeight_Divine_Renderer_FontFlags_System_Single_System_Numerics_Matrix3x2_"></a> DrawText\(string, Rect, Color, string, FontWeight, FontFlags, float, Matrix3x2\)

```csharp
public static void DrawText(string text, Rect rect, Color color, string fontFamilyName, FontWeight fontWeight, FontFlags fontFlags, float fontSize, Matrix3x2 matrix)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`fontFamilyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fontWeight` [FontWeight](Divine.Renderer.FontWeight.md)

`fontFlags` [FontFlags](Divine.Renderer.FontFlags.md)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

`matrix` [Matrix3x2](https://learn.microsoft.com/dotnet/api/system.numerics.matrix3x2)

### <a id="Divine_Renderer_RendererManager_ForceLoadImage_System_String_System_IO_Stream_"></a> ForceLoadImage\(string, Stream\)

```csharp
public static bool ForceLoadImage(string imageKey, Stream stream)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_ForceLoadImage_System_String_System_Byte___"></a> ForceLoadImage\(string, byte\[\]\)

```csharp
public static bool ForceLoadImage(string imageKey, byte[] buffer)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`buffer` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_GetImage_System_String_"></a> GetImage\(string\)

```csharp
public static ID2D1Bitmap* GetImage(string imageKey)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 ID2D1Bitmap\*

### <a id="Divine_Renderer_RendererManager_GetImage_System_String_Divine_Renderer_ImageType_"></a> GetImage\(string, ImageType\)

```csharp
public static ID2D1Bitmap* GetImage(string imageKey, ImageType imageType)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`imageType` [ImageType](Divine.Renderer.ImageType.md)

#### Returns

 ID2D1Bitmap\*

### <a id="Divine_Renderer_RendererManager_GetImage_System_String_System_Action_System_IntPtr__Divine_Renderer_ImageType_"></a> GetImage\(string, Action<nint\>, ImageType\)

```csharp
public static void GetImage(string imageKey, Action<nint> action, ImageType imageType = ImageType.Default)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`action` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[nint](https://learn.microsoft.com/dotnet/api/system.intptr)\>

`imageType` [ImageType](Divine.Renderer.ImageType.md)

### <a id="Divine_Renderer_RendererManager_GetImageAsync_System_String_Divine_Renderer_ImageType_"></a> GetImageAsync\(string, ImageType\)

```csharp
public static Task<nint> GetImageAsync(string imageKey, ImageType imageType = ImageType.Default)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`imageType` [ImageType](Divine.Renderer.ImageType.md)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[nint](https://learn.microsoft.com/dotnet/api/system.intptr)\>

### <a id="Divine_Renderer_RendererManager_HasImage_System_String_"></a> HasImage\(string\)

```csharp
public static bool HasImage(string imageKey)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_HasImage_System_String_Divine_Renderer_ImageType_"></a> HasImage\(string, ImageType\)

```csharp
public static bool HasImage(string imageKey, ImageType imageType)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`imageType` [ImageType](Divine.Renderer.ImageType.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_Invoke_System_Action_"></a> Invoke\(Action\)

```csharp
public static void Invoke(Action callback)
```

#### Parameters

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

### <a id="Divine_Renderer_RendererManager_IsImageLoading_System_String_Divine_Renderer_ImageType_"></a> IsImageLoading\(string, ImageType\)

```csharp
public static bool IsImageLoading(string imageKey, ImageType imageType = ImageType.Default)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`imageType` [ImageType](Divine.Renderer.ImageType.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadFont_System_IO_Stream_"></a> LoadFont\(Stream\)

```csharp
public static bool LoadFont(Stream stream)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadFont_System_Byte___"></a> LoadFont\(byte\[\]\)

```csharp
public static bool LoadFont(byte[] buffer)
```

#### Parameters

`buffer` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImage_Divine_Entity_Entities_Abilities_Components_AbilityId_"></a> LoadImage\(AbilityId\)

```csharp
public static bool LoadImage(AbilityId abilityId)
```

#### Parameters

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImage_Divine_Entity_Entities_Abilities_Components_AbilityId_Divine_Renderer_AbilityImageType_"></a> LoadImage\(AbilityId, AbilityImageType\)

```csharp
public static bool LoadImage(AbilityId abilityId, AbilityImageType abilityImageType)
```

#### Parameters

`abilityId` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

`abilityImageType` [AbilityImageType](Divine.Renderer.AbilityImageType.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImage_Divine_Entity_Entities_Units_Heroes_Components_HeroId_"></a> LoadImage\(HeroId\)

```csharp
public static bool LoadImage(HeroId heroId)
```

#### Parameters

`heroId` [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImage_Divine_Entity_Entities_Units_Heroes_Components_HeroId_Divine_Renderer_UnitImageType_"></a> LoadImage\(HeroId, UnitImageType\)

```csharp
public static bool LoadImage(HeroId heroId, UnitImageType unitImageType)
```

#### Parameters

`heroId` [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)

`unitImageType` [UnitImageType](Divine.Renderer.UnitImageType.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImage_System_String_Divine_Renderer_UnitImageType_"></a> LoadImage\(string, UnitImageType\)

```csharp
public static bool LoadImage(string unitName, UnitImageType unitImageType)
```

#### Parameters

`unitName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`unitImageType` [UnitImageType](Divine.Renderer.UnitImageType.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImage_System_String_"></a> LoadImage\(string\)

```csharp
public static bool LoadImage(string imageKey)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImage_System_String_System_String_"></a> LoadImage\(string, string\)

```csharp
public static bool LoadImage(string imageKey, string fileName)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImage_System_String_Divine_Renderer_ImageType_"></a> LoadImage\(string, ImageType\)

```csharp
public static bool LoadImage(string imageKey, ImageType imageType)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`imageType` [ImageType](Divine.Renderer.ImageType.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImage_System_String_System_String_Divine_Renderer_ImageType_"></a> LoadImage\(string, string, ImageType\)

```csharp
public static bool LoadImage(string imageKey, string fileName, ImageType imageType)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`imageType` [ImageType](Divine.Renderer.ImageType.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImage_System_String_System_String_Divine_Renderer_ImageProperties_"></a> LoadImage\(string, string, ImageProperties\)

```csharp
public static bool LoadImage(string imageKey, string fileName, ImageProperties imageProperties)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`imageProperties` [ImageProperties](Divine.Renderer.ImageProperties.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImage_System_String_System_String_Divine_Renderer_ImageProperties_Divine_Renderer_ImageType_"></a> LoadImage\(string, string, ImageProperties, ImageType\)

```csharp
public static bool LoadImage(string imageKey, string fileName, ImageProperties imageProperties, ImageType imageType)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`imageProperties` [ImageProperties](Divine.Renderer.ImageProperties.md)

`imageType` [ImageType](Divine.Renderer.ImageType.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImage_System_String_System_IO_Stream_System_Nullable_Divine_Renderer_ImageProperties__"></a> LoadImage\(string, Stream, ImageProperties?\)

```csharp
public static bool LoadImage(string imageKey, Stream stream, ImageProperties? imageProperties = null)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

`imageProperties` [ImageProperties](Divine.Renderer.ImageProperties.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImage_System_String_System_Byte___System_Nullable_Divine_Renderer_ImageProperties__"></a> LoadImage\(string, byte\[\], ImageProperties?\)

```csharp
public static bool LoadImage(string imageKey, byte[] buffer, ImageProperties? imageProperties = null)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`buffer` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

`imageProperties` [ImageProperties](Divine.Renderer.ImageProperties.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImageFromAssembly_System_String_System_String_"></a> LoadImageFromAssembly\(string, string\)

```csharp
public static bool LoadImageFromAssembly(string imageKey, string name)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImageFromAssembly_System_String_Divine_Renderer_ImageProperties_"></a> LoadImageFromAssembly\(string, ImageProperties\)

```csharp
public static bool LoadImageFromAssembly(string imageKey, ImageProperties imageProperties)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`imageProperties` [ImageProperties](Divine.Renderer.ImageProperties.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImageFromAssembly_System_String_System_String_Divine_Renderer_ImageProperties_"></a> LoadImageFromAssembly\(string, string, ImageProperties\)

```csharp
public static bool LoadImageFromAssembly(string imageKey, string name, ImageProperties imageProperties)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`imageProperties` [ImageProperties](Divine.Renderer.ImageProperties.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImageFromAssembly_System_String_System_String_System_Reflection_Assembly_System_Nullable_Divine_Renderer_ImageProperties__"></a> LoadImageFromAssembly\(string, string?, Assembly?, ImageProperties?\)

```csharp
public static bool LoadImageFromAssembly(string imageKey, string? name = null, Assembly? assembly = null, ImageProperties? imageProperties = null)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`assembly` [Assembly](https://learn.microsoft.com/dotnet/api/system.reflection.assembly)?

`imageProperties` [ImageProperties](Divine.Renderer.ImageProperties.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImageFromBitmap_System_String_SkiaSharp_SKBitmap_System_Nullable_Divine_Renderer_ImageProperties__"></a> LoadImageFromBitmap\(string, SKBitmap, ImageProperties?\)

```csharp
public static bool LoadImageFromBitmap(string imageKey, SKBitmap bitmap, ImageProperties? imageProperties = null)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`bitmap` [SKBitmap](https://learn.microsoft.com/dotnet/api/skiasharp.skbitmap)

`imageProperties` [ImageProperties](Divine.Renderer.ImageProperties.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImageFromFile_System_String_System_String_System_Nullable_Divine_Renderer_ImageProperties__"></a> LoadImageFromFile\(string, string, ImageProperties?\)

```csharp
public static bool LoadImageFromFile(string imageKey, string file, ImageProperties? imageProperties = null)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`file` [string](https://learn.microsoft.com/dotnet/api/system.string)

`imageProperties` [ImageProperties](Divine.Renderer.ImageProperties.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_LoadImageFromResources_System_String_System_String_System_Nullable_Divine_Renderer_ImageProperties__"></a> LoadImageFromResources\(string, string?, ImageProperties?\)

```csharp
public static bool LoadImageFromResources(string imageKey, string? fileName = null, ImageProperties? imageProperties = null)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`imageProperties` [ImageProperties](Divine.Renderer.ImageProperties.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_MeasureText_System_String_System_Single_"></a> MeasureText\(string, float\)

```csharp
public static Vector2 MeasureText(string text, float fontSize)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Renderer_RendererManager_MeasureText_System_String_System_String_System_Single_"></a> MeasureText\(string, string, float\)

```csharp
public static Vector2 MeasureText(string text, string fontFamilyName, float fontSize)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fontFamilyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Renderer_RendererManager_MeasureText_System_String_System_String_Divine_Renderer_FontWeight_System_Single_"></a> MeasureText\(string, string, FontWeight, float\)

```csharp
public static Vector2 MeasureText(string text, string fontFamilyName, FontWeight fontWeight, float fontSize)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fontFamilyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fontWeight` [FontWeight](Divine.Renderer.FontWeight.md)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Renderer_RendererManager_RemoveImage_System_String_"></a> RemoveImage\(string\)

```csharp
public static bool RemoveImage(string imageKey)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_RemoveImage_System_String_Divine_Renderer_ImageType_"></a> RemoveImage\(string, ImageType\)

```csharp
public static bool RemoveImage(string imageKey, ImageType imageType)
```

#### Parameters

`imageKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`imageType` [ImageType](Divine.Renderer.ImageType.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Renderer_RendererManager_WorldToScreen_System_Numerics_Vector3_System_Boolean_"></a> WorldToScreen\(Vector3, bool\)

```csharp
public static Vector2 WorldToScreen(Vector3 position, bool inScreen)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`inScreen` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Renderer_RendererManager_WorldToScreen_System_Numerics_Vector3_"></a> WorldToScreen\(Vector3\)

```csharp
public static Vector2 WorldToScreen(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Renderer_RendererManager_Draw"></a> Draw

```csharp
public static event RendererManager.DrawEventHandler? Draw
```

#### Event Type

 [RendererManager](Divine.Renderer.RendererManager.md).[DrawEventHandler](Divine.Renderer.RendererManager.DrawEventHandler.md)?

### <a id="Divine_Renderer_RendererManager_Present"></a> Present

```csharp
public static event RendererManager.PresentEventHandler? Present
```

#### Event Type

 [RendererManager](Divine.Renderer.RendererManager.md).[PresentEventHandler](Divine.Renderer.RendererManager.PresentEventHandler.md)?

### <a id="Divine_Renderer_RendererManager_PresentMenu"></a> PresentMenu

```csharp
public static event RendererManager.PresentEventHandler? PresentMenu
```

#### Event Type

 [RendererManager](Divine.Renderer.RendererManager.md).[PresentEventHandler](Divine.Renderer.RendererManager.PresentEventHandler.md)?

