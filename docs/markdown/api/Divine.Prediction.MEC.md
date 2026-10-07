# <a id="Divine_Prediction_MEC"></a> Class MEC

Namespace: [Divine.Prediction](Divine.Prediction.md)  
Assembly: Divine.dll  

```csharp
public static class MEC
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MEC](Divine.Prediction.MEC.md)

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

### <a id="Divine_Prediction_MEC_g_MinMaxBox"></a> g\_MinMaxBox

```csharp
public static Rect g_MinMaxBox
```

#### Field Value

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Prediction_MEC_g_MinMaxCorners"></a> g\_MinMaxCorners

```csharp
public static Vector2[] g_MinMaxCorners
```

#### Field Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\[\]

### <a id="Divine_Prediction_MEC_g_NonCulledPoints"></a> g\_NonCulledPoints

```csharp
public static Vector2[] g_NonCulledPoints
```

#### Field Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\[\]

## Methods

### <a id="Divine_Prediction_MEC_GetMec_System_Collections_Generic_List_System_Numerics_Vector2__"></a> GetMec\(List<Vector2\>\)

```csharp
public static MEC.MecCircle GetMec(List<Vector2> points)
```

#### Parameters

`points` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\>

#### Returns

 [MEC](Divine.Prediction.MEC.md).[MecCircle](Divine.Prediction.MEC.MecCircle.md)

### <a id="Divine_Prediction_MEC_MakeConvexHull_System_Collections_Generic_List_System_Numerics_Vector2__"></a> MakeConvexHull\(List<Vector2\>\)

```csharp
public static List<Vector2> MakeConvexHull(List<Vector2> points)
```

#### Parameters

`points` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\>

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\>

