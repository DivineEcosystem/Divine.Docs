# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest"></a> Class CMsgClientToGCSocialFeedPostCommentRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSocialFeedPostCommentRequest : IMessage<CMsgClientToGCSocialFeedPostCommentRequest>, IEquatable<CMsgClientToGCSocialFeedPostCommentRequest>, IDeepCloneable<CMsgClientToGCSocialFeedPostCommentRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSocialFeedPostCommentRequest](Divine.Protobufs.Dota2.CMsgClientToGCSocialFeedPostCommentRequest.md)

#### Implements

IMessage<CMsgClientToGCSocialFeedPostCommentRequest\>, 
[IEquatable<CMsgClientToGCSocialFeedPostCommentRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSocialFeedPostCommentRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSocialFeedPostCommentRequest\>\(CMsgClientToGCSocialFeedPostCommentRequest, params CMsgClientToGCSocialFeedPostCommentRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest__ctor"></a> CMsgClientToGCSocialFeedPostCommentRequest\(\)

```csharp
public CMsgClientToGCSocialFeedPostCommentRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_"></a> CMsgClientToGCSocialFeedPostCommentRequest\(CMsgClientToGCSocialFeedPostCommentRequest\)

```csharp
public CMsgClientToGCSocialFeedPostCommentRequest(CMsgClientToGCSocialFeedPostCommentRequest other)
```

#### Parameters

`other` [CMsgClientToGCSocialFeedPostCommentRequest](Divine.Protobufs.Dota2.CMsgClientToGCSocialFeedPostCommentRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_CommentFieldNumber"></a> CommentFieldNumber

```csharp
public const int CommentFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_Comment"></a> Comment

```csharp
public string Comment { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_EventId"></a> EventId

```csharp
public ulong EventId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_HasComment"></a> HasComment

```csharp
public bool HasComment { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSocialFeedPostCommentRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSocialFeedPostCommentRequest](Divine.Protobufs.Dota2.CMsgClientToGCSocialFeedPostCommentRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_ClearComment"></a> ClearComment\(\)

```csharp
public void ClearComment()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSocialFeedPostCommentRequest Clone()
```

#### Returns

 [CMsgClientToGCSocialFeedPostCommentRequest](Divine.Protobufs.Dota2.CMsgClientToGCSocialFeedPostCommentRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_"></a> Equals\(CMsgClientToGCSocialFeedPostCommentRequest\)

```csharp
public bool Equals(CMsgClientToGCSocialFeedPostCommentRequest other)
```

#### Parameters

`other` [CMsgClientToGCSocialFeedPostCommentRequest](Divine.Protobufs.Dota2.CMsgClientToGCSocialFeedPostCommentRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_"></a> MergeFrom\(CMsgClientToGCSocialFeedPostCommentRequest\)

```csharp
public void MergeFrom(CMsgClientToGCSocialFeedPostCommentRequest other)
```

#### Parameters

`other` [CMsgClientToGCSocialFeedPostCommentRequest](Divine.Protobufs.Dota2.CMsgClientToGCSocialFeedPostCommentRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSocialFeedPostCommentRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

