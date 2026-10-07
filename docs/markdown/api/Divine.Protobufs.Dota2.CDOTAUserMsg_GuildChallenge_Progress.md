# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress"></a> Class CDOTAUserMsg\_GuildChallenge\_Progress

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_GuildChallenge_Progress : IMessage<CDOTAUserMsg_GuildChallenge_Progress>, IEquatable<CDOTAUserMsg_GuildChallenge_Progress>, IDeepCloneable<CDOTAUserMsg_GuildChallenge_Progress>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_GuildChallenge\_Progress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.md)

#### Implements

IMessage<CDOTAUserMsg\_GuildChallenge\_Progress\>, 
[IEquatable<CDOTAUserMsg\_GuildChallenge\_Progress\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_GuildChallenge\_Progress\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_GuildChallenge\_Progress\>\(CDOTAUserMsg\_GuildChallenge\_Progress, params CDOTAUserMsg\_GuildChallenge\_Progress\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress__ctor"></a> CDOTAUserMsg\_GuildChallenge\_Progress\(\)

```csharp
public CDOTAUserMsg_GuildChallenge_Progress()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_"></a> CDOTAUserMsg\_GuildChallenge\_Progress\(CDOTAUserMsg\_GuildChallenge\_Progress\)

```csharp
public CDOTAUserMsg_GuildChallenge_Progress(CDOTAUserMsg_GuildChallenge_Progress other)
```

#### Parameters

`other` [CDOTAUserMsg\_GuildChallenge\_Progress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_ChallengeInstanceIdFieldNumber"></a> ChallengeInstanceIdFieldNumber

```csharp
public const int ChallengeInstanceIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_ChallengeParameterFieldNumber"></a> ChallengeParameterFieldNumber

```csharp
public const int ChallengeParameterFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_ChallengeProgressAtStartFieldNumber"></a> ChallengeProgressAtStartFieldNumber

```csharp
public const int ChallengeProgressAtStartFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_ChallengeTypeFieldNumber"></a> ChallengeTypeFieldNumber

```csharp
public const int ChallengeTypeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_CompleteFieldNumber"></a> CompleteFieldNumber

```csharp
public const int CompleteFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_PlayerProgressFieldNumber"></a> PlayerProgressFieldNumber

```csharp
public const int PlayerProgressFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_ChallengeInstanceId"></a> ChallengeInstanceId

```csharp
public uint ChallengeInstanceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_ChallengeParameter"></a> ChallengeParameter

```csharp
public uint ChallengeParameter { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_ChallengeProgressAtStart"></a> ChallengeProgressAtStart

```csharp
public uint ChallengeProgressAtStart { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_ChallengeType"></a> ChallengeType

```csharp
public CDOTAUserMsg_GuildChallenge_Progress.Types.EChallengeType ChallengeType { get; set; }
```

#### Property Value

 [CDOTAUserMsg\_GuildChallenge\_Progress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.Types.md).[EChallengeType](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.Types.EChallengeType.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Complete"></a> Complete

```csharp
public bool Complete { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_HasChallengeInstanceId"></a> HasChallengeInstanceId

```csharp
public bool HasChallengeInstanceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_HasChallengeParameter"></a> HasChallengeParameter

```csharp
public bool HasChallengeParameter { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_HasChallengeProgressAtStart"></a> HasChallengeProgressAtStart

```csharp
public bool HasChallengeProgressAtStart { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_HasChallengeType"></a> HasChallengeType

```csharp
public bool HasChallengeType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_HasComplete"></a> HasComplete

```csharp
public bool HasComplete { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_GuildChallenge_Progress> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_GuildChallenge\_Progress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_PlayerProgress"></a> PlayerProgress

```csharp
public RepeatedField<CDOTAUserMsg_GuildChallenge_Progress.Types.PlayerProgress> PlayerProgress { get; }
```

#### Property Value

 RepeatedField<[CDOTAUserMsg\_GuildChallenge\_Progress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.Types.md).[PlayerProgress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.Types.PlayerProgress.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_ClearChallengeInstanceId"></a> ClearChallengeInstanceId\(\)

```csharp
public void ClearChallengeInstanceId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_ClearChallengeParameter"></a> ClearChallengeParameter\(\)

```csharp
public void ClearChallengeParameter()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_ClearChallengeProgressAtStart"></a> ClearChallengeProgressAtStart\(\)

```csharp
public void ClearChallengeProgressAtStart()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_ClearChallengeType"></a> ClearChallengeType\(\)

```csharp
public void ClearChallengeType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_ClearComplete"></a> ClearComplete\(\)

```csharp
public void ClearComplete()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_GuildChallenge_Progress Clone()
```

#### Returns

 [CDOTAUserMsg\_GuildChallenge\_Progress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_"></a> Equals\(CDOTAUserMsg\_GuildChallenge\_Progress\)

```csharp
public bool Equals(CDOTAUserMsg_GuildChallenge_Progress other)
```

#### Parameters

`other` [CDOTAUserMsg\_GuildChallenge\_Progress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_"></a> MergeFrom\(CDOTAUserMsg\_GuildChallenge\_Progress\)

```csharp
public void MergeFrom(CDOTAUserMsg_GuildChallenge_Progress other)
```

#### Parameters

`other` [CDOTAUserMsg\_GuildChallenge\_Progress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

