# <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request"></a> Class CWorkshop\_AddSpecialPayment\_Request

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CWorkshop_AddSpecialPayment_Request : IMessage<CWorkshop_AddSpecialPayment_Request>, IEquatable<CWorkshop_AddSpecialPayment_Request>, IDeepCloneable<CWorkshop_AddSpecialPayment_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CWorkshop\_AddSpecialPayment\_Request](Divine.Protobufs.Steam.CWorkshop\_AddSpecialPayment\_Request.md)

#### Implements

IMessage<CWorkshop\_AddSpecialPayment\_Request\>, 
[IEquatable<CWorkshop\_AddSpecialPayment\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CWorkshop\_AddSpecialPayment\_Request\>, 
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
[EnumerableExtensions.In<CWorkshop\_AddSpecialPayment\_Request\>\(CWorkshop\_AddSpecialPayment\_Request, params CWorkshop\_AddSpecialPayment\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request__ctor"></a> CWorkshop\_AddSpecialPayment\_Request\(\)

```csharp
public CWorkshop_AddSpecialPayment_Request()
```

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request__ctor_Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_"></a> CWorkshop\_AddSpecialPayment\_Request\(CWorkshop\_AddSpecialPayment\_Request\)

```csharp
public CWorkshop_AddSpecialPayment_Request(CWorkshop_AddSpecialPayment_Request other)
```

#### Parameters

`other` [CWorkshop\_AddSpecialPayment\_Request](Divine.Protobufs.Steam.CWorkshop\_AddSpecialPayment\_Request.md)

## Fields

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_DateFieldNumber"></a> DateFieldNumber

```csharp
public const int DateFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_GameitemidFieldNumber"></a> GameitemidFieldNumber

```csharp
public const int GameitemidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_PaymentRowUsdFieldNumber"></a> PaymentRowUsdFieldNumber

```csharp
public const int PaymentRowUsdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_PaymentUsUsdFieldNumber"></a> PaymentUsUsdFieldNumber

```csharp
public const int PaymentUsUsdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_Date"></a> Date

```csharp
public string Date { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_Gameitemid"></a> Gameitemid

```csharp
public uint Gameitemid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_HasDate"></a> HasDate

```csharp
public bool HasDate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_HasGameitemid"></a> HasGameitemid

```csharp
public bool HasGameitemid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_HasPaymentRowUsd"></a> HasPaymentRowUsd

```csharp
public bool HasPaymentRowUsd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_HasPaymentUsUsd"></a> HasPaymentUsUsd

```csharp
public bool HasPaymentUsUsd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_Parser"></a> Parser

```csharp
public static MessageParser<CWorkshop_AddSpecialPayment_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CWorkshop\_AddSpecialPayment\_Request](Divine.Protobufs.Steam.CWorkshop\_AddSpecialPayment\_Request.md)\>

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_PaymentRowUsd"></a> PaymentRowUsd

```csharp
public ulong PaymentRowUsd { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_PaymentUsUsd"></a> PaymentUsUsd

```csharp
public ulong PaymentUsUsd { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_ClearDate"></a> ClearDate\(\)

```csharp
public void ClearDate()
```

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_ClearGameitemid"></a> ClearGameitemid\(\)

```csharp
public void ClearGameitemid()
```

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_ClearPaymentRowUsd"></a> ClearPaymentRowUsd\(\)

```csharp
public void ClearPaymentRowUsd()
```

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_ClearPaymentUsUsd"></a> ClearPaymentUsUsd\(\)

```csharp
public void ClearPaymentUsUsd()
```

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_Clone"></a> Clone\(\)

```csharp
public CWorkshop_AddSpecialPayment_Request Clone()
```

#### Returns

 [CWorkshop\_AddSpecialPayment\_Request](Divine.Protobufs.Steam.CWorkshop\_AddSpecialPayment\_Request.md)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_Equals_Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_"></a> Equals\(CWorkshop\_AddSpecialPayment\_Request\)

```csharp
public bool Equals(CWorkshop_AddSpecialPayment_Request other)
```

#### Parameters

`other` [CWorkshop\_AddSpecialPayment\_Request](Divine.Protobufs.Steam.CWorkshop\_AddSpecialPayment\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_MergeFrom_Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_"></a> MergeFrom\(CWorkshop\_AddSpecialPayment\_Request\)

```csharp
public void MergeFrom(CWorkshop_AddSpecialPayment_Request other)
```

#### Parameters

`other` [CWorkshop\_AddSpecialPayment\_Request](Divine.Protobufs.Steam.CWorkshop\_AddSpecialPayment\_Request.md)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CWorkshop_AddSpecialPayment_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

