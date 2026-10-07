# <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC"></a> Class CMsgGCMsgMasterSetDirectory.Types.SubGC

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCMsgMasterSetDirectory.Types.SubGC : IMessage<CMsgGCMsgMasterSetDirectory.Types.SubGC>, IEquatable<CMsgGCMsgMasterSetDirectory.Types.SubGC>, IDeepCloneable<CMsgGCMsgMasterSetDirectory.Types.SubGC>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCMsgMasterSetDirectory.Types.SubGC](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.Types.SubGC.md)

#### Implements

IMessage<CMsgGCMsgMasterSetDirectory.Types.SubGC\>, 
[IEquatable<CMsgGCMsgMasterSetDirectory.Types.SubGC\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCMsgMasterSetDirectory.Types.SubGC\>, 
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
[EnumerableExtensions.In<CMsgGCMsgMasterSetDirectory.Types.SubGC\>\(CMsgGCMsgMasterSetDirectory.Types.SubGC, params CMsgGCMsgMasterSetDirectory.Types.SubGC\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC__ctor"></a> SubGC\(\)

```csharp
public SubGC()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC__ctor_Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_"></a> SubGC\(SubGC\)

```csharp
public SubGC(CMsgGCMsgMasterSetDirectory.Types.SubGC other)
```

#### Parameters

`other` [CMsgGCMsgMasterSetDirectory](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.Types.md).[SubGC](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.Types.SubGC.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_BoxFieldNumber"></a> BoxFieldNumber

```csharp
public const int BoxFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_CommandLineFieldNumber"></a> CommandLineFieldNumber

```csharp
public const int CommandLineFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_DirIndexFieldNumber"></a> DirIndexFieldNumber

```csharp
public const int DirIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_GcBinaryFieldNumber"></a> GcBinaryFieldNumber

```csharp
public const int GcBinaryFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_Box"></a> Box

```csharp
public string Box { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_CommandLine"></a> CommandLine

```csharp
public string CommandLine { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_DirIndex"></a> DirIndex

```csharp
public int DirIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_GcBinary"></a> GcBinary

```csharp
public string GcBinary { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_HasBox"></a> HasBox

```csharp
public bool HasBox { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_HasCommandLine"></a> HasCommandLine

```csharp
public bool HasCommandLine { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_HasDirIndex"></a> HasDirIndex

```csharp
public bool HasDirIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_HasGcBinary"></a> HasGcBinary

```csharp
public bool HasGcBinary { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCMsgMasterSetDirectory.Types.SubGC> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCMsgMasterSetDirectory](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.Types.md).[SubGC](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.Types.SubGC.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_ClearBox"></a> ClearBox\(\)

```csharp
public void ClearBox()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_ClearCommandLine"></a> ClearCommandLine\(\)

```csharp
public void ClearCommandLine()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_ClearDirIndex"></a> ClearDirIndex\(\)

```csharp
public void ClearDirIndex()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_ClearGcBinary"></a> ClearGcBinary\(\)

```csharp
public void ClearGcBinary()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_Clone"></a> Clone\(\)

```csharp
public CMsgGCMsgMasterSetDirectory.Types.SubGC Clone()
```

#### Returns

 [CMsgGCMsgMasterSetDirectory](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.Types.md).[SubGC](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.Types.SubGC.md)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_Equals_Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_"></a> Equals\(SubGC\)

```csharp
public bool Equals(CMsgGCMsgMasterSetDirectory.Types.SubGC other)
```

#### Parameters

`other` [CMsgGCMsgMasterSetDirectory](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.Types.md).[SubGC](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.Types.SubGC.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_MergeFrom_Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_"></a> MergeFrom\(SubGC\)

```csharp
public void MergeFrom(CMsgGCMsgMasterSetDirectory.Types.SubGC other)
```

#### Parameters

`other` [CMsgGCMsgMasterSetDirectory](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.Types.md).[SubGC](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory.Types.SubGC.md)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Types_SubGC_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

