# <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated"></a> Class CMsgGCToClientQuestProgressUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientQuestProgressUpdated : IMessage<CMsgGCToClientQuestProgressUpdated>, IEquatable<CMsgGCToClientQuestProgressUpdated>, IDeepCloneable<CMsgGCToClientQuestProgressUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientQuestProgressUpdated](Divine.Protobufs.Dota2.CMsgGCToClientQuestProgressUpdated.md)

#### Implements

IMessage<CMsgGCToClientQuestProgressUpdated\>, 
[IEquatable<CMsgGCToClientQuestProgressUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientQuestProgressUpdated\>, 
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
[EnumerableExtensions.In<CMsgGCToClientQuestProgressUpdated\>\(CMsgGCToClientQuestProgressUpdated, params CMsgGCToClientQuestProgressUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated__ctor"></a> CMsgGCToClientQuestProgressUpdated\(\)

```csharp
public CMsgGCToClientQuestProgressUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated__ctor_Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_"></a> CMsgGCToClientQuestProgressUpdated\(CMsgGCToClientQuestProgressUpdated\)

```csharp
public CMsgGCToClientQuestProgressUpdated(CMsgGCToClientQuestProgressUpdated other)
```

#### Parameters

`other` [CMsgGCToClientQuestProgressUpdated](Divine.Protobufs.Dota2.CMsgGCToClientQuestProgressUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_CompletedChallengesFieldNumber"></a> CompletedChallengesFieldNumber

```csharp
public const int CompletedChallengesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_QuestIdFieldNumber"></a> QuestIdFieldNumber

```csharp
public const int QuestIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_CompletedChallenges"></a> CompletedChallenges

```csharp
public RepeatedField<CMsgGCToClientQuestProgressUpdated.Types.Challenge> CompletedChallenges { get; }
```

#### Property Value

 RepeatedField<[CMsgGCToClientQuestProgressUpdated](Divine.Protobufs.Dota2.CMsgGCToClientQuestProgressUpdated.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientQuestProgressUpdated.Types.md).[Challenge](Divine.Protobufs.Dota2.CMsgGCToClientQuestProgressUpdated.Types.Challenge.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_HasQuestId"></a> HasQuestId

```csharp
public bool HasQuestId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientQuestProgressUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientQuestProgressUpdated](Divine.Protobufs.Dota2.CMsgGCToClientQuestProgressUpdated.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_QuestId"></a> QuestId

```csharp
public uint QuestId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_ClearQuestId"></a> ClearQuestId\(\)

```csharp
public void ClearQuestId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientQuestProgressUpdated Clone()
```

#### Returns

 [CMsgGCToClientQuestProgressUpdated](Divine.Protobufs.Dota2.CMsgGCToClientQuestProgressUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_Equals_Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_"></a> Equals\(CMsgGCToClientQuestProgressUpdated\)

```csharp
public bool Equals(CMsgGCToClientQuestProgressUpdated other)
```

#### Parameters

`other` [CMsgGCToClientQuestProgressUpdated](Divine.Protobufs.Dota2.CMsgGCToClientQuestProgressUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_"></a> MergeFrom\(CMsgGCToClientQuestProgressUpdated\)

```csharp
public void MergeFrom(CMsgGCToClientQuestProgressUpdated other)
```

#### Parameters

`other` [CMsgGCToClientQuestProgressUpdated](Divine.Protobufs.Dota2.CMsgGCToClientQuestProgressUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientQuestProgressUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

