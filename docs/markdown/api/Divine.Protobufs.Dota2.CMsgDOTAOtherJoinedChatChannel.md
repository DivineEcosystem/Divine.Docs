# <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel"></a> Class CMsgDOTAOtherJoinedChatChannel

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAOtherJoinedChatChannel : IMessage<CMsgDOTAOtherJoinedChatChannel>, IEquatable<CMsgDOTAOtherJoinedChatChannel>, IDeepCloneable<CMsgDOTAOtherJoinedChatChannel>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAOtherJoinedChatChannel](Divine.Protobufs.Dota2.CMsgDOTAOtherJoinedChatChannel.md)

#### Implements

IMessage<CMsgDOTAOtherJoinedChatChannel\>, 
[IEquatable<CMsgDOTAOtherJoinedChatChannel\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAOtherJoinedChatChannel\>, 
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
[EnumerableExtensions.In<CMsgDOTAOtherJoinedChatChannel\>\(CMsgDOTAOtherJoinedChatChannel, params CMsgDOTAOtherJoinedChatChannel\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel__ctor"></a> CMsgDOTAOtherJoinedChatChannel\(\)

```csharp
public CMsgDOTAOtherJoinedChatChannel()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel__ctor_Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_"></a> CMsgDOTAOtherJoinedChatChannel\(CMsgDOTAOtherJoinedChatChannel\)

```csharp
public CMsgDOTAOtherJoinedChatChannel(CMsgDOTAOtherJoinedChatChannel other)
```

#### Parameters

`other` [CMsgDOTAOtherJoinedChatChannel](Divine.Protobufs.Dota2.CMsgDOTAOtherJoinedChatChannel.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_ChannelIdFieldNumber"></a> ChannelIdFieldNumber

```csharp
public const int ChannelIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_ChannelUserIdFieldNumber"></a> ChannelUserIdFieldNumber

```csharp
public const int ChannelUserIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_PersonaNameFieldNumber"></a> PersonaNameFieldNumber

```csharp
public const int PersonaNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_StatusFieldNumber"></a> StatusFieldNumber

```csharp
public const int StatusFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_ChannelId"></a> ChannelId

```csharp
public ulong ChannelId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_ChannelUserId"></a> ChannelUserId

```csharp
public uint ChannelUserId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_HasChannelId"></a> HasChannelId

```csharp
public bool HasChannelId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_HasChannelUserId"></a> HasChannelUserId

```csharp
public bool HasChannelUserId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_HasPersonaName"></a> HasPersonaName

```csharp
public bool HasPersonaName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_HasStatus"></a> HasStatus

```csharp
public bool HasStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_HasSteamId"></a> HasSteamId

```csharp
public bool HasSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAOtherJoinedChatChannel> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAOtherJoinedChatChannel](Divine.Protobufs.Dota2.CMsgDOTAOtherJoinedChatChannel.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_PersonaName"></a> PersonaName

```csharp
public string PersonaName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_Status"></a> Status

```csharp
public uint Status { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_SteamId"></a> SteamId

```csharp
public ulong SteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_ClearChannelId"></a> ClearChannelId\(\)

```csharp
public void ClearChannelId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_ClearChannelUserId"></a> ClearChannelUserId\(\)

```csharp
public void ClearChannelUserId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_ClearPersonaName"></a> ClearPersonaName\(\)

```csharp
public void ClearPersonaName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_ClearStatus"></a> ClearStatus\(\)

```csharp
public void ClearStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_ClearSteamId"></a> ClearSteamId\(\)

```csharp
public void ClearSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAOtherJoinedChatChannel Clone()
```

#### Returns

 [CMsgDOTAOtherJoinedChatChannel](Divine.Protobufs.Dota2.CMsgDOTAOtherJoinedChatChannel.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_Equals_Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_"></a> Equals\(CMsgDOTAOtherJoinedChatChannel\)

```csharp
public bool Equals(CMsgDOTAOtherJoinedChatChannel other)
```

#### Parameters

`other` [CMsgDOTAOtherJoinedChatChannel](Divine.Protobufs.Dota2.CMsgDOTAOtherJoinedChatChannel.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_"></a> MergeFrom\(CMsgDOTAOtherJoinedChatChannel\)

```csharp
public void MergeFrom(CMsgDOTAOtherJoinedChatChannel other)
```

#### Parameters

`other` [CMsgDOTAOtherJoinedChatChannel](Divine.Protobufs.Dota2.CMsgDOTAOtherJoinedChatChannel.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAOtherJoinedChatChannel_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

