# <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge"></a> Class CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge : IMessage<CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge>, IEquatable<CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge>, IDeepCloneable<CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge](Divine.Protobufs.Dota2.CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge.md)

#### Implements

IMessage<CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge\>, 
[IEquatable<CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge\>, 
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
[EnumerableExtensions.In<CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge\>\(CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge, params CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge__ctor"></a> PlayerChallenge\(\)

```csharp
public PlayerChallenge()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge__ctor_Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_"></a> PlayerChallenge\(PlayerChallenge\)

```csharp
public PlayerChallenge(CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge other)
```

#### Parameters

`other` [CMsgServerToGCPlayerChallengeHistory](Divine.Protobufs.Dota2.CMsgServerToGCPlayerChallengeHistory.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCPlayerChallengeHistory.Types.md).[PlayerChallenge](Divine.Protobufs.Dota2.CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_AuditDataFieldNumber"></a> AuditDataFieldNumber

```csharp
public const int AuditDataFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ChallengeId1FieldNumber"></a> ChallengeId1FieldNumber

```csharp
public const int ChallengeId1FieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ChallengeId2FieldNumber"></a> ChallengeId2FieldNumber

```csharp
public const int ChallengeId2FieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ChallengeTypeFieldNumber"></a> ChallengeTypeFieldNumber

```csharp
public const int ChallengeTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ProgressValueEndFieldNumber"></a> ProgressValueEndFieldNumber

```csharp
public const int ProgressValueEndFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ProgressValueStartFieldNumber"></a> ProgressValueStartFieldNumber

```csharp
public const int ProgressValueStartFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_RankCompletedFieldNumber"></a> RankCompletedFieldNumber

```csharp
public const int RankCompletedFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_TeamWonFieldNumber"></a> TeamWonFieldNumber

```csharp
public const int TeamWonFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_AuditData"></a> AuditData

```csharp
public ulong AuditData { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ChallengeId1"></a> ChallengeId1

```csharp
public uint ChallengeId1 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ChallengeId2"></a> ChallengeId2

```csharp
public uint ChallengeId2 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ChallengeType"></a> ChallengeType

```csharp
public EPlayerChallengeHistoryType ChallengeType { get; set; }
```

#### Property Value

 [EPlayerChallengeHistoryType](Divine.Protobufs.Dota2.EPlayerChallengeHistoryType.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_HasAuditData"></a> HasAuditData

```csharp
public bool HasAuditData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_HasChallengeId1"></a> HasChallengeId1

```csharp
public bool HasChallengeId1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_HasChallengeId2"></a> HasChallengeId2

```csharp
public bool HasChallengeId2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_HasChallengeType"></a> HasChallengeType

```csharp
public bool HasChallengeType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_HasProgressValueEnd"></a> HasProgressValueEnd

```csharp
public bool HasProgressValueEnd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_HasProgressValueStart"></a> HasProgressValueStart

```csharp
public bool HasProgressValueStart { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_HasRankCompleted"></a> HasRankCompleted

```csharp
public bool HasRankCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_HasTeamWon"></a> HasTeamWon

```csharp
public bool HasTeamWon { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCPlayerChallengeHistory](Divine.Protobufs.Dota2.CMsgServerToGCPlayerChallengeHistory.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCPlayerChallengeHistory.Types.md).[PlayerChallenge](Divine.Protobufs.Dota2.CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ProgressValueEnd"></a> ProgressValueEnd

```csharp
public uint ProgressValueEnd { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ProgressValueStart"></a> ProgressValueStart

```csharp
public uint ProgressValueStart { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_RankCompleted"></a> RankCompleted

```csharp
public uint RankCompleted { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_TeamWon"></a> TeamWon

```csharp
public bool TeamWon { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ClearAuditData"></a> ClearAuditData\(\)

```csharp
public void ClearAuditData()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ClearChallengeId1"></a> ClearChallengeId1\(\)

```csharp
public void ClearChallengeId1()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ClearChallengeId2"></a> ClearChallengeId2\(\)

```csharp
public void ClearChallengeId2()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ClearChallengeType"></a> ClearChallengeType\(\)

```csharp
public void ClearChallengeType()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ClearProgressValueEnd"></a> ClearProgressValueEnd\(\)

```csharp
public void ClearProgressValueEnd()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ClearProgressValueStart"></a> ClearProgressValueStart\(\)

```csharp
public void ClearProgressValueStart()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ClearRankCompleted"></a> ClearRankCompleted\(\)

```csharp
public void ClearRankCompleted()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ClearTeamWon"></a> ClearTeamWon\(\)

```csharp
public void ClearTeamWon()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge Clone()
```

#### Returns

 [CMsgServerToGCPlayerChallengeHistory](Divine.Protobufs.Dota2.CMsgServerToGCPlayerChallengeHistory.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCPlayerChallengeHistory.Types.md).[PlayerChallenge](Divine.Protobufs.Dota2.CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_Equals_Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_"></a> Equals\(PlayerChallenge\)

```csharp
public bool Equals(CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge other)
```

#### Parameters

`other` [CMsgServerToGCPlayerChallengeHistory](Divine.Protobufs.Dota2.CMsgServerToGCPlayerChallengeHistory.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCPlayerChallengeHistory.Types.md).[PlayerChallenge](Divine.Protobufs.Dota2.CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_"></a> MergeFrom\(PlayerChallenge\)

```csharp
public void MergeFrom(CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge other)
```

#### Parameters

`other` [CMsgServerToGCPlayerChallengeHistory](Divine.Protobufs.Dota2.CMsgServerToGCPlayerChallengeHistory.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCPlayerChallengeHistory.Types.md).[PlayerChallenge](Divine.Protobufs.Dota2.CMsgServerToGCPlayerChallengeHistory.Types.PlayerChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCPlayerChallengeHistory_Types_PlayerChallenge_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

