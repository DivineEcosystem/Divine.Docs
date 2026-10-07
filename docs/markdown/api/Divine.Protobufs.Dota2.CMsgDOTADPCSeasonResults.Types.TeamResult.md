# <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult"></a> Class CMsgDOTADPCSeasonResults.Types.TeamResult

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTADPCSeasonResults.Types.TeamResult : IMessage<CMsgDOTADPCSeasonResults.Types.TeamResult>, IEquatable<CMsgDOTADPCSeasonResults.Types.TeamResult>, IDeepCloneable<CMsgDOTADPCSeasonResults.Types.TeamResult>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTADPCSeasonResults.Types.TeamResult](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.TeamResult.md)

#### Implements

IMessage<CMsgDOTADPCSeasonResults.Types.TeamResult\>, 
[IEquatable<CMsgDOTADPCSeasonResults.Types.TeamResult\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTADPCSeasonResults.Types.TeamResult\>, 
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
[EnumerableExtensions.In<CMsgDOTADPCSeasonResults.Types.TeamResult\>\(CMsgDOTADPCSeasonResults.Types.TeamResult, params CMsgDOTADPCSeasonResults.Types.TeamResult\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult__ctor"></a> TeamResult\(\)

```csharp
public TeamResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult__ctor_Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_"></a> TeamResult\(TeamResult\)

```csharp
public TeamResult(CMsgDOTADPCSeasonResults.Types.TeamResult other)
```

#### Parameters

`other` [CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[TeamResult](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.TeamResult.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_LeagueResultsFieldNumber"></a> LeagueResultsFieldNumber

```csharp
public const int LeagueResultsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_TeamAbbreviationFieldNumber"></a> TeamAbbreviationFieldNumber

```csharp
public const int TeamAbbreviationFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_TeamLogoFieldNumber"></a> TeamLogoFieldNumber

```csharp
public const int TeamLogoFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_TeamLogoUrlFieldNumber"></a> TeamLogoUrlFieldNumber

```csharp
public const int TeamLogoUrlFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_TeamNameFieldNumber"></a> TeamNameFieldNumber

```csharp
public const int TeamNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_TotalEarningsFieldNumber"></a> TotalEarningsFieldNumber

```csharp
public const int TotalEarningsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_TotalPointsFieldNumber"></a> TotalPointsFieldNumber

```csharp
public const int TotalPointsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_HasTeamAbbreviation"></a> HasTeamAbbreviation

```csharp
public bool HasTeamAbbreviation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_HasTeamLogo"></a> HasTeamLogo

```csharp
public bool HasTeamLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_HasTeamLogoUrl"></a> HasTeamLogoUrl

```csharp
public bool HasTeamLogoUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_HasTeamName"></a> HasTeamName

```csharp
public bool HasTeamName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_HasTotalEarnings"></a> HasTotalEarnings

```csharp
public bool HasTotalEarnings { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_HasTotalPoints"></a> HasTotalPoints

```csharp
public bool HasTotalPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_LeagueResults"></a> LeagueResults

```csharp
public RepeatedField<CMsgDOTADPCSeasonResults.Types.TeamLeagueResult> LeagueResults { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[TeamLeagueResult](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.TeamLeagueResult.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTADPCSeasonResults.Types.TeamResult> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[TeamResult](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.TeamResult.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_TeamAbbreviation"></a> TeamAbbreviation

```csharp
public string TeamAbbreviation { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_TeamLogo"></a> TeamLogo

```csharp
public ulong TeamLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_TeamLogoUrl"></a> TeamLogoUrl

```csharp
public string TeamLogoUrl { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_TeamName"></a> TeamName

```csharp
public string TeamName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_TotalEarnings"></a> TotalEarnings

```csharp
public uint TotalEarnings { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_TotalPoints"></a> TotalPoints

```csharp
public uint TotalPoints { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_ClearTeamAbbreviation"></a> ClearTeamAbbreviation\(\)

```csharp
public void ClearTeamAbbreviation()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_ClearTeamLogo"></a> ClearTeamLogo\(\)

```csharp
public void ClearTeamLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_ClearTeamLogoUrl"></a> ClearTeamLogoUrl\(\)

```csharp
public void ClearTeamLogoUrl()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_ClearTeamName"></a> ClearTeamName\(\)

```csharp
public void ClearTeamName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_ClearTotalEarnings"></a> ClearTotalEarnings\(\)

```csharp
public void ClearTotalEarnings()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_ClearTotalPoints"></a> ClearTotalPoints\(\)

```csharp
public void ClearTotalPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_Clone"></a> Clone\(\)

```csharp
public CMsgDOTADPCSeasonResults.Types.TeamResult Clone()
```

#### Returns

 [CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[TeamResult](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.TeamResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_Equals_Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_"></a> Equals\(TeamResult\)

```csharp
public bool Equals(CMsgDOTADPCSeasonResults.Types.TeamResult other)
```

#### Parameters

`other` [CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[TeamResult](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.TeamResult.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_"></a> MergeFrom\(TeamResult\)

```csharp
public void MergeFrom(CMsgDOTADPCSeasonResults.Types.TeamResult other)
```

#### Parameters

`other` [CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[TeamResult](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.TeamResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_TeamResult_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

