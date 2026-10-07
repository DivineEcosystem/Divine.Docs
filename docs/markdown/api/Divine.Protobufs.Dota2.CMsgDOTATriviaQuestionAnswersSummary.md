# <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary"></a> Class CMsgDOTATriviaQuestionAnswersSummary

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATriviaQuestionAnswersSummary : IMessage<CMsgDOTATriviaQuestionAnswersSummary>, IEquatable<CMsgDOTATriviaQuestionAnswersSummary>, IDeepCloneable<CMsgDOTATriviaQuestionAnswersSummary>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATriviaQuestionAnswersSummary](Divine.Protobufs.Dota2.CMsgDOTATriviaQuestionAnswersSummary.md)

#### Implements

IMessage<CMsgDOTATriviaQuestionAnswersSummary\>, 
[IEquatable<CMsgDOTATriviaQuestionAnswersSummary\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATriviaQuestionAnswersSummary\>, 
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
[EnumerableExtensions.In<CMsgDOTATriviaQuestionAnswersSummary\>\(CMsgDOTATriviaQuestionAnswersSummary, params CMsgDOTATriviaQuestionAnswersSummary\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary__ctor"></a> CMsgDOTATriviaQuestionAnswersSummary\(\)

```csharp
public CMsgDOTATriviaQuestionAnswersSummary()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary__ctor_Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_"></a> CMsgDOTATriviaQuestionAnswersSummary\(CMsgDOTATriviaQuestionAnswersSummary\)

```csharp
public CMsgDOTATriviaQuestionAnswersSummary(CMsgDOTATriviaQuestionAnswersSummary other)
```

#### Parameters

`other` [CMsgDOTATriviaQuestionAnswersSummary](Divine.Protobufs.Dota2.CMsgDOTATriviaQuestionAnswersSummary.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_PickedCountFieldNumber"></a> PickedCountFieldNumber

```csharp
public const int PickedCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_SummaryAvailableFieldNumber"></a> SummaryAvailableFieldNumber

```csharp
public const int SummaryAvailableFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_HasSummaryAvailable"></a> HasSummaryAvailable

```csharp
public bool HasSummaryAvailable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATriviaQuestionAnswersSummary> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATriviaQuestionAnswersSummary](Divine.Protobufs.Dota2.CMsgDOTATriviaQuestionAnswersSummary.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_PickedCount"></a> PickedCount

```csharp
public RepeatedField<uint> PickedCount { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_SummaryAvailable"></a> SummaryAvailable

```csharp
public bool SummaryAvailable { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_ClearSummaryAvailable"></a> ClearSummaryAvailable\(\)

```csharp
public void ClearSummaryAvailable()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATriviaQuestionAnswersSummary Clone()
```

#### Returns

 [CMsgDOTATriviaQuestionAnswersSummary](Divine.Protobufs.Dota2.CMsgDOTATriviaQuestionAnswersSummary.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_Equals_Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_"></a> Equals\(CMsgDOTATriviaQuestionAnswersSummary\)

```csharp
public bool Equals(CMsgDOTATriviaQuestionAnswersSummary other)
```

#### Parameters

`other` [CMsgDOTATriviaQuestionAnswersSummary](Divine.Protobufs.Dota2.CMsgDOTATriviaQuestionAnswersSummary.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_"></a> MergeFrom\(CMsgDOTATriviaQuestionAnswersSummary\)

```csharp
public void MergeFrom(CMsgDOTATriviaQuestionAnswersSummary other)
```

#### Parameters

`other` [CMsgDOTATriviaQuestionAnswersSummary](Divine.Protobufs.Dota2.CMsgDOTATriviaQuestionAnswersSummary.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATriviaQuestionAnswersSummary_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

