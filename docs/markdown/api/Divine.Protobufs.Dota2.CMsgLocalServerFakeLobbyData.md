# <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData"></a> Class CMsgLocalServerFakeLobbyData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLocalServerFakeLobbyData : IMessage<CMsgLocalServerFakeLobbyData>, IEquatable<CMsgLocalServerFakeLobbyData>, IDeepCloneable<CMsgLocalServerFakeLobbyData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLocalServerFakeLobbyData](Divine.Protobufs.Dota2.CMsgLocalServerFakeLobbyData.md)

#### Implements

IMessage<CMsgLocalServerFakeLobbyData\>, 
[IEquatable<CMsgLocalServerFakeLobbyData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLocalServerFakeLobbyData\>, 
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
[EnumerableExtensions.In<CMsgLocalServerFakeLobbyData\>\(CMsgLocalServerFakeLobbyData, params CMsgLocalServerFakeLobbyData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData__ctor"></a> CMsgLocalServerFakeLobbyData\(\)

```csharp
public CMsgLocalServerFakeLobbyData()
```

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData__ctor_Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_"></a> CMsgLocalServerFakeLobbyData\(CMsgLocalServerFakeLobbyData\)

```csharp
public CMsgLocalServerFakeLobbyData(CMsgLocalServerFakeLobbyData other)
```

#### Parameters

`other` [CMsgLocalServerFakeLobbyData](Divine.Protobufs.Dota2.CMsgLocalServerFakeLobbyData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_AdditionalDataFieldNumber"></a> AdditionalDataFieldNumber

```csharp
public const int AdditionalDataFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_EventPointsFieldNumber"></a> EventPointsFieldNumber

```csharp
public const int EventPointsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_FavoriteTeamFieldNumber"></a> FavoriteTeamFieldNumber

```csharp
public const int FavoriteTeamFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_FavoriteTeamQualityFieldNumber"></a> FavoriteTeamQualityFieldNumber

```csharp
public const int FavoriteTeamQualityFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_GuildInfoFieldNumber"></a> GuildInfoFieldNumber

```csharp
public const int GuildInfoFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_IsPlusSubscriberFieldNumber"></a> IsPlusSubscriberFieldNumber

```csharp
public const int IsPlusSubscriberFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_PrimaryEventIdFieldNumber"></a> PrimaryEventIdFieldNumber

```csharp
public const int PrimaryEventIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_TeleportFxLevelFieldNumber"></a> TeleportFxLevelFieldNumber

```csharp
public const int TeleportFxLevelFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_AdditionalData"></a> AdditionalData

```csharp
public CMsgAdditionalLobbyStartupAccountData AdditionalData { get; set; }
```

#### Property Value

 [CMsgAdditionalLobbyStartupAccountData](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.md)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_EventPoints"></a> EventPoints

```csharp
public RepeatedField<CMsgLobbyEventPoints> EventPoints { get; }
```

#### Property Value

 RepeatedField<[CMsgLobbyEventPoints](Divine.Protobufs.Dota2.CMsgLobbyEventPoints.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_FavoriteTeam"></a> FavoriteTeam

```csharp
public uint FavoriteTeam { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_FavoriteTeamQuality"></a> FavoriteTeamQuality

```csharp
public uint FavoriteTeamQuality { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_GuildInfo"></a> GuildInfo

```csharp
public CMsgLocalServerGuildData GuildInfo { get; set; }
```

#### Property Value

 [CMsgLocalServerGuildData](Divine.Protobufs.Dota2.CMsgLocalServerGuildData.md)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_HasFavoriteTeam"></a> HasFavoriteTeam

```csharp
public bool HasFavoriteTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_HasFavoriteTeamQuality"></a> HasFavoriteTeamQuality

```csharp
public bool HasFavoriteTeamQuality { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_HasIsPlusSubscriber"></a> HasIsPlusSubscriber

```csharp
public bool HasIsPlusSubscriber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_HasPrimaryEventId"></a> HasPrimaryEventId

```csharp
public bool HasPrimaryEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_HasTeleportFxLevel"></a> HasTeleportFxLevel

```csharp
public bool HasTeleportFxLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_IsPlusSubscriber"></a> IsPlusSubscriber

```csharp
public bool IsPlusSubscriber { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLocalServerFakeLobbyData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLocalServerFakeLobbyData](Divine.Protobufs.Dota2.CMsgLocalServerFakeLobbyData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_PrimaryEventId"></a> PrimaryEventId

```csharp
public uint PrimaryEventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_TeleportFxLevel"></a> TeleportFxLevel

```csharp
public uint TeleportFxLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_ClearFavoriteTeam"></a> ClearFavoriteTeam\(\)

```csharp
public void ClearFavoriteTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_ClearFavoriteTeamQuality"></a> ClearFavoriteTeamQuality\(\)

```csharp
public void ClearFavoriteTeamQuality()
```

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_ClearIsPlusSubscriber"></a> ClearIsPlusSubscriber\(\)

```csharp
public void ClearIsPlusSubscriber()
```

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_ClearPrimaryEventId"></a> ClearPrimaryEventId\(\)

```csharp
public void ClearPrimaryEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_ClearTeleportFxLevel"></a> ClearTeleportFxLevel\(\)

```csharp
public void ClearTeleportFxLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_Clone"></a> Clone\(\)

```csharp
public CMsgLocalServerFakeLobbyData Clone()
```

#### Returns

 [CMsgLocalServerFakeLobbyData](Divine.Protobufs.Dota2.CMsgLocalServerFakeLobbyData.md)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_Equals_Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_"></a> Equals\(CMsgLocalServerFakeLobbyData\)

```csharp
public bool Equals(CMsgLocalServerFakeLobbyData other)
```

#### Parameters

`other` [CMsgLocalServerFakeLobbyData](Divine.Protobufs.Dota2.CMsgLocalServerFakeLobbyData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_MergeFrom_Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_"></a> MergeFrom\(CMsgLocalServerFakeLobbyData\)

```csharp
public void MergeFrom(CMsgLocalServerFakeLobbyData other)
```

#### Parameters

`other` [CMsgLocalServerFakeLobbyData](Divine.Protobufs.Dota2.CMsgLocalServerFakeLobbyData.md)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLocalServerFakeLobbyData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

