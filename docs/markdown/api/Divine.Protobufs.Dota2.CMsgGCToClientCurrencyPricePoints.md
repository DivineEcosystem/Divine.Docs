# <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints"></a> Class CMsgGCToClientCurrencyPricePoints

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientCurrencyPricePoints : IMessage<CMsgGCToClientCurrencyPricePoints>, IEquatable<CMsgGCToClientCurrencyPricePoints>, IDeepCloneable<CMsgGCToClientCurrencyPricePoints>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientCurrencyPricePoints](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.md)

#### Implements

IMessage<CMsgGCToClientCurrencyPricePoints\>, 
[IEquatable<CMsgGCToClientCurrencyPricePoints\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientCurrencyPricePoints\>, 
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
[EnumerableExtensions.In<CMsgGCToClientCurrencyPricePoints\>\(CMsgGCToClientCurrencyPricePoints, params CMsgGCToClientCurrencyPricePoints\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints__ctor"></a> CMsgGCToClientCurrencyPricePoints\(\)

```csharp
public CMsgGCToClientCurrencyPricePoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints__ctor_Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_"></a> CMsgGCToClientCurrencyPricePoints\(CMsgGCToClientCurrencyPricePoints\)

```csharp
public CMsgGCToClientCurrencyPricePoints(CMsgGCToClientCurrencyPricePoints other)
```

#### Parameters

`other` [CMsgGCToClientCurrencyPricePoints](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_CurrenciesFieldNumber"></a> CurrenciesFieldNumber

```csharp
public const int CurrenciesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_PriceKeyFieldNumber"></a> PriceKeyFieldNumber

```csharp
public const int PriceKeyFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Currencies"></a> Currencies

```csharp
public RepeatedField<CMsgGCToClientCurrencyPricePoints.Types.Currency> Currencies { get; }
```

#### Property Value

 RepeatedField<[CMsgGCToClientCurrencyPricePoints](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.Types.md).[Currency](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.Types.Currency.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientCurrencyPricePoints> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientCurrencyPricePoints](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_PriceKey"></a> PriceKey

```csharp
public RepeatedField<ulong> PriceKey { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientCurrencyPricePoints Clone()
```

#### Returns

 [CMsgGCToClientCurrencyPricePoints](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_Equals_Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_"></a> Equals\(CMsgGCToClientCurrencyPricePoints\)

```csharp
public bool Equals(CMsgGCToClientCurrencyPricePoints other)
```

#### Parameters

`other` [CMsgGCToClientCurrencyPricePoints](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_"></a> MergeFrom\(CMsgGCToClientCurrencyPricePoints\)

```csharp
public void MergeFrom(CMsgGCToClientCurrencyPricePoints other)
```

#### Parameters

`other` [CMsgGCToClientCurrencyPricePoints](Divine.Protobufs.Dota2.CMsgGCToClientCurrencyPricePoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCurrencyPricePoints_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

