# <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team"></a> Class CMsgDOTALiveScoreboardUpdate.Types.Team

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALiveScoreboardUpdate.Types.Team : IMessage<CMsgDOTALiveScoreboardUpdate.Types.Team>, IEquatable<CMsgDOTALiveScoreboardUpdate.Types.Team>, IDeepCloneable<CMsgDOTALiveScoreboardUpdate.Types.Team>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALiveScoreboardUpdate.Types.Team](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.Types.Team.md)

#### Implements

IMessage<CMsgDOTALiveScoreboardUpdate.Types.Team\>, 
[IEquatable<CMsgDOTALiveScoreboardUpdate.Types.Team\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALiveScoreboardUpdate.Types.Team\>, 
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
[EnumerableExtensions.In<CMsgDOTALiveScoreboardUpdate.Types.Team\>\(CMsgDOTALiveScoreboardUpdate.Types.Team, params CMsgDOTALiveScoreboardUpdate.Types.Team\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team__ctor"></a> Team\(\)

```csharp
public Team()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team__ctor_Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_"></a> Team\(Team\)

```csharp
public Team(CMsgDOTALiveScoreboardUpdate.Types.Team other)
```

#### Parameters

`other` [CMsgDOTALiveScoreboardUpdate](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.Types.Team.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_BarracksStateFieldNumber"></a> BarracksStateFieldNumber

```csharp
public const int BarracksStateFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_HeroBansFieldNumber"></a> HeroBansFieldNumber

```csharp
public const int HeroBansFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_HeroPicksFieldNumber"></a> HeroPicksFieldNumber

```csharp
public const int HeroPicksFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_ScoreFieldNumber"></a> ScoreFieldNumber

```csharp
public const int ScoreFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_TowerStateFieldNumber"></a> TowerStateFieldNumber

```csharp
public const int TowerStateFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_BarracksState"></a> BarracksState

```csharp
public uint BarracksState { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_HasBarracksState"></a> HasBarracksState

```csharp
public bool HasBarracksState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_HasScore"></a> HasScore

```csharp
public bool HasScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_HasTowerState"></a> HasTowerState

```csharp
public bool HasTowerState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_HeroBans"></a> HeroBans

```csharp
public RepeatedField<int> HeroBans { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_HeroPicks"></a> HeroPicks

```csharp
public RepeatedField<int> HeroPicks { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALiveScoreboardUpdate.Types.Team> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALiveScoreboardUpdate](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.Types.Team.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_Players"></a> Players

```csharp
public RepeatedField<CMsgDOTALiveScoreboardUpdate.Types.Team.Types.Player> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTALiveScoreboardUpdate](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.Types.Team.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.Types.Team.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_Score"></a> Score

```csharp
public uint Score { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_TowerState"></a> TowerState

```csharp
public uint TowerState { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_ClearBarracksState"></a> ClearBarracksState\(\)

```csharp
public void ClearBarracksState()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_ClearScore"></a> ClearScore\(\)

```csharp
public void ClearScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_ClearTowerState"></a> ClearTowerState\(\)

```csharp
public void ClearTowerState()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALiveScoreboardUpdate.Types.Team Clone()
```

#### Returns

 [CMsgDOTALiveScoreboardUpdate](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.Types.Team.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_Equals_Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_"></a> Equals\(Team\)

```csharp
public bool Equals(CMsgDOTALiveScoreboardUpdate.Types.Team other)
```

#### Parameters

`other` [CMsgDOTALiveScoreboardUpdate](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.Types.Team.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_"></a> MergeFrom\(Team\)

```csharp
public void MergeFrom(CMsgDOTALiveScoreboardUpdate.Types.Team other)
```

#### Parameters

`other` [CMsgDOTALiveScoreboardUpdate](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTALiveScoreboardUpdate.Types.Team.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALiveScoreboardUpdate_Types_Team_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

