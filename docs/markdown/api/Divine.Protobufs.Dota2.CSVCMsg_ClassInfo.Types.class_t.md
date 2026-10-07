# <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t"></a> Class CSVCMsg\_ClassInfo.Types.class\_t

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_ClassInfo.Types.class_t : IMessage<CSVCMsg_ClassInfo.Types.class_t>, IEquatable<CSVCMsg_ClassInfo.Types.class_t>, IDeepCloneable<CSVCMsg_ClassInfo.Types.class_t>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_ClassInfo.Types.class\_t](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.Types.class\_t.md)

#### Implements

IMessage<CSVCMsg\_ClassInfo.Types.class\_t\>, 
[IEquatable<CSVCMsg\_ClassInfo.Types.class\_t\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_ClassInfo.Types.class\_t\>, 
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
[EnumerableExtensions.In<CSVCMsg\_ClassInfo.Types.class\_t\>\(CSVCMsg\_ClassInfo.Types.class\_t, params CSVCMsg\_ClassInfo.Types.class\_t\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t__ctor"></a> class\_t\(\)

```csharp
public class_t()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t__ctor_Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_"></a> class\_t\(class\_t\)

```csharp
public class_t(CSVCMsg_ClassInfo.Types.class_t other)
```

#### Parameters

`other` [CSVCMsg\_ClassInfo](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.Types.md).[class\_t](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.Types.class\_t.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_ClassIdFieldNumber"></a> ClassIdFieldNumber

```csharp
public const int ClassIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_ClassNameFieldNumber"></a> ClassNameFieldNumber

```csharp
public const int ClassNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_ClassId"></a> ClassId

```csharp
public int ClassId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_ClassName"></a> ClassName

```csharp
public string ClassName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_HasClassId"></a> HasClassId

```csharp
public bool HasClassId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_HasClassName"></a> HasClassName

```csharp
public bool HasClassName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_ClassInfo.Types.class_t> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_ClassInfo](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.Types.md).[class\_t](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.Types.class\_t.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_ClearClassId"></a> ClearClassId\(\)

```csharp
public void ClearClassId()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_ClearClassName"></a> ClearClassName\(\)

```csharp
public void ClearClassName()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_ClassInfo.Types.class_t Clone()
```

#### Returns

 [CSVCMsg\_ClassInfo](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.Types.md).[class\_t](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.Types.class\_t.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_Equals_Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_"></a> Equals\(class\_t\)

```csharp
public bool Equals(CSVCMsg_ClassInfo.Types.class_t other)
```

#### Parameters

`other` [CSVCMsg\_ClassInfo](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.Types.md).[class\_t](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.Types.class\_t.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_"></a> MergeFrom\(class\_t\)

```csharp
public void MergeFrom(CSVCMsg_ClassInfo.Types.class_t other)
```

#### Parameters

`other` [CSVCMsg\_ClassInfo](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.Types.md).[class\_t](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.Types.class\_t.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Types_class_t_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

