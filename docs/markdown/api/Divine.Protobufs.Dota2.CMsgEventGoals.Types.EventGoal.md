# <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal"></a> Class CMsgEventGoals.Types.EventGoal

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgEventGoals.Types.EventGoal : IMessage<CMsgEventGoals.Types.EventGoal>, IEquatable<CMsgEventGoals.Types.EventGoal>, IDeepCloneable<CMsgEventGoals.Types.EventGoal>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgEventGoals.Types.EventGoal](Divine.Protobufs.Dota2.CMsgEventGoals.Types.EventGoal.md)

#### Implements

IMessage<CMsgEventGoals.Types.EventGoal\>, 
[IEquatable<CMsgEventGoals.Types.EventGoal\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgEventGoals.Types.EventGoal\>, 
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
[EnumerableExtensions.In<CMsgEventGoals.Types.EventGoal\>\(CMsgEventGoals.Types.EventGoal, params CMsgEventGoals.Types.EventGoal\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal__ctor"></a> EventGoal\(\)

```csharp
public EventGoal()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal__ctor_Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_"></a> EventGoal\(EventGoal\)

```csharp
public EventGoal(CMsgEventGoals.Types.EventGoal other)
```

#### Parameters

`other` [CMsgEventGoals](Divine.Protobufs.Dota2.CMsgEventGoals.md).[Types](Divine.Protobufs.Dota2.CMsgEventGoals.Types.md).[EventGoal](Divine.Protobufs.Dota2.CMsgEventGoals.Types.EventGoal.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_GoalIdFieldNumber"></a> GoalIdFieldNumber

```csharp
public const int GoalIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_GoalId"></a> GoalId

```csharp
public uint GoalId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_HasGoalId"></a> HasGoalId

```csharp
public bool HasGoalId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_Parser"></a> Parser

```csharp
public static MessageParser<CMsgEventGoals.Types.EventGoal> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgEventGoals](Divine.Protobufs.Dota2.CMsgEventGoals.md).[Types](Divine.Protobufs.Dota2.CMsgEventGoals.Types.md).[EventGoal](Divine.Protobufs.Dota2.CMsgEventGoals.Types.EventGoal.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_Value"></a> Value

```csharp
public ulong Value { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_ClearGoalId"></a> ClearGoalId\(\)

```csharp
public void ClearGoalId()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_Clone"></a> Clone\(\)

```csharp
public CMsgEventGoals.Types.EventGoal Clone()
```

#### Returns

 [CMsgEventGoals](Divine.Protobufs.Dota2.CMsgEventGoals.md).[Types](Divine.Protobufs.Dota2.CMsgEventGoals.Types.md).[EventGoal](Divine.Protobufs.Dota2.CMsgEventGoals.Types.EventGoal.md)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_Equals_Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_"></a> Equals\(EventGoal\)

```csharp
public bool Equals(CMsgEventGoals.Types.EventGoal other)
```

#### Parameters

`other` [CMsgEventGoals](Divine.Protobufs.Dota2.CMsgEventGoals.md).[Types](Divine.Protobufs.Dota2.CMsgEventGoals.Types.md).[EventGoal](Divine.Protobufs.Dota2.CMsgEventGoals.Types.EventGoal.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_MergeFrom_Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_"></a> MergeFrom\(EventGoal\)

```csharp
public void MergeFrom(CMsgEventGoals.Types.EventGoal other)
```

#### Parameters

`other` [CMsgEventGoals](Divine.Protobufs.Dota2.CMsgEventGoals.md).[Types](Divine.Protobufs.Dota2.CMsgEventGoals.Types.md).[EventGoal](Divine.Protobufs.Dota2.CMsgEventGoals.Types.EventGoal.md)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Types_EventGoal_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

