# <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged"></a> Class CMsgItemAcknowledged

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgItemAcknowledged : IMessage<CMsgItemAcknowledged>, IEquatable<CMsgItemAcknowledged>, IDeepCloneable<CMsgItemAcknowledged>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgItemAcknowledged](Divine.Protobufs.Dota2.CMsgItemAcknowledged.md)

#### Implements

IMessage<CMsgItemAcknowledged\>, 
[IEquatable<CMsgItemAcknowledged\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgItemAcknowledged\>, 
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
[EnumerableExtensions.In<CMsgItemAcknowledged\>\(CMsgItemAcknowledged, params CMsgItemAcknowledged\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged__ctor"></a> CMsgItemAcknowledged\(\)

```csharp
public CMsgItemAcknowledged()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged__ctor_Divine_Protobufs_Dota2_CMsgItemAcknowledged_"></a> CMsgItemAcknowledged\(CMsgItemAcknowledged\)

```csharp
public CMsgItemAcknowledged(CMsgItemAcknowledged other)
```

#### Parameters

`other` [CMsgItemAcknowledged](Divine.Protobufs.Dota2.CMsgItemAcknowledged.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_DefIndexFieldNumber"></a> DefIndexFieldNumber

```csharp
public const int DefIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_InventoryFieldNumber"></a> InventoryFieldNumber

```csharp
public const int InventoryFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_OriginFieldNumber"></a> OriginFieldNumber

```csharp
public const int OriginFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_QualityFieldNumber"></a> QualityFieldNumber

```csharp
public const int QualityFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_RarityFieldNumber"></a> RarityFieldNumber

```csharp
public const int RarityFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_DefIndex"></a> DefIndex

```csharp
public uint DefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_HasDefIndex"></a> HasDefIndex

```csharp
public bool HasDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_HasInventory"></a> HasInventory

```csharp
public bool HasInventory { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_HasOrigin"></a> HasOrigin

```csharp
public bool HasOrigin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_HasQuality"></a> HasQuality

```csharp
public bool HasQuality { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_HasRarity"></a> HasRarity

```csharp
public bool HasRarity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_Inventory"></a> Inventory

```csharp
public uint Inventory { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_Origin"></a> Origin

```csharp
public uint Origin { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_Parser"></a> Parser

```csharp
public static MessageParser<CMsgItemAcknowledged> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgItemAcknowledged](Divine.Protobufs.Dota2.CMsgItemAcknowledged.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_Quality"></a> Quality

```csharp
public uint Quality { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_Rarity"></a> Rarity

```csharp
public uint Rarity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_ClearDefIndex"></a> ClearDefIndex\(\)

```csharp
public void ClearDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_ClearInventory"></a> ClearInventory\(\)

```csharp
public void ClearInventory()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_ClearOrigin"></a> ClearOrigin\(\)

```csharp
public void ClearOrigin()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_ClearQuality"></a> ClearQuality\(\)

```csharp
public void ClearQuality()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_ClearRarity"></a> ClearRarity\(\)

```csharp
public void ClearRarity()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_Clone"></a> Clone\(\)

```csharp
public CMsgItemAcknowledged Clone()
```

#### Returns

 [CMsgItemAcknowledged](Divine.Protobufs.Dota2.CMsgItemAcknowledged.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_Equals_Divine_Protobufs_Dota2_CMsgItemAcknowledged_"></a> Equals\(CMsgItemAcknowledged\)

```csharp
public bool Equals(CMsgItemAcknowledged other)
```

#### Parameters

`other` [CMsgItemAcknowledged](Divine.Protobufs.Dota2.CMsgItemAcknowledged.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_MergeFrom_Divine_Protobufs_Dota2_CMsgItemAcknowledged_"></a> MergeFrom\(CMsgItemAcknowledged\)

```csharp
public void MergeFrom(CMsgItemAcknowledged other)
```

#### Parameters

`other` [CMsgItemAcknowledged](Divine.Protobufs.Dota2.CMsgItemAcknowledged.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgItemAcknowledged_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

