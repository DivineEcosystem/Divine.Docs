# <a id="Divine_Menu_Components_MenuTogglerValue_1"></a> Class MenuTogglerValue<T\>

Namespace: [Divine.Menu.Components](Divine.Menu.Components.md)  
Assembly: Divine.dll  

```csharp
public class MenuTogglerValue<T> : MenuValue<T, bool> where T : notnull
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuValue<T, bool\>](Divine.Menu.Components.MenuValue\-2.md) ← 
[MenuTogglerValue<T\>](Divine.Menu.Components.MenuTogglerValue\-1.md)

#### Inherited Members

[MenuValue<T, bool\>.Key](Divine.Menu.Components.MenuValue\-2.md\#Divine\_Menu\_Components\_MenuValue\_2\_Key), 
[MenuValue<T, bool\>.Value](Divine.Menu.Components.MenuValue\-2.md\#Divine\_Menu\_Components\_MenuValue\_2\_Value), 
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
[EnumerableExtensions.In<MenuTogglerValue<T\>\>\(MenuTogglerValue<T\>, params MenuTogglerValue<T\>\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Menu_Components_MenuTogglerValue_1__ctor__0_System_Boolean_Divine_Menu_Components_MenuImageKey_"></a> MenuTogglerValue\(T, bool, MenuImageKey\)

```csharp
[SetsRequiredMembers]
public MenuTogglerValue(T key, bool value, MenuImageKey imageKey)
```

#### Parameters

`key` T

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`imageKey` [MenuImageKey](Divine.Menu.Components.MenuImageKey.md)

### <a id="Divine_Menu_Components_MenuTogglerValue_1__ctor__0_"></a> MenuTogglerValue\(T\)

```csharp
[SetsRequiredMembers]
public MenuTogglerValue(T key)
```

#### Parameters

`key` T

### <a id="Divine_Menu_Components_MenuTogglerValue_1__ctor__0_System_Boolean_"></a> MenuTogglerValue\(T, bool\)

```csharp
[SetsRequiredMembers]
public MenuTogglerValue(T key, bool value)
```

#### Parameters

`key` T

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Properties

### <a id="Divine_Menu_Components_MenuTogglerValue_1_ImageKey"></a> ImageKey

```csharp
public required MenuImageKey ImageKey { get; init; }
```

#### Property Value

 [MenuImageKey](Divine.Menu.Components.MenuImageKey.md)

## Operators

### <a id="Divine_Menu_Components_MenuTogglerValue_1_op_Implicit_System_ValueTuple__0_System_Boolean___Divine_Menu_Components_MenuTogglerValue__0_"></a> implicit operator MenuTogglerValue<T\>\(\(T Key, bool Value\)\)

```csharp
public static implicit operator MenuTogglerValue<T>((T Key, bool Value) togglerValue)
```

#### Parameters

`togglerValue` \(T [Key](https://learn.microsoft.com/dotnet/api/system.valuetuple\-\-0,system.boolean\-.key), [bool](https://learn.microsoft.com/dotnet/api/system.boolean) [Value](https://learn.microsoft.com/dotnet/api/system.valuetuple\-\-0,system.boolean\-.value)\)

#### Returns

 [MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue\-1.md)<T\>

### <a id="Divine_Menu_Components_MenuTogglerValue_1_op_Implicit_System_ValueTuple__0_Divine_Menu_Components_MenuImageKey___Divine_Menu_Components_MenuTogglerValue__0_"></a> implicit operator MenuTogglerValue<T\>\(\(T Key, MenuImageKey ImageKey\)\)

```csharp
public static implicit operator MenuTogglerValue<T>((T Key, MenuImageKey ImageKey) togglerValue)
```

#### Parameters

`togglerValue` \(T [Key](https://learn.microsoft.com/dotnet/api/system.valuetuple\-\-0,divine.menu.components.menuimagekey\-.key), [MenuImageKey](Divine.Menu.Components.MenuImageKey.md) [ImageKey](https://learn.microsoft.com/dotnet/api/system.valuetuple\-\-0,divine.menu.components.menuimagekey\-.imagekey)\)

#### Returns

 [MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue\-1.md)<T\>

### <a id="Divine_Menu_Components_MenuTogglerValue_1_op_Implicit_System_ValueTuple__0_System_Boolean_Divine_Menu_Components_MenuImageKey___Divine_Menu_Components_MenuTogglerValue__0_"></a> implicit operator MenuTogglerValue<T\>\(\(T Key, bool Value, MenuImageKey ImageKey\)\)

```csharp
public static implicit operator MenuTogglerValue<T>((T Key, bool Value, MenuImageKey ImageKey) togglerValue)
```

#### Parameters

`togglerValue` \(T [Key](https://learn.microsoft.com/dotnet/api/system.valuetuple\-\-0,system.boolean,divine.menu.components.menuimagekey\-.key), [bool](https://learn.microsoft.com/dotnet/api/system.boolean) [Value](https://learn.microsoft.com/dotnet/api/system.valuetuple\-\-0,system.boolean,divine.menu.components.menuimagekey\-.value), [MenuImageKey](Divine.Menu.Components.MenuImageKey.md) [ImageKey](https://learn.microsoft.com/dotnet/api/system.valuetuple\-\-0,system.boolean,divine.menu.components.menuimagekey\-.imagekey)\)

#### Returns

 [MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue\-1.md)<T\>

### <a id="Divine_Menu_Components_MenuTogglerValue_1_op_Implicit_System_Collections_Generic_KeyValuePair__0_System_Boolean___Divine_Menu_Components_MenuTogglerValue__0_"></a> implicit operator MenuTogglerValue<T\>\(KeyValuePair<T, bool\>\)

```csharp
public static implicit operator MenuTogglerValue<T>(KeyValuePair<T, bool> pair)
```

#### Parameters

`pair` [KeyValuePair](https://learn.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair\-2)<T, [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

#### Returns

 [MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue\-1.md)<T\>

### <a id="Divine_Menu_Components_MenuTogglerValue_1_op_Implicit__0__Divine_Menu_Components_MenuTogglerValue__0_"></a> implicit operator MenuTogglerValue<T\>\(T\)

```csharp
public static implicit operator MenuTogglerValue<T>(T key)
```

#### Parameters

`key` T

#### Returns

 [MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue\-1.md)<T\>

