# <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request"></a> Class CPublishedFile\_RefreshVotingQueue\_Request

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPublishedFile_RefreshVotingQueue_Request : IMessage<CPublishedFile_RefreshVotingQueue_Request>, IEquatable<CPublishedFile_RefreshVotingQueue_Request>, IDeepCloneable<CPublishedFile_RefreshVotingQueue_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPublishedFile\_RefreshVotingQueue\_Request](Divine.Protobufs.Steam.CPublishedFile\_RefreshVotingQueue\_Request.md)

#### Implements

IMessage<CPublishedFile\_RefreshVotingQueue\_Request\>, 
[IEquatable<CPublishedFile\_RefreshVotingQueue\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPublishedFile\_RefreshVotingQueue\_Request\>, 
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
[EnumerableExtensions.In<CPublishedFile\_RefreshVotingQueue\_Request\>\(CPublishedFile\_RefreshVotingQueue\_Request, params CPublishedFile\_RefreshVotingQueue\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request__ctor"></a> CPublishedFile\_RefreshVotingQueue\_Request\(\)

```csharp
public CPublishedFile_RefreshVotingQueue_Request()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request__ctor_Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_"></a> CPublishedFile\_RefreshVotingQueue\_Request\(CPublishedFile\_RefreshVotingQueue\_Request\)

```csharp
public CPublishedFile_RefreshVotingQueue_Request(CPublishedFile_RefreshVotingQueue_Request other)
```

#### Parameters

`other` [CPublishedFile\_RefreshVotingQueue\_Request](Divine.Protobufs.Steam.CPublishedFile\_RefreshVotingQueue\_Request.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_DesiredQueueSizeFieldNumber"></a> DesiredQueueSizeFieldNumber

```csharp
public const int DesiredQueueSizeFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_ExcludedTagsFieldNumber"></a> ExcludedTagsFieldNumber

```csharp
public const int ExcludedTagsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_MatchAllTagsFieldNumber"></a> MatchAllTagsFieldNumber

```csharp
public const int MatchAllTagsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_MatchingFileTypeFieldNumber"></a> MatchingFileTypeFieldNumber

```csharp
public const int MatchingFileTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_TagsFieldNumber"></a> TagsFieldNumber

```csharp
public const int TagsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_DesiredQueueSize"></a> DesiredQueueSize

```csharp
public uint DesiredQueueSize { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_ExcludedTags"></a> ExcludedTags

```csharp
public RepeatedField<string> ExcludedTags { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_HasDesiredQueueSize"></a> HasDesiredQueueSize

```csharp
public bool HasDesiredQueueSize { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_HasMatchAllTags"></a> HasMatchAllTags

```csharp
public bool HasMatchAllTags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_HasMatchingFileType"></a> HasMatchingFileType

```csharp
public bool HasMatchingFileType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_MatchAllTags"></a> MatchAllTags

```csharp
public bool MatchAllTags { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_MatchingFileType"></a> MatchingFileType

```csharp
public uint MatchingFileType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_Parser"></a> Parser

```csharp
public static MessageParser<CPublishedFile_RefreshVotingQueue_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CPublishedFile\_RefreshVotingQueue\_Request](Divine.Protobufs.Steam.CPublishedFile\_RefreshVotingQueue\_Request.md)\>

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_Tags"></a> Tags

```csharp
public RepeatedField<string> Tags { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## Methods

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_ClearDesiredQueueSize"></a> ClearDesiredQueueSize\(\)

```csharp
public void ClearDesiredQueueSize()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_ClearMatchAllTags"></a> ClearMatchAllTags\(\)

```csharp
public void ClearMatchAllTags()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_ClearMatchingFileType"></a> ClearMatchingFileType\(\)

```csharp
public void ClearMatchingFileType()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_Clone"></a> Clone\(\)

```csharp
public CPublishedFile_RefreshVotingQueue_Request Clone()
```

#### Returns

 [CPublishedFile\_RefreshVotingQueue\_Request](Divine.Protobufs.Steam.CPublishedFile\_RefreshVotingQueue\_Request.md)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_Equals_Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_"></a> Equals\(CPublishedFile\_RefreshVotingQueue\_Request\)

```csharp
public bool Equals(CPublishedFile_RefreshVotingQueue_Request other)
```

#### Parameters

`other` [CPublishedFile\_RefreshVotingQueue\_Request](Divine.Protobufs.Steam.CPublishedFile\_RefreshVotingQueue\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_MergeFrom_Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_"></a> MergeFrom\(CPublishedFile\_RefreshVotingQueue\_Request\)

```csharp
public void MergeFrom(CPublishedFile_RefreshVotingQueue_Request other)
```

#### Parameters

`other` [CPublishedFile\_RefreshVotingQueue\_Request](Divine.Protobufs.Steam.CPublishedFile\_RefreshVotingQueue\_Request.md)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPublishedFile_RefreshVotingQueue_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

