# <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats"></a> Class CMatchTeamTimedStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMatchTeamTimedStats : IMessage<CMatchTeamTimedStats>, IEquatable<CMatchTeamTimedStats>, IDeepCloneable<CMatchTeamTimedStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMatchTeamTimedStats](Divine.Protobufs.Dota2.CMatchTeamTimedStats.md)

#### Implements

IMessage<CMatchTeamTimedStats\>, 
[IEquatable<CMatchTeamTimedStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMatchTeamTimedStats\>, 
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
[EnumerableExtensions.In<CMatchTeamTimedStats\>\(CMatchTeamTimedStats, params CMatchTeamTimedStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats__ctor"></a> CMatchTeamTimedStats\(\)

```csharp
public CMatchTeamTimedStats()
```

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats__ctor_Divine_Protobufs_Dota2_CMatchTeamTimedStats_"></a> CMatchTeamTimedStats\(CMatchTeamTimedStats\)

```csharp
public CMatchTeamTimedStats(CMatchTeamTimedStats other)
```

#### Parameters

`other` [CMatchTeamTimedStats](Divine.Protobufs.Dota2.CMatchTeamTimedStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_EnemyBarracksKilledFieldNumber"></a> EnemyBarracksKilledFieldNumber

```csharp
public const int EnemyBarracksKilledFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_EnemyBarracksStatusFieldNumber"></a> EnemyBarracksStatusFieldNumber

```csharp
public const int EnemyBarracksStatusFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_EnemyTowersKilledFieldNumber"></a> EnemyTowersKilledFieldNumber

```csharp
public const int EnemyTowersKilledFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_EnemyTowersStatusFieldNumber"></a> EnemyTowersStatusFieldNumber

```csharp
public const int EnemyTowersStatusFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_TimeFieldNumber"></a> TimeFieldNumber

```csharp
public const int TimeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_EnemyBarracksKilled"></a> EnemyBarracksKilled

```csharp
public uint EnemyBarracksKilled { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_EnemyBarracksStatus"></a> EnemyBarracksStatus

```csharp
public uint EnemyBarracksStatus { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_EnemyTowersKilled"></a> EnemyTowersKilled

```csharp
public uint EnemyTowersKilled { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_EnemyTowersStatus"></a> EnemyTowersStatus

```csharp
public uint EnemyTowersStatus { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_HasEnemyBarracksKilled"></a> HasEnemyBarracksKilled

```csharp
public bool HasEnemyBarracksKilled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_HasEnemyBarracksStatus"></a> HasEnemyBarracksStatus

```csharp
public bool HasEnemyBarracksStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_HasEnemyTowersKilled"></a> HasEnemyTowersKilled

```csharp
public bool HasEnemyTowersKilled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_HasEnemyTowersStatus"></a> HasEnemyTowersStatus

```csharp
public bool HasEnemyTowersStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_HasTime"></a> HasTime

```csharp
public bool HasTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_Parser"></a> Parser

```csharp
public static MessageParser<CMatchTeamTimedStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMatchTeamTimedStats](Divine.Protobufs.Dota2.CMatchTeamTimedStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_Time"></a> Time

```csharp
public uint Time { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_ClearEnemyBarracksKilled"></a> ClearEnemyBarracksKilled\(\)

```csharp
public void ClearEnemyBarracksKilled()
```

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_ClearEnemyBarracksStatus"></a> ClearEnemyBarracksStatus\(\)

```csharp
public void ClearEnemyBarracksStatus()
```

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_ClearEnemyTowersKilled"></a> ClearEnemyTowersKilled\(\)

```csharp
public void ClearEnemyTowersKilled()
```

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_ClearEnemyTowersStatus"></a> ClearEnemyTowersStatus\(\)

```csharp
public void ClearEnemyTowersStatus()
```

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_ClearTime"></a> ClearTime\(\)

```csharp
public void ClearTime()
```

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_Clone"></a> Clone\(\)

```csharp
public CMatchTeamTimedStats Clone()
```

#### Returns

 [CMatchTeamTimedStats](Divine.Protobufs.Dota2.CMatchTeamTimedStats.md)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_Equals_Divine_Protobufs_Dota2_CMatchTeamTimedStats_"></a> Equals\(CMatchTeamTimedStats\)

```csharp
public bool Equals(CMatchTeamTimedStats other)
```

#### Parameters

`other` [CMatchTeamTimedStats](Divine.Protobufs.Dota2.CMatchTeamTimedStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_MergeFrom_Divine_Protobufs_Dota2_CMatchTeamTimedStats_"></a> MergeFrom\(CMatchTeamTimedStats\)

```csharp
public void MergeFrom(CMatchTeamTimedStats other)
```

#### Parameters

`other` [CMatchTeamTimedStats](Divine.Protobufs.Dota2.CMatchTeamTimedStats.md)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMatchTeamTimedStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

