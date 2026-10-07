# <a id="Divine_Protobufs_Steam_CMsgGCGetCommandListResponse"></a> Class CMsgGCGetCommandListResponse

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCGetCommandListResponse : IMessage<CMsgGCGetCommandListResponse>, IEquatable<CMsgGCGetCommandListResponse>, IDeepCloneable<CMsgGCGetCommandListResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCGetCommandListResponse](Divine.Protobufs.Steam.CMsgGCGetCommandListResponse.md)

#### Implements

IMessage<CMsgGCGetCommandListResponse\>, 
[IEquatable<CMsgGCGetCommandListResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCGetCommandListResponse\>, 
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
[EnumerableExtensions.In<CMsgGCGetCommandListResponse\>\(CMsgGCGetCommandListResponse, params CMsgGCGetCommandListResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandListResponse__ctor"></a> CMsgGCGetCommandListResponse\(\)

```csharp
public CMsgGCGetCommandListResponse()
```

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandListResponse__ctor_Divine_Protobufs_Steam_CMsgGCGetCommandListResponse_"></a> CMsgGCGetCommandListResponse\(CMsgGCGetCommandListResponse\)

```csharp
public CMsgGCGetCommandListResponse(CMsgGCGetCommandListResponse other)
```

#### Parameters

`other` [CMsgGCGetCommandListResponse](Divine.Protobufs.Steam.CMsgGCGetCommandListResponse.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandListResponse_CommandNameFieldNumber"></a> CommandNameFieldNumber

```csharp
public const int CommandNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandListResponse_CommandName"></a> CommandName

```csharp
public RepeatedField<string> CommandName { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandListResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandListResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCGetCommandListResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCGetCommandListResponse](Divine.Protobufs.Steam.CMsgGCGetCommandListResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandListResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandListResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCGetCommandListResponse Clone()
```

#### Returns

 [CMsgGCGetCommandListResponse](Divine.Protobufs.Steam.CMsgGCGetCommandListResponse.md)

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandListResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandListResponse_Equals_Divine_Protobufs_Steam_CMsgGCGetCommandListResponse_"></a> Equals\(CMsgGCGetCommandListResponse\)

```csharp
public bool Equals(CMsgGCGetCommandListResponse other)
```

#### Parameters

`other` [CMsgGCGetCommandListResponse](Divine.Protobufs.Steam.CMsgGCGetCommandListResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandListResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandListResponse_MergeFrom_Divine_Protobufs_Steam_CMsgGCGetCommandListResponse_"></a> MergeFrom\(CMsgGCGetCommandListResponse\)

```csharp
public void MergeFrom(CMsgGCGetCommandListResponse other)
```

#### Parameters

`other` [CMsgGCGetCommandListResponse](Divine.Protobufs.Steam.CMsgGCGetCommandListResponse.md)

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandListResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandListResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandListResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

