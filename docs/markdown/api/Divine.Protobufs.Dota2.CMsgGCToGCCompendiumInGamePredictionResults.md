# <a id="Divine_Protobufs_Dota2_CMsgGCToGCCompendiumInGamePredictionResults"></a> Class CMsgGCToGCCompendiumInGamePredictionResults

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCCompendiumInGamePredictionResults : IMessage<CMsgGCToGCCompendiumInGamePredictionResults>, IEquatable<CMsgGCToGCCompendiumInGamePredictionResults>, IDeepCloneable<CMsgGCToGCCompendiumInGamePredictionResults>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCCompendiumInGamePredictionResults](Divine.Protobufs.Dota2.CMsgGCToGCCompendiumInGamePredictionResults.md)

#### Implements

IMessage<CMsgGCToGCCompendiumInGamePredictionResults\>, 
[IEquatable<CMsgGCToGCCompendiumInGamePredictionResults\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCCompendiumInGamePredictionResults\>, 
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
[EnumerableExtensions.In<CMsgGCToGCCompendiumInGamePredictionResults\>\(CMsgGCToGCCompendiumInGamePredictionResults, params CMsgGCToGCCompendiumInGamePredictionResults\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCompendiumInGamePredictionResults__ctor"></a> CMsgGCToGCCompendiumInGamePredictionResults\(\)

```csharp
public CMsgGCToGCCompendiumInGamePredictionResults()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCompendiumInGamePredictionResults__ctor_Divine_Protobufs_Dota2_CMsgGCToGCCompendiumInGamePredictionResults_"></a> CMsgGCToGCCompendiumInGamePredictionResults\(CMsgGCToGCCompendiumInGamePredictionResults\)

```csharp
public CMsgGCToGCCompendiumInGamePredictionResults(CMsgGCToGCCompendiumInGamePredictionResults other)
```

#### Parameters

`other` [CMsgGCToGCCompendiumInGamePredictionResults](Divine.Protobufs.Dota2.CMsgGCToGCCompendiumInGamePredictionResults.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCompendiumInGamePredictionResults_ResultsFieldNumber"></a> ResultsFieldNumber

```csharp
public const int ResultsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCompendiumInGamePredictionResults_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCompendiumInGamePredictionResults_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCCompendiumInGamePredictionResults> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCCompendiumInGamePredictionResults](Divine.Protobufs.Dota2.CMsgGCToGCCompendiumInGamePredictionResults.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCompendiumInGamePredictionResults_Results"></a> Results

```csharp
public CMsgServerToGCCompendiumInGamePredictionResults Results { get; set; }
```

#### Property Value

 [CMsgServerToGCCompendiumInGamePredictionResults](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCompendiumInGamePredictionResults_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCompendiumInGamePredictionResults_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCCompendiumInGamePredictionResults Clone()
```

#### Returns

 [CMsgGCToGCCompendiumInGamePredictionResults](Divine.Protobufs.Dota2.CMsgGCToGCCompendiumInGamePredictionResults.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCompendiumInGamePredictionResults_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCompendiumInGamePredictionResults_Equals_Divine_Protobufs_Dota2_CMsgGCToGCCompendiumInGamePredictionResults_"></a> Equals\(CMsgGCToGCCompendiumInGamePredictionResults\)

```csharp
public bool Equals(CMsgGCToGCCompendiumInGamePredictionResults other)
```

#### Parameters

`other` [CMsgGCToGCCompendiumInGamePredictionResults](Divine.Protobufs.Dota2.CMsgGCToGCCompendiumInGamePredictionResults.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCompendiumInGamePredictionResults_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCompendiumInGamePredictionResults_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCCompendiumInGamePredictionResults_"></a> MergeFrom\(CMsgGCToGCCompendiumInGamePredictionResults\)

```csharp
public void MergeFrom(CMsgGCToGCCompendiumInGamePredictionResults other)
```

#### Parameters

`other` [CMsgGCToGCCompendiumInGamePredictionResults](Divine.Protobufs.Dota2.CMsgGCToGCCompendiumInGamePredictionResults.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCompendiumInGamePredictionResults_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCompendiumInGamePredictionResults_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCompendiumInGamePredictionResults_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

