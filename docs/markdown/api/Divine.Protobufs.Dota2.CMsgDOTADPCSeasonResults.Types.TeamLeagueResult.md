# <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult"></a> Class CMsgDOTADPCSeasonResults.Types.TeamLeagueResult

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTADPCSeasonResults.Types.TeamLeagueResult : IMessage<CMsgDOTADPCSeasonResults.Types.TeamLeagueResult>, IEquatable<CMsgDOTADPCSeasonResults.Types.TeamLeagueResult>, IDeepCloneable<CMsgDOTADPCSeasonResults.Types.TeamLeagueResult>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTADPCSeasonResults.Types.TeamLeagueResult](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.TeamLeagueResult.md)

#### Implements

IMessage<CMsgDOTADPCSeasonResults.Types.TeamLeagueResult\>, 
[IEquatable<CMsgDOTADPCSeasonResults.Types.TeamLeagueResult\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTADPCSeasonResults.Types.TeamLeagueResult\>, 
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
[EnumerableExtensions.In<CMsgDOTADPCSeasonResults.Types.TeamLeagueResult\>\(CMsgDOTADPCSeasonResults.Types.TeamLeagueResult, params CMsgDOTADPCSeasonResults.Types.TeamLeagueResult\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult__ctor"></a> TeamLeagueResult\(\)

```csharp
public TeamLeagueResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult__ctor_Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_"></a> TeamLeagueResult\(TeamLeagueResult\)

```csharp
public TeamLeagueResult(CMsgDOTADPCSeasonResults.Types.TeamLeagueResult other)
```

#### Parameters

`other` [CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[TeamLeagueResult](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.TeamLeagueResult.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_AuditActionFieldNumber"></a> AuditActionFieldNumber

```csharp
public const int AuditActionFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_AuditDataFieldNumber"></a> AuditDataFieldNumber

```csharp
public const int AuditDataFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_EarningsFieldNumber"></a> EarningsFieldNumber

```csharp
public const int EarningsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_PointsFieldNumber"></a> PointsFieldNumber

```csharp
public const int PointsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_StandingFieldNumber"></a> StandingFieldNumber

```csharp
public const int StandingFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_AuditAction"></a> AuditAction

```csharp
public uint AuditAction { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_AuditData"></a> AuditData

```csharp
public uint AuditData { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_Earnings"></a> Earnings

```csharp
public uint Earnings { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_HasAuditAction"></a> HasAuditAction

```csharp
public bool HasAuditAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_HasAuditData"></a> HasAuditData

```csharp
public bool HasAuditData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_HasEarnings"></a> HasEarnings

```csharp
public bool HasEarnings { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_HasPoints"></a> HasPoints

```csharp
public bool HasPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_HasStanding"></a> HasStanding

```csharp
public bool HasStanding { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTADPCSeasonResults.Types.TeamLeagueResult> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[TeamLeagueResult](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.TeamLeagueResult.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_Points"></a> Points

```csharp
public uint Points { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_Standing"></a> Standing

```csharp
public uint Standing { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_ClearAuditAction"></a> ClearAuditAction\(\)

```csharp
public void ClearAuditAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_ClearAuditData"></a> ClearAuditData\(\)

```csharp
public void ClearAuditData()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_ClearEarnings"></a> ClearEarnings\(\)

```csharp
public void ClearEarnings()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_ClearPoints"></a> ClearPoints\(\)

```csharp
public void ClearPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_ClearStanding"></a> ClearStanding\(\)

```csharp
public void ClearStanding()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_Clone"></a> Clone\(\)

```csharp
public CMsgDOTADPCSeasonResults.Types.TeamLeagueResult Clone()
```

#### Returns

 [CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[TeamLeagueResult](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.TeamLeagueResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_Equals_Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_"></a> Equals\(TeamLeagueResult\)

```csharp
public bool Equals(CMsgDOTADPCSeasonResults.Types.TeamLeagueResult other)
```

#### Parameters

`other` [CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[TeamLeagueResult](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.TeamLeagueResult.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_"></a> MergeFrom\(TeamLeagueResult\)

```csharp
public void MergeFrom(CMsgDOTADPCSeasonResults.Types.TeamLeagueResult other)
```

#### Parameters

`other` [CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[TeamLeagueResult](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.TeamLeagueResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamLeagueResult_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

