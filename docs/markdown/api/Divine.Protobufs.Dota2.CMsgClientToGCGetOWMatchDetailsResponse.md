# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse"></a> Class CMsgClientToGCGetOWMatchDetailsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetOWMatchDetailsResponse : IMessage<CMsgClientToGCGetOWMatchDetailsResponse>, IEquatable<CMsgClientToGCGetOWMatchDetailsResponse>, IDeepCloneable<CMsgClientToGCGetOWMatchDetailsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetOWMatchDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.md)

#### Implements

IMessage<CMsgClientToGCGetOWMatchDetailsResponse\>, 
[IEquatable<CMsgClientToGCGetOWMatchDetailsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetOWMatchDetailsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetOWMatchDetailsResponse\>\(CMsgClientToGCGetOWMatchDetailsResponse, params CMsgClientToGCGetOWMatchDetailsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse__ctor"></a> CMsgClientToGCGetOWMatchDetailsResponse\(\)

```csharp
public CMsgClientToGCGetOWMatchDetailsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_"></a> CMsgClientToGCGetOWMatchDetailsResponse\(CMsgClientToGCGetOWMatchDetailsResponse\)

```csharp
public CMsgClientToGCGetOWMatchDetailsResponse(CMsgClientToGCGetOWMatchDetailsResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetOWMatchDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_ClusterFieldNumber"></a> ClusterFieldNumber

```csharp
public const int ClusterFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_DecryptionKeyFieldNumber"></a> DecryptionKeyFieldNumber

```csharp
public const int DecryptionKeyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_LaneSelectionFlagsFieldNumber"></a> LaneSelectionFlagsFieldNumber

```csharp
public const int LaneSelectionFlagsFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_MarkersFieldNumber"></a> MarkersFieldNumber

```csharp
public const int MarkersFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_OverwatchReplayIdFieldNumber"></a> OverwatchReplayIdFieldNumber

```csharp
public const int OverwatchReplayIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_OverwatchSaltFieldNumber"></a> OverwatchSaltFieldNumber

```csharp
public const int OverwatchSaltFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_RankTierFieldNumber"></a> RankTierFieldNumber

```csharp
public const int RankTierFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_ReportReasonFieldNumber"></a> ReportReasonFieldNumber

```csharp
public const int ReportReasonFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_TargetHeroIdFieldNumber"></a> TargetHeroIdFieldNumber

```csharp
public const int TargetHeroIdFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_TargetPlayerSlotFieldNumber"></a> TargetPlayerSlotFieldNumber

```csharp
public const int TargetPlayerSlotFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Cluster"></a> Cluster

```csharp
public uint Cluster { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_DecryptionKey"></a> DecryptionKey

```csharp
public ulong DecryptionKey { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_HasCluster"></a> HasCluster

```csharp
public bool HasCluster { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_HasDecryptionKey"></a> HasDecryptionKey

```csharp
public bool HasDecryptionKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_HasLaneSelectionFlags"></a> HasLaneSelectionFlags

```csharp
public bool HasLaneSelectionFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_HasOverwatchReplayId"></a> HasOverwatchReplayId

```csharp
public bool HasOverwatchReplayId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_HasOverwatchSalt"></a> HasOverwatchSalt

```csharp
public bool HasOverwatchSalt { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_HasRankTier"></a> HasRankTier

```csharp
public bool HasRankTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_HasReportReason"></a> HasReportReason

```csharp
public bool HasReportReason { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_HasTargetHeroId"></a> HasTargetHeroId

```csharp
public bool HasTargetHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_HasTargetPlayerSlot"></a> HasTargetPlayerSlot

```csharp
public bool HasTargetPlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_LaneSelectionFlags"></a> LaneSelectionFlags

```csharp
public uint LaneSelectionFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Markers"></a> Markers

```csharp
public RepeatedField<CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker> Markers { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCGetOWMatchDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.Types.md).[Marker](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_OverwatchReplayId"></a> OverwatchReplayId

```csharp
public ulong OverwatchReplayId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_OverwatchSalt"></a> OverwatchSalt

```csharp
public uint OverwatchSalt { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetOWMatchDetailsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetOWMatchDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_RankTier"></a> RankTier

```csharp
public uint RankTier { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_ReportReason"></a> ReportReason

```csharp
public EOverwatchReportReason ReportReason { get; set; }
```

#### Property Value

 [EOverwatchReportReason](Divine.Protobufs.Dota2.EOverwatchReportReason.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Result"></a> Result

```csharp
public CMsgClientToGCGetOWMatchDetailsResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCGetOWMatchDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_TargetHeroId"></a> TargetHeroId

```csharp
public int TargetHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_TargetPlayerSlot"></a> TargetPlayerSlot

```csharp
public uint TargetPlayerSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_ClearCluster"></a> ClearCluster\(\)

```csharp
public void ClearCluster()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_ClearDecryptionKey"></a> ClearDecryptionKey\(\)

```csharp
public void ClearDecryptionKey()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_ClearLaneSelectionFlags"></a> ClearLaneSelectionFlags\(\)

```csharp
public void ClearLaneSelectionFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_ClearOverwatchReplayId"></a> ClearOverwatchReplayId\(\)

```csharp
public void ClearOverwatchReplayId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_ClearOverwatchSalt"></a> ClearOverwatchSalt\(\)

```csharp
public void ClearOverwatchSalt()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_ClearRankTier"></a> ClearRankTier\(\)

```csharp
public void ClearRankTier()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_ClearReportReason"></a> ClearReportReason\(\)

```csharp
public void ClearReportReason()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_ClearTargetHeroId"></a> ClearTargetHeroId\(\)

```csharp
public void ClearTargetHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_ClearTargetPlayerSlot"></a> ClearTargetPlayerSlot\(\)

```csharp
public void ClearTargetPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetOWMatchDetailsResponse Clone()
```

#### Returns

 [CMsgClientToGCGetOWMatchDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_"></a> Equals\(CMsgClientToGCGetOWMatchDetailsResponse\)

```csharp
public bool Equals(CMsgClientToGCGetOWMatchDetailsResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetOWMatchDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_"></a> MergeFrom\(CMsgClientToGCGetOWMatchDetailsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCGetOWMatchDetailsResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetOWMatchDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

