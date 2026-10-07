# <a id="Divine_Protobufs_Dota2_CMsgStickerbook"></a> Class CMsgStickerbook

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgStickerbook : IMessage<CMsgStickerbook>, IEquatable<CMsgStickerbook>, IDeepCloneable<CMsgStickerbook>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgStickerbook](Divine.Protobufs.Dota2.CMsgStickerbook.md)

#### Implements

IMessage<CMsgStickerbook\>, 
[IEquatable<CMsgStickerbook\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgStickerbook\>, 
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
[EnumerableExtensions.In<CMsgStickerbook\>\(CMsgStickerbook, params CMsgStickerbook\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook__ctor"></a> CMsgStickerbook\(\)

```csharp
public CMsgStickerbook()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook__ctor_Divine_Protobufs_Dota2_CMsgStickerbook_"></a> CMsgStickerbook\(CMsgStickerbook\)

```csharp
public CMsgStickerbook(CMsgStickerbook other)
```

#### Parameters

`other` [CMsgStickerbook](Divine.Protobufs.Dota2.CMsgStickerbook.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook_FavoritePageNumFieldNumber"></a> FavoritePageNumFieldNumber

```csharp
public const int FavoritePageNumFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook_PagesFieldNumber"></a> PagesFieldNumber

```csharp
public const int PagesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook_TeamPageOrderSequenceFieldNumber"></a> TeamPageOrderSequenceFieldNumber

```csharp
public const int TeamPageOrderSequenceFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook_FavoritePageNum"></a> FavoritePageNum

```csharp
public uint FavoritePageNum { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook_HasFavoritePageNum"></a> HasFavoritePageNum

```csharp
public bool HasFavoritePageNum { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook_Pages"></a> Pages

```csharp
public RepeatedField<CMsgStickerbookPage> Pages { get; }
```

#### Property Value

 RepeatedField<[CMsgStickerbookPage](Divine.Protobufs.Dota2.CMsgStickerbookPage.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook_Parser"></a> Parser

```csharp
public static MessageParser<CMsgStickerbook> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgStickerbook](Divine.Protobufs.Dota2.CMsgStickerbook.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook_TeamPageOrderSequence"></a> TeamPageOrderSequence

```csharp
public CMsgStickerbookTeamPageOrderSequence TeamPageOrderSequence { get; set; }
```

#### Property Value

 [CMsgStickerbookTeamPageOrderSequence](Divine.Protobufs.Dota2.CMsgStickerbookTeamPageOrderSequence.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook_ClearFavoritePageNum"></a> ClearFavoritePageNum\(\)

```csharp
public void ClearFavoritePageNum()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook_Clone"></a> Clone\(\)

```csharp
public CMsgStickerbook Clone()
```

#### Returns

 [CMsgStickerbook](Divine.Protobufs.Dota2.CMsgStickerbook.md)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook_Equals_Divine_Protobufs_Dota2_CMsgStickerbook_"></a> Equals\(CMsgStickerbook\)

```csharp
public bool Equals(CMsgStickerbook other)
```

#### Parameters

`other` [CMsgStickerbook](Divine.Protobufs.Dota2.CMsgStickerbook.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook_MergeFrom_Divine_Protobufs_Dota2_CMsgStickerbook_"></a> MergeFrom\(CMsgStickerbook\)

```csharp
public void MergeFrom(CMsgStickerbook other)
```

#### Parameters

`other` [CMsgStickerbook](Divine.Protobufs.Dota2.CMsgStickerbook.md)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbook_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

