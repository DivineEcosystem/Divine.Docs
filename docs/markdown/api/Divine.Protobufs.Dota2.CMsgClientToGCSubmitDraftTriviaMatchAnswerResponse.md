# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse"></a> Class CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse : IMessage<CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse>, IEquatable<CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse>, IDeepCloneable<CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse.md)

#### Implements

IMessage<CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse\>, 
[IEquatable<CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse\>\(CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse, params CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse__ctor"></a> CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse\(\)

```csharp
public CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse_"></a> CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse\(CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse\)

```csharp
public CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse(CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse other)
```

#### Parameters

`other` [CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse_Result"></a> Result

```csharp
public EDOTADraftTriviaAnswerResult Result { get; set; }
```

#### Property Value

 [EDOTADraftTriviaAnswerResult](Divine.Protobufs.Dota2.EDOTADraftTriviaAnswerResult.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse Clone()
```

#### Returns

 [CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse_"></a> Equals\(CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse\)

```csharp
public bool Equals(CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse other)
```

#### Parameters

`other` [CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse_"></a> MergeFrom\(CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse\)

```csharp
public void MergeFrom(CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse other)
```

#### Parameters

`other` [CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

