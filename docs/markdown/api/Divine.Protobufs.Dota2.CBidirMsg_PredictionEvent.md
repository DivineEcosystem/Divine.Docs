# <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent"></a> Class CBidirMsg\_PredictionEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CBidirMsg_PredictionEvent : IMessage<CBidirMsg_PredictionEvent>, IEquatable<CBidirMsg_PredictionEvent>, IDeepCloneable<CBidirMsg_PredictionEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CBidirMsg\_PredictionEvent](Divine.Protobufs.Dota2.CBidirMsg\_PredictionEvent.md)

#### Implements

IMessage<CBidirMsg\_PredictionEvent\>, 
[IEquatable<CBidirMsg\_PredictionEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CBidirMsg\_PredictionEvent\>, 
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
[EnumerableExtensions.In<CBidirMsg\_PredictionEvent\>\(CBidirMsg\_PredictionEvent, params CBidirMsg\_PredictionEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent__ctor"></a> CBidirMsg\_PredictionEvent\(\)

```csharp
public CBidirMsg_PredictionEvent()
```

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent__ctor_Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_"></a> CBidirMsg\_PredictionEvent\(CBidirMsg\_PredictionEvent\)

```csharp
public CBidirMsg_PredictionEvent(CBidirMsg_PredictionEvent other)
```

#### Parameters

`other` [CBidirMsg\_PredictionEvent](Divine.Protobufs.Dota2.CBidirMsg\_PredictionEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_EventDataFieldNumber"></a> EventDataFieldNumber

```csharp
public const int EventDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_SyncTypeFieldNumber"></a> SyncTypeFieldNumber

```csharp
public const int SyncTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_SyncValUint32FieldNumber"></a> SyncValUint32FieldNumber

```csharp
public const int SyncValUint32FieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_EventData"></a> EventData

```csharp
public ByteString EventData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_HasEventData"></a> HasEventData

```csharp
public bool HasEventData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_HasSyncType"></a> HasSyncType

```csharp
public bool HasSyncType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_HasSyncValUint32"></a> HasSyncValUint32

```csharp
public bool HasSyncValUint32 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_Parser"></a> Parser

```csharp
public static MessageParser<CBidirMsg_PredictionEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CBidirMsg\_PredictionEvent](Divine.Protobufs.Dota2.CBidirMsg\_PredictionEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_SyncType"></a> SyncType

```csharp
public uint SyncType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_SyncValUint32"></a> SyncValUint32

```csharp
public uint SyncValUint32 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_ClearEventData"></a> ClearEventData\(\)

```csharp
public void ClearEventData()
```

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_ClearSyncType"></a> ClearSyncType\(\)

```csharp
public void ClearSyncType()
```

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_ClearSyncValUint32"></a> ClearSyncValUint32\(\)

```csharp
public void ClearSyncValUint32()
```

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_Clone"></a> Clone\(\)

```csharp
public CBidirMsg_PredictionEvent Clone()
```

#### Returns

 [CBidirMsg\_PredictionEvent](Divine.Protobufs.Dota2.CBidirMsg\_PredictionEvent.md)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_Equals_Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_"></a> Equals\(CBidirMsg\_PredictionEvent\)

```csharp
public bool Equals(CBidirMsg_PredictionEvent other)
```

#### Parameters

`other` [CBidirMsg\_PredictionEvent](Divine.Protobufs.Dota2.CBidirMsg\_PredictionEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_MergeFrom_Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_"></a> MergeFrom\(CBidirMsg\_PredictionEvent\)

```csharp
public void MergeFrom(CBidirMsg_PredictionEvent other)
```

#### Parameters

`other` [CBidirMsg\_PredictionEvent](Divine.Protobufs.Dota2.CBidirMsg\_PredictionEvent.md)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_PredictionEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

