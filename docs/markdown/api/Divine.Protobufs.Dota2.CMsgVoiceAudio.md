# <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio"></a> Class CMsgVoiceAudio

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgVoiceAudio : IMessage<CMsgVoiceAudio>, IEquatable<CMsgVoiceAudio>, IDeepCloneable<CMsgVoiceAudio>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgVoiceAudio](Divine.Protobufs.Dota2.CMsgVoiceAudio.md)

#### Implements

IMessage<CMsgVoiceAudio\>, 
[IEquatable<CMsgVoiceAudio\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgVoiceAudio\>, 
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
[EnumerableExtensions.In<CMsgVoiceAudio\>\(CMsgVoiceAudio, params CMsgVoiceAudio\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio__ctor"></a> CMsgVoiceAudio\(\)

```csharp
public CMsgVoiceAudio()
```

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio__ctor_Divine_Protobufs_Dota2_CMsgVoiceAudio_"></a> CMsgVoiceAudio\(CMsgVoiceAudio\)

```csharp
public CMsgVoiceAudio(CMsgVoiceAudio other)
```

#### Parameters

`other` [CMsgVoiceAudio](Divine.Protobufs.Dota2.CMsgVoiceAudio.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_FormatFieldNumber"></a> FormatFieldNumber

```csharp
public const int FormatFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_NumPacketsFieldNumber"></a> NumPacketsFieldNumber

```csharp
public const int NumPacketsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_PacketOffsetsFieldNumber"></a> PacketOffsetsFieldNumber

```csharp
public const int PacketOffsetsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_SampleRateFieldNumber"></a> SampleRateFieldNumber

```csharp
public const int SampleRateFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_SectionNumberFieldNumber"></a> SectionNumberFieldNumber

```csharp
public const int SectionNumberFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_SequenceBytesFieldNumber"></a> SequenceBytesFieldNumber

```csharp
public const int SequenceBytesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_UncompressedSampleOffsetFieldNumber"></a> UncompressedSampleOffsetFieldNumber

```csharp
public const int UncompressedSampleOffsetFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_VoiceDataFieldNumber"></a> VoiceDataFieldNumber

```csharp
public const int VoiceDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_VoiceLevelFieldNumber"></a> VoiceLevelFieldNumber

```csharp
public const int VoiceLevelFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_Format"></a> Format

```csharp
public VoiceDataFormat_t Format { get; set; }
```

#### Property Value

 [VoiceDataFormat\_t](Divine.Protobufs.Dota2.VoiceDataFormat\_t.md)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_HasFormat"></a> HasFormat

```csharp
public bool HasFormat { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_HasNumPackets"></a> HasNumPackets

```csharp
public bool HasNumPackets { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_HasSampleRate"></a> HasSampleRate

```csharp
public bool HasSampleRate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_HasSectionNumber"></a> HasSectionNumber

```csharp
public bool HasSectionNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_HasSequenceBytes"></a> HasSequenceBytes

```csharp
public bool HasSequenceBytes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_HasUncompressedSampleOffset"></a> HasUncompressedSampleOffset

```csharp
public bool HasUncompressedSampleOffset { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_HasVoiceData"></a> HasVoiceData

```csharp
public bool HasVoiceData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_HasVoiceLevel"></a> HasVoiceLevel

```csharp
public bool HasVoiceLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_NumPackets"></a> NumPackets

```csharp
public uint NumPackets { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_PacketOffsets"></a> PacketOffsets

```csharp
public RepeatedField<uint> PacketOffsets { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_Parser"></a> Parser

```csharp
public static MessageParser<CMsgVoiceAudio> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgVoiceAudio](Divine.Protobufs.Dota2.CMsgVoiceAudio.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_SampleRate"></a> SampleRate

```csharp
public uint SampleRate { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_SectionNumber"></a> SectionNumber

```csharp
public uint SectionNumber { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_SequenceBytes"></a> SequenceBytes

```csharp
public int SequenceBytes { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_UncompressedSampleOffset"></a> UncompressedSampleOffset

```csharp
public uint UncompressedSampleOffset { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_VoiceData"></a> VoiceData

```csharp
public ByteString VoiceData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_VoiceLevel"></a> VoiceLevel

```csharp
public float VoiceLevel { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_ClearFormat"></a> ClearFormat\(\)

```csharp
public void ClearFormat()
```

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_ClearNumPackets"></a> ClearNumPackets\(\)

```csharp
public void ClearNumPackets()
```

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_ClearSampleRate"></a> ClearSampleRate\(\)

```csharp
public void ClearSampleRate()
```

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_ClearSectionNumber"></a> ClearSectionNumber\(\)

```csharp
public void ClearSectionNumber()
```

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_ClearSequenceBytes"></a> ClearSequenceBytes\(\)

```csharp
public void ClearSequenceBytes()
```

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_ClearUncompressedSampleOffset"></a> ClearUncompressedSampleOffset\(\)

```csharp
public void ClearUncompressedSampleOffset()
```

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_ClearVoiceData"></a> ClearVoiceData\(\)

```csharp
public void ClearVoiceData()
```

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_ClearVoiceLevel"></a> ClearVoiceLevel\(\)

```csharp
public void ClearVoiceLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_Clone"></a> Clone\(\)

```csharp
public CMsgVoiceAudio Clone()
```

#### Returns

 [CMsgVoiceAudio](Divine.Protobufs.Dota2.CMsgVoiceAudio.md)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_Equals_Divine_Protobufs_Dota2_CMsgVoiceAudio_"></a> Equals\(CMsgVoiceAudio\)

```csharp
public bool Equals(CMsgVoiceAudio other)
```

#### Parameters

`other` [CMsgVoiceAudio](Divine.Protobufs.Dota2.CMsgVoiceAudio.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_MergeFrom_Divine_Protobufs_Dota2_CMsgVoiceAudio_"></a> MergeFrom\(CMsgVoiceAudio\)

```csharp
public void MergeFrom(CMsgVoiceAudio other)
```

#### Parameters

`other` [CMsgVoiceAudio](Divine.Protobufs.Dota2.CMsgVoiceAudio.md)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgVoiceAudio_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

