# <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData"></a> Class CMsgItemBattlerWorldData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgItemBattlerWorldData : IMessage<CMsgItemBattlerWorldData>, IEquatable<CMsgItemBattlerWorldData>, IDeepCloneable<CMsgItemBattlerWorldData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgItemBattlerWorldData](Divine.Protobufs.Dota2.CMsgItemBattlerWorldData.md)

#### Implements

IMessage<CMsgItemBattlerWorldData\>, 
[IEquatable<CMsgItemBattlerWorldData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgItemBattlerWorldData\>, 
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
[EnumerableExtensions.In<CMsgItemBattlerWorldData\>\(CMsgItemBattlerWorldData, params CMsgItemBattlerWorldData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData__ctor"></a> CMsgItemBattlerWorldData\(\)

```csharp
public CMsgItemBattlerWorldData()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData__ctor_Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_"></a> CMsgItemBattlerWorldData\(CMsgItemBattlerWorldData\)

```csharp
public CMsgItemBattlerWorldData(CMsgItemBattlerWorldData other)
```

#### Parameters

`other` [CMsgItemBattlerWorldData](Divine.Protobufs.Dota2.CMsgItemBattlerWorldData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_ConcededFieldNumber"></a> ConcededFieldNumber

```csharp
public const int ConcededFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_DayFieldNumber"></a> DayFieldNumber

```csharp
public const int DayFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_EncounterChoicesFieldNumber"></a> EncounterChoicesFieldNumber

```csharp
public const int EncounterChoicesFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_EncounterFieldNumber"></a> EncounterFieldNumber

```csharp
public const int EncounterFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_FightResultFieldNumber"></a> FightResultFieldNumber

```csharp
public const int FightResultFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_GameStateFieldNumber"></a> GameStateFieldNumber

```csharp
public const int GameStateFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_HourFieldNumber"></a> HourFieldNumber

```csharp
public const int HourFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_ItemsFieldNumber"></a> ItemsFieldNumber

```csharp
public const int ItemsFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_MonsterChoicesFieldNumber"></a> MonsterChoicesFieldNumber

```csharp
public const int MonsterChoicesFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_OpponentDataFieldNumber"></a> OpponentDataFieldNumber

```csharp
public const int OpponentDataFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_PlayerDataFieldNumber"></a> PlayerDataFieldNumber

```csharp
public const int PlayerDataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_RunActiveFieldNumber"></a> RunActiveFieldNumber

```csharp
public const int RunActiveFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_RunIdFieldNumber"></a> RunIdFieldNumber

```csharp
public const int RunIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_StashFieldNumber"></a> StashFieldNumber

```csharp
public const int StashFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_Conceded"></a> Conceded

```csharp
public bool Conceded { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_Day"></a> Day

```csharp
public int Day { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_Encounter"></a> Encounter

```csharp
public CMsgItemBattlerEncounterData Encounter { get; set; }
```

#### Property Value

 [CMsgItemBattlerEncounterData](Divine.Protobufs.Dota2.CMsgItemBattlerEncounterData.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_EncounterChoices"></a> EncounterChoices

```csharp
public RepeatedField<uint> EncounterChoices { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_FightResult"></a> FightResult

```csharp
public CMsgItemBattlerFightResult FightResult { get; set; }
```

#### Property Value

 [CMsgItemBattlerFightResult](Divine.Protobufs.Dota2.CMsgItemBattlerFightResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_GameState"></a> GameState

```csharp
public EItemBattlerGameState GameState { get; set; }
```

#### Property Value

 [EItemBattlerGameState](Divine.Protobufs.Dota2.EItemBattlerGameState.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_HasConceded"></a> HasConceded

```csharp
public bool HasConceded { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_HasDay"></a> HasDay

```csharp
public bool HasDay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_HasGameState"></a> HasGameState

```csharp
public bool HasGameState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_HasHour"></a> HasHour

```csharp
public bool HasHour { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_HasRunActive"></a> HasRunActive

```csharp
public bool HasRunActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_HasRunId"></a> HasRunId

```csharp
public bool HasRunId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_Hour"></a> Hour

```csharp
public int Hour { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_Items"></a> Items

```csharp
public MapField<uint, CMsgItemBattlerItem> Items { get; }
```

#### Property Value

 MapField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32), [CMsgItemBattlerItem](Divine.Protobufs.Dota2.CMsgItemBattlerItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_MonsterChoices"></a> MonsterChoices

```csharp
public RepeatedField<uint> MonsterChoices { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_OpponentData"></a> OpponentData

```csharp
public CMsgItemBattlerPlayerData OpponentData { get; set; }
```

#### Property Value

 [CMsgItemBattlerPlayerData](Divine.Protobufs.Dota2.CMsgItemBattlerPlayerData.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgItemBattlerWorldData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgItemBattlerWorldData](Divine.Protobufs.Dota2.CMsgItemBattlerWorldData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_PlayerData"></a> PlayerData

```csharp
public CMsgItemBattlerPlayerData PlayerData { get; set; }
```

#### Property Value

 [CMsgItemBattlerPlayerData](Divine.Protobufs.Dota2.CMsgItemBattlerPlayerData.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_RunActive"></a> RunActive

```csharp
public bool RunActive { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_RunId"></a> RunId

```csharp
public uint RunId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_Stash"></a> Stash

```csharp
public CMsgItemBattlerItemContainer Stash { get; set; }
```

#### Property Value

 [CMsgItemBattlerItemContainer](Divine.Protobufs.Dota2.CMsgItemBattlerItemContainer.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_ClearConceded"></a> ClearConceded\(\)

```csharp
public void ClearConceded()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_ClearDay"></a> ClearDay\(\)

```csharp
public void ClearDay()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_ClearGameState"></a> ClearGameState\(\)

```csharp
public void ClearGameState()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_ClearHour"></a> ClearHour\(\)

```csharp
public void ClearHour()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_ClearRunActive"></a> ClearRunActive\(\)

```csharp
public void ClearRunActive()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_ClearRunId"></a> ClearRunId\(\)

```csharp
public void ClearRunId()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_Clone"></a> Clone\(\)

```csharp
public CMsgItemBattlerWorldData Clone()
```

#### Returns

 [CMsgItemBattlerWorldData](Divine.Protobufs.Dota2.CMsgItemBattlerWorldData.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_Equals_Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_"></a> Equals\(CMsgItemBattlerWorldData\)

```csharp
public bool Equals(CMsgItemBattlerWorldData other)
```

#### Parameters

`other` [CMsgItemBattlerWorldData](Divine.Protobufs.Dota2.CMsgItemBattlerWorldData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_MergeFrom_Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_"></a> MergeFrom\(CMsgItemBattlerWorldData\)

```csharp
public void MergeFrom(CMsgItemBattlerWorldData other)
```

#### Parameters

`other` [CMsgItemBattlerWorldData](Divine.Protobufs.Dota2.CMsgItemBattlerWorldData.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerWorldData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

