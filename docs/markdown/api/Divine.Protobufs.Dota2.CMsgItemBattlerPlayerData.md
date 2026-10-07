# <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData"></a> Class CMsgItemBattlerPlayerData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgItemBattlerPlayerData : IMessage<CMsgItemBattlerPlayerData>, IEquatable<CMsgItemBattlerPlayerData>, IDeepCloneable<CMsgItemBattlerPlayerData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgItemBattlerPlayerData](Divine.Protobufs.Dota2.CMsgItemBattlerPlayerData.md)

#### Implements

IMessage<CMsgItemBattlerPlayerData\>, 
[IEquatable<CMsgItemBattlerPlayerData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgItemBattlerPlayerData\>, 
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
[EnumerableExtensions.In<CMsgItemBattlerPlayerData\>\(CMsgItemBattlerPlayerData, params CMsgItemBattlerPlayerData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData__ctor"></a> CMsgItemBattlerPlayerData\(\)

```csharp
public CMsgItemBattlerPlayerData()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData__ctor_Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_"></a> CMsgItemBattlerPlayerData\(CMsgItemBattlerPlayerData\)

```csharp
public CMsgItemBattlerPlayerData(CMsgItemBattlerPlayerData other)
```

#### Parameters

`other` [CMsgItemBattlerPlayerData](Divine.Protobufs.Dota2.CMsgItemBattlerPlayerData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_AbilitiesFieldNumber"></a> AbilitiesFieldNumber

```csharp
public const int AbilitiesFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_BaseMaxHealthFieldNumber"></a> BaseMaxHealthFieldNumber

```csharp
public const int BaseMaxHealthFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_BoardFieldNumber"></a> BoardFieldNumber

```csharp
public const int BoardFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_BonusMaxHealthFieldNumber"></a> BonusMaxHealthFieldNumber

```csharp
public const int BonusMaxHealthFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_ExperienceFieldNumber"></a> ExperienceFieldNumber

```csharp
public const int ExperienceFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_GoldFieldNumber"></a> GoldFieldNumber

```csharp
public const int GoldFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_IncomeFieldNumber"></a> IncomeFieldNumber

```csharp
public const int IncomeFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_LevelFieldNumber"></a> LevelFieldNumber

```csharp
public const int LevelFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_LossesFieldNumber"></a> LossesFieldNumber

```csharp
public const int LossesFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_MonsterIdFieldNumber"></a> MonsterIdFieldNumber

```csharp
public const int MonsterIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_PrestigeFieldNumber"></a> PrestigeFieldNumber

```csharp
public const int PrestigeFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_SkillsFieldNumber"></a> SkillsFieldNumber

```csharp
public const int SkillsFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_WinsFieldNumber"></a> WinsFieldNumber

```csharp
public const int WinsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_Abilities"></a> Abilities

```csharp
public CMsgItemBattlerItemContainer Abilities { get; set; }
```

#### Property Value

 [CMsgItemBattlerItemContainer](Divine.Protobufs.Dota2.CMsgItemBattlerItemContainer.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_BaseMaxHealth"></a> BaseMaxHealth

```csharp
public uint BaseMaxHealth { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_Board"></a> Board

```csharp
public CMsgItemBattlerItemContainer Board { get; set; }
```

#### Property Value

 [CMsgItemBattlerItemContainer](Divine.Protobufs.Dota2.CMsgItemBattlerItemContainer.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_BonusMaxHealth"></a> BonusMaxHealth

```csharp
public uint BonusMaxHealth { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_Experience"></a> Experience

```csharp
public int Experience { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_Gold"></a> Gold

```csharp
public int Gold { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_HasBaseMaxHealth"></a> HasBaseMaxHealth

```csharp
public bool HasBaseMaxHealth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_HasBonusMaxHealth"></a> HasBonusMaxHealth

```csharp
public bool HasBonusMaxHealth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_HasExperience"></a> HasExperience

```csharp
public bool HasExperience { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_HasGold"></a> HasGold

```csharp
public bool HasGold { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_HasIncome"></a> HasIncome

```csharp
public bool HasIncome { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_HasLevel"></a> HasLevel

```csharp
public bool HasLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_HasLosses"></a> HasLosses

```csharp
public bool HasLosses { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_HasMonsterId"></a> HasMonsterId

```csharp
public bool HasMonsterId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_HasPrestige"></a> HasPrestige

```csharp
public bool HasPrestige { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_HasWins"></a> HasWins

```csharp
public bool HasWins { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_HeroId"></a> HeroId

```csharp
public uint HeroId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_Income"></a> Income

```csharp
public int Income { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_Level"></a> Level

```csharp
public uint Level { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_Losses"></a> Losses

```csharp
public int Losses { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_MonsterId"></a> MonsterId

```csharp
public uint MonsterId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgItemBattlerPlayerData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgItemBattlerPlayerData](Divine.Protobufs.Dota2.CMsgItemBattlerPlayerData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_Prestige"></a> Prestige

```csharp
public int Prestige { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_Skills"></a> Skills

```csharp
public RepeatedField<uint> Skills { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_Wins"></a> Wins

```csharp
public int Wins { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_ClearBaseMaxHealth"></a> ClearBaseMaxHealth\(\)

```csharp
public void ClearBaseMaxHealth()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_ClearBonusMaxHealth"></a> ClearBonusMaxHealth\(\)

```csharp
public void ClearBonusMaxHealth()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_ClearExperience"></a> ClearExperience\(\)

```csharp
public void ClearExperience()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_ClearGold"></a> ClearGold\(\)

```csharp
public void ClearGold()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_ClearIncome"></a> ClearIncome\(\)

```csharp
public void ClearIncome()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_ClearLevel"></a> ClearLevel\(\)

```csharp
public void ClearLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_ClearLosses"></a> ClearLosses\(\)

```csharp
public void ClearLosses()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_ClearMonsterId"></a> ClearMonsterId\(\)

```csharp
public void ClearMonsterId()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_ClearPrestige"></a> ClearPrestige\(\)

```csharp
public void ClearPrestige()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_ClearWins"></a> ClearWins\(\)

```csharp
public void ClearWins()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_Clone"></a> Clone\(\)

```csharp
public CMsgItemBattlerPlayerData Clone()
```

#### Returns

 [CMsgItemBattlerPlayerData](Divine.Protobufs.Dota2.CMsgItemBattlerPlayerData.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_Equals_Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_"></a> Equals\(CMsgItemBattlerPlayerData\)

```csharp
public bool Equals(CMsgItemBattlerPlayerData other)
```

#### Parameters

`other` [CMsgItemBattlerPlayerData](Divine.Protobufs.Dota2.CMsgItemBattlerPlayerData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_MergeFrom_Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_"></a> MergeFrom\(CMsgItemBattlerPlayerData\)

```csharp
public void MergeFrom(CMsgItemBattlerPlayerData other)
```

#### Parameters

`other` [CMsgItemBattlerPlayerData](Divine.Protobufs.Dota2.CMsgItemBattlerPlayerData.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

