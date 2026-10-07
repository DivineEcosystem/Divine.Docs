# <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse"></a> Class CMsgClientToGCPurchaseChargeCostItemsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCPurchaseChargeCostItemsResponse : IMessage<CMsgClientToGCPurchaseChargeCostItemsResponse>, IEquatable<CMsgClientToGCPurchaseChargeCostItemsResponse>, IDeepCloneable<CMsgClientToGCPurchaseChargeCostItemsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCPurchaseChargeCostItemsResponse](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItemsResponse.md)

#### Implements

IMessage<CMsgClientToGCPurchaseChargeCostItemsResponse\>, 
[IEquatable<CMsgClientToGCPurchaseChargeCostItemsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCPurchaseChargeCostItemsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCPurchaseChargeCostItemsResponse\>\(CMsgClientToGCPurchaseChargeCostItemsResponse, params CMsgClientToGCPurchaseChargeCostItemsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse__ctor"></a> CMsgClientToGCPurchaseChargeCostItemsResponse\(\)

```csharp
public CMsgClientToGCPurchaseChargeCostItemsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_"></a> CMsgClientToGCPurchaseChargeCostItemsResponse\(CMsgClientToGCPurchaseChargeCostItemsResponse\)

```csharp
public CMsgClientToGCPurchaseChargeCostItemsResponse(CMsgClientToGCPurchaseChargeCostItemsResponse other)
```

#### Parameters

`other` [CMsgClientToGCPurchaseChargeCostItemsResponse](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItemsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_ItemIdsFieldNumber"></a> ItemIdsFieldNumber

```csharp
public const int ItemIdsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_ItemIds"></a> ItemIds

```csharp
public RepeatedField<ulong> ItemIds { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCPurchaseChargeCostItemsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCPurchaseChargeCostItemsResponse](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItemsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_Result"></a> Result

```csharp
public CMsgClientToGCPurchaseChargeCostItemsResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCPurchaseChargeCostItemsResponse](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItemsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItemsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItemsResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCPurchaseChargeCostItemsResponse Clone()
```

#### Returns

 [CMsgClientToGCPurchaseChargeCostItemsResponse](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItemsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_"></a> Equals\(CMsgClientToGCPurchaseChargeCostItemsResponse\)

```csharp
public bool Equals(CMsgClientToGCPurchaseChargeCostItemsResponse other)
```

#### Parameters

`other` [CMsgClientToGCPurchaseChargeCostItemsResponse](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItemsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_"></a> MergeFrom\(CMsgClientToGCPurchaseChargeCostItemsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCPurchaseChargeCostItemsResponse other)
```

#### Parameters

`other` [CMsgClientToGCPurchaseChargeCostItemsResponse](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItemsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItemsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

