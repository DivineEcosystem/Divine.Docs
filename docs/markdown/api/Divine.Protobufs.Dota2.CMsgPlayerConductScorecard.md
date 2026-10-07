# <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard"></a> Class CMsgPlayerConductScorecard

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPlayerConductScorecard : IMessage<CMsgPlayerConductScorecard>, IEquatable<CMsgPlayerConductScorecard>, IDeepCloneable<CMsgPlayerConductScorecard>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPlayerConductScorecard](Divine.Protobufs.Dota2.CMsgPlayerConductScorecard.md)

#### Implements

IMessage<CMsgPlayerConductScorecard\>, 
[IEquatable<CMsgPlayerConductScorecard\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPlayerConductScorecard\>, 
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
[EnumerableExtensions.In<CMsgPlayerConductScorecard\>\(CMsgPlayerConductScorecard, params CMsgPlayerConductScorecard\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard__ctor"></a> CMsgPlayerConductScorecard\(\)

```csharp
public CMsgPlayerConductScorecard()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard__ctor_Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_"></a> CMsgPlayerConductScorecard\(CMsgPlayerConductScorecard\)

```csharp
public CMsgPlayerConductScorecard(CMsgPlayerConductScorecard other)
```

#### Parameters

`other` [CMsgPlayerConductScorecard](Divine.Protobufs.Dota2.CMsgPlayerConductScorecard.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_BehaviorRatingFieldNumber"></a> BehaviorRatingFieldNumber

```csharp
public const int BehaviorRatingFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_CommendCountFieldNumber"></a> CommendCountFieldNumber

```csharp
public const int CommendCountFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_CommsPartiesFieldNumber"></a> CommsPartiesFieldNumber

```csharp
public const int CommsPartiesFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_CommsReportsFieldNumber"></a> CommsReportsFieldNumber

```csharp
public const int CommsReportsFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_DateFieldNumber"></a> DateFieldNumber

```csharp
public const int DateFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_MatchesAbandonedFieldNumber"></a> MatchesAbandonedFieldNumber

```csharp
public const int MatchesAbandonedFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_MatchesCleanFieldNumber"></a> MatchesCleanFieldNumber

```csharp
public const int MatchesCleanFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_MatchesInReportFieldNumber"></a> MatchesInReportFieldNumber

```csharp
public const int MatchesInReportFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_MatchesReportedFieldNumber"></a> MatchesReportedFieldNumber

```csharp
public const int MatchesReportedFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_OldRawBehaviorScoreFieldNumber"></a> OldRawBehaviorScoreFieldNumber

```csharp
public const int OldRawBehaviorScoreFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_RawBehaviorScoreFieldNumber"></a> RawBehaviorScoreFieldNumber

```csharp
public const int RawBehaviorScoreFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ReasonsFieldNumber"></a> ReasonsFieldNumber

```csharp
public const int ReasonsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ReportsCountFieldNumber"></a> ReportsCountFieldNumber

```csharp
public const int ReportsCountFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ReportsPartiesFieldNumber"></a> ReportsPartiesFieldNumber

```csharp
public const int ReportsPartiesFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_SeqNumFieldNumber"></a> SeqNumFieldNumber

```csharp
public const int SeqNumFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_BehaviorRating"></a> BehaviorRating

```csharp
public CMsgPlayerConductScorecard.Types.EBehaviorRating BehaviorRating { get; set; }
```

#### Property Value

 [CMsgPlayerConductScorecard](Divine.Protobufs.Dota2.CMsgPlayerConductScorecard.md).[Types](Divine.Protobufs.Dota2.CMsgPlayerConductScorecard.Types.md).[EBehaviorRating](Divine.Protobufs.Dota2.CMsgPlayerConductScorecard.Types.EBehaviorRating.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_CommendCount"></a> CommendCount

```csharp
public uint CommendCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_CommsParties"></a> CommsParties

```csharp
public uint CommsParties { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_CommsReports"></a> CommsReports

```csharp
public uint CommsReports { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_Date"></a> Date

```csharp
public uint Date { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_HasBehaviorRating"></a> HasBehaviorRating

```csharp
public bool HasBehaviorRating { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_HasCommendCount"></a> HasCommendCount

```csharp
public bool HasCommendCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_HasCommsParties"></a> HasCommsParties

```csharp
public bool HasCommsParties { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_HasCommsReports"></a> HasCommsReports

```csharp
public bool HasCommsReports { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_HasDate"></a> HasDate

```csharp
public bool HasDate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_HasMatchesAbandoned"></a> HasMatchesAbandoned

```csharp
public bool HasMatchesAbandoned { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_HasMatchesClean"></a> HasMatchesClean

```csharp
public bool HasMatchesClean { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_HasMatchesInReport"></a> HasMatchesInReport

```csharp
public bool HasMatchesInReport { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_HasMatchesReported"></a> HasMatchesReported

```csharp
public bool HasMatchesReported { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_HasOldRawBehaviorScore"></a> HasOldRawBehaviorScore

```csharp
public bool HasOldRawBehaviorScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_HasRawBehaviorScore"></a> HasRawBehaviorScore

```csharp
public bool HasRawBehaviorScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_HasReasons"></a> HasReasons

```csharp
public bool HasReasons { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_HasReportsCount"></a> HasReportsCount

```csharp
public bool HasReportsCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_HasReportsParties"></a> HasReportsParties

```csharp
public bool HasReportsParties { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_HasSeqNum"></a> HasSeqNum

```csharp
public bool HasSeqNum { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_MatchesAbandoned"></a> MatchesAbandoned

```csharp
public uint MatchesAbandoned { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_MatchesClean"></a> MatchesClean

```csharp
public uint MatchesClean { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_MatchesInReport"></a> MatchesInReport

```csharp
public uint MatchesInReport { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_MatchesReported"></a> MatchesReported

```csharp
public uint MatchesReported { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_OldRawBehaviorScore"></a> OldRawBehaviorScore

```csharp
public uint OldRawBehaviorScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPlayerConductScorecard> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPlayerConductScorecard](Divine.Protobufs.Dota2.CMsgPlayerConductScorecard.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_RawBehaviorScore"></a> RawBehaviorScore

```csharp
public uint RawBehaviorScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_Reasons"></a> Reasons

```csharp
public uint Reasons { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ReportsCount"></a> ReportsCount

```csharp
public uint ReportsCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ReportsParties"></a> ReportsParties

```csharp
public uint ReportsParties { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_SeqNum"></a> SeqNum

```csharp
public uint SeqNum { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ClearBehaviorRating"></a> ClearBehaviorRating\(\)

```csharp
public void ClearBehaviorRating()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ClearCommendCount"></a> ClearCommendCount\(\)

```csharp
public void ClearCommendCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ClearCommsParties"></a> ClearCommsParties\(\)

```csharp
public void ClearCommsParties()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ClearCommsReports"></a> ClearCommsReports\(\)

```csharp
public void ClearCommsReports()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ClearDate"></a> ClearDate\(\)

```csharp
public void ClearDate()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ClearMatchesAbandoned"></a> ClearMatchesAbandoned\(\)

```csharp
public void ClearMatchesAbandoned()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ClearMatchesClean"></a> ClearMatchesClean\(\)

```csharp
public void ClearMatchesClean()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ClearMatchesInReport"></a> ClearMatchesInReport\(\)

```csharp
public void ClearMatchesInReport()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ClearMatchesReported"></a> ClearMatchesReported\(\)

```csharp
public void ClearMatchesReported()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ClearOldRawBehaviorScore"></a> ClearOldRawBehaviorScore\(\)

```csharp
public void ClearOldRawBehaviorScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ClearRawBehaviorScore"></a> ClearRawBehaviorScore\(\)

```csharp
public void ClearRawBehaviorScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ClearReasons"></a> ClearReasons\(\)

```csharp
public void ClearReasons()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ClearReportsCount"></a> ClearReportsCount\(\)

```csharp
public void ClearReportsCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ClearReportsParties"></a> ClearReportsParties\(\)

```csharp
public void ClearReportsParties()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ClearSeqNum"></a> ClearSeqNum\(\)

```csharp
public void ClearSeqNum()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_Clone"></a> Clone\(\)

```csharp
public CMsgPlayerConductScorecard Clone()
```

#### Returns

 [CMsgPlayerConductScorecard](Divine.Protobufs.Dota2.CMsgPlayerConductScorecard.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_Equals_Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_"></a> Equals\(CMsgPlayerConductScorecard\)

```csharp
public bool Equals(CMsgPlayerConductScorecard other)
```

#### Parameters

`other` [CMsgPlayerConductScorecard](Divine.Protobufs.Dota2.CMsgPlayerConductScorecard.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_MergeFrom_Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_"></a> MergeFrom\(CMsgPlayerConductScorecard\)

```csharp
public void MergeFrom(CMsgPlayerConductScorecard other)
```

#### Parameters

`other` [CMsgPlayerConductScorecard](Divine.Protobufs.Dota2.CMsgPlayerConductScorecard.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecard_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

