# <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction"></a> Class CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction : IMessage<CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction>, IEquatable<CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction>, IDeepCloneable<CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction.md)

#### Implements

IMessage<CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction\>, 
[IEquatable<CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction\>, 
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
[EnumerableExtensions.In<CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction\>\(CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction, params CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction__ctor"></a> Prediction\(\)

```csharp
public Prediction()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction__ctor_Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction_"></a> Prediction\(Prediction\)

```csharp
public Prediction(CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction other)
```

#### Parameters

`other` [CMsgServerToGCCompendiumChosenInGamePredictions](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction_PredictionIdFieldNumber"></a> PredictionIdFieldNumber

```csharp
public const int PredictionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction_HasPredictionId"></a> HasPredictionId

```csharp
public bool HasPredictionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCCompendiumChosenInGamePredictions](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction_PredictionId"></a> PredictionId

```csharp
public uint PredictionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction_ClearPredictionId"></a> ClearPredictionId\(\)

```csharp
public void ClearPredictionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction Clone()
```

#### Returns

 [CMsgServerToGCCompendiumChosenInGamePredictions](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction_Equals_Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction_"></a> Equals\(Prediction\)

```csharp
public bool Equals(CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction other)
```

#### Parameters

`other` [CMsgServerToGCCompendiumChosenInGamePredictions](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction_"></a> MergeFrom\(Prediction\)

```csharp
public void MergeFrom(CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction other)
```

#### Parameters

`other` [CMsgServerToGCCompendiumChosenInGamePredictions](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Types_Prediction_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

