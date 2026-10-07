# <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge"></a> Class CMsgGuildChallenge

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGuildChallenge : IMessage<CMsgGuildChallenge>, IEquatable<CMsgGuildChallenge>, IDeepCloneable<CMsgGuildChallenge>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGuildChallenge](Divine.Protobufs.Dota2.CMsgGuildChallenge.md)

#### Implements

IMessage<CMsgGuildChallenge\>, 
[IEquatable<CMsgGuildChallenge\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGuildChallenge\>, 
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
[EnumerableExtensions.In<CMsgGuildChallenge\>\(CMsgGuildChallenge, params CMsgGuildChallenge\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge__ctor"></a> CMsgGuildChallenge\(\)

```csharp
public CMsgGuildChallenge()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge__ctor_Divine_Protobufs_Dota2_CMsgGuildChallenge_"></a> CMsgGuildChallenge\(CMsgGuildChallenge\)

```csharp
public CMsgGuildChallenge(CMsgGuildChallenge other)
```

#### Parameters

`other` [CMsgGuildChallenge](Divine.Protobufs.Dota2.CMsgGuildChallenge.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_ChallengeFlagsFieldNumber"></a> ChallengeFlagsFieldNumber

```csharp
public const int ChallengeFlagsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_ChallengeInstanceIdFieldNumber"></a> ChallengeInstanceIdFieldNumber

```csharp
public const int ChallengeInstanceIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_ChallengeParameterFieldNumber"></a> ChallengeParameterFieldNumber

```csharp
public const int ChallengeParameterFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_ChallengeProgressFieldNumber"></a> ChallengeProgressFieldNumber

```csharp
public const int ChallengeProgressFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_ChallengeTimestampFieldNumber"></a> ChallengeTimestampFieldNumber

```csharp
public const int ChallengeTimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_ChallengeFlags"></a> ChallengeFlags

```csharp
public uint ChallengeFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_ChallengeInstanceId"></a> ChallengeInstanceId

```csharp
public uint ChallengeInstanceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_ChallengeParameter"></a> ChallengeParameter

```csharp
public uint ChallengeParameter { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_ChallengeProgress"></a> ChallengeProgress

```csharp
public uint ChallengeProgress { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_ChallengeTimestamp"></a> ChallengeTimestamp

```csharp
public uint ChallengeTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_HasChallengeFlags"></a> HasChallengeFlags

```csharp
public bool HasChallengeFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_HasChallengeInstanceId"></a> HasChallengeInstanceId

```csharp
public bool HasChallengeInstanceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_HasChallengeParameter"></a> HasChallengeParameter

```csharp
public bool HasChallengeParameter { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_HasChallengeProgress"></a> HasChallengeProgress

```csharp
public bool HasChallengeProgress { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_HasChallengeTimestamp"></a> HasChallengeTimestamp

```csharp
public bool HasChallengeTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGuildChallenge> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGuildChallenge](Divine.Protobufs.Dota2.CMsgGuildChallenge.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_ClearChallengeFlags"></a> ClearChallengeFlags\(\)

```csharp
public void ClearChallengeFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_ClearChallengeInstanceId"></a> ClearChallengeInstanceId\(\)

```csharp
public void ClearChallengeInstanceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_ClearChallengeParameter"></a> ClearChallengeParameter\(\)

```csharp
public void ClearChallengeParameter()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_ClearChallengeProgress"></a> ClearChallengeProgress\(\)

```csharp
public void ClearChallengeProgress()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_ClearChallengeTimestamp"></a> ClearChallengeTimestamp\(\)

```csharp
public void ClearChallengeTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_Clone"></a> Clone\(\)

```csharp
public CMsgGuildChallenge Clone()
```

#### Returns

 [CMsgGuildChallenge](Divine.Protobufs.Dota2.CMsgGuildChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_Equals_Divine_Protobufs_Dota2_CMsgGuildChallenge_"></a> Equals\(CMsgGuildChallenge\)

```csharp
public bool Equals(CMsgGuildChallenge other)
```

#### Parameters

`other` [CMsgGuildChallenge](Divine.Protobufs.Dota2.CMsgGuildChallenge.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_MergeFrom_Divine_Protobufs_Dota2_CMsgGuildChallenge_"></a> MergeFrom\(CMsgGuildChallenge\)

```csharp
public void MergeFrom(CMsgGuildChallenge other)
```

#### Parameters

`other` [CMsgGuildChallenge](Divine.Protobufs.Dota2.CMsgGuildChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildChallenge_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

