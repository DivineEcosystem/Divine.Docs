# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus"></a> Class CDOTAClientMsg\_QuestStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_QuestStatus : IMessage<CDOTAClientMsg_QuestStatus>, IEquatable<CDOTAClientMsg_QuestStatus>, IDeepCloneable<CDOTAClientMsg_QuestStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_QuestStatus](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuestStatus.md)

#### Implements

IMessage<CDOTAClientMsg\_QuestStatus\>, 
[IEquatable<CDOTAClientMsg\_QuestStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_QuestStatus\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_QuestStatus\>\(CDOTAClientMsg\_QuestStatus, params CDOTAClientMsg\_QuestStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus__ctor"></a> CDOTAClientMsg\_QuestStatus\(\)

```csharp
public CDOTAClientMsg_QuestStatus()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_"></a> CDOTAClientMsg\_QuestStatus\(CDOTAClientMsg\_QuestStatus\)

```csharp
public CDOTAClientMsg_QuestStatus(CDOTAClientMsg_QuestStatus other)
```

#### Parameters

`other` [CDOTAClientMsg\_QuestStatus](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuestStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_ChallengeIdFieldNumber"></a> ChallengeIdFieldNumber

```csharp
public const int ChallengeIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_FailGametimeFieldNumber"></a> FailGametimeFieldNumber

```csharp
public const int FailGametimeFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_GoalFieldNumber"></a> GoalFieldNumber

```csharp
public const int GoalFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_ItemAbilityIdFieldNumber"></a> ItemAbilityIdFieldNumber

```csharp
public const int ItemAbilityIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_ProgressFieldNumber"></a> ProgressFieldNumber

```csharp
public const int ProgressFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_QueryFieldNumber"></a> QueryFieldNumber

```csharp
public const int QueryFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_QuestIdFieldNumber"></a> QuestIdFieldNumber

```csharp
public const int QuestIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_ChallengeId"></a> ChallengeId

```csharp
public uint ChallengeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_FailGametime"></a> FailGametime

```csharp
public float FailGametime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_Goal"></a> Goal

```csharp
public uint Goal { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_HasChallengeId"></a> HasChallengeId

```csharp
public bool HasChallengeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_HasFailGametime"></a> HasFailGametime

```csharp
public bool HasFailGametime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_HasGoal"></a> HasGoal

```csharp
public bool HasGoal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_HasItemAbilityId"></a> HasItemAbilityId

```csharp
public bool HasItemAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_HasProgress"></a> HasProgress

```csharp
public bool HasProgress { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_HasQuery"></a> HasQuery

```csharp
public bool HasQuery { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_HasQuestId"></a> HasQuestId

```csharp
public bool HasQuestId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_ItemAbilityId"></a> ItemAbilityId

```csharp
public int ItemAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_QuestStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_QuestStatus](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuestStatus.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_Progress"></a> Progress

```csharp
public uint Progress { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_Query"></a> Query

```csharp
public uint Query { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_QuestId"></a> QuestId

```csharp
public uint QuestId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_ClearChallengeId"></a> ClearChallengeId\(\)

```csharp
public void ClearChallengeId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_ClearFailGametime"></a> ClearFailGametime\(\)

```csharp
public void ClearFailGametime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_ClearGoal"></a> ClearGoal\(\)

```csharp
public void ClearGoal()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_ClearItemAbilityId"></a> ClearItemAbilityId\(\)

```csharp
public void ClearItemAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_ClearProgress"></a> ClearProgress\(\)

```csharp
public void ClearProgress()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_ClearQuery"></a> ClearQuery\(\)

```csharp
public void ClearQuery()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_ClearQuestId"></a> ClearQuestId\(\)

```csharp
public void ClearQuestId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_QuestStatus Clone()
```

#### Returns

 [CDOTAClientMsg\_QuestStatus](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuestStatus.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_"></a> Equals\(CDOTAClientMsg\_QuestStatus\)

```csharp
public bool Equals(CDOTAClientMsg_QuestStatus other)
```

#### Parameters

`other` [CDOTAClientMsg\_QuestStatus](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuestStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_"></a> MergeFrom\(CDOTAClientMsg\_QuestStatus\)

```csharp
public void MergeFrom(CDOTAClientMsg_QuestStatus other)
```

#### Parameters

`other` [CDOTAClientMsg\_QuestStatus](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuestStatus.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuestStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

