# <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply"></a> Class CGCToGCMsgRoutedReply

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCToGCMsgRoutedReply : IMessage<CGCToGCMsgRoutedReply>, IEquatable<CGCToGCMsgRoutedReply>, IDeepCloneable<CGCToGCMsgRoutedReply>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCToGCMsgRoutedReply](Divine.Protobufs.Dota2.CGCToGCMsgRoutedReply.md)

#### Implements

IMessage<CGCToGCMsgRoutedReply\>, 
[IEquatable<CGCToGCMsgRoutedReply\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCToGCMsgRoutedReply\>, 
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
[EnumerableExtensions.In<CGCToGCMsgRoutedReply\>\(CGCToGCMsgRoutedReply, params CGCToGCMsgRoutedReply\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply__ctor"></a> CGCToGCMsgRoutedReply\(\)

```csharp
public CGCToGCMsgRoutedReply()
```

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply__ctor_Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_"></a> CGCToGCMsgRoutedReply\(CGCToGCMsgRoutedReply\)

```csharp
public CGCToGCMsgRoutedReply(CGCToGCMsgRoutedReply other)
```

#### Parameters

`other` [CGCToGCMsgRoutedReply](Divine.Protobufs.Dota2.CGCToGCMsgRoutedReply.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_MsgTypeFieldNumber"></a> MsgTypeFieldNumber

```csharp
public const int MsgTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_NetMessageFieldNumber"></a> NetMessageFieldNumber

```csharp
public const int NetMessageFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_HasMsgType"></a> HasMsgType

```csharp
public bool HasMsgType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_HasNetMessage"></a> HasNetMessage

```csharp
public bool HasNetMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_MsgType"></a> MsgType

```csharp
public uint MsgType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_NetMessage"></a> NetMessage

```csharp
public ByteString NetMessage { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_Parser"></a> Parser

```csharp
public static MessageParser<CGCToGCMsgRoutedReply> Parser { get; }
```

#### Property Value

 MessageParser<[CGCToGCMsgRoutedReply](Divine.Protobufs.Dota2.CGCToGCMsgRoutedReply.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_ClearMsgType"></a> ClearMsgType\(\)

```csharp
public void ClearMsgType()
```

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_ClearNetMessage"></a> ClearNetMessage\(\)

```csharp
public void ClearNetMessage()
```

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_Clone"></a> Clone\(\)

```csharp
public CGCToGCMsgRoutedReply Clone()
```

#### Returns

 [CGCToGCMsgRoutedReply](Divine.Protobufs.Dota2.CGCToGCMsgRoutedReply.md)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_Equals_Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_"></a> Equals\(CGCToGCMsgRoutedReply\)

```csharp
public bool Equals(CGCToGCMsgRoutedReply other)
```

#### Parameters

`other` [CGCToGCMsgRoutedReply](Divine.Protobufs.Dota2.CGCToGCMsgRoutedReply.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_MergeFrom_Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_"></a> MergeFrom\(CGCToGCMsgRoutedReply\)

```csharp
public void MergeFrom(CGCToGCMsgRoutedReply other)
```

#### Parameters

`other` [CGCToGCMsgRoutedReply](Divine.Protobufs.Dota2.CGCToGCMsgRoutedReply.md)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgRoutedReply_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

