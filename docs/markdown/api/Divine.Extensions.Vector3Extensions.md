# <a id="Divine_Extensions_Vector3Extensions"></a> Class Vector3Extensions

Namespace: [Divine.Extensions](Divine.Extensions.md)  
Assembly: Divine.dll  

```csharp
public static class Vector3Extensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Vector3Extensions](Divine.Extensions.Vector3Extensions.md)

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

### <a id="Divine_Extensions_Vector3Extensions_AngleBetween_System_Numerics_Vector3_System_Numerics_Vector3_"></a> AngleBetween\(Vector3, Vector3\)

```csharp
public static float AngleBetween(this Vector3 vector3, Vector3 toVector3)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`toVector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector3Extensions_AngleBetween_System_Numerics_Vector3_System_Numerics_Vector2_"></a> AngleBetween\(Vector3, Vector2\)

```csharp
public static float AngleBetween(this Vector3 vector3, Vector2 toVector2)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`toVector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector3Extensions_AngleBetween_System_Numerics_Vector3_System_Numerics_Vector4_"></a> AngleBetween\(Vector3, Vector4\)

```csharp
public static float AngleBetween(this Vector3 vector3, Vector4 toVector4)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`toVector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector3Extensions_Closest_System_Numerics_Vector3_System_Collections_Generic_IEnumerable_System_Numerics_Vector3__"></a> Closest\(Vector3, IEnumerable<Vector3\>\)

```csharp
public static Vector3 Closest(this Vector3 vector3, IEnumerable<Vector3> array)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`array` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)\>

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Extensions_Vector3Extensions_Closest_System_Numerics_Vector3_System_Collections_Generic_IEnumerable_System_Numerics_Vector2__"></a> Closest\(Vector3, IEnumerable<Vector2\>\)

```csharp
public static Vector2 Closest(this Vector3 vector3, IEnumerable<Vector2> array)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`array` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\>

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Extensions_Vector3Extensions_Closest_System_Numerics_Vector3_System_Collections_Generic_IEnumerable_System_Numerics_Vector4__"></a> Closest\(Vector3, IEnumerable<Vector4\>\)

```csharp
public static Vector4 Closest(this Vector3 vector3, IEnumerable<Vector4> array)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`array` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)\>

#### Returns

 [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

### <a id="Divine_Extensions_Vector3Extensions_Distance_System_Numerics_Vector3_System_Numerics_Vector3_"></a> Distance\(Vector3, Vector3\)

```csharp
public static float Distance(this Vector3 vector3, Vector3 toVector3)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`toVector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector3Extensions_Distance_System_Numerics_Vector3_System_Numerics_Vector2_"></a> Distance\(Vector3, Vector2\)

```csharp
public static float Distance(this Vector3 vector3, Vector2 toVector2)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`toVector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector3Extensions_Distance_System_Numerics_Vector3_System_Numerics_Vector4_"></a> Distance\(Vector3, Vector4\)

```csharp
public static float Distance(this Vector3 vector3, Vector4 toVector4)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`toVector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector3Extensions_Distance2D_System_Numerics_Vector3_System_Numerics_Vector3_"></a> Distance2D\(Vector3, Vector3\)

```csharp
public static float Distance2D(this Vector3 vector3, Vector3 toVector3)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`toVector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector3Extensions_Distance2D_System_Numerics_Vector3_System_Numerics_Vector2_"></a> Distance2D\(Vector3, Vector2\)

```csharp
public static float Distance2D(this Vector3 vector3, Vector2 toVector2)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`toVector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector3Extensions_Distance2D_System_Numerics_Vector3_System_Numerics_Vector4_"></a> Distance2D\(Vector3, Vector4\)

```csharp
public static float Distance2D(this Vector3 vector3, Vector4 toVector4)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`toVector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector3Extensions_DistanceSquared_System_Numerics_Vector3_System_Numerics_Vector3_"></a> DistanceSquared\(Vector3, Vector3\)

```csharp
public static float DistanceSquared(this Vector3 vector3, Vector3 toVector3)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`toVector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector3Extensions_DistanceSquared_System_Numerics_Vector3_System_Numerics_Vector2_"></a> DistanceSquared\(Vector3, Vector2\)

```csharp
public static float DistanceSquared(this Vector3 vector3, Vector2 toVector2)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`toVector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector3Extensions_DistanceSquared_System_Numerics_Vector3_System_Numerics_Vector4_"></a> DistanceSquared\(Vector3, Vector4\)

```csharp
public static float DistanceSquared(this Vector3 vector3, Vector4 toVector4)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`toVector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector3Extensions_Extend_System_Numerics_Vector3_System_Numerics_Vector3_System_Single_"></a> Extend\(Vector3, Vector3, float\)

```csharp
public static Vector3 Extend(this Vector3 vector3, Vector3 toVector3, float distance)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`toVector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`distance` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Extensions_Vector3Extensions_Extend_System_Numerics_Vector3_System_Numerics_Vector2_System_Single_"></a> Extend\(Vector3, Vector2, float\)

```csharp
public static Vector3 Extend(this Vector3 vector3, Vector2 toVector2, float distance)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`toVector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`distance` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Extensions_Vector3Extensions_Extend_System_Numerics_Vector3_System_Numerics_Vector4_System_Single_"></a> Extend\(Vector3, Vector4, float\)

```csharp
public static Vector3 Extend(this Vector3 vector3, Vector4 toVector4, float distance)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`toVector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`distance` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Extensions_Vector3Extensions_GetPathLength_System_Collections_Generic_List_System_Numerics_Vector3__"></a> GetPathLength\(List<Vector3\>\)

```csharp
public static float GetPathLength(this List<Vector3> path)
```

#### Parameters

`path` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)\>

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector3Extensions_IsInRange_System_Numerics_Vector3_Divine_Entity_Entities_Entity_System_Single_"></a> IsInRange\(Vector3, Entity, float\)

