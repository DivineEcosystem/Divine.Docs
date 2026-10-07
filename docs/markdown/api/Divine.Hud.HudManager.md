# <a id="Divine_Hud_HudManager"></a> Class HudManager

Namespace: [Divine.Hud](Divine.Hud.md)  
Assembly: Divine.dll  

```csharp
public static class HudManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[HudManager](Divine.Hud.HudManager.md)

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

## Properties

### <a id="Divine_Hud_HudManager_GlyphButton"></a> GlyphButton

```csharp
public static Rect GlyphButton { get; }
```

#### Property Value

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Hud_HudManager_IsExtraLargeMinimap"></a> IsExtraLargeMinimap

```csharp
public static bool IsExtraLargeMinimap { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Hud_HudManager_IsFlipped"></a> IsFlipped

```csharp
public static bool IsFlipped { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Hud_HudManager_Minimap"></a> Minimap

```csharp
public static Rect Minimap { get; }
```

#### Property Value

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Hud_HudManager_MinimapBounds"></a> MinimapBounds

```csharp
public static Rect MinimapBounds { get; }
```

#### Property Value

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Hud_HudManager_MinimapRenderBounds"></a> MinimapRenderBounds

```csharp
public static Rect MinimapRenderBounds { get; }
```

#### Property Value

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Hud_HudManager_RadarButton"></a> RadarButton

```csharp
public static Rect RadarButton { get; }
```

#### Property Value

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Hud_HudManager_TimeOfDay"></a> TimeOfDay

```csharp
public static Rect TimeOfDay { get; }
```

#### Property Value

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Hud_HudManager_TopBar"></a> TopBar

```csharp
public static Rect TopBar { get; }
```

#### Property Value

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Hud_HudManager_TopBarDireScore"></a> TopBarDireScore

```csharp
public static Rect TopBarDireScore { get; }
```

#### Property Value

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Hud_HudManager_TopBarDireTeam"></a> TopBarDireTeam

```csharp
public static Rect TopBarDireTeam { get; }
```

#### Property Value

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Hud_HudManager_TopBarRadiantScore"></a> TopBarRadiantScore

```csharp
public static Rect TopBarRadiantScore { get; }
```

#### Property Value

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Hud_HudManager_TopBarRadiantTeam"></a> TopBarRadiantTeam

```csharp
public static Rect TopBarRadiantTeam { get; }
```

#### Property Value

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

## Methods

### <a id="Divine_Hud_HudManager_MinimapToWorld_System_Numerics_Vector2_"></a> MinimapToWorld\(Vector2\)

```csharp
public static Vector3 MinimapToWorld(Vector2 minimapPosition)
```

#### Parameters

`minimapPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Hud_HudManager_WorldToMinimap_System_Numerics_Vector3_"></a> WorldToMinimap\(Vector3\)

```csharp
public static Vector2 WorldToMinimap(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

