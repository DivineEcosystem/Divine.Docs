# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward"></a> Class CMsgClientToGCMonsterHunterClaimCodexReward

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterClaimCodexReward : IMessage<CMsgClientToGCMonsterHunterClaimCodexReward>, IEquatable<CMsgClientToGCMonsterHunterClaimCodexReward>, IDeepCloneable<CMsgClientToGCMonsterHunterClaimCodexReward>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterClaimCodexReward](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimCodexReward.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterClaimCodexReward\>, 
[IEquatable<CMsgClientToGCMonsterHunterClaimCodexReward\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterClaimCodexReward\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterClaimCodexReward\>\(CMsgClientToGCMonsterHunterClaimCodexReward, params CMsgClientToGCMonsterHunterClaimCodexReward\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward__ctor"></a> CMsgClientToGCMonsterHunterClaimCodexReward\(\)

```csharp
public CMsgClientToGCMonsterHunterClaimCodexReward()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_"></a> CMsgClientToGCMonsterHunterClaimCodexReward\(CMsgClientToGCMonsterHunterClaimCodexReward\)

```csharp
public CMsgClientToGCMonsterHunterClaimCodexReward(CMsgClientToGCMonsterHunterClaimCodexReward other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterClaimCodexReward](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimCodexReward.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_CodexIdFieldNumber"></a> CodexIdFieldNumber

```csharp
public const int CodexIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_RewardFieldNumber"></a> RewardFieldNumber

```csharp
public const int RewardFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_CodexId"></a> CodexId

```csharp
public uint CodexId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_HasCodexId"></a> HasCodexId

```csharp
public bool HasCodexId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_HasReward"></a> HasReward

```csharp
public bool HasReward { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterClaimCodexReward> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterClaimCodexReward](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimCodexReward.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_Reward"></a> Reward

```csharp
public uint Reward { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_ClearCodexId"></a> ClearCodexId\(\)

```csharp
public void ClearCodexId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_ClearReward"></a> ClearReward\(\)

```csharp
public void ClearReward()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterClaimCodexReward Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterClaimCodexReward](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimCodexReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_"></a> Equals\(CMsgClientToGCMonsterHunterClaimCodexReward\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterClaimCodexReward other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterClaimCodexReward](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimCodexReward.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_"></a> MergeFrom\(CMsgClientToGCMonsterHunterClaimCodexReward\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterClaimCodexReward other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterClaimCodexReward](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimCodexReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimCodexReward_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

