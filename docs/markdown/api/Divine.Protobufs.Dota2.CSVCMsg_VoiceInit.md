# <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit"></a> Class CSVCMsg\_VoiceInit

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_VoiceInit : IMessage<CSVCMsg_VoiceInit>, IEquatable<CSVCMsg_VoiceInit>, IDeepCloneable<CSVCMsg_VoiceInit>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_VoiceInit](Divine.Protobufs.Dota2.CSVCMsg\_VoiceInit.md)

#### Implements

IMessage<CSVCMsg\_VoiceInit\>, 
[IEquatable<CSVCMsg\_VoiceInit\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_VoiceInit\>, 
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
[EnumerableExtensions.In<CSVCMsg\_VoiceInit\>\(CSVCMsg\_VoiceInit, params CSVCMsg\_VoiceInit\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit__ctor"></a> CSVCMsg\_VoiceInit\(\)

```csharp
public CSVCMsg_VoiceInit()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit__ctor_Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_"></a> CSVCMsg\_VoiceInit\(CSVCMsg\_VoiceInit\)

```csharp
public CSVCMsg_VoiceInit(CSVCMsg_VoiceInit other)
```

#### Parameters

`other` [CSVCMsg\_VoiceInit](Divine.Protobufs.Dota2.CSVCMsg\_VoiceInit.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_CodecFieldNumber"></a> CodecFieldNumber

```csharp
public const int CodecFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_QualityFieldNumber"></a> QualityFieldNumber

```csharp
public const int QualityFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_Codec"></a> Codec

```csharp
public string Codec { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_HasCodec"></a> HasCodec

```csharp
public bool HasCodec { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_HasQuality"></a> HasQuality

```csharp
public bool HasQuality { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_VoiceInit> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_VoiceInit](Divine.Protobufs.Dota2.CSVCMsg\_VoiceInit.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_Quality"></a> Quality

```csharp
public int Quality { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_Version"></a> Version

```csharp
public int Version { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_ClearCodec"></a> ClearCodec\(\)

```csharp
public void ClearCodec()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_ClearQuality"></a> ClearQuality\(\)

```csharp
public void ClearQuality()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_VoiceInit Clone()
```

#### Returns

 [CSVCMsg\_VoiceInit](Divine.Protobufs.Dota2.CSVCMsg\_VoiceInit.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_Equals_Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_"></a> Equals\(CSVCMsg\_VoiceInit\)

```csharp
public bool Equals(CSVCMsg_VoiceInit other)
```

#### Parameters

`other` [CSVCMsg\_VoiceInit](Divine.Protobufs.Dota2.CSVCMsg\_VoiceInit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_"></a> MergeFrom\(CSVCMsg\_VoiceInit\)

```csharp
public void MergeFrom(CSVCMsg_VoiceInit other)
```

#### Parameters

`other` [CSVCMsg\_VoiceInit](Divine.Protobufs.Dota2.CSVCMsg\_VoiceInit.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceInit_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

