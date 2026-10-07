# <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted"></a> Class CGCToGCMsgRouted

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCToGCMsgRouted : IMessage<CGCToGCMsgRouted>, IEquatable<CGCToGCMsgRouted>, IDeepCloneable<CGCToGCMsgRouted>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCToGCMsgRouted](Divine.Protobufs.Dota2.CGCToGCMsgRouted.md)

#### Implements

IMessage<CGCToGCMsgRouted\>, 
[IEquatable<CGCToGCMsgRouted\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCToGCMsgRouted\>, 
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
[EnumerableExtensions.In<CGCToGCMsgRouted\>\(CGCToGCMsgRouted, params CGCToGCMsgRouted\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted__ctor"></a> CGCToGCMsgRouted\(\)

```csharp
public CGCToGCMsgRouted()
```

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted__ctor_Divine_Protobufs_Dota2_CGCToGCMsgRouted_"></a> CGCToGCMsgRouted\(CGCToGCMsgRouted\)

```csharp
public CGCToGCMsgRouted(CGCToGCMsgRouted other)
```

#### Parameters

`other` [CGCToGCMsgRouted](Divine.Protobufs.Dota2.CGCToGCMsgRouted.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_MsgTypeFieldNumber"></a> MsgTypeFieldNumber

```csharp
public const int MsgTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_NetMessageFieldNumber"></a> NetMessageFieldNumber

```csharp
public const int NetMessageFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_SenderIdFieldNumber"></a> SenderIdFieldNumber

```csharp
public const int SenderIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_HasMsgType"></a> HasMsgType

```csharp
public bool HasMsgType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_HasNetMessage"></a> HasNetMessage

```csharp
public bool HasNetMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_HasSenderId"></a> HasSenderId

```csharp
public bool HasSenderId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_MsgType"></a> MsgType

```csharp
public uint MsgType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_NetMessage"></a> NetMessage

```csharp
public ByteString NetMessage { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_Parser"></a> Parser

```csharp
public static MessageParser<CGCToGCMsgRouted> Parser { get; }
```

#### Property Value

 MessageParser<[CGCToGCMsgRouted](Divine.Protobufs.Dota2.CGCToGCMsgRouted.md)\>

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_SenderId"></a> SenderId

```csharp
public ulong SenderId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_ClearMsgType"></a> ClearMsgType\(\)

```csharp
public void ClearMsgType()
```

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_ClearNetMessage"></a> ClearNetMessage\(\)

```csharp
public void ClearNetMessage()
```

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_ClearSenderId"></a> ClearSenderId\(\)

```csharp
public void ClearSenderId()
```

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_Clone"></a> Clone\(\)

```csharp
public CGCToGCMsgRouted Clone()
```

#### Returns

 [CGCToGCMsgRouted](Divine.Protobufs.Dota2.CGCToGCMsgRouted.md)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_Equals_Divine_Protobufs_Dota2_CGCToGCMsgRouted_"></a> Equals\(CGCToGCMsgRouted\)

```csharp
public bool Equals(CGCToGCMsgRouted other)
```

#### Parameters

`other` [CGCToGCMsgRouted](Divine.Protobufs.Dota2.CGCToGCMsgRouted.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_MergeFrom_Divine_Protobufs_Dota2_CGCToGCMsgRouted_"></a> MergeFrom\(CGCToGCMsgRouted\)

```csharp
public void MergeFrom(CGCToGCMsgRouted other)
```

#### Parameters

`other` [CGCToGCMsgRouted](Divine.Protobufs.Dota2.CGCToGCMsgRouted.md)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRouted_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

