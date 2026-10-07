# <a id="Divine_IO_GameFileStream"></a> Class GameFileStream

Namespace: [Divine.IO](Divine.IO.md)  
Assembly: Divine.dll  

```csharp
public sealed class GameFileStream : Stream, IAsyncDisposable, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MarshalByRefObject](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject) ← 
[Stream](https://learn.microsoft.com/dotnet/api/system.io.stream) ← 
[GameFileStream](Divine.IO.GameFileStream.md)

#### Implements

[IAsyncDisposable](https://learn.microsoft.com/dotnet/api/system.iasyncdisposable), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[Stream.Null](https://learn.microsoft.com/dotnet/api/system.io.stream.null), 
[Stream.BeginRead\(byte\[\], int, int, AsyncCallback?, object?\)](https://learn.microsoft.com/dotnet/api/system.io.stream.beginread), 
[Stream.BeginWrite\(byte\[\], int, int, AsyncCallback?, object?\)](https://learn.microsoft.com/dotnet/api/system.io.stream.beginwrite), 
[Stream.Close\(\)](https://learn.microsoft.com/dotnet/api/system.io.stream.close), 
[Stream.CopyTo\(Stream\)](https://learn.microsoft.com/dotnet/api/system.io.stream.copyto\#system\-io\-stream\-copyto\(system\-io\-stream\)), 
[Stream.CopyTo\(Stream, int\)](https://learn.microsoft.com/dotnet/api/system.io.stream.copyto\#system\-io\-stream\-copyto\(system\-io\-stream\-system\-int32\)), 
[Stream.CopyToAsync\(Stream\)](https://learn.microsoft.com/dotnet/api/system.io.stream.copytoasync\#system\-io\-stream\-copytoasync\(system\-io\-stream\)), 
[Stream.CopyToAsync\(Stream, int\)](https://learn.microsoft.com/dotnet/api/system.io.stream.copytoasync\#system\-io\-stream\-copytoasync\(system\-io\-stream\-system\-int32\)), 
[Stream.CopyToAsync\(Stream, int, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.copytoasync\#system\-io\-stream\-copytoasync\(system\-io\-stream\-system\-int32\-system\-threading\-cancellationtoken\)), 
[Stream.CopyToAsync\(Stream, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.copytoasync\#system\-io\-stream\-copytoasync\(system\-io\-stream\-system\-threading\-cancellationtoken\)), 
[Stream.Dispose\(\)](https://learn.microsoft.com/dotnet/api/system.io.stream.dispose\#system\-io\-stream\-dispose), 
[Stream.DisposeAsync\(\)](https://learn.microsoft.com/dotnet/api/system.io.stream.disposeasync), 
[Stream.EndRead\(IAsyncResult\)](https://learn.microsoft.com/dotnet/api/system.io.stream.endread), 
[Stream.EndWrite\(IAsyncResult\)](https://learn.microsoft.com/dotnet/api/system.io.stream.endwrite), 
[Stream.Flush\(\)](https://learn.microsoft.com/dotnet/api/system.io.stream.flush), 
[Stream.FlushAsync\(\)](https://learn.microsoft.com/dotnet/api/system.io.stream.flushasync\#system\-io\-stream\-flushasync), 
[Stream.FlushAsync\(CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.flushasync\#system\-io\-stream\-flushasync\(system\-threading\-cancellationtoken\)), 
[Stream.Read\(byte\[\], int, int\)](https://learn.microsoft.com/dotnet/api/system.io.stream.read\#system\-io\-stream\-read\(system\-byte\(\)\-system\-int32\-system\-int32\)), 
[Stream.Read\(Span<byte\>\)](https://learn.microsoft.com/dotnet/api/system.io.stream.read\#system\-io\-stream\-read\(system\-span\(\(system\-byte\)\)\)), 
[Stream.ReadAsync\(byte\[\], int, int\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readasync\#system\-io\-stream\-readasync\(system\-byte\(\)\-system\-int32\-system\-int32\)), 
[Stream.ReadAsync\(byte\[\], int, int, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readasync\#system\-io\-stream\-readasync\(system\-byte\(\)\-system\-int32\-system\-int32\-system\-threading\-cancellationtoken\)), 
[Stream.ReadAsync\(Memory<byte\>, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readasync\#system\-io\-stream\-readasync\(system\-memory\(\(system\-byte\)\)\-system\-threading\-cancellationtoken\)), 
[Stream.ReadAtLeast\(Span<byte\>, int, bool\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readatleast), 
[Stream.ReadAtLeastAsync\(Memory<byte\>, int, bool, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readatleastasync), 
[Stream.ReadByte\(\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readbyte), 
[Stream.ReadExactly\(byte\[\], int, int\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readexactly\#system\-io\-stream\-readexactly\(system\-byte\(\)\-system\-int32\-system\-int32\)), 
[Stream.ReadExactly\(Span<byte\>\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readexactly\#system\-io\-stream\-readexactly\(system\-span\(\(system\-byte\)\)\)), 
[Stream.ReadExactlyAsync\(byte\[\], int, int, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readexactlyasync\#system\-io\-stream\-readexactlyasync\(system\-byte\(\)\-system\-int32\-system\-int32\-system\-threading\-cancellationtoken\)), 
[Stream.ReadExactlyAsync\(Memory<byte\>, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readexactlyasync\#system\-io\-stream\-readexactlyasync\(system\-memory\(\(system\-byte\)\)\-system\-threading\-cancellationtoken\)), 
[Stream.Seek\(long, SeekOrigin\)](https://learn.microsoft.com/dotnet/api/system.io.stream.seek), 
[Stream.SetLength\(long\)](https://learn.microsoft.com/dotnet/api/system.io.stream.setlength), 
[Stream.Synchronized\(Stream\)](https://learn.microsoft.com/dotnet/api/system.io.stream.synchronized), 
[Stream.Write\(byte\[\], int, int\)](https://learn.microsoft.com/dotnet/api/system.io.stream.write\#system\-io\-stream\-write\(system\-byte\(\)\-system\-int32\-system\-int32\)), 
[Stream.Write\(ReadOnlySpan<byte\>\)](https://learn.microsoft.com/dotnet/api/system.io.stream.write\#system\-io\-stream\-write\(system\-readonlyspan\(\(system\-byte\)\)\)), 
[Stream.WriteAsync\(byte\[\], int, int\)](https://learn.microsoft.com/dotnet/api/system.io.stream.writeasync\#system\-io\-stream\-writeasync\(system\-byte\(\)\-system\-int32\-system\-int32\)), 
[Stream.WriteAsync\(byte\[\], int, int, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.writeasync\#system\-io\-stream\-writeasync\(system\-byte\(\)\-system\-int32\-system\-int32\-system\-threading\-cancellationtoken\)), 
[Stream.WriteAsync\(ReadOnlyMemory<byte\>, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.writeasync\#system\-io\-stream\-writeasync\(system\-readonlymemory\(\(system\-byte\)\)\-system\-threading\-cancellationtoken\)), 
[Stream.WriteByte\(byte\)](https://learn.microsoft.com/dotnet/api/system.io.stream.writebyte), 
[Stream.CanRead](https://learn.microsoft.com/dotnet/api/system.io.stream.canread), 
[Stream.CanSeek](https://learn.microsoft.com/dotnet/api/system.io.stream.canseek), 
[Stream.CanTimeout](https://learn.microsoft.com/dotnet/api/system.io.stream.cantimeout), 
[Stream.CanWrite](https://learn.microsoft.com/dotnet/api/system.io.stream.canwrite), 
[Stream.Length](https://learn.microsoft.com/dotnet/api/system.io.stream.length), 
[Stream.Position](https://learn.microsoft.com/dotnet/api/system.io.stream.position), 
[Stream.ReadTimeout](https://learn.microsoft.com/dotnet/api/system.io.stream.readtimeout), 
[Stream.WriteTimeout](https://learn.microsoft.com/dotnet/api/system.io.stream.writetimeout), 
[MarshalByRefObject.GetLifetimeService\(\)](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject.getlifetimeservice), 
[MarshalByRefObject.InitializeLifetimeService\(\)](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject.initializelifetimeservice), 
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
[EnumerableExtensions.In<GameFileStream\>\(GameFileStream, params GameFileStream\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_IO_GameFileStream_CanRead"></a> CanRead

When overridden in a derived class, gets a value indicating whether the current stream supports reading.

```csharp
public override bool CanRead { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_IO_GameFileStream_CanSeek"></a> CanSeek

When overridden in a derived class, gets a value indicating whether the current stream supports seeking.

```csharp
public override bool CanSeek { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_IO_GameFileStream_CanWrite"></a> CanWrite

When overridden in a derived class, gets a value indicating whether the current stream supports writing.

```csharp
public override bool CanWrite { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_IO_GameFileStream_Length"></a> Length

When overridden in a derived class, gets the length in bytes of the stream.

```csharp
public override long Length { get; }
```

#### Property Value

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

#### Exceptions

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

A class derived from <code>Stream</code> does not support seeking and the length is unknown.

 [ObjectDisposedException](https://learn.microsoft.com/dotnet/api/system.objectdisposedexception)

Methods were called after the stream was closed.

### <a id="Divine_IO_GameFileStream_Position"></a> Position

When overridden in a derived class, gets or sets the position within the current stream.

```csharp
public override long Position { get; set; }
```

#### Property Value

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

#### Exceptions

 [IOException](https://learn.microsoft.com/dotnet/api/system.io.ioexception)

An I/O error occurs.

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The stream does not support seeking.

 [ObjectDisposedException](https://learn.microsoft.com/dotnet/api/system.objectdisposedexception)

Methods were called after the stream was closed.

## Methods

### <a id="Divine_IO_GameFileStream_Dispose_System_Boolean_"></a> Dispose\(bool\)

Releases the unmanaged resources used by the <xref href="System.IO.Stream" data-throw-if-not-resolved="false"></xref> and optionally releases the managed resources.

```csharp
protected override void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> to release both managed and unmanaged resources; <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a> to release only unmanaged resources.

### <a id="Divine_IO_GameFileStream_Finalize"></a> \~GameFileStream\(\)

```csharp
protected ~GameFileStream()
```

### <a id="Divine_IO_GameFileStream_Flush"></a> Flush\(\)

When overridden in a derived class, clears all buffers for this stream and causes any buffered data to be written to the underlying device.

```csharp
public override void Flush()
```

#### Exceptions

 [IOException](https://learn.microsoft.com/dotnet/api/system.io.ioexception)

An I/O error occurs.

### <a id="Divine_IO_GameFileStream_Read_System_Byte___System_Int32_System_Int32_"></a> Read\(byte\[\], int, int\)

When overridden in a derived class, reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.

```csharp
public override int Read(byte[] buffer, int offset, int count)
```

#### Parameters

`buffer` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

An array of bytes. When this method returns, the buffer contains the specified byte array with the values between <code class="paramref">offset</code> and (<code class="paramref">offset</code> + <code class="paramref">count</code> - 1) replaced by the bytes read from the current source.

`offset` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The zero-based byte offset in <code class="paramref">buffer</code> at which to begin storing the data read from the current stream.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The maximum number of bytes to be read from the current stream.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

The total number of bytes read into the buffer. This can be less than the number of bytes requested if that many bytes are not currently available, or zero (0) if <code class="paramref">count</code> is 0 or the end of the stream has been reached.

#### Exceptions

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

The sum of <code class="paramref">offset</code> and <code class="paramref">count</code> is larger than the buffer length.

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

<code class="paramref">buffer</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

<code class="paramref">offset</code> or <code class="paramref">count</code> is negative.

 [IOException](https://learn.microsoft.com/dotnet/api/system.io.ioexception)

An I/O error occurs.

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The stream does not support reading.

 [ObjectDisposedException](https://learn.microsoft.com/dotnet/api/system.objectdisposedexception)

Methods were called after the stream was closed.

### <a id="Divine_IO_GameFileStream_Seek_System_Int64_System_IO_SeekOrigin_"></a> Seek\(long, SeekOrigin\)

When overridden in a derived class, sets the position within the current stream.

```csharp
public override long Seek(long offset, SeekOrigin origin)
```

#### Parameters

`offset` [long](https://learn.microsoft.com/dotnet/api/system.int64)

A byte offset relative to the <code class="paramref">origin</code> parameter.

`origin` [SeekOrigin](https://learn.microsoft.com/dotnet/api/system.io.seekorigin)

A value of type <xref href="System.IO.SeekOrigin" data-throw-if-not-resolved="false"></xref> indicating the reference point used to obtain the new position.

#### Returns

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

The new position within the current stream.

#### Exceptions

 [IOException](https://learn.microsoft.com/dotnet/api/system.io.ioexception)

An I/O error occurs.

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The stream does not support seeking, such as if the stream is constructed from a pipe or console output.

 [ObjectDisposedException](https://learn.microsoft.com/dotnet/api/system.objectdisposedexception)

Methods were called after the stream was closed.

### <a id="Divine_IO_GameFileStream_SetLength_System_Int64_"></a> SetLength\(long\)

When overridden in a derived class, sets the length of the current stream.

```csharp
public override void SetLength(long value)
```

#### Parameters

`value` [long](https://learn.microsoft.com/dotnet/api/system.int64)

The desired length of the current stream in bytes.

#### Exceptions

 [IOException](https://learn.microsoft.com/dotnet/api/system.io.ioexception)

An I/O error occurs.

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The stream does not support both writing and seeking, such as if the stream is constructed from a pipe or console output.

 [ObjectDisposedException](https://learn.microsoft.com/dotnet/api/system.objectdisposedexception)

Methods were called after the stream was closed.

### <a id="Divine_IO_GameFileStream_ToArray"></a> ToArray\(\)

```csharp
public byte[] ToArray()
```

#### Returns

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

### <a id="Divine_IO_GameFileStream_Write_System_Byte___System_Int32_System_Int32_"></a> Write\(byte\[\], int, int\)

When overridden in a derived class, writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written.

```csharp
public override void Write(byte[] buffer, int offset, int count)
```

#### Parameters

`buffer` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

An array of bytes. This method copies <code class="paramref">count</code> bytes from <code class="paramref">buffer</code> to the current stream.

`offset` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The zero-based byte offset in <code class="paramref">buffer</code> at which to begin copying bytes to the current stream.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of bytes to be written to the current stream.

#### Exceptions

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

The sum of <code class="paramref">offset</code> and <code class="paramref">count</code> is greater than the buffer length.

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

<code class="paramref">buffer</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

<code class="paramref">offset</code> or <code class="paramref">count</code> is negative.

 [IOException](https://learn.microsoft.com/dotnet/api/system.io.ioexception)

An I/O error occurred, such as the specified file cannot be found.

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The stream does not support writing.

 [ObjectDisposedException](https://learn.microsoft.com/dotnet/api/system.objectdisposedexception)

<xref href="System.IO.Stream.Write(System.Byte%5b%5d%2cSystem.Int32%2cSystem.Int32)" data-throw-if-not-resolved="false"></xref> was called after the stream was closed.

