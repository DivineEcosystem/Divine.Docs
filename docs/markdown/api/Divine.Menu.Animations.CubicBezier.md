# <a id="Divine_Menu_Animations_CubicBezier"></a> Class CubicBezier

Namespace: [Divine.Menu.Animations](Divine.Menu.Animations.md)  
Assembly: Divine.dll  

```csharp
public sealed class CubicBezier
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CubicBezier](Divine.Menu.Animations.CubicBezier.md)

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
[EnumerableExtensions.In<CubicBezier\>\(CubicBezier, params CubicBezier\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Menu_Animations_CubicBezier__ctor_System_Single_System_Single_System_Single_System_Single_"></a> CubicBezier\(float, float, float, float\)

```csharp
public CubicBezier(float x1, float y1, float x2, float y2)
```

#### Parameters

`x1` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y1` [float](https://learn.microsoft.com/dotnet/api/system.single)

`x2` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y2` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="Divine_Menu_Animations_CubicBezier__x1"></a> \_x1

```csharp
public float _x1
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Animations_CubicBezier__x2"></a> \_x2

```csharp
public float _x2
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Animations_CubicBezier__y1"></a> \_y1

```csharp
public float _y1
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Animations_CubicBezier__y2"></a> \_y2

```csharp
public float _y2
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Menu_Animations_CubicBezier_EaseBounce_Divine_Menu_Animations_Types_BezierFeature_System_Single_"></a> EaseBounce\(BezierFeature, float\)

```csharp
public static float EaseBounce(BezierFeature bezierFeature, float t)
```

#### Parameters

`bezierFeature` [BezierFeature](Divine.Menu.Animations.Types.BezierFeature.md)

`t` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Animations_CubicBezier_EaseInElastic_System_Single_"></a> EaseInElastic\(float\)

```csharp
public static float EaseInElastic(float t)
```

#### Parameters

`t` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Animations_CubicBezier_EaseInOutElastic_System_Single_"></a> EaseInOutElastic\(float\)

```csharp
public static float EaseInOutElastic(float t)
```

#### Parameters

`t` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Animations_CubicBezier_EaseOutBounce_System_Single_"></a> EaseOutBounce\(float\)

```csharp
public static float EaseOutBounce(float t)
```

#### Parameters

`t` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Animations_CubicBezier_EaseOutElastic_System_Single_"></a> EaseOutElastic\(float\)

```csharp
public static float EaseOutElastic(float t)
```

#### Parameters

`t` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Animations_CubicBezier_Transform_System_Single_"></a> Transform\(float\)

```csharp
public float Transform(float t)
```

#### Parameters

`t` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

