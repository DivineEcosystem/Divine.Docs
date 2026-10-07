# <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response"></a> Class CGCSystemMsg\_GetAccountDetails\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCSystemMsg_GetAccountDetails_Response : IMessage<CGCSystemMsg_GetAccountDetails_Response>, IEquatable<CGCSystemMsg_GetAccountDetails_Response>, IDeepCloneable<CGCSystemMsg_GetAccountDetails_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCSystemMsg\_GetAccountDetails\_Response](Divine.Protobufs.Steam.CGCSystemMsg\_GetAccountDetails\_Response.md)

#### Implements

IMessage<CGCSystemMsg\_GetAccountDetails\_Response\>, 
[IEquatable<CGCSystemMsg\_GetAccountDetails\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCSystemMsg\_GetAccountDetails\_Response\>, 
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
[EnumerableExtensions.In<CGCSystemMsg\_GetAccountDetails\_Response\>\(CGCSystemMsg\_GetAccountDetails\_Response, params CGCSystemMsg\_GetAccountDetails\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response__ctor"></a> CGCSystemMsg\_GetAccountDetails\_Response\(\)

```csharp
public CGCSystemMsg_GetAccountDetails_Response()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response__ctor_Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_"></a> CGCSystemMsg\_GetAccountDetails\_Response\(CGCSystemMsg\_GetAccountDetails\_Response\)

```csharp
public CGCSystemMsg_GetAccountDetails_Response(CGCSystemMsg_GetAccountDetails_Response other)
```

#### Parameters

`other` [CGCSystemMsg\_GetAccountDetails\_Response](Divine.Protobufs.Steam.CGCSystemMsg\_GetAccountDetails\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_AccountCreationTimeFieldNumber"></a> AccountCreationTimeFieldNumber

```csharp
public const int AccountCreationTimeFieldNumber = 25
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_AccountidFieldNumber"></a> AccountidFieldNumber

```csharp
public const int AccountidFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_AccountNameFieldNumber"></a> AccountNameFieldNumber

```csharp
public const int AccountNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_CurrencyFieldNumber"></a> CurrencyFieldNumber

```csharp
public const int CurrencyFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_EresultDeprecatedFieldNumber"></a> EresultDeprecatedFieldNumber

```csharp
public const int EresultDeprecatedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_FreeTrialExpirationFieldNumber"></a> FreeTrialExpirationFieldNumber

```csharp
public const int FreeTrialExpirationFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_FriendCountFieldNumber"></a> FriendCountFieldNumber

```csharp
public const int FriendCountFieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasAcceptedChinaSsaFieldNumber"></a> HasAcceptedChinaSsaFieldNumber

```csharp
public const int HasAcceptedChinaSsaFieldNumber = 38
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsAccountLockedDownFieldNumber"></a> IsAccountLockedDownFieldNumber

```csharp
public const int IsAccountLockedDownFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsBannedSteamChinaFieldNumber"></a> IsBannedSteamChinaFieldNumber

```csharp
public const int IsBannedSteamChinaFieldNumber = 39
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsCommunityBannedFieldNumber"></a> IsCommunityBannedFieldNumber

```csharp
public const int IsCommunityBannedFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsCyberCafeFieldNumber"></a> IsCyberCafeFieldNumber

```csharp
public const int IsCyberCafeFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsFreeTrialAccountFieldNumber"></a> IsFreeTrialAccountFieldNumber

```csharp
public const int IsFreeTrialAccountFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsInventoryPublicFieldNumber"></a> IsInventoryPublicFieldNumber

```csharp
public const int IsInventoryPublicFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsLimitedFieldNumber"></a> IsLimitedFieldNumber

```csharp
public const int IsLimitedFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsLowViolenceFieldNumber"></a> IsLowViolenceFieldNumber

```csharp
public const int IsLowViolenceFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsPhoneIdentifyingFieldNumber"></a> IsPhoneIdentifyingFieldNumber

```csharp
public const int IsPhoneIdentifyingFieldNumber = 34
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsPhoneVerifiedFieldNumber"></a> IsPhoneVerifiedFieldNumber

```csharp
public const int IsPhoneVerifiedFieldNumber = 28
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsProfileCreatedFieldNumber"></a> IsProfileCreatedFieldNumber

```csharp
public const int IsProfileCreatedFieldNumber = 26
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsProfilePublicFieldNumber"></a> IsProfilePublicFieldNumber

```csharp
public const int IsProfilePublicFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsSchoolAccountFieldNumber"></a> IsSchoolAccountFieldNumber

```csharp
public const int IsSchoolAccountFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsSteamguardEnabledFieldNumber"></a> IsSteamguardEnabledFieldNumber

```csharp
public const int IsSteamguardEnabledFieldNumber = 27
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsSubscribedFieldNumber"></a> IsSubscribedFieldNumber

```csharp
public const int IsSubscribedFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsTradeBannedFieldNumber"></a> IsTradeBannedFieldNumber

```csharp
public const int IsTradeBannedFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsTwoFactorAuthEnabledFieldNumber"></a> IsTwoFactorAuthEnabledFieldNumber

```csharp
public const int IsTwoFactorAuthEnabledFieldNumber = 29
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsVacBannedFieldNumber"></a> IsVacBannedFieldNumber

```csharp
public const int IsVacBannedFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_PackageFieldNumber"></a> PackageFieldNumber

```csharp
public const int PackageFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_PersonaNameFieldNumber"></a> PersonaNameFieldNumber

```csharp
public const int PersonaNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_PhoneIdFieldNumber"></a> PhoneIdFieldNumber

```csharp
public const int PhoneIdFieldNumber = 33
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_PhoneVerificationTimeFieldNumber"></a> PhoneVerificationTimeFieldNumber

```csharp
public const int PhoneVerificationTimeFieldNumber = 31
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_RtBirthDateFieldNumber"></a> RtBirthDateFieldNumber

```csharp
public const int RtBirthDateFieldNumber = 36
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_RtIdentityLinkedFieldNumber"></a> RtIdentityLinkedFieldNumber

```csharp
public const int RtIdentityLinkedFieldNumber = 35
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_SteamLevelFieldNumber"></a> SteamLevelFieldNumber

```csharp
public const int SteamLevelFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_SuspensionEndTimeFieldNumber"></a> SuspensionEndTimeFieldNumber

```csharp
public const int SuspensionEndTimeFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_TradeBanExpirationFieldNumber"></a> TradeBanExpirationFieldNumber

```csharp
public const int TradeBanExpirationFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_TwoFactorEnabledTimeFieldNumber"></a> TwoFactorEnabledTimeFieldNumber

```csharp
public const int TwoFactorEnabledTimeFieldNumber = 30
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_TxnCountryCodeFieldNumber"></a> TxnCountryCodeFieldNumber

```csharp
public const int TxnCountryCodeFieldNumber = 37
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_AccountCreationTime"></a> AccountCreationTime

```csharp
public uint AccountCreationTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_Accountid"></a> Accountid

```csharp
public uint Accountid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_AccountName"></a> AccountName

```csharp
public string AccountName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_Currency"></a> Currency

```csharp
public string Currency { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_EresultDeprecated"></a> EresultDeprecated

```csharp
public uint EresultDeprecated { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_FreeTrialExpiration"></a> FreeTrialExpiration

```csharp
public uint FreeTrialExpiration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_FriendCount"></a> FriendCount

```csharp
public uint FriendCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasAcceptedChinaSsa"></a> HasAcceptedChinaSsa

```csharp
public bool HasAcceptedChinaSsa { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasAccountCreationTime"></a> HasAccountCreationTime

```csharp
public bool HasAccountCreationTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasAccountid"></a> HasAccountid

```csharp
public bool HasAccountid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasAccountName"></a> HasAccountName

```csharp
public bool HasAccountName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasCurrency"></a> HasCurrency

```csharp
public bool HasCurrency { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasEresultDeprecated"></a> HasEresultDeprecated

```csharp
public bool HasEresultDeprecated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasFreeTrialExpiration"></a> HasFreeTrialExpiration

```csharp
public bool HasFreeTrialExpiration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasFriendCount"></a> HasFriendCount

```csharp
public bool HasFriendCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasHasAcceptedChinaSsa"></a> HasHasAcceptedChinaSsa

```csharp
public bool HasHasAcceptedChinaSsa { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasIsAccountLockedDown"></a> HasIsAccountLockedDown

```csharp
public bool HasIsAccountLockedDown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasIsBannedSteamChina"></a> HasIsBannedSteamChina

```csharp
public bool HasIsBannedSteamChina { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasIsCommunityBanned"></a> HasIsCommunityBanned

```csharp
public bool HasIsCommunityBanned { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasIsCyberCafe"></a> HasIsCyberCafe

```csharp
public bool HasIsCyberCafe { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasIsFreeTrialAccount"></a> HasIsFreeTrialAccount

```csharp
public bool HasIsFreeTrialAccount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasIsInventoryPublic"></a> HasIsInventoryPublic

```csharp
public bool HasIsInventoryPublic { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasIsLimited"></a> HasIsLimited

```csharp
public bool HasIsLimited { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasIsLowViolence"></a> HasIsLowViolence

```csharp
public bool HasIsLowViolence { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasIsPhoneIdentifying"></a> HasIsPhoneIdentifying

```csharp
public bool HasIsPhoneIdentifying { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasIsPhoneVerified"></a> HasIsPhoneVerified

```csharp
public bool HasIsPhoneVerified { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasIsProfileCreated"></a> HasIsProfileCreated

```csharp
public bool HasIsProfileCreated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasIsProfilePublic"></a> HasIsProfilePublic

```csharp
public bool HasIsProfilePublic { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasIsSchoolAccount"></a> HasIsSchoolAccount

```csharp
public bool HasIsSchoolAccount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasIsSteamguardEnabled"></a> HasIsSteamguardEnabled

```csharp
public bool HasIsSteamguardEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasIsSubscribed"></a> HasIsSubscribed

```csharp
public bool HasIsSubscribed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasIsTradeBanned"></a> HasIsTradeBanned

```csharp
public bool HasIsTradeBanned { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasIsTwoFactorAuthEnabled"></a> HasIsTwoFactorAuthEnabled

```csharp
public bool HasIsTwoFactorAuthEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasIsVacBanned"></a> HasIsVacBanned

```csharp
public bool HasIsVacBanned { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasPackage"></a> HasPackage

```csharp
public bool HasPackage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasPersonaName"></a> HasPersonaName

```csharp
public bool HasPersonaName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasPhoneId"></a> HasPhoneId

```csharp
public bool HasPhoneId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasPhoneVerificationTime"></a> HasPhoneVerificationTime

```csharp
public bool HasPhoneVerificationTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasRtBirthDate"></a> HasRtBirthDate

```csharp
public bool HasRtBirthDate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasRtIdentityLinked"></a> HasRtIdentityLinked

```csharp
public bool HasRtIdentityLinked { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasSteamLevel"></a> HasSteamLevel

```csharp
public bool HasSteamLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasSuspensionEndTime"></a> HasSuspensionEndTime

```csharp
public bool HasSuspensionEndTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasTradeBanExpiration"></a> HasTradeBanExpiration

```csharp
public bool HasTradeBanExpiration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasTwoFactorEnabledTime"></a> HasTwoFactorEnabledTime

```csharp
public bool HasTwoFactorEnabledTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_HasTxnCountryCode"></a> HasTxnCountryCode

```csharp
public bool HasTxnCountryCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsAccountLockedDown"></a> IsAccountLockedDown

```csharp
public bool IsAccountLockedDown { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsBannedSteamChina"></a> IsBannedSteamChina

```csharp
public bool IsBannedSteamChina { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsCommunityBanned"></a> IsCommunityBanned

```csharp
public bool IsCommunityBanned { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsCyberCafe"></a> IsCyberCafe

```csharp
public bool IsCyberCafe { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsFreeTrialAccount"></a> IsFreeTrialAccount

```csharp
public bool IsFreeTrialAccount { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsInventoryPublic"></a> IsInventoryPublic

```csharp
public bool IsInventoryPublic { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsLimited"></a> IsLimited

```csharp
public bool IsLimited { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsLowViolence"></a> IsLowViolence

```csharp
public bool IsLowViolence { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsPhoneIdentifying"></a> IsPhoneIdentifying

```csharp
public bool IsPhoneIdentifying { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsPhoneVerified"></a> IsPhoneVerified

```csharp
public bool IsPhoneVerified { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsProfileCreated"></a> IsProfileCreated

```csharp
public bool IsProfileCreated { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsProfilePublic"></a> IsProfilePublic

```csharp
public bool IsProfilePublic { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsSchoolAccount"></a> IsSchoolAccount

```csharp
public bool IsSchoolAccount { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsSteamguardEnabled"></a> IsSteamguardEnabled

```csharp
public bool IsSteamguardEnabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsSubscribed"></a> IsSubscribed

```csharp
public bool IsSubscribed { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsTradeBanned"></a> IsTradeBanned

```csharp
public bool IsTradeBanned { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsTwoFactorAuthEnabled"></a> IsTwoFactorAuthEnabled

```csharp
public bool IsTwoFactorAuthEnabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_IsVacBanned"></a> IsVacBanned

```csharp
public bool IsVacBanned { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_Package"></a> Package

```csharp
public uint Package { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_Parser"></a> Parser

```csharp
public static MessageParser<CGCSystemMsg_GetAccountDetails_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CGCSystemMsg\_GetAccountDetails\_Response](Divine.Protobufs.Steam.CGCSystemMsg\_GetAccountDetails\_Response.md)\>

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_PersonaName"></a> PersonaName

```csharp
public string PersonaName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_PhoneId"></a> PhoneId

```csharp
public ulong PhoneId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_PhoneVerificationTime"></a> PhoneVerificationTime

```csharp
public uint PhoneVerificationTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_RtBirthDate"></a> RtBirthDate

```csharp
public uint RtBirthDate { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_RtIdentityLinked"></a> RtIdentityLinked

```csharp
public uint RtIdentityLinked { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_SteamLevel"></a> SteamLevel

```csharp
public uint SteamLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_SuspensionEndTime"></a> SuspensionEndTime

```csharp
public uint SuspensionEndTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_TradeBanExpiration"></a> TradeBanExpiration

```csharp
public uint TradeBanExpiration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_TwoFactorEnabledTime"></a> TwoFactorEnabledTime

```csharp
public uint TwoFactorEnabledTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_TxnCountryCode"></a> TxnCountryCode

```csharp
public string TxnCountryCode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearAccountCreationTime"></a> ClearAccountCreationTime\(\)

```csharp
public void ClearAccountCreationTime()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearAccountid"></a> ClearAccountid\(\)

```csharp
public void ClearAccountid()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearAccountName"></a> ClearAccountName\(\)

```csharp
public void ClearAccountName()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearCurrency"></a> ClearCurrency\(\)

```csharp
public void ClearCurrency()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearEresultDeprecated"></a> ClearEresultDeprecated\(\)

```csharp
public void ClearEresultDeprecated()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearFreeTrialExpiration"></a> ClearFreeTrialExpiration\(\)

```csharp
public void ClearFreeTrialExpiration()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearFriendCount"></a> ClearFriendCount\(\)

```csharp
public void ClearFriendCount()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearHasAcceptedChinaSsa"></a> ClearHasAcceptedChinaSsa\(\)

```csharp
public void ClearHasAcceptedChinaSsa()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearIsAccountLockedDown"></a> ClearIsAccountLockedDown\(\)

```csharp
public void ClearIsAccountLockedDown()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearIsBannedSteamChina"></a> ClearIsBannedSteamChina\(\)

```csharp
public void ClearIsBannedSteamChina()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearIsCommunityBanned"></a> ClearIsCommunityBanned\(\)

```csharp
public void ClearIsCommunityBanned()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearIsCyberCafe"></a> ClearIsCyberCafe\(\)

```csharp
public void ClearIsCyberCafe()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearIsFreeTrialAccount"></a> ClearIsFreeTrialAccount\(\)

```csharp
public void ClearIsFreeTrialAccount()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearIsInventoryPublic"></a> ClearIsInventoryPublic\(\)

```csharp
public void ClearIsInventoryPublic()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearIsLimited"></a> ClearIsLimited\(\)

```csharp
public void ClearIsLimited()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearIsLowViolence"></a> ClearIsLowViolence\(\)

```csharp
public void ClearIsLowViolence()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearIsPhoneIdentifying"></a> ClearIsPhoneIdentifying\(\)

```csharp
public void ClearIsPhoneIdentifying()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearIsPhoneVerified"></a> ClearIsPhoneVerified\(\)

```csharp
public void ClearIsPhoneVerified()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearIsProfileCreated"></a> ClearIsProfileCreated\(\)

```csharp
public void ClearIsProfileCreated()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearIsProfilePublic"></a> ClearIsProfilePublic\(\)

```csharp
public void ClearIsProfilePublic()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearIsSchoolAccount"></a> ClearIsSchoolAccount\(\)

```csharp
public void ClearIsSchoolAccount()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearIsSteamguardEnabled"></a> ClearIsSteamguardEnabled\(\)

```csharp
public void ClearIsSteamguardEnabled()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearIsSubscribed"></a> ClearIsSubscribed\(\)

```csharp
public void ClearIsSubscribed()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearIsTradeBanned"></a> ClearIsTradeBanned\(\)

```csharp
public void ClearIsTradeBanned()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearIsTwoFactorAuthEnabled"></a> ClearIsTwoFactorAuthEnabled\(\)

```csharp
public void ClearIsTwoFactorAuthEnabled()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearIsVacBanned"></a> ClearIsVacBanned\(\)

```csharp
public void ClearIsVacBanned()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearPackage"></a> ClearPackage\(\)

```csharp
public void ClearPackage()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearPersonaName"></a> ClearPersonaName\(\)

```csharp
public void ClearPersonaName()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearPhoneId"></a> ClearPhoneId\(\)

```csharp
public void ClearPhoneId()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearPhoneVerificationTime"></a> ClearPhoneVerificationTime\(\)

```csharp
public void ClearPhoneVerificationTime()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearRtBirthDate"></a> ClearRtBirthDate\(\)

```csharp
public void ClearRtBirthDate()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearRtIdentityLinked"></a> ClearRtIdentityLinked\(\)

```csharp
public void ClearRtIdentityLinked()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearSteamLevel"></a> ClearSteamLevel\(\)

```csharp
public void ClearSteamLevel()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearSuspensionEndTime"></a> ClearSuspensionEndTime\(\)

```csharp
public void ClearSuspensionEndTime()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearTradeBanExpiration"></a> ClearTradeBanExpiration\(\)

```csharp
public void ClearTradeBanExpiration()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearTwoFactorEnabledTime"></a> ClearTwoFactorEnabledTime\(\)

```csharp
public void ClearTwoFactorEnabledTime()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ClearTxnCountryCode"></a> ClearTxnCountryCode\(\)

```csharp
public void ClearTxnCountryCode()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_Clone"></a> Clone\(\)

```csharp
public CGCSystemMsg_GetAccountDetails_Response Clone()
```

#### Returns

 [CGCSystemMsg\_GetAccountDetails\_Response](Divine.Protobufs.Steam.CGCSystemMsg\_GetAccountDetails\_Response.md)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_Equals_Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_"></a> Equals\(CGCSystemMsg\_GetAccountDetails\_Response\)

```csharp
public bool Equals(CGCSystemMsg_GetAccountDetails_Response other)
```

#### Parameters

`other` [CGCSystemMsg\_GetAccountDetails\_Response](Divine.Protobufs.Steam.CGCSystemMsg\_GetAccountDetails\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_MergeFrom_Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_"></a> MergeFrom\(CGCSystemMsg\_GetAccountDetails\_Response\)

```csharp
public void MergeFrom(CGCSystemMsg_GetAccountDetails_Response other)
```

#### Parameters

`other` [CGCSystemMsg\_GetAccountDetails\_Response](Divine.Protobufs.Steam.CGCSystemMsg\_GetAccountDetails\_Response.md)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

