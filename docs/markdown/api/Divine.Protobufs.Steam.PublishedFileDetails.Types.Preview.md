# <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview"></a> Class PublishedFileDetails.Types.Preview

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class PublishedFileDetails.Types.Preview : IMessage<PublishedFileDetails.Types.Preview>, IEquatable<PublishedFileDetails.Types.Preview>, IDeepCloneable<PublishedFileDetails.Types.Preview>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PublishedFileDetails.Types.Preview](Divine.Protobufs.Steam.PublishedFileDetails.Types.Preview.md)

#### Implements

IMessage<PublishedFileDetails.Types.Preview\>, 
[IEquatable<PublishedFileDetails.Types.Preview\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<PublishedFileDetails.Types.Preview\>, 
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
[EnumerableExtensions.In<PublishedFileDetails.Types.Preview\>\(PublishedFileDetails.Types.Preview, params PublishedFileDetails.Types.Preview\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview__ctor"></a> Preview\(\)

```csharp
public Preview()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview__ctor_Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_"></a> Preview\(Preview\)

```csharp
public Preview(PublishedFileDetails.Types.Preview other)
```

#### Parameters

`other` [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[Preview](Divine.Protobufs.Steam.PublishedFileDetails.Types.Preview.md)

## Fields

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_FilenameFieldNumber"></a> FilenameFieldNumber

```csharp
public const int FilenameFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_PreviewidFieldNumber"></a> PreviewidFieldNumber

```csharp
public const int PreviewidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_SizeFieldNumber"></a> SizeFieldNumber

```csharp
public const int SizeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_SortorderFieldNumber"></a> SortorderFieldNumber

```csharp
public const int SortorderFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_UrlFieldNumber"></a> UrlFieldNumber

```csharp
public const int UrlFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_YoutubevideoidFieldNumber"></a> YoutubevideoidFieldNumber

```csharp
public const int YoutubevideoidFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_Filename"></a> Filename

```csharp
public string Filename { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_HasFilename"></a> HasFilename

```csharp
public bool HasFilename { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_HasPreviewid"></a> HasPreviewid

```csharp
public bool HasPreviewid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_HasSize"></a> HasSize

```csharp
public bool HasSize { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_HasSortorder"></a> HasSortorder

```csharp
public bool HasSortorder { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_HasUrl"></a> HasUrl

```csharp
public bool HasUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_HasYoutubevideoid"></a> HasYoutubevideoid

```csharp
public bool HasYoutubevideoid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_Parser"></a> Parser

```csharp
public static MessageParser<PublishedFileDetails.Types.Preview> Parser { get; }
```

#### Property Value

 MessageParser<[PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[Preview](Divine.Protobufs.Steam.PublishedFileDetails.Types.Preview.md)\>

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_Previewid"></a> Previewid

```csharp
public ulong Previewid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_Size"></a> Size

```csharp
public uint Size { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_Sortorder"></a> Sortorder

```csharp
public uint Sortorder { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_Url"></a> Url

```csharp
public string Url { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_Youtubevideoid"></a> Youtubevideoid

```csharp
public string Youtubevideoid { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_ClearFilename"></a> ClearFilename\(\)

```csharp
public void ClearFilename()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_ClearPreviewid"></a> ClearPreviewid\(\)

```csharp
public void ClearPreviewid()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_ClearSize"></a> ClearSize\(\)

```csharp
public void ClearSize()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_ClearSortorder"></a> ClearSortorder\(\)

```csharp
public void ClearSortorder()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_ClearUrl"></a> ClearUrl\(\)

```csharp
public void ClearUrl()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_ClearYoutubevideoid"></a> ClearYoutubevideoid\(\)

```csharp
public void ClearYoutubevideoid()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_Clone"></a> Clone\(\)

```csharp
public PublishedFileDetails.Types.Preview Clone()
```

#### Returns

 [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[Preview](Divine.Protobufs.Steam.PublishedFileDetails.Types.Preview.md)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_Equals_Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_"></a> Equals\(Preview\)

```csharp
public bool Equals(PublishedFileDetails.Types.Preview other)
```

#### Parameters

`other` [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[Preview](Divine.Protobufs.Steam.PublishedFileDetails.Types.Preview.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_MergeFrom_Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_"></a> MergeFrom\(Preview\)

```csharp
public void MergeFrom(PublishedFileDetails.Types.Preview other)
```

#### Parameters

`other` [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[Preview](Divine.Protobufs.Steam.PublishedFileDetails.Types.Preview.md)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Preview_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

