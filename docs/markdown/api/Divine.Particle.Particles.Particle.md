# <a id="Divine_Particle_Particles_Particle"></a> Class Particle

Namespace: [Divine.Particle.Particles](Divine.Particle.Particles.md)  
Assembly: Divine.dll  

```csharp
public class Particle : IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Particle](Divine.Particle.Particles.Particle.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

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
[EnumerableExtensions.In<Particle\>\(Particle, params Particle\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Particle_Particles_Particle_CanDestroy"></a> CanDestroy

```csharp
public bool CanDestroy { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Particle_Particles_Particle_HighestControlPoint"></a> HighestControlPoint

```csharp
public int HighestControlPoint { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Particle_Particles_Particle_Index"></a> Index

```csharp
public int Index { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Particle_Particles_Particle_IsDestroying"></a> IsDestroying

```csharp
public bool IsDestroying { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Particle_Particles_Particle_IsHidden"></a> IsHidden

```csharp
public bool IsHidden { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Particle_Particles_Particle_IsInFogVisible"></a> IsInFogVisible

```csharp
public bool IsInFogVisible { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Particle_Particles_Particle_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Particle_Particles_Particle_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Particle_Particles_Particle_Owner"></a> Owner

```csharp
public Entity? Owner { get; }
```

#### Property Value

 [Entity](Divine.Entity.Entities.Entity.md)?

### <a id="Divine_Particle_Particles_Particle_Position"></a> Position

```csharp
public Vector3 Position { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

## Methods

### <a id="Divine_Particle_Particles_Particle_Destroy"></a> Destroy\(\)

```csharp
public bool Destroy()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Particle_Particles_Particle_Destroy_System_Boolean_"></a> Destroy\(bool\)

```csharp
public bool Destroy(bool immediately)
```

#### Parameters

`immediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Particle_Particles_Particle_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="Divine_Particle_Particles_Particle_FullRestart"></a> FullRestart\(\)

```csharp
public void FullRestart()
```

### <a id="Divine_Particle_Particles_Particle_GetControlPoint_System_Int32_"></a> GetControlPoint\(int\)

```csharp
public Vector3 GetControlPoint(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Particle_Particles_Particle_IsValidControlPoint_System_Int32_"></a> IsValidControlPoint\(int\)

```csharp
public bool IsValidControlPoint(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Particle_Particles_Particle_Release"></a> Release\(\)

```csharp
public void Release()
```

### <a id="Divine_Particle_Particles_Particle_Restart"></a> Restart\(\)

```csharp
public void Restart()
```

### <a id="Divine_Particle_Particles_Particle_SetControlPoint_System_Int32_System_Numerics_Vector3_"></a> SetControlPoint\(int, Vector3\)

```csharp
public void SetControlPoint(int index, Vector3 point)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`point` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Particle_Particles_Particle_SetHidden_System_Boolean_"></a> SetHidden\(bool\)

```csharp
public void SetHidden(bool isHidden)
```

#### Parameters

`isHidden` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Particle_Particles_Particle_SetInFogVisible_System_Boolean_"></a> SetInFogVisible\(bool\)

```csharp
public void SetInFogVisible(bool isInFogVisible)
```

#### Parameters

`isInFogVisible` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Particle_Particles_Particle_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

