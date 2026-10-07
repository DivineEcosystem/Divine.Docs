# <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult"></a> Class CMsgDraftTrivia.Types.PreviousResult

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDraftTrivia.Types.PreviousResult : IMessage<CMsgDraftTrivia.Types.PreviousResult>, IEquatable<CMsgDraftTrivia.Types.PreviousResult>, IDeepCloneable<CMsgDraftTrivia.Types.PreviousResult>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDraftTrivia.Types.PreviousResult](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.PreviousResult.md)

#### Implements

IMessage<CMsgDraftTrivia.Types.PreviousResult\>, 
[IEquatable<CMsgDraftTrivia.Types.PreviousResult\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDraftTrivia.Types.PreviousResult\>, 
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
[EnumerableExtensions.In<CMsgDraftTrivia.Types.PreviousResult\>\(CMsgDraftTrivia.Types.PreviousResult, params CMsgDraftTrivia.Types.PreviousResult\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult__ctor"></a> PreviousResult\(\)

```csharp
public PreviousResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult__ctor_Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_"></a> PreviousResult\(PreviousResult\)

```csharp
public PreviousResult(CMsgDraftTrivia.Types.PreviousResult other)
```

#### Parameters

`other` [CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[PreviousResult](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.PreviousResult.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_EndTimeFieldNumber"></a> EndTimeFieldNumber

```csharp
public const int EndTimeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_MatchHeroInfoFieldNumber"></a> MatchHeroInfoFieldNumber

```csharp
public const int MatchHeroInfoFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_MatchRankTierFieldNumber"></a> MatchRankTierFieldNumber

```csharp
public const int MatchRankTierFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_VotedCorrectlyFieldNumber"></a> VotedCorrectlyFieldNumber

```csharp
public const int VotedCorrectlyFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_VotedRadiantFieldNumber"></a> VotedRadiantFieldNumber

```csharp
public const int VotedRadiantFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_EndTime"></a> EndTime

```csharp
public uint EndTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_HasEndTime"></a> HasEndTime

```csharp
public bool HasEndTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_HasMatchRankTier"></a> HasMatchRankTier

```csharp
public bool HasMatchRankTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_HasVotedCorrectly"></a> HasVotedCorrectly

```csharp
public bool HasVotedCorrectly { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_HasVotedRadiant"></a> HasVotedRadiant

```csharp
public bool HasVotedRadiant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_MatchHeroInfo"></a> MatchHeroInfo

```csharp
public CMsgDraftTrivia.Types.DraftTriviaMatchInfo MatchHeroInfo { get; set; }
```

#### Property Value

 [CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[DraftTriviaMatchInfo](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.DraftTriviaMatchInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_MatchRankTier"></a> MatchRankTier

```csharp
public uint MatchRankTier { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDraftTrivia.Types.PreviousResult> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[PreviousResult](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.PreviousResult.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_VotedCorrectly"></a> VotedCorrectly

```csharp
public bool VotedCorrectly { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_VotedRadiant"></a> VotedRadiant

```csharp
public bool VotedRadiant { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_ClearEndTime"></a> ClearEndTime\(\)

```csharp
public void ClearEndTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_ClearMatchRankTier"></a> ClearMatchRankTier\(\)

```csharp
public void ClearMatchRankTier()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_ClearVotedCorrectly"></a> ClearVotedCorrectly\(\)

```csharp
public void ClearVotedCorrectly()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_ClearVotedRadiant"></a> ClearVotedRadiant\(\)

```csharp
public void ClearVotedRadiant()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_Clone"></a> Clone\(\)

```csharp
public CMsgDraftTrivia.Types.PreviousResult Clone()
```

#### Returns

 [CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[PreviousResult](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.PreviousResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_Equals_Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_"></a> Equals\(PreviousResult\)

```csharp
public bool Equals(CMsgDraftTrivia.Types.PreviousResult other)
```

#### Parameters

`other` [CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[PreviousResult](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.PreviousResult.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_MergeFrom_Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_"></a> MergeFrom\(PreviousResult\)

```csharp
public void MergeFrom(CMsgDraftTrivia.Types.PreviousResult other)
```

#### Parameters

`other` [CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[PreviousResult](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.PreviousResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_PreviousResult_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

