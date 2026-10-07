# <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge"></a> Class CMsgClientToGCFightingGameAnswerChallenge

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCFightingGameAnswerChallenge : IMessage<CMsgClientToGCFightingGameAnswerChallenge>, IEquatable<CMsgClientToGCFightingGameAnswerChallenge>, IDeepCloneable<CMsgClientToGCFightingGameAnswerChallenge>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCFightingGameAnswerChallenge](Divine.Protobufs.Dota2.CMsgClientToGCFightingGameAnswerChallenge.md)

#### Implements

IMessage<CMsgClientToGCFightingGameAnswerChallenge\>, 
[IEquatable<CMsgClientToGCFightingGameAnswerChallenge\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCFightingGameAnswerChallenge\>, 
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
[EnumerableExtensions.In<CMsgClientToGCFightingGameAnswerChallenge\>\(CMsgClientToGCFightingGameAnswerChallenge, params CMsgClientToGCFightingGameAnswerChallenge\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge__ctor"></a> CMsgClientToGCFightingGameAnswerChallenge\(\)

```csharp
public CMsgClientToGCFightingGameAnswerChallenge()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge__ctor_Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_"></a> CMsgClientToGCFightingGameAnswerChallenge\(CMsgClientToGCFightingGameAnswerChallenge\)

```csharp
public CMsgClientToGCFightingGameAnswerChallenge(CMsgClientToGCFightingGameAnswerChallenge other)
```

#### Parameters

`other` [CMsgClientToGCFightingGameAnswerChallenge](Divine.Protobufs.Dota2.CMsgClientToGCFightingGameAnswerChallenge.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_AcceptFieldNumber"></a> AcceptFieldNumber

```csharp
public const int AcceptFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_ChallengerAccountIdFieldNumber"></a> ChallengerAccountIdFieldNumber

```csharp
public const int ChallengerAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_Accept"></a> Accept

```csharp
public bool Accept { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_ChallengerAccountId"></a> ChallengerAccountId

```csharp
public uint ChallengerAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_HasAccept"></a> HasAccept

```csharp
public bool HasAccept { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_HasChallengerAccountId"></a> HasChallengerAccountId

```csharp
public bool HasChallengerAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCFightingGameAnswerChallenge> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCFightingGameAnswerChallenge](Divine.Protobufs.Dota2.CMsgClientToGCFightingGameAnswerChallenge.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_ClearAccept"></a> ClearAccept\(\)

```csharp
public void ClearAccept()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_ClearChallengerAccountId"></a> ClearChallengerAccountId\(\)

```csharp
public void ClearChallengerAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCFightingGameAnswerChallenge Clone()
```

#### Returns

 [CMsgClientToGCFightingGameAnswerChallenge](Divine.Protobufs.Dota2.CMsgClientToGCFightingGameAnswerChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_Equals_Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_"></a> Equals\(CMsgClientToGCFightingGameAnswerChallenge\)

```csharp
public bool Equals(CMsgClientToGCFightingGameAnswerChallenge other)
```

#### Parameters

`other` [CMsgClientToGCFightingGameAnswerChallenge](Divine.Protobufs.Dota2.CMsgClientToGCFightingGameAnswerChallenge.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_"></a> MergeFrom\(CMsgClientToGCFightingGameAnswerChallenge\)

```csharp
public void MergeFrom(CMsgClientToGCFightingGameAnswerChallenge other)
```

#### Parameters

`other` [CMsgClientToGCFightingGameAnswerChallenge](Divine.Protobufs.Dota2.CMsgClientToGCFightingGameAnswerChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameAnswerChallenge_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

