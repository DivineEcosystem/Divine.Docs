# <a id="Divine_ConsoleImpl_ConsoleTextWriter"></a> Class ConsoleTextWriter

Namespace: [Divine.ConsoleImpl](Divine.ConsoleImpl.md)  
Assembly: Divine.Common.dll  

```csharp
public sealed class ConsoleTextWriter : TextWriter, IDisposable, IAsyncDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MarshalByRefObject](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject) ← 
[TextWriter](https://learn.microsoft.com/dotnet/api/system.io.textwriter) ← 
[ConsoleTextWriter](Divine.ConsoleImpl.ConsoleTextWriter.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IAsyncDisposable](https://learn.microsoft.com/dotnet/api/system.iasyncdisposable)

#### Inherited Members

[TextWriter.Null](https://learn.microsoft.com/dotnet/api/system.io.textwriter.null), 
[TextWriter.Close\(\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.close), 
[TextWriter.Dispose\(\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.dispose\#system\-io\-textwriter\-dispose), 
[TextWriter.DisposeAsync\(\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.disposeasync), 
[TextWriter.Flush\(\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.flush), 
[TextWriter.Write\(char\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-char\)), 
[TextWriter.Write\(Rune\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-text\-rune\)), 
[TextWriter.Write\(char\[\]?\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-char\(\)\)), 
[TextWriter.Write\(char\[\], int, int\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-char\(\)\-system\-int32\-system\-int32\)), 
[TextWriter.Write\(ReadOnlySpan<char\>\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-readonlyspan\(\(system\-char\)\)\)), 
[TextWriter.Write\(bool\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-boolean\)), 
[TextWriter.Write\(int\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-int32\)), 
[TextWriter.Write\(uint\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-uint32\)), 
[TextWriter.Write\(long\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-int64\)), 
[TextWriter.Write\(ulong\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-uint64\)), 
[TextWriter.Write\(float\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-single\)), 
[TextWriter.Write\(double\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-double\)), 
[TextWriter.Write\(decimal\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-decimal\)), 
[TextWriter.Write\(string?\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-string\)), 
[TextWriter.Write\(object?\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-object\)), 
[TextWriter.Write\(StringBuilder?\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-text\-stringbuilder\)), 
[TextWriter.Write\(string, object?\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-string\-system\-object\)), 
[TextWriter.Write\(string, object?, object?\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-string\-system\-object\-system\-object\)), 
[TextWriter.Write\(string, object?, object?, object?\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-string\-system\-object\-system\-object\-system\-object\)), 
[TextWriter.Write\(string, params object?\[\]\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-string\-system\-object\(\)\)), 
[TextWriter.Write\(string, params ReadOnlySpan<object?\>\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.write\#system\-io\-textwriter\-write\(system\-string\-system\-readonlyspan\(\(system\-object\)\)\)), 
[TextWriter.WriteLine\(\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline), 
[TextWriter.WriteLine\(char\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-char\)), 
[TextWriter.WriteLine\(Rune\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-text\-rune\)), 
[TextWriter.WriteLine\(char\[\]?\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-char\(\)\)), 
[TextWriter.WriteLine\(char\[\], int, int\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-char\(\)\-system\-int32\-system\-int32\)), 
[TextWriter.WriteLine\(ReadOnlySpan<char\>\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-readonlyspan\(\(system\-char\)\)\)), 
[TextWriter.WriteLine\(bool\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-boolean\)), 
[TextWriter.WriteLine\(int\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-int32\)), 
[TextWriter.WriteLine\(uint\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-uint32\)), 
[TextWriter.WriteLine\(long\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-int64\)), 
[TextWriter.WriteLine\(ulong\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-uint64\)), 
[TextWriter.WriteLine\(float\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-single\)), 
[TextWriter.WriteLine\(double\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-double\)), 
[TextWriter.WriteLine\(decimal\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-decimal\)), 
[TextWriter.WriteLine\(string?\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-string\)), 
[TextWriter.WriteLine\(StringBuilder?\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-text\-stringbuilder\)), 
[TextWriter.WriteLine\(object?\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-object\)), 
[TextWriter.WriteLine\(string, object?\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-string\-system\-object\)), 
[TextWriter.WriteLine\(string, object?, object?\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-string\-system\-object\-system\-object\)), 
[TextWriter.WriteLine\(string, object?, object?, object?\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-string\-system\-object\-system\-object\-system\-object\)), 
[TextWriter.WriteLine\(string, params object?\[\]\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-string\-system\-object\(\)\)), 
[TextWriter.WriteLine\(string, params ReadOnlySpan<object?\>\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeline\#system\-io\-textwriter\-writeline\(system\-string\-system\-readonlyspan\(\(system\-object\)\)\)), 
[TextWriter.WriteAsync\(char\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeasync\#system\-io\-textwriter\-writeasync\(system\-char\)), 
[TextWriter.WriteAsync\(Rune\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeasync\#system\-io\-textwriter\-writeasync\(system\-text\-rune\)), 
[TextWriter.WriteAsync\(string?\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeasync\#system\-io\-textwriter\-writeasync\(system\-string\)), 
[TextWriter.WriteAsync\(string?, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeasync\#system\-io\-textwriter\-writeasync\(system\-string\-system\-threading\-cancellationtoken\)), 
[TextWriter.WriteAsync\(StringBuilder?, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeasync\#system\-io\-textwriter\-writeasync\(system\-text\-stringbuilder\-system\-threading\-cancellationtoken\)), 
[TextWriter.WriteAsync\(char\[\]?\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeasync\#system\-io\-textwriter\-writeasync\(system\-char\(\)\)), 
[TextWriter.WriteAsync\(char\[\], int, int\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeasync\#system\-io\-textwriter\-writeasync\(system\-char\(\)\-system\-int32\-system\-int32\)), 
[TextWriter.WriteAsync\(ReadOnlyMemory<char\>, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writeasync\#system\-io\-textwriter\-writeasync\(system\-readonlymemory\(\(system\-char\)\)\-system\-threading\-cancellationtoken\)), 
[TextWriter.WriteLineAsync\(char\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writelineasync\#system\-io\-textwriter\-writelineasync\(system\-char\)), 
[TextWriter.WriteLineAsync\(Rune\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writelineasync\#system\-io\-textwriter\-writelineasync\(system\-text\-rune\)), 
[TextWriter.WriteLineAsync\(string?\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writelineasync\#system\-io\-textwriter\-writelineasync\(system\-string\)), 
[TextWriter.WriteLineAsync\(string?, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writelineasync\#system\-io\-textwriter\-writelineasync\(system\-string\-system\-threading\-cancellationtoken\)), 
[TextWriter.WriteLineAsync\(StringBuilder?, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writelineasync\#system\-io\-textwriter\-writelineasync\(system\-text\-stringbuilder\-system\-threading\-cancellationtoken\)), 
[TextWriter.WriteLineAsync\(char\[\]?\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writelineasync\#system\-io\-textwriter\-writelineasync\(system\-char\(\)\)), 
[TextWriter.WriteLineAsync\(char\[\], int, int\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writelineasync\#system\-io\-textwriter\-writelineasync\(system\-char\(\)\-system\-int32\-system\-int32\)), 
[TextWriter.WriteLineAsync\(ReadOnlyMemory<char\>, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writelineasync\#system\-io\-textwriter\-writelineasync\(system\-readonlymemory\(\(system\-char\)\)\-system\-threading\-cancellationtoken\)), 
[TextWriter.WriteLineAsync\(\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writelineasync\#system\-io\-textwriter\-writelineasync), 
[TextWriter.WriteLineAsync\(CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.writelineasync\#system\-io\-textwriter\-writelineasync\(system\-threading\-cancellationtoken\)), 
[TextWriter.FlushAsync\(\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.flushasync\#system\-io\-textwriter\-flushasync), 
[TextWriter.FlushAsync\(CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.flushasync\#system\-io\-textwriter\-flushasync\(system\-threading\-cancellationtoken\)), 
[TextWriter.Synchronized\(TextWriter\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.synchronized), 
[TextWriter.CreateBroadcasting\(params TextWriter\[\]\)](https://learn.microsoft.com/dotnet/api/system.io.textwriter.createbroadcasting), 
[TextWriter.FormatProvider](https://learn.microsoft.com/dotnet/api/system.io.textwriter.formatprovider), 
[TextWriter.Encoding](https://learn.microsoft.com/dotnet/api/system.io.textwriter.encoding), 
[TextWriter.NewLine](https://learn.microsoft.com/dotnet/api/system.io.textwriter.newline), 
[MarshalByRefObject.GetLifetimeService\(\)](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject.getlifetimeservice), 
[MarshalByRefObject.InitializeLifetimeService\(\)](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject.initializelifetimeservice), 
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
[EnumerableExtensions.In<ConsoleTextWriter\>\(ConsoleTextWriter, params ConsoleTextWriter\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_ConsoleImpl_ConsoleTextWriter__ctor_System_Int32_"></a> ConsoleTextWriter\(int\)

```csharp
public ConsoleTextWriter(int capacity = 4000000)
```

#### Parameters

`capacity` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_Encoding"></a> Encoding

```csharp
public override Encoding Encoding { get; }
```

#### Property Value

 [Encoding](https://learn.microsoft.com/dotnet/api/system.text.encoding)

## Methods

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_CopyTo_System_IO_Stream_"></a> CopyTo\(Stream\)

```csharp
public void CopyTo(Stream stream)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected override void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_ReplayTo_Divine_ConsoleImpl_AnsiParser_"></a> ReplayTo\(AnsiParser\)

