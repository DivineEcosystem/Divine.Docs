# <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse"></a> Class CMsgSocialFeedCommentsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSocialFeedCommentsResponse : IMessage<CMsgSocialFeedCommentsResponse>, IEquatable<CMsgSocialFeedCommentsResponse>, IDeepCloneable<CMsgSocialFeedCommentsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSocialFeedCommentsResponse](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.md)

#### Implements

IMessage<CMsgSocialFeedCommentsResponse\>, 
[IEquatable<CMsgSocialFeedCommentsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSocialFeedCommentsResponse\>, 
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
[EnumerableExtensions.In<CMsgSocialFeedCommentsResponse\>\(CMsgSocialFeedCommentsResponse, params CMsgSocialFeedCommentsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse__ctor"></a> CMsgSocialFeedCommentsResponse\(\)

```csharp
public CMsgSocialFeedCommentsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse__ctor_Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_"></a> CMsgSocialFeedCommentsResponse\(CMsgSocialFeedCommentsResponse\)

```csharp
public CMsgSocialFeedCommentsResponse(CMsgSocialFeedCommentsResponse other)
```

#### Parameters

`other` [CMsgSocialFeedCommentsResponse](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_FeedCommentsFieldNumber"></a> FeedCommentsFieldNumber

```csharp
public const int FeedCommentsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_FeedComments"></a> FeedComments

```csharp
public RepeatedField<CMsgSocialFeedCommentsResponse.Types.FeedComment> FeedComments { get; }
```

#### Property Value

 RepeatedField<[CMsgSocialFeedCommentsResponse](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.Types.md).[FeedComment](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.Types.FeedComment.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSocialFeedCommentsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSocialFeedCommentsResponse](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Result"></a> Result

```csharp
public CMsgSocialFeedCommentsResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgSocialFeedCommentsResponse](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgSocialFeedCommentsResponse Clone()
```

#### Returns

 [CMsgSocialFeedCommentsResponse](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_Equals_Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_"></a> Equals\(CMsgSocialFeedCommentsResponse\)

```csharp
public bool Equals(CMsgSocialFeedCommentsResponse other)
```

#### Parameters

`other` [CMsgSocialFeedCommentsResponse](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_"></a> MergeFrom\(CMsgSocialFeedCommentsResponse\)

```csharp
public void MergeFrom(CMsgSocialFeedCommentsResponse other)
```

#### Parameters

`other` [CMsgSocialFeedCommentsResponse](Divine.Protobufs.Dota2.CMsgSocialFeedCommentsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedCommentsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

