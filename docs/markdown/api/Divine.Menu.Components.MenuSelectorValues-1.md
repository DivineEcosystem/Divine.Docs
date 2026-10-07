# <a id="Divine_Menu_Components_MenuSelectorValues_1"></a> Struct MenuSelectorValues<T\>

Namespace: [Divine.Menu.Components](Divine.Menu.Components.md)  
Assembly: Divine.dll  

```csharp
public readonly ref struct MenuSelectorValues<T> where T : notnull
```

#### Type Parameters

`T` 

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Divine_Menu_Components_MenuSelectorValues_1__ctor_System_ReadOnlySpan_Divine_Menu_Components_MenuSelectorValue__0___"></a> MenuSelectorValues\(ReadOnlySpan<MenuSelectorValue<T\>\>\)

```csharp
public MenuSelectorValues(ReadOnlySpan<MenuSelectorValue<T>> span)
```

#### Parameters

`span` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuSelectorValue](Divine.Menu.Components.MenuSelectorValue\-1.md)<T\>\>

## Fields

### <a id="Divine_Menu_Components_MenuSelectorValues_1_Span"></a> Span

```csharp
public readonly ReadOnlySpan<MenuSelectorValue<T>> Span
```

#### Field Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuSelectorValue](Divine.Menu.Components.MenuSelectorValue\-1.md)<T\>\>

## Methods

### <a id="Divine_Menu_Components_MenuSelectorValues_1_GetEnumerator"></a> GetEnumerator\(\)

```csharp
public ReadOnlySpan<MenuSelectorValue<T>>.Enumerator GetEnumerator()
```

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuSelectorValue](Divine.Menu.Components.MenuSelectorValue\-1.md)<T\>\>.[Enumerator](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1.enumerator)

## Operators

### <a id="Divine_Menu_Components_MenuSelectorValues_1_op_Implicit_System_Collections_Generic_Dictionary_System_String__0___Divine_Menu_Components_MenuSelectorValues__0_"></a> implicit operator MenuSelectorValues<T\>\(Dictionary<string, T\>\)

```csharp
public static implicit operator MenuSelectorValues<T>(Dictionary<string, T> values)
```

#### Parameters

`values` [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), T\>

#### Returns

 [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues\-1.md)<T\>

### <a id="Divine_Menu_Components_MenuSelectorValues_1_op_Implicit_System_Collections_Generic_HashSet__0___Divine_Menu_Components_MenuSelectorValues__0_"></a> implicit operator MenuSelectorValues<T\>\(HashSet<T\>\)

```csharp
public static implicit operator MenuSelectorValues<T>(HashSet<T> values)
```

#### Parameters

`values` [HashSet](https://learn.microsoft.com/dotnet/api/system.collections.generic.hashset\-1)<T\>

#### Returns

 [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues\-1.md)<T\>

### <a id="Divine_Menu_Components_MenuSelectorValues_1_op_Implicit_System_Collections_Generic_List__0___Divine_Menu_Components_MenuSelectorValues__0_"></a> implicit operator MenuSelectorValues<T\>\(List<T\>\)

```csharp
public static implicit operator MenuSelectorValues<T>(List<T> values)
```

#### Parameters

`values` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<T\>

#### Returns

 [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues\-1.md)<T\>

### <a id="Divine_Menu_Components_MenuSelectorValues_1_op_Implicit__0____Divine_Menu_Components_MenuSelectorValues__0_"></a> implicit operator MenuSelectorValues<T\>\(T\[\]\)

```csharp
public static implicit operator MenuSelectorValues<T>(T[] values)
```

#### Parameters

`values` T\[\]

#### Returns

 [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues\-1.md)<T\>

### <a id="Divine_Menu_Components_MenuSelectorValues_1_op_Implicit_System_Span__0___Divine_Menu_Components_MenuSelectorValues__0_"></a> implicit operator MenuSelectorValues<T\>\(Span<T\>\)

```csharp
public static implicit operator MenuSelectorValues<T>(Span<T> values)
```

#### Parameters

`values` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<T\>

#### Returns

 [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues\-1.md)<T\>

### <a id="Divine_Menu_Components_MenuSelectorValues_1_op_Implicit_Divine_Menu_Components_MenuSelectorValue__0_____Divine_Menu_Components_MenuSelectorValues__0_"></a> implicit operator MenuSelectorValues<T\>\(MenuSelectorValue<T\>\[\]\)

```csharp
public static implicit operator MenuSelectorValues<T>(MenuSelectorValue<T>[] values)
```

#### Parameters

`values` [MenuSelectorValue](Divine.Menu.Components.MenuSelectorValue\-1.md)<T\>\[\]

#### Returns

 [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues\-1.md)<T\>

### <a id="Divine_Menu_Components_MenuSelectorValues_1_op_Implicit_Divine_Menu_Components_MenuSelectorValues__0___System_ReadOnlySpan_Divine_Menu_Components_MenuSelectorValue__0__"></a> implicit operator ReadOnlySpan<MenuSelectorValue<T\>\>\(MenuSelectorValues<T\>\)

```csharp
public static implicit operator ReadOnlySpan<MenuSelectorValue<T>>(MenuSelectorValues<T> values)
```

#### Parameters

`values` [MenuSelectorValues](Divine.Menu.Components.MenuSelectorValues\-1.md)<T\>

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuSelectorValue](Divine.Menu.Components.MenuSelectorValue\-1.md)<T\>\>

