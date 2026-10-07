# <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions"></a> Class CMsgDOTASeasonPredictions

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASeasonPredictions : IMessage<CMsgDOTASeasonPredictions>, IEquatable<CMsgDOTASeasonPredictions>, IDeepCloneable<CMsgDOTASeasonPredictions>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md)

#### Implements

IMessage<CMsgDOTASeasonPredictions\>, 
[IEquatable<CMsgDOTASeasonPredictions\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASeasonPredictions\>, 
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
[EnumerableExtensions.In<CMsgDOTASeasonPredictions\>\(CMsgDOTASeasonPredictions, params CMsgDOTASeasonPredictions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions__ctor"></a> CMsgDOTASeasonPredictions\(\)

```csharp
public CMsgDOTASeasonPredictions()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions__ctor_Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_"></a> CMsgDOTASeasonPredictions\(CMsgDOTASeasonPredictions\)

```csharp
public CMsgDOTASeasonPredictions(CMsgDOTASeasonPredictions other)
```

#### Parameters

`other` [CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_InGamePredictionCountPerGameFieldNumber"></a> InGamePredictionCountPerGameFieldNumber

```csharp
public const int InGamePredictionCountPerGameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_InGamePredictionsFieldNumber"></a> InGamePredictionsFieldNumber

```csharp
public const int InGamePredictionsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_InGamePredictionVotingPeriodMinutesFieldNumber"></a> InGamePredictionVotingPeriodMinutesFieldNumber

```csharp
public const int InGamePredictionVotingPeriodMinutesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_PredictionsFieldNumber"></a> PredictionsFieldNumber

```csharp
public const int PredictionsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_HasInGamePredictionCountPerGame"></a> HasInGamePredictionCountPerGame

```csharp
public bool HasInGamePredictionCountPerGame { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_HasInGamePredictionVotingPeriodMinutes"></a> HasInGamePredictionVotingPeriodMinutes

```csharp
public bool HasInGamePredictionVotingPeriodMinutes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_InGamePredictionCountPerGame"></a> InGamePredictionCountPerGame

```csharp
public uint InGamePredictionCountPerGame { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_InGamePredictions"></a> InGamePredictions

```csharp
public RepeatedField<CMsgInGamePrediction> InGamePredictions { get; }
```

#### Property Value

 RepeatedField<[CMsgInGamePrediction](Divine.Protobufs.Dota2.CMsgInGamePrediction.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_InGamePredictionVotingPeriodMinutes"></a> InGamePredictionVotingPeriodMinutes

```csharp
public uint InGamePredictionVotingPeriodMinutes { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASeasonPredictions> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Predictions"></a> Predictions

```csharp
public RepeatedField<CMsgDOTASeasonPredictions.Types.Prediction> Predictions { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.Types.Prediction.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_ClearInGamePredictionCountPerGame"></a> ClearInGamePredictionCountPerGame\(\)

```csharp
public void ClearInGamePredictionCountPerGame()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_ClearInGamePredictionVotingPeriodMinutes"></a> ClearInGamePredictionVotingPeriodMinutes\(\)

```csharp
public void ClearInGamePredictionVotingPeriodMinutes()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASeasonPredictions Clone()
```

#### Returns

 [CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_Equals_Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_"></a> Equals\(CMsgDOTASeasonPredictions\)

```csharp
public bool Equals(CMsgDOTASeasonPredictions other)
```

#### Parameters

`other` [CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_"></a> MergeFrom\(CMsgDOTASeasonPredictions\)

```csharp
public void MergeFrom(CMsgDOTASeasonPredictions other)
```

#### Parameters

`other` [CMsgDOTASeasonPredictions](Divine.Protobufs.Dota2.CMsgDOTASeasonPredictions.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeasonPredictions_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