```csharp
public void ReplayTo(AnsiParser parser)
```

#### Parameters

`parser` [AnsiParser](Divine.ConsoleImpl.AnsiParser.md)

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_Write_System_Char_"></a> Write\(char\)

```csharp
public override void Write(char value)
```

#### Parameters

`value` [char](https://learn.microsoft.com/dotnet/api/system.char)

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_Write_System_String_"></a> Write\(string?\)

```csharp
public override void Write(string? value)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_Write_System_Text_StringBuilder_"></a> Write\(StringBuilder?\)

```csharp
public override void Write(StringBuilder? value)
```

#### Parameters

`value` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)?

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_Write_System_Char___System_Int32_System_Int32_"></a> Write\(char\[\], int, int\)

```csharp
public override void Write(char[] buffer, int index, int count)
```

#### Parameters

`buffer` [char](https://learn.microsoft.com/dotnet/api/system.char)\[\]

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_Write_System_ReadOnlySpan_System_Char__"></a> Write\(ReadOnlySpan<char\>\)

```csharp
public override void Write(ReadOnlySpan<char> buffer)
```

#### Parameters

`buffer` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_WriteAsync_System_Char_"></a> WriteAsync\(char\)

```csharp
public override Task WriteAsync(char value)
```

#### Parameters

`value` [char](https://learn.microsoft.com/dotnet/api/system.char)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_WriteAsync_System_String_"></a> WriteAsync\(string?\)

```csharp
public override Task WriteAsync(string? value)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)?

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_WriteAsync_System_Text_StringBuilder_System_Threading_CancellationToken_"></a> WriteAsync\(StringBuilder?, CancellationToken\)

