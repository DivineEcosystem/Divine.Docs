# <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment"></a> Class CMsgSocialFeedCommentsResponse.Types.FeedComment

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSocialFeedCommentsResponse.Types.FeedComment : IMessage<CMsgSocialFeedCommentsResponse.Types.FeedComment>, IEquatable<CMsgSocialFeedCommentsResponse.Types.FeedComment>, IDeepCloneable<CMsgSocialFeedCommentsResponse.Types.FeedComment>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSocialFeedCommentsResponse.Types.FeedComment](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.Types.FeedComment.md)

#### Implements

IMessage<CMsgSocialFeedCommentsResponse.Types.FeedComment\>, 
[IEquatable<CMsgSocialFeedCommentsResponse.Types.FeedComment\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSocialFeedCommentsResponse.Types.FeedComment\>, 
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
[EnumerableExtensions.In<CMsgSocialFeedCommentsResponse.Types.FeedComment\>\(CMsgSocialFeedCommentsResponse.Types.FeedComment, params CMsgSocialFeedCommentsResponse.Types.FeedComment\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment__ctor"></a> FeedComment\(\)

```csharp
public FeedComment()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment__ctor_Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_"></a> FeedComment\(FeedComment\)

```csharp
public FeedComment(CMsgSocialFeedCommentsResponse.Types.FeedComment other)
```

#### Parameters

`other` [CMsgSocialFeedCommentsResponse](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.Types.md).[FeedComment](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.Types.FeedComment.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_CommenterAccountIdFieldNumber"></a> CommenterAccountIdFieldNumber

```csharp
public const int CommenterAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_CommentTextFieldNumber"></a> CommentTextFieldNumber

```csharp
public const int CommentTextFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_CommenterAccountId"></a> CommenterAccountId

```csharp
public uint CommenterAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_CommentText"></a> CommentText

```csharp
public string CommentText { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_HasCommenterAccountId"></a> HasCommenterAccountId

```csharp
public bool HasCommenterAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_HasCommentText"></a> HasCommentText

```csharp
public bool HasCommentText { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSocialFeedCommentsResponse.Types.FeedComment> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSocialFeedCommentsResponse](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.Types.md).[FeedComment](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.Types.FeedComment.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_ClearCommenterAccountId"></a> ClearCommenterAccountId\(\)

```csharp
public void ClearCommenterAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_ClearCommentText"></a> ClearCommentText\(\)

```csharp
public void ClearCommentText()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_Clone"></a> Clone\(\)

```csharp
public CMsgSocialFeedCommentsResponse.Types.FeedComment Clone()
```

#### Returns

 [CMsgSocialFeedCommentsResponse](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.Types.md).[FeedComment](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.Types.FeedComment.md)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_Equals_Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_"></a> Equals\(FeedComment\)

```csharp
public bool Equals(CMsgSocialFeedCommentsResponse.Types.FeedComment other)
```

#### Parameters

`other` [CMsgSocialFeedCommentsResponse](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.Types.md).[FeedComment](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.Types.FeedComment.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_MergeFrom_Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_"></a> MergeFrom\(FeedComment\)

```csharp
public void MergeFrom(CMsgSocialFeedCommentsResponse.Types.FeedComment other)
```

#### Parameters

`other` [CMsgSocialFeedCommentsResponse](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.Types.md).[FeedComment](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.Types.FeedComment.md)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Types_FeedComment_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

