# <a id="Divine_Extensions_Vector4Extensions"></a> Class Vector4Extensions

Namespace: [Divine.Extensions](Divine.Extensions.md)  
Assembly: Divine.dll  

```csharp
public static class Vector4Extensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Vector4Extensions](Divine.Extensions.Vector4Extensions.md)

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

### <a id="Divine_Extensions_Vector4Extensions_AngleBetween_System_Numerics_Vector4_System_Numerics_Vector4_"></a> AngleBetween\(Vector4, Vector4\)

```csharp
public static float AngleBetween(this Vector4 vector4, Vector4 toVector4)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`toVector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector4Extensions_AngleBetween_System_Numerics_Vector4_System_Numerics_Vector2_"></a> AngleBetween\(Vector4, Vector2\)

```csharp
public static float AngleBetween(this Vector4 vector4, Vector2 toVector2)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`toVector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector4Extensions_AngleBetween_System_Numerics_Vector4_System_Numerics_Vector3_"></a> AngleBetween\(Vector4, Vector3\)

```csharp
public static float AngleBetween(this Vector4 vector4, Vector3 toVector3)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`toVector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector4Extensions_Closest_System_Numerics_Vector4_System_Collections_Generic_IEnumerable_System_Numerics_Vector4__"></a> Closest\(Vector4, IEnumerable<Vector4\>\)

```csharp
public static Vector4 Closest(this Vector4 vector4, IEnumerable<Vector4> array)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`array` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)\>

#### Returns

 [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

### <a id="Divine_Extensions_Vector4Extensions_Closest_System_Numerics_Vector4_System_Collections_Generic_IEnumerable_System_Numerics_Vector3__"></a> Closest\(Vector4, IEnumerable<Vector3\>\)

```csharp
public static Vector3 Closest(this Vector4 vector4, IEnumerable<Vector3> array)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`array` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)\>

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Extensions_Vector4Extensions_Closest_System_Numerics_Vector4_System_Collections_Generic_IEnumerable_System_Numerics_Vector2__"></a> Closest\(Vector4, IEnumerable<Vector2\>\)

```csharp
public static Vector2 Closest(this Vector4 vector4, IEnumerable<Vector2> array)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`array` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\>

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Extensions_Vector4Extensions_Distance_System_Numerics_Vector4_System_Numerics_Vector4_"></a> Distance\(Vector4, Vector4\)

```csharp
public static float Distance(this Vector4 vector4, Vector4 toVector4)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`toVector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector4Extensions_Distance_System_Numerics_Vector4_System_Numerics_Vector2_"></a> Distance\(Vector4, Vector2\)

```csharp
public static float Distance(this Vector4 vector4, Vector2 toVector2)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`toVector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector4Extensions_Distance_System_Numerics_Vector4_System_Numerics_Vector3_"></a> Distance\(Vector4, Vector3\)

```csharp
public static float Distance(this Vector4 vector4, Vector3 toVector3)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`toVector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector4Extensions_DistanceSquared_System_Numerics_Vector4_System_Numerics_Vector4_"></a> DistanceSquared\(Vector4, Vector4\)

```csharp
public static float DistanceSquared(this Vector4 vector4, Vector4 toVector4)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`toVector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector4Extensions_DistanceSquared_System_Numerics_Vector4_System_Numerics_Vector2_"></a> DistanceSquared\(Vector4, Vector2\)

```csharp
public static float DistanceSquared(this Vector4 vector4, Vector2 toVector2)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`toVector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector4Extensions_DistanceSquared_System_Numerics_Vector4_System_Numerics_Vector3_"></a> DistanceSquared\(Vector4, Vector3\)

```csharp
public static float DistanceSquared(this Vector4 vector4, Vector3 toVector3)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`toVector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector4Extensions_Extend_System_Numerics_Vector4_System_Numerics_Vector4_System_Single_"></a> Extend\(Vector4, Vector4, float\)

```csharp
public static Vector4 Extend(this Vector4 vector4, Vector4 toVector4, float distance)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`toVector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`distance` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

### <a id="Divine_Extensions_Vector4Extensions_Extend_System_Numerics_Vector4_System_Numerics_Vector2_System_Single_"></a> Extend\(Vector4, Vector2, float\)

```csharp
public static Vector4 Extend(this Vector4 vector4, Vector2 toVector2, float distance)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`toVector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`distance` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

### <a id="Divine_Extensions_Vector4Extensions_Extend_System_Numerics_Vector4_System_Numerics_Vector3_System_Single_"></a> Extend\(Vector4, Vector3, float\)

```csharp
public static Vector4 Extend(this Vector4 vector4, Vector3 toVector3, float distance)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`toVector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`distance` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

### <a id="Divine_Extensions_Vector4Extensions_IsOnScreen_System_Numerics_Vector4_"></a> IsOnScreen\(Vector4\)

```csharp
public static bool IsOnScreen(this Vector4 vector4)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector4Extensions_IsOrthogonal_System_Numerics_Vector4_System_Numerics_Vector4_"></a> IsOrthogonal\(Vector4, Vector4\)

```csharp
public static bool IsOrthogonal(this Vector4 vector4, Vector4 toVector4)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`toVector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector4Extensions_IsOrthogonal_System_Numerics_Vector4_System_Numerics_Vector2_"></a> IsOrthogonal\(Vector4, Vector2\)

```csharp
public static bool IsOrthogonal(this Vector4 vector4, Vector2 toVector2)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`toVector2` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector4Extensions_IsOrthogonal_System_Numerics_Vector4_System_Numerics_Vector3_"></a> IsOrthogonal\(Vector4, Vector3\)

```csharp
public static bool IsOrthogonal(this Vector4 vector4, Vector3 toVector3)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`toVector3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector4Extensions_IsValid_System_Numerics_Vector4_"></a> IsValid\(Vector4\)

```csharp
public static bool IsValid(this Vector4 vector4)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector4Extensions_IsWall_System_Numerics_Vector4_"></a> IsWall\(Vector4\)

```csharp
public static bool IsWall(this Vector4 vector4)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_Vector4Extensions_Magnitude_System_Numerics_Vector4_"></a> Magnitude\(Vector4\)

```csharp
public static float Magnitude(this Vector4 vector4)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector4Extensions_Normalized_System_Numerics_Vector4_"></a> Normalized\(Vector4\)

```csharp
public static Vector4 Normalized(this Vector4 vector4)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

### <a id="Divine_Extensions_Vector4Extensions_PathLength_System_Collections_Generic_List_System_Numerics_Vector4__"></a> PathLength\(List<Vector4\>\)

```csharp
public static float PathLength(this List<Vector4> path)
```

#### Parameters

`path` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)\>

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector4Extensions_Perpendicular_System_Numerics_Vector4_System_Int32_"></a> Perpendicular\(Vector4, int\)

