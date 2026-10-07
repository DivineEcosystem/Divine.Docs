# <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player"></a> Class CMsgPoorNetworkConditions.Types.Player

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPoorNetworkConditions.Types.Player : IMessage<CMsgPoorNetworkConditions.Types.Player>, IEquatable<CMsgPoorNetworkConditions.Types.Player>, IDeepCloneable<CMsgPoorNetworkConditions.Types.Player>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPoorNetworkConditions.Types.Player](Divine.Protobufs.Dota2.CMsgPoorNetworkConditions.Types.Player.md)

#### Implements

IMessage<CMsgPoorNetworkConditions.Types.Player\>, 
[IEquatable<CMsgPoorNetworkConditions.Types.Player\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPoorNetworkConditions.Types.Player\>, 
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
[EnumerableExtensions.In<CMsgPoorNetworkConditions.Types.Player\>\(CMsgPoorNetworkConditions.Types.Player, params CMsgPoorNetworkConditions.Types.Player\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player__ctor"></a> Player\(\)

```csharp
public Player()
```

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player__ctor_Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_"></a> Player\(Player\)

```csharp
public Player(CMsgPoorNetworkConditions.Types.Player other)
```

#### Parameters

`other` [CMsgPoorNetworkConditions](Divine.Protobufs.Dota2.CMsgPoorNetworkConditions.md).[Types](Divine.Protobufs.Dota2.CMsgPoorNetworkConditions.Types.md).[Player](Divine.Protobufs.Dota2.CMsgPoorNetworkConditions.Types.Player.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_DisconnectReasonFieldNumber"></a> DisconnectReasonFieldNumber

```csharp
public const int DisconnectReasonFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_NumBadIntervalsFieldNumber"></a> NumBadIntervalsFieldNumber

```csharp
public const int NumBadIntervalsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_PeakLossPctFieldNumber"></a> PeakLossPctFieldNumber

```csharp
public const int PeakLossPctFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_DisconnectReason"></a> DisconnectReason

```csharp
public ENetworkDisconnectionReason DisconnectReason { get; set; }
```

#### Property Value

 [ENetworkDisconnectionReason](Divine.Protobufs.Dota2.ENetworkDisconnectionReason.md)

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_HasDisconnectReason"></a> HasDisconnectReason

```csharp
public bool HasDisconnectReason { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_HasNumBadIntervals"></a> HasNumBadIntervals

```csharp
public bool HasNumBadIntervals { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_HasPeakLossPct"></a> HasPeakLossPct

```csharp
public bool HasPeakLossPct { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_NumBadIntervals"></a> NumBadIntervals

```csharp
public uint NumBadIntervals { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPoorNetworkConditions.Types.Player> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPoorNetworkConditions](Divine.Protobufs.Dota2.CMsgPoorNetworkConditions.md).[Types](Divine.Protobufs.Dota2.CMsgPoorNetworkConditions.Types.md).[Player](Divine.Protobufs.Dota2.CMsgPoorNetworkConditions.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_PeakLossPct"></a> PeakLossPct

```csharp
public uint PeakLossPct { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_ClearDisconnectReason"></a> ClearDisconnectReason\(\)

```csharp
public void ClearDisconnectReason()
```

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_ClearNumBadIntervals"></a> ClearNumBadIntervals\(\)

```csharp
public void ClearNumBadIntervals()
```

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_ClearPeakLossPct"></a> ClearPeakLossPct\(\)

```csharp
public void ClearPeakLossPct()
```

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_Clone"></a> Clone\(\)

```csharp
public CMsgPoorNetworkConditions.Types.Player Clone()
```

#### Returns

 [CMsgPoorNetworkConditions](Divine.Protobufs.Dota2.CMsgPoorNetworkConditions.md).[Types](Divine.Protobufs.Dota2.CMsgPoorNetworkConditions.Types.md).[Player](Divine.Protobufs.Dota2.CMsgPoorNetworkConditions.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_Equals_Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_"></a> Equals\(Player\)

```csharp
public bool Equals(CMsgPoorNetworkConditions.Types.Player other)
```

#### Parameters

`other` [CMsgPoorNetworkConditions](Divine.Protobufs.Dota2.CMsgPoorNetworkConditions.md).[Types](Divine.Protobufs.Dota2.CMsgPoorNetworkConditions.Types.md).[Player](Divine.Protobufs.Dota2.CMsgPoorNetworkConditions.Types.Player.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_MergeFrom_Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_"></a> MergeFrom\(Player\)

```csharp
public void MergeFrom(CMsgPoorNetworkConditions.Types.Player other)
```

#### Parameters

`other` [CMsgPoorNetworkConditions](Divine.Protobufs.Dota2.CMsgPoorNetworkConditions.md).[Types](Divine.Protobufs.Dota2.CMsgPoorNetworkConditions.Types.md).[Player](Divine.Protobufs.Dota2.CMsgPoorNetworkConditions.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPoorNetworkConditions_Types_Player_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

