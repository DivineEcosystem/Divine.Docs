# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState"></a> Class CMsgSteamLearnMatchStateV5.Types.TeamState

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnMatchStateV5.Types.TeamState : IMessage<CMsgSteamLearnMatchStateV5.Types.TeamState>, IEquatable<CMsgSteamLearnMatchStateV5.Types.TeamState>, IDeepCloneable<CMsgSteamLearnMatchStateV5.Types.TeamState>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnMatchStateV5.Types.TeamState](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.Types.TeamState.md)

#### Implements

IMessage<CMsgSteamLearnMatchStateV5.Types.TeamState\>, 
[IEquatable<CMsgSteamLearnMatchStateV5.Types.TeamState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnMatchStateV5.Types.TeamState\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnMatchStateV5.Types.TeamState\>\(CMsgSteamLearnMatchStateV5.Types.TeamState, params CMsgSteamLearnMatchStateV5.Types.TeamState\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState__ctor"></a> TeamState\(\)

```csharp
public TeamState()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_"></a> TeamState\(TeamState\)

```csharp
public TeamState(CMsgSteamLearnMatchStateV5.Types.TeamState other)
```

#### Parameters

`other` [CMsgSteamLearnMatchStateV5](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.Types.md).[TeamState](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.Types.TeamState.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_AncientHealthPctFieldNumber"></a> AncientHealthPctFieldNumber

```csharp
public const int AncientHealthPctFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_BarracksHealthPctFieldNumber"></a> BarracksHealthPctFieldNumber

```csharp
public const int BarracksHealthPctFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_CreepDistanceMidFieldNumber"></a> CreepDistanceMidFieldNumber

```csharp
public const int CreepDistanceMidFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_CreepDistanceOffFieldNumber"></a> CreepDistanceOffFieldNumber

```csharp
public const int CreepDistanceOffFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_CreepDistanceSafeFieldNumber"></a> CreepDistanceSafeFieldNumber

```csharp
public const int CreepDistanceSafeFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_GlyphCooldownFieldNumber"></a> GlyphCooldownFieldNumber

```csharp
public const int GlyphCooldownFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_KillsFieldNumber"></a> KillsFieldNumber

```csharp
public const int KillsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_PlayerStatesFieldNumber"></a> PlayerStatesFieldNumber

```csharp
public const int PlayerStatesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_TowerHealthPctFieldNumber"></a> TowerHealthPctFieldNumber

```csharp
public const int TowerHealthPctFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_AncientHealthPct"></a> AncientHealthPct

```csharp
public uint AncientHealthPct { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_BarracksHealthPct"></a> BarracksHealthPct

```csharp
public RepeatedField<uint> BarracksHealthPct { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_CreepDistanceMid"></a> CreepDistanceMid

```csharp
public uint CreepDistanceMid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_CreepDistanceOff"></a> CreepDistanceOff

```csharp
public uint CreepDistanceOff { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_CreepDistanceSafe"></a> CreepDistanceSafe

```csharp
public uint CreepDistanceSafe { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_GlyphCooldown"></a> GlyphCooldown

```csharp
public uint GlyphCooldown { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_HasAncientHealthPct"></a> HasAncientHealthPct

```csharp
public bool HasAncientHealthPct { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_HasCreepDistanceMid"></a> HasCreepDistanceMid

```csharp
public bool HasCreepDistanceMid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_HasCreepDistanceOff"></a> HasCreepDistanceOff

```csharp
public bool HasCreepDistanceOff { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_HasCreepDistanceSafe"></a> HasCreepDistanceSafe

```csharp
public bool HasCreepDistanceSafe { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_HasGlyphCooldown"></a> HasGlyphCooldown

```csharp
public bool HasGlyphCooldown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_HasKills"></a> HasKills

```csharp
public bool HasKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_Kills"></a> Kills

```csharp
public uint Kills { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnMatchStateV5.Types.TeamState> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnMatchStateV5](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.Types.md).[TeamState](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.Types.TeamState.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_PlayerStates"></a> PlayerStates

```csharp
public RepeatedField<CMsgSteamLearnMatchStateV5.Types.PlayerState> PlayerStates { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearnMatchStateV5](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.Types.md).[PlayerState](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.Types.PlayerState.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_Team"></a> Team

```csharp
public uint Team { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_TowerHealthPct"></a> TowerHealthPct

```csharp
public RepeatedField<uint> TowerHealthPct { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_ClearAncientHealthPct"></a> ClearAncientHealthPct\(\)

```csharp
public void ClearAncientHealthPct()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_ClearCreepDistanceMid"></a> ClearCreepDistanceMid\(\)

```csharp
public void ClearCreepDistanceMid()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_ClearCreepDistanceOff"></a> ClearCreepDistanceOff\(\)

```csharp
public void ClearCreepDistanceOff()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_ClearCreepDistanceSafe"></a> ClearCreepDistanceSafe\(\)

```csharp
public void ClearCreepDistanceSafe()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_ClearGlyphCooldown"></a> ClearGlyphCooldown\(\)

```csharp
public void ClearGlyphCooldown()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_ClearKills"></a> ClearKills\(\)

```csharp
public void ClearKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnMatchStateV5.Types.TeamState Clone()
```

#### Returns

 [CMsgSteamLearnMatchStateV5](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.Types.md).[TeamState](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.Types.TeamState.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_"></a> Equals\(TeamState\)

```csharp
public bool Equals(CMsgSteamLearnMatchStateV5.Types.TeamState other)
```

#### Parameters

`other` [CMsgSteamLearnMatchStateV5](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.Types.md).[TeamState](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.Types.TeamState.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_"></a> MergeFrom\(TeamState\)

```csharp
public void MergeFrom(CMsgSteamLearnMatchStateV5.Types.TeamState other)
```

#### Parameters

`other` [CMsgSteamLearnMatchStateV5](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.Types.md).[TeamState](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.Types.TeamState.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Types_TeamState_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

