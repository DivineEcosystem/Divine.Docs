# <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats"></a> Class CMsgDOTAWeekendTourneyPlayerStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAWeekendTourneyPlayerStats : IMessage<CMsgDOTAWeekendTourneyPlayerStats>, IEquatable<CMsgDOTAWeekendTourneyPlayerStats>, IDeepCloneable<CMsgDOTAWeekendTourneyPlayerStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAWeekendTourneyPlayerStats](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerStats.md)

#### Implements

IMessage<CMsgDOTAWeekendTourneyPlayerStats\>, 
[IEquatable<CMsgDOTAWeekendTourneyPlayerStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAWeekendTourneyPlayerStats\>, 
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
[EnumerableExtensions.In<CMsgDOTAWeekendTourneyPlayerStats\>\(CMsgDOTAWeekendTourneyPlayerStats, params CMsgDOTAWeekendTourneyPlayerStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats__ctor"></a> CMsgDOTAWeekendTourneyPlayerStats\(\)

```csharp
public CMsgDOTAWeekendTourneyPlayerStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats__ctor_Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_"></a> CMsgDOTAWeekendTourneyPlayerStats\(CMsgDOTAWeekendTourneyPlayerStats\)

```csharp
public CMsgDOTAWeekendTourneyPlayerStats(CMsgDOTAWeekendTourneyPlayerStats other)
```

#### Parameters

`other` [CMsgDOTAWeekendTourneyPlayerStats](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_CurrentTierFieldNumber"></a> CurrentTierFieldNumber

```csharp
public const int CurrentTierFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_SeasonTrophyIdFieldNumber"></a> SeasonTrophyIdFieldNumber

```csharp
public const int SeasonTrophyIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_SkillLevelsFieldNumber"></a> SkillLevelsFieldNumber

```csharp
public const int SkillLevelsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_CurrentTier"></a> CurrentTier

```csharp
public uint CurrentTier { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_HasCurrentTier"></a> HasCurrentTier

```csharp
public bool HasCurrentTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_HasSeasonTrophyId"></a> HasSeasonTrophyId

```csharp
public bool HasSeasonTrophyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAWeekendTourneyPlayerStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAWeekendTourneyPlayerStats](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_SeasonTrophyId"></a> SeasonTrophyId

```csharp
public uint SeasonTrophyId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_SkillLevels"></a> SkillLevels

```csharp
public RepeatedField<CMsgDOTAWeekendTourneyPlayerSkillLevelStats> SkillLevels { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAWeekendTourneyPlayerSkillLevelStats](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerSkillLevelStats.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_ClearCurrentTier"></a> ClearCurrentTier\(\)

```csharp
public void ClearCurrentTier()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_ClearSeasonTrophyId"></a> ClearSeasonTrophyId\(\)

```csharp
public void ClearSeasonTrophyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAWeekendTourneyPlayerStats Clone()
```

#### Returns

 [CMsgDOTAWeekendTourneyPlayerStats](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_Equals_Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_"></a> Equals\(CMsgDOTAWeekendTourneyPlayerStats\)

```csharp
public bool Equals(CMsgDOTAWeekendTourneyPlayerStats other)
```

#### Parameters

`other` [CMsgDOTAWeekendTourneyPlayerStats](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_"></a> MergeFrom\(CMsgDOTAWeekendTourneyPlayerStats\)

```csharp
public void MergeFrom(CMsgDOTAWeekendTourneyPlayerStats other)
```

#### Parameters

`other` [CMsgDOTAWeekendTourneyPlayerStats](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

