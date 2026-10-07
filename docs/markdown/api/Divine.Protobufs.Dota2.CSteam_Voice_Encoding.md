# <a id="Divine_Protobufs_Dota2_CSteam_Voice_Encoding"></a> Class CSteam\_Voice\_Encoding

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSteam_Voice_Encoding : IMessage<CSteam_Voice_Encoding>, IEquatable<CSteam_Voice_Encoding>, IDeepCloneable<CSteam_Voice_Encoding>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSteam\_Voice\_Encoding](Divine.Protobufs.Dota2.CSteam\_Voice\_Encoding.md)

#### Implements

IMessage<CSteam\_Voice\_Encoding\>, 
[IEquatable<CSteam\_Voice\_Encoding\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSteam\_Voice\_Encoding\>, 
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
[EnumerableExtensions.In<CSteam\_Voice\_Encoding\>\(CSteam\_Voice\_Encoding, params CSteam\_Voice\_Encoding\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSteam_Voice_Encoding__ctor"></a> CSteam\_Voice\_Encoding\(\)

```csharp
public CSteam_Voice_Encoding()
```

### <a id="Divine_Protobufs_Dota2_CSteam_Voice_Encoding__ctor_Divine_Protobufs_Dota2_CSteam_Voice_Encoding_"></a> CSteam\_Voice\_Encoding\(CSteam\_Voice\_Encoding\)

```csharp
public CSteam_Voice_Encoding(CSteam_Voice_Encoding other)
```

#### Parameters

`other` [CSteam\_Voice\_Encoding](Divine.Protobufs.Dota2.CSteam\_Voice\_Encoding.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSteam_Voice_Encoding_VoiceDataFieldNumber"></a> VoiceDataFieldNumber

```csharp
public const int VoiceDataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSteam_Voice_Encoding_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSteam_Voice_Encoding_HasVoiceData"></a> HasVoiceData

```csharp
public bool HasVoiceData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSteam_Voice_Encoding_Parser"></a> Parser

```csharp
public static MessageParser<CSteam_Voice_Encoding> Parser { get; }
```

#### Property Value

 MessageParser<[CSteam\_Voice\_Encoding](Divine.Protobufs.Dota2.CSteam\_Voice\_Encoding.md)\>

### <a id="Divine_Protobufs_Dota2_CSteam_Voice_Encoding_VoiceData"></a> VoiceData

```csharp
public ByteString VoiceData { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Dota2_CSteam_Voice_Encoding_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSteam_Voice_Encoding_ClearVoiceData"></a> ClearVoiceData\(\)

```csharp
public void ClearVoiceData()
```

### <a id="Divine_Protobufs_Dota2_CSteam_Voice_Encoding_Clone"></a> Clone\(\)

```csharp
public CSteam_Voice_Encoding Clone()
```

#### Returns

 [CSteam\_Voice\_Encoding](Divine.Protobufs.Dota2.CSteam\_Voice\_Encoding.md)

### <a id="Divine_Protobufs_Dota2_CSteam_Voice_Encoding_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSteam_Voice_Encoding_Equals_Divine_Protobufs_Dota2_CSteam_Voice_Encoding_"></a> Equals\(CSteam\_Voice\_Encoding\)

```csharp
public bool Equals(CSteam_Voice_Encoding other)
```

#### Parameters

`other` [CSteam\_Voice\_Encoding](Divine.Protobufs.Dota2.CSteam\_Voice\_Encoding.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSteam_Voice_Encoding_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSteam_Voice_Encoding_MergeFrom_Divine_Protobufs_Dota2_CSteam_Voice_Encoding_"></a> MergeFrom\(CSteam\_Voice\_Encoding\)

```csharp
public void MergeFrom(CSteam_Voice_Encoding other)
```

#### Parameters

`other` [CSteam\_Voice\_Encoding](Divine.Protobufs.Dota2.CSteam\_Voice\_Encoding.md)

### <a id="Divine_Protobufs_Dota2_CSteam_Voice_Encoding_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSteam_Voice_Encoding_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSteam_Voice_Encoding_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

