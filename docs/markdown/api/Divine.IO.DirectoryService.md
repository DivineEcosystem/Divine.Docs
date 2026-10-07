# <a id="Divine_IO_DirectoryService"></a> Class DirectoryService

Namespace: [Divine.IO](Divine.IO.md)  
Assembly: Divine.Common.dll  

```csharp
public sealed class DirectoryService
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DirectoryService](Divine.IO.DirectoryService.md)

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
[EnumerableExtensions.In<DirectoryService\>\(DirectoryService, params DirectoryService\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_IO_DirectoryService__ctor_Microsoft_Extensions_Options_IOptions_Divine_IO_DirectoryOptions__"></a> DirectoryService\(IOptions<DirectoryOptions\>\)

```csharp
public DirectoryService(IOptions<DirectoryOptions> options)
```

#### Parameters

`options` [IOptions](https://learn.microsoft.com/dotnet/api/microsoft.extensions.options.ioptions\-1)<[DirectoryOptions](Divine.IO.DirectoryOptions.md)\>

## Fields

### <a id="Divine_IO_DirectoryService_DefaultExcludeDirectories"></a> DefaultExcludeDirectories

```csharp
public readonly IReadOnlyList<string> DefaultExcludeDirectories
```

#### Field Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## Properties

### <a id="Divine_IO_DirectoryService_Analyzers"></a> Analyzers

```csharp
public string Analyzers { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_DirectoryService_BaseDirectory"></a> BaseDirectory

```csharp
public string BaseDirectory { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_DirectoryService_Cache"></a> Cache

```csharp
public string Cache { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_DirectoryService_CacheClient"></a> CacheClient

```csharp
public string CacheClient { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_DirectoryService_CacheDependencies"></a> CacheDependencies

```csharp
public string CacheDependencies { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_DirectoryService_Client"></a> Client

```csharp
public string Client { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_DirectoryService_Config"></a> Config

```csharp
public string Config { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_DirectoryService_Dependencies"></a> Dependencies

```csharp
public string Dependencies { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_DirectoryService_Logs"></a> Logs

```csharp
public string Logs { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_DirectoryService_Plugins"></a> Plugins

```csharp
public string Plugins { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_DirectoryService_References"></a> References

```csharp
public string References { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_DirectoryService_Resources"></a> Resources

```csharp
public string Resources { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_DirectoryService_System"></a> System

```csharp
public string System { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_DirectoryService_Temp"></a> Temp

```csharp
public string Temp { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_DirectoryService_TempDownload"></a> TempDownload

```csharp
public string TempDownload { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_DirectoryService_TempGame"></a> TempGame

```csharp
public string TempGame { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_DirectoryService_TempSteam"></a> TempSteam

```csharp
public string TempSteam { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_IO_DirectoryService_Copy_System_String_System_String_"></a> Copy\(string, string\)

```csharp
public void Copy(string sourceDirectory, string destDirectory)
```

#### Parameters

`sourceDirectory` [string](https://learn.microsoft.com/dotnet/api/system.string)

`destDirectory` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_DirectoryService_Copy_System_String_System_String_System_Collections_Generic_IEnumerable_System_String__"></a> Copy\(string, string, IEnumerable<string\>\)

```csharp
public void Copy(string sourceDirectory, string destDirectory, IEnumerable<string> exclude)
```

#### Parameters

`sourceDirectory` [string](https://learn.microsoft.com/dotnet/api/system.string)

`destDirectory` [string](https://learn.microsoft.com/dotnet/api/system.string)

`exclude` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_IO_DirectoryService_Create_System_String_"></a> Create\(string\)

```csharp
public string Create(string directory)
```

#### Parameters

`directory` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_DirectoryService_Delete_System_String_"></a> Delete\(string\)

```csharp
public void Delete(string directory)
```

#### Parameters

`directory` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_DirectoryService_GetDirectories_System_Boolean_"></a> GetDirectories\(bool\)

```csharp
public IEnumerable<string> GetDirectories(bool topDirectoryOnly = false)
```

#### Parameters

`topDirectoryOnly` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