```csharp
public static bool IsInRange(this Vector3 sourcePosition, Entity target, float range)
```

#### Parameters

`sourcePosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`target` [Entity](Divine.Entity.Entities.Entity.md)

`range` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector3Extensions_IsInRange_System_Numerics_Vector3_System_Numerics_Vector2_System_Single_"></a> IsInRange\(Vector3, Vector2, float\)

```csharp
public static bool IsInRange(this Vector3 sourcePosition, Vector2 targetPosition, float range)
```

#### Parameters

`sourcePosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`targetPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`range` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector3Extensions_IsInRange_System_Numerics_Vector3_System_Numerics_Vector3_System_Single_"></a> IsInRange\(Vector3, Vector3, float\)

```csharp
public static bool IsInRange(this Vector3 sourcePosition, Vector3 targetPosition, float range)
```

#### Parameters

`sourcePosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`targetPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`range` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector3Extensions_IsOnScreen_System_Numerics_Vector3_"></a> IsOnScreen\(Vector3\)

```csharp
public static bool IsOnScreen(this Vector3 vector3)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector3Extensions_IsOrthogonal_System_Numerics_Vector3_System_Numerics_Vector3_"></a> IsOrthogonal\(Vector3, Vector3\)

```csharp
public static bool IsOrthogonal(Vector3 vector3, Vector3 toVector3)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`toVector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector3Extensions_IsOrthogonal_System_Numerics_Vector3_System_Numerics_Vector2_"></a> IsOrthogonal\(Vector3, Vector2\)

```csharp
public static bool IsOrthogonal(Vector3 vector3, Vector2 toVector2)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`toVector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector3Extensions_IsOrthogonal_System_Numerics_Vector3_System_Numerics_Vector4_"></a> IsOrthogonal\(Vector3, Vector4\)

```csharp
public static bool IsOrthogonal(Vector3 vector3, Vector4 toVector4)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`toVector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector3Extensions_IsValid_System_Numerics_Vector3_"></a> IsValid\(Vector3\)

```csharp
public static bool IsValid(this Vector3 vector3)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector3Extensions_IsWall_System_Numerics_Vector3_"></a> IsWall\(Vector3\)

```csharp
public static bool IsWall(this Vector3 vector3)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector3Extensions_Magnitude_System_Numerics_Vector3_"></a> Magnitude\(Vector3\)

```csharp
public static float Magnitude(this Vector3 vector3)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector3Extensions_Normalized_System_Numerics_Vector3_"></a> Normalized\(Vector3\)

```csharp
public static Vector3 Normalized(this Vector3 vector3)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Extensions_Vector3Extensions_PathLength_System_Collections_Generic_List_System_Numerics_Vector3__"></a> PathLength\(List<Vector3\>\)

```csharp
public static float PathLength(this List<Vector3> path)
```

#### Parameters

`path` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)\>

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector3Extensions_Perpendicular_System_Numerics_Vector3_System_Int32_"></a> Perpendicular\(Vector3, int\)

```csharp
public static Vector3 Perpendicular(this Vector3 vector3, int offset = 0)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`offset` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Extensions_Vector3Extensions_Polar_System_Numerics_Vector3_"></a> Polar\(Vector3\)

```csharp
public static float Polar(this Vector3 vector3)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector3Extensions_Rotated_System_Numerics_Vector3_System_Single_"></a> Rotated\(Vector3, float\)

```csharp
public static Vector3 Rotated(this Vector3 vector3, float angle)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`angle` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Extensions_Vector3Extensions_SetZ_System_Numerics_Vector3_System_Nullable_System_Single__"></a> SetZ\(Vector3, float?\)

```csharp
public static Vector3 SetZ(this Vector3 v, float? value = null)
```

#### Parameters

`v` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)?

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Extensions_Vector3Extensions_ToVector2_System_Numerics_Vector3_"></a> ToVector2\(Vector3\)

```csharp
public static Vector2 ToVector2(this Vector3 vector3)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Extensions_Vector3Extensions_ToVector2_System_Collections_Generic_List_System_Numerics_Vector3__"></a> ToVector2\(List<Vector3\>\)

```csharp
public static List<Vector2> ToVector2(this List<Vector3> path)
```

#### Parameters

`path` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)\>

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\>

### <a id="Divine_Extensions_Vector3Extensions_ToVector4_System_Numerics_Vector3_System_Single_"></a> ToVector4\(Vector3, float\)

```csharp
public static Vector4 ToVector4(this Vector3 vector3, float w = 1)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`w` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

### <a id="Divine_Extensions_Vector3Extensions_ToVector4_System_Collections_Generic_List_System_Numerics_Vector3__"></a> ToVector4\(List<Vector3\>\)

```csharp
public static List<Vector4> ToVector4(this List<Vector3> path)
```

#### Parameters

`path` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)\>

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)\>

### <a id="Divine_Extensions_Vector3Extensions_WorldToMinimap_System_Numerics_Vector3_"></a> WorldToMinimap\(Vector3\)

```csharp
public static Vector2 WorldToMinimap(this Vector3 vector3)
```

#### Parameters

`vector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

