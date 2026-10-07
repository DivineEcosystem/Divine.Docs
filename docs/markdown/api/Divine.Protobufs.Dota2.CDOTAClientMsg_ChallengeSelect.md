# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect"></a> Class CDOTAClientMsg\_ChallengeSelect

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_ChallengeSelect : IMessage<CDOTAClientMsg_ChallengeSelect>, IEquatable<CDOTAClientMsg_ChallengeSelect>, IDeepCloneable<CDOTAClientMsg_ChallengeSelect>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_ChallengeSelect](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChallengeSelect.md)

#### Implements

IMessage<CDOTAClientMsg\_ChallengeSelect\>, 
[IEquatable<CDOTAClientMsg\_ChallengeSelect\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_ChallengeSelect\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_ChallengeSelect\>\(CDOTAClientMsg\_ChallengeSelect, params CDOTAClientMsg\_ChallengeSelect\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect__ctor"></a> CDOTAClientMsg\_ChallengeSelect\(\)

```csharp
public CDOTAClientMsg_ChallengeSelect()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_"></a> CDOTAClientMsg\_ChallengeSelect\(CDOTAClientMsg\_ChallengeSelect\)

```csharp
public CDOTAClientMsg_ChallengeSelect(CDOTAClientMsg_ChallengeSelect other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChallengeSelect](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChallengeSelect.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_SequenceIdFieldNumber"></a> SequenceIdFieldNumber

```csharp
public const int SequenceIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_SlotIdFieldNumber"></a> SlotIdFieldNumber

```csharp
public const int SlotIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_HasSequenceId"></a> HasSequenceId

```csharp
public bool HasSequenceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_HasSlotId"></a> HasSlotId

```csharp
public bool HasSlotId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_ChallengeSelect> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_ChallengeSelect](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChallengeSelect.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_SequenceId"></a> SequenceId

```csharp
public uint SequenceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_SlotId"></a> SlotId

```csharp
public uint SlotId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_ClearSequenceId"></a> ClearSequenceId\(\)

```csharp
public void ClearSequenceId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_ClearSlotId"></a> ClearSlotId\(\)

```csharp
public void ClearSlotId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_ChallengeSelect Clone()
```

#### Returns

 [CDOTAClientMsg\_ChallengeSelect](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChallengeSelect.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_"></a> Equals\(CDOTAClientMsg\_ChallengeSelect\)

```csharp
public bool Equals(CDOTAClientMsg_ChallengeSelect other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChallengeSelect](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChallengeSelect.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_"></a> MergeFrom\(CDOTAClientMsg\_ChallengeSelect\)

```csharp
public void MergeFrom(CDOTAClientMsg_ChallengeSelect other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChallengeSelect](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChallengeSelect.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChallengeSelect_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

