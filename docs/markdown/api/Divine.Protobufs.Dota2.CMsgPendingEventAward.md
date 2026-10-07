# <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward"></a> Class CMsgPendingEventAward

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPendingEventAward : IMessage<CMsgPendingEventAward>, IEquatable<CMsgPendingEventAward>, IDeepCloneable<CMsgPendingEventAward>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPendingEventAward](Divine.Protobufs.Dota2.CMsgPendingEventAward.md)

#### Implements

IMessage<CMsgPendingEventAward\>, 
[IEquatable<CMsgPendingEventAward\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPendingEventAward\>, 
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
[EnumerableExtensions.In<CMsgPendingEventAward\>\(CMsgPendingEventAward, params CMsgPendingEventAward\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward__ctor"></a> CMsgPendingEventAward\(\)

```csharp
public CMsgPendingEventAward()
```

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward__ctor_Divine_Protobufs_Dota2_CMsgPendingEventAward_"></a> CMsgPendingEventAward\(CMsgPendingEventAward\)

```csharp
public CMsgPendingEventAward(CMsgPendingEventAward other)
```

#### Parameters

`other` [CMsgPendingEventAward](Divine.Protobufs.Dota2.CMsgPendingEventAward.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_ActionIdFieldNumber"></a> ActionIdFieldNumber

```csharp
public const int ActionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_AuditActionFieldNumber"></a> AuditActionFieldNumber

```csharp
public const int AuditActionFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_AuditDataFieldNumber"></a> AuditDataFieldNumber

```csharp
public const int AuditDataFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_NumToGrantFieldNumber"></a> NumToGrantFieldNumber

```csharp
public const int NumToGrantFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_ScoreModeFieldNumber"></a> ScoreModeFieldNumber

```csharp
public const int ScoreModeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_ActionId"></a> ActionId

```csharp
public uint ActionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_AuditAction"></a> AuditAction

```csharp
public uint AuditAction { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_AuditData"></a> AuditData

```csharp
public ulong AuditData { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_HasActionId"></a> HasActionId

```csharp
public bool HasActionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_HasAuditAction"></a> HasAuditAction

```csharp
public bool HasAuditAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_HasAuditData"></a> HasAuditData

```csharp
public bool HasAuditData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_HasNumToGrant"></a> HasNumToGrant

```csharp
public bool HasNumToGrant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_HasScoreMode"></a> HasScoreMode

```csharp
public bool HasScoreMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_NumToGrant"></a> NumToGrant

```csharp
public uint NumToGrant { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPendingEventAward> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPendingEventAward](Divine.Protobufs.Dota2.CMsgPendingEventAward.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_ScoreMode"></a> ScoreMode

```csharp
public EEventActionScoreMode ScoreMode { get; set; }
```

#### Property Value

 [EEventActionScoreMode](Divine.Protobufs.Dota2.EEventActionScoreMode.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_ClearActionId"></a> ClearActionId\(\)

```csharp
public void ClearActionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_ClearAuditAction"></a> ClearAuditAction\(\)

```csharp
public void ClearAuditAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_ClearAuditData"></a> ClearAuditData\(\)

```csharp
public void ClearAuditData()
```

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_ClearNumToGrant"></a> ClearNumToGrant\(\)

```csharp
public void ClearNumToGrant()
```

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_ClearScoreMode"></a> ClearScoreMode\(\)

```csharp
public void ClearScoreMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_Clone"></a> Clone\(\)

```csharp
public CMsgPendingEventAward Clone()
```

#### Returns

 [CMsgPendingEventAward](Divine.Protobufs.Dota2.CMsgPendingEventAward.md)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_Equals_Divine_Protobufs_Dota2_CMsgPendingEventAward_"></a> Equals\(CMsgPendingEventAward\)

```csharp
public bool Equals(CMsgPendingEventAward other)
```

#### Parameters

`other` [CMsgPendingEventAward](Divine.Protobufs.Dota2.CMsgPendingEventAward.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_MergeFrom_Divine_Protobufs_Dota2_CMsgPendingEventAward_"></a> MergeFrom\(CMsgPendingEventAward\)

```csharp
public void MergeFrom(CMsgPendingEventAward other)
```

#### Parameters

`other` [CMsgPendingEventAward](Divine.Protobufs.Dota2.CMsgPendingEventAward.md)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPendingEventAward_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

