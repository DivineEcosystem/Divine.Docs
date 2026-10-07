# <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry"></a> Class CMsgPracticeLobbyListResponseEntry

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPracticeLobbyListResponseEntry : IMessage<CMsgPracticeLobbyListResponseEntry>, IEquatable<CMsgPracticeLobbyListResponseEntry>, IDeepCloneable<CMsgPracticeLobbyListResponseEntry>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPracticeLobbyListResponseEntry](Divine.Protobufs.Dota2.CMsgPracticeLobbyListResponseEntry.md)

#### Implements

IMessage<CMsgPracticeLobbyListResponseEntry\>, 
[IEquatable<CMsgPracticeLobbyListResponseEntry\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPracticeLobbyListResponseEntry\>, 
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
[EnumerableExtensions.In<CMsgPracticeLobbyListResponseEntry\>\(CMsgPracticeLobbyListResponseEntry, params CMsgPracticeLobbyListResponseEntry\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry__ctor"></a> CMsgPracticeLobbyListResponseEntry\(\)

```csharp
public CMsgPracticeLobbyListResponseEntry()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry__ctor_Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_"></a> CMsgPracticeLobbyListResponseEntry\(CMsgPracticeLobbyListResponseEntry\)

```csharp
public CMsgPracticeLobbyListResponseEntry(CMsgPracticeLobbyListResponseEntry other)
```

#### Parameters

`other` [CMsgPracticeLobbyListResponseEntry](Divine.Protobufs.Dota2.CMsgPracticeLobbyListResponseEntry.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_CustomGameModeFieldNumber"></a> CustomGameModeFieldNumber

```csharp
public const int CustomGameModeFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_CustomMapNameFieldNumber"></a> CustomMapNameFieldNumber

```csharp
public const int CustomMapNameFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_FriendPresentFieldNumber"></a> FriendPresentFieldNumber

```csharp
public const int FriendPresentFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_GameModeFieldNumber"></a> GameModeFieldNumber

```csharp
public const int GameModeFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_LanHostPingLocationFieldNumber"></a> LanHostPingLocationFieldNumber

```csharp
public const int LanHostPingLocationFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_LeaderAccountIdFieldNumber"></a> LeaderAccountIdFieldNumber

```csharp
public const int LeaderAccountIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_MaxPlayerCountFieldNumber"></a> MaxPlayerCountFieldNumber

```csharp
public const int MaxPlayerCountFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_MembersFieldNumber"></a> MembersFieldNumber

```csharp
public const int MembersFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_MinPlayerCountFieldNumber"></a> MinPlayerCountFieldNumber

```csharp
public const int MinPlayerCountFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_PenaltiesEnabledFieldNumber"></a> PenaltiesEnabledFieldNumber

```csharp
public const int PenaltiesEnabledFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_RequiresPassKeyFieldNumber"></a> RequiresPassKeyFieldNumber

```csharp
public const int RequiresPassKeyFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_ServerRegionFieldNumber"></a> ServerRegionFieldNumber

```csharp
public const int ServerRegionFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_CustomGameMode"></a> CustomGameMode

```csharp
public string CustomGameMode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_CustomMapName"></a> CustomMapName

```csharp
public string CustomMapName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_FriendPresent"></a> FriendPresent

```csharp
public bool FriendPresent { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_GameMode"></a> GameMode

```csharp
public DOTA_GameMode GameMode { get; set; }
```

#### Property Value

 [DOTA\_GameMode](Divine.Protobufs.Dota2.DOTA\_GameMode.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_HasCustomGameMode"></a> HasCustomGameMode

```csharp
public bool HasCustomGameMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_HasCustomMapName"></a> HasCustomMapName

```csharp
public bool HasCustomMapName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_HasFriendPresent"></a> HasFriendPresent

```csharp
public bool HasFriendPresent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_HasGameMode"></a> HasGameMode

```csharp
public bool HasGameMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_HasLanHostPingLocation"></a> HasLanHostPingLocation

```csharp
public bool HasLanHostPingLocation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_HasLeaderAccountId"></a> HasLeaderAccountId

```csharp
public bool HasLeaderAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_HasMaxPlayerCount"></a> HasMaxPlayerCount

```csharp
public bool HasMaxPlayerCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_HasMinPlayerCount"></a> HasMinPlayerCount

```csharp
public bool HasMinPlayerCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_HasPenaltiesEnabled"></a> HasPenaltiesEnabled

```csharp
public bool HasPenaltiesEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_HasPlayers"></a> HasPlayers

```csharp
public bool HasPlayers { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_HasRequiresPassKey"></a> HasRequiresPassKey

```csharp
public bool HasRequiresPassKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_HasServerRegion"></a> HasServerRegion

```csharp
public bool HasServerRegion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_Id"></a> Id

```csharp
public ulong Id { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_LanHostPingLocation"></a> LanHostPingLocation

```csharp
public string LanHostPingLocation { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_LeaderAccountId"></a> LeaderAccountId

```csharp
public uint LeaderAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_MaxPlayerCount"></a> MaxPlayerCount

```csharp
public uint MaxPlayerCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_Members"></a> Members

```csharp
public RepeatedField<CMsgPracticeLobbyListResponseEntry.Types.CLobbyMember> Members { get; }
```

#### Property Value

 RepeatedField<[CMsgPracticeLobbyListResponseEntry](Divine.Protobufs.Dota2.CMsgPracticeLobbyListResponseEntry.md).[Types](Divine.Protobufs.Dota2.CMsgPracticeLobbyListResponseEntry.Types.md).[CLobbyMember](Divine.Protobufs.Dota2.CMsgPracticeLobbyListResponseEntry.Types.CLobbyMember.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_MinPlayerCount"></a> MinPlayerCount

```csharp
public uint MinPlayerCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPracticeLobbyListResponseEntry> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPracticeLobbyListResponseEntry](Divine.Protobufs.Dota2.CMsgPracticeLobbyListResponseEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_PenaltiesEnabled"></a> PenaltiesEnabled

```csharp
public bool PenaltiesEnabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_Players"></a> Players

```csharp
public uint Players { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_RequiresPassKey"></a> RequiresPassKey

```csharp
public bool RequiresPassKey { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_ServerRegion"></a> ServerRegion

```csharp
public uint ServerRegion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_ClearCustomGameMode"></a> ClearCustomGameMode\(\)

```csharp
public void ClearCustomGameMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_ClearCustomMapName"></a> ClearCustomMapName\(\)

```csharp
public void ClearCustomMapName()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_ClearFriendPresent"></a> ClearFriendPresent\(\)

```csharp
public void ClearFriendPresent()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_ClearGameMode"></a> ClearGameMode\(\)

```csharp
public void ClearGameMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_ClearLanHostPingLocation"></a> ClearLanHostPingLocation\(\)

```csharp
public void ClearLanHostPingLocation()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_ClearLeaderAccountId"></a> ClearLeaderAccountId\(\)

```csharp
public void ClearLeaderAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_ClearMaxPlayerCount"></a> ClearMaxPlayerCount\(\)

```csharp
public void ClearMaxPlayerCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_ClearMinPlayerCount"></a> ClearMinPlayerCount\(\)

```csharp
public void ClearMinPlayerCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_ClearPenaltiesEnabled"></a> ClearPenaltiesEnabled\(\)

```csharp
public void ClearPenaltiesEnabled()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_ClearPlayers"></a> ClearPlayers\(\)

```csharp
public void ClearPlayers()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_ClearRequiresPassKey"></a> ClearRequiresPassKey\(\)

```csharp
public void ClearRequiresPassKey()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_ClearServerRegion"></a> ClearServerRegion\(\)

```csharp
public void ClearServerRegion()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_Clone"></a> Clone\(\)

```csharp
public CMsgPracticeLobbyListResponseEntry Clone()
```

#### Returns

 [CMsgPracticeLobbyListResponseEntry](Divine.Protobufs.Dota2.CMsgPracticeLobbyListResponseEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_Equals_Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_"></a> Equals\(CMsgPracticeLobbyListResponseEntry\)

```csharp
public bool Equals(CMsgPracticeLobbyListResponseEntry other)
```

#### Parameters

`other` [CMsgPracticeLobbyListResponseEntry](Divine.Protobufs.Dota2.CMsgPracticeLobbyListResponseEntry.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_MergeFrom_Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_"></a> MergeFrom\(CMsgPracticeLobbyListResponseEntry\)

```csharp
public void MergeFrom(CMsgPracticeLobbyListResponseEntry other)
```

#### Parameters

`other` [CMsgPracticeLobbyListResponseEntry](Divine.Protobufs.Dota2.CMsgPracticeLobbyListResponseEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponseEntry_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

