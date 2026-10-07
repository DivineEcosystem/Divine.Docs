# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse"></a> Class CMsgClientToGCGetEventRankingResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetEventRankingResponse : IMessage<CMsgClientToGCGetEventRankingResponse>, IEquatable<CMsgClientToGCGetEventRankingResponse>, IDeepCloneable<CMsgClientToGCGetEventRankingResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetEventRankingResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventRankingResponse.md)

#### Implements

IMessage<CMsgClientToGCGetEventRankingResponse\>, 
[IEquatable<CMsgClientToGCGetEventRankingResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetEventRankingResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetEventRankingResponse\>\(CMsgClientToGCGetEventRankingResponse, params CMsgClientToGCGetEventRankingResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse__ctor"></a> CMsgClientToGCGetEventRankingResponse\(\)

```csharp
public CMsgClientToGCGetEventRankingResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_"></a> CMsgClientToGCGetEventRankingResponse\(CMsgClientToGCGetEventRankingResponse\)

```csharp
public CMsgClientToGCGetEventRankingResponse(CMsgClientToGCGetEventRankingResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetEventRankingResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventRankingResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_FinalRankBucketFieldNumber"></a> FinalRankBucketFieldNumber

```csharp
public const int FinalRankBucketFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_PercentileFieldNumber"></a> PercentileFieldNumber

```csharp
public const int PercentileFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_ScoreFieldNumber"></a> ScoreFieldNumber

```csharp
public const int ScoreFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_UpdateInProgressFieldNumber"></a> UpdateInProgressFieldNumber

```csharp
public const int UpdateInProgressFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_FinalRankBucket"></a> FinalRankBucket

```csharp
public uint FinalRankBucket { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_HasFinalRankBucket"></a> HasFinalRankBucket

```csharp
public bool HasFinalRankBucket { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_HasPercentile"></a> HasPercentile

```csharp
public bool HasPercentile { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_HasScore"></a> HasScore

```csharp
public bool HasScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_HasUpdateInProgress"></a> HasUpdateInProgress

```csharp
public bool HasUpdateInProgress { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetEventRankingResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetEventRankingResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventRankingResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_Percentile"></a> Percentile

```csharp
public float Percentile { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_Score"></a> Score

```csharp
public float Score { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_UpdateInProgress"></a> UpdateInProgress

```csharp
public bool UpdateInProgress { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_ClearFinalRankBucket"></a> ClearFinalRankBucket\(\)

```csharp
public void ClearFinalRankBucket()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_ClearPercentile"></a> ClearPercentile\(\)

```csharp
public void ClearPercentile()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_ClearScore"></a> ClearScore\(\)

```csharp
public void ClearScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_ClearUpdateInProgress"></a> ClearUpdateInProgress\(\)

```csharp
public void ClearUpdateInProgress()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetEventRankingResponse Clone()
```

#### Returns

 [CMsgClientToGCGetEventRankingResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventRankingResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_"></a> Equals\(CMsgClientToGCGetEventRankingResponse\)

```csharp
public bool Equals(CMsgClientToGCGetEventRankingResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetEventRankingResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventRankingResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_"></a> MergeFrom\(CMsgClientToGCGetEventRankingResponse\)

```csharp
public void MergeFrom(CMsgClientToGCGetEventRankingResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetEventRankingResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventRankingResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRankingResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

