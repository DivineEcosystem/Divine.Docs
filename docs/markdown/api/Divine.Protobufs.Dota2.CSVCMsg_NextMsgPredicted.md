# <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted"></a> Class CSVCMsg\_NextMsgPredicted

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_NextMsgPredicted : IMessage<CSVCMsg_NextMsgPredicted>, IEquatable<CSVCMsg_NextMsgPredicted>, IDeepCloneable<CSVCMsg_NextMsgPredicted>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_NextMsgPredicted](Divine.Protobufs.Dota2.CSVCMsg\_NextMsgPredicted.md)

#### Implements

IMessage<CSVCMsg\_NextMsgPredicted\>, 
[IEquatable<CSVCMsg\_NextMsgPredicted\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_NextMsgPredicted\>, 
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
[EnumerableExtensions.In<CSVCMsg\_NextMsgPredicted\>\(CSVCMsg\_NextMsgPredicted, params CSVCMsg\_NextMsgPredicted\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted__ctor"></a> CSVCMsg\_NextMsgPredicted\(\)

```csharp
public CSVCMsg_NextMsgPredicted()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted__ctor_Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_"></a> CSVCMsg\_NextMsgPredicted\(CSVCMsg\_NextMsgPredicted\)

```csharp
public CSVCMsg_NextMsgPredicted(CSVCMsg_NextMsgPredicted other)
```

#### Parameters

`other` [CSVCMsg\_NextMsgPredicted](Divine.Protobufs.Dota2.CSVCMsg\_NextMsgPredicted.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_MessageTypeIdFieldNumber"></a> MessageTypeIdFieldNumber

```csharp
public const int MessageTypeIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_PredictedByPlayerSlotFieldNumber"></a> PredictedByPlayerSlotFieldNumber

```csharp
public const int PredictedByPlayerSlotFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_HasMessageTypeId"></a> HasMessageTypeId

```csharp
public bool HasMessageTypeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_HasPredictedByPlayerSlot"></a> HasPredictedByPlayerSlot

```csharp
public bool HasPredictedByPlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_MessageTypeId"></a> MessageTypeId

```csharp
public uint MessageTypeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_NextMsgPredicted> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_NextMsgPredicted](Divine.Protobufs.Dota2.CSVCMsg\_NextMsgPredicted.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_PredictedByPlayerSlot"></a> PredictedByPlayerSlot

```csharp
public int PredictedByPlayerSlot { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_ClearMessageTypeId"></a> ClearMessageTypeId\(\)

```csharp
public void ClearMessageTypeId()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_ClearPredictedByPlayerSlot"></a> ClearPredictedByPlayerSlot\(\)

```csharp
public void ClearPredictedByPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_NextMsgPredicted Clone()
```

#### Returns

 [CSVCMsg\_NextMsgPredicted](Divine.Protobufs.Dota2.CSVCMsg\_NextMsgPredicted.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_Equals_Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_"></a> Equals\(CSVCMsg\_NextMsgPredicted\)

```csharp
public bool Equals(CSVCMsg_NextMsgPredicted other)
```

#### Parameters

`other` [CSVCMsg\_NextMsgPredicted](Divine.Protobufs.Dota2.CSVCMsg\_NextMsgPredicted.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_"></a> MergeFrom\(CSVCMsg\_NextMsgPredicted\)

```csharp
public void MergeFrom(CSVCMsg_NextMsgPredicted other)
```

#### Parameters

`other` [CSVCMsg\_NextMsgPredicted](Divine.Protobufs.Dota2.CSVCMsg\_NextMsgPredicted.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_NextMsgPredicted_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

