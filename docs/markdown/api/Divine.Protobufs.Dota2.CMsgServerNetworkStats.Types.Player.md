# <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player"></a> Class CMsgServerNetworkStats.Types.Player

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerNetworkStats.Types.Player : IMessage<CMsgServerNetworkStats.Types.Player>, IEquatable<CMsgServerNetworkStats.Types.Player>, IDeepCloneable<CMsgServerNetworkStats.Types.Player>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerNetworkStats.Types.Player](Divine.Protobufs.Dota2.CMsgServerNetworkStats.Types.Player.md)

#### Implements

IMessage<CMsgServerNetworkStats.Types.Player\>, 
[IEquatable<CMsgServerNetworkStats.Types.Player\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerNetworkStats.Types.Player\>, 
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
[EnumerableExtensions.In<CMsgServerNetworkStats.Types.Player\>\(CMsgServerNetworkStats.Types.Player, params CMsgServerNetworkStats.Types.Player\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player__ctor"></a> Player\(\)

```csharp
public Player()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player__ctor_Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_"></a> Player\(Player\)

```csharp
public Player(CMsgServerNetworkStats.Types.Player other)
```

#### Parameters

`other` [CMsgServerNetworkStats](Divine.Protobufs.Dota2.CMsgServerNetworkStats.md).[Types](Divine.Protobufs.Dota2.CMsgServerNetworkStats.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerNetworkStats.Types.Player.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_EngineLatencyMsFieldNumber"></a> EngineLatencyMsFieldNumber

```csharp
public const int EngineLatencyMsFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_IsBotFieldNumber"></a> IsBotFieldNumber

```csharp
public const int IsBotFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_LossInFieldNumber"></a> LossInFieldNumber

```csharp
public const int LossInFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_LossOutFieldNumber"></a> LossOutFieldNumber

```csharp
public const int LossOutFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_PacketLossPctFieldNumber"></a> PacketLossPctFieldNumber

```csharp
public const int PacketLossPctFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_PingAvgMsFieldNumber"></a> PingAvgMsFieldNumber

```csharp
public const int PingAvgMsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_RemoteAddrFieldNumber"></a> RemoteAddrFieldNumber

```csharp
public const int RemoteAddrFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_EngineLatencyMs"></a> EngineLatencyMs

```csharp
public int EngineLatencyMs { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_HasEngineLatencyMs"></a> HasEngineLatencyMs

```csharp
public bool HasEngineLatencyMs { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_HasIsBot"></a> HasIsBot

```csharp
public bool HasIsBot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_HasLossIn"></a> HasLossIn

```csharp
public bool HasLossIn { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_HasLossOut"></a> HasLossOut

```csharp
public bool HasLossOut { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_HasPacketLossPct"></a> HasPacketLossPct

```csharp
public bool HasPacketLossPct { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_HasPingAvgMs"></a> HasPingAvgMs

```csharp
public bool HasPingAvgMs { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_HasRemoteAddr"></a> HasRemoteAddr

```csharp
public bool HasRemoteAddr { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_IsBot"></a> IsBot

```csharp
public bool IsBot { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_LossIn"></a> LossIn

```csharp
public float LossIn { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_LossOut"></a> LossOut

```csharp
public float LossOut { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_PacketLossPct"></a> PacketLossPct

```csharp
public float PacketLossPct { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerNetworkStats.Types.Player> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerNetworkStats](Divine.Protobufs.Dota2.CMsgServerNetworkStats.md).[Types](Divine.Protobufs.Dota2.CMsgServerNetworkStats.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerNetworkStats.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_PingAvgMs"></a> PingAvgMs

```csharp
public int PingAvgMs { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_RemoteAddr"></a> RemoteAddr

```csharp
public string RemoteAddr { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_ClearEngineLatencyMs"></a> ClearEngineLatencyMs\(\)

```csharp
public void ClearEngineLatencyMs()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_ClearIsBot"></a> ClearIsBot\(\)

```csharp
public void ClearIsBot()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_ClearLossIn"></a> ClearLossIn\(\)

```csharp
public void ClearLossIn()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_ClearLossOut"></a> ClearLossOut\(\)

```csharp
public void ClearLossOut()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_ClearPacketLossPct"></a> ClearPacketLossPct\(\)

```csharp
public void ClearPacketLossPct()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_ClearPingAvgMs"></a> ClearPingAvgMs\(\)

```csharp
public void ClearPingAvgMs()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_ClearRemoteAddr"></a> ClearRemoteAddr\(\)

```csharp
public void ClearRemoteAddr()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_Clone"></a> Clone\(\)

```csharp
public CMsgServerNetworkStats.Types.Player Clone()
```

#### Returns

 [CMsgServerNetworkStats](Divine.Protobufs.Dota2.CMsgServerNetworkStats.md).[Types](Divine.Protobufs.Dota2.CMsgServerNetworkStats.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerNetworkStats.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_Equals_Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_"></a> Equals\(Player\)

```csharp
public bool Equals(CMsgServerNetworkStats.Types.Player other)
```

#### Parameters

`other` [CMsgServerNetworkStats](Divine.Protobufs.Dota2.CMsgServerNetworkStats.md).[Types](Divine.Protobufs.Dota2.CMsgServerNetworkStats.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerNetworkStats.Types.Player.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_MergeFrom_Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_"></a> MergeFrom\(Player\)

```csharp
public void MergeFrom(CMsgServerNetworkStats.Types.Player other)
```

#### Parameters

`other` [CMsgServerNetworkStats](Divine.Protobufs.Dota2.CMsgServerNetworkStats.md).[Types](Divine.Protobufs.Dota2.CMsgServerNetworkStats.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerNetworkStats.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerNetworkStats_Types_Player_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

