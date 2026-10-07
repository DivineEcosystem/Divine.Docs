# <a id="Microsoft_Extensions_Logging_LoggerFactoryExtensions"></a> Class LoggerFactoryExtensions

Namespace: [Microsoft.Extensions.Logging](Microsoft.Extensions.Logging.md)  
Assembly: Divine.Common.dll  

```csharp
public static class LoggerFactoryExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[LoggerFactoryExtensions](Microsoft.Extensions.Logging.LoggerFactoryExtensions.md)

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

### <a id="Microsoft_Extensions_Logging_LoggerFactoryExtensions_CreateLogger__1"></a> CreateLogger<TCategoryName\>\(\)

```csharp
public static ILogger<TCategoryName> CreateLogger<TCategoryName>()
```

#### Returns

 [ILogger](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.ilogger\-1)<TCategoryName\>

#### Type Parameters

`TCategoryName` 

### <a id="Microsoft_Extensions_Logging_LoggerFactoryExtensions_CreateLogger_System_Type_"></a> CreateLogger\(Type\)

```csharp
public static ILogger CreateLogger(Type type)
```

#### Parameters

`type` [Type](https://learn.microsoft.com/dotnet/api/system.type)

#### Returns

 [ILogger](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.ilogger)

### <a id="Microsoft_Extensions_Logging_LoggerFactoryExtensions_CreateLogger_System_String_"></a> CreateLogger\(string\)

```csharp
public static ILogger CreateLogger(string categoryName = "Default")
```

#### Parameters

`categoryName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [ILogger](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.ilogger)

### <a id="Microsoft_Extensions_Logging_LoggerFactoryExtensions_get_Current"></a> get\_Current\(\)

```csharp
public static ILoggerFactory get_Current()
```

#### Returns

 [ILoggerFactory](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.iloggerfactory)

