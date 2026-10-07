# <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag"></a> Class CGCMsgMemCachedGetResponse.Types.ValueTag

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCMsgMemCachedGetResponse.Types.ValueTag : IMessage<CGCMsgMemCachedGetResponse.Types.ValueTag>, IEquatable<CGCMsgMemCachedGetResponse.Types.ValueTag>, IDeepCloneable<CGCMsgMemCachedGetResponse.Types.ValueTag>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCMsgMemCachedGetResponse.Types.ValueTag](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.Types.ValueTag.md)

#### Implements

IMessage<CGCMsgMemCachedGetResponse.Types.ValueTag\>, 
[IEquatable<CGCMsgMemCachedGetResponse.Types.ValueTag\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCMsgMemCachedGetResponse.Types.ValueTag\>, 
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
[EnumerableExtensions.In<CGCMsgMemCachedGetResponse.Types.ValueTag\>\(CGCMsgMemCachedGetResponse.Types.ValueTag, params CGCMsgMemCachedGetResponse.Types.ValueTag\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag__ctor"></a> ValueTag\(\)

```csharp
public ValueTag()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag__ctor_Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_"></a> ValueTag\(ValueTag\)

```csharp
public ValueTag(CGCMsgMemCachedGetResponse.Types.ValueTag other)
```

#### Parameters

`other` [CGCMsgMemCachedGetResponse](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.md).[Types](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.Types.md).[ValueTag](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.Types.ValueTag.md)

## Fields

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_FoundFieldNumber"></a> FoundFieldNumber

```csharp
public const int FoundFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_Found"></a> Found

```csharp
public bool Found { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_HasFound"></a> HasFound

```csharp
public bool HasFound { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_Parser"></a> Parser

```csharp
public static MessageParser<CGCMsgMemCachedGetResponse.Types.ValueTag> Parser { get; }
```

#### Property Value

 MessageParser<[CGCMsgMemCachedGetResponse](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.md).[Types](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.Types.md).[ValueTag](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.Types.ValueTag.md)\>

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_Value"></a> Value

```csharp
public ByteString Value { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_ClearFound"></a> ClearFound\(\)

```csharp
public void ClearFound()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_Clone"></a> Clone\(\)

```csharp
public CGCMsgMemCachedGetResponse.Types.ValueTag Clone()
```

#### Returns

 [CGCMsgMemCachedGetResponse](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.md).[Types](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.Types.md).[ValueTag](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.Types.ValueTag.md)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_Equals_Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_"></a> Equals\(ValueTag\)

```csharp
public bool Equals(CGCMsgMemCachedGetResponse.Types.ValueTag other)
```

#### Parameters

`other` [CGCMsgMemCachedGetResponse](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.md).[Types](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.Types.md).[ValueTag](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.Types.ValueTag.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_MergeFrom_Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_"></a> MergeFrom\(ValueTag\)

```csharp
public void MergeFrom(CGCMsgMemCachedGetResponse.Types.ValueTag other)
```

#### Parameters

`other` [CGCMsgMemCachedGetResponse](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.md).[Types](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.Types.md).[ValueTag](Divine.Protobufs.Steam.CGCMsgMemCachedGetResponse.Types.ValueTag.md)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGetResponse_Types_ValueTag_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

