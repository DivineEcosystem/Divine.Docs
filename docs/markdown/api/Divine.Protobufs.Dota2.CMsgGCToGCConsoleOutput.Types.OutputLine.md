# <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine"></a> Class CMsgGCToGCConsoleOutput.Types.OutputLine

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCConsoleOutput.Types.OutputLine : IMessage<CMsgGCToGCConsoleOutput.Types.OutputLine>, IEquatable<CMsgGCToGCConsoleOutput.Types.OutputLine>, IDeepCloneable<CMsgGCToGCConsoleOutput.Types.OutputLine>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCConsoleOutput.Types.OutputLine](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.Types.OutputLine.md)

#### Implements

IMessage<CMsgGCToGCConsoleOutput.Types.OutputLine\>, 
[IEquatable<CMsgGCToGCConsoleOutput.Types.OutputLine\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCConsoleOutput.Types.OutputLine\>, 
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
[EnumerableExtensions.In<CMsgGCToGCConsoleOutput.Types.OutputLine\>\(CMsgGCToGCConsoleOutput.Types.OutputLine, params CMsgGCToGCConsoleOutput.Types.OutputLine\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine__ctor"></a> OutputLine\(\)

```csharp
public OutputLine()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine__ctor_Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_"></a> OutputLine\(OutputLine\)

```csharp
public OutputLine(CMsgGCToGCConsoleOutput.Types.OutputLine other)
```

#### Parameters

`other` [CMsgGCToGCConsoleOutput](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.Types.md).[OutputLine](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.Types.OutputLine.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_SpewLevelFieldNumber"></a> SpewLevelFieldNumber

```csharp
public const int SpewLevelFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_TextFieldNumber"></a> TextFieldNumber

```csharp
public const int TextFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_HasSpewLevel"></a> HasSpewLevel

```csharp
public bool HasSpewLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_HasText"></a> HasText

```csharp
public bool HasText { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCConsoleOutput.Types.OutputLine> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCConsoleOutput](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.Types.md).[OutputLine](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.Types.OutputLine.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_SpewLevel"></a> SpewLevel

```csharp
public uint SpewLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_Text"></a> Text

```csharp
public string Text { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_ClearSpewLevel"></a> ClearSpewLevel\(\)

```csharp
public void ClearSpewLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_ClearText"></a> ClearText\(\)

```csharp
public void ClearText()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCConsoleOutput.Types.OutputLine Clone()
```

#### Returns

 [CMsgGCToGCConsoleOutput](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.Types.md).[OutputLine](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.Types.OutputLine.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_Equals_Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_"></a> Equals\(OutputLine\)

```csharp
public bool Equals(CMsgGCToGCConsoleOutput.Types.OutputLine other)
```

#### Parameters

`other` [CMsgGCToGCConsoleOutput](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.Types.md).[OutputLine](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.Types.OutputLine.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_"></a> MergeFrom\(OutputLine\)

```csharp
public void MergeFrom(CMsgGCToGCConsoleOutput.Types.OutputLine other)
```

#### Parameters

`other` [CMsgGCToGCConsoleOutput](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.Types.md).[OutputLine](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.Types.OutputLine.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Types_OutputLine_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

