# <a id="Divine_Menu_Components_MenuValue_2"></a> Class MenuValue<TKey, TValue\>

Namespace: [Divine.Menu.Components](Divine.Menu.Components.md)  
Assembly: Divine.dll  

```csharp
public class MenuValue<TKey, TValue>
```

#### Type Parameters

`TKey` 

`TValue` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuValue<TKey, TValue\>](Divine.Menu.Components.MenuValue\-2.md)

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
[EnumerableExtensions.In<MenuValue<TKey, TValue\>\>\(MenuValue<TKey, TValue\>, params MenuValue<TKey, TValue\>\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Menu_Components_MenuValue_2__ctor"></a> MenuValue\(\)

```csharp
public MenuValue()
```

### <a id="Divine_Menu_Components_MenuValue_2__ctor__0__1_"></a> MenuValue\(TKey, TValue\)

```csharp
[SetsRequiredMembers]
public MenuValue(TKey key, TValue value)
```

#### Parameters

`key` TKey

`value` TValue

## Properties

### <a id="Divine_Menu_Components_MenuValue_2_Key"></a> Key

```csharp
public required TKey Key { get; init; }
```

#### Property Value

 TKey

### <a id="Divine_Menu_Components_MenuValue_2_Value"></a> Value

```csharp
public required TValue Value { get; init; }
```

#### Property Value

 TValue

## Operators

### <a id="Divine_Menu_Components_MenuValue_2_op_Implicit_System_ValueTuple__0__1___Divine_Menu_Components_MenuValue__0__1_"></a> implicit operator MenuValue<TKey, TValue\>\(\(TKey Key, TValue Value\)\)

```csharp
public static implicit operator MenuValue<TKey, TValue>((TKey Key, TValue Value) menuValue)
```

#### Parameters

`menuValue` \(TKey [Key](https://learn.microsoft.com/dotnet/api/system.valuetuple\-\-0,\-1\-.key), TValue [Value](https://learn.microsoft.com/dotnet/api/system.valuetuple\-\-0,\-1\-.value)\)

#### Returns

 [MenuValue](Divine.Menu.Components.MenuValue\-2.md)<TKey, TValue\>

### <a id="Divine_Menu_Components_MenuValue_2_op_Implicit_System_Collections_Generic_KeyValuePair__0__1___Divine_Menu_Components_MenuValue__0__1_"></a> implicit operator MenuValue<TKey, TValue\>\(KeyValuePair<TKey, TValue\>\)

```csharp
public static implicit operator MenuValue<TKey, TValue>(KeyValuePair<TKey, TValue> pair)
```

#### Parameters

`pair` [KeyValuePair](https://learn.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair\-2)<TKey, TValue\>

#### Returns

 [MenuValue](Divine.Menu.Components.MenuValue\-2.md)<TKey, TValue\>

