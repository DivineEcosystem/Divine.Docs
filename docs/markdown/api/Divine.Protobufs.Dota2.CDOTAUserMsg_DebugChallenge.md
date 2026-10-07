# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge"></a> Class CDOTAUserMsg\_DebugChallenge

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_DebugChallenge : IMessage<CDOTAUserMsg_DebugChallenge>, IEquatable<CDOTAUserMsg_DebugChallenge>, IDeepCloneable<CDOTAUserMsg_DebugChallenge>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_DebugChallenge](Divine.Protobufs.Dota2.CDOTAUserMsg\_DebugChallenge.md)

#### Implements

IMessage<CDOTAUserMsg\_DebugChallenge\>, 
[IEquatable<CDOTAUserMsg\_DebugChallenge\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_DebugChallenge\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_DebugChallenge\>\(CDOTAUserMsg\_DebugChallenge, params CDOTAUserMsg\_DebugChallenge\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge__ctor"></a> CDOTAUserMsg\_DebugChallenge\(\)

```csharp
public CDOTAUserMsg_DebugChallenge()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_"></a> CDOTAUserMsg\_DebugChallenge\(CDOTAUserMsg\_DebugChallenge\)

```csharp
public CDOTAUserMsg_DebugChallenge(CDOTAUserMsg_DebugChallenge other)
```

#### Parameters

`other` [CDOTAUserMsg\_DebugChallenge](Divine.Protobufs.Dota2.CDOTAUserMsg\_DebugChallenge.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_ChallengeMaxRankFieldNumber"></a> ChallengeMaxRankFieldNumber

```csharp
public const int ChallengeMaxRankFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_ChallengeQueryIdFieldNumber"></a> ChallengeQueryIdFieldNumber

```csharp
public const int ChallengeQueryIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_ChallengeTypeFieldNumber"></a> ChallengeTypeFieldNumber

```csharp
public const int ChallengeTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_ChallengeVar0FieldNumber"></a> ChallengeVar0FieldNumber

```csharp
public const int ChallengeVar0FieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_ChallengeVar1FieldNumber"></a> ChallengeVar1FieldNumber

```csharp
public const int ChallengeVar1FieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_InstanceIdFieldNumber"></a> InstanceIdFieldNumber

```csharp
public const int InstanceIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_ChallengeMaxRank"></a> ChallengeMaxRank

```csharp
public uint ChallengeMaxRank { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_ChallengeQueryId"></a> ChallengeQueryId

```csharp
public uint ChallengeQueryId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_ChallengeType"></a> ChallengeType

```csharp
public uint ChallengeType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_ChallengeVar0"></a> ChallengeVar0

```csharp
public uint ChallengeVar0 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_ChallengeVar1"></a> ChallengeVar1

```csharp
public uint ChallengeVar1 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_HasChallengeMaxRank"></a> HasChallengeMaxRank

```csharp
public bool HasChallengeMaxRank { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_HasChallengeQueryId"></a> HasChallengeQueryId

```csharp
public bool HasChallengeQueryId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_HasChallengeType"></a> HasChallengeType

```csharp
public bool HasChallengeType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_HasChallengeVar0"></a> HasChallengeVar0

```csharp
public bool HasChallengeVar0 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_HasChallengeVar1"></a> HasChallengeVar1

```csharp
public bool HasChallengeVar1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_HasInstanceId"></a> HasInstanceId

```csharp
public bool HasInstanceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_InstanceId"></a> InstanceId

```csharp
public uint InstanceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_DebugChallenge> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_DebugChallenge](Divine.Protobufs.Dota2.CDOTAUserMsg\_DebugChallenge.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_ClearChallengeMaxRank"></a> ClearChallengeMaxRank\(\)

```csharp
public void ClearChallengeMaxRank()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_ClearChallengeQueryId"></a> ClearChallengeQueryId\(\)

```csharp
public void ClearChallengeQueryId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_ClearChallengeType"></a> ClearChallengeType\(\)

```csharp
public void ClearChallengeType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_ClearChallengeVar0"></a> ClearChallengeVar0\(\)

```csharp
public void ClearChallengeVar0()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_ClearChallengeVar1"></a> ClearChallengeVar1\(\)

```csharp
public void ClearChallengeVar1()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_ClearInstanceId"></a> ClearInstanceId\(\)

```csharp
public void ClearInstanceId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_DebugChallenge Clone()
```

#### Returns

 [CDOTAUserMsg\_DebugChallenge](Divine.Protobufs.Dota2.CDOTAUserMsg\_DebugChallenge.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_"></a> Equals\(CDOTAUserMsg\_DebugChallenge\)

```csharp
public bool Equals(CDOTAUserMsg_DebugChallenge other)
```

#### Parameters

`other` [CDOTAUserMsg\_DebugChallenge](Divine.Protobufs.Dota2.CDOTAUserMsg\_DebugChallenge.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_"></a> MergeFrom\(CDOTAUserMsg\_DebugChallenge\)

```csharp
public void MergeFrom(CDOTAUserMsg_DebugChallenge other)
```

#### Parameters

`other` [CDOTAUserMsg\_DebugChallenge](Divine.Protobufs.Dota2.CDOTAUserMsg\_DebugChallenge.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DebugChallenge_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

