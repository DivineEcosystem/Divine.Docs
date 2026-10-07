# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse"></a> Class CMsgClientToGCMonsterHunterClaimCodexRewardResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterClaimCodexRewardResponse : IMessage<CMsgClientToGCMonsterHunterClaimCodexRewardResponse>, IEquatable<CMsgClientToGCMonsterHunterClaimCodexRewardResponse>, IDeepCloneable<CMsgClientToGCMonsterHunterClaimCodexRewardResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterClaimCodexRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimCodexRewardResponse.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterClaimCodexRewardResponse\>, 
[IEquatable<CMsgClientToGCMonsterHunterClaimCodexRewardResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterClaimCodexRewardResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterClaimCodexRewardResponse\>\(CMsgClientToGCMonsterHunterClaimCodexRewardResponse, params CMsgClientToGCMonsterHunterClaimCodexRewardResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse__ctor"></a> CMsgClientToGCMonsterHunterClaimCodexRewardResponse\(\)

```csharp
public CMsgClientToGCMonsterHunterClaimCodexRewardResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_"></a> CMsgClientToGCMonsterHunterClaimCodexRewardResponse\(CMsgClientToGCMonsterHunterClaimCodexRewardResponse\)

```csharp
public CMsgClientToGCMonsterHunterClaimCodexRewardResponse(CMsgClientToGCMonsterHunterClaimCodexRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterClaimCodexRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimCodexRewardResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_ClaimResponseFieldNumber"></a> ClaimResponseFieldNumber

```csharp
public const int ClaimResponseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_ClaimResponse"></a> ClaimResponse

```csharp
public CMsgDOTAClaimEventActionResponse ClaimResponse { get; set; }
```

#### Property Value

 [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterClaimCodexRewardResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterClaimCodexRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimCodexRewardResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_Response"></a> Response

```csharp
public CMsgClientToGCMonsterHunterClaimCodexRewardResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCMonsterHunterClaimCodexRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimCodexRewardResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimCodexRewardResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimCodexRewardResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterClaimCodexRewardResponse Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterClaimCodexRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimCodexRewardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_"></a> Equals\(CMsgClientToGCMonsterHunterClaimCodexRewardResponse\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterClaimCodexRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterClaimCodexRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimCodexRewardResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_"></a> MergeFrom\(CMsgClientToGCMonsterHunterClaimCodexRewardResponse\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterClaimCodexRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterClaimCodexRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimCodexRewardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexRewardResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

