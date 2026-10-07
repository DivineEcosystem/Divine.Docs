# <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Response"></a> Class CPublishedFile\_GetDetails\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPublishedFile_GetDetails_Response : IMessage<CPublishedFile_GetDetails_Response>, IEquatable<CPublishedFile_GetDetails_Response>, IDeepCloneable<CPublishedFile_GetDetails_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPublishedFile\_GetDetails\_Response](Divine.Protobufs.Steam.CPublishedFile\_GetDetails\_Response.md)

#### Implements

IMessage<CPublishedFile\_GetDetails\_Response\>, 
[IEquatable<CPublishedFile\_GetDetails\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPublishedFile\_GetDetails\_Response\>, 
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
[EnumerableExtensions.In<CPublishedFile\_GetDetails\_Response\>\(CPublishedFile\_GetDetails\_Response, params CPublishedFile\_GetDetails\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Response__ctor"></a> CPublishedFile\_GetDetails\_Response\(\)

```csharp
public CPublishedFile_GetDetails_Response()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Response__ctor_Divine_Protobufs_Steam_CPublishedFile_GetDetails_Response_"></a> CPublishedFile\_GetDetails\_Response\(CPublishedFile\_GetDetails\_Response\)

```csharp
public CPublishedFile_GetDetails_Response(CPublishedFile_GetDetails_Response other)
```

#### Parameters

`other` [CPublishedFile\_GetDetails\_Response](Divine.Protobufs.Steam.CPublishedFile\_GetDetails\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Response_PublishedfiledetailsFieldNumber"></a> PublishedfiledetailsFieldNumber

```csharp
public const int PublishedfiledetailsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Response_Parser"></a> Parser

```csharp
public static MessageParser<CPublishedFile_GetDetails_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CPublishedFile\_GetDetails\_Response](Divine.Protobufs.Steam.CPublishedFile\_GetDetails\_Response.md)\>

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Response_Publishedfiledetails"></a> Publishedfiledetails

```csharp
public RepeatedField<PublishedFileDetails> Publishedfiledetails { get; }
```

#### Property Value

 RepeatedField<[PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Response_Clone"></a> Clone\(\)

```csharp
public CPublishedFile_GetDetails_Response Clone()
```

#### Returns

 [CPublishedFile\_GetDetails\_Response](Divine.Protobufs.Steam.CPublishedFile\_GetDetails\_Response.md)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Response_Equals_Divine_Protobufs_Steam_CPublishedFile_GetDetails_Response_"></a> Equals\(CPublishedFile\_GetDetails\_Response\)

```csharp
public bool Equals(CPublishedFile_GetDetails_Response other)
```

#### Parameters

`other` [CPublishedFile\_GetDetails\_Response](Divine.Protobufs.Steam.CPublishedFile\_GetDetails\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Response_MergeFrom_Divine_Protobufs_Steam_CPublishedFile_GetDetails_Response_"></a> MergeFrom\(CPublishedFile\_GetDetails\_Response\)

```csharp
public void MergeFrom(CPublishedFile_GetDetails_Response other)
```

#### Parameters

`other` [CPublishedFile\_GetDetails\_Response](Divine.Protobufs.Steam.CPublishedFile\_GetDetails\_Response.md)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetDetails_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

