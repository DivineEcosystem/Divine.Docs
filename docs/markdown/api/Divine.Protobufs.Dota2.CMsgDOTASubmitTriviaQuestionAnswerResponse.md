# <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse"></a> Class CMsgDOTASubmitTriviaQuestionAnswerResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASubmitTriviaQuestionAnswerResponse : IMessage<CMsgDOTASubmitTriviaQuestionAnswerResponse>, IEquatable<CMsgDOTASubmitTriviaQuestionAnswerResponse>, IDeepCloneable<CMsgDOTASubmitTriviaQuestionAnswerResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASubmitTriviaQuestionAnswerResponse](Divine.Protobufs.Dota2.CMsgDOTASubmitTriviaQuestionAnswerResponse.md)

#### Implements

IMessage<CMsgDOTASubmitTriviaQuestionAnswerResponse\>, 
[IEquatable<CMsgDOTASubmitTriviaQuestionAnswerResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASubmitTriviaQuestionAnswerResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTASubmitTriviaQuestionAnswerResponse\>\(CMsgDOTASubmitTriviaQuestionAnswerResponse, params CMsgDOTASubmitTriviaQuestionAnswerResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse__ctor"></a> CMsgDOTASubmitTriviaQuestionAnswerResponse\(\)

```csharp
public CMsgDOTASubmitTriviaQuestionAnswerResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse_"></a> CMsgDOTASubmitTriviaQuestionAnswerResponse\(CMsgDOTASubmitTriviaQuestionAnswerResponse\)

```csharp
public CMsgDOTASubmitTriviaQuestionAnswerResponse(CMsgDOTASubmitTriviaQuestionAnswerResponse other)
```

#### Parameters

`other` [CMsgDOTASubmitTriviaQuestionAnswerResponse](Divine.Protobufs.Dota2.CMsgDOTASubmitTriviaQuestionAnswerResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASubmitTriviaQuestionAnswerResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASubmitTriviaQuestionAnswerResponse](Divine.Protobufs.Dota2.CMsgDOTASubmitTriviaQuestionAnswerResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse_Result"></a> Result

```csharp
public EDOTATriviaAnswerResult Result { get; set; }
```

#### Property Value

 [EDOTATriviaAnswerResult](Divine.Protobufs.Dota2.EDOTATriviaAnswerResult.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASubmitTriviaQuestionAnswerResponse Clone()
```

#### Returns

 [CMsgDOTASubmitTriviaQuestionAnswerResponse](Divine.Protobufs.Dota2.CMsgDOTASubmitTriviaQuestionAnswerResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse_"></a> Equals\(CMsgDOTASubmitTriviaQuestionAnswerResponse\)

```csharp
public bool Equals(CMsgDOTASubmitTriviaQuestionAnswerResponse other)
```

#### Parameters

`other` [CMsgDOTASubmitTriviaQuestionAnswerResponse](Divine.Protobufs.Dota2.CMsgDOTASubmitTriviaQuestionAnswerResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse_"></a> MergeFrom\(CMsgDOTASubmitTriviaQuestionAnswerResponse\)

```csharp
public void MergeFrom(CMsgDOTASubmitTriviaQuestionAnswerResponse other)
```

#### Parameters

`other` [CMsgDOTASubmitTriviaQuestionAnswerResponse](Divine.Protobufs.Dota2.CMsgDOTASubmitTriviaQuestionAnswerResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitTriviaQuestionAnswerResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

