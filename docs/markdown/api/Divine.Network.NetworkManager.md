# <a id="Divine_Network_NetworkManager"></a> Class NetworkManager

Namespace: [Divine.Network](Divine.Network.md)  
Assembly: Divine.dll  

```csharp
public static class NetworkManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[NetworkManager](Divine.Network.NetworkManager.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_)

## Properties

### <a id="Divine_Network_NetworkManager_FlattenedSerializer"></a> FlattenedSerializer

```csharp
public static NetProtobuf? FlattenedSerializer { get; }
```

#### Property Value

 [NetProtobuf](Divine.Network.NetProtobuf.md)?

## Methods

### <a id="Divine_Network_NetworkManager_SendGCMessage_Divine_Network_GC_GCMessageId_Google_Protobuf_IMessage_"></a> SendGCMessage\(GCMessageId, IMessage\)

```csharp
public static void SendGCMessage(GCMessageId messageId, IMessage message)
```

#### Parameters

`messageId` [GCMessageId](Divine.Network.GC.GCMessageId.md)

`message` IMessage

### <a id="Divine_Network_NetworkManager_SendGCMessage_Divine_Network_GC_GCMessageId_System_UInt64_Google_Protobuf_IMessage_"></a> SendGCMessage\(GCMessageId, ulong, IMessage\)

```csharp
public static void SendGCMessage(GCMessageId messageId, ulong jobId, IMessage message)
```

#### Parameters

`messageId` [GCMessageId](Divine.Network.GC.GCMessageId.md)

`jobId` [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

`message` IMessage

### <a id="Divine_Network_NetworkManager_SendGCMessage_Divine_Network_GC_GCMessageId_System_UInt64_System_Byte___"></a> SendGCMessage\(GCMessageId, ulong, byte\[\]\)

```csharp
public static void SendGCMessage(GCMessageId messageId, ulong jobId, byte[] buffer)
```

#### Parameters

`messageId` [GCMessageId](Divine.Network.GC.GCMessageId.md)

`jobId` [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

`buffer` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

### <a id="Divine_Network_NetworkManager_SendGCMessageToClient_Divine_Network_GC_GCMessageId_Google_Protobuf_IMessage_"></a> SendGCMessageToClient\(GCMessageId, IMessage\)

```csharp
public static void SendGCMessageToClient(GCMessageId messageId, IMessage message)
```

#### Parameters

`messageId` [GCMessageId](Divine.Network.GC.GCMessageId.md)

`message` IMessage

### <a id="Divine_Network_NetworkManager_SendGCMessageToClient_Divine_Network_GC_GCMessageId_System_UInt64_Google_Protobuf_IMessage_"></a> SendGCMessageToClient\(GCMessageId, ulong, IMessage\)

```csharp
public static void SendGCMessageToClient(GCMessageId messageId, ulong jobId, IMessage message)
```

#### Parameters

`messageId` [GCMessageId](Divine.Network.GC.GCMessageId.md)

`jobId` [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

`message` IMessage

### <a id="Divine_Network_NetworkManager_SendGCMessageToClient_Divine_Network_GC_GCMessageId_System_UInt64_System_Byte___"></a> SendGCMessageToClient\(GCMessageId, ulong, byte\[\]\)

```csharp
public static void SendGCMessageToClient(GCMessageId messageId, ulong jobId, byte[] buffer)
```

#### Parameters

`messageId` [GCMessageId](Divine.Network.GC.GCMessageId.md)

`jobId` [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

`buffer` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

### <a id="Divine_Network_NetworkManager_SendNetMessage_Divine_Network_Net_NetMessageId_Google_Protobuf_IMessage_"></a> SendNetMessage\(NetMessageId, IMessage\)

```csharp
public static bool SendNetMessage(NetMessageId messageId, IMessage message)
```

#### Parameters

`messageId` [NetMessageId](Divine.Network.Net.NetMessageId.md)

`message` IMessage

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Network_NetworkManager_SendNetMessage_Divine_Network_Net_NetMessageId_System_Byte___"></a> SendNetMessage\(NetMessageId, byte\[\]\)

```csharp
public static bool SendNetMessage(NetMessageId messageId, byte[] buffer)
```

#### Parameters

`messageId` [NetMessageId](Divine.Network.Net.NetMessageId.md)

`buffer` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Network_NetworkManager_SendNetMessageToClient_Divine_Network_Net_NetMessageId_Google_Protobuf_IMessage_"></a> SendNetMessageToClient\(NetMessageId, IMessage\)

```csharp
public static bool SendNetMessageToClient(NetMessageId messageId, IMessage message)
```

#### Parameters

`messageId` [NetMessageId](Divine.Network.Net.NetMessageId.md)

`message` IMessage

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Network_NetworkManager_SendNetMessageToClient_Divine_Network_Net_NetMessageId_System_Byte___"></a> SendNetMessageToClient\(NetMessageId, byte\[\]\)

```csharp
public static bool SendNetMessageToClient(NetMessageId messageId, byte[] buffer)
```

#### Parameters

`messageId` [NetMessageId](Divine.Network.Net.NetMessageId.md)

`buffer` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Network_NetworkManager_GCMessageReceived"></a> GCMessageReceived

```csharp
public static event NetworkManager.GCMessageReceivedEventHandler GCMessageReceived
```

#### Event Type

 [NetworkManager](Divine.Network.NetworkManager.md).[GCMessageReceivedEventHandler](Divine.Network.NetworkManager.GCMessageReceivedEventHandler.md)

### <a id="Divine_Network_NetworkManager_GCMessageSend"></a> GCMessageSend

```csharp
public static event NetworkManager.GCMessageSendEventHandler GCMessageSend
```

#### Event Type

 [NetworkManager](Divine.Network.NetworkManager.md).[GCMessageSendEventHandler](Divine.Network.NetworkManager.GCMessageSendEventHandler.md)

### <a id="Divine_Network_NetworkManager_GCSOMessageUpdate"></a> GCSOMessageUpdate

```csharp
public static event NetworkManager.GCSOMessageUpdateEventHandler GCSOMessageUpdate
```

#### Event Type

 [NetworkManager](Divine.Network.NetworkManager.md).[GCSOMessageUpdateEventHandler](Divine.Network.NetworkManager.GCSOMessageUpdateEventHandler.md)

### <a id="Divine_Network_NetworkManager_HttpRequestCreating"></a> HttpRequestCreating

```csharp
public static event NetworkManager.HttpRequestCreatingEventHandler? HttpRequestCreating
```

#### Event Type

 [NetworkManager](Divine.Network.NetworkManager.md).[HttpRequestCreatingEventHandler](Divine.Network.NetworkManager.HttpRequestCreatingEventHandler.md)?

### <a id="Divine_Network_NetworkManager_HttpResponseReceived"></a> HttpResponseReceived

```csharp
public static event NetworkManager.HttpResponseReceivedEventHandler? HttpResponseReceived
```

#### Event Type

 [NetworkManager](Divine.Network.NetworkManager.md).[HttpResponseReceivedEventHandler](Divine.Network.NetworkManager.HttpResponseReceivedEventHandler.md)?

### <a id="Divine_Network_NetworkManager_NetMessageReceived"></a> NetMessageReceived

```csharp
public static event NetworkManager.NetMessageReceivedEventHandler NetMessageReceived
```

#### Event Type

 [NetworkManager](Divine.Network.NetworkManager.md).[NetMessageReceivedEventHandler](Divine.Network.NetworkManager.NetMessageReceivedEventHandler.md)

### <a id="Divine_Network_NetworkManager_NetMessageSend"></a> NetMessageSend

```csharp
public static event NetworkManager.NetMessageSendEventHandler NetMessageSend
```

#### Event Type

 [NetworkManager](Divine.Network.NetworkManager.md).[NetMessageSendEventHandler](Divine.Network.NetworkManager.NetMessageSendEventHandler.md)

