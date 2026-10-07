# <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel"></a> Class CUserMessageSayTextChannel

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageSayTextChannel : IMessage<CUserMessageSayTextChannel>, IEquatable<CUserMessageSayTextChannel>, IDeepCloneable<CUserMessageSayTextChannel>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageSayTextChannel](Divine.Protobufs.Dota2.CUserMessageSayTextChannel.md)

#### Implements

IMessage<CUserMessageSayTextChannel\>, 
[IEquatable<CUserMessageSayTextChannel\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageSayTextChannel\>, 
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
[EnumerableExtensions.In<CUserMessageSayTextChannel\>\(CUserMessageSayTextChannel, params CUserMessageSayTextChannel\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel__ctor"></a> CUserMessageSayTextChannel\(\)

```csharp
public CUserMessageSayTextChannel()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel__ctor_Divine_Protobufs_Dota2_CUserMessageSayTextChannel_"></a> CUserMessageSayTextChannel\(CUserMessageSayTextChannel\)

```csharp
public CUserMessageSayTextChannel(CUserMessageSayTextChannel other)
```

#### Parameters

`other` [CUserMessageSayTextChannel](Divine.Protobufs.Dota2.CUserMessageSayTextChannel.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_ChannelFieldNumber"></a> ChannelFieldNumber

```csharp
public const int ChannelFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_PlayerFieldNumber"></a> PlayerFieldNumber

```csharp
public const int PlayerFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_TextFieldNumber"></a> TextFieldNumber

```csharp
public const int TextFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_Channel"></a> Channel

```csharp
public int Channel { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_HasChannel"></a> HasChannel

```csharp
public bool HasChannel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_HasPlayer"></a> HasPlayer

```csharp
public bool HasPlayer { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_HasText"></a> HasText

```csharp
public bool HasText { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageSayTextChannel> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageSayTextChannel](Divine.Protobufs.Dota2.CUserMessageSayTextChannel.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_Player"></a> Player

```csharp
public int Player { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_Text"></a> Text

```csharp
public string Text { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_ClearChannel"></a> ClearChannel\(\)

```csharp
public void ClearChannel()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_ClearPlayer"></a> ClearPlayer\(\)

```csharp
public void ClearPlayer()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_ClearText"></a> ClearText\(\)

```csharp
public void ClearText()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_Clone"></a> Clone\(\)

```csharp
public CUserMessageSayTextChannel Clone()
```

#### Returns

 [CUserMessageSayTextChannel](Divine.Protobufs.Dota2.CUserMessageSayTextChannel.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_Equals_Divine_Protobufs_Dota2_CUserMessageSayTextChannel_"></a> Equals\(CUserMessageSayTextChannel\)

```csharp
public bool Equals(CUserMessageSayTextChannel other)
```

#### Parameters

`other` [CUserMessageSayTextChannel](Divine.Protobufs.Dota2.CUserMessageSayTextChannel.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_MergeFrom_Divine_Protobufs_Dota2_CUserMessageSayTextChannel_"></a> MergeFrom\(CUserMessageSayTextChannel\)

```csharp
public void MergeFrom(CUserMessageSayTextChannel other)
```

#### Parameters

`other` [CUserMessageSayTextChannel](Divine.Protobufs.Dota2.CUserMessageSayTextChannel.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayTextChannel_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

