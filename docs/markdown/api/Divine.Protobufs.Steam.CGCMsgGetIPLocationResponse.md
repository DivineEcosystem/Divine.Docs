# <a id="Divine_Protobufs_Steam_CGCMsgGetIPLocationResponse"></a> Class CGCMsgGetIPLocationResponse

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCMsgGetIPLocationResponse : IMessage<CGCMsgGetIPLocationResponse>, IEquatable<CGCMsgGetIPLocationResponse>, IDeepCloneable<CGCMsgGetIPLocationResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCMsgGetIPLocationResponse](Divine.Protobufs.Steam.CGCMsgGetIPLocationResponse.md)

#### Implements

IMessage<CGCMsgGetIPLocationResponse\>, 
[IEquatable<CGCMsgGetIPLocationResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCMsgGetIPLocationResponse\>, 
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
[EnumerableExtensions.In<CGCMsgGetIPLocationResponse\>\(CGCMsgGetIPLocationResponse, params CGCMsgGetIPLocationResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPLocationResponse__ctor"></a> CGCMsgGetIPLocationResponse\(\)

```csharp
public CGCMsgGetIPLocationResponse()
```

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPLocationResponse__ctor_Divine_Protobufs_Steam_CGCMsgGetIPLocationResponse_"></a> CGCMsgGetIPLocationResponse\(CGCMsgGetIPLocationResponse\)

```csharp
public CGCMsgGetIPLocationResponse(CGCMsgGetIPLocationResponse other)
```

#### Parameters

`other` [CGCMsgGetIPLocationResponse](Divine.Protobufs.Steam.CGCMsgGetIPLocationResponse.md)

## Fields

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPLocationResponse_InfosFieldNumber"></a> InfosFieldNumber

```csharp
public const int InfosFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPLocationResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPLocationResponse_Infos"></a> Infos

```csharp
public RepeatedField<CIPLocationInfo> Infos { get; }
```

#### Property Value

 RepeatedField<[CIPLocationInfo](Divine.Protobufs.Steam.CIPLocationInfo.md)\>

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPLocationResponse_Parser"></a> Parser

```csharp
public static MessageParser<CGCMsgGetIPLocationResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CGCMsgGetIPLocationResponse](Divine.Protobufs.Steam.CGCMsgGetIPLocationResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPLocationResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPLocationResponse_Clone"></a> Clone\(\)

```csharp
public CGCMsgGetIPLocationResponse Clone()
```

#### Returns

 [CGCMsgGetIPLocationResponse](Divine.Protobufs.Steam.CGCMsgGetIPLocationResponse.md)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPLocationResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPLocationResponse_Equals_Divine_Protobufs_Steam_CGCMsgGetIPLocationResponse_"></a> Equals\(CGCMsgGetIPLocationResponse\)

```csharp
public bool Equals(CGCMsgGetIPLocationResponse other)
```

#### Parameters

`other` [CGCMsgGetIPLocationResponse](Divine.Protobufs.Steam.CGCMsgGetIPLocationResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPLocationResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPLocationResponse_MergeFrom_Divine_Protobufs_Steam_CGCMsgGetIPLocationResponse_"></a> MergeFrom\(CGCMsgGetIPLocationResponse\)

```csharp
public void MergeFrom(CGCMsgGetIPLocationResponse other)
```

#### Parameters

`other` [CGCMsgGetIPLocationResponse](Divine.Protobufs.Steam.CGCMsgGetIPLocationResponse.md)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPLocationResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPLocationResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPLocationResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

