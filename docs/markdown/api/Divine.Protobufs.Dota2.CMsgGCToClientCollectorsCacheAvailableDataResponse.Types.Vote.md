# <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote"></a> Class CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote : IMessage<CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote>, IEquatable<CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote>, IDeepCloneable<CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote.md)

#### Implements

IMessage<CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote\>, 
[IEquatable<CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote\>, 
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
[EnumerableExtensions.In<CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote\>\(CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote, params CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote__ctor"></a> Vote\(\)

```csharp
public Vote()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote__ctor_Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_"></a> Vote\(Vote\)

```csharp
public Vote(CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote other)
```

#### Parameters

`other` [CMsgGCToClientCollectorsCacheAvailableDataResponse](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.md).[Vote](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_ItemDefFieldNumber"></a> ItemDefFieldNumber

```csharp
public const int ItemDefFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_VoteTypeFieldNumber"></a> VoteTypeFieldNumber

```csharp
public const int VoteTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_HasItemDef"></a> HasItemDef

```csharp
public bool HasItemDef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_HasVoteType"></a> HasVoteType

```csharp
public bool HasVoteType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_ItemDef"></a> ItemDef

```csharp
public uint ItemDef { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientCollectorsCacheAvailableDataResponse](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.md).[Vote](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_VoteType"></a> VoteType

```csharp
public CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote.Types.EVoteType VoteType { get; set; }
```

#### Property Value

 [CMsgGCToClientCollectorsCacheAvailableDataResponse](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.md).[Vote](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote.Types.md).[EVoteType](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote.Types.EVoteType.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_ClearItemDef"></a> ClearItemDef\(\)

```csharp
public void ClearItemDef()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_ClearVoteType"></a> ClearVoteType\(\)

```csharp
public void ClearVoteType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote Clone()
```

#### Returns

 [CMsgGCToClientCollectorsCacheAvailableDataResponse](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.md).[Vote](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_Equals_Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_"></a> Equals\(Vote\)

```csharp
public bool Equals(CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote other)
```

#### Parameters

`other` [CMsgGCToClientCollectorsCacheAvailableDataResponse](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.md).[Vote](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_"></a> MergeFrom\(Vote\)

```csharp
public void MergeFrom(CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote other)
```

#### Parameters

`other` [CMsgGCToClientCollectorsCacheAvailableDataResponse](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.md).[Vote](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Types_Vote_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

