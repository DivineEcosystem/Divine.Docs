# <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction"></a> Class CDotaMsg\_PredictionResult.Types.Prediction

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDotaMsg_PredictionResult.Types.Prediction : IMessage<CDotaMsg_PredictionResult.Types.Prediction>, IEquatable<CDotaMsg_PredictionResult.Types.Prediction>, IDeepCloneable<CDotaMsg_PredictionResult.Types.Prediction>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDotaMsg\_PredictionResult.Types.Prediction](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.Types.Prediction.md)

#### Implements

IMessage<CDotaMsg\_PredictionResult.Types.Prediction\>, 
[IEquatable<CDotaMsg\_PredictionResult.Types.Prediction\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDotaMsg\_PredictionResult.Types.Prediction\>, 
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
[EnumerableExtensions.In<CDotaMsg\_PredictionResult.Types.Prediction\>\(CDotaMsg\_PredictionResult.Types.Prediction, params CDotaMsg\_PredictionResult.Types.Prediction\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction__ctor"></a> Prediction\(\)

```csharp
public Prediction()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction__ctor_Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_"></a> Prediction\(Prediction\)

```csharp
public Prediction(CDotaMsg_PredictionResult.Types.Prediction other)
```

#### Parameters

`other` [CDotaMsg\_PredictionResult](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.md).[Types](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.Types.md).[Prediction](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.Types.Prediction.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_GrantedItemDefsFieldNumber"></a> GrantedItemDefsFieldNumber

```csharp
public const int GrantedItemDefsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_ItemDefFieldNumber"></a> ItemDefFieldNumber

```csharp
public const int ItemDefFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_NumCorrectFieldNumber"></a> NumCorrectFieldNumber

```csharp
public const int NumCorrectFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_NumFailsFieldNumber"></a> NumFailsFieldNumber

```csharp
public const int NumFailsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_GrantedItemDefs"></a> GrantedItemDefs

```csharp
public RepeatedField<uint> GrantedItemDefs { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_HasItemDef"></a> HasItemDef

```csharp
public bool HasItemDef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_HasNumCorrect"></a> HasNumCorrect

```csharp
public bool HasNumCorrect { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_HasNumFails"></a> HasNumFails

```csharp
public bool HasNumFails { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_ItemDef"></a> ItemDef

```csharp
public uint ItemDef { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_NumCorrect"></a> NumCorrect

```csharp
public uint NumCorrect { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_NumFails"></a> NumFails

```csharp
public uint NumFails { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_Parser"></a> Parser

```csharp
public static MessageParser<CDotaMsg_PredictionResult.Types.Prediction> Parser { get; }
```

#### Property Value

 MessageParser<[CDotaMsg\_PredictionResult](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.md).[Types](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.Types.md).[Prediction](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.Types.Prediction.md)\>

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_Result"></a> Result

```csharp
public CDotaMsg_PredictionResult.Types.Prediction.Types.EResult Result { get; set; }
```

#### Property Value

 [CDotaMsg\_PredictionResult](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.md).[Types](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.Types.md).[Prediction](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.Types.Prediction.md).[Types](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.Types.Prediction.Types.md).[EResult](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.Types.Prediction.Types.EResult.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_ClearItemDef"></a> ClearItemDef\(\)

```csharp
public void ClearItemDef()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_ClearNumCorrect"></a> ClearNumCorrect\(\)

```csharp
public void ClearNumCorrect()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_ClearNumFails"></a> ClearNumFails\(\)

```csharp
public void ClearNumFails()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_Clone"></a> Clone\(\)

```csharp
public CDotaMsg_PredictionResult.Types.Prediction Clone()
```

#### Returns

 [CDotaMsg\_PredictionResult](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.md).[Types](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.Types.md).[Prediction](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.Types.Prediction.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_Equals_Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_"></a> Equals\(Prediction\)

```csharp
public bool Equals(CDotaMsg_PredictionResult.Types.Prediction other)
```

#### Parameters

`other` [CDotaMsg\_PredictionResult](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.md).[Types](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.Types.md).[Prediction](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.Types.Prediction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_MergeFrom_Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_"></a> MergeFrom\(Prediction\)

```csharp
public void MergeFrom(CDotaMsg_PredictionResult.Types.Prediction other)
```

#### Parameters

`other` [CDotaMsg\_PredictionResult](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.md).[Types](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.Types.md).[Prediction](Divine.Protobufs.Dota2.CDotaMsg\_PredictionResult.Types.Prediction.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsg_PredictionResult_Types_Prediction_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

