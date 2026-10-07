# <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit"></a> Class CMsgGCPlayerInfoSubmit

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCPlayerInfoSubmit : IMessage<CMsgGCPlayerInfoSubmit>, IEquatable<CMsgGCPlayerInfoSubmit>, IDeepCloneable<CMsgGCPlayerInfoSubmit>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCPlayerInfoSubmit](Divine.Protobufs.Dota2.CMsgGCPlayerInfoSubmit.md)

#### Implements

IMessage<CMsgGCPlayerInfoSubmit\>, 
[IEquatable<CMsgGCPlayerInfoSubmit\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCPlayerInfoSubmit\>, 
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
[EnumerableExtensions.In<CMsgGCPlayerInfoSubmit\>\(CMsgGCPlayerInfoSubmit, params CMsgGCPlayerInfoSubmit\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit__ctor"></a> CMsgGCPlayerInfoSubmit\(\)

```csharp
public CMsgGCPlayerInfoSubmit()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit__ctor_Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_"></a> CMsgGCPlayerInfoSubmit\(CMsgGCPlayerInfoSubmit\)

```csharp
public CMsgGCPlayerInfoSubmit(CMsgGCPlayerInfoSubmit other)
```

#### Parameters

`other` [CMsgGCPlayerInfoSubmit](Divine.Protobufs.Dota2.CMsgGCPlayerInfoSubmit.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_AcceptedProAgreementFieldNumber"></a> AcceptedProAgreementFieldNumber

```csharp
public const int AcceptedProAgreementFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_CountryCodeFieldNumber"></a> CountryCodeFieldNumber

```csharp
public const int CountryCodeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_FantasyRoleFieldNumber"></a> FantasyRoleFieldNumber

```csharp
public const int FantasyRoleFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_PlayerNameFieldNumber"></a> PlayerNameFieldNumber

```csharp
public const int PlayerNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_RealNameFieldNumber"></a> RealNameFieldNumber

```csharp
public const int RealNameFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_RegistrationPeriodFieldNumber"></a> RegistrationPeriodFieldNumber

```csharp
public const int RegistrationPeriodFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_SponsorFieldNumber"></a> SponsorFieldNumber

```csharp
public const int SponsorFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_AcceptedProAgreement"></a> AcceptedProAgreement

```csharp
public bool AcceptedProAgreement { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_CountryCode"></a> CountryCode

```csharp
public string CountryCode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_FantasyRole"></a> FantasyRole

```csharp
public uint FantasyRole { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_HasAcceptedProAgreement"></a> HasAcceptedProAgreement

```csharp
public bool HasAcceptedProAgreement { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_HasCountryCode"></a> HasCountryCode

```csharp
public bool HasCountryCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_HasFantasyRole"></a> HasFantasyRole

```csharp
public bool HasFantasyRole { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_HasPlayerName"></a> HasPlayerName

```csharp
public bool HasPlayerName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_HasRealName"></a> HasRealName

```csharp
public bool HasRealName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_HasRegistrationPeriod"></a> HasRegistrationPeriod

```csharp
public bool HasRegistrationPeriod { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_HasSponsor"></a> HasSponsor

```csharp
public bool HasSponsor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCPlayerInfoSubmit> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCPlayerInfoSubmit](Divine.Protobufs.Dota2.CMsgGCPlayerInfoSubmit.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_PlayerName"></a> PlayerName

```csharp
public string PlayerName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_RealName"></a> RealName

```csharp
public string RealName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_RegistrationPeriod"></a> RegistrationPeriod

```csharp
public uint RegistrationPeriod { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_Sponsor"></a> Sponsor

```csharp
public string Sponsor { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_ClearAcceptedProAgreement"></a> ClearAcceptedProAgreement\(\)

```csharp
public void ClearAcceptedProAgreement()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_ClearCountryCode"></a> ClearCountryCode\(\)

```csharp
public void ClearCountryCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_ClearFantasyRole"></a> ClearFantasyRole\(\)

```csharp
public void ClearFantasyRole()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_ClearPlayerName"></a> ClearPlayerName\(\)

```csharp
public void ClearPlayerName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_ClearRealName"></a> ClearRealName\(\)

```csharp
public void ClearRealName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_ClearRegistrationPeriod"></a> ClearRegistrationPeriod\(\)

```csharp
public void ClearRegistrationPeriod()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_ClearSponsor"></a> ClearSponsor\(\)

```csharp
public void ClearSponsor()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_Clone"></a> Clone\(\)

```csharp
public CMsgGCPlayerInfoSubmit Clone()
```

#### Returns

 [CMsgGCPlayerInfoSubmit](Divine.Protobufs.Dota2.CMsgGCPlayerInfoSubmit.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_Equals_Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_"></a> Equals\(CMsgGCPlayerInfoSubmit\)

```csharp
public bool Equals(CMsgGCPlayerInfoSubmit other)
```

#### Parameters

`other` [CMsgGCPlayerInfoSubmit](Divine.Protobufs.Dota2.CMsgGCPlayerInfoSubmit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_MergeFrom_Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_"></a> MergeFrom\(CMsgGCPlayerInfoSubmit\)

```csharp
public void MergeFrom(CMsgGCPlayerInfoSubmit other)
```

#### Parameters

`other` [CMsgGCPlayerInfoSubmit](Divine.Protobufs.Dota2.CMsgGCPlayerInfoSubmit.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmit_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

