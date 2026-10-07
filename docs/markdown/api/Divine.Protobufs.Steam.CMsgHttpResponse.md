# <a id="Divine_Protobufs_Steam_CMsgHttpResponse"></a> Class CMsgHttpResponse

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgHttpResponse : IMessage<CMsgHttpResponse>, IEquatable<CMsgHttpResponse>, IDeepCloneable<CMsgHttpResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgHttpResponse](Divine.Protobufs.Steam.CMsgHttpResponse.md)

#### Implements

IMessage<CMsgHttpResponse\>, 
[IEquatable<CMsgHttpResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgHttpResponse\>, 
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
[EnumerableExtensions.In<CMsgHttpResponse\>\(CMsgHttpResponse, params CMsgHttpResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse__ctor"></a> CMsgHttpResponse\(\)

```csharp
public CMsgHttpResponse()
```

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse__ctor_Divine_Protobufs_Steam_CMsgHttpResponse_"></a> CMsgHttpResponse\(CMsgHttpResponse\)

```csharp
public CMsgHttpResponse(CMsgHttpResponse other)
```

#### Parameters

`other` [CMsgHttpResponse](Divine.Protobufs.Steam.CMsgHttpResponse.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_BodyFieldNumber"></a> BodyFieldNumber

```csharp
public const int BodyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_HeadersFieldNumber"></a> HeadersFieldNumber

```csharp
public const int HeadersFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_StatusCodeFieldNumber"></a> StatusCodeFieldNumber

```csharp
public const int StatusCodeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Body"></a> Body

```csharp
public ByteString Body { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_HasBody"></a> HasBody

```csharp
public bool HasBody { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_HasStatusCode"></a> HasStatusCode

```csharp
public bool HasStatusCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Headers"></a> Headers

```csharp
public RepeatedField<CMsgHttpResponse.Types.ResponseHeader> Headers { get; }
```

#### Property Value

 RepeatedField<[CMsgHttpResponse](Divine.Protobufs.Steam.CMsgHttpResponse.md).[Types](Divine.Protobufs.Steam.CMsgHttpResponse.Types.md).[ResponseHeader](Divine.Protobufs.Steam.CMsgHttpResponse.Types.ResponseHeader.md)\>

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgHttpResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgHttpResponse](Divine.Protobufs.Steam.CMsgHttpResponse.md)\>

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_StatusCode"></a> StatusCode

```csharp
public uint StatusCode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_ClearBody"></a> ClearBody\(\)

```csharp
public void ClearBody()
```

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_ClearStatusCode"></a> ClearStatusCode\(\)

```csharp
public void ClearStatusCode()
```

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Clone"></a> Clone\(\)

```csharp
public CMsgHttpResponse Clone()
```

#### Returns

 [CMsgHttpResponse](Divine.Protobufs.Steam.CMsgHttpResponse.md)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Equals_Divine_Protobufs_Steam_CMsgHttpResponse_"></a> Equals\(CMsgHttpResponse\)

```csharp
public bool Equals(CMsgHttpResponse other)
```

#### Parameters

`other` [CMsgHttpResponse](Divine.Protobufs.Steam.CMsgHttpResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_MergeFrom_Divine_Protobufs_Steam_CMsgHttpResponse_"></a> MergeFrom\(CMsgHttpResponse\)

```csharp
public void MergeFrom(CMsgHttpResponse other)
```

#### Parameters

`other` [CMsgHttpResponse](Divine.Protobufs.Steam.CMsgHttpResponse.md)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

