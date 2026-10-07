# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse"></a> Class CMsgClientToGCOverworldTradeTokensResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldTradeTokensResponse : IMessage<CMsgClientToGCOverworldTradeTokensResponse>, IEquatable<CMsgClientToGCOverworldTradeTokensResponse>, IDeepCloneable<CMsgClientToGCOverworldTradeTokensResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldTradeTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldTradeTokensResponse.md)

#### Implements

IMessage<CMsgClientToGCOverworldTradeTokensResponse\>, 
[IEquatable<CMsgClientToGCOverworldTradeTokensResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldTradeTokensResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldTradeTokensResponse\>\(CMsgClientToGCOverworldTradeTokensResponse, params CMsgClientToGCOverworldTradeTokensResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse__ctor"></a> CMsgClientToGCOverworldTradeTokensResponse\(\)

```csharp
public CMsgClientToGCOverworldTradeTokensResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_"></a> CMsgClientToGCOverworldTradeTokensResponse\(CMsgClientToGCOverworldTradeTokensResponse\)

```csharp
public CMsgClientToGCOverworldTradeTokensResponse(CMsgClientToGCOverworldTradeTokensResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldTradeTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldTradeTokensResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_TokensReceivedFieldNumber"></a> TokensReceivedFieldNumber

```csharp
public const int TokensReceivedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldTradeTokensResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldTradeTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldTradeTokensResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_Response"></a> Response

```csharp
public CMsgClientToGCOverworldTradeTokensResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCOverworldTradeTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldTradeTokensResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldTradeTokensResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldTradeTokensResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_TokensReceived"></a> TokensReceived

```csharp
public CMsgOverworldTokenQuantity TokensReceived { get; set; }
```

#### Property Value

 [CMsgOverworldTokenQuantity](Divine.Protobufs.Dota2.CMsgOverworldTokenQuantity.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldTradeTokensResponse Clone()
```

#### Returns

 [CMsgClientToGCOverworldTradeTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldTradeTokensResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_"></a> Equals\(CMsgClientToGCOverworldTradeTokensResponse\)

```csharp
public bool Equals(CMsgClientToGCOverworldTradeTokensResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldTradeTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldTradeTokensResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_"></a> MergeFrom\(CMsgClientToGCOverworldTradeTokensResponse\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldTradeTokensResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldTradeTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldTradeTokensResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokensResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

