# <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent"></a> Class CMsgDOTAClaimGatedEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAClaimGatedEvent : IMessage<CMsgDOTAClaimGatedEvent>, IEquatable<CMsgDOTAClaimGatedEvent>, IDeepCloneable<CMsgDOTAClaimGatedEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAClaimGatedEvent](Divine.Protobufs.Dota2.CMsgDOTAClaimGatedEvent.md)

#### Implements

IMessage<CMsgDOTAClaimGatedEvent\>, 
[IEquatable<CMsgDOTAClaimGatedEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAClaimGatedEvent\>, 
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
[EnumerableExtensions.In<CMsgDOTAClaimGatedEvent\>\(CMsgDOTAClaimGatedEvent, params CMsgDOTAClaimGatedEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent__ctor"></a> CMsgDOTAClaimGatedEvent\(\)

```csharp
public CMsgDOTAClaimGatedEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent__ctor_Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent_"></a> CMsgDOTAClaimGatedEvent\(CMsgDOTAClaimGatedEvent\)

```csharp
public CMsgDOTAClaimGatedEvent(CMsgDOTAClaimGatedEvent other)
```

#### Parameters

`other` [CMsgDOTAClaimGatedEvent](Divine.Protobufs.Dota2.CMsgDOTAClaimGatedEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAClaimGatedEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAClaimGatedEvent](Divine.Protobufs.Dota2.CMsgDOTAClaimGatedEvent.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAClaimGatedEvent Clone()
```

#### Returns

 [CMsgDOTAClaimGatedEvent](Divine.Protobufs.Dota2.CMsgDOTAClaimGatedEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent_Equals_Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent_"></a> Equals\(CMsgDOTAClaimGatedEvent\)

```csharp
public bool Equals(CMsgDOTAClaimGatedEvent other)
```

#### Parameters

`other` [CMsgDOTAClaimGatedEvent](Divine.Protobufs.Dota2.CMsgDOTAClaimGatedEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent_"></a> MergeFrom\(CMsgDOTAClaimGatedEvent\)

```csharp
public void MergeFrom(CMsgDOTAClaimGatedEvent other)
```

#### Parameters

`other` [CMsgDOTAClaimGatedEvent](Divine.Protobufs.Dota2.CMsgDOTAClaimGatedEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

