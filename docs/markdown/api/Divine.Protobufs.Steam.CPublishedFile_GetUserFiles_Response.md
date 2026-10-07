# <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response"></a> Class CPublishedFile\_GetUserFiles\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPublishedFile_GetUserFiles_Response : IMessage<CPublishedFile_GetUserFiles_Response>, IEquatable<CPublishedFile_GetUserFiles_Response>, IDeepCloneable<CPublishedFile_GetUserFiles_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPublishedFile\_GetUserFiles\_Response](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.md)

#### Implements

IMessage<CPublishedFile\_GetUserFiles\_Response\>, 
[IEquatable<CPublishedFile\_GetUserFiles\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPublishedFile\_GetUserFiles\_Response\>, 
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
[EnumerableExtensions.In<CPublishedFile\_GetUserFiles\_Response\>\(CPublishedFile\_GetUserFiles\_Response, params CPublishedFile\_GetUserFiles\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response__ctor"></a> CPublishedFile\_GetUserFiles\_Response\(\)

```csharp
public CPublishedFile_GetUserFiles_Response()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response__ctor_Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_"></a> CPublishedFile\_GetUserFiles\_Response\(CPublishedFile\_GetUserFiles\_Response\)

```csharp
public CPublishedFile_GetUserFiles_Response(CPublishedFile_GetUserFiles_Response other)
```

#### Parameters

`other` [CPublishedFile\_GetUserFiles\_Response](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_AppsFieldNumber"></a> AppsFieldNumber

```csharp
public const int AppsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_PublishedfiledetailsFieldNumber"></a> PublishedfiledetailsFieldNumber

```csharp
public const int PublishedfiledetailsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_StartindexFieldNumber"></a> StartindexFieldNumber

```csharp
public const int StartindexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_TotalFieldNumber"></a> TotalFieldNumber

```csharp
public const int TotalFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Apps"></a> Apps

```csharp
public RepeatedField<CPublishedFile_GetUserFiles_Response.Types.App> Apps { get; }
```

#### Property Value

 RepeatedField<[CPublishedFile\_GetUserFiles\_Response](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.md).[Types](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.Types.md).[App](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.Types.App.md)\>

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_HasStartindex"></a> HasStartindex

```csharp
public bool HasStartindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_HasTotal"></a> HasTotal

```csharp
public bool HasTotal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Parser"></a> Parser

```csharp
public static MessageParser<CPublishedFile_GetUserFiles_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CPublishedFile\_GetUserFiles\_Response](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.md)\>

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Publishedfiledetails"></a> Publishedfiledetails

```csharp
public RepeatedField<PublishedFileDetails> Publishedfiledetails { get; }
```

#### Property Value

 RepeatedField<[PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md)\>

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Startindex"></a> Startindex

```csharp
public uint Startindex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Total"></a> Total

```csharp
public uint Total { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_ClearStartindex"></a> ClearStartindex\(\)

```csharp
public void ClearStartindex()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_ClearTotal"></a> ClearTotal\(\)

```csharp
public void ClearTotal()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Clone"></a> Clone\(\)

```csharp
public CPublishedFile_GetUserFiles_Response Clone()
```

#### Returns

 [CPublishedFile\_GetUserFiles\_Response](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.md)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_Equals_Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_"></a> Equals\(CPublishedFile\_GetUserFiles\_Response\)

```csharp
public bool Equals(CPublishedFile_GetUserFiles_Response other)
```

#### Parameters

`other` [CPublishedFile\_GetUserFiles\_Response](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_MergeFrom_Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_"></a> MergeFrom\(CPublishedFile\_GetUserFiles\_Response\)

```csharp
public void MergeFrom(CPublishedFile_GetUserFiles_Response other)
```

#### Parameters

`other` [CPublishedFile\_GetUserFiles\_Response](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Response.md)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

