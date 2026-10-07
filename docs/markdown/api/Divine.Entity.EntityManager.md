# <a id="Divine_Entity_EntityManager"></a> Class EntityManager

Namespace: [Divine.Entity](Divine.Entity.md)  
Assembly: Divine.dll  

```csharp
public static class EntityManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EntityManager](Divine.Entity.EntityManager.md)

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

### <a id="Divine_Entity_EntityManager_Entities"></a> Entities

```csharp
public static IEnumerable<Entity> Entities { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Entity](Divine.Entity.Entities.Entity.md)\>

### <a id="Divine_Entity_EntityManager_LocalHero"></a> LocalHero

```csharp
public static Hero? LocalHero { get; }
```

#### Property Value

 [Hero](Divine.Entity.Entities.Units.Heroes.Hero.md)?

### <a id="Divine_Entity_EntityManager_LocalPlayer"></a> LocalPlayer

```csharp
public static Player? LocalPlayer { get; }
```

#### Property Value

 [Player](Divine.Entity.Entities.Players.Player.md)?

### <a id="Divine_Entity_EntityManager_MainEntities"></a> MainEntities

```csharp
public static IEnumerable<Entity> MainEntities { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Entity](Divine.Entity.Entities.Entity.md)\>

## Methods

### <a id="Divine_Entity_EntityManager_GetEntities__1"></a> GetEntities<T\>\(\)

```csharp
public static IEnumerable<T> GetEntities<T>() where T : Entity
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

#### Type Parameters

`T` 

### <a id="Divine_Entity_EntityManager_GetEntityByHandle_System_UInt32_"></a> GetEntityByHandle\(uint\)

```csharp
public static Entity? GetEntityByHandle(uint handle)
```

#### Parameters

`handle` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [Entity](Divine.Entity.Entities.Entity.md)?

### <a id="Divine_Entity_EntityManager_GetEntityByIndex_System_Int32_"></a> GetEntityByIndex\(int\)

```csharp
public static Entity? GetEntityByIndex(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Entity](Divine.Entity.Entities.Entity.md)?

### <a id="Divine_Entity_EntityManager_GetMainEntities__1"></a> GetMainEntities<T\>\(\)

```csharp
public static IEnumerable<T> GetMainEntities<T>() where T : Entity
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

#### Type Parameters

`T` 

### <a id="Divine_Entity_EntityManager_GetPlayerById_System_Int32_"></a> GetPlayerById\(int\)

```csharp
public static Player? GetPlayerById(int playerId)
```

#### Parameters

`playerId` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Player](Divine.Entity.Entities.Players.Player.md)?

### <a id="Divine_Entity_EntityManager_EntityAdded"></a> EntityAdded

```csharp
public static event EntityManager.EntityAddedEventHandler? EntityAdded
```

#### Event Type

 [EntityManager](Divine.Entity.EntityManager.md).[EntityAddedEventHandler](Divine.Entity.EntityManager.EntityAddedEventHandler.md)?

### <a id="Divine_Entity_EntityManager_EntityCreate"></a> EntityCreate

```csharp
public static event EntityManager.EntityCreateEventHandler? EntityCreate
```

#### Event Type

 [EntityManager](Divine.Entity.EntityManager.md).[EntityCreateEventHandler](Divine.Entity.EntityManager.EntityCreateEventHandler.md)?

### <a id="Divine_Entity_EntityManager_EntityDestroy"></a> EntityDestroy

```csharp
public static event EntityManager.EntityDestroyEventHandler? EntityDestroy
```

#### Event Type

 [EntityManager](Divine.Entity.EntityManager.md).[EntityDestroyEventHandler](Divine.Entity.EntityManager.EntityDestroyEventHandler.md)?

### <a id="Divine_Entity_EntityManager_EntityRemoved"></a> EntityRemoved

```csharp
public static event EntityManager.EntityRemovedEventHandler? EntityRemoved
```

#### Event Type

 [EntityManager](Divine.Entity.EntityManager.md).[EntityRemovedEventHandler](Divine.Entity.EntityManager.EntityRemovedEventHandler.md)?

### <a id="Divine_Entity_EntityManager_PostDataUpdate"></a> PostDataUpdate

```csharp
public static event EntityManager.PostDataUpdateEventHandler? PostDataUpdate
```

#### Event Type

 [EntityManager](Divine.Entity.EntityManager.md).[PostDataUpdateEventHandler](Divine.Entity.EntityManager.PostDataUpdateEventHandler.md)?

