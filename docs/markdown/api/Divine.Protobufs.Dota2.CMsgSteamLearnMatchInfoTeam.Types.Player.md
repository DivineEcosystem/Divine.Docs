# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player"></a> Class CMsgSteamLearnMatchInfoTeam.Types.Player

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnMatchInfoTeam.Types.Player : IMessage<CMsgSteamLearnMatchInfoTeam.Types.Player>, IEquatable<CMsgSteamLearnMatchInfoTeam.Types.Player>, IDeepCloneable<CMsgSteamLearnMatchInfoTeam.Types.Player>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnMatchInfoTeam.Types.Player](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.Types.Player.md)

#### Implements

IMessage<CMsgSteamLearnMatchInfoTeam.Types.Player\>, 
[IEquatable<CMsgSteamLearnMatchInfoTeam.Types.Player\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnMatchInfoTeam.Types.Player\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnMatchInfoTeam.Types.Player\>\(CMsgSteamLearnMatchInfoTeam.Types.Player, params CMsgSteamLearnMatchInfoTeam.Types.Player\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player__ctor"></a> Player\(\)

```csharp
public Player()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_"></a> Player\(Player\)

```csharp
public Player(CMsgSteamLearnMatchInfoTeam.Types.Player other)
```

#### Parameters

`other` [CMsgSteamLearnMatchInfoTeam](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.Types.Player.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_NumPlayersInPartyFieldNumber"></a> NumPlayersInPartyFieldNumber

```csharp
public const int NumPlayersInPartyFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_PrematchBehaviorScoreFieldNumber"></a> PrematchBehaviorScoreFieldNumber

```csharp
public const int PrematchBehaviorScoreFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_PrematchCommScoreFieldNumber"></a> PrematchCommScoreFieldNumber

```csharp
public const int PrematchCommScoreFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_PrematchMmrFieldNumber"></a> PrematchMmrFieldNumber

```csharp
public const int PrematchMmrFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_PrematchRankUncertaintyFieldNumber"></a> PrematchRankUncertaintyFieldNumber

```csharp
public const int PrematchRankUncertaintyFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_HasNumPlayersInParty"></a> HasNumPlayersInParty

```csharp
public bool HasNumPlayersInParty { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_HasPrematchBehaviorScore"></a> HasPrematchBehaviorScore

```csharp
public bool HasPrematchBehaviorScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_HasPrematchCommScore"></a> HasPrematchCommScore

```csharp
public bool HasPrematchCommScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_HasPrematchMmr"></a> HasPrematchMmr

```csharp
public bool HasPrematchMmr { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_HasPrematchRankUncertainty"></a> HasPrematchRankUncertainty

```csharp
public bool HasPrematchRankUncertainty { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_NumPlayersInParty"></a> NumPlayersInParty

```csharp
public uint NumPlayersInParty { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnMatchInfoTeam.Types.Player> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnMatchInfoTeam](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_PrematchBehaviorScore"></a> PrematchBehaviorScore

```csharp
public uint PrematchBehaviorScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_PrematchCommScore"></a> PrematchCommScore

```csharp
public uint PrematchCommScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_PrematchMmr"></a> PrematchMmr

```csharp
public uint PrematchMmr { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_PrematchRankUncertainty"></a> PrematchRankUncertainty

```csharp
public uint PrematchRankUncertainty { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_ClearNumPlayersInParty"></a> ClearNumPlayersInParty\(\)

```csharp
public void ClearNumPlayersInParty()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_ClearPrematchBehaviorScore"></a> ClearPrematchBehaviorScore\(\)

```csharp
public void ClearPrematchBehaviorScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_ClearPrematchCommScore"></a> ClearPrematchCommScore\(\)

```csharp
public void ClearPrematchCommScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_ClearPrematchMmr"></a> ClearPrematchMmr\(\)

```csharp
public void ClearPrematchMmr()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_ClearPrematchRankUncertainty"></a> ClearPrematchRankUncertainty\(\)

```csharp
public void ClearPrematchRankUncertainty()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnMatchInfoTeam.Types.Player Clone()
```

#### Returns

 [CMsgSteamLearnMatchInfoTeam](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_"></a> Equals\(Player\)

```csharp
public bool Equals(CMsgSteamLearnMatchInfoTeam.Types.Player other)
```

#### Parameters

`other` [CMsgSteamLearnMatchInfoTeam](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.Types.Player.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_"></a> MergeFrom\(Player\)

```csharp
public void MergeFrom(CMsgSteamLearnMatchInfoTeam.Types.Player other)
```

#### Parameters

`other` [CMsgSteamLearnMatchInfoTeam](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Types_Player_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

