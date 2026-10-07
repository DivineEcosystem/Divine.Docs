# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse"></a> Class CMsgClientToGCGetLimitedItemPurchaseQuantityResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetLimitedItemPurchaseQuantityResponse : IMessage<CMsgClientToGCGetLimitedItemPurchaseQuantityResponse>, IEquatable<CMsgClientToGCGetLimitedItemPurchaseQuantityResponse>, IDeepCloneable<CMsgClientToGCGetLimitedItemPurchaseQuantityResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetLimitedItemPurchaseQuantityResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetLimitedItemPurchaseQuantityResponse.md)

#### Implements

IMessage<CMsgClientToGCGetLimitedItemPurchaseQuantityResponse\>, 
[IEquatable<CMsgClientToGCGetLimitedItemPurchaseQuantityResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetLimitedItemPurchaseQuantityResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetLimitedItemPurchaseQuantityResponse\>\(CMsgClientToGCGetLimitedItemPurchaseQuantityResponse, params CMsgClientToGCGetLimitedItemPurchaseQuantityResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse__ctor"></a> CMsgClientToGCGetLimitedItemPurchaseQuantityResponse\(\)

```csharp
public CMsgClientToGCGetLimitedItemPurchaseQuantityResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_"></a> CMsgClientToGCGetLimitedItemPurchaseQuantityResponse\(CMsgClientToGCGetLimitedItemPurchaseQuantityResponse\)

```csharp
public CMsgClientToGCGetLimitedItemPurchaseQuantityResponse(CMsgClientToGCGetLimitedItemPurchaseQuantityResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetLimitedItemPurchaseQuantityResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetLimitedItemPurchaseQuantityResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_QuantityPurchasedFieldNumber"></a> QuantityPurchasedFieldNumber

```csharp
public const int QuantityPurchasedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_HasQuantityPurchased"></a> HasQuantityPurchased

```csharp
public bool HasQuantityPurchased { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetLimitedItemPurchaseQuantityResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetLimitedItemPurchaseQuantityResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetLimitedItemPurchaseQuantityResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_QuantityPurchased"></a> QuantityPurchased

```csharp
public uint QuantityPurchased { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_Result"></a> Result

```csharp
public CMsgClientToGCGetLimitedItemPurchaseQuantityResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCGetLimitedItemPurchaseQuantityResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetLimitedItemPurchaseQuantityResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetLimitedItemPurchaseQuantityResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetLimitedItemPurchaseQuantityResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_ClearQuantityPurchased"></a> ClearQuantityPurchased\(\)

```csharp
public void ClearQuantityPurchased()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetLimitedItemPurchaseQuantityResponse Clone()
```

#### Returns

 [CMsgClientToGCGetLimitedItemPurchaseQuantityResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetLimitedItemPurchaseQuantityResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_"></a> Equals\(CMsgClientToGCGetLimitedItemPurchaseQuantityResponse\)

```csharp
public bool Equals(CMsgClientToGCGetLimitedItemPurchaseQuantityResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetLimitedItemPurchaseQuantityResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetLimitedItemPurchaseQuantityResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_"></a> MergeFrom\(CMsgClientToGCGetLimitedItemPurchaseQuantityResponse\)

```csharp
public void MergeFrom(CMsgClientToGCGetLimitedItemPurchaseQuantityResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetLimitedItemPurchaseQuantityResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetLimitedItemPurchaseQuantityResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetLimitedItemPurchaseQuantityResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

