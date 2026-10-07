# <a id="Microsoft_Extensions_DependencyInjection_ServiceCollectionExtensions"></a> Class ServiceCollectionExtensions

Namespace: [Microsoft.Extensions.DependencyInjection](Microsoft.Extensions.DependencyInjection.md)  
Assembly: Divine.Common.dll  

```csharp
public static class ServiceCollectionExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ServiceCollectionExtensions](Microsoft.Extensions.DependencyInjection.ServiceCollectionExtensions.md)

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

### <a id="Microsoft_Extensions_DependencyInjection_ServiceCollectionExtensions_AddService__2_Microsoft_Extensions_DependencyInjection_ServiceCollection_System_Action___1__"></a> AddService<TService, TOptions\>\(ServiceCollection, Action<TOptions\>\)

```csharp
public static ServiceCollection AddService<TService, TOptions>(this ServiceCollection services, Action<TOptions> configureOptions) where TService : class where TOptions : class
```

#### Parameters

`services` [ServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.servicecollection)

`configureOptions` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<TOptions\>

#### Returns

 [ServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.servicecollection)

#### Type Parameters

`TService` 

`TOptions` 

### <a id="Microsoft_Extensions_DependencyInjection_ServiceCollectionExtensions_AddService__2_Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action___1__"></a> AddService<TService, TOptions\>\(IServiceCollection, Action<TOptions\>\)

```csharp
public static IServiceCollection AddService<TService, TOptions>(this IServiceCollection services, Action<TOptions> configureOptions) where TService : class where TOptions : class
```

#### Parameters

`services` [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

`configureOptions` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<TOptions\>

#### Returns

 [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

#### Type Parameters

`TService` 

`TOptions` 

