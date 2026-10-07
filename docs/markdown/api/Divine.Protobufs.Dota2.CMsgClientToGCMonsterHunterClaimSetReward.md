# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetReward"></a> Class CMsgClientToGCMonsterHunterClaimSetReward

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterClaimSetReward : IMessage<CMsgClientToGCMonsterHunterClaimSetReward>, IEquatable<CMsgClientToGCMonsterHunterClaimSetReward>, IDeepCloneable<CMsgClientToGCMonsterHunterClaimSetReward>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterClaimSetReward](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimSetReward.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterClaimSetReward\>, 
[IEquatable<CMsgClientToGCMonsterHunterClaimSetReward\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterClaimSetReward\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterClaimSetReward\>\(CMsgClientToGCMonsterHunterClaimSetReward, params CMsgClientToGCMonsterHunterClaimSetReward\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetReward__ctor"></a> CMsgClientToGCMonsterHunterClaimSetReward\(\)

```csharp
public CMsgClientToGCMonsterHunterClaimSetReward()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetReward__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetReward_"></a> CMsgClientToGCMonsterHunterClaimSetReward\(CMsgClientToGCMonsterHunterClaimSetReward\)

```csharp
public CMsgClientToGCMonsterHunterClaimSetReward(CMsgClientToGCMonsterHunterClaimSetReward other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterClaimSetReward](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimSetReward.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetReward_ItemSetsFieldNumber"></a> ItemSetsFieldNumber

```csharp
public const int ItemSetsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetReward_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetReward_ItemSets"></a> ItemSets

```csharp
public RepeatedField<CMsgMonsterHunterItemSet> ItemSets { get; }
```

#### Property Value

 RepeatedField<[CMsgMonsterHunterItemSet](Divine.Protobufs.Dota2.CMsgMonsterHunterItemSet.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetReward_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterClaimSetReward> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterClaimSetReward](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimSetReward.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetReward_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetReward_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterClaimSetReward Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterClaimSetReward](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimSetReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetReward_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetReward_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetReward_"></a> Equals\(CMsgClientToGCMonsterHunterClaimSetReward\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterClaimSetReward other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterClaimSetReward](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimSetReward.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetReward_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetReward_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetReward_"></a> MergeFrom\(CMsgClientToGCMonsterHunterClaimSetReward\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterClaimSetReward other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterClaimSetReward](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterClaimSetReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetReward_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetReward_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterClaimSetReward_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

