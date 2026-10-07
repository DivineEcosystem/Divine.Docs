# <a id="Divine_Projectile_Projectiles_LinearProjectile"></a> Class LinearProjectile

Namespace: [Divine.Projectile.Projectiles](Divine.Projectile.Projectiles.md)  
Assembly: Divine.dll  

```csharp
public sealed class LinearProjectile : Projectile
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Projectile](Divine.Projectile.Projectiles.Projectile.md) ← 
[LinearProjectile](Divine.Projectile.Projectiles.LinearProjectile.md)

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
[EnumerableExtensions.In<LinearProjectile\>\(LinearProjectile, params LinearProjectile\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Projectile_Projectiles_LinearProjectile_Distance"></a> Distance

```csharp
public float Distance { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Projectile_Projectiles_LinearProjectile_Particle"></a> Particle

```csharp
public override Particle? Particle { get; }
```

#### Property Value

 [Particle](Divine.Particle.Particles.Particle.md)?

### <a id="Divine_Projectile_Projectiles_LinearProjectile_Position"></a> Position

```csharp
public Vector3 Position { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Projectile_Projectiles_LinearProjectile_ProjectileType"></a> ProjectileType

```csharp
public override ProjectileType ProjectileType { get; }
```

#### Property Value

 [ProjectileType](Divine.Projectile.Components.ProjectileType.md)

### <a id="Divine_Projectile_Projectiles_LinearProjectile_Radius"></a> Radius

```csharp
public float Radius { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Projectile_Projectiles_LinearProjectile_Source"></a> Source

```csharp
public Entity? Source { get; }
```

#### Property Value

 [Entity](Divine.Entity.Entities.Entity.md)?

### <a id="Divine_Projectile_Projectiles_LinearProjectile_StartPosition"></a> StartPosition

```csharp
public Vector3 StartPosition { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Projectile_Projectiles_LinearProjectile_Velocity"></a> Velocity

```csharp
public Vector3 Velocity { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

