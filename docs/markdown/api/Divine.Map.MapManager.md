# <a id="Divine_Map_MapManager"></a> Class MapManager

Namespace: [Divine.Map](Divine.Map.md)  
Assembly: Divine.dll  

```csharp
public static class MapManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MapManager](Divine.Map.MapManager.md)

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

### <a id="Divine_Map_MapManager_Bottom"></a> Bottom

```csharp
public static float Bottom { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Map_MapManager_Left"></a> Left

```csharp
public static float Left { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Map_MapManager_MapFileName"></a> MapFileName

```csharp
public static string? MapFileName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Divine_Map_MapManager_MapName"></a> MapName

```csharp
public static string? MapName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Divine_Map_MapManager_MeshCellSize"></a> MeshCellSize

```csharp
public static float MeshCellSize { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Map_MapManager_MeshHeight"></a> MeshHeight

```csharp
public static int MeshHeight { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Map_MapManager_MeshWidth"></a> MeshWidth

```csharp
public static int MeshWidth { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Map_MapManager_Right"></a> Right

```csharp
public static float Right { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Map_MapManager_Size"></a> Size

```csharp
public static Vector2 Size { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Map_MapManager_Top"></a> Top

```csharp
public static float Top { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Map_MapManager_GetAbsolutePosition_System_Numerics_Vector3_"></a> GetAbsolutePosition\(Vector3\)

```csharp
public static Vector3 GetAbsolutePosition(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Map_MapManager_GetAbsolutePosition_System_Numerics_Vector2_"></a> GetAbsolutePosition\(Vector2\)

```csharp
public static Vector3 GetAbsolutePosition(Vector2 position)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Map_MapManager_GetHeight_System_Numerics_Vector3_"></a> GetHeight\(Vector3\)

```csharp
public static float GetHeight(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Map_MapManager_GetHeight_System_Numerics_Vector2_"></a> GetHeight\(Vector2\)

```csharp
public static float GetHeight(Vector2 position)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Map_MapManager_GetMeshCell_System_Int32_System_Int32_System_Numerics_Vector2__"></a> GetMeshCell\(int, int, out Vector2\)

```csharp
public static MeshCellFlags GetMeshCell(int cellX, int cellY, out Vector2 worldPosition)
```

#### Parameters

`cellX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`cellY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`worldPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [MeshCellFlags](Divine.Map.Components.MeshCellFlags.md)

### <a id="Divine_Map_MapManager_GetMeshCell_System_Numerics_Vector2_System_Int32__System_Int32__System_Numerics_Vector2__"></a> GetMeshCell\(Vector2, out int, out int, out Vector2\)

```csharp
public static MeshCellFlags GetMeshCell(Vector2 position, out int cellX, out int cellY, out Vector2 worldPosition)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`cellX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`cellY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`worldPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [MeshCellFlags](Divine.Map.Components.MeshCellFlags.md)

### <a id="Divine_Map_MapManager_GetMeshCell_System_Numerics_Vector3_System_Int32__System_Int32__System_Numerics_Vector2__"></a> GetMeshCell\(Vector3, out int, out int, out Vector2\)

```csharp
public static MeshCellFlags GetMeshCell(Vector3 position, out int cellX, out int cellY, out Vector2 worldPosition)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`cellX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`cellY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`worldPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [MeshCellFlags](Divine.Map.Components.MeshCellFlags.md)

### <a id="Divine_Map_MapManager_GetMeshCell_System_Numerics_Vector2_"></a> GetMeshCell\(Vector2\)

```csharp
public static MeshCell GetMeshCell(Vector2 position)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [MeshCell](Divine.Map.Components.MeshCell.md)

### <a id="Divine_Map_MapManager_GetMeshCell_System_Numerics_Vector3_"></a> GetMeshCell\(Vector3\)

```csharp
public static MeshCell GetMeshCell(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [MeshCell](Divine.Map.Components.MeshCell.md)

### <a id="Divine_Map_MapManager_GetMeshCell_System_Int32_System_Int32_"></a> GetMeshCell\(int, int\)

```csharp
public static MeshCell GetMeshCell(int cellX, int cellY)
```

#### Parameters

`cellX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`cellY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [MeshCell](Divine.Map.Components.MeshCell.md)

### <a id="Divine_Map_MapManager_GetMeshCellFlags_System_Numerics_Vector3_"></a> GetMeshCellFlags\(Vector3\)

```csharp
public static MeshCellFlags GetMeshCellFlags(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [MeshCellFlags](Divine.Map.Components.MeshCellFlags.md)

### <a id="Divine_Map_MapManager_GetMeshCellFlags_System_Numerics_Vector2_"></a> GetMeshCellFlags\(Vector2\)

```csharp
public static MeshCellFlags GetMeshCellFlags(Vector2 position)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [MeshCellFlags](Divine.Map.Components.MeshCellFlags.md)

### <a id="Divine_Map_MapManager_GetMeshCellFlags_System_Int32_System_Int32_"></a> GetMeshCellFlags\(int, int\)

```csharp
public static MeshCellFlags GetMeshCellFlags(int cellX, int cellY)
```

#### Parameters

`cellX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`cellY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [MeshCellFlags](Divine.Map.Components.MeshCellFlags.md)

### <a id="Divine_Map_MapManager_GetMeshCellPosition_System_Numerics_Vector3_System_Int32__System_Int32__"></a> GetMeshCellPosition\(Vector3, out int, out int\)

```csharp
public static bool GetMeshCellPosition(Vector3 position, out int cellX, out int cellY)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`cellX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`cellY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Map_MapManager_GetMeshCellPosition_System_Numerics_Vector2_System_Int32__System_Int32__"></a> GetMeshCellPosition\(Vector2, out int, out int\)

```csharp
public static bool GetMeshCellPosition(Vector2 position, out int cellX, out int cellY)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`cellX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`cellY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Map_MapManager_GetSecondaryHeight_System_Numerics_Vector3_"></a> GetSecondaryHeight\(Vector3\)

```csharp
public static float GetSecondaryHeight(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Map_MapManager_GetSecondaryHeight_System_Numerics_Vector2_"></a> GetSecondaryHeight\(Vector2\)

```csharp
public static float GetSecondaryHeight(Vector2 position)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

