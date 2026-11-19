# <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems"></a> Class CMsgGCGiftedItems

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCGiftedItems : IMessage<CMsgGCGiftedItems>, IEquatable<CMsgGCGiftedItems>, IDeepCloneable<CMsgGCGiftedItems>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCGiftedItems](Divine.Protobufs.Dota2.CMsgGCGiftedItems.md)

#### Implements

IMessage<CMsgGCGiftedItems\>, 
[IEquatable<CMsgGCGiftedItems\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCGiftedItems\>, 
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
[EnumerableExtensions.In<CMsgGCGiftedItems\>\(CMsgGCGiftedItems, params CMsgGCGiftedItems\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems__ctor"></a> CMsgGCGiftedItems\(\)

```csharp
public CMsgGCGiftedItems()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems__ctor_Divine_Protobufs_Dota2_CMsgGCGiftedItems_"></a> CMsgGCGiftedItems\(CMsgGCGiftedItems\)

```csharp
public CMsgGCGiftedItems(CMsgGCGiftedItems other)
```

#### Parameters

`other` [CMsgGCGiftedItems](Divine.Protobufs.Dota2.CMsgGCGiftedItems.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_GifterAccountIdFieldNumber"></a> GifterAccountIdFieldNumber

```csharp
public const int GifterAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_RecipientAccountIdsFieldNumber"></a> RecipientAccountIdsFieldNumber

```csharp
public const int RecipientAccountIdsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_WasRandomPersonFieldNumber"></a> WasRandomPersonFieldNumber

```csharp
public const int WasRandomPersonFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_GifterAccountId"></a> GifterAccountId

```csharp
public uint GifterAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_HasGifterAccountId"></a> HasGifterAccountId

```csharp
public bool HasGifterAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_HasWasRandomPerson"></a> HasWasRandomPerson

```csharp
public bool HasWasRandomPerson { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCGiftedItems> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCGiftedItems](Divine.Protobufs.Dota2.CMsgGCGiftedItems.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_RecipientAccountIds"></a> RecipientAccountIds

```csharp
public RepeatedField<uint> RecipientAccountIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_WasRandomPerson"></a> WasRandomPerson

```csharp
public bool WasRandomPerson { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_ClearGifterAccountId"></a> ClearGifterAccountId\(\)

```csharp
public void ClearGifterAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_ClearWasRandomPerson"></a> ClearWasRandomPerson\(\)

```csharp
public void ClearWasRandomPerson()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_Clone"></a> Clone\(\)

```csharp
public CMsgGCGiftedItems Clone()
```

#### Returns

 [CMsgGCGiftedItems](Divine.Protobufs.Dota2.CMsgGCGiftedItems.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_Equals_Divine_Protobufs_Dota2_CMsgGCGiftedItems_"></a> Equals\(CMsgGCGiftedItems\)

```csharp
public bool Equals(CMsgGCGiftedItems other)
```

#### Parameters

`other` [CMsgGCGiftedItems](Divine.Protobufs.Dota2.CMsgGCGiftedItems.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_MergeFrom_Divine_Protobufs_Dota2_CMsgGCGiftedItems_"></a> MergeFrom\(CMsgGCGiftedItems\)

```csharp
public void MergeFrom(CMsgGCGiftedItems other)
```

#### Parameters

`other` [CMsgGCGiftedItems](Divine.Protobufs.Dota2.CMsgGCGiftedItems.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCGiftedItems_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

