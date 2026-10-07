# <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player"></a> Class CMsgMonsterHunterMatchRewards.Types.Player

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMonsterHunterMatchRewards.Types.Player : IMessage<CMsgMonsterHunterMatchRewards.Types.Player>, IEquatable<CMsgMonsterHunterMatchRewards.Types.Player>, IDeepCloneable<CMsgMonsterHunterMatchRewards.Types.Player>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMonsterHunterMatchRewards.Types.Player](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.md)

#### Implements

IMessage<CMsgMonsterHunterMatchRewards.Types.Player\>, 
[IEquatable<CMsgMonsterHunterMatchRewards.Types.Player\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMonsterHunterMatchRewards.Types.Player\>, 
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
[EnumerableExtensions.In<CMsgMonsterHunterMatchRewards.Types.Player\>\(CMsgMonsterHunterMatchRewards.Types.Player, params CMsgMonsterHunterMatchRewards.Types.Player\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player__ctor"></a> Player\(\)

```csharp
public Player()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player__ctor_Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_"></a> Player\(Player\)

```csharp
public Player(CMsgMonsterHunterMatchRewards.Types.Player other)
```

#### Parameters

`other` [CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.md).[Player](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_ActualMatchRewardMaterialsFieldNumber"></a> ActualMatchRewardMaterialsFieldNumber

```csharp
public const int ActualMatchRewardMaterialsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_DenialRewardsFieldNumber"></a> DenialRewardsFieldNumber

```csharp
public const int DenialRewardsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_HunterDuelFieldNumber"></a> HunterDuelFieldNumber

```csharp
public const int HunterDuelFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_HuntRewardFieldNumber"></a> HuntRewardFieldNumber

```csharp
public const int HuntRewardFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_PlayerSlotFieldNumber"></a> PlayerSlotFieldNumber

```csharp
public const int PlayerSlotFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_PossibleMatchRewardMaterialsFieldNumber"></a> PossibleMatchRewardMaterialsFieldNumber

```csharp
public const int PossibleMatchRewardMaterialsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_ActualMatchRewardMaterials"></a> ActualMatchRewardMaterials

```csharp
public CMsgMonsterHunterMaterialQuantity ActualMatchRewardMaterials { get; set; }
```

#### Property Value

 [CMsgMonsterHunterMaterialQuantity](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_DenialRewards"></a> DenialRewards

```csharp
public RepeatedField<CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward> DenialRewards { get; }
```

#### Property Value

 RepeatedField<[CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.md).[Player](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.Types.md).[HuntReward](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_HasHunterDuel"></a> HasHunterDuel

```csharp
public bool HasHunterDuel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_HasPlayerSlot"></a> HasPlayerSlot

```csharp
public bool HasPlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_HunterDuel"></a> HunterDuel

```csharp
public bool HunterDuel { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_HuntReward"></a> HuntReward

```csharp
public CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward HuntReward { get; set; }
```

#### Property Value

 [CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.md).[Player](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.Types.md).[HuntReward](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMonsterHunterMatchRewards.Types.Player> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.md).[Player](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_PlayerSlot"></a> PlayerSlot

```csharp
public uint PlayerSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_PossibleMatchRewardMaterials"></a> PossibleMatchRewardMaterials

```csharp
public CMsgMonsterHunterMaterialQuantity PossibleMatchRewardMaterials { get; set; }
```

#### Property Value

 [CMsgMonsterHunterMaterialQuantity](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialQuantity.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_ClearHunterDuel"></a> ClearHunterDuel\(\)

```csharp
public void ClearHunterDuel()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_ClearPlayerSlot"></a> ClearPlayerSlot\(\)

```csharp
public void ClearPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Clone"></a> Clone\(\)

```csharp
public CMsgMonsterHunterMatchRewards.Types.Player Clone()
```

#### Returns

 [CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.md).[Player](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Equals_Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_"></a> Equals\(Player\)

```csharp
public bool Equals(CMsgMonsterHunterMatchRewards.Types.Player other)
```

#### Parameters

`other` [CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.md).[Player](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_MergeFrom_Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_"></a> MergeFrom\(Player\)

```csharp
public void MergeFrom(CMsgMonsterHunterMatchRewards.Types.Player other)
```

#### Parameters

`other` [CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.md).[Player](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

