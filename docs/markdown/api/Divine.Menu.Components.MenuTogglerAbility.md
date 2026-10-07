# <a id="Divine_Menu_Components_MenuTogglerAbility"></a> Class MenuTogglerAbility

Namespace: [Divine.Menu.Components](Divine.Menu.Components.md)  
Assembly: Divine.dll  

```csharp
public sealed class MenuTogglerAbility : MenuTogglerValue<AbilityId>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuValue<AbilityId, bool\>](Divine.Menu.Components.MenuValue\-2.md) ← 
[MenuTogglerValue<AbilityId\>](Divine.Menu.Components.MenuTogglerValue\-1.md) ← 
[MenuTogglerAbility](Divine.Menu.Components.MenuTogglerAbility.md)

#### Inherited Members

[MenuTogglerValue<AbilityId\>.ImageKey](Divine.Menu.Components.MenuTogglerValue\-1.md\#Divine\_Menu\_Components\_MenuTogglerValue\_1\_ImageKey), 
[MenuValue<AbilityId, bool\>.Key](Divine.Menu.Components.MenuValue\-2.md\#Divine\_Menu\_Components\_MenuValue\_2\_Key), 
[MenuValue<AbilityId, bool\>.Value](Divine.Menu.Components.MenuValue\-2.md\#Divine\_Menu\_Components\_MenuValue\_2\_Value), 
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
[EnumerableExtensions.In<MenuTogglerAbility\>\(MenuTogglerAbility, params MenuTogglerAbility\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Menu_Components_MenuTogglerAbility__ctor_Divine_Entity_Entities_Abilities_Components_AbilityId_System_Boolean_"></a> MenuTogglerAbility\(AbilityId, bool\)

```csharp
[SetsRequiredMembers]
public MenuTogglerAbility(AbilityId key, bool value)
```

#### Parameters

`key` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Components_MenuTogglerAbility__ctor_Divine_Entity_Entities_Abilities_Components_AbilityId_"></a> MenuTogglerAbility\(AbilityId\)

```csharp
[SetsRequiredMembers]
public MenuTogglerAbility(AbilityId key)
```

#### Parameters

`key` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

## Operators

### <a id="Divine_Menu_Components_MenuTogglerAbility_op_Implicit_System_ValueTuple_Divine_Entity_Entities_Abilities_Components_AbilityId_System_Boolean___Divine_Menu_Components_MenuTogglerAbility"></a> implicit operator MenuTogglerAbility\(\(AbilityId Key, bool Value\)\)

```csharp
public static implicit operator MenuTogglerAbility((AbilityId Key, bool Value) togglerImage)
```

#### Parameters

`togglerImage` \([AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md) [Key](https://learn.microsoft.com/dotnet/api/system.valuetuple\-divine.entity.entities.abilities.components.abilityid,system.boolean\-.key), [bool](https://learn.microsoft.com/dotnet/api/system.boolean) [Value](https://learn.microsoft.com/dotnet/api/system.valuetuple\-divine.entity.entities.abilities.components.abilityid,system.boolean\-.value)\)

#### Returns

 [MenuTogglerAbility](Divine.Menu.Components.MenuTogglerAbility.md)

### <a id="Divine_Menu_Components_MenuTogglerAbility_op_Implicit_System_Collections_Generic_KeyValuePair_Divine_Entity_Entities_Abilities_Components_AbilityId_System_Boolean___Divine_Menu_Components_MenuTogglerAbility"></a> implicit operator MenuTogglerAbility\(KeyValuePair<AbilityId, bool\>\)

```csharp
public static implicit operator MenuTogglerAbility(KeyValuePair<AbilityId, bool> pair)
```

#### Parameters

`pair` [KeyValuePair](https://learn.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair\-2)<[AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md), [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

#### Returns

 [MenuTogglerAbility](Divine.Menu.Components.MenuTogglerAbility.md)

### <a id="Divine_Menu_Components_MenuTogglerAbility_op_Implicit_Divine_Entity_Entities_Abilities_Components_AbilityId__Divine_Menu_Components_MenuTogglerAbility"></a> implicit operator MenuTogglerAbility\(AbilityId\)

```csharp
public static implicit operator MenuTogglerAbility(AbilityId key)
```

#### Parameters

`key` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

#### Returns

 [MenuTogglerAbility](Divine.Menu.Components.MenuTogglerAbility.md)

