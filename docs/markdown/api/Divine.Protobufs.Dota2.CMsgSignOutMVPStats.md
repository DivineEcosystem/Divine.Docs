# <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats"></a> Class CMsgSignOutMVPStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutMVPStats : IMessage<CMsgSignOutMVPStats>, IEquatable<CMsgSignOutMVPStats>, IDeepCloneable<CMsgSignOutMVPStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutMVPStats](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.md)

#### Implements

IMessage<CMsgSignOutMVPStats\>, 
[IEquatable<CMsgSignOutMVPStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutMVPStats\>, 
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
[EnumerableExtensions.In<CMsgSignOutMVPStats\>\(CMsgSignOutMVPStats, params CMsgSignOutMVPStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats__ctor"></a> CMsgSignOutMVPStats\(\)

```csharp
public CMsgSignOutMVPStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats__ctor_Divine_Protobufs_Dota2_CMsgSignOutMVPStats_"></a> CMsgSignOutMVPStats\(CMsgSignOutMVPStats\)

```csharp
public CMsgSignOutMVPStats(CMsgSignOutMVPStats other)
```

#### Parameters

`other` [CMsgSignOutMVPStats](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_GameModeFieldNumber"></a> GameModeFieldNumber

```csharp
public const int GameModeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_GameTimeFieldNumber"></a> GameTimeFieldNumber

```csharp
public const int GameTimeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_WinningTeamFieldNumber"></a> WinningTeamFieldNumber

```csharp
public const int WinningTeamFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_GameMode"></a> GameMode

```csharp
public uint GameMode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_GameTime"></a> GameTime

```csharp
public float GameTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_HasGameMode"></a> HasGameMode

```csharp
public bool HasGameMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_HasGameTime"></a> HasGameTime

```csharp
public bool HasGameTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_HasWinningTeam"></a> HasWinningTeam

```csharp
public bool HasWinningTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutMVPStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutMVPStats](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Players"></a> Players

```csharp
public RepeatedField<CMsgSignOutMVPStats.Types.Player> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgSignOutMVPStats](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_WinningTeam"></a> WinningTeam

```csharp
public uint WinningTeam { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_ClearGameMode"></a> ClearGameMode\(\)

```csharp
public void ClearGameMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_ClearGameTime"></a> ClearGameTime\(\)

```csharp
public void ClearGameTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_ClearWinningTeam"></a> ClearWinningTeam\(\)

```csharp
public void ClearWinningTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutMVPStats Clone()
```

#### Returns

 [CMsgSignOutMVPStats](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Equals_Divine_Protobufs_Dota2_CMsgSignOutMVPStats_"></a> Equals\(CMsgSignOutMVPStats\)

```csharp
public bool Equals(CMsgSignOutMVPStats other)
```

#### Parameters

`other` [CMsgSignOutMVPStats](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutMVPStats_"></a> MergeFrom\(CMsgSignOutMVPStats\)

```csharp
public void MergeFrom(CMsgSignOutMVPStats other)
```

#### Parameters

`other` [CMsgSignOutMVPStats](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

