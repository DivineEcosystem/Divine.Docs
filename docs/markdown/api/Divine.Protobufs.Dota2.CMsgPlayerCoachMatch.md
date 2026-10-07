# <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch"></a> Class CMsgPlayerCoachMatch

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPlayerCoachMatch : IMessage<CMsgPlayerCoachMatch>, IEquatable<CMsgPlayerCoachMatch>, IDeepCloneable<CMsgPlayerCoachMatch>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPlayerCoachMatch](Divine.Protobufs.Dota2.CMsgPlayerCoachMatch.md)

#### Implements

IMessage<CMsgPlayerCoachMatch\>, 
[IEquatable<CMsgPlayerCoachMatch\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPlayerCoachMatch\>, 
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
[EnumerableExtensions.In<CMsgPlayerCoachMatch\>\(CMsgPlayerCoachMatch, params CMsgPlayerCoachMatch\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch__ctor"></a> CMsgPlayerCoachMatch\(\)

```csharp
public CMsgPlayerCoachMatch()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch__ctor_Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_"></a> CMsgPlayerCoachMatch\(CMsgPlayerCoachMatch\)

```csharp
public CMsgPlayerCoachMatch(CMsgPlayerCoachMatch other)
```

#### Parameters

`other` [CMsgPlayerCoachMatch](Divine.Protobufs.Dota2.CMsgPlayerCoachMatch.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_CoachedTeamFieldNumber"></a> CoachedTeamFieldNumber

```csharp
public const int CoachedTeamFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_CoachFlagsFieldNumber"></a> CoachFlagsFieldNumber

```csharp
public const int CoachFlagsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_MatchOutcomeFieldNumber"></a> MatchOutcomeFieldNumber

```csharp
public const int MatchOutcomeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_StartTimeFieldNumber"></a> StartTimeFieldNumber

```csharp
public const int StartTimeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_TeammateRatingsFieldNumber"></a> TeammateRatingsFieldNumber

```csharp
public const int TeammateRatingsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_CoachedTeam"></a> CoachedTeam

```csharp
public uint CoachedTeam { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_CoachFlags"></a> CoachFlags

```csharp
public uint CoachFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_Duration"></a> Duration

```csharp
public uint Duration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_HasCoachedTeam"></a> HasCoachedTeam

```csharp
public bool HasCoachedTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_HasCoachFlags"></a> HasCoachFlags

```csharp
public bool HasCoachFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_HasMatchOutcome"></a> HasMatchOutcome

```csharp
public bool HasMatchOutcome { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_HasStartTime"></a> HasStartTime

```csharp
public bool HasStartTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_MatchOutcome"></a> MatchOutcome

```csharp
public EMatchOutcome MatchOutcome { get; set; }
```

#### Property Value

 [EMatchOutcome](Divine.Protobufs.Dota2.EMatchOutcome.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPlayerCoachMatch> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPlayerCoachMatch](Divine.Protobufs.Dota2.CMsgPlayerCoachMatch.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_StartTime"></a> StartTime

```csharp
public uint StartTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_TeammateRatings"></a> TeammateRatings

```csharp
public RepeatedField<ECoachTeammateRating> TeammateRatings { get; }
```

#### Property Value

 RepeatedField<[ECoachTeammateRating](Divine.Protobufs.Dota2.ECoachTeammateRating.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_ClearCoachedTeam"></a> ClearCoachedTeam\(\)

```csharp
public void ClearCoachedTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_ClearCoachFlags"></a> ClearCoachFlags\(\)

```csharp
public void ClearCoachFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_ClearMatchOutcome"></a> ClearMatchOutcome\(\)

```csharp
public void ClearMatchOutcome()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_ClearStartTime"></a> ClearStartTime\(\)

```csharp
public void ClearStartTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_Clone"></a> Clone\(\)

```csharp
public CMsgPlayerCoachMatch Clone()
```

#### Returns

 [CMsgPlayerCoachMatch](Divine.Protobufs.Dota2.CMsgPlayerCoachMatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_Equals_Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_"></a> Equals\(CMsgPlayerCoachMatch\)

```csharp
public bool Equals(CMsgPlayerCoachMatch other)
```

#### Parameters

`other` [CMsgPlayerCoachMatch](Divine.Protobufs.Dota2.CMsgPlayerCoachMatch.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_MergeFrom_Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_"></a> MergeFrom\(CMsgPlayerCoachMatch\)

```csharp
public void MergeFrom(CMsgPlayerCoachMatch other)
```

#### Parameters

`other` [CMsgPlayerCoachMatch](Divine.Protobufs.Dota2.CMsgPlayerCoachMatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCoachMatch_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

