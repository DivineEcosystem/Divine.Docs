# <a id="Divine_Protobufs_Dota2_CUserMessageColoredText"></a> Class CUserMessageColoredText

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageColoredText : IMessage<CUserMessageColoredText>, IEquatable<CUserMessageColoredText>, IDeepCloneable<CUserMessageColoredText>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageColoredText](Divine.Protobufs.Dota2.CUserMessageColoredText.md)

#### Implements

IMessage<CUserMessageColoredText\>, 
[IEquatable<CUserMessageColoredText\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageColoredText\>, 
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
[EnumerableExtensions.In<CUserMessageColoredText\>\(CUserMessageColoredText, params CUserMessageColoredText\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText__ctor"></a> CUserMessageColoredText\(\)

```csharp
public CUserMessageColoredText()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText__ctor_Divine_Protobufs_Dota2_CUserMessageColoredText_"></a> CUserMessageColoredText\(CUserMessageColoredText\)

```csharp
public CUserMessageColoredText(CUserMessageColoredText other)
```

#### Parameters

`other` [CUserMessageColoredText](Divine.Protobufs.Dota2.CUserMessageColoredText.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_ColorFieldNumber"></a> ColorFieldNumber

```csharp
public const int ColorFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_ContextPlayerSlotFieldNumber"></a> ContextPlayerSlotFieldNumber

```csharp
public const int ContextPlayerSlotFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_ContextTeamIdFieldNumber"></a> ContextTeamIdFieldNumber

```csharp
public const int ContextTeamIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_ContextValueFieldNumber"></a> ContextValueFieldNumber

```csharp
public const int ContextValueFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_ResetFieldNumber"></a> ResetFieldNumber

```csharp
public const int ResetFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_TextFieldNumber"></a> TextFieldNumber

```csharp
public const int TextFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_Color"></a> Color

```csharp
public uint Color { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_ContextPlayerSlot"></a> ContextPlayerSlot

```csharp
public int ContextPlayerSlot { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_ContextTeamId"></a> ContextTeamId

```csharp
public int ContextTeamId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_ContextValue"></a> ContextValue

```csharp
public int ContextValue { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_HasColor"></a> HasColor

```csharp
public bool HasColor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_HasContextPlayerSlot"></a> HasContextPlayerSlot

```csharp
public bool HasContextPlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_HasContextTeamId"></a> HasContextTeamId

```csharp
public bool HasContextTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_HasContextValue"></a> HasContextValue

```csharp
public bool HasContextValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_HasReset"></a> HasReset

```csharp
public bool HasReset { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_HasText"></a> HasText

```csharp
public bool HasText { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageColoredText> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageColoredText](Divine.Protobufs.Dota2.CUserMessageColoredText.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_Reset"></a> Reset

```csharp
public bool Reset { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_Text"></a> Text

```csharp
public string Text { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_ClearColor"></a> ClearColor\(\)

```csharp
public void ClearColor()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_ClearContextPlayerSlot"></a> ClearContextPlayerSlot\(\)

```csharp
public void ClearContextPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_ClearContextTeamId"></a> ClearContextTeamId\(\)

```csharp
public void ClearContextTeamId()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_ClearContextValue"></a> ClearContextValue\(\)

```csharp
public void ClearContextValue()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_ClearReset"></a> ClearReset\(\)

```csharp
public void ClearReset()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_ClearText"></a> ClearText\(\)

```csharp
public void ClearText()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_Clone"></a> Clone\(\)

```csharp
public CUserMessageColoredText Clone()
```

#### Returns

 [CUserMessageColoredText](Divine.Protobufs.Dota2.CUserMessageColoredText.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_Equals_Divine_Protobufs_Dota2_CUserMessageColoredText_"></a> Equals\(CUserMessageColoredText\)

```csharp
public bool Equals(CUserMessageColoredText other)
```

#### Parameters

`other` [CUserMessageColoredText](Divine.Protobufs.Dota2.CUserMessageColoredText.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_MergeFrom_Divine_Protobufs_Dota2_CUserMessageColoredText_"></a> MergeFrom\(CUserMessageColoredText\)

```csharp
public void MergeFrom(CUserMessageColoredText other)
```

#### Parameters

`other` [CUserMessageColoredText](Divine.Protobufs.Dota2.CUserMessageColoredText.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageColoredText_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

