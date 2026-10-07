# <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder"></a> Class CDOTAMsg\_UnitOrder

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMsg_UnitOrder : IMessage<CDOTAMsg_UnitOrder>, IEquatable<CDOTAMsg_UnitOrder>, IDeepCloneable<CDOTAMsg_UnitOrder>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMsg\_UnitOrder](Divine.Protobufs.Dota2.CDOTAMsg\_UnitOrder.md)

#### Implements

IMessage<CDOTAMsg\_UnitOrder\>, 
[IEquatable<CDOTAMsg\_UnitOrder\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMsg\_UnitOrder\>, 
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
[EnumerableExtensions.In<CDOTAMsg\_UnitOrder\>\(CDOTAMsg\_UnitOrder, params CDOTAMsg\_UnitOrder\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder__ctor"></a> CDOTAMsg\_UnitOrder\(\)

```csharp
public CDOTAMsg_UnitOrder()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder__ctor_Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_"></a> CDOTAMsg\_UnitOrder\(CDOTAMsg\_UnitOrder\)

```csharp
public CDOTAMsg_UnitOrder(CDOTAMsg_UnitOrder other)
```

#### Parameters

`other` [CDOTAMsg\_UnitOrder](Divine.Protobufs.Dota2.CDOTAMsg\_UnitOrder.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_AbilityIndexFieldNumber"></a> AbilityIndexFieldNumber

```csharp
public const int AbilityIndexFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_OrderTypeFieldNumber"></a> OrderTypeFieldNumber

```csharp
public const int OrderTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_PositionFieldNumber"></a> PositionFieldNumber

```csharp
public const int PositionFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_SequenceNumberFieldNumber"></a> SequenceNumberFieldNumber

```csharp
public const int SequenceNumberFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_TargetIndexFieldNumber"></a> TargetIndexFieldNumber

```csharp
public const int TargetIndexFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_UnitsFieldNumber"></a> UnitsFieldNumber

```csharp
public const int UnitsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_AbilityIndex"></a> AbilityIndex

```csharp
public int AbilityIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_HasAbilityIndex"></a> HasAbilityIndex

```csharp
public bool HasAbilityIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_HasOrderType"></a> HasOrderType

```csharp
public bool HasOrderType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_HasSequenceNumber"></a> HasSequenceNumber

```csharp
public bool HasSequenceNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_HasTargetIndex"></a> HasTargetIndex

```csharp
public bool HasTargetIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_OrderType"></a> OrderType

```csharp
public dotaunitorder_t OrderType { get; set; }
```

#### Property Value

 [dotaunitorder\_t](Divine.Protobufs.Dota2.dotaunitorder\_t.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMsg_UnitOrder> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMsg\_UnitOrder](Divine.Protobufs.Dota2.CDOTAMsg\_UnitOrder.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_Position"></a> Position

```csharp
public CMsgVector Position { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_SequenceNumber"></a> SequenceNumber

```csharp
public int SequenceNumber { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_TargetIndex"></a> TargetIndex

```csharp
public int TargetIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_Units"></a> Units

```csharp
public RepeatedField<int> Units { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_ClearAbilityIndex"></a> ClearAbilityIndex\(\)

```csharp
public void ClearAbilityIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_ClearOrderType"></a> ClearOrderType\(\)

```csharp
public void ClearOrderType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_ClearSequenceNumber"></a> ClearSequenceNumber\(\)

```csharp
public void ClearSequenceNumber()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_ClearTargetIndex"></a> ClearTargetIndex\(\)

```csharp
public void ClearTargetIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_Clone"></a> Clone\(\)

```csharp
public CDOTAMsg_UnitOrder Clone()
```

#### Returns

 [CDOTAMsg\_UnitOrder](Divine.Protobufs.Dota2.CDOTAMsg\_UnitOrder.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_Equals_Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_"></a> Equals\(CDOTAMsg\_UnitOrder\)

```csharp
public bool Equals(CDOTAMsg_UnitOrder other)
```

#### Parameters

`other` [CDOTAMsg\_UnitOrder](Divine.Protobufs.Dota2.CDOTAMsg\_UnitOrder.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_MergeFrom_Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_"></a> MergeFrom\(CDOTAMsg\_UnitOrder\)

```csharp
public void MergeFrom(CDOTAMsg_UnitOrder other)
```

#### Parameters

`other` [CDOTAMsg\_UnitOrder](Divine.Protobufs.Dota2.CDOTAMsg\_UnitOrder.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_UnitOrder_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

