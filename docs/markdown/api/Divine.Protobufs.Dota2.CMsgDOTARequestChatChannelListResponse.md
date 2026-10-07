# <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse"></a> Class CMsgDOTARequestChatChannelListResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARequestChatChannelListResponse : IMessage<CMsgDOTARequestChatChannelListResponse>, IEquatable<CMsgDOTARequestChatChannelListResponse>, IDeepCloneable<CMsgDOTARequestChatChannelListResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARequestChatChannelListResponse](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.md)

#### Implements

IMessage<CMsgDOTARequestChatChannelListResponse\>, 
[IEquatable<CMsgDOTARequestChatChannelListResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARequestChatChannelListResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTARequestChatChannelListResponse\>\(CMsgDOTARequestChatChannelListResponse, params CMsgDOTARequestChatChannelListResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse__ctor"></a> CMsgDOTARequestChatChannelListResponse\(\)

```csharp
public CMsgDOTARequestChatChannelListResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_"></a> CMsgDOTARequestChatChannelListResponse\(CMsgDOTARequestChatChannelListResponse\)

```csharp
public CMsgDOTARequestChatChannelListResponse(CMsgDOTARequestChatChannelListResponse other)
```

#### Parameters

`other` [CMsgDOTARequestChatChannelListResponse](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_ChannelsFieldNumber"></a> ChannelsFieldNumber

```csharp
public const int ChannelsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Channels"></a> Channels

```csharp
public RepeatedField<CMsgDOTARequestChatChannelListResponse.Types.ChatChannel> Channels { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTARequestChatChannelListResponse](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.Types.md).[ChatChannel](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.Types.ChatChannel.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARequestChatChannelListResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARequestChatChannelListResponse](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARequestChatChannelListResponse Clone()
```

#### Returns

 [CMsgDOTARequestChatChannelListResponse](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_"></a> Equals\(CMsgDOTARequestChatChannelListResponse\)

```csharp
public bool Equals(CMsgDOTARequestChatChannelListResponse other)
```

#### Parameters

`other` [CMsgDOTARequestChatChannelListResponse](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_"></a> MergeFrom\(CMsgDOTARequestChatChannelListResponse\)

```csharp
public void MergeFrom(CMsgDOTARequestChatChannelListResponse other)
```

#### Parameters

`other` [CMsgDOTARequestChatChannelListResponse](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

