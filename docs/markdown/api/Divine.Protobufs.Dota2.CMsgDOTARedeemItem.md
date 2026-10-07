# <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem"></a> Class CMsgDOTARedeemItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARedeemItem : IMessage<CMsgDOTARedeemItem>, IEquatable<CMsgDOTARedeemItem>, IDeepCloneable<CMsgDOTARedeemItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARedeemItem](Divine.Protobufs.Dota2.CMsgDOTARedeemItem.md)

#### Implements

IMessage<CMsgDOTARedeemItem\>, 
[IEquatable<CMsgDOTARedeemItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARedeemItem\>, 
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
[EnumerableExtensions.In<CMsgDOTARedeemItem\>\(CMsgDOTARedeemItem, params CMsgDOTARedeemItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem__ctor"></a> CMsgDOTARedeemItem\(\)

```csharp
public CMsgDOTARedeemItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem__ctor_Divine_Protobufs_Dota2_CMsgDOTARedeemItem_"></a> CMsgDOTARedeemItem\(CMsgDOTARedeemItem\)

```csharp
public CMsgDOTARedeemItem(CMsgDOTARedeemItem other)
```

#### Parameters

`other` [CMsgDOTARedeemItem](Divine.Protobufs.Dota2.CMsgDOTARedeemItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_ClaimAsPointsFieldNumber"></a> ClaimAsPointsFieldNumber

```csharp
public const int ClaimAsPointsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_CurrencyIdFieldNumber"></a> CurrencyIdFieldNumber

```csharp
public const int CurrencyIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_PurchaseDefFieldNumber"></a> PurchaseDefFieldNumber

```csharp
public const int PurchaseDefFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_ClaimAsPoints"></a> ClaimAsPoints

```csharp
public bool ClaimAsPoints { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_CurrencyId"></a> CurrencyId

```csharp
public ulong CurrencyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_HasClaimAsPoints"></a> HasClaimAsPoints

```csharp
public bool HasClaimAsPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_HasCurrencyId"></a> HasCurrencyId

```csharp
public bool HasCurrencyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_HasPurchaseDef"></a> HasPurchaseDef

```csharp
public bool HasPurchaseDef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARedeemItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARedeemItem](Divine.Protobufs.Dota2.CMsgDOTARedeemItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_PurchaseDef"></a> PurchaseDef

```csharp
public uint PurchaseDef { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_ClearClaimAsPoints"></a> ClearClaimAsPoints\(\)

```csharp
public void ClearClaimAsPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_ClearCurrencyId"></a> ClearCurrencyId\(\)

```csharp
public void ClearCurrencyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_ClearPurchaseDef"></a> ClearPurchaseDef\(\)

```csharp
public void ClearPurchaseDef()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARedeemItem Clone()
```

#### Returns

 [CMsgDOTARedeemItem](Divine.Protobufs.Dota2.CMsgDOTARedeemItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_Equals_Divine_Protobufs_Dota2_CMsgDOTARedeemItem_"></a> Equals\(CMsgDOTARedeemItem\)

```csharp
public bool Equals(CMsgDOTARedeemItem other)
```

#### Parameters

`other` [CMsgDOTARedeemItem](Divine.Protobufs.Dota2.CMsgDOTARedeemItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARedeemItem_"></a> MergeFrom\(CMsgDOTARedeemItem\)

```csharp
public void MergeFrom(CMsgDOTARedeemItem other)
```

#### Parameters

`other` [CMsgDOTARedeemItem](Divine.Protobufs.Dota2.CMsgDOTARedeemItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

