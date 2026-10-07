# <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge"></a> Class CLobbyGuildChallenge

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CLobbyGuildChallenge : IMessage<CLobbyGuildChallenge>, IEquatable<CLobbyGuildChallenge>, IDeepCloneable<CLobbyGuildChallenge>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CLobbyGuildChallenge](Divine.Protobufs.Dota2.CLobbyGuildChallenge.md)

#### Implements

IMessage<CLobbyGuildChallenge\>, 
[IEquatable<CLobbyGuildChallenge\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CLobbyGuildChallenge\>, 
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
[EnumerableExtensions.In<CLobbyGuildChallenge\>\(CLobbyGuildChallenge, params CLobbyGuildChallenge\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge__ctor"></a> CLobbyGuildChallenge\(\)

```csharp
public CLobbyGuildChallenge()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge__ctor_Divine_Protobufs_Dota2_CLobbyGuildChallenge_"></a> CLobbyGuildChallenge\(CLobbyGuildChallenge\)

```csharp
public CLobbyGuildChallenge(CLobbyGuildChallenge other)
```

#### Parameters

`other` [CLobbyGuildChallenge](Divine.Protobufs.Dota2.CLobbyGuildChallenge.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_ChallengeInstanceIdFieldNumber"></a> ChallengeInstanceIdFieldNumber

```csharp
public const int ChallengeInstanceIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_ChallengeParameterFieldNumber"></a> ChallengeParameterFieldNumber

```csharp
public const int ChallengeParameterFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_ChallengePeriodSerialFieldNumber"></a> ChallengePeriodSerialFieldNumber

```csharp
public const int ChallengePeriodSerialFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_ChallengeProgressAtStartFieldNumber"></a> ChallengeProgressAtStartFieldNumber

```csharp
public const int ChallengeProgressAtStartFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_ChallengeTimestampFieldNumber"></a> ChallengeTimestampFieldNumber

```csharp
public const int ChallengeTimestampFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_EligibleAccountIdsFieldNumber"></a> EligibleAccountIdsFieldNumber

```csharp
public const int EligibleAccountIdsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_ChallengeInstanceId"></a> ChallengeInstanceId

```csharp
public uint ChallengeInstanceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_ChallengeParameter"></a> ChallengeParameter

```csharp
public uint ChallengeParameter { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_ChallengePeriodSerial"></a> ChallengePeriodSerial

```csharp
public uint ChallengePeriodSerial { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_ChallengeProgressAtStart"></a> ChallengeProgressAtStart

```csharp
public uint ChallengeProgressAtStart { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_ChallengeTimestamp"></a> ChallengeTimestamp

```csharp
public uint ChallengeTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_EligibleAccountIds"></a> EligibleAccountIds

```csharp
public RepeatedField<uint> EligibleAccountIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_HasChallengeInstanceId"></a> HasChallengeInstanceId

```csharp
public bool HasChallengeInstanceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_HasChallengeParameter"></a> HasChallengeParameter

```csharp
public bool HasChallengeParameter { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_HasChallengePeriodSerial"></a> HasChallengePeriodSerial

```csharp
public bool HasChallengePeriodSerial { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_HasChallengeProgressAtStart"></a> HasChallengeProgressAtStart

```csharp
public bool HasChallengeProgressAtStart { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_HasChallengeTimestamp"></a> HasChallengeTimestamp

```csharp
public bool HasChallengeTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_Parser"></a> Parser

```csharp
public static MessageParser<CLobbyGuildChallenge> Parser { get; }
```

#### Property Value

 MessageParser<[CLobbyGuildChallenge](Divine.Protobufs.Dota2.CLobbyGuildChallenge.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_ClearChallengeInstanceId"></a> ClearChallengeInstanceId\(\)

```csharp
public void ClearChallengeInstanceId()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_ClearChallengeParameter"></a> ClearChallengeParameter\(\)

```csharp
public void ClearChallengeParameter()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_ClearChallengePeriodSerial"></a> ClearChallengePeriodSerial\(\)

```csharp
public void ClearChallengePeriodSerial()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_ClearChallengeProgressAtStart"></a> ClearChallengeProgressAtStart\(\)

```csharp
public void ClearChallengeProgressAtStart()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_ClearChallengeTimestamp"></a> ClearChallengeTimestamp\(\)

```csharp
public void ClearChallengeTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_Clone"></a> Clone\(\)

```csharp
public CLobbyGuildChallenge Clone()
```

#### Returns

 [CLobbyGuildChallenge](Divine.Protobufs.Dota2.CLobbyGuildChallenge.md)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_Equals_Divine_Protobufs_Dota2_CLobbyGuildChallenge_"></a> Equals\(CLobbyGuildChallenge\)

```csharp
public bool Equals(CLobbyGuildChallenge other)
```

#### Parameters

`other` [CLobbyGuildChallenge](Divine.Protobufs.Dota2.CLobbyGuildChallenge.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_MergeFrom_Divine_Protobufs_Dota2_CLobbyGuildChallenge_"></a> MergeFrom\(CLobbyGuildChallenge\)

```csharp
public void MergeFrom(CLobbyGuildChallenge other)
```

#### Parameters

`other` [CLobbyGuildChallenge](Divine.Protobufs.Dota2.CLobbyGuildChallenge.md)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CLobbyGuildChallenge_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

