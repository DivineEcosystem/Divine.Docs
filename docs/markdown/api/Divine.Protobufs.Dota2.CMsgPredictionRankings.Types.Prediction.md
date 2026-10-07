# <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction"></a> Class CMsgPredictionRankings.Types.Prediction

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPredictionRankings.Types.Prediction : IMessage<CMsgPredictionRankings.Types.Prediction>, IEquatable<CMsgPredictionRankings.Types.Prediction>, IDeepCloneable<CMsgPredictionRankings.Types.Prediction>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPredictionRankings.Types.Prediction](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.Prediction.md)

#### Implements

IMessage<CMsgPredictionRankings.Types.Prediction\>, 
[IEquatable<CMsgPredictionRankings.Types.Prediction\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPredictionRankings.Types.Prediction\>, 
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
[EnumerableExtensions.In<CMsgPredictionRankings.Types.Prediction\>\(CMsgPredictionRankings.Types.Prediction, params CMsgPredictionRankings.Types.Prediction\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction__ctor"></a> Prediction\(\)

```csharp
public Prediction()
```

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction__ctor_Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_"></a> Prediction\(Prediction\)

```csharp
public Prediction(CMsgPredictionRankings.Types.Prediction other)
```

#### Parameters

`other` [CMsgPredictionRankings](Divine.Protobufs.Dota2.CMsgPredictionRankings.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.Prediction.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_PredictionLinesFieldNumber"></a> PredictionLinesFieldNumber

```csharp
public const int PredictionLinesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_SelectionIdFieldNumber"></a> SelectionIdFieldNumber

```csharp
public const int SelectionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_HasSelectionId"></a> HasSelectionId

```csharp
public bool HasSelectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPredictionRankings.Types.Prediction> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPredictionRankings](Divine.Protobufs.Dota2.CMsgPredictionRankings.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.Prediction.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_PredictionLines"></a> PredictionLines

```csharp
public RepeatedField<CMsgPredictionRankings.Types.PredictionLine> PredictionLines { get; }
```

#### Property Value

 RepeatedField<[CMsgPredictionRankings](Divine.Protobufs.Dota2.CMsgPredictionRankings.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.md).[PredictionLine](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.PredictionLine.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_SelectionId"></a> SelectionId

```csharp
public uint SelectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_ClearSelectionId"></a> ClearSelectionId\(\)

```csharp
public void ClearSelectionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_Clone"></a> Clone\(\)

```csharp
public CMsgPredictionRankings.Types.Prediction Clone()
```

#### Returns

 [CMsgPredictionRankings](Divine.Protobufs.Dota2.CMsgPredictionRankings.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.Prediction.md)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_Equals_Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_"></a> Equals\(Prediction\)

```csharp
public bool Equals(CMsgPredictionRankings.Types.Prediction other)
```

#### Parameters

`other` [CMsgPredictionRankings](Divine.Protobufs.Dota2.CMsgPredictionRankings.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.Prediction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_MergeFrom_Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_"></a> MergeFrom\(Prediction\)

```csharp
public void MergeFrom(CMsgPredictionRankings.Types.Prediction other)
```

#### Parameters

`other` [CMsgPredictionRankings](Divine.Protobufs.Dota2.CMsgPredictionRankings.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.Prediction.md)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_Prediction_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

