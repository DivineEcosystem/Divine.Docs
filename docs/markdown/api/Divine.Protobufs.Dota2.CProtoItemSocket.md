# <a id="Divine_Protobufs_Dota2_CProtoItemSocket"></a> Class CProtoItemSocket

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CProtoItemSocket : IMessage<CProtoItemSocket>, IEquatable<CProtoItemSocket>, IDeepCloneable<CProtoItemSocket>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CProtoItemSocket](Divine.Protobufs.Dota2.CProtoItemSocket.md)

#### Implements

IMessage<CProtoItemSocket\>, 
[IEquatable<CProtoItemSocket\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CProtoItemSocket\>, 
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
[EnumerableExtensions.In<CProtoItemSocket\>\(CProtoItemSocket, params CProtoItemSocket\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket__ctor"></a> CProtoItemSocket\(\)

```csharp
public CProtoItemSocket()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket__ctor_Divine_Protobufs_Dota2_CProtoItemSocket_"></a> CProtoItemSocket\(CProtoItemSocket\)

```csharp
public CProtoItemSocket(CProtoItemSocket other)
```

#### Parameters

`other` [CProtoItemSocket](Divine.Protobufs.Dota2.CProtoItemSocket.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AttrDefIndexFieldNumber"></a> AttrDefIndexFieldNumber

```csharp
public const int AttrDefIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_GemDefIndexFieldNumber"></a> GemDefIndexFieldNumber

```csharp
public const int GemDefIndexFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_NotTradableFieldNumber"></a> NotTradableFieldNumber

```csharp
public const int NotTradableFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_RequiredHeroFieldNumber"></a> RequiredHeroFieldNumber

```csharp
public const int RequiredHeroFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_RequiredItemSlotFieldNumber"></a> RequiredItemSlotFieldNumber

```csharp
public const int RequiredItemSlotFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_RequiredTypeFieldNumber"></a> RequiredTypeFieldNumber

```csharp
public const int RequiredTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_AttrDefIndex"></a> AttrDefIndex

```csharp
public uint AttrDefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_GemDefIndex"></a> GemDefIndex

```csharp
public uint GemDefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_HasAttrDefIndex"></a> HasAttrDefIndex

```csharp
public bool HasAttrDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_HasGemDefIndex"></a> HasGemDefIndex

```csharp
public bool HasGemDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_HasNotTradable"></a> HasNotTradable

```csharp
public bool HasNotTradable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_HasRequiredHero"></a> HasRequiredHero

```csharp
public bool HasRequiredHero { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_HasRequiredItemSlot"></a> HasRequiredItemSlot

```csharp
public bool HasRequiredItemSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_HasRequiredType"></a> HasRequiredType

```csharp
public bool HasRequiredType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_NotTradable"></a> NotTradable

```csharp
public bool NotTradable { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Parser"></a> Parser

```csharp
public static MessageParser<CProtoItemSocket> Parser { get; }
```

#### Property Value

 MessageParser<[CProtoItemSocket](Divine.Protobufs.Dota2.CProtoItemSocket.md)\>

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_RequiredHero"></a> RequiredHero

```csharp
public string RequiredHero { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_RequiredItemSlot"></a> RequiredItemSlot

```csharp
public string RequiredItemSlot { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_RequiredType"></a> RequiredType

```csharp
public uint RequiredType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_ClearAttrDefIndex"></a> ClearAttrDefIndex\(\)

```csharp
public void ClearAttrDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_ClearGemDefIndex"></a> ClearGemDefIndex\(\)

```csharp
public void ClearGemDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_ClearNotTradable"></a> ClearNotTradable\(\)

```csharp
public void ClearNotTradable()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_ClearRequiredHero"></a> ClearRequiredHero\(\)

```csharp
public void ClearRequiredHero()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_ClearRequiredItemSlot"></a> ClearRequiredItemSlot\(\)

```csharp
public void ClearRequiredItemSlot()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_ClearRequiredType"></a> ClearRequiredType\(\)

```csharp
public void ClearRequiredType()
```

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Clone"></a> Clone\(\)

```csharp
public CProtoItemSocket Clone()
```

#### Returns

 [CProtoItemSocket](Divine.Protobufs.Dota2.CProtoItemSocket.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_Equals_Divine_Protobufs_Dota2_CProtoItemSocket_"></a> Equals\(CProtoItemSocket\)

```csharp
public bool Equals(CProtoItemSocket other)
```

#### Parameters

`other` [CProtoItemSocket](Divine.Protobufs.Dota2.CProtoItemSocket.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_MergeFrom_Divine_Protobufs_Dota2_CProtoItemSocket_"></a> MergeFrom\(CProtoItemSocket\)

```csharp
public void MergeFrom(CProtoItemSocket other)
```

#### Parameters

`other` [CProtoItemSocket](Divine.Protobufs.Dota2.CProtoItemSocket.md)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CProtoItemSocket_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

