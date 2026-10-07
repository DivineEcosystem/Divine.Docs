# <a id="Divine_Protobufs_Steam_CGCMsgGetIPASNResponse"></a> Class CGCMsgGetIPASNResponse

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCMsgGetIPASNResponse : IMessage<CGCMsgGetIPASNResponse>, IEquatable<CGCMsgGetIPASNResponse>, IDeepCloneable<CGCMsgGetIPASNResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCMsgGetIPASNResponse](Divine.Protobufs.Steam.CGCMsgGetIPASNResponse.md)

#### Implements

IMessage<CGCMsgGetIPASNResponse\>, 
[IEquatable<CGCMsgGetIPASNResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCMsgGetIPASNResponse\>, 
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
[EnumerableExtensions.In<CGCMsgGetIPASNResponse\>\(CGCMsgGetIPASNResponse, params CGCMsgGetIPASNResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASNResponse__ctor"></a> CGCMsgGetIPASNResponse\(\)

```csharp
public CGCMsgGetIPASNResponse()
```

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASNResponse__ctor_Divine_Protobufs_Steam_CGCMsgGetIPASNResponse_"></a> CGCMsgGetIPASNResponse\(CGCMsgGetIPASNResponse\)

```csharp
public CGCMsgGetIPASNResponse(CGCMsgGetIPASNResponse other)
```

#### Parameters

`other` [CGCMsgGetIPASNResponse](Divine.Protobufs.Steam.CGCMsgGetIPASNResponse.md)

## Fields

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASNResponse_InfosFieldNumber"></a> InfosFieldNumber

```csharp
public const int InfosFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASNResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASNResponse_Infos"></a> Infos

```csharp
public RepeatedField<CIPASNInfo> Infos { get; }
```

#### Property Value

 RepeatedField<[CIPASNInfo](Divine.Protobufs.Steam.CIPASNInfo.md)\>

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASNResponse_Parser"></a> Parser

```csharp
public static MessageParser<CGCMsgGetIPASNResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CGCMsgGetIPASNResponse](Divine.Protobufs.Steam.CGCMsgGetIPASNResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASNResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASNResponse_Clone"></a> Clone\(\)

```csharp
public CGCMsgGetIPASNResponse Clone()
```

#### Returns

 [CGCMsgGetIPASNResponse](Divine.Protobufs.Steam.CGCMsgGetIPASNResponse.md)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASNResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASNResponse_Equals_Divine_Protobufs_Steam_CGCMsgGetIPASNResponse_"></a> Equals\(CGCMsgGetIPASNResponse\)

```csharp
public bool Equals(CGCMsgGetIPASNResponse other)
```

#### Parameters

`other` [CGCMsgGetIPASNResponse](Divine.Protobufs.Steam.CGCMsgGetIPASNResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASNResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASNResponse_MergeFrom_Divine_Protobufs_Steam_CGCMsgGetIPASNResponse_"></a> MergeFrom\(CGCMsgGetIPASNResponse\)

```csharp
public void MergeFrom(CGCMsgGetIPASNResponse other)
```

#### Parameters

`other` [CGCMsgGetIPASNResponse](Divine.Protobufs.Steam.CGCMsgGetIPASNResponse.md)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASNResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASNResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASNResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

