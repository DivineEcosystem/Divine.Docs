# <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote"></a> Class CMsgDOTAPassportVote

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAPassportVote : IMessage<CMsgDOTAPassportVote>, IEquatable<CMsgDOTAPassportVote>, IDeepCloneable<CMsgDOTAPassportVote>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAPassportVote](Divine.Protobufs.Dota2.CMsgDOTAPassportVote.md)

#### Implements

IMessage<CMsgDOTAPassportVote\>, 
[IEquatable<CMsgDOTAPassportVote\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAPassportVote\>, 
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
[EnumerableExtensions.In<CMsgDOTAPassportVote\>\(CMsgDOTAPassportVote, params CMsgDOTAPassportVote\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote__ctor"></a> CMsgDOTAPassportVote\(\)

```csharp
public CMsgDOTAPassportVote()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote__ctor_Divine_Protobufs_Dota2_CMsgDOTAPassportVote_"></a> CMsgDOTAPassportVote\(CMsgDOTAPassportVote\)

```csharp
public CMsgDOTAPassportVote(CMsgDOTAPassportVote other)
```

#### Parameters

`other` [CMsgDOTAPassportVote](Divine.Protobufs.Dota2.CMsgDOTAPassportVote.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote_GenericSelectionsFieldNumber"></a> GenericSelectionsFieldNumber

```csharp
public const int GenericSelectionsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote_PlayerCardChallengesFieldNumber"></a> PlayerCardChallengesFieldNumber

```csharp
public const int PlayerCardChallengesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote_StampedPlayersFieldNumber"></a> StampedPlayersFieldNumber

```csharp
public const int StampedPlayersFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote_TeamVotesFieldNumber"></a> TeamVotesFieldNumber

```csharp
public const int TeamVotesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote_GenericSelections"></a> GenericSelections

```csharp
public RepeatedField<CMsgDOTAPassportVoteGenericSelection> GenericSelections { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAPassportVoteGenericSelection](Divine.Protobufs.Dota2.CMsgDOTAPassportVoteGenericSelection.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAPassportVote> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAPassportVote](Divine.Protobufs.Dota2.CMsgDOTAPassportVote.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote_PlayerCardChallenges"></a> PlayerCardChallenges

```csharp
public RepeatedField<CMsgDOTAPassportPlayerCardChallenge> PlayerCardChallenges { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAPassportPlayerCardChallenge](Divine.Protobufs.Dota2.CMsgDOTAPassportPlayerCardChallenge.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote_StampedPlayers"></a> StampedPlayers

```csharp
public RepeatedField<CMsgDOTAPassportStampedPlayer> StampedPlayers { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAPassportStampedPlayer](Divine.Protobufs.Dota2.CMsgDOTAPassportStampedPlayer.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote_TeamVotes"></a> TeamVotes

```csharp
public RepeatedField<CMsgDOTAPassportVoteTeamGuess> TeamVotes { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAPassportVoteTeamGuess](Divine.Protobufs.Dota2.CMsgDOTAPassportVoteTeamGuess.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAPassportVote Clone()
```

#### Returns

 [CMsgDOTAPassportVote](Divine.Protobufs.Dota2.CMsgDOTAPassportVote.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote_Equals_Divine_Protobufs_Dota2_CMsgDOTAPassportVote_"></a> Equals\(CMsgDOTAPassportVote\)

```csharp
public bool Equals(CMsgDOTAPassportVote other)
```

#### Parameters

`other` [CMsgDOTAPassportVote](Divine.Protobufs.Dota2.CMsgDOTAPassportVote.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAPassportVote_"></a> MergeFrom\(CMsgDOTAPassportVote\)

```csharp
public void MergeFrom(CMsgDOTAPassportVote other)
```

#### Parameters

`other` [CMsgDOTAPassportVote](Divine.Protobufs.Dota2.CMsgDOTAPassportVote.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportVote_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

