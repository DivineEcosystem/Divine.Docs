# <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse"></a> Class CMsgServerToGCEvaluateToxicChatResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCEvaluateToxicChatResponse : IMessage<CMsgServerToGCEvaluateToxicChatResponse>, IEquatable<CMsgServerToGCEvaluateToxicChatResponse>, IDeepCloneable<CMsgServerToGCEvaluateToxicChatResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCEvaluateToxicChatResponse](Divine.Protobufs.Dota2.CMsgServerToGCEvaluateToxicChatResponse.md)

#### Implements

IMessage<CMsgServerToGCEvaluateToxicChatResponse\>, 
[IEquatable<CMsgServerToGCEvaluateToxicChatResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCEvaluateToxicChatResponse\>, 
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
[EnumerableExtensions.In<CMsgServerToGCEvaluateToxicChatResponse\>\(CMsgServerToGCEvaluateToxicChatResponse, params CMsgServerToGCEvaluateToxicChatResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse__ctor"></a> CMsgServerToGCEvaluateToxicChatResponse\(\)

```csharp
public CMsgServerToGCEvaluateToxicChatResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse__ctor_Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_"></a> CMsgServerToGCEvaluateToxicChatResponse\(CMsgServerToGCEvaluateToxicChatResponse\)

```csharp
public CMsgServerToGCEvaluateToxicChatResponse(CMsgServerToGCEvaluateToxicChatResponse other)
```

#### Parameters

`other` [CMsgServerToGCEvaluateToxicChatResponse](Divine.Protobufs.Dota2.CMsgServerToGCEvaluateToxicChatResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_BanDurationFieldNumber"></a> BanDurationFieldNumber

```csharp
public const int BanDurationFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_BanReasonFieldNumber"></a> BanReasonFieldNumber

```csharp
public const int BanReasonFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_ReporterAccountIdFieldNumber"></a> ReporterAccountIdFieldNumber

```csharp
public const int ReporterAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_ToxicityScoreFieldNumber"></a> ToxicityScoreFieldNumber

```csharp
public const int ToxicityScoreFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_BanDuration"></a> BanDuration

```csharp
public uint BanDuration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_BanReason"></a> BanReason

```csharp
public uint BanReason { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_HasBanDuration"></a> HasBanDuration

```csharp
public bool HasBanDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_HasBanReason"></a> HasBanReason

```csharp
public bool HasBanReason { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_HasReporterAccountId"></a> HasReporterAccountId

```csharp
public bool HasReporterAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_HasToxicityScore"></a> HasToxicityScore

```csharp
public bool HasToxicityScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCEvaluateToxicChatResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCEvaluateToxicChatResponse](Divine.Protobufs.Dota2.CMsgServerToGCEvaluateToxicChatResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_ReporterAccountId"></a> ReporterAccountId

```csharp
public uint ReporterAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_ToxicityScore"></a> ToxicityScore

```csharp
public float ToxicityScore { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_ClearBanDuration"></a> ClearBanDuration\(\)

```csharp
public void ClearBanDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_ClearBanReason"></a> ClearBanReason\(\)

```csharp
public void ClearBanReason()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_ClearReporterAccountId"></a> ClearReporterAccountId\(\)

```csharp
public void ClearReporterAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_ClearToxicityScore"></a> ClearToxicityScore\(\)

```csharp
public void ClearToxicityScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCEvaluateToxicChatResponse Clone()
```

#### Returns

 [CMsgServerToGCEvaluateToxicChatResponse](Divine.Protobufs.Dota2.CMsgServerToGCEvaluateToxicChatResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_Equals_Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_"></a> Equals\(CMsgServerToGCEvaluateToxicChatResponse\)

```csharp
public bool Equals(CMsgServerToGCEvaluateToxicChatResponse other)
```

#### Parameters

`other` [CMsgServerToGCEvaluateToxicChatResponse](Divine.Protobufs.Dota2.CMsgServerToGCEvaluateToxicChatResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_"></a> MergeFrom\(CMsgServerToGCEvaluateToxicChatResponse\)

```csharp
public void MergeFrom(CMsgServerToGCEvaluateToxicChatResponse other)
```

#### Parameters

`other` [CMsgServerToGCEvaluateToxicChatResponse](Divine.Protobufs.Dota2.CMsgServerToGCEvaluateToxicChatResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChatResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

