# <a id="Divine_Extensions_EntityExtensions"></a> Class EntityExtensions

Namespace: [Divine.Extensions](Divine.Extensions.md)  
Assembly: Divine.dll  

```csharp
public static class EntityExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EntityExtensions](Divine.Extensions.EntityExtensions.md)

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

### <a id="Divine_Extensions_EntityExtensions_Distance_Divine_Entity_Entities_Entity_Divine_Entity_Entities_Entity_"></a> Distance\(Entity, Entity\)

```csharp
public static float Distance(this Entity entity, Entity other)
```

#### Parameters

`entity` [Entity](Divine.Entity.Entities.Entity.md)

`other` [Entity](Divine.Entity.Entities.Entity.md)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_EntityExtensions_Distance_Divine_Entity_Entities_Entity_System_Numerics_Vector3_"></a> Distance\(Entity, Vector3\)

```csharp
public static float Distance(this Entity entity, Vector3 position)
```

#### Parameters

`entity` [Entity](Divine.Entity.Entities.Entity.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_EntityExtensions_Distance2D_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Units_Unit_System_Boolean_"></a> Distance2D\(Unit, Unit, bool\)

```csharp
public static float Distance2D(this Unit entity, Unit other, bool fromCenterToCenter = false)
```

#### Parameters

`entity` [Unit](Divine.Entity.Entities.Units.Unit.md)

`other` [Unit](Divine.Entity.Entities.Units.Unit.md)

`fromCenterToCenter` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_EntityExtensions_Distance2D_Divine_Entity_Entities_Entity_Divine_Entity_Entities_Entity_"></a> Distance2D\(Entity, Entity\)

```csharp
public static float Distance2D(this Entity entity, Entity other)
```

#### Parameters

`entity` [Entity](Divine.Entity.Entities.Entity.md)

`other` [Entity](Divine.Entity.Entities.Entity.md)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_EntityExtensions_Distance2D_Divine_Entity_Entities_Entity_System_Numerics_Vector3_"></a> Distance2D\(Entity, Vector3\)

```csharp
public static float Distance2D(this Entity entity, Vector3 position)
```

#### Parameters

`entity` [Entity](Divine.Entity.Entities.Entity.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Extensions_EntityExtensions_IsAlly_Divine_Entity_Entities_Entity_"></a> IsAlly\(Entity\)

```csharp
public static bool IsAlly(this Entity entity)
```

#### Parameters

`entity` [Entity](Divine.Entity.Entities.Entity.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_EntityExtensions_IsAlly_Divine_Entity_Entities_Entity_Divine_Entity_Entities_Entity_"></a> IsAlly\(Entity, Entity\)

```csharp
public static bool IsAlly(this Entity entity, Entity target)
```

#### Parameters

`entity` [Entity](Divine.Entity.Entities.Entity.md)

`target` [Entity](Divine.Entity.Entities.Entity.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_EntityExtensions_IsAlly_Divine_Entity_Entities_Entity_Divine_Entity_Entities_Components_Team_"></a> IsAlly\(Entity, Team\)

```csharp
public static bool IsAlly(this Entity entity, Team targetTeam)
```

#### Parameters

`entity` [Entity](Divine.Entity.Entities.Entity.md)

`targetTeam` [Team](Divine.Entity.Entities.Components.Team.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_EntityExtensions_IsEnemy_Divine_Entity_Entities_Entity_"></a> IsEnemy\(Entity\)

```csharp
public static bool IsEnemy(this Entity entity)
```

#### Parameters

`entity` [Entity](Divine.Entity.Entities.Entity.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_EntityExtensions_IsEnemy_Divine_Entity_Entities_Entity_Divine_Entity_Entities_Entity_"></a> IsEnemy\(Entity, Entity\)

```csharp
public static bool IsEnemy(this Entity entity, Entity target)
```

#### Parameters

`entity` [Entity](Divine.Entity.Entities.Entity.md)

`target` [Entity](Divine.Entity.Entities.Entity.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_EntityExtensions_IsEnemy_Divine_Entity_Entities_Entity_Divine_Entity_Entities_Components_Team_"></a> IsEnemy\(Entity, Team\)

```csharp
public static bool IsEnemy(this Entity entity, Team targetTeam)
```

#### Parameters

`entity` [Entity](Divine.Entity.Entities.Entity.md)

`targetTeam` [Team](Divine.Entity.Entities.Components.Team.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_EntityExtensions_IsInRange_Divine_Entity_Entities_Entity_Divine_Entity_Entities_Entity_System_Single_"></a> IsInRange\(Entity, Entity, float\)

```csharp
public static bool IsInRange(this Entity source, Entity target, float range)
```

#### Parameters

`source` [Entity](Divine.Entity.Entities.Entity.md)

`target` [Entity](Divine.Entity.Entities.Entity.md)

`range` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_EntityExtensions_IsInRange_Divine_Entity_Entities_Entity_System_Numerics_Vector2_System_Single_"></a> IsInRange\(Entity, Vector2, float\)

```csharp
public static bool IsInRange(this Entity source, Vector2 targetPosition, float range)
```

#### Parameters

`source` [Entity](Divine.Entity.Entities.Entity.md)

`targetPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`range` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_EntityExtensions_IsInRange_Divine_Entity_Entities_Entity_System_Numerics_Vector3_System_Single_"></a> IsInRange\(Entity, Vector3, float\)

```csharp
public static bool IsInRange(this Entity source, Vector3 targetPosition, float range)
```

#### Parameters

`source` [Entity](Divine.Entity.Entities.Entity.md)

`targetPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`range` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

