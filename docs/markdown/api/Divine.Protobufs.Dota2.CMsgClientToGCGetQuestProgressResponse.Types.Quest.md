# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest"></a> Class CMsgClientToGCGetQuestProgressResponse.Types.Quest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetQuestProgressResponse.Types.Quest : IMessage<CMsgClientToGCGetQuestProgressResponse.Types.Quest>, IEquatable<CMsgClientToGCGetQuestProgressResponse.Types.Quest>, IDeepCloneable<CMsgClientToGCGetQuestProgressResponse.Types.Quest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetQuestProgressResponse.Types.Quest](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.Quest.md)

#### Implements

IMessage<CMsgClientToGCGetQuestProgressResponse.Types.Quest\>, 
[IEquatable<CMsgClientToGCGetQuestProgressResponse.Types.Quest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetQuestProgressResponse.Types.Quest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetQuestProgressResponse.Types.Quest\>\(CMsgClientToGCGetQuestProgressResponse.Types.Quest, params CMsgClientToGCGetQuestProgressResponse.Types.Quest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest__ctor"></a> Quest\(\)

```csharp
public Quest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_"></a> Quest\(Quest\)

```csharp
public Quest(CMsgClientToGCGetQuestProgressResponse.Types.Quest other)
```

#### Parameters

`other` [CMsgClientToGCGetQuestProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.md).[Quest](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.Quest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_CompletedChallengesFieldNumber"></a> CompletedChallengesFieldNumber

```csharp
public const int CompletedChallengesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_QuestIdFieldNumber"></a> QuestIdFieldNumber

```csharp
public const int QuestIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_CompletedChallenges"></a> CompletedChallenges

```csharp
public RepeatedField<CMsgClientToGCGetQuestProgressResponse.Types.Challenge> CompletedChallenges { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCGetQuestProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.md).[Challenge](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.Challenge.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_HasQuestId"></a> HasQuestId

```csharp
public bool HasQuestId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetQuestProgressResponse.Types.Quest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetQuestProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.md).[Quest](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.Quest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_QuestId"></a> QuestId

```csharp
public uint QuestId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_ClearQuestId"></a> ClearQuestId\(\)

```csharp
public void ClearQuestId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetQuestProgressResponse.Types.Quest Clone()
```

#### Returns

 [CMsgClientToGCGetQuestProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.md).[Quest](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.Quest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_"></a> Equals\(Quest\)

```csharp
public bool Equals(CMsgClientToGCGetQuestProgressResponse.Types.Quest other)
```

#### Parameters

`other` [CMsgClientToGCGetQuestProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.md).[Quest](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.Quest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_"></a> MergeFrom\(Quest\)

```csharp
public void MergeFrom(CMsgClientToGCGetQuestProgressResponse.Types.Quest other)
```

#### Parameters

`other` [CMsgClientToGCGetQuestProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.md).[Quest](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.Quest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Types_Quest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

