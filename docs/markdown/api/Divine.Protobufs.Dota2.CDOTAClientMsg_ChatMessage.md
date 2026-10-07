# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage"></a> Class CDOTAClientMsg\_ChatMessage

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_ChatMessage : IMessage<CDOTAClientMsg_ChatMessage>, IEquatable<CDOTAClientMsg_ChatMessage>, IDeepCloneable<CDOTAClientMsg_ChatMessage>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_ChatMessage](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChatMessage.md)

#### Implements

IMessage<CDOTAClientMsg\_ChatMessage\>, 
[IEquatable<CDOTAClientMsg\_ChatMessage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_ChatMessage\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_ChatMessage\>\(CDOTAClientMsg\_ChatMessage, params CDOTAClientMsg\_ChatMessage\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage__ctor"></a> CDOTAClientMsg\_ChatMessage\(\)

```csharp
public CDOTAClientMsg_ChatMessage()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_"></a> CDOTAClientMsg\_ChatMessage\(CDOTAClientMsg\_ChatMessage\)

```csharp
public CDOTAClientMsg_ChatMessage(CDOTAClientMsg_ChatMessage other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChatMessage](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChatMessage.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_ChannelTypeFieldNumber"></a> ChannelTypeFieldNumber

```csharp
public const int ChannelTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_MessageTextFieldNumber"></a> MessageTextFieldNumber

```csharp
public const int MessageTextFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_ChannelType"></a> ChannelType

```csharp
public uint ChannelType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_HasChannelType"></a> HasChannelType

```csharp
public bool HasChannelType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_HasMessageText"></a> HasMessageText

```csharp
public bool HasMessageText { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_MessageText"></a> MessageText

```csharp
public string MessageText { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_ChatMessage> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_ChatMessage](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChatMessage.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_ClearChannelType"></a> ClearChannelType\(\)

```csharp
public void ClearChannelType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_ClearMessageText"></a> ClearMessageText\(\)

```csharp
public void ClearMessageText()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_ChatMessage Clone()
```

#### Returns

 [CDOTAClientMsg\_ChatMessage](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChatMessage.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_"></a> Equals\(CDOTAClientMsg\_ChatMessage\)

```csharp
public bool Equals(CDOTAClientMsg_ChatMessage other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChatMessage](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChatMessage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_"></a> MergeFrom\(CDOTAClientMsg\_ChatMessage\)

```csharp
public void MergeFrom(CDOTAClientMsg_ChatMessage other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChatMessage](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChatMessage.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChatMessage_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

