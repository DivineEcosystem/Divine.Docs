# <a id="Divine_Protobufs_Steam_CCloud_Delete_Request"></a> Class CCloud\_Delete\_Request

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CCloud_Delete_Request : IMessage<CCloud_Delete_Request>, IEquatable<CCloud_Delete_Request>, IDeepCloneable<CCloud_Delete_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CCloud\_Delete\_Request](Divine.Protobufs.Steam.CCloud\_Delete\_Request.md)

#### Implements

IMessage<CCloud\_Delete\_Request\>, 
[IEquatable<CCloud\_Delete\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CCloud\_Delete\_Request\>, 
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
[EnumerableExtensions.In<CCloud\_Delete\_Request\>\(CCloud\_Delete\_Request, params CCloud\_Delete\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request__ctor"></a> CCloud\_Delete\_Request\(\)

```csharp
public CCloud_Delete_Request()
```

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request__ctor_Divine_Protobufs_Steam_CCloud_Delete_Request_"></a> CCloud\_Delete\_Request\(CCloud\_Delete\_Request\)

```csharp
public CCloud_Delete_Request(CCloud_Delete_Request other)
```

#### Parameters

`other` [CCloud\_Delete\_Request](Divine.Protobufs.Steam.CCloud\_Delete\_Request.md)

## Fields

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request_FilenameFieldNumber"></a> FilenameFieldNumber

```csharp
public const int FilenameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request_Filename"></a> Filename

```csharp
public string Filename { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request_HasFilename"></a> HasFilename

```csharp
public bool HasFilename { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request_Parser"></a> Parser

```csharp
public static MessageParser<CCloud_Delete_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CCloud\_Delete\_Request](Divine.Protobufs.Steam.CCloud\_Delete\_Request.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request_ClearFilename"></a> ClearFilename\(\)

```csharp
public void ClearFilename()
```

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request_Clone"></a> Clone\(\)

```csharp
public CCloud_Delete_Request Clone()
```

#### Returns

 [CCloud\_Delete\_Request](Divine.Protobufs.Steam.CCloud\_Delete\_Request.md)

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request_Equals_Divine_Protobufs_Steam_CCloud_Delete_Request_"></a> Equals\(CCloud\_Delete\_Request\)

```csharp
public bool Equals(CCloud_Delete_Request other)
```

#### Parameters

`other` [CCloud\_Delete\_Request](Divine.Protobufs.Steam.CCloud\_Delete\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request_MergeFrom_Divine_Protobufs_Steam_CCloud_Delete_Request_"></a> MergeFrom\(CCloud\_Delete\_Request\)

```csharp
public void MergeFrom(CCloud_Delete_Request other)
```

#### Parameters

`other` [CCloud\_Delete\_Request](Divine.Protobufs.Steam.CCloud\_Delete\_Request.md)

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CCloud_Delete_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

