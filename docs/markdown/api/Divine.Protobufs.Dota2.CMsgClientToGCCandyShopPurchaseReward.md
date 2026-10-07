# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward"></a> Class CMsgClientToGCCandyShopPurchaseReward

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCandyShopPurchaseReward : IMessage<CMsgClientToGCCandyShopPurchaseReward>, IEquatable<CMsgClientToGCCandyShopPurchaseReward>, IDeepCloneable<CMsgClientToGCCandyShopPurchaseReward>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCandyShopPurchaseReward](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopPurchaseReward.md)

#### Implements

IMessage<CMsgClientToGCCandyShopPurchaseReward\>, 
[IEquatable<CMsgClientToGCCandyShopPurchaseReward\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCandyShopPurchaseReward\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCandyShopPurchaseReward\>\(CMsgClientToGCCandyShopPurchaseReward, params CMsgClientToGCCandyShopPurchaseReward\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward__ctor"></a> CMsgClientToGCCandyShopPurchaseReward\(\)

```csharp
public CMsgClientToGCCandyShopPurchaseReward()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_"></a> CMsgClientToGCCandyShopPurchaseReward\(CMsgClientToGCCandyShopPurchaseReward\)

```csharp
public CMsgClientToGCCandyShopPurchaseReward(CMsgClientToGCCandyShopPurchaseReward other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopPurchaseReward](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopPurchaseReward.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_CandyShopIdFieldNumber"></a> CandyShopIdFieldNumber

```csharp
public const int CandyShopIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_RewardIdFieldNumber"></a> RewardIdFieldNumber

```csharp
public const int RewardIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_CandyShopId"></a> CandyShopId

```csharp
public uint CandyShopId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_HasCandyShopId"></a> HasCandyShopId

```csharp
public bool HasCandyShopId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_HasRewardId"></a> HasRewardId

```csharp
public bool HasRewardId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCandyShopPurchaseReward> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCandyShopPurchaseReward](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopPurchaseReward.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_RewardId"></a> RewardId

```csharp
public ulong RewardId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_ClearCandyShopId"></a> ClearCandyShopId\(\)

```csharp
public void ClearCandyShopId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_ClearRewardId"></a> ClearRewardId\(\)

```csharp
public void ClearRewardId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCandyShopPurchaseReward Clone()
```

#### Returns

 [CMsgClientToGCCandyShopPurchaseReward](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopPurchaseReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_"></a> Equals\(CMsgClientToGCCandyShopPurchaseReward\)

```csharp
public bool Equals(CMsgClientToGCCandyShopPurchaseReward other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopPurchaseReward](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopPurchaseReward.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_"></a> MergeFrom\(CMsgClientToGCCandyShopPurchaseReward\)

```csharp
public void MergeFrom(CMsgClientToGCCandyShopPurchaseReward other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopPurchaseReward](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopPurchaseReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopPurchaseReward_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

