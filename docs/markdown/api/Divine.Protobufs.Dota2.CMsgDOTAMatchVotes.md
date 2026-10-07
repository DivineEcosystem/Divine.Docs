# <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes"></a> Class CMsgDOTAMatchVotes

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAMatchVotes : IMessage<CMsgDOTAMatchVotes>, IEquatable<CMsgDOTAMatchVotes>, IDeepCloneable<CMsgDOTAMatchVotes>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAMatchVotes](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.md)

#### Implements

IMessage<CMsgDOTAMatchVotes\>, 
[IEquatable<CMsgDOTAMatchVotes\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAMatchVotes\>, 
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
[EnumerableExtensions.In<CMsgDOTAMatchVotes\>\(CMsgDOTAMatchVotes, params CMsgDOTAMatchVotes\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes__ctor"></a> CMsgDOTAMatchVotes\(\)

```csharp
public CMsgDOTAMatchVotes()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes__ctor_Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_"></a> CMsgDOTAMatchVotes\(CMsgDOTAMatchVotes\)

```csharp
public CMsgDOTAMatchVotes(CMsgDOTAMatchVotes other)
```

#### Parameters

`other` [CMsgDOTAMatchVotes](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_VotesFieldNumber"></a> VotesFieldNumber

```csharp
public const int VotesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAMatchVotes> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAMatchVotes](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Votes"></a> Votes

```csharp
public RepeatedField<CMsgDOTAMatchVotes.Types.PlayerVote> Votes { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAMatchVotes](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.Types.md).[PlayerVote](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.Types.PlayerVote.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAMatchVotes Clone()
```

#### Returns

 [CMsgDOTAMatchVotes](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Equals_Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_"></a> Equals\(CMsgDOTAMatchVotes\)

```csharp
public bool Equals(CMsgDOTAMatchVotes other)
```

#### Parameters

`other` [CMsgDOTAMatchVotes](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_"></a> MergeFrom\(CMsgDOTAMatchVotes\)

```csharp
public void MergeFrom(CMsgDOTAMatchVotes other)
```

#### Parameters

`other` [CMsgDOTAMatchVotes](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

