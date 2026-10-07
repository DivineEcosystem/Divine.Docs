# <a id="Divine_Protobufs_Dota2_CDemoFileInfo"></a> Class CDemoFileInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDemoFileInfo : IMessage<CDemoFileInfo>, IEquatable<CDemoFileInfo>, IDeepCloneable<CDemoFileInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDemoFileInfo](Divine.Protobufs.Dota2.CDemoFileInfo.md)

#### Implements

IMessage<CDemoFileInfo\>, 
[IEquatable<CDemoFileInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDemoFileInfo\>, 
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
[EnumerableExtensions.In<CDemoFileInfo\>\(CDemoFileInfo, params CDemoFileInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo__ctor"></a> CDemoFileInfo\(\)

```csharp
public CDemoFileInfo()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo__ctor_Divine_Protobufs_Dota2_CDemoFileInfo_"></a> CDemoFileInfo\(CDemoFileInfo\)

```csharp
public CDemoFileInfo(CDemoFileInfo other)
```

#### Parameters

`other` [CDemoFileInfo](Divine.Protobufs.Dota2.CDemoFileInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_GameInfoFieldNumber"></a> GameInfoFieldNumber

```csharp
public const int GameInfoFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_PlaybackFramesFieldNumber"></a> PlaybackFramesFieldNumber

```csharp
public const int PlaybackFramesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_PlaybackTicksFieldNumber"></a> PlaybackTicksFieldNumber

```csharp
public const int PlaybackTicksFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_PlaybackTimeFieldNumber"></a> PlaybackTimeFieldNumber

```csharp
public const int PlaybackTimeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_GameInfo"></a> GameInfo

```csharp
public CGameInfo GameInfo { get; set; }
```

#### Property Value

 [CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md)

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_HasPlaybackFrames"></a> HasPlaybackFrames

```csharp
public bool HasPlaybackFrames { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_HasPlaybackTicks"></a> HasPlaybackTicks

```csharp
public bool HasPlaybackTicks { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_HasPlaybackTime"></a> HasPlaybackTime

```csharp
public bool HasPlaybackTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_Parser"></a> Parser

```csharp
public static MessageParser<CDemoFileInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CDemoFileInfo](Divine.Protobufs.Dota2.CDemoFileInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_PlaybackFrames"></a> PlaybackFrames

```csharp
public int PlaybackFrames { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_PlaybackTicks"></a> PlaybackTicks

```csharp
public int PlaybackTicks { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_PlaybackTime"></a> PlaybackTime

```csharp
public float PlaybackTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_ClearPlaybackFrames"></a> ClearPlaybackFrames\(\)

```csharp
public void ClearPlaybackFrames()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_ClearPlaybackTicks"></a> ClearPlaybackTicks\(\)

```csharp
public void ClearPlaybackTicks()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_ClearPlaybackTime"></a> ClearPlaybackTime\(\)

```csharp
public void ClearPlaybackTime()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_Clone"></a> Clone\(\)

```csharp
public CDemoFileInfo Clone()
```

#### Returns

 [CDemoFileInfo](Divine.Protobufs.Dota2.CDemoFileInfo.md)

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_Equals_Divine_Protobufs_Dota2_CDemoFileInfo_"></a> Equals\(CDemoFileInfo\)

```csharp
public bool Equals(CDemoFileInfo other)
```

#### Parameters

`other` [CDemoFileInfo](Divine.Protobufs.Dota2.CDemoFileInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_MergeFrom_Divine_Protobufs_Dota2_CDemoFileInfo_"></a> MergeFrom\(CDemoFileInfo\)

```csharp
public void MergeFrom(CDemoFileInfo other)
```

#### Parameters

`other` [CDemoFileInfo](Divine.Protobufs.Dota2.CDemoFileInfo.md)

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoFileInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

