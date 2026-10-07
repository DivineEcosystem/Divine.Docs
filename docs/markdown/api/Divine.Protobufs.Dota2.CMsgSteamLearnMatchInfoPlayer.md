# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer"></a> Class CMsgSteamLearnMatchInfoPlayer

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnMatchInfoPlayer : IMessage<CMsgSteamLearnMatchInfoPlayer>, IEquatable<CMsgSteamLearnMatchInfoPlayer>, IDeepCloneable<CMsgSteamLearnMatchInfoPlayer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnMatchInfoPlayer](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoPlayer.md)

#### Implements

IMessage<CMsgSteamLearnMatchInfoPlayer\>, 
[IEquatable<CMsgSteamLearnMatchInfoPlayer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnMatchInfoPlayer\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnMatchInfoPlayer\>\(CMsgSteamLearnMatchInfoPlayer, params CMsgSteamLearnMatchInfoPlayer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer__ctor"></a> CMsgSteamLearnMatchInfoPlayer\(\)

```csharp
public CMsgSteamLearnMatchInfoPlayer()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_"></a> CMsgSteamLearnMatchInfoPlayer\(CMsgSteamLearnMatchInfoPlayer\)

```csharp
public CMsgSteamLearnMatchInfoPlayer(CMsgSteamLearnMatchInfoPlayer other)
```

#### Parameters

`other` [CMsgSteamLearnMatchInfoPlayer](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoPlayer.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_AverageMmrFieldNumber"></a> AverageMmrFieldNumber

```csharp
public const int AverageMmrFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_GameModeFieldNumber"></a> GameModeFieldNumber

```csharp
public const int GameModeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_LobbyTypeFieldNumber"></a> LobbyTypeFieldNumber

```csharp
public const int LobbyTypeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_PlayerMmrFieldNumber"></a> PlayerMmrFieldNumber

```csharp
public const int PlayerMmrFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_TeamWonFieldNumber"></a> TeamWonFieldNumber

```csharp
public const int TeamWonFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_AverageMmr"></a> AverageMmr

```csharp
public uint AverageMmr { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_Duration"></a> Duration

```csharp
public uint Duration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_GameMode"></a> GameMode

```csharp
public uint GameMode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_HasAverageMmr"></a> HasAverageMmr

```csharp
public bool HasAverageMmr { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_HasGameMode"></a> HasGameMode

```csharp
public bool HasGameMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_HasLobbyType"></a> HasLobbyType

```csharp
public bool HasLobbyType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_HasPlayerMmr"></a> HasPlayerMmr

```csharp
public bool HasPlayerMmr { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_HasTeamWon"></a> HasTeamWon

```csharp
public bool HasTeamWon { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_LobbyType"></a> LobbyType

```csharp
public uint LobbyType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnMatchInfoPlayer> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnMatchInfoPlayer](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoPlayer.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_PlayerMmr"></a> PlayerMmr

```csharp
public uint PlayerMmr { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_TeamWon"></a> TeamWon

```csharp
public bool TeamWon { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_ClearAverageMmr"></a> ClearAverageMmr\(\)

```csharp
public void ClearAverageMmr()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_ClearGameMode"></a> ClearGameMode\(\)

```csharp
public void ClearGameMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_ClearLobbyType"></a> ClearLobbyType\(\)

```csharp
public void ClearLobbyType()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_ClearPlayerMmr"></a> ClearPlayerMmr\(\)

```csharp
public void ClearPlayerMmr()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_ClearTeamWon"></a> ClearTeamWon\(\)

```csharp
public void ClearTeamWon()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnMatchInfoPlayer Clone()
```

#### Returns

 [CMsgSteamLearnMatchInfoPlayer](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoPlayer.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_"></a> Equals\(CMsgSteamLearnMatchInfoPlayer\)

```csharp
public bool Equals(CMsgSteamLearnMatchInfoPlayer other)
```

#### Parameters

`other` [CMsgSteamLearnMatchInfoPlayer](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoPlayer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_"></a> MergeFrom\(CMsgSteamLearnMatchInfoPlayer\)

```csharp
public void MergeFrom(CMsgSteamLearnMatchInfoPlayer other)
```

#### Parameters

`other` [CMsgSteamLearnMatchInfoPlayer](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoPlayer.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoPlayer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

