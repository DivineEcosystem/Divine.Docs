# <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message"></a> Class CMsgDOTALeagueMessages.Types.Message

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeagueMessages.Types.Message : IMessage<CMsgDOTALeagueMessages.Types.Message>, IEquatable<CMsgDOTALeagueMessages.Types.Message>, IDeepCloneable<CMsgDOTALeagueMessages.Types.Message>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeagueMessages.Types.Message](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.Types.Message.md)

#### Implements

IMessage<CMsgDOTALeagueMessages.Types.Message\>, 
[IEquatable<CMsgDOTALeagueMessages.Types.Message\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeagueMessages.Types.Message\>, 
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
[EnumerableExtensions.In<CMsgDOTALeagueMessages.Types.Message\>\(CMsgDOTALeagueMessages.Types.Message, params CMsgDOTALeagueMessages.Types.Message\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message__ctor"></a> Message\(\)

```csharp
public Message()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message__ctor_Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_"></a> Message\(Message\)

```csharp
public Message(CMsgDOTALeagueMessages.Types.Message other)
```

#### Parameters

`other` [CMsgDOTALeagueMessages](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.Types.md).[Message](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.Types.Message.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_AuthorAccountIdFieldNumber"></a> AuthorAccountIdFieldNumber

```csharp
public const int AuthorAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_Message_FieldNumber"></a> Message\_FieldNumber

```csharp
public const int Message_FieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_AuthorAccountId"></a> AuthorAccountId

```csharp
public uint AuthorAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_HasAuthorAccountId"></a> HasAuthorAccountId

```csharp
public bool HasAuthorAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_HasMessage_"></a> HasMessage\_

```csharp
public bool HasMessage_ { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_Message_"></a> Message\_

```csharp
public string Message_ { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeagueMessages.Types.Message> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeagueMessages](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.Types.md).[Message](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.Types.Message.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_ClearAuthorAccountId"></a> ClearAuthorAccountId\(\)

```csharp
public void ClearAuthorAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_ClearMessage_"></a> ClearMessage\_\(\)

```csharp
public void ClearMessage_()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeagueMessages.Types.Message Clone()
```

#### Returns

 [CMsgDOTALeagueMessages](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.Types.md).[Message](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.Types.Message.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_Equals_Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_"></a> Equals\(Message\)

```csharp
public bool Equals(CMsgDOTALeagueMessages.Types.Message other)
```

#### Parameters

`other` [CMsgDOTALeagueMessages](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.Types.md).[Message](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.Types.Message.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_"></a> MergeFrom\(Message\)

```csharp
public void MergeFrom(CMsgDOTALeagueMessages.Types.Message other)
```

#### Parameters

`other` [CMsgDOTALeagueMessages](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.Types.md).[Message](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.Types.Message.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Types_Message_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

