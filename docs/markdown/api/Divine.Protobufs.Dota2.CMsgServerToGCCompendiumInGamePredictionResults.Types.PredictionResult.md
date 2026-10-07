# <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult"></a> Class CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult : IMessage<CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult>, IEquatable<CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult>, IDeepCloneable<CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult.md)

#### Implements

IMessage<CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult\>, 
[IEquatable<CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult\>, 
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
[EnumerableExtensions.In<CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult\>\(CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult, params CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult__ctor"></a> PredictionResult\(\)

```csharp
public PredictionResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult__ctor_Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_"></a> PredictionResult\(PredictionResult\)

```csharp
public PredictionResult(CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult other)
```

#### Parameters

`other` [CMsgServerToGCCompendiumInGamePredictionResults](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.Types.md).[PredictionResult](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_PredictionIdFieldNumber"></a> PredictionIdFieldNumber

```csharp
public const int PredictionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_PredictionValueFieldNumber"></a> PredictionValueFieldNumber

```csharp
public const int PredictionValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_PredictionValueIsMaskFieldNumber"></a> PredictionValueIsMaskFieldNumber

```csharp
public const int PredictionValueIsMaskFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_HasPredictionId"></a> HasPredictionId

```csharp
public bool HasPredictionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_HasPredictionValue"></a> HasPredictionValue

```csharp
public bool HasPredictionValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_HasPredictionValueIsMask"></a> HasPredictionValueIsMask

```csharp
public bool HasPredictionValueIsMask { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCCompendiumInGamePredictionResults](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.Types.md).[PredictionResult](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_PredictionId"></a> PredictionId

```csharp
public uint PredictionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_PredictionValue"></a> PredictionValue

```csharp
public uint PredictionValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_PredictionValueIsMask"></a> PredictionValueIsMask

```csharp
public bool PredictionValueIsMask { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_ClearPredictionId"></a> ClearPredictionId\(\)

```csharp
public void ClearPredictionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_ClearPredictionValue"></a> ClearPredictionValue\(\)

```csharp
public void ClearPredictionValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_ClearPredictionValueIsMask"></a> ClearPredictionValueIsMask\(\)

```csharp
public void ClearPredictionValueIsMask()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult Clone()
```

#### Returns

 [CMsgServerToGCCompendiumInGamePredictionResults](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.Types.md).[PredictionResult](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_Equals_Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_"></a> Equals\(PredictionResult\)

```csharp
public bool Equals(CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult other)
```

#### Parameters

`other` [CMsgServerToGCCompendiumInGamePredictionResults](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.Types.md).[PredictionResult](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_"></a> MergeFrom\(PredictionResult\)

```csharp
public void MergeFrom(CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult other)
```

#### Parameters

`other` [CMsgServerToGCCompendiumInGamePredictionResults](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.Types.md).[PredictionResult](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Types_PredictionResult_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

