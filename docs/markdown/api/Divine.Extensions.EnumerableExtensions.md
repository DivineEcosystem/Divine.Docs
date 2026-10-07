# <a id="Divine_Extensions_EnumerableExtensions"></a> Class EnumerableExtensions

Namespace: [Divine.Extensions](Divine.Extensions.md)  
Assembly: Divine.dll  

```csharp
public static class EnumerableExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EnumerableExtensions](Divine.Extensions.EnumerableExtensions.md)

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
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_)

## Methods

### <a id="Divine_Extensions_EnumerableExtensions_ClearFlags__1___0___0_"></a> ClearFlags<T\>\(T, T\)

Clears all given flags from a specific struct source.

```csharp
public static T ClearFlags<T>(this T value, T flags) where T : struct
```

#### Parameters

`value` T

The enumeration

`flags` T

Flags to be cleared

#### Returns

 T

Enumeration with Flag Attributes (struct)

#### Type Parameters

`T` 

Flag with Attributes type.

### <a id="Divine_Extensions_EnumerableExtensions_CombineFlags__1_System_Collections_Generic_IEnumerable___0__"></a> CombineFlags<T\>\(IEnumerable<T\>\)

Combines flags from an enumerable list to a new given struct source.

```csharp
public static T CombineFlags<T>(this IEnumerable<T> flags) where T : struct
```

#### Parameters

`flags` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

The flags

#### Returns

 T

Enumeration with Flag Attributes (struct)

#### Type Parameters

`T` 

Flag with Attributes type.

### <a id="Divine_Extensions_EnumerableExtensions_Find__1_System_Collections_Generic_IEnumerable___0__System_Predicate___0__"></a> Find<TSource\>\(IEnumerable<TSource\>, Predicate<TSource\>\)

```csharp
public static TSource Find<TSource>(this IEnumerable<TSource> source, Predicate<TSource> match)
```

#### Parameters

`source` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<TSource\>

`match` [Predicate](https://learn.microsoft.com/dotnet/api/system.predicate\-1)<TSource\>

#### Returns

 TSource

#### Type Parameters

`TSource` 

### <a id="Divine_Extensions_EnumerableExtensions_GetCombinations_System_Collections_Generic_IReadOnlyCollection_System_Numerics_Vector2__"></a> GetCombinations\(IReadOnlyCollection<Vector2\>\)

Returns all the subgroup combinations that can be made from a group

```csharp
public static IEnumerable<List<Vector2>> GetCombinations(this IReadOnlyCollection<Vector2> allValues)
```

#### Parameters

`allValues` [IReadOnlyCollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1)<[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\>

List of <xref href="System.Numerics.Vector2" data-throw-if-not-resolved="false"></xref>

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\>\>

Double list of vectors.

### <a id="Divine_Extensions_EnumerableExtensions_GetFlagDescription__1___0_"></a> GetFlagDescription<T\>\(T\)

Gets a flag attribute description.

```csharp
public static string GetFlagDescription<T>(this T value) where T : struct
```

#### Parameters

`value` T

The enumeration

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

Enumeration with Flag Attributes (struct)

#### Type Parameters

`T` 

Flag with Attributes type.

### <a id="Divine_Extensions_EnumerableExtensions_GetFlags__1___0_"></a> GetFlags<T\>\(T\)

Retrieves all of the flags from a specific struct source.

```csharp
public static IEnumerable<T> GetFlags<T>(this T value) where T : struct
```

#### Parameters

`value` T

The enumeration

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

Enumeration with Flag Attributes (struct)

#### Type Parameters

`T` 

Flag with Attributes type.

### <a id="Divine_Extensions_EnumerableExtensions_In__1___0___0___"></a> In<T\>\(T, params T\[\]\)

Determines if a list contains any of the values.

```csharp
public static bool In<T>(this T source, params T[] list)
```

#### Parameters

`source` T

Container of objects

`list` T\[\]

Any object that should be in the container

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

If the container contains any values.

#### Type Parameters

`T` 

Type of object to look for

### <a id="Divine_Extensions_EnumerableExtensions_MaxOrDefault__2_System_Collections_Generic_IEnumerable___0__System_Func___0___1__"></a> MaxOrDefault<T, TR\>\(IEnumerable<T\>, Func<T, TR\>\)

Gets the maximum value of an IEnumerable by the comparer, or returns the default.

```csharp
public static T MaxOrDefault<T, TR>(this IEnumerable<T> container, Func<T, TR> comparer) where TR : IComparable
```

#### Parameters

`container` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

Container of values to search through

`comparer` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<T, TR\>

Function to compare values

#### Returns

 T

The maximums of the objects

#### Type Parameters

`T` 

Type of object

`TR` 

Type result of comparer

### <a id="Divine_Extensions_EnumerableExtensions_MinOrDefault__2_System_Collections_Generic_IEnumerable___0__System_Func___0___1__"></a> MinOrDefault<T, TR\>\(IEnumerable<T\>, Func<T, TR\>\)

Gets the minimum value of an IEnumerable by the comparer, or returns the default.

```csharp
public static T MinOrDefault<T, TR>(this IEnumerable<T> container, Func<T, TR> comparer) where TR : IComparable
```

#### Parameters

`container` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

Container of values to search through

`comparer` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<T, TR\>

Function to compare the values

#### Returns

 T

The minimum of the objects

#### Type Parameters

`T` 

Type of object

`TR` 

Type result of comparer

### <a id="Divine_Extensions_EnumerableExtensions_SetFlags__1___0___0_System_Boolean_"></a> SetFlags<T\>\(T, T, bool\)

```csharp
public static T SetFlags<T>(this T value, T flags, bool status = true) where T : struct
```

#### Parameters

`value` T

`flags` T

`status` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Extensions_EnumerableExtensions_StandardDeviation_System_Collections_Generic_IEnumerable_System_Int32__"></a> StandardDeviation\(IEnumerable<int\>\)

Standard Deviation of the values list.

```csharp
public static double StandardDeviation(this IEnumerable<int> values)
```

#### Parameters

`values` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

Values list

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

Standard Deviation

### <a id="Divine_Extensions_EnumerableExtensions_To__1_System_IConvertible_"></a> To<T\>\(IConvertible\)

Converts an item to another Type

```csharp
public static T To<T>(this IConvertible @object)
```

#### Parameters

`object` [IConvertible](https://learn.microsoft.com/dotnet/api/system.iconvertible)

The object to convert to

#### Returns

 T

The converted object

#### Type Parameters

`T` 

Type to convert to

### <a id="Divine_Extensions_EnumerableExtensions_ToEnumString__1___0_"></a> ToEnumString<T\>\(T\)

```csharp
public static string ToEnumString<T>(this T type) where T : Enum
```

#### Parameters

`type` T

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Type Parameters

`T` 

