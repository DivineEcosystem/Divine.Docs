# <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite"></a> Class CSODOTALobbyInvite

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSODOTALobbyInvite : IMessage<CSODOTALobbyInvite>, IEquatable<CSODOTALobbyInvite>, IDeepCloneable<CSODOTALobbyInvite>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSODOTALobbyInvite](Divine.Protobufs.Dota2.CSODOTALobbyInvite.md)

#### Implements

IMessage<CSODOTALobbyInvite\>, 
[IEquatable<CSODOTALobbyInvite\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSODOTALobbyInvite\>, 
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
[EnumerableExtensions.In<CSODOTALobbyInvite\>\(CSODOTALobbyInvite, params CSODOTALobbyInvite\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite__ctor"></a> CSODOTALobbyInvite\(\)

```csharp
public CSODOTALobbyInvite()
```

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite__ctor_Divine_Protobufs_Dota2_CSODOTALobbyInvite_"></a> CSODOTALobbyInvite\(CSODOTALobbyInvite\)

```csharp
public CSODOTALobbyInvite(CSODOTALobbyInvite other)
```

#### Parameters

`other` [CSODOTALobbyInvite](Divine.Protobufs.Dota2.CSODOTALobbyInvite.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_CustomGameCrcFieldNumber"></a> CustomGameCrcFieldNumber

```csharp
public const int CustomGameCrcFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_CustomGameIdFieldNumber"></a> CustomGameIdFieldNumber

```csharp
public const int CustomGameIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_CustomGameTimestampFieldNumber"></a> CustomGameTimestampFieldNumber

```csharp
public const int CustomGameTimestampFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_GroupIdFieldNumber"></a> GroupIdFieldNumber

```csharp
public const int GroupIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_InviteGidFieldNumber"></a> InviteGidFieldNumber

```csharp
public const int InviteGidFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_MembersFieldNumber"></a> MembersFieldNumber

```csharp
public const int MembersFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_SenderIdFieldNumber"></a> SenderIdFieldNumber

```csharp
public const int SenderIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_SenderNameFieldNumber"></a> SenderNameFieldNumber

```csharp
public const int SenderNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_CustomGameCrc"></a> CustomGameCrc

```csharp
public ulong CustomGameCrc { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_CustomGameId"></a> CustomGameId

```csharp
public ulong CustomGameId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_CustomGameTimestamp"></a> CustomGameTimestamp

```csharp
public uint CustomGameTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_GroupId"></a> GroupId

```csharp
public ulong GroupId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_HasCustomGameCrc"></a> HasCustomGameCrc

```csharp
public bool HasCustomGameCrc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_HasCustomGameId"></a> HasCustomGameId

```csharp
public bool HasCustomGameId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_HasCustomGameTimestamp"></a> HasCustomGameTimestamp

```csharp
public bool HasCustomGameTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_HasGroupId"></a> HasGroupId

```csharp
public bool HasGroupId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_HasInviteGid"></a> HasInviteGid

```csharp
public bool HasInviteGid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_HasSenderId"></a> HasSenderId

```csharp
public bool HasSenderId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_HasSenderName"></a> HasSenderName

```csharp
public bool HasSenderName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_InviteGid"></a> InviteGid

```csharp
public ulong InviteGid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Members"></a> Members

```csharp
public RepeatedField<CSODOTALobbyInvite.Types.LobbyMember> Members { get; }
```

#### Property Value

 RepeatedField<[CSODOTALobbyInvite](Divine.Protobufs.Dota2.CSODOTALobbyInvite.md).[Types](Divine.Protobufs.Dota2.CSODOTALobbyInvite.Types.md).[LobbyMember](Divine.Protobufs.Dota2.CSODOTALobbyInvite.Types.LobbyMember.md)\>

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Parser"></a> Parser

```csharp
public static MessageParser<CSODOTALobbyInvite> Parser { get; }
```

#### Property Value

 MessageParser<[CSODOTALobbyInvite](Divine.Protobufs.Dota2.CSODOTALobbyInvite.md)\>

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_SenderId"></a> SenderId

```csharp
public ulong SenderId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_SenderName"></a> SenderName

```csharp
public string SenderName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_ClearCustomGameCrc"></a> ClearCustomGameCrc\(\)

```csharp
public void ClearCustomGameCrc()
```

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_ClearCustomGameId"></a> ClearCustomGameId\(\)

```csharp
public void ClearCustomGameId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_ClearCustomGameTimestamp"></a> ClearCustomGameTimestamp\(\)

```csharp
public void ClearCustomGameTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_ClearGroupId"></a> ClearGroupId\(\)

```csharp
public void ClearGroupId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_ClearInviteGid"></a> ClearInviteGid\(\)

```csharp
public void ClearInviteGid()
```

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_ClearSenderId"></a> ClearSenderId\(\)

```csharp
public void ClearSenderId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_ClearSenderName"></a> ClearSenderName\(\)

```csharp
public void ClearSenderName()
```

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Clone"></a> Clone\(\)

```csharp
public CSODOTALobbyInvite Clone()
```

#### Returns

 [CSODOTALobbyInvite](Divine.Protobufs.Dota2.CSODOTALobbyInvite.md)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Equals_Divine_Protobufs_Dota2_CSODOTALobbyInvite_"></a> Equals\(CSODOTALobbyInvite\)

```csharp
public bool Equals(CSODOTALobbyInvite other)
```

#### Parameters

`other` [CSODOTALobbyInvite](Divine.Protobufs.Dota2.CSODOTALobbyInvite.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_MergeFrom_Divine_Protobufs_Dota2_CSODOTALobbyInvite_"></a> MergeFrom\(CSODOTALobbyInvite\)

```csharp
public void MergeFrom(CSODOTALobbyInvite other)
```

#### Parameters

`other` [CSODOTALobbyInvite](Divine.Protobufs.Dota2.CSODOTALobbyInvite.md)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

