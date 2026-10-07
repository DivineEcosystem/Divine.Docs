# <a id="Divine_Menu_Components_MenuTogglerValues"></a> Struct MenuTogglerValues

Namespace: [Divine.Menu.Components](Divine.Menu.Components.md)  
Assembly: Divine.dll  

```csharp
public readonly ref struct MenuTogglerValues
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Divine_Menu_Components_MenuTogglerValues__ctor_System_ReadOnlySpan_Divine_Menu_Components_MenuTogglerValue__"></a> MenuTogglerValues\(ReadOnlySpan<MenuTogglerValue\>\)

```csharp
public MenuTogglerValues(ReadOnlySpan<MenuTogglerValue> span)
```

#### Parameters

`span` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue.md)\>

## Fields

### <a id="Divine_Menu_Components_MenuTogglerValues_Span"></a> Span

```csharp
public readonly ReadOnlySpan<MenuTogglerValue> Span
```

#### Field Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue.md)\>

## Methods

### <a id="Divine_Menu_Components_MenuTogglerValues_Create_System_Span_System_String__"></a> Create\(Span<string\>\)

```csharp
public static MenuTogglerValues Create(Span<string> values)
```

#### Parameters

`values` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Returns

 [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues.md)

### <a id="Divine_Menu_Components_MenuTogglerValues_Create_System_ReadOnlySpan_Divine_Menu_Components_MenuTogglerValue__"></a> Create\(ReadOnlySpan<MenuTogglerValue\>\)

```csharp
public static MenuTogglerValues Create(ReadOnlySpan<MenuTogglerValue> values)
```

#### Parameters

`values` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue.md)\>

#### Returns

 [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues.md)

### <a id="Divine_Menu_Components_MenuTogglerValues_Create__1_System_Span___0__"></a> Create<T\>\(Span<T\>\)

```csharp
public static MenuTogglerValues<T> Create<T>(Span<T> values) where T : notnull
```

#### Parameters

`values` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<T\>

#### Returns

 [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="Divine_Menu_Components_MenuTogglerValues_Create__1_System_ReadOnlySpan_Divine_Menu_Components_MenuTogglerValue___0___"></a> Create<T\>\(ReadOnlySpan<MenuTogglerValue<T\>\>\)

```csharp
public static MenuTogglerValues<T> Create<T>(ReadOnlySpan<MenuTogglerValue<T>> values) where T : notnull
```

#### Parameters

`values` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue\-1.md)<T\>\>

#### Returns

 [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="Divine_Menu_Components_MenuTogglerValues_GetEnumerator"></a> GetEnumerator\(\)

```csharp
public ReadOnlySpan<MenuTogglerValue>.Enumerator GetEnumerator()
```

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue.md)\>.[Enumerator](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1.enumerator)

## Operators

### <a id="Divine_Menu_Components_MenuTogglerValues_op_Implicit_System_Collections_Generic_Dictionary_System_String_System_Boolean___Divine_Menu_Components_MenuTogglerValues"></a> implicit operator MenuTogglerValues\(Dictionary<string, bool\>\)

```csharp
public static implicit operator MenuTogglerValues(Dictionary<string, bool> values)
```

#### Parameters

`values` [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

#### Returns

 [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues.md)

### <a id="Divine_Menu_Components_MenuTogglerValues_op_Implicit_System_Collections_Generic_HashSet_System_String___Divine_Menu_Components_MenuTogglerValues"></a> implicit operator MenuTogglerValues\(HashSet<string\>\)

```csharp
public static implicit operator MenuTogglerValues(HashSet<string> values)
```

#### Parameters

`values` [HashSet](https://learn.microsoft.com/dotnet/api/system.collections.generic.hashset\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Returns

 [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues.md)

### <a id="Divine_Menu_Components_MenuTogglerValues_op_Implicit_System_Collections_Generic_List_System_String___Divine_Menu_Components_MenuTogglerValues"></a> implicit operator MenuTogglerValues\(List<string\>\)

```csharp
public static implicit operator MenuTogglerValues(List<string> values)
```

#### Parameters

`values` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Returns

 [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues.md)

### <a id="Divine_Menu_Components_MenuTogglerValues_op_Implicit_System_String____Divine_Menu_Components_MenuTogglerValues"></a> implicit operator MenuTogglerValues\(string\[\]\)

```csharp
public static implicit operator MenuTogglerValues(string[] values)
```

#### Parameters

`values` [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

#### Returns

 [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues.md)

### <a id="Divine_Menu_Components_MenuTogglerValues_op_Implicit_System_Span_System_String___Divine_Menu_Components_MenuTogglerValues"></a> implicit operator MenuTogglerValues\(Span<string\>\)

```csharp
public static implicit operator MenuTogglerValues(Span<string> values)
```

#### Parameters

`values` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Returns

 [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues.md)

### <a id="Divine_Menu_Components_MenuTogglerValues_op_Implicit_Divine_Menu_Components_MenuTogglerValue____Divine_Menu_Components_MenuTogglerValues"></a> implicit operator MenuTogglerValues\(MenuTogglerValue\[\]\)

```csharp
public static implicit operator MenuTogglerValues(MenuTogglerValue[] values)
```

#### Parameters

`values` [MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue.md)\[\]

#### Returns

 [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues.md)

