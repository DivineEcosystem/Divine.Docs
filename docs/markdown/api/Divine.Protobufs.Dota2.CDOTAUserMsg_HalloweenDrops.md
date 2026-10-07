# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops"></a> Class CDOTAUserMsg\_HalloweenDrops

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_HalloweenDrops : IMessage<CDOTAUserMsg_HalloweenDrops>, IEquatable<CDOTAUserMsg_HalloweenDrops>, IDeepCloneable<CDOTAUserMsg_HalloweenDrops>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_HalloweenDrops](Divine.Protobufs.Dota2.CDOTAUserMsg\_HalloweenDrops.md)

#### Implements

IMessage<CDOTAUserMsg\_HalloweenDrops\>, 
[IEquatable<CDOTAUserMsg\_HalloweenDrops\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_HalloweenDrops\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_HalloweenDrops\>\(CDOTAUserMsg\_HalloweenDrops, params CDOTAUserMsg\_HalloweenDrops\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops__ctor"></a> CDOTAUserMsg\_HalloweenDrops\(\)

```csharp
public CDOTAUserMsg_HalloweenDrops()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_"></a> CDOTAUserMsg\_HalloweenDrops\(CDOTAUserMsg\_HalloweenDrops\)

```csharp
public CDOTAUserMsg_HalloweenDrops(CDOTAUserMsg_HalloweenDrops other)
```

#### Parameters

`other` [CDOTAUserMsg\_HalloweenDrops](Divine.Protobufs.Dota2.CDOTAUserMsg\_HalloweenDrops.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_ItemDefsFieldNumber"></a> ItemDefsFieldNumber

```csharp
public const int ItemDefsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_PlayerIdsFieldNumber"></a> PlayerIdsFieldNumber

```csharp
public const int PlayerIdsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_PrizeListFieldNumber"></a> PrizeListFieldNumber

```csharp
public const int PrizeListFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_HasPrizeList"></a> HasPrizeList

```csharp
public bool HasPrizeList { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_ItemDefs"></a> ItemDefs

```csharp
public RepeatedField<uint> ItemDefs { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_HalloweenDrops> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_HalloweenDrops](Divine.Protobufs.Dota2.CDOTAUserMsg\_HalloweenDrops.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_PlayerIds"></a> PlayerIds

```csharp
public RepeatedField<int> PlayerIds { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_PrizeList"></a> PrizeList

```csharp
public uint PrizeList { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_ClearPrizeList"></a> ClearPrizeList\(\)

```csharp
public void ClearPrizeList()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_HalloweenDrops Clone()
```

#### Returns

 [CDOTAUserMsg\_HalloweenDrops](Divine.Protobufs.Dota2.CDOTAUserMsg\_HalloweenDrops.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_"></a> Equals\(CDOTAUserMsg\_HalloweenDrops\)

```csharp
public bool Equals(CDOTAUserMsg_HalloweenDrops other)
```

#### Parameters

`other` [CDOTAUserMsg\_HalloweenDrops](Divine.Protobufs.Dota2.CDOTAUserMsg\_HalloweenDrops.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_"></a> MergeFrom\(CDOTAUserMsg\_HalloweenDrops\)

```csharp
public void MergeFrom(CDOTAUserMsg_HalloweenDrops other)
```

#### Parameters

`other` [CDOTAUserMsg\_HalloweenDrops](Divine.Protobufs.Dota2.CDOTAUserMsg\_HalloweenDrops.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HalloweenDrops_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

