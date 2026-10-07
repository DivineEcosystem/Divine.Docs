# <a id="Divine_Protobufs_Dota2_CUserMessageSayText"></a> Class CUserMessageSayText

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageSayText : IMessage<CUserMessageSayText>, IEquatable<CUserMessageSayText>, IDeepCloneable<CUserMessageSayText>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageSayText](Divine.Protobufs.Dota2.CUserMessageSayText.md)

#### Implements

IMessage<CUserMessageSayText\>, 
[IEquatable<CUserMessageSayText\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageSayText\>, 
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
[EnumerableExtensions.In<CUserMessageSayText\>\(CUserMessageSayText, params CUserMessageSayText\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText__ctor"></a> CUserMessageSayText\(\)

```csharp
public CUserMessageSayText()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText__ctor_Divine_Protobufs_Dota2_CUserMessageSayText_"></a> CUserMessageSayText\(CUserMessageSayText\)

```csharp
public CUserMessageSayText(CUserMessageSayText other)
```

#### Parameters

`other` [CUserMessageSayText](Divine.Protobufs.Dota2.CUserMessageSayText.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_ChatFieldNumber"></a> ChatFieldNumber

```csharp
public const int ChatFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_PlayerindexFieldNumber"></a> PlayerindexFieldNumber

```csharp
public const int PlayerindexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_TextallchatFieldNumber"></a> TextallchatFieldNumber

```csharp
public const int TextallchatFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_TextFieldNumber"></a> TextFieldNumber

```csharp
public const int TextFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_Chat"></a> Chat

```csharp
public bool Chat { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_HasChat"></a> HasChat

```csharp
public bool HasChat { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_HasPlayerindex"></a> HasPlayerindex

```csharp
public bool HasPlayerindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_HasText"></a> HasText

```csharp
public bool HasText { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_HasTextallchat"></a> HasTextallchat

```csharp
public bool HasTextallchat { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageSayText> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageSayText](Divine.Protobufs.Dota2.CUserMessageSayText.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_Playerindex"></a> Playerindex

```csharp
public int Playerindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_Text"></a> Text

```csharp
public string Text { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_Textallchat"></a> Textallchat

```csharp
public bool Textallchat { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_ClearChat"></a> ClearChat\(\)

```csharp
public void ClearChat()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_ClearPlayerindex"></a> ClearPlayerindex\(\)

```csharp
public void ClearPlayerindex()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_ClearText"></a> ClearText\(\)

```csharp
public void ClearText()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_ClearTextallchat"></a> ClearTextallchat\(\)

```csharp
public void ClearTextallchat()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_Clone"></a> Clone\(\)

```csharp
public CUserMessageSayText Clone()
```

#### Returns

 [CUserMessageSayText](Divine.Protobufs.Dota2.CUserMessageSayText.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_Equals_Divine_Protobufs_Dota2_CUserMessageSayText_"></a> Equals\(CUserMessageSayText\)

```csharp
public bool Equals(CUserMessageSayText other)
```

#### Parameters

`other` [CUserMessageSayText](Divine.Protobufs.Dota2.CUserMessageSayText.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_MergeFrom_Divine_Protobufs_Dota2_CUserMessageSayText_"></a> MergeFrom\(CUserMessageSayText\)

```csharp
public void MergeFrom(CUserMessageSayText other)
```

#### Parameters

`other` [CUserMessageSayText](Divine.Protobufs.Dota2.CUserMessageSayText.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

