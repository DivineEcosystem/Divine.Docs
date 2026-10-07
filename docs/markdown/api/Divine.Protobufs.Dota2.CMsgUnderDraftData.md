# <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData"></a> Class CMsgUnderDraftData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgUnderDraftData : IMessage<CMsgUnderDraftData>, IEquatable<CMsgUnderDraftData>, IDeepCloneable<CMsgUnderDraftData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md)

#### Implements

IMessage<CMsgUnderDraftData\>, 
[IEquatable<CMsgUnderDraftData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgUnderDraftData\>, 
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
[EnumerableExtensions.In<CMsgUnderDraftData\>\(CMsgUnderDraftData, params CMsgUnderDraftData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData__ctor"></a> CMsgUnderDraftData\(\)

```csharp
public CMsgUnderDraftData()
```

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData__ctor_Divine_Protobufs_Dota2_CMsgUnderDraftData_"></a> CMsgUnderDraftData\(CMsgUnderDraftData\)

```csharp
public CMsgUnderDraftData(CMsgUnderDraftData other)
```

#### Parameters

`other` [CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_BenchSlotsFieldNumber"></a> BenchSlotsFieldNumber

```csharp
public const int BenchSlotsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_GoldFieldNumber"></a> GoldFieldNumber

```csharp
public const int GoldFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_NotRestorableFieldNumber"></a> NotRestorableFieldNumber

```csharp
public const int NotRestorableFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_ShopSlotsFieldNumber"></a> ShopSlotsFieldNumber

```csharp
public const int ShopSlotsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_TotalGoldFieldNumber"></a> TotalGoldFieldNumber

```csharp
public const int TotalGoldFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_BenchSlots"></a> BenchSlots

```csharp
public RepeatedField<CMsgUnderDraftData.Types.BenchSlot> BenchSlots { get; }
```

#### Property Value

 RepeatedField<[CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md).[Types](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.md).[BenchSlot](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.BenchSlot.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Gold"></a> Gold

```csharp
public uint Gold { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_HasGold"></a> HasGold

```csharp
public bool HasGold { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_HasNotRestorable"></a> HasNotRestorable

```csharp
public bool HasNotRestorable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_HasTotalGold"></a> HasTotalGold

```csharp
public bool HasTotalGold { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_NotRestorable"></a> NotRestorable

```csharp
public bool NotRestorable { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgUnderDraftData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_ShopSlots"></a> ShopSlots

```csharp
public RepeatedField<CMsgUnderDraftData.Types.ShopSlot> ShopSlots { get; }
```

#### Property Value

 RepeatedField<[CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md).[Types](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.md).[ShopSlot](Divine.Protobufs.Dota2.CMsgUnderDraftData.Types.ShopSlot.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_TotalGold"></a> TotalGold

```csharp
public uint TotalGold { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_ClearGold"></a> ClearGold\(\)

```csharp
public void ClearGold()
```

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_ClearNotRestorable"></a> ClearNotRestorable\(\)

```csharp
public void ClearNotRestorable()
```

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_ClearTotalGold"></a> ClearTotalGold\(\)

```csharp
public void ClearTotalGold()
```

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Clone"></a> Clone\(\)

```csharp
public CMsgUnderDraftData Clone()
```

#### Returns

 [CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_Equals_Divine_Protobufs_Dota2_CMsgUnderDraftData_"></a> Equals\(CMsgUnderDraftData\)

```csharp
public bool Equals(CMsgUnderDraftData other)
```

#### Parameters

`other` [CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_MergeFrom_Divine_Protobufs_Dota2_CMsgUnderDraftData_"></a> MergeFrom\(CMsgUnderDraftData\)

```csharp
public void MergeFrom(CMsgUnderDraftData other)
```

#### Parameters

`other` [CMsgUnderDraftData](Divine.Protobufs.Dota2.CMsgUnderDraftData.md)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgUnderDraftData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

