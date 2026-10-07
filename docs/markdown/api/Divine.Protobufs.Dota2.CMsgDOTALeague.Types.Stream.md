# <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream"></a> Class CMsgDOTALeague.Types.Stream

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeague.Types.Stream : IMessage<CMsgDOTALeague.Types.Stream>, IEquatable<CMsgDOTALeague.Types.Stream>, IDeepCloneable<CMsgDOTALeague.Types.Stream>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeague.Types.Stream](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.Stream.md)

#### Implements

IMessage<CMsgDOTALeague.Types.Stream\>, 
[IEquatable<CMsgDOTALeague.Types.Stream\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeague.Types.Stream\>, 
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
[EnumerableExtensions.In<CMsgDOTALeague.Types.Stream\>\(CMsgDOTALeague.Types.Stream, params CMsgDOTALeague.Types.Stream\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream__ctor"></a> Stream\(\)

```csharp
public Stream()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream__ctor_Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_"></a> Stream\(Stream\)

```csharp
public Stream(CMsgDOTALeague.Types.Stream other)
```

#### Parameters

`other` [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[Stream](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.Stream.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_BroadcastProviderFieldNumber"></a> BroadcastProviderFieldNumber

```csharp
public const int BroadcastProviderFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_LanguageFieldNumber"></a> LanguageFieldNumber

```csharp
public const int LanguageFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_StreamIdFieldNumber"></a> StreamIdFieldNumber

```csharp
public const int StreamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_StreamUrlFieldNumber"></a> StreamUrlFieldNumber

```csharp
public const int StreamUrlFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_VodUrlFieldNumber"></a> VodUrlFieldNumber

```csharp
public const int VodUrlFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_BroadcastProvider"></a> BroadcastProvider

```csharp
public ELeagueBroadcastProvider BroadcastProvider { get; set; }
```

#### Property Value

 [ELeagueBroadcastProvider](Divine.Protobufs.Dota2.ELeagueBroadcastProvider.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_HasBroadcastProvider"></a> HasBroadcastProvider

```csharp
public bool HasBroadcastProvider { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_HasLanguage"></a> HasLanguage

```csharp
public bool HasLanguage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_HasStreamId"></a> HasStreamId

```csharp
public bool HasStreamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_HasStreamUrl"></a> HasStreamUrl

```csharp
public bool HasStreamUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_HasVodUrl"></a> HasVodUrl

```csharp
public bool HasVodUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_Language"></a> Language

```csharp
public uint Language { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeague.Types.Stream> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[Stream](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.Stream.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_StreamId"></a> StreamId

```csharp
public uint StreamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_StreamUrl"></a> StreamUrl

```csharp
public string StreamUrl { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_VodUrl"></a> VodUrl

```csharp
public string VodUrl { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_ClearBroadcastProvider"></a> ClearBroadcastProvider\(\)

```csharp
public void ClearBroadcastProvider()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_ClearLanguage"></a> ClearLanguage\(\)

```csharp
public void ClearLanguage()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_ClearStreamId"></a> ClearStreamId\(\)

```csharp
public void ClearStreamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_ClearStreamUrl"></a> ClearStreamUrl\(\)

```csharp
public void ClearStreamUrl()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_ClearVodUrl"></a> ClearVodUrl\(\)

```csharp
public void ClearVodUrl()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeague.Types.Stream Clone()
```

#### Returns

 [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[Stream](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.Stream.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_Equals_Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_"></a> Equals\(Stream\)

```csharp
public bool Equals(CMsgDOTALeague.Types.Stream other)
```

#### Parameters

`other` [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[Stream](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.Stream.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_"></a> MergeFrom\(Stream\)

```csharp
public void MergeFrom(CMsgDOTALeague.Types.Stream other)
```

#### Parameters

`other` [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[Stream](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.Stream.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_Stream_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

