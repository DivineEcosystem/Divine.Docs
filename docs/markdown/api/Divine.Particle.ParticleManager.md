# <a id="Divine_Particle_ParticleManager"></a> Class ParticleManager

Namespace: [Divine.Particle](Divine.Particle.md)  
Assembly: Divine.dll  

```csharp
public static class ParticleManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ParticleManager](Divine.Particle.ParticleManager.md)

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

### <a id="Divine_Particle_ParticleManager_Particles"></a> Particles

```csharp
public static IEnumerable<Particle> Particles { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Particle](Divine.Particle.Particles.Particle.md)\>

### <a id="Divine_Particle_ParticleManager_UseParticleFoW"></a> UseParticleFoW

```csharp
public static bool UseParticleFoW { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Particle_ParticleManager_CreateCircleParticle_System_String_System_Numerics_Vector3_System_Single_Vortice_Mathematics_Color_"></a> CreateCircleParticle\(string, Vector3, float, Color\)

```csharp
public static void CreateCircleParticle(string key, Vector3 position, float range, Color color)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`range` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Particle_ParticleManager_CreateLineParticle_System_String_System_Numerics_Vector3_System_Numerics_Vector3_System_Single_Vortice_Mathematics_Color_"></a> CreateLineParticle\(string, Vector3, Vector3, float, Color\)

```csharp
public static void CreateLineParticle(string key, Vector3 startPosition, Vector3 endPosition, float size, Color color)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`startPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`size` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Particle_ParticleManager_CreateLineParticle_System_String_System_Numerics_Vector3_System_Numerics_Vector3_System_Numerics_Vector3_Vortice_Mathematics_Color_"></a> CreateLineParticle\(string, Vector3, Vector3, Vector3, Color\)

```csharp
public static void CreateLineParticle(string key, Vector3 startPosition, Vector3 endPosition, Vector3 functions, Color color)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`startPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`functions` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Particle_ParticleManager_CreateParticle_System_String_System_Numerics_Vector3_"></a> CreateParticle\(string, Vector3\)

```csharp
public static Particle CreateParticle(string name, Vector3 position)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [Particle](Divine.Particle.Particles.Particle.md)

### <a id="Divine_Particle_ParticleManager_CreateParticle_System_String_Divine_Particle_Components_ParticleAttachment_"></a> CreateParticle\(string, ParticleAttachment\)

```csharp
public static Particle CreateParticle(string name, ParticleAttachment attachment)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`attachment` [ParticleAttachment](Divine.Particle.Components.ParticleAttachment.md)

#### Returns

 [Particle](Divine.Particle.Particles.Particle.md)

### <a id="Divine_Particle_ParticleManager_CreateParticle_System_String_Divine_Entity_Entities_Entity_"></a> CreateParticle\(string, Entity\)

```csharp
public static Particle CreateParticle(string name, Entity entity)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`entity` [Entity](Divine.Entity.Entities.Entity.md)

#### Returns

 [Particle](Divine.Particle.Particles.Particle.md)

### <a id="Divine_Particle_ParticleManager_CreateParticle_System_String_Divine_Particle_Components_ParticleAttachment_Divine_Entity_Entities_Entity_"></a> CreateParticle\(string, ParticleAttachment, Entity\)

```csharp
public static Particle CreateParticle(string name, ParticleAttachment attachment, Entity entity)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`attachment` [ParticleAttachment](Divine.Particle.Components.ParticleAttachment.md)

`entity` [Entity](Divine.Entity.Entities.Entity.md)

#### Returns

 [Particle](Divine.Particle.Particles.Particle.md)

### <a id="Divine_Particle_ParticleManager_CreateParticle_System_String_System_String_Divine_Particle_Components_ParticleAttachment_"></a> CreateParticle\(string, string, ParticleAttachment\)

