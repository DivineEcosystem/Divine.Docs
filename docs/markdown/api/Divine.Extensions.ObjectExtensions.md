# <a id="Divine_Extensions_ObjectExtensions"></a> Class ObjectExtensions

Namespace: [Divine.Extensions](Divine.Extensions.md)  
Assembly: Divine.dll  

```csharp
public static class ObjectExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ObjectExtensions](Divine.Extensions.ObjectExtensions.md)

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

### <a id="Divine_Extensions_ObjectExtensions_Dump_System_Object_System_Boolean_"></a> Dump\(object?, bool\)

```csharp
public static string Dump(this object? obj, bool preserveReference = false)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

`preserveReference` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Extensions_ObjectExtensions_DumpToConsole_System_Object_System_Boolean_"></a> DumpToConsole\(object?, bool\)

```csharp
public static void DumpToConsole(this object? obj, bool preserveReference = false)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

`preserveReference` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_ObjectExtensions_DumpToLogDebug_System_Object_System_Boolean_"></a> DumpToLogDebug\(object?, bool\)

```csharp
public static void DumpToLogDebug(this object? obj, bool preserveReference = false)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

`preserveReference` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

