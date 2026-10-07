# <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome"></a> Class CMsgDOTAWelcome

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAWelcome : IMessage<CMsgDOTAWelcome>, IEquatable<CMsgDOTAWelcome>, IDeepCloneable<CMsgDOTAWelcome>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAWelcome](Divine.Protobufs.Dota2.CMsgDOTAWelcome.md)

#### Implements

IMessage<CMsgDOTAWelcome\>, 
[IEquatable<CMsgDOTAWelcome\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAWelcome\>, 
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
[EnumerableExtensions.In<CMsgDOTAWelcome\>\(CMsgDOTAWelcome, params CMsgDOTAWelcome\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome__ctor"></a> CMsgDOTAWelcome\(\)

```csharp
public CMsgDOTAWelcome()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome__ctor_Divine_Protobufs_Dota2_CMsgDOTAWelcome_"></a> CMsgDOTAWelcome\(CMsgDOTAWelcome\)

```csharp
public CMsgDOTAWelcome(CMsgDOTAWelcome other)
```

#### Parameters

`other` [CMsgDOTAWelcome](Divine.Protobufs.Dota2.CMsgDOTAWelcome.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ActiveEventFieldNumber"></a> ActiveEventFieldNumber

```csharp
public const int ActiveEventFieldNumber = 28
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ActiveEventForDisplayFieldNumber"></a> ActiveEventForDisplayFieldNumber

```csharp
public const int ActiveEventForDisplayFieldNumber = 35
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_AdditionalUserMessageFieldNumber"></a> AdditionalUserMessageFieldNumber

```csharp
public const int AdditionalUserMessageFieldNumber = 29
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_Allow3RdPartyMatchHistoryFieldNumber"></a> Allow3RdPartyMatchHistoryFieldNumber

```csharp
public const int Allow3RdPartyMatchHistoryFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_CurrencyFieldNumber"></a> CurrencyFieldNumber

```csharp
public const int CurrencyFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_CustomGameWhitelistVersionFieldNumber"></a> CustomGameWhitelistVersionFieldNumber

```csharp
public const int CustomGameWhitelistVersionFieldNumber = 30
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_DisableGuildPersonaInfoFieldNumber"></a> DisableGuildPersonaInfoFieldNumber

```csharp
public const int DisableGuildPersonaInfoFieldNumber = 33
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ExtraMessageBlocksFieldNumber"></a> ExtraMessageBlocksFieldNumber

```csharp
public const int ExtraMessageBlocksFieldNumber = 34
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ExtraMessagesFieldNumber"></a> ExtraMessagesFieldNumber

```csharp
public const int ExtraMessagesFieldNumber = 26
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_GcSocacheFileVersionFieldNumber"></a> GcSocacheFileVersionFieldNumber

```csharp
public const int GcSocacheFileVersionFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_IsPerfectWorldTestAccountFieldNumber"></a> IsPerfectWorldTestAccountFieldNumber

```csharp
public const int IsPerfectWorldTestAccountFieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_LastIpAddressFieldNumber"></a> LastIpAddressFieldNumber

```csharp
public const int LastIpAddressFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_MinimumRecentItemIdFieldNumber"></a> MinimumRecentItemIdFieldNumber

```csharp
public const int MinimumRecentItemIdFieldNumber = 27
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_PartySearchFriendInvitesFieldNumber"></a> PartySearchFriendInvitesFieldNumber

```csharp
public const int PartySearchFriendInvitesFieldNumber = 31
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ProfilePrivateFieldNumber"></a> ProfilePrivateFieldNumber

```csharp
public const int ProfilePrivateFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_RemainingPlaytimeFieldNumber"></a> RemainingPlaytimeFieldNumber

```csharp
public const int RemainingPlaytimeFieldNumber = 32
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ShouldRequestPlayerOriginFieldNumber"></a> ShouldRequestPlayerOriginFieldNumber

```csharp
public const int ShouldRequestPlayerOriginFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_StoreItemHashFieldNumber"></a> StoreItemHashFieldNumber

```csharp
public const int StoreItemHashFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_TimeplayedconsecutivelyFieldNumber"></a> TimeplayedconsecutivelyFieldNumber

```csharp
public const int TimeplayedconsecutivelyFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ActiveEvent"></a> ActiveEvent

```csharp
public EEvent ActiveEvent { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ActiveEventForDisplay"></a> ActiveEventForDisplay

```csharp
public EEvent ActiveEventForDisplay { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_AdditionalUserMessage"></a> AdditionalUserMessage

```csharp
public uint AdditionalUserMessage { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_Allow3RdPartyMatchHistory"></a> Allow3RdPartyMatchHistory

```csharp
public bool Allow3RdPartyMatchHistory { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_Currency"></a> Currency

```csharp
public uint Currency { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_CustomGameWhitelistVersion"></a> CustomGameWhitelistVersion

```csharp
public uint CustomGameWhitelistVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_DisableGuildPersonaInfo"></a> DisableGuildPersonaInfo

```csharp
public bool DisableGuildPersonaInfo { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ExtraMessageBlocks"></a> ExtraMessageBlocks

```csharp
public RepeatedField<CExtraMsgBlock> ExtraMessageBlocks { get; }
```

#### Property Value

 RepeatedField<[CExtraMsgBlock](Divine.Protobufs.Dota2.CExtraMsgBlock.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ExtraMessages"></a> ExtraMessages

```csharp
public RepeatedField<CMsgDOTAWelcome.Types.CExtraMsg> ExtraMessages { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAWelcome](Divine.Protobufs.Dota2.CMsgDOTAWelcome.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAWelcome.Types.md).[CExtraMsg](Divine.Protobufs.Dota2.CMsgDOTAWelcome.Types.CExtraMsg.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_GcSocacheFileVersion"></a> GcSocacheFileVersion

```csharp
public uint GcSocacheFileVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_HasActiveEvent"></a> HasActiveEvent

```csharp
public bool HasActiveEvent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_HasActiveEventForDisplay"></a> HasActiveEventForDisplay

```csharp
public bool HasActiveEventForDisplay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_HasAdditionalUserMessage"></a> HasAdditionalUserMessage

```csharp
public bool HasAdditionalUserMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_HasAllow3RdPartyMatchHistory"></a> HasAllow3RdPartyMatchHistory

```csharp
public bool HasAllow3RdPartyMatchHistory { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_HasCurrency"></a> HasCurrency

```csharp
public bool HasCurrency { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_HasCustomGameWhitelistVersion"></a> HasCustomGameWhitelistVersion

```csharp
public bool HasCustomGameWhitelistVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_HasDisableGuildPersonaInfo"></a> HasDisableGuildPersonaInfo

```csharp
public bool HasDisableGuildPersonaInfo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_HasGcSocacheFileVersion"></a> HasGcSocacheFileVersion

```csharp
public bool HasGcSocacheFileVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_HasIsPerfectWorldTestAccount"></a> HasIsPerfectWorldTestAccount

```csharp
public bool HasIsPerfectWorldTestAccount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_HasLastIpAddress"></a> HasLastIpAddress

```csharp
public bool HasLastIpAddress { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_HasMinimumRecentItemId"></a> HasMinimumRecentItemId

```csharp
public bool HasMinimumRecentItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_HasProfilePrivate"></a> HasProfilePrivate

```csharp
public bool HasProfilePrivate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_HasRemainingPlaytime"></a> HasRemainingPlaytime

```csharp
public bool HasRemainingPlaytime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_HasShouldRequestPlayerOrigin"></a> HasShouldRequestPlayerOrigin

```csharp
public bool HasShouldRequestPlayerOrigin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_HasStoreItemHash"></a> HasStoreItemHash

```csharp
public bool HasStoreItemHash { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_HasTimeplayedconsecutively"></a> HasTimeplayedconsecutively

```csharp
public bool HasTimeplayedconsecutively { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_IsPerfectWorldTestAccount"></a> IsPerfectWorldTestAccount

```csharp
public bool IsPerfectWorldTestAccount { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_LastIpAddress"></a> LastIpAddress

```csharp
public uint LastIpAddress { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_MinimumRecentItemId"></a> MinimumRecentItemId

```csharp
public ulong MinimumRecentItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAWelcome> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAWelcome](Divine.Protobufs.Dota2.CMsgDOTAWelcome.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_PartySearchFriendInvites"></a> PartySearchFriendInvites

```csharp
public CMsgGCToClientPartySearchInvites PartySearchFriendInvites { get; set; }
```

#### Property Value

 [CMsgGCToClientPartySearchInvites](Divine.Protobufs.Dota2.CMsgGCToClientPartySearchInvites.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ProfilePrivate"></a> ProfilePrivate

```csharp
public bool ProfilePrivate { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_RemainingPlaytime"></a> RemainingPlaytime

```csharp
public int RemainingPlaytime { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ShouldRequestPlayerOrigin"></a> ShouldRequestPlayerOrigin

```csharp
public bool ShouldRequestPlayerOrigin { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_StoreItemHash"></a> StoreItemHash

```csharp
public uint StoreItemHash { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_Timeplayedconsecutively"></a> Timeplayedconsecutively

```csharp
public uint Timeplayedconsecutively { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ClearActiveEvent"></a> ClearActiveEvent\(\)

```csharp
public void ClearActiveEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ClearActiveEventForDisplay"></a> ClearActiveEventForDisplay\(\)

```csharp
public void ClearActiveEventForDisplay()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ClearAdditionalUserMessage"></a> ClearAdditionalUserMessage\(\)

```csharp
public void ClearAdditionalUserMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ClearAllow3RdPartyMatchHistory"></a> ClearAllow3RdPartyMatchHistory\(\)

```csharp
public void ClearAllow3RdPartyMatchHistory()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ClearCurrency"></a> ClearCurrency\(\)

```csharp
public void ClearCurrency()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ClearCustomGameWhitelistVersion"></a> ClearCustomGameWhitelistVersion\(\)

```csharp
public void ClearCustomGameWhitelistVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ClearDisableGuildPersonaInfo"></a> ClearDisableGuildPersonaInfo\(\)

```csharp
public void ClearDisableGuildPersonaInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ClearGcSocacheFileVersion"></a> ClearGcSocacheFileVersion\(\)

```csharp
public void ClearGcSocacheFileVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ClearIsPerfectWorldTestAccount"></a> ClearIsPerfectWorldTestAccount\(\)

```csharp
public void ClearIsPerfectWorldTestAccount()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ClearLastIpAddress"></a> ClearLastIpAddress\(\)

```csharp
public void ClearLastIpAddress()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ClearMinimumRecentItemId"></a> ClearMinimumRecentItemId\(\)

```csharp
public void ClearMinimumRecentItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ClearProfilePrivate"></a> ClearProfilePrivate\(\)

```csharp
public void ClearProfilePrivate()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ClearRemainingPlaytime"></a> ClearRemainingPlaytime\(\)

```csharp
public void ClearRemainingPlaytime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ClearShouldRequestPlayerOrigin"></a> ClearShouldRequestPlayerOrigin\(\)

```csharp
public void ClearShouldRequestPlayerOrigin()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ClearStoreItemHash"></a> ClearStoreItemHash\(\)

```csharp
public void ClearStoreItemHash()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ClearTimeplayedconsecutively"></a> ClearTimeplayedconsecutively\(\)

```csharp
public void ClearTimeplayedconsecutively()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAWelcome Clone()
```

#### Returns

 [CMsgDOTAWelcome](Divine.Protobufs.Dota2.CMsgDOTAWelcome.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_Equals_Divine_Protobufs_Dota2_CMsgDOTAWelcome_"></a> Equals\(CMsgDOTAWelcome\)

```csharp
public bool Equals(CMsgDOTAWelcome other)
```

#### Parameters

`other` [CMsgDOTAWelcome](Divine.Protobufs.Dota2.CMsgDOTAWelcome.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAWelcome_"></a> MergeFrom\(CMsgDOTAWelcome\)

```csharp
public void MergeFrom(CMsgDOTAWelcome other)
```

#### Parameters

`other` [CMsgDOTAWelcome](Divine.Protobufs.Dota2.CMsgDOTAWelcome.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWelcome_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

