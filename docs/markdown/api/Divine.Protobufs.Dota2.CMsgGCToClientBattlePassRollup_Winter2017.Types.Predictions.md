# <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions"></a> Class CMsgGCToClientBattlePassRollup\_Winter2017.Types.Predictions

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientBattlePassRollup_Winter2017.Types.Predictions : IMessage<CMsgGCToClientBattlePassRollup_Winter2017.Types.Predictions>, IEquatable<CMsgGCToClientBattlePassRollup_Winter2017.Types.Predictions>, IDeepCloneable<CMsgGCToClientBattlePassRollup_Winter2017.Types.Predictions>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientBattlePassRollup\_Winter2017.Types.Predictions](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.Predictions.md)

#### Implements

IMessage<CMsgGCToClientBattlePassRollup\_Winter2017.Types.Predictions\>, 
[IEquatable<CMsgGCToClientBattlePassRollup\_Winter2017.Types.Predictions\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientBattlePassRollup\_Winter2017.Types.Predictions\>, 
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
[EnumerableExtensions.In<CMsgGCToClientBattlePassRollup\_Winter2017.Types.Predictions\>\(CMsgGCToClientBattlePassRollup\_Winter2017.Types.Predictions, params CMsgGCToClientBattlePassRollup\_Winter2017.Types.Predictions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions__ctor"></a> Predictions\(\)

```csharp
public Predictions()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions__ctor_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_"></a> Predictions\(Predictions\)

```csharp
public Predictions(CMsgGCToClientBattlePassRollup_Winter2017.Types.Predictions other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_Winter2017](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.md).[Predictions](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.Predictions.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_CorrectFieldNumber"></a> CorrectFieldNumber

```csharp
public const int CorrectFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_PointsFieldNumber"></a> PointsFieldNumber

```csharp
public const int PointsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_TotalFieldNumber"></a> TotalFieldNumber

```csharp
public const int TotalFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_Correct"></a> Correct

```csharp
public uint Correct { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_HasCorrect"></a> HasCorrect

```csharp
public bool HasCorrect { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_HasPoints"></a> HasPoints

```csharp
public bool HasPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_HasTotal"></a> HasTotal

```csharp
public bool HasTotal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientBattlePassRollup_Winter2017.Types.Predictions> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientBattlePassRollup\_Winter2017](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.md).[Predictions](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.Predictions.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_Points"></a> Points

```csharp
public uint Points { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_Total"></a> Total

```csharp
public uint Total { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_ClearCorrect"></a> ClearCorrect\(\)

```csharp
public void ClearCorrect()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_ClearPoints"></a> ClearPoints\(\)

```csharp
public void ClearPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_ClearTotal"></a> ClearTotal\(\)

```csharp
public void ClearTotal()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientBattlePassRollup_Winter2017.Types.Predictions Clone()
```

#### Returns

 [CMsgGCToClientBattlePassRollup\_Winter2017](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.md).[Predictions](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.Predictions.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_Equals_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_"></a> Equals\(Predictions\)

```csharp
public bool Equals(CMsgGCToClientBattlePassRollup_Winter2017.Types.Predictions other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_Winter2017](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.md).[Predictions](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.Predictions.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_"></a> MergeFrom\(Predictions\)

```csharp
public void MergeFrom(CMsgGCToClientBattlePassRollup_Winter2017.Types.Predictions other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_Winter2017](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.md).[Predictions](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.Types.Predictions.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Winter2017_Types_Predictions_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

