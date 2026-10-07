# <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins"></a> Class CMsgSignOutXPCoins

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutXPCoins : IMessage<CMsgSignOutXPCoins>, IEquatable<CMsgSignOutXPCoins>, IDeepCloneable<CMsgSignOutXPCoins>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutXPCoins](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.md)

#### Implements

IMessage<CMsgSignOutXPCoins\>, 
[IEquatable<CMsgSignOutXPCoins\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutXPCoins\>, 
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
[EnumerableExtensions.In<CMsgSignOutXPCoins\>\(CMsgSignOutXPCoins, params CMsgSignOutXPCoins\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins__ctor"></a> CMsgSignOutXPCoins\(\)

```csharp
public CMsgSignOutXPCoins()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins__ctor_Divine_Protobufs_Dota2_CMsgSignOutXPCoins_"></a> CMsgSignOutXPCoins\(CMsgSignOutXPCoins\)

```csharp
public CMsgSignOutXPCoins(CMsgSignOutXPCoins other)
```

#### Parameters

`other` [CMsgSignOutXPCoins](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutXPCoins> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutXPCoins](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Players"></a> Players

```csharp
public RepeatedField<CMsgSignOutXPCoins.Types.Player> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgSignOutXPCoins](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutXPCoins Clone()
```

#### Returns

 [CMsgSignOutXPCoins](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_Equals_Divine_Protobufs_Dota2_CMsgSignOutXPCoins_"></a> Equals\(CMsgSignOutXPCoins\)

```csharp
public bool Equals(CMsgSignOutXPCoins other)
```

#### Parameters

`other` [CMsgSignOutXPCoins](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutXPCoins_"></a> MergeFrom\(CMsgSignOutXPCoins\)

```csharp
public void MergeFrom(CMsgSignOutXPCoins other)
```

#### Parameters

`other` [CMsgSignOutXPCoins](Divine.Protobufs.Dota2.CMsgSignOutXPCoins.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutXPCoins_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

