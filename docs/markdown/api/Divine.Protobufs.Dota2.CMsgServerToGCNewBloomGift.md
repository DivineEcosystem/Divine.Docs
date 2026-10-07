# <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift"></a> Class CMsgServerToGCNewBloomGift

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCNewBloomGift : IMessage<CMsgServerToGCNewBloomGift>, IEquatable<CMsgServerToGCNewBloomGift>, IDeepCloneable<CMsgServerToGCNewBloomGift>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCNewBloomGift](Divine.Protobufs.Dota2.CMsgServerToGCNewBloomGift.md)

#### Implements

IMessage<CMsgServerToGCNewBloomGift\>, 
[IEquatable<CMsgServerToGCNewBloomGift\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCNewBloomGift\>, 
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
[EnumerableExtensions.In<CMsgServerToGCNewBloomGift\>\(CMsgServerToGCNewBloomGift, params CMsgServerToGCNewBloomGift\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift__ctor"></a> CMsgServerToGCNewBloomGift\(\)

```csharp
public CMsgServerToGCNewBloomGift()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift__ctor_Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_"></a> CMsgServerToGCNewBloomGift\(CMsgServerToGCNewBloomGift\)

```csharp
public CMsgServerToGCNewBloomGift(CMsgServerToGCNewBloomGift other)
```

#### Parameters

`other` [CMsgServerToGCNewBloomGift](Divine.Protobufs.Dota2.CMsgServerToGCNewBloomGift.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_DefindexFieldNumber"></a> DefindexFieldNumber

```csharp
public const int DefindexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_GifterAccountIdFieldNumber"></a> GifterAccountIdFieldNumber

```csharp
public const int GifterAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_TargetAccountIdsFieldNumber"></a> TargetAccountIdsFieldNumber

```csharp
public const int TargetAccountIdsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_Defindex"></a> Defindex

```csharp
public uint Defindex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_GifterAccountId"></a> GifterAccountId

```csharp
public uint GifterAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_HasDefindex"></a> HasDefindex

```csharp
public bool HasDefindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_HasGifterAccountId"></a> HasGifterAccountId

```csharp
public bool HasGifterAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCNewBloomGift> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCNewBloomGift](Divine.Protobufs.Dota2.CMsgServerToGCNewBloomGift.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_TargetAccountIds"></a> TargetAccountIds

```csharp
public RepeatedField<uint> TargetAccountIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_ClearDefindex"></a> ClearDefindex\(\)

```csharp
public void ClearDefindex()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_ClearGifterAccountId"></a> ClearGifterAccountId\(\)

```csharp
public void ClearGifterAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCNewBloomGift Clone()
```

#### Returns

 [CMsgServerToGCNewBloomGift](Divine.Protobufs.Dota2.CMsgServerToGCNewBloomGift.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_Equals_Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_"></a> Equals\(CMsgServerToGCNewBloomGift\)

```csharp
public bool Equals(CMsgServerToGCNewBloomGift other)
```

#### Parameters

`other` [CMsgServerToGCNewBloomGift](Divine.Protobufs.Dota2.CMsgServerToGCNewBloomGift.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_"></a> MergeFrom\(CMsgServerToGCNewBloomGift\)

```csharp
public void MergeFrom(CMsgServerToGCNewBloomGift other)
```

#### Parameters

`other` [CMsgServerToGCNewBloomGift](Divine.Protobufs.Dota2.CMsgServerToGCNewBloomGift.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGift_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

