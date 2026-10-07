# <a id="Divine_IO_FileLoader"></a> Class FileLoader

Namespace: [Divine.IO](Divine.IO.md)  
Assembly: Divine.dll  

```csharp
public sealed class FileLoader : IFileLoader
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[FileLoader](Divine.IO.FileLoader.md)

#### Implements

IFileLoader

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<FileLoader\>\(FileLoader, params FileLoader\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Methods

### <a id="Divine_IO_FileLoader_GetFileStream_System_String_"></a> GetFileStream\(string\)

Opens a stream for reading a raw (uncompiled) file, such as a loose script text file.

```csharp
public Stream? GetFileStream(string file)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string)

Path to the file to read.

#### Returns

 [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)?

A readable stream, or null if not found.

### <a id="Divine_IO_FileLoader_LoadFile_System_String_"></a> LoadFile\(string\)

Loads a compiled resource file.

```csharp
public Resource? LoadFile(string file)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string)

Path to the resource file to load.

#### Returns

 Resource?

Loaded resource, or <code>null</code> if not found.

#### Remarks

To read raw file bytes from a VPK package, use <code>Package.ReadEntry</code> instead.

### <a id="Divine_IO_FileLoader_LoadFileCompiled_System_String_"></a> LoadFileCompiled\(string\)

Same as <xref href="ValveResourceFormat.IO.IFileLoader.LoadFile(System.String)" data-throw-if-not-resolved="false"></xref> but appends <b>"_c"</b> to the end of the string.

```csharp
public Resource? LoadFileCompiled(string file)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string)

Path to the file to load (without _c suffix).

#### Returns

 Resource?

Loaded compiled resource, or null if not found.

