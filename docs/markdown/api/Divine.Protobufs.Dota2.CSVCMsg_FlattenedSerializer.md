# <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer"></a> Class CSVCMsg\_FlattenedSerializer

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_FlattenedSerializer : IMessage<CSVCMsg_FlattenedSerializer>, IEquatable<CSVCMsg_FlattenedSerializer>, IDeepCloneable<CSVCMsg_FlattenedSerializer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_FlattenedSerializer](Divine.Protobufs.Dota2.CSVCMsg\_FlattenedSerializer.md)

#### Implements

IMessage<CSVCMsg\_FlattenedSerializer\>, 
[IEquatable<CSVCMsg\_FlattenedSerializer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_FlattenedSerializer\>, 
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
[EnumerableExtensions.In<CSVCMsg\_FlattenedSerializer\>\(CSVCMsg\_FlattenedSerializer, params CSVCMsg\_FlattenedSerializer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer__ctor"></a> CSVCMsg\_FlattenedSerializer\(\)

```csharp
public CSVCMsg_FlattenedSerializer()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer__ctor_Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_"></a> CSVCMsg\_FlattenedSerializer\(CSVCMsg\_FlattenedSerializer\)

```csharp
public CSVCMsg_FlattenedSerializer(CSVCMsg_FlattenedSerializer other)
```

#### Parameters

`other` [CSVCMsg\_FlattenedSerializer](Divine.Protobufs.Dota2.CSVCMsg\_FlattenedSerializer.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_CoordSizeParamsFieldNumber"></a> CoordSizeParamsFieldNumber

```csharp
public const int CoordSizeParamsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_FieldsFieldNumber"></a> FieldsFieldNumber

```csharp
public const int FieldsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_SerializersFieldNumber"></a> SerializersFieldNumber

```csharp
public const int SerializersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_SymbolsFieldNumber"></a> SymbolsFieldNumber

```csharp
public const int SymbolsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_CoordSizeParams"></a> CoordSizeParams

```csharp
public ProtoCoordSizeParams_t CoordSizeParams { get; set; }
```

#### Property Value

 [ProtoCoordSizeParams\_t](Divine.Protobufs.Dota2.ProtoCoordSizeParams\_t.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_Fields"></a> Fields

```csharp
public RepeatedField<ProtoFlattenedSerializerField_t> Fields { get; }
```

#### Property Value

 RepeatedField<[ProtoFlattenedSerializerField\_t](Divine.Protobufs.Dota2.ProtoFlattenedSerializerField\_t.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_FlattenedSerializer> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_FlattenedSerializer](Divine.Protobufs.Dota2.CSVCMsg\_FlattenedSerializer.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_Serializers"></a> Serializers

```csharp
public RepeatedField<ProtoFlattenedSerializer_t> Serializers { get; }
```

#### Property Value

 RepeatedField<[ProtoFlattenedSerializer\_t](Divine.Protobufs.Dota2.ProtoFlattenedSerializer\_t.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_Symbols"></a> Symbols

```csharp
public RepeatedField<string> Symbols { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_FlattenedSerializer Clone()
```

#### Returns

 [CSVCMsg\_FlattenedSerializer](Divine.Protobufs.Dota2.CSVCMsg\_FlattenedSerializer.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_Equals_Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_"></a> Equals\(CSVCMsg\_FlattenedSerializer\)

```csharp
public bool Equals(CSVCMsg_FlattenedSerializer other)
```

#### Parameters

`other` [CSVCMsg\_FlattenedSerializer](Divine.Protobufs.Dota2.CSVCMsg\_FlattenedSerializer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_"></a> MergeFrom\(CSVCMsg\_FlattenedSerializer\)

```csharp
public void MergeFrom(CSVCMsg_FlattenedSerializer other)
```

#### Parameters

`other` [CSVCMsg\_FlattenedSerializer](Divine.Protobufs.Dota2.CSVCMsg\_FlattenedSerializer.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FlattenedSerializer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

