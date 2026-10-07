# <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player"></a> Class CDOTASaveGame.Types.Player

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTASaveGame.Types.Player : IMessage<CDOTASaveGame.Types.Player>, IEquatable<CDOTASaveGame.Types.Player>, IDeepCloneable<CDOTASaveGame.Types.Player>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTASaveGame.Types.Player](Divine.Protobufs.Dota2.CDOTASaveGame.Types.Player.md)

#### Implements

IMessage<CDOTASaveGame.Types.Player\>, 
[IEquatable<CDOTASaveGame.Types.Player\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTASaveGame.Types.Player\>, 
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
[EnumerableExtensions.In<CDOTASaveGame.Types.Player\>\(CDOTASaveGame.Types.Player, params CDOTASaveGame.Types.Player\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player__ctor"></a> Player\(\)

```csharp
public Player()
```

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player__ctor_Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_"></a> Player\(Player\)

```csharp
public Player(CDOTASaveGame.Types.Player other)
```

#### Parameters

`other` [CDOTASaveGame](Divine.Protobufs.Dota2.CDOTASaveGame.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.md).[Player](Divine.Protobufs.Dota2.CDOTASaveGame.Types.Player.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_HeroFieldNumber"></a> HeroFieldNumber

```csharp
public const int HeroFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_HasHero"></a> HasHero

```csharp
public bool HasHero { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_Hero"></a> Hero

```csharp
public string Hero { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_Parser"></a> Parser

```csharp
public static MessageParser<CDOTASaveGame.Types.Player> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTASaveGame](Divine.Protobufs.Dota2.CDOTASaveGame.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.md).[Player](Divine.Protobufs.Dota2.CDOTASaveGame.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_Team"></a> Team

```csharp
public DOTA_GC_TEAM Team { get; set; }
```

#### Property Value

 [DOTA\_GC\_TEAM](Divine.Protobufs.Dota2.DOTA\_GC\_TEAM.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_ClearHero"></a> ClearHero\(\)

```csharp
public void ClearHero()
```

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_Clone"></a> Clone\(\)

```csharp
public CDOTASaveGame.Types.Player Clone()
```

#### Returns

 [CDOTASaveGame](Divine.Protobufs.Dota2.CDOTASaveGame.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.md).[Player](Divine.Protobufs.Dota2.CDOTASaveGame.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_Equals_Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_"></a> Equals\(Player\)

```csharp
public bool Equals(CDOTASaveGame.Types.Player other)
```

#### Parameters

`other` [CDOTASaveGame](Divine.Protobufs.Dota2.CDOTASaveGame.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.md).[Player](Divine.Protobufs.Dota2.CDOTASaveGame.Types.Player.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_MergeFrom_Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_"></a> MergeFrom\(Player\)

```csharp
public void MergeFrom(CDOTASaveGame.Types.Player other)
```

#### Parameters

`other` [CDOTASaveGame](Divine.Protobufs.Dota2.CDOTASaveGame.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.md).[Player](Divine.Protobufs.Dota2.CDOTASaveGame.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_Player_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

