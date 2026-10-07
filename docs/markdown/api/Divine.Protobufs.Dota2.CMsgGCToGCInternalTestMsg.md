# <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg"></a> Class CMsgGCToGCInternalTestMsg

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCInternalTestMsg : IMessage<CMsgGCToGCInternalTestMsg>, IEquatable<CMsgGCToGCInternalTestMsg>, IDeepCloneable<CMsgGCToGCInternalTestMsg>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCInternalTestMsg](Divine.Protobufs.Dota2.CMsgGCToGCInternalTestMsg.md)

#### Implements

IMessage<CMsgGCToGCInternalTestMsg\>, 
[IEquatable<CMsgGCToGCInternalTestMsg\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCInternalTestMsg\>, 
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
[EnumerableExtensions.In<CMsgGCToGCInternalTestMsg\>\(CMsgGCToGCInternalTestMsg, params CMsgGCToGCInternalTestMsg\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg__ctor"></a> CMsgGCToGCInternalTestMsg\(\)

```csharp
public CMsgGCToGCInternalTestMsg()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg__ctor_Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_"></a> CMsgGCToGCInternalTestMsg\(CMsgGCToGCInternalTestMsg\)

```csharp
public CMsgGCToGCInternalTestMsg(CMsgGCToGCInternalTestMsg other)
```

#### Parameters

`other` [CMsgGCToGCInternalTestMsg](Divine.Protobufs.Dota2.CMsgGCToGCInternalTestMsg.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_ContextFieldNumber"></a> ContextFieldNumber

```csharp
public const int ContextFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_JobIdSourceFieldNumber"></a> JobIdSourceFieldNumber

```csharp
public const int JobIdSourceFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_JobIdTargetFieldNumber"></a> JobIdTargetFieldNumber

```csharp
public const int JobIdTargetFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_MessageBodyFieldNumber"></a> MessageBodyFieldNumber

```csharp
public const int MessageBodyFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_MessageIdFieldNumber"></a> MessageIdFieldNumber

```csharp
public const int MessageIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_SenderIdFieldNumber"></a> SenderIdFieldNumber

```csharp
public const int SenderIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_SendingGcFieldNumber"></a> SendingGcFieldNumber

```csharp
public const int SendingGcFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_Context"></a> Context

```csharp
public uint Context { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_HasContext"></a> HasContext

```csharp
public bool HasContext { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_HasJobIdSource"></a> HasJobIdSource

```csharp
public bool HasJobIdSource { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_HasJobIdTarget"></a> HasJobIdTarget

```csharp
public bool HasJobIdTarget { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_HasMessageBody"></a> HasMessageBody

```csharp
public bool HasMessageBody { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_HasMessageId"></a> HasMessageId

```csharp
public bool HasMessageId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_HasSenderId"></a> HasSenderId

```csharp
public bool HasSenderId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_HasSendingGc"></a> HasSendingGc

```csharp
public bool HasSendingGc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_JobIdSource"></a> JobIdSource

```csharp
public ulong JobIdSource { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_JobIdTarget"></a> JobIdTarget

```csharp
public ulong JobIdTarget { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_MessageBody"></a> MessageBody

```csharp
public ByteString MessageBody { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_MessageId"></a> MessageId

```csharp
public uint MessageId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCInternalTestMsg> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCInternalTestMsg](Divine.Protobufs.Dota2.CMsgGCToGCInternalTestMsg.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_SenderId"></a> SenderId

```csharp
public ulong SenderId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_SendingGc"></a> SendingGc

```csharp
public int SendingGc { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_ClearContext"></a> ClearContext\(\)

```csharp
public void ClearContext()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_ClearJobIdSource"></a> ClearJobIdSource\(\)

```csharp
public void ClearJobIdSource()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_ClearJobIdTarget"></a> ClearJobIdTarget\(\)

```csharp
public void ClearJobIdTarget()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_ClearMessageBody"></a> ClearMessageBody\(\)

```csharp
public void ClearMessageBody()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_ClearMessageId"></a> ClearMessageId\(\)

```csharp
public void ClearMessageId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_ClearSenderId"></a> ClearSenderId\(\)

```csharp
public void ClearSenderId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_ClearSendingGc"></a> ClearSendingGc\(\)

```csharp
public void ClearSendingGc()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCInternalTestMsg Clone()
```

#### Returns

 [CMsgGCToGCInternalTestMsg](Divine.Protobufs.Dota2.CMsgGCToGCInternalTestMsg.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_Equals_Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_"></a> Equals\(CMsgGCToGCInternalTestMsg\)

```csharp
public bool Equals(CMsgGCToGCInternalTestMsg other)
```

#### Parameters

`other` [CMsgGCToGCInternalTestMsg](Divine.Protobufs.Dota2.CMsgGCToGCInternalTestMsg.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_"></a> MergeFrom\(CMsgGCToGCInternalTestMsg\)

```csharp
public void MergeFrom(CMsgGCToGCInternalTestMsg other)
```

#### Parameters

`other` [CMsgGCToGCInternalTestMsg](Divine.Protobufs.Dota2.CMsgGCToGCInternalTestMsg.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCInternalTestMsg_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

