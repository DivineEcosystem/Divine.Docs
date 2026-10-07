# <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent"></a> Class CMsgSocialFeedResponse.Types.FeedEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSocialFeedResponse.Types.FeedEvent : IMessage<CMsgSocialFeedResponse.Types.FeedEvent>, IEquatable<CMsgSocialFeedResponse.Types.FeedEvent>, IDeepCloneable<CMsgSocialFeedResponse.Types.FeedEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSocialFeedResponse.Types.FeedEvent](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.Types.FeedEvent.md)

#### Implements

IMessage<CMsgSocialFeedResponse.Types.FeedEvent\>, 
[IEquatable<CMsgSocialFeedResponse.Types.FeedEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSocialFeedResponse.Types.FeedEvent\>, 
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
[EnumerableExtensions.In<CMsgSocialFeedResponse.Types.FeedEvent\>\(CMsgSocialFeedResponse.Types.FeedEvent, params CMsgSocialFeedResponse.Types.FeedEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent__ctor"></a> FeedEvent\(\)

```csharp
public FeedEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent__ctor_Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_"></a> FeedEvent\(FeedEvent\)

```csharp
public FeedEvent(CMsgSocialFeedResponse.Types.FeedEvent other)
```

#### Parameters

`other` [CMsgSocialFeedResponse](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.Types.md).[FeedEvent](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.Types.FeedEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_CommentCountFieldNumber"></a> CommentCountFieldNumber

```csharp
public const int CommentCountFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_EventSubTypeFieldNumber"></a> EventSubTypeFieldNumber

```csharp
public const int EventSubTypeFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_EventTypeFieldNumber"></a> EventTypeFieldNumber

```csharp
public const int EventTypeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_FeedEventIdFieldNumber"></a> FeedEventIdFieldNumber

```csharp
public const int FeedEventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ParamBigInt1FieldNumber"></a> ParamBigInt1FieldNumber

```csharp
public const int ParamBigInt1FieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ParamInt1FieldNumber"></a> ParamInt1FieldNumber

```csharp
public const int ParamInt1FieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ParamInt2FieldNumber"></a> ParamInt2FieldNumber

```csharp
public const int ParamInt2FieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ParamInt3FieldNumber"></a> ParamInt3FieldNumber

```csharp
public const int ParamInt3FieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ParamStringFieldNumber"></a> ParamStringFieldNumber

```csharp
public const int ParamStringFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_CommentCount"></a> CommentCount

```csharp
public uint CommentCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_EventSubType"></a> EventSubType

```csharp
public uint EventSubType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_EventType"></a> EventType

```csharp
public uint EventType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_FeedEventId"></a> FeedEventId

```csharp
public ulong FeedEventId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_HasCommentCount"></a> HasCommentCount

```csharp
public bool HasCommentCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_HasEventSubType"></a> HasEventSubType

```csharp
public bool HasEventSubType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_HasEventType"></a> HasEventType

```csharp
public bool HasEventType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_HasFeedEventId"></a> HasFeedEventId

```csharp
public bool HasFeedEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_HasParamBigInt1"></a> HasParamBigInt1

```csharp
public bool HasParamBigInt1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_HasParamInt1"></a> HasParamInt1

```csharp
public bool HasParamInt1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_HasParamInt2"></a> HasParamInt2

```csharp
public bool HasParamInt2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_HasParamInt3"></a> HasParamInt3

```csharp
public bool HasParamInt3 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_HasParamString"></a> HasParamString

```csharp
public bool HasParamString { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ParamBigInt1"></a> ParamBigInt1

```csharp
public ulong ParamBigInt1 { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ParamInt1"></a> ParamInt1

```csharp
public uint ParamInt1 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ParamInt2"></a> ParamInt2

```csharp
public uint ParamInt2 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ParamInt3"></a> ParamInt3

```csharp
public uint ParamInt3 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ParamString"></a> ParamString

```csharp
public string ParamString { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSocialFeedResponse.Types.FeedEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSocialFeedResponse](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.Types.md).[FeedEvent](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.Types.FeedEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ClearCommentCount"></a> ClearCommentCount\(\)

```csharp
public void ClearCommentCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ClearEventSubType"></a> ClearEventSubType\(\)

```csharp
public void ClearEventSubType()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ClearEventType"></a> ClearEventType\(\)

```csharp
public void ClearEventType()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ClearFeedEventId"></a> ClearFeedEventId\(\)

```csharp
public void ClearFeedEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ClearParamBigInt1"></a> ClearParamBigInt1\(\)

```csharp
public void ClearParamBigInt1()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ClearParamInt1"></a> ClearParamInt1\(\)

```csharp
public void ClearParamInt1()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ClearParamInt2"></a> ClearParamInt2\(\)

```csharp
public void ClearParamInt2()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ClearParamInt3"></a> ClearParamInt3\(\)

```csharp
public void ClearParamInt3()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ClearParamString"></a> ClearParamString\(\)

```csharp
public void ClearParamString()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_Clone"></a> Clone\(\)

```csharp
public CMsgSocialFeedResponse.Types.FeedEvent Clone()
```

#### Returns

 [CMsgSocialFeedResponse](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.Types.md).[FeedEvent](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.Types.FeedEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_Equals_Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_"></a> Equals\(FeedEvent\)

```csharp
public bool Equals(CMsgSocialFeedResponse.Types.FeedEvent other)
```

#### Parameters

`other` [CMsgSocialFeedResponse](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.Types.md).[FeedEvent](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.Types.FeedEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_MergeFrom_Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_"></a> MergeFrom\(FeedEvent\)

```csharp
public void MergeFrom(CMsgSocialFeedResponse.Types.FeedEvent other)
```

#### Parameters

`other` [CMsgSocialFeedResponse](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.Types.md).[FeedEvent](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.Types.FeedEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Types_FeedEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

