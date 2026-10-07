# <a id="Divine_Projectile_Projectiles_TrackingProjectile"></a> Class TrackingProjectile

Namespace: [Divine.Projectile.Projectiles](Divine.Projectile.Projectiles.md)  
Assembly: Divine.dll  

```csharp
public sealed class TrackingProjectile : Projectile
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Projectile](Divine.Projectile.Projectiles.Projectile.md) ← 
[TrackingProjectile](Divine.Projectile.Projectiles.TrackingProjectile.md)

#### Inherited Members

[Projectile.IsValid](Divine.Projectile.Projectiles.Projectile.md\#Divine\_Projectile\_Projectiles\_Projectile\_IsValid), 
[Projectile.Handle](Divine.Projectile.Projectiles.Projectile.md\#Divine\_Projectile\_Projectiles\_Projectile\_Handle), 
[Projectile.ProjectileType](Divine.Projectile.Projectiles.Projectile.md\#Divine\_Projectile\_Projectiles\_Projectile\_ProjectileType), 
[Projectile.Particle](Divine.Projectile.Projectiles.Projectile.md\#Divine\_Projectile\_Projectiles\_Projectile\_Particle), 
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
[EnumerableExtensions.In<TrackingProjectile\>\(TrackingProjectile, params TrackingProjectile\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Projectile_Projectiles_TrackingProjectile_Ability"></a> Ability

```csharp
public Ability? Ability { get; }
```

#### Property Value

 [Ability](Divine.Entity.Entities.Abilities.Ability.md)?

### <a id="Divine_Projectile_Projectiles_TrackingProjectile_IsAttack"></a> IsAttack

```csharp
public bool IsAttack { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Projectile_Projectiles_TrackingProjectile_IsEvadeable"></a> IsEvadeable

```csharp
public bool IsEvadeable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Projectile_Projectiles_TrackingProjectile_IsEvaded"></a> IsEvaded

```csharp
public bool IsEvaded { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Projectile_Projectiles_TrackingProjectile_Particle"></a> Particle

```csharp
public override Particle? Particle { get; }
```

#### Property Value

 [Particle](Divine.Particle.Particles.Particle.md)?

### <a id="Divine_Projectile_Projectiles_TrackingProjectile_Position"></a> Position

```csharp
public Vector3 Position { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Projectile_Projectiles_TrackingProjectile_ProjectileType"></a> ProjectileType

```csharp
public override ProjectileType ProjectileType { get; }
```

#### Property Value

 [ProjectileType](Divine.Projectile.Components.ProjectileType.md)

### <a id="Divine_Projectile_Projectiles_TrackingProjectile_Source"></a> Source

```csharp
public Entity? Source { get; }
```

#### Property Value

 [Entity](Divine.Entity.Entities.Entity.md)?

### <a id="Divine_Projectile_Projectiles_TrackingProjectile_Speed"></a> Speed

```csharp
public int Speed { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Projectile_Projectiles_TrackingProjectile_Target"></a> Target

```csharp
public Entity? Target { get; }
```

#### Property Value

 [Entity](Divine.Entity.Entities.Entity.md)?

### <a id="Divine_Projectile_Projectiles_TrackingProjectile_TargetPosition"></a> TargetPosition

```csharp
public Vector3 TargetPosition { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

