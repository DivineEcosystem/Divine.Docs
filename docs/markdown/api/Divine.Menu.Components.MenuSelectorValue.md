# <a id="Divine_Menu_Components_MenuSelectorValue"></a> Class MenuSelectorValue

Namespace: [Divine.Menu.Components](Divine.Menu.Components.md)  
Assembly: Divine.dll  

```csharp
public class MenuSelectorValue : MenuSelectorValue<string>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuValue<string, string\>](Divine.Menu.Components.MenuValue\-2.md) ← 
[MenuSelectorValue<string\>](Divine.Menu.Components.MenuSelectorValue\-1.md) ← 
[MenuSelectorValue](Divine.Menu.Components.MenuSelectorValue.md)

#### Inherited Members

[MenuValue<string, string\>.Key](Divine.Menu.Components.MenuValue\-2.md\#Divine\_Menu\_Components\_MenuValue\_2\_Key), 
[MenuValue<string, string\>.Value](Divine.Menu.Components.MenuValue\-2.md\#Divine\_Menu\_Components\_MenuValue\_2\_Value), 
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
[EnumerableExtensions.In<MenuSelectorValue\>\(MenuSelectorValue, params MenuSelectorValue\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Menu_Components_MenuSelectorValue__ctor_System_String_System_String_"></a> MenuSelectorValue\(string, string\)

```csharp
[SetsRequiredMembers]
public MenuSelectorValue(string key, string value)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Menu_Components_MenuSelectorValue__ctor_System_String_"></a> MenuSelectorValue\(string\)

```csharp
[SetsRequiredMembers]
public MenuSelectorValue(string value)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Divine_Menu_Components_MenuSelectorValue_op_Implicit_System_ValueTuple_System_String_System_String___Divine_Menu_Components_MenuSelectorValue"></a> implicit operator MenuSelectorValue\(\(string Key, string Value\)\)

```csharp
public static implicit operator MenuSelectorValue((string Key, string Value) selectorValue)
```

#### Parameters

`selectorValue` \([string](https://learn.microsoft.com/dotnet/api/system.string) [Key](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.key), [string](https://learn.microsoft.com/dotnet/api/system.string) [Value](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.value)\)

#### Returns

 [MenuSelectorValue](Divine.Menu.Components.MenuSelectorValue.md)

### <a id="Divine_Menu_Components_MenuSelectorValue_op_Implicit_System_Collections_Generic_KeyValuePair_System_String_System_String___Divine_Menu_Components_MenuSelectorValue"></a> implicit operator MenuSelectorValue\(KeyValuePair<string, string\>\)

```csharp
public static implicit operator MenuSelectorValue(KeyValuePair<string, string> pair)
```

#### Parameters

`pair` [KeyValuePair](https://learn.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Returns

 [MenuSelectorValue](Divine.Menu.Components.MenuSelectorValue.md)

### <a id="Divine_Menu_Components_MenuSelectorValue_op_Implicit_System_String__Divine_Menu_Components_MenuSelectorValue"></a> implicit operator MenuSelectorValue\(string\)

```csharp
public static implicit operator MenuSelectorValue(string value)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [MenuSelectorValue](Divine.Menu.Components.MenuSelectorValue.md)

