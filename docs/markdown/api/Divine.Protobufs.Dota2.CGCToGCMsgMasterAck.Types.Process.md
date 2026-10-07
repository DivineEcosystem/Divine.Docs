# <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process"></a> Class CGCToGCMsgMasterAck.Types.Process

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCToGCMsgMasterAck.Types.Process : IMessage<CGCToGCMsgMasterAck.Types.Process>, IEquatable<CGCToGCMsgMasterAck.Types.Process>, IDeepCloneable<CGCToGCMsgMasterAck.Types.Process>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCToGCMsgMasterAck.Types.Process](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.Types.Process.md)

#### Implements

IMessage<CGCToGCMsgMasterAck.Types.Process\>, 
[IEquatable<CGCToGCMsgMasterAck.Types.Process\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCToGCMsgMasterAck.Types.Process\>, 
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
[EnumerableExtensions.In<CGCToGCMsgMasterAck.Types.Process\>\(CGCToGCMsgMasterAck.Types.Process, params CGCToGCMsgMasterAck.Types.Process\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process__ctor"></a> Process\(\)

```csharp
public Process()
```

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process__ctor_Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_"></a> Process\(Process\)

```csharp
public Process(CGCToGCMsgMasterAck.Types.Process other)
```

#### Parameters

`other` [CGCToGCMsgMasterAck](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.md).[Types](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.Types.md).[Process](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.Types.Process.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_DirIndexFieldNumber"></a> DirIndexFieldNumber

```csharp
public const int DirIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_TypeInstancesFieldNumber"></a> TypeInstancesFieldNumber

```csharp
public const int TypeInstancesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_DirIndex"></a> DirIndex

```csharp
public int DirIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_HasDirIndex"></a> HasDirIndex

```csharp
public bool HasDirIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_Parser"></a> Parser

```csharp
public static MessageParser<CGCToGCMsgMasterAck.Types.Process> Parser { get; }
```

#### Property Value

 MessageParser<[CGCToGCMsgMasterAck](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.md).[Types](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.Types.md).[Process](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.Types.Process.md)\>

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_TypeInstances"></a> TypeInstances

```csharp
public RepeatedField<uint> TypeInstances { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_ClearDirIndex"></a> ClearDirIndex\(\)

```csharp
public void ClearDirIndex()
```

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_Clone"></a> Clone\(\)

```csharp
public CGCToGCMsgMasterAck.Types.Process Clone()
```

#### Returns

 [CGCToGCMsgMasterAck](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.md).[Types](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.Types.md).[Process](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.Types.Process.md)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_Equals_Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_"></a> Equals\(Process\)

```csharp
public bool Equals(CGCToGCMsgMasterAck.Types.Process other)
```

#### Parameters

`other` [CGCToGCMsgMasterAck](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.md).[Types](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.Types.md).[Process](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.Types.Process.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_MergeFrom_Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_"></a> MergeFrom\(Process\)

```csharp
public void MergeFrom(CGCToGCMsgMasterAck.Types.Process other)
```

#### Parameters

`other` [CGCToGCMsgMasterAck](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.md).[Types](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.Types.md).[Process](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.Types.Process.md)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Types_Process_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

