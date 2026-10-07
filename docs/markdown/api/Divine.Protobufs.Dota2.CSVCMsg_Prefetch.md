# <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch"></a> Class CSVCMsg\_Prefetch

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_Prefetch : IMessage<CSVCMsg_Prefetch>, IEquatable<CSVCMsg_Prefetch>, IDeepCloneable<CSVCMsg_Prefetch>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_Prefetch](Divine.Protobufs.Dota2.CSVCMsg\_Prefetch.md)

#### Implements

IMessage<CSVCMsg\_Prefetch\>, 
[IEquatable<CSVCMsg\_Prefetch\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_Prefetch\>, 
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
[EnumerableExtensions.In<CSVCMsg\_Prefetch\>\(CSVCMsg\_Prefetch, params CSVCMsg\_Prefetch\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch__ctor"></a> CSVCMsg\_Prefetch\(\)

```csharp
public CSVCMsg_Prefetch()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch__ctor_Divine_Protobufs_Dota2_CSVCMsg_Prefetch_"></a> CSVCMsg\_Prefetch\(CSVCMsg\_Prefetch\)

```csharp
public CSVCMsg_Prefetch(CSVCMsg_Prefetch other)
```

#### Parameters

`other` [CSVCMsg\_Prefetch](Divine.Protobufs.Dota2.CSVCMsg\_Prefetch.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch_ResourceTypeFieldNumber"></a> ResourceTypeFieldNumber

```csharp
public const int ResourceTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch_SoundIndexFieldNumber"></a> SoundIndexFieldNumber

```csharp
public const int SoundIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch_HasResourceType"></a> HasResourceType

```csharp
public bool HasResourceType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch_HasSoundIndex"></a> HasSoundIndex

```csharp
public bool HasSoundIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_Prefetch> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_Prefetch](Divine.Protobufs.Dota2.CSVCMsg\_Prefetch.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch_ResourceType"></a> ResourceType

```csharp
public PrefetchType ResourceType { get; set; }
```

#### Property Value

 [PrefetchType](Divine.Protobufs.Dota2.PrefetchType.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch_SoundIndex"></a> SoundIndex

```csharp
public int SoundIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch_ClearResourceType"></a> ClearResourceType\(\)

```csharp
public void ClearResourceType()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch_ClearSoundIndex"></a> ClearSoundIndex\(\)

```csharp
public void ClearSoundIndex()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_Prefetch Clone()
```

#### Returns

 [CSVCMsg\_Prefetch](Divine.Protobufs.Dota2.CSVCMsg\_Prefetch.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch_Equals_Divine_Protobufs_Dota2_CSVCMsg_Prefetch_"></a> Equals\(CSVCMsg\_Prefetch\)

```csharp
public bool Equals(CSVCMsg_Prefetch other)
```

#### Parameters

`other` [CSVCMsg\_Prefetch](Divine.Protobufs.Dota2.CSVCMsg\_Prefetch.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_Prefetch_"></a> MergeFrom\(CSVCMsg\_Prefetch\)

```csharp
public void MergeFrom(CSVCMsg_Prefetch other)
```

#### Parameters

`other` [CSVCMsg\_Prefetch](Divine.Protobufs.Dota2.CSVCMsg\_Prefetch.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Prefetch_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

