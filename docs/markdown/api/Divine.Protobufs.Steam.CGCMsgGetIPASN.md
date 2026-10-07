# <a id="Divine_Protobufs_Steam_CGCMsgGetIPASN"></a> Class CGCMsgGetIPASN

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCMsgGetIPASN : IMessage<CGCMsgGetIPASN>, IEquatable<CGCMsgGetIPASN>, IDeepCloneable<CGCMsgGetIPASN>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCMsgGetIPASN](Divine.Protobufs.Steam.CGCMsgGetIPASN.md)

#### Implements

IMessage<CGCMsgGetIPASN\>, 
[IEquatable<CGCMsgGetIPASN\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCMsgGetIPASN\>, 
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
[EnumerableExtensions.In<CGCMsgGetIPASN\>\(CGCMsgGetIPASN, params CGCMsgGetIPASN\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASN__ctor"></a> CGCMsgGetIPASN\(\)

```csharp
public CGCMsgGetIPASN()
```

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASN__ctor_Divine_Protobufs_Steam_CGCMsgGetIPASN_"></a> CGCMsgGetIPASN\(CGCMsgGetIPASN\)

```csharp
public CGCMsgGetIPASN(CGCMsgGetIPASN other)
```

#### Parameters

`other` [CGCMsgGetIPASN](Divine.Protobufs.Steam.CGCMsgGetIPASN.md)

## Fields

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASN_IpsFieldNumber"></a> IpsFieldNumber

```csharp
public const int IpsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASN_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASN_Ips"></a> Ips

```csharp
public RepeatedField<uint> Ips { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASN_Parser"></a> Parser

```csharp
public static MessageParser<CGCMsgGetIPASN> Parser { get; }
```

#### Property Value

 MessageParser<[CGCMsgGetIPASN](Divine.Protobufs.Steam.CGCMsgGetIPASN.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASN_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASN_Clone"></a> Clone\(\)

```csharp
public CGCMsgGetIPASN Clone()
```

#### Returns

 [CGCMsgGetIPASN](Divine.Protobufs.Steam.CGCMsgGetIPASN.md)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASN_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASN_Equals_Divine_Protobufs_Steam_CGCMsgGetIPASN_"></a> Equals\(CGCMsgGetIPASN\)

```csharp
public bool Equals(CGCMsgGetIPASN other)
```

#### Parameters

`other` [CGCMsgGetIPASN](Divine.Protobufs.Steam.CGCMsgGetIPASN.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASN_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASN_MergeFrom_Divine_Protobufs_Steam_CGCMsgGetIPASN_"></a> MergeFrom\(CGCMsgGetIPASN\)

```csharp
public void MergeFrom(CGCMsgGetIPASN other)
```

#### Parameters

`other` [CGCMsgGetIPASN](Divine.Protobufs.Steam.CGCMsgGetIPASN.md)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASN_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASN_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGCMsgGetIPASN_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

