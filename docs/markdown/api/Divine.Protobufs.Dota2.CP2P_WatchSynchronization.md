# <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization"></a> Class CP2P\_WatchSynchronization

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CP2P_WatchSynchronization : IMessage<CP2P_WatchSynchronization>, IEquatable<CP2P_WatchSynchronization>, IDeepCloneable<CP2P_WatchSynchronization>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CP2P\_WatchSynchronization](Divine.Protobufs.Dota2.CP2P\_WatchSynchronization.md)

#### Implements

IMessage<CP2P\_WatchSynchronization\>, 
[IEquatable<CP2P\_WatchSynchronization\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CP2P\_WatchSynchronization\>, 
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
[EnumerableExtensions.In<CP2P\_WatchSynchronization\>\(CP2P\_WatchSynchronization, params CP2P\_WatchSynchronization\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization__ctor"></a> CP2P\_WatchSynchronization\(\)

```csharp
public CP2P_WatchSynchronization()
```

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization__ctor_Divine_Protobufs_Dota2_CP2P_WatchSynchronization_"></a> CP2P\_WatchSynchronization\(CP2P\_WatchSynchronization\)

```csharp
public CP2P_WatchSynchronization(CP2P_WatchSynchronization other)
```

#### Parameters

`other` [CP2P\_WatchSynchronization](Divine.Protobufs.Dota2.CP2P\_WatchSynchronization.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_DemoTickFieldNumber"></a> DemoTickFieldNumber

```csharp
public const int DemoTickFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_DotaReplaySpeedFieldNumber"></a> DotaReplaySpeedFieldNumber

```csharp
public const int DotaReplaySpeedFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_DotaSpectatorAutospeedFieldNumber"></a> DotaSpectatorAutospeedFieldNumber

```csharp
public const int DotaSpectatorAutospeedFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_DotaSpectatorHeroIndexFieldNumber"></a> DotaSpectatorHeroIndexFieldNumber

```csharp
public const int DotaSpectatorHeroIndexFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_DotaSpectatorModeFieldNumber"></a> DotaSpectatorModeFieldNumber

```csharp
public const int DotaSpectatorModeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_DotaSpectatorWatchingBroadcasterFieldNumber"></a> DotaSpectatorWatchingBroadcasterFieldNumber

```csharp
public const int DotaSpectatorWatchingBroadcasterFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_PausedFieldNumber"></a> PausedFieldNumber

```csharp
public const int PausedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_TvListenVoiceIndicesFieldNumber"></a> TvListenVoiceIndicesFieldNumber

```csharp
public const int TvListenVoiceIndicesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_DemoTick"></a> DemoTick

```csharp
public int DemoTick { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_DotaReplaySpeed"></a> DotaReplaySpeed

```csharp
public int DotaReplaySpeed { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_DotaSpectatorAutospeed"></a> DotaSpectatorAutospeed

```csharp
public int DotaSpectatorAutospeed { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_DotaSpectatorHeroIndex"></a> DotaSpectatorHeroIndex

```csharp
public int DotaSpectatorHeroIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_DotaSpectatorMode"></a> DotaSpectatorMode

```csharp
public int DotaSpectatorMode { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_DotaSpectatorWatchingBroadcaster"></a> DotaSpectatorWatchingBroadcaster

```csharp
public bool DotaSpectatorWatchingBroadcaster { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_HasDemoTick"></a> HasDemoTick

```csharp
public bool HasDemoTick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_HasDotaReplaySpeed"></a> HasDotaReplaySpeed

```csharp
public bool HasDotaReplaySpeed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_HasDotaSpectatorAutospeed"></a> HasDotaSpectatorAutospeed

```csharp
public bool HasDotaSpectatorAutospeed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_HasDotaSpectatorHeroIndex"></a> HasDotaSpectatorHeroIndex

```csharp
public bool HasDotaSpectatorHeroIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_HasDotaSpectatorMode"></a> HasDotaSpectatorMode

```csharp
public bool HasDotaSpectatorMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_HasDotaSpectatorWatchingBroadcaster"></a> HasDotaSpectatorWatchingBroadcaster

```csharp
public bool HasDotaSpectatorWatchingBroadcaster { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_HasPaused"></a> HasPaused

```csharp
public bool HasPaused { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_HasTvListenVoiceIndices"></a> HasTvListenVoiceIndices

```csharp
public bool HasTvListenVoiceIndices { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_Parser"></a> Parser

```csharp
public static MessageParser<CP2P_WatchSynchronization> Parser { get; }
```

#### Property Value

 MessageParser<[CP2P\_WatchSynchronization](Divine.Protobufs.Dota2.CP2P\_WatchSynchronization.md)\>

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_Paused"></a> Paused

```csharp
public bool Paused { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_TvListenVoiceIndices"></a> TvListenVoiceIndices

```csharp
public ulong TvListenVoiceIndices { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_ClearDemoTick"></a> ClearDemoTick\(\)

```csharp
public void ClearDemoTick()
```

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_ClearDotaReplaySpeed"></a> ClearDotaReplaySpeed\(\)

```csharp
public void ClearDotaReplaySpeed()
```

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_ClearDotaSpectatorAutospeed"></a> ClearDotaSpectatorAutospeed\(\)

```csharp
public void ClearDotaSpectatorAutospeed()
```

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_ClearDotaSpectatorHeroIndex"></a> ClearDotaSpectatorHeroIndex\(\)

```csharp
public void ClearDotaSpectatorHeroIndex()
```

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_ClearDotaSpectatorMode"></a> ClearDotaSpectatorMode\(\)

```csharp
public void ClearDotaSpectatorMode()
```

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_ClearDotaSpectatorWatchingBroadcaster"></a> ClearDotaSpectatorWatchingBroadcaster\(\)

```csharp
public void ClearDotaSpectatorWatchingBroadcaster()
```

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_ClearPaused"></a> ClearPaused\(\)

```csharp
public void ClearPaused()
```

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_ClearTvListenVoiceIndices"></a> ClearTvListenVoiceIndices\(\)

```csharp
public void ClearTvListenVoiceIndices()
```

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_Clone"></a> Clone\(\)

```csharp
public CP2P_WatchSynchronization Clone()
```

#### Returns

 [CP2P\_WatchSynchronization](Divine.Protobufs.Dota2.CP2P\_WatchSynchronization.md)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_Equals_Divine_Protobufs_Dota2_CP2P_WatchSynchronization_"></a> Equals\(CP2P\_WatchSynchronization\)

```csharp
public bool Equals(CP2P_WatchSynchronization other)
```

#### Parameters

`other` [CP2P\_WatchSynchronization](Divine.Protobufs.Dota2.CP2P\_WatchSynchronization.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_MergeFrom_Divine_Protobufs_Dota2_CP2P_WatchSynchronization_"></a> MergeFrom\(CP2P\_WatchSynchronization\)

```csharp
public void MergeFrom(CP2P_WatchSynchronization other)
```

#### Parameters

`other` [CP2P\_WatchSynchronization](Divine.Protobufs.Dota2.CP2P\_WatchSynchronization.md)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CP2P_WatchSynchronization_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

