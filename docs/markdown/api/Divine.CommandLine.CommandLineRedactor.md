# <a id="Divine_CommandLine_CommandLineRedactor"></a> Class CommandLineRedactor

Namespace: [Divine.CommandLine](Divine.CommandLine.md)  
Assembly: Divine.Common.dll  

```csharp
public static class CommandLineRedactor
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CommandLineRedactor](Divine.CommandLine.CommandLineRedactor.md)

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

### <a id="Divine_CommandLine_CommandLineRedactor_Redact_System_String_System_String_System_Int32_System_Char_"></a> Redact\(string, string, int, char\)

```csharp
public static string Redact(string value, string argumentName, int valueOffset = 1, char redactedValue = '*')
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`argumentName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`valueOffset` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`redactedValue` [char](https://learn.microsoft.com/dotnet/api/system.char)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_CommandLine_CommandLineRedactor_RedactLogin_System_String_"></a> RedactLogin\(string\)

```csharp
public static string RedactLogin(string value)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

