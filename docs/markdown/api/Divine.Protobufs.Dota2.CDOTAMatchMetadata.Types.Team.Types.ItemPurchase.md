# <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase"></a> Class CDOTAMatchMetadata.Types.Team.Types.ItemPurchase

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMatchMetadata.Types.Team.Types.ItemPurchase : IMessage<CDOTAMatchMetadata.Types.Team.Types.ItemPurchase>, IEquatable<CDOTAMatchMetadata.Types.Team.Types.ItemPurchase>, IDeepCloneable<CDOTAMatchMetadata.Types.Team.Types.ItemPurchase>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMatchMetadata.Types.Team.Types.ItemPurchase](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.ItemPurchase.md)

#### Implements

IMessage<CDOTAMatchMetadata.Types.Team.Types.ItemPurchase\>, 
[IEquatable<CDOTAMatchMetadata.Types.Team.Types.ItemPurchase\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMatchMetadata.Types.Team.Types.ItemPurchase\>, 
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
[EnumerableExtensions.In<CDOTAMatchMetadata.Types.Team.Types.ItemPurchase\>\(CDOTAMatchMetadata.Types.Team.Types.ItemPurchase, params CDOTAMatchMetadata.Types.Team.Types.ItemPurchase\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase__ctor"></a> ItemPurchase\(\)

```csharp
public ItemPurchase()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase__ctor_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_"></a> ItemPurchase\(ItemPurchase\)

```csharp
public ItemPurchase(CDOTAMatchMetadata.Types.Team.Types.ItemPurchase other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[ItemPurchase](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.ItemPurchase.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_PurchaseTimeFieldNumber"></a> PurchaseTimeFieldNumber

```csharp
public const int PurchaseTimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_HasPurchaseTime"></a> HasPurchaseTime

```csharp
public bool HasPurchaseTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_ItemId"></a> ItemId

```csharp
public int ItemId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMatchMetadata.Types.Team.Types.ItemPurchase> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[ItemPurchase](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.ItemPurchase.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_PurchaseTime"></a> PurchaseTime

```csharp
public int PurchaseTime { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_ClearPurchaseTime"></a> ClearPurchaseTime\(\)

```csharp
public void ClearPurchaseTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_Clone"></a> Clone\(\)

```csharp
public CDOTAMatchMetadata.Types.Team.Types.ItemPurchase Clone()
```

#### Returns

 [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[ItemPurchase](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.ItemPurchase.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_Equals_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_"></a> Equals\(ItemPurchase\)

```csharp
public bool Equals(CDOTAMatchMetadata.Types.Team.Types.ItemPurchase other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[ItemPurchase](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.ItemPurchase.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_MergeFrom_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_"></a> MergeFrom\(ItemPurchase\)

```csharp
public void MergeFrom(CDOTAMatchMetadata.Types.Team.Types.ItemPurchase other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[ItemPurchase](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.ItemPurchase.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_ItemPurchase_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

