# <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame"></a> Class CMsgDOTASeries.Types.LiveGame

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASeries.Types.LiveGame : IMessage<CMsgDOTASeries.Types.LiveGame>, IEquatable<CMsgDOTASeries.Types.LiveGame>, IDeepCloneable<CMsgDOTASeries.Types.LiveGame>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASeries.Types.LiveGame](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.LiveGame.md)

#### Implements

IMessage<CMsgDOTASeries.Types.LiveGame\>, 
[IEquatable<CMsgDOTASeries.Types.LiveGame\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASeries.Types.LiveGame\>, 
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
[EnumerableExtensions.In<CMsgDOTASeries.Types.LiveGame\>\(CMsgDOTASeries.Types.LiveGame, params CMsgDOTASeries.Types.LiveGame\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame__ctor"></a> LiveGame\(\)

```csharp
public LiveGame()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame__ctor_Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_"></a> LiveGame\(LiveGame\)

```csharp
public LiveGame(CMsgDOTASeries.Types.LiveGame other)
```

#### Parameters

`other` [CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.md).[LiveGame](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.LiveGame.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_ServerSteamIdFieldNumber"></a> ServerSteamIdFieldNumber

```csharp
public const int ServerSteamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_TeamDireFieldNumber"></a> TeamDireFieldNumber

```csharp
public const int TeamDireFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_TeamDireScoreFieldNumber"></a> TeamDireScoreFieldNumber

```csharp
public const int TeamDireScoreFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_TeamRadiantFieldNumber"></a> TeamRadiantFieldNumber

```csharp
public const int TeamRadiantFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_TeamRadiantScoreFieldNumber"></a> TeamRadiantScoreFieldNumber

```csharp
public const int TeamRadiantScoreFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_HasServerSteamId"></a> HasServerSteamId

```csharp
public bool HasServerSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_HasTeamDireScore"></a> HasTeamDireScore

```csharp
public bool HasTeamDireScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_HasTeamRadiantScore"></a> HasTeamRadiantScore

```csharp
public bool HasTeamRadiantScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASeries.Types.LiveGame> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.md).[LiveGame](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.LiveGame.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_ServerSteamId"></a> ServerSteamId

```csharp
public ulong ServerSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_TeamDire"></a> TeamDire

```csharp
public CMsgDOTASeries.Types.TeamInfo TeamDire { get; set; }
```

#### Property Value

 [CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.md).[TeamInfo](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.TeamInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_TeamDireScore"></a> TeamDireScore

```csharp
public uint TeamDireScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_TeamRadiant"></a> TeamRadiant

```csharp
public CMsgDOTASeries.Types.TeamInfo TeamRadiant { get; set; }
```

#### Property Value

 [CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.md).[TeamInfo](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.TeamInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_TeamRadiantScore"></a> TeamRadiantScore

```csharp
public uint TeamRadiantScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_ClearServerSteamId"></a> ClearServerSteamId\(\)

```csharp
public void ClearServerSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_ClearTeamDireScore"></a> ClearTeamDireScore\(\)

```csharp
public void ClearTeamDireScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_ClearTeamRadiantScore"></a> ClearTeamRadiantScore\(\)

```csharp
public void ClearTeamRadiantScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASeries.Types.LiveGame Clone()
```

#### Returns

 [CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.md).[LiveGame](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.LiveGame.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_Equals_Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_"></a> Equals\(LiveGame\)

```csharp
public bool Equals(CMsgDOTASeries.Types.LiveGame other)
```

#### Parameters

`other` [CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.md).[LiveGame](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.LiveGame.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_"></a> MergeFrom\(LiveGame\)

```csharp
public void MergeFrom(CMsgDOTASeries.Types.LiveGame other)
```

#### Parameters

`other` [CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.md).[LiveGame](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.LiveGame.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Types_LiveGame_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

