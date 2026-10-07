# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent"></a> Class CDOTAUserMsg\_ProjectionEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_ProjectionEvent : IMessage<CDOTAUserMsg_ProjectionEvent>, IEquatable<CDOTAUserMsg_ProjectionEvent>, IDeepCloneable<CDOTAUserMsg_ProjectionEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_ProjectionEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_ProjectionEvent.md)

#### Implements

IMessage<CDOTAUserMsg\_ProjectionEvent\>, 
[IEquatable<CDOTAUserMsg\_ProjectionEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_ProjectionEvent\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_ProjectionEvent\>\(CDOTAUserMsg\_ProjectionEvent, params CDOTAUserMsg\_ProjectionEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent__ctor"></a> CDOTAUserMsg\_ProjectionEvent\(\)

```csharp
public CDOTAUserMsg_ProjectionEvent()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_"></a> CDOTAUserMsg\_ProjectionEvent\(CDOTAUserMsg\_ProjectionEvent\)

```csharp
public CDOTAUserMsg_ProjectionEvent(CDOTAUserMsg_ProjectionEvent other)
```

#### Parameters

`other` [CDOTAUserMsg\_ProjectionEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_ProjectionEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_EventId"></a> EventId

```csharp
public EProjectionEvent EventId { get; set; }
```

#### Property Value

 [EProjectionEvent](Divine.Protobufs.Dota2.EProjectionEvent.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_ProjectionEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_ProjectionEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_ProjectionEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_Team"></a> Team

```csharp
public uint Team { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_ProjectionEvent Clone()
```

#### Returns

 [CDOTAUserMsg\_ProjectionEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_ProjectionEvent.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_"></a> Equals\(CDOTAUserMsg\_ProjectionEvent\)

```csharp
public bool Equals(CDOTAUserMsg_ProjectionEvent other)
```

#### Parameters

`other` [CDOTAUserMsg\_ProjectionEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_ProjectionEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_"></a> MergeFrom\(CDOTAUserMsg\_ProjectionEvent\)

```csharp
public void MergeFrom(CDOTAUserMsg_ProjectionEvent other)
```

#### Parameters

`other` [CDOTAUserMsg\_ProjectionEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_ProjectionEvent.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectionEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

