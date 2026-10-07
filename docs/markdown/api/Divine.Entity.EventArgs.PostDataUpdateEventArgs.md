# <a id="Divine_Entity_EventArgs_PostDataUpdateEventArgs"></a> Struct PostDataUpdateEventArgs

Namespace: [Divine.Entity.EventArgs](Divine.Entity.EventArgs.md)  
Assembly: Divine.dll  

```csharp
public ref struct PostDataUpdateEventArgs
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Properties

### <a id="Divine_Entity_EventArgs_PostDataUpdateEventArgs_Entities"></a> Entities

```csharp
public IEnumerable<Entity> Entities { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Entity](Divine.Entity.Entities.Entity.md)\>

### <a id="Divine_Entity_EventArgs_PostDataUpdateEventArgs_NativeEntities"></a> NativeEntities

```csharp
public readonly ReadOnlySpan<nint> NativeEntities { get; }
```

#### Property Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[nint](https://learn.microsoft.com/dotnet/api/system.intptr)\>

