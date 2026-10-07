# <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent"></a> Class CMsgGuildFeedEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGuildFeedEvent : IMessage<CMsgGuildFeedEvent>, IEquatable<CMsgGuildFeedEvent>, IDeepCloneable<CMsgGuildFeedEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGuildFeedEvent](Divine.Protobufs.Dota2.CMsgGuildFeedEvent.md)

#### Implements

IMessage<CMsgGuildFeedEvent\>, 
[IEquatable<CMsgGuildFeedEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGuildFeedEvent\>, 
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
[EnumerableExtensions.In<CMsgGuildFeedEvent\>\(CMsgGuildFeedEvent, params CMsgGuildFeedEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent__ctor"></a> CMsgGuildFeedEvent\(\)

```csharp
public CMsgGuildFeedEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent__ctor_Divine_Protobufs_Dota2_CMsgGuildFeedEvent_"></a> CMsgGuildFeedEvent\(CMsgGuildFeedEvent\)

```csharp
public CMsgGuildFeedEvent(CMsgGuildFeedEvent other)
```

#### Parameters

`other` [CMsgGuildFeedEvent](Divine.Protobufs.Dota2.CMsgGuildFeedEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_EventTypeFieldNumber"></a> EventTypeFieldNumber

```csharp
public const int EventTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_FeedEventIdFieldNumber"></a> FeedEventIdFieldNumber

```csharp
public const int FeedEventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_ParamUint1FieldNumber"></a> ParamUint1FieldNumber

```csharp
public const int ParamUint1FieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_ParamUint2FieldNumber"></a> ParamUint2FieldNumber

```csharp
public const int ParamUint2FieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_ParamUint3FieldNumber"></a> ParamUint3FieldNumber

```csharp
public const int ParamUint3FieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_EventType"></a> EventType

```csharp
public uint EventType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_FeedEventId"></a> FeedEventId

```csharp
public ulong FeedEventId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_HasEventType"></a> HasEventType

```csharp
public bool HasEventType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_HasFeedEventId"></a> HasFeedEventId

```csharp
public bool HasFeedEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_HasParamUint1"></a> HasParamUint1

```csharp
public bool HasParamUint1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_HasParamUint2"></a> HasParamUint2

```csharp
public bool HasParamUint2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_HasParamUint3"></a> HasParamUint3

```csharp
public bool HasParamUint3 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_ParamUint1"></a> ParamUint1

```csharp
public uint ParamUint1 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_ParamUint2"></a> ParamUint2

```csharp
public uint ParamUint2 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_ParamUint3"></a> ParamUint3

```csharp
public uint ParamUint3 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGuildFeedEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGuildFeedEvent](Divine.Protobufs.Dota2.CMsgGuildFeedEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_ClearEventType"></a> ClearEventType\(\)

```csharp
public void ClearEventType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_ClearFeedEventId"></a> ClearFeedEventId\(\)

```csharp
public void ClearFeedEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_ClearParamUint1"></a> ClearParamUint1\(\)

```csharp
public void ClearParamUint1()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_ClearParamUint2"></a> ClearParamUint2\(\)

```csharp
public void ClearParamUint2()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_ClearParamUint3"></a> ClearParamUint3\(\)

```csharp
public void ClearParamUint3()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_Clone"></a> Clone\(\)

```csharp
public CMsgGuildFeedEvent Clone()
```

#### Returns

 [CMsgGuildFeedEvent](Divine.Protobufs.Dota2.CMsgGuildFeedEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_Equals_Divine_Protobufs_Dota2_CMsgGuildFeedEvent_"></a> Equals\(CMsgGuildFeedEvent\)

```csharp
public bool Equals(CMsgGuildFeedEvent other)
```

#### Parameters

`other` [CMsgGuildFeedEvent](Divine.Protobufs.Dota2.CMsgGuildFeedEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_MergeFrom_Divine_Protobufs_Dota2_CMsgGuildFeedEvent_"></a> MergeFrom\(CMsgGuildFeedEvent\)

```csharp
public void MergeFrom(CMsgGuildFeedEvent other)
```

#### Parameters

`other` [CMsgGuildFeedEvent](Divine.Protobufs.Dota2.CMsgGuildFeedEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildFeedEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

