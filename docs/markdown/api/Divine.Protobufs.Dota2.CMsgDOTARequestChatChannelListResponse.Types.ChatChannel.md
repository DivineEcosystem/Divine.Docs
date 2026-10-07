# <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel"></a> Class CMsgDOTARequestChatChannelListResponse.Types.ChatChannel

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARequestChatChannelListResponse.Types.ChatChannel : IMessage<CMsgDOTARequestChatChannelListResponse.Types.ChatChannel>, IEquatable<CMsgDOTARequestChatChannelListResponse.Types.ChatChannel>, IDeepCloneable<CMsgDOTARequestChatChannelListResponse.Types.ChatChannel>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARequestChatChannelListResponse.Types.ChatChannel](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.Types.ChatChannel.md)

#### Implements

IMessage<CMsgDOTARequestChatChannelListResponse.Types.ChatChannel\>, 
[IEquatable<CMsgDOTARequestChatChannelListResponse.Types.ChatChannel\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARequestChatChannelListResponse.Types.ChatChannel\>, 
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
[EnumerableExtensions.In<CMsgDOTARequestChatChannelListResponse.Types.ChatChannel\>\(CMsgDOTARequestChatChannelListResponse.Types.ChatChannel, params CMsgDOTARequestChatChannelListResponse.Types.ChatChannel\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel__ctor"></a> ChatChannel\(\)

```csharp
public ChatChannel()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel__ctor_Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_"></a> ChatChannel\(ChatChannel\)

```csharp
public ChatChannel(CMsgDOTARequestChatChannelListResponse.Types.ChatChannel other)
```

#### Parameters

`other` [CMsgDOTARequestChatChannelListResponse](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.Types.md).[ChatChannel](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.Types.ChatChannel.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_ChannelNameFieldNumber"></a> ChannelNameFieldNumber

```csharp
public const int ChannelNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_ChannelTypeFieldNumber"></a> ChannelTypeFieldNumber

```csharp
public const int ChannelTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_NumMembersFieldNumber"></a> NumMembersFieldNumber

```csharp
public const int NumMembersFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_ChannelName"></a> ChannelName

```csharp
public string ChannelName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_ChannelType"></a> ChannelType

```csharp
public DOTAChatChannelType_t ChannelType { get; set; }
```

#### Property Value

 [DOTAChatChannelType\_t](Divine.Protobufs.Dota2.DOTAChatChannelType\_t.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_HasChannelName"></a> HasChannelName

```csharp
public bool HasChannelName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_HasChannelType"></a> HasChannelType

```csharp
public bool HasChannelType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_HasNumMembers"></a> HasNumMembers

```csharp
public bool HasNumMembers { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_NumMembers"></a> NumMembers

```csharp
public uint NumMembers { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARequestChatChannelListResponse.Types.ChatChannel> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARequestChatChannelListResponse](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.Types.md).[ChatChannel](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.Types.ChatChannel.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_ClearChannelName"></a> ClearChannelName\(\)

```csharp
public void ClearChannelName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_ClearChannelType"></a> ClearChannelType\(\)

```csharp
public void ClearChannelType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_ClearNumMembers"></a> ClearNumMembers\(\)

```csharp
public void ClearNumMembers()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARequestChatChannelListResponse.Types.ChatChannel Clone()
```

#### Returns

 [CMsgDOTARequestChatChannelListResponse](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.Types.md).[ChatChannel](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.Types.ChatChannel.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_Equals_Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_"></a> Equals\(ChatChannel\)

```csharp
public bool Equals(CMsgDOTARequestChatChannelListResponse.Types.ChatChannel other)
```

#### Parameters

`other` [CMsgDOTARequestChatChannelListResponse](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.Types.md).[ChatChannel](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.Types.ChatChannel.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_"></a> MergeFrom\(ChatChannel\)

```csharp
public void MergeFrom(CMsgDOTARequestChatChannelListResponse.Types.ChatChannel other)
```

#### Parameters

`other` [CMsgDOTARequestChatChannelListResponse](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.Types.md).[ChatChannel](Divine.Protobufs.Dota2.CMsgDOTARequestChatChannelListResponse.Types.ChatChannel.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestChatChannelListResponse_Types_ChatChannel_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

