# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage"></a> Class CDOTAUserMsg\_ChatMessage

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_ChatMessage : IMessage<CDOTAUserMsg_ChatMessage>, IEquatable<CDOTAUserMsg_ChatMessage>, IDeepCloneable<CDOTAUserMsg_ChatMessage>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_ChatMessage](Divine.Protobufs.Dota2.CDOTAUserMsg\_ChatMessage.md)

#### Implements

IMessage<CDOTAUserMsg\_ChatMessage\>, 
[IEquatable<CDOTAUserMsg\_ChatMessage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_ChatMessage\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_ChatMessage\>\(CDOTAUserMsg\_ChatMessage, params CDOTAUserMsg\_ChatMessage\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage__ctor"></a> CDOTAUserMsg\_ChatMessage\(\)

```csharp
public CDOTAUserMsg_ChatMessage()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_"></a> CDOTAUserMsg\_ChatMessage\(CDOTAUserMsg\_ChatMessage\)

```csharp
public CDOTAUserMsg_ChatMessage(CDOTAUserMsg_ChatMessage other)
```

#### Parameters

`other` [CDOTAUserMsg\_ChatMessage](Divine.Protobufs.Dota2.CDOTAUserMsg\_ChatMessage.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_ChannelTypeFieldNumber"></a> ChannelTypeFieldNumber

```csharp
public const int ChannelTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_MessageTextFieldNumber"></a> MessageTextFieldNumber

```csharp
public const int MessageTextFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_SourcePlayerIdFieldNumber"></a> SourcePlayerIdFieldNumber

```csharp
public const int SourcePlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_ChannelType"></a> ChannelType

```csharp
public uint ChannelType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_HasChannelType"></a> HasChannelType

```csharp
public bool HasChannelType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_HasMessageText"></a> HasMessageText

```csharp
public bool HasMessageText { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_HasSourcePlayerId"></a> HasSourcePlayerId

```csharp
public bool HasSourcePlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_MessageText"></a> MessageText

```csharp
public string MessageText { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_ChatMessage> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_ChatMessage](Divine.Protobufs.Dota2.CDOTAUserMsg\_ChatMessage.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_SourcePlayerId"></a> SourcePlayerId

```csharp
public int SourcePlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_ClearChannelType"></a> ClearChannelType\(\)

```csharp
public void ClearChannelType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_ClearMessageText"></a> ClearMessageText\(\)

```csharp
public void ClearMessageText()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_ClearSourcePlayerId"></a> ClearSourcePlayerId\(\)

```csharp
public void ClearSourcePlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_ChatMessage Clone()
```

#### Returns

 [CDOTAUserMsg\_ChatMessage](Divine.Protobufs.Dota2.CDOTAUserMsg\_ChatMessage.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_"></a> Equals\(CDOTAUserMsg\_ChatMessage\)

```csharp
public bool Equals(CDOTAUserMsg_ChatMessage other)
```

#### Parameters

`other` [CDOTAUserMsg\_ChatMessage](Divine.Protobufs.Dota2.CDOTAUserMsg\_ChatMessage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_"></a> MergeFrom\(CDOTAUserMsg\_ChatMessage\)

```csharp
public void MergeFrom(CDOTAUserMsg_ChatMessage other)
```

#### Parameters

`other` [CDOTAUserMsg\_ChatMessage](Divine.Protobufs.Dota2.CDOTAUserMsg\_ChatMessage.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatMessage_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

