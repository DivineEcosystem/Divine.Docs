# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse"></a> Class CMsgClientToGCMonsterHunterClaimRewardResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterClaimRewardResponse : IMessage<CMsgClientToGCMonsterHunterClaimRewardResponse>, IEquatable<CMsgClientToGCMonsterHunterClaimRewardResponse>, IDeepCloneable<CMsgClientToGCMonsterHunterClaimRewardResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterClaimRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimRewardResponse.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterClaimRewardResponse\>, 
[IEquatable<CMsgClientToGCMonsterHunterClaimRewardResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterClaimRewardResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterClaimRewardResponse\>\(CMsgClientToGCMonsterHunterClaimRewardResponse, params CMsgClientToGCMonsterHunterClaimRewardResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse__ctor"></a> CMsgClientToGCMonsterHunterClaimRewardResponse\(\)

```csharp
public CMsgClientToGCMonsterHunterClaimRewardResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_"></a> CMsgClientToGCMonsterHunterClaimRewardResponse\(CMsgClientToGCMonsterHunterClaimRewardResponse\)

```csharp
public CMsgClientToGCMonsterHunterClaimRewardResponse(CMsgClientToGCMonsterHunterClaimRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterClaimRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimRewardResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_ClaimResponseFieldNumber"></a> ClaimResponseFieldNumber

```csharp
public const int ClaimResponseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_MaterialsReceivedFieldNumber"></a> MaterialsReceivedFieldNumber

```csharp
public const int MaterialsReceivedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_ClaimResponse"></a> ClaimResponse

```csharp
public CMsgDOTAClaimEventActionResponse ClaimResponse { get; set; }
```

#### Property Value

 [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_MaterialsReceived"></a> MaterialsReceived

```csharp
public CMsgMonsterHunterMaterialQuantity MaterialsReceived { get; set; }
```

#### Property Value

 [CMsgMonsterHunterMaterialQuantity](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterClaimRewardResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterClaimRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimRewardResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_Response"></a> Response

```csharp
public CMsgClientToGCMonsterHunterClaimRewardResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCMonsterHunterClaimRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimRewardResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimRewardResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimRewardResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterClaimRewardResponse Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterClaimRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimRewardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_"></a> Equals\(CMsgClientToGCMonsterHunterClaimRewardResponse\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterClaimRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterClaimRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimRewardResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_"></a> MergeFrom\(CMsgClientToGCMonsterHunterClaimRewardResponse\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterClaimRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterClaimRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimRewardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimRewardResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

