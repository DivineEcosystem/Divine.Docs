# <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats"></a> Class CMsgDOTATeamInfo.Types.HeroStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATeamInfo.Types.HeroStats : IMessage<CMsgDOTATeamInfo.Types.HeroStats>, IEquatable<CMsgDOTATeamInfo.Types.HeroStats>, IDeepCloneable<CMsgDOTATeamInfo.Types.HeroStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATeamInfo.Types.HeroStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.HeroStats.md)

#### Implements

IMessage<CMsgDOTATeamInfo.Types.HeroStats\>, 
[IEquatable<CMsgDOTATeamInfo.Types.HeroStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATeamInfo.Types.HeroStats\>, 
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
[EnumerableExtensions.In<CMsgDOTATeamInfo.Types.HeroStats\>\(CMsgDOTATeamInfo.Types.HeroStats, params CMsgDOTATeamInfo.Types.HeroStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats__ctor"></a> HeroStats\(\)

```csharp
public HeroStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats__ctor_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_"></a> HeroStats\(HeroStats\)

```csharp
public HeroStats(CMsgDOTATeamInfo.Types.HeroStats other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[HeroStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.HeroStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_AvgAssistsFieldNumber"></a> AvgAssistsFieldNumber

```csharp
public const int AvgAssistsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_AvgDeathsFieldNumber"></a> AvgDeathsFieldNumber

```csharp
public const int AvgDeathsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_AvgGpmFieldNumber"></a> AvgGpmFieldNumber

```csharp
public const int AvgGpmFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_AvgKillsFieldNumber"></a> AvgKillsFieldNumber

```csharp
public const int AvgKillsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_AvgXpmFieldNumber"></a> AvgXpmFieldNumber

```csharp
public const int AvgXpmFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_BansFieldNumber"></a> BansFieldNumber

```csharp
public const int BansFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_PicksFieldNumber"></a> PicksFieldNumber

```csharp
public const int PicksFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_WinsFieldNumber"></a> WinsFieldNumber

```csharp
public const int WinsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_AvgAssists"></a> AvgAssists

```csharp
public float AvgAssists { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_AvgDeaths"></a> AvgDeaths

```csharp
public float AvgDeaths { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_AvgGpm"></a> AvgGpm

```csharp
public float AvgGpm { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_AvgKills"></a> AvgKills

```csharp
public float AvgKills { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_AvgXpm"></a> AvgXpm

```csharp
public float AvgXpm { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_Bans"></a> Bans

```csharp
public uint Bans { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_HasAvgAssists"></a> HasAvgAssists

```csharp
public bool HasAvgAssists { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_HasAvgDeaths"></a> HasAvgDeaths

```csharp
public bool HasAvgDeaths { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_HasAvgGpm"></a> HasAvgGpm

```csharp
public bool HasAvgGpm { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_HasAvgKills"></a> HasAvgKills

```csharp
public bool HasAvgKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_HasAvgXpm"></a> HasAvgXpm

```csharp
public bool HasAvgXpm { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_HasBans"></a> HasBans

```csharp
public bool HasBans { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_HasPicks"></a> HasPicks

```csharp
public bool HasPicks { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_HasWins"></a> HasWins

```csharp
public bool HasWins { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATeamInfo.Types.HeroStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[HeroStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.HeroStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_Picks"></a> Picks

```csharp
public uint Picks { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_Wins"></a> Wins

```csharp
public uint Wins { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_ClearAvgAssists"></a> ClearAvgAssists\(\)

```csharp
public void ClearAvgAssists()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_ClearAvgDeaths"></a> ClearAvgDeaths\(\)

```csharp
public void ClearAvgDeaths()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_ClearAvgGpm"></a> ClearAvgGpm\(\)

```csharp
public void ClearAvgGpm()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_ClearAvgKills"></a> ClearAvgKills\(\)

```csharp
public void ClearAvgKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_ClearAvgXpm"></a> ClearAvgXpm\(\)

```csharp
public void ClearAvgXpm()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_ClearBans"></a> ClearBans\(\)

```csharp
public void ClearBans()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_ClearPicks"></a> ClearPicks\(\)

```csharp
public void ClearPicks()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_ClearWins"></a> ClearWins\(\)

```csharp
public void ClearWins()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATeamInfo.Types.HeroStats Clone()
```

#### Returns

 [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[HeroStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.HeroStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_Equals_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_"></a> Equals\(HeroStats\)

```csharp
public bool Equals(CMsgDOTATeamInfo.Types.HeroStats other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[HeroStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.HeroStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_"></a> MergeFrom\(HeroStats\)

```csharp
public void MergeFrom(CMsgDOTATeamInfo.Types.HeroStats other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[HeroStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.HeroStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_HeroStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

