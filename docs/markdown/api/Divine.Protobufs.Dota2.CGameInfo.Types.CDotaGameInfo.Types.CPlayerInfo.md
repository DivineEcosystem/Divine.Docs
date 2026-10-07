# <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo"></a> Class CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo : IMessage<CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo>, IEquatable<CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo>, IDeepCloneable<CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo.md)

#### Implements

IMessage<CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo\>, 
[IEquatable<CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo\>, 
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
[EnumerableExtensions.In<CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo\>\(CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo, params CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo__ctor"></a> CPlayerInfo\(\)

```csharp
public CPlayerInfo()
```

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo__ctor_Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_"></a> CPlayerInfo\(CPlayerInfo\)

```csharp
public CPlayerInfo(CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo other)
```

#### Parameters

`other` [CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.md).[CDotaGameInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.md).[CPlayerInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_GameTeamFieldNumber"></a> GameTeamFieldNumber

```csharp
public const int GameTeamFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_HeroNameFieldNumber"></a> HeroNameFieldNumber

```csharp
public const int HeroNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_IsFakeClientFieldNumber"></a> IsFakeClientFieldNumber

```csharp
public const int IsFakeClientFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_PlayerNameFieldNumber"></a> PlayerNameFieldNumber

```csharp
public const int PlayerNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_GameTeam"></a> GameTeam

```csharp
public int GameTeam { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_HasGameTeam"></a> HasGameTeam

```csharp
public bool HasGameTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_HasHeroName"></a> HasHeroName

```csharp
public bool HasHeroName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_HasIsFakeClient"></a> HasIsFakeClient

```csharp
public bool HasIsFakeClient { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_HasPlayerName"></a> HasPlayerName

```csharp
public bool HasPlayerName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_HeroName"></a> HeroName

```csharp
public string HeroName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_IsFakeClient"></a> IsFakeClient

```csharp
public bool IsFakeClient { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_Parser"></a> Parser

```csharp
public static MessageParser<CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.md).[CDotaGameInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.md).[CPlayerInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_PlayerName"></a> PlayerName

```csharp
public string PlayerName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_ClearGameTeam"></a> ClearGameTeam\(\)

```csharp
public void ClearGameTeam()
```

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_ClearHeroName"></a> ClearHeroName\(\)

```csharp
public void ClearHeroName()
```

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_ClearIsFakeClient"></a> ClearIsFakeClient\(\)

```csharp
public void ClearIsFakeClient()
```

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_ClearPlayerName"></a> ClearPlayerName\(\)

```csharp
public void ClearPlayerName()
```

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_Clone"></a> Clone\(\)

```csharp
public CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo Clone()
```

#### Returns

 [CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.md).[CDotaGameInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.md).[CPlayerInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo.md)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_Equals_Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_"></a> Equals\(CPlayerInfo\)

```csharp
public bool Equals(CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo other)
```

#### Parameters

`other` [CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.md).[CDotaGameInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.md).[CPlayerInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_MergeFrom_Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_"></a> MergeFrom\(CPlayerInfo\)

```csharp
public void MergeFrom(CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo other)
```

#### Parameters

`other` [CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.md).[CDotaGameInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.md).[CPlayerInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.CPlayerInfo.md)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CPlayerInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

