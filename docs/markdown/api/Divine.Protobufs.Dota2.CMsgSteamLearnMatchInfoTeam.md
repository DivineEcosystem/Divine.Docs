# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam"></a> Class CMsgSteamLearnMatchInfoTeam

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnMatchInfoTeam : IMessage<CMsgSteamLearnMatchInfoTeam>, IEquatable<CMsgSteamLearnMatchInfoTeam>, IDeepCloneable<CMsgSteamLearnMatchInfoTeam>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnMatchInfoTeam](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.md)

#### Implements

IMessage<CMsgSteamLearnMatchInfoTeam\>, 
[IEquatable<CMsgSteamLearnMatchInfoTeam\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnMatchInfoTeam\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnMatchInfoTeam\>\(CMsgSteamLearnMatchInfoTeam, params CMsgSteamLearnMatchInfoTeam\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam__ctor"></a> CMsgSteamLearnMatchInfoTeam\(\)

```csharp
public CMsgSteamLearnMatchInfoTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_"></a> CMsgSteamLearnMatchInfoTeam\(CMsgSteamLearnMatchInfoTeam\)

```csharp
public CMsgSteamLearnMatchInfoTeam(CMsgSteamLearnMatchInfoTeam other)
```

#### Parameters

`other` [CMsgSteamLearnMatchInfoTeam](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_DirePlayersFieldNumber"></a> DirePlayersFieldNumber

```csharp
public const int DirePlayersFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_RadiantPlayersFieldNumber"></a> RadiantPlayersFieldNumber

```csharp
public const int RadiantPlayersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_RadiantTeamWonFieldNumber"></a> RadiantTeamWonFieldNumber

```csharp
public const int RadiantTeamWonFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_DirePlayers"></a> DirePlayers

```csharp
public RepeatedField<CMsgSteamLearnMatchInfoTeam.Types.Player> DirePlayers { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearnMatchInfoTeam](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_HasRadiantTeamWon"></a> HasRadiantTeamWon

```csharp
public bool HasRadiantTeamWon { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnMatchInfoTeam> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnMatchInfoTeam](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_RadiantPlayers"></a> RadiantPlayers

```csharp
public RepeatedField<CMsgSteamLearnMatchInfoTeam.Types.Player> RadiantPlayers { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearnMatchInfoTeam](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_RadiantTeamWon"></a> RadiantTeamWon

```csharp
public bool RadiantTeamWon { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_ClearRadiantTeamWon"></a> ClearRadiantTeamWon\(\)

```csharp
public void ClearRadiantTeamWon()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnMatchInfoTeam Clone()
```

#### Returns

 [CMsgSteamLearnMatchInfoTeam](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_"></a> Equals\(CMsgSteamLearnMatchInfoTeam\)

```csharp
public bool Equals(CMsgSteamLearnMatchInfoTeam other)
```

#### Parameters

`other` [CMsgSteamLearnMatchInfoTeam](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_"></a> MergeFrom\(CMsgSteamLearnMatchInfoTeam\)

```csharp
public void MergeFrom(CMsgSteamLearnMatchInfoTeam other)
```

#### Parameters

`other` [CMsgSteamLearnMatchInfoTeam](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfoTeam.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfoTeam_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

