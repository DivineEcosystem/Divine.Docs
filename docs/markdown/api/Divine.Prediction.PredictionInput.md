# <a id="Divine_Prediction_PredictionInput"></a> Class PredictionInput

Namespace: [Divine.Prediction](Divine.Prediction.md)  
Assembly: Divine.dll  

```csharp
public class PredictionInput
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PredictionInput](Divine.Prediction.PredictionInput.md)

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
[EnumerableExtensions.In<PredictionInput\>\(PredictionInput, params PredictionInput\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Prediction_PredictionInput__ctor"></a> PredictionInput\(\)

```csharp
public PredictionInput()
```

### <a id="Divine_Prediction_PredictionInput__ctor_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Units_Unit_System_Single_System_Single_System_Single_System_Single_Divine_Prediction_PredictionSkillshotType_System_Boolean_System_Collections_Generic_IReadOnlyList_Divine_Entity_Entities_Units_Unit__System_Boolean_"></a> PredictionInput\(Unit, Unit, float, float, float, float, PredictionSkillshotType, bool, IReadOnlyList<Unit\>, bool\)

```csharp
public PredictionInput(Unit owner, Unit target, float delay, float speed, float range, float radius, PredictionSkillshotType type, bool areaOfEffect = false, IReadOnlyList<Unit> aoeTargets = null, bool areaOfEffectHitMainTarget = true)
```

#### Parameters

`owner` [Unit](Divine.Entity.Entities.Units.Unit.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`delay` [float](https://learn.microsoft.com/dotnet/api/system.single)

`speed` [float](https://learn.microsoft.com/dotnet/api/system.single)

`range` [float](https://learn.microsoft.com/dotnet/api/system.single)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`type` [PredictionSkillshotType](Divine.Prediction.PredictionSkillshotType.md)

`areaOfEffect` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`aoeTargets` [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[Unit](Divine.Entity.Entities.Units.Unit.md)\>

`areaOfEffectHitMainTarget` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Prediction_PredictionInput__ctor_Divine_Entity_Entities_Units_Unit_Divine_Entity_Entities_Units_Unit_System_Single_System_Single_System_Single_System_Single_"></a> PredictionInput\(Unit, Unit, float, float, float, float\)

```csharp
public PredictionInput(Unit owner, Unit target, float delay, float speed, float range, float radius)
```

#### Parameters

`owner` [Unit](Divine.Entity.Entities.Units.Unit.md)

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`delay` [float](https://learn.microsoft.com/dotnet/api/system.single)

`speed` [float](https://learn.microsoft.com/dotnet/api/system.single)

`range` [float](https://learn.microsoft.com/dotnet/api/system.single)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="Divine_Prediction_PredictionInput_AreaOfEffect"></a> AreaOfEffect

```csharp
public bool AreaOfEffect { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Prediction_PredictionInput_AreaOfEffectHitMainTarget"></a> AreaOfEffectHitMainTarget

```csharp
public bool AreaOfEffectHitMainTarget { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Prediction_PredictionInput_AreaOfEffectTargets"></a> AreaOfEffectTargets

```csharp
public IReadOnlyList<Unit> AreaOfEffectTargets { get; set; }
```

#### Property Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[Unit](Divine.Entity.Entities.Units.Unit.md)\>

### <a id="Divine_Prediction_PredictionInput_CollisionTypes"></a> CollisionTypes

```csharp
public CollisionTypes CollisionTypes { get; set; }
```

#### Property Value

 [CollisionTypes](Divine.Prediction.Collision.CollisionTypes.md)

### <a id="Divine_Prediction_PredictionInput_Delay"></a> Delay

```csharp
public float Delay { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Prediction_PredictionInput_Owner"></a> Owner

```csharp
public Unit Owner { get; set; }
```

#### Property Value

 [Unit](Divine.Entity.Entities.Units.Unit.md)

### <a id="Divine_Prediction_PredictionInput_PredictionSkillshotType"></a> PredictionSkillshotType

```csharp
public PredictionSkillshotType PredictionSkillshotType { get; set; }
```

#### Property Value

 [PredictionSkillshotType](Divine.Prediction.PredictionSkillshotType.md)

### <a id="Divine_Prediction_PredictionInput_Radius"></a> Radius

```csharp
public float Radius { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Prediction_PredictionInput_Range"></a> Range

```csharp
public float Range { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Prediction_PredictionInput_Speed"></a> Speed

```csharp
public float Speed { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Prediction_PredictionInput_Target"></a> Target

```csharp
public Unit Target { get; }
```

#### Property Value

 [Unit](Divine.Entity.Entities.Units.Unit.md)

## Methods

### <a id="Divine_Prediction_PredictionInput_WithTarget_Divine_Entity_Entities_Units_Unit_"></a> WithTarget\(Unit\)

```csharp
public PredictionInput WithTarget(Unit target)
```

#### Parameters

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [PredictionInput](Divine.Prediction.PredictionInput.md)

