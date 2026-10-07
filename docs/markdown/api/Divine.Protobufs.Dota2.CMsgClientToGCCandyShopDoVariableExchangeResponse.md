# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse"></a> Class CMsgClientToGCCandyShopDoVariableExchangeResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCandyShopDoVariableExchangeResponse : IMessage<CMsgClientToGCCandyShopDoVariableExchangeResponse>, IEquatable<CMsgClientToGCCandyShopDoVariableExchangeResponse>, IDeepCloneable<CMsgClientToGCCandyShopDoVariableExchangeResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCandyShopDoVariableExchangeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoVariableExchangeResponse.md)

#### Implements

IMessage<CMsgClientToGCCandyShopDoVariableExchangeResponse\>, 
[IEquatable<CMsgClientToGCCandyShopDoVariableExchangeResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCandyShopDoVariableExchangeResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCandyShopDoVariableExchangeResponse\>\(CMsgClientToGCCandyShopDoVariableExchangeResponse, params CMsgClientToGCCandyShopDoVariableExchangeResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse__ctor"></a> CMsgClientToGCCandyShopDoVariableExchangeResponse\(\)

```csharp
public CMsgClientToGCCandyShopDoVariableExchangeResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse_"></a> CMsgClientToGCCandyShopDoVariableExchangeResponse\(CMsgClientToGCCandyShopDoVariableExchangeResponse\)

```csharp
public CMsgClientToGCCandyShopDoVariableExchangeResponse(CMsgClientToGCCandyShopDoVariableExchangeResponse other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDoVariableExchangeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoVariableExchangeResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCandyShopDoVariableExchangeResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCandyShopDoVariableExchangeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoVariableExchangeResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse_Response"></a> Response

```csharp
public CMsgClientToGCCandyShopDoVariableExchangeResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCCandyShopDoVariableExchangeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoVariableExchangeResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoVariableExchangeResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoVariableExchangeResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCandyShopDoVariableExchangeResponse Clone()
```

#### Returns

 [CMsgClientToGCCandyShopDoVariableExchangeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoVariableExchangeResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse_"></a> Equals\(CMsgClientToGCCandyShopDoVariableExchangeResponse\)

```csharp
public bool Equals(CMsgClientToGCCandyShopDoVariableExchangeResponse other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDoVariableExchangeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoVariableExchangeResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse_"></a> MergeFrom\(CMsgClientToGCCandyShopDoVariableExchangeResponse\)

```csharp
public void MergeFrom(CMsgClientToGCCandyShopDoVariableExchangeResponse other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDoVariableExchangeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoVariableExchangeResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchangeResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

