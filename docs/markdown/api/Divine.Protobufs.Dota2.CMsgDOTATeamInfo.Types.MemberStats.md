# <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats"></a> Class CMsgDOTATeamInfo.Types.MemberStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATeamInfo.Types.MemberStats : IMessage<CMsgDOTATeamInfo.Types.MemberStats>, IEquatable<CMsgDOTATeamInfo.Types.MemberStats>, IDeepCloneable<CMsgDOTATeamInfo.Types.MemberStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATeamInfo.Types.MemberStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.MemberStats.md)

#### Implements

IMessage<CMsgDOTATeamInfo.Types.MemberStats\>, 
[IEquatable<CMsgDOTATeamInfo.Types.MemberStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATeamInfo.Types.MemberStats\>, 
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
[EnumerableExtensions.In<CMsgDOTATeamInfo.Types.MemberStats\>\(CMsgDOTATeamInfo.Types.MemberStats, params CMsgDOTATeamInfo.Types.MemberStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats__ctor"></a> MemberStats\(\)

```csharp
public MemberStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats__ctor_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_"></a> MemberStats\(MemberStats\)

```csharp
public MemberStats(CMsgDOTATeamInfo.Types.MemberStats other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[MemberStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.MemberStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_AvgAssistsFieldNumber"></a> AvgAssistsFieldNumber

```csharp
public const int AvgAssistsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_AvgDeathsFieldNumber"></a> AvgDeathsFieldNumber

```csharp
public const int AvgDeathsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_AvgKillsFieldNumber"></a> AvgKillsFieldNumber

```csharp
public const int AvgKillsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_LossesWithTeamFieldNumber"></a> LossesWithTeamFieldNumber

```csharp
public const int LossesWithTeamFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_TopHeroesFieldNumber"></a> TopHeroesFieldNumber

```csharp
public const int TopHeroesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_WinsWithTeamFieldNumber"></a> WinsWithTeamFieldNumber

```csharp
public const int WinsWithTeamFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_AvgAssists"></a> AvgAssists

```csharp
public float AvgAssists { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_AvgDeaths"></a> AvgDeaths

```csharp
public float AvgDeaths { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_AvgKills"></a> AvgKills

```csharp
public float AvgKills { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_HasAvgAssists"></a> HasAvgAssists

```csharp
public bool HasAvgAssists { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_HasAvgDeaths"></a> HasAvgDeaths

```csharp
public bool HasAvgDeaths { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_HasAvgKills"></a> HasAvgKills

```csharp
public bool HasAvgKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_HasLossesWithTeam"></a> HasLossesWithTeam

```csharp
public bool HasLossesWithTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_HasWinsWithTeam"></a> HasWinsWithTeam

```csharp
public bool HasWinsWithTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_LossesWithTeam"></a> LossesWithTeam

```csharp
public uint LossesWithTeam { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATeamInfo.Types.MemberStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[MemberStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.MemberStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_TopHeroes"></a> TopHeroes

```csharp
public RepeatedField<CMsgDOTATeamInfo.Types.HeroStats> TopHeroes { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[HeroStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.HeroStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_WinsWithTeam"></a> WinsWithTeam

```csharp
public uint WinsWithTeam { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_ClearAvgAssists"></a> ClearAvgAssists\(\)

```csharp
public void ClearAvgAssists()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_ClearAvgDeaths"></a> ClearAvgDeaths\(\)

```csharp
public void ClearAvgDeaths()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_ClearAvgKills"></a> ClearAvgKills\(\)

```csharp
public void ClearAvgKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_ClearLossesWithTeam"></a> ClearLossesWithTeam\(\)

```csharp
public void ClearLossesWithTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_ClearWinsWithTeam"></a> ClearWinsWithTeam\(\)

```csharp
public void ClearWinsWithTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATeamInfo.Types.MemberStats Clone()
```

#### Returns

 [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[MemberStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.MemberStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_Equals_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_"></a> Equals\(MemberStats\)

```csharp
public bool Equals(CMsgDOTATeamInfo.Types.MemberStats other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[MemberStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.MemberStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_"></a> MergeFrom\(MemberStats\)

```csharp
public void MergeFrom(CMsgDOTATeamInfo.Types.MemberStats other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[MemberStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.MemberStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_MemberStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

