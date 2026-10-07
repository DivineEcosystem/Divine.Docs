# <a id="Divine_Prediction_Collision_CollisionResult"></a> Class CollisionResult

Namespace: [Divine.Prediction.Collision](Divine.Prediction.Collision.md)  
Assembly: Divine.dll  

```csharp
public class CollisionResult
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CollisionResult](Divine.Prediction.Collision.CollisionResult.md)

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
[EnumerableExtensions.In<CollisionResult\>\(CollisionResult, params CollisionResult\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Prediction_Collision_CollisionResult__ctor_System_Collections_Generic_List_Divine_Prediction_Collision_CollisionObject__"></a> CollisionResult\(List<CollisionObject\>\)

```csharp
public CollisionResult(List<CollisionObject> collisionObjects)
```

#### Parameters

`collisionObjects` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[CollisionObject](Divine.Prediction.Collision.CollisionObject.md)\>

## Properties

### <a id="Divine_Prediction_Collision_CollisionResult_Collides"></a> Collides

```csharp
public bool Collides { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Prediction_Collision_CollisionResult_CollisionObjects"></a> CollisionObjects

```csharp
public IReadOnlyCollection<CollisionObject> CollisionObjects { get; }
```

#### Property Value

 [IReadOnlyCollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1)<[CollisionObject](Divine.Prediction.Collision.CollisionObject.md)\>

