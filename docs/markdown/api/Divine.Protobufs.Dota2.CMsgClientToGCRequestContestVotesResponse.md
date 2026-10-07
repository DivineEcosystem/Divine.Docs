# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse"></a> Class CMsgClientToGCRequestContestVotesResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestContestVotesResponse : IMessage<CMsgClientToGCRequestContestVotesResponse>, IEquatable<CMsgClientToGCRequestContestVotesResponse>, IDeepCloneable<CMsgClientToGCRequestContestVotesResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestContestVotesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.md)

#### Implements

IMessage<CMsgClientToGCRequestContestVotesResponse\>, 
[IEquatable<CMsgClientToGCRequestContestVotesResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestContestVotesResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestContestVotesResponse\>\(CMsgClientToGCRequestContestVotesResponse, params CMsgClientToGCRequestContestVotesResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse__ctor"></a> CMsgClientToGCRequestContestVotesResponse\(\)

```csharp
public CMsgClientToGCRequestContestVotesResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_"></a> CMsgClientToGCRequestContestVotesResponse\(CMsgClientToGCRequestContestVotesResponse\)

```csharp
public CMsgClientToGCRequestContestVotesResponse(CMsgClientToGCRequestContestVotesResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestContestVotesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_VotesFieldNumber"></a> VotesFieldNumber

```csharp
public const int VotesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestContestVotesResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestContestVotesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Result"></a> Result

```csharp
public CMsgClientToGCRequestContestVotesResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCRequestContestVotesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Votes"></a> Votes

```csharp
public RepeatedField<CMsgClientToGCRequestContestVotesResponse.Types.ItemVote> Votes { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCRequestContestVotesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.Types.md).[ItemVote](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.Types.ItemVote.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestContestVotesResponse Clone()
```

#### Returns

 [CMsgClientToGCRequestContestVotesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_"></a> Equals\(CMsgClientToGCRequestContestVotesResponse\)

```csharp
public bool Equals(CMsgClientToGCRequestContestVotesResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestContestVotesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_"></a> MergeFrom\(CMsgClientToGCRequestContestVotesResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRequestContestVotesResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestContestVotesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

