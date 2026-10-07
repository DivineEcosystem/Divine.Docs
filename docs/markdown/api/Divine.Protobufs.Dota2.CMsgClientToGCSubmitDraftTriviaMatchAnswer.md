# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer"></a> Class CMsgClientToGCSubmitDraftTriviaMatchAnswer

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSubmitDraftTriviaMatchAnswer : IMessage<CMsgClientToGCSubmitDraftTriviaMatchAnswer>, IEquatable<CMsgClientToGCSubmitDraftTriviaMatchAnswer>, IDeepCloneable<CMsgClientToGCSubmitDraftTriviaMatchAnswer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSubmitDraftTriviaMatchAnswer](Divine.Protobufs.Dota2.CMsgClientToGCSubmitDraftTriviaMatchAnswer.md)

#### Implements

IMessage<CMsgClientToGCSubmitDraftTriviaMatchAnswer\>, 
[IEquatable<CMsgClientToGCSubmitDraftTriviaMatchAnswer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSubmitDraftTriviaMatchAnswer\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSubmitDraftTriviaMatchAnswer\>\(CMsgClientToGCSubmitDraftTriviaMatchAnswer, params CMsgClientToGCSubmitDraftTriviaMatchAnswer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer__ctor"></a> CMsgClientToGCSubmitDraftTriviaMatchAnswer\(\)

```csharp
public CMsgClientToGCSubmitDraftTriviaMatchAnswer()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_"></a> CMsgClientToGCSubmitDraftTriviaMatchAnswer\(CMsgClientToGCSubmitDraftTriviaMatchAnswer\)

```csharp
public CMsgClientToGCSubmitDraftTriviaMatchAnswer(CMsgClientToGCSubmitDraftTriviaMatchAnswer other)
```

#### Parameters

`other` [CMsgClientToGCSubmitDraftTriviaMatchAnswer](Divine.Protobufs.Dota2.CMsgClientToGCSubmitDraftTriviaMatchAnswer.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_ChoseRadiantAsWinnerFieldNumber"></a> ChoseRadiantAsWinnerFieldNumber

```csharp
public const int ChoseRadiantAsWinnerFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_EndTimeFieldNumber"></a> EndTimeFieldNumber

```csharp
public const int EndTimeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_ChoseRadiantAsWinner"></a> ChoseRadiantAsWinner

```csharp
public bool ChoseRadiantAsWinner { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_EndTime"></a> EndTime

```csharp
public uint EndTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_HasChoseRadiantAsWinner"></a> HasChoseRadiantAsWinner

```csharp
public bool HasChoseRadiantAsWinner { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_HasEndTime"></a> HasEndTime

```csharp
public bool HasEndTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSubmitDraftTriviaMatchAnswer> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSubmitDraftTriviaMatchAnswer](Divine.Protobufs.Dota2.CMsgClientToGCSubmitDraftTriviaMatchAnswer.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_ClearChoseRadiantAsWinner"></a> ClearChoseRadiantAsWinner\(\)

```csharp
public void ClearChoseRadiantAsWinner()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_ClearEndTime"></a> ClearEndTime\(\)

```csharp
public void ClearEndTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSubmitDraftTriviaMatchAnswer Clone()
```

#### Returns

 [CMsgClientToGCSubmitDraftTriviaMatchAnswer](Divine.Protobufs.Dota2.CMsgClientToGCSubmitDraftTriviaMatchAnswer.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_"></a> Equals\(CMsgClientToGCSubmitDraftTriviaMatchAnswer\)

```csharp
public bool Equals(CMsgClientToGCSubmitDraftTriviaMatchAnswer other)
```

#### Parameters

`other` [CMsgClientToGCSubmitDraftTriviaMatchAnswer](Divine.Protobufs.Dota2.CMsgClientToGCSubmitDraftTriviaMatchAnswer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_"></a> MergeFrom\(CMsgClientToGCSubmitDraftTriviaMatchAnswer\)

```csharp
public void MergeFrom(CMsgClientToGCSubmitDraftTriviaMatchAnswer other)
```

#### Parameters

`other` [CMsgClientToGCSubmitDraftTriviaMatchAnswer](Divine.Protobufs.Dota2.CMsgClientToGCSubmitDraftTriviaMatchAnswer.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

