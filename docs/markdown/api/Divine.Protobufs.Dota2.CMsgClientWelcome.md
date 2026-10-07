# <a id="Divine_Protobufs_Dota2_CMsgClientWelcome"></a> Class CMsgClientWelcome

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientWelcome : IMessage<CMsgClientWelcome>, IEquatable<CMsgClientWelcome>, IDeepCloneable<CMsgClientWelcome>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientWelcome](Divine.Protobufs.Dota2.CMsgClientWelcome.md)

#### Implements

IMessage<CMsgClientWelcome\>, 
[IEquatable<CMsgClientWelcome\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientWelcome\>, 
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
[EnumerableExtensions.In<CMsgClientWelcome\>\(CMsgClientWelcome, params CMsgClientWelcome\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome__ctor"></a> CMsgClientWelcome\(\)

```csharp
public CMsgClientWelcome()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome__ctor_Divine_Protobufs_Dota2_CMsgClientWelcome_"></a> CMsgClientWelcome\(CMsgClientWelcome\)

```csharp
public CMsgClientWelcome(CMsgClientWelcome other)
```

#### Parameters

`other` [CMsgClientWelcome](Divine.Protobufs.Dota2.CMsgClientWelcome.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_AdditionalWelcomeMsgsFieldNumber"></a> AdditionalWelcomeMsgsFieldNumber

```csharp
public const int AdditionalWelcomeMsgsFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_BalanceFieldNumber"></a> BalanceFieldNumber

```csharp
public const int BalanceFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_BalanceUrlFieldNumber"></a> BalanceUrlFieldNumber

```csharp
public const int BalanceUrlFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_CurrencyFieldNumber"></a> CurrencyFieldNumber

```csharp
public const int CurrencyFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_GameData2FieldNumber"></a> GameData2FieldNumber

```csharp
public const int GameData2FieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_GameDataFieldNumber"></a> GameDataFieldNumber

```csharp
public const int GameDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_GcSocacheFileVersionFieldNumber"></a> GcSocacheFileVersionFieldNumber

```csharp
public const int GcSocacheFileVersionFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_HasAcceptedChinaSsaFieldNumber"></a> HasAcceptedChinaSsaFieldNumber

```csharp
public const int HasAcceptedChinaSsaFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_IsBannedSteamChinaFieldNumber"></a> IsBannedSteamChinaFieldNumber

```csharp
public const int IsBannedSteamChinaFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_LocationFieldNumber"></a> LocationFieldNumber

```csharp
public const int LocationFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_OutofdateSubscribedCachesFieldNumber"></a> OutofdateSubscribedCachesFieldNumber

```csharp
public const int OutofdateSubscribedCachesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Rtime32GcWelcomeTimestampFieldNumber"></a> Rtime32GcWelcomeTimestampFieldNumber

```csharp
public const int Rtime32GcWelcomeTimestampFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_SteamLearnServerInfoFieldNumber"></a> SteamLearnServerInfoFieldNumber

```csharp
public const int SteamLearnServerInfoFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_TxnCountryCodeFieldNumber"></a> TxnCountryCodeFieldNumber

```csharp
public const int TxnCountryCodeFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_UptodateSubscribedCachesFieldNumber"></a> UptodateSubscribedCachesFieldNumber

```csharp
public const int UptodateSubscribedCachesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_AdditionalWelcomeMsgs"></a> AdditionalWelcomeMsgs

```csharp
public CExtraMsgBlock AdditionalWelcomeMsgs { get; set; }
```

#### Property Value

 [CExtraMsgBlock](Divine.Protobufs.Dota2.CExtraMsgBlock.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Balance"></a> Balance

```csharp
public uint Balance { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_BalanceUrl"></a> BalanceUrl

```csharp
public string BalanceUrl { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Currency"></a> Currency

```csharp
public uint Currency { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_GameData"></a> GameData

```csharp
public ByteString GameData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_GameData2"></a> GameData2

```csharp
public ByteString GameData2 { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_GcSocacheFileVersion"></a> GcSocacheFileVersion

```csharp
public uint GcSocacheFileVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_HasAcceptedChinaSsa"></a> HasAcceptedChinaSsa

```csharp
public bool HasAcceptedChinaSsa { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_HasBalance"></a> HasBalance

```csharp
public bool HasBalance { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_HasBalanceUrl"></a> HasBalanceUrl

```csharp
public bool HasBalanceUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_HasCurrency"></a> HasCurrency

```csharp
public bool HasCurrency { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_HasGameData"></a> HasGameData

```csharp
public bool HasGameData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_HasGameData2"></a> HasGameData2

```csharp
public bool HasGameData2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_HasGcSocacheFileVersion"></a> HasGcSocacheFileVersion

```csharp
public bool HasGcSocacheFileVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_HasHasAcceptedChinaSsa"></a> HasHasAcceptedChinaSsa

```csharp
public bool HasHasAcceptedChinaSsa { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_HasIsBannedSteamChina"></a> HasIsBannedSteamChina

```csharp
public bool HasIsBannedSteamChina { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_HasRtime32GcWelcomeTimestamp"></a> HasRtime32GcWelcomeTimestamp

```csharp
public bool HasRtime32GcWelcomeTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_HasTxnCountryCode"></a> HasTxnCountryCode

```csharp
public bool HasTxnCountryCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_IsBannedSteamChina"></a> IsBannedSteamChina

```csharp
public bool IsBannedSteamChina { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Location"></a> Location

```csharp
public CMsgClientWelcome.Types.Location Location { get; set; }
```

#### Property Value

 [CMsgClientWelcome](Divine.Protobufs.Dota2.CMsgClientWelcome.md).[Types](Divine.Protobufs.Dota2.CMsgClientWelcome.Types.md).[Location](Divine.Protobufs.Dota2.CMsgClientWelcome.Types.Location.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_OutofdateSubscribedCaches"></a> OutofdateSubscribedCaches

```csharp
public RepeatedField<CMsgSOCacheSubscribed> OutofdateSubscribedCaches { get; }
```

#### Property Value

 RepeatedField<[CMsgSOCacheSubscribed](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientWelcome> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientWelcome](Divine.Protobufs.Dota2.CMsgClientWelcome.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Rtime32GcWelcomeTimestamp"></a> Rtime32GcWelcomeTimestamp

```csharp
public uint Rtime32GcWelcomeTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_SteamLearnServerInfo"></a> SteamLearnServerInfo

```csharp
public CMsgSteamLearnServerInfo SteamLearnServerInfo { get; set; }
```

#### Property Value

 [CMsgSteamLearnServerInfo](Divine.Protobufs.Dota2.CMsgSteamLearnServerInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_TxnCountryCode"></a> TxnCountryCode

```csharp
public string TxnCountryCode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_UptodateSubscribedCaches"></a> UptodateSubscribedCaches

```csharp
public RepeatedField<CMsgSOCacheSubscriptionCheck> UptodateSubscribedCaches { get; }
```

#### Property Value

 RepeatedField<[CMsgSOCacheSubscriptionCheck](Divine.Protobufs.Dota2.CMsgSOCacheSubscriptionCheck.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Version"></a> Version

```csharp
public uint Version { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_ClearBalance"></a> ClearBalance\(\)

```csharp
public void ClearBalance()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_ClearBalanceUrl"></a> ClearBalanceUrl\(\)

```csharp
public void ClearBalanceUrl()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_ClearCurrency"></a> ClearCurrency\(\)

```csharp
public void ClearCurrency()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_ClearGameData"></a> ClearGameData\(\)

```csharp
public void ClearGameData()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_ClearGameData2"></a> ClearGameData2\(\)

```csharp
public void ClearGameData2()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_ClearGcSocacheFileVersion"></a> ClearGcSocacheFileVersion\(\)

```csharp
public void ClearGcSocacheFileVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_ClearHasAcceptedChinaSsa"></a> ClearHasAcceptedChinaSsa\(\)

```csharp
public void ClearHasAcceptedChinaSsa()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_ClearIsBannedSteamChina"></a> ClearIsBannedSteamChina\(\)

```csharp
public void ClearIsBannedSteamChina()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_ClearRtime32GcWelcomeTimestamp"></a> ClearRtime32GcWelcomeTimestamp\(\)

```csharp
public void ClearRtime32GcWelcomeTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_ClearTxnCountryCode"></a> ClearTxnCountryCode\(\)

```csharp
public void ClearTxnCountryCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Clone"></a> Clone\(\)

```csharp
public CMsgClientWelcome Clone()
```

#### Returns

 [CMsgClientWelcome](Divine.Protobufs.Dota2.CMsgClientWelcome.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Equals_Divine_Protobufs_Dota2_CMsgClientWelcome_"></a> Equals\(CMsgClientWelcome\)

```csharp
public bool Equals(CMsgClientWelcome other)
```

#### Parameters

`other` [CMsgClientWelcome](Divine.Protobufs.Dota2.CMsgClientWelcome.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_MergeFrom_Divine_Protobufs_Dota2_CMsgClientWelcome_"></a> MergeFrom\(CMsgClientWelcome\)

```csharp
public void MergeFrom(CMsgClientWelcome other)
```

#### Parameters

`other` [CMsgClientWelcome](Divine.Protobufs.Dota2.CMsgClientWelcome.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

