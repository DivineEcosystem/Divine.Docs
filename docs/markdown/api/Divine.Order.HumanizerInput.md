# <a id="Divine_Order_HumanizerInput"></a> Class HumanizerInput

Namespace: [Divine.Order](Divine.Order.md)  
Assembly: Divine.dll  

```csharp
public sealed class HumanizerInput : IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[HumanizerInput](Divine.Order.HumanizerInput.md)

#### Implements

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
[EnumerableExtensions.In<HumanizerInput\>\(HumanizerInput, params HumanizerInput\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Order_HumanizerInput_CameraLookAt"></a> CameraLookAt

```csharp
public Vector3 CameraLookAt { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Order_HumanizerInput_CameraPosition"></a> CameraPosition

```csharp
public Vector3 CameraPosition { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Order_HumanizerInput_IsDisposed"></a> IsDisposed

```csharp
public bool IsDisposed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Order_HumanizerInput_IsEnabled"></a> IsEnabled

```csharp
public bool IsEnabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Order_HumanizerInput_MouseScreenPosition"></a> MouseScreenPosition

```csharp
public Vector2 MouseScreenPosition { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

## Methods

### <a id="Divine_Order_HumanizerInput_Create"></a> Create\(\)

```csharp
public static HumanizerInput? Create()
```

#### Returns

 [HumanizerInput](Divine.Order.HumanizerInput.md)?

### <a id="Divine_Order_HumanizerInput_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="Divine_Order_HumanizerInput_MoveCamera_System_Numerics_Vector3_"></a> MoveCamera\(Vector3\)

```csharp
public void MoveCamera(Vector3 lookAt)
```

#### Parameters

`lookAt` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Order_HumanizerInput_MoveMouse_System_Numerics_Vector2_"></a> MoveMouse\(Vector2\)

```csharp
public void MoveMouse(Vector2 screenPosition)
```

#### Parameters

`screenPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Order_HumanizerInput_WorldToScreen_System_Numerics_Vector3_System_Numerics_Vector2__"></a> WorldToScreen\(Vector3, out Vector2\)

```csharp
public bool WorldToScreen(Vector3 position, out Vector2 screenPosition)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`screenPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

