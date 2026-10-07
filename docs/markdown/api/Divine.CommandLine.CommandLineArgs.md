# <a id="Divine_CommandLine_CommandLineArgs"></a> Class CommandLineArgs

Namespace: [Divine.CommandLine](Divine.CommandLine.md)  
Assembly: Divine.Common.dll  

```csharp
public sealed class CommandLineArgs : IReadOnlyList<string>, IReadOnlyCollection<string>, IEnumerable<string>, IEnumerable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CommandLineArgs](Divine.CommandLine.CommandLineArgs.md)

#### Implements

[IReadOnlyList<string\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1), 
[IReadOnlyCollection<string\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<string\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

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
[EnumerableExtensions.In<CommandLineArgs\>\(CommandLineArgs, params CommandLineArgs\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_CommandLine_CommandLineArgs__ctor_System_String___"></a> CommandLineArgs\(string\[\]\)

```csharp
public CommandLineArgs(string[] args)
```

#### Parameters

`args` [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

## Properties

### <a id="Divine_CommandLine_CommandLineArgs_Count"></a> Count

```csharp
public int Count { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_CommandLine_CommandLineArgs_Item_System_Int32_"></a> this\[int\]

```csharp
public string this[int index] { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_CommandLine_CommandLineArgs_Value"></a> Value

```csharp
public string[] Value { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

## Methods

### <a id="Divine_CommandLine_CommandLineArgs_AsArray"></a> AsArray\(\)

```csharp
public string[] AsArray()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

### <a id="Divine_CommandLine_CommandLineArgs_AsSpan"></a> AsSpan\(\)

```csharp
public ReadOnlySpan<string> AsSpan()
```

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_CommandLine_CommandLineArgs_Create_System_ReadOnlySpan_System_String__"></a> Create\(ReadOnlySpan<string\>\)

```csharp
public static CommandLineArgs Create(ReadOnlySpan<string> args)
```

#### Parameters

`args` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Returns

 [CommandLineArgs](Divine.CommandLine.CommandLineArgs.md)

### <a id="Divine_CommandLine_CommandLineArgs_GetEnumerator"></a> GetEnumerator\(\)

```csharp
public IEnumerator<string> GetEnumerator()
```

#### Returns

 [IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_CommandLine_CommandLineArgs_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Divine_CommandLine_CommandLineArgs_op_Implicit_System_String____Divine_CommandLine_CommandLineArgs"></a> implicit operator CommandLineArgs\(string\[\]\)

```csharp
public static implicit operator CommandLineArgs(string[] args)
```

#### Parameters

`args` [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

#### Returns

 [CommandLineArgs](Divine.CommandLine.CommandLineArgs.md)

### <a id="Divine_CommandLine_CommandLineArgs_op_Implicit_Divine_CommandLine_CommandLineArgs__System_String__"></a> implicit operator string\[\]\(CommandLineArgs\)

```csharp
public static implicit operator string[](CommandLineArgs args)
```

#### Parameters

`args` [CommandLineArgs](Divine.CommandLine.CommandLineArgs.md)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

### <a id="Divine_CommandLine_CommandLineArgs_op_Implicit_Divine_CommandLine_CommandLineArgs__System_ReadOnlySpan_System_String_"></a> implicit operator ReadOnlySpan<string\>\(CommandLineArgs\)

```csharp
public static implicit operator ReadOnlySpan<string>(CommandLineArgs args)
```

#### Parameters

`args` [CommandLineArgs](Divine.CommandLine.CommandLineArgs.md)

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

