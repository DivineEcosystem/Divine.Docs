# <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo"></a> Class CMsgPlayerRecentMatchInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPlayerRecentMatchInfo : IMessage<CMsgPlayerRecentMatchInfo>, IEquatable<CMsgPlayerRecentMatchInfo>, IDeepCloneable<CMsgPlayerRecentMatchInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPlayerRecentMatchInfo](Divine.Protobufs.Dota2.CMsgPlayerRecentMatchInfo.md)

#### Implements

IMessage<CMsgPlayerRecentMatchInfo\>, 
[IEquatable<CMsgPlayerRecentMatchInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPlayerRecentMatchInfo\>, 
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
[EnumerableExtensions.In<CMsgPlayerRecentMatchInfo\>\(CMsgPlayerRecentMatchInfo, params CMsgPlayerRecentMatchInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo__ctor"></a> CMsgPlayerRecentMatchInfo\(\)

```csharp
public CMsgPlayerRecentMatchInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo__ctor_Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_"></a> CMsgPlayerRecentMatchInfo\(CMsgPlayerRecentMatchInfo\)

```csharp
public CMsgPlayerRecentMatchInfo(CMsgPlayerRecentMatchInfo other)
```

#### Parameters

`other` [CMsgPlayerRecentMatchInfo](Divine.Protobufs.Dota2.CMsgPlayerRecentMatchInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_AssistsFieldNumber"></a> AssistsFieldNumber

```csharp
public const int AssistsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_DeathsFieldNumber"></a> DeathsFieldNumber

```csharp
public const int DeathsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_KillsFieldNumber"></a> KillsFieldNumber

```csharp
public const int KillsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_WinFieldNumber"></a> WinFieldNumber

```csharp
public const int WinFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_Assists"></a> Assists

```csharp
public uint Assists { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_Deaths"></a> Deaths

```csharp
public uint Deaths { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_Duration"></a> Duration

```csharp
public uint Duration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_HasAssists"></a> HasAssists

```csharp
public bool HasAssists { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_HasDeaths"></a> HasDeaths

```csharp
public bool HasDeaths { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_HasKills"></a> HasKills

```csharp
public bool HasKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_HasWin"></a> HasWin

```csharp
public bool HasWin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_Kills"></a> Kills

```csharp
public uint Kills { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPlayerRecentMatchInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPlayerRecentMatchInfo](Divine.Protobufs.Dota2.CMsgPlayerRecentMatchInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_Win"></a> Win

```csharp
public bool Win { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_ClearAssists"></a> ClearAssists\(\)

```csharp
public void ClearAssists()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_ClearDeaths"></a> ClearDeaths\(\)

```csharp
public void ClearDeaths()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_ClearKills"></a> ClearKills\(\)

```csharp
public void ClearKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_ClearWin"></a> ClearWin\(\)

```csharp
public void ClearWin()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_Clone"></a> Clone\(\)

```csharp
public CMsgPlayerRecentMatchInfo Clone()
```

#### Returns

 [CMsgPlayerRecentMatchInfo](Divine.Protobufs.Dota2.CMsgPlayerRecentMatchInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_Equals_Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_"></a> Equals\(CMsgPlayerRecentMatchInfo\)

```csharp
public bool Equals(CMsgPlayerRecentMatchInfo other)
```

#### Parameters

`other` [CMsgPlayerRecentMatchInfo](Divine.Protobufs.Dota2.CMsgPlayerRecentMatchInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_"></a> MergeFrom\(CMsgPlayerRecentMatchInfo\)

```csharp
public void MergeFrom(CMsgPlayerRecentMatchInfo other)
```

#### Parameters

`other` [CMsgPlayerRecentMatchInfo](Divine.Protobufs.Dota2.CMsgPlayerRecentMatchInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentMatchInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

