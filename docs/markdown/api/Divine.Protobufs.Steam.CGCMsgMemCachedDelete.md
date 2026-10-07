# <a id="Divine_Protobufs_Steam_CGCMsgMemCachedDelete"></a> Class CGCMsgMemCachedDelete

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCMsgMemCachedDelete : IMessage<CGCMsgMemCachedDelete>, IEquatable<CGCMsgMemCachedDelete>, IDeepCloneable<CGCMsgMemCachedDelete>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCMsgMemCachedDelete](Divine.Protobufs.Steam.CGCMsgMemCachedDelete.md)

#### Implements

IMessage<CGCMsgMemCachedDelete\>, 
[IEquatable<CGCMsgMemCachedDelete\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCMsgMemCachedDelete\>, 
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
[EnumerableExtensions.In<CGCMsgMemCachedDelete\>\(CGCMsgMemCachedDelete, params CGCMsgMemCachedDelete\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedDelete__ctor"></a> CGCMsgMemCachedDelete\(\)

```csharp
public CGCMsgMemCachedDelete()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedDelete__ctor_Divine_Protobufs_Steam_CGCMsgMemCachedDelete_"></a> CGCMsgMemCachedDelete\(CGCMsgMemCachedDelete\)

```csharp
public CGCMsgMemCachedDelete(CGCMsgMemCachedDelete other)
```

#### Parameters

`other` [CGCMsgMemCachedDelete](Divine.Protobufs.Steam.CGCMsgMemCachedDelete.md)

## Fields

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedDelete_KeysFieldNumber"></a> KeysFieldNumber

```csharp
public const int KeysFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedDelete_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedDelete_Keys"></a> Keys

```csharp
public RepeatedField<string> Keys { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedDelete_Parser"></a> Parser

```csharp
public static MessageParser<CGCMsgMemCachedDelete> Parser { get; }
```

#### Property Value

 MessageParser<[CGCMsgMemCachedDelete](Divine.Protobufs.Steam.CGCMsgMemCachedDelete.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedDelete_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedDelete_Clone"></a> Clone\(\)

```csharp
public CGCMsgMemCachedDelete Clone()
```

#### Returns

 [CGCMsgMemCachedDelete](Divine.Protobufs.Steam.CGCMsgMemCachedDelete.md)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedDelete_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedDelete_Equals_Divine_Protobufs_Steam_CGCMsgMemCachedDelete_"></a> Equals\(CGCMsgMemCachedDelete\)

```csharp
public bool Equals(CGCMsgMemCachedDelete other)
```

#### Parameters

`other` [CGCMsgMemCachedDelete](Divine.Protobufs.Steam.CGCMsgMemCachedDelete.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedDelete_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedDelete_MergeFrom_Divine_Protobufs_Steam_CGCMsgMemCachedDelete_"></a> MergeFrom\(CGCMsgMemCachedDelete\)

```csharp
public void MergeFrom(CGCMsgMemCachedDelete other)
```

#### Parameters

`other` [CGCMsgMemCachedDelete](Divine.Protobufs.Steam.CGCMsgMemCachedDelete.md)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedDelete_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedDelete_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedDelete_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

