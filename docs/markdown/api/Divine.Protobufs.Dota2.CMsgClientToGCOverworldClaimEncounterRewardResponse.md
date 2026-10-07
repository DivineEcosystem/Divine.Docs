# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse"></a> Class CMsgClientToGCOverworldClaimEncounterRewardResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldClaimEncounterRewardResponse : IMessage<CMsgClientToGCOverworldClaimEncounterRewardResponse>, IEquatable<CMsgClientToGCOverworldClaimEncounterRewardResponse>, IDeepCloneable<CMsgClientToGCOverworldClaimEncounterRewardResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldClaimEncounterRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimEncounterRewardResponse.md)

#### Implements

IMessage<CMsgClientToGCOverworldClaimEncounterRewardResponse\>, 
[IEquatable<CMsgClientToGCOverworldClaimEncounterRewardResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldClaimEncounterRewardResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldClaimEncounterRewardResponse\>\(CMsgClientToGCOverworldClaimEncounterRewardResponse, params CMsgClientToGCOverworldClaimEncounterRewardResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse__ctor"></a> CMsgClientToGCOverworldClaimEncounterRewardResponse\(\)

```csharp
public CMsgClientToGCOverworldClaimEncounterRewardResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_"></a> CMsgClientToGCOverworldClaimEncounterRewardResponse\(CMsgClientToGCOverworldClaimEncounterRewardResponse\)

```csharp
public CMsgClientToGCOverworldClaimEncounterRewardResponse(CMsgClientToGCOverworldClaimEncounterRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldClaimEncounterRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimEncounterRewardResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_ClaimResponseFieldNumber"></a> ClaimResponseFieldNumber

```csharp
public const int ClaimResponseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_TokensReceivedFieldNumber"></a> TokensReceivedFieldNumber

```csharp
public const int TokensReceivedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_ClaimResponse"></a> ClaimResponse

```csharp
public CMsgDOTAClaimEventActionResponse ClaimResponse { get; set; }
```

#### Property Value

 [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldClaimEncounterRewardResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldClaimEncounterRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimEncounterRewardResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_Response"></a> Response

```csharp
public CMsgClientToGCOverworldClaimEncounterRewardResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCOverworldClaimEncounterRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimEncounterRewardResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimEncounterRewardResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimEncounterRewardResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_TokensReceived"></a> TokensReceived

```csharp
public CMsgOverworldTokenQuantity TokensReceived { get; set; }
```

#### Property Value

 [CMsgOverworldTokenQuantity](Divine.Protobufs.Dota2.CMsgOverworldTokenQuantity.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldClaimEncounterRewardResponse Clone()
```

#### Returns

 [CMsgClientToGCOverworldClaimEncounterRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimEncounterRewardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_"></a> Equals\(CMsgClientToGCOverworldClaimEncounterRewardResponse\)

```csharp
public bool Equals(CMsgClientToGCOverworldClaimEncounterRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldClaimEncounterRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimEncounterRewardResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_"></a> MergeFrom\(CMsgClientToGCOverworldClaimEncounterRewardResponse\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldClaimEncounterRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldClaimEncounterRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimEncounterRewardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimEncounterRewardResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

