# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse"></a> Class CMsgClientToGCOverworldRequestFortuneResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldRequestFortuneResponse : IMessage<CMsgClientToGCOverworldRequestFortuneResponse>, IEquatable<CMsgClientToGCOverworldRequestFortuneResponse>, IDeepCloneable<CMsgClientToGCOverworldRequestFortuneResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldRequestFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestFortuneResponse.md)

#### Implements

IMessage<CMsgClientToGCOverworldRequestFortuneResponse\>, 
[IEquatable<CMsgClientToGCOverworldRequestFortuneResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldRequestFortuneResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldRequestFortuneResponse\>\(CMsgClientToGCOverworldRequestFortuneResponse, params CMsgClientToGCOverworldRequestFortuneResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse__ctor"></a> CMsgClientToGCOverworldRequestFortuneResponse\(\)

```csharp
public CMsgClientToGCOverworldRequestFortuneResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_"></a> CMsgClientToGCOverworldRequestFortuneResponse\(CMsgClientToGCOverworldRequestFortuneResponse\)

```csharp
public CMsgClientToGCOverworldRequestFortuneResponse(CMsgClientToGCOverworldRequestFortuneResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldRequestFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestFortuneResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_ClaimResponseFieldNumber"></a> ClaimResponseFieldNumber

```csharp
public const int ClaimResponseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_ClaimResponse"></a> ClaimResponse

```csharp
public CMsgDOTAClaimEventActionResponse ClaimResponse { get; set; }
```

#### Property Value

 [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldRequestFortuneResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldRequestFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestFortuneResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_Response"></a> Response

```csharp
public CMsgClientToGCOverworldRequestFortuneResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCOverworldRequestFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestFortuneResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestFortuneResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestFortuneResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldRequestFortuneResponse Clone()
```

#### Returns

 [CMsgClientToGCOverworldRequestFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestFortuneResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_"></a> Equals\(CMsgClientToGCOverworldRequestFortuneResponse\)

```csharp
public bool Equals(CMsgClientToGCOverworldRequestFortuneResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldRequestFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestFortuneResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_"></a> MergeFrom\(CMsgClientToGCOverworldRequestFortuneResponse\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldRequestFortuneResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldRequestFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestFortuneResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortuneResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

