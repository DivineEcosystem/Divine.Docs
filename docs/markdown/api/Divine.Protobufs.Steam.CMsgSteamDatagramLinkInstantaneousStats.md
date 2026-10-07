# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats"></a> Class CMsgSteamDatagramLinkInstantaneousStats

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramLinkInstantaneousStats : IMessage<CMsgSteamDatagramLinkInstantaneousStats>, IEquatable<CMsgSteamDatagramLinkInstantaneousStats>, IDeepCloneable<CMsgSteamDatagramLinkInstantaneousStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramLinkInstantaneousStats](Divine.Protobufs.Steam.CMsgSteamDatagramLinkInstantaneousStats.md)

#### Implements

IMessage<CMsgSteamDatagramLinkInstantaneousStats\>, 
[IEquatable<CMsgSteamDatagramLinkInstantaneousStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramLinkInstantaneousStats\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramLinkInstantaneousStats\>\(CMsgSteamDatagramLinkInstantaneousStats, params CMsgSteamDatagramLinkInstantaneousStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats__ctor"></a> CMsgSteamDatagramLinkInstantaneousStats\(\)

```csharp
public CMsgSteamDatagramLinkInstantaneousStats()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_"></a> CMsgSteamDatagramLinkInstantaneousStats\(CMsgSteamDatagramLinkInstantaneousStats\)

```csharp
public CMsgSteamDatagramLinkInstantaneousStats(CMsgSteamDatagramLinkInstantaneousStats other)
```

#### Parameters

`other` [CMsgSteamDatagramLinkInstantaneousStats](Divine.Protobufs.Steam.CMsgSteamDatagramLinkInstantaneousStats.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_InBytesPerSecFieldNumber"></a> InBytesPerSecFieldNumber

```csharp
public const int InBytesPerSecFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_InPacketsPerSecX10FieldNumber"></a> InPacketsPerSecX10FieldNumber

```csharp
public const int InPacketsPerSecX10FieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_OutBytesPerSecFieldNumber"></a> OutBytesPerSecFieldNumber

```csharp
public const int OutBytesPerSecFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_OutPacketsPerSecX10FieldNumber"></a> OutPacketsPerSecX10FieldNumber

```csharp
public const int OutPacketsPerSecX10FieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_PacketsDroppedPctFieldNumber"></a> PacketsDroppedPctFieldNumber

```csharp
public const int PacketsDroppedPctFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_PacketsWeirdSequencePctFieldNumber"></a> PacketsWeirdSequencePctFieldNumber

```csharp
public const int PacketsWeirdSequencePctFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_PeakJitterUsecFieldNumber"></a> PeakJitterUsecFieldNumber

```csharp
public const int PeakJitterUsecFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_PingMsFieldNumber"></a> PingMsFieldNumber

```csharp
public const int PingMsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_HasInBytesPerSec"></a> HasInBytesPerSec

```csharp
public bool HasInBytesPerSec { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_HasInPacketsPerSecX10"></a> HasInPacketsPerSecX10

```csharp
public bool HasInPacketsPerSecX10 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_HasOutBytesPerSec"></a> HasOutBytesPerSec

```csharp
public bool HasOutBytesPerSec { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_HasOutPacketsPerSecX10"></a> HasOutPacketsPerSecX10

```csharp
public bool HasOutPacketsPerSecX10 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_HasPacketsDroppedPct"></a> HasPacketsDroppedPct

```csharp
public bool HasPacketsDroppedPct { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_HasPacketsWeirdSequencePct"></a> HasPacketsWeirdSequencePct

```csharp
public bool HasPacketsWeirdSequencePct { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_HasPeakJitterUsec"></a> HasPeakJitterUsec

```csharp
public bool HasPeakJitterUsec { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_HasPingMs"></a> HasPingMs

```csharp
public bool HasPingMs { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_InBytesPerSec"></a> InBytesPerSec

```csharp
public uint InBytesPerSec { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_InPacketsPerSecX10"></a> InPacketsPerSecX10

```csharp
public uint InPacketsPerSecX10 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_OutBytesPerSec"></a> OutBytesPerSec

```csharp
public uint OutBytesPerSec { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_OutPacketsPerSecX10"></a> OutPacketsPerSecX10

```csharp
public uint OutPacketsPerSecX10 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_PacketsDroppedPct"></a> PacketsDroppedPct

```csharp
public uint PacketsDroppedPct { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_PacketsWeirdSequencePct"></a> PacketsWeirdSequencePct

```csharp
public uint PacketsWeirdSequencePct { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramLinkInstantaneousStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramLinkInstantaneousStats](Divine.Protobufs.Steam.CMsgSteamDatagramLinkInstantaneousStats.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_PeakJitterUsec"></a> PeakJitterUsec

```csharp
public uint PeakJitterUsec { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_PingMs"></a> PingMs

```csharp
public uint PingMs { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_ClearInBytesPerSec"></a> ClearInBytesPerSec\(\)

```csharp
public void ClearInBytesPerSec()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_ClearInPacketsPerSecX10"></a> ClearInPacketsPerSecX10\(\)

```csharp
public void ClearInPacketsPerSecX10()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_ClearOutBytesPerSec"></a> ClearOutBytesPerSec\(\)

```csharp
public void ClearOutBytesPerSec()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_ClearOutPacketsPerSecX10"></a> ClearOutPacketsPerSecX10\(\)

```csharp
public void ClearOutPacketsPerSecX10()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_ClearPacketsDroppedPct"></a> ClearPacketsDroppedPct\(\)

```csharp
public void ClearPacketsDroppedPct()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_ClearPacketsWeirdSequencePct"></a> ClearPacketsWeirdSequencePct\(\)

```csharp
public void ClearPacketsWeirdSequencePct()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_ClearPeakJitterUsec"></a> ClearPeakJitterUsec\(\)

```csharp
public void ClearPeakJitterUsec()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_ClearPingMs"></a> ClearPingMs\(\)

```csharp
public void ClearPingMs()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramLinkInstantaneousStats Clone()
```

#### Returns

 [CMsgSteamDatagramLinkInstantaneousStats](Divine.Protobufs.Steam.CMsgSteamDatagramLinkInstantaneousStats.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_"></a> Equals\(CMsgSteamDatagramLinkInstantaneousStats\)

```csharp
public bool Equals(CMsgSteamDatagramLinkInstantaneousStats other)
```

#### Parameters

`other` [CMsgSteamDatagramLinkInstantaneousStats](Divine.Protobufs.Steam.CMsgSteamDatagramLinkInstantaneousStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_"></a> MergeFrom\(CMsgSteamDatagramLinkInstantaneousStats\)

```csharp
public void MergeFrom(CMsgSteamDatagramLinkInstantaneousStats other)
```

#### Parameters

`other` [CMsgSteamDatagramLinkInstantaneousStats](Divine.Protobufs.Steam.CMsgSteamDatagramLinkInstantaneousStats.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramLinkInstantaneousStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

