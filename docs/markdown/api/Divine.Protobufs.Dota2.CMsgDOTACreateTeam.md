# <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam"></a> Class CMsgDOTACreateTeam

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTACreateTeam : IMessage<CMsgDOTACreateTeam>, IEquatable<CMsgDOTACreateTeam>, IDeepCloneable<CMsgDOTACreateTeam>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTACreateTeam](Divine.Protobufs.Dota2.CMsgDOTACreateTeam.md)

#### Implements

IMessage<CMsgDOTACreateTeam\>, 
[IEquatable<CMsgDOTACreateTeam\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTACreateTeam\>, 
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
[EnumerableExtensions.In<CMsgDOTACreateTeam\>\(CMsgDOTACreateTeam, params CMsgDOTACreateTeam\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam__ctor"></a> CMsgDOTACreateTeam\(\)

```csharp
public CMsgDOTACreateTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam__ctor_Divine_Protobufs_Dota2_CMsgDOTACreateTeam_"></a> CMsgDOTACreateTeam\(CMsgDOTACreateTeam\)

```csharp
public CMsgDOTACreateTeam(CMsgDOTACreateTeam other)
```

#### Parameters

`other` [CMsgDOTACreateTeam](Divine.Protobufs.Dota2.CMsgDOTACreateTeam.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_AbbreviationFieldNumber"></a> AbbreviationFieldNumber

```csharp
public const int AbbreviationFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_BannerLogoFieldNumber"></a> BannerLogoFieldNumber

```csharp
public const int BannerLogoFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_BaseLogoFieldNumber"></a> BaseLogoFieldNumber

```csharp
public const int BaseLogoFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_CountryCodeFieldNumber"></a> CountryCodeFieldNumber

```csharp
public const int CountryCodeFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_LogoFieldNumber"></a> LogoFieldNumber

```csharp
public const int LogoFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_PickupTeamFieldNumber"></a> PickupTeamFieldNumber

```csharp
public const int PickupTeamFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_SponsorLogoFieldNumber"></a> SponsorLogoFieldNumber

```csharp
public const int SponsorLogoFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_TagFieldNumber"></a> TagFieldNumber

```csharp
public const int TagFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_UrlFieldNumber"></a> UrlFieldNumber

```csharp
public const int UrlFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_Abbreviation"></a> Abbreviation

```csharp
public string Abbreviation { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_BannerLogo"></a> BannerLogo

```csharp
public ulong BannerLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_BaseLogo"></a> BaseLogo

```csharp
public ulong BaseLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_CountryCode"></a> CountryCode

```csharp
public string CountryCode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_HasAbbreviation"></a> HasAbbreviation

```csharp
public bool HasAbbreviation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_HasBannerLogo"></a> HasBannerLogo

```csharp
public bool HasBannerLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_HasBaseLogo"></a> HasBaseLogo

```csharp
public bool HasBaseLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_HasCountryCode"></a> HasCountryCode

```csharp
public bool HasCountryCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_HasLogo"></a> HasLogo

```csharp
public bool HasLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_HasPickupTeam"></a> HasPickupTeam

```csharp
public bool HasPickupTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_HasSponsorLogo"></a> HasSponsorLogo

```csharp
public bool HasSponsorLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_HasTag"></a> HasTag

```csharp
public bool HasTag { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_HasUrl"></a> HasUrl

```csharp
public bool HasUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_Logo"></a> Logo

```csharp
public ulong Logo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTACreateTeam> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTACreateTeam](Divine.Protobufs.Dota2.CMsgDOTACreateTeam.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_PickupTeam"></a> PickupTeam

```csharp
public bool PickupTeam { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_SponsorLogo"></a> SponsorLogo

```csharp
public ulong SponsorLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_Tag"></a> Tag

```csharp
public string Tag { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_Url"></a> Url

```csharp
public string Url { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_ClearAbbreviation"></a> ClearAbbreviation\(\)

```csharp
public void ClearAbbreviation()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_ClearBannerLogo"></a> ClearBannerLogo\(\)

```csharp
public void ClearBannerLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_ClearBaseLogo"></a> ClearBaseLogo\(\)

```csharp
public void ClearBaseLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_ClearCountryCode"></a> ClearCountryCode\(\)

```csharp
public void ClearCountryCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_ClearLogo"></a> ClearLogo\(\)

```csharp
public void ClearLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_ClearPickupTeam"></a> ClearPickupTeam\(\)

```csharp
public void ClearPickupTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_ClearSponsorLogo"></a> ClearSponsorLogo\(\)

```csharp
public void ClearSponsorLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_ClearTag"></a> ClearTag\(\)

```csharp
public void ClearTag()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_ClearUrl"></a> ClearUrl\(\)

```csharp
public void ClearUrl()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_Clone"></a> Clone\(\)

```csharp
public CMsgDOTACreateTeam Clone()
```

#### Returns

 [CMsgDOTACreateTeam](Divine.Protobufs.Dota2.CMsgDOTACreateTeam.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_Equals_Divine_Protobufs_Dota2_CMsgDOTACreateTeam_"></a> Equals\(CMsgDOTACreateTeam\)

```csharp
public bool Equals(CMsgDOTACreateTeam other)
```

#### Parameters

`other` [CMsgDOTACreateTeam](Divine.Protobufs.Dota2.CMsgDOTACreateTeam.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTACreateTeam_"></a> MergeFrom\(CMsgDOTACreateTeam\)

```csharp
public void MergeFrom(CMsgDOTACreateTeam other)
```

#### Parameters

`other` [CMsgDOTACreateTeam](Divine.Protobufs.Dota2.CMsgDOTACreateTeam.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeam_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

