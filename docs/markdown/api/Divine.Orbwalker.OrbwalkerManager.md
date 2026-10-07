# <a id="Divine_Orbwalker_OrbwalkerManager"></a> Class OrbwalkerManager

Namespace: [Divine.Orbwalker](Divine.Orbwalker.md)  
Assembly: Divine.dll  

```csharp
public static class OrbwalkerManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[OrbwalkerManager](Divine.Orbwalker.OrbwalkerManager.md)

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

## Methods

### <a id="Divine_Orbwalker_OrbwalkerManager_Attack_Divine_Entity_Entities_Units_Unit_System_Single_"></a> Attack\(Unit, float\)

```csharp
public static bool Attack(Unit unit, float time)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`time` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Orbwalker_OrbwalkerManager_Attack_Divine_Entity_Entities_Units_Unit_"></a> Attack\(Unit\)

```csharp
public static bool Attack(Unit unit)
```

#### Parameters

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Orbwalker_OrbwalkerManager_CanAttack_Divine_Entity_Entities_Units_Unit_System_Single_"></a> CanAttack\(Unit, float\)

```csharp
public static bool CanAttack(Unit target, float time)
```

#### Parameters

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`time` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Orbwalker_OrbwalkerManager_CanAttack_Divine_Entity_Entities_Units_Unit_"></a> CanAttack\(Unit\)

```csharp
public static bool CanAttack(Unit target)
```

#### Parameters

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Orbwalker_OrbwalkerManager_CanMove_System_Single_"></a> CanMove\(float\)

```csharp
public static bool CanMove(float time)
```

#### Parameters

`time` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Orbwalker_OrbwalkerManager_CanMove"></a> CanMove\(\)

```csharp
public static bool CanMove()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Orbwalker_OrbwalkerManager_GetTurnTime_Divine_Entity_Entities_Entity_System_Single_"></a> GetTurnTime\(Entity, float\)

```csharp
public static float GetTurnTime(Entity unit, float time)
```

#### Parameters

`unit` [Entity](Divine.Entity.Entities.Entity.md)

`time` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Orbwalker_OrbwalkerManager_GetTurnTime_Divine_Entity_Entities_Entity_"></a> GetTurnTime\(Entity\)

```csharp
public static float GetTurnTime(Entity unit)
```

#### Parameters

`unit` [Entity](Divine.Entity.Entities.Entity.md)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Orbwalker_OrbwalkerManager_Move_System_Numerics_Vector3_System_Single_"></a> Move\(Vector3, float\)

```csharp
public static bool Move(Vector3 position, float time)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`time` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Orbwalker_OrbwalkerManager_Move_System_Numerics_Vector3_"></a> Move\(Vector3\)

```csharp
public static bool Move(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Orbwalker_OrbwalkerManager_OrbwalkTo_Divine_Entity_Entities_Units_Unit_System_Numerics_Vector3_"></a> OrbwalkTo\(Unit, Vector3\)

```csharp
public static bool OrbwalkTo(Unit target, Vector3 position)
```

#### Parameters

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Orbwalker_OrbwalkerManager_OrbwalkTo_Divine_Entity_Entities_Units_Unit_"></a> OrbwalkTo\(Unit\)

```csharp
public static bool OrbwalkTo(Unit target)
```

#### Parameters

`target` [Unit](Divine.Entity.Entities.Units.Unit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

