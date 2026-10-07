# <a id="Divine_Protobufs_Dota2_CSVCMsg_SetPause"></a> Class CSVCMsg\_SetPause

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_SetPause : IMessage<CSVCMsg_SetPause>, IEquatable<CSVCMsg_SetPause>, IDeepCloneable<CSVCMsg_SetPause>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_SetPause](Divine.Protobufs.Dota2.CSVCMsg\_SetPause.md)

#### Implements

IMessage<CSVCMsg\_SetPause\>, 
[IEquatable<CSVCMsg\_SetPause\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_SetPause\>, 
IBufferMessage, 
IMessage

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
[EnumerableExtensions.In<CSVCMsg\_SetPause\>\(CSVCMsg\_SetPause, params CSVCMsg\_SetPause\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetPause__ctor"></a> CSVCMsg\_SetPause\(\)

```csharp
public CSVCMsg_SetPause()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetPause__ctor_Divine_Protobufs_Dota2_CSVCMsg_SetPause_"></a> CSVCMsg\_SetPause\(CSVCMsg\_SetPause\)

```csharp
public CSVCMsg_SetPause(CSVCMsg_SetPause other)
```

#### Parameters

`other` [CSVCMsg\_SetPause](Divine.Protobufs.Dota2.CSVCMsg\_SetPause.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetPause_PausedFieldNumber"></a> PausedFieldNumber

```csharp
public const int PausedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetPause_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetPause_HasPaused"></a> HasPaused

```csharp
public bool HasPaused { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetPause_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_SetPause> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_SetPause](Divine.Protobufs.Dota2.CSVCMsg\_SetPause.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetPause_Paused"></a> Paused

```csharp
public bool Paused { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetPause_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetPause_ClearPaused"></a> ClearPaused\(\)

```csharp
public void ClearPaused()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetPause_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_SetPause Clone()
```

#### Returns

 [CSVCMsg\_SetPause](Divine.Protobufs.Dota2.CSVCMsg\_SetPause.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetPause_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetPause_Equals_Divine_Protobufs_Dota2_CSVCMsg_SetPause_"></a> Equals\(CSVCMsg\_SetPause\)

```csharp
public bool Equals(CSVCMsg_SetPause other)
```

#### Parameters

`other` [CSVCMsg\_SetPause](Divine.Protobufs.Dota2.CSVCMsg\_SetPause.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetPause_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetPause_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_SetPause_"></a> MergeFrom\(CSVCMsg\_SetPause\)

```csharp
public void MergeFrom(CSVCMsg_SetPause other)
```

#### Parameters

`other` [CSVCMsg\_SetPause](Divine.Protobufs.Dota2.CSVCMsg\_SetPause.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetPause_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetPause_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetPause_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

