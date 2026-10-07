# <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem"></a> Class CMsgClientToGCClaimEventActionUsingItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCClaimEventActionUsingItem : IMessage<CMsgClientToGCClaimEventActionUsingItem>, IEquatable<CMsgClientToGCClaimEventActionUsingItem>, IDeepCloneable<CMsgClientToGCClaimEventActionUsingItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCClaimEventActionUsingItem](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventActionUsingItem.md)

#### Implements

IMessage<CMsgClientToGCClaimEventActionUsingItem\>, 
[IEquatable<CMsgClientToGCClaimEventActionUsingItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCClaimEventActionUsingItem\>, 
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
[EnumerableExtensions.In<CMsgClientToGCClaimEventActionUsingItem\>\(CMsgClientToGCClaimEventActionUsingItem, params CMsgClientToGCClaimEventActionUsingItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem__ctor"></a> CMsgClientToGCClaimEventActionUsingItem\(\)

```csharp
public CMsgClientToGCClaimEventActionUsingItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem__ctor_Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_"></a> CMsgClientToGCClaimEventActionUsingItem\(CMsgClientToGCClaimEventActionUsingItem\)

```csharp
public CMsgClientToGCClaimEventActionUsingItem(CMsgClientToGCClaimEventActionUsingItem other)
```

#### Parameters

`other` [CMsgClientToGCClaimEventActionUsingItem](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventActionUsingItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_ActionIdFieldNumber"></a> ActionIdFieldNumber

```csharp
public const int ActionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_QuantityFieldNumber"></a> QuantityFieldNumber

```csharp
public const int QuantityFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_SuppressRewardsFieldNumber"></a> SuppressRewardsFieldNumber

```csharp
public const int SuppressRewardsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_ActionId"></a> ActionId

```csharp
public uint ActionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_HasActionId"></a> HasActionId

```csharp
public bool HasActionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_HasQuantity"></a> HasQuantity

```csharp
public bool HasQuantity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_HasSuppressRewards"></a> HasSuppressRewards

```csharp
public bool HasSuppressRewards { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCClaimEventActionUsingItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCClaimEventActionUsingItem](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventActionUsingItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_Quantity"></a> Quantity

```csharp
public uint Quantity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_SuppressRewards"></a> SuppressRewards

```csharp
public bool SuppressRewards { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_ClearActionId"></a> ClearActionId\(\)

```csharp
public void ClearActionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_ClearQuantity"></a> ClearQuantity\(\)

```csharp
public void ClearQuantity()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_ClearSuppressRewards"></a> ClearSuppressRewards\(\)

```csharp
public void ClearSuppressRewards()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCClaimEventActionUsingItem Clone()
```

#### Returns

 [CMsgClientToGCClaimEventActionUsingItem](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventActionUsingItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_Equals_Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_"></a> Equals\(CMsgClientToGCClaimEventActionUsingItem\)

```csharp
public bool Equals(CMsgClientToGCClaimEventActionUsingItem other)
```

#### Parameters

`other` [CMsgClientToGCClaimEventActionUsingItem](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventActionUsingItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_"></a> MergeFrom\(CMsgClientToGCClaimEventActionUsingItem\)

```csharp
public void MergeFrom(CMsgClientToGCClaimEventActionUsingItem other)
```

#### Parameters

`other` [CMsgClientToGCClaimEventActionUsingItem](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventActionUsingItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionUsingItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

