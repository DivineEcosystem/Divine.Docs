# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState"></a> Class CMsgSteamLearnPlayerMatchState

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnPlayerMatchState : IMessage<CMsgSteamLearnPlayerMatchState>, IEquatable<CMsgSteamLearnPlayerMatchState>, IDeepCloneable<CMsgSteamLearnPlayerMatchState>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnPlayerMatchState](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerMatchState.md)

#### Implements

IMessage<CMsgSteamLearnPlayerMatchState\>, 
[IEquatable<CMsgSteamLearnPlayerMatchState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnPlayerMatchState\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnPlayerMatchState\>\(CMsgSteamLearnPlayerMatchState, params CMsgSteamLearnPlayerMatchState\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState__ctor"></a> CMsgSteamLearnPlayerMatchState\(\)

```csharp
public CMsgSteamLearnPlayerMatchState()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_"></a> CMsgSteamLearnPlayerMatchState\(CMsgSteamLearnPlayerMatchState\)

```csharp
public CMsgSteamLearnPlayerMatchState(CMsgSteamLearnPlayerMatchState other)
```

#### Parameters

`other` [CMsgSteamLearnPlayerMatchState](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerMatchState.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_DeathsFieldNumber"></a> DeathsFieldNumber

```csharp
public const int DeathsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_EnemyTeamKillsFieldNumber"></a> EnemyTeamKillsFieldNumber

```csharp
public const int EnemyTeamKillsFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_EnemyTeamNetWorthFieldNumber"></a> EnemyTeamNetWorthFieldNumber

```csharp
public const int EnemyTeamNetWorthFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_GameTimeFieldNumber"></a> GameTimeFieldNumber

```csharp
public const int GameTimeFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_HasAegisFieldNumber"></a> HasAegisFieldNumber

```csharp
public const int HasAegisFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_HasBuybackFieldNumber"></a> HasBuybackFieldNumber

```csharp
public const int HasBuybackFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_HasRapierFieldNumber"></a> HasRapierFieldNumber

```csharp
public const int HasRapierFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_LevelFieldNumber"></a> LevelFieldNumber

```csharp
public const int LevelFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_NetWorthFieldNumber"></a> NetWorthFieldNumber

```csharp
public const int NetWorthFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_RespawnTimeFieldNumber"></a> RespawnTimeFieldNumber

```csharp
public const int RespawnTimeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_TeamKillsFieldNumber"></a> TeamKillsFieldNumber

```csharp
public const int TeamKillsFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_TeamNetWorthFieldNumber"></a> TeamNetWorthFieldNumber

```csharp
public const int TeamNetWorthFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_Deaths"></a> Deaths

```csharp
public uint Deaths { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_EnemyTeamKills"></a> EnemyTeamKills

```csharp
public uint EnemyTeamKills { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_EnemyTeamNetWorth"></a> EnemyTeamNetWorth

```csharp
public uint EnemyTeamNetWorth { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_GameTime"></a> GameTime

```csharp
public float GameTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_HasAegis"></a> HasAegis

```csharp
public bool HasAegis { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_HasBuyback"></a> HasBuyback

```csharp
public bool HasBuyback { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_HasDeaths"></a> HasDeaths

```csharp
public bool HasDeaths { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_HasEnemyTeamKills"></a> HasEnemyTeamKills

```csharp
public bool HasEnemyTeamKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_HasEnemyTeamNetWorth"></a> HasEnemyTeamNetWorth

```csharp
public bool HasEnemyTeamNetWorth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_HasGameTime"></a> HasGameTime

```csharp
public bool HasGameTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_HasHasAegis"></a> HasHasAegis

```csharp
public bool HasHasAegis { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_HasHasBuyback"></a> HasHasBuyback

```csharp
public bool HasHasBuyback { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_HasHasRapier"></a> HasHasRapier

```csharp
public bool HasHasRapier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_HasLevel"></a> HasLevel

```csharp
public bool HasLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_HasNetWorth"></a> HasNetWorth

```csharp
public bool HasNetWorth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_HasRapier"></a> HasRapier

```csharp
public bool HasRapier { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_HasRespawnTime"></a> HasRespawnTime

```csharp
public bool HasRespawnTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_HasTeamKills"></a> HasTeamKills

```csharp
public bool HasTeamKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_HasTeamNetWorth"></a> HasTeamNetWorth

```csharp
public bool HasTeamNetWorth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_Level"></a> Level

```csharp
public uint Level { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_NetWorth"></a> NetWorth

```csharp
public uint NetWorth { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnPlayerMatchState> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnPlayerMatchState](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerMatchState.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_RespawnTime"></a> RespawnTime

```csharp
public uint RespawnTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_TeamKills"></a> TeamKills

```csharp
public uint TeamKills { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_TeamNetWorth"></a> TeamNetWorth

```csharp
public uint TeamNetWorth { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_ClearDeaths"></a> ClearDeaths\(\)

```csharp
public void ClearDeaths()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_ClearEnemyTeamKills"></a> ClearEnemyTeamKills\(\)

```csharp
public void ClearEnemyTeamKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_ClearEnemyTeamNetWorth"></a> ClearEnemyTeamNetWorth\(\)

```csharp
public void ClearEnemyTeamNetWorth()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_ClearGameTime"></a> ClearGameTime\(\)

```csharp
public void ClearGameTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_ClearHasAegis"></a> ClearHasAegis\(\)

```csharp
public void ClearHasAegis()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_ClearHasBuyback"></a> ClearHasBuyback\(\)

```csharp
public void ClearHasBuyback()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_ClearHasRapier"></a> ClearHasRapier\(\)

```csharp
public void ClearHasRapier()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_ClearLevel"></a> ClearLevel\(\)

```csharp
public void ClearLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_ClearNetWorth"></a> ClearNetWorth\(\)

```csharp
public void ClearNetWorth()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_ClearRespawnTime"></a> ClearRespawnTime\(\)

```csharp
public void ClearRespawnTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_ClearTeamKills"></a> ClearTeamKills\(\)

```csharp
public void ClearTeamKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_ClearTeamNetWorth"></a> ClearTeamNetWorth\(\)

```csharp
public void ClearTeamNetWorth()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnPlayerMatchState Clone()
```

#### Returns

 [CMsgSteamLearnPlayerMatchState](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerMatchState.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_"></a> Equals\(CMsgSteamLearnPlayerMatchState\)

```csharp
public bool Equals(CMsgSteamLearnPlayerMatchState other)
```

#### Parameters

`other` [CMsgSteamLearnPlayerMatchState](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerMatchState.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_"></a> MergeFrom\(CMsgSteamLearnPlayerMatchState\)

```csharp
public void MergeFrom(CMsgSteamLearnPlayerMatchState other)
```

#### Parameters

`other` [CMsgSteamLearnPlayerMatchState](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerMatchState.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerMatchState_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

