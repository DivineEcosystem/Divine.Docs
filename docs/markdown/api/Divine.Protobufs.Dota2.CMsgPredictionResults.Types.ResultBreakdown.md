# <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown"></a> Class CMsgPredictionResults.Types.ResultBreakdown

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPredictionResults.Types.ResultBreakdown : IMessage<CMsgPredictionResults.Types.ResultBreakdown>, IEquatable<CMsgPredictionResults.Types.ResultBreakdown>, IDeepCloneable<CMsgPredictionResults.Types.ResultBreakdown>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPredictionResults.Types.ResultBreakdown](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.ResultBreakdown.md)

#### Implements

IMessage<CMsgPredictionResults.Types.ResultBreakdown\>, 
[IEquatable<CMsgPredictionResults.Types.ResultBreakdown\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPredictionResults.Types.ResultBreakdown\>, 
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
[EnumerableExtensions.In<CMsgPredictionResults.Types.ResultBreakdown\>\(CMsgPredictionResults.Types.ResultBreakdown, params CMsgPredictionResults.Types.ResultBreakdown\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown__ctor"></a> ResultBreakdown\(\)

```csharp
public ResultBreakdown()
```

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown__ctor_Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_"></a> ResultBreakdown\(ResultBreakdown\)

```csharp
public ResultBreakdown(CMsgPredictionResults.Types.ResultBreakdown other)
```

#### Parameters

`other` [CMsgPredictionResults](Divine.Protobufs.Dota2.CMsgPredictionResults.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.md).[ResultBreakdown](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.ResultBreakdown.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_AnswerSelectionFieldNumber"></a> AnswerSelectionFieldNumber

```csharp
public const int AnswerSelectionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_AnswerValueFieldNumber"></a> AnswerValueFieldNumber

```csharp
public const int AnswerValueFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_AnswerSelection"></a> AnswerSelection

```csharp
public uint AnswerSelection { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_AnswerValue"></a> AnswerValue

```csharp
public float AnswerValue { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_HasAnswerSelection"></a> HasAnswerSelection

```csharp
public bool HasAnswerSelection { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_HasAnswerValue"></a> HasAnswerValue

```csharp
public bool HasAnswerValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPredictionResults.Types.ResultBreakdown> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPredictionResults](Divine.Protobufs.Dota2.CMsgPredictionResults.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.md).[ResultBreakdown](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.ResultBreakdown.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_ClearAnswerSelection"></a> ClearAnswerSelection\(\)

```csharp
public void ClearAnswerSelection()
```

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_ClearAnswerValue"></a> ClearAnswerValue\(\)

```csharp
public void ClearAnswerValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_Clone"></a> Clone\(\)

```csharp
public CMsgPredictionResults.Types.ResultBreakdown Clone()
```

#### Returns

 [CMsgPredictionResults](Divine.Protobufs.Dota2.CMsgPredictionResults.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.md).[ResultBreakdown](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.ResultBreakdown.md)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_Equals_Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_"></a> Equals\(ResultBreakdown\)

```csharp
public bool Equals(CMsgPredictionResults.Types.ResultBreakdown other)
```

#### Parameters

`other` [CMsgPredictionResults](Divine.Protobufs.Dota2.CMsgPredictionResults.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.md).[ResultBreakdown](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.ResultBreakdown.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_MergeFrom_Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_"></a> MergeFrom\(ResultBreakdown\)

```csharp
public void MergeFrom(CMsgPredictionResults.Types.ResultBreakdown other)
```

#### Parameters

`other` [CMsgPredictionResults](Divine.Protobufs.Dota2.CMsgPredictionResults.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.md).[ResultBreakdown](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.ResultBreakdown.md)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_ResultBreakdown_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

