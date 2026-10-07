# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote"></a> Class CDOTAClientMsg\_RecordVote

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_RecordVote : IMessage<CDOTAClientMsg_RecordVote>, IEquatable<CDOTAClientMsg_RecordVote>, IDeepCloneable<CDOTAClientMsg_RecordVote>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_RecordVote](Divine.Protobufs.Dota2.CDOTAClientMsg\_RecordVote.md)

#### Implements

IMessage<CDOTAClientMsg\_RecordVote\>, 
[IEquatable<CDOTAClientMsg\_RecordVote\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_RecordVote\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_RecordVote\>\(CDOTAClientMsg\_RecordVote, params CDOTAClientMsg\_RecordVote\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote__ctor"></a> CDOTAClientMsg\_RecordVote\(\)

```csharp
public CDOTAClientMsg_RecordVote()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote_"></a> CDOTAClientMsg\_RecordVote\(CDOTAClientMsg\_RecordVote\)

```csharp
public CDOTAClientMsg_RecordVote(CDOTAClientMsg_RecordVote other)
```

#### Parameters

`other` [CDOTAClientMsg\_RecordVote](Divine.Protobufs.Dota2.CDOTAClientMsg\_RecordVote.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote_ChoiceIndexFieldNumber"></a> ChoiceIndexFieldNumber

```csharp
public const int ChoiceIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote_ChoiceIndex"></a> ChoiceIndex

```csharp
public int ChoiceIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote_HasChoiceIndex"></a> HasChoiceIndex

```csharp
public bool HasChoiceIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_RecordVote> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_RecordVote](Divine.Protobufs.Dota2.CDOTAClientMsg\_RecordVote.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote_ClearChoiceIndex"></a> ClearChoiceIndex\(\)

```csharp
public void ClearChoiceIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_RecordVote Clone()
```

#### Returns

 [CDOTAClientMsg\_RecordVote](Divine.Protobufs.Dota2.CDOTAClientMsg\_RecordVote.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote_"></a> Equals\(CDOTAClientMsg\_RecordVote\)

```csharp
public bool Equals(CDOTAClientMsg_RecordVote other)
```

#### Parameters

`other` [CDOTAClientMsg\_RecordVote](Divine.Protobufs.Dota2.CDOTAClientMsg\_RecordVote.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote_"></a> MergeFrom\(CDOTAClientMsg\_RecordVote\)

```csharp
public void MergeFrom(CDOTAClientMsg_RecordVote other)
```

#### Parameters

`other` [CDOTAClientMsg\_RecordVote](Divine.Protobufs.Dota2.CDOTAClientMsg\_RecordVote.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RecordVote_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

