# <a id="Divine_Protobufs_Steam_CCloud_GetFileDetails_Response"></a> Class CCloud\_GetFileDetails\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CCloud_GetFileDetails_Response : IMessage<CCloud_GetFileDetails_Response>, IEquatable<CCloud_GetFileDetails_Response>, IDeepCloneable<CCloud_GetFileDetails_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CCloud\_GetFileDetails\_Response](Divine.Protobufs.Steam.CCloud\_GetFileDetails\_Response.md)

#### Implements

IMessage<CCloud\_GetFileDetails\_Response\>, 
[IEquatable<CCloud\_GetFileDetails\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CCloud\_GetFileDetails\_Response\>, 
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
[EnumerableExtensions.In<CCloud\_GetFileDetails\_Response\>\(CCloud\_GetFileDetails\_Response, params CCloud\_GetFileDetails\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CCloud_GetFileDetails_Response__ctor"></a> CCloud\_GetFileDetails\_Response\(\)

```csharp
public CCloud_GetFileDetails_Response()
```

### <a id="Divine_Protobufs_Steam_CCloud_GetFileDetails_Response__ctor_Divine_Protobufs_Steam_CCloud_GetFileDetails_Response_"></a> CCloud\_GetFileDetails\_Response\(CCloud\_GetFileDetails\_Response\)

```csharp
public CCloud_GetFileDetails_Response(CCloud_GetFileDetails_Response other)
```

#### Parameters

`other` [CCloud\_GetFileDetails\_Response](Divine.Protobufs.Steam.CCloud\_GetFileDetails\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CCloud_GetFileDetails_Response_DetailsFieldNumber"></a> DetailsFieldNumber

```csharp
public const int DetailsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CCloud_GetFileDetails_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CCloud_GetFileDetails_Response_Details"></a> Details

```csharp
public CCloud_UserFile Details { get; set; }
```

#### Property Value

 [CCloud\_UserFile](Divine.Protobufs.Steam.CCloud\_UserFile.md)

### <a id="Divine_Protobufs_Steam_CCloud_GetFileDetails_Response_Parser"></a> Parser

```csharp
public static MessageParser<CCloud_GetFileDetails_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CCloud\_GetFileDetails\_Response](Divine.Protobufs.Steam.CCloud\_GetFileDetails\_Response.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CCloud_GetFileDetails_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_GetFileDetails_Response_Clone"></a> Clone\(\)

```csharp
public CCloud_GetFileDetails_Response Clone()
```

#### Returns

 [CCloud\_GetFileDetails\_Response](Divine.Protobufs.Steam.CCloud\_GetFileDetails\_Response.md)

### <a id="Divine_Protobufs_Steam_CCloud_GetFileDetails_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_GetFileDetails_Response_Equals_Divine_Protobufs_Steam_CCloud_GetFileDetails_Response_"></a> Equals\(CCloud\_GetFileDetails\_Response\)

```csharp
public bool Equals(CCloud_GetFileDetails_Response other)
```

#### Parameters

`other` [CCloud\_GetFileDetails\_Response](Divine.Protobufs.Steam.CCloud\_GetFileDetails\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_GetFileDetails_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_GetFileDetails_Response_MergeFrom_Divine_Protobufs_Steam_CCloud_GetFileDetails_Response_"></a> MergeFrom\(CCloud\_GetFileDetails\_Response\)

```csharp
public void MergeFrom(CCloud_GetFileDetails_Response other)
```

#### Parameters

`other` [CCloud\_GetFileDetails\_Response](Divine.Protobufs.Steam.CCloud\_GetFileDetails\_Response.md)

### <a id="Divine_Protobufs_Steam_CCloud_GetFileDetails_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CCloud_GetFileDetails_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CCloud_GetFileDetails_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

