# <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card"></a> Class CMsgDOTAFantasyCardLineup.Types.Card

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAFantasyCardLineup.Types.Card : IMessage<CMsgDOTAFantasyCardLineup.Types.Card>, IEquatable<CMsgDOTAFantasyCardLineup.Types.Card>, IDeepCloneable<CMsgDOTAFantasyCardLineup.Types.Card>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAFantasyCardLineup.Types.Card](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.Card.md)

#### Implements

IMessage<CMsgDOTAFantasyCardLineup.Types.Card\>, 
[IEquatable<CMsgDOTAFantasyCardLineup.Types.Card\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAFantasyCardLineup.Types.Card\>, 
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
[EnumerableExtensions.In<CMsgDOTAFantasyCardLineup.Types.Card\>\(CMsgDOTAFantasyCardLineup.Types.Card, params CMsgDOTAFantasyCardLineup.Types.Card\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card__ctor"></a> Card\(\)

```csharp
public Card()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card__ctor_Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_"></a> Card\(Card\)

```csharp
public Card(CMsgDOTAFantasyCardLineup.Types.Card other)
```

#### Parameters

`other` [CMsgDOTAFantasyCardLineup](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.md).[Card](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.Card.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_BonusesFieldNumber"></a> BonusesFieldNumber

```csharp
public const int BonusesFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_FinalizedFieldNumber"></a> FinalizedFieldNumber

```csharp
public const int FinalizedFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_PlayerAccountIdFieldNumber"></a> PlayerAccountIdFieldNumber

```csharp
public const int PlayerAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_PlayerNameFieldNumber"></a> PlayerNameFieldNumber

```csharp
public const int PlayerNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_RoleFieldNumber"></a> RoleFieldNumber

```csharp
public const int RoleFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_ScoreFieldNumber"></a> ScoreFieldNumber

```csharp
public const int ScoreFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_TeamNameFieldNumber"></a> TeamNameFieldNumber

```csharp
public const int TeamNameFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_Bonuses"></a> Bonuses

```csharp
public RepeatedField<CMsgDOTAFantasyCardLineup.Types.CardBonus> Bonuses { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAFantasyCardLineup](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.md).[CardBonus](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.CardBonus.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_Finalized"></a> Finalized

```csharp
public bool Finalized { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_HasFinalized"></a> HasFinalized

```csharp
public bool HasFinalized { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_HasPlayerAccountId"></a> HasPlayerAccountId

```csharp
public bool HasPlayerAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_HasPlayerName"></a> HasPlayerName

```csharp
public bool HasPlayerName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_HasRole"></a> HasRole

```csharp
public bool HasRole { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_HasScore"></a> HasScore

```csharp
public bool HasScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_HasTeamName"></a> HasTeamName

```csharp
public bool HasTeamName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAFantasyCardLineup.Types.Card> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAFantasyCardLineup](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.md).[Card](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.Card.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_PlayerAccountId"></a> PlayerAccountId

```csharp
public uint PlayerAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_PlayerName"></a> PlayerName

```csharp
public string PlayerName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_Role"></a> Role

```csharp
public uint Role { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_Score"></a> Score

```csharp
public float Score { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_TeamName"></a> TeamName

```csharp
public string TeamName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_ClearFinalized"></a> ClearFinalized\(\)

```csharp
public void ClearFinalized()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_ClearPlayerAccountId"></a> ClearPlayerAccountId\(\)

```csharp
public void ClearPlayerAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_ClearPlayerName"></a> ClearPlayerName\(\)

```csharp
public void ClearPlayerName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_ClearRole"></a> ClearRole\(\)

```csharp
public void ClearRole()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_ClearScore"></a> ClearScore\(\)

```csharp
public void ClearScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_ClearTeamName"></a> ClearTeamName\(\)

```csharp
public void ClearTeamName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAFantasyCardLineup.Types.Card Clone()
```

#### Returns

 [CMsgDOTAFantasyCardLineup](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.md).[Card](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.Card.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_Equals_Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_"></a> Equals\(Card\)

```csharp
public bool Equals(CMsgDOTAFantasyCardLineup.Types.Card other)
```

#### Parameters

`other` [CMsgDOTAFantasyCardLineup](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.md).[Card](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.Card.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_"></a> MergeFrom\(Card\)

```csharp
public void MergeFrom(CMsgDOTAFantasyCardLineup.Types.Card other)
```

#### Parameters

`other` [CMsgDOTAFantasyCardLineup](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.md).[Card](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.Card.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Card_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

