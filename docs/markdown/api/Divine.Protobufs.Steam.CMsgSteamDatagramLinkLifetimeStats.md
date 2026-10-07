# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats"></a> Class CMsgSteamDatagramLinkLifetimeStats

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramLinkLifetimeStats : IMessage<CMsgSteamDatagramLinkLifetimeStats>, IEquatable<CMsgSteamDatagramLinkLifetimeStats>, IDeepCloneable<CMsgSteamDatagramLinkLifetimeStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramLinkLifetimeStats](Divine.Protobufs.Steam.CMsgSteamDatagramLinkLifetimeStats.md)

#### Implements

IMessage<CMsgSteamDatagramLinkLifetimeStats\>, 
[IEquatable<CMsgSteamDatagramLinkLifetimeStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramLinkLifetimeStats\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramLinkLifetimeStats\>\(CMsgSteamDatagramLinkLifetimeStats, params CMsgSteamDatagramLinkLifetimeStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats__ctor"></a> CMsgSteamDatagramLinkLifetimeStats\(\)

```csharp
public CMsgSteamDatagramLinkLifetimeStats()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_"></a> CMsgSteamDatagramLinkLifetimeStats\(CMsgSteamDatagramLinkLifetimeStats\)

```csharp
public CMsgSteamDatagramLinkLifetimeStats(CMsgSteamDatagramLinkLifetimeStats other)
```

#### Parameters

`other` [CMsgSteamDatagramLinkLifetimeStats](Divine.Protobufs.Steam.CMsgSteamDatagramLinkLifetimeStats.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ConnectedSecondsFieldNumber"></a> ConnectedSecondsFieldNumber

```csharp
public const int ConnectedSecondsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_JitterHistogram10FieldNumber"></a> JitterHistogram10FieldNumber

```csharp
public const int JitterHistogram10FieldNumber = 65
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_JitterHistogram1FieldNumber"></a> JitterHistogram1FieldNumber

```csharp
public const int JitterHistogram1FieldNumber = 62
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_JitterHistogram20FieldNumber"></a> JitterHistogram20FieldNumber

```csharp
public const int JitterHistogram20FieldNumber = 66
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_JitterHistogram2FieldNumber"></a> JitterHistogram2FieldNumber

```csharp
public const int JitterHistogram2FieldNumber = 63
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_JitterHistogram5FieldNumber"></a> JitterHistogram5FieldNumber

```csharp
public const int JitterHistogram5FieldNumber = 64
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_JitterHistogramNegligibleFieldNumber"></a> JitterHistogramNegligibleFieldNumber

```csharp
public const int JitterHistogramNegligibleFieldNumber = 61
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_KbRecvFieldNumber"></a> KbRecvFieldNumber

```csharp
public const int KbRecvFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_KbSentFieldNumber"></a> KbSentFieldNumber

```csharp
public const int KbSentFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_MultipathPacketsRecvLaterFieldNumber"></a> MultipathPacketsRecvLaterFieldNumber

```csharp
public const int MultipathPacketsRecvLaterFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_MultipathPacketsRecvSequencedFieldNumber"></a> MultipathPacketsRecvSequencedFieldNumber

```csharp
public const int MultipathPacketsRecvSequencedFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_MultipathSendEnabledFieldNumber"></a> MultipathSendEnabledFieldNumber

```csharp
public const int MultipathSendEnabledFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PacketsRecvDroppedFieldNumber"></a> PacketsRecvDroppedFieldNumber

```csharp
public const int PacketsRecvDroppedFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PacketsRecvDuplicateFieldNumber"></a> PacketsRecvDuplicateFieldNumber

```csharp
public const int PacketsRecvDuplicateFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PacketsRecvFieldNumber"></a> PacketsRecvFieldNumber

```csharp
public const int PacketsRecvFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PacketsRecvLurchFieldNumber"></a> PacketsRecvLurchFieldNumber

```csharp
public const int PacketsRecvLurchFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PacketsRecvOutOfOrderCorrectedFieldNumber"></a> PacketsRecvOutOfOrderCorrectedFieldNumber

```csharp
public const int PacketsRecvOutOfOrderCorrectedFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PacketsRecvOutOfOrderFieldNumber"></a> PacketsRecvOutOfOrderFieldNumber

```csharp
public const int PacketsRecvOutOfOrderFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PacketsRecvSequencedFieldNumber"></a> PacketsRecvSequencedFieldNumber

```csharp
public const int PacketsRecvSequencedFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PacketsSentFieldNumber"></a> PacketsSentFieldNumber

```csharp
public const int PacketsSentFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingHistogram100FieldNumber"></a> PingHistogram100FieldNumber

```csharp
public const int PingHistogram100FieldNumber = 44
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingHistogram125FieldNumber"></a> PingHistogram125FieldNumber

```csharp
public const int PingHistogram125FieldNumber = 45
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingHistogram150FieldNumber"></a> PingHistogram150FieldNumber

```csharp
public const int PingHistogram150FieldNumber = 46
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingHistogram200FieldNumber"></a> PingHistogram200FieldNumber

```csharp
public const int PingHistogram200FieldNumber = 47
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingHistogram25FieldNumber"></a> PingHistogram25FieldNumber

```csharp
public const int PingHistogram25FieldNumber = 41
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingHistogram300FieldNumber"></a> PingHistogram300FieldNumber

```csharp
public const int PingHistogram300FieldNumber = 48
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingHistogram50FieldNumber"></a> PingHistogram50FieldNumber

```csharp
public const int PingHistogram50FieldNumber = 42
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingHistogram75FieldNumber"></a> PingHistogram75FieldNumber

```csharp
public const int PingHistogram75FieldNumber = 43
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingHistogramMaxFieldNumber"></a> PingHistogramMaxFieldNumber

```csharp
public const int PingHistogramMaxFieldNumber = 49
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingNtile50ThFieldNumber"></a> PingNtile50ThFieldNumber

```csharp
public const int PingNtile50ThFieldNumber = 51
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingNtile5ThFieldNumber"></a> PingNtile5ThFieldNumber

```csharp
public const int PingNtile5ThFieldNumber = 50
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingNtile75ThFieldNumber"></a> PingNtile75ThFieldNumber

```csharp
public const int PingNtile75ThFieldNumber = 52
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingNtile95ThFieldNumber"></a> PingNtile95ThFieldNumber

```csharp
public const int PingNtile95ThFieldNumber = 53
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingNtile98ThFieldNumber"></a> PingNtile98ThFieldNumber

```csharp
public const int PingNtile98ThFieldNumber = 54
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityHistogram100FieldNumber"></a> QualityHistogram100FieldNumber

```csharp
public const int QualityHistogram100FieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityHistogram1FieldNumber"></a> QualityHistogram1FieldNumber

```csharp
public const int QualityHistogram1FieldNumber = 28
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityHistogram50FieldNumber"></a> QualityHistogram50FieldNumber

```csharp
public const int QualityHistogram50FieldNumber = 27
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityHistogram75FieldNumber"></a> QualityHistogram75FieldNumber

```csharp
public const int QualityHistogram75FieldNumber = 26
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityHistogram90FieldNumber"></a> QualityHistogram90FieldNumber

```csharp
public const int QualityHistogram90FieldNumber = 25
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityHistogram95FieldNumber"></a> QualityHistogram95FieldNumber

```csharp
public const int QualityHistogram95FieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityHistogram97FieldNumber"></a> QualityHistogram97FieldNumber

```csharp
public const int QualityHistogram97FieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityHistogram99FieldNumber"></a> QualityHistogram99FieldNumber

```csharp
public const int QualityHistogram99FieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityHistogramDeadFieldNumber"></a> QualityHistogramDeadFieldNumber

```csharp
public const int QualityHistogramDeadFieldNumber = 29
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityNtile25ThFieldNumber"></a> QualityNtile25ThFieldNumber

```csharp
public const int QualityNtile25ThFieldNumber = 32
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityNtile2NdFieldNumber"></a> QualityNtile2NdFieldNumber

```csharp
public const int QualityNtile2NdFieldNumber = 30
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityNtile50ThFieldNumber"></a> QualityNtile50ThFieldNumber

```csharp
public const int QualityNtile50ThFieldNumber = 33
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityNtile5ThFieldNumber"></a> QualityNtile5ThFieldNumber

```csharp
public const int QualityNtile5ThFieldNumber = 31
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ConnectedSeconds"></a> ConnectedSeconds

```csharp
public uint ConnectedSeconds { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasConnectedSeconds"></a> HasConnectedSeconds

```csharp
public bool HasConnectedSeconds { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasJitterHistogram1"></a> HasJitterHistogram1

```csharp
public bool HasJitterHistogram1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasJitterHistogram10"></a> HasJitterHistogram10

```csharp
public bool HasJitterHistogram10 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasJitterHistogram2"></a> HasJitterHistogram2

```csharp
public bool HasJitterHistogram2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasJitterHistogram20"></a> HasJitterHistogram20

```csharp
public bool HasJitterHistogram20 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasJitterHistogram5"></a> HasJitterHistogram5

```csharp
public bool HasJitterHistogram5 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasJitterHistogramNegligible"></a> HasJitterHistogramNegligible

```csharp
public bool HasJitterHistogramNegligible { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasKbRecv"></a> HasKbRecv

```csharp
public bool HasKbRecv { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasKbSent"></a> HasKbSent

```csharp
public bool HasKbSent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasMultipathSendEnabled"></a> HasMultipathSendEnabled

```csharp
public bool HasMultipathSendEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPacketsRecv"></a> HasPacketsRecv

```csharp
public bool HasPacketsRecv { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPacketsRecvDropped"></a> HasPacketsRecvDropped

```csharp
public bool HasPacketsRecvDropped { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPacketsRecvDuplicate"></a> HasPacketsRecvDuplicate

```csharp
public bool HasPacketsRecvDuplicate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPacketsRecvLurch"></a> HasPacketsRecvLurch

```csharp
public bool HasPacketsRecvLurch { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPacketsRecvOutOfOrder"></a> HasPacketsRecvOutOfOrder

```csharp
public bool HasPacketsRecvOutOfOrder { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPacketsRecvOutOfOrderCorrected"></a> HasPacketsRecvOutOfOrderCorrected

```csharp
public bool HasPacketsRecvOutOfOrderCorrected { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPacketsRecvSequenced"></a> HasPacketsRecvSequenced

```csharp
public bool HasPacketsRecvSequenced { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPacketsSent"></a> HasPacketsSent

```csharp
public bool HasPacketsSent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPingHistogram100"></a> HasPingHistogram100

```csharp
public bool HasPingHistogram100 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPingHistogram125"></a> HasPingHistogram125

```csharp
public bool HasPingHistogram125 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPingHistogram150"></a> HasPingHistogram150

```csharp
public bool HasPingHistogram150 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPingHistogram200"></a> HasPingHistogram200

```csharp
public bool HasPingHistogram200 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPingHistogram25"></a> HasPingHistogram25

```csharp
public bool HasPingHistogram25 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPingHistogram300"></a> HasPingHistogram300

```csharp
public bool HasPingHistogram300 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPingHistogram50"></a> HasPingHistogram50

```csharp
public bool HasPingHistogram50 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPingHistogram75"></a> HasPingHistogram75

```csharp
public bool HasPingHistogram75 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPingHistogramMax"></a> HasPingHistogramMax

```csharp
public bool HasPingHistogramMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPingNtile50Th"></a> HasPingNtile50Th

```csharp
public bool HasPingNtile50Th { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPingNtile5Th"></a> HasPingNtile5Th

```csharp
public bool HasPingNtile5Th { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPingNtile75Th"></a> HasPingNtile75Th

```csharp
public bool HasPingNtile75Th { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPingNtile95Th"></a> HasPingNtile95Th

```csharp
public bool HasPingNtile95Th { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasPingNtile98Th"></a> HasPingNtile98Th

```csharp
public bool HasPingNtile98Th { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasQualityHistogram1"></a> HasQualityHistogram1

```csharp
public bool HasQualityHistogram1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasQualityHistogram100"></a> HasQualityHistogram100

```csharp
public bool HasQualityHistogram100 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasQualityHistogram50"></a> HasQualityHistogram50

```csharp
public bool HasQualityHistogram50 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasQualityHistogram75"></a> HasQualityHistogram75

```csharp
public bool HasQualityHistogram75 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasQualityHistogram90"></a> HasQualityHistogram90

```csharp
public bool HasQualityHistogram90 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasQualityHistogram95"></a> HasQualityHistogram95

```csharp
public bool HasQualityHistogram95 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasQualityHistogram97"></a> HasQualityHistogram97

```csharp
public bool HasQualityHistogram97 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasQualityHistogram99"></a> HasQualityHistogram99

```csharp
public bool HasQualityHistogram99 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasQualityHistogramDead"></a> HasQualityHistogramDead

```csharp
public bool HasQualityHistogramDead { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasQualityNtile25Th"></a> HasQualityNtile25Th

```csharp
public bool HasQualityNtile25Th { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasQualityNtile2Nd"></a> HasQualityNtile2Nd

```csharp
public bool HasQualityNtile2Nd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasQualityNtile50Th"></a> HasQualityNtile50Th

```csharp
public bool HasQualityNtile50Th { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_HasQualityNtile5Th"></a> HasQualityNtile5Th

```csharp
public bool HasQualityNtile5Th { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_JitterHistogram1"></a> JitterHistogram1

```csharp
public uint JitterHistogram1 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_JitterHistogram10"></a> JitterHistogram10

```csharp
public uint JitterHistogram10 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_JitterHistogram2"></a> JitterHistogram2

```csharp
public uint JitterHistogram2 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_JitterHistogram20"></a> JitterHistogram20

```csharp
public uint JitterHistogram20 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_JitterHistogram5"></a> JitterHistogram5

```csharp
public uint JitterHistogram5 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_JitterHistogramNegligible"></a> JitterHistogramNegligible

```csharp
public uint JitterHistogramNegligible { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_KbRecv"></a> KbRecv

```csharp
public ulong KbRecv { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_KbSent"></a> KbSent

```csharp
public ulong KbSent { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_MultipathPacketsRecvLater"></a> MultipathPacketsRecvLater

```csharp
public RepeatedField<ulong> MultipathPacketsRecvLater { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_MultipathPacketsRecvSequenced"></a> MultipathPacketsRecvSequenced

```csharp
public RepeatedField<ulong> MultipathPacketsRecvSequenced { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_MultipathSendEnabled"></a> MultipathSendEnabled

```csharp
public uint MultipathSendEnabled { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PacketsRecv"></a> PacketsRecv

```csharp
public ulong PacketsRecv { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PacketsRecvDropped"></a> PacketsRecvDropped

```csharp
public ulong PacketsRecvDropped { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PacketsRecvDuplicate"></a> PacketsRecvDuplicate

```csharp
public ulong PacketsRecvDuplicate { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PacketsRecvLurch"></a> PacketsRecvLurch

```csharp
public ulong PacketsRecvLurch { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PacketsRecvOutOfOrder"></a> PacketsRecvOutOfOrder

```csharp
public ulong PacketsRecvOutOfOrder { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PacketsRecvOutOfOrderCorrected"></a> PacketsRecvOutOfOrderCorrected

```csharp
public ulong PacketsRecvOutOfOrderCorrected { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PacketsRecvSequenced"></a> PacketsRecvSequenced

```csharp
public ulong PacketsRecvSequenced { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PacketsSent"></a> PacketsSent

```csharp
public ulong PacketsSent { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramLinkLifetimeStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramLinkLifetimeStats](Divine.Protobufs.Steam.CMsgSteamDatagramLinkLifetimeStats.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingHistogram100"></a> PingHistogram100

```csharp
public uint PingHistogram100 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingHistogram125"></a> PingHistogram125

```csharp
public uint PingHistogram125 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingHistogram150"></a> PingHistogram150

```csharp
public uint PingHistogram150 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingHistogram200"></a> PingHistogram200

```csharp
public uint PingHistogram200 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingHistogram25"></a> PingHistogram25

```csharp
public uint PingHistogram25 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingHistogram300"></a> PingHistogram300

```csharp
public uint PingHistogram300 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingHistogram50"></a> PingHistogram50

```csharp
public uint PingHistogram50 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingHistogram75"></a> PingHistogram75

```csharp
public uint PingHistogram75 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingHistogramMax"></a> PingHistogramMax

```csharp
public uint PingHistogramMax { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingNtile50Th"></a> PingNtile50Th

```csharp
public uint PingNtile50Th { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingNtile5Th"></a> PingNtile5Th

```csharp
public uint PingNtile5Th { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingNtile75Th"></a> PingNtile75Th

```csharp
public uint PingNtile75Th { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingNtile95Th"></a> PingNtile95Th

```csharp
public uint PingNtile95Th { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_PingNtile98Th"></a> PingNtile98Th

```csharp
public uint PingNtile98Th { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityHistogram1"></a> QualityHistogram1

```csharp
public uint QualityHistogram1 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityHistogram100"></a> QualityHistogram100

```csharp
public uint QualityHistogram100 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityHistogram50"></a> QualityHistogram50

```csharp
public uint QualityHistogram50 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityHistogram75"></a> QualityHistogram75

```csharp
public uint QualityHistogram75 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityHistogram90"></a> QualityHistogram90

```csharp
public uint QualityHistogram90 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityHistogram95"></a> QualityHistogram95

```csharp
public uint QualityHistogram95 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityHistogram97"></a> QualityHistogram97

```csharp
public uint QualityHistogram97 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityHistogram99"></a> QualityHistogram99

```csharp
public uint QualityHistogram99 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityHistogramDead"></a> QualityHistogramDead

```csharp
public uint QualityHistogramDead { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityNtile25Th"></a> QualityNtile25Th

```csharp
public uint QualityNtile25Th { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityNtile2Nd"></a> QualityNtile2Nd

```csharp
public uint QualityNtile2Nd { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityNtile50Th"></a> QualityNtile50Th

```csharp
public uint QualityNtile50Th { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_QualityNtile5Th"></a> QualityNtile5Th

```csharp
public uint QualityNtile5Th { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearConnectedSeconds"></a> ClearConnectedSeconds\(\)

```csharp
public void ClearConnectedSeconds()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearJitterHistogram1"></a> ClearJitterHistogram1\(\)

```csharp
public void ClearJitterHistogram1()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearJitterHistogram10"></a> ClearJitterHistogram10\(\)

```csharp
public void ClearJitterHistogram10()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearJitterHistogram2"></a> ClearJitterHistogram2\(\)

```csharp
public void ClearJitterHistogram2()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearJitterHistogram20"></a> ClearJitterHistogram20\(\)

```csharp
public void ClearJitterHistogram20()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearJitterHistogram5"></a> ClearJitterHistogram5\(\)

```csharp
public void ClearJitterHistogram5()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearJitterHistogramNegligible"></a> ClearJitterHistogramNegligible\(\)

```csharp
public void ClearJitterHistogramNegligible()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearKbRecv"></a> ClearKbRecv\(\)

```csharp
public void ClearKbRecv()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearKbSent"></a> ClearKbSent\(\)

```csharp
public void ClearKbSent()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearMultipathSendEnabled"></a> ClearMultipathSendEnabled\(\)

```csharp
public void ClearMultipathSendEnabled()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPacketsRecv"></a> ClearPacketsRecv\(\)

```csharp
public void ClearPacketsRecv()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPacketsRecvDropped"></a> ClearPacketsRecvDropped\(\)

```csharp
public void ClearPacketsRecvDropped()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPacketsRecvDuplicate"></a> ClearPacketsRecvDuplicate\(\)

```csharp
public void ClearPacketsRecvDuplicate()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPacketsRecvLurch"></a> ClearPacketsRecvLurch\(\)

```csharp
public void ClearPacketsRecvLurch()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPacketsRecvOutOfOrder"></a> ClearPacketsRecvOutOfOrder\(\)

```csharp
public void ClearPacketsRecvOutOfOrder()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPacketsRecvOutOfOrderCorrected"></a> ClearPacketsRecvOutOfOrderCorrected\(\)

```csharp
public void ClearPacketsRecvOutOfOrderCorrected()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPacketsRecvSequenced"></a> ClearPacketsRecvSequenced\(\)

```csharp
public void ClearPacketsRecvSequenced()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPacketsSent"></a> ClearPacketsSent\(\)

```csharp
public void ClearPacketsSent()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPingHistogram100"></a> ClearPingHistogram100\(\)

```csharp
public void ClearPingHistogram100()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPingHistogram125"></a> ClearPingHistogram125\(\)

```csharp
public void ClearPingHistogram125()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPingHistogram150"></a> ClearPingHistogram150\(\)

```csharp
public void ClearPingHistogram150()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPingHistogram200"></a> ClearPingHistogram200\(\)

```csharp
public void ClearPingHistogram200()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPingHistogram25"></a> ClearPingHistogram25\(\)

```csharp
public void ClearPingHistogram25()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPingHistogram300"></a> ClearPingHistogram300\(\)

```csharp
public void ClearPingHistogram300()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPingHistogram50"></a> ClearPingHistogram50\(\)

```csharp
public void ClearPingHistogram50()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPingHistogram75"></a> ClearPingHistogram75\(\)

```csharp
public void ClearPingHistogram75()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPingHistogramMax"></a> ClearPingHistogramMax\(\)

```csharp
public void ClearPingHistogramMax()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPingNtile50Th"></a> ClearPingNtile50Th\(\)

```csharp
public void ClearPingNtile50Th()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPingNtile5Th"></a> ClearPingNtile5Th\(\)

```csharp
public void ClearPingNtile5Th()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPingNtile75Th"></a> ClearPingNtile75Th\(\)

```csharp
public void ClearPingNtile75Th()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPingNtile95Th"></a> ClearPingNtile95Th\(\)

```csharp
public void ClearPingNtile95Th()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearPingNtile98Th"></a> ClearPingNtile98Th\(\)

```csharp
public void ClearPingNtile98Th()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearQualityHistogram1"></a> ClearQualityHistogram1\(\)

```csharp
public void ClearQualityHistogram1()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearQualityHistogram100"></a> ClearQualityHistogram100\(\)

```csharp
public void ClearQualityHistogram100()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearQualityHistogram50"></a> ClearQualityHistogram50\(\)

```csharp
public void ClearQualityHistogram50()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearQualityHistogram75"></a> ClearQualityHistogram75\(\)

```csharp
public void ClearQualityHistogram75()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearQualityHistogram90"></a> ClearQualityHistogram90\(\)

```csharp
public void ClearQualityHistogram90()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearQualityHistogram95"></a> ClearQualityHistogram95\(\)

```csharp
public void ClearQualityHistogram95()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearQualityHistogram97"></a> ClearQualityHistogram97\(\)

```csharp
public void ClearQualityHistogram97()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearQualityHistogram99"></a> ClearQualityHistogram99\(\)

```csharp
public void ClearQualityHistogram99()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearQualityHistogramDead"></a> ClearQualityHistogramDead\(\)

```csharp
public void ClearQualityHistogramDead()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearQualityNtile25Th"></a> ClearQualityNtile25Th\(\)

```csharp
public void ClearQualityNtile25Th()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearQualityNtile2Nd"></a> ClearQualityNtile2Nd\(\)

```csharp
public void ClearQualityNtile2Nd()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearQualityNtile50Th"></a> ClearQualityNtile50Th\(\)

```csharp
public void ClearQualityNtile50Th()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ClearQualityNtile5Th"></a> ClearQualityNtile5Th\(\)

```csharp
public void ClearQualityNtile5Th()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramLinkLifetimeStats Clone()
```

#### Returns

 [CMsgSteamDatagramLinkLifetimeStats](Divine.Protobufs.Steam.CMsgSteamDatagramLinkLifetimeStats.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_"></a> Equals\(CMsgSteamDatagramLinkLifetimeStats\)

```csharp
public bool Equals(CMsgSteamDatagramLinkLifetimeStats other)
```

#### Parameters

`other` [CMsgSteamDatagramLinkLifetimeStats](Divine.Protobufs.Steam.CMsgSteamDatagramLinkLifetimeStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_"></a> MergeFrom\(CMsgSteamDatagramLinkLifetimeStats\)

```csharp
public void MergeFrom(CMsgSteamDatagramLinkLifetimeStats other)
```

#### Parameters

`other` [CMsgSteamDatagramLinkLifetimeStats](Divine.Protobufs.Steam.CMsgSteamDatagramLinkLifetimeStats.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkLifetimeStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

