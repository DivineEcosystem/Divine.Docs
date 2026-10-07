# <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions"></a> Class CMsgDOTATriviaCurrentQuestions

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATriviaCurrentQuestions : IMessage<CMsgDOTATriviaCurrentQuestions>, IEquatable<CMsgDOTATriviaCurrentQuestions>, IDeepCloneable<CMsgDOTATriviaCurrentQuestions>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATriviaCurrentQuestions](Divine.Protobufs.Dota2.CMsgDOTATriviaCurrentQuestions.md)

#### Implements

IMessage<CMsgDOTATriviaCurrentQuestions\>, 
[IEquatable<CMsgDOTATriviaCurrentQuestions\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATriviaCurrentQuestions\>, 
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
[EnumerableExtensions.In<CMsgDOTATriviaCurrentQuestions\>\(CMsgDOTATriviaCurrentQuestions, params CMsgDOTATriviaCurrentQuestions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions__ctor"></a> CMsgDOTATriviaCurrentQuestions\(\)

```csharp
public CMsgDOTATriviaCurrentQuestions()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions__ctor_Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_"></a> CMsgDOTATriviaCurrentQuestions\(CMsgDOTATriviaCurrentQuestions\)

```csharp
public CMsgDOTATriviaCurrentQuestions(CMsgDOTATriviaCurrentQuestions other)
```

#### Parameters

`other` [CMsgDOTATriviaCurrentQuestions](Divine.Protobufs.Dota2.CMsgDOTATriviaCurrentQuestions.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_QuestionsFieldNumber"></a> QuestionsFieldNumber

```csharp
public const int QuestionsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_TriviaEnabledFieldNumber"></a> TriviaEnabledFieldNumber

```csharp
public const int TriviaEnabledFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_HasTriviaEnabled"></a> HasTriviaEnabled

```csharp
public bool HasTriviaEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATriviaCurrentQuestions> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATriviaCurrentQuestions](Divine.Protobufs.Dota2.CMsgDOTATriviaCurrentQuestions.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_Questions"></a> Questions

```csharp
public RepeatedField<CMsgDOTATriviaQuestion> Questions { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTATriviaQuestion](Divine.Protobufs.Dota2.CMsgDOTATriviaQuestion.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_TriviaEnabled"></a> TriviaEnabled

```csharp
public bool TriviaEnabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_ClearTriviaEnabled"></a> ClearTriviaEnabled\(\)

```csharp
public void ClearTriviaEnabled()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATriviaCurrentQuestions Clone()
```

#### Returns

 [CMsgDOTATriviaCurrentQuestions](Divine.Protobufs.Dota2.CMsgDOTATriviaCurrentQuestions.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_Equals_Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_"></a> Equals\(CMsgDOTATriviaCurrentQuestions\)

```csharp
public bool Equals(CMsgDOTATriviaCurrentQuestions other)
```

#### Parameters

`other` [CMsgDOTATriviaCurrentQuestions](Divine.Protobufs.Dota2.CMsgDOTATriviaCurrentQuestions.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_"></a> MergeFrom\(CMsgDOTATriviaCurrentQuestions\)

```csharp
public void MergeFrom(CMsgDOTATriviaCurrentQuestions other)
```

#### Parameters

`other` [CMsgDOTATriviaCurrentQuestions](Divine.Protobufs.Dota2.CMsgDOTATriviaCurrentQuestions.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaCurrentQuestions_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

