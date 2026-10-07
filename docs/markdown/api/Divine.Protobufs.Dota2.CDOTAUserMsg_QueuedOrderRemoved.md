# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QueuedOrderRemoved"></a> Class CDOTAUserMsg\_QueuedOrderRemoved

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_QueuedOrderRemoved : IMessage<CDOTAUserMsg_QueuedOrderRemoved>, IEquatable<CDOTAUserMsg_QueuedOrderRemoved>, IDeepCloneable<CDOTAUserMsg_QueuedOrderRemoved>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_QueuedOrderRemoved](Divine.Protobufs.Dota2.CDOTAUserMsg\_QueuedOrderRemoved.md)

#### Implements

IMessage<CDOTAUserMsg\_QueuedOrderRemoved\>, 
[IEquatable<CDOTAUserMsg\_QueuedOrderRemoved\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_QueuedOrderRemoved\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_QueuedOrderRemoved\>\(CDOTAUserMsg\_QueuedOrderRemoved, params CDOTAUserMsg\_QueuedOrderRemoved\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QueuedOrderRemoved__ctor"></a> CDOTAUserMsg\_QueuedOrderRemoved\(\)

```csharp
public CDOTAUserMsg_QueuedOrderRemoved()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QueuedOrderRemoved__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_QueuedOrderRemoved_"></a> CDOTAUserMsg\_QueuedOrderRemoved\(CDOTAUserMsg\_QueuedOrderRemoved\)

```csharp
public CDOTAUserMsg_QueuedOrderRemoved(CDOTAUserMsg_QueuedOrderRemoved other)
```

#### Parameters

`other` [CDOTAUserMsg\_QueuedOrderRemoved](Divine.Protobufs.Dota2.CDOTAUserMsg\_QueuedOrderRemoved.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QueuedOrderRemoved_UnitOrderSequenceFieldNumber"></a> UnitOrderSequenceFieldNumber

```csharp
public const int UnitOrderSequenceFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QueuedOrderRemoved_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QueuedOrderRemoved_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_QueuedOrderRemoved> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_QueuedOrderRemoved](Divine.Protobufs.Dota2.CDOTAUserMsg\_QueuedOrderRemoved.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QueuedOrderRemoved_UnitOrderSequence"></a> UnitOrderSequence

```csharp
public RepeatedField<uint> UnitOrderSequence { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QueuedOrderRemoved_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QueuedOrderRemoved_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_QueuedOrderRemoved Clone()
```

#### Returns

 [CDOTAUserMsg\_QueuedOrderRemoved](Divine.Protobufs.Dota2.CDOTAUserMsg\_QueuedOrderRemoved.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QueuedOrderRemoved_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QueuedOrderRemoved_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_QueuedOrderRemoved_"></a> Equals\(CDOTAUserMsg\_QueuedOrderRemoved\)

```csharp
public bool Equals(CDOTAUserMsg_QueuedOrderRemoved other)
```

#### Parameters

`other` [CDOTAUserMsg\_QueuedOrderRemoved](Divine.Protobufs.Dota2.CDOTAUserMsg\_QueuedOrderRemoved.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QueuedOrderRemoved_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QueuedOrderRemoved_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_QueuedOrderRemoved_"></a> MergeFrom\(CDOTAUserMsg\_QueuedOrderRemoved\)

```csharp
public void MergeFrom(CDOTAUserMsg_QueuedOrderRemoved other)
```

#### Parameters

`other` [CDOTAUserMsg\_QueuedOrderRemoved](Divine.Protobufs.Dota2.CDOTAUserMsg\_QueuedOrderRemoved.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QueuedOrderRemoved_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QueuedOrderRemoved_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QueuedOrderRemoved_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

