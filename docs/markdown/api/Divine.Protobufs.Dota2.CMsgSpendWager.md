# <a id="Divine_Protobufs_Dota2_CMsgSpendWager"></a> Class CMsgSpendWager

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSpendWager : IMessage<CMsgSpendWager>, IEquatable<CMsgSpendWager>, IDeepCloneable<CMsgSpendWager>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSpendWager](Divine.Protobufs.Dota2.CMsgSpendWager.md)

#### Implements

IMessage<CMsgSpendWager\>, 
[IEquatable<CMsgSpendWager\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSpendWager\>, 
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
[EnumerableExtensions.In<CMsgSpendWager\>\(CMsgSpendWager, params CMsgSpendWager\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager__ctor"></a> CMsgSpendWager\(\)

```csharp
public CMsgSpendWager()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager__ctor_Divine_Protobufs_Dota2_CMsgSpendWager_"></a> CMsgSpendWager\(CMsgSpendWager\)

```csharp
public CMsgSpendWager(CMsgSpendWager other)
```

#### Parameters

`other` [CMsgSpendWager](Divine.Protobufs.Dota2.CMsgSpendWager.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_ServerSteamIdFieldNumber"></a> ServerSteamIdFieldNumber

```csharp
public const int ServerSteamIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_HasServerSteamId"></a> HasServerSteamId

```csharp
public bool HasServerSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSpendWager> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSpendWager](Divine.Protobufs.Dota2.CMsgSpendWager.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_Players"></a> Players

```csharp
public RepeatedField<CMsgSpendWager.Types.Player> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgSpendWager](Divine.Protobufs.Dota2.CMsgSpendWager.md).[Types](Divine.Protobufs.Dota2.CMsgSpendWager.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSpendWager.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_ServerSteamId"></a> ServerSteamId

```csharp
public ulong ServerSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_ClearServerSteamId"></a> ClearServerSteamId\(\)

```csharp
public void ClearServerSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_Clone"></a> Clone\(\)

```csharp
public CMsgSpendWager Clone()
```

#### Returns

 [CMsgSpendWager](Divine.Protobufs.Dota2.CMsgSpendWager.md)

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_Equals_Divine_Protobufs_Dota2_CMsgSpendWager_"></a> Equals\(CMsgSpendWager\)

```csharp
public bool Equals(CMsgSpendWager other)
```

#### Parameters

`other` [CMsgSpendWager](Divine.Protobufs.Dota2.CMsgSpendWager.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_MergeFrom_Divine_Protobufs_Dota2_CMsgSpendWager_"></a> MergeFrom\(CMsgSpendWager\)

```csharp
public void MergeFrom(CMsgSpendWager other)
```

#### Parameters

`other` [CMsgSpendWager](Divine.Protobufs.Dota2.CMsgSpendWager.md)

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSpendWager_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

