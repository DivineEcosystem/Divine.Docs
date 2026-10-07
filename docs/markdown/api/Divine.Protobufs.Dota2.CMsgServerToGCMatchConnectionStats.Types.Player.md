# <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player"></a> Class CMsgServerToGCMatchConnectionStats.Types.Player

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCMatchConnectionStats.Types.Player : IMessage<CMsgServerToGCMatchConnectionStats.Types.Player>, IEquatable<CMsgServerToGCMatchConnectionStats.Types.Player>, IDeepCloneable<CMsgServerToGCMatchConnectionStats.Types.Player>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCMatchConnectionStats.Types.Player](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.Types.Player.md)

#### Implements

IMessage<CMsgServerToGCMatchConnectionStats.Types.Player\>, 
[IEquatable<CMsgServerToGCMatchConnectionStats.Types.Player\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCMatchConnectionStats.Types.Player\>, 
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
[EnumerableExtensions.In<CMsgServerToGCMatchConnectionStats.Types.Player\>\(CMsgServerToGCMatchConnectionStats.Types.Player, params CMsgServerToGCMatchConnectionStats.Types.Player\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player__ctor"></a> Player\(\)

```csharp
public Player()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player__ctor_Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_"></a> Player\(Player\)

```csharp
public Player(CMsgServerToGCMatchConnectionStats.Types.Player other)
```

#### Parameters

`other` [CMsgServerToGCMatchConnectionStats](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.Types.Player.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_AvgPingMsFieldNumber"></a> AvgPingMsFieldNumber

```csharp
public const int AvgPingMsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_FullResendsFieldNumber"></a> FullResendsFieldNumber

```csharp
public const int FullResendsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_IpFieldNumber"></a> IpFieldNumber

```csharp
public const int IpFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_PacketLossFieldNumber"></a> PacketLossFieldNumber

```csharp
public const int PacketLossFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_PingDeviationFieldNumber"></a> PingDeviationFieldNumber

```csharp
public const int PingDeviationFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_AvgPingMs"></a> AvgPingMs

```csharp
public uint AvgPingMs { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_FullResends"></a> FullResends

```csharp
public uint FullResends { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_HasAvgPingMs"></a> HasAvgPingMs

```csharp
public bool HasAvgPingMs { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_HasFullResends"></a> HasFullResends

```csharp
public bool HasFullResends { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_HasIp"></a> HasIp

```csharp
public bool HasIp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_HasPacketLoss"></a> HasPacketLoss

```csharp
public bool HasPacketLoss { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_HasPingDeviation"></a> HasPingDeviation

```csharp
public bool HasPingDeviation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_Ip"></a> Ip

```csharp
public uint Ip { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_PacketLoss"></a> PacketLoss

```csharp
public float PacketLoss { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCMatchConnectionStats.Types.Player> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCMatchConnectionStats](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_PingDeviation"></a> PingDeviation

```csharp
public float PingDeviation { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_ClearAvgPingMs"></a> ClearAvgPingMs\(\)

```csharp
public void ClearAvgPingMs()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_ClearFullResends"></a> ClearFullResends\(\)

```csharp
public void ClearFullResends()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_ClearIp"></a> ClearIp\(\)

```csharp
public void ClearIp()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_ClearPacketLoss"></a> ClearPacketLoss\(\)

```csharp
public void ClearPacketLoss()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_ClearPingDeviation"></a> ClearPingDeviation\(\)

```csharp
public void ClearPingDeviation()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCMatchConnectionStats.Types.Player Clone()
```

#### Returns

 [CMsgServerToGCMatchConnectionStats](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_Equals_Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_"></a> Equals\(Player\)

```csharp
public bool Equals(CMsgServerToGCMatchConnectionStats.Types.Player other)
```

#### Parameters

`other` [CMsgServerToGCMatchConnectionStats](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.Types.Player.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_"></a> MergeFrom\(Player\)

```csharp
public void MergeFrom(CMsgServerToGCMatchConnectionStats.Types.Player other)
```

#### Parameters

`other` [CMsgServerToGCMatchConnectionStats](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerToGCMatchConnectionStats.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCMatchConnectionStats_Types_Player_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

