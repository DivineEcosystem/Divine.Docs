# <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers"></a> Class CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers : IMessage<CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers>, IEquatable<CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers>, IDeepCloneable<CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers.md)

#### Implements

IMessage<CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers\>, 
[IEquatable<CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers\>, 
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
[EnumerableExtensions.In<CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers\>\(CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers, params CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers__ctor"></a> Answers\(\)

```csharp
public Answers()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers__ctor_Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers_"></a> Answers\(Answers\)

```csharp
public Answers(CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers other)
```

#### Parameters

`other` [CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.Types.md).[Answers](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers_AnswerIdFieldNumber"></a> AnswerIdFieldNumber

```csharp
public const int AnswerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers_AnswerId"></a> AnswerId

```csharp
public uint AnswerId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers_HasAnswerId"></a> HasAnswerId

```csharp
public bool HasAnswerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.Types.md).[Answers](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers_ClearAnswerId"></a> ClearAnswerId\(\)

```csharp
public void ClearAnswerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers Clone()
```

#### Returns

 [CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.Types.md).[Answers](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers_Equals_Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers_"></a> Equals\(Answers\)

```csharp
public bool Equals(CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers other)
```

#### Parameters

`other` [CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.Types.md).[Answers](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers_"></a> MergeFrom\(Answers\)

```csharp
public void MergeFrom(CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers other)
```

#### Parameters

`other` [CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.Types.md).[Answers](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.Types.Answers.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Types_Prediction_Types_Answers_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

