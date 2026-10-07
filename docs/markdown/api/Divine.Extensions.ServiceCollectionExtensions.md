# <a id="Divine_Extensions_ServiceCollectionExtensions"></a> Class ServiceCollectionExtensions

Namespace: [Divine.Extensions](Divine.Extensions.md)  
Assembly: Divine.Common.dll  

```csharp
public static class ServiceCollectionExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ServiceCollectionExtensions](Divine.Extensions.ServiceCollectionExtensions.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_)

## Methods

### <a id="Divine_Extensions_ServiceCollectionExtensions_AddDivineDirectory__1___0_System_Action_Divine_IO_DirectoryOptions__"></a> AddDivineDirectory<T\>\(T, Action<DirectoryOptions\>\)

```csharp
public static T AddDivineDirectory<T>(this T services, Action<DirectoryOptions> configure) where T : notnull, IServiceCollection
```

#### Parameters

`services` T

`configure` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[DirectoryOptions](Divine.IO.DirectoryOptions.md)\>

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Extensions_ServiceCollectionExtensions_AddDivineDirectory__1___0_"></a> AddDivineDirectory<T\>\(T\)

```csharp
public static T AddDivineDirectory<T>(this T services) where T : notnull, IServiceCollection
```

#### Parameters

`services` T

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Extensions_ServiceCollectionExtensions_AddDivineFile__1___0_"></a> AddDivineFile<T\>\(T\)

```csharp
public static T AddDivineFile<T>(this T services) where T : notnull, IServiceCollection
```

#### Parameters

`services` T

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Extensions_ServiceCollectionExtensions_AddDivineLogging__1___0_"></a> AddDivineLogging<T\>\(T\)

```csharp
public static T AddDivineLogging<T>(this T services) where T : notnull, IServiceCollection
```

#### Parameters

`services` T

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Extensions_ServiceCollectionExtensions_AddJsonStorage__1_Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Divine_Storage_JsonStorageOptions___0___"></a> AddJsonStorage<TJsonStorage\>\(IServiceCollection, Action<JsonStorageOptions<TJsonStorage\>\>\)

```csharp
public static IServiceCollection AddJsonStorage<TJsonStorage>(this IServiceCollection services, Action<JsonStorageOptions<TJsonStorage>> configure) where TJsonStorage : notnull, JsonStorage<TJsonStorage>
```

#### Parameters

`services` [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

`configure` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[JsonStorageOptions](Divine.Storage.JsonStorageOptions\-1.md)<TJsonStorage\>\>

#### Returns

 [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

#### Type Parameters

`TJsonStorage` 

### <a id="Divine_Extensions_ServiceCollectionExtensions_AddJsonStorage__1_Microsoft_Extensions_DependencyInjection_IServiceCollection_"></a> AddJsonStorage<TJsonStorage\>\(IServiceCollection\)

```csharp
public static IServiceCollection AddJsonStorage<TJsonStorage>(this IServiceCollection services) where TJsonStorage : notnull, JsonStorage<TJsonStorage>
```

#### Parameters

`services` [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

#### Returns

 [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

#### Type Parameters

`TJsonStorage` 

### <a id="Divine_Extensions_ServiceCollectionExtensions_TryAddDivineDirectory__1___0_"></a> TryAddDivineDirectory<T\>\(T\)

```csharp
public static T TryAddDivineDirectory<T>(this T services) where T : notnull, IServiceCollection
```

#### Parameters

`services` T

#### Returns

 T

#### Type Parameters

`T` 

