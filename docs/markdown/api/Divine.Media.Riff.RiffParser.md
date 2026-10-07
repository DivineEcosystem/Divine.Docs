# <a id="Divine_Media_Riff_RiffParser"></a> Class RiffParser

Namespace: [Divine.Media.Riff](Divine.Media.Riff.md)  
Assembly: Divine.dll  

```csharp
public class RiffParser : IEnumerator<RiffChunk>, IEnumerator, IDisposable, IEnumerable<RiffChunk>, IEnumerable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[RiffParser](Divine.Media.Riff.RiffParser.md)

#### Implements

[IEnumerator<RiffChunk\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator\-1), 
[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IEnumerable<RiffChunk\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

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
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.Find<RiffChunk\>\(IEnumerable<RiffChunk\>, Predicate<RiffChunk\>\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_Find\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Predicate\_\_\_0\_\_), 
[EnumerableExtensions.In<RiffParser\>\(RiffParser, params RiffParser\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[EnumerableExtensions.MaxOrDefault<RiffChunk, TR\>\(IEnumerable<RiffChunk\>, Func<RiffChunk, TR\>\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_MaxOrDefault\_\_2\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Func\_\_\_0\_\_\_1\_\_), 
[EnumerableExtensions.MinOrDefault<RiffChunk, TR\>\(IEnumerable<RiffChunk\>, Func<RiffChunk, TR\>\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_MinOrDefault\_\_2\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Func\_\_\_0\_\_\_1\_\_)

## Constructors

### <a id="Divine_Media_Riff_RiffParser__ctor_System_IO_Stream_"></a> RiffParser\(Stream\)

Initializes a new instance of the <xref href="Divine.Media.Riff.RiffParser" data-throw-if-not-resolved="false"></xref> class.

```csharp
public RiffParser(Stream input)
```

#### Parameters

`input` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

The input.

## Properties

### <a id="Divine_Media_Riff_RiffParser_ChunkStack"></a> ChunkStack

Gets the current stack of chunks.

```csharp
public Stack<RiffChunk> ChunkStack { get; }
```

#### Property Value

 [Stack](https://learn.microsoft.com/dotnet/api/system.collections.generic.stack\-1)<[RiffChunk](Divine.Media.Riff.RiffChunk.md)\>

### <a id="Divine_Media_Riff_RiffParser_Current"></a> Current

Gets the element in the collection at the current position of the enumerator.

```csharp
public RiffChunk Current { get; }
```

#### Property Value

 [RiffChunk](Divine.Media.Riff.RiffChunk.md)

## Methods

### <a id="Divine_Media_Riff_RiffParser_Ascend"></a> Ascend\(\)

Ascends to the outer chunk.

```csharp
public void Ascend()
```

### <a id="Divine_Media_Riff_RiffParser_Descend"></a> Descend\(\)

Descends to the current chunk.

```csharp
public void Descend()
```

### <a id="Divine_Media_Riff_RiffParser_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="Divine_Media_Riff_RiffParser_GetAllChunks"></a> GetAllChunks\(\)

Gets all chunks.

```csharp
public IList<RiffChunk> GetAllChunks()
```

#### Returns

 [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<[RiffChunk](Divine.Media.Riff.RiffChunk.md)\>

### <a id="Divine_Media_Riff_RiffParser_GetEnumerator"></a> GetEnumerator\(\)

Returns an enumerator that iterates through the collection.

```csharp
public IEnumerator<RiffChunk> GetEnumerator()
```

#### Returns

 [IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator\-1)<[RiffChunk](Divine.Media.Riff.RiffChunk.md)\>

A <xref href="System.Collections.Generic.IEnumerator%601" data-throw-if-not-resolved="false"></xref> that can be used to iterate through the collection.

### <a id="Divine_Media_Riff_RiffParser_MoveNext"></a> MoveNext\(\)

Advances the enumerator to the next element of the collection.

```csharp
public bool MoveNext()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

true if the enumerator was successfully advanced to the next element; false if the enumerator has passed the end of the collection.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

The collection was modified after the enumerator was created.

### <a id="Divine_Media_Riff_RiffParser_Reset"></a> Reset\(\)

Sets the enumerator to its initial position, which is before the first element in the collection.

```csharp
public void Reset()
```

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

The collection was modified after the enumerator was created.

