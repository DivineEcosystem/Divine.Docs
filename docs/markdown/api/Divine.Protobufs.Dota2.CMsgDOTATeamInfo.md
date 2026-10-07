# <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo"></a> Class CMsgDOTATeamInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATeamInfo : IMessage<CMsgDOTATeamInfo>, IEquatable<CMsgDOTATeamInfo>, IDeepCloneable<CMsgDOTATeamInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md)

#### Implements

IMessage<CMsgDOTATeamInfo\>, 
[IEquatable<CMsgDOTATeamInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATeamInfo\>, 
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
[EnumerableExtensions.In<CMsgDOTATeamInfo\>\(CMsgDOTATeamInfo, params CMsgDOTATeamInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo__ctor"></a> CMsgDOTATeamInfo\(\)

```csharp
public CMsgDOTATeamInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo__ctor_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_"></a> CMsgDOTATeamInfo\(CMsgDOTATeamInfo\)

```csharp
public CMsgDOTATeamInfo(CMsgDOTATeamInfo other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_AbbreviationFieldNumber"></a> AbbreviationFieldNumber

```csharp
public const int AbbreviationFieldNumber = 32
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_AuditEntriesFieldNumber"></a> AuditEntriesFieldNumber

```csharp
public const int AuditEntriesFieldNumber = 31
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ColorPrimaryFieldNumber"></a> ColorPrimaryFieldNumber

```csharp
public const int ColorPrimaryFieldNumber = 37
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ColorSecondaryFieldNumber"></a> ColorSecondaryFieldNumber

```csharp
public const int ColorSecondaryFieldNumber = 38
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_CountryCodeFieldNumber"></a> CountryCodeFieldNumber

```csharp
public const int CountryCodeFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_DpcResultsFieldNumber"></a> DpcResultsFieldNumber

```csharp
public const int DpcResultsFieldNumber = 35
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_GamesPlayedMatchmakingFieldNumber"></a> GamesPlayedMatchmakingFieldNumber

```csharp
public const int GamesPlayedMatchmakingFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_GamesPlayedTotalFieldNumber"></a> GamesPlayedTotalFieldNumber

```csharp
public const int GamesPlayedTotalFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_LossesFieldNumber"></a> LossesFieldNumber

```csharp
public const int LossesFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_MembersFieldNumber"></a> MembersFieldNumber

```csharp
public const int MembersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_MemberStatsFieldNumber"></a> MemberStatsFieldNumber

```csharp
public const int MemberStatsFieldNumber = 33
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_PickupTeamFieldNumber"></a> PickupTeamFieldNumber

```csharp
public const int PickupTeamFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ProFieldNumber"></a> ProFieldNumber

```csharp
public const int ProFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_RegionFieldNumber"></a> RegionFieldNumber

```csharp
public const int RegionFieldNumber = 29
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_TagFieldNumber"></a> TagFieldNumber

```csharp
public const int TagFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_TeamCaptainFieldNumber"></a> TeamCaptainFieldNumber

```csharp
public const int TeamCaptainFieldNumber = 39
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_TeamStatsFieldNumber"></a> TeamStatsFieldNumber

```csharp
public const int TeamStatsFieldNumber = 34
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_TimeCreatedFieldNumber"></a> TimeCreatedFieldNumber

```csharp
public const int TimeCreatedFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_UgcBannerLogoFieldNumber"></a> UgcBannerLogoFieldNumber

```csharp
public const int UgcBannerLogoFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_UgcBaseLogoFieldNumber"></a> UgcBaseLogoFieldNumber

```csharp
public const int UgcBaseLogoFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_UgcLogoFieldNumber"></a> UgcLogoFieldNumber

```csharp
public const int UgcLogoFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_UgcSponsorLogoFieldNumber"></a> UgcSponsorLogoFieldNumber

```csharp
public const int UgcSponsorLogoFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_UrlFieldNumber"></a> UrlFieldNumber

```csharp
public const int UrlFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_UrlLogoFieldNumber"></a> UrlLogoFieldNumber

```csharp
public const int UrlLogoFieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_WinsFieldNumber"></a> WinsFieldNumber

```csharp
public const int WinsFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Abbreviation"></a> Abbreviation

```csharp
public string Abbreviation { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_AuditEntries"></a> AuditEntries

```csharp
public RepeatedField<CMsgDOTATeamInfo.Types.AuditEntry> AuditEntries { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[AuditEntry](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.AuditEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ColorPrimary"></a> ColorPrimary

```csharp
public string ColorPrimary { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ColorSecondary"></a> ColorSecondary

```csharp
public string ColorSecondary { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_CountryCode"></a> CountryCode

```csharp
public string CountryCode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_DpcResults"></a> DpcResults

```csharp
public RepeatedField<CMsgDOTATeamInfo.Types.DPCResult> DpcResults { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[DPCResult](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.DPCResult.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_GamesPlayedMatchmaking"></a> GamesPlayedMatchmaking

```csharp
public uint GamesPlayedMatchmaking { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_GamesPlayedTotal"></a> GamesPlayedTotal

```csharp
public uint GamesPlayedTotal { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasAbbreviation"></a> HasAbbreviation

```csharp
public bool HasAbbreviation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasColorPrimary"></a> HasColorPrimary

```csharp
public bool HasColorPrimary { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasColorSecondary"></a> HasColorSecondary

```csharp
public bool HasColorSecondary { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasCountryCode"></a> HasCountryCode

```csharp
public bool HasCountryCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasGamesPlayedMatchmaking"></a> HasGamesPlayedMatchmaking

```csharp
public bool HasGamesPlayedMatchmaking { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasGamesPlayedTotal"></a> HasGamesPlayedTotal

```csharp
public bool HasGamesPlayedTotal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasLosses"></a> HasLosses

```csharp
public bool HasLosses { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasPickupTeam"></a> HasPickupTeam

```csharp
public bool HasPickupTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasPro"></a> HasPro

```csharp
public bool HasPro { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasRegion"></a> HasRegion

```csharp
public bool HasRegion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasTag"></a> HasTag

```csharp
public bool HasTag { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasTeamCaptain"></a> HasTeamCaptain

```csharp
public bool HasTeamCaptain { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasTimeCreated"></a> HasTimeCreated

```csharp
public bool HasTimeCreated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasUgcBannerLogo"></a> HasUgcBannerLogo

```csharp
public bool HasUgcBannerLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasUgcBaseLogo"></a> HasUgcBaseLogo

```csharp
public bool HasUgcBaseLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasUgcLogo"></a> HasUgcLogo

```csharp
public bool HasUgcLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasUgcSponsorLogo"></a> HasUgcSponsorLogo

```csharp
public bool HasUgcSponsorLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasUrl"></a> HasUrl

```csharp
public bool HasUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasUrlLogo"></a> HasUrlLogo

```csharp
public bool HasUrlLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_HasWins"></a> HasWins

```csharp
public bool HasWins { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Losses"></a> Losses

```csharp
public uint Losses { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Members"></a> Members

```csharp
public RepeatedField<CMsgDOTATeamInfo.Types.Member> Members { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[Member](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.Member.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_MemberStats"></a> MemberStats

```csharp
public RepeatedField<CMsgDOTATeamInfo.Types.MemberStats> MemberStats { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[MemberStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.MemberStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATeamInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_PickupTeam"></a> PickupTeam

```csharp
public bool PickupTeam { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Pro"></a> Pro

```csharp
public bool Pro { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Region"></a> Region

```csharp
public ELeagueRegion Region { get; set; }
```

#### Property Value

 [ELeagueRegion](Divine.Protobufs.Dota2.ELeagueRegion.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Tag"></a> Tag

```csharp
public string Tag { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_TeamCaptain"></a> TeamCaptain

```csharp
public uint TeamCaptain { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_TeamStats"></a> TeamStats

```csharp
public CMsgDOTATeamInfo.Types.TeamStats TeamStats { get; set; }
```

#### Property Value

 [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[TeamStats](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.TeamStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_TimeCreated"></a> TimeCreated

```csharp
public uint TimeCreated { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_UgcBannerLogo"></a> UgcBannerLogo

```csharp
public ulong UgcBannerLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_UgcBaseLogo"></a> UgcBaseLogo

```csharp
public ulong UgcBaseLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_UgcLogo"></a> UgcLogo

```csharp
public ulong UgcLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_UgcSponsorLogo"></a> UgcSponsorLogo

```csharp
public ulong UgcSponsorLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Url"></a> Url

```csharp
public string Url { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_UrlLogo"></a> UrlLogo

```csharp
public string UrlLogo { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Wins"></a> Wins

```csharp
public uint Wins { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearAbbreviation"></a> ClearAbbreviation\(\)

```csharp
public void ClearAbbreviation()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearColorPrimary"></a> ClearColorPrimary\(\)

```csharp
public void ClearColorPrimary()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearColorSecondary"></a> ClearColorSecondary\(\)

```csharp
public void ClearColorSecondary()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearCountryCode"></a> ClearCountryCode\(\)

```csharp
public void ClearCountryCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearGamesPlayedMatchmaking"></a> ClearGamesPlayedMatchmaking\(\)

```csharp
public void ClearGamesPlayedMatchmaking()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearGamesPlayedTotal"></a> ClearGamesPlayedTotal\(\)

```csharp
public void ClearGamesPlayedTotal()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearLosses"></a> ClearLosses\(\)

```csharp
public void ClearLosses()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearPickupTeam"></a> ClearPickupTeam\(\)

```csharp
public void ClearPickupTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearPro"></a> ClearPro\(\)

```csharp
public void ClearPro()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearRegion"></a> ClearRegion\(\)

```csharp
public void ClearRegion()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearTag"></a> ClearTag\(\)

```csharp
public void ClearTag()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearTeamCaptain"></a> ClearTeamCaptain\(\)

```csharp
public void ClearTeamCaptain()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearTimeCreated"></a> ClearTimeCreated\(\)

```csharp
public void ClearTimeCreated()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearUgcBannerLogo"></a> ClearUgcBannerLogo\(\)

```csharp
public void ClearUgcBannerLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearUgcBaseLogo"></a> ClearUgcBaseLogo\(\)

```csharp
public void ClearUgcBaseLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearUgcLogo"></a> ClearUgcLogo\(\)

```csharp
public void ClearUgcLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearUgcSponsorLogo"></a> ClearUgcSponsorLogo\(\)

```csharp
public void ClearUgcSponsorLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearUrl"></a> ClearUrl\(\)

```csharp
public void ClearUrl()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearUrlLogo"></a> ClearUrlLogo\(\)

```csharp
public void ClearUrlLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ClearWins"></a> ClearWins\(\)

```csharp
public void ClearWins()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATeamInfo Clone()
```

#### Returns

 [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Equals_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_"></a> Equals\(CMsgDOTATeamInfo\)

```csharp
public bool Equals(CMsgDOTATeamInfo other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_"></a> MergeFrom\(CMsgDOTATeamInfo\)

```csharp
public void MergeFrom(CMsgDOTATeamInfo other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

