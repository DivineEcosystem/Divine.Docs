# <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player"></a> Class CMsgOverworldMatchRewards.Types.Player

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgOverworldMatchRewards.Types.Player : IMessage<CMsgOverworldMatchRewards.Types.Player>, IEquatable<CMsgOverworldMatchRewards.Types.Player>, IDeepCloneable<CMsgOverworldMatchRewards.Types.Player>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgOverworldMatchRewards.Types.Player](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.Types.Player.md)

#### Implements

IMessage<CMsgOverworldMatchRewards.Types.Player\>, 
[IEquatable<CMsgOverworldMatchRewards.Types.Player\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgOverworldMatchRewards.Types.Player\>, 
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
[EnumerableExtensions.In<CMsgOverworldMatchRewards.Types.Player\>\(CMsgOverworldMatchRewards.Types.Player, params CMsgOverworldMatchRewards.Types.Player\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player__ctor"></a> Player\(\)

```csharp
public Player()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player__ctor_Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_"></a> Player\(Player\)

```csharp
public Player(CMsgOverworldMatchRewards.Types.Player other)
```

#### Parameters

`other` [CMsgOverworldMatchRewards](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.md).[Types](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.Types.md).[Player](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.Types.Player.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_PlayerSlotFieldNumber"></a> PlayerSlotFieldNumber

```csharp
public const int PlayerSlotFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_TokensFieldNumber"></a> TokensFieldNumber

```csharp
public const int TokensFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_HasPlayerSlot"></a> HasPlayerSlot

```csharp
public bool HasPlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_Parser"></a> Parser

```csharp
public static MessageParser<CMsgOverworldMatchRewards.Types.Player> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgOverworldMatchRewards](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.md).[Types](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.Types.md).[Player](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_PlayerSlot"></a> PlayerSlot

```csharp
public uint PlayerSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_Tokens"></a> Tokens

```csharp
public CMsgOverworldTokenQuantity Tokens { get; set; }
```

#### Property Value

 [CMsgOverworldTokenQuantity](Divine.Protobufs.Dota2.CMsgOverworldTokenQuantity.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_ClearPlayerSlot"></a> ClearPlayerSlot\(\)

```csharp
public void ClearPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_Clone"></a> Clone\(\)

```csharp
public CMsgOverworldMatchRewards.Types.Player Clone()
```

#### Returns

 [CMsgOverworldMatchRewards](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.md).[Types](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.Types.md).[Player](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_Equals_Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_"></a> Equals\(Player\)

```csharp
public bool Equals(CMsgOverworldMatchRewards.Types.Player other)
```

#### Parameters

`other` [CMsgOverworldMatchRewards](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.md).[Types](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.Types.md).[Player](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.Types.Player.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_MergeFrom_Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_"></a> MergeFrom\(Player\)

```csharp
public void MergeFrom(CMsgOverworldMatchRewards.Types.Player other)
```

#### Parameters

`other` [CMsgOverworldMatchRewards](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.md).[Types](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.Types.md).[Player](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMatchRewards_Types_Player_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

