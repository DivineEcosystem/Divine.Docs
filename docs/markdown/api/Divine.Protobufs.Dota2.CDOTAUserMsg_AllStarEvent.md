# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent"></a> Class CDOTAUserMsg\_AllStarEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_AllStarEvent : IMessage<CDOTAUserMsg_AllStarEvent>, IEquatable<CDOTAUserMsg_AllStarEvent>, IDeepCloneable<CDOTAUserMsg_AllStarEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_AllStarEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_AllStarEvent.md)

#### Implements

IMessage<CDOTAUserMsg\_AllStarEvent\>, 
[IEquatable<CDOTAUserMsg\_AllStarEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_AllStarEvent\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_AllStarEvent\>\(CDOTAUserMsg\_AllStarEvent, params CDOTAUserMsg\_AllStarEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent__ctor"></a> CDOTAUserMsg\_AllStarEvent\(\)

```csharp
public CDOTAUserMsg_AllStarEvent()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_"></a> CDOTAUserMsg\_AllStarEvent\(CDOTAUserMsg\_AllStarEvent\)

```csharp
public CDOTAUserMsg_AllStarEvent(CDOTAUserMsg_AllStarEvent other)
```

#### Parameters

`other` [CDOTAUserMsg\_AllStarEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_AllStarEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_PlayerScoresFieldNumber"></a> PlayerScoresFieldNumber

```csharp
public const int PlayerScoresFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_PointAmountFieldNumber"></a> PointAmountFieldNumber

```csharp
public const int PointAmountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_SourcePlayerIdFieldNumber"></a> SourcePlayerIdFieldNumber

```csharp
public const int SourcePlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_TargetPlayerIdFieldNumber"></a> TargetPlayerIdFieldNumber

```csharp
public const int TargetPlayerIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_HasPointAmount"></a> HasPointAmount

```csharp
public bool HasPointAmount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_HasSourcePlayerId"></a> HasSourcePlayerId

```csharp
public bool HasSourcePlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_HasTargetPlayerId"></a> HasTargetPlayerId

```csharp
public bool HasTargetPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_AllStarEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_AllStarEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_AllStarEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_PlayerScores"></a> PlayerScores

```csharp
public RepeatedField<CDOTAUserMsg_AllStarEvent.Types.PlayerScore> PlayerScores { get; }
```

#### Property Value

 RepeatedField<[CDOTAUserMsg\_AllStarEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_AllStarEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_AllStarEvent.Types.md).[PlayerScore](Divine.Protobufs.Dota2.CDOTAUserMsg\_AllStarEvent.Types.PlayerScore.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_PointAmount"></a> PointAmount

```csharp
public uint PointAmount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_SourcePlayerId"></a> SourcePlayerId

```csharp
public int SourcePlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_TargetPlayerId"></a> TargetPlayerId

```csharp
public int TargetPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_ClearPointAmount"></a> ClearPointAmount\(\)

```csharp
public void ClearPointAmount()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_ClearSourcePlayerId"></a> ClearSourcePlayerId\(\)

```csharp
public void ClearSourcePlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_ClearTargetPlayerId"></a> ClearTargetPlayerId\(\)

```csharp
public void ClearTargetPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_AllStarEvent Clone()
```

#### Returns

 [CDOTAUserMsg\_AllStarEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_AllStarEvent.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_"></a> Equals\(CDOTAUserMsg\_AllStarEvent\)

```csharp
public bool Equals(CDOTAUserMsg_AllStarEvent other)
```

#### Parameters

`other` [CDOTAUserMsg\_AllStarEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_AllStarEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_"></a> MergeFrom\(CDOTAUserMsg\_AllStarEvent\)

```csharp
public void MergeFrom(CDOTAUserMsg_AllStarEvent other)
```

#### Parameters

`other` [CDOTAUserMsg\_AllStarEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_AllStarEvent.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AllStarEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

