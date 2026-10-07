# <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool"></a> Class CMsgDOTALeague.Types.PrizePool

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeague.Types.PrizePool : IMessage<CMsgDOTALeague.Types.PrizePool>, IEquatable<CMsgDOTALeague.Types.PrizePool>, IDeepCloneable<CMsgDOTALeague.Types.PrizePool>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeague.Types.PrizePool](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.PrizePool.md)

#### Implements

IMessage<CMsgDOTALeague.Types.PrizePool\>, 
[IEquatable<CMsgDOTALeague.Types.PrizePool\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeague.Types.PrizePool\>, 
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
[EnumerableExtensions.In<CMsgDOTALeague.Types.PrizePool\>\(CMsgDOTALeague.Types.PrizePool, params CMsgDOTALeague.Types.PrizePool\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool__ctor"></a> PrizePool\(\)

```csharp
public PrizePool()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool__ctor_Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_"></a> PrizePool\(PrizePool\)

```csharp
public PrizePool(CMsgDOTALeague.Types.PrizePool other)
```

#### Parameters

`other` [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[PrizePool](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.PrizePool.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_BasePrizePoolFieldNumber"></a> BasePrizePoolFieldNumber

```csharp
public const int BasePrizePoolFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_PrizePoolItemsFieldNumber"></a> PrizePoolItemsFieldNumber

```csharp
public const int PrizePoolItemsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_PrizeSplitPctX100FieldNumber"></a> PrizeSplitPctX100FieldNumber

```csharp
public const int PrizeSplitPctX100FieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_TotalPrizePoolFieldNumber"></a> TotalPrizePoolFieldNumber

```csharp
public const int TotalPrizePoolFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_BasePrizePool"></a> BasePrizePool

```csharp
public uint BasePrizePool { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_HasBasePrizePool"></a> HasBasePrizePool

```csharp
public bool HasBasePrizePool { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_HasTotalPrizePool"></a> HasTotalPrizePool

```csharp
public bool HasTotalPrizePool { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeague.Types.PrizePool> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[PrizePool](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.PrizePool.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_PrizePoolItems"></a> PrizePoolItems

```csharp
public RepeatedField<CMsgDOTALeague.Types.PrizePoolItem> PrizePoolItems { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[PrizePoolItem](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.PrizePoolItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_PrizeSplitPctX100"></a> PrizeSplitPctX100

```csharp
public RepeatedField<uint> PrizeSplitPctX100 { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_TotalPrizePool"></a> TotalPrizePool

```csharp
public uint TotalPrizePool { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_ClearBasePrizePool"></a> ClearBasePrizePool\(\)

```csharp
public void ClearBasePrizePool()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_ClearTotalPrizePool"></a> ClearTotalPrizePool\(\)

```csharp
public void ClearTotalPrizePool()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeague.Types.PrizePool Clone()
```

#### Returns

 [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[PrizePool](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.PrizePool.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_Equals_Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_"></a> Equals\(PrizePool\)

```csharp
public bool Equals(CMsgDOTALeague.Types.PrizePool other)
```

#### Parameters

`other` [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[PrizePool](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.PrizePool.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_"></a> MergeFrom\(PrizePool\)

```csharp
public void MergeFrom(CMsgDOTALeague.Types.PrizePool other)
```

#### Parameters

`other` [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[PrizePool](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.PrizePool.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_PrizePool_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

