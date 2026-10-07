# <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer"></a> Class CMsgSignOutGameplayStats.Types.CPlayer

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutGameplayStats.Types.CPlayer : IMessage<CMsgSignOutGameplayStats.Types.CPlayer>, IEquatable<CMsgSignOutGameplayStats.Types.CPlayer>, IDeepCloneable<CMsgSignOutGameplayStats.Types.CPlayer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutGameplayStats.Types.CPlayer](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.CPlayer.md)

#### Implements

IMessage<CMsgSignOutGameplayStats.Types.CPlayer\>, 
[IEquatable<CMsgSignOutGameplayStats.Types.CPlayer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutGameplayStats.Types.CPlayer\>, 
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
[EnumerableExtensions.In<CMsgSignOutGameplayStats.Types.CPlayer\>\(CMsgSignOutGameplayStats.Types.CPlayer, params CMsgSignOutGameplayStats.Types.CPlayer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer__ctor"></a> CPlayer\(\)

```csharp
public CPlayer()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer__ctor_Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_"></a> CPlayer\(CPlayer\)

```csharp
public CPlayer(CMsgSignOutGameplayStats.Types.CPlayer other)
```

#### Parameters

`other` [CMsgSignOutGameplayStats](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.md).[CPlayer](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.CPlayer.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_PlayerSlotFieldNumber"></a> PlayerSlotFieldNumber

```csharp
public const int PlayerSlotFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_TimedPlayerStatsFieldNumber"></a> TimedPlayerStatsFieldNumber

```csharp
public const int TimedPlayerStatsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_HasPlayerSlot"></a> HasPlayerSlot

```csharp
public bool HasPlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_HasSteamId"></a> HasSteamId

```csharp
public bool HasSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutGameplayStats.Types.CPlayer> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutGameplayStats](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.md).[CPlayer](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.CPlayer.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_PlayerSlot"></a> PlayerSlot

```csharp
public uint PlayerSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_SteamId"></a> SteamId

```csharp
public ulong SteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_TimedPlayerStats"></a> TimedPlayerStats

```csharp
public RepeatedField<CMatchPlayerTimedStats> TimedPlayerStats { get; }
```

#### Property Value

 RepeatedField<[CMatchPlayerTimedStats](Divine.Protobufs.Dota2.CMatchPlayerTimedStats.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_ClearPlayerSlot"></a> ClearPlayerSlot\(\)

```csharp
public void ClearPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_ClearSteamId"></a> ClearSteamId\(\)

```csharp
public void ClearSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutGameplayStats.Types.CPlayer Clone()
```

#### Returns

 [CMsgSignOutGameplayStats](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.md).[CPlayer](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.CPlayer.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_Equals_Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_"></a> Equals\(CPlayer\)

```csharp
public bool Equals(CMsgSignOutGameplayStats.Types.CPlayer other)
```

#### Parameters

`other` [CMsgSignOutGameplayStats](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.md).[CPlayer](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.CPlayer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_"></a> MergeFrom\(CPlayer\)

```csharp
public void MergeFrom(CMsgSignOutGameplayStats.Types.CPlayer other)
```

#### Parameters

`other` [CMsgSignOutGameplayStats](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.md).[CPlayer](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.CPlayer.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CPlayer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

