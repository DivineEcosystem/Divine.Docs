# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse"></a> Class CMsgClientToGCRequestArcanaVotesRemainingResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestArcanaVotesRemainingResponse : IMessage<CMsgClientToGCRequestArcanaVotesRemainingResponse>, IEquatable<CMsgClientToGCRequestArcanaVotesRemainingResponse>, IDeepCloneable<CMsgClientToGCRequestArcanaVotesRemainingResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestArcanaVotesRemainingResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestArcanaVotesRemainingResponse.md)

#### Implements

IMessage<CMsgClientToGCRequestArcanaVotesRemainingResponse\>, 
[IEquatable<CMsgClientToGCRequestArcanaVotesRemainingResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestArcanaVotesRemainingResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestArcanaVotesRemainingResponse\>\(CMsgClientToGCRequestArcanaVotesRemainingResponse, params CMsgClientToGCRequestArcanaVotesRemainingResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse__ctor"></a> CMsgClientToGCRequestArcanaVotesRemainingResponse\(\)

```csharp
public CMsgClientToGCRequestArcanaVotesRemainingResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_"></a> CMsgClientToGCRequestArcanaVotesRemainingResponse\(CMsgClientToGCRequestArcanaVotesRemainingResponse\)

```csharp
public CMsgClientToGCRequestArcanaVotesRemainingResponse(CMsgClientToGCRequestArcanaVotesRemainingResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestArcanaVotesRemainingResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestArcanaVotesRemainingResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_MatchesPreviouslyVotedForFieldNumber"></a> MatchesPreviouslyVotedForFieldNumber

```csharp
public const int MatchesPreviouslyVotedForFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_VotesRemainingFieldNumber"></a> VotesRemainingFieldNumber

```csharp
public const int VotesRemainingFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_VotesTotalFieldNumber"></a> VotesTotalFieldNumber

```csharp
public const int VotesTotalFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_HasVotesRemaining"></a> HasVotesRemaining

```csharp
public bool HasVotesRemaining { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_HasVotesTotal"></a> HasVotesTotal

```csharp
public bool HasVotesTotal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_MatchesPreviouslyVotedFor"></a> MatchesPreviouslyVotedFor

```csharp
public RepeatedField<CMsgArcanaVoteMatchVotes> MatchesPreviouslyVotedFor { get; }
```

#### Property Value

 RepeatedField<[CMsgArcanaVoteMatchVotes](Divine.Protobufs.Dota2.CMsgArcanaVoteMatchVotes.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestArcanaVotesRemainingResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestArcanaVotesRemainingResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestArcanaVotesRemainingResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_Result"></a> Result

```csharp
public bool Result { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_VotesRemaining"></a> VotesRemaining

```csharp
public uint VotesRemaining { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_VotesTotal"></a> VotesTotal

```csharp
public uint VotesTotal { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_ClearVotesRemaining"></a> ClearVotesRemaining\(\)

```csharp
public void ClearVotesRemaining()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_ClearVotesTotal"></a> ClearVotesTotal\(\)

```csharp
public void ClearVotesTotal()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestArcanaVotesRemainingResponse Clone()
```

#### Returns

 [CMsgClientToGCRequestArcanaVotesRemainingResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestArcanaVotesRemainingResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_"></a> Equals\(CMsgClientToGCRequestArcanaVotesRemainingResponse\)

```csharp
public bool Equals(CMsgClientToGCRequestArcanaVotesRemainingResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestArcanaVotesRemainingResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestArcanaVotesRemainingResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_"></a> MergeFrom\(CMsgClientToGCRequestArcanaVotesRemainingResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRequestArcanaVotesRemainingResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestArcanaVotesRemainingResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestArcanaVotesRemainingResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestArcanaVotesRemainingResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

