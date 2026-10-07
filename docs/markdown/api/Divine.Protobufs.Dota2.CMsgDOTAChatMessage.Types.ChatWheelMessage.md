# <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage"></a> Class CMsgDOTAChatMessage.Types.ChatWheelMessage

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAChatMessage.Types.ChatWheelMessage : IMessage<CMsgDOTAChatMessage.Types.ChatWheelMessage>, IEquatable<CMsgDOTAChatMessage.Types.ChatWheelMessage>, IDeepCloneable<CMsgDOTAChatMessage.Types.ChatWheelMessage>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAChatMessage.Types.ChatWheelMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.ChatWheelMessage.md)

#### Implements

IMessage<CMsgDOTAChatMessage.Types.ChatWheelMessage\>, 
[IEquatable<CMsgDOTAChatMessage.Types.ChatWheelMessage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAChatMessage.Types.ChatWheelMessage\>, 
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
[EnumerableExtensions.In<CMsgDOTAChatMessage.Types.ChatWheelMessage\>\(CMsgDOTAChatMessage.Types.ChatWheelMessage, params CMsgDOTAChatMessage.Types.ChatWheelMessage\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage__ctor"></a> ChatWheelMessage\(\)

```csharp
public ChatWheelMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage__ctor_Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_"></a> ChatWheelMessage\(ChatWheelMessage\)

```csharp
public ChatWheelMessage(CMsgDOTAChatMessage.Types.ChatWheelMessage other)
```

#### Parameters

`other` [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[ChatWheelMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.ChatWheelMessage.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_EmoticonIdFieldNumber"></a> EmoticonIdFieldNumber

```csharp
public const int EmoticonIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_HeroBadgeTierFieldNumber"></a> HeroBadgeTierFieldNumber

```csharp
public const int HeroBadgeTierFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_MessageIdFieldNumber"></a> MessageIdFieldNumber

```csharp
public const int MessageIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_MessageTextFieldNumber"></a> MessageTextFieldNumber

```csharp
public const int MessageTextFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_EmoticonId"></a> EmoticonId

```csharp
public uint EmoticonId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_HasEmoticonId"></a> HasEmoticonId

```csharp
public bool HasEmoticonId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_HasHeroBadgeTier"></a> HasHeroBadgeTier

```csharp
public bool HasHeroBadgeTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_HasMessageId"></a> HasMessageId

```csharp
public bool HasMessageId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_HasMessageText"></a> HasMessageText

```csharp
public bool HasMessageText { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_HeroBadgeTier"></a> HeroBadgeTier

```csharp
public uint HeroBadgeTier { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_MessageId"></a> MessageId

```csharp
public uint MessageId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_MessageText"></a> MessageText

```csharp
public string MessageText { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAChatMessage.Types.ChatWheelMessage> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[ChatWheelMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.ChatWheelMessage.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_ClearEmoticonId"></a> ClearEmoticonId\(\)

```csharp
public void ClearEmoticonId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_ClearHeroBadgeTier"></a> ClearHeroBadgeTier\(\)

```csharp
public void ClearHeroBadgeTier()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_ClearMessageId"></a> ClearMessageId\(\)

```csharp
public void ClearMessageId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_ClearMessageText"></a> ClearMessageText\(\)

```csharp
public void ClearMessageText()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAChatMessage.Types.ChatWheelMessage Clone()
```

#### Returns

 [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[ChatWheelMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.ChatWheelMessage.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_Equals_Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_"></a> Equals\(ChatWheelMessage\)

```csharp
public bool Equals(CMsgDOTAChatMessage.Types.ChatWheelMessage other)
```

#### Parameters

`other` [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[ChatWheelMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.ChatWheelMessage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_"></a> MergeFrom\(ChatWheelMessage\)

```csharp
public void MergeFrom(CMsgDOTAChatMessage.Types.ChatWheelMessage other)
```

#### Parameters

`other` [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[ChatWheelMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.ChatWheelMessage.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_ChatWheelMessage_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

