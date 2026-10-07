# <a id="Divine_IO_FileService"></a> Class FileService

Namespace: [Divine.IO](Divine.IO.md)  
Assembly: Divine.Common.dll  

```csharp
public sealed class FileService
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[FileService](Divine.IO.FileService.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<FileService\>\(FileService, params FileService\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_IO_FileService__ctor_Microsoft_Extensions_Logging_ILogger_Divine_IO_FileService__Divine_IO_DirectoryService_"></a> FileService\(ILogger<FileService\>, DirectoryService\)

```csharp
public FileService(ILogger<FileService> logger, DirectoryService directoryService)
```

#### Parameters

`logger` [ILogger](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.ilogger\-1)<[FileService](Divine.IO.FileService.md)\>

`directoryService` [DirectoryService](Divine.IO.DirectoryService.md)

## Properties

### <a id="Divine_IO_FileService_Client"></a> Client

```csharp
public string Client { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_FileService_Common"></a> Common

```csharp
public string Common { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_FileService_Core"></a> Core

```csharp
public string Core { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_FileService_CoreSteam"></a> CoreSteam

```csharp
public string CoreSteam { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_FileService_CoreSteamX86"></a> CoreSteamX86

```csharp
public string CoreSteamX86 { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_FileService_Dependencies"></a> Dependencies

```csharp
public string Dependencies { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_FileService_Divine"></a> Divine

```csharp
public string Divine { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_FileService_Extensions"></a> Extensions

```csharp
public string Extensions { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_FileService_Interop"></a> Interop

```csharp
public string Interop { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_FileService_Loader"></a> Loader

```csharp
public string Loader { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_FileService_Protobufs"></a> Protobufs

```csharp
public string Protobufs { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_FileService_Sandbox"></a> Sandbox

```csharp
public string Sandbox { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_FileService_SourceGenerator"></a> SourceGenerator

```csharp
public string SourceGenerator { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_FileService_Toolkit"></a> Toolkit

```csharp
public string Toolkit { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_FileService_Win32"></a> Win32

```csharp
public string Win32 { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_IO_FileService_CopyAsync_System_String_System_String_System_Threading_CancellationToken_"></a> CopyAsync\(string, string, CancellationToken\)

```csharp
public Task CopyAsync(string source, string destination, CancellationToken cancellationToken = default)
```

#### Parameters

`source` [string](https://learn.microsoft.com/dotnet/api/system.string)

`destination` [string](https://learn.microsoft.com/dotnet/api/system.string)

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="Divine_IO_FileService_CopyAsync_System_String_System_String_System_Int32_System_Threading_CancellationToken_"></a> CopyAsync\(string, string, int, CancellationToken\)

```csharp
public Task CopyAsync(string source, string destination, int attempts, CancellationToken cancellationToken = default)
```

#### Parameters

`source` [string](https://learn.microsoft.com/dotnet/api/system.string)

`destination` [string](https://learn.microsoft.com/dotnet/api/system.string)

`attempts` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="Divine_IO_FileService_CopyAsync_System_String_System_String_System_Int32_System_TimeSpan_System_Threading_CancellationToken_"></a> CopyAsync\(string, string, int, TimeSpan, CancellationToken\)

```csharp
public Task CopyAsync(string source, string destination, int attempts, TimeSpan retryDelay, CancellationToken cancellationToken = default)
```

#### Parameters

`source` [string](https://learn.microsoft.com/dotnet/api/system.string)

`destination` [string](https://learn.microsoft.com/dotnet/api/system.string)

`attempts` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`retryDelay` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan)

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="Divine_IO_FileService_CopyFile_System_String_System_String_System_Boolean_"></a> CopyFile\(string, string, bool\)

```csharp
public void CopyFile(string sourceFile, string destFile, bool overwrite = true)
```

#### Parameters

`sourceFile` [string](https://learn.microsoft.com/dotnet/api/system.string)

`destFile` [string](https://learn.microsoft.com/dotnet/api/system.string)

`overwrite` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_IO_FileService_CopyLibrary_System_String_System_String_"></a> CopyLibrary\(string, string\)

```csharp
public string CopyLibrary(string sourceFile, string destDirectory)
```

#### Parameters

`sourceFile` [string](https://learn.microsoft.com/dotnet/api/system.string)

`destDirectory` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_FileService_GetFileByName_System_String_"></a> GetFileByName\(string\)

```csharp
public string? GetFileByName(string fileName)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

