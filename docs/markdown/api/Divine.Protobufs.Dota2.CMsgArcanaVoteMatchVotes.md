# <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes"></a> Class CMsgArcanaVoteMatchVotes

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgArcanaVoteMatchVotes : IMessage<CMsgArcanaVoteMatchVotes>, IEquatable<CMsgArcanaVoteMatchVotes>, IDeepCloneable<CMsgArcanaVoteMatchVotes>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgArcanaVoteMatchVotes](Divine.Protobufs.Dota2.CMsgArcanaVoteMatchVotes.md)

#### Implements

IMessage<CMsgArcanaVoteMatchVotes\>, 
[IEquatable<CMsgArcanaVoteMatchVotes\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgArcanaVoteMatchVotes\>, 
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
[EnumerableExtensions.In<CMsgArcanaVoteMatchVotes\>\(CMsgArcanaVoteMatchVotes, params CMsgArcanaVoteMatchVotes\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes__ctor"></a> CMsgArcanaVoteMatchVotes\(\)

```csharp
public CMsgArcanaVoteMatchVotes()
```

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes__ctor_Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_"></a> CMsgArcanaVoteMatchVotes\(CMsgArcanaVoteMatchVotes\)

```csharp
public CMsgArcanaVoteMatchVotes(CMsgArcanaVoteMatchVotes other)
```

#### Parameters

`other` [CMsgArcanaVoteMatchVotes](Divine.Protobufs.Dota2.CMsgArcanaVoteMatchVotes.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_VoteCountFieldNumber"></a> VoteCountFieldNumber

```csharp
public const int VoteCountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_HasVoteCount"></a> HasVoteCount

```csharp
public bool HasVoteCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_MatchId"></a> MatchId

```csharp
public uint MatchId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_Parser"></a> Parser

```csharp
public static MessageParser<CMsgArcanaVoteMatchVotes> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgArcanaVoteMatchVotes](Divine.Protobufs.Dota2.CMsgArcanaVoteMatchVotes.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_VoteCount"></a> VoteCount

```csharp
public uint VoteCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_ClearVoteCount"></a> ClearVoteCount\(\)

```csharp
public void ClearVoteCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_Clone"></a> Clone\(\)

```csharp
public CMsgArcanaVoteMatchVotes Clone()
```

#### Returns

 [CMsgArcanaVoteMatchVotes](Divine.Protobufs.Dota2.CMsgArcanaVoteMatchVotes.md)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_Equals_Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_"></a> Equals\(CMsgArcanaVoteMatchVotes\)

```csharp
public bool Equals(CMsgArcanaVoteMatchVotes other)
```

#### Parameters

`other` [CMsgArcanaVoteMatchVotes](Divine.Protobufs.Dota2.CMsgArcanaVoteMatchVotes.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_MergeFrom_Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_"></a> MergeFrom\(CMsgArcanaVoteMatchVotes\)

```csharp
public void MergeFrom(CMsgArcanaVoteMatchVotes other)
```

#### Parameters

`other` [CMsgArcanaVoteMatchVotes](Divine.Protobufs.Dota2.CMsgArcanaVoteMatchVotes.md)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgArcanaVoteMatchVotes_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

