# <a id="Divine_Menu_Animations_Animation_1"></a> Class Animation<T\>

Namespace: [Divine.Menu.Animations](Divine.Menu.Animations.md)  
Assembly: Divine.dll  

```csharp
public sealed class Animation<T> where T : struct
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Animation<T\>](Divine.Menu.Animations.Animation\-1.md)

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
[EnumerableExtensions.In<Animation<T\>\>\(Animation<T\>, params Animation<T\>\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Menu_Animations_Animation_1_Destination"></a> Destination

```csharp
public T Destination { get; set; }
```

#### Property Value

 T

### <a id="Divine_Menu_Animations_Animation_1_Initial"></a> Initial

```csharp
public T Initial { get; set; }
```

#### Property Value

 T

### <a id="Divine_Menu_Animations_Animation_1_IsFinished"></a> IsFinished

```csharp
public bool IsFinished { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Animations_Animation_1_IsFinishedReverse"></a> IsFinishedReverse

```csharp
public bool IsFinishedReverse { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Animations_Animation_1_IsStarted"></a> IsStarted

```csharp
public bool IsStarted { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Animations_Animation_1_IsStartedReverse"></a> IsStartedReverse

```csharp
public bool IsStartedReverse { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Animations_Animation_1_Progress"></a> Progress

```csharp
public float Progress { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Menu_Animations_Animation_1_Backward_Divine_Menu_Animations_CubicBezier_System_Single_System_Single_System_Boolean_"></a> Backward\(CubicBezier, float, float, bool\)

```csharp
public void Backward(CubicBezier cubicBezier, float duration = 1000, float delay = 0, bool needToMirror = false)
```

#### Parameters

`cubicBezier` [CubicBezier](Divine.Menu.Animations.CubicBezier.md)

`duration` [float](https://learn.microsoft.com/dotnet/api/system.single)

`delay` [float](https://learn.microsoft.com/dotnet/api/system.single)

`needToMirror` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Animations_Animation_1_Backward_Divine_Menu_Animations_Types_BezierInOut_System_Single_System_Single_"></a> Backward\(BezierInOut, float, float\)

```csharp
public void Backward(BezierInOut bezierInOut, float duration = 1000, float delay = 0)
```

#### Parameters

`bezierInOut` [BezierInOut](Divine.Menu.Animations.Types.BezierInOut.md)

`duration` [float](https://learn.microsoft.com/dotnet/api/system.single)

`delay` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Animations_Animation_1_Backward_Divine_Menu_Animations_Types_BezierIn_System_Single_System_Single_"></a> Backward\(BezierIn, float, float\)

```csharp
public void Backward(BezierIn bezierIn, float duration = 1000, float delay = 0)
```

#### Parameters

`bezierIn` [BezierIn](Divine.Menu.Animations.Types.BezierIn.md)

`duration` [float](https://learn.microsoft.com/dotnet/api/system.single)

`delay` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Animations_Animation_1_Backward_Divine_Menu_Animations_Types_BezierOut_System_Single_System_Single_"></a> Backward\(BezierOut, float, float\)

```csharp
public void Backward(BezierOut bezierOut, float duration = 1000, float delay = 0)
```

#### Parameters

`bezierOut` [BezierOut](Divine.Menu.Animations.Types.BezierOut.md)

`duration` [float](https://learn.microsoft.com/dotnet/api/system.single)

`delay` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Animations_Animation_1_Backward_Divine_Menu_Animations_Types_BezierFeature_System_Single_System_Single_"></a> Backward\(BezierFeature, float, float\)

```csharp
public void Backward(BezierFeature bezierFeature, float duration = 1000, float delay = 0)
```

#### Parameters

`bezierFeature` [BezierFeature](Divine.Menu.Animations.Types.BezierFeature.md)

`duration` [float](https://learn.microsoft.com/dotnet/api/system.single)

`delay` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Animations_Animation_1_Forward_Divine_Menu_Animations_CubicBezier_System_Single_System_Single_System_Boolean_"></a> Forward\(CubicBezier, float, float, bool\)

```csharp
public void Forward(CubicBezier cubicBezier, float duration = 1000, float delay = 0, bool needToMirror = false)
```

#### Parameters

`cubicBezier` [CubicBezier](Divine.Menu.Animations.CubicBezier.md)

`duration` [float](https://learn.microsoft.com/dotnet/api/system.single)

`delay` [float](https://learn.microsoft.com/dotnet/api/system.single)

`needToMirror` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Animations_Animation_1_Forward_Divine_Menu_Animations_Types_BezierInOut_System_Single_System_Single_"></a> Forward\(BezierInOut, float, float\)

```csharp
public void Forward(BezierInOut bezierInOut, float duration = 1000, float delay = 0)
```

#### Parameters

`bezierInOut` [BezierInOut](Divine.Menu.Animations.Types.BezierInOut.md)

`duration` [float](https://learn.microsoft.com/dotnet/api/system.single)

`delay` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Animations_Animation_1_Forward_Divine_Menu_Animations_Types_BezierIn_System_Single_System_Single_"></a> Forward\(BezierIn, float, float\)

```csharp
public void Forward(BezierIn bezierIn, float duration = 1000, float delay = 0)
```

#### Parameters

`bezierIn` [BezierIn](Divine.Menu.Animations.Types.BezierIn.md)

`duration` [float](https://learn.microsoft.com/dotnet/api/system.single)

`delay` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Animations_Animation_1_Forward_Divine_Menu_Animations_Types_BezierOut_System_Single_System_Single_"></a> Forward\(BezierOut, float, float\)

```csharp
public void Forward(BezierOut bezierOut, float duration = 1000, float delay = 0)
```

#### Parameters

`bezierOut` [BezierOut](Divine.Menu.Animations.Types.BezierOut.md)

`duration` [float](https://learn.microsoft.com/dotnet/api/system.single)

`delay` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Animations_Animation_1_Forward_Divine_Menu_Animations_Types_BezierFeature_System_Single_System_Single_"></a> Forward\(BezierFeature, float, float\)

```csharp
public void Forward(BezierFeature bezierFeature, float duration = 1000, float delay = 0)
```

#### Parameters

`bezierFeature` [BezierFeature](Divine.Menu.Animations.Types.BezierFeature.md)

`duration` [float](https://learn.microsoft.com/dotnet/api/system.single)

`delay` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Animations_Animation_1_GetValue"></a> GetValue\(\)

```csharp
public float GetValue()
```

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Animations_Animation_1_Reset"></a> Reset\(\)

```csharp
public void Reset()
```

