# <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse"></a> Class CMsgClientToGCWrapAndDeliverGiftResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCWrapAndDeliverGiftResponse : IMessage<CMsgClientToGCWrapAndDeliverGiftResponse>, IEquatable<CMsgClientToGCWrapAndDeliverGiftResponse>, IDeepCloneable<CMsgClientToGCWrapAndDeliverGiftResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCWrapAndDeliverGiftResponse](Divine.Protobufs.Dota2.CMsgClientToGCWrapAndDeliverGiftResponse.md)

#### Implements

IMessage<CMsgClientToGCWrapAndDeliverGiftResponse\>, 
[IEquatable<CMsgClientToGCWrapAndDeliverGiftResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCWrapAndDeliverGiftResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCWrapAndDeliverGiftResponse\>\(CMsgClientToGCWrapAndDeliverGiftResponse, params CMsgClientToGCWrapAndDeliverGiftResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse__ctor"></a> CMsgClientToGCWrapAndDeliverGiftResponse\(\)

```csharp
public CMsgClientToGCWrapAndDeliverGiftResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_"></a> CMsgClientToGCWrapAndDeliverGiftResponse\(CMsgClientToGCWrapAndDeliverGiftResponse\)

```csharp
public CMsgClientToGCWrapAndDeliverGiftResponse(CMsgClientToGCWrapAndDeliverGiftResponse other)
```

#### Parameters

`other` [CMsgClientToGCWrapAndDeliverGiftResponse](Divine.Protobufs.Dota2.CMsgClientToGCWrapAndDeliverGiftResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_GiftingChargeMaxFieldNumber"></a> GiftingChargeMaxFieldNumber

```csharp
public const int GiftingChargeMaxFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_GiftingChargeUsesFieldNumber"></a> GiftingChargeUsesFieldNumber

```csharp
public const int GiftingChargeUsesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_GiftingMaxFieldNumber"></a> GiftingMaxFieldNumber

```csharp
public const int GiftingMaxFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_GiftingUsesFieldNumber"></a> GiftingUsesFieldNumber

```csharp
public const int GiftingUsesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_GiftingWindowHoursFieldNumber"></a> GiftingWindowHoursFieldNumber

```csharp
public const int GiftingWindowHoursFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_TradeRestrictionFieldNumber"></a> TradeRestrictionFieldNumber

```csharp
public const int TradeRestrictionFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_GiftingChargeMax"></a> GiftingChargeMax

```csharp
public int GiftingChargeMax { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_GiftingChargeUses"></a> GiftingChargeUses

```csharp
public uint GiftingChargeUses { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_GiftingMax"></a> GiftingMax

```csharp
public int GiftingMax { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_GiftingUses"></a> GiftingUses

```csharp
public uint GiftingUses { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_GiftingWindowHours"></a> GiftingWindowHours

```csharp
public uint GiftingWindowHours { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_HasGiftingChargeMax"></a> HasGiftingChargeMax

```csharp
public bool HasGiftingChargeMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_HasGiftingChargeUses"></a> HasGiftingChargeUses

```csharp
public bool HasGiftingChargeUses { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_HasGiftingMax"></a> HasGiftingMax

```csharp
public bool HasGiftingMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_HasGiftingUses"></a> HasGiftingUses

```csharp
public bool HasGiftingUses { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_HasGiftingWindowHours"></a> HasGiftingWindowHours

```csharp
public bool HasGiftingWindowHours { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_HasTradeRestriction"></a> HasTradeRestriction

```csharp
public bool HasTradeRestriction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCWrapAndDeliverGiftResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCWrapAndDeliverGiftResponse](Divine.Protobufs.Dota2.CMsgClientToGCWrapAndDeliverGiftResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_Response"></a> Response

```csharp
public EGCMsgResponse Response { get; set; }
```

#### Property Value

 [EGCMsgResponse](Divine.Protobufs.Dota2.EGCMsgResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_TradeRestriction"></a> TradeRestriction

```csharp
public EGCMsgInitiateTradeResponse TradeRestriction { get; set; }
```

#### Property Value

 [EGCMsgInitiateTradeResponse](Divine.Protobufs.Dota2.EGCMsgInitiateTradeResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_ClearGiftingChargeMax"></a> ClearGiftingChargeMax\(\)

```csharp
public void ClearGiftingChargeMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_ClearGiftingChargeUses"></a> ClearGiftingChargeUses\(\)

```csharp
public void ClearGiftingChargeUses()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_ClearGiftingMax"></a> ClearGiftingMax\(\)

```csharp
public void ClearGiftingMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_ClearGiftingUses"></a> ClearGiftingUses\(\)

```csharp
public void ClearGiftingUses()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_ClearGiftingWindowHours"></a> ClearGiftingWindowHours\(\)

```csharp
public void ClearGiftingWindowHours()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_ClearTradeRestriction"></a> ClearTradeRestriction\(\)

```csharp
public void ClearTradeRestriction()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCWrapAndDeliverGiftResponse Clone()
```

#### Returns

 [CMsgClientToGCWrapAndDeliverGiftResponse](Divine.Protobufs.Dota2.CMsgClientToGCWrapAndDeliverGiftResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_"></a> Equals\(CMsgClientToGCWrapAndDeliverGiftResponse\)

```csharp
public bool Equals(CMsgClientToGCWrapAndDeliverGiftResponse other)
```

#### Parameters

`other` [CMsgClientToGCWrapAndDeliverGiftResponse](Divine.Protobufs.Dota2.CMsgClientToGCWrapAndDeliverGiftResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_"></a> MergeFrom\(CMsgClientToGCWrapAndDeliverGiftResponse\)

```csharp
public void MergeFrom(CMsgClientToGCWrapAndDeliverGiftResponse other)
```

#### Parameters

`other` [CMsgClientToGCWrapAndDeliverGiftResponse](Divine.Protobufs.Dota2.CMsgClientToGCWrapAndDeliverGiftResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGiftResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

