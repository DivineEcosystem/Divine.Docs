# <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress"></a> Class CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress : IMessage<CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress>, IEquatable<CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress>, IDeepCloneable<CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress.md)

#### Implements

IMessage<CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress\>, 
[IEquatable<CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress\>, 
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
[EnumerableExtensions.In<CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress\>\(CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress, params CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress__ctor"></a> ChallengeProgress\(\)

```csharp
public ChallengeProgress()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress__ctor_Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_"></a> ChallengeProgress\(ChallengeProgress\)

```csharp
public ChallengeProgress(CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress other)
```

#### Parameters

`other` [CMsgSignOutGuildChallengeProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.Types.md).[ChallengeProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_ChallengeInstanceIdFieldNumber"></a> ChallengeInstanceIdFieldNumber

```csharp
public const int ChallengeInstanceIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_ChallengeInstanceTimestampFieldNumber"></a> ChallengeInstanceTimestampFieldNumber

```csharp
public const int ChallengeInstanceTimestampFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_ChallengeParameterFieldNumber"></a> ChallengeParameterFieldNumber

```csharp
public const int ChallengeParameterFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_ChallengePeriodSerialFieldNumber"></a> ChallengePeriodSerialFieldNumber

```csharp
public const int ChallengePeriodSerialFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_ProgressFieldNumber"></a> ProgressFieldNumber

```csharp
public const int ProgressFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_ChallengeInstanceId"></a> ChallengeInstanceId

```csharp
public uint ChallengeInstanceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_ChallengeInstanceTimestamp"></a> ChallengeInstanceTimestamp

```csharp
public uint ChallengeInstanceTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_ChallengeParameter"></a> ChallengeParameter

```csharp
public uint ChallengeParameter { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_ChallengePeriodSerial"></a> ChallengePeriodSerial

```csharp
public uint ChallengePeriodSerial { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_HasChallengeInstanceId"></a> HasChallengeInstanceId

```csharp
public bool HasChallengeInstanceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_HasChallengeInstanceTimestamp"></a> HasChallengeInstanceTimestamp

```csharp
public bool HasChallengeInstanceTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_HasChallengeParameter"></a> HasChallengeParameter

```csharp
public bool HasChallengeParameter { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_HasChallengePeriodSerial"></a> HasChallengePeriodSerial

```csharp
public bool HasChallengePeriodSerial { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_HasProgress"></a> HasProgress

```csharp
public bool HasProgress { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutGuildChallengeProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.Types.md).[ChallengeProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_Progress"></a> Progress

```csharp
public uint Progress { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_ClearChallengeInstanceId"></a> ClearChallengeInstanceId\(\)

```csharp
public void ClearChallengeInstanceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_ClearChallengeInstanceTimestamp"></a> ClearChallengeInstanceTimestamp\(\)

```csharp
public void ClearChallengeInstanceTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_ClearChallengeParameter"></a> ClearChallengeParameter\(\)

```csharp
public void ClearChallengeParameter()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_ClearChallengePeriodSerial"></a> ClearChallengePeriodSerial\(\)

```csharp
public void ClearChallengePeriodSerial()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_ClearProgress"></a> ClearProgress\(\)

```csharp
public void ClearProgress()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress Clone()
```

#### Returns

 [CMsgSignOutGuildChallengeProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.Types.md).[ChallengeProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_Equals_Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_"></a> Equals\(ChallengeProgress\)

```csharp
public bool Equals(CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress other)
```

#### Parameters

`other` [CMsgSignOutGuildChallengeProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.Types.md).[ChallengeProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_"></a> MergeFrom\(ChallengeProgress\)

```csharp
public void MergeFrom(CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress other)
```

#### Parameters

`other` [CMsgSignOutGuildChallengeProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.Types.md).[ChallengeProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Types_ChallengeProgress_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

