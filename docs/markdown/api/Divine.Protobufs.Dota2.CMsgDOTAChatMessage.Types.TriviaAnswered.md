# <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered"></a> Class CMsgDOTAChatMessage.Types.TriviaAnswered

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAChatMessage.Types.TriviaAnswered : IMessage<CMsgDOTAChatMessage.Types.TriviaAnswered>, IEquatable<CMsgDOTAChatMessage.Types.TriviaAnswered>, IDeepCloneable<CMsgDOTAChatMessage.Types.TriviaAnswered>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAChatMessage.Types.TriviaAnswered](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.TriviaAnswered.md)

#### Implements

IMessage<CMsgDOTAChatMessage.Types.TriviaAnswered\>, 
[IEquatable<CMsgDOTAChatMessage.Types.TriviaAnswered\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAChatMessage.Types.TriviaAnswered\>, 
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
[EnumerableExtensions.In<CMsgDOTAChatMessage.Types.TriviaAnswered\>\(CMsgDOTAChatMessage.Types.TriviaAnswered, params CMsgDOTAChatMessage.Types.TriviaAnswered\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered__ctor"></a> TriviaAnswered\(\)

```csharp
public TriviaAnswered()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered__ctor_Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_"></a> TriviaAnswered\(TriviaAnswered\)

```csharp
public TriviaAnswered(CMsgDOTAChatMessage.Types.TriviaAnswered other)
```

#### Parameters

`other` [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[TriviaAnswered](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.TriviaAnswered.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_AnswerIndexFieldNumber"></a> AnswerIndexFieldNumber

```csharp
public const int AnswerIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_PartyQuestionsCorrectFieldNumber"></a> PartyQuestionsCorrectFieldNumber

```csharp
public const int PartyQuestionsCorrectFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_PartyQuestionsViewedFieldNumber"></a> PartyQuestionsViewedFieldNumber

```csharp
public const int PartyQuestionsViewedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_PartyTriviaPointsFieldNumber"></a> PartyTriviaPointsFieldNumber

```csharp
public const int PartyTriviaPointsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_QuestionIdFieldNumber"></a> QuestionIdFieldNumber

```csharp
public const int QuestionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_AnswerIndex"></a> AnswerIndex

```csharp
public uint AnswerIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_HasAnswerIndex"></a> HasAnswerIndex

```csharp
public bool HasAnswerIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_HasPartyQuestionsCorrect"></a> HasPartyQuestionsCorrect

```csharp
public bool HasPartyQuestionsCorrect { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_HasPartyQuestionsViewed"></a> HasPartyQuestionsViewed

```csharp
public bool HasPartyQuestionsViewed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_HasPartyTriviaPoints"></a> HasPartyTriviaPoints

```csharp
public bool HasPartyTriviaPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_HasQuestionId"></a> HasQuestionId

```csharp
public bool HasQuestionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAChatMessage.Types.TriviaAnswered> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[TriviaAnswered](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.TriviaAnswered.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_PartyQuestionsCorrect"></a> PartyQuestionsCorrect

```csharp
public uint PartyQuestionsCorrect { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_PartyQuestionsViewed"></a> PartyQuestionsViewed

```csharp
public uint PartyQuestionsViewed { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_PartyTriviaPoints"></a> PartyTriviaPoints

```csharp
public uint PartyTriviaPoints { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_QuestionId"></a> QuestionId

```csharp
public uint QuestionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_ClearAnswerIndex"></a> ClearAnswerIndex\(\)

```csharp
public void ClearAnswerIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_ClearPartyQuestionsCorrect"></a> ClearPartyQuestionsCorrect\(\)

```csharp
public void ClearPartyQuestionsCorrect()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_ClearPartyQuestionsViewed"></a> ClearPartyQuestionsViewed\(\)

```csharp
public void ClearPartyQuestionsViewed()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_ClearPartyTriviaPoints"></a> ClearPartyTriviaPoints\(\)

```csharp
public void ClearPartyTriviaPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_ClearQuestionId"></a> ClearQuestionId\(\)

```csharp
public void ClearQuestionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAChatMessage.Types.TriviaAnswered Clone()
```

#### Returns

 [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[TriviaAnswered](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.TriviaAnswered.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_Equals_Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_"></a> Equals\(TriviaAnswered\)

```csharp
public bool Equals(CMsgDOTAChatMessage.Types.TriviaAnswered other)
```

#### Parameters

`other` [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[TriviaAnswered](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.TriviaAnswered.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_"></a> MergeFrom\(TriviaAnswered\)

```csharp
public void MergeFrom(CMsgDOTAChatMessage.Types.TriviaAnswered other)
```

#### Parameters

`other` [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[TriviaAnswered](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.TriviaAnswered.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_TriviaAnswered_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

