# <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward"></a> Class CMsgCandyShopReward

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgCandyShopReward : IMessage<CMsgCandyShopReward>, IEquatable<CMsgCandyShopReward>, IDeepCloneable<CMsgCandyShopReward>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgCandyShopReward](Divine.Protobufs.Dota2.CMsgCandyShopReward.md)

#### Implements

IMessage<CMsgCandyShopReward\>, 
[IEquatable<CMsgCandyShopReward\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgCandyShopReward\>, 
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
[EnumerableExtensions.In<CMsgCandyShopReward\>\(CMsgCandyShopReward, params CMsgCandyShopReward\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward__ctor"></a> CMsgCandyShopReward\(\)

```csharp
public CMsgCandyShopReward()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward__ctor_Divine_Protobufs_Dota2_CMsgCandyShopReward_"></a> CMsgCandyShopReward\(CMsgCandyShopReward\)

```csharp
public CMsgCandyShopReward(CMsgCandyShopReward other)
```

#### Parameters

`other` [CMsgCandyShopReward](Divine.Protobufs.Dota2.CMsgCandyShopReward.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_EventActionDataFieldNumber"></a> EventActionDataFieldNumber

```csharp
public const int EventActionDataFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_EventPointsDataFieldNumber"></a> EventPointsDataFieldNumber

```csharp
public const int EventPointsDataFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_ItemDataFieldNumber"></a> ItemDataFieldNumber

```csharp
public const int ItemDataFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_PriceFieldNumber"></a> PriceFieldNumber

```csharp
public const int PriceFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_RewardIdFieldNumber"></a> RewardIdFieldNumber

```csharp
public const int RewardIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_RewardOptionIdFieldNumber"></a> RewardOptionIdFieldNumber

```csharp
public const int RewardOptionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_RewardTypeFieldNumber"></a> RewardTypeFieldNumber

```csharp
public const int RewardTypeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_EventActionData"></a> EventActionData

```csharp
public CMsgCandyShopRewardData_EventAction EventActionData { get; set; }
```

#### Property Value

 [CMsgCandyShopRewardData\_EventAction](Divine.Protobufs.Dota2.CMsgCandyShopRewardData\_EventAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_EventPointsData"></a> EventPointsData

```csharp
public CMsgCandyShopRewardData_EventPoints EventPointsData { get; set; }
```

#### Property Value

 [CMsgCandyShopRewardData\_EventPoints](Divine.Protobufs.Dota2.CMsgCandyShopRewardData\_EventPoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_HasRewardId"></a> HasRewardId

```csharp
public bool HasRewardId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_HasRewardOptionId"></a> HasRewardOptionId

```csharp
public bool HasRewardOptionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_HasRewardType"></a> HasRewardType

```csharp
public bool HasRewardType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_ItemData"></a> ItemData

```csharp
public CMsgCandyShopRewardData_Item ItemData { get; set; }
```

#### Property Value

 [CMsgCandyShopRewardData\_Item](Divine.Protobufs.Dota2.CMsgCandyShopRewardData\_Item.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_Parser"></a> Parser

```csharp
public static MessageParser<CMsgCandyShopReward> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgCandyShopReward](Divine.Protobufs.Dota2.CMsgCandyShopReward.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_Price"></a> Price

```csharp
public CMsgCandyShopCandyQuantity Price { get; set; }
```

#### Property Value

 [CMsgCandyShopCandyQuantity](Divine.Protobufs.Dota2.CMsgCandyShopCandyQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_RewardId"></a> RewardId

```csharp
public uint RewardId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_RewardOptionId"></a> RewardOptionId

```csharp
public uint RewardOptionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_RewardType"></a> RewardType

```csharp
public ECandyShopRewardType RewardType { get; set; }
```

#### Property Value

 [ECandyShopRewardType](Divine.Protobufs.Dota2.ECandyShopRewardType.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_ClearRewardId"></a> ClearRewardId\(\)

```csharp
public void ClearRewardId()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_ClearRewardOptionId"></a> ClearRewardOptionId\(\)

```csharp
public void ClearRewardOptionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_ClearRewardType"></a> ClearRewardType\(\)

```csharp
public void ClearRewardType()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_Clone"></a> Clone\(\)

```csharp
public CMsgCandyShopReward Clone()
```

#### Returns

 [CMsgCandyShopReward](Divine.Protobufs.Dota2.CMsgCandyShopReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_Equals_Divine_Protobufs_Dota2_CMsgCandyShopReward_"></a> Equals\(CMsgCandyShopReward\)

```csharp
public bool Equals(CMsgCandyShopReward other)
```

#### Parameters

`other` [CMsgCandyShopReward](Divine.Protobufs.Dota2.CMsgCandyShopReward.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_MergeFrom_Divine_Protobufs_Dota2_CMsgCandyShopReward_"></a> MergeFrom\(CMsgCandyShopReward\)

```csharp
public void MergeFrom(CMsgCandyShopReward other)
```

#### Parameters

`other` [CMsgCandyShopReward](Divine.Protobufs.Dota2.CMsgCandyShopReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopReward_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

