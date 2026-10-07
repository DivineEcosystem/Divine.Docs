# <a id="Divine_Media_Riff_RiffChunk"></a> Class RiffChunk

Namespace: [Divine.Media.Riff](Divine.Media.Riff.md)  
Assembly: Divine.dll  

```csharp
public class RiffChunk
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[RiffChunk](Divine.Media.Riff.RiffChunk.md)

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
[EnumerableExtensions.In<RiffChunk\>\(RiffChunk, params RiffChunk\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Media_Riff_RiffChunk__ctor_System_IO_Stream_Divine_Media_Riff_FourCC_System_UInt32_System_UInt32_System_Boolean_System_Boolean_"></a> RiffChunk\(Stream, FourCC, uint, uint, bool, bool\)

Initializes a new instance of the <xref href="Divine.Media.Riff.RiffChunk" data-throw-if-not-resolved="false"></xref> class.

```csharp
public RiffChunk(Stream stream, FourCC type, uint size, uint dataPosition, bool isList = false, bool isHeader = false)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

The stream holding this chunk

`type` [FourCC](Divine.Media.Riff.FourCC.md)

The type.

`size` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

The size.

`dataPosition` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

The data offset.

`isList` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

if set to <code>true</code> [is list].

`isHeader` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

if set to <code>true</code> [is header].

## Properties

### <a id="Divine_Media_Riff_RiffChunk_DataPosition"></a> DataPosition

Gets the position of the data embedded by this chunk relative to the stream.

```csharp
public uint DataPosition { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Media_Riff_RiffChunk_IsHeader"></a> IsHeader

Gets a value indicating whether this instance is a header chunk.

```csharp
public bool IsHeader { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Media_Riff_RiffChunk_IsList"></a> IsList

Gets or sets a value indicating whether this instance is a list chunk.

```csharp
public bool IsList { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Media_Riff_RiffChunk_Size"></a> Size

Gets the size of the data embedded by this chunk.

```csharp
public uint Size { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Media_Riff_RiffChunk_Stream"></a> Stream

Gets the type.

```csharp
public Stream Stream { get; }
```

#### Property Value

 [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

### <a id="Divine_Media_Riff_RiffChunk_Type"></a> Type

Gets the <xref href="Divine.Media.Riff.FourCC" data-throw-if-not-resolved="false"></xref> of this chunk.

```csharp
public FourCC Type { get; }
```

#### Property Value

 [FourCC](Divine.Media.Riff.FourCC.md)

## Methods

### <a id="Divine_Media_Riff_RiffChunk_GetData"></a> GetData\(\)

Gets the raw data contained in this chunk.

```csharp
public byte[] GetData()
```

#### Returns

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

### <a id="Divine_Media_Riff_RiffChunk_ToString"></a> ToString\(\)

Returns a <xref href="System.String" data-throw-if-not-resolved="false"></xref> that represents this instance.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A <xref href="System.String" data-throw-if-not-resolved="false"></xref> that represents this instance.

