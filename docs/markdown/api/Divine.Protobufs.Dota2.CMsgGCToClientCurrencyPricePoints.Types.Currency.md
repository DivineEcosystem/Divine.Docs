# <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency"></a> Class CMsgGCToClientCurrencyPricePoints.Types.Currency

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientCurrencyPricePoints.Types.Currency : IMessage<CMsgGCToClientCurrencyPricePoints.Types.Currency>, IEquatable<CMsgGCToClientCurrencyPricePoints.Types.Currency>, IDeepCloneable<CMsgGCToClientCurrencyPricePoints.Types.Currency>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientCurrencyPricePoints.Types.Currency](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.Types.Currency.md)

#### Implements

IMessage<CMsgGCToClientCurrencyPricePoints.Types.Currency\>, 
[IEquatable<CMsgGCToClientCurrencyPricePoints.Types.Currency\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientCurrencyPricePoints.Types.Currency\>, 
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
[EnumerableExtensions.In<CMsgGCToClientCurrencyPricePoints.Types.Currency\>\(CMsgGCToClientCurrencyPricePoints.Types.Currency, params CMsgGCToClientCurrencyPricePoints.Types.Currency\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency__ctor"></a> Currency\(\)

```csharp
public Currency()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency__ctor_Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_"></a> Currency\(Currency\)

```csharp
public Currency(CMsgGCToClientCurrencyPricePoints.Types.Currency other)
```

#### Parameters

`other` [CMsgGCToClientCurrencyPricePoints](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.Types.md).[Currency](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.Types.Currency.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_CurrencyIdFieldNumber"></a> CurrencyIdFieldNumber

```csharp
public const int CurrencyIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_CurrencyPriceFieldNumber"></a> CurrencyPriceFieldNumber

```csharp
public const int CurrencyPriceFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_CurrencyId"></a> CurrencyId

```csharp
public uint CurrencyId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_CurrencyPrice"></a> CurrencyPrice

```csharp
public RepeatedField<ulong> CurrencyPrice { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_HasCurrencyId"></a> HasCurrencyId

```csharp
public bool HasCurrencyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientCurrencyPricePoints.Types.Currency> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientCurrencyPricePoints](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.Types.md).[Currency](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.Types.Currency.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_ClearCurrencyId"></a> ClearCurrencyId\(\)

```csharp
public void ClearCurrencyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientCurrencyPricePoints.Types.Currency Clone()
```

#### Returns

 [CMsgGCToClientCurrencyPricePoints](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.Types.md).[Currency](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.Types.Currency.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_Equals_Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_"></a> Equals\(Currency\)

```csharp
public bool Equals(CMsgGCToClientCurrencyPricePoints.Types.Currency other)
```

#### Parameters

`other` [CMsgGCToClientCurrencyPricePoints](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.Types.md).[Currency](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.Types.Currency.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_"></a> MergeFrom\(Currency\)

```csharp
public void MergeFrom(CMsgGCToClientCurrencyPricePoints.Types.Currency other)
```

#### Parameters

`other` [CMsgGCToClientCurrencyPricePoints](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.Types.md).[Currency](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.Types.Currency.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Types_Currency_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

