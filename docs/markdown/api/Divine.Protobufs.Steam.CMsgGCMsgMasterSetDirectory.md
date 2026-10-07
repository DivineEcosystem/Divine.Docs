# <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory"></a> Class CMsgGCMsgMasterSetDirectory

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCMsgMasterSetDirectory : IMessage<CMsgGCMsgMasterSetDirectory>, IEquatable<CMsgGCMsgMasterSetDirectory>, IDeepCloneable<CMsgGCMsgMasterSetDirectory>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCMsgMasterSetDirectory](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.md)

#### Implements

IMessage<CMsgGCMsgMasterSetDirectory\>, 
[IEquatable<CMsgGCMsgMasterSetDirectory\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCMsgMasterSetDirectory\>, 
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
[EnumerableExtensions.In<CMsgGCMsgMasterSetDirectory\>\(CMsgGCMsgMasterSetDirectory, params CMsgGCMsgMasterSetDirectory\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory__ctor"></a> CMsgGCMsgMasterSetDirectory\(\)

```csharp
public CMsgGCMsgMasterSetDirectory()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory__ctor_Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_"></a> CMsgGCMsgMasterSetDirectory\(CMsgGCMsgMasterSetDirectory\)

```csharp
public CMsgGCMsgMasterSetDirectory(CMsgGCMsgMasterSetDirectory other)
```

#### Parameters

`other` [CMsgGCMsgMasterSetDirectory](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_DirFieldNumber"></a> DirFieldNumber

```csharp
public const int DirFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_MasterDirIndexFieldNumber"></a> MasterDirIndexFieldNumber

```csharp
public const int MasterDirIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Dir"></a> Dir

```csharp
public RepeatedField<CMsgGCMsgMasterSetDirectory.Types.SubGC> Dir { get; }
```

#### Property Value

 RepeatedField<[CMsgGCMsgMasterSetDirectory](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.Types.md).[SubGC](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.Types.SubGC.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_HasMasterDirIndex"></a> HasMasterDirIndex

```csharp
public bool HasMasterDirIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_MasterDirIndex"></a> MasterDirIndex

```csharp
public int MasterDirIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCMsgMasterSetDirectory> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCMsgMasterSetDirectory](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_ClearMasterDirIndex"></a> ClearMasterDirIndex\(\)

```csharp
public void ClearMasterDirIndex()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Clone"></a> Clone\(\)

```csharp
public CMsgGCMsgMasterSetDirectory Clone()
```

#### Returns

 [CMsgGCMsgMasterSetDirectory](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.md)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Equals_Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_"></a> Equals\(CMsgGCMsgMasterSetDirectory\)

```csharp
public bool Equals(CMsgGCMsgMasterSetDirectory other)
```

#### Parameters

`other` [CMsgGCMsgMasterSetDirectory](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_MergeFrom_Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_"></a> MergeFrom\(CMsgGCMsgMasterSetDirectory\)

```csharp
public void MergeFrom(CMsgGCMsgMasterSetDirectory other)
```

#### Parameters

`other` [CMsgGCMsgMasterSetDirectory](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.md)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

