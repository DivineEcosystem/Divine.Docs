# <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat"></a> Class CMsgClientToGCTeammateStatsResponse.Types.TeammateStat

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCTeammateStatsResponse.Types.TeammateStat : IMessage<CMsgClientToGCTeammateStatsResponse.Types.TeammateStat>, IEquatable<CMsgClientToGCTeammateStatsResponse.Types.TeammateStat>, IDeepCloneable<CMsgClientToGCTeammateStatsResponse.Types.TeammateStat>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCTeammateStatsResponse.Types.TeammateStat](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.Types.TeammateStat.md)

#### Implements

IMessage<CMsgClientToGCTeammateStatsResponse.Types.TeammateStat\>, 
[IEquatable<CMsgClientToGCTeammateStatsResponse.Types.TeammateStat\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCTeammateStatsResponse.Types.TeammateStat\>, 
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
[EnumerableExtensions.In<CMsgClientToGCTeammateStatsResponse.Types.TeammateStat\>\(CMsgClientToGCTeammateStatsResponse.Types.TeammateStat, params CMsgClientToGCTeammateStatsResponse.Types.TeammateStat\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat__ctor"></a> TeammateStat\(\)

```csharp
public TeammateStat()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat__ctor_Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_"></a> TeammateStat\(TeammateStat\)

```csharp
public TeammateStat(CMsgClientToGCTeammateStatsResponse.Types.TeammateStat other)
```

#### Parameters

`other` [CMsgClientToGCTeammateStatsResponse](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.Types.md).[TeammateStat](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.Types.TeammateStat.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_GamesFieldNumber"></a> GamesFieldNumber

```csharp
public const int GamesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_MostRecentGameMatchIdFieldNumber"></a> MostRecentGameMatchIdFieldNumber

```csharp
public const int MostRecentGameMatchIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_MostRecentGameTimestampFieldNumber"></a> MostRecentGameTimestampFieldNumber

```csharp
public const int MostRecentGameTimestampFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_PerformanceFieldNumber"></a> PerformanceFieldNumber

```csharp
public const int PerformanceFieldNumber = 100
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_WinsFieldNumber"></a> WinsFieldNumber

```csharp
public const int WinsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_Games"></a> Games

```csharp
public uint Games { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_HasGames"></a> HasGames

```csharp
public bool HasGames { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_HasMostRecentGameMatchId"></a> HasMostRecentGameMatchId

```csharp
public bool HasMostRecentGameMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_HasMostRecentGameTimestamp"></a> HasMostRecentGameTimestamp

```csharp
public bool HasMostRecentGameTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_HasPerformance"></a> HasPerformance

```csharp
public bool HasPerformance { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_HasWins"></a> HasWins

```csharp
public bool HasWins { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_MostRecentGameMatchId"></a> MostRecentGameMatchId

```csharp
public ulong MostRecentGameMatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_MostRecentGameTimestamp"></a> MostRecentGameTimestamp

```csharp
public uint MostRecentGameTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCTeammateStatsResponse.Types.TeammateStat> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCTeammateStatsResponse](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.Types.md).[TeammateStat](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.Types.TeammateStat.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_Performance"></a> Performance

```csharp
public float Performance { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_Wins"></a> Wins

```csharp
public uint Wins { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_ClearGames"></a> ClearGames\(\)

```csharp
public void ClearGames()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_ClearMostRecentGameMatchId"></a> ClearMostRecentGameMatchId\(\)

```csharp
public void ClearMostRecentGameMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_ClearMostRecentGameTimestamp"></a> ClearMostRecentGameTimestamp\(\)

```csharp
public void ClearMostRecentGameTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_ClearPerformance"></a> ClearPerformance\(\)

```csharp
public void ClearPerformance()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_ClearWins"></a> ClearWins\(\)

```csharp
public void ClearWins()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCTeammateStatsResponse.Types.TeammateStat Clone()
```

#### Returns

 [CMsgClientToGCTeammateStatsResponse](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.Types.md).[TeammateStat](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.Types.TeammateStat.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_Equals_Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_"></a> Equals\(TeammateStat\)

```csharp
public bool Equals(CMsgClientToGCTeammateStatsResponse.Types.TeammateStat other)
```

#### Parameters

`other` [CMsgClientToGCTeammateStatsResponse](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.Types.md).[TeammateStat](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.Types.TeammateStat.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_"></a> MergeFrom\(TeammateStat\)

```csharp
public void MergeFrom(CMsgClientToGCTeammateStatsResponse.Types.TeammateStat other)
```

#### Parameters

`other` [CMsgClientToGCTeammateStatsResponse](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.Types.md).[TeammateStat](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.Types.TeammateStat.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Types_TeammateStat_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

