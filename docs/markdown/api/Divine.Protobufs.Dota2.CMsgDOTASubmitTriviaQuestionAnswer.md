# <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer"></a> Class CMsgDOTASubmitTriviaQuestionAnswer

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASubmitTriviaQuestionAnswer : IMessage<CMsgDOTASubmitTriviaQuestionAnswer>, IEquatable<CMsgDOTASubmitTriviaQuestionAnswer>, IDeepCloneable<CMsgDOTASubmitTriviaQuestionAnswer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASubmitTriviaQuestionAnswer](Divine.Protobufs.Dota2.CMsgDOTASubmitTriviaQuestionAnswer.md)

#### Implements

IMessage<CMsgDOTASubmitTriviaQuestionAnswer\>, 
[IEquatable<CMsgDOTASubmitTriviaQuestionAnswer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASubmitTriviaQuestionAnswer\>, 
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
[EnumerableExtensions.In<CMsgDOTASubmitTriviaQuestionAnswer\>\(CMsgDOTASubmitTriviaQuestionAnswer, params CMsgDOTASubmitTriviaQuestionAnswer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer__ctor"></a> CMsgDOTASubmitTriviaQuestionAnswer\(\)

```csharp
public CMsgDOTASubmitTriviaQuestionAnswer()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer__ctor_Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_"></a> CMsgDOTASubmitTriviaQuestionAnswer\(CMsgDOTASubmitTriviaQuestionAnswer\)

```csharp
public CMsgDOTASubmitTriviaQuestionAnswer(CMsgDOTASubmitTriviaQuestionAnswer other)
```

#### Parameters

`other` [CMsgDOTASubmitTriviaQuestionAnswer](Divine.Protobufs.Dota2.CMsgDOTASubmitTriviaQuestionAnswer.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_AnswerIndexFieldNumber"></a> AnswerIndexFieldNumber

```csharp
public const int AnswerIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_QuestionIdFieldNumber"></a> QuestionIdFieldNumber

```csharp
public const int QuestionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_AnswerIndex"></a> AnswerIndex

```csharp
public uint AnswerIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_HasAnswerIndex"></a> HasAnswerIndex

```csharp
public bool HasAnswerIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_HasQuestionId"></a> HasQuestionId

```csharp
public bool HasQuestionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASubmitTriviaQuestionAnswer> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASubmitTriviaQuestionAnswer](Divine.Protobufs.Dota2.CMsgDOTASubmitTriviaQuestionAnswer.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_QuestionId"></a> QuestionId

```csharp
public uint QuestionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_ClearAnswerIndex"></a> ClearAnswerIndex\(\)

```csharp
public void ClearAnswerIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_ClearQuestionId"></a> ClearQuestionId\(\)

```csharp
public void ClearQuestionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASubmitTriviaQuestionAnswer Clone()
```

#### Returns

 [CMsgDOTASubmitTriviaQuestionAnswer](Divine.Protobufs.Dota2.CMsgDOTASubmitTriviaQuestionAnswer.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_Equals_Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_"></a> Equals\(CMsgDOTASubmitTriviaQuestionAnswer\)

```csharp
public bool Equals(CMsgDOTASubmitTriviaQuestionAnswer other)
```

#### Parameters

`other` [CMsgDOTASubmitTriviaQuestionAnswer](Divine.Protobufs.Dota2.CMsgDOTASubmitTriviaQuestionAnswer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_"></a> MergeFrom\(CMsgDOTASubmitTriviaQuestionAnswer\)

```csharp
public void MergeFrom(CMsgDOTASubmitTriviaQuestionAnswer other)
```

#### Parameters

`other` [CMsgDOTASubmitTriviaQuestionAnswer](Divine.Protobufs.Dota2.CMsgDOTASubmitTriviaQuestionAnswer.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

