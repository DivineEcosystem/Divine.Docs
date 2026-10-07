# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateQuestProgress"></a> Class CDOTAUserMsg\_UpdateQuestProgress

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_UpdateQuestProgress : IMessage<CDOTAUserMsg_UpdateQuestProgress>, IEquatable<CDOTAUserMsg_UpdateQuestProgress>, IDeepCloneable<CDOTAUserMsg_UpdateQuestProgress>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_UpdateQuestProgress](Divine.Protobufs.Dota2.CDOTAUserMsg\_UpdateQuestProgress.md)

#### Implements

IMessage<CDOTAUserMsg\_UpdateQuestProgress\>, 
[IEquatable<CDOTAUserMsg\_UpdateQuestProgress\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_UpdateQuestProgress\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_UpdateQuestProgress\>\(CDOTAUserMsg\_UpdateQuestProgress, params CDOTAUserMsg\_UpdateQuestProgress\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateQuestProgress__ctor"></a> CDOTAUserMsg\_UpdateQuestProgress\(\)

```csharp
public CDOTAUserMsg_UpdateQuestProgress()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateQuestProgress__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateQuestProgress_"></a> CDOTAUserMsg\_UpdateQuestProgress\(CDOTAUserMsg\_UpdateQuestProgress\)

```csharp
public CDOTAUserMsg_UpdateQuestProgress(CDOTAUserMsg_UpdateQuestProgress other)
```

#### Parameters

`other` [CDOTAUserMsg\_UpdateQuestProgress](Divine.Protobufs.Dota2.CDOTAUserMsg\_UpdateQuestProgress.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateQuestProgress_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateQuestProgress_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_UpdateQuestProgress> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_UpdateQuestProgress](Divine.Protobufs.Dota2.CDOTAUserMsg\_UpdateQuestProgress.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateQuestProgress_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateQuestProgress_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_UpdateQuestProgress Clone()
```

#### Returns

 [CDOTAUserMsg\_UpdateQuestProgress](Divine.Protobufs.Dota2.CDOTAUserMsg\_UpdateQuestProgress.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateQuestProgress_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateQuestProgress_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateQuestProgress_"></a> Equals\(CDOTAUserMsg\_UpdateQuestProgress\)

```csharp
public bool Equals(CDOTAUserMsg_UpdateQuestProgress other)
```

#### Parameters

`other` [CDOTAUserMsg\_UpdateQuestProgress](Divine.Protobufs.Dota2.CDOTAUserMsg\_UpdateQuestProgress.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateQuestProgress_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateQuestProgress_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateQuestProgress_"></a> MergeFrom\(CDOTAUserMsg\_UpdateQuestProgress\)

```csharp
public void MergeFrom(CDOTAUserMsg_UpdateQuestProgress other)
```

#### Parameters

`other` [CDOTAUserMsg\_UpdateQuestProgress](Divine.Protobufs.Dota2.CDOTAUserMsg\_UpdateQuestProgress.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateQuestProgress_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateQuestProgress_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateQuestProgress_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

