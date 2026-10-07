# <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia"></a> Class CMsgDraftTrivia

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDraftTrivia : IMessage<CMsgDraftTrivia>, IEquatable<CMsgDraftTrivia>, IDeepCloneable<CMsgDraftTrivia>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md)

#### Implements

IMessage<CMsgDraftTrivia\>, 
[IEquatable<CMsgDraftTrivia\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDraftTrivia\>, 
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
[EnumerableExtensions.In<CMsgDraftTrivia\>\(CMsgDraftTrivia, params CMsgDraftTrivia\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia__ctor"></a> CMsgDraftTrivia\(\)

```csharp
public CMsgDraftTrivia()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia__ctor_Divine_Protobufs_Dota2_CMsgDraftTrivia_"></a> CMsgDraftTrivia\(CMsgDraftTrivia\)

```csharp
public CMsgDraftTrivia(CMsgDraftTrivia other)
```

#### Parameters

`other` [CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_CurrentMatchVotedRadiantFieldNumber"></a> CurrentMatchVotedRadiantFieldNumber

```csharp
public const int CurrentMatchVotedRadiantFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_CurrentStreakFieldNumber"></a> CurrentStreakFieldNumber

```csharp
public const int CurrentStreakFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_EndTimeFieldNumber"></a> EndTimeFieldNumber

```csharp
public const int EndTimeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_HasValidMatchFieldNumber"></a> HasValidMatchFieldNumber

```csharp
public const int HasValidMatchFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_MatchHeroInfoFieldNumber"></a> MatchHeroInfoFieldNumber

```csharp
public const int MatchHeroInfoFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_MatchRankTierFieldNumber"></a> MatchRankTierFieldNumber

```csharp
public const int MatchRankTierFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_PreviousResultFieldNumber"></a> PreviousResultFieldNumber

```csharp
public const int PreviousResultFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_CurrentMatchVotedRadiant"></a> CurrentMatchVotedRadiant

```csharp
public bool CurrentMatchVotedRadiant { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_CurrentStreak"></a> CurrentStreak

```csharp
public uint CurrentStreak { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_EndTime"></a> EndTime

```csharp
public uint EndTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_HasCurrentMatchVotedRadiant"></a> HasCurrentMatchVotedRadiant

```csharp
public bool HasCurrentMatchVotedRadiant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_HasCurrentStreak"></a> HasCurrentStreak

```csharp
public bool HasCurrentStreak { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_HasEndTime"></a> HasEndTime

```csharp
public bool HasEndTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_HasHasValidMatch"></a> HasHasValidMatch

```csharp
public bool HasHasValidMatch { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_HasMatchRankTier"></a> HasMatchRankTier

```csharp
public bool HasMatchRankTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_HasValidMatch"></a> HasValidMatch

```csharp
public bool HasValidMatch { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_MatchHeroInfo"></a> MatchHeroInfo

```csharp
public CMsgDraftTrivia.Types.DraftTriviaMatchInfo MatchHeroInfo { get; set; }
```

#### Property Value

 [CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[DraftTriviaMatchInfo](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.DraftTriviaMatchInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_MatchRankTier"></a> MatchRankTier

```csharp
public uint MatchRankTier { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDraftTrivia> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_PreviousResult"></a> PreviousResult

```csharp
public CMsgDraftTrivia.Types.PreviousResult PreviousResult { get; set; }
```

#### Property Value

 [CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[PreviousResult](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.PreviousResult.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_ClearCurrentMatchVotedRadiant"></a> ClearCurrentMatchVotedRadiant\(\)

```csharp
public void ClearCurrentMatchVotedRadiant()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_ClearCurrentStreak"></a> ClearCurrentStreak\(\)

```csharp
public void ClearCurrentStreak()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_ClearEndTime"></a> ClearEndTime\(\)

```csharp
public void ClearEndTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_ClearHasValidMatch"></a> ClearHasValidMatch\(\)

```csharp
public void ClearHasValidMatch()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_ClearMatchRankTier"></a> ClearMatchRankTier\(\)

```csharp
public void ClearMatchRankTier()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Clone"></a> Clone\(\)

```csharp
public CMsgDraftTrivia Clone()
```

#### Returns

 [CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Equals_Divine_Protobufs_Dota2_CMsgDraftTrivia_"></a> Equals\(CMsgDraftTrivia\)

```csharp
public bool Equals(CMsgDraftTrivia other)
```

#### Parameters

`other` [CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_MergeFrom_Divine_Protobufs_Dota2_CMsgDraftTrivia_"></a> MergeFrom\(CMsgDraftTrivia\)

```csharp
public void MergeFrom(CMsgDraftTrivia other)
```

#### Parameters

`other` [CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

