# <a id="Microsoft_Extensions_DependencyInjection_OptionsServiceCollectionExtensions"></a> Class OptionsServiceCollectionExtensions

Namespace: [Microsoft.Extensions.DependencyInjection](Microsoft.Extensions.DependencyInjection.md)  
Assembly: Divine.Common.dll  

```csharp
public static class OptionsServiceCollectionExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[OptionsServiceCollectionExtensions](Microsoft.Extensions.DependencyInjection.OptionsServiceCollectionExtensions.md)

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

### <a id="Microsoft_Extensions_DependencyInjection_OptionsServiceCollectionExtensions_Configure__2_Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action___0___1__"></a> Configure<TOptions, TDep\>\(IServiceCollection, Action<TOptions, TDep\>\)

```csharp
public static IServiceCollection Configure<TOptions, TDep>(this IServiceCollection services, Action<TOptions, TDep> configureOptions) where TOptions : class where TDep : class
```

#### Parameters

`services` [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

`configureOptions` [Action](https://learn.microsoft.com/dotnet/api/system.action\-2)<TOptions, TDep\>

#### Returns

 [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

#### Type Parameters

`TOptions` 

`TDep` 

### <a id="Microsoft_Extensions_DependencyInjection_OptionsServiceCollectionExtensions_Configure__3_Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action___0___1___2__"></a> Configure<TOptions, TDep1, TDep2\>\(IServiceCollection, Action<TOptions, TDep1, TDep2\>\)

```csharp
public static IServiceCollection Configure<TOptions, TDep1, TDep2>(this IServiceCollection services, Action<TOptions, TDep1, TDep2> configureOptions) where TOptions : class where TDep1 : class where TDep2 : class
```

#### Parameters

`services` [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

`configureOptions` [Action](https://learn.microsoft.com/dotnet/api/system.action\-3)<TOptions, TDep1, TDep2\>

#### Returns

 [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

#### Type Parameters

`TOptions` 

`TDep1` 

`TDep2` 

### <a id="Microsoft_Extensions_DependencyInjection_OptionsServiceCollectionExtensions_Configure__4_Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action___0___1___2___3__"></a> Configure<TOptions, TDep1, TDep2, TDep3\>\(IServiceCollection, Action<TOptions, TDep1, TDep2, TDep3\>\)

```csharp
public static IServiceCollection Configure<TOptions, TDep1, TDep2, TDep3>(this IServiceCollection services, Action<TOptions, TDep1, TDep2, TDep3> configureOptions) where TOptions : class where TDep1 : class where TDep2 : class where TDep3 : class
```

#### Parameters

`services` [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

`configureOptions` [Action](https://learn.microsoft.com/dotnet/api/system.action\-4)<TOptions, TDep1, TDep2, TDep3\>

#### Returns

 [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

#### Type Parameters

`TOptions` 

`TDep1` 

`TDep2` 

`TDep3` 

### <a id="Microsoft_Extensions_DependencyInjection_OptionsServiceCollectionExtensions_Configure__5_Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action___0___1___2___3___4__"></a> Configure<TOptions, TDep1, TDep2, TDep3, TDep4\>\(IServiceCollection, Action<TOptions, TDep1, TDep2, TDep3, TDep4\>\)

```csharp
public static IServiceCollection Configure<TOptions, TDep1, TDep2, TDep3, TDep4>(this IServiceCollection services, Action<TOptions, TDep1, TDep2, TDep3, TDep4> configureOptions) where TOptions : class where TDep1 : class where TDep2 : class where TDep3 : class where TDep4 : class
```

#### Parameters

`services` [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

`configureOptions` [Action](https://learn.microsoft.com/dotnet/api/system.action\-5)<TOptions, TDep1, TDep2, TDep3, TDep4\>

#### Returns

 [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

#### Type Parameters

`TOptions` 

`TDep1` 

`TDep2` 

`TDep3` 

`TDep4` 

### <a id="Microsoft_Extensions_DependencyInjection_OptionsServiceCollectionExtensions_Configure__6_Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action___0___1___2___3___4___5__"></a> Configure<TOptions, TDep1, TDep2, TDep3, TDep4, TDep5\>\(IServiceCollection, Action<TOptions, TDep1, TDep2, TDep3, TDep4, TDep5\>\)

```csharp
public static IServiceCollection Configure<TOptions, TDep1, TDep2, TDep3, TDep4, TDep5>(this IServiceCollection services, Action<TOptions, TDep1, TDep2, TDep3, TDep4, TDep5> configureOptions) where TOptions : class where TDep1 : class where TDep2 : class where TDep3 : class where TDep4 : class where TDep5 : class
```

#### Parameters

`services` [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

`configureOptions` [Action](https://learn.microsoft.com/dotnet/api/system.action\-6)<TOptions, TDep1, TDep2, TDep3, TDep4, TDep5\>

#### Returns

 [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

#### Type Parameters

`TOptions` 

`TDep1` 

`TDep2` 

`TDep3` 

`TDep4` 

`TDep5` 

### <a id="Microsoft_Extensions_DependencyInjection_OptionsServiceCollectionExtensions_Configure__2_Microsoft_Extensions_DependencyInjection_IServiceCollection_System_String_System_Action___0___1__"></a> Configure<TOptions, TDep\>\(IServiceCollection, string?, Action<TOptions, TDep\>\)

```csharp
public static IServiceCollection Configure<TOptions, TDep>(this IServiceCollection services, string? name, Action<TOptions, TDep> configureOptions) where TOptions : class where TDep : class
```

#### Parameters

`services` [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`configureOptions` [Action](https://learn.microsoft.com/dotnet/api/system.action\-2)<TOptions, TDep\>

#### Returns

 [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

#### Type Parameters

`TOptions` 

`TDep` 

### <a id="Microsoft_Extensions_DependencyInjection_OptionsServiceCollectionExtensions_Configure__3_Microsoft_Extensions_DependencyInjection_IServiceCollection_System_String_System_Action___0___1___2__"></a> Configure<TOptions, TDep1, TDep2\>\(IServiceCollection, string?, Action<TOptions, TDep1, TDep2\>\)

```csharp
public static IServiceCollection Configure<TOptions, TDep1, TDep2>(this IServiceCollection services, string? name, Action<TOptions, TDep1, TDep2> configureOptions) where TOptions : class where TDep1 : class where TDep2 : class
```

#### Parameters

`services` [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`configureOptions` [Action](https://learn.microsoft.com/dotnet/api/system.action\-3)<TOptions, TDep1, TDep2\>

#### Returns

 [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

#### Type Parameters

`TOptions` 

`TDep1` 

`TDep2` 

### <a id="Microsoft_Extensions_DependencyInjection_OptionsServiceCollectionExtensions_Configure__4_Microsoft_Extensions_DependencyInjection_IServiceCollection_System_String_System_Action___0___1___2___3__"></a> Configure<TOptions, TDep1, TDep2, TDep3\>\(IServiceCollection, string?, Action<TOptions, TDep1, TDep2, TDep3\>\)

```csharp
public static IServiceCollection Configure<TOptions, TDep1, TDep2, TDep3>(this IServiceCollection services, string? name, Action<TOptions, TDep1, TDep2, TDep3> configureOptions) where TOptions : class where TDep1 : class where TDep2 : class where TDep3 : class
```

#### Parameters

`services` [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`configureOptions` [Action](https://learn.microsoft.com/dotnet/api/system.action\-4)<TOptions, TDep1, TDep2, TDep3\>

#### Returns

 [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

#### Type Parameters

`TOptions` 

`TDep1` 

`TDep2` 

`TDep3` 

### <a id="Microsoft_Extensions_DependencyInjection_OptionsServiceCollectionExtensions_Configure__5_Microsoft_Extensions_DependencyInjection_IServiceCollection_System_String_System_Action___0___1___2___3___4__"></a> Configure<TOptions, TDep1, TDep2, TDep3, TDep4\>\(IServiceCollection, string?, Action<TOptions, TDep1, TDep2, TDep3, TDep4\>\)

```csharp
public static IServiceCollection Configure<TOptions, TDep1, TDep2, TDep3, TDep4>(this IServiceCollection services, string? name, Action<TOptions, TDep1, TDep2, TDep3, TDep4> configureOptions) where TOptions : class where TDep1 : class where TDep2 : class where TDep3 : class where TDep4 : class
```

#### Parameters

`services` [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`configureOptions` [Action](https://learn.microsoft.com/dotnet/api/system.action\-5)<TOptions, TDep1, TDep2, TDep3, TDep4\>

#### Returns

 [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

#### Type Parameters

`TOptions` 

`TDep1` 

`TDep2` 

`TDep3` 

`TDep4` 

### <a id="Microsoft_Extensions_DependencyInjection_OptionsServiceCollectionExtensions_Configure__6_Microsoft_Extensions_DependencyInjection_IServiceCollection_System_String_System_Action___0___1___2___3___4___5__"></a> Configure<TOptions, TDep1, TDep2, TDep3, TDep4, TDep5\>\(IServiceCollection, string?, Action<TOptions, TDep1, TDep2, TDep3, TDep4, TDep5\>\)

```csharp
public static IServiceCollection Configure<TOptions, TDep1, TDep2, TDep3, TDep4, TDep5>(this IServiceCollection services, string? name, Action<TOptions, TDep1, TDep2, TDep3, TDep4, TDep5> configureOptions) where TOptions : class where TDep1 : class where TDep2 : class where TDep3 : class where TDep4 : class where TDep5 : class
```

#### Parameters

`services` [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`configureOptions` [Action](https://learn.microsoft.com/dotnet/api/system.action\-6)<TOptions, TDep1, TDep2, TDep3, TDep4, TDep5\>

#### Returns

 [IServiceCollection](https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection)

#### Type Parameters

`TOptions` 

`TDep1` 

`TDep2` 

`TDep3` 

`TDep4` 

`TDep5` 

