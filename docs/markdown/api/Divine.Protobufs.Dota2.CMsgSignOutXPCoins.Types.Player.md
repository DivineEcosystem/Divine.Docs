# <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player"></a> Class CMsgSignOutXPCoins.Types.Player

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutXPCoins.Types.Player : IMessage<CMsgSignOutXPCoins.Types.Player>, IEquatable<CMsgSignOutXPCoins.Types.Player>, IDeepCloneable<CMsgSignOutXPCoins.Types.Player>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutXPCoins.Types.Player](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.Types.Player.md)

#### Implements

IMessage<CMsgSignOutXPCoins.Types.Player\>, 
[IEquatable<CMsgSignOutXPCoins.Types.Player\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutXPCoins.Types.Player\>, 
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
[EnumerableExtensions.In<CMsgSignOutXPCoins.Types.Player\>\(CMsgSignOutXPCoins.Types.Player, params CMsgSignOutXPCoins.Types.Player\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player__ctor"></a> Player\(\)

```csharp
public Player()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player__ctor_Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_"></a> Player\(Player\)

```csharp
public Player(CMsgSignOutXPCoins.Types.Player other)
```

#### Parameters

`other` [CMsgSignOutXPCoins](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.Types.Player.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_CoinsSpentFieldNumber"></a> CoinsSpentFieldNumber

```csharp
public const int CoinsSpentFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_RankWagerFieldNumber"></a> RankWagerFieldNumber

```csharp
public const int RankWagerFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_WagerStreakFieldNumber"></a> WagerStreakFieldNumber

```csharp
public const int WagerStreakFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_WagerTokenItemIdFieldNumber"></a> WagerTokenItemIdFieldNumber

```csharp
public const int WagerTokenItemIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_XpGainedFieldNumber"></a> XpGainedFieldNumber

```csharp
public const int XpGainedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_CoinsSpent"></a> CoinsSpent

```csharp
public uint CoinsSpent { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_HasCoinsSpent"></a> HasCoinsSpent

```csharp
public bool HasCoinsSpent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_HasRankWager"></a> HasRankWager

```csharp
public bool HasRankWager { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_HasWagerStreak"></a> HasWagerStreak

```csharp
public bool HasWagerStreak { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_HasWagerTokenItemId"></a> HasWagerTokenItemId

```csharp
public bool HasWagerTokenItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_HasXpGained"></a> HasXpGained

```csharp
public bool HasXpGained { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutXPCoins.Types.Player> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutXPCoins](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_RankWager"></a> RankWager

```csharp
public uint RankWager { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_WagerStreak"></a> WagerStreak

```csharp
public uint WagerStreak { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_WagerTokenItemId"></a> WagerTokenItemId

```csharp
public ulong WagerTokenItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_XpGained"></a> XpGained

```csharp
public uint XpGained { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_ClearCoinsSpent"></a> ClearCoinsSpent\(\)

```csharp
public void ClearCoinsSpent()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_ClearRankWager"></a> ClearRankWager\(\)

```csharp
public void ClearRankWager()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_ClearWagerStreak"></a> ClearWagerStreak\(\)

```csharp
public void ClearWagerStreak()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_ClearWagerTokenItemId"></a> ClearWagerTokenItemId\(\)

```csharp
public void ClearWagerTokenItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_ClearXpGained"></a> ClearXpGained\(\)

```csharp
public void ClearXpGained()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutXPCoins.Types.Player Clone()
```

#### Returns

 [CMsgSignOutXPCoins](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_Equals_Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_"></a> Equals\(Player\)

```csharp
public bool Equals(CMsgSignOutXPCoins.Types.Player other)
```

#### Parameters

`other` [CMsgSignOutXPCoins](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.Types.Player.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_"></a> MergeFrom\(Player\)

```csharp
public void MergeFrom(CMsgSignOutXPCoins.Types.Player other)
```

#### Parameters

`other` [CMsgSignOutXPCoins](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Types_Player_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

