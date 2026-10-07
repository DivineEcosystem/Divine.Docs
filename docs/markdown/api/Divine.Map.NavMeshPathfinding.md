# <a id="Divine_Map_NavMeshPathfinding"></a> Class NavMeshPathfinding

Namespace: [Divine.Map](Divine.Map.md)  
Assembly: Divine.dll  

```csharp
public sealed class NavMeshPathfinding : ICloneable, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[NavMeshPathfinding](Divine.Map.NavMeshPathfinding.md)

#### Implements

[ICloneable](https://learn.microsoft.com/dotnet/api/system.icloneable), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

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
[EnumerableExtensions.In<NavMeshPathfinding\>\(NavMeshPathfinding, params NavMeshPathfinding\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Map_NavMeshPathfinding__ctor"></a> NavMeshPathfinding\(\)

```csharp
public NavMeshPathfinding()
```

## Properties

### <a id="Divine_Map_NavMeshPathfinding_CellSize"></a> CellSize

```csharp
public float CellSize { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Map_NavMeshPathfinding_HasNavMeshData"></a> HasNavMeshData

```csharp
public bool HasNavMeshData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Map_NavMeshPathfinding_Height"></a> Height

```csharp
public int Height { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Map_NavMeshPathfinding_IsDebugDrawEnabled"></a> IsDebugDrawEnabled

```csharp
public bool IsDebugDrawEnabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Map_NavMeshPathfinding_Width"></a> Width

```csharp
public int Width { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Map_NavMeshPathfinding_AddObstacle_System_Numerics_Vector3_System_Numerics_Vector3_System_Single_System_Single_"></a> AddObstacle\(Vector3, Vector3, float, float\)

```csharp
public uint AddObstacle(Vector3 startPosition, Vector3 endPosition, float startRadius, float endRadius)
```

#### Parameters

`startPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`startRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`endRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Map_NavMeshPathfinding_AddObstacle_System_Numerics_Vector3_System_Numerics_Vector3_System_Single_"></a> AddObstacle\(Vector3, Vector3, float\)

```csharp
public uint AddObstacle(Vector3 startPosition, Vector3 endPosition, float radius)
```

#### Parameters

`startPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Map_NavMeshPathfinding_AddObstacle_System_Numerics_Vector3_System_Single_"></a> AddObstacle\(Vector3, float\)

```csharp
public uint AddObstacle(Vector3 position, float radius)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Map_NavMeshPathfinding_CalculateLongPath_System_Numerics_Vector3_System_Numerics_Vector3_System_Single_System_Boolean_System_Boolean__"></a> CalculateLongPath\(Vector3, Vector3, float, bool, out bool\)

```csharp
public IEnumerable<Vector3> CalculateLongPath(Vector3 startPosition, Vector3 endPosition, float maximumDistance, bool shortenPath, out bool completed)
```

#### Parameters

`startPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`maximumDistance` [float](https://learn.microsoft.com/dotnet/api/system.single)

`shortenPath` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`completed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)\>

### <a id="Divine_Map_NavMeshPathfinding_CalculatePathFromObstacle_System_Numerics_Vector3_System_Numerics_Vector3_System_Single_System_Single_System_Single_System_Single_System_Boolean_System_Boolean__"></a> CalculatePathFromObstacle\(Vector3, Vector3, float, float, float, float, bool, out bool\)

```csharp
public IEnumerable<Vector3> CalculatePathFromObstacle(Vector3 startPosition, Vector3 endPosition, float currentDirection, float movementSpeed, float turnRate, float timeLeft, bool shortenPath, out bool completed)
```

#### Parameters

`startPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`currentDirection` [float](https://learn.microsoft.com/dotnet/api/system.single)

`movementSpeed` [float](https://learn.microsoft.com/dotnet/api/system.single)

`turnRate` [float](https://learn.microsoft.com/dotnet/api/system.single)

`timeLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

`shortenPath` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`completed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)\>

### <a id="Divine_Map_NavMeshPathfinding_CalculateStaticLongPath_System_Numerics_Vector3_System_Numerics_Vector3_System_Single_System_Boolean_System_Boolean__"></a> CalculateStaticLongPath\(Vector3, Vector3, float, bool, out bool\)

```csharp
public IEnumerable<Vector3> CalculateStaticLongPath(Vector3 startPosition, Vector3 endPosition, float maximumDistance, bool shortenPath, out bool completed)
```

#### Parameters

`startPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`maximumDistance` [float](https://learn.microsoft.com/dotnet/api/system.single)

`shortenPath` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`completed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)\>

### <a id="Divine_Map_NavMeshPathfinding_DeepClone"></a> DeepClone\(\)

```csharp
public NavMeshPathfinding DeepClone()
```

#### Returns

 [NavMeshPathfinding](Divine.Map.NavMeshPathfinding.md)

### <a id="Divine_Map_NavMeshPathfinding_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="Divine_Map_NavMeshPathfinding_GetCell_System_Int32_System_Int32_"></a> GetCell\(int, int\)

```csharp
public MeshCell? GetCell(int x, int y)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [MeshCell](Divine.Map.Components.MeshCell.md)?

### <a id="Divine_Map_NavMeshPathfinding_GetCellFlags_System_Single_System_Single_"></a> GetCellFlags\(float, float\)

```csharp
public MeshCellFlags GetCellFlags(float x, float y)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [MeshCellFlags](Divine.Map.Components.MeshCellFlags.md)

### <a id="Divine_Map_NavMeshPathfinding_GetCellFlags_System_Numerics_Vector2_"></a> GetCellFlags\(Vector2\)

```csharp
public MeshCellFlags GetCellFlags(Vector2 position)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [MeshCellFlags](Divine.Map.Components.MeshCellFlags.md)

### <a id="Divine_Map_NavMeshPathfinding_GetCellFlags_System_Numerics_Vector3_"></a> GetCellFlags\(Vector3\)

```csharp
public MeshCellFlags GetCellFlags(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [MeshCellFlags](Divine.Map.Components.MeshCellFlags.md)

### <a id="Divine_Map_NavMeshPathfinding_GetCellFlags_System_Int32_System_Int32_"></a> GetCellFlags\(int, int\)

```csharp
public MeshCellFlags GetCellFlags(int x, int y)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [MeshCellFlags](Divine.Map.Components.MeshCellFlags.md)

### <a id="Divine_Map_NavMeshPathfinding_GetCellPosition_System_Numerics_Vector3_System_Int32__System_Int32__"></a> GetCellPosition\(Vector3, out int, out int\)

```csharp
public bool GetCellPosition(Vector3 position, out int cellX, out int cellY)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`cellX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`cellY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Map_NavMeshPathfinding_GetIntersectingObstacleIDs_System_Numerics_Vector3_System_Single_"></a> GetIntersectingObstacleIDs\(Vector3, float\)

```csharp
public IEnumerable<uint> GetIntersectingObstacleIDs(Vector3 position, float radius)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Map_NavMeshPathfinding_GetIntersectingObstacleIDs_System_Numerics_Vector3_"></a> GetIntersectingObstacleIDs\(Vector3\)

```csharp
public IEnumerable<uint> GetIntersectingObstacleIDs(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Map_NavMeshPathfinding_RemoveObstacle_System_Numerics_Vector3_System_Single_"></a> RemoveObstacle\(Vector3, float\)

```csharp
public int RemoveObstacle(Vector3 position, float radius)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Map_NavMeshPathfinding_RemoveObstacle_System_UInt32_"></a> RemoveObstacle\(uint\)

```csharp
public bool RemoveObstacle(uint obstacleId)
```

#### Parameters

`obstacleId` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Map_NavMeshPathfinding_SetCellFlags_System_Single_System_Single_Divine_Map_Components_MeshCellFlags_"></a> SetCellFlags\(float, float, MeshCellFlags\)

```csharp
public void SetCellFlags(float x, float y, MeshCellFlags flags)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`flags` [MeshCellFlags](Divine.Map.Components.MeshCellFlags.md)

### <a id="Divine_Map_NavMeshPathfinding_SetCellFlags_System_Numerics_Vector2_Divine_Map_Components_MeshCellFlags_"></a> SetCellFlags\(Vector2, MeshCellFlags\)

```csharp
public void SetCellFlags(Vector2 position, MeshCellFlags flags)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`flags` [MeshCellFlags](Divine.Map.Components.MeshCellFlags.md)

### <a id="Divine_Map_NavMeshPathfinding_SetCellFlags_System_Numerics_Vector3_Divine_Map_Components_MeshCellFlags_"></a> SetCellFlags\(Vector3, MeshCellFlags\)

```csharp
public void SetCellFlags(Vector3 position, MeshCellFlags flags)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`flags` [MeshCellFlags](Divine.Map.Components.MeshCellFlags.md)

### <a id="Divine_Map_NavMeshPathfinding_UpdateNavMesh"></a> UpdateNavMesh\(\)

```csharp
public bool UpdateNavMesh()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Map_NavMeshPathfinding_UpdateObstacle_System_UInt32_System_Numerics_Vector3_System_Single_System_Single_"></a> UpdateObstacle\(uint, Vector3, float, float\)

```csharp
public bool UpdateObstacle(uint obstacleId, Vector3 position, float startRadius, float endRadius)
```

#### Parameters

`obstacleId` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`startRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`endRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Map_NavMeshPathfinding_UpdateObstacle_System_UInt32_System_Numerics_Vector3_System_Single_"></a> UpdateObstacle\(uint, Vector3, float\)

```csharp
public bool UpdateObstacle(uint obstacleId, Vector3 position, float radius)
```

#### Parameters

`obstacleId` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Map_NavMeshPathfinding_UpdateObstacle_System_UInt32_System_Numerics_Vector3_System_Numerics_Vector3_"></a> UpdateObstacle\(uint, Vector3, Vector3\)

```csharp
public bool UpdateObstacle(uint obstacleId, Vector3 startPosition, Vector3 endPosition)
```

#### Parameters

`obstacleId` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`startPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Map_NavMeshPathfinding_UpdateObstacle_System_UInt32_System_Numerics_Vector3_"></a> UpdateObstacle\(uint, Vector3\)

```csharp
public bool UpdateObstacle(uint obstacleId, Vector3 position)
```

#### Parameters

`obstacleId` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

