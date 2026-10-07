# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction"></a> Class CMsgClientToGCSelectCompendiumInGamePrediction

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSelectCompendiumInGamePrediction : IMessage<CMsgClientToGCSelectCompendiumInGamePrediction>, IEquatable<CMsgClientToGCSelectCompendiumInGamePrediction>, IDeepCloneable<CMsgClientToGCSelectCompendiumInGamePrediction>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSelectCompendiumInGamePrediction](Divine.Protobufs.Dota2.CMsgClientToGCSelectCompendiumInGamePrediction.md)

#### Implements

IMessage<CMsgClientToGCSelectCompendiumInGamePrediction\>, 
[IEquatable<CMsgClientToGCSelectCompendiumInGamePrediction\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSelectCompendiumInGamePrediction\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSelectCompendiumInGamePrediction\>\(CMsgClientToGCSelectCompendiumInGamePrediction, params CMsgClientToGCSelectCompendiumInGamePrediction\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction__ctor"></a> CMsgClientToGCSelectCompendiumInGamePrediction\(\)

```csharp
public CMsgClientToGCSelectCompendiumInGamePrediction()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_"></a> CMsgClientToGCSelectCompendiumInGamePrediction\(CMsgClientToGCSelectCompendiumInGamePrediction\)

```csharp
public CMsgClientToGCSelectCompendiumInGamePrediction(CMsgClientToGCSelectCompendiumInGamePrediction other)
```

#### Parameters

`other` [CMsgClientToGCSelectCompendiumInGamePrediction](Divine.Protobufs.Dota2.CMsgClientToGCSelectCompendiumInGamePrediction.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_PredictionsFieldNumber"></a> PredictionsFieldNumber

```csharp
public const int PredictionsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSelectCompendiumInGamePrediction> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSelectCompendiumInGamePrediction](Divine.Protobufs.Dota2.CMsgClientToGCSelectCompendiumInGamePrediction.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_Predictions"></a> Predictions

```csharp
public RepeatedField<CMsgClientToGCSelectCompendiumInGamePrediction.Types.Prediction> Predictions { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCSelectCompendiumInGamePrediction](Divine.Protobufs.Dota2.CMsgClientToGCSelectCompendiumInGamePrediction.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCSelectCompendiumInGamePrediction.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgClientToGCSelectCompendiumInGamePrediction.Types.Prediction.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSelectCompendiumInGamePrediction Clone()
```

#### Returns

 [CMsgClientToGCSelectCompendiumInGamePrediction](Divine.Protobufs.Dota2.CMsgClientToGCSelectCompendiumInGamePrediction.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_"></a> Equals\(CMsgClientToGCSelectCompendiumInGamePrediction\)

```csharp
public bool Equals(CMsgClientToGCSelectCompendiumInGamePrediction other)
```

#### Parameters

`other` [CMsgClientToGCSelectCompendiumInGamePrediction](Divine.Protobufs.Dota2.CMsgClientToGCSelectCompendiumInGamePrediction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_"></a> MergeFrom\(CMsgClientToGCSelectCompendiumInGamePrediction\)

```csharp
public void MergeFrom(CMsgClientToGCSelectCompendiumInGamePrediction other)
```

#### Parameters

`other` [CMsgClientToGCSelectCompendiumInGamePrediction](Divine.Protobufs.Dota2.CMsgClientToGCSelectCompendiumInGamePrediction.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePrediction_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

