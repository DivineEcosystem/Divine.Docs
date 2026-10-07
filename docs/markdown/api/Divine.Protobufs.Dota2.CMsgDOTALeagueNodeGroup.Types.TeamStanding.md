# <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding"></a> Class CMsgDOTALeagueNodeGroup.Types.TeamStanding

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeagueNodeGroup.Types.TeamStanding : IMessage<CMsgDOTALeagueNodeGroup.Types.TeamStanding>, IEquatable<CMsgDOTALeagueNodeGroup.Types.TeamStanding>, IDeepCloneable<CMsgDOTALeagueNodeGroup.Types.TeamStanding>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeagueNodeGroup.Types.TeamStanding](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeGroup.Types.TeamStanding.md)

#### Implements

IMessage<CMsgDOTALeagueNodeGroup.Types.TeamStanding\>, 
[IEquatable<CMsgDOTALeagueNodeGroup.Types.TeamStanding\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeagueNodeGroup.Types.TeamStanding\>, 
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
[EnumerableExtensions.In<CMsgDOTALeagueNodeGroup.Types.TeamStanding\>\(CMsgDOTALeagueNodeGroup.Types.TeamStanding, params CMsgDOTALeagueNodeGroup.Types.TeamStanding\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding__ctor"></a> TeamStanding\(\)

```csharp
public TeamStanding()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding__ctor_Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_"></a> TeamStanding\(TeamStanding\)

```csharp
public TeamStanding(CMsgDOTALeagueNodeGroup.Types.TeamStanding other)
```

#### Parameters

`other` [CMsgDOTALeagueNodeGroup](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeGroup.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeGroup.Types.md).[TeamStanding](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeGroup.Types.TeamStanding.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_IsProFieldNumber"></a> IsProFieldNumber

```csharp
public const int IsProFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_LossesFieldNumber"></a> LossesFieldNumber

```csharp
public const int LossesFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_ScoreFieldNumber"></a> ScoreFieldNumber

```csharp
public const int ScoreFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_StandingFieldNumber"></a> StandingFieldNumber

```csharp
public const int StandingFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TeamAbbreviationFieldNumber"></a> TeamAbbreviationFieldNumber

```csharp
public const int TeamAbbreviationFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TeamLogoFieldNumber"></a> TeamLogoFieldNumber

```csharp
public const int TeamLogoFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TeamLogoUrlFieldNumber"></a> TeamLogoUrlFieldNumber

```csharp
public const int TeamLogoUrlFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TeamNameFieldNumber"></a> TeamNameFieldNumber

```csharp
public const int TeamNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TeamTagFieldNumber"></a> TeamTagFieldNumber

```csharp
public const int TeamTagFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TiebereakAverageGameLengthFieldNumber"></a> TiebereakAverageGameLengthFieldNumber

```csharp
public const int TiebereakAverageGameLengthFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TiebreakCoinflipFieldNumber"></a> TiebreakCoinflipFieldNumber

```csharp
public const int TiebreakCoinflipFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TiebreakGameWinPctFieldNumber"></a> TiebreakGameWinPctFieldNumber

```csharp
public const int TiebreakGameWinPctFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TiebreakOpponentGameWinPctFieldNumber"></a> TiebreakOpponentGameWinPctFieldNumber

```csharp
public const int TiebreakOpponentGameWinPctFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TiebreakOpponentMatchWinsFieldNumber"></a> TiebreakOpponentMatchWinsFieldNumber

```csharp
public const int TiebreakOpponentMatchWinsFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_WinsFieldNumber"></a> WinsFieldNumber

```csharp
public const int WinsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_HasIsPro"></a> HasIsPro

```csharp
public bool HasIsPro { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_HasLosses"></a> HasLosses

```csharp
public bool HasLosses { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_HasScore"></a> HasScore

```csharp
public bool HasScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_HasStanding"></a> HasStanding

```csharp
public bool HasStanding { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_HasTeamAbbreviation"></a> HasTeamAbbreviation

```csharp
public bool HasTeamAbbreviation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_HasTeamLogo"></a> HasTeamLogo

```csharp
public bool HasTeamLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_HasTeamLogoUrl"></a> HasTeamLogoUrl

```csharp
public bool HasTeamLogoUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_HasTeamName"></a> HasTeamName

```csharp
public bool HasTeamName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_HasTeamTag"></a> HasTeamTag

```csharp
public bool HasTeamTag { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_HasTiebereakAverageGameLength"></a> HasTiebereakAverageGameLength

```csharp
public bool HasTiebereakAverageGameLength { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_HasTiebreakCoinflip"></a> HasTiebreakCoinflip

```csharp
public bool HasTiebreakCoinflip { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_HasTiebreakGameWinPct"></a> HasTiebreakGameWinPct

```csharp
public bool HasTiebreakGameWinPct { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_HasTiebreakOpponentGameWinPct"></a> HasTiebreakOpponentGameWinPct

```csharp
public bool HasTiebreakOpponentGameWinPct { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_HasTiebreakOpponentMatchWins"></a> HasTiebreakOpponentMatchWins

```csharp
public bool HasTiebreakOpponentMatchWins { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_HasWins"></a> HasWins

```csharp
public bool HasWins { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_IsPro"></a> IsPro

```csharp
public bool IsPro { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_Losses"></a> Losses

```csharp
public uint Losses { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeagueNodeGroup.Types.TeamStanding> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeagueNodeGroup](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeGroup.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeGroup.Types.md).[TeamStanding](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeGroup.Types.TeamStanding.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_Score"></a> Score

```csharp
public long Score { get; set; }
```

#### Property Value

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_Standing"></a> Standing

```csharp
public uint Standing { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TeamAbbreviation"></a> TeamAbbreviation

```csharp
public string TeamAbbreviation { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TeamLogo"></a> TeamLogo

```csharp
public ulong TeamLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TeamLogoUrl"></a> TeamLogoUrl

```csharp
public string TeamLogoUrl { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TeamName"></a> TeamName

```csharp
public string TeamName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TeamTag"></a> TeamTag

```csharp
public string TeamTag { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TiebereakAverageGameLength"></a> TiebereakAverageGameLength

```csharp
public uint TiebereakAverageGameLength { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TiebreakCoinflip"></a> TiebreakCoinflip

```csharp
public uint TiebreakCoinflip { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TiebreakGameWinPct"></a> TiebreakGameWinPct

```csharp
public uint TiebreakGameWinPct { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TiebreakOpponentGameWinPct"></a> TiebreakOpponentGameWinPct

```csharp
public uint TiebreakOpponentGameWinPct { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_TiebreakOpponentMatchWins"></a> TiebreakOpponentMatchWins

```csharp
public uint TiebreakOpponentMatchWins { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_Wins"></a> Wins

```csharp
public uint Wins { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_ClearIsPro"></a> ClearIsPro\(\)

```csharp
public void ClearIsPro()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_ClearLosses"></a> ClearLosses\(\)

```csharp
public void ClearLosses()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_ClearScore"></a> ClearScore\(\)

```csharp
public void ClearScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_ClearStanding"></a> ClearStanding\(\)

```csharp
public void ClearStanding()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_ClearTeamAbbreviation"></a> ClearTeamAbbreviation\(\)

```csharp
public void ClearTeamAbbreviation()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_ClearTeamLogo"></a> ClearTeamLogo\(\)

```csharp
public void ClearTeamLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_ClearTeamLogoUrl"></a> ClearTeamLogoUrl\(\)

```csharp
public void ClearTeamLogoUrl()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_ClearTeamName"></a> ClearTeamName\(\)

```csharp
public void ClearTeamName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_ClearTeamTag"></a> ClearTeamTag\(\)

```csharp
public void ClearTeamTag()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_ClearTiebereakAverageGameLength"></a> ClearTiebereakAverageGameLength\(\)

```csharp
public void ClearTiebereakAverageGameLength()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_ClearTiebreakCoinflip"></a> ClearTiebreakCoinflip\(\)

```csharp
public void ClearTiebreakCoinflip()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_ClearTiebreakGameWinPct"></a> ClearTiebreakGameWinPct\(\)

```csharp
public void ClearTiebreakGameWinPct()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_ClearTiebreakOpponentGameWinPct"></a> ClearTiebreakOpponentGameWinPct\(\)

```csharp
public void ClearTiebreakOpponentGameWinPct()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_ClearTiebreakOpponentMatchWins"></a> ClearTiebreakOpponentMatchWins\(\)

```csharp
public void ClearTiebreakOpponentMatchWins()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_ClearWins"></a> ClearWins\(\)

```csharp
public void ClearWins()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeagueNodeGroup.Types.TeamStanding Clone()
```

#### Returns

 [CMsgDOTALeagueNodeGroup](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeGroup.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeGroup.Types.md).[TeamStanding](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeGroup.Types.TeamStanding.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_Equals_Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_"></a> Equals\(TeamStanding\)

```csharp
public bool Equals(CMsgDOTALeagueNodeGroup.Types.TeamStanding other)
```

#### Parameters

`other` [CMsgDOTALeagueNodeGroup](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeGroup.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeGroup.Types.md).[TeamStanding](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeGroup.Types.TeamStanding.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_"></a> MergeFrom\(TeamStanding\)

```csharp
public void MergeFrom(CMsgDOTALeagueNodeGroup.Types.TeamStanding other)
```

#### Parameters

`other` [CMsgDOTALeagueNodeGroup](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeGroup.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeGroup.Types.md).[TeamStanding](Divine.Protobufs.Dota2.CMsgDOTALeagueNodeGroup.Types.TeamStanding.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNodeGroup_Types_TeamStanding_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

