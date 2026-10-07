# <a id="Divine_Modifier_Modifiers_Modifier"></a> Class Modifier

Namespace: [Divine.Modifier.Modifiers](Divine.Modifier.Modifiers.md)  
Assembly: Divine.dll  

```csharp
public sealed class Modifier : IEquatable<Modifier>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Modifier](Divine.Modifier.Modifiers.Modifier.md)

#### Implements

[IEquatable<Modifier\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

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
[EnumerableExtensions.In<Modifier\>\(Modifier, params Modifier\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Modifier_Modifiers_Modifier_Ability"></a> Ability

```csharp
public Ability? Ability { get; }
```

#### Property Value

 [Ability](Divine.Entity.Entities.Abilities.Ability.md)?

### <a id="Divine_Modifier_Modifiers_Modifier_Attributes"></a> Attributes

```csharp
public ModifierAttributes Attributes { get; }
```

#### Property Value

 [ModifierAttributes](Divine.Modifier.Modifiers.Components.ModifierAttributes.md)

### <a id="Divine_Modifier_Modifiers_Modifier_AuraOwner"></a> AuraOwner

```csharp
public Entity? AuraOwner { get; }
```

#### Property Value

 [Entity](Divine.Entity.Entities.Entity.md)?

### <a id="Divine_Modifier_Modifiers_Modifier_AuraRadius"></a> AuraRadius

```csharp
public float AuraRadius { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Modifier_Modifiers_Modifier_AuraSearchFlags"></a> AuraSearchFlags

```csharp
public int AuraSearchFlags { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Modifier_Modifiers_Modifier_AuraSearchTeam"></a> AuraSearchTeam

```csharp
public Team AuraSearchTeam { get; }
```

#### Property Value

 [Team](Divine.Entity.Entities.Components.Team.md)

### <a id="Divine_Modifier_Modifiers_Modifier_AuraSearchType"></a> AuraSearchType

```csharp
public short AuraSearchType { get; }
```

#### Property Value

 [short](https://learn.microsoft.com/dotnet/api/system.int16)

### <a id="Divine_Modifier_Modifiers_Modifier_CanParentBeAutoAttacked"></a> CanParentBeAutoAttacked

```csharp
[Obsolete("TODO")]
public bool CanParentBeAutoAttacked { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Modifier_Modifiers_Modifier_Caster"></a> Caster

```csharp
public Entity? Caster { get; }
```

#### Property Value

 [Entity](Divine.Entity.Entities.Entity.md)?

### <a id="Divine_Modifier_Modifiers_Modifier_ClassName"></a> ClassName

```csharp
[Obsolete("Valve remove this")]
public string ClassName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Modifier_Modifiers_Modifier_CreationTime"></a> CreationTime

```csharp
public float CreationTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Modifier_Modifiers_Modifier_DieTime"></a> DieTime

```csharp
public float DieTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Modifier_Modifiers_Modifier_Duration"></a> Duration

```csharp
public float Duration { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Modifier_Modifiers_Modifier_ElapsedTime"></a> ElapsedTime

```csharp
public float ElapsedTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Modifier_Modifiers_Modifier_Funcs"></a> Funcs

```csharp
public IEnumerable<ModifierFunc> Funcs { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[ModifierFunc](Divine.Modifier.Modifiers.Components.ModifierFunc.md)\>

### <a id="Divine_Modifier_Modifiers_Modifier_Index"></a> Index

```csharp
public int Index { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Modifier_Modifiers_Modifier_IsAllowIllusionDuplicate"></a> IsAllowIllusionDuplicate

```csharp
[Obsolete("TODO")]
public bool IsAllowIllusionDuplicate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Modifier_Modifiers_Modifier_IsAura"></a> IsAura

```csharp
public bool IsAura { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Modifier_Modifiers_Modifier_IsDebuff"></a> IsDebuff

```csharp
public bool IsDebuff { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Modifier_Modifiers_Modifier_IsHidden"></a> IsHidden

```csharp
public bool IsHidden { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Modifier_Modifiers_Modifier_IsPurgable"></a> IsPurgable

```csharp
public bool IsPurgable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Modifier_Modifiers_Modifier_IsPurgeException"></a> IsPurgeException

```csharp
[Obsolete("TODO")]
public bool IsPurgeException { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Modifier_Modifiers_Modifier_IsStunDebuff"></a> IsStunDebuff

```csharp
public bool IsStunDebuff { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Modifier_Modifiers_Modifier_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Modifier_Modifiers_Modifier_LastAppliedTime"></a> LastAppliedTime

```csharp
public float LastAppliedTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Modifier_Modifiers_Modifier_ModifierAuraName"></a> ModifierAuraName

```csharp
public string ModifierAuraName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Modifier_Modifiers_Modifier_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Modifier_Modifiers_Modifier_Native"></a> Native

```csharp
public nint Native { get; }
```

#### Property Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="Divine_Modifier_Modifiers_Modifier_Owner"></a> Owner

```csharp
public Entity Owner { get; }
```

#### Property Value

 [Entity](Divine.Entity.Entities.Entity.md)

### <a id="Divine_Modifier_Modifiers_Modifier_Particles"></a> Particles

```csharp
public IEnumerable<Particle> Particles { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Particle](Divine.Particle.Particles.Particle.md)\>

### <a id="Divine_Modifier_Modifiers_Modifier_RemainingTime"></a> RemainingTime

```csharp
public float RemainingTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Modifier_Modifiers_Modifier_StackCount"></a> StackCount

```csharp
public int StackCount { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Modifier_Modifiers_Modifier_Team"></a> Team

```csharp
public Team Team { get; }
```

#### Property Value

 [Team](Divine.Entity.Entities.Components.Team.md)

### <a id="Divine_Modifier_Modifiers_Modifier_TextureName"></a> TextureName

```csharp
public string TextureName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Modifier_Modifiers_Modifier_Equals_System_Object_"></a> Equals\(object?\)

Determines whether the specified object is equal to the current object.

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The object to compare with the current object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the specified object  is equal to the current object; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="Divine_Modifier_Modifiers_Modifier_Equals_Divine_Modifier_Modifiers_Modifier_"></a> Equals\(Modifier?\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(Modifier? other)
```

#### Parameters

`other` [Modifier](Divine.Modifier.Modifiers.Modifier.md)?

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="Divine_Modifier_Modifiers_Modifier_GetFuncs_Divine_Modifier_Modifiers_Components_ModifierFuncParams_"></a> GetFuncs\(ModifierFuncParams?\)

```csharp
public IReadOnlyList<ModifierFunc> GetFuncs(ModifierFuncParams? @params = null)
```

#### Parameters

`params` [ModifierFuncParams](Divine.Modifier.Modifiers.Components.ModifierFuncParams.md)?

#### Returns

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[ModifierFunc](Divine.Modifier.Modifiers.Components.ModifierFunc.md)\>

### <a id="Divine_Modifier_Modifiers_Modifier_GetFuncValue_Divine_Modifier_Modifiers_Components_ModifierFuncId_Divine_Modifier_Modifiers_Components_ModifierFuncParams_"></a> GetFuncValue\(ModifierFuncId, ModifierFuncParams?\)

```csharp
public ModifierFuncValue GetFuncValue(ModifierFuncId id, ModifierFuncParams? @params = null)
```

#### Parameters

`id` [ModifierFuncId](Divine.Modifier.Modifiers.Components.ModifierFuncId.md)

`params` [ModifierFuncParams](Divine.Modifier.Modifiers.Components.ModifierFuncParams.md)?

#### Returns

 [ModifierFuncValue](Divine.Modifier.Modifiers.Components.ModifierFuncValue.md)

### <a id="Divine_Modifier_Modifiers_Modifier_GetHashCode"></a> GetHashCode\(\)

Serves as the default hash function.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A hash code for the current object.

### <a id="Divine_Modifier_Modifiers_Modifier_HasFunc_Divine_Modifier_Modifiers_Components_ModifierFuncId_"></a> HasFunc\(ModifierFuncId\)

```csharp
public bool HasFunc(ModifierFuncId id)
```

#### Parameters

`id` [ModifierFuncId](Divine.Modifier.Modifiers.Components.ModifierFuncId.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Modifier_Modifiers_Modifier_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

### <a id="Divine_Modifier_Modifiers_Modifier_TryGetFuncValue_Divine_Modifier_Modifiers_Components_ModifierFuncId_Divine_Modifier_Modifiers_Components_ModifierFuncValue__"></a> TryGetFuncValue\(ModifierFuncId, out ModifierFuncValue\)

```csharp
public bool TryGetFuncValue(ModifierFuncId id, out ModifierFuncValue funcValue)
```

#### Parameters

`id` [ModifierFuncId](Divine.Modifier.Modifiers.Components.ModifierFuncId.md)

`funcValue` [ModifierFuncValue](Divine.Modifier.Modifiers.Components.ModifierFuncValue.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Modifier_Modifiers_Modifier_TryGetFuncValue_Divine_Modifier_Modifiers_Components_ModifierFuncId_Divine_Modifier_Modifiers_Components_ModifierFuncParams_Divine_Modifier_Modifiers_Components_ModifierFuncValue__"></a> TryGetFuncValue\(ModifierFuncId, ModifierFuncParams?, out ModifierFuncValue\)

```csharp
public bool TryGetFuncValue(ModifierFuncId id, ModifierFuncParams? @params, out ModifierFuncValue funcValue)
```

#### Parameters

`id` [ModifierFuncId](Divine.Modifier.Modifiers.Components.ModifierFuncId.md)

`params` [ModifierFuncParams](Divine.Modifier.Modifiers.Components.ModifierFuncParams.md)?

`funcValue` [ModifierFuncValue](Divine.Modifier.Modifiers.Components.ModifierFuncValue.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Operators

### <a id="Divine_Modifier_Modifiers_Modifier_op_Equality_Divine_Modifier_Modifiers_Modifier_Divine_Modifier_Modifiers_Modifier_"></a> operator ==\(Modifier?, Modifier?\)

```csharp
public static bool operator ==(Modifier? left, Modifier? right)
```

#### Parameters

`left` [Modifier](Divine.Modifier.Modifiers.Modifier.md)?

`right` [Modifier](Divine.Modifier.Modifiers.Modifier.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Modifier_Modifiers_Modifier_op_Inequality_Divine_Modifier_Modifiers_Modifier_Divine_Modifier_Modifiers_Modifier_"></a> operator \!=\(Modifier?, Modifier?\)

```csharp
public static bool operator !=(Modifier? left, Modifier? right)
```

#### Parameters

`left` [Modifier](Divine.Modifier.Modifiers.Modifier.md)?

`right` [Modifier](Divine.Modifier.Modifiers.Modifier.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

