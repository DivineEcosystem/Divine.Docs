# <a id="Divine_Particle_EventArgs_ParticleCreateEventArgs"></a> Class ParticleCreateEventArgs

Namespace: [Divine.Particle.EventArgs](Divine.Particle.EventArgs.md)  
Assembly: Divine.dll  

```csharp
public sealed class ParticleCreateEventArgs : EventArgs
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs) ← 
[ParticleCreateEventArgs](Divine.Particle.EventArgs.ParticleCreateEventArgs.md)

#### Inherited Members

[EventArgs.Empty](https://learn.microsoft.com/dotnet/api/system.eventargs.empty), 
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
[EnumerableExtensions.In<ParticleCreateEventArgs\>\(ParticleCreateEventArgs, params ParticleCreateEventArgs\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Particle_EventArgs_ParticleCreateEventArgs_Attachment"></a> Attachment

```csharp
public ParticleAttachment Attachment { get; }
```

#### Property Value

 [ParticleAttachment](Divine.Particle.Components.ParticleAttachment.md)

### <a id="Divine_Particle_EventArgs_ParticleCreateEventArgs_Entity"></a> Entity

```csharp
public Entity? Entity { get; }
```

#### Property Value

 [Entity](Divine.Entity.Entities.Entity.md)?

### <a id="Divine_Particle_EventArgs_ParticleCreateEventArgs_EntityForModifiers"></a> EntityForModifiers

```csharp
public Entity? EntityForModifiers { get; }
```

#### Property Value

 [Entity](Divine.Entity.Entities.Entity.md)?

### <a id="Divine_Particle_EventArgs_ParticleCreateEventArgs_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Particle_EventArgs_ParticleCreateEventArgs_Particle"></a> Particle

```csharp
public Particle Particle { get; }
```

#### Property Value

 [Particle](Divine.Particle.Particles.Particle.md)

