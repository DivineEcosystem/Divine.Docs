# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent"></a> Class CDOTAUserMsg\_MinimapEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_MinimapEvent : IMessage<CDOTAUserMsg_MinimapEvent>, IEquatable<CDOTAUserMsg_MinimapEvent>, IDeepCloneable<CDOTAUserMsg_MinimapEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_MinimapEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_MinimapEvent.md)

#### Implements

IMessage<CDOTAUserMsg\_MinimapEvent\>, 
[IEquatable<CDOTAUserMsg\_MinimapEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_MinimapEvent\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_MinimapEvent\>\(CDOTAUserMsg\_MinimapEvent, params CDOTAUserMsg\_MinimapEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent__ctor"></a> CDOTAUserMsg\_MinimapEvent\(\)

```csharp
public CDOTAUserMsg_MinimapEvent()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_"></a> CDOTAUserMsg\_MinimapEvent\(CDOTAUserMsg\_MinimapEvent\)

```csharp
public CDOTAUserMsg_MinimapEvent(CDOTAUserMsg_MinimapEvent other)
```

#### Parameters

`other` [CDOTAUserMsg\_MinimapEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_MinimapEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_EntityHandleFieldNumber"></a> EntityHandleFieldNumber

```csharp
public const int EntityHandleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_EventTypeFieldNumber"></a> EventTypeFieldNumber

```csharp
public const int EventTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_TargetEntityHandleFieldNumber"></a> TargetEntityHandleFieldNumber

```csharp
public const int TargetEntityHandleFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_XFieldNumber"></a> XFieldNumber

```csharp
public const int XFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_YFieldNumber"></a> YFieldNumber

```csharp
public const int YFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_Duration"></a> Duration

```csharp
public int Duration { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_EntityHandle"></a> EntityHandle

```csharp
public uint EntityHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_EventType"></a> EventType

```csharp
public int EventType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_HasEntityHandle"></a> HasEntityHandle

```csharp
public bool HasEntityHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_HasEventType"></a> HasEventType

```csharp
public bool HasEventType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_HasTargetEntityHandle"></a> HasTargetEntityHandle

```csharp
public bool HasTargetEntityHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_HasX"></a> HasX

```csharp
public bool HasX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_HasY"></a> HasY

```csharp
public bool HasY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_MinimapEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_MinimapEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_MinimapEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_TargetEntityHandle"></a> TargetEntityHandle

```csharp
public uint TargetEntityHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_X"></a> X

```csharp
public int X { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_Y"></a> Y

```csharp
public int Y { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_ClearEntityHandle"></a> ClearEntityHandle\(\)

```csharp
public void ClearEntityHandle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_ClearEventType"></a> ClearEventType\(\)

```csharp
public void ClearEventType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_ClearTargetEntityHandle"></a> ClearTargetEntityHandle\(\)

```csharp
public void ClearTargetEntityHandle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_ClearX"></a> ClearX\(\)

```csharp
public void ClearX()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_ClearY"></a> ClearY\(\)

```csharp
public void ClearY()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_MinimapEvent Clone()
```

#### Returns

 [CDOTAUserMsg\_MinimapEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_MinimapEvent.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_"></a> Equals\(CDOTAUserMsg\_MinimapEvent\)

```csharp
public bool Equals(CDOTAUserMsg_MinimapEvent other)
```

#### Parameters

`other` [CDOTAUserMsg\_MinimapEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_MinimapEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_"></a> MergeFrom\(CDOTAUserMsg\_MinimapEvent\)

```csharp
public void MergeFrom(CDOTAUserMsg_MinimapEvent other)
```

#### Parameters

`other` [CDOTAUserMsg\_MinimapEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_MinimapEvent.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MinimapEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

