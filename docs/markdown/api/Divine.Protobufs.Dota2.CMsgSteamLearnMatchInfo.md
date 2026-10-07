# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo"></a> Class CMsgSteamLearnMatchInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnMatchInfo : IMessage<CMsgSteamLearnMatchInfo>, IEquatable<CMsgSteamLearnMatchInfo>, IDeepCloneable<CMsgSteamLearnMatchInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnMatchInfo](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfo.md)

#### Implements

IMessage<CMsgSteamLearnMatchInfo\>, 
[IEquatable<CMsgSteamLearnMatchInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnMatchInfo\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnMatchInfo\>\(CMsgSteamLearnMatchInfo, params CMsgSteamLearnMatchInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo__ctor"></a> CMsgSteamLearnMatchInfo\(\)

```csharp
public CMsgSteamLearnMatchInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_"></a> CMsgSteamLearnMatchInfo\(CMsgSteamLearnMatchInfo\)

```csharp
public CMsgSteamLearnMatchInfo(CMsgSteamLearnMatchInfo other)
```

#### Parameters

`other` [CMsgSteamLearnMatchInfo](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_AverageMmrFieldNumber"></a> AverageMmrFieldNumber

```csharp
public const int AverageMmrFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_GameModeFieldNumber"></a> GameModeFieldNumber

```csharp
public const int GameModeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_LobbyTypeFieldNumber"></a> LobbyTypeFieldNumber

```csharp
public const int LobbyTypeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_RadiantWonFieldNumber"></a> RadiantWonFieldNumber

```csharp
public const int RadiantWonFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_AverageMmr"></a> AverageMmr

```csharp
public uint AverageMmr { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_Duration"></a> Duration

```csharp
public uint Duration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_GameMode"></a> GameMode

```csharp
public uint GameMode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_HasAverageMmr"></a> HasAverageMmr

```csharp
public bool HasAverageMmr { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_HasGameMode"></a> HasGameMode

```csharp
public bool HasGameMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_HasLobbyType"></a> HasLobbyType

```csharp
public bool HasLobbyType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_HasRadiantWon"></a> HasRadiantWon

```csharp
public bool HasRadiantWon { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_LobbyType"></a> LobbyType

```csharp
public uint LobbyType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnMatchInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnMatchInfo](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_RadiantWon"></a> RadiantWon

```csharp
public bool RadiantWon { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_ClearAverageMmr"></a> ClearAverageMmr\(\)

```csharp
public void ClearAverageMmr()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_ClearGameMode"></a> ClearGameMode\(\)

```csharp
public void ClearGameMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_ClearLobbyType"></a> ClearLobbyType\(\)

```csharp
public void ClearLobbyType()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_ClearRadiantWon"></a> ClearRadiantWon\(\)

```csharp
public void ClearRadiantWon()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnMatchInfo Clone()
```

#### Returns

 [CMsgSteamLearnMatchInfo](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_"></a> Equals\(CMsgSteamLearnMatchInfo\)

```csharp
public bool Equals(CMsgSteamLearnMatchInfo other)
```

#### Parameters

`other` [CMsgSteamLearnMatchInfo](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_"></a> MergeFrom\(CMsgSteamLearnMatchInfo\)

```csharp
public void MergeFrom(CMsgSteamLearnMatchInfo other)
```

#### Parameters

`other` [CMsgSteamLearnMatchInfo](Divine.Protobufs.Dota2.CMsgSteamLearnMatchInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

