# <a id="Divine_Camera_CameraManager"></a> Class CameraManager

Namespace: [Divine.Camera](Divine.Camera.md)  
Assembly: Divine.dll  

```csharp
public static class CameraManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CameraManager](Divine.Camera.CameraManager.md)

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

### <a id="Divine_Camera_CameraManager_DefaultAngles"></a> DefaultAngles

```csharp
public static readonly Vector3 DefaultAngles
```

#### Field Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Camera_CameraManager_DefaultDistance"></a> DefaultDistance

```csharp
public const float DefaultDistance = 1200
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Camera_CameraManager_DefaultLookAt"></a> DefaultLookAt

```csharp
public static readonly Vector3 DefaultLookAt
```

#### Field Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Camera_CameraManager_DefaultLookAtY"></a> DefaultLookAtY

```csharp
public const float DefaultLookAtY = 600
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Camera_CameraManager_DefaultPitch"></a> DefaultPitch

```csharp
public const float DefaultPitch = 60
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Camera_CameraManager_DefaultRoll"></a> DefaultRoll

```csharp
public const float DefaultRoll = 0
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Camera_CameraManager_DefaultYaw"></a> DefaultYaw

```csharp
public const float DefaultYaw = 90
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="Divine_Camera_CameraManager_Angles"></a> Angles

```csharp
public static Vector3 Angles { get; set; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Camera_CameraManager_Bounds"></a> Bounds

```csharp
public static BoundingBox Bounds { get; }
```

#### Property Value

 [BoundingBox](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/BoundingBox.cs)

### <a id="Divine_Camera_CameraManager_Distance"></a> Distance

```csharp
public static float Distance { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Camera_CameraManager_LookAt"></a> LookAt

```csharp
public static Vector3 LookAt { get; set; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Camera_CameraManager_Pitch"></a> Pitch

```csharp
public static float Pitch { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Camera_CameraManager_Position"></a> Position

```csharp
public static Vector3 Position { get; set; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Camera_CameraManager_Roll"></a> Roll

```csharp
public static float Roll { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Camera_CameraManager_Yaw"></a> Yaw

```csharp
public static float Yaw { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Camera_CameraManager_CalculatePosition_System_Numerics_Vector3_"></a> CalculatePosition\(Vector3\)

```csharp
public static Vector3 CalculatePosition(Vector3 cameraPosition)
```

#### Parameters

`cameraPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Camera_CameraManager_CalculatePosition_System_Numerics_Vector3_System_Numerics_Vector3_System_Single_"></a> CalculatePosition\(Vector3, Vector3, float\)

```csharp
public static Vector3 CalculatePosition(Vector3 cameraPosition, Vector3 cameraAngles, float cameraDistance)
```

#### Parameters

`cameraPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`cameraAngles` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`cameraDistance` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Camera_CameraManager_GetDefaultLookAt"></a> GetDefaultLookAt\(\)

```csharp
public static Vector3 GetDefaultLookAt()
```

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Camera_CameraManager_GetDefaultLookAt_System_Numerics_Vector3_"></a> GetDefaultLookAt\(Vector3\)

```csharp
public static Vector3 GetDefaultLookAt(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Camera_CameraManager_GetLookAt_System_Single_"></a> GetLookAt\(float\)

```csharp
public static Vector3 GetLookAt(float distance)
```

#### Parameters

`distance` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Camera_CameraManager_GetLookAt_System_Numerics_Vector3_System_Single_"></a> GetLookAt\(Vector3, float\)

```csharp
public static Vector3 GetLookAt(Vector3 position, float distance)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`distance` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Camera_CameraManager_ScreenToWorld_System_Numerics_Vector2_System_Numerics_Vector3_"></a> ScreenToWorld\(Vector2, Vector3\)

```csharp
public static Vector3 ScreenToWorld(Vector2 screenPosition, Vector3 cameraPosition)
```

#### Parameters

`screenPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`cameraPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Camera_CameraManager_ScreenToWorld_System_Numerics_Vector2_System_Numerics_Vector3_System_Numerics_Vector3_System_Single_System_Numerics_Vector2_"></a> ScreenToWorld\(Vector2, Vector3, Vector3, float, Vector2\)

```csharp
public static Vector3 ScreenToWorld(Vector2 screenPosition, Vector3 cameraPosition, Vector3 cameraAngles, float cameraDistance, Vector2 screenSize)
```

#### Parameters

`screenPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`cameraPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`cameraAngles` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`cameraDistance` [float](https://learn.microsoft.com/dotnet/api/system.single)

`screenSize` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Camera_CameraManager_WorldToScreen_System_Numerics_Vector3_System_Numerics_Vector3_System_Numerics_Vector2__"></a> WorldToScreen\(Vector3, Vector3, out Vector2\)

```csharp
public static bool WorldToScreen(Vector3 position, Vector3 cameraPosition, out Vector2 screenPosition)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`cameraPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`screenPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Camera_CameraManager_WorldToScreen_System_Numerics_Vector3_System_Numerics_Vector3_System_Numerics_Vector3_System_Single_System_Numerics_Vector2_System_Numerics_Vector2__"></a> WorldToScreen\(Vector3, Vector3, Vector3, float, Vector2, out Vector2\)

```csharp
public static bool WorldToScreen(Vector3 position, Vector3 cameraPosition, Vector3 cameraAngles, float cameraDistance, Vector2 screenSize, out Vector2 screenPosition)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`cameraPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`cameraAngles` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`cameraDistance` [float](https://learn.microsoft.com/dotnet/api/system.single)

`screenSize` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`screenPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

