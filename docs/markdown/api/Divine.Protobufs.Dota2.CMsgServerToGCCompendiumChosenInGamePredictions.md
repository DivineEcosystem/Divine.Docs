# <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions"></a> Class CMsgServerToGCCompendiumChosenInGamePredictions

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCCompendiumChosenInGamePredictions : IMessage<CMsgServerToGCCompendiumChosenInGamePredictions>, IEquatable<CMsgServerToGCCompendiumChosenInGamePredictions>, IDeepCloneable<CMsgServerToGCCompendiumChosenInGamePredictions>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCCompendiumChosenInGamePredictions](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.md)

#### Implements

IMessage<CMsgServerToGCCompendiumChosenInGamePredictions\>, 
[IEquatable<CMsgServerToGCCompendiumChosenInGamePredictions\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCCompendiumChosenInGamePredictions\>, 
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
[EnumerableExtensions.In<CMsgServerToGCCompendiumChosenInGamePredictions\>\(CMsgServerToGCCompendiumChosenInGamePredictions, params CMsgServerToGCCompendiumChosenInGamePredictions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions__ctor"></a> CMsgServerToGCCompendiumChosenInGamePredictions\(\)

```csharp
public CMsgServerToGCCompendiumChosenInGamePredictions()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions__ctor_Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_"></a> CMsgServerToGCCompendiumChosenInGamePredictions\(CMsgServerToGCCompendiumChosenInGamePredictions\)

```csharp
public CMsgServerToGCCompendiumChosenInGamePredictions(CMsgServerToGCCompendiumChosenInGamePredictions other)
```

#### Parameters

`other` [CMsgServerToGCCompendiumChosenInGamePredictions](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_PredictionsChosenFieldNumber"></a> PredictionsChosenFieldNumber

```csharp
public const int PredictionsChosenFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCCompendiumChosenInGamePredictions> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCCompendiumChosenInGamePredictions](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_PredictionsChosen"></a> PredictionsChosen

```csharp
public RepeatedField<CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction> PredictionsChosen { get; }
```

#### Property Value

 RepeatedField<[CMsgServerToGCCompendiumChosenInGamePredictions](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.Types.md).[Prediction](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.Types.Prediction.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCCompendiumChosenInGamePredictions Clone()
```

#### Returns

 [CMsgServerToGCCompendiumChosenInGamePredictions](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_Equals_Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_"></a> Equals\(CMsgServerToGCCompendiumChosenInGamePredictions\)

```csharp
public bool Equals(CMsgServerToGCCompendiumChosenInGamePredictions other)
```

#### Parameters

`other` [CMsgServerToGCCompendiumChosenInGamePredictions](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_"></a> MergeFrom\(CMsgServerToGCCompendiumChosenInGamePredictions\)

```csharp
public void MergeFrom(CMsgServerToGCCompendiumChosenInGamePredictions other)
```

#### Parameters

`other` [CMsgServerToGCCompendiumChosenInGamePredictions](Divine.Protobufs.Dota2.CMsgServerToGCCompendiumChosenInGamePredictions.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCompendiumChosenInGamePredictions_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

