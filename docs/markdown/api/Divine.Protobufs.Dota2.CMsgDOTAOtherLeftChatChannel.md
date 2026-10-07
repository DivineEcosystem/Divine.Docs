# <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel"></a> Class CMsgDOTAOtherLeftChatChannel

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAOtherLeftChatChannel : IMessage<CMsgDOTAOtherLeftChatChannel>, IEquatable<CMsgDOTAOtherLeftChatChannel>, IDeepCloneable<CMsgDOTAOtherLeftChatChannel>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAOtherLeftChatChannel](Divine.Protobufs.Dota2.CMsgDOTAOtherLeftChatChannel.md)

#### Implements

IMessage<CMsgDOTAOtherLeftChatChannel\>, 
[IEquatable<CMsgDOTAOtherLeftChatChannel\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAOtherLeftChatChannel\>, 
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
[EnumerableExtensions.In<CMsgDOTAOtherLeftChatChannel\>\(CMsgDOTAOtherLeftChatChannel, params CMsgDOTAOtherLeftChatChannel\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel__ctor"></a> CMsgDOTAOtherLeftChatChannel\(\)

```csharp
public CMsgDOTAOtherLeftChatChannel()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel__ctor_Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_"></a> CMsgDOTAOtherLeftChatChannel\(CMsgDOTAOtherLeftChatChannel\)

```csharp
public CMsgDOTAOtherLeftChatChannel(CMsgDOTAOtherLeftChatChannel other)
```

#### Parameters

`other` [CMsgDOTAOtherLeftChatChannel](Divine.Protobufs.Dota2.CMsgDOTAOtherLeftChatChannel.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_ChannelIdFieldNumber"></a> ChannelIdFieldNumber

```csharp
public const int ChannelIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_ChannelUserIdFieldNumber"></a> ChannelUserIdFieldNumber

```csharp
public const int ChannelUserIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_ChannelId"></a> ChannelId

```csharp
public ulong ChannelId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_ChannelUserId"></a> ChannelUserId

```csharp
public uint ChannelUserId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_HasChannelId"></a> HasChannelId

```csharp
public bool HasChannelId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_HasChannelUserId"></a> HasChannelUserId

```csharp
public bool HasChannelUserId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_HasSteamId"></a> HasSteamId

```csharp
public bool HasSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAOtherLeftChatChannel> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAOtherLeftChatChannel](Divine.Protobufs.Dota2.CMsgDOTAOtherLeftChatChannel.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_SteamId"></a> SteamId

```csharp
public ulong SteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_ClearChannelId"></a> ClearChannelId\(\)

```csharp
public void ClearChannelId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_ClearChannelUserId"></a> ClearChannelUserId\(\)

```csharp
public void ClearChannelUserId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_ClearSteamId"></a> ClearSteamId\(\)

```csharp
public void ClearSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAOtherLeftChatChannel Clone()
```

#### Returns

 [CMsgDOTAOtherLeftChatChannel](Divine.Protobufs.Dota2.CMsgDOTAOtherLeftChatChannel.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_Equals_Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_"></a> Equals\(CMsgDOTAOtherLeftChatChannel\)

```csharp
public bool Equals(CMsgDOTAOtherLeftChatChannel other)
```

#### Parameters

`other` [CMsgDOTAOtherLeftChatChannel](Divine.Protobufs.Dota2.CMsgDOTAOtherLeftChatChannel.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_"></a> MergeFrom\(CMsgDOTAOtherLeftChatChannel\)

```csharp
public void MergeFrom(CMsgDOTAOtherLeftChatChannel other)
```

#### Parameters

`other` [CMsgDOTAOtherLeftChatChannel](Divine.Protobufs.Dota2.CMsgDOTAOtherLeftChatChannel.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherLeftChatChannel_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

