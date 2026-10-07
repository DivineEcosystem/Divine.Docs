# <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient"></a> Class CGCMsgCompressedMsgToClient

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCMsgCompressedMsgToClient : IMessage<CGCMsgCompressedMsgToClient>, IEquatable<CGCMsgCompressedMsgToClient>, IDeepCloneable<CGCMsgCompressedMsgToClient>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCMsgCompressedMsgToClient](Divine.Protobufs.Dota2.CGCMsgCompressedMsgToClient.md)

#### Implements

IMessage<CGCMsgCompressedMsgToClient\>, 
[IEquatable<CGCMsgCompressedMsgToClient\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCMsgCompressedMsgToClient\>, 
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
[EnumerableExtensions.In<CGCMsgCompressedMsgToClient\>\(CGCMsgCompressedMsgToClient, params CGCMsgCompressedMsgToClient\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient__ctor"></a> CGCMsgCompressedMsgToClient\(\)

```csharp
public CGCMsgCompressedMsgToClient()
```

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient__ctor_Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_"></a> CGCMsgCompressedMsgToClient\(CGCMsgCompressedMsgToClient\)

```csharp
public CGCMsgCompressedMsgToClient(CGCMsgCompressedMsgToClient other)
```

#### Parameters

`other` [CGCMsgCompressedMsgToClient](Divine.Protobufs.Dota2.CGCMsgCompressedMsgToClient.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_CompressedMsgFieldNumber"></a> CompressedMsgFieldNumber

```csharp
public const int CompressedMsgFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_MsgIdFieldNumber"></a> MsgIdFieldNumber

```csharp
public const int MsgIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_CompressedMsg"></a> CompressedMsg

```csharp
public ByteString CompressedMsg { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_HasCompressedMsg"></a> HasCompressedMsg

```csharp
public bool HasCompressedMsg { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_HasMsgId"></a> HasMsgId

```csharp
public bool HasMsgId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_MsgId"></a> MsgId

```csharp
public uint MsgId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_Parser"></a> Parser

```csharp
public static MessageParser<CGCMsgCompressedMsgToClient> Parser { get; }
```

#### Property Value

 MessageParser<[CGCMsgCompressedMsgToClient](Divine.Protobufs.Dota2.CGCMsgCompressedMsgToClient.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_ClearCompressedMsg"></a> ClearCompressedMsg\(\)

```csharp
public void ClearCompressedMsg()
```

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_ClearMsgId"></a> ClearMsgId\(\)

```csharp
public void ClearMsgId()
```

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_Clone"></a> Clone\(\)

```csharp
public CGCMsgCompressedMsgToClient Clone()
```

#### Returns

 [CGCMsgCompressedMsgToClient](Divine.Protobufs.Dota2.CGCMsgCompressedMsgToClient.md)

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_Equals_Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_"></a> Equals\(CGCMsgCompressedMsgToClient\)

```csharp
public bool Equals(CGCMsgCompressedMsgToClient other)
```

#### Parameters

`other` [CGCMsgCompressedMsgToClient](Divine.Protobufs.Dota2.CGCMsgCompressedMsgToClient.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_MergeFrom_Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_"></a> MergeFrom\(CGCMsgCompressedMsgToClient\)

```csharp
public void MergeFrom(CGCMsgCompressedMsgToClient other)
```

#### Parameters

`other` [CGCMsgCompressedMsgToClient](Divine.Protobufs.Dota2.CGCMsgCompressedMsgToClient.md)

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CGCMsgCompressedMsgToClient_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

