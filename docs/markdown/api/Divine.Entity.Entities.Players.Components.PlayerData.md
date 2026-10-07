# <a id="Divine_Entity_Entities_Players_Components_PlayerData"></a> Class PlayerData

Namespace: [Divine.Entity.Entities.Players.Components](Divine.Entity.Entities.Players.Components.md)  
Assembly: Divine.dll  

```csharp
public sealed class PlayerData : IEquatable<PlayerData>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PlayerData](Divine.Entity.Entities.Players.Components.PlayerData.md)

#### Implements

[IEquatable<PlayerData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<PlayerData\>\(PlayerData, params PlayerData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_Assists"></a> Assists

```csharp
public int Assists { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_BattleBonusRate"></a> BattleBonusRate

```csharp
public uint BattleBonusRate { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_BehaviorLevel"></a> BehaviorLevel

```csharp
public int BehaviorLevel { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_BountyRunes"></a> BountyRunes

```csharp
public byte BountyRunes { get; }
```

#### Property Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_CanEarnRewards"></a> CanEarnRewards

```csharp
public bool CanEarnRewards { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_CanRepick"></a> CanRepick

```csharp
public bool CanRepick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_CommLevel"></a> CommLevel

```csharp
public int CommLevel { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_CompendiumLevel"></a> CompendiumLevel

```csharp
public ushort CompendiumLevel { get; }
```

#### Property Value

 [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_ConnectionState"></a> ConnectionState

```csharp
public ConnectionState ConnectionState { get; }
```

#### Property Value

 [ConnectionState](Divine.Entity.Entities.Players.Components.ConnectionState.md)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_CustomBuybackCost"></a> CustomBuybackCost

```csharp
public int CustomBuybackCost { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_CustomPlayerColor"></a> CustomPlayerColor

```csharp
public Color CustomPlayerColor { get; }
```

#### Property Value

 [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_Deaths"></a> Deaths

```csharp
public int Deaths { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_FirstBloodClaimed"></a> FirstBloodClaimed

```csharp
public int FirstBloodClaimed { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_FirstBloodGiven"></a> FirstBloodGiven

```csharp
public int FirstBloodGiven { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_FowTeam"></a> FowTeam

```csharp
public byte FowTeam { get; }
```

#### Property Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_GeneralData"></a> GeneralData

```csharp
public nint GeneralData { get; }
```

#### Property Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_HasRandomed"></a> HasRandomed

```csharp
public bool HasRandomed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_Id"></a> Id

```csharp
public int Id { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_IsAFK"></a> IsAFK

```csharp
public bool IsAFK { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_IsBattleBonusActive"></a> IsBattleBonusActive

```csharp
public bool IsBattleBonusActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_IsBot"></a> IsBot

```csharp
public bool IsBot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_IsBroadcaster"></a> IsBroadcaster

```csharp
public bool IsBroadcaster { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_IsFakeClient"></a> IsFakeClient

```csharp
public bool IsFakeClient { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_IsFullyJoinedServer"></a> IsFullyJoinedServer

```csharp
public bool IsFullyJoinedServer { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_IsPlusSubscriber"></a> IsPlusSubscriber

```csharp
public bool IsPlusSubscriber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_IsPredictingVictory"></a> IsPredictingVictory

```csharp
public bool IsPredictingVictory { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_Kills"></a> Kills

```csharp
public int Kills { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_KillStreak"></a> KillStreak

```csharp
public int KillStreak { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_LaneSelectionFlags"></a> LaneSelectionFlags

```csharp
public LaneSelectionFlags LaneSelectionFlags { get; }
```

#### Property Value

 [LaneSelectionFlags](Divine.Entity.Entities.Players.Components.LaneSelectionFlags.md)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_LastBuybackTime"></a> LastBuybackTime

```csharp
public float LastBuybackTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_LastCommsTime"></a> LastCommsTime

```csharp
public float LastCommsTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_Level"></a> Level

```csharp
public int Level { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_OutpostsCaptured"></a> OutpostsCaptured

```csharp
public byte OutpostsCaptured { get; }
```

#### Property Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_PickOrder"></a> PickOrder

```csharp
public uint PickOrder { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_PlayerDraftPreferredRoles"></a> PlayerDraftPreferredRoles

```csharp
public LaneSelectionFlags PlayerDraftPreferredRoles { get; }
```

#### Property Value

 [LaneSelectionFlags](Divine.Entity.Entities.Players.Components.LaneSelectionFlags.md)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_PlayerDraftPreferredTeam"></a> PlayerDraftPreferredTeam

```csharp
public sbyte PlayerDraftPreferredTeam { get; }
```

#### Property Value

 [sbyte](https://learn.microsoft.com/dotnet/api/system.sbyte)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_PlayerSlot"></a> PlayerSlot

```csharp
public byte PlayerSlot { get; }
```

#### Property Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_PowerRunes"></a> PowerRunes

```csharp
public byte PowerRunes { get; }
```

#### Property Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_RandomedHeroId"></a> RandomedHeroId

```csharp
public HeroId RandomedHeroId { get; }
```

#### Property Value

 [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_RankTier"></a> RankTier

```csharp
public int RankTier { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_RespawnSeconds"></a> RespawnSeconds

```csharp
public int RespawnSeconds { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_SelectedHero"></a> SelectedHero

```csharp
[JsonIgnore]
public Hero? SelectedHero { get; }
```

#### Property Value

 [Hero](Divine.Entity.Entities.Units.Heroes.Hero.md)?

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_SelectedHeroBadgeXP"></a> SelectedHeroBadgeXP

```csharp
public uint SelectedHeroBadgeXP { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_SelectedHeroFacet"></a> SelectedHeroFacet

```csharp
public uint SelectedHeroFacet { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_SelectedHeroId"></a> SelectedHeroId

```csharp
public HeroId SelectedHeroId { get; }
```

#### Property Value

 [HeroId](Divine.Entity.Entities.Units.Heroes.Components.HeroId.md)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_SteamId"></a> SteamId

```csharp
public uint SteamId { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_Team"></a> Team

```csharp
public Team Team { get; }
```

#### Property Value

 [Team](Divine.Entity.Entities.Components.Team.md)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_TeamData"></a> TeamData

```csharp
public nint TeamData { get; }
```

#### Property Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_TeamSlot"></a> TeamSlot

```csharp
public int TeamSlot { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_WaterRunes"></a> WaterRunes

```csharp
public byte WaterRunes { get; }
```

#### Property Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

## Methods

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_Equals_System_Object_"></a> Equals\(object?\)

Determines whether the specified object is equal to the current object.

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The object to compare with the current object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the specified object  is equal to the current object; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_Equals_Divine_Entity_Entities_Players_Components_PlayerData_"></a> Equals\(PlayerData?\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(PlayerData? other)
```

#### Parameters

`other` [PlayerData](Divine.Entity.Entities.Players.Components.PlayerData.md)?

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_GetHashCode"></a> GetHashCode\(\)

Serves as the default hash function.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A hash code for the current object.

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

## Operators

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_op_Equality_Divine_Entity_Entities_Players_Components_PlayerData_Divine_Entity_Entities_Players_Components_PlayerData_"></a> operator ==\(PlayerData?, PlayerData?\)

```csharp
public static bool operator ==(PlayerData? left, PlayerData? right)
```

#### Parameters

`left` [PlayerData](Divine.Entity.Entities.Players.Components.PlayerData.md)?

`right` [PlayerData](Divine.Entity.Entities.Players.Components.PlayerData.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Entity_Entities_Players_Components_PlayerData_op_Inequality_Divine_Entity_Entities_Players_Components_PlayerData_Divine_Entity_Entities_Players_Components_PlayerData_"></a> operator \!=\(PlayerData?, PlayerData?\)

```csharp
public static bool operator !=(PlayerData? left, PlayerData? right)
```

#### Parameters

`left` [PlayerData](Divine.Entity.Entities.Players.Components.PlayerData.md)?

`right` [PlayerData](Divine.Entity.Entities.Players.Components.PlayerData.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

