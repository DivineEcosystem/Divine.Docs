# <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion"></a> Class CMsgDOTATriviaQuestion

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATriviaQuestion : IMessage<CMsgDOTATriviaQuestion>, IEquatable<CMsgDOTATriviaQuestion>, IDeepCloneable<CMsgDOTATriviaQuestion>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATriviaQuestion](Divine.Protobufs.Dota2.CMsgDOTATriviaQuestion.md)

#### Implements

IMessage<CMsgDOTATriviaQuestion\>, 
[IEquatable<CMsgDOTATriviaQuestion\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATriviaQuestion\>, 
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
[EnumerableExtensions.In<CMsgDOTATriviaQuestion\>\(CMsgDOTATriviaQuestion, params CMsgDOTATriviaQuestion\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion__ctor"></a> CMsgDOTATriviaQuestion\(\)

```csharp
public CMsgDOTATriviaQuestion()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion__ctor_Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_"></a> CMsgDOTATriviaQuestion\(CMsgDOTATriviaQuestion\)

```csharp
public CMsgDOTATriviaQuestion(CMsgDOTATriviaQuestion other)
```

#### Parameters

`other` [CMsgDOTATriviaQuestion](Divine.Protobufs.Dota2.CMsgDOTATriviaQuestion.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_AnswerValuesFieldNumber"></a> AnswerValuesFieldNumber

```csharp
public const int AnswerValuesFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_CategoryFieldNumber"></a> CategoryFieldNumber

```csharp
public const int CategoryFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_CorrectAnswerIndexFieldNumber"></a> CorrectAnswerIndexFieldNumber

```csharp
public const int CorrectAnswerIndexFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_QuestionIdFieldNumber"></a> QuestionIdFieldNumber

```csharp
public const int QuestionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_QuestionValueFieldNumber"></a> QuestionValueFieldNumber

```csharp
public const int QuestionValueFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_AnswerValues"></a> AnswerValues

```csharp
public RepeatedField<string> AnswerValues { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_Category"></a> Category

```csharp
public EDOTATriviaQuestionCategory Category { get; set; }
```

#### Property Value

 [EDOTATriviaQuestionCategory](Divine.Protobufs.Dota2.EDOTATriviaQuestionCategory.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_CorrectAnswerIndex"></a> CorrectAnswerIndex

```csharp
public uint CorrectAnswerIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_HasCategory"></a> HasCategory

```csharp
public bool HasCategory { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_HasCorrectAnswerIndex"></a> HasCorrectAnswerIndex

```csharp
public bool HasCorrectAnswerIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_HasQuestionId"></a> HasQuestionId

```csharp
public bool HasQuestionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_HasQuestionValue"></a> HasQuestionValue

```csharp
public bool HasQuestionValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATriviaQuestion> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATriviaQuestion](Divine.Protobufs.Dota2.CMsgDOTATriviaQuestion.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_QuestionId"></a> QuestionId

```csharp
public uint QuestionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_QuestionValue"></a> QuestionValue

```csharp
public string QuestionValue { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_ClearCategory"></a> ClearCategory\(\)

```csharp
public void ClearCategory()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_ClearCorrectAnswerIndex"></a> ClearCorrectAnswerIndex\(\)

```csharp
public void ClearCorrectAnswerIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_ClearQuestionId"></a> ClearQuestionId\(\)

```csharp
public void ClearQuestionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_ClearQuestionValue"></a> ClearQuestionValue\(\)

```csharp
public void ClearQuestionValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATriviaQuestion Clone()
```

#### Returns

 [CMsgDOTATriviaQuestion](Divine.Protobufs.Dota2.CMsgDOTATriviaQuestion.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_Equals_Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_"></a> Equals\(CMsgDOTATriviaQuestion\)

```csharp
public bool Equals(CMsgDOTATriviaQuestion other)
```

#### Parameters

`other` [CMsgDOTATriviaQuestion](Divine.Protobufs.Dota2.CMsgDOTATriviaQuestion.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_"></a> MergeFrom\(CMsgDOTATriviaQuestion\)

```csharp
public void MergeFrom(CMsgDOTATriviaQuestion other)
```

#### Parameters

`other` [CMsgDOTATriviaQuestion](Divine.Protobufs.Dota2.CMsgDOTATriviaQuestion.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestion_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

