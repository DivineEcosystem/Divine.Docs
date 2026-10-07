# <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats"></a> Class CMsgDOTATeamInfo.Types.TeamStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATeamInfo.Types.TeamStats : IMessage<CMsgDOTATeamInfo.Types.TeamStats>, IEquatable<CMsgDOTATeamInfo.Types.TeamStats>, IDeepCloneable<CMsgDOTATeamInfo.Types.TeamStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATeamInfo.Types.TeamStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.TeamStats.md)

#### Implements

IMessage<CMsgDOTATeamInfo.Types.TeamStats\>, 
[IEquatable<CMsgDOTATeamInfo.Types.TeamStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATeamInfo.Types.TeamStats\>, 
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
[EnumerableExtensions.In<CMsgDOTATeamInfo.Types.TeamStats\>\(CMsgDOTATeamInfo.Types.TeamStats, params CMsgDOTATeamInfo.Types.TeamStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats__ctor"></a> TeamStats\(\)

```csharp
public TeamStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats__ctor_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_"></a> TeamStats\(TeamStats\)

```csharp
public TeamStats(CMsgDOTATeamInfo.Types.TeamStats other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[TeamStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.TeamStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_AvgDeathsFieldNumber"></a> AvgDeathsFieldNumber

```csharp
public const int AvgDeathsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_AvgDurationFieldNumber"></a> AvgDurationFieldNumber

```csharp
public const int AvgDurationFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_AvgKillsFieldNumber"></a> AvgKillsFieldNumber

```csharp
public const int AvgKillsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_FarmingFieldNumber"></a> FarmingFieldNumber

```csharp
public const int FarmingFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_FightingFieldNumber"></a> FightingFieldNumber

```csharp
public const int FightingFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_PlayedHeroesFieldNumber"></a> PlayedHeroesFieldNumber

```csharp
public const int PlayedHeroesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_VersatilityFieldNumber"></a> VersatilityFieldNumber

```csharp
public const int VersatilityFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_AvgDeaths"></a> AvgDeaths

```csharp
public float AvgDeaths { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_AvgDuration"></a> AvgDuration

```csharp
public float AvgDuration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_AvgKills"></a> AvgKills

```csharp
public float AvgKills { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_Farming"></a> Farming

```csharp
public float Farming { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_Fighting"></a> Fighting

```csharp
public float Fighting { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_HasAvgDeaths"></a> HasAvgDeaths

```csharp
public bool HasAvgDeaths { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_HasAvgDuration"></a> HasAvgDuration

```csharp
public bool HasAvgDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_HasAvgKills"></a> HasAvgKills

```csharp
public bool HasAvgKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_HasFarming"></a> HasFarming

```csharp
public bool HasFarming { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_HasFighting"></a> HasFighting

```csharp
public bool HasFighting { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_HasVersatility"></a> HasVersatility

```csharp
public bool HasVersatility { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATeamInfo.Types.TeamStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[TeamStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.TeamStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_PlayedHeroes"></a> PlayedHeroes

```csharp
public RepeatedField<CMsgDOTATeamInfo.Types.HeroStats> PlayedHeroes { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[HeroStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.HeroStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_Versatility"></a> Versatility

```csharp
public float Versatility { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_ClearAvgDeaths"></a> ClearAvgDeaths\(\)

```csharp
public void ClearAvgDeaths()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_ClearAvgDuration"></a> ClearAvgDuration\(\)

```csharp
public void ClearAvgDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_ClearAvgKills"></a> ClearAvgKills\(\)

```csharp
public void ClearAvgKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_ClearFarming"></a> ClearFarming\(\)

```csharp
public void ClearFarming()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_ClearFighting"></a> ClearFighting\(\)

```csharp
public void ClearFighting()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_ClearVersatility"></a> ClearVersatility\(\)

```csharp
public void ClearVersatility()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATeamInfo.Types.TeamStats Clone()
```

#### Returns

 [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[TeamStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.TeamStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_Equals_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_"></a> Equals\(TeamStats\)

```csharp
public bool Equals(CMsgDOTATeamInfo.Types.TeamStats other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[TeamStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.TeamStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_"></a> MergeFrom\(TeamStats\)

```csharp
public void MergeFrom(CMsgDOTATeamInfo.Types.TeamStats other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[TeamStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.TeamStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_TeamStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

