# <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData"></a> Class CMsgAccountGuildEventData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAccountGuildEventData : IMessage<CMsgAccountGuildEventData>, IEquatable<CMsgAccountGuildEventData>, IDeepCloneable<CMsgAccountGuildEventData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAccountGuildEventData](Divine.Protobufs.Dota2.CMsgAccountGuildEventData.md)

#### Implements

IMessage<CMsgAccountGuildEventData\>, 
[IEquatable<CMsgAccountGuildEventData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAccountGuildEventData\>, 
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
[EnumerableExtensions.In<CMsgAccountGuildEventData\>\(CMsgAccountGuildEventData, params CMsgAccountGuildEventData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData__ctor"></a> CMsgAccountGuildEventData\(\)

```csharp
public CMsgAccountGuildEventData()
```

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData__ctor_Divine_Protobufs_Dota2_CMsgAccountGuildEventData_"></a> CMsgAccountGuildEventData\(CMsgAccountGuildEventData\)

```csharp
public CMsgAccountGuildEventData(CMsgAccountGuildEventData other)
```

#### Parameters

`other` [CMsgAccountGuildEventData](Divine.Protobufs.Dota2.CMsgAccountGuildEventData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_ChallengesRefreshTimestampFieldNumber"></a> ChallengesRefreshTimestampFieldNumber

```csharp
public const int ChallengesRefreshTimestampFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_CompletedChallengeCountFieldNumber"></a> CompletedChallengeCountFieldNumber

```csharp
public const int CompletedChallengeCountFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_ContractSlotsFieldNumber"></a> ContractSlotsFieldNumber

```csharp
public const int ContractSlotsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_ContractsRefreshedTimestampFieldNumber"></a> ContractsRefreshedTimestampFieldNumber

```csharp
public const int ContractsRefreshedTimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_GuildCurrentPercentileFieldNumber"></a> GuildCurrentPercentileFieldNumber

```csharp
public const int GuildCurrentPercentileFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_GuildPointsFieldNumber"></a> GuildPointsFieldNumber

```csharp
public const int GuildPointsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_GuildWeeklyLastTimestampFieldNumber"></a> GuildWeeklyLastTimestampFieldNumber

```csharp
public const int GuildWeeklyLastTimestampFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_GuildWeeklyPercentileFieldNumber"></a> GuildWeeklyPercentileFieldNumber

```csharp
public const int GuildWeeklyPercentileFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_LastWeeklyClaimTimeFieldNumber"></a> LastWeeklyClaimTimeFieldNumber

```csharp
public const int LastWeeklyClaimTimeFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_ChallengesRefreshTimestamp"></a> ChallengesRefreshTimestamp

```csharp
public uint ChallengesRefreshTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_CompletedChallengeCount"></a> CompletedChallengeCount

```csharp
public uint CompletedChallengeCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_ContractSlots"></a> ContractSlots

```csharp
public RepeatedField<CMsgGuildContractSlot> ContractSlots { get; }
```

#### Property Value

 RepeatedField<[CMsgGuildContractSlot](Divine.Protobufs.Dota2.CMsgGuildContractSlot.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_ContractsRefreshedTimestamp"></a> ContractsRefreshedTimestamp

```csharp
public uint ContractsRefreshedTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_GuildCurrentPercentile"></a> GuildCurrentPercentile

```csharp
public uint GuildCurrentPercentile { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_GuildPoints"></a> GuildPoints

```csharp
public uint GuildPoints { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_GuildWeeklyLastTimestamp"></a> GuildWeeklyLastTimestamp

```csharp
public uint GuildWeeklyLastTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_GuildWeeklyPercentile"></a> GuildWeeklyPercentile

```csharp
public uint GuildWeeklyPercentile { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_HasChallengesRefreshTimestamp"></a> HasChallengesRefreshTimestamp

```csharp
public bool HasChallengesRefreshTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_HasCompletedChallengeCount"></a> HasCompletedChallengeCount

```csharp
public bool HasCompletedChallengeCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_HasContractsRefreshedTimestamp"></a> HasContractsRefreshedTimestamp

```csharp
public bool HasContractsRefreshedTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_HasGuildCurrentPercentile"></a> HasGuildCurrentPercentile

```csharp
public bool HasGuildCurrentPercentile { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_HasGuildPoints"></a> HasGuildPoints

```csharp
public bool HasGuildPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_HasGuildWeeklyLastTimestamp"></a> HasGuildWeeklyLastTimestamp

```csharp
public bool HasGuildWeeklyLastTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_HasGuildWeeklyPercentile"></a> HasGuildWeeklyPercentile

```csharp
public bool HasGuildWeeklyPercentile { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_HasLastWeeklyClaimTime"></a> HasLastWeeklyClaimTime

```csharp
public bool HasLastWeeklyClaimTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_LastWeeklyClaimTime"></a> LastWeeklyClaimTime

```csharp
public uint LastWeeklyClaimTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAccountGuildEventData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAccountGuildEventData](Divine.Protobufs.Dota2.CMsgAccountGuildEventData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_ClearChallengesRefreshTimestamp"></a> ClearChallengesRefreshTimestamp\(\)

```csharp
public void ClearChallengesRefreshTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_ClearCompletedChallengeCount"></a> ClearCompletedChallengeCount\(\)

```csharp
public void ClearCompletedChallengeCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_ClearContractsRefreshedTimestamp"></a> ClearContractsRefreshedTimestamp\(\)

```csharp
public void ClearContractsRefreshedTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_ClearGuildCurrentPercentile"></a> ClearGuildCurrentPercentile\(\)

```csharp
public void ClearGuildCurrentPercentile()
```

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_ClearGuildPoints"></a> ClearGuildPoints\(\)

```csharp
public void ClearGuildPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_ClearGuildWeeklyLastTimestamp"></a> ClearGuildWeeklyLastTimestamp\(\)

```csharp
public void ClearGuildWeeklyLastTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_ClearGuildWeeklyPercentile"></a> ClearGuildWeeklyPercentile\(\)

```csharp
public void ClearGuildWeeklyPercentile()
```

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_ClearLastWeeklyClaimTime"></a> ClearLastWeeklyClaimTime\(\)

```csharp
public void ClearLastWeeklyClaimTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_Clone"></a> Clone\(\)

```csharp
public CMsgAccountGuildEventData Clone()
```

#### Returns

 [CMsgAccountGuildEventData](Divine.Protobufs.Dota2.CMsgAccountGuildEventData.md)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_Equals_Divine_Protobufs_Dota2_CMsgAccountGuildEventData_"></a> Equals\(CMsgAccountGuildEventData\)

```csharp
public bool Equals(CMsgAccountGuildEventData other)
```

#### Parameters

`other` [CMsgAccountGuildEventData](Divine.Protobufs.Dota2.CMsgAccountGuildEventData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_MergeFrom_Divine_Protobufs_Dota2_CMsgAccountGuildEventData_"></a> MergeFrom\(CMsgAccountGuildEventData\)

```csharp
public void MergeFrom(CMsgAccountGuildEventData other)
```

#### Parameters

`other` [CMsgAccountGuildEventData](Divine.Protobufs.Dota2.CMsgAccountGuildEventData.md)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildEventData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

