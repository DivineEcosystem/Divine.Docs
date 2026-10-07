# <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge"></a> Class CMsgSignOutUpdatePlayerChallenge.Types.Challenge

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutUpdatePlayerChallenge.Types.Challenge : IMessage<CMsgSignOutUpdatePlayerChallenge.Types.Challenge>, IEquatable<CMsgSignOutUpdatePlayerChallenge.Types.Challenge>, IDeepCloneable<CMsgSignOutUpdatePlayerChallenge.Types.Challenge>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutUpdatePlayerChallenge.Types.Challenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.Types.Challenge.md)

#### Implements

IMessage<CMsgSignOutUpdatePlayerChallenge.Types.Challenge\>, 
[IEquatable<CMsgSignOutUpdatePlayerChallenge.Types.Challenge\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutUpdatePlayerChallenge.Types.Challenge\>, 
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
[EnumerableExtensions.In<CMsgSignOutUpdatePlayerChallenge.Types.Challenge\>\(CMsgSignOutUpdatePlayerChallenge.Types.Challenge, params CMsgSignOutUpdatePlayerChallenge.Types.Challenge\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge__ctor"></a> Challenge\(\)

```csharp
public Challenge()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge__ctor_Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_"></a> Challenge\(Challenge\)

```csharp
public Challenge(CMsgSignOutUpdatePlayerChallenge.Types.Challenge other)
```

#### Parameters

`other` [CMsgSignOutUpdatePlayerChallenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.Types.md).[Challenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.Types.Challenge.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_ChallengeRankFieldNumber"></a> ChallengeRankFieldNumber

```csharp
public const int ChallengeRankFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_ProgressFieldNumber"></a> ProgressFieldNumber

```csharp
public const int ProgressFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_SequenceIdFieldNumber"></a> SequenceIdFieldNumber

```csharp
public const int SequenceIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_SlotIdFieldNumber"></a> SlotIdFieldNumber

```csharp
public const int SlotIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_ChallengeRank"></a> ChallengeRank

```csharp
public uint ChallengeRank { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_HasChallengeRank"></a> HasChallengeRank

```csharp
public bool HasChallengeRank { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_HasProgress"></a> HasProgress

```csharp
public bool HasProgress { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_HasSequenceId"></a> HasSequenceId

```csharp
public bool HasSequenceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_HasSlotId"></a> HasSlotId

```csharp
public bool HasSlotId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutUpdatePlayerChallenge.Types.Challenge> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutUpdatePlayerChallenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.Types.md).[Challenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.Types.Challenge.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_Progress"></a> Progress

```csharp
public uint Progress { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_SequenceId"></a> SequenceId

```csharp
public uint SequenceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_SlotId"></a> SlotId

```csharp
public uint SlotId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_ClearChallengeRank"></a> ClearChallengeRank\(\)

```csharp
public void ClearChallengeRank()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_ClearProgress"></a> ClearProgress\(\)

```csharp
public void ClearProgress()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_ClearSequenceId"></a> ClearSequenceId\(\)

```csharp
public void ClearSequenceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_ClearSlotId"></a> ClearSlotId\(\)

```csharp
public void ClearSlotId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutUpdatePlayerChallenge.Types.Challenge Clone()
```

#### Returns

 [CMsgSignOutUpdatePlayerChallenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.Types.md).[Challenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.Types.Challenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_Equals_Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_"></a> Equals\(Challenge\)

```csharp
public bool Equals(CMsgSignOutUpdatePlayerChallenge.Types.Challenge other)
```

#### Parameters

`other` [CMsgSignOutUpdatePlayerChallenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.Types.md).[Challenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.Types.Challenge.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_"></a> MergeFrom\(Challenge\)

```csharp
public void MergeFrom(CMsgSignOutUpdatePlayerChallenge.Types.Challenge other)
```

#### Parameters

`other` [CMsgSignOutUpdatePlayerChallenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.Types.md).[Challenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.Types.Challenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Types_Challenge_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

