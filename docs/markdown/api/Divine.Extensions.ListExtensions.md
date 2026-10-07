# <a id="Divine_Extensions_ListExtensions"></a> Class ListExtensions

Namespace: [Divine.Extensions](Divine.Extensions.md)  
Assembly: Divine.dll  

```csharp
public static class ListExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ListExtensions](Divine.Extensions.ListExtensions.md)

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

### <a id="Divine_Extensions_ListExtensions_InsertItem__1_System_Collections_Generic_List___0__System_Int32___0_"></a> InsertItem<T\>\(List<T\>, int, T\)

```csharp
public static List<T> InsertItem<T>(this List<T> list, int index, T item)
```

#### Parameters

`list` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<T\>

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`item` T

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<T\>

#### Type Parameters

`T` 

### <a id="Divine_Extensions_ListExtensions_RemoveAtItem__1_System_Collections_Generic_List___0__System_Int32_"></a> RemoveAtItem<T\>\(List<T\>, int\)

```csharp
public static List<T> RemoveAtItem<T>(this List<T> list, int index)
```

#### Parameters

`list` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<T\>

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<T\>

#### Type Parameters

`T` 

