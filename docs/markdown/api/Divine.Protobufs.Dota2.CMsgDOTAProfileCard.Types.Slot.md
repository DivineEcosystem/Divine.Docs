# <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot"></a> Class CMsgDOTAProfileCard.Types.Slot

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAProfileCard.Types.Slot : IMessage<CMsgDOTAProfileCard.Types.Slot>, IEquatable<CMsgDOTAProfileCard.Types.Slot>, IDeepCloneable<CMsgDOTAProfileCard.Types.Slot>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAProfileCard.Types.Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md)

#### Implements

IMessage<CMsgDOTAProfileCard.Types.Slot\>, 
[IEquatable<CMsgDOTAProfileCard.Types.Slot\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAProfileCard.Types.Slot\>, 
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
[EnumerableExtensions.In<CMsgDOTAProfileCard.Types.Slot\>\(CMsgDOTAProfileCard.Types.Slot, params CMsgDOTAProfileCard.Types.Slot\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot__ctor"></a> Slot\(\)

```csharp
public Slot()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot__ctor_Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_"></a> Slot\(Slot\)

```csharp
public Slot(CMsgDOTAProfileCard.Types.Slot other)
```

#### Parameters

`other` [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_EmoticonFieldNumber"></a> EmoticonFieldNumber

```csharp
public const int EmoticonFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_HeroFieldNumber"></a> HeroFieldNumber

```csharp
public const int HeroFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_ItemFieldNumber"></a> ItemFieldNumber

```csharp
public const int ItemFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_SlotIdFieldNumber"></a> SlotIdFieldNumber

```csharp
public const int SlotIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_StatFieldNumber"></a> StatFieldNumber

```csharp
public const int StatFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_TrophyFieldNumber"></a> TrophyFieldNumber

```csharp
public const int TrophyFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Emoticon"></a> Emoticon

```csharp
public CMsgDOTAProfileCard.Types.Slot.Types.Emoticon Emoticon { get; set; }
```

#### Property Value

 [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Emoticon](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Emoticon.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_HasSlotId"></a> HasSlotId

```csharp
public bool HasSlotId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Hero"></a> Hero

```csharp
public CMsgDOTAProfileCard.Types.Slot.Types.Hero Hero { get; set; }
```

#### Property Value

 [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Hero](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Hero.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Item"></a> Item

```csharp
public CMsgDOTAProfileCard.Types.Slot.Types.Item Item { get; set; }
```

#### Property Value

 [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Item](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Item.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAProfileCard.Types.Slot> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_SlotId"></a> SlotId

```csharp
public uint SlotId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Stat"></a> Stat

```csharp
public CMsgDOTAProfileCard.Types.Slot.Types.Stat Stat { get; set; }
```

#### Property Value

 [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Stat](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Stat.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Team"></a> Team

```csharp
public CMsgDOTAProfileCard.Types.Slot.Types.Team Team { get; set; }
```

#### Property Value

 [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Team.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Trophy"></a> Trophy

```csharp
public CMsgDOTAProfileCard.Types.Slot.Types.Trophy Trophy { get; set; }
```

#### Property Value

 [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Trophy](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Trophy.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_ClearSlotId"></a> ClearSlotId\(\)

```csharp
public void ClearSlotId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAProfileCard.Types.Slot Clone()
```

#### Returns

 [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Equals_Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_"></a> Equals\(Slot\)

```csharp
public bool Equals(CMsgDOTAProfileCard.Types.Slot other)
```

#### Parameters

`other` [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_"></a> MergeFrom\(Slot\)

```csharp
public void MergeFrom(CMsgDOTAProfileCard.Types.Slot other)
```

#### Parameters

`other` [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

