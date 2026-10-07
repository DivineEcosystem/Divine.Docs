# <a id="Divine_Numerics_Polygon"></a> Class Polygon

Namespace: [Divine.Numerics](Divine.Numerics.md)  
Assembly: Divine.dll  

```csharp
public class Polygon
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Polygon](Divine.Numerics.Polygon.md)

#### Derived

[Polygon.Circle](Divine.Numerics.Polygon.Circle.md)

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
[EnumerableExtensions.In<Polygon\>\(Polygon, params Polygon\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Fields

### <a id="Divine_Numerics_Polygon_Points"></a> Points

```csharp
public List<Vector2> Points
```

#### Field Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\>

## Methods

### <a id="Divine_Numerics_Polygon_Add_System_Numerics_Vector2_"></a> Add\(Vector2\)

```csharp
public void Add(Vector2 point)
```

#### Parameters

`point` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Numerics_Polygon_Add_System_Numerics_Vector3_"></a> Add\(Vector3\)

```csharp
public void Add(Vector3 point)
```

#### Parameters

`point` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Numerics_Polygon_Add_Divine_Numerics_Polygon_"></a> Add\(Polygon\)

```csharp
public void Add(Polygon polygon)
```

#### Parameters

`polygon` [Polygon](Divine.Numerics.Polygon.md)

### <a id="Divine_Numerics_Polygon_Draw_Vortice_Mathematics_Color_System_Int32_System_Boolean_"></a> Draw\(Color, int, bool\)

```csharp
public virtual void Draw(Color color, int width = 1, bool draw3D = false)
```

#### Parameters

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`draw3D` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Numerics_Polygon_IsInside_System_Numerics_Vector2_"></a> IsInside\(Vector2\)

```csharp
public bool IsInside(Vector2 point)
```

#### Parameters

`point` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Numerics_Polygon_IsInside_System_Numerics_Vector3_"></a> IsInside\(Vector3\)

```csharp
public bool IsInside(Vector3 point)
```

#### Parameters

`point` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Numerics_Polygon_IsInside_System_Collections_Generic_IReadOnlyList_System_Numerics_Vector2__System_Numerics_Vector2_"></a> IsInside\(IReadOnlyList<Vector2\>, Vector2\)

```csharp
public static bool IsInside(IReadOnlyList<Vector2> points, Vector2 point)
```

#### Parameters

`points` [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\>

`point` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Numerics_Polygon_IsOutside_System_Numerics_Vector2_"></a> IsOutside\(Vector2\)

```csharp
public bool IsOutside(Vector2 point)
```

#### Parameters

`point` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Numerics_Polygon_IsOutside_System_Numerics_Vector3_"></a> IsOutside\(Vector3\)

```csharp
public bool IsOutside(Vector3 point)
```

#### Parameters

`point` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

