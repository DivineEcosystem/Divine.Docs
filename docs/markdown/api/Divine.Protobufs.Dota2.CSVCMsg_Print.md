# <a id="Divine_Protobufs_Dota2_CSVCMsg_Print"></a> Class CSVCMsg\_Print

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_Print : IMessage<CSVCMsg_Print>, IEquatable<CSVCMsg_Print>, IDeepCloneable<CSVCMsg_Print>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_Print](Divine.Protobufs.Dota2.CSVCMsg\_Print.md)

#### Implements

IMessage<CSVCMsg\_Print\>, 
[IEquatable<CSVCMsg\_Print\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_Print\>, 
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
[EnumerableExtensions.In<CSVCMsg\_Print\>\(CSVCMsg\_Print, params CSVCMsg\_Print\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Print__ctor"></a> CSVCMsg\_Print\(\)

```csharp
public CSVCMsg_Print()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Print__ctor_Divine_Protobufs_Dota2_CSVCMsg_Print_"></a> CSVCMsg\_Print\(CSVCMsg\_Print\)

```csharp
public CSVCMsg_Print(CSVCMsg_Print other)
```

#### Parameters

`other` [CSVCMsg\_Print](Divine.Protobufs.Dota2.CSVCMsg\_Print.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Print_TextFieldNumber"></a> TextFieldNumber

```csharp
public const int TextFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Print_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Print_HasText"></a> HasText

```csharp
public bool HasText { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Print_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_Print> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_Print](Divine.Protobufs.Dota2.CSVCMsg\_Print.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Print_Text"></a> Text

```csharp
public string Text { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Print_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Print_ClearText"></a> ClearText\(\)

```csharp
public void ClearText()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Print_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_Print Clone()
```

#### Returns

 [CSVCMsg\_Print](Divine.Protobufs.Dota2.CSVCMsg\_Print.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Print_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Print_Equals_Divine_Protobufs_Dota2_CSVCMsg_Print_"></a> Equals\(CSVCMsg\_Print\)

```csharp
public bool Equals(CSVCMsg_Print other)
```

#### Parameters

`other` [CSVCMsg\_Print](Divine.Protobufs.Dota2.CSVCMsg\_Print.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Print_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Print_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_Print_"></a> MergeFrom\(CSVCMsg\_Print\)

```csharp
public void MergeFrom(CSVCMsg_Print other)
```

#### Parameters

`other` [CSVCMsg\_Print](Divine.Protobufs.Dota2.CSVCMsg\_Print.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Print_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Print_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Print_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

