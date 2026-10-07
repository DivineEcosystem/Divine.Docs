# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse"></a> Class CMsgClientToGCCandyShopPurchaseRewardResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCandyShopPurchaseRewardResponse : IMessage<CMsgClientToGCCandyShopPurchaseRewardResponse>, IEquatable<CMsgClientToGCCandyShopPurchaseRewardResponse>, IDeepCloneable<CMsgClientToGCCandyShopPurchaseRewardResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCandyShopPurchaseRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopPurchaseRewardResponse.md)

#### Implements

IMessage<CMsgClientToGCCandyShopPurchaseRewardResponse\>, 
[IEquatable<CMsgClientToGCCandyShopPurchaseRewardResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCandyShopPurchaseRewardResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCandyShopPurchaseRewardResponse\>\(CMsgClientToGCCandyShopPurchaseRewardResponse, params CMsgClientToGCCandyShopPurchaseRewardResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse__ctor"></a> CMsgClientToGCCandyShopPurchaseRewardResponse\(\)

```csharp
public CMsgClientToGCCandyShopPurchaseRewardResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse_"></a> CMsgClientToGCCandyShopPurchaseRewardResponse\(CMsgClientToGCCandyShopPurchaseRewardResponse\)

```csharp
public CMsgClientToGCCandyShopPurchaseRewardResponse(CMsgClientToGCCandyShopPurchaseRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopPurchaseRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopPurchaseRewardResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCandyShopPurchaseRewardResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCandyShopPurchaseRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopPurchaseRewardResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse_Response"></a> Response

```csharp
public CMsgClientToGCCandyShopPurchaseRewardResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCCandyShopPurchaseRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopPurchaseRewardResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopPurchaseRewardResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopPurchaseRewardResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCandyShopPurchaseRewardResponse Clone()
```

#### Returns

 [CMsgClientToGCCandyShopPurchaseRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopPurchaseRewardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse_"></a> Equals\(CMsgClientToGCCandyShopPurchaseRewardResponse\)

```csharp
public bool Equals(CMsgClientToGCCandyShopPurchaseRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopPurchaseRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopPurchaseRewardResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse_"></a> MergeFrom\(CMsgClientToGCCandyShopPurchaseRewardResponse\)

```csharp
public void MergeFrom(CMsgClientToGCCandyShopPurchaseRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopPurchaseRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopPurchaseRewardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseRewardResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

