# <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine"></a> Class CMsgPredictionRankings.Types.PredictionLine

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPredictionRankings.Types.PredictionLine : IMessage<CMsgPredictionRankings.Types.PredictionLine>, IEquatable<CMsgPredictionRankings.Types.PredictionLine>, IDeepCloneable<CMsgPredictionRankings.Types.PredictionLine>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPredictionRankings.Types.PredictionLine](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.PredictionLine.md)

#### Implements

IMessage<CMsgPredictionRankings.Types.PredictionLine\>, 
[IEquatable<CMsgPredictionRankings.Types.PredictionLine\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPredictionRankings.Types.PredictionLine\>, 
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
[EnumerableExtensions.In<CMsgPredictionRankings.Types.PredictionLine\>\(CMsgPredictionRankings.Types.PredictionLine, params CMsgPredictionRankings.Types.PredictionLine\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine__ctor"></a> PredictionLine\(\)

```csharp
public PredictionLine()
```

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine__ctor_Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_"></a> PredictionLine\(PredictionLine\)

```csharp
public PredictionLine(CMsgPredictionRankings.Types.PredictionLine other)
```

#### Parameters

`other` [CMsgPredictionRankings](Divine.Protobufs.Dota2.CMsgPredictionRankings.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.md).[PredictionLine](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.PredictionLine.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_AnswerIdFieldNumber"></a> AnswerIdFieldNumber

```csharp
public const int AnswerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_AnswerLogoFieldNumber"></a> AnswerLogoFieldNumber

```csharp
public const int AnswerLogoFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_AnswerNameFieldNumber"></a> AnswerNameFieldNumber

```csharp
public const int AnswerNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_AnswerValueFieldNumber"></a> AnswerValueFieldNumber

```csharp
public const int AnswerValueFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_AnswerId"></a> AnswerId

```csharp
public uint AnswerId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_AnswerLogo"></a> AnswerLogo

```csharp
public ulong AnswerLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_AnswerName"></a> AnswerName

```csharp
public string AnswerName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_AnswerValue"></a> AnswerValue

```csharp
public float AnswerValue { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_HasAnswerId"></a> HasAnswerId

```csharp
public bool HasAnswerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_HasAnswerLogo"></a> HasAnswerLogo

```csharp
public bool HasAnswerLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_HasAnswerName"></a> HasAnswerName

```csharp
public bool HasAnswerName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_HasAnswerValue"></a> HasAnswerValue

```csharp
public bool HasAnswerValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPredictionRankings.Types.PredictionLine> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPredictionRankings](Divine.Protobufs.Dota2.CMsgPredictionRankings.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.md).[PredictionLine](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.PredictionLine.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_ClearAnswerId"></a> ClearAnswerId\(\)

```csharp
public void ClearAnswerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_ClearAnswerLogo"></a> ClearAnswerLogo\(\)

```csharp
public void ClearAnswerLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_ClearAnswerName"></a> ClearAnswerName\(\)

```csharp
public void ClearAnswerName()
```

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_ClearAnswerValue"></a> ClearAnswerValue\(\)

```csharp
public void ClearAnswerValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_Clone"></a> Clone\(\)

```csharp
public CMsgPredictionRankings.Types.PredictionLine Clone()
```

#### Returns

 [CMsgPredictionRankings](Divine.Protobufs.Dota2.CMsgPredictionRankings.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.md).[PredictionLine](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.PredictionLine.md)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_Equals_Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_"></a> Equals\(PredictionLine\)

```csharp
public bool Equals(CMsgPredictionRankings.Types.PredictionLine other)
```

#### Parameters

`other` [CMsgPredictionRankings](Divine.Protobufs.Dota2.CMsgPredictionRankings.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.md).[PredictionLine](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.PredictionLine.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_MergeFrom_Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_"></a> MergeFrom\(PredictionLine\)

```csharp
public void MergeFrom(CMsgPredictionRankings.Types.PredictionLine other)
```

#### Parameters

`other` [CMsgPredictionRankings](Divine.Protobufs.Dota2.CMsgPredictionRankings.md).[Types](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.md).[PredictionLine](Divine.Protobufs.Dota2.CMsgPredictionRankings.Types.PredictionLine.md)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionRankings_Types_PredictionLine_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

