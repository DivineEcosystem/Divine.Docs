# <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting"></a> Class CMsgServerToGCCloseCompendiumInGamePredictionVoting

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCCloseCompendiumInGamePredictionVoting : IMessage<CMsgServerToGCCloseCompendiumInGamePredictionVoting>, IEquatable<CMsgServerToGCCloseCompendiumInGamePredictionVoting>, IDeepCloneable<CMsgServerToGCCloseCompendiumInGamePredictionVoting>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCCloseCompendiumInGamePredictionVoting](Divine.Protobufs.Dota2.CMsgServerToGCCloseCompendiumInGamePredictionVoting.md)

#### Implements

IMessage<CMsgServerToGCCloseCompendiumInGamePredictionVoting\>, 
[IEquatable<CMsgServerToGCCloseCompendiumInGamePredictionVoting\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCCloseCompendiumInGamePredictionVoting\>, 
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
[EnumerableExtensions.In<CMsgServerToGCCloseCompendiumInGamePredictionVoting\>\(CMsgServerToGCCloseCompendiumInGamePredictionVoting, params CMsgServerToGCCloseCompendiumInGamePredictionVoting\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting__ctor"></a> CMsgServerToGCCloseCompendiumInGamePredictionVoting\(\)

```csharp
public CMsgServerToGCCloseCompendiumInGamePredictionVoting()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting__ctor_Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_"></a> CMsgServerToGCCloseCompendiumInGamePredictionVoting\(CMsgServerToGCCloseCompendiumInGamePredictionVoting\)

```csharp
public CMsgServerToGCCloseCompendiumInGamePredictionVoting(CMsgServerToGCCloseCompendiumInGamePredictionVoting other)
```

#### Parameters

`other` [CMsgServerToGCCloseCompendiumInGamePredictionVoting](Divine.Protobufs.Dota2.CMsgServerToGCCloseCompendiumInGamePredictionVoting.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_HltvDelayFieldNumber"></a> HltvDelayFieldNumber

```csharp
public const int HltvDelayFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_HasHltvDelay"></a> HasHltvDelay

```csharp
public bool HasHltvDelay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_HltvDelay"></a> HltvDelay

```csharp
public uint HltvDelay { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCCloseCompendiumInGamePredictionVoting> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCCloseCompendiumInGamePredictionVoting](Divine.Protobufs.Dota2.CMsgServerToGCCloseCompendiumInGamePredictionVoting.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_ClearHltvDelay"></a> ClearHltvDelay\(\)

```csharp
public void ClearHltvDelay()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCCloseCompendiumInGamePredictionVoting Clone()
```

#### Returns

 [CMsgServerToGCCloseCompendiumInGamePredictionVoting](Divine.Protobufs.Dota2.CMsgServerToGCCloseCompendiumInGamePredictionVoting.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_Equals_Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_"></a> Equals\(CMsgServerToGCCloseCompendiumInGamePredictionVoting\)

```csharp
public bool Equals(CMsgServerToGCCloseCompendiumInGamePredictionVoting other)
```

#### Parameters

`other` [CMsgServerToGCCloseCompendiumInGamePredictionVoting](Divine.Protobufs.Dota2.CMsgServerToGCCloseCompendiumInGamePredictionVoting.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_"></a> MergeFrom\(CMsgServerToGCCloseCompendiumInGamePredictionVoting\)

```csharp
public void MergeFrom(CMsgServerToGCCloseCompendiumInGamePredictionVoting other)
```

#### Parameters

`other` [CMsgServerToGCCloseCompendiumInGamePredictionVoting](Divine.Protobufs.Dota2.CMsgServerToGCCloseCompendiumInGamePredictionVoting.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCloseCompendiumInGamePredictionVoting_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

