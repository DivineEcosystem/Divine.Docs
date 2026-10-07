# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse"></a> Class CMsgClientToGCMonsterHunterClaimSetRewardResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterClaimSetRewardResponse : IMessage<CMsgClientToGCMonsterHunterClaimSetRewardResponse>, IEquatable<CMsgClientToGCMonsterHunterClaimSetRewardResponse>, IDeepCloneable<CMsgClientToGCMonsterHunterClaimSetRewardResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterClaimSetRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimSetRewardResponse.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterClaimSetRewardResponse\>, 
[IEquatable<CMsgClientToGCMonsterHunterClaimSetRewardResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterClaimSetRewardResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterClaimSetRewardResponse\>\(CMsgClientToGCMonsterHunterClaimSetRewardResponse, params CMsgClientToGCMonsterHunterClaimSetRewardResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse__ctor"></a> CMsgClientToGCMonsterHunterClaimSetRewardResponse\(\)

```csharp
public CMsgClientToGCMonsterHunterClaimSetRewardResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_"></a> CMsgClientToGCMonsterHunterClaimSetRewardResponse\(CMsgClientToGCMonsterHunterClaimSetRewardResponse\)

```csharp
public CMsgClientToGCMonsterHunterClaimSetRewardResponse(CMsgClientToGCMonsterHunterClaimSetRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterClaimSetRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimSetRewardResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_ClaimResponsesFieldNumber"></a> ClaimResponsesFieldNumber

```csharp
public const int ClaimResponsesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_ClaimResponses"></a> ClaimResponses

```csharp
public RepeatedField<CMsgDOTAClaimEventActionResponse> ClaimResponses { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterClaimSetRewardResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterClaimSetRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimSetRewardResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_Response"></a> Response

```csharp
public CMsgClientToGCMonsterHunterClaimSetRewardResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCMonsterHunterClaimSetRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimSetRewardResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimSetRewardResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimSetRewardResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterClaimSetRewardResponse Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterClaimSetRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimSetRewardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_"></a> Equals\(CMsgClientToGCMonsterHunterClaimSetRewardResponse\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterClaimSetRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterClaimSetRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimSetRewardResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_"></a> MergeFrom\(CMsgClientToGCMonsterHunterClaimSetRewardResponse\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterClaimSetRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterClaimSetRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimSetRewardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetRewardResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

