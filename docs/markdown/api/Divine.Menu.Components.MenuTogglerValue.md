# <a id="Divine_Menu_Components_MenuTogglerValue"></a> Class MenuTogglerValue

Namespace: [Divine.Menu.Components](Divine.Menu.Components.md)  
Assembly: Divine.dll  

```csharp
public sealed class MenuTogglerValue : MenuTogglerValue<string>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuValue<string, bool\>](Divine.Menu.Components.MenuValue\-2.md) ← 
[MenuTogglerValue<string\>](Divine.Menu.Components.MenuTogglerValue\-1.md) ← 
[MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue.md)

#### Inherited Members

[MenuTogglerValue<string\>.ImageKey](Divine.Menu.Components.MenuTogglerValue\-1.md\#Divine\_Menu\_Components\_MenuTogglerValue\_1\_ImageKey), 
[MenuValue<string, bool\>.Key](Divine.Menu.Components.MenuValue\-2.md\#Divine\_Menu\_Components\_MenuValue\_2\_Key), 
[MenuValue<string, bool\>.Value](Divine.Menu.Components.MenuValue\-2.md\#Divine\_Menu\_Components\_MenuValue\_2\_Value), 
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
[EnumerableExtensions.In<MenuTogglerValue\>\(MenuTogglerValue, params MenuTogglerValue\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Menu_Components_MenuTogglerValue__ctor_System_String_System_Boolean_Divine_Menu_Components_MenuImageKey_"></a> MenuTogglerValue\(string, bool, MenuImageKey\)

```csharp
[SetsRequiredMembers]
public MenuTogglerValue(string key, bool value, MenuImageKey imageKey)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`imageKey` [MenuImageKey](Divine.Menu.Components.MenuImageKey.md)

### <a id="Divine_Menu_Components_MenuTogglerValue__ctor_System_String_"></a> MenuTogglerValue\(string\)

```csharp
[SetsRequiredMembers]
public MenuTogglerValue(string key)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Menu_Components_MenuTogglerValue__ctor_System_String_System_Boolean_"></a> MenuTogglerValue\(string, bool\)

```csharp
[SetsRequiredMembers]
public MenuTogglerValue(string key, bool value)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Operators

### <a id="Divine_Menu_Components_MenuTogglerValue_op_Implicit_System_ValueTuple_System_String_System_Boolean___Divine_Menu_Components_MenuTogglerValue"></a> implicit operator MenuTogglerValue\(\(string Key, bool Value\)\)

```csharp
public static implicit operator MenuTogglerValue((string Key, bool Value) togglerValue)
```

#### Parameters

`togglerValue` \([string](https://learn.microsoft.com/dotnet/api/system.string) [Key](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.boolean\-.key), [bool](https://learn.microsoft.com/dotnet/api/system.boolean) [Value](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.boolean\-.value)\)

#### Returns

 [MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue.md)

### <a id="Divine_Menu_Components_MenuTogglerValue_op_Implicit_System_ValueTuple_System_String_Divine_Menu_Components_MenuImageKey___Divine_Menu_Components_MenuTogglerValue"></a> implicit operator MenuTogglerValue\(\(string Key, MenuImageKey ImageKey\)\)

```csharp
public static implicit operator MenuTogglerValue((string Key, MenuImageKey ImageKey) togglerValue)
```

#### Parameters

`togglerValue` \([string](https://learn.microsoft.com/dotnet/api/system.string) [Key](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,divine.menu.components.menuimagekey\-.key), [MenuImageKey](Divine.Menu.Components.MenuImageKey.md) [ImageKey](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,divine.menu.components.menuimagekey\-.imagekey)\)

#### Returns

 [MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue.md)

### <a id="Divine_Menu_Components_MenuTogglerValue_op_Implicit_System_ValueTuple_System_String_System_Boolean_Divine_Menu_Components_MenuImageKey___Divine_Menu_Components_MenuTogglerValue"></a> implicit operator MenuTogglerValue\(\(string Key, bool Value, MenuImageKey ImageKey\)\)

```csharp
public static implicit operator MenuTogglerValue((string Key, bool Value, MenuImageKey ImageKey) togglerValue)
```

#### Parameters

`togglerValue` \([string](https://learn.microsoft.com/dotnet/api/system.string) [Key](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.boolean,divine.menu.components.menuimagekey\-.key), [bool](https://learn.microsoft.com/dotnet/api/system.boolean) [Value](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.boolean,divine.menu.components.menuimagekey\-.value), [MenuImageKey](Divine.Menu.Components.MenuImageKey.md) [ImageKey](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.boolean,divine.menu.components.menuimagekey\-.imagekey)\)

#### Returns

 [MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue.md)

### <a id="Divine_Menu_Components_MenuTogglerValue_op_Implicit_System_Collections_Generic_KeyValuePair_System_String_System_Boolean___Divine_Menu_Components_MenuTogglerValue"></a> implicit operator MenuTogglerValue\(KeyValuePair<string, bool\>\)

```csharp
public static implicit operator MenuTogglerValue(KeyValuePair<string, bool> pair)
```

#### Parameters

`pair` [KeyValuePair](https://learn.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

#### Returns

 [MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue.md)

### <a id="Divine_Menu_Components_MenuTogglerValue_op_Implicit_System_String__Divine_Menu_Components_MenuTogglerValue"></a> implicit operator MenuTogglerValue\(string\)

```csharp
public static implicit operator MenuTogglerValue(string key)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue.md)

