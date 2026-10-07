# <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer"></a> Class CMsgPartySearchPlayer

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPartySearchPlayer : IMessage<CMsgPartySearchPlayer>, IEquatable<CMsgPartySearchPlayer>, IDeepCloneable<CMsgPartySearchPlayer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPartySearchPlayer](Divine.Protobufs.Dota2.CMsgPartySearchPlayer.md)

#### Implements

IMessage<CMsgPartySearchPlayer\>, 
[IEquatable<CMsgPartySearchPlayer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPartySearchPlayer\>, 
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
[EnumerableExtensions.In<CMsgPartySearchPlayer\>\(CMsgPartySearchPlayer, params CMsgPartySearchPlayer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer__ctor"></a> CMsgPartySearchPlayer\(\)

```csharp
public CMsgPartySearchPlayer()
```

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer__ctor_Divine_Protobufs_Dota2_CMsgPartySearchPlayer_"></a> CMsgPartySearchPlayer\(CMsgPartySearchPlayer\)

```csharp
public CMsgPartySearchPlayer(CMsgPartySearchPlayer other)
```

#### Parameters

`other` [CMsgPartySearchPlayer](Divine.Protobufs.Dota2.CMsgPartySearchPlayer.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_CreationTimeFieldNumber"></a> CreationTimeFieldNumber

```csharp
public const int CreationTimeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_CreationTime"></a> CreationTime

```csharp
public uint CreationTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_HasCreationTime"></a> HasCreationTime

```csharp
public bool HasCreationTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPartySearchPlayer> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPartySearchPlayer](Divine.Protobufs.Dota2.CMsgPartySearchPlayer.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_ClearCreationTime"></a> ClearCreationTime\(\)

```csharp
public void ClearCreationTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_Clone"></a> Clone\(\)

```csharp
public CMsgPartySearchPlayer Clone()
```

#### Returns

 [CMsgPartySearchPlayer](Divine.Protobufs.Dota2.CMsgPartySearchPlayer.md)

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_Equals_Divine_Protobufs_Dota2_CMsgPartySearchPlayer_"></a> Equals\(CMsgPartySearchPlayer\)

```csharp
public bool Equals(CMsgPartySearchPlayer other)
```

#### Parameters

`other` [CMsgPartySearchPlayer](Divine.Protobufs.Dota2.CMsgPartySearchPlayer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_MergeFrom_Divine_Protobufs_Dota2_CMsgPartySearchPlayer_"></a> MergeFrom\(CMsgPartySearchPlayer\)

```csharp
public void MergeFrom(CMsgPartySearchPlayer other)
```

#### Parameters

`other` [CMsgPartySearchPlayer](Divine.Protobufs.Dota2.CMsgPartySearchPlayer.md)

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPartySearchPlayer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

