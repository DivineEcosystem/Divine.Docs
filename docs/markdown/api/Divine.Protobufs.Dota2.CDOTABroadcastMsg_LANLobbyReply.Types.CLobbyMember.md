# <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember"></a> Class CDOTABroadcastMsg\_LANLobbyReply.Types.CLobbyMember

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTABroadcastMsg_LANLobbyReply.Types.CLobbyMember : IMessage<CDOTABroadcastMsg_LANLobbyReply.Types.CLobbyMember>, IEquatable<CDOTABroadcastMsg_LANLobbyReply.Types.CLobbyMember>, IDeepCloneable<CDOTABroadcastMsg_LANLobbyReply.Types.CLobbyMember>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTABroadcastMsg\_LANLobbyReply.Types.CLobbyMember](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.Types.CLobbyMember.md)

#### Implements

IMessage<CDOTABroadcastMsg\_LANLobbyReply.Types.CLobbyMember\>, 
[IEquatable<CDOTABroadcastMsg\_LANLobbyReply.Types.CLobbyMember\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTABroadcastMsg\_LANLobbyReply.Types.CLobbyMember\>, 
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
[EnumerableExtensions.In<CDOTABroadcastMsg\_LANLobbyReply.Types.CLobbyMember\>\(CDOTABroadcastMsg\_LANLobbyReply.Types.CLobbyMember, params CDOTABroadcastMsg\_LANLobbyReply.Types.CLobbyMember\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember__ctor"></a> CLobbyMember\(\)

```csharp
public CLobbyMember()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember__ctor_Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_"></a> CLobbyMember\(CLobbyMember\)

```csharp
public CLobbyMember(CDOTABroadcastMsg_LANLobbyReply.Types.CLobbyMember other)
```

#### Parameters

`other` [CDOTABroadcastMsg\_LANLobbyReply](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.md).[Types](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.Types.md).[CLobbyMember](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.Types.CLobbyMember.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_PlayerNameFieldNumber"></a> PlayerNameFieldNumber

```csharp
public const int PlayerNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_HasPlayerName"></a> HasPlayerName

```csharp
public bool HasPlayerName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_Parser"></a> Parser

```csharp
public static MessageParser<CDOTABroadcastMsg_LANLobbyReply.Types.CLobbyMember> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTABroadcastMsg\_LANLobbyReply](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.md).[Types](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.Types.md).[CLobbyMember](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.Types.CLobbyMember.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_PlayerName"></a> PlayerName

```csharp
public string PlayerName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_ClearPlayerName"></a> ClearPlayerName\(\)

```csharp
public void ClearPlayerName()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_Clone"></a> Clone\(\)

```csharp
public CDOTABroadcastMsg_LANLobbyReply.Types.CLobbyMember Clone()
```

#### Returns

 [CDOTABroadcastMsg\_LANLobbyReply](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.md).[Types](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.Types.md).[CLobbyMember](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.Types.CLobbyMember.md)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_Equals_Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_"></a> Equals\(CLobbyMember\)

```csharp
public bool Equals(CDOTABroadcastMsg_LANLobbyReply.Types.CLobbyMember other)
```

#### Parameters

`other` [CDOTABroadcastMsg\_LANLobbyReply](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.md).[Types](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.Types.md).[CLobbyMember](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.Types.CLobbyMember.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_MergeFrom_Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_"></a> MergeFrom\(CLobbyMember\)

```csharp
public void MergeFrom(CDOTABroadcastMsg_LANLobbyReply.Types.CLobbyMember other)
```

#### Parameters

`other` [CDOTABroadcastMsg\_LANLobbyReply](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.md).[Types](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.Types.md).[CLobbyMember](Divine.Protobufs.Dota2.CDOTABroadcastMsg\_LANLobbyReply.Types.CLobbyMember.md)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcastMsg_LANLobbyReply_Types_CLobbyMember_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

