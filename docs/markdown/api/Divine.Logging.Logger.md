# <a id="Divine_Logging_Logger"></a> Class Logger

Namespace: [Divine.Logging](Divine.Logging.md)  
Assembly: Divine.Common.dll  

```csharp
public static class Logger
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Logger](Divine.Logging.Logger.md)

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

## Properties

### <a id="Divine_Logging_Logger_Current"></a> Current

```csharp
public static ILogger Current { get; }
```

#### Property Value

 [ILogger](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.ilogger)

## Methods

### <a id="Divine_Logging_Logger_Log_Microsoft_Extensions_Logging_LogLevel_System_String_System_Object___"></a> Log\(LogLevel, string?, params object?\[\]\)

```csharp
public static void Log(LogLevel logLevel, string? message, params object?[] args)
```

#### Parameters

`logLevel` [LogLevel](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.loglevel)

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_Log_Microsoft_Extensions_Logging_LogLevel_System_Exception_"></a> Log\(LogLevel, Exception?\)

```csharp
public static void Log(LogLevel logLevel, Exception? exception)
```

#### Parameters

`logLevel` [LogLevel](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.loglevel)

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

### <a id="Divine_Logging_Logger_Log_Microsoft_Extensions_Logging_LogLevel_System_Exception_System_String_System_Object___"></a> Log\(LogLevel, Exception?, string?, params object?\[\]\)

```csharp
public static void Log(LogLevel logLevel, Exception? exception, string? message, params object?[] args)
```

#### Parameters

`logLevel` [LogLevel](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.loglevel)

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_Log_Microsoft_Extensions_Logging_LogLevel_Microsoft_Extensions_Logging_EventId_System_String_System_Object___"></a> Log\(LogLevel, EventId, string?, params object?\[\]\)

```csharp
public static void Log(LogLevel logLevel, EventId eventId, string? message, params object?[] args)
```

#### Parameters

`logLevel` [LogLevel](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.loglevel)

`eventId` [EventId](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.eventid)

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_Log_Microsoft_Extensions_Logging_LogLevel_Microsoft_Extensions_Logging_EventId_System_Exception_System_String_System_Object___"></a> Log\(LogLevel, EventId, Exception?, string?, params object?\[\]\)

```csharp
public static void Log(LogLevel logLevel, EventId eventId, Exception? exception, string? message, params object?[] args)
```

#### Parameters

`logLevel` [LogLevel](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.loglevel)

`eventId` [EventId](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.eventid)

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogCritical_System_String_System_Object___"></a> LogCritical\(string?, params object?\[\]\)

```csharp
public static void LogCritical(string? message, params object?[] args)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogCritical_System_Exception_"></a> LogCritical\(Exception?\)

```csharp
public static void LogCritical(Exception? exception)
```

#### Parameters

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

### <a id="Divine_Logging_Logger_LogCritical_System_Exception_System_String_System_Object___"></a> LogCritical\(Exception?, string?, params object?\[\]\)

```csharp
public static void LogCritical(Exception? exception, string? message, params object?[] args)
```

#### Parameters

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogCritical_Microsoft_Extensions_Logging_EventId_System_String_System_Object___"></a> LogCritical\(EventId, string?, params object?\[\]\)

```csharp
public static void LogCritical(EventId eventId, string? message, params object?[] args)
```

#### Parameters

`eventId` [EventId](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.eventid)

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogCritical_Microsoft_Extensions_Logging_EventId_System_Exception_System_String_System_Object___"></a> LogCritical\(EventId, Exception?, string?, params object?\[\]\)

```csharp
public static void LogCritical(EventId eventId, Exception? exception, string? message, params object?[] args)
```

#### Parameters

`eventId` [EventId](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.eventid)

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogDebug_System_String_System_Object___"></a> LogDebug\(string?, params object?\[\]\)

```csharp
public static void LogDebug(string? message, params object?[] args)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogDebug_System_Exception_"></a> LogDebug\(Exception?\)

```csharp
public static void LogDebug(Exception? exception)
```

#### Parameters

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

### <a id="Divine_Logging_Logger_LogDebug_System_Exception_System_String_System_Object___"></a> LogDebug\(Exception?, string?, params object?\[\]\)

```csharp
public static void LogDebug(Exception? exception, string? message, params object?[] args)
```

#### Parameters

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogDebug_Microsoft_Extensions_Logging_EventId_System_String_System_Object___"></a> LogDebug\(EventId, string?, params object?\[\]\)

```csharp
public static void LogDebug(EventId eventId, string? message, params object?[] args)
```

#### Parameters

`eventId` [EventId](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.eventid)

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogDebug_Microsoft_Extensions_Logging_EventId_System_Exception_System_String_System_Object___"></a> LogDebug\(EventId, Exception?, string?, params object?\[\]\)

```csharp
public static void LogDebug(EventId eventId, Exception? exception, string? message, params object?[] args)
```

#### Parameters

`eventId` [EventId](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.eventid)

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogError_System_String_System_Object___"></a> LogError\(string?, params object?\[\]\)

```csharp
public static void LogError(string? message, params object?[] args)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogError_System_Exception_"></a> LogError\(Exception?\)

