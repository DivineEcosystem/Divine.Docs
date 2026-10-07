# <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo"></a> Class CSVCMsg\_ClassInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_ClassInfo : IMessage<CSVCMsg_ClassInfo>, IEquatable<CSVCMsg_ClassInfo>, IDeepCloneable<CSVCMsg_ClassInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_ClassInfo](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.md)

#### Implements

IMessage<CSVCMsg\_ClassInfo\>, 
[IEquatable<CSVCMsg\_ClassInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_ClassInfo\>, 
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
[EnumerableExtensions.In<CSVCMsg\_ClassInfo\>\(CSVCMsg\_ClassInfo, params CSVCMsg\_ClassInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo__ctor"></a> CSVCMsg\_ClassInfo\(\)

```csharp
public CSVCMsg_ClassInfo()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo__ctor_Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_"></a> CSVCMsg\_ClassInfo\(CSVCMsg\_ClassInfo\)

```csharp
public CSVCMsg_ClassInfo(CSVCMsg_ClassInfo other)
```

#### Parameters

`other` [CSVCMsg\_ClassInfo](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_ClassesFieldNumber"></a> ClassesFieldNumber

```csharp
public const int ClassesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_CreateOnClientFieldNumber"></a> CreateOnClientFieldNumber

```csharp
public const int CreateOnClientFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Classes"></a> Classes

```csharp
public RepeatedField<CSVCMsg_ClassInfo.Types.class_t> Classes { get; }
```

#### Property Value

 RepeatedField<[CSVCMsg\_ClassInfo](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.Types.md).[class\_t](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.Types.class\_t.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_CreateOnClient"></a> CreateOnClient

```csharp
public bool CreateOnClient { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_HasCreateOnClient"></a> HasCreateOnClient

```csharp
public bool HasCreateOnClient { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_ClassInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_ClassInfo](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_ClearCreateOnClient"></a> ClearCreateOnClient\(\)

```csharp
public void ClearCreateOnClient()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_ClassInfo Clone()
```

#### Returns

 [CSVCMsg\_ClassInfo](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_Equals_Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_"></a> Equals\(CSVCMsg\_ClassInfo\)

```csharp
public bool Equals(CSVCMsg_ClassInfo other)
```

#### Parameters

`other` [CSVCMsg\_ClassInfo](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_"></a> MergeFrom\(CSVCMsg\_ClassInfo\)

```csharp
public void MergeFrom(CSVCMsg_ClassInfo other)
```

#### Parameters

`other` [CSVCMsg\_ClassInfo](Divine.Protobufs.Dota2.CSVCMsg\_ClassInfo.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClassInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

