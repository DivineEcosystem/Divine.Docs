# <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount"></a> Class CMsgDraftTriviaVoteCount

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDraftTriviaVoteCount : IMessage<CMsgDraftTriviaVoteCount>, IEquatable<CMsgDraftTriviaVoteCount>, IDeepCloneable<CMsgDraftTriviaVoteCount>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDraftTriviaVoteCount](Divine.Protobufs.Dota2.CMsgDraftTriviaVoteCount.md)

#### Implements

IMessage<CMsgDraftTriviaVoteCount\>, 
[IEquatable<CMsgDraftTriviaVoteCount\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDraftTriviaVoteCount\>, 
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
[EnumerableExtensions.In<CMsgDraftTriviaVoteCount\>\(CMsgDraftTriviaVoteCount, params CMsgDraftTriviaVoteCount\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount__ctor"></a> CMsgDraftTriviaVoteCount\(\)

```csharp
public CMsgDraftTriviaVoteCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount__ctor_Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_"></a> CMsgDraftTriviaVoteCount\(CMsgDraftTriviaVoteCount\)

```csharp
public CMsgDraftTriviaVoteCount(CMsgDraftTriviaVoteCount other)
```

#### Parameters

`other` [CMsgDraftTriviaVoteCount](Divine.Protobufs.Dota2.CMsgDraftTriviaVoteCount.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_DireVotesFieldNumber"></a> DireVotesFieldNumber

```csharp
public const int DireVotesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_RadiantVotesFieldNumber"></a> RadiantVotesFieldNumber

```csharp
public const int RadiantVotesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_TotalVotesFieldNumber"></a> TotalVotesFieldNumber

```csharp
public const int TotalVotesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_DireVotes"></a> DireVotes

```csharp
public uint DireVotes { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_HasDireVotes"></a> HasDireVotes

```csharp
public bool HasDireVotes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_HasRadiantVotes"></a> HasRadiantVotes

```csharp
public bool HasRadiantVotes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_HasTotalVotes"></a> HasTotalVotes

```csharp
public bool HasTotalVotes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDraftTriviaVoteCount> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDraftTriviaVoteCount](Divine.Protobufs.Dota2.CMsgDraftTriviaVoteCount.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_RadiantVotes"></a> RadiantVotes

```csharp
public uint RadiantVotes { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_TotalVotes"></a> TotalVotes

```csharp
public uint TotalVotes { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_ClearDireVotes"></a> ClearDireVotes\(\)

```csharp
public void ClearDireVotes()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_ClearRadiantVotes"></a> ClearRadiantVotes\(\)

```csharp
public void ClearRadiantVotes()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_ClearTotalVotes"></a> ClearTotalVotes\(\)

```csharp
public void ClearTotalVotes()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_Clone"></a> Clone\(\)

```csharp
public CMsgDraftTriviaVoteCount Clone()
```

#### Returns

 [CMsgDraftTriviaVoteCount](Divine.Protobufs.Dota2.CMsgDraftTriviaVoteCount.md)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_Equals_Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_"></a> Equals\(CMsgDraftTriviaVoteCount\)

```csharp
public bool Equals(CMsgDraftTriviaVoteCount other)
```

#### Parameters

`other` [CMsgDraftTriviaVoteCount](Divine.Protobufs.Dota2.CMsgDraftTriviaVoteCount.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_MergeFrom_Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_"></a> MergeFrom\(CMsgDraftTriviaVoteCount\)

```csharp
public void MergeFrom(CMsgDraftTriviaVoteCount other)
```

#### Parameters

`other` [CMsgDraftTriviaVoteCount](Divine.Protobufs.Dota2.CMsgDraftTriviaVoteCount.md)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTriviaVoteCount_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

