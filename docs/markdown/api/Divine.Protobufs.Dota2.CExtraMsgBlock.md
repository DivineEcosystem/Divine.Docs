# <a id="Divine_Protobufs_Dota2_CExtraMsgBlock"></a> Class CExtraMsgBlock

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CExtraMsgBlock : IMessage<CExtraMsgBlock>, IEquatable<CExtraMsgBlock>, IDeepCloneable<CExtraMsgBlock>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CExtraMsgBlock](Divine.Protobufs.Dota2.CExtraMsgBlock.md)

#### Implements

IMessage<CExtraMsgBlock\>, 
[IEquatable<CExtraMsgBlock\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CExtraMsgBlock\>, 
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
[EnumerableExtensions.In<CExtraMsgBlock\>\(CExtraMsgBlock, params CExtraMsgBlock\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock__ctor"></a> CExtraMsgBlock\(\)

```csharp
public CExtraMsgBlock()
```

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock__ctor_Divine_Protobufs_Dota2_CExtraMsgBlock_"></a> CExtraMsgBlock\(CExtraMsgBlock\)

```csharp
public CExtraMsgBlock(CExtraMsgBlock other)
```

#### Parameters

`other` [CExtraMsgBlock](Divine.Protobufs.Dota2.CExtraMsgBlock.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_ContentsFieldNumber"></a> ContentsFieldNumber

```csharp
public const int ContentsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_IsCompressedFieldNumber"></a> IsCompressedFieldNumber

```csharp
public const int IsCompressedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_MsgKeyFieldNumber"></a> MsgKeyFieldNumber

```csharp
public const int MsgKeyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_MsgTypeFieldNumber"></a> MsgTypeFieldNumber

```csharp
public const int MsgTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_Contents"></a> Contents

```csharp
public ByteString Contents { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_HasContents"></a> HasContents

```csharp
public bool HasContents { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_HasIsCompressed"></a> HasIsCompressed

```csharp
public bool HasIsCompressed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_HasMsgKey"></a> HasMsgKey

```csharp
public bool HasMsgKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_HasMsgType"></a> HasMsgType

```csharp
public bool HasMsgType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_IsCompressed"></a> IsCompressed

```csharp
public bool IsCompressed { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_MsgKey"></a> MsgKey

```csharp
public ulong MsgKey { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_MsgType"></a> MsgType

```csharp
public uint MsgType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_Parser"></a> Parser

```csharp
public static MessageParser<CExtraMsgBlock> Parser { get; }
```

#### Property Value

 MessageParser<[CExtraMsgBlock](Divine.Protobufs.Dota2.CExtraMsgBlock.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_ClearContents"></a> ClearContents\(\)

```csharp
public void ClearContents()
```

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_ClearIsCompressed"></a> ClearIsCompressed\(\)

```csharp
public void ClearIsCompressed()
```

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_ClearMsgKey"></a> ClearMsgKey\(\)

```csharp
public void ClearMsgKey()
```

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_ClearMsgType"></a> ClearMsgType\(\)

```csharp
public void ClearMsgType()
```

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_Clone"></a> Clone\(\)

```csharp
public CExtraMsgBlock Clone()
```

#### Returns

 [CExtraMsgBlock](Divine.Protobufs.Dota2.CExtraMsgBlock.md)

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_Equals_Divine_Protobufs_Dota2_CExtraMsgBlock_"></a> Equals\(CExtraMsgBlock\)

```csharp
public bool Equals(CExtraMsgBlock other)
```

#### Parameters

`other` [CExtraMsgBlock](Divine.Protobufs.Dota2.CExtraMsgBlock.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_MergeFrom_Divine_Protobufs_Dota2_CExtraMsgBlock_"></a> MergeFrom\(CExtraMsgBlock\)

```csharp
public void MergeFrom(CExtraMsgBlock other)
```

#### Parameters

`other` [CExtraMsgBlock](Divine.Protobufs.Dota2.CExtraMsgBlock.md)

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CExtraMsgBlock_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

