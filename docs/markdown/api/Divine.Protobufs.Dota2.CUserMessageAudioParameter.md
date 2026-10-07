# <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter"></a> Class CUserMessageAudioParameter

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageAudioParameter : IMessage<CUserMessageAudioParameter>, IEquatable<CUserMessageAudioParameter>, IDeepCloneable<CUserMessageAudioParameter>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageAudioParameter](Divine.Protobufs.Dota2.CUserMessageAudioParameter.md)

#### Implements

IMessage<CUserMessageAudioParameter\>, 
[IEquatable<CUserMessageAudioParameter\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageAudioParameter\>, 
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
[EnumerableExtensions.In<CUserMessageAudioParameter\>\(CUserMessageAudioParameter, params CUserMessageAudioParameter\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter__ctor"></a> CUserMessageAudioParameter\(\)

```csharp
public CUserMessageAudioParameter()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter__ctor_Divine_Protobufs_Dota2_CUserMessageAudioParameter_"></a> CUserMessageAudioParameter\(CUserMessageAudioParameter\)

```csharp
public CUserMessageAudioParameter(CUserMessageAudioParameter other)
```

#### Parameters

`other` [CUserMessageAudioParameter](Divine.Protobufs.Dota2.CUserMessageAudioParameter.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_IntValueFieldNumber"></a> IntValueFieldNumber

```csharp
public const int IntValueFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_NameHashCodeFieldNumber"></a> NameHashCodeFieldNumber

```csharp
public const int NameHashCodeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_ParameterTypeFieldNumber"></a> ParameterTypeFieldNumber

```csharp
public const int ParameterTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_HasIntValue"></a> HasIntValue

```csharp
public bool HasIntValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_HasNameHashCode"></a> HasNameHashCode

```csharp
public bool HasNameHashCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_HasParameterType"></a> HasParameterType

```csharp
public bool HasParameterType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_IntValue"></a> IntValue

```csharp
public uint IntValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_NameHashCode"></a> NameHashCode

```csharp
public uint NameHashCode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_ParameterType"></a> ParameterType

```csharp
public uint ParameterType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageAudioParameter> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageAudioParameter](Divine.Protobufs.Dota2.CUserMessageAudioParameter.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_Value"></a> Value

```csharp
public float Value { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_ClearIntValue"></a> ClearIntValue\(\)

```csharp
public void ClearIntValue()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_ClearNameHashCode"></a> ClearNameHashCode\(\)

```csharp
public void ClearNameHashCode()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_ClearParameterType"></a> ClearParameterType\(\)

```csharp
public void ClearParameterType()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_Clone"></a> Clone\(\)

```csharp
public CUserMessageAudioParameter Clone()
```

#### Returns

 [CUserMessageAudioParameter](Divine.Protobufs.Dota2.CUserMessageAudioParameter.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_Equals_Divine_Protobufs_Dota2_CUserMessageAudioParameter_"></a> Equals\(CUserMessageAudioParameter\)

```csharp
public bool Equals(CUserMessageAudioParameter other)
```

#### Parameters

`other` [CUserMessageAudioParameter](Divine.Protobufs.Dota2.CUserMessageAudioParameter.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_MergeFrom_Divine_Protobufs_Dota2_CUserMessageAudioParameter_"></a> MergeFrom\(CUserMessageAudioParameter\)

```csharp
public void MergeFrom(CUserMessageAudioParameter other)
```

#### Parameters

`other` [CUserMessageAudioParameter](Divine.Protobufs.Dota2.CUserMessageAudioParameter.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageAudioParameter_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

