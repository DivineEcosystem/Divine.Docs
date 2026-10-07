# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote"></a> Class CMsgClientToGCRecordContestVote

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRecordContestVote : IMessage<CMsgClientToGCRecordContestVote>, IEquatable<CMsgClientToGCRecordContestVote>, IDeepCloneable<CMsgClientToGCRecordContestVote>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRecordContestVote](Divine.Protobufs.Dota2.CMsgClientToGCRecordContestVote.md)

#### Implements

IMessage<CMsgClientToGCRecordContestVote\>, 
[IEquatable<CMsgClientToGCRecordContestVote\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRecordContestVote\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRecordContestVote\>\(CMsgClientToGCRecordContestVote, params CMsgClientToGCRecordContestVote\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote__ctor"></a> CMsgClientToGCRecordContestVote\(\)

```csharp
public CMsgClientToGCRecordContestVote()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_"></a> CMsgClientToGCRecordContestVote\(CMsgClientToGCRecordContestVote\)

```csharp
public CMsgClientToGCRecordContestVote(CMsgClientToGCRecordContestVote other)
```

#### Parameters

`other` [CMsgClientToGCRecordContestVote](Divine.Protobufs.Dota2.CMsgClientToGCRecordContestVote.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_ContestIdFieldNumber"></a> ContestIdFieldNumber

```csharp
public const int ContestIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_ContestItemIdFieldNumber"></a> ContestItemIdFieldNumber

```csharp
public const int ContestItemIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_VoteFieldNumber"></a> VoteFieldNumber

```csharp
public const int VoteFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_ContestId"></a> ContestId

```csharp
public uint ContestId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_ContestItemId"></a> ContestItemId

```csharp
public ulong ContestItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_HasContestId"></a> HasContestId

```csharp
public bool HasContestId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_HasContestItemId"></a> HasContestItemId

```csharp
public bool HasContestItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_HasVote"></a> HasVote

```csharp
public bool HasVote { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRecordContestVote> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRecordContestVote](Divine.Protobufs.Dota2.CMsgClientToGCRecordContestVote.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_Vote"></a> Vote

```csharp
public int Vote { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_ClearContestId"></a> ClearContestId\(\)

```csharp
public void ClearContestId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_ClearContestItemId"></a> ClearContestItemId\(\)

```csharp
public void ClearContestItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_ClearVote"></a> ClearVote\(\)

```csharp
public void ClearVote()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRecordContestVote Clone()
```

#### Returns

 [CMsgClientToGCRecordContestVote](Divine.Protobufs.Dota2.CMsgClientToGCRecordContestVote.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_"></a> Equals\(CMsgClientToGCRecordContestVote\)

```csharp
public bool Equals(CMsgClientToGCRecordContestVote other)
```

#### Parameters

`other` [CMsgClientToGCRecordContestVote](Divine.Protobufs.Dota2.CMsgClientToGCRecordContestVote.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_"></a> MergeFrom\(CMsgClientToGCRecordContestVote\)

```csharp
public void MergeFrom(CMsgClientToGCRecordContestVote other)
```

#### Parameters

`other` [CMsgClientToGCRecordContestVote](Divine.Protobufs.Dota2.CMsgClientToGCRecordContestVote.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecordContestVote_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

