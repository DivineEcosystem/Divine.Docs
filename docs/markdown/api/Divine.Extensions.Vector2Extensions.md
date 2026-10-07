# <a id="Divine_Extensions_Vector2Extensions"></a> Class Vector2Extensions

Namespace: [Divine.Extensions](Divine.Extensions.md)  
Assembly: Divine.dll  

```csharp
public static class Vector2Extensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Vector2Extensions](Divine.Extensions.Vector2Extensions.md)

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

## Methods

### <a id="Divine_Extensions_Vector2Extensions_AngleBetween_System_Numerics_Vector2_System_Numerics_Vector2_"></a> AngleBetween\(Vector2, Vector2\)

```csharp
public static float AngleBetween(this Vector2 vector2, Vector2 toVector2)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`toVector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector2Extensions_AngleBetween_System_Numerics_Vector2_System_Numerics_Vector3_"></a> AngleBetween\(Vector2, Vector3\)

```csharp
public static float AngleBetween(this Vector2 vector2, Vector3 toVector3)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`toVector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector2Extensions_AngleBetween_System_Numerics_Vector2_System_Numerics_Vector4_"></a> AngleBetween\(Vector2, Vector4\)

```csharp
public static float AngleBetween(this Vector2 vector2, Vector4 toVector4)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`toVector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector2Extensions_CircleCircleIntersection_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_System_Single_"></a> CircleCircleIntersection\(Vector2, Vector2, float, float\)

```csharp
public static Vector2[] CircleCircleIntersection(this Vector2 center1, Vector2 center2, float radius1, float radius2)
```

#### Parameters

`center1` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`center2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radius1` [float](https://learn.microsoft.com/dotnet/api/system.single)

`radius2` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\[\]

### <a id="Divine_Extensions_Vector2Extensions_Closest_System_Numerics_Vector2_System_Collections_Generic_IEnumerable_System_Numerics_Vector2__"></a> Closest\(Vector2, IEnumerable<Vector2\>\)

```csharp
public static Vector2 Closest(this Vector2 vector2, IEnumerable<Vector2> array)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`array` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\>

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Extensions_Vector2Extensions_Closest_System_Numerics_Vector2_System_Collections_Generic_IEnumerable_System_Numerics_Vector3__"></a> Closest\(Vector2, IEnumerable<Vector3\>\)

```csharp
public static Vector3 Closest(this Vector2 vector2, IEnumerable<Vector3> array)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`array` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)\>

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Extensions_Vector2Extensions_Closest_System_Numerics_Vector2_System_Collections_Generic_IEnumerable_System_Numerics_Vector4__"></a> Closest\(Vector2, IEnumerable<Vector4\>\)

```csharp
public static Vector4 Closest(this Vector2 vector2, IEnumerable<Vector4> array)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`array` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)\>

