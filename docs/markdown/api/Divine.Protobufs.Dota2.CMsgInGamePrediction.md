# <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction"></a> Class CMsgInGamePrediction

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgInGamePrediction : IMessage<CMsgInGamePrediction>, IEquatable<CMsgInGamePrediction>, IDeepCloneable<CMsgInGamePrediction>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgInGamePrediction](Divine.Protobufs.Dota2.CMsgInGamePrediction.md)

#### Implements

IMessage<CMsgInGamePrediction\>, 
[IEquatable<CMsgInGamePrediction\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgInGamePrediction\>, 
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
[EnumerableExtensions.In<CMsgInGamePrediction\>\(CMsgInGamePrediction, params CMsgInGamePrediction\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction__ctor"></a> CMsgInGamePrediction\(\)

```csharp
public CMsgInGamePrediction()
```

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction__ctor_Divine_Protobufs_Dota2_CMsgInGamePrediction_"></a> CMsgInGamePrediction\(CMsgInGamePrediction\)

```csharp
public CMsgInGamePrediction(CMsgInGamePrediction other)
```

#### Parameters

`other` [CMsgInGamePrediction](Divine.Protobufs.Dota2.CMsgInGamePrediction.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_AnswerResolutionTypeFieldNumber"></a> AnswerResolutionTypeFieldNumber

```csharp
public const int AnswerResolutionTypeFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_ChoicesFieldNumber"></a> ChoicesFieldNumber

```csharp
public const int ChoicesFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_DebugForceSelectionFieldNumber"></a> DebugForceSelectionFieldNumber

```csharp
public const int DebugForceSelectionFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_GroupFieldNumber"></a> GroupFieldNumber

```csharp
public const int GroupFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_PointsToGrantFieldNumber"></a> PointsToGrantFieldNumber

```csharp
public const int PointsToGrantFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_QueryNameFieldNumber"></a> QueryNameFieldNumber

```csharp
public const int QueryNameFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_QueryValuesFieldNumber"></a> QueryValuesFieldNumber

```csharp
public const int QueryValuesFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_QuestionFieldNumber"></a> QuestionFieldNumber

```csharp
public const int QuestionFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_RawValueTypeFieldNumber"></a> RawValueTypeFieldNumber

```csharp
public const int RawValueTypeFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_RequiredHeroesFieldNumber"></a> RequiredHeroesFieldNumber

```csharp
public const int RequiredHeroesFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_RewardActionFieldNumber"></a> RewardActionFieldNumber

```csharp
public const int RewardActionFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_AnswerResolutionType"></a> AnswerResolutionType

```csharp
public CMsgInGamePrediction.Types.EResolutionType_t AnswerResolutionType { get; set; }
```

#### Property Value

 [CMsgInGamePrediction](Divine.Protobufs.Dota2.CMsgInGamePrediction.md).[Types](Divine.Protobufs.Dota2.CMsgInGamePrediction.Types.md).[EResolutionType\_t](Divine.Protobufs.Dota2.CMsgInGamePrediction.Types.EResolutionType\_t.md)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_Choices"></a> Choices

```csharp
public RepeatedField<CMsgPredictionChoice> Choices { get; }
```

#### Property Value

 RepeatedField<[CMsgPredictionChoice](Divine.Protobufs.Dota2.CMsgPredictionChoice.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_DebugForceSelection"></a> DebugForceSelection

```csharp
public uint DebugForceSelection { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_Group"></a> Group

```csharp
public CMsgInGamePrediction.Types.ERandomSelectionGroup_t Group { get; set; }
```

#### Property Value

 [CMsgInGamePrediction](Divine.Protobufs.Dota2.CMsgInGamePrediction.md).[Types](Divine.Protobufs.Dota2.CMsgInGamePrediction.Types.md).[ERandomSelectionGroup\_t](Divine.Protobufs.Dota2.CMsgInGamePrediction.Types.ERandomSelectionGroup\_t.md)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_HasAnswerResolutionType"></a> HasAnswerResolutionType

```csharp
public bool HasAnswerResolutionType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_HasDebugForceSelection"></a> HasDebugForceSelection

```csharp
public bool HasDebugForceSelection { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_HasGroup"></a> HasGroup

```csharp
public bool HasGroup { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_HasPointsToGrant"></a> HasPointsToGrant

```csharp
public bool HasPointsToGrant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_HasQueryName"></a> HasQueryName

```csharp
public bool HasQueryName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_HasQuestion"></a> HasQuestion

```csharp
public bool HasQuestion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_HasRawValueType"></a> HasRawValueType

```csharp
public bool HasRawValueType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_HasRewardAction"></a> HasRewardAction

```csharp
public bool HasRewardAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_Id"></a> Id

```csharp
public uint Id { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_Parser"></a> Parser

```csharp
public static MessageParser<CMsgInGamePrediction> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgInGamePrediction](Divine.Protobufs.Dota2.CMsgInGamePrediction.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_PointsToGrant"></a> PointsToGrant

```csharp
public uint PointsToGrant { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_QueryName"></a> QueryName

```csharp
public string QueryName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_QueryValues"></a> QueryValues

```csharp
public RepeatedField<CMsgInGamePrediction.Types.QueryKeyValues> QueryValues { get; }
```

#### Property Value

 RepeatedField<[CMsgInGamePrediction](Divine.Protobufs.Dota2.CMsgInGamePrediction.md).[Types](Divine.Protobufs.Dota2.CMsgInGamePrediction.Types.md).[QueryKeyValues](Divine.Protobufs.Dota2.CMsgInGamePrediction.Types.QueryKeyValues.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_Question"></a> Question

```csharp
public string Question { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_RawValueType"></a> RawValueType

```csharp
public CMsgInGamePrediction.Types.ERawValueType_t RawValueType { get; set; }
```

#### Property Value

 [CMsgInGamePrediction](Divine.Protobufs.Dota2.CMsgInGamePrediction.md).[Types](Divine.Protobufs.Dota2.CMsgInGamePrediction.Types.md).[ERawValueType\_t](Divine.Protobufs.Dota2.CMsgInGamePrediction.Types.ERawValueType\_t.md)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_RequiredHeroes"></a> RequiredHeroes

```csharp
public RepeatedField<string> RequiredHeroes { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_RewardAction"></a> RewardAction

```csharp
public uint RewardAction { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_Type"></a> Type

```csharp
public CMsgInGamePrediction.Types.EPredictionType Type { get; set; }
```

#### Property Value

 [CMsgInGamePrediction](Divine.Protobufs.Dota2.CMsgInGamePrediction.md).[Types](Divine.Protobufs.Dota2.CMsgInGamePrediction.Types.md).[EPredictionType](Divine.Protobufs.Dota2.CMsgInGamePrediction.Types.EPredictionType.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_ClearAnswerResolutionType"></a> ClearAnswerResolutionType\(\)

```csharp
public void ClearAnswerResolutionType()
```

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_ClearDebugForceSelection"></a> ClearDebugForceSelection\(\)

```csharp
public void ClearDebugForceSelection()
```

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_ClearGroup"></a> ClearGroup\(\)

```csharp
public void ClearGroup()
```

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_ClearPointsToGrant"></a> ClearPointsToGrant\(\)

```csharp
public void ClearPointsToGrant()
```

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_ClearQueryName"></a> ClearQueryName\(\)

```csharp
public void ClearQueryName()
```

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_ClearQuestion"></a> ClearQuestion\(\)

```csharp
public void ClearQuestion()
```

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_ClearRawValueType"></a> ClearRawValueType\(\)

```csharp
public void ClearRawValueType()
```

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_ClearRewardAction"></a> ClearRewardAction\(\)

```csharp
public void ClearRewardAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_Clone"></a> Clone\(\)

```csharp
public CMsgInGamePrediction Clone()
```

#### Returns

 [CMsgInGamePrediction](Divine.Protobufs.Dota2.CMsgInGamePrediction.md)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_Equals_Divine_Protobufs_Dota2_CMsgInGamePrediction_"></a> Equals\(CMsgInGamePrediction\)

```csharp
public bool Equals(CMsgInGamePrediction other)
```

#### Parameters

`other` [CMsgInGamePrediction](Divine.Protobufs.Dota2.CMsgInGamePrediction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_MergeFrom_Divine_Protobufs_Dota2_CMsgInGamePrediction_"></a> MergeFrom\(CMsgInGamePrediction\)

```csharp
public void MergeFrom(CMsgInGamePrediction other)
```

#### Parameters

`other` [CMsgInGamePrediction](Divine.Protobufs.Dota2.CMsgInGamePrediction.md)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgInGamePrediction_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

