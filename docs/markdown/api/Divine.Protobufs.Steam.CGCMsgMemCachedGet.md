# <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGet"></a> Class CGCMsgMemCachedGet

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCMsgMemCachedGet : IMessage<CGCMsgMemCachedGet>, IEquatable<CGCMsgMemCachedGet>, IDeepCloneable<CGCMsgMemCachedGet>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCMsgMemCachedGet](Divine.Protobufs.Steam.CGCMsgMemCachedGet.md)

#### Implements

IMessage<CGCMsgMemCachedGet\>, 
[IEquatable<CGCMsgMemCachedGet\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCMsgMemCachedGet\>, 
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
[EnumerableExtensions.In<CGCMsgMemCachedGet\>\(CGCMsgMemCachedGet, params CGCMsgMemCachedGet\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGet__ctor"></a> CGCMsgMemCachedGet\(\)

```csharp
public CGCMsgMemCachedGet()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGet__ctor_Divine_Protobufs_Steam_CGCMsgMemCachedGet_"></a> CGCMsgMemCachedGet\(CGCMsgMemCachedGet\)

```csharp
public CGCMsgMemCachedGet(CGCMsgMemCachedGet other)
```

#### Parameters

`other` [CGCMsgMemCachedGet](Divine.Protobufs.Steam.CGCMsgMemCachedGet.md)

## Fields

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGet_KeysFieldNumber"></a> KeysFieldNumber

```csharp
public const int KeysFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGet_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGet_Keys"></a> Keys

```csharp
public RepeatedField<string> Keys { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGet_Parser"></a> Parser

```csharp
public static MessageParser<CGCMsgMemCachedGet> Parser { get; }
```

#### Property Value

 MessageParser<[CGCMsgMemCachedGet](Divine.Protobufs.Steam.CGCMsgMemCachedGet.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGet_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGet_Clone"></a> Clone\(\)

```csharp
public CGCMsgMemCachedGet Clone()
```

#### Returns

 [CGCMsgMemCachedGet](Divine.Protobufs.Steam.CGCMsgMemCachedGet.md)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGet_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGet_Equals_Divine_Protobufs_Steam_CGCMsgMemCachedGet_"></a> Equals\(CGCMsgMemCachedGet\)

```csharp
public bool Equals(CGCMsgMemCachedGet other)
```

#### Parameters

`other` [CGCMsgMemCachedGet](Divine.Protobufs.Steam.CGCMsgMemCachedGet.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGet_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGet_MergeFrom_Divine_Protobufs_Steam_CGCMsgMemCachedGet_"></a> MergeFrom\(CGCMsgMemCachedGet\)

```csharp
public void MergeFrom(CGCMsgMemCachedGet other)
```

#### Parameters

`other` [CGCMsgMemCachedGet](Divine.Protobufs.Steam.CGCMsgMemCachedGet.md)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGet_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGet_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedGet_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

