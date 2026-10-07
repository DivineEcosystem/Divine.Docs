# <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent"></a> Class CMsgDOTABroadcastTimelineEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTABroadcastTimelineEvent : IMessage<CMsgDOTABroadcastTimelineEvent>, IEquatable<CMsgDOTABroadcastTimelineEvent>, IDeepCloneable<CMsgDOTABroadcastTimelineEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTABroadcastTimelineEvent](Divine.Protobufs.Dota2.CMsgDOTABroadcastTimelineEvent.md)

#### Implements

IMessage<CMsgDOTABroadcastTimelineEvent\>, 
[IEquatable<CMsgDOTABroadcastTimelineEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTABroadcastTimelineEvent\>, 
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
[EnumerableExtensions.In<CMsgDOTABroadcastTimelineEvent\>\(CMsgDOTABroadcastTimelineEvent, params CMsgDOTABroadcastTimelineEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent__ctor"></a> CMsgDOTABroadcastTimelineEvent\(\)

```csharp
public CMsgDOTABroadcastTimelineEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent__ctor_Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_"></a> CMsgDOTABroadcastTimelineEvent\(CMsgDOTABroadcastTimelineEvent\)

```csharp
public CMsgDOTABroadcastTimelineEvent(CMsgDOTABroadcastTimelineEvent other)
```

#### Parameters

`other` [CMsgDOTABroadcastTimelineEvent](Divine.Protobufs.Dota2.CMsgDOTABroadcastTimelineEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_EventFieldNumber"></a> EventFieldNumber

```csharp
public const int EventFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_StringDataFieldNumber"></a> StringDataFieldNumber

```csharp
public const int StringDataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_Data"></a> Data

```csharp
public uint Data { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_Event"></a> Event

```csharp
public EBroadcastTimelineEvent Event { get; set; }
```

#### Property Value

 [EBroadcastTimelineEvent](Divine.Protobufs.Dota2.EBroadcastTimelineEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_HasEvent"></a> HasEvent

```csharp
public bool HasEvent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_HasStringData"></a> HasStringData

```csharp
public bool HasStringData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTABroadcastTimelineEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTABroadcastTimelineEvent](Divine.Protobufs.Dota2.CMsgDOTABroadcastTimelineEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_StringData"></a> StringData

```csharp
public string StringData { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_ClearEvent"></a> ClearEvent\(\)

```csharp
public void ClearEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_ClearStringData"></a> ClearStringData\(\)

```csharp
public void ClearStringData()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_Clone"></a> Clone\(\)

```csharp
public CMsgDOTABroadcastTimelineEvent Clone()
```

#### Returns

 [CMsgDOTABroadcastTimelineEvent](Divine.Protobufs.Dota2.CMsgDOTABroadcastTimelineEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_Equals_Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_"></a> Equals\(CMsgDOTABroadcastTimelineEvent\)

```csharp
public bool Equals(CMsgDOTABroadcastTimelineEvent other)
```

#### Parameters

`other` [CMsgDOTABroadcastTimelineEvent](Divine.Protobufs.Dota2.CMsgDOTABroadcastTimelineEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_"></a> MergeFrom\(CMsgDOTABroadcastTimelineEvent\)

```csharp
public void MergeFrom(CMsgDOTABroadcastTimelineEvent other)
```

#### Parameters

`other` [CMsgDOTABroadcastTimelineEvent](Divine.Protobufs.Dota2.CMsgDOTABroadcastTimelineEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastTimelineEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

