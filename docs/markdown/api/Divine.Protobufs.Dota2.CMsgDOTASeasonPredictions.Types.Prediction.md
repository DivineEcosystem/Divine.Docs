# <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction"></a> Class CMsgDOTASeasonPredictions.Types.Prediction

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASeasonPredictions.Types.Prediction : IMessage<CMsgDOTASeasonPredictions.Types.Prediction>, IEquatable<CMsgDOTASeasonPredictions.Types.Prediction>, IDeepCloneable<CMsgDOTASeasonPredictions.Types.Prediction>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASeasonPredictions.Types.Prediction](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.md)

#### Implements

IMessage<CMsgDOTASeasonPredictions.Types.Prediction\>, 
[IEquatable<CMsgDOTASeasonPredictions.Types.Prediction\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASeasonPredictions.Types.Prediction\>, 
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
[EnumerableExtensions.In<CMsgDOTASeasonPredictions.Types.Prediction\>\(CMsgDOTASeasonPredictions.Types.Prediction, params CMsgDOTASeasonPredictions.Types.Prediction\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction__ctor"></a> Prediction\(\)

```csharp
public Prediction()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction__ctor_Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_"></a> Prediction\(Prediction\)

```csharp
public Prediction(CMsgDOTASeasonPredictions.Types.Prediction other)
```

#### Parameters

`other` [CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_AnswerIdFieldNumber"></a> AnswerIdFieldNumber

```csharp
public const int AnswerIdFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_AnswersFieldNumber"></a> AnswersFieldNumber

```csharp
public const int AnswersFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_AnswerTypeFieldNumber"></a> AnswerTypeFieldNumber

```csharp
public const int AnswerTypeFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_ChoicesFieldNumber"></a> ChoicesFieldNumber

```csharp
public const int ChoicesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_LeagueNodeIdFieldNumber"></a> LeagueNodeIdFieldNumber

```csharp
public const int LeagueNodeIdFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_LockDateFieldNumber"></a> LockDateFieldNumber

```csharp
public const int LockDateFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_LockOnSelectionIdFieldNumber"></a> LockOnSelectionIdFieldNumber

```csharp
public const int LockOnSelectionIdFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_LockOnSelectionSetFieldNumber"></a> LockOnSelectionSetFieldNumber

```csharp
public const int LockOnSelectionSetFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_LockOnSelectionValueFieldNumber"></a> LockOnSelectionValueFieldNumber

```csharp
public const int LockOnSelectionValueFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_PhasesFieldNumber"></a> PhasesFieldNumber

```csharp
public const int PhasesFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_QueryNameFieldNumber"></a> QueryNameFieldNumber

```csharp
public const int QueryNameFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_QuestionFieldNumber"></a> QuestionFieldNumber

```csharp
public const int QuestionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_RegionFieldNumber"></a> RegionFieldNumber

```csharp
public const int RegionFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_RewardEventActionFieldNumber"></a> RewardEventActionFieldNumber

```csharp
public const int RewardEventActionFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_RewardEventFieldNumber"></a> RewardEventFieldNumber

```csharp
public const int RewardEventFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_RewardFieldNumber"></a> RewardFieldNumber

```csharp
public const int RewardFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_SelectionIdFieldNumber"></a> SelectionIdFieldNumber

```csharp
public const int SelectionIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_StartDateFieldNumber"></a> StartDateFieldNumber

```csharp
public const int StartDateFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_UseAnswerValueRangesFieldNumber"></a> UseAnswerValueRangesFieldNumber

```csharp
public const int UseAnswerValueRangesFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_AnswerId"></a> AnswerId

```csharp
public uint AnswerId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Answers"></a> Answers

```csharp
public RepeatedField<CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers> Answers { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.Types.md).[Answers](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_AnswerType"></a> AnswerType

```csharp
public CMsgDOTASeasonPredictions.Types.Prediction.Types.EAnswerType AnswerType { get; set; }
```

#### Property Value

 [CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.Types.md).[EAnswerType](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.Types.EAnswerType.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Choices"></a> Choices

```csharp
public RepeatedField<CMsgPredictionChoice> Choices { get; }
```

#### Property Value

 RepeatedField<[CMsgPredictionChoice](Divine.Protobufs.Dota2.CMsgPredictionChoice.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_HasAnswerId"></a> HasAnswerId

```csharp
public bool HasAnswerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_HasAnswerType"></a> HasAnswerType

```csharp
public bool HasAnswerType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_HasLeagueNodeId"></a> HasLeagueNodeId

```csharp
public bool HasLeagueNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_HasLockDate"></a> HasLockDate

```csharp
public bool HasLockDate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_HasLockOnSelectionId"></a> HasLockOnSelectionId

```csharp
public bool HasLockOnSelectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_HasLockOnSelectionSet"></a> HasLockOnSelectionSet

```csharp
public bool HasLockOnSelectionSet { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_HasLockOnSelectionValue"></a> HasLockOnSelectionValue

```csharp
public bool HasLockOnSelectionValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_HasQueryName"></a> HasQueryName

```csharp
public bool HasQueryName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_HasQuestion"></a> HasQuestion

```csharp
public bool HasQuestion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_HasRegion"></a> HasRegion

```csharp
public bool HasRegion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_HasReward"></a> HasReward

```csharp
public bool HasReward { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_HasRewardEvent"></a> HasRewardEvent

```csharp
public bool HasRewardEvent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_HasRewardEventAction"></a> HasRewardEventAction

```csharp
public bool HasRewardEventAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_HasSelectionId"></a> HasSelectionId

```csharp
public bool HasSelectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_HasStartDate"></a> HasStartDate

```csharp
public bool HasStartDate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_HasUseAnswerValueRanges"></a> HasUseAnswerValueRanges

```csharp
public bool HasUseAnswerValueRanges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_LeagueNodeId"></a> LeagueNodeId

```csharp
public uint LeagueNodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_LockDate"></a> LockDate

```csharp
public uint LockDate { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_LockOnSelectionId"></a> LockOnSelectionId

```csharp
public uint LockOnSelectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_LockOnSelectionSet"></a> LockOnSelectionSet

```csharp
public bool LockOnSelectionSet { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_LockOnSelectionValue"></a> LockOnSelectionValue

```csharp
public uint LockOnSelectionValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASeasonPredictions.Types.Prediction> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Phases"></a> Phases

```csharp
public RepeatedField<ELeaguePhase> Phases { get; }
```

#### Property Value

 RepeatedField<[ELeaguePhase](Divine.Protobufs.Dota2.ELeaguePhase.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_QueryName"></a> QueryName

```csharp
public string QueryName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Question"></a> Question

```csharp
public string Question { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Region"></a> Region

```csharp
public ELeagueRegion Region { get; set; }
```

#### Property Value

 [ELeagueRegion](Divine.Protobufs.Dota2.ELeagueRegion.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Reward"></a> Reward

```csharp
public uint Reward { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_RewardEvent"></a> RewardEvent

```csharp
public EEvent RewardEvent { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_RewardEventAction"></a> RewardEventAction

```csharp
public string RewardEventAction { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_SelectionId"></a> SelectionId

```csharp
public uint SelectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_StartDate"></a> StartDate

```csharp
public uint StartDate { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Type"></a> Type

```csharp
public CMsgDOTASeasonPredictions.Types.Prediction.Types.EPredictionType Type { get; set; }
```

#### Property Value

 [CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.Types.md).[EPredictionType](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.Types.EPredictionType.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_UseAnswerValueRanges"></a> UseAnswerValueRanges

```csharp
public bool UseAnswerValueRanges { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_ClearAnswerId"></a> ClearAnswerId\(\)

```csharp
public void ClearAnswerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_ClearAnswerType"></a> ClearAnswerType\(\)

```csharp
public void ClearAnswerType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_ClearLeagueNodeId"></a> ClearLeagueNodeId\(\)

```csharp
public void ClearLeagueNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_ClearLockDate"></a> ClearLockDate\(\)

```csharp
public void ClearLockDate()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_ClearLockOnSelectionId"></a> ClearLockOnSelectionId\(\)

```csharp
public void ClearLockOnSelectionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_ClearLockOnSelectionSet"></a> ClearLockOnSelectionSet\(\)

```csharp
public void ClearLockOnSelectionSet()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_ClearLockOnSelectionValue"></a> ClearLockOnSelectionValue\(\)

```csharp
public void ClearLockOnSelectionValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_ClearQueryName"></a> ClearQueryName\(\)

```csharp
public void ClearQueryName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_ClearQuestion"></a> ClearQuestion\(\)

```csharp
public void ClearQuestion()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_ClearRegion"></a> ClearRegion\(\)

```csharp
public void ClearRegion()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_ClearReward"></a> ClearReward\(\)

```csharp
public void ClearReward()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_ClearRewardEvent"></a> ClearRewardEvent\(\)

```csharp
public void ClearRewardEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_ClearRewardEventAction"></a> ClearRewardEventAction\(\)

```csharp
public void ClearRewardEventAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_ClearSelectionId"></a> ClearSelectionId\(\)

```csharp
public void ClearSelectionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_ClearStartDate"></a> ClearStartDate\(\)

```csharp
public void ClearStartDate()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_ClearUseAnswerValueRanges"></a> ClearUseAnswerValueRanges\(\)

```csharp
public void ClearUseAnswerValueRanges()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASeasonPredictions.Types.Prediction Clone()
```

#### Returns

 [CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Equals_Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_"></a> Equals\(Prediction\)

```csharp
public bool Equals(CMsgDOTASeasonPredictions.Types.Prediction other)
```

#### Parameters

`other` [CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_"></a> MergeFrom\(Prediction\)

```csharp
public void MergeFrom(CMsgDOTASeasonPredictions.Types.Prediction other)
```

#### Parameters

`other` [CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

