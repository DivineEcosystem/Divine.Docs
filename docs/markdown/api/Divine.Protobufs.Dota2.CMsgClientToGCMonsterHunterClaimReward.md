# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward"></a> Class CMsgClientToGCMonsterHunterClaimReward

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterClaimReward : IMessage<CMsgClientToGCMonsterHunterClaimReward>, IEquatable<CMsgClientToGCMonsterHunterClaimReward>, IDeepCloneable<CMsgClientToGCMonsterHunterClaimReward>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterClaimReward](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimReward.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterClaimReward\>, 
[IEquatable<CMsgClientToGCMonsterHunterClaimReward\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterClaimReward\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterClaimReward\>\(CMsgClientToGCMonsterHunterClaimReward, params CMsgClientToGCMonsterHunterClaimReward\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward__ctor"></a> CMsgClientToGCMonsterHunterClaimReward\(\)

```csharp
public CMsgClientToGCMonsterHunterClaimReward()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_"></a> CMsgClientToGCMonsterHunterClaimReward\(CMsgClientToGCMonsterHunterClaimReward\)

```csharp
public CMsgClientToGCMonsterHunterClaimReward(CMsgClientToGCMonsterHunterClaimReward other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterClaimReward](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimReward.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_HunterRankRewardFieldNumber"></a> HunterRankRewardFieldNumber

```csharp
public const int HunterRankRewardFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_HasHunterRankReward"></a> HasHunterRankReward

```csharp
public bool HasHunterRankReward { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_HunterRankReward"></a> HunterRankReward

```csharp
public uint HunterRankReward { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_ItemId"></a> ItemId

```csharp
public uint ItemId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterClaimReward> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterClaimReward](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimReward.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_RewardTypeCase"></a> RewardTypeCase

```csharp
public CMsgClientToGCMonsterHunterClaimReward.RewardTypeOneofCase RewardTypeCase { get; }
```

#### Property Value

 [CMsgClientToGCMonsterHunterClaimReward](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimReward.md).[RewardTypeOneofCase](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimReward.RewardTypeOneofCase.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_ClearHunterRankReward"></a> ClearHunterRankReward\(\)

```csharp
public void ClearHunterRankReward()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_ClearRewardType"></a> ClearRewardType\(\)

```csharp
public void ClearRewardType()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterClaimReward Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterClaimReward](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_"></a> Equals\(CMsgClientToGCMonsterHunterClaimReward\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterClaimReward other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterClaimReward](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimReward.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_"></a> MergeFrom\(CMsgClientToGCMonsterHunterClaimReward\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterClaimReward other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterClaimReward](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimReward_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

