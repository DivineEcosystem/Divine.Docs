# <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse"></a> Class CMsgLobbyInviteResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLobbyInviteResponse : IMessage<CMsgLobbyInviteResponse>, IEquatable<CMsgLobbyInviteResponse>, IDeepCloneable<CMsgLobbyInviteResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLobbyInviteResponse](Divine.Protobufs.Dota2.CMsgLobbyInviteResponse.md)

#### Implements

IMessage<CMsgLobbyInviteResponse\>, 
[IEquatable<CMsgLobbyInviteResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLobbyInviteResponse\>, 
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
[EnumerableExtensions.In<CMsgLobbyInviteResponse\>\(CMsgLobbyInviteResponse, params CMsgLobbyInviteResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse__ctor"></a> CMsgLobbyInviteResponse\(\)

```csharp
public CMsgLobbyInviteResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse__ctor_Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_"></a> CMsgLobbyInviteResponse\(CMsgLobbyInviteResponse\)

```csharp
public CMsgLobbyInviteResponse(CMsgLobbyInviteResponse other)
```

#### Parameters

`other` [CMsgLobbyInviteResponse](Divine.Protobufs.Dota2.CMsgLobbyInviteResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_AcceptFieldNumber"></a> AcceptFieldNumber

```csharp
public const int AcceptFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_ClientVersionFieldNumber"></a> ClientVersionFieldNumber

```csharp
public const int ClientVersionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_CustomGameCrcFieldNumber"></a> CustomGameCrcFieldNumber

```csharp
public const int CustomGameCrcFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_CustomGameTimestampFieldNumber"></a> CustomGameTimestampFieldNumber

```csharp
public const int CustomGameTimestampFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_LobbyIdFieldNumber"></a> LobbyIdFieldNumber

```csharp
public const int LobbyIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_Accept"></a> Accept

```csharp
public bool Accept { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_ClientVersion"></a> ClientVersion

```csharp
public uint ClientVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_CustomGameCrc"></a> CustomGameCrc

```csharp
public ulong CustomGameCrc { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_CustomGameTimestamp"></a> CustomGameTimestamp

```csharp
public uint CustomGameTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_HasAccept"></a> HasAccept

```csharp
public bool HasAccept { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_HasClientVersion"></a> HasClientVersion

```csharp
public bool HasClientVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_HasCustomGameCrc"></a> HasCustomGameCrc

```csharp
public bool HasCustomGameCrc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_HasCustomGameTimestamp"></a> HasCustomGameTimestamp

```csharp
public bool HasCustomGameTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_HasLobbyId"></a> HasLobbyId

```csharp
public bool HasLobbyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_LobbyId"></a> LobbyId

```csharp
public ulong LobbyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLobbyInviteResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLobbyInviteResponse](Divine.Protobufs.Dota2.CMsgLobbyInviteResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_ClearAccept"></a> ClearAccept\(\)

```csharp
public void ClearAccept()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_ClearClientVersion"></a> ClearClientVersion\(\)

```csharp
public void ClearClientVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_ClearCustomGameCrc"></a> ClearCustomGameCrc\(\)

```csharp
public void ClearCustomGameCrc()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_ClearCustomGameTimestamp"></a> ClearCustomGameTimestamp\(\)

```csharp
public void ClearCustomGameTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_ClearLobbyId"></a> ClearLobbyId\(\)

```csharp
public void ClearLobbyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_Clone"></a> Clone\(\)

```csharp
public CMsgLobbyInviteResponse Clone()
```

#### Returns

 [CMsgLobbyInviteResponse](Divine.Protobufs.Dota2.CMsgLobbyInviteResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_Equals_Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_"></a> Equals\(CMsgLobbyInviteResponse\)

```csharp
public bool Equals(CMsgLobbyInviteResponse other)
```

#### Parameters

`other` [CMsgLobbyInviteResponse](Divine.Protobufs.Dota2.CMsgLobbyInviteResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_"></a> MergeFrom\(CMsgLobbyInviteResponse\)

```csharp
public void MergeFrom(CMsgLobbyInviteResponse other)
```

#### Parameters

`other` [CMsgLobbyInviteResponse](Divine.Protobufs.Dota2.CMsgLobbyInviteResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInviteResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

