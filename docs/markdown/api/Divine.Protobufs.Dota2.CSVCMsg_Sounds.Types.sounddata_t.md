# <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t"></a> Class CSVCMsg\_Sounds.Types.sounddata\_t

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_Sounds.Types.sounddata_t : IMessage<CSVCMsg_Sounds.Types.sounddata_t>, IEquatable<CSVCMsg_Sounds.Types.sounddata_t>, IDeepCloneable<CSVCMsg_Sounds.Types.sounddata_t>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_Sounds.Types.sounddata\_t](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.Types.sounddata\_t.md)

#### Implements

IMessage<CSVCMsg\_Sounds.Types.sounddata\_t\>, 
[IEquatable<CSVCMsg\_Sounds.Types.sounddata\_t\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_Sounds.Types.sounddata\_t\>, 
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
[EnumerableExtensions.In<CSVCMsg\_Sounds.Types.sounddata\_t\>\(CSVCMsg\_Sounds.Types.sounddata\_t, params CSVCMsg\_Sounds.Types.sounddata\_t\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t__ctor"></a> sounddata\_t\(\)

```csharp
public sounddata_t()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t__ctor_Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_"></a> sounddata\_t\(sounddata\_t\)

```csharp
public sounddata_t(CSVCMsg_Sounds.Types.sounddata_t other)
```

#### Parameters

`other` [CSVCMsg\_Sounds](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.Types.md).[sounddata\_t](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.Types.sounddata\_t.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ChannelFieldNumber"></a> ChannelFieldNumber

```csharp
public const int ChannelFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_DelayValueFieldNumber"></a> DelayValueFieldNumber

```csharp
public const int DelayValueFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_EntityIndexFieldNumber"></a> EntityIndexFieldNumber

```csharp
public const int EntityIndexFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_GuidFieldNumber"></a> GuidFieldNumber

```csharp
public const int GuidFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_IsAmbientFieldNumber"></a> IsAmbientFieldNumber

```csharp
public const int IsAmbientFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_IsSentenceFieldNumber"></a> IsSentenceFieldNumber

```csharp
public const int IsSentenceFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_OriginXFieldNumber"></a> OriginXFieldNumber

```csharp
public const int OriginXFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_OriginYFieldNumber"></a> OriginYFieldNumber

```csharp
public const int OriginYFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_OriginZFieldNumber"></a> OriginZFieldNumber

```csharp
public const int OriginZFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_PitchFieldNumber"></a> PitchFieldNumber

```csharp
public const int PitchFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_RandomSeedFieldNumber"></a> RandomSeedFieldNumber

```csharp
public const int RandomSeedFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_SequenceNumberFieldNumber"></a> SequenceNumberFieldNumber

```csharp
public const int SequenceNumberFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_SoundLevelFieldNumber"></a> SoundLevelFieldNumber

```csharp
public const int SoundLevelFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_SoundNumFieldNumber"></a> SoundNumFieldNumber

```csharp
public const int SoundNumFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_SoundNumHandleFieldNumber"></a> SoundNumHandleFieldNumber

```csharp
public const int SoundNumHandleFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_SoundResourceIdFieldNumber"></a> SoundResourceIdFieldNumber

```csharp
public const int SoundResourceIdFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_SpeakerEntityFieldNumber"></a> SpeakerEntityFieldNumber

```csharp
public const int SpeakerEntityFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_VolumeFieldNumber"></a> VolumeFieldNumber

```csharp
public const int VolumeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_Channel"></a> Channel

```csharp
public int Channel { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_DelayValue"></a> DelayValue

```csharp
public float DelayValue { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_EntityIndex"></a> EntityIndex

```csharp
public int EntityIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_Flags"></a> Flags

```csharp
public int Flags { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_Guid"></a> Guid

```csharp
public uint Guid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_HasChannel"></a> HasChannel

```csharp
public bool HasChannel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_HasDelayValue"></a> HasDelayValue

```csharp
public bool HasDelayValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_HasEntityIndex"></a> HasEntityIndex

```csharp
public bool HasEntityIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_HasGuid"></a> HasGuid

```csharp
public bool HasGuid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_HasIsAmbient"></a> HasIsAmbient

```csharp
public bool HasIsAmbient { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_HasIsSentence"></a> HasIsSentence

```csharp
public bool HasIsSentence { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_HasOriginX"></a> HasOriginX

```csharp
public bool HasOriginX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_HasOriginY"></a> HasOriginY

```csharp
public bool HasOriginY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_HasOriginZ"></a> HasOriginZ

```csharp
public bool HasOriginZ { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_HasPitch"></a> HasPitch

```csharp
public bool HasPitch { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_HasRandomSeed"></a> HasRandomSeed

```csharp
public bool HasRandomSeed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_HasSequenceNumber"></a> HasSequenceNumber

```csharp
public bool HasSequenceNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_HasSoundLevel"></a> HasSoundLevel

```csharp
public bool HasSoundLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_HasSoundNum"></a> HasSoundNum

```csharp
public bool HasSoundNum { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_HasSoundNumHandle"></a> HasSoundNumHandle

```csharp
public bool HasSoundNumHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_HasSoundResourceId"></a> HasSoundResourceId

```csharp
public bool HasSoundResourceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_HasSpeakerEntity"></a> HasSpeakerEntity

```csharp
public bool HasSpeakerEntity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_HasVolume"></a> HasVolume

```csharp
public bool HasVolume { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_IsAmbient"></a> IsAmbient

```csharp
public bool IsAmbient { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_IsSentence"></a> IsSentence

```csharp
public bool IsSentence { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_OriginX"></a> OriginX

```csharp
public int OriginX { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_OriginY"></a> OriginY

```csharp
public int OriginY { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_OriginZ"></a> OriginZ

```csharp
public int OriginZ { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_Sounds.Types.sounddata_t> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_Sounds](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.Types.md).[sounddata\_t](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.Types.sounddata\_t.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_Pitch"></a> Pitch

```csharp
public int Pitch { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_RandomSeed"></a> RandomSeed

```csharp
public int RandomSeed { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_SequenceNumber"></a> SequenceNumber

```csharp
public int SequenceNumber { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_SoundLevel"></a> SoundLevel

```csharp
public int SoundLevel { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_SoundNum"></a> SoundNum

```csharp
public uint SoundNum { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_SoundNumHandle"></a> SoundNumHandle

```csharp
public uint SoundNumHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_SoundResourceId"></a> SoundResourceId

```csharp
public ulong SoundResourceId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_SpeakerEntity"></a> SpeakerEntity

```csharp
public int SpeakerEntity { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_Volume"></a> Volume

```csharp
public uint Volume { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ClearChannel"></a> ClearChannel\(\)

```csharp
public void ClearChannel()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ClearDelayValue"></a> ClearDelayValue\(\)

```csharp
public void ClearDelayValue()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ClearEntityIndex"></a> ClearEntityIndex\(\)

```csharp
public void ClearEntityIndex()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ClearGuid"></a> ClearGuid\(\)

```csharp
public void ClearGuid()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ClearIsAmbient"></a> ClearIsAmbient\(\)

```csharp
public void ClearIsAmbient()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ClearIsSentence"></a> ClearIsSentence\(\)

```csharp
public void ClearIsSentence()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ClearOriginX"></a> ClearOriginX\(\)

```csharp
public void ClearOriginX()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ClearOriginY"></a> ClearOriginY\(\)

```csharp
public void ClearOriginY()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ClearOriginZ"></a> ClearOriginZ\(\)

```csharp
public void ClearOriginZ()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ClearPitch"></a> ClearPitch\(\)

```csharp
public void ClearPitch()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ClearRandomSeed"></a> ClearRandomSeed\(\)

```csharp
public void ClearRandomSeed()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ClearSequenceNumber"></a> ClearSequenceNumber\(\)

```csharp
public void ClearSequenceNumber()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ClearSoundLevel"></a> ClearSoundLevel\(\)

```csharp
public void ClearSoundLevel()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ClearSoundNum"></a> ClearSoundNum\(\)

```csharp
public void ClearSoundNum()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ClearSoundNumHandle"></a> ClearSoundNumHandle\(\)

```csharp
public void ClearSoundNumHandle()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ClearSoundResourceId"></a> ClearSoundResourceId\(\)

```csharp
public void ClearSoundResourceId()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ClearSpeakerEntity"></a> ClearSpeakerEntity\(\)

```csharp
public void ClearSpeakerEntity()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ClearVolume"></a> ClearVolume\(\)

```csharp
public void ClearVolume()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_Sounds.Types.sounddata_t Clone()
```

#### Returns

 [CSVCMsg\_Sounds](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.Types.md).[sounddata\_t](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.Types.sounddata\_t.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_Equals_Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_"></a> Equals\(sounddata\_t\)

```csharp
public bool Equals(CSVCMsg_Sounds.Types.sounddata_t other)
```

#### Parameters

`other` [CSVCMsg\_Sounds](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.Types.md).[sounddata\_t](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.Types.sounddata\_t.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_"></a> MergeFrom\(sounddata\_t\)

```csharp
public void MergeFrom(CSVCMsg_Sounds.Types.sounddata_t other)
```

#### Parameters

`other` [CSVCMsg\_Sounds](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.Types.md).[sounddata\_t](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.Types.sounddata\_t.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Types_sounddata_t_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

