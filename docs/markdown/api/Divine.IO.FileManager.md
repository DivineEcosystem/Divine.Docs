# <a id="Divine_IO_FileManager"></a> Class FileManager

Namespace: [Divine.IO](Divine.IO.md)  
Assembly: Divine.dll  

```csharp
public static class FileManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[FileManager](Divine.IO.FileManager.md)

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

## Properties

### <a id="Divine_IO_FileManager_FileLoader"></a> FileLoader

```csharp
public static FileLoader FileLoader { get; }
```

#### Property Value

 [FileLoader](Divine.IO.FileLoader.md)

### <a id="Divine_IO_FileManager_FileOverrides"></a> FileOverrides

```csharp
public static IReadOnlyList<string> FileOverrides { get; }
```

#### Property Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_IO_FileManager_Package"></a> Package

```csharp
public static Package Package { get; }
```

#### Property Value

 Package

### <a id="Divine_IO_FileManager_PackageFile"></a> PackageFile

```csharp
public static string PackageFile { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_FileManager_PackageFileLoader"></a> PackageFileLoader

```csharp
public static GameFileLoader PackageFileLoader { get; }
```

#### Property Value

 GameFileLoader

## Methods

### <a id="Divine_IO_FileManager_AddFileOverride_System_String_System_String_"></a> AddFileOverride\(string, string\)

```csharp
public static bool AddFileOverride(string fileName, string replacementFileName)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`replacementFileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_IO_FileManager_AddFileOverride_System_String_System_Span_System_Byte__"></a> AddFileOverride\(string, Span<byte\>\)

```csharp
public static bool AddFileOverride(string fileName, Span<byte> content)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`content` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_IO_FileManager_AddSearchPath_System_String_"></a> AddSearchPath\(string\)

```csharp
public static void AddSearchPath(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_IO_FileManager_ClearFileOverrides"></a> ClearFileOverrides\(\)

```csharp
public static void ClearFileOverrides()
```

### <a id="Divine_IO_FileManager_EnumerateDirectories_System_String_"></a> EnumerateDirectories\(string\)

```csharp
public static IEnumerable<string> EnumerateDirectories(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_IO_FileManager_EnumerateDirectories_System_String_System_String_"></a> EnumerateDirectories\(string, string\)

```csharp
public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

`searchPattern` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_IO_FileManager_EnumerateDirectories_System_String_System_String_System_IO_SearchOption_"></a> EnumerateDirectories\(string, string, SearchOption\)

```csharp
public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

`searchPattern` [string](https://learn.microsoft.com/dotnet/api/system.string)

`searchOption` [SearchOption](https://learn.microsoft.com/dotnet/api/system.io.searchoption)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_IO_FileManager_EnumerateFiles_System_String_"></a> EnumerateFiles\(string\)

```csharp
public static IEnumerable<string> EnumerateFiles(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_IO_FileManager_EnumerateFiles_System_String_System_String_"></a> EnumerateFiles\(string, string\)

```csharp
public static IEnumerable<string> EnumerateFiles(string path, string searchPattern)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

`searchPattern` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_IO_FileManager_EnumerateFiles_System_String_System_String_System_IO_SearchOption_"></a> EnumerateFiles\(string, string, SearchOption\)

```csharp
public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

`searchPattern` [string](https://learn.microsoft.com/dotnet/api/system.string)

`searchOption` [SearchOption](https://learn.microsoft.com/dotnet/api/system.io.searchoption)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_IO_FileManager_HasFileOverride_System_String_"></a> HasFileOverride\(string\)

```csharp
public static bool HasFileOverride(string fileName)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_IO_FileManager_LoadResource_System_String_"></a> LoadResource\(string\)

```csharp
public static bool LoadResource(string fileName)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_IO_FileManager_OpenFile_System_String_"></a> OpenFile\(string\)

```csharp
public static GameFileStream? OpenFile(string fileName)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [GameFileStream](Divine.IO.GameFileStream.md)?

### <a id="Divine_IO_FileManager_ReadResource_System_String_System_Boolean_"></a> ReadResource\(string, bool\)

```csharp
public static Resource? ReadResource(string fileName, bool compiled = false)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`compiled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 Resource?

### <a id="Divine_IO_FileManager_ReadResourceRequired_System_String_System_Boolean_"></a> ReadResourceRequired\(string, bool\)

```csharp
public static Resource ReadResourceRequired(string fileName, bool compiled = false)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`compiled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 Resource

### <a id="Divine_IO_FileManager_RemoveFileOverride_System_String_"></a> RemoveFileOverride\(string\)

```csharp
public static bool RemoveFileOverride(string fileName)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_IO_FileManager_RemoveSearchPath_System_String_"></a> RemoveSearchPath\(string\)

```csharp
public static void RemoveSearchPath(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

