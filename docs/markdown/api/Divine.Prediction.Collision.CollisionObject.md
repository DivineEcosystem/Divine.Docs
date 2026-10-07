# <a id="Divine_Prediction_Collision_CollisionObject"></a> Class CollisionObject

Namespace: [Divine.Prediction.Collision](Divine.Prediction.Collision.md)  
Assembly: Divine.dll  

```csharp
public class CollisionObject
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CollisionObject](Divine.Prediction.Collision.CollisionObject.md)

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
[EnumerableExtensions.In<CollisionObject\>\(CollisionObject, params CollisionObject\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Prediction_Collision_CollisionObject__ctor_Divine_Entity_Entities_Units_Unit_"></a> CollisionObject\(Unit\)

```csharp
public CollisionObject(Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

### <a id="Divine_Prediction_Collision_CollisionObject__ctor_Divine_Entity_Entities_Entity_System_Numerics_Vector2_System_Single_"></a> CollisionObject\(Entity, Vector2, float\)

```csharp
public CollisionObject(Entity entity, Vector2 position, float radius)
```

#### Parameters

`entity` [Entity](Divine.Entity.Entities.Entity.md)

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Prediction_Collision_CollisionObject__ctor_Divine_Entity_Entities_Entity_System_Numerics_Vector3_System_Single_"></a> CollisionObject\(Entity, Vector3, float\)

```csharp
public CollisionObject(Entity entity, Vector3 position, float radius)
```

#### Parameters

`entity` [Entity](Divine.Entity.Entities.Entity.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="Divine_Prediction_Collision_CollisionObject_Entity"></a> Entity

```csharp
public Entity Entity { get; }
```

#### Property Value

 [Entity](Divine.Entity.Entities.Entity.md)

### <a id="Divine_Prediction_Collision_CollisionObject_Position"></a> Position

```csharp
public Vector2 Position { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Prediction_Collision_CollisionObject_Radius"></a> Radius

```csharp
public float Radius { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

