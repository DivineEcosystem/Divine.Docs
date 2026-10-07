# <a id="Divine_Extensions_ConfigurationBuilderExtensions"></a> Class ConfigurationBuilderExtensions

Namespace: [Divine.Extensions](Divine.Extensions.md)  
Assembly: Divine.Common.dll  

```csharp
public static class ConfigurationBuilderExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ConfigurationBuilderExtensions](Divine.Extensions.ConfigurationBuilderExtensions.md)

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

### <a id="Divine_Extensions_ConfigurationBuilderExtensions_AddDivineCommandLine__1___0_Divine_CommandLine_CommandLineArgs_System_CommandLine_Command_"></a> AddDivineCommandLine<T\>\(T, CommandLineArgs, Command\)

```csharp
public static T AddDivineCommandLine<T>(this T configuration, CommandLineArgs args, Command command) where T : notnull, IConfigurationBuilder
```

#### Parameters

`configuration` T

`args` [CommandLineArgs](Divine.CommandLine.CommandLineArgs.md)

`command` [Command](https://learn.microsoft.com/dotnet/api/system.commandline.command)

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Extensions_ConfigurationBuilderExtensions_AddDivineEnvironmentVariables__1___0_"></a> AddDivineEnvironmentVariables<T\>\(T\)

```csharp
public static T AddDivineEnvironmentVariables<T>(this T configuration) where T : notnull, IConfigurationBuilder
```

#### Parameters

`configuration` T

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_Extensions_ConfigurationBuilderExtensions_RemoveAll__2___0_"></a> RemoveAll<T, TSource\>\(T\)

```csharp
public static T RemoveAll<T, TSource>(this T configuration) where T : notnull, IConfigurationBuilder where TSource : notnull, IConfigurationSource
```

#### Parameters

`configuration` T

#### Returns

 T

#### Type Parameters

`T` 

`TSource` 

### <a id="Divine_Extensions_ConfigurationBuilderExtensions_RemoveAll__2___0_System_Func___1_System_Boolean__"></a> RemoveAll<T, TSource\>\(T, Func<TSource, bool\>\)

```csharp
public static T RemoveAll<T, TSource>(this T configuration, Func<TSource, bool> predicate) where T : notnull, IConfigurationBuilder where TSource : notnull, IConfigurationSource
```

#### Parameters

`configuration` T

`predicate` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<TSource, [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

#### Returns

 T

#### Type Parameters

`T` 

`TSource` 

### <a id="Divine_Extensions_ConfigurationBuilderExtensions_RemoveAll__1_Microsoft_Extensions_Configuration_IConfigurationBuilder_"></a> RemoveAll<TSource\>\(IConfigurationBuilder\)

```csharp
public static IConfigurationBuilder RemoveAll<TSource>(this IConfigurationBuilder configuration) where TSource : notnull, IConfigurationSource
```

#### Parameters

`configuration` [IConfigurationBuilder](https://learn.microsoft.com/dotnet/api/microsoft.extensions.configuration.iconfigurationbuilder)

#### Returns

 [IConfigurationBuilder](https://learn.microsoft.com/dotnet/api/microsoft.extensions.configuration.iconfigurationbuilder)

#### Type Parameters

`TSource` 

### <a id="Divine_Extensions_ConfigurationBuilderExtensions_RemoveAll__1_Microsoft_Extensions_Configuration_IConfigurationBuilder_System_Func___0_System_Boolean__"></a> RemoveAll<TSource\>\(IConfigurationBuilder, Func<TSource, bool\>\)

```csharp
public static IConfigurationBuilder RemoveAll<TSource>(this IConfigurationBuilder configuration, Func<TSource, bool> predicate) where TSource : notnull, IConfigurationSource
```

#### Parameters

`configuration` [IConfigurationBuilder](https://learn.microsoft.com/dotnet/api/microsoft.extensions.configuration.iconfigurationbuilder)

`predicate` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<TSource, [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

#### Returns

 [IConfigurationBuilder](https://learn.microsoft.com/dotnet/api/microsoft.extensions.configuration.iconfigurationbuilder)

#### Type Parameters

`TSource` 

