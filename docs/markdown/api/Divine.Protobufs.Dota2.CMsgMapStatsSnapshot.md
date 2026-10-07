# <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot"></a> Class CMsgMapStatsSnapshot

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMapStatsSnapshot : IMessage<CMsgMapStatsSnapshot>, IEquatable<CMsgMapStatsSnapshot>, IDeepCloneable<CMsgMapStatsSnapshot>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMapStatsSnapshot](Divine.Protobufs.Dota2.CMsgMapStatsSnapshot.md)

#### Implements

IMessage<CMsgMapStatsSnapshot\>, 
[IEquatable<CMsgMapStatsSnapshot\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMapStatsSnapshot\>, 
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
[EnumerableExtensions.In<CMsgMapStatsSnapshot\>\(CMsgMapStatsSnapshot, params CMsgMapStatsSnapshot\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot__ctor"></a> CMsgMapStatsSnapshot\(\)

```csharp
public CMsgMapStatsSnapshot()
```

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot__ctor_Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_"></a> CMsgMapStatsSnapshot\(CMsgMapStatsSnapshot\)

```csharp
public CMsgMapStatsSnapshot(CMsgMapStatsSnapshot other)
```

#### Parameters

`other` [CMsgMapStatsSnapshot](Divine.Protobufs.Dota2.CMsgMapStatsSnapshot.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_LotusesGainedFieldNumber"></a> LotusesGainedFieldNumber

```csharp
public const int LotusesGainedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_OutpostsCapturedFieldNumber"></a> OutpostsCapturedFieldNumber

```csharp
public const int OutpostsCapturedFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_PortalsUsedFieldNumber"></a> PortalsUsedFieldNumber

```csharp
public const int PortalsUsedFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_RoshanKillsDayFieldNumber"></a> RoshanKillsDayFieldNumber

```csharp
public const int RoshanKillsDayFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_RoshanKillsNightFieldNumber"></a> RoshanKillsNightFieldNumber

```csharp
public const int RoshanKillsNightFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_ShieldRunesGainedFieldNumber"></a> ShieldRunesGainedFieldNumber

```csharp
public const int ShieldRunesGainedFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_TormentorKillsFieldNumber"></a> TormentorKillsFieldNumber

```csharp
public const int TormentorKillsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_WatchersTakenFieldNumber"></a> WatchersTakenFieldNumber

```csharp
public const int WatchersTakenFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_WisdomRunesGainedFieldNumber"></a> WisdomRunesGainedFieldNumber

```csharp
public const int WisdomRunesGainedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_HasLotusesGained"></a> HasLotusesGained

```csharp
public bool HasLotusesGained { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_HasOutpostsCaptured"></a> HasOutpostsCaptured

```csharp
public bool HasOutpostsCaptured { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_HasPortalsUsed"></a> HasPortalsUsed

```csharp
public bool HasPortalsUsed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_HasRoshanKillsDay"></a> HasRoshanKillsDay

```csharp
public bool HasRoshanKillsDay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_HasRoshanKillsNight"></a> HasRoshanKillsNight

```csharp
public bool HasRoshanKillsNight { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_HasShieldRunesGained"></a> HasShieldRunesGained

```csharp
public bool HasShieldRunesGained { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_HasTormentorKills"></a> HasTormentorKills

```csharp
public bool HasTormentorKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_HasWatchersTaken"></a> HasWatchersTaken

```csharp
public bool HasWatchersTaken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_HasWisdomRunesGained"></a> HasWisdomRunesGained

```csharp
public bool HasWisdomRunesGained { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_LotusesGained"></a> LotusesGained

```csharp
public ulong LotusesGained { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_OutpostsCaptured"></a> OutpostsCaptured

```csharp
public ulong OutpostsCaptured { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMapStatsSnapshot> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMapStatsSnapshot](Divine.Protobufs.Dota2.CMsgMapStatsSnapshot.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_PortalsUsed"></a> PortalsUsed

```csharp
public ulong PortalsUsed { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_RoshanKillsDay"></a> RoshanKillsDay

```csharp
public ulong RoshanKillsDay { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_RoshanKillsNight"></a> RoshanKillsNight

```csharp
public ulong RoshanKillsNight { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_ShieldRunesGained"></a> ShieldRunesGained

```csharp
public ulong ShieldRunesGained { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_TormentorKills"></a> TormentorKills

```csharp
public ulong TormentorKills { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_WatchersTaken"></a> WatchersTaken

```csharp
public ulong WatchersTaken { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_WisdomRunesGained"></a> WisdomRunesGained

```csharp
public ulong WisdomRunesGained { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_ClearLotusesGained"></a> ClearLotusesGained\(\)

```csharp
public void ClearLotusesGained()
```

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_ClearOutpostsCaptured"></a> ClearOutpostsCaptured\(\)

```csharp
public void ClearOutpostsCaptured()
```

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_ClearPortalsUsed"></a> ClearPortalsUsed\(\)

```csharp
public void ClearPortalsUsed()
```

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_ClearRoshanKillsDay"></a> ClearRoshanKillsDay\(\)

```csharp
public void ClearRoshanKillsDay()
```

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_ClearRoshanKillsNight"></a> ClearRoshanKillsNight\(\)

```csharp
public void ClearRoshanKillsNight()
```

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_ClearShieldRunesGained"></a> ClearShieldRunesGained\(\)

```csharp
public void ClearShieldRunesGained()
```

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_ClearTormentorKills"></a> ClearTormentorKills\(\)

```csharp
public void ClearTormentorKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_ClearWatchersTaken"></a> ClearWatchersTaken\(\)

```csharp
public void ClearWatchersTaken()
```

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_ClearWisdomRunesGained"></a> ClearWisdomRunesGained\(\)

```csharp
public void ClearWisdomRunesGained()
```

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_Clone"></a> Clone\(\)

```csharp
public CMsgMapStatsSnapshot Clone()
```

#### Returns

 [CMsgMapStatsSnapshot](Divine.Protobufs.Dota2.CMsgMapStatsSnapshot.md)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_Equals_Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_"></a> Equals\(CMsgMapStatsSnapshot\)

```csharp
public bool Equals(CMsgMapStatsSnapshot other)
```

#### Parameters

`other` [CMsgMapStatsSnapshot](Divine.Protobufs.Dota2.CMsgMapStatsSnapshot.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_MergeFrom_Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_"></a> MergeFrom\(CMsgMapStatsSnapshot\)

```csharp
public void MergeFrom(CMsgMapStatsSnapshot other)
```

#### Parameters

`other` [CMsgMapStatsSnapshot](Divine.Protobufs.Dota2.CMsgMapStatsSnapshot.md)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMapStatsSnapshot_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

