# <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team"></a> Class CMsgDotaScenario.Types.Team

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDotaScenario.Types.Team : IMessage<CMsgDotaScenario.Types.Team>, IEquatable<CMsgDotaScenario.Types.Team>, IDeepCloneable<CMsgDotaScenario.Types.Team>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDotaScenario.Types.Team](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Team.md)

#### Implements

IMessage<CMsgDotaScenario.Types.Team\>, 
[IEquatable<CMsgDotaScenario.Types.Team\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDotaScenario.Types.Team\>, 
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
[EnumerableExtensions.In<CMsgDotaScenario.Types.Team\>\(CMsgDotaScenario.Types.Team, params CMsgDotaScenario.Types.Team\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team__ctor"></a> Team\(\)

```csharp
public Team()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team__ctor_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_"></a> Team\(Team\)

```csharp
public Team(CMsgDotaScenario.Types.Team other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Team.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_BarracksKillsFieldNumber"></a> BarracksKillsFieldNumber

```csharp
public const int BarracksKillsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_GlyphCooldownFieldNumber"></a> GlyphCooldownFieldNumber

```csharp
public const int GlyphCooldownFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_HeroKillsFieldNumber"></a> HeroKillsFieldNumber

```csharp
public const int HeroKillsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_NeutralItemsFieldNumber"></a> NeutralItemsFieldNumber

```csharp
public const int NeutralItemsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_RadarCooldownFieldNumber"></a> RadarCooldownFieldNumber

```csharp
public const int RadarCooldownFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_TeamNumberFieldNumber"></a> TeamNumberFieldNumber

```csharp
public const int TeamNumberFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_TowerKillsFieldNumber"></a> TowerKillsFieldNumber

```csharp
public const int TowerKillsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_BarracksKills"></a> BarracksKills

```csharp
public int BarracksKills { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_GlyphCooldown"></a> GlyphCooldown

```csharp
public float GlyphCooldown { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_HasBarracksKills"></a> HasBarracksKills

```csharp
public bool HasBarracksKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_HasGlyphCooldown"></a> HasGlyphCooldown

```csharp
public bool HasGlyphCooldown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_HasHeroKills"></a> HasHeroKills

```csharp
public bool HasHeroKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_HasRadarCooldown"></a> HasRadarCooldown

```csharp
public bool HasRadarCooldown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_HasTeamNumber"></a> HasTeamNumber

```csharp
public bool HasTeamNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_HasTowerKills"></a> HasTowerKills

```csharp
public bool HasTowerKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_HeroKills"></a> HeroKills

```csharp
public int HeroKills { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_NeutralItems"></a> NeutralItems

```csharp
public RepeatedField<CMsgDotaScenario.Types.TeamNeutralItem> NeutralItems { get; }
```

#### Property Value

 RepeatedField<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[TeamNeutralItem](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.TeamNeutralItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDotaScenario.Types.Team> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Team.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_RadarCooldown"></a> RadarCooldown

```csharp
public float RadarCooldown { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_TeamNumber"></a> TeamNumber

```csharp
public int TeamNumber { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_TowerKills"></a> TowerKills

```csharp
public int TowerKills { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_ClearBarracksKills"></a> ClearBarracksKills\(\)

```csharp
public void ClearBarracksKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_ClearGlyphCooldown"></a> ClearGlyphCooldown\(\)

```csharp
public void ClearGlyphCooldown()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_ClearHeroKills"></a> ClearHeroKills\(\)

```csharp
public void ClearHeroKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_ClearRadarCooldown"></a> ClearRadarCooldown\(\)

```csharp
public void ClearRadarCooldown()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_ClearTeamNumber"></a> ClearTeamNumber\(\)

```csharp
public void ClearTeamNumber()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_ClearTowerKills"></a> ClearTowerKills\(\)

```csharp
public void ClearTowerKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_Clone"></a> Clone\(\)

```csharp
public CMsgDotaScenario.Types.Team Clone()
```

#### Returns

 [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Team.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_Equals_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_"></a> Equals\(Team\)

```csharp
public bool Equals(CMsgDotaScenario.Types.Team other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Team.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_MergeFrom_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_"></a> MergeFrom\(Team\)

```csharp
public void MergeFrom(CMsgDotaScenario.Types.Team other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Team.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Team_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