#### Returns

 [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

### <a id="Divine_Extensions_Vector2Extensions_CrossProduct_System_Numerics_Vector2_System_Numerics_Vector2_"></a> CrossProduct\(Vector2, Vector2\)

```csharp
public static float CrossProduct(this Vector2 self, Vector2 other)
```

#### Parameters

`self` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`other` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector2Extensions_Distance_System_Numerics_Vector2_System_Numerics_Vector2_"></a> Distance\(Vector2, Vector2\)

```csharp
public static float Distance(this Vector2 vector2, Vector2 toVector2)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`toVector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector2Extensions_Distance_System_Numerics_Vector2_System_Numerics_Vector3_"></a> Distance\(Vector2, Vector3\)

```csharp
public static float Distance(this Vector2 vector2, Vector3 toVector3)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`toVector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector2Extensions_Distance_System_Numerics_Vector2_System_Numerics_Vector4_"></a> Distance\(Vector2, Vector4\)

```csharp
public static float Distance(this Vector2 vector2, Vector4 toVector4)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`toVector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector2Extensions_Distance_System_Numerics_Vector2_System_Numerics_Vector2_System_Boolean_"></a> Distance\(Vector2, Vector2, bool\)

```csharp
public static float Distance(this Vector2 vector2, Vector2 to, bool squared = false)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`to` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`squared` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector2Extensions_Distance_System_Numerics_Vector2_System_Numerics_Vector3_System_Boolean_"></a> Distance\(Vector2, Vector3, bool\)

```csharp
public static float Distance(this Vector2 vector2, Vector3 to, bool squared = false)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`to` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`squared` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector2Extensions_Distance_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_System_Boolean_System_Boolean_"></a> Distance\(Vector2, Vector2, Vector2, bool, bool\)

```csharp
public static float Distance(this Vector2 vector2, Vector2 segmentStart, Vector2 segmentEnd, bool onlyIfOnSegment = false, bool squared = false)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`segmentStart` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`segmentEnd` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`onlyIfOnSegment` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`squared` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector2Extensions_DistanceSquared_System_Numerics_Vector2_System_Numerics_Vector2_"></a> DistanceSquared\(Vector2, Vector2\)

```csharp
public static float DistanceSquared(this Vector2 vector2, Vector2 toVector2)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`toVector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector2Extensions_DistanceSquared_System_Numerics_Vector2_System_Numerics_Vector3_"></a> DistanceSquared\(Vector2, Vector3\)

```csharp
public static float DistanceSquared(this Vector2 vector2, Vector3 toVector3)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`toVector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector2Extensions_DistanceSquared_System_Numerics_Vector2_System_Numerics_Vector4_"></a> DistanceSquared\(Vector2, Vector4\)

```csharp
public static float DistanceSquared(this Vector2 vector2, Vector4 toVector4)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`toVector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector2Extensions_Extend_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_"></a> Extend\(Vector2, Vector2, float\)

```csharp
public static Vector2 Extend(this Vector2 vector2, Vector2 toVector2, float distance)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`toVector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`distance` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Extensions_Vector2Extensions_Extend_System_Numerics_Vector2_System_Numerics_Vector3_System_Single_"></a> Extend\(Vector2, Vector3, float\)

```csharp
public static Vector2 Extend(this Vector2 vector2, Vector3 toVector3, float distance)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`toVector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`distance` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Extensions_Vector2Extensions_Extend_System_Numerics_Vector2_System_Numerics_Vector4_System_Single_"></a> Extend\(Vector2, Vector4, float\)

```csharp
public static Vector2 Extend(this Vector2 vector2, Vector4 toVector4, float distance)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`toVector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`distance` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Extensions_Vector2Extensions_GetPathLength_System_Collections_Generic_List_System_Numerics_Vector2__"></a> GetPathLength\(List<Vector2\>\)

```csharp
public static float GetPathLength(this List<Vector2> path)
```

#### Parameters

`path` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\>

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector2Extensions_IsInRange_System_Numerics_Vector2_Divine_Entity_Entities_Entity_System_Single_"></a> IsInRange\(Vector2, Entity, float\)

```csharp
public static bool IsInRange(this Vector2 sourcePosition, Entity target, float range)
```

#### Parameters

`sourcePosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`target` [Entity](Divine.Entity.Entities.Entity.md)

`range` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector2Extensions_IsInRange_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_"></a> IsInRange\(Vector2, Vector2, float\)

```csharp
public static bool IsInRange(this Vector2 sourcePosition, Vector2 targetPosition, float range)
```

#### Parameters

`sourcePosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`targetPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`range` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector2Extensions_IsInRange_System_Numerics_Vector2_System_Numerics_Vector3_System_Single_"></a> IsInRange\(Vector2, Vector3, float\)

```csharp
public static bool IsInRange(this Vector2 sourcePosition, Vector3 targetPosition, float range)
```

#### Parameters

`sourcePosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`targetPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`range` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector2Extensions_IsOnScreen_System_Numerics_Vector2_"></a> IsOnScreen\(Vector2\)

```csharp
public static bool IsOnScreen(this Vector2 vector2)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector2Extensions_IsOrthogonal_System_Numerics_Vector2_System_Numerics_Vector2_"></a> IsOrthogonal\(Vector2, Vector2\)

```csharp
public static bool IsOrthogonal(this Vector2 vector2, Vector2 toVector2)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`toVector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector2Extensions_IsOrthogonal_System_Numerics_Vector2_System_Numerics_Vector3_"></a> IsOrthogonal\(Vector2, Vector3\)

```csharp
public static bool IsOrthogonal(this Vector2 vector2, Vector3 toVector3)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`toVector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector2Extensions_IsOrthogonal_System_Numerics_Vector2_System_Numerics_Vector4_"></a> IsOrthogonal\(Vector2, Vector4\)

```csharp
public static bool IsOrthogonal(this Vector2 vector2, Vector4 toVector4)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`toVector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector2Extensions_IsUnderRectangle_System_Numerics_Vector2_Vortice_Mathematics_Rect_"></a> IsUnderRectangle\(Vector2, Rect\)

```csharp
public static bool IsUnderRectangle(this Vector2 position, Rect rect)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`rect` [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector2Extensions_IsUnderRectangle_System_Numerics_Vector2_System_Single_System_Single_System_Single_System_Single_"></a> IsUnderRectangle\(Vector2, float, float, float, float\)

```csharp
public static bool IsUnderRectangle(this Vector2 position, float x, float y, float width, float height)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector2Extensions_IsValid_System_Numerics_Vector2_"></a> IsValid\(Vector2\)

```csharp
public static bool IsValid(this Vector2 vector2)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector2Extensions_IsWall_System_Numerics_Vector2_"></a> IsWall\(Vector2\)

```csharp
public static bool IsWall(this Vector2 vector2)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector2Extensions_Magnitude_System_Numerics_Vector2_"></a> Magnitude\(Vector2\)

```csharp
public static float Magnitude(this Vector2 vector2)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector2Extensions_Normalized_System_Numerics_Vector2_"></a> Normalized\(Vector2\)

```csharp
public static Vector2 Normalized(this Vector2 vector2)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Extensions_Vector2Extensions_PathLength_System_Collections_Generic_List_System_Numerics_Vector2__"></a> PathLength\(List<Vector2\>\)

```csharp
public static float PathLength(this List<Vector2> path)
```

#### Parameters

`path` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\>

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector2Extensions_Perpendicular_System_Numerics_Vector2_System_Int32_"></a> Perpendicular\(Vector2, int\)

```csharp
public static Vector2 Perpendicular(this Vector2 vector2, int offset = 0)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`offset` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Extensions_Vector2Extensions_Polar_System_Numerics_Vector2_"></a> Polar\(Vector2\)

```csharp
public static float Polar(this Vector2 vector2)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector2Extensions_ProjectOn_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_"></a> ProjectOn\(Vector2, Vector2, Vector2\)

```csharp
public static Vector2Extensions.ProjectionInfo ProjectOn(this Vector2 point, Vector2 segmentStart, Vector2 segmentEnd)
```

#### Parameters

`point` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`segmentStart` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`segmentEnd` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [Vector2Extensions](Divine.Extensions.Vector2Extensions.md).[ProjectionInfo](Divine.Extensions.Vector2Extensions.ProjectionInfo.md)

### <a id="Divine_Extensions_Vector2Extensions_Rotated_System_Numerics_Vector2_System_Single_"></a> Rotated\(Vector2, float\)

```csharp
public static Vector2 Rotated(this Vector2 vector2, float angle)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`angle` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Extensions_Vector2Extensions_ToVector3_System_Numerics_Vector2_System_Single_"></a> ToVector3\(Vector2, float\)

```csharp
public static Vector3 ToVector3(this Vector2 vector2, float z = 0)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`z` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Extensions_Vector2Extensions_ToVector3_System_Collections_Generic_List_System_Numerics_Vector2__"></a> ToVector3\(List<Vector2\>\)

```csharp
public static List<Vector3> ToVector3(this List<Vector2> path)
```

#### Parameters

`path` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\>

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)\>

### <a id="Divine_Extensions_Vector2Extensions_ToVector4_System_Numerics_Vector2_System_Single_System_Single_"></a> ToVector4\(Vector2, float, float\)

```csharp
public static Vector4 ToVector4(this Vector2 vector2, float z = 0, float w = 1)
```

#### Parameters

`vector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`z` [float](https://learn.microsoft.com/dotnet/api/system.single)

`w` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

### <a id="Divine_Extensions_Vector2Extensions_ToVector4_System_Collections_Generic_List_System_Numerics_Vector2__"></a> ToVector4\(List<Vector2\>\)

```csharp
public static List<Vector4> ToVector4(this List<Vector2> path)
```

#### Parameters

`path` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\>

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)\>

