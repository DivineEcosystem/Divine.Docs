# <a id="Divine_Prediction_Collision_Collision"></a> Class Collision

Namespace: [Divine.Prediction.Collision](Divine.Prediction.Collision.md)  
Assembly: Divine.dll  

```csharp
public static class Collision
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Collision](Divine.Prediction.Collision.Collision.md)

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

### <a id="Divine_Prediction_Collision_Collision_GetCollision_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_System_Collections_Generic_List_Divine_Prediction_Collision_CollisionObject__"></a> GetCollision\(Vector2, Vector2, float, List<CollisionObject\>\)

```csharp
public static CollisionResult GetCollision(Vector2 startPosition, Vector2 endPosition, float radius, List<CollisionObject> collisionObjects)
```

#### Parameters

`startPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`endPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`collisionObjects` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[CollisionObject](Divine.Prediction.Collision.CollisionObject.md)\>

#### Returns

 [CollisionResult](Divine.Prediction.Collision.CollisionResult.md)

