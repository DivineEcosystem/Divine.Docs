# <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client"></a> Class CSource2Metrics\_MatchPerfSummary\_Notification.Types.Client

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSource2Metrics_MatchPerfSummary_Notification.Types.Client : IMessage<CSource2Metrics_MatchPerfSummary_Notification.Types.Client>, IEquatable<CSource2Metrics_MatchPerfSummary_Notification.Types.Client>, IDeepCloneable<CSource2Metrics_MatchPerfSummary_Notification.Types.Client>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSource2Metrics\_MatchPerfSummary\_Notification.Types.Client](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.Types.Client.md)

#### Implements

IMessage<CSource2Metrics\_MatchPerfSummary\_Notification.Types.Client\>, 
[IEquatable<CSource2Metrics\_MatchPerfSummary\_Notification.Types.Client\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSource2Metrics\_MatchPerfSummary\_Notification.Types.Client\>, 
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
[EnumerableExtensions.In<CSource2Metrics\_MatchPerfSummary\_Notification.Types.Client\>\(CSource2Metrics\_MatchPerfSummary\_Notification.Types.Client, params CSource2Metrics\_MatchPerfSummary\_Notification.Types.Client\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client__ctor"></a> Client\(\)

```csharp
public Client()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client__ctor_Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_"></a> Client\(Client\)

```csharp
public Client(CSource2Metrics_MatchPerfSummary_Notification.Types.Client other)
```

#### Parameters

`other` [CSource2Metrics\_MatchPerfSummary\_Notification](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.md).[Types](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.Types.md).[Client](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.Types.Client.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_BuildIdFieldNumber"></a> BuildIdFieldNumber

```csharp
public const int BuildIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_DownstreamFlowFieldNumber"></a> DownstreamFlowFieldNumber

```csharp
public const int DownstreamFlowFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_PerfSamplesFieldNumber"></a> PerfSamplesFieldNumber

```csharp
public const int PerfSamplesFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_ProfileFieldNumber"></a> ProfileFieldNumber

```csharp
public const int ProfileFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_SystemSpecsFieldNumber"></a> SystemSpecsFieldNumber

```csharp
public const int SystemSpecsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_UpstreamFlowFieldNumber"></a> UpstreamFlowFieldNumber

```csharp
public const int UpstreamFlowFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_BuildId"></a> BuildId

```csharp
public uint BuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_DownstreamFlow"></a> DownstreamFlow

```csharp
public CMsgSource2NetworkFlowQuality DownstreamFlow { get; set; }
```

#### Property Value

 [CMsgSource2NetworkFlowQuality](Divine.Protobufs.Dota2.CMsgSource2NetworkFlowQuality.md)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_HasBuildId"></a> HasBuildId

```csharp
public bool HasBuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_Parser"></a> Parser

```csharp
public static MessageParser<CSource2Metrics_MatchPerfSummary_Notification.Types.Client> Parser { get; }
```

#### Property Value

 MessageParser<[CSource2Metrics\_MatchPerfSummary\_Notification](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.md).[Types](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.Types.md).[Client](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.Types.Client.md)\>

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_PerfSamples"></a> PerfSamples

```csharp
public RepeatedField<CMsgSource2FramePerfSample> PerfSamples { get; }
```

#### Property Value

 RepeatedField<[CMsgSource2FramePerfSample](Divine.Protobufs.Dota2.CMsgSource2FramePerfSample.md)\>

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_Profile"></a> Profile

```csharp
public CMsgSource2VProfLiteReport Profile { get; set; }
```

#### Property Value

 [CMsgSource2VProfLiteReport](Divine.Protobufs.Dota2.CMsgSource2VProfLiteReport.md)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_SystemSpecs"></a> SystemSpecs

```csharp
public CMsgSource2SystemSpecs SystemSpecs { get; set; }
```

#### Property Value

 [CMsgSource2SystemSpecs](Divine.Protobufs.Dota2.CMsgSource2SystemSpecs.md)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_UpstreamFlow"></a> UpstreamFlow

```csharp
public CMsgSource2NetworkFlowQuality UpstreamFlow { get; set; }
```

#### Property Value

 [CMsgSource2NetworkFlowQuality](Divine.Protobufs.Dota2.CMsgSource2NetworkFlowQuality.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_ClearBuildId"></a> ClearBuildId\(\)

```csharp
public void ClearBuildId()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_Clone"></a> Clone\(\)

```csharp
public CSource2Metrics_MatchPerfSummary_Notification.Types.Client Clone()
```

#### Returns

 [CSource2Metrics\_MatchPerfSummary\_Notification](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.md).[Types](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.Types.md).[Client](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.Types.Client.md)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_Equals_Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_"></a> Equals\(Client\)

```csharp
public bool Equals(CSource2Metrics_MatchPerfSummary_Notification.Types.Client other)
```

#### Parameters

`other` [CSource2Metrics\_MatchPerfSummary\_Notification](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.md).[Types](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.Types.md).[Client](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.Types.Client.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_MergeFrom_Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_"></a> MergeFrom\(Client\)

```csharp
public void MergeFrom(CSource2Metrics_MatchPerfSummary_Notification.Types.Client other)
```

#### Parameters

`other` [CSource2Metrics\_MatchPerfSummary\_Notification](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.md).[Types](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.Types.md).[Client](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.Types.Client.md)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Types_Client_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

