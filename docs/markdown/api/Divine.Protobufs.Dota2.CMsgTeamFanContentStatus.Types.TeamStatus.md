# <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus"></a> Class CMsgTeamFanContentStatus.Types.TeamStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTeamFanContentStatus.Types.TeamStatus : IMessage<CMsgTeamFanContentStatus.Types.TeamStatus>, IEquatable<CMsgTeamFanContentStatus.Types.TeamStatus>, IDeepCloneable<CMsgTeamFanContentStatus.Types.TeamStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTeamFanContentStatus.Types.TeamStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.Types.TeamStatus.md)

#### Implements

IMessage<CMsgTeamFanContentStatus.Types.TeamStatus\>, 
[IEquatable<CMsgTeamFanContentStatus.Types.TeamStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTeamFanContentStatus.Types.TeamStatus\>, 
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
[EnumerableExtensions.In<CMsgTeamFanContentStatus.Types.TeamStatus\>\(CMsgTeamFanContentStatus.Types.TeamStatus, params CMsgTeamFanContentStatus.Types.TeamStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus__ctor"></a> TeamStatus\(\)

```csharp
public TeamStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus__ctor_Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_"></a> TeamStatus\(TeamStatus\)

```csharp
public TeamStatus(CMsgTeamFanContentStatus.Types.TeamStatus other)
```

#### Parameters

`other` [CMsgTeamFanContentStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.Types.md).[TeamStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.Types.TeamStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_AbbreviationFieldNumber"></a> AbbreviationFieldNumber

```csharp
public const int AbbreviationFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_AssetStatusFieldNumber"></a> AssetStatusFieldNumber

```csharp
public const int AssetStatusFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_CommentFieldNumber"></a> CommentFieldNumber

```csharp
public const int CommentFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_CommentTimestampFieldNumber"></a> CommentTimestampFieldNumber

```csharp
public const int CommentTimestampFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_EmailTierFieldNumber"></a> EmailTierFieldNumber

```csharp
public const int EmailTierFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_EmailTimestampFieldNumber"></a> EmailTimestampFieldNumber

```csharp
public const int EmailTimestampFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_EmoticonCountFieldNumber"></a> EmoticonCountFieldNumber

```csharp
public const int EmoticonCountFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_LanguagesFieldNumber"></a> LanguagesFieldNumber

```csharp
public const int LanguagesFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_LogoUrlFieldNumber"></a> LogoUrlFieldNumber

```csharp
public const int LogoUrlFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_SprayCountFieldNumber"></a> SprayCountFieldNumber

```csharp
public const int SprayCountFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_StatusFieldNumber"></a> StatusFieldNumber

```csharp
public const int StatusFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_UgcLogoFieldNumber"></a> UgcLogoFieldNumber

```csharp
public const int UgcLogoFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_VoicelineCountFieldNumber"></a> VoicelineCountFieldNumber

```csharp
public const int VoicelineCountFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_WallpaperCountFieldNumber"></a> WallpaperCountFieldNumber

```csharp
public const int WallpaperCountFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_WorkshopAccountIdFieldNumber"></a> WorkshopAccountIdFieldNumber

```csharp
public const int WorkshopAccountIdFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_Abbreviation"></a> Abbreviation

```csharp
public string Abbreviation { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_AssetStatus"></a> AssetStatus

```csharp
public RepeatedField<CMsgTeamFanContentAssetStatus> AssetStatus { get; }
```

#### Property Value

 RepeatedField<[CMsgTeamFanContentAssetStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAssetStatus.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_Comment"></a> Comment

```csharp
public string Comment { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_CommentTimestamp"></a> CommentTimestamp

```csharp
public uint CommentTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_EmailTier"></a> EmailTier

```csharp
public uint EmailTier { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_EmailTimestamp"></a> EmailTimestamp

```csharp
public uint EmailTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_EmoticonCount"></a> EmoticonCount

```csharp
public uint EmoticonCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_HasAbbreviation"></a> HasAbbreviation

```csharp
public bool HasAbbreviation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_HasComment"></a> HasComment

```csharp
public bool HasComment { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_HasCommentTimestamp"></a> HasCommentTimestamp

```csharp
public bool HasCommentTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_HasEmailTier"></a> HasEmailTier

```csharp
public bool HasEmailTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_HasEmailTimestamp"></a> HasEmailTimestamp

```csharp
public bool HasEmailTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_HasEmoticonCount"></a> HasEmoticonCount

```csharp
public bool HasEmoticonCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_HasLanguages"></a> HasLanguages

```csharp
public bool HasLanguages { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_HasLogoUrl"></a> HasLogoUrl

```csharp
public bool HasLogoUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_HasSprayCount"></a> HasSprayCount

```csharp
public bool HasSprayCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_HasStatus"></a> HasStatus

```csharp
public bool HasStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_HasUgcLogo"></a> HasUgcLogo

```csharp
public bool HasUgcLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_HasVoicelineCount"></a> HasVoicelineCount

```csharp
public bool HasVoicelineCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_HasWallpaperCount"></a> HasWallpaperCount

```csharp
public bool HasWallpaperCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_HasWorkshopAccountId"></a> HasWorkshopAccountId

```csharp
public bool HasWorkshopAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_Languages"></a> Languages

```csharp
public string Languages { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_LogoUrl"></a> LogoUrl

```csharp
public string LogoUrl { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTeamFanContentStatus.Types.TeamStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTeamFanContentStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.Types.md).[TeamStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.Types.TeamStatus.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_SprayCount"></a> SprayCount

```csharp
public uint SprayCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_Status"></a> Status

```csharp
public ETeamFanContentStatus Status { get; set; }
```

#### Property Value

 [ETeamFanContentStatus](Divine.Protobufs.Dota2.ETeamFanContentStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_UgcLogo"></a> UgcLogo

```csharp
public ulong UgcLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_VoicelineCount"></a> VoicelineCount

```csharp
public uint VoicelineCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_WallpaperCount"></a> WallpaperCount

```csharp
public uint WallpaperCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_WorkshopAccountId"></a> WorkshopAccountId

```csharp
public uint WorkshopAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_ClearAbbreviation"></a> ClearAbbreviation\(\)

```csharp
public void ClearAbbreviation()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_ClearComment"></a> ClearComment\(\)

```csharp
public void ClearComment()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_ClearCommentTimestamp"></a> ClearCommentTimestamp\(\)

```csharp
public void ClearCommentTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_ClearEmailTier"></a> ClearEmailTier\(\)

```csharp
public void ClearEmailTier()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_ClearEmailTimestamp"></a> ClearEmailTimestamp\(\)

```csharp
public void ClearEmailTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_ClearEmoticonCount"></a> ClearEmoticonCount\(\)

```csharp
public void ClearEmoticonCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_ClearLanguages"></a> ClearLanguages\(\)

```csharp
public void ClearLanguages()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_ClearLogoUrl"></a> ClearLogoUrl\(\)

```csharp
public void ClearLogoUrl()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_ClearSprayCount"></a> ClearSprayCount\(\)

```csharp
public void ClearSprayCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_ClearStatus"></a> ClearStatus\(\)

```csharp
public void ClearStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_ClearUgcLogo"></a> ClearUgcLogo\(\)

```csharp
public void ClearUgcLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_ClearVoicelineCount"></a> ClearVoicelineCount\(\)

```csharp
public void ClearVoicelineCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_ClearWallpaperCount"></a> ClearWallpaperCount\(\)

```csharp
public void ClearWallpaperCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_ClearWorkshopAccountId"></a> ClearWorkshopAccountId\(\)

```csharp
public void ClearWorkshopAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_Clone"></a> Clone\(\)

```csharp
public CMsgTeamFanContentStatus.Types.TeamStatus Clone()
```

#### Returns

 [CMsgTeamFanContentStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.Types.md).[TeamStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.Types.TeamStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_Equals_Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_"></a> Equals\(TeamStatus\)

```csharp
public bool Equals(CMsgTeamFanContentStatus.Types.TeamStatus other)
```

#### Parameters

`other` [CMsgTeamFanContentStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.Types.md).[TeamStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.Types.TeamStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_MergeFrom_Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_"></a> MergeFrom\(TeamStatus\)

```csharp
public void MergeFrom(CMsgTeamFanContentStatus.Types.TeamStatus other)
```

#### Parameters

`other` [CMsgTeamFanContentStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.Types.md).[TeamStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.Types.TeamStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Types_TeamStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

