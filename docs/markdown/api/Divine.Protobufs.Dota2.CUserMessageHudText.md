# <a id="Divine_Protobufs_Dota2_CUserMessageHudText"></a> Class CUserMessageHudText

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageHudText : IMessage<CUserMessageHudText>, IEquatable<CUserMessageHudText>, IDeepCloneable<CUserMessageHudText>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageHudText](Divine.Protobufs.Dota2.CUserMessageHudText.md)

#### Implements

IMessage<CUserMessageHudText\>, 
[IEquatable<CUserMessageHudText\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageHudText\>, 
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
[EnumerableExtensions.In<CUserMessageHudText\>\(CUserMessageHudText, params CUserMessageHudText\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageHudText__ctor"></a> CUserMessageHudText\(\)

```csharp
public CUserMessageHudText()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageHudText__ctor_Divine_Protobufs_Dota2_CUserMessageHudText_"></a> CUserMessageHudText\(CUserMessageHudText\)

```csharp
public CUserMessageHudText(CUserMessageHudText other)
```

#### Parameters

`other` [CUserMessageHudText](Divine.Protobufs.Dota2.CUserMessageHudText.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageHudText_MessageFieldNumber"></a> MessageFieldNumber

```csharp
public const int MessageFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageHudText_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageHudText_HasMessage"></a> HasMessage

```csharp
public bool HasMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudText_Message"></a> Message

```csharp
public string Message { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudText_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageHudText> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageHudText](Divine.Protobufs.Dota2.CUserMessageHudText.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageHudText_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudText_ClearMessage"></a> ClearMessage\(\)

```csharp
public void ClearMessage()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageHudText_Clone"></a> Clone\(\)

```csharp
public CUserMessageHudText Clone()
```

#### Returns

 [CUserMessageHudText](Divine.Protobufs.Dota2.CUserMessageHudText.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudText_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudText_Equals_Divine_Protobufs_Dota2_CUserMessageHudText_"></a> Equals\(CUserMessageHudText\)

```csharp
public bool Equals(CUserMessageHudText other)
```

#### Parameters

`other` [CUserMessageHudText](Divine.Protobufs.Dota2.CUserMessageHudText.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudText_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudText_MergeFrom_Divine_Protobufs_Dota2_CUserMessageHudText_"></a> MergeFrom\(CUserMessageHudText\)

```csharp
public void MergeFrom(CUserMessageHudText other)
```

#### Parameters

`other` [CUserMessageHudText](Divine.Protobufs.Dota2.CUserMessageHudText.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudText_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageHudText_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudText_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

