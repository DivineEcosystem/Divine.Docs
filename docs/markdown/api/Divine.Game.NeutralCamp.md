# <a id="Divine_Game_NeutralCamp"></a> Class NeutralCamp

Namespace: [Divine.Game](Divine.Game.md)  
Assembly: Divine.dll  

```csharp
public sealed class NeutralCamp
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[NeutralCamp](Divine.Game.NeutralCamp.md)

#### Inherited Members

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
[EnumerableExtensions.In<NeutralCamp\>\(NeutralCamp, params NeutralCamp\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Game_NeutralCamp_Box"></a> Box

```csharp
public BoundingBox Box { get; }
```

#### Property Value

 [BoundingBox](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/BoundingBox.cs)

### <a id="Divine_Game_NeutralCamp_CampType"></a> CampType

```csharp
public NeutralCampType CampType { get; }
```

#### Property Value

 [NeutralCampType](Divine.Game.NeutralCampType.md)

### <a id="Divine_Game_NeutralCamp_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Game_NeutralCamp_Spawner"></a> Spawner

```csharp
public Entity Spawner { get; }
```

#### Property Value

 [Entity](Divine.Entity.Entities.Entity.md)

### <a id="Divine_Game_NeutralCamp_SpawnPosition"></a> SpawnPosition

```csharp
public Vector3 SpawnPosition { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

## Methods

### <a id="Divine_Game_NeutralCamp_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override sealed string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

