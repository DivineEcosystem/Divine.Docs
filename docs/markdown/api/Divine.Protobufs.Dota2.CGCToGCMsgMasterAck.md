# <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck"></a> Class CGCToGCMsgMasterAck

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCToGCMsgMasterAck : IMessage<CGCToGCMsgMasterAck>, IEquatable<CGCToGCMsgMasterAck>, IDeepCloneable<CGCToGCMsgMasterAck>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCToGCMsgMasterAck](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.md)

#### Implements

IMessage<CGCToGCMsgMasterAck\>, 
[IEquatable<CGCToGCMsgMasterAck\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCToGCMsgMasterAck\>, 
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
[EnumerableExtensions.In<CGCToGCMsgMasterAck\>\(CGCToGCMsgMasterAck, params CGCToGCMsgMasterAck\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck__ctor"></a> CGCToGCMsgMasterAck\(\)

```csharp
public CGCToGCMsgMasterAck()
```

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck__ctor_Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_"></a> CGCToGCMsgMasterAck\(CGCToGCMsgMasterAck\)

```csharp
public CGCToGCMsgMasterAck(CGCToGCMsgMasterAck other)
```

#### Parameters

`other` [CGCToGCMsgMasterAck](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_DirectoryFieldNumber"></a> DirectoryFieldNumber

```csharp
public const int DirectoryFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_DirIndexFieldNumber"></a> DirIndexFieldNumber

```csharp
public const int DirIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_MachineNameFieldNumber"></a> MachineNameFieldNumber

```csharp
public const int MachineNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_ProcessNameFieldNumber"></a> ProcessNameFieldNumber

```csharp
public const int ProcessNameFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Directory"></a> Directory

```csharp
public RepeatedField<CGCToGCMsgMasterAck.Types.Process> Directory { get; }
```

#### Property Value

 RepeatedField<[CGCToGCMsgMasterAck](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.md).[Types](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.Types.md).[Process](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.Types.Process.md)\>

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_DirIndex"></a> DirIndex

```csharp
public int DirIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_HasDirIndex"></a> HasDirIndex

```csharp
public bool HasDirIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_HasMachineName"></a> HasMachineName

```csharp
public bool HasMachineName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_HasProcessName"></a> HasProcessName

```csharp
public bool HasProcessName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_MachineName"></a> MachineName

```csharp
public string MachineName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Parser"></a> Parser

```csharp
public static MessageParser<CGCToGCMsgMasterAck> Parser { get; }
```

#### Property Value

 MessageParser<[CGCToGCMsgMasterAck](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.md)\>

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_ProcessName"></a> ProcessName

```csharp
public string ProcessName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_ClearDirIndex"></a> ClearDirIndex\(\)

```csharp
public void ClearDirIndex()
```

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_ClearMachineName"></a> ClearMachineName\(\)

```csharp
public void ClearMachineName()
```

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_ClearProcessName"></a> ClearProcessName\(\)

```csharp
public void ClearProcessName()
```

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Clone"></a> Clone\(\)

```csharp
public CGCToGCMsgMasterAck Clone()
```

#### Returns

 [CGCToGCMsgMasterAck](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.md)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Equals_Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_"></a> Equals\(CGCToGCMsgMasterAck\)

```csharp
public bool Equals(CGCToGCMsgMasterAck other)
```

#### Parameters

`other` [CGCToGCMsgMasterAck](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_MergeFrom_Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_"></a> MergeFrom\(CGCToGCMsgMasterAck\)

```csharp
public void MergeFrom(CGCToGCMsgMasterAck other)
```

#### Parameters

`other` [CGCToGCMsgMasterAck](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck.md)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

