# <a id="Divine_Media_SoundData"></a> Class SoundData

Namespace: [Divine.Media](Divine.Media.md)  
Assembly: Divine.dll  

```csharp
public sealed class SoundData
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SoundData](Divine.Media.SoundData.md)

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
[EnumerableExtensions.In<SoundData\>\(SoundData, params SoundData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Media_SoundData__ctor_System_String_"></a> SoundData\(string\)

```csharp
public SoundData(string file)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Media_SoundData__ctor_System_IO_Stream_"></a> SoundData\(Stream\)

```csharp
public SoundData(Stream stream)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

## Properties

### <a id="Divine_Media_SoundData_Data"></a> Data

```csharp
public byte[] Data { get; }
```

#### Property Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

### <a id="Divine_Media_SoundData_Format"></a> Format

```csharp
public WaveFormatEx Format { get; }
```

#### Property Value

 WaveFormatEx

### <a id="Divine_Media_SoundData_FormatName"></a> FormatName

```csharp
public string FormatName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

