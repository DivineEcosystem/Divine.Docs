# <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot"></a> Class CMsgUnderDraftData.Types.ShopSlot

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgUnderDraftData.Types.ShopSlot : IMessage<CMsgUnderDraftData.Types.ShopSlot>, IEquatable<CMsgUnderDraftData.Types.ShopSlot>, IDeepCloneable<CMsgUnderDraftData.Types.ShopSlot>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgUnderDraftData.Types.ShopSlot](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.ShopSlot.md)

#### Implements

IMessage<CMsgUnderDraftData.Types.ShopSlot\>, 
[IEquatable<CMsgUnderDraftData.Types.ShopSlot\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgUnderDraftData.Types.ShopSlot\>, 
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
[EnumerableExtensions.In<CMsgUnderDraftData.Types.ShopSlot\>\(CMsgUnderDraftData.Types.ShopSlot, params CMsgUnderDraftData.Types.ShopSlot\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot__ctor"></a> ShopSlot\(\)

```csharp
public ShopSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot__ctor_Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_"></a> ShopSlot\(ShopSlot\)

```csharp
public ShopSlot(CMsgUnderDraftData.Types.ShopSlot other)
```

#### Parameters

`other` [CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md).[Types](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.md).[ShopSlot](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.ShopSlot.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_IsSpecialRewardFieldNumber"></a> IsSpecialRewardFieldNumber

```csharp
public const int IsSpecialRewardFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_SlotIdFieldNumber"></a> SlotIdFieldNumber

```csharp
public const int SlotIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_HasIsSpecialReward"></a> HasIsSpecialReward

```csharp
public bool HasIsSpecialReward { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_HasSlotId"></a> HasSlotId

```csharp
public bool HasSlotId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_IsSpecialReward"></a> IsSpecialReward

```csharp
public bool IsSpecialReward { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_Parser"></a> Parser

```csharp
public static MessageParser<CMsgUnderDraftData.Types.ShopSlot> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md).[Types](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.md).[ShopSlot](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.ShopSlot.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_SlotId"></a> SlotId

```csharp
public uint SlotId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_ClearIsSpecialReward"></a> ClearIsSpecialReward\(\)

```csharp
public void ClearIsSpecialReward()
```

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_ClearSlotId"></a> ClearSlotId\(\)

```csharp
public void ClearSlotId()
```

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_Clone"></a> Clone\(\)

```csharp
public CMsgUnderDraftData.Types.ShopSlot Clone()
```

#### Returns

 [CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md).[Types](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.md).[ShopSlot](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.ShopSlot.md)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_Equals_Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_"></a> Equals\(ShopSlot\)

```csharp
public bool Equals(CMsgUnderDraftData.Types.ShopSlot other)
```

#### Parameters

`other` [CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md).[Types](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.md).[ShopSlot](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.ShopSlot.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_MergeFrom_Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_"></a> MergeFrom\(ShopSlot\)

```csharp
public void MergeFrom(CMsgUnderDraftData.Types.ShopSlot other)
```

#### Parameters

`other` [CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md).[Types](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.md).[ShopSlot](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.ShopSlot.md)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_ShopSlot_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

