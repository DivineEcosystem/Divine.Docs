# <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest"></a> Class CMsgClientToGCDeleteStickerbookPageRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCDeleteStickerbookPageRequest : IMessage<CMsgClientToGCDeleteStickerbookPageRequest>, IEquatable<CMsgClientToGCDeleteStickerbookPageRequest>, IDeepCloneable<CMsgClientToGCDeleteStickerbookPageRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCDeleteStickerbookPageRequest](Divine.Protobufs.Dota2.CMsgClientToGCDeleteStickerbookPageRequest.md)

#### Implements

IMessage<CMsgClientToGCDeleteStickerbookPageRequest\>, 
[IEquatable<CMsgClientToGCDeleteStickerbookPageRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCDeleteStickerbookPageRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCDeleteStickerbookPageRequest\>\(CMsgClientToGCDeleteStickerbookPageRequest, params CMsgClientToGCDeleteStickerbookPageRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest__ctor"></a> CMsgClientToGCDeleteStickerbookPageRequest\(\)

```csharp
public CMsgClientToGCDeleteStickerbookPageRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_"></a> CMsgClientToGCDeleteStickerbookPageRequest\(CMsgClientToGCDeleteStickerbookPageRequest\)

```csharp
public CMsgClientToGCDeleteStickerbookPageRequest(CMsgClientToGCDeleteStickerbookPageRequest other)
```

#### Parameters

`other` [CMsgClientToGCDeleteStickerbookPageRequest](Divine.Protobufs.Dota2.CMsgClientToGCDeleteStickerbookPageRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_PageNumFieldNumber"></a> PageNumFieldNumber

```csharp
public const int PageNumFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_StickerCountFieldNumber"></a> StickerCountFieldNumber

```csharp
public const int StickerCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_StickerMaxFieldNumber"></a> StickerMaxFieldNumber

```csharp
public const int StickerMaxFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_HasPageNum"></a> HasPageNum

```csharp
public bool HasPageNum { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_HasStickerCount"></a> HasStickerCount

```csharp
public bool HasStickerCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_HasStickerMax"></a> HasStickerMax

```csharp
public bool HasStickerMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_PageNum"></a> PageNum

```csharp
public uint PageNum { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCDeleteStickerbookPageRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCDeleteStickerbookPageRequest](Divine.Protobufs.Dota2.CMsgClientToGCDeleteStickerbookPageRequest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_StickerCount"></a> StickerCount

```csharp
public uint StickerCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_StickerMax"></a> StickerMax

```csharp
public uint StickerMax { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_ClearPageNum"></a> ClearPageNum\(\)

```csharp
public void ClearPageNum()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_ClearStickerCount"></a> ClearStickerCount\(\)

```csharp
public void ClearStickerCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_ClearStickerMax"></a> ClearStickerMax\(\)

```csharp
public void ClearStickerMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCDeleteStickerbookPageRequest Clone()
```

#### Returns

 [CMsgClientToGCDeleteStickerbookPageRequest](Divine.Protobufs.Dota2.CMsgClientToGCDeleteStickerbookPageRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_"></a> Equals\(CMsgClientToGCDeleteStickerbookPageRequest\)

```csharp
public bool Equals(CMsgClientToGCDeleteStickerbookPageRequest other)
```

#### Parameters

`other` [CMsgClientToGCDeleteStickerbookPageRequest](Divine.Protobufs.Dota2.CMsgClientToGCDeleteStickerbookPageRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_"></a> MergeFrom\(CMsgClientToGCDeleteStickerbookPageRequest\)

```csharp
public void MergeFrom(CMsgClientToGCDeleteStickerbookPageRequest other)
```

#### Parameters

`other` [CMsgClientToGCDeleteStickerbookPageRequest](Divine.Protobufs.Dota2.CMsgClientToGCDeleteStickerbookPageRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

