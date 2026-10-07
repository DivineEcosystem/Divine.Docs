# <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse"></a> Class CMsgSocialFeedResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSocialFeedResponse : IMessage<CMsgSocialFeedResponse>, IEquatable<CMsgSocialFeedResponse>, IDeepCloneable<CMsgSocialFeedResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSocialFeedResponse](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.md)

#### Implements

IMessage<CMsgSocialFeedResponse\>, 
[IEquatable<CMsgSocialFeedResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSocialFeedResponse\>, 
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
[EnumerableExtensions.In<CMsgSocialFeedResponse\>\(CMsgSocialFeedResponse, params CMsgSocialFeedResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse__ctor"></a> CMsgSocialFeedResponse\(\)

```csharp
public CMsgSocialFeedResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse__ctor_Divine_Protobufs_Dota2_CMsgSocialFeedResponse_"></a> CMsgSocialFeedResponse\(CMsgSocialFeedResponse\)

```csharp
public CMsgSocialFeedResponse(CMsgSocialFeedResponse other)
```

#### Parameters

`other` [CMsgSocialFeedResponse](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_FeedEventsFieldNumber"></a> FeedEventsFieldNumber

```csharp
public const int FeedEventsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_FeedEvents"></a> FeedEvents

```csharp
public RepeatedField<CMsgSocialFeedResponse.Types.FeedEvent> FeedEvents { get; }
```

#### Property Value

 RepeatedField<[CMsgSocialFeedResponse](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.Types.md).[FeedEvent](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.Types.FeedEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSocialFeedResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSocialFeedResponse](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Result"></a> Result

```csharp
public CMsgSocialFeedResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgSocialFeedResponse](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Clone"></a> Clone\(\)

```csharp
public CMsgSocialFeedResponse Clone()
```

#### Returns

 [CMsgSocialFeedResponse](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_Equals_Divine_Protobufs_Dota2_CMsgSocialFeedResponse_"></a> Equals\(CMsgSocialFeedResponse\)

```csharp
public bool Equals(CMsgSocialFeedResponse other)
```

#### Parameters

`other` [CMsgSocialFeedResponse](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgSocialFeedResponse_"></a> MergeFrom\(CMsgSocialFeedResponse\)

```csharp
public void MergeFrom(CMsgSocialFeedResponse other)
```

#### Parameters

`other` [CMsgSocialFeedResponse](Divine.Protobufs.Dota2.CMsgSocialFeedResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

