# <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse"></a> Class CGCMsgMemCachedGetResponse

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCMsgMemCachedGetResponse : IMessage<CGCMsgMemCachedGetResponse>, IEquatable<CGCMsgMemCachedGetResponse>, IDeepCloneable<CGCMsgMemCachedGetResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCMsgMemCachedGetResponse](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.md)

#### Implements

IMessage<CGCMsgMemCachedGetResponse\>, 
[IEquatable<CGCMsgMemCachedGetResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCMsgMemCachedGetResponse\>, 
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
[EnumerableExtensions.In<CGCMsgMemCachedGetResponse\>\(CGCMsgMemCachedGetResponse, params CGCMsgMemCachedGetResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse__ctor"></a> CGCMsgMemCachedGetResponse\(\)

```csharp
public CGCMsgMemCachedGetResponse()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse__ctor_Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_"></a> CGCMsgMemCachedGetResponse\(CGCMsgMemCachedGetResponse\)

```csharp
public CGCMsgMemCachedGetResponse(CGCMsgMemCachedGetResponse other)
```

#### Parameters

`other` [CGCMsgMemCachedGetResponse](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.md)

## Fields

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_ValuesFieldNumber"></a> ValuesFieldNumber

```csharp
public const int ValuesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Parser"></a> Parser

```csharp
public static MessageParser<CGCMsgMemCachedGetResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CGCMsgMemCachedGetResponse](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.md)\>

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Values"></a> Values

```csharp
public RepeatedField<CGCMsgMemCachedGetResponse.Types.ValueTag> Values { get; }
```

#### Property Value

 RepeatedField<[CGCMsgMemCachedGetResponse](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.md).[Types](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.Types.md).[ValueTag](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.Types.ValueTag.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Clone"></a> Clone\(\)

```csharp
public CGCMsgMemCachedGetResponse Clone()
```

#### Returns

 [CGCMsgMemCachedGetResponse](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.md)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Equals_Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_"></a> Equals\(CGCMsgMemCachedGetResponse\)

```csharp
public bool Equals(CGCMsgMemCachedGetResponse other)
```

#### Parameters

`other` [CGCMsgMemCachedGetResponse](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_MergeFrom_Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_"></a> MergeFrom\(CGCMsgMemCachedGetResponse\)

```csharp
public void MergeFrom(CGCMsgMemCachedGetResponse other)
```

#### Parameters

`other` [CGCMsgMemCachedGetResponse](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.md)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

