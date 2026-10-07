# <a id="Divine_Menu_Components_MenuTogglerValues_1"></a> Struct MenuTogglerValues<T\>

Namespace: [Divine.Menu.Components](Divine.Menu.Components.md)  
Assembly: Divine.dll  

```csharp
public readonly ref struct MenuTogglerValues<T> where T : notnull
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

### <a id="Divine_Menu_Components_MenuTogglerValues_1__ctor_System_ReadOnlySpan_Divine_Menu_Components_MenuTogglerValue__0___"></a> MenuTogglerValues\(ReadOnlySpan<MenuTogglerValue<T\>\>\)

```csharp
public MenuTogglerValues(ReadOnlySpan<MenuTogglerValue<T>> span)
```

#### Parameters

`span` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue\-1.md)<T\>\>

## Fields

### <a id="Divine_Menu_Components_MenuTogglerValues_1_Span"></a> Span

```csharp
public readonly ReadOnlySpan<MenuTogglerValue<T>> Span
```

#### Field Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue\-1.md)<T\>\>

## Methods

### <a id="Divine_Menu_Components_MenuTogglerValues_1_GetEnumerator"></a> GetEnumerator\(\)

```csharp
public ReadOnlySpan<MenuTogglerValue<T>>.Enumerator GetEnumerator()
```

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue\-1.md)<T\>\>.[Enumerator](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1.enumerator)

## Operators

### <a id="Divine_Menu_Components_MenuTogglerValues_1_op_Implicit_System_Collections_Generic_Dictionary__0_System_Boolean___Divine_Menu_Components_MenuTogglerValues__0_"></a> implicit operator MenuTogglerValues<T\>\(Dictionary<T, bool\>\)

```csharp
public static implicit operator MenuTogglerValues<T>(Dictionary<T, bool> values)
```

#### Parameters

`values` [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<T, [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

#### Returns

 [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues\-1.md)<T\>

### <a id="Divine_Menu_Components_MenuTogglerValues_1_op_Implicit_System_Collections_Generic_HashSet__0___Divine_Menu_Components_MenuTogglerValues__0_"></a> implicit operator MenuTogglerValues<T\>\(HashSet<T\>\)

```csharp
public static implicit operator MenuTogglerValues<T>(HashSet<T> values)
```

#### Parameters

`values` [HashSet](https://learn.microsoft.com/dotnet/api/system.collections.generic.hashset\-1)<T\>

#### Returns

 [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues\-1.md)<T\>

### <a id="Divine_Menu_Components_MenuTogglerValues_1_op_Implicit_System_Collections_Generic_List__0___Divine_Menu_Components_MenuTogglerValues__0_"></a> implicit operator MenuTogglerValues<T\>\(List<T\>\)

```csharp
public static implicit operator MenuTogglerValues<T>(List<T> values)
```

#### Parameters

`values` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<T\>

#### Returns

 [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues\-1.md)<T\>

### <a id="Divine_Menu_Components_MenuTogglerValues_1_op_Implicit__0____Divine_Menu_Components_MenuTogglerValues__0_"></a> implicit operator MenuTogglerValues<T\>\(T\[\]\)

```csharp
public static implicit operator MenuTogglerValues<T>(T[] values)
```

#### Parameters

`values` T\[\]

#### Returns

 [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues\-1.md)<T\>

### <a id="Divine_Menu_Components_MenuTogglerValues_1_op_Implicit_System_Span__0___Divine_Menu_Components_MenuTogglerValues__0_"></a> implicit operator MenuTogglerValues<T\>\(Span<T\>\)

```csharp
public static implicit operator MenuTogglerValues<T>(Span<T> values)
```

#### Parameters

`values` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<T\>

#### Returns

 [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues\-1.md)<T\>

### <a id="Divine_Menu_Components_MenuTogglerValues_1_op_Implicit_Divine_Menu_Components_MenuTogglerValue__0_____Divine_Menu_Components_MenuTogglerValues__0_"></a> implicit operator MenuTogglerValues<T\>\(MenuTogglerValue<T\>\[\]\)

```csharp
public static implicit operator MenuTogglerValues<T>(MenuTogglerValue<T>[] values)
```

#### Parameters

`values` [MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue\-1.md)<T\>\[\]

#### Returns

 [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues\-1.md)<T\>

### <a id="Divine_Menu_Components_MenuTogglerValues_1_op_Implicit_Divine_Menu_Components_MenuTogglerValues__0___System_ReadOnlySpan_Divine_Menu_Components_MenuTogglerValue__0__"></a> implicit operator ReadOnlySpan<MenuTogglerValue<T\>\>\(MenuTogglerValues<T\>\)

```csharp
public static implicit operator ReadOnlySpan<MenuTogglerValue<T>>(MenuTogglerValues<T> values)
```

#### Parameters

`values` [MenuTogglerValues](Divine.Menu.Components.MenuTogglerValues\-1.md)<T\>

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[MenuTogglerValue](Divine.Menu.Components.MenuTogglerValue\-1.md)<T\>\>

