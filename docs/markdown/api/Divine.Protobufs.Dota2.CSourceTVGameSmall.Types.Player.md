# <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player"></a> Class CSourceTVGameSmall.Types.Player

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSourceTVGameSmall.Types.Player : IMessage<CSourceTVGameSmall.Types.Player>, IEquatable<CSourceTVGameSmall.Types.Player>, IDeepCloneable<CSourceTVGameSmall.Types.Player>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSourceTVGameSmall.Types.Player](Divine.Protobufs.Dota2.CSourceTVGameSmall.Types.Player.md)

#### Implements

IMessage<CSourceTVGameSmall.Types.Player\>, 
[IEquatable<CSourceTVGameSmall.Types.Player\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSourceTVGameSmall.Types.Player\>, 
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
[EnumerableExtensions.In<CSourceTVGameSmall.Types.Player\>\(CSourceTVGameSmall.Types.Player, params CSourceTVGameSmall.Types.Player\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player__ctor"></a> Player\(\)

```csharp
public Player()
```

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player__ctor_Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_"></a> Player\(Player\)

```csharp
public Player(CSourceTVGameSmall.Types.Player other)
```

#### Parameters

`other` [CSourceTVGameSmall](Divine.Protobufs.Dota2.CSourceTVGameSmall.md).[Types](Divine.Protobufs.Dota2.CSourceTVGameSmall.Types.md).[Player](Divine.Protobufs.Dota2.CSourceTVGameSmall.Types.Player.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_TeamSlotFieldNumber"></a> TeamSlotFieldNumber

```csharp
public const int TeamSlotFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_HasTeamSlot"></a> HasTeamSlot

```csharp
public bool HasTeamSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_Parser"></a> Parser

```csharp
public static MessageParser<CSourceTVGameSmall.Types.Player> Parser { get; }
```

#### Property Value

 MessageParser<[CSourceTVGameSmall](Divine.Protobufs.Dota2.CSourceTVGameSmall.md).[Types](Divine.Protobufs.Dota2.CSourceTVGameSmall.Types.md).[Player](Divine.Protobufs.Dota2.CSourceTVGameSmall.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_Team"></a> Team

```csharp
public uint Team { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_TeamSlot"></a> TeamSlot

```csharp
public uint TeamSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_ClearTeamSlot"></a> ClearTeamSlot\(\)

```csharp
public void ClearTeamSlot()
```

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_Clone"></a> Clone\(\)

```csharp
public CSourceTVGameSmall.Types.Player Clone()
```

#### Returns

 [CSourceTVGameSmall](Divine.Protobufs.Dota2.CSourceTVGameSmall.md).[Types](Divine.Protobufs.Dota2.CSourceTVGameSmall.Types.md).[Player](Divine.Protobufs.Dota2.CSourceTVGameSmall.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_Equals_Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_"></a> Equals\(Player\)

```csharp
public bool Equals(CSourceTVGameSmall.Types.Player other)
```

#### Parameters

`other` [CSourceTVGameSmall](Divine.Protobufs.Dota2.CSourceTVGameSmall.md).[Types](Divine.Protobufs.Dota2.CSourceTVGameSmall.Types.md).[Player](Divine.Protobufs.Dota2.CSourceTVGameSmall.Types.Player.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_MergeFrom_Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_"></a> MergeFrom\(Player\)

```csharp
public void MergeFrom(CSourceTVGameSmall.Types.Player other)
```

#### Parameters

`other` [CSourceTVGameSmall](Divine.Protobufs.Dota2.CSourceTVGameSmall.md).[Types](Divine.Protobufs.Dota2.CSourceTVGameSmall.Types.md).[Player](Divine.Protobufs.Dota2.CSourceTVGameSmall.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSourceTVGameSmall_Types_Player_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

