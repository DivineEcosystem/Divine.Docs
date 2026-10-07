# <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory"></a> Class CMsgBattleCupVictory

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBattleCupVictory : IMessage<CMsgBattleCupVictory>, IEquatable<CMsgBattleCupVictory>, IDeepCloneable<CMsgBattleCupVictory>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBattleCupVictory](Divine.Protobufs.Dota2.CMsgBattleCupVictory.md)

#### Implements

IMessage<CMsgBattleCupVictory\>, 
[IEquatable<CMsgBattleCupVictory\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBattleCupVictory\>, 
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
[EnumerableExtensions.In<CMsgBattleCupVictory\>\(CMsgBattleCupVictory, params CMsgBattleCupVictory\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory__ctor"></a> CMsgBattleCupVictory\(\)

```csharp
public CMsgBattleCupVictory()
```

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory__ctor_Divine_Protobufs_Dota2_CMsgBattleCupVictory_"></a> CMsgBattleCupVictory\(CMsgBattleCupVictory\)

```csharp
public CMsgBattleCupVictory(CMsgBattleCupVictory other)
```

#### Parameters

`other` [CMsgBattleCupVictory](Divine.Protobufs.Dota2.CMsgBattleCupVictory.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_DivisionIdFieldNumber"></a> DivisionIdFieldNumber

```csharp
public const int DivisionIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_SkillLevelFieldNumber"></a> SkillLevelFieldNumber

```csharp
public const int SkillLevelFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_StreakFieldNumber"></a> StreakFieldNumber

```csharp
public const int StreakFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_TournamentIdFieldNumber"></a> TournamentIdFieldNumber

```csharp
public const int TournamentIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_TrophyIdFieldNumber"></a> TrophyIdFieldNumber

```csharp
public const int TrophyIdFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_ValidUntilFieldNumber"></a> ValidUntilFieldNumber

```csharp
public const int ValidUntilFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_WinDateFieldNumber"></a> WinDateFieldNumber

```csharp
public const int WinDateFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_DivisionId"></a> DivisionId

```csharp
public uint DivisionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_HasDivisionId"></a> HasDivisionId

```csharp
public bool HasDivisionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_HasSkillLevel"></a> HasSkillLevel

```csharp
public bool HasSkillLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_HasStreak"></a> HasStreak

```csharp
public bool HasStreak { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_HasTournamentId"></a> HasTournamentId

```csharp
public bool HasTournamentId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_HasTrophyId"></a> HasTrophyId

```csharp
public bool HasTrophyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_HasValidUntil"></a> HasValidUntil

```csharp
public bool HasValidUntil { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_HasWinDate"></a> HasWinDate

```csharp
public bool HasWinDate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBattleCupVictory> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBattleCupVictory](Divine.Protobufs.Dota2.CMsgBattleCupVictory.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_SkillLevel"></a> SkillLevel

```csharp
public uint SkillLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_Streak"></a> Streak

```csharp
public uint Streak { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_TournamentId"></a> TournamentId

```csharp
public uint TournamentId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_TrophyId"></a> TrophyId

```csharp
public uint TrophyId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_ValidUntil"></a> ValidUntil

```csharp
public uint ValidUntil { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_WinDate"></a> WinDate

```csharp
public uint WinDate { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_ClearDivisionId"></a> ClearDivisionId\(\)

```csharp
public void ClearDivisionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_ClearSkillLevel"></a> ClearSkillLevel\(\)

```csharp
public void ClearSkillLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_ClearStreak"></a> ClearStreak\(\)

```csharp
public void ClearStreak()
```

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_ClearTournamentId"></a> ClearTournamentId\(\)

```csharp
public void ClearTournamentId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_ClearTrophyId"></a> ClearTrophyId\(\)

```csharp
public void ClearTrophyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_ClearValidUntil"></a> ClearValidUntil\(\)

```csharp
public void ClearValidUntil()
```

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_ClearWinDate"></a> ClearWinDate\(\)

```csharp
public void ClearWinDate()
```

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_Clone"></a> Clone\(\)

```csharp
public CMsgBattleCupVictory Clone()
```

#### Returns

 [CMsgBattleCupVictory](Divine.Protobufs.Dota2.CMsgBattleCupVictory.md)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_Equals_Divine_Protobufs_Dota2_CMsgBattleCupVictory_"></a> Equals\(CMsgBattleCupVictory\)

```csharp
public bool Equals(CMsgBattleCupVictory other)
```

#### Parameters

`other` [CMsgBattleCupVictory](Divine.Protobufs.Dota2.CMsgBattleCupVictory.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_MergeFrom_Divine_Protobufs_Dota2_CMsgBattleCupVictory_"></a> MergeFrom\(CMsgBattleCupVictory\)

```csharp
public void MergeFrom(CMsgBattleCupVictory other)
```

#### Parameters

`other` [CMsgBattleCupVictory](Divine.Protobufs.Dota2.CMsgBattleCupVictory.md)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBattleCupVictory_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

