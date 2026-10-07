# <a id="Microsoft_Extensions_Logging_LoggerExtensions"></a> Class LoggerExtensions

Namespace: [Microsoft.Extensions.Logging](Microsoft.Extensions.Logging.md)  
Assembly: Divine.Common.dll  

```csharp
public static class LoggerExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[LoggerExtensions](Microsoft.Extensions.Logging.LoggerExtensions.md)

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

### <a id="Microsoft_Extensions_Logging_LoggerExtensions_Log_Microsoft_Extensions_Logging_ILogger_Microsoft_Extensions_Logging_LogLevel_System_Exception_"></a> Log\(ILogger, LogLevel, Exception?\)

```csharp
public static void Log(this ILogger logger, LogLevel logLevel, Exception? exception)
```

#### Parameters

`logger` [ILogger](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.ilogger)

`logLevel` [LogLevel](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.loglevel)

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

### <a id="Microsoft_Extensions_Logging_LoggerExtensions_LogCritical_Microsoft_Extensions_Logging_ILogger_System_Exception_"></a> LogCritical\(ILogger, Exception?\)

```csharp
public static void LogCritical(this ILogger logger, Exception? exception)
```

#### Parameters

`logger` [ILogger](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.ilogger)

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

### <a id="Microsoft_Extensions_Logging_LoggerExtensions_LogDebug_Microsoft_Extensions_Logging_ILogger_System_Exception_"></a> LogDebug\(ILogger, Exception?\)

```csharp
public static void LogDebug(this ILogger logger, Exception? exception)
```

#### Parameters

`logger` [ILogger](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.ilogger)

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

### <a id="Microsoft_Extensions_Logging_LoggerExtensions_LogError_Microsoft_Extensions_Logging_ILogger_System_Exception_"></a> LogError\(ILogger, Exception?\)

```csharp
public static void LogError(this ILogger logger, Exception? exception)
```

#### Parameters

`logger` [ILogger](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.ilogger)

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

### <a id="Microsoft_Extensions_Logging_LoggerExtensions_LogInformation_Microsoft_Extensions_Logging_ILogger_System_Exception_"></a> LogInformation\(ILogger, Exception?\)

```csharp
public static void LogInformation(this ILogger logger, Exception? exception)
```

#### Parameters

`logger` [ILogger](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.ilogger)

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

### <a id="Microsoft_Extensions_Logging_LoggerExtensions_LogTrace_Microsoft_Extensions_Logging_ILogger_System_Exception_"></a> LogTrace\(ILogger, Exception?\)

```csharp
public static void LogTrace(this ILogger logger, Exception? exception)
```

#### Parameters

`logger` [ILogger](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.ilogger)

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

### <a id="Microsoft_Extensions_Logging_LoggerExtensions_LogWarning_Microsoft_Extensions_Logging_ILogger_System_Exception_"></a> LogWarning\(ILogger, Exception?\)

```csharp
public static void LogWarning(this ILogger logger, Exception? exception)
```

#### Parameters

`logger` [ILogger](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.ilogger)

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

