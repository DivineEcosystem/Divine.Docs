# <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory"></a> Class CMsgDOTAGetPlayerMatchHistory

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAGetPlayerMatchHistory : IMessage<CMsgDOTAGetPlayerMatchHistory>, IEquatable<CMsgDOTAGetPlayerMatchHistory>, IDeepCloneable<CMsgDOTAGetPlayerMatchHistory>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAGetPlayerMatchHistory](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistory.md)

#### Implements

IMessage<CMsgDOTAGetPlayerMatchHistory\>, 
[IEquatable<CMsgDOTAGetPlayerMatchHistory\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAGetPlayerMatchHistory\>, 
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
[EnumerableExtensions.In<CMsgDOTAGetPlayerMatchHistory\>\(CMsgDOTAGetPlayerMatchHistory, params CMsgDOTAGetPlayerMatchHistory\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory__ctor"></a> CMsgDOTAGetPlayerMatchHistory\(\)

```csharp
public CMsgDOTAGetPlayerMatchHistory()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory__ctor_Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_"></a> CMsgDOTAGetPlayerMatchHistory\(CMsgDOTAGetPlayerMatchHistory\)

```csharp
public CMsgDOTAGetPlayerMatchHistory(CMsgDOTAGetPlayerMatchHistory other)
```

#### Parameters

`other` [CMsgDOTAGetPlayerMatchHistory](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistory.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_IncludeCustomGamesFieldNumber"></a> IncludeCustomGamesFieldNumber

```csharp
public const int IncludeCustomGamesFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_IncludeEventGamesFieldNumber"></a> IncludeEventGamesFieldNumber

```csharp
public const int IncludeEventGamesFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_IncludePracticeMatchesFieldNumber"></a> IncludePracticeMatchesFieldNumber

```csharp
public const int IncludePracticeMatchesFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_MatchesRequestedFieldNumber"></a> MatchesRequestedFieldNumber

```csharp
public const int MatchesRequestedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_RequestIdFieldNumber"></a> RequestIdFieldNumber

```csharp
public const int RequestIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_StartAtMatchIdFieldNumber"></a> StartAtMatchIdFieldNumber

```csharp
public const int StartAtMatchIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_HasIncludeCustomGames"></a> HasIncludeCustomGames

```csharp
public bool HasIncludeCustomGames { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_HasIncludeEventGames"></a> HasIncludeEventGames

```csharp
public bool HasIncludeEventGames { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_HasIncludePracticeMatches"></a> HasIncludePracticeMatches

```csharp
public bool HasIncludePracticeMatches { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_HasMatchesRequested"></a> HasMatchesRequested

```csharp
public bool HasMatchesRequested { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_HasRequestId"></a> HasRequestId

```csharp
public bool HasRequestId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_HasStartAtMatchId"></a> HasStartAtMatchId

```csharp
public bool HasStartAtMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_IncludeCustomGames"></a> IncludeCustomGames

```csharp
public bool IncludeCustomGames { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_IncludeEventGames"></a> IncludeEventGames

```csharp
public bool IncludeEventGames { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_IncludePracticeMatches"></a> IncludePracticeMatches

```csharp
public bool IncludePracticeMatches { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_MatchesRequested"></a> MatchesRequested

```csharp
public uint MatchesRequested { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAGetPlayerMatchHistory> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAGetPlayerMatchHistory](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistory.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_RequestId"></a> RequestId

```csharp
public uint RequestId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_StartAtMatchId"></a> StartAtMatchId

```csharp
public ulong StartAtMatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_ClearIncludeCustomGames"></a> ClearIncludeCustomGames\(\)

```csharp
public void ClearIncludeCustomGames()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_ClearIncludeEventGames"></a> ClearIncludeEventGames\(\)

```csharp
public void ClearIncludeEventGames()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_ClearIncludePracticeMatches"></a> ClearIncludePracticeMatches\(\)

```csharp
public void ClearIncludePracticeMatches()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_ClearMatchesRequested"></a> ClearMatchesRequested\(\)

```csharp
public void ClearMatchesRequested()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_ClearRequestId"></a> ClearRequestId\(\)

```csharp
public void ClearRequestId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_ClearStartAtMatchId"></a> ClearStartAtMatchId\(\)

```csharp
public void ClearStartAtMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAGetPlayerMatchHistory Clone()
```

#### Returns

 [CMsgDOTAGetPlayerMatchHistory](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistory.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_Equals_Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_"></a> Equals\(CMsgDOTAGetPlayerMatchHistory\)

```csharp
public bool Equals(CMsgDOTAGetPlayerMatchHistory other)
```

#### Parameters

`other` [CMsgDOTAGetPlayerMatchHistory](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistory.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_"></a> MergeFrom\(CMsgDOTAGetPlayerMatchHistory\)

```csharp
public void MergeFrom(CMsgDOTAGetPlayerMatchHistory other)
```

#### Parameters

`other` [CMsgDOTAGetPlayerMatchHistory](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistory.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistory_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