```csharp
public static void LogError(Exception? exception)
```

#### Parameters

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

### <a id="Divine_Logging_Logger_LogError_System_Exception_System_String_System_Object___"></a> LogError\(Exception?, string?, params object?\[\]\)

```csharp
public static void LogError(Exception? exception, string? message, params object?[] args)
```

#### Parameters

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogError_Microsoft_Extensions_Logging_EventId_System_String_System_Object___"></a> LogError\(EventId, string?, params object?\[\]\)

```csharp
public static void LogError(EventId eventId, string? message, params object?[] args)
```

#### Parameters

`eventId` [EventId](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.eventid)

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogError_Microsoft_Extensions_Logging_EventId_System_Exception_System_String_System_Object___"></a> LogError\(EventId, Exception?, string?, params object?\[\]\)

```csharp
public static void LogError(EventId eventId, Exception? exception, string? message, params object?[] args)
```

#### Parameters

`eventId` [EventId](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.eventid)

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogInformation_System_String_System_Object___"></a> LogInformation\(string?, params object?\[\]\)

```csharp
public static void LogInformation(string? message, params object?[] args)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogInformation_System_Exception_"></a> LogInformation\(Exception?\)

```csharp
public static void LogInformation(Exception? exception)
```

#### Parameters

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

### <a id="Divine_Logging_Logger_LogInformation_System_Exception_System_String_System_Object___"></a> LogInformation\(Exception?, string?, params object?\[\]\)

```csharp
public static void LogInformation(Exception? exception, string? message, params object?[] args)
```

#### Parameters

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogInformation_Microsoft_Extensions_Logging_EventId_System_String_System_Object___"></a> LogInformation\(EventId, string?, params object?\[\]\)

```csharp
public static void LogInformation(EventId eventId, string? message, params object?[] args)
```

#### Parameters

`eventId` [EventId](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.eventid)

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogInformation_Microsoft_Extensions_Logging_EventId_System_Exception_System_String_System_Object___"></a> LogInformation\(EventId, Exception?, string?, params object?\[\]\)

```csharp
public static void LogInformation(EventId eventId, Exception? exception, string? message, params object?[] args)
```

#### Parameters

`eventId` [EventId](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.eventid)

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogTrace_System_String_System_Object___"></a> LogTrace\(string?, params object?\[\]\)

```csharp
public static void LogTrace(string? message, params object?[] args)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogTrace_System_Exception_"></a> LogTrace\(Exception?\)

```csharp
public static void LogTrace(Exception? exception)
```

#### Parameters

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

### <a id="Divine_Logging_Logger_LogTrace_System_Exception_System_String_System_Object___"></a> LogTrace\(Exception?, string?, params object?\[\]\)

```csharp
public static void LogTrace(Exception? exception, string? message, params object?[] args)
```

#### Parameters

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogTrace_Microsoft_Extensions_Logging_EventId_System_String_System_Object___"></a> LogTrace\(EventId, string?, params object?\[\]\)

```csharp
public static void LogTrace(EventId eventId, string? message, params object?[] args)
```

#### Parameters

`eventId` [EventId](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.eventid)

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogTrace_Microsoft_Extensions_Logging_EventId_System_Exception_System_String_System_Object___"></a> LogTrace\(EventId, Exception?, string?, params object?\[\]\)

```csharp
public static void LogTrace(EventId eventId, Exception? exception, string? message, params object?[] args)
```

#### Parameters

`eventId` [EventId](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.eventid)

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogWarning_System_String_System_Object___"></a> LogWarning\(string?, params object?\[\]\)

```csharp
public static void LogWarning(string? message, params object?[] args)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogWarning_System_Exception_"></a> LogWarning\(Exception?\)

```csharp
public static void LogWarning(Exception? exception)
```

#### Parameters

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

### <a id="Divine_Logging_Logger_LogWarning_System_Exception_System_String_System_Object___"></a> LogWarning\(Exception?, string?, params object?\[\]\)

```csharp
public static void LogWarning(Exception? exception, string? message, params object?[] args)
```

#### Parameters

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogWarning_Microsoft_Extensions_Logging_EventId_System_String_System_Object___"></a> LogWarning\(EventId, string?, params object?\[\]\)

```csharp
public static void LogWarning(EventId eventId, string? message, params object?[] args)
```

#### Parameters

`eventId` [EventId](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.eventid)

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Logging_Logger_LogWarning_Microsoft_Extensions_Logging_EventId_System_Exception_System_String_System_Object___"></a> LogWarning\(EventId, Exception?, string?, params object?\[\]\)

```csharp
public static void LogWarning(EventId eventId, Exception? exception, string? message, params object?[] args)
```

#### Parameters

`eventId` [EventId](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.eventid)

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

