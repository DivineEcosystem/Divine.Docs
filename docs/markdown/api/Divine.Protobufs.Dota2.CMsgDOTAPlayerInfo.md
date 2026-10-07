# <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo"></a> Class CMsgDOTAPlayerInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAPlayerInfo : IMessage<CMsgDOTAPlayerInfo>, IEquatable<CMsgDOTAPlayerInfo>, IDeepCloneable<CMsgDOTAPlayerInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md)

#### Implements

IMessage<CMsgDOTAPlayerInfo\>, 
[IEquatable<CMsgDOTAPlayerInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAPlayerInfo\>, 
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
[EnumerableExtensions.In<CMsgDOTAPlayerInfo\>\(CMsgDOTAPlayerInfo, params CMsgDOTAPlayerInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo__ctor"></a> CMsgDOTAPlayerInfo\(\)

```csharp
public CMsgDOTAPlayerInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo__ctor_Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_"></a> CMsgDOTAPlayerInfo\(CMsgDOTAPlayerInfo\)

```csharp
public CMsgDOTAPlayerInfo(CMsgDOTAPlayerInfo other)
```

#### Parameters

`other` [CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_AuditEntriesFieldNumber"></a> AuditEntriesFieldNumber

```csharp
public const int AuditEntriesFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_CountryCodeFieldNumber"></a> CountryCodeFieldNumber

```csharp
public const int CountryCodeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_FantasyRoleFieldNumber"></a> FantasyRoleFieldNumber

```csharp
public const int FantasyRoleFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_HasPlayedInInternationalFieldNumber"></a> HasPlayedInInternationalFieldNumber

```csharp
public const int HasPlayedInInternationalFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_ProRegistrationFieldNumber"></a> ProRegistrationFieldNumber

```csharp
public const int ProRegistrationFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_RealNameFieldNumber"></a> RealNameFieldNumber

```csharp
public const int RealNameFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_ResultsFieldNumber"></a> ResultsFieldNumber

```csharp
public const int ResultsFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_SponsorFieldNumber"></a> SponsorFieldNumber

```csharp
public const int SponsorFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_TeamAbbreviationFieldNumber"></a> TeamAbbreviationFieldNumber

```csharp
public const int TeamAbbreviationFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_TeamNameFieldNumber"></a> TeamNameFieldNumber

```csharp
public const int TeamNameFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_TeamTagFieldNumber"></a> TeamTagFieldNumber

```csharp
public const int TeamTagFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_TeamUrlLogoFieldNumber"></a> TeamUrlLogoFieldNumber

```csharp
public const int TeamUrlLogoFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_TotalEarningsFieldNumber"></a> TotalEarningsFieldNumber

```csharp
public const int TotalEarningsFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_AuditEntries"></a> AuditEntries

```csharp
public RepeatedField<CMsgDOTAPlayerInfo.Types.AuditEntry> AuditEntries { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.md).[AuditEntry](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.AuditEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_CountryCode"></a> CountryCode

```csharp
public string CountryCode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_FantasyRole"></a> FantasyRole

```csharp
public Fantasy_Roles FantasyRole { get; set; }
```

#### Property Value

 [Fantasy\_Roles](Divine.Protobufs.Dota2.Fantasy\_Roles.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_HasCountryCode"></a> HasCountryCode

```csharp
public bool HasCountryCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_HasFantasyRole"></a> HasFantasyRole

```csharp
public bool HasFantasyRole { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_HasHasPlayedInInternational"></a> HasHasPlayedInInternational

```csharp
public bool HasHasPlayedInInternational { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_HasPlayedInInternational"></a> HasPlayedInInternational

```csharp
public bool HasPlayedInInternational { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_HasRealName"></a> HasRealName

```csharp
public bool HasRealName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_HasSponsor"></a> HasSponsor

```csharp
public bool HasSponsor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_HasTeamAbbreviation"></a> HasTeamAbbreviation

```csharp
public bool HasTeamAbbreviation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_HasTeamName"></a> HasTeamName

```csharp
public bool HasTeamName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_HasTeamTag"></a> HasTeamTag

```csharp
public bool HasTeamTag { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_HasTeamUrlLogo"></a> HasTeamUrlLogo

```csharp
public bool HasTeamUrlLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_HasTotalEarnings"></a> HasTotalEarnings

```csharp
public bool HasTotalEarnings { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAPlayerInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_ProRegistration"></a> ProRegistration

```csharp
public RepeatedField<CMsgDOTAPlayerInfo.Types.ProRegistration> ProRegistration { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.md).[ProRegistration](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.ProRegistration.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_RealName"></a> RealName

```csharp
public string RealName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Results"></a> Results

```csharp
public RepeatedField<CMsgDOTAPlayerInfo.Types.Results> Results { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.md).[Results](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.Results.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Sponsor"></a> Sponsor

```csharp
public string Sponsor { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_TeamAbbreviation"></a> TeamAbbreviation

```csharp
public string TeamAbbreviation { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_TeamName"></a> TeamName

```csharp
public string TeamName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_TeamTag"></a> TeamTag

```csharp
public string TeamTag { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_TeamUrlLogo"></a> TeamUrlLogo

```csharp
public string TeamUrlLogo { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_TotalEarnings"></a> TotalEarnings

```csharp
public uint TotalEarnings { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_ClearCountryCode"></a> ClearCountryCode\(\)

```csharp
public void ClearCountryCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_ClearFantasyRole"></a> ClearFantasyRole\(\)

```csharp
public void ClearFantasyRole()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_ClearHasPlayedInInternational"></a> ClearHasPlayedInInternational\(\)

```csharp
public void ClearHasPlayedInInternational()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_ClearRealName"></a> ClearRealName\(\)

```csharp
public void ClearRealName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_ClearSponsor"></a> ClearSponsor\(\)

```csharp
public void ClearSponsor()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_ClearTeamAbbreviation"></a> ClearTeamAbbreviation\(\)

```csharp
public void ClearTeamAbbreviation()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_ClearTeamName"></a> ClearTeamName\(\)

```csharp
public void ClearTeamName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_ClearTeamTag"></a> ClearTeamTag\(\)

```csharp
public void ClearTeamTag()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_ClearTeamUrlLogo"></a> ClearTeamUrlLogo\(\)

```csharp
public void ClearTeamUrlLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_ClearTotalEarnings"></a> ClearTotalEarnings\(\)

```csharp
public void ClearTotalEarnings()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAPlayerInfo Clone()
```

#### Returns

 [CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Equals_Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_"></a> Equals\(CMsgDOTAPlayerInfo\)

```csharp
public bool Equals(CMsgDOTAPlayerInfo other)
```

#### Parameters

`other` [CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_"></a> MergeFrom\(CMsgDOTAPlayerInfo\)

```csharp
public void MergeFrom(CMsgDOTAPlayerInfo other)
```

#### Parameters

`other` [CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

