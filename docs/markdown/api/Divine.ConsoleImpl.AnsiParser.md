# <a id="Divine_ConsoleImpl_AnsiParser"></a> Class AnsiParser

Namespace: [Divine.ConsoleImpl](Divine.ConsoleImpl.md)  
Assembly: Divine.Common.dll  

```csharp
public sealed class AnsiParser
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AnsiParser](Divine.ConsoleImpl.AnsiParser.md)

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
[EnumerableExtensions.In<AnsiParser\>\(AnsiParser, params AnsiParser\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_ConsoleImpl_AnsiParser__ctor_System_Action_System_ReadOnlySpan_System_Char__System_Nullable_System_ConsoleColor__System_Nullable_System_ConsoleColor___"></a> AnsiParser\(Action<ReadOnlySpan<char\>, ConsoleColor?, ConsoleColor?\>\)

```csharp
public AnsiParser(Action<ReadOnlySpan<char>, ConsoleColor?, ConsoleColor?> parseWrite)
```

#### Parameters

`parseWrite` [Action](https://learn.microsoft.com/dotnet/api/system.action\-3)<[ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>, [ConsoleColor](https://learn.microsoft.com/dotnet/api/system.consolecolor)?, [ConsoleColor](https://learn.microsoft.com/dotnet/api/system.consolecolor)?\>

## Fields

### <a id="Divine_ConsoleImpl_AnsiParser_DefaultBackgroundColor"></a> DefaultBackgroundColor

```csharp
public const string DefaultBackgroundColor = "\u001b[49m"
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_ConsoleImpl_AnsiParser_DefaultForegroundColor"></a> DefaultForegroundColor

```csharp
public const string DefaultForegroundColor = "\u001b[39m\u001b[22m"
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_ConsoleImpl_AnsiParser_GetBackgroundColorEscapeCode_System_ConsoleColor_"></a> GetBackgroundColorEscapeCode\(ConsoleColor\)

```csharp
public static string GetBackgroundColorEscapeCode(ConsoleColor color)
```

#### Parameters

`color` [ConsoleColor](https://learn.microsoft.com/dotnet/api/system.consolecolor)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_ConsoleImpl_AnsiParser_GetForegroundColorEscapeCode_System_ConsoleColor_"></a> GetForegroundColorEscapeCode\(ConsoleColor\)

```csharp
public static string GetForegroundColorEscapeCode(ConsoleColor color)
```

#### Parameters

`color` [ConsoleColor](https://learn.microsoft.com/dotnet/api/system.consolecolor)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_ConsoleImpl_AnsiParser_Parse_System_ReadOnlySpan_System_Char__"></a> Parse\(ReadOnlySpan<char\>\)

```csharp
public void Parse(ReadOnlySpan<char> message)
```

#### Parameters

`message` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

