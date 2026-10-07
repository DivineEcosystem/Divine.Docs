# <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest"></a> Class CMsgRoadToTIAssignedQuest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgRoadToTIAssignedQuest : IMessage<CMsgRoadToTIAssignedQuest>, IEquatable<CMsgRoadToTIAssignedQuest>, IDeepCloneable<CMsgRoadToTIAssignedQuest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgRoadToTIAssignedQuest](Divine.Protobufs.Dota2.CMsgRoadToTIAssignedQuest.md)

#### Implements

IMessage<CMsgRoadToTIAssignedQuest\>, 
[IEquatable<CMsgRoadToTIAssignedQuest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgRoadToTIAssignedQuest\>, 
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
[EnumerableExtensions.In<CMsgRoadToTIAssignedQuest\>\(CMsgRoadToTIAssignedQuest, params CMsgRoadToTIAssignedQuest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest__ctor"></a> CMsgRoadToTIAssignedQuest\(\)

```csharp
public CMsgRoadToTIAssignedQuest()
```

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest__ctor_Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_"></a> CMsgRoadToTIAssignedQuest\(CMsgRoadToTIAssignedQuest\)

```csharp
public CMsgRoadToTIAssignedQuest(CMsgRoadToTIAssignedQuest other)
```

#### Parameters

`other` [CMsgRoadToTIAssignedQuest](Divine.Protobufs.Dota2.CMsgRoadToTIAssignedQuest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_CompletedFieldNumber"></a> CompletedFieldNumber

```csharp
public const int CompletedFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_DifficultyFieldNumber"></a> DifficultyFieldNumber

```csharp
public const int DifficultyFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_HalfCreditFlagsFieldNumber"></a> HalfCreditFlagsFieldNumber

```csharp
public const int HalfCreditFlagsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_ProgressFlagsFieldNumber"></a> ProgressFlagsFieldNumber

```csharp
public const int ProgressFlagsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_QuestIdFieldNumber"></a> QuestIdFieldNumber

```csharp
public const int QuestIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_Completed"></a> Completed

```csharp
public bool Completed { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_Difficulty"></a> Difficulty

```csharp
public uint Difficulty { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_HalfCreditFlags"></a> HalfCreditFlags

```csharp
public uint HalfCreditFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_HasCompleted"></a> HasCompleted

```csharp
public bool HasCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_HasDifficulty"></a> HasDifficulty

```csharp
public bool HasDifficulty { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_HasHalfCreditFlags"></a> HasHalfCreditFlags

```csharp
public bool HasHalfCreditFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_HasProgressFlags"></a> HasProgressFlags

```csharp
public bool HasProgressFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_HasQuestId"></a> HasQuestId

```csharp
public bool HasQuestId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgRoadToTIAssignedQuest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgRoadToTIAssignedQuest](Divine.Protobufs.Dota2.CMsgRoadToTIAssignedQuest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_ProgressFlags"></a> ProgressFlags

```csharp
public uint ProgressFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_QuestId"></a> QuestId

```csharp
public uint QuestId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_ClearCompleted"></a> ClearCompleted\(\)

```csharp
public void ClearCompleted()
```

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_ClearDifficulty"></a> ClearDifficulty\(\)

```csharp
public void ClearDifficulty()
```

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_ClearHalfCreditFlags"></a> ClearHalfCreditFlags\(\)

```csharp
public void ClearHalfCreditFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_ClearProgressFlags"></a> ClearProgressFlags\(\)

```csharp
public void ClearProgressFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_ClearQuestId"></a> ClearQuestId\(\)

```csharp
public void ClearQuestId()
```

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_Clone"></a> Clone\(\)

```csharp
public CMsgRoadToTIAssignedQuest Clone()
```

#### Returns

 [CMsgRoadToTIAssignedQuest](Divine.Protobufs.Dota2.CMsgRoadToTIAssignedQuest.md)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_Equals_Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_"></a> Equals\(CMsgRoadToTIAssignedQuest\)

```csharp
public bool Equals(CMsgRoadToTIAssignedQuest other)
```

#### Parameters

`other` [CMsgRoadToTIAssignedQuest](Divine.Protobufs.Dota2.CMsgRoadToTIAssignedQuest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_MergeFrom_Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_"></a> MergeFrom\(CMsgRoadToTIAssignedQuest\)

```csharp
public void MergeFrom(CMsgRoadToTIAssignedQuest other)
```

#### Parameters

`other` [CMsgRoadToTIAssignedQuest](Divine.Protobufs.Dota2.CMsgRoadToTIAssignedQuest.md)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIAssignedQuest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

