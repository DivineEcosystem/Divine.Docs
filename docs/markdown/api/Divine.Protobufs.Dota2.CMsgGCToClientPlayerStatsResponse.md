# <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse"></a> Class CMsgGCToClientPlayerStatsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientPlayerStatsResponse : IMessage<CMsgGCToClientPlayerStatsResponse>, IEquatable<CMsgGCToClientPlayerStatsResponse>, IDeepCloneable<CMsgGCToClientPlayerStatsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientPlayerStatsResponse](Divine.Protobufs.Dota2.CMsgGCToClientPlayerStatsResponse.md)

#### Implements

IMessage<CMsgGCToClientPlayerStatsResponse\>, 
[IEquatable<CMsgGCToClientPlayerStatsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientPlayerStatsResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientPlayerStatsResponse\>\(CMsgGCToClientPlayerStatsResponse, params CMsgGCToClientPlayerStatsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse__ctor"></a> CMsgGCToClientPlayerStatsResponse\(\)

```csharp
public CMsgGCToClientPlayerStatsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_"></a> CMsgGCToClientPlayerStatsResponse\(CMsgGCToClientPlayerStatsResponse\)

```csharp
public CMsgGCToClientPlayerStatsResponse(CMsgGCToClientPlayerStatsResponse other)
```

#### Parameters

`other` [CMsgGCToClientPlayerStatsResponse](Divine.Protobufs.Dota2.CMsgGCToClientPlayerStatsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_AegisesSnatchedFieldNumber"></a> AegisesSnatchedFieldNumber

```csharp
public const int AegisesSnatchedFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_CheesesEatenFieldNumber"></a> CheesesEatenFieldNumber

```csharp
public const int CheesesEatenFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_CouriersKilledFieldNumber"></a> CouriersKilledFieldNumber

```csharp
public const int CouriersKilledFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_CreepsStackedFieldNumber"></a> CreepsStackedFieldNumber

```csharp
public const int CreepsStackedFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_FarmScoreFieldNumber"></a> FarmScoreFieldNumber

```csharp
public const int FarmScoreFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_FightScoreFieldNumber"></a> FightScoreFieldNumber

```csharp
public const int FightScoreFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_FirstBloodClaimedFieldNumber"></a> FirstBloodClaimedFieldNumber

```csharp
public const int FirstBloodClaimedFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_FirstBloodGivenFieldNumber"></a> FirstBloodGivenFieldNumber

```csharp
public const int FirstBloodGivenFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_MatchCountFieldNumber"></a> MatchCountFieldNumber

```csharp
public const int MatchCountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_MeanDamageFieldNumber"></a> MeanDamageFieldNumber

```csharp
public const int MeanDamageFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_MeanGpmFieldNumber"></a> MeanGpmFieldNumber

```csharp
public const int MeanGpmFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_MeanHealsFieldNumber"></a> MeanHealsFieldNumber

```csharp
public const int MeanHealsFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_MeanLasthitsFieldNumber"></a> MeanLasthitsFieldNumber

```csharp
public const int MeanLasthitsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_MeanNetworthFieldNumber"></a> MeanNetworthFieldNumber

```csharp
public const int MeanNetworthFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_MeanXppmFieldNumber"></a> MeanXppmFieldNumber

```csharp
public const int MeanXppmFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_PlayerStatsFieldNumber"></a> PlayerStatsFieldNumber

```csharp
public const int PlayerStatsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_PushScoreFieldNumber"></a> PushScoreFieldNumber

```csharp
public const int PushScoreFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_RampagesFieldNumber"></a> RampagesFieldNumber

```csharp
public const int RampagesFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_RapiersPurchasedFieldNumber"></a> RapiersPurchasedFieldNumber

```csharp
public const int RapiersPurchasedFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_SupportScoreFieldNumber"></a> SupportScoreFieldNumber

```csharp
public const int SupportScoreFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_TripleKillsFieldNumber"></a> TripleKillsFieldNumber

```csharp
public const int TripleKillsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_VersatilityScoreFieldNumber"></a> VersatilityScoreFieldNumber

```csharp
public const int VersatilityScoreFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_AegisesSnatched"></a> AegisesSnatched

```csharp
public uint AegisesSnatched { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_CheesesEaten"></a> CheesesEaten

```csharp
public uint CheesesEaten { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_CouriersKilled"></a> CouriersKilled

```csharp
public uint CouriersKilled { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_CreepsStacked"></a> CreepsStacked

```csharp
public uint CreepsStacked { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_FarmScore"></a> FarmScore

```csharp
public float FarmScore { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_FightScore"></a> FightScore

```csharp
public float FightScore { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_FirstBloodClaimed"></a> FirstBloodClaimed

```csharp
public uint FirstBloodClaimed { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_FirstBloodGiven"></a> FirstBloodGiven

```csharp
public uint FirstBloodGiven { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasAegisesSnatched"></a> HasAegisesSnatched

```csharp
public bool HasAegisesSnatched { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasCheesesEaten"></a> HasCheesesEaten

```csharp
public bool HasCheesesEaten { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasCouriersKilled"></a> HasCouriersKilled

```csharp
public bool HasCouriersKilled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasCreepsStacked"></a> HasCreepsStacked

```csharp
public bool HasCreepsStacked { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasFarmScore"></a> HasFarmScore

```csharp
public bool HasFarmScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasFightScore"></a> HasFightScore

```csharp
public bool HasFightScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasFirstBloodClaimed"></a> HasFirstBloodClaimed

```csharp
public bool HasFirstBloodClaimed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasFirstBloodGiven"></a> HasFirstBloodGiven

```csharp
public bool HasFirstBloodGiven { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasMatchCount"></a> HasMatchCount

```csharp
public bool HasMatchCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasMeanDamage"></a> HasMeanDamage

```csharp
public bool HasMeanDamage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasMeanGpm"></a> HasMeanGpm

```csharp
public bool HasMeanGpm { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasMeanHeals"></a> HasMeanHeals

```csharp
public bool HasMeanHeals { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasMeanLasthits"></a> HasMeanLasthits

```csharp
public bool HasMeanLasthits { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasMeanNetworth"></a> HasMeanNetworth

```csharp
public bool HasMeanNetworth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasMeanXppm"></a> HasMeanXppm

```csharp
public bool HasMeanXppm { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasPushScore"></a> HasPushScore

```csharp
public bool HasPushScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasRampages"></a> HasRampages

```csharp
public bool HasRampages { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasRapiersPurchased"></a> HasRapiersPurchased

```csharp
public bool HasRapiersPurchased { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasSupportScore"></a> HasSupportScore

```csharp
public bool HasSupportScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasTripleKills"></a> HasTripleKills

```csharp
public bool HasTripleKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_HasVersatilityScore"></a> HasVersatilityScore

```csharp
public bool HasVersatilityScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_MatchCount"></a> MatchCount

```csharp
public uint MatchCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_MeanDamage"></a> MeanDamage

```csharp
public float MeanDamage { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_MeanGpm"></a> MeanGpm

```csharp
public float MeanGpm { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_MeanHeals"></a> MeanHeals

```csharp
public float MeanHeals { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_MeanLasthits"></a> MeanLasthits

```csharp
public float MeanLasthits { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_MeanNetworth"></a> MeanNetworth

```csharp
public float MeanNetworth { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_MeanXppm"></a> MeanXppm

```csharp
public float MeanXppm { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientPlayerStatsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientPlayerStatsResponse](Divine.Protobufs.Dota2.CMsgGCToClientPlayerStatsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_PlayerStats"></a> PlayerStats

```csharp
public RepeatedField<float> PlayerStats { get; }
```

#### Property Value

 RepeatedField<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_PushScore"></a> PushScore

```csharp
public float PushScore { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_Rampages"></a> Rampages

```csharp
public uint Rampages { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_RapiersPurchased"></a> RapiersPurchased

```csharp
public uint RapiersPurchased { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_SupportScore"></a> SupportScore

```csharp
public float SupportScore { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_TripleKills"></a> TripleKills

```csharp
public uint TripleKills { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_VersatilityScore"></a> VersatilityScore

```csharp
public float VersatilityScore { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearAegisesSnatched"></a> ClearAegisesSnatched\(\)

```csharp
public void ClearAegisesSnatched()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearCheesesEaten"></a> ClearCheesesEaten\(\)

```csharp
public void ClearCheesesEaten()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearCouriersKilled"></a> ClearCouriersKilled\(\)

```csharp
public void ClearCouriersKilled()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearCreepsStacked"></a> ClearCreepsStacked\(\)

```csharp
public void ClearCreepsStacked()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearFarmScore"></a> ClearFarmScore\(\)

```csharp
public void ClearFarmScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearFightScore"></a> ClearFightScore\(\)

```csharp
public void ClearFightScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearFirstBloodClaimed"></a> ClearFirstBloodClaimed\(\)

```csharp
public void ClearFirstBloodClaimed()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearFirstBloodGiven"></a> ClearFirstBloodGiven\(\)

```csharp
public void ClearFirstBloodGiven()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearMatchCount"></a> ClearMatchCount\(\)

```csharp
public void ClearMatchCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearMeanDamage"></a> ClearMeanDamage\(\)

```csharp
public void ClearMeanDamage()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearMeanGpm"></a> ClearMeanGpm\(\)

```csharp
public void ClearMeanGpm()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearMeanHeals"></a> ClearMeanHeals\(\)

```csharp
public void ClearMeanHeals()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearMeanLasthits"></a> ClearMeanLasthits\(\)

```csharp
public void ClearMeanLasthits()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearMeanNetworth"></a> ClearMeanNetworth\(\)

```csharp
public void ClearMeanNetworth()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearMeanXppm"></a> ClearMeanXppm\(\)

```csharp
public void ClearMeanXppm()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearPushScore"></a> ClearPushScore\(\)

```csharp
public void ClearPushScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearRampages"></a> ClearRampages\(\)

```csharp
public void ClearRampages()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearRapiersPurchased"></a> ClearRapiersPurchased\(\)

```csharp
public void ClearRapiersPurchased()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearSupportScore"></a> ClearSupportScore\(\)

```csharp
public void ClearSupportScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearTripleKills"></a> ClearTripleKills\(\)

```csharp
public void ClearTripleKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ClearVersatilityScore"></a> ClearVersatilityScore\(\)

```csharp
public void ClearVersatilityScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientPlayerStatsResponse Clone()
```

#### Returns

 [CMsgGCToClientPlayerStatsResponse](Divine.Protobufs.Dota2.CMsgGCToClientPlayerStatsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_"></a> Equals\(CMsgGCToClientPlayerStatsResponse\)

```csharp
public bool Equals(CMsgGCToClientPlayerStatsResponse other)
```

#### Parameters

`other` [CMsgGCToClientPlayerStatsResponse](Divine.Protobufs.Dota2.CMsgGCToClientPlayerStatsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_"></a> MergeFrom\(CMsgGCToClientPlayerStatsResponse\)

```csharp
public void MergeFrom(CMsgGCToClientPlayerStatsResponse other)
```

#### Parameters

`other` [CMsgGCToClientPlayerStatsResponse](Divine.Protobufs.Dota2.CMsgGCToClientPlayerStatsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerStatsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

