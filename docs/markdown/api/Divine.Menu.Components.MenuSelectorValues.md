# <a id="Divine_Menu_Components_MenuSelectorValues"></a> Struct MenuSelectorValues

Namespace: [Divine.Menu.Components](Divine.Menu.Components.md)  
Assembly: Divine.dll  

```csharp
public readonly ref struct MenuSelectorValues
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Divine_Menu_Components_MenuSelectorValues__ctor_System_ReadOnlySpan_Divine_Menu_Components_MenuSelectorValue__"></a> MenuSelectorValues\(ReadOnlySpan<MenuSelectorValue\>\)

```csharp
public MenuSelectorValues(ReadOnlySpan<MenuSelectorValue> span)
```

#### Parameters

`span` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuSelectorValue](Divine.Menu.Components.MenuSelectorValue.md)\>

## Fields

### <a id="Divine_Menu_Components_MenuSelectorValues_Span"></a> Span

```csharp
public readonly ReadOnlySpan<MenuSelectorValue> Span
```

#### Field Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuSelectorValue](Divine.Menu.Components.MenuSelectorValue.md)\>

## Methods

### <a id="Divine_Menu_Components_MenuSelectorValues_Create_System_Span_System_String__"></a> Create\(Span<string\>\)

```csharp
public static MenuSelectorValues Create(Span<string> values)
```

#### Parameters

`values` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Returns

 [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues.md)

### <a id="Divine_Menu_Components_MenuSelectorValues_Create_System_ReadOnlySpan_Divine_Menu_Components_MenuSelectorValue__"></a> Create\(ReadOnlySpan<MenuSelectorValue\>\)

```csharp
public static MenuSelectorValues Create(ReadOnlySpan<MenuSelectorValue> values)
```

#### Parameters

`values` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuSelectorValue](Divine.Menu.Components.MenuSelectorValue.md)\>

#### Returns

 [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues.md)

### <a id="Divine_Menu_Components_MenuSelectorValues_Create__1_System_Span___0__"></a> Create<T\>\(Span<T\>\)

```csharp
public static MenuSelectorValues<T> Create<T>(Span<T> values) where T : notnull
```

#### Parameters

`values` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<T\>

#### Returns

 [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="Divine_Menu_Components_MenuSelectorValues_Create__1_System_ReadOnlySpan_Divine_Menu_Components_MenuSelectorValue___0___"></a> Create<T\>\(ReadOnlySpan<MenuSelectorValue<T\>\>\)

```csharp
public static MenuSelectorValues<T> Create<T>(ReadOnlySpan<MenuSelectorValue<T>> values) where T : notnull
```

#### Parameters

`values` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuSelectorValue](Divine.Menu.Components.MenuSelectorValue\-1.md)<T\>\>

#### Returns

 [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="Divine_Menu_Components_MenuSelectorValues_GetEnumerator"></a> GetEnumerator\(\)

```csharp
public ReadOnlySpan<MenuSelectorValue>.Enumerator GetEnumerator()
```

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuSelectorValue](Divine.Menu.Components.MenuSelectorValue.md)\>.[Enumerator](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1.enumerator)

## Operators

### <a id="Divine_Menu_Components_MenuSelectorValues_op_Implicit_System_Collections_Generic_Dictionary_System_String_System_String___Divine_Menu_Components_MenuSelectorValues"></a> implicit operator MenuSelectorValues\(Dictionary<string, string\>\)

```csharp
public static implicit operator MenuSelectorValues(Dictionary<string, string> values)
```

#### Parameters

`values` [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Returns

 [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues.md)

### <a id="Divine_Menu_Components_MenuSelectorValues_op_Implicit_System_Collections_Generic_HashSet_System_String___Divine_Menu_Components_MenuSelectorValues"></a> implicit operator MenuSelectorValues\(HashSet<string\>\)

```csharp
public static implicit operator MenuSelectorValues(HashSet<string> values)
```

#### Parameters

`values` [HashSet](https://learn.microsoft.com/dotnet/api/system.collections.generic.hashset\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Returns

 [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues.md)

### <a id="Divine_Menu_Components_MenuSelectorValues_op_Implicit_System_Collections_Generic_List_System_String___Divine_Menu_Components_MenuSelectorValues"></a> implicit operator MenuSelectorValues\(List<string\>\)

```csharp
public static implicit operator MenuSelectorValues(List<string> values)
```

#### Parameters

`values` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Returns

 [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues.md)

### <a id="Divine_Menu_Components_MenuSelectorValues_op_Implicit_System_String____Divine_Menu_Components_MenuSelectorValues"></a> implicit operator MenuSelectorValues\(string\[\]\)

```csharp
public static implicit operator MenuSelectorValues(string[] values)
```

#### Parameters

`values` [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

#### Returns

 [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues.md)

### <a id="Divine_Menu_Components_MenuSelectorValues_op_Implicit_System_Span_System_String___Divine_Menu_Components_MenuSelectorValues"></a> implicit operator MenuSelectorValues\(Span<string\>\)

```csharp
public static implicit operator MenuSelectorValues(Span<string> values)
```

#### Parameters

`values` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Returns

 [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues.md)

### <a id="Divine_Menu_Components_MenuSelectorValues_op_Implicit_Divine_Menu_Components_MenuSelectorValue____Divine_Menu_Components_MenuSelectorValues"></a> implicit operator MenuSelectorValues\(MenuSelectorValue\[\]\)

```csharp
public static implicit operator MenuSelectorValues(MenuSelectorValue[] values)
```

#### Parameters

`values` [MenuSelectorValue](Divine.Menu.Components.MenuSelectorValue.md)\[\]

#### Returns

 [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues.md)

