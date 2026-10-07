# <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems"></a> Class CMsgClientToGCPurchaseChargeCostItems

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCPurchaseChargeCostItems : IMessage<CMsgClientToGCPurchaseChargeCostItems>, IEquatable<CMsgClientToGCPurchaseChargeCostItems>, IDeepCloneable<CMsgClientToGCPurchaseChargeCostItems>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCPurchaseChargeCostItems](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.md)

#### Implements

IMessage<CMsgClientToGCPurchaseChargeCostItems\>, 
[IEquatable<CMsgClientToGCPurchaseChargeCostItems\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCPurchaseChargeCostItems\>, 
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
[EnumerableExtensions.In<CMsgClientToGCPurchaseChargeCostItems\>\(CMsgClientToGCPurchaseChargeCostItems, params CMsgClientToGCPurchaseChargeCostItems\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems__ctor"></a> CMsgClientToGCPurchaseChargeCostItems\(\)

```csharp
public CMsgClientToGCPurchaseChargeCostItems()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems__ctor_Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_"></a> CMsgClientToGCPurchaseChargeCostItems\(CMsgClientToGCPurchaseChargeCostItems\)

```csharp
public CMsgClientToGCPurchaseChargeCostItems(CMsgClientToGCPurchaseChargeCostItems other)
```

#### Parameters

`other` [CMsgClientToGCPurchaseChargeCostItems](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_CurrencyFieldNumber"></a> CurrencyFieldNumber

```csharp
public const int CurrencyFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_ItemsFieldNumber"></a> ItemsFieldNumber

```csharp
public const int ItemsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Currency"></a> Currency

```csharp
public uint Currency { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_HasCurrency"></a> HasCurrency

```csharp
public bool HasCurrency { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Items"></a> Items

```csharp
public RepeatedField<CMsgClientToGCPurchaseChargeCostItems.Types.Item> Items { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCPurchaseChargeCostItems](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.Types.md).[Item](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.Types.Item.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCPurchaseChargeCostItems> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCPurchaseChargeCostItems](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_ClearCurrency"></a> ClearCurrency\(\)

```csharp
public void ClearCurrency()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCPurchaseChargeCostItems Clone()
```

#### Returns

 [CMsgClientToGCPurchaseChargeCostItems](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_Equals_Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_"></a> Equals\(CMsgClientToGCPurchaseChargeCostItems\)

```csharp
public bool Equals(CMsgClientToGCPurchaseChargeCostItems other)
```

#### Parameters

`other` [CMsgClientToGCPurchaseChargeCostItems](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_"></a> MergeFrom\(CMsgClientToGCPurchaseChargeCostItems\)

```csharp
public void MergeFrom(CMsgClientToGCPurchaseChargeCostItems other)
```

#### Parameters

`other` [CMsgClientToGCPurchaseChargeCostItems](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseChargeCostItems.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseChargeCostItems_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

