# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem"></a> Class CDOTAUserMsg\_FoundNeutralItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_FoundNeutralItem : IMessage<CDOTAUserMsg_FoundNeutralItem>, IEquatable<CDOTAUserMsg_FoundNeutralItem>, IDeepCloneable<CDOTAUserMsg_FoundNeutralItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_FoundNeutralItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_FoundNeutralItem.md)

#### Implements

IMessage<CDOTAUserMsg\_FoundNeutralItem\>, 
[IEquatable<CDOTAUserMsg\_FoundNeutralItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_FoundNeutralItem\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_FoundNeutralItem\>\(CDOTAUserMsg\_FoundNeutralItem, params CDOTAUserMsg\_FoundNeutralItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem__ctor"></a> CDOTAUserMsg\_FoundNeutralItem\(\)

```csharp
public CDOTAUserMsg_FoundNeutralItem()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_"></a> CDOTAUserMsg\_FoundNeutralItem\(CDOTAUserMsg\_FoundNeutralItem\)

```csharp
public CDOTAUserMsg_FoundNeutralItem(CDOTAUserMsg_FoundNeutralItem other)
```

#### Parameters

`other` [CDOTAUserMsg\_FoundNeutralItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_FoundNeutralItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_EnhancementAbilityIdFieldNumber"></a> EnhancementAbilityIdFieldNumber

```csharp
public const int EnhancementAbilityIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_EnhancementLevelFieldNumber"></a> EnhancementLevelFieldNumber

```csharp
public const int EnhancementLevelFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_ItemAbilityIdFieldNumber"></a> ItemAbilityIdFieldNumber

```csharp
public const int ItemAbilityIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_ItemTierFieldNumber"></a> ItemTierFieldNumber

```csharp
public const int ItemTierFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_TierItemCountFieldNumber"></a> TierItemCountFieldNumber

```csharp
public const int TierItemCountFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_TrinketLevelFieldNumber"></a> TrinketLevelFieldNumber

```csharp
public const int TrinketLevelFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_EnhancementAbilityId"></a> EnhancementAbilityId

```csharp
public int EnhancementAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_EnhancementLevel"></a> EnhancementLevel

```csharp
public int EnhancementLevel { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_HasEnhancementAbilityId"></a> HasEnhancementAbilityId

```csharp
public bool HasEnhancementAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_HasEnhancementLevel"></a> HasEnhancementLevel

```csharp
public bool HasEnhancementLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_HasItemAbilityId"></a> HasItemAbilityId

```csharp
public bool HasItemAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_HasItemTier"></a> HasItemTier

```csharp
public bool HasItemTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_HasTierItemCount"></a> HasTierItemCount

```csharp
public bool HasTierItemCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_HasTrinketLevel"></a> HasTrinketLevel

```csharp
public bool HasTrinketLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_ItemAbilityId"></a> ItemAbilityId

```csharp
public int ItemAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_ItemTier"></a> ItemTier

```csharp
public uint ItemTier { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_FoundNeutralItem> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_FoundNeutralItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_FoundNeutralItem.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_TierItemCount"></a> TierItemCount

```csharp
public uint TierItemCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_TrinketLevel"></a> TrinketLevel

```csharp
public int TrinketLevel { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_ClearEnhancementAbilityId"></a> ClearEnhancementAbilityId\(\)

```csharp
public void ClearEnhancementAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_ClearEnhancementLevel"></a> ClearEnhancementLevel\(\)

```csharp
public void ClearEnhancementLevel()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_ClearItemAbilityId"></a> ClearItemAbilityId\(\)

```csharp
public void ClearItemAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_ClearItemTier"></a> ClearItemTier\(\)

```csharp
public void ClearItemTier()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_ClearTierItemCount"></a> ClearTierItemCount\(\)

```csharp
public void ClearTierItemCount()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_ClearTrinketLevel"></a> ClearTrinketLevel\(\)

```csharp
public void ClearTrinketLevel()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_FoundNeutralItem Clone()
```

#### Returns

 [CDOTAUserMsg\_FoundNeutralItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_FoundNeutralItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_"></a> Equals\(CDOTAUserMsg\_FoundNeutralItem\)

```csharp
public bool Equals(CDOTAUserMsg_FoundNeutralItem other)
```

#### Parameters

`other` [CDOTAUserMsg\_FoundNeutralItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_FoundNeutralItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_"></a> MergeFrom\(CDOTAUserMsg\_FoundNeutralItem\)

```csharp
public void MergeFrom(CDOTAUserMsg_FoundNeutralItem other)
```

#### Parameters

`other` [CDOTAUserMsg\_FoundNeutralItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_FoundNeutralItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FoundNeutralItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

