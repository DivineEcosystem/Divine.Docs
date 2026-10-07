# <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails"></a> Class CMsgDOTAEditTeamDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAEditTeamDetails : IMessage<CMsgDOTAEditTeamDetails>, IEquatable<CMsgDOTAEditTeamDetails>, IDeepCloneable<CMsgDOTAEditTeamDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAEditTeamDetails](Divine.Protobufs.Dota2.CMsgDOTAEditTeamDetails.md)

#### Implements

IMessage<CMsgDOTAEditTeamDetails\>, 
[IEquatable<CMsgDOTAEditTeamDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAEditTeamDetails\>, 
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
[EnumerableExtensions.In<CMsgDOTAEditTeamDetails\>\(CMsgDOTAEditTeamDetails, params CMsgDOTAEditTeamDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails__ctor"></a> CMsgDOTAEditTeamDetails\(\)

```csharp
public CMsgDOTAEditTeamDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails__ctor_Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_"></a> CMsgDOTAEditTeamDetails\(CMsgDOTAEditTeamDetails\)

```csharp
public CMsgDOTAEditTeamDetails(CMsgDOTAEditTeamDetails other)
```

#### Parameters

`other` [CMsgDOTAEditTeamDetails](Divine.Protobufs.Dota2.CMsgDOTAEditTeamDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_AbbreviationFieldNumber"></a> AbbreviationFieldNumber

```csharp
public const int AbbreviationFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_BannerLogoFieldNumber"></a> BannerLogoFieldNumber

```csharp
public const int BannerLogoFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_BaseLogoFieldNumber"></a> BaseLogoFieldNumber

```csharp
public const int BaseLogoFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_CountryCodeFieldNumber"></a> CountryCodeFieldNumber

```csharp
public const int CountryCodeFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_InUseByPartyFieldNumber"></a> InUseByPartyFieldNumber

```csharp
public const int InUseByPartyFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_LogoFieldNumber"></a> LogoFieldNumber

```csharp
public const int LogoFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_SponsorLogoFieldNumber"></a> SponsorLogoFieldNumber

```csharp
public const int SponsorLogoFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_TagFieldNumber"></a> TagFieldNumber

```csharp
public const int TagFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_UrlFieldNumber"></a> UrlFieldNumber

```csharp
public const int UrlFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_Abbreviation"></a> Abbreviation

```csharp
public string Abbreviation { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_BannerLogo"></a> BannerLogo

```csharp
public ulong BannerLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_BaseLogo"></a> BaseLogo

```csharp
public ulong BaseLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_CountryCode"></a> CountryCode

```csharp
public string CountryCode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_HasAbbreviation"></a> HasAbbreviation

```csharp
public bool HasAbbreviation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_HasBannerLogo"></a> HasBannerLogo

```csharp
public bool HasBannerLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_HasBaseLogo"></a> HasBaseLogo

```csharp
public bool HasBaseLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_HasCountryCode"></a> HasCountryCode

```csharp
public bool HasCountryCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_HasInUseByParty"></a> HasInUseByParty

```csharp
public bool HasInUseByParty { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_HasLogo"></a> HasLogo

```csharp
public bool HasLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_HasSponsorLogo"></a> HasSponsorLogo

```csharp
public bool HasSponsorLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_HasTag"></a> HasTag

```csharp
public bool HasTag { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_HasUrl"></a> HasUrl

```csharp
public bool HasUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_InUseByParty"></a> InUseByParty

```csharp
public bool InUseByParty { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_Logo"></a> Logo

```csharp
public ulong Logo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAEditTeamDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAEditTeamDetails](Divine.Protobufs.Dota2.CMsgDOTAEditTeamDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_SponsorLogo"></a> SponsorLogo

```csharp
public ulong SponsorLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_Tag"></a> Tag

```csharp
public string Tag { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_Url"></a> Url

```csharp
public string Url { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_ClearAbbreviation"></a> ClearAbbreviation\(\)

```csharp
public void ClearAbbreviation()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_ClearBannerLogo"></a> ClearBannerLogo\(\)

```csharp
public void ClearBannerLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_ClearBaseLogo"></a> ClearBaseLogo\(\)

```csharp
public void ClearBaseLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_ClearCountryCode"></a> ClearCountryCode\(\)

```csharp
public void ClearCountryCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_ClearInUseByParty"></a> ClearInUseByParty\(\)

```csharp
public void ClearInUseByParty()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_ClearLogo"></a> ClearLogo\(\)

```csharp
public void ClearLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_ClearSponsorLogo"></a> ClearSponsorLogo\(\)

```csharp
public void ClearSponsorLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_ClearTag"></a> ClearTag\(\)

```csharp
public void ClearTag()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_ClearUrl"></a> ClearUrl\(\)

```csharp
public void ClearUrl()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAEditTeamDetails Clone()
```

#### Returns

 [CMsgDOTAEditTeamDetails](Divine.Protobufs.Dota2.CMsgDOTAEditTeamDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_Equals_Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_"></a> Equals\(CMsgDOTAEditTeamDetails\)

```csharp
public bool Equals(CMsgDOTAEditTeamDetails other)
```

#### Parameters

`other` [CMsgDOTAEditTeamDetails](Divine.Protobufs.Dota2.CMsgDOTAEditTeamDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_"></a> MergeFrom\(CMsgDOTAEditTeamDetails\)

```csharp
public void MergeFrom(CMsgDOTAEditTeamDetails other)
```

#### Parameters

`other` [CMsgDOTAEditTeamDetails](Divine.Protobufs.Dota2.CMsgDOTAEditTeamDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

