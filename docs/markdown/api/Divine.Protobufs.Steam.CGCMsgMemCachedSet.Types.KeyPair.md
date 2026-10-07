# <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair"></a> Class CGCMsgMemCachedSet.Types.KeyPair

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCMsgMemCachedSet.Types.KeyPair : IMessage<CGCMsgMemCachedSet.Types.KeyPair>, IEquatable<CGCMsgMemCachedSet.Types.KeyPair>, IDeepCloneable<CGCMsgMemCachedSet.Types.KeyPair>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCMsgMemCachedSet.Types.KeyPair](Divine.Protobufs.Steam.CGCMsgMemCachedSet.Types.KeyPair.md)

#### Implements

IMessage<CGCMsgMemCachedSet.Types.KeyPair\>, 
[IEquatable<CGCMsgMemCachedSet.Types.KeyPair\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCMsgMemCachedSet.Types.KeyPair\>, 
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
[EnumerableExtensions.In<CGCMsgMemCachedSet.Types.KeyPair\>\(CGCMsgMemCachedSet.Types.KeyPair, params CGCMsgMemCachedSet.Types.KeyPair\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair__ctor"></a> KeyPair\(\)

```csharp
public KeyPair()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair__ctor_Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_"></a> KeyPair\(KeyPair\)

```csharp
public KeyPair(CGCMsgMemCachedSet.Types.KeyPair other)
```

#### Parameters

`other` [CGCMsgMemCachedSet](Divine.Protobufs.Steam.CGCMsgMemCachedSet.md).[Types](Divine.Protobufs.Steam.CGCMsgMemCachedSet.Types.md).[KeyPair](Divine.Protobufs.Steam.CGCMsgMemCachedSet.Types.KeyPair.md)

## Fields

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_Parser"></a> Parser

```csharp
public static MessageParser<CGCMsgMemCachedSet.Types.KeyPair> Parser { get; }
```

#### Property Value

 MessageParser<[CGCMsgMemCachedSet](Divine.Protobufs.Steam.CGCMsgMemCachedSet.md).[Types](Divine.Protobufs.Steam.CGCMsgMemCachedSet.Types.md).[KeyPair](Divine.Protobufs.Steam.CGCMsgMemCachedSet.Types.KeyPair.md)\>

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_Value"></a> Value

```csharp
public ByteString Value { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_Clone"></a> Clone\(\)

```csharp
public CGCMsgMemCachedSet.Types.KeyPair Clone()
```

#### Returns

 [CGCMsgMemCachedSet](Divine.Protobufs.Steam.CGCMsgMemCachedSet.md).[Types](Divine.Protobufs.Steam.CGCMsgMemCachedSet.Types.md).[KeyPair](Divine.Protobufs.Steam.CGCMsgMemCachedSet.Types.KeyPair.md)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_Equals_Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_"></a> Equals\(KeyPair\)

```csharp
public bool Equals(CGCMsgMemCachedSet.Types.KeyPair other)
```

#### Parameters

`other` [CGCMsgMemCachedSet](Divine.Protobufs.Steam.CGCMsgMemCachedSet.md).[Types](Divine.Protobufs.Steam.CGCMsgMemCachedSet.Types.md).[KeyPair](Divine.Protobufs.Steam.CGCMsgMemCachedSet.Types.KeyPair.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_MergeFrom_Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_"></a> MergeFrom\(KeyPair\)

```csharp
public void MergeFrom(CGCMsgMemCachedSet.Types.KeyPair other)
```

#### Parameters

`other` [CGCMsgMemCachedSet](Divine.Protobufs.Steam.CGCMsgMemCachedSet.md).[Types](Divine.Protobufs.Steam.CGCMsgMemCachedSet.Types.md).[KeyPair](Divine.Protobufs.Steam.CGCMsgMemCachedSet.Types.KeyPair.md)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedSet_Types_KeyPair_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

