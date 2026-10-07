# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem"></a> Class CDOTAUserMsg\_CourierKilledAlert.Types.LostItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_CourierKilledAlert.Types.LostItem : IMessage<CDOTAUserMsg_CourierKilledAlert.Types.LostItem>, IEquatable<CDOTAUserMsg_CourierKilledAlert.Types.LostItem>, IDeepCloneable<CDOTAUserMsg_CourierKilledAlert.Types.LostItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_CourierKilledAlert.Types.LostItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.Types.LostItem.md)

#### Implements

IMessage<CDOTAUserMsg\_CourierKilledAlert.Types.LostItem\>, 
[IEquatable<CDOTAUserMsg\_CourierKilledAlert.Types.LostItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_CourierKilledAlert.Types.LostItem\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_CourierKilledAlert.Types.LostItem\>\(CDOTAUserMsg\_CourierKilledAlert.Types.LostItem, params CDOTAUserMsg\_CourierKilledAlert.Types.LostItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem__ctor"></a> LostItem\(\)

```csharp
public LostItem()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_"></a> LostItem\(LostItem\)

```csharp
public LostItem(CDOTAUserMsg_CourierKilledAlert.Types.LostItem other)
```

#### Parameters

`other` [CDOTAUserMsg\_CourierKilledAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.Types.md).[LostItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.Types.LostItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_ItemAbilityIdFieldNumber"></a> ItemAbilityIdFieldNumber

```csharp
public const int ItemAbilityIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_QuantityFieldNumber"></a> QuantityFieldNumber

```csharp
public const int QuantityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_HasItemAbilityId"></a> HasItemAbilityId

```csharp
public bool HasItemAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_HasQuantity"></a> HasQuantity

```csharp
public bool HasQuantity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_ItemAbilityId"></a> ItemAbilityId

```csharp
public int ItemAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_CourierKilledAlert.Types.LostItem> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_CourierKilledAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.Types.md).[LostItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.Types.LostItem.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_Quantity"></a> Quantity

```csharp
public uint Quantity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_ClearItemAbilityId"></a> ClearItemAbilityId\(\)

```csharp
public void ClearItemAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_ClearQuantity"></a> ClearQuantity\(\)

```csharp
public void ClearQuantity()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_CourierKilledAlert.Types.LostItem Clone()
```

#### Returns

 [CDOTAUserMsg\_CourierKilledAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.Types.md).[LostItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.Types.LostItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_"></a> Equals\(LostItem\)

```csharp
public bool Equals(CDOTAUserMsg_CourierKilledAlert.Types.LostItem other)
```

#### Parameters

`other` [CDOTAUserMsg\_CourierKilledAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.Types.md).[LostItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.Types.LostItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_"></a> MergeFrom\(LostItem\)

```csharp
public void MergeFrom(CDOTAUserMsg_CourierKilledAlert.Types.LostItem other)
```

#### Parameters

`other` [CDOTAUserMsg\_CourierKilledAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.Types.md).[LostItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.Types.LostItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Types_LostItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

