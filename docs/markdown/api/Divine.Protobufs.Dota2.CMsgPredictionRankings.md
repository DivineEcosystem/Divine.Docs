# <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings"></a> Class CMsgPredictionRankings

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPredictionRankings : IMessage<CMsgPredictionRankings>, IEquatable<CMsgPredictionRankings>, IDeepCloneable<CMsgPredictionRankings>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPredictionRankings](Divine.Protobufs.Dota2.CMsgPredictionRankings.md)

#### Implements

IMessage<CMsgPredictionRankings\>, 
[IEquatable<CMsgPredictionRankings\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPredictionRankings\>, 
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
[EnumerableExtensions.In<CMsgPredictionRankings\>\(CMsgPredictionRankings, params CMsgPredictionRankings\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings__ctor"></a> CMsgPredictionRankings\(\)

```csharp
public CMsgPredictionRankings()
```

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings__ctor_Divine_Protobufs_Dota2_CMsgPredictionRankings_"></a> CMsgPredictionRankings\(CMsgPredictionRankings\)

```csharp
public CMsgPredictionRankings(CMsgPredictionRankings other)
```

#### Parameters

`other` [CMsgPredictionRankings](Divine.Protobufs.Dota2.CMsgPredictionRankings.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_PredictionsFieldNumber"></a> PredictionsFieldNumber

```csharp
public const int PredictionsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPredictionRankings> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPredictionRankings](Divine.Protobufs.Dota2.CMsgPredictionRankings.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Predictions"></a> Predictions

```csharp
public RepeatedField<CMsgPredictionRankings.Types.Prediction> Predictions { get; }
```

#### Property Value

 RepeatedField<[CMsgPredictionRankings](Divine.Protobufs.Dota2.CMsgPredictionRankings.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.Prediction.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Clone"></a> Clone\(\)

```csharp
public CMsgPredictionRankings Clone()
```

#### Returns

 [CMsgPredictionRankings](Divine.Protobufs.Dota2.CMsgPredictionRankings.md)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Equals_Divine_Protobufs_Dota2_CMsgPredictionRankings_"></a> Equals\(CMsgPredictionRankings\)

```csharp
public bool Equals(CMsgPredictionRankings other)
```

#### Parameters

`other` [CMsgPredictionRankings](Divine.Protobufs.Dota2.CMsgPredictionRankings.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_MergeFrom_Divine_Protobufs_Dota2_CMsgPredictionRankings_"></a> MergeFrom\(CMsgPredictionRankings\)

```csharp
public void MergeFrom(CMsgPredictionRankings other)
```

#### Parameters

`other` [CMsgPredictionRankings](Divine.Protobufs.Dota2.CMsgPredictionRankings.md)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

