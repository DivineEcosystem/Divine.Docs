# <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient"></a> Class CSOEconGameAccountClient

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSOEconGameAccountClient : IMessage<CSOEconGameAccountClient>, IEquatable<CSOEconGameAccountClient>, IDeepCloneable<CSOEconGameAccountClient>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSOEconGameAccountClient](Divine.Protobufs.Dota2.CSOEconGameAccountClient.md)

#### Implements

IMessage<CSOEconGameAccountClient\>, 
[IEquatable<CSOEconGameAccountClient\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSOEconGameAccountClient\>, 
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
[EnumerableExtensions.In<CSOEconGameAccountClient\>\(CSOEconGameAccountClient, params CSOEconGameAccountClient\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient__ctor"></a> CSOEconGameAccountClient\(\)

```csharp
public CSOEconGameAccountClient()
```

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient__ctor_Divine_Protobufs_Dota2_CSOEconGameAccountClient_"></a> CSOEconGameAccountClient\(CSOEconGameAccountClient\)

```csharp
public CSOEconGameAccountClient(CSOEconGameAccountClient other)
```

#### Parameters

`other` [CSOEconGameAccountClient](Divine.Protobufs.Dota2.CSOEconGameAccountClient.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_AdditionalBackpackSlotsFieldNumber"></a> AdditionalBackpackSlotsFieldNumber

```csharp
public const int AdditionalBackpackSlotsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_DuelBanExpirationFieldNumber"></a> DuelBanExpirationFieldNumber

```csharp
public const int DuelBanExpirationFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_EligibleForOnlinePlayFieldNumber"></a> EligibleForOnlinePlayFieldNumber

```csharp
public const int EligibleForOnlinePlayFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_InCoachesListFieldNumber"></a> InCoachesListFieldNumber

```csharp
public const int InCoachesListFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_MadeFirstPurchaseFieldNumber"></a> MadeFirstPurchaseFieldNumber

```csharp
public const int MadeFirstPurchaseFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_NeedToChooseMostHelpfulFriendFieldNumber"></a> NeedToChooseMostHelpfulFriendFieldNumber

```csharp
public const int NeedToChooseMostHelpfulFriendFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_TradeBanExpirationFieldNumber"></a> TradeBanExpirationFieldNumber

```csharp
public const int TradeBanExpirationFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_TrialAccountFieldNumber"></a> TrialAccountFieldNumber

```csharp
public const int TrialAccountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_AdditionalBackpackSlots"></a> AdditionalBackpackSlots

```csharp
public uint AdditionalBackpackSlots { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_DuelBanExpiration"></a> DuelBanExpiration

```csharp
public uint DuelBanExpiration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_EligibleForOnlinePlay"></a> EligibleForOnlinePlay

```csharp
public bool EligibleForOnlinePlay { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_HasAdditionalBackpackSlots"></a> HasAdditionalBackpackSlots

```csharp
public bool HasAdditionalBackpackSlots { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_HasDuelBanExpiration"></a> HasDuelBanExpiration

```csharp
public bool HasDuelBanExpiration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_HasEligibleForOnlinePlay"></a> HasEligibleForOnlinePlay

```csharp
public bool HasEligibleForOnlinePlay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_HasInCoachesList"></a> HasInCoachesList

```csharp
public bool HasInCoachesList { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_HasMadeFirstPurchase"></a> HasMadeFirstPurchase

```csharp
public bool HasMadeFirstPurchase { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_HasNeedToChooseMostHelpfulFriend"></a> HasNeedToChooseMostHelpfulFriend

```csharp
public bool HasNeedToChooseMostHelpfulFriend { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_HasTradeBanExpiration"></a> HasTradeBanExpiration

```csharp
public bool HasTradeBanExpiration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_HasTrialAccount"></a> HasTrialAccount

```csharp
public bool HasTrialAccount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_InCoachesList"></a> InCoachesList

```csharp
public bool InCoachesList { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_MadeFirstPurchase"></a> MadeFirstPurchase

```csharp
public bool MadeFirstPurchase { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_NeedToChooseMostHelpfulFriend"></a> NeedToChooseMostHelpfulFriend

```csharp
public bool NeedToChooseMostHelpfulFriend { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_Parser"></a> Parser

```csharp
public static MessageParser<CSOEconGameAccountClient> Parser { get; }
```

#### Property Value

 MessageParser<[CSOEconGameAccountClient](Divine.Protobufs.Dota2.CSOEconGameAccountClient.md)\>

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_TradeBanExpiration"></a> TradeBanExpiration

```csharp
public uint TradeBanExpiration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_TrialAccount"></a> TrialAccount

```csharp
public bool TrialAccount { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_ClearAdditionalBackpackSlots"></a> ClearAdditionalBackpackSlots\(\)

```csharp
public void ClearAdditionalBackpackSlots()
```

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_ClearDuelBanExpiration"></a> ClearDuelBanExpiration\(\)

```csharp
public void ClearDuelBanExpiration()
```

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_ClearEligibleForOnlinePlay"></a> ClearEligibleForOnlinePlay\(\)

```csharp
public void ClearEligibleForOnlinePlay()
```

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_ClearInCoachesList"></a> ClearInCoachesList\(\)

```csharp
public void ClearInCoachesList()
```

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_ClearMadeFirstPurchase"></a> ClearMadeFirstPurchase\(\)

```csharp
public void ClearMadeFirstPurchase()
```

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_ClearNeedToChooseMostHelpfulFriend"></a> ClearNeedToChooseMostHelpfulFriend\(\)

```csharp
public void ClearNeedToChooseMostHelpfulFriend()
```

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_ClearTradeBanExpiration"></a> ClearTradeBanExpiration\(\)

```csharp
public void ClearTradeBanExpiration()
```

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_ClearTrialAccount"></a> ClearTrialAccount\(\)

```csharp
public void ClearTrialAccount()
```

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_Clone"></a> Clone\(\)

```csharp
public CSOEconGameAccountClient Clone()
```

#### Returns

 [CSOEconGameAccountClient](Divine.Protobufs.Dota2.CSOEconGameAccountClient.md)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_Equals_Divine_Protobufs_Dota2_CSOEconGameAccountClient_"></a> Equals\(CSOEconGameAccountClient\)

```csharp
public bool Equals(CSOEconGameAccountClient other)
```

#### Parameters

`other` [CSOEconGameAccountClient](Divine.Protobufs.Dota2.CSOEconGameAccountClient.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_MergeFrom_Divine_Protobufs_Dota2_CSOEconGameAccountClient_"></a> MergeFrom\(CSOEconGameAccountClient\)

```csharp
public void MergeFrom(CSOEconGameAccountClient other)
```

#### Parameters

`other` [CSOEconGameAccountClient](Divine.Protobufs.Dota2.CSOEconGameAccountClient.md)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSOEconGameAccountClient_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

