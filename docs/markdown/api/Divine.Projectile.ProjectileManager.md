# <a id="Divine_Projectile_ProjectileManager"></a> Class ProjectileManager

Namespace: [Divine.Projectile](Divine.Projectile.md)  
Assembly: Divine.dll  

```csharp
public static class ProjectileManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ProjectileManager](Divine.Projectile.ProjectileManager.md)

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

### <a id="Divine_Projectile_ProjectileManager_LinearProjectiles"></a> LinearProjectiles

```csharp
public static IEnumerable<LinearProjectile> LinearProjectiles { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[LinearProjectile](Divine.Projectile.Projectiles.LinearProjectile.md)\>

### <a id="Divine_Projectile_ProjectileManager_TrackingProjectiles"></a> TrackingProjectiles

```csharp
public static IEnumerable<TrackingProjectile> TrackingProjectiles { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TrackingProjectile](Divine.Projectile.Projectiles.TrackingProjectile.md)\>

### <a id="Divine_Projectile_ProjectileManager_LinearProjectileAdded"></a> LinearProjectileAdded

```csharp
public static event ProjectileManager.LinearProjectileAddedEventHandler LinearProjectileAdded
```

#### Event Type

 [ProjectileManager](Divine.Projectile.ProjectileManager.md).[LinearProjectileAddedEventHandler](Divine.Projectile.ProjectileManager.LinearProjectileAddedEventHandler.md)

### <a id="Divine_Projectile_ProjectileManager_LinearProjectileCreate"></a> LinearProjectileCreate

```csharp
public static event ProjectileManager.LinearProjectileCreateEventHandler LinearProjectileCreate
```

#### Event Type

 [ProjectileManager](Divine.Projectile.ProjectileManager.md).[LinearProjectileCreateEventHandler](Divine.Projectile.ProjectileManager.LinearProjectileCreateEventHandler.md)

### <a id="Divine_Projectile_ProjectileManager_LinearProjectileDestroy"></a> LinearProjectileDestroy

```csharp
public static event ProjectileManager.LinearProjectileDestroyEventHandler LinearProjectileDestroy
```

#### Event Type

 [ProjectileManager](Divine.Projectile.ProjectileManager.md).[LinearProjectileDestroyEventHandler](Divine.Projectile.ProjectileManager.LinearProjectileDestroyEventHandler.md)

### <a id="Divine_Projectile_ProjectileManager_LinearProjectileRemoved"></a> LinearProjectileRemoved

```csharp
public static event ProjectileManager.LinearProjectileRemovedEventHandler LinearProjectileRemoved
```

#### Event Type

 [ProjectileManager](Divine.Projectile.ProjectileManager.md).[LinearProjectileRemovedEventHandler](Divine.Projectile.ProjectileManager.LinearProjectileRemovedEventHandler.md)

### <a id="Divine_Projectile_ProjectileManager_TrackingProjectileAdded"></a> TrackingProjectileAdded

```csharp
public static event ProjectileManager.TrackingProjectileAddedEventHandler TrackingProjectileAdded
```

#### Event Type

 [ProjectileManager](Divine.Projectile.ProjectileManager.md).[TrackingProjectileAddedEventHandler](Divine.Projectile.ProjectileManager.TrackingProjectileAddedEventHandler.md)

### <a id="Divine_Projectile_ProjectileManager_TrackingProjectileCreate"></a> TrackingProjectileCreate

```csharp
public static event ProjectileManager.TrackingProjectileCreateEventHandler TrackingProjectileCreate
```

#### Event Type

 [ProjectileManager](Divine.Projectile.ProjectileManager.md).[TrackingProjectileCreateEventHandler](Divine.Projectile.ProjectileManager.TrackingProjectileCreateEventHandler.md)

### <a id="Divine_Projectile_ProjectileManager_TrackingProjectileDestroy"></a> TrackingProjectileDestroy

```csharp
public static event ProjectileManager.TrackingProjectileDestroyEventHandler TrackingProjectileDestroy
```

#### Event Type

 [ProjectileManager](Divine.Projectile.ProjectileManager.md).[TrackingProjectileDestroyEventHandler](Divine.Projectile.ProjectileManager.TrackingProjectileDestroyEventHandler.md)

### <a id="Divine_Projectile_ProjectileManager_TrackingProjectileRemoved"></a> TrackingProjectileRemoved

```csharp
public static event ProjectileManager.TrackingProjectileRemovedEventHandler TrackingProjectileRemoved
```

#### Event Type

 [ProjectileManager](Divine.Projectile.ProjectileManager.md).[TrackingProjectileRemovedEventHandler](Divine.Projectile.ProjectileManager.TrackingProjectileRemovedEventHandler.md)

