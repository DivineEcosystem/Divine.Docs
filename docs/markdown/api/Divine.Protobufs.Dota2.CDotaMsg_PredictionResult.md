# <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult"></a> Class CDotaMsg\_PredictionResult

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDotaMsg_PredictionResult : IMessage<CDotaMsg_PredictionResult>, IEquatable<CDotaMsg_PredictionResult>, IDeepCloneable<CDotaMsg_PredictionResult>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDotaMsg\_PredictionResult](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.md)

#### Implements

IMessage<CDotaMsg\_PredictionResult\>, 
[IEquatable<CDotaMsg\_PredictionResult\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDotaMsg\_PredictionResult\>, 
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
[EnumerableExtensions.In<CDotaMsg\_PredictionResult\>\(CDotaMsg\_PredictionResult, params CDotaMsg\_PredictionResult\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult__ctor"></a> CDotaMsg\_PredictionResult\(\)

```csharp
public CDotaMsg_PredictionResult()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult__ctor_Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_"></a> CDotaMsg\_PredictionResult\(CDotaMsg\_PredictionResult\)

```csharp
public CDotaMsg_PredictionResult(CDotaMsg_PredictionResult other)
```

#### Parameters

`other` [CDotaMsg\_PredictionResult](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_CorrectFieldNumber"></a> CorrectFieldNumber

```csharp
public const int CorrectFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_PredictionsFieldNumber"></a> PredictionsFieldNumber

```csharp
public const int PredictionsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Correct"></a> Correct

```csharp
public bool Correct { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_HasCorrect"></a> HasCorrect

```csharp
public bool HasCorrect { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Parser"></a> Parser

```csharp
public static MessageParser<CDotaMsg_PredictionResult> Parser { get; }
```

#### Property Value

 MessageParser<[CDotaMsg\_PredictionResult](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.md)\>

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Predictions"></a> Predictions

```csharp
public RepeatedField<CDotaMsg_PredictionResult.Types.Prediction> Predictions { get; }
```

#### Property Value

 RepeatedField<[CDotaMsg\_PredictionResult](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.md).[Types](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.Types.md).[Prediction](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.Types.Prediction.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_ClearCorrect"></a> ClearCorrect\(\)

```csharp
public void ClearCorrect()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Clone"></a> Clone\(\)

```csharp
public CDotaMsg_PredictionResult Clone()
```

#### Returns

 [CDotaMsg\_PredictionResult](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Equals_Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_"></a> Equals\(CDotaMsg\_PredictionResult\)

```csharp
public bool Equals(CDotaMsg_PredictionResult other)
```

#### Parameters

`other` [CDotaMsg\_PredictionResult](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_MergeFrom_Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_"></a> MergeFrom\(CDotaMsg\_PredictionResult\)

```csharp
public void MergeFrom(CDotaMsg_PredictionResult other)
```

#### Parameters

`other` [CDotaMsg\_PredictionResult](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

