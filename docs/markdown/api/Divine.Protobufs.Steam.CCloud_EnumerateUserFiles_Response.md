# <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response"></a> Class CCloud\_EnumerateUserFiles\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CCloud_EnumerateUserFiles_Response : IMessage<CCloud_EnumerateUserFiles_Response>, IEquatable<CCloud_EnumerateUserFiles_Response>, IDeepCloneable<CCloud_EnumerateUserFiles_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CCloud\_EnumerateUserFiles\_Response](Divine.Protobufs.Steam.CCloud\_EnumerateUserFiles\_Response.md)

#### Implements

IMessage<CCloud\_EnumerateUserFiles\_Response\>, 
[IEquatable<CCloud\_EnumerateUserFiles\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CCloud\_EnumerateUserFiles\_Response\>, 
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
[EnumerableExtensions.In<CCloud\_EnumerateUserFiles\_Response\>\(CCloud\_EnumerateUserFiles\_Response, params CCloud\_EnumerateUserFiles\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response__ctor"></a> CCloud\_EnumerateUserFiles\_Response\(\)

```csharp
public CCloud_EnumerateUserFiles_Response()
```

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response__ctor_Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_"></a> CCloud\_EnumerateUserFiles\_Response\(CCloud\_EnumerateUserFiles\_Response\)

```csharp
public CCloud_EnumerateUserFiles_Response(CCloud_EnumerateUserFiles_Response other)
```

#### Parameters

`other` [CCloud\_EnumerateUserFiles\_Response](Divine.Protobufs.Steam.CCloud\_EnumerateUserFiles\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_FilesFieldNumber"></a> FilesFieldNumber

```csharp
public const int FilesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_TotalFilesFieldNumber"></a> TotalFilesFieldNumber

```csharp
public const int TotalFilesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_Files"></a> Files

```csharp
public RepeatedField<CCloud_UserFile> Files { get; }
```

#### Property Value

 RepeatedField<[CCloud\_UserFile](Divine.Protobufs.Steam.CCloud\_UserFile.md)\>

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_HasTotalFiles"></a> HasTotalFiles

```csharp
public bool HasTotalFiles { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_Parser"></a> Parser

```csharp
public static MessageParser<CCloud_EnumerateUserFiles_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CCloud\_EnumerateUserFiles\_Response](Divine.Protobufs.Steam.CCloud\_EnumerateUserFiles\_Response.md)\>

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_TotalFiles"></a> TotalFiles

```csharp
public uint TotalFiles { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_ClearTotalFiles"></a> ClearTotalFiles\(\)

```csharp
public void ClearTotalFiles()
```

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_Clone"></a> Clone\(\)

```csharp
public CCloud_EnumerateUserFiles_Response Clone()
```

#### Returns

 [CCloud\_EnumerateUserFiles\_Response](Divine.Protobufs.Steam.CCloud\_EnumerateUserFiles\_Response.md)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_Equals_Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_"></a> Equals\(CCloud\_EnumerateUserFiles\_Response\)

```csharp
public bool Equals(CCloud_EnumerateUserFiles_Response other)
```

#### Parameters

`other` [CCloud\_EnumerateUserFiles\_Response](Divine.Protobufs.Steam.CCloud\_EnumerateUserFiles\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_MergeFrom_Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_"></a> MergeFrom\(CCloud\_EnumerateUserFiles\_Response\)

```csharp
public void MergeFrom(CCloud_EnumerateUserFiles_Response other)
```

#### Parameters

`other` [CCloud\_EnumerateUserFiles\_Response](Divine.Protobufs.Steam.CCloud\_EnumerateUserFiles\_Response.md)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

