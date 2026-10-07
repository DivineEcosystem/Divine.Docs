# <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem"></a> Class CMsgNeutralItemStats.Types.NeutralItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgNeutralItemStats.Types.NeutralItem : IMessage<CMsgNeutralItemStats.Types.NeutralItem>, IEquatable<CMsgNeutralItemStats.Types.NeutralItem>, IDeepCloneable<CMsgNeutralItemStats.Types.NeutralItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgNeutralItemStats.Types.NeutralItem](Divine.Protobufs.Dota2.CMsgNeutralItemStats.Types.NeutralItem.md)

#### Implements

IMessage<CMsgNeutralItemStats.Types.NeutralItem\>, 
[IEquatable<CMsgNeutralItemStats.Types.NeutralItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgNeutralItemStats.Types.NeutralItem\>, 
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
[EnumerableExtensions.In<CMsgNeutralItemStats.Types.NeutralItem\>\(CMsgNeutralItemStats.Types.NeutralItem, params CMsgNeutralItemStats.Types.NeutralItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem__ctor"></a> NeutralItem\(\)

```csharp
public NeutralItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem__ctor_Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_"></a> NeutralItem\(NeutralItem\)

```csharp
public NeutralItem(CMsgNeutralItemStats.Types.NeutralItem other)
```

#### Parameters

`other` [CMsgNeutralItemStats](Divine.Protobufs.Dota2.CMsgNeutralItemStats.md).[Types](Divine.Protobufs.Dota2.CMsgNeutralItemStats.Types.md).[NeutralItem](Divine.Protobufs.Dota2.CMsgNeutralItemStats.Types.NeutralItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_DurationEquippedFieldNumber"></a> DurationEquippedFieldNumber

```csharp
public const int DurationEquippedFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_TimeDroppedFieldNumber"></a> TimeDroppedFieldNumber

```csharp
public const int TimeDroppedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_TimeLastEquippedFieldNumber"></a> TimeLastEquippedFieldNumber

```csharp
public const int TimeLastEquippedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_TimeLastUnequippedFieldNumber"></a> TimeLastUnequippedFieldNumber

```csharp
public const int TimeLastUnequippedFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_DurationEquipped"></a> DurationEquipped

```csharp
public uint DurationEquipped { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_HasDurationEquipped"></a> HasDurationEquipped

```csharp
public bool HasDurationEquipped { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_HasTimeDropped"></a> HasTimeDropped

```csharp
public bool HasTimeDropped { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_HasTimeLastEquipped"></a> HasTimeLastEquipped

```csharp
public bool HasTimeLastEquipped { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_HasTimeLastUnequipped"></a> HasTimeLastUnequipped

```csharp
public bool HasTimeLastUnequipped { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_ItemId"></a> ItemId

```csharp
public int ItemId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgNeutralItemStats.Types.NeutralItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgNeutralItemStats](Divine.Protobufs.Dota2.CMsgNeutralItemStats.md).[Types](Divine.Protobufs.Dota2.CMsgNeutralItemStats.Types.md).[NeutralItem](Divine.Protobufs.Dota2.CMsgNeutralItemStats.Types.NeutralItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_Team"></a> Team

```csharp
public uint Team { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_TimeDropped"></a> TimeDropped

```csharp
public uint TimeDropped { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_TimeLastEquipped"></a> TimeLastEquipped

```csharp
public uint TimeLastEquipped { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_TimeLastUnequipped"></a> TimeLastUnequipped

```csharp
public uint TimeLastUnequipped { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_ClearDurationEquipped"></a> ClearDurationEquipped\(\)

```csharp
public void ClearDurationEquipped()
```

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_ClearTimeDropped"></a> ClearTimeDropped\(\)

```csharp
public void ClearTimeDropped()
```

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_ClearTimeLastEquipped"></a> ClearTimeLastEquipped\(\)

```csharp
public void ClearTimeLastEquipped()
```

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_ClearTimeLastUnequipped"></a> ClearTimeLastUnequipped\(\)

```csharp
public void ClearTimeLastUnequipped()
```

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_Clone"></a> Clone\(\)

```csharp
public CMsgNeutralItemStats.Types.NeutralItem Clone()
```

#### Returns

 [CMsgNeutralItemStats](Divine.Protobufs.Dota2.CMsgNeutralItemStats.md).[Types](Divine.Protobufs.Dota2.CMsgNeutralItemStats.Types.md).[NeutralItem](Divine.Protobufs.Dota2.CMsgNeutralItemStats.Types.NeutralItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_Equals_Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_"></a> Equals\(NeutralItem\)

```csharp
public bool Equals(CMsgNeutralItemStats.Types.NeutralItem other)
```

#### Parameters

`other` [CMsgNeutralItemStats](Divine.Protobufs.Dota2.CMsgNeutralItemStats.md).[Types](Divine.Protobufs.Dota2.CMsgNeutralItemStats.Types.md).[NeutralItem](Divine.Protobufs.Dota2.CMsgNeutralItemStats.Types.NeutralItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_MergeFrom_Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_"></a> MergeFrom\(NeutralItem\)

```csharp
public void MergeFrom(CMsgNeutralItemStats.Types.NeutralItem other)
```

#### Parameters

`other` [CMsgNeutralItemStats](Divine.Protobufs.Dota2.CMsgNeutralItemStats.md).[Types](Divine.Protobufs.Dota2.CMsgNeutralItemStats.Types.md).[NeutralItem](Divine.Protobufs.Dota2.CMsgNeutralItemStats.Types.NeutralItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Types_NeutralItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

