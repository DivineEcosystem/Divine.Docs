# <a id="Divine_Protobufs_Dota2_CUIFontFilePB"></a> Class CUIFontFilePB

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUIFontFilePB : IMessage<CUIFontFilePB>, IEquatable<CUIFontFilePB>, IDeepCloneable<CUIFontFilePB>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUIFontFilePB](Divine.Protobufs.Dota2.CUIFontFilePB.md)

#### Implements

IMessage<CUIFontFilePB\>, 
[IEquatable<CUIFontFilePB\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUIFontFilePB\>, 
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
[EnumerableExtensions.In<CUIFontFilePB\>\(CUIFontFilePB, params CUIFontFilePB\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB__ctor"></a> CUIFontFilePB\(\)

```csharp
public CUIFontFilePB()
```

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB__ctor_Divine_Protobufs_Dota2_CUIFontFilePB_"></a> CUIFontFilePB\(CUIFontFilePB\)

```csharp
public CUIFontFilePB(CUIFontFilePB other)
```

#### Parameters

`other` [CUIFontFilePB](Divine.Protobufs.Dota2.CUIFontFilePB.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB_FontFileNameFieldNumber"></a> FontFileNameFieldNumber

```csharp
public const int FontFileNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB_OpentypeFontDataFieldNumber"></a> OpentypeFontDataFieldNumber

```csharp
public const int OpentypeFontDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB_FontFileName"></a> FontFileName

```csharp
public string FontFileName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB_HasFontFileName"></a> HasFontFileName

```csharp
public bool HasFontFileName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB_HasOpentypeFontData"></a> HasOpentypeFontData

```csharp
public bool HasOpentypeFontData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB_OpentypeFontData"></a> OpentypeFontData

```csharp
public ByteString OpentypeFontData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB_Parser"></a> Parser

```csharp
public static MessageParser<CUIFontFilePB> Parser { get; }
```

#### Property Value

 MessageParser<[CUIFontFilePB](Divine.Protobufs.Dota2.CUIFontFilePB.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB_ClearFontFileName"></a> ClearFontFileName\(\)

```csharp
public void ClearFontFileName()
```

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB_ClearOpentypeFontData"></a> ClearOpentypeFontData\(\)

```csharp
public void ClearOpentypeFontData()
```

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB_Clone"></a> Clone\(\)

```csharp
public CUIFontFilePB Clone()
```

#### Returns

 [CUIFontFilePB](Divine.Protobufs.Dota2.CUIFontFilePB.md)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB_Equals_Divine_Protobufs_Dota2_CUIFontFilePB_"></a> Equals\(CUIFontFilePB\)

```csharp
public bool Equals(CUIFontFilePB other)
```

#### Parameters

`other` [CUIFontFilePB](Divine.Protobufs.Dota2.CUIFontFilePB.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB_MergeFrom_Divine_Protobufs_Dota2_CUIFontFilePB_"></a> MergeFrom\(CUIFontFilePB\)

```csharp
public void MergeFrom(CUIFontFilePB other)
```

#### Parameters

`other` [CUIFontFilePB](Divine.Protobufs.Dota2.CUIFontFilePB.md)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePB_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

