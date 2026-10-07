# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge"></a> Class CMsgClientToGCGetQuestProgressResponse.Types.Challenge

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetQuestProgressResponse.Types.Challenge : IMessage<CMsgClientToGCGetQuestProgressResponse.Types.Challenge>, IEquatable<CMsgClientToGCGetQuestProgressResponse.Types.Challenge>, IDeepCloneable<CMsgClientToGCGetQuestProgressResponse.Types.Challenge>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetQuestProgressResponse.Types.Challenge](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.Challenge.md)

#### Implements

IMessage<CMsgClientToGCGetQuestProgressResponse.Types.Challenge\>, 
[IEquatable<CMsgClientToGCGetQuestProgressResponse.Types.Challenge\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetQuestProgressResponse.Types.Challenge\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetQuestProgressResponse.Types.Challenge\>\(CMsgClientToGCGetQuestProgressResponse.Types.Challenge, params CMsgClientToGCGetQuestProgressResponse.Types.Challenge\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge__ctor"></a> Challenge\(\)

```csharp
public Challenge()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_"></a> Challenge\(Challenge\)

```csharp
public Challenge(CMsgClientToGCGetQuestProgressResponse.Types.Challenge other)
```

#### Parameters

`other` [CMsgClientToGCGetQuestProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.md).[Challenge](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.Challenge.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_AttemptsFieldNumber"></a> AttemptsFieldNumber

```csharp
public const int AttemptsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_ChallengeIdFieldNumber"></a> ChallengeIdFieldNumber

```csharp
public const int ChallengeIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_QuestRankFieldNumber"></a> QuestRankFieldNumber

```csharp
public const int QuestRankFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_TemplateIdFieldNumber"></a> TemplateIdFieldNumber

```csharp
public const int TemplateIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_TimeCompletedFieldNumber"></a> TimeCompletedFieldNumber

```csharp
public const int TimeCompletedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_Attempts"></a> Attempts

```csharp
public uint Attempts { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_ChallengeId"></a> ChallengeId

```csharp
public uint ChallengeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_HasAttempts"></a> HasAttempts

```csharp
public bool HasAttempts { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_HasChallengeId"></a> HasChallengeId

```csharp
public bool HasChallengeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_HasQuestRank"></a> HasQuestRank

```csharp
public bool HasQuestRank { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_HasTemplateId"></a> HasTemplateId

```csharp
public bool HasTemplateId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_HasTimeCompleted"></a> HasTimeCompleted

```csharp
public bool HasTimeCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetQuestProgressResponse.Types.Challenge> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetQuestProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.md).[Challenge](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.Challenge.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_QuestRank"></a> QuestRank

```csharp
public uint QuestRank { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_TemplateId"></a> TemplateId

```csharp
public uint TemplateId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_TimeCompleted"></a> TimeCompleted

```csharp
public uint TimeCompleted { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_ClearAttempts"></a> ClearAttempts\(\)

```csharp
public void ClearAttempts()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_ClearChallengeId"></a> ClearChallengeId\(\)

```csharp
public void ClearChallengeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_ClearQuestRank"></a> ClearQuestRank\(\)

```csharp
public void ClearQuestRank()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_ClearTemplateId"></a> ClearTemplateId\(\)

```csharp
public void ClearTemplateId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_ClearTimeCompleted"></a> ClearTimeCompleted\(\)

```csharp
public void ClearTimeCompleted()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetQuestProgressResponse.Types.Challenge Clone()
```

#### Returns

 [CMsgClientToGCGetQuestProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.md).[Challenge](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.Challenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_"></a> Equals\(Challenge\)

```csharp
public bool Equals(CMsgClientToGCGetQuestProgressResponse.Types.Challenge other)
```

#### Parameters

`other` [CMsgClientToGCGetQuestProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.md).[Challenge](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.Challenge.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_"></a> MergeFrom\(Challenge\)

```csharp
public void MergeFrom(CMsgClientToGCGetQuestProgressResponse.Types.Challenge other)
```

#### Parameters

`other` [CMsgClientToGCGetQuestProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.md).[Challenge](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.Challenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Challenge_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

