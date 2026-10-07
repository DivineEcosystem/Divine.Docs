# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent"></a> Class CDOTAUserMsg\_OverheadEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_OverheadEvent : IMessage<CDOTAUserMsg_OverheadEvent>, IEquatable<CDOTAUserMsg_OverheadEvent>, IDeepCloneable<CDOTAUserMsg_OverheadEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_OverheadEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_OverheadEvent.md)

#### Implements

IMessage<CDOTAUserMsg\_OverheadEvent\>, 
[IEquatable<CDOTAUserMsg\_OverheadEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_OverheadEvent\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_OverheadEvent\>\(CDOTAUserMsg\_OverheadEvent, params CDOTAUserMsg\_OverheadEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent__ctor"></a> CDOTAUserMsg\_OverheadEvent\(\)

```csharp
public CDOTAUserMsg_OverheadEvent()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_"></a> CDOTAUserMsg\_OverheadEvent\(CDOTAUserMsg\_OverheadEvent\)

```csharp
public CDOTAUserMsg_OverheadEvent(CDOTAUserMsg_OverheadEvent other)
```

#### Parameters

`other` [CDOTAUserMsg\_OverheadEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_OverheadEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_MessageTypeFieldNumber"></a> MessageTypeFieldNumber

```csharp
public const int MessageTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_SourcePlayerEntindexFieldNumber"></a> SourcePlayerEntindexFieldNumber

```csharp
public const int SourcePlayerEntindexFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_TargetEntindexFieldNumber"></a> TargetEntindexFieldNumber

```csharp
public const int TargetEntindexFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_TargetPlayerEntindexFieldNumber"></a> TargetPlayerEntindexFieldNumber

```csharp
public const int TargetPlayerEntindexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_HasMessageType"></a> HasMessageType

```csharp
public bool HasMessageType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_HasSourcePlayerEntindex"></a> HasSourcePlayerEntindex

```csharp
public bool HasSourcePlayerEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_HasTargetEntindex"></a> HasTargetEntindex

```csharp
public bool HasTargetEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_HasTargetPlayerEntindex"></a> HasTargetPlayerEntindex

```csharp
public bool HasTargetPlayerEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_MessageType"></a> MessageType

```csharp
public DOTA_OVERHEAD_ALERT MessageType { get; set; }
```

#### Property Value

 [DOTA\_OVERHEAD\_ALERT](Divine.Protobufs.Dota2.DOTA\_OVERHEAD\_ALERT.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_OverheadEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_OverheadEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_OverheadEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_SourcePlayerEntindex"></a> SourcePlayerEntindex

```csharp
public int SourcePlayerEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_TargetEntindex"></a> TargetEntindex

```csharp
public int TargetEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_TargetPlayerEntindex"></a> TargetPlayerEntindex

```csharp
public int TargetPlayerEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_Value"></a> Value

```csharp
public int Value { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_ClearMessageType"></a> ClearMessageType\(\)

```csharp
public void ClearMessageType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_ClearSourcePlayerEntindex"></a> ClearSourcePlayerEntindex\(\)

```csharp
public void ClearSourcePlayerEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_ClearTargetEntindex"></a> ClearTargetEntindex\(\)

```csharp
public void ClearTargetEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_ClearTargetPlayerEntindex"></a> ClearTargetPlayerEntindex\(\)

```csharp
public void ClearTargetPlayerEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_OverheadEvent Clone()
```

#### Returns

 [CDOTAUserMsg\_OverheadEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_OverheadEvent.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_"></a> Equals\(CDOTAUserMsg\_OverheadEvent\)

```csharp
public bool Equals(CDOTAUserMsg_OverheadEvent other)
```

#### Parameters

`other` [CDOTAUserMsg\_OverheadEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_OverheadEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_"></a> MergeFrom\(CDOTAUserMsg\_OverheadEvent\)

```csharp
public void MergeFrom(CDOTAUserMsg_OverheadEvent other)
```

#### Parameters

`other` [CDOTAUserMsg\_OverheadEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_OverheadEvent.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OverheadEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

