# <a id="Divine_Entity_Entities_Units_Components_ModifierStatus"></a> Class ModifierStatus

Namespace: [Divine.Entity.Entities.Units.Components](Divine.Entity.Entities.Units.Components.md)  
Assembly: Divine.dll  

```csharp
public sealed class ModifierStatus
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ModifierStatus](Divine.Entity.Entities.Units.Components.ModifierStatus.md)

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
[EnumerableExtensions.In<ModifierStatus\>\(ModifierStatus, params ModifierStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Entity_Entities_Units_Components_ModifierStatus_Buffs"></a> Buffs

```csharp
public IEnumerable<Modifier> Buffs { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Modifier](Divine.Modifier.Modifiers.Modifier.md)\>

### <a id="Divine_Entity_Entities_Units_Components_ModifierStatus_Debuffs"></a> Debuffs

```csharp
public IEnumerable<Modifier> Debuffs { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Modifier](Divine.Modifier.Modifiers.Modifier.md)\>

### <a id="Divine_Entity_Entities_Units_Components_ModifierStatus_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Units_Components_ModifierStatus_Modifiers"></a> Modifiers

```csharp
public IEnumerable<Modifier> Modifiers { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Modifier](Divine.Modifier.Modifiers.Modifier.md)\>

### <a id="Divine_Entity_Entities_Units_Components_ModifierStatus_Owner"></a> Owner

```csharp
public Unit Owner { get; }
```

#### Property Value

 [Unit](Divine.Entity.Entities.Units.Unit.md)

## Methods

### <a id="Divine_Entity_Entities_Units_Components_ModifierStatus_GetBuffsByName_System_String_"></a> GetBuffsByName\(string\)

```csharp
public IEnumerable<Modifier> GetBuffsByName(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Modifier](Divine.Modifier.Modifiers.Modifier.md)\>

### <a id="Divine_Entity_Entities_Units_Components_ModifierStatus_GetDebuffsByName_System_String_"></a> GetDebuffsByName\(string\)

```csharp
public IEnumerable<Modifier> GetDebuffsByName(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Modifier](Divine.Modifier.Modifiers.Modifier.md)\>

### <a id="Divine_Entity_Entities_Units_Components_ModifierStatus_GetModifierByIndex_System_Int32_"></a> GetModifierByIndex\(int\)

```csharp
public Modifier? GetModifierByIndex(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Modifier](Divine.Modifier.Modifiers.Modifier.md)?

### <a id="Divine_Entity_Entities_Units_Components_ModifierStatus_GetModifierByName_System_String_"></a> GetModifierByName\(string\)

```csharp
public Modifier? GetModifierByName(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Modifier](Divine.Modifier.Modifiers.Modifier.md)?

### <a id="Divine_Entity_Entities_Units_Components_ModifierStatus_GetModifiersByName_System_String_"></a> GetModifiersByName\(string\)

```csharp
public IEnumerable<Modifier> GetModifiersByName(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Modifier](Divine.Modifier.Modifiers.Modifier.md)\>

