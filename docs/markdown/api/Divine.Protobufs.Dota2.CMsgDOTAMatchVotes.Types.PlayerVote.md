# <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote"></a> Class CMsgDOTAMatchVotes.Types.PlayerVote

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAMatchVotes.Types.PlayerVote : IMessage<CMsgDOTAMatchVotes.Types.PlayerVote>, IEquatable<CMsgDOTAMatchVotes.Types.PlayerVote>, IDeepCloneable<CMsgDOTAMatchVotes.Types.PlayerVote>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAMatchVotes.Types.PlayerVote](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.Types.PlayerVote.md)

#### Implements

IMessage<CMsgDOTAMatchVotes.Types.PlayerVote\>, 
[IEquatable<CMsgDOTAMatchVotes.Types.PlayerVote\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAMatchVotes.Types.PlayerVote\>, 
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
[EnumerableExtensions.In<CMsgDOTAMatchVotes.Types.PlayerVote\>\(CMsgDOTAMatchVotes.Types.PlayerVote, params CMsgDOTAMatchVotes.Types.PlayerVote\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote__ctor"></a> PlayerVote\(\)

```csharp
public PlayerVote()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote__ctor_Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_"></a> PlayerVote\(PlayerVote\)

```csharp
public PlayerVote(CMsgDOTAMatchVotes.Types.PlayerVote other)
```

#### Parameters

`other` [CMsgDOTAMatchVotes](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.Types.md).[PlayerVote](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.Types.PlayerVote.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_VoteFieldNumber"></a> VoteFieldNumber

```csharp
public const int VoteFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_HasVote"></a> HasVote

```csharp
public bool HasVote { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAMatchVotes.Types.PlayerVote> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAMatchVotes](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.Types.md).[PlayerVote](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.Types.PlayerVote.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_Vote"></a> Vote

```csharp
public uint Vote { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_ClearVote"></a> ClearVote\(\)

```csharp
public void ClearVote()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAMatchVotes.Types.PlayerVote Clone()
```

#### Returns

 [CMsgDOTAMatchVotes](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.Types.md).[PlayerVote](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.Types.PlayerVote.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_Equals_Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_"></a> Equals\(PlayerVote\)

```csharp
public bool Equals(CMsgDOTAMatchVotes.Types.PlayerVote other)
```

#### Parameters

`other` [CMsgDOTAMatchVotes](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.Types.md).[PlayerVote](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.Types.PlayerVote.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_"></a> MergeFrom\(PlayerVote\)

```csharp
public void MergeFrom(CMsgDOTAMatchVotes.Types.PlayerVote other)
```

#### Parameters

`other` [CMsgDOTAMatchVotes](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.Types.md).[PlayerVote](Divine.Protobufs.Dota2.CMsgDOTAMatchVotes.Types.PlayerVote.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchVotes_Types_PlayerVote_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

