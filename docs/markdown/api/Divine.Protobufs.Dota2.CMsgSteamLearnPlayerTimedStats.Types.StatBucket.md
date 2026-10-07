# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket"></a> Class CMsgSteamLearnPlayerTimedStats.Types.StatBucket

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnPlayerTimedStats.Types.StatBucket : IMessage<CMsgSteamLearnPlayerTimedStats.Types.StatBucket>, IEquatable<CMsgSteamLearnPlayerTimedStats.Types.StatBucket>, IDeepCloneable<CMsgSteamLearnPlayerTimedStats.Types.StatBucket>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnPlayerTimedStats.Types.StatBucket](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.Types.StatBucket.md)

#### Implements

IMessage<CMsgSteamLearnPlayerTimedStats.Types.StatBucket\>, 
[IEquatable<CMsgSteamLearnPlayerTimedStats.Types.StatBucket\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnPlayerTimedStats.Types.StatBucket\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnPlayerTimedStats.Types.StatBucket\>\(CMsgSteamLearnPlayerTimedStats.Types.StatBucket, params CMsgSteamLearnPlayerTimedStats.Types.StatBucket\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket__ctor"></a> StatBucket\(\)

```csharp
public StatBucket()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_"></a> StatBucket\(StatBucket\)

```csharp
public StatBucket(CMsgSteamLearnPlayerTimedStats.Types.StatBucket other)
```

#### Parameters

`other` [CMsgSteamLearnPlayerTimedStats](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.Types.md).[StatBucket](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.Types.StatBucket.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_AssistsFieldNumber"></a> AssistsFieldNumber

```csharp
public const int AssistsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_CommandsIssuedFieldNumber"></a> CommandsIssuedFieldNumber

```csharp
public const int CommandsIssuedFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_DeathsFieldNumber"></a> DeathsFieldNumber

```csharp
public const int DeathsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_DeniesFieldNumber"></a> DeniesFieldNumber

```csharp
public const int DeniesFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_ExperienceFieldNumber"></a> ExperienceFieldNumber

```csharp
public const int ExperienceFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_GameTimeFieldNumber"></a> GameTimeFieldNumber

```csharp
public const int GameTimeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_IdleTimeFieldNumber"></a> IdleTimeFieldNumber

```csharp
public const int IdleTimeFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_KillsFieldNumber"></a> KillsFieldNumber

```csharp
public const int KillsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_LastHitsFieldNumber"></a> LastHitsFieldNumber

```csharp
public const int LastHitsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_NetWorthFieldNumber"></a> NetWorthFieldNumber

```csharp
public const int NetWorthFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_ObserverWardsPlacedFieldNumber"></a> ObserverWardsPlacedFieldNumber

```csharp
public const int ObserverWardsPlacedFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_SentryWardsPlacedFieldNumber"></a> SentryWardsPlacedFieldNumber

```csharp
public const int SentryWardsPlacedFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_Assists"></a> Assists

```csharp
public uint Assists { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_CommandsIssued"></a> CommandsIssued

```csharp
public uint CommandsIssued { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_Deaths"></a> Deaths

```csharp
public uint Deaths { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_Denies"></a> Denies

```csharp
public uint Denies { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_Experience"></a> Experience

```csharp
public uint Experience { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_GameTime"></a> GameTime

```csharp
public float GameTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_HasAssists"></a> HasAssists

```csharp
public bool HasAssists { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_HasCommandsIssued"></a> HasCommandsIssued

```csharp
public bool HasCommandsIssued { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_HasDeaths"></a> HasDeaths

```csharp
public bool HasDeaths { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_HasDenies"></a> HasDenies

```csharp
public bool HasDenies { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_HasExperience"></a> HasExperience

```csharp
public bool HasExperience { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_HasGameTime"></a> HasGameTime

```csharp
public bool HasGameTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_HasIdleTime"></a> HasIdleTime

```csharp
public bool HasIdleTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_HasKills"></a> HasKills

```csharp
public bool HasKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_HasLastHits"></a> HasLastHits

```csharp
public bool HasLastHits { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_HasNetWorth"></a> HasNetWorth

```csharp
public bool HasNetWorth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_HasObserverWardsPlaced"></a> HasObserverWardsPlaced

```csharp
public bool HasObserverWardsPlaced { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_HasSentryWardsPlaced"></a> HasSentryWardsPlaced

```csharp
public bool HasSentryWardsPlaced { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_IdleTime"></a> IdleTime

```csharp
public float IdleTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_Kills"></a> Kills

```csharp
public uint Kills { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_LastHits"></a> LastHits

```csharp
public uint LastHits { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_NetWorth"></a> NetWorth

```csharp
public uint NetWorth { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_ObserverWardsPlaced"></a> ObserverWardsPlaced

```csharp
public uint ObserverWardsPlaced { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnPlayerTimedStats.Types.StatBucket> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnPlayerTimedStats](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.Types.md).[StatBucket](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.Types.StatBucket.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_SentryWardsPlaced"></a> SentryWardsPlaced

```csharp
public uint SentryWardsPlaced { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_ClearAssists"></a> ClearAssists\(\)

```csharp
public void ClearAssists()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_ClearCommandsIssued"></a> ClearCommandsIssued\(\)

```csharp
public void ClearCommandsIssued()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_ClearDeaths"></a> ClearDeaths\(\)

```csharp
public void ClearDeaths()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_ClearDenies"></a> ClearDenies\(\)

```csharp
public void ClearDenies()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_ClearExperience"></a> ClearExperience\(\)

```csharp
public void ClearExperience()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_ClearGameTime"></a> ClearGameTime\(\)

```csharp
public void ClearGameTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_ClearIdleTime"></a> ClearIdleTime\(\)

```csharp
public void ClearIdleTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_ClearKills"></a> ClearKills\(\)

```csharp
public void ClearKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_ClearLastHits"></a> ClearLastHits\(\)

```csharp
public void ClearLastHits()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_ClearNetWorth"></a> ClearNetWorth\(\)

```csharp
public void ClearNetWorth()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_ClearObserverWardsPlaced"></a> ClearObserverWardsPlaced\(\)

```csharp
public void ClearObserverWardsPlaced()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_ClearSentryWardsPlaced"></a> ClearSentryWardsPlaced\(\)

```csharp
public void ClearSentryWardsPlaced()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnPlayerTimedStats.Types.StatBucket Clone()
```

#### Returns

 [CMsgSteamLearnPlayerTimedStats](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.Types.md).[StatBucket](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.Types.StatBucket.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_"></a> Equals\(StatBucket\)

```csharp
public bool Equals(CMsgSteamLearnPlayerTimedStats.Types.StatBucket other)
```

#### Parameters

`other` [CMsgSteamLearnPlayerTimedStats](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.Types.md).[StatBucket](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.Types.StatBucket.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_"></a> MergeFrom\(StatBucket\)

```csharp
public void MergeFrom(CMsgSteamLearnPlayerTimedStats.Types.StatBucket other)
```

#### Parameters

`other` [CMsgSteamLearnPlayerTimedStats](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.Types.md).[StatBucket](Divine.Protobufs.Dota2.CMsgSteamLearnPlayerTimedStats.Types.StatBucket.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPlayerTimedStats_Types_StatBucket_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

