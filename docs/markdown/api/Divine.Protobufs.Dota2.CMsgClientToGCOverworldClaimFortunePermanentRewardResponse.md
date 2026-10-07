# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse"></a> Class CMsgClientToGCOverworldClaimFortunePermanentRewardResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldClaimFortunePermanentRewardResponse : IMessage<CMsgClientToGCOverworldClaimFortunePermanentRewardResponse>, IEquatable<CMsgClientToGCOverworldClaimFortunePermanentRewardResponse>, IDeepCloneable<CMsgClientToGCOverworldClaimFortunePermanentRewardResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldClaimFortunePermanentRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortunePermanentRewardResponse.md)

#### Implements

IMessage<CMsgClientToGCOverworldClaimFortunePermanentRewardResponse\>, 
[IEquatable<CMsgClientToGCOverworldClaimFortunePermanentRewardResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldClaimFortunePermanentRewardResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldClaimFortunePermanentRewardResponse\>\(CMsgClientToGCOverworldClaimFortunePermanentRewardResponse, params CMsgClientToGCOverworldClaimFortunePermanentRewardResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse__ctor"></a> CMsgClientToGCOverworldClaimFortunePermanentRewardResponse\(\)

```csharp
public CMsgClientToGCOverworldClaimFortunePermanentRewardResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_"></a> CMsgClientToGCOverworldClaimFortunePermanentRewardResponse\(CMsgClientToGCOverworldClaimFortunePermanentRewardResponse\)

```csharp
public CMsgClientToGCOverworldClaimFortunePermanentRewardResponse(CMsgClientToGCOverworldClaimFortunePermanentRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldClaimFortunePermanentRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortunePermanentRewardResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_ClaimResponseFieldNumber"></a> ClaimResponseFieldNumber

```csharp
public const int ClaimResponseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_ClaimResponse"></a> ClaimResponse

```csharp
public CMsgDOTAClaimEventActionResponse ClaimResponse { get; set; }
```

#### Property Value

 [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldClaimFortunePermanentRewardResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldClaimFortunePermanentRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortunePermanentRewardResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_Response"></a> Response

```csharp
public CMsgClientToGCOverworldClaimFortunePermanentRewardResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCOverworldClaimFortunePermanentRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortunePermanentRewardResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortunePermanentRewardResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortunePermanentRewardResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldClaimFortunePermanentRewardResponse Clone()
```

#### Returns

 [CMsgClientToGCOverworldClaimFortunePermanentRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortunePermanentRewardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_"></a> Equals\(CMsgClientToGCOverworldClaimFortunePermanentRewardResponse\)

```csharp
public bool Equals(CMsgClientToGCOverworldClaimFortunePermanentRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldClaimFortunePermanentRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortunePermanentRewardResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_"></a> MergeFrom\(CMsgClientToGCOverworldClaimFortunePermanentRewardResponse\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldClaimFortunePermanentRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldClaimFortunePermanentRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortunePermanentRewardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentRewardResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

