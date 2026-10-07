# <a id="Divine_Protobufs_Dota2_CMsgUseItem"></a> Class CMsgUseItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgUseItem : IMessage<CMsgUseItem>, IEquatable<CMsgUseItem>, IDeepCloneable<CMsgUseItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgUseItem](Divine.Protobufs.Dota2.CMsgUseItem.md)

#### Implements

IMessage<CMsgUseItem\>, 
[IEquatable<CMsgUseItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgUseItem\>, 
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
[EnumerableExtensions.In<CMsgUseItem\>\(CMsgUseItem, params CMsgUseItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgUseItem__ctor"></a> CMsgUseItem\(\)

```csharp
public CMsgUseItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgUseItem__ctor_Divine_Protobufs_Dota2_CMsgUseItem_"></a> CMsgUseItem\(CMsgUseItem\)

```csharp
public CMsgUseItem(CMsgUseItem other)
```

#### Parameters

`other` [CMsgUseItem](Divine.Protobufs.Dota2.CMsgUseItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_DuelClassLockFieldNumber"></a> DuelClassLockFieldNumber

```csharp
public const int DuelClassLockFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_GiftPotentialTargetsFieldNumber"></a> GiftPotentialTargetsFieldNumber

```csharp
public const int GiftPotentialTargetsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_InitiatorSteamIdFieldNumber"></a> InitiatorSteamIdFieldNumber

```csharp
public const int InitiatorSteamIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_ItempackAckImmediatelyFieldNumber"></a> ItempackAckImmediatelyFieldNumber

```csharp
public const int ItempackAckImmediatelyFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_TargetSteamIdFieldNumber"></a> TargetSteamIdFieldNumber

```csharp
public const int TargetSteamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_DuelClassLock"></a> DuelClassLock

```csharp
public uint DuelClassLock { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_GiftPotentialTargets"></a> GiftPotentialTargets

```csharp
public RepeatedField<uint> GiftPotentialTargets { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_HasDuelClassLock"></a> HasDuelClassLock

```csharp
public bool HasDuelClassLock { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_HasInitiatorSteamId"></a> HasInitiatorSteamId

```csharp
public bool HasInitiatorSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_HasItempackAckImmediately"></a> HasItempackAckImmediately

```csharp
public bool HasItempackAckImmediately { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_HasTargetSteamId"></a> HasTargetSteamId

```csharp
public bool HasTargetSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_InitiatorSteamId"></a> InitiatorSteamId

```csharp
public ulong InitiatorSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_ItempackAckImmediately"></a> ItempackAckImmediately

```csharp
public bool ItempackAckImmediately { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgUseItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgUseItem](Divine.Protobufs.Dota2.CMsgUseItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_TargetSteamId"></a> TargetSteamId

```csharp
public ulong TargetSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_ClearDuelClassLock"></a> ClearDuelClassLock\(\)

```csharp
public void ClearDuelClassLock()
```

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_ClearInitiatorSteamId"></a> ClearInitiatorSteamId\(\)

```csharp
public void ClearInitiatorSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_ClearItempackAckImmediately"></a> ClearItempackAckImmediately\(\)

```csharp
public void ClearItempackAckImmediately()
```

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_ClearTargetSteamId"></a> ClearTargetSteamId\(\)

```csharp
public void ClearTargetSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_Clone"></a> Clone\(\)

```csharp
public CMsgUseItem Clone()
```

#### Returns

 [CMsgUseItem](Divine.Protobufs.Dota2.CMsgUseItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_Equals_Divine_Protobufs_Dota2_CMsgUseItem_"></a> Equals\(CMsgUseItem\)

```csharp
public bool Equals(CMsgUseItem other)
```

#### Parameters

`other` [CMsgUseItem](Divine.Protobufs.Dota2.CMsgUseItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_MergeFrom_Divine_Protobufs_Dota2_CMsgUseItem_"></a> MergeFrom\(CMsgUseItem\)

```csharp
public void MergeFrom(CMsgUseItem other)
```

#### Parameters

`other` [CMsgUseItem](Divine.Protobufs.Dota2.CMsgUseItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgUseItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

