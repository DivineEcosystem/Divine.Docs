# <a id="Divine_Extensions_AssemblyLoadContextExtensions"></a> Class AssemblyLoadContextExtensions

Namespace: [Divine.Extensions](Divine.Extensions.md)  
Assembly: Divine.Common.dll  

```csharp
public static class AssemblyLoadContextExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AssemblyLoadContextExtensions](Divine.Extensions.AssemblyLoadContextExtensions.md)

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

### <a id="Divine_Extensions_AssemblyLoadContextExtensions_LoadFromStream_System_Runtime_Loader_AssemblyLoadContext_System_IO_Stream_System_String_System_Boolean_"></a> LoadFromStream\(AssemblyLoadContext, Stream, string, bool\)

```csharp
[RequiresUnreferencedCode("Loading assemblies from streams is not compatible with trimming because loaded assembly dependencies cannot be statically analyzed.")]
public static Assembly LoadFromStream(this AssemblyLoadContext alc, Stream assemblyStream, string symbolsFile, bool throwIfNotExistsSymbols = false)
```

#### Parameters

`alc` [AssemblyLoadContext](https://learn.microsoft.com/dotnet/api/system.runtime.loader.assemblyloadcontext)

`assemblyStream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

`symbolsFile` [string](https://learn.microsoft.com/dotnet/api/system.string)

`throwIfNotExistsSymbols` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [Assembly](https://learn.microsoft.com/dotnet/api/system.reflection.assembly)

### <a id="Divine_Extensions_AssemblyLoadContextExtensions_LoadInMemoryAssembly_System_Runtime_Loader_AssemblyLoadContext_System_String_"></a> LoadInMemoryAssembly\(AssemblyLoadContext, string\)

```csharp
[RequiresUnreferencedCode("Loading assemblies from streams is not compatible with trimming because loaded assembly dependencies cannot be statically analyzed.")]
public static Assembly LoadInMemoryAssembly(this AssemblyLoadContext alc, string assemblyFile)
```

#### Parameters

`alc` [AssemblyLoadContext](https://learn.microsoft.com/dotnet/api/system.runtime.loader.assemblyloadcontext)

`assemblyFile` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Assembly](https://learn.microsoft.com/dotnet/api/system.reflection.assembly)

### <a id="Divine_Extensions_AssemblyLoadContextExtensions_LoadInMemoryAssembly_System_Runtime_Loader_AssemblyLoadContext_System_String_System_Boolean_"></a> LoadInMemoryAssembly\(AssemblyLoadContext, string, bool\)

```csharp
[RequiresUnreferencedCode("Loading assemblies from streams is not compatible with trimming because loaded assembly dependencies cannot be statically analyzed.")]
public static Assembly LoadInMemoryAssembly(this AssemblyLoadContext alc, string assemblyFile, bool searchSymbols)
```

#### Parameters

`alc` [AssemblyLoadContext](https://learn.microsoft.com/dotnet/api/system.runtime.loader.assemblyloadcontext)

`assemblyFile` [string](https://learn.microsoft.com/dotnet/api/system.string)

`searchSymbols` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [Assembly](https://learn.microsoft.com/dotnet/api/system.reflection.assembly)

### <a id="Divine_Extensions_AssemblyLoadContextExtensions_LoadInMemoryAssembly_System_Runtime_Loader_AssemblyLoadContext_System_String_System_String_"></a> LoadInMemoryAssembly\(AssemblyLoadContext, string, string\)

```csharp
[RequiresUnreferencedCode("Loading assemblies from streams is not compatible with trimming because loaded assembly dependencies cannot be statically analyzed.")]
public static Assembly LoadInMemoryAssembly(this AssemblyLoadContext alc, string assemblyFile, string symbolsFile)
```

#### Parameters

`alc` [AssemblyLoadContext](https://learn.microsoft.com/dotnet/api/system.runtime.loader.assemblyloadcontext)

`assemblyFile` [string](https://learn.microsoft.com/dotnet/api/system.string)

`symbolsFile` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Assembly](https://learn.microsoft.com/dotnet/api/system.reflection.assembly)

