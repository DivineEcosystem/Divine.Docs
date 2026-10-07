# <a id="Divine_Menu_Components_MenuSelectorValue_1"></a> Class MenuSelectorValue<T\>

Namespace: [Divine.Menu.Components](Divine.Menu.Components.md)  
Assembly: Divine.dll  

```csharp
public class MenuSelectorValue<T> : MenuValue<string, T> where T : notnull
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuValue<string, T\>](Divine.Menu.Components.MenuValue\-2.md) ← 
[MenuSelectorValue<T\>](Divine.Menu.Components.MenuSelectorValue\-1.md)

#### Inherited Members

[MenuValue<string, T\>.Key](Divine.Menu.Components.MenuValue\-2.md\#Divine\_Menu\_Components\_MenuValue\_2\_Key), 
[MenuValue<string, T\>.Value](Divine.Menu.Components.MenuValue\-2.md\#Divine\_Menu\_Components\_MenuValue\_2\_Value), 
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
[EnumerableExtensions.In<MenuSelectorValue<T\>\>\(MenuSelectorValue<T\>, params MenuSelectorValue<T\>\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Menu_Components_MenuSelectorValue_1__ctor"></a> MenuSelectorValue\(\)

```csharp
public MenuSelectorValue()
```

### <a id="Divine_Menu_Components_MenuSelectorValue_1__ctor__0_"></a> MenuSelectorValue\(T\)

```csharp
[SetsRequiredMembers]
public MenuSelectorValue(T value)
```

#### Parameters

`value` T

### <a id="Divine_Menu_Components_MenuSelectorValue_1__ctor_System_String__0_"></a> MenuSelectorValue\(string, T\)

```csharp
[SetsRequiredMembers]
public MenuSelectorValue(string key, T value)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` T

## Operators

### <a id="Divine_Menu_Components_MenuSelectorValue_1_op_Implicit_System_ValueTuple_System_String__0___Divine_Menu_Components_MenuSelectorValue__0_"></a> implicit operator MenuSelectorValue<T\>\(\(string Key, T Value\)\)

```csharp
public static implicit operator MenuSelectorValue<T>((string Key, T Value) selectorValue)
```

#### Parameters

`selectorValue` \([string](https://learn.microsoft.com/dotnet/api/system.string) [Key](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,\-0\-.key), T [Value](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,\-0\-.value)\)

#### Returns

 [MenuSelectorValue](Divine.Menu.Components.MenuSelectorValue\-1.md)<T\>

### <a id="Divine_Menu_Components_MenuSelectorValue_1_op_Implicit_System_Collections_Generic_KeyValuePair_System_String__0___Divine_Menu_Components_MenuSelectorValue__0_"></a> implicit operator MenuSelectorValue<T\>\(KeyValuePair<string, T\>\)

```csharp
public static implicit operator MenuSelectorValue<T>(KeyValuePair<string, T> pair)
```

#### Parameters

`pair` [KeyValuePair](https://learn.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), T\>

#### Returns

 [MenuSelectorValue](Divine.Menu.Components.MenuSelectorValue\-1.md)<T\>

### <a id="Divine_Menu_Components_MenuSelectorValue_1_op_Implicit__0__Divine_Menu_Components_MenuSelectorValue__0_"></a> implicit operator MenuSelectorValue<T\>\(T\)

```csharp
public static implicit operator MenuSelectorValue<T>(T value)
```

#### Parameters

`value` T

#### Returns

 [MenuSelectorValue](Divine.Menu.Components.MenuSelectorValue\-1.md)<T\>

