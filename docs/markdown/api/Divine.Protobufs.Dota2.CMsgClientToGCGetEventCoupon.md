# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon"></a> Class CMsgClientToGCGetEventCoupon

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetEventCoupon : IMessage<CMsgClientToGCGetEventCoupon>, IEquatable<CMsgClientToGCGetEventCoupon>, IDeepCloneable<CMsgClientToGCGetEventCoupon>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetEventCoupon](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCoupon.md)

#### Implements

IMessage<CMsgClientToGCGetEventCoupon\>, 
[IEquatable<CMsgClientToGCGetEventCoupon\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetEventCoupon\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetEventCoupon\>\(CMsgClientToGCGetEventCoupon, params CMsgClientToGCGetEventCoupon\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon__ctor"></a> CMsgClientToGCGetEventCoupon\(\)

```csharp
public CMsgClientToGCGetEventCoupon()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon_"></a> CMsgClientToGCGetEventCoupon\(CMsgClientToGCGetEventCoupon\)

```csharp
public CMsgClientToGCGetEventCoupon(CMsgClientToGCGetEventCoupon other)
```

#### Parameters

`other` [CMsgClientToGCGetEventCoupon](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCoupon.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetEventCoupon> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetEventCoupon](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCoupon.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetEventCoupon Clone()
```

#### Returns

 [CMsgClientToGCGetEventCoupon](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCoupon.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon_"></a> Equals\(CMsgClientToGCGetEventCoupon\)

```csharp
public bool Equals(CMsgClientToGCGetEventCoupon other)
```

#### Parameters

`other` [CMsgClientToGCGetEventCoupon](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCoupon.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon_"></a> MergeFrom\(CMsgClientToGCGetEventCoupon\)

```csharp
public void MergeFrom(CMsgClientToGCGetEventCoupon other)
```

#### Parameters

`other` [CMsgClientToGCGetEventCoupon](Divine.Protobufs.Dota2.CMsgClientToGCGetEventCoupon.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventCoupon_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

