# <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage"></a> Class CMsgSignOutTextMuteInfo.Types.TextMuteMessage

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutTextMuteInfo.Types.TextMuteMessage : IMessage<CMsgSignOutTextMuteInfo.Types.TextMuteMessage>, IEquatable<CMsgSignOutTextMuteInfo.Types.TextMuteMessage>, IDeepCloneable<CMsgSignOutTextMuteInfo.Types.TextMuteMessage>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutTextMuteInfo.Types.TextMuteMessage](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.Types.TextMuteMessage.md)

#### Implements

IMessage<CMsgSignOutTextMuteInfo.Types.TextMuteMessage\>, 
[IEquatable<CMsgSignOutTextMuteInfo.Types.TextMuteMessage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutTextMuteInfo.Types.TextMuteMessage\>, 
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
[EnumerableExtensions.In<CMsgSignOutTextMuteInfo.Types.TextMuteMessage\>\(CMsgSignOutTextMuteInfo.Types.TextMuteMessage, params CMsgSignOutTextMuteInfo.Types.TextMuteMessage\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage__ctor"></a> TextMuteMessage\(\)

```csharp
public TextMuteMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage__ctor_Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_"></a> TextMuteMessage\(TextMuteMessage\)

```csharp
public TextMuteMessage(CMsgSignOutTextMuteInfo.Types.TextMuteMessage other)
```

#### Parameters

`other` [CMsgSignOutTextMuteInfo](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.Types.md).[TextMuteMessage](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.Types.TextMuteMessage.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_CausedTextMuteFieldNumber"></a> CausedTextMuteFieldNumber

```csharp
public const int CausedTextMuteFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_ChatMessageFieldNumber"></a> ChatMessageFieldNumber

```csharp
public const int ChatMessageFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_RegionFieldNumber"></a> RegionFieldNumber

```csharp
public const int RegionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_CausedTextMute"></a> CausedTextMute

```csharp
public bool CausedTextMute { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_ChatMessage"></a> ChatMessage

```csharp
public string ChatMessage { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_HasCausedTextMute"></a> HasCausedTextMute

```csharp
public bool HasCausedTextMute { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_HasChatMessage"></a> HasChatMessage

```csharp
public bool HasChatMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_HasRegion"></a> HasRegion

```csharp
public bool HasRegion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutTextMuteInfo.Types.TextMuteMessage> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutTextMuteInfo](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.Types.md).[TextMuteMessage](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.Types.TextMuteMessage.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_Region"></a> Region

```csharp
public uint Region { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_ClearCausedTextMute"></a> ClearCausedTextMute\(\)

```csharp
public void ClearCausedTextMute()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_ClearChatMessage"></a> ClearChatMessage\(\)

```csharp
public void ClearChatMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_ClearRegion"></a> ClearRegion\(\)

```csharp
public void ClearRegion()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutTextMuteInfo.Types.TextMuteMessage Clone()
```

#### Returns

 [CMsgSignOutTextMuteInfo](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.Types.md).[TextMuteMessage](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.Types.TextMuteMessage.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_Equals_Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_"></a> Equals\(TextMuteMessage\)

```csharp
public bool Equals(CMsgSignOutTextMuteInfo.Types.TextMuteMessage other)
```

#### Parameters

`other` [CMsgSignOutTextMuteInfo](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.Types.md).[TextMuteMessage](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.Types.TextMuteMessage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_"></a> MergeFrom\(TextMuteMessage\)

```csharp
public void MergeFrom(CMsgSignOutTextMuteInfo.Types.TextMuteMessage other)
```

#### Parameters

`other` [CMsgSignOutTextMuteInfo](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.Types.md).[TextMuteMessage](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.Types.TextMuteMessage.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Types_TextMuteMessage_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

