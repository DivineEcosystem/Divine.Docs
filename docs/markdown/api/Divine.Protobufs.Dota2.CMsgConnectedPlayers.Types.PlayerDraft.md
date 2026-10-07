# <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft"></a> Class CMsgConnectedPlayers.Types.PlayerDraft

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgConnectedPlayers.Types.PlayerDraft : IMessage<CMsgConnectedPlayers.Types.PlayerDraft>, IEquatable<CMsgConnectedPlayers.Types.PlayerDraft>, IDeepCloneable<CMsgConnectedPlayers.Types.PlayerDraft>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgConnectedPlayers.Types.PlayerDraft](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.PlayerDraft.md)

#### Implements

IMessage<CMsgConnectedPlayers.Types.PlayerDraft\>, 
[IEquatable<CMsgConnectedPlayers.Types.PlayerDraft\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgConnectedPlayers.Types.PlayerDraft\>, 
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
[EnumerableExtensions.In<CMsgConnectedPlayers.Types.PlayerDraft\>\(CMsgConnectedPlayers.Types.PlayerDraft, params CMsgConnectedPlayers.Types.PlayerDraft\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft__ctor"></a> PlayerDraft\(\)

```csharp
public PlayerDraft()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft__ctor_Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_"></a> PlayerDraft\(PlayerDraft\)

```csharp
public PlayerDraft(CMsgConnectedPlayers.Types.PlayerDraft other)
```

#### Parameters

`other` [CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md).[Types](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.md).[PlayerDraft](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.PlayerDraft.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_TeamSlotFieldNumber"></a> TeamSlotFieldNumber

```csharp
public const int TeamSlotFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_HasSteamId"></a> HasSteamId

```csharp
public bool HasSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_HasTeamSlot"></a> HasTeamSlot

```csharp
public bool HasTeamSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_Parser"></a> Parser

```csharp
public static MessageParser<CMsgConnectedPlayers.Types.PlayerDraft> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md).[Types](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.md).[PlayerDraft](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.PlayerDraft.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_SteamId"></a> SteamId

```csharp
public ulong SteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_Team"></a> Team

```csharp
public DOTA_GC_TEAM Team { get; set; }
```

#### Property Value

 [DOTA\_GC\_TEAM](Divine.Protobufs.Dota2.DOTA\_GC\_TEAM.md)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_TeamSlot"></a> TeamSlot

```csharp
public int TeamSlot { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_ClearSteamId"></a> ClearSteamId\(\)

```csharp
public void ClearSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_ClearTeamSlot"></a> ClearTeamSlot\(\)

```csharp
public void ClearTeamSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_Clone"></a> Clone\(\)

```csharp
public CMsgConnectedPlayers.Types.PlayerDraft Clone()
```

#### Returns

 [CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md).[Types](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.md).[PlayerDraft](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.PlayerDraft.md)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_Equals_Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_"></a> Equals\(PlayerDraft\)

```csharp
public bool Equals(CMsgConnectedPlayers.Types.PlayerDraft other)
```

#### Parameters

`other` [CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md).[Types](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.md).[PlayerDraft](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.PlayerDraft.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_MergeFrom_Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_"></a> MergeFrom\(PlayerDraft\)

```csharp
public void MergeFrom(CMsgConnectedPlayers.Types.PlayerDraft other)
```

#### Parameters

`other` [CMsgConnectedPlayers](Divine.Protobufs.Dota2.CMsgConnectedPlayers.md).[Types](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.md).[PlayerDraft](Divine.Protobufs.Dota2.CMsgConnectedPlayers.Types.PlayerDraft.md)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgConnectedPlayers_Types_PlayerDraft_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

