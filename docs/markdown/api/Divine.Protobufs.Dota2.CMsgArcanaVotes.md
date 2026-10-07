# <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes"></a> Class CMsgArcanaVotes

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgArcanaVotes : IMessage<CMsgArcanaVotes>, IEquatable<CMsgArcanaVotes>, IDeepCloneable<CMsgArcanaVotes>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgArcanaVotes](Divine.Protobufs.Dota2.CMsgArcanaVotes.md)

#### Implements

IMessage<CMsgArcanaVotes\>, 
[IEquatable<CMsgArcanaVotes\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgArcanaVotes\>, 
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
[EnumerableExtensions.In<CMsgArcanaVotes\>\(CMsgArcanaVotes, params CMsgArcanaVotes\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes__ctor"></a> CMsgArcanaVotes\(\)

```csharp
public CMsgArcanaVotes()
```

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes__ctor_Divine_Protobufs_Dota2_CMsgArcanaVotes_"></a> CMsgArcanaVotes\(CMsgArcanaVotes\)

```csharp
public CMsgArcanaVotes(CMsgArcanaVotes other)
```

#### Parameters

`other` [CMsgArcanaVotes](Divine.Protobufs.Dota2.CMsgArcanaVotes.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_ClosestActiveMatchIdFieldNumber"></a> ClosestActiveMatchIdFieldNumber

```csharp
public const int ClosestActiveMatchIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_IsCurrentRoundCalibratingFieldNumber"></a> IsCurrentRoundCalibratingFieldNumber

```csharp
public const int IsCurrentRoundCalibratingFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_MatchesFieldNumber"></a> MatchesFieldNumber

```csharp
public const int MatchesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_RoundNumberFieldNumber"></a> RoundNumberFieldNumber

```csharp
public const int RoundNumberFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_RoundTimeRemainingFieldNumber"></a> RoundTimeRemainingFieldNumber

```csharp
public const int RoundTimeRemainingFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_VotingStartTimeFieldNumber"></a> VotingStartTimeFieldNumber

```csharp
public const int VotingStartTimeFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_VotingStateFieldNumber"></a> VotingStateFieldNumber

```csharp
public const int VotingStateFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_ClosestActiveMatchId"></a> ClosestActiveMatchId

```csharp
public uint ClosestActiveMatchId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_HasClosestActiveMatchId"></a> HasClosestActiveMatchId

```csharp
public bool HasClosestActiveMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_HasIsCurrentRoundCalibrating"></a> HasIsCurrentRoundCalibrating

```csharp
public bool HasIsCurrentRoundCalibrating { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_HasRoundNumber"></a> HasRoundNumber

```csharp
public bool HasRoundNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_HasRoundTimeRemaining"></a> HasRoundTimeRemaining

```csharp
public bool HasRoundTimeRemaining { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_HasVotingStartTime"></a> HasVotingStartTime

```csharp
public bool HasVotingStartTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_HasVotingState"></a> HasVotingState

```csharp
public bool HasVotingState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_IsCurrentRoundCalibrating"></a> IsCurrentRoundCalibrating

```csharp
public bool IsCurrentRoundCalibrating { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_Matches"></a> Matches

```csharp
public RepeatedField<CMsgArcanaVotes.Types.Match> Matches { get; }
```

#### Property Value

 RepeatedField<[CMsgArcanaVotes](Divine.Protobufs.Dota2.CMsgArcanaVotes.md).[Types](Divine.Protobufs.Dota2.CMsgArcanaVotes.Types.md).[Match](Divine.Protobufs.Dota2.CMsgArcanaVotes.Types.Match.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_Parser"></a> Parser

```csharp
public static MessageParser<CMsgArcanaVotes> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgArcanaVotes](Divine.Protobufs.Dota2.CMsgArcanaVotes.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_RoundNumber"></a> RoundNumber

```csharp
public uint RoundNumber { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_RoundTimeRemaining"></a> RoundTimeRemaining

```csharp
public uint RoundTimeRemaining { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_VotingStartTime"></a> VotingStartTime

```csharp
public uint VotingStartTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_VotingState"></a> VotingState

```csharp
public uint VotingState { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_ClearClosestActiveMatchId"></a> ClearClosestActiveMatchId\(\)

```csharp
public void ClearClosestActiveMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_ClearIsCurrentRoundCalibrating"></a> ClearIsCurrentRoundCalibrating\(\)

```csharp
public void ClearIsCurrentRoundCalibrating()
```

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_ClearRoundNumber"></a> ClearRoundNumber\(\)

```csharp
public void ClearRoundNumber()
```

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_ClearRoundTimeRemaining"></a> ClearRoundTimeRemaining\(\)

```csharp
public void ClearRoundTimeRemaining()
```

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_ClearVotingStartTime"></a> ClearVotingStartTime\(\)

```csharp
public void ClearVotingStartTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_ClearVotingState"></a> ClearVotingState\(\)

```csharp
public void ClearVotingState()
```

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_Clone"></a> Clone\(\)

```csharp
public CMsgArcanaVotes Clone()
```

#### Returns

 [CMsgArcanaVotes](Divine.Protobufs.Dota2.CMsgArcanaVotes.md)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_Equals_Divine_Protobufs_Dota2_CMsgArcanaVotes_"></a> Equals\(CMsgArcanaVotes\)

```csharp
public bool Equals(CMsgArcanaVotes other)
```

#### Parameters

`other` [CMsgArcanaVotes](Divine.Protobufs.Dota2.CMsgArcanaVotes.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_MergeFrom_Divine_Protobufs_Dota2_CMsgArcanaVotes_"></a> MergeFrom\(CMsgArcanaVotes\)

```csharp
public void MergeFrom(CMsgArcanaVotes other)
```

#### Parameters

`other` [CMsgArcanaVotes](Divine.Protobufs.Dota2.CMsgArcanaVotes.md)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVotes_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

