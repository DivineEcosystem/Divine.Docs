# <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats"></a> Class CMsgServerNetworkStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerNetworkStats : IMessage<CMsgServerNetworkStats>, IEquatable<CMsgServerNetworkStats>, IDeepCloneable<CMsgServerNetworkStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerNetworkStats](Divine.Protobufs.Dota2.CMsgServerNetworkStats.md)

#### Implements

IMessage<CMsgServerNetworkStats\>, 
[IEquatable<CMsgServerNetworkStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerNetworkStats\>, 
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
[EnumerableExtensions.In<CMsgServerNetworkStats\>\(CMsgServerNetworkStats, params CMsgServerNetworkStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats__ctor"></a> CMsgServerNetworkStats\(\)

```csharp
public CMsgServerNetworkStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats__ctor_Divine_Protobufs_Dota2_CMsgServerNetworkStats_"></a> CMsgServerNetworkStats\(CMsgServerNetworkStats\)

```csharp
public CMsgServerNetworkStats(CMsgServerNetworkStats other)
```

#### Parameters

`other` [CMsgServerNetworkStats](Divine.Protobufs.Dota2.CMsgServerNetworkStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_AvgDataInFieldNumber"></a> AvgDataInFieldNumber

```csharp
public const int AvgDataInFieldNumber = 25
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_AvgDataOutFieldNumber"></a> AvgDataOutFieldNumber

```csharp
public const int AvgDataOutFieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_AvgEngineLatencyOutFieldNumber"></a> AvgEngineLatencyOutFieldNumber

```csharp
public const int AvgEngineLatencyOutFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_AvgLossInFieldNumber"></a> AvgLossInFieldNumber

```csharp
public const int AvgLossInFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_AvgLossOutFieldNumber"></a> AvgLossOutFieldNumber

```csharp
public const int AvgLossOutFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_AvgPacketsInFieldNumber"></a> AvgPacketsInFieldNumber

```csharp
public const int AvgPacketsInFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_AvgPacketsOutFieldNumber"></a> AvgPacketsOutFieldNumber

```csharp
public const int AvgPacketsOutFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_AvgPingMsFieldNumber"></a> AvgPingMsFieldNumber

```csharp
public const int AvgPingMsFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_CpuUsageFieldNumber"></a> CpuUsageFieldNumber

```csharp
public const int CpuUsageFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_DedicatedFieldNumber"></a> DedicatedFieldNumber

```csharp
public const int DedicatedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_FpsFieldNumber"></a> FpsFieldNumber

```csharp
public const int FpsFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_MemoryFreeMbFieldNumber"></a> MemoryFreeMbFieldNumber

```csharp
public const int MemoryFreeMbFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_MemoryUsedMbFieldNumber"></a> MemoryUsedMbFieldNumber

```csharp
public const int MemoryUsedMbFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_NumBotsFieldNumber"></a> NumBotsFieldNumber

```csharp
public const int NumBotsFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_NumClientsFieldNumber"></a> NumClientsFieldNumber

```csharp
public const int NumClientsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_NumSpectatorsFieldNumber"></a> NumSpectatorsFieldNumber

```csharp
public const int NumSpectatorsFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_NumTvRelaysFieldNumber"></a> NumTvRelaysFieldNumber

```csharp
public const int NumTvRelaysFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 30
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_PortsFieldNumber"></a> PortsFieldNumber

```csharp
public const int PortsFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_SpawnCountFieldNumber"></a> SpawnCountFieldNumber

```csharp
public const int SpawnCountFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_TotalDataInFieldNumber"></a> TotalDataInFieldNumber

```csharp
public const int TotalDataInFieldNumber = 26
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_TotalDataOutFieldNumber"></a> TotalDataOutFieldNumber

```csharp
public const int TotalDataOutFieldNumber = 28
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_TotalPacketsInFieldNumber"></a> TotalPacketsInFieldNumber

```csharp
public const int TotalPacketsInFieldNumber = 27
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_TotalPacketsOutFieldNumber"></a> TotalPacketsOutFieldNumber

```csharp
public const int TotalPacketsOutFieldNumber = 29
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_UptimeFieldNumber"></a> UptimeFieldNumber

```csharp
public const int UptimeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_AvgDataIn"></a> AvgDataIn

```csharp
public float AvgDataIn { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_AvgDataOut"></a> AvgDataOut

```csharp
public float AvgDataOut { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_AvgEngineLatencyOut"></a> AvgEngineLatencyOut

```csharp
public float AvgEngineLatencyOut { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_AvgLossIn"></a> AvgLossIn

```csharp
public float AvgLossIn { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_AvgLossOut"></a> AvgLossOut

```csharp
public float AvgLossOut { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_AvgPacketsIn"></a> AvgPacketsIn

```csharp
public float AvgPacketsIn { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_AvgPacketsOut"></a> AvgPacketsOut

```csharp
public float AvgPacketsOut { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_AvgPingMs"></a> AvgPingMs

```csharp
public float AvgPingMs { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_CpuUsage"></a> CpuUsage

```csharp
public int CpuUsage { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Dedicated"></a> Dedicated

```csharp
public bool Dedicated { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Fps"></a> Fps

```csharp
public float Fps { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasAvgDataIn"></a> HasAvgDataIn

```csharp
public bool HasAvgDataIn { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasAvgDataOut"></a> HasAvgDataOut

```csharp
public bool HasAvgDataOut { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasAvgEngineLatencyOut"></a> HasAvgEngineLatencyOut

```csharp
public bool HasAvgEngineLatencyOut { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasAvgLossIn"></a> HasAvgLossIn

```csharp
public bool HasAvgLossIn { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasAvgLossOut"></a> HasAvgLossOut

```csharp
public bool HasAvgLossOut { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasAvgPacketsIn"></a> HasAvgPacketsIn

```csharp
public bool HasAvgPacketsIn { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasAvgPacketsOut"></a> HasAvgPacketsOut

```csharp
public bool HasAvgPacketsOut { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasAvgPingMs"></a> HasAvgPingMs

```csharp
public bool HasAvgPingMs { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasCpuUsage"></a> HasCpuUsage

```csharp
public bool HasCpuUsage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasDedicated"></a> HasDedicated

```csharp
public bool HasDedicated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasFps"></a> HasFps

```csharp
public bool HasFps { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasMemoryFreeMb"></a> HasMemoryFreeMb

```csharp
public bool HasMemoryFreeMb { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasMemoryUsedMb"></a> HasMemoryUsedMb

```csharp
public bool HasMemoryUsedMb { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasNumBots"></a> HasNumBots

```csharp
public bool HasNumBots { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasNumClients"></a> HasNumClients

```csharp
public bool HasNumClients { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasNumSpectators"></a> HasNumSpectators

```csharp
public bool HasNumSpectators { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasNumTvRelays"></a> HasNumTvRelays

```csharp
public bool HasNumTvRelays { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasSpawnCount"></a> HasSpawnCount

```csharp
public bool HasSpawnCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasTotalDataIn"></a> HasTotalDataIn

```csharp
public bool HasTotalDataIn { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasTotalDataOut"></a> HasTotalDataOut

```csharp
public bool HasTotalDataOut { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasTotalPacketsIn"></a> HasTotalPacketsIn

```csharp
public bool HasTotalPacketsIn { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasTotalPacketsOut"></a> HasTotalPacketsOut

```csharp
public bool HasTotalPacketsOut { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_HasUptime"></a> HasUptime

```csharp
public bool HasUptime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_MemoryFreeMb"></a> MemoryFreeMb

```csharp
public int MemoryFreeMb { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_MemoryUsedMb"></a> MemoryUsedMb

```csharp
public int MemoryUsedMb { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_NumBots"></a> NumBots

```csharp
public int NumBots { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_NumClients"></a> NumClients

```csharp
public int NumClients { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_NumSpectators"></a> NumSpectators

```csharp
public int NumSpectators { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_NumTvRelays"></a> NumTvRelays

```csharp
public int NumTvRelays { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerNetworkStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerNetworkStats](Divine.Protobufs.Dota2.CMsgServerNetworkStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Players"></a> Players

```csharp
public RepeatedField<CMsgServerNetworkStats.Types.Player> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgServerNetworkStats](Divine.Protobufs.Dota2.CMsgServerNetworkStats.md).[Types](Divine.Protobufs.Dota2.CMsgServerNetworkStats.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerNetworkStats.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Ports"></a> Ports

```csharp
public RepeatedField<CMsgServerNetworkStats.Types.Port> Ports { get; }
```

#### Property Value

 RepeatedField<[CMsgServerNetworkStats](Divine.Protobufs.Dota2.CMsgServerNetworkStats.md).[Types](Divine.Protobufs.Dota2.CMsgServerNetworkStats.Types.md).[Port](Divine.Protobufs.Dota2.CMsgServerNetworkStats.Types.Port.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_SpawnCount"></a> SpawnCount

```csharp
public int SpawnCount { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_TotalDataIn"></a> TotalDataIn

```csharp
public ulong TotalDataIn { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_TotalDataOut"></a> TotalDataOut

```csharp
public ulong TotalDataOut { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_TotalPacketsIn"></a> TotalPacketsIn

```csharp
public ulong TotalPacketsIn { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_TotalPacketsOut"></a> TotalPacketsOut

```csharp
public ulong TotalPacketsOut { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Uptime"></a> Uptime

```csharp
public int Uptime { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearAvgDataIn"></a> ClearAvgDataIn\(\)

```csharp
public void ClearAvgDataIn()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearAvgDataOut"></a> ClearAvgDataOut\(\)

```csharp
public void ClearAvgDataOut()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearAvgEngineLatencyOut"></a> ClearAvgEngineLatencyOut\(\)

```csharp
public void ClearAvgEngineLatencyOut()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearAvgLossIn"></a> ClearAvgLossIn\(\)

```csharp
public void ClearAvgLossIn()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearAvgLossOut"></a> ClearAvgLossOut\(\)

```csharp
public void ClearAvgLossOut()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearAvgPacketsIn"></a> ClearAvgPacketsIn\(\)

```csharp
public void ClearAvgPacketsIn()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearAvgPacketsOut"></a> ClearAvgPacketsOut\(\)

```csharp
public void ClearAvgPacketsOut()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearAvgPingMs"></a> ClearAvgPingMs\(\)

```csharp
public void ClearAvgPingMs()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearCpuUsage"></a> ClearCpuUsage\(\)

```csharp
public void ClearCpuUsage()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearDedicated"></a> ClearDedicated\(\)

```csharp
public void ClearDedicated()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearFps"></a> ClearFps\(\)

```csharp
public void ClearFps()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearMemoryFreeMb"></a> ClearMemoryFreeMb\(\)

```csharp
public void ClearMemoryFreeMb()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearMemoryUsedMb"></a> ClearMemoryUsedMb\(\)

```csharp
public void ClearMemoryUsedMb()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearNumBots"></a> ClearNumBots\(\)

```csharp
public void ClearNumBots()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearNumClients"></a> ClearNumClients\(\)

```csharp
public void ClearNumClients()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearNumSpectators"></a> ClearNumSpectators\(\)

```csharp
public void ClearNumSpectators()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearNumTvRelays"></a> ClearNumTvRelays\(\)

```csharp
public void ClearNumTvRelays()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearSpawnCount"></a> ClearSpawnCount\(\)

```csharp
public void ClearSpawnCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearTotalDataIn"></a> ClearTotalDataIn\(\)

```csharp
public void ClearTotalDataIn()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearTotalDataOut"></a> ClearTotalDataOut\(\)

```csharp
public void ClearTotalDataOut()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearTotalPacketsIn"></a> ClearTotalPacketsIn\(\)

```csharp
public void ClearTotalPacketsIn()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearTotalPacketsOut"></a> ClearTotalPacketsOut\(\)

```csharp
public void ClearTotalPacketsOut()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ClearUptime"></a> ClearUptime\(\)

```csharp
public void ClearUptime()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Clone"></a> Clone\(\)

```csharp
public CMsgServerNetworkStats Clone()
```

#### Returns

 [CMsgServerNetworkStats](Divine.Protobufs.Dota2.CMsgServerNetworkStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Equals_Divine_Protobufs_Dota2_CMsgServerNetworkStats_"></a> Equals\(CMsgServerNetworkStats\)

```csharp
public bool Equals(CMsgServerNetworkStats other)
```

#### Parameters

`other` [CMsgServerNetworkStats](Divine.Protobufs.Dota2.CMsgServerNetworkStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_MergeFrom_Divine_Protobufs_Dota2_CMsgServerNetworkStats_"></a> MergeFrom\(CMsgServerNetworkStats\)

```csharp
public void MergeFrom(CMsgServerNetworkStats other)
```

#### Parameters

`other` [CMsgServerNetworkStats](Divine.Protobufs.Dota2.CMsgServerNetworkStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

