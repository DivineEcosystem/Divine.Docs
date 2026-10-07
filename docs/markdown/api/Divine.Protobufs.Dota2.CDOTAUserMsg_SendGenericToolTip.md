# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip"></a> Class CDOTAUserMsg\_SendGenericToolTip

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_SendGenericToolTip : IMessage<CDOTAUserMsg_SendGenericToolTip>, IEquatable<CDOTAUserMsg_SendGenericToolTip>, IDeepCloneable<CDOTAUserMsg_SendGenericToolTip>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_SendGenericToolTip](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendGenericToolTip.md)

#### Implements

IMessage<CDOTAUserMsg\_SendGenericToolTip\>, 
[IEquatable<CDOTAUserMsg\_SendGenericToolTip\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_SendGenericToolTip\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_SendGenericToolTip\>\(CDOTAUserMsg\_SendGenericToolTip, params CDOTAUserMsg\_SendGenericToolTip\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip__ctor"></a> CDOTAUserMsg\_SendGenericToolTip\(\)

```csharp
public CDOTAUserMsg_SendGenericToolTip()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_"></a> CDOTAUserMsg\_SendGenericToolTip\(CDOTAUserMsg\_SendGenericToolTip\)

```csharp
public CDOTAUserMsg_SendGenericToolTip(CDOTAUserMsg_SendGenericToolTip other)
```

#### Parameters

`other` [CDOTAUserMsg\_SendGenericToolTip](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendGenericToolTip.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_CloseFieldNumber"></a> CloseFieldNumber

```csharp
public const int CloseFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_EntindexFieldNumber"></a> EntindexFieldNumber

```csharp
public const int EntindexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_TextFieldNumber"></a> TextFieldNumber

```csharp
public const int TextFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_TitleFieldNumber"></a> TitleFieldNumber

```csharp
public const int TitleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_Close"></a> Close

```csharp
public bool Close { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_Entindex"></a> Entindex

```csharp
public int Entindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_HasClose"></a> HasClose

```csharp
public bool HasClose { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_HasEntindex"></a> HasEntindex

```csharp
public bool HasEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_HasText"></a> HasText

```csharp
public bool HasText { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_HasTitle"></a> HasTitle

```csharp
public bool HasTitle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_SendGenericToolTip> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_SendGenericToolTip](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendGenericToolTip.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_Text"></a> Text

```csharp
public string Text { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_Title"></a> Title

```csharp
public string Title { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_ClearClose"></a> ClearClose\(\)

```csharp
public void ClearClose()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_ClearEntindex"></a> ClearEntindex\(\)

```csharp
public void ClearEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_ClearText"></a> ClearText\(\)

```csharp
public void ClearText()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_ClearTitle"></a> ClearTitle\(\)

```csharp
public void ClearTitle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_SendGenericToolTip Clone()
```

#### Returns

 [CDOTAUserMsg\_SendGenericToolTip](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendGenericToolTip.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_"></a> Equals\(CDOTAUserMsg\_SendGenericToolTip\)

```csharp
public bool Equals(CDOTAUserMsg_SendGenericToolTip other)
```

#### Parameters

`other` [CDOTAUserMsg\_SendGenericToolTip](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendGenericToolTip.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_"></a> MergeFrom\(CDOTAUserMsg\_SendGenericToolTip\)

```csharp
public void MergeFrom(CDOTAUserMsg_SendGenericToolTip other)
```

#### Parameters

`other` [CDOTAUserMsg\_SendGenericToolTip](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendGenericToolTip.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendGenericToolTip_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

