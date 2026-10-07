# <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment"></a> Class CWorkshop\_GetSpecialPayments\_Response.Types.SpecialPayment

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CWorkshop_GetSpecialPayments_Response.Types.SpecialPayment : IMessage<CWorkshop_GetSpecialPayments_Response.Types.SpecialPayment>, IEquatable<CWorkshop_GetSpecialPayments_Response.Types.SpecialPayment>, IDeepCloneable<CWorkshop_GetSpecialPayments_Response.Types.SpecialPayment>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CWorkshop\_GetSpecialPayments\_Response.Types.SpecialPayment](Divine.Protobufs.Steam.CWorkshop\_GetSpecialPayments\_Response.Types.SpecialPayment.md)

#### Implements

IMessage<CWorkshop\_GetSpecialPayments\_Response.Types.SpecialPayment\>, 
[IEquatable<CWorkshop\_GetSpecialPayments\_Response.Types.SpecialPayment\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CWorkshop\_GetSpecialPayments\_Response.Types.SpecialPayment\>, 
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
[EnumerableExtensions.In<CWorkshop\_GetSpecialPayments\_Response.Types.SpecialPayment\>\(CWorkshop\_GetSpecialPayments\_Response.Types.SpecialPayment, params CWorkshop\_GetSpecialPayments\_Response.Types.SpecialPayment\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment__ctor"></a> SpecialPayment\(\)

```csharp
public SpecialPayment()
```

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment__ctor_Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_"></a> SpecialPayment\(SpecialPayment\)

```csharp
public SpecialPayment(CWorkshop_GetSpecialPayments_Response.Types.SpecialPayment other)
```

#### Parameters

`other` [CWorkshop\_GetSpecialPayments\_Response](Divine.Protobufs.Steam.CWorkshop\_GetSpecialPayments\_Response.md).[Types](Divine.Protobufs.Steam.CWorkshop\_GetSpecialPayments\_Response.Types.md).[SpecialPayment](Divine.Protobufs.Steam.CWorkshop\_GetSpecialPayments\_Response.Types.SpecialPayment.md)

## Fields

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_DateFieldNumber"></a> DateFieldNumber

```csharp
public const int DateFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_GameitemidFieldNumber"></a> GameitemidFieldNumber

```csharp
public const int GameitemidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_NetPaymentRowUsdFieldNumber"></a> NetPaymentRowUsdFieldNumber

```csharp
public const int NetPaymentRowUsdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_NetPaymentUsUsdFieldNumber"></a> NetPaymentUsUsdFieldNumber

```csharp
public const int NetPaymentUsUsdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_Date"></a> Date

```csharp
public string Date { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_Gameitemid"></a> Gameitemid

```csharp
public uint Gameitemid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_HasDate"></a> HasDate

```csharp
public bool HasDate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_HasGameitemid"></a> HasGameitemid

```csharp
public bool HasGameitemid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_HasNetPaymentRowUsd"></a> HasNetPaymentRowUsd

```csharp
public bool HasNetPaymentRowUsd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_HasNetPaymentUsUsd"></a> HasNetPaymentUsUsd

```csharp
public bool HasNetPaymentUsUsd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_NetPaymentRowUsd"></a> NetPaymentRowUsd

```csharp
public ulong NetPaymentRowUsd { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_NetPaymentUsUsd"></a> NetPaymentUsUsd

```csharp
public ulong NetPaymentUsUsd { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_Parser"></a> Parser

```csharp
public static MessageParser<CWorkshop_GetSpecialPayments_Response.Types.SpecialPayment> Parser { get; }
```

#### Property Value

 MessageParser<[CWorkshop\_GetSpecialPayments\_Response](Divine.Protobufs.Steam.CWorkshop\_GetSpecialPayments\_Response.md).[Types](Divine.Protobufs.Steam.CWorkshop\_GetSpecialPayments\_Response.Types.md).[SpecialPayment](Divine.Protobufs.Steam.CWorkshop\_GetSpecialPayments\_Response.Types.SpecialPayment.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_ClearDate"></a> ClearDate\(\)

```csharp
public void ClearDate()
```

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_ClearGameitemid"></a> ClearGameitemid\(\)

```csharp
public void ClearGameitemid()
```

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_ClearNetPaymentRowUsd"></a> ClearNetPaymentRowUsd\(\)

```csharp
public void ClearNetPaymentRowUsd()
```

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_ClearNetPaymentUsUsd"></a> ClearNetPaymentUsUsd\(\)

```csharp
public void ClearNetPaymentUsUsd()
```

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_Clone"></a> Clone\(\)

```csharp
public CWorkshop_GetSpecialPayments_Response.Types.SpecialPayment Clone()
```

#### Returns

 [CWorkshop\_GetSpecialPayments\_Response](Divine.Protobufs.Steam.CWorkshop\_GetSpecialPayments\_Response.md).[Types](Divine.Protobufs.Steam.CWorkshop\_GetSpecialPayments\_Response.Types.md).[SpecialPayment](Divine.Protobufs.Steam.CWorkshop\_GetSpecialPayments\_Response.Types.SpecialPayment.md)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_Equals_Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_"></a> Equals\(SpecialPayment\)

```csharp
public bool Equals(CWorkshop_GetSpecialPayments_Response.Types.SpecialPayment other)
```

#### Parameters

`other` [CWorkshop\_GetSpecialPayments\_Response](Divine.Protobufs.Steam.CWorkshop\_GetSpecialPayments\_Response.md).[Types](Divine.Protobufs.Steam.CWorkshop\_GetSpecialPayments\_Response.Types.md).[SpecialPayment](Divine.Protobufs.Steam.CWorkshop\_GetSpecialPayments\_Response.Types.SpecialPayment.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_MergeFrom_Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_"></a> MergeFrom\(SpecialPayment\)

```csharp
public void MergeFrom(CWorkshop_GetSpecialPayments_Response.Types.SpecialPayment other)
```

#### Parameters

`other` [CWorkshop\_GetSpecialPayments\_Response](Divine.Protobufs.Steam.CWorkshop\_GetSpecialPayments\_Response.md).[Types](Divine.Protobufs.Steam.CWorkshop\_GetSpecialPayments\_Response.Types.md).[SpecialPayment](Divine.Protobufs.Steam.CWorkshop\_GetSpecialPayments\_Response.Types.SpecialPayment.md)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CWorkshop_GetSpecialPayments_Response_Types_SpecialPayment_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

