# <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage"></a> Class CMsgGCToGCMasterBroadcastMessage

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCMasterBroadcastMessage : IMessage<CMsgGCToGCMasterBroadcastMessage>, IEquatable<CMsgGCToGCMasterBroadcastMessage>, IDeepCloneable<CMsgGCToGCMasterBroadcastMessage>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCMasterBroadcastMessage](Divine.Protobufs.Dota2.CMsgGCToGCMasterBroadcastMessage.md)

#### Implements

IMessage<CMsgGCToGCMasterBroadcastMessage\>, 
[IEquatable<CMsgGCToGCMasterBroadcastMessage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCMasterBroadcastMessage\>, 
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
[EnumerableExtensions.In<CMsgGCToGCMasterBroadcastMessage\>\(CMsgGCToGCMasterBroadcastMessage, params CMsgGCToGCMasterBroadcastMessage\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage__ctor"></a> CMsgGCToGCMasterBroadcastMessage\(\)

```csharp
public CMsgGCToGCMasterBroadcastMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage__ctor_Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_"></a> CMsgGCToGCMasterBroadcastMessage\(CMsgGCToGCMasterBroadcastMessage\)

```csharp
public CMsgGCToGCMasterBroadcastMessage(CMsgGCToGCMasterBroadcastMessage other)
```

#### Parameters

`other` [CMsgGCToGCMasterBroadcastMessage](Divine.Protobufs.Dota2.CMsgGCToGCMasterBroadcastMessage.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_MsgDataFieldNumber"></a> MsgDataFieldNumber

```csharp
public const int MsgDataFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_MsgIdFieldNumber"></a> MsgIdFieldNumber

```csharp
public const int MsgIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_SendToServersFieldNumber"></a> SendToServersFieldNumber

```csharp
public const int SendToServersFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_SendToUsersFieldNumber"></a> SendToUsersFieldNumber

```csharp
public const int SendToUsersFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_TrustedServersOnlyFieldNumber"></a> TrustedServersOnlyFieldNumber

```csharp
public const int TrustedServersOnlyFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_UsersPerSecondFieldNumber"></a> UsersPerSecondFieldNumber

```csharp
public const int UsersPerSecondFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_HasMsgData"></a> HasMsgData

```csharp
public bool HasMsgData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_HasMsgId"></a> HasMsgId

```csharp
public bool HasMsgId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_HasSendToServers"></a> HasSendToServers

```csharp
public bool HasSendToServers { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_HasSendToUsers"></a> HasSendToUsers

```csharp
public bool HasSendToUsers { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_HasTrustedServersOnly"></a> HasTrustedServersOnly

```csharp
public bool HasTrustedServersOnly { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_HasUsersPerSecond"></a> HasUsersPerSecond

```csharp
public bool HasUsersPerSecond { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_MsgData"></a> MsgData

```csharp
public ByteString MsgData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_MsgId"></a> MsgId

```csharp
public uint MsgId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCMasterBroadcastMessage> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCMasterBroadcastMessage](Divine.Protobufs.Dota2.CMsgGCToGCMasterBroadcastMessage.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_SendToServers"></a> SendToServers

```csharp
public bool SendToServers { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_SendToUsers"></a> SendToUsers

```csharp
public bool SendToUsers { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_TrustedServersOnly"></a> TrustedServersOnly

```csharp
public bool TrustedServersOnly { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_UsersPerSecond"></a> UsersPerSecond

```csharp
public uint UsersPerSecond { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_ClearMsgData"></a> ClearMsgData\(\)

```csharp
public void ClearMsgData()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_ClearMsgId"></a> ClearMsgId\(\)

```csharp
public void ClearMsgId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_ClearSendToServers"></a> ClearSendToServers\(\)

```csharp
public void ClearSendToServers()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_ClearSendToUsers"></a> ClearSendToUsers\(\)

```csharp
public void ClearSendToUsers()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_ClearTrustedServersOnly"></a> ClearTrustedServersOnly\(\)

```csharp
public void ClearTrustedServersOnly()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_ClearUsersPerSecond"></a> ClearUsersPerSecond\(\)

```csharp
public void ClearUsersPerSecond()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCMasterBroadcastMessage Clone()
```

#### Returns

 [CMsgGCToGCMasterBroadcastMessage](Divine.Protobufs.Dota2.CMsgGCToGCMasterBroadcastMessage.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_Equals_Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_"></a> Equals\(CMsgGCToGCMasterBroadcastMessage\)

```csharp
public bool Equals(CMsgGCToGCMasterBroadcastMessage other)
```

#### Parameters

`other` [CMsgGCToGCMasterBroadcastMessage](Divine.Protobufs.Dota2.CMsgGCToGCMasterBroadcastMessage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_"></a> MergeFrom\(CMsgGCToGCMasterBroadcastMessage\)

```csharp
public void MergeFrom(CMsgGCToGCMasterBroadcastMessage other)
```

#### Parameters

`other` [CMsgGCToGCMasterBroadcastMessage](Divine.Protobufs.Dota2.CMsgGCToGCMasterBroadcastMessage.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterBroadcastMessage_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

