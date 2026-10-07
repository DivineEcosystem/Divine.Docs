# <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request"></a> Class CPublishedFile\_Unsubscribe\_Request

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPublishedFile_Unsubscribe_Request : IMessage<CPublishedFile_Unsubscribe_Request>, IEquatable<CPublishedFile_Unsubscribe_Request>, IDeepCloneable<CPublishedFile_Unsubscribe_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPublishedFile\_Unsubscribe\_Request](Divine.Protobufs.Steam.CPublishedFile\_Unsubscribe\_Request.md)

#### Implements

IMessage<CPublishedFile\_Unsubscribe\_Request\>, 
[IEquatable<CPublishedFile\_Unsubscribe\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPublishedFile\_Unsubscribe\_Request\>, 
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
[EnumerableExtensions.In<CPublishedFile\_Unsubscribe\_Request\>\(CPublishedFile\_Unsubscribe\_Request, params CPublishedFile\_Unsubscribe\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request__ctor"></a> CPublishedFile\_Unsubscribe\_Request\(\)

```csharp
public CPublishedFile_Unsubscribe_Request()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request__ctor_Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_"></a> CPublishedFile\_Unsubscribe\_Request\(CPublishedFile\_Unsubscribe\_Request\)

```csharp
public CPublishedFile_Unsubscribe_Request(CPublishedFile_Unsubscribe_Request other)
```

#### Parameters

`other` [CPublishedFile\_Unsubscribe\_Request](Divine.Protobufs.Steam.CPublishedFile\_Unsubscribe\_Request.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_ListTypeFieldNumber"></a> ListTypeFieldNumber

```csharp
public const int ListTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_NotifyClientFieldNumber"></a> NotifyClientFieldNumber

```csharp
public const int NotifyClientFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_PublishedfileidFieldNumber"></a> PublishedfileidFieldNumber

```csharp
public const int PublishedfileidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_Appid"></a> Appid

```csharp
public int Appid { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_HasListType"></a> HasListType

```csharp
public bool HasListType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_HasNotifyClient"></a> HasNotifyClient

```csharp
public bool HasNotifyClient { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_HasPublishedfileid"></a> HasPublishedfileid

```csharp
public bool HasPublishedfileid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_ListType"></a> ListType

```csharp
public uint ListType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_NotifyClient"></a> NotifyClient

```csharp
public bool NotifyClient { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_Parser"></a> Parser

```csharp
public static MessageParser<CPublishedFile_Unsubscribe_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CPublishedFile\_Unsubscribe\_Request](Divine.Protobufs.Steam.CPublishedFile\_Unsubscribe\_Request.md)\>

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_Publishedfileid"></a> Publishedfileid

```csharp
public ulong Publishedfileid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_ClearListType"></a> ClearListType\(\)

```csharp
public void ClearListType()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_ClearNotifyClient"></a> ClearNotifyClient\(\)

```csharp
public void ClearNotifyClient()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_ClearPublishedfileid"></a> ClearPublishedfileid\(\)

```csharp
public void ClearPublishedfileid()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_Clone"></a> Clone\(\)

```csharp
public CPublishedFile_Unsubscribe_Request Clone()
```

#### Returns

 [CPublishedFile\_Unsubscribe\_Request](Divine.Protobufs.Steam.CPublishedFile\_Unsubscribe\_Request.md)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_Equals_Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_"></a> Equals\(CPublishedFile\_Unsubscribe\_Request\)

```csharp
public bool Equals(CPublishedFile_Unsubscribe_Request other)
```

#### Parameters

`other` [CPublishedFile\_Unsubscribe\_Request](Divine.Protobufs.Steam.CPublishedFile\_Unsubscribe\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_MergeFrom_Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_"></a> MergeFrom\(CPublishedFile\_Unsubscribe\_Request\)

```csharp
public void MergeFrom(CPublishedFile_Unsubscribe_Request other)
```

#### Parameters

`other` [CPublishedFile\_Unsubscribe\_Request](Divine.Protobufs.Steam.CPublishedFile\_Unsubscribe\_Request.md)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPublishedFile_Unsubscribe_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

