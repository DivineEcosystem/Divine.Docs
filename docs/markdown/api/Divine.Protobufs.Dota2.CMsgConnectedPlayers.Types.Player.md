# <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player"></a> Class CMsgConnectedPlayers.Types.Player

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgConnectedPlayers.Types.Player : IMessage<CMsgConnectedPlayers.Types.Player>, IEquatable<CMsgConnectedPlayers.Types.Player>, IDeepCloneable<CMsgConnectedPlayers.Types.Player>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgConnectedPlayers.Types.Player](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.Player.md)

#### Implements

IMessage<CMsgConnectedPlayers.Types.Player\>, 
[IEquatable<CMsgConnectedPlayers.Types.Player\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgConnectedPlayers.Types.Player\>, 
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
[EnumerableExtensions.In<CMsgConnectedPlayers.Types.Player\>\(CMsgConnectedPlayers.Types.Player, params CMsgConnectedPlayers.Types.Player\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player__ctor"></a> Player\(\)

```csharp
public Player()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player__ctor_Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_"></a> Player\(Player\)

```csharp
public Player(CMsgConnectedPlayers.Types.Player other)
```

#### Parameters

`other` [CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md).[Types](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.md).[Player](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.Player.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_DisconnectReasonFieldNumber"></a> DisconnectReasonFieldNumber

```csharp
public const int DisconnectReasonFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_LeaverStateFieldNumber"></a> LeaverStateFieldNumber

```csharp
public const int LeaverStateFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_DisconnectReason"></a> DisconnectReason

```csharp
public ENetworkDisconnectionReason DisconnectReason { get; set; }
```

#### Property Value

 [ENetworkDisconnectionReason](Divine.Protobufs.Dota2.ENetworkDisconnectionReason.md)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_HasDisconnectReason"></a> HasDisconnectReason

```csharp
public bool HasDisconnectReason { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_HasSteamId"></a> HasSteamId

```csharp
public bool HasSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_LeaverState"></a> LeaverState

```csharp
public CMsgLeaverState LeaverState { get; set; }
```

#### Property Value

 [CMsgLeaverState](Divine.Protobufs.Dota2.CMsgLeaverState.md)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_Parser"></a> Parser

```csharp
public static MessageParser<CMsgConnectedPlayers.Types.Player> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md).[Types](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.md).[Player](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_SteamId"></a> SteamId

```csharp
public ulong SteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_ClearDisconnectReason"></a> ClearDisconnectReason\(\)

```csharp
public void ClearDisconnectReason()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_ClearSteamId"></a> ClearSteamId\(\)

```csharp
public void ClearSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_Clone"></a> Clone\(\)

```csharp
public CMsgConnectedPlayers.Types.Player Clone()
```

#### Returns

 [CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md).[Types](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.md).[Player](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_Equals_Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_"></a> Equals\(Player\)

```csharp
public bool Equals(CMsgConnectedPlayers.Types.Player other)
```

#### Parameters

`other` [CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md).[Types](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.md).[Player](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.Player.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_MergeFrom_Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_"></a> MergeFrom\(Player\)

```csharp
public void MergeFrom(CMsgConnectedPlayers.Types.Player other)
```

#### Parameters

`other` [CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md).[Types](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.md).[Player](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_Player_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

