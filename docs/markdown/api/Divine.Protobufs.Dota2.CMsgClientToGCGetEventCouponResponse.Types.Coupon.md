# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon"></a> Class CMsgClientToGCGetEventCouponResponse.Types.Coupon

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetEventCouponResponse.Types.Coupon : IMessage<CMsgClientToGCGetEventCouponResponse.Types.Coupon>, IEquatable<CMsgClientToGCGetEventCouponResponse.Types.Coupon>, IDeepCloneable<CMsgClientToGCGetEventCouponResponse.Types.Coupon>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetEventCouponResponse.Types.Coupon](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.Types.Coupon.md)

#### Implements

IMessage<CMsgClientToGCGetEventCouponResponse.Types.Coupon\>, 
[IEquatable<CMsgClientToGCGetEventCouponResponse.Types.Coupon\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetEventCouponResponse.Types.Coupon\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetEventCouponResponse.Types.Coupon\>\(CMsgClientToGCGetEventCouponResponse.Types.Coupon, params CMsgClientToGCGetEventCouponResponse.Types.Coupon\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon__ctor"></a> Coupon\(\)

```csharp
public Coupon()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_"></a> Coupon\(Coupon\)

```csharp
public Coupon(CMsgClientToGCGetEventCouponResponse.Types.Coupon other)
```

#### Parameters

`other` [CMsgClientToGCGetEventCouponResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.Types.md).[Coupon](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.Types.Coupon.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_CouponCodeFieldNumber"></a> CouponCodeFieldNumber

```csharp
public const int CouponCodeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_CouponIdFieldNumber"></a> CouponIdFieldNumber

```csharp
public const int CouponIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_CouponCode"></a> CouponCode

```csharp
public string CouponCode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_CouponId"></a> CouponId

```csharp
public uint CouponId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_HasCouponCode"></a> HasCouponCode

```csharp
public bool HasCouponCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_HasCouponId"></a> HasCouponId

```csharp
public bool HasCouponId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetEventCouponResponse.Types.Coupon> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetEventCouponResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.Types.md).[Coupon](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.Types.Coupon.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_ClearCouponCode"></a> ClearCouponCode\(\)

```csharp
public void ClearCouponCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_ClearCouponId"></a> ClearCouponId\(\)

```csharp
public void ClearCouponId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetEventCouponResponse.Types.Coupon Clone()
```

#### Returns

 [CMsgClientToGCGetEventCouponResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.Types.md).[Coupon](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.Types.Coupon.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_"></a> Equals\(Coupon\)

```csharp
public bool Equals(CMsgClientToGCGetEventCouponResponse.Types.Coupon other)
```

#### Parameters

`other` [CMsgClientToGCGetEventCouponResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.Types.md).[Coupon](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.Types.Coupon.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_"></a> MergeFrom\(Coupon\)

```csharp
public void MergeFrom(CMsgClientToGCGetEventCouponResponse.Types.Coupon other)
```

#### Parameters

`other` [CMsgClientToGCGetEventCouponResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.Types.md).[Coupon](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCouponResponse.Types.Coupon.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCouponResponse_Types_Coupon_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

