# <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request"></a> Class CPublishedFile\_GetDetails\_Request

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPublishedFile_GetDetails_Request : IMessage<CPublishedFile_GetDetails_Request>, IEquatable<CPublishedFile_GetDetails_Request>, IDeepCloneable<CPublishedFile_GetDetails_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPublishedFile\_GetDetails\_Request](Divine.Protobufs.Steam.CPublishedFile\_GetDetails\_Request.md)

#### Implements

IMessage<CPublishedFile\_GetDetails\_Request\>, 
[IEquatable<CPublishedFile\_GetDetails\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPublishedFile\_GetDetails\_Request\>, 
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
[EnumerableExtensions.In<CPublishedFile\_GetDetails\_Request\>\(CPublishedFile\_GetDetails\_Request, params CPublishedFile\_GetDetails\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request__ctor"></a> CPublishedFile\_GetDetails\_Request\(\)

```csharp
public CPublishedFile_GetDetails_Request()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request__ctor_Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_"></a> CPublishedFile\_GetDetails\_Request\(CPublishedFile\_GetDetails\_Request\)

```csharp
public CPublishedFile_GetDetails_Request(CPublishedFile_GetDetails_Request other)
```

#### Parameters

`other` [CPublishedFile\_GetDetails\_Request](Divine.Protobufs.Steam.CPublishedFile\_GetDetails\_Request.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_IncludeadditionalpreviewsFieldNumber"></a> IncludeadditionalpreviewsFieldNumber

```csharp
public const int IncludeadditionalpreviewsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_IncludechildrenFieldNumber"></a> IncludechildrenFieldNumber

```csharp
public const int IncludechildrenFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_IncludekvtagsFieldNumber"></a> IncludekvtagsFieldNumber

```csharp
public const int IncludekvtagsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_IncludetagsFieldNumber"></a> IncludetagsFieldNumber

```csharp
public const int IncludetagsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_IncludevotesFieldNumber"></a> IncludevotesFieldNumber

```csharp
public const int IncludevotesFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_PublishedfileidsFieldNumber"></a> PublishedfileidsFieldNumber

```csharp
public const int PublishedfileidsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_ShortDescriptionFieldNumber"></a> ShortDescriptionFieldNumber

```csharp
public const int ShortDescriptionFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_HasIncludeadditionalpreviews"></a> HasIncludeadditionalpreviews

```csharp
public bool HasIncludeadditionalpreviews { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_HasIncludechildren"></a> HasIncludechildren

```csharp
public bool HasIncludechildren { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_HasIncludekvtags"></a> HasIncludekvtags

```csharp
public bool HasIncludekvtags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_HasIncludetags"></a> HasIncludetags

```csharp
public bool HasIncludetags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_HasIncludevotes"></a> HasIncludevotes

```csharp
public bool HasIncludevotes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_HasShortDescription"></a> HasShortDescription

```csharp
public bool HasShortDescription { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_Includeadditionalpreviews"></a> Includeadditionalpreviews

```csharp
public bool Includeadditionalpreviews { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_Includechildren"></a> Includechildren

```csharp
public bool Includechildren { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_Includekvtags"></a> Includekvtags

```csharp
public bool Includekvtags { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_Includetags"></a> Includetags

```csharp
public bool Includetags { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_Includevotes"></a> Includevotes

```csharp
public bool Includevotes { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_Parser"></a> Parser

```csharp
public static MessageParser<CPublishedFile_GetDetails_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CPublishedFile\_GetDetails\_Request](Divine.Protobufs.Steam.CPublishedFile\_GetDetails\_Request.md)\>

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_Publishedfileids"></a> Publishedfileids

```csharp
public RepeatedField<ulong> Publishedfileids { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_ShortDescription"></a> ShortDescription

```csharp
public bool ShortDescription { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_ClearIncludeadditionalpreviews"></a> ClearIncludeadditionalpreviews\(\)

```csharp
public void ClearIncludeadditionalpreviews()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_ClearIncludechildren"></a> ClearIncludechildren\(\)

```csharp
public void ClearIncludechildren()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_ClearIncludekvtags"></a> ClearIncludekvtags\(\)

```csharp
public void ClearIncludekvtags()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_ClearIncludetags"></a> ClearIncludetags\(\)

```csharp
public void ClearIncludetags()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_ClearIncludevotes"></a> ClearIncludevotes\(\)

```csharp
public void ClearIncludevotes()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_ClearShortDescription"></a> ClearShortDescription\(\)

```csharp
public void ClearShortDescription()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_Clone"></a> Clone\(\)

```csharp
public CPublishedFile_GetDetails_Request Clone()
```

#### Returns

 [CPublishedFile\_GetDetails\_Request](Divine.Protobufs.Steam.CPublishedFile\_GetDetails\_Request.md)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_Equals_Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_"></a> Equals\(CPublishedFile\_GetDetails\_Request\)

```csharp
public bool Equals(CPublishedFile_GetDetails_Request other)
```

#### Parameters

`other` [CPublishedFile\_GetDetails\_Request](Divine.Protobufs.Steam.CPublishedFile\_GetDetails\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_MergeFrom_Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_"></a> MergeFrom\(CPublishedFile\_GetDetails\_Request\)

```csharp
public void MergeFrom(CPublishedFile_GetDetails_Request other)
```

#### Parameters

`other` [CPublishedFile\_GetDetails\_Request](Divine.Protobufs.Steam.CPublishedFile\_GetDetails\_Request.md)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

