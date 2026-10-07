# <a id="Divine_Projectile_Projectiles_Projectile"></a> Class Projectile

Namespace: [Divine.Projectile.Projectiles](Divine.Projectile.Projectiles.md)  
Assembly: Divine.dll  

```csharp
public abstract class Projectile
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Projectile](Divine.Projectile.Projectiles.Projectile.md)

#### Derived

[LinearProjectile](Divine.Projectile.Projectiles.LinearProjectile.md), 
[TrackingProjectile](Divine.Projectile.Projectiles.TrackingProjectile.md)

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
[EnumerableExtensions.In<Projectile\>\(Projectile, params Projectile\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Projectile_Projectiles_Projectile_Handle"></a> Handle

```csharp
public uint Handle { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Projectile_Projectiles_Projectile_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Projectile_Projectiles_Projectile_Particle"></a> Particle

```csharp
public abstract Particle? Particle { get; }
```

#### Property Value

 [Particle](Divine.Particle.Particles.Particle.md)?

### <a id="Divine_Projectile_Projectiles_Projectile_ProjectileType"></a> ProjectileType

```csharp
public abstract ProjectileType ProjectileType { get; }
```

#### Property Value

 [ProjectileType](Divine.Projectile.Components.ProjectileType.md)