```csharp
public static Vector4 Perpendicular(this Vector4 vector4, int offset = 0)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`offset` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

### <a id="Divine_Extensions_Vector4Extensions_Polar_System_Numerics_Vector4_"></a> Polar\(Vector4\)

```csharp
public static float Polar(this Vector4 vector4)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_Vector4Extensions_Rotated_System_Numerics_Vector4_System_Single_"></a> Rotated\(Vector4, float\)

```csharp
public static Vector4 Rotated(this Vector4 vector4, float angle)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`angle` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

### <a id="Divine_Extensions_Vector4Extensions_SetW_System_Numerics_Vector4_System_Nullable_System_Single__"></a> SetW\(Vector4, float?\)

```csharp
public static Vector4 SetW(this Vector4 v, float? value = null)
```

#### Parameters

`v` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)?

#### Returns

 [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

### <a id="Divine_Extensions_Vector4Extensions_SetZ_System_Numerics_Vector4_System_Nullable_System_Single__"></a> SetZ\(Vector4, float?\)

```csharp
public static Vector4 SetZ(this Vector4 v, float? value = null)
```

#### Parameters

`v` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)?

#### Returns

 [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

### <a id="Divine_Extensions_Vector4Extensions_ToVector2_System_Numerics_Vector4_"></a> ToVector2\(Vector4\)

```csharp
public static Vector2 ToVector2(this Vector4 vector4)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Extensions_Vector4Extensions_ToVector2_System_Collections_Generic_List_System_Numerics_Vector4__"></a> ToVector2\(List<Vector4\>\)

```csharp
public static List<Vector2> ToVector2(this List<Vector4> path)
```

#### Parameters

`path` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)\>

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\>

### <a id="Divine_Extensions_Vector4Extensions_ToVector3_System_Numerics_Vector4_"></a> ToVector3\(Vector4\)

```csharp
public static Vector3 ToVector3(this Vector4 vector4)
```

#### Parameters

`vector4` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Extensions_Vector4Extensions_ToVector3_System_Collections_Generic_List_System_Numerics_Vector4__"></a> ToVector3\(List<Vector4\>\)

```csharp
public static List<Vector3> ToVector3(this List<Vector4> path)
```

#### Parameters

`path` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)\>

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)\>

