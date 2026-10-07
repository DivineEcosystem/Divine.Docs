# <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader"></a> Class CMsgHttpResponse.Types.ResponseHeader

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgHttpResponse.Types.ResponseHeader : IMessage<CMsgHttpResponse.Types.ResponseHeader>, IEquatable<CMsgHttpResponse.Types.ResponseHeader>, IDeepCloneable<CMsgHttpResponse.Types.ResponseHeader>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgHttpResponse.Types.ResponseHeader](Divine.Protobufs.Steam.CMsgHttpResponse.Types.ResponseHeader.md)

#### Implements

IMessage<CMsgHttpResponse.Types.ResponseHeader\>, 
[IEquatable<CMsgHttpResponse.Types.ResponseHeader\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgHttpResponse.Types.ResponseHeader\>, 
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
[EnumerableExtensions.In<CMsgHttpResponse.Types.ResponseHeader\>\(CMsgHttpResponse.Types.ResponseHeader, params CMsgHttpResponse.Types.ResponseHeader\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader__ctor"></a> ResponseHeader\(\)

```csharp
public ResponseHeader()
```

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader__ctor_Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_"></a> ResponseHeader\(ResponseHeader\)

```csharp
public ResponseHeader(CMsgHttpResponse.Types.ResponseHeader other)
```

#### Parameters

`other` [CMsgHttpResponse](Divine.Protobufs.Steam.CMsgHttpResponse.md).[Types](Divine.Protobufs.Steam.CMsgHttpResponse.Types.md).[ResponseHeader](Divine.Protobufs.Steam.CMsgHttpResponse.Types.ResponseHeader.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_Parser"></a> Parser

```csharp
public static MessageParser<CMsgHttpResponse.Types.ResponseHeader> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgHttpResponse](Divine.Protobufs.Steam.CMsgHttpResponse.md).[Types](Divine.Protobufs.Steam.CMsgHttpResponse.Types.md).[ResponseHeader](Divine.Protobufs.Steam.CMsgHttpResponse.Types.ResponseHeader.md)\>

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_Value"></a> Value

```csharp
public string Value { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_Clone"></a> Clone\(\)

```csharp
public CMsgHttpResponse.Types.ResponseHeader Clone()
```

#### Returns

 [CMsgHttpResponse](Divine.Protobufs.Steam.CMsgHttpResponse.md).[Types](Divine.Protobufs.Steam.CMsgHttpResponse.Types.md).[ResponseHeader](Divine.Protobufs.Steam.CMsgHttpResponse.Types.ResponseHeader.md)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_Equals_Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_"></a> Equals\(ResponseHeader\)

```csharp
public bool Equals(CMsgHttpResponse.Types.ResponseHeader other)
```

#### Parameters

`other` [CMsgHttpResponse](Divine.Protobufs.Steam.CMsgHttpResponse.md).[Types](Divine.Protobufs.Steam.CMsgHttpResponse.Types.md).[ResponseHeader](Divine.Protobufs.Steam.CMsgHttpResponse.Types.ResponseHeader.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_MergeFrom_Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_"></a> MergeFrom\(ResponseHeader\)

```csharp
public void MergeFrom(CMsgHttpResponse.Types.ResponseHeader other)
```

#### Parameters

`other` [CMsgHttpResponse](Divine.Protobufs.Steam.CMsgHttpResponse.md).[Types](Divine.Protobufs.Steam.CMsgHttpResponse.Types.md).[ResponseHeader](Divine.Protobufs.Steam.CMsgHttpResponse.Types.ResponseHeader.md)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgHttpResponse_Types_ResponseHeader_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

