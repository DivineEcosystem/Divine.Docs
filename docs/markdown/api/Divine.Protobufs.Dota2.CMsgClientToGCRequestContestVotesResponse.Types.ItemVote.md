# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote"></a> Class CMsgClientToGCRequestContestVotesResponse.Types.ItemVote

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestContestVotesResponse.Types.ItemVote : IMessage<CMsgClientToGCRequestContestVotesResponse.Types.ItemVote>, IEquatable<CMsgClientToGCRequestContestVotesResponse.Types.ItemVote>, IDeepCloneable<CMsgClientToGCRequestContestVotesResponse.Types.ItemVote>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestContestVotesResponse.Types.ItemVote](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.Types.ItemVote.md)

#### Implements

IMessage<CMsgClientToGCRequestContestVotesResponse.Types.ItemVote\>, 
[IEquatable<CMsgClientToGCRequestContestVotesResponse.Types.ItemVote\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestContestVotesResponse.Types.ItemVote\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestContestVotesResponse.Types.ItemVote\>\(CMsgClientToGCRequestContestVotesResponse.Types.ItemVote, params CMsgClientToGCRequestContestVotesResponse.Types.ItemVote\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote__ctor"></a> ItemVote\(\)

```csharp
public ItemVote()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_"></a> ItemVote\(ItemVote\)

```csharp
public ItemVote(CMsgClientToGCRequestContestVotesResponse.Types.ItemVote other)
```

#### Parameters

`other` [CMsgClientToGCRequestContestVotesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.Types.md).[ItemVote](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.Types.ItemVote.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_ContestItemIdFieldNumber"></a> ContestItemIdFieldNumber

```csharp
public const int ContestItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_VoteFieldNumber"></a> VoteFieldNumber

```csharp
public const int VoteFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_ContestItemId"></a> ContestItemId

```csharp
public ulong ContestItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_HasContestItemId"></a> HasContestItemId

```csharp
public bool HasContestItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_HasVote"></a> HasVote

```csharp
public bool HasVote { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestContestVotesResponse.Types.ItemVote> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestContestVotesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.Types.md).[ItemVote](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.Types.ItemVote.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_Vote"></a> Vote

```csharp
public int Vote { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_ClearContestItemId"></a> ClearContestItemId\(\)

```csharp
public void ClearContestItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_ClearVote"></a> ClearVote\(\)

```csharp
public void ClearVote()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestContestVotesResponse.Types.ItemVote Clone()
```

#### Returns

 [CMsgClientToGCRequestContestVotesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.Types.md).[ItemVote](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.Types.ItemVote.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_"></a> Equals\(ItemVote\)

```csharp
public bool Equals(CMsgClientToGCRequestContestVotesResponse.Types.ItemVote other)
```

#### Parameters

`other` [CMsgClientToGCRequestContestVotesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.Types.md).[ItemVote](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.Types.ItemVote.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_"></a> MergeFrom\(ItemVote\)

```csharp
public void MergeFrom(CMsgClientToGCRequestContestVotesResponse.Types.ItemVote other)
```

#### Parameters

`other` [CMsgClientToGCRequestContestVotesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.Types.md).[ItemVote](Divine.Protobufs.Dota2.CMsgClientToGCRequestContestVotesResponse.Types.ItemVote.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestContestVotesResponse_Types_ItemVote_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

