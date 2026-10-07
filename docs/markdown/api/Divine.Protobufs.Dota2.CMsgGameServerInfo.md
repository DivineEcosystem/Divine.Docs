# <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo"></a> Class CMsgGameServerInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameServerInfo : IMessage<CMsgGameServerInfo>, IEquatable<CMsgGameServerInfo>, IDeepCloneable<CMsgGameServerInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameServerInfo](Divine.Protobufs.Dota2.CMsgGameServerInfo.md)

#### Implements

IMessage<CMsgGameServerInfo\>, 
[IEquatable<CMsgGameServerInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameServerInfo\>, 
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
[EnumerableExtensions.In<CMsgGameServerInfo\>\(CMsgGameServerInfo, params CMsgGameServerInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo__ctor"></a> CMsgGameServerInfo\(\)

```csharp
public CMsgGameServerInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo__ctor_Divine_Protobufs_Dota2_CMsgGameServerInfo_"></a> CMsgGameServerInfo\(CMsgGameServerInfo\)

```csharp
public CMsgGameServerInfo(CMsgGameServerInfo other)
```

#### Parameters

`other` [CMsgGameServerInfo](Divine.Protobufs.Dota2.CMsgGameServerInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_AllowCustomGamesFieldNumber"></a> AllowCustomGamesFieldNumber

```csharp
public const int AllowCustomGamesFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_AssignedServerTvPortFieldNumber"></a> AssignedServerTvPortFieldNumber

```csharp
public const int AssignedServerTvPortFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_BuildVersionFieldNumber"></a> BuildVersionFieldNumber

```csharp
public const int BuildVersionFieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_DevForceServerTypeFieldNumber"></a> DevForceServerTypeFieldNumber

```csharp
public const int DevForceServerTypeFieldNumber = 28
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_LegacyServerSteamdatagramAddressFieldNumber"></a> LegacyServerSteamdatagramAddressFieldNumber

```csharp
public const int LegacyServerSteamdatagramAddressFieldNumber = 27
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ParentRelayCountFieldNumber"></a> ParentRelayCountFieldNumber

```csharp
public const int ParentRelayCountFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_RelayClientsConnectedFieldNumber"></a> RelayClientsConnectedFieldNumber

```csharp
public const int RelayClientsConnectedFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_RelayedGameServerSteamIdFieldNumber"></a> RelayedGameServerSteamIdFieldNumber

```csharp
public const int RelayedGameServerSteamIdFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_RelaysConnectedFieldNumber"></a> RelaysConnectedFieldNumber

```csharp
public const int RelaysConnectedFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_RelaySlotsMaxFieldNumber"></a> RelaySlotsMaxFieldNumber

```csharp
public const int RelaySlotsMaxFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerClusterFieldNumber"></a> ServerClusterFieldNumber

```csharp
public const int ServerClusterFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerGameTimeFieldNumber"></a> ServerGameTimeFieldNumber

```csharp
public const int ServerGameTimeFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerHibernationFieldNumber"></a> ServerHibernationFieldNumber

```csharp
public const int ServerHibernationFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerKeyFieldNumber"></a> ServerKeyFieldNumber

```csharp
public const int ServerKeyFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerLoadavgFieldNumber"></a> ServerLoadavgFieldNumber

```csharp
public const int ServerLoadavgFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerPortFieldNumber"></a> ServerPortFieldNumber

```csharp
public const int ServerPortFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerPrivateIpAddrFieldNumber"></a> ServerPrivateIpAddrFieldNumber

```csharp
public const int ServerPrivateIpAddrFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerPublicIpAddrFieldNumber"></a> ServerPublicIpAddrFieldNumber

```csharp
public const int ServerPublicIpAddrFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerRegionFieldNumber"></a> ServerRegionFieldNumber

```csharp
public const int ServerRegionFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerRelayConnectedSteamIdFieldNumber"></a> ServerRelayConnectedSteamIdFieldNumber

```csharp
public const int ServerRelayConnectedSteamIdFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerTvBroadcastTimeFieldNumber"></a> ServerTvBroadcastTimeFieldNumber

```csharp
public const int ServerTvBroadcastTimeFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerTvPortFieldNumber"></a> ServerTvPortFieldNumber

```csharp
public const int ServerTvPortFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerTypeFieldNumber"></a> ServerTypeFieldNumber

```csharp
public const int ServerTypeFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerVersionFieldNumber"></a> ServerVersionFieldNumber

```csharp
public const int ServerVersionFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_SrcdsInstanceFieldNumber"></a> SrcdsInstanceFieldNumber

```csharp
public const int SrcdsInstanceFieldNumber = 26
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_TvSecretCodeFieldNumber"></a> TvSecretCodeFieldNumber

```csharp
public const int TvSecretCodeFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_AllowCustomGames"></a> AllowCustomGames

```csharp
public CMsgGameServerInfo.Types.CustomGames AllowCustomGames { get; set; }
```

#### Property Value

 [CMsgGameServerInfo](Divine.Protobufs.Dota2.CMsgGameServerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgGameServerInfo.Types.md).[CustomGames](Divine.Protobufs.Dota2.CMsgGameServerInfo.Types.CustomGames.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_AssignedServerTvPort"></a> AssignedServerTvPort

```csharp
public uint AssignedServerTvPort { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_BuildVersion"></a> BuildVersion

```csharp
public uint BuildVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_DevForceServerType"></a> DevForceServerType

```csharp
public bool DevForceServerType { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasAllowCustomGames"></a> HasAllowCustomGames

```csharp
public bool HasAllowCustomGames { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasAssignedServerTvPort"></a> HasAssignedServerTvPort

```csharp
public bool HasAssignedServerTvPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasBuildVersion"></a> HasBuildVersion

```csharp
public bool HasBuildVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasDevForceServerType"></a> HasDevForceServerType

```csharp
public bool HasDevForceServerType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasLegacyServerSteamdatagramAddress"></a> HasLegacyServerSteamdatagramAddress

```csharp
public bool HasLegacyServerSteamdatagramAddress { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasParentRelayCount"></a> HasParentRelayCount

```csharp
public bool HasParentRelayCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasRelayClientsConnected"></a> HasRelayClientsConnected

```csharp
public bool HasRelayClientsConnected { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasRelayedGameServerSteamId"></a> HasRelayedGameServerSteamId

```csharp
public bool HasRelayedGameServerSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasRelaysConnected"></a> HasRelaysConnected

```csharp
public bool HasRelaysConnected { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasRelaySlotsMax"></a> HasRelaySlotsMax

```csharp
public bool HasRelaySlotsMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasServerCluster"></a> HasServerCluster

```csharp
public bool HasServerCluster { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasServerGameTime"></a> HasServerGameTime

```csharp
public bool HasServerGameTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasServerHibernation"></a> HasServerHibernation

```csharp
public bool HasServerHibernation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasServerKey"></a> HasServerKey

```csharp
public bool HasServerKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasServerLoadavg"></a> HasServerLoadavg

```csharp
public bool HasServerLoadavg { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasServerPort"></a> HasServerPort

```csharp
public bool HasServerPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasServerPrivateIpAddr"></a> HasServerPrivateIpAddr

```csharp
public bool HasServerPrivateIpAddr { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasServerPublicIpAddr"></a> HasServerPublicIpAddr

```csharp
public bool HasServerPublicIpAddr { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasServerRegion"></a> HasServerRegion

```csharp
public bool HasServerRegion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasServerRelayConnectedSteamId"></a> HasServerRelayConnectedSteamId

```csharp
public bool HasServerRelayConnectedSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasServerTvBroadcastTime"></a> HasServerTvBroadcastTime

```csharp
public bool HasServerTvBroadcastTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasServerTvPort"></a> HasServerTvPort

```csharp
public bool HasServerTvPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasServerType"></a> HasServerType

```csharp
public bool HasServerType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasServerVersion"></a> HasServerVersion

```csharp
public bool HasServerVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasSrcdsInstance"></a> HasSrcdsInstance

```csharp
public bool HasSrcdsInstance { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_HasTvSecretCode"></a> HasTvSecretCode

```csharp
public bool HasTvSecretCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_LegacyServerSteamdatagramAddress"></a> LegacyServerSteamdatagramAddress

```csharp
public ByteString LegacyServerSteamdatagramAddress { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ParentRelayCount"></a> ParentRelayCount

```csharp
public uint ParentRelayCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameServerInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameServerInfo](Divine.Protobufs.Dota2.CMsgGameServerInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_RelayClientsConnected"></a> RelayClientsConnected

```csharp
public int RelayClientsConnected { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_RelayedGameServerSteamId"></a> RelayedGameServerSteamId

```csharp
public ulong RelayedGameServerSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_RelaysConnected"></a> RelaysConnected

```csharp
public int RelaysConnected { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_RelaySlotsMax"></a> RelaySlotsMax

```csharp
public uint RelaySlotsMax { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerCluster"></a> ServerCluster

```csharp
public uint ServerCluster { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerGameTime"></a> ServerGameTime

```csharp
public float ServerGameTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerHibernation"></a> ServerHibernation

```csharp
public bool ServerHibernation { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerKey"></a> ServerKey

```csharp
public string ServerKey { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerLoadavg"></a> ServerLoadavg

```csharp
public float ServerLoadavg { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerPort"></a> ServerPort

```csharp
public uint ServerPort { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerPrivateIpAddr"></a> ServerPrivateIpAddr

```csharp
public uint ServerPrivateIpAddr { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerPublicIpAddr"></a> ServerPublicIpAddr

```csharp
public uint ServerPublicIpAddr { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerRegion"></a> ServerRegion

```csharp
public uint ServerRegion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerRelayConnectedSteamId"></a> ServerRelayConnectedSteamId

```csharp
public ulong ServerRelayConnectedSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerTvBroadcastTime"></a> ServerTvBroadcastTime

```csharp
public float ServerTvBroadcastTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerTvPort"></a> ServerTvPort

```csharp
public uint ServerTvPort { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerType"></a> ServerType

```csharp
public CMsgGameServerInfo.Types.ServerType ServerType { get; set; }
```

#### Property Value

 [CMsgGameServerInfo](Divine.Protobufs.Dota2.CMsgGameServerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgGameServerInfo.Types.md).[ServerType](Divine.Protobufs.Dota2.CMsgGameServerInfo.Types.ServerType.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ServerVersion"></a> ServerVersion

```csharp
public uint ServerVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_SrcdsInstance"></a> SrcdsInstance

```csharp
public uint SrcdsInstance { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_TvSecretCode"></a> TvSecretCode

```csharp
public ulong TvSecretCode { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearAllowCustomGames"></a> ClearAllowCustomGames\(\)

```csharp
public void ClearAllowCustomGames()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearAssignedServerTvPort"></a> ClearAssignedServerTvPort\(\)

```csharp
public void ClearAssignedServerTvPort()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearBuildVersion"></a> ClearBuildVersion\(\)

```csharp
public void ClearBuildVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearDevForceServerType"></a> ClearDevForceServerType\(\)

```csharp
public void ClearDevForceServerType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearLegacyServerSteamdatagramAddress"></a> ClearLegacyServerSteamdatagramAddress\(\)

```csharp
public void ClearLegacyServerSteamdatagramAddress()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearParentRelayCount"></a> ClearParentRelayCount\(\)

```csharp
public void ClearParentRelayCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearRelayClientsConnected"></a> ClearRelayClientsConnected\(\)

```csharp
public void ClearRelayClientsConnected()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearRelayedGameServerSteamId"></a> ClearRelayedGameServerSteamId\(\)

```csharp
public void ClearRelayedGameServerSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearRelaysConnected"></a> ClearRelaysConnected\(\)

```csharp
public void ClearRelaysConnected()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearRelaySlotsMax"></a> ClearRelaySlotsMax\(\)

```csharp
public void ClearRelaySlotsMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearServerCluster"></a> ClearServerCluster\(\)

```csharp
public void ClearServerCluster()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearServerGameTime"></a> ClearServerGameTime\(\)

```csharp
public void ClearServerGameTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearServerHibernation"></a> ClearServerHibernation\(\)

```csharp
public void ClearServerHibernation()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearServerKey"></a> ClearServerKey\(\)

```csharp
public void ClearServerKey()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearServerLoadavg"></a> ClearServerLoadavg\(\)

```csharp
public void ClearServerLoadavg()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearServerPort"></a> ClearServerPort\(\)

```csharp
public void ClearServerPort()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearServerPrivateIpAddr"></a> ClearServerPrivateIpAddr\(\)

```csharp
public void ClearServerPrivateIpAddr()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearServerPublicIpAddr"></a> ClearServerPublicIpAddr\(\)

```csharp
public void ClearServerPublicIpAddr()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearServerRegion"></a> ClearServerRegion\(\)

```csharp
public void ClearServerRegion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearServerRelayConnectedSteamId"></a> ClearServerRelayConnectedSteamId\(\)

```csharp
public void ClearServerRelayConnectedSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearServerTvBroadcastTime"></a> ClearServerTvBroadcastTime\(\)

```csharp
public void ClearServerTvBroadcastTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearServerTvPort"></a> ClearServerTvPort\(\)

```csharp
public void ClearServerTvPort()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearServerType"></a> ClearServerType\(\)

```csharp
public void ClearServerType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearServerVersion"></a> ClearServerVersion\(\)

```csharp
public void ClearServerVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearSrcdsInstance"></a> ClearSrcdsInstance\(\)

```csharp
public void ClearSrcdsInstance()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ClearTvSecretCode"></a> ClearTvSecretCode\(\)

```csharp
public void ClearTvSecretCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_Clone"></a> Clone\(\)

```csharp
public CMsgGameServerInfo Clone()
```

#### Returns

 [CMsgGameServerInfo](Divine.Protobufs.Dota2.CMsgGameServerInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_Equals_Divine_Protobufs_Dota2_CMsgGameServerInfo_"></a> Equals\(CMsgGameServerInfo\)

```csharp
public bool Equals(CMsgGameServerInfo other)
```

#### Parameters

`other` [CMsgGameServerInfo](Divine.Protobufs.Dota2.CMsgGameServerInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgGameServerInfo_"></a> MergeFrom\(CMsgGameServerInfo\)

```csharp
public void MergeFrom(CMsgGameServerInfo other)
```

#### Parameters

`other` [CMsgGameServerInfo](Divine.Protobufs.Dota2.CMsgGameServerInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameServerInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

