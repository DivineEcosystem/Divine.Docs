# <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction"></a> Class CMsgAvailablePredictions.Types.MatchPrediction

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAvailablePredictions.Types.MatchPrediction : IMessage<CMsgAvailablePredictions.Types.MatchPrediction>, IEquatable<CMsgAvailablePredictions.Types.MatchPrediction>, IDeepCloneable<CMsgAvailablePredictions.Types.MatchPrediction>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAvailablePredictions.Types.MatchPrediction](Divine.Protobufs.Dota2.CMsgAvailablePredictions.Types.MatchPrediction.md)

#### Implements

IMessage<CMsgAvailablePredictions.Types.MatchPrediction\>, 
[IEquatable<CMsgAvailablePredictions.Types.MatchPrediction\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAvailablePredictions.Types.MatchPrediction\>, 
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
[EnumerableExtensions.In<CMsgAvailablePredictions.Types.MatchPrediction\>\(CMsgAvailablePredictions.Types.MatchPrediction, params CMsgAvailablePredictions.Types.MatchPrediction\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction__ctor"></a> MatchPrediction\(\)

```csharp
public MatchPrediction()
```

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction__ctor_Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_"></a> MatchPrediction\(MatchPrediction\)

```csharp
public MatchPrediction(CMsgAvailablePredictions.Types.MatchPrediction other)
```

#### Parameters

`other` [CMsgAvailablePredictions](Divine.Protobufs.Dota2.CMsgAvailablePredictions.md).[Types](Divine.Protobufs.Dota2.CMsgAvailablePredictions.Types.md).[MatchPrediction](Divine.Protobufs.Dota2.CMsgAvailablePredictions.Types.MatchPrediction.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_PredictionsFieldNumber"></a> PredictionsFieldNumber

```csharp
public const int PredictionsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAvailablePredictions.Types.MatchPrediction> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAvailablePredictions](Divine.Protobufs.Dota2.CMsgAvailablePredictions.md).[Types](Divine.Protobufs.Dota2.CMsgAvailablePredictions.Types.md).[MatchPrediction](Divine.Protobufs.Dota2.CMsgAvailablePredictions.Types.MatchPrediction.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_Predictions"></a> Predictions

```csharp
public RepeatedField<CMsgInGamePrediction> Predictions { get; }
```

#### Property Value

 RepeatedField<[CMsgInGamePrediction](Divine.Protobufs.Dota2.CMsgInGamePrediction.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_Clone"></a> Clone\(\)

```csharp
public CMsgAvailablePredictions.Types.MatchPrediction Clone()
```

#### Returns

 [CMsgAvailablePredictions](Divine.Protobufs.Dota2.CMsgAvailablePredictions.md).[Types](Divine.Protobufs.Dota2.CMsgAvailablePredictions.Types.md).[MatchPrediction](Divine.Protobufs.Dota2.CMsgAvailablePredictions.Types.MatchPrediction.md)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_Equals_Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_"></a> Equals\(MatchPrediction\)

```csharp
public bool Equals(CMsgAvailablePredictions.Types.MatchPrediction other)
```

#### Parameters

`other` [CMsgAvailablePredictions](Divine.Protobufs.Dota2.CMsgAvailablePredictions.md).[Types](Divine.Protobufs.Dota2.CMsgAvailablePredictions.Types.md).[MatchPrediction](Divine.Protobufs.Dota2.CMsgAvailablePredictions.Types.MatchPrediction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_MergeFrom_Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_"></a> MergeFrom\(MatchPrediction\)

```csharp
public void MergeFrom(CMsgAvailablePredictions.Types.MatchPrediction other)
```

#### Parameters

`other` [CMsgAvailablePredictions](Divine.Protobufs.Dota2.CMsgAvailablePredictions.md).[Types](Divine.Protobufs.Dota2.CMsgAvailablePredictions.Types.md).[MatchPrediction](Divine.Protobufs.Dota2.CMsgAvailablePredictions.Types.MatchPrediction.md)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Types_MatchPrediction_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

