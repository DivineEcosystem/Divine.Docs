# <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints"></a> Class CMsgPurchaseItemWithEventPoints

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPurchaseItemWithEventPoints : IMessage<CMsgPurchaseItemWithEventPoints>, IEquatable<CMsgPurchaseItemWithEventPoints>, IDeepCloneable<CMsgPurchaseItemWithEventPoints>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPurchaseItemWithEventPoints](Divine.Protobufs.Dota2.CMsgPurchaseItemWithEventPoints.md)

#### Implements

IMessage<CMsgPurchaseItemWithEventPoints\>, 
[IEquatable<CMsgPurchaseItemWithEventPoints\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPurchaseItemWithEventPoints\>, 
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
[EnumerableExtensions.In<CMsgPurchaseItemWithEventPoints\>\(CMsgPurchaseItemWithEventPoints, params CMsgPurchaseItemWithEventPoints\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints__ctor"></a> CMsgPurchaseItemWithEventPoints\(\)

```csharp
public CMsgPurchaseItemWithEventPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints__ctor_Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_"></a> CMsgPurchaseItemWithEventPoints\(CMsgPurchaseItemWithEventPoints\)

```csharp
public CMsgPurchaseItemWithEventPoints(CMsgPurchaseItemWithEventPoints other)
```

#### Parameters

`other` [CMsgPurchaseItemWithEventPoints](Divine.Protobufs.Dota2.CMsgPurchaseItemWithEventPoints.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_ItemDefFieldNumber"></a> ItemDefFieldNumber

```csharp
public const int ItemDefFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_QuantityFieldNumber"></a> QuantityFieldNumber

```csharp
public const int QuantityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_UsePremiumPointsFieldNumber"></a> UsePremiumPointsFieldNumber

```csharp
public const int UsePremiumPointsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_HasItemDef"></a> HasItemDef

```csharp
public bool HasItemDef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_HasQuantity"></a> HasQuantity

```csharp
public bool HasQuantity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_HasUsePremiumPoints"></a> HasUsePremiumPoints

```csharp
public bool HasUsePremiumPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_ItemDef"></a> ItemDef

```csharp
public uint ItemDef { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPurchaseItemWithEventPoints> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPurchaseItemWithEventPoints](Divine.Protobufs.Dota2.CMsgPurchaseItemWithEventPoints.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_Quantity"></a> Quantity

```csharp
public uint Quantity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_UsePremiumPoints"></a> UsePremiumPoints

```csharp
public bool UsePremiumPoints { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_ClearItemDef"></a> ClearItemDef\(\)

```csharp
public void ClearItemDef()
```

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_ClearQuantity"></a> ClearQuantity\(\)

```csharp
public void ClearQuantity()
```

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_ClearUsePremiumPoints"></a> ClearUsePremiumPoints\(\)

```csharp
public void ClearUsePremiumPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_Clone"></a> Clone\(\)

```csharp
public CMsgPurchaseItemWithEventPoints Clone()
```

#### Returns

 [CMsgPurchaseItemWithEventPoints](Divine.Protobufs.Dota2.CMsgPurchaseItemWithEventPoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_Equals_Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_"></a> Equals\(CMsgPurchaseItemWithEventPoints\)

```csharp
public bool Equals(CMsgPurchaseItemWithEventPoints other)
```

#### Parameters

`other` [CMsgPurchaseItemWithEventPoints](Divine.Protobufs.Dota2.CMsgPurchaseItemWithEventPoints.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_MergeFrom_Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_"></a> MergeFrom\(CMsgPurchaseItemWithEventPoints\)

```csharp
public void MergeFrom(CMsgPurchaseItemWithEventPoints other)
```

#### Parameters

`other` [CMsgPurchaseItemWithEventPoints](Divine.Protobufs.Dota2.CMsgPurchaseItemWithEventPoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPoints_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