```csharp
public override Task WriteAsync(StringBuilder? value, CancellationToken cancellationToken = default)
```

#### Parameters

`value` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)?

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_WriteAsync_System_Char___System_Int32_System_Int32_"></a> WriteAsync\(char\[\], int, int\)

```csharp
public override Task WriteAsync(char[] buffer, int index, int count)
```

#### Parameters

`buffer` [char](https://learn.microsoft.com/dotnet/api/system.char)\[\]

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_WriteAsync_System_ReadOnlyMemory_System_Char__System_Threading_CancellationToken_"></a> WriteAsync\(ReadOnlyMemory<char\>, CancellationToken\)

```csharp
public override Task WriteAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default)
```

#### Parameters

`buffer` [ReadOnlyMemory](https://learn.microsoft.com/dotnet/api/system.readonlymemory\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_WriteLine"></a> WriteLine\(\)

```csharp
public override void WriteLine()
```

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_WriteLine_System_Char_"></a> WriteLine\(char\)

```csharp
public override void WriteLine(char value)
```

#### Parameters

`value` [char](https://learn.microsoft.com/dotnet/api/system.char)

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_WriteLine_System_String_"></a> WriteLine\(string?\)

```csharp
public override void WriteLine(string? value)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_WriteLine_System_Text_StringBuilder_"></a> WriteLine\(StringBuilder?\)

```csharp
public override void WriteLine(StringBuilder? value)
```

#### Parameters

`value` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)?

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_WriteLine_System_Char___System_Int32_System_Int32_"></a> WriteLine\(char\[\], int, int\)

```csharp
public override void WriteLine(char[] buffer, int index, int count)
```

#### Parameters

`buffer` [char](https://learn.microsoft.com/dotnet/api/system.char)\[\]

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_WriteLine_System_ReadOnlySpan_System_Char__"></a> WriteLine\(ReadOnlySpan<char\>\)

```csharp
public override void WriteLine(ReadOnlySpan<char> buffer)
```

#### Parameters

`buffer` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_WriteLineAsync_System_Char_"></a> WriteLineAsync\(char\)

```csharp
public override Task WriteLineAsync(char value)
```

#### Parameters

`value` [char](https://learn.microsoft.com/dotnet/api/system.char)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_WriteLineAsync_System_String_"></a> WriteLineAsync\(string?\)

```csharp
public override Task WriteLineAsync(string? value)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)?

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_WriteLineAsync_System_Text_StringBuilder_System_Threading_CancellationToken_"></a> WriteLineAsync\(StringBuilder?, CancellationToken\)

```csharp
public override Task WriteLineAsync(StringBuilder? value, CancellationToken cancellationToken = default)
```

#### Parameters

`value` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)?

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_WriteLineAsync_System_Char___System_Int32_System_Int32_"></a> WriteLineAsync\(char\[\], int, int\)

```csharp
public override Task WriteLineAsync(char[] buffer, int index, int count)
```

#### Parameters

`buffer` [char](https://learn.microsoft.com/dotnet/api/system.char)\[\]

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_WriteLineAsync_System_ReadOnlyMemory_System_Char__System_Threading_CancellationToken_"></a> WriteLineAsync\(ReadOnlyMemory<char\>, CancellationToken\)

```csharp
public override Task WriteLineAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default)
```

#### Parameters

`buffer` [ReadOnlyMemory](https://learn.microsoft.com/dotnet/api/system.readonlymemory\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="Divine_ConsoleImpl_ConsoleTextWriter_Written"></a> Written

```csharp
public event Action<ReadOnlySpan<char>>? Written
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>\>?

