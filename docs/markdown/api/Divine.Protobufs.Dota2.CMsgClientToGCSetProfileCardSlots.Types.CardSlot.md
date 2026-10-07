# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot"></a> Class CMsgClientToGCSetProfileCardSlots.Types.CardSlot

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSetProfileCardSlots.Types.CardSlot : IMessage<CMsgClientToGCSetProfileCardSlots.Types.CardSlot>, IEquatable<CMsgClientToGCSetProfileCardSlots.Types.CardSlot>, IDeepCloneable<CMsgClientToGCSetProfileCardSlots.Types.CardSlot>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSetProfileCardSlots.Types.CardSlot](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.Types.CardSlot.md)

#### Implements

IMessage<CMsgClientToGCSetProfileCardSlots.Types.CardSlot\>, 
[IEquatable<CMsgClientToGCSetProfileCardSlots.Types.CardSlot\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSetProfileCardSlots.Types.CardSlot\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSetProfileCardSlots.Types.CardSlot\>\(CMsgClientToGCSetProfileCardSlots.Types.CardSlot, params CMsgClientToGCSetProfileCardSlots.Types.CardSlot\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot__ctor"></a> CardSlot\(\)

```csharp
public CardSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_"></a> CardSlot\(CardSlot\)

```csharp
public CardSlot(CMsgClientToGCSetProfileCardSlots.Types.CardSlot other)
```

#### Parameters

`other` [CMsgClientToGCSetProfileCardSlots](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.Types.md).[CardSlot](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.Types.CardSlot.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_SlotIdFieldNumber"></a> SlotIdFieldNumber

```csharp
public const int SlotIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_SlotTypeFieldNumber"></a> SlotTypeFieldNumber

```csharp
public const int SlotTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_SlotValueFieldNumber"></a> SlotValueFieldNumber

```csharp
public const int SlotValueFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_HasSlotId"></a> HasSlotId

```csharp
public bool HasSlotId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_HasSlotType"></a> HasSlotType

```csharp
public bool HasSlotType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_HasSlotValue"></a> HasSlotValue

```csharp
public bool HasSlotValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSetProfileCardSlots.Types.CardSlot> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSetProfileCardSlots](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.Types.md).[CardSlot](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.Types.CardSlot.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_SlotId"></a> SlotId

```csharp
public uint SlotId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_SlotType"></a> SlotType

```csharp
public EProfileCardSlotType SlotType { get; set; }
```

#### Property Value

 [EProfileCardSlotType](Divine.Protobufs.Dota2.EProfileCardSlotType.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_SlotValue"></a> SlotValue

```csharp
public ulong SlotValue { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_ClearSlotId"></a> ClearSlotId\(\)

```csharp
public void ClearSlotId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_ClearSlotType"></a> ClearSlotType\(\)

```csharp
public void ClearSlotType()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_ClearSlotValue"></a> ClearSlotValue\(\)

```csharp
public void ClearSlotValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSetProfileCardSlots.Types.CardSlot Clone()
```

#### Returns

 [CMsgClientToGCSetProfileCardSlots](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.Types.md).[CardSlot](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.Types.CardSlot.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_"></a> Equals\(CardSlot\)

```csharp
public bool Equals(CMsgClientToGCSetProfileCardSlots.Types.CardSlot other)
```

#### Parameters

`other` [CMsgClientToGCSetProfileCardSlots](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.Types.md).[CardSlot](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.Types.CardSlot.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_"></a> MergeFrom\(CardSlot\)

```csharp
public void MergeFrom(CMsgClientToGCSetProfileCardSlots.Types.CardSlot other)
```

#### Parameters

`other` [CMsgClientToGCSetProfileCardSlots](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.Types.md).[CardSlot](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.Types.CardSlot.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Types_CardSlot_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

