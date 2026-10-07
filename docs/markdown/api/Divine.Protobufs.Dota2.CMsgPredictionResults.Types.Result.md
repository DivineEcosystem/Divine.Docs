# <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result"></a> Class CMsgPredictionResults.Types.Result

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPredictionResults.Types.Result : IMessage<CMsgPredictionResults.Types.Result>, IEquatable<CMsgPredictionResults.Types.Result>, IDeepCloneable<CMsgPredictionResults.Types.Result>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPredictionResults.Types.Result](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.Result.md)

#### Implements

IMessage<CMsgPredictionResults.Types.Result\>, 
[IEquatable<CMsgPredictionResults.Types.Result\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPredictionResults.Types.Result\>, 
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
[EnumerableExtensions.In<CMsgPredictionResults.Types.Result\>\(CMsgPredictionResults.Types.Result, params CMsgPredictionResults.Types.Result\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result__ctor"></a> Result\(\)

```csharp
public Result()
```

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result__ctor_Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_"></a> Result\(Result\)

```csharp
public Result(CMsgPredictionResults.Types.Result other)
```

#### Parameters

`other` [CMsgPredictionResults](Divine.Protobufs.Dota2.CMsgPredictionResults.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.md).[Result](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.Result.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_ResultBreakdownFieldNumber"></a> ResultBreakdownFieldNumber

```csharp
public const int ResultBreakdownFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_SelectionIdFieldNumber"></a> SelectionIdFieldNumber

```csharp
public const int SelectionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_HasSelectionId"></a> HasSelectionId

```csharp
public bool HasSelectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPredictionResults.Types.Result> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPredictionResults](Divine.Protobufs.Dota2.CMsgPredictionResults.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.md).[Result](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.Result.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_ResultBreakdown"></a> ResultBreakdown

```csharp
public RepeatedField<CMsgPredictionResults.Types.ResultBreakdown> ResultBreakdown { get; }
```

#### Property Value

 RepeatedField<[CMsgPredictionResults](Divine.Protobufs.Dota2.CMsgPredictionResults.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.md).[ResultBreakdown](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.ResultBreakdown.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_SelectionId"></a> SelectionId

```csharp
public uint SelectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_ClearSelectionId"></a> ClearSelectionId\(\)

```csharp
public void ClearSelectionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_Clone"></a> Clone\(\)

```csharp
public CMsgPredictionResults.Types.Result Clone()
```

#### Returns

 [CMsgPredictionResults](Divine.Protobufs.Dota2.CMsgPredictionResults.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.md).[Result](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.Result.md)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_Equals_Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_"></a> Equals\(Result\)

```csharp
public bool Equals(CMsgPredictionResults.Types.Result other)
```

#### Parameters

`other` [CMsgPredictionResults](Divine.Protobufs.Dota2.CMsgPredictionResults.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.md).[Result](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.Result.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_MergeFrom_Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_"></a> MergeFrom\(Result\)

```csharp
public void MergeFrom(CMsgPredictionResults.Types.Result other)
```

#### Parameters

`other` [CMsgPredictionResults](Divine.Protobufs.Dota2.CMsgPredictionResults.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.md).[Result](Divine.Protobufs.Dota2.CMsgPredictionResults.Types.Result.md)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionResults_Types_Result_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

