# <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults"></a> Class CMsgServerToGCCompendiumInGamePredictionResults

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCCompendiumInGamePredictionResults : IMessage<CMsgServerToGCCompendiumInGamePredictionResults>, IEquatable<CMsgServerToGCCompendiumInGamePredictionResults>, IDeepCloneable<CMsgServerToGCCompendiumInGamePredictionResults>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCCompendiumInGamePredictionResults](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.md)

#### Implements

IMessage<CMsgServerToGCCompendiumInGamePredictionResults\>, 
[IEquatable<CMsgServerToGCCompendiumInGamePredictionResults\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCCompendiumInGamePredictionResults\>, 
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
[EnumerableExtensions.In<CMsgServerToGCCompendiumInGamePredictionResults\>\(CMsgServerToGCCompendiumInGamePredictionResults, params CMsgServerToGCCompendiumInGamePredictionResults\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults__ctor"></a> CMsgServerToGCCompendiumInGamePredictionResults\(\)

```csharp
public CMsgServerToGCCompendiumInGamePredictionResults()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults__ctor_Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_"></a> CMsgServerToGCCompendiumInGamePredictionResults\(CMsgServerToGCCompendiumInGamePredictionResults\)

```csharp
public CMsgServerToGCCompendiumInGamePredictionResults(CMsgServerToGCCompendiumInGamePredictionResults other)
```

#### Parameters

`other` [CMsgServerToGCCompendiumInGamePredictionResults](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_LeagueNodeIdFieldNumber"></a> LeagueNodeIdFieldNumber

```csharp
public const int LeagueNodeIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_ResultsFieldNumber"></a> ResultsFieldNumber

```csharp
public const int ResultsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_HasLeagueNodeId"></a> HasLeagueNodeId

```csharp
public bool HasLeagueNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_LeagueNodeId"></a> LeagueNodeId

```csharp
public uint LeagueNodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCCompendiumInGamePredictionResults> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCCompendiumInGamePredictionResults](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Results"></a> Results

```csharp
public RepeatedField<CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult> Results { get; }
```

#### Property Value

 RepeatedField<[CMsgServerToGCCompendiumInGamePredictionResults](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.Types.md).[PredictionResult](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.Types.PredictionResult.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_ClearLeagueNodeId"></a> ClearLeagueNodeId\(\)

```csharp
public void ClearLeagueNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCCompendiumInGamePredictionResults Clone()
```

#### Returns

 [CMsgServerToGCCompendiumInGamePredictionResults](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_Equals_Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_"></a> Equals\(CMsgServerToGCCompendiumInGamePredictionResults\)

```csharp
public bool Equals(CMsgServerToGCCompendiumInGamePredictionResults other)
```

#### Parameters

`other` [CMsgServerToGCCompendiumInGamePredictionResults](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_"></a> MergeFrom\(CMsgServerToGCCompendiumInGamePredictionResults\)

```csharp
public void MergeFrom(CMsgServerToGCCompendiumInGamePredictionResults other)
```

#### Parameters

`other` [CMsgServerToGCCompendiumInGamePredictionResults](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumInGamePredictionResults.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumInGamePredictionResults_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

