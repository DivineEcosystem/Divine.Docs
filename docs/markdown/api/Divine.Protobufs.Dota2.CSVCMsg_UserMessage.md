# <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage"></a> Class CSVCMsg\_UserMessage

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_UserMessage : IMessage<CSVCMsg_UserMessage>, IEquatable<CSVCMsg_UserMessage>, IDeepCloneable<CSVCMsg_UserMessage>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_UserMessage](Divine.Protobufs.Dota2.CSVCMsg\_UserMessage.md)

#### Implements

IMessage<CSVCMsg\_UserMessage\>, 
[IEquatable<CSVCMsg\_UserMessage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_UserMessage\>, 
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
[EnumerableExtensions.In<CSVCMsg\_UserMessage\>\(CSVCMsg\_UserMessage, params CSVCMsg\_UserMessage\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage__ctor"></a> CSVCMsg\_UserMessage\(\)

```csharp
public CSVCMsg_UserMessage()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage__ctor_Divine_Protobufs_Dota2_CSVCMsg_UserMessage_"></a> CSVCMsg\_UserMessage\(CSVCMsg\_UserMessage\)

```csharp
public CSVCMsg_UserMessage(CSVCMsg_UserMessage other)
```

#### Parameters

`other` [CSVCMsg\_UserMessage](Divine.Protobufs.Dota2.CSVCMsg\_UserMessage.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_MsgDataFieldNumber"></a> MsgDataFieldNumber

```csharp
public const int MsgDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_MsgTypeFieldNumber"></a> MsgTypeFieldNumber

```csharp
public const int MsgTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_PassthroughFieldNumber"></a> PassthroughFieldNumber

```csharp
public const int PassthroughFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_HasMsgData"></a> HasMsgData

```csharp
public bool HasMsgData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_HasMsgType"></a> HasMsgType

```csharp
public bool HasMsgType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_HasPassthrough"></a> HasPassthrough

```csharp
public bool HasPassthrough { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_MsgData"></a> MsgData

```csharp
public ByteString MsgData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_MsgType"></a> MsgType

```csharp
public int MsgType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_UserMessage> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_UserMessage](Divine.Protobufs.Dota2.CSVCMsg\_UserMessage.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_Passthrough"></a> Passthrough

```csharp
public int Passthrough { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_ClearMsgData"></a> ClearMsgData\(\)

```csharp
public void ClearMsgData()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_ClearMsgType"></a> ClearMsgType\(\)

```csharp
public void ClearMsgType()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_ClearPassthrough"></a> ClearPassthrough\(\)

```csharp
public void ClearPassthrough()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_UserMessage Clone()
```

#### Returns

 [CSVCMsg\_UserMessage](Divine.Protobufs.Dota2.CSVCMsg\_UserMessage.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_Equals_Divine_Protobufs_Dota2_CSVCMsg_UserMessage_"></a> Equals\(CSVCMsg\_UserMessage\)

```csharp
public bool Equals(CSVCMsg_UserMessage other)
```

#### Parameters

`other` [CSVCMsg\_UserMessage](Divine.Protobufs.Dota2.CSVCMsg\_UserMessage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_UserMessage_"></a> MergeFrom\(CSVCMsg\_UserMessage\)

```csharp
public void MergeFrom(CSVCMsg_UserMessage other)
```

#### Parameters

`other` [CSVCMsg\_UserMessage](Divine.Protobufs.Dota2.CSVCMsg\_UserMessage.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserMessage_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

