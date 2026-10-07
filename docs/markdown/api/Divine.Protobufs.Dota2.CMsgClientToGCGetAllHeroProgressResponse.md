# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse"></a> Class CMsgClientToGCGetAllHeroProgressResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetAllHeroProgressResponse : IMessage<CMsgClientToGCGetAllHeroProgressResponse>, IEquatable<CMsgClientToGCGetAllHeroProgressResponse>, IDeepCloneable<CMsgClientToGCGetAllHeroProgressResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetAllHeroProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAllHeroProgressResponse.md)

#### Implements

IMessage<CMsgClientToGCGetAllHeroProgressResponse\>, 
[IEquatable<CMsgClientToGCGetAllHeroProgressResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetAllHeroProgressResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetAllHeroProgressResponse\>\(CMsgClientToGCGetAllHeroProgressResponse, params CMsgClientToGCGetAllHeroProgressResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse__ctor"></a> CMsgClientToGCGetAllHeroProgressResponse\(\)

```csharp
public CMsgClientToGCGetAllHeroProgressResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_"></a> CMsgClientToGCGetAllHeroProgressResponse\(CMsgClientToGCGetAllHeroProgressResponse\)

```csharp
public CMsgClientToGCGetAllHeroProgressResponse(CMsgClientToGCGetAllHeroProgressResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetAllHeroProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAllHeroProgressResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_BestLapGamesFieldNumber"></a> BestLapGamesFieldNumber

```csharp
public const int BestLapGamesFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_BestLapTimeFieldNumber"></a> BestLapTimeFieldNumber

```csharp
public const int BestLapTimeFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_CurrAvgTriesFieldNumber"></a> CurrAvgTriesFieldNumber

```csharp
public const int CurrAvgTriesFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_CurrHeroGamesFieldNumber"></a> CurrHeroGamesFieldNumber

```csharp
public const int CurrHeroGamesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_CurrHeroIdFieldNumber"></a> CurrHeroIdFieldNumber

```csharp
public const int CurrHeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_CurrLapAvgTriesFieldNumber"></a> CurrLapAvgTriesFieldNumber

```csharp
public const int CurrLapAvgTriesFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_CurrLapGamesFieldNumber"></a> CurrLapGamesFieldNumber

```csharp
public const int CurrLapGamesFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_CurrLapTimeStartedFieldNumber"></a> CurrLapTimeStartedFieldNumber

```csharp
public const int CurrLapTimeStartedFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_FullLapAvgTriesFieldNumber"></a> FullLapAvgTriesFieldNumber

```csharp
public const int FullLapAvgTriesFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_LapHeroesCompletedFieldNumber"></a> LapHeroesCompletedFieldNumber

```csharp
public const int LapHeroesCompletedFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_LapHeroesRemainingFieldNumber"></a> LapHeroesRemainingFieldNumber

```csharp
public const int LapHeroesRemainingFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_LapsCompletedFieldNumber"></a> LapsCompletedFieldNumber

```csharp
public const int LapsCompletedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_NextAvgTriesFieldNumber"></a> NextAvgTriesFieldNumber

```csharp
public const int NextAvgTriesFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_NextHeroIdFieldNumber"></a> NextHeroIdFieldNumber

```csharp
public const int NextHeroIdFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_PrevAvgTriesFieldNumber"></a> PrevAvgTriesFieldNumber

```csharp
public const int PrevAvgTriesFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_PrevHeroGamesFieldNumber"></a> PrevHeroGamesFieldNumber

```csharp
public const int PrevHeroGamesFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_PrevHeroIdFieldNumber"></a> PrevHeroIdFieldNumber

```csharp
public const int PrevHeroIdFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ProfileNameFieldNumber"></a> ProfileNameFieldNumber

```csharp
public const int ProfileNameFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_StartHeroIdFieldNumber"></a> StartHeroIdFieldNumber

```csharp
public const int StartHeroIdFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_BestLapGames"></a> BestLapGames

```csharp
public uint BestLapGames { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_BestLapTime"></a> BestLapTime

```csharp
public uint BestLapTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_CurrAvgTries"></a> CurrAvgTries

```csharp
public float CurrAvgTries { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_CurrHeroGames"></a> CurrHeroGames

```csharp
public uint CurrHeroGames { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_CurrHeroId"></a> CurrHeroId

```csharp
public int CurrHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_CurrLapAvgTries"></a> CurrLapAvgTries

```csharp
public float CurrLapAvgTries { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_CurrLapGames"></a> CurrLapGames

```csharp
public uint CurrLapGames { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_CurrLapTimeStarted"></a> CurrLapTimeStarted

```csharp
public uint CurrLapTimeStarted { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_FullLapAvgTries"></a> FullLapAvgTries

```csharp
public float FullLapAvgTries { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasBestLapGames"></a> HasBestLapGames

```csharp
public bool HasBestLapGames { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasBestLapTime"></a> HasBestLapTime

```csharp
public bool HasBestLapTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasCurrAvgTries"></a> HasCurrAvgTries

```csharp
public bool HasCurrAvgTries { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasCurrHeroGames"></a> HasCurrHeroGames

```csharp
public bool HasCurrHeroGames { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasCurrHeroId"></a> HasCurrHeroId

```csharp
public bool HasCurrHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasCurrLapAvgTries"></a> HasCurrLapAvgTries

```csharp
public bool HasCurrLapAvgTries { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasCurrLapGames"></a> HasCurrLapGames

```csharp
public bool HasCurrLapGames { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasCurrLapTimeStarted"></a> HasCurrLapTimeStarted

```csharp
public bool HasCurrLapTimeStarted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasFullLapAvgTries"></a> HasFullLapAvgTries

```csharp
public bool HasFullLapAvgTries { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasLapHeroesCompleted"></a> HasLapHeroesCompleted

```csharp
public bool HasLapHeroesCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasLapHeroesRemaining"></a> HasLapHeroesRemaining

```csharp
public bool HasLapHeroesRemaining { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasLapsCompleted"></a> HasLapsCompleted

```csharp
public bool HasLapsCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasNextAvgTries"></a> HasNextAvgTries

```csharp
public bool HasNextAvgTries { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasNextHeroId"></a> HasNextHeroId

```csharp
public bool HasNextHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasPrevAvgTries"></a> HasPrevAvgTries

```csharp
public bool HasPrevAvgTries { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasPrevHeroGames"></a> HasPrevHeroGames

```csharp
public bool HasPrevHeroGames { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasPrevHeroId"></a> HasPrevHeroId

```csharp
public bool HasPrevHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasProfileName"></a> HasProfileName

```csharp
public bool HasProfileName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_HasStartHeroId"></a> HasStartHeroId

```csharp
public bool HasStartHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_LapHeroesCompleted"></a> LapHeroesCompleted

```csharp
public uint LapHeroesCompleted { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_LapHeroesRemaining"></a> LapHeroesRemaining

```csharp
public uint LapHeroesRemaining { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_LapsCompleted"></a> LapsCompleted

```csharp
public uint LapsCompleted { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_NextAvgTries"></a> NextAvgTries

```csharp
public float NextAvgTries { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_NextHeroId"></a> NextHeroId

```csharp
public int NextHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetAllHeroProgressResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetAllHeroProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAllHeroProgressResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_PrevAvgTries"></a> PrevAvgTries

```csharp
public float PrevAvgTries { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_PrevHeroGames"></a> PrevHeroGames

```csharp
public uint PrevHeroGames { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_PrevHeroId"></a> PrevHeroId

```csharp
public int PrevHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ProfileName"></a> ProfileName

```csharp
public string ProfileName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_StartHeroId"></a> StartHeroId

```csharp
public int StartHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearBestLapGames"></a> ClearBestLapGames\(\)

```csharp
public void ClearBestLapGames()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearBestLapTime"></a> ClearBestLapTime\(\)

```csharp
public void ClearBestLapTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearCurrAvgTries"></a> ClearCurrAvgTries\(\)

```csharp
public void ClearCurrAvgTries()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearCurrHeroGames"></a> ClearCurrHeroGames\(\)

```csharp
public void ClearCurrHeroGames()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearCurrHeroId"></a> ClearCurrHeroId\(\)

```csharp
public void ClearCurrHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearCurrLapAvgTries"></a> ClearCurrLapAvgTries\(\)

```csharp
public void ClearCurrLapAvgTries()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearCurrLapGames"></a> ClearCurrLapGames\(\)

```csharp
public void ClearCurrLapGames()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearCurrLapTimeStarted"></a> ClearCurrLapTimeStarted\(\)

```csharp
public void ClearCurrLapTimeStarted()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearFullLapAvgTries"></a> ClearFullLapAvgTries\(\)

```csharp
public void ClearFullLapAvgTries()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearLapHeroesCompleted"></a> ClearLapHeroesCompleted\(\)

```csharp
public void ClearLapHeroesCompleted()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearLapHeroesRemaining"></a> ClearLapHeroesRemaining\(\)

```csharp
public void ClearLapHeroesRemaining()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearLapsCompleted"></a> ClearLapsCompleted\(\)

```csharp
public void ClearLapsCompleted()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearNextAvgTries"></a> ClearNextAvgTries\(\)

```csharp
public void ClearNextAvgTries()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearNextHeroId"></a> ClearNextHeroId\(\)

```csharp
public void ClearNextHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearPrevAvgTries"></a> ClearPrevAvgTries\(\)

```csharp
public void ClearPrevAvgTries()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearPrevHeroGames"></a> ClearPrevHeroGames\(\)

```csharp
public void ClearPrevHeroGames()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearPrevHeroId"></a> ClearPrevHeroId\(\)

```csharp
public void ClearPrevHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearProfileName"></a> ClearProfileName\(\)

```csharp
public void ClearProfileName()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ClearStartHeroId"></a> ClearStartHeroId\(\)

```csharp
public void ClearStartHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetAllHeroProgressResponse Clone()
```

#### Returns

 [CMsgClientToGCGetAllHeroProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAllHeroProgressResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_"></a> Equals\(CMsgClientToGCGetAllHeroProgressResponse\)

```csharp
public bool Equals(CMsgClientToGCGetAllHeroProgressResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetAllHeroProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAllHeroProgressResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_"></a> MergeFrom\(CMsgClientToGCGetAllHeroProgressResponse\)

```csharp
public void MergeFrom(CMsgClientToGCGetAllHeroProgressResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetAllHeroProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAllHeroProgressResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroProgressResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

