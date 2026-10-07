# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse"></a> Class CMsgClientToGCGetEventCouponResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetEventCouponResponse : IMessage<CMsgClientToGCGetEventCouponResponse>, IEquatable<CMsgClientToGCGetEventCouponResponse>, IDeepCloneable<CMsgClientToGCGetEventCouponResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetEventCouponResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.md)

#### Implements

IMessage<CMsgClientToGCGetEventCouponResponse\>, 
[IEquatable<CMsgClientToGCGetEventCouponResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetEventCouponResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetEventCouponResponse\>\(CMsgClientToGCGetEventCouponResponse, params CMsgClientToGCGetEventCouponResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse__ctor"></a> CMsgClientToGCGetEventCouponResponse\(\)

```csharp
public CMsgClientToGCGetEventCouponResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_"></a> CMsgClientToGCGetEventCouponResponse\(CMsgClientToGCGetEventCouponResponse\)

```csharp
public CMsgClientToGCGetEventCouponResponse(CMsgClientToGCGetEventCouponResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetEventCouponResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_CouponsFieldNumber"></a> CouponsFieldNumber

```csharp
public const int CouponsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Coupons"></a> Coupons

```csharp
public RepeatedField<CMsgClientToGCGetEventCouponResponse.Types.Coupon> Coupons { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCGetEventCouponResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.Types.md).[Coupon](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.Types.Coupon.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetEventCouponResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetEventCouponResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Result"></a> Result

```csharp
public CMsgClientToGCGetEventCouponResponse.Types.ResultCode Result { get; set; }
```

#### Property Value

 [CMsgClientToGCGetEventCouponResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.Types.md).[ResultCode](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.Types.ResultCode.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetEventCouponResponse Clone()
```

#### Returns

 [CMsgClientToGCGetEventCouponResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_"></a> Equals\(CMsgClientToGCGetEventCouponResponse\)

```csharp
public bool Equals(CMsgClientToGCGetEventCouponResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetEventCouponResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_"></a> MergeFrom\(CMsgClientToGCGetEventCouponResponse\)

```csharp
public void MergeFrom(CMsgClientToGCGetEventCouponResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetEventCouponResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

