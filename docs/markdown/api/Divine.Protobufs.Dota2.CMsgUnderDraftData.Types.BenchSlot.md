# <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot"></a> Class CMsgUnderDraftData.Types.BenchSlot

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgUnderDraftData.Types.BenchSlot : IMessage<CMsgUnderDraftData.Types.BenchSlot>, IEquatable<CMsgUnderDraftData.Types.BenchSlot>, IDeepCloneable<CMsgUnderDraftData.Types.BenchSlot>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgUnderDraftData.Types.BenchSlot](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.BenchSlot.md)

#### Implements

IMessage<CMsgUnderDraftData.Types.BenchSlot\>, 
[IEquatable<CMsgUnderDraftData.Types.BenchSlot\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgUnderDraftData.Types.BenchSlot\>, 
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
[EnumerableExtensions.In<CMsgUnderDraftData.Types.BenchSlot\>\(CMsgUnderDraftData.Types.BenchSlot, params CMsgUnderDraftData.Types.BenchSlot\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot__ctor"></a> BenchSlot\(\)

```csharp
public BenchSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot__ctor_Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_"></a> BenchSlot\(BenchSlot\)

```csharp
public BenchSlot(CMsgUnderDraftData.Types.BenchSlot other)
```

#### Parameters

`other` [CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md).[Types](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.md).[BenchSlot](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.BenchSlot.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_SlotIdFieldNumber"></a> SlotIdFieldNumber

```csharp
public const int SlotIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_StarsFieldNumber"></a> StarsFieldNumber

```csharp
public const int StarsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_HasSlotId"></a> HasSlotId

```csharp
public bool HasSlotId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_HasStars"></a> HasStars

```csharp
public bool HasStars { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_Parser"></a> Parser

```csharp
public static MessageParser<CMsgUnderDraftData.Types.BenchSlot> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md).[Types](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.md).[BenchSlot](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.BenchSlot.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_SlotId"></a> SlotId

```csharp
public uint SlotId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_Stars"></a> Stars

```csharp
public uint Stars { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_ClearSlotId"></a> ClearSlotId\(\)

```csharp
public void ClearSlotId()
```

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_ClearStars"></a> ClearStars\(\)

```csharp
public void ClearStars()
```

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_Clone"></a> Clone\(\)

```csharp
public CMsgUnderDraftData.Types.BenchSlot Clone()
```

#### Returns

 [CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md).[Types](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.md).[BenchSlot](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.BenchSlot.md)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_Equals_Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_"></a> Equals\(BenchSlot\)

```csharp
public bool Equals(CMsgUnderDraftData.Types.BenchSlot other)
```

#### Parameters

`other` [CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md).[Types](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.md).[BenchSlot](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.BenchSlot.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_MergeFrom_Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_"></a> MergeFrom\(BenchSlot\)

```csharp
public void MergeFrom(CMsgUnderDraftData.Types.BenchSlot other)
```

#### Parameters

`other` [CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md).[Types](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.md).[BenchSlot](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.BenchSlot.md)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Types_BenchSlot_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

