# <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo"></a> Class CGCToGCMsgMasterStartupComplete.Types.GCInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCToGCMsgMasterStartupComplete.Types.GCInfo : IMessage<CGCToGCMsgMasterStartupComplete.Types.GCInfo>, IEquatable<CGCToGCMsgMasterStartupComplete.Types.GCInfo>, IDeepCloneable<CGCToGCMsgMasterStartupComplete.Types.GCInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCToGCMsgMasterStartupComplete.Types.GCInfo](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.Types.GCInfo.md)

#### Implements

IMessage<CGCToGCMsgMasterStartupComplete.Types.GCInfo\>, 
[IEquatable<CGCToGCMsgMasterStartupComplete.Types.GCInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCToGCMsgMasterStartupComplete.Types.GCInfo\>, 
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
[EnumerableExtensions.In<CGCToGCMsgMasterStartupComplete.Types.GCInfo\>\(CGCToGCMsgMasterStartupComplete.Types.GCInfo, params CGCToGCMsgMasterStartupComplete.Types.GCInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo__ctor"></a> GCInfo\(\)

```csharp
public GCInfo()
```

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo__ctor_Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_"></a> GCInfo\(GCInfo\)

```csharp
public GCInfo(CGCToGCMsgMasterStartupComplete.Types.GCInfo other)
```

#### Parameters

`other` [CGCToGCMsgMasterStartupComplete](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.md).[Types](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.Types.md).[GCInfo](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.Types.GCInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_DirIndexFieldNumber"></a> DirIndexFieldNumber

```csharp
public const int DirIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_MachineNameFieldNumber"></a> MachineNameFieldNumber

```csharp
public const int MachineNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_DirIndex"></a> DirIndex

```csharp
public int DirIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_HasDirIndex"></a> HasDirIndex

```csharp
public bool HasDirIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_HasMachineName"></a> HasMachineName

```csharp
public bool HasMachineName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_MachineName"></a> MachineName

```csharp
public string MachineName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_Parser"></a> Parser

```csharp
public static MessageParser<CGCToGCMsgMasterStartupComplete.Types.GCInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CGCToGCMsgMasterStartupComplete](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.md).[Types](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.Types.md).[GCInfo](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.Types.GCInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_ClearDirIndex"></a> ClearDirIndex\(\)

```csharp
public void ClearDirIndex()
```

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_ClearMachineName"></a> ClearMachineName\(\)

```csharp
public void ClearMachineName()
```

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_Clone"></a> Clone\(\)

```csharp
public CGCToGCMsgMasterStartupComplete.Types.GCInfo Clone()
```

#### Returns

 [CGCToGCMsgMasterStartupComplete](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.md).[Types](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.Types.md).[GCInfo](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.Types.GCInfo.md)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_Equals_Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_"></a> Equals\(GCInfo\)

```csharp
public bool Equals(CGCToGCMsgMasterStartupComplete.Types.GCInfo other)
```

#### Parameters

`other` [CGCToGCMsgMasterStartupComplete](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.md).[Types](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.Types.md).[GCInfo](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.Types.GCInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_MergeFrom_Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_"></a> MergeFrom\(GCInfo\)

```csharp
public void MergeFrom(CGCToGCMsgMasterStartupComplete.Types.GCInfo other)
```

#### Parameters

`other` [CGCToGCMsgMasterStartupComplete](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.md).[Types](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.Types.md).[GCInfo](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.Types.GCInfo.md)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Types_GCInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

