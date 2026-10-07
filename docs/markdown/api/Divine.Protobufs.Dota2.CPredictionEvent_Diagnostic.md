# <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic"></a> Class CPredictionEvent\_Diagnostic

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPredictionEvent_Diagnostic : IMessage<CPredictionEvent_Diagnostic>, IEquatable<CPredictionEvent_Diagnostic>, IDeepCloneable<CPredictionEvent_Diagnostic>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPredictionEvent\_Diagnostic](Divine.Protobufs.Dota2.CPredictionEvent\_Diagnostic.md)

#### Implements

IMessage<CPredictionEvent\_Diagnostic\>, 
[IEquatable<CPredictionEvent\_Diagnostic\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPredictionEvent\_Diagnostic\>, 
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
[EnumerableExtensions.In<CPredictionEvent\_Diagnostic\>\(CPredictionEvent\_Diagnostic, params CPredictionEvent\_Diagnostic\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic__ctor"></a> CPredictionEvent\_Diagnostic\(\)

```csharp
public CPredictionEvent_Diagnostic()
```

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic__ctor_Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_"></a> CPredictionEvent\_Diagnostic\(CPredictionEvent\_Diagnostic\)

```csharp
public CPredictionEvent_Diagnostic(CPredictionEvent_Diagnostic other)
```

#### Parameters

`other` [CPredictionEvent\_Diagnostic](Divine.Protobufs.Dota2.CPredictionEvent\_Diagnostic.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_ExecutionSyncFieldNumber"></a> ExecutionSyncFieldNumber

```csharp
public const int ExecutionSyncFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_RequestedPlayerIndexFieldNumber"></a> RequestedPlayerIndexFieldNumber

```csharp
public const int RequestedPlayerIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_RequestedSyncFieldNumber"></a> RequestedSyncFieldNumber

```csharp
public const int RequestedSyncFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_ExecutionSync"></a> ExecutionSync

```csharp
public RepeatedField<uint> ExecutionSync { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_HasRequestedPlayerIndex"></a> HasRequestedPlayerIndex

```csharp
public bool HasRequestedPlayerIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_HasRequestedSync"></a> HasRequestedSync

```csharp
public bool HasRequestedSync { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_Id"></a> Id

```csharp
public uint Id { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_Parser"></a> Parser

```csharp
public static MessageParser<CPredictionEvent_Diagnostic> Parser { get; }
```

#### Property Value

 MessageParser<[CPredictionEvent\_Diagnostic](Divine.Protobufs.Dota2.CPredictionEvent\_Diagnostic.md)\>

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_RequestedPlayerIndex"></a> RequestedPlayerIndex

```csharp
public uint RequestedPlayerIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_RequestedSync"></a> RequestedSync

```csharp
public uint RequestedSync { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_ClearRequestedPlayerIndex"></a> ClearRequestedPlayerIndex\(\)

```csharp
public void ClearRequestedPlayerIndex()
```

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_ClearRequestedSync"></a> ClearRequestedSync\(\)

```csharp
public void ClearRequestedSync()
```

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_Clone"></a> Clone\(\)

```csharp
public CPredictionEvent_Diagnostic Clone()
```

#### Returns

 [CPredictionEvent\_Diagnostic](Divine.Protobufs.Dota2.CPredictionEvent\_Diagnostic.md)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_Equals_Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_"></a> Equals\(CPredictionEvent\_Diagnostic\)

```csharp
public bool Equals(CPredictionEvent_Diagnostic other)
```

#### Parameters

`other` [CPredictionEvent\_Diagnostic](Divine.Protobufs.Dota2.CPredictionEvent\_Diagnostic.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_MergeFrom_Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_"></a> MergeFrom\(CPredictionEvent\_Diagnostic\)

```csharp
public void MergeFrom(CPredictionEvent_Diagnostic other)
```

#### Parameters

`other` [CPredictionEvent\_Diagnostic](Divine.Protobufs.Dota2.CPredictionEvent\_Diagnostic.md)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Diagnostic_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