```csharp
public static void CreateParticle(string key, string name, ParticleAttachment attachment)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`attachment` [ParticleAttachment](Divine.Particle.Components.ParticleAttachment.md)

### <a id="Divine_Particle_ParticleManager_CreateParticle_System_String_System_String_Divine_Particle_Components_ParticleAttachment_Divine_Particle_Components_RestartType_"></a> CreateParticle\(string, string, ParticleAttachment, RestartType\)

```csharp
public static void CreateParticle(string key, string name, ParticleAttachment attachment, RestartType restartType)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`attachment` [ParticleAttachment](Divine.Particle.Components.ParticleAttachment.md)

`restartType` [RestartType](Divine.Particle.Components.RestartType.md)

### <a id="Divine_Particle_ParticleManager_CreateParticle_System_String_System_String_Divine_Particle_Components_ParticleAttachment_Divine_Particle_Numerics_ControlPoint___"></a> CreateParticle\(string, string, ParticleAttachment, params ControlPoint\[\]?\)

```csharp
public static void CreateParticle(string key, string name, ParticleAttachment attachment, params ControlPoint[]? controlPoints)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`attachment` [ParticleAttachment](Divine.Particle.Components.ParticleAttachment.md)

`controlPoints` [ControlPoint](Divine.Particle.Numerics.ControlPoint.md)\[\]?

### <a id="Divine_Particle_ParticleManager_CreateParticle_System_String_System_String_Divine_Particle_Components_ParticleAttachment_Divine_Particle_Components_RestartType_Divine_Particle_Numerics_ControlPoint___"></a> CreateParticle\(string, string, ParticleAttachment, RestartType, params ControlPoint\[\]?\)

```csharp
public static void CreateParticle(string key, string name, ParticleAttachment attachment, RestartType restartType, params ControlPoint[]? controlPoints)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`attachment` [ParticleAttachment](Divine.Particle.Components.ParticleAttachment.md)

`restartType` [RestartType](Divine.Particle.Components.RestartType.md)

`controlPoints` [ControlPoint](Divine.Particle.Numerics.ControlPoint.md)\[\]?

### <a id="Divine_Particle_ParticleManager_CreateParticle_System_String_System_String_Divine_Particle_Components_ParticleAttachment_Divine_Entity_Entities_Entity_"></a> CreateParticle\(string, string, ParticleAttachment, Entity\)

```csharp
public static void CreateParticle(string key, string name, ParticleAttachment attachment, Entity entity)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`attachment` [ParticleAttachment](Divine.Particle.Components.ParticleAttachment.md)

`entity` [Entity](Divine.Entity.Entities.Entity.md)

### <a id="Divine_Particle_ParticleManager_CreateParticle_System_String_System_String_Divine_Particle_Components_ParticleAttachment_Divine_Entity_Entities_Entity_Divine_Particle_Components_RestartType_"></a> CreateParticle\(string, string, ParticleAttachment, Entity, RestartType\)

```csharp
public static void CreateParticle(string key, string name, ParticleAttachment attachment, Entity entity, RestartType restartType)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`attachment` [ParticleAttachment](Divine.Particle.Components.ParticleAttachment.md)

`entity` [Entity](Divine.Entity.Entities.Entity.md)

`restartType` [RestartType](Divine.Particle.Components.RestartType.md)

### <a id="Divine_Particle_ParticleManager_CreateParticle_System_String_System_String_Divine_Particle_Components_ParticleAttachment_Divine_Entity_Entities_Entity_Divine_Particle_Numerics_ControlPoint___"></a> CreateParticle\(string, string, ParticleAttachment, Entity, params ControlPoint\[\]?\)

