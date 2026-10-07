# <a id="Microsoft_Extensions_Hosting_HostBuilderOptions"></a> Class HostBuilderOptions

Namespace: [Microsoft.Extensions.Hosting](Microsoft.Extensions.Hosting.md)  
Assembly: Divine.Common.dll  

```csharp
public sealed class HostBuilderOptions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[HostBuilderOptions](Microsoft.Extensions.Hosting.HostBuilderOptions.md)

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
[EnumerableExtensions.In<HostBuilderOptions\>\(HostBuilderOptions, params HostBuilderOptions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Microsoft_Extensions_Hosting_HostBuilderOptions__ctor"></a> HostBuilderOptions\(\)

```csharp
public HostBuilderOptions()
```

## Properties

### <a id="Microsoft_Extensions_Hosting_HostBuilderOptions_Args"></a> Args

```csharp
public CommandLineArgs Args { get; set; }
```

#### Property Value

 [CommandLineArgs](Divine.CommandLine.CommandLineArgs.md)

### <a id="Microsoft_Extensions_Hosting_HostBuilderOptions_CommandFactory"></a> CommandFactory

```csharp
public Func<Command>? CommandFactory { get; set; }
```

#### Property Value

 [Func](https://learn.microsoft.com/dotnet/api/system.func\-1)<[Command](https://learn.microsoft.com/dotnet/api/system.commandline.command)\>?

### <a id="Microsoft_Extensions_Hosting_HostBuilderOptions_DisableDefaults"></a> DisableDefaults

```csharp
public bool DisableDefaults { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Microsoft_Extensions_Hosting_HostBuilderOptions_FallbackBaseDirectoryFactory"></a> FallbackBaseDirectoryFactory

```csharp
public Func<string>? FallbackBaseDirectoryFactory { get; set; }
```

#### Property Value

 [Func](https://learn.microsoft.com/dotnet/api/system.func\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>?

### <a id="Microsoft_Extensions_Hosting_HostBuilderOptions_SetCurrentDirectory"></a> SetCurrentDirectory

```csharp
public bool SetCurrentDirectory { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Operators

### <a id="Microsoft_Extensions_Hosting_HostBuilderOptions_op_Implicit_System_String____Microsoft_Extensions_Hosting_HostBuilderOptions"></a> implicit operator HostBuilderOptions\(string\[\]\)

```csharp
public static implicit operator HostBuilderOptions(string[] args)
```

#### Parameters

`args` [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

#### Returns

 [HostBuilderOptions](Microsoft.Extensions.Hosting.HostBuilderOptions.md)

### <a id="Microsoft_Extensions_Hosting_HostBuilderOptions_op_Implicit_Divine_CommandLine_CommandLineArgs__Microsoft_Extensions_Hosting_HostBuilderOptions"></a> implicit operator HostBuilderOptions\(CommandLineArgs\)

```csharp
public static implicit operator HostBuilderOptions(CommandLineArgs args)
```

#### Parameters

`args` [CommandLineArgs](Divine.CommandLine.CommandLineArgs.md)

#### Returns

 [HostBuilderOptions](Microsoft.Extensions.Hosting.HostBuilderOptions.md)

