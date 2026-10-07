# <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request"></a> Class CPublishedFile\_Update\_Request

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPublishedFile_Update_Request : IMessage<CPublishedFile_Update_Request>, IEquatable<CPublishedFile_Update_Request>, IDeepCloneable<CPublishedFile_Update_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPublishedFile\_Update\_Request](Divine.Protobufs.Steam.CPublishedFile\_Update\_Request.md)

#### Implements

IMessage<CPublishedFile\_Update\_Request\>, 
[IEquatable<CPublishedFile\_Update\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPublishedFile\_Update\_Request\>, 
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
[EnumerableExtensions.In<CPublishedFile\_Update\_Request\>\(CPublishedFile\_Update\_Request, params CPublishedFile\_Update\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request__ctor"></a> CPublishedFile\_Update\_Request\(\)

```csharp
public CPublishedFile_Update_Request()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request__ctor_Divine_Protobufs_Steam_CPublishedFile_Update_Request_"></a> CPublishedFile\_Update\_Request\(CPublishedFile\_Update\_Request\)

```csharp
public CPublishedFile_Update_Request(CPublishedFile_Update_Request other)
```

#### Parameters

`other` [CPublishedFile\_Update\_Request](Divine.Protobufs.Steam.CPublishedFile\_Update\_Request.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_FileDescriptionFieldNumber"></a> FileDescriptionFieldNumber

```csharp
public const int FileDescriptionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_FilenameFieldNumber"></a> FilenameFieldNumber

```csharp
public const int FilenameFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_PreviewFilenameFieldNumber"></a> PreviewFilenameFieldNumber

```csharp
public const int PreviewFilenameFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_PublishedfileidFieldNumber"></a> PublishedfileidFieldNumber

```csharp
public const int PublishedfileidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_TagsFieldNumber"></a> TagsFieldNumber

```csharp
public const int TagsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_TitleFieldNumber"></a> TitleFieldNumber

```csharp
public const int TitleFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_VisibilityFieldNumber"></a> VisibilityFieldNumber

```csharp
public const int VisibilityFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_FileDescription"></a> FileDescription

```csharp
public string FileDescription { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_Filename"></a> Filename

```csharp
public string Filename { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_HasFileDescription"></a> HasFileDescription

```csharp
public bool HasFileDescription { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_HasFilename"></a> HasFilename

```csharp
public bool HasFilename { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_HasPreviewFilename"></a> HasPreviewFilename

```csharp
public bool HasPreviewFilename { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_HasPublishedfileid"></a> HasPublishedfileid

```csharp
public bool HasPublishedfileid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_HasTitle"></a> HasTitle

```csharp
public bool HasTitle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_HasVisibility"></a> HasVisibility

```csharp
public bool HasVisibility { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_Parser"></a> Parser

```csharp
public static MessageParser<CPublishedFile_Update_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CPublishedFile\_Update\_Request](Divine.Protobufs.Steam.CPublishedFile\_Update\_Request.md)\>

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_PreviewFilename"></a> PreviewFilename

```csharp
public string PreviewFilename { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_Publishedfileid"></a> Publishedfileid

```csharp
public ulong Publishedfileid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_Tags"></a> Tags

```csharp
public RepeatedField<string> Tags { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_Title"></a> Title

```csharp
public string Title { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_Visibility"></a> Visibility

```csharp
public uint Visibility { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_ClearFileDescription"></a> ClearFileDescription\(\)

```csharp
public void ClearFileDescription()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_ClearFilename"></a> ClearFilename\(\)

```csharp
public void ClearFilename()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_ClearPreviewFilename"></a> ClearPreviewFilename\(\)

```csharp
public void ClearPreviewFilename()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_ClearPublishedfileid"></a> ClearPublishedfileid\(\)

```csharp
public void ClearPublishedfileid()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_ClearTitle"></a> ClearTitle\(\)

```csharp
public void ClearTitle()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_ClearVisibility"></a> ClearVisibility\(\)

```csharp
public void ClearVisibility()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_Clone"></a> Clone\(\)

```csharp
public CPublishedFile_Update_Request Clone()
```

#### Returns

 [CPublishedFile\_Update\_Request](Divine.Protobufs.Steam.CPublishedFile\_Update\_Request.md)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_Equals_Divine_Protobufs_Steam_CPublishedFile_Update_Request_"></a> Equals\(CPublishedFile\_Update\_Request\)

```csharp
public bool Equals(CPublishedFile_Update_Request other)
```

#### Parameters

`other` [CPublishedFile\_Update\_Request](Divine.Protobufs.Steam.CPublishedFile\_Update\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_MergeFrom_Divine_Protobufs_Steam_CPublishedFile_Update_Request_"></a> MergeFrom\(CPublishedFile\_Update\_Request\)

```csharp
public void MergeFrom(CPublishedFile_Update_Request other)
```

#### Parameters

`other` [CPublishedFile\_Update\_Request](Divine.Protobufs.Steam.CPublishedFile\_Update\_Request.md)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Update_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

