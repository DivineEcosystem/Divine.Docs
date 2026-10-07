# <a id="Divine_Numerics_Polygon_Circle"></a> Class Polygon.Circle

Namespace: [Divine.Numerics](Divine.Numerics.md)  
Assembly: Divine.dll  

```csharp
public class Polygon.Circle : Polygon
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Polygon](Divine.Numerics.Polygon.md) ← 
[Polygon.Circle](Divine.Numerics.Polygon.Circle.md)

#### Inherited Members

[Polygon.Points](Divine.Numerics.Polygon.md\#Divine\_Numerics\_Polygon\_Points), 
[Polygon.Add\(Vector2\)](Divine.Numerics.Polygon.md\#Divine\_Numerics\_Polygon\_Add\_System\_Numerics\_Vector2\_), 
[Polygon.Add\(Vector3\)](Divine.Numerics.Polygon.md\#Divine\_Numerics\_Polygon\_Add\_System\_Numerics\_Vector3\_), 
[Polygon.Add\(Polygon\)](Divine.Numerics.Polygon.md\#Divine\_Numerics\_Polygon\_Add\_Divine\_Numerics\_Polygon\_), 
[Polygon.Draw\(Color, int, bool\)](Divine.Numerics.Polygon.md\#Divine\_Numerics\_Polygon\_Draw\_Vortice\_Mathematics\_Color\_System\_Int32\_System\_Boolean\_), 
[Polygon.IsInside\(Vector2\)](Divine.Numerics.Polygon.md\#Divine\_Numerics\_Polygon\_IsInside\_System\_Numerics\_Vector2\_), 
[Polygon.IsInside\(Vector3\)](Divine.Numerics.Polygon.md\#Divine\_Numerics\_Polygon\_IsInside\_System\_Numerics\_Vector3\_), 
[Polygon.IsOutside\(Vector2\)](Divine.Numerics.Polygon.md\#Divine\_Numerics\_Polygon\_IsOutside\_System\_Numerics\_Vector2\_), 
[Polygon.IsOutside\(Vector3\)](Divine.Numerics.Polygon.md\#Divine\_Numerics\_Polygon\_IsOutside\_System\_Numerics\_Vector3\_), 
[Polygon.IsInside\(IReadOnlyList<Vector2\>, Vector2\)](Divine.Numerics.Polygon.md\#Divine\_Numerics\_Polygon\_IsInside\_System\_Collections\_Generic\_IReadOnlyList\_System\_Numerics\_Vector2\_\_System\_Numerics\_Vector2\_), 
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
[EnumerableExtensions.In<Polygon.Circle\>\(Polygon.Circle, params Polygon.Circle\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Numerics_Polygon_Circle__ctor_System_Numerics_Vector3_System_Single_System_Int32_"></a> Circle\(Vector3, float, int\)

```csharp
public Circle(Vector3 center, float radius, int quality = 20)
```

#### Parameters

`center` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`quality` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Numerics_Polygon_Circle__ctor_System_Numerics_Vector2_System_Single_System_Int32_"></a> Circle\(Vector2, float, int\)

```csharp
public Circle(Vector2 center, float radius, int quality = 20)
```

#### Parameters

`center` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`quality` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Fields

### <a id="Divine_Numerics_Polygon_Circle_Center"></a> Center

```csharp
public Vector2 Center
```

#### Field Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Numerics_Polygon_Circle_Radius"></a> Radius

```csharp
public float Radius
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Numerics_Polygon_Circle_UpdatePolygon_System_Int32_System_Single_"></a> UpdatePolygon\(int, float\)

```csharp
public void UpdatePolygon(int offset = 0, float overrideWidth = -1)
```

#### Parameters

`offset` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`overrideWidth` [float](https://learn.microsoft.com/dotnet/api/system.single)

