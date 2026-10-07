# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse"></a> Class CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse : IMessage<CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse>, IEquatable<CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse>, IDeepCloneable<CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse\>, 
[IEquatable<CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse\>\(CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse, params CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse__ctor"></a> CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse\(\)

```csharp
public CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse_"></a> CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse\(CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse\)

```csharp
public CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse(CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse_Response"></a> Response

```csharp
public CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse_"></a> Equals\(CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse_"></a> MergeFrom\(CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewardsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