```csharp
public static void CreateParticle(string key, string name, ParticleAttachment attachment, Entity entity, params ControlPoint[]? controlPoints)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`attachment` [ParticleAttachment](Divine.Particle.Components.ParticleAttachment.md)

`entity` [Entity](Divine.Entity.Entities.Entity.md)

`controlPoints` [ControlPoint](Divine.Particle.Numerics.ControlPoint.md)\[\]?

### <a id="Divine_Particle_ParticleManager_CreateParticle_System_String_System_String_Divine_Particle_Components_ParticleAttachment_Divine_Entity_Entities_Entity_Divine_Particle_Components_RestartType_Divine_Particle_Numerics_ControlPoint___"></a> CreateParticle\(string, string, ParticleAttachment, Entity, RestartType, params ControlPoint\[\]?\)

```csharp
public static void CreateParticle(string key, string name, ParticleAttachment attachment, Entity entity, RestartType restartType, params ControlPoint[]? controlPoints)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`attachment` [ParticleAttachment](Divine.Particle.Components.ParticleAttachment.md)

`entity` [Entity](Divine.Entity.Entities.Entity.md)

`restartType` [RestartType](Divine.Particle.Components.RestartType.md)

`controlPoints` [ControlPoint](Divine.Particle.Numerics.ControlPoint.md)\[\]?

### <a id="Divine_Particle_ParticleManager_CreateRangeParticle_System_String_Divine_Entity_Entities_Entity_System_Single_Vortice_Mathematics_Color_"></a> CreateRangeParticle\(string, Entity, float, Color\)

```csharp
public static void CreateRangeParticle(string key, Entity entity, float range, Color color)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`entity` [Entity](Divine.Entity.Entities.Entity.md)

`range` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Particle_ParticleManager_CreateTargetLineParticle_System_String_Divine_Entity_Entities_Entity_System_Numerics_Vector3_Vortice_Mathematics_Color_"></a> CreateTargetLineParticle\(string, Entity, Vector3, Color\)

```csharp
public static void CreateTargetLineParticle(string key, Entity entity, Vector3 endPosition, Color color)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`entity` [Entity](Divine.Entity.Entities.Entity.md)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`color` [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Particle_ParticleManager_DestroyParticle_System_String_System_Boolean_"></a> DestroyParticle\(string, bool\)

```csharp
public static bool DestroyParticle(string key, bool immediately = true)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`immediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Particle_ParticleManager_GetParticleByIndex_System_Int32_"></a> GetParticleByIndex\(int\)

```csharp
public static Particle? GetParticleByIndex(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Particle](Divine.Particle.Particles.Particle.md)?

### <a id="Divine_Particle_ParticleManager_RemoveParticle_System_String_System_Boolean_"></a> RemoveParticle\(string, bool\)

```csharp
[Obsolete("Use DestroyParticle!")]
public static bool RemoveParticle(string key, bool immediately = true)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`immediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Particle_ParticleManager_ParticleAdded"></a> ParticleAdded

```csharp
public static event ParticleManager.ParticleAddedEventHandler? ParticleAdded
```

#### Event Type

 [ParticleManager](Divine.Particle.ParticleManager.md).[ParticleAddedEventHandler](Divine.Particle.ParticleManager.ParticleAddedEventHandler.md)?

### <a id="Divine_Particle_ParticleManager_ParticleCreate"></a> ParticleCreate

```csharp
public static event ParticleManager.ParticleCreateEventHandler? ParticleCreate
```

#### Event Type

 [ParticleManager](Divine.Particle.ParticleManager.md).[ParticleCreateEventHandler](Divine.Particle.ParticleManager.ParticleCreateEventHandler.md)?

### <a id="Divine_Particle_ParticleManager_ParticleDestroy"></a> ParticleDestroy

```csharp
public static event ParticleManager.ParticleDestroyEventHandler? ParticleDestroy
```

#### Event Type

 [ParticleManager](Divine.Particle.ParticleManager.md).[ParticleDestroyEventHandler](Divine.Particle.ParticleManager.ParticleDestroyEventHandler.md)?

### <a id="Divine_Particle_ParticleManager_ParticleRemoved"></a> ParticleRemoved

```csharp
public static event ParticleManager.ParticleRemovedEventHandler? ParticleRemoved
```

#### Event Type

 [ParticleManager](Divine.Particle.ParticleManager.md).[ParticleRemovedEventHandler](Divine.Particle.ParticleManager.ParticleRemovedEventHandler.md)?

