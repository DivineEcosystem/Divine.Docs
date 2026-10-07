# <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails"></a> Class CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails : IMessage<CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails>, IEquatable<CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails>, IDeepCloneable<CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails.md)

#### Implements

IMessage<CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails\>, 
[IEquatable<CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails\>, 
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
[EnumerableExtensions.In<CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails\>\(CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails, params CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails__ctor"></a> PlayerDetails\(\)

```csharp
public PlayerDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails__ctor_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_"></a> PlayerDetails\(PlayerDetails\)

```csharp
public PlayerDetails(CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[PlayerDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_AbilitiesFieldNumber"></a> AbilitiesFieldNumber

```csharp
public const int AbilitiesFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_AccountidFieldNumber"></a> AccountidFieldNumber

```csharp
public const int AccountidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_AssistsCountFieldNumber"></a> AssistsCountFieldNumber

```csharp
public const int AssistsCountFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_DeathCountFieldNumber"></a> DeathCountFieldNumber

```csharp
public const int DeathCountFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_DeniesCountFieldNumber"></a> DeniesCountFieldNumber

```csharp
public const int DeniesCountFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_GoldFieldNumber"></a> GoldFieldNumber

```csharp
public const int GoldFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_HeroidFieldNumber"></a> HeroidFieldNumber

```csharp
public const int HeroidFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_ItemsFieldNumber"></a> ItemsFieldNumber

```csharp
public const int ItemsFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_KillCountFieldNumber"></a> KillCountFieldNumber

```csharp
public const int KillCountFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_LevelFieldNumber"></a> LevelFieldNumber

```csharp
public const int LevelFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_LhCountFieldNumber"></a> LhCountFieldNumber

```csharp
public const int LhCountFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_NetWorthFieldNumber"></a> NetWorthFieldNumber

```csharp
public const int NetWorthFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_PlayeridFieldNumber"></a> PlayeridFieldNumber

```csharp
public const int PlayeridFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_TeamSlotFieldNumber"></a> TeamSlotFieldNumber

```csharp
public const int TeamSlotFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_XFieldNumber"></a> XFieldNumber

```csharp
public const int XFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_YFieldNumber"></a> YFieldNumber

```csharp
public const int YFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_Abilities"></a> Abilities

```csharp
public RepeatedField<int> Abilities { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_Accountid"></a> Accountid

```csharp
public uint Accountid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_AssistsCount"></a> AssistsCount

```csharp
public uint AssistsCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_DeathCount"></a> DeathCount

```csharp
public uint DeathCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_DeniesCount"></a> DeniesCount

```csharp
public uint DeniesCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_Gold"></a> Gold

```csharp
public uint Gold { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_HasAccountid"></a> HasAccountid

```csharp
public bool HasAccountid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_HasAssistsCount"></a> HasAssistsCount

```csharp
public bool HasAssistsCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_HasDeathCount"></a> HasDeathCount

```csharp
public bool HasDeathCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_HasDeniesCount"></a> HasDeniesCount

```csharp
public bool HasDeniesCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_HasGold"></a> HasGold

```csharp
public bool HasGold { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_HasHeroid"></a> HasHeroid

```csharp
public bool HasHeroid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_HasKillCount"></a> HasKillCount

```csharp
public bool HasKillCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_HasLevel"></a> HasLevel

```csharp
public bool HasLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_HasLhCount"></a> HasLhCount

```csharp
public bool HasLhCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_HasNetWorth"></a> HasNetWorth

```csharp
public bool HasNetWorth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_HasPlayerid"></a> HasPlayerid

```csharp
public bool HasPlayerid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_HasTeamSlot"></a> HasTeamSlot

```csharp
public bool HasTeamSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_HasX"></a> HasX

```csharp
public bool HasX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_HasY"></a> HasY

```csharp
public bool HasY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_Heroid"></a> Heroid

```csharp
public int Heroid { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_Items"></a> Items

```csharp
public RepeatedField<int> Items { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_KillCount"></a> KillCount

```csharp
public uint KillCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_Level"></a> Level

```csharp
public uint Level { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_LhCount"></a> LhCount

```csharp
public uint LhCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_NetWorth"></a> NetWorth

```csharp
public uint NetWorth { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[PlayerDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_Playerid"></a> Playerid

```csharp
public int Playerid { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_Team"></a> Team

```csharp
public uint Team { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_TeamSlot"></a> TeamSlot

```csharp
public uint TeamSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_X"></a> X

```csharp
public float X { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_Y"></a> Y

```csharp
public float Y { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_ClearAccountid"></a> ClearAccountid\(\)

```csharp
public void ClearAccountid()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_ClearAssistsCount"></a> ClearAssistsCount\(\)

```csharp
public void ClearAssistsCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_ClearDeathCount"></a> ClearDeathCount\(\)

```csharp
public void ClearDeathCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_ClearDeniesCount"></a> ClearDeniesCount\(\)

```csharp
public void ClearDeniesCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_ClearGold"></a> ClearGold\(\)

```csharp
public void ClearGold()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_ClearHeroid"></a> ClearHeroid\(\)

```csharp
public void ClearHeroid()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_ClearKillCount"></a> ClearKillCount\(\)

```csharp
public void ClearKillCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_ClearLevel"></a> ClearLevel\(\)

```csharp
public void ClearLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_ClearLhCount"></a> ClearLhCount\(\)

```csharp
public void ClearLhCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_ClearNetWorth"></a> ClearNetWorth\(\)

```csharp
public void ClearNetWorth()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_ClearPlayerid"></a> ClearPlayerid\(\)

```csharp
public void ClearPlayerid()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_ClearTeamSlot"></a> ClearTeamSlot\(\)

```csharp
public void ClearTeamSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_ClearX"></a> ClearX\(\)

```csharp
public void ClearX()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_ClearY"></a> ClearY\(\)

```csharp
public void ClearY()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails Clone()
```

#### Returns

 [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[PlayerDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_Equals_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_"></a> Equals\(PlayerDetails\)

```csharp
public bool Equals(CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[PlayerDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_"></a> MergeFrom\(PlayerDetails\)

```csharp
public void MergeFrom(CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[PlayerDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PlayerDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

