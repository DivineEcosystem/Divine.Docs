# <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby"></a> Class CMsgSpectatorLobbyListResponse.Types.SpectatorLobby

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSpectatorLobbyListResponse.Types.SpectatorLobby : IMessage<CMsgSpectatorLobbyListResponse.Types.SpectatorLobby>, IEquatable<CMsgSpectatorLobbyListResponse.Types.SpectatorLobby>, IDeepCloneable<CMsgSpectatorLobbyListResponse.Types.SpectatorLobby>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSpectatorLobbyListResponse.Types.SpectatorLobby](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.Types.SpectatorLobby.md)

#### Implements

IMessage<CMsgSpectatorLobbyListResponse.Types.SpectatorLobby\>, 
[IEquatable<CMsgSpectatorLobbyListResponse.Types.SpectatorLobby\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSpectatorLobbyListResponse.Types.SpectatorLobby\>, 
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
[EnumerableExtensions.In<CMsgSpectatorLobbyListResponse.Types.SpectatorLobby\>\(CMsgSpectatorLobbyListResponse.Types.SpectatorLobby, params CMsgSpectatorLobbyListResponse.Types.SpectatorLobby\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby__ctor"></a> SpectatorLobby\(\)

```csharp
public SpectatorLobby()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby__ctor_Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_"></a> SpectatorLobby\(SpectatorLobby\)

```csharp
public SpectatorLobby(CMsgSpectatorLobbyListResponse.Types.SpectatorLobby other)
```

#### Parameters

`other` [CMsgSpectatorLobbyListResponse](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.Types.md).[SpectatorLobby](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.Types.SpectatorLobby.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_GameDetailsFieldNumber"></a> GameDetailsFieldNumber

```csharp
public const int GameDetailsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_GameNameFieldNumber"></a> GameNameFieldNumber

```csharp
public const int GameNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_LeaderAccountIdFieldNumber"></a> LeaderAccountIdFieldNumber

```csharp
public const int LeaderAccountIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_LobbyIdFieldNumber"></a> LobbyIdFieldNumber

```csharp
public const int LobbyIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_MemberCountFieldNumber"></a> MemberCountFieldNumber

```csharp
public const int MemberCountFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_RequiresPassKeyFieldNumber"></a> RequiresPassKeyFieldNumber

```csharp
public const int RequiresPassKeyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_GameDetails"></a> GameDetails

```csharp
public CMsgSpectatorLobbyGameDetails GameDetails { get; set; }
```

#### Property Value

 [CMsgSpectatorLobbyGameDetails](Divine.Protobufs.Dota2.CMsgSpectatorLobbyGameDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_GameName"></a> GameName

```csharp
public string GameName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_HasGameName"></a> HasGameName

```csharp
public bool HasGameName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_HasLeaderAccountId"></a> HasLeaderAccountId

```csharp
public bool HasLeaderAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_HasLobbyId"></a> HasLobbyId

```csharp
public bool HasLobbyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_HasMemberCount"></a> HasMemberCount

```csharp
public bool HasMemberCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_HasRequiresPassKey"></a> HasRequiresPassKey

```csharp
public bool HasRequiresPassKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_LeaderAccountId"></a> LeaderAccountId

```csharp
public uint LeaderAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_LobbyId"></a> LobbyId

```csharp
public ulong LobbyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_MemberCount"></a> MemberCount

```csharp
public uint MemberCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSpectatorLobbyListResponse.Types.SpectatorLobby> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSpectatorLobbyListResponse](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.Types.md).[SpectatorLobby](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.Types.SpectatorLobby.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_RequiresPassKey"></a> RequiresPassKey

```csharp
public bool RequiresPassKey { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_ClearGameName"></a> ClearGameName\(\)

```csharp
public void ClearGameName()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_ClearLeaderAccountId"></a> ClearLeaderAccountId\(\)

```csharp
public void ClearLeaderAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_ClearLobbyId"></a> ClearLobbyId\(\)

```csharp
public void ClearLobbyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_ClearMemberCount"></a> ClearMemberCount\(\)

```csharp
public void ClearMemberCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_ClearRequiresPassKey"></a> ClearRequiresPassKey\(\)

```csharp
public void ClearRequiresPassKey()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_Clone"></a> Clone\(\)

```csharp
public CMsgSpectatorLobbyListResponse.Types.SpectatorLobby Clone()
```

#### Returns

 [CMsgSpectatorLobbyListResponse](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.Types.md).[SpectatorLobby](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.Types.SpectatorLobby.md)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_Equals_Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_"></a> Equals\(SpectatorLobby\)

```csharp
public bool Equals(CMsgSpectatorLobbyListResponse.Types.SpectatorLobby other)
```

#### Parameters

`other` [CMsgSpectatorLobbyListResponse](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.Types.md).[SpectatorLobby](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.Types.SpectatorLobby.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_MergeFrom_Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_"></a> MergeFrom\(SpectatorLobby\)

```csharp
public void MergeFrom(CMsgSpectatorLobbyListResponse.Types.SpectatorLobby other)
```

#### Parameters

`other` [CMsgSpectatorLobbyListResponse](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.Types.md).[SpectatorLobby](Divine.Protobufs.Dota2.CMsgSpectatorLobbyListResponse.Types.SpectatorLobby.md)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyListResponse_Types_SpectatorLobby_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

