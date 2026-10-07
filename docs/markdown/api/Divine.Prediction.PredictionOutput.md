# <a id="Divine_Prediction_PredictionOutput"></a> Class PredictionOutput

Namespace: [Divine.Prediction](Divine.Prediction.md)  
Assembly: Divine.dll  

```csharp
public class PredictionOutput
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PredictionOutput](Divine.Prediction.PredictionOutput.md)

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
[EnumerableExtensions.In<PredictionOutput\>\(PredictionOutput, params PredictionOutput\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Prediction_PredictionOutput_AoeTargetsHit"></a> AoeTargetsHit

```csharp
public IReadOnlyList<PredictionOutput> AoeTargetsHit { get; set; }
```

#### Property Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[PredictionOutput](Divine.Prediction.PredictionOutput.md)\>

### <a id="Divine_Prediction_PredictionOutput_ArrivalTime"></a> ArrivalTime

```csharp
public float ArrivalTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Prediction_PredictionOutput_CastPosition"></a> CastPosition

```csharp
public Vector3 CastPosition { get; set; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Prediction_PredictionOutput_CollisionResult"></a> CollisionResult

```csharp
public CollisionResult CollisionResult { get; set; }
```

#### Property Value

 [CollisionResult](Divine.Prediction.Collision.CollisionResult.md)

### <a id="Divine_Prediction_PredictionOutput_HitChance"></a> HitChance

```csharp
public HitChance HitChance { get; set; }
```

#### Property Value

 [HitChance](Divine.Prediction.HitChance.md)

### <a id="Divine_Prediction_PredictionOutput_Unit"></a> Unit

```csharp
public Unit Unit { get; set; }
```

#### Property Value

 [Unit](Divine.Entity.Entities.Units.Unit.md)

### <a id="Divine_Prediction_PredictionOutput_UnitPosition"></a> UnitPosition

```csharp
public Vector3 UnitPosition { get; set; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

