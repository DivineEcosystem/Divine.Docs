# <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions"></a> Class CMsgAvailablePredictions

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAvailablePredictions : IMessage<CMsgAvailablePredictions>, IEquatable<CMsgAvailablePredictions>, IDeepCloneable<CMsgAvailablePredictions>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAvailablePredictions](Divine.Protobufs.Dota2.CMsgAvailablePredictions.md)

#### Implements

IMessage<CMsgAvailablePredictions\>, 
[IEquatable<CMsgAvailablePredictions\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAvailablePredictions\>, 
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
[EnumerableExtensions.In<CMsgAvailablePredictions\>\(CMsgAvailablePredictions, params CMsgAvailablePredictions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions__ctor"></a> CMsgAvailablePredictions\(\)

```csharp
public CMsgAvailablePredictions()
```

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions__ctor_Divine_Protobufs_Dota2_CMsgAvailablePredictions_"></a> CMsgAvailablePredictions\(CMsgAvailablePredictions\)

```csharp
public CMsgAvailablePredictions(CMsgAvailablePredictions other)
```

#### Parameters

`other` [CMsgAvailablePredictions](Divine.Protobufs.Dota2.CMsgAvailablePredictions.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_MatchPredictionsFieldNumber"></a> MatchPredictionsFieldNumber

```csharp
public const int MatchPredictionsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_MatchPredictions"></a> MatchPredictions

```csharp
public RepeatedField<CMsgAvailablePredictions.Types.MatchPrediction> MatchPredictions { get; }
```

#### Property Value

 RepeatedField<[CMsgAvailablePredictions](Divine.Protobufs.Dota2.CMsgAvailablePredictions.md).[Types](Divine.Protobufs.Dota2.CMsgAvailablePredictions.Types.md).[MatchPrediction](Divine.Protobufs.Dota2.CMsgAvailablePredictions.Types.MatchPrediction.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAvailablePredictions> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAvailablePredictions](Divine.Protobufs.Dota2.CMsgAvailablePredictions.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Clone"></a> Clone\(\)

```csharp
public CMsgAvailablePredictions Clone()
```

#### Returns

 [CMsgAvailablePredictions](Divine.Protobufs.Dota2.CMsgAvailablePredictions.md)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_Equals_Divine_Protobufs_Dota2_CMsgAvailablePredictions_"></a> Equals\(CMsgAvailablePredictions\)

```csharp
public bool Equals(CMsgAvailablePredictions other)
```

#### Parameters

`other` [CMsgAvailablePredictions](Divine.Protobufs.Dota2.CMsgAvailablePredictions.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_MergeFrom_Divine_Protobufs_Dota2_CMsgAvailablePredictions_"></a> MergeFrom\(CMsgAvailablePredictions\)

```csharp
public void MergeFrom(CMsgAvailablePredictions other)
```

#### Parameters

`other` [CMsgAvailablePredictions](Divine.Protobufs.Dota2.CMsgAvailablePredictions.md)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePredictions_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

