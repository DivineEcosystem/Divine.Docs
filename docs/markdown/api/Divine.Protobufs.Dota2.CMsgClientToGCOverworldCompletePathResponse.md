# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse"></a> Class CMsgClientToGCOverworldCompletePathResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldCompletePathResponse : IMessage<CMsgClientToGCOverworldCompletePathResponse>, IEquatable<CMsgClientToGCOverworldCompletePathResponse>, IDeepCloneable<CMsgClientToGCOverworldCompletePathResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldCompletePathResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldCompletePathResponse.md)

#### Implements

IMessage<CMsgClientToGCOverworldCompletePathResponse\>, 
[IEquatable<CMsgClientToGCOverworldCompletePathResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldCompletePathResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldCompletePathResponse\>\(CMsgClientToGCOverworldCompletePathResponse, params CMsgClientToGCOverworldCompletePathResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse__ctor"></a> CMsgClientToGCOverworldCompletePathResponse\(\)

```csharp
public CMsgClientToGCOverworldCompletePathResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_"></a> CMsgClientToGCOverworldCompletePathResponse\(CMsgClientToGCOverworldCompletePathResponse\)

```csharp
public CMsgClientToGCOverworldCompletePathResponse(CMsgClientToGCOverworldCompletePathResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldCompletePathResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldCompletePathResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_ClaimResponseFieldNumber"></a> ClaimResponseFieldNumber

```csharp
public const int ClaimResponseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_ClaimResponse"></a> ClaimResponse

```csharp
public CMsgDOTAClaimEventActionResponse ClaimResponse { get; set; }
```

#### Property Value

 [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldCompletePathResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldCompletePathResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldCompletePathResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_Response"></a> Response

```csharp
public CMsgClientToGCOverworldCompletePathResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCOverworldCompletePathResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldCompletePathResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldCompletePathResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldCompletePathResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldCompletePathResponse Clone()
```

#### Returns

 [CMsgClientToGCOverworldCompletePathResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldCompletePathResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_"></a> Equals\(CMsgClientToGCOverworldCompletePathResponse\)

```csharp
public bool Equals(CMsgClientToGCOverworldCompletePathResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldCompletePathResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldCompletePathResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_"></a> MergeFrom\(CMsgClientToGCOverworldCompletePathResponse\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldCompletePathResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldCompletePathResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldCompletePathResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePathResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

